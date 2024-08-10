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
        public static int Sin{{ a }}(int x) => Cos{{ a }}(Overflowing.WrappingSub(x, Sin.Right));
{%- endmacro -%}

{%- macro cos_even(a, d, error) %}

        {{- self::sin_cos_comment(sin=false, a=a, d=d, error=error) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Cos{{ a }}(int x) {
            var masked = x & Sin.RightMask;
            switch (Sin.ToQuadrant(x)) {
                default:
                case Sin.Quadrant.First: return Sin.One - Sin.Cos{{ a }}(masked);
                case Sin.Quadrant.Third: return Sin.Cos{{ a }}(masked) - Sin.One;
                case Sin.Quadrant.Fourth: return Sin.One - Sin.Cos{{ a }}(Sin.Right - masked);
                case Sin.Quadrant.Second: return Sin.Cos{{ a }}(Sin.Right - masked) - Sin.One;
            }
        }
{%- endmacro -%}

{%- macro cos_odd(a, d, error) %}

        {{- self::sin_cos_comment(sin=false, a=a, d=d, error=error) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Cos{{ a }}(int x) => Sin{{ a }}(Overflowing.WrappingAdd(x, Sin.Right));
{%- endmacro -%}

{%- macro cos_p4_detail(k) %}

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int CosP4A{{ k }}(int z) {
                const int a = {{ k }};
                const int b = a + Right;
                var z_2 = (z * z) >> RightExp;
                return (b - ((z_2 * a) >> RightExp)) * z_2;
            }
{%- endmacro -%}

{%- macro sin_p5(k, d, error) %}

        {{- self::sin_cos_comment(sin=true, a='P5A'~k, d=d, error=error) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SinP5A{{ k }}(int x) {
            const int k = {{ k }};
            const int a = (k * 2) - (Sin.Right * 5 / 2);
            const int b = k - (Sin.Right * 3 / 2);
            var z = Sin.MakeArgOdd(x);
            var z_2 = (z * z) >> Sin.RightExp;
            return (k - (((a - ((z_2 * b) >> Sin.RightExp)) * z_2) >> Sin.RightExp)) * z;
        }
{%- endmacro -%}

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static class Mathi {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int AsinInternal(int x) {
            var ret = 391 * x;

            const int k1 = 50762241;
            ret = ((k1 - ret) >> 15) * x;

            const int k2 = 144994038;
            ret = ((k2 - ret) >> 15) * x;

            const int k3 = 1073695665;
            ret = (k3 - ret) >> 15;

            const int k0 = 1 << 15;

            return (int)Sqrt(k0 * (k0 - (uint)x)) * ret;
        }

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Asin(int x) {
            var negate = x < 0;
            var sign = Math.Sign(x);
            x = AsinInternal(negate ? -x : x);
            return sign * ((1 << 30) - x);
        }

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
                return (int)((k + Math.Abs(xl)) / (xl << 1));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int Div(int a, int b) {
                var al = ((long)a) << 16;
                var bl = (long)b;
                return (int)((al + (Math.Sign(a) * Math.Abs(bl))) / (bl << 1));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P2A2850(int x) {
                const int a = 2850;
                var xAbs = Math.Abs(x);
                var tmp = (One - xAbs) * a;
                tmp = FracK4 + (tmp >> 15);
                return x * tmp;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P3A2555B691(int x) {
                const int a = 2555;
                const int b = 691;
                var xAbs = Math.Abs(x);
                var tmp = (xAbs * b) >> 15;
                tmp = (One - xAbs) * (a + tmp);
                tmp = FracK4 + (tmp >> 15);
                return x * tmp;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int P5A787B2968(int x) {
                const int a = 787;
                const int b = 2968;
                const int c = (1 << 13) + b - a;
                var x2 = (x * x) >> 15;
                var tmp = (a * x2) >> 15;
                tmp = (b - tmp) * x2;
                tmp = c - (tmp >> 15);
                return tmp * x;
            }
        }

{%- set atan_params = [
    'P2A2850',     2, 0.003778,
    'P3A2555B691', 3, 0.001543,
    'P5A787B2968', 5, 0.000767
] %}
{%- for i in range(end=atan_params | length / 3) %}
{%- set method = atan_params | nth(n=loop.index0 * 3    ) %}
{%- set d      = atan_params | nth(n=loop.index0 * 3 + 1) %}
{%- set error  = atan_params | nth(n=loop.index0 * 3 + 2) %}

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
            if (x < Atan.OneNeg) {
                return Atan.RightNeg - Atan.{{ method }}(Atan.Inv(x));
            } else if (x > Atan.One) {
                return Atan.Right - Atan.{{ method }}(Atan.Inv(x));
            } else {
                return Atan.{{ method }}(x);
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
        /// Assert.AreEqual(expected, a, {{ error }});
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
                        ? Atan.RightNeg - Atan.{{ method }}(Atan.Div(x, y))
                        : Atan.{{ method }}(Atan.Div(y, x)) - Atan.Straight;
                } else if (x > 0) {
                    return y < -x
                        ? Atan.RightNeg - Atan.{{ method }}(Atan.Div(x, y))
                        : Atan.{{ method }}(Atan.Div(y, x));
                } else {
                    return Atan.RightNeg;
                }
            } else if (y > 0) {
                if (x < 0) {
                    return -y < x
                        ? Atan.Right - Atan.{{ method }}(Atan.Div(x, y))
                        : Atan.Straight + Atan.{{ method }}(Atan.Div(y, x));
                } else if (x > 0) {
                    return y > x
                        ? Atan.Right - Atan.{{ method }}(Atan.Div(x, y))
                        : Atan.{{ method }}(Atan.Div(y, x));
                } else {
                    return Atan.Right;
                }
            } else {
                return x < 0 ? Atan.Straight : 0;
            }
        }

{%- endfor %}

{%- for type in ["int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte"] %}
        {{- self::clamp(type = type) }}
{%- endfor %}
{% for type in ["int", "uint", "long", "ulong"] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Half({{ type }} x) => x / 2;
{%- endfor %}

        internal static class Sin {
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

            {{- self::cos_p4_detail(k=7032) }}
            {{- self::cos_p4_detail(k=7384) }}
        }

        {{- self::cos_even(a='P2', d=2, error=0.056010) }}
        {{- self::sin_even(a='P2', d=2, error=0.056010) }}

        {{- self::sin_cos_comment(sin=true, a='P3A16384', d=3, error=0.020017) }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SinP3A16384(int x) {
            const int b = Sin.Right / 2;
            const int a = Sin.Right + b;
            var z = Sin.MakeArgOdd(x);
            var z_2 = (z * z) >> Sin.RightExp;
            return (a - ((z_2 * b) >> Sin.RightExp)) * z;
        }

        {{- self::cos_odd(a="P3A16384", d=3, error=0.020017) }}
        {{- self::cos_even(a="P4A7032", d=4, error=0.002819) }}
        {{- self::sin_even(a="P4A7032", d=4, error=0.002819) }}
        {{- self::cos_even(a="P4A7384", d=4, error=0.001174) }}
        {{- self::sin_even(a="P4A7384", d=4, error=0.001174) }}
        {{- self::sin_p5(k=51472, d=5, error=0.000425) }}
        {{- self::cos_odd(a="P5A51472", d=5, error=0.000425) }}
        {{- self::sin_p5(k=51437, d=5, error=0.000226) }}
        {{- self::cos_odd(a="P5A51437", d=5, error=0.000226) }}

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
