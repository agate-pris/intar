using Intar1991.Rand;
using NUnit.Framework;

namespace Intar1991.Tests {
    public class VectorTest {
        static void Test(I17F15 x, I17F15 y, I17F15 z, I17F15 w) {
            var p = new System.Numerics.Vector4(
                x.LossyToSingle(),
                y.LossyToSingle(),
                z.LossyToSingle(),
                w.LossyToSingle());
            var q = new Vector4I17F15(x, y, z, w);
            {
                var e = System.Numerics.Vector4.Normalize(p);
                var a = q.Normalize();
                if (!a.HasValue) {
                    Assert.IsTrue(
                        float.IsNaN(e.X) &&
                        float.IsNaN(e.Y) &&
                        float.IsNaN(e.Z) &&
                        float.IsNaN(e.W));
                }
                const double delta = 0.00004;
                Utility.AssertAreEqual(e.X, (a?.X ?? I17F15.Zero).LossyToSingle(), delta);
                Utility.AssertAreEqual(e.Y, (a?.Y ?? I17F15.Zero).LossyToSingle(), delta);
                Utility.AssertAreEqual(e.Z, (a?.Z ?? I17F15.Zero).LossyToSingle(), delta);
                Utility.AssertAreEqual(e.W, (a?.W ?? I17F15.Zero).LossyToSingle(), delta);
            }
        }
        static void Test(I17F15 x, I17F15 y, I17F15 z) {
            var p = new System.Numerics.Vector3(
                x.LossyToSingle(),
                y.LossyToSingle(),
                z.LossyToSingle());
            var q = new Vector3I17F15(x, y, z);
            {
                var e = System.Numerics.Vector3.Normalize(p);
                var a = q.Normalize();
                if (!a.HasValue) {
                    Assert.IsTrue(
                        float.IsNaN(e.X) &&
                        float.IsNaN(e.Y) &&
                        float.IsNaN(e.Z));
                }
                const double delta = 0.00004;
                Utility.AssertAreEqual(e.X, (a?.X ?? I17F15.Zero).LossyToSingle(), delta);
                Utility.AssertAreEqual(e.Y, (a?.Y ?? I17F15.Zero).LossyToSingle(), delta);
                Utility.AssertAreEqual(e.Z, (a?.Z ?? I17F15.Zero).LossyToSingle(), delta);
            }
            {
                var a = q.LengthSquared();
                const double delta = 1024;
                Utility.AssertAreEqual(p.LengthSquared(), a.LossyToSingle(), delta);
            }
            {
                var a = q.Length();
                const double delta = 0.008;
                Utility.AssertAreEqual(p.Length(), a.LossyToSingle(), delta);
            }
        }
        static void Test(I17F15 x, I17F15 y) {
            var p = new System.Numerics.Vector2(
                x.LossyToSingle(),
                y.LossyToSingle());
            var q = new Vector2I17F15(x, y);
            {
                var e = System.Numerics.Vector2.Normalize(p);
                var a = q.Normalize();
                if (!a.HasValue) {
                    Assert.IsTrue(
                        float.IsNaN(e.X) &&
                        float.IsNaN(e.Y));
                }
                const double delta = 0.00004;
                Utility.AssertAreEqual(e.X, (a?.X ?? I17F15.Zero).LossyToSingle(), delta);
                Utility.AssertAreEqual(e.Y, (a?.Y ?? I17F15.Zero).LossyToSingle(), delta);
            }
            {
                var a = q.LengthSquared();
                const double delta = 1024;
                Utility.AssertAreEqual(p.LengthSquared(), a.LossyToSingle(), delta);
            }
            {
                var a = q.Length();
                const double delta = 0.008;
                Utility.AssertAreEqual(p.Length(), a.LossyToSingle(), delta);
            }
        }

        [Test]
        public static void Test() {
            const int k = 1 << 15;
            var coords = new I17F15[] {
                I17F15.FromBits(int.MinValue),
                I17F15.FromBits(int.MaxValue),
                I17F15.FromBits(-k - 1),
                I17F15.FromBits(-k + 1),
                I17F15.FromBits(k - 1),
                I17F15.FromBits(k + 1),
                I17F15.FromBits(-1),
                I17F15.FromBits(0),
                I17F15.FromBits(1),
                I17F15.FromBits(k),
            };
            var rng = new Xoroshiro128StarStar(1, 2);
            foreach (var x in coords) {
                foreach (var y in coords) {
                    foreach (var z in coords) {
                        foreach (var w in coords) {
                            Test(x, y, z, w);
                            Test(
                                I17F15.FromBits(rng.Next()),
                                I17F15.FromBits(rng.Next()),
                                I17F15.FromBits(rng.Next()),
                                I17F15.FromBits(rng.Next()));
                        }
                        Test(x, y, z);
                        Test(
                            I17F15.FromBits(rng.Next()),
                            I17F15.FromBits(rng.Next()),
                            I17F15.FromBits(rng.Next()));
                    }
                    Test(x, y);
                    Test(
                        I17F15.FromBits(rng.Next()),
                        I17F15.FromBits(rng.Next()));
                }
            }
        }
    }
}
