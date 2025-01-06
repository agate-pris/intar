{%- import "macros.cs" as macros %}
{%- set dim = 2 %}
{%- set components = ['X', 'Y', 'Z', 'W']|slice(end=dim) %}
{%- set component   = 'I17F15' %}
{%- set component_u = 'U17F15' %}
{%- set type = 'Circle' ~ dim ~ component -%}
using System;
using System.Runtime.CompilerServices;

namespace {{ namespace }}.Geometry {
    [Serializable]
    public struct {{ type }} : IEquatable<{{ type }}>, IFormattable {

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public {{ macros::vector_type(dim=2, type=component) }} Center;
        public {{ component_u }} Radius;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #region Construction
        public {{ type }}({{ macros::vector_type(dim=2, type=component) }} center, {{ component_u }} radius) {
            Center = center;
            Radius = radius;
        }
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ type }} other) {
            return Center.Equals(other.Center) && Radius.Equals(other.Radius);
        }
        #endregion
        #region Object
        public override bool Equals(object obj) {
            return obj is {{ type }} o && Equals(o);
        }

        public override int GetHashCode() => HashCode.Combine(
            Center, Radius
        );

        public override string ToString() {
            return $"{{ '{{' }}Center:{Center} Radius:{Radius}{{ '}}' }}";
        }
        #endregion
        #region IFormattable
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"{{ '{{' }}Center:{Center.ToString(format, formatProvider)} Radius:{Radius.ToString(format, formatProvider)}{{ '}}' }}";
        }
        #endregion
        #region IMultiplyOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator *(AffineTransform3{{ component }} left, {{ type }} right) {
            {%- for c in components %}
            var s{{ c }} = left.DecomposeScale{{ c }}();
            {%- endfor %}
            var center = new Vector3{{ component }}(
                {%- for i in range(end=3) %}
                {%- if i < dim -%}
                right.Center.{{ components[i] }}
                {%- else -%}
                {{ component }}.Zero
                {%- endif %}
                {%- if not loop.last -%}, {% endif %}
                {%- endfor %});
            return new {{ type }}(
                (left * center).
                {%- for i in range(end=dim) -%}
                {{ components[i] }}
                {%- endfor %}(),
                right.Radius * sX
                {%- for i in range(start=1, end=dim) -%}
                .Max(s{{ components[i] }})
                {%- endfor %}
            );
        }
        #endregion
        #region Disjoint, Intersects
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Disjoint({{ type }} other) {
            var r = Radius + other.Radius;
            return Center.DistanceSquared(other.Center) > r.BigMul(r);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects({{ type }} other) => !Disjoint(other);
        #endregion
    }
}
