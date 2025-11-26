using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#if UNITY_2020_3_OR_NEWER
using Unity.Collections;
#endif

#if UNITY_5_3_OR_NEWER
using UnityEngine;
using Unity.Mathematics;
#endif

namespace Intar {
    public enum WeightedMode {
        None,
        In,
        Out,
        Both,
    }

#if false // 未実装
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
        public WeightedMode WeightedMode;
        public I17F15 InWeight;
        public I17F15 OutWeight;
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#if false // 未実装
        public TangentMode TangentMode;
#endif
        public KeyframeI17F15(
            I17F15 time, I17F15 value,
            I17F15 inTangent, I17F15 outTangent,
            I17F15 inWeight, I17F15 outWeight
        ) {
            Time = time;
            Value = value;
            InTangent = inTangent;
            OutTangent = outTangent;
            InWeight = inWeight;
            OutWeight = outWeight;
            WeightedMode = WeightedMode.Both;
        }
        public KeyframeI17F15(
            I17F15 time, I17F15 value,
            I17F15 inTangent, I17F15 outTangent
        ) {
            Time = time;
            Value = value;
            InTangent = inTangent;
            OutTangent = outTangent;
            InWeight = I17F15.Zero;
            OutWeight = I17F15.Zero;
            WeightedMode = WeightedMode.None;
        }
        public KeyframeI17F15(
            I17F15 time, I17F15 value
        ) : this(time, value, I17F15.Zero, I17F15.Zero) { }
    }

#if UNITY_2022_2_OR_NEWER
    [GenerateTestsForBurstCompatibility]
#elif UNITY_2020_3_OR_NEWER
    [BurstCompatible]
