{% import "macros.cs" as macros %}

{%- set type   = macros::vector_primitive(dim=dim, signed=signed, bits=bits) %}
{%- set type_u = macros::vector_primitive(dim=dim, signed=false,  bits=bits) %}
{%- set component = macros::inttype(bits=bits, signed=signed) %}
{%- set components = ['X', 'Y', 'Z', 'W']|slice(end=dim) -%}
{%- if bits < 128 %}
    {%- set wide_type = macros::vector_primitive(dim=dim, signed=signed, bits=2*bits) %}
    {%- set wide_component = macros::inttype(bits=2*bits, signed=signed) %}
    {%- set math = 'Math' %}
{%- else %}
    {%- set math = component %}
{%- endif %}
{%- if 64 < bits -%}
#if NET7_0_OR_GREATER

{% endif -%}
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public struct {{ type }} : IEquatable<{{ type }}> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
{% for c in components %}
        public {{ component }} {{ c }};
{%- endfor %}

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public {{ type }}(
{%- for c in components %}
    {{- component }} {{ c | lower }}
    {%- if not loop.last %}, {% endif %}
{%- endfor -%}
        ) {
{%- for c in components %}
            {{ c }} = {{ c | lower }};
{%- endfor %}
        }

        //
        // IEqualityOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==({{ type }} left, {{ type }} right) {
            return
{%- for c in components %}
    {%- if not loop.first %} &&{% endif %} left.{{ c }} == right.{{ c }}
{%- endfor %};
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=({{ type }} left, {{ type }} right) {
            return
{%- for c in components %}
    {%- if not loop.first %} ||{% endif %} left.{{ c }} != right.{{ c }}
{%- endfor %};
        }

        //
        // IEquatable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ type }} other) => this == other;

        //
        // Object
        //

        public override bool Equals(object obj) => obj is {{ type }} o && Equals(o);

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
        public static {{ type }} operator {{ o
        }}({{ type }} left, {{ type }} right) {
            return new {{ type }}(
    {%- for c in components -%}
        left.{{ c }} {{ o }} right.{{ c }}
        {%- if not loop.last %}, {% endif %}
    {%- endfor -%}
            );
        }
{%- endfor %}

{%- for o in ['*', '/'] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator {{ o
        }}({{ type }} left, {{ component }} right) {
            return new {{ type }}(
    {%- for c in components -%}
        left.{{ c }} {{ o }} right
        {%- if not loop.last %}, {% endif %}
    {%- endfor -%}
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator {{ o
        }}({{ component }} left, {{ type }} right) {
            return new {{ type }}(
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
        public static {{ type }} operator +({{ type }} x) {
            return new {{ type }}(
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
        public static {{ type }} operator -({{ type }} x) {
            return new {{ type }}(
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
        %}explicit{% endif %} operator {{ other_type }}({{ type }} a) {
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
        // Indexer
        //

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
        // Other methods
        //

{%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }} Abs() => new {{ type }}(
    {%- for c in components -%}
        {{ math }}.Abs({{ c }}){% if not loop.last %}, {% endif %}
    {%- endfor -%}
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type_u }} UnsignedAbs() {
            return new {{ type_u }}(
    {%- for c in components -%}
        Mathi.UnsignedAbs({{ c }}){% if not loop.last %}, {% endif %}
    {%- endfor -%}
            );
        }

{%- endif %}

{%- if bits < 128 %}
    {%- if bits > 32 %}

#if NET7_0_OR_GREATER
    {%- endif %}

        public {{ wide_type }} BigMul({{ component }} other) {
            return ({{ wide_type }})this * other;
        }

        public {{ wide_type }} BigMul({{ type }} other) {
            return ({{ wide_type }})this * other;
        }
    {%- if bits > 32 %}

#endif // NET7_0_OR_GREATER
    {%- endif %}
{%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }} Min({{ type }} other) {
            return new {{ type }}(
{%- for c in components -%}
    {{ math }}.Min({{ c }}, other.{{ c }}){% if not loop.last %}, {% endif %}
{%- endfor -%}
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }} Max({{ type }} other) {
            return new {{ type }}(
{%- for c in components -%}
    {{ math }}.Max({{ c }}, other.{{ c }}){% if not loop.last %}, {% endif %}
{%- endfor -%}
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type
        }} Clamp({{ component }} min, {{ component }} max) {
{%- if bits > 64 %}
            return new {{ type }}(
    {%- for c in components -%}
        {{ math }}.Clamp({{ c }}, min, max){% if not loop.last %}, {% endif %}
    {%- endfor -%}
            );
{%- else %}
#if NET5_0_OR_GREATER
            return new {{ type }}(
    {%- for c in components -%}
        Math.Clamp({{ c }}, min, max){% if not loop.last %}, {% endif %}
    {%- endfor -%}
            );
#else
            return new {{ type }}(
    {%- for c in components -%}
        Mathi.Clamp({{ c }}, min, max){% if not loop.last %}, {% endif %}
    {%- endfor -%}
            );
#endif
{%- endif %}
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type
        }} Clamp({{ type }} min, {{ type }} max) {
{%- if bits > 64 %}
            return new {{ type }}(
    {%- for c in components -%}
        {{ math }}.Clamp({{ c }}, min.{{ c }}, max.{{ c }}){% if not loop.last %}, {% endif %}
    {%- endfor -%}
            );
{%- else %}
#if NET5_0_OR_GREATER
            return new {{ type }}(
    {%- for c in components -%}
        Math.Clamp({{ c }}, min.{{ c }}, max.{{ c }}){% if not loop.last %}, {% endif %}
    {%- endfor -%}
            );
#else
            return new {{ type }}(
    {%- for c in components -%}
        Mathi.Clamp({{ c }}, min.{{ c }}, max.{{ c }}){% if not loop.last %}, {% endif %}
    {%- endfor -%}
            );
#endif
{%- endif %}
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }} Half() => new {{ type }}(
{%- for c in components -%}
    Mathi.Half({{ c }}){% if not loop.last %}, {% endif %}
{%- endfor -%}
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }} Twice() => new {{ type }}(
{%- for c in components -%}
    Mathi.Twice({{ c }}){% if not loop.last %}, {% endif %}
{%- endfor -%}
        );

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
