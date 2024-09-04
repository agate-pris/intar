use utility::{to_rad, Statistics, RIGHT, RIGHT_AS_F64, RIGHT_EXP};

macro_rules! sin_p4 {
    ($k: expr, $name: ident) => {
        fn $name(x: i32) -> i32 {
            const A: i32 = $k + RIGHT;
            const B: i32 = $k;
            let z = x * x >> RIGHT_EXP;
            let y = A - (z * B >> RIGHT_EXP);
            y * z
        }
    };
}

macro_rules! sin_p4f {
    ($k: expr, $name: ident) => {
        fn $name(x: f64) -> f64 {
            const A: f64 = $k + RIGHT_AS_F64;
            const B: f64 = $k;
            let z = x * x / RIGHT_AS_F64;
            let y = A - z * B / RIGHT_AS_F64;
            y * z
        }
    };
}

sin_p4!(7372, sin_p4_7372);
sin_p4!(7373, sin_p4_7373);
sin_p4!(7384, sin_p4_7384);
sin_p4!(7385, sin_p4_7385);
sin_p4f!(7372.8, sin_p4f_7372);
sin_p4f!(7384.324742943203, sin_p4f_7384);

macro_rules! sin_p5 {
    ($k: expr, $name: ident) => {
        fn $name(x: i32) -> i32 {
            const EXP: i32 = 15;
            const A: i32 = $k;
            const B: i32 = $k * 2 - RIGHT * 5 / 2;
            const C: i32 = $k - RIGHT * 3 / 2;
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
            const ONE: f64 = RIGHT_AS_F64;
            const A: f64 = $k;
            const B: f64 = $k * 2.0 - ONE * 2.5;
            const C: f64 = $k - ONE * 1.5;
            let z = x * x / ONE;
            let y = B - C * z / ONE;
            let y = A - y * z / ONE;
            y * x
        }
    };
}

sin_p5!(51436, sin_p5_51436);
sin_p5!(51437, sin_p5_51437);
sin_p5f!(51436.540205645438220618274829932, sin_p5f_51436);

fn main() {
    let mut statistics: [Statistics; 3] = Default::default();
    for x in 0..=RIGHT {
        let rad = to_rad(x);
        let sin_expected = rad.sin();
        let cos_expected = 1.0 - rad.cos();
        let s = [
            Statistics::new(sin_p4_7372, sin_p4_7373, sin_p4f_7372, x, cos_expected),
            Statistics::new(sin_p4_7384, sin_p4_7385, sin_p4f_7384, x, cos_expected),
            Statistics::new(sin_p5_51436, sin_p5_51437, sin_p5f_51436, x, sin_expected),
        ];
        for (a, b) in statistics.iter_mut().zip(s.iter()) {
            *a = a.fold(b);
        }
    }
    for s in statistics {
        println!("s: {:#?}", s);
        println!("flor_rmse: {}", s.flor_rmse());
        println!("ceil_rmse: {}", s.ceil_rmse());
    }
}
