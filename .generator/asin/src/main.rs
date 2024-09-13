use std::cmp::Ordering;

use anyhow::Result;
use itertools::Itertools;
use log::error;
use smallvec::SmallVec;
use utility::{
    consts::{TWO_POW_15, TWO_POW_15_AS_F64, TWO_POW_30, TWO_POW_30_AS_F64},
    find_root_multi_dim, Measures,
};

// 探索を容易にするためビットシフトを加減算より先に行う｡
// 探索を容易にするため定数項の内 1 つを固定する｡
// 副作用として x = 0 の時の返り値の値が丁度 0 になる｡
// (そのため､ 最後に x の符号を見て 0 なら 0 を乗算する必要が無くなる)
// -----------------------------------------------------

fn asin_2(x: i32, k: &[i32; 2]) -> i32 {
    let y = k[0] * x;
    let y = (k[1] - (y >> 15)) * x;
    let y = (TWO_POW_30 - y) >> 15;
    let y = ((TWO_POW_15 * (TWO_POW_15 - x)) as f64).sqrt() as i32 * y;
    TWO_POW_30 - y
}

fn asin_3(x: i32, k: &[i32; 3]) -> i32 {
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

fn main() -> Result<()> {
    env_logger::init();
    let expected = (0..=TWO_POW_15)
        .map(|i| (i as f64 / TWO_POW_15_AS_F64).asin())
        .collect::<Vec<_>>();
    let cmp = (
        Measures::rmse_total_cmp,
        Measures::mae_total_cmp,
        Measures::max_error_abs_total_cmp,
        Measures::me_abs_total_cmp,
    );
    let e = (
        |k: &SmallVec<[i32; 3]>| eval(&expected, asin_2, &[k[0], k[1]]),
        |k: &SmallVec<[i32; 3]>| eval(&expected, asin_3, &[k[0], k[1], k[2]]),
    );
    let a = (
        ([1000..=1200], 4200, 4400),
        ([400..=500, 1500..=1700], 4000, 5000),
    );
    let results = (
        || find_root_multi_dim(e.0, &a.0 .0, a.0 .1, a.0 .2, cmp.0),
        || find_root_multi_dim(e.0, &a.0 .0, a.0 .1, a.0 .2, cmp.1),
        || find_root_multi_dim(e.0, &a.0 .0, a.0 .1, a.0 .2, cmp.2),
        || find_root_multi_dim(e.1, &a.1 .0, a.1 .1, a.1 .2, cmp.0),
        || find_root_multi_dim(e.1, &a.1 .0, a.1 .1, a.1 .2, cmp.1),
        || find_root_multi_dim(e.1, &a.1 .0, a.1 .1, a.1 .2, cmp.2),
    );
    let names = ["rmse", "mae", "max error"];

    type K = SmallVec<[i32; 3]>;
    type Expected = (Option<fn(&Measures, &Measures) -> Ordering>, K, [f64; 4]);

    fn print(
        name: &str,
        result: &Vec<(SmallVec<[i32; 3]>, Measures)>,
        expected: &[Expected],
    ) -> Result<()> {
        println!("{name}:");

        for (cmp, expected, acceptable) in expected {
            if let Some(cmp) = cmp {
                let actual = result.iter().min_set_by(|(_, a), (_, b)| cmp(a, b));
                for (actual, measures) in actual {
                    println!("{actual:?}: {measures:?}");
                    anyhow::ensure!(expected == actual);
                    anyhow::ensure!(measures.rmse < acceptable[0]);
                    anyhow::ensure!(measures.mae < acceptable[1]);
                    anyhow::ensure!(measures.me.abs() < acceptable[2]);
                    anyhow::ensure!(measures.max_error.abs() < acceptable[3]);
                }
            } else {
                for (actual, measures) in result {
                    println!("{actual:?}: {measures:?}");
                    anyhow::ensure!(expected == actual);
                    anyhow::ensure!(measures.rmse < acceptable[0]);
                    anyhow::ensure!(measures.mae < acceptable[1]);
                    anyhow::ensure!(measures.me.abs() < acceptable[2]);
                    anyhow::ensure!(measures.max_error.abs() < acceptable[3]);
                }
            }
        }

        Ok(())
    }

    let expected = [
        K::from_slice(&[1103, 4313]),
        K::from_slice(&[1100, 4308]),
        K::from_slice(&[1112, 4322]),
        K::from_slice(&[425, 1589, 4435]),
        K::from_slice(&[428, 1591, 4435]),
        K::from_slice(&[432, 1597, 4437]),
        K::from_slice(&[430, 1594, 4436]),
        K::from_slice(&[440, 1606, 4439]),
    ];
    let expected_measures = [
        [0.0002700381, 0.0002407592, 0.0000756196, 0.0004766101],
        [0.0002739589, 0.0002389276, 0.0001176047, 0.0005049201],
        [0.0002753829, 0.0002481576, 0.0000263691, 0.0004280717],
        [0.0000317827, 0.0000264042, 0.0000001147, 0.0000919194],
        [0.0000320178, 0.0000263291, 0.0000001189, 0.0000919194],
        [0.0000318079, 0.0000264605, 0.0000010292, 0.0000914031],
        [0.0000318519, 0.0000263443, 0.0000004694, 0.0000914031],
        [0.0000325019, 0.0000269233, 0.0000000919, 0.0000914031],
    ];
    let expected: Vec<Vec<Expected>> = vec![
        vec![(None, expected[0].clone(), expected_measures[0])],
        vec![(None, expected[1].clone(), expected_measures[1])],
        vec![(None, expected[2].clone(), expected_measures[2])],
        vec![(None, expected[3].clone(), expected_measures[3])],
        vec![(None, expected[4].clone(), expected_measures[4])],
        vec![
            (Some(cmp.0), expected[5].clone(), expected_measures[5]),
            (Some(cmp.1), expected[6].clone(), expected_measures[6]),
            (Some(cmp.3), expected[7].clone(), expected_measures[7]),
        ],
    ];

    let results = [
        print(names[0], &results.0()?, &expected[0]),
        print(names[1], &results.1()?, &expected[1]),
        print(names[2], &results.2()?, &expected[2]),
        print(names[0], &results.3()?, &expected[3]),
        print(names[1], &results.4()?, &expected[4]),
        print(names[2], &results.5()?, &expected[5]),
    ];
    for result in results {
        if let Err(e) = result {
            error!("{:?}", e);
        }
    }

    Ok(())
}
