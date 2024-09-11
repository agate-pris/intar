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
    println!("# atan_p5\n");
    println!("## RMSE\n");
    let eval = |k: &(i32, i32)| {
        Measures::try_from(expected.iter().enumerate().map(|(x, &expected)| {
            let actual = atan_p5(x as i32, k);
            to_rad(actual) - expected
        }))
    };
    let rmse = find_root_d2(&a_range, b_min, b_max, eval, |a, b| {
        a.rmse.total_cmp(&b.rmse)
    })?;
    println!("{:#?}", rmse);
    println!("\n## MAE\n");
    let mae = find_root_d2(&a_range, b_min, b_max, eval, |a, b| a.mae.total_cmp(&b.mae))?;
    println!("{:#?}", mae);
    println!("\n## Max Error\n");
    let max_error = find_root_d2(&a_range, b_min, b_max, eval, |a, b| {
        a.max_error.abs().total_cmp(&b.max_error.abs())
    })?;
    println!("{:#?}", max_error);
    Ok(())
}
