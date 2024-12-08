using System;
using System.Runtime.CompilerServices;

namespace Intar1991 {
    public struct Vector2UInt32 : IEquatable<Vector2UInt32> {

        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public uint X;
        public uint Y;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion

        public static explicit operator System.Numerics.Vector2(Vector2UInt32 a) {
            return new System.Numerics.Vector2(a.X, a.Y);
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector2(Vector2UInt32 a) {
            return new UnityEngine.Vector2(a.X, a.Y);
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float2(Vector2UInt32 a) {
            return new Unity.Mathematics.float2(a.X, a.Y);
        }
#endif

        public Vector2UInt32(uint x, uint y) {
            X = x;
            Y = y;
        }

        public uint this[int index] {
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
        public static Vector2Bool operator <(Vector2UInt32 left, Vector2UInt32 right) {
            return new Vector2Bool(left.X < right.X, left.Y < right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <(uint left, Vector2UInt32 right) {
            return new Vector2Bool(left < right.X, left < right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <(Vector2UInt32 left, uint right) {
            return new Vector2Bool(left.X < right, left.Y < right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >(Vector2UInt32 left, Vector2UInt32 right) {
            return new Vector2Bool(left.X > right.X, left.Y > right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >(uint left, Vector2UInt32 right) {
            return new Vector2Bool(left > right.X, left > right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >(Vector2UInt32 left, uint right) {
            return new Vector2Bool(left.X > right, left.Y > right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <=(Vector2UInt32 left, Vector2UInt32 right) {
            return new Vector2Bool(left.X <= right.X, left.Y <= right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <=(uint left, Vector2UInt32 right) {
            return new Vector2Bool(left <= right.X, left <= right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator <=(Vector2UInt32 left, uint right) {
            return new Vector2Bool(left.X <= right, left.Y <= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >=(Vector2UInt32 left, Vector2UInt32 right) {
            return new Vector2Bool(left.X >= right.X, left.Y >= right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >=(uint left, Vector2UInt32 right) {
            return new Vector2Bool(left >= right.X, left >= right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator >=(Vector2UInt32 left, uint right) {
            return new Vector2Bool(left.X >= right, left.Y >= right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(Vector2UInt32 left, Vector2UInt32 right) {
            return new Vector2Bool(left.X == right.X, left.Y == right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(uint left, Vector2UInt32 right) {
            return new Vector2Bool(left == right.X, left == right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(Vector2UInt32 left, uint right) {
            return new Vector2Bool(left.X == right, left.Y == right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2UInt32 left, Vector2UInt32 right) {
            return new Vector2Bool(left.X != right.X, left.Y != right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(uint left, Vector2UInt32 right) {
            return new Vector2Bool(left != right.X, left != right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2UInt32 left, uint right) {
            return new Vector2Bool(left.X != right, left.Y != right);
        }

        #endregion

        #region IShiftOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator <<(Vector2UInt32 left, int right) {
            return new Vector2UInt32(left.X << right, left.Y << right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator >>(Vector2UInt32 left, int right) {
            return new Vector2UInt32(left.X >> right, left.Y >> right);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator >>>(Vector2UInt32 left, int right) {
            return new Vector2UInt32(left.X >>> right, left.Y >>> right);
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2UInt32 other) {
            return X == other.X && Y == other.Y;
        }

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is Vector2UInt32 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        #endregion

        #region IAdditionOperators, ISubtractionOperators, IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator +(Vector2UInt32 left, Vector2UInt32 right) {
            return new Vector2UInt32(left.X + right.X, left.Y + right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator +(Vector2UInt32 left, uint right) {
            return new Vector2UInt32(left.X + right, left.Y + right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator +(uint left, Vector2UInt32 right) {
            return new Vector2UInt32(left + right.X, left + right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator -(Vector2UInt32 left, Vector2UInt32 right) {
            return new Vector2UInt32(left.X - right.X, left.Y - right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator -(Vector2UInt32 left, uint right) {
            return new Vector2UInt32(left.X - right, left.Y - right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator -(uint left, Vector2UInt32 right) {
            return new Vector2UInt32(left - right.X, left - right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator *(Vector2UInt32 left, Vector2UInt32 right) {
            return new Vector2UInt32(left.X * right.X, left.Y * right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator *(Vector2UInt32 left, uint right) {
            return new Vector2UInt32(left.X * right, left.Y * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator *(uint left, Vector2UInt32 right) {
            return new Vector2UInt32(left * right.X, left * right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator /(Vector2UInt32 left, Vector2UInt32 right) {
            return new Vector2UInt32(left.X / right.X, left.Y / right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator /(Vector2UInt32 left, uint right) {
            return new Vector2UInt32(left.X / right, left.Y / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator /(uint left, Vector2UInt32 right) {
            return new Vector2UInt32(left / right.X, left / right.Y);
        }

        #endregion

        #region IUnaryPlusOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator +(Vector2UInt32 x) {
            return new Vector2UInt32(+x.X, +x.Y);
        }

        #endregion

        #region Conversion Operators

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2Int32(Vector2UInt32 a) {
            return new Vector2Int32((int)a.X, (int)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector2Int64(Vector2UInt32 a) {
            return new Vector2Int64((long)a.X, (long)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector2UInt64(Vector2UInt32 a) {
            return new Vector2UInt64((ulong)a.X, (ulong)a.Y);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector2Int128(Vector2UInt32 a) {
            return new Vector2Int128((Int128)a.X, (Int128)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector2UInt128(Vector2UInt32 a) {
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

        // 符号なしベクトル型に対しては Abs, UnsignedAbs は定義しない.

        #endregion

        #region Min, Max, MaxComponent, Clamp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 Min(Vector2UInt32 other) {
            return new Vector2UInt32(Math.Min(X, other.X), Math.Min(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 Max(Vector2UInt32 other) {
            return new Vector2UInt32(Math.Max(X, other.X), Math.Max(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal uint MaxComponent() {
            return Math.Max(X, Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 Clamp(uint min, uint max) {
#if NET5_0_OR_GREATER
            return new Vector2UInt32(Math.Clamp(X, min, max), Math.Clamp(Y, min, max));
#else
            return new Vector2UInt32(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max));
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 Clamp(Vector2UInt32 min, Vector2UInt32 max) {
#if NET5_0_OR_GREATER
            return new Vector2UInt32(Math.Clamp(X, min.X, max.X), Math.Clamp(Y, min.Y, max.Y));
#else
            return new Vector2UInt32(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y));
#endif
        }

        #endregion

        #region Half, Twice, UncheckedComponentsSum

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 Half() => new Vector2UInt32(Mathi.Half(X), Mathi.Half(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 Twice() => new Vector2UInt32(Mathi.Twice(X), Mathi.Twice(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal uint UncheckedComponentsSum() => X + Y;

        #endregion

        #region BigMul, Cross, UncheckedDot, (Unchecked)LengthSquared, (Unchecked)Length, HalfLength

        public Vector2UInt64 BigMul(uint other) {
            return (Vector2UInt64)this * other;
        }

        public Vector2UInt64 BigMul(Vector2UInt32 other) {
            return (Vector2UInt64)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong UncheckedDot(Vector2UInt32 other) {
            return BigMul(other).UncheckedComponentsSum();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong UncheckedLengthSquared() {
            var sqr = BigMul(this);
            return sqr.UncheckedComponentsSum();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint UncheckedLength() => (uint)Mathi.Sqrt(UncheckedLengthSquared());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal uint HalfLength() {
            var sqr = BigMul(this);
            return (uint)Mathi.Sqrt((sqr / 4).UncheckedComponentsSum());
        }

        #endregion

        #region Overflowing

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 WrappingAdd(Vector2UInt32 other) {
            return new Vector2UInt32(Overflowing.WrappingAdd(X, other.X), Overflowing.WrappingAdd(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 WrappingSub(Vector2UInt32 other) {
            return new Vector2UInt32(Overflowing.WrappingSub(X, other.X), Overflowing.WrappingSub(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 WrappingNeg() {
            return new Vector2UInt32(Overflowing.WrappingNeg(X), Overflowing.WrappingNeg(Y));
        }

        // Rust に倣って WrappingAddSigned のみを定義し
        // WrappingSubSigned は定義しない.
        // https://doc.rust-lang.org/std/primitive.u32.html#method.wrapping_add_signed

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 WrappingAddSigned(Vector2Int32 other) {
            return new Vector2UInt32(Overflowing.WrappingAddSigned(X, other.X), Overflowing.WrappingAddSigned(Y, other.Y));
        }

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 XX() => new Vector2UInt32(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 XY() => new Vector2UInt32(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 YX() => new Vector2UInt32(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt32 YY() => new Vector2UInt32(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XXX() => new Vector3UInt32(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XXY() => new Vector3UInt32(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XYX() => new Vector3UInt32(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 XYY() => new Vector3UInt32(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YXX() => new Vector3UInt32(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YXY() => new Vector3UInt32(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YYX() => new Vector3UInt32(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt32 YYY() => new Vector3UInt32(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXXX() => new Vector4UInt32(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXXY() => new Vector4UInt32(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXYX() => new Vector4UInt32(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XXYY() => new Vector4UInt32(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYXX() => new Vector4UInt32(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYXY() => new Vector4UInt32(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYYX() => new Vector4UInt32(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 XYYY() => new Vector4UInt32(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXXX() => new Vector4UInt32(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXXY() => new Vector4UInt32(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXYX() => new Vector4UInt32(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YXYY() => new Vector4UInt32(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYXX() => new Vector4UInt32(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYXY() => new Vector4UInt32(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYYX() => new Vector4UInt32(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt32 YYYY() => new Vector4UInt32(Y, Y, Y, Y);

        #endregion

    }
} // namespace Intar1991
