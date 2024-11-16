{% import "macros.cs" as macros %}
{%- set bits   = macros::inttype(signed=signed, bits = int_nbits+frac_nbits) %}
{%- set bits_u = macros::inttype(signed=false,  bits = int_nbits+frac_nbits) %}
{%- set component   = macros::fixed_type(s=signed, i=int_nbits, f=frac_nbits) %}
{%- set component_u = macros::fixed_type(s=false,  i=int_nbits, f=frac_nbits) %}
{%- set vector = macros::vector_type(dim=dim, type=component) %}
{%- set repr = macros::vector_primitive(dim=dim, signed=signed, bits = int_nbits+frac_nbits) %}
{%- if int_nbits+frac_nbits < 128 %}
    {%- set wide_bits_u = macros::inttype(bits= 2*int_nbits + 2*frac_nbits, signed=false) %}
    {%- set wide_component = macros::fixed_type(s=signed, i = 2*int_nbits, f = 2*frac_nbits) %}
    {%- set wide_vector = macros::vector_type(dim=dim, type=wide_component) %}
    {%- set wide_repr = macros::vector_primitive(dim=dim, signed=signed, bits = 2*int_nbits + 2*frac_nbits) %}
{%- endif %}
{%- set components = ['X', 'Y', 'Z', 'W']|slice(end=dim) %}
{%- if int_nbits+frac_nbits > 64 -%}
#if NET7_0_OR_GREATER

{% endif -%}

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct {{ vector }}
    : IEquatable<{{ vector }}>
    , IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public {{ repr }} Repr;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

{%- if int_nbits+frac_nbits < 128 %}
    {%- if int_nbits+frac_nbits > 32 %}

#if NET7_0_OR_GREATER
    {%- endif %}

        internal {{ wide_repr }} WideRepr {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Repr;
        }
    {%- if int_nbits+frac_nbits > 32 %}

#endif // NET7_0_OR_GREATER
    {%- endif %}
{%- endif %}
{% for c in components %}
        public {{ component }} {{ c }} {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => {{ component }}.FromBits(Repr.{{ c }});
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.{{ c }} = value.Bits;
        }
{%- endfor %}

        public {{ component }} this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => {{ component }}.FromBits(Repr[index]);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr[index] = value.Bits;
        }

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }}({{ repr }} repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }}(
{%- for c in components -%}
    {{ component }} {{ c|lower }}{% if not loop.last %}, {% endif %}
{%- endfor -%}
        ) : this(new {{ repr }}(
{%- for c in components -%}
    {{ c|lower }}.Bits{% if not loop.last %}, {% endif %}
{%- endfor -%}
        )) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }}({{ component }} value) : this(
{%- for i in range(end=dim) -%}
    value{% if not loop.last %}, {% endif %}
{%- endfor -%}
        ) { }

        // Constants
        // ---------------------------------------

        public static readonly {{ vector }} Zero = new {{ vector }}({{ component }}.Zero);
        public static readonly {{ vector }} One = new {{ vector }}({{ component }}.One);
{%- for i in range(end=dim) %}
    {%- if i >= dim %}{% continue %}{% endif %}
        public static readonly {{ vector }} Unit{{ components[i] }} = new {{ vector }}(
    {%- for j in range(end=dim) %}
        {{- component }}.
        {%- if i == j %}One{% else %}Zero{% endif %}
        {%- if not loop.last %}, {% endif %}
    {%- endfor %});
{%- endfor %}

        //
        // IAdditionOperators
        // ISubtractionOperators
        //

