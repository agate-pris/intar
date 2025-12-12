using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Numerics;

namespace Intar.Tests {
    readonly struct BigRational {
        readonly BigInteger numer;
        readonly BigInteger denom;
        public BigInteger Numer => numer;
        public BigInteger Denom => denom;
        public int Sign => numer.Sign * denom.Sign;
        public BigRational(BigInteger numer, BigInteger denom) {
            var gcd = BigInteger.GreatestCommonDivisor(numer, denom);
            numer /= gcd;
            denom /= gcd;
            this.numer = numer;
            this.denom = denom;
        }
        public BigRational(BigInteger numer) : this(numer, 1) { }
        public override string ToString() {
            return $"{numer}/{denom}";
        }
        public static explicit operator BigInteger(BigRational v) {
            return v.numer / v.denom;
        }
        public static BigRational operator *(BigRational x, BigInteger y) {
            return new BigRational(x.numer * y, x.denom);
        }
        public static BigRational operator *(BigRational left, BigRational right) {
            return new BigRational(left.numer * right.numer, left.denom * right.denom);
        }
        public static BigRational operator /(BigRational left, BigInteger right) {
            return new BigRational(left.numer, left.denom * right);
        }
        public static BigRational operator /(BigInteger left, BigRational right) {
            return new BigRational(left * right.denom, right.numer);
        }
        public BigRational Pow(int exponent) {
            return new BigRational(BigInteger.Pow(numer, exponent), BigInteger.Pow(denom, exponent));
        }
        public BigRational Round() {
            BigInteger tmp;
            if ((numer < 0) == (denom < 0)) {
                tmp = (2 * numer) + denom;
            } else {
                tmp = (2 * numer) - denom;
            }
            return new BigRational(tmp / (2 * denom));
        }
    }

    public class BigRationalTest {
        [Test]
        public static void TestBigRational() {
            // 0 方向に丸められることをテスト
            Utility.AssertAreEqual(1, (int)(BigInteger)new BigRational(4, 3));
            Utility.AssertAreEqual(1, (int)(BigInteger)new BigRational(5, 3));
            Utility.AssertAreEqual(1, (int)(BigInteger)new BigRational(-4, -3));
            Utility.AssertAreEqual(1, (int)(BigInteger)new BigRational(-5, -3));

            // 四捨五入されることをテスト
            Utility.AssertAreEqual(1, (int)(BigInteger)new BigRational(1, 2).Round());
            Utility.AssertAreEqual(1, (int)(BigInteger)new BigRational(4, 3).Round());
            Utility.AssertAreEqual(1, (int)(BigInteger)new BigRational(-1, -2).Round());
            Utility.AssertAreEqual(1, (int)(BigInteger)new BigRational(-4, -3).Round());
            Utility.AssertAreEqual(2, (int)(BigInteger)new BigRational(5, 3).Round());
            Utility.AssertAreEqual(2, (int)(BigInteger)new BigRational(-5, -3).Round());
            Utility.AssertAreEqual(-2, (int)(BigInteger)new BigRational(5, -3).Round());
            Utility.AssertAreEqual(-2, (int)(BigInteger)new BigRational(-5, 3).Round());
        }

        /// <summary>
        /// 小数をパースして分数に変換する.
        /// </summary>
        /// <param name="s">小数を表現する文字列</param>
        /// <returns>与えられた小数を精確に表現する分数</returns>
        static BigRational ParseReal(string s) {
            var i = s.IndexOf('.');
            var provider = System.Globalization.CultureInfo.InvariantCulture;
            if (i < 0) {
                return new BigRational(BigInteger.Parse(s, provider));
            } else {
                var numer = s.Remove(i, 1);
                var denom = "1" + new string('0', s.Length - i - 1);
                var n = BigInteger.Parse(numer, provider);
                var d = BigInteger.Parse(denom, provider);
                return new BigRational(n, d);
            }
        }

        [Test]
        public static void TestParseReal() {
            var x = ParseReal("1.2");
            Utility.AssertAreEqual(6, (int)x.Numer);
            Utility.AssertAreEqual(5, (int)x.Denom);

            var e = Assert.Throws<FormatException>(() => ParseReal("1.2.3"));
            Console.WriteLine(x);
        }

        static readonly BigRational piLower = ParseReal("3.1415926535897932384626433832795028841971");
        static readonly BigRational piUpper = ParseReal("3.1415926535897932384626433832795028841972");

        const ulong AsinP3D32 = 25005;
        const ulong AsinP3D64 = 163874548;
        const ulong AsinP7H64 = 883706959;
        const ulong AtanP2K32 = 22780;
        const ulong AtanP2K64 = 1492906562;
        const ulong AtanP3C32 = 22129;
        const ulong AtanP3C64 = 1450252089;
        const ulong AtanP9E64 = 1822995312;
        const ulong SinP4B32 = 14782;
        const ulong SinP4B64 = 968785392;
        const ulong SinP5C32 = 9539;
        const ulong SinP5C64 = 625135121;
        const ulong SinP10E64 = 209554172;
        const ulong SinP11F64 = 120799838;

