

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public struct Vector3Int64 : IEquatable<Vector3Int64> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public long X;
        public long Y;
        public long Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector3Int64(long x, long y, long z) {
            X = x;
            Y = y;
            Z = z;
        }

        //
        // IEqualityOperators<Vector3Int64, Vector3Int64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3Int64 left, Vector3Int64 right) {
            return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3Int64 left, Vector3Int64 right) {
            return left.X != right.X || left.Y != right.Y || left.Z != right.Z;
        }

        //
        // IEquatable<Vector3Int64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3Int64 other) => this == other;

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector3Int64 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        //
        // IAdditionOperators<Vector3Int64, Vector3Int64, Vector3Int64>
        // ISubtractionOperators<Vector3Int64, Vector3Int64, Vector3Int64>
        // IIMultiplyOperators<Vector3Int64, Vector3Int64, Vector3Int64>
        // IDivisionOperators<Vector3Int64, Vector3Int64, Vector3Int64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator +(Vector3Int64 left, Vector3Int64 right) {
            return new Vector3Int64(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator -(Vector3Int64 left, Vector3Int64 right) {
            return new Vector3Int64(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator *(Vector3Int64 left, Vector3Int64 right) {
            return new Vector3Int64(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator /(Vector3Int64 left, Vector3Int64 right) {
            return new Vector3Int64(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
        }

        //
        // IMultiplyOperators<Vector3Int64, Vector3Int64, long>
        // IDivisionOperators<Vector3Int64, Vector3Int64, long>
        // IMultiplyOperators<Vector3Int64, long, Vector3Int64>
        // IDivisionOperators<Vector3Int64, long, Vector3Int64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator *(Vector3Int64 left, long right) {
            return new Vector3Int64(left.X * right, left.Y * right, left.Z * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator *(long left, Vector3Int64 right) {
            return new Vector3Int64(left * right.X, left * right.Y, left * right.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator /(Vector3Int64 left, long right) {
            return new Vector3Int64(left.X / right, left.Y / right, left.Z / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator /(long left, Vector3Int64 right) {
            return new Vector3Int64(left / right.X, left / right.Y, left / right.Z);
        }

        //
        // IUnaryPlusOperators<Vector3Int64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator +(Vector3Int64 x) {
            return new Vector3Int64(+x.X, +x.Y, +x.Z);
        }

        //
        // IUnaryNegationOperators<Vector3Int64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator -(Vector3Int64 x) {
            return new Vector3Int64(-x.X, -x.Y, -x.Z);
        }

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3Int32(Vector3Int64 a) {
            return new Vector3Int32((int)a.X, (int)a.Y, (int)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt32(Vector3Int64 a) {
            return new Vector3UInt32((uint)a.X, (uint)a.Y, (uint)a.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector3UInt64(Vector3Int64 a) {
            return new Vector3UInt64((ulong)a.X, (ulong)a.Y, (ulong)a.Z);
        }

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 Abs() => new Vector3Int64(Math.Abs(X), Math.Abs(Y), Math.Abs(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 UnsignedAbs() {
            return new Vector3UInt64(Mathi.UnsignedAbs(X), Mathi.UnsignedAbs(Y), Mathi.UnsignedAbs(Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 Min(Vector3Int64 other) {
            return new Vector3Int64(Math.Min(X, other.X), Math.Min(Y, other.Y), Math.Min(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 Max(Vector3Int64 other) {
            return new Vector3Int64(Math.Max(X, other.X), Math.Max(Y, other.Y), Math.Max(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 Clamp(long min, long max) {
            return new Vector3Int64(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max), Mathi.Clamp(Z, min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 Clamp(Vector3Int64 min, Vector3Int64 max) {
            return new Vector3Int64(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y), Mathi.Clamp(Z, min.Z, max.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 Half() => new Vector3Int64(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3Int64 Twice() => new Vector3Int64(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z));

    }
}
