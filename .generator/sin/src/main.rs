use std::{f64::consts::FRAC_PI_2, ops::RangeInclusive};

use anyhow::Result;
use utility::{consts::*, find_root_ab};

const EXP: i32 = 15;

fn sin_p4(x: i32, k: i32) -> i32 {
    let a = k + TWO_POW_15;
    let b = k;
    let z = (x * x) >> EXP;
    let y = a - ((z * b) >> EXP);
    y * z
}

fn sin_p5(x: i32, k: i32) -> i32 {
    let a = k;
    let b = k * 2 - TWO_POW_15 * 5 / 2;
    let c = k - TWO_POW_15 * 3 / 2;
    let z = (x * x) >> EXP;
    let y = b - ((z * c) >> EXP);
    let y = a - ((z * y) >> EXP);
    y * x
}

fn to_rad(x: i32) -> f64 {
    x as f64 * (FRAC_PI_2 / TWO_POW_15_AS_F64)
}

fn make_sin_expected() -> Vec<f64> {
    (0..=TWO_POW_15).map(|x| to_rad(x).sin()).collect()
}

fn make_cos_expected() -> Vec<f64> {
    (0..=TWO_POW_15).map(|x| 1.0 - to_rad(x).cos()).collect()
}

#[derive(Clone, Debug, Default)]
pub struct Measures {
    pub k: i32,
    me: f64,
    mae: f64,
    rmse: f64,
    max_error: f64,
}

impl Measures {
    fn new<F>(k: i32, f: F, range: RangeInclusive<i32>, expected_table: &[f64]) -> Measures
    where
        F: Fn(i32, i32) -> f64,
    {
        let mut sum_error = 0.0;
        let mut sum_abs_error = 0.0;
        let mut sum_sqr_error = 0.0;
        let mut max_error = 0.0_f64;
        for x in range.clone() {
            let expected = expected_table[x as usize];
            let actual = f(x, k);
            let error = actual - expected;
            sum_error += error;
            sum_abs_error += error.abs();
            sum_sqr_error += error * error;
            if max_error.abs() < error.abs() {
                max_error = error;
            }
        }
        let count = range.count() as f64;
        Measures {
            k,
            me: sum_error / count,
            mae: sum_abs_error / count,
            rmse: (sum_sqr_error / count).sqrt(),
            max_error,
        }
    }
}

fn to_f64(x: i32) -> f64 {
    x as f64 / TWO_POW_30_AS_F64
}

fn main() -> Result<()> {
    let expected_1 = make_cos_expected();
    let expected_2 = make_sin_expected();
    let f1 = |k| {
        utility::Measures::try_from(
            expected_1
                .iter()
                .enumerate()
                .map(|(i, expected)| to_f64(sin_p4(i as i32, k)) - expected),
        )
    };
    let f2 = |k| {
        utility::Measures::try_from(
            expected_2
                .iter()
                .enumerate()
                .map(|(i, expected)| to_f64(sin_p5(i as i32, k)) - expected),
        )
    };
    let a1 = 6884;
    let b1 = 7884;
    let a2 = 50936;
    let b2 = 51936;
    println!("sin p4");
    let result = find_root_ab(f1, a1, b1, utility::Measures::rmse_total_cmp)?;
    println!("{:>9}: {:?}", "rmse", result);
    let result = find_root_ab(f1, a1, b1, utility::Measures::mae_total_cmp)?;
    println!("{:>9}: {:?}", "mae", result);
    let result = find_root_ab(f1, a1, b1, utility::Measures::max_error_abs_total_cmp)?;
    println!("{:>9}: {:?}", "max error", result);
    println!("sin p5");
    let result = find_root_ab(f2, a2, b2, utility::Measures::rmse_total_cmp)?;
    println!("{:>9}: {:?}", "rmse", result);
    let result = find_root_ab(f2, a2, b2, utility::Measures::mae_total_cmp)?;
    println!("{:>9}: {:?}", "mae", result);
    let result = find_root_ab(f2, a2, b2, utility::Measures::max_error_abs_total_cmp)?;
    println!("{:>9}: {:?}", "max error", result);
    Ok(())
}
