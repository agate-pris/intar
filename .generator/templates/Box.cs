{%- import "macros.cs" as macros %}
{%- set int_nbits  = 17 %}
{%- set frac_nbits = 15 %}
{%- set component   = macros::fixed_type(s=true,  i=int_nbits, f=frac_nbits) %}
{%- set component_u = macros::fixed_type(s=false, i=int_nbits, f=frac_nbits) %}
{%- set component_wide = macros::fixed_type(s=true, i=2*int_nbits, f=2*frac_nbits) %}
{%- set bits = int_nbits+frac_nbits %}
{%- set bits_type = macros::inttype(signed=true, bits=bits) %}
{%- set dim = 2 %}
{%- set components = ['X', 'Y', 'Z', 'W']|slice(end=dim) %}
{%- set translation = macros::vector_type(dim=dim, type=component) %}
{%- set translation_repr = macros::vector_primitive(signed=true, dim=dim, bits=bits) %}
{%- if dim == 2 %}
{%- set circle = 'Circle' ~ component %}{% elif dim == 3 %}
{%- set circle = 'Sphere' ~ component %}{% else %}
{{- throw(message='not implemented') }}
{%- endif %}
{%- set segment = 'Segment' ~ dim ~ component %}
{%- set aabb = 'Aabb' ~ dim ~ component %}
{%- set type = 'Box' ~ dim ~ component -%}
using System;
using System.Runtime.CompilerServices;

#if UNITY_EDITOR

using UnityEngine;

#endif // UNITY_EDITOR

namespace {{ namespace }}.Geometry {

