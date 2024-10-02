using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static class Mathi {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int AsinInternal(int x) {
            // (2^15) / (0.5 * PI) * 0.0187293
            // = 390.707370478933
            var ret = 391 * x;

            // (2^30) / (0.5 * PI) * 0.074261
            // = 50762240.9295814
            const int k1 = 50762241;
            ret = ((k1 - ret) >> 15) * x;

            // (2^30) / (0.5 * PI) * 0.2121144
            // = 144994038.289729
            const int k2 = 144994038;
            ret = ((k2 - ret) >> 15) * x;

            // (2^30) / (0.5 * PI) * 1.5707288
            // = 1073695665.02784
            const int k3 = 1073695665;
            ret = (k3 - ret) >> 15;

            const int k0 = 1 << 15;

            return (int)Sqrt(k0 * (k0 - (uint)x)) * ret;
        }

        /// <summary>
        /// 逆余弦を近似する｡
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とする余弦</param>
        /// <returns>0 以上 π 以下の､ π を 2 の 30 乗で表した角度｡</returns>
        /// <remarks>
        /// <para>以下の式に基づいて近似する｡</para>
        /// <div class="math"></div>
        /// <para>\[0\le x\le1\]</para>
        /// <para>
        /// \[arcsin\ x =
        /// \frac{\pi}{2} -
        /// \left(1 - x\right)^{\frac{1}{2}}
        /// \left(a_0+a_1x+a_2x^2+a_3x^3\right) +
        /// \epsilon\left(x\right)\]
        /// </para>
        /// <para>\[\left|\epsilon\left(x\right)\right|\leq 5 \times 10^{-5}\]</para>
        /// <para>
        /// \begin{align*}
        /// a_0&amp;=\hspace{0.277em}1.57072\ 88&amp;a_2&amp;=\hspace{0.777em}.07426\ 10\newline
        /// a_1&amp;=                -.21211\ 44&amp;a_3&amp;=               -.01872\ 93
        /// \end{align*}
        /// </para>
        /// <para>
        /// 出典：Milton Abramowitz and Irene Stegun .
        /// Handbook of Mathematical Function
        /// With Formulas, Graphs, and Mathematical Tables
        /// (Abramowitz and Stegun) .
        /// United States Department of Commerce,
        /// National Bureau of Standards (NBS) , 1964
        /// </para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>このメソッドは引数 <c>x</c> が範囲外 (-32768 未満または 32768 より大きい値) の場合､ 誤った値を返します｡</para>
        /// </div>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>このメソッドは引数 <c>x</c> が範囲外 (-32768 未満または 32768 より大きい値) の場合､ 例外を送出する場合があります｡</para>
        /// </div>
        /// </remarks>
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

        /// <summary>
        /// 逆正弦を近似する｡
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とする正弦</param>
        /// <returns>-π/2 以上 π/2 以下の､ π を 2 の 30 乗で表した角度｡</returns>
        /// <remarks>
        /// <para>以下の式に基づいて近似する｡</para>
        /// <div class="math"></div>
        /// <para>\[0\le x\le1\]</para>
        /// <para>
        /// \[arcsin\ x =
        /// \frac{\pi}{2} -
        /// \left(1 - x\right)^{\frac{1}{2}}
        /// \left(a_0+a_1x+a_2x^2+a_3x^3\right) +
        /// \epsilon\left(x\right)\]
        /// </para>
        /// <para>\[\left|\epsilon\left(x\right)\right|\leq 5 \times 10^{-5}\]</para>
        /// <para>
        /// \begin{align*}
        /// a_0&amp;=\hspace{0.277em}1.57072\ 88&amp;a_2&amp;=\hspace{0.777em}.07426\ 10\newline
        /// a_1&amp;=                -.21211\ 44&amp;a_3&amp;=               -.01872\ 93
        /// \end{align*}
        /// </para>
        /// <para>
        /// 出典：Milton Abramowitz and Irene Stegun .
        /// Handbook of Mathematical Function
        /// With Formulas, Graphs, and Mathematical Tables
        /// (Abramowitz and Stegun) .
        /// United States Department of Commerce,
        /// National Bureau of Standards (NBS) , 1964
        /// </para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>このメソッドは引数 <c>x</c> が範囲外 (-32768 未満または 32768 より大きい値) の場合､ 誤った値を返します｡</para>
        /// </div>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>このメソッドは引数 <c>x</c> が範囲外 (-32768 未満または 32768 より大きい値) の場合､ 例外を送出する場合があります｡</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Asin(int x) {
            var negate = x < 0;
            var sign = Math.Sign(x);
            x = AsinInternal(negate ? -x : x);
            return sign * ((1 << 30) - x);
        }

        internal static class AtanInternal {
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
            internal static int P2A2909(int x) {
                const int k = FracK4;
                const int a = 2909;
                var w = Math.Abs(x);
                var z = One - w;
                var y = k + ((z * a) >> 15);
                return x * y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P3A2577B664(int x) {
                const int k = FracK4;
                const int a = 2577;
                const int b = 664;
                var w = Math.Abs(x);
                var z = One - w;
                int y;
                y = a + ((w * b) >> 15);
                y = k + ((z * y) >> 15);
                return x * y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P5A2996B809(int x) {
                const int b = 809;
                const int a = 2996;
                const int k = (1 << 13) + a - b;
                var z = (x * x) >> 15;
                int y;
                y = a - ((b * z) >> 15);
                y = k - ((y * z) >> 15);
                return y * x;
            }
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 2 / 3;
        /// var actual = Intar.Mathi.AtanP2A2909(x);
        /// var expected = System.Math.Atan((double)x / k);
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
        /// Assert.AreEqual(expected, a, 0.004507);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int AtanP2A2909(int x) {
            if (x < AtanInternal.OneNeg) {
                return AtanInternal.RightNeg - AtanInternal.P2A2909(AtanInternal.Inv(x));
            } else if (x > AtanInternal.One) {
                return AtanInternal.Right - AtanInternal.P2A2909(AtanInternal.Inv(x));
            } else {
                return AtanInternal.P2A2909(x);
            }
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var y = 2;
        /// var x = 3;
        /// var actual = Intar.Mathi.Atan2P2A2909(y, x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
        /// Assert.AreEqual(expected, a, 0.004507);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Atan2P2A2909(int y, int x) {
            if (y < 0) {
                if (x < 0) {
                    return y < x
                        ? AtanInternal.RightNeg - AtanInternal.P2A2909(AtanInternal.Div(x, y))
                        : AtanInternal.P2A2909(AtanInternal.Div(y, x)) - AtanInternal.Straight;
                } else if (x > 0) {
                    return y < -x
                        ? AtanInternal.RightNeg - AtanInternal.P2A2909(AtanInternal.Div(x, y))
                        : AtanInternal.P2A2909(AtanInternal.Div(y, x));
                } else {
                    return AtanInternal.RightNeg;
                }
            } else if (y > 0) {
                if (x < 0) {
                    return -y < x
                        ? AtanInternal.Right - AtanInternal.P2A2909(AtanInternal.Div(x, y))
                        : AtanInternal.Straight + AtanInternal.P2A2909(AtanInternal.Div(y, x));
                } else if (x > 0) {
                    return y > x
                        ? AtanInternal.Right - AtanInternal.P2A2909(AtanInternal.Div(x, y))
                        : AtanInternal.P2A2909(AtanInternal.Div(y, x));
                } else {
                    return AtanInternal.Right;
                }
            } else {
                return x < 0 ? AtanInternal.Straight : 0;
            }
        }

        /// <summary>
        /// 3 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 2 / 3;
        /// var actual = Intar.Mathi.AtanP3A2577B664(x);
        /// var expected = System.Math.Atan((double)x / k);
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
        /// Assert.AreEqual(expected, a, 0.00173);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int AtanP3A2577B664(int x) {
            if (x < AtanInternal.OneNeg) {
                return AtanInternal.RightNeg - AtanInternal.P3A2577B664(AtanInternal.Inv(x));
            } else if (x > AtanInternal.One) {
                return AtanInternal.Right - AtanInternal.P3A2577B664(AtanInternal.Inv(x));
            } else {
                return AtanInternal.P3A2577B664(x);
            }
        }

        /// <summary>
        /// 3 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var y = 2;
        /// var x = 3;
        /// var actual = Intar.Mathi.Atan2P3A2577B664(y, x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
        /// Assert.AreEqual(expected, a, 0.00173);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Atan2P3A2577B664(int y, int x) {
            if (y < 0) {
                if (x < 0) {
                    return y < x
                        ? AtanInternal.RightNeg - AtanInternal.P3A2577B664(AtanInternal.Div(x, y))
                        : AtanInternal.P3A2577B664(AtanInternal.Div(y, x)) - AtanInternal.Straight;
                } else if (x > 0) {
                    return y < -x
                        ? AtanInternal.RightNeg - AtanInternal.P3A2577B664(AtanInternal.Div(x, y))
                        : AtanInternal.P3A2577B664(AtanInternal.Div(y, x));
                } else {
                    return AtanInternal.RightNeg;
                }
            } else if (y > 0) {
                if (x < 0) {
                    return -y < x
                        ? AtanInternal.Right - AtanInternal.P3A2577B664(AtanInternal.Div(x, y))
                        : AtanInternal.Straight + AtanInternal.P3A2577B664(AtanInternal.Div(y, x));
                } else if (x > 0) {
                    return y > x
                        ? AtanInternal.Right - AtanInternal.P3A2577B664(AtanInternal.Div(x, y))
                        : AtanInternal.P3A2577B664(AtanInternal.Div(y, x));
                } else {
                    return AtanInternal.Right;
                }
            } else {
                return x < 0 ? AtanInternal.Straight : 0;
            }
        }

        /// <summary>
        /// 5 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 2 / 3;
        /// var actual = Intar.Mathi.AtanP5A2996B809(x);
        /// var expected = System.Math.Atan((double)x / k);
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
        /// Assert.AreEqual(expected, a, 0.000914);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int AtanP5A2996B809(int x) {
            if (x < AtanInternal.OneNeg) {
                return AtanInternal.RightNeg - AtanInternal.P5A2996B809(AtanInternal.Inv(x));
            } else if (x > AtanInternal.One) {
                return AtanInternal.Right - AtanInternal.P5A2996B809(AtanInternal.Inv(x));
            } else {
                return AtanInternal.P5A2996B809(x);
            }
        }

        /// <summary>
        /// 5 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var y = 2;
        /// var x = 3;
        /// var actual = Intar.Mathi.Atan2P5A2996B809(y, x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
        /// Assert.AreEqual(expected, a, 0.000919);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Atan2P5A2996B809(int y, int x) {
            if (y < 0) {
                if (x < 0) {
                    return y < x
                        ? AtanInternal.RightNeg - AtanInternal.P5A2996B809(AtanInternal.Div(x, y))
                        : AtanInternal.P5A2996B809(AtanInternal.Div(y, x)) - AtanInternal.Straight;
                } else if (x > 0) {
                    return y < -x
                        ? AtanInternal.RightNeg - AtanInternal.P5A2996B809(AtanInternal.Div(x, y))
                        : AtanInternal.P5A2996B809(AtanInternal.Div(y, x));
                } else {
                    return AtanInternal.RightNeg;
                }
            } else if (y > 0) {
                if (x < 0) {
                    return -y < x
                        ? AtanInternal.Right - AtanInternal.P5A2996B809(AtanInternal.Div(x, y))
                        : AtanInternal.Straight + AtanInternal.P5A2996B809(AtanInternal.Div(y, x));
                } else if (x > 0) {
                    return y > x
                        ? AtanInternal.Right - AtanInternal.P5A2996B809(AtanInternal.Div(x, y))
                        : AtanInternal.P5A2996B809(AtanInternal.Div(y, x));
                } else {
                    return AtanInternal.Right;
                }
            } else {
                return x < 0 ? AtanInternal.Straight : 0;
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

        internal static class SinInternal {
            internal enum Quadrant : byte {
                First,
                Second,
                Third,
                Fourth,
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static Quadrant ToQuadrant(int x) => (Quadrant)((x >> 15) & 3);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int MakeArgOdd(int x) {
                var masked = x & ((1 << 15) - 1);
                switch (ToQuadrant(x)) {
                    default:
                    case Quadrant.First: return masked;
                    case Quadrant.Third: return -masked;
                    case Quadrant.Fourth: return masked - (1 << 15);
                    case Quadrant.Second: return (1 << 15) - masked;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static Quadrant ToQuadrant(long x) => (Quadrant)((x >> 31) & 3);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static long MakeArgOdd(long x) {
                var masked = x & ((1L << 31) - 1);
                switch (ToQuadrant(x)) {
                    default:
                    case Quadrant.First: return masked;
                    case Quadrant.Third: return -masked;
                    case Quadrant.Fourth: return masked - (1L << 31);
                    case Quadrant.Second: return (1L << 31) - masked;
                }
            }

            const decimal K01 = 3.1415926535897932384626433833m / 2;
            const decimal K02 = K01 * K01;
            const decimal K03 = K02 * K01;
            const decimal K04 = K03 * K01;
            const decimal K05 = K04 * K01;
            const decimal K06 = K05 * K01;
            const decimal K07 = K06 * K01;
            const decimal K08 = K07 * K01;
            const decimal K09 = K08 * K01;
            const decimal K10 = K09 * K01;
            const decimal K11 = K10 * K01;

            // Milton Abramowitz and Irene Stegun .
            // Handbook of Mathematical Function With Formulas, Graphs, and Mathematical Tables (Abramowitz and Stegun) .
            // United States Department of Commerce, National Bureau of Standards (NBS) , 1964

            // 符号なし整数を用いることで 1 ビット定数の精度上げることができるが､
            // 最終的な精度に対して与える影響が安定せず､
            // また､ 乗算対象と同じ精度にすることができなくなるので､
            // ここではそのビットは捨てる｡

            // 7244019458077122842
            // 5957967184218496005
            // 5880276630038185627
            // 5527136674668279497
            // 6054407851785858183
            // 8301301681792740747
            // 5689439535887298204
            // 4679373698902585566
            // 6157594556960820448
            // 8667924621372700220
            // 7200226522060996872
            // 1686629713
            // 1382064706
            // 1250270241
            // 1315933018
            // 1937570784

            internal const long P11I64A = (long)(0.5m + (1.000_000_000_0m * K01 * (1L << 62)));
            internal const long P11I64B = (long)(0.5m + (0.166_666_666_4m * K03 * (1L << 62) * (1 << 1)));
            internal const long P11I64C = (long)(0.5m + (0.008_333_331_5m * K05 * (1L << 62) * (1 << 4)));
            internal const long P11I64D = (long)(0.5m + (0.000_198_409_0m * K07 * (1L << 62) * (1 << 8)));
            internal const long P11I64E = (long)(0.5m + (0.000_002_752_6m * K09 * (1L << 62) * (1 << 13)));
            internal const long P11I64F = (long)(0.0m + (0.000_000_023_9m * K11 * (1L << 62) * (1 << 19)));
            internal const long P10I64A = (long)(0.5m + (0.499_999_996_3m * K02 * (1L << 62)));
            internal const long P10I64B = (long)(0.5m + (0.041_666_641_8m * K04 * (1L << 62) * (1 << 2)));
            internal const long P10I64C = (long)(0.5m + (0.001_388_839_7m * K06 * (1L << 62) * (1 << 6)));
            internal const long P10I64D = (long)(0.5m + (0.000_024_760_9m * K08 * (1L << 62) * (1 << 11)));
            internal const long P10I64E = (long)(0.0m + (0.000_000_260_5m * K10 * (1L << 62) * (1 << 16)));
            internal const int P5I32A = (int)(0.5m + (1.00000m * K01 * (1 << 30)));
            internal const int P5I32B = (int)(0.5m + (0.16605m * K03 * (1 << 30) * (1 << 1)));
            internal const int P5I32C = (int)(0.0m + (0.00761m * K05 * (1 << 30) * (1 << 4)));
            internal const int P4I32A = (int)(0.5m + (0.49670m * K02 * (1 << 30)));
            internal const int P4I32B = (int)(0.0m + (0.03705m * K04 * (1 << 30) * (1 << 3)));

            // 精度に対して与える影響が軽微であるため､
            // 乗算前に一度にまとめてビットシフトを行う｡

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static long P11(long z) {
                long y;
                y = P11I64F + (1 << (31 + 6 - 1));
                y = P11I64E - ((y >> (31 + 6)) * z);
                y = P11I64D - ((y >> (31 + 5)) * z);
                y = P11I64C - ((y >> (31 + 4)) * z);
                y = P11I64B - ((y >> (31 + 3)) * z);
                y = P11I64A - ((y >> (31 + 1)) * z);
                return y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static long P10(long z) {
                long y;
                y = P10I64E + (1 << (31 + 5 - 1));
                y = P10I64D - ((y >> (31 + 5)) * z);
                y = P10I64C - ((y >> (31 + 5)) * z);
                y = P10I64B - ((y >> (31 + 4)) * z);
                y = P10I64A - ((y >> (31 + 2)) * z);
                return (y >> 31) * z;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P5(int z) {
                int y;
                y = P5I32C + (1 << (15 + 3 - 1));
                y = P5I32B - ((y >> (15 + 3)) * z);
                y = P5I32A - ((y >> (15 + 1)) * z);
                return y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P4(int z) {
                int y;
                y = P4I32B + (1 << (15 + 3 - 1));
                y = P4I32A - ((y >> (15 + 3)) * z);
                return (y >> 15) * z;
            }
        }

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.CosP4(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Cos(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.0018);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CosP4(int x) {
            const int pi = 1 << 15;
            const int one = 1 << 30;
            var q = SinInternal.ToQuadrant(x);
            x &= pi - 1;
            switch (q) {
                default:
                case SinInternal.Quadrant.First: return one - SinInternal.P4((x * x) >> 15);
                case SinInternal.Quadrant.Third: return SinInternal.P4((x * x) >> 15) - one;
                case SinInternal.Quadrant.Fourth: return one - SinInternal.P4(((pi - x) * (pi - x)) >> 15);
                case SinInternal.Quadrant.Second: return SinInternal.P4(((pi - x) * (pi - x)) >> 15) - one;
            }
        }

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.SinP4(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Sin(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.0018);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SinP4(int x) => CosP4(Overflowing.WrappingSub(x, 1 << 15));

        /// <summary>
        /// 10 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// const long k = 1L &lt;&lt; 31;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.CosP10(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Cos(rad);
        /// var a = (double)actual / (1L &lt;&lt; 62);
        /// Assert.AreEqual(expected, a, 0.000000004);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を直角とする角度</param>
        /// <returns>2 の 62 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long CosP10(long x) {
            const long pi = 1L << 31;
            const long one = 1L << 62;
            var q = SinInternal.ToQuadrant(x);
            x &= pi - 1;
            switch (q) {
                default:
                case SinInternal.Quadrant.First: return one - SinInternal.P10((x * x) >> 31);
                case SinInternal.Quadrant.Third: return SinInternal.P10((x * x) >> 31) - one;
                case SinInternal.Quadrant.Fourth: return one - SinInternal.P10(((pi - x) * (pi - x)) >> 31);
                case SinInternal.Quadrant.Second: return SinInternal.P10(((pi - x) * (pi - x)) >> 31) - one;
            }
        }

        /// <summary>
        /// 10 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// const long k = 1L &lt;&lt; 31;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.SinP10(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Sin(rad);
        /// var a = (double)actual / (1L &lt;&lt; 62);
        /// Assert.AreEqual(expected, a, 0.000000004);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を直角とする角度</param>
        /// <returns>2 の 62 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long SinP10(long x) => CosP10(Overflowing.WrappingSub(x, 1L << 31));

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.SinP5(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Sin(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.0004);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SinP5(int x) {
            x = SinInternal.MakeArgOdd(x);
            return x * (SinInternal.P5((x * x) >> 15) >> 15);
        }

        /// <summary>
        /// 5 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.CosP5(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Cos(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.0004);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CosP5(int x) => SinP5(Overflowing.WrappingAdd(x, 1 << 15));

        /// <summary>
        /// 11 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// const long k = 1L &lt;&lt; 31;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.SinP11(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Sin(rad);
        /// var a = (double)actual / (1L &lt;&lt; 62);
        /// Assert.AreEqual(expected, a, 0.000000004);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を直角とする角度</param>
        /// <returns>2 の 62 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long SinP11(long x) {
            x = SinInternal.MakeArgOdd(x);
            return x * (SinInternal.P11((x * x) >> 31) >> 31);
        }

        /// <summary>
        /// 11 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// const long k = 1L &lt;&lt; 31;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.CosP11(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Cos(rad);
        /// var a = (double)actual / (1L &lt;&lt; 62);
        /// Assert.AreEqual(expected, a, 0.000000004);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を直角とする角度</param>
        /// <returns>2 の 62 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long CosP11(long x) => SinP11(Overflowing.WrappingAdd(x, 1L << 31));

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
