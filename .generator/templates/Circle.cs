{%- import "macros.cs" as macros %}
{%- set dim = 2 %}
{%- set components = ['X', 'Y', 'Z', 'W']|slice(end=dim) %}
{%- set component   = 'I17F15' %}
{%- set component_u = 'U17F15' %}
{%- if dim == 2 %}
{%- set type = 'Circle' ~ component %}{% else %}
{{- throw(message='not implemented') }}
{%- endif -%}
using System;
using System.Runtime.CompilerServices;

#if UNITY_EDITOR

using UnityEngine;

#endif // UNITY_EDITOR

namespace {{ namespace }}.Geometry {
    [Serializable]
    public struct {{ type }} : IEquatable<{{ type }}>, IFormattable {

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public {{ macros::vector_type(dim=dim, type=component) }} Center;
        public {{ component_u }} Radius;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }}({{ macros::vector_type(dim=dim, type=component) }} center, {{ component_u }} radius) {
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
        #region IEqualityOperators
        {%- for op in ['==', '!='] %}
        {%- if op == '==' -%}
        {%- set combine = '&&' %}{% else %}
        {%- set combine = '||' %}{% endif %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator {{ op }}({{ type }} left, {{ type }} right) {
            return
                {%- for c in components -%}
                {#- #} left.Center.{{ c }} {{ op }} right.Center.{{ c }} {{ combine }}
                {%- endfor %}
                {#- #} left.Radius {{ op }} right.Radius;
        }
        {%- endfor %}
        #endregion
        #region Object
        public override bool Equals(object obj) {
            return obj is {{ type }} o && Equals(o);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(
            Center, Radius
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() {
            return $"{{ '{{' }}Center:{Center} Radius:{Radius}{{ '}}' }}";
        }
        #endregion
        #region IFormattable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"{{ '{{' }}Center:{Center.ToString(format, formatProvider)} Radius:{Radius.ToString(format, formatProvider)}{{ '}}' }}";
        }
        #endregion
        #region IMultiplyOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator *(AffineTransform{{ dim }}{{ component }} left, {{ type }} right) {
            {%- for c in components %}
            var s{{ c }} = left.DecomposeScale{{ c }}();
            {%- endfor %}
            return new {{ type }}(
                left * right.Center,
                right.Radius * sX
                {%- for i in range(start=1, end=dim) -%}
                .Max(s{{ components[i] }})
                {%- endfor %}
            );
        }
        {%- if dim == 2 %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator *(AffineTransform3{{ component }} left, {{ type }} right) {
            return new AffineTransform2{{ component }}(
                new Matrix2x2{{ component }}(
                    left.RotationScale.C0.XY(),
                    left.RotationScale.C1.XY()
                ), left.Translation.XY()
            ) * right;
        }
        {%- endif %}
        #endregion
        #region Envelope
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Aabb{{ dim }}{{ component }} Envelope() {
            return new Aabb{{ dim }}{{ component }}(this);
        }
        #endregion
        #region Disjoint, Intersects
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Disjoint({{ macros::vector_type(dim=dim, type=component) }} other) {
            return Center.DistanceSquared(other) > Radius.BigMul(Radius);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects({{ macros::vector_type(dim=dim, type=component) }} other) => !Disjoint(other);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Disjoint({{ type }} other) {
            var r = Radius + other.Radius;
            return Center.DistanceSquared(other.Center) > r.BigMul(r);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects({{ type }} other) => !Disjoint(other);
        #endregion

#if UNITY_EDITOR

        #region Draw
        {%- if dim == 2 %}
        public void Draw(float z) {
            var x = (float)Center.X;
            var y = (float)Center.Y;
            var radius = (float)Radius;
            Gizmos.DrawLine(
                new Vector3(x, y, z),
                new Vector3(x + radius, y, z));
            const int div = 60;
            for (var i = 0; i < div; i++) {
                const float toRad = 2 * Mathf.PI / div;
                var th1 = i * toRad;
                var th2 = (i + 1) * toRad;
                var px = (Mathf.Cos(th1) * radius) + x;
                var py = (Mathf.Sin(th1) * radius) + y;
                var qx = (Mathf.Cos(th2) * radius) + x;
                var qy = (Mathf.Sin(th2) * radius) + y;
                Gizmos.DrawLine(
                    new Vector3(px, py, z),
                    new Vector3(qx, qy, z));
            }
        }
        {%- else %}
        {{ throw(message='not implemented') }}
        {%- endif %}
        public void Draw(AffineTransform3{{ component }} transform) {
            (transform * this).Draw({% if dim == 2 %}(float)transform.Translation.Z{% endif %});
        }
        public void Draw(Matrix4x4 matrix) {
            Draw((AffineTransform3I17F15)matrix);
        }
        public void Draw(Transform transform) {
            Draw(transform.localToWorldMatrix);
        }
        #endregion

#endif // UNITY_EDITOR

    }
}
