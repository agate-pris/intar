using System;

using NUnit.Framework;

namespace Intar1991.Tests.Mathi {
    public class AtanTest {
        [Test]
        public static void TestConsts() {
            var actual = new ulong[] {
                Intar1991.Mathi.AtanInternal.P9U64A,
                Intar1991.Mathi.AtanInternal.P9U64B,
                Intar1991.Mathi.AtanInternal.P9U64C,
                Intar1991.Mathi.AtanInternal.P9U64D,
                Intar1991.Mathi.AtanInternal.P9U64E,
                Intar1991.Mathi.AtanInternal.P3U64B,
                Intar1991.Mathi.AtanInternal.P3U64C,
                Intar1991.Mathi.AtanInternal.P2U64B,
                Intar1991.Mathi.AtanInternal.P3U32B,
                Intar1991.Mathi.AtanInternal.P3U32C,
                Intar1991.Mathi.AtanInternal.P2U32B,
            };
            for (var i = 0; i < actual.Length; ++i) {
                Console.WriteLine($"{actual[i]},");
            }
            Assert.AreEqual(new ulong[] {
                11741988375818245753,
                15515570644620693826,
                16923976036855135454,
                15996234637818023067,
                15659410489582290881,
                11494598498449691202,
                12457570583526187604,
                12823969718335781357,
                2676294767,
                2900504177,
                2985813123,
            }, actual);
        }