#endif
    public struct AnimationCurveEvaluator {
        static long Mul(long a, long b) => a * b / I17F15.OneRepr;
        static long Div(long a, long b) => a * I17F15.OneRepr / b;

#if true
        static long Cbrt(long x) {
            if (x < 0) {
                return (long)(-math.exp(math.log(-x / 32768.0F) / 3.0f) * 32768);
            } else {
                return (long)(math.exp(math.log(x / 32768.0F) / 3.0f) * 32768);
            }
        }
        static ulong CbrtPositive(ulong x) {
            return (ulong)(Math.Exp(Math.Log((double)x / 32768) / 3) * 32768);
        }
#endif

        internal static I17F15 HermiteInterpolate(I17F15 time,
            KeyframeI17F15 left,
            KeyframeI17F15 right,
            I17F15 defaultValue) {

            if (left.Time == right.Time) {
                return defaultValue;
            }
            var dx = right.Time.WideBits - left.Time.Bits;

            var m0 = Mul(left.OutTangent.Bits, dx);
            var m1 = Mul(right.InTangent.Bits, dx);
            var t = Div(time.WideBits - left.Time.Bits, dx);

            // 極端な値が与えられた場合オーバーフローを引き起こすが許容する.
            return HermiteInterpolate(t, left.Value.Bits, m0, m1, right.Value.Bits);
        }

        static I17F15 HermiteInterpolate(long t, long p0, long m0, long m1, long p1) {
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
            // p(t) = t * (t * (t * a + b) + c) + d とるすと a, b, c, d は以下のようになる.
            //
            // a = m0 + m1 -  2 * (p1 - p0)
            // b = 3 * (p1 - p0) - 2 * m0 - m1
            // c = m0
            // d = p0

            var pd = p1 - p0;

            var a = m0 + m1 - (2 * pd);
            var b = (3 * pd) - (2 * m0) - m1;

            // 極端な値が与えられた場合オーバーフローを引き起こすが許容する.

            var bits = Mul(t, a) + b;
            bits = Mul(t, bits) + m0;
            bits = Mul(t, bits) + p0;
            return I17F15.FromBits((int)bits);
        }

        internal static I17F15 BezierInterpolate(I17F15 time,
            KeyframeI17F15 left,
            KeyframeI17F15 right,
            I17F15 defaultValue) {
            if (left.Time == right.Time) {
                return defaultValue;
            }
            var dx = right.Time.WideBits - left.Time.Bits;
            var t = Div(time.WideBits - left.Time.Bits, dx);
            var m1 = Mul(left.OutTangent.Bits, dx);
            var m2 = Mul(right.InTangent.Bits, dx);
            long outWeight;
            long inWeight;
            if (left.WeightedMode == WeightedMode.None &&
                left.WeightedMode == WeightedMode.In) {
                outWeight = I17F15.OneRepr / 3;
            } else {
                outWeight = left.OutWeight.Bits;
            }
            if (right.WeightedMode == WeightedMode.None &&
                right.WeightedMode == WeightedMode.Out) {
                inWeight = I17F15.OneRepr / 3;
            } else {
                inWeight = right.InWeight.Bits;
            }
            return BezierInterpolate(t, left.Value.Bits, m1, outWeight, right.Value.Bits, m2, inWeight);
        }

#if true
        internal static float FAST_CBRT_POSITIVE(float x) {
            return math.exp(math.log(x) / 3.0f);
        }

        static float FAST_CBRT(float x) {
            return (x < 0) ? -math.exp(math.log(-x) / 3.0f) : math.exp(math.log(x) / 3.0f);
        }

        static float BezierExtractU(float t, float w1, float w2) {
            var a = (3.0F * w1) - (3.0F * w2) + 1.0F;
            var b = (-6.0F * w1) + (3.0F * w2);
            var c = 3.0F * w1;
            var d = -t;

            if (math.abs(a) > 1e-3f) {
                Debug.Log("float1");
                var p = -b / (3.0F * a);
                var p2 = p * p;
                var p3 = p2 * p;

                var q = p3 + (((b * c) - (3.0F * a * d)) / (6.0F * a * a));
                var q2 = q * q;

                var r = c / (3.0F * a);
                var rmp2 = r - p2;

                var s = q2 + (rmp2 * rmp2 * rmp2);

                if (s < 0.0F) {
                    Debug.Log("float2");
                    var ssi = math.sqrt(-s);
                    var r_1 = math.sqrt(-s + q2);
                    var phi = math.atan2(ssi, q);

                    var r_3 = FAST_CBRT_POSITIVE(r_1);
                    var phi_3 = phi / 3.0F;

                    // Extract cubic roots.
                    var u1 = (2.0F * r_3 * math.cos(phi_3)) + p;
                    var u2 = (2.0F * r_3 * math.cos(phi_3 + (2.0F * math.PI / 3.0f))) + p;
                    var u3 = (2.0F * r_3 * math.cos(phi_3 - (2.0F * math.PI / 3.0f))) + p;

                    if (u1 >= 0.0F && u1 <= 1.0F) {
                        Debug.Log("float3");
                        return u1;
                    } else if (u2 >= 0.0F && u2 <= 1.0F) {
                        Debug.Log("float4");
                        return u2;
                    } else if (u3 >= 0.0F && u3 <= 1.0F) {
                        Debug.Log("float5");
                        return u3;
                    }

                    // Aiming at solving numerical imprecisions when u is outside [0,1].
                    Debug.Log("float6");
                    return (t < 0.5F) ? 0.0F : 1.0F;
                } else {
                    Debug.Log("float7");
                    var ss = math.sqrt(s);
                    var u = FAST_CBRT(q + ss) + FAST_CBRT(q - ss) + p;

                    if (u >= 0.0F && u <= 1.0F) {
                        Debug.Log($"float8 {u}");
                        return u;
                    }

                    // Aiming at solving numerical imprecisions when u is outside [0,1].
                    Debug.Log("float9");
                    return (t < 0.5F) ? 0.0F : 1.0F;
                }
            }

            if (math.abs(b) > 1e-3f) {
                Debug.Log("float10");
                var s = (c * c) - (4.0F * b * d);
                var ss = math.sqrt(s);

                var u1 = (-c - ss) / (2.0F * b);
                var u2 = (-c + ss) / (2.0F * b);

                if (u1 >= 0.0F && u1 <= 1.0F) {
                    Debug.Log("float11");
                    return u1;
                } else if (u2 >= 0.0F && u2 <= 1.0F) {
                    Debug.Log("float12");
                    return u2;
                }

                // Aiming at solving numerical imprecisions when u is outside [0,1].
                Debug.Log("float13");
                return (t < 0.5F) ? 0.0F : 1.0F;
            }

            if (math.abs(c) > 1e-3f) {
                Debug.Log("float14");
                return -d / c;
            }

            Debug.Log("float15");
            return 0.0F;
        }
#endif

        static I17F15 BezierInterpolate(long t, long v1, long m1, long w1, long v2, long m2, long w2) {
            var u = BezierExtractU(t, w1, I17F15.OneRepr - w2);
            Debug.Log($"u:{u}");
#if true
            {
                var uFloat = BezierExtractU((float)t / 32768, w1, 1.0F - w2);
                Assert.AreEqual(uFloat, u, Math.Abs(uFloat) * 0.1);
            }
#endif
            var p1 = v1 + Mul(w1, m1);
            var p2 = v2 - Mul(w2, m2);
            return BezierInterpolate(u, v1, p1, p2, v2);
        }

        static I17F15 BezierInterpolate(long t, long p0, long p1, long p2, long p3) {
            // p(t) = t * (t * (t * a + b) + c) + d
            //      =           (1 - t)^3 * p0
            //      + 3 * t   * (1 - t)^2 * p1
            //      + 3 * t^2 * (1 - t)   * p2
            //      +     t^3             * p3
            //
            // (1 - t)^2 = 1 - 2t +  t^2
            // (1 - t)^3 = 1 - 3t + 3t^2 - t^3
            //
            // p(t) =           (1 - 3t + 3 * t^2 - t^3) * p0
            //      + 3 * t   * (1 - 2t +     t^2      ) * p1
            //      + 3 * t^2 * (1 -  t                ) * p2
            //      +     t^3                            * p3
            //      = (1 - 3t + 3 * t^2 -     t^3) * p0
            //      + (    3t - 6 * t^2 + 3 * t^3) * p1
            //      + (         3 * t^2 - 3 * t^3) * p2
            //      +                         t^3  * p3
            //
            // a = 3 * p1 - 3 * p2 + p3 - p0
            // b = 3 * p0 - 6 * p1 + 3 * p2
            // c = 3 * p1 - 3 * p0
            // d = p0

            var _3p0 = 3 * p0;
            var _3p1 = 3 * p1;
            var _3p2 = 3 * p2;
            var c = _3p1 - _3p0;
            var b = _3p0 - (6 * p1) + _3p2;
            var a = _3p1 - _3p2 + p3 - p0;

            var bits = Mul(a, t) + b;
            bits = Mul(bits, t) + c;
            bits = Mul(bits, t) + p0;
            return I17F15.FromBits((int)bits);
        }

        // カルダノの方法に基づいて三次方程式の解の公式で解の個数を求め,
        // それに基づいて値を決定している.
        static long BezierExtractU(long t, long w1, long w2) {
            // time(u) =           (1 - u)^3 * 0
            //         + 3 * u   * (1 - u)^2 * w1
            //         + 3 * u^2 * (1 - u)   * (1 - w2)
            //         +     u^3             * 1
            // (w2 = 1 - w2 として扱う)
            //
            // time(u) = a * u^3 + b * u^2 + c * u + d とする.
            //
            // すると 3 次の項 a が十分に小さい場合は 2 次方程式,
            // 2 次の項 b も十分に小さい場合は 1 次方程式として扱えることが分かる.

            //  0 <= w1 <= 1
            //  0 <= w2 <= 1
            // -2 <= a  <= 4
            // -6 <= b  <= 3
            //  0 <= c  <= 3
            // -1 <= d  <= 0

            var a = (3 * w1) - (3 * w2) + I17F15.OneRepr;
            var b = (3 * w2) - (6 * w1);
            var c = 3 * w1;
            var d = -t;

            var aFloat = (((3.0F * w1) - (3.0F * w2)) / 32768) + 1;
            var bFloat = ((-6.0F * w1) + (3.0F * w2)) / 32768;
            var cFloat = 3.0F * w1 / 32768;
            var dFloat = -t / 32768F;
            Assert.AreEqual(aFloat, a / 32768.0F, 1e-5f);
            Assert.AreEqual(bFloat, b / 32768.0F, 1e-5f);
            Assert.AreEqual(cFloat, c / 32768.0F, 1e-5f);
            Assert.AreEqual(dFloat, d / 32768.0F, 1e-5f);

            Debug.Log($"a:{a / 32768.0F} b:{b / 32768F} c:{c / 32768F} d:{d / 32768F}");

            // 1e-3f approx 32 in I17F15 (32/32768 approx 0.001)
            var epsilon = 32;

            if (Math.Abs(a) > epsilon) {
                Debug.Log("Foo");
#if false
                throw new NotImplementedException();
#else
                // カルダノの方法による解の公式の
                // ビエトの解を用いて 3 次方程式を変形する.
                //
                // (x / a)^3 = 3 * x / a + b / a とすると
                // x / a - 2 cos a すなわち x = 2a cos a ならば
                // cos 3a = b / (2 * a)
                // a = 1/3 * arccos(b / (2 * a)) と表せる.
                // x = 2 a cos a = 2 a cos(1/3 * arccos(b / (2 * a)))
                // という解が得られる. この解のことをビエトの解という.
                //
                // D = - (4 * (-3)^3 + 27 * (-b / a)^2) = 27 * (4 - (b / a)^2) > 0
                // => |b / (2 * a)| < 1
                //
                // 0 < a < pi / 3 なる解 a を a1 とすると
                // a2= a1 + 2pi/3, a3 = a1 + 4pi/3 となる.

                //     -b
                // p = --
                //     3a
                // -inf <= p <= inf (-6 / 0.003 <= p <= 3 / 0.003)

                var p = Div(-b, 3 * a);
                var p2 = Mul(p, p);
                var p3 = Mul(p2, p);

                var pFloat = -bFloat / (3 * aFloat);
                var p2Float = pFloat * pFloat;
                var p3Float = p2Float * pFloat;
                Assert.AreEqual(pFloat, p / 32768.0F, Math.Abs(pFloat) * 0.1);
                Assert.AreEqual(p2Float, p2 / 32768.0F, Math.Abs(p2Float) * 0.1);
                Assert.AreEqual(p3Float, p3 / 32768.0F, Math.Abs(p3Float) * 0.1);

                //           b c - 3 a d
                // q = p^3 + -----------
                //              6 a^2
                //     b c - 3 a d      b^3
                //   = ----------- - ------
                //        6 a^2      27 a^3

                var q = p3 + (((b * c) - (3 * a * d)) / (6 * Mul(a, a)));
                var q2 = Mul(q, q);

                var qFloat = p3Float + (((bFloat * cFloat) - (3 * aFloat * dFloat)) / (6 * aFloat * aFloat));
                var q2Float = qFloat * qFloat;
                Assert.AreEqual(qFloat, q / 32768.0F, Math.Abs(qFloat) * 0.1);
                Assert.AreEqual(q2Float, q2 / 32768.0F, Math.Abs(q2Float) * 0.1);

                //      c
                // r = --
                //     3a

                var r = Div(c, 3 * a);
                var rmp2 = r - p2;

                var rFloat = cFloat / (3 * aFloat);
                var rmp2Float = rFloat - p2Float;
                Assert.AreEqual(rFloat, r / 32768.0F, 1e-3f);

                // s = q^2 + (r - p^2)^3
                //     (b c - 3 a d)     ( c     b^2 )
                //   = (-----------)^2 + (--- - -----)^3
                //     (   6 a^2   )     (3 a   9 a^2)

                long s30;
                //long s;
                {
                    var tmp1 = (b * c) - (3 * a * d);
                    var tmp2 = 6 * a * a / I17F15.OneRepr;
                    var tmp3 = tmp1 / tmp2;
                    tmp3 *= tmp3;
                    tmp1 = b * b;
                    tmp2 = 9 * a * a / I17F15.OneRepr;
                    var tmp4 = (c * 32768 / (3 * a)) - (tmp1 / tmp2);
                    tmp4 *= Mul(tmp4, tmp4);
                    s30 = tmp3 + tmp4;
                }

                var sFloat = q2Float + (rmp2Float * rmp2Float * rmp2Float);
                //Assert.AreEqual(sFloat, s / 32768.0F, 1e-1f);

                if (s30 < 0) {
                    Debug.Log("Bar");
                    var ssi = Mathi.Sqrt(Mathi.UnsignedAbs(s30));
                    var r_1 = Mathi.Sqrt(Mathi.UnsignedAbs(s30) + (ulong)(q * q));
                    var phi = Mathi.Atan2P3((int)ssi, (int)q); // Returns ratio to PI/2

                    var ssiFloat = math.sqrt(-sFloat);
                    var r_1Float = math.sqrt(-sFloat + q2Float);
                    var phiFloat = math.atan2(ssiFloat, qFloat);
                    Assert.AreEqual(ssiFloat, ssi / 32768.0F, ssiFloat * 0.01);
                    Assert.AreEqual(r_1Float, r_1 / 32768.0F, r_1Float * 0.01);
                    Assert.AreEqual(phiFloat / math.PI, phi / (float)(1 << 30), 1e-2f);

                    var r_3 = CbrtPositive(r_1);
                    var phi_3 = phi / (3 * (1 << 14));

                    var r_3Float = FAST_CBRT_POSITIVE(r_1Float);
                    var phi_3Float = phiFloat / 3;
                    Assert.AreEqual(r_3Float, r_3 / 32768.0F, 1e-3f);
                    Assert.AreEqual(phi_3Float / math.PI * 2, phi_3 / 32768.0F, 1e-3f);

                    // Extract cubic roots.
                    // CosP5 takes ratio to PI/2.
                    // 2PI/3 radians is 4/3 in ratio units.
                    var offset = I17F15.OneRepr * 4 / 3;
                    //var _2 = (I17F15)2;

                    var cos1 = Mathi.CosP5(phi_3);
                    var cos2 = Mathi.CosP5(phi_3 + offset);
                    var cos3 = Mathi.CosP5(phi_3 - offset);

                    var cos1Float = math.cos(phi_3Float);
                    var cos2Float = math.cos(phi_3Float + (2 * math.PI / 3.0f));
                    var cos3Float = math.cos(phi_3Float - (2 * math.PI / 3.0f));
                    Assert.AreEqual(cos1Float, cos1 / (float)(1 << 30), 1e-2f);
                    Assert.AreEqual(cos2Float, cos2 / (float)(1 << 30), 1e-2f);
                    Assert.AreEqual(cos3Float, cos3 / (float)(1 << 30), 1e-2f);

                    var u1 = (cos1 / I17F15.OneRepr * (long)r_3 * 2) + (p * 32768);
                    var u2 = (cos2 / I17F15.OneRepr * (long)r_3 * 2) + (p * 32768);
                    var u3 = (cos3 / I17F15.OneRepr * (long)r_3 * 2) + (p * 32768);

                    var u1Float = (2 * r_3Float * cos1Float) + pFloat;
                    var u2Float = (2 * r_3Float * cos2Float) + pFloat;
                    var u3Float = (2 * r_3Float * cos3Float) + pFloat;

                    Assert.AreEqual(u1Float, u1 / 32768.0F, 1e-2f);
                    Assert.AreEqual(u2Float, u2 / 32768.0F, 1e-2f);
                    Assert.AreEqual(u3Float, u3 / 32768.0F, 1e-2f);

                    Debug.Log($"{u1Float} {u2Float} {u3Float}");

                    if (u1 >= 0 && u1 <= (1 << 30)) {
                        Debug.Log("aaa");
                        return u1 / 32768;
                    } else if (u2 >= 0 && u2 <= (1 << 30)) {
                        Debug.Log("bbb");
                        return u2 / 32768;
                    } else if (u3 >= 0 && u3 <= (1 << 30)) {
                        Debug.Log("ccc");
                        return u3 / 32768;
                    }

                    Debug.Log("ddd");
                    return (t < I17F15.OneRepr / 2) ? 0 : I17F15.OneRepr;
                } else {
                    var ss = (long)Mathi.Sqrt((ulong)s30);

                    var ssFloat = math.sqrt(sFloat);
                    Assert.AreEqual(ssFloat, ss / 32768.0F, 1e-2f);

                    long u;
                    {
                        var tmp1 = Cbrt(q + ss);
                        var tmp2 = Cbrt(q - ss);
                        u = tmp1 + tmp2 + p;

                        var tmp1Float = FAST_CBRT(qFloat + ssFloat);
                        var tmp2Float = FAST_CBRT(qFloat - ssFloat);
                        Assert.AreEqual(tmp1Float, tmp1 / 32768.0F, 1e-1f);
                        Assert.AreEqual(tmp2Float, tmp2 / 32768.0F, 1e-1f);
                    }

                    var uFloat = FAST_CBRT(qFloat + ssFloat) + FAST_CBRT(qFloat - ssFloat) + pFloat;
                    Assert.AreEqual(uFloat, u / 32768.0F, 1e-1f);

                    if (u >= 0 && u <= I17F15.OneRepr) {
                        Debug.Log($"Baz {uFloat} {u} {u / 32768.0F}");
                        return u;
                    }

                    Debug.Log("Qux");
                    return (t < I17F15.OneRepr / 2) ? 0 : I17F15.OneRepr;
                }
#endif
            }

            if (Math.Abs(b) > epsilon) {
                var s = (c * c) - (4 * b * d);

                var sFloat = (cFloat * cFloat) - (4.0F * bFloat * dFloat);
                Assert.AreEqual(sFloat, s / 32768.0F, 1e-3f);

                // ここ本当にキャストして大丈夫？
                var ss = (long)Mathi.Sqrt((ulong)s);

                var ssFloat = math.sqrt(sFloat);
                Assert.AreEqual(ssFloat, ss / 32768.0F, 1e-3f);

                var u1 = Div(-c - ss, 2 * b);
                var u2 = Div(-c + ss, 2 * b);

                var u1Float = (-cFloat - ssFloat) / (2.0F * bFloat);
                var u2Float = (-cFloat + ssFloat) / (2.0F * bFloat);
                Assert.AreEqual(u1Float, u1 / 32768.0F, 1e-3f);
                Assert.AreEqual(u2Float, u2 / 32768.0F, 1e-3f);

                if (u1 >= 0 && u1 <= I17F15.OneRepr) {
                    return u1;
                } else if (u2 >= 0 && u2 <= I17F15.OneRepr) {
                    return u2;
                }

                return (t < I17F15.OneRepr / 2) ? 0 : I17F15.OneRepr;
            }

            if (Math.Abs(c) > epsilon) {
                return Div(-d, c);
            }

            return 0;
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
                    var l = keys[i - 1];
                    var r = keys[i];
                    bool isHermite;
                    switch (l.WeightedMode) {
                        default:
                        throw new NotImplementedException($"{l.WeightedMode}");
                        case WeightedMode.None:
                        case WeightedMode.In:
                        switch (r.WeightedMode) {
                            default:
                            throw new NotImplementedException($"{r.WeightedMode}");
                            case WeightedMode.None:
                            case WeightedMode.Out:
                            isHermite = true;
                            break;
                            case WeightedMode.In:
                            case WeightedMode.Both:
                            isHermite = false;
                            break;
                        }
                        break;
                        case WeightedMode.Out:
                        case WeightedMode.Both:
                        isHermite = false;
                        break;
                    }
                    if (isHermite) {
                        return AnimationCurveEvaluator.HermiteInterpolate(time, l, r, r.Value);
                    } else {
                        return AnimationCurveEvaluator.BezierInterpolate(time, l, r, r.Value);
                    }
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
