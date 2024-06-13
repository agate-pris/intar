{% macro fixed_type(s, i, f) %}
    {%- if s %}I
    {%- else %}U{% endif %}
    {{- i }}F
    {{- f }}
{%- endmacro -%}

{% macro self_type() %}
    {{- self::fixed_type(s = signed, i = int_nbits, f = frac_nbits) }}
{%- endmacro -%}

{%- macro bits_type(s, i, f) %}
    {%- if s %}
        {%- if i + f == 32 %}int
        {%- elif i + f == 64 %}long
        {%- else %}{{ throw(message = "invalid arguments. i: " ~ i ~ ", f: " ~ f ) }}
        {%- endif %}
    {%- else %}
        {%- if i + f == 32 %}uint
        {%- elif i + f == 64 %}ulong
        {%- else %}{{ throw(message = "invalid arguments. i: " ~ i ~ ", f: " ~ f ) }}
        {%- endif %}
    {%- endif %}
{%- endmacro %}

{%- macro self_bits_type() %}
    {{- self::bits_type(s=signed, i=int_nbits, f=frac_nbits) }}
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

{%- macro one_literal(t) %}
    {%- if t == "int"     -%}1
    {%- elif t == "uint"  -%}1U
    {%- elif t == "long"  -%}1L
    {%- elif t == "ulong" -%}1UL
    {%- else %}
        {{ throw(message=t) }}
    {%- endif %}
{%- endmacro %}

