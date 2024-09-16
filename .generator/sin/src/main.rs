use anyhow::Result;
use itertools::{izip, Itertools};
use log::error;
use smallvec::{smallvec, SmallVec};
use utility::{consts::*, find_root_multi_dim, Measures};

type K = SmallVec<[i32; 1]>;

const EXP: i32 = 15;

fn sin_p4(x: i32, k: &K) -> i32 {
    let k = k[0];
    let a = k + TWO_POW_15;
    let b = k;
    let z = (x * x) >> EXP;
    let y = a - ((z * b) >> EXP);
    y * z
}

fn sin_p5(x: i32, k: &K) -> i32 {
    let k = k[0];
    let a = k;
    let b = k * 2 - TWO_POW_15 * 5 / 2;
    let c = k - TWO_POW_15 * 3 / 2;
    let z = (x * x) >> EXP;
    let y = b - ((z * c) >> EXP);
    let y = a - ((z * y) >> EXP);
    y * x
}

fn to_rad(x: i32) -> f64 {
    x as f64 * (std::f64::consts::FRAC_PI_2 / TWO_POW_15_AS_F64)
}

fn make_sin_expected() -> Vec<f64> {
    (0..=TWO_POW_15).map(|x| to_rad(x).sin()).collect()
}

fn make_cos_expected() -> Vec<f64> {
    (0..=TWO_POW_15).map(|x| 1.0 - to_rad(x).cos()).collect()
}

fn to_f64(x: i32) -> f64 {
    x as f64 / TWO_POW_30_AS_F64
}

fn eval<F>(expected: &[f64], f: F, k: &K) -> utility::Result<Measures>
where
    F: Fn(i32, &K) -> i32,
{
    Measures::try_from(
        expected
            .iter()
            .enumerate()
            .map(|(i, expected)| to_f64(f(i as i32, k)) - expected),
    )
}

fn test(expected: &(K, [f64; 4]), actual: &(K, Measures)) -> Result<()> {
    anyhow::ensure!(expected.0 == actual.0);
    anyhow::ensure!(
        Measures {
            rmse: expected.1[0],
            mae: expected.1[1],
            max_error: expected.1[2],
            me: expected.1[3],
        } > actual.1
    );
    Ok(())
}

fn main() {
    env_logger::init();
    const NAMES: [&str; 2] = ["Sin P4", "Sin P5"];
    const F: [fn(i32, &K) -> i32; 2] = [sin_p4, sin_p5];
    const B: [[i32; 2]; 2] = [[7300, 7400], [51400, 51500]];
    let criterion = [make_cos_expected(), make_sin_expected()];

    #[rustfmt::skip]
    let expected: [Vec<Vec<(K, _)>>; 2] = [
        vec![vec![(smallvec![ 7369], [6.023_564_4e-4, 5.158_339_05e-4, 1.090_161_042e-3, 0.734_394_9e_4])],
             vec![(smallvec![ 7394], [6.144_696_0e-4, 5.104_531_45e-4, 1.228_649_504e-3, 0.282_855_2e_4])],
             vec![(smallvec![ 7341], [6.176_454_6e-4, 5.350_726_79e-4, 0.948_007_656e-3, 1.873_568_3e_4])]],
        vec![vec![(smallvec![51438], [1.300_827_2e-4, 1.147_002_29e-4, 0.231_402_791e-3, 0.155_630_1e_4])],
             vec![(smallvec![51441], [1.313_057_1e-4, 1.138_984_57e-4, 0.247_365_117e-3, 0.307_664_6e_4])],
             vec![(smallvec![51432], [1.345_545_0e-4, 1.195_839_28e-4, 0.208_532_828e-3, 0.150_249_6e_4])]],
    ];

    for (n, f, criterion, b, expected) in izip!(NAMES, F, criterion, B, expected) {
        println!("{n}");
        for (cmp, expected) in izip!(
            [
                Measures::rmse_total_cmp,
                Measures::mae_total_cmp,
                Measures::max_error_abs_total_cmp,
            ],
            expected
        ) {
            let results = find_root_multi_dim(|k| eval(&criterion, f, k), &[], b[0], b[1], cmp);
            match results {
                Err(e) => error!("{e}"),
                Ok(results) => match results.len() {
                    0 => error!("empty reulsts"),
                    1 => {
                        let result = &results[0];
                        println!("{result:?}");
                        if let Err(e) = || -> Result<()> {
                            anyhow::ensure!(expected.len() == 1);
                            test(&expected[0], result)?;
                            Ok(())
                        }() {
                            error!("{e}");
                        };
                    }
                    _ => {
                        for (cmp, expected) in izip!(
                            [
                                Measures::rmse_total_cmp,
                                Measures::mae_total_cmp,
                                Measures::me_abs_total_cmp,
                            ],
                            expected
                        ) {
                            let results = results.iter().min_set_by(|a, b| cmp(&a.1, &b.1));
                            println!("{results:?}");
                            if let Err(e) = || -> Result<()> {
                                anyhow::ensure!(results.len() == 1);
                                test(&expected, results[0])?;
                                Ok(())
                            }() {
                                error!("{e}");
                            };
                        }
                    }
                },
            }
        }
    }
}
