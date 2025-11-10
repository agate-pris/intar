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

        [Test]
        public static void TestAddKey() {
            var curve = new AnimationCurve();
            var k1 = new Keyframe(2, 2);
            var k2 = new Keyframe(2, 3);
            var k3 = new Keyframe(4, 4);
            var k4 = new Keyframe(3, 3);
            var k5 = new Keyframe(1, 1);
            var i = curve.AddKey(k1);
            Utility.AssertAreEqual(1, curve.length);
            Utility.AssertAreEqual(0, i);
            Utility.AssertAreEqual(k1.time, curve[i].time);
            Utility.AssertAreEqual(k1.value, curve[i].value);
            Utility.AssertAreEqual(-1, curve.AddKey(k2));
            Utility.AssertAreEqual(1, curve.length);
            Utility.AssertAreEqual(k1.time, curve[i].time);
            Utility.AssertAreEqual(k1.value, curve[i].value);
            i = curve.AddKey(k3);
            Utility.AssertAreEqual(2, curve.length);
            Utility.AssertAreEqual(1, i);
            Utility.AssertAreEqual(k1.time, curve[0].time);
            Utility.AssertAreEqual(k1.value, curve[0].value);
            Utility.AssertAreEqual(k3.time, curve[i].time);
            Utility.AssertAreEqual(k3.value, curve[i].value);
            i = curve.AddKey(k4);
            Utility.AssertAreEqual(3, curve.length);
            Utility.AssertAreEqual(1, i);
            Utility.AssertAreEqual(k1.time, curve[0].time);
            Utility.AssertAreEqual(k1.value, curve[0].value);
            Utility.AssertAreEqual(k4.time, curve[i].time);
            Utility.AssertAreEqual(k4.value, curve[i].value);
            Utility.AssertAreEqual(k3.time, curve[2].time);
            Utility.AssertAreEqual(k3.value, curve[2].value);
            i = curve.AddKey(k5);
            Utility.AssertAreEqual(4, curve.length);
            Utility.AssertAreEqual(0, i);
            Utility.AssertAreEqual(k5.time, curve[i].time);
            Utility.AssertAreEqual(k5.value, curve[i].value);
            Utility.AssertAreEqual(k1.time, curve[1].time);
            Utility.AssertAreEqual(k1.value, curve[1].value);
            Utility.AssertAreEqual(k4.time, curve[2].time);
            Utility.AssertAreEqual(k4.value, curve[2].value);
            Utility.AssertAreEqual(k3.time, curve[3].time);
            Utility.AssertAreEqual(k3.value, curve[3].value);
        }

        [Test]
        public static void TestSetKeys() {
            var curve = new AnimationCurve();
            Assert.AreEqual(0, curve.length);
            curve.keys = new Keyframe[] { };
            Assert.AreEqual(0, curve.length);
            curve.keys = null;
            Assert.AreEqual(0, curve.length);

            var keys = new Keyframe[] {
                new Keyframe(4, 5),
                new Keyframe(4, 4),
                new Keyframe(3, 4),
                new Keyframe(3, 3),
                new Keyframe(2, 3),
                new Keyframe(2, 2),
                new Keyframe(1, 2),
                new Keyframe(1, 1),
            };
            curve.keys = keys;

            // keys 設定時, 値が安定ソートされることをテスト
            Assert.AreEqual(8, curve.length);
            Assert.AreEqual(keys[6], curve[0]);
            Assert.AreEqual(keys[7], curve[1]);
            Assert.AreEqual(keys[4], curve[2]);
            Assert.AreEqual(keys[5], curve[3]);
            Assert.AreEqual(keys[2], curve[4]);
            Assert.AreEqual(keys[3], curve[5]);
            Assert.AreEqual(keys[0], curve[6]);
            Assert.AreEqual(keys[1], curve[7]);
        }
    }
}
