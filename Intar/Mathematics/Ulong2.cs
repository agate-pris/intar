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
    public struct Ulong2 : IEquatable<Ulong2>, IFormattable {
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif
        ulong x;
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif
        ulong y;

        public ulong X => x;
        public ulong Y => y;

        public static readonly Ulong2 Zero;

        [MethodImpl(AggressiveInlining)]
        public Ulong2(ulong x, ulong y) {
            this.x = x;
            this.y = y;
        }
        [MethodImpl(AggressiveInlining)] public Ulong2(Ulong2 xy) : this(xy.x, xy.y) {}
        [MethodImpl(AggressiveInlining)] public Ulong2(ulong v) : this(v, v) {}
        [MethodImpl(AggressiveInlining)]
        public static Ulong2 operator +(Ulong2 a, Ulong2 b) => new Ulong2(
            a.x + b.x,
            a.y + b.y);
        [MethodImpl(AggressiveInlining)]
        public static Ulong2 operator -(Ulong2 a, Ulong2 b) => new Ulong2(
            a.x - b.x,
            a.y - b.y);
        [MethodImpl(AggressiveInlining)]
        public static Ulong2 operator *(ulong scalar, Ulong2 vector) => new Ulong2(
            scalar * vector.x,
            scalar * vector.y);
        [MethodImpl(AggressiveInlining)]
        public static Ulong2 operator *(Ulong2 vector, ulong scalar) => scalar * vector;
        [MethodImpl(AggressiveInlining)]
        public static Ulong2 operator /(Ulong2 vector, ulong scalar) => new Ulong2(
            vector.x / scalar,
            vector.y / scalar);
        [MethodImpl(AggressiveInlining)]
        public static bool operator ==(Ulong2 left, Ulong2 right) => left.Equals(right);
        [MethodImpl(AggressiveInlining)]
        public static bool operator !=(Ulong2 left, Ulong2 right) => !(left == right);
        [MethodImpl(AggressiveInlining)]
        public static implicit operator Ulong2(ulong v) => new Ulong2(v);

        // Object
        // ------

        public override bool Equals(object obj) => obj is Ulong2 o && Equals(o);
        [MethodImpl(AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(x, y);
        [MethodImpl(AggressiveInlining)] public override string ToString() => $"Ulong2({x}, {y})";

        // IEquatable<Ulong2>
        // ------------------

        [MethodImpl(AggressiveInlining)] public bool Equals(Ulong2 rhs) => rhs.x == x && rhs.y == y;

        // IFormattable
        // ------------

        [MethodImpl(AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Ulong2({x}, {y})";
        }
    }
}
