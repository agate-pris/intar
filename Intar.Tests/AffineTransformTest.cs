using System;
using System.Runtime.CompilerServices;

using Intar.Rand;
using NUnit.Framework;

namespace Intar.Tests {
    public class AffineTransformTest {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Delta(System.Numerics.Matrix4x4 e, AffineTransform3I17F15 a) {
            var d = 0.0;
            d = Math.Max(d, Math.Abs(e.M11 - (float)a.RotationScale.C0.X));
            d = Math.Max(d, Math.Abs(e.M12 - (float)a.RotationScale.C0.Y));
            d = Math.Max(d, Math.Abs(e.M13 - (float)a.RotationScale.C0.Z));
            d = Math.Max(d, Math.Abs(e.M14));
            d = Math.Max(d, Math.Abs(e.M21 - (float)a.RotationScale.C1.X));
            d = Math.Max(d, Math.Abs(e.M22 - (float)a.RotationScale.C1.Y));
            d = Math.Max(d, Math.Abs(e.M23 - (float)a.RotationScale.C1.Z));
            d = Math.Max(d, Math.Abs(e.M24));
            d = Math.Max(d, Math.Abs(e.M31 - (float)a.RotationScale.C2.X));
            d = Math.Max(d, Math.Abs(e.M32 - (float)a.RotationScale.C2.Y));
            d = Math.Max(d, Math.Abs(e.M33 - (float)a.RotationScale.C2.Z));
            d = Math.Max(d, Math.Abs(e.M34));
            d = Math.Max(d, Math.Abs(e.M41 - (float)a.Translation.X));
            d = Math.Max(d, Math.Abs(e.M42 - (float)a.Translation.Y));
            d = Math.Max(d, Math.Abs(e.M43 - (float)a.Translation.Z));
            d = Math.Max(d, Math.Abs(e.M44 - 1.0));
            return d;
        }

#if UNITY_5_3_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Delta(UnityEngine.Matrix4x4 e, AffineTransform3I17F15 a) {
            var d = 0.0;
            d = Math.Max(d, Math.Abs(e.m00 - (float)a.RotationScale.C0.X));
            d = Math.Max(d, Math.Abs(e.m10 - (float)a.RotationScale.C0.Y));
            d = Math.Max(d, Math.Abs(e.m20 - (float)a.RotationScale.C0.Z));
            d = Math.Max(d, Math.Abs(e.m30));
            d = Math.Max(d, Math.Abs(e.m01 - (float)a.RotationScale.C1.X));
            d = Math.Max(d, Math.Abs(e.m11 - (float)a.RotationScale.C1.Y));
            d = Math.Max(d, Math.Abs(e.m21 - (float)a.RotationScale.C1.Z));
            d = Math.Max(d, Math.Abs(e.m31));
            d = Math.Max(d, Math.Abs(e.m02 - (float)a.RotationScale.C2.X));
            d = Math.Max(d, Math.Abs(e.m12 - (float)a.RotationScale.C2.Y));
            d = Math.Max(d, Math.Abs(e.m22 - (float)a.RotationScale.C2.Z));
            d = Math.Max(d, Math.Abs(e.m32));
            d = Math.Max(d, Math.Abs(e.m03 - (float)a.Translation.X));
            d = Math.Max(d, Math.Abs(e.m13 - (float)a.Translation.Y));
            d = Math.Max(d, Math.Abs(e.m23 - (float)a.Translation.Z));
            d = Math.Max(d, Math.Abs(e.m33 - 1.0));
            return d;
        }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Delta(Unity.Mathematics.float4x4 e, AffineTransform3I17F15 a) {
            var d = 0.0;
            d = Math.Max(d, Math.Abs(e.c0.x - (float)a.RotationScale.C0.X));
            d = Math.Max(d, Math.Abs(e.c0.y - (float)a.RotationScale.C0.Y));
            d = Math.Max(d, Math.Abs(e.c0.z - (float)a.RotationScale.C0.Z));
            d = Math.Max(d, Math.Abs(e.c0.w));
            d = Math.Max(d, Math.Abs(e.c1.x - (float)a.RotationScale.C1.X));
            d = Math.Max(d, Math.Abs(e.c1.y - (float)a.RotationScale.C1.Y));
            d = Math.Max(d, Math.Abs(e.c1.z - (float)a.RotationScale.C1.Z));
            d = Math.Max(d, Math.Abs(e.c1.w));
            d = Math.Max(d, Math.Abs(e.c2.x - (float)a.RotationScale.C2.X));
            d = Math.Max(d, Math.Abs(e.c2.y - (float)a.RotationScale.C2.Y));
            d = Math.Max(d, Math.Abs(e.c2.z - (float)a.RotationScale.C2.Z));
            d = Math.Max(d, Math.Abs(e.c2.w));
            d = Math.Max(d, Math.Abs(e.c3.x - (float)a.Translation.X));
            d = Math.Max(d, Math.Abs(e.c3.y - (float)a.Translation.Y));
            d = Math.Max(d, Math.Abs(e.c3.z - (float)a.Translation.Z));
            d = Math.Max(d, Math.Abs(e.c3.w - 1.0));
            return d;
        }
#endif // UNITY_2018_1_OR_NEWER