        [Test]
        public static void TestAsinConstant() {
            const int k1 = (8 * 2) - 1;
            const int k2 = (8 * 4) - 1;
            const int k3 = (8 * 8) - 1;
            const int k4 = k2 - k1;
            const int k5 = k3 - k2;
            var ks = new int[] {
                1, 3, 5, 7,
                1, 3, 5, 5, 6, 7, 8, 11,
            };
            var k6 = ks[3] - ks[2];
            var frac2PiLower = 2 / piUpper;
            var frac2PiUpper = 2 / piLower;
            var cases = new[] {
                ("1.5707288", new[] { (k2 + ks[0], k2, Intar.Mathi.AsinInternal.P3U32A), (k3 + ks[0], k3, Intar.Mathi.AsinInternal.P3U64A), }),
                ("0.2121144", new[] { (k2 + ks[1], k2, Intar.Mathi.AsinInternal.P3U32B), (k3 + ks[1], k3, Intar.Mathi.AsinInternal.P3U64B), }),
                ("0.0742610", new[] { (k2 + ks[2], k2, Intar.Mathi.AsinInternal.P3U32C), (k3 + ks[2], k3, Intar.Mathi.AsinInternal.P3U64C), }),
                ("0.0187293", new[] { (k4 + ks[2], k4 - k6, AsinP3D32), (k5 + ks[2], k5 - k6, AsinP3D64), }),
                ("1.5707963050", new[] { (k3 + ks[4], k3, Intar.Mathi.AsinInternal.P7U64A), } ),
                ("0.2145988016", new[] { (k3 + ks[5], k3, Intar.Mathi.AsinInternal.P7U64B), } ),
                ("0.0889789874", new[] { (k3 + ks[6], k3, Intar.Mathi.AsinInternal.P7U64C), } ),
                ("0.0501743046", new[] { (k3 + ks[7], k3, Intar.Mathi.AsinInternal.P7U64D), } ),
                ("0.0308918810", new[] { (k3 + ks[8], k3, Intar.Mathi.AsinInternal.P7U64E), } ),
                ("0.0170881256", new[] { (k3 + ks[9], k3, Intar.Mathi.AsinInternal.P7U64F), } ),
                ("0.0066700901", new[] { (k3 + ks[10], k3, Intar.Mathi.AsinInternal.P7U64G), } ),
                ("0.0012624911", new[] { (k5 + ks[10], k5 - (ks[11] - ks[10]), AsinP7H64), } ),
            };
            foreach (var c in cases) {
                var k = ParseReal(c.Item1);
                var lower = k * frac2PiLower;
                var upper = k * frac2PiUpper;
                foreach (var precision in c.Item2) {
                    Test(lower, upper, precision.Item1, precision.Item3, precision.Item2);
                }
            }
        }

        [Test]
        public static void TestAtanConstant() {
            const int k1 = (8 * 2) - 1;
            const int k2 = (8 * 4) - 1;
            const int k3 = (8 * 8) - 1;
            const int k4 = k2 - k1;
            const int k5 = k3 - k2;
            var ks = new int[] {
                2, 4,
                2, 4, 6,
                2, 4, 5, 6, 8,
            };
            var k6 = ks[1] - ks[0];
            var k7 = ks[4] - ks[3];
            var frac1PiLower = 1 / piUpper;
            var frac1PiUpper = 1 / piLower;
            var cases = new[] {
                ("0.273", new[] { (k4 + ks[0], k4 - k6, AtanP2K32), (k5 + ks[0], k5 - k6, AtanP2K64), } ),
                ("0.2447", new[] { (k2 + ks[3], k2, Intar.Mathi.AtanInternal.P3U32B), (k3 + ks[3], k3, Intar.Mathi.AtanInternal.P3U64B), }),
                ("0.0663", new[] { (k4 + ks[3], k4 - k7, AtanP3C32), (k5 + ks[3], k5 - k7, AtanP3C64), } ),
                ("0.9998660", new[] { (k3 + ks[5], k3, Intar.Mathi.AtanInternal.P9U64A), }),
                ("0.3302995", new[] { (k3 + ks[6], k3, Intar.Mathi.AtanInternal.P9U64B), }),
                ("0.1801410", new[] { (k3 + ks[7], k3, Intar.Mathi.AtanInternal.P9U64C), }),
                ("0.0851330", new[] { (k3 + ks[8], k3, Intar.Mathi.AtanInternal.P9U64D), }),
                ("0.0208351", new[] { (k5 + ks[8], k5 - (ks[9] - ks[8]), AtanP9E64), }),
            };
            foreach (var c in cases) {
                var k = ParseReal(c.Item1);
                var lower = k * frac1PiLower;
                var upper = k * frac1PiUpper;
                foreach (var precision in c.Item2) {
                    Test(lower, upper, precision.Item1, precision.Item3, precision.Item2);
                }
            }
        }

