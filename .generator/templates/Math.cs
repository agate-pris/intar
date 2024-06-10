{% macro clamp(type) %}

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> や
        /// <c>Intar.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// この関数は .NET 5 または .NET Standard 2.1 以降の場合 <c>System.Math.Clamp</c> を呼ぶ.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} Clamp({{ type }} v, {{ type }} min, {{ type }} max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }
{%- endmacro -%}

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class Math {
{% for type in ["int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "float", "double", "decimal"] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsZero(this {{ type }} v) => v == 0;
{%- endfor %}
{%- for type in ["int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "float", "double", "decimal"] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeExclusive(this {{ type }} v) => v < 0;
{%- endfor %}
{%- for type in ["int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "float", "double", "decimal"] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveExclusive(this {{ type }} v) => v > 0;
{%- endfor %}
{%- for type in ["int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "float", "double", "decimal"] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeInclusive(this {{ type }} v) => v <= 0;
{%- endfor %}
{%- for type in ["int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "float", "double", "decimal"] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveInclusive(this {{ type }} v) => v >= 0;
{%- endfor %}

{%- for type in ["int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "float", "double", "decimal"] %}
        {{- self::clamp(type = type) }}
{%- endfor %}

{%- for type in ["int", "long", "short", "sbyte", "float", "double", "decimal"] %}

        /// <summary>
        /// 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign({{ type }} v) => System.Math.Sign(v);
{%- endfor %}

{%- for type in ["uint", "ulong", "ushort", "byte"] %}

        /// <summary>
        /// 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign({{ type }} v) => (v == 0) ? 0 : 1;
{%- endfor %}

{%- for type in ["int", "long", "short", "sbyte"] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} CopySign(this {{ type }} v, {{ type }} sign) {
            unchecked {
                var abs = {% if type == "short" or type == "sbyte" -%}
                    ({{ type }})(
                {%- endif -%}
                        v < 0 ? -v : v
                {%- if type == "short" or type == "sbyte" -%}
                    )
                {%- endif -%}
                ;
                if (sign >= 0) {
                    if (abs < 0) {
                        throw new OverflowException(
                            "Negating the minimum value of a twos complement number is invalid."
                        );
                    }
                    return abs;
                }
                return {% if type == "short" or type == "sbyte" -%}
                    ({{ type }})
                {%- endif -%}
                    -abs;
            }
        }
{%- endfor %}

    }
}
