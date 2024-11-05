{% import "macros.cs" as macros %}

using System.Runtime.CompilerServices;

#if NET7_0_OR_GREATER

using System;

#endif // NET7_0_OR_GREATER

namespace AgatePris.Intar {
    static class Overflowing {

{%- for bits in [32, 64, 128] %}

    {%- if bits > 64 %}

#if NET7_0_OR_GREATER

    {%- endif %}

    {%- set st = macros::inttype(bits=bits, signed=true ) %}
    {%- set ut = macros::inttype(bits=bits, signed=false) %}

    {%- for s in [true, false] %}

        {%- set t = macros::inttype(bits=bits, signed=s) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ t }} WrappingAdd({{ t }} x, {{ t }} y) {
            return unchecked(x + y);
        }

        {%- if s %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ st }} WrappingAddUnsigned({{ st }} x, {{ ut }} y) {
            return WrappingAdd(x, unchecked(({{ st }})y));
        }

        {%- else %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ ut }} WrappingAddSigned({{ ut }} x, {{ st }} y) {
            return WrappingAdd(x, unchecked(({{ ut }})y));
        }

        {%- endif %}

    {%- endfor %}

    {%- if bits > 64 %}

#endif // NET7_0_OR_GREATER

    {%- endif %}

{%- endfor %}

{%- for bits in [32, 64, 128] %}

    {%- if bits > 64 %}

#if NET7_0_OR_GREATER

    {%- endif %}

    {%- set st = macros::inttype(bits=bits, signed=true ) %}
    {%- set ut = macros::inttype(bits=bits, signed=false) %}

    {%- for s in [true, false] %}

        {%- set t = macros::inttype(bits=bits, signed=s) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ t }} WrappingSub({{ t }} x, {{ t }} y) {
            return unchecked(x - y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ t }} WrappingNeg({{ t }} x) {
            return WrappingSub(0, x);
        }

        {%- if s %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ st }} WrappingSubUnsigned({{ st }} x, {{ ut }} y) {
            return WrappingSub(x, unchecked(({{ st }})y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ t }} WrappingAbs({{ t }} x) {
            return (x < 0) ? WrappingNeg(x) : x;
        }

        {%- endif %}

    {%- endfor %}

    {%- if bits > 64 %}

#endif // NET7_0_OR_GREATER

    {%- endif %}

{%- endfor %}

    }
}
