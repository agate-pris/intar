using System;

using NUnit.Framework;

namespace Intar.Tests.Mathi {
    public class AtanTest {
        [Test]
        public static void TestConsts() {
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

            var p2K32B = (k4 + ks[0], k4 - k6, Intar.Mathi.AtanInternal.P2U32B);
            var p2K64B = (k5 + ks[0], k5 - k6, Intar.Mathi.AtanInternal.P2U64B);
            var p3K32B = (k2 + ks[3], k2, Intar.Mathi.AtanInternal.P3U32B);
            var p3K32C = (k4 + ks[3], k4 - k7, Intar.Mathi.AtanInternal.P3U32C);
            var p3K64B = (k3 + ks[3], k3, Intar.Mathi.AtanInternal.P3U64B);
            var p3K64C = (k5 + ks[3], k5 - k7, Intar.Mathi.AtanInternal.P3U64C);
            var p9K64A = (k3 + ks[5], k3, Intar.Mathi.AtanInternal.P9U64A);
            var p9K64B = (k3 + ks[6], k3, Intar.Mathi.AtanInternal.P9U64B);
            var p9K64C = (k3 + ks[7], k3, Intar.Mathi.AtanInternal.P9U64C);
            var p9K64D = (k3 + ks[8], k3, Intar.Mathi.AtanInternal.P9U64D);
            var p9K64E = (k5 + ks[8], k5 - (ks[9] - ks[8]), Intar.Mathi.AtanInternal.P9U64E);

            var cases = new[] {
                ("0.273", new[] { p2K32B, p2K64B } ),
                ("0.2447", new[] { p3K32B, p3K64B }),
                ("0.0663", new[] { p3K32C, p3K64C } ),
                ("0.9998660", new[] { p9K64A }),
                ("0.3302995", new[] { p9K64B }),
                ("0.1801410", new[] { p9K64C }),
                ("0.0851330", new[] { p9K64D }),
                ("0.0208351", new[] { p9K64E }),
            };

            foreach (var c in cases) {
                var k = BigRationalTest.ParseReal(c.Item1);
                var lower = k * BigRationalTest.Frac1PiLower;
                var upper = k * BigRationalTest.Frac1PiUpper;
                foreach (var precision in c.Item2) {
                    BigRationalTest.Test(lower, upper, precision.Item1, precision.Item3, precision.Item2);
                }
            }
        }

