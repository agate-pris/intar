using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Intar.Tests {
    public partial class AnimationUtilityTest {
        const float defaultWeight = 1.0F / 3;

        /// <summary>安全な除算を行う.</summary>
        /// <param name="defaultValue"><c>x</c> の絶対値がしきい値以下の時に返される値</param>
        /// <param name="threshold">しきい値. デフォルト値は適当なので注意.</param>
        static float SafeDiv(float y, float x, float defaultValue = 0, float threshold = 1e-3F) {
            return Math.Abs(x) > threshold ? y / x : defaultValue;
        }

        /// <summary>2 つのキーの間の傾きを計算する.</summary>
        static float CalculateTangent(Keyframe left, Keyframe right) {
            return SafeDiv(right.value - left.value, right.time - left.time);
        }

        /// <summary><c>TangentMode.Auto</c> に対応する傾きを計算する.</summary>
        /// <returns>キー数が 2 未満の場合は <c>null</c>.</returns>
        static float? CalculateTangentAuto(AnimationCurve curve, int index) {
            if (curve.length < 2) {
                return null;
            } else if (index == 0) {
                // 最初のキーの場合は次のキーとの間の傾きを返す.
                return CalculateTangent(curve[index], curve[index + 1]);
            } else if (index == curve.length - 1) {
                // 最後のキーの場合は前のキーとの間の傾きを返す.
                return CalculateTangent(curve[index - 1], curve[index]);
            } else {
                // それ以外の場合は前後のキーとの間の傾きの平均を返す.
                var left = CalculateTangent(curve[index - 1], curve[index]);
                var right = CalculateTangent(curve[index], curve[index + 1]);
                return (left + right) * 0.5F;
            }
        }

        /// <summary><c>TangentMode.ClampedAuto</c> に対応する傾きを計算する.</summary>
        /// <param name="bias">上界・下界を決定するバイアス値</param>
        /// <returns>キー数が 2 未満の場合は <c>null</c>.</returns>
        static float? CalculateTangentClampedAuto(AnimationCurve curve, int index, float bias = 0.5F) {
            // キー数が 2 未満の場合は計算できない.
            // キーが最初・最後の場合は傾きは 0.
            if (curve.length < 2) {
                return null;
            } else if (index == 0) {
                return 0;
            } else if (index == curve.length - 1) {
                return 0;
            } else {
                var pre = curve[index - 1];
                var nxt = curve[index + 1];
                var cur = curve[index];
                var dx1 = cur.time - pre.time;
                var dx2 = nxt.time - cur.time;
                var dy1 = cur.value - pre.value;
                var dy2 = nxt.value - cur.value;
                var m1 = SafeDiv(dy1, dx1);
                var m2 = SafeDiv(dy2, dx2);

                // 変曲点では 0 を返す.
                if ((0 < m1 && 0 < m2) || (m1 < 0 && m2 < 0)) {
                    // この時点で単調増加または単調減少が保証されているため,
                    // dy, dy1, dy2 の符号は全て同じになる.
                    // -1 <= bias <= 1 の場合 lowerDy, upperDy についても同様.
                    // (後述のコメントは 0 < bias < 1 を前提とするものとする.)
                    var dx = dx1 + dx2;
                    var dy = dy1 + dy2;
                    var m = SafeDiv(dy, dx);
                    var lowerBias = 0.5F - (0.5F * bias);
                    var upperBias = 0.5F + (0.5F * bias);
                    var lowerDy = lowerBias * dy;
                    var upperDy = upperBias * dy;

                    // * |dy1| が極端に大きい場合, 負のバイアスがかかる.
                    // * |dy1| が小さい場合 0 に寄せるバイアスがかかる.
                    if (Math.Abs(dy1) > Math.Abs(upperDy)) {
                        // 1 > bias > 0 (|dy1 - upperDy| < |lowerDy|)
                        //     bias = 0 ( dy1 - upperDy  =  lowerDy )
                        // 0 > bias     (|dy1 - upperDy| > |lowerDy|)
                        dy1 -= upperDy;
                        bias = SafeDiv(dy1, lowerDy);
                        bias = 1 - bias;
                        return bias * m;
                    } else if (Math.Abs(dy1) < Math.Abs(lowerDy)) {
                        // 1 > bias > 0 (|dy1| < |lowerDy|)
                        //     bias = 0 ( dy1  =  0       )
                        bias = SafeDiv(dy1, lowerDy);
                        return bias * m;
                    } else {
                        return m;
                    }
                } else {
                    return 0;
                }
            }
        }

        /// <summary>
        /// <c>AnimationCurve</c> に
        /// <c>AnimationUtility.SetKeyBroken</c>、
        /// <c>AnimationUtility.SetKeyLeftTangentMode</c>
        /// <c>AnimationUtility.SetKeyRightTangentMode</c> を適用した時に
        /// <c>AnimationCurve.inTangent</c>,
        /// <c>AnimationCurve.outTangent</c>,
        /// <c>AnimationCurve.inWeight</c>,
        /// <c>AnimationCurve.outWeight</c> に適用される自動的な変更の内容が期待通りであることを検証する.
        /// </summary>
        /// <param name="curve">適用対象のカーブ</param>
        /// <param name="keys">適用前のキーの値</param>
        static void Test(AnimationCurve curve, Keyframe[] keys) {
            // TangentMode の組み合わせによる期待される動作:
            //
            // | left        | right       | weight      | inTangent   | outTangent
            // | ----------- | ----------- | ----------- | ----------- | ----------
            // | Free        | Free        | Free        | Free        | Free
            // | Free        | Auto        | Auto        | Auto        | Auto
            // | Free        | Linear      | Free        | -           | Linear
            // | Free        | Constant    | Free        | -           | inf
            // | Free        | ClampedAuto | ClampedAuto | ClampedAuto | ClampedAuto
            // | Auto        | Free        | Auto        | Auto        | Auto
            // | Auto        | Auto        | Auto        | Auto        | Auto
            // | Auto        | Linear      | Auto        | Auto        | Auto
            // | Auto        | Constant    | Auto        | Auto        | inf
            // | Auto        | ClampedAuto | ClampedAuto | Auto        | Auto
            // | Linear      | Free        | Free        | Linear      | -
            // | Linear      | Auto        | Auto        | Auto        | Auto
            // | Linear      | Linear      | Free        | Linear      | Linear
            // | Linear      | Constant    | Free        | Linear      | inf
            // | Linear      | ClampedAuto | ClampedAuto | ClampedAuto | ClampedAuto
            // | Constant    | Free        | Free        | inf         | -
            // | Constant    | Auto        | Auto        | inf         | Auto
            // | Constant    | Linear      | Free        | inf         | Linear
            // | Constant    | Constant    | Free        | inf         | inf
            // | Constant    | ClampedAuto | ClampedAuto | inf         | ClampedAuto
            // | ClampedAuto | Free        | ClampedAuto | ClampedAuto | ClampedAuto
            // | ClampedAuto | Auto        | ClampedAuto | Auto        | Auto
            // | ClampedAuto | Linear      | ClampedAuto | ClampedAuto | ClampedAuto
            // | ClampedAuto | Constant    | ClampedAuto | ClampedAuto | inf
            // | ClampedAuto | ClampedAuto | ClampedAuto | ClampedAuto | ClampedAuto
            //
            // `-` は元の値を維持することを意味する.
            // weight, inTangent, outTangent 列はそれぞれ
            // 適用されるアルゴリズムの種別を示している.

            // 各キーについて期待される動作を検証する.
            // ここでは time, value, inTangent, outTangent, inWeight, outWeight の値を確認する.
            // GetKeyBroken, GetKeyLeftTangentMode,
            // GetKeyRightTangentMode の結果の正しさは呼び出し元で確認する.
            for (var i = 0; i < curve.length; i++) {
                // time, value は元の値を維持することを確認する.
                Utility.AssertAreEqual(keys[i].time, curve[i].time);
                Utility.AssertAreEqual(keys[i].value, curve[i].value);

                var l = AnimationUtility.GetKeyLeftTangentMode(curve, i);
                var r = AnimationUtility.GetKeyRightTangentMode(curve, i);
                var eitherAuto =
                    l == AnimationUtility.TangentMode.Auto ||
                    r == AnimationUtility.TangentMode.Auto;
                var eitherClampedAuto =
                    l == AnimationUtility.TangentMode.ClampedAuto ||
                    r == AnimationUtility.TangentMode.ClampedAuto;

                // inWeight, outWeight の値は以下の優先度で分岐する.
                //
                // 1. 何れかが ClampedAuto
                // 2. 何れかが Auto
                // 3. その他
                if (eitherClampedAuto) {
                    // キーが 2 個未満の場合は元のウェイト,
                    // それ以外の場合はデフォルトウェイトに設定される.
                    if (curve.length < 2) {
                        Utility.AssertAreEqual(keys[i].inWeight, curve[i].inWeight);
                        Utility.AssertAreEqual(keys[i].outWeight, curve[i].outWeight);
                    } else {
                        Utility.AssertAreEqual(defaultWeight, curve[i].inWeight);
                        Utility.AssertAreEqual(defaultWeight, curve[i].outWeight);
                    }
                } else if (eitherAuto) {
                    // 最初のキーの inWeight, 最後のキー の outWeight は元の値を維持する.
                    // それ以外のキーの inWeight, outWeight はデフォルト値が設定される.
                    var inWeight = i == 0 ? keys[i].inWeight : defaultWeight;
                    var outWeight = i == curve.length - 1 ? keys[i].outWeight : defaultWeight;
                    Utility.AssertAreEqual(inWeight, curve[i].inWeight);
                    Utility.AssertAreEqual(outWeight, curve[i].outWeight);
                } else {
                    // 元のウェイトを維持する.
                    Utility.AssertAreEqual(keys[i].inWeight, curve[i].inWeight);
                    Utility.AssertAreEqual(keys[i].outWeight, curve[i].outWeight);
                }

                // inTangent, outTangent は以下の優先度で分岐する.
                //
                // 1. 両方 Free
                // 2. Constant
                // 3. 何れかが Auto
                // 4. 何れかが ClampedAuto
                // 5. Linear
                // 6. その他
                if (l == AnimationUtility.TangentMode.Free &&
                    r == AnimationUtility.TangentMode.Free) {
                    // inTangent は元の値を維持する.
                    Utility.AssertAreEqual(keys[i].inTangent, curve[i].inTangent);

                    // outTangent は broken が false の場合 inTangent と同じ値,
                    // それ以外の場合は元の値になる.
                    var broken = AnimationUtility.GetKeyBroken(curve, i);
                    var outTangent = broken ? keys[i].outTangent : keys[i].inTangent;
                    Utility.AssertAreEqual(outTangent, curve[i].outTangent);
                } else {
                    var tangentAuto = eitherAuto ? CalculateTangentAuto(curve, i) : null;
                    float? tangentClampedAuto = null;

                    if (l == AnimationUtility.TangentMode.Constant) {
                        // Constant の場合 inf.
                        Utility.AssertAreEqual(float.PositiveInfinity, curve[i].inTangent);
                    } else if (eitherAuto) {
                        if (tangentAuto.HasValue) {
                            Utility.AssertAreEqual(tangentAuto.Value, curve[i].inTangent, 1e-3F);
                        } else {
                            // キー数が 2 未満の場合, 元の値を維持する.
                            Utility.AssertAreEqual(keys[i].inTangent, curve[i].inTangent);
                        }
                    } else if (eitherClampedAuto) {
                        tangentClampedAuto = CalculateTangentClampedAuto(curve, i);
                        if (tangentClampedAuto.HasValue) {
                            Utility.AssertAreEqual(tangentClampedAuto.Value, curve[i].inTangent, 1e-3F);
                        } else {
                            // キー数が 2 未満の場合, 元の値を維持する.
                            Utility.AssertAreEqual(keys[i].inTangent, curve[i].inTangent);
                        }
                    } else if (l == AnimationUtility.TangentMode.Linear && i != 0) {
                        // Linear の場合は前のキーとの間の傾きを設定する.
                        // 前のキーが存在しない場合は元の値を維持する.
                        Utility.AssertAreEqual(CalculateTangent(curve[i - 1], curve[i]), curve[i].inTangent, 1e-3F);
                    } else {
                        // 元の値を維持する.
                        Utility.AssertAreEqual(keys[i].inTangent, curve[i].inTangent);
                    }

                    // outTangent についても同様.
                    if (r == AnimationUtility.TangentMode.Constant) {
                        Utility.AssertAreEqual(float.PositiveInfinity, curve[i].outTangent);
                    } else if (eitherAuto) {
                        if (tangentAuto.HasValue) {
                            Utility.AssertAreEqual(tangentAuto.Value, curve[i].outTangent, 1e-3F);
                        } else {
                            Utility.AssertAreEqual(keys[i].outTangent, curve[i].outTangent);
                        }
                    } else if (eitherClampedAuto) {
                        tangentClampedAuto ??= CalculateTangentClampedAuto(curve, i);
                        if (tangentClampedAuto.HasValue) {
                            Utility.AssertAreEqual(tangentClampedAuto.Value, curve[i].outTangent, 1e-3F);
                        } else {
                            Utility.AssertAreEqual(keys[i].outTangent, curve[i].outTangent);
                        }
                    } else if (r == AnimationUtility.TangentMode.Linear && i != curve.length - 1) {
                        // Linear の場合は次のキーとの間の傾きを設定する.
                        // 次のキーが存在しない場合は元の値を維持する.
                        Utility.AssertAreEqual(CalculateTangent(curve[i], curve[i + 1]), curve[i].outTangent, 1e-3F);
                    } else {
                        Utility.AssertAreEqual(keys[i].outTangent, curve[i].outTangent);
                    }
                }
            }
        }

        static AnimationCurve CreateRandomCurve(int length, List<AnimationUtility.TangentMode> leftModes, List<AnimationUtility.TangentMode> rightModes, List<bool> brokens) {
            var curve = new AnimationCurve() {
                preWrapMode = AnimationCurveTest.RandomWrapMode(),
                postWrapMode = AnimationCurveTest.RandomWrapMode(),
            };
            for (var i = 0; i < length; i++) {
                var key = AnimationCurveTest.RandomKeyframe(UnityEngine.Random.value + (i * 1.5F));
                _ = curve.AddKey(key);
                {
                    // ランダムに TangentMode, broken を設定する.
                    var l = AnimationCurveTest.RandomTangentMode();
                    var r = AnimationCurveTest.RandomTangentMode();
                    var b = AnimationCurveTest.RandomBool();
                    leftModes?.Add(l);
                    rightModes?.Add(r);
                    brokens?.Add(b);
                    AnimationUtility.SetKeyLeftTangentMode(curve, i, l);
                    AnimationUtility.SetKeyRightTangentMode(curve, i, r);
                    AnimationUtility.SetKeyBroken(curve, i, b);
                }
                {
                    // 副作用を打ち消すために元の値を再設定する.
                    var k = curve[i];
                    k.inTangent = key.inTangent;
                    k.outTangent = key.outTangent;
                    k.inWeight = key.inWeight;
                    k.outWeight = key.outWeight;
                    _ = curve.MoveKey(i, k);
                }
            }
            return curve;
        }

        /// <summary><c>AnimationUtility.SetKeyBroken</c> の副作用を検証する.</summary>
        public static void TestSetKeyBroken(int length) {
            // ランダムなカーブを生成し,
            // SetKeyBroken 呼び出し前に keys の内容を保存する.
            // その後, ランダムに SetKeyBroken を呼び出し,
            // 呼び出し後の内容を検証する.
            var leftModes = new List<AnimationUtility.TangentMode>();
            var rightModes = new List<AnimationUtility.TangentMode>();
            var curve = CreateRandomCurve(length, leftModes, rightModes, null);
            var keys = curve.keys;

            for (var i = 0; i < curve.length; i++) {
                var expected = AnimationCurveTest.RandomBool();
                AnimationUtility.SetKeyBroken(curve, i, expected);
                var actual = AnimationUtility.GetKeyBroken(curve, i);
                if (expected != actual) {
                    Assert.Fail($"SetKeyBroken failed: expected {expected}, actual {actual}");
                }
            }

            for (var i = 0; i < curve.length; i++) {
                var l = AnimationUtility.GetKeyLeftTangentMode(curve, i);
                var r = AnimationUtility.GetKeyRightTangentMode(curve, i);
                if (leftModes[i] != l || rightModes[i] != r) {
                    var message
                        = "SetKeyBroken causes unexpected side effects: "
                        + $"expected: {{ keyLeftTangentMode: {leftModes[i]}, keyRightTangentMode: {rightModes[i]} }}, "
                        + $"actual: {{ keyLeftTangentMode: {l}, keyRightTangentMode: {r} }}";
                    Assert.Fail(message);
                }
            }
            Test(curve, keys);
        }

        [TestCase(1000, 1)]
        [TestCase(9999, 2)]
        [TestCase(9999, 3)]
        [TestCase(9999, 4)]
        [TestCase(9999, 5)]
        public static void TestSetKeyBroken(int testCount, int length) {
            for (var i = 0; i < testCount; i++) {
                TestSetKeyBroken(length);
            }
        }

        /// <summary><c>AnimationUtility.SetKeyLeftTangentMode</c> の副作用を検証する.</summary>
        public static void TestSetKeyLeftTangentMode(int length) {
            var rightModes = new List<AnimationUtility.TangentMode>();
            var brokens = new List<bool>();
            var curve = CreateRandomCurve(length, null, rightModes, brokens);
            var keys = curve.keys;

            for (var i = 0; i < curve.length; i++) {
                var expected = AnimationCurveTest.RandomTangentMode();
                AnimationUtility.SetKeyLeftTangentMode(curve, i, expected);
                var actual = AnimationUtility.GetKeyLeftTangentMode(curve, i);
                if (expected != actual) {
                    Assert.Fail($"SetKeyLeftTangentMode failed: expected {expected}, actual {actual}");
                }

                // Free 以外の場合 broken は true になる.
                brokens[i] |= expected != AnimationUtility.TangentMode.Free;
            }

            for (var i = 0; i < curve.length; i++) {
                var r = AnimationUtility.GetKeyRightTangentMode(curve, i);
                var b = AnimationUtility.GetKeyBroken(curve, i);
                if (rightModes[i] != r || brokens[i] != b) {
                    var message
                        = "SetKeyLeftTangentMode causes unexpected side effects: "
                        + $"expected: {{ keyRightTangentMode: {rightModes[i]}, keyBroken: {brokens[i]} }}, "
                        + $"actual: {{ keyRightTangentMode: {r}, keyBroken: {b} }}";
                    Assert.Fail(message);
                }
            }
            Test(curve, keys);
        }

        [TestCase(1000, 1)]
        [TestCase(9999, 2)]
        [TestCase(9999, 3)]
        [TestCase(9999, 4)]
        [TestCase(9999, 5)]
        public static void TestSetKeyLeftTangentMode(int testCount, int length) {
            for (var i = 0; i < testCount; i++) {
                TestSetKeyLeftTangentMode(length);
            }
        }

        /// <summary><c>AnimationUtility.SetKeyRightTangentMode</c> の副作用を検証する.</summary>
        public static void TestSetKeyRightTangentMode(int length) {
            var leftModes = new List<AnimationUtility.TangentMode>();
            var brokens = new List<bool>();
            var curve = CreateRandomCurve(length, leftModes, null, brokens);
            var keys = curve.keys;

            for (var i = 0; i < curve.length; i++) {
                var expected = AnimationCurveTest.RandomTangentMode();
                AnimationUtility.SetKeyRightTangentMode(curve, i, expected);
                var actual = AnimationUtility.GetKeyRightTangentMode(curve, i);
                if (expected != actual) {
                    Assert.Fail($"SetKeyRightTangentMode failed: expected {expected}, actual {actual}");
                }
                brokens[i] |= expected != AnimationUtility.TangentMode.Free;
            }

            for (var i = 0; i < curve.length; i++) {
                var l = AnimationUtility.GetKeyLeftTangentMode(curve, i);
                var b = AnimationUtility.GetKeyBroken(curve, i);
                if (leftModes[i] != l || brokens[i] != b) {
                    var message
                        = $"SetKeyRightTangentMode causes unexpected side effects: "
                        + $"expected: {{ keyLeftTangentMode: {leftModes[i]}, keyBroken: {brokens[i]} }}, "
                        + $"actual: {{ keyLeftTangentMode: {l}, keyBroken: {b} }}";
                    Assert.Fail(message);
                }
            }
            Test(curve, keys);
        }

        [TestCase(1000, 1)]
        [TestCase(9999, 2)]
        [TestCase(9999, 3)]
        [TestCase(9999, 4)]
        [TestCase(9999, 5)]
        public static void TestSetKeyRightTangentMode(int testCount, int length) {
            for (var i = 0; i < testCount; i++) {
                TestSetKeyRightTangentMode(length);
            }
        }
    }
}
