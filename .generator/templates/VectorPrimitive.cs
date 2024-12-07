{% import "macros.cs" as macros %}
{%- set vector   = macros::vector_primitive(signed=signed, dim=dim, bits=bits) %}
{%- set vector_s = macros::vector_primitive(signed=true,   dim=dim, bits=bits) %}
{%- set vector_u = macros::vector_primitive(signed=false,  dim=dim, bits=bits) %}
{%- set vector_b = macros::vector_bool(dim=dim) %}
{%- set component   = macros::inttype(signed=signed, bits=bits) %}
{%- set component_u = macros::inttype(signed=false,  bits=bits) %}
{%- if bits < 128 %}
    {%- set wide_vector = macros::vector_primitive(signed=signed, dim=dim, bits=2*bits) %}
    {%- set wide_component   = macros::inttype(signed=signed, bits=2*bits) %}
    {%- set wide_component_u = macros::inttype(signed=false,  bits=2*bits) %}
    {%- set math = 'Math' %}
{%- else %}
    {%- set math = component %}
{%- endif %}
{%- set components = ['X', 'Y', 'Z', 'W']|slice(end=dim) %}
{%- if 64 < bits -%}
#if NET7_0_OR_GREATER

{% endif -%}
using System;
using System.Runtime.CompilerServices;

namespace {{ namespace }} {
    public struct {{ vector }} : IEquatable<{{ vector }}> {

        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        {%- for c in components %}
        public {{ component }} {{ c }};
        {%- endfor %}
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion

