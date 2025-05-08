{% import "macros.cs" as macros -%}

using System;
using System.Runtime.CompilerServices;

namespace {{ namespace }} {
    public static class Mathi {
        const decimal Pi = 3.1415926535897932384626433833m;

        #region AbsDiff
{%- for bits in [32, 64, 128] %}

    {%- if bits > 64 %}

        // 128 ビット整数型に対する AbsDiff は .NET 7 以降のみ

#if NET7_0_OR_GREATER

    {%- endif %}

    {%- set st = macros::inttype(bits=bits, signed=true ) %}
    {%- set ut = macros::inttype(bits=bits, signed=false) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ ut }} AbsDiff({{ st }} x, {{ st }} y) {
            unchecked {
                var ux = ({{ ut }})x;
                var uy = ({{ ut }})y;
                return (x < y)
                    ? Overflowing.WrappingSub(uy, ux)
                    : Overflowing.WrappingSub(ux, uy);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ ut }} AbsDiff({{ ut }} x, {{ ut }} y) {
            return (x < y)
                ? y - x
                : x - y;
        }

    {%- if bits > 64 %}

#endif // NET7_0_OR_GREATER

    {%- endif %}

{%- endfor %}

        #endregion

        #region Asin / Acos

        internal static class AsinInternal {
            const decimal Frac2Pi = 2 / Pi;

            {%- set p1 = ['int',  32, '' ] %}
            {%- set p2 = ['long', 64, 'L'] %}
            {%- set ps = [p1, p2] %}
            {%- for p in ps %}
            const decimal Z{{ p[1] }} = Frac2Pi * (1UL << {{ p[1] - 1 }});
            {%- endfor %}

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
{% for p in ps %}
            internal const u{{ p[0] }} P3U{{ p[1] }}A = (u{{ p[0] }})(0.5m + (Z{{ p[1] }} * (1 << 1) * 1.5707288m));
            internal const u{{ p[0] }} P3U{{ p[1] }}B = (u{{ p[0] }})(0.5m + (Z{{ p[1] }} * (1 << 3) * 0.2121144m));
            internal const u{{ p[0] }} P3U{{ p[1] }}C = (u{{ p[0] }})(0.5m + (Z{{ p[1] }} * (1 << 5) * 0.0742610m));
            internal const u{{ p[0] }} P3U{{ p[1] }}D = (u{{ p[0] }})(0.0m + (Z{{ p[1] }} * (1 << 7) * 0.0187293m));
{%- endfor %}
            {%- for bits in [64] %}
            {%- set type = macros::inttype(bits=bits, signed=false) %}
            internal const {{ type }} P7U{{ bits }}A = ({{ type }})(0.5m + (Z{{ bits }} * 1.570_796_305_0m * (1 << 1)));
            internal const {{ type }} P7U{{ bits }}B = ({{ type }})(0.5m + (Z{{ bits }} * 0.214_598_801_6m * (1 << 3)));
            internal const {{ type }} P7U{{ bits }}C = ({{ type }})(0.5m + (Z{{ bits }} * 0.088_978_987_4m * (1 << 5)));
            internal const {{ type }} P7U{{ bits }}D = ({{ type }})(0.5m + (Z{{ bits }} * 0.050_174_304_6m * (1 << 5)));
            internal const {{ type }} P7U{{ bits }}E = ({{ type }})(0.5m + (Z{{ bits }} * 0.030_891_881_0m * (1 << 6)));
            internal const {{ type }} P7U{{ bits }}F = ({{ type }})(0.5m + (Z{{ bits }} * 0.017_088_125_6m * (1 << 7)));
            internal const {{ type }} P7U{{ bits }}G = ({{ type }})(0.5m + (Z{{ bits }} * 0.006_670_090_1m * (1 << 8)));
            internal const {{ type }} P7U{{ bits }}H = ({{ type }})(0.0m + (Z{{ bits }} * 0.001_262_491_1m * (1 << 11)));
            {%- endfor %}

