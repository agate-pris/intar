using System.Collections.Generic;

using Intar.Geometry;
using NUnit.Framework;

namespace Intar.Tests {
    public class AabbTest {
        [Test]
        public static void TestAabb() {
            Aabb2I17F15 envelope;
            {
                var centerX = I17F15.FromBits(200);
                var centerY = I17F15.FromBits(300);
                var center = new Vector2I17F15(centerX, centerY);
                var radius = U17F15.FromBits(50);
                var circle = new CircleI17F15(center, radius);
                envelope = new Aabb2I17F15(circle);
            }
            {
                Assert.AreEqual(150, envelope.Min.X.Bits);
                Assert.AreEqual(250, envelope.Min.Y.Bits);
                Assert.AreEqual(250, envelope.Max.X.Bits);
                Assert.AreEqual(350, envelope.Max.Y.Bits);
            }
            var points = new List<Vector2I17F15> {
                new Vector2I17F15(I17F15.FromBits(100), I17F15.FromBits(200)),
                new Vector2I17F15(I17F15.FromBits(100), I17F15.FromBits(300)),
                new Vector2I17F15(I17F15.FromBits(100), I17F15.FromBits(400)),
                new Vector2I17F15(I17F15.FromBits(200), I17F15.FromBits(200)),
                new Vector2I17F15(I17F15.FromBits(200), I17F15.FromBits(300)),
                new Vector2I17F15(I17F15.FromBits(200), I17F15.FromBits(400)),
                new Vector2I17F15(I17F15.FromBits(300), I17F15.FromBits(200)),
                new Vector2I17F15(I17F15.FromBits(300), I17F15.FromBits(300)),
                new Vector2I17F15(I17F15.FromBits(300), I17F15.FromBits(400)),
            };
            {
                var expand = envelope.Expand(new Aabb2I17F15(points[0]));
                Assert.AreEqual(expand.Min, points[0]);
                Assert.AreEqual(expand.Max, envelope.Max);
            }
            {
                var expand = envelope.Expand(new Aabb2I17F15(points[8]));
                Assert.AreEqual(expand.Max, points[8]);
                Assert.AreEqual(expand.Min, envelope.Min);
            }
            {
                var expand = envelope.Expand(points[0]);
                Assert.AreEqual(expand.Min, points[0]);
                Assert.AreEqual(expand.Max, envelope.Max);
            }
            {
                var expand = envelope.Expand(points[8]);
                Assert.AreEqual(expand.Min, envelope.Min);
                Assert.AreEqual(expand.Max, points[8]);
            }
            foreach (var p in points) {
                {
                    var copy = envelope;
                    copy.Min = p;
                    Assert.AreEqual(copy.Min.X, p.X);
                    Assert.AreEqual(copy.Min.Y, p.Y);
                    Assert.AreEqual(copy.Max.X, envelope.Max.X < p.X ? p.X : envelope.Max.X);
                    Assert.AreEqual(copy.Max.Y, envelope.Max.Y < p.Y ? p.Y : envelope.Max.Y);
                }
                {
                    var copy = envelope;
                    copy.Max = p;
                    Assert.AreEqual(copy.Max.X, p.X);
                    Assert.AreEqual(copy.Max.Y, p.Y);
                    Assert.AreEqual(copy.Min.X, envelope.Min.X > p.X ? p.X : envelope.Min.X);
                    Assert.AreEqual(copy.Min.Y, envelope.Min.Y > p.Y ? p.Y : envelope.Min.Y);
                }
                {
                    var copy = envelope;
                    copy.MinX = p.X;
                    Assert.AreEqual(copy.Min.X, p.X);
                    Assert.AreEqual(copy.Min.Y, envelope.Min.Y);
                    Assert.AreEqual(copy.Max.Y, envelope.Max.Y);
                    Assert.AreEqual(copy.Max.X, envelope.Max.X < p.X ? p.X : envelope.Max.X);
                }
                {
                    var copy = envelope;
                    copy.MinY = p.Y;
                    Assert.AreEqual(copy.Min.Y, p.Y);
                    Assert.AreEqual(copy.Min.X, envelope.Min.X);
                    Assert.AreEqual(copy.Max.X, envelope.Max.X);
                    Assert.AreEqual(copy.Max.Y, envelope.Max.Y < p.Y ? p.Y : envelope.Max.Y);
                }
                {
                    var copy = envelope;
                    copy.MaxX = p.X;
                    Assert.AreEqual(copy.Max.X, p.X);
                    Assert.AreEqual(copy.Max.Y, envelope.Max.Y);
                    Assert.AreEqual(copy.Min.Y, envelope.Min.Y);
                    Assert.AreEqual(copy.Min.X, envelope.Min.X > p.X ? p.X : envelope.Min.X);
                }
                {
                    var copy = envelope;
                    copy.MaxY = p.Y;
                    Assert.AreEqual(copy.Max.Y, p.Y);
                    Assert.AreEqual(copy.Max.X, envelope.Max.X);
                    Assert.AreEqual(copy.Min.X, envelope.Min.X);
                    Assert.AreEqual(copy.Min.Y, envelope.Min.Y > p.Y ? p.Y : envelope.Min.Y);
                }
            }
        }
    }
}
