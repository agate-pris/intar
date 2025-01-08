using System;
using System.Runtime.CompilerServices;

#if UNITY_EDITOR

using UnityEngine;

#endif // UNITY_EDITOR

namespace Intar.Geometry {

    /// <summary>
    /// A 2D box defined by affine transform and extents.
    /// </summary>
    [Serializable]
    public struct Box2I17F15 : IEquatable<Box2I17F15> {
        #region Transform, Extents

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public AffineTransform2I17F15 Transform;
        public Vector2I17F15 Extents;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        #region Center, Size
        public Vector2I17F15 Center {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Transform.Translation;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Transform.Translation = value;
        }
        public Vector2I17F15 Size {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Vector2I17F15.FromRepr(2 * Extents.Repr);
        }
        #endregion
        #region P1, P2, P3, P4
        public Vector2I17F15 P1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Transform * Extents;
        }
        public Vector2I17F15 P2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Transform * Vector2I17F15.FromRepr(new Vector2Int32(
                -Extents.Repr.X, Extents.Repr.Y
            ));
        }
        public Vector2I17F15 P3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Transform * Vector2I17F15.FromRepr(new Vector2Int32(
                -Extents.Repr.X, -Extents.Repr.Y
            ));
        }
        public Vector2I17F15 P4 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Transform * Vector2I17F15.FromRepr(new Vector2Int32(
                Extents.Repr.X, -Extents.Repr.Y
            ));
        }
        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Box2I17F15(
            AffineTransform2I17F15 transform, Vector2I17F15 extents
        ) {
            Transform = transform;
            Extents = extents;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Box2I17F15(
            Matrix2x2I17F15 rotationScale,
            Vector2I17F15 center, Vector2I17F15 extents
        ) : this(
            new AffineTransform2I17F15(rotationScale, center), extents
        ) { }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Box2I17F15(
            Vector2I17F15 center, Vector2I17F15 extents
        ) : this(Matrix2x2I17F15.Identity, center, extents) { }
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Box2I17F15 other) =>
            Center.Equals(other.Center) &&
            Transform.Equals(other.Transform);
        #endregion
        #region IEqualityOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Box2I17F15 left, Box2I17F15 right) {
            return left.Equals(right);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Box2I17F15 left, Box2I17F15 right) {
            return !(left == right);
        }
        #endregion
        #region Object
        public override bool Equals(object obj) {
            return obj is Box2I17F15 o && Equals(o);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(Extents, Transform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() {
            return $"({P1}, {P2}, {P3}, {P4})";
        }
        #endregion
        #region IMultiplyOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Box2I17F15 operator *(AffineTransform2I17F15 left, Box2I17F15 right) {
            return new Box2I17F15(left * right.Transform, right.Extents);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Box2I17F15 operator *(AffineTransform3I17F15 left, Box2I17F15 right) {
            return new AffineTransform2I17F15(
                new Matrix2x2I17F15(
                    left.RotationScale.C0.XY(),
                    left.RotationScale.C1.XY()
                ), left.Translation.XY()
            ) * right;
        }
        #endregion
        #region AccumulateDistanceFromAxis
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static (I34F30 Min, I34F30 Max) AccumulateDistanceFromAxis(
            Vector2I17F15 axis, Vector2I17F15 p, I34F30 min, I34F30 max
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
        public bool Intersects(Vector2I17F15 p) {
            var o = P1;
            var a = P2;
            var b = P4;

            // 一組以上の互いに線形独立なベクトルが含まれない場合,
            // 後続のロジックによって交差を判定することができないため,
            // 事前にバウンディングボックスによる判定を行う.
            // バウンディングボックスによる判定は
            // 座標軸を分離軸とする判定と数学的に等価である.
            {
                var envelope = new Aabb2I17F15(new Segment2I17F15(a, b));
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

            if (g < I34F30.Zero) {
                if (h < g || I34F30.Zero < h) {
                    return false;
                }
                return g <= i && i <= I34F30.Zero;
            } else {
                if (h < I34F30.Zero || g < h) {
                    return false;
                }
                return I34F30.Zero <= i && i <= g;
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
        public bool Intersects(CircleI17F15 circle) {
            if (Intersects(circle.Center)) { return true; }
            var p1 = P1;
            var p2 = P2;
            var p3 = P3;
            var p4 = P4;
            var e1 = new Segment2I17F15(p1, p2);
            var e2 = new Segment2I17F15(p2, p3);
            var e3 = new Segment2I17F15(p3, p4);
            var e4 = new Segment2I17F15(p4, p1);
            return e1.Intersects(circle) ||
                   e2.Intersects(circle) ||
                   e3.Intersects(circle) ||
                   e4.Intersects(circle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(Segment2I17F15 segment) {
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
                var envelope = new Aabb2I17F15(new Segment2I17F15(p1, p2));
                envelope.Encapsulate(p3);
                envelope.Encapsulate(p4);
                if (!envelope.Intersects(new Aabb2I17F15(segment))) {
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

            if (!v1.Equals(Vector2I17F15.Zero)) {
                var prjMin1 = v1.Determinant(p1);
                var prjMin2 = v1.Determinant(segment.P1);
                var prjMax1 = prjMin1;
                var prjMax2 = prjMin2;
                (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v1, p4, prjMin1, prjMax1);
                (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v1, segment.P2, prjMin2, prjMax2);
                if (prjMax1 < prjMin2 || prjMax2 < prjMin1) {
                    return false;
                }
            }

            if (!v2.Equals(Vector2I17F15.Zero)) {
                var prjMin1 = v2.Determinant(p1);
                var prjMin2 = v2.Determinant(segment.P1);
                var prjMax1 = prjMin1;
                var prjMax2 = prjMin2;
                (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v2, p2, prjMin1, prjMax1);
                (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v2, segment.P2, prjMin2, prjMax2);
                if (prjMax1 < prjMin2 || prjMax2 < prjMin1) {
                    return false;
                }
            }

            if (!v3.Equals(Vector2I17F15.Zero)) {
                var prjMin1 = v3.Determinant(p1);
                var prjMax1 = prjMin1;
                var prj2 = v3.Determinant(segment.P1);
                (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v3, p2, prjMin1, prjMax1);
                (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v3, p3, prjMin1, prjMax1);
                (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v3, p4, prjMin1, prjMax1);
                if (prjMax1 < prj2 || prj2 < prjMin1) {
                    return false;
                }
            }

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
        public bool Intersects(Box2I17F15 other) {
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
                var b1 = new Aabb2I17F15(new Segment2I17F15(p1, p2));
                var b2 = new Aabb2I17F15(new Segment2I17F15(q1, q2));
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

                if (!v1.Equals(Vector2I17F15.Zero)) {
                    var prjMin1 = v1.Determinant(p1);
                    var prjMin2 = v1.Determinant(q1);
                    var prjMax1 = prjMin1;
                    var prjMax2 = prjMin2;
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v1, p4, prjMin1, prjMax1);
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v1, q2, prjMin2, prjMax2);
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v1, q3, prjMin2, prjMax2);
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v1, q4, prjMin2, prjMax2);
                    if (prjMax1 < prjMin2 || prjMax2 < prjMin1) {
                        return false;
                    }
                }

                if (!v2.Equals(Vector2I17F15.Zero)) {
                    var prjMin1 = v2.Determinant(p1);
                    var prjMin2 = v2.Determinant(q1);
                    var prjMax1 = prjMin1;
                    var prjMax2 = prjMin2;
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v2, p2, prjMin1, prjMax1);
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v2, q2, prjMin2, prjMax2);
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v2, q3, prjMin2, prjMax2);
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v2, q4, prjMin2, prjMax2);
                    if (prjMax1 < prjMin2 || prjMax2 < prjMin1) {
                        return false;
                    }
                }

                if (!v3.Equals(Vector2I17F15.Zero)) {
                    var prjMin1 = v3.Determinant(p1);
                    var prjMin2 = v3.Determinant(q1);
                    var prjMax1 = prjMin1;
                    var prjMax2 = prjMin2;
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v3, p2, prjMin1, prjMax1);
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v3, p3, prjMin1, prjMax1);
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v3, p4, prjMin1, prjMax1);
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v3, q4, prjMin2, prjMax2);
                    if (prjMax1 < prjMin2 || prjMax2 < prjMin1) {
                        return false;
                    }
                }

                if (!v4.Equals(Vector2I17F15.Zero)) {
                    var prjMin1 = v4.Determinant(p1);
                    var prjMin2 = v4.Determinant(q1);
                    var prjMax1 = prjMin1;
                    var prjMax2 = prjMin2;
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v4, p2, prjMin1, prjMax1);
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v4, p3, prjMin1, prjMax1);
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v4, p4, prjMin1, prjMax1);
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v4, q2, prjMin2, prjMax2);
                    if (prjMax1 < prjMin2 || prjMax2 < prjMin1) {
                        return false;
                    }
                }
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
        public bool Overlaps(Vector2I17F15 p) {
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

            if (g < I34F30.Zero) {
                if (h <= g || I34F30.Zero <= h) {
                    return false;
                }
                return g < i && i < I34F30.Zero;
            } else {
                if (h <= I34F30.Zero || g <= h) {
                    return false;
                }
                return I34F30.Zero < i && i < g;
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
        public bool Overlaps(CircleI17F15 circle) {
            if (Overlaps(circle.Center)) { return true; }
            var p1 = P1;
            var p2 = P2;
            var p3 = P3;
            var p4 = P4;
            var e1 = new Segment2I17F15(p1, p2);
            var e2 = new Segment2I17F15(p2, p3);
            var e3 = new Segment2I17F15(p3, p4);
            var e4 = new Segment2I17F15(p4, p1);
            return e1.Overlaps(circle) ||
                   e2.Overlaps(circle) ||
                   e3.Overlaps(circle) ||
                   e4.Overlaps(circle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps(Segment2I17F15 segment) {
            var p1 = P1;
            var p2 = P2;
            var p3 = P3;
            var p4 = P4;

            {
                var envelope = new Aabb2I17F15(new Segment2I17F15(p1, p2));
                envelope.Encapsulate(p3);
                envelope.Encapsulate(p4);
                if (!envelope.Overlaps(new Aabb2I17F15(segment))) {
                    return false;
                }
            }

            var v1 = Transform.RotationScale.C0;
            var v2 = Transform.RotationScale.C1;
            var v3 = segment.P2 - segment.P1;

            if (!v1.Equals(Vector2I17F15.Zero)) {
                var prjMin1 = v1.Determinant(p1);
                var prjMin2 = v1.Determinant(segment.P1);
                var prjMax1 = prjMin1;
                var prjMax2 = prjMin2;
                (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v1, p4, prjMin1, prjMax1);
                (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v1, segment.P2, prjMin2, prjMax2);
                if (prjMax1 <= prjMin2 || prjMax2 <= prjMin1) {
                    return false;
                }
            }

            if (!v2.Equals(Vector2I17F15.Zero)) {
                var prjMin1 = v2.Determinant(p1);
                var prjMin2 = v2.Determinant(segment.P1);
                var prjMax1 = prjMin1;
                var prjMax2 = prjMin2;
                (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v2, p2, prjMin1, prjMax1);
                (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v2, segment.P2, prjMin2, prjMax2);
                if (prjMax1 <= prjMin2 || prjMax2 <= prjMin1) {
                    return false;
                }
            }

            if (!v3.Equals(Vector2I17F15.Zero)) {
                var prjMin1 = v3.Determinant(p1);
                var prjMax1 = prjMin1;
                var prj2 = v3.Determinant(segment.P1);
                (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v3, p2, prjMin1, prjMax1);
                (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v3, p3, prjMin1, prjMax1);
                (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v3, p4, prjMin1, prjMax1);
                if (prjMax1 <= prj2 || prj2 <= prjMin1) {
                    return false;
                }
            }

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
        public bool Overlaps(Box2I17F15 other) {
            var p1 = P1;
            var p2 = P2;
            var p3 = P3;
            var p4 = P4;

            var q1 = other.P1;
            var q2 = other.P2;
            var q3 = other.P3;
            var q4 = other.P4;

            {
                var b1 = new Aabb2I17F15(new Segment2I17F15(p1, p2));
                var b2 = new Aabb2I17F15(new Segment2I17F15(q1, q2));
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

                if (!v1.Equals(Vector2I17F15.Zero)) {
                    var prjMin1 = v1.Determinant(p1);
                    var prjMin2 = v1.Determinant(q1);
                    var prjMax1 = prjMin1;
                    var prjMax2 = prjMin2;
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v1, p4, prjMin1, prjMax1);
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v1, q2, prjMin2, prjMax2);
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v1, q3, prjMin2, prjMax2);
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v1, q4, prjMin2, prjMax2);
                    if (prjMax1 <= prjMin2 || prjMax2 <= prjMin1) {
                        return false;
                    }
                }

                if (!v2.Equals(Vector2I17F15.Zero)) {
                    var prjMin1 = v2.Determinant(p1);
                    var prjMin2 = v2.Determinant(q1);
                    var prjMax1 = prjMin1;
                    var prjMax2 = prjMin2;
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v2, p2, prjMin1, prjMax1);
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v2, q2, prjMin2, prjMax2);
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v2, q3, prjMin2, prjMax2);
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v2, q4, prjMin2, prjMax2);
                    if (prjMax1 <= prjMin2 || prjMax2 <= prjMin1) {
                        return false;
                    }
                }

                if (!v3.Equals(Vector2I17F15.Zero)) {
                    var prjMin1 = v3.Determinant(p1);
                    var prjMin2 = v3.Determinant(q1);
                    var prjMax1 = prjMin1;
                    var prjMax2 = prjMin2;
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v3, p2, prjMin1, prjMax1);
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v3, p3, prjMin1, prjMax1);
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v3, p4, prjMin1, prjMax1);
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v3, q4, prjMin2, prjMax2);
                    if (prjMax1 <= prjMin2 || prjMax2 <= prjMin1) {
                        return false;
                    }
                }

                if (!v4.Equals(Vector2I17F15.Zero)) {
                    var prjMin1 = v4.Determinant(p1);
                    var prjMin2 = v4.Determinant(q1);
                    var prjMax1 = prjMin1;
                    var prjMax2 = prjMin2;
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v4, p2, prjMin1, prjMax1);
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v4, p3, prjMin1, prjMax1);
                    (prjMin1, prjMax1) = AccumulateDistanceFromAxis(v4, p4, prjMin1, prjMax1);
                    (prjMin2, prjMax2) = AccumulateDistanceFromAxis(v4, q2, prjMin2, prjMax2);
                    if (prjMax1 <= prjMin2 || prjMax2 <= prjMin1) {
                        return false;
                    }
                }
            }

            return true;
        }
        #endregion

#if UNITY_EDITOR

        #region Draw
        public void Draw(float z) {
            var p1 = P1;
            var p2 = P2;
            var p3 = P3;
            var p4 = P4;
            var q1 = new Vector3((float)p1.X, (float)p1.Y, z);
            var q2 = new Vector3((float)p2.X, (float)p2.Y, z);
            var q3 = new Vector3((float)p3.X, (float)p3.Y, z);
            var q4 = new Vector3((float)p4.X, (float)p4.Y, z);
            Gizmos.DrawLine(q1, q2);
            Gizmos.DrawLine(q2, q3);
            Gizmos.DrawLine(q3, q4);
            Gizmos.DrawLine(q4, q1);
        }
        public void Draw(AffineTransform2I17F15 transform, float z) {
            (transform * this).Draw(z);
        }
        public void Draw(AffineTransform3I17F15 transform) {
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

    }
} // namespace Intar.Geometry