            {%- for p in ps %}

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static u{{ p[0] }} P3(u{{ p[0] }} x) {
                var y = 1U{{ p[2] }} << ({{ p[1] / 2 - 1 }} + 7 - 5);
                y = (P3U{{ p[1] }}D + (y / 2)) >> ({{ p[1] / 2 - 1 }} + 7 - 5);
                y = (P3U{{ p[1] }}C - (y * x)) >> ({{ p[1] / 2 - 1 }} + 5 - 3);
                y = (P3U{{ p[1] }}B - (y * x)) >> ({{ p[1] / 2 - 1 }} + 3 - 1);
                y = (P3U{{ p[1] }}A - (y * x)) >> ({{ p[1] / 2 - 1 }} + 1 + 1);
                const u{{ p[0] }} one = 1U{{ p[2] }} << {{ p[1] / 2 - 1 }};
                return Sqrt(one * (one - x)) * y;
            }
            {%- endfor %}

            {%- for bits in [64] %}
            {%- set type=macros::inttype(bits=bits, signed=false) %}
            {%- set one=macros::one(bits=bits, signed=false) %}

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static {{ type }} P7({{ type }} x) {
                var y = {{ one }} << ({{ bits / 2 - 1 }} + 11 - 8);
                y = (P7U{{ bits }}H + (y / 2)) >> ({{ bits / 2 - 1 }} + 11 - 8);
                y = (P7U{{ bits }}G - (y * x)) >> ({{ bits / 2 - 1 }} + 8 - 7);
                y = (P7U{{ bits }}F - (y * x)) >> ({{ bits / 2 - 1 }} + 7 - 6);
                y = (P7U{{ bits }}E - (y * x)) >> ({{ bits / 2 - 1 }} + 6 - 5);
                y = (P7U{{ bits }}D - (y * x)) >> ({{ bits / 2 - 1 }} + 5 - 5);
                y = (P7U{{ bits }}C - (y * x)) >> ({{ bits / 2 - 1 }} + 5 - 3);
                y = (P7U{{ bits }}B - (y * x)) >> ({{ bits / 2 - 1 }} + 3 - 1);
                y = (P7U{{ bits }}A - (y * x)) >> ({{ bits / 2 - 1 }} + 1 + 1);
                const {{ type }} one = {{ one }} << {{ bits / 2 - 1 }};
                return Sqrt(one * (one - x)) * y;
            }
            {%- endfor %}
        }

        {%- set p1=['int',  32, '',  3] %}
        {%- set p2=['long', 64, 'L', 3] %}
        {%- set p3=['long', 64, 'L', 7] %}
        {%- for p in [p1, p2, p3] %}

