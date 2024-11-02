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
        // IEqualityOperators<Vector2UInt32, Vector2UInt32>
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
        // IEquatable<Vector2UInt32>
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
        // IAdditionOperators<Vector2UInt32, Vector2UInt32, Vector2UInt32>
        // ISubtractionOperators<Vector2UInt32, Vector2UInt32, Vector2UInt32>
        // IIMultiplyOperators<Vector2UInt32, Vector2UInt32, Vector2UInt32>
        // IDivisionOperators<Vector2UInt32, Vector2UInt32, Vector2UInt32>
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

        //
        // IMultiplyOperators<Vector2UInt32, Vector2UInt32, uint>
        // IDivisionOperators<Vector2UInt32, Vector2UInt32, uint>
        // IMultiplyOperators<Vector2UInt32, uint, Vector2UInt32>
        // IDivisionOperators<Vector2UInt32, uint, Vector2UInt32>
        //

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
        // IUnaryPlusOperators<Vector2UInt32>
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

        public Vector2UInt64 BigMul(uint other) {
            return new Vector2UInt64((ulong)X * other, (ulong)Y * other);
        }

        public Vector2UInt64 BigMul(Vector2UInt32 other) {
            return new Vector2UInt64((ulong)X * other.X, (ulong)Y * other.Y);
        }

    }
}
