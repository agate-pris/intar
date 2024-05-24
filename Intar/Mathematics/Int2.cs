using System;
using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

#if UNITY_5_6_OR_NEWER
using UnityEngine;
#endif

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public readonly struct Int2 : IEquatable<Int2>, IFormattable {
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#endif
        readonly int x;
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#endif
        readonly int y;

        public int X => x;
        public int Y => y;

        public static readonly Int2 Zero;

        [MethodImpl(AggressiveInlining)]
        public Int2(int x, int y) {
            this.x = x;
            this.y = y;
        }
        [MethodImpl(AggressiveInlining)] public Int2(Int2 xy) : this(xy.X, xy.Y) {}
        [MethodImpl(AggressiveInlining)] public Int2(int v) : this(v, v) {}
        [MethodImpl(AggressiveInlining)]
        public static Int2 operator +(Int2 a, Int2 b) => new Int2(
            a.x + b.x,
            a.y + b.y);
        [MethodImpl(AggressiveInlining)]
        public static Int2 operator -(Int2 a, Int2 b) => new Int2(
            a.x - b.x,
            a.y - b.y);
        [MethodImpl(AggressiveInlining)]
        public static Int2 operator *(int scalar, Int2 vector) => new Int2(
            scalar * vector.x,
            scalar * vector.y);
        [MethodImpl(AggressiveInlining)]
        public static Int2 operator *(Int2 vector, int scalar) => scalar * vector;
        [MethodImpl(AggressiveInlining)]
        public static Int2 operator /(Int2 vector, int scalar) => new Int2(
            vector.x / scalar,
            vector.y / scalar);
        [MethodImpl(AggressiveInlining)]
        public static bool operator ==(Int2 left, Int2 right) => left.Equals(right);
        [MethodImpl(AggressiveInlining)]
        public static bool operator !=(Int2 left, Int2 right) => !(left == right);
        [MethodImpl(AggressiveInlining)]
        public static implicit operator Int2(int v) => new Int2(v);

        // Object
        // ------

        public override bool Equals(object obj) => obj is Int2 o && Equals(o);
        [MethodImpl(AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(x, y);
        [MethodImpl(AggressiveInlining)] public override string ToString() => $"Int2({x}, {y})";

        // IEquatable<Int2>
        // ----------------

        [MethodImpl(AggressiveInlining)] public bool Equals(Int2 rhs) => rhs.x == x && rhs.y == y;

        // IFormattable
        // ------------

        [MethodImpl(AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Int2({x}, {y})";
        }
    }
}
