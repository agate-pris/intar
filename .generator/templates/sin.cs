{%- macro sin_even(sin, cos) %}
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int {{ sin }}(int x) => {{ cos }}(x.WrappingSub(Sin.Right));
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
        public static int {{ cos }}(int x) => {{ sin }}(x.WrappingAdd(Sin.Right));
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

{%- macro cos_p4_detail(k) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int cos_p4_{{ k }}_detail(int z) {
            const int b = {{ k }};
            const int a = b + Sin.Right;
            var z_2 = (z * z) >> Sin.RightExp;
            return (a - ((z_2 * b) >> Sin.RightExp)) * z_2;
        }
{%- endmacro -%}

{%- macro sin_p5(k) %}
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int sin_p5_{{ k }}(int x) {
            const int k = {{ k }};
            const int a = (k * 2) - (Sin.Right * 5 / 2);
            const int b = k - (Sin.Right * 3 / 2);
            var z = Sin.MakeArgOdd(x);
            var z_2 = (z * z) >> Sin.RightExp;
            return (k - (((a - ((z_2 * b) >> Sin.RightExp)) * z_2) >> Sin.RightExp)) * z;
        }
{%- endmacro -%}

using AgatePris.Intar.Fixed;
using AgatePris.Intar.Integer;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CS8981 // 型名には、小文字の ASCII 文字のみが含まれています。このような名前は、プログラミング言語用に予約されている可能性があります。
#pragma warning disable IDE1006 // 命名スタイル

    public static partial class math {

#pragma warning restore IDE1006 // 命名スタイル
#pragma warning restore CS8981 // 型名には、小文字の ASCII 文字のみが含まれています。このような名前は、プログラミング言語用に予約されている可能性があります。
#pragma warning restore IDE0079 // 不要な抑制を削除します

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
        }

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1707 // 識別子にアンダースコアを含めるべきではありません
#pragma warning restore IDE0079 // 不要な抑制を削除します

#pragma warning disable IDE1006 // 命名スタイル

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int cos_p2_detail(int z) {
            return z * z;
        }

        /// <summary>
        /// 2 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathematics.Math.CosP2(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.056010);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::cos_even(name="cos_p2", detail="cos_p2_detail") }}

        /// <summary>
        /// 2 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathematics.Math.SinP2(x);
        /// var rad = System.Math.PI / 6;
        /// var expected = System.Math.Sin(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.056010);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::sin_even(sin="sin_p2", cos="cos_p2") }}

        /// <summary>
        /// 3 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathematics.Math.SinP3_16384(x);
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
        public static int sin_p3_16384(int x) {
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
        /// var actual = Intar.Mathematics.Math.CosP3_16384(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.020017);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::cos_odd(cos="cos_p3_16384", sin="sin_p3_16384") }}

        {{- self::cos_p4_detail(k=7032) }}

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathematics.Math.CosP4_7032(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.002819);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::cos_even(name="cos_p4_7032", detail="cos_p4_7032_detail") }}

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathematics.Math.SinP4_7032(x);
        /// var rad = System.Math.PI / 6;
        /// var expected = System.Math.Sin(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.002819);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::sin_even(sin="sin_p4_7032", cos="cos_p4_7032") }}

        {{- self::cos_p4_detail(k=7384) }}

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathematics.Math.CosP4_7384(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.001174);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::cos_even(name="cos_p4_7384", detail="cos_p4_7384_detail") }}

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathematics.Math.SinP4_7384(x);
        /// var rad = System.Math.PI / 6;
        /// var expected = System.Math.Sin(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.001174);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::sin_even(sin="sin_p4_7384", cos="cos_p4_7384") }}

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathematics.Math.SinP5_51472(x);
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
        /// var actual = Intar.Mathematics.Math.CosP5_51472(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.000425);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::cos_odd(cos="cos_p5_51472", sin="sin_p5_51472") }}

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathematics.Math.SinP5_51437(x);
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
        /// var actual = Intar.Mathematics.Math.CosP5_51472(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.000226);
        /// </code>
        /// </example>
        /// </summary>
        {{- self::cos_odd(cos="cos_p5_51437", sin="sin_p5_51437") }}

        {{- self::sin_fixed(name="sin_p2", sin=true, dim=2) }}
        {{- self::sin_fixed(name="sin_p3_16384", sin=true, dim=3) }}
        {{- self::sin_fixed(name="sin_p4_7032", sin=true, dim=4) }}
        {{- self::sin_fixed(name="sin_p4_7384", sin=true, dim=4) }}
        {{- self::sin_fixed(name="cos_p5_51472", sin=false, dim=5) }}
        {{- self::sin_fixed(name="sin_p5_51437", sin=true, dim=5) }}
        {{- self::sin_fixed(name="cos_p2", sin=false, dim=2) }}
        {{- self::sin_fixed(name="cos_p3_16384", sin=false, dim=3) }}
        {{- self::sin_fixed(name="cos_p4_7032", sin=false, dim=4) }}
        {{- self::sin_fixed(name="cos_p4_7384", sin=false, dim=4) }}
        {{- self::sin_fixed(name="sin_p5_51472", sin=true, dim=5) }}
        {{- self::sin_fixed(name="cos_p5_51437", sin=false, dim=5) }}

#pragma warning restore IDE1006 // 命名スタイル

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning restore CA1707 // 識別子にアンダースコアを含めるべきではありません
#pragma warning restore IDE0079 // 不要な抑制を削除します

    }
}
