using System;

using Intar1991.Rand;
using NUnit.Framework;

namespace Intar1991.Tests {
    public class AffineTransformTest {
        public static QuaternionI2F30 RandomRotation(ref Xoroshiro128StarStar rng) {
            var axis = QuaternionTest.RandomAxis(ref rng);
            var angle = QuaternionTest.RandomI17F15(ref rng);
            return QuaternionI2F30.AxisAngleP5(axis, angle);
        }
        public static Vector3I17F15 RandomScale(ref Xoroshiro128StarStar rng) {
            return new Vector3I17F15(
                I17F15.FromBits(rng.Next(16384, 65536)),
                I17F15.FromBits(rng.Next(16384, 65536)),
                I17F15.FromBits(rng.Next(16384, 65536)));
        }

        public static double Delta(System.Numerics.Matrix4x4 e, AffineTransformI17F15 a) {
            var d = 0.0;
            d = Math.Max(d, Math.Abs(e.M11 - a.RotationScale.C0.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M12 - a.RotationScale.C0.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M13 - a.RotationScale.C0.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M14));
            d = Math.Max(d, Math.Abs(e.M21 - a.RotationScale.C1.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M22 - a.RotationScale.C1.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M23 - a.RotationScale.C1.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M24));
            d = Math.Max(d, Math.Abs(e.M31 - a.RotationScale.C2.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M32 - a.RotationScale.C2.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M33 - a.RotationScale.C2.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M34));
            d = Math.Max(d, Math.Abs(e.M41 - a.Translation.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M42 - a.Translation.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M43 - a.Translation.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M44 - 1.0));
            return d;
        }
        public static double Delta(UnityEngine.Matrix4x4 e, AffineTransformI17F15 a) {
            var d = 0.0;
            d = Math.Max(d, Math.Abs(e.m00 - a.RotationScale.C0.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m10 - a.RotationScale.C0.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m20 - a.RotationScale.C0.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m30));
            d = Math.Max(d, Math.Abs(e.m01 - a.RotationScale.C1.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m11 - a.RotationScale.C1.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m21 - a.RotationScale.C1.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m31));
            d = Math.Max(d, Math.Abs(e.m02 - a.RotationScale.C2.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m12 - a.RotationScale.C2.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m22 - a.RotationScale.C2.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m32));
            d = Math.Max(d, Math.Abs(e.m03 - a.Translation.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m13 - a.Translation.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m23 - a.Translation.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m33 - 1.0));
            return d;
        }
        public static double Delta(Unity.Mathematics.float4x4 e, AffineTransformI17F15 a) {
            var d = 0.0;
            d = Math.Max(d, Math.Abs(e.c0.x - a.RotationScale.C0.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c0.y - a.RotationScale.C0.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c0.z - a.RotationScale.C0.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c0.w));
            d = Math.Max(d, Math.Abs(e.c1.x - a.RotationScale.C1.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c1.y - a.RotationScale.C1.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c1.z - a.RotationScale.C1.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c1.w));
            d = Math.Max(d, Math.Abs(e.c2.x - a.RotationScale.C2.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c2.y - a.RotationScale.C2.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c2.z - a.RotationScale.C2.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c2.w));
            d = Math.Max(d, Math.Abs(e.c3.x - a.Translation.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c3.y - a.Translation.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c3.z - a.Translation.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c3.w - 1.0));
            return d;
        }

        [Test]
        public static void TestTrs() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var axis = QuaternionTest.RandomAxis(ref rng);
                var angle = QuaternionTest.RandomI17F15(ref rng);
                var t = QuaternionTest.RandomPosition(ref rng);
                var r = QuaternionI2F30.AxisAngleP5(axis, angle);
                var s = QuaternionTest.RandomPosition(ref rng);
                var a = AffineTransformI17F15.Trs(t, r, s);

