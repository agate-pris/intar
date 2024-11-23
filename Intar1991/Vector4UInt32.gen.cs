using System;
using System.Runtime.CompilerServices;

namespace Intar1991 {
    public struct Vector4UInt32 : IEquatable<Vector4UInt32> {

        #region Fields

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public uint X;
        public uint Y;
        public uint Z;
        public uint W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        #endregion

        public Vector4UInt32(uint x, uint y, uint z, uint w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public uint this[int index] {
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
        public static Vector4Bool operator ==(Vector4UInt32 left, Vector4UInt32 right) {
            return new Vector4Bool(left.X == right.X, left.Y == right.Y, left.Z == right.Z, left.W == right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(Vector4UInt32 left, Vector4UInt32 right) {
            return new Vector4Bool(left.X != right.X, left.Y != right.Y, left.Z != right.Z, left.W != right.W);
        }

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4UInt32 other) {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is Vector4UInt32 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        #endregion

        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator +(Vector4UInt32 left, Vector4UInt32 right) {
            return new Vector4UInt32(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator -(Vector4UInt32 left, Vector4UInt32 right) {
            return new Vector4UInt32(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator *(Vector4UInt32 left, Vector4UInt32 right) {
            return new Vector4UInt32(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator /(Vector4UInt32 left, Vector4UInt32 right) {
            return new Vector4UInt32(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator *(Vector4UInt32 left, uint right) {
            return new Vector4UInt32(left.X * right, left.Y * right, left.Z * right, left.W * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator *(uint left, Vector4UInt32 right) {
            return new Vector4UInt32(left * right.X, left * right.Y, left * right.Z, left * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator /(Vector4UInt32 left, uint right) {
            return new Vector4UInt32(left.X / right, left.Y / right, left.Z / right, left.W / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator /(uint left, Vector4UInt32 right) {
            return new Vector4UInt32(left / right.X, left / right.Y, left / right.Z, left / right.W);
        }

        #endregion

        #region IUnaryPlusOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator +(Vector4UInt32 x) {
            return new Vector4UInt32(+x.X, +x.Y, +x.Z, +x.W);
        }

        #endregion

        #region Conversion Operators

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4Int32(Vector4UInt32 a) {
            return new Vector4Int32((int)a.X, (int)a.Y, (int)a.Z, (int)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector4Int64(Vector4UInt32 a) {
            return new Vector4Int64((long)a.X, (long)a.Y, (long)a.Z, (long)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector4UInt64(Vector4UInt32 a) {
            return new Vector4UInt64((ulong)a.X, (ulong)a.Y, (ulong)a.Z, (ulong)a.W);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector4Int128(Vector4UInt32 a) {
            return new Vector4Int128((Int128)a.X, (Int128)a.Y, (Int128)a.Z, (Int128)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector4UInt128(Vector4UInt32 a) {
            return new Vector4UInt128((UInt128)a.X, (UInt128)a.Y, (UInt128)a.Z, (UInt128)a.W);
        }

#endif // NET7_0_OR_GREATER

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        #endregion

        #region IsNegative, Abs, UnsignedAbs

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Bool IsNegative() {
            return new Vector4Bool(X < 0, Y < 0, Z < 0, W < 0);
        }

        // 符号なしベクトル型に対しては Abs, UnsignedAbs は定義しない.

        #endregion

        #region Min, Max, Clamp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 Min(Vector4UInt32 other) {
            return new Vector4UInt32(Math.Min(X, other.X), Math.Min(Y, other.Y), Math.Min(Z, other.Z), Math.Min(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 Max(Vector4UInt32 other) {
            return new Vector4UInt32(Math.Max(X, other.X), Math.Max(Y, other.Y), Math.Max(Z, other.Z), Math.Max(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 Clamp(uint min, uint max) {
#if NET5_0_OR_GREATER
            return new Vector4UInt32(Math.Clamp(X, min, max), Math.Clamp(Y, min, max), Math.Clamp(Z, min, max), Math.Clamp(W, min, max));
#else
            return new Vector4UInt32(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max), Mathi.Clamp(Z, min, max), Mathi.Clamp(W, min, max));
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 Clamp(Vector4UInt32 min, Vector4UInt32 max) {
#if NET5_0_OR_GREATER
            return new Vector4UInt32(Math.Clamp(X, min.X, max.X), Math.Clamp(Y, min.Y, max.Y), Math.Clamp(Z, min.Z, max.Z), Math.Clamp(W, min.W, max.W));
#else
            return new Vector4UInt32(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y), Mathi.Clamp(Z, min.Z, max.Z), Mathi.Clamp(W, min.W, max.W));
#endif
        }

        #endregion

        #region Half and Twice

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 Half() => new Vector4UInt32(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z), Mathi.Half(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 Twice() => new Vector4UInt32(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z), Mathi.Twice(W));

        #endregion

        #region BigMul, Cross, UncheckedDot, (Unchecked)LengthSquared, (Unchecked)Length

        public Vector4UInt64 BigMul(uint other) {
            return (Vector4UInt64)this * other;
        }

        public Vector4UInt64 BigMul(Vector4UInt32 other) {
            return (Vector4UInt64)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong UncheckedDot(Vector4UInt32 other) {
            var mul = (Vector4UInt64)this * other;
            return mul.X + mul.Y + mul.Z + mul.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong UncheckedLengthSquared() {
            var sqr = BigMul(this);
            return sqr.X + sqr.Y + sqr.Z + sqr.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint UncheckedLength() => (uint)Mathi.Sqrt(UncheckedLengthSquared());

        #endregion

        #region Overflowing

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 WrappingAdd(Vector4UInt32 other) {
            return new Vector4UInt32(Overflowing.WrappingAdd(X, other.X), Overflowing.WrappingAdd(Y, other.Y), Overflowing.WrappingAdd(Z, other.Z), Overflowing.WrappingAdd(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 WrappingSub(Vector4UInt32 other) {
            return new Vector4UInt32(Overflowing.WrappingSub(X, other.X), Overflowing.WrappingSub(Y, other.Y), Overflowing.WrappingSub(Z, other.Z), Overflowing.WrappingSub(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 WrappingNeg() {
            return new Vector4UInt32(Overflowing.WrappingNeg(X), Overflowing.WrappingNeg(Y), Overflowing.WrappingNeg(Z), Overflowing.WrappingNeg(W));
        }

        // Rust に倣って WrappingAddSigned のみを定義し
        // WrappingSubSigned は定義しない.
        // https://doc.rust-lang.org/std/primitive.u32.html#method.wrapping_add_signed

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 WrappingAddSigned(Vector4Int32 other) {
            return new Vector4UInt32(Overflowing.WrappingAddSigned(X, other.X), Overflowing.WrappingAddSigned(Y, other.Y), Overflowing.WrappingAddSigned(Z, other.Z), Overflowing.WrappingAddSigned(W, other.W));
        }

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 XX() => new Vector2UInt32(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 XY() => new Vector2UInt32(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 XZ() => new Vector2UInt32(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 XW() => new Vector2UInt32(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 YX() => new Vector2UInt32(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 YY() => new Vector2UInt32(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 YZ() => new Vector2UInt32(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 YW() => new Vector2UInt32(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 ZX() => new Vector2UInt32(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 ZY() => new Vector2UInt32(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 ZZ() => new Vector2UInt32(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 ZW() => new Vector2UInt32(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 WX() => new Vector2UInt32(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 WY() => new Vector2UInt32(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 WZ() => new Vector2UInt32(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 WW() => new Vector2UInt32(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XXX() => new Vector3UInt32(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XXY() => new Vector3UInt32(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XXZ() => new Vector3UInt32(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XXW() => new Vector3UInt32(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XYX() => new Vector3UInt32(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XYY() => new Vector3UInt32(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XYZ() => new Vector3UInt32(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XYW() => new Vector3UInt32(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XZX() => new Vector3UInt32(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XZY() => new Vector3UInt32(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XZZ() => new Vector3UInt32(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XZW() => new Vector3UInt32(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XWX() => new Vector3UInt32(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XWY() => new Vector3UInt32(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XWZ() => new Vector3UInt32(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XWW() => new Vector3UInt32(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YXX() => new Vector3UInt32(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YXY() => new Vector3UInt32(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YXZ() => new Vector3UInt32(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YXW() => new Vector3UInt32(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YYX() => new Vector3UInt32(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YYY() => new Vector3UInt32(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YYZ() => new Vector3UInt32(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YYW() => new Vector3UInt32(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YZX() => new Vector3UInt32(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YZY() => new Vector3UInt32(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YZZ() => new Vector3UInt32(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YZW() => new Vector3UInt32(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YWX() => new Vector3UInt32(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YWY() => new Vector3UInt32(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YWZ() => new Vector3UInt32(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YWW() => new Vector3UInt32(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZXX() => new Vector3UInt32(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZXY() => new Vector3UInt32(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZXZ() => new Vector3UInt32(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZXW() => new Vector3UInt32(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZYX() => new Vector3UInt32(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZYY() => new Vector3UInt32(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZYZ() => new Vector3UInt32(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZYW() => new Vector3UInt32(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZZX() => new Vector3UInt32(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZZY() => new Vector3UInt32(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZZZ() => new Vector3UInt32(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZZW() => new Vector3UInt32(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZWX() => new Vector3UInt32(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZWY() => new Vector3UInt32(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZWZ() => new Vector3UInt32(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 ZWW() => new Vector3UInt32(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 WXX() => new Vector3UInt32(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 WXY() => new Vector3UInt32(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 WXZ() => new Vector3UInt32(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 WXW() => new Vector3UInt32(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 WYX() => new Vector3UInt32(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 WYY() => new Vector3UInt32(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 WYZ() => new Vector3UInt32(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 WYW() => new Vector3UInt32(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 WZX() => new Vector3UInt32(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 WZY() => new Vector3UInt32(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 WZZ() => new Vector3UInt32(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 WZW() => new Vector3UInt32(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 WWX() => new Vector3UInt32(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 WWY() => new Vector3UInt32(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 WWZ() => new Vector3UInt32(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 WWW() => new Vector3UInt32(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXXX() => new Vector4UInt32(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXXY() => new Vector4UInt32(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXXZ() => new Vector4UInt32(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXXW() => new Vector4UInt32(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXYX() => new Vector4UInt32(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXYY() => new Vector4UInt32(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXYZ() => new Vector4UInt32(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXYW() => new Vector4UInt32(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXZX() => new Vector4UInt32(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXZY() => new Vector4UInt32(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXZZ() => new Vector4UInt32(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXZW() => new Vector4UInt32(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXWX() => new Vector4UInt32(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXWY() => new Vector4UInt32(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXWZ() => new Vector4UInt32(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXWW() => new Vector4UInt32(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYXX() => new Vector4UInt32(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYXY() => new Vector4UInt32(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYXZ() => new Vector4UInt32(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYXW() => new Vector4UInt32(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYYX() => new Vector4UInt32(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYYY() => new Vector4UInt32(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYYZ() => new Vector4UInt32(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYYW() => new Vector4UInt32(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYZX() => new Vector4UInt32(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYZY() => new Vector4UInt32(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYZZ() => new Vector4UInt32(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYZW() => new Vector4UInt32(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYWX() => new Vector4UInt32(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYWY() => new Vector4UInt32(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYWZ() => new Vector4UInt32(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYWW() => new Vector4UInt32(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZXX() => new Vector4UInt32(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZXY() => new Vector4UInt32(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZXZ() => new Vector4UInt32(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZXW() => new Vector4UInt32(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZYX() => new Vector4UInt32(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZYY() => new Vector4UInt32(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZYZ() => new Vector4UInt32(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZYW() => new Vector4UInt32(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZZX() => new Vector4UInt32(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZZY() => new Vector4UInt32(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZZZ() => new Vector4UInt32(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZZW() => new Vector4UInt32(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZWX() => new Vector4UInt32(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZWY() => new Vector4UInt32(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZWZ() => new Vector4UInt32(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XZWW() => new Vector4UInt32(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XWXX() => new Vector4UInt32(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XWXY() => new Vector4UInt32(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XWXZ() => new Vector4UInt32(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XWXW() => new Vector4UInt32(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XWYX() => new Vector4UInt32(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XWYY() => new Vector4UInt32(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XWYZ() => new Vector4UInt32(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XWYW() => new Vector4UInt32(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XWZX() => new Vector4UInt32(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XWZY() => new Vector4UInt32(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XWZZ() => new Vector4UInt32(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XWZW() => new Vector4UInt32(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XWWX() => new Vector4UInt32(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XWWY() => new Vector4UInt32(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XWWZ() => new Vector4UInt32(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XWWW() => new Vector4UInt32(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXXX() => new Vector4UInt32(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXXY() => new Vector4UInt32(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXXZ() => new Vector4UInt32(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXXW() => new Vector4UInt32(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXYX() => new Vector4UInt32(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXYY() => new Vector4UInt32(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXYZ() => new Vector4UInt32(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXYW() => new Vector4UInt32(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXZX() => new Vector4UInt32(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXZY() => new Vector4UInt32(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXZZ() => new Vector4UInt32(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXZW() => new Vector4UInt32(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXWX() => new Vector4UInt32(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXWY() => new Vector4UInt32(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXWZ() => new Vector4UInt32(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXWW() => new Vector4UInt32(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYXX() => new Vector4UInt32(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYXY() => new Vector4UInt32(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYXZ() => new Vector4UInt32(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYXW() => new Vector4UInt32(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYYX() => new Vector4UInt32(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYYY() => new Vector4UInt32(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYYZ() => new Vector4UInt32(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYYW() => new Vector4UInt32(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYZX() => new Vector4UInt32(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYZY() => new Vector4UInt32(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYZZ() => new Vector4UInt32(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYZW() => new Vector4UInt32(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYWX() => new Vector4UInt32(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYWY() => new Vector4UInt32(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYWZ() => new Vector4UInt32(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYWW() => new Vector4UInt32(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZXX() => new Vector4UInt32(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZXY() => new Vector4UInt32(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZXZ() => new Vector4UInt32(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZXW() => new Vector4UInt32(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZYX() => new Vector4UInt32(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZYY() => new Vector4UInt32(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZYZ() => new Vector4UInt32(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZYW() => new Vector4UInt32(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZZX() => new Vector4UInt32(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZZY() => new Vector4UInt32(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZZZ() => new Vector4UInt32(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZZW() => new Vector4UInt32(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZWX() => new Vector4UInt32(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZWY() => new Vector4UInt32(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZWZ() => new Vector4UInt32(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YZWW() => new Vector4UInt32(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YWXX() => new Vector4UInt32(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YWXY() => new Vector4UInt32(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YWXZ() => new Vector4UInt32(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YWXW() => new Vector4UInt32(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YWYX() => new Vector4UInt32(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YWYY() => new Vector4UInt32(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YWYZ() => new Vector4UInt32(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YWYW() => new Vector4UInt32(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YWZX() => new Vector4UInt32(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YWZY() => new Vector4UInt32(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YWZZ() => new Vector4UInt32(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YWZW() => new Vector4UInt32(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YWWX() => new Vector4UInt32(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YWWY() => new Vector4UInt32(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YWWZ() => new Vector4UInt32(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YWWW() => new Vector4UInt32(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXXX() => new Vector4UInt32(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXXY() => new Vector4UInt32(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXXZ() => new Vector4UInt32(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXXW() => new Vector4UInt32(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXYX() => new Vector4UInt32(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXYY() => new Vector4UInt32(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXYZ() => new Vector4UInt32(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXYW() => new Vector4UInt32(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXZX() => new Vector4UInt32(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXZY() => new Vector4UInt32(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXZZ() => new Vector4UInt32(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXZW() => new Vector4UInt32(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXWX() => new Vector4UInt32(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXWY() => new Vector4UInt32(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXWZ() => new Vector4UInt32(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZXWW() => new Vector4UInt32(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYXX() => new Vector4UInt32(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYXY() => new Vector4UInt32(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYXZ() => new Vector4UInt32(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYXW() => new Vector4UInt32(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYYX() => new Vector4UInt32(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYYY() => new Vector4UInt32(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYYZ() => new Vector4UInt32(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYYW() => new Vector4UInt32(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYZX() => new Vector4UInt32(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYZY() => new Vector4UInt32(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYZZ() => new Vector4UInt32(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYZW() => new Vector4UInt32(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYWX() => new Vector4UInt32(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYWY() => new Vector4UInt32(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYWZ() => new Vector4UInt32(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZYWW() => new Vector4UInt32(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZXX() => new Vector4UInt32(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZXY() => new Vector4UInt32(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZXZ() => new Vector4UInt32(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZXW() => new Vector4UInt32(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZYX() => new Vector4UInt32(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZYY() => new Vector4UInt32(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZYZ() => new Vector4UInt32(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZYW() => new Vector4UInt32(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZZX() => new Vector4UInt32(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZZY() => new Vector4UInt32(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZZZ() => new Vector4UInt32(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZZW() => new Vector4UInt32(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZWX() => new Vector4UInt32(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZWY() => new Vector4UInt32(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZWZ() => new Vector4UInt32(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZZWW() => new Vector4UInt32(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZWXX() => new Vector4UInt32(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZWXY() => new Vector4UInt32(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZWXZ() => new Vector4UInt32(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZWXW() => new Vector4UInt32(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZWYX() => new Vector4UInt32(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZWYY() => new Vector4UInt32(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZWYZ() => new Vector4UInt32(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZWYW() => new Vector4UInt32(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZWZX() => new Vector4UInt32(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZWZY() => new Vector4UInt32(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZWZZ() => new Vector4UInt32(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZWZW() => new Vector4UInt32(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZWWX() => new Vector4UInt32(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZWWY() => new Vector4UInt32(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZWWZ() => new Vector4UInt32(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 ZWWW() => new Vector4UInt32(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WXXX() => new Vector4UInt32(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WXXY() => new Vector4UInt32(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WXXZ() => new Vector4UInt32(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WXXW() => new Vector4UInt32(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WXYX() => new Vector4UInt32(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WXYY() => new Vector4UInt32(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WXYZ() => new Vector4UInt32(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WXYW() => new Vector4UInt32(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WXZX() => new Vector4UInt32(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WXZY() => new Vector4UInt32(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WXZZ() => new Vector4UInt32(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WXZW() => new Vector4UInt32(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WXWX() => new Vector4UInt32(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WXWY() => new Vector4UInt32(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WXWZ() => new Vector4UInt32(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WXWW() => new Vector4UInt32(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WYXX() => new Vector4UInt32(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WYXY() => new Vector4UInt32(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WYXZ() => new Vector4UInt32(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WYXW() => new Vector4UInt32(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WYYX() => new Vector4UInt32(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WYYY() => new Vector4UInt32(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WYYZ() => new Vector4UInt32(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WYYW() => new Vector4UInt32(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WYZX() => new Vector4UInt32(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WYZY() => new Vector4UInt32(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WYZZ() => new Vector4UInt32(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WYZW() => new Vector4UInt32(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WYWX() => new Vector4UInt32(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WYWY() => new Vector4UInt32(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WYWZ() => new Vector4UInt32(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WYWW() => new Vector4UInt32(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WZXX() => new Vector4UInt32(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WZXY() => new Vector4UInt32(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WZXZ() => new Vector4UInt32(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WZXW() => new Vector4UInt32(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WZYX() => new Vector4UInt32(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WZYY() => new Vector4UInt32(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WZYZ() => new Vector4UInt32(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WZYW() => new Vector4UInt32(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WZZX() => new Vector4UInt32(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WZZY() => new Vector4UInt32(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WZZZ() => new Vector4UInt32(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WZZW() => new Vector4UInt32(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WZWX() => new Vector4UInt32(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WZWY() => new Vector4UInt32(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WZWZ() => new Vector4UInt32(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WZWW() => new Vector4UInt32(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WWXX() => new Vector4UInt32(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WWXY() => new Vector4UInt32(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WWXZ() => new Vector4UInt32(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WWXW() => new Vector4UInt32(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WWYX() => new Vector4UInt32(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WWYY() => new Vector4UInt32(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WWYZ() => new Vector4UInt32(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WWYW() => new Vector4UInt32(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WWZX() => new Vector4UInt32(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WWZY() => new Vector4UInt32(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WWZZ() => new Vector4UInt32(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WWZW() => new Vector4UInt32(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WWWX() => new Vector4UInt32(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WWWY() => new Vector4UInt32(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WWWZ() => new Vector4UInt32(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 WWWW() => new Vector4UInt32(W, W, W, W);

        #endregion

    }
} // namespace Intar1991
