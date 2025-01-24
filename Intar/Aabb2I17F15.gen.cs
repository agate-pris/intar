using System.Runtime.CompilerServices;

namespace Intar {
    public struct Aabb2I17F15 {
        #region min, max
        Vector2I17F15 min;
        Vector2I17F15 max;
        #endregion
        #region Min, Max
        public Vector2I17F15 Min {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => min;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                min = value;
                max = max.Max(value);
            }
        }
        public Vector2I17F15 Max {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                max = value;
                min = min.Min(value);
            }
        }
        #endregion
        #region MinX, MaxX
        public I17F15 MinX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => min.X;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                min.X = value;
                max.X = max.X.Max(value);
            }
        }
        public I17F15 MaxX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max.X;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                max.X = value;
                min.X = min.X.Min(value);
            }
        }
        #endregion
        #region MinY, MaxY
        public I17F15 MinY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => min.Y;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                min.Y = value;
                max.Y = max.Y.Max(value);
            }
        }
        public I17F15 MaxY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max.Y;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                max.Y = value;
                min.Y = min.Y.Min(value);
            }
        }
        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        Aabb2I17F15(Vector2I17F15 min, Vector2I17F15 max) {
            this.min = min;
            this.max = max;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Aabb2I17F15(Vector2I17F15 p) {
            min = p;
            max = p;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Aabb2I17F15(Geometry.CircleI17F15 circle)
            : this(
                circle.Center - (I17F15)circle.Radius,
                circle.Center + (I17F15)circle.Radius
            ) { }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Aabb2I17F15(Geometry.Segment2I17F15 segment) {
            I17F15 minX, maxX;
            if (segment.P1.X < segment.P2.X) {
                minX = segment.P1.X;
                maxX = segment.P2.X;
            } else {
                minX = segment.P2.X;
                maxX = segment.P1.X;
            }
            I17F15 minY, maxY;
            if (segment.P1.Y < segment.P2.Y) {
                minY = segment.P1.Y;
                maxY = segment.P2.Y;
            } else {
                minY = segment.P2.Y;
                maxY = segment.P1.Y;
            }
            min = new Vector2I17F15(minX, minY);
            max = new Vector2I17F15(maxX, maxY);
        }
        #endregion
        #region EncapsulateX
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void EncapsulateX(I17F15 v) {
            if (v < min.X) {
                min.X = v;
            } else if (v > max.X) {
                max.X = v;
            }
        }
        #endregion
        #region EncapsulateY
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void EncapsulateY(I17F15 v) {
            if (v < min.Y) {
                min.Y = v;
            } else if (v > max.Y) {
                max.Y = v;
            }
        }
        #endregion
        #region Encapsulate
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encapsulate(Aabb2I17F15 other) {
            min = min.Min(other.min);
            max = max.Max(other.max);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encapsulate(Vector2I17F15 p) {
            if (p.X < min.X) {
                min.X = p.X;
            } else if (p.X > max.X) {
                max.X = p.X;
            }
            if (p.Y < min.Y) {
                min.Y = p.Y;
            } else if (p.Y > max.Y) {
                max.Y = p.Y;
            }
        }
        #endregion
    }
} // namespace Intar
