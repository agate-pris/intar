{% import "macros.cs" as macros %}

{% macro wrapping_add(type) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} WrappingAdd({{ type }} x, {{ type }} y) => unchecked(x + y);
{%- endmacro -%}

{% macro wrapping_sub(type) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} WrappingSub({{ type }} x, {{ type }} y) => unchecked(x - y);
{%- endmacro -%}

{% macro wrapping_mul(type) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} WrappingMul({{ type }} x, {{ type }} y) => unchecked(x * y);
{%- endmacro -%}

{% macro wrapping_add_signed(unsigned, signed) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ unsigned }} WrappingAddSigned({{ unsigned }} x, {{ signed }} y) => WrappingAdd(x, unchecked(({{ unsigned }})y));
{%- endmacro -%}

{% macro wrapping_add_unsigned(signed, unsigned) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ signed }} WrappingAddUnsigned({{ signed }} x, {{ unsigned }} y) => WrappingAdd(x, unchecked(({{ signed }})y));
{%- endmacro -%}

{% macro wrapping_sub_unsigned(signed, unsigned) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ signed }} WrappingSubUnsigned({{ signed }} x, {{ unsigned }} y) => WrappingSub(x, unchecked(({{ signed }})y));
{%- endmacro -%}

{% macro wrapping_neg(type, zero) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} WrappingNeg({{ type }} x) => WrappingSub({{ zero }}, x);
{%- endmacro -%}

{% macro wrapping_abs(type) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} WrappingAbs({{ type }} x) => (x < 0) ? WrappingNeg(x) : x;
{%- endmacro -%}

{% macro unsigned_abs(signed, unsigned) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ unsigned }} UnsignedAbs({{ signed }} x) => unchecked(({{ unsigned }})WrappingAbs(x));
{%- endmacro -%}

{% macro abs_diff_signed(signed, unsigned) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ unsigned }} AbsDiff({{ signed }} x, {{ signed }} y) {
            unchecked {
                var ux = ({{ unsigned }})x;
                var uy = ({{ unsigned }})y;
                return (x < y)
                    ? WrappingSub(uy, ux)
                    : WrappingSub(ux, uy);
            }
        }
{%- endmacro -%}

