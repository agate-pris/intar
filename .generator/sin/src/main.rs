#![feature(f128)]

use utility::consts::*;

fn to_rad(x: i32) -> f64 {
    x as f64 * (std::f64::consts::FRAC_PI_2 / TWO_POW_15_AS_F64)
}

macro_rules! k {
    ($a:expr, $log:expr, $shift:expr, $add:expr, $type:ty) => {
        ($a * (1_i128 << ($log + $shift)) as f128 + $add) as $type
    };
}

pub mod cos_p4 {
    use std::f128::consts::FRAC_PI_2;

    use utility::powi;

    pub const A_F128: [f128; 2] = [0.496_70 * powi(FRAC_PI_2, 2), 0.037_05 * powi(FRAC_PI_2, 4)];

    // FLOOR(1 - LOG(A, 2))
    pub const LOGS: [i32; 2] = [0, 3];

    macro_rules! def {
        ($k_name:ident, $f_name:ident, $shift:expr, $type:ty) => {
            pub const $k_name: [$type; 2] = [
                k!(A_F128[0], LOGS[0], $shift, 0.5, $type),
                k!(A_F128[1], LOGS[1], $shift, 0.0, $type),
            ];
            pub fn $f_name(x: $type) -> $type {
                const EXP: i32 = $shift / 2;
                let z = (x * x) >> EXP;
                let y = $k_name[1] + (1 << EXP) / 2;
                let y = $k_name[0] - (((y >> EXP) * z) >> (LOGS[1] - LOGS[0]));
                (y >> EXP) * z
            }
        };
    }
    def!(A_I16, f_i16, 14, i16);
    def!(A_I32, f_i32, 30, i32);
    def!(A_I64, f_i64, 62, i64);
}

pub mod sin_p5 {
    use std::f128::consts::FRAC_PI_2;

    use utility::powi;

    pub const A_F128: [f128; 3] = [
        1.00000 * FRAC_PI_2,
        0.16605 * powi(FRAC_PI_2, 3),
        0.00761 * powi(FRAC_PI_2, 5),
    ];

    // FLOOR(1 - LOG(A, 2))
    pub const LOGS: [i32; 3] = [0, 1, 4];

    macro_rules! def {
        ($k_name:ident, $f_name:ident, $shift:expr, $type:ty) => {
            pub const $k_name: [$type; 3] = [
                k!(A_F128[0], LOGS[0], $shift, 0.5, $type),
                k!(A_F128[1], LOGS[1], $shift, 0.5, $type),
                k!(A_F128[2], LOGS[2], $shift, 0.0, $type),
            ];
            pub fn $f_name(x: $type) -> $type {
                const EXP: i32 = $shift / 2;
                let z = (x * x) >> EXP;
                let y = $k_name[2] + (1 << EXP) / 2;
                let y = $k_name[1] - (((y >> EXP) * z) >> (LOGS[2] - LOGS[1]));
                let y = $k_name[0] - (((y >> EXP) * z) >> (LOGS[1] - LOGS[0]));
                (y >> EXP) * x
            }
        };
    }
    def!(A_I32, f_i32, 30, i32);
    def!(A_I64, f_i64, 62, i64);
    def!(A_I16, f_i16, 14, i16);
}

pub mod cos_p10 {
    use std::f128::consts::FRAC_PI_2;

    use utility::powi;

    pub const A_F128: [f128; 5] = [
        0.499_999_996_3 * powi(FRAC_PI_2, 2),
        0.041_666_641_8 * powi(FRAC_PI_2, 4),
        0.001_388_839_7 * powi(FRAC_PI_2, 6),
        0.000_024_760_9 * powi(FRAC_PI_2, 8),
        0.000_000_260_5 * powi(FRAC_PI_2, 10),
    ];

    // FLOOR(1 - LOG(A, 2))
    pub const LOGS: [i32; 5] = [0, 2, 6, 11, 16];

