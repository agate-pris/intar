#![feature(f128)]

use std::{cmp::Ordering, cmp::PartialOrd, fmt::Display, ops::RangeInclusive};

use itertools::Itertools;
use log::{debug, error, info};
use rayon::prelude::*;
use smallvec::SmallVec;
use thiserror::Error;

pub mod consts {
    pub const TWO_POW_7: i16 = 1 << 7;
    pub const TWO_POW_14: i16 = 1 << 14;
    pub const TWO_POW_15: i32 = 1 << 15;
    pub const TWO_POW_30: i32 = 1 << 30;
    pub const TWO_POW_62: i64 = 1 << 62;
    pub const TWO_POW_14_AS_F64: f64 = TWO_POW_14 as f64;
    pub const TWO_POW_15_AS_F64: f64 = TWO_POW_15 as f64;
    pub const TWO_POW_30_AS_F64: f64 = TWO_POW_30 as f64;
    pub const TWO_POW_62_AS_F64: f64 = TWO_POW_62 as f64;
}

pub const fn powi(x: f128, n: i32) -> f128 {
    if n == 0 {
        1.0
    } else if n % 2 == 0 {
        powi(x * x, n / 2)
    } else {
        x * powi(x, n - 1)
    }
}

#[derive(Debug, Error)]
pub enum MeasuresError {
    #[error("{0} (expected: {1:?}, got: {2:?}, lhs: {3:?}, rhs: {4:?})")]
    UnexpectedComparison(&'static str, Ordering, Ordering, Measures, Measures),
    #[error("{0} (lhs: {1:?}, rhs: {2:?})")]
    ComparisonEquals(&'static str, Measures, Measures),
}

#[derive(Debug, Error)]
pub enum FindRootAbError {
    #[error("{0} is not less than {1}")]
    NotLess(i32, i32),
}

#[derive(Debug, Error)]
pub enum Error {
    #[error("empty iterator")]
    EmptyIterator,
    #[error("{0}")]
    EmptyOption(&'static str),
    #[error(transparent)]
    Measures(#[from] MeasuresError),
    #[error(transparent)]
    FindRootAb(#[from] FindRootAbError),
}

pub type Result<T> = std::result::Result<T, Error>;

#[derive(Clone, Debug)]
pub struct Measures {
    pub rmse: f64,
    pub mae: f64,
    pub max_error: f64,
    pub max_error_idx: usize,
    pub me: f64,
}

impl Measures {
    pub fn try_from<T>(iter: T) -> Result<Self>
    where
        T: ExactSizeIterator<Item = f64>,
    {
        let len = iter.len();
        if len == 0 {
            return Err(Error::EmptyIterator);
        }
        let len = len as f64;
        let (sqr_sum, abs_sum, max, idx, sum) = iter.enumerate().fold(
            (0.0, 0.0, 0.0_f64, 0_usize, 0.0),
            |(sqr_sum, abs_sum, max, idx, sum), (i, error)| {
                let (idx, max) = if max.abs() < error.abs() {
                    (i, error)
                } else {
                    (idx, max)
                };
                (
                    sqr_sum + error.powi(2),
                    abs_sum + error.abs(),
                    max,
                    idx,
                    sum + error,
                )
            },
        );
        Ok(Measures {
            rmse: (sqr_sum / len).sqrt(),
            mae: abs_sum / len,
            max_error: max,
            max_error_idx: idx,
            me: sum / len,
        })
    }

    pub fn rmse_total_cmp(&self, other: &Self) -> Ordering {
        self.rmse.total_cmp(&other.rmse)
    }
    pub fn mae_total_cmp(&self, other: &Self) -> Ordering {
        self.mae.total_cmp(&other.mae)
    }
    pub fn max_error_abs_total_cmp(&self, other: &Self) -> Ordering {
        self.max_error.abs().total_cmp(&other.max_error.abs())
    }
    pub fn me_abs_total_cmp(&self, other: &Self) -> Ordering {
        self.me.abs().total_cmp(&other.me.abs())
    }
}

impl Display for Measures {
    fn fmt(&self, f: &mut std::fmt::Formatter) -> std::fmt::Result {
        write!(
            f,
            "RMSE: {:13.10}, MAE: {:13.10}, Max Error: {:13.10} ({:5}), ME: {:12.5e}",
            self.rmse, self.mae, self.max_error, self.max_error_idx, self.me
        )
    }
}

impl PartialEq for Measures {
    fn eq(&self, other: &Self) -> bool {
        self.rmse == other.rmse
            && self.mae == other.mae
            && self.max_error == other.max_error
            && self.me == other.me
    }
}

impl PartialOrd for Measures {
    fn partial_cmp(&self, other: &Self) -> Option<Ordering> {
        match self.rmse.partial_cmp(&other.rmse) {
            Some(head) => {
                let tail = [
                    self.mae.partial_cmp(&other.mae),
                    self.max_error.abs().partial_cmp(&other.max_error.abs()),
                    self.me.abs().partial_cmp(&other.me.abs()),
                ];
                if tail.iter().all(|&x| x == Some(head)) {
                    Some(head)
                } else {
                    None
                }
            }
            None => None,
        }
    }
}

fn find_root_ab<Eval, C>(eval: Eval, a: i32, b: i32, cmp: C) -> Result<Vec<(i32, Measures)>>
where
    Eval: Fn(i32) -> Result<Measures>,
    C: Fn(&Measures, &Measures) -> Ordering,
{
    fn make_bc(a: i32, d: i32) -> (i32, i32) {
        let tmp = a + d;
        if tmp < 0 {
            let c = tmp / 2;
            (c - 1, c)
        } else {
            let b = tmp / 2;
            (b, b + 1)
        }
    }
    if a >= b {
        return Err(FindRootAbError::NotLess(a, b).into());
    }
    {
        let p = eval(a)?;
        let q = eval(a + 1)?;
        let ord = cmp(&p, &q);
        if ord != Ordering::Greater {
            error!("a: {}", a);
            return Err(MeasuresError::UnexpectedComparison(
                "f(a) > f(a + 1)",
                Ordering::Greater,
                ord,
                p,
                q,
            )
            .into());
        }
    }
    {
        let p = eval(b - 1)?;
        let q = eval(b)?;
        let ord = cmp(&p, &q);
        if ord != Ordering::Less {
            error!("b: {}", b);
            return Err(MeasuresError::UnexpectedComparison(
                "f(b - 1) < f(b)",
                Ordering::Less,
                ord,
                p,
                q,
            )
            .into());
        }
    }

    let mut a = a;
    let mut d = b;
    let (mut b, mut c) = make_bc(a, d);
    let mut p = eval(b)?;
    let mut q = eval(c)?;
    loop {
        let ord = cmp(&p, &q);
        match ord {
            Ordering::Equal => {
                let evaluated = (a..=d)
                    .map(|x| eval(x).map(|val| (x, val)))
                    .collect::<Result<Vec<_>>>()?;
                return Ok(evaluated.into_iter().min_set_by(|a, b| cmp(&a.1, &b.1)));
            }
            Ordering::Less => {
                if a == b {
                    return Ok(vec![(a, p)]);
                }
                d = b;
                (b, c) = make_bc(a, d);
            }
            Ordering::Greater => {
                if c == d {
                    return Ok(vec![(d, q)]);
                }
                a = c;
                (b, c) = make_bc(a, d);
            }
        }
        p = eval(b)?;
        q = eval(c)?;
    }
}

pub fn find_root<Eval, C, A>(
    eval: Eval,
    ranges: &[RangeInclusive<i32>],
    b_min: i32,
    b_max: i32,
    cmp: C,
) -> Result<Vec<(SmallVec<A>, Measures)>>
where
    Eval: Copy + Fn(&SmallVec<A>) -> Result<Measures> + Sync,
    C: Copy + Fn(&Measures, &Measures) -> Ordering + Sync,
    A: smallvec::Array<Item = i32>,
{
    fn rec<Eval, C, A>(
        eval: Eval,
        ranges: &[RangeInclusive<i32>],
        b_min: i32,
        b_max: i32,
        cmp: C,
        arg: &SmallVec<A>,
    ) -> Result<Vec<(SmallVec<A>, Measures)>>
    where
        Eval: Copy + Fn(&SmallVec<A>) -> Result<Measures> + Sync,
        C: Copy + Fn(&Measures, &Measures) -> Ordering + Sync,
        A: smallvec::Array<Item = i32>,
    {
        if let Some((first, rest)) = ranges.split_first() {
            let result = first
                .clone()
                .map(|x| {
                    let mut arg = arg.clone();
                    arg.push(x);
                    let result = rec(eval, rest, b_min, b_max, cmp, &arg);
                    if let Ok(result) = result.as_ref() {
                        if let Some(first) = result.first() {
                            info!("arg: {arg:?}, measures: {first:?}");
                        }
                        for item in result.iter().take(result.len() - 1).skip(1) {
                            debug!("arg: {arg:?}, measures: {item:?}");
                        }
                        if let Some(last) = result.last() {
                            info!("arg: {arg:?}, measures: {last:?}");
                        }
                    }
                    result
                })
                .collect::<Result<Vec<_>>>()?;
            let result = result
                .into_iter()
                .flatten()
                .min_set_by(|a, b| cmp(&a.1, &b.1));
            Ok(result)
        } else {
            let eval = |b| {
                let mut arg = arg.clone();
                arg.push(b);
                eval(&arg)
            };
            let root = find_root_ab(eval, b_min, b_max, cmp)?;
            let root = root
                .into_iter()
                .min_set_by(|a, b| cmp(&a.1, &b.1))
                .into_iter()
                .map(|(b, measures)| {
                    let mut arg = arg.clone();
                    arg.push(b);
                    (arg, measures)
                })
                .collect::<Vec<_>>();
            Ok(root)
        }
    }

    //一番最初の場合は Rayon で並列化する｡
    if let Some((first, rest)) = ranges.split_first() {
        let num_cpus = num_cpus::get();
        let result = (0..num_cpus)
            .into_par_iter()
            .map(|i| -> Result<_> {
                let range = {
                    let i = i as i32;
                    let num_cpus = num_cpus as i32;
                    let (p, q) = first.clone().into_inner();
                    let diff = q - p + 1;
                    let (p, q) = (p + diff * i / num_cpus, p + diff * (i + 1) / num_cpus);
                    p..q
                };
                let result = range
                    .map(|x| {
                        let arg = SmallVec::from_slice(&[x]);
                        rec(eval, rest, b_min, b_max, cmp, &arg)
                    })
                    .collect::<Result<Vec<_>>>()?;
                let result = result
                    .into_iter()
                    .flatten()
                    .min_set_by(|a, b| cmp(&a.1, &b.1));
                Ok(result)
            })
            .collect::<Result<Vec<_>>>()?;
        let result = result
            .into_iter()
            .flatten()
            .min_set_by(|a, b| cmp(&a.1, &b.1));
        Ok(result)
    } else {
        // 要素が空だった場合､ b_min と b_max の間で探索する｡
        let eval = |b| {
            let arg = SmallVec::from_slice(&[b]);
            eval(&arg)
        };
        find_root_ab(eval, b_min, b_max, cmp).map(|root| {
            root.into_iter()
                .map(|(b, measures)| (SmallVec::<A>::from_slice(&[b]), measures))
                .collect::<Vec<_>>()
        })
    }
}