        /// <summary>
        /// 逆余弦を近似する｡
        /// </summary>
        /// <param name="x">2 の {{ p[1] / 2 - 1 }} 乗を 1 とする余弦</param>
        /// <returns>0 以上 π 以下の､ π を 2 の {{ p[1] - 1 }} 乗で表した角度｡</returns>
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
        public static u{{ p[0] }} AcosP{{ p[3] }}({{ p[0] }} x) {
            const u{{ p[0] }} pi = 1U{{ p[2] }} << {{ p[1] - 1 }};
            switch (Math.Sign(x)) {
                case 0: return pi / 2;
                case 1: return AsinInternal.P{{ p[3] }}((u{{ p[0] }})x);
                default: return pi - AsinInternal.P{{ p[3] }}((u{{ p[0] }})-x);
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
        public static {{ p[0] }} AsinP{{ p[3] }}({{ p[0] }} x) {
            const {{ p[0] }} fracPi2 = 1{{ p[2] }} << {{ p[1] - 2 }};
            switch (Math.Sign(x)) {
                case 0: return 0;
                case 1: return fracPi2 - ({{ p[0] }})AsinInternal.P{{ p[3] }}((u{{ p[0] }})x);
                default: return ({{ p[0] }})AsinInternal.P{{ p[3] }}((u{{ p[0] }})-x) - fracPi2;
            }
        }
        {%- endfor %}

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
            {%- for bits in [32, 64] %}
            {%- set i = macros::inttype(signed=true, bits=bits  ) %}
            {%- set l = macros::inttype(signed=true, bits=bits*2) %}
            {%- if bits > 32 %}

#if NET7_0_OR_GREATER
            {%- endif %}

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static {{ i }} Div({{ i }} a, {{ i }} b) {
                var al = (({{ l }})a) << {{ bits / 2 }};
                var bl = ({{ l }})b;
                var sign = ((a < 0) == (b < 0)) ? 1 : -1;
                return ({{ i }})((al + (bl * sign)) / (bl << 1));
            }
            {%- if bits > 32 %}

#endif // NET7_0_OR_GREATER
            {%- endif %}
            {%- endfor %}

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

            {%- for bits in [32, 64] %}
            {%- set  t = macros::inttype(bits=bits, signed=true ) %}
            {%- set ut = macros::inttype(bits=bits, signed=false) %}
            {%- set exp = bits / 2 - 1 %}
            {%- set uone = macros::one(bits=bits, signed=false) %}

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static {{ t }} P2({{ t }} x) {
                const {{ ut }} one = {{ uone }} << {{ exp }};
                var w = ({{ ut }})Math.Abs(x);
                var z = one - w;
                var y = {{ uone }} << ({{ exp }} + 2);
                y = (P2U{{ bits }}B + (y / 2)) >> ({{ exp }} + 2);
                y = (P2U{{ bits }}A + (z * y)) >> ({{ exp }} + 3);
                return ({{ t }})y * x;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static {{ t }} P3({{ t }} x) {
                const {{ ut }} one = {{ uone }} << {{ exp }};
                var w = ({{ ut }})Math.Abs(x);
                var z = one - w;
                var y = {{ uone }} << ({{ exp }} + 6 - 4);
                y = (P3U{{ bits }}C + (y / 2)) >> ({{ exp }} + 6 - 4);
                y = (P3U{{ bits }}B + (y * w)) >> ({{ exp }} + 4 - 2);
                y = (P3U{{ bits }}A + (z * y)) >> ({{ exp }} + 3);
                return ({{ t }})y * x;
            }
            {%- if bits < 64 %}{% continue %}{% endif %}

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static {{ t }} P9({{ t }} x) {
                var z = ({{ ut }})(x * x) >> {{ exp }};
                var y = {{ uone }} << ({{ exp }} + 8 - 6);
                y = (P9U{{ bits }}E + (y / 2)) >> ({{ exp }} + 8 - 6);
                y = (P9U{{ bits }}D - (y * z)) >> ({{ exp }} + 6 - 5);
                y = (P9U{{ bits }}C - (y * z)) >> ({{ exp }} + 5 - 4);
                y = (P9U{{ bits }}B - (y * z)) >> ({{ exp }} + 4 - 2);
                y = (P9U{{ bits }}A - (y * z)) >> ({{ exp }} + 3);
                return ({{ t }})y * x;
            }
            {%- endfor %}
        }

        {%- set params = [
            2, 0.0039,
            3, 0.0016,
            9, 0.00002,
        ] %}

        {%- for bits in [32, 64] %}
        {%- set t = macros::inttype(bits=bits, signed=true) %}
        {%- set one = macros::one(bits=bits, signed=true) %}
        {%- set shift = bits/2 - 1 %}
        {%- for i in range(end = params|length / 2) %}
        {%- set o = params|nth(n = i*2    ) %}
        {%- set e = params|nth(n = i*2 + 1) %}
        {%- if o > 3 and bits < 64 %}{% continue %}{% endif %}

        /// <summary>
        /// {{ o }} 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// const {{ t }} k = {{ one }} &lt;&lt; {{ shift }};
        /// const {{ t }} toRad = System.Math.PI / ({{ one }} &lt;&lt; {{ shift * 2 }});
        /// var x = k * 2 / 3;
        /// var actual = {{ namespace }}.Mathi.AtanP{{ o }}(x);
        /// var expected = System.Math.Atan((double)x / k);
        /// Assert.AreEqual(expected, actual * toRad, {{ e }});
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の {{ shift }} 乗を 1 とするタンジェント</param>
        /// <returns>2 の {{ shift * 2 }} 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ t }} AtanP{{ o }}({{ t }} x) {
            const {{ t }} one = {{ one }} << {{ shift }};
            const {{ t }} oneNeg = -one;
            const {{ t }} right = {{ one }} << {{ 2 * shift - 1 }};
            const {{ t }} rightNeg = -right;

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
                return rightNeg - AtanInternal.P{{ o }}(AtanInternal.Inv(x));
            } else if (x > one) {
                return right - AtanInternal.P{{ o }}(AtanInternal.Inv(x));
            } else if (x == oneNeg) {
                return rightNeg / 2;
            } else if (x == one) {
                return right / 2;
            } else {
                return AtanInternal.P{{ o }}(x);
            }
        }
        {%- endfor %}
        {%- endfor %}

