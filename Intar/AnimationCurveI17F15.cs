using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#if UNITY_5_3_OR_NEWER
using UnityEngine;
#endif

namespace Intar {
#if false // 未実装
    public enum WeightedMode {
        None,
        In,
        Out,
        Both,
    }

    public enum TangentMode {
        Free,
        Auto,
        Linear,
        Constant,
        ClampedAuto,
    }
#endif

    [Serializable]
    public struct KeyframeI17F15 {
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
        public I17F15 Time;
        public I17F15 Value;
        public I17F15 InTangent;
        public I17F15 OutTangent;
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#if false // 未実装
        public WeightedMode WeightedMode;
        public I17F15 InWeight;
        public I17F15 OutWeight;
        public TangentMode TangentMode;
#endif
        public KeyframeI17F15(
            I17F15 time, I17F15 value,
            I17F15 inTangent, I17F15 outTangent
        ) {
            Time = time;
            Value = value;
            InTangent = inTangent;
            OutTangent = outTangent;
        }
    }

    public enum WrapMode {
        Default,
        Clamp,
        Loop,
#if false // 未実装
        PingPong = 4,
        ClampForever = 8,
#endif
        Once = 1,
    }

    [Serializable]
    public class AnimationCurveI17F15 {
        #region keys, Keys, Length, AddKey, MoveKey, RemoveKey, ClearKeys, Indexer
#if UNITY_5_3_OR_NEWER
        [SerializeField]
#endif // UNITY_5_3_OR_NEWER
        List<KeyframeI17F15> keys;
        public KeyframeI17F15[] Keys {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                if (keys == null) {
                    return Array.Empty<KeyframeI17F15>();
                }
                return keys.ToArray();
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                if (value == null || value.Length == 0) {
                    keys = null;
                    return;
                }
                keys = new List<KeyframeI17F15>(value);
            }
        }
        public int Length {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => keys == null ? 0 : keys.Count;
        }
        public void AddKey(KeyframeI17F15 key) {
            if (keys == null) {
                keys = new List<KeyframeI17F15> { key };
                return;
            }

            // key を挿入する位置を探す。
            for (var i = 0; i < keys.Count; i++) {
                if (key.Time < keys[i].Time) {
                    keys.Insert(i, key);
                    return;
                }

                // すでに key が存在する場合は何もしない。
                if (key.Time == keys[i].Time) {
                    return;
                }
            }
            keys.Add(key);
        }
        public void MoveKey(int index, KeyframeI17F15 key) {
            keys[index] = key;
            keys.Sort((a, b) => a.Time.CompareTo(b.Time));
        }
        public void RemoveKey(int index) {
            if (keys == null) {
                return;
            }
            keys.RemoveAt(index);
            if (keys.Count == 0) {
                keys = null;
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClearKeys() => keys = null;
        public KeyframeI17F15 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => keys[index];
        }
        #endregion
        #region PreWrapMode, PostWrapMode
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
        public WrapMode PostWrapMode;
        public WrapMode PreWrapMode;
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
        #endregion
        #region Evaluate
        // 重み付きの場合、ニュートン法で解く必要がある。
        // 現時点では未実装とする。
#if false
        float Evaluate(
            float time,
            float outTangent, float outTime, float outValue, float outWeight,
            float inTangent, float inTime, float inValue, float inWeight
        ) {
            var dt = inTime - outTime;
            var owdt = outWeight * dt;
            var iwdt = inWeight * dt;

            // Bezier control points
            // var x1 = outTime + owdt;
            // var x2 = inTime - iwdt;
            var y1 = outValue + owdt * outTangent;
            var y2 = inValue - iwdt * inTangent;

            // Solve x(t) = time for t (cubic equation)
            // x(t) = (1-t)^3 x0 + 3(1-t)^2 t x1 + 3(1-t) t^2 x2 + t^3 x3
            // var a = x3 - 3 * x2 + 3 * x1 - x0;
            // var b = 3 * x0 - 6 * x1 + 3 * x2;
            // var c = 3 * x1 - 3 * x0;
            // var d = x0 - time;
            float a, b, c, d;
            {
                var tmp = 3 * (dt - owdt - iwdt);
                d = outTime - time;
                c = 3 * owdt;
                b = tmp - c;
                a = dt - tmp;
            }

            // Cubic solver (approximate t using Newton's method or assume t range [0,1])
            var t = (time - outTime) / dt; // Initial guess

            // Newton iterations
            for (int i = 0; i < 5; i++) {
                var xt = a * t * t * t + b * t * t + c * t + d;
                var dxdt = 3 * a * t * t + 2 * b * t + c;
                if (dxdt == 0) break;
                t -= xt / dxdt;
                if (t < 0) t = 0;
                if (t > 1) t = 1;
            }

            // Compute y(t)
            var oneMinusT = 1 - t;
            var oneMinusT2 = oneMinusT * oneMinusT;
            var oneMinusT3 = oneMinusT2 * oneMinusT;
            var t2 = t * t;
            var t3 = t2 * t;

            return oneMinusT3 * outValue + 3 * oneMinusT2 * t * y1 + 3 * oneMinusT * t2 * y2 + t3 * inValue;
        }
#endif
        internal static I17F15 Evaluate(I17F15 time, KeyframeI17F15 left, KeyframeI17F15 right) {
            var dt = right.Time - left.Time;
            if (dt == I17F15.Zero) {
                return right.Value;
            }

            // 正規化時間 (0 <= t <= 1)
            var t = (time - left.Time) / dt;

            var t2 = t * t;
            var t3 = t2 * t;

            var h01 = (t2 * (I17F15)3) - (t3 * (I17F15)2);
            var h00 = I17F15.One - h01;
            var h11 = t3 - t2;
            var h10 = h11 - t2 + t;

            var m0 = left.OutTangent * dt;
            var m1 = right.InTangent * dt;

            return (h00 * left.Value) + (h10 * m0) + (h01 * right.Value) + (h11 * m1);
        }
        public I17F15 Evaluate(I17F15 time) {
            if (keys == null) {
                return I17F15.Zero;
            }

            {
                var length = keys.Count;
                if (length == 0) {
                    return I17F15.Zero;
                }

                var first = keys[0];
                if (length == 1) {
                    return first.Value;
                }
                var last = keys[length - 1];

                // UnityEngine.AnimationCurve では
                // ClampForever は Once と同じ挙動。
                if (PostWrapMode == WrapMode.Clamp && last.Time <= time) {
                    return last.Value;
                } else if (PreWrapMode == WrapMode.Clamp && time <= first.Time) {
                    return first.Value;
                }

                // Default は Loop と同じ挙動。
                // （UnityEngine.AnimationCurve と同じ）

                var duration = last.Time - first.Time;

                // 周期長が 0 の場合 last.Value を返す。
                // それ以外の場合、time が [first.Time, last.Time) の範囲に収まるように調整する。
                if (duration == I17F15.Zero) {
                    return last.Value;
                } else {
                    var fromFirst = time - first.Time;
                    var progress = I17F15.FromBits(fromFirst.Bits % duration.Bits);
                    var negative = progress < I17F15.Zero;
                    time = (negative ? last.Time : first.Time) + progress;
                }
            }

            {
                KeyframeI17F15 key1, key2;
                var i = 0;
                // length > 1 かつ begin <= time < end であるため、
                // keys[i].Time <= time < keys[i + 1].Time となる i が存在する。
                // また time < key[length - 1].Time（end）であるため、
                // i < length - 1 である。
                while (keys[i].Time <= time) {
                    i++;
                }
                key1 = Keys[i - 1];
                key2 = Keys[i];
                return Evaluate(time, key1, key2);
            }
        }
        #endregion

#if UNITY_5_3_OR_NEWER
        public static explicit operator AnimationCurve(AnimationCurveI17F15 a) {
            var curve = new AnimationCurve();
            if (a.keys != null) {
                foreach (var key in a.keys) {
                    _ = curve.AddKey(new Keyframe(
                        (float)key.Time,
                        (float)key.Value,
                        (float)key.InTangent,
                        (float)key.OutTangent
                    ));
                }
            }
            return curve;
        }
#endif

    }
} // namespace Intar