        [Test]
        public static void TestInvInt() {
            // K = 2^15
            //   = 32768
            // y = (2 * 2 ^ K + x) / (2x)
            //   = 2 ^ K / x + 0.5
            // x = 2 ^ K / (y - 0.5)
            // x = 2 * 2 ^ K / (2y - 1)
            Utility.AssertAreEqual(1, Intar.Mathi.AtanInternal.Inv(int.MaxValue));
            Utility.AssertAreEqual(-1, Intar.Mathi.AtanInternal.Inv(int.MinValue));
            Utility.AssertAreEqual(102, Intar.Mathi.AtanInternal.Inv(10_578_737));
            Utility.AssertAreEqual(101, Intar.Mathi.AtanInternal.Inv(10_578_738));
            Utility.AssertAreEqual(101, Intar.Mathi.AtanInternal.Inv(10_683_998));
            Utility.AssertAreEqual(100, Intar.Mathi.AtanInternal.Inv(10_683_999));
            Utility.AssertAreEqual(-102, Intar.Mathi.AtanInternal.Inv(-10_578_737));
            Utility.AssertAreEqual(-101, Intar.Mathi.AtanInternal.Inv(-10_578_738));
            Utility.AssertAreEqual(-101, Intar.Mathi.AtanInternal.Inv(-10_683_998));
            Utility.AssertAreEqual(-100, Intar.Mathi.AtanInternal.Inv(-10_683_999));
            for (var i = 2; i <= (1 << 15); i++) {
                var p = (int)((1U << 31) / ((2 * (uint)i) - 1));
                Utility.AssertAreEqual(i, Intar.Mathi.AtanInternal.Inv(p));
                Utility.AssertAreEqual(i - 1, Intar.Mathi.AtanInternal.Inv(p + 1));
                Utility.AssertAreEqual(-i, Intar.Mathi.AtanInternal.Inv(-p));
                Utility.AssertAreEqual(-i + 1, Intar.Mathi.AtanInternal.Inv(-p - 1));
            }
        }
        [Test]
        public static void TestInvLong() {
            Utility.AssertAreEqual(1, Intar.Mathi.AtanInternal.Inv(long.MaxValue));
            Utility.AssertAreEqual(-1, Intar.Mathi.AtanInternal.Inv(long.MinValue));
            Console.WriteLine((1L << 62) / 101.5m);
            Console.WriteLine((1L << 62) / 100.5m);
            Utility.AssertAreEqual(102, Intar.Mathi.AtanInternal.Inv(45_435_330_230_811_703));
            Utility.AssertAreEqual(101, Intar.Mathi.AtanInternal.Inv(45_435_330_230_811_704));
            Utility.AssertAreEqual(101, Intar.Mathi.AtanInternal.Inv(45_887_423_068_929_232));
            Utility.AssertAreEqual(100, Intar.Mathi.AtanInternal.Inv(45_887_423_068_929_233));
            Utility.AssertAreEqual(-102, Intar.Mathi.AtanInternal.Inv(-45_435_330_230_811_703));
            Utility.AssertAreEqual(-101, Intar.Mathi.AtanInternal.Inv(-45_435_330_230_811_704));
            Utility.AssertAreEqual(-101, Intar.Mathi.AtanInternal.Inv(-45_887_423_068_929_232));
            Utility.AssertAreEqual(-100, Intar.Mathi.AtanInternal.Inv(-45_887_423_068_929_233));
            for (var x = 2; x < 10; x++) {
                var p = (long)((1UL << 63) / ((2 * (ulong)x) - 1));
                Utility.AssertAreEqual(x, Intar.Mathi.AtanInternal.Inv(p));
                Utility.AssertAreEqual(x - 1, Intar.Mathi.AtanInternal.Inv(p + 1));
                Utility.AssertAreEqual(-x, Intar.Mathi.AtanInternal.Inv(-p));
                Utility.AssertAreEqual(-x + 1, Intar.Mathi.AtanInternal.Inv(-p - 1));
            }
            const long one = 1L << 31;
            for (var x = one - 9; x <= one; ++x) {
                var p = (long)((1UL << 63) / ((2 * (ulong)x) - 1));
                Utility.AssertAreEqual(x, Intar.Mathi.AtanInternal.Inv(p));
                Utility.AssertAreEqual(x - 1, Intar.Mathi.AtanInternal.Inv(p + 1));
                Utility.AssertAreEqual(-x, Intar.Mathi.AtanInternal.Inv(-p));
                Utility.AssertAreEqual(-x + 1, Intar.Mathi.AtanInternal.Inv(-p - 1));
            }
            var rng = new Intar.Rand.Xoroshiro128StarStar(1, 2);
            for (var i = 0; i < 32768; ++i) {
                var x = rng.NextInt64(10, one - 9);
                var p = (long)((1UL << 63) / ((2 * (ulong)x) - 1));
                Utility.AssertAreEqual(x, Intar.Mathi.AtanInternal.Inv(p));
                Utility.AssertAreEqual(x - 1, Intar.Mathi.AtanInternal.Inv(p + 1));
                Utility.AssertAreEqual(-x, Intar.Mathi.AtanInternal.Inv(-p));
                Utility.AssertAreEqual(-x + 1, Intar.Mathi.AtanInternal.Inv(-p - 1));
            }
        }

