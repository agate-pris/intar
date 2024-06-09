{% macro self_type() %}
    {%- if signed %}I
    {%- else %}U
    {%- endif %}
    {{- int_nbits}}F{{ frac_nbits }}
{%- endmacro -%}

{% macro bits_type() %}
    {%- if signed %}
        {%- if int_nbits + frac_nbits == 32 %}int
        {%- elif int_nbits + frac_nbits == 64 %}long
        {%- else %}{{ throw(message = "invalid arguments. int_nbits: " ~ int_nbits ~ ", frac_nbits: " ~ frac_nbits ) }}
        {%- endif %}
    {%- else %}
        {%- if int_nbits + frac_nbits == 32 %}uint
        {%- elif int_nbits + frac_nbits == 64 %}ulong
        {%- else %}{{ throw(message = "invalid arguments. int_nbits: " ~ int_nbits ~ ", frac_nbits: " ~ frac_nbits ) }}
        {%- endif %}
    {%- endif %}
{%- endmacro -%}

{% macro wide_bits_type() %}
    {%- if signed %}
        {%- if int_nbits + frac_nbits == 32 %}long
        {%- elif int_nbits + frac_nbits == 64 %}Int128
        {%- else %}{{ throw(message = "invalid arguments. int_nbits: " ~ int_nbits ~ ", frac_nbits: " ~ frac_nbits ) }}
        {%- endif %}
    {%- else %}
        {%- if int_nbits + frac_nbits == 32 %}ulong
        {%- elif int_nbits + frac_nbits == 64 %}UInt128
        {%- else %}{{ throw(message = "invalid arguments. int_nbits: " ~ int_nbits ~ ", frac_nbits: " ~ frac_nbits ) }}
        {%- endif %}
    {%- endif %}
{%- endmacro -%}