        [Test]
        public static void TestSinConstant() {
            const int k1 = (8 * 2) - 1;
            const int k2 = (8 * 4) - 1;
            const int k3 = (8 * 8) - 1;
            const int k4 = k2 - k1;
            const int k5 = k3 - k2;
            var ks = new int[] {
                0,
                0, 3,
                1, 4,
                0, 2, 6, 11, 16,
                1, 4, 8, 13, 19,
            };
            var k6 = ks[2] - ks[1];
            var k7 = ks[4] - ks[3];
            var fracPi2Lower = piLower / 2;
            var fracPi2Upper = piUpper / 2;
            var cases = new[] {
                ("1.0", 1, new[] { (k2 + ks[0], k2, Intar.Mathi.SinInternal.P5I32A), (k3 + ks[0], k3, Intar.Mathi.SinInternal.P5I64A), }),
                ("0.49670", 2, new[] { (k2 + ks[1], k2, Intar.Mathi.SinInternal.P4I32A), (k3 + ks[1], k3, Intar.Mathi.SinInternal.P4I64A), }),
                ("0.03705", 4, new[] { (k4 + ks[1], k4 - k6, SinP4B32), (k5 + ks[1], k5 - k6, SinP4B64), }),
                ("0.16605", 3, new[] { (k2 + ks[3], k2, Intar.Mathi.SinInternal.P5I32B), (k3 + ks[3], k3, Intar.Mathi.SinInternal.P5I64B), }),
                ("0.00761", 5, new[] { (k4 + ks[3], k4 - k7, SinP5C32), (k5 + ks[3], k5 - k7, SinP5C64), }),
                ("0.4999999963", 2, new[] { (k3 + ks[5], k3, Intar.Mathi.SinInternal.P10I64A), }),
                ("0.0416666418", 4, new[] { (k3 + ks[6], k3, Intar.Mathi.SinInternal.P10I64B), }),
                ("0.0013888397", 6, new[] { (k3 + ks[7], k3, Intar.Mathi.SinInternal.P10I64C), }),
                ("0.0000247609", 8, new[] { (k3 + ks[8], k3, Intar.Mathi.SinInternal.P10I64D), }),
                ("0.0000002605", 10, new[] { (k5 + ks[8], k5 - (ks[9] - ks[8]), SinP10E64) }),
                ("0.1666666664", 3, new[] { (k3 + ks[10], k3, Intar.Mathi.SinInternal.P11I64B), }),
                ("0.0083333315", 5, new[] { (k3 + ks[11], k3, Intar.Mathi.SinInternal.P11I64C), }),
                ("0.0001984090", 7, new[] { (k3 + ks[12], k3, Intar.Mathi.SinInternal.P11I64D), }),
                ("0.0000027526", 9, new[] { (k3 + ks[13], k3, Intar.Mathi.SinInternal.P11I64E), }),
                ("0.0000000239", 11, new[] { (k5 + ks[13], k5 - (ks[14] - ks[13]), SinP11F64) }),
            };
            foreach (var c in cases) {
                var k = ParseReal(c.Item1);
                var lower = k * fracPi2Lower.Pow(c.Item2);
                var upper = k * fracPi2Upper.Pow(c.Item2);
                foreach (var precision in c.Item3) {
                    Test(lower, upper, precision.Item1, precision.Item3, precision.Item2);
                }
            }
        }

        static void Test(BigRational lower, BigRational upper, int shift, BigInteger expected, int frac) {
            // 分数を shift ビットを小数部とする整数に変換するための前準備
            {
                var b = BigInteger.Pow(2, shift);
                lower *= b;
                upper *= b;
            }

            // 上界と下界の両方について, 四捨五入した時に同じ値になることを確認
            Assert.AreEqual((BigInteger)lower.Round(), expected);
            Assert.AreEqual((BigInteger)upper.Round(), expected);

            // 小数部を frac ビットで表現した時に 1 以上 2 未満の値になっていることを確認
            Assert.IsTrue(BigInteger.Pow(2, frac) <= expected, $"{frac} {expected}");
            Assert.IsTrue(expected < BigInteger.Pow(2, frac + 1), $"{frac} {expected}");
        }

        [Test]
        public static void TestX() {
            // SinP3, SinP5 では
            // SinInternal.MakeArgOdd によって入力の範囲は
            // int の場合 [-0x8000, 0x8000] の範囲に,
            // long の場合 [-0x80000000, 0x80000000] の範囲に制限される.
            // その後, 呼び出し時に 2 乗してからビットシフトすることで
            // それぞれ [0, 0x8000], [0, 0x80000000] の範囲に制限される.
        }
    }
}
