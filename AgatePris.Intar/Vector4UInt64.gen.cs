using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public struct Vector4UInt64 : IEquatable<Vector4UInt64> {

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public ulong X;
        public ulong Y;
        public ulong Z;
        public ulong W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector4UInt64(ulong x, ulong y, ulong z, ulong w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        //
        // IEqualityOperators<Vector4UInt64, Vector4UInt64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4UInt64 left, Vector4UInt64 right) {
            return left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.W == right.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4UInt64 left, Vector4UInt64 right) {
            return left.X != right.X || left.Y != right.Y || left.Z != right.Z || left.W != right.W;
        }

        //
        // IEquatable<Vector4UInt64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4UInt64 other) => this == other;

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector4UInt64 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        //
        // IAdditionOperators<Vector4UInt64, Vector4UInt64, Vector4UInt64>
        // ISubtractionOperators<Vector4UInt64, Vector4UInt64, Vector4UInt64>
        // IIMultiplyOperators<Vector4UInt64, Vector4UInt64, Vector4UInt64>
        // IDivisionOperators<Vector4UInt64, Vector4UInt64, Vector4UInt64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator +(Vector4UInt64 left, Vector4UInt64 right) {
            return new Vector4UInt64(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator -(Vector4UInt64 left, Vector4UInt64 right) {
            return new Vector4UInt64(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator *(Vector4UInt64 left, Vector4UInt64 right) {
            return new Vector4UInt64(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator /(Vector4UInt64 left, Vector4UInt64 right) {
            return new Vector4UInt64(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);
        }

        //
        // IMultiplyOperators<Vector4UInt64, Vector4UInt64, ulong>
        // IDivisionOperators<Vector4UInt64, Vector4UInt64, ulong>
        // IMultiplyOperators<Vector4UInt64, ulong, Vector4UInt64>
        // IDivisionOperators<Vector4UInt64, ulong, Vector4UInt64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator *(Vector4UInt64 left, ulong right) {
            return new Vector4UInt64(left.X * right, left.Y * right, left.Z * right, left.W * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator *(ulong left, Vector4UInt64 right) {
            return new Vector4UInt64(left * right.X, left * right.Y, left * right.Z, left * right.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator /(Vector4UInt64 left, ulong right) {
            return new Vector4UInt64(left.X / right, left.Y / right, left.Z / right, left.W / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator /(ulong left, Vector4UInt64 right) {
            return new Vector4UInt64(left / right.X, left / right.Y, left / right.Z, left / right.W);
        }

        //
        // IUnaryPlusOperators<Vector4UInt64>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4UInt64 operator +(Vector4UInt64 x) {
            return new Vector4UInt64(+x.X, +x.Y, +x.Z, +x.W);
        }

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4Int32(Vector4UInt64 a) {
            return new Vector4Int32((int)a.X, (int)a.Y, (int)a.Z, (int)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4UInt32(Vector4UInt64 a) {
            return new Vector4UInt32((uint)a.X, (uint)a.Y, (uint)a.Z, (uint)a.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector4Int64(Vector4UInt64 a) {
            return new Vector4Int64((long)a.X, (long)a.Y, (long)a.Z, (long)a.W);
        }

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

    }
}
