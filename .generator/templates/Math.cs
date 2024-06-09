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

using System.Runtime.CompilerServices;

#if !NET_STANDARD_2_1 && !NET5_0_OR_GREATER
using System;
#endif

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

#if NET7_0_OR_GREATER
{% for type in ["int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "float", "double", "decimal"] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign({{ type }} v) => {{ type }}.Sign(v);
{%- endfor %}

#else
{% for type in ["int", "long", "short", "sbyte", "float", "double", "decimal"] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign({{ type }} v) => System.Math.Sign(v);
{%- endfor %}
{%- for type in ["uint", "ulong", "ushort", "byte"] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign({{ type }} v) => (v == 0) ? 0 : 1;
{%- endfor %}

#endif

    }
}
