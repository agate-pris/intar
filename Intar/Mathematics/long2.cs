using System;
using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

#if UNITY_5_6_OR_NEWER
using UnityEngine;
#endif

namespace AgatePris.Intar.Mathematics {
    [Serializable]
#pragma warning disable IDE1006 // 命名スタイル
    public struct long2 : IEquatable<long2>, IFormattable {
#pragma warning restore IDE1006 // 命名スタイル
        public long x;
        public long y;

        public static readonly long2 Zero;

        [MethodImpl(AggressiveInlining)]
        public long2(long x, long y) {
            this.x = x;
            this.y = y;
        }
        [MethodImpl(AggressiveInlining)] public long2(long2 xy) : this(xy.x, xy.y) {}
        [MethodImpl(AggressiveInlining)] public long2(long v) : this(v, v) {}
        [MethodImpl(AggressiveInlining)]
        public static long2 operator +(long2 a, long2 b) => new long2(
            a.x + b.x,
            a.y + b.y);
        [MethodImpl(AggressiveInlining)]
        public static long2 operator -(long2 a, long2 b) => new long2(
            a.x - b.x,
            a.y - b.y);
        [MethodImpl(AggressiveInlining)]
        public static long2 operator *(long scalar, long2 vector) => new long2(
            scalar * vector.x,
            scalar * vector.y);
        [MethodImpl(AggressiveInlining)]
        public static long2 operator *(long2 vector, long scalar) => scalar * vector;
        [MethodImpl(AggressiveInlining)]
        public static long2 operator /(long2 vector, long scalar) => new long2(
            vector.x / scalar,
            vector.y / scalar);
        [MethodImpl(AggressiveInlining)]
        public static bool operator ==(long2 lhs, long2 rhs) => lhs.Equals(rhs);
        [MethodImpl(AggressiveInlining)]
        public static bool operator !=(long2 lhs, long2 rhs) => !(lhs == rhs);
        [MethodImpl(AggressiveInlining)]
        public static implicit operator long2(long v) => new long2(v);

        // Object
        // ------

        public override readonly bool Equals(object obj) => obj is long2 o && Equals(o);
        [MethodImpl(AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);
        [MethodImpl(AggressiveInlining)]
        public override readonly string ToString() => $"long2({x}, {y})";

        // IEquatable<long2>
        // -----------------

        [MethodImpl(AggressiveInlining)] public readonly bool Equals(long2 rhs)
            => rhs.x == x
            && rhs.y == y;

        // IFormattable
        // ------------

        [MethodImpl(AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"long2({x}, {y})";
        }
    }
}