{%- for o in ['+', '-'] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator {{ o }}({{ vector }} a, {{ vector }} b) {
            return new {{ vector }}(a.Repr {{ o }} b.Repr);
        }

{%- endfor %}

{%- if int_nbits+frac_nbits < 128 %}
    {%- if int_nbits+frac_nbits > 32 %}

#if NET7_0_OR_GREATER
    {%- endif %}

        //
        // IIMultiplyOperators
        // IDivisionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator *({{ vector }} a, {{ vector }} b) {
            return new {{ vector }}(({{ repr }})(a.WideRepr * b.WideRepr / {{ component }}.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator *({{ vector }} a, {{component}} b) {
            return new {{ vector }}(({{ repr }})(a.WideRepr * b.Bits / {{ component }}.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator *({{ component }} a, {{ vector }} b) {
            return b * a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator /({{ vector }} a, {{ vector }} b) {
            return new {{ vector }}(({{ repr }})(a.WideRepr * {{ component }}.OneRepr / b.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator /({{ vector }} a, {{ component }} b) {
            return new {{ vector }}(({{ repr }})(a.WideRepr * {{ component }}.OneRepr / b.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator /({{ component }} a, {{ vector }} b) {
            return new {{ vector }}(({{ repr }})(a.WideBits * {{ component }}.OneRepr / b.WideRepr));
        }
    {%- if int_nbits+frac_nbits > 32 %}

#endif // NET7_0_OR_GREATER
    {%- endif %}
{%- endif %}

        //
        // IUnaryPlusOperators
        // IUnaryNegationOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator +({{ vector }} x) {
            return new {{ vector }}(+x.Repr);
        }

{%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator -({{ vector }} x) {
            return new {{ vector }}(-x.Repr);
        }

{%- endif %}

        //
        // IEqualityOperators
        //

{%- for o in ['==', '!='] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator {{ o
        }}({{ vector }} lhs, {{ vector }} rhs) => lhs.Repr {{ o }} rhs.Repr;

{%- endfor %}

        //
        // Object
        //

        public override bool Equals(object obj) => obj is {{ vector }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<
{%- for c in components -%}
    { {{- c -}} } {%- if not loop.last %}, {% endif %}
{%- endfor -%}
        >";

        //
        // IEquatable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ vector }} other) {
            return Repr.Equals(other.Repr);
        }

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"<
{%- for c in components -%}
    { {{- c }}.ToString(format, formatProvider)} {%- if not loop.last %}, {% endif %}
{%- endfor -%}
            >";
        }

        //
        // Methods
        //

{%- for m in ['Min', 'Max'] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} {{ m }}({{ vector }} other) {
            return new {{ vector }}(Repr.{{ m }}(other.Repr));
        }

{%- endfor %}

        {%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} Abs() => new {{ vector }}(Repr.Abs());

        {%- endif %}

{%- for m in ['Half', 'Twice'] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal {{ vector }} {{ m }}() => new {{ vector }}(Repr.{{ m }}());

{%- endfor %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} Clamp({{ component }} min, {{ component }} max) {
            return new {{ vector }}(Repr.Clamp(min.Bits, max.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} Clamp({{ vector }} min, {{ vector }} max) {
            return new {{ vector }}(Repr.Clamp(min.Repr, max.Repr));
        }

{%- if int_nbits+frac_nbits < 128 %}
    {%- if int_nbits+frac_nbits > 32 %}

#if NET7_0_OR_GREATER
    {%- endif %}
    {%- if signed and dim == 3 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ wide_vector }} Cross({{ vector }} other) {
            var tmp = Repr.Cross(other.Repr);
            return new {{ wide_vector }}(tmp);
        }
    {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ wide_component }} UncheckedDot({{ vector }} other) {
            return {{ wide_component }}.FromBits(Repr.UncheckedDot(other.Repr));
        }
    {%- if int_nbits+frac_nbits > 32 %}

#endif // NET7_0_OR_GREATER
    {%- endif %}
{%- endif %}
{%- if int_nbits+frac_nbits < 64 %}

    {%- if not signed or dim > 3 %}

        // ベクトルの長さは符号つき、
        // かつ次元が 3 以下の場合のみ定義される。

    {%- else %}

    {%- set len_sqr_ty = macros::fixed_type(s=false, i=int_nbits*2, f=frac_nbits * 2) %}

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ len_sqr_ty }} LengthSquared() {
            var a1 = Mathi.UnsignedAbs(X.Bits);
            var a2 = Mathi.UnsignedAbs(Y.Bits);{% if dim > 2 %}
            var a3 = Mathi.UnsignedAbs(Z.Bits);{% if dim > 3 %}
            var a4 = Mathi.UnsignedAbs(W.Bits);{% endif %}{% endif %}
            var s1 = ({{ wide_bits_u }})a1 * a1;
            var s2 = ({{ wide_bits_u }})a2 * a2;{% if dim > 2 %}
            var s3 = ({{ wide_bits_u }})a3 * a3;{% if dim > 3 %}
            var s4 = ({{ wide_bits_u }})a4 * a4;{% endif %}{% endif %}
            return {{ len_sqr_ty }}.FromBits(s1 + s2
            {%- if dim > 2 %} + s3
            {%- if dim > 3 %} + s4
            {%- endif %}{% endif %});
        }

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ component_u }} Length() {
            return {{ component_u }}.FromBits(({{ bits_u }})Mathi.Sqrt(LengthSquared().Bits));
        }

    {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }}? Normalize() {
            {%- if signed %}

            // 各要素の内部表現型を取り出し、
            // その絶対値を得る。

            var x0 = X.Bits;
            var x1 = Y.Bits;{% if dim > 2 %}
            var x2 = Z.Bits;{% if dim > 3 %}
            var x3 = W.Bits;{% endif %}{% endif %}

            {%- for i in range(end=dim) %}
            var b{{ i }} = x{{ i }} < 0;
            {%- endfor %}

            {%- for i in range(end=dim) %}
            var a{{ i }} = unchecked(({{ bits_u }})(b{{ i }} ? Overflowing.WrappingNeg(x{{ i }}) : x{{ i }}));
            {%- endfor %}

            {%- else -%}

            var a0 = X.Bits;
            var a1 = Y.Bits;{% if dim > 2 %}
            var a2 = Z.Bits;{% if dim > 3 %}
            var a3 = W.Bits;{% endif %}{% endif %}

            {%- endif %}

            // 各要素の最大値が 0 の場合は null を返す。

            var max = {% if dim > 2 %}Math.Max({% endif -%}
                Math.Max(a0, a1)
                {%- if dim == 3 %}, a2{% endif %}
                {%- if dim == 4 %}, Math.Max(a2, a3){% endif %}
                {%- if dim > 2 %}){% endif %};
            if (max == 0) {
                return null;
            }

            // ベクトルの大きさが小さい時の誤差を小さくするため、
            // 最大の要素が表現型の範囲に収まるように拡大する。
            // 最大の要素以外にも同じ値を乗算する。

            {{ wide_bits_u }} m = {{ bits_u }}.MaxValue / max;

            {%- for i in range(end=dim) %}
            var l{{ i }} = m * a{{ i }};
            {%- endfor %}
            var sum =
                (l0 * l0 / 4) +
                (l1 * l1 / 4){% if dim > 2 %} +
                (l2 * l2 / 4){% if dim > 3 %} +
                (l3 * l3 / 4){% endif %}{% endif %};
            var ll = Mathi.Sqrt(sum);

            // 小数部の桁をあわせる。

            const {{ wide_bits_u }} k = {{
                macros::one(signed=false, bits = 2*(int_nbits+frac_nbits))
            }} << {{ frac_nbits - 1 }};

            {%- for i in range(end=dim) %}
            var y{{ i }} = ({{ bits }})(l{{ i }} * k / ll);
            {%- endfor %}

            // 最後に符号をあわせて返す。

            return new {{ vector }}(
                {{ component }}.FromBits({% if signed %}b0 ? -y0 : {% endif %}y0),
                {{ component }}.FromBits({% if signed %}b1 ? -y1 : {% endif %}y1){% if dim > 2 %},
                {{ component }}.FromBits({% if signed %}b2 ? -y2 : {% endif %}y2){% if dim > 3 %},
                {{ component }}.FromBits({% if signed %}b3 ? -y3 : {% endif %}y3){% endif %}{% endif %});
        }

    {%- endif %}

        {%- if component == "I17F15" %}
        {%- for name in [
            "SinP4",
            "SinP5",
            "CosP4",
            "CosP5",
        ] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ macros::vector_type(dim=dim, type="I2F30") }} {{ name }}() => new {{ macros::vector_type(dim=dim, type="I2F30") }}(
            X.{{ name }}(),
            Y.{{ name }}(){% if dim > 2 %},
            Z.{{ name }}(){% if dim > 3 %},
            W.{{ name }}(){% endif %}{% endif %});

        {%- endfor %}
        {%- endif %}

        //
        // Swizzling
        //

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義
{# 改行 #}

{%- for x in components %}
    {%- for y in components %}
        {%- set t = macros::vector_type(dim=2, type=component) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ t }} {{ x }}{{ y }}() => new {{ t }}(Repr.{{ x }}{{ y }}());
    {%- endfor %}
{%- endfor %}

{%- for x in components %}
    {%- for y in components %}
        {%- for z in components %}
            {%- set t = macros::vector_type(dim=3, type=component) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ t }} {{ x }}{{ y }}{{ z }}() => new {{ t }}(Repr.{{ x }}{{ y }}{{ z }}());
        {%- endfor %}
    {%- endfor %}
{%- endfor %}

{%- for x in components %}
    {%- for y in components %}
        {%- for z in components %}
            {%- for w in components %}
                {%- set t = macros::vector_type(dim=4, type=component) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ t }} {{ x }}{{ y }}{{ z }}{{ w }}() => new {{ t }}(Repr.{{ x }}{{ y }}{{ z }}{{ w }}());
            {%- endfor %}
        {%- endfor %}
    {%- endfor %}
{%- endfor %}

    }
} // namespace AgatePris.Intar

{%- if int_nbits+frac_nbits > 64 %}

#endif // NET7_0_OR_GREATER
{%- endif %}
