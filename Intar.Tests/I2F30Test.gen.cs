using NUnit.Framework;
using System;

namespace Intar.Tests {
    public class I2F30Test {
        static void TestAtan2P2(int y, int x) {
            const double scale = Math.PI;
            var negativeY = -y;
            var negativeX = -x;
            var a = I2F30.Atan2P2(y, x);
            var b = I2F30.Atan2P2(x, y);
            var c = I2F30.Atan2P2(x, negativeY);
            var d = I2F30.Atan2P2(y, negativeX);
            var e = I2F30.Atan2P2(negativeY, negativeX);
            var f = I2F30.Atan2P2(negativeX, negativeY);
            var g = I2F30.Atan2P2(negativeX, y);
            var h = I2F30.Atan2P2(negativeY, x);
            const double delta = 4e-3;
            Utility.AssertAreEqual(Math.Atan2(y, x), (double)a * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(x, y), (double)b * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(x, negativeY), (double)c * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(y, negativeX), (double)d * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeY, negativeX), (double)e * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeX, negativeY), (double)f * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeX, y), (double)g * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeY, x), (double)h * scale, delta);
            const int right = I2F30.OneRepr / 2;
            const int negativeRight = -right;
            if (right - a.Bits != b.Bits) {
                Assert.AreEqual(right - a.Bits, b.Bits, $"y:{y} x:{x}");
            }
            if (right + a.Bits != c.Bits) {
                Assert.AreEqual(right + a.Bits, c.Bits, $"y:{y} x:{x}");
            }
            if (I2F30.OneRepr - a.Bits != d.Bits) {
                Assert.AreEqual(I2F30.OneRepr - a.Bits, d.Bits, $"y:{y} x:{x}");
            }
            if (a.Bits - I2F30.OneRepr != e.Bits) {
                Assert.AreEqual(a.Bits - I2F30.OneRepr, e.Bits, $"y:{y} x:{x}");
            }
            if (negativeRight - a.Bits != f.Bits) {
                Assert.AreEqual(negativeRight - a.Bits, f.Bits, $"y:{y} x:{x}");
            }
            if (negativeRight + a.Bits != g.Bits) {
                Assert.AreEqual(negativeRight + a.Bits, g.Bits, $"y:{y} x:{x}");
            }
            if (-a.Bits != h.Bits) {
                Assert.AreEqual(-a.Bits, h.Bits, $"y:{y} x:{x}");
            }
        }
        [Test]
        public void TestAtan2P2() {
            {
                var a = I2F30.Atan2P2(0, 0);
                var b = I2F30.Atan2P2(0, 1);
                var c = I2F30.Atan2P2(1, 0);
                var d = I2F30.Atan2P2(1, 1);
                var e = I2F30.Atan2P2(0, -1);
                var f = I2F30.Atan2P2(1, -1);
                var g = I2F30.Atan2P2(-1, 0);
                var h = I2F30.Atan2P2(-1, 1);
                var i = I2F30.Atan2P2(-1, -1);
                Assert.AreEqual(I2F30.Zero, a);
                Assert.AreEqual(I2F30.Zero, b);
                Assert.AreEqual(I2F30.OneRepr / 2, c.Bits);
                Assert.AreEqual(I2F30.OneRepr / 4, d.Bits);
                Assert.AreEqual(I2F30.One, e);
                Assert.AreEqual(I2F30.OneRepr / 4 * 3, f.Bits);
                Assert.AreEqual(I2F30.NegativeOneRepr / 2, g.Bits);
                Assert.AreEqual(I2F30.NegativeOneRepr / 4, h.Bits);
                Assert.AreEqual(I2F30.NegativeOneRepr / 4 * 3, i.Bits);
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
            const double scale = Math.PI;
            var negativeY = -y;
            var negativeX = -x;
            var a = I2F30.Atan2P3(y, x);
            var b = I2F30.Atan2P3(x, y);
            var c = I2F30.Atan2P3(x, negativeY);
            var d = I2F30.Atan2P3(y, negativeX);
            var e = I2F30.Atan2P3(negativeY, negativeX);
            var f = I2F30.Atan2P3(negativeX, negativeY);
            var g = I2F30.Atan2P3(negativeX, y);
            var h = I2F30.Atan2P3(negativeY, x);
            const double delta = 4e-3;
            Utility.AssertAreEqual(Math.Atan2(y, x), (double)a * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(x, y), (double)b * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(x, negativeY), (double)c * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(y, negativeX), (double)d * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeY, negativeX), (double)e * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeX, negativeY), (double)f * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeX, y), (double)g * scale, delta);
            Utility.AssertAreEqual(Math.Atan2(negativeY, x), (double)h * scale, delta);
            const int right = I2F30.OneRepr / 2;
            const int negativeRight = -right;
            if (right - a.Bits != b.Bits) {
                Assert.AreEqual(right - a.Bits, b.Bits, $"y:{y} x:{x}");
            }
            if (right + a.Bits != c.Bits) {
                Assert.AreEqual(right + a.Bits, c.Bits, $"y:{y} x:{x}");
            }
            if (I2F30.OneRepr - a.Bits != d.Bits) {
                Assert.AreEqual(I2F30.OneRepr - a.Bits, d.Bits, $"y:{y} x:{x}");
            }
            if (a.Bits - I2F30.OneRepr != e.Bits) {
                Assert.AreEqual(a.Bits - I2F30.OneRepr, e.Bits, $"y:{y} x:{x}");
            }
            if (negativeRight - a.Bits != f.Bits) {
                Assert.AreEqual(negativeRight - a.Bits, f.Bits, $"y:{y} x:{x}");
            }
            if (negativeRight + a.Bits != g.Bits) {
                Assert.AreEqual(negativeRight + a.Bits, g.Bits, $"y:{y} x:{x}");
            }
            if (-a.Bits != h.Bits) {
                Assert.AreEqual(-a.Bits, h.Bits, $"y:{y} x:{x}");
            }
        }
        [Test]
        public void TestAtan2P3() {
            {
                var a = I2F30.Atan2P3(0, 0);
                var b = I2F30.Atan2P3(0, 1);
                var c = I2F30.Atan2P3(1, 0);
                var d = I2F30.Atan2P3(1, 1);
                var e = I2F30.Atan2P3(0, -1);
                var f = I2F30.Atan2P3(1, -1);
                var g = I2F30.Atan2P3(-1, 0);
                var h = I2F30.Atan2P3(-1, 1);
                var i = I2F30.Atan2P3(-1, -1);
                Assert.AreEqual(I2F30.Zero, a);
                Assert.AreEqual(I2F30.Zero, b);
                Assert.AreEqual(I2F30.OneRepr / 2, c.Bits);
                Assert.AreEqual(I2F30.OneRepr / 4, d.Bits);
                Assert.AreEqual(I2F30.One, e);
                Assert.AreEqual(I2F30.OneRepr / 4 * 3, f.Bits);
                Assert.AreEqual(I2F30.NegativeOneRepr / 2, g.Bits);
                Assert.AreEqual(I2F30.NegativeOneRepr / 4, h.Bits);
                Assert.AreEqual(I2F30.NegativeOneRepr / 4 * 3, i.Bits);
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
