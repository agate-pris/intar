using System;
using System.Runtime.CompilerServices;

namespace Intar1991 {
    public struct Vector4UInt64 : IEquatable<Vector4UInt64> {

        #region Fields

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public ulong X;
        public ulong Y;
        public ulong Z;
        public ulong W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        #endregion

        public Vector4UInt64(ulong x, ulong y, ulong z, ulong w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public ulong this[int index] {
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
        public static Vector4Bool operator ==(Vector4UInt64 left, Vector4UInt64 right) {
            return new Vector4Bool(left.X == right.X, left.Y == right.Y, left.Z == right.Z, left.W == right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(Vector4UInt64 left, Vector4UInt64 right) {
            return new Vector4Bool(left.X != right.X, left.Y != right.Y, left.Z != right.Z, left.W != right.W);
        }

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4UInt64 other) {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is Vector4UInt64 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        #endregion

        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator +(Vector4UInt64 left, Vector4UInt64 right) {
            return new Vector4UInt64(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator +(Vector4UInt64 left, ulong right) {
            return new Vector4UInt64(left.X + right, left.Y + right, left.Z + right, left.W + right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator +(ulong left, Vector4UInt64 right) {
            return new Vector4UInt64(left + right.X, left + right.Y, left + right.Z, left + right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator -(Vector4UInt64 left, Vector4UInt64 right) {
            return new Vector4UInt64(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator -(Vector4UInt64 left, ulong right) {
            return new Vector4UInt64(left.X - right, left.Y - right, left.Z - right, left.W - right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator -(ulong left, Vector4UInt64 right) {
            return new Vector4UInt64(left - right.X, left - right.Y, left - right.Z, left - right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator *(Vector4UInt64 left, Vector4UInt64 right) {
            return new Vector4UInt64(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator *(Vector4UInt64 left, ulong right) {
            return new Vector4UInt64(left.X * right, left.Y * right, left.Z * right, left.W * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator *(ulong left, Vector4UInt64 right) {
            return new Vector4UInt64(left * right.X, left * right.Y, left * right.Z, left * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator /(Vector4UInt64 left, Vector4UInt64 right) {
            return new Vector4UInt64(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator /(Vector4UInt64 left, ulong right) {
            return new Vector4UInt64(left.X / right, left.Y / right, left.Z / right, left.W / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator /(ulong left, Vector4UInt64 right) {
            return new Vector4UInt64(left / right.X, left / right.Y, left / right.Z, left / right.W);
        }

        #endregion

        #region IUnaryPlusOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator +(Vector4UInt64 x) {
            return new Vector4UInt64(+x.X, +x.Y, +x.Z, +x.W);
        }

        #endregion

        #region Conversion Operators

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4Int32(Vector4UInt64 a) {
            return new Vector4Int32((int)a.X, (int)a.Y, (int)a.Z, (int)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt32(Vector4UInt64 a) {
            return new Vector4UInt32((uint)a.X, (uint)a.Y, (uint)a.Z, (uint)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4Int64(Vector4UInt64 a) {
            return new Vector4Int64((long)a.X, (long)a.Y, (long)a.Z, (long)a.W);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector4Int128(Vector4UInt64 a) {
            return new Vector4Int128((Int128)a.X, (Int128)a.Y, (Int128)a.Z, (Int128)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector4UInt128(Vector4UInt64 a) {
            return new Vector4UInt128((UInt128)a.X, (UInt128)a.Y, (UInt128)a.Z, (UInt128)a.W);
        }

#endif // NET7_0_OR_GREATER

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        #endregion

        #region IsNegative, Abs, UnsignedAbs, IsNegativeAndUnsignedAbs

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Bool IsNegative() {
            return new Vector4Bool(X < 0, Y < 0, Z < 0, W < 0);
        }

        // 符号なしベクトル型に対しては Abs, UnsignedAbs は定義しない.

        #endregion

        #region Min, Max, MaxComponent, Clamp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt64 Min(Vector4UInt64 other) {
            return new Vector4UInt64(Math.Min(X, other.X), Math.Min(Y, other.Y), Math.Min(Z, other.Z), Math.Min(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt64 Max(Vector4UInt64 other) {
            return new Vector4UInt64(Math.Max(X, other.X), Math.Max(Y, other.Y), Math.Max(Z, other.Z), Math.Max(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal ulong MaxComponent() {
            return Math.Max(Math.Max(X, Y), Math.Max(Z, W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt64 Clamp(ulong min, ulong max) {
#if NET5_0_OR_GREATER
            return new Vector4UInt64(Math.Clamp(X, min, max), Math.Clamp(Y, min, max), Math.Clamp(Z, min, max), Math.Clamp(W, min, max));
#else
            return new Vector4UInt64(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max), Mathi.Clamp(Z, min, max), Mathi.Clamp(W, min, max));
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt64 Clamp(Vector4UInt64 min, Vector4UInt64 max) {
#if NET5_0_OR_GREATER
            return new Vector4UInt64(Math.Clamp(X, min.X, max.X), Math.Clamp(Y, min.Y, max.Y), Math.Clamp(Z, min.Z, max.Z), Math.Clamp(W, min.W, max.W));
#else
            return new Vector4UInt64(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y), Mathi.Clamp(Z, min.Z, max.Z), Mathi.Clamp(W, min.W, max.W));
#endif
        }

        #endregion

        #region Half, Twice, UncheckedComponentsSum

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt64 Half() => new Vector4UInt64(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z), Mathi.Half(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt64 Twice() => new Vector4UInt64(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z), Mathi.Twice(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal ulong UncheckedComponentsSum() => X + Y + Z + W;

        #endregion

        #region BigMul, Cross, UncheckedDot, (Unchecked)LengthSquared, (Unchecked)Length, HalfLength

#if NET7_0_OR_GREATER

        public Vector4UInt128 BigMul(ulong other) {
            return (Vector4UInt128)this * other;
        }

        public Vector4UInt128 BigMul(Vector4UInt64 other) {
            return (Vector4UInt128)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt128 UncheckedDot(Vector4UInt64 other) {
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
        public Vector4UInt64 WrappingAdd(Vector4UInt64 other) {
            return new Vector4UInt64(Overflowing.WrappingAdd(X, other.X), Overflowing.WrappingAdd(Y, other.Y), Overflowing.WrappingAdd(Z, other.Z), Overflowing.WrappingAdd(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt64 WrappingSub(Vector4UInt64 other) {
            return new Vector4UInt64(Overflowing.WrappingSub(X, other.X), Overflowing.WrappingSub(Y, other.Y), Overflowing.WrappingSub(Z, other.Z), Overflowing.WrappingSub(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt64 WrappingNeg() {
            return new Vector4UInt64(Overflowing.WrappingNeg(X), Overflowing.WrappingNeg(Y), Overflowing.WrappingNeg(Z), Overflowing.WrappingNeg(W));
        }

        // Rust に倣って WrappingAddSigned のみを定義し
        // WrappingSubSigned は定義しない.
        // https://doc.rust-lang.org/std/primitive.u32.html#method.wrapping_add_signed

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt64 WrappingAddSigned(Vector4Int64 other) {
            return new Vector4UInt64(Overflowing.WrappingAddSigned(X, other.X), Overflowing.WrappingAddSigned(Y, other.Y), Overflowing.WrappingAddSigned(Z, other.Z), Overflowing.WrappingAddSigned(W, other.W));
        }

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 XX() => new Vector2UInt64(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 XY() => new Vector2UInt64(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 XZ() => new Vector2UInt64(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 XW() => new Vector2UInt64(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 YX() => new Vector2UInt64(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 YY() => new Vector2UInt64(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 YZ() => new Vector2UInt64(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 YW() => new Vector2UInt64(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 ZX() => new Vector2UInt64(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 ZY() => new Vector2UInt64(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 ZZ() => new Vector2UInt64(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 ZW() => new Vector2UInt64(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 WX() => new Vector2UInt64(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 WY() => new Vector2UInt64(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 WZ() => new Vector2UInt64(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 WW() => new Vector2UInt64(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XXX() => new Vector3UInt64(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XXY() => new Vector3UInt64(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XXZ() => new Vector3UInt64(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XXW() => new Vector3UInt64(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XYX() => new Vector3UInt64(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XYY() => new Vector3UInt64(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XYZ() => new Vector3UInt64(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XYW() => new Vector3UInt64(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XZX() => new Vector3UInt64(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XZY() => new Vector3UInt64(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XZZ() => new Vector3UInt64(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XZW() => new Vector3UInt64(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XWX() => new Vector3UInt64(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XWY() => new Vector3UInt64(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XWZ() => new Vector3UInt64(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XWW() => new Vector3UInt64(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YXX() => new Vector3UInt64(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YXY() => new Vector3UInt64(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YXZ() => new Vector3UInt64(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YXW() => new Vector3UInt64(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YYX() => new Vector3UInt64(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YYY() => new Vector3UInt64(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YYZ() => new Vector3UInt64(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YYW() => new Vector3UInt64(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YZX() => new Vector3UInt64(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YZY() => new Vector3UInt64(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YZZ() => new Vector3UInt64(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YZW() => new Vector3UInt64(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YWX() => new Vector3UInt64(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YWY() => new Vector3UInt64(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YWZ() => new Vector3UInt64(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YWW() => new Vector3UInt64(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZXX() => new Vector3UInt64(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZXY() => new Vector3UInt64(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZXZ() => new Vector3UInt64(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZXW() => new Vector3UInt64(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZYX() => new Vector3UInt64(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZYY() => new Vector3UInt64(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZYZ() => new Vector3UInt64(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZYW() => new Vector3UInt64(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZZX() => new Vector3UInt64(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZZY() => new Vector3UInt64(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZZZ() => new Vector3UInt64(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZZW() => new Vector3UInt64(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZWX() => new Vector3UInt64(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZWY() => new Vector3UInt64(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZWZ() => new Vector3UInt64(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZWW() => new Vector3UInt64(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 WXX() => new Vector3UInt64(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 WXY() => new Vector3UInt64(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 WXZ() => new Vector3UInt64(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 WXW() => new Vector3UInt64(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 WYX() => new Vector3UInt64(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 WYY() => new Vector3UInt64(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 WYZ() => new Vector3UInt64(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 WYW() => new Vector3UInt64(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 WZX() => new Vector3UInt64(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 WZY() => new Vector3UInt64(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 WZZ() => new Vector3UInt64(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 WZW() => new Vector3UInt64(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 WWX() => new Vector3UInt64(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 WWY() => new Vector3UInt64(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 WWZ() => new Vector3UInt64(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 WWW() => new Vector3UInt64(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXXX() => new Vector4UInt64(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXXY() => new Vector4UInt64(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXXZ() => new Vector4UInt64(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXXW() => new Vector4UInt64(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXYX() => new Vector4UInt64(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXYY() => new Vector4UInt64(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXYZ() => new Vector4UInt64(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXYW() => new Vector4UInt64(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXZX() => new Vector4UInt64(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXZY() => new Vector4UInt64(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXZZ() => new Vector4UInt64(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXZW() => new Vector4UInt64(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXWX() => new Vector4UInt64(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXWY() => new Vector4UInt64(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXWZ() => new Vector4UInt64(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXWW() => new Vector4UInt64(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYXX() => new Vector4UInt64(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYXY() => new Vector4UInt64(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYXZ() => new Vector4UInt64(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYXW() => new Vector4UInt64(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYYX() => new Vector4UInt64(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYYY() => new Vector4UInt64(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYYZ() => new Vector4UInt64(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYYW() => new Vector4UInt64(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYZX() => new Vector4UInt64(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYZY() => new Vector4UInt64(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYZZ() => new Vector4UInt64(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYZW() => new Vector4UInt64(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYWX() => new Vector4UInt64(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYWY() => new Vector4UInt64(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYWZ() => new Vector4UInt64(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYWW() => new Vector4UInt64(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZXX() => new Vector4UInt64(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZXY() => new Vector4UInt64(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZXZ() => new Vector4UInt64(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZXW() => new Vector4UInt64(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZYX() => new Vector4UInt64(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZYY() => new Vector4UInt64(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZYZ() => new Vector4UInt64(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZYW() => new Vector4UInt64(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZZX() => new Vector4UInt64(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZZY() => new Vector4UInt64(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZZZ() => new Vector4UInt64(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZZW() => new Vector4UInt64(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZWX() => new Vector4UInt64(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZWY() => new Vector4UInt64(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZWZ() => new Vector4UInt64(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZWW() => new Vector4UInt64(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XWXX() => new Vector4UInt64(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XWXY() => new Vector4UInt64(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XWXZ() => new Vector4UInt64(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XWXW() => new Vector4UInt64(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XWYX() => new Vector4UInt64(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XWYY() => new Vector4UInt64(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XWYZ() => new Vector4UInt64(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XWYW() => new Vector4UInt64(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XWZX() => new Vector4UInt64(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XWZY() => new Vector4UInt64(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XWZZ() => new Vector4UInt64(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XWZW() => new Vector4UInt64(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XWWX() => new Vector4UInt64(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XWWY() => new Vector4UInt64(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XWWZ() => new Vector4UInt64(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XWWW() => new Vector4UInt64(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXXX() => new Vector4UInt64(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXXY() => new Vector4UInt64(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXXZ() => new Vector4UInt64(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXXW() => new Vector4UInt64(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXYX() => new Vector4UInt64(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXYY() => new Vector4UInt64(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXYZ() => new Vector4UInt64(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXYW() => new Vector4UInt64(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXZX() => new Vector4UInt64(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXZY() => new Vector4UInt64(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXZZ() => new Vector4UInt64(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXZW() => new Vector4UInt64(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXWX() => new Vector4UInt64(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXWY() => new Vector4UInt64(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXWZ() => new Vector4UInt64(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXWW() => new Vector4UInt64(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYXX() => new Vector4UInt64(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYXY() => new Vector4UInt64(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYXZ() => new Vector4UInt64(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYXW() => new Vector4UInt64(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYYX() => new Vector4UInt64(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYYY() => new Vector4UInt64(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYYZ() => new Vector4UInt64(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYYW() => new Vector4UInt64(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYZX() => new Vector4UInt64(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYZY() => new Vector4UInt64(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYZZ() => new Vector4UInt64(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYZW() => new Vector4UInt64(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYWX() => new Vector4UInt64(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYWY() => new Vector4UInt64(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYWZ() => new Vector4UInt64(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYWW() => new Vector4UInt64(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZXX() => new Vector4UInt64(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZXY() => new Vector4UInt64(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZXZ() => new Vector4UInt64(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZXW() => new Vector4UInt64(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZYX() => new Vector4UInt64(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZYY() => new Vector4UInt64(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZYZ() => new Vector4UInt64(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZYW() => new Vector4UInt64(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZZX() => new Vector4UInt64(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZZY() => new Vector4UInt64(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZZZ() => new Vector4UInt64(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZZW() => new Vector4UInt64(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZWX() => new Vector4UInt64(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZWY() => new Vector4UInt64(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZWZ() => new Vector4UInt64(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZWW() => new Vector4UInt64(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YWXX() => new Vector4UInt64(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YWXY() => new Vector4UInt64(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YWXZ() => new Vector4UInt64(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YWXW() => new Vector4UInt64(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YWYX() => new Vector4UInt64(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YWYY() => new Vector4UInt64(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YWYZ() => new Vector4UInt64(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YWYW() => new Vector4UInt64(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YWZX() => new Vector4UInt64(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YWZY() => new Vector4UInt64(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YWZZ() => new Vector4UInt64(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YWZW() => new Vector4UInt64(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YWWX() => new Vector4UInt64(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YWWY() => new Vector4UInt64(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YWWZ() => new Vector4UInt64(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YWWW() => new Vector4UInt64(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXXX() => new Vector4UInt64(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXXY() => new Vector4UInt64(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXXZ() => new Vector4UInt64(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXXW() => new Vector4UInt64(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXYX() => new Vector4UInt64(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXYY() => new Vector4UInt64(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXYZ() => new Vector4UInt64(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXYW() => new Vector4UInt64(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXZX() => new Vector4UInt64(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXZY() => new Vector4UInt64(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXZZ() => new Vector4UInt64(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXZW() => new Vector4UInt64(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXWX() => new Vector4UInt64(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXWY() => new Vector4UInt64(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXWZ() => new Vector4UInt64(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXWW() => new Vector4UInt64(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYXX() => new Vector4UInt64(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYXY() => new Vector4UInt64(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYXZ() => new Vector4UInt64(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYXW() => new Vector4UInt64(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYYX() => new Vector4UInt64(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYYY() => new Vector4UInt64(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYYZ() => new Vector4UInt64(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYYW() => new Vector4UInt64(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYZX() => new Vector4UInt64(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYZY() => new Vector4UInt64(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYZZ() => new Vector4UInt64(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYZW() => new Vector4UInt64(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYWX() => new Vector4UInt64(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYWY() => new Vector4UInt64(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYWZ() => new Vector4UInt64(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYWW() => new Vector4UInt64(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZXX() => new Vector4UInt64(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZXY() => new Vector4UInt64(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZXZ() => new Vector4UInt64(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZXW() => new Vector4UInt64(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZYX() => new Vector4UInt64(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZYY() => new Vector4UInt64(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZYZ() => new Vector4UInt64(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZYW() => new Vector4UInt64(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZZX() => new Vector4UInt64(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZZY() => new Vector4UInt64(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZZZ() => new Vector4UInt64(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZZW() => new Vector4UInt64(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZWX() => new Vector4UInt64(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZWY() => new Vector4UInt64(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZWZ() => new Vector4UInt64(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZWW() => new Vector4UInt64(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZWXX() => new Vector4UInt64(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZWXY() => new Vector4UInt64(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZWXZ() => new Vector4UInt64(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZWXW() => new Vector4UInt64(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZWYX() => new Vector4UInt64(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZWYY() => new Vector4UInt64(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZWYZ() => new Vector4UInt64(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZWYW() => new Vector4UInt64(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZWZX() => new Vector4UInt64(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZWZY() => new Vector4UInt64(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZWZZ() => new Vector4UInt64(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZWZW() => new Vector4UInt64(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZWWX() => new Vector4UInt64(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZWWY() => new Vector4UInt64(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZWWZ() => new Vector4UInt64(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZWWW() => new Vector4UInt64(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WXXX() => new Vector4UInt64(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WXXY() => new Vector4UInt64(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WXXZ() => new Vector4UInt64(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WXXW() => new Vector4UInt64(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WXYX() => new Vector4UInt64(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WXYY() => new Vector4UInt64(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WXYZ() => new Vector4UInt64(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WXYW() => new Vector4UInt64(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WXZX() => new Vector4UInt64(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WXZY() => new Vector4UInt64(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WXZZ() => new Vector4UInt64(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WXZW() => new Vector4UInt64(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WXWX() => new Vector4UInt64(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WXWY() => new Vector4UInt64(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WXWZ() => new Vector4UInt64(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WXWW() => new Vector4UInt64(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WYXX() => new Vector4UInt64(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WYXY() => new Vector4UInt64(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WYXZ() => new Vector4UInt64(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WYXW() => new Vector4UInt64(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WYYX() => new Vector4UInt64(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WYYY() => new Vector4UInt64(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WYYZ() => new Vector4UInt64(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WYYW() => new Vector4UInt64(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WYZX() => new Vector4UInt64(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WYZY() => new Vector4UInt64(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WYZZ() => new Vector4UInt64(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WYZW() => new Vector4UInt64(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WYWX() => new Vector4UInt64(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WYWY() => new Vector4UInt64(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WYWZ() => new Vector4UInt64(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WYWW() => new Vector4UInt64(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WZXX() => new Vector4UInt64(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WZXY() => new Vector4UInt64(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WZXZ() => new Vector4UInt64(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WZXW() => new Vector4UInt64(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WZYX() => new Vector4UInt64(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WZYY() => new Vector4UInt64(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WZYZ() => new Vector4UInt64(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WZYW() => new Vector4UInt64(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WZZX() => new Vector4UInt64(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WZZY() => new Vector4UInt64(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WZZZ() => new Vector4UInt64(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WZZW() => new Vector4UInt64(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WZWX() => new Vector4UInt64(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WZWY() => new Vector4UInt64(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WZWZ() => new Vector4UInt64(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WZWW() => new Vector4UInt64(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WWXX() => new Vector4UInt64(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WWXY() => new Vector4UInt64(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WWXZ() => new Vector4UInt64(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WWXW() => new Vector4UInt64(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WWYX() => new Vector4UInt64(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WWYY() => new Vector4UInt64(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WWYZ() => new Vector4UInt64(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WWYW() => new Vector4UInt64(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WWZX() => new Vector4UInt64(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WWZY() => new Vector4UInt64(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WWZZ() => new Vector4UInt64(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WWZW() => new Vector4UInt64(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WWWX() => new Vector4UInt64(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WWWY() => new Vector4UInt64(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WWWZ() => new Vector4UInt64(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 WWWW() => new Vector4UInt64(W, W, W, W);

        #endregion

    }
} // namespace Intar1991
