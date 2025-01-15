using System;
using System.Runtime.CompilerServices;

#if UNITY_EDITOR

using UnityEngine;

#endif // UNITY_EDITOR

namespace Intar.Geometry {
    [Serializable]
    public struct Circle2I17F15 : IEquatable<Circle2I17F15>, IFormattable {

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector2I17F15 Center;
        public U17F15 Radius;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #region Construction
        public Circle2I17F15(Vector2I17F15 center, U17F15 radius) {
            Center = center;
            Radius = radius;
        }
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Circle2I17F15 other) {
            return Center.Equals(other.Center) && Radius.Equals(other.Radius);
        }
        #endregion
        #region IEqualityOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Circle2I17F15 left, Circle2I17F15 right) {
            return left.Center.X == right.Center.X && left.Center.Y == right.Center.Y && left.Radius == right.Radius;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Circle2I17F15 left, Circle2I17F15 right) {
            return left.Center.X != right.Center.X || left.Center.Y != right.Center.Y || left.Radius != right.Radius;
        }
        #endregion
        #region Object
        public override bool Equals(object obj) {
            return obj is Circle2I17F15 o && Equals(o);
        }

        public override int GetHashCode() => HashCode.Combine(
            Center, Radius
        );

        public override string ToString() {
            return $"{{Center:{Center} Radius:{Radius}}}";
        }
        #endregion
        #region IFormattable
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"{{Center:{Center.ToString(format, formatProvider)} Radius:{Radius.ToString(format, formatProvider)}}}";
        }
        #endregion
        #region IMultiplyOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Circle2I17F15 operator *(AffineTransform3I17F15 left, Circle2I17F15 right) {
            var sX = left.DecomposeScaleX();
            var sY = left.DecomposeScaleY();
            var center = new Vector3I17F15(right.Center.X, right.Center.Y, I17F15.Zero);
            return new Circle2I17F15(
                (left * center).XY(),
                right.Radius * sX.Max(sY)
            );
        }
        #endregion
        #region Disjoint, Intersects
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Disjoint(Vector2I17F15 other) {
            return Center.DistanceSquared(other) > Radius.BigMul(Radius);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(Vector2I17F15 other) => !Disjoint(other);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Disjoint(Circle2I17F15 other) {
            var r = Radius + other.Radius;
            return Center.DistanceSquared(other.Center) > r.BigMul(r);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(Circle2I17F15 other) => !Disjoint(other);
        #endregion

#if UNITY_EDITOR

        #region Draw
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
}
