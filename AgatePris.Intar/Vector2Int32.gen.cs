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

        //
        // IEqualityOperators<Vector2Int32, Vector2Int32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2Int32 left, Vector2Int32 right) {
            return left.X == right.X && left.Y == right.Y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2Int32 left, Vector2Int32 right) {
            return left.X != right.X || left.Y != right.Y;
        }

        //
        // IEquatable<Vector2Int32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2Int32 other) => this == other;

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector2Int32 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        //
        // IAdditionOperators<Vector2Int32, Vector2Int32, Vector2Int32>
        // ISubtractionOperators<Vector2Int32, Vector2Int32, Vector2Int32>
        // IIMultiplyOperators<Vector2Int32, Vector2Int32, Vector2Int32>
        // IDivisionOperators<Vector2Int32, Vector2Int32, Vector2Int32>
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

        //
        // IMultiplyOperators<Vector2Int32, Vector2Int32, int>
        // IDivisionOperators<Vector2Int32, Vector2Int32, int>
        // IMultiplyOperators<Vector2Int32, int, Vector2Int32>
        // IDivisionOperators<Vector2Int32, int, Vector2Int32>
        //

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
        // IUnaryPlusOperators<Vector2Int32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int32 operator +(Vector2Int32 x) {
            return new Vector2Int32(+x.X, +x.Y);
        }

        //
        // IUnaryNegationOperators<Vector2Int32>
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

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt32 UnsignedAbs() {
            return new Vector2UInt32(Mathi.UnsignedAbs(X), Mathi.UnsignedAbs(Y));
        }

        public Vector2Int64 BigMul(int other) {
            return new Vector2Int64((long)X * other, (long)Y * other);
        }

        public Vector2Int64 BigMul(Vector2Int32 other) {
            return new Vector2Int64((long)X * other.X, (long)Y * other.Y);
        }

    }
}
