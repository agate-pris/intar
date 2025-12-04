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
        internal static BigRational ParseReal(string s) {
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

        internal static readonly BigRational PiLower = ParseReal("3.1415926535897932384626433832795028841971");
        internal static readonly BigRational PiUpper = ParseReal("3.1415926535897932384626433832795028841972");
        internal static readonly BigRational FracPi2Lower = PiLower / 2;
        internal static readonly BigRational FracPi2Upper = PiUpper / 2;
        internal static readonly BigRational Frac1PiLower = 1 / PiUpper;
        internal static readonly BigRational Frac1PiUpper = 1 / PiLower;
        internal static readonly BigRational Frac2PiLower = 2 / PiUpper;
        internal static readonly BigRational Frac2PiUpper = 2 / PiLower;

        internal static void Test(BigRational lower, BigRational upper, int shift, BigInteger expected, int frac) {
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
