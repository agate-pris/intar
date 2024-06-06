{% macro wrapping_add(type) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} WrappingAdd(this {{ type }} x, {{ type }} y) => unchecked(x + y);
{%- endmacro -%}

{% macro wrapping_sub(type) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} WrappingSub(this {{ type }} x, {{ type }} y) => unchecked(x - y);
{%- endmacro -%}

{% macro wrapping_mul(type) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} WrappingMul(this {{ type }} x, {{ type }} y) => unchecked(x * y);
{%- endmacro -%}

{% macro wrapping_add_sub_signed_unsigned(signed, unsigned) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ unsigned }} WrappingAddSigned(this {{ unsigned }} x, {{ signed }} y) => x.WrappingAdd(unchecked(({{ unsigned }})y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ signed }} WrappingAddUnsigned(this {{ signed }} x, {{ unsigned }} y) => x.WrappingAdd(unchecked(({{ signed }})y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ signed }} WrappingSubUnsigned(this {{ signed }} x, {{ unsigned }} y) => x.WrappingSub(unchecked(({{ signed }})y));
{%- endmacro -%}

{% macro wrapping_neg(type, zero) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} WrappingNeg(this {{ type }} x) => {{ zero }}.WrappingSub(x);
{%- endmacro -%}

{% macro wrapping_abs(type) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} WrappingAbs(this {{ type }} x) => x.IsNegative() ? x.WrappingNeg() : x;
{%- endmacro -%}

{% macro unsigned_abs(signed, unsigned) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ unsigned }} UnsignedAbs(this {{ signed }} x) => unchecked(({{ unsigned }})x.WrappingAbs());
{%- endmacro -%}

{% macro abs_diff_signed(signed, unsigned) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ unsigned }} AbsDiff(this {{ signed }} x, {{ signed }} y) {
            unchecked {
                var ux = ({{ unsigned }})x;
                var uy = ({{ unsigned }})y;
                return (x < y)
                    ? uy.WrappingSub(ux)
                    : ux.WrappingSub(uy);
            }
        }
{%- endmacro -%}

{% macro overflowing_abs(type) -%}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingAbs(this {{ type }}, out {{ type }} result) {
        //    result = x.WrappingAbs();
        //    return x == {{ type }}.MinValue;
        //}
{%- endmacro -%}

{% macro overflowing_neg_signed(type) -%}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingNeg(this {{ type }} x, out {{ type }} result) {
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
        //public static bool OverflowingNeg(this {{ type }} x, out {{ type }} result) {
        //    result = (~x).WrappingAdd(1);
        //    return x != 0;
        //}
{%- endmacro -%}

{% macro checked_neg(type) -%}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static {{ type }}? CheckedNeg(this {{ type }} x) {
        //    var b = x.OverflowingNeg(out var result);
        //    return b ? ({{ type }}?)null : result;
        //}
{%- endmacro -%}

{% macro checked_abs(type) -%}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static {{ type }}? CheckedAbs(this {{ type }} x) => x.IsNegative() ? x.CheckedNeg() : x;
{%- endmacro -%}

{% macro abs_diff_unsigned(type) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} AbsDiff(this {{ type }} x, {{ type }} y) {
            return (x < y)
                ? y - x
                : x - y;
        }
{%- endmacro -%}

using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Integer {
    public static class Overflowing {
        {{ self::wrapping_add(type = "int") }}
        {{ self::wrapping_add(type = "uint") }}
        {{ self::wrapping_add(type = "long") }}
        {{ self::wrapping_add(type = "ulong") }}
        {{ self::wrapping_sub(type = "int") }}
        {{ self::wrapping_sub(type = "uint") }}
        {{ self::wrapping_sub(type = "long") }}
        {{ self::wrapping_sub(type = "ulong") }}
        {{ self::wrapping_mul(type = "int") }}
        {{ self::wrapping_mul(type = "uint") }}
        {{ self::wrapping_mul(type = "long") }}
        {{ self::wrapping_mul(type = "ulong") }}
        {{ self::wrapping_add_sub_signed_unsigned(signed = "int", unsigned = "uint") }}
        {{ self::wrapping_add_sub_signed_unsigned(signed = "long", unsigned = "ulong") }}
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

        {{ self::overflowing_neg_signed(type = "int") }}
        {{ self::overflowing_neg_signed(type = "long") }}

        {{ self::overflowing_neg_unsigned(type = "uint") }}
        {{ self::overflowing_neg_unsigned(type = "ulong") }}

        {{ self::checked_neg(type = "int") }}
        {{ self::checked_neg(type = "long") }}
        {{ self::checked_neg(type = "uint") }}
        {{ self::checked_neg(type = "ulong") }}

        {{ self::checked_abs(type = "int") }}
        {{ self::checked_abs(type = "long") }}

        {{ self::abs_diff_signed(signed = "int", unsigned = "uint") }}
        {{ self::abs_diff_signed(signed = "long", unsigned = "ulong") }}

        {{ self::abs_diff_unsigned(type = "uint") }}
        {{ self::abs_diff_unsigned(type = "ulong") }}
    }
}
