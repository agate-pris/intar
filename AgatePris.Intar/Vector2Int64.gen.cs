using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public struct Vector2Int64 : IEquatable<Vector2Int64> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public long X;
        public long Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
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

        //
        // IEqualityOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2Int64 left, Vector2Int64 right) {
            return left.X == right.X && left.Y == right.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2Int64 left, Vector2Int64 right) {
            return left.X != right.X || left.Y != right.Y;
        }

        //
        // IEquatable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2Int64 other) => this == other;

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector2Int64 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        //
        // IAdditionOperators
        // ISubtractionOperators
        // IMultiplyOperators
        // IDivisionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator +(Vector2Int64 left, Vector2Int64 right) {
            return new Vector2Int64(left.X + right.X, left.Y + right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator -(Vector2Int64 left, Vector2Int64 right) {
            return new Vector2Int64(left.X - right.X, left.Y - right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator *(Vector2Int64 left, Vector2Int64 right) {
            return new Vector2Int64(left.X * right.X, left.Y * right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator /(Vector2Int64 left, Vector2Int64 right) {
            return new Vector2Int64(left.X / right.X, left.Y / right.Y);
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
        public static Vector2Int64 operator /(Vector2Int64 left, long right) {
            return new Vector2Int64(left.X / right, left.Y / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator /(long left, Vector2Int64 right) {
            return new Vector2Int64(left / right.X, left / right.Y);
        }

        //
        // IUnaryPlusOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator +(Vector2Int64 x) {
            return new Vector2Int64(+x.X, +x.Y);
        }

        //
        // IUnaryNegationOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator -(Vector2Int64 x) {
            return new Vector2Int64(-x.X, -x.Y);
        }

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

        //
        // Other methods
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 Abs() => new Vector2Int64(Math.Abs(X), Math.Abs(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 UnsignedAbs() {
            return new Vector2UInt64(Mathi.UnsignedAbs(X), Mathi.UnsignedAbs(Y));
        }

#if NET7_0_OR_GREATER

        public Vector2Int128 BigMul(long other) {
            return (Vector2Int128)this * other;
        }

        public Vector2Int128 BigMul(Vector2Int64 other) {
            return (Vector2Int128)this * other;
        }

#endif // NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 Min(Vector2Int64 other) {
            return new Vector2Int64(Math.Min(X, other.X), Math.Min(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 Max(Vector2Int64 other) {
            return new Vector2Int64(Math.Max(X, other.X), Math.Max(Y, other.Y));
        }

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 Half() => new Vector2Int64(Mathi.Half(X), Mathi.Half(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int64 Twice() => new Vector2Int64(Mathi.Twice(X), Mathi.Twice(Y));

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int128 UncheckedDot(Vector2Int64 other) {
            var mul = (Vector2Int128)this * other;
            return mul.X + mul.Y;
        }

#endif // NET7_0_OR_GREATER

        //
        // Swizzling
        //

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

    }
}
