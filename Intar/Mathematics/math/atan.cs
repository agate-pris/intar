using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CS8981 // 型名には、小文字の ASCII 文字のみが含まれています。このような名前は、プログラミング言語用に予約されている可能性があります。
#pragma warning disable IDE1006 // 命名スタイル

    public static partial class math {

#pragma warning restore IDE1006 // 命名スタイル
#pragma warning restore CS8981 // 型名には、小文字の ASCII 文字のみが含まれています。このような名前は、プログラミング言語用に予約されている可能性があります。
#pragma warning restore IDE0079 // 不要な抑制を削除します

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
        }

#pragma warning disable IDE1006 // 命名スタイル
#pragma warning disable CA1707 // 識別子にアンダースコアを含めるべきではありません

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int atan_p2_2850_detail(int x) {
            const int a = 2850;
            var xAbs = System.Math.Abs(x);
            return x * (Atan.FracK4 + (((Atan.One - xAbs) * a) >> 15));
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var x = (1 << 15) * 2 / 3;
        /// var actual = Intar.Mathematics.math.atan_p2_2850(x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = actual * System.Math.PI / (1 << 30);
        /// Assert.AreEqual(expected, a, 0.003778);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int atan_p2_2850(int x) {
            return (x < Atan.OneNeg, x > Atan.One) switch {
                (true, _) => Atan.RightNeg - atan_p2_2850_detail(Atan.Inv(x)),
                (_, true) => Atan.Right - atan_p2_2850_detail(Atan.Inv(x)),
                _ => atan_p2_2850_detail(x),
            };
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var y = 2;
        /// var x = 3;
        /// var actual = Intar.Mathematics.math.atan2_p2_2850(y, x);
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
        public static int atan2_p2_2850(int y, int x) {
            return (System.Math.Sign(y), System.Math.Sign(x)) switch {
                (-1, -1) => y < x
                    ? Atan.RightNeg - atan_p2_2850_detail(Atan.Div(x, y))
                    : atan_p2_2850_detail(Atan.Div(y, x)) - Atan.Straight,
                (-1, 0) => Atan.RightNeg,
                (-1, 1) => y < -x
                    ? Atan.RightNeg - atan_p2_2850_detail(Atan.Div(x, y))
                    : atan_p2_2850_detail(Atan.Div(y, x)),
                (0, -1) => Atan.Straight,
                (1, -1) => -y < x
                    ? Atan.Right - atan_p2_2850_detail(Atan.Div(x, y))
                    : Atan.Straight + atan_p2_2850_detail(Atan.Div(y, x)),
                (1, 0) => Atan.Right,
                (1, 1) => y < x
                    ? atan_p2_2850_detail(Atan.Div(y, x))
                    : Atan.Right - atan_p2_2850_detail(Atan.Div(x, y)),
                _ => 0,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int atan_p3_2555_691_detail(int x) {
            const int a = 2555;
            const int b = 691;
            var xAbs = System.Math.Abs(x);
            return x * (Atan.FracK4 + (((Atan.One - xAbs) * (a + ((xAbs * b) >> 15))) >> 15));
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var x = (1 << 15) * 2 / 3;
        /// var actual = Intar.Mathematics.math.atan_p3_2555_691(x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = actual * System.Math.PI / (1 << 30);
        /// Assert.AreEqual(expected, a, 0.001543);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int atan_p3_2555_691(int x) {
            return (x < Atan.OneNeg, x > Atan.One) switch {
                (true, _) => Atan.RightNeg - atan_p3_2555_691_detail(Atan.Inv(x)),
                (_, true) => Atan.Right - atan_p3_2555_691_detail(Atan.Inv(x)),
                _ => atan_p3_2555_691_detail(x),
            };
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var y = 2;
        /// var x = 3;
        /// var actual = Intar.Mathematics.math.atan2_p3_2555_691(y, x);
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
        public static int atan2_p3_2555_691(int y, int x) {
            return (System.Math.Sign(y), System.Math.Sign(x)) switch {
                (-1, -1) => y < x
                    ? Atan.RightNeg - atan_p3_2555_691_detail(Atan.Div(x, y))
                    : atan_p3_2555_691_detail(Atan.Div(y, x)) - Atan.Straight,
                (-1, 0) => Atan.RightNeg,
                (-1, 1) => y < -x
                    ? Atan.RightNeg - atan_p3_2555_691_detail(Atan.Div(x, y))
                    : atan_p3_2555_691_detail(Atan.Div(y, x)),
                (0, -1) => Atan.Straight,
                (1, -1) => -y < x
                    ? Atan.Right - atan_p3_2555_691_detail(Atan.Div(x, y))
                    : Atan.Straight + atan_p3_2555_691_detail(Atan.Div(y, x)),
                (1, 0) => Atan.Right,
                (1, 1) => y < x
                    ? atan_p3_2555_691_detail(Atan.Div(y, x))
                    : Atan.Right - atan_p3_2555_691_detail(Atan.Div(x, y)),
                _ => 0,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int atan_p5_787_2968_detail(int x) {
            const int a = 787;
            const int b = 2968;
            const int c = (1 << 13) + b - a;
            var x2 = (x * x) >> 15;
            return (c - (((b - ((a * x2) >> 15)) * x2) >> 15)) * x;
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var x = (1 << 15) * 2 / 3;
        /// var actual = Intar.Mathematics.math.atan_p5_787_2968(x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = actual * System.Math.PI / (1 << 30);
        /// Assert.AreEqual(expected, a, 0.000767);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int atan_p5_787_2968(int x) {
            return (x < Atan.OneNeg, x > Atan.One) switch {
                (true, _) => Atan.RightNeg - atan_p5_787_2968_detail(Atan.Inv(x)),
                (_, true) => Atan.Right - atan_p5_787_2968_detail(Atan.Inv(x)),
                _ => atan_p5_787_2968_detail(x),
            };
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var y = 2;
        /// var x = 3;
        /// var actual = Intar.Mathematics.math.atan2_p5_787_2968(y, x);
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
        public static int atan2_p5_787_2968(int y, int x) {
            return (System.Math.Sign(y), System.Math.Sign(x)) switch {
                (-1, -1) => y < x
                    ? Atan.RightNeg - atan_p5_787_2968_detail(Atan.Div(x, y))
                    : atan_p5_787_2968_detail(Atan.Div(y, x)) - Atan.Straight,
                (-1, 0) => Atan.RightNeg,
                (-1, 1) => y < -x
                    ? Atan.RightNeg - atan_p5_787_2968_detail(Atan.Div(x, y))
                    : atan_p5_787_2968_detail(Atan.Div(y, x)),
                (0, -1) => Atan.Straight,
                (1, -1) => -y < x
                    ? Atan.Right - atan_p5_787_2968_detail(Atan.Div(x, y))
                    : Atan.Straight + atan_p5_787_2968_detail(Atan.Div(y, x)),
                (1, 0) => Atan.Right,
                (1, 1) => y < x
                    ? atan_p5_787_2968_detail(Atan.Div(y, x))
                    : Atan.Right - atan_p5_787_2968_detail(Atan.Div(x, y)),
                _ => 0,
            };
        }

#pragma warning restore CA1707 // 識別子にアンダースコアを含めるべきではありません
#pragma warning restore IDE1006 // 命名スタイル

    }
}
