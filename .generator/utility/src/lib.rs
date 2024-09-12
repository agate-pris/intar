use std::{cmp::Ordering, ops::RangeInclusive};

use log::info;
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
    pub me: f64,
    pub max_error: f64,
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
        let (sqr_sum, abs_sum, sum, max_error) = iter.fold(
            (0.0, 0.0, 0.0, 0.0_f64),
            |(sqr_sum, abs_sum, sum, max_error), error| {
                (
                    sqr_sum + error.powi(2),
                    abs_sum + error.abs(),
                    sum + error,
                    if max_error.abs() < error.abs() {
                        error
                    } else {
                        max_error
                    },
                )
            },
        );
        Ok(Measures {
            rmse: (sqr_sum / len).sqrt(),
            mae: abs_sum / len,
            me: sum / len,
            max_error,
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
}

pub fn find_root_ab<F, C>(f: F, a: i32, b: i32, cmp: C) -> Result<(i32, Measures)>
where
    F: Fn(i32) -> Result<Measures>,
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
        let p = f(a)?;
        let q = f(a + 1)?;
        let ord = cmp(&p, &q);
        if ord != Ordering::Greater {
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
        let p = f(b - 1)?;
        let q = f(b)?;
        let ord = cmp(&p, &q);
        if ord != Ordering::Less {
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
    let mut p = f(b)?;
    let mut q = f(c)?;
    loop {
        let ord = cmp(&p, &q);
        match ord {
            Ordering::Equal => {
                return Err(MeasuresError::ComparisonEquals("p != q", p, q).into());
            }
            Ordering::Less => {
                if a == b {
                    return Ok((a, p));
                }
                d = b;
                (b, c) = make_bc(a, d);
            }
            Ordering::Greater => {
                if c == d {
                    return Ok((d, q));
                }
                a = c;
                (b, c) = make_bc(a, d);
            }
        }
        p = f(b)?;
        q = f(c)?;
    }
}

pub fn find_root_d2<Eval, C>(
    a_range: &RangeInclusive<i32>,
    b_min: i32,
    b_max: i32,
    eval: Eval,
    cmp: C,
) -> Result<(i32, i32, Measures)>
where
    Eval: Fn(&(i32, i32)) -> Result<Measures>,
    C: Copy + Fn(&Measures, &Measures) -> Ordering,
{
    let opt_b_for_each_a = a_range
        .clone()
        .map(|a| {
            let root = find_root_ab(|b| eval(&(a, b)), b_min, b_max, cmp)?;
            info!("a: {}, b: {}, measures: {:#?}", a, root.0, root.1);
            Ok((a, root.0, root.1))
        })
        .collect::<Result<Vec<_>>>()?;
    if let Some(first) = opt_b_for_each_a.first() {
        println!("first: {:#?}", first);
    }
    if let Some(last) = opt_b_for_each_a.last() {
        println!("last: {:#?}", last);
    }
    let answer = opt_b_for_each_a.iter().min_by(|a, b| cmp(&a.2, &b.2));
    answer.cloned().ok_or(Error::EmptyOption("answer"))
}
