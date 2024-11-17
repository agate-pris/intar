{%- set vector = 'Vector' ~ dim ~ 'Bool' %}
{%- set components = ['X', 'Y', 'Z', 'W']|slice(end=dim) %}
{#- -#}
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace {{ namespace }} {
    [Serializable]
    public struct {{ vector }} : IEquatable<{{ vector }}> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
{%- for c in components %}

        [MarshalAs(UnmanagedType.U1)]
        public bool {{ c }};
{%- endfor %}

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }}(
{%- for c in components -%}
    bool {{ c|lower }}{% if not loop.last %}, {% endif %}
{%- endfor -%}
        ) {
{%- for c in components %}
            {{ c }} = {{ c|lower }};
{%- endfor %}
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector }}(bool value)
            : this(
{%- for i in range(end=dim) -%}
    value{% if not loop.last %}, {%endif %}
{%- endfor %}) { }

        #region IEqualityOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator ==({{
            vector }} left, {{
            vector }} right) {
            return new {{ vector }}(
{%- for c in components -%}
    left.{{ c }} == right.{{ c }}{% if not loop.last %}, {% endif %}
{%- endfor -%}
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector }} operator !=({{
            vector }} left, {{
            vector }} right) {
            return new {{ vector }}(
{%- for c in components -%}
    left.{{ c }} != right.{{ c }}{% if not loop.last %}, {% endif %} 
{%- endfor -%}
            );
        }

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj) {
            return obj is {{ vector }} o && Equals(o);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() {
            return HashCode.Combine(
{%- for c in components -%}
    {{ c }}{% if not loop.last %}, {% endif %}
{%- endfor -%}
            );
        }

        #endregion

    }
}