        static void TestAtan(
            int[] expectedHead,
            int[] expectedTail,
            double error, Func<int, int> atan) {
            const int one = 1 << 15;
            const int pi = 1 << 30;
            const double toReal = 1.0 / one;
            const double toRad = Math.PI / pi;

            Utility.AssertAreEqual(0, atan(0));
            Utility.AssertAreEqual(pi / 4, atan(1 << 15));
            Utility.AssertAreEqual(-pi / 4, atan(-1 << 15));

            Utility.AssertAreEqual((pi / 2) - expectedHead[1], atan(int.MaxValue));
            Utility.AssertAreEqual(expectedHead[1] - (pi / 2), atan(int.MinValue));
            Utility.AssertAreEqual(Math.Atan(int.MaxValue * toReal), atan(int.MaxValue) * toRad, error);
            Utility.AssertAreEqual(Math.Atan(int.MinValue * toReal), atan(int.MinValue) * toRad, error);
            {
                for (var i = 0; i < expectedHead.Length; ++i) {
                    Console.WriteLine($"atan({i})={atan(i)}");
                }
                for (var i = 0; i < expectedHead.Length; ++i) {
                    var actual = atan(i);
                    Utility.AssertAreEqual(expectedHead[i], actual);
                    Utility.AssertAreEqual(-actual, atan(-i));
                }
                for (var i = 0; i < expectedTail.Length; ++i) {
                    var x = one - i;
                    Console.WriteLine($"atan({x})={atan(x)}");
                }
                for (var i = 0; i < expectedTail.Length; ++i) {
                    var x = one - i;
                    var actual = atan(x);
                    Utility.AssertAreEqual(expectedTail[i], actual);
                    Utility.AssertAreEqual(-actual, atan(-x));
                }
            }
            for (var x = 0; x <= 32768; ++x) {
                var expectedReal = Math.Atan(x * toReal);
                var actual = atan(x);
                Utility.AssertAreEqual(expectedReal, actual * toRad, error);
            }
            var rng = new Intar.Rand.Xoroshiro128StarStar(1, 2);
            for (var i = 0; i < 32768; ++i) {
                var x = rng.Next(int.MinValue, -one);
                Utility.AssertAreEqual(Math.Atan(x * toReal), atan(x) * toRad, error);
                Utility.AssertAreEqual(Math.Atan(-x * toReal), atan(-x) * toRad, error);
            }
        }

        static void TestAtan(
            long[] expectedHead,
            long[] expectedTail,
            double error, Func<long, long> atan) {
            const long one = 1L << 31;
            const long pi = 1L << 62;
            const double toReal = 1.0 / one;
            const double toRad = Math.PI / pi;

            Utility.AssertAreEqual(0, atan(0));
            Utility.AssertAreEqual(pi / 4, atan(1L << 31));
            Utility.AssertAreEqual(-pi / 4, atan(-1L << 31));

            Utility.AssertAreEqual((pi / 2) - expectedHead[1], atan(long.MaxValue));
            Utility.AssertAreEqual(expectedHead[1] - (pi / 2), atan(long.MinValue));
            Utility.AssertAreEqual(Math.Atan(long.MaxValue * toReal), atan(long.MaxValue) * toRad, error);
            Utility.AssertAreEqual(Math.Atan(long.MinValue * toReal), atan(long.MinValue) * toRad, error);

            {
                for (var i = 0; i < expectedHead.Length; ++i) {
                    Console.WriteLine($"atan({i})={atan(i)}");
                }
                for (var i = 0; i < expectedHead.Length; ++i) {
                    var actual = atan(i);
                    var actualNeg = atan(-i);
                    Utility.AssertAreEqual(expectedHead[i], actual);
                    Utility.AssertAreEqual(-actual, actualNeg);
                    Utility.AssertAreEqual(Math.Atan(i * toReal), actual * toRad, error);
                    Utility.AssertAreEqual(Math.Atan(-i * toReal), actualNeg * toRad, error);
                }
                for (var i = 0; i < expectedTail.Length; ++i) {
                    var x = one - i;
                    Console.WriteLine($"atan({x})={atan(x)}");
                }
                for (var i = 0; i < expectedTail.Length; ++i) {
                    var x = one - i;
                    var actual = atan(x);
                    var actualNeg = atan(-x);
                    Utility.AssertAreEqual(expectedTail[i], actual);
                    Utility.AssertAreEqual(-actual, actualNeg);
                    Utility.AssertAreEqual(Math.Atan(x * toReal), actual * toRad, error);
                    Utility.AssertAreEqual(Math.Atan(-x * toReal), actualNeg * toRad, error);
                }
            }
            var rng = new Intar.Rand.Xoroshiro128StarStar(1, 2);
            for (var i = 0; i < 32768; ++i) {
                var x = rng.NextInt64(one + 1);
                Utility.AssertAreEqual(Math.Atan(x * toReal), atan(x) * toRad, error);
                Utility.AssertAreEqual(Math.Atan(-x * toReal), atan(-x) * toRad, error);
            }
            for (var i = 0; i < 32768; ++i) {
                var x = rng.NextInt64(long.MinValue, -one);
                Utility.AssertAreEqual(Math.Atan(x * toReal), atan(x) * toRad, error);
                Utility.AssertAreEqual(Math.Atan(-x * toReal), atan(-x) * toRad, error);
            }
        }

