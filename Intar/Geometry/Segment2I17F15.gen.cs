using System;
using System.Runtime.CompilerServices;

#if UNITY_5_3_OR_NEWER
using UnityEngine;
#endif

namespace Intar.Geometry {
    [Serializable]
    public struct Segment2I17F15 : IEquatable<Segment2I17F15>, IFormattable {
        #region P1, P2

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector2I17F15 P1;
        public Vector2I17F15 P2;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Segment2I17F15(Vector2I17F15 p1, Vector2I17F15 p2) {
            P1 = p1;
            P2 = p2;
        }
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Segment2I17F15 other) {
            return P1.Equals(other.P1) && P2.Equals(other.P2);
        }
        #endregion
        #region IEqualityOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Segment2I17F15 left, Segment2I17F15 right) {
            return left.Equals(right);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Segment2I17F15 left, Segment2I17F15 right) {
            return !left.Equals(right);
        }
        #endregion
        #region Object
        public override bool Equals(object obj) {
            return obj is Segment2I17F15 o && Equals(o);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(P1, P2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() {
            return $"{{P1:{P1} P2:{P2}}}";
        }
        #endregion
        #region IFormattable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"{{P1:{P1.ToString(format, formatProvider)} P2:{P2.ToString(format, formatProvider)}}}";
        }
        #endregion
        #region IMultiplyOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Segment2I17F15 operator *(AffineTransform2I17F15 left, Segment2I17F15 right) {
            return new Segment2I17F15(left * right.P1, left * right.P2);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Segment2I17F15 operator *(AffineTransform3I17F15 left, Segment2I17F15 right) {
            return new AffineTransform2I17F15(
                new Matrix2x2I17F15(
                    left.RotationScale.C0.XY(),
                    left.RotationScale.C1.XY()
                ), left.Translation.XY()
            ) * right;
        }
        #endregion
        #region Envelope
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Aabb2I17F15 Envelope() {
            return new Aabb2I17F15(this);
        }
        #endregion
        #region ClosestPoint
        /// <summary>
        /// 線分上で最も点 p に近い点を求める。
        /// 線分が極端に短い場合 P1 を返す。
        /// 線分が極端に長い場合、または点 p が極端に遠い場合、
        /// オーバーフローを引き起こす。
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 ClosestPoint(Vector2I17F15 p) {
            var v = P2 - P1;

            // あとで除算するので小数部のビット数を 15 にする.
            // 線分が極端に長い場合 v ･ v はオーバーフローする.
            var vv = v.Dot(v).Bits / I17F15.OneRepr;
            if (vv == 0) {
                return P1;
            }

            // 点 p が極端に遠い場合 u ･ v はオーバーフローする.

            var u = p - P1;
            var uv = u.Dot(v).Bits;

            // ドット積の小数部のビット数は 30 になるので,
            // これを vv で割ると, その小数部のビット数は 15 になる.

#if NET5_0_OR_GREATER

            var tBits = Math.Clamp(uv / vv, 0, I17F15.OneRepr);

#else

            var tBits = Mathi.Clamp(uv / vv, 0, I17F15.OneRepr);

#endif

            var t = I17F15.FromBits((int)tBits);
            return P1 + (v * t);
        }
        #endregion
        #region Disjoint, Intersects

        // 線分と点の交差判定は実装しない.

        /// <summary>
        /// Checkes whether this segment is intersects with the specified segment.
        /// </summary>
        /// <remarks>
        /// <div class="WARNING alert alert-info">
        /// <h5>WARNING</h5>
        /// <para>If either segment is extremely long,
        /// or if the segments are extremely far apart from each other,
        /// overflow may occur.</para>
        /// </div>
        /// </remarks>
        /// <param name="other">The segment to check.</param>
        /// <param name="intersection">
        /// <para>The intersection point.</para>
        /// <div class="NOTE alert alert-info">
        /// When this method returns false, the value will not be assigned.
        /// </div>
        /// </param>
        /// <returns>
        /// <para>Returns true if this segment intersects with the specified segment;
        /// otherwise, false.</para>
        /// <div class="NOTE alert alert-info">
        /// If the segments are parallel, even if they overlap, this method will return false.
        /// </div>
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(Segment2I17F15 other, ref Vector2I17F15 intersection) {
            var r = P2 - P1;
            var s = other.P2 - other.P1;

            // r x s (2 次元のクロス積)
            // クロス積が極端に大きい場合, オーバーフローを引き起こす.
            // ここではオーバーフローが発生する可能性を低減するため,
            // I17F15 にキャストする代わりに,
            // 小数部が 15 ビットになるように内部表現の除算のみを行う.
            var rxs = r.Determinant(s).Bits / I17F15.OneRepr;

            // r x s = 0 の場合, 線分は平行なため交差しない.
            // (重なっている場合は交差していないとみなす)
            if (rxs == 0) {
                return false;
            }

            var v = other.P1 - P1;

            // クロス積の小数部は 30 ビット,
            // rxs の小数部は 15 ビットなので,
            // t と u の小数部は 15 ビットになる.

            // (v x s) / (r x s)
            var t = v.Determinant(s).Bits / rxs;
            if (t < 0 || I17F15.OneRepr < t) {
                return false;
            }

            // (v x r) / (r x s)
            var u = v.Determinant(r).Bits / rxs;
            if (u < 0 || I17F15.OneRepr < u) {
                return false;
            }

            // 0 <= t <= 1 かつ 0 <= u <= 1 の場合,
            // 線分は交差している.
            // 前提条件により t のキャストは必ず成功する.
            intersection = P1 + (I17F15.FromBits((int)t) * r);
            return true;
        }

        /// <summary>
        /// Checkes whether this segment is intersects with the specified segment.
        /// </summary>
        /// <remarks>
        /// <div class="WARNING alert alert-info">
        /// <h5>WARNING</h5>
        /// <para>If either segment is extremely long,
        /// or if the segments are extremely far apart from each other,
        /// overflow may occur.</para>
        /// </div>
        /// </remarks>
        /// <param name="other">The segment to check.</param>
        /// <returns>
        /// <para>Returns true if this segment intersects with the specified segment;
        /// otherwise, false.</para>
        /// <div class="NOTE alert alert-info">
        /// If the segments are parallel, even if they overlap, this method will return false.
        /// </div>
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(Segment2I17F15 other) {
            var r = P2 - P1;
            var s = other.P2 - other.P1;

            // r x s (2 次元のクロス積)
            // クロス積が極端に大きい場合, オーバーフローを引き起こす.
            // ここではオーバーフローが発生する可能性を低減するため,
            // I17F15 にキャストする代わりに,
            // 小数部が 15 ビットになるように内部表現の除算のみを行う.
            var rxs = r.Determinant(s).Bits / I17F15.OneRepr;

            // r x s = 0 の場合, 線分は平行なため交差しない.
            // (重なっている場合は交差していないとみなす)
            if (rxs == 0) {
                return false;
            }

            var v = other.P1 - P1;

            // クロス積の小数部は 30 ビット,
            // rxs の小数部は 15 ビットなので,
            // t と u の小数部は 15 ビットになる.

            // t = (v x s) / (r x s),
            // u = (v x r) / (r x s)

            var t = v.Determinant(s).Bits / rxs;
            var u = v.Determinant(r).Bits / rxs;
            return 0 <= t && t <= I17F15.OneRepr &&
                   0 <= u && u <= I17F15.OneRepr;
        }

        /// <summary>
        /// Checks whether this segment is disjoint with the specified segment.
        /// </summary>
        /// <remarks>
        /// <div class="WARNING alert alert-info">
        /// <h5>WARNING</h5>
        /// <para>If either segment is extremely long,
        /// or if the segments are extremely far apart from each other,
        /// overflow may occur.</para>
        /// </div>
        /// </remarks>
        /// <param name="other">The segment to check.</param>
        /// <returns>
        /// <para>Returns true if this segment is disjoint with the specified segment;
        /// otherwise, false.</para>
        /// <div class="NOTE alert alert-info">
        /// If the segments are parallel, even if they overlap, this method will return true.
        /// </div>
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Disjoint(Segment2I17F15 other) {
            return !Intersects(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Disjoint(CircleI17F15 circle) {
            var closestPoint = ClosestPoint(circle.Center);
            var distanceSquared = (closestPoint - circle.Center).LengthSquared();
            return distanceSquared > circle.Radius.BigMul(circle.Radius);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(CircleI17F15 circle) {
            return !Disjoint(circle);
        }
        #endregion

#if UNITY_EDITOR

        #region Draw
        public void Draw(float z) {
            var p1 = new Vector3((float)P1.X, (float)P1.Y, z);
            var p2 = new Vector3((float)P2.X, (float)P2.Y, z);
            Gizmos.DrawLine(p1, p2);
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
