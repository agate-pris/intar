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
        #region Extents, Transform

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
        #region Perpendicular, ProjectOntoAxis
        /// Calculate the perpendicular vector of the specified vector.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static Vector2I17F15 Perpendicular(Vector2I17F15 v) {
            return new Vector2I17F15(-v.Y, v.X);
        }

        /// Calculate the projection range of the box on the specified axis.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static (I34F30 Min, I34F30 Max) ProjectOntoAxis(
            Vector2I17F15 axis,
            Vector2I17F15 p1,
            Vector2I17F15 p2
        ) {
            var prj = axis.Dot(p1);
            var min = prj;
            var max = prj;
            prj = axis.Dot(p2);
            if (prj < min) {
                min = prj;
            } else if (prj > max) {
                max = prj;
            }
            return (min, max);
        }

        /// Calculate the projection range of the box on the specified axis.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static (I34F30 Min, I34F30 Max) ProjectOntoAxis(
            Vector2I17F15 axis,
            Vector2I17F15 p1,
            Vector2I17F15 p2,
            Vector2I17F15 p3,
            Vector2I17F15 p4
        ) {
            var prj = axis.Dot(p1);
            var min = prj;
            var max = prj;
            prj = axis.Dot(p2);
            if (prj < min) {
                min = prj;
            } else if (prj > max) {
                max = prj;
            }
            prj = axis.Dot(p3);
            if (prj < min) {
                min = prj;
            } else if (prj > max) {
                max = prj;
            }
            prj = axis.Dot(p4);
            if (prj < min) {
                min = prj;
            } else if (prj > max) {
                max = prj;
            }
            return (min, max);
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
            var op = p - o;
            var oa = a - o;
            var ob = b - o;

            // |oa| |ob| sin(th)
            var det = oa.Determinant(ob).Bits / I17F15.OneRepr;

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
            if (t < 0 || I17F15.OneRepr < t) {
                return false;
            }

            // 軸 OB 上の位置の反数.
            // 計算を省略するため det を流用する.
            // そのため, 反数となる.
            // (|op| |oa| sin(lm)) / (|oa| |ob| sin(-th))
            // = -(|op| |oa| sin(lm)) / (|oa| |ob| sin(th))
            // = -(|op| sin(lm)) / (|ob| sin(th))
            var u = op.Determinant(oa).Bits / det;
            if (u < I17F15.NegativeOneRepr || 0 < u) {
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
        public bool Intersects(CircleI17F15 circle) {
            if (Intersects(circle.Center)) {
                return true;
            }
            var p1 = P1;
            var p2 = P2;
            var p3 = P3;
            var p4 = P4;
            var e1 = new Segment2I17F15(p1, p2);
            var e2 = new Segment2I17F15(p2, p3);
            var e3 = new Segment2I17F15(p3, p4);
            var e4 = new Segment2I17F15(p4, p1);
            return
                e1.Intersects(circle) ||
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
            var axis1 = Perpendicular(p2 - p1);
            var axis2 = Perpendicular(p4 - p1);
            var axis3 = Perpendicular(segment.P2 - segment.P1);

            {
                var b1 = new Aabb2I17F15(new Segment2I17F15(p1, p2));
                b1.Encapsulate(p3);
                b1.Encapsulate(p4);
                var b2 = new Aabb2I17F15(segment);
                if (!b1.Intersects(b2)) {
                    return false;
                }
            }

            if (!axis1.Equals(Vector2I17F15.Zero)) {
                var (prjMin1, prjMax1) = ProjectOntoAxis(axis1, p1, p2, p3, p4);
                var (prjMin2, prjMax2) = ProjectOntoAxis(axis1, segment.P1, segment.P2);
                if (prjMax1 < prjMin2 || prjMax2 < prjMin1) {
                    return false;
                }
            }

            if (!axis2.Equals(Vector2I17F15.Zero)) {
                var (prjMin1, prjMax1) = ProjectOntoAxis(axis2, p1, p2, p3, p4);
                var (prjMin2, prjMax2) = ProjectOntoAxis(axis2, segment.P1, segment.P2);
                if (prjMax1 < prjMin2 || prjMax2 < prjMin1) {
                    return false;
                }
            }

            if (!axis3.Equals(Vector2I17F15.Zero)) {
                var (prjMin1, prjMax1) = ProjectOntoAxis(axis3, p1, p2, p3, p4);
                var (prjMin2, prjMax2) = ProjectOntoAxis(axis3, segment.P1, segment.P2);
                if (prjMax1 < prjMin2 || prjMax2 < prjMin1) {
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

            // ボックスが線分や点に退化している場合,
            // バウンディングボックス同士の判定によって
            // 重ならない場合を除外する.
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
                var axis1 = Perpendicular(p2 - p1);
                var axis2 = Perpendicular(p4 - p1);
                var axis3 = Perpendicular(q2 - q1);
                var axis4 = Perpendicular(q4 - q1);

                if (!axis1.Equals(Vector2I17F15.Zero)) {
                    // このボックスの投影範囲
                    var (prjMin1, prjMax1) = ProjectOntoAxis(axis1, p1, p2, p3, p4);

                    // 他のボックスの投影範囲
                    var (prjMin2, prjMax2) = ProjectOntoAxis(axis1, q1, q2, q3, q4);

                    // [prjMin1, prjMax1] と [prjMin2, prjMax2] が重ならない場合 false を返す.
                    if (prjMax1 < prjMin2 || prjMax2 < prjMin1) {
                        return false;
                    }
                }

                if (!axis2.Equals(Vector2I17F15.Zero)) {
                    // このボックスの投影範囲
                    var (prjMin1, prjMax1) = ProjectOntoAxis(axis2, p1, p2, p3, p4);

                    // 他のボックスの投影範囲
                    var (prjMin2, prjMax2) = ProjectOntoAxis(axis2, q1, q2, q3, q4);

                    // [prjMin1, prjMax1] と [prjMin2, prjMax2] が重ならない場合 false を返す.
                    if (prjMax1 < prjMin2 || prjMax2 < prjMin1) {
                        return false;
                    }
                }

                if (!axis3.Equals(Vector2I17F15.Zero)) {
                    // このボックスの投影範囲
                    var (prjMin1, prjMax1) = ProjectOntoAxis(axis3, p1, p2, p3, p4);

                    // 他のボックスの投影範囲
                    var (prjMin2, prjMax2) = ProjectOntoAxis(axis3, q1, q2, q3, q4);

                    // [prjMin1, prjMax1] と [prjMin2, prjMax2] が重ならない場合 false を返す.
                    if (prjMax1 < prjMin2 || prjMax2 < prjMin1) {
                        return false;
                    }
                }

                if (!axis4.Equals(Vector2I17F15.Zero)) {
                    // このボックスの投影範囲
                    var (prjMin1, prjMax1) = ProjectOntoAxis(axis4, p1, p2, p3, p4);

                    // 他のボックスの投影範囲
                    var (prjMin2, prjMax2) = ProjectOntoAxis(axis4, q1, q2, q3, q4);

                    // [prjMin1, prjMax1] と [prjMin2, prjMax2] が重ならない場合 false を返す.
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
            var op = p - o;
            var oa = a - o;
            var ob = b - o;

            // |oa| |ob| sin(th)
            var det = oa.Determinant(ob).Bits / I17F15.OneRepr;
            if (det == 0) {
                return false;
            }

            // (|op| |ob| sin(ph)) / (|oa| |ob| sin(th))
            // = (|op| sin(ph)) / (|oa| sin(th))
            var t = op.Determinant(ob).Bits / det;
            if (t <= 0 || I17F15.OneRepr <= t) {
                return false;
            }

            // (|op| |oa| sin(lm)) / (|oa| |ob| sin(-th))
            // = -(|op| |oa| sin(lm)) / (|oa| |ob| sin(th))
            // = -(|op| sin(lm)) / (|ob| sin(th))
            var u = op.Determinant(oa).Bits / det;
            if (u <= I17F15.NegativeOneRepr || 0 <= u) {
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
        public bool Overlaps(CircleI17F15 circle) {
            if (Overlaps(circle.Center)) {
                return true;
            }
            var p1 = P1;
            var p2 = P2;
            var p3 = P3;
            var p4 = P4;
            var e1 = new Segment2I17F15(p1, p2);
            var e2 = new Segment2I17F15(p2, p3);
            var e3 = new Segment2I17F15(p3, p4);
            var e4 = new Segment2I17F15(p4, p1);
            return
                e1.Overlaps(circle) ||
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
            var axis1 = Perpendicular(p2 - p1);
            var axis2 = Perpendicular(p4 - p1);
            var axis3 = Perpendicular(segment.P2 - segment.P1);

            {
                var b1 = new Aabb2I17F15(new Segment2I17F15(p1, p2));
                b1.Encapsulate(p3);
                b1.Encapsulate(p4);
                var b2 = new Aabb2I17F15(segment);
                if (!b1.Overlaps(b2)) {
                    return false;
                }
            }

            if (!axis1.Equals(Vector2I17F15.Zero)) {
                var (prjMin1, prjMax1) = ProjectOntoAxis(axis1, p1, p2, p3, p4);
                var (prjMin2, prjMax2) = ProjectOntoAxis(axis1, segment.P1, segment.P2);
                if (prjMax1 <= prjMin2 || prjMax2 <= prjMin1) {
                    return false;
                }
            }

            if (!axis2.Equals(Vector2I17F15.Zero)) {
                var (prjMin1, prjMax1) = ProjectOntoAxis(axis2, p1, p2, p3, p4);
                var (prjMin2, prjMax2) = ProjectOntoAxis(axis2, segment.P1, segment.P2);
                if (prjMax1 <= prjMin2 || prjMax2 <= prjMin1) {
                    return false;
                }
            }

            if (!axis3.Equals(Vector2I17F15.Zero)) {
                var (prjMin1, prjMax1) = ProjectOntoAxis(axis3, p1, p2, p3, p4);
                var (prjMin2, prjMax2) = ProjectOntoAxis(axis3, segment.P1, segment.P2);
                if (prjMax1 <= prjMin2 || prjMax2 <= prjMin1) {
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
                var axis1 = Perpendicular(p2 - p1);
                var axis2 = Perpendicular(p4 - p1);
                var axis3 = Perpendicular(q2 - q1);
                var axis4 = Perpendicular(q4 - q1);

                if (!axis1.Equals(Vector2I17F15.Zero)) {
                    var (prjMin1, prjMax1) = ProjectOntoAxis(axis1, p1, p2, p3, p4);
                    var (prjMin2, prjMax2) = ProjectOntoAxis(axis1, q1, q2, q3, q4);

                    // (prjMin1, prjMax1) と (prjMin2, prjMax2) が重ならない場合 false を返す.
                    if (prjMax1 <= prjMin2 || prjMax2 <= prjMin1) {
                        return false;
                    }
                }
                if (!axis2.Equals(Vector2I17F15.Zero)) {
                    var (prjMin1, prjMax1) = ProjectOntoAxis(axis2, p1, p2, p3, p4);
                    var (prjMin2, prjMax2) = ProjectOntoAxis(axis2, q1, q2, q3, q4);

                    // (prjMin1, prjMax1) と (prjMin2, prjMax2) が重ならない場合 false を返す.
                    if (prjMax1 <= prjMin2 || prjMax2 <= prjMin1) {
                        return false;
                    }
                }
                if (!axis3.Equals(Vector2I17F15.Zero)) {
                    var (prjMin1, prjMax1) = ProjectOntoAxis(axis3, p1, p2, p3, p4);
                    var (prjMin2, prjMax2) = ProjectOntoAxis(axis3, q1, q2, q3, q4);

                    // (prjMin1, prjMax1) と (prjMin2, prjMax2) が重ならない場合 false を返す.
                    if (prjMax1 <= prjMin2 || prjMax2 <= prjMin1) {
                        return false;
                    }
                }
                if (!axis4.Equals(Vector2I17F15.Zero)) {
                    var (prjMin1, prjMax1) = ProjectOntoAxis(axis4, p1, p2, p3, p4);
                    var (prjMin2, prjMax2) = ProjectOntoAxis(axis4, q1, q2, q3, q4);

                    // (prjMin1, prjMax1) と (prjMin2, prjMax2) が重ならない場合 false を返す.
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