        [Test]
        public static void TestAtanP2() {
            var head = new int[] {
                0,
                11039, 22078, 33117,
                44156, 55195, 66228,
                77266, 88304, 99342,
            };
            var tail = new int[] {
                268435456, 268427264, 268419072, 268410880, 268402688,
                268394496, 268386304, 268378112, 268369920, 268361728,
            };
            TestAtan(head, tail, 0.0039, Intar.Mathi.AtanP2);
        }

        [Test]
        public static void TestAtanP3() {
            var head = new int[] {
                0,
                10744, 21488, 32232,
                42976, 53715, 64458,
                75201, 85944, 96687,
            };
            var tail = new int[] {
                268435456, 268427264, 268419072, 268410880, 268402688,
                268394496, 268386304, 268378112, 268369920, 268361728,
            };
            TestAtan(head, tail, 0.0016, Intar.Mathi.AtanP3);
        }

        [Test]
        public static void TestAtanP9() {
            var head = new long[] {
                0, 683473677,
                1366947354, 2050421031, 2733894708, 3417368385,
                4100842062, 4784315739, 5467789416, 6151263093,
            };
            var tail = new long[] {
                1152921504606846976, // 2^60, used for high-precision symmetry fix
                1152938290949644663,
                1152938290412765934, 1152938289875887205,
                1152938291486492120, 1152938290949613390,
                1152938290412734660, 1152938289875855930,
                1152938289338977200, 1152938288802098470,
            };
            TestAtan(head, tail, 0.00002, Intar.Mathi.AtanP9);
        }

        [Test]
        public static void TestDiv() {
            const int k1 = 1 << 15;
            const int k2 = -k1;
            Utility.AssertAreEqual(k1, Intar.Mathi.AtanInternal.Div(int.MinValue, int.MinValue));
            Utility.AssertAreEqual(k2, Intar.Mathi.AtanInternal.Div(int.MinValue, int.MaxValue));
            Utility.AssertAreEqual(k2, Intar.Mathi.AtanInternal.Div(int.MaxValue, int.MinValue));
            Utility.AssertAreEqual(k1, Intar.Mathi.AtanInternal.Div(int.MaxValue, int.MaxValue));
            for (var i = 0; i < k1; ++i) {
                var e1 = i;
                var e2 = e1 + 1;
                var e3 = -e1;
                var e4 = -e2;
                var y2 = ((2 * i) + 1) << 15;
                var y1 = y2 - 1;
                Utility.AssertAreEqual(e1, Intar.Mathi.AtanInternal.Div(y1, int.MaxValue));
                Utility.AssertAreEqual(e2, Intar.Mathi.AtanInternal.Div(y2, int.MaxValue));
                Utility.AssertAreEqual(e3, Intar.Mathi.AtanInternal.Div(y1, int.MinValue));
                Utility.AssertAreEqual(e4, Intar.Mathi.AtanInternal.Div(y2, int.MinValue));
            }
        }