{% macro overflowing_abs(type) -%}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingAbs({{ type }}, out {{ type }} result) {
        //    result = WrappingAbs(x);
        //    return x == {{ type }}.MinValue;
        //}
{%- endmacro -%}

{% macro overflowing_neg_signed(type) -%}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingNeg({{ type }} x, out {{ type }} result) {
        //    if (x == {{ type }}.MinValue) {
        //        result = {{ type }}.MinValue;
        //        return true;
        //    } else {
        //        result = -x;
        //        return false;
        //    }
        //}
{%- endmacro -%}

{% macro overflowing_neg_unsigned(type) -%}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingNeg({{ type }} x, out {{ type }} result) {
        //    result = WrappingAdd(~x, 1);
        //    return x != 0;
        //}
{%- endmacro -%}

{% macro checked_neg(type) -%}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static {{ type }}? CheckedNeg({{ type }} x) {
        //    var b = OverflowingNeg(x, out var result);
        //    return b ? ({{ type }}?)null : result;
        //}
{%- endmacro -%}

{% macro checked_abs(type) -%}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static {{ type }}? CheckedAbs({{ type }} x) => (x < 0) ? x.CheckedNeg() : x;
{%- endmacro -%}

{% macro abs_diff_unsigned(type) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} AbsDiff({{ type }} x, {{ type }} y) {
            return (x < y)
                ? y - x
                : x - y;
        }
{%- endmacro -%}

using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static class Overflowing {
        {{ self::wrapping_add(type = "int") }}
        {{ self::wrapping_add(type = "uint") }}
        {{ self::wrapping_add(type = "long") }}
        {{ self::wrapping_add(type = "ulong") }}
        {{- self::wrapping_add_signed(unsigned="uint", signed="int") }}
        {{- self::wrapping_add_signed(unsigned="ulong", signed="long") }}
        {{- self::wrapping_add_unsigned(signed="int", unsigned="uint") }}
        {{- self::wrapping_add_unsigned(signed="long", unsigned="ulong") }}
        {{ self::overflowing_neg_unsigned(type = "uint") }}
        {{ self::overflowing_neg_unsigned(type = "ulong") }}
        {{ self::checked_neg(type = "uint") }}
        {{ self::checked_neg(type = "ulong") }}
        {{ self::checked_abs(type = "int") }}
        {{ self::checked_abs(type = "long") }}
        {{ self::wrapping_sub(type = "int") }}
        {{ self::wrapping_sub(type = "uint") }}
        {{ self::wrapping_sub(type = "long") }}
        {{ self::wrapping_sub(type = "ulong") }}
        {{- self::wrapping_sub_unsigned(signed="int", unsigned="uint") }}
        {{- self::wrapping_sub_unsigned(signed="long", unsigned="ulong") }}
        {{ self::abs_diff_signed(signed = "int", unsigned = "uint") }}
        {{ self::abs_diff_signed(signed = "long", unsigned = "ulong") }}
        {{ self::wrapping_neg(type = "int", zero = "0") }}
        {{ self::wrapping_neg(type = "long", zero = "0L") }}
        {{ self::wrapping_neg(type = "uint", zero = "0U") }}
        {{ self::wrapping_neg(type = "ulong", zero = "0UL") }}
        {{ self::wrapping_abs(type = "int") }}
        {{ self::wrapping_abs(type = "long") }}
        {{ self::unsigned_abs(signed = "int", unsigned = "uint") }}
        {{ self::unsigned_abs(signed = "long", unsigned = "ulong") }}
        {{ self::overflowing_abs(type = "int") }}
        {{ self::overflowing_abs(type = "long") }}

        {{ self::wrapping_mul(type = "int") }}
        {{ self::wrapping_mul(type = "uint") }}
        {{ self::wrapping_mul(type = "long") }}
        {{ self::wrapping_mul(type = "ulong") }}

        {{ self::abs_diff_unsigned(type = "uint") }}
        {{ self::abs_diff_unsigned(type = "ulong") }}

        {{ self::overflowing_neg_signed(type = "int") }}
        {{ self::overflowing_neg_signed(type = "long") }}
        {{ self::checked_neg(type = "int") }}
        {{ self::checked_neg(type = "long") }}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(int x, int y, out int result) {
            var tmp = ((long)x) + y;
            result = unchecked((int)tmp);
            return tmp < int.MinValue || tmp > int.MaxValue;
        }
        {{ macros::checked_add(type="int", ext=false) | indent(prefix="        ") }}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SaturatingAdd(int x, int y) {
            return CheckedAdd(x, y) ?? ((x < 0) && (y < 0)
                ? int.MinValue
                : int.MaxValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(uint x, uint y, out uint result) {
            var tmp = ((ulong)x) + y;
            result = unchecked((uint)tmp);
            return tmp > uint.MaxValue;
        }
        {{ macros::checked_add(type="uint", ext=false) | indent(prefix="        ") }}
        {{ macros::saturating_add_unsigned(type="uint", ext=false) | indent(prefix="        ") }}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(int x, int y, out int result) {
            long l = x;
            l *= y;
            result = unchecked((int)l);
            return l < int.MinValue || l > int.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int? CheckedMul(int x, int y) {
            int? @null = null;
            return OverflowingMul(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SaturatingMul(int x, int y) => CheckedMul(x, y) ?? (
            ((x < 0) == (y < 0))
            ? int.MaxValue
            : int.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(uint x, uint y, out uint result) {
            ulong l = x;
            l *= y;
            result = unchecked((uint)l);
            return l > int.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint? CheckedMul(uint x, uint y) {
            uint? @null = null;
            return OverflowingMul(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SaturatingMul(uint x, uint y) => CheckedMul(x, y) ?? uint.MaxValue;

    }
}
