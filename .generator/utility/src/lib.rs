use std::f64::consts::FRAC_PI_2;

pub mod consts {
    pub const TWO_POW_15: i32 = 1 << 15;
    pub const TWO_POW_30: i32 = 1 << 30;
    pub const TWO_POW_15_AS_F64: f64 = TWO_POW_15 as f64;
    pub const TWO_POW_30_AS_F64: f64 = TWO_POW_30 as f64;
}

#[derive(Clone, Debug)]
pub struct Measures {
    pub rmse: f64,
    pub mae: f64,
    pub me: f64,
    pub max_error: f64,
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

pub const RIGHT_EXP: i32 = 15;
pub const RIGHT: i32 = 1 << RIGHT_EXP;
pub const RIGHT_AS_F64: f64 = RIGHT as f64;

pub fn to_rad(x: i32) -> f64 {
    (x as f64) / RIGHT_AS_F64 * FRAC_PI_2
}
