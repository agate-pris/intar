using System;
using System.Runtime.CompilerServices;

namespace Intar1991 {
    public struct Vector3UInt32 : IEquatable<Vector3UInt32> {

        #region Fields

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public uint X;
        public uint Y;
        public uint Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        #endregion

        public Vector3UInt32(uint x, uint y, uint z) {
            X = x;
            Y = y;
            Z = z;
        }

        public uint this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                switch (index) {
                    case 0: return X;
                    case 1: return Y;
                    case 2: return Z;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                switch (index) {
                    case 0: X = value; break;
                    case 1: Y = value; break;
                    case 2: Z = value; break;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
        }

        #region IEqualityOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3UInt32 left, Vector3UInt32 right) {
            return new Vector3Bool(left.X == right.X, left.Y == right.Y, left.Z == right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3UInt32 left, Vector3UInt32 right) {
            return new Vector3Bool(left.X != right.X, left.Y != right.Y, left.Z != right.Z);
        }

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3UInt32 other) {
            return X == other.X && Y == other.Y && Z == other.Z;
        }

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is Vector3UInt32 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        #endregion

        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator +(Vector3UInt32 left, Vector3UInt32 right) {
            return new Vector3UInt32(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator -(Vector3UInt32 left, Vector3UInt32 right) {
            return new Vector3UInt32(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator *(Vector3UInt32 left, Vector3UInt32 right) {
            return new Vector3UInt32(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator /(Vector3UInt32 left, Vector3UInt32 right) {
            return new Vector3UInt32(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator *(Vector3UInt32 left, uint right) {
            return new Vector3UInt32(left.X * right, left.Y * right, left.Z * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator *(uint left, Vector3UInt32 right) {
            return new Vector3UInt32(left * right.X, left * right.Y, left * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator /(Vector3UInt32 left, uint right) {
            return new Vector3UInt32(left.X / right, left.Y / right, left.Z / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator /(uint left, Vector3UInt32 right) {
            return new Vector3UInt32(left / right.X, left / right.Y, left / right.Z);
        }

        #endregion

        #region IUnaryPlusOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator +(Vector3UInt32 x) {
            return new Vector3UInt32(+x.X, +x.Y, +x.Z);
        }

        #endregion

        #region Conversion Operators

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3Int32(Vector3UInt32 a) {
            return new Vector3Int32((int)a.X, (int)a.Y, (int)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector3Int64(Vector3UInt32 a) {
            return new Vector3Int64((long)a.X, (long)a.Y, (long)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector3UInt64(Vector3UInt32 a) {
            return new Vector3UInt64((ulong)a.X, (ulong)a.Y, (ulong)a.Z);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector3Int128(Vector3UInt32 a) {
            return new Vector3Int128((Int128)a.X, (Int128)a.Y, (Int128)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector3UInt128(Vector3UInt32 a) {
            return new Vector3UInt128((UInt128)a.X, (UInt128)a.Y, (UInt128)a.Z);
        }

#endif // NET7_0_OR_GREATER

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        #endregion

        #region IsNegative, Abs, UnsignedAbs

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Bool IsNegative() {
            return new Vector3Bool(X < 0, Y < 0, Z < 0);
        }

        // 符号なしベクトル型に対しては Abs, UnsignedAbs は定義しない.

        #endregion

        #region Min, Max, Clamp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt32 Min(Vector3UInt32 other) {
            return new Vector3UInt32(Math.Min(X, other.X), Math.Min(Y, other.Y), Math.Min(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt32 Max(Vector3UInt32 other) {
            return new Vector3UInt32(Math.Max(X, other.X), Math.Max(Y, other.Y), Math.Max(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt32 Clamp(uint min, uint max) {
#if NET5_0_OR_GREATER
            return new Vector3UInt32(Math.Clamp(X, min, max), Math.Clamp(Y, min, max), Math.Clamp(Z, min, max));
#else
            return new Vector3UInt32(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max), Mathi.Clamp(Z, min, max));
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt32 Clamp(Vector3UInt32 min, Vector3UInt32 max) {
#if NET5_0_OR_GREATER
            return new Vector3UInt32(Math.Clamp(X, min.X, max.X), Math.Clamp(Y, min.Y, max.Y), Math.Clamp(Z, min.Z, max.Z));
#else
            return new Vector3UInt32(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y), Mathi.Clamp(Z, min.Z, max.Z));
#endif
        }

        #endregion

        #region Half and Twice

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt32 Half() => new Vector3UInt32(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt32 Twice() => new Vector3UInt32(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z));

        #endregion

        #region BigMul, Cross, UncheckedDot, (Unchecked)LengthSquared, (Unchecked)Length

        public Vector3UInt64 BigMul(uint other) {
            return (Vector3UInt64)this * other;
        }

        public Vector3UInt64 BigMul(Vector3UInt32 other) {
            return (Vector3UInt64)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong UncheckedDot(Vector3UInt32 other) {
            var mul = (Vector3UInt64)this * other;
            return mul.X + mul.Y + mul.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong UncheckedLengthSquared() {
            var sqr = BigMul(this);
            return sqr.X + sqr.Y + sqr.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint UncheckedLength() => (uint)Mathi.Sqrt(UncheckedLengthSquared());

        #endregion

        #region Overflowing

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt32 WrappingAdd(Vector3UInt32 other) {
            return new Vector3UInt32(Overflowing.WrappingAdd(X, other.X), Overflowing.WrappingAdd(Y, other.Y), Overflowing.WrappingAdd(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt32 WrappingSub(Vector3UInt32 other) {
            return new Vector3UInt32(Overflowing.WrappingSub(X, other.X), Overflowing.WrappingSub(Y, other.Y), Overflowing.WrappingSub(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt32 WrappingNeg() {
            return new Vector3UInt32(Overflowing.WrappingNeg(X), Overflowing.WrappingNeg(Y), Overflowing.WrappingNeg(Z));
        }

        // Rust に倣って WrappingAddSigned のみを定義し
        // WrappingSubSigned は定義しない.
        // https://doc.rust-lang.org/std/primitive.u32.html#method.wrapping_add_signed

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt32 WrappingAddSigned(Vector3Int32 other) {
            return new Vector3UInt32(Overflowing.WrappingAddSigned(X, other.X), Overflowing.WrappingAddSigned(Y, other.Y), Overflowing.WrappingAddSigned(Z, other.Z));
        }

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 XX() => new Vector2UInt32(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 XY() => new Vector2UInt32(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 XZ() => new Vector2UInt32(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 YX() => new Vector2UInt32(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 YY() => new Vector2UInt32(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 YZ() => new Vector2UInt32(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 ZX() => new Vector2UInt32(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 ZY() => new Vector2UInt32(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 ZZ() => new Vector2UInt32(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XXX() => new Vector3UInt32(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XXY() => new Vector3UInt32(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XXZ() => new Vector3UInt32(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XYX() => new Vector3UInt32(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XYY() => new Vector3UInt32(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XYZ() => new Vector3UInt32(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XZX() => new Vector3UInt32(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XZY() => new Vector3UInt32(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XZZ() => new Vector3UInt32(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YXX() => new Vector3UInt32(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YXY() => new Vector3UInt32(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YXZ() => new Vector3UInt32(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YYX() => new Vector3UInt32(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YYY() => new Vector3UInt32(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YYZ() => new Vector3UInt32(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YZX() => new Vector3UInt32(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YZY() => new Vector3UInt32(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YZZ() => new Vector3UInt32(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZXX() => new Vector3UInt32(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZXY() => new Vector3UInt32(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZXZ() => new Vector3UInt32(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZYX() => new Vector3UInt32(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZYY() => new Vector3UInt32(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZYZ() => new Vector3UInt32(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZZX() => new Vector3UInt32(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZZY() => new Vector3UInt32(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZZZ() => new Vector3UInt32(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXXX() => new Vector4UInt32(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXXY() => new Vector4UInt32(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXXZ() => new Vector4UInt32(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXYX() => new Vector4UInt32(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXYY() => new Vector4UInt32(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXYZ() => new Vector4UInt32(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXZX() => new Vector4UInt32(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXZY() => new Vector4UInt32(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXZZ() => new Vector4UInt32(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYXX() => new Vector4UInt32(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYXY() => new Vector4UInt32(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYXZ() => new Vector4UInt32(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYYX() => new Vector4UInt32(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYYY() => new Vector4UInt32(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYYZ() => new Vector4UInt32(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYZX() => new Vector4UInt32(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYZY() => new Vector4UInt32(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYZZ() => new Vector4UInt32(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZXX() => new Vector4UInt32(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZXY() => new Vector4UInt32(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZXZ() => new Vector4UInt32(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZYX() => new Vector4UInt32(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZYY() => new Vector4UInt32(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZYZ() => new Vector4UInt32(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZZX() => new Vector4UInt32(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZZY() => new Vector4UInt32(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZZZ() => new Vector4UInt32(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXXX() => new Vector4UInt32(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXXY() => new Vector4UInt32(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXXZ() => new Vector4UInt32(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXYX() => new Vector4UInt32(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXYY() => new Vector4UInt32(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXYZ() => new Vector4UInt32(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXZX() => new Vector4UInt32(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXZY() => new Vector4UInt32(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXZZ() => new Vector4UInt32(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYXX() => new Vector4UInt32(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYXY() => new Vector4UInt32(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYXZ() => new Vector4UInt32(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYYX() => new Vector4UInt32(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYYY() => new Vector4UInt32(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYYZ() => new Vector4UInt32(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYZX() => new Vector4UInt32(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYZY() => new Vector4UInt32(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYZZ() => new Vector4UInt32(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZXX() => new Vector4UInt32(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZXY() => new Vector4UInt32(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZXZ() => new Vector4UInt32(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZYX() => new Vector4UInt32(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZYY() => new Vector4UInt32(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZYZ() => new Vector4UInt32(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZZX() => new Vector4UInt32(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZZY() => new Vector4UInt32(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZZZ() => new Vector4UInt32(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXXX() => new Vector4UInt32(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXXY() => new Vector4UInt32(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXXZ() => new Vector4UInt32(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXYX() => new Vector4UInt32(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXYY() => new Vector4UInt32(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXYZ() => new Vector4UInt32(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXZX() => new Vector4UInt32(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXZY() => new Vector4UInt32(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXZZ() => new Vector4UInt32(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYXX() => new Vector4UInt32(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYXY() => new Vector4UInt32(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYXZ() => new Vector4UInt32(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYYX() => new Vector4UInt32(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYYY() => new Vector4UInt32(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYYZ() => new Vector4UInt32(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYZX() => new Vector4UInt32(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYZY() => new Vector4UInt32(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYZZ() => new Vector4UInt32(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZXX() => new Vector4UInt32(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZXY() => new Vector4UInt32(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZXZ() => new Vector4UInt32(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZYX() => new Vector4UInt32(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZYY() => new Vector4UInt32(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZYZ() => new Vector4UInt32(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZZX() => new Vector4UInt32(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZZY() => new Vector4UInt32(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZZZ() => new Vector4UInt32(Z, Z, Z, Z);

        #endregion

    }
} // namespace Intar1991
