#if NET7_0_OR_GREATER

using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector2UInt128 : IEquatable<Vector2UInt128> {

        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public UInt128 X;
        public UInt128 Y;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion

        public static explicit operator System.Numerics.Vector2(Vector2UInt128 a) {
            return new System.Numerics.Vector2((float)a.X, (float)a.Y);
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector2(Vector2UInt128 a) {
            return new UnityEngine.Vector2((float)a.X, (float)a.Y);
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float2(Vector2UInt128 a) {
            return new Unity.Mathematics.float2((float)a.X, (float)a.Y);
        }
#endif

        public Vector2UInt128(UInt128 x, UInt128 y) {
            X = x;
            Y = y;
        }

        public UInt128 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                switch (index) {
                    case 0: return X;
                    case 1: return Y;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                switch (index) {
                    case 0: X = value; break;
                    case 1: Y = value; break;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
        }

        #region IComparisonOperators, IEqualityOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <(Vector2UInt128 left, Vector2UInt128 right) {
            return new Vector2Bool(left.X < right.X, left.Y < right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <(UInt128 left, Vector2UInt128 right) {
            return new Vector2Bool(left < right.X, left < right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <(Vector2UInt128 left, UInt128 right) {
            return new Vector2Bool(left.X < right, left.Y < right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >(Vector2UInt128 left, Vector2UInt128 right) {
            return new Vector2Bool(left.X > right.X, left.Y > right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >(UInt128 left, Vector2UInt128 right) {
            return new Vector2Bool(left > right.X, left > right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >(Vector2UInt128 left, UInt128 right) {
            return new Vector2Bool(left.X > right, left.Y > right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <=(Vector2UInt128 left, Vector2UInt128 right) {
            return new Vector2Bool(left.X <= right.X, left.Y <= right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <=(UInt128 left, Vector2UInt128 right) {
            return new Vector2Bool(left <= right.X, left <= right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <=(Vector2UInt128 left, UInt128 right) {
            return new Vector2Bool(left.X <= right, left.Y <= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >=(Vector2UInt128 left, Vector2UInt128 right) {
            return new Vector2Bool(left.X >= right.X, left.Y >= right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >=(UInt128 left, Vector2UInt128 right) {
            return new Vector2Bool(left >= right.X, left >= right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >=(Vector2UInt128 left, UInt128 right) {
            return new Vector2Bool(left.X >= right, left.Y >= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(Vector2UInt128 left, Vector2UInt128 right) {
            return new Vector2Bool(left.X == right.X, left.Y == right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(UInt128 left, Vector2UInt128 right) {
            return new Vector2Bool(left == right.X, left == right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(Vector2UInt128 left, UInt128 right) {
            return new Vector2Bool(left.X == right, left.Y == right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2UInt128 left, Vector2UInt128 right) {
            return new Vector2Bool(left.X != right.X, left.Y != right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(UInt128 left, Vector2UInt128 right) {
            return new Vector2Bool(left != right.X, left != right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2UInt128 left, UInt128 right) {
            return new Vector2Bool(left.X != right, left.Y != right);
        }

        #endregion

        #region IShiftOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt128 operator <<(Vector2UInt128 left, int right) {
            return new Vector2UInt128(left.X << right, left.Y << right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt128 operator >>(Vector2UInt128 left, int right) {
            return new Vector2UInt128(left.X >> right, left.Y >> right);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt128 operator >>>(Vector2UInt128 left, int right) {
            return new Vector2UInt128(left.X >>> right, left.Y >>> right);
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2UInt128 other) {
            return X == other.X && Y == other.Y;
        }

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is Vector2UInt128 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        #endregion

        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt128 operator +(Vector2UInt128 left, Vector2UInt128 right) {
            return new Vector2UInt128(left.X + right.X, left.Y + right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt128 operator +(Vector2UInt128 left, UInt128 right) {
            return new Vector2UInt128(left.X + right, left.Y + right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt128 operator +(UInt128 left, Vector2UInt128 right) {
            return new Vector2UInt128(left + right.X, left + right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt128 operator -(Vector2UInt128 left, Vector2UInt128 right) {
            return new Vector2UInt128(left.X - right.X, left.Y - right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt128 operator -(Vector2UInt128 left, UInt128 right) {
            return new Vector2UInt128(left.X - right, left.Y - right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt128 operator -(UInt128 left, Vector2UInt128 right) {
            return new Vector2UInt128(left - right.X, left - right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt128 operator *(Vector2UInt128 left, Vector2UInt128 right) {
            return new Vector2UInt128(left.X * right.X, left.Y * right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt128 operator *(Vector2UInt128 left, UInt128 right) {
            return new Vector2UInt128(left.X * right, left.Y * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt128 operator *(UInt128 left, Vector2UInt128 right) {
            return new Vector2UInt128(left * right.X, left * right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt128 operator /(Vector2UInt128 left, Vector2UInt128 right) {
            return new Vector2UInt128(left.X / right.X, left.Y / right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt128 operator /(Vector2UInt128 left, UInt128 right) {
            return new Vector2UInt128(left.X / right, left.Y / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt128 operator /(UInt128 left, Vector2UInt128 right) {
            return new Vector2UInt128(left / right.X, left / right.Y);
        }

        #endregion

        #region IUnaryPlusOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt128 operator +(Vector2UInt128 x) {
            return new Vector2UInt128(+x.X, +x.Y);
        }

        #endregion

        #region Conversion Operators

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2Int32(Vector2UInt128 a) {
            return new Vector2Int32((int)a.X, (int)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2UInt32(Vector2UInt128 a) {
            return new Vector2UInt32((uint)a.X, (uint)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2Int64(Vector2UInt128 a) {
            return new Vector2Int64((long)a.X, (long)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2UInt64(Vector2UInt128 a) {
            return new Vector2UInt64((ulong)a.X, (ulong)a.Y);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2Int128(Vector2UInt128 a) {
            return new Vector2Int128((Int128)a.X, (Int128)a.Y);
        }

#endif // NET7_0_OR_GREATER

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        #endregion

        #region IsNegative, Abs, UnsignedAbs, IsNegativeAndUnsignedAbs

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Bool IsNegative() {
            return new Vector2Bool(X < 0, Y < 0);
        }

        // 符号なしベクトル型に対しては Abs, UnsignedAbs は定義しない.

        #endregion

        #region Min, Max, MaxComponent, Clamp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt128 Min(Vector2UInt128 other) {
            return new Vector2UInt128(UInt128.Min(X, other.X), UInt128.Min(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt128 Max(Vector2UInt128 other) {
            return new Vector2UInt128(UInt128.Max(X, other.X), UInt128.Max(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal UInt128 MaxComponent() {
            return UInt128.Max(X, Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt128 Clamp(UInt128 min, UInt128 max) {
            return new Vector2UInt128(UInt128.Clamp(X, min, max), UInt128.Clamp(Y, min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt128 Clamp(Vector2UInt128 min, Vector2UInt128 max) {
            return new Vector2UInt128(UInt128.Clamp(X, min.X, max.X), UInt128.Clamp(Y, min.Y, max.Y));
        }

        #endregion

        #region Half, Twice, ComponentsSum

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt128 Half() => new Vector2UInt128(Mathi.Half(X), Mathi.Half(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt128 Twice() => new Vector2UInt128(Mathi.Twice(X), Mathi.Twice(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal UInt128 ComponentsSum() => X + Y;

        #endregion

        #region Overflowing

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt128 WrappingAdd(Vector2UInt128 other) {
            return new Vector2UInt128(Overflowing.WrappingAdd(X, other.X), Overflowing.WrappingAdd(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt128 WrappingSub(Vector2UInt128 other) {
            return new Vector2UInt128(Overflowing.WrappingSub(X, other.X), Overflowing.WrappingSub(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt128 WrappingNeg() {
            return new Vector2UInt128(Overflowing.WrappingNeg(X), Overflowing.WrappingNeg(Y));
        }

        // Rust に倣って WrappingAddSigned のみを定義し
        // WrappingSubSigned は定義しない.
        // https://doc.rust-lang.org/std/primitive.u32.html#method.wrapping_add_signed

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt128 WrappingAddSigned(Vector2Int128 other) {
            return new Vector2UInt128(Overflowing.WrappingAddSigned(X, other.X), Overflowing.WrappingAddSigned(Y, other.Y));
        }

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 XX() => new Vector2UInt128(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 XY() => new Vector2UInt128(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 YX() => new Vector2UInt128(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt128 YY() => new Vector2UInt128(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XXX() => new Vector3UInt128(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XXY() => new Vector3UInt128(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XYX() => new Vector3UInt128(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 XYY() => new Vector3UInt128(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YXX() => new Vector3UInt128(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YXY() => new Vector3UInt128(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YYX() => new Vector3UInt128(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt128 YYY() => new Vector3UInt128(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXXX() => new Vector4UInt128(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXXY() => new Vector4UInt128(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXYX() => new Vector4UInt128(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XXYY() => new Vector4UInt128(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYXX() => new Vector4UInt128(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYXY() => new Vector4UInt128(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYYX() => new Vector4UInt128(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 XYYY() => new Vector4UInt128(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXXX() => new Vector4UInt128(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXXY() => new Vector4UInt128(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXYX() => new Vector4UInt128(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YXYY() => new Vector4UInt128(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYXX() => new Vector4UInt128(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYXY() => new Vector4UInt128(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYYX() => new Vector4UInt128(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt128 YYYY() => new Vector4UInt128(Y, Y, Y, Y);

        #endregion

    }
} // namespace Intar

#endif // NET7_0_OR_GREATER
