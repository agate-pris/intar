

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
        // IEqualityOperators
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
        // IEquatable
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
        // IAdditionOperators
        // ISubtractionOperators
        // IMultiplyOperators
        // IDivisionOperators
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
        // IUnaryPlusOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int64 operator +(Vector3Int64 x) {
            return new Vector3Int64(+x.X, +x.Y, +x.Z);
        }

        //
        // IUnaryNegationOperators
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

        //
        // Indexer
        //

        public long this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                switch (index) {
                    case 0: return X;
                    case 1: return Y;
                    case 2: return Z;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                switch (index) {
                    case 0: X = value; break;
                    case 1: Y = value; break;
                    case 2: Z = value; break;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
        }

        //
        // Other methods
        //

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
