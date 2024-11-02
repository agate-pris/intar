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

        //
        // IEqualityOperators<Vector2Int64, Vector2Int64>
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
        // IEquatable<Vector2Int64>
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
        // IAdditionOperators<Vector2Int64, Vector2Int64, Vector2Int64>
        // ISubtractionOperators<Vector2Int64, Vector2Int64, Vector2Int64>
        // IIMultiplyOperators<Vector2Int64, Vector2Int64, Vector2Int64>
        // IDivisionOperators<Vector2Int64, Vector2Int64, Vector2Int64>
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

        //
        // IMultiplyOperators<Vector2Int64, Vector2Int64, long>
        // IDivisionOperators<Vector2Int64, Vector2Int64, long>
        // IMultiplyOperators<Vector2Int64, long, Vector2Int64>
        // IDivisionOperators<Vector2Int64, long, Vector2Int64>
        //

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
        // IUnaryPlusOperators<Vector2Int64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int64 operator +(Vector2Int64 x) {
            return new Vector2Int64(+x.X, +x.Y);
        }

        //
        // IUnaryNegationOperators<Vector2Int64>
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

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2UInt64 UnsignedAbs() {
            return new Vector2UInt64(Mathi.UnsignedAbs(X), Mathi.UnsignedAbs(Y));
        }

    }
}
