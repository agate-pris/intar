using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public struct Vector3UInt64 : IEquatable<Vector3UInt64> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public ulong X;
        public ulong Y;
        public ulong Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector3UInt64(ulong x, ulong y, ulong z) {
            X = x;
            Y = y;
            Z = z;
        }

        //
        // IEqualityOperators<Vector3UInt64, Vector3UInt64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3UInt64 left, Vector3UInt64 right) {
            return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3UInt64 left, Vector3UInt64 right) {
            return left.X != right.X || left.Y != right.Y || left.Z != right.Z;
        }

        //
        // IEquatable<Vector3UInt64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3UInt64 other) => this == other;

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector3UInt64 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        //
        // IAdditionOperators<Vector3UInt64, Vector3UInt64, Vector3UInt64>
        // ISubtractionOperators<Vector3UInt64, Vector3UInt64, Vector3UInt64>
        // IIMultiplyOperators<Vector3UInt64, Vector3UInt64, Vector3UInt64>
        // IDivisionOperators<Vector3UInt64, Vector3UInt64, Vector3UInt64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator +(Vector3UInt64 left, Vector3UInt64 right) {
            return new Vector3UInt64(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator -(Vector3UInt64 left, Vector3UInt64 right) {
            return new Vector3UInt64(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator *(Vector3UInt64 left, Vector3UInt64 right) {
            return new Vector3UInt64(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator /(Vector3UInt64 left, Vector3UInt64 right) {
            return new Vector3UInt64(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
        }

        //
        // IMultiplyOperators<Vector3UInt64, Vector3UInt64, ulong>
        // IDivisionOperators<Vector3UInt64, Vector3UInt64, ulong>
        // IMultiplyOperators<Vector3UInt64, ulong, Vector3UInt64>
        // IDivisionOperators<Vector3UInt64, ulong, Vector3UInt64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator *(Vector3UInt64 left, ulong right) {
            return new Vector3UInt64(left.X * right, left.Y * right, left.Z * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator *(ulong left, Vector3UInt64 right) {
            return new Vector3UInt64(left * right.X, left * right.Y, left * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator /(Vector3UInt64 left, ulong right) {
            return new Vector3UInt64(left.X / right, left.Y / right, left.Z / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator /(ulong left, Vector3UInt64 right) {
            return new Vector3UInt64(left / right.X, left / right.Y, left / right.Z);
        }

        //
        // IUnaryPlusOperators<Vector3UInt64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt64 operator +(Vector3UInt64 x) {
            return new Vector3UInt64(+x.X, +x.Y, +x.Z);
        }

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3Int32(Vector3UInt64 a) {
            return new Vector3Int32((int)a.X, (int)a.Y, (int)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt32(Vector3UInt64 a) {
            return new Vector3UInt32((uint)a.X, (uint)a.Y, (uint)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3Int64(Vector3UInt64 a) {
            return new Vector3Int64((long)a.X, (long)a.Y, (long)a.Z);
        }

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

    }
}
