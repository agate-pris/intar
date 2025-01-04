{% import "macros.cs" as macros %}
{%- set bits   = macros::inttype(signed=signed, bits = int_nbits+frac_nbits) %}
{%- set bits_u = macros::inttype(signed=false,  bits = int_nbits+frac_nbits) %}
{%- set component    = macros::fixed_type(s=signed, i=int_nbits, f=frac_nbits) %}
{%- set component_u  = macros::fixed_type(s=false,  i=int_nbits, f=frac_nbits) %}
{%- set component_i2 = macros::fixed_type(s=true, i=2, f=int_nbits+frac_nbits-2) %}
{%- set vector    = macros::vector_type(dim=dim, type=component) %}
{%- set vector_i2 = macros::vector_type(dim=dim, type=component_i2) %}
{%- set vector_b = macros::vector_bool(dim=dim) %}
{%- set repr   = macros::vector_primitive(dim=dim, signed=signed, bits = int_nbits+frac_nbits) %}
{%- set repr_u = macros::vector_primitive(dim=dim, signed=false,  bits = int_nbits+frac_nbits) %}
{%- if int_nbits+frac_nbits < 128 %}
    {%- set wide_bits_u = macros::inttype(bits= 2*int_nbits + 2*frac_nbits, signed=false) %}
    {%- set wide_component   = macros::fixed_type(s=signed, i = 2*int_nbits, f = 2*frac_nbits) %}
    {%- set wide_component_u = macros::fixed_type(s=false,  i = 2*int_nbits, f = 2*frac_nbits) %}
    {%- set wide_vector = macros::vector_type(dim=dim, type=wide_component) %}
    {%- set wide_repr = macros::vector_primitive(dim=dim, signed=signed, bits = 2*int_nbits + 2*frac_nbits) %}
{%- endif %}
{%- set components = ['X', 'Y', 'Z', 'W']|slice(end=dim) %}
{%- if int_nbits+frac_nbits > 64 -%}
#if NET7_0_OR_GREATER

{% endif -%}

using System;
using System.Runtime.CompilerServices;

