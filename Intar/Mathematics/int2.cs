#if !UNITY_2018_3_OR_NEWER

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
#pragma warning disable IDE1006 // 命名スタイル
    public struct int2 : IEquatable<int2>, IFormattable {
#pragma warning restore IDE1006 // 命名スタイル
        public int x;
        public int y;

        public static readonly int2 Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int x, int y) {
            this.x = x;
            this.y = y;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int2 xy) : this(xy.x, xy.y) {}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int v) : this(v, v) {}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator +(int2 a, int2 b) => new int2(
            a.x + b.x,
            a.y + b.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator -(int2 a, int2 b) => new int2(
            a.x - b.x,
            a.y - b.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator *(int scalar, int2 vector) => new int2(
            scalar * vector.x,
            scalar * vector.y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator *(int2 vector, int scalar) => scalar * vector;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator /(int2 vector, int scalar) => new int2(
            vector.x / scalar,
            vector.y / scalar);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(int2 left, int2 right) => left.Equals(right);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(int2 left, int2 right) => !(left == right);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2(int v) => new int2(v);

        // Object
        // ------

        public override readonly bool Equals(object obj) => obj is int2 o && Equals(o);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"int2({x}, {y})";

        // IEquatable<int2>
        // ----------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly bool Equals(int2 rhs)
            => rhs.x == x
            && rhs.y == y;

        // IFormattable
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"int2({x}, {y})";
        }
    }
}

#endif // !UNITY_2018_3_OR_NEWER
