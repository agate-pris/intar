{% import "macros.cs" as macros %}

{% macro clamp(type) %}

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
{%- endmacro -%}

{%- macro sin_comment(sin, type, order, error) %}
{%- if sin %}{% set prefix='Sin' %}{% set jp='正弦比' %}
{%- else   %}{% set prefix='Cos' %}{% set jp='余弦比' %}
{%- endif %}
{%- if   type == 'int'  %}{% set shift = 15 %}{% set one = '1'  %}
{%- elif type == 'long' %}{% set shift = 31 %}{% set one = '1L' %}
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

{%- macro asin_equation() %}
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
{%- endmacro -%}

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
        {{- self::asin_equation() }}
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
        {{- self::asin_equation() }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Asin(int x) {
            var negate = x < 0;
            var sign = Math.Sign(x);
            x = AsinInternal(negate ? -x : x);
            return sign * ((1 << 30) - x);
        }

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

            const decimal PI = 3.1415926535897932384626433833m;

            internal const uint P2U32A = 1U << 31;
            internal const uint P3U32A = 1U << 31;
            internal const ulong P2U64A = 1UL << 63;
            internal const ulong P3U64A = 1UL << 63;
            internal const uint P2U32B = (uint)(0.0m + ((1U << 31) / PI * (1U << 4) * 0.273m));
            internal const uint P3U32B = (uint)(0.5m + ((1U << 31) / PI * (1U << 4) * 0.2447m));
            internal const uint P3U32C = (uint)(0.0m + ((1U << 31) / PI * (1U << 6) * 0.0663m));
            internal const ulong P2U64B = (ulong)(0.0m + ((1UL << 63) / PI * (1UL << 4) * 0.273m));
            internal const ulong P3U64B = (ulong)(0.5m + ((1UL << 63) / PI * (1UL << 4) * 0.2447m));
            internal const ulong P3U64C = (ulong)(0.0m + ((1UL << 63) / PI * (1UL << 6) * 0.0663m));
            internal const ulong P9U64A = (ulong)(0.5m + ((1UL << 63) / PI * (1UL << 2) * 0.999_866_0m));
            internal const ulong P9U64B = (ulong)(0.5m + ((1UL << 63) / PI * (1UL << 4) * 0.330_299_5m));
            internal const ulong P9U64C = (ulong)(0.5m + ((1UL << 63) / PI * (1UL << 5) * 0.180_141_0m));
            internal const ulong P9U64D = (ulong)(0.5m + ((1UL << 63) / PI * (1UL << 6) * 0.085_133_0m));
            internal const ulong P9U64E = (ulong)(0.0m + ((1UL << 63) / PI * (1UL << 8) * 0.020_835_1m));

            {%- for type in ['int', 'long'] %}
            {%- if   type == 'int'  %}{% set utype='uint'  %}{% set exp=15 %}{% set uone='1U'  %}{% set bits=32 %}
            {%- elif type == 'long' %}{% set utype='ulong' %}{% set exp=31 %}{% set uone='1UL' %}{% set bits=64 %}
            {%- endif %}

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static {{ type }} P2({{ type }} x) {
                const {{ utype }} one = {{ uone }} << {{ exp }};
                var w = ({{ utype }})Math.Abs(x);
                var z = one - w;
                {{ utype }} y;
                y = (P2U{{ bits }}B + ({{ uone }} << ({{ exp }} + 2 - 1))) >> ({{ exp }} + 2);
                y = (P2U{{ bits }}A + (z * y)) >> ({{ exp }} + 3);
                return ({{ type }})y * x;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static {{ type }} P3({{ type }} x) {
                const {{ utype }} one = {{ uone }} << {{ exp }};
                var w = ({{ utype }})Math.Abs(x);
                var z = one - w;
                {{ utype }} y;
                y = (P3U{{ bits }}C + ({{ uone }} << ({{ exp }} + 6 - 4 - 1))) >> ({{ exp }} + 6 - 4);
                y = (P3U{{ bits }}B + (y * w)) >> ({{ exp }} + 4 - 2);
                y = (P3U{{ bits }}A + (z * y)) >> ({{ exp }} + 3);
                return ({{ type }})y * x;
            }
            {%- endfor %}

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static long P9(long x) {
                var z = (ulong)(x * x) >> 31;
                ulong y;
                y = (P9U64E + (1UL << (31 + 8 - 6 - 1))) >> (31 + 8 - 6);
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
        {{- self::clamp(type = type) }}
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

        {%- set p4  = ['int',   4, 0.0018     ] %}
        {%- set p5  = ['int',   5, 0.0004     ] %}
        {%- set p10 = ['long', 10, 0.000000004] %}
        {%- set p11 = ['long', 11, 0.000000004] %}

        {%- for params in [p4, p10] %}
        {%- if   params[0] == 'int'  %}{% set shift = 15 %}{% set one = '1'  %}
        {%- elif params[0] == 'long' %}{% set shift = 31 %}{% set one = '1L' %}
        {%- endif %}

        {{- self::sin_comment(sin=false, type=params[0], order=params[1], error=params[2]) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ params[0] }} CosP{{ params[1] }}({{ params[0] }} x) {
            const {{ params[0] }} pi = {{ one }} << {{ shift }};
            const {{ params[0] }} one = {{ one }} << {{ 2 * shift }};
            var q = SinInternal.ToQuadrant(x);
            x &= pi - 1;
            switch (q) {
                default:
                case SinInternal.Quadrant.First: return one - SinInternal.P{{ params[1] }}((x * x) >> {{ shift }});
                case SinInternal.Quadrant.Third: return SinInternal.P{{ params[1] }}((x * x) >> {{ shift }}) - one;
                case SinInternal.Quadrant.Fourth: return one - SinInternal.P{{ params[1] }}(((pi - x) * (pi - x)) >> {{ shift }});
                case SinInternal.Quadrant.Second: return SinInternal.P{{ params[1] }}(((pi - x) * (pi - x)) >> {{ shift }}) - one;
            }
        }

        {{- self::sin_comment(sin=true, type=params[0], order=params[1], error=params[2]) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ params[0] }} SinP{{ params[1] }}({{ params[0] }} x) => CosP{{ params[1] }}(Overflowing.WrappingSub(x, {{ one }} << {{ shift }}));
        {%- endfor %}

        {%- for params in [p5, p11] %}
        {%- if   params[0] == 'int'  %}{% set shift = 15 %}{% set one = '1'  %}
        {%- elif params[0] == 'long' %}{% set shift = 31 %}{% set one = '1L' %}
        {%- endif %}

        {{- self::sin_comment(sin=true, type=params[0], order=params[1], error=params[2]) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ params[0] }} SinP{{ params[1] }}({{ params[0] }} x) {
            x = SinInternal.MakeArgOdd(x);
            return x * (SinInternal.P{{ params[1] }}((x * x) >> {{ shift }}) >> {{ shift }});
        }

        {{- self::sin_comment(sin=false, type=params[0], order=params[1], error=params[2]) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ params[0] }} CosP{{ params[1] }}({{ params[0] }} x) => SinP{{ params[1] }}(Overflowing.WrappingAdd(x, {{ one }} << {{ shift }}));
        {%- endfor %}

{%- for type in ['uint', 'ulong'] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} Sqrt({{ type }} x) {
            if (x <= 1) {
                return x;
            }

            const int halfBits = sizeof({{ type }}) * 4;
            var k = halfBits - (BitOperations.LeadingZeroCount(x - 1) >> 1);
            var s = {{ macros::one_literal(t=type) }} << k;
            var t = (s + (x >> k)) >> 1;
            while (t < s) {
                s = t;
                t = (s + (x / s)) >> 1;
            }
            return s;
        }
{%- endfor %}
{% for type in ["int", "uint", "long", "ulong"] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Twice({{ type }} x) => x * 2;
{%- endfor %}

    }
}
