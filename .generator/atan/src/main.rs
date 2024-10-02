#![feature(f128)]

use std::{
    f64::consts::{FRAC_PI_4, PI},
    ops::Range,
};

use utility::Measures;

mod consts {
    use std::f128::consts::PI;
    use utility::powi;
    pub const P2: [f128; 1] = [0.273];
    pub const P3: [f128; 2] = [0.2447, 0.0663];
    pub const P9: [f128; 5] = [0.9998660, 0.3302995, 0.1801410, 0.0851330, 0.0208351];
    macro_rules! p2 {
        ($name:ident, $t:ty, $shift:expr) => {
            pub const $name: [$t; 2] = [1 << $shift, (P2[0] / PI * powi(2.0, $shift + 4)) as $t];
        };
    }
    macro_rules! p3 {
        ($name:ident, $t:ty, $shift:expr) => {
            pub const $name: [$t; 3] = [
                1 << $shift,
                (P3[0] / PI * powi(2.0, $shift + 4) + 0.5) as $t,
                (P3[1] / PI * powi(2.0, $shift + 6)) as $t,
            ];
        };
    }
    macro_rules! p9 {
        ($name:ident, $t:ty, $shift:expr) => {
            pub const $name: [$t; 5] = [
                (P9[0] / PI * powi(2.0, $shift + 2) + 0.5) as $t,
                (P9[1] / PI * powi(2.0, $shift + 4) + 0.5) as $t,
                (P9[2] / PI * powi(2.0, $shift + 5) + 0.5) as $t,
                (P9[3] / PI * powi(2.0, $shift + 6) + 0.5) as $t,
                (P9[4] / PI * powi(2.0, $shift + 8) + 0.0) as $t,
            ];
        };
    }
    p2! { P2_U32, u32, 31 }
    p2! { P2_U64, u64, 63 }
    p3! { P3_U32, u32, 31 }
    p3! { P3_U64, u64, 63 }
    p9! { P9_U32, u32, 31 }
    p9! { P9_U64, u64, 63 }
}

fn atan_p2_f64(x: i32) -> f64 {
    let x = (x as f64) / (1 << 15) as f64;
    let w = x.abs();
    let z = 1.0 - w;
    let y = ((consts::P2[0] as f64 * z) + FRAC_PI_4) * x;
    y - x.atan()
}

fn atan_p3_f64(x: i32) -> f64 {
    let x = (x as f64) / (1 << 15) as f64;
    let w = x.abs();
    let z = 1.0 - w;
    let y = ((consts::P3[1] as f64 * w + consts::P3[0] as f64) * z + FRAC_PI_4) * x;
    y - x.atan()
}

fn atan_p9_f64(x: i32) -> f64 {
    let x = (x as f64) / (1 << 15) as f64;
    let z = x * x;
    let y = 0.0;
    let y = (consts::P9[4] as f64 - y) * z;
    let y = (consts::P9[3] as f64 - y) * z;
    let y = (consts::P9[2] as f64 - y) * z;
    let y = (consts::P9[1] as f64 - y) * z;
    let y = (consts::P9[0] as f64 - y) * x;
    y - x.atan()
}

macro_rules! p2 {
    ($name:ident, $t:ty, $ut:ty, $consts:expr, $shift:expr) => {
        fn $name(x: i32) -> f64 {
            const ONE: $ut = 1 as $ut << $shift;
            let x = x as $t << ($shift - 15);
            let expected = (x as f64 / ONE as f64).atan();
            let w = x.unsigned_abs();
            let z = ONE - w;
            let y = 1 as $ut << ($shift + 2 - 1);
            let y = ($consts[1] + y) >> ($shift + 2);
            let y = ($consts[0] + z * y) >> ($shift + 3);
            let y = y as $t * x;
            y as f64 * PI / (1 as $ut << ($shift * 2)) as f64 - expected
        }
    };
}

macro_rules! p3 {
    ($name:ident, $t:ty, $ut:ty, $consts:expr, $shift:expr) => {
        fn $name(x: i32) -> f64 {
            const ONE: $ut = 1 as $ut << $shift;
            let x = x as $t << ($shift - 15);
            let expected = (x as f64 / ONE as f64).atan();
            let w = x.unsigned_abs();
            let z = ONE - w;
            let y = 1 as $ut << ($shift + 6 - 4 - 1);
            let y = ($consts[2] + y) >> ($shift + 6 - 4);
            let y = ($consts[1] + (y * w)) >> ($shift + 4 - 2);
            let y = ($consts[0] + (z * y)) >> ($shift + 3);
            let y = y as $t * x;
            y as f64 * PI / (1 as $ut << ($shift * 2)) as f64 - expected
        }
    };
}

