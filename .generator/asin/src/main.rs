use anyhow::Result;
use itertools::{izip, Itertools};
use log::error;
use smallvec::{smallvec, SmallVec};
use utility::{consts::*, find_root_multi_dim, Measures};

type K = SmallVec<[i32; 3]>;

// 探索を容易にするためビットシフトを加減算より先に行う｡
// 探索を容易にするため定数項の内 1 つを固定する｡
// 副作用として x = 0 の時の返り値の値が丁度 0 になる｡
// (そのため､ 最後に x の符号を見て 0 なら 0 を乗算する必要が無くなる)
// -----------------------------------------------------

fn asin_2(x: i32, k: &K) -> i32 {
    let y = k[0] * x;
    let y = (k[1] - (y >> 15)) * x;
    let y = (TWO_POW_30 - y) >> 15;
    let y = ((TWO_POW_15 * (TWO_POW_15 - x)) as f64).sqrt() as i32 * y;
    TWO_POW_30 - y
}

fn asin_3(x: i32, k: &K) -> i32 {
    let y = k[0] * x;
    let y = (k[1] - (y >> 15)) * x;
    let y = (k[2] - (y >> 15)) * x;
    let y = (TWO_POW_30 - y) >> 15;
    let y = ((TWO_POW_15 * (TWO_POW_15 - x)) as f64).sqrt() as i32 * y;
    TWO_POW_30 - y
}

fn to_rad(x: i32) -> f64 {
    x as f64 * (std::f64::consts::FRAC_PI_2 / TWO_POW_30_AS_F64)
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
            .map(|(i, expected)| to_rad(f(i as i32, k)) - expected),
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
    const NAMES: [&str; 2] = ["Asin P2", "Asin P3"];
    const F: [fn(i32, &K) -> i32; 2] = [asin_2, asin_3];
    const B: [[i32; 2]; 2] = [[4200, 4400], [4000, 5000]];
    let criterion = (0..=TWO_POW_15)
        .map(|i| (i as f64 / TWO_POW_15_AS_F64).asin())
        .collect::<Vec<_>>();
    let a: [SmallVec<[_; 2]>; 2] = [smallvec![1000..=1200], smallvec![400..=500, 1500..=1700]];

    #[rustfmt::skip]
    let expected: [Vec<Vec<(K, _)>>; 2] = [
        vec![vec![(smallvec![     1103, 4313], [2.700_381_0e-4, 2.407_591_1e-4, 4.766_100_60e-4, 0.756_195_97e-4])],
             vec![(smallvec![     1100, 4308], [2.739_588_1e-4, 2.389_275_9e-4, 5.049_200_86e-4, 1.176_046_82e-4])],
             vec![(smallvec![     1112, 4322], [2.753_828_3e-4, 2.481_575_6e-4, 4.280_716_76e-4, 0.263_690_43e-4])]],
        vec![vec![(smallvec![425, 1589, 4435], [0.317_820_7e-4, 0.264_041_6e-4, 0.919_193_98e-4, 0.001_146_39e-4])],
             vec![(smallvec![428, 1591, 4435], [0.320_178_0e-4, 0.263_290_8e-4, 0.919_193_98e-4, 0.001_188_95e-4])],
             vec![(smallvec![432, 1597, 4437], [0.318_079_0e-4, 0.264_604_3e-4, 0.914_030_41e-4, 0.010_291_97e-4]),
                  (smallvec![430, 1594, 4436], [0.318_518_9e-4, 0.263_442_4e-4, 0.914_030_41e-4, 0.004_693_60e-4]),
                  (smallvec![440, 1606, 4439], [0.325_018_7e-4, 0.269_232_6e-4, 0.914_030_41e-4, 0.000_918_73e-4])]],
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
            let results = find_root_multi_dim(|k| eval(&criterion, f, k), &a, b[0], b[1], cmp);
            match results {
                Err(e) => error!("{e}"),
                Ok(results) => match results.len() {
                    0 => error!("empty reulsts"),
                    1 => {
                        println!("{:?}", results[0]);
                        if let Err(e) = || -> Result<()> {
                            anyhow::ensure!(expected.len() == 1);
                            test(&expected[0], &results[0])?;
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
