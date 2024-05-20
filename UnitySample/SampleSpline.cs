using AgatePris.Intar.Splines;
using System;
using UnityEngine;

namespace AgatePris.Intar.UnitySample {
    [Serializable]
    public class SampleSpline : MonoBehaviour {
        [SerializeField] Spline2D spline;

#if UNITY_EDITOR
        void OnDrawGizmos() {
            Gizmos.color = Color.yellow;
            var colors = new Color[] {
                Color.HSVToRGB(0.0f / 7, 1, 1),
                Color.HSVToRGB(3.0f / 7, 1, 1),
                Color.HSVToRGB(6.0f / 7, 1, 1),
                Color.HSVToRGB(2.0f / 7, 1, 1),
                Color.HSVToRGB(5.0f / 7, 1, 1),
                Color.HSVToRGB(1.0f / 7, 1, 1),
                Color.HSVToRGB(4.0f / 7, 1, 1),
            };
            for (var i = 0; i < (spline.Count - 1); ++i) {
                var curve = spline.GetCurve(i);

                const int resolution = 24;
                for (var j = 0; j < resolution; ++j) {
                    var t1 = (int)((1 << 30) * (long)j / resolution);
                    var t2 = (int)((1 << 30) * (long)(j + 1) / resolution);
                    var p1 = CurveUtility.EvaluatePosition(curve, t1);
                    var p2 = CurveUtility.EvaluatePosition(curve, t2);
                    Gizmos.color = colors[j % colors.Length];

                    const float scale = 1.0F / (1 << 15);
                    Gizmos.DrawLine(
                        new Vector3(p1.X * scale, p1.Y * scale),
                        new Vector3(p2.X * scale, p2.Y * scale)
                    );
                }
            }
        }
#endif
    }
}