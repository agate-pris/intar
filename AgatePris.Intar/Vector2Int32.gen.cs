using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public struct Vector2Int32 : IEquatable<Vector2Int32> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public int X;
        public int Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector2Int32(int x, int y) {
            X = x;
            Y = y;
        }

        public int this[int index] {
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
        public static Vector2Bool operator ==(Vector2Int32 left, Vector2Int32 right) {
            return new Vector2Bool(left.X == right.X, left.Y == right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2Int32 left, Vector2Int32 right) {
            return new Vector2Bool(left.X != right.X, left.Y != right.Y);
        }

        //
        // IEquatable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2Int32 other) {
            return X == other.X && Y == other.Y;
        }

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector2Int32 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        //
        // IAdditionOperators
        // ISubtractionOperators
        // IMultiplyOperators
        // IDivisionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int32 operator +(Vector2Int32 left, Vector2Int32 right) {
            return new Vector2Int32(left.X + right.X, left.Y + right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int32 operator -(Vector2Int32 left, Vector2Int32 right) {
            return new Vector2Int32(left.X - right.X, left.Y - right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int32 operator *(Vector2Int32 left, Vector2Int32 right) {
            return new Vector2Int32(left.X * right.X, left.Y * right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int32 operator /(Vector2Int32 left, Vector2Int32 right) {
            return new Vector2Int32(left.X / right.X, left.Y / right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int32 operator *(Vector2Int32 left, int right) {
            return new Vector2Int32(left.X * right, left.Y * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int32 operator *(int left, Vector2Int32 right) {
            return new Vector2Int32(left * right.X, left * right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int32 operator /(Vector2Int32 left, int right) {
            return new Vector2Int32(left.X / right, left.Y / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int32 operator /(int left, Vector2Int32 right) {
            return new Vector2Int32(left / right.X, left / right.Y);
        }

        //
        // IUnaryPlusOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int32 operator +(Vector2Int32 x) {
            return new Vector2Int32(+x.X, +x.Y);
        }

        //
        // IUnaryNegationOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int32 operator -(Vector2Int32 x) {
            return new Vector2Int32(-x.X, -x.Y);
        }

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2UInt32(Vector2Int32 a) {
            return new Vector2UInt32((uint)a.X, (uint)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector2Int64(Vector2Int32 a) {
            return new Vector2Int64((long)a.X, (long)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2UInt64(Vector2Int32 a) {
            return new Vector2UInt64((ulong)a.X, (ulong)a.Y);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector2Int128(Vector2Int32 a) {
            return new Vector2Int128((Int128)a.X, (Int128)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2UInt128(Vector2Int32 a) {
            return new Vector2UInt128((UInt128)a.X, (UInt128)a.Y);
        }

#endif // NET7_0_OR_GREATER

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        //
        // Other methods
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int32 Abs() => new Vector2Int32(Math.Abs(X), Math.Abs(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 UnsignedAbs() {
            return new Vector2UInt32(Mathi.UnsignedAbs(X), Mathi.UnsignedAbs(Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int32 Min(Vector2Int32 other) {
            return new Vector2Int32(Math.Min(X, other.X), Math.Min(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int32 Max(Vector2Int32 other) {
            return new Vector2Int32(Math.Max(X, other.X), Math.Max(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int32 Clamp(int min, int max) {
#if NET5_0_OR_GREATER
            return new Vector2Int32(Math.Clamp(X, min, max), Math.Clamp(Y, min, max));
#else
            return new Vector2Int32(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max));
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int32 Clamp(Vector2Int32 min, Vector2Int32 max) {
#if NET5_0_OR_GREATER
            return new Vector2Int32(Math.Clamp(X, min.X, max.X), Math.Clamp(Y, min.Y, max.Y));
#else
            return new Vector2Int32(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y));
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int32 Half() => new Vector2Int32(Mathi.Half(X), Mathi.Half(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2Int32 Twice() => new Vector2Int32(Mathi.Twice(X), Mathi.Twice(Y));

        public Vector2Int64 BigMul(int other) {
            return (Vector2Int64)this * other;
        }

        public Vector2Int64 BigMul(Vector2Int32 other) {
            return (Vector2Int64)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long UncheckedDot(Vector2Int32 other) {
            var mul = (Vector2Int64)this * other;
            return mul.X + mul.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong LengthSquared() {
            var abs = UnsignedAbs();
            var sqr = abs.BigMul(abs);
            return sqr.X + sqr.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Length() => (uint)Mathi.Sqrt(LengthSquared());

        //
        // Swizzling
        //

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 XX() => new Vector2Int32(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 XY() => new Vector2Int32(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 YX() => new Vector2Int32(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2Int32 YY() => new Vector2Int32(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XXX() => new Vector3Int32(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XXY() => new Vector3Int32(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XYX() => new Vector3Int32(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 XYY() => new Vector3Int32(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YXX() => new Vector3Int32(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YXY() => new Vector3Int32(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YYX() => new Vector3Int32(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3Int32 YYY() => new Vector3Int32(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXXX() => new Vector4Int32(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXXY() => new Vector4Int32(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXYX() => new Vector4Int32(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XXYY() => new Vector4Int32(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYXX() => new Vector4Int32(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYXY() => new Vector4Int32(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYYX() => new Vector4Int32(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 XYYY() => new Vector4Int32(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXXX() => new Vector4Int32(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXXY() => new Vector4Int32(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXYX() => new Vector4Int32(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YXYY() => new Vector4Int32(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYXX() => new Vector4Int32(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYXY() => new Vector4Int32(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYYX() => new Vector4Int32(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4Int32 YYYY() => new Vector4Int32(Y, Y, Y, Y);

    }
}
