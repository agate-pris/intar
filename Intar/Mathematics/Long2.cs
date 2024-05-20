using System;
using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

#if UNITY_5_6_OR_NEWER
using UnityEngine;
#endif

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public readonly struct Long2 : IEquatable<Long2>, IFormattable {
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#endif
        readonly long x;
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#endif
        readonly long y;

        public long X => x;
        public long Y => y;

        public static readonly Long2 Zero;

        [MethodImpl(AggressiveInlining)]
        public Long2(long x, long y) {
            this.x = x;
            this.y = y;
        }
        [MethodImpl(AggressiveInlining)] public Long2(Long2 xy) : this(xy.x, xy.y) {}
        [MethodImpl(AggressiveInlining)] public Long2(long v) : this(v, v) {}
        [MethodImpl(AggressiveInlining)]
        public static Long2 operator +(Long2 a, Long2 b) => new Long2(
            a.x + b.x,
            a.y + b.y);
        [MethodImpl(AggressiveInlining)]
        public static Long2 operator -(Long2 a, Long2 b) => new Long2(
            a.x - b.x,
            a.y - b.y);
        [MethodImpl(AggressiveInlining)]
        public static Long2 operator *(long scalar, Long2 vector) => new Long2(
            scalar * vector.x,
            scalar * vector.y);
        [MethodImpl(AggressiveInlining)]
        public static Long2 operator *(Long2 vector, long scalar) => scalar * vector;
        [MethodImpl(AggressiveInlining)]
        public static Long2 operator /(Long2 vector, long scalar) => new Long2(
            vector.x / scalar,
            vector.y / scalar);
        [MethodImpl(AggressiveInlining)]
        public static bool operator ==(Long2 lhs, Long2 rhs) => lhs.Equals(rhs);
        [MethodImpl(AggressiveInlining)]
        public static bool operator !=(Long2 lhs, Long2 rhs) => !(lhs == rhs);
        [MethodImpl(AggressiveInlining)]
        public static implicit operator Long2(long v) => new Long2(v);

        // Object
        // ------

        public override bool Equals(object obj) => obj is Long2 o && Equals(o);
        [MethodImpl(AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(x, y);
        [MethodImpl(AggressiveInlining)] public override string ToString() => $"Long2({x}, {y})";

        // IEquatable<Long2>
        // -----------------

        [MethodImpl(AggressiveInlining)] public bool Equals(Long2 rhs) => rhs.x == x && rhs.y == y;

        // IFormattable
        // ------------

        [MethodImpl(AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Long2({x}, {y})";
        }
    }
}
