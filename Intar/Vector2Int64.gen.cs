using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector2Int64 : IEquatable<Vector2Int64> {

        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public long X;
        public long Y;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion

        public static explicit operator System.Numerics.Vector2(Vector2Int64 a) {
            return new System.Numerics.Vector2(a.X, a.Y);
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector2(Vector2Int64 a) {
            return new UnityEngine.Vector2(a.X, a.Y);
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float2(Vector2Int64 a) {
            return new Unity.Mathematics.float2(a.X, a.Y);
        }
#endif

        public Vector2Int64(long x, long y) {
            X = x;
            Y = y;
        }

        public long this[int index] {
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

        #region IComparisonOperators, IEqualityOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <(Vector2Int64 left, Vector2Int64 right) {
            return new Vector2Bool(left.X < right.X, left.Y < right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <(long left, Vector2Int64 right) {
            return new Vector2Bool(left < right.X, left < right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <(Vector2Int64 left, long right) {
            return new Vector2Bool(left.X < right, left.Y < right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >(Vector2Int64 left, Vector2Int64 right) {
            return new Vector2Bool(left.X > right.X, left.Y > right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >(long left, Vector2Int64 right) {
            return new Vector2Bool(left > right.X, left > right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >(Vector2Int64 left, long right) {
            return new Vector2Bool(left.X > right, left.Y > right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <=(Vector2Int64 left, Vector2Int64 right) {
            return new Vector2Bool(left.X <= right.X, left.Y <= right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <=(long left, Vector2Int64 right) {
            return new Vector2Bool(left <= right.X, left <= right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <=(Vector2Int64 left, long right) {
            return new Vector2Bool(left.X <= right, left.Y <= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >=(Vector2Int64 left, Vector2Int64 right) {
            return new Vector2Bool(left.X >= right.X, left.Y >= right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >=(long left, Vector2Int64 right) {
            return new Vector2Bool(left >= right.X, left >= right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >=(Vector2Int64 left, long right) {
            return new Vector2Bool(left.X >= right, left.Y >= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(Vector2Int64 left, Vector2Int64 right) {
            return new Vector2Bool(left.X == right.X, left.Y == right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(long left, Vector2Int64 right) {
            return new Vector2Bool(left == right.X, left == right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(Vector2Int64 left, long right) {
            return new Vector2Bool(left.X == right, left.Y == right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2Int64 left, Vector2Int64 right) {
            return new Vector2Bool(left.X != right.X, left.Y != right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(long left, Vector2Int64 right) {
            return new Vector2Bool(left != right.X, left != right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2Int64 left, long right) {
            return new Vector2Bool(left.X != right, left.Y != right);
        }

        #endregion

        #region IShiftOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator <<(Vector2Int64 left, int right) {
            return new Vector2Int64(left.X << right, left.Y << right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator >>(Vector2Int64 left, int right) {
            return new Vector2Int64(left.X >> right, left.Y >> right);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator >>>(Vector2Int64 left, int right) {
            return new Vector2Int64(left.X >>> right, left.Y >>> right);
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2Int64 other) {
            return X == other.X && Y == other.Y;
        }

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is Vector2Int64 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        #endregion

        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator +(Vector2Int64 left, Vector2Int64 right) {
            return new Vector2Int64(left.X + right.X, left.Y + right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator +(Vector2Int64 left, long right) {
            return new Vector2Int64(left.X + right, left.Y + right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator +(long left, Vector2Int64 right) {
            return new Vector2Int64(left + right.X, left + right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator -(Vector2Int64 left, Vector2Int64 right) {
            return new Vector2Int64(left.X - right.X, left.Y - right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator -(Vector2Int64 left, long right) {
            return new Vector2Int64(left.X - right, left.Y - right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator -(long left, Vector2Int64 right) {
            return new Vector2Int64(left - right.X, left - right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator *(Vector2Int64 left, Vector2Int64 right) {
            return new Vector2Int64(left.X * right.X, left.Y * right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator *(Vector2Int64 left, long right) {
            return new Vector2Int64(left.X * right, left.Y * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator *(long left, Vector2Int64 right) {
            return new Vector2Int64(left * right.X, left * right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator /(Vector2Int64 left, Vector2Int64 right) {
            return new Vector2Int64(left.X / right.X, left.Y / right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator /(Vector2Int64 left, long right) {
            return new Vector2Int64(left.X / right, left.Y / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator /(long left, Vector2Int64 right) {
            return new Vector2Int64(left / right.X, left / right.Y);
        }

        #endregion

        #region IUnaryPlusOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator +(Vector2Int64 x) {
            return new Vector2Int64(+x.X, +x.Y);
        }

        #endregion

        #region IUnarryNegationOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator -(Vector2Int64 x) {
            return new Vector2Int64(-x.X, -x.Y);
        }

        #endregion

        #region Conversion Operators

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2Int32(Vector2Int64 a) {
            return new Vector2Int32((int)a.X, (int)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2UInt32(Vector2Int64 a) {
            return new Vector2UInt32((uint)a.X, (uint)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2UInt64(Vector2Int64 a) {
            return new Vector2UInt64((ulong)a.X, (ulong)a.Y);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector2Int128(Vector2Int64 a) {
            return new Vector2Int128((Int128)a.X, (Int128)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2UInt128(Vector2Int64 a) {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 Abs() => new Vector2Int64(Math.Abs(X), Math.Abs(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 UnsignedAbs() {
            var isNegative = IsNegative();
            return new Vector2UInt64(
                unchecked((ulong)(isNegative.X ? Overflowing.WrappingNeg(X) : X)),
                unchecked((ulong)(isNegative.Y ? Overflowing.WrappingNeg(Y) : Y))
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal (Vector2Bool isNegative, Vector2UInt64 unsignedAbs) IsNegativeAndUnsignedAbs() {
            var isNegative = IsNegative();
            var unsignedAbs = new Vector2UInt64(
                unchecked((ulong)(isNegative.X ? Overflowing.WrappingNeg(X) : X)),
                unchecked((ulong)(isNegative.Y ? Overflowing.WrappingNeg(Y) : Y))
            );
            return (isNegative, unsignedAbs);
        }

        #endregion

        #region Min, Max, MaxComponent, Clamp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 Min(Vector2Int64 other) {
            return new Vector2Int64(Math.Min(X, other.X), Math.Min(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 Max(Vector2Int64 other) {
            return new Vector2Int64(Math.Max(X, other.X), Math.Max(Y, other.Y));
        }

        // MaxComponent は符号なしの場合のみ定義する。

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 Clamp(long min, long max) {
#if NET5_0_OR_GREATER
            return new Vector2Int64(Math.Clamp(X, min, max), Math.Clamp(Y, min, max));
#else
            return new Vector2Int64(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max));
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 Clamp(Vector2Int64 min, Vector2Int64 max) {
#if NET5_0_OR_GREATER
            return new Vector2Int64(Math.Clamp(X, min.X, max.X), Math.Clamp(Y, min.Y, max.Y));
#else
            return new Vector2Int64(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y));
#endif
        }

        #endregion

        #region Half, Twice, ComponentsSum

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 Half() => new Vector2Int64(Mathi.Half(X), Mathi.Half(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 Twice() => new Vector2Int64(Mathi.Twice(X), Mathi.Twice(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal long ComponentsSum() => X + Y;

        #endregion

        #region BigMul, Cross, Dot, LengthSquared, (Unchecked)Length, HalfLength

#if NET7_0_OR_GREATER

        public Vector2Int128 BigMul(long other) {
            return (Vector2Int128)this * other;
        }

        public Vector2Int128 BigMul(Vector2Int64 other) {
            return (Vector2Int128)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int128 Dot(Vector2Int64 other) {
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
        public Vector2Int64 WrappingAdd(Vector2Int64 other) {
            return new Vector2Int64(Overflowing.WrappingAdd(X, other.X), Overflowing.WrappingAdd(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 WrappingSub(Vector2Int64 other) {
            return new Vector2Int64(Overflowing.WrappingSub(X, other.X), Overflowing.WrappingSub(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 WrappingNeg() {
            return new Vector2Int64(Overflowing.WrappingNeg(X), Overflowing.WrappingNeg(Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 WrappingAddUnsigned(Vector2UInt64 other) {
            return new Vector2Int64(Overflowing.WrappingAddUnsigned(X, other.X), Overflowing.WrappingAddUnsigned(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 WrappingSubUnsigned(Vector2UInt64 other) {
            return new Vector2Int64(Overflowing.WrappingSubUnsigned(X, other.X), Overflowing.WrappingSubUnsigned(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 WrappingAbs() {
            return new Vector2Int64(Overflowing.WrappingAbs(X), Overflowing.WrappingAbs(Y));
        }

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 XX() => new Vector2Int64(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 XY() => new Vector2Int64(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 YX() => new Vector2Int64(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int64 YY() => new Vector2Int64(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XXX() => new Vector3Int64(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XXY() => new Vector3Int64(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XYX() => new Vector3Int64(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 XYY() => new Vector3Int64(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YXX() => new Vector3Int64(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YXY() => new Vector3Int64(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YYX() => new Vector3Int64(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int64 YYY() => new Vector3Int64(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXXX() => new Vector4Int64(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXXY() => new Vector4Int64(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXYX() => new Vector4Int64(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XXYY() => new Vector4Int64(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYXX() => new Vector4Int64(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYXY() => new Vector4Int64(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYYX() => new Vector4Int64(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 XYYY() => new Vector4Int64(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXXX() => new Vector4Int64(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXXY() => new Vector4Int64(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXYX() => new Vector4Int64(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YXYY() => new Vector4Int64(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYXX() => new Vector4Int64(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYXY() => new Vector4Int64(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYYX() => new Vector4Int64(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int64 YYYY() => new Vector4Int64(Y, Y, Y, Y);

        #endregion

    }
} // namespace Intar
