{%- macro sin_even(sin, cos) %}
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int {{ sin }}(int x) => {{ cos }}(Overflowing.WrappingSub(x, Sin.Right));
{%- endmacro -%}

{%- macro cos_even(name, detail) %}
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int {{ name }}(int x) {
            var masked = x & Sin.RightMask;
            return Sin.ToQuadrant(x) switch {
                Sin.Quadrant.Second => {{ detail }}(Sin.Right - masked) - Sin.One,
                Sin.Quadrant.Fourth => Sin.One - {{ detail }}(Sin.Right - masked),
                Sin.Quadrant.Third => {{ detail }}(masked) - Sin.One,
                Sin.Quadrant.First => Sin.One - {{ detail }}(masked),
#if NET7_0_OR_GREATER
                _ => throw new System.Diagnostics.UnreachableException(),
#else
                _ => throw new System.NotImplementedException(),
#endif
            };
        }
{%- endmacro -%}

{%- macro cos_odd(cos, sin) %}
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int {{ cos }}(int x) => {{ sin }}(Overflowing.WrappingAdd(x, Sin.Right));
{%- endmacro -%}

{%- macro sincos(s, i, o) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos_{{ s }}({{ i }} x, out {{ o }} s, out {{ o }} c) {
            s = sin_{{ s }}(x);
            c = cos_{{ s }}(x);
        }
{%- endmacro -%}

{%- macro sincos_int(s) %}
    {{- self::sincos(s=s, i="int", o="int") }}
{%- endmacro -%}

{%- macro sin_fixed(name, sin, dim) %}

        /// <summary>
        /// {{ dim }} 次の多項式で{% if sin %}正弦比{% else %}余弦比{% endif %}を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>{% if sin %}正弦比{% else %}余弦比{% endif %}</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 {{ name }}(I17F15 x) => I2F30.FromBits({{ name }}(x.Bits));
{%- endmacro -%}

{%- macro sin_vec(n, t, d) %}

        public static {{ t }} {{ n }}({{ t }} x) => {{ t }}(
            {{ n }}(x.x),
            {{ n }}(x.y){% if d > 2 %},
            {{ n }}(x.z){% if d > 3 %},
            {{ n }}(x.w){% endif %}{% endif %});
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

{%- macro sin_p5(k) %}
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
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

using AgatePris.Intar.Numerics;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class Mathi {
        internal sealed class Sin {
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
                var z = ToQuadrant(x) switch {
                    Quadrant.Second => Right - masked,
                    Quadrant.Fourth => masked - Right,
                    Quadrant.Third => -masked,
                    Quadrant.First => masked,
                    _ => throw new System.NotImplementedException(),
                };
                return z;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int CosP2(int z) {
                return z * z;
            }

            {{- self::cos_p4_detail(k=7032) }}
            {{- self::cos_p4_detail(k=7384) }}
        }

        /// <summary>
        /// 2 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathi.CosP2(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.056010);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::cos_even(name="CosP2", detail="Sin.CosP2") }}

        /// <summary>
        /// 2 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathi.SinP2(x);
        /// var rad = System.Math.PI / 6;
        /// var expected = System.Math.Sin(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.056010);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::sin_even(sin="SinP2", cos="CosP2") }}

        /// <summary>
        /// 3 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathi.SinP3_16384(x);
        /// var rad = System.Math.PI / 6;
        /// var expected = System.Math.Sin(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.020017);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SinP3A16384(int x) {
            const int b = Sin.Right / 2;
            const int a = Sin.Right + b;
            var z = Sin.MakeArgOdd(x);
            var z_2 = (z * z) >> Sin.RightExp;
            return (a - ((z_2 * b) >> Sin.RightExp)) * z;
        }

        /// <summary>
        /// 3 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathi.CosP3_16384(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.020017);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::cos_odd(cos="CosP3A16384", sin="SinP3A16384") }}

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathi.CosP4_7032(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.002819);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::cos_even(name="CosP4A7032", detail="Sin.CosP4A7032") }}

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathi.SinP4_7032(x);
        /// var rad = System.Math.PI / 6;
        /// var expected = System.Math.Sin(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.002819);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::sin_even(sin="SinP4A7032", cos="CosP4A7032") }}

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathi.CosP4_7384(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.001174);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::cos_even(name="CosP4A7384", detail="Sin.CosP4A7384") }}

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathi.SinP4_7384(x);
        /// var rad = System.Math.PI / 6;
        /// var expected = System.Math.Sin(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.001174);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::sin_even(sin="SinP4A7384", cos="CosP4A7384") }}

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathi.SinP5_51472(x);
        /// var rad = System.Math.PI / 6;
        /// var expected = System.Math.Sin(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.000425);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::sin_p5(k=51472) }}

        /// <summary>
        /// 5 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathi.CosP5_51472(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.000425);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::cos_odd(cos="CosP5A51472", sin="SinP5A51472") }}

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathi.SinP5_51437(x);
        /// var rad = System.Math.PI / 6;
        /// var expected = System.Math.Sin(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.000226);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::sin_p5(k=51437) }}

        /// <summary>
        /// 5 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathi.CosP5_51472(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.000226);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::cos_odd(cos="CosP5A51437", sin="SinP5A51437") }}

        {{- self::sin_fixed(name="SinP2", sin=true, dim=2) }}
        {{- self::sin_fixed(name="SinP3A16384", sin=true, dim=3) }}
        {{- self::sin_fixed(name="SinP4A7032", sin=true, dim=4) }}
        {{- self::sin_fixed(name="SinP4A7384", sin=true, dim=4) }}
        {{- self::sin_fixed(name="SinP5A51472", sin=true, dim=5) }}
        {{- self::sin_fixed(name="SinP5A51437", sin=true, dim=5) }}
        {{- self::sin_fixed(name="CosP2", sin=false, dim=2) }}
        {{- self::sin_fixed(name="CosP3A16384", sin=false, dim=3) }}
        {{- self::sin_fixed(name="CosP4A7032", sin=false, dim=4) }}
        {{- self::sin_fixed(name="CosP4A7384", sin=false, dim=4) }}
        {{- self::sin_fixed(name="CosP5A51472", sin=false, dim=5) }}
        {{- self::sin_fixed(name="CosP5A51437", sin=false, dim=5) }}
    }
}
