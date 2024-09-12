use anyhow::Result;
use utility::{consts::*, find_root_d2, Measures};

fn atan_p5(x: i32, k: &(i32, i32)) -> i32 {
    //const int a = 787;
    //const int b = 2968;
    //const int c = (1 << 13) + b - a;
    let a = k.0;
    let b = k.1;
    let c = (1 << 13) + k.1 - k.0;
    let z = (x * x) >> 15;
    let y = b - ((a * z) >> 15);
    let y = c - ((y * z) >> 15);
    y * x
}

fn to_rad(x: i32) -> f64 {
    x as f64 * std::f64::consts::PI / TWO_POW_30_AS_F64
}

fn main() -> Result<()> {
    let expected = (0..=TWO_POW_15)
        .map(|x| (x as f64 / TWO_POW_15_AS_F64).atan())
        .collect::<Vec<_>>();
    let a_range = 700..=900;
    let b_min = 2500;
    let b_max = 3500;
    let eval = |k: &(i32, i32)| {
        Measures::try_from(expected.iter().enumerate().map(|(x, &expected)| {
            let actual = atan_p5(x as i32, k);
            to_rad(actual) - expected
        }))
    };
    println!("atan_p5");
    let result = find_root_d2(&a_range, b_min, b_max, eval, Measures::rmse_total_cmp)?;
    println!("{:>9}: {:?}", "rmse", result);
    let result = find_root_d2(&a_range, b_min, b_max, eval, Measures::mae_total_cmp)?;
    println!("{:>9}: {:?}", "mae", result);
    let cmp = Measures::max_error_abs_total_cmp;
    let result = find_root_d2(&a_range, b_min, b_max, eval, cmp)?;
    println!("{:>9}: {:?}", "max error", result);
    Ok(())
}
