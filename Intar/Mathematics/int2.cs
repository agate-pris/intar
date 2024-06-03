#if !UNITY_2018_3_OR_NEWER

using System;
using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

#if UNITY_5_6_OR_NEWER
using UnityEngine;
#endif

namespace AgatePris.Intar.Mathematics {
    [Serializable]
#if !UNITY_5_6_OR_NEWER
    readonly
#endif
    public struct int2 : IEquatable<int2>, IFormattable {
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif
        int x;
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif
        int y;

        public int X => x;
        public int Y => y;

        public static readonly int2 Zero;

        [MethodImpl(AggressiveInlining)]
        public int2(int x, int y) {
            this.x = x;
            this.y = y;
        }
        [MethodImpl(AggressiveInlining)] public int2(int2 xy) : this(xy.X, xy.Y) {}
        [MethodImpl(AggressiveInlining)] public int2(int v) : this(v, v) {}
        [MethodImpl(AggressiveInlining)]
        public static int2 operator +(int2 a, int2 b) => new int2(
            a.x + b.x,
            a.y + b.y);
        [MethodImpl(AggressiveInlining)]
        public static int2 operator -(int2 a, int2 b) => new int2(
            a.x - b.x,
            a.y - b.y);
        [MethodImpl(AggressiveInlining)]
        public static int2 operator *(int scalar, int2 vector) => new int2(
            scalar * vector.x,
            scalar * vector.y);
        [MethodImpl(AggressiveInlining)]
        public static int2 operator *(int2 vector, int scalar) => scalar * vector;
        [MethodImpl(AggressiveInlining)]
        public static int2 operator /(int2 vector, int scalar) => new int2(
            vector.x / scalar,
            vector.y / scalar);
        [MethodImpl(AggressiveInlining)]
        public static bool operator ==(int2 left, int2 right) => left.Equals(right);
        [MethodImpl(AggressiveInlining)]
        public static bool operator !=(int2 left, int2 right) => !(left == right);
        [MethodImpl(AggressiveInlining)]
        public static implicit operator int2(int v) => new int2(v);

        // Object
        // ------

        public override bool Equals(object obj) => obj is int2 o && Equals(o);
        [MethodImpl(AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(x, y);
        [MethodImpl(AggressiveInlining)] public override string ToString() => $"int2({x}, {y})";

        // IEquatable<int2>
        // ----------------

        [MethodImpl(AggressiveInlining)] public bool Equals(int2 rhs) => rhs.x == x && rhs.y == y;

        // IFormattable
        // ------------

        [MethodImpl(AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"int2({x}, {y})";
        }
    }
}

#endif // !UNITY_2018_3_OR_NEWER