    macro_rules! def {
        ($k_name:ident, $f_name:ident, $shift:expr, $type:ty) => {
            pub const $k_name: [$type; 5] = [
                k!(A_F128[0], LOGS[0], $shift, 0.5, $type),
                k!(A_F128[1], LOGS[1], $shift, 0.5, $type),
                k!(A_F128[2], LOGS[2], $shift, 0.5, $type),
                k!(A_F128[3], LOGS[3], $shift, 0.5, $type),
                k!(A_F128[4], LOGS[4], $shift, 0.0, $type),
            ];
            pub fn $f_name(x: $type) -> $type {
                const EXP: i32 = $shift / 2;
                let z = (x * x) >> EXP;
                let y = $k_name[4] + (1 << EXP) / 2;
                let y = $k_name[3] - (((y >> EXP) * z) >> (LOGS[4] - LOGS[3]));
                let y = $k_name[2] - (((y >> EXP) * z) >> (LOGS[3] - LOGS[2]));
                let y = $k_name[1] - (((y >> EXP) * z) >> (LOGS[2] - LOGS[1]));
                let y = $k_name[0] - (((y >> EXP) * z) >> (LOGS[1] - LOGS[0]));
                (y >> EXP) * z
            }
        };
    }
    def!(A_I32, f_i32, 30, i32);
    def!(A_I64, f_i64, 62, i64);
    def!(A_I16, f_i16, 14, i16);
}

pub mod sin_p11 {
    use std::f128::consts::FRAC_PI_2;

    use utility::powi;

    pub const A_F128: [f128; 6] = [
        1.000_000_000_0 * FRAC_PI_2,
        0.166_666_666_4 * powi(FRAC_PI_2, 3),
        0.008_333_331_5 * powi(FRAC_PI_2, 5),
        0.000_198_409_0 * powi(FRAC_PI_2, 7),
        0.000_002_752_6 * powi(FRAC_PI_2, 9),
        0.000_000_023_9 * powi(FRAC_PI_2, 11),
    ];

    // FLOOR(1 - LOG(A, 2))
    pub const LOGS: [i32; 6] = [0, 1, 4, 8, 13, 19];

    macro_rules! def {
        ($k_name:ident, $f_name:ident, $shift:expr, $type:ty) => {
            pub const $k_name: [$type; 6] = [
                k!(A_F128[0], LOGS[0], $shift, 0.5, $type),
                k!(A_F128[1], LOGS[1], $shift, 0.5, $type),
                k!(A_F128[2], LOGS[2], $shift, 0.5, $type),
                k!(A_F128[3], LOGS[3], $shift, 0.5, $type),
                k!(A_F128[4], LOGS[4], $shift, 0.5, $type),
                k!(A_F128[5], LOGS[5], $shift, 0.0, $type),
            ];
            pub fn $f_name(x: $type) -> $type {
                const EXP: i32 = $shift / 2;
                let z = (x * x) >> EXP;
                let y = $k_name[5] + (1 << EXP) / 2;
                let y = $k_name[4] - (((y >> EXP) * z) >> (LOGS[5] - LOGS[4]));
                let y = $k_name[3] - (((y >> EXP) * z) >> (LOGS[4] - LOGS[3]));
                let y = $k_name[2] - (((y >> EXP) * z) >> (LOGS[3] - LOGS[2]));
                let y = $k_name[1] - (((y >> EXP) * z) >> (LOGS[2] - LOGS[1]));
                let y = $k_name[0] - (((y >> EXP) * z) >> (LOGS[1] - LOGS[0]));
                (y >> EXP) * x
            }
        };
    }
    def!(A_I32, f_i32, 30, i32);
    def!(A_I64, f_i64, 62, i64);
    def!(A_I16, f_i16, 14, i16);
}

fn acc_errors<Errors>(errors: Errors) -> (f64, f64, f64, usize, f64)
where
    Errors: Iterator<Item = f64>,
{
    errors.enumerate().fold(
        (0.0, 0.0, 0.0_f64, 0, 0.0),
        |(sqrt_sum, abs_sum, max_error, index, sum), (i, error)| {
            let sqrt_sum = sqrt_sum + error * error;
            let abs_sum = abs_sum + error.abs();
            let (max_error, index) = if max_error.abs() < error.abs() {
                (error, i)
            } else {
                (max_error, index)
            };
            let sum = sum + error;
            (sqrt_sum, abs_sum, max_error, index, sum)
        },
    )
}

