#if NET7_0_OR_GREATER

using System;
using System.Runtime.CompilerServices;

namespace Intar1991 {
    public struct Vector2Int128 : IEquatable<Vector2Int128> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Int128 X;
        public Int128 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector2Int128(Int128 x, Int128 y) {
            X = x;
            Y = y;
        }

        public Int128 this[int index] {
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
        public static Vector2Bool operator ==(Vector2Int128 left, Vector2Int128 right) {
            return new Vector2Bool(left.X == right.X, left.Y == right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2Int128 left, Vector2Int128 right) {
            return new Vector2Bool(left.X != right.X, left.Y != right.Y);
        }

        #endregion

        #region Dervied from INumberBase

        public Vector2Bool IsNegative() {
            return new Vector2Bool(X < 0, Y < 0);
        }

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2Int128 other) {
            return X == other.X && Y == other.Y;
        }

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is Vector2Int128 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        #endregion

        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int128 operator +(Vector2Int128 left, Vector2Int128 right) {
            return new Vector2Int128(left.X + right.X, left.Y + right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int128 operator -(Vector2Int128 left, Vector2Int128 right) {
            return new Vector2Int128(left.X - right.X, left.Y - right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int128 operator *(Vector2Int128 left, Vector2Int128 right) {
            return new Vector2Int128(left.X * right.X, left.Y * right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int128 operator /(Vector2Int128 left, Vector2Int128 right) {
            return new Vector2Int128(left.X / right.X, left.Y / right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int128 operator *(Vector2Int128 left, Int128 right) {
            return new Vector2Int128(left.X * right, left.Y * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int128 operator *(Int128 left, Vector2Int128 right) {
            return new Vector2Int128(left * right.X, left * right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int128 operator /(Vector2Int128 left, Int128 right) {
            return new Vector2Int128(left.X / right, left.Y / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int128 operator /(Int128 left, Vector2Int128 right) {
            return new Vector2Int128(left / right.X, left / right.Y);
        }

        #endregion

        #region IUnaryPlusOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int128 operator +(Vector2Int128 x) {
            return new Vector2Int128(+x.X, +x.Y);
        }

        #endregion

        #region IUnarryNegationOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int128 operator -(Vector2Int128 x) {
            return new Vector2Int128(-x.X, -x.Y);
        }

        #endregion

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2Int32(Vector2Int128 a) {
            return new Vector2Int32((int)a.X, (int)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2UInt32(Vector2Int128 a) {
            return new Vector2UInt32((uint)a.X, (uint)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2Int64(Vector2Int128 a) {
            return new Vector2Int64((long)a.X, (long)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2UInt64(Vector2Int128 a) {
            return new Vector2UInt64((ulong)a.X, (ulong)a.Y);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2UInt128(Vector2Int128 a) {
            return new Vector2UInt128((UInt128)a.X, (UInt128)a.Y);
        }

#endif // NET7_0_OR_GREATER

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        //
        // Other methods
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int128 Abs() => new Vector2Int128(Int128.Abs(X), Int128.Abs(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt128 UnsignedAbs() {
            return new Vector2UInt128(Mathi.UnsignedAbs(X), Mathi.UnsignedAbs(Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int128 Min(Vector2Int128 other) {
            return new Vector2Int128(Int128.Min(X, other.X), Int128.Min(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int128 Max(Vector2Int128 other) {
            return new Vector2Int128(Int128.Max(X, other.X), Int128.Max(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int128 Clamp(Int128 min, Int128 max) {
            return new Vector2Int128(Int128.Clamp(X, min, max), Int128.Clamp(Y, min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int128 Clamp(Vector2Int128 min, Vector2Int128 max) {
            return new Vector2Int128(Int128.Clamp(X, min.X, max.X), Int128.Clamp(Y, min.Y, max.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int128 Half() => new Vector2Int128(Mathi.Half(X), Mathi.Half(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int128 Twice() => new Vector2Int128(Mathi.Twice(X), Mathi.Twice(Y));

        #region Overflowing

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int128 WrappingAdd(Vector2Int128 other) {
            return new Vector2Int128(Overflowing.WrappingAdd(X, other.X), Overflowing.WrappingAdd(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int128 WrappingSub(Vector2Int128 other) {
            return new Vector2Int128(Overflowing.WrappingSub(X, other.X), Overflowing.WrappingSub(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int128 WrappingNeg() {
            return new Vector2Int128(Overflowing.WrappingNeg(X), Overflowing.WrappingNeg(Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int128 WrappingAddUnsigned(Vector2UInt128 other) {
            return new Vector2Int128(Overflowing.WrappingAddUnsigned(X, other.X), Overflowing.WrappingAddUnsigned(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int128 WrappingSubUnsigned(Vector2UInt128 other) {
            return new Vector2Int128(Overflowing.WrappingSubUnsigned(X, other.X), Overflowing.WrappingSubUnsigned(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int128 WrappingAbs() {
            return new Vector2Int128(Overflowing.WrappingAbs(X), Overflowing.WrappingAbs(Y));
        }

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 XX() => new Vector2Int128(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 XY() => new Vector2Int128(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 YX() => new Vector2Int128(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int128 YY() => new Vector2Int128(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XXX() => new Vector3Int128(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XXY() => new Vector3Int128(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XYX() => new Vector3Int128(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 XYY() => new Vector3Int128(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YXX() => new Vector3Int128(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YXY() => new Vector3Int128(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YYX() => new Vector3Int128(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int128 YYY() => new Vector3Int128(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXXX() => new Vector4Int128(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXXY() => new Vector4Int128(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXYX() => new Vector4Int128(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XXYY() => new Vector4Int128(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYXX() => new Vector4Int128(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYXY() => new Vector4Int128(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYYX() => new Vector4Int128(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 XYYY() => new Vector4Int128(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXXX() => new Vector4Int128(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXXY() => new Vector4Int128(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXYX() => new Vector4Int128(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YXYY() => new Vector4Int128(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYXX() => new Vector4Int128(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYXY() => new Vector4Int128(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYYX() => new Vector4Int128(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int128 YYYY() => new Vector4Int128(Y, Y, Y, Y);

        #endregion

    }
} // namespace Intar1991

#endif // NET7_0_OR_GREATER
