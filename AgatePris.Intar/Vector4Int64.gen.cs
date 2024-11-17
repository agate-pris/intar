using System;
using System.Runtime.CompilerServices;

namespace Intar1991 {
    public struct Vector4Int64 : IEquatable<Vector4Int64> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public long X;
        public long Y;
        public long Z;
        public long W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector4Int64(long x, long y, long z, long w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public long this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                switch (index) {
                    case 0: return X;
                    case 1: return Y;
                    case 2: return Z;
                    case 3: return W;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                switch (index) {
                    case 0: X = value; break;
                    case 1: Y = value; break;
                    case 2: Z = value; break;
                    case 3: W = value; break;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
        }

        #region IEqualityOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator ==(Vector4Int64 left, Vector4Int64 right) {
            return new Vector4Bool(left.X == right.X, left.Y == right.Y, left.Z == right.Z, left.W == right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(Vector4Int64 left, Vector4Int64 right) {
            return new Vector4Bool(left.X != right.X, left.Y != right.Y, left.Z != right.Z, left.W != right.W);
        }

        #endregion

        #region Dervied from INumberBase

        public Vector4Bool IsNegative() {
            return new Vector4Bool(X < 0, Y < 0, Z < 0, W < 0);
        }

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4Int64 other) {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is Vector4Int64 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        #endregion

        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator +(Vector4Int64 left, Vector4Int64 right) {
            return new Vector4Int64(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator -(Vector4Int64 left, Vector4Int64 right) {
            return new Vector4Int64(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator *(Vector4Int64 left, Vector4Int64 right) {
            return new Vector4Int64(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator /(Vector4Int64 left, Vector4Int64 right) {
            return new Vector4Int64(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator *(Vector4Int64 left, long right) {
            return new Vector4Int64(left.X * right, left.Y * right, left.Z * right, left.W * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator *(long left, Vector4Int64 right) {
            return new Vector4Int64(left * right.X, left * right.Y, left * right.Z, left * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator /(Vector4Int64 left, long right) {
            return new Vector4Int64(left.X / right, left.Y / right, left.Z / right, left.W / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator /(long left, Vector4Int64 right) {
            return new Vector4Int64(left / right.X, left / right.Y, left / right.Z, left / right.W);
        }

        #endregion

        #region IUnaryPlusOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator +(Vector4Int64 x) {
            return new Vector4Int64(+x.X, +x.Y, +x.Z, +x.W);
        }

        #endregion

        #region IUnarryNegationOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator -(Vector4Int64 x) {
            return new Vector4Int64(-x.X, -x.Y, -x.Z, -x.W);
        }

        #endregion

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4Int32(Vector4Int64 a) {
            return new Vector4Int32((int)a.X, (int)a.Y, (int)a.Z, (int)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt32(Vector4Int64 a) {
            return new Vector4UInt32((uint)a.X, (uint)a.Y, (uint)a.Z, (uint)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt64(Vector4Int64 a) {
            return new Vector4UInt64((ulong)a.X, (ulong)a.Y, (ulong)a.Z, (ulong)a.W);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector4Int128(Vector4Int64 a) {
            return new Vector4Int128((Int128)a.X, (Int128)a.Y, (Int128)a.Z, (Int128)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt128(Vector4Int64 a) {
            return new Vector4UInt128((UInt128)a.X, (UInt128)a.Y, (UInt128)a.Z, (UInt128)a.W);
        }

#endif // NET7_0_OR_GREATER

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        //
        // Other methods
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 Abs() => new Vector4Int64(Math.Abs(X), Math.Abs(Y), Math.Abs(Z), Math.Abs(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt64 UnsignedAbs() {
            return new Vector4UInt64(Mathi.UnsignedAbs(X), Mathi.UnsignedAbs(Y), Mathi.UnsignedAbs(Z), Mathi.UnsignedAbs(W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 Min(Vector4Int64 other) {
            return new Vector4Int64(Math.Min(X, other.X), Math.Min(Y, other.Y), Math.Min(Z, other.Z), Math.Min(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 Max(Vector4Int64 other) {
            return new Vector4Int64(Math.Max(X, other.X), Math.Max(Y, other.Y), Math.Max(Z, other.Z), Math.Max(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 Clamp(long min, long max) {
#if NET5_0_OR_GREATER
            return new Vector4Int64(Math.Clamp(X, min, max), Math.Clamp(Y, min, max), Math.Clamp(Z, min, max), Math.Clamp(W, min, max));
#else
            return new Vector4Int64(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max), Mathi.Clamp(Z, min, max), Mathi.Clamp(W, min, max));
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 Clamp(Vector4Int64 min, Vector4Int64 max) {
#if NET5_0_OR_GREATER
            return new Vector4Int64(Math.Clamp(X, min.X, max.X), Math.Clamp(Y, min.Y, max.Y), Math.Clamp(Z, min.Z, max.Z), Math.Clamp(W, min.W, max.W));
#else
            return new Vector4Int64(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y), Mathi.Clamp(Z, min.Z, max.Z), Mathi.Clamp(W, min.W, max.W));
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 Half() => new Vector4Int64(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z), Mathi.Half(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 Twice() => new Vector4Int64(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z), Mathi.Twice(W));

#if NET7_0_OR_GREATER

        public Vector4Int128 BigMul(long other) {
            return (Vector4Int128)this * other;
        }

        public Vector4Int128 BigMul(Vector4Int64 other) {
            return (Vector4Int128)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int128 UncheckedDot(Vector4Int64 other) {
            var mul = (Vector4Int128)this * other;
            return mul.X + mul.Y + mul.Z + mul.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt128 UncheckedLengthSquared() {
            var abs = UnsignedAbs();
            var sqr = abs.BigMul(abs);
            return sqr.X + sqr.Y + sqr.Z + sqr.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong UncheckedLength() => (ulong)Mathi.Sqrt(UncheckedLengthSquared());

#endif // NET7_0_OR_GREATER

        #region Overflowing

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 WrappingAdd(Vector4Int64 other) {
            return new Vector4Int64(Overflowing.WrappingAdd(X, other.X), Overflowing.WrappingAdd(Y, other.Y), Overflowing.WrappingAdd(Z, other.Z), Overflowing.WrappingAdd(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 WrappingSub(Vector4Int64 other) {
            return new Vector4Int64(Overflowing.WrappingSub(X, other.X), Overflowing.WrappingSub(Y, other.Y), Overflowing.WrappingSub(Z, other.Z), Overflowing.WrappingSub(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 WrappingNeg() {
            return new Vector4Int64(Overflowing.WrappingNeg(X), Overflowing.WrappingNeg(Y), Overflowing.WrappingNeg(Z), Overflowing.WrappingNeg(W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 WrappingAddUnsigned(Vector4UInt64 other) {
            return new Vector4Int64(Overflowing.WrappingAddUnsigned(X, other.X), Overflowing.WrappingAddUnsigned(Y, other.Y), Overflowing.WrappingAddUnsigned(Z, other.Z), Overflowing.WrappingAddUnsigned(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 WrappingSubUnsigned(Vector4UInt64 other) {
            return new Vector4Int64(Overflowing.WrappingSubUnsigned(X, other.X), Overflowing.WrappingSubUnsigned(Y, other.Y), Overflowing.WrappingSubUnsigned(Z, other.Z), Overflowing.WrappingSubUnsigned(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 WrappingAbs() {
            return new Vector4Int64(Overflowing.WrappingAbs(X), Overflowing.WrappingAbs(Y), Overflowing.WrappingAbs(Z), Overflowing.WrappingAbs(W));
        }

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 XX() => new Vector2Int64(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 XY() => new Vector2Int64(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 XZ() => new Vector2Int64(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 XW() => new Vector2Int64(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 YX() => new Vector2Int64(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 YY() => new Vector2Int64(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 YZ() => new Vector2Int64(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 YW() => new Vector2Int64(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 ZX() => new Vector2Int64(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 ZY() => new Vector2Int64(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 ZZ() => new Vector2Int64(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 ZW() => new Vector2Int64(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 WX() => new Vector2Int64(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 WY() => new Vector2Int64(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 WZ() => new Vector2Int64(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 WW() => new Vector2Int64(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XXX() => new Vector3Int64(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XXY() => new Vector3Int64(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XXZ() => new Vector3Int64(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XXW() => new Vector3Int64(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XYX() => new Vector3Int64(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XYY() => new Vector3Int64(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XYZ() => new Vector3Int64(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XYW() => new Vector3Int64(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XZX() => new Vector3Int64(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XZY() => new Vector3Int64(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XZZ() => new Vector3Int64(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XZW() => new Vector3Int64(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XWX() => new Vector3Int64(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XWY() => new Vector3Int64(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XWZ() => new Vector3Int64(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XWW() => new Vector3Int64(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YXX() => new Vector3Int64(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YXY() => new Vector3Int64(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YXZ() => new Vector3Int64(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YXW() => new Vector3Int64(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YYX() => new Vector3Int64(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YYY() => new Vector3Int64(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YYZ() => new Vector3Int64(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YYW() => new Vector3Int64(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YZX() => new Vector3Int64(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YZY() => new Vector3Int64(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YZZ() => new Vector3Int64(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YZW() => new Vector3Int64(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YWX() => new Vector3Int64(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YWY() => new Vector3Int64(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YWZ() => new Vector3Int64(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YWW() => new Vector3Int64(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZXX() => new Vector3Int64(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZXY() => new Vector3Int64(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZXZ() => new Vector3Int64(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZXW() => new Vector3Int64(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZYX() => new Vector3Int64(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZYY() => new Vector3Int64(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZYZ() => new Vector3Int64(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZYW() => new Vector3Int64(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZZX() => new Vector3Int64(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZZY() => new Vector3Int64(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZZZ() => new Vector3Int64(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZZW() => new Vector3Int64(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZWX() => new Vector3Int64(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZWY() => new Vector3Int64(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZWZ() => new Vector3Int64(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZWW() => new Vector3Int64(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 WXX() => new Vector3Int64(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 WXY() => new Vector3Int64(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 WXZ() => new Vector3Int64(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 WXW() => new Vector3Int64(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 WYX() => new Vector3Int64(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 WYY() => new Vector3Int64(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 WYZ() => new Vector3Int64(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 WYW() => new Vector3Int64(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 WZX() => new Vector3Int64(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 WZY() => new Vector3Int64(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 WZZ() => new Vector3Int64(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 WZW() => new Vector3Int64(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 WWX() => new Vector3Int64(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 WWY() => new Vector3Int64(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 WWZ() => new Vector3Int64(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 WWW() => new Vector3Int64(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXXX() => new Vector4Int64(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXXY() => new Vector4Int64(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXXZ() => new Vector4Int64(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXXW() => new Vector4Int64(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXYX() => new Vector4Int64(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXYY() => new Vector4Int64(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXYZ() => new Vector4Int64(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXYW() => new Vector4Int64(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXZX() => new Vector4Int64(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXZY() => new Vector4Int64(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXZZ() => new Vector4Int64(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXZW() => new Vector4Int64(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXWX() => new Vector4Int64(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXWY() => new Vector4Int64(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXWZ() => new Vector4Int64(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXWW() => new Vector4Int64(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYXX() => new Vector4Int64(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYXY() => new Vector4Int64(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYXZ() => new Vector4Int64(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYXW() => new Vector4Int64(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYYX() => new Vector4Int64(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYYY() => new Vector4Int64(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYYZ() => new Vector4Int64(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYYW() => new Vector4Int64(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYZX() => new Vector4Int64(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYZY() => new Vector4Int64(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYZZ() => new Vector4Int64(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYZW() => new Vector4Int64(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYWX() => new Vector4Int64(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYWY() => new Vector4Int64(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYWZ() => new Vector4Int64(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYWW() => new Vector4Int64(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZXX() => new Vector4Int64(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZXY() => new Vector4Int64(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZXZ() => new Vector4Int64(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZXW() => new Vector4Int64(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZYX() => new Vector4Int64(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZYY() => new Vector4Int64(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZYZ() => new Vector4Int64(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZYW() => new Vector4Int64(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZZX() => new Vector4Int64(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZZY() => new Vector4Int64(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZZZ() => new Vector4Int64(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZZW() => new Vector4Int64(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZWX() => new Vector4Int64(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZWY() => new Vector4Int64(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZWZ() => new Vector4Int64(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZWW() => new Vector4Int64(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XWXX() => new Vector4Int64(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XWXY() => new Vector4Int64(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XWXZ() => new Vector4Int64(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XWXW() => new Vector4Int64(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XWYX() => new Vector4Int64(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XWYY() => new Vector4Int64(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XWYZ() => new Vector4Int64(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XWYW() => new Vector4Int64(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XWZX() => new Vector4Int64(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XWZY() => new Vector4Int64(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XWZZ() => new Vector4Int64(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XWZW() => new Vector4Int64(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XWWX() => new Vector4Int64(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XWWY() => new Vector4Int64(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XWWZ() => new Vector4Int64(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XWWW() => new Vector4Int64(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXXX() => new Vector4Int64(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXXY() => new Vector4Int64(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXXZ() => new Vector4Int64(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXXW() => new Vector4Int64(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXYX() => new Vector4Int64(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXYY() => new Vector4Int64(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXYZ() => new Vector4Int64(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXYW() => new Vector4Int64(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXZX() => new Vector4Int64(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXZY() => new Vector4Int64(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXZZ() => new Vector4Int64(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXZW() => new Vector4Int64(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXWX() => new Vector4Int64(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXWY() => new Vector4Int64(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXWZ() => new Vector4Int64(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXWW() => new Vector4Int64(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYXX() => new Vector4Int64(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYXY() => new Vector4Int64(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYXZ() => new Vector4Int64(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYXW() => new Vector4Int64(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYYX() => new Vector4Int64(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYYY() => new Vector4Int64(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYYZ() => new Vector4Int64(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYYW() => new Vector4Int64(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYZX() => new Vector4Int64(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYZY() => new Vector4Int64(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYZZ() => new Vector4Int64(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYZW() => new Vector4Int64(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYWX() => new Vector4Int64(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYWY() => new Vector4Int64(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYWZ() => new Vector4Int64(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYWW() => new Vector4Int64(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZXX() => new Vector4Int64(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZXY() => new Vector4Int64(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZXZ() => new Vector4Int64(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZXW() => new Vector4Int64(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZYX() => new Vector4Int64(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZYY() => new Vector4Int64(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZYZ() => new Vector4Int64(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZYW() => new Vector4Int64(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZZX() => new Vector4Int64(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZZY() => new Vector4Int64(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZZZ() => new Vector4Int64(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZZW() => new Vector4Int64(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZWX() => new Vector4Int64(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZWY() => new Vector4Int64(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZWZ() => new Vector4Int64(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZWW() => new Vector4Int64(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YWXX() => new Vector4Int64(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YWXY() => new Vector4Int64(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YWXZ() => new Vector4Int64(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YWXW() => new Vector4Int64(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YWYX() => new Vector4Int64(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YWYY() => new Vector4Int64(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YWYZ() => new Vector4Int64(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YWYW() => new Vector4Int64(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YWZX() => new Vector4Int64(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YWZY() => new Vector4Int64(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YWZZ() => new Vector4Int64(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YWZW() => new Vector4Int64(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YWWX() => new Vector4Int64(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YWWY() => new Vector4Int64(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YWWZ() => new Vector4Int64(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YWWW() => new Vector4Int64(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXXX() => new Vector4Int64(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXXY() => new Vector4Int64(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXXZ() => new Vector4Int64(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXXW() => new Vector4Int64(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXYX() => new Vector4Int64(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXYY() => new Vector4Int64(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXYZ() => new Vector4Int64(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXYW() => new Vector4Int64(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXZX() => new Vector4Int64(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXZY() => new Vector4Int64(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXZZ() => new Vector4Int64(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXZW() => new Vector4Int64(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXWX() => new Vector4Int64(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXWY() => new Vector4Int64(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXWZ() => new Vector4Int64(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXWW() => new Vector4Int64(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYXX() => new Vector4Int64(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYXY() => new Vector4Int64(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYXZ() => new Vector4Int64(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYXW() => new Vector4Int64(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYYX() => new Vector4Int64(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYYY() => new Vector4Int64(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYYZ() => new Vector4Int64(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYYW() => new Vector4Int64(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYZX() => new Vector4Int64(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYZY() => new Vector4Int64(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYZZ() => new Vector4Int64(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYZW() => new Vector4Int64(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYWX() => new Vector4Int64(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYWY() => new Vector4Int64(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYWZ() => new Vector4Int64(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYWW() => new Vector4Int64(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZXX() => new Vector4Int64(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZXY() => new Vector4Int64(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZXZ() => new Vector4Int64(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZXW() => new Vector4Int64(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZYX() => new Vector4Int64(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZYY() => new Vector4Int64(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZYZ() => new Vector4Int64(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZYW() => new Vector4Int64(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZZX() => new Vector4Int64(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZZY() => new Vector4Int64(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZZZ() => new Vector4Int64(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZZW() => new Vector4Int64(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZWX() => new Vector4Int64(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZWY() => new Vector4Int64(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZWZ() => new Vector4Int64(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZWW() => new Vector4Int64(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZWXX() => new Vector4Int64(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZWXY() => new Vector4Int64(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZWXZ() => new Vector4Int64(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZWXW() => new Vector4Int64(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZWYX() => new Vector4Int64(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZWYY() => new Vector4Int64(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZWYZ() => new Vector4Int64(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZWYW() => new Vector4Int64(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZWZX() => new Vector4Int64(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZWZY() => new Vector4Int64(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZWZZ() => new Vector4Int64(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZWZW() => new Vector4Int64(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZWWX() => new Vector4Int64(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZWWY() => new Vector4Int64(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZWWZ() => new Vector4Int64(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZWWW() => new Vector4Int64(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WXXX() => new Vector4Int64(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WXXY() => new Vector4Int64(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WXXZ() => new Vector4Int64(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WXXW() => new Vector4Int64(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WXYX() => new Vector4Int64(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WXYY() => new Vector4Int64(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WXYZ() => new Vector4Int64(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WXYW() => new Vector4Int64(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WXZX() => new Vector4Int64(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WXZY() => new Vector4Int64(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WXZZ() => new Vector4Int64(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WXZW() => new Vector4Int64(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WXWX() => new Vector4Int64(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WXWY() => new Vector4Int64(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WXWZ() => new Vector4Int64(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WXWW() => new Vector4Int64(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WYXX() => new Vector4Int64(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WYXY() => new Vector4Int64(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WYXZ() => new Vector4Int64(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WYXW() => new Vector4Int64(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WYYX() => new Vector4Int64(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WYYY() => new Vector4Int64(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WYYZ() => new Vector4Int64(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WYYW() => new Vector4Int64(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WYZX() => new Vector4Int64(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WYZY() => new Vector4Int64(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WYZZ() => new Vector4Int64(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WYZW() => new Vector4Int64(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WYWX() => new Vector4Int64(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WYWY() => new Vector4Int64(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WYWZ() => new Vector4Int64(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WYWW() => new Vector4Int64(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WZXX() => new Vector4Int64(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WZXY() => new Vector4Int64(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WZXZ() => new Vector4Int64(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WZXW() => new Vector4Int64(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WZYX() => new Vector4Int64(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WZYY() => new Vector4Int64(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WZYZ() => new Vector4Int64(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WZYW() => new Vector4Int64(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WZZX() => new Vector4Int64(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WZZY() => new Vector4Int64(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WZZZ() => new Vector4Int64(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WZZW() => new Vector4Int64(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WZWX() => new Vector4Int64(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WZWY() => new Vector4Int64(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WZWZ() => new Vector4Int64(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WZWW() => new Vector4Int64(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WWXX() => new Vector4Int64(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WWXY() => new Vector4Int64(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WWXZ() => new Vector4Int64(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WWXW() => new Vector4Int64(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WWYX() => new Vector4Int64(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WWYY() => new Vector4Int64(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WWYZ() => new Vector4Int64(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WWYW() => new Vector4Int64(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WWZX() => new Vector4Int64(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WWZY() => new Vector4Int64(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WWZZ() => new Vector4Int64(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WWZW() => new Vector4Int64(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WWWX() => new Vector4Int64(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WWWY() => new Vector4Int64(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WWWZ() => new Vector4Int64(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 WWWW() => new Vector4Int64(W, W, W, W);

        #endregion

    }
} // namespace Intar1991
