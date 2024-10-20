using AgatePris.Intar.Rand;
using NUnit.Framework;

namespace AgatePris.Intar.Tests.Numerics {
    public class VectorTest {
        static void Test(I17F15 x, I17F15 y, I17F15 z, I17F15 w) {
            var p = new System.Numerics.Vector4(
                (float)x,
                (float)y,
                (float)z,
                (float)w);
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
                Utility.AssertAreEqual(e.X, (float)(a?.X ?? I17F15.Zero), delta);
                Utility.AssertAreEqual(e.Y, (float)(a?.Y ?? I17F15.Zero), delta);
                Utility.AssertAreEqual(e.Z, (float)(a?.Z ?? I17F15.Zero), delta);
                Utility.AssertAreEqual(e.W, (float)(a?.W ?? I17F15.Zero), delta);
            }
        }
        static void Test(I17F15 x, I17F15 y, I17F15 z) {
            var p = new System.Numerics.Vector3(
                (float)x,
                (float)y,
                (float)z);
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
                Utility.AssertAreEqual(e.X, (float)(a?.X ?? I17F15.Zero), delta);
                Utility.AssertAreEqual(e.Y, (float)(a?.Y ?? I17F15.Zero), delta);
                Utility.AssertAreEqual(e.Z, (float)(a?.Z ?? I17F15.Zero), delta);
            }
            {
                var a = q.LengthSquared();
                const double delta = 1024;
                Utility.AssertAreEqual(p.LengthSquared(), (float)a, delta);
            }
            {
                var a = q.Length();
                const double delta = 0.004;
                Utility.AssertAreEqual(p.Length() / 2, (float)a, delta);
            }
        }
        static void Test(I17F15 x, I17F15 y) {
            var p = new System.Numerics.Vector2(
                (float)x,
                (float)y);
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
                Utility.AssertAreEqual(e.X, (float)(a?.X ?? I17F15.Zero), delta);
                Utility.AssertAreEqual(e.Y, (float)(a?.Y ?? I17F15.Zero), delta);
            }
            {
                var a = q.LengthSquared();
                const double delta = 1024;
                Utility.AssertAreEqual(p.LengthSquared(), (float)a, delta);
            }
            {
                var a = q.Length();
                const double delta = 0.004;
                Utility.AssertAreEqual(p.Length() / 2, (float)a, delta);
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
