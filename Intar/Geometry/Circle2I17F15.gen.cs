using System;
using System.Runtime.CompilerServices;

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
        public bool Disjoint(Circle2I17F15 other) {
            var r = Radius + other.Radius;
            return Center.DistanceSquared(other.Center) > r.BigMul(r);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(Circle2I17F15 other) => !Disjoint(other);
        #endregion
    }
}
