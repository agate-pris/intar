{%- import "macros.cs" as macros %}
{%- set int_nbits  = 17 %}
{%- set frac_nbits = 15 %}
{%- set nbits = int_nbits+frac_nbits %}
{%- set bits = macros::inttype(signed=true, bits=nbits) %}
{%- set component   = macros::fixed_type(s=true,  i=int_nbits, f=frac_nbits) %}
{%- set dim = 2 %}
{%- set components = ['X', 'Y', 'Z', 'W']|slice(end=dim) %}
{%- set vector_type = macros::vector_type(dim=dim, type=component) %}
{%- if dim == 2 %}
{%- set circle_type = 'Circle' ~ component %}{% elif dim == 3 %}
{%- set circle_type = 'Sphere' ~ component %}{% else %}
{{- throw(message='not implemented') }}
{%- endif %}
{%- set aabb_type = 'Aabb' ~ dim ~ component %}
{%- set type = 'Segment' ~ dim ~ component -%}
using System;
using System.Runtime.CompilerServices;

#if UNITY_5_3_OR_NEWER
using UnityEngine;
#endif

namespace {{ namespace }}.Geometry {
    [Serializable]
    public struct {{ type }} : IEquatable<{{ type }}>, IFormattable {
        #region P1, P2

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public {{ vector_type }} P1;
        public {{ vector_type }} P2;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type }}({{
            vector_type }} p1, {{
            vector_type }} p2) {
            P1 = p1;
            P2 = p2;
        }
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ type }} other) {
            return P1.Equals(other.P1) && P2.Equals(other.P2);
        }
        #endregion
        #region IEqualityOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==({{ type }} left, {{ type }} right) {
            return left.Equals(right);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=({{ type }} left, {{ type }} right) {
            return !left.Equals(right);
        }
        #endregion
        #region Object
        public override bool Equals(object obj) {
            return obj is {{ type }} o && Equals(o);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(P1, P2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() {
            return $"{{ '{{' }}P1:{P1} P2:{P2}{{ '}}' }}";
        }
        #endregion
        #region IFormattable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"{{ '{{' }}P1:{P1.ToString(format, formatProvider)} P2:{P2.ToString(format, formatProvider)}{{ '}}' }}";
        }
        #endregion
        #region IMultiplyOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} operator *(AffineTransform{{ dim }}{{ component }} left, {{ type }} right) {
            return new {{ type }}(left * right.P1, left * right.P2);
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
        public {{ aabb_type }} Envelope() {
            return new {{ aabb_type }}(this);
        }
        #endregion
        {%- if dim == 2 %}
        #region ClosestPoint
        /// <summary>
        /// 線分上で最も点 p に近い点を求める。
        /// 線分が極端に短い場合 P1 を返す。
        /// 線分が極端に長い場合、または点 p が極端に遠い場合、
        /// オーバーフローを引き起こす。
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ vector_type }} ClosestPoint({{ vector_type }} p) {
            var v = P2 - P1;

            // あとで除算するので小数部のビット数を {{ frac_nbits }} にする.
            // 線分が極端に長い場合 v ･ v はオーバーフローする.
            var vv = v.Dot(v).Bits / {{ component }}.OneRepr;
            if (vv == 0) {
                return P1;
            }

            // 点 p が極端に遠い場合 u ･ v はオーバーフローする.

            var u = p - P1;
            var uv = u.Dot(v).Bits;

            // ドット積の小数部のビット数は {{ 2*frac_nbits }} になるので,
            // これを vv で割ると, その小数部のビット数は {{ frac_nbits }} になる.

#if NET5_0_OR_GREATER

            var tBits = Math.Clamp(uv / vv, 0, {{ component }}.OneRepr);

#else

            var tBits = Mathi.Clamp(uv / vv, 0, {{ component }}.OneRepr);

#endif

            var t = {{ component }}.FromBits(({{ bits }})tBits);
            return P1 + (v * t);
        }
        #endregion
        #region Intersects

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
        public bool Intersects({{ type }} other, ref {{ vector_type }} intersection) {
            var r = P2 - P1;
            var s = other.P2 - other.P1;

            // ベクトル r とベクトル s からなる行列 A について,
            // r と s がなす角を th とすると,
            // det(A) = r x s = |r| |s| sin(th) となる.
            // r と s の成分が極端に大きい場合, オーバーフローを引き起こすため注意する.
            // ここではオーバーフローが発生する可能性を低減するため,
            // 小数部が {{ frac_nbits }} ビットになるように内部表現の除算のみを行う.

            var rxs = r.Determinant(s).Bits / {{ component }}.OneRepr;

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
            if (t < 0 || {{ component }}.OneRepr < t) {
                return false;
            }

            // ベクトル v とベクトル r からなる行列 C について,
            // det(C) / det(A) より直線 r と直線 s の交点の
            // 直線 s に対する位置 u が求まる.
            // 本来は v の逆ベクトルを使うべきだが,
            // 除数も sxr ではなく rxs であるため問題ない.
            // (rxs = -sxr)
            var u = v.Determinant(r).Bits / rxs;
            if (u < 0 || {{ component }}.OneRepr < u) {
                return false;
            }

            // 0 <= t <= 1 かつ 0 <= u <= 1 の場合,
            // 線分は交差している.
            // 前提条件により t のキャストは必ず成功する.
            intersection = P1 + ({{ component }}.FromBits(({{ bits }})t) * r);
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
        public bool Intersects({{ type }} other) {
            var r = P2 - P1;
            var s = other.P2 - other.P1;

            var rxs = r.Determinant(s).Bits / {{ component }}.OneRepr;

            if (rxs == 0) {
                return false;
            }

            var v = other.P1 - P1;

            var t = v.Determinant(s).Bits / rxs;
            var u = v.Determinant(r).Bits / rxs;
            return 0 <= t && t <= {{ component }}.OneRepr &&
                   0 <= u && u <= {{ component }}.OneRepr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects({{ circle_type }} circle) {
            var closestPoint = ClosestPoint(circle.Center);
            var distanceSquared = (closestPoint - circle.Center).LengthSquared();
            return distanceSquared <= circle.Radius.BigMul(circle.Radius);
        }
        #endregion
        {%- endif %}

#if UNITY_EDITOR

        #region Draw
        public void Draw({% if dim == 2 %}float z{% endif %}) {
            var p1 = new Vector3((float)P1.X, (float)P1.Y, {% if dim == 2 %}z{% else %}(float)P1.z{% endif %});
            var p2 = new Vector3((float)P2.X, (float)P2.Y, {% if dim == 2 %}z{% else %}(float)P2.z{% endif %});
            Gizmos.DrawLine(p1, p2);
        }
        {%- if dim == 2 %}
        public void Draw(AffineTransform2{{ component }} transform, float z) {
            (transform * this).Draw(z);
        }
        {%- endif %}
        public void Draw(AffineTransform3{{ component }} transform) {
            (transform * this).Draw({% if dim == 2 %}(float)transform.Translation.Z{% endif %});
        }
        public void Draw(Matrix4x4 matrix) {
            Draw((AffineTransform3{{ component }})matrix);
        }
        public void Draw(Transform transform) {
            Draw(transform.localToWorldMatrix);
        }
        #endregion

#endif // UNITY_EDITOR

    }
} // namespace {{ namespace }}.Geometry
