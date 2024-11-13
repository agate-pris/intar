{% import "macros.cs" as macros %}

{%- macro other_type(s, dim, bits) %}
    {%- if s %}Vector{{ dim }}Int{{ bits }}
    {%- else %}Vector{{ dim }}UInt{{ bits }}
    {%- endif %}
{%- endmacro %}

{%- set type = self::other_type(s=signed, dim=dim, bits=bits) %}
{%- set component = macros::inttype(bits=bits, signed=signed) %}
{%- set components = ['X', 'Y', 'Z', 'W']|slice(end=dim) -%}

{%- if bits < 64 %}

    {%- set wide_type = self::other_type(bits = 2*bits, s=signed, dim=dim) %}

{%- endif %}

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
        {%- endfor %}) {
        {%- for c in components %}
            {{ c }} = {{ c | lower }};
        {%- endfor %}
        }

        //
        // IEqualityOperators<{{ type }}, {{ type }}>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(
            {{- type }} left, {{ type }} right) {
            return
            {%- for c in components %}
                {#- #} left.{{ c }} == right.{{ c }}
                {%- if not loop.last %} &&{% endif %}
            {%- endfor %};
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(
            {{- type }} left, {{ type }} right) {
            return
            {%- for c in components %}
                {#- #} left.{{ c }} != right.{{ c }}
                {%- if not loop.last %} ||{% endif %}
            {%- endfor %};
        }

        //
        // IEquatable<{{ type }}>
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
                {{- c }}
                {%- if not loop.last %}, {% endif %}
            {%- endfor %});

        //
        // IAdditionOperators<{{ type }}, {{ type }}, {{ type }}>
        // ISubtractionOperators<{{ type }}, {{ type }}, {{ type }}>
        // IIMultiplyOperators<{{ type }}, {{ type }}, {{ type }}>
        // IDivisionOperators<{{ type }}, {{ type }}, {{ type }}>
        //

{%- for o in ['+', '-', '*', '/'] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator {{ o }}(
            {{- type }} left, {{ type }} right) {
            return new {{ type }}(
                {%- for c in components -%}
                    left.{{ c }} {{ o }} right.{{ c }}
                    {%- if not loop.last %}, {% endif %}
                {%- endfor %});
        }
{%- endfor %}

        //
        // IMultiplyOperators<{{ type }}, {{ type }}, {{ component }}>
        // IDivisionOperators<{{ type }}, {{ type }}, {{ component }}>
        // IMultiplyOperators<{{ type }}, {{ component }}, {{ type }}>
        // IDivisionOperators<{{ type }}, {{ component }}, {{ type }}>
        //

{%- for o in ['*', '/'] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator {{ o }}(
            {{- type }} left, {{ component }} right) {
            return new {{ type }}(
                {%- for c in components -%}
                    left.{{ c }} {{ o }} right
                    {%- if not loop.last %}, {% endif %}
                {%- endfor %});
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator {{ o }}(
            {{- component }} left, {{ type }} right) {
            return new {{ type }}(
                {%- for c in components -%}
                    left {{ o }} right.{{ c }}
                    {%- if not loop.last %}, {% endif %}
                {%- endfor %});
        }
{%- endfor %}

        //
        // IUnaryPlusOperators<{{ type }}>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator +({{ type }} x) {
            return new {{ type }}(
                {%- for c in components -%}
                    +x.{{ c }}
                    {%- if not loop.last %}, {% endif %}
                {%- endfor %});
        }

{%- if signed %}

        //
        // IUnaryNegationOperators<{{ type }}>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator -({{ type }} x) {
            return new {{ type }}(
                {%- for c in components -%}
                    -x.{{ c }}
                    {%- if not loop.last %}, {% endif %}
                {%- endfor %});
        }

{%- endif %}

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

{%- for other_bits in [32, 64] %}
    {%- for s in [true, false] %}
        {%- if bits != other_bits or s != signed %}
            {%- set implicit = signed == s and other_bits >= bits
                or not signed and s and other_bits > bits %}
            {%- set other_type = self::other_type(s=s, bits=other_bits, dim=dim) %}
            {%- set t = macros::inttype(signed=s, bits=other_bits) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {# #}
        {%- if implicit %}implicit
        {%- else        %}explicit
        {%- endif %} operator {{ other_type }}({{ type }} a) {
            return new {{ other_type }}(
                {%- for c in components -%}
                ({{ t }})a.{{ c }}{% if not loop.last %}, {% endif %}
                {%- endfor %});
        }

        {%- endif %}
    {%- endfor %}
{%- endfor %}

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

{%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }} Abs() => new {{ type }}(
{%- for c in components -%}
    Math.Abs({{ c }}){% if not loop.last %}, {% endif %}
{%- endfor -%}
        );

    {%- set t = self::other_type(bits=bits, s=false, dim=dim) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ t }} UnsignedAbs() {
            return new {{ t }}(
                {%- for c in components -%}
                Mathi.UnsignedAbs({{ c }}){% if not loop.last %}, {% endif %}
                {%- endfor %});
        }

{%- endif %}

{%- if bits < 64 %}

        public {{ wide_type }} BigMul({{ component }} other) {
            return new {{ self::other_type(bits=2*bits, s=sig }}(
                {%- for c in components -%}
                ({{ macros::inttype(bits=2*bits, signed=signed) }}){{ c }} * other{% if not loop.last %}, {% endif %}
                {%- endfor %});
        }

        public {{ wide_type }} BigMul({{ type }} other) {
            return new {{ wide_type }}(
                {%- for c in components -%}
                ({{ wide_type }}){{ c }} * other.{{ c }}{% if not loop.last %}, {% endif %}
                {%- endfor %});
        }

{%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }} Min({{ type }} other) {
            return new {{ type }}(
{%- for c in components -%}
    Math.Min({{ c }}, other.{{ c }}){% if not loop.last %}, {% endif %}
{%- endfor -%}
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }} Max({{ type }} other) {
            return new {{ type }}(
{%- for c in components -%}
    Math.Max({{ c }}, other.{{ c }}){% if not loop.last %}, {% endif %}
{%- endfor -%}
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }} Clamp({{
            component }} min, {{
            component }} max) {
            return new {{ type }}(
{%- for c in components -%}
    Mathi.Clamp({{ c }}, min, max){% if not loop.last %}, {% endif %}
{%- endfor -%}
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }} Clamp({{
            type }} min, {{
            type }} max) {
            return new {{ type }}(
{%- for c in components -%}
    Mathi.Clamp({{ c }}, min.{{ c }}, max.{{ c }}){% if not loop.last %}, {% endif %}
{%- endfor -%}
            );
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

{%- if bits == 32 and dim == 3 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }} CrossInternal() => new {{ type }}(
{%- for c in components -%}
    Mathi.Twice({{ c }}){% if not loop.last %}, {% endif %}
{%- endfor -%}
        );

{%- endif %}

{%- if bits < 64 %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }} LengthSquared() {
    {%- if signed %}
            var abs = UnsignedAbs();
    {%- endif %}
            return
    {%- for c in components -%}
        {%- if not loop.first %} + {% endif %} (ulong){% if signed %}abs.{% endif %}{{ c }} * {% if signed %}abs.{% endif %}{{ c }}
    {%- endfor -%}
        }
{%- eneidf %}

    }
}
