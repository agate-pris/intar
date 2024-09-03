macro_rules! sin_p4 {
    ($k: expr, $name: ident) => {
        fn $name(x: i32) -> i32 {
            const EXP: i32 = 15;
            const ONE: i32 = 32768;
            const A: i32 = $k + ONE;
            const B: i32 = $k;
            let z = x * x >> EXP;
            let y = A - (z * B >> EXP);
            y * z
        }
    };
}

macro_rules! sin_p4f {
    ($k: expr, $name: ident) => {
        fn $name(x: f64) -> f64 {
            const ONE: f64 = 32768.0;
            const A: f64 = $k + ONE;
            const B: f64 = $k;
            let z = x * x / ONE;
            let y = A - z * B / ONE;
            y * z
        }
    };
}

sin_p4!(7372, sin_p4_7372);
sin_p4!(7373, sin_p4_7373);
sin_p4!(7384, sin_p4_7384);
sin_p4!(7385, sin_p4_7385);
sin_p4f!(7372.800000000006462079297794552, sin_p4f_7372);
sin_p4f!(7384.324742943212069749687249668, sin_p4f_7384);

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
            let y = B - C * z / ONE;
            let y = A - y * z / ONE;
            y * x
        }
    };
}

sin_p5!(51436, sin_p5_51436);
sin_p5!(51437, sin_p5_51437);
sin_p5f!(51436.540205645438220618274829932, sin_p5f_51436);

#[derive(Debug, Default)]
struct Statistics {
    max_flor_diff: f64,
    min_flor_diff: f64,
    max_ceil_diff: f64,
    min_ceil_diff: f64,
    max_diff: f64,
    sum_flor_diff_sqr: f64,
    sum_ceil_diff_sqr: f64,
}

impl Statistics {
    fn new<A, B, C>(flor_func: A, ceil_func: B, func: C, x: i32, expected: f64) -> Statistics
    where
        A: Fn(i32) -> i32,
        B: Fn(i32) -> i32,
        C: Fn(f64) -> f64,
    {
        const K: f64 = 1.0 / (1 << 30) as f64;
        let a = flor_func(x) as f64;
        let b = ceil_func(x) as f64;
        let c = func(x as f64);
        let max_flor_diff = a - c;
        let max_ceil_diff = b - c;
        let max_diff = (a * K - expected)
            .abs()
            .max((b * K - expected).abs())
            .max((c * K - expected).abs());
        Statistics {
            max_flor_diff,
            min_flor_diff: max_flor_diff,
            max_ceil_diff,
            min_ceil_diff: max_ceil_diff,
            max_diff,
            sum_flor_diff_sqr: max_flor_diff.powi(2),
            sum_ceil_diff_sqr: max_ceil_diff.powi(2),
        }
    }
    fn fold(&self, other: Self) -> Statistics {
        Statistics {
            max_flor_diff: self.max_flor_diff.max(other.max_flor_diff),
            min_flor_diff: self.min_flor_diff.min(other.min_flor_diff),
            max_ceil_diff: self.max_ceil_diff.max(other.max_ceil_diff),
            min_ceil_diff: self.min_ceil_diff.min(other.min_ceil_diff),
            max_diff: self.max_diff.max(other.max_diff),
            sum_flor_diff_sqr: self.sum_flor_diff_sqr + other.sum_flor_diff_sqr,
            sum_ceil_diff_sqr: self.sum_ceil_diff_sqr + other.sum_ceil_diff_sqr,
        }
    }
}

fn main() {
    let mut statistics: [Statistics; 3] = Default::default();
    for x in 0..=32768 {
        let rad = (x as f64) / 32768.0 * std::f64::consts::FRAC_PI_2;
        let sin_expected = rad.sin();
        let cos_expected = 1.0 - rad.cos();
        statistics[0] = statistics[0].fold(Statistics::new(
            sin_p4_7372,
            sin_p4_7373,
            sin_p4f_7372,
            x,
            cos_expected,
        ));
        statistics[1] = statistics[1].fold(Statistics::new(
            sin_p4_7384,
            sin_p4_7385,
            sin_p4f_7384,
            x,
            cos_expected,
        ));
        statistics[2] = statistics[2].fold(Statistics::new(
            sin_p5_51436,
            sin_p5_51437,
            sin_p5f_51436,
            x,
            sin_expected,
        ));
    }
    println!("statistics: {:#?}", statistics);
    for s in statistics {
        println!("flor_rmse: {}", (s.sum_flor_diff_sqr / 32769.0).sqrt());
        println!("ceil_rmse: {}", (s.sum_ceil_diff_sqr / 32769.0).sqrt());
    }
}
