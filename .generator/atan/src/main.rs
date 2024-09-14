use std::fmt::Debug;

use anyhow::Result;
use utility::{consts::*, find_root_ab, find_root_d2, Measures};

const EXP: i32 = 15;

fn atan_p2(x: i32, k: i32) -> i32 {
    let y = TWO_POW_15 - x;
    let y = (1 << (EXP - 2)) + ((y * k) >> EXP);
    y * x
}

fn atan_p3(x: i32, k: &(i32, i32)) -> i32 {
    let y = (x * k.1) >> 15;
    let y = (TWO_POW_15 - x) * (k.0 + y);
    let y = (TWO_POW_15 >> 2) + (y >> 15);
    x * y
}

fn atan_p5(x: i32, k: &(i32, i32)) -> i32 {
    let a = k.0;
    let b = k.1;
    let c = (1 << (EXP - 2)) + k.1 - k.0;
    let z = (x * x) >> EXP;
    let y = b - ((a * z) >> EXP);
    let y = c - ((y * z) >> EXP);
    y * x
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

fn main() -> Result<()> {
    env_logger::init();
    let expected = (0..=TWO_POW_15)
        .map(|x| (x as f64 / TWO_POW_15_AS_F64).atan())
        .collect::<Vec<_>>();
    let f = (
        |k| eval(&expected, atan_p2, k),
        |k: &(i32, i32)| eval(&expected, atan_p3, k),
        |k: &(i32, i32)| eval(&expected, atan_p5, k),
    );
    let a = (
        (2800, 3000),
        (2400..=2700, 400, 1000),
        (700..=900, 2500, 3500),
    );
    let cmp = (
        Measures::rmse_total_cmp,
        Measures::mae_total_cmp,
        Measures::max_error_abs_total_cmp,
    );
    let results = (
        || find_root_ab(f.0, a.0 .0, a.0 .1, cmp.0),
        || find_root_ab(f.0, a.0 .0, a.0 .1, cmp.1),
        || find_root_ab(f.0, a.0 .0, a.0 .1, cmp.2),
        || find_root_d2(f.1, &a.1 .0, a.1 .1, a.1 .2, cmp.0),
        || find_root_d2(f.1, &a.1 .0, a.1 .1, a.1 .2, cmp.1),
        || find_root_d2(f.2, &a.2 .0, a.2 .1, a.2 .2, cmp.0),
        || find_root_d2(f.2, &a.2 .0, a.2 .1, a.2 .2, cmp.1),
        || find_root_d2(f.2, &a.2 .0, a.2 .1, a.2 .2, cmp.2),
    );
    let names = ["rmse", "mae", "max error"];

    fn print<T>(name: &str, result: (T, Measures), expected: &T, i: usize) -> Result<()>
    where
        T: Debug + PartialEq,
    {
        let acceptables = [
            [0.002428, 0.002078, 0.00034, 0.00450],
            [0.002596, 0.001983, 0.00117, 0.00519],
            [0.002636, 0.002369, 0.00061, 0.00377],
            [0.001050, 0.000940, 0.00033, 0.00172],
            [0.001063, 0.000933, 0.00045, 0.00193],
            [0.000492, 0.000440, 0.00016, 0.00091],
            [0.000498, 0.000437, 0.00018, 0.00104],
            [0.000506, 0.000456, 0.00013, 0.00076],
        ];
        println!("{:>9}: {:?}", name, result);
        anyhow::ensure!(result.0 == *expected);
        anyhow::ensure!(result.1.rmse < acceptables[i][0]);
        anyhow::ensure!(result.1.mae < acceptables[i][1]);
        anyhow::ensure!(result.1.me.abs() < acceptables[i][2]);
        anyhow::ensure!(result.1.max_error.abs() < acceptables[i][3]);
        Ok(())
    }

    println!("atan p2");
    print(names[0], results.0()?, &2909, 0)?;
    print(names[1], results.1()?, &2961, 1)?;
    print(names[2], results.2()?, &2850, 2)?;
    println!("atan p3");
    print(names[0], results.3()?, &(2577, 664), 3)?;
    print(names[1], results.4()?, &(2601, 631), 4)?;
    println!("atan p5");
    print(names[0], results.5()?, &(809, 2996), 5)?;
    print(names[1], results.6()?, &(823, 3014), 6)?;
    print(names[2], results.7()?, &(787, 2968), 7)?;

    Ok(())
}
