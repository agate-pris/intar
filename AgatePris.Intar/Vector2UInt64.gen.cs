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
        // IEqualityOperators<Vector2UInt64, Vector2UInt64>
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
        // IEquatable<Vector2UInt64>
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
        // IAdditionOperators<Vector2UInt64, Vector2UInt64, Vector2UInt64>
        // ISubtractionOperators<Vector2UInt64, Vector2UInt64, Vector2UInt64>
        // IIMultiplyOperators<Vector2UInt64, Vector2UInt64, Vector2UInt64>
        // IDivisionOperators<Vector2UInt64, Vector2UInt64, Vector2UInt64>
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

        //
        // IMultiplyOperators<Vector2UInt64, Vector2UInt64, ulong>
        // IDivisionOperators<Vector2UInt64, Vector2UInt64, ulong>
        // IMultiplyOperators<Vector2UInt64, ulong, Vector2UInt64>
        // IDivisionOperators<Vector2UInt64, ulong, Vector2UInt64>
        //

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
        // IUnaryPlusOperators<Vector2UInt64>
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

    }
}
