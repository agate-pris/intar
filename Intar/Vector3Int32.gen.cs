using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector3Int32 : IEquatable<Vector3Int32> {
        #region X, Y, Z

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public int X;
        public int Y;
        public int Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        #region Conversion
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator System.Numerics.Vector3(Vector3Int32 a) {
            return new System.Numerics.Vector3(a.X, a.Y, a.Z);
        }

#if UNITY_5_3_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UnityEngine.Vector3(Vector3Int32 a) {
            return new UnityEngine.Vector3(a.X, a.Y, a.Z);
        }

#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Unity.Mathematics.float3(Vector3Int32 a) {
            return new Unity.Mathematics.float3(a.X, a.Y, a.Z);
        }

#endif // UNITY_2018_1_OR_NEWER

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32(int x, int y, int z) {
            X = x;
            Y = y;
            Z = z;
        }
        #endregion
        #region Indexer
        public int this[int index] {
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
        #endregion
        #region IComparisonOperators, IEqualityOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <(Vector3Int32 left, Vector3Int32 right) {
            return new Vector3Bool(left.X < right.X, left.Y < right.Y, left.Z < right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <(int left, Vector3Int32 right) {
            return new Vector3Bool(left < right.X, left < right.Y, left < right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <(Vector3Int32 left, int right) {
            return new Vector3Bool(left.X < right, left.Y < right, left.Z < right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >(Vector3Int32 left, Vector3Int32 right) {
            return new Vector3Bool(left.X > right.X, left.Y > right.Y, left.Z > right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >(int left, Vector3Int32 right) {
            return new Vector3Bool(left > right.X, left > right.Y, left > right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >(Vector3Int32 left, int right) {
            return new Vector3Bool(left.X > right, left.Y > right, left.Z > right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <=(Vector3Int32 left, Vector3Int32 right) {
            return new Vector3Bool(left.X <= right.X, left.Y <= right.Y, left.Z <= right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <=(int left, Vector3Int32 right) {
            return new Vector3Bool(left <= right.X, left <= right.Y, left <= right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator <=(Vector3Int32 left, int right) {
            return new Vector3Bool(left.X <= right, left.Y <= right, left.Z <= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >=(Vector3Int32 left, Vector3Int32 right) {
            return new Vector3Bool(left.X >= right.X, left.Y >= right.Y, left.Z >= right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >=(int left, Vector3Int32 right) {
            return new Vector3Bool(left >= right.X, left >= right.Y, left >= right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator >=(Vector3Int32 left, int right) {
            return new Vector3Bool(left.X >= right, left.Y >= right, left.Z >= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3Int32 left, Vector3Int32 right) {
            return new Vector3Bool(left.X == right.X, left.Y == right.Y, left.Z == right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(int left, Vector3Int32 right) {
            return new Vector3Bool(left == right.X, left == right.Y, left == right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3Int32 left, int right) {
            return new Vector3Bool(left.X == right, left.Y == right, left.Z == right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3Int32 left, Vector3Int32 right) {
            return new Vector3Bool(left.X != right.X, left.Y != right.Y, left.Z != right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(int left, Vector3Int32 right) {
            return new Vector3Bool(left != right.X, left != right.Y, left != right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3Int32 left, int right) {
            return new Vector3Bool(left.X != right, left.Y != right, left.Z != right);
        }
        #endregion
        #region IShiftOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator <<(Vector3Int32 left, int right) {
            return new Vector3Int32(left.X << right, left.Y << right, left.Z << right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator >>(Vector3Int32 left, int right) {
            return new Vector3Int32(left.X >> right, left.Y >> right, left.Z >> right);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator >>>(Vector3Int32 left, int right) {
            return new Vector3Int32(left.X >>> right, left.Y >>> right, left.Z >>> right);
        }

#endif // NET7_0_OR_GREATER

        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3Int32 other) {
            return X == other.X && Y == other.Y && Z == other.Z;
        }
        #endregion
        #region Object

        public override bool Equals(object obj) => obj is Vector3Int32 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);
        #endregion
        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator +(Vector3Int32 left, Vector3Int32 right) {
            return new Vector3Int32(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator +(Vector3Int32 left, int right) {
            return new Vector3Int32(left.X + right, left.Y + right, left.Z + right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator +(int left, Vector3Int32 right) {
            return new Vector3Int32(left + right.X, left + right.Y, left + right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator -(Vector3Int32 left, Vector3Int32 right) {
            return new Vector3Int32(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator -(Vector3Int32 left, int right) {
            return new Vector3Int32(left.X - right, left.Y - right, left.Z - right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator -(int left, Vector3Int32 right) {
            return new Vector3Int32(left - right.X, left - right.Y, left - right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator *(Vector3Int32 left, Vector3Int32 right) {
            return new Vector3Int32(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator *(Vector3Int32 left, int right) {
            return new Vector3Int32(left.X * right, left.Y * right, left.Z * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator *(int left, Vector3Int32 right) {
            return new Vector3Int32(left * right.X, left * right.Y, left * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator /(Vector3Int32 left, Vector3Int32 right) {
            return new Vector3Int32(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator /(Vector3Int32 left, int right) {
            return new Vector3Int32(left.X / right, left.Y / right, left.Z / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator /(int left, Vector3Int32 right) {
            return new Vector3Int32(left / right.X, left / right.Y, left / right.Z);
        }
        #endregion
        #region IUnaryPlusOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator +(Vector3Int32 x) {
            return new Vector3Int32(+x.X, +x.Y, +x.Z);
        }
        #endregion
        #region IUnarryNegationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator -(Vector3Int32 x) {
            return new Vector3Int32(-x.X, -x.Y, -x.Z);
        }
        #endregion
        #region Conversion

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt32(Vector3Int32 a) {
            return new Vector3UInt32((uint)a.X, (uint)a.Y, (uint)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector3Int64(Vector3Int32 a) {
            return new Vector3Int64((long)a.X, (long)a.Y, (long)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt64(Vector3Int32 a) {
            return new Vector3UInt64((ulong)a.X, (ulong)a.Y, (ulong)a.Z);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector3Int128(Vector3Int32 a) {
            return new Vector3Int128((Int128)a.X, (Int128)a.Y, (Int128)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt128(Vector3Int32 a) {
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
        public Vector3Int32 Abs() => new Vector3Int32(Math.Abs(X), Math.Abs(Y), Math.Abs(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt32 UnsignedAbs() {
            var isNegative = IsNegative();
            return new Vector3UInt32(
                unchecked((uint)(isNegative.X ? Overflowing.WrappingNeg(X) : X)),
                unchecked((uint)(isNegative.Y ? Overflowing.WrappingNeg(Y) : Y)),
                unchecked((uint)(isNegative.Z ? Overflowing.WrappingNeg(Z) : Z))
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal (Vector3Bool isNegative, Vector3UInt32 unsignedAbs) IsNegativeAndUnsignedAbs() {
            var isNegative = IsNegative();
            var unsignedAbs = new Vector3UInt32(
                unchecked((uint)(isNegative.X ? Overflowing.WrappingNeg(X) : X)),
                unchecked((uint)(isNegative.Y ? Overflowing.WrappingNeg(Y) : Y)),
                unchecked((uint)(isNegative.Z ? Overflowing.WrappingNeg(Z) : Z))
            );
            return (isNegative, unsignedAbs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt32 AbsDiff(Vector3Int32 other) {
            return new Vector3UInt32(
                Mathi.AbsDiff(X, other.X),
                Mathi.AbsDiff(Y, other.Y),
                Mathi.AbsDiff(Z, other.Z)
            );
        }
        #endregion
        #region Min, Max, MaxComponent, Clamp
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 Min(Vector3Int32 other) {
            return new Vector3Int32(Math.Min(X, other.X), Math.Min(Y, other.Y), Math.Min(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 Max(Vector3Int32 other) {
            return new Vector3Int32(Math.Max(X, other.X), Math.Max(Y, other.Y), Math.Max(Z, other.Z));
        }

        // MaxComponent は符号なしの場合のみ定義する。

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 Clamp(int min, int max) {

#if NET5_0_OR_GREATER

            return new Vector3Int32(Math.Clamp(X, min, max), Math.Clamp(Y, min, max), Math.Clamp(Z, min, max));

#else

            return new Vector3Int32(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max), Mathi.Clamp(Z, min, max));

#endif

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 Clamp(Vector3Int32 min, Vector3Int32 max) {

#if NET5_0_OR_GREATER

            return new Vector3Int32(Math.Clamp(X, min.X, max.X), Math.Clamp(Y, min.Y, max.Y), Math.Clamp(Z, min.Z, max.Z));

#else

            return new Vector3Int32(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y), Mathi.Clamp(Z, min.Z, max.Z));

#endif

        }
        #endregion
        #region Half, Twice, ComponentsSum
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 Half() => new Vector3Int32(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 Twice() => new Vector3Int32(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal int ComponentsSum() => X + Y + Z;
        #endregion
        #region BigMul, Cross, Dot, LengthSquared, Length, HalfLength, DistanceSquared, Distance
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 BigMul(int other) {
            return (Vector3Int64)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 BigMul(Vector3Int32 other) {
            return (Vector3Int64)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 Cross(Vector3Int32 other) {
            // (a1)   (b1)   (a2b3 - a3b2)
            // (a2) x (b2) = (a3b1 - a1b3)
            // (a3)   (b3)   (a1b2 - a2b1)
            return YZX().BigMul(other.ZXY()) - ZXY().BigMul(other.YZX());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Dot(Vector3Int32 other) {
            return BigMul(other).ComponentsSum();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong LengthSquared() {
            var abs = UnsignedAbs();
            return abs.LengthSquared();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Length() => (uint)Mathi.Sqrt(LengthSquared());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal uint HalfLength() {
            var abs = UnsignedAbs();
            var sqr = abs.BigMul(abs);
            return (uint)Mathi.Sqrt((sqr / 4).ComponentsSum());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong DistanceSquared(Vector3Int32 other) {
            return AbsDiff(other).LengthSquared();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Distance(Vector3Int32 other) {
            return AbsDiff(other).Length();
        }
        #endregion
        #region Overflowing

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 WrappingAdd(Vector3Int32 other) {
            return new Vector3Int32(Overflowing.WrappingAdd(X, other.X), Overflowing.WrappingAdd(Y, other.Y), Overflowing.WrappingAdd(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 WrappingSub(Vector3Int32 other) {
            return new Vector3Int32(Overflowing.WrappingSub(X, other.X), Overflowing.WrappingSub(Y, other.Y), Overflowing.WrappingSub(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 WrappingNeg() {
            return new Vector3Int32(Overflowing.WrappingNeg(X), Overflowing.WrappingNeg(Y), Overflowing.WrappingNeg(Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 WrappingAddUnsigned(Vector3UInt32 other) {
            return new Vector3Int32(Overflowing.WrappingAddUnsigned(X, other.X), Overflowing.WrappingAddUnsigned(Y, other.Y), Overflowing.WrappingAddUnsigned(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 WrappingSubUnsigned(Vector3UInt32 other) {
            return new Vector3Int32(Overflowing.WrappingSubUnsigned(X, other.X), Overflowing.WrappingSubUnsigned(Y, other.Y), Overflowing.WrappingSubUnsigned(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 WrappingAbs() {
            return new Vector3Int32(Overflowing.WrappingAbs(X), Overflowing.WrappingAbs(Y), Overflowing.WrappingAbs(Z));
        }
        #endregion
        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 X0() => new Vector2Int32(X, 0);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 X1() => new Vector2Int32(X, 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 XX() => new Vector2Int32(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 XY() => new Vector2Int32(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 XZ() => new Vector2Int32(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 YX() => new Vector2Int32(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 YY() => new Vector2Int32(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 YZ() => new Vector2Int32(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 ZX() => new Vector2Int32(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 ZY() => new Vector2Int32(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 ZZ() => new Vector2Int32(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XY0() => new Vector3Int32(X, Y, 0);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XY1() => new Vector3Int32(X, Y, 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XXX() => new Vector3Int32(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XXY() => new Vector3Int32(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XXZ() => new Vector3Int32(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XYX() => new Vector3Int32(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XYY() => new Vector3Int32(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XYZ() => new Vector3Int32(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XZX() => new Vector3Int32(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XZY() => new Vector3Int32(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XZZ() => new Vector3Int32(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YXX() => new Vector3Int32(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YXY() => new Vector3Int32(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YXZ() => new Vector3Int32(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YYX() => new Vector3Int32(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YYY() => new Vector3Int32(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YYZ() => new Vector3Int32(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YZX() => new Vector3Int32(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YZY() => new Vector3Int32(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YZZ() => new Vector3Int32(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZXX() => new Vector3Int32(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZXY() => new Vector3Int32(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZXZ() => new Vector3Int32(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZYX() => new Vector3Int32(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZYY() => new Vector3Int32(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZYZ() => new Vector3Int32(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZZX() => new Vector3Int32(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZZY() => new Vector3Int32(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 ZZZ() => new Vector3Int32(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYZ0() => new Vector4Int32(X, Y, Z, 0);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYZ1() => new Vector4Int32(X, Y, Z, 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXXX() => new Vector4Int32(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXXY() => new Vector4Int32(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXXZ() => new Vector4Int32(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXYX() => new Vector4Int32(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXYY() => new Vector4Int32(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXYZ() => new Vector4Int32(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXZX() => new Vector4Int32(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXZY() => new Vector4Int32(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXZZ() => new Vector4Int32(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYXX() => new Vector4Int32(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYXY() => new Vector4Int32(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYXZ() => new Vector4Int32(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYYX() => new Vector4Int32(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYYY() => new Vector4Int32(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYYZ() => new Vector4Int32(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYZX() => new Vector4Int32(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYZY() => new Vector4Int32(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYZZ() => new Vector4Int32(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZXX() => new Vector4Int32(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZXY() => new Vector4Int32(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZXZ() => new Vector4Int32(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZYX() => new Vector4Int32(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZYY() => new Vector4Int32(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZYZ() => new Vector4Int32(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZZX() => new Vector4Int32(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZZY() => new Vector4Int32(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XZZZ() => new Vector4Int32(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXXX() => new Vector4Int32(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXXY() => new Vector4Int32(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXXZ() => new Vector4Int32(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXYX() => new Vector4Int32(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXYY() => new Vector4Int32(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXYZ() => new Vector4Int32(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXZX() => new Vector4Int32(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXZY() => new Vector4Int32(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXZZ() => new Vector4Int32(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYXX() => new Vector4Int32(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYXY() => new Vector4Int32(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYXZ() => new Vector4Int32(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYYX() => new Vector4Int32(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYYY() => new Vector4Int32(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYYZ() => new Vector4Int32(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYZX() => new Vector4Int32(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYZY() => new Vector4Int32(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYZZ() => new Vector4Int32(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZXX() => new Vector4Int32(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZXY() => new Vector4Int32(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZXZ() => new Vector4Int32(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZYX() => new Vector4Int32(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZYY() => new Vector4Int32(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZYZ() => new Vector4Int32(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZZX() => new Vector4Int32(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZZY() => new Vector4Int32(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YZZZ() => new Vector4Int32(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXXX() => new Vector4Int32(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXXY() => new Vector4Int32(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXXZ() => new Vector4Int32(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXYX() => new Vector4Int32(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXYY() => new Vector4Int32(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXYZ() => new Vector4Int32(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXZX() => new Vector4Int32(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXZY() => new Vector4Int32(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZXZZ() => new Vector4Int32(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYXX() => new Vector4Int32(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYXY() => new Vector4Int32(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYXZ() => new Vector4Int32(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYYX() => new Vector4Int32(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYYY() => new Vector4Int32(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYYZ() => new Vector4Int32(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYZX() => new Vector4Int32(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYZY() => new Vector4Int32(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZYZZ() => new Vector4Int32(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZXX() => new Vector4Int32(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZXY() => new Vector4Int32(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZXZ() => new Vector4Int32(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZYX() => new Vector4Int32(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZYY() => new Vector4Int32(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZYZ() => new Vector4Int32(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZZX() => new Vector4Int32(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZZY() => new Vector4Int32(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 ZZZZ() => new Vector4Int32(Z, Z, Z, Z);
        #endregion
    }
} // namespace Intar
