using System;

using Intar1991.Rand;
using NUnit.Framework;

namespace Intar1991.Tests {
    public class MatrixTest {
        public static Matrix3x3I2F30 RandomMatrix(ref Xoroshiro128StarStar rng) {
            var q = QuaternionTest.RandomQuaternion(ref rng);
            return (Matrix3x3I2F30)q;
        }

        public static double Delta(System.Numerics.Matrix4x4 e, Matrix3x3I17F15 a) {
            var d = 0.0;
            d = Math.Max(d, Math.Abs(e.M11 - a.C0.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M12 - a.C1.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M13 - a.C2.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M14));
            d = Math.Max(d, Math.Abs(e.M21 - a.C0.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M22 - a.C1.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M23 - a.C2.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M24));
            d = Math.Max(d, Math.Abs(e.M31 - a.C0.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M32 - a.C1.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M33 - a.C2.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M34));
            d = Math.Max(d, Math.Abs(e.M41));
            d = Math.Max(d, Math.Abs(e.M42));
            d = Math.Max(d, Math.Abs(e.M43));
            d = Math.Max(d, Math.Abs(e.M44 - 1));
            return d;
        }

        public static double Delta(System.Numerics.Matrix4x4 e, Matrix3x3I2F30 a) {
            var d = 0.0;
            d = Math.Max(d, Math.Abs(e.M11 - a.C0.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M12 - a.C1.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M13 - a.C2.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M14));
            d = Math.Max(d, Math.Abs(e.M21 - a.C0.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M22 - a.C1.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M23 - a.C2.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M24));
            d = Math.Max(d, Math.Abs(e.M31 - a.C0.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M32 - a.C1.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M33 - a.C2.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.M34));
            d = Math.Max(d, Math.Abs(e.M41));
            d = Math.Max(d, Math.Abs(e.M42));
            d = Math.Max(d, Math.Abs(e.M43));
            d = Math.Max(d, Math.Abs(e.M44 - 1));
            return d;
        }

#if UNITY_5_3_OR_NEWER
        public static double Delta(UnityEngine.Matrix4x4 e, Matrix3x3I2F30 a) {
            var d = 0.0;
            d = Math.Max(d, Math.Abs(e.m00 - a.C0.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m01 - a.C1.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m02 - a.C2.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m03));
            d = Math.Max(d, Math.Abs(e.m10 - a.C0.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m11 - a.C1.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m12 - a.C2.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m13));
            d = Math.Max(d, Math.Abs(e.m20 - a.C0.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m21 - a.C1.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m22 - a.C2.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.m23));
            d = Math.Max(d, Math.Abs(e.m30));
            d = Math.Max(d, Math.Abs(e.m31));
            d = Math.Max(d, Math.Abs(e.m32));
            d = Math.Max(d, Math.Abs(e.m33 - 1));
            return d;
        }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
        public static double Delta(Unity.Mathematics.float3x3 e, Matrix3x3I2F30 a) {
            var d = 0.0;
            d = Math.Max(d, Math.Abs(e.c0.x - a.C0.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c1.x - a.C1.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c2.x - a.C2.X.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c0.y - a.C0.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c1.y - a.C1.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c2.y - a.C2.Y.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c0.z - a.C0.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c1.z - a.C1.Z.LossyToSingle()));
            d = Math.Max(d, Math.Abs(e.c2.z - a.C2.Z.LossyToSingle()));
            return d;
        }
#endif // UNITY_2018_1_OR_NEWER

