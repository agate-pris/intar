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
        #endregion
        #region ExpandX
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Aabb2I17F15 ExpandX(I17F15 v) {
            if (min.X > v) {
                return new Aabb2I17F15(
                    new Vector2I17F15(v, min.Y),
                    max
                );
            } else if (max.X < v) {
                return new Aabb2I17F15(
                    min,
                    new Vector2I17F15(v, max.Y)
                );
            } else {
                return this;
            }
        }
        #endregion
        #region ExpandY
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Aabb2I17F15 ExpandY(I17F15 v) {
            if (min.Y > v) {
                return new Aabb2I17F15(
                    new Vector2I17F15(min.X, v),
                    max
                );
            } else if (max.Y < v) {
                return new Aabb2I17F15(
                    min,
                    new Vector2I17F15(max.X, v)
                );
            } else {
                return this;
            }
        }
        #endregion
        #region Expand
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Aabb2I17F15 Expand(Aabb2I17F15 other) {
            return new Aabb2I17F15(
                min.Min(other.Min),
                max.Max(other.Max)
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Aabb2I17F15 Expand(Vector2I17F15 p) {
            I17F15 minX, maxX;
            if (min.X > p.X) {
                minX = p.X;
                maxX = max.X;
            } else if (max.X < p.X) {
                minX = min.X;
                maxX = p.X;
            } else {
                minX = min.X;
                maxX = max.X;
            }
            I17F15 minY, maxY;
            if (min.Y > p.Y) {
                minY = p.Y;
                maxY = max.Y;
            } else if (max.Y < p.Y) {
                minY = min.Y;
                maxY = p.Y;
            } else {
                minY = min.Y;
                maxY = max.Y;
            }
            return new Aabb2I17F15(
                new Vector2I17F15(minX, minY),
                new Vector2I17F15(maxX, maxY)
            );
        }
        #endregion
    }
} // namespace Intar
