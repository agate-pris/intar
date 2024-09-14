use anyhow::Result;
use utility::{consts::*, find_root_ab, Measures};

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

fn eval<F, K>(expected: &[f64], f: F, k: K) -> utility::Result<Measures>
where
    F: Fn(i32, K) -> i32,
    K: Copy,
{
    Measures::try_from(
        expected
            .iter()
            .enumerate()
            .map(|(i, expected)| to_f64(f(i as i32, k)) - expected),
    )
}

fn main() -> Result<()> {
    env_logger::init();
    let expected = [make_cos_expected(), make_sin_expected()];
    let f = (
        |k| eval(&expected[0], sin_p4, k),
        |k| eval(&expected[1], sin_p5, k),
    );
    let a = ((6884, 7884), (50936, 51936));
    let cmp = (
        Measures::rmse_total_cmp,
        Measures::mae_total_cmp,
        Measures::max_error_abs_total_cmp,
    );

    let results = (
        || find_root_ab(f.0, a.0 .0, a.0 .1, cmp.0),
        || find_root_ab(f.0, a.0 .0, a.0 .1, cmp.1),
        || find_root_ab(f.0, a.0 .0, a.0 .1, cmp.2),
        || find_root_ab(f.1, a.1 .0, a.1 .1, cmp.0),
        || find_root_ab(f.1, a.1 .0, a.1 .1, cmp.1),
        || find_root_ab(f.1, a.1 .0, a.1 .1, cmp.2),
    );
    let names = ["rmse", "mae", "max error"];

    fn print(name: &str, result: (i32, Measures), i: usize) -> Result<()> {
        let expected = [7369, 7394, 7341, 51438, 51441, 51432];
        let acceptables = [
            [0.000603, 0.000516, 0.0000735, 0.00110],
            [0.000615, 0.000511, 0.0000283, 0.00123],
            [0.000618, 0.000536, 0.0001874, 0.00095],
            [0.000131, 0.000115, 0.0000156, 0.00024],
            [0.000132, 0.000114, 0.0000308, 0.00025],
            [0.000135, 0.000120, 0.0000151, 0.00021],
        ];
        println!("{:>9}: {:?}", name, result);
        anyhow::ensure!(result.0 == expected[i]);
        anyhow::ensure!(result.1.rmse < acceptables[i][0]);
        anyhow::ensure!(result.1.mae < acceptables[i][1]);
        anyhow::ensure!(result.1.me.abs() < acceptables[i][2]);
        anyhow::ensure!(result.1.max_error.abs() < acceptables[i][3]);
        Ok(())
    }

    println!("sin p4");
    print(names[0], results.0()?, 0)?;
    print(names[1], results.1()?, 1)?;
    print(names[2], results.2()?, 2)?;
    println!("sin p5");
    print(names[0], results.3()?, 3)?;
    print(names[1], results.4()?, 4)?;
    print(names[2], results.5()?, 5)?;

    Ok(())
}
