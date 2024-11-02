using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public struct Vector4Int32 : IEquatable<Vector4Int32> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public int X;
        public int Y;
        public int Z;
        public int W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector4Int32(int x, int y, int z, int w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        //
        // IEqualityOperators<Vector4Int32, Vector4Int32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4Int32 left, Vector4Int32 right) {
            return left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.W == right.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4Int32 left, Vector4Int32 right) {
            return left.X != right.X || left.Y != right.Y || left.Z != right.Z || left.W != right.W;
        }

        //
        // IEquatable<Vector4Int32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4Int32 other) => this == other;

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector4Int32 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        //
        // IAdditionOperators<Vector4Int32, Vector4Int32, Vector4Int32>
        // ISubtractionOperators<Vector4Int32, Vector4Int32, Vector4Int32>
        // IIMultiplyOperators<Vector4Int32, Vector4Int32, Vector4Int32>
        // IDivisionOperators<Vector4Int32, Vector4Int32, Vector4Int32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator +(Vector4Int32 left, Vector4Int32 right) {
            return new Vector4Int32(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator -(Vector4Int32 left, Vector4Int32 right) {
            return new Vector4Int32(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator *(Vector4Int32 left, Vector4Int32 right) {
            return new Vector4Int32(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator /(Vector4Int32 left, Vector4Int32 right) {
            return new Vector4Int32(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);
        }

        //
        // IMultiplyOperators<Vector4Int32, Vector4Int32, int>
        // IDivisionOperators<Vector4Int32, Vector4Int32, int>
        // IMultiplyOperators<Vector4Int32, int, Vector4Int32>
        // IDivisionOperators<Vector4Int32, int, Vector4Int32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator *(Vector4Int32 left, int right) {
            return new Vector4Int32(left.X * right, left.Y * right, left.Z * right, left.W * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator *(int left, Vector4Int32 right) {
            return new Vector4Int32(left * right.X, left * right.Y, left * right.Z, left * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator /(Vector4Int32 left, int right) {
            return new Vector4Int32(left.X / right, left.Y / right, left.Z / right, left.W / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator /(int left, Vector4Int32 right) {
            return new Vector4Int32(left / right.X, left / right.Y, left / right.Z, left / right.W);
        }

        //
        // IUnaryPlusOperators<Vector4Int32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator +(Vector4Int32 x) {
            return new Vector4Int32(+x.X, +x.Y, +x.Z, +x.W);
        }

        //
        // IUnaryNegationOperators<Vector4Int32>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator -(Vector4Int32 x) {
            return new Vector4Int32(-x.X, -x.Y, -x.Z, -x.W);
        }

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt32(Vector4Int32 a) {
            return new Vector4UInt32((uint)a.X, (uint)a.Y, (uint)a.Z, (uint)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Vector4Int64(Vector4Int32 a) {
            return new Vector4Int64((long)a.X, (long)a.Y, (long)a.Z, (long)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt64(Vector4Int32 a) {
            return new Vector4UInt64((ulong)a.X, (ulong)a.Y, (ulong)a.Z, (ulong)a.W);
        }

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 UnsignedAbs() {
            return new Vector4UInt32(Mathi.UnsignedAbs(X), Mathi.UnsignedAbs(Y), Mathi.UnsignedAbs(Z), Mathi.UnsignedAbs(W));
        }

        public Vector4Int64 BigMul(int other) {
            return new Vector4Int64((long)X * other, (long)Y * other, (long)Z * other, (long)W * other);
        }

        public Vector4Int64 BigMul(Vector4Int32 other) {
            return new Vector4Int64((long)X * other.X, (long)Y * other.Y, (long)Z * other.Z, (long)W * other.W);
        }

    }
}
