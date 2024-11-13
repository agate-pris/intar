

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public struct Vector2UInt32 : IEquatable<Vector2UInt32> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public uint X;
        public uint Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector2UInt32(uint x, uint y) {
            X = x;
            Y = y;
        }

        //
        // IEqualityOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2UInt32 left, Vector2UInt32 right) {
            return left.X == right.X && left.Y == right.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2UInt32 left, Vector2UInt32 right) {
            return left.X != right.X || left.Y != right.Y;
        }

        //
        // IEquatable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2UInt32 other) => this == other;

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector2UInt32 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        //
        // IAdditionOperators
        // ISubtractionOperators
        // IMultiplyOperators
        // IDivisionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator +(Vector2UInt32 left, Vector2UInt32 right) {
            return new Vector2UInt32(left.X + right.X, left.Y + right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator -(Vector2UInt32 left, Vector2UInt32 right) {
            return new Vector2UInt32(left.X - right.X, left.Y - right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator *(Vector2UInt32 left, Vector2UInt32 right) {
            return new Vector2UInt32(left.X * right.X, left.Y * right.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator /(Vector2UInt32 left, Vector2UInt32 right) {
            return new Vector2UInt32(left.X / right.X, left.Y / right.Y);
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
        public static Vector2UInt32 operator /(Vector2UInt32 left, uint right) {
            return new Vector2UInt32(left.X / right, left.Y / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator /(uint left, Vector2UInt32 right) {
            return new Vector2UInt32(left / right.X, left / right.Y);
        }

        //
        // IUnaryPlusOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2UInt32 operator +(Vector2UInt32 x) {
            return new Vector2UInt32(+x.X, +x.Y);
        }

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

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        //
        // Indexer
        //

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

        //
        // Other methods
        //

        public Vector2UInt64 BigMul(uint other) {
            return (Vector2UInt64)this * other;
        }

        public Vector2UInt64 BigMul(Vector2UInt32 other) {
            return (Vector2UInt64)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 Min(Vector2UInt32 other) {
            return new Vector2UInt32(Math.Min(X, other.X), Math.Min(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 Max(Vector2UInt32 other) {
            return new Vector2UInt32(Math.Max(X, other.X), Math.Max(Y, other.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 Clamp(uint min, uint max) {
            return new Vector2UInt32(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 Clamp(Vector2UInt32 min, Vector2UInt32 max) {
            return new Vector2UInt32(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 Half() => new Vector2UInt32(Mathi.Half(X), Mathi.Half(Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 Twice() => new Vector2UInt32(Mathi.Twice(X), Mathi.Twice(Y));

    }
}
