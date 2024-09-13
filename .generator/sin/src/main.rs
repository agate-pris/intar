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

    println!("sin p4");
    let result = find_root_ab(f.0, a.0 .0, a.0 .1, cmp.0)?;
    println!("{:>9}: {:?}", "rmse", result);
    let result = find_root_ab(f.0, a.0 .0, a.0 .1, cmp.1)?;
    println!("{:>9}: {:?}", "mae", result);
    let result = find_root_ab(f.0, a.0 .0, a.0 .1, cmp.2)?;
    println!("{:>9}: {:?}", "max error", result);

    println!("sin p5");
    let result = find_root_ab(f.1, a.1 .0, a.1 .1, cmp.0)?;
    println!("{:>9}: {:?}", "rmse", result);
    let result = find_root_ab(f.1, a.1 .0, a.1 .1, cmp.1)?;
    println!("{:>9}: {:?}", "mae", result);
    let result = find_root_ab(f.1, a.1 .0, a.1 .1, cmp.2)?;
    println!("{:>9}: {:?}", "max error", result);

    Ok(())
}
