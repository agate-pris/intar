using System;
using System.Runtime.CompilerServices;

namespace Intar {
    public static class Mathi {
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
            internal const uint P3U32A = 4294782660U;
            internal const uint P3U32B = 2319904613U;
            internal const uint P3U32C = 3248783419U;
            internal const uint P3U32D = 25005U;
            internal const ulong P3U64A = 18445951068606135392UL;
            internal const ulong P3U64B = 9963914441109755535UL;
            internal const ulong P3U64C = 13953418538510380357UL;
            internal const ulong P3U64D = 1638745487U;
            internal const ulong P7U64A = 18446743817759831598UL;
            internal const ulong P7U64B = 10080617338130213281UL;
            internal const ulong P7U64C = 16718884102355766130UL;
            internal const ulong P7U64D = 9427600920570779471UL;
            internal const ulong P7U64E = 11608983047221464490UL;
            internal const ulong P7U64F = 12843229610990092589UL;
            internal const ulong P7U64G = 10026318940480150471UL;
            internal const ulong P7U64H = 883706959UL;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static uint P3(uint x) {
                var y = P3U32D;
                y = (P3U32C - (y * x)) >> (15 + 5 - 3);
                y = (P3U32B - (y * x)) >> (15 + 3 - 1);
                y = (P3U32A - (y * x)) >> (15 + 1 + 1);
                const uint one = 1U << 15;
                return Sqrt(one * (one - x)) * y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static ulong P3(ulong x) {
                var y = P3U64D;
                y = (P3U64C - (y * x)) >> (31 + 5 - 3);
                y = (P3U64B - (y * x)) >> (31 + 3 - 1);
                y = (P3U64A - (y * x)) >> (31 + 1 + 1);
                const ulong one = 1UL << 31;
                return Sqrt(one * (one - x)) * y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static ulong P7(ulong x) {
                var y = P7U64H;
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
        /// <param name="x">2 の 31 乗を 1 とする正弦</param>
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
        /// <param name="x">2 の 31 乗を 1 とする正弦</param>
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
                var sign = ((a < 0) == (b < 0)) ? 1 : -1;
                return (int)((al + (bl * sign)) / (bl << 1));
            }

#if NET7_0_OR_GREATER

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static long Div(long a, long b) {
                var al = ((Int128)a) << 32;
                var bl = (Int128)b;
                var sign = ((a < 0) == (b < 0)) ? 1 : -1;
                return (long)((al + (bl * sign)) / (bl << 1));
            }

#endif // NET7_0_OR_GREATER

            const uint P2U32A = 1U << 31;
            const uint P3U32A = 1U << 31;
            const ulong P2U64A = 1UL << 63;
            const ulong P3U64A = 1UL << 63;
            internal const uint P2U32B = 22780U;
            internal const uint P3U32B = 2676294767U;
            internal const uint P3U32C = 22129U;
            internal const ulong P2U64B = 1492906562UL;
            internal const ulong P3U64B = 11494598498449691202UL;
            internal const ulong P3U64C = 1450252089UL;
            internal const ulong P9U64A = 11741988375818245753UL;
            internal const ulong P9U64B = 15515570644620693826UL;
            internal const ulong P9U64C = 16923976036855135454UL;
            internal const ulong P9U64D = 15996234637818023067UL;
            internal const ulong P9U64E = 1822995312UL;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P2(int x) {
                const uint one = 1U << 15;
                var w = (uint)Math.Abs(x);
                var z = one - w;
                var y = P2U32B;
                y = (P2U32A + (z * y)) >> (15 + 3);
                return (int)y * x;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P3(int x) {
                const uint one = 1U << 15;
                var w = (uint)Math.Abs(x);
                var z = one - w;
                var y = P3U32C;
                y = (P3U32B + (y * w)) >> (15 + 4 - 2);
                y = (P3U32A + (z * y)) >> (15 + 3);
                return (int)y * x;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static long P2(long x) {
                const ulong one = 1UL << 31;
                var w = (ulong)Math.Abs(x);
                var z = one - w;
                var y = P2U64B;
                y = (P2U64A + (z * y)) >> (31 + 3);
                return (long)y * x;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static long P3(long x) {
                const ulong one = 1UL << 31;
                var w = (ulong)Math.Abs(x);
                var z = one - w;
                var y = P3U64C;
                y = (P3U64B + (y * w)) >> (31 + 4 - 2);
                y = (P3U64A + (z * y)) >> (31 + 3);
                return (long)y * x;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static long P9(long x) {
                var z = (ulong)(x * x) >> 31;
                var y = P9U64E;
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

            // AtanInternal.P2 と AtanInternal.P3 は
            // 0 < x かつ 0 < y かつ x = y の場合
            // 厳密に PI / 4 に相当する値を返すが,
            // ここでは AtanInternal.P9 とロジックを統一するため
            // 厳密に y と x が等しいか否かを調べる.
            // AtanInternal.P9 は厳密に PI / 4 に相当する値を返さないため,
            // 必ず y と x が等しいか否かを調べる必要がある.
            // if 文 1 つ分のオーバーヘッドは, これを許容する.
            // 高頻度で y = x になる場合, 計算量の削減が期待できるかもしれないが,
            // その削減分で if 文 1 つ分の増分を吸収できるかは不明.

            if (x < oneNeg) {
                return rightNeg - AtanInternal.P2(AtanInternal.Inv(x));
            } else if (x > one) {
                return right - AtanInternal.P2(AtanInternal.Inv(x));
            } else if (x == oneNeg) {
                return rightNeg / 2;
            } else if (x == one) {
                return right / 2;
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

            // AtanInternal.P2 と AtanInternal.P3 は
            // 0 < x かつ 0 < y かつ x = y の場合
            // 厳密に PI / 4 に相当する値を返すが,
            // ここでは AtanInternal.P9 とロジックを統一するため
            // 厳密に y と x が等しいか否かを調べる.
            // AtanInternal.P9 は厳密に PI / 4 に相当する値を返さないため,
            // 必ず y と x が等しいか否かを調べる必要がある.
            // if 文 1 つ分のオーバーヘッドは, これを許容する.
            // 高頻度で y = x になる場合, 計算量の削減が期待できるかもしれないが,
            // その削減分で if 文 1 つ分の増分を吸収できるかは不明.

            if (x < oneNeg) {
                return rightNeg - AtanInternal.P3(AtanInternal.Inv(x));
            } else if (x > one) {
                return right - AtanInternal.P3(AtanInternal.Inv(x));
            } else if (x == oneNeg) {
                return rightNeg / 2;
            } else if (x == one) {
                return right / 2;
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

            // AtanInternal.P2 と AtanInternal.P3 は
            // 0 < x かつ 0 < y かつ x = y の場合
            // 厳密に PI / 4 に相当する値を返すが,
            // ここでは AtanInternal.P9 とロジックを統一するため
            // 厳密に y と x が等しいか否かを調べる.
            // AtanInternal.P9 は厳密に PI / 4 に相当する値を返さないため,
            // 必ず y と x が等しいか否かを調べる必要がある.
            // if 文 1 つ分のオーバーヘッドは, これを許容する.
            // 高頻度で y = x になる場合, 計算量の削減が期待できるかもしれないが,
            // その削減分で if 文 1 つ分の増分を吸収できるかは不明.

            if (x < oneNeg) {
                return rightNeg - AtanInternal.P2(AtanInternal.Inv(x));
            } else if (x > one) {
                return right - AtanInternal.P2(AtanInternal.Inv(x));
            } else if (x == oneNeg) {
                return rightNeg / 2;
            } else if (x == one) {
                return right / 2;
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

            // AtanInternal.P2 と AtanInternal.P3 は
            // 0 < x かつ 0 < y かつ x = y の場合
            // 厳密に PI / 4 に相当する値を返すが,
            // ここでは AtanInternal.P9 とロジックを統一するため
            // 厳密に y と x が等しいか否かを調べる.
            // AtanInternal.P9 は厳密に PI / 4 に相当する値を返さないため,
            // 必ず y と x が等しいか否かを調べる必要がある.
            // if 文 1 つ分のオーバーヘッドは, これを許容する.
            // 高頻度で y = x になる場合, 計算量の削減が期待できるかもしれないが,
            // その削減分で if 文 1 つ分の増分を吸収できるかは不明.

            if (x < oneNeg) {
                return rightNeg - AtanInternal.P3(AtanInternal.Inv(x));
            } else if (x > one) {
                return right - AtanInternal.P3(AtanInternal.Inv(x));
            } else if (x == oneNeg) {
                return rightNeg / 2;
            } else if (x == one) {
                return right / 2;
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

            // AtanInternal.P2 と AtanInternal.P3 は
            // 0 < x かつ 0 < y かつ x = y の場合
            // 厳密に PI / 4 に相当する値を返すが,
            // ここでは AtanInternal.P9 とロジックを統一するため
            // 厳密に y と x が等しいか否かを調べる.
            // AtanInternal.P9 は厳密に PI / 4 に相当する値を返さないため,
            // 必ず y と x が等しいか否かを調べる必要がある.
            // if 文 1 つ分のオーバーヘッドは, これを許容する.
            // 高頻度で y = x になる場合, 計算量の削減が期待できるかもしれないが,
            // その削減分で if 文 1 つ分の増分を吸収できるかは不明.

            if (x < oneNeg) {
                return rightNeg - AtanInternal.P9(AtanInternal.Inv(x));
            } else if (x > one) {
                return right - AtanInternal.P9(AtanInternal.Inv(x));
            } else if (x == oneNeg) {
                return rightNeg / 2;
            } else if (x == one) {
                return right / 2;
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
        /// Assert.AreEqual(expected, actual * toRad, 0.0039);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Atan2P2(int y, int x) {
            const int pi = 1 << 30;
            const int pi_2 = pi / 2;
            const int pi_4 = pi / 4;
            const int negativePi_2 = -pi_2;

            // AtanInternal.P2 と AtanInternal.P3 は
            // 0 < x かつ 0 < y かつ x = y の場合
            // 厳密に PI / 4 に相当する値を返すが,
            // ここでは AtanInternal.P9 とロジックを統一するため
            // 厳密に y と x が等しいか否かを調べる.
            // AtanInternal.P9 は厳密に PI / 4 に相当する値を返さないため,
            // 必ず y と x が等しいか否かを調べる必要がある.
            // if 文 1 つ分のオーバーヘッドは, これを許容する.
            // 高頻度で y = x になる場合, 計算量の削減が期待できるかもしれないが,
            // その削減分で if 文 1 つ分の増分を吸収できるかは不明.

            if (y < 0) {
                if (x < 0) {
                    if (y < x) {
                        return negativePi_2 - AtanInternal.P2(AtanInternal.Div(x, y));
                    } else if (y > x) {
                        return AtanInternal.P2(AtanInternal.Div(y, x)) - pi;
                    } else {
                        return pi_4 - pi;
                    }
                } else if (x > 0) {
                    if (y < -x) {
                        return negativePi_2 - AtanInternal.P2(AtanInternal.Div(x, y));
                    } else if (y > -x) {
                        return AtanInternal.P2(AtanInternal.Div(y, x));
                    } else {
                        return -pi_4;
                    }
                } else {
                    return -pi_2;
                }
            } else if (y > 0) {
                if (x < 0) {
                    if (-y < x) {
                        return pi_2 - AtanInternal.P2(AtanInternal.Div(x, y));
                    } else if (-y > x) {
                        return pi + AtanInternal.P2(AtanInternal.Div(y, x));
                    } else {
                        return pi - pi_4;
                    }
                } else if (x > 0) {
                    if (y > x) {
                        return pi_2 - AtanInternal.P2(AtanInternal.Div(x, y));
                    } else if (y < x) {
                        return AtanInternal.P2(AtanInternal.Div(y, x));
                    } else {
                        return pi_4;
                    }
                } else {
                    return pi_2;
                }
            } else {
                return x < 0 ? pi : 0;
            }
        }

        /// <summary>
        /// 3 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var actual = Intar.Mathi.Atan2P3(2, 3);
        /// var expected = System.Math.Atan2(2, 3);
        /// Assert.AreEqual(expected, actual * toRad, 0.0016);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Atan2P3(int y, int x) {
            const int pi = 1 << 30;
            const int pi_2 = pi / 2;
            const int pi_4 = pi / 4;
            const int negativePi_2 = -pi_2;

            // AtanInternal.P2 と AtanInternal.P3 は
            // 0 < x かつ 0 < y かつ x = y の場合
            // 厳密に PI / 4 に相当する値を返すが,
            // ここでは AtanInternal.P9 とロジックを統一するため
            // 厳密に y と x が等しいか否かを調べる.
            // AtanInternal.P9 は厳密に PI / 4 に相当する値を返さないため,
            // 必ず y と x が等しいか否かを調べる必要がある.
            // if 文 1 つ分のオーバーヘッドは, これを許容する.
            // 高頻度で y = x になる場合, 計算量の削減が期待できるかもしれないが,
            // その削減分で if 文 1 つ分の増分を吸収できるかは不明.

            if (y < 0) {
                if (x < 0) {
                    if (y < x) {
                        return negativePi_2 - AtanInternal.P3(AtanInternal.Div(x, y));
                    } else if (y > x) {
                        return AtanInternal.P3(AtanInternal.Div(y, x)) - pi;
                    } else {
                        return pi_4 - pi;
                    }
                } else if (x > 0) {
                    if (y < -x) {
                        return negativePi_2 - AtanInternal.P3(AtanInternal.Div(x, y));
                    } else if (y > -x) {
                        return AtanInternal.P3(AtanInternal.Div(y, x));
                    } else {
                        return -pi_4;
                    }
                } else {
                    return -pi_2;
                }
            } else if (y > 0) {
                if (x < 0) {
                    if (-y < x) {
                        return pi_2 - AtanInternal.P3(AtanInternal.Div(x, y));
                    } else if (-y > x) {
                        return pi + AtanInternal.P3(AtanInternal.Div(y, x));
                    } else {
                        return pi - pi_4;
                    }
                } else if (x > 0) {
                    if (y > x) {
                        return pi_2 - AtanInternal.P3(AtanInternal.Div(x, y));
                    } else if (y < x) {
                        return AtanInternal.P3(AtanInternal.Div(y, x));
                    } else {
                        return pi_4;
                    }
                } else {
                    return pi_2;
                }
            } else {
                return x < 0 ? pi : 0;
            }
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// 2 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var actual = Intar.Mathi.Atan2P2(2, 3);
        /// var expected = System.Math.Atan2(2, 3);
        /// Assert.AreEqual(expected, actual * toRad, 0.0039);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の 62 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Atan2P2(long y, long x) {
            const long pi = 1L << 62;
            const long pi_2 = pi / 2;
            const long pi_4 = pi / 4;
            const long negativePi_2 = -pi_2;

            // AtanInternal.P2 と AtanInternal.P3 は
            // 0 < x かつ 0 < y かつ x = y の場合
            // 厳密に PI / 4 に相当する値を返すが,
            // ここでは AtanInternal.P9 とロジックを統一するため
            // 厳密に y と x が等しいか否かを調べる.
            // AtanInternal.P9 は厳密に PI / 4 に相当する値を返さないため,
            // 必ず y と x が等しいか否かを調べる必要がある.
            // if 文 1 つ分のオーバーヘッドは, これを許容する.
            // 高頻度で y = x になる場合, 計算量の削減が期待できるかもしれないが,
            // その削減分で if 文 1 つ分の増分を吸収できるかは不明.

            if (y < 0) {
                if (x < 0) {
                    if (y < x) {
                        return negativePi_2 - AtanInternal.P2(AtanInternal.Div(x, y));
                    } else if (y > x) {
                        return AtanInternal.P2(AtanInternal.Div(y, x)) - pi;
                    } else {
                        return pi_4 - pi;
                    }
                } else if (x > 0) {
                    if (y < -x) {
                        return negativePi_2 - AtanInternal.P2(AtanInternal.Div(x, y));
                    } else if (y > -x) {
                        return AtanInternal.P2(AtanInternal.Div(y, x));
                    } else {
                        return -pi_4;
                    }
                } else {
                    return -pi_2;
                }
            } else if (y > 0) {
                if (x < 0) {
                    if (-y < x) {
                        return pi_2 - AtanInternal.P2(AtanInternal.Div(x, y));
                    } else if (-y > x) {
                        return pi + AtanInternal.P2(AtanInternal.Div(y, x));
                    } else {
                        return pi - pi_4;
                    }
                } else if (x > 0) {
                    if (y > x) {
                        return pi_2 - AtanInternal.P2(AtanInternal.Div(x, y));
                    } else if (y < x) {
                        return AtanInternal.P2(AtanInternal.Div(y, x));
                    } else {
                        return pi_4;
                    }
                } else {
                    return pi_2;
                }
            } else {
                return x < 0 ? pi : 0;
            }
        }

        /// <summary>
        /// 3 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var actual = Intar.Mathi.Atan2P3(2, 3);
        /// var expected = System.Math.Atan2(2, 3);
        /// Assert.AreEqual(expected, actual * toRad, 0.0016);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の 62 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Atan2P3(long y, long x) {
            const long pi = 1L << 62;
            const long pi_2 = pi / 2;
            const long pi_4 = pi / 4;
            const long negativePi_2 = -pi_2;

            // AtanInternal.P2 と AtanInternal.P3 は
            // 0 < x かつ 0 < y かつ x = y の場合
            // 厳密に PI / 4 に相当する値を返すが,
            // ここでは AtanInternal.P9 とロジックを統一するため
            // 厳密に y と x が等しいか否かを調べる.
            // AtanInternal.P9 は厳密に PI / 4 に相当する値を返さないため,
            // 必ず y と x が等しいか否かを調べる必要がある.
            // if 文 1 つ分のオーバーヘッドは, これを許容する.
            // 高頻度で y = x になる場合, 計算量の削減が期待できるかもしれないが,
            // その削減分で if 文 1 つ分の増分を吸収できるかは不明.

            if (y < 0) {
                if (x < 0) {
                    if (y < x) {
                        return negativePi_2 - AtanInternal.P3(AtanInternal.Div(x, y));
                    } else if (y > x) {
                        return AtanInternal.P3(AtanInternal.Div(y, x)) - pi;
                    } else {
                        return pi_4 - pi;
                    }
                } else if (x > 0) {
                    if (y < -x) {
                        return negativePi_2 - AtanInternal.P3(AtanInternal.Div(x, y));
                    } else if (y > -x) {
                        return AtanInternal.P3(AtanInternal.Div(y, x));
                    } else {
                        return -pi_4;
                    }
                } else {
                    return -pi_2;
                }
            } else if (y > 0) {
                if (x < 0) {
                    if (-y < x) {
                        return pi_2 - AtanInternal.P3(AtanInternal.Div(x, y));
                    } else if (-y > x) {
                        return pi + AtanInternal.P3(AtanInternal.Div(y, x));
                    } else {
                        return pi - pi_4;
                    }
                } else if (x > 0) {
                    if (y > x) {
                        return pi_2 - AtanInternal.P3(AtanInternal.Div(x, y));
                    } else if (y < x) {
                        return AtanInternal.P3(AtanInternal.Div(y, x));
                    } else {
                        return pi_4;
                    }
                } else {
                    return pi_2;
                }
            } else {
                return x < 0 ? pi : 0;
            }
        }

        /// <summary>
        /// 9 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var actual = Intar.Mathi.Atan2P9(2, 3);
        /// var expected = System.Math.Atan2(2, 3);
        /// Assert.AreEqual(expected, actual * toRad, 0.00002);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の 62 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Atan2P9(long y, long x) {
            const long pi = 1L << 62;
            const long pi_2 = pi / 2;
            const long pi_4 = pi / 4;
            const long negativePi_2 = -pi_2;

            // AtanInternal.P2 と AtanInternal.P3 は
            // 0 < x かつ 0 < y かつ x = y の場合
            // 厳密に PI / 4 に相当する値を返すが,
            // ここでは AtanInternal.P9 とロジックを統一するため
            // 厳密に y と x が等しいか否かを調べる.
            // AtanInternal.P9 は厳密に PI / 4 に相当する値を返さないため,
            // 必ず y と x が等しいか否かを調べる必要がある.
            // if 文 1 つ分のオーバーヘッドは, これを許容する.
            // 高頻度で y = x になる場合, 計算量の削減が期待できるかもしれないが,
            // その削減分で if 文 1 つ分の増分を吸収できるかは不明.

            if (y < 0) {
                if (x < 0) {
                    if (y < x) {
                        return negativePi_2 - AtanInternal.P9(AtanInternal.Div(x, y));
                    } else if (y > x) {
                        return AtanInternal.P9(AtanInternal.Div(y, x)) - pi;
                    } else {
                        return pi_4 - pi;
                    }
                } else if (x > 0) {
                    if (y < -x) {
                        return negativePi_2 - AtanInternal.P9(AtanInternal.Div(x, y));
                    } else if (y > -x) {
                        return AtanInternal.P9(AtanInternal.Div(y, x));
                    } else {
                        return -pi_4;
                    }
                } else {
                    return -pi_2;
                }
            } else if (y > 0) {
                if (x < 0) {
                    if (-y < x) {
                        return pi_2 - AtanInternal.P9(AtanInternal.Div(x, y));
                    } else if (-y > x) {
                        return pi + AtanInternal.P9(AtanInternal.Div(y, x));
                    } else {
                        return pi - pi_4;
                    }
                } else if (x > 0) {
                    if (y > x) {
                        return pi_2 - AtanInternal.P9(AtanInternal.Div(x, y));
                    } else if (y < x) {
                        return AtanInternal.P9(AtanInternal.Div(y, x));
                    } else {
                        return pi_4;
                    }
                } else {
                    return pi_2;
                }
            } else {
                return x < 0 ? pi : 0;
            }
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region Clamp

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>

#if NET5_0_OR_GREATER
        [Obsolete(
            "This method is obsolete. Use System.Math.Clamp instead.",
#if NET6_0_OR_GREATER
            true
#else
            false
#endif
        )]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Clamp(int v, int min, int max) {
#if NET5_0_OR_GREATER
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

#if NET5_0_OR_GREATER
        [Obsolete(
            "This method is obsolete. Use System.Math.Clamp instead.",
#if NET6_0_OR_GREATER
            true
#else
            false
#endif
        )]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Clamp(uint v, uint min, uint max) {
#if NET5_0_OR_GREATER
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

#if NET5_0_OR_GREATER
        [Obsolete(
            "This method is obsolete. Use System.Math.Clamp instead.",
#if NET6_0_OR_GREATER
            true
#else
            false
#endif
        )]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Clamp(long v, long min, long max) {
#if NET5_0_OR_GREATER
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

#if NET5_0_OR_GREATER
        [Obsolete(
            "This method is obsolete. Use System.Math.Clamp instead.",
#if NET6_0_OR_GREATER
            true
#else
            false
#endif
        )]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Clamp(ulong v, ulong min, ulong max) {
#if NET5_0_OR_GREATER
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

#if NET5_0_OR_GREATER
        [Obsolete(
            "This method is obsolete. Use System.Math.Clamp instead.",
#if NET6_0_OR_GREATER
            true
#else
            false
#endif
        )]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Clamp(short v, short min, short max) {
#if NET5_0_OR_GREATER
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

#if NET5_0_OR_GREATER
        [Obsolete(
            "This method is obsolete. Use System.Math.Clamp instead.",
#if NET6_0_OR_GREATER
            true
#else
            false
#endif
        )]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Clamp(ushort v, ushort min, ushort max) {
#if NET5_0_OR_GREATER
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

#if NET5_0_OR_GREATER
        [Obsolete(
            "This method is obsolete. Use System.Math.Clamp instead.",
#if NET6_0_OR_GREATER
            true
#else
            false
#endif
        )]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Clamp(sbyte v, sbyte min, sbyte max) {
#if NET5_0_OR_GREATER
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

#if NET5_0_OR_GREATER
        [Obsolete(
            "This method is obsolete. Use System.Math.Clamp instead.",
#if NET6_0_OR_GREATER
            true
#else
            false
#endif
        )]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Clamp(byte v, byte min, byte max) {
#if NET5_0_OR_GREATER
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

            // Milton Abramowitz and Irene Stegun .
            // Handbook of Mathematical Function With Formulas, Graphs, and Mathematical Tables (Abramowitz and Stegun) .
            // United States Department of Commerce, National Bureau of Standards (NBS) , 1964

            internal const ulong P11I64A = 14488038916154245685UL;
            internal const ulong P11I64B = 11915934368436992009UL;
            internal const ulong P11I64C = 11760553260076371255UL;
            internal const ulong P11I64D = 11054273349336558994UL;
            internal const ulong P11I64E = 12108815703571716367UL;
            internal const ulong P11I64F = 120799838UL;
            internal const ulong P10I64A = 11378879071774596408UL;
            internal const ulong P10I64B = 9358747397805171131UL;
            internal const ulong P10I64C = 12315189113921640896UL;
            internal const ulong P10I64D = 17335849242745400440UL;
            internal const ulong P10I64E = 209554172UL;
            internal const ulong P5I64A = 14488038916154245685UL;
            internal const ulong P5I64B = 11871845430268727827UL;
            internal const ulong P5I64C = 625135121UL;
            internal const ulong P4I64A = 11303778553548845368UL;
            internal const ulong P4I64B = 968785392UL;
            internal const uint P5I32A = 3373259426U;
            internal const uint P5I32B = 2764129413U;
            internal const uint P5I32C = 9539U;
            internal const uint P4I32A = 2631866036U;
            internal const uint P4I32B = 14782U;

            // 精度に対して与える影響が軽微であるため､
            // 乗算前に一度にまとめてビットシフトを行う｡

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static ulong P11(ulong z) {
                var y = P11I64F;
                y = P11I64E - (y * z);
                y = P11I64D - ((y >> (31 + 5)) * z);
                y = P11I64C - ((y >> (31 + 4)) * z);
                y = P11I64B - ((y >> (31 + 3)) * z);
                y = P11I64A - ((y >> (31 + 1)) * z);
                return y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static ulong P10(ulong z) {
                var y = P10I64E;
                y = P10I64D - (y * z);
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
                var y = P5I64C;
                y = P5I64B - (y * z);
                y = P5I64A - ((y >> (31 + 1)) * z);
                return y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static ulong P4(ulong z) {
                var y = P4I64B;
                y = P4I64A - (y * z);
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
                var y = P5I32C;
                y = P5I32B - (y * z);
                y = P5I32A - ((y >> (15 + 1)) * z);
                return y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static uint P4(uint z) {
                var y = P4I32B;
                y = P4I32A - (y * z);
                return (y >> 16) * z;
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
        /// 3 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.SinP3(x);
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
        /// Assert.AreEqual(expected, a, 0.0018);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CosP3(int x) => SinP3(Overflowing.WrappingAdd(x, 1 << 15));

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
        /// Assert.AreEqual(expected, a, 0.0018);
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
        /// Assert.AreEqual(expected, a, 0.0018);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を直角とする角度</param>
        /// <returns>2 の 62 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long CosP3(long x) => SinP3(Overflowing.WrappingAdd(x, 1L << 31));

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
        /// Assert.AreEqual(expected, a, 0.0004);
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
        /// Assert.AreEqual(expected, a, 0.0004);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SinP4(int x) => CosP4(Overflowing.WrappingSub(x, 1 << 15));

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
        /// Assert.AreEqual(expected, a, 0.0004);
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
        /// Assert.AreEqual(expected, a, 0.0004);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 31 乗を直角とする角度</param>
        /// <returns>2 の 62 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long SinP4(long x) => CosP4(Overflowing.WrappingSub(x, 1L << 31));

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 Sqrt(UInt128 x) {
            if (x <= 1) {
                return x;
            }

            const int halfBits = 64;
            var k = halfBits - ((int)UInt128.LeadingZeroCount(x - 1) >> 1);
            var s = new UInt128(0, 1) << k;
            var t = (s + (x >> k)) >> 1;
            while (t < s) {
                s = t;
                t = (s + (x / s)) >> 1;
            }
            return s;
        }

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
} // namespace Intar
