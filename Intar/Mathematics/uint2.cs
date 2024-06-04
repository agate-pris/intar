#if !UNITY_2018_3_OR_NEWER

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
#pragma warning disable IDE1006 // 命名スタイル
    public struct uint2 : IEquatable<uint2>, IFormattable {
#pragma warning restore IDE1006 // 命名スタイル
        public uint x;
        public uint y;

        public static readonly uint2 Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(uint x, uint y) {
            this.x = x;
            this.y = y;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(uint2 xy) : this(xy.x, xy.y) {}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(uint v) : this(v, v) {}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator +(uint2 a, uint2 b) => new uint2(
            a.x + b.x,
            a.y + b.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator -(uint2 a, uint2 b) => new uint2(
            a.x - b.x,
            a.y - b.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator *(uint scalar, uint2 vector) => new uint2(
            scalar * vector.x,
            scalar * vector.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator *(uint2 vector, uint scalar) => scalar * vector;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator /(uint2 vector, uint scalar) => new uint2(
            vector.x / scalar,
            vector.y / scalar);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(uint2 left, uint2 right) => left.Equals(right);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(uint2 left, uint2 right) => !(left == right);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint2(uint v) => new uint2(v);

        // Object
        // ------

        public override readonly bool Equals(object obj) => obj is uint2 o && Equals(o);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"uint2({x}, {y})";

        // IEquatable<uint2>
        // -----------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly bool Equals(uint2 rhs)
            => rhs.x == x
            && rhs.y == y;

        // IFormattable
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"uint2({x}, {y})";
        }
    }
}

#endif
