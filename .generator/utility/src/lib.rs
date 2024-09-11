use std::cmp::Ordering;

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
}

#[derive(Debug, Default)]
pub struct Statistics {
    pub max_flor_diff: f64,
    pub min_flor_diff: f64,
    pub max_ceil_diff: f64,
    pub min_ceil_diff: f64,
    pub max_flor_error: f64,
    pub max_ceil_error: f64,
    pub max_error: f64,
    pub sum_flor_diff_sqr: f64,
    pub sum_ceil_diff_sqr: f64,
    pub count: usize,
}

impl Statistics {
    pub fn new<A, B, C>(flor_func: A, ceil_func: B, func: C, x: i32, expected: f64) -> Statistics
    where
        A: Fn(i32) -> i32,
        B: Fn(i32) -> i32,
        C: Fn(f64) -> f64,
    {
        const K: f64 = 1.0 / (1 << 30) as f64;
        let a = flor_func(x) as f64;
        let b = ceil_func(x) as f64;
        let c = func(x as f64);
        let max_flor_diff = a - c;
        let max_ceil_diff = b - c;
        Statistics {
            max_flor_diff,
            min_flor_diff: max_flor_diff,
            max_ceil_diff,
            min_ceil_diff: max_ceil_diff,
            max_flor_error: (a * K - expected).abs(),
            max_ceil_error: (b * K - expected).abs(),
            max_error: (c * K - expected).abs(),
            sum_flor_diff_sqr: max_flor_diff.powi(2),
            sum_ceil_diff_sqr: max_ceil_diff.powi(2),
            count: 1,
        }
    }
    pub fn fold(&self, other: &Self) -> Statistics {
        Statistics {
            max_flor_diff: self.max_flor_diff.max(other.max_flor_diff),
            min_flor_diff: self.min_flor_diff.min(other.min_flor_diff),
            max_ceil_diff: self.max_ceil_diff.max(other.max_ceil_diff),
            min_ceil_diff: self.min_ceil_diff.min(other.min_ceil_diff),
            max_flor_error: self.max_flor_error.max(other.max_flor_error),
            max_ceil_error: self.max_ceil_error.max(other.max_ceil_error),
            max_error: self.max_error.max(other.max_error),
            sum_flor_diff_sqr: self.sum_flor_diff_sqr + other.sum_flor_diff_sqr,
            sum_ceil_diff_sqr: self.sum_ceil_diff_sqr + other.sum_ceil_diff_sqr,
            count: self.count + 1,
        }
    }
    pub fn flor_rmse(&self) -> f64 {
        (self.sum_flor_diff_sqr / self.count as f64).sqrt()
    }
    pub fn ceil_rmse(&self) -> f64 {
        (self.sum_ceil_diff_sqr / self.count as f64).sqrt()
    }
}