        static readonly AffineTransform3I17F15 sample = new AffineTransform3I17F15(
            new Matrix3x3I17F15(
                new Vector3I17F15((I17F15)1, (I17F15)2, (I17F15)3),
                new Vector3I17F15((I17F15)4, (I17F15)5, (I17F15)6),
                new Vector3I17F15((I17F15)7, (I17F15)8, (I17F15)9)),
            new Vector3I17F15((I17F15)10, (I17F15)11, (I17F15)12));
        static readonly Vector3I17F15 samplePosition = new Vector3I17F15(
            (I17F15)13, (I17F15)14, (I17F15)15);
        static readonly Vector3I17F15 sampleTransformedPosition = sample * samplePosition;

        [Test]
        public static void TestConversionToSystemNumericsMatrix4x4() {
            var t = (System.Numerics.Matrix4x4)sample;
            var p = (System.Numerics.Vector3)samplePosition;
            var e = System.Numerics.Vector3.Transform(p, t);
            Assert.True(e.Equals((System.Numerics.Vector3)sampleTransformedPosition));
        }

#if UNITY_5_3_OR_NEWER
        [Test]
        public static void TestConversionToUnityEngineMatrix4x4() {
            var t = (UnityEngine.Matrix4x4)sample;
            var p = (UnityEngine.Vector3)samplePosition;
            var e = t.MultiplyPoint(p);
            Assert.True(e.Equals((UnityEngine.Vector3)sampleTransformedPosition));
        }
#endif

#if UNITY_2018_1_OR_NEWER
        [Test]
        public static void TestConversionToUnityMathematicsFloat4x4() {
            var t = (Unity.Mathematics.float4x4)sample;
            var p = (Unity.Mathematics.float3)samplePosition;
            var e = Unity.Mathematics.math.transform(t, p);
            Assert.True(e.Equals((Unity.Mathematics.float3)sampleTransformedPosition));
        }
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static AffineTransform3I17F15 Trs(Vector3I17F15 translation, System.Numerics.Quaternion rotation, Vector3I17F15 scale) {
            return AffineTransform3I17F15.Trs(translation, new QuaternionI2F30(
                (I2F30)rotation.X,
                (I2F30)rotation.Y,
                (I2F30)rotation.Z,
                (I2F30)rotation.W), scale);
        }

        [Test]
        public static void TestTrs() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                // テストでは演算誤差の検証のため浮動小数点数を使用する。
                // 実際のユースケースでは使用しない。

                var translation = Utility.RandomVector3(ref rng);
                var rotation = System.Numerics.Quaternion.CreateFromYawPitchRoll(rng.Next(), rng.Next(), rng.Next());
                var scale = Utility.RandomScale(ref rng);
                var a = Trs(translation, rotation, scale);