        {%- for bits in [32, 64] %}
        {%- if bits > 32 %}

#if NET7_0_OR_GREATER
        {%- endif %}
        {%- for idx in range(end = params|length / 2) %}
        {%- set i = macros::inttype(signed=true, bits=bits) %}
        {%- set o = params|nth(n=2*idx    ) %}
        {%- set e = params|nth(n=2*idx + 1) %}
        {%- if o > 3 and bits < 64 %}{% continue %}{% endif %}
        {%- set method = "" ~ o %}
        {%- set one = macros::one(signed=true, bits=bits) %}
        {%- set one_shift = bits/2 - 1 %}
        {%- set pi_shift = bits-2 %}

        /// <summary>
        /// {{ o }} 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var actual = {{ namespace }}.Mathi.Atan2P{{ o }}(2, 3);
        /// var expected = System.Math.Atan2(2, 3);
        /// Assert.AreEqual(expected, actual * toRad, {{ e }});
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の {{ pi_shift }} 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ i }} Atan2P{{ o }}({{ i }} y, {{ i }} x) {
            const {{ i }} pi = {{ one }} << {{ pi_shift }};
            const {{ i }} pi_2 = pi / 2;
            const {{ i }} pi_4 = pi / 4;
            const {{ i }} negativePi_2 = -pi_2;

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
                        return negativePi_2 - AtanInternal.P{{ o }}(AtanInternal.Div(x, y));
                    } else if (y > x) {
                        return AtanInternal.P{{ o }}(AtanInternal.Div(y, x)) - pi;
                    } else {
                        return pi_4 - pi;
                    }
                } else if (x > 0) {
                    if (y < -x) {
                        return negativePi_2 - AtanInternal.P{{ o }}(AtanInternal.Div(x, y));
                    } else if (y > -x) {
                        return AtanInternal.P{{ o }}(AtanInternal.Div(y, x));
                    } else {
                        return -pi_4;
                    }
                } else {
                    return -pi_2;
                }
            } else if (y > 0) {
                if (x < 0) {
                    if (-y < x) {
                        return pi_2 - AtanInternal.P{{ o }}(AtanInternal.Div(x, y));
                    } else if (-y > x) {
                        return pi + AtanInternal.P{{ o }}(AtanInternal.Div(y, x));
                    } else {
                        return pi - pi_4;
                    }
                } else if (x > 0) {
                    if (y > x) {
                        return pi_2 - AtanInternal.P{{ o }}(AtanInternal.Div(x, y));
                    } else if (y < x) {
                        return AtanInternal.P{{ o }}(AtanInternal.Div(y, x));
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
        {%- endfor %}
        {%- if bits > 32 %}

#endif // NET7_0_OR_GREATER
        {%- endif %}
        {%- endfor %}

        #endregion

        #region Clamp
{%- for bits in [32, 64, 16, 8, 128] %}
    {%- if bits > 64 %}

        // 128 ビット整数値型については代わりに INumber.Clamp を使うこと
        {%- continue %}
    {%- endif %}
    {%- for s in [true, false] %}
        {%- set t = macros::inttype(bits=bits, signed=s) %}

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
        public static {{ t }} Clamp({{ t }} v, {{ t }} min, {{ t }} max) {
#if NET5_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }

    {%- endfor %}
{%- endfor %}

        #endregion

        #region Half
{# 改行 #}
{%- for bits in [32, 64, 128] %}
    {%- if bits > 64 %}

#if NET7_0_OR_GREATER
{# 改行 #}
    {%- endif %}
    {%- for s in [true, false] %}
        {%- set t=macros::inttype(signed=s, bits=bits) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal static {{ t }} Half({{ t }} x) => x / 2;
    {%- endfor %}
    {%- if bits > 64 %}

#endif // NET7_0_OR_GREATER
    {%- endif %}
{%- endfor %}

        #endregion

        #region Sin / Cos

        internal static class SinInternal {
            internal enum Quadrant : byte {
                First,
                Second,
                Third,
                Fourth,
            }

            {%- for type in ['int', 'long'] %}
            {%- if   type == 'int'  %}{% set exp = 15 %}{% set one = '1'  %}
            {%- elif type == 'long' %}{% set exp = 31 %}{% set one = '1L' %}
            {%- endif %}

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static Quadrant ToQuadrant({{ type }} x) => (Quadrant)((x >> {{ exp }}) & 3);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static {{ type }} MakeArgOdd({{ type }} x) {
                var masked = x & (({{ one }} << {{ exp }}) - 1);
                switch (ToQuadrant(x)) {
                    default:
                    case Quadrant.First: return masked;
                    case Quadrant.Third: return -masked;
                    case Quadrant.Fourth: return masked - ({{ one }} << {{ exp }});
                    case Quadrant.Second: return ({{ one }} << {{ exp }}) - masked;
                }
            }
            {%- endfor %}

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

            // もっとも最初に計算に使う係数 (P11I64F など) は
            // 0.5 に相当する値を別途加算するため、
            // ここでは加算しない。

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
            {%- for bits in [64, 32] %}
            {%- set type = macros::inttype(bits=bits, signed=false) %}
            internal const {{ type }} P5I{{ bits }}A = ({{ type }})(0.5m + (1.00000m * K01 * Z{{ bits }}));
            internal const {{ type }} P5I{{ bits }}B = ({{ type }})(0.5m + (0.16605m * K03 * Z{{ bits }} * (1 << 1)));
            internal const {{ type }} P5I{{ bits }}C = ({{ type }})(0.0m + (0.00761m * K05 * Z{{ bits }} * (1 << 4)));
            internal const {{ type }} P4I{{ bits }}A = ({{ type }})(0.5m + (0.49670m * K02 * Z{{ bits }}));
            internal const {{ type }} P4I{{ bits }}B = ({{ type }})(0.0m + (0.03705m * K04 * Z{{ bits }} * (1 << 3)));
            {%- endfor %}

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

            {%- for bits in [64, 32] %}
            {%- set type = macros::inttype(bits=bits, signed=false) %}
            {%- set one = macros::one(bits=bits, signed=false) %}
            {%- set shift = bits / 2 - 1 %}

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static {{ type }} P3({{ type }} z) {
                const {{ type }} a = ({{ one }} << {{ shift * 2 }}) * 3;
                const {{ type }} b = ({{ one }} << {{ shift * 2 }}) * 2;
                return a - ((b >> {{ shift + 1 }}) * z);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static {{ type }} P5({{ type }} z) {
                var y = {{ one }};
                y = P5I{{ bits }}C + ((y << ({{ shift }} + 3)) / 2);
                y = P5I{{ bits }}B - ((y >> ({{ shift }} + 3)) * z);
                y = P5I{{ bits }}A - ((y >> ({{ shift }} + 1)) * z);
                return y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static {{ type }} P4({{ type }} z) {
                var y = {{ one }};
                y = P4I{{ bits }}B + ((y << ({{ shift }} + 3)) / 2);
                y = P4I{{ bits }}A - ((y >> ({{ shift }} + 3)) * z);
                return (y >> {{ shift + 1 }}) * z;
            }
            {%- endfor %}
        }

        {%- set parameters = [
             2, 0.06,
             3, 0.0018,
             4, 0.0004,
             5, 0.0004,
            10, 0.000000004,
            11, 0.000000004,
        ] %}
        {%- for i in range(end = parameters|length / 2) %}
        {%- set o = parameters|nth(n = i * 2    ) %}
        {%- set e = parameters|nth(n = i * 2 + 1) %}
        {%- for bits in [32, 64] %}

        {#- 6 次以上の多項式による近似は
            64 ビット以上の場合のみ定義する。#}
        {%- if o > 5 and bits < 64 %}
            {%- continue %}
        {%- endif %}

        {%- set shift = bits / 2 - 1 %}
        {%- set one   = macros::one(bits=bits, signed=true) %}
        {%- set type  = macros::inttype(bits=bits, signed=true ) %}
        {%- set utype = macros::inttype(bits=bits, signed=false) %}

        {#- 多項式の次数が偶数の場合は Sin が Cos に、
            奇数の場合は Cos が Sin に依存するので、
            依存関係の順に定義する。#}
        {%- if o is even %}{% set methods = ['Cos', 'Sin'] %}
        {%- else         %}{% set methods = ['Sin', 'Cos'] %}
        {%- endif %}

        {%- for m in methods %}
        {%- if m == 'Sin' %}{% set jp = '正弦比' %}
        {%- else          %}{% set jp = '余弦比' %}
        {%- endif %}

        /// <summary>
        /// {{ o }} 次の多項式で{{ jp }}を近似する。
        /// <example>
        /// <code>
        /// const {{ type }} k = {{ one }} &lt;&lt; {{ shift }};
        /// var x = k * 30 / 90;
        /// var actual = {{ namespace }}.Mathi.{{ m }}P{{ o }}(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.{{ m }}(rad);
        /// var a = (double)actual / ({{ one }} &lt;&lt; {{ 2 * shift }});
        /// Assert.AreEqual(expected, a, {{ e }});
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の {{ shift }} 乗を直角とする角度</param>
        /// <returns>2 の {{ 2 * shift }} 乗を 1 とする{{ jp }}</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} {{ m }}P{{ o }}({{ type }} x)
        {%- if   o is even and m == 'Sin' %} => CosP{{ o }}(Overflowing.WrappingSub(x, {{ one }} << {{ shift }}));
        {%- elif o is odd  and m == 'Cos' %} => SinP{{ o }}(Overflowing.WrappingAdd(x, {{ one }} << {{ shift }}));
        {%- elif o is odd %} {
            x = SinInternal.MakeArgOdd(x);
            return x * ({{ type }})(SinInternal.P{{ o }}(({{ utype }})(x * x) >> {{ shift }}) >> {{ shift + 1 }});
        }
        {%- else %} {
            const {{ type }} fracPi2 = {{ one }} << {{ shift }};
            const {{ type }} one = {{ one }} << {{ 2 * shift }};
            var q = SinInternal.ToQuadrant(x);
            x &= fracPi2 - 1;
            switch (q) {
                default:
                {%- if o == 2 %}
                case SinInternal.Quadrant.First: return one - (x * x);
                case SinInternal.Quadrant.Third: return (x * x) - one;
                case SinInternal.Quadrant.Fourth: return one - ((fracPi2 - x) * (fracPi2 - x));
                case SinInternal.Quadrant.Second: return ((fracPi2 - x) * (fracPi2 - x)) - one;
                {%- else %}
                case SinInternal.Quadrant.First: return one - ({{ type }})SinInternal.P{{ o }}(({{ utype }})(x * x) >> {{ shift }});
                case SinInternal.Quadrant.Third: return ({{ type }})SinInternal.P{{ o }}(({{ utype }})(x * x) >> {{ shift }}) - one;
                case SinInternal.Quadrant.Fourth: return one - ({{ type }})SinInternal.P{{ o }}(({{ utype }})((fracPi2 - x) * (fracPi2 - x)) >> {{ shift }});
                case SinInternal.Quadrant.Second: return ({{ type }})SinInternal.P{{ o }}(({{ utype }})((fracPi2 - x) * (fracPi2 - x)) >> {{ shift }}) - one;
                {%- endif %}
            }
        }
        {%- endif %}
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}

        #endregion

        #region Sqrt
{%- for bits in [32, 64] %}
{%- set type=macros::inttype(bits=bits, signed=false) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} Sqrt({{ type }} x) {
            if (x <= 1) {
                return x;
            }

            const int halfBits = sizeof({{ type }}) * 4;
            var k = halfBits - (BitOperations.LeadingZeroCount(x - 1) >> 1);
            var s = {{ macros::one(bits=bits, signed=false) }} << k;
            var t = (s + (x >> k)) >> 1;
            while (t < s) {
                s = t;
                t = (s + (x / s)) >> 1;
            }
            return s;
        }
{%- endfor %}

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
{# 改行 #}
{%- for bits in [32, 64, 128] %}
    {%- if bits > 64 %}

#if NET7_0_OR_GREATER
{# 改行 #}
    {%- endif %}
    {%- for s in [true, false] %}
        {%- set t=macros::inttype(signed=s, bits=bits) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal static {{ t }} Twice({{ t }} x) => x * 2;
    {%- endfor %}
    {%- if bits > 64 %}

#endif // NET7_0_OR_GREATER
    {%- endif %}
{%- endfor %}

        #endregion

        #region UnsignedAbs
{%- for bits in [32, 64, 128] %}
    {%- if bits > 64 %}

#if NET7_0_OR_GREATER

    {%- endif %}

    {%- set ut = macros::inttype(bits=bits, signed=false) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ ut }} UnsignedAbs({{ macros::inttype(bits=bits, signed=true) }} x) {
            return unchecked(({{ ut }})Overflowing.WrappingAbs(x));
        }

    {%- if bits > 64 %}

#endif // NET7_0_OR_GREATER

    {%- endif %}

{%- endfor %}

        #endregion

    }
} // namespace {{ namespace }}