namespace {{ namespace }} {
    [Serializable]
    public struct {{ vector }}
    : IEquatable<{{ vector }}>
    , IFormattable {
        #region Fields

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public {{ repr }} Repr;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        {%- if int_nbits+frac_nbits < 128 %}
        #region WideRepr
        {%- if int_nbits+frac_nbits > 32 %}

#if NET7_0_OR_GREATER
{% endif %}
        internal {{ wide_repr }} WideRepr {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Repr;
        }
        {%- if int_nbits+frac_nbits > 32 %}

#endif // NET7_0_OR_GREATER
{% endif %}
        #endregion
        {%- endif %}
        #region Components
        {%- for c in components %}
        public {{ component }} {{ c }} {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => {{ component }}.FromBits(Repr.{{ c }});
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.{{ c }} = value.Bits;
        }
        {%- endfor %}
        #endregion
        #region Indexer
        public {{ component }} this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => {{ component }}.FromBits(Repr[index]);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr[index] = value.Bits;
        }
        #endregion
        #region Conversion
        public static explicit operator System.Numerics.Vector{{ dim }}({{ vector }} a) {
            return (System.Numerics.Vector{{ dim }})a.Repr / {%
                if int_nbits+frac_nbits > 64 %}(float){%
                endif
            %}{{ component }}.OneRepr;
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector{{
            dim }}({{ vector }} a) {
            return (UnityEngine.Vector{{ dim }})a.Repr / {%
                if int_nbits+frac_nbits > 64 %}(float){%
                endif
            %}{{ component }}.OneRepr;
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float{{
            dim }}({{ vector }} a) {
            return (Unity.Mathematics.float{{ dim }})a.Repr / {%
                if int_nbits+frac_nbits > 64 %}(float){%
                endif
            %}{{ component }}.OneRepr;
        }
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        {{ vector }}({{ repr }} repr) {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} FromRepr({{ repr }} repr) {
            return new {{ vector }}(repr);
        }
        #endregion
        #region Zero, One, {% for c in components %}Unit{{ c }}{% if not loop.last %}, {% endif %}{% endfor %}
        public static readonly {{ vector }} Zero = new {{ vector }}({{ component }}.Zero);
        public static readonly {{ vector }} One = new {{ vector }}({{ component }}.One);
        {%- for i in range(end=dim) %}
        {%- if i >= dim %}{% continue %}{% endif %}
        public static readonly {{ vector }} Unit{{ components[i] }} = new {{ vector }}(
            {%- for j in range(end=dim) %}
                {{- component }}.
                {%- if i == j %}One{% else %}Zero{% endif %}
                {%- if not loop.last %}, {% endif %}
            {%- endfor -%}
        );
        {%- endfor %}
        #endregion
        #region IAdditionOperators, ISubtractionOperators
        {%- for o in ['+', '-'] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator {{ o }}({{ vector }} a, {{ vector }} b) {
            return new {{ vector }}(a.Repr {{ o }} b.Repr);
        }
        {%- endfor %}
        #endregion
        {%- if int_nbits+frac_nbits < 128 %}
        #region IMultiplyOperators, IDivisionOperators
        {%- if int_nbits+frac_nbits > 32 %}

#if NET7_0_OR_GREATER
{% endif %}
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
{% endif %}
        #endregion
        {%- endif %}
        #region IUnaryPlusOperators, IUnaryNegationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator +({{ vector }} x) {
            return new {{ vector }}(+x.Repr);
        }
        {%- if not signed %}

        // 単項マイナス演算子は符号ありの場合のみ定義される

        {% else %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator -({{ vector }} x) {
            return new {{ vector }}(-x.Repr);
        }
        {% endif -%}
        #endregion
        #region IEqualityOperators
        {%- for o in ['==', '!='] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector_b }} operator {{ o
        }}({{ vector }} lhs, {{ vector }} rhs) => lhs.Repr {{ o }} rhs.Repr;
        {%- endfor %}
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is {{ vector }} o && Equals(o);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<
            {%- for c in components -%}
                { {{- c -}} } {%- if not loop.last %}, {% endif %}
            {%- endfor -%}
        >";
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ vector }} other) {
            return Repr.Equals(other.Repr);
        }
        #endregion
        #region IFormattable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"<
                {%- for c in components -%}
                    { {{- c }}.ToString(format, formatProvider)} {%- if not loop.last %}, {% endif %}
                {%- endfor -%}
            >";
        }
        #endregion
        #region Min, Max, Clamp
        {%- for m in ['Min', 'Max'] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} {{ m }}({{ vector }} other) {
            return new {{ vector }}(Repr.{{ m }}(other.Repr));
        }
        {%- endfor %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} Clamp({{ component }} min, {{ component }} max) {
            return new {{ vector }}(Repr.Clamp(min.Bits, max.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} Clamp({{ vector }} min, {{ vector }} max) {
            return new {{ vector }}(Repr.Clamp(min.Repr, max.Repr));
        }
        #endregion
        #region IsNegative{% if signed %}, Abs{% endif %}
        public {{ vector_b }} IsNegative() => Repr.IsNegative();
        {%- if signed %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} Abs() => new {{ vector }}(Repr.Abs());

        // 符号なし固定小数点数ベクトル型は定義されていないため
        // UnsignedAbs と AbsDiff は定義されない.
        {%- endif %}
        #endregion
        #region Half, Twice
        {%- for m in ['Half', 'Twice'] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal {{ vector }} {{ m }}() => new {{ vector }}(Repr.{{ m }}());
        {%- endfor %}
        #endregion
        {%- if int_nbits+frac_nbits < 128 %}
        {%- if int_nbits+frac_nbits > 32 %}

#if NET7_0_OR_GREATER
{% endif %}
        #region Cross, Dot, LengthSquared, Length, DistanceSquared
        {%- if signed and dim == 3 %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ wide_vector }} Cross({{ vector }} other) {
            var tmp = Repr.Cross(other.Repr);
            return {{ wide_vector }}.FromRepr(tmp);
        }
        {%- endif %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ wide_component }} Dot({{ vector }} other) {
            return {{ wide_component }}.FromBits(Repr.Dot(other.Repr));
        }

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ wide_component_u }} LengthSquared() => {{
            wide_component_u
        }}.FromBits(Repr.LengthSquared());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ component_u }} Length() => {{ component_u }}.FromBits(Repr.Length());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ wide_component_u }} DistanceSquared({{ vector }} other) {
            return {{ wide_component_u }}.FromBits(Repr.DistanceSquared(other.Repr));
        }
        #endregion
        #region Normalize
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static {{ repr }}? Normalize({{ repr }} v) {
            {%- if signed %}

            // 各要素の内部表現型を取り出し、
            // その絶対値を得る。

            var (isNegative, abs) = v.IsNegativeAndUnsignedAbs();
            var maxComponent = abs.MaxComponent();
            {%- else %}
            var maxComponent = v.MaxComponent();
            {%- endif %}

            // 各要素の最大値が 0 の場合は null を返す。
            if (maxComponent == 0) {
                return null;
            }

            // ベクトルの大きさが小さい時の誤差を小さくするため、
            // 最大の要素が表現型の範囲に収まるように拡大する。
            // 最大の要素以外にも同じ値を乗算する。
            // 剰余の回数を減らすため、
            // 先に型の最大値を最大値で割っておき、それを乗算する。

            var scaled = {% if signed %}abs
            {%- else %}v
            {%- endif %} * ({{ bits_u }}.MaxValue / maxComponent);

            var halfLength = scaled.HalfLength();

            const {{ bits_u }} fracOneTwo = {{ component }}.OneRepr / 2;
            var absNormalized = ({{ repr }})(scaled.BigMul(fracOneTwo) / halfLength);

            return new {{ repr }}(
                {%- for c in components %}
                {% if signed       -%}     isNegative.{{ c }}
                {#-  #} ? {#       -#} -absNormalized.{{ c }}
                {#-  #} : {% endif -%}  absNormalized.{{ c }}
                {%- if not loop.last %},{% endif %}
                {%- endfor %}
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }}? Normalize() {
            var tmp = Normalize(Repr);
            if (tmp == null) {
                return null;
            }
            return new {{ vector }}(tmp.Value);
        }
        #endregion
        {%- if int_nbits+frac_nbits > 32 %}

#endif // NET7_0_OR_GREATER
{% endif %}
        {%- endif %}
        {%- if signed
            and int_nbits + frac_nbits < 128
            and int_nbits - frac_nbits == 2 %}
        #region Sin/Cos
        {%- for m in ['Sin', 'Cos'] %}
        {%- for o in [2, 3, 4, 5, 10, 11] %}
        {%- if o > 5 and int_nbits + frac_nbits < 64 %}
            {%- continue %}
        {%- endif %}
        {%- set f = m ~ 'P' ~ o %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector_i2 }} {{ f }}() => new {{ vector_i2 }}(
            {%- for c in components %}
            {{ c }}.{{ f }}(){% if not loop.last %},{% endif %}
            {%- endfor %});

        {%- endfor %}
        {%- endfor %}

        #endregion
        {%- endif %}
        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義
{# 改行 #}

        {%- for x in components %}
        {%- for y in components %}
        {%- set t = macros::vector_type(dim=2, type=component) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ t }} {{ x }}{{ y }}() => {{ t }}.FromRepr(Repr.{{ x }}{{ y }}());
        {%- endfor %}
        {%- endfor %}

        {%- for x in components %}
        {%- for y in components %}
        {%- for z in components %}
        {%- set t = macros::vector_type(dim=3, type=component) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ t }} {{ x }}{{ y }}{{ z }}() => {{ t }}.FromRepr(Repr.{{ x }}{{ y }}{{ z }}());
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}

        {%- for x in components %}
        {%- for y in components %}
        {%- for z in components %}
        {%- for w in components %}
        {%- set t = macros::vector_type(dim=4, type=component) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ t }} {{ x }}{{ y }}{{ z }}{{ w }}() => {{ t }}.FromRepr(Repr.{{ x }}{{ y }}{{ z }}{{ w }}());
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
        #endregion
    }
} // namespace {{ namespace }}

{%- if int_nbits+frac_nbits > 64 %}

#endif // NET7_0_OR_GREATER
{%- endif %}
