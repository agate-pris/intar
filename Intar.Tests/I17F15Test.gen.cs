
using Intar.Rand;

using NUnit.Framework;
using System;

namespace Intar.Tests {
    public class I17F15Test {

        static void TestAsinP3I17F15(int x) {
            var arg1 = I17F15.FromBits(x);
            var arg2 = -arg1;
            var actual1 = I17F15.AsinP3(arg1);
            var actual2 = I17F15.AsinP3(arg2);
            var actual3 = I17F15.AcosP3(arg1);
            var actual4 = I17F15.AcosP3(arg2);
            Utility.AssertAreEqual(Math.Asin((double)arg1), Math.PI / 2 * (double)actual1, 2e-4);
            Utility.AssertAreEqual(Math.Asin((double)arg2), Math.PI / 2 * (double)actual2, 2e-4);
            Utility.AssertAreEqual(Math.Acos((double)arg1), Math.PI / 2 * (double)actual3, 2e-4);
            Utility.AssertAreEqual(Math.Acos((double)arg2), Math.PI / 2 * (double)actual4, 2e-4);
            if (actual1 != -actual2) {
                Assert.AreEqual(actual1, -actual2, $"actual1.Bits:{actual1.Bits} actual2.Bits:{actual2.Bits}");
            }
            if (I17F15.One - actual1 != actual3) {
                Assert.AreEqual(I17F15.One - actual1, actual3, $"actual1.Bits:{actual1.Bits} actual3.Bits:{actual3.Bits}");
            }
            if (I17F15.One + actual1 != actual4) {
                Assert.AreEqual(I17F15.One + actual1, actual4, $"actual1.Bits:{actual1.Bits} actual4.Bits:{actual4.Bits}");
            }
        }

        [Test]
        public static void TestAsinP3I17F15() {
            // Asin, Acos のテスト
            // 引数の正負と Asin/Acos に対し,
            // 戻り値の鏡面対称性をテストする.
            // 32 ビットの場合, 0 から 1 まで全ての値をテストする.
            for (var i = 0; i <= 32768; i++) {
                TestAsinP3I17F15(i);
            }
        }

        static void TestAsinP3I33F31(long x) {
            var arg1 = I33F31.FromBits(x);
            var arg2 = -arg1;
            var actual1 = I17F15.AsinP3(arg1);
            var actual2 = I17F15.AsinP3(arg2);
            var actual3 = I17F15.AcosP3(arg1);
            var actual4 = I17F15.AcosP3(arg2);
            Utility.AssertAreEqual(Math.Asin((double)arg1), Math.PI / 2 * (double)actual1, 2e-4);
            Utility.AssertAreEqual(Math.Asin((double)arg2), Math.PI / 2 * (double)actual2, 2e-4);
            Utility.AssertAreEqual(Math.Acos((double)arg1), Math.PI / 2 * (double)actual3, 2e-4);
            Utility.AssertAreEqual(Math.Acos((double)arg2), Math.PI / 2 * (double)actual4, 2e-4);
            if (actual1 != -actual2) {
                Assert.AreEqual(actual1, -actual2, $"actual1.Bits:{actual1.Bits} actual2.Bits:{actual2.Bits}");
            }
            if (I17F15.One - actual1 != actual3) {
                Assert.AreEqual(I17F15.One - actual1, actual3, $"actual1.Bits:{actual1.Bits} actual3.Bits:{actual3.Bits}");
            }
            if (I17F15.One + actual1 != actual4) {
                Assert.AreEqual(I17F15.One + actual1, actual4, $"actual1.Bits:{actual1.Bits} actual4.Bits:{actual4.Bits}");
            }
        }

        [Test]
        public static void TestAsinP3I33F31() {
            // Asin, Acos のテスト
            // 引数の正負と Asin/Acos に対し,
            // 戻り値の鏡面対称性をテストする.
            // 64 ビットの場合, 最初の 10000 要素, 最後の 10000 要素,
            // そしてランダムな 10000 要素をテストする.
            var rng = new Xoroshiro128StarStar(1, 2);
            for (var i = 0; i <= 10000; i++) {
                TestAsinP3I33F31(i);
                TestAsinP3I33F31(I33F31.OneRepr - i);
                TestAsinP3I33F31(rng.NextInt64(0, I33F31.OneRepr));
            }
        }

