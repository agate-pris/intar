{% import "macros.cs" as macros %}
{%- set self_type = macros::fixed_type(s = signed, i = int_nbits, f = frac_nbits) %}
{%- set self_bits_type      = macros::inttype(bits=int_nbits  +frac_nbits,   signed=signed) %}
{%- set self_wide_bits_type = macros::inttype(bits=int_nbits*2+frac_nbits*2, signed=signed) %}

{%- macro def_conv(self_type, self_bits_type, s, i, f) %}
    {#- 自身と異なる型の場合のみ定義する #}
    {%- if s != signed or i != int_nbits or f != frac_nbits %}
        {%- set target_bits_type = macros::inttype(bits=i+f, signed=s) -%}
        {%- set target_type = macros::fixed_type(s=s, i=i, f=f) %}
        {%- set explicit = signed and s == false or frac_nbits > f or
            signed and s and int_nbits > i or
            signed and not s and int_nbits - 1 > i or
            not signed and s and int_nbits > i - 1 or
            not signed and not s and int_nbits > i
        %}
        {%- set cast =
            self_bits_type == "int" and (target_bits_type == "uint" or target_bits_type == "ulong") or
            self_bits_type == "uint" and (target_bits_type == "int") or
            self_bits_type == "long" and (target_bits_type == "int" or target_bits_type == "uint" or target_bits_type == "ulong") or
            self_bits_type == "ulong" and (target_bits_type == "int" or target_bits_type == "uint" or target_bits_type == "long")
        %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static
        {%- if explicit %} explicit
        {%- else %} implicit
        {%- endif %} operator {{ target_type }}(
        {{- self_type }} x) => {{ target_type -}}
        .FromBits(
        {%- if f == frac_nbits -%}
            {%- if cast %}({{ target_bits_type }}){% endif -%}
            x.Bits
            {%- elif f > frac_nbits -%}
            {%- if cast %}({{ target_bits_type }}){% endif -%}
            x.Bits * (
                {{- macros::one(bits=i+f, signed=s) }} << {{ f - frac_nbits -}}
            )
            {%- else -%}
            {%- if cast %}({{ target_bits_type }})({% endif -%}
            x.Bits / (
                {{- macros::one(bits=int_nbits+frac_nbits, signed=signed) }} << {{ frac_nbits - f -}}
            )
            {%- if cast %}){% endif %}
        {%- endif -%}
        );
    {%- endif %}
{%- endmacro %}

{%- macro explicit_conversion_to_fixed(self_type, self_bits_type) %}
{%- for i in range(start = 1, end = 31) %}
    {{- self::def_conv(self_type=self_type, self_bits_type=self_bits_type, s=true, i=32-i, f=i) }}
{%- endfor %}
{%- for i in range(start = 1, end = 31) %}
    {{- self::def_conv(self_type=self_type, self_bits_type=self_bits_type, s=false, i=32-i, f=i) }}
{%- endfor %}
{%- for i in range(start = 1, end = 63) %}
    {{- self::def_conv(self_type=self_type, self_bits_type=self_bits_type, s=true, i=64-i, f=i) }}
{%- endfor %}
{%- for i in range(start = 1, end = 63) %}
    {{- self::def_conv(self_type=self_type, self_bits_type=self_bits_type, s=false, i=64-i, f=i) }}
{%- endfor %}
{%- endmacro -%}

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct {{ self_type }} : IEquatable<{{ self_type }}>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = {{ int_nbits }};
        public const int FracNbits = {{ frac_nbits }};

        const {{ self_bits_type }} oneRepr = 1{% if self_bits_type == "int" -%}
        {%- elif self_bits_type == "uint" -%}U
        {%- elif self_bits_type == "long" -%}L
        {%- elif self_bits_type == "ulong" -%}UL
        {%- else %}{{ throw(message = "self::self_bits_type returns unknown value.") }}
        {%- endif %} << FracNbits;

        // Fields
        // ------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public {{ self_bits_type }} Bits;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        {{ self_type }}({{ self_bits_type }} bits) {
            Bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} FromBits({{ self_bits_type }} bits) => new {{ self_type }}(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} FromNum({{ self_bits_type }} num) => FromBits(num * oneRepr);

        // Static Properties
        // -----------------

        public static {{ self_type }} Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(0);
        }
        public static {{ self_type }} One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(1);
        }
        public static {{ self_type }} MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits({{ self_bits_type }}.MinValue);
        }
        public static {{ self_type }} MaxValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits({{ self_bits_type }}.MaxValue);
        }

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator +({{ self_type }} left, {{ self_type }} right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator -({{ self_type }} left, {{ self_type }} right) {
            return FromBits(left.Bits - right.Bits);
        }

{%- if int_nbits + frac_nbits == 64 %}

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

{%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator *({{ self_type }} left, {{ self_type }} right) {
            {{ self_wide_bits_type }} l = left.Bits;
            return FromBits(({{ self_bits_type }})(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator /({{ self_type }} left, {{ self_type }} right) {
            {{ self_wide_bits_type }} l = left.Bits;
            return FromBits(({{ self_bits_type }})(l * oneRepr / right.Bits));
        }

{%- if int_nbits + frac_nbits == 64 %}

#endif

{%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator +({{ self_type }} x) => FromBits(+x.Bits);

{%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator -({{ self_type }} x) => FromBits(-x.Bits);
{%- endif %}

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==({{ self_type }} lhs, {{ self_type }} rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=({{ self_type }} lhs, {{ self_type }} rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <({{ self_type }} left, {{ self_type }} right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >({{ self_type }} left, {{ self_type }} right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=({{ self_type }} left, {{ self_type }} right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=({{ self_type }} left, {{ self_type }} right) => left.Bits >= right.Bits;

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int({{ self_type }} x) => {% if self_bits_type != "int" %}(int)({% endif %}x.Bits / oneRepr{% if self_bits_type != "int" %}){% endif %};
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint({{ self_type }} x) => {% if self_bits_type != "uint" %}(uint)({% endif %}x.Bits / oneRepr{% if self_bits_type != "uint" %}){% endif %};
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long({{ self_type }} x) => {% if self_bits_type == "ulong" %}(long)({% endif %}x.Bits / oneRepr{% if self_bits_type == "ulong" %}){% endif %};
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong({{ self_type }} x) => {% if signed %}(ulong)({% endif %}x.Bits / oneRepr{% if signed %}){% endif %};

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float({{ self_type }} x) {
            const float k = 1.0f / oneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double({{ self_type }} x) {
            const double k = 1.0 / oneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal({{ self_type }} x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.Bits;
        }
{# これは空行挿入用のコメント #}
        {%- for other_signed in [true, false] %}
        {%- for other in fixed_list %}
        {%- if not signed == other_signed or not int_nbits == other[0] or not frac_nbits == other[1] %}
        {%- set other_type = macros::fixed_type(s=other_signed, i=other[0], f=other[1]) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static{% if
            signed != other_signed or
            int_nbits > other[0] or
            frac_nbits > other[1]
        %} explicit {% else %} implicit {% endif %}operator {{
            other_type
        }}({{ self_type }} x) => {{ other_type }}.FromBits(
            {#- 変換先の型より小数部のビット数が小さい場合、その分の値を掛ける #}
            {#- 内部表現の値は必ずより大きくなる、かつ符号が変わることはないので #}
            {#- 変換先の型に変換してから乗算を行う #}
            {#- 変換先の型より小数部のビット数が大きい場合、その分の値で割る #}
            {#- この時、小数部のビット数はどちらも 0 より大きいので #}
            {#- 除算に用いる値は必ず自身の型の表現の範囲内で表現できる #}
            {#- 除算後、変換先の型と符号の有無が同じ、かつ変換先のビット数が変換元以上の場合、暗黙の型変換を行う #}
            {#- それ以外の場合、明示的に型変換を行う #}
            {#- 変換先の型と小数部のビット数が同じ場合ただ値を変換する #}
            {#- 変換先の型と符号の有無が同じ、かつ変換先の型の整数部のビット数の方が大きい場合、暗黙の型変換を行う #}
            {#- それ以外の場合、明示的に型変換を行う #}
            {%- if frac_nbits < other[1] %}
                {%- if signed != other_signed or int_nbits + frac_nbits > other[0] + other[1] -%}
                    ({{ macros::inttype(bits=other[0]+other[1], signed=other_signed) }})
                {%- endif %}x.Bits * ({{ macros::one(bits=other[0]+other[1], signed=other_signed) }} << {{ other[1] - frac_nbits }})
            {%- elif frac_nbits > other[1] %}
                {%- if signed != other_signed or int_nbits + frac_nbits > other[0] + other[1] -%}
                    ({{ macros::inttype(bits=other[0]+other[1], signed=other_signed) }})(x.Bits / ({{ macros::one(bits=int_nbits+frac_nbits, signed=signed) }} << {{ frac_nbits - other[1] }}))
                {%- else -%}
                    x.Bits / ({{ macros::one(bits=int_nbits+frac_nbits, signed=signed) }} << {{ frac_nbits - other[1] }})
                {%- endif %}
            {%- else %}
                {%- if signed != other_signed or int_nbits > other[0] -%}
                    ({{ macros::inttype(bits=other[0]+other[1], signed=other_signed) }})
                {%- endif %}x.Bits
            {%- endif -%}
        );
        {%- endif %}
        {%- endfor %}
        {%- endfor %}

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is {{ self_type }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<{{ self_type }}>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ self_type }} other) => Bits == other.Bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} Min({{ self_type }} other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} Max({{ self_type }} other) => FromBits(Math.Max(Bits, other.Bits));
{%- if signed %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} Abs() => FromBits(Math.Abs(Bits));
{%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} Clamp(
            {{ self_type }} min, {{ self_type }} max
        ) => FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} Half() => FromBits(Mathi.Half(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} Twice() => FromBits(Mathi.Twice(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} WrappingAdd({{ self_type }} other) => FromBits(Overflowing.WrappingAdd(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} WrappingSub({{ self_type }} other) => FromBits(Overflowing.WrappingSub(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} WrappingMul({{ self_type }} other) => FromBits(Overflowing.WrappingMul(Bits, other.Bits));

        {%- if signed %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} WrappingAddUnsigned({{ macros::fixed_type(s=false, i=int_nbits, f=frac_nbits) }} other) => FromBits(Overflowing.WrappingAddUnsigned(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} WrappingSubUnsigned({{ macros::fixed_type(s=false, i=int_nbits, f=frac_nbits) }} other) => FromBits(Overflowing.WrappingSubUnsigned(Bits, other.Bits));
        {%- else %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} WrappingAddSigned({{ macros::fixed_type(s=true, i=int_nbits, f=frac_nbits) }} other) => FromBits(Overflowing.WrappingAddSigned(Bits, other.Bits));
        {%- endif %}

        {%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ macros::fixed_type(s=false, i=int_nbits, f=frac_nbits) }} UnsignedAbs() {
            return {{ macros::fixed_type(s=false, i=int_nbits, f=frac_nbits) }}.FromBits(Overflowing.UnsignedAbs(Bits));
        }

        {%- endif %}

        {%- if int_nbits + frac_nbits <= 32 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool OverflowingAdd({{ self_type }} other, out {{ self_type }} result) {
            var b = Overflowing.OverflowingAdd(Bits, other.Bits, out var bits);
            result = FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}? CheckedAdd({{ self_type }} other) {
            {{ self_type }}? @null = null;
            return OverflowingAdd(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        {%- if signed %}
        public {{ self_type }} SaturatingAdd({{ self_type }} other) {
            return CheckedAdd(other) ?? ((Bits < 0) && (other.Bits < 0)
                ? MinValue
                : MaxValue);
        }
        {%- else %}
        public {{ self_type }} SaturatingAdd({{ self_type }} other) {
            return CheckedAdd(other) ?? MaxValue;
        }
        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool OverflowingMul({{ self_type }} other, out {{ self_type }} result) {
            var bits = (({{ self_wide_bits_type }})Bits) * other.Bits / oneRepr;
            result = FromBits(unchecked(({{ self_bits_type }})bits));
            {%- if signed %}
            return bits < {{ self_bits_type }}.MinValue || bits > {{ self_bits_type }}.MaxValue;
            {%- else %}
            return bits > {{ self_bits_type }}.MaxValue;
            {%- endif %}
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}? CheckedMul({{ self_type }} other) {
            {{ self_type }}? @null = null;
            return OverflowingMul(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} SaturatingMul({{ self_type }} other) {
            {%- if signed %}
            return CheckedMul(other) ?? (((Bits < 0) == (other.Bits < 0))
                ? MaxValue
                : MinValue);
            {%- else %}
            return CheckedMul(other) ?? MaxValue;
            {%- endif %}
        }

        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} LosslessMul({{
            self_bits_type
        }} other) => FromBits(Bits * other);

        {%- for result in fixed_list %}
        {%- for other in fixed_list %}
        {%- if
            int_nbits + frac_nbits == result[0] + result[1] and
            int_nbits + frac_nbits == other[0] + other[1] and
            result[1] == frac_nbits + other[1]
        %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{
            macros::fixed_type(s=signed, i=result[0], f=result[1])
        }} LosslessMul({{
            macros::fixed_type(s=signed, i=other[0], f=other[1])
        }} other) => {{
            macros::fixed_type(s=signed, i=result[0], f=result[1])
        }}.FromBits(Bits * other.Bits);
        {%- endif %}
        {%- endfor %}
        {%- endfor %}

        {%- for result in fixed_list %}
        {%- for other in [32, 64] %}
        {%- if int_nbits + other == result[0] and frac_nbits == result[1] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{
            macros::fixed_type(s=signed, i=int_nbits+other, f=frac_nbits)
        }} WideningMul({{ macros::inttype(bits=other, signed=signed) }} other) => {{
            macros::fixed_type(s=signed, i=int_nbits+other, f=frac_nbits)
        }}.FromBits(({{ macros::inttype(bits=int_nbits+frac_nbits+other, signed=signed) }})Bits * other);
        {%- endif %}
        {%- endfor %}
        {%- endfor %}

        {%- for result in fixed_list %}
        {%- for other in fixed_list %}
        {%- if int_nbits + other[0] == result[0] and frac_nbits + other[1] == result[1] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{
            macros::fixed_type(s=signed, i=int_nbits+other[0], f=frac_nbits+other[1])
        }} WideningMul({{ macros::inttype(bits=other, signed=signed) }} other) => {{
            macros::fixed_type(s=signed, i=int_nbits+other[0], f=frac_nbits+other[1])
        }}.FromBits(({{ macros::inttype(bits=int_nbits+frac_nbits+other[0]+other[1], signed=signed) }})Bits * other);
        {%- endif %}
        {%- endfor %}
        {%- endfor %}

        {%- if signed and int_nbits == 17 and frac_nbits == 15 %}
        {%- for name in [
            "SinP4",
            "SinP5",
            "CosP4",
            "CosP5",
        ] %}
        {%- set sin = name is starting_with("Sin") %}
        {%- set dim = name | trim_start_matches(pat="SinP") | trim_start_matches(pat="CosP") | truncate(length=1, end="") %}

        /// <summary>
        /// {{ dim }} 次の多項式で{% if sin %}正弦比{% else %}余弦比{% endif %}を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>{% if sin %}正弦比{% else %}余弦比{% endif %}</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 {{ name }}() => I2F30.FromBits(Mathi.{{ name }}(Bits));

        {%- endfor %}
        {%- endif %}

        {%- if int_nbits + frac_nbits == 32 and int_nbits > 1 and frac_nbits > 1 %}

        // ベクトル型との演算
        // ------------------
{% for dim in [2, 3, 4] %}
{%- set vec_type = macros::vector_type(dim=dim, type=self_type) %}
        //[MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ vec_type }} SaturatingMul({{ vec_type }} other) => other.SaturatingMul(this);
{%- endfor %}

        {%- endif %}

    }
} // namespace AgatePris.Intar
