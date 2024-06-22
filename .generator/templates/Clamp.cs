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

using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class Mathi {
{%- for type in ["int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte"] %}
        {{- self::clamp(type = type) }}
{%- endfor %}

{% for end in [32, 64] %}
{% for s in [true, false] %}
{% for i in range(start=2, end=end) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ macros::fixed_type(s=s, i=i, f=end-i) }} Clamp(this {{ macros::fixed_type(s=s, i=i, f=end-i) }} x, {{ macros::fixed_type(s=s, i=i, f=end-i) }} min, {{ macros::fixed_type(s=s, i=i, f=end-i) }} max) => {{ macros::fixed_type(s=s, i=i, f=end-i) }}.FromBits(Clamp(x.Bits, min.Bits, max.Bits));
{%- endfor %}
{%- endfor %}
{%- endfor %}

    }
}
