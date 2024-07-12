using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class Mathi {
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
                return (int)((k + System.Math.Abs(xl)) / (xl << 1));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int Div(int a, int b) {
                var al = ((long)a) << 16;
                var bl = (long)b;
                return (int)((al + (System.Math.Sign(a) * System.Math.Abs(bl))) / (bl << 1));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P2A2850(int x) {
                const int a = 2850;
                var xAbs = System.Math.Abs(x);
                return x * (FracK4 + (((One - xAbs) * a) >> 15));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P3A2555B691(int x) {
                const int a = 2555;
                const int b = 691;
                var xAbs = System.Math.Abs(x);
                return x * (FracK4 + (((One - xAbs) * (a + ((xAbs * b) >> 15))) >> 15));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P5A787B2968(int x) {
                const int a = 787;
                const int b = 2968;
                const int c = (1 << 13) + b - a;
                var x2 = (x * x) >> 15;
                return (c - (((b - ((a * x2) >> 15)) * x2) >> 15)) * x;
            }
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var x = (1 << 15) * 2 / 3;
        /// var actual = Intar.Mathi.AtanP2A2850(x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = actual * System.Math.PI / (1 << 30);
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
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var x = (1 << 15) * 2 / 3;
        /// var actual = Intar.Mathi.AtanP3A2555B691(x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = actual * System.Math.PI / (1 << 30);
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
        /// 2 次の多項式で逆正接を近似する。
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
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var x = (1 << 15) * 2 / 3;
        /// var actual = Intar.Mathi.AtanP5A787B2968(x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = actual * System.Math.PI / (1 << 30);
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
        /// 2 次の多項式で逆正接を近似する。
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
    }
}
