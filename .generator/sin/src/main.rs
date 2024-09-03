macro_rules! sin_p5 {
    ($k: expr, $name: ident) => {
        fn $name(x: i32) -> i32 {
            const EXP: i32 = 15;
            const A: i32 = $k;
            const B: i32 = $k * 2 - 32768 * 5 / 2;
            const C: i32 = $k - 32768 * 3 / 2;
            let z = x * x >> EXP;
            let y = B - (C * z >> EXP);
            let y = A - (y * z >> EXP);
            y * x
        }
    };
}

macro_rules! sin_p5f {
    ($k: expr, $name: ident) => {
        fn $name(x: f64) -> f64 {
            const ONE: f64 = 32768.0;
            const A: f64 = $k;
            const B: f64 = $k * 2.0 - ONE * 2.5;
            const C: f64 = $k - ONE * 1.5;
            let z = x * x / ONE;
            let y = B - (C * z / ONE);
            let y = A - (y * z / ONE);
            y * x
        } 
    }
}

sin_p5!(51436, sin_p5_51436);
sin_p5!(51437, sin_p5_51437);
sin_p5f!(51436.540205645438220618274829932, sin_p5f_51436);

fn main() {
    let mut p: f64 = 0.0;
    let mut q: f64 = 0.0;
    let mut r: f64 = 0.0;
    let mut s: f64 = 0.0;
    let mut t: f64 = 0.0;
    let mut u: f64 = 0.0;
    for i in 0..=32768 {
        let a = sin_p5_51436(i);
        let b = sin_p5_51437(i);
        let c = sin_p5f_51436(i as f64);
        p = p.max(a as f64 - c);
        q = q.min(a as f64 - c);
        r = r.max(b as f64 - c);
        s = s.min(b as f64 - c);
        t += (a as f64 - c).powi(2);
        u += (b as f64 - c).powi(2);
    }
    println!("p: {}", p);
    println!("q: {}", q);
    println!("r: {}", r);
    println!("s: {}", s);
    println!("t: {}", (t / 32769.0).sqrt());
    println!("u: {}", (u / 32769.0).sqrt());
}
