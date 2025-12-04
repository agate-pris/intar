{% import "macros.cs" as macros -%}

using System;
using System.Runtime.CompilerServices;

namespace {{ namespace }} {
    public static class Mathi {
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
            {%- set p1 = ['int',  32, '' ] %}
            {%- set p2 = ['long', 64, 'L'] %}
            {%- set ps = [p1, p2] %}
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

            {%- for p in ps %}

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static u{{ p[0] }} P3(u{{ p[0] }} x) {
                var y = P3U{{ p[1] }}D;
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
                var y = P7U{{ bits }}H;
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
        /// <param name="x">2 の {{ p[1] / 2 - 1 }} 乗を 1 とする正弦</param>
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
                var y = P2U{{ bits }}B;
                y = (P2U{{ bits }}A + (z * y)) >> ({{ exp }} + 3);
                return ({{ t }})y * x;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static {{ t }} P3({{ t }} x) {
                const {{ ut }} one = {{ uone }} << {{ exp }};
                var w = ({{ ut }})Math.Abs(x);
                var z = one - w;
                var y = P3U{{ bits }}C;
                y = (P3U{{ bits }}B + (y * w)) >> ({{ exp }} + 4 - 2);
                y = (P3U{{ bits }}A + (z * y)) >> ({{ exp }} + 3);
                return ({{ t }})y * x;
            }
            {%- if bits < 64 %}{% continue %}{% endif %}

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static {{ t }} P9({{ t }} x) {
                var z = ({{ ut }})(x * x) >> {{ exp }};
                var y = P9U{{ bits }}E;
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
                var y = P5I{{ bits }}C;
                y = P5I{{ bits }}B - (y * z);
                y = P5I{{ bits }}A - ((y >> ({{ shift }} + 1)) * z);
                return y;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static {{ type }} P4({{ type }} z) {
                var y = P4I{{ bits }}B;
                y = P4I{{ bits }}A - (y * z);
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
