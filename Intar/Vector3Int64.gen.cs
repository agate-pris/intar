using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector3Int64 : IEquatable<Vector3Int64> {

        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public long X;
        public long Y;
        public long Z;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion

        public static explicit operator System.Numerics.Vector3(Vector3Int64 a) {
            return new System.Numerics.Vector3(a.X, a.Y, a.Z);
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector3(Vector3Int64 a) {
            return new UnityEngine.Vector3(a.X, a.Y, a.Z);
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float3(Vector3Int64 a) {
            return new Unity.Mathematics.float3(a.X, a.Y, a.Z);
        }
#endif

        public Vector3Int64(long x, long y, long z) {
            X = x;
            Y = y;
            Z = z;
        }

        public long this[int index] {
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
        public static Vector3Bool operator <(Vector3Int64 left, Vector3Int64 right) {
            return new Vector3Bool(left.X < right.X, left.Y < right.Y, left.Z < right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <(long left, Vector3Int64 right) {
            return new Vector3Bool(left < right.X, left < right.Y, left < right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <(Vector3Int64 left, long right) {
            return new Vector3Bool(left.X < right, left.Y < right, left.Z < right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >(Vector3Int64 left, Vector3Int64 right) {
            return new Vector3Bool(left.X > right.X, left.Y > right.Y, left.Z > right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >(long left, Vector3Int64 right) {
            return new Vector3Bool(left > right.X, left > right.Y, left > right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >(Vector3Int64 left, long right) {
            return new Vector3Bool(left.X > right, left.Y > right, left.Z > right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <=(Vector3Int64 left, Vector3Int64 right) {
            return new Vector3Bool(left.X <= right.X, left.Y <= right.Y, left.Z <= right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <=(long left, Vector3Int64 right) {
            return new Vector3Bool(left <= right.X, left <= right.Y, left <= right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <=(Vector3Int64 left, long right) {
            return new Vector3Bool(left.X <= right, left.Y <= right, left.Z <= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >=(Vector3Int64 left, Vector3Int64 right) {
            return new Vector3Bool(left.X >= right.X, left.Y >= right.Y, left.Z >= right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >=(long left, Vector3Int64 right) {
            return new Vector3Bool(left >= right.X, left >= right.Y, left >= right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >=(Vector3Int64 left, long right) {
            return new Vector3Bool(left.X >= right, left.Y >= right, left.Z >= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3Int64 left, Vector3Int64 right) {
            return new Vector3Bool(left.X == right.X, left.Y == right.Y, left.Z == right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(long left, Vector3Int64 right) {
            return new Vector3Bool(left == right.X, left == right.Y, left == right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3Int64 left, long right) {
            return new Vector3Bool(left.X == right, left.Y == right, left.Z == right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3Int64 left, Vector3Int64 right) {
            return new Vector3Bool(left.X != right.X, left.Y != right.Y, left.Z != right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(long left, Vector3Int64 right) {
            return new Vector3Bool(left != right.X, left != right.Y, left != right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3Int64 left, long right) {
            return new Vector3Bool(left.X != right, left.Y != right, left.Z != right);
        }

        #endregion

        #region IShiftOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator <<(Vector3Int64 left, int right) {
            return new Vector3Int64(left.X << right, left.Y << right, left.Z << right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator >>(Vector3Int64 left, int right) {
            return new Vector3Int64(left.X >> right, left.Y >> right, left.Z >> right);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator >>>(Vector3Int64 left, int right) {
            return new Vector3Int64(left.X >>> right, left.Y >>> right, left.Z >>> right);
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3Int64 other) {
            return X == other.X && Y == other.Y && Z == other.Z;
        }

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is Vector3Int64 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        #endregion

        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator +(Vector3Int64 left, Vector3Int64 right) {
            return new Vector3Int64(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator +(Vector3Int64 left, long right) {
            return new Vector3Int64(left.X + right, left.Y + right, left.Z + right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator +(long left, Vector3Int64 right) {
            return new Vector3Int64(left + right.X, left + right.Y, left + right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator -(Vector3Int64 left, Vector3Int64 right) {
            return new Vector3Int64(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator -(Vector3Int64 left, long right) {
            return new Vector3Int64(left.X - right, left.Y - right, left.Z - right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator -(long left, Vector3Int64 right) {
            return new Vector3Int64(left - right.X, left - right.Y, left - right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator *(Vector3Int64 left, Vector3Int64 right) {
            return new Vector3Int64(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator *(Vector3Int64 left, long right) {
            return new Vector3Int64(left.X * right, left.Y * right, left.Z * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator *(long left, Vector3Int64 right) {
            return new Vector3Int64(left * right.X, left * right.Y, left * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator /(Vector3Int64 left, Vector3Int64 right) {
            return new Vector3Int64(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator /(Vector3Int64 left, long right) {
            return new Vector3Int64(left.X / right, left.Y / right, left.Z / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator /(long left, Vector3Int64 right) {
            return new Vector3Int64(left / right.X, left / right.Y, left / right.Z);
        }

        #endregion

        #region IUnaryPlusOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator +(Vector3Int64 x) {
            return new Vector3Int64(+x.X, +x.Y, +x.Z);
        }

        #endregion

        #region IUnarryNegationOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator -(Vector3Int64 x) {
            return new Vector3Int64(-x.X, -x.Y, -x.Z);
        }

        #endregion

        #region Conversion Operators

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3Int32(Vector3Int64 a) {
            return new Vector3Int32((int)a.X, (int)a.Y, (int)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt32(Vector3Int64 a) {
            return new Vector3UInt32((uint)a.X, (uint)a.Y, (uint)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt64(Vector3Int64 a) {
            return new Vector3UInt64((ulong)a.X, (ulong)a.Y, (ulong)a.Z);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector3Int128(Vector3Int64 a) {
            return new Vector3Int128((Int128)a.X, (Int128)a.Y, (Int128)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt128(Vector3Int64 a) {
            return new Vector3UInt128((UInt128)a.X, (UInt128)a.Y, (UInt128)a.Z);
        }

#endif // NET7_0_OR_GREATER

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        #endregion

        #region IsNegative, Abs, UnsignedAbs, IsNegativeAndUnsignedAbs, AbsDiff

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Bool IsNegative() {
            return new Vector3Bool(X < 0, Y < 0, Z < 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 Abs() => new Vector3Int64(Math.Abs(X), Math.Abs(Y), Math.Abs(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 UnsignedAbs() {
            var isNegative = IsNegative();
            return new Vector3UInt64(
                unchecked((ulong)(isNegative.X ? Overflowing.WrappingNeg(X) : X)),
                unchecked((ulong)(isNegative.Y ? Overflowing.WrappingNeg(Y) : Y)),
                unchecked((ulong)(isNegative.Z ? Overflowing.WrappingNeg(Z) : Z))
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal (Vector3Bool isNegative, Vector3UInt64 unsignedAbs) IsNegativeAndUnsignedAbs() {
            var isNegative = IsNegative();
            var unsignedAbs = new Vector3UInt64(
                unchecked((ulong)(isNegative.X ? Overflowing.WrappingNeg(X) : X)),
                unchecked((ulong)(isNegative.Y ? Overflowing.WrappingNeg(Y) : Y)),
                unchecked((ulong)(isNegative.Z ? Overflowing.WrappingNeg(Z) : Z))
            );
            return (isNegative, unsignedAbs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 AbsDiff(Vector3Int64 other) {
            return new Vector3UInt64(
                Mathi.AbsDiff(X, other.X),
                Mathi.AbsDiff(Y, other.Y),
                Mathi.AbsDiff(Z, other.Z)
            );
        }
        #endregion

        #region Min, Max, MaxComponent, Clamp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 Min(Vector3Int64 other) {
            return new Vector3Int64(Math.Min(X, other.X), Math.Min(Y, other.Y), Math.Min(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 Max(Vector3Int64 other) {
            return new Vector3Int64(Math.Max(X, other.X), Math.Max(Y, other.Y), Math.Max(Z, other.Z));
        }

        // MaxComponent は符号なしの場合のみ定義する。

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 Clamp(long min, long max) {
#if NET5_0_OR_GREATER
            return new Vector3Int64(Math.Clamp(X, min, max), Math.Clamp(Y, min, max), Math.Clamp(Z, min, max));
#else
            return new Vector3Int64(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max), Mathi.Clamp(Z, min, max));
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 Clamp(Vector3Int64 min, Vector3Int64 max) {
#if NET5_0_OR_GREATER
            return new Vector3Int64(Math.Clamp(X, min.X, max.X), Math.Clamp(Y, min.Y, max.Y), Math.Clamp(Z, min.Z, max.Z));
#else
            return new Vector3Int64(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y), Mathi.Clamp(Z, min.Z, max.Z));
#endif
        }

        #endregion

        #region Half, Twice, ComponentsSum

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 Half() => new Vector3Int64(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 Twice() => new Vector3Int64(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal long ComponentsSum() => X + Y + Z;

        #endregion

        #region BigMul, Cross, Dot, LengthSquared, Length, HalfLength

#if NET7_0_OR_GREATER

        public Vector3Int128 BigMul(long other) {
            return (Vector3Int128)this * other;
        }

        public Vector3Int128 BigMul(Vector3Int64 other) {
            return (Vector3Int128)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int128 Cross(Vector3Int64 other) {
            // (a1)   (b1)   (a2b3 - a3b2)
            // (a2) x (b2) = (a3b1 - a1b3)
            // (a3)   (b3)   (a1b2 - a2b1)
            return YZX().BigMul(other.ZXY()) - ZXY().BigMul(other.YZX());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int128 Dot(Vector3Int64 other) {
            return BigMul(other).ComponentsSum();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt128 LengthSquared() {
            var abs = UnsignedAbs();
            var sqr = abs.BigMul(abs);
            return sqr.ComponentsSum();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Length() => (ulong)Mathi.Sqrt(LengthSquared());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal ulong HalfLength() {
            var abs = UnsignedAbs();
            var sqr = abs.BigMul(abs);
            return (ulong)Mathi.Sqrt((sqr / 4).ComponentsSum());
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region Overflowing

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 WrappingAdd(Vector3Int64 other) {
            return new Vector3Int64(Overflowing.WrappingAdd(X, other.X), Overflowing.WrappingAdd(Y, other.Y), Overflowing.WrappingAdd(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 WrappingSub(Vector3Int64 other) {
            return new Vector3Int64(Overflowing.WrappingSub(X, other.X), Overflowing.WrappingSub(Y, other.Y), Overflowing.WrappingSub(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 WrappingNeg() {
            return new Vector3Int64(Overflowing.WrappingNeg(X), Overflowing.WrappingNeg(Y), Overflowing.WrappingNeg(Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 WrappingAddUnsigned(Vector3UInt64 other) {
            return new Vector3Int64(Overflowing.WrappingAddUnsigned(X, other.X), Overflowing.WrappingAddUnsigned(Y, other.Y), Overflowing.WrappingAddUnsigned(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 WrappingSubUnsigned(Vector3UInt64 other) {
            return new Vector3Int64(Overflowing.WrappingSubUnsigned(X, other.X), Overflowing.WrappingSubUnsigned(Y, other.Y), Overflowing.WrappingSubUnsigned(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 WrappingAbs() {
            return new Vector3Int64(Overflowing.WrappingAbs(X), Overflowing.WrappingAbs(Y), Overflowing.WrappingAbs(Z));
        }

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 XX() => new Vector2Int64(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 XY() => new Vector2Int64(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 XZ() => new Vector2Int64(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 YX() => new Vector2Int64(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 YY() => new Vector2Int64(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 YZ() => new Vector2Int64(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 ZX() => new Vector2Int64(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 ZY() => new Vector2Int64(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 ZZ() => new Vector2Int64(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XXX() => new Vector3Int64(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XXY() => new Vector3Int64(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XXZ() => new Vector3Int64(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XYX() => new Vector3Int64(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XYY() => new Vector3Int64(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XYZ() => new Vector3Int64(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XZX() => new Vector3Int64(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XZY() => new Vector3Int64(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XZZ() => new Vector3Int64(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YXX() => new Vector3Int64(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YXY() => new Vector3Int64(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YXZ() => new Vector3Int64(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YYX() => new Vector3Int64(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YYY() => new Vector3Int64(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YYZ() => new Vector3Int64(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YZX() => new Vector3Int64(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YZY() => new Vector3Int64(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YZZ() => new Vector3Int64(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZXX() => new Vector3Int64(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZXY() => new Vector3Int64(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZXZ() => new Vector3Int64(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZYX() => new Vector3Int64(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZYY() => new Vector3Int64(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZYZ() => new Vector3Int64(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZZX() => new Vector3Int64(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZZY() => new Vector3Int64(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 ZZZ() => new Vector3Int64(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXXX() => new Vector4Int64(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXXY() => new Vector4Int64(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXXZ() => new Vector4Int64(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXYX() => new Vector4Int64(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXYY() => new Vector4Int64(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXYZ() => new Vector4Int64(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXZX() => new Vector4Int64(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXZY() => new Vector4Int64(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXZZ() => new Vector4Int64(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYXX() => new Vector4Int64(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYXY() => new Vector4Int64(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYXZ() => new Vector4Int64(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYYX() => new Vector4Int64(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYYY() => new Vector4Int64(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYYZ() => new Vector4Int64(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYZX() => new Vector4Int64(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYZY() => new Vector4Int64(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYZZ() => new Vector4Int64(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZXX() => new Vector4Int64(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZXY() => new Vector4Int64(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZXZ() => new Vector4Int64(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZYX() => new Vector4Int64(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZYY() => new Vector4Int64(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZYZ() => new Vector4Int64(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZZX() => new Vector4Int64(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZZY() => new Vector4Int64(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XZZZ() => new Vector4Int64(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXXX() => new Vector4Int64(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXXY() => new Vector4Int64(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXXZ() => new Vector4Int64(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXYX() => new Vector4Int64(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXYY() => new Vector4Int64(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXYZ() => new Vector4Int64(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXZX() => new Vector4Int64(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXZY() => new Vector4Int64(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXZZ() => new Vector4Int64(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYXX() => new Vector4Int64(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYXY() => new Vector4Int64(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYXZ() => new Vector4Int64(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYYX() => new Vector4Int64(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYYY() => new Vector4Int64(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYYZ() => new Vector4Int64(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYZX() => new Vector4Int64(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYZY() => new Vector4Int64(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYZZ() => new Vector4Int64(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZXX() => new Vector4Int64(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZXY() => new Vector4Int64(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZXZ() => new Vector4Int64(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZYX() => new Vector4Int64(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZYY() => new Vector4Int64(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZYZ() => new Vector4Int64(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZZX() => new Vector4Int64(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZZY() => new Vector4Int64(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YZZZ() => new Vector4Int64(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXXX() => new Vector4Int64(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXXY() => new Vector4Int64(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXXZ() => new Vector4Int64(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXYX() => new Vector4Int64(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXYY() => new Vector4Int64(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXYZ() => new Vector4Int64(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXZX() => new Vector4Int64(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXZY() => new Vector4Int64(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZXZZ() => new Vector4Int64(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYXX() => new Vector4Int64(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYXY() => new Vector4Int64(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYXZ() => new Vector4Int64(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYYX() => new Vector4Int64(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYYY() => new Vector4Int64(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYYZ() => new Vector4Int64(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYZX() => new Vector4Int64(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYZY() => new Vector4Int64(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZYZZ() => new Vector4Int64(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZXX() => new Vector4Int64(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZXY() => new Vector4Int64(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZXZ() => new Vector4Int64(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZYX() => new Vector4Int64(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZYY() => new Vector4Int64(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZYZ() => new Vector4Int64(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZZX() => new Vector4Int64(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZZY() => new Vector4Int64(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 ZZZZ() => new Vector4Int64(Z, Z, Z, Z);

        #endregion

    }
} // namespace Intar
