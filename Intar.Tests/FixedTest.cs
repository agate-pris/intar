using NUnit.Framework;

namespace AgatePris.Intar.Tests {
    public class FixedTest {
        [Test]
        public static void Test() {
            var a = Fixed.I17F15.FromNum(1);
            var b = Fixed.I17F15.FromNum(2);
            a += b;
            Assert.AreEqual(3, (int)a);
        }
    }
}
