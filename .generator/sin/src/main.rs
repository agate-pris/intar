use std::ops::RangeInclusive;

use utility::{to_rad, RIGHT, RIGHT_AS_F64, RIGHT_EXP};

fn sin_p4(x: i32, k: i32) -> i32 {
    let a = k + RIGHT;
    let b = k;
    let z = (x * x) >> RIGHT_EXP;
    let y = a - ((z * b) >> RIGHT_EXP);
    y * z
}

fn sin_p5(x: i32, k: i32) -> i32 {
    let a = k;
    let b = k * 2 - RIGHT * 5 / 2;
    let c = k - RIGHT * 3 / 2;
    let z = (x * x) >> RIGHT_EXP;
    let y = b - ((z * c) >> RIGHT_EXP);
    let y = a - ((z * y) >> RIGHT_EXP);
    y * x
}

fn make_sin_expected() -> Vec<f64> {
    (0..=RIGHT).map(|x| to_rad(x).sin()).collect()
}

fn make_cos_expected() -> Vec<f64> {
    (0..=RIGHT).map(|x| 1.0 - to_rad(x).cos()).collect()
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
            let error = actual as f64 - expected;
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

#[derive(Debug, Default)]
pub struct Statistics {
    pub min_me: Vec<Measures>,
    pub min_mae: Vec<Measures>,
    pub min_rmse: Vec<Measures>,
    pub min_max_error: Vec<Measures>,
}

impl TryFrom<&[Measures]> for Statistics {
    type Error = &'static str;
    fn try_from(value: &[Measures]) -> Result<Self, Self::Error> {
        if value.len() > 2 {
            let mut min_me = vec![value[0].clone()];
            let mut min_mae = min_me.clone();
            let mut min_rmse = min_me.clone();
            let mut min_max_error = min_me.clone();
            if value[0].me.abs() > value[1].me.abs() {
                min_me.clear();
                min_me.push(value[1].clone());
            } else if value[0].me.abs() < value[1].me.abs() {
                return Err("me unexpectedly increased");
            } else {
                min_me.push(value[1].clone());
            };
            if value[0].mae > value[1].mae {
                min_mae.clear();
                min_mae.push(value[1].clone());
            } else if value[0].mae < value[1].mae {
                return Err("mae unexpectedly increased");
            } else {
                min_mae.push(value[1].clone());
            };
            if value[0].rmse > value[1].rmse {
                min_rmse.clear();
                min_rmse.push(value[1].clone());
            } else if value[0].rmse < value[1].rmse {
                return Err("rmse unexpectedly increased");
            } else {
                min_rmse.push(value[1].clone());
            };
            if value[0].max_error.abs() > value[1].max_error.abs() {
                min_max_error.clear();
                min_max_error.push(value[1].clone());
            } else if value[0].max_error.abs() < value[1].max_error.abs() {
                return Err("max_error unexpectedly increased");
            } else {
                min_max_error.push(value[1].clone());
            };
            let mut me_flag = false;
            let mut mae_flag = false;
            let mut rmse_flag = false;
            let mut max_error_flag = false;
            for measures in value.iter().skip(2) {
                if min_me[0].me.abs() == measures.me.abs() {
                    min_me.push(measures.clone());
                } else if me_flag {
                    if min_me[0].me.abs() > measures.me.abs() {
                        return Err("me unexpectedly increased");
                    }
                } else if min_me[0].me.abs() > measures.me.abs() {
                    min_me.clear();
                    min_me.push(measures.clone());
                } else if min_me[0].me.abs() < measures.me.abs() {
                    me_flag = true;
                }
                if min_mae[0].mae == measures.mae {
                    min_mae.push(measures.clone());
                } else if mae_flag {
                    if min_mae[0].mae > measures.mae {
                        return Err("mae unexpectedly increased");
                    }
                } else if min_mae[0].mae > measures.mae {
                    min_mae.clear();
                    min_mae.push(measures.clone());
                } else if min_mae[0].mae < measures.mae {
                    mae_flag = true;
                }
                if min_rmse[0].rmse == measures.rmse {
                    min_rmse.push(measures.clone());
                } else if rmse_flag {
                    if min_rmse[0].rmse > measures.rmse {
                        return Err("rmse unexpectedly increased");
                    }
                } else if min_rmse[0].rmse > measures.rmse {
                    min_rmse.clear();
                    min_rmse.push(measures.clone());
                } else if min_rmse[0].rmse < measures.rmse {
                    rmse_flag = true;
                }
                if min_max_error[0].max_error.abs() == measures.max_error.abs() {
                    min_max_error.push(measures.clone());
                } else if max_error_flag {
                    if min_max_error[0].max_error.abs() > measures.max_error.abs() {
                        return Err("max_error unexpectedly increased");
                    }
                } else if min_max_error[0].max_error.abs() > measures.max_error.abs() {
                    min_max_error.clear();
                    min_max_error.push(measures.clone());
                } else if min_max_error[0].max_error.abs() < measures.max_error.abs() {
                    max_error_flag = true;
                }
            }
            Ok(Statistics {
                min_me,
                min_mae,
                min_rmse,
                min_max_error,
            })
        } else {
            Err("not implemented")
        }
    }
}

fn find_zero_mean_error<F>(range: RangeInclusive<i32>, expected_table: &[f64], f: F)
where
    F: Copy + Fn(i32, i32) -> f64,
{
    let all_measures = range
        .map(|k| Measures::new(k, f, 0..=RIGHT, expected_table))
        .collect::<Vec<_>>();
    let s = Statistics::try_from(&all_measures[..]);
    println!("{:#?}", s);
}

fn main() {
    let expected_table = make_cos_expected();
    find_zero_mean_error(6884..=7884, &expected_table, |x, k| {
        sin_p4(x, k) as f64 / RIGHT_AS_F64 / RIGHT_AS_F64
    });
    let expected_table = make_sin_expected();
    find_zero_mean_error(50936..=51936, &expected_table, |x, k| {
        sin_p5(x, k) as f64 / RIGHT_AS_F64 / RIGHT_AS_F64
    });
}