        public static explicit operator System.Numerics.Vector{{
            dim }}({{ vector }} a) {
            return new System.Numerics.Vector{{ dim }}(
                {%- for c in components %}
                {%- if bits > 64 %}(float){% endif -%}
                a.{{ c }}{%- if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector{{
            dim }}({{ vector }} a) {
            return new UnityEngine.Vector{{ dim }}(
                {%- for c in components %}
                {%- if bits > 64 %}(float){% endif -%}
                a.{{ c }}{%- if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float{{
            dim }}({{ vector }} a) {
            return new Unity.Mathematics.float{{ dim }}(
                {%- for c in components %}
                {%- if bits > 64 %}(float){% endif -%}
                a.{{ c }}{%- if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }
#endif

        public {{ vector }}(
            {%- for c in components %}
            {{- component }} {{ c | lower }}
            {%- if not loop.last %}, {% endif %}
            {%- endfor -%}
        ) {
            {%- for c in components %}
            {{ c }} = {{ c | lower }};
            {%- endfor %}
        }

        public {{ component }} this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                switch (index) {
                    {%- for c in components %}
                    case {{ loop.index0 }}: return {{ c }};
                    {%- endfor %}
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                switch (index) {
                    {%- for c in components %}
                    case {{ loop.index0 }}: {{ c }} = value; break;
                    {%- endfor %}
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
        }

        #region IComparisonOperators, IEqualityOperators

        {%- for o in ['<', '>', '<=', '>=', '==', '!='] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector_b }} operator {{ o }}({{ vector }} left, {{ vector }} right) {
            return new {{ vector_b }}(
                {%- for c in components -%}
                left.{{ c }} {{ o }} right.{{ c }}{% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector_b }} operator {{ o }}({{ component }} left, {{ vector }} right) {
            return new {{ vector_b }}(
                {%- for c in components -%}
                left {{ o }} right.{{ c }}{% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector_b }} operator {{ o }}({{ vector }} left, {{ component }} right) {
            return new {{ vector_b }}(
                {%- for c in components -%}
                left.{{ c }} {{ o }} right{% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }
        {%- endfor %}

        #endregion

        #region IShiftOperators
        {%- for o in ['<<', '>>', '>>>'] %}
        {%- if o == '>>>' %}

#if NET7_0_OR_GREATER
        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator {{ o }}({{ vector }} left, int right) {
            return new {{ vector }}(
                {%- for c in components -%}
                left.{{ c }} {{ o }} right{% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }
        {%- if o == '>>>' %}

#endif // NET7_0_OR_GREATER
        {%- endif %}
        {%- endfor %}

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ vector }} other) {
            return
            {%- for c in components -%}
            {% if not loop.first %} &&{% endif %} {{ c }} == other.{{ c }}
            {%- endfor -%}
            ;
        }

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is {{ vector }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(
            {%- for c in components %}
            {%- if not loop.first %}, {% endif %}{{ c }}
            {%- endfor -%}
        );

        #endregion

        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        {%- for o in ['+', '-', '*', '/'] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator {{ o
        }}({{ vector }} left, {{ vector }} right) {
            return new {{ vector }}(
                {%- for c in components -%}
                left.{{ c }} {{ o }} right.{{ c }}
                {%- if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator {{ o
        }}({{ vector }} left, {{ component }} right) {
            return new {{ vector }}(
                {%- for c in components -%}
                left.{{ c }} {{ o }} right
                {%- if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator {{ o
        }}({{ component }} left, {{ vector }} right) {
            return new {{ vector }}(
                {%- for c in components -%}
                left {{ o }} right.{{ c }}
                {%- if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }
        {%- endfor %}

        #endregion

        #region IUnaryPlusOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator +({{ vector }} x) {
            return new {{ vector }}(
                {%- for c in components -%}
                +x.{{ c }}
                {%- if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }

        #endregion

        {#- 単項マイナス演算子は符号付きベクトル型に対してのみ定義する #}
        {%- if signed %}

        #region IUnarryNegationOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator -({{ vector }} x) {
            return new {{ vector }}(
                {%- for c in components -%}
                -x.{{ c }}
                {%- if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }

        #endregion
        {%- endif %}

        #region Conversion Operators

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        {%- for other_bits in [32, 64, 128] %}
        {%- if other_bits > 64 %}

#if NET7_0_OR_GREATER
        {%- endif %}
        {%- for s in [true, false] %}
        {%- if bits != other_bits or s != signed %}
        {%- set implicit = signed == s and other_bits >= bits
            or not signed and s and other_bits > bits %}
        {%- set other_type = macros::vector_primitive(dim=dim, signed=s, bits=other_bits) %}
        {%- set t = macros::inttype(signed=s, bits=other_bits) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {% if implicit
        %}implicit{% else
        %}explicit{% endif %} operator {{ other_type }}({{ vector }} a) {
            return new {{ other_type }}(
                {%- for c in components -%}
                ({{ t }})a.{{ c }}{% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }

        {%- endif %}
        {%- endfor %}
        {%- if other_bits > 64 %}

#endif // NET7_0_OR_GREATER
        {%- endif %}
        {%- endfor %}

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        #endregion

        #region IsNegative, Abs, UnsignedAbs, IsNegativeAndUnsignedAbs

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector_b }} IsNegative() {
            return new {{ vector_b }}(
                {%- for c in components -%}
                {{ c }} < 0{% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }

        {%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} Abs() => new {{ vector }}(
            {%- for c in components -%}
            {{ math }}.Abs({{ c }}){% if not loop.last %}, {% endif %}
            {%- endfor -%}
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector_u }} UnsignedAbs() {
            var isNegative = IsNegative();
            return new {{ vector_u }}(
                {%- for c in components %}
                unchecked(({{ component_u }})(isNegative.{{ c }} ? Overflowing.WrappingNeg({{ c }}) : {{ c }}))
                {%- if not loop.last %},{% endif %}
                {%- endfor %}
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal ({{ vector_b }} isNegative, {{ vector_u }} unsignedAbs) IsNegativeAndUnsignedAbs() {
            var isNegative = IsNegative();
            var unsignedAbs = new {{ vector_u }}(
                {%- for c in components %}
                unchecked(({{ component_u }})(isNegative.{{ c }} ? Overflowing.WrappingNeg({{ c }}) : {{ c }}))
                {%- if not loop.last %},{% endif %}
                {%- endfor %}
            );
            return (isNegative, unsignedAbs);
        }

        {%- else %}

        // 符号なしベクトル型に対しては Abs, UnsignedAbs は定義しない.

        {%- endif %}

        #endregion

        #region Min, Max, MaxComponent, Clamp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} Min({{ vector }} other) {
            return new {{ vector }}(
                {%- for c in components -%}
                {{ math }}.Min({{ c }}, other.{{ c }}){% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} Max({{ vector }} other) {
            return new {{ vector }}(
                {%- for c in components -%}
                {{ math }}.Max({{ c }}, other.{{ c }}){% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }

        {%- if signed %}

        // MaxComponent は符号なしの場合のみ定義する。
        {%- else %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal {{ component }} MaxComponent() {
            {%- if dim == 2 %}
            return {{ math }}.Max(X, Y);
            {%- elif dim == 3 %}
            return {{ math }}.Max({{ math }}.Max(X, Y), Z);
            {%- elif dim == 4 %}
            return {{ math }}.Max({{ math }}.Max(X, Y), {{ math }}.Max(Z, W));
            {%- endif %}
        }
        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector
        }} Clamp({{ component }} min, {{ component }} max) {
            {%- if bits > 64 %}
            return new {{ vector }}(
                {%- for c in components -%}
                {{ math }}.Clamp({{ c }}, min, max){% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
            {%- else %}
#if NET5_0_OR_GREATER
            return new {{ vector }}(
                {%- for c in components -%}
                Math.Clamp({{ c }}, min, max){% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
#else
            return new {{ vector }}(
                {%- for c in components -%}
                Mathi.Clamp({{ c }}, min, max){% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
#endif
            {%- endif %}
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector
        }} Clamp({{ vector }} min, {{ vector }} max) {
            {%- if bits > 64 %}
            return new {{ vector }}(
                {%- for c in components -%}
                {{ math }}.Clamp({{ c }}, min.{{ c }}, max.{{ c }}){% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
            {%- else %}
#if NET5_0_OR_GREATER
            return new {{ vector }}(
                {%- for c in components -%}
                Math.Clamp({{ c }}, min.{{ c }}, max.{{ c }}){% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
#else
            return new {{ vector }}(
                {%- for c in components -%}
                Mathi.Clamp({{ c }}, min.{{ c }}, max.{{ c }}){% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
#endif
            {%- endif %}
        }

        #endregion

        #region Half, Twice, UncheckedComponentsSum

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} Half() => new {{ vector }}(
            {%- for c in components -%}
            Mathi.Half({{ c }}){% if not loop.last %}, {% endif %}
            {%- endfor -%}
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} Twice() => new {{ vector }}(
            {%- for c in components -%}
            Mathi.Twice({{ c }}){% if not loop.last %}, {% endif %}
            {%- endfor -%}
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal {{ component }} UncheckedComponentsSum() => {% for c in components -%}
            {{ c }}{% if not loop.last %} + {% endif %}
        {%- endfor %};

        #endregion

        {%- if bits < 128 %}

        #region BigMul, Cross, UncheckedDot, (Unchecked)LengthSquared, (Unchecked)Length, HalfLength
        {%- if bits > 32 %}

#if NET7_0_OR_GREATER
        {%- endif %}

        public {{ wide_vector }} BigMul({{ component }} other) {
            return ({{ wide_vector }})this * other;
        }

        public {{ wide_vector }} BigMul({{ vector }} other) {
            return ({{ wide_vector }})this * other;
        }
        {%- if signed and dim == 3 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ wide_vector }} Cross({{ vector }} other) {
            // (a1)   (b1)   (a2b3 - a3b2)
            // (a2) x (b2) = (a3b1 - a1b3)
            // (a3)   (b3)   (a1b2 - a2b1)
            return YZX().BigMul(other.ZXY()) - ZXY().BigMul(other.YZX());
        }
        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ wide_component }} UncheckedDot({{ vector }} other) {
            return BigMul(other).UncheckedComponentsSum();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ wide_component_u }} {%
            if dim > 3 or not signed and dim > 1
        %}Unchecked{% endif %}LengthSquared() {
            {%- if signed %}
            var abs = UnsignedAbs();
            var sqr = abs.BigMul(abs);
            {%- else %}
            var sqr = BigMul(this);
            {%- endif %}
            return sqr.UncheckedComponentsSum();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ component_u }} {%
            if dim > 3 or not signed and dim > 1
        %}Unchecked{% endif %}Length() => ({{ component_u }})Mathi.Sqrt({%
            if dim > 3 or not signed and dim > 1
        %}Unchecked{% endif %}LengthSquared());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal {{ component_u }} HalfLength() {
            {%- if signed %}
            var abs = UnsignedAbs();
            var sqr = abs.BigMul(abs);
            {%- else %}
            var sqr = BigMul(this);
            {%- endif %}
            return ({{ component_u }})Mathi.Sqrt((sqr / 4).UncheckedComponentsSum());
        }
        {%- if bits > 32 %}

#endif // NET7_0_OR_GREATER
        {%- endif %}

        #endregion
        {%- endif %}

        #region Overflowing
        {%- for m in ['WrappingAdd', 'WrappingSub'] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} {{ m }}({{ vector }} other) {
            return new {{ vector }}(
                {%- for c in components -%}
                Overflowing.{{ m }}({{ c }}, other.{{ c }}){% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }
        {%- endfor %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} WrappingNeg() {
            return new {{ vector }}(
                {%- for c in components -%}
                Overflowing.WrappingNeg({{ c }}){% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }
        {%- if signed %}
        {%- for m in ['WrappingAddUnsigned', 'WrappingSubUnsigned'] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} {{ m }}({{ vector_u }} other) {
            return new {{ vector }}(
                {%- for c in components -%}
                Overflowing.{{ m }}({{ c }}, other.{{ c }}){% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }
        {%- endfor %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} WrappingAbs() {
            return new {{ vector }}(
                {%- for c in components -%}
                Overflowing.WrappingAbs({{ c }}){% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }
        {%- else %}

        // Rust に倣って WrappingAddSigned のみを定義し
        // WrappingSubSigned は定義しない.
        // https://doc.rust-lang.org/std/primitive.u32.html#method.wrapping_add_signed

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} WrappingAddSigned({{ vector_s }} other) {
            return new {{ vector }}(
                {%- for c in components -%}
                Overflowing.WrappingAddSigned({{ c }}, other.{{ c }}){% if not loop.last %}, {% endif %}
                {%- endfor -%}
            );
        }
        {%- endif %}

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義
{# 改行 #}

        {%- for x in components %}
        {%- for y in components %}
        {%- set t = macros::vector_primitive(dim=2, signed=signed, bits=bits) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ t }} {{ x }}{{ y }}() => new {{ t }}({{ x }}, {{ y }});
        {%- endfor %}
        {%- endfor %}

        {%- for x in components %}
        {%- for y in components %}
        {%- for z in components %}
        {%- set t = macros::vector_primitive(dim=3, signed=signed, bits=bits) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ t }} {{ x }}{{ y }}{{ z }}() => new {{ t }}({{ x }}, {{ y }}, {{ z }});
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}

        {%- for x in components %}
        {%- for y in components %}
        {%- for z in components %}
        {%- for w in components %}
        {%- set t = macros::vector_primitive(dim=4, signed=signed, bits=bits) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ t }} {{ x }}{{ y }}{{ z }}{{ w }}() => new {{ t }}({{ x }}, {{ y }}, {{ z }}, {{ w }});
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}

        #endregion

    }
} // namespace {{ namespace }}
{%- if 64 < bits %}

#endif // NET7_0_OR_GREATER
{%- endif %}