                {
                    var t = System.Numerics.Matrix4x4.CreateTranslation((System.Numerics.Vector3)translation);
                    var r = System.Numerics.Matrix4x4.CreateFromQuaternion(rotation);
                    var s = System.Numerics.Matrix4x4.CreateScale((System.Numerics.Vector3)scale);
                    var e = s * r * t;
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); }
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = UnityEngine.Matrix4x4.TRS(
                        (UnityEngine.Vector3)translation,
                        new UnityEngine.Quaternion(rotation.X, rotation.Y, rotation.Z, rotation.W),
                        (UnityEngine.Vector3)scale);
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); }
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var e = Unity.Mathematics.float4x4.TRS(
                        (Unity.Mathematics.float3)translation,
                        new Unity.Mathematics.quaternion(rotation.X, rotation.Y, rotation.Z, rotation.W),
                        (Unity.Mathematics.float3)scale);
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); }
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.00004;
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm1:{dm3}");
        }

        [Test]
        public static void TestMulAffineTransform() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var t1 = Utility.RandomVector3(ref rng);
                var t2 = Utility.RandomVector3(ref rng);
                var r1 = System.Numerics.Quaternion.CreateFromYawPitchRoll(rng.Next(), rng.Next(), rng.Next());
                var r2 = System.Numerics.Quaternion.CreateFromYawPitchRoll(rng.Next(), rng.Next(), rng.Next());
                var s1 = Utility.RandomScale(ref rng);
                var s2 = Utility.RandomScale(ref rng);
                var p = Trs(t1, r1, s1);
                var q = Trs(t2, r2, s2);
                var a = p * q;

                {
                    var e = (System.Numerics.Matrix4x4)q * (System.Numerics.Matrix4x4)p;
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail($"e:{e}\n a:{a}"); }
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = (UnityEngine.Matrix4x4)p * (UnityEngine.Matrix4x4)q;
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail($"e:{e}\n a:{a}"); }
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var l = (Unity.Mathematics.float4x4)p;
                    var r = (Unity.Mathematics.float4x4)q;
                    var e = Unity.Mathematics.math.mul(l, r);
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail($"e:{e}\n a:{a}"); }
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0002;
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
        }

        [Test]
        public static void TestMulAffineTransformVector3() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var translation = Utility.RandomVector3(ref rng);
                var rotation = System.Numerics.Quaternion.CreateFromYawPitchRoll(rng.Next(), rng.Next(), rng.Next());
                var scale = Utility.RandomScale(ref rng);
                var pos = Utility.RandomVector3(ref rng);
                var transform = Trs(translation, rotation, scale);
                var a = transform * pos;

                {
                    var t = (System.Numerics.Matrix4x4)transform;
                    var p = (System.Numerics.Vector3)pos;
                    var e = System.Numerics.Vector3.Transform(p, t);
                    var d1 = Math.Abs(e.X - (float)a.X);
                    var d2 = Math.Abs(e.Y - (float)a.Y);
                    var d3 = Math.Abs(e.Z - (float)a.Z);
                    var d = Math.Max(d1, Math.Max(d2, d3));
                    if (d > 0.1) { Assert.Fail($"e:{e}\n a:{a}"); }
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var t = (UnityEngine.Matrix4x4)transform;
                    var p = new UnityEngine.Vector4(
                        (float)pos.X,
                        (float)pos.Y,
                        (float)pos.Z,
                        1);
                    var e = t * p;
                    var d1 = Math.Abs(e.x - (float)a.X);
                    var d2 = Math.Abs(e.y - (float)a.Y);
                    var d3 = Math.Abs(e.z - (float)a.Z);
                    var d = Math.Max(d1, Math.Max(d2, d3));
                    if (d > 0.1) { Assert.Fail($"e:{e}\n a:{a}"); }
                    dm2 = Math.Max(dm2, d);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var t = (Unity.Mathematics.float4x4)transform;
                    var p = (Unity.Mathematics.float3)pos;
                    var e = Unity.Mathematics.math.transform(t, p);
                    var d1 = Math.Abs(e.x - (float)a.X);
                    var d2 = Math.Abs(e.y - (float)a.Y);
                    var d3 = Math.Abs(e.z - (float)a.Z);
                    var d = Math.Max(d1, Math.Max(d2, d3));
                    if (d > 0.1) { Assert.Fail($"e:{e}\n a:{a}"); }
                    dm3 = Math.Max(dm3, d);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0002;
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
        }

        [Test]
        public static void TestMulAffineTransformMatrix3x3() {
            var rng = new Xoroshiro128StarStar(1, 2);
            var dm1 = 0.0;
            var dm2 = 0.0;
            var dm3 = 0.0;
            for (var i = 0; i < 32768; i++) {
                var translation = Utility.RandomVector3(ref rng);
                var rotation1 = System.Numerics.Quaternion.CreateFromYawPitchRoll(rng.Next(), rng.Next(), rng.Next());
                var rotation2 = System.Numerics.Quaternion.CreateFromYawPitchRoll(rng.Next(), rng.Next(), rng.Next());
                var scale1 = Utility.RandomScale(ref rng);
                var scale2 = Utility.RandomScale(ref rng);
                var transform1 = Trs(translation, rotation1, scale1);
                var transform2 = Trs(Vector3I17F15.Zero, rotation2, scale2);
                var a1 = transform1 * transform2.RotationScale;
                var a2 = transform2.RotationScale * transform1;
                {
                    var t1 = (System.Numerics.Matrix4x4)transform1;
                    var t2 = (System.Numerics.Matrix4x4)transform2;
                    var e1 = t2 * t1;
                    var e2 = t1 * t2;
                    var d1 = Delta(e1, a1);
                    var d2 = Delta(e2, a2);
                    if (d1 > 0.1) { Assert.Fail($"e:{e1}\n a:{a1}"); }
                    if (d2 > 0.1) { Assert.Fail($"e:{e2}\n a:{a2}"); }
                    dm1 = Math.Max(dm1, d1);
                    dm1 = Math.Max(dm1, d2);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var t1 = (UnityEngine.Matrix4x4)transform1;
                    var t2 = (UnityEngine.Matrix4x4)transform2;
                    var e1 = t1 * t2;
                    var e2 = t2 * t1;
                    var d1 = Delta(e1, a1);
                    var d2 = Delta(e2, a2);
                    if (d1 > 0.1) { Assert.Fail($"e:{e1}\n a:{a1}"); }
                    if (d2 > 0.1) { Assert.Fail($"e:{e2}\n a:{a2}"); }
                    dm2 = Math.Max(dm2, d1);
                    dm2 = Math.Max(dm2, d2);
                }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
                {
                    var t1 = (Unity.Mathematics.float4x4)transform1;
                    var t2 = (Unity.Mathematics.float4x4)transform2;
                    var e1 = Unity.Mathematics.math.mul(t1, t2);
                    var e2 = Unity.Mathematics.math.mul(t2, t1);
                    var d1 = Delta(e1, a1);
                    var d2 = Delta(e2, a2);
                    if (d1 > 0.1) { Assert.Fail($"e:{e1}\n a:{a1}"); }
                    if (d2 > 0.1) { Assert.Fail($"e:{e2}\n a:{a2}"); }
                    dm3 = Math.Max(dm3, d1);
                    dm3 = Math.Max(dm3, d2);
                }
#endif // UNITY_2018_1_OR_NEWER
            }
            const double delta = 0.0002;
            Utility.Log($"dm1:{dm1}");
            Utility.Log($"dm2:{dm2}");
            Utility.Log($"dm3:{dm3}");
            Assert.Less(dm1, delta);
            Assert.Less(dm2, delta);
            Assert.Less(dm3, delta);
        }
    }
}
