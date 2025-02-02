using Intar.Geometry;
using NUnit.Framework;

namespace Intar.Tests.Geometry {
    public class CircleTest {
        [Test]
        public static void TestPoint() {
            var p1 = Vector2I17F15.Zero;
            var p2 = Vector2I17F15.UnitX;
            var p3 = Vector2I17F15.UnitY;
            var p4 = Vector2I17F15.One;
            var c1 = new CircleI17F15(p1, U17F15.One);
            var c2 = new CircleI17F15(p2, U17F15.One);
            var c3 = new CircleI17F15(p3, U17F15.One);
            var c4 = new CircleI17F15(p4, U17F15.One);
            Assert.IsTrue(new CircleI17F15().Intersects(p1));
            Assert.IsFalse(new CircleI17F15().Overlaps(p1));
            Assert.IsTrue(c1.Intersects(p1));
            Assert.IsTrue(c1.Intersects(p2));
            Assert.IsTrue(c1.Intersects(p3));
            Assert.IsTrue(c2.Intersects(p1));
            Assert.IsTrue(c2.Intersects(p2));
            Assert.IsTrue(c2.Intersects(p4));
            Assert.IsTrue(c3.Intersects(p1));
            Assert.IsTrue(c3.Intersects(p3));
            Assert.IsTrue(c3.Intersects(p4));
            Assert.IsTrue(c4.Intersects(p2));
            Assert.IsTrue(c4.Intersects(p3));
            Assert.IsTrue(c4.Intersects(p4));
            Assert.IsTrue(c1.Overlaps(p1));
            Assert.IsTrue(c2.Overlaps(p2));
            Assert.IsTrue(c3.Overlaps(p3));
            Assert.IsTrue(c4.Overlaps(p4));
            Assert.IsFalse(c1.Intersects(p4));
            Assert.IsFalse(c2.Intersects(p3));
            Assert.IsFalse(c3.Intersects(p2));
            Assert.IsFalse(c4.Intersects(p1));
            Assert.IsFalse(c1.Overlaps(p2));
            Assert.IsFalse(c1.Overlaps(p3));
            Assert.IsFalse(c1.Overlaps(p4));
            Assert.IsFalse(c2.Overlaps(p1));
            Assert.IsFalse(c2.Overlaps(p3));
            Assert.IsFalse(c2.Overlaps(p4));
            Assert.IsFalse(c3.Overlaps(p1));
            Assert.IsFalse(c3.Overlaps(p2));
            Assert.IsFalse(c3.Overlaps(p4));
            Assert.IsFalse(c4.Overlaps(p1));
            Assert.IsFalse(c4.Overlaps(p2));
            Assert.IsFalse(c4.Overlaps(p3));
        }
        [Test]
        public static void TestCircle() {
            {
                var o = new CircleI17F15(Vector2I17F15.One * (I17F15)0.5f, U17F15.Zero);
                Assert.IsTrue(o.Intersects(o));
                Assert.IsFalse(o.Overlaps(o));
                var l = new CircleI17F15[] {
                    new CircleI17F15(Vector2I17F15.Zero, U17F15.One),
                    new CircleI17F15(Vector2I17F15.UnitX, U17F15.One),
                    new CircleI17F15(Vector2I17F15.UnitY, U17F15.One),
                    new CircleI17F15(Vector2I17F15.One, U17F15.One),
                };
                foreach (var a in l) {
                    Assert.IsTrue(o.Intersects(a));
                    Assert.IsTrue(a.Intersects(o));
                    Assert.IsTrue(o.Overlaps(a));
                    Assert.IsTrue(a.Overlaps(o));
                    foreach (var b in l) {
                        Assert.IsTrue(a.Intersects(b), $"a:{a} b:{b}");
                        Assert.IsTrue(a.Overlaps(b), $"a:{a} b:{b}");
                    }
                }
            }
            {
                var a = new CircleI17F15(Vector2I17F15.Zero, (U17F15)0.5f);
                var b = new CircleI17F15(Vector2I17F15.UnitX, (U17F15)0.5f);
                var c = new CircleI17F15(Vector2I17F15.UnitY, (U17F15)0.5f);
                var d = new CircleI17F15(Vector2I17F15.One, (U17F15)0.5f);
                Assert.IsTrue(a.Intersects(a));
                Assert.IsTrue(a.Intersects(b));
                Assert.IsTrue(a.Intersects(c));
                Assert.IsTrue(b.Intersects(a));
                Assert.IsTrue(b.Intersects(b));
                Assert.IsTrue(b.Intersects(d));
                Assert.IsTrue(c.Intersects(a));
                Assert.IsTrue(c.Intersects(c));
                Assert.IsTrue(c.Intersects(d));
                Assert.IsTrue(d.Intersects(b));
                Assert.IsTrue(d.Intersects(c));
                Assert.IsTrue(d.Intersects(d));
                Assert.IsTrue(a.Overlaps(a));
                Assert.IsTrue(b.Overlaps(b));
                Assert.IsTrue(c.Overlaps(c));
                Assert.IsTrue(d.Overlaps(d));
                Assert.IsFalse(a.Intersects(d));
                Assert.IsFalse(b.Intersects(c));
                Assert.IsFalse(c.Intersects(b));
                Assert.IsFalse(d.Intersects(a));
                Assert.IsFalse(a.Overlaps(b));
                Assert.IsFalse(a.Overlaps(c));
                Assert.IsFalse(a.Overlaps(d));
                Assert.IsFalse(b.Overlaps(a));
                Assert.IsFalse(b.Overlaps(c));
                Assert.IsFalse(b.Overlaps(d));
                Assert.IsFalse(c.Overlaps(a));
                Assert.IsFalse(c.Overlaps(b));
                Assert.IsFalse(c.Overlaps(d));
                Assert.IsFalse(d.Overlaps(a));
                Assert.IsFalse(d.Overlaps(b));
                Assert.IsFalse(d.Overlaps(c));
            }
        }
    }
} // namespace Intar.Tests.Geometry
