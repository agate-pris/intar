{% import "macros.cs" as macros %}
{%- set self_type = macros::fixed_type(s = signed, i = int_nbits, f = frac_nbits) %}
{%- set self_bits_type      = macros::inttype(bits=int_nbits  +frac_nbits,   signed=signed) %}
{%- set self_wide_bits_type = macros::inttype(bits=int_nbits*2+frac_nbits*2, signed=signed) %}

{#- 固定小数点数の定義 -#}

using System;
using System.Runtime.CompilerServices;

{%- if int_nbits + frac_nbits > 32 %}

#if NET7_0_OR_GREATER

using {% if signed %}I{% else %} U{% endif %}{{
    int_nbits * 2 + frac_nbits * 2 }} = System.{% if not signed %}U{% endif %}Int{{
    int_nbits * 2 + frac_nbits * 2 }};

#endif // NET7_0_OR_GREATER

{%- endif %}

namespace AgatePris.Intar {
    [Serializable]
    public struct {{ self_type }} : IEquatable<{{ self_type }}>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = {{ int_nbits }};
        public const int FracNbits = {{ frac_nbits }};

        const {{ self_bits_type }} OneRepr = {{
            macros::one(bits=int_nbits+frac_nbits, signed=signed)
        }} << FracNbits;

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

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified num.</para>
        /// <para>指定された数値から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドはオーバーフローを引き起こします。その場合の動作はビルド時の既定のオーバーフロー チェック コンテキストに従います。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = {{ self_type }}.FromNum(1);
        /// System.Assert.AreEqual(1 &lt;&lt; {{ frac_nbits }}, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} FromNum({{ self_bits_type }} num) => FromBits(num * OneRepr);

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified num.</para>
        /// <para>指定された数値から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = {{ self_type }}.StrictFromNum(1);
        /// System.Assert.AreEqual(1 &lt;&lt; {{ frac_nbits }}, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} StrictFromNum({{ self_bits_type }} num) => FromBits(checked(num * OneRepr));

        {%- set type_1 = ['float', '1.0f'] %}
        {%- set type_2 = ['double', '1.0'] %}
        {%- set type_3 = ['decimal', '1.0m'] %}
        {%- for t in [type_1, type_2, type_3] %}

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified num.</para>
        /// <para>指定された数値から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドはオーバーフローを引き起こします。その場合の動作はビルド時の既定のオーバーフロー チェック コンテキストに従います。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = {{ self_type }}.FromNum({{ t[1] }});
        /// System.Assert.AreEqual(1 &lt;&lt; {{ frac_nbits }}, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} FromNum({{ t[0] }} num) => FromBits(({{ self_bits_type }})(num * OneRepr));

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified num.</para>
        /// <para>指定された数値から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = {{ self_type }}.StrictFromNum({{ t[1] }});
        /// System.Assert.AreEqual(1 &lt;&lt; {{ frac_nbits }}, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} StrictFromNum({{ t[0] }} num) => FromBits(checked(({{ self_bits_type }})(num * OneRepr)));

        {%- endfor %}

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
            return FromBits(({{ self_bits_type }})(l * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator /({{ self_type }} left, {{ self_type }} right) {
            {{ self_wide_bits_type }} l = left.Bits;
            return FromBits(({{ self_bits_type }})(l * OneRepr / right.Bits));
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==({{ self_type }} lhs, {{ self_type }} rhs) => lhs.Bits == rhs.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=({{ self_type }} lhs, {{ self_type }} rhs) => lhs.Bits != rhs.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <({{ self_type }} left, {{ self_type }} right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >({{ self_type }} left, {{ self_type }} right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=({{ self_type }} left, {{ self_type }} right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=({{ self_type }} left, {{ self_type }} right) => left.Bits >= right.Bits;

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int({{ self_type }} x) => {% if self_bits_type != "int" %}(int)({% endif %}x.Bits / OneRepr{% if self_bits_type != "int" %}){% endif %};
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint({{ self_type }} x) => {% if self_bits_type != "uint" %}(uint)({% endif %}x.Bits / OneRepr{% if self_bits_type != "uint" %}){% endif %};
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long({{ self_type }} x) => {% if self_bits_type == "ulong" %}(long)({% endif %}x.Bits / OneRepr{% if self_bits_type == "ulong" %}){% endif %};
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong({{ self_type }} x) => {% if signed %}(ulong)({% endif %}x.Bits / OneRepr{% if signed %}){% endif %};

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float({{ self_type }} x) {
            const float k = 1.0f / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double({{ self_type }} x) {
            const double k = 1.0 / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal({{ self_type }} x) {
            const decimal k = 1.0M / OneRepr;
            return k * x.Bits;
        }

{#- 自身と異なる小数点数型への型変換の定義 #}
{% for s in [true, false] %}
    {%- for target in fixed_list %}
        {#- 自身と異なる型の場合のみ定義する #}
        {%- set i = target[0] %}
        {%- set f = target[1] %}
        {%- if s != signed or i != int_nbits or f != frac_nbits %}
            {%- set target_type = macros::fixed_type(s=s, i=i, f=f) %}
            {#- 符号ありから符号なしへのキャストは常に explicit
                符号なしから符号ありへのキャストはターゲットの整数部が自身以下、
                またはターゲットの小数部が自身未満の場合 explicit
                それ以外の場合、ターゲットの整数部が自身未満、
                またはターゲットの小数部が自身未満の場合 explicit #}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {%if
            signed and not s
            or not signed and s and int_nbits >= i
            or not signed and s and frac_nbits > f
            or signed == s and int_nbits > i
            or signed == s and frac_nbits > f
        %}explicit{%
            else
        %}implicit{%
            endif
        %} operator {{ target_type }}({{ self_type }} x) => {{ target_type }}.FromBits(
            {#- ターゲットの小数部がより小さい場合、除算してからキャストする。
                ターゲットの小数部がより大きい場合、キャストしてから乗算する。
                ターゲットの小数部が同じ場合、ただキャストする。
                いずれの場合も内部表現型が暗黙型変換可能な場合はキャストしない。 #}
            {%- set cast
                = signed and not s
                or not signed and s and int_nbits + frac_nbits >= i + f
                or signed ==s and int_nbits + frac_nbits > i + f %}
            {%- if cast -%}
                ({{ macros::inttype(bits=i+f, signed=s) }})
            {%- endif -%}
            {%- if frac_nbits > f -%}
                {%- if cast %}({% endif -%}
                x.Bits / ({{ macros::one(bits=int_nbits+frac_nbits, signed=signed) }} << {{ frac_nbits - f }})
                {%- if cast %}){% endif -%}
            {%- elif frac_nbits < f -%}
                x.Bits * ({{ macros::one(bits=i+f, signed=s) }} << {{ f - frac_nbits }})
            {%- else -%}
                x.Bits
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
        public {{ self_type }} SaturatingAdd({{ self_type }} other) {
            return FromBits(Overflowing.SaturatingAdd(Bits, other.Bits));
        }

        {%- if int_nbits + frac_nbits <= 32 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool OverflowingMul({{ self_type }} other, out {{ self_type }} result) {
            var bits = (({{ self_wide_bits_type }})Bits) * other.Bits / OneRepr;
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

{%- for output in fixed_list %}
    {%- for rhs in fixed_list %}
        {%- if int_nbits + rhs[0] == output[0]
            and frac_nbits + rhs[1] == output[1] %}
            {%- set output_type = macros::fixed_type(s=signed, i=int_nbits+rhs[0], f=frac_nbits+rhs[1]) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{
            output_type
        }} BigMul({{
            macros::fixed_type(s=signed, i=rhs[0], f=rhs[1])
        }} other) => {{ output_type }}.FromBits(({{
            self_wide_bits_type
        }})Bits * other.Bits);
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

        {%- for v in vector_list %}
        {%- if v[0] == int_nbits and v[1] == frac_nbits %}

        // ベクトル型との演算
        // ------------------

{%- if not signed %}

#if AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

{%- endif %}
{# これは改行を挿入するためのコメントです #}

        {%- for dim in [2, 3, 4] %}
        {%- set vec_type = macros::vector_type(dim=dim, type=self_type) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ vec_type }} SaturatingMul({{ vec_type }} other) => other.SaturatingMul(this);
        {%- endfor %}

{%-if not signed %}

#endif // AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

{%- endif %}

        {%- endif %}
        {%- endfor %}

    }
} // namespace AgatePris.Intar
