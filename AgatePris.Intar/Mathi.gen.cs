using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class Mathi {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int AsinInternal(int x) {
            var ret = 391 * x;

            const int k1 = 50762241;
            ret = ((k1 - ret) >> 15) * x;

            const int k2 = 144994038;
            ret = ((k2 - ret) >> 15) * x;

            const int k3 = 1073695665;
            ret = (k3 - ret) >> 15;

            const int k0 = 1 << 15;

            return (int)Sqrt(k0 * (k0 - (uint)x)) * ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Acos(int x) {
            var negate = x < 0;
            var sign = Math.Sign(x);
            x = AsinInternal(negate ? -x : x);
            x = sign * (x - (1 << 30));
            if (x < 0) {
                return (uint)(x + (1 << 30));
            } else {
                return (uint)x + (1 << 30);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Asin(int x) {
            var negate = x < 0;
            var sign = Math.Sign(x);
            x = AsinInternal(negate ? -x : x);
            return sign * ((1 << 30) - x);
        }

        internal static class Atan {
            internal const int One = 1 << 15;
            internal const int OneNeg = -One;
            internal const int Straight = 1 << 30;
            internal const int Right = Straight / 2;
            internal const int RightNeg = -Right;
            internal const int FracK4 = One / 4;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int Inv(int x) {
                const long k = 1L << 31;
                var xl = (long)x;
                return (int)((k + Math.Abs(xl)) / (xl << 1));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int Div(int a, int b) {
                var al = ((long)a) << 16;
                var bl = (long)b;
                return (int)((al + (Math.Sign(a) * Math.Abs(bl))) / (bl << 1));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P2A2850(int x) {
                const int a = 2850;
                var xAbs = Math.Abs(x);
                var tmp = (One - xAbs) * a;
                tmp = FracK4 + (tmp >> 15);
                return x * tmp;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P3A2555B691(int x) {
                const int a = 2555;
                const int b = 691;
                var xAbs = Math.Abs(x);
                var tmp = (xAbs * b) >> 15;
                tmp = (One - xAbs) * (a + tmp);
                tmp = FracK4 + (tmp >> 15);
                return x * tmp;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P5A787B2968(int x) {
                const int a = 787;
                const int b = 2968;
                const int c = (1 << 13) + b - a;
                var x2 = (x * x) >> 15;
                var tmp = (a * x2) >> 15;
                tmp = (b - tmp) * x2;
                tmp = c - (tmp >> 15);
                return tmp * x;
            }
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 2 / 3;
        /// var actual = Intar.Mathi.AtanP2A2850(x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = actual * System.Math.PI / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.003778);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int AtanP2A2850(int x) {
            if (x < Atan.OneNeg) {
                return Atan.RightNeg - Atan.P2A2850(Atan.Inv(x));
            } else if (x > Atan.One) {
                return Atan.Right - Atan.P2A2850(Atan.Inv(x));
            } else {
                return Atan.P2A2850(x);
            }
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var y = 2;
        /// var x = 3;
        /// var actual = Intar.Mathi.Atan2P2A2850(y, x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = actual * System.Math.PI / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.003778);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Atan2P2A2850(int y, int x) {
            if (y < 0) {
                if (x < 0) {
                    return y < x
                        ? Atan.RightNeg - Atan.P2A2850(Atan.Div(x, y))
                        : Atan.P2A2850(Atan.Div(y, x)) - Atan.Straight;
                } else if (x > 0) {
                    return y < -x
                        ? Atan.RightNeg - Atan.P2A2850(Atan.Div(x, y))
                        : Atan.P2A2850(Atan.Div(y, x));
                } else {
                    return Atan.RightNeg;
                }
            } else if (y > 0) {
                if (x < 0) {
                    return -y < x
                        ? Atan.Right - Atan.P2A2850(Atan.Div(x, y))
                        : Atan.Straight + Atan.P2A2850(Atan.Div(y, x));
                } else if (x > 0) {
                    return y > x
                        ? Atan.Right - Atan.P2A2850(Atan.Div(x, y))
                        : Atan.P2A2850(Atan.Div(y, x));
                } else {
                    return Atan.Right;
                }
            } else {
                return x < 0 ? Atan.Straight : 0;
            }
        }

        /// <summary>
        /// 3 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 2 / 3;
        /// var actual = Intar.Mathi.AtanP3A2555B691(x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = actual * System.Math.PI / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.001543);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int AtanP3A2555B691(int x) {
            if (x < Atan.OneNeg) {
                return Atan.RightNeg - Atan.P3A2555B691(Atan.Inv(x));
            } else if (x > Atan.One) {
                return Atan.Right - Atan.P3A2555B691(Atan.Inv(x));
            } else {
                return Atan.P3A2555B691(x);
            }
        }

        /// <summary>
        /// 3 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var y = 2;
        /// var x = 3;
        /// var actual = Intar.Mathi.Atan2P3A2555B691(y, x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = actual * System.Math.PI / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.001543);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Atan2P3A2555B691(int y, int x) {
            if (y < 0) {
                if (x < 0) {
                    return y < x
                        ? Atan.RightNeg - Atan.P3A2555B691(Atan.Div(x, y))
                        : Atan.P3A2555B691(Atan.Div(y, x)) - Atan.Straight;
                } else if (x > 0) {
                    return y < -x
                        ? Atan.RightNeg - Atan.P3A2555B691(Atan.Div(x, y))
                        : Atan.P3A2555B691(Atan.Div(y, x));
                } else {
                    return Atan.RightNeg;
                }
            } else if (y > 0) {
                if (x < 0) {
                    return -y < x
                        ? Atan.Right - Atan.P3A2555B691(Atan.Div(x, y))
                        : Atan.Straight + Atan.P3A2555B691(Atan.Div(y, x));
                } else if (x > 0) {
                    return y > x
                        ? Atan.Right - Atan.P3A2555B691(Atan.Div(x, y))
                        : Atan.P3A2555B691(Atan.Div(y, x));
                } else {
                    return Atan.Right;
                }
            } else {
                return x < 0 ? Atan.Straight : 0;
            }
        }

        /// <summary>
        /// 5 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 2 / 3;
        /// var actual = Intar.Mathi.AtanP5A787B2968(x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = actual * System.Math.PI / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.000767);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int AtanP5A787B2968(int x) {
            if (x < Atan.OneNeg) {
                return Atan.RightNeg - Atan.P5A787B2968(Atan.Inv(x));
            } else if (x > Atan.One) {
                return Atan.Right - Atan.P5A787B2968(Atan.Inv(x));
            } else {
                return Atan.P5A787B2968(x);
            }
        }

        /// <summary>
        /// 5 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var y = 2;
        /// var x = 3;
        /// var actual = Intar.Mathi.Atan2P5A787B2968(y, x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = actual * System.Math.PI / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.000767);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Atan2P5A787B2968(int y, int x) {
            if (y < 0) {
                if (x < 0) {
                    return y < x
                        ? Atan.RightNeg - Atan.P5A787B2968(Atan.Div(x, y))
                        : Atan.P5A787B2968(Atan.Div(y, x)) - Atan.Straight;
                } else if (x > 0) {
                    return y < -x
                        ? Atan.RightNeg - Atan.P5A787B2968(Atan.Div(x, y))
                        : Atan.P5A787B2968(Atan.Div(y, x));
                } else {
                    return Atan.RightNeg;
                }
            } else if (y > 0) {
                if (x < 0) {
                    return -y < x
                        ? Atan.Right - Atan.P5A787B2968(Atan.Div(x, y))
                        : Atan.Straight + Atan.P5A787B2968(Atan.Div(y, x));
                } else if (x > 0) {
                    return y > x
                        ? Atan.Right - Atan.P5A787B2968(Atan.Div(x, y))
                        : Atan.P5A787B2968(Atan.Div(y, x));
                } else {
                    return Atan.Right;
                }
            } else {
                return x < 0 ? Atan.Straight : 0;
            }
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Clamp(int v, int min, int max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Clamp(uint v, uint min, uint max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Clamp(long v, long min, long max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Clamp(ulong v, ulong min, ulong max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Clamp(short v, short min, short max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Clamp(ushort v, ushort min, ushort max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Clamp(byte v, byte min, byte max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Clamp(sbyte v, sbyte min, sbyte max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Half(int x) => x / 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint Half(uint x) => x / 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long Half(long x) => x / 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong Half(ulong x) => x / 2;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Sqrt(uint x) {
            if (x <= 1) {
                return x;
            }

            const int halfBits = sizeof(uint) * 4;
            var k = halfBits - (BitOperations.LeadingZeroCount(x - 1) >> 1);
            var s = 1U << k;
            var t = (s + (x >> k)) >> 1;
            while (t < s) {
                s = t;
                t = (s + (x / s)) >> 1;
            }
            return s;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Sqrt(ulong x) {
            if (x <= 1) {
                return x;
            }

            const int halfBits = sizeof(ulong) * 4;
            var k = halfBits - (BitOperations.LeadingZeroCount(x - 1) >> 1);
            var s = 1UL << k;
            var t = (s + (x >> k)) >> 1;
            while (t < s) {
                s = t;
                t = (s + (x / s)) >> 1;
            }
            return s;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Twice(int x) => x * 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint Twice(uint x) => x * 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long Twice(long x) => x * 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong Twice(ulong x) => x * 2;

    }
}
