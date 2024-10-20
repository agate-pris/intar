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

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static class Overflowing {
        {%- for t in ['int', 'uint', 'long', 'ulong'] %}

        /// <summary>
        /// <para>Adds two values together to compute their sum.</para>
        /// <para>2 つの値を加算し､ その合計を計算します｡</para>
        /// <remarks><div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ t }} StrictAdd({{ t }} x, {{ t }} y) => checked(x + y);

        /// <summary>
        /// <para>Subtracts two values to compute their difference.</para>
        /// <para>1 つの値からもう 1 つの値を引いて､ その差を計算します｡</para>
        /// <remarks><div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ t }} StrictSub({{ t }} x, {{ t }} y) => checked(x - y);

        /// <summary>
        /// <para>Multiplies two values together to compute their product.</para>
        /// <para>2 つの値を掛け合わせて､ その積を計算します｡</para>
        /// <remarks><div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ t }} StrictMul({{ t }} x, {{ t }} y) => checked(x * y);
        {%- endfor %}

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

        /// <summary>
        /// Checked integer addition. Computes <c>x + y</c>,
        /// returning <c>null</c> if overflow occured.
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// System.Assert.AreEqual(uint.MaxValue - 1U, Overflowing.CheckedAdd(uint.MaxValue - 2U, 1U));
        /// System.Assert.AreEqual(null, Overflowing.CheckedAdd(uint.MaxValue - 2U, 3U));
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ t }}? CheckedAdd({{ t }} x, {{ t }} y) {
            {{ t }}? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }

        /// <summary>
        /// Saturating integer addition. Computes <c>x + y</c>, saturating at the numeric bounds instead of overflowing.
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// System.Assert.AreEqual(101U, Overflowing.SaturatingAdd(100U, 1U));
        /// System.Assert.AreEqual(uint.MaxValue, Overflowing.SaturatingAdd(uint.MaxValue, 127U));
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ t }} SaturatingAdd({{ t }} x, {{ t }} y)
        {%- if e[0] %} {
            // オーバーフローが起きた場合、両辺が負の場合は負方向のオーバーフロー、
            // それ以外の場合は必ず正方向のオーバーフローとなる。
            // 両辺の符号が異なる場合はオーバーフローが起きないが、
            // それを検査するのは CheckedAdd の責務である。
            return CheckedAdd(x, y) ?? ((x < 0) && (y < 0)
                ? {{ t }}.MinValue
                : {{ t }}.MaxValue);
        }
        {%- else %} => CheckedAdd(x, y) ?? {{ t }}.MaxValue;
        {%- endif %}
        {%- endfor %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(int x, int y, out int result) {
            var l = Math.BigMul(x, y);
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
            var l = ((ulong)x) * y;
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
