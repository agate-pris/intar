

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public struct Vector4Int64 : IEquatable<Vector4Int64> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public long X;
        public long Y;
        public long Z;
        public long W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector4Int64(long x, long y, long z, long w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        //
        // IEqualityOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4Int64 left, Vector4Int64 right) {
            return left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.W == right.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4Int64 left, Vector4Int64 right) {
            return left.X != right.X || left.Y != right.Y || left.Z != right.Z || left.W != right.W;
        }

        //
        // IEquatable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4Int64 other) => this == other;

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector4Int64 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        //
        // IAdditionOperators
        // ISubtractionOperators
        // IMultiplyOperators
        // IDivisionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator +(Vector4Int64 left, Vector4Int64 right) {
            return new Vector4Int64(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator -(Vector4Int64 left, Vector4Int64 right) {
            return new Vector4Int64(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator *(Vector4Int64 left, Vector4Int64 right) {
            return new Vector4Int64(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator /(Vector4Int64 left, Vector4Int64 right) {
            return new Vector4Int64(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator *(Vector4Int64 left, long right) {
            return new Vector4Int64(left.X * right, left.Y * right, left.Z * right, left.W * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator *(long left, Vector4Int64 right) {
            return new Vector4Int64(left * right.X, left * right.Y, left * right.Z, left * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator /(Vector4Int64 left, long right) {
            return new Vector4Int64(left.X / right, left.Y / right, left.Z / right, left.W / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator /(long left, Vector4Int64 right) {
            return new Vector4Int64(left / right.X, left / right.Y, left / right.Z, left / right.W);
        }

        //
        // IUnaryPlusOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator +(Vector4Int64 x) {
            return new Vector4Int64(+x.X, +x.Y, +x.Z, +x.W);
        }

        //
        // IUnaryNegationOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator -(Vector4Int64 x) {
            return new Vector4Int64(-x.X, -x.Y, -x.Z, -x.W);
        }

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4Int32(Vector4Int64 a) {
            return new Vector4Int32((int)a.X, (int)a.Y, (int)a.Z, (int)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt32(Vector4Int64 a) {
            return new Vector4UInt32((uint)a.X, (uint)a.Y, (uint)a.Z, (uint)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt64(Vector4Int64 a) {
            return new Vector4UInt64((ulong)a.X, (ulong)a.Y, (ulong)a.Z, (ulong)a.W);
        }

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 Abs() => new Vector4Int64(Math.Abs(X), Math.Abs(Y), Math.Abs(Z), Math.Abs(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt64 UnsignedAbs() {
            return new Vector4UInt64(Mathi.UnsignedAbs(X), Mathi.UnsignedAbs(Y), Mathi.UnsignedAbs(Z), Mathi.UnsignedAbs(W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 Min(Vector4Int64 other) {
            return new Vector4Int64(Math.Min(X, other.X), Math.Min(Y, other.Y), Math.Min(Z, other.Z), Math.Min(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 Max(Vector4Int64 other) {
            return new Vector4Int64(Math.Max(X, other.X), Math.Max(Y, other.Y), Math.Max(Z, other.Z), Math.Max(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 Clamp(long min, long max) {
            return new Vector4Int64(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max), Mathi.Clamp(Z, min, max), Mathi.Clamp(W, min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 Clamp(Vector4Int64 min, Vector4Int64 max) {
            return new Vector4Int64(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y), Mathi.Clamp(Z, min.Z, max.Z), Mathi.Clamp(W, min.W, max.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 Half() => new Vector4Int64(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z), Mathi.Half(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int64 Twice() => new Vector4Int64(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z), Mathi.Twice(W));

    }
}