    /// <summary>
    /// A {{ dim }}D box defined by affine transform and extents.
    /// </summary>
    [Serializable]
    public struct {{ type }} : IEquatable<{{ type }}> {
        #region Extents, Transform

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public AffineTransform{{ dim }}{{ component }} Transform;
        public {{ macros::vector_type(dim=dim, type=component) }} Extents;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        #region Center, Size
        public {{ macros::vector_type(dim=dim, type=component) }} Center {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Transform.Translation;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Transform.Translation = value;
        }
        public {{ macros::vector_type(dim=dim, type=component) }} Size {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => {{ macros::vector_type(dim=dim, type=component) }}.FromRepr(2 * Extents.Repr);
        }
        #endregion
        {%- if dim == 2 %}
        #region P1, P2, P3, P4
        public {{ macros::vector_type(dim=dim, type=component) }} P1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Transform * Extents;
        }
        public {{ macros::vector_type(dim=dim, type=component) }} P2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Transform * {{ translation }}.FromRepr(new {{ translation_repr }}(
                -Extents.Repr.X, Extents.Repr.Y
            ));
        }
        public {{ macros::vector_type(dim=dim, type=component) }} P3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Transform * {{ translation }}.FromRepr(new {{ translation_repr }}(
                -Extents.Repr.X, -Extents.Repr.Y
            ));
        }
        public {{ macros::vector_type(dim=dim, type=component) }} P4 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Transform * {{ translation }}.FromRepr(new {{ translation_repr }}(
                Extents.Repr.X, -Extents.Repr.Y
            ));
        }
        #endregion
        {%- else %}
        {{- throw(message='not implemented') }}
        {%- endif %}
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }}(
            AffineTransform{{ dim }}{{ component }} transform, {{ macros::vector_type(dim=dim, type=component) }} extents
        ) {
            Transform = transform;
            Extents = extents;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }}(
            Matrix{{ dim }}x{{ dim }}{{ component }} rotationScale,
            {{ macros::vector_type(dim=dim, type=component) }} center, {{ macros::vector_type(dim=dim, type=component) }} extents
        ) : this(
            new AffineTransform{{ dim }}{{ component }}(rotationScale, center), extents
        ) { }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }}(
            {{ macros::vector_type(dim=dim, type=component) }} center, {# -#}
            {{ macros::vector_type(dim=dim, type=component) }} extents
        ) : this(Matrix{{ dim }}x{{ dim }}{{ component }}.Identity, center, extents) { }
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ type }} other) =>
            Center.Equals(other.Center) &&
            Transform.Equals(other.Transform);
        #endregion
        #region IEqualityOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==({{ type }} left, {{ type }} right) {
            return left.Equals(right);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=({{ type }} left, {{ type }} right) {
            return !(left == right);
        }
        #endregion
        #region Object
        public override bool Equals(object obj) {
            return obj is {{ type }} o && Equals(o);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(Extents, Transform);
        {%- if dim == 2 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() {
            return $"({P1}, {P2}, {P3}, {P4})";
        }
        {%- else %}
        {{- throw(message='not implemented') }}
        {%- endif %}
        #endregion
        #region IMultiplyOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator *(AffineTransform{{ dim }}{{ component }} left, {{ type }} right) {
            return new {{ type }}(left * right.Transform, right.Extents);
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
        {%- if dim == 2 %}
        #region Perpendicular, ProjectOntoAxis
        /// Calculate the perpendicular vector of the specified vector.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static {{ translation }} Perpendicular({{ translation }} v) {
            return new {{ translation }}(-v.Y, v.X);
        }

        {%- for count in [2, 4] %}

        /// Calculate the projection range of the box on the specified axis.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static ({{ component_wide }} Min, {{ component_wide }} Max) ProjectOntoAxis(
            {{ translation }} axis,
            {%- for i in range(end=count) %}
            {{ translation }} p{{ i+1 }}
            {%- if not loop.last %},{% endif %}
            {%- endfor %}
        ) {
            var prj = axis.Dot(p1);
            var min = prj;
            var max = prj;
            {%- for i in range(start = 2, end = count+1) %}
            prj = axis.Dot(p{{ i }});
            if (prj < min) {
                min = prj;
            } else if (prj > max) {
                max = prj;
            }
            {%- endfor %}
            return (min, max);
        }
        {%- endfor %}
        #endregion
        #region Intersects
        /// <summary>Check if the box intersects with a point.</summary>
        /// <param name="p">The point to check.</param>
        /// <returns>True if the the box intersects with the point, false otherwise.</returns>
        /// <remarks>
        /// <div class="WARNING alert alert-info">
        /// <h5>WARNING</h5>
        /// <para>This method will cause an <b>overflow</b> in the following case:</para>
        /// <list type="bullet">
        /// <item><description>The box is very large.</description></item>
        /// <item><description>The specified point is very far away.</description></item>
        /// </list>
        /// </div>
        /// <div class="NOTE alert alert-info">
        /// <h5>NOTE</h5>
        /// <para>If the box is degenerate (i.e. all vertices are collinear or all vertices coincide at one point),
        /// this method returns <c>false</c> regardless of the position of the point.</para>
        /// </para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects({{ translation }} p) {
            var o = P1;
            var a = P2;
            var b = P4;
            var op = p - o;
            var oa = a - o;
            var ob = b - o;

            // |oa| |ob| sin(th)
            var det = oa.Determinant(ob).Bits / {{ component }}.OneRepr;

            // det = 0 の場合 |OA| = 0 または |OB| = 0 または sin(th) = 0 である.
            // この時ボックスは線分または点に退化している.
            // ボックスが線分または点に退化している場合,
            // 点 P とボックスは交差していないものとする.
            if (det == 0) {
                return false;
            }

            // 軸 OA 上の位置.
            // (|op| |ob| sin(ph)) / (|oa| |ob| sin(th))
            // = (|op| sin(ph)) / (|oa| sin(th))
            var t = op.Determinant(ob).Bits / det;
            if (t < 0 || {{ component }}.OneRepr < t) {
                return false;
            }

            // 軸 OB 上の位置の反数.
            // 計算を省略するため det を流用する.
            // そのため, 反数となる.
            // (|op| |oa| sin(lm)) / (|oa| |ob| sin(-th))
            // = -(|op| |oa| sin(lm)) / (|oa| |ob| sin(th))
            // = -(|op| sin(lm)) / (|ob| sin(th))
            var u = op.Determinant(oa).Bits / det;
            if (u < {{ component }}.NegativeOneRepr || 0 < u) {
                return false;
            }

            // 0 <= t <= 1 かつ
            // -1 <= u <= 0 なら true
            return true;
        }

        /// <summary>Check if the box intersects with a circle.</summary>
        /// <param name="circle">The circle to check.</param>
        /// <returns>True if the the box intersects with the circle, false otherwise.</returns>
        /// <remarks>
        /// <div class="WARNING alert alert-info">
        /// <h5>WARNING</h5>
        /// <para>This method will cause an <b>overflow</b> in the following cases.</para>
        /// <list type="bullet">
        /// <item><description>The box is very large.</description></item>
        /// <item><description>The specified circle is very large.</description></item>
        /// <item><description>The center point of the specified circle is very far away.</description></item>
        /// </list>
        /// </div>
        /// <div class="NOTE alert alert-info">
        /// <h5>NOTE</h5>
        /// <para>If the box is degenerate (i.e. all vertices are collinear or all vertices coincide at one point),
        /// this method returns <c>false</c> regardless of the position of the circle.</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects({{ circle }} circle) {
            if (Intersects(circle.Center)) {
                return true;
            }
            var p1 = P1;
            var p2 = P2;
            var p3 = P3;
            var p4 = P4;
            var e1 = new Segment2{{ component }}(p1, p2);
            var e2 = new Segment2{{ component }}(p2, p3);
            var e3 = new Segment2{{ component }}(p3, p4);
            var e4 = new Segment2{{ component }}(p4, p1);
            return
                e1.Intersects(circle) ||
                e2.Intersects(circle) ||
                e3.Intersects(circle) ||
                e4.Intersects(circle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(Segment{{ dim }}{{ component }} segment) {
            var p1 = P1;
            var p2 = P2;
            var p3 = P3;
            var p4 = P4;
            var axis1 = Perpendicular(p2 - p1);
            var axis2 = Perpendicular(p4 - p1);
            var axis3 = Perpendicular(segment.P2 - segment.P1);

            {
                var b1 = new {{ aabb }}(new {{ segment }}(p1, p2));
                b1.Encapsulate(p3);
                b1.Encapsulate(p4);
                var b2 = new {{ aabb }}(segment);
                if (!b1.Intersects(b2)) {
                    return false;
                }
            }
            {%- for i in range(start=1, end=4) %}

            if (!axis{{ i }}.Equals({{ translation }}.Zero)) {
                var (prjMin1, prjMax1) = ProjectOntoAxis(axis{{ i }}, p1, p2, p3, p4);
                var (prjMin2, prjMax2) = ProjectOntoAxis(axis{{ i }}, segment.P1, segment.P2);
                if (prjMax1 < prjMin2 || prjMax2 < prjMin1) {
                    return false;
                }
            }
            {%- endfor %}

            return true;
        }

        /// <summary>Checks if the box intersects with another box.</summary>
        /// <param name="other">The other box to check.</param>
        /// <returns>True if the box intersects with the other box, false otherwise.</returns>
        /// <remarks>
        /// <div class="WARNING alert alert-info">
        /// <h5>WARNING</h5>
        /// <para>This method will cause an <b>overflow</b> in the following case:
        /// <list type="bullet">
        /// <item><description>The box is very large.</description></item>
        /// <item><description>The other box is very large.</description></item>
        /// </list>
        /// </para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects({{ type }} other) {
            var p1 = P1;
            var p2 = P2;
            var p3 = P3;
            var p4 = P4;

            var q1 = other.P1;
            var q2 = other.P2;
            var q3 = other.P3;
            var q4 = other.P4;

            // ボックスが線分や点に退化している場合,
            // バウンディングボックス同士の判定によって
            // 重ならない場合を除外する.
            // バウンディングボックスによる判定は
            // 座標軸を分離軸とする判定と数学的に等価である.
            {
                var b1 = new {{ aabb }}(new {{ segment }}(p1, p2));
                var b2 = new {{ aabb }}(new {{ segment }}(q1, q2));
                b1.Encapsulate(p3);
                b1.Encapsulate(p4);
                b2.Encapsulate(q3);
                b2.Encapsulate(q4);
                if (!b1.Intersects(b2)) {
                    return false;
                }
            }

            // ボックスではなく凸多角形についての判定を行う場合は
            // ここで対角線が交差している場合に true を返すことで
            // パフォーマンスの向上が期待できる.

            // このボックスと他のボックスの全てのエッジに垂直な分離軸を調べる.
            // 各軸に対して投影を計算し, 範囲が重ならないか確認する.
            // 分離軸がゼロベクトルの場合, 投影は常に 0 になるためスキップする.
            {
                var axis1 = Perpendicular(p2 - p1);
                var axis2 = Perpendicular(p4 - p1);
                var axis3 = Perpendicular(q2 - q1);
                var axis4 = Perpendicular(q4 - q1);
                {%- for i in range(start=1, end=5) %}

                if (!axis{{ i }}.Equals({{ translation }}.Zero)) {
                    // このボックスの投影範囲
                    var (prjMin1, prjMax1) = ProjectOntoAxis(axis{{ i }}, p1, p2, p3, p4);

                    // 他のボックスの投影範囲
                    var (prjMin2, prjMax2) = ProjectOntoAxis(axis{{ i }}, q1, q2, q3, q4);

                    // [prjMin1, prjMax1] と [prjMin2, prjMax2] が重ならない場合 false を返す.
                    if (prjMax1 < prjMin2 || prjMax2 < prjMin1) {
                        return false;
                    }
                }
                {%- endfor %}
            }

            // 全ての軸で重なりがある場合, 交差している.
            return true;
        }
        #endregion
        #region Overlaps
        /// <summary>Check if the box overlaps with a point.</summary>
        /// <param name="p">The point to check.</param>
        /// <returns>True if the the box overlaps with the point, false otherwise.</returns>
        /// <remarks>
        /// <div class="WARNING alert alert-info">
        /// <h5>WARNING</h5>
        /// <para>This method will cause an <b>overflow</b> in the following case:</para>
        /// <list type="bullet">
        /// <item><description>The box is very large.</description></item>
        /// <item><description>The specified point is very far away.</description></item>
        /// </list>
        /// </div>
        /// <div class="NOTE alert alert-info">
        /// <h5>NOTE</h5>
        /// <para>If the box is degenerate (i.e. all vertices are collinear or all vertices coincide at one point),
        /// this method returns <c>false</c> regardless of the position of the point.</para>
        /// </para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps({{ translation }} p) {
            var o = P1;
            var a = P2;
            var b = P4;
            var op = p - o;
            var oa = a - o;
            var ob = b - o;

            // |oa| |ob| sin(th)
            var det = oa.Determinant(ob).Bits / {{ component }}.OneRepr;
            if (det == 0) {
                return false;
            }

            // (|op| |ob| sin(ph)) / (|oa| |ob| sin(th))
            // = (|op| sin(ph)) / (|oa| sin(th))
            var t = op.Determinant(ob).Bits / det;
            if (t <= 0 || {{ component }}.OneRepr <= t) {
                return false;
            }

            // (|op| |oa| sin(lm)) / (|oa| |ob| sin(-th))
            // = -(|op| |oa| sin(lm)) / (|oa| |ob| sin(th))
            // = -(|op| sin(lm)) / (|ob| sin(th))
            var u = op.Determinant(oa).Bits / det;
            if (u <= {{ component }}.NegativeOneRepr || 0 <= u) {
                return false;
            }

            // 0 < t < 1 かつ
            // -1 < u < 0 なら true
            return true;
        }

        /// <summary>Check if the box overlaps with a circle.</summary>
        /// <param name="circle">The circle to check.</param>
        /// <returns>True if the the box overlaps with the circle, false otherwise.</returns>
        /// <remarks>
        /// <div class="WARNING alert alert-info">
        /// <h5>WARNING</h5>
        /// <para>This method will cause an <b>overflow</b> in the following cases.</para>
        /// <list type="bullet">
        /// <item><description>The box is very large.</description></item>
        /// <item><description>The specified circle is very large.</description></item>
        /// <item><description>The center point of the specified circle is very far away.</description></item>
        /// </list>
        /// </div>
        /// <div class="NOTE alert alert-info">
        /// <h5>NOTE</h5>
        /// <para>If the box is degenerate (i.e. all vertices are collinear or all vertices coincide at one point),
        /// this method returns <c>false</c> regardless of the position of the circle.</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps({{ circle }} circle) {
            if (Overlaps(circle.Center)) {
                return true;
            }
            var p1 = P1;
            var p2 = P2;
            var p3 = P3;
            var p4 = P4;
            var e1 = new Segment2{{ component }}(p1, p2);
            var e2 = new Segment2{{ component }}(p2, p3);
            var e3 = new Segment2{{ component }}(p3, p4);
            var e4 = new Segment2{{ component }}(p4, p1);
            return
                e1.Overlaps(circle) ||
                e2.Overlaps(circle) ||
                e3.Overlaps(circle) ||
                e4.Overlaps(circle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps(Segment{{ dim }}{{ component }} segment) {
            var p1 = P1;
            var p2 = P2;
            var p3 = P3;
            var p4 = P4;
            var axis1 = Perpendicular(p2 - p1);
            var axis2 = Perpendicular(p4 - p1);
            var axis3 = Perpendicular(segment.P2 - segment.P1);

            {
                var b1 = new {{ aabb }}(new {{ segment }}(p1, p2));
                b1.Encapsulate(p3);
                b1.Encapsulate(p4);
                var b2 = new {{ aabb }}(segment);
                if (!b1.Overlaps(b2)) {
                    return false;
                }
            }
            {%- for i in range(start=1, end=4) %}

            if (!axis{{ i }}.Equals({{ translation }}.Zero)) {
                var (prjMin1, prjMax1) = ProjectOntoAxis(axis{{ i }}, p1, p2, p3, p4);
                var (prjMin2, prjMax2) = ProjectOntoAxis(axis{{ i }}, segment.P1, segment.P2);
                if (prjMax1 <= prjMin2 || prjMax2 <= prjMin1) {
                    return false;
                }
            }
            {%- endfor %}

            return true;
        }

        /// <summary>Checks if the box overlaps with another box.</summary>
        /// <param name="other">The other box to check.</param>
        /// <returns>True if the box overlaps with the other box, false otherwise.</returns>
        /// <remarks>
        /// <div class="WARNING alert alert-info">
        /// <h5>WARNING</h5>
        /// <para>This method will cause an <b>overflow</b> in the following case:
        /// <list type="bullet">
        /// <item><description>The box is very large.</description></item>
        /// <item><description>The other box is very large.</description></item>
        /// </list>
        /// </para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps({{ type }} other) {
            var p1 = P1;
            var p2 = P2;
            var p3 = P3;
            var p4 = P4;

            var q1 = other.P1;
            var q2 = other.P2;
            var q3 = other.P3;
            var q4 = other.P4;

            {
                var b1 = new {{ aabb }}(new {{ segment }}(p1, p2));
                var b2 = new {{ aabb }}(new {{ segment }}(q1, q2));
                b1.Encapsulate(p3);
                b1.Encapsulate(p4);
                b2.Encapsulate(q3);
                b2.Encapsulate(q4);
                if (!b1.Overlaps(b2)) {
                    return false;
                }
            }

            {
                var axis1 = Perpendicular(p2 - p1);
                var axis2 = Perpendicular(p4 - p1);
                var axis3 = Perpendicular(q2 - q1);
                var axis4 = Perpendicular(q4 - q1);
{# lf #}
                {%- for i in range(start=1, end=5) %}
                if (!axis{{ i }}.Equals({{ translation }}.Zero)) {
                    var (prjMin1, prjMax1) = ProjectOntoAxis(axis{{ i }}, p1, p2, p3, p4);
                    var (prjMin2, prjMax2) = ProjectOntoAxis(axis{{ i }}, q1, q2, q3, q4);

                    // (prjMin1, prjMax1) と (prjMin2, prjMax2) が重ならない場合 false を返す.
                    if (prjMax1 <= prjMin2 || prjMax2 <= prjMin1) {
                        return false;
                    }
                }
                {%- endfor %}
            }

            return true;
        }
        #endregion
        {%- endif %}
        {%- if dim == 2 %}

#if UNITY_EDITOR

        #region Draw
        public void Draw(float z) {
            {%- for i in range(start=1, end=5) %}
            var p{{ i }} = P{{ i }};
            {%- endfor %}
            {%- for i in range(start=1, end=5) %}
            var q{{ i }} = new Vector3((float)p{{ i }}.X, (float)p{{ i }}.Y, z);
            {%- endfor %}
            {%- for i in range(start=1, end=5) %}
            {%- set n = i + 1 %}
            Gizmos.DrawLine(q{{ i }}, q{{ i%4 + 1 }});
            {%- endfor %}
        }
        public void Draw(AffineTransform2{{ component }} transform, float z) {
            (transform * this).Draw(z);
        }
        public void Draw(AffineTransform3{{ component }} transform) {
            (transform * this).Draw((float)transform.Translation.Z);
        }
        public void Draw(Matrix4x4 matrix) {
            Draw((AffineTransform3I17F15)matrix);
        }
        public void Draw(Transform transform) {
            Draw(transform.localToWorldMatrix);
        }
        #endregion

#endif // UNITY_EDITOR
{# lf #}
        {%- endif %}
    }
} // namespace {{ namespace }}.Geometry
