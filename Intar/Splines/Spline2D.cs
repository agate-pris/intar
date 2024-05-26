using AgatePris.Intar.Integer;
using System;
using System.Collections;
using System.Collections.Generic;

#if UNITY_5_6_OR_NEWER
using UnityEngine;
#endif

namespace AgatePris.Intar.Splines {
    [Serializable]
#if !UNITY_5_6_OR_NEWER
    readonly
#endif
    public struct  DistanceToInterpolation {
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif
        ulong distance;
#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif
        int t;

        public ulong Distance => distance;
        public int T => t;

        public DistanceToInterpolation(ulong distance, int t) {
            this.distance = distance;
            this.t = t;
        }
    }

    [Serializable]
    public class Spline2D : IReadOnlyList<BezierKnot2D> {
        [Serializable]
        sealed class MetaData {
            const int curveDistanceLutResolution = 30;

#if UNITY_5_6_OR_NEWER
            [SerializeField]
#endif
            bool isDirty = true;
#if UNITY_5_6_OR_NEWER
            [SerializeField]
#else
            readonly
#endif
            DistanceToInterpolation[] distanceToInterpolation = new DistanceToInterpolation[curveDistanceLutResolution];

            public bool IsDirty {
                get => isDirty;
                set => isDirty = value;
            }
            public DistanceToInterpolation[] DistanceToInterpolation => distanceToInterpolation;
        }

#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif
        List<BezierKnot2D> knots = new List<BezierKnot2D>();
#if UNITY_5_6_OR_NEWER
        [SerializeField, HideInInspector]
#else
        readonly
#endif
        List<MetaData> metaData = new List<MetaData>();
        [NonSerialized] ulong? lengthCache;

        public BezierKnot2D this[int i] {
            get => knots[i];
            set {
                // If the knot is the same, it is not necessary to do anything.
                if (knots[i] == value) {
                    return;
                }

                // When the knot is changed, the cache of the total length is discarded.
                lengthCache = null;

                // If it is not the first knot, the cache of the previous curve is discarded.
                if (i != 0) {
                    metaData[i - 1] = null;
                }

                // If it is not the last knot, the cache of the forward curve is discarded.
                if (i != knots.Count - 1) {
                    metaData[i] = null;
                }

                knots[i] = value;
            }
        }

        public Spline2D() {
        }
        public Spline2D(Spline2D spline) {
            knots = new List<BezierKnot2D>();
            foreach (var knot in spline.knots) {
                knots.Add(knot);
                metaData.Add(null);
            }
        }
        void EnsureMetData() {
#if UNITY_5_6_OR_NEWER
            if (metaData == null) {
                metaData = new List<MetaData>();
            }
#endif
            if (knots.Count != metaData.Count) {
                metaData.Clear();
                while (metaData.Count < knots.Count) {
                    metaData.Add(new MetaData());
                }
            }
        }
        public BezierCurve2D GetCurve(int index) {
            var next = (index + 1).Min(knots.Count - 1);
            return new BezierCurve2D(knots[index], knots[next]);
        }
        DistanceToInterpolation[] GetCurveDistanceLut(int index) {
            EnsureMetData();
            var metaData = this.metaData[index];
            if (metaData.IsDirty) {
                var curve = GetCurve(index);
                curve.CalculateCumulativeLengths(metaData.DistanceToInterpolation);
                metaData.IsDirty = false;
            }
            return metaData.DistanceToInterpolation;
        }
        public ulong GetCurveLength(int index) {
            var cumulativeCurveLengths = GetCurveDistanceLut(index);
            return cumulativeCurveLengths[cumulativeCurveLengths.Length - 1].Distance;
        }
        public int GetCurveInterpolation(int curveIndex, ulong curveDistance) {
            var cumulativeCurveLengths = GetCurveDistanceLut(curveIndex);
            return CurveUtility.GetDistanceToInterpolation(cumulativeCurveLengths, curveDistance);
        }
        public ulong GetLength() {
            if (lengthCache.HasValue) {
                return lengthCache.Value;
            }
            if (knots.Count < 2) {
                lengthCache = 0;
                return 0;
            }
            var acc = 0UL;
            for (var i = 0; i < (knots.Count - 1); ++i) {
                acc += GetCurveLength(i);
            }
            lengthCache = acc;
            return acc;
        }

        // IReadOnlyList<BezierKnot2D>
        // ---------------------------

        public int Count => knots.Count;
        public IEnumerator<BezierKnot2D> GetEnumerator() => knots.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => knots.GetEnumerator();
    }
}
