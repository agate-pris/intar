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
        // IEqualityOperators<Vector4Int64, Vector4Int64>
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
        // IEquatable<Vector4Int64>
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
        // IAdditionOperators<Vector4Int64, Vector4Int64, Vector4Int64>
        // ISubtractionOperators<Vector4Int64, Vector4Int64, Vector4Int64>
        // IIMultiplyOperators<Vector4Int64, Vector4Int64, Vector4Int64>
        // IDivisionOperators<Vector4Int64, Vector4Int64, Vector4Int64>
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

        //
        // IMultiplyOperators<Vector4Int64, Vector4Int64, long>
        // IDivisionOperators<Vector4Int64, Vector4Int64, long>
        // IMultiplyOperators<Vector4Int64, long, Vector4Int64>
        // IDivisionOperators<Vector4Int64, long, Vector4Int64>
        //

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
        // IUnaryPlusOperators<Vector4Int64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int64 operator +(Vector4Int64 x) {
            return new Vector4Int64(+x.X, +x.Y, +x.Z, +x.W);
        }

        //
        // IUnaryNegationOperators<Vector4Int64>
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
        public Vector4UInt64 UnsignedAbs() {
            return new Vector4UInt64(Mathi.UnsignedAbs(X), Mathi.UnsignedAbs(Y), Mathi.UnsignedAbs(Z), Mathi.UnsignedAbs(W));
        }

    }
}
