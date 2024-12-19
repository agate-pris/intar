using System;

using Intar1991.Rand;
using NUnit.Framework;

namespace Intar1991.Tests {
    public class AffineTransformTest {
        public static AffineTransformI17F15 RandomTrs(ref Xoroshiro128StarStar rng) {
            var axis = QuaternionTest.RandomAxis(ref rng);
            var angle = QuaternionTest.RandomI17F15(ref rng);
            var t = QuaternionTest.RandomPosition(ref rng);
            var r = QuaternionI2F30.AxisAngleP5(axis, angle);
            var s = new Vector3I17F15(
                I17F15.FromBits(rng.Next(16384, 65536)),
                I17F15.FromBits(rng.Next(16384, 65536)),
                I17F15.FromBits(rng.Next(16384, 65536)));
            return AffineTransformI17F15.Trs(t, r, s);
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
            for (var i = 0; i < 32768; i++) {
                var p = RandomTrs(ref rng);
                var q = RandomTrs(ref rng);
                var a = p * q;

                {
                    var e = (System.Numerics.Matrix4x4)q * (System.Numerics.Matrix4x4)p;
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); }
                    dm1 = Math.Max(dm1, d);
                }

#if UNITY_5_3_OR_NEWER
                {
                    var e = UnityEngine.Matrix4x4.TRS(
                        (UnityEngine.Vector3)q.Translation,
                        (UnityEngine.Quaternion)q.Rotation,
                        (UnityEngine.Vector3)q.Scale) *
                        UnityEngine.Matrix4x4.TRS(
                            (UnityEngine.Vector3)p.Translation,
                            (UnityEngine.Quaternion)p.Rotation,
                            (UnityEngine.Vector3)p.Scale);
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); }
                    dm1 = Math.Max(dm1, d);
                }
#endif

#if UNITY_2018_1_OR_NEWER
                {
                    var e = UnityEngine.Matrix4x4.TRS(
                        (UnityEngine.Vector3)q.Translation,
                        (UnityEngine.Quaternion)q.Rotation,
                        (UnityEngine.Vector3)q.Scale) *
                        UnityEngine.Matrix4x4.TRS(
                            (UnityEngine.Vector3)p.Translation,
                            (UnityEngine.Quaternion)p.Rotation,
                            (UnityEngine.Vector3)p.Scale);
                    var d = Delta(e, a);
                    if (d > 0.1) { Assert.Fail(); }
                    dm1 = Math.Max(dm1, d);
                }
#endif
            }
            QuaternionTest.Log($"dm1:{dm1}");
        }
    }
}
