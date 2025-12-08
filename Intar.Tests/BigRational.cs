using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Diagnostics;
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
        public static BigRational operator *(BigRational left, int right) {
            return new BigRational(left.numer * right, left.denom);
        }
        public static BigRational operator *(BigRational left, BigRational right) {
            return new BigRational(left.numer * right.numer, left.denom * right.denom);
        }
        public static BigRational operator /(BigRational left, int right) {
            return new BigRational(left.numer, left.denom * right);
        }
        public static BigRational operator /(int left, BigRational right) {
            return new BigRational(left * right.denom, right.numer);
        }
        public static bool operator <(BigRational x, BigInteger y) {
            if (x.denom.IsZero) {
                return false;
            }
            return x.numer < x.denom * y;
        }
        public static bool operator >(BigRational x, BigInteger y) {
            if (x.denom.IsZero) {
                return false;
            }
            return x.numer > x.denom * y;
        }
        public static bool operator <=(BigInteger x, BigRational y) {
            if (y.denom.IsZero) {
                return false;
            }
            return x * y.denom <= y.numer;
        }
        public static bool operator >=(BigInteger x, BigRational y) {
            if (y.denom.IsZero) {
                return false;
            }
            return x * y.denom >= y.numer;
        }
        public static bool operator <(BigRational x, ulong y) {
            if (x.denom.IsZero) {
                return false;
            }
            return x.numer < x.denom * y;
        }
        public static bool operator >(BigRational x, ulong y) {
            if (x.denom.IsZero) {
                return false;
            }
            return x.numer > x.denom * y;
        }
        public static explicit operator BigInteger(BigRational v) {
            return v.numer / v.denom;
        }
        public static explicit operator ulong(BigRational v) {
            return (ulong)(v.numer / v.denom);
        }
        public static BigRational Abs(BigRational v) {
            return new BigRational(BigInteger.Abs(v.numer), BigInteger.Abs(v.denom));
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
        public BigRational Pow(int exponent) {
            return new BigRational(BigInteger.Pow(numer, exponent), BigInteger.Pow(denom, exponent));
        }
    }

    public class BigRationalTest {
        [Test]
        public static void TestBigRational() {
            // 0 方向に丸められることをテスト
            Utility.AssertAreEqual(1, (ulong)new BigRational(4, 3));
            Utility.AssertAreEqual(1, (ulong)new BigRational(5, 3));
            Utility.AssertAreEqual(1, (ulong)new BigRational(-4, -3));
            Utility.AssertAreEqual(1, (ulong)new BigRational(-5, -3));

            // 四捨五入されることをテスト
            Utility.AssertAreEqual(1, (ulong)new BigRational(1, 2).Round());
            Utility.AssertAreEqual(1, (ulong)new BigRational(4, 3).Round());
            Utility.AssertAreEqual(1, (ulong)new BigRational(-1, -2).Round());
            Utility.AssertAreEqual(1, (ulong)new BigRational(-4, -3).Round());
            Utility.AssertAreEqual(2, (ulong)new BigRational(5, 3).Round());
            Utility.AssertAreEqual(2, (ulong)new BigRational(-5, -3).Round());

            // 負数を符号なし整数にキャストした時例外をスローすることをテスト.
            var e = Assert.Throws<OverflowException>(() => {
                Debug.Assert(ulong.MaxValue == (ulong)new BigRational(5, -3));
            });
            Utility.Log(e.ToString());

            e = Assert.Throws<OverflowException>(() => {
                Debug.Assert(ulong.MaxValue == (ulong)new BigRational(-5, 3));
            });
            Utility.Log(e.ToString());
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
        static readonly BigRational frac1PiLower = 1 / piUpper;
        static readonly BigRational frac1PiUpper = 1 / piLower;
        static readonly BigRational frac2PiLower = 2 / piUpper;
        static readonly BigRational frac2PiUpper = 2 / piLower;
        static readonly BigRational fracPi2Lower = piLower / 2;
        static readonly BigRational fracPi2Upper = piUpper / 2;

        struct BigFloat {
            public int exp;
            public BigInteger frac;
            public BigFloat(int exp, BigInteger frac) {
                this.exp = exp;
                this.frac = frac;
            }
            public static bool operator ==(BigFloat x, BigFloat y) {
                return (x.exp == y.exp) && (x.frac == y.frac);
            }
            public static bool operator !=(BigFloat x, BigFloat y) {
                return (x.exp != y.exp) || (x.frac != y.frac);
            }
            public override bool Equals(object obj) {
                return obj is BigFloat u && this == u;
            }
            public override int GetHashCode() {
                return HashCode.Combine(frac, exp);
            }
            public override string ToString() {
                return $"ResultU32 {{ exp: {exp}, frac: {frac} }}";
            }
        }

        static BigFloat? Calc(BigRational v, bool round, int exponent) {
            if (v.Denom == 0) {
                return null;
            }

            var sign = v.Sign;
            if (sign == 0) {
                return new BigFloat();
            }
            v = BigRational.Abs(v);

            // 2^exponent < f(v) <= e^(exponent+1) になるように
            // v と exp を調整する. (f(v) = v または Round(v))

            var k = BigInteger.Pow(2, exponent);
            var exp = 0;
            if (round) {
                var p = v.Round();

                while (p < k) {
                    exp--;
                    v *= 2;
                    p = v.Round();
                }

                k *= 2;
                while (k <= p) {
                    exp++;
                    v /= 2;
                    p = v.Round();
                }

                v = p;
            } else {
                while (v < k) {
                    exp--;
                    v *= 2;
                }

                k *= 2;
                while (k <= v) {
                    exp++;
                    v /= 2;
                }
            }

            return new BigFloat(exp, (BigInteger)v * sign);
        }

        static BigFloat? Calc32(BigRational v, bool round) => Calc(v, round, 31);
        static BigFloat? Calc64(BigRational v, bool round) => Calc(v, round, 63);

        static void Check32(
            BigRational lower,
            BigRational upper,
            int shift,
            uint frac,
            bool round
        ) {
            var expected = new BigFloat(-31 - shift, frac);
            var l = Calc32(lower, round);
            var u = Calc32(upper, round);
            if (l == u &&
                expected == l &&
                expected == u) {
                return;
            }
            Assert.AreEqual(l, u);
            Assert.AreEqual(expected, l);
            Assert.AreEqual(expected, u);
        }
        static void Check64(
            BigRational lower,
            BigRational upper,
            int shift,
            ulong frac,
            bool round
        ) {
            var expected = new BigFloat(-63 - shift, frac);
            var l = Calc64(lower, round);
            var u = Calc64(upper, round);
            if (l == u &&
                expected == l &&
                expected == u) {
                return;
            }
            Assert.AreEqual(l, u);
            Assert.AreEqual(expected, l);
            Assert.AreEqual(expected, u);
        }
        static void CheckAsin32(string v, int expectedShift, uint expectedFrac, bool round) {
            var k = ParseReal(v);
            var lower = frac2PiLower * k;
            var upper = frac2PiUpper * k;
            Check32(lower, upper, expectedShift, expectedFrac, round);
        }
        static void CheckAsin64(string v, int expectedShift, ulong expectedFrac, bool round) {
            var k = ParseReal(v);
            var lower = frac2PiLower * k;
            var upper = frac2PiUpper * k;
            Check64(lower, upper, expectedShift, expectedFrac, round);
        }
        static void CheckAtan32(string s, int expectedShift, uint expectedFrac, bool round) {
            var k = ParseReal(s);
            var lower = frac1PiLower * k;
            var upper = frac1PiUpper * k;
            Check32(lower, upper, expectedShift, expectedFrac, round);
        }
        static void CheckAtan64(string s, int expectedShift, ulong expectedFrac, bool round) {
            var k = ParseReal(s);
            var lower = frac1PiLower * k;
            var upper = frac1PiUpper * k;
            Check64(lower, upper, expectedShift, expectedFrac, round);
        }
        static void CheckSin32(string s, int exponent, int expectedShift, uint expectedFrac, bool round) {
            var k = ParseReal(s);
            var lower = fracPi2Lower.Pow(exponent) * k;
            var upper = fracPi2Upper.Pow(exponent) * k;
            Check32(lower, upper, expectedShift, expectedFrac, round);
        }
        static void CheckSin64(string s, int exponent, int expectedShift, ulong expectedFrac, bool round) {
            var k = ParseReal(s);
            var lower = fracPi2Lower.Pow(exponent) * k;
            var upper = fracPi2Upper.Pow(exponent) * k;
            Check64(lower, upper, expectedShift, expectedFrac, round);
        }

        [Test]
        public static void TestConstant() {
            var asin = new string[] {
                "1.5707288",
                "0.2121144",
                "0.0742610",
                "0.0187293",
                "1.5707963050",
                "0.2145988016",
                "0.0889789874",
                "0.0501743046",
                "0.0308918810",
                "0.0170881256",
                "0.0066700901",
                "0.0012624911",
            };
            var atan = new string[] {
                "0.273",
                "0.2447",
                "0.0663",
            };
            var sin = new string[] {
                "0.16605",
                "0.00761",
                "0.49670",
                "0.03705",
            };
            CheckAsin32(asin[0], 1, Intar.Mathi.AsinInternal.P3U32A, true);
            CheckAsin64(asin[0], 1, Intar.Mathi.AsinInternal.P3U64A, true);
            CheckAsin32(asin[1], 3, Intar.Mathi.AsinInternal.P3U32B, true);
            CheckAsin64(asin[1], 3, Intar.Mathi.AsinInternal.P3U64B, true);
            CheckAsin32(asin[2], 5, Intar.Mathi.AsinInternal.P3U32C, true);
            CheckAsin64(asin[2], 5, Intar.Mathi.AsinInternal.P3U64C, true);
            CheckAsin32(asin[3], 7, Intar.Mathi.AsinInternal.P3U32D, false);
            CheckAsin64(asin[3], 7, Intar.Mathi.AsinInternal.P3U64D, false);
            CheckAtan32(atan[0], 4, Intar.Mathi.AtanInternal.P2U32B, false);
            CheckAtan64(atan[0], 4, Intar.Mathi.AtanInternal.P2U64B, false);
            CheckAtan32(atan[1], 4, Intar.Mathi.AtanInternal.P3U32B, true);
            CheckAtan64(atan[1], 4, Intar.Mathi.AtanInternal.P3U64B, true);
            CheckAtan32(atan[2], 6, Intar.Mathi.AtanInternal.P3U32C, false);
            CheckAtan64(atan[2], 6, Intar.Mathi.AtanInternal.P3U64C, false);
            CheckSin32(sin[0], 3, 1, Intar.Mathi.SinInternal.P5I32B, true);
            CheckSin64(sin[0], 3, 1, Intar.Mathi.SinInternal.P5I64B, true);
            CheckSin32(sin[1], 5, 4, Intar.Mathi.SinInternal.P5I32C, false);
            CheckSin64(sin[1], 5, 4, Intar.Mathi.SinInternal.P5I64C, false);
            CheckSin32(sin[2], 2, 0, Intar.Mathi.SinInternal.P4I32A, true);
            CheckSin64(sin[2], 2, 0, Intar.Mathi.SinInternal.P4I64A, true);
            CheckSin32(sin[3], 4, 3, Intar.Mathi.SinInternal.P4I32B, false);
            CheckSin64(sin[3], 4, 3, Intar.Mathi.SinInternal.P4I64B, false);
            CheckAsin64("1.5707963050", 1, Intar.Mathi.AsinInternal.P7U64A, true);
            CheckAsin64("0.2145988016", 3, Intar.Mathi.AsinInternal.P7U64B, true);
            CheckAsin64("0.0889789874", 5, Intar.Mathi.AsinInternal.P7U64C, true);
            CheckAsin64("0.0501743046", 5, Intar.Mathi.AsinInternal.P7U64D, true);
            CheckAsin64("0.0308918810", 6, Intar.Mathi.AsinInternal.P7U64E, true);
            CheckAsin64("0.0170881256", 7, Intar.Mathi.AsinInternal.P7U64F, true);
            CheckAsin64("0.0066700901", 8, Intar.Mathi.AsinInternal.P7U64G, true);
            CheckAsin64("0.0012624911", 11, Intar.Mathi.AsinInternal.P7U64H, false);
            CheckAtan64("0.9998660", 2, Intar.Mathi.AtanInternal.P9U64A, true);
            CheckAtan64("0.3302995", 4, Intar.Mathi.AtanInternal.P9U64B, true);
            CheckAtan64("0.1801410", 5, Intar.Mathi.AtanInternal.P9U64C, true);
            CheckAtan64("0.0851330", 6, Intar.Mathi.AtanInternal.P9U64D, true);
            CheckAtan64("0.0208351", 8, Intar.Mathi.AtanInternal.P9U64E, false);
            Check32(fracPi2Lower, fracPi2Upper, 0, Intar.Mathi.SinInternal.P5I32A, true);
            Check64(fracPi2Lower, fracPi2Upper, 0, Intar.Mathi.SinInternal.P5I64A, true);
            Check64(fracPi2Lower, fracPi2Upper, 0, Intar.Mathi.SinInternal.P11I64A, true);
            CheckSin64("0.1666666664", 3, 1, Intar.Mathi.SinInternal.P11I64B, true);
            CheckSin64("0.0083333315", 5, 4, Intar.Mathi.SinInternal.P11I64C, true);
            CheckSin64("0.0001984090", 7, 8, Intar.Mathi.SinInternal.P11I64D, true);
            CheckSin64("0.0000027526", 9, 13, Intar.Mathi.SinInternal.P11I64E, true);
            CheckSin64("0.0000000239", 11, 19, Intar.Mathi.SinInternal.P11I64F, false);
            CheckSin64("0.4999999963", 2, 0, Intar.Mathi.SinInternal.P10I64A, true);
            CheckSin64("0.0416666418", 4, 2, Intar.Mathi.SinInternal.P10I64B, true);
            CheckSin64("0.0013888397", 6, 6, Intar.Mathi.SinInternal.P10I64C, true);
            CheckSin64("0.0000247609", 8, 11, Intar.Mathi.SinInternal.P10I64D, true);
            CheckSin64("0.0000002605", 10, 16, Intar.Mathi.SinInternal.P10I64E, false);
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
