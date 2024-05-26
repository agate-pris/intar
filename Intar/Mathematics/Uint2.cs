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
    public struct Uint2 : IEquatable<Uint2>, IFormattable {
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif
        uint x;
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif
        uint y;

        public uint X => x;
        public uint Y => y;

        public static readonly Uint2 Zero;

        [MethodImpl(AggressiveInlining)]
        public Uint2(uint x, uint y) {
            this.x = x;
            this.y = y;
        }
        [MethodImpl(AggressiveInlining)] public Uint2(Uint2 xy) : this(xy.x, xy.y) {}
        [MethodImpl(AggressiveInlining)] public Uint2(uint v) : this(v, v) {}
        [MethodImpl(AggressiveInlining)]
        public static Uint2 operator +(Uint2 a, Uint2 b) => new Uint2(
            a.x + b.x,
            a.y + b.y);
        [MethodImpl(AggressiveInlining)]
        public static Uint2 operator -(Uint2 a, Uint2 b) => new Uint2(
            a.x - b.x,
            a.y - b.y);
        [MethodImpl(AggressiveInlining)]
        public static Uint2 operator *(uint scalar, Uint2 vector) => new Uint2(
            scalar * vector.x,
            scalar * vector.y);
        [MethodImpl(AggressiveInlining)]
        public static Uint2 operator *(Uint2 vector, uint scalar) => scalar * vector;
        [MethodImpl(AggressiveInlining)]
        public static Uint2 operator /(Uint2 vector, uint scalar) => new Uint2(
            vector.x / scalar,
            vector.y / scalar);
        [MethodImpl(AggressiveInlining)]
        public static bool operator ==(Uint2 left, Uint2 right) => left.Equals(right);
        [MethodImpl(AggressiveInlining)]
        public static bool operator !=(Uint2 left, Uint2 right) => !(left == right);
        [MethodImpl(AggressiveInlining)]
        public static implicit operator Uint2(uint v) => new Uint2(v);

        // Object
        // ------

        public override bool Equals(object obj) => obj is Uint2 o && Equals(o);
        [MethodImpl(AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(x, y);
        [MethodImpl(AggressiveInlining)] public override string ToString() => $"Uint2({x}, {y})";

        // IEquatable<Uint2>
        // -----------------

        [MethodImpl(AggressiveInlining)] public bool Equals(Uint2 rhs) => rhs.x == x && rhs.y == y;

        // IFormattable
        // ------------

        [MethodImpl(AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Uint2({x}, {y})";
        }
    }
}