        static void TestAsinP7I33F31(long x) {
            var arg1 = I33F31.FromBits(x);
            var arg2 = -arg1;
            var actual1 = I17F15.AsinP7(arg1);
            var actual2 = I17F15.AsinP7(arg2);
            var actual3 = I17F15.AcosP7(arg1);
            var actual4 = I17F15.AcosP7(arg2);
            Utility.AssertAreEqual(Math.Asin((double)arg1), Math.PI / 2 * (double)actual1, 2e-4);
            Utility.AssertAreEqual(Math.Asin((double)arg2), Math.PI / 2 * (double)actual2, 2e-4);
            Utility.AssertAreEqual(Math.Acos((double)arg1), Math.PI / 2 * (double)actual3, 2e-4);
            Utility.AssertAreEqual(Math.Acos((double)arg2), Math.PI / 2 * (double)actual4, 2e-4);
            if (actual1 != -actual2) {
                Assert.AreEqual(actual1, -actual2, $"actual1.Bits:{actual1.Bits} actual2.Bits:{actual2.Bits}");
            }
            if (I17F15.One - actual1 != actual3) {
                Assert.AreEqual(I17F15.One - actual1, actual3, $"actual1.Bits:{actual1.Bits} actual3.Bits:{actual3.Bits}");
            }
            if (I17F15.One + actual1 != actual4) {
                Assert.AreEqual(I17F15.One + actual1, actual4, $"actual1.Bits:{actual1.Bits} actual4.Bits:{actual4.Bits}");
            }
        }

        [Test]
        public static void TestAsinP7I33F31() {
            // Asin, Acos のテスト
            // 引数の正負と Asin/Acos に対し,
            // 戻り値の鏡面対称性をテストする.
            // 64 ビットの場合, 最初の 10000 要素, 最後の 10000 要素,
            // そしてランダムな 10000 要素をテストする.
            var rng = new Xoroshiro128StarStar(1, 2);
            for (var i = 0; i <= 10000; i++) {
                TestAsinP7I33F31(i);
                TestAsinP7I33F31(I33F31.OneRepr - i);
                TestAsinP7I33F31(rng.NextInt64(0, I33F31.OneRepr));
            }
        }

