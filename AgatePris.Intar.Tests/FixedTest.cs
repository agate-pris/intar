using NUnit.Framework;

namespace AgatePris.Intar.Tests {
    public class FixedTest {
        [Test]
        public static void Test() {
            var a = I17F15.FromNum(1);
            var b = I17F15.FromNum(2);
            a += b;
            Utility.AssertAreEqual(3, (int)a);
        }
    }
}
