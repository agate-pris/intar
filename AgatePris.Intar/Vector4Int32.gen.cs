

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
        // IEqualityOperators
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
        // IEquatable
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
        // IAdditionOperators
        // ISubtractionOperators
        // IMultiplyOperators
        // IDivisionOperators
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
        // IUnaryPlusOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Int32 operator +(Vector4Int32 x) {
            return new Vector4Int32(+x.X, +x.Y, +x.Z, +x.W);
        }

        //
        // IUnaryNegationOperators
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

        //
        // Indexer
        //

        public int this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                switch (index) {
                    case 0: return X;
                    case 1: return Y;
                    case 2: return Z;
                    case 3: return W;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                switch (index) {
                    case 0: X = value; break;
                    case 1: Y = value; break;
                    case 2: Z = value; break;
                    case 3: W = value; break;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
        }

        //
        // Other methods
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 Abs() => new Vector4Int32(Math.Abs(X), Math.Abs(Y), Math.Abs(Z), Math.Abs(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4UInt32 UnsignedAbs() {
            return new Vector4UInt32(Mathi.UnsignedAbs(X), Mathi.UnsignedAbs(Y), Mathi.UnsignedAbs(Z), Mathi.UnsignedAbs(W));
        }

        public Vector4Int64 BigMul(int other) {
            return (Vector4Int64)this * other;
        }

        public Vector4Int64 BigMul(Vector4Int32 other) {
            return (Vector4Int64)this * other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 Min(Vector4Int32 other) {
            return new Vector4Int32(Math.Min(X, other.X), Math.Min(Y, other.Y), Math.Min(Z, other.Z), Math.Min(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 Max(Vector4Int32 other) {
            return new Vector4Int32(Math.Max(X, other.X), Math.Max(Y, other.Y), Math.Max(Z, other.Z), Math.Max(W, other.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 Clamp(int min, int max) {
            return new Vector4Int32(Mathi.Clamp(X, min, max), Mathi.Clamp(Y, min, max), Mathi.Clamp(Z, min, max), Mathi.Clamp(W, min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 Clamp(Vector4Int32 min, Vector4Int32 max) {
            return new Vector4Int32(Mathi.Clamp(X, min.X, max.X), Mathi.Clamp(Y, min.Y, max.Y), Mathi.Clamp(Z, min.Z, max.Z), Mathi.Clamp(W, min.W, max.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 Half() => new Vector4Int32(Mathi.Half(X), Mathi.Half(Y), Mathi.Half(Z), Mathi.Half(W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4Int32 Twice() => new Vector4Int32(Mathi.Twice(X), Mathi.Twice(Y), Mathi.Twice(Z), Mathi.Twice(W));

    }
}
