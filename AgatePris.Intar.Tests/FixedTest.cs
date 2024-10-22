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
        public static void TestStrictFromNum() {
            _ = Assert.Throws<OverflowException>(() => I17F15.StrictFrom(int.MaxValue));
            _ = Assert.Throws<OverflowException>(() => I2F30.StrictFromNum(2.0f));
            _ = Assert.Throws<OverflowException>(() => I2F30.StrictFromNum(2.0));
            _ = Assert.Throws<OverflowException>(() => I2F30.StrictFromNum(2.0m));
        }
    }
}
