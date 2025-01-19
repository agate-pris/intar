using Intar.Geometry;
using NUnit.Framework;

namespace Intar.Tests.Geometry {
    public class SegmentTest {
        [Test]
        public static void TestIntersectsCircle() {
            var a = new Segment2I17F15(
                new Vector2I17F15(I17F15.FromBits(100), I17F15.FromBits(100)),
                new Vector2I17F15(I17F15.FromBits(300), I17F15.FromBits(400))
            );
            var b = new CircleI17F15(
                new Vector2I17F15(I17F15.FromBits(371), I17F15.FromBits(471)),
                U17F15.FromBits(100)
            );
            Assert.IsFalse(a.Intersects(b));
            b.Center = new Vector2I17F15(I17F15.FromBits(370), I17F15.FromBits(470));
            Assert.IsTrue(a.Intersects(b));
        }

        [Test]
        public static void TestIntersectsSegment() {
            var a = new Vector2I17F15(I17F15.FromBits(100), I17F15.FromBits(100));
            var b = new Vector2I17F15(I17F15.FromBits(200), I17F15.FromBits(200));
            var c = new Vector2I17F15(I17F15.FromBits(300), I17F15.FromBits(300));
            var d = new Vector2I17F15(I17F15.FromBits(400), I17F15.FromBits(400));
            var e = new Vector2I17F15(I17F15.FromBits(100), I17F15.FromBits(200));
            var f = new Vector2I17F15(I17F15.FromBits(300), I17F15.FromBits(200));
            var g = new Vector2I17F15(I17F15.FromBits(400), I17F15.FromBits(200));
            var h = new Vector2I17F15(I17F15.FromBits(200), I17F15.FromBits(100));
            var i = new Vector2I17F15(I17F15.FromBits(200), I17F15.FromBits(300));
            var j = new Vector2I17F15(I17F15.FromBits(200), I17F15.FromBits(400));
            {
                var p = new Segment2I17F15(a, c);
                var q = new Segment2I17F15(b, d);
                Assert.IsTrue(p.Disjoint(q));
                Assert.IsFalse(p.Intersects(q));
            }
            {
                var p = new Segment2I17F15(e, f);
                var q = new Segment2I17F15(b, g);
                Assert.IsTrue(p.Disjoint(q));
                Assert.IsFalse(p.Intersects(q));
            }
            {
                var p = new Segment2I17F15(h, i);
                var q = new Segment2I17F15(b, j);
                Assert.IsTrue(p.Disjoint(q));
                Assert.IsFalse(p.Intersects(q));
            }
            {
                var p = new Segment2I17F15(a, c);
                var q = new Segment2I17F15(e, f);
                Assert.IsTrue(p.Intersects(q));
                Assert.IsFalse(p.Disjoint(q));
            }
            {
                var p = new Segment2I17F15(a, c);
                var q = new Segment2I17F15(h, i);
                Assert.IsTrue(p.Intersects(q));
                Assert.IsFalse(p.Disjoint(q));
            }
            {
                var p = new Segment2I17F15(e, f);
                var q = new Segment2I17F15(h, i);
                Assert.IsTrue(p.Intersects(q));
                Assert.IsFalse(p.Disjoint(q));
            }
        }
    }
} // namespace Intar.Tests.Geometry
