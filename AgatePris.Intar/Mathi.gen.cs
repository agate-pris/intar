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
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 2 / 3;
        /// var actual = Intar.Mathi.AtanP2A2850(x);
        /// var expected = System.Math.Atan((double)x / k);
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
        /// Assert.AreEqual(expected, a, 0.003778);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int AtanP2A2850(int x) {
            if (x < AtanInternal.OneNeg) {
                return AtanInternal.RightNeg - AtanInternal.P2A2850(AtanInternal.Inv(x));
            } else if (x > AtanInternal.One) {
                return AtanInternal.Right - AtanInternal.P2A2850(AtanInternal.Inv(x));
            } else {
                return AtanInternal.P2A2850(x);
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
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
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
                        ? AtanInternal.RightNeg - AtanInternal.P2A2850(AtanInternal.Div(x, y))
                        : AtanInternal.P2A2850(AtanInternal.Div(y, x)) - AtanInternal.Straight;
                } else if (x > 0) {
                    return y < -x
                        ? AtanInternal.RightNeg - AtanInternal.P2A2850(AtanInternal.Div(x, y))
                        : AtanInternal.P2A2850(AtanInternal.Div(y, x));
                } else {
                    return AtanInternal.RightNeg;
                }
            } else if (y > 0) {
                if (x < 0) {
                    return -y < x
                        ? AtanInternal.Right - AtanInternal.P2A2850(AtanInternal.Div(x, y))
                        : AtanInternal.Straight + AtanInternal.P2A2850(AtanInternal.Div(y, x));
                } else if (x > 0) {
                    return y > x
                        ? AtanInternal.Right - AtanInternal.P2A2850(AtanInternal.Div(x, y))
                        : AtanInternal.P2A2850(AtanInternal.Div(y, x));
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
        /// var actual = Intar.Mathi.AtanP3A2555B691(x);
        /// var expected = System.Math.Atan((double)x / k);
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
        /// Assert.AreEqual(expected, a, 0.001543);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int AtanP3A2555B691(int x) {
            if (x < AtanInternal.OneNeg) {
                return AtanInternal.RightNeg - AtanInternal.P3A2555B691(AtanInternal.Inv(x));
            } else if (x > AtanInternal.One) {
                return AtanInternal.Right - AtanInternal.P3A2555B691(AtanInternal.Inv(x));
            } else {
                return AtanInternal.P3A2555B691(x);
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
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
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
                        ? AtanInternal.RightNeg - AtanInternal.P3A2555B691(AtanInternal.Div(x, y))
                        : AtanInternal.P3A2555B691(AtanInternal.Div(y, x)) - AtanInternal.Straight;
                } else if (x > 0) {
                    return y < -x
                        ? AtanInternal.RightNeg - AtanInternal.P3A2555B691(AtanInternal.Div(x, y))
                        : AtanInternal.P3A2555B691(AtanInternal.Div(y, x));
                } else {
                    return AtanInternal.RightNeg;
                }
            } else if (y > 0) {
                if (x < 0) {
                    return -y < x
                        ? AtanInternal.Right - AtanInternal.P3A2555B691(AtanInternal.Div(x, y))
                        : AtanInternal.Straight + AtanInternal.P3A2555B691(AtanInternal.Div(y, x));
                } else if (x > 0) {
                    return y > x
                        ? AtanInternal.Right - AtanInternal.P3A2555B691(AtanInternal.Div(x, y))
                        : AtanInternal.P3A2555B691(AtanInternal.Div(y, x));
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
        /// var actual = Intar.Mathi.AtanP5A787B2968(x);
        /// var expected = System.Math.Atan((double)x / k);
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
        /// Assert.AreEqual(expected, a, 0.000767);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int AtanP5A787B2968(int x) {
            if (x < AtanInternal.OneNeg) {
                return AtanInternal.RightNeg - AtanInternal.P5A787B2968(AtanInternal.Inv(x));
            } else if (x > AtanInternal.One) {
                return AtanInternal.Right - AtanInternal.P5A787B2968(AtanInternal.Inv(x));
            } else {
                return AtanInternal.P5A787B2968(x);
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
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
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
                        ? AtanInternal.RightNeg - AtanInternal.P5A787B2968(AtanInternal.Div(x, y))
                        : AtanInternal.P5A787B2968(AtanInternal.Div(y, x)) - AtanInternal.Straight;
                } else if (x > 0) {
                    return y < -x
                        ? AtanInternal.RightNeg - AtanInternal.P5A787B2968(AtanInternal.Div(x, y))
                        : AtanInternal.P5A787B2968(AtanInternal.Div(y, x));
                } else {
                    return AtanInternal.RightNeg;
                }
            } else if (y > 0) {
                if (x < 0) {
                    return -y < x
                        ? AtanInternal.Right - AtanInternal.P5A787B2968(AtanInternal.Div(x, y))
                        : AtanInternal.Straight + AtanInternal.P5A787B2968(AtanInternal.Div(y, x));
                } else if (x > 0) {
                    return y > x
                        ? AtanInternal.Right - AtanInternal.P5A787B2968(AtanInternal.Div(x, y))
                        : AtanInternal.P5A787B2968(AtanInternal.Div(y, x));
                } else {
                    return AtanInternal.Right;
                }
            } else {
                return x < 0 ? AtanInternal.Straight : 0;
            }
        }

        public enum AtanMethod : byte {
            P2A2850,
            P3A2555B691,
            P5A787B2968,
            Default = P5A787B2968,
        }

        /// <summary>
        /// 指定された方法で逆正接を近似する｡
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 2 / 3;
        /// var method = Intar.Mathi.AtanMethod.P3A2555B691;
        /// var actual = Intar.Mathi.Atan(x, method);
        /// var expected = System.Math.Atan((double)x / k);
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
        /// Assert.AreEqual(expected, a, 0.001543);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <param name="method">逆正接の近似方法</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Atan(int x, AtanMethod method = AtanMethod.Default) {
            switch (method) {
                case AtanMethod.P2A2850: return AtanP2A2850(x);
                case AtanMethod.P3A2555B691: return AtanP3A2555B691(x);
                default:
                case AtanMethod.P5A787B2968: return AtanP5A787B2968(x);
            }
        }

        /// <summary>
        /// 指定された方法で逆正接を近似する｡
        /// <example>
        /// <code>
        /// var y = 2;
        /// var x = 3;
        /// var method = Intar.Mathi.AtanMethod.P3A2555B691;
        /// var actual = Intar.Mathi.Atan2(y, x, method);
        /// var expected = System.Math.Atan2(y, x);
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
        /// Assert.AreEqual(expected, a, 0.001543);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <param name="method">逆正接の近似方法</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Atan2(int y, int x, AtanMethod method = AtanMethod.Default) {
            switch (method) {
                case AtanMethod.P2A2850: return Atan2P2A2850(y, x);
                case AtanMethod.P3A2555B691: return Atan2P3A2555B691(y, x);
                default:
                case AtanMethod.P5A787B2968: return Atan2P5A787B2968(y, x);
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
            internal const int RightExp = (8 * sizeof(int) / 2) - 1;
            internal const int Right = 1 << RightExp;
            internal const int RightMask = Right - 1;
            internal const int One = Right * Right;

            internal enum Quadrant : byte {
                First,
                Second,
                Third,
                Fourth,
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static Quadrant ToQuadrant(int x) => (Quadrant)((x >> RightExp) & 3);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int MakeArgOdd(int x) {
                var masked = x & RightMask;
                switch (ToQuadrant(x)) {
                    default:
                    case Quadrant.First: return masked;
                    case Quadrant.Third: return -masked;
                    case Quadrant.Fourth: return masked - Right;
                    case Quadrant.Second: return Right - masked;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int CosP2(int z) {
                return z * z;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int CosP4A7373(int z) {
                const int a = 7373;
                const int b = a + Right;
                var z_2 = (z * z) >> RightExp;
                return (b - ((z_2 * a) >> RightExp)) * z_2;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int CosP4A7385(int z) {
                const int a = 7385;
                const int b = a + Right;
                var z_2 = (z * z) >> RightExp;
                return (b - ((z_2 * a) >> RightExp)) * z_2;
            }
        }

        /// <summary>
        /// 2 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.CosP2(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Cos(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.05601);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CosP2(int x) {
            var masked = x & SinInternal.RightMask;
            switch (SinInternal.ToQuadrant(x)) {
                default:
                case SinInternal.Quadrant.First: return SinInternal.One - SinInternal.CosP2(masked);
                case SinInternal.Quadrant.Third: return SinInternal.CosP2(masked) - SinInternal.One;
                case SinInternal.Quadrant.Fourth: return SinInternal.One - SinInternal.CosP2(SinInternal.Right - masked);
                case SinInternal.Quadrant.Second: return SinInternal.CosP2(SinInternal.Right - masked) - SinInternal.One;
            }
        }

        /// <summary>
        /// 2 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.SinP2(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Sin(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.05601);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SinP2(int x) => CosP2(Overflowing.WrappingSub(x, SinInternal.Right));

        /// <summary>
        /// 3 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.SinP3A16384(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Sin(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.020017);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SinP3A16384(int x) {
            const int b = SinInternal.Right / 2;
            const int a = SinInternal.Right + b;
            var z = SinInternal.MakeArgOdd(x);
            var z_2 = (z * z) >> SinInternal.RightExp;
            return (a - ((z_2 * b) >> SinInternal.RightExp)) * z;
        }

        /// <summary>
        /// 3 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.CosP3A16384(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Cos(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.020017);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CosP3A16384(int x) => SinP3A16384(Overflowing.WrappingAdd(x, SinInternal.Right));

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.CosP4A7373(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Cos(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.001114);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CosP4A7373(int x) {
            var masked = x & SinInternal.RightMask;
            switch (SinInternal.ToQuadrant(x)) {
                default:
                case SinInternal.Quadrant.First: return SinInternal.One - SinInternal.CosP4A7373(masked);
                case SinInternal.Quadrant.Third: return SinInternal.CosP4A7373(masked) - SinInternal.One;
                case SinInternal.Quadrant.Fourth: return SinInternal.One - SinInternal.CosP4A7373(SinInternal.Right - masked);
                case SinInternal.Quadrant.Second: return SinInternal.CosP4A7373(SinInternal.Right - masked) - SinInternal.One;
            }
        }

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.SinP4A7373(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Sin(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.001114);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SinP4A7373(int x) => CosP4A7373(Overflowing.WrappingSub(x, SinInternal.Right));

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.CosP4A7385(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Cos(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.00118);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CosP4A7385(int x) {
            var masked = x & SinInternal.RightMask;
            switch (SinInternal.ToQuadrant(x)) {
                default:
                case SinInternal.Quadrant.First: return SinInternal.One - SinInternal.CosP4A7385(masked);
                case SinInternal.Quadrant.Third: return SinInternal.CosP4A7385(masked) - SinInternal.One;
                case SinInternal.Quadrant.Fourth: return SinInternal.One - SinInternal.CosP4A7385(SinInternal.Right - masked);
                case SinInternal.Quadrant.Second: return SinInternal.CosP4A7385(SinInternal.Right - masked) - SinInternal.One;
            }
        }

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.SinP4A7385(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Sin(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.00118);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SinP4A7385(int x) => CosP4A7385(Overflowing.WrappingSub(x, SinInternal.Right));

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.SinP5A51436(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Sin(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.000223);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SinP5A51436(int x) {
            const int k = 51436;
            const int a = (k * 2) - (SinInternal.Right * 5 / 2);
            const int b = k - (SinInternal.Right * 3 / 2);
            var z = SinInternal.MakeArgOdd(x);
            var z_2 = (z * z) >> SinInternal.RightExp;
            return (k - (((a - ((z_2 * b) >> SinInternal.RightExp)) * z_2) >> SinInternal.RightExp)) * z;
        }

        /// <summary>
        /// 5 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.CosP5A51436(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Cos(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.000223);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CosP5A51436(int x) => SinP5A51436(Overflowing.WrappingAdd(x, SinInternal.Right));

        public enum SinMethod : byte {
            P2,
            P3A16384,
            P4A7373,
            P4A7385,
            P5A51436,
            Default = P5A51436,
        }

        /// <summary>
        /// 指定された方法で正弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var method = Intar.Mathi.SinMethod.P5A51436;
        /// var actual = Intar.Mathi.Sin(x, method);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Sin(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.000223);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sin(int x, SinMethod method = SinMethod.Default) {
            switch (method) {
                case SinMethod.P2: return SinP2(x);
                case SinMethod.P3A16384: return SinP3A16384(x);
                case SinMethod.P4A7373: return SinP4A7373(x);
                case SinMethod.P4A7385: return SinP4A7385(x);
                default:
                case SinMethod.P5A51436: return SinP5A51436(x);
            }
        }

        /// <summary>
        /// 指定された方法で余弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var method = Intar.Mathi.SinMethod.P5A51436;
        /// var actual = Intar.Mathi.Cos(x, method);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Cos(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.000223);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Cos(int x, SinMethod method = SinMethod.Default) {
            switch (method) {
                case SinMethod.P2: return CosP2(x);
                case SinMethod.P3A16384: return CosP3A16384(x);
                case SinMethod.P4A7373: return CosP4A7373(x);
                case SinMethod.P4A7385: return CosP4A7385(x);
                default:
                case SinMethod.P5A51436: return CosP5A51436(x);
            }
        }

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