        static void TestAtan2(
            Func<int, int, int> atan2,
            Func<int, int> atan, double error) {
            const int pi = 1 << 30;
            const int pi_2 = pi / 2;
            const int pi_4 = pi / 4;

            Utility.AssertAreEqual(0, atan2(0, 0));
            Utility.AssertAreEqual(0, atan2(0, 1));
            Utility.AssertAreEqual(pi_2, atan2(1, 0));
            Utility.AssertAreEqual(-pi_2, atan2(-1, 0));
            Utility.AssertAreEqual(pi, atan2(0, -1));
            Utility.AssertAreEqual(pi_4, atan2(1, 1));
            Utility.AssertAreEqual(pi_4 + pi_2, atan2(1, -1));
            Utility.AssertAreEqual(pi_4 - pi_2, atan2(-1, 1));
            Utility.AssertAreEqual(pi_4 - pi, atan2(-1, -1));

            for (var i = 1; i <= 32768; ++i) {
                const int k1 = 1 << 16;
                const int k2 = -k1;
                const int k3 = 1 << 30;
                const int k4 = k3 / 2;
                var expected1 = atan(i);
                var expected4 = -expected1;
                var expected3 = expected1 - k3;
                var expected2 = k3 - expected1;
                var expected5 = k4 - expected1;
                var expected8 = -expected5;
                var expected7 = expected5 - k3;
                var expected6 = k3 - expected5;
                var p12 = 2 * i;
                var p11 = p12 - 1;
                var p41 = -p11;
                var p42 = -p12;
                Utility.AssertAreEqual(expected1, atan2(p11, k1), $"{i}");
                Utility.AssertAreEqual(expected1, atan2(p12, k1), $"{i}");
                Utility.AssertAreEqual(expected2, atan2(p11, k2), $"{i}");
                Utility.AssertAreEqual(expected2, atan2(p12, k2), $"{i}");
                Utility.AssertAreEqual(expected4, atan2(p41, k1), $"{i}");
                Utility.AssertAreEqual(expected4, atan2(p42, k1), $"{i}");
                Utility.AssertAreEqual(expected3, atan2(p41, k2), $"{i}");
                Utility.AssertAreEqual(expected3, atan2(p42, k2), $"{i}");
                Utility.AssertAreEqual(expected5, atan2(k1, p11), $"{i}");
                Utility.AssertAreEqual(expected5, atan2(k1, p12), $"{i}");
                Utility.AssertAreEqual(expected8, atan2(k2, p11), $"{i}");
                Utility.AssertAreEqual(expected8, atan2(k2, p12), $"{i}");
                Utility.AssertAreEqual(expected6, atan2(k1, p41), $"{i}");
                Utility.AssertAreEqual(expected6, atan2(k1, p42), $"{i}");
                Utility.AssertAreEqual(expected7, atan2(k2, p41), $"{i}");
                Utility.AssertAreEqual(expected7, atan2(k2, p42), $"{i}");
            }
            const double toRad = Math.PI / pi;
            var rng = new Intar.Rand.Xoroshiro128StarStar(1, 2);
            var max = 0.0;
            for (var i = 0; i < 32768; ++i) {
                var x = rng.Next();
                var y = rng.Next();
                var expected = Math.Atan2(y, x);
                var actual = atan2(y, x);
                Utility.AssertAreEqual(expected, actual * toRad, error);
                max = Math.Max(max, Math.Abs(expected - (actual * toRad)));
            }
            Console.WriteLine($"max error: {max}");
        }

#if NET7_0_OR_GREATER

