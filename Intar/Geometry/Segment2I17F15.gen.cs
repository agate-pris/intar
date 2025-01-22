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
        #region Intersects

        // 線分と点の交差判定は実装しない.

        /// <summary>Check if the segment intersects with another segment.</summary>
        /// <param name="other">The segment to check.</param>
        /// <param name="intersection">The intersection point.</param>
        /// <returns>True if the segment intersects with the other segment, false otherwise.
        /// </returns>
        /// <remarks>
        /// <div class="WARNING alert alert-info">
        /// <h5>WARNING</h5>
        /// <para>This method causes an <b>overflow</b> in the following case:</para>
        /// <list type="bullet">
        /// <item><description>The segment is very long.</description></item>
        /// <item><description>The other segment is very long.</description></item>
        /// <item><description>The distance between the segment and the other segment is very large.
        /// </description></item>
        /// </list>
        /// </div>
        /// <div class="NOTE alert alert-info">
        /// <h5>NOTE</h5>
        /// <para>This method may return <c>false</c> regardless of the position relationship
        /// between this segment and the other segment in the following cases:</para>
        /// <list type="bullet">
        /// <item><description>Both this segment and the other segment are very short.
        /// </description></item>
        /// <item><description>The angle between this segment and the other segment is very small.
        /// </description></item>
        /// </list>
        /// </div>
        /// <div class="TIP alert alert-info">
        /// <h5>TIP</h5>
        /// <para>The <paramref name="intersection"/> parameter is not updated if this method
        /// returns <c>false</c>.</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(Segment2I17F15 other, ref Vector2I17F15 intersection) {
            var r = P2 - P1;
            var s = other.P2 - other.P1;

            // ベクトル r とベクトル s からなる行列 A について,
            // r と s がなす角を th とすると,
            // det(A) = r x s = |r| |s| sin(th) となる.
            // r と s の成分が極端に大きい場合, オーバーフローを引き起こすため注意する.
            // ここではオーバーフローが発生する可能性を低減するため,
            // 小数部が 15 ビットになるように内部表現の除算のみを行う.

            var rxs = r.Determinant(s).Bits / I17F15.OneRepr;

            // det(A) = 0 の場合, 線分は平行なため交差しない.
            // (線分が平行な場合, たとえ重なっていたとしても交差していないとみなす)
            if (rxs == 0) {
                return false;
            }

            var v = other.P1 - P1;

            // ベクトル v とベクトル s からなる行列 B について,
            // det(B) / det(A) より直線 r と直線 s の交点の
            // 直線 r に対する位置 t が求まる.
            var t = v.Determinant(s).Bits / rxs;
            if (t < 0 || I17F15.OneRepr < t) {
                return false;
            }

            // ベクトル v とベクトル r からなる行列 C について,
            // det(C) / det(A) より直線 r と直線 s の交点の
            // 直線 s に対する位置 u が求まる.
            // 本来は v の逆ベクトルを使うべきだが,
            // 除数も sxr ではなく rxs であるため問題ない.
            // (rxs = -sxr)
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

        /// <summary>Check if the segment intersects with another segment.</summary>
        /// <param name="other">The segment to check.</param>
        /// <returns>True if the segment intersects with the other segment, false otherwise.
        /// </returns>
        /// <remarks>
        /// <div class="WARNING alert alert-info">
        /// <h5>WARNING</h5>
        /// <para>This method causes an <b>overflow</b> in the following case:</para>
        /// <list type="bullet">
        /// <item><description>The segment is very long.</description></item>
        /// <item><description>The other segment is very long.</description></item>
        /// <item><description>The distance between the segment and the other segment is very large.
        /// </description></item>
        /// </list>
        /// </div>
        /// <div class="NOTE alert alert-info">
        /// <h5>NOTE</h5>
        /// <para>This method may return <c>false</c> regardless of the position relationship
        /// between this segment and the other segment in the following cases:</para>
        /// <list type="bullet">
        /// <item><description>Both this segment and the other segment are very short.
        /// </description></item>
        /// <item><description>The angle between this segment and the other segment is very small.
        /// </description></item>
        /// </list>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(Segment2I17F15 other) {
            var r = P2 - P1;
            var s = other.P2 - other.P1;

            var rxs = r.Determinant(s).Bits / I17F15.OneRepr;

            if (rxs == 0) {
                return false;
            }

            var v = other.P1 - P1;

            var t = v.Determinant(s).Bits / rxs;
            var u = v.Determinant(r).Bits / rxs;
            return 0 <= t && t <= I17F15.OneRepr &&
                   0 <= u && u <= I17F15.OneRepr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(CircleI17F15 circle) {
            var closestPoint = ClosestPoint(circle.Center);
            var distanceSquared = (closestPoint - circle.Center).LengthSquared();
            return distanceSquared <= circle.Radius.BigMul(circle.Radius);
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
