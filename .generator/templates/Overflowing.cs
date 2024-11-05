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

        {%- set u_32 = [false, 32] %}
        {%- set u_64 = [false, 64] %}
        {%- set i_32 = [true,  32] %}
        {%- set i_64 = [true,  64] %}
        {%- for e in [u_32, u_64, i_32, i_64] %}
        {%- set t = macros::inttype(signed=e[0], bits=e[1]) %}

        /// <summary>
        /// <para>Calculates <c>x + y</c></para>
        /// </summary>
        /// <returns>
        /// Returns a boolean indicating whether an arithmetic overflow would occur.
        /// </returns>
        /// <example>
        /// Basic usage:
        /// <code>
        /// System.Assert.AreEqual(false, Overflowing.OverflowingAdd(5U, 2U, out var result));
        /// System.Assert.AreEqual(true, Overflowing.OverflowingAdd(uint.MaxValue, 1U, out result));
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd({{ t }} x, {{ t }} y, out {{ t }} result) {
            // unchecked コンテキストでは、整数の演算結果はラップアラウンドする。
            result = unchecked(x + y);

            {%- if e[0] %}

            // 右辺が 0 未満の場合、結果がより大きくなったらオーバーフロー。
            // それ以外の場合、結果がより小さくなったらオーバーフロー。
            return y < 0 ? result > x : result < x;
            {%- else %}

            // 結果がより小さくなったらオーバーフロー。
            return result < x;
            {%- endif %}
        }

        {%- endfor %}

    }
}
