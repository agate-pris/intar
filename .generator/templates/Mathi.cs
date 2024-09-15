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

{%- macro sin_cos_comment(sin, a, d, error) %}
{%- if sin %}{% set prefix='Sin' %}{% set jp='正弦比' %}
{%- else   %}{% set prefix='Cos' %}{% set jp='余弦比' %}
{%- endif %}

        /// <summary>
        /// {{ d }} 次の多項式で{{ jp }}を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var actual = Intar.Mathi.{{ prefix }}{{ a }}(x);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.{{ prefix }}(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, {{ error }});
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする{{ jp }}</returns>
{%- endmacro -%}

{%- macro sin_even(a, d, error) %}

        {{- self::sin_cos_comment(sin=true, a=a, d=d, error=error) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sin{{ a }}(int x) => Cos{{ a }}(Overflowing.WrappingSub(x, SinInternal.Right));
{%- endmacro -%}

{%- macro cos_even(a, d, error) %}

        {{- self::sin_cos_comment(sin=false, a=a, d=d, error=error) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Cos{{ a }}(int x) {
            var masked = x & SinInternal.RightMask;
            switch (SinInternal.ToQuadrant(x)) {
                default:
                case SinInternal.Quadrant.First: return SinInternal.One - SinInternal.Cos{{ a }}(masked);
                case SinInternal.Quadrant.Third: return SinInternal.Cos{{ a }}(masked) - SinInternal.One;
                case SinInternal.Quadrant.Fourth: return SinInternal.One - SinInternal.Cos{{ a }}(SinInternal.Right - masked);
                case SinInternal.Quadrant.Second: return SinInternal.Cos{{ a }}(SinInternal.Right - masked) - SinInternal.One;
            }
        }
{%- endmacro -%}

{%- macro cos_odd(a, d, error) %}

        {{- self::sin_cos_comment(sin=false, a=a, d=d, error=error) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Cos{{ a }}(int x) => Sin{{ a }}(Overflowing.WrappingAdd(x, SinInternal.Right));
{%- endmacro -%}

{%- macro cos_p4_detail(k) %}

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int CosP4A{{ k }}(int z) {
                const int a = {{ k }};
                const int k = a + Right;
                z = (z * z) >> RightExp;
                var y = k - ((z * a) >> RightExp);
                return y * z;
            }
{%- endmacro -%}

{%- macro sin_p5(k, d, error) %}

        {{- self::sin_cos_comment(sin=true, a='P5A'~k, d=d, error=error) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SinP5A{{ k }}(int x) {
            const int k = {{ k }};
            const int a = (k * 2) - (SinInternal.Right * 5 / 2);
            const int b = k - (SinInternal.Right * 3 / 2);
            var z = SinInternal.MakeArgOdd(x);
            var z_2 = (z * z) >> SinInternal.RightExp;
            return (k - (((a - ((z_2 * b) >> SinInternal.RightExp)) * z_2) >> SinInternal.RightExp)) * z;
        }
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
            internal static int P2A2909(int x) {
                const int a = 2909;
                var xAbs = Math.Abs(x);
                var tmp = (One - xAbs) * a;
                tmp = FracK4 + (tmp >> 15);
                return x * tmp;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P3A2577B664(int x) {
                const int a = 2577;
                const int b = 664;
                var xAbs = Math.Abs(x);
                var tmp = (xAbs * b) >> 15;
                tmp = (One - xAbs) * (a + tmp);
                tmp = FracK4 + (tmp >> 15);
                return x * tmp;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P5A2996B809(int x) {
                const int b = 809;
                const int a = 2996;
                const int k = (1 << 13) + a - b;
                var z = (x * x) >> 15;
                int y;
                y = a - ((b * z) >> 15);
                y = k - ((y * z) >> 15);
                return y * x;
            }
        }

{%- set atan_params = [
    'P2A2909',     2, 0.004507, 0.004507,
    'P3A2577B664', 3, 0.001730, 0.001730,
    'P5A2996B809', 5, 0.000914, 0.000919
] %}
{%- for i in range(end=atan_params | length / 4) %}
{%- set method = atan_params | nth(n=loop.index0 * 4    ) %}
{%- set d      = atan_params | nth(n=loop.index0 * 4 + 1) %}
{%- set error  = atan_params | nth(n=loop.index0 * 4 + 2) %}
{%- set error2 = atan_params | nth(n=loop.index0 * 4 + 3) %}

        /// <summary>
        /// {{ d }} 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 2 / 3;
        /// var actual = Intar.Mathi.Atan{{ method }}(x);
        /// var expected = System.Math.Atan((double)x / k);
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
        /// Assert.AreEqual(expected, a, {{ error }});
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Atan{{ method }}(int x) {
            if (x < AtanInternal.OneNeg) {
                return AtanInternal.RightNeg - AtanInternal.{{ method }}(AtanInternal.Inv(x));
            } else if (x > AtanInternal.One) {
                return AtanInternal.Right - AtanInternal.{{ method }}(AtanInternal.Inv(x));
            } else {
                return AtanInternal.{{ method }}(x);
            }
        }

        /// <summary>
        /// {{ d }} 次の多項式で逆正接を近似する。
        /// <example>
        /// <code>
        /// var y = 2;
        /// var x = 3;
        /// var actual = Intar.Mathi.Atan2{{ method }}(y, x);
        /// var expected = System.Math.Atan2(2, 3);
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
        /// Assert.AreEqual(expected, a, {{ error2 }});
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="y">Y 座標</param>
        /// <param name="x">X 座標</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Atan2{{ method }}(int y, int x) {
            if (y < 0) {
                if (x < 0) {
                    return y < x
                        ? AtanInternal.RightNeg - AtanInternal.{{ method }}(AtanInternal.Div(x, y))
                        : AtanInternal.{{ method }}(AtanInternal.Div(y, x)) - AtanInternal.Straight;
                } else if (x > 0) {
                    return y < -x
                        ? AtanInternal.RightNeg - AtanInternal.{{ method }}(AtanInternal.Div(x, y))
                        : AtanInternal.{{ method }}(AtanInternal.Div(y, x));
                } else {
                    return AtanInternal.RightNeg;
                }
            } else if (y > 0) {
                if (x < 0) {
                    return -y < x
                        ? AtanInternal.Right - AtanInternal.{{ method }}(AtanInternal.Div(x, y))
                        : AtanInternal.Straight + AtanInternal.{{ method }}(AtanInternal.Div(y, x));
                } else if (x > 0) {
                    return y > x
                        ? AtanInternal.Right - AtanInternal.{{ method }}(AtanInternal.Div(x, y))
                        : AtanInternal.{{ method }}(AtanInternal.Div(y, x));
                } else {
                    return AtanInternal.Right;
                }
            } else {
                return x < 0 ? AtanInternal.Straight : 0;
            }
        }

{%- endfor %}

        public enum AtanMethod : byte {
            {%- for i in range(end=atan_params | length / 4) %}
            {{ atan_params | nth(n=4 * i) }},
            {%- endfor %}
            Default = {{ atan_params | nth(n=atan_params | length - 4) }},
        }

        /// <summary>
        /// 指定された方法で逆正接を近似する｡
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 2 / 3;
        /// var method = Intar.Mathi.AtanMethod.{{ atan_params[4] }};
        /// var actual = Intar.Mathi.Atan(x, method);
        /// var expected = System.Math.Atan((double)x / k);
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
        /// Assert.AreEqual(expected, a, {{ atan_params[6] }});
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <param name="method">逆正接の近似方法</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Atan(int x, AtanMethod method = AtanMethod.Default) {
            switch (method) {
                {%- for i in range(end=atan_params | length / 4) %}
                {%- if loop.last %}
                default:{% endif %}
                case AtanMethod.{{ atan_params | nth(n=4 * i) }}: return Atan{{ atan_params | nth(n=4 * i) }}(x);
                {%- endfor %}
            }
        }

        /// <summary>
        /// 指定された方法で逆正接を近似する｡
        /// <example>
        /// <code>
        /// var y = 2;
        /// var x = 3;
        /// var method = Intar.Mathi.AtanMethod.{{ atan_params[4] }};
        /// var actual = Intar.Mathi.Atan2(y, x, method);
        /// var expected = System.Math.Atan2(y, x);
        /// var a = System.Math.PI / (1 &lt;&lt; 30) * actual;
        /// Assert.AreEqual(expected, a, {{ atan_params[7] }});
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を 1 とするタンジェント</param>
        /// <param name="method">逆正接の近似方法</param>
        /// <returns>2 の 30 乗を PI とする逆正接</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Atan2(int y, int x, AtanMethod method = AtanMethod.Default) {
            switch (method) {
                {%- for i in range(end=atan_params | length / 4) %}
                {%- if loop.last %}
                default:{% endif %}
                case AtanMethod.{{ atan_params | nth(n=4 * i) }}: return Atan2{{ atan_params | nth(n=4 * i) }}(y, x);
                {%- endfor %}
            }
        }

{%- for type in ["int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte"] %}
        {{- self::clamp(type = type) }}
{%- endfor %}
{% for type in ["int", "uint", "long", "ulong"] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Half({{ type }} x) => x / 2;
{%- endfor %}

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

            {{- self::cos_p4_detail(k=7369) }}
        }

        {%- set sin_params = [
            'P2',       2, 0.056010,
            'P3A16384', 3, 0.020017,
            'P4A7369',  4, 0.001091,
            'P5A51438', 5, 0.000232
        ] %}

        {{- self::cos_even(a=sin_params[0], d=sin_params[1], error=sin_params[2]) }}
        {{- self::sin_even(a=sin_params[0], d=sin_params[1], error=sin_params[2]) }}

        {{- self::sin_cos_comment(sin=true, a=sin_params[3], d=sin_params[4], error=sin_params[5]) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sin{{ sin_params[3] }}(int x) {
            const int b = SinInternal.Right / 2;
            const int a = SinInternal.Right + b;
            var z = SinInternal.MakeArgOdd(x);
            var z_2 = (z * z) >> SinInternal.RightExp;
            return (a - ((z_2 * b) >> SinInternal.RightExp)) * z;
        }

        {{- self::cos_odd(a=sin_params[3], d=sin_params[4], error=sin_params[5]) }}
        {{- self::cos_even(a=sin_params[6], d=sin_params[7], error=sin_params[8]) }}
        {{- self::sin_even(a=sin_params[6], d=sin_params[7], error=sin_params[8]) }}
        {{- self::sin_p5(k=sin_params[9] | trim_start_matches(pat='P5A'), d=sin_params[10], error=sin_params[11]) }}
        {{- self::cos_odd(a=sin_params[9], d=sin_params[10], error=sin_params[11]) }}

        public enum SinMethod : byte {
            {%- for i in range(end=sin_params | length / 3) %}
            {{ sin_params | nth(n=3 * i) }},
            {%- endfor %}
            Default = {{ sin_params | nth(n=sin_params | length - 3) }},
        }

        {%- for sin in [true, false] %}
        {%- if sin %}{% set method='Sin' %}{% set jp='正弦比' %}
        {%- else   %}{% set method='Cos' %}{% set jp='余弦比' %}
        {%- endif  %}

        /// <summary>
        /// 指定された方法で{{ jp }}を近似する。
        /// <example>
        /// <code>
        /// const int k = 1 &lt;&lt; 15;
        /// var x = k * 30 / 90;
        /// var method = Intar.Mathi.SinMethod.{{ sin_params[9] }};
        /// var actual = Intar.Mathi.{{ method }}(x, method);
        /// var rad = 0.5 * System.Math.PI / k * x;
        /// var expected = System.Math.{{ method }}(rad);
        /// var a = (double)actual / (1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, {{ sin_params[11] }});
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする{{ jp }}</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int {{ method }}(int x, SinMethod method = SinMethod.Default) {
            switch (method) {
                {%- for i in range(end=sin_params | length / 3) %}
                {%- if loop.last %}
                default:{% endif %}
                case SinMethod.{{ sin_params | nth(n=3 * i) }}: return {{ method }}{{ sin_params | nth(n=3 * i) }}(x);
                {%- endfor %}
            }
        }

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