{%- macro def_conv(s, i, f) %}
    {#- 自身と異なる型の場合のみ定義する #}
    {%- if s != signed or i != int_nbits or f != frac_nbits %}
        {%- set sbt = self::self_bits_type() %}
        {%- set self_bits_type_one = self::one_literal(t = sbt) %}
        {%- set target_bits_type = self::bits_type(s=s, i=i, f=f) -%}
        {%- set target_bits_type_one = self::one_literal(t = target_bits_type) %}
        {%- set target_type = self::fixed_type(s=s, i=i, f=f) %}
        {%- set explicit = signed and s == false or frac_nbits > f or
            signed and s and int_nbits > i or
            signed and not s and int_nbits - 1 > i or
            not signed and s and int_nbits > i - 1 or
            not signed and not s and int_nbits > i
        %}
        {%- set cast =
            sbt == "int" and (target_bits_type == "uint" or target_bits_type == "ulong") or
            sbt == "uint" and (target_bits_type == "int") or
            sbt == "long" and (target_bits_type == "int" or target_bits_type == "uint" or target_bits_type == "ulong") or
            sbt == "ulong" and (target_bits_type == "int" or target_bits_type == "uint" or target_bits_type == "long")
        %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static
        {%- if explicit %} explicit
        {%- else %} implicit
        {%- endif %} operator {{ target_type }}(
        {{- self::self_type() }} x) => {{ target_type -}}
        .FromBits(
        {%- if f == frac_nbits -%}
            {%- if cast %}({{ target_bits_type }}){% endif -%}
            x.Bits
            {%- elif f > frac_nbits -%}
            {%- if cast %}({{ target_bits_type }}){% endif -%}
            x.Bits * (
                {{- target_bits_type_one }} << {{ f - frac_nbits -}}
            )
            {%- else -%}
            {%- if cast %}({{ target_bits_type }})({% endif -%}
            x.Bits / (
                {{- self_bits_type_one }} << {{ frac_nbits - f -}}
            )
            {%- if cast %}){% endif %}
        {%- endif -%}
        );
    {%- endif %}
{%- endmacro %}

{%- macro explicit_conversion_to_fixed() %}
{%- for i in range(start = 1, end = 31) %}
    {{- self::def_conv(s=true, i=32-i, f=i) }}
{%- endfor %}
{%- for i in range(start = 1, end = 31) %}
    {{- self::def_conv(s=false, i=32-i, f=i) }}
{%- endfor %}
{%- for i in range(start = 1, end = 63) %}
    {{- self::def_conv(s=true, i=64-i, f=i) }}
{%- endfor %}
{%- for i in range(start = 1, end = 63) %}
    {{- self::def_conv(s=false, i=64-i, f=i) }}
{%- endfor %}
{%- endmacro -%}

using System;
using System.Runtime.CompilerServices;

#if UNITY_5_6_OR_NEWER
using UnityEngine;
#endif

namespace AgatePris.Intar.Fixed {
    [Serializable]
    public

#if !UNITY_5_6_OR_NEWER
    readonly
#endif

    struct {{ self::self_type() }} : IEquatable<{{ self::self_type() }}>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = {{ int_nbits }};
        public const int FracNbits = {{ frac_nbits }};

        const {{ self::self_bits_type() }} oneRepr = 1{% if self::self_bits_type() == "int" -%}
        {%- elif self::self_bits_type() == "uint" -%}U
        {%- elif self::self_bits_type() == "long" -%}L
        {%- elif self::self_bits_type() == "ulong" -%}UL
        {%- else %}{{ throw(message = "self::self_bits_type returns unknown value.") }}
        {%- endif %} << FracNbits;

        // Fields
        // ------

#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif

        {{ self::self_bits_type() }} bits;

        // Properties
        // ----------

        public readonly {{ self::self_bits_type() }} Bits {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => bits;
        }

        // Static readonly properties
        // --------------------------

        public static readonly {{ self::self_type() }} Zero = FromNum(0);
        public static readonly {{ self::self_type() }} One = FromNum(1);
        public static readonly {{ self::self_type() }} MinValue = FromBits({{ self::self_bits_type() }}.MinValue);
        public static readonly {{ self::self_type() }} MaxValue = FromBits({{ self::self_bits_type() }}.MaxValue);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        {{ self::self_type() }}({{ self::self_bits_type() }} bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} FromBits({{ self::self_bits_type() }} bits) => new {{ self::self_type() }}(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} FromNum({{ self::self_bits_type() }} num) => FromBits(num * oneRepr);

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
            return FromBits(({{ self::self_bits_type() }})(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator /({{ self::self_type() }} left, {{ self::self_type() }} right) {
            {{ self::wide_bits_type() }} l = left.Bits;
            return FromBits(({{ self::self_bits_type() }})(l * oneRepr / right.Bits));
        }

{%- if int_nbits + frac_nbits == 64 %}

#endif

{%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator +({{ self::self_type() }} x) => FromBits(+x.Bits);

{%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator -({{ self::self_type() }} x) => FromBits(-x.Bits);
{%- endif %}

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==({{ self::self_type() }} lhs, {{ self::self_type() }} rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=({{ self::self_type() }} lhs, {{ self::self_type() }} rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <({{ self::self_type() }} left, {{ self::self_type() }} right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >({{ self::self_type() }} left, {{ self::self_type() }} right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=({{ self::self_type() }} left, {{ self::self_type() }} right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=({{ self::self_type() }} left, {{ self::self_type() }} right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self::self_type() }} Min({{ self::self_type() }} other) => FromBits(System.Math.Min(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self::self_type() }} Max({{ self::self_type() }} other) => FromBits(System.Math.Max(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self::self_type() }} Clamp({{ self::self_type() }} min, {{ self::self_type() }} max) => FromBits(Math.Clamp(bits, min.Bits, max.Bits));
{%- if signed %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self::self_type() }} Abs() => FromBits(System.Math.Abs(bits));
{%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self::self_type() }} LosslessMul(
            {{- self::self_bits_type() }} other) => FromBits(bits * other);
{%- if int_nbits != 2 %}
{%- for i in range(start = 1, end = int_nbits - 1) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {% if signed %}I{% else %}U{% endif %}{{ int_nbits - i }}F{{ frac_nbits + i }} LosslessMul({% if signed %}I{% else %}U{% endif %}{{ int_nbits + frac_nbits - i }}F{{ i }} other) => {% if signed %}I{% else %}U{% endif %}{{ int_nbits - i }}F{{ frac_nbits + i }}.FromBits(bits * other.Bits);
{%- endfor %}
{%- endif %}

{%- if int_nbits + frac_nbits == 32 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {% if signed %}I{% else %}U{% endif %}{{ int_nbits + 32 }}F{{ frac_nbits }} WideningMul(
            {{- self::self_bits_type() }} other) => {% if signed %}I{% else %}U{% endif %}{{ int_nbits + 32 }}F{{ frac_nbits }}.FromBits((
                {{- self::wide_bits_type() -}}
            )bits * other);
{%- for i in range(start = 1, end = 31) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {% if signed %}I{% else %}U{% endif %}{{ int_nbits + 32 - i }}F{{ frac_nbits + i }} WideningMul({% if signed %}I{% else %}U{% endif %}{{ 32 - i }}F{{ i }} other) => {% if signed %}I{% else %}U{% endif %}{{ int_nbits +32 - i }}F{{ frac_nbits + i }}.FromBits(({% if signed %}long{% else %}ulong{% endif %})bits * other.Bits);
{%- endfor %}

{%- endif %}

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int({{ self::self_type() }} x) => {% if self::self_bits_type() != "int" %}(int)({% endif %}x.bits / oneRepr{% if self::self_bits_type() != "int" %}){% endif %};
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint({{ self::self_type() }} x) => {% if self::self_bits_type() != "uint" %}(uint)({% endif %}x.bits / oneRepr{% if self::self_bits_type() != "uint" %}){% endif %};
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long({{ self::self_type() }} x) => {% if self::self_bits_type() == "ulong" %}(long)({% endif %}x.bits / oneRepr{% if self::self_bits_type() == "ulong" %}){% endif %};
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
        public override readonly string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<{{ self::self_type() }}>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals({{ self::self_type() }} other) => bits == other.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
