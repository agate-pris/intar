using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
#pragma warning disable IDE1006 // 命名スタイル
    public struct ulong2 : IEquatable<ulong2>, IFormattable {
#pragma warning restore IDE1006 // 命名スタイル
        public ulong x;
        public ulong y;

        public static readonly ulong2 Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2(ulong x, ulong y) {
            this.x = x;
            this.y = y;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2(ulong2 xy) : this(xy.x, xy.y) {}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2(ulong v) : this(v, v) {}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator +(ulong2 a, ulong2 b) => new ulong2(
            a.x + b.x,
            a.y + b.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator -(ulong2 a, ulong2 b) => new ulong2(
            a.x - b.x,
            a.y - b.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator *(ulong scalar, ulong2 vector) => new ulong2(
            scalar * vector.x,
            scalar * vector.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator *(ulong2 vector, ulong scalar) => scalar * vector;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 operator /(ulong2 vector, ulong scalar) => new ulong2(
            vector.x / scalar,
            vector.y / scalar);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(ulong2 left, ulong2 right) => left.Equals(right);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(ulong2 left, ulong2 right) => !(left == right);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong2(ulong v) => new ulong2(v);

        // Object
        // ------

        public override readonly bool Equals(object obj) => obj is ulong2 o && Equals(o);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"ulong2({x}, {y})";

        // IEquatable<ulong2>
        // ------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly bool Equals(ulong2 rhs)
            => rhs.x == x
            && rhs.y == y;

        // IFormattable
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"ulong2({x}, {y})";
        }
    }
}
