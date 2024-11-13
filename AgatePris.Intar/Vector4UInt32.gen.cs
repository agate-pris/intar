

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public struct Vector4UInt32 : IEquatable<Vector4UInt32> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public uint X;
        public uint Y;
        public uint Z;
        public uint W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector4UInt32(uint x, uint y, uint z, uint w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        //
        // IEqualityOperators<Vector4UInt32, Vector4UInt32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4UInt32 left, Vector4UInt32 right) {
            return left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.W == right.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4UInt32 left, Vector4UInt32 right) {
            return left.X != right.X || left.Y != right.Y || left.Z != right.Z || left.W != right.W;
        }

        //
        // IEquatable<Vector4UInt32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4UInt32 other) => this == other;

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector4UInt32 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        //
        // IAdditionOperators<Vector4UInt32, Vector4UInt32, Vector4UInt32>
        // ISubtractionOperators<Vector4UInt32, Vector4UInt32, Vector4UInt32>
        // IIMultiplyOperators<Vector4UInt32, Vector4UInt32, Vector4UInt32>
        // IDivisionOperators<Vector4UInt32, Vector4UInt32, Vector4UInt32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator +(Vector4UInt32 left, Vector4UInt32 right) {
            return new Vector4UInt32(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator -(Vector4UInt32 left, Vector4UInt32 right) {
            return new Vector4UInt32(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator *(Vector4UInt32 left, Vector4UInt32 right) {
            return new Vector4UInt32(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator /(Vector4UInt32 left, Vector4UInt32 right) {
            return new Vector4UInt32(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);
        }

        //
        // IMultiplyOperators<Vector4UInt32, Vector4UInt32, uint>
        // IDivisionOperators<Vector4UInt32, Vector4UInt32, uint>
        // IMultiplyOperators<Vector4UInt32, uint, Vector4UInt32>
        // IDivisionOperators<Vector4UInt32, uint, Vector4UInt32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator *(Vector4UInt32 left, uint right) {
            return new Vector4UInt32(left.X * right, left.Y * right, left.Z * right, left.W * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator *(uint left, Vector4UInt32 right) {
            return new Vector4UInt32(left * right.X, left * right.Y, left * right.Z, left * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator /(Vector4UInt32 left, uint right) {
            return new Vector4UInt32(left.X / right, left.Y / right, left.Z / right, left.W / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator /(uint left, Vector4UInt32 right) {
            return new Vector4UInt32(left / right.X, left / right.Y, left / right.Z, left / right.W);
        }

        //
        // IUnaryPlusOperators<Vector4UInt32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt32 operator +(Vector4UInt32 x) {
            return new Vector4UInt32(+x.X, +x.Y, +x.Z, +x.W);
        }

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4Int32(Vector4UInt32 a) {
            return new Vector4Int32((int)a.X, (int)a.Y, (int)a.Z, (int)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector4Int64(Vector4UInt32 a) {
            return new Vector4Int64((long)a.X, (long)a.Y, (long)a.Z, (long)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector4UInt64(Vector4UInt32 a) {
            return new Vector4UInt64((ulong)a.X, (ulong)a.Y, (ulong)a.Z, (ulong)a.W);
        }

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        public Vector4UInt64 BigMul(uint other) {
            return (Vector4UInt64)this * other;
        }

        public Vector4UInt64 BigMul(Vector4UInt32 other) {
            return (Vector4UInt64)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 Min(Vector4UInt32 other) {
            return new Vector4UInt32(Math.Min(X, other.X), Math.Min(Y, other.Y), Math.Min(Z, other.Z), Math.Min(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 Max(Vector4UInt32 other) {
            return new Vector4UInt32(Math.Max(X, other.X), Math.Max(Y, other.Y), Math.Max(Z, other.Z), Math.Max(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 Clamp(uint min, uint max) {
            return new Vector4UInt32(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max), Mathi.Clamp(Z, min, max), Mathi.Clamp(W, min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 Clamp(Vector4UInt32 min, Vector4UInt32 max) {
            return new Vector4UInt32(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y), Mathi.Clamp(Z, min.Z, max.Z), Mathi.Clamp(W, min.W, max.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 Half() => new Vector4UInt32(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z), Mathi.Half(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 Twice() => new Vector4UInt32(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z), Mathi.Twice(W));

    }
}
