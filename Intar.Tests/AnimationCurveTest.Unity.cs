using Intar.Rand;
using NUnit.Framework;
using System;
using UnityEngine;

namespace Intar.Tests {
    public partial class AnimationCurveTest {
        static readonly UnityEngine.WrapMode[] wrapModes = new UnityEngine.WrapMode[] {
            UnityEngine.WrapMode.Default,
            UnityEngine.WrapMode.Clamp,
            UnityEngine.WrapMode.Loop,
            UnityEngine.WrapMode.PingPong,
            UnityEngine.WrapMode.ClampForever,
        };

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
        public static void TestIndexer() {
            var curve = new AnimationCurve();
            for (var i = 0; i < 3; i++) {
                for (var j = -1; j <= curve.length; j++) {
                    if (j < 0 || j == curve.length) {
                        // UnityEngine.AnimationCurve は IndexOutOfRangeException をスローする.
                        var e = Assert.Throws<IndexOutOfRangeException>(() => {
                            _ = curve[j];
                        }, $"i:{i} j:{j}");
                    } else {
                        Assert.DoesNotThrow(() => {
                            _ = curve[j];
                        }, $"i:{i} j:{j}");
                    }
                }
                _ = curve.AddKey(new Keyframe(i + 1, (i + 1) * 2));
            }
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
            curve.keys = Array.Empty<Keyframe>();
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

        [Test]
        public static void TestRemoveKey() {
            var curve = new AnimationCurve();

            // AnimationCurve は IndexOutOfRangeException をスローする.

            _ = Assert.Throws<IndexOutOfRangeException>(() => {
                curve.RemoveKey(0);
            });

            _ = curve.AddKey(new Keyframe(1, 1));
            Utility.AssertAreEqual(1, curve.length);

            _ = Assert.Throws<IndexOutOfRangeException>(() => {
                curve.RemoveKey(-1);
            });

            curve.RemoveKey(0);
            Utility.AssertAreEqual(0, curve.length);

            _ = Assert.Throws<IndexOutOfRangeException>(() => {
                curve.RemoveKey(0);
            });
        }

        [Test]
        public static void TestMoveKey() {
            var curve = new AnimationCurve();

            // AnimationCurve.MoveKey はインデックスが不正な場合
            // IndexOutOfRangeException をスローする.
            var e = Assert.Throws<IndexOutOfRangeException>(() => {
                _ = curve.MoveKey(0, new Keyframe(1, 1));
            });

            var i = curve.AddKey(new Keyframe(1, 1));
            Utility.AssertAreEqual(0, i);
            Utility.AssertAreEqual(1, curve.length);
            Utility.AssertAreEqual(1, curve[i].time);
            Utility.AssertAreEqual(1, curve[i].value);
            i = curve.MoveKey(0, new Keyframe(2, 2));
            Utility.AssertAreEqual(0, i);
            Utility.AssertAreEqual(1, curve.length);
            Utility.AssertAreEqual(2, curve[i].time);
            Utility.AssertAreEqual(2, curve[i].value);

            i = curve.AddKey(new Keyframe(3, 3));
            Utility.AssertAreEqual(1, i);
            Utility.AssertAreEqual(2, curve.length);
            Utility.AssertAreEqual(2, curve[0].time);
            Utility.AssertAreEqual(2, curve[0].value);
            Utility.AssertAreEqual(3, curve[1].time);
            Utility.AssertAreEqual(3, curve[1].value);

            i = curve.MoveKey(0, new Keyframe(4, 4));
            Utility.AssertAreEqual(1, i);
            Utility.AssertAreEqual(2, curve.length);
            Utility.AssertAreEqual(3, curve[0].time);
            Utility.AssertAreEqual(3, curve[0].value);
            Utility.AssertAreEqual(4, curve[1].time);
            Utility.AssertAreEqual(4, curve[1].value);

            i = curve.MoveKey(1, new Keyframe(1, 1));
            Utility.AssertAreEqual(0, i);
            Utility.AssertAreEqual(2, curve.length);
            Utility.AssertAreEqual(1, curve[0].time);
            Utility.AssertAreEqual(1, curve[0].value);
            Utility.AssertAreEqual(3, curve[1].time);
            Utility.AssertAreEqual(3, curve[1].value);

            // Keyframe.time が既存のキーと重複する場合,
            // 例外をスローせず指定したインデックスのキーを削除し -1 を返す.

            i = curve.MoveKey(0, new Keyframe(3, 5));
            Utility.AssertAreEqual(-1, i);
            Utility.AssertAreEqual(1, curve.length);
            Utility.AssertAreEqual(3, curve[0].time);
            Utility.AssertAreEqual(3, curve[0].value);
        }

        /// <summary>
        /// キー数が 0 または 1 の場合,
        /// それぞれ PreWrapMode, PostWrapMode に関わらず
        /// どこで評価しても 0 またはそのキーの値であることをテスト.
        /// </summary>
        static void TestEvaluateLessThanTwoKeys(UnityEngine.WrapMode preWrapMode, UnityEngine.WrapMode postWrapMode, Keyframe? keyFrame) {
            var randomNumberGenerator = new Xoroshiro128StarStar(1, 2);
            var value = keyFrame.HasValue ? keyFrame.Value.value : 0F;
            var rng = randomNumberGenerator;
            var curve = new AnimationCurve {
                preWrapMode = preWrapMode,
                postWrapMode = postWrapMode,
            };
            if (keyFrame.HasValue) {
                var time = keyFrame.Value.time;
                _ = curve.AddKey(new Keyframe(time, value));
                Utility.AssertAreEqual(value, curve.Evaluate(time));
            }
            Utility.AssertAreEqual(value, curve.Evaluate(0F));
            Utility.AssertAreEqual(value, curve.Evaluate(1F));
            Utility.AssertAreEqual(value, curve.Evaluate(-1F));
            for (var i = 0; i < 100; i++) {
                const long k = 1L << 32;
                var randomNumber = (float)rng.NextInt64(0, 1 + k) / k;
                Utility.AssertAreEqual(value, curve.Evaluate(randomNumber));
                Utility.AssertAreEqual(value, curve.Evaluate(randomNumber + 1));
                Utility.AssertAreEqual(value, curve.Evaluate(randomNumber - 1));
            }
        }

        [Test]
        public static void TestEvaluateLessThanTwoKeys() {
            var values = new float[] {
                0, 1, -1,
            };
            var randomNumberGenerator = new Xoroshiro128StarStar(1, 2);
            foreach (var preWrapMode in wrapModes) {
                foreach (var postWrapMode in wrapModes) {
                    // キー無しの場合常に評価値が 0 になることをテスト
                    TestEvaluateLessThanTwoKeys(preWrapMode, postWrapMode, null);

                    foreach (var v1 in values) {
                        foreach (var v2 in values) {
                            // 時間と値が境界値のキー 1 つの場合
                            // 常に評価値が値と同値になることをテスト
                            TestEvaluateLessThanTwoKeys(preWrapMode, postWrapMode, new Keyframe(v1, v2));
                        }

                        var rng = randomNumberGenerator;
                        for (var i = 0; i < 100; i++) {
                            var v2 = rng.Next(-32768, 32768) / 32768F;

                            // 時間が境界値, 値が乱数のキー 1 つの場合または
                            // 時間が乱数, 値が境界値のキー 1 つの場合
                            // 各々常に評価値が値と同値になることをテスト
                            TestEvaluateLessThanTwoKeys(preWrapMode, postWrapMode, new Keyframe(v1, v2));
                            TestEvaluateLessThanTwoKeys(preWrapMode, postWrapMode, new Keyframe(v2, v1));
                        }
                    }
                    {
                        // 時間と値が乱数のキー 1 つの場合
                        // 評価値が常に値と同値になることをテスト
                        var rng1 = randomNumberGenerator;
                        for (var i = 10; i < 10; i++) {
                            var rng2 = randomNumberGenerator;
                            var time = rng1.Next(-32768, 32768) / 32768F;
                            for (var j = 10; j < 10; j++) {
                                var value = rng2.Next(-32768, 32768) / 32768F;
                                TestEvaluateLessThanTwoKeys(preWrapMode, postWrapMode, new Keyframe(time, value));
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// キー数が 2 つの場合,
        /// それぞれのキーの時間で評価した時,
        /// その評価値が PreWrapMode 及び PostWrapMode に応じた値になることをテスト.
        /// </summary>
        [Test]
        public static void TestEvaluateTwoKeys() {
            var curve = new AnimationCurve();
            _ = curve.AddKey(new Keyframe(1F, 0F, 1F, 1F));
            _ = curve.AddKey(new Keyframe(2F, 1F, 1F, 1F));

            // 基本的にループ時, [0, 1) の範囲に収まるように評価されることをテスト.
            // また preWrapMode, postWrapMode が Default の場合
            // Loop と同じ挙動であることをテスト.
            foreach (var preWrapMode in wrapModes) {
                curve.preWrapMode = preWrapMode;
                foreach (var postWrapMode in wrapModes) {
                    curve.postWrapMode = postWrapMode;
                    Utility.AssertAreEqual(0.000F, curve.Evaluate(1.000F));
                    Utility.AssertAreEqual(0.125F, curve.Evaluate(1.125F));
                    Utility.AssertAreEqual(0.875F, curve.Evaluate(1.875F));
                    switch (preWrapMode) {
                        default:
                        throw new NotImplementedException(preWrapMode.ToString());

                        case UnityEngine.WrapMode.Default:
                        case UnityEngine.WrapMode.Loop:
                        Utility.AssertAreEqual(0.875F, curve.Evaluate(-0.125F));
                        Utility.AssertAreEqual(0.000F, curve.Evaluate(+0.000F));
                        Utility.AssertAreEqual(0.125F, curve.Evaluate(+0.125F));
                        Utility.AssertAreEqual(0.875F, curve.Evaluate(+0.875F));
                        break;

                        case UnityEngine.WrapMode.Clamp:
                        case UnityEngine.WrapMode.ClampForever:
                        Utility.AssertAreEqual(0F, curve.Evaluate(-0.125F));
                        Utility.AssertAreEqual(0F, curve.Evaluate(+0.000F));
                        Utility.AssertAreEqual(0F, curve.Evaluate(+0.125F));
                        Utility.AssertAreEqual(0F, curve.Evaluate(+0.875F));
                        break;

                        case UnityEngine.WrapMode.PingPong:
                        Utility.AssertAreEqual(0.125F, curve.Evaluate(-1.125F));
                        Utility.AssertAreEqual(0.000F, curve.Evaluate(-1.000F));
                        Utility.AssertAreEqual(0.125F, curve.Evaluate(-0.875F));
                        Utility.AssertAreEqual(0.875F, curve.Evaluate(-0.125F));
                        Utility.AssertAreEqual(1.000F, curve.Evaluate(+0.000F));
                        Utility.AssertAreEqual(0.875F, curve.Evaluate(+0.125F));
                        Utility.AssertAreEqual(0.125F, curve.Evaluate(+0.875F));
                        break;
                    }
                    switch (postWrapMode) {
                        default:
                        throw new NotImplementedException(preWrapMode.ToString());

                        case UnityEngine.WrapMode.Default:
                        case UnityEngine.WrapMode.Loop:
                        Utility.AssertAreEqual(0.000F, curve.Evaluate(2.000F));
                        Utility.AssertAreEqual(0.125F, curve.Evaluate(2.125F));
                        Utility.AssertAreEqual(0.875F, curve.Evaluate(2.875F));
                        Utility.AssertAreEqual(0.000F, curve.Evaluate(3.000F));
                        Utility.AssertAreEqual(0.125F, curve.Evaluate(3.125F));
                        break;

                        case UnityEngine.WrapMode.Clamp:
                        case UnityEngine.WrapMode.ClampForever:
                        Utility.AssertAreEqual(1F, curve.Evaluate(2.000F));
                        Utility.AssertAreEqual(1F, curve.Evaluate(2.125F));
                        Utility.AssertAreEqual(1F, curve.Evaluate(2.875F));
                        Utility.AssertAreEqual(1F, curve.Evaluate(3.000F));
                        Utility.AssertAreEqual(1F, curve.Evaluate(3.125F));
                        break;

                        case UnityEngine.WrapMode.PingPong:
                        Utility.AssertAreEqual(1.000F, curve.Evaluate(2.000F));
                        Utility.AssertAreEqual(0.875F, curve.Evaluate(2.125F));
                        Utility.AssertAreEqual(0.125F, curve.Evaluate(2.875F));
                        Utility.AssertAreEqual(0.000F, curve.Evaluate(3.000F));
                        Utility.AssertAreEqual(0.125f, curve.Evaluate(3.125F));
                        break;
                    }
                }
            }
        }
    }
}
