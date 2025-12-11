using NUnit.Framework;
using NUnit.Framework.Interfaces;
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
        struct X {
            public int i;
            public int p;
            public ulong v;
            public X(int i, int p, ulong v) {
                this.i = i;
                this.p = p;
                this.v = v;
            }
        }
        struct Y {
            public string s;
            public X[] x;
            public Y(string s, X[] x) {
                this.s = s;
                this.x = x;
            }
        }
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
            var x = new Y[] {
                new Y("1.5707288", new X[] { new X(k2 + ks[0], k2, Intar.Mathi.AsinInternal.P3U32A), new X(k3 + ks[0], k3, Intar.Mathi.AsinInternal.P3U64A), }),
                new Y("0.2121144", new X[] { new X(k2 + ks[1], k2, Intar.Mathi.AsinInternal.P3U32B), new X(k3 + ks[1], k3, Intar.Mathi.AsinInternal.P3U64B), }),
                new Y("0.0742610", new X[] { new X(k2 + ks[2], k2, Intar.Mathi.AsinInternal.P3U32C), new X(k3 + ks[2], k3, Intar.Mathi.AsinInternal.P3U64C), }),
                new Y("0.0187293", new X[] { new X(k4 + ks[2], k4 - (ks[3] - ks[2]), 25005), new X(k5 + ks[2], k5 - (ks[3] - ks[2]), 1638745487), }),
                new Y("1.5707963050",new X[] { new X(k3 + ks[4], k3, Intar.Mathi.AsinInternal.P7U64A) } ),
                new Y("0.2145988016",new X[] { new X(k3 + ks[5], k3, Intar.Mathi.AsinInternal.P7U64B) } ),
                new Y("0.0889789874",new X[] { new X(k3 + ks[6], k3, Intar.Mathi.AsinInternal.P7U64C) } ),
                new Y("0.0501743046",new X[] { new X(k3 + ks[7], k3, Intar.Mathi.AsinInternal.P7U64D) } ),
                new Y("0.0308918810",new X[] { new X(k3 + ks[8], k3, Intar.Mathi.AsinInternal.P7U64E) } ),
                new Y("0.0170881256",new X[] { new X(k3 + ks[9], k3, Intar.Mathi.AsinInternal.P7U64F) } ),
                new Y("0.0066700901",new X[] { new X(k3 + ks[10], k3, Intar.Mathi.AsinInternal.P7U64G) } ),
                new Y("0.0012624911",new X[] { new X(k5 + ks[10], k5 - (ks[11] - ks[10]), 883706959) } ),
            };
            foreach (var item in x) {
                var k = ParseReal(item.s);
                var lower = frac2PiLower * k;
                var upper = frac2PiUpper * k;
                foreach (var item2 in item.x) {
                    var l = lower;
                    var u = upper;
                    for (var i = 0; i < item2.i; i++) {
                        l *= 2;
                        u *= 2;
                    }
                    Utility.AssertAreEqual((ulong)l.Round(), item2.v);
                    Utility.AssertAreEqual((ulong)u.Round(), item2.v);
                    Assert.IsTrue(1UL << item2.p < item2.v);
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
            var cases = new Y[] {
                new Y("0.273", new X[] { new X(k4 + ks[0], k4 - (ks[1] - ks[0]), 22780), new X(k5 + ks[0], k5 - (ks[1] - ks[0]), 1492906562) } ),
                new Y("0.2447", new X[] { new X(k2 + ks[3], k2, Intar.Mathi.AtanInternal.P3U32B), new X(k3 + ks[3], k3, Intar.Mathi.AtanInternal.P3U64B) }),
                new Y("0.0663", new X[] { new X(k4 + ks[3], k4 - (ks[4] - ks[3]), 22129), new X(k5 + ks[3], k5 - (ks[4] - ks[3]), 1450252089) } ),
                new Y("0.9998660", new X[] { new X(k3 + ks[5], k3, Intar.Mathi.AtanInternal.P9U64A) }),
                new Y("0.3302995", new X[] { new X(k3 + ks[6], k3, Intar.Mathi.AtanInternal.P9U64B) }),
                new Y("0.1801410", new X[] { new X(k3 + ks[7], k3, Intar.Mathi.AtanInternal.P9U64C) }),
                new Y("0.0851330", new X[] { new X(k3 + ks[8], k3, Intar.Mathi.AtanInternal.P9U64D) }),
                new Y("0.0208351", new X[] { new X(k5 + ks[8], k5 - (ks[9] - ks[8]), 1822995312) }),
            };
            foreach (var item in cases) {
                var k = ParseReal(item.s);
                var lower = frac1PiLower * k;
                var upper = frac1PiUpper * k;
                foreach (var item2 in item.x) {
                    var l = lower;
                    var u = upper;
                    for (var i = 0; i < item2.i; i++) {
                        l *= 2;
                        u *= 2;
                    }
                    Utility.AssertAreEqual((ulong)l.Round(), item2.v);
                    Utility.AssertAreEqual((ulong)u.Round(), item2.v);
                    Assert.IsTrue(1UL << item2.p < item2.v);
                }
            }
        }

        [Test]
        public static void TestSinConstant() {
            var cases = new[] {
                //("1.0", 1, 63 + 0, Intar.Mathi.SinInternal.P5I64A),
                ("0.16605", 3, 63 + 1, Intar.Mathi.SinInternal.P5I64B),
                //("0.00761", 5, 63 + 4, Intar.Mathi.SinInternal.P5I64C),
                ("0.49670", 2, 63 + 0, Intar.Mathi.SinInternal.P4I64A),
                //("0.03705", 4, 63 + 3, Intar.Mathi.SinInternal.P4I64B),
            };
            foreach (var c in cases) {
                var k = ParseReal(c.Item1);
                var lower = fracPi2Lower.Pow(c.Item2) * k;
                var upper = fracPi2Upper.Pow(c.Item2) * k;
                for (var i = 0; i < c.Item3; i++) {
                    lower *= 2;
                    upper *= 2;
                }
                Utility.AssertAreEqual((ulong)lower.Round(), c.Item4, $"{c.Item3}");
                Utility.AssertAreEqual((ulong)upper.Round(), c.Item4, $"{c.Item3}");
            }
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
            var sin = new string[] {
                "1.0",
                "0.16605",
                "0.00761",
                "0.49670",
                "0.03705",
                "0.1666666664",
                "0.0083333315",
                "0.0001984090",
                "0.0000027526",
                "0.0000000239",
                "0.4999999963",
                "0.0416666418",
                "0.0013888397",
                "0.0000247609",
                "0.0000002605",
            };

            // Sin P11 64
            {
                const int index = 9;
                const int k1 = 19;
                const int k2 = 13;
                const int k3 = k1 - k2;
                const int k4 = 63 - 31 - k3;
                const int k5 = -32 - k2;
                var r = ParseReal(sin[index]);
                var l = r * fracPi2Lower.Pow(11);
                var u = r * fracPi2Upper.Pow(11);
                var expected64 = new BigInteger((Intar.Mathi.SinInternal.P11I64F + (1UL << (31 + k3 - 1))) >> (31 + k3));
                var a64L = Calc(l, true, k4);
                var a64U = Calc(u, true, k4);
                Assert.AreEqual(a64L.Value.exp, k5);
                Assert.AreEqual(a64L.Value.frac, a64U.Value.frac);
                Assert.AreEqual(a64L.Value.frac, expected64);
                Assert.AreEqual(a64U.Value.exp, k5);
                Assert.AreEqual(a64U.Value.frac, expected64);
            }

            // Sin P10 64
            {
                const int index = 14;
                const int k = 5;
                var r = ParseReal(sin[index]);
                var l = r * fracPi2Lower.Pow(10);
                var u = r * fracPi2Upper.Pow(10);
                var expected64 = new BigInteger((Intar.Mathi.SinInternal.P10I64E + (1UL << (31 + k - 1))) >> (31 + k));
                var a64L = Calc(l, true, 63 - 31 - k);
                var a64U = Calc(u, true, 63 - 31 - k);
                Assert.AreEqual(a64L.Value.exp, -32 - 11);
                Assert.AreEqual(a64L.Value.frac, a64U.Value.frac);
                Assert.AreEqual(a64L.Value.frac, expected64);
                Assert.AreEqual(a64U.Value.exp, -32 - 11);
                Assert.AreEqual(a64U.Value.frac, expected64);
            }

            // Sin P5
            {
                const int index = 2;
                const int k = 3;
                var r = ParseReal(sin[index]);
                var l = r * fracPi2Lower.Pow(5);
                var u = r * fracPi2Upper.Pow(5);
                var expected32 = new BigInteger((Intar.Mathi.SinInternal.P5I32C + (1UL << (15 + k - 1))) >> (15 + k));
                var expected64 = new BigInteger((Intar.Mathi.SinInternal.P5I64C + (1UL << (31 + k - 1))) >> (31 + k));
                var a32L = Calc(l, true, 31 - 15 - k);
                var a32U = Calc(u, true, 31 - 15 - k);
                var a64L = Calc(l, true, 63 - 31 - k);
                var a64U = Calc(u, true, 63 - 31 - k);
                Assert.AreEqual(a32L.Value.exp, -15 - (3 - 1));
                Assert.AreEqual(a32L.Value.frac, a32U.Value.frac);
                Assert.AreEqual(a32L.Value.frac, expected32);
                Assert.AreEqual(a32U.Value.exp, -15 - (3 - 1));
                Assert.AreEqual(a32U.Value.frac, expected32);
                Assert.AreEqual(a64L.Value.exp, -31 - (3 - 1));
                Assert.AreEqual(a64L.Value.frac, a64U.Value.frac);
                Assert.AreEqual(a64L.Value.frac, expected64);
                Assert.AreEqual(a64U.Value.exp, -31 - (3 - 1));
                Assert.AreEqual(a64U.Value.frac, expected64);
            }

            // Sin P4
            {
                const int index = 4;
                const int k = 3;
                var r = ParseReal(sin[index]);
                var l = r * fracPi2Lower.Pow(4);
                var u = r * fracPi2Upper.Pow(4);
                var expected32 = new BigInteger((Intar.Mathi.SinInternal.P4I32B + (1UL << (15 + k - 1))) >> (15 + k));
                var expected64 = new BigInteger((Intar.Mathi.SinInternal.P4I64B + (1UL << (31 + k - 1))) >> (31 + k));
                var a32L = Calc(l, true, 31 - 15 - k);
                var a32U = Calc(u, true, 31 - 15 - k);
                var a64L = Calc(l, true, 63 - 31 - k);
                var a64U = Calc(u, true, 63 - 31 - k);
                Assert.AreEqual(a32L.Value.exp, -15 - (3 - 2));
                Assert.AreEqual(a32L.Value.frac, a32U.Value.frac);
                Assert.AreEqual(a32L.Value.frac, expected32);
                Assert.AreEqual(a32U.Value.exp, -15 - (3 - 2));
                Assert.AreEqual(a32U.Value.frac, expected32);
                Assert.AreEqual(a64L.Value.exp, -31 - (3 - 2));
                Assert.AreEqual(a64L.Value.frac, a64U.Value.frac);
                Assert.AreEqual(a64L.Value.frac, expected64);
                Assert.AreEqual(a64U.Value.exp, -31 - (3 - 2));
                Assert.AreEqual(a64U.Value.frac, expected64);
            }

            CheckSin32(sin[0], 1, 0, Intar.Mathi.SinInternal.P5I32A, true);
            CheckSin64(sin[0], 1, 0, Intar.Mathi.SinInternal.P5I64A, true);
            CheckSin64(sin[0], 1, 0, Intar.Mathi.SinInternal.P11I64A, true);
            CheckSin32(sin[1], 3, 1, Intar.Mathi.SinInternal.P5I32B, true);
            CheckSin64(sin[1], 3, 1, Intar.Mathi.SinInternal.P5I64B, true);
            CheckSin32(sin[2], 5, 4, Intar.Mathi.SinInternal.P5I32C, false);
            CheckSin64(sin[2], 5, 4, Intar.Mathi.SinInternal.P5I64C, false);
            CheckSin32(sin[3], 2, 0, Intar.Mathi.SinInternal.P4I32A, true);
            CheckSin64(sin[3], 2, 0, Intar.Mathi.SinInternal.P4I64A, true);
            CheckSin32(sin[4], 4, 3, Intar.Mathi.SinInternal.P4I32B, false);
            CheckSin64(sin[4], 4, 3, Intar.Mathi.SinInternal.P4I64B, false);
            CheckSin64(sin[5], 3, 1, Intar.Mathi.SinInternal.P11I64B, true);
            CheckSin64(sin[6], 5, 4, Intar.Mathi.SinInternal.P11I64C, true);
            CheckSin64(sin[7], 7, 8, Intar.Mathi.SinInternal.P11I64D, true);
            CheckSin64(sin[8], 9, 13, Intar.Mathi.SinInternal.P11I64E, true);
            CheckSin64(sin[9], 11, 19, Intar.Mathi.SinInternal.P11I64F, false);
            CheckSin64(sin[10], 2, 0, Intar.Mathi.SinInternal.P10I64A, true);
            CheckSin64(sin[11], 4, 2, Intar.Mathi.SinInternal.P10I64B, true);
            CheckSin64(sin[12], 6, 6, Intar.Mathi.SinInternal.P10I64C, true);
            CheckSin64(sin[13], 8, 11, Intar.Mathi.SinInternal.P10I64D, true);
            CheckSin64(sin[14], 10, 16, Intar.Mathi.SinInternal.P10I64E, false);
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
