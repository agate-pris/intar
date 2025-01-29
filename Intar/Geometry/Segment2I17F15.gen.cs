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
            var ab = P2 - P1;
            var cd = other.P2 - other.P1;

            // 線分 AB, 線分 CD について交点が存在するとき,
            // AB と CD がなす角を th,
            // AC と AB がなす角を ph,
            // AC と CD がなす角を lm とすると sin(th) < 0 の時
            // 0 < |AC| sin(-ph) < |CD| sin(-th) かつ
            // 0 < |AC| sin(-lm) < |AB| sin(-th) といえる.
            // 上記の式を変形すると
            // |CD| sin(th) < |AC| sin(ph) < 0
            // |AB| sin(th) < |AC| sin(lm) < 0
            // |AB| |CD| sin(th) < |AC| |AB| sin(ph) < 0
            // |AB| |CD| sin(th) < |AC| |CD| sin(lm) < 0

            // |AB| |CD| sin(th)
            var g = ab.Determinant(cd).Bits / I17F15.OneRepr;

            // g = 0 の場合, いずれか, または両方の線分の長さが 0,
            // または平行である. 平行かつ線分が重なっている場合,
            // 交点が一点に定まらないため, ここでは false を返す.
            // 完全に一点に加算っている場合は交点も一点に定まるが,
            // アルゴリズムの統一感を損なうため, そのために専用の
            // ロジックを用意することは許容しない.
            if (g == 0) {
                return false;
            }

            var ac = other.P1 - P1;

            // 最終的に h が [0, 1] の範囲に収まらなければならないので,
            // g の小数部を 15 ビットににしてしまい,
            // false を返す条件として g と比較するのではなく,
            // 除算後の値と比較することには妥当性がある.

            // |AC| |CD| sin(lm)   |AC| sin(lm)
            // ----------------- = ------------
            // |AB| |CD| sin(th)   |AB| sin(th)
            var h = ac.Determinant(cd).Bits / g;
            if (h < 0 || I17F15.OneRepr < h) {
                return false;
            }

            // i の判定を, 除算前の g の値との比較で行うこともできるが,
            // h の判定との対称性を損なうため, ここでは h と同様の
            // ロジックを用いる.

            // |AC| |AB| sin(ph)  |AC| sin(ph)
            // ----------------- = ------------
            // |AB| |CD| sin(th)  |CD| sin(th)
            var i = ac.Determinant(ab).Bits / g;
            if (i < 0 || I17F15.OneRepr < i) {
                return false;
            }

            // 0 <= t <= 1 かつ 0 <= u <= 1 の時, 線分は交差している.
            // 前提条件により t のキャストは必ず成功する.
            intersection = P1 + (I17F15.FromBits((int)h) * ab);
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
            // 交点を求めない場合, より高精度の判定を行う.
            // その場合, 事前にバウンディングボックスによる判定を
            // 行う必要がある. (理由は後述)
            if (!Envelope().Intersects(other.Envelope())) {
                return false;
            }

            // 線分 AB, 線分 CD について交点が存在するとき,
            // その交点を E とする.
            // AB と CD がなす角を th,
            // AC と AB がなす角を ph,
            // AC と CD がなす角を lm とすると sin(th) < 0 の時
            // 0 < |AC| sin(-ph) < |CD| sin(-th) かつ
            // 0 < |AC| sin(-lm) < |AB| sin(-th) といえる.
            // 上記の式を変形すると
            // |CD| sin(th) < |AC| sin(ph) < 0
            // |AB| sin(th) < |AC| sin(lm) < 0
            // |AB| |CD| sin(th) < |AC| |AB| sin(ph) < 0
            // |AB| |CD| sin(th) < |AC| |CD| sin(lm) < 0

            var ab = P2 - P1;
            var cd = other.P2 - other.P1;
            var ac = other.P1 - P1;

            // i の計算は最適化により早期リターンより後になることを期待している.

            var g = ab.Determinant(cd); // |AB| |CD| sin(th)
            var h = ac.Determinant(cd); // |AC| |CD| sin(lm)
            var i = ac.Determinant(ab); // |AC| |AB| sin(ph)

            // g = 0 の時, いずれか, または両方の線分の長さが
            // 0 であるか, 線分が平行である. この時, h = 0 かつ
            // i = 0 であればすべての端点が一点に重なるか,
            // 一直線上に並ぶことを意味する. この時,
            // バウンディングボックスによる事前判定によって 1 点に
            // 重なるか, 線分が重なることが保証される.

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

        /// <summary>Check if the segment intersects with a circle.</summary>
        /// <param name="circle">The circle to check.</param>
        /// <returns>True if the segment intersects with the circle, false otherwise.</returns>
        /// <remarks>
        /// <div class="WARNING alert alert-info">
        /// <h5>WARNING</h5>
        /// <para>This method causes an <b>overflow</b> in the following case:</para>
        /// <list type="bullet">
        /// <item><description>The segment is very long.</description></item>
        /// <item><description>The distance between the segment and the center of the circle is
        /// very large.</description></item>
        /// </list>
        /// </div>
        /// <div class="NOTE alert alert-info">
        /// <h5>NOTE</h5><para>The accuracy reduces when the segment is very short.</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(CircleI17F15 circle) {
            var closestPoint = ClosestPoint(circle.Center);
            var distanceSquared = (closestPoint - circle.Center).LengthSquared();
            return distanceSquared <= circle.Radius.BigMul(circle.Radius);
        }
        #endregion
        #region Overlaps
        /// <summary>Check if the segment overlaps with another segment.
        /// </summary>
        /// <param name="other">The segment to check.</param>
        /// <param name="intersection">The intersection point.</param>
        /// <returns>True if the segment overlaps with the other
        /// segment, false otherwise.
        /// </returns>
        /// <remarks>
        /// <div class="WARNING alert alert-info">
        /// <h5>WARNING</h5>
        /// <para>This method causes an <b>overflow</b> in the following
        /// case:</para>
        /// <list type="bullet">
        /// <item><description>The segment is very long.
        /// </description></item>
        /// <item><description>The other segment is very long.
        /// </description></item>
        /// <item><description>The distance between the segment and the
        /// other segment is very large.
        /// </description></item>
        /// </list>
        /// </div>
        /// <div class="NOTE alert alert-info">
        /// <h5>NOTE</h5>
        /// <para>This method may return <c>false</c> regardless of the
        /// position relationship between this segment and the other
        /// segment in the following cases:</para>
        /// <list type="bullet">
        /// <item><description>Both this segment and the other segment
        /// are very short.</description></item>
        /// <item><description>The angle between this segment and the
        /// other segment is very small.</description></item>
        /// </list>
        /// </div>
        /// <div class="TIP alert alert-info">
        /// <h5>TIP</h5>
        /// <para>The <paramref name="intersection"/> parameter is not
        /// updated if this method returns <c>false</c>.</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps(Segment2I17F15 other, ref Vector2I17F15 intersection) {
            var ab = P2 - P1;
            var cd = other.P2 - other.P1;
            var g = ab.Determinant(cd).Bits / I17F15.OneRepr;
            if (g == 0) {
                return false;
            }

            var ac = other.P1 - P1;

            var h = ac.Determinant(cd).Bits / g;
            if (h <= 0 || I17F15.OneRepr <= h) {
                return false;
            }

            var i = ac.Determinant(ab).Bits / g;
            if (i <= 0 || I17F15.OneRepr <= i) {
                return false;
            }

            intersection = P1 + (I17F15.FromBits((int)h) * ab);
            return true;
        }

        /// <summary>Check if the segment overlaps with another segment.
        /// </summary>
        /// <param name="other">The segment to check.</param>
        /// <returns>True if the segment overlaps with the other
        /// segment, false otherwise.</returns>
        /// <remarks>
        /// <div class="WARNING alert alert-info">
        /// <h5>WARNING</h5>
        /// <para>This method causes an <b>overflow</b> in the following
        /// case:</para>
        /// <list type="bullet">
        /// <item><description>The segment is very long.
        /// </description></item>
        /// <item><description>The other segment is very long.
        /// </description></item>
        /// <item><description>The distance between the segment and the
        /// other segment is very large.</description></item>
        /// </list>
        /// </div>
        /// <div class="NOTE alert alert-info">
        /// <h5>NOTE</h5>
        /// <para>This method may return <c>false</c> regardless of the
        /// position relationship between this segment and the other
        /// segment in the following cases:</para>
        /// <list type="bullet">
        /// <item><description>Both this segment and the other segment
        /// are very short.</description></item>
        /// <item><description>The angle between this segment and the
        /// other segment is very small.</description></item>
        /// </list>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps(Segment2I17F15 other) {
            var ab = P2 - P1;
            var cd = other.P2 - other.P1;
            var ac = other.P1 - P1;

            // i の計算は最適化により早期リターンより後になることを期待している.

            var g = ab.Determinant(cd); // |AB| |CD| sin(th)
            var h = ac.Determinant(cd); // |AC| |CD| sin(lm)
            var i = ac.Determinant(ab); // |AC| |AB| sin(ph)

            // Overlaps では g = 0 の場合, 後の分岐によって
            // 必ず false が返る. g = 0 となる確率は低いため,
            // ここでは早期リターンしない. Overlaps では
            // g = 0 の場合常に false が返るため,
            // すべての端点が一点に重なるか, 一直線上に並ぶ時に
            // 誤って true を返すことはない. このため,
            // バウンディングボックスによる事前判定を行わない.
            // パフォーマンス最適化のためのバウンディングボックスによる
            // 事前判定はユーザー責務となる.

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

        /// <summary>Check if the segment overlaps with a circle.
        /// </summary>
        /// <param name="circle">The circle to check.</param>
        /// <returns>True if the segment overlaps with the circle,
        /// false otherwise.</returns>
        /// <remarks>
        /// <div class="WARNING alert alert-info">
        /// <h5>WARNING</h5>
        /// <para>This method causes an <b>overflow</b> in the following
        /// case:</para>
        /// <list type="bullet">
        /// <item><description>The segment is very long.
        /// </description></item>
        /// <item><description>The distance between the segment and the
        /// center of the circle is very large.</description></item>
        /// </list>
        /// </div>
        /// <div class="NOTE alert alert-info">
        /// <h5>NOTE</h5><para>The accuracy reduces when the segment is
        /// very short.</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps(CircleI17F15 circle) {
            var closestPoint = ClosestPoint(circle.Center);
            var distanceSquared = (closestPoint - circle.Center).LengthSquared();
            return distanceSquared < circle.Radius.BigMul(circle.Radius);
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
