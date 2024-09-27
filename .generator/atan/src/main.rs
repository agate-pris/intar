use std::f64::consts::PI;

use utility::Measures;

const K: [u32; 4] = [
    1 << 31,
    (0.273 / PI * (1_u32 << 31) as f64 * (1 << 4) as f64) as u32,
    (0.2447 / PI * (1_u32 << 31) as f64 * (1 << 4) as f64 + 0.5) as u32,
    (0.0663 / PI * (1_u32 << 31) as f64 * (1 << 6) as f64) as u32,
];

fn atan_p2_a(x: i32) -> f64 {
    const ONE: u32 = 1 << 15;
    let expected = (x as f64 / ONE as f64).atan();
    let w = x.unsigned_abs();
    let z = ONE - w;
    let y = (K[1] + (1 << (15 - 1))) >> 15;
    let y = (K[0] + ((z * y) >> 2)) >> 15;
    let y = ((y * w) >> 3) as i32 * x.signum();
    y as f64 * PI / (1_u32 << 30) as f64 - expected
}

fn atan_p2_b(x: i32) -> f64 {
    const ONE: u32 = 1 << 15;
    let expected = (x as f64 / ONE as f64).atan();
    let w = x.unsigned_abs();
    let z = ONE - w;
    let y = (K[1] + (1 << (15 + 2 - 1))) >> (15 + 2);
    let y = (K[0] + z * y) >> (15 + 3);
    let y = y as i32 * x;
    y as f64 * PI / (1_u32 << 30) as f64 - expected
}

fn atan_p3_a(x: i32) -> f64 {
    const ONE: u32 = 1 << 15;
    let expected = (x as f64 / ONE as f64).atan();
    let w = x.unsigned_abs();
    let z = ONE - w;
    let y = (K[3] + (1 << (15 - 1))) >> 15;
    let y = (K[2] + ((y * w) >> (6 - 4))) >> 15;
    let y = (K[0] + ((z * y) >> (4 - 2))) >> 15;
    let y = ((w * y) >> 3) as i32 * x.signum();
    y as f64 * PI / (1_u32 << 30) as f64 - expected
}

fn atan_p3_b(x: i32) -> f64 {
    const ONE: u32 = 1 << 15;
    let expected = (x as f64 / ONE as f64).atan();
    let w = x.unsigned_abs();
    let z = ONE - w;
    let y = (K[3] + (1 << (15 - 1 + 6 - 4))) >> (15 + 6 - 4);
    let y = (K[2] + (y * w)) >> (15 + 4 - 2);
    let y = (K[0] + (z * y)) >> (15 + 3);
    let y = y as i32 * x;
    y as f64 * PI / (1_u32 << 30) as f64 - expected
}

fn main() {
    env_logger::init();
    for k in K {
        println!("{k}");
    }
    for (expected, actual) in [2147483648, 2985813123, 2676294767, 2900504177]
        .into_iter()
        .zip(K)
    {
        assert_eq!(expected, actual);
    }
    println!("{:?}", Measures::try_from((-32768..32769).map(atan_p2_a)));
    println!("{:?}", Measures::try_from((-32768..32769).map(atan_p2_b)));
    println!("{:?}", Measures::try_from((-32768..32769).map(atan_p3_a)));
    println!("{:?}", Measures::try_from((-32768..32769).map(atan_p3_b)));
}