{% macro explicit_conversion_to_fixed() %}
{%- if int_nbits + frac_nbits == 32 %}
    {%- if signed %}
        {%- set one = 1 %}
    {%- else %}
        {%- set one = "1U" %}
    {%- endif %}
{%- else %}
    {%- if signed %}
        {%- set one = "1L" %}
    {%- else %}
        {%- set one = "1UL" %}
    {%- endif %}
{%- endif %}
{%- if frac_nbits > 31 %}
    {%- set end = 31 %}
{%- else %}
    {%- set end = frac_nbits %}
{%- endif %}
{%- for i in range(start = 1, end = end) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I{{ 32 - i }}F{{ i }}({{ self::self_type() }} x) => I{{ 32 - i }}F{{ i }}.FromBits({% if not self::bits_type() == "int" %}(int)({% endif %}x.Bits / ({{ one }} << {{ frac_nbits - i }}{% if not self::bits_type() == "int" %}){% endif %}));
{%- endfor %}
{%- if frac_nbits < 30 %}
{%- for i in range(start = frac_nbits + 1, end = 31) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I{{ 32 - i }}F{{ i }}({{ self::self_type() }} x) => I{{ 32 - i }}F{{ i }}.FromBits({% if not self::bits_type() == "int" %}(int){% endif %}x.Bits * (1 << {{ i - frac_nbits }}));
{%- endfor %}
{%- endif %}
{%- for i in range(start = 1, end = end) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U{{ 32 - i }}F{{ i }}({{ self::self_type() }} x) => U{{ 32 - i }}F{{ i }}.FromBits({% if not self::bits_type() == "uint" %}(uint)({% endif %}x.Bits / ({{ one }} << {{ frac_nbits - i }}{% if not self::bits_type() == "uint" %}){% endif %}));
{%- endfor %}
{%- if frac_nbits < 30 %}
{%- for i in range(start = frac_nbits + 1, end = 31) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U{{ 32 - i }}F{{ i }}({{ self::self_type() }} x) => U{{ 32 - i }}F{{ i }}.FromBits({% if not self::bits_type() == "uint" %}(uint){% endif %}x.Bits * (1U << {{ i - frac_nbits }}));
{%- endfor %}
{%- endif %}
{%- endmacro -%}

using System;
using System.Runtime.CompilerServices;

#if UNITY_5_6_OR_NEWER
using UnityEngine;
#endif

namespace AgatePris.Intar.Fixed {
    [Serializable]

#if !UNITY_5_6_OR_NEWER
    readonly
#endif

    public struct {{ self::self_type() }} : IEquatable<{{ self::self_type() }}>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = {{ int_nbits }};
        public const int FracNbits = {{ frac_nbits }};

        const {{ self::bits_type() }} oneRepr = 1{% if self::bits_type() == "int" -%}
        {%- elif self::bits_type() == "uint" -%}U
        {%- elif self::bits_type() == "long" -%}L
        {%- elif self::bits_type() == "ulong" -%}UL
        {%- else %}{{ throw(message = "self::bits_type returns unknown value.") }}
        {%- endif %} << FracNbits;

        // Fields
        // ------

#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif

        {{ self::bits_type() }} bits;

        // Properties
        // ----------

        public readonly {{ self::bits_type() }} Bits {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => bits;
        }

        // Static readonly properties
        // --------------------------

        public static readonly {{ self::self_type() }} Zero = FromNum(0);
        public static readonly {{ self::self_type() }} One = FromNum(1);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        {{ self::self_type() }}({{ self::bits_type() }} bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} FromBits({{ self::bits_type() }} bits) => new {{ self::self_type() }}(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} FromNum({{ self::bits_type() }} num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator +({{ self::self_type() }} left, {{ self::self_type() }} right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator -({{ self::self_type() }} left, {{ self::self_type() }} right) {
            return FromBits(left.Bits - right.Bits);
        }

{%- if int_nbits + frac_nbits == 64 %}

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

{%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator *({{ self::self_type() }} left, {{ self::self_type() }} right) {
            {{ self::wide_bits_type() }} l = left.Bits;
            return FromBits(({{ self::bits_type() }})(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator /({{ self::self_type() }} left, {{ self::self_type() }} right) {
            {{ self::wide_bits_type() }} l = left.Bits;
            return FromBits(({{ self::bits_type() }})(l * oneRepr / right.Bits));
        }

{%- if int_nbits + frac_nbits == 64 %}

#endif

{%- endif %}

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==({{ self::self_type() }} lhs, {{ self::self_type() }} rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=({{ self::self_type() }} lhs, {{ self::self_type() }} rhs) => !(lhs == rhs); {%- if int_nbits != 2 or int_nbits + frac_nbits == 32 %}

        // Methods
        // -------
{%- endif %}

{%- if int_nbits != 2 %}
{% for i in range(start = 1, end = int_nbits - 1) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {% if signed %}I{% else %}U{% endif %}{{ int_nbits - i }}F{{ frac_nbits + i }} LosslessMul({% if signed %}I{% else %}U{% endif %}{{ int_nbits + frac_nbits - i }}F{{ i }} other) => {% if signed %}I{% else %}U{% endif %}{{ int_nbits - i }}F{{ frac_nbits + i }}.FromBits(bits * other.Bits);
{%- endfor %}
{%- endif %}

{%- if int_nbits + frac_nbits == 32 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {% if signed %}I{% else %}U{% endif %}{{ int_nbits + 32 }}F{{ frac_nbits }} WideningMul(
            {%- if signed %}int{% else %}uint{% endif %} other) => {% if signed %}I{% else %}U{% endif %}{{ int_nbits + 32 }}F{{ frac_nbits }}.FromBits((
            {%- if signed %}long
            {%- else %}ulong
            {%- endif %})bits * other);
{% for i in range(start = 1, end = 31) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {% if signed %}I{% else %}U{% endif %}{{ int_nbits + 32 - i }}F{{ frac_nbits + i }} WideningMul({% if signed %}I{% else %}U{% endif %}{{ 32 - i }}F{{ i }} other) => {% if signed %}I{% else %}U{% endif %}{{ int_nbits +32 - i }}F{{ frac_nbits + i }}.FromBits(({% if signed %}long{% else %}ulong{% endif %})bits * other.Bits);
{%- endfor %}

{%- endif %}

{%- if int_nbits + frac_nbits == 32 %}

        // Implicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator {%- if signed %} I{% else %} U{% endif %}{{ 32 + int_nbits }}F{{ frac_nbits -}}({{ self::self_type() }} x) =>
        {%- if signed %} I{% else %} U{% endif %}{{ 32 + int_nbits }}F{{ frac_nbits -}}.FromBits(x.Bits);
{%- for i in range(end = 32) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator
            {%- if signed %} I{% else %} U{% endif %}{{ 32 + int_nbits - i - 1 }}F{{ frac_nbits + i + 1 -}}
        ({{ self::self_type() }} x) =>
            {%- if signed %} I{% else %} U{% endif %}{{ 32 + int_nbits - i - 1 }}F{{ frac_nbits + i + 1 -}}.FromBits((
            {%- if signed %}long{% else %}ulong{% endif %})x.Bits << {{ i + 1 }});
{%- endfor %}

{%- endif %}

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int({{ self::self_type() }} x) => {% if self::bits_type() != "int" %}(int)({% endif %}x.bits / oneRepr{% if self::bits_type() != "int" %}){% endif %};
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint({{ self::self_type() }} x) => {% if self::bits_type() != "uint" %}(uint)({% endif %}x.bits / oneRepr{% if self::bits_type() != "uint" %}){% endif %};
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long({{ self::self_type() }} x) => {% if self::bits_type() == "ulong" %}(long)({% endif %}x.bits / oneRepr{% if self::bits_type() == "ulong" %}){% endif %};
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong({{ self::self_type() }} x) => {% if signed %}(ulong)({% endif %}x.bits / oneRepr{% if signed %}){% endif %};

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float({{ self::self_type() }} x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double({{ self::self_type() }} x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal({{ self::self_type() }} x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }
{{ self::explicit_conversion_to_fixed() }}

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is {{ self::self_type() }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<{{ self::self_type() }}>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals({{ self::self_type() }} rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
