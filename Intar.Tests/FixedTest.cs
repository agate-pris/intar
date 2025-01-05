using System;

using NUnit.Framework;

namespace Intar.Tests {
    public class FixedTest {
        [Test]
        public static void Test() {
            var a = (I17F15)1;
            var b = (I17F15)2;
            a += b;
            Utility.AssertAreEqual(3, a.ToInt32());
        }

        [Test]
        public static void TestFromNum() {
            const float f = 65539.9f / 65536;
            Assert.AreEqual(32769, ((I17F15)f).Bits);
            Assert.AreEqual(-32769, ((I17F15)(-f)).Bits);
        }
    }
}
