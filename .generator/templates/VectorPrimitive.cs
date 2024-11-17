{% import "macros.cs" as macros %}
{%- set vector   = macros::vector_primitive(signed=signed, dim=dim, bits=bits) %}
{%- set vector_s = macros::vector_primitive(signed=true,   dim=dim, bits=bits) %}
{%- set vector_u = macros::vector_primitive(signed=false,  dim=dim, bits=bits) %}
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

namespace AgatePris.Intar {
    public struct {{ vector }} : IEquatable<{{ vector }}> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
{% for c in components %}
        public {{ component }} {{ c }};
{%- endfor %}

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
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

        //
        // IEqualityOperators
        //
{%- for o in ['==', '!='] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ macros::vector_bool(dim=dim) }} operator {{ o }}({{ vector }} left, {{ vector }} right) {
            return new {{ macros::vector_bool(dim=dim) }}(
{%- for c in components -%}
    left.{{ c }} {{ o }} right.{{ c }}{% if not loop.last %}, {% endif %}
{%- endfor -%}
            );
        }
{%- endfor %}

        //
        // Derived from INumberBase
        //

        public {{ macros::vector_bool(dim=dim) }} IsNegative() {
            return new {{ macros::vector_bool(dim=dim) }}(
{%- for c in components -%}
    {{ c }} < 0{% if not loop.last %}, {% endif %}
{%- endfor -%}
            );
        }

        //
        // IEquatable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ vector }} other) {
            return
{%- for c in components -%}
    {% if not loop.first %} &&{% endif %} {{ c }} == other.{{ c }}
{%- endfor -%}
            ;
        }

        //
        // Object
        //

        public override bool Equals(object obj) => obj is {{ vector }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(
{%- for c in components %}
    {%- if not loop.first %}, {% endif %}{{ c }}
{%- endfor -%}
        );

        //
        // IAdditionOperators
        // ISubtractionOperators
        // IMultiplyOperators
        // IDivisionOperators
        //

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
{%- endfor %}

{%- for o in ['*', '/'] %}

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

        //
        // IUnaryPlusOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator +({{ vector }} x) {
            return new {{ vector }}(
{%- for c in components -%}
    +x.{{ c }}
    {%- if not loop.last %}, {% endif %}
{%- endfor -%}
            );
        }

{%- if signed %}

        //
        // IUnaryNegationOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator -({{ vector }} x) {
            return new {{ vector }}(
{%- for c in components -%}
    -x.{{ c }}
    {%- if not loop.last %}, {% endif %}
{%- endfor -%}
            );
        }

{%- endif %}

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

        //
        // Other methods
        //

{%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }} Abs() => new {{ vector }}(
    {%- for c in components -%}
        {{ math }}.Abs({{ c }}){% if not loop.last %}, {% endif %}
    {%- endfor -%}
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector_u }} UnsignedAbs() {
            return new {{ vector_u }}(
    {%- for c in components -%}
        Mathi.UnsignedAbs({{ c }}){% if not loop.last %}, {% endif %}
    {%- endfor -%}
            );
        }

{%- endif %}

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

{%- if bits < 128 %}
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
            return YZX().BigMul(other.ZXY()) - ZXY().BigMul(other.YZX());
        }
    {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ wide_component }} UncheckedDot({{ vector }} other) {
            var mul = ({{ wide_vector }})this * other;
            return
    {%- for c in components -%}
        {% if not loop.first %} +{% endif %} mul.{{ c }}
    {%- endfor -%}
            ;
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
            return
    {%- for c in components -%}
        {% if not loop.first %} +{% endif %} sqr.{{ c }}
    {%- endfor -%}
            ;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ component_u }} {%
            if dim > 3 or not signed and dim > 1
        %}Unchecked{% endif %}Length() => ({{ component_u }})Mathi.Sqrt({%
            if dim > 3 or not signed and dim > 1
        %}Unchecked{% endif %}LengthSquared());
    {%- if bits > 32 %}

#endif // NET7_0_OR_GREATER
    {%- endif %}
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

        //
        // Swizzling
        //

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

    }
}
{%- if 64 < bits %}

#endif // NET7_0_OR_GREATER
{%- endif %}