                {
                    var te = System.Numerics.Matrix4x4.CreateTranslation((System.Numerics.Vector3)t);
                    var re = System.Numerics.Matrix4x4.CreateFromQuaternion((System.Numerics.Quaternion)r);
                    var se = System.Numerics.Matrix4x4.CreateScale((System.Numerics.Vector3)s);
                    var e = se * re * te;
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); }
                    dm1 = Math.Max(dm1, d);
                }
            }
            const double delta = 0.00008;
            Assert.Less(dm1, delta);
        }

        [Test]
        public static void TestMulAffineTransform() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            var dm4 = 0.0;
            var dm5 = 0.0;
            var dm6 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var t1 = QuaternionTest.RandomPosition(ref rng);
                var t2 = QuaternionTest.RandomPosition(ref rng);
                var axis1 = QuaternionTest.RandomAxis(ref rng);
                var axis2 = QuaternionTest.RandomAxis(ref rng);
                var angle1 = QuaternionTest.RandomI17F15(ref rng);
                var angle2 = QuaternionTest.RandomI17F15(ref rng);
                var r1 = QuaternionI2F30.AxisAngleP5(axis1, angle1);
                var r2 = QuaternionI2F30.AxisAngleP5(axis2, angle2);
                var s1 = RandomScale(ref rng);
                var s2 = RandomScale(ref rng);
                var p = AffineTransformI17F15.Trs(t1, r1, s1);
                var q = AffineTransformI17F15.Trs(t2, r2, s2);
                var a = p * q;

                {
                    var q1 = System.Numerics.Quaternion.CreateFromAxisAngle(
                        System.Numerics.Vector3.Normalize(
                            (System.Numerics.Vector3)axis1
                        ), angle1.LossyToSingle() * (float)(Math.PI / 2));
                    var q2 = System.Numerics.Quaternion.CreateFromAxisAngle(
                        System.Numerics.Vector3.Normalize(
                            (System.Numerics.Vector3)axis2
                        ), angle2.LossyToSingle() * (float)(Math.PI / 2));
                    var e
                        = System.Numerics.Matrix4x4.CreateScale((System.Numerics.Vector3)s2)
                        * System.Numerics.Matrix4x4.CreateFromQuaternion(q2)
                        * System.Numerics.Matrix4x4.CreateTranslation((System.Numerics.Vector3)t2)
                        * System.Numerics.Matrix4x4.CreateScale((System.Numerics.Vector3)s1)
                        * System.Numerics.Matrix4x4.CreateFromQuaternion(q1)
                        * System.Numerics.Matrix4x4.CreateTranslation((System.Numerics.Vector3)t1);
                    var d = Delta(e, a);
                    if (d > 1.0) { Assert.Fail($"e:{e}\n a:{a}"); }
                    dm1 = Math.Max(dm1, d);
                }
                {
                    var e = (System.Numerics.Matrix4x4)q * (System.Numerics.Matrix4x4)p;
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail($"e:{e}\n a:{a}"); }
                    dm2 = Math.Max(dm2, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var l = UnityEngine.Matrix4x4.TRS(
                        (UnityEngine.Vector3)t1,
                        UnityEngine.Quaternion.AngleAxis(
                            angle1.LossyToSingle() * 90,
                            UnityEngine.Vector3.Normalize(
                                (UnityEngine.Vector3)axis1
                            )
                        ),
                        (UnityEngine.Vector3)s1);
                    var r = UnityEngine.Matrix4x4.TRS(
                        (UnityEngine.Vector3)t2,
                        UnityEngine.Quaternion.AngleAxis(
                            angle2.LossyToSingle() * 90,
                            UnityEngine.Vector3.Normalize(
                                (UnityEngine.Vector3)axis2
                            )
                        ),
                        (UnityEngine.Vector3)s2);
                    var e = l * r;
                    var d = Delta(e, a);
                    if (d > 0.4) { Assert.Fail($"e:{e}\n a:{a}"); }
                    dm3 = Math.Max(dm3, d);
                }
                {
                    var e = (UnityEngine.Matrix4x4)p * (UnityEngine.Matrix4x4)q;
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail($"e:{e}\n a:{a}"); }
                    dm4 = Math.Max(dm4, d);
                }
#endif

#if UNITY_2018_1_OR_NEWER
                {
                    var l = Unity.Mathematics.float4x4.TRS(
                        (Unity.Mathematics.float3)t1,
                        Unity.Mathematics.quaternion.AxisAngle(
                            Unity.Mathematics.math.normalize(
                                (Unity.Mathematics.float3)axis1
                            ), angle1.LossyToSingle() * (float)(Math.PI / 2)
                        ),
                        (Unity.Mathematics.float3)s1);
                    var r = Unity.Mathematics.float4x4.TRS(
                        (Unity.Mathematics.float3)t2,
                        Unity.Mathematics.quaternion.AxisAngle(
                            Unity.Mathematics.math.normalize(
                                (Unity.Mathematics.float3)axis2
                            ), angle2.LossyToSingle() * (float)(Math.PI / 2)
                        ),
                        (Unity.Mathematics.float3)s2);
                    var e = Unity.Mathematics.math.mul(l, r);
                    var d = Delta(e, a);
                    if (d > 1.0) { Assert.Fail($"e:{e}\n a:{a}"); }
                    dm5 = Math.Max(dm5, d);
                }
                {
                    var l = (Unity.Mathematics.float4x4)p;
                    var r = (Unity.Mathematics.float4x4)q;
                    var e = Unity.Mathematics.math.mul(l, r);
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail($"e:{e}\n a:{a}"); }
                    dm6 = Math.Max(dm6, d);
                }
#endif
            }
            const double delta = 0.0002;
            QuaternionTest.Log($"dm1:{dm1}");
            QuaternionTest.Log($"dm2:{dm2}");
            QuaternionTest.Log($"dm3:{dm3}");
            QuaternionTest.Log($"dm4:{dm4}");
            QuaternionTest.Log($"dm5:{dm5}");
            QuaternionTest.Log($"dm6:{dm6}");
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Assert.Less(dm4, delta);
            Assert.Less(dm5, delta);
            Assert.Less(dm6, delta);
        }
    }
}
