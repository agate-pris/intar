

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public struct Vector3Int32 : IEquatable<Vector3Int32> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public int X;
        public int Y;
        public int Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector3Int32(int x, int y, int z) {
            X = x;
            Y = y;
            Z = z;
        }

        //
        // IEqualityOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3Int32 left, Vector3Int32 right) {
            return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3Int32 left, Vector3Int32 right) {
            return left.X != right.X || left.Y != right.Y || left.Z != right.Z;
        }

        //
        // IEquatable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3Int32 other) => this == other;

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector3Int32 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        //
        // IAdditionOperators
        // ISubtractionOperators
        // IMultiplyOperators
        // IDivisionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator +(Vector3Int32 left, Vector3Int32 right) {
            return new Vector3Int32(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator -(Vector3Int32 left, Vector3Int32 right) {
            return new Vector3Int32(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator *(Vector3Int32 left, Vector3Int32 right) {
            return new Vector3Int32(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator /(Vector3Int32 left, Vector3Int32 right) {
            return new Vector3Int32(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator *(Vector3Int32 left, int right) {
            return new Vector3Int32(left.X * right, left.Y * right, left.Z * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator *(int left, Vector3Int32 right) {
            return new Vector3Int32(left * right.X, left * right.Y, left * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator /(Vector3Int32 left, int right) {
            return new Vector3Int32(left.X / right, left.Y / right, left.Z / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator /(int left, Vector3Int32 right) {
            return new Vector3Int32(left / right.X, left / right.Y, left / right.Z);
        }

        //
        // IUnaryPlusOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator +(Vector3Int32 x) {
            return new Vector3Int32(+x.X, +x.Y, +x.Z);
        }

        //
        // IUnaryNegationOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int32 operator -(Vector3Int32 x) {
            return new Vector3Int32(-x.X, -x.Y, -x.Z);
        }

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt32(Vector3Int32 a) {
            return new Vector3UInt32((uint)a.X, (uint)a.Y, (uint)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector3Int64(Vector3Int32 a) {
            return new Vector3Int64((long)a.X, (long)a.Y, (long)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt64(Vector3Int32 a) {
            return new Vector3UInt64((ulong)a.X, (ulong)a.Y, (ulong)a.Z);
        }

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 Abs() => new Vector3Int32(Math.Abs(X), Math.Abs(Y), Math.Abs(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt32 UnsignedAbs() {
            return new Vector3UInt32(Mathi.UnsignedAbs(X), Mathi.UnsignedAbs(Y), Mathi.UnsignedAbs(Z));
        }

        public Vector3Int64 BigMul(int other) {
            return (Vector3Int64)this * other;
        }

        public Vector3Int64 BigMul(Vector3Int32 other) {
            return (Vector3Int64)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 Min(Vector3Int32 other) {
            return new Vector3Int32(Math.Min(X, other.X), Math.Min(Y, other.Y), Math.Min(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 Max(Vector3Int32 other) {
            return new Vector3Int32(Math.Max(X, other.X), Math.Max(Y, other.Y), Math.Max(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 Clamp(int min, int max) {
            return new Vector3Int32(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max), Mathi.Clamp(Z, min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 Clamp(Vector3Int32 min, Vector3Int32 max) {
            return new Vector3Int32(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y), Mathi.Clamp(Z, min.Z, max.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 Half() => new Vector3Int32(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int32 Twice() => new Vector3Int32(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z));

    }
}
