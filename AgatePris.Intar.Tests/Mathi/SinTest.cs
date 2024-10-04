using System;
using System.Runtime.CompilerServices;

using NUnit.Framework;

namespace AgatePris.Intar.Tests.Mathi {
    public class SinTest {
        [Test]
        public static void TestConsts() {
            Console.WriteLine(Intar.Mathi.SinInternal.P11I64A);
            Console.WriteLine(Intar.Mathi.SinInternal.P11I64B);
            Console.WriteLine(Intar.Mathi.SinInternal.P11I64C);
            Console.WriteLine(Intar.Mathi.SinInternal.P11I64D);
            Console.WriteLine(Intar.Mathi.SinInternal.P11I64E);
            Console.WriteLine(Intar.Mathi.SinInternal.P11I64F);
            Console.WriteLine(Intar.Mathi.SinInternal.P10I64A);
            Console.WriteLine(Intar.Mathi.SinInternal.P10I64B);
            Console.WriteLine(Intar.Mathi.SinInternal.P10I64C);
            Console.WriteLine(Intar.Mathi.SinInternal.P10I64D);
            Console.WriteLine(Intar.Mathi.SinInternal.P10I64E);
            Console.WriteLine(Intar.Mathi.SinInternal.P5I32A);
            Console.WriteLine(Intar.Mathi.SinInternal.P5I32B);
            Console.WriteLine(Intar.Mathi.SinInternal.P5I32C);
            Console.WriteLine(Intar.Mathi.SinInternal.P4I32A);
            Console.WriteLine(Intar.Mathi.SinInternal.P4I32B);
            Assert.AreEqual(Intar.Mathi.SinInternal.P11I64A, 14488038916154245685);
            Assert.AreEqual(Intar.Mathi.SinInternal.P11I64B, 11915934368436992009);
            Assert.AreEqual(Intar.Mathi.SinInternal.P11I64C, 11760553260076371255);
            Assert.AreEqual(Intar.Mathi.SinInternal.P11I64D, 11054273349336558994);
            Assert.AreEqual(Intar.Mathi.SinInternal.P11I64E, 12108815703571716367);
            Assert.AreEqual(Intar.Mathi.SinInternal.P11I64F, 16602603363585481494);
            Assert.AreEqual(Intar.Mathi.SinInternal.P10I64A, 11378879071774596408);
            Assert.AreEqual(Intar.Mathi.SinInternal.P10I64B, 9358747397805171131);
            Assert.AreEqual(Intar.Mathi.SinInternal.P10I64C, 12315189113921640896);
            Assert.AreEqual(Intar.Mathi.SinInternal.P10I64D, 17335849242745400440);
            Assert.AreEqual(Intar.Mathi.SinInternal.P10I64E, 14400453044121993745);
            Assert.AreEqual(Intar.Mathi.SinInternal.P5I32A, 3373259426);
            Assert.AreEqual(Intar.Mathi.SinInternal.P5I32B, 2764129413);
            Assert.AreEqual(Intar.Mathi.SinInternal.P5I32C, 2500540483);
            Assert.AreEqual(Intar.Mathi.SinInternal.P4I32A, 2631866036);
            Assert.AreEqual(Intar.Mathi.SinInternal.P4I32B, 3875141568);
        }

