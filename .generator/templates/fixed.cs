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
        public static bool operator !=({{ self::self_type() }} lhs, {{ self::self_type() }} rhs) => !(lhs == rhs);

{%- if int_nbits + frac_nbits == 32 %}

        // Implicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator
        {%- if signed %} I{% else %} U{% endif %}{{ 32 + int_nbits }}F{{ frac_nbits -}}
        ({{ self::self_type() }} x) =>
        {%- if signed %} I{% else %} U{% endif %}{{ 32 + int_nbits }}F{{ frac_nbits -}}.FromBits(x.Bits);

        {%- for i in range(end = 32) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator
            {%- if signed %} I{% else %} U{% endif %}{{ 32 + int_nbits - i - 1 }}F{{ frac_nbits + i + 1 -}}
        ({{ self::self_type() }} x) =>
            {%- if signed %} I{% else %} U{% endif %}{{ 32 + int_nbits - i - 1 }}F{{ frac_nbits + i + 1 -}}.FromBits((
            {%- if signed %}long{% else %}ulong{% endif %})x.Bits << {{ i + 1 }});
        {%- endfor %}

{%- endif %}

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator {{ self::bits_type() }}({{ self::self_type() }} x) {
            return x.bits / oneRepr;
        }

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
