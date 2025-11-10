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
            Assert.AreEqual(0, curve.Length);
            Assert.IsNotNull(curve.Keys);

            // Length と Keys のアクセス順序が逆でも正しく動作することを確認
            curve = new AnimationCurveI17F15();
            Assert.IsNotNull(curve.Keys);
            Assert.AreEqual(0, curve.Length);
        }

        [Test]
        public static void TestAddKeyI17F15() {
            var curve = new AnimationCurveI17F15();
            var k1 = new KeyframeI17F15((I17F15)2, (I17F15)2);
            var k2 = new KeyframeI17F15((I17F15)2, (I17F15)3);
            var k3 = new KeyframeI17F15((I17F15)4, (I17F15)4);
            var k4 = new KeyframeI17F15((I17F15)3, (I17F15)3);
            var k5 = new KeyframeI17F15((I17F15)1, (I17F15)1);
            var i = curve.AddKey(k1);
            Utility.AssertAreEqual(1, curve.Length);
            Utility.AssertAreEqual(0, i);
            Utility.AssertAreEqual(k1.Time, curve[i].Time);
            Utility.AssertAreEqual(k1.Value, curve[i].Value);
            Utility.AssertAreEqual(-1, curve.AddKey(k2));
            Utility.AssertAreEqual(1, curve.Length);
            Utility.AssertAreEqual(k1.Time, curve[i].Time);
            Utility.AssertAreEqual(k1.Value, curve[i].Value);
            i = curve.AddKey(k3);
            Utility.AssertAreEqual(2, curve.Length);
            Utility.AssertAreEqual(1, i);
            Utility.AssertAreEqual(k1.Time, curve[0].Time);
            Utility.AssertAreEqual(k1.Value, curve[0].Value);
            Utility.AssertAreEqual(k3.Time, curve[i].Time);
            Utility.AssertAreEqual(k3.Value, curve[i].Value);
            i = curve.AddKey(k4);
            Utility.AssertAreEqual(3, curve.Length);
            Utility.AssertAreEqual(1, i);
            Utility.AssertAreEqual(k1.Time, curve[0].Time);
            Utility.AssertAreEqual(k1.Value, curve[0].Value);
            Utility.AssertAreEqual(k4.Time, curve[i].Time);
            Utility.AssertAreEqual(k4.Value, curve[i].Value);
            Utility.AssertAreEqual(k3.Time, curve[2].Time);
            Utility.AssertAreEqual(k3.Value, curve[2].Value);
            i = curve.AddKey(k5);
            Utility.AssertAreEqual(4, curve.Length);
            Utility.AssertAreEqual(0, i);
            Utility.AssertAreEqual(k5.Time, curve[i].Time);
            Utility.AssertAreEqual(k5.Value, curve[i].Value);
            Utility.AssertAreEqual(k1.Time, curve[1].Time);
            Utility.AssertAreEqual(k1.Value, curve[1].Value);
            Utility.AssertAreEqual(k4.Time, curve[2].Time);
            Utility.AssertAreEqual(k4.Value, curve[2].Value);
            Utility.AssertAreEqual(k3.Time, curve[3].Time);
            Utility.AssertAreEqual(k3.Value, curve[3].Value);
        }

        [Test]
        public static void TestSetKeysI17F15() {
            var keys = new KeyframeI17F15[] {
                new KeyframeI17F15(I17F15.FromBits(4000), I17F15.FromBits(5000)),
                new KeyframeI17F15(I17F15.FromBits(4000), I17F15.FromBits(4000)),
                new KeyframeI17F15(I17F15.FromBits(3000), I17F15.FromBits(4000)),
                new KeyframeI17F15(I17F15.FromBits(3000), I17F15.FromBits(3000)),
                new KeyframeI17F15(I17F15.FromBits(2000), I17F15.FromBits(3000)),
                new KeyframeI17F15(I17F15.FromBits(2000), I17F15.FromBits(2000)),
                new KeyframeI17F15(I17F15.FromBits(1000), I17F15.FromBits(2000)),
                new KeyframeI17F15(I17F15.FromBits(1000), I17F15.FromBits(1000)),
            };
            var curve = new AnimationCurveI17F15 { Keys = keys };

            // Keys 設定時, 値が安定ソートされることをテスト
            Assert.AreEqual(8, curve.Length);
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