        static void TestAtan2P2(int y, int x) {
            const double scale = Math.PI / 2;
            var negativeY = -y;
            var negativeX = -x;
            var a = I17F15.Atan2P2(y, x);
            var b = I17F15.Atan2P2(x, y);
            var c = I17F15.Atan2P2(x, negativeY);
            var d = I17F15.Atan2P2(y, negativeX);
            var e = I17F15.Atan2P2(negativeY, negativeX);
            var f = I17F15.Atan2P2(negativeX, negativeY);
            var g = I17F15.Atan2P2(negativeX, y);
            var h = I17F15.Atan2P2(negativeY, x);
            const double delta = 4e-3;
            Utility.AssertAreEqual(Math.Atan2(y, x), (double)a * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(x, y), (double)b * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(x, negativeY), (double)c * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(y, negativeX), (double)d * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeY, negativeX), (double)e * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeX, negativeY), (double)f * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeX, y), (double)g * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeY, x), (double)h * scale, delta);
            const int straight = I17F15.OneRepr * 2;
            if (I17F15.OneRepr - a.Bits != b.Bits) {
                Assert.AreEqual(I17F15.OneRepr - a.Bits, b.Bits, $"y:{y} x:{x}");
            }
            if (I17F15.OneRepr + a.Bits != c.Bits) {
                Assert.AreEqual(I17F15.OneRepr + a.Bits, c.Bits, $"y:{y} x:{x}");
            }
            if (straight - a.Bits != d.Bits) {
                Assert.AreEqual(straight - a.Bits, d.Bits, $"y:{y} x:{x}");
            }
            if (a.Bits - straight != e.Bits) {
                Assert.AreEqual(a.Bits - straight, e.Bits, $"y:{y} x:{x}");
            }
            if (I17F15.NegativeOneRepr - a.Bits != f.Bits) {
                Assert.AreEqual(I17F15.NegativeOneRepr - a.Bits, f.Bits, $"y:{y} x:{x}");
            }
            if (I17F15.NegativeOneRepr + a.Bits != g.Bits) {
                Assert.AreEqual(I17F15.NegativeOneRepr + a.Bits, g.Bits, $"y:{y} x:{x}");
            }
            if (-a.Bits != h.Bits) {
                Assert.AreEqual(-a.Bits, h.Bits, $"y:{y} x:{x}");
            }
        }
        [Test]
        public void TestAtan2P2() {
            {
                var a = I17F15.Atan2P2(0, 0);
                var b = I17F15.Atan2P2(0, 1);
                var c = I17F15.Atan2P2(1, 0);
                var d = I17F15.Atan2P2(1, 1);
                var e = I17F15.Atan2P2(0, -1);
                var f = I17F15.Atan2P2(1, -1);
                var g = I17F15.Atan2P2(-1, 0);
                var h = I17F15.Atan2P2(-1, 1);
                var i = I17F15.Atan2P2(-1, -1);
                Assert.AreEqual(I17F15.Zero, a);
                Assert.AreEqual(I17F15.Zero, b);
                Assert.AreEqual(I17F15.One, c);
                Assert.AreEqual(I17F15.OneRepr / 2, d.Bits);
                Assert.AreEqual(I17F15.OneRepr * 2, e.Bits);
                Assert.AreEqual(I17F15.OneRepr / 2 * 3, f.Bits);
                Assert.AreEqual(I17F15.NegativeOne, g);
                Assert.AreEqual(I17F15.NegativeOneRepr / 2, h.Bits);
                Assert.AreEqual(I17F15.NegativeOneRepr / 2 * 3, i.Bits);
            }
            for (var i = 1; i <= 1 << 15; i++) {
                TestAtan2P2(i, 1 << 15);
            }
            var random = new Random();
            for (var i = 0; i < 100; i++) {
                var a = random.Next(0, int.MaxValue) + 1;
                var b = random.Next(0, int.MaxValue) + 1;
                if (a < b) {
                    TestAtan2P2(a, b);
                } else {
                    TestAtan2P2(b, a);
                }
            }
        }

        static void TestAtan2P3(int y, int x) {
            const double scale = Math.PI / 2;
            var negativeY = -y;
            var negativeX = -x;
            var a = I17F15.Atan2P3(y, x);
            var b = I17F15.Atan2P3(x, y);
            var c = I17F15.Atan2P3(x, negativeY);
            var d = I17F15.Atan2P3(y, negativeX);
            var e = I17F15.Atan2P3(negativeY, negativeX);
            var f = I17F15.Atan2P3(negativeX, negativeY);
            var g = I17F15.Atan2P3(negativeX, y);
            var h = I17F15.Atan2P3(negativeY, x);
            const double delta = 4e-3;
            Utility.AssertAreEqual(Math.Atan2(y, x), (double)a * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(x, y), (double)b * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(x, negativeY), (double)c * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(y, negativeX), (double)d * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeY, negativeX), (double)e * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeX, negativeY), (double)f * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeX, y), (double)g * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeY, x), (double)h * scale, delta);
            const int straight = I17F15.OneRepr * 2;
            if (I17F15.OneRepr - a.Bits != b.Bits) {
                Assert.AreEqual(I17F15.OneRepr - a.Bits, b.Bits, $"y:{y} x:{x}");
            }
            if (I17F15.OneRepr + a.Bits != c.Bits) {
                Assert.AreEqual(I17F15.OneRepr + a.Bits, c.Bits, $"y:{y} x:{x}");
            }
            if (straight - a.Bits != d.Bits) {
                Assert.AreEqual(straight - a.Bits, d.Bits, $"y:{y} x:{x}");
            }
            if (a.Bits - straight != e.Bits) {
                Assert.AreEqual(a.Bits - straight, e.Bits, $"y:{y} x:{x}");
            }
            if (I17F15.NegativeOneRepr - a.Bits != f.Bits) {
                Assert.AreEqual(I17F15.NegativeOneRepr - a.Bits, f.Bits, $"y:{y} x:{x}");
            }
            if (I17F15.NegativeOneRepr + a.Bits != g.Bits) {
                Assert.AreEqual(I17F15.NegativeOneRepr + a.Bits, g.Bits, $"y:{y} x:{x}");
            }
            if (-a.Bits != h.Bits) {
                Assert.AreEqual(-a.Bits, h.Bits, $"y:{y} x:{x}");
            }
        }
        [Test]
        public void TestAtan2P3() {
            {
                var a = I17F15.Atan2P3(0, 0);
                var b = I17F15.Atan2P3(0, 1);
                var c = I17F15.Atan2P3(1, 0);
                var d = I17F15.Atan2P3(1, 1);
                var e = I17F15.Atan2P3(0, -1);
                var f = I17F15.Atan2P3(1, -1);
                var g = I17F15.Atan2P3(-1, 0);
                var h = I17F15.Atan2P3(-1, 1);
                var i = I17F15.Atan2P3(-1, -1);
                Assert.AreEqual(I17F15.Zero, a);
                Assert.AreEqual(I17F15.Zero, b);
                Assert.AreEqual(I17F15.One, c);
                Assert.AreEqual(I17F15.OneRepr / 2, d.Bits);
                Assert.AreEqual(I17F15.OneRepr * 2, e.Bits);
                Assert.AreEqual(I17F15.OneRepr / 2 * 3, f.Bits);
                Assert.AreEqual(I17F15.NegativeOne, g);
                Assert.AreEqual(I17F15.NegativeOneRepr / 2, h.Bits);
                Assert.AreEqual(I17F15.NegativeOneRepr / 2 * 3, i.Bits);
            }
            for (var i = 1; i <= 1 << 15; i++) {
                TestAtan2P3(i, 1 << 15);
            }
            var random = new Random();
            for (var i = 0; i < 100; i++) {
                var a = random.Next(0, int.MaxValue) + 1;
                var b = random.Next(0, int.MaxValue) + 1;
                if (a < b) {
                    TestAtan2P3(a, b);
                } else {
                    TestAtan2P3(b, a);
                }
            }
        }

    }
} // namespace Intar.Tests