        static void Test(int expected, Func<int, int> f, Func<double, double> g, int x, double delta) {
            const int pi = 1 << 16;
            const double toRad = Math.PI / pi;
            const double toReal = 1.0 / (1 << 30);
            var a = f(x);
            Utility.AssertAreEqual(expected, a, x);
            Utility.AssertAreEqual(g(x * toRad), a * toReal, delta, x);
        }
        static void Test(long expected, Func<long, long> f, Func<double, double> g, long x, double delta) {
            const long pi = 1L << 32;
            const double toRad = Math.PI / pi;
            const double toReal = 1.0 / (1L << 62);
            var a = f(x);
            Utility.AssertAreEqual(expected, a, x);
            Utility.AssertAreEqual(g(x * toRad), a * toReal, delta, x);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static void TestSin(int expected, Func<int, int> sin, int x, double delta) => Test(expected, sin, Math.Sin, x, delta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static void TestCos(int expected, Func<int, int> cos, int x, double delta) => Test(expected, cos, Math.Cos, x, delta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static void TestSin(long expected, Func<long, long> sin, long x, double delta) => Test(expected, sin, Math.Sin, x, delta);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] static void TestCos(long expected, Func<long, long> cos, long x, double delta) => Test(expected, cos, Math.Cos, x, delta);

        static void TestSin(
            int[] expectedSin,
            int[] expectedCos,
            Func<int, int> sin,
            Func<int, int> cos, double delta
        ) {
            const int pi = 1 << 16;
            const double toRad = Math.PI / pi;
            const double toReal = 1.0 / (1 << 30);
            Utility.AssertAreEqual(sin(0), sin(int.MinValue), int.MinValue);
            Utility.AssertAreEqual(cos(0), cos(int.MinValue), int.MinValue);
            Utility.AssertAreEqual(sin(-1), sin(int.MaxValue), int.MaxValue);
            Utility.AssertAreEqual(cos(-1), cos(int.MaxValue), int.MaxValue);
            for (var x = 0; x < expectedSin.Length; x++) {
                Console.WriteLine(sin(x));
            }
            for (var x = 0; x < expectedCos.Length; x++) {
                Console.WriteLine(cos(x));
            }
            {
                var e1 = expectedSin[0];
                var e2 = -e1;
                TestSin(e1, sin, 0, delta);
                TestSin(e2, sin, pi, delta);
                TestCos(e2, cos, pi / 2, delta);
                TestSin(e1, sin, -pi, delta);
                TestCos(e1, cos, -pi / 2, delta);
            }
            for (var x = 1; x < expectedSin.Length; x++) {
                var p = -x;
                var e1 = expectedSin[x];
                var e2 = -e1;
                TestSin(e1, sin, x, delta);
                TestSin(e1, sin, p + pi, delta);
                TestSin(e1, sin, p - pi, delta);
                TestSin(e2, sin, p, delta);
                TestSin(e2, sin, x + pi, delta);
                TestSin(e2, sin, x - pi, delta);
                TestCos(e1, cos, (pi / 2) + p, delta);
                TestCos(e2, cos, (pi / 2) + x, delta);
                TestCos(e1, cos, x - (pi / 2), delta);
                TestCos(e2, cos, p - (pi / 2), delta);
            }
            for (var x = 0; x < expectedCos.Length; x++) {
                var p = -x;
                var e1 = expectedCos[x];
                var e2 = -e1;
                TestCos(e1, cos, x, delta);
                TestCos(e1, cos, p, delta);
                TestCos(e2, cos, pi + x, delta);
                TestCos(e2, cos, pi + p, delta);
                TestCos(e2, cos, x - pi, delta);
                TestCos(e2, cos, p - pi, delta);
                TestSin(e1, sin, (pi / 2) + x, delta);
                TestSin(e1, sin, (pi / 2) + p, delta);
                TestSin(e2, sin, x - (pi / 2), delta);
                TestSin(e2, sin, p - (pi / 2), delta);
            }
            TestSin(expectedCos[0], sin, pi / 2, delta);
            TestCos(expectedSin[0], cos, -pi / 2, delta);
            TestCos(-expectedSin[0], cos, pi / 2, delta);
            TestSin(-expectedCos[0], sin, -pi / 2, delta);
            for (var x = 0; x < pi / 2; ++x) {
                var expected = Math.Cos(x * toRad);
                var actual = cos(x);
                Utility.AssertAreEqual(expected, actual * toReal, delta, x);
                var p = -x;
                TestCos(actual, cos, p, delta);
                TestSin(actual, sin, p + (pi / 2), delta);
                TestSin(actual, sin, x + (pi / 2), delta);
                TestSin(-actual, sin, p - (pi / 2), delta);
                TestSin(-actual, sin, x - (pi / 2), delta);
                TestCos(-actual, cos, pi - x, delta);
                TestCos(-actual, cos, x - pi, delta);
            }
            var rng = new Intar.Rand.Xoroshiro128StarStar(1, 2);
            for (var i = 0; i < 32768; ++i) {
                var x = 1 + rng.Next((pi / 2) - 1, int.MaxValue);
                TestSin(sin(x & ((pi * 2) - 1)), sin, x, delta);
                TestCos(cos(x & ((pi * 2) - 1)), cos, x, delta);
                TestSin(sin(-x & ((pi * 2) - 1)), sin, -x, delta);
                TestCos(cos(-x & ((pi * 2) - 1)), cos, -x, delta);
            }
        }
        static void TestSin(
            long[] expectedSin,
            long[] expectedCos,
            Func<long, long> sin,
            Func<long, long> cos, double delta
        ) {
            const long pi = 1L << 32;
            Utility.AssertAreEqual(sin(0), sin(long.MinValue), long.MinValue);
            Utility.AssertAreEqual(cos(0), cos(long.MinValue), long.MinValue);
            Utility.AssertAreEqual(sin(-1), sin(long.MaxValue), long.MaxValue);
            Utility.AssertAreEqual(cos(-1), cos(long.MaxValue), long.MaxValue);
            for (var x = 0; x < expectedSin.Length; x++) {
                Console.WriteLine(sin(x));
            }
            for (var x = 0; x < expectedCos.Length; x++) {
                Console.WriteLine(cos(x));
            }
            {
                var e1 = expectedSin[0];
                var e2 = -e1;
                TestSin(e1, sin, 0, delta);
                TestSin(e2, sin, pi, delta);
                TestCos(e2, cos, pi / 2, delta);
                TestSin(e2, sin, -pi, delta);
                TestCos(e1, cos, -pi / 2, delta);
            }
            for (var x = 1; x < expectedSin.Length; x++) {
                var p = -x;
                var e1 = expectedSin[x];
                var e2 = -e1;
                TestSin(e1, sin, x, delta);
                TestSin(e1, sin, p + pi, delta);
                TestSin(e1, sin, p - pi, delta);
                TestSin(e2, sin, p, delta);
                TestSin(e2, sin, x + pi, delta);
                TestSin(e2, sin, x - pi, delta);
                TestCos(e1, cos, (pi / 2) + p, delta);
                TestCos(e2, cos, (pi / 2) + x, delta);
                TestCos(e1, cos, x - (pi / 2), delta);
                TestCos(e2, cos, p - (pi / 2), delta);
            }
            for (var x = 0; x < expectedCos.Length; x++) {
                var p = -x;
                var e1 = expectedCos[x];
                var e2 = -e1;
                TestCos(e1, cos, x, delta);
                TestCos(e1, cos, p, delta);
                TestCos(e2, cos, pi + x, delta);
                TestCos(e2, cos, pi + p, delta);
                TestCos(e2, cos, x - pi, delta);
                TestCos(e2, cos, p - pi, delta);
                TestSin(e1, sin, (pi / 2) + x, delta);
                TestSin(e1, sin, (pi / 2) + p, delta);
                TestSin(e2, sin, x - (pi / 2), delta);
                TestSin(e2, sin, p - (pi / 2), delta);
            }
            TestSin(expectedCos[0], sin, pi / 2, delta);
            TestCos(expectedSin[0], cos, -pi / 2, delta);
            TestCos(-expectedSin[0], cos, pi / 2, delta);
            TestSin(-expectedCos[0], sin, -pi / 2, delta);
            var rng = new Intar.Rand.Xoroshiro128StarStar(1, 2);
            for (var i = 0; i < 32768; ++i) {
                var x = rng.NextInt64(0, (pi / 2) + 1);
                TestSin(sin(x & ((pi * 2) - 1)), sin, x, delta);
                TestCos(cos(x & ((pi * 2) - 1)), cos, x, delta);
                TestSin(sin(-x & ((pi * 2) - 1)), sin, -x, delta);
                TestCos(cos(-x & ((pi * 2) - 1)), cos, -x, delta);
            }
            for (var i = 0; i < 32768; ++i) {
                var x = 1 + rng.NextInt64((pi / 2) - 1, long.MaxValue);
                TestSin(sin(x & ((pi * 2) - 1)), sin, x, delta);
                TestCos(cos(x & ((pi * 2) - 1)), cos, x, delta);
                TestSin(sin(-x & ((pi * 2) - 1)), sin, -x, delta);
                TestCos(cos(-x & ((pi * 2) - 1)), cos, -x, delta);
            }
        }

        [Test]
        public static void TestSinP4() {
            var expectedSin = new int[] {
                0, 65536,
                131072, 163846, 229384, 262164,
                327704, 360490, 426032, 458824,
            };
            var expectedCos = new int[] {
                1073741824, 1073741824, 1073741824, 1073741824, 1073741824,
                1073741824, 1073741824, 1073741824, 1073741824, 1073741824,
            };
            TestSin(expectedSin, expectedCos, Intar.Mathi.SinP4, Intar.Mathi.CosP4, 0.0018);
        }

        [Test]
        public static void TestSinP5() {
            var expectedSin = new int[] {
                0, 51471,
                102942, 154413, 205884, 257355,
                308826, 360297, 411768, 463239,
            };
            var expectedCos = new int[] {
                1073741824, 1073709056, 1073741820, 1073741815, 1073741808,
                1073741799, 1073741788, 1073741775, 1073709000, 1073741743,
            };
            TestSin(expectedSin, expectedCos, Intar.Mathi.SinP5, Intar.Mathi.CosP5, 0.0004);
        }
        [Test]
        public static void TestSinP10() {
            var expectedSin = new long[] {
                10737418240, 15032385526,
                17179869168, 21474836456,
                25769803744, 27917287394,
                32212254684, 34359738340,
                38654705632, 40802189294,
            };
            var expectedCos = new long[] {
                1L << 62, 1L << 62, 1L << 62, 1L << 62, 1L << 62,
                1L << 62, 1L << 62, 1L << 62, 1L << 62, 1L << 62,
            };
            TestSin(expectedSin, expectedCos, Intar.Mathi.SinP10, Intar.Mathi.CosP10, 0.000002);
        }
        [Test]
        public static void TestSinP11() {
            var expectedSin = new long[] {
                0,
                3373259426,
                6746518852,
                10119778278,
                13493037704,
                16866297130,
                20239556556,
                23612815982,
                26986075408,
                30359334834,
            };
            var expectedCos = new long[] {
                4611686007689969664, 4611686007689969668,
                4611686007689969670, 4611686007689969670,
                4611686007689969668, 4611686007689969664,
                4611686005542486016, 4611686007689969650,
                4611686007689969640, 4611686007689969628,
            };
            TestSin(expectedSin, expectedCos, Intar.Mathi.SinP11, Intar.Mathi.CosP11, 0.000002);
        }
    }
}
