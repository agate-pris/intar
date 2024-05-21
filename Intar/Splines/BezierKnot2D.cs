using AgatePris.Intar.Mathematics;
using System;

#if UNITY_5_6_OR_NEWER
using UnityEngine;
#endif

namespace AgatePris.Intar.Splines {
    [Serializable]
#if !UNITY_5_6_OR_NEWER
    readonly
#endif
    public struct BezierKnot2D : IEquatable<BezierKnot2D> {
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif
        Int2 position;
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif
        Int2 tangentIn;
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif
        Int2 tangentOut;

        public Int2 Position => position;
        public Int2 TangentIn => tangentIn;
        public Int2 TangentOut => tangentOut;

        public BezierKnot2D(Int2 position, Int2 tangentIn, Int2 tangentOut) {
            this.position = position;
            this.tangentIn = tangentIn;
            this.tangentOut = tangentOut;
        }
        public BezierKnot2D(Int2 position) : this(position, 0, 0) { }

        public static BezierKnot2D operator +(BezierKnot2D knot, Int2 rhs) => new BezierKnot2D(
            knot.position + rhs, knot.tangentIn, knot.tangentOut);
        public static BezierKnot2D operator -(BezierKnot2D knot, Int2 rhs) => new BezierKnot2D(
            knot.position - rhs, knot.tangentIn, knot.tangentOut);

        public static bool operator ==(BezierKnot2D left, BezierKnot2D right) => left.Equals(right);
        public static bool operator !=(BezierKnot2D left, BezierKnot2D right) => !(left == right);

        // Object
        // ------

        public override bool Equals(object obj) => obj is BezierKnot2D o && Equals(o);
        public override int GetHashCode() => HashCode.Combine(position, tangentIn, tangentOut);
        public override string ToString()
            => $"BezierKnot2D {{ {position}, {tangentIn}, {tangentOut} }}";

        // IEquatable<BezierKnot2D>
        // ------------------------

        public bool Equals(BezierKnot2D other)
            => other.position.Equals(position)
            && other.tangentIn.Equals(tangentIn)
            && other.tangentOut.Equals(tangentOut);
    }
}
