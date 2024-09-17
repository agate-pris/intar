use anyhow::Result;
use itertools::{izip, Itertools};
use log::error;
use smallvec::{smallvec, SmallVec};
use utility::{consts::*, find_root, Measures};

type K = SmallVec<[i32; 2]>;

const EXP: i32 = 15;

fn atan_p2(x: i32, k: &K) -> i32 {
    let k = k[0];
    const A: i32 = TWO_POW_15 >> 2;
    let y = TWO_POW_15 - x;
    let y = A + ((k * y) >> EXP);
    x * y
}

fn atan_p3(x: i32, k: &K) -> i32 {
    const A: i32 = TWO_POW_15 >> 2;
    let c = k[0];
    let b = k[1];
    let z = TWO_POW_15 - x;
    let y = b + ((c * x) >> EXP);
    let y = A + ((z * y) >> EXP);
    x * y
}

fn atan_p5(x: i32, k: &K) -> i32 {
    let c = k[0];
    let b = k[1];
    let a = (TWO_POW_15 >> 2) + k[1] - k[0];
    let z = (x * x) >> EXP;
    let y = b - ((c * z) >> EXP);
    let y = a - ((y * z) >> EXP);
    x * y
}

fn to_rad(x: i32) -> f64 {
    x as f64 * (std::f64::consts::PI / TWO_POW_30_AS_F64)
}

fn eval<F, K>(expected: &[f64], f: F, k: K) -> utility::Result<Measures>
where
    F: Fn(i32, K) -> i32,
    K: Copy,
{
    Measures::try_from(
        expected
            .iter()
            .enumerate()
            .map(|(x, &expected)| to_rad(f(x as i32, k)) - expected),
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
    const NAMES: [&str; 3] = ["Atan P2", "Atan P3", "Atan P5"];
    const F: [fn(i32, &K) -> i32; 3] = [atan_p2, atan_p3, atan_p5];
    const B: [[i32; 2]; 3] = [[2800, 3000], [2500, 2700], [2800, 3200]];
    let criterion = (0..=TWO_POW_15)
        .map(|x| (x as f64 / TWO_POW_15_AS_F64).atan())
        .collect::<Vec<_>>();
    let a: [SmallVec<[_; 1]>; 3] = [smallvec![], smallvec![600..=700], smallvec![700..=900]];

    #[rustfmt::skip]
    let expected: [Vec<Vec<(K, _)>>; 3] = [
        vec![vec![(smallvec![     2909], [2.427_818_463e-3, 2.077_174_29e-3, 4.491_925_80e-3, 0.333_347_37e-3])],
             vec![(smallvec![     2961], [2.595_716_871e-3, 1.982_912_10e-3, 5.184_662_78e-3, 1.164_232_39e-3])],
             vec![(smallvec![     2850], [2.635_112_959e-3, 2.368_024_60e-3, 3.767_039_33e-3, 0.609_359_21e-3])]],
        vec![vec![(smallvec![664, 2577], [1.049_134_615e-3, 0.939_676_02e-3, 1.714_716_72e-3, 0.325_335_31e-3])],
             vec![(smallvec![631, 2601], [1.062_183_213e-3, 0.932_879_30e-3, 1.920_656_59e-3, 0.445_237_61e-3])],
             vec![(smallvec![691, 2555], [1.064_113_944e-3, 0.960_337_16e-3, 1.527_843_83e-3, 0.189_503_94e-3])]],
        vec![vec![(smallvec![809, 2996], [0.491_372_789e-3, 0.439_212_06e-3, 0.909_806_77e-3, 0.156_463_49e-3])],
             vec![(smallvec![823, 3014], [0.497_432_099e-3, 0.436_286_57e-3, 1.030_130_37e-3, 0.172_414_19e-3])],
             vec![(smallvec![787, 2968], [0.505_815_786e-3, 0.455_372_26e-3, 0.752_340_43e-3, 0.124_505_16e-3])]],
    ];

    for (n, f, a, b, expected) in izip!(NAMES, F, a, B, expected) {
        println!("{n}");
        for (cmp, expected) in izip!(
            [
                Measures::rmse_total_cmp,
                Measures::mae_total_cmp,
                Measures::max_error_abs_total_cmp,
            ],
            expected
        ) {
            let results = find_root(|k| eval(&criterion, f, k), &a, b[0], b[1], cmp);
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
