using System;
using System.Runtime.CompilerServices;

namespace Intar1991 {
    public struct Vector2UInt64 : IEquatable<Vector2UInt64> {

        #region Fields

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public ulong X;
        public ulong Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        #endregion

        public Vector2UInt64(ulong x, ulong y) {
            X = x;
            Y = y;
        }

        public ulong this[int index] {
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

        #region IEqualityOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(Vector2UInt64 left, Vector2UInt64 right) {
            return new Vector2Bool(left.X == right.X, left.Y == right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2UInt64 left, Vector2UInt64 right) {
            return new Vector2Bool(left.X != right.X, left.Y != right.Y);
        }

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2UInt64 other) {
            return X == other.X && Y == other.Y;
        }

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is Vector2UInt64 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        #endregion

        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator +(Vector2UInt64 left, Vector2UInt64 right) {
            return new Vector2UInt64(left.X + right.X, left.Y + right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator +(Vector2UInt64 left, ulong right) {
            return new Vector2UInt64(left.X + right, left.Y + right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator +(ulong left, Vector2UInt64 right) {
            return new Vector2UInt64(left + right.X, left + right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator -(Vector2UInt64 left, Vector2UInt64 right) {
            return new Vector2UInt64(left.X - right.X, left.Y - right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator -(Vector2UInt64 left, ulong right) {
            return new Vector2UInt64(left.X - right, left.Y - right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator -(ulong left, Vector2UInt64 right) {
            return new Vector2UInt64(left - right.X, left - right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator *(Vector2UInt64 left, Vector2UInt64 right) {
            return new Vector2UInt64(left.X * right.X, left.Y * right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator *(Vector2UInt64 left, ulong right) {
            return new Vector2UInt64(left.X * right, left.Y * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator *(ulong left, Vector2UInt64 right) {
            return new Vector2UInt64(left * right.X, left * right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator /(Vector2UInt64 left, Vector2UInt64 right) {
            return new Vector2UInt64(left.X / right.X, left.Y / right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator /(Vector2UInt64 left, ulong right) {
            return new Vector2UInt64(left.X / right, left.Y / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator /(ulong left, Vector2UInt64 right) {
            return new Vector2UInt64(left / right.X, left / right.Y);
        }

        #endregion

        #region IUnaryPlusOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator +(Vector2UInt64 x) {
            return new Vector2UInt64(+x.X, +x.Y);
        }

        #endregion

        #region Conversion Operators

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2Int32(Vector2UInt64 a) {
            return new Vector2Int32((int)a.X, (int)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2UInt32(Vector2UInt64 a) {
            return new Vector2UInt32((uint)a.X, (uint)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2Int64(Vector2UInt64 a) {
            return new Vector2Int64((long)a.X, (long)a.Y);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector2Int128(Vector2UInt64 a) {
            return new Vector2Int128((Int128)a.X, (Int128)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector2UInt128(Vector2UInt64 a) {
            return new Vector2UInt128((UInt128)a.X, (UInt128)a.Y);
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
        public Vector2UInt64 Min(Vector2UInt64 other) {
            return new Vector2UInt64(Math.Min(X, other.X), Math.Min(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 Max(Vector2UInt64 other) {
            return new Vector2UInt64(Math.Max(X, other.X), Math.Max(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal ulong MaxComponent() {
            return Math.Max(X, Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 Clamp(ulong min, ulong max) {
#if NET5_0_OR_GREATER
            return new Vector2UInt64(Math.Clamp(X, min, max), Math.Clamp(Y, min, max));
#else
            return new Vector2UInt64(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max));
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 Clamp(Vector2UInt64 min, Vector2UInt64 max) {
#if NET5_0_OR_GREATER
            return new Vector2UInt64(Math.Clamp(X, min.X, max.X), Math.Clamp(Y, min.Y, max.Y));
#else
            return new Vector2UInt64(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y));
#endif
        }

        #endregion

        #region Half, Twice, UncheckedComponentsSum

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 Half() => new Vector2UInt64(Mathi.Half(X), Mathi.Half(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 Twice() => new Vector2UInt64(Mathi.Twice(X), Mathi.Twice(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal ulong UncheckedComponentsSum() => X + Y;

        #endregion

        #region BigMul, Cross, UncheckedDot, (Unchecked)LengthSquared, (Unchecked)Length, HalfLength

#if NET7_0_OR_GREATER

        public Vector2UInt128 BigMul(ulong other) {
            return (Vector2UInt128)this * other;
        }

        public Vector2UInt128 BigMul(Vector2UInt64 other) {
            return (Vector2UInt128)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt128 UncheckedDot(Vector2UInt64 other) {
            return BigMul(other).UncheckedComponentsSum();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt128 UncheckedLengthSquared() {
            var sqr = BigMul(this);
            return sqr.UncheckedComponentsSum();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong UncheckedLength() => (ulong)Mathi.Sqrt(UncheckedLengthSquared());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal ulong HalfLength() {
            var sqr = BigMul(this);
            return (ulong)Mathi.Sqrt((sqr / 4).UncheckedComponentsSum());
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region Overflowing

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 WrappingAdd(Vector2UInt64 other) {
            return new Vector2UInt64(Overflowing.WrappingAdd(X, other.X), Overflowing.WrappingAdd(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 WrappingSub(Vector2UInt64 other) {
            return new Vector2UInt64(Overflowing.WrappingSub(X, other.X), Overflowing.WrappingSub(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 WrappingNeg() {
            return new Vector2UInt64(Overflowing.WrappingNeg(X), Overflowing.WrappingNeg(Y));
        }

        // Rust に倣って WrappingAddSigned のみを定義し
        // WrappingSubSigned は定義しない.
        // https://doc.rust-lang.org/std/primitive.u32.html#method.wrapping_add_signed

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 WrappingAddSigned(Vector2Int64 other) {
            return new Vector2UInt64(Overflowing.WrappingAddSigned(X, other.X), Overflowing.WrappingAddSigned(Y, other.Y));
        }

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 XX() => new Vector2UInt64(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 XY() => new Vector2UInt64(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 YX() => new Vector2UInt64(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 YY() => new Vector2UInt64(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XXX() => new Vector3UInt64(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XXY() => new Vector3UInt64(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XYX() => new Vector3UInt64(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XYY() => new Vector3UInt64(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YXX() => new Vector3UInt64(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YXY() => new Vector3UInt64(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YYX() => new Vector3UInt64(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YYY() => new Vector3UInt64(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXXX() => new Vector4UInt64(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXXY() => new Vector4UInt64(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXYX() => new Vector4UInt64(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXYY() => new Vector4UInt64(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYXX() => new Vector4UInt64(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYXY() => new Vector4UInt64(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYYX() => new Vector4UInt64(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYYY() => new Vector4UInt64(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXXX() => new Vector4UInt64(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXXY() => new Vector4UInt64(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXYX() => new Vector4UInt64(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXYY() => new Vector4UInt64(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYXX() => new Vector4UInt64(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYXY() => new Vector4UInt64(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYYX() => new Vector4UInt64(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYYY() => new Vector4UInt64(Y, Y, Y, Y);

        #endregion

    }
} // namespace Intar1991