        [Test]
        public static void TestInvInt() {
            // K = 2^15
            //   = 32768
            // y = (2 * 2 ^ K + x) / (2x)
            //   = 2 ^ K / x + 0.5
            // x = 2 ^ K / (y - 0.5)
            // x = 2 * 2 ^ K / (2y - 1)
            Utility.AssertAreEqual(1, Intar1991.Mathi.AtanInternal.Inv(int.MaxValue));
            Utility.AssertAreEqual(-1, Intar1991.Mathi.AtanInternal.Inv(int.MinValue));
            Utility.AssertAreEqual(102, Intar1991.Mathi.AtanInternal.Inv(10_578_737));
            Utility.AssertAreEqual(101, Intar1991.Mathi.AtanInternal.Inv(10_578_738));
            Utility.AssertAreEqual(101, Intar1991.Mathi.AtanInternal.Inv(10_683_998));
            Utility.AssertAreEqual(100, Intar1991.Mathi.AtanInternal.Inv(10_683_999));
            Utility.AssertAreEqual(-102, Intar1991.Mathi.AtanInternal.Inv(-10_578_737));
            Utility.AssertAreEqual(-101, Intar1991.Mathi.AtanInternal.Inv(-10_578_738));
            Utility.AssertAreEqual(-101, Intar1991.Mathi.AtanInternal.Inv(-10_683_998));
            Utility.AssertAreEqual(-100, Intar1991.Mathi.AtanInternal.Inv(-10_683_999));
            for (var i = 2; i <= (1 << 15); i++) {
                var p = (int)((1U << 31) / ((2 * (uint)i) - 1));
                Utility.AssertAreEqual(i, Intar1991.Mathi.AtanInternal.Inv(p));
                Utility.AssertAreEqual(i - 1, Intar1991.Mathi.AtanInternal.Inv(p + 1));
                Utility.AssertAreEqual(-i, Intar1991.Mathi.AtanInternal.Inv(-p));
                Utility.AssertAreEqual(-i + 1, Intar1991.Mathi.AtanInternal.Inv(-p - 1));
            }
        }
        [Test]
        public static void TestInvLong() {
            Utility.AssertAreEqual(1, Intar1991.Mathi.AtanInternal.Inv(long.MaxValue));
            Utility.AssertAreEqual(-1, Intar1991.Mathi.AtanInternal.Inv(long.MinValue));
            Console.WriteLine((1L << 62) / 101.5m);
            Console.WriteLine((1L << 62) / 100.5m);
            Utility.AssertAreEqual(102, Intar1991.Mathi.AtanInternal.Inv(45_435_330_230_811_703));
            Utility.AssertAreEqual(101, Intar1991.Mathi.AtanInternal.Inv(45_435_330_230_811_704));
            Utility.AssertAreEqual(101, Intar1991.Mathi.AtanInternal.Inv(45_887_423_068_929_232));
            Utility.AssertAreEqual(100, Intar1991.Mathi.AtanInternal.Inv(45_887_423_068_929_233));
            Utility.AssertAreEqual(-102, Intar1991.Mathi.AtanInternal.Inv(-45_435_330_230_811_703));
            Utility.AssertAreEqual(-101, Intar1991.Mathi.AtanInternal.Inv(-45_435_330_230_811_704));
            Utility.AssertAreEqual(-101, Intar1991.Mathi.AtanInternal.Inv(-45_887_423_068_929_232));
            Utility.AssertAreEqual(-100, Intar1991.Mathi.AtanInternal.Inv(-45_887_423_068_929_233));
            for (var x = 2; x < 10; x++) {
                var p = (long)((1UL << 63) / ((2 * (ulong)x) - 1));
                Utility.AssertAreEqual(x, Intar1991.Mathi.AtanInternal.Inv(p));
                Utility.AssertAreEqual(x - 1, Intar1991.Mathi.AtanInternal.Inv(p + 1));
                Utility.AssertAreEqual(-x, Intar1991.Mathi.AtanInternal.Inv(-p));
                Utility.AssertAreEqual(-x + 1, Intar1991.Mathi.AtanInternal.Inv(-p - 1));
            }
            const long one = 1L << 31;
            for (var x = one - 9; x <= one; ++x) {
                var p = (long)((1UL << 63) / ((2 * (ulong)x) - 1));
                Utility.AssertAreEqual(x, Intar1991.Mathi.AtanInternal.Inv(p));
                Utility.AssertAreEqual(x - 1, Intar1991.Mathi.AtanInternal.Inv(p + 1));
                Utility.AssertAreEqual(-x, Intar1991.Mathi.AtanInternal.Inv(-p));
                Utility.AssertAreEqual(-x + 1, Intar1991.Mathi.AtanInternal.Inv(-p - 1));
            }
            var rng = new Intar1991.Rand.Xoroshiro128StarStar(1, 2);
            for (var i = 0; i < 32768; ++i) {
                var x = rng.NextInt64(10, one - 9);
                var p = (long)((1UL << 63) / ((2 * (ulong)x) - 1));
                Utility.AssertAreEqual(x, Intar1991.Mathi.AtanInternal.Inv(p));
                Utility.AssertAreEqual(x - 1, Intar1991.Mathi.AtanInternal.Inv(p + 1));
                Utility.AssertAreEqual(-x, Intar1991.Mathi.AtanInternal.Inv(-p));
                Utility.AssertAreEqual(-x + 1, Intar1991.Mathi.AtanInternal.Inv(-p - 1));
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
            var rng = new Intar1991.Rand.Xoroshiro128StarStar(1, 2);
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
            var rng = new Intar1991.Rand.Xoroshiro128StarStar(1, 2);
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
            TestAtan(head, tail, 0.0039, Intar1991.Mathi.AtanP2);
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
            TestAtan(head, tail, 0.0016, Intar1991.Mathi.AtanP3);
        }

        [Test]
        public static void TestAtanP9() {
            var head = new long[] {
                0, 683473677,
                1366947354, 2050421031, 2733894708, 3417368385,
                4100842062, 4784315739, 5467789416, 6151263093,
            };
            var tail = new long[] {
                1152938291486523392, 1152938290949644663,
                1152938290412765934, 1152938289875887205,
                1152938291486492120, 1152938290949613390,
                1152938290412734660, 1152938289875855930,
                1152938289338977200, 1152938288802098470,
            };
            TestAtan(head, tail, 0.00002, Intar1991.Mathi.AtanP9);
        }

        [Test]
        public static void TestDiv() {
            const int k1 = 1 << 15;
            const int k2 = -k1;
            Utility.AssertAreEqual(k1, Intar1991.Mathi.AtanInternal.Div(int.MinValue, int.MinValue));
            Utility.AssertAreEqual(k2, Intar1991.Mathi.AtanInternal.Div(int.MinValue, int.MaxValue));
            Utility.AssertAreEqual(k2, Intar1991.Mathi.AtanInternal.Div(int.MaxValue, int.MinValue));
            Utility.AssertAreEqual(k1, Intar1991.Mathi.AtanInternal.Div(int.MaxValue, int.MaxValue));
            for (var i = 0; i < k1; ++i) {
                var e1 = i;
                var e2 = e1 + 1;
                var e3 = -e1;
                var e4 = -e2;
                var y2 = ((2 * i) + 1) << 15;
                var y1 = y2 - 1;
                Utility.AssertAreEqual(e1, Intar1991.Mathi.AtanInternal.Div(y1, int.MaxValue));
                Utility.AssertAreEqual(e2, Intar1991.Mathi.AtanInternal.Div(y2, int.MaxValue));
                Utility.AssertAreEqual(e3, Intar1991.Mathi.AtanInternal.Div(y1, int.MinValue));
                Utility.AssertAreEqual(e4, Intar1991.Mathi.AtanInternal.Div(y2, int.MinValue));
            }
        }

        static void TestAtan2(
            Func<int, int, int> atan2,
            Func<int, int> atan, double error) {
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
                Utility.AssertAreEqual(expected1, atan2(p11, k1), i);
                Utility.AssertAreEqual(expected1, atan2(p12, k1), i);
                Utility.AssertAreEqual(expected2, atan2(p11, k2), i);
                Utility.AssertAreEqual(expected2, atan2(p12, k2), i);
                Utility.AssertAreEqual(expected4, atan2(p41, k1), i);
                Utility.AssertAreEqual(expected4, atan2(p42, k1), i);
                Utility.AssertAreEqual(expected3, atan2(p41, k2), i);
                Utility.AssertAreEqual(expected3, atan2(p42, k2), i);
                Utility.AssertAreEqual(expected5, atan2(k1, p11), i);
                Utility.AssertAreEqual(expected5, atan2(k1, p12), i);
                Utility.AssertAreEqual(expected8, atan2(k2, p11), i);
                Utility.AssertAreEqual(expected8, atan2(k2, p12), i);
                Utility.AssertAreEqual(expected6, atan2(k1, p41), i);
                Utility.AssertAreEqual(expected6, atan2(k1, p42), i);
                Utility.AssertAreEqual(expected7, atan2(k2, p41), i);
                Utility.AssertAreEqual(expected7, atan2(k2, p42), i);
            }
            const int pi = 1 << 30;
            const double toRad = Math.PI / pi;
            var rng = new Intar1991.Rand.Xoroshiro128StarStar(1, 2);
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
                Utility.AssertAreEqual(expected1, atan2(p11, k1), i);
                Utility.AssertAreEqual(expected1, atan2(p12, k1), i);
                Utility.AssertAreEqual(expected2, atan2(p11, k2), i);
                Utility.AssertAreEqual(expected2, atan2(p12, k2), i);
                Utility.AssertAreEqual(expected4, atan2(p41, k1), i);
                Utility.AssertAreEqual(expected4, atan2(p42, k1), i);
                Utility.AssertAreEqual(expected3, atan2(p41, k2), i);
                Utility.AssertAreEqual(expected3, atan2(p42, k2), i);
                Utility.AssertAreEqual(expected5, atan2(k1, p11), i);
                Utility.AssertAreEqual(expected5, atan2(k1, p12), i);
                Utility.AssertAreEqual(expected8, atan2(k2, p11), i);
                Utility.AssertAreEqual(expected8, atan2(k2, p12), i);
                Utility.AssertAreEqual(expected6, atan2(k1, p41), i);
                Utility.AssertAreEqual(expected6, atan2(k1, p42), i);
                Utility.AssertAreEqual(expected7, atan2(k2, p41), i);
                Utility.AssertAreEqual(expected7, atan2(k2, p42), i);
            }
            const double toRad = Math.PI / pi;
            var rng = new Intar1991.Rand.Xoroshiro128StarStar(1, 2);
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

        [Test] public static void TestAtan2P2() => TestAtan2(Intar1991.Mathi.Atan2P2, Intar1991.Mathi.AtanP2, 0.0039);
        [Test] public static void TestAtan2P3() => TestAtan2(Intar1991.Mathi.Atan2P3, Intar1991.Mathi.AtanP3, 0.0016);

#if NET7_0_OR_GREATER

        [Test] public static void TestAtan2P2L() => TestAtan2(Intar1991.Mathi.Atan2P2, Intar1991.Mathi.AtanP2, 0.0039);
        [Test] public static void TestAtan2P3L() => TestAtan2(Intar1991.Mathi.Atan2P3, Intar1991.Mathi.AtanP3, 0.0016);
        [Test] public static void TestAtan2P9L() => TestAtan2(Intar1991.Mathi.Atan2P9, Intar1991.Mathi.AtanP9, 0.00002);

#endif

    }
}
