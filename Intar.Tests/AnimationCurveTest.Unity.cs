using Intar.Rand;
using NUnit.Framework;
using System;
using UnityEditor;
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

        static float RandomTangent() {
            const float th = 1.57F;
            return (float)Math.Tan(UnityEngine.Random.Range(-th, th));
        }
        static float RandomWeight() => UnityEngine.Random.value;
        static void SetRandomKeyframe(float time, ref Keyframe key) {
            key.time = time;
            key.value = UnityEngine.Random.Range(-10F, +10F);
            key.inTangent = RandomTangent();
            key.outTangent = RandomTangent();
            key.inWeight = RandomWeight();
            key.outWeight = RandomWeight();
            key.weightedMode = (WeightedMode)UnityEngine.Random.Range(0, 4);
        }

        internal static bool RandomBool() => UnityEngine.Random.value < 0.5F;
        internal static UnityEngine.WrapMode RandomWrapMode() {
            return wrapModes[UnityEngine.Random.Range(0, wrapModes.Length)];
        }
        internal static AnimationUtility.TangentMode RandomTangentMode() {
            return (AnimationUtility.TangentMode)UnityEngine.Random.Range(0, 5);
        }
        internal static Keyframe RandomKeyframe(float time) {
            var keyframe = new Keyframe();
            SetRandomKeyframe(time, ref keyframe);
            return keyframe;
        }

        /// <summary>
        /// <c>Keyframe.time</c>, <c>Keyframe.value</c>, <c>Keyframe.inTangent</c>,
        /// <c>Keyframe.outTangent</c>, <c>Keyframe.inWeight</c>, <c>Keyframe.outWeight</c>,
        /// そして <c>Keyframe.weightedMode</c> が等しいことを確認する.
        /// </summary>
        static void TestKeyframe(Keyframe expected, Keyframe actual) {
            Utility.AssertAreEqual(expected.time, actual.time);
            Utility.AssertAreEqual(expected.value, actual.value);
            Utility.AssertAreEqual(expected.inTangent, actual.inTangent);
            Utility.AssertAreEqual(expected.outTangent, actual.outTangent);
            Utility.AssertAreEqual(expected.inWeight, actual.inWeight);
            Utility.AssertAreEqual(expected.outWeight, actual.outWeight);
            if (expected.weightedMode != actual.weightedMode) {
                Assert.Fail($"Keyframe.weightedMode mismatch. expected:{expected.weightedMode} actual:{actual.weightedMode}");
            }
        }

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

        static void TestMoveKey() {
            static int MoveKeyRandom(AnimationCurve curve, int index, float time, ref Keyframe keyframe, int expected, int length) {
                var l = RandomTangentMode();
                var r = RandomTangentMode();
                var b = RandomBool();

                // SetKeyLeftTangentMode, SetKeyRightTangentMode,
                // そして SetKeyBroken による副作用が MoveKey で修正されることをテスト.
                AnimationUtility.SetKeyLeftTangentMode(curve, index, l);
                AnimationUtility.SetKeyRightTangentMode(curve, index, r);
                AnimationUtility.SetKeyBroken(curve, index, b);
                var key = curve[index];
                SetRandomKeyframe(time, ref key);
                index = curve.MoveKey(index, key);
                Utility.AssertAreEqual(expected, index);
                Utility.AssertAreEqual(length, curve.length);
                if (index == -1) {
                    return index;
                }
                var failed =
                    l != AnimationUtility.GetKeyLeftTangentMode(curve, index) ||
                    r != AnimationUtility.GetKeyRightTangentMode(curve, index) ||
                    b != AnimationUtility.GetKeyBroken(curve, index);
                if (failed) {
                    Assert.Fail($"MoveKeyRandom failed. index:{index} time:{time} l:{l} r:{r} b:{b}");
                }
                TestKeyframe(key, curve[index]);
                keyframe = key;
                return index;
            }

            var curve = new AnimationCurve() {
                preWrapMode = RandomWrapMode(),
                postWrapMode = RandomWrapMode(),
            };

            // AnimationCurve.MoveKey はインデックスが不正な場合
            // IndexOutOfRangeException をスローする.
            var e = Assert.Throws<IndexOutOfRangeException>(() => {
                _ = curve.MoveKey(0, new Keyframe(1, 1));
            });

            var k1 = RandomKeyframe(1);
            var i = curve.AddKey(k1);
            Utility.AssertAreEqual(0, i);
            Utility.AssertAreEqual(1, curve.length);
            Utility.AssertAreEqual(1, curve[i].time);
            TestKeyframe(k1, curve[i]);

            i = MoveKeyRandom(curve, i, 2, ref k1, 0, 1);
            Utility.AssertAreEqual(0, i);
            Utility.AssertAreEqual(1, curve.length);

            var k2 = RandomKeyframe(3);
            i = curve.AddKey(k2);
            Utility.AssertAreEqual(1, i);
            Utility.AssertAreEqual(2, curve.length);
            TestKeyframe(k1, curve[0]);
            TestKeyframe(k2, curve[1]);

            i = MoveKeyRandom(curve, 0, 4, ref k1, 1, 2);
            TestKeyframe(k2, curve[0]);

            i = MoveKeyRandom(curve, 1, 1, ref k1, 0, 2);
            TestKeyframe(k1, curve[i]);

            // Keyframe.time が既存のキーと重複する場合,
            // 例外をスローせず指定したインデックスのキーを削除し -1 を返す.

            i = MoveKeyRandom(curve, 0, 3, ref k1, -1, 1);
            TestKeyframe(k2, curve[0]);
        }

        [TestCase(9999)]
        public static void TestMoveKey(int testCount) {
            for (var i = 0; i < testCount; i++) {
                TestMoveKey();
            }
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

        /// <summary>
        /// 周期長が 0 のカーブのテスト
        /// </summary>
        [TestCase(true)]
        [TestCase(false)]
        public static void TestEvaluateZeroDuration(bool dryRun) {
            for (var flag = 0; flag < 1; flag++) {
                int first, second, third, last;
                if (flag == 0) {
                    first = 1;
                    second = 4;
                    third = 3;
                    last = 2;
                } else {
                    first = 2;
                    second = 3;
                    third = 4;
                    last = 1;
                }
                var curve = new AnimationCurve {
                    keys = new Keyframe[] {
                        new Keyframe(1, first),
                        new Keyframe(1, second),
                        new Keyframe(1, third),
                        new Keyframe(1, last),
                    }
                };
                var message = "";
                for (var t = 0; t <= 2; t++) {
                    foreach (var pre in wrapModes) {
                        curve.preWrapMode = pre;
                        foreach (var post in wrapModes) {
                            curve.postWrapMode = post;
                            var a = curve.Evaluate(t);
                            float e;
                            if (t == 0) {
                                switch (pre) {
                                    default:
                                    throw new NotImplementedException($"time:{t} preWrapMode:{pre} postWrapMode:{post}");

                                    case UnityEngine.WrapMode.Default:
                                    case UnityEngine.WrapMode.PingPong:
                                    e = last;
                                    break;

                                    case UnityEngine.WrapMode.Clamp:
                                    case UnityEngine.WrapMode.ClampForever:
                                    e = first;
                                    break;

                                    case UnityEngine.WrapMode.Loop:
                                    e = float.NaN;
                                    break;
                                }
                            } else {
                                switch (post) {
                                    default:
                                    throw new NotImplementedException($"time:{t} preWrapMode:{pre} postWrapMode:{post}");

                                    case UnityEngine.WrapMode.Default:
                                    case UnityEngine.WrapMode.Clamp:
                                    case UnityEngine.WrapMode.PingPong:
                                    case UnityEngine.WrapMode.ClampForever:
                                    e = last;
                                    break;

                                    case UnityEngine.WrapMode.Loop:
                                    e = first;
                                    break;
                                }
                            }
                            var expectedIsNaN = float.IsNaN(e);
                            var actualIsNaN = float.IsNaN(a);
                            if (dryRun) {
                                message += $"time:{t} preWrapMode:{pre} postWrapMode:{post} expected:{e} ";
                                if ((expectedIsNaN && actualIsNaN) || e == a) {
                                    message += $"actual:{a}\n";
                                } else {
                                    message += $"<color=red>actual:{a}</color>\n";
                                }
                            } else if (expectedIsNaN) {
                                Assert.IsTrue(actualIsNaN);
                            } else {
                                Utility.AssertAreEqual(e, a);
                            }
                        }
                    }
                }
                if (dryRun) {
                    Console.WriteLine(message);
                }
            }
        }

        /// <summary>
        /// キーとキーの間の時間が 0 のカーブのテスト
        /// </summary>
        [TestCase(true)]
        [TestCase(false)]
        public static void TestEvaluateZeroInterval(bool dryRun) {
            // キーの時間が同じ場合, 後に追加されたキーの値が評価されることをテスト.

            var curve = new AnimationCurve {
                keys = new Keyframe[] {
                    new Keyframe(1F, 1F),
                    new Keyframe(1F, 2F),
                    new Keyframe(2F, 2F),
                    new Keyframe(2F, 3F),
                    new Keyframe(3F, 3F),
                    new Keyframe(3F, 4F),
                }
            };
            var message = "";
            for (var t = 0; t <= 6; t++) {
                foreach (var pre in wrapModes) {
                    curve.preWrapMode = pre;
                    foreach (var post in wrapModes) {
                        curve.postWrapMode = post;
                        var a = curve.Evaluate(t);
                        float e;
                        switch (t) {
                            default:
                            throw new NotImplementedException($"time:{t} preWrapMode:{pre} postWrapMode:{post}");

                            case 0:
                            switch (pre) {
                                default:
                                throw new NotImplementedException($"time:{t} preWrapMode:{pre} postWrapMode:{post}");

                                case UnityEngine.WrapMode.Default:
                                case UnityEngine.WrapMode.Loop:
                                case UnityEngine.WrapMode.PingPong:
                                e = 3F;
                                break;

                                case UnityEngine.WrapMode.Clamp:
                                case UnityEngine.WrapMode.ClampForever:
                                e = 1F;
                                break;
                            }
                            break;

                            case 1:
                            e = 1F;
                            break;

                            case 2:
                            e = 3F;
                            break;

                            case 3:
                            switch (post) {
                                default:
                                throw new NotImplementedException($"time:{t} preWrapMode:{pre} postWrapMode:{post}");

                                case UnityEngine.WrapMode.Default:
                                case UnityEngine.WrapMode.Loop:
                                e = 1F;
                                break;

                                case UnityEngine.WrapMode.Clamp:
                                case UnityEngine.WrapMode.PingPong:
                                case UnityEngine.WrapMode.ClampForever:
                                e = 4F;
                                break;
                            }
                            break;

                            case 4:
                            switch (post) {
                                default:
                                throw new NotImplementedException($"time:{t} preWrapMode:{pre} postWrapMode:{post}");

                                case UnityEngine.WrapMode.Default:
                                case UnityEngine.WrapMode.Loop:
                                case UnityEngine.WrapMode.PingPong:
                                e = 3F;
                                break;

                                case UnityEngine.WrapMode.Clamp:
                                case UnityEngine.WrapMode.ClampForever:
                                e = 4F;
                                break;
                            }
                            break;

                            case 5:
                            switch (post) {
                                default:
                                throw new NotImplementedException($"time:{t} preWrapMode:{pre} postWrapMode:{post}");

                                case UnityEngine.WrapMode.Default:
                                case UnityEngine.WrapMode.Loop:
                                case UnityEngine.WrapMode.PingPong:
                                e = 1F;
                                break;

                                case UnityEngine.WrapMode.Clamp:
                                case UnityEngine.WrapMode.ClampForever:
                                e = 4F;
                                break;
                            }
                            break;
                            case 6:
                            switch (post) {
                                default:
                                throw new NotImplementedException($"time:{t} preWrapMode:{pre} postWrapMode:{post}");

                                case UnityEngine.WrapMode.Default:
                                case UnityEngine.WrapMode.Loop:
                                case UnityEngine.WrapMode.PingPong:
                                e = 3F;
                                break;

                                case UnityEngine.WrapMode.Clamp:
                                case UnityEngine.WrapMode.ClampForever:
                                e = 4F;
                                break;
                            }
                            break;
                        }
                        if (dryRun) {
                            message += $"time:{t} preWrapMode:{pre} postWrapMode:{post} expected:{e} ";
                            if (e == a) {
                                message += $"actual:{a}\n";
                            } else {
                                message += $"<color=red>actual:{a}</color>\n";
                            }
                        } else {
                            Utility.AssertAreEqual(e, a);
                        }
                    }
                }
            }
            if (dryRun) {
                Debug.Log(message);
            }
        }

        /// <summary>
        /// <c>Keyframe.tangentMode</c> を直接操作することで
        /// <c>AnimationUtility.GetKeyBroken</c>、
        /// <c>AnimationUtility.GetKeyLeftTangentMode</c>、そして
        /// <c>AnimationUtility.GetKeyRightTangentMode</c>
        /// を使用せずにパラメータを操作できることをテストする。
        /// また、<c>AnimationCurve.MoveKey</c>
        /// を使用することでそれらの関数の使用によって自動的に変更されたパラメータを修正できることをテストする。
        /// </summary>
        /// <param name="testCount"></param>
        [TestCase(100)]
        public static void TestRestoreKeys(int testCount) {
            for (var testIndex = 0; testIndex < testCount; testIndex++) {
                var count = UnityEngine.Random.Range(1, 100);
                var keys = new Keyframe[count];

                var brokenFlags = new bool[count];
                var leftModes = new AnimationUtility.TangentMode[count];
                var rightModes = new AnimationUtility.TangentMode[count];

                for (var i = 0; i < count; i++) {
                    var time = (float)i / count;
                    var value = UnityEngine.Random.Range(-1F, +1F);
                    var inTangent = UnityEngine.Random.Range(-1F, +1F);
                    var outTangent = UnityEngine.Random.Range(-1F, +1F);
                    var inWeight = UnityEngine.Random.Range(0F, +1F);
                    var outWeight = UnityEngine.Random.Range(0F, +1F);
                    var weightedMode = (WeightedMode)UnityEngine.Random.Range(0, 4);
                    var broken = UnityEngine.Random.value < 0.5F;
                    var left = UnityEngine.Random.Range(0, 5);
                    var right = UnityEngine.Random.Range(0, 5);
                    var tangentMode = (broken ? 1 : 0) | (left << 1) | (right << 5);

#pragma warning disable CS0618 // 型またはメンバーが旧型式です
                    keys[i] = new Keyframe(time, value, inTangent, outTangent, inWeight, outWeight) {
                        weightedMode = weightedMode,
                        tangentMode = tangentMode,
                    };
#pragma warning restore CS0618 // 型またはメンバーが旧型式です

                    brokenFlags[i] = broken;
                    leftModes[i] = (AnimationUtility.TangentMode)left;
                    rightModes[i] = (AnimationUtility.TangentMode)right;
                }

                // keys 設定時に各値が影響を受けないことをテスト.
                var curve = new AnimationCurve { keys = keys };
                for (var i = 0; i < count; i++) {
                    var actual = curve[i];

                    Utility.AssertAreEqual(keys[i].time, actual.time);
                    Utility.AssertAreEqual(keys[i].value, actual.value);
                    Utility.AssertAreEqual(keys[i].inTangent, actual.inTangent);
                    Utility.AssertAreEqual(keys[i].outTangent, actual.outTangent);
                    Utility.AssertAreEqual(keys[i].inWeight, actual.inWeight);
                    Utility.AssertAreEqual(keys[i].outWeight, actual.outWeight);
                    Assert.AreEqual(keys[i].weightedMode, actual.weightedMode);

#pragma warning disable CS0618 // 型またはメンバーが旧型式です
                    Assert.AreEqual(keys[i].tangentMode, actual.tangentMode);
#pragma warning restore CS0618 // 型またはメンバーが旧型式です

                    Assert.AreEqual(brokenFlags[i], AnimationUtility.GetKeyBroken(curve, i));
                    Assert.AreEqual(leftModes[i], AnimationUtility.GetKeyLeftTangentMode(curve, i));
                    Assert.AreEqual(rightModes[i], AnimationUtility.GetKeyRightTangentMode(curve, i));
                }

                // * 上書きを防ぐため
                //   SetKeyLeftTangentMode, SetKeyRightTangentMode, SetKeyBroken の順序で設定する.
                // * SetKeyLeftTangentMode, SetKeyRightTangentMode, SetKeyBroken は
                //   inTangent, outTangent, inWeight, outWeight を上書きするため
                //   MoveKey で再設定する.
                for (var i = 0; i < count; i++) {
                    AnimationUtility.SetKeyLeftTangentMode(curve, i, leftModes[i]);
                    AnimationUtility.SetKeyRightTangentMode(curve, i, rightModes[i]);
                    AnimationUtility.SetKeyBroken(curve, i, brokenFlags[i]);
                    var k = curve[i];
                    k.inTangent = keys[i].inTangent;
                    k.outTangent = keys[i].outTangent;
                    k.inWeight = keys[i].inWeight;
                    k.outWeight = keys[i].outWeight;
                    _ = curve.MoveKey(i, k);
                }

                for (var i = 0; i < count; i++) {
                    var actual = curve[i];

                    Assert.AreEqual(leftModes[i], AnimationUtility.GetKeyLeftTangentMode(curve, i));
                    Assert.AreEqual(rightModes[i], AnimationUtility.GetKeyRightTangentMode(curve, i));
                    Assert.AreEqual(brokenFlags[i], AnimationUtility.GetKeyBroken(curve, i));
                    Assert.AreEqual(keys[i].weightedMode, actual.weightedMode);
                    Utility.AssertAreEqual(keys[i].time, actual.time);
                    Utility.AssertAreEqual(keys[i].value, actual.value);
                    Utility.AssertAreEqual(keys[i].inTangent, actual.inTangent);
                    Utility.AssertAreEqual(keys[i].outTangent, actual.outTangent);
                    Utility.AssertAreEqual(keys[i].inWeight, actual.inWeight);
                    Utility.AssertAreEqual(keys[i].outWeight, actual.outWeight);

#pragma warning disable CS0618 // 型またはメンバーが旧型式です
                    Utility.AssertAreEqual(keys[i].tangentMode, curve[i].tangentMode);
#pragma warning restore CS0618 // 型またはメンバーが旧型式です
                }
            }
        }
    }
}
