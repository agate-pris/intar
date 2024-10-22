using System;

using NUnit.Framework;

namespace AgatePris.Intar.Tests {
    public class FixedTest {
        [Test]
        public static void Test() {
            var a = I17F15.CheckedFrom(1).Value;
            var b = I17F15.CheckedFrom(2).Value;
            a += b;
            Utility.AssertAreEqual(3, (int)a);
        }

        [Test]
        public static void TestFromNum() {
            const float f = 65539.9f / 65536;
            Assert.AreEqual(32769, I17F15.CheckedFrom(f)?.Bits);
            Assert.AreEqual(-32769, I17F15.CheckedFrom(-f)?.Bits);
        }

        [Test]
        public static void TestStrictFromNum() {
            _ = Assert.Throws<OverflowException>(() => I17F15.StrictFrom(int.MaxValue));
            _ = Assert.Throws<OverflowException>(() => I2F30.StrictFrom(2.0f));
            _ = Assert.Throws<OverflowException>(() => I2F30.StrictFrom(2.0));
            _ = Assert.Throws<OverflowException>(() => I2F30.StrictFrom(float.NegativeInfinity));
            _ = Assert.Throws<OverflowException>(() => I2F30.StrictFrom(float.PositiveInfinity));
            _ = Assert.Throws<OverflowException>(() => I2F30.StrictFrom(float.NaN));
        }

        [Test]
        public static void TestCheckedFromNum() {
            Assert.AreEqual(int.MinValue, I2F30.CheckedFrom(-2.0f)?.Bits);
            Assert.AreEqual(null, I2F30.CheckedFrom(2));
            Assert.AreEqual(null, I2F30.CheckedFrom(2.0f));
            Assert.AreEqual(null, I2F30.CheckedFrom(-2.000001f));
            Assert.AreEqual(null, I2F30.CheckedFrom(-3));
            Assert.AreEqual(null, I17F15.CheckedFrom(float.NegativeInfinity));
            Assert.AreEqual(null, I17F15.CheckedFrom(float.PositiveInfinity));
            Assert.AreEqual(null, I17F15.CheckedFrom(float.NaN));
            Assert.AreEqual(null, I17F15.CheckedFrom(double.NegativeInfinity));
            Assert.AreEqual(null, I17F15.CheckedFrom(double.PositiveInfinity));
            Assert.AreEqual(null, I17F15.CheckedFrom(double.NaN));
            Assert.AreEqual(null, I17F15.CheckedFrom(65536.0f));
        }
    }
}
