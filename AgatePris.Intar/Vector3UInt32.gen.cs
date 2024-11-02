using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public struct Vector3UInt32 : IEquatable<Vector3UInt32> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public uint X;
        public uint Y;
        public uint Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector3UInt32(uint x, uint y, uint z) {
            X = x;
            Y = y;
            Z = z;
        }

        //
        // IEqualityOperators<Vector3UInt32, Vector3UInt32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3UInt32 left, Vector3UInt32 right) {
            return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3UInt32 left, Vector3UInt32 right) {
            return left.X != right.X || left.Y != right.Y || left.Z != right.Z;
        }

        //
        // IEquatable<Vector3UInt32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3UInt32 other) => this == other;

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector3UInt32 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        //
        // IAdditionOperators<Vector3UInt32, Vector3UInt32, Vector3UInt32>
        // ISubtractionOperators<Vector3UInt32, Vector3UInt32, Vector3UInt32>
        // IIMultiplyOperators<Vector3UInt32, Vector3UInt32, Vector3UInt32>
        // IDivisionOperators<Vector3UInt32, Vector3UInt32, Vector3UInt32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator +(Vector3UInt32 left, Vector3UInt32 right) {
            return new Vector3UInt32(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator -(Vector3UInt32 left, Vector3UInt32 right) {
            return new Vector3UInt32(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator *(Vector3UInt32 left, Vector3UInt32 right) {
            return new Vector3UInt32(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator /(Vector3UInt32 left, Vector3UInt32 right) {
            return new Vector3UInt32(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
        }

        //
        // IMultiplyOperators<Vector3UInt32, Vector3UInt32, uint>
        // IDivisionOperators<Vector3UInt32, Vector3UInt32, uint>
        // IMultiplyOperators<Vector3UInt32, uint, Vector3UInt32>
        // IDivisionOperators<Vector3UInt32, uint, Vector3UInt32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator *(Vector3UInt32 left, uint right) {
            return new Vector3UInt32(left.X * right, left.Y * right, left.Z * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator *(uint left, Vector3UInt32 right) {
            return new Vector3UInt32(left * right.X, left * right.Y, left * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator /(Vector3UInt32 left, uint right) {
            return new Vector3UInt32(left.X / right, left.Y / right, left.Z / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator /(uint left, Vector3UInt32 right) {
            return new Vector3UInt32(left / right.X, left / right.Y, left / right.Z);
        }

        //
        // IUnaryPlusOperators<Vector3UInt32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3UInt32 operator +(Vector3UInt32 x) {
            return new Vector3UInt32(+x.X, +x.Y, +x.Z);
        }

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3Int32(Vector3UInt32 a) {
            return new Vector3Int32((int)a.X, (int)a.Y, (int)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector3Int64(Vector3UInt32 a) {
            return new Vector3Int64((long)a.X, (long)a.Y, (long)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector3UInt64(Vector3UInt32 a) {
            return new Vector3UInt64((ulong)a.X, (ulong)a.Y, (ulong)a.Z);
        }

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        public Vector3UInt64 BigMul(uint other) {
            return new Vector3UInt64((ulong)X * other, (ulong)Y * other, (ulong)Z * other);
        }

        public Vector3UInt64 BigMul(Vector3UInt32 other) {
            return new Vector3UInt64((ulong)X * other.X, (ulong)Y * other.Y, (ulong)Z * other.Z);
        }

    }
}