fn print_measures(len: usize, errors: &(f64, f64, f64, usize, f64)) {
    let rmse = (errors.0 / len as f64).sqrt();
    let mae = errors.1 / len as f64;
    let me = errors.4 / len as f64;
    println!(
        concat!(
            "RMSE: {:12.10}, MAE: {:12.10}, ",
            "Max Error: {:>13.10} (i = {:5}), ME: {:>13.10}",
        ),
        rmse, mae, errors.2, errors.3, me,
    );
}

fn main() {
    env_logger::init();
    {
        assert_eq!(sin_p11::A_I64[0], 7244019458077122842);
        assert_eq!(sin_p11::A_I64[1], 5957967184218496005);
        assert_eq!(sin_p11::A_I64[2], 5880276630038185627);
        assert_eq!(sin_p11::A_I64[3], 5527136674668279497);
        assert_eq!(sin_p11::A_I64[4], 6054407851785858183);
        assert_eq!(sin_p11::A_I64[5], 8301301681792740747);
        assert_eq!(cos_p10::A_I64[0], 5689439535887298204);
        assert_eq!(cos_p10::A_I64[1], 4679373698902585566);
        assert_eq!(cos_p10::A_I64[2], 6157594556960820448);
        assert_eq!(cos_p10::A_I64[3], 8667924621372700220);
        assert_eq!(cos_p10::A_I64[4], 7200226522060996872);
        assert_eq!(cos_p10::A_I32[0], 1324675869);
        assert_eq!(cos_p10::A_I32[1], 1089501590);
        assert_eq!(cos_p10::A_I32[2], 1433676704);
        assert_eq!(cos_p10::A_I32[3], 2018158469);
        assert_eq!(cos_p10::A_I32[4], 1676433375);
        assert_eq!(sin_p5::A_I32[0], 1686629713);
        assert_eq!(sin_p5::A_I32[1], 1382064706);
        assert_eq!(sin_p5::A_I32[2], 1250270241);
        assert_eq!(cos_p4::A_I32[0], 1315933018);
        assert_eq!(cos_p4::A_I32[1], 1937570784);
        assert_eq!(cos_p4::A_I16[0], 20080);
        assert_eq!(cos_p4::A_I16[1], 29564);
        assert_eq!(cos_p4::f_i16(0), 0);
        assert_eq!(cos_p4::f_i32(0), 0);
        assert_eq!(cos_p4::f_i64(0), 0);
        assert_eq!(sin_p5::f_i16(0), 0);
        assert_eq!(sin_p5::f_i32(0), 0);
        assert_eq!(sin_p5::f_i64(0), 0);
        assert_eq!(cos_p10::f_i16(0), 0);
        assert_eq!(cos_p10::f_i32(0), 0);
        assert_eq!(cos_p10::f_i64(0), 0);
        assert_eq!(sin_p11::f_i16(0), 0);
        assert_eq!(sin_p11::f_i32(0), 0);
        assert_eq!(sin_p11::f_i64(0), 0);
    }
    fn f_i32<F>(f: F)
    where
        F: Fn(i32) -> f64,
    {
        let errors = (0..(TWO_POW_15 + 1)).map(f);
        print_measures(errors.len(), &acc_errors(errors));
    }
    fn f_i64<F>(f: F)
    where
        F: Fn(i64) -> f64,
    {
        let errors = (0..(TWO_POW_15 + 1)).map(|x| f(x as i64 * 65536));
        print_measures(errors.len(), &acc_errors(errors));
    }
    fn f_i16<F>(f: F)
    where
        F: Fn(i16) -> f64,
    {
        let errors = (0..(TWO_POW_7 + 1)).map(f);
        print_measures(errors.len(), &acc_errors(errors));
    }
    fn sin_i32<F>(name: &str, f: F)
    where
        F: Fn(i32) -> i32,
    {
        print!("{:11}: ", name);
        f_i32(|x| f(x) as f64 / TWO_POW_30_AS_F64 - to_rad(x).sin());
    }
    fn sin_i64<F>(name: &str, f: F)
    where
        F: Fn(i64) -> i64,
    {
        print!("{:11}: ", name);
        f_i64(|x| f(x) as f64 / TWO_POW_62_AS_F64 - to_rad((x / 65536) as i32).sin());
    }
    fn sin_f16<F>(name: &str, f: F)
    where
        F: Fn(i16) -> i16,
    {
        print!("{:11}: ", name);
        f_i16(|x| f(x) as f64 / TWO_POW_14_AS_F64 - to_rad(x as i32 * 256).sin());
    }
    fn cos_i32<F>(name: &str, f: F)
    where
        F: Fn(i32) -> i32,
    {
        print!("{:11}: ", name);
        f_i32(|x| 1.0 - f(x) as f64 / TWO_POW_30_AS_F64 - to_rad(x).cos());
    }
    fn cos_i64<F>(name: &str, f: F)
    where
        F: Fn(i64) -> i64,
    {
        print!("{:11}: ", name);
        f_i64(|x| 1.0 - f(x) as f64 / TWO_POW_62_AS_F64 - to_rad((x / 65536) as i32).cos());
    }
    fn cos_i16<F>(name: &str, f: F)
    where
        F: Fn(i16) -> i16,
    {
        print!("{:11}: ", name);
        f_i16(|x| 1.0 - f(x) as f64 / TWO_POW_14_AS_F64 - to_rad(x as i32 * 256).cos());
    }
    {
        // sin_p11 i32: RMSE: 0.0000062976, MAE: 0.0000045232, Max Error: -0.0000305164 (i = 32767), ME: -0.0000015507
        // sin_p11 i64: RMSE: 0.0000000006, MAE: 0.0000000003, Max Error: -0.0000000027 (i = 32751), ME: -0.0000000003
        // sin_p11 i16: RMSE: 0.0015075931, MAE: 0.0010805380, Max Error: -0.0050456506 (i =   116), ME: -0.0005070525
        // cos_p10 i32: RMSE: 0.0000230620, MAE: 0.0000205185, Max Error:  0.0000515435 (i = 31501), ME:  0.0000205138
        // cos_p10 i64: RMSE: 0.0000000007, MAE: 0.0000000004, Max Error:  0.0000000027 (i = 32719), ME:  0.0000000003
        // cos_p10 i16: RMSE: 0.0051403188, MAE: 0.0043606195, Max Error:  0.0114153852 (i =   117), ME:  0.0043606195
        // sin_p5 i32 : RMSE: 0.0000853741, MAE: 0.0000687285, Max Error: -0.0001868704 (i = 29643), ME:  0.0000126170
        // sin_p5 i64 : RMSE: 0.0000856929, MAE: 0.0000693601, Max Error: -0.0001641488 (i = 29599), ME:  0.0000141006
        // sin_p5 i16 : RMSE: 0.0015075931, MAE: 0.0010805380, Max Error: -0.0050456506 (i =   116), ME: -0.0005070525
        // cos_p4 i32 : RMSE: 0.0006034412, MAE: 0.0005051203, Max Error: -0.0011871464 (i = 28581), ME: -0.0000052894
        // cos_p4 i64 : RMSE: 0.0006059845, MAE: 0.0005010220, Max Error: -0.0011879371 (i = 28565), ME: -0.0000265616
        // cos_p4 i16 : RMSE: 0.0050991042, MAE: 0.0044159770, Max Error:  0.0114153852 (i =   117), ME:  0.0044159770

        sin_i32("sin_p11 i32", sin_p11::f_i32);
        sin_i64("sin_p11 i64", sin_p11::f_i64);
        sin_f16("sin_p11 i16", sin_p11::f_i16);
        cos_i32("cos_p10 i32", cos_p10::f_i32);
        cos_i64("cos_p10 i64", cos_p10::f_i64);
        cos_i16("cos_p10 i16", cos_p10::f_i16);
        sin_i32("sin_p5 i32", sin_p5::f_i32);
        sin_i64("sin_p5 i64", sin_p5::f_i64);
        sin_f16("sin_p5 i16", sin_p5::f_i16);
        cos_i32("cos_p4 i32", cos_p4::f_i32);
        cos_i64("cos_p4 i64", cos_p4::f_i64);
        cos_i16("cos_p4 i16", cos_p4::f_i16);
    }
}
