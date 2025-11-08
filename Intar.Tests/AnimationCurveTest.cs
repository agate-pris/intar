using NUnit.Framework;

namespace Intar.Tests {
    public partial class AnimationCurveTest {
        [Test]
        public static void TestKeyframeI17F15() {
            var a = I17F15.FromBits(1000);
            var b = I17F15.FromBits(2000);
            var c = I17F15.FromBits(3000);
            var d = I17F15.FromBits(4000);
            var k = new KeyframeI17F15();
            Assert.IsTrue(I17F15.Zero == k.Time);
            Assert.IsTrue(I17F15.Zero == k.Value);
            Assert.IsTrue(I17F15.Zero == k.InTangent);
            Assert.IsTrue(I17F15.Zero == k.OutTangent);
            k = new KeyframeI17F15(a, b, c, d);
            Assert.IsTrue(a == k.Time);
            Assert.IsTrue(b == k.Value);
            Assert.IsTrue(c == k.InTangent);
            Assert.IsTrue(d == k.OutTangent);
        }
    }
}
