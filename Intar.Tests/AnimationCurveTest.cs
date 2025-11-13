using Intar.Rand;
using NUnit.Framework;
using System;

namespace Intar.Tests {
    public partial class AnimationCurveTest {
        static readonly WrapMode[] wrapModesI17F15 = new WrapMode[] {
#if false
            0,
#endif
            WrapMode.Clamp,
            WrapMode.Loop,
        };

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
        public static void TestIndexerI17F15() {
            var curve = new AnimationCurveI17F15();
            for (var i = 0; i < 3; i++) {
                for (var j = -1; j <= curve.Length; j++) {
                    if (j < 0 || j == curve.Length) {
                        // AnimationCurveI17F15 は ArgumentOutOfRangeException をスローする.
                        var e = Assert.Throws<ArgumentOutOfRangeException>(() => {
                            _ = curve[j];
                        }, $"i:{i} j:{j}");
                    } else {
                        Assert.DoesNotThrow(() => {
                            _ = curve[j];
                        }, $"i:{i} j:{j}");
                    }
                }
                var t = (I17F15)(i + 1);
                var v = (I17F15)((i + 1) * 2);
                _ = curve.AddKey(new KeyframeI17F15(t, v));
            }
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
            var curve = new AnimationCurveI17F15();
            Assert.AreEqual(0, curve.Length);
            curve.Keys = Array.Empty<KeyframeI17F15>();
            Assert.AreEqual(0, curve.Length);
            curve.Keys = null;
            Assert.AreEqual(0, curve.Length);

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
            curve.Keys = keys;

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

        [Test]
        public static void TestClearKeys() {
            var curve = new AnimationCurveI17F15();

            // 初期状態で ClearKeys を呼んでも問題ないことをテスト
            curve.ClearKeys();
            Utility.AssertAreEqual(0, curve.Length);

            _ = curve.AddKey(new KeyframeI17F15((I17F15)1, (I17F15)1));
            Utility.AssertAreEqual(1, curve.Length);

            curve.ClearKeys();
            Utility.AssertAreEqual(0, curve.Length);
        }

        [Test]
        public static void TestRemoveKeyI17F15() {
            var curve = new AnimationCurveI17F15();

            // AnimationCurveI17F15 は ArgumentOutOfRangeException をスローする.

            _ = Assert.Throws<ArgumentOutOfRangeException>(() => {
                curve.RemoveKey(0);
            });

            _ = curve.AddKey(new KeyframeI17F15((I17F15)1, (I17F15)1));
            Utility.AssertAreEqual(1, curve.Length);

            _ = Assert.Throws<ArgumentOutOfRangeException>(() => {
                curve.RemoveKey(-1);
            });

            curve.RemoveKey(0);
            Utility.AssertAreEqual(0, curve.Length);

            _ = Assert.Throws<ArgumentOutOfRangeException>(() => {
                curve.RemoveKey(0);
            });
        }

        [Test]
        public static void TestMoveKeyI17F15() {
            var curve = new AnimationCurveI17F15();

            // AnimationCurveI17F15 はインデックスが不正な場合
            // ArgumentOutOfRangeException をスローする.
            var e = Assert.Throws<ArgumentOutOfRangeException>(() => {
                _ = curve.MoveKey(0, new KeyframeI17F15((I17F15)1, (I17F15)1));
            });

            var i = curve.AddKey(new KeyframeI17F15((I17F15)1, (I17F15)1));
            Utility.AssertAreEqual(0, i);
            Utility.AssertAreEqual(1, curve.Length);
            Utility.AssertAreEqual((I17F15)1, curve[i].Time);
            Utility.AssertAreEqual((I17F15)1, curve[i].Value);
            i = curve.MoveKey(0, new KeyframeI17F15((I17F15)2, (I17F15)2));
            Utility.AssertAreEqual(0, i);
            Utility.AssertAreEqual(1, curve.Length);
            Utility.AssertAreEqual((I17F15)2, curve[i].Time);
            Utility.AssertAreEqual((I17F15)2, curve[i].Value);

            i = curve.AddKey(new KeyframeI17F15((I17F15)3, (I17F15)3));
            Utility.AssertAreEqual(1, i);
            Utility.AssertAreEqual(2, curve.Length);
            Utility.AssertAreEqual((I17F15)2, curve[0].Time);
            Utility.AssertAreEqual((I17F15)2, curve[0].Value);
            Utility.AssertAreEqual((I17F15)3, curve[1].Time);
            Utility.AssertAreEqual((I17F15)3, curve[1].Value);

            i = curve.MoveKey(0, new KeyframeI17F15((I17F15)4, (I17F15)4));
            Utility.AssertAreEqual(1, i);
            Utility.AssertAreEqual(2, curve.Length);
            Utility.AssertAreEqual((I17F15)3, curve[0].Time);
            Utility.AssertAreEqual((I17F15)3, curve[0].Value);
            Utility.AssertAreEqual((I17F15)4, curve[1].Time);
            Utility.AssertAreEqual((I17F15)4, curve[1].Value);

            i = curve.MoveKey(1, new KeyframeI17F15((I17F15)1, (I17F15)1));
            Utility.AssertAreEqual(0, i);
            Utility.AssertAreEqual(2, curve.Length);
            Utility.AssertAreEqual((I17F15)1, curve[0].Time);
            Utility.AssertAreEqual((I17F15)1, curve[0].Value);
            Utility.AssertAreEqual((I17F15)3, curve[1].Time);
            Utility.AssertAreEqual((I17F15)3, curve[1].Value);

            // KeyframeI17F15.Time が既存のキーと重複する場合,
            // 例外をスローせず指定したインデックスのキーを削除し -1 を返す.

            i = curve.MoveKey(0, new KeyframeI17F15((I17F15)3, (I17F15)5));
            Utility.AssertAreEqual(-1, i);
            Utility.AssertAreEqual(1, curve.Length);
            Utility.AssertAreEqual((I17F15)3, curve[0].Time);
            Utility.AssertAreEqual((I17F15)3, curve[0].Value);
        }

        /// <summary>
        /// キー数が 0 または 1 の場合,
        /// それぞれ PreWrapMode, PostWrapMode に関わらず
        /// どこで評価しても 0 またはそのキーの値であることをテスト.
        /// </summary>
        static void TestEvaluateLessThanTwoKeysI17F15(WrapMode preWrapMode, WrapMode postWrapMode, KeyframeI17F15? keyFrame) {
            var randomNumberGenerator = new Xoroshiro128StarStar(1, 2);
            var value = keyFrame.HasValue ? keyFrame.Value.Value : I17F15.Zero;
            var rng = randomNumberGenerator;
            var curve = new AnimationCurveI17F15 {
                PreWrapMode = preWrapMode,
                PostWrapMode = postWrapMode,
            };
            if (keyFrame.HasValue) {
                _ = curve.AddKey(keyFrame.Value);
                Utility.AssertAreEqual(value, curve.Evaluate(keyFrame.Value.Time));
            }
            Utility.AssertAreEqual(value, curve.Evaluate(I17F15.Zero));
            Utility.AssertAreEqual(value, curve.Evaluate(I17F15.One));
            Utility.AssertAreEqual(value, curve.Evaluate(I17F15.NegativeOne));
            for (var i = 0; i < 100; i++) {
                const int k = 1 << 15;
                var randomNumber = I17F15.FromBits(rng.Next(0, 1 + k));
                Utility.AssertAreEqual(value, curve.Evaluate(randomNumber));
                Utility.AssertAreEqual(value, curve.Evaluate(randomNumber + I17F15.One));
                Utility.AssertAreEqual(value, curve.Evaluate(randomNumber - I17F15.One));
            }
        }

        [Test]
        public static void TestEvaluateLessThanTwoKeysI17F15() {
            var values = new I17F15[] {
                I17F15.Zero,
                I17F15.One,
                I17F15.NegativeOne,
            };
            var randomNumberGenerator = new Xoroshiro128StarStar(1, 2);
            foreach (var preWrapMode in wrapModesI17F15) {
                foreach (var postWrapMode in wrapModesI17F15) {
                    // キー無しの場合常に評価値が 0 になることをテスト
                    TestEvaluateLessThanTwoKeysI17F15(preWrapMode, postWrapMode, null);

                    foreach (var v1 in values) {
                        foreach (var v2 in values) {
                            // 時間と値が境界値のキー 1 つの場合
                            // 常に評価値が値と同値になることをテスト
                            TestEvaluateLessThanTwoKeysI17F15(preWrapMode, postWrapMode, new KeyframeI17F15(v1, v2));
                        }

                        var rng = randomNumberGenerator;
                        for (var i = 0; i < 100; i++) {
                            var v2 = I17F15.FromBits(rng.Next(-32768, 32768));

                            // 時間が境界値, 値が乱数のキー 1 つの場合または
                            // 時間が乱数, 値が境界値のキー 1 つの場合
                            // 各々常に評価値が値と同値になることをテスト
                            TestEvaluateLessThanTwoKeysI17F15(preWrapMode, postWrapMode, new KeyframeI17F15(v1, v2));
                            TestEvaluateLessThanTwoKeysI17F15(preWrapMode, postWrapMode, new KeyframeI17F15(v2, v1));
                        }
                    }
                    {
                        // 時間と値が乱数のキー 1 つの場合
                        // 評価値が常に値と同値になることをテスト
                        var rng1 = randomNumberGenerator;
                        for (var i = 10; i < 10; i++) {
                            var rng2 = randomNumberGenerator;
                            var time = I17F15.FromBits(rng1.Next(-32768, 32768));
                            for (var j = 10; j < 10; j++) {
                                var value = I17F15.FromBits(rng2.Next(-32768, 32768));
                                TestEvaluateLessThanTwoKeysI17F15(preWrapMode, postWrapMode, new KeyframeI17F15(time, value));
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
        public static void TestEvaluateTwoKeysI17F15() {
            var curve = new AnimationCurveI17F15();
            _ = curve.AddKey(new KeyframeI17F15((I17F15)1, (I17F15)0, (I17F15)1, (I17F15)1));
            _ = curve.AddKey(new KeyframeI17F15((I17F15)2, (I17F15)1, (I17F15)1, (I17F15)1));

            // 基本的にループ時, [0, 1) の範囲に収まるように評価されることをテスト.
            // また PreWrapMode, PostWrapMode が Default の場合
            // Loop と同じ挙動であることをテスト.
            foreach (var preWrapMode in wrapModesI17F15) {
                curve.PreWrapMode = preWrapMode;
                foreach (var postWrapMode in wrapModesI17F15) {
                    curve.PostWrapMode = postWrapMode;
                    Utility.AssertAreEqual((I17F15)0.000F, curve.Evaluate((I17F15)1.000F));
                    Utility.AssertAreEqual((I17F15)0.125F, curve.Evaluate((I17F15)1.125F));
                    Utility.AssertAreEqual((I17F15)0.875F, curve.Evaluate((I17F15)1.875F));
                    switch (preWrapMode) {
                        default:
                        throw new NotImplementedException(preWrapMode.ToString());

#if false
                        case 0:
#endif
                        case WrapMode.Loop:
                        Utility.AssertAreEqual((I17F15)0.875F, curve.Evaluate((I17F15)(-0.125F)));
                        Utility.AssertAreEqual((I17F15)0.000F, curve.Evaluate((I17F15)(+0.000F)));
                        Utility.AssertAreEqual((I17F15)0.125F, curve.Evaluate((I17F15)(+0.125F)));
                        Utility.AssertAreEqual((I17F15)0.875F, curve.Evaluate((I17F15)(+0.875F)));
                        break;

                        case WrapMode.Clamp:
                        Utility.AssertAreEqual((I17F15)0, curve.Evaluate((I17F15)(-0.125F)));
                        Utility.AssertAreEqual((I17F15)0, curve.Evaluate((I17F15)(+0.000F)));
                        Utility.AssertAreEqual((I17F15)0, curve.Evaluate((I17F15)(+0.125F)));
                        Utility.AssertAreEqual((I17F15)0, curve.Evaluate((I17F15)(+0.875F)));
                        break;
                    }
                    switch (postWrapMode) {
                        default:
                        throw new NotImplementedException(preWrapMode.ToString());

#if false
                        case 0:
#endif
                        case WrapMode.Loop:
                        Utility.AssertAreEqual((I17F15)0.000F, curve.Evaluate((I17F15)2.000F));
                        Utility.AssertAreEqual((I17F15)0.125F, curve.Evaluate((I17F15)2.125F));
                        Utility.AssertAreEqual((I17F15)0.875F, curve.Evaluate((I17F15)2.875F));
                        Utility.AssertAreEqual((I17F15)0.000F, curve.Evaluate((I17F15)3.000F));
                        Utility.AssertAreEqual((I17F15)0.125F, curve.Evaluate((I17F15)3.125F));
                        break;

                        case WrapMode.Clamp:
                        Utility.AssertAreEqual((I17F15)1, curve.Evaluate((I17F15)2.000F));
                        Utility.AssertAreEqual((I17F15)1, curve.Evaluate((I17F15)2.125F));
                        Utility.AssertAreEqual((I17F15)1, curve.Evaluate((I17F15)2.875F));
                        Utility.AssertAreEqual((I17F15)1, curve.Evaluate((I17F15)3.000F));
                        Utility.AssertAreEqual((I17F15)1, curve.Evaluate((I17F15)3.125F));
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 周期長が 0 のカーブのテスト
        /// </summary>
        [Test]
        public static void TestEvaluateZeroDurationI17F15() {
            for (var flag = 0; flag < 1; flag++) {
                I17F15 first, second, third, last;
                if (flag == 0) {
                    first = (I17F15)1;
                    second = (I17F15)4;
                    third = (I17F15)3;
                    last = (I17F15)2;
                } else {
                    first = (I17F15)2;
                    second = (I17F15)3;
                    third = (I17F15)4;
                    last = (I17F15)1;
                }
                var curve = new AnimationCurveI17F15 {
                    Keys = new KeyframeI17F15[] {
                        new KeyframeI17F15((I17F15)1, first),
                        new KeyframeI17F15((I17F15)1, second),
                        new KeyframeI17F15((I17F15)1, third),
                        new KeyframeI17F15((I17F15)1, last),
                    }
                };
                for (var t = 0; t <= 2; t++) {
                    foreach (var pre in wrapModesI17F15) {
                        curve.PreWrapMode = pre;
                        foreach (var post in wrapModesI17F15) {
                            curve.PostWrapMode = post;
                            var time = (I17F15)t;
                            var actual = curve.Evaluate(time);
                            I17F15 expected;
                            if (t == 0) {
                                switch (pre) {
                                    default:
                                    throw new NotImplementedException($"time:{t} preWrapMode:{pre} postWrapMode:{post}");

#if false
                                    case 0:
                                    expected = last;
                                    break;
#endif

                                    case WrapMode.Clamp:
                                    expected = first;
                                    break;

                                    case WrapMode.Loop:
                                    expected = I17F15.Zero;
                                    break;
                                }
                            } else {
                                switch (post) {
                                    default:
                                    throw new NotImplementedException($"time:{t} preWrapMode:{pre} postWrapMode:{post}");

#if false
                                    case 0:
#endif
                                    case WrapMode.Clamp:
                                    expected = last;
                                    break;

                                    case WrapMode.Loop:
                                    expected = first;
                                    break;
                                }
                            }
                            Utility.AssertAreEqual(expected, actual, $"time:{t} preWrapMode:{pre} postWrapMode:{post} expected:{expected} actual:{actual}");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// キーとキーの間の時間が 0 のカーブのテスト
        /// </summary>
        [Test]
        public static void TestEvaluateZeroIntervalI17F15() {
            // キーの時間が同じ場合, 後に追加されたキーの値が評価されることをテスト.
            var curve = new AnimationCurveI17F15 {
                Keys = new KeyframeI17F15[] {
                    new KeyframeI17F15((I17F15)1, (I17F15)1),
                    new KeyframeI17F15((I17F15)1, (I17F15)2),
                    new KeyframeI17F15((I17F15)2, (I17F15)2),
                    new KeyframeI17F15((I17F15)2, (I17F15)3),
                    new KeyframeI17F15((I17F15)3, (I17F15)3),
                    new KeyframeI17F15((I17F15)3, (I17F15)4),
                }
            };
            for (var t = 0; t <= 6; t++) {
                foreach (var pre in wrapModesI17F15) {
                    curve.PreWrapMode = pre;
                    foreach (var post in wrapModesI17F15) {
                        curve.PostWrapMode = post;
                        var actual = curve.Evaluate((I17F15)t);

                        I17F15 expected;
                        switch (t) {
                            default: throw new NotImplementedException($"time:{t} preWrapMode:{pre} postWrapMode:{post}");
                            case 0:
                            switch (pre) {
                                default:
                                throw new NotImplementedException($"time:{t} preWrapMode:{pre} postWrapMode:{post}");

#if false
                                case 0:
#endif
                                case WrapMode.Loop:
                                expected = (I17F15)3;
                                break;

                                case WrapMode.Clamp:
                                expected = (I17F15)1;
                                break;
                            }
                            break;

                            case 1:
                            expected = (I17F15)1;
                            break;
                            case 2:
                            expected = (I17F15)3;
                            break;
                            case 3:
                            switch (post) {
                                default:
                                throw new NotImplementedException($"time:{t} preWrapMode:{pre} postWrapMode:{post}");

#if false
                                case 0:
#endif
                                case WrapMode.Loop:
                                expected = (I17F15)1;
                                break;

                                case WrapMode.Clamp:
                                expected = (I17F15)4;
                                break;
                            }
                            break;

                            case 4:
                            switch (post) {
                                default:
                                throw new NotImplementedException($"time:{t} preWrapMode:{pre} postWrapMode:{post}");

#if false
                                case 0:
#endif
                                case WrapMode.Loop:
                                expected = (I17F15)3;
                                break;

                                case WrapMode.Clamp:
                                expected = (I17F15)4;
                                break;
                            }
                            break;

                            case 5:
                            switch (post) {
                                default:
                                throw new NotImplementedException($"time:{t} preWrapMode:{pre} postWrapMode:{post}");

#if false
                                case 0:
#endif
                                case WrapMode.Loop:
                                expected = (I17F15)1;
                                break;

                                case WrapMode.Clamp:
                                expected = (I17F15)4;
                                break;
                            }
                            break;

                            case 6:
                            switch (post) {
                                default:
                                throw new NotImplementedException($"time:{t} preWrapMode:{pre} postWrapMode:{post}");

#if false
                                case 0:
#endif
                                case WrapMode.Loop:
                                expected = (I17F15)3;
                                break;

                                case WrapMode.Clamp:
                                expected = (I17F15)4;
                                break;
                            }
                            break;
                        }
                        Utility.AssertAreEqual(expected, actual, $"time:{t} preWrapMode:{pre} postWrapMode:{post} expected:{expected} actual:{actual}");
                    }
                }
            }
        }
    }
}
