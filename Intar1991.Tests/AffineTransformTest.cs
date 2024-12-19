using System;

using Intar1991.Rand;
using NUnit.Framework;

namespace Intar1991.Tests {
    public class AffineTransformTest {
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
                var p = QuaternionTest.RandomPosition(ref rng);
                var trs = AffineTransformI17F15.Trs(t, r, s);

                {
                    var e
                        = System.Numerics.Matrix4x4.CreateScale((System.Numerics.Vector3)s)
                        * System.Numerics.Matrix4x4.CreateFromQuaternion((System.Numerics.Quaternion)r)
                        * System.Numerics.Matrix4x4.CreateTranslation((System.Numerics.Vector3)t);
                    double d = MatrixTest.Delta(e, trs.RotationScale);
                    if (d > 0.2) { Assert.Fail(); }
                    dm1 = Math.Max(dm1, d);
                }
            }
            const double delta = 0.0;
            Assert.Less(dm1, delta);
        }
    }
}
