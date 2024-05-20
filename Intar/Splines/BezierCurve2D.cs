using AgatePris.Intar.Mathematics;
using System;
using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace AgatePris.Intar.Splines {
    public readonly struct BezierCurve2D : IEquatable<BezierCurve2D> {
        readonly Int2 p0;
        readonly Int2 p1;
        readonly Int2 p2;
        readonly Int2 p3;
        public Int2 P0 => p0;
        public Int2 P1 => p1;
        public Int2 P2 => p2;
        public Int2 P3 => p3;

        [MethodImpl(AggressiveInlining)]
        public BezierCurve2D(Int2 p0, Int2 p1) {
            this.p0 = p2 = p0;
            this.p1 = p3 = p1;
        }
        public BezierCurve2D(Int2 p0, Int2 p1, Int2 p2) {
            var p0l = p0.AsLong();
            var p1l = p1.AsLong();
            var p2l = p2.AsLong();
            var tan = p1l * 2 / 3;

            this.p0 = p0;
            this.p1 = (p0l / 3 + tan).AsInt();
            this.p2 = (p2l / 3 + tan).AsInt();
            p3 = p2;
        }
        [MethodImpl(AggressiveInlining)]
        public BezierCurve2D(Int2 p0, Int2 p1, Int2 p2, Int2 p3) {
            this.p0 = p0;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }
        public BezierCurve2D(BezierKnot2D a, BezierKnot2D b)
            : this(a.Position, a.Position + a.TangentOut, b.Position + b.TangentIn, b.Position) { }

        [MethodImpl(AggressiveInlining)] public static bool operator ==(BezierCurve2D left, BezierCurve2D right) => left.Equals(right);
        [MethodImpl(AggressiveInlining)] public static bool operator !=(BezierCurve2D left, BezierCurve2D right) => !(left == right);

        // Object
        // ------

        public override bool Equals(object obj) => obj is BezierCurve2D o && Equals(o);
        public override int GetHashCode() => HashCode.Combine(p0, p1, p2, p3);

        // IEquatable<BezierCurve2D>
        // -------------------------

        [MethodImpl(AggressiveInlining)]
        public bool Equals(BezierCurve2D other)
            => p0.Equals(other.p0)
            && p1.Equals(other.p1)
            && p2.Equals(other.p2)
            && p3.Equals(other.p3);
    }
}
