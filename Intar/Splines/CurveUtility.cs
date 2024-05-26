using AgatePris.Intar.Mathematics;
using AgatePris.Intar.Integer;

namespace AgatePris.Intar.Splines {
    public static class CurveUtility {
        // ---------------------------------------
        // The following constants must never be changed
        // because changing them will change the calculation results.

        public const int DefaultCalculateLengthResolution = 30;
        // ---------------------------------------

        public static Int2 EvaluatePosition(this BezierCurve2D curve, int t) {
            const int exp = 30;
            const int one = 1 << exp;
            t = t.Clamp(0, one);
            var tl = (long)t;
            var t2 = tl * tl >> exp;
            var t3 = tl * t2 >> exp;
            var position
                = curve.P0.AsLong() * (-t3 + 3 * t2 - 3 * tl + one)
                + curve.P1.AsLong() * (3 * t3 - 6 * t2 + 3 * tl)
                + curve.P2.AsLong() * (-3 * t3 + 3 * t2)
                + curve.P3.AsLong() * t3;

            return new Int2(
                (int)(position.X / one),
                (int)(position.Y / one));
        }
        public static void CalculateCumulativeLengths(
            this BezierCurve2D curve, DistanceToInterpolation[] lookUpTable
        ) {
            const int one = 1 << 30;
            var resolution = lookUpTable.Length;
            var p = curve.P0;
            var acc = 0UL;
            for (var i = 1; i <= resolution; ++i) {
                var t = (int)(i * (long)one / resolution);
                var q = curve.EvaluatePosition(t);
                acc += q.AbsDiff(p).Length();
                lookUpTable[i - 1] = new DistanceToInterpolation(acc, t);
                p = q;
            }
            lookUpTable[resolution - 1] = new DistanceToInterpolation(
                acc + curve.P3.AbsDiff(p).Length(), one
            );
        }
        public static ulong CalculateLength(
            this BezierCurve2D curve, int resolution = DefaultCalculateLengthResolution
        ) {
            var p = curve.P0;
            var acc = 0UL;
            for (var i = 1U; i < resolution; ++i) {
                var t = i * (1UL << 30) / (ulong)resolution;
                var q = curve.EvaluatePosition((int)t);
                acc += q.AbsDiff(p).Length();
                p = q;
            }
            return acc + curve.P3.AbsDiff(p).Length();
        }
        public static int GetDistanceToInterpolation(
            DistanceToInterpolation[] cumulativeCurveLengths, ulong distance
        ) {
            if (cumulativeCurveLengths == null ||
                cumulativeCurveLengths.Length < 1 ||
                distance <= 0) {
                return 0;
            }

            var p = 0UL;
            var t = 0;
            foreach (var cumulativeCurveLength in cumulativeCurveLengths) {
                var q = cumulativeCurveLength.Distance;
                var u = cumulativeCurveLength.T;
                if (distance < q) {
                    return t + (int)((ulong)(u - t) * (distance - p) / (q - p));
                }
                p = q;
                t = u;
            }
            return 1 << 30;
        }
    }
}
