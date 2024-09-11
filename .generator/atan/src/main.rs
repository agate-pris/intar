use std::{cmp::Ordering, ops::RangeInclusive, sync::LazyLock};

use anyhow::Result;
use clap::Parser;
use utility::{consts::*, Measures};

#[derive(Debug, Parser)]
struct Args {
    verbose: bool,
}

static ARGS: LazyLock<Args> = std::sync::LazyLock::new(Args::parse);

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

fn take_atan_p5_statistics(k: &(i32, i32), expected: &[f64]) -> Measures {
    let range = 0..=32768;
    let count = range.clone().count() as f64;
    let (sqr_sum, abs_sum, sum, max_error) = range.into_iter().fold(
        (0.0, 0.0, 0.0, 0.0_f64),
        |(sqr_sum, abs_sum, sum, max_error), x| {
            let actual = to_rad(atan_p5(x, k));
            let error = actual - expected[x as usize];
            (
                sqr_sum + error.powi(2),
                abs_sum + error.abs(),
                sum + error,
                if max_error.abs() < error.abs() {
                    error
                } else {
                    max_error
                },
            )
        },
    );
    Measures {
        rmse: (sqr_sum / count).sqrt(),
        mae: abs_sum / count,
        me: sum / count,
        max_error,
    }
}

fn find_root_ab<F, C>(f: F, a: i32, b: i32, cmp: C) -> Result<(i32, Measures)>
where
    F: Fn(i32) -> Result<Measures>,
    C: Fn(&Measures, &Measures) -> Ordering,
{
    fn make_bc(a: i32, d: i32) -> (i32, i32) {
        let tmp = a + d;
        if tmp < 0 {
            let c = tmp / 2;
            (c - 1, c)
        } else {
            let b = tmp / 2;
            (b, b + 1)
        }
    }
    anyhow::ensure!(a < b);
    anyhow::ensure!(cmp(&f(a)?, &f(a + 1)?) == Ordering::Greater);
    anyhow::ensure!(cmp(&f(b - 1)?, &f(b)?) == Ordering::Less);

    let mut a = a;
    let mut d = b;
    let (mut b, mut c) = make_bc(a, d);
    let mut p = f(b)?;
    let mut q = f(c)?;
    loop {
        let ord = cmp(&p, &q);
        match ord {
            Ordering::Equal => anyhow::bail!("p: {:#?}, q: {:#?}", p, q),
            Ordering::Less => {
                if a + 1 == b {
                    return Ok((a, p));
                }
                d = c;
                (b, c) = make_bc(a, d);
            }
            Ordering::Greater => {
                if a + 1 == b {
                    return Ok((b, q));
                }
                a = b;
                (b, c) = make_bc(a, d);
            }
        }
        p = f(b)?;
        q = f(c)?;
    }
}

fn find_root_d2<Eval, C>(
    a_range: &RangeInclusive<i32>,
    b_min: i32,
    b_max: i32,
    eval: Eval,
    cmp: C,
) -> Result<(i32, i32, Measures)>
where
    Eval: Fn(&(i32, i32)) -> Result<Measures>,
    C: Copy + Fn(&Measures, &Measures) -> Ordering,
{
    let verbose = ARGS.verbose;
    let opt_b_for_each_a = a_range
        .clone()
        .map(|a| {
            let root = find_root_ab(|b| eval(&(a, b)), b_min, b_max, cmp);
            if verbose {
                if let Ok(b) = &root {
                    println!("a: {}, b: {}, measures: {:#?}", a, b.0, b.1);
                }
            }
            root.map(|root| (a, root.0, root.1))
        })
        .collect::<Result<Vec<_>>>()?;
    if let Some(first) = opt_b_for_each_a.first() {
        println!("first: {:#?}", first);
    }
    if let Some(last) = opt_b_for_each_a.last() {
        println!("last: {:#?}", last);
    }
    let answer = opt_b_for_each_a.iter().min_by(|a, b| cmp(&a.2, &b.2));
    anyhow::ensure!(answer.is_some());
    Ok(answer.unwrap().clone())
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
    let eval = |k: &(i32, i32)| Ok(take_atan_p5_statistics(k, &expected));
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
