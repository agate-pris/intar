using AgatePris.Intar.Integer;
using AgatePris.Intar.Mathematics;

namespace AgatePris.Intar.Splines {
    public static partial class SplineUtility {
        public static int SplineToCurveT(this Spline2D spline, int splineT, out int curveT) {
            const int one = 1 << 30;
            if (spline.Count < 2) {
                curveT = 0;
                return 0;
            }
            splineT = splineT.Clamp(0, one);
            var tLength = spline.GetLength() * (ulong)splineT / one;
            var acc = 0UL;
            for (var i = 0; i < spline.Count - 1; ++i) {
                var curveLength = spline.GetCurveLength(i);
                var nextAcc = acc + curveLength;
                if (tLength <= nextAcc) {
                    var curveDistance = tLength - acc;
                    curveT = spline.GetCurveInterpolation(i, curveDistance);
                    return i;
                }
                acc = nextAcc;
            }

            curveT = one;
            return spline.Count - 2;
        }
        public static Int2? EvaluatePosition(this Spline2D spline, int t) {
            if (spline.Count < 1) {
                return null;
            }
            var curveIndex = SplineToCurveT(spline, t, out var curveT);
            var curve = spline.GetCurve(curveIndex);
            return curve.EvaluatePosition(curveT);
        }
    }
}
