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
    //const int a = 787;
    //const int b = 2968;
    //const int c = (1 << 13) + b - a;
    let a = k.0;
    let b = k.1;
    let c = (1 << (EXP - 2)) + k.1 - k.0;
    let z = (x * x) >> EXP;
    let y = b - ((a * z) >> EXP);
    let y = c - ((y * z) >> EXP);
    y * x
}

fn to_rad(x: i32) -> f64 {
    x as f64 * std::f64::consts::PI / TWO_POW_30_AS_F64
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

    println!("atan p2");
    let result = find_root_ab(f.0, a.0 .0, a.0 .1, cmp.0)?;
    println!("{:>9}: {:?}", "rmse", result);
    let result = find_root_ab(f.0, a.0 .0, a.0 .1, cmp.1)?;
    println!("{:>9}: {:?}", "mae", result);
    let result = find_root_ab(f.0, a.0 .0, a.0 .1, cmp.2)?;
    println!("{:>9}: {:?}", "max error", result);

    println!("atan p3");
    let result = find_root_d2(&a.1 .0, a.1 .1, a.1 .2, f.1, cmp.0)?;
    println!("{:>9}: {:?}", "rmse", result);
    let result = find_root_d2(&a.1 .0, a.1 .1, a.1 .2, f.1, cmp.1)?;
    println!("{:>9}: {:?}", "mae", result);

    println!("atan p5");
    let result = find_root_d2(&a.2 .0, a.2 .1, a.2 .2, f.2, cmp.0)?;
    println!("{:>9}: {:?}", "rmse", result);
    let result = find_root_d2(&a.2 .0, a.2 .1, a.2 .2, f.2, cmp.1)?;
    println!("{:>9}: {:?}", "mae", result);
    let result = find_root_d2(&a.2 .0, a.2 .1, a.2 .2, f.2, cmp.2)?;
    println!("{:>9}: {:?}", "max error", result);

    Ok(())
}
