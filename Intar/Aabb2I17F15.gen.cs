using System;
using System.Runtime.CompilerServices;

#if UNITY_5_3_OR_NEWER
using UnityEngine;
#endif // UNITY_5_3_OR_NEWER

namespace Intar {
    [Serializable]
    public struct Aabb2I17F15 {
        #region min, max
#if UNITY_5_3_OR_NEWER
        [SerializeField]
#endif // UNITY_5_3_OR_NEWER
        Vector2I17F15 min;
#if UNITY_5_3_OR_NEWER
        [SerializeField]
#endif // UNITY_5_3_OR_NEWER
        Vector2I17F15 max;
        #endregion
        #region Min, Max, Size
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
        public Vector2I17F15 Size {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max - min;
        }
        #endregion
        #region MinX, MaxX, SizeX
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
        public I17F15 SizeX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max.X - min.X;
        }
        #endregion
        #region MinY, MaxY, SizeY
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
        public I17F15 SizeY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max.Y - min.Y;
        }
        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Aabb2I17F15(Vector2I17F15 p) {
            min = p;
            max = p;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Aabb2I17F15(Geometry.CircleI17F15 circle) {
            min = circle.Center - (I17F15)circle.Radius;
            max = circle.Center + (I17F15)circle.Radius;
        }
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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Aabb2I17F15(Geometry.Box2I17F15 box) : this(
            new Geometry.Segment2I17F15(box.P1, box.P2)
        ) {
            Encapsulate(box.P3);
            Encapsulate(box.P4);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Aabb2I17F15? CheckedFromMinMax(Vector2I17F15 min, Vector2I17F15 max) {
            if (max.X < min.X || max.Y < min.Y) {
                return null;
            }
            return new Aabb2I17F15 {
                min = min,
                max = max,
            };
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Aabb2I17F15 UncheckedFromMinMax(Vector2I17F15 min, Vector2I17F15 max) {
            return new Aabb2I17F15 {
                min = min,
                max = max,
            };
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Aabb2I17F15 StrictFromMinMax(Vector2I17F15 min, Vector2I17F15 max) {
            var nullable = CheckedFromMinMax(min, max);
            if (nullable.HasValue) {
                return nullable.Value;
            }
            throw new ArgumentException("Invalid Aabb2I17F15: max must be greater than or equal to min.");
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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encapsulate(Geometry.CircleI17F15 a) {
            Encapsulate(new Aabb2I17F15(a));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encapsulate(Geometry.Segment2I17F15 a) {
            Encapsulate(new Aabb2I17F15(a));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encapsulate(Geometry.Box2I17F15 a) {
            Encapsulate(new Aabb2I17F15(a));
        }
        #endregion
        #region Intersects
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(Vector2I17F15 p) {
            if (p.X < min.X || max.X < p.X) { return false; }
            if (p.Y < min.Y || max.Y < p.Y) { return false; }
            return true;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(Aabb2I17F15 other) {
            if (max.X < other.min.X || other.max.X < min.X) { return false; }
            if (max.Y < other.min.Y || other.max.Y < min.Y) { return false; }
            return true;
        }
        #endregion
        #region Overlaps
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps(Vector2I17F15 p) {
            if (p.X <= min.X || max.X <= p.X) { return false; }
            if (p.Y <= min.Y || max.Y <= p.Y) { return false; }
            return true;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps(Aabb2I17F15 other) {
            if (max.X <= other.min.X || other.max.X <= min.X) { return false; }
            if (max.Y <= other.min.Y || other.max.Y <= min.Y) { return false; }
            return true;
        }
        #endregion
    }
} // namespace Intar
