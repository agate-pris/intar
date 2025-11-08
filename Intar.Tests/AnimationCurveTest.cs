using NUnit.Framework;

namespace Intar.Tests {
    public partial class AnimationCurveTest {
        [Test]
        public static void TestKeyframeI17F15() {
            var a = I17F15.FromBits(1000);
            var b = I17F15.FromBits(2000);
            var c = I17F15.FromBits(3000);
            var d = I17F15.FromBits(4000);
            var e = I17F15.FromBits(5000);
            var k = new KeyframeI17F15();
            Assert.IsTrue(I17F15.Zero == k.Time);
            Assert.IsTrue(I17F15.Zero == k.Value);
            Assert.IsTrue(I17F15.Zero == k.InTangent);
            Assert.IsTrue(I17F15.Zero == k.OutTangent);
            k = new KeyframeI17F15(a, b);
            Assert.IsTrue(a == k.Time);
            Assert.IsTrue(b == k.Value);
            Assert.IsTrue(I17F15.Zero == k.InTangent);
            Assert.IsTrue(I17F15.Zero == k.OutTangent);
            k = new KeyframeI17F15(b, c, d, e);
            Assert.IsTrue(b == k.Time);
            Assert.IsTrue(c == k.Value);
            Assert.IsTrue(d == k.InTangent);
            Assert.IsTrue(e == k.OutTangent);
        }

        [Test]
        public static void TestAnimationCurveI17F15Constructor() {
            var curve = new AnimationCurveI17F15();
            Assert.AreEqual(curve.PreWrapMode, WrapMode.Clamp);
            Assert.AreEqual(curve.PostWrapMode, WrapMode.Clamp);
        }
    }
}
