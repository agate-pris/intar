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
        #region Transform, Extents

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
        #region AccumulateDistanceFromAxis
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static ({{ component_wide }} Min, {{ component_wide }} Max) AccumulateDistanceFromAxis(
            {{ translation }} axis, {{ translation }} p, {{ component_wide }} min, {{ component_wide }} max
        ) {
            var det = axis.Determinant(p);
            return det < min ? (det, max)
                 : max < det ? (min, det)
                             : (min, max);
        }
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

            // 一組以上の互いに線形独立なベクトルが含まれない場合,
            // 後続のロジックによって交差を判定することができないため,
            // 事前にバウンディングボックスによる判定を行う.
            // バウンディングボックスによる判定は
            // 座標軸を分離軸とする判定と数学的に等価である.
            {
                var envelope = new {{ aabb }}(new {{ segment }}(a, b));
                envelope.Encapsulate(o);
                envelope.Encapsulate(P3);
                if (!envelope.Intersects(p)) {
                    return false;
                }
            }

            var op = p - o;
            var oa = a - o;
            var ob = b - o;

            // 線分 OA, OB をその辺とする平行四辺形と点 P について
            // OA と OB が成す角を th,
            // OP と OB が成す角を ph,
            // OA と OP が成す各を lm とする. 点 P が平行四辺形の
            // 内側にある時 sin(th) < 0 ならば
            // |OA| sin(th) < |OP| sin(ph) < 0 かつ
            // |OB| sin(th) < |OP| sin(lm) < 0. よって
            // |OA| |OB| sin(th) < |OP| |OB| sin(ph) < 0 かつ
            // |OA| |OB| sin(th) < |OA| |OP| sin(lm) < 0 となる.

            // i の計算は最適化により早期リターンより後になることを期待.
            // ここではベクトルの代わりにアフィン変換の列を直接使うことは
            // できない. もしアフィン変換の列を使う場合,
            // |C0| |OB| sin(th), |C0| |OP| sin(lm), |C1| |OB| sin(th),
            // そして |C1| |OP| sin(ph) の 4 つの値を計算する必要がある.
            // |OA| |OB| sin(th) を用いれば 3 つの値で済む.

            var g = oa.Determinant(ob); // |OA| |OB| sin(th)
            var h = op.Determinant(ob); // |OP| |OB| sin(ph)
            var i = oa.Determinant(op); // |OA| |OP| sin(lm)

            if (g < {{ component_wide }}.Zero) {
                if (h < g || {{ component_wide }}.Zero < h) {
                    return false;
                }
                return g <= i && i <= {{ component_wide }}.Zero;
            } else {
                if (h < {{ component_wide }}.Zero || g < h) {
                    return false;
                }
                return {{ component_wide }}.Zero <= i && i <= g;
            }
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
            if (Intersects(circle.Center)) { return true; }
            var p1 = P1;
            var p2 = P2;
            var p3 = P3;
            var p4 = P4;
            var e1 = new Segment2{{ component }}(p1, p2);
            var e2 = new Segment2{{ component }}(p2, p3);
            var e3 = new Segment2{{ component }}(p3, p4);
            var e4 = new Segment2{{ component }}(p4, p1);
            return e1.Intersects(circle) ||
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

            // 一組以上の互いに線形独立なベクトルが含まれない場合,
            // 後続のロジックによって交差を判定することができないため,
            // 事前にバウンディングボックスによる判定を行う.
            // バウンディングボックスによる判定は
            // 座標軸を分離軸とする判定と数学的に等価である.
            {
                var envelope = new {{ aabb }}(new {{ segment }}(p1, p2));
                envelope.Encapsulate(p3);
                envelope.Encapsulate(p4);
                if (!envelope.Intersects(new {{ aabb }}(segment))) {
                    return false;
                }
            }

            // p2 - p1, p4 - p1 の代わりにアフィン変換の列を
            // 直接使うことで引き算の分の計算を省略することができる.
            // Extents と乗算しない分僅かな誤差が生じるが,
            // これは分離軸の計算において無視できる程度のものである.

            var v1 = Transform.RotationScale.C0;
            var v2 = Transform.RotationScale.C1;
            var v3 = segment.P2 - segment.P1;
            {%- for i in range(start=1, end=4) %}

            if (!v{{ i }}.Equals({{ translation }}.Zero)) {
                var prjMin1 = v{{ i }}.Determinant(p1);
                {%- if i != 3 %}
                var prjMin2 = v{{ i }}.Determinant(segment.P1);
                {%- endif %}
                var prjMax1 = prjMin1;
                {%- if i != 3 %}
                var prjMax2 = prjMin2;
                {%- else %}
                var prj2 = v{{ i }}.Determinant(segment.P1);
                {%- endif %}
                {%- for j in range(start=2, end=5) %}
                {%- if i == 1 and (j == 2 or j == 3)
                    or i == 2 and (j == 3 or j == 4)
                %}{% continue %}{% endif %}
                (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v{{ i }}, p{{ j }}, prjMin1, prjMax1);
                {%- endfor %}
                {%- if i != 3 %}
                (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v{{ i }}, segment.P2, prjMin2, prjMax2);
                {%- endif %}
                if (prjMax1 < prj{% if i != 3 %}Min{% endif %}2 || prj{% if i != 3 %}Max{% endif %}2 < prjMin1) {
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

            // 一組以上の互いに線形独立なベクトルが含まれない場合,
            // 後続のロジックによって交差を判定することができないため,
            // 事前にバウンディングボックスによる判定を行う.
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
                var v1 = Transform.RotationScale.C0;
                var v2 = Transform.RotationScale.C1;
                var v3 = other.Transform.RotationScale.C0;
                var v4 = other.Transform.RotationScale.C1;
                {%- for i in range(start=1, end=5) %}

                if (!v{{ i }}.Equals({{ translation }}.Zero)) {
                    var prjMin1 = v{{ i }}.Determinant(p1);
                    var prjMin2 = v{{ i }}.Determinant(q1);
                    var prjMax1 = prjMin1;
                    var prjMax2 = prjMin2;
                    {%- for j in range(start=2, end=5) %}
                    {%- if i == 1 and (j == 2 or j == 3)
                        or i == 2 and (j == 3 or j == 4)
                    %}{% continue %}{% endif %}
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v{{ i }}, p{{ j }}, prjMin1, prjMax1);
                    {%- endfor %}
                    {%- for j in range(start=2, end=5) %}
                    {%- if i == 3 and (j == 2 or j == 3)
                        or i == 4 and (j == 3 or j == 4)
                    %}{% continue %}{% endif %}
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v{{ i }}, q{{ j }}, prjMin2, prjMax2);
                    {%- endfor %}
                    if (prjMax1 < prjMin2 || prjMax2 < prjMin1) {
                        return false;
                    }
                }
                {%- endfor %}
            }

            // 全ての軸で重なりがある場合, 交差している.
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects({{ aabb }} other) {
            var p0 = P1;
            var p1 = P2;
            var p2 = P3;
            var p3 = P4;

            {
                var b = new {{ aabb }}(new {{ segment }}(p0, p1));
                b.Encapsulate(p2);
                b.Encapsulate(p3);
                if (!b.Intersects(other)) {
                    return false;
                }
            }

            var q0 = new {{ translation }}(other.MaxX, other.MinY);
            var q1 = new {{ translation }}(other.MinX, other.MinY);
            var q2 = new {{ translation }}(other.MinX, other.MaxY);
            var q3 = new {{ translation }}(other.MaxX, other.MaxY);

            {
                var v0 = Transform.RotationScale.C0;
                var v1 = Transform.RotationScale.C1;
                {%- for i in range(end=2) %}
                if (!v{{ i }}.Equals({{ translation }}.Zero)) {
                    var prjMin1 = v{{ i }}.Determinant(p0);
                    var prjMin2 = v{{ i }}.Determinant(q0);
                    var prjMax1 = prjMin1;
                    var prjMax2 = prjMin2;
                    {%- for j in range(start=1, end=4) %}
                    {%- if i == 0 and (j == 1 or j == 2)
                        or i == 1 and (j == 2 or j == 3)
                    %}{% continue %}{% endif %}
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v{{ i }}, p{{ j }}, prjMin1, prjMax1);
                    {%- endfor %}
                    {%- for j in range(start=1, end=4) %}
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v{{ i }}, q{{ j }}, prjMin2, prjMax2);
                    {%- endfor %}
                    if (prjMax1 < prjMin2 || prjMax2 < prjMin1) {
                        return false;
                    }
                }
                {%- endfor %}
            }

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

            // 一点に重なる場合, または一直線上に並ぶ場合でも誤判定は
            // 発生しないのでバウンディングボックスによる判定は不要.

            var op = p - o;
            var oa = a - o;
            var ob = b - o;

            // i の計算は最適化により早期リターンより後になることを期待.

            var g = oa.Determinant(ob); // |OA| |OB| sin(th)
            var h = op.Determinant(ob); // |OP| |OB| sin(ph)
            var i = oa.Determinant(op); // |OA| |OP| sin(lm)

            if (g < {{ component_wide }}.Zero) {
                if (h <= g || {{ component_wide }}.Zero <= h) {
                    return false;
                }
                return g < i && i < {{ component_wide }}.Zero;
            } else {
                if (h <= {{ component_wide }}.Zero || g <= h) {
                    return false;
                }
                return {{ component_wide }}.Zero < i && i < g;
            }
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
            if (Overlaps(circle.Center)) { return true; }
            var p1 = P1;
            var p2 = P2;
            var p3 = P3;
            var p4 = P4;
            var e1 = new Segment2{{ component }}(p1, p2);
            var e2 = new Segment2{{ component }}(p2, p3);
            var e3 = new Segment2{{ component }}(p3, p4);
            var e4 = new Segment2{{ component }}(p4, p1);
            return e1.Overlaps(circle) ||
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

            {
                var envelope = new {{ aabb }}(new {{ segment }}(p1, p2));
                envelope.Encapsulate(p3);
                envelope.Encapsulate(p4);
                if (!envelope.Overlaps(new {{ aabb }}(segment))) {
                    return false;
                }
            }

            var v1 = Transform.RotationScale.C0;
            var v2 = Transform.RotationScale.C1;
            var v3 = segment.P2 - segment.P1;
            {%- for i in range(start=1, end=4) %}

            if (!v{{ i }}.Equals({{ translation }}.Zero)) {
                var prjMin1 = v{{ i }}.Determinant(p1);
                {%- if i != 3 %}
                var prjMin2 = v{{ i }}.Determinant(segment.P1);
                {%- endif %}
                var prjMax1 = prjMin1;
                {%- if i != 3 %}
                var prjMax2 = prjMin2;
                {%- else %}
                var prj2 = v{{ i }}.Determinant(segment.P1);
                {%- endif %}
                {%- for j in range(start=2, end=5) %}
                {%- if i == 1 and (j == 2 or j == 3)
                    or i == 2 and (j == 3 or j == 4)
                %}{% continue %}{% endif %}
                (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v{{ i }}, p{{ j }}, prjMin1, prjMax1);
                {%- endfor %}
                {%- if i != 3 %}
                (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v{{ i }}, segment.P2, prjMin2, prjMax2);
                {%- endif %}
                if (prjMax1 <= prj{% if i != 3 %}Min{% endif %}2 || prj{% if i != 3 %}Max{% endif %}2 <= prjMin1) {
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
                var v1 = Transform.RotationScale.C0;
                var v2 = Transform.RotationScale.C1;
                var v3 = other.Transform.RotationScale.C0;
                var v4 = other.Transform.RotationScale.C1;
                {%- for i in range(start=1, end=5) %}

                if (!v{{ i }}.Equals({{ translation }}.Zero)) {
                    var prjMin1 = v{{ i }}.Determinant(p1);
                    var prjMin2 = v{{ i }}.Determinant(q1);
                    var prjMax1 = prjMin1;
                    var prjMax2 = prjMin2;
                    {%- for j in range(start=2, end=5) %}
                    {%- if i == 1 and (j == 2 or j == 3)
                        or i == 2 and (j == 3 or j == 4)
                    %}{% continue %}{% endif %}
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v{{ i }}, p{{ j }}, prjMin1, prjMax1);
                    {%- endfor %}
                    {%- for j in range(start=2, end=5) %}
                    {%- if i == 3 and (j == 2 or j == 3)
                        or i == 4 and (j == 3 or j == 4)
                    %}{% continue %}{% endif %}
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v{{ i }}, q{{ j }}, prjMin2, prjMax2);
                    {%- endfor %}
                    if (prjMax1 <= prjMin2 || prjMax2 <= prjMin1) {
                        return false;
                    }
                }
                {%- endfor %}
            }

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps({{ aabb }} other) {
            var p0 = P1;
            var p1 = P2;
            var p2 = P3;
            var p3 = P4;

            {
                var b = new {{ aabb }}(new {{ segment }}(p0, p1));
                b.Encapsulate(p2);
                b.Encapsulate(p3);
                if (!b.Overlaps(other)) {
                    return false;
                }
            }

            var q0 = new {{ translation }}(other.MaxX, other.MinY);
            var q1 = new {{ translation }}(other.MinX, other.MinY);
            var q2 = new {{ translation }}(other.MinX, other.MaxY);
            var q3 = new {{ translation }}(other.MaxX, other.MaxY);

            {
                var v0 = Transform.RotationScale.C0;
                var v1 = Transform.RotationScale.C1;
                {%- for i in range(end=2) %}
                if (!v{{ i }}.Equals({{ translation }}.Zero)) {
                    var prjMin1 = v{{ i }}.Determinant(p0);
                    var prjMin2 = v{{ i }}.Determinant(q0);
                    var prjMax1 = prjMin1;
                    var prjMax2 = prjMin2;
                    {%- for j in range(start=1, end=4) %}
                    {%- if i == 0 and (j == 1 or j == 2)
                        or i == 1 and (j == 2 or j == 3)
                    %}{% continue %}{% endif %}
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v{{ i }}, p{{ j }}, prjMin1, prjMax1);
                    {%- endfor %}
                    {%- for j in range(start=1, end=4) %}
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v{{ i }}, q{{ j }}, prjMin2, prjMax2);
                    {%- endfor %}
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