macro_rules! p9 {
    ($name:ident, $t:ty, $ut:ty, $consts:expr, $shift:expr) => {
        fn $name(x: i32) -> f64 {
            let x = x as $t * (1 as $t << ($shift - 15));
            let z = (x * x) as $ut >> $shift;
            let y = 1 as $ut << ($shift + 8 - 6 - 1);
            let y = ($consts[4] + y) >> ($shift + 8 - 6);
            let y = ($consts[3] - (y * z)) >> ($shift + 6 - 5);
            let y = ($consts[2] - (y * z)) >> ($shift + 5 - 4);
            let y = ($consts[1] - (y * z)) >> ($shift + 4 - 2);
            let y = ($consts[0] - (y * z)) >> ($shift + 2 + 1);
            let y = y as $t * x;
            y as f64 * PI / (1 as $ut << ($shift * 2)) as f64 - (x as f64 / (1 as $ut << $shift) as f64).atan()
        }
    };
}

p2! { atan_p2_i32, i32, u32, consts::P2_U32, 15 }
p2! { atan_p2_i64, i64, u64, consts::P2_U64, 31 }
p3! { atan_p3_i32, i32, u32, consts::P3_U32, 15 }
p3! { atan_p3_i64, i64, u64, consts::P3_U64, 31 }
p9! { atan_p9_i32, i32, u32, consts::P9_U32, 15 }
p9! { atan_p9_i64, i64, u64, consts::P9_U64, 31 }

fn main() {
    env_logger::init();
    println!("{:#?}", consts::P2_U32);
    println!("{:#?}", consts::P2_U64);
    println!("{:#?}", consts::P3_U32);
    println!("{:#?}", consts::P3_U64);
    println!("{:#?}", consts::P9_U32);
    println!("{:#?}", consts::P9_U64);
    for (expected, actual) in [2147483648, 2985813123].into_iter().zip(consts::P2_U32) {
        assert_eq!(expected, actual);
    }
    for (expected, actual) in [9223372036854775808, 12823969718335781357]
        .into_iter()
        .zip(consts::P2_U64)
    {
        assert_eq!(expected, actual);
    }
    for (expected, actual) in [2147483648, 2676294767, 2900504177]
        .into_iter()
        .zip(consts::P3_U32)
    {
        assert_eq!(expected, actual);
    }
    for (expected, actual) in [
        9223372036854775808,
        11494598498449691202,
        12457570583526187604,
    ]
    .into_iter()
    .zip(consts::P3_U64)
    {
        assert_eq!(expected, actual);
    }
    for (expected, actual) in [2733894711, 3612500300, 3940420234, 3724413607, 3645990623]
        .into_iter()
        .zip(consts::P9_U32)
    {
        assert_eq!(expected, actual);
    }
    for (expected, actual) in [
        11741988375818245753,
        15515570644620693826,
        16923976036855135454,
        15996234637818023067,
        15659410489582290881,
    ]
    .into_iter()
    .zip(consts::P9_U64)
    {
        assert_eq!(expected, actual);
    }
    const RANGE: Range<i32> = -32768..32769;
    let a = [
        ("atan_p2_f64:", Measures::try_from(RANGE.map(atan_p2_f64))),
        ("atan_p2_i32:", Measures::try_from(RANGE.map(atan_p2_i32))),
        ("atan_p2_i64:", Measures::try_from(RANGE.map(atan_p2_i64))),
        ("atan_p3_f64:", Measures::try_from(RANGE.map(atan_p3_f64))),
        ("atan_p3_i32:", Measures::try_from(RANGE.map(atan_p3_i32))),
        ("atan_p3_i64:", Measures::try_from(RANGE.map(atan_p3_i64))),
        ("atan_p9_f64:", Measures::try_from(RANGE.map(atan_p9_f64))),
        ("atan_p9_i32:", Measures::try_from(RANGE.map(atan_p9_i32))),
        ("atan_p9_i64:", Measures::try_from(RANGE.map(atan_p9_i64))),
    ];
    for (name, result) in a.into_iter() {
        if let Ok(result) = result {
            println!("{} {{ {} }}", name, result);
        } else {
            println!("{} {{ error }}", name);
        }
    }
}
