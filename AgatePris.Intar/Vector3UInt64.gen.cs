

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
        // IEqualityOperators
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
        // IEquatable
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
        // IAdditionOperators
        // ISubtractionOperators
        // IMultiplyOperators
        // IDivisionOperators
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
        // IUnaryPlusOperators
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

        //
        // Indexer
        //

        public ulong this[int index] {
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
        public Vector3UInt64 Min(Vector3UInt64 other) {
            return new Vector3UInt64(Math.Min(X, other.X), Math.Min(Y, other.Y), Math.Min(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 Max(Vector3UInt64 other) {
            return new Vector3UInt64(Math.Max(X, other.X), Math.Max(Y, other.Y), Math.Max(Z, other.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 Clamp(ulong min, ulong max) {
            return new Vector3UInt64(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max), Mathi.Clamp(Z, min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 Clamp(Vector3UInt64 min, Vector3UInt64 max) {
            return new Vector3UInt64(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y), Mathi.Clamp(Z, min.Z, max.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 Half() => new Vector3UInt64(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3UInt64 Twice() => new Vector3UInt64(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z));

    }
}
