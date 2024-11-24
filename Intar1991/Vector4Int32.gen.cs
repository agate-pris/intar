using System;
using System.Runtime.CompilerServices;

namespace Intar1991 {
    public struct Vector4Int32 : IEquatable<Vector4Int32> {

        #region Fields

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public int X;
        public int Y;
        public int Z;
        public int W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        #endregion

        public Vector4Int32(int x, int y, int z, int w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public int this[int index] {
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
        public static Vector4Bool operator ==(Vector4Int32 left, Vector4Int32 right) {
            return new Vector4Bool(left.X == right.X, left.Y == right.Y, left.Z == right.Z, left.W == right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(Vector4Int32 left, Vector4Int32 right) {
            return new Vector4Bool(left.X != right.X, left.Y != right.Y, left.Z != right.Z, left.W != right.W);
        }

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4Int32 other) {
            return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
        }

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is Vector4Int32 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        #endregion

        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator +(Vector4Int32 left, Vector4Int32 right) {
            return new Vector4Int32(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator -(Vector4Int32 left, Vector4Int32 right) {
            return new Vector4Int32(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator *(Vector4Int32 left, Vector4Int32 right) {
            return new Vector4Int32(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator /(Vector4Int32 left, Vector4Int32 right) {
            return new Vector4Int32(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator *(Vector4Int32 left, int right) {
            return new Vector4Int32(left.X * right, left.Y * right, left.Z * right, left.W * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator *(int left, Vector4Int32 right) {
            return new Vector4Int32(left * right.X, left * right.Y, left * right.Z, left * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator /(Vector4Int32 left, int right) {
            return new Vector4Int32(left.X / right, left.Y / right, left.Z / right, left.W / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator /(int left, Vector4Int32 right) {
            return new Vector4Int32(left / right.X, left / right.Y, left / right.Z, left / right.W);
        }

        #endregion

        #region IUnaryPlusOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator +(Vector4Int32 x) {
            return new Vector4Int32(+x.X, +x.Y, +x.Z, +x.W);
        }

        #endregion

        #region IUnarryNegationOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator -(Vector4Int32 x) {
            return new Vector4Int32(-x.X, -x.Y, -x.Z, -x.W);
        }

        #endregion

        #region Conversion Operators

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt32(Vector4Int32 a) {
            return new Vector4UInt32((uint)a.X, (uint)a.Y, (uint)a.Z, (uint)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector4Int64(Vector4Int32 a) {
            return new Vector4Int64((long)a.X, (long)a.Y, (long)a.Z, (long)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt64(Vector4Int32 a) {
            return new Vector4UInt64((ulong)a.X, (ulong)a.Y, (ulong)a.Z, (ulong)a.W);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector4Int128(Vector4Int32 a) {
            return new Vector4Int128((Int128)a.X, (Int128)a.Y, (Int128)a.Z, (Int128)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt128(Vector4Int32 a) {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 Abs() => new Vector4Int32(Math.Abs(X), Math.Abs(Y), Math.Abs(Z), Math.Abs(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 UnsignedAbs() {
            var isNegative = IsNegative();
            return new Vector4UInt32(
                unchecked((uint)(isNegative.X ? Overflowing.WrappingNeg(X) : X)),
                unchecked((uint)(isNegative.Y ? Overflowing.WrappingNeg(Y) : Y)),
                unchecked((uint)(isNegative.Z ? Overflowing.WrappingNeg(Z) : Z)),
                unchecked((uint)(isNegative.W ? Overflowing.WrappingNeg(W) : W))
            );
        }

        #endregion

        #region Min, Max, Clamp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 Min(Vector4Int32 other) {
            return new Vector4Int32(Math.Min(X, other.X), Math.Min(Y, other.Y), Math.Min(Z, other.Z), Math.Min(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 Max(Vector4Int32 other) {
            return new Vector4Int32(Math.Max(X, other.X), Math.Max(Y, other.Y), Math.Max(Z, other.Z), Math.Max(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 Clamp(int min, int max) {
#if NET5_0_OR_GREATER
            return new Vector4Int32(Math.Clamp(X, min, max), Math.Clamp(Y, min, max), Math.Clamp(Z, min, max), Math.Clamp(W, min, max));
#else
            return new Vector4Int32(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max), Mathi.Clamp(Z, min, max), Mathi.Clamp(W, min, max));
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 Clamp(Vector4Int32 min, Vector4Int32 max) {
#if NET5_0_OR_GREATER
            return new Vector4Int32(Math.Clamp(X, min.X, max.X), Math.Clamp(Y, min.Y, max.Y), Math.Clamp(Z, min.Z, max.Z), Math.Clamp(W, min.W, max.W));
#else
            return new Vector4Int32(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y), Mathi.Clamp(Z, min.Z, max.Z), Mathi.Clamp(W, min.W, max.W));
#endif
        }

        #endregion

        #region Half, Twice, UncheckedComponentsSum

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 Half() => new Vector4Int32(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z), Mathi.Half(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 Twice() => new Vector4Int32(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z), Mathi.Twice(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal int UncheckedComponentsSum() => X + Y + Z + W;

        #endregion

        #region BigMul, Cross, UncheckedDot, (Unchecked)LengthSquared, (Unchecked)Length

        public Vector4Int64 BigMul(int other) {
            return (Vector4Int64)this * other;
        }

        public Vector4Int64 BigMul(Vector4Int32 other) {
            return (Vector4Int64)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long UncheckedDot(Vector4Int32 other) {
            return BigMul(other).UncheckedComponentsSum();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong UncheckedLengthSquared() {
            var abs = UnsignedAbs();
            var sqr = abs.BigMul(abs);
            return sqr.UncheckedComponentsSum();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint UncheckedLength() => (uint)Mathi.Sqrt(UncheckedLengthSquared());

        #endregion

        #region Overflowing

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 WrappingAdd(Vector4Int32 other) {
            return new Vector4Int32(Overflowing.WrappingAdd(X, other.X), Overflowing.WrappingAdd(Y, other.Y), Overflowing.WrappingAdd(Z, other.Z), Overflowing.WrappingAdd(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 WrappingSub(Vector4Int32 other) {
            return new Vector4Int32(Overflowing.WrappingSub(X, other.X), Overflowing.WrappingSub(Y, other.Y), Overflowing.WrappingSub(Z, other.Z), Overflowing.WrappingSub(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 WrappingNeg() {
            return new Vector4Int32(Overflowing.WrappingNeg(X), Overflowing.WrappingNeg(Y), Overflowing.WrappingNeg(Z), Overflowing.WrappingNeg(W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 WrappingAddUnsigned(Vector4UInt32 other) {
            return new Vector4Int32(Overflowing.WrappingAddUnsigned(X, other.X), Overflowing.WrappingAddUnsigned(Y, other.Y), Overflowing.WrappingAddUnsigned(Z, other.Z), Overflowing.WrappingAddUnsigned(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 WrappingSubUnsigned(Vector4UInt32 other) {
            return new Vector4Int32(Overflowing.WrappingSubUnsigned(X, other.X), Overflowing.WrappingSubUnsigned(Y, other.Y), Overflowing.WrappingSubUnsigned(Z, other.Z), Overflowing.WrappingSubUnsigned(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 WrappingAbs() {
            return new Vector4Int32(Overflowing.WrappingAbs(X), Overflowing.WrappingAbs(Y), Overflowing.WrappingAbs(Z), Overflowing.WrappingAbs(W));
        }

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 XX() => new Vector2Int32(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 XY() => new Vector2Int32(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 XZ() => new Vector2Int32(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 XW() => new Vector2Int32(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 YX() => new Vector2Int32(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 YY() => new Vector2Int32(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 YZ() => new Vector2Int32(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 YW() => new Vector2Int32(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 ZX() => new Vector2Int32(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 ZY() => new Vector2Int32(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 ZZ() => new Vector2Int32(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 ZW() => new Vector2Int32(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 WX() => new Vector2Int32(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 WY() => new Vector2Int32(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 WZ() => new Vector2Int32(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 WW() => new Vector2Int32(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XXX() => new Vector3Int32(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XXY() => new Vector3Int32(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XXZ() => new Vector3Int32(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XXW() => new Vector3Int32(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XYX() => new Vector3Int32(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XYY() => new Vector3Int32(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XYZ() => new Vector3Int32(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XYW() => new Vector3Int32(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XZX() => new Vector3Int32(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XZY() => new Vector3Int32(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XZZ() => new Vector3Int32(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XZW() => new Vector3Int32(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XWX() => new Vector3Int32(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XWY() => new Vector3Int32(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XWZ() => new Vector3Int32(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XWW() => new Vector3Int32(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YXX() => new Vector3Int32(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YXY() => new Vector3Int32(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YXZ() => new Vector3Int32(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YXW() => new Vector3Int32(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YYX() => new Vector3Int32(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YYY() => new Vector3Int32(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YYZ() => new Vector3Int32(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YYW() => new Vector3Int32(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YZX() => new Vector3Int32(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YZY() => new Vector3Int32(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YZZ() => new Vector3Int32(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YZW() => new Vector3Int32(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YWX() => new Vector3Int32(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YWY() => new Vector3Int32(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YWZ() => new Vector3Int32(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YWW() => new Vector3Int32(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZXX() => new Vector3Int32(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZXY() => new Vector3Int32(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZXZ() => new Vector3Int32(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZXW() => new Vector3Int32(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZYX() => new Vector3Int32(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZYY() => new Vector3Int32(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZYZ() => new Vector3Int32(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZYW() => new Vector3Int32(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZZX() => new Vector3Int32(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZZY() => new Vector3Int32(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZZZ() => new Vector3Int32(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZZW() => new Vector3Int32(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZWX() => new Vector3Int32(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZWY() => new Vector3Int32(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZWZ() => new Vector3Int32(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZWW() => new Vector3Int32(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 WXX() => new Vector3Int32(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 WXY() => new Vector3Int32(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 WXZ() => new Vector3Int32(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 WXW() => new Vector3Int32(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 WYX() => new Vector3Int32(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 WYY() => new Vector3Int32(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 WYZ() => new Vector3Int32(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 WYW() => new Vector3Int32(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 WZX() => new Vector3Int32(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 WZY() => new Vector3Int32(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 WZZ() => new Vector3Int32(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 WZW() => new Vector3Int32(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 WWX() => new Vector3Int32(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 WWY() => new Vector3Int32(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 WWZ() => new Vector3Int32(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 WWW() => new Vector3Int32(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXXX() => new Vector4Int32(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXXY() => new Vector4Int32(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXXZ() => new Vector4Int32(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXXW() => new Vector4Int32(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXYX() => new Vector4Int32(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXYY() => new Vector4Int32(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXYZ() => new Vector4Int32(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXYW() => new Vector4Int32(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXZX() => new Vector4Int32(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXZY() => new Vector4Int32(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXZZ() => new Vector4Int32(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXZW() => new Vector4Int32(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXWX() => new Vector4Int32(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXWY() => new Vector4Int32(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXWZ() => new Vector4Int32(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXWW() => new Vector4Int32(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYXX() => new Vector4Int32(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYXY() => new Vector4Int32(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYXZ() => new Vector4Int32(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYXW() => new Vector4Int32(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYYX() => new Vector4Int32(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYYY() => new Vector4Int32(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYYZ() => new Vector4Int32(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYYW() => new Vector4Int32(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYZX() => new Vector4Int32(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYZY() => new Vector4Int32(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYZZ() => new Vector4Int32(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYZW() => new Vector4Int32(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYWX() => new Vector4Int32(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYWY() => new Vector4Int32(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYWZ() => new Vector4Int32(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYWW() => new Vector4Int32(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZXX() => new Vector4Int32(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZXY() => new Vector4Int32(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZXZ() => new Vector4Int32(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZXW() => new Vector4Int32(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZYX() => new Vector4Int32(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZYY() => new Vector4Int32(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZYZ() => new Vector4Int32(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZYW() => new Vector4Int32(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZZX() => new Vector4Int32(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZZY() => new Vector4Int32(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZZZ() => new Vector4Int32(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZZW() => new Vector4Int32(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZWX() => new Vector4Int32(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZWY() => new Vector4Int32(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZWZ() => new Vector4Int32(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZWW() => new Vector4Int32(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XWXX() => new Vector4Int32(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XWXY() => new Vector4Int32(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XWXZ() => new Vector4Int32(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XWXW() => new Vector4Int32(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XWYX() => new Vector4Int32(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XWYY() => new Vector4Int32(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XWYZ() => new Vector4Int32(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XWYW() => new Vector4Int32(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XWZX() => new Vector4Int32(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XWZY() => new Vector4Int32(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XWZZ() => new Vector4Int32(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XWZW() => new Vector4Int32(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XWWX() => new Vector4Int32(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XWWY() => new Vector4Int32(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XWWZ() => new Vector4Int32(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XWWW() => new Vector4Int32(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXXX() => new Vector4Int32(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXXY() => new Vector4Int32(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXXZ() => new Vector4Int32(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXXW() => new Vector4Int32(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXYX() => new Vector4Int32(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXYY() => new Vector4Int32(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXYZ() => new Vector4Int32(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXYW() => new Vector4Int32(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXZX() => new Vector4Int32(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXZY() => new Vector4Int32(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXZZ() => new Vector4Int32(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXZW() => new Vector4Int32(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXWX() => new Vector4Int32(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXWY() => new Vector4Int32(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXWZ() => new Vector4Int32(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXWW() => new Vector4Int32(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYXX() => new Vector4Int32(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYXY() => new Vector4Int32(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYXZ() => new Vector4Int32(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYXW() => new Vector4Int32(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYYX() => new Vector4Int32(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYYY() => new Vector4Int32(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYYZ() => new Vector4Int32(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYYW() => new Vector4Int32(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYZX() => new Vector4Int32(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYZY() => new Vector4Int32(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYZZ() => new Vector4Int32(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYZW() => new Vector4Int32(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYWX() => new Vector4Int32(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYWY() => new Vector4Int32(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYWZ() => new Vector4Int32(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYWW() => new Vector4Int32(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZXX() => new Vector4Int32(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZXY() => new Vector4Int32(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZXZ() => new Vector4Int32(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZXW() => new Vector4Int32(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZYX() => new Vector4Int32(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZYY() => new Vector4Int32(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZYZ() => new Vector4Int32(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZYW() => new Vector4Int32(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZZX() => new Vector4Int32(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZZY() => new Vector4Int32(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZZZ() => new Vector4Int32(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZZW() => new Vector4Int32(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZWX() => new Vector4Int32(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZWY() => new Vector4Int32(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZWZ() => new Vector4Int32(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZWW() => new Vector4Int32(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YWXX() => new Vector4Int32(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YWXY() => new Vector4Int32(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YWXZ() => new Vector4Int32(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YWXW() => new Vector4Int32(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YWYX() => new Vector4Int32(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YWYY() => new Vector4Int32(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YWYZ() => new Vector4Int32(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YWYW() => new Vector4Int32(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YWZX() => new Vector4Int32(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YWZY() => new Vector4Int32(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YWZZ() => new Vector4Int32(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YWZW() => new Vector4Int32(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YWWX() => new Vector4Int32(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YWWY() => new Vector4Int32(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YWWZ() => new Vector4Int32(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YWWW() => new Vector4Int32(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXXX() => new Vector4Int32(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXXY() => new Vector4Int32(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXXZ() => new Vector4Int32(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXXW() => new Vector4Int32(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXYX() => new Vector4Int32(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXYY() => new Vector4Int32(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXYZ() => new Vector4Int32(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXYW() => new Vector4Int32(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXZX() => new Vector4Int32(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXZY() => new Vector4Int32(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXZZ() => new Vector4Int32(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXZW() => new Vector4Int32(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXWX() => new Vector4Int32(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXWY() => new Vector4Int32(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXWZ() => new Vector4Int32(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXWW() => new Vector4Int32(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYXX() => new Vector4Int32(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYXY() => new Vector4Int32(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYXZ() => new Vector4Int32(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYXW() => new Vector4Int32(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYYX() => new Vector4Int32(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYYY() => new Vector4Int32(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYYZ() => new Vector4Int32(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYYW() => new Vector4Int32(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYZX() => new Vector4Int32(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYZY() => new Vector4Int32(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYZZ() => new Vector4Int32(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYZW() => new Vector4Int32(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYWX() => new Vector4Int32(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYWY() => new Vector4Int32(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYWZ() => new Vector4Int32(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYWW() => new Vector4Int32(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZXX() => new Vector4Int32(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZXY() => new Vector4Int32(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZXZ() => new Vector4Int32(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZXW() => new Vector4Int32(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZYX() => new Vector4Int32(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZYY() => new Vector4Int32(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZYZ() => new Vector4Int32(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZYW() => new Vector4Int32(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZZX() => new Vector4Int32(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZZY() => new Vector4Int32(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZZZ() => new Vector4Int32(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZZW() => new Vector4Int32(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZWX() => new Vector4Int32(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZWY() => new Vector4Int32(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZWZ() => new Vector4Int32(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZWW() => new Vector4Int32(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZWXX() => new Vector4Int32(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZWXY() => new Vector4Int32(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZWXZ() => new Vector4Int32(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZWXW() => new Vector4Int32(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZWYX() => new Vector4Int32(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZWYY() => new Vector4Int32(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZWYZ() => new Vector4Int32(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZWYW() => new Vector4Int32(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZWZX() => new Vector4Int32(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZWZY() => new Vector4Int32(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZWZZ() => new Vector4Int32(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZWZW() => new Vector4Int32(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZWWX() => new Vector4Int32(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZWWY() => new Vector4Int32(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZWWZ() => new Vector4Int32(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZWWW() => new Vector4Int32(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WXXX() => new Vector4Int32(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WXXY() => new Vector4Int32(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WXXZ() => new Vector4Int32(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WXXW() => new Vector4Int32(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WXYX() => new Vector4Int32(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WXYY() => new Vector4Int32(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WXYZ() => new Vector4Int32(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WXYW() => new Vector4Int32(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WXZX() => new Vector4Int32(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WXZY() => new Vector4Int32(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WXZZ() => new Vector4Int32(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WXZW() => new Vector4Int32(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WXWX() => new Vector4Int32(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WXWY() => new Vector4Int32(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WXWZ() => new Vector4Int32(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WXWW() => new Vector4Int32(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WYXX() => new Vector4Int32(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WYXY() => new Vector4Int32(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WYXZ() => new Vector4Int32(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WYXW() => new Vector4Int32(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WYYX() => new Vector4Int32(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WYYY() => new Vector4Int32(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WYYZ() => new Vector4Int32(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WYYW() => new Vector4Int32(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WYZX() => new Vector4Int32(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WYZY() => new Vector4Int32(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WYZZ() => new Vector4Int32(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WYZW() => new Vector4Int32(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WYWX() => new Vector4Int32(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WYWY() => new Vector4Int32(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WYWZ() => new Vector4Int32(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WYWW() => new Vector4Int32(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WZXX() => new Vector4Int32(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WZXY() => new Vector4Int32(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WZXZ() => new Vector4Int32(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WZXW() => new Vector4Int32(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WZYX() => new Vector4Int32(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WZYY() => new Vector4Int32(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WZYZ() => new Vector4Int32(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WZYW() => new Vector4Int32(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WZZX() => new Vector4Int32(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WZZY() => new Vector4Int32(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WZZZ() => new Vector4Int32(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WZZW() => new Vector4Int32(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WZWX() => new Vector4Int32(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WZWY() => new Vector4Int32(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WZWZ() => new Vector4Int32(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WZWW() => new Vector4Int32(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WWXX() => new Vector4Int32(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WWXY() => new Vector4Int32(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WWXZ() => new Vector4Int32(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WWXW() => new Vector4Int32(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WWYX() => new Vector4Int32(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WWYY() => new Vector4Int32(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WWYZ() => new Vector4Int32(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WWYW() => new Vector4Int32(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WWZX() => new Vector4Int32(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WWZY() => new Vector4Int32(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WWZZ() => new Vector4Int32(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WWZW() => new Vector4Int32(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WWWX() => new Vector4Int32(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WWWY() => new Vector4Int32(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WWWZ() => new Vector4Int32(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 WWWW() => new Vector4Int32(W, W, W, W);

        #endregion

    }
} // namespace Intar1991
