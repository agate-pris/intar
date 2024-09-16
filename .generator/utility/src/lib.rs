use std::{cmp::Ordering, ops::RangeInclusive};

use itertools::Itertools;
use log::{debug, error, info};
use thiserror::Error;

pub mod consts {
    pub const TWO_POW_15: i32 = 1 << 15;
    pub const TWO_POW_30: i32 = 1 << 30;
    pub const TWO_POW_15_AS_F64: f64 = TWO_POW_15 as f64;
    pub const TWO_POW_30_AS_F64: f64 = TWO_POW_30 as f64;
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
        let (sqr_sum, abs_sum, max_error, sum) = iter.fold(
            (0.0, 0.0, 0.0_f64, 0.0),
            |(sqr_sum, abs_sum, max_error, sum), error| {
                (
                    sqr_sum + error.powi(2),
                    abs_sum + error.abs(),
                    if max_error.abs() < error.abs() {
                        error
                    } else {
                        max_error
                    },
                    sum + error,
                )
            },
        );
        Ok(Measures {
            rmse: (sqr_sum / len).sqrt(),
            mae: abs_sum / len,
            max_error,
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

pub fn find_root_ab<Eval, C>(eval: Eval, a: i32, b: i32, cmp: C) -> Result<Vec<(i32, Measures)>>
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

pub fn find_root_d2<Eval, C>(
    eval: Eval,
    a_range: &RangeInclusive<i32>,
    b_min: i32,
    b_max: i32,
    cmp: C,
) -> Result<Vec<((i32, i32), Measures)>>
where
    Eval: Fn(&(i32, i32)) -> Result<Measures>,
    C: Copy + Fn(&Measures, &Measures) -> Ordering,
{
    let opt_b_for_each_a = a_range
        .clone()
        .map(|a| {
            let root = find_root_ab(|b| eval(&(a, b)), b_min, b_max, cmp)?;
            debug!("a: {}, root: {:#?}", a, root);
            Ok((a, root))
        })
        .collect::<Result<Vec<_>>>()?;
    if let Some(first) = opt_b_for_each_a.first() {
        info!("first: {:?}", first);
    }
    if let Some(last) = opt_b_for_each_a.last() {
        info!("last: {:?}", last);
    }
    Ok(opt_b_for_each_a
        .into_iter()
        .flat_map(|(a, b)| b.into_iter().map(move |(b, measures)| ((a, b), measures)))
        .min_set_by(|a, b| cmp(&a.1, &b.1)))
}
