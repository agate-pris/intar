{% import "macros.cs" as macros %}

{%- macro sin_comment(sin, type, shift, one, order, error) %}
{%- if sin %}{% set prefix='Sin' %}{% set jp='正弦比' %}
{%- else   %}{% set prefix='Cos' %}{% set jp='余弦比' %}
{%- endif %}

        /// <summary>
        /// {{ order }} 次の多項式で{{ jp }}を近似する。
        /// <example>
        /// <code>
        /// const {{ type }} k = {{ one }} &lt;&lt; {{ shift }};
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.{{ prefix }}P{{ order }}(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.{{ prefix }}(rad);
        /// var a = (double)actual / ({{ one }} &lt;&lt; {{ 2 * shift }});
        /// Assert.AreEqual(expected, a, {{ error }});
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の {{ shift }} 乗を直角とする角度</param>
        /// <returns>2 の {{ 2 * shift }} 乗を 1 とする{{ jp }}</returns>
{%- endmacro -%}

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static class Mathi {
        const decimal Pi = 3.1415926535897932384626433833m;

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

            {%- for type in ['int', 'long'] %}
            {%- if   type == 'int'  %}{% set utype='uint'  %}{% set exp=15 %}{% set uone='1U'  %}{% set bits=32 %}
            {%- elif type == 'long' %}{% set utype='ulong' %}{% set exp=31 %}{% set uone='1UL' %}{% set bits=64 %}
            {%- endif %}

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static {{ type }} P2({{ type }} x) {
                const {{ utype }} one = {{ uone }} << {{ exp }};
                var w = ({{ utype }})Math.Abs(x);
                var z = one - w;
                var y = {{ uone }} << ({{ exp }} + 2);
                y = (P2U{{ bits }}B + (y / 2)) >> ({{ exp }} + 2);
                y = (P2U{{ bits }}A + (z * y)) >> ({{ exp }} + 3);
                return ({{ type }})y * x;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static {{ type }} P3({{ type }} x) {
                const {{ utype }} one = {{ uone }} << {{ exp }};
                var w = ({{ utype }})Math.Abs(x);
                var z = one - w;
                var y = {{ uone }} << ({{ exp }} + 6 - 4);
                y = (P3U{{ bits }}C + (y / 2)) >> ({{ exp }} + 6 - 4);
                y = (P3U{{ bits }}B + (y * w)) >> ({{ exp }} + 4 - 2);
                y = (P3U{{ bits }}A + (z * y)) >> ({{ exp }} + 3);
                return ({{ type }})y * x;
            }
            {%- endfor %}

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

        {%- set p2i = ['int',  2, 0.0039  ] %}
        {%- set p3i = ['int',  3, 0.0016  ] %}
        {%- set p2l = ['long', 2, 0.0039  ] %}
        {%- set p3l = ['long', 3, 0.0016  ] %}
        {%- set p9l = ['long', 9, 0.00002 ] %}

        {%- for params in [p2i, p3i, p2l, p3l, p9l] %}
        {%- if   params[0] == 'int'  %}{% set one = '1'  %}{% set shift = 15 %}
        {%- elif params[0] == 'long' %}{% set one = '1L' %}{% set shift = 31 %}
        {%- endif %}

        /// <summary>
        /// {{ params[1] }} 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// const {{ params[0] }} k = {{ one }} &lt;&lt; {{ shift }};
        /// const {{ params[0] }} toRad = System.Math.PI / ({{ one }} &lt;&lt; {{ shift * 2 }});
        /// var x = k * 2 / 3;
        /// var actual = Intar.Mathi.AtanP{{ params[1] }}(x);
        /// var expected = System.Math.Atan((double)x / k);
        /// Assert.AreEqual(expected, actual * toRad, {{ params[2] }});
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の {{ shift }} 乗を 1 とするタンジェント</param>
        /// <returns>2 の {{ shift * 2 }} 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ params[0] }} AtanP{{ params[1] }}({{ params[0] }} x) {
            const {{ params[0] }} one = {{ one }} << {{ shift }};
            const {{ params[0] }} oneNeg = -one;
            const {{ params[0] }} right = {{ one }} << {{ 2 * shift - 1}};
            const {{ params[0] }} rightNeg = -right;
            if (x < oneNeg) {
                return rightNeg - AtanInternal.P{{ params[1] }}(AtanInternal.Inv(x));
            } else if (x > one) {
                return right - AtanInternal.P{{ params[1] }}(AtanInternal.Inv(x));
            } else {
                return AtanInternal.P{{ params[1] }}(x);
            }
        }
        {%- endfor %}

        {%- set p2 = ['int', 2, 'int',  0.0040 ] %}
        {%- set p3 = ['int', 3, 'int',  0.0017 ] %}
        {%- set p9 = ['int', 9, 'long', 0.00003] %}
        {%- for params in [p2, p3, p9] %}
        {%- set method = "AtanInternal.P" ~ params[1] %}
        {%- if   params[0] == 'int'  %}{% set one_unit='1'  %}{% set one_shift=15 %}
        {%- elif params[0] == 'long' %}{% set one_unit='1L' %}{% set one_shift=31 %}{% endif %}
        {%- if   params[2] == 'int'  %}{% set pi_unit ='1'  %}{% set pi_shift =30 %}
        {%- elif params[2] == 'long' %}{% set pi_unit ='1L' %}{% set pi_shift =62 %}{% endif %}
        {%- if   params[0] == 'int' and params[2] == 'int'  %}{% set xy=      "AtanInternal.Div(x, y)"       %}{% set yx=      "AtanInternal.Div(y, x)"       %}
        {%- elif params[0] == 'int' and params[2] == 'long' %}{% set xy="(long)AtanInternal.Div(x, y) << 16" %}{% set yx="(long)AtanInternal.Div(y, x) << 16" %}{% endif %}

        /// <summary>
        /// {{ params[1] }} 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var actual = Intar.Mathi.Atan2P{{ params[1] }}(2, 3);
        /// var expected = System.Math.Atan2(2, 3);
        /// Assert.AreEqual(expected, actual * toRad, {{ params[3] }});
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の {{ pi_shift }} 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ params[2] }} Atan2P{{ params[1] }}({{ params[0] }} y, {{ params[0] }} x) {
            const {{ params[2] }} straight = {{ pi_unit }} << {{ pi_shift }};
            const {{ params[2] }} right = straight / 2;
            const {{ params[2] }} rightNeg = -right;
            if (y < 0) {
                if (x < 0) {
                    return y < x
                        ? rightNeg - {{ method }}({{ xy }})
                        : {{ method }}({{ yx }}) - straight;
                } else if (x > 0) {
                    return y < -x
                        ? rightNeg - {{ method }}({{ xy }})
                        : {{ method }}({{ yx }});
                } else {
                    return rightNeg;
                }
            } else if (y > 0) {
                if (x < 0) {
                    return -y < x
                        ? right - {{ method }}({{ xy }})
                        : straight + {{ method }}({{ yx }});
                } else if (x > 0) {
                    return y > x
                        ? right - {{ method }}({{ xy }})
                        : {{ method }}({{ yx }});
                } else {
                    return right;
                }
            } else {
                return x < 0 ? straight : 0;
            }
        }

        {%- endfor %}