        static void TestAtan2(
            Func<long, long, long> atan2,
            Func<long, long> atan, double error) {
            const long pi = 1L << 62;
            const long pi_2 = pi / 2;
            const long pi_4 = pi / 4;

            Utility.AssertAreEqual(0, atan2(0, 0));
            Utility.AssertAreEqual(0, atan2(0, 1));
            Utility.AssertAreEqual(pi_2, atan2(1, 0));
            Utility.AssertAreEqual(-pi_2, atan2(-1, 0));
            Utility.AssertAreEqual(pi, atan2(0, -1));
            Utility.AssertAreEqual(pi_4, atan2(1, 1));
            Utility.AssertAreEqual(pi_4 + pi_2, atan2(1, -1));
            Utility.AssertAreEqual(pi_4 - pi_2, atan2(-1, 1));
            Utility.AssertAreEqual(pi_4 - pi, atan2(-1, -1));

            for (var i = 1L; i <= 1L << 31; i += 1024) {
                const long k1 = 1L << 32;
                const long k2 = -k1;
                const long k3 = pi / 2;
                var expected1 = atan(i);
                var expected4 = -expected1;
                var expected3 = expected1 - pi;
                var expected2 = pi - expected1;
                var expected5 = k3 - expected1;
                var expected8 = -expected5;
                var expected7 = expected5 - pi;
                var expected6 = pi - expected5;
                var p12 = 2 * i;
                var p11 = p12 - 1;
                var p41 = -p11;
                var p42 = -p12;
                Utility.AssertAreEqual(expected1, atan2(p11, k1), $"{i}");
                Utility.AssertAreEqual(expected1, atan2(p12, k1), $"{i}");
                Utility.AssertAreEqual(expected2, atan2(p11, k2), $"{i}");
                Utility.AssertAreEqual(expected2, atan2(p12, k2), $"{i}");
                Utility.AssertAreEqual(expected4, atan2(p41, k1), $"{i}");
                Utility.AssertAreEqual(expected4, atan2(p42, k1), $"{i}");
                Utility.AssertAreEqual(expected3, atan2(p41, k2), $"{i}");
                Utility.AssertAreEqual(expected3, atan2(p42, k2), $"{i}");
                Utility.AssertAreEqual(expected5, atan2(k1, p11), $"{i}");
                Utility.AssertAreEqual(expected5, atan2(k1, p12), $"{i}");
                Utility.AssertAreEqual(expected8, atan2(k2, p11), $"{i}");
                Utility.AssertAreEqual(expected8, atan2(k2, p12), $"{i}");
                Utility.AssertAreEqual(expected6, atan2(k1, p41), $"{i}");
                Utility.AssertAreEqual(expected6, atan2(k1, p42), $"{i}");
                Utility.AssertAreEqual(expected7, atan2(k2, p41), $"{i}");
                Utility.AssertAreEqual(expected7, atan2(k2, p42), $"{i}");
            }
            const double toRad = Math.PI / pi;
            var rng = new Intar.Rand.Xoroshiro128StarStar(1, 2);
            var max = 0.0;
            for (var i = 0; i < 32768; ++i) {
                var x = rng.NextInt64();
                var y = rng.NextInt64();
                var expected = Math.Atan2(y, x);
                var actual = atan2(y, x);
                Utility.AssertAreEqual(expected, actual * toRad, error);
                max = Math.Max(max, Math.Abs(expected - (actual * toRad)));
            }
            Console.WriteLine($"max error: {max}");
        }

#endif

        [Test] public static void TestAtan2P2() => TestAtan2(Intar.Mathi.Atan2P2, Intar.Mathi.AtanP2, 0.0039);
        [Test] public static void TestAtan2P3() => TestAtan2(Intar.Mathi.Atan2P3, Intar.Mathi.AtanP3, 0.0016);

#if NET7_0_OR_GREATER

