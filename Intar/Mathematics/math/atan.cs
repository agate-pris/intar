using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE1006 // 命名スタイル
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    public static partial class math {
#pragma warning restore CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
#pragma warning restore IDE1006 // 命名スタイル
#pragma warning restore IDE0079 // 不要な抑制を削除します
        const int atanOne = 1 << 15;
        const int atanOneNeg = -atanOne;
        const int atanStraight = 1 << 30;
        const int atanRight = atanStraight / 2;
        const int atanRightNeg = -atanRight;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int AtanInv(int x) {
            const long k = 1L << 31;
            var xl = (long)x;
            return (int)((k + System.Math.Abs(xl)) / (xl << 1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int AtanDiv(int a, int b) {
            var al = ((long)a) << 16;
            var bl = (long)b;
            return (int)((al + System.Math.Sign(a) * System.Math.Abs(bl)) / (bl << 1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int AtanP2_2850Detail(int x) {
            const int a = 2850;
            const int frac_k_4 = atanOne / 4;
            var xAbs = System.Math.Abs(x);
            return x * (frac_k_4 + ((atanOne - xAbs) * a >> 15));
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var x = (1 << 15) * 2 / 3;
        /// var actual = Intar.Mathematics.Math.AtanP2_2850(x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = actual * System.Math.PI / (1 << 30);
        /// Assert.AreEqual(expected, a, 0.003778);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int AtanP2_2850(int x) {
            return (x < atanOneNeg, x > atanOne) switch {
                (true, _) => atanRightNeg - AtanP2_2850Detail(AtanInv(x)),
                (_, true) => atanRight - AtanP2_2850Detail(AtanInv(x)),
                _ => AtanP2_2850Detail(x),
            };
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var y = 2;
        /// var x = 3;
        /// var actual = Intar.Mathematics.Math.Atan2P2_2850(y, x);
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
        public static int Atan2P2_2850(int y, int x) {
            return (System.Math.Sign(y), System.Math.Sign(x)) switch {
                (-1, -1) => y < x
                    ? atanRightNeg - AtanP2_2850Detail(AtanDiv(x, y))
                    : AtanP2_2850Detail(AtanDiv(y, x)) - atanStraight,
                (-1, 0) => atanRightNeg,
                (-1, 1) => y < -x
                    ? atanRightNeg - AtanP2_2850Detail(AtanDiv(x, y))
                    : AtanP2_2850Detail(AtanDiv(y, x)),
                (0, -1) => atanStraight,
                (1, -1) => -y < x
                    ? atanRight - AtanP2_2850Detail(AtanDiv(x, y))
                    : atanStraight + AtanP2_2850Detail(AtanDiv(y, x)),
                (1, 0) => atanRight,
                (1, 1) => y < x
                    ? AtanP2_2850Detail(AtanDiv(y, x))
                    : atanRight - AtanP2_2850Detail(AtanDiv(x, y)),
                _ => 0,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int AtanP3_2555_691Detail(int x) {
            const int a = 2555;
            const int b = 691;
            const int frac_k_4 = atanOne / 4;
            var xAbs = System.Math.Abs(x);
            return x * (frac_k_4 + ((atanOne - xAbs) * (a + (xAbs * b >> 15)) >> 15));
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var x = (1 << 15) * 2 / 3;
        /// var actual = Intar.Mathematics.Math.AtanP3_2555_691(x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = actual * System.Math.PI / (1 << 30);
        /// Assert.AreEqual(expected, a, 0.001543);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int AtanP3_2555_691(int x) {
            return (x < atanOneNeg, x > atanOne) switch {
                (true, _) => atanRightNeg - AtanP3_2555_691Detail(AtanInv(x)),
                (_, true) => atanRight - AtanP3_2555_691Detail(AtanInv(x)),
                _ => AtanP3_2555_691Detail(x),
            };
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var y = 2;
        /// var x = 3;
        /// var actual = Intar.Mathematics.Math.Atan2P3_2555_691(y, x);
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
        public static int Atan2P3_2555_691(int y, int x) {
            return (System.Math.Sign(y), System.Math.Sign(x)) switch {
                (-1, -1) => y < x
                    ? atanRightNeg - AtanP3_2555_691Detail(AtanDiv(x, y))
                    : AtanP3_2555_691Detail(AtanDiv(y, x)) - atanStraight,
                (-1, 0) => atanRightNeg,
                (-1, 1) => y < -x
                    ? atanRightNeg - AtanP3_2555_691Detail(AtanDiv(x, y))
                    : AtanP3_2555_691Detail(AtanDiv(y, x)),
                (0, -1) => atanStraight,
                (1, -1) => -y < x
                    ? atanRight - AtanP3_2555_691Detail(AtanDiv(x, y))
                    : atanStraight + AtanP3_2555_691Detail(AtanDiv(y, x)),
                (1, 0) => atanRight,
                (1, 1) => y < x
                    ? AtanP3_2555_691Detail(AtanDiv(y, x))
                    : atanRight - AtanP3_2555_691Detail(AtanDiv(x, y)),
                _ => 0,
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int AtanP5_787_2968Detail(int x) {
            const int a = 787;
            const int b = 2968;
            const int c = (1 << 13) + b - a;
            var x2 = (x * x) >> 15;
            return (c - ((b - (a * x2 >> 15)) * x2 >> 15)) * x;
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var x = (1 << 15) * 2 / 3;
        /// var actual = Intar.Mathematics.Math.AtanP5_787_2968(x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = actual * System.Math.PI / (1 << 30);
        /// Assert.AreEqual(expected, a, 0.000767);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int AtanP5_787_2968(int x) {
            return (x < atanOneNeg, x > atanOne) switch {
                (true, _) => atanRightNeg - AtanP5_787_2968Detail(AtanInv(x)),
                (_, true) => atanRight - AtanP5_787_2968Detail(AtanInv(x)),
                _ => AtanP5_787_2968Detail(x),
            };
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var y = 2;
        /// var x = 3;
        /// var actual = Intar.Mathematics.Math.Atan2P5_787_2968(y, x);
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
        public static int Atan2P5_787_2968(int y, int x) {
            return (System.Math.Sign(y), System.Math.Sign(x)) switch {
                (-1, -1) => y < x
                    ? atanRightNeg - AtanP5_787_2968Detail(AtanDiv(x, y))
                    : AtanP5_787_2968Detail(AtanDiv(y, x)) - atanStraight,
                (-1, 0) => atanRightNeg,
                (-1, 1) => y < -x
                    ? atanRightNeg - AtanP5_787_2968Detail(AtanDiv(x, y))
                    : AtanP5_787_2968Detail(AtanDiv(y, x)),
                (0, -1) => atanStraight,
                (1, -1) => -y < x
                    ? atanRight - AtanP5_787_2968Detail(AtanDiv(x, y))
                    : atanStraight + AtanP5_787_2968Detail(AtanDiv(y, x)),
                (1, 0) => atanRight,
                (1, 1) => y < x
                    ? AtanP5_787_2968Detail(AtanDiv(y, x))
                    : atanRight - AtanP5_787_2968Detail(AtanDiv(x, y)),
                _ => 0,
            };
        }
    }
}