        [Test]
        public static void TestConversionFromQuaternion() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32786; i++) {
                var q = QuaternionTest.RandomQuaternion(ref rng);
                var a = (Matrix3x3I2F30)q;

                {
                    var e = System.Numerics.Matrix4x4.Transpose(
                        System.Numerics.Matrix4x4.CreateFromQuaternion(
                            (System.Numerics.Quaternion)q
                        )
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = UnityEngine.Matrix4x4.Rotate(
                        (UnityEngine.Quaternion)q
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = new Unity.Mathematics.float3x3(
                        (Unity.Mathematics.quaternion)q
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0000003;
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
        }

        [Test]
        public static void TestMultiply() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var m1 = RandomMatrix(ref rng);
                var m2 = RandomMatrix(ref rng);
                var a = m1 * m2;

                {
                    var mf1 = new System.Numerics.Matrix4x4(
                        m1.C0.X.LossyToSingle(), m1.C1.X.LossyToSingle(), m1.C2.X.LossyToSingle(), 0,
                        m1.C0.Y.LossyToSingle(), m1.C1.Y.LossyToSingle(), m1.C2.Y.LossyToSingle(), 0,
                        m1.C0.Z.LossyToSingle(), m1.C1.Z.LossyToSingle(), m1.C2.Z.LossyToSingle(), 0,
                        0, 0, 0, 1
                    );
                    var mf2 = new System.Numerics.Matrix4x4(
                        m2.C0.X.LossyToSingle(), m2.C1.X.LossyToSingle(), m2.C2.X.LossyToSingle(), 0,
                        m2.C0.Y.LossyToSingle(), m2.C1.Y.LossyToSingle(), m2.C2.Y.LossyToSingle(), 0,
                        m2.C0.Z.LossyToSingle(), m2.C1.Z.LossyToSingle(), m2.C2.Z.LossyToSingle(), 0,
                        0, 0, 0, 1
                    );
                    var e = mf1 * mf2;
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var mf1 = new UnityEngine.Matrix4x4(
                        (UnityEngine.Vector3)m1.C0,
                        (UnityEngine.Vector3)m1.C1,
                        (UnityEngine.Vector3)m1.C2,
                        new UnityEngine.Vector4(0, 0, 0, 1)
                    );
                    var mf2 = new UnityEngine.Matrix4x4(
                        (UnityEngine.Vector3)m2.C0,
                        (UnityEngine.Vector3)m2.C1,
                        (UnityEngine.Vector3)m2.C2,
                        new UnityEngine.Vector4(0, 0, 0, 1)
                    );
                    var e = mf1 * mf2;
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var mf1 = new Unity.Mathematics.float3x3(
                        (Unity.Mathematics.float3)m1.C0,
                        (Unity.Mathematics.float3)m1.C1,
                        (Unity.Mathematics.float3)m1.C2
                    );
                    var mf2 = new Unity.Mathematics.float3x3(
                        (Unity.Mathematics.float3)m2.C0,
                        (Unity.Mathematics.float3)m2.C1,
                        (Unity.Mathematics.float3)m2.C2
                    );
                    var e = Unity.Mathematics.math.mul(mf1, mf2);
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0000002;
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
        }

        [Test]
        public static void TestRotateX() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var angle = Utility.RandomI17F15(ref rng);
                var rad = (float)(angle.LossyToSingle() * Math.PI / 2);
                var a = Matrix3x3I2F30.RotateXP5(angle);

                {
                    var e = System.Numerics.Matrix4x4.Transpose(System.Numerics.Matrix4x4.CreateRotationX(rad));
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var deg = (float)(angle.LossyToSingle() * 90);
                    var e = UnityEngine.Matrix4x4.Rotate(UnityEngine.Quaternion.Euler(deg, 0, 0));
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.RotateX(rad);
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0002;
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
        }

        [Test]
        public static void TestRotateY() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var angle = Utility.RandomI17F15(ref rng);
                var rad = (float)(angle.LossyToSingle() * Math.PI / 2);
                var a = Matrix3x3I2F30.RotateYP5(angle);

                {
                    var e = System.Numerics.Matrix4x4.Transpose(System.Numerics.Matrix4x4.CreateRotationY(rad));
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var deg = (float)(angle.LossyToSingle() * 90);
                    var e = UnityEngine.Matrix4x4.Rotate(UnityEngine.Quaternion.Euler(0, deg, 0));
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.RotateY(rad);
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0002;
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
        }

        [Test]
        public static void TestRotateZ() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var angle = Utility.RandomI17F15(ref rng);
                var rad = (float)(angle.LossyToSingle() * Math.PI / 2);
                var a = Matrix3x3I2F30.RotateZP5(angle);

                {
                    var e = System.Numerics.Matrix4x4.Transpose(System.Numerics.Matrix4x4.CreateRotationZ(rad));
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var deg = (float)(angle.LossyToSingle() * 90);
                    var e = UnityEngine.Matrix4x4.Rotate(UnityEngine.Quaternion.Euler(0, 0, deg));
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.RotateZ(rad);
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0002;
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
        }

        [Test]
        public static void TestEulerXyz() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var angles = Utility.RandomVector3(ref rng);
                var a = Matrix3x3I2F30.EulerXyzP5(angles);

                {
                    var e
                        = System.Numerics.Matrix4x4.CreateRotationX(angles.X.LossyToSingle() * (float)Math.PI / 2)
                        * System.Numerics.Matrix4x4.CreateRotationY(angles.Y.LossyToSingle() * (float)Math.PI / 2)
                        * System.Numerics.Matrix4x4.CreateRotationZ(angles.Z.LossyToSingle() * (float)Math.PI / 2);
                    var d = Delta(System.Numerics.Matrix4x4.Transpose(e), a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.EulerXYZ(
                        (Unity.Mathematics.float3)angles * (float)(Math.PI / 2)
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0006;
            Assert.Less(dm1, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm3:{dm3}");
        }

        [Test]
        public static void TestEulerXzy() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var angles = Utility.RandomVector3(ref rng);
                var a = Matrix3x3I2F30.EulerXzyP5(angles);

                {
                    var e
                        = System.Numerics.Matrix4x4.CreateRotationX(angles.X.LossyToSingle() * (float)Math.PI / 2)
                        * System.Numerics.Matrix4x4.CreateRotationZ(angles.Z.LossyToSingle() * (float)Math.PI / 2)
                        * System.Numerics.Matrix4x4.CreateRotationY(angles.Y.LossyToSingle() * (float)Math.PI / 2);
                    var d = Delta(System.Numerics.Matrix4x4.Transpose(e), a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.EulerXZY(
                        (Unity.Mathematics.float3)angles * (float)(Math.PI / 2)
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0006;
            Assert.Less(dm1, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm3:{dm3}");
        }

        [Test]
        public static void TestEulerYxz() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var angles = Utility.RandomVector3(ref rng);
                var a = Matrix3x3I2F30.EulerYxzP5(angles);

                {
                    var e
                        = System.Numerics.Matrix4x4.CreateRotationY(angles.Y.LossyToSingle() * (float)Math.PI / 2)
                        * System.Numerics.Matrix4x4.CreateRotationX(angles.X.LossyToSingle() * (float)Math.PI / 2)
                        * System.Numerics.Matrix4x4.CreateRotationZ(angles.Z.LossyToSingle() * (float)Math.PI / 2);
                    var d = Delta(System.Numerics.Matrix4x4.Transpose(e), a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.EulerYXZ(
                        (Unity.Mathematics.float3)angles * (float)(Math.PI / 2)
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0006;
            Assert.Less(dm1, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm3:{dm3}");
        }

        [Test]
        public static void TestEulerYzx() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var angles = Utility.RandomVector3(ref rng);
                var a = Matrix3x3I2F30.EulerYzxP5(angles);

                {
                    var e
                        = System.Numerics.Matrix4x4.CreateRotationY(angles.Y.LossyToSingle() * (float)Math.PI / 2)
                        * System.Numerics.Matrix4x4.CreateRotationZ(angles.Z.LossyToSingle() * (float)Math.PI / 2)
                        * System.Numerics.Matrix4x4.CreateRotationX(angles.X.LossyToSingle() * (float)Math.PI / 2);
                    var d = Delta(System.Numerics.Matrix4x4.Transpose(e), a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.EulerYZX(
                        (Unity.Mathematics.float3)angles * (float)(Math.PI / 2)
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0006;
            Assert.Less(dm1, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm3:{dm3}");
        }

        [Test]
        public static void TestEulerZxy() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var angles = Utility.RandomVector3(ref rng);
                var a = Matrix3x3I2F30.EulerZxyP5(angles);

                {
                    var e
                        = System.Numerics.Matrix4x4.CreateRotationZ(angles.Z.LossyToSingle() * (float)Math.PI / 2)
                        * System.Numerics.Matrix4x4.CreateRotationX(angles.X.LossyToSingle() * (float)Math.PI / 2)
                        * System.Numerics.Matrix4x4.CreateRotationY(angles.Y.LossyToSingle() * (float)Math.PI / 2);
                    var d = Delta(System.Numerics.Matrix4x4.Transpose(e), a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }
#if UNITY_5_3_OR_NEWER
                {
                    var e = UnityEngine.Matrix4x4.Rotate(
                        UnityEngine.Quaternion.Euler(
                            (UnityEngine.Vector3)angles * 90
                        )
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.EulerZXY(
                        (Unity.Mathematics.float3)angles * (float)(Math.PI / 2)
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0006;
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
        }

        [Test]
        public static void TestEulerZyx() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var angles = Utility.RandomVector3(ref rng);
                var a = Matrix3x3I2F30.EulerZyxP5(angles);

                {
                    var e
                        = System.Numerics.Matrix4x4.CreateRotationZ(angles.Z.LossyToSingle() * (float)Math.PI / 2)
                        * System.Numerics.Matrix4x4.CreateRotationY(angles.Y.LossyToSingle() * (float)Math.PI / 2)
                        * System.Numerics.Matrix4x4.CreateRotationX(angles.X.LossyToSingle() * (float)Math.PI / 2);
                    var d = Delta(System.Numerics.Matrix4x4.Transpose(e), a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.EulerZYX(
                        (Unity.Mathematics.float3)angles * (float)(Math.PI / 2)
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0006;
            Assert.Less(dm1, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm3:{dm3}");
        }

        [Test]
        public static void TestAxisAngle() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var axis = Utility.RandomAxis(ref rng);
                var angle = Utility.RandomI17F15(ref rng);
                var a = Matrix3x3I2F30.AxisAngleP5(axis, angle);

                {
                    // Remarks
                    //
                    // For matrix transformations, the Vector2, Vector3, and Vector4
                    // instances are represented as rows: a vector v is transformed by
                    // a matrix M with vM multiplication.
                    //
                    // https://learn.microsoft.com/en-us/dotnet/api/system.numerics.matrix4x4
                    var e = System.Numerics.Matrix4x4.Transpose(
                        System.Numerics.Matrix4x4.CreateFromAxisAngle(
                            (System.Numerics.Vector3)axis,
                            (float)(angle.LossyToSingle() * Math.PI / 2)
                        )
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
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
                    if (d > 0.1) { Assert.Fail(); };
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.AxisAngle(
                        (Unity.Mathematics.float3)axis,
                        (float)(angle.LossyToSingle() * Math.PI / 2)
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0002;
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
        }

        [Test]
        public static void TestLookRotation() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                Vector3I2F30 forward, up;
                {
                    var q1 = QuaternionTest.RandomQuaternion(ref rng);
                    var q2 = QuaternionTest.RandomQuaternion(ref rng);
                    forward = q1.Rotate(Vector3I2F30.UnitX);
                    up = q2.Rotate(Vector3I2F30.UnitX);
                }
                var a = Matrix3x3I2F30.LookRotation(forward, up);

                {
                    // System.Numerics は右手系であるから
                    // forward を符号反転し、行列を転置 **しない** ことで
                    // 同じ値になる。
                    var e = System.Numerics.Matrix4x4.CreateLookAt(
                        System.Numerics.Vector3.Zero,
                        -(System.Numerics.Vector3)forward,
                        (System.Numerics.Vector3)up
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = UnityEngine.Matrix4x4.LookAt(
                        UnityEngine.Vector3.zero,
                        (UnityEngine.Vector3)forward,
                        (UnityEngine.Vector3)up
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.LookRotation(
                        (Unity.Mathematics.float3)forward,
                        (Unity.Mathematics.float3)up
                    );
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0007;
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
        }

        [Test]
        public static void TestLookRotationSafe() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                Vector3I2F30 forward, up;
                {
                    var q1 = QuaternionTest.RandomQuaternion(ref rng);
                    var q2 = QuaternionTest.RandomQuaternion(ref rng);
                    forward = q1.Rotate(Vector3I2F30.UnitX);
                    up = q2.Rotate(Vector3I2F30.UnitX);
                }
                var a = Matrix3x3I2F30.LookRotationSafe(forward, up);

                if (!a.HasValue) {
                    continue;
                }

                {
                    var e = System.Numerics.Matrix4x4.CreateLookAt(
                        System.Numerics.Vector3.Zero,
                        -(System.Numerics.Vector3)forward,
                        (System.Numerics.Vector3)up
                    );
                    var d = Delta(e, a.Value);
                    if (d > 0.1) { Assert.Fail(); };
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = UnityEngine.Matrix4x4.LookAt(
                        UnityEngine.Vector3.zero,
                        (UnityEngine.Vector3)forward,
                        (UnityEngine.Vector3)up
                    );
                    var d = Delta(e, a.Value);
                    if (d > 0.1) { Assert.Fail(); };
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float3x3.LookRotation(
                        (Unity.Mathematics.float3)forward,
                        (Unity.Mathematics.float3)up
                    );
                    var d = Delta(e, a.Value);
                    if (d > 0.1) { Assert.Fail(); };
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0007;
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
        }
    }
} // namespace Intar1991.Tests
