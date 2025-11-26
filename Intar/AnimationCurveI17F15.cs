using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;

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
        public KeyframeI17F15(
            I17F15 time, I17F15 value
        ) : this(time, value, I17F15.Zero, I17F15.Zero) { }
    }

    [GenerateTestsForBurstCompatibility]
    public struct AnimationCurveEvaluator {
        internal static I17F15 HermiteInterpolate(I17F15 time,
            KeyframeI17F15 left,
            KeyframeI17F15 right,
            I17F15 defaultValue) {

            // 極端な値が与えられた場合オーバーフローを引き起こすが許容する.

            var dx = right.Time.WideBits - left.Time.WideBits;
            if (dx == 0) {
                return defaultValue;
            }
            var m0 = left.OutTangent.WideBits * dx / I17F15.OneRepr;
            var m1 = right.InTangent.WideBits * dx / I17F15.OneRepr;
            var t = (time.WideBits - left.Time.WideBits) * I17F15.OneRepr / dx;
            return HermiteInterpolate(t, left.Value, m0, m1, right.Value);
        }

        static I17F15 HermiteInterpolate(long t, I17F15 p0, long m0, long m1, I17F15 p1) {
            // 3 次エルミート補間は単位区間 [0, 1] について, t = 0 における始点 p0, t = 1 における
            // 終点 p1, t = 0 における開始接ベクトル m0, t = 1 における終了接ベクトル m1 を
            // 与えられた時, 以下の多項式で表される.
            //
            // p(t) = ( 2 * t^3 - 3 * t^2 + 1) * p0
            //      + (     t^3 - 2 * t^2 + t) * m0
            //      + (-2 * t^3 + 3 * t^2    ) * p1
            //      + (     t^3 -     t^2    ) * m1
            //
            // 誤差を小さくするため以下のように式変形する.
            //
            // p(t)
            // = ( 2 * p0 * t^3 - 3 * p0 * t^2 + p0    )
            // + (     m0 * t^3 - 2 * m0 * t^2 + m0 * t)
            // + (-2 * p1 * t^3 + 3 * p1 * t^2         )
            // + (     m1 * t^3 -     m1 * t^2         )
            // = t * ( 2 * p0 * t^2 - 3 * p0 * t     ) + p0
            // + t * (     m0 * t^2 - 2 * m0 * t + m0)
            // + t * (-2 * p1 * t^2 + 3 * p1 * t     )
            // + t * (     m1 * t^2 -     m1 * t     )
            // = t * (t * ( 2 * p0 * t - 3 * p0)     ) + p0
            // + t * (t * (     m0 * t - 2 * m0) + m0)
            // + t * (t * (-2 * p1 * t + 3 * p1)     )
            // + t * (t * (     m1 * t -     m1)     )
            // = ((t * ( 2 * p0 * t - 3 * p0)     )
            //  + (t * (     m0 * t - 2 * m0) + m0)
            //  + (t * (-2 * p1 * t + 3 * p1)     )
            //  + (t * (     m1 * t -     m1)     )) * t + d (d = p0)
            // = ((2 * p0 * t - 3 * p0
            //   +     m0 * t - 2 * m0
            //   - 2 * p1 * t + 3 * p1
            //   +     m1 * t -     m1) * t + c) * t + d (c = m0, d = p0)
            // = (a * t + b) * t + c) * t + d (a = 2 * p0 + m0 - 2 * p1 + m1
            //                                 b = -3 * p0 - 2 * m0 + 3 * p1 - m1
            //                                 c = m0, d = p0)

            var _2 = (I17F15)2;
            var _3 = (I17F15)3;

            var pd = p1.WideBits - p0.WideBits;

            // 極端な値が与えられた場合オーバーフローを引き起こすが許容する.

            var a = m0 + m1 - (_2.WideBits * pd / I17F15.OneRepr);
            var b = (_3.WideBits * pd / I17F15.OneRepr) - (_2.WideBits * m0 / I17F15.OneRepr) - m1;
            var c = m0;
            var d = p0.WideBits;

            var bits = (t * a / I17F15.OneRepr) + b;
            bits = (t * bits / I17F15.OneRepr) + c;
            bits = (t * bits / I17F15.OneRepr) + d;
            return I17F15.FromBits((int)bits);
        }
    }

    public enum WrapMode {
        Clamp = 1,
        Loop,
        PingPong = 4,
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
            get => keys.ToArray();
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                keys.Clear();
                if (value == null) {
                    return;
                }
                keys.AddRange(value);
                Utility.InsertionSort(keys, (a, b) => a.Time.CompareTo(b.Time));
            }
        }
        public int Length {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => keys.Count;
        }
        public int AddKey(KeyframeI17F15 key) {
            // key を挿入する位置を探す。
            for (var i = 0; i < keys.Count; i++) {
                if (key.Time < keys[i].Time) {
                    keys.Insert(i, key);
                    return i;
                }

                // すでに key が存在する場合は何もしない。
                if (key.Time == keys[i].Time) {
                    return -1;
                }
            }
            keys.Add(key);
            return keys.Count - 1;
        }
        public int MoveKey(int index, KeyframeI17F15 key) {
            RemoveKey(index);
            return AddKey(key);
        }
        public void RemoveKey(int index) {
            keys.RemoveAt(index);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClearKeys() => keys.Clear();
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
        #region LoopTime, PingPongTime
        /// <summary>
        /// ループした時間を計算する.
        /// </summary>
        /// <remarks>
        /// <c>begin</c> と <c>end</c> が同値の場合 <c>null</c> を返す.
        /// <c>AddKey</c> は <c>Time</c> が同値の場合ただその操作を無視するため,
        /// <c>begin</c> と <c>end</c> が同値になることはない.
        /// (キー数が 1 つになるか否かによって判別できる.)
        /// </remarks>
        internal static I17F15? LoopTime(I17F15 begin, I17F15 end, I17F15 time) {
            var duration = end - begin;

            // 周期長が 0 の場合 null を返す.
            if (duration == I17F15.Zero) {
                return null;
            }

            // time が [begin, end) の範囲に収まるように調整する.
            return begin + Utility.FlooredRem(time - begin, duration);
        }
        internal static I17F15? PingPongTime(I17F15 begin, I17F15 end, I17F15 time) {
            var halfDuration = end - begin;

            // 周期長が 0 の場合 null を返す.
            if (halfDuration == I17F15.Zero) {
                return null;
            }
            var duration = I17F15.FromBits(2 * halfDuration.Bits);

            // time が [begin, end] の範囲に収まるように調整する.
            time = Utility.TruncatedRem(time - begin, duration).Abs();
            time = 0 == time.Bits / halfDuration.Bits
                ? time
                : duration - time;
            return begin + time;
        }
        #endregion
        #region FindKey
        internal int FindKey(I17F15 time) {
            var i = 0;
            var c = keys == null ? 0 : keys.Count;
            for (; i < c; i++) {
                if (time < keys[i].Time) {
                    break;
                }
            }
            return i;
        }
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
        public I17F15 Evaluate(I17F15 time) {
            switch (keys.Count) {
                default: break;
                case 0: return I17F15.Zero;
                case 1: return keys[0].Value;
            }

            var first = keys[0];
            var last = keys[keys.Count - 1];

            if (last.Time <= time) {
                switch (PostWrapMode) {
                    default: throw new NotImplementedException($"{PostWrapMode}");
#if false
                    case 0: {
                        // 周期長が 0 の場合, 最後の値を返す.
                        // それ以外の場合 Loop と同様.
                        // (UnityEngine.AnimationCurve 準拠)
                        var t = LoopTime(first.Time, last.Time, time);
                        if (!t.HasValue) {
                            return last.Value;
                        }
                        time = t.Value;
                        break;
                    }
#endif
                    case WrapMode.Clamp: return last.Value;
                    case WrapMode.Loop: {
                        // 周期長が 0 の場合, 最初の値を返す.
                        // (UnityEngine.AnimationCurve 準拠)
                        var t = LoopTime(first.Time, last.Time, time);
                        if (!t.HasValue) {
                            return first.Value;
                        }
                        time = t.Value;
                        break;
                    }
                    case WrapMode.PingPong: {
                        // 周期長が 0 の場合, 最後の値を返す.
                        // (UnityEngine.AnimationCurve 準拠)
                        var t = PingPongTime(first.Time, last.Time, time);
                        if (!t.HasValue) {
                            return last.Value;
                        }
                        time = t.Value;
                        break;
                    }
                }
            } else if (time <= first.Time) {
                // 周期長が 0 の場合, 最初の if 節と,
                // この else if 節の両方の条件を満たす場合,
                // 必ず if 節の中で早期リターンするため,
                // この else if 節を if 節にする必要はない.
                // もし if 節にした場合, 条件式を評価するコストが増える.

                switch (PreWrapMode) {
                    default: throw new NotImplementedException($"{PreWrapMode}");
#if false
                    case 0: {
                        // 周期長が 0 の場合, 最後の値を返す.
                        // それ以外の場合 Loop と同様.
                        // (UnityEngine.AnimationCurve 準拠)
                        var t = LoopTime(first.Time, last.Time, time);
                        if (!t.HasValue) {
                            return last.Value;
                        }
                        time = t.Value;
                        break;
                    }
#endif
                    case WrapMode.Clamp: return first.Value;
                    case WrapMode.Loop: {
                        // 周期長が 0 の場合 I17F15.Zero を返す.
                        // (UnityEngine.AnimationCurve は NaN を返す.)
                        var t = LoopTime(first.Time, last.Time, time);
                        if (!t.HasValue) {
                            return I17F15.Zero;
                        }
                        time = t.Value;
                        break;
                    }
                    case WrapMode.PingPong: {
                        // 周期長が 0 の場合, 最後の値を返す.
                        // (UnityEngine.AnimationCurve 準拠)
                        var t = PingPongTime(first.Time, last.Time, time);
                        if (!t.HasValue) {
                            return last.Value;
                        }
                        time = t.Value;
                        break;
                    }
                }
            }

            // first.Time < time の場合のみ補間処理を行う.
            if (time <= first.Time) {
                return first.Value;
            }

            {
                var i = FindKey(time);
                if (i == keys.Count) {
                    return last.Value;
                } else {
                    return AnimationCurveEvaluator.HermiteInterpolate(time,
                        keys[i - 1],
                        keys[i],
                        keys[i].Value);
                }
            }
        }
        #endregion
        #region Constructor
        public AnimationCurveI17F15() {
            PreWrapMode = WrapMode.Clamp;
            PostWrapMode = WrapMode.Clamp;
            keys = new List<KeyframeI17F15>();
        }
        #endregion
        #region Conversion
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
        #endregion
    }
} // namespace Intar