{%- for type in ["int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte"] %}

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} Clamp({{ type }} v, {{ type }} min, {{ type }} max) {
#if NET6_0_OR_GREATER
            return Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return Math.Min(Math.Max(v, min), max);
#endif
        }
{%- endfor %}
{% for type in ["int", "uint", "long", "ulong"] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Half({{ type }} x) => x / 2;
{%- endfor %}

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

        {%- set bits_32 = [64, 32] %}
        {%- set bits_64 = [64] %}
        {%- set p2  = [bits_32,  2, 0.06       ] %}
        {%- set p4  = [bits_32,  4, 0.0018     ] %}
        {%- set p3  = [bits_32,  3, 0.0004     ] %}
        {%- set p5  = [bits_32,  5, 0.0004     ] %}
        {%- set p10 = [bits_64, 10, 0.000000004] %}
        {%- set p11 = [bits_64, 11, 0.000000004] %}

        {%- for bits in p2[0] %}
        {%- set shift = bits / 2 - 1 %}
        {%- set one   = macros::one(bits=bits, signed=true) %}
        {%- set type  = macros::inttype(bits=bits, signed=true ) %}
        {%- set utype = macros::inttype(bits=bits, signed=false) %}

        {{- self::sin_comment(sin=false, type=type, shift=shift, one=one, order=p2[1], error=p2[2]) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} CosP{{ p2[1] }}({{ type }} x) {
            const {{ type }} fracPi2 = {{ one }} << {{ shift }};
            const {{ type }} one = {{ one }} << {{ 2 * shift }};
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

        {{- self::sin_comment(sin=true, type=type, shift=shift, one=one, order=p2[1], error=p2[2]) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} SinP{{ p2[1] }}({{ type }} x) => CosP{{ p2[1] }}(Overflowing.WrappingSub(x, {{ one }} << {{ shift }}));
        {%- endfor %}

        {%- for params in [p4, p10] %}
        {%- for bits in params[0] %}
        {%- set shift = bits / 2 - 1 %}
        {%- set one   = macros::one(bits=bits, signed=true) %}
        {%- set type  = macros::inttype(bits=bits, signed=true ) %}
        {%- set utype = macros::inttype(bits=bits, signed=false) %}

        {{- self::sin_comment(sin=false, type=type, shift=shift, one=one, order=params[1], error=params[2]) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} CosP{{ params[1] }}({{ type }} x) {
            const {{ type }} fracPi2 = {{ one }} << {{ shift }};
            const {{ type }} one = {{ one }} << {{ 2 * shift }};
            var q = SinInternal.ToQuadrant(x);
            x &= fracPi2 - 1;
            switch (q) {
                default:
                case SinInternal.Quadrant.First: return one - ({{ type }})SinInternal.P{{ params[1] }}(({{ utype }})(x * x) >> {{ shift }});
                case SinInternal.Quadrant.Third: return ({{ type }})SinInternal.P{{ params[1] }}(({{ utype }})(x * x) >> {{ shift }}) - one;
                case SinInternal.Quadrant.Fourth: return one - ({{ type }})SinInternal.P{{ params[1] }}(({{ utype }})((fracPi2 - x) * (fracPi2 - x)) >> {{ shift }});
                case SinInternal.Quadrant.Second: return ({{ type }})SinInternal.P{{ params[1] }}(({{ utype }})((fracPi2 - x) * (fracPi2 - x)) >> {{ shift }}) - one;
            }
        }

        {{- self::sin_comment(sin=true, type=type, shift=shift, one=one, order=params[1], error=params[2]) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} SinP{{ params[1] }}({{ type }} x) => CosP{{ params[1] }}(Overflowing.WrappingSub(x, {{ one }} << {{ shift }}));
        {%- endfor %}
        {%- endfor %}

        {%- for params in [p3, p5, p11] %}
        {%- for bits in params[0] %}
        {%- set shift = bits / 2 - 1 %}
        {%- set one   = macros::one(bits=bits, signed=true) %}
        {%- set type  = macros::inttype(bits=bits, signed=true ) %}
        {%- set utype = macros::inttype(bits=bits, signed=false) %}

        {{- self::sin_comment(sin=true, type=type, shift=shift, one=one, order=params[1], error=params[2]) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} SinP{{ params[1] }}({{ type }} x) {
            x = SinInternal.MakeArgOdd(x);
            return x * ({{ type }})(SinInternal.P{{ params[1] }}(({{ utype }})(x * x) >> {{ shift }}) >> {{ shift + 1 }});
        }

        {{- self::sin_comment(sin=false, type=type, shift=shift, one=one, order=params[1], error=params[2]) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} CosP{{ params[1] }}({{ type }} x) => SinP{{ params[1] }}(Overflowing.WrappingAdd(x, {{ one }} << {{ shift }}));
        {%- endfor %}
        {%- endfor %}

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

{% for type in ["int", "uint", "long", "ulong"] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Twice({{ type }} x) => x * 2;
{%- endfor %}

    }
}