        [Test] public static void TestAtan2P2L() => TestAtan2(Intar.Mathi.Atan2P2, Intar.Mathi.AtanP2, 0.0039);
        [Test] public static void TestAtan2P3L() => TestAtan2(Intar.Mathi.Atan2P3, Intar.Mathi.AtanP3, 0.0016);
        [Test] public static void TestAtan2P9L() => TestAtan2(Intar.Mathi.Atan2P9, Intar.Mathi.AtanP9, 0.00002);

#endif

        [Test]
        public static void TestAtanP2Overflow() {
            const uint z = 1U << 15;
            const uint k = (1U << 31) + (Intar.Mathi.AtanInternal.P2U32B * z);
            Console.WriteLine($"{uint.MaxValue}\n{k}");
            Assert.IsTrue(uint.MaxValue >= k);
        }

        [Test]
        public static void TestAtanP2LOverflow() {
            const ulong z = 1UL << 31;
            const ulong k = (1UL << 63) + (Intar.Mathi.AtanInternal.P2U64B * z);
            Console.WriteLine($"{ulong.MaxValue}\n{k}");
            Assert.IsTrue(ulong.MaxValue >= k);
        }

        [Test]
        public static void TestAtanP3Overflow() {
            const uint z = 1U << 15;
            const uint k1 = Intar.Mathi.AtanInternal.P3U32B + (Intar.Mathi.AtanInternal.P3U32C * z);
            Console.WriteLine($"{uint.MaxValue}\n{k1}");
            const uint k2 = (1U << 31) + (z * (k1 >> (15 + 4 - 2)));
            Console.WriteLine($"{uint.MaxValue}\n{k2}");
            Assert.IsTrue(uint.MaxValue >= k1);
            Assert.IsTrue(uint.MaxValue >= k2);
        }

        [Test]
        public static void TestAtanP3LOverflow() {
            const ulong z = 1UL << 31;
            const ulong k1 = Intar.Mathi.AtanInternal.P3U64B + (Intar.Mathi.AtanInternal.P3U64C * z);
            Console.WriteLine($"{ulong.MaxValue}\n{k1}");
            const ulong k2 = (1UL << 63) + (z * (k1 >> (31 + 4 - 2)));
            Console.WriteLine($"{ulong.MaxValue}\n{k2}");
            Assert.IsTrue(ulong.MaxValue >= k1);
            Assert.IsTrue(ulong.MaxValue >= k2);
        }

        [Test]
        public static void TestAtanP9Overflow() {
            const ulong z = 1UL << 31;
            const ulong e = z * Intar.Mathi.AtanInternal.P9U64E;
            const ulong d = z * (Intar.Mathi.AtanInternal.P9U64D >> (31 + 6 - 5));
            const ulong c = z * (Intar.Mathi.AtanInternal.P9U64C >> (31 + 5 - 4));
            const ulong b = z * (Intar.Mathi.AtanInternal.P9U64B >> (31 + 4 - 2));
            const ulong a = z * (Intar.Mathi.AtanInternal.P9U64A >> (31 + 3));
            Console.WriteLine($"{Intar.Mathi.AtanInternal.P9U64D}\n{e}");
            Console.WriteLine($"{Intar.Mathi.AtanInternal.P9U64C}\n{d}");
            Console.WriteLine($"{Intar.Mathi.AtanInternal.P9U64B}\n{c}");
            Console.WriteLine($"{Intar.Mathi.AtanInternal.P9U64A}\n{b}");
            Console.WriteLine($"{1UL << 62}\n{a}");
            Assert.IsTrue(Intar.Mathi.AtanInternal.P9U64D >= e);
            Assert.IsTrue(Intar.Mathi.AtanInternal.P9U64C >= d);
            Assert.IsTrue(Intar.Mathi.AtanInternal.P9U64B >= c);
            Assert.IsTrue(Intar.Mathi.AtanInternal.P9U64A >= b);
            Assert.IsTrue((1UL << 62) >= a);
        }
    }
}
