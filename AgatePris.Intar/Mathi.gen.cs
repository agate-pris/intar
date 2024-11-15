using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static class Mathi {
        const decimal Pi = 3.1415926535897932384626433833m;

        #region AbsDiff

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint AbsDiff(int x, int y) {
            unchecked {
                var ux = (uint)x;
                var uy = (uint)y;
                return (x < y)
                    ? Overflowing.WrappingSub(uy, ux)
                    : Overflowing.WrappingSub(ux, uy);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint AbsDiff(uint x, uint y) {
            return (x < y)
                ? y - x
                : x - y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong AbsDiff(long x, long y) {
            unchecked {
                var ux = (ulong)x;
                var uy = (ulong)y;
                return (x < y)
                    ? Overflowing.WrappingSub(uy, ux)
                    : Overflowing.WrappingSub(ux, uy);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong AbsDiff(ulong x, ulong y) {
            return (x < y)
                ? y - x
                : x - y;
        }

        // 128 ビット整数型に対する AbsDiff は .NET 7 以降のみ

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 AbsDiff(Int128 x, Int128 y) {
            unchecked {
                var ux = (UInt128)x;
                var uy = (UInt128)y;
                return (x < y)
                    ? Overflowing.WrappingSub(uy, ux)
                    : Overflowing.WrappingSub(ux, uy);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 AbsDiff(UInt128 x, UInt128 y) {
            return (x < y)
                ? y - x
                : x - y;
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region Asin / Acos

        internal static class AsinInternal {
            const decimal Frac2Pi = 2 / Pi;
            const decimal Z32 = Frac2Pi * (1UL << 31);
            const decimal Z64 = Frac2Pi * (1UL << 63);

            // 4294782660
            // 2319904613
            // 3248783419
            // 3277490973
            // 18445951068606135392
            // 9963914441109755535
            // 13953418538510380357
            // 14076716544798613906
            // 18446743817759831598
            // 10080617338130213281
            // 16718884102355766130
            // 9427600920570779471
            // 11608983047221464490
            // 12843229610990092589
            // 10026318940480150471
            // 15181969944445121899

            internal const uint P3U32A = (uint)(0.5m + (Z32 * (1 << 1) * 1.5707288m));
            internal const uint P3U32B = (uint)(0.5m + (Z32 * (1 << 3) * 0.2121144m));
            internal const uint P3U32C = (uint)(0.5m + (Z32 * (1 << 5) * 0.0742610m));
            internal const uint P3U32D = (uint)(0.0m + (Z32 * (1 << 7) * 0.0187293m));
            internal const ulong P3U64A = (ulong)(0.5m + (Z64 * (1 << 1) * 1.5707288m));
            internal const ulong P3U64B = (ulong)(0.5m + (Z64 * (1 << 3) * 0.2121144m));
            internal const ulong P3U64C = (ulong)(0.5m + (Z64 * (1 << 5) * 0.0742610m));
            internal const ulong P3U64D = (ulong)(0.0m + (Z64 * (1 << 7) * 0.0187293m));
            internal const ulong P7U64A = (ulong)(0.5m + (Z64 * 1.570_796_305_0m * (1 << 1)));
            internal const ulong P7U64B = (ulong)(0.5m + (Z64 * 0.214_598_801_6m * (1 << 3)));
            internal const ulong P7U64C = (ulong)(0.5m + (Z64 * 0.088_978_987_4m * (1 << 5)));
            internal const ulong P7U64D = (ulong)(0.5m + (Z64 * 0.050_174_304_6m * (1 << 5)));
            internal const ulong P7U64E = (ulong)(0.5m + (Z64 * 0.030_891_881_0m * (1 << 6)));
            internal const ulong P7U64F = (ulong)(0.5m + (Z64 * 0.017_088_125_6m * (1 << 7)));
            internal const ulong P7U64G = (ulong)(0.5m + (Z64 * 0.006_670_090_1m * (1 << 8)));
            internal const ulong P7U64H = (ulong)(0.0m + (Z64 * 0.001_262_491_1m * (1 << 11)));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static uint P3(uint x) {
                var y = 1U << (15 + 7 - 5);
                y = (P3U32D + (y / 2)) >> (15 + 7 - 5);
                y = (P3U32C - (y * x)) >> (15 + 5 - 3);
                y = (P3U32B - (y * x)) >> (15 + 3 - 1);
                y = (P3U32A - (y * x)) >> (15 + 1 + 1);
                const uint one = 1U << 15;
                return Sqrt(one * (one - x)) * y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static ulong P3(ulong x) {
                var y = 1UL << (31 + 7 - 5);
                y = (P3U64D + (y / 2)) >> (31 + 7 - 5);
                y = (P3U64C - (y * x)) >> (31 + 5 - 3);
                y = (P3U64B - (y * x)) >> (31 + 3 - 1);
                y = (P3U64A - (y * x)) >> (31 + 1 + 1);
                const ulong one = 1UL << 31;
                return Sqrt(one * (one - x)) * y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static ulong P7(ulong x) {
                var y = 1UL << (31 + 11 - 8);
                y = (P7U64H + (y / 2)) >> (31 + 11 - 8);
                y = (P7U64G - (y * x)) >> (31 + 8 - 7);
                y = (P7U64F - (y * x)) >> (31 + 7 - 6);
                y = (P7U64E - (y * x)) >> (31 + 6 - 5);
                y = (P7U64D - (y * x)) >> (31 + 5 - 5);
                y = (P7U64C - (y * x)) >> (31 + 5 - 3);
                y = (P7U64B - (y * x)) >> (31 + 3 - 1);
                y = (P7U64A - (y * x)) >> (31 + 1 + 1);
                const ulong one = 1UL << 31;
                return Sqrt(one * (one - x)) * y;
            }
        }

        /// <summary>
        /// 逆余弦を近似する｡
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とする余弦</param>
        /// <returns>0 以上 π 以下の､ π を 2 の 31 乗で表した角度｡</returns>
        /// <remarks>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>このメソッドは引数 <c>x</c> が範囲外 (-1 に相当する値未満または 1 に相当する値より大きい値) の場合､ 誤った値を返します｡</para>
        /// </div>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>このメソッドは引数 <c>x</c> が範囲外 (-1 に相当する値未満または 1 に相当する値より大きい値) の場合､ 例外を送出する場合があります｡</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint AcosP3(int x) {
            const uint pi = 1U << 31;
            switch (Math.Sign(x)) {
                case 0: return pi / 2;
                case 1: return AsinInternal.P3((uint)x);
                default: return pi - AsinInternal.P3((uint)-x);
            }
        }

        /// <summary>
        /// 逆正弦を近似する｡
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とする正弦</param>
        /// <returns>0 以上 π 以下の､ π を 2 の 31 乗で表した角度｡</returns>
        /// <remarks>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>このメソッドは引数 <c>x</c> が範囲外 (-1 に相当する値未満または 1 に相当する値より大きい値) の場合､ 誤った値を返します｡</para>
        /// </div>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>このメソッドは引数 <c>x</c> が範囲外 (-1 に相当する値未満または 1 に相当する値より大きい値) の場合､ 例外を送出する場合があります｡</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int AsinP3(int x) {
            const int fracPi2 = 1 << 30;
            switch (Math.Sign(x)) {
                case 0: return 0;
                case 1: return fracPi2 - (int)AsinInternal.P3((uint)x);
                default: return (int)AsinInternal.P3((uint)-x) - fracPi2;
            }
        }

        /// <summary>
        /// 逆余弦を近似する｡
        /// </summary>
        /// <param name="x">2 の 31 乗を 1 とする余弦</param>
        /// <returns>0 以上 π 以下の､ π を 2 の 63 乗で表した角度｡</returns>
        /// <remarks>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>このメソッドは引数 <c>x</c> が範囲外 (-1 に相当する値未満または 1 に相当する値より大きい値) の場合､ 誤った値を返します｡</para>
        /// </div>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>このメソッドは引数 <c>x</c> が範囲外 (-1 に相当する値未満または 1 に相当する値より大きい値) の場合､ 例外を送出する場合があります｡</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong AcosP3(long x) {
            const ulong pi = 1UL << 63;
            switch (Math.Sign(x)) {
                case 0: return pi / 2;
                case 1: return AsinInternal.P3((ulong)x);
                default: return pi - AsinInternal.P3((ulong)-x);
            }
        }

        /// <summary>
        /// 逆正弦を近似する｡
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とする正弦</param>
        /// <returns>0 以上 π 以下の､ π を 2 の 31 乗で表した角度｡</returns>
        /// <remarks>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>このメソッドは引数 <c>x</c> が範囲外 (-1 に相当する値未満または 1 に相当する値より大きい値) の場合､ 誤った値を返します｡</para>
        /// </div>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>このメソッドは引数 <c>x</c> が範囲外 (-1 に相当する値未満または 1 に相当する値より大きい値) の場合､ 例外を送出する場合があります｡</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long AsinP3(long x) {
            const long fracPi2 = 1L << 62;
            switch (Math.Sign(x)) {
                case 0: return 0;
                case 1: return fracPi2 - (long)AsinInternal.P3((ulong)x);
                default: return (long)AsinInternal.P3((ulong)-x) - fracPi2;
            }
        }

        /// <summary>
        /// 逆余弦を近似する｡
        /// </summary>
        /// <param name="x">2 の 31 乗を 1 とする余弦</param>
        /// <returns>0 以上 π 以下の､ π を 2 の 63 乗で表した角度｡</returns>
        /// <remarks>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>このメソッドは引数 <c>x</c> が範囲外 (-1 に相当する値未満または 1 に相当する値より大きい値) の場合､ 誤った値を返します｡</para>
        /// </div>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>このメソッドは引数 <c>x</c> が範囲外 (-1 に相当する値未満または 1 に相当する値より大きい値) の場合､ 例外を送出する場合があります｡</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong AcosP7(long x) {
            const ulong pi = 1UL << 63;
            switch (Math.Sign(x)) {
                case 0: return pi / 2;
                case 1: return AsinInternal.P7((ulong)x);
                default: return pi - AsinInternal.P7((ulong)-x);
            }
        }

        /// <summary>
        /// 逆正弦を近似する｡
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とする正弦</param>
        /// <returns>0 以上 π 以下の､ π を 2 の 31 乗で表した角度｡</returns>
        /// <remarks>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>このメソッドは引数 <c>x</c> が範囲外 (-1 に相当する値未満または 1 に相当する値より大きい値) の場合､ 誤った値を返します｡</para>
        /// </div>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>このメソッドは引数 <c>x</c> が範囲外 (-1 に相当する値未満または 1 に相当する値より大きい値) の場合､ 例外を送出する場合があります｡</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long AsinP7(long x) {
            const long fracPi2 = 1L << 62;
            switch (Math.Sign(x)) {
                case 0: return 0;
                case 1: return fracPi2 - (long)AsinInternal.P7((ulong)x);
                default: return (long)AsinInternal.P7((ulong)-x) - fracPi2;
            }
        }

        #endregion

        #region Atan

        internal static class AtanInternal {
            // Round(K * Inv(a / K))
            // = Round(K * (K / a))
            // = Round(K^2 / a)
            // = Trunc(K^2 / a + 0.5 * Signum(a))
            // = Trunc(((K^2 * 2) / a + Signum(a)) / 2)
            // = Trunc(((K^2 * 2 + Abs(a)) / (a * 2)))
            // = Trunc(((K^2 * 2 + Abs(a)) / (Abs(a) * 2))) * Signum(a)

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int Inv(int x) {
                const long k = 1L << 31;
                var xl = (long)x;
                return (int)((k + Math.Abs(xl)) / (xl << 1));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static long Inv(long x) {
                if (x == long.MinValue) {
                    return -1;
                }
                var abs = (ulong)Math.Abs(x);
                const ulong k = 1UL << (1 + (2 * 31));
                return (long)((k + abs) / (2 * abs)) * Math.Sign(x);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int Div(int a, int b) {
                var al = ((long)a) << 16;
                var bl = (long)b;
                return (int)((al + (Math.Sign(a) * Math.Abs(bl))) / (bl << 1));
            }

            const decimal Z1 = (1UL << 31) / Pi;
            const decimal Z2 = (1UL << 63) / Pi;

            // 2147483648
            // 2147483648
            // 9223372036854775808
            // 9223372036854775808
            // 2985813123
            // 2676294767
            // 2900504177
            // 12823969718335781357
            // 11494598498449691202
            // 12457570583526187604
            // 11741988375818245753
            // 15515570644620693826
            // 16923976036855135454
            // 15996234637818023067
            // 15659410489582290881

            const uint P2U32A = 1U << 31;
            const uint P3U32A = 1U << 31;
            const ulong P2U64A = 1UL << 63;
            const ulong P3U64A = 1UL << 63;
            internal const uint P2U32B = (uint)(0.0m + (Z1 * (1U << 4) * 0.273m));
            internal const uint P3U32B = (uint)(0.5m + (Z1 * (1U << 4) * 0.2447m));
            internal const uint P3U32C = (uint)(0.0m + (Z1 * (1U << 6) * 0.0663m));
            internal const ulong P2U64B = (ulong)(0.0m + (Z2 * (1UL << 4) * 0.273m));
            internal const ulong P3U64B = (ulong)(0.5m + (Z2 * (1UL << 4) * 0.2447m));
            internal const ulong P3U64C = (ulong)(0.0m + (Z2 * (1UL << 6) * 0.0663m));
            internal const ulong P9U64A = (ulong)(0.5m + (Z2 * (1UL << 2) * 0.999_866_0m));
            internal const ulong P9U64B = (ulong)(0.5m + (Z2 * (1UL << 4) * 0.330_299_5m));
            internal const ulong P9U64C = (ulong)(0.5m + (Z2 * (1UL << 5) * 0.180_141_0m));
            internal const ulong P9U64D = (ulong)(0.5m + (Z2 * (1UL << 6) * 0.085_133_0m));
            internal const ulong P9U64E = (ulong)(0.0m + (Z2 * (1UL << 8) * 0.020_835_1m));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P2(int x) {
                const uint one = 1U << 15;
                var w = (uint)Math.Abs(x);
                var z = one - w;
                var y = 1U << (15 + 2);
                y = (P2U32B + (y / 2)) >> (15 + 2);
                y = (P2U32A + (z * y)) >> (15 + 3);
                return (int)y * x;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P3(int x) {
                const uint one = 1U << 15;
                var w = (uint)Math.Abs(x);
                var z = one - w;
                var y = 1U << (15 + 6 - 4);
                y = (P3U32C + (y / 2)) >> (15 + 6 - 4);
                y = (P3U32B + (y * w)) >> (15 + 4 - 2);
                y = (P3U32A + (z * y)) >> (15 + 3);
                return (int)y * x;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static long P2(long x) {
                const ulong one = 1UL << 31;
                var w = (ulong)Math.Abs(x);
                var z = one - w;
                var y = 1UL << (31 + 2);
                y = (P2U64B + (y / 2)) >> (31 + 2);
                y = (P2U64A + (z * y)) >> (31 + 3);
                return (long)y * x;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static long P3(long x) {
                const ulong one = 1UL << 31;
                var w = (ulong)Math.Abs(x);
                var z = one - w;
                var y = 1UL << (31 + 6 - 4);
                y = (P3U64C + (y / 2)) >> (31 + 6 - 4);
                y = (P3U64B + (y * w)) >> (31 + 4 - 2);
                y = (P3U64A + (z * y)) >> (31 + 3);
                return (long)y * x;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static long P9(long x) {
                var z = (ulong)(x * x) >> 31;
                var y = 1UL << (31 + 8 - 6);
                y = (P9U64E + (y / 2)) >> (31 + 8 - 6);
                y = (P9U64D - (y * z)) >> (31 + 6 - 5);
                y = (P9U64C - (y * z)) >> (31 + 5 - 4);
                y = (P9U64B - (y * z)) >> (31 + 4 - 2);
                y = (P9U64A - (y * z)) >> (31 + 3);
                return (long)y * x;
            }
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// const int toRad = System.Math.PI / (1 &lt;&lt; 30);
        /// var x = k * 2 / 3;
        /// var actual = Intar.Mathi.AtanP2(x);
        /// var expected = System.Math.Atan((double)x / k);
        /// Assert.AreEqual(expected, actual * toRad, 0.0039);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int AtanP2(int x) {
            const int one = 1 << 15;
            const int oneNeg = -one;
            const int right = 1 << 29;
            const int rightNeg = -right;
            if (x < oneNeg) {
                return rightNeg - AtanInternal.P2(AtanInternal.Inv(x));
            } else if (x > one) {
                return right - AtanInternal.P2(AtanInternal.Inv(x));
            } else {
                return AtanInternal.P2(x);
            }
        }

        /// <summary>
        /// 3 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// const int toRad = System.Math.PI / (1 &lt;&lt; 30);
        /// var x = k * 2 / 3;
        /// var actual = Intar.Mathi.AtanP3(x);
        /// var expected = System.Math.Atan((double)x / k);
        /// Assert.AreEqual(expected, actual * toRad, 0.0016);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int AtanP3(int x) {
            const int one = 1 << 15;
            const int oneNeg = -one;
            const int right = 1 << 29;
            const int rightNeg = -right;
            if (x < oneNeg) {
                return rightNeg - AtanInternal.P3(AtanInternal.Inv(x));
            } else if (x > one) {
                return right - AtanInternal.P3(AtanInternal.Inv(x));
            } else {
                return AtanInternal.P3(x);
            }
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// const long k = 1L &lt;&lt; 31;
        /// const long toRad = System.Math.PI / (1L &lt;&lt; 62);
        /// var x = k * 2 / 3;
        /// var actual = Intar.Mathi.AtanP2(x);
        /// var expected = System.Math.Atan((double)x / k);
        /// Assert.AreEqual(expected, actual * toRad, 0.0039);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を 1 とするタンジェント</param>
        /// <returns>2 の 62 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long AtanP2(long x) {
            const long one = 1L << 31;
            const long oneNeg = -one;
            const long right = 1L << 61;
            const long rightNeg = -right;
            if (x < oneNeg) {
                return rightNeg - AtanInternal.P2(AtanInternal.Inv(x));
            } else if (x > one) {
                return right - AtanInternal.P2(AtanInternal.Inv(x));
            } else {
                return AtanInternal.P2(x);
            }
        }

        /// <summary>
        /// 3 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// const long k = 1L &lt;&lt; 31;
        /// const long toRad = System.Math.PI / (1L &lt;&lt; 62);
        /// var x = k * 2 / 3;
        /// var actual = Intar.Mathi.AtanP3(x);
        /// var expected = System.Math.Atan((double)x / k);
        /// Assert.AreEqual(expected, actual * toRad, 0.0016);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を 1 とするタンジェント</param>
        /// <returns>2 の 62 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long AtanP3(long x) {
            const long one = 1L << 31;
            const long oneNeg = -one;
            const long right = 1L << 61;
            const long rightNeg = -right;
            if (x < oneNeg) {
                return rightNeg - AtanInternal.P3(AtanInternal.Inv(x));
            } else if (x > one) {
                return right - AtanInternal.P3(AtanInternal.Inv(x));
            } else {
                return AtanInternal.P3(x);
            }
        }

        /// <summary>
        /// 9 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// const long k = 1L &lt;&lt; 31;
        /// const long toRad = System.Math.PI / (1L &lt;&lt; 62);
        /// var x = k * 2 / 3;
        /// var actual = Intar.Mathi.AtanP9(x);
        /// var expected = System.Math.Atan((double)x / k);
        /// Assert.AreEqual(expected, actual * toRad, 0.00002);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を 1 とするタンジェント</param>
        /// <returns>2 の 62 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long AtanP9(long x) {
            const long one = 1L << 31;
            const long oneNeg = -one;
            const long right = 1L << 61;
            const long rightNeg = -right;
            if (x < oneNeg) {
                return rightNeg - AtanInternal.P9(AtanInternal.Inv(x));
            } else if (x > one) {
                return right - AtanInternal.P9(AtanInternal.Inv(x));
            } else {
                return AtanInternal.P9(x);
            }
        }

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var actual = Intar.Mathi.Atan2P2(2, 3);
        /// var expected = System.Math.Atan2(2, 3);
        /// Assert.AreEqual(expected, actual * toRad, 0.004);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Atan2P2(int y, int x) {
            const int straight = 1 << 30;
            const int right = straight / 2;
            const int rightNeg = -right;
            if (y < 0) {
                if (x < 0) {
                    return y < x
                        ? rightNeg - AtanInternal.P2(AtanInternal.Div(x, y))
                        : AtanInternal.P2(AtanInternal.Div(y, x)) - straight;
                } else if (x > 0) {
                    return y < -x
                        ? rightNeg - AtanInternal.P2(AtanInternal.Div(x, y))
                        : AtanInternal.P2(AtanInternal.Div(y, x));
                } else {
                    return rightNeg;
                }
            } else if (y > 0) {
                if (x < 0) {
                    return -y < x
                        ? right - AtanInternal.P2(AtanInternal.Div(x, y))
                        : straight + AtanInternal.P2(AtanInternal.Div(y, x));
                } else if (x > 0) {
                    return y > x
                        ? right - AtanInternal.P2(AtanInternal.Div(x, y))
                        : AtanInternal.P2(AtanInternal.Div(y, x));
                } else {
                    return right;
                }
            } else {
                return x < 0 ? straight : 0;
            }
        }

        /// <summary>
        /// 3 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var actual = Intar.Mathi.Atan2P3(2, 3);
        /// var expected = System.Math.Atan2(2, 3);
        /// Assert.AreEqual(expected, actual * toRad, 0.0017);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Atan2P3(int y, int x) {
            const int straight = 1 << 30;
            const int right = straight / 2;
            const int rightNeg = -right;
            if (y < 0) {
                if (x < 0) {
                    return y < x
                        ? rightNeg - AtanInternal.P3(AtanInternal.Div(x, y))
                        : AtanInternal.P3(AtanInternal.Div(y, x)) - straight;
                } else if (x > 0) {
                    return y < -x
                        ? rightNeg - AtanInternal.P3(AtanInternal.Div(x, y))
                        : AtanInternal.P3(AtanInternal.Div(y, x));
                } else {
                    return rightNeg;
                }
            } else if (y > 0) {
                if (x < 0) {
                    return -y < x
                        ? right - AtanInternal.P3(AtanInternal.Div(x, y))
                        : straight + AtanInternal.P3(AtanInternal.Div(y, x));
                } else if (x > 0) {
                    return y > x
                        ? right - AtanInternal.P3(AtanInternal.Div(x, y))
                        : AtanInternal.P3(AtanInternal.Div(y, x));
                } else {
                    return right;
                }
            } else {
                return x < 0 ? straight : 0;
            }
        }

        /// <summary>
        /// 9 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var actual = Intar.Mathi.Atan2P9(2, 3);
        /// var expected = System.Math.Atan2(2, 3);
        /// Assert.AreEqual(expected, actual * toRad, 0.00003);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の 62 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Atan2P9(int y, int x) {
            const long straight = 1L << 62;
            const long right = straight / 2;
            const long rightNeg = -right;
            if (y < 0) {
                if (x < 0) {
                    return y < x
                        ? rightNeg - AtanInternal.P9((long)AtanInternal.Div(x, y) << 16)
                        : AtanInternal.P9((long)AtanInternal.Div(y, x) << 16) - straight;
                } else if (x > 0) {
                    return y < -x
                        ? rightNeg - AtanInternal.P9((long)AtanInternal.Div(x, y) << 16)
                        : AtanInternal.P9((long)AtanInternal.Div(y, x) << 16);
                } else {
                    return rightNeg;
                }
            } else if (y > 0) {
                if (x < 0) {
                    return -y < x
                        ? right - AtanInternal.P9((long)AtanInternal.Div(x, y) << 16)
                        : straight + AtanInternal.P9((long)AtanInternal.Div(y, x) << 16);
                } else if (x > 0) {
                    return y > x
                        ? right - AtanInternal.P9((long)AtanInternal.Div(x, y) << 16)
                        : AtanInternal.P9((long)AtanInternal.Div(y, x) << 16);
                } else {
                    return right;
                }
            } else {
                return x < 0 ? straight : 0;
            }
        }

        #endregion

        #region Clamp

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

        // 128 ビット整数値型については代わりに INumber.Clamp を使うこと

        #endregion

        #region Half

        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal static int Half(int x) => x / 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal static uint Half(uint x) => x / 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal static long Half(long x) => x / 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal static ulong Half(ulong x) => x / 2;

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal static Int128 Half(Int128 x) => x / 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal static UInt128 Half(UInt128 x) => x / 2;

#endif // NET7_0_OR_GREATER

        #endregion

        #region Sin / Cos

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

            const decimal Z32 = 1UL << 31;
            const decimal Z64 = 1UL << 63;
            const decimal K01 = Pi / 2;
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

            // 14488038916154245685
            // 11915934368436992009
            // 11760553260076371255
            // 11054273349336558994
            // 12108815703571716367
            // 16602603363585481494
            // 11378879071774596408
            // 9358747397805171131
            // 12315189113921640896
            // 17335849242745400440
            // 14400453044121993745
            // 14488038916154245685
            // 11871845430268727827
            // 10739739599844454195
            // 11303778553548845368
            // 16643606305160959259
            // 3373259426
            // 2764129413
            // 2500540483
            // 2631866036
            // 3875141568

            internal const ulong P11I64A = (ulong)(0.5m + (1.000_000_000_0m * K01 * Z64));
            internal const ulong P11I64B = (ulong)(0.5m + (0.166_666_666_4m * K03 * Z64 * (1 << 1)));
            internal const ulong P11I64C = (ulong)(0.5m + (0.008_333_331_5m * K05 * Z64 * (1 << 4)));
            internal const ulong P11I64D = (ulong)(0.5m + (0.000_198_409_0m * K07 * Z64 * (1 << 8)));
            internal const ulong P11I64E = (ulong)(0.5m + (0.000_002_752_6m * K09 * Z64 * (1 << 13)));
            internal const ulong P11I64F = (ulong)(0.0m + (0.000_000_023_9m * K11 * Z64 * (1 << 19)));
            internal const ulong P10I64A = (ulong)(0.5m + (0.499_999_996_3m * K02 * Z64));
            internal const ulong P10I64B = (ulong)(0.5m + (0.041_666_641_8m * K04 * Z64 * (1 << 2)));
            internal const ulong P10I64C = (ulong)(0.5m + (0.001_388_839_7m * K06 * Z64 * (1 << 6)));
            internal const ulong P10I64D = (ulong)(0.5m + (0.000_024_760_9m * K08 * Z64 * (1 << 11)));
            internal const ulong P10I64E = (ulong)(0.0m + (0.000_000_260_5m * K10 * Z64 * (1 << 16)));
            internal const ulong P5I64A = (ulong)(0.5m + (1.00000m * K01 * Z64));
            internal const ulong P5I64B = (ulong)(0.5m + (0.16605m * K03 * Z64 * (1 << 1)));
            internal const ulong P5I64C = (ulong)(0.0m + (0.00761m * K05 * Z64 * (1 << 4)));
            internal const ulong P4I64A = (ulong)(0.5m + (0.49670m * K02 * Z64));
            internal const ulong P4I64B = (ulong)(0.0m + (0.03705m * K04 * Z64 * (1 << 3)));
            internal const uint P5I32A = (uint)(0.5m + (1.00000m * K01 * Z32));
            internal const uint P5I32B = (uint)(0.5m + (0.16605m * K03 * Z32 * (1 << 1)));
            internal const uint P5I32C = (uint)(0.0m + (0.00761m * K05 * Z32 * (1 << 4)));
            internal const uint P4I32A = (uint)(0.5m + (0.49670m * K02 * Z32));
            internal const uint P4I32B = (uint)(0.0m + (0.03705m * K04 * Z32 * (1 << 3)));

            // 精度に対して与える影響が軽微であるため､
            // 乗算前に一度にまとめてビットシフトを行う｡

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static ulong P11(ulong z) {
                var y = 1UL;
                y = P11I64F + ((y << (31 + 6)) / 2);
                y = P11I64E - ((y >> (31 + 6)) * z);
                y = P11I64D - ((y >> (31 + 5)) * z);
                y = P11I64C - ((y >> (31 + 4)) * z);
                y = P11I64B - ((y >> (31 + 3)) * z);
                y = P11I64A - ((y >> (31 + 1)) * z);
                return y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static ulong P10(ulong z) {
                var y = 1UL;
                y = P10I64E + ((y << (31 + 5)) / 2);
                y = P10I64D - ((y >> (31 + 5)) * z);
                y = P10I64C - ((y >> (31 + 5)) * z);
                y = P10I64B - ((y >> (31 + 4)) * z);
                y = P10I64A - ((y >> (31 + 2)) * z);
                return (y >> 32) * z;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static ulong P3(ulong z) {
                const ulong a = (1UL << 62) * 3;
                const ulong b = (1UL << 62) * 2;
                return a - ((b >> 32) * z);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static ulong P5(ulong z) {
                var y = 1UL;
                y = P5I64C + ((y << (31 + 3)) / 2);
                y = P5I64B - ((y >> (31 + 3)) * z);
                y = P5I64A - ((y >> (31 + 1)) * z);
                return y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static ulong P4(ulong z) {
                var y = 1UL;
                y = P4I64B + ((y << (31 + 3)) / 2);
                y = P4I64A - ((y >> (31 + 3)) * z);
                return (y >> 32) * z;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static uint P3(uint z) {
                const uint a = (1U << 30) * 3;
                const uint b = (1U << 30) * 2;
                return a - ((b >> 16) * z);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static uint P5(uint z) {
                var y = 1U;
                y = P5I32C + ((y << (15 + 3)) / 2);
                y = P5I32B - ((y >> (15 + 3)) * z);
                y = P5I32A - ((y >> (15 + 1)) * z);
                return y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static uint P4(uint z) {
                var y = 1U;
                y = P4I32B + ((y << (15 + 3)) / 2);
                y = P4I32A - ((y >> (15 + 3)) * z);
                return (y >> 16) * z;
            }
        }

        /// <summary>
        /// 2 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// const long k = 1L &lt;&lt; 31;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.CosP2(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Cos(rad);
        /// var a = (double)actual / (1L &lt;&lt; 62);
        /// Assert.AreEqual(expected, a, 0.06);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を直角とする角度</param>
        /// <returns>2 の 62 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long CosP2(long x) {
            const long fracPi2 = 1L << 31;
            const long one = 1L << 62;
            var q = SinInternal.ToQuadrant(x);
            x &= fracPi2 - 1;
            switch (q) {
                default:
                case SinInternal.Quadrant.First: return one - (x * x);
                case SinInternal.Quadrant.Third: return (x * x) - one;
                case SinInternal.Quadrant.Fourth: return one - ((fracPi2 - x) * (fracPi2 - x));
                case SinInternal.Quadrant.Second: return ((fracPi2 - x) * (fracPi2 - x)) - one;
            }
        }

        /// <summary>
        /// 2 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// const long k = 1L &lt;&lt; 31;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.SinP2(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Sin(rad);
        /// var a = (double)actual / (1L &lt;&lt; 62);
        /// Assert.AreEqual(expected, a, 0.06);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を直角とする角度</param>
        /// <returns>2 の 62 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long SinP2(long x) => CosP2(Overflowing.WrappingSub(x, 1L << 31));

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
        /// Assert.AreEqual(expected, a, 0.06);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CosP2(int x) {
            const int fracPi2 = 1 << 15;
            const int one = 1 << 30;
            var q = SinInternal.ToQuadrant(x);
            x &= fracPi2 - 1;
            switch (q) {
                default:
                case SinInternal.Quadrant.First: return one - (x * x);
                case SinInternal.Quadrant.Third: return (x * x) - one;
                case SinInternal.Quadrant.Fourth: return one - ((fracPi2 - x) * (fracPi2 - x));
                case SinInternal.Quadrant.Second: return ((fracPi2 - x) * (fracPi2 - x)) - one;
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
        /// Assert.AreEqual(expected, a, 0.06);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SinP2(int x) => CosP2(Overflowing.WrappingSub(x, 1 << 15));

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// const long k = 1L &lt;&lt; 31;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.CosP4(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Cos(rad);
        /// var a = (double)actual / (1L &lt;&lt; 62);
        /// Assert.AreEqual(expected, a, 0.0018);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を直角とする角度</param>
        /// <returns>2 の 62 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long CosP4(long x) {
            const long fracPi2 = 1L << 31;
            const long one = 1L << 62;
            var q = SinInternal.ToQuadrant(x);
            x &= fracPi2 - 1;
            switch (q) {
                default:
                case SinInternal.Quadrant.First: return one - (long)SinInternal.P4((ulong)(x * x) >> 31);
                case SinInternal.Quadrant.Third: return (long)SinInternal.P4((ulong)(x * x) >> 31) - one;
                case SinInternal.Quadrant.Fourth: return one - (long)SinInternal.P4((ulong)((fracPi2 - x) * (fracPi2 - x)) >> 31);
                case SinInternal.Quadrant.Second: return (long)SinInternal.P4((ulong)((fracPi2 - x) * (fracPi2 - x)) >> 31) - one;
            }
        }

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// const long k = 1L &lt;&lt; 31;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.SinP4(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Sin(rad);
        /// var a = (double)actual / (1L &lt;&lt; 62);
        /// Assert.AreEqual(expected, a, 0.0018);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を直角とする角度</param>
        /// <returns>2 の 62 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long SinP4(long x) => CosP4(Overflowing.WrappingSub(x, 1L << 31));

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
            const int fracPi2 = 1 << 15;
            const int one = 1 << 30;
            var q = SinInternal.ToQuadrant(x);
            x &= fracPi2 - 1;
            switch (q) {
                default:
                case SinInternal.Quadrant.First: return one - (int)SinInternal.P4((uint)(x * x) >> 15);
                case SinInternal.Quadrant.Third: return (int)SinInternal.P4((uint)(x * x) >> 15) - one;
                case SinInternal.Quadrant.Fourth: return one - (int)SinInternal.P4((uint)((fracPi2 - x) * (fracPi2 - x)) >> 15);
                case SinInternal.Quadrant.Second: return (int)SinInternal.P4((uint)((fracPi2 - x) * (fracPi2 - x)) >> 15) - one;
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
            const long fracPi2 = 1L << 31;
            const long one = 1L << 62;
            var q = SinInternal.ToQuadrant(x);
            x &= fracPi2 - 1;
            switch (q) {
                default:
                case SinInternal.Quadrant.First: return one - (long)SinInternal.P10((ulong)(x * x) >> 31);
                case SinInternal.Quadrant.Third: return (long)SinInternal.P10((ulong)(x * x) >> 31) - one;
                case SinInternal.Quadrant.Fourth: return one - (long)SinInternal.P10((ulong)((fracPi2 - x) * (fracPi2 - x)) >> 31);
                case SinInternal.Quadrant.Second: return (long)SinInternal.P10((ulong)((fracPi2 - x) * (fracPi2 - x)) >> 31) - one;
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
        /// 3 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// const long k = 1L &lt;&lt; 31;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.SinP3(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Sin(rad);
        /// var a = (double)actual / (1L &lt;&lt; 62);
        /// Assert.AreEqual(expected, a, 0.0004);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を直角とする角度</param>
        /// <returns>2 の 62 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long SinP3(long x) {
            x = SinInternal.MakeArgOdd(x);
            return x * (long)(SinInternal.P3((ulong)(x * x) >> 31) >> 32);
        }

        /// <summary>
        /// 3 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// const long k = 1L &lt;&lt; 31;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.CosP3(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Cos(rad);
        /// var a = (double)actual / (1L &lt;&lt; 62);
        /// Assert.AreEqual(expected, a, 0.0004);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を直角とする角度</param>
        /// <returns>2 の 62 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long CosP3(long x) => SinP3(Overflowing.WrappingAdd(x, 1L << 31));

        /// <summary>
        /// 3 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.SinP3(x);
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
        public static int SinP3(int x) {
            x = SinInternal.MakeArgOdd(x);
            return x * (int)(SinInternal.P3((uint)(x * x) >> 15) >> 16);
        }

        /// <summary>
        /// 3 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.CosP3(x);
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
        public static int CosP3(int x) => SinP3(Overflowing.WrappingAdd(x, 1 << 15));

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// const long k = 1L &lt;&lt; 31;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.SinP5(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Sin(rad);
        /// var a = (double)actual / (1L &lt;&lt; 62);
        /// Assert.AreEqual(expected, a, 0.0004);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を直角とする角度</param>
        /// <returns>2 の 62 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long SinP5(long x) {
            x = SinInternal.MakeArgOdd(x);
            return x * (long)(SinInternal.P5((ulong)(x * x) >> 31) >> 32);
        }

        /// <summary>
        /// 5 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// const long k = 1L &lt;&lt; 31;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.CosP5(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.Cos(rad);
        /// var a = (double)actual / (1L &lt;&lt; 62);
        /// Assert.AreEqual(expected, a, 0.0004);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を直角とする角度</param>
        /// <returns>2 の 62 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long CosP5(long x) => SinP5(Overflowing.WrappingAdd(x, 1L << 31));

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
            return x * (int)(SinInternal.P5((uint)(x * x) >> 15) >> 16);
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
            return x * (long)(SinInternal.P11((ulong)(x * x) >> 31) >> 32);
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

        #endregion

        #region Sqrt

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

#if NET7_0_OR_GREATER

#pragma warning disable IDE0001
#pragma warning disable IDE0002

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static System.UInt128 Sqrt(System.UInt128 x) {
            if (x <= 1) {
                return x;
            }

            const int halfBits = 64;
            var k = halfBits - ((int)System.UInt128.LeadingZeroCount(x - 1) >> 1);
            var s = new System.UInt128(0, 1) << k;
            var t = (s + (x >> k)) >> 1;
            while (t < s) {
                s = t;
                t = (s + (x / s)) >> 1;
            }
            return s;
        }

#pragma warning restore IDE0002
#pragma warning restore IDE0001

#endif // NET7_0_OR_GREATER

        #endregion

        #region Twice

        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal static int Twice(int x) => x * 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal static uint Twice(uint x) => x * 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal static long Twice(long x) => x * 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal static ulong Twice(ulong x) => x * 2;

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal static Int128 Twice(Int128 x) => x * 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal static UInt128 Twice(UInt128 x) => x * 2;

#endif // NET7_0_OR_GREATER

        #endregion

        #region UnsignedAbs

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint UnsignedAbs(int x) {
            return unchecked((uint)Overflowing.WrappingAbs(x));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong UnsignedAbs(long x) {
            return unchecked((ulong)Overflowing.WrappingAbs(x));
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 UnsignedAbs(Int128 x) {
            return unchecked((UInt128)Overflowing.WrappingAbs(x));
        }

#endif // NET7_0_OR_GREATER

        #endregion

    }
}
