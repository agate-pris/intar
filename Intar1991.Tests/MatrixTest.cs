using System;

using Intar1991.Rand;
using NUnit.Framework;

namespace Intar1991.Tests {
    public class MatrixTest {
        static double Delta(System.Numerics.Matrix4x4 e, Matrix3x3I2F30 a) {
            // Remarks
            //
            // For matrix transformations, the Vector2, Vector3, and Vector4
            // instances are represented as rows: a vector v is transformed by
            // a matrix M with vM multiplication.
            //
            // https://learn.microsoft.com/en-us/dotnet/api/system.numerics.matrix4x4
            var d = 0.0;
            d = Math.Max(d, Math.Abs(e.M11 - a.C0.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M12 - a.C0.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M13 - a.C0.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M14 - 0.0));
            d = Math.Max(d, Math.Abs(e.M21 - a.C1.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M22 - a.C1.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M23 - a.C1.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M24 - 0.0));
            d = Math.Max(d, Math.Abs(e.M31 - a.C2.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M32 - a.C2.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M33 - a.C2.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M34 - 0.0));
            d = Math.Max(d, Math.Abs(e.M41 - 0.0));
            d = Math.Max(d, Math.Abs(e.M42 - 0.0));
            d = Math.Max(d, Math.Abs(e.M43 - 0.0));
            d = Math.Max(d, Math.Abs(e.M44 - 1.0));
            return d;
        }

#if UNITY_2018_1_OR_NEWER
        static double Delta(Unity.Mathematics.float4x4 e, Matrix3x3I2F30 a) {
            var d = 0.0;
            d = Math.Max(d, Math.Abs(e.c0.x - a.C0.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c1.x - a.C1.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c2.x - a.C2.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c3.x - 0.0));
            d = Math.Max(d, Math.Abs(e.c0.y - a.C0.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c1.y - a.C1.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c2.y - a.C2.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c3.y - 0.0));
            d = Math.Max(d, Math.Abs(e.c0.z - a.C0.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c1.z - a.C1.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c2.z - a.C2.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c3.z - 0.0));
            d = Math.Max(d, Math.Abs(e.c0.w - 0.0));
            d = Math.Max(d, Math.Abs(e.c1.w - 0.0));
            d = Math.Max(d, Math.Abs(e.c2.w - 0.0));
            d = Math.Max(d, Math.Abs(e.c3.w - 1.0));
            return d;
        }
#endif

        [Test]
        public void TestAxisAngle() {
            const double delta = 0.0002;
            var rng = new Xoroshiro128StarStar(1, 2);
            var axis = QuaternionTest.RandomAxis(ref rng);
            var angle = QuaternionTest.RandomI17F15(ref rng);

            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;

            for (var i = 0; i < 32768; i++) {
                var a = Matrix3x3I2F30.AxisAngleP5(axis, angle);

                {
                    var e = System.Numerics.Matrix4x4.CreateFromAxisAngle(
                        (System.Numerics.Vector3)axis,
                        (float)(angle.LossyToSingle() * Math.PI / 2)
                    );
                    var d = Delta(e, a);
                    if (d > delta) {
                        QuaternionTest.LogError($"d:{d} axis:{axis} angle:{angle} e:{e} a:{a}");
                    }
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = UnityEngine.Matrix4x4.Rotate(
                        UnityEngine.Quaternion.AngleAxis(
                            (float)(angle.LossyToSingle() * 90),
                            (UnityEngine.Vector3)axis
                        )
                    );
                    var d = Delta(e, a);
                    if (d > delta) {
                        QuaternionTest.LogError($"d:{d} axis:{axis} angle:{angle} e:{e} a:{a}");
                    }
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float4x4.AxisAngle(
                        (Unity.Mathematics.float3)axis,
                        (float)(angle.LossyToSingle() * Math.PI / 2));
                    var d = Delta(e, a);
                    if (d > delta) {
                        QuaternionTest.LogError($"d:{d} axis:{axis} angle:{angle} e:{e} a:{a}");
                    }
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER

            }
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            QuaternionTest.Log($"dm1:{dm1}");
            QuaternionTest.Log($"dm2:{dm2}");
            QuaternionTest.Log($"dm3:{dm3}");
        }

        [Test]
        public void TestConversionFromQuaternion() {
            const double delta = 0.0000003;
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            for (var i = 0; i < 32786; i++) {
                var q = QuaternionTest.RandomQuaternion(ref rng);
                var a = (Matrix3x3I2F30)q;

                {
                    var qf = (System.Numerics.Quaternion)q;
                    var e = System.Numerics.Matrix4x4.CreateFromQuaternion(qf);
                    var d = Delta(e, a);
                    if (d > delta) {
                        QuaternionTest.Log($"d:{d} q:{q} e:{e} a:{a}");
                    }
                    dm1 = Math.Max(dm1, d);
                }
            }
            Assert.Less(dm1, delta);
            QuaternionTest.Log($"dm1:{dm1}");
        }
    }
} // namespace Intar1991.Tests
