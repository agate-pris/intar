using NUnit.Framework;
using UnityEngine;

namespace Intar.Tests {
    public partial class AnimationCurveTest {
        [Test]
        public static void TestKeyframe() {
            var k = new Keyframe();
            Assert.IsTrue(0 == k.time);
            Assert.IsTrue(0 == k.value);
            Assert.IsTrue(0 == k.inTangent);
            Assert.IsTrue(0 == k.outTangent);
            Assert.IsTrue(0 == k.inWeight);
            Assert.IsTrue(0 == k.outWeight);
            k = new Keyframe(1, 2);
            Assert.IsTrue(1 == k.time);
            Assert.IsTrue(2 == k.value);
            Assert.IsTrue(0 == k.inTangent);
            Assert.IsTrue(0 == k.outTangent);
            Assert.IsTrue(0 == k.inWeight);
            Assert.IsTrue(0 == k.outWeight);
            k = new Keyframe(2, 3, 4, 5);
            Assert.IsTrue(2 == k.time);
            Assert.IsTrue(3 == k.value);
            Assert.IsTrue(4 == k.inTangent);
            Assert.IsTrue(5 == k.outTangent);
            Assert.IsTrue(0 == k.inWeight);
            Assert.IsTrue(0 == k.outWeight);
            k = new Keyframe(3, 4, 5, 6, 7, 8);
            Assert.IsTrue(3 == k.time);
            Assert.IsTrue(4 == k.value);
            Assert.IsTrue(5 == k.inTangent);
            Assert.IsTrue(6 == k.outTangent);
            Assert.IsTrue(7 == k.inWeight);
            Assert.IsTrue(8 == k.outWeight);
        }

        [Test]
        public static void TestAnimationCurveConstructor() {
            var curve = new AnimationCurve();
            Assert.IsTrue(curve.preWrapMode == UnityEngine.WrapMode.ClampForever);
            Assert.IsTrue(curve.postWrapMode == UnityEngine.WrapMode.ClampForever);
            Assert.AreEqual(0, curve.length);
            Assert.IsNotNull(curve.keys);

            // length と keys のアクセス順序が逆でも正しく動作することを確認
            curve = new AnimationCurve();
            Assert.IsNotNull(curve.keys);
            Assert.AreEqual(0, curve.length);
        }
    }
}
