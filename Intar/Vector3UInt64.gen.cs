using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector3UInt64 : IEquatable<Vector3UInt64> {

        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public ulong X;
        public ulong Y;
        public ulong Z;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion

        public static explicit operator System.Numerics.Vector3(Vector3UInt64 a) {
            return new System.Numerics.Vector3(a.X, a.Y, a.Z);
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector3(Vector3UInt64 a) {
            return new UnityEngine.Vector3(a.X, a.Y, a.Z);
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float3(Vector3UInt64 a) {
            return new Unity.Mathematics.float3(a.X, a.Y, a.Z);
        }
#endif

        public Vector3UInt64(ulong x, ulong y, ulong z) {
            X = x;
            Y = y;
            Z = z;
        }

        public ulong this[int index] {
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

        #region IComparisonOperators, IEqualityOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <(Vector3UInt64 left, Vector3UInt64 right) {
            return new Vector3Bool(left.X < right.X, left.Y < right.Y, left.Z < right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <(ulong left, Vector3UInt64 right) {
            return new Vector3Bool(left < right.X, left < right.Y, left < right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <(Vector3UInt64 left, ulong right) {
            return new Vector3Bool(left.X < right, left.Y < right, left.Z < right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >(Vector3UInt64 left, Vector3UInt64 right) {
            return new Vector3Bool(left.X > right.X, left.Y > right.Y, left.Z > right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >(ulong left, Vector3UInt64 right) {
            return new Vector3Bool(left > right.X, left > right.Y, left > right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >(Vector3UInt64 left, ulong right) {
            return new Vector3Bool(left.X > right, left.Y > right, left.Z > right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <=(Vector3UInt64 left, Vector3UInt64 right) {
            return new Vector3Bool(left.X <= right.X, left.Y <= right.Y, left.Z <= right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <=(ulong left, Vector3UInt64 right) {
            return new Vector3Bool(left <= right.X, left <= right.Y, left <= right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <=(Vector3UInt64 left, ulong right) {
            return new Vector3Bool(left.X <= right, left.Y <= right, left.Z <= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >=(Vector3UInt64 left, Vector3UInt64 right) {
            return new Vector3Bool(left.X >= right.X, left.Y >= right.Y, left.Z >= right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >=(ulong left, Vector3UInt64 right) {
            return new Vector3Bool(left >= right.X, left >= right.Y, left >= right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >=(Vector3UInt64 left, ulong right) {
            return new Vector3Bool(left.X >= right, left.Y >= right, left.Z >= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3UInt64 left, Vector3UInt64 right) {
            return new Vector3Bool(left.X == right.X, left.Y == right.Y, left.Z == right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(ulong left, Vector3UInt64 right) {
            return new Vector3Bool(left == right.X, left == right.Y, left == right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3UInt64 left, ulong right) {
            return new Vector3Bool(left.X == right, left.Y == right, left.Z == right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3UInt64 left, Vector3UInt64 right) {
            return new Vector3Bool(left.X != right.X, left.Y != right.Y, left.Z != right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(ulong left, Vector3UInt64 right) {
            return new Vector3Bool(left != right.X, left != right.Y, left != right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3UInt64 left, ulong right) {
            return new Vector3Bool(left.X != right, left.Y != right, left.Z != right);
        }

        #endregion

        #region IShiftOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator <<(Vector3UInt64 left, int right) {
            return new Vector3UInt64(left.X << right, left.Y << right, left.Z << right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator >>(Vector3UInt64 left, int right) {
            return new Vector3UInt64(left.X >> right, left.Y >> right, left.Z >> right);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator >>>(Vector3UInt64 left, int right) {
            return new Vector3UInt64(left.X >>> right, left.Y >>> right, left.Z >>> right);
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3UInt64 other) {
            return X == other.X && Y == other.Y && Z == other.Z;
        }

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is Vector3UInt64 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        #endregion

        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator +(Vector3UInt64 left, Vector3UInt64 right) {
            return new Vector3UInt64(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator +(Vector3UInt64 left, ulong right) {
            return new Vector3UInt64(left.X + right, left.Y + right, left.Z + right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator +(ulong left, Vector3UInt64 right) {
            return new Vector3UInt64(left + right.X, left + right.Y, left + right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator -(Vector3UInt64 left, Vector3UInt64 right) {
            return new Vector3UInt64(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator -(Vector3UInt64 left, ulong right) {
            return new Vector3UInt64(left.X - right, left.Y - right, left.Z - right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator -(ulong left, Vector3UInt64 right) {
            return new Vector3UInt64(left - right.X, left - right.Y, left - right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator *(Vector3UInt64 left, Vector3UInt64 right) {
            return new Vector3UInt64(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator *(Vector3UInt64 left, ulong right) {
            return new Vector3UInt64(left.X * right, left.Y * right, left.Z * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator *(ulong left, Vector3UInt64 right) {
            return new Vector3UInt64(left * right.X, left * right.Y, left * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator /(Vector3UInt64 left, Vector3UInt64 right) {
            return new Vector3UInt64(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator /(Vector3UInt64 left, ulong right) {
            return new Vector3UInt64(left.X / right, left.Y / right, left.Z / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator /(ulong left, Vector3UInt64 right) {
            return new Vector3UInt64(left / right.X, left / right.Y, left / right.Z);
        }

        #endregion

        #region IUnaryPlusOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator +(Vector3UInt64 x) {
            return new Vector3UInt64(+x.X, +x.Y, +x.Z);
        }

        #endregion

        #region Conversion Operators

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3Int32(Vector3UInt64 a) {
            return new Vector3Int32((int)a.X, (int)a.Y, (int)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt32(Vector3UInt64 a) {
            return new Vector3UInt32((uint)a.X, (uint)a.Y, (uint)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3Int64(Vector3UInt64 a) {
            return new Vector3Int64((long)a.X, (long)a.Y, (long)a.Z);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector3Int128(Vector3UInt64 a) {
            return new Vector3Int128((Int128)a.X, (Int128)a.Y, (Int128)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector3UInt128(Vector3UInt64 a) {
            return new Vector3UInt128((UInt128)a.X, (UInt128)a.Y, (UInt128)a.Z);
        }

#endif // NET7_0_OR_GREATER

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        #endregion

        #region IsNegative, Abs, UnsignedAbs, IsNegativeAndUnsignedAbs

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Bool IsNegative() {
            return new Vector3Bool(X < 0, Y < 0, Z < 0);
        }

        // 符号なしベクトル型に対しては Abs, UnsignedAbs は定義しない.

        #endregion

        #region Min, Max, MaxComponent, Clamp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 Min(Vector3UInt64 other) {
            return new Vector3UInt64(Math.Min(X, other.X), Math.Min(Y, other.Y), Math.Min(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 Max(Vector3UInt64 other) {
            return new Vector3UInt64(Math.Max(X, other.X), Math.Max(Y, other.Y), Math.Max(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal ulong MaxComponent() {
            return Math.Max(Math.Max(X, Y), Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 Clamp(ulong min, ulong max) {
#if NET5_0_OR_GREATER
            return new Vector3UInt64(Math.Clamp(X, min, max), Math.Clamp(Y, min, max), Math.Clamp(Z, min, max));
#else
            return new Vector3UInt64(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max), Mathi.Clamp(Z, min, max));
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 Clamp(Vector3UInt64 min, Vector3UInt64 max) {
#if NET5_0_OR_GREATER
            return new Vector3UInt64(Math.Clamp(X, min.X, max.X), Math.Clamp(Y, min.Y, max.Y), Math.Clamp(Z, min.Z, max.Z));
#else
            return new Vector3UInt64(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y), Mathi.Clamp(Z, min.Z, max.Z));
#endif
        }

        #endregion

        #region Half, Twice, ComponentsSum

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 Half() => new Vector3UInt64(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 Twice() => new Vector3UInt64(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal ulong ComponentsSum() => X + Y + Z;

        #endregion

        #region BigMul, Cross, Dot, LengthSquared, Length, HalfLength

#if NET7_0_OR_GREATER

        public Vector3UInt128 BigMul(ulong other) {
            return (Vector3UInt128)this * other;
        }

        public Vector3UInt128 BigMul(Vector3UInt64 other) {
            return (Vector3UInt128)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt128 Dot(Vector3UInt64 other) {
            return BigMul(other).ComponentsSum();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt128 LengthSquared() {
            var sqr = BigMul(this);
            return sqr.ComponentsSum();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Length() => (ulong)Mathi.Sqrt(LengthSquared());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal ulong HalfLength() {
            var sqr = BigMul(this);
            return (ulong)Mathi.Sqrt((sqr / 4).ComponentsSum());
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region Overflowing

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 WrappingAdd(Vector3UInt64 other) {
            return new Vector3UInt64(Overflowing.WrappingAdd(X, other.X), Overflowing.WrappingAdd(Y, other.Y), Overflowing.WrappingAdd(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 WrappingSub(Vector3UInt64 other) {
            return new Vector3UInt64(Overflowing.WrappingSub(X, other.X), Overflowing.WrappingSub(Y, other.Y), Overflowing.WrappingSub(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 WrappingNeg() {
            return new Vector3UInt64(Overflowing.WrappingNeg(X), Overflowing.WrappingNeg(Y), Overflowing.WrappingNeg(Z));
        }

        // Rust に倣って WrappingAddSigned のみを定義し
        // WrappingSubSigned は定義しない.
        // https://doc.rust-lang.org/std/primitive.u32.html#method.wrapping_add_signed

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 WrappingAddSigned(Vector3Int64 other) {
            return new Vector3UInt64(Overflowing.WrappingAddSigned(X, other.X), Overflowing.WrappingAddSigned(Y, other.Y), Overflowing.WrappingAddSigned(Z, other.Z));
        }

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 XX() => new Vector2UInt64(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 XY() => new Vector2UInt64(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 XZ() => new Vector2UInt64(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 YX() => new Vector2UInt64(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 YY() => new Vector2UInt64(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 YZ() => new Vector2UInt64(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 ZX() => new Vector2UInt64(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 ZY() => new Vector2UInt64(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 ZZ() => new Vector2UInt64(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XXX() => new Vector3UInt64(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XXY() => new Vector3UInt64(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XXZ() => new Vector3UInt64(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XYX() => new Vector3UInt64(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XYY() => new Vector3UInt64(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XYZ() => new Vector3UInt64(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XZX() => new Vector3UInt64(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XZY() => new Vector3UInt64(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XZZ() => new Vector3UInt64(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YXX() => new Vector3UInt64(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YXY() => new Vector3UInt64(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YXZ() => new Vector3UInt64(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YYX() => new Vector3UInt64(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YYY() => new Vector3UInt64(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YYZ() => new Vector3UInt64(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YZX() => new Vector3UInt64(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YZY() => new Vector3UInt64(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YZZ() => new Vector3UInt64(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZXX() => new Vector3UInt64(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZXY() => new Vector3UInt64(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZXZ() => new Vector3UInt64(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZYX() => new Vector3UInt64(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZYY() => new Vector3UInt64(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZYZ() => new Vector3UInt64(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZZX() => new Vector3UInt64(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZZY() => new Vector3UInt64(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 ZZZ() => new Vector3UInt64(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXXX() => new Vector4UInt64(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXXY() => new Vector4UInt64(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXXZ() => new Vector4UInt64(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXYX() => new Vector4UInt64(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXYY() => new Vector4UInt64(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXYZ() => new Vector4UInt64(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXZX() => new Vector4UInt64(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXZY() => new Vector4UInt64(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXZZ() => new Vector4UInt64(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYXX() => new Vector4UInt64(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYXY() => new Vector4UInt64(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYXZ() => new Vector4UInt64(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYYX() => new Vector4UInt64(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYYY() => new Vector4UInt64(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYYZ() => new Vector4UInt64(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYZX() => new Vector4UInt64(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYZY() => new Vector4UInt64(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYZZ() => new Vector4UInt64(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZXX() => new Vector4UInt64(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZXY() => new Vector4UInt64(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZXZ() => new Vector4UInt64(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZYX() => new Vector4UInt64(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZYY() => new Vector4UInt64(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZYZ() => new Vector4UInt64(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZZX() => new Vector4UInt64(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZZY() => new Vector4UInt64(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XZZZ() => new Vector4UInt64(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXXX() => new Vector4UInt64(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXXY() => new Vector4UInt64(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXXZ() => new Vector4UInt64(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXYX() => new Vector4UInt64(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXYY() => new Vector4UInt64(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXYZ() => new Vector4UInt64(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXZX() => new Vector4UInt64(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXZY() => new Vector4UInt64(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXZZ() => new Vector4UInt64(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYXX() => new Vector4UInt64(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYXY() => new Vector4UInt64(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYXZ() => new Vector4UInt64(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYYX() => new Vector4UInt64(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYYY() => new Vector4UInt64(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYYZ() => new Vector4UInt64(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYZX() => new Vector4UInt64(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYZY() => new Vector4UInt64(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYZZ() => new Vector4UInt64(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZXX() => new Vector4UInt64(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZXY() => new Vector4UInt64(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZXZ() => new Vector4UInt64(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZYX() => new Vector4UInt64(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZYY() => new Vector4UInt64(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZYZ() => new Vector4UInt64(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZZX() => new Vector4UInt64(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZZY() => new Vector4UInt64(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YZZZ() => new Vector4UInt64(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXXX() => new Vector4UInt64(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXXY() => new Vector4UInt64(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXXZ() => new Vector4UInt64(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXYX() => new Vector4UInt64(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXYY() => new Vector4UInt64(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXYZ() => new Vector4UInt64(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXZX() => new Vector4UInt64(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXZY() => new Vector4UInt64(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZXZZ() => new Vector4UInt64(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYXX() => new Vector4UInt64(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYXY() => new Vector4UInt64(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYXZ() => new Vector4UInt64(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYYX() => new Vector4UInt64(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYYY() => new Vector4UInt64(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYYZ() => new Vector4UInt64(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYZX() => new Vector4UInt64(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYZY() => new Vector4UInt64(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZYZZ() => new Vector4UInt64(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZXX() => new Vector4UInt64(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZXY() => new Vector4UInt64(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZXZ() => new Vector4UInt64(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZYX() => new Vector4UInt64(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZYY() => new Vector4UInt64(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZYZ() => new Vector4UInt64(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZZX() => new Vector4UInt64(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZZY() => new Vector4UInt64(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 ZZZZ() => new Vector4UInt64(Z, Z, Z, Z);

        #endregion

    }
} // namespace Intar
