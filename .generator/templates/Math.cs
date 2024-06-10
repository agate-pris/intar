{% macro clamp(type) %}

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> や
        /// <c>Intar.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// この関数は .NET 5 または .NET Standard 2.1 以降の場合 <c>System.Math.Clamp</c> を呼ぶ.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} Clamp({{ type }} v, {{ type }} min, {{ type }} max) {
#if NET_STANDARD_2_1 || NET5_0_OR_GREATER
            return System.Math.Clamp(v, min, max);
#else
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
#endif
        }
{%- endmacro -%}

using System.Runtime.CompilerServices;

#if !NET_STANDARD_2_1 && !NET5_0_OR_GREATER
using System;
#endif

namespace AgatePris.Intar {
    public static partial class Math {

{%- for type in ["int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "float", "double", "decimal"] %}
        {{- self::clamp(type = type) }}
{%- endfor %}

#if NET7_0_OR_GREATER
{%- for type in ["int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "float", "double", "decimal"] %}

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>{{ type }}.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign({{ type }} v) => {{ type }}.Sign(v);
{%- endfor %}

#else
{%- for type in ["int", "long", "short", "sbyte", "float", "double", "decimal"] %}

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>{{ type }}.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign({{ type }} v) => System.Math.Sign(v);
{%- endfor %}
{%- for type in ["uint", "ulong", "ushort", "byte"] %}

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>{{ type }}.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign({{ type }} v) => (v == 0) ? 0 : 1;
{%- endfor %}

#endif

    }
}
