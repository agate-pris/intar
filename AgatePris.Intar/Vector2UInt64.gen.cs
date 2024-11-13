

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public struct Vector2UInt64 : IEquatable<Vector2UInt64> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public ulong X;
        public ulong Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector2UInt64(ulong x, ulong y) {
            X = x;
            Y = y;
        }

        //
        // IEqualityOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2UInt64 left, Vector2UInt64 right) {
            return left.X == right.X && left.Y == right.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2UInt64 left, Vector2UInt64 right) {
            return left.X != right.X || left.Y != right.Y;
        }

        //
        // IEquatable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2UInt64 other) => this == other;

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector2UInt64 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        //
        // IAdditionOperators
        // ISubtractionOperators
        // IMultiplyOperators
        // IDivisionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator +(Vector2UInt64 left, Vector2UInt64 right) {
            return new Vector2UInt64(left.X + right.X, left.Y + right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator -(Vector2UInt64 left, Vector2UInt64 right) {
            return new Vector2UInt64(left.X - right.X, left.Y - right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator *(Vector2UInt64 left, Vector2UInt64 right) {
            return new Vector2UInt64(left.X * right.X, left.Y * right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator /(Vector2UInt64 left, Vector2UInt64 right) {
            return new Vector2UInt64(left.X / right.X, left.Y / right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator *(Vector2UInt64 left, ulong right) {
            return new Vector2UInt64(left.X * right, left.Y * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator *(ulong left, Vector2UInt64 right) {
            return new Vector2UInt64(left * right.X, left * right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator /(Vector2UInt64 left, ulong right) {
            return new Vector2UInt64(left.X / right, left.Y / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator /(ulong left, Vector2UInt64 right) {
            return new Vector2UInt64(left / right.X, left / right.Y);
        }

        //
        // IUnaryPlusOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt64 operator +(Vector2UInt64 x) {
            return new Vector2UInt64(+x.X, +x.Y);
        }

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2Int32(Vector2UInt64 a) {
            return new Vector2Int32((int)a.X, (int)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2UInt32(Vector2UInt64 a) {
            return new Vector2UInt32((uint)a.X, (uint)a.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector2Int64(Vector2UInt64 a) {
            return new Vector2Int64((long)a.X, (long)a.Y);
        }

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        //
        // Indexer
        //

        public ulong this[int index] {
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
        // Other methods
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 Min(Vector2UInt64 other) {
            return new Vector2UInt64(Math.Min(X, other.X), Math.Min(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 Max(Vector2UInt64 other) {
            return new Vector2UInt64(Math.Max(X, other.X), Math.Max(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 Clamp(ulong min, ulong max) {
            return new Vector2UInt64(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 Clamp(Vector2UInt64 min, Vector2UInt64 max) {
            return new Vector2UInt64(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 Half() => new Vector2UInt64(Mathi.Half(X), Mathi.Half(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 Twice() => new Vector2UInt64(Mathi.Twice(X), Mathi.Twice(Y));

        //
        // Swizzling
        //

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 XX() => new Vector2UInt64(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 XY() => new Vector2UInt64(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 YX() => new Vector2UInt64(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2UInt64 YY() => new Vector2UInt64(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XXX() => new Vector3UInt64(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XXY() => new Vector3UInt64(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XYX() => new Vector3UInt64(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 XYY() => new Vector3UInt64(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YXX() => new Vector3UInt64(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YXY() => new Vector3UInt64(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YYX() => new Vector3UInt64(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3UInt64 YYY() => new Vector3UInt64(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXXX() => new Vector4UInt64(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXXY() => new Vector4UInt64(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXYX() => new Vector4UInt64(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XXYY() => new Vector4UInt64(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYXX() => new Vector4UInt64(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYXY() => new Vector4UInt64(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYYX() => new Vector4UInt64(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 XYYY() => new Vector4UInt64(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXXX() => new Vector4UInt64(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXXY() => new Vector4UInt64(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXYX() => new Vector4UInt64(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YXYY() => new Vector4UInt64(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYXX() => new Vector4UInt64(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYXY() => new Vector4UInt64(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYYX() => new Vector4UInt64(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4UInt64 YYYY() => new Vector4UInt64(Y, Y, Y, Y);

    }
}
