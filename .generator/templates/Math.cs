{% macro net_6_clamp(type) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Clamp({{ type }} x, {{ type }} a, {{ type }} b) => System.Math.Clamp(x, a, b);
{%- endmacro -%}

{% macro clamp(type) %}

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

#if NET_STANDARD_2_1 || NET5_0_OR_GREATER
{% for type in ["int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "float", "double", "decimal"] %}
        {{ self::net_6_clamp(type = type) }}
{%- endfor %}

#else
{%- for type in ["int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "float", "double", "decimal"] %}
        {{- self::clamp(type = type) }}
{%- endfor %}

#endif

    }
}
