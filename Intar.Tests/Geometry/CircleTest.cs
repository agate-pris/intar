using Intar.Geometry;
using NUnit.Framework;

namespace Intar.Tests.Geometry {
    public class CircleTest {
        [Test]
        public static void TestIntersectsCircle() {
            var a = new CircleI17F15(
                new Vector2I17F15(I17F15.FromBits(10000), I17F15.FromBits(10000)),
                U17F15.FromBits(10000)
            );
            var b = new CircleI17F15(
                new Vector2I17F15(I17F15.FromBits(5000), I17F15.FromBits(5000)),
                U17F15.FromBits(2000)
            );
            Assert.IsTrue(a.Intersects(b));
            b.Center = new Vector2I17F15(I17F15.FromBits(20000), I17F15.FromBits(10000));
            b.Radius = U17F15.FromBits(0);
            Assert.IsTrue(a.Intersects(b));
            b.Center = new Vector2I17F15(I17F15.FromBits(20001), I17F15.FromBits(10000));
            Assert.IsFalse(a.Intersects(b));
            b.Radius = U17F15.FromBits(1);
            Assert.IsTrue(a.Intersects(b));
            b.Radius = U17F15.FromBits(2);
            Assert.IsTrue(a.Intersects(b));
            b.Center = new Vector2I17F15(I17F15.FromBits(30000), I17F15.FromBits(10000));
            b.Radius = U17F15.FromBits(10000);
            Assert.IsTrue(a.Intersects(b));
            b.Radius = U17F15.FromBits(10001);
            Assert.IsTrue(a.Intersects(b));
            b.Radius = U17F15.FromBits(9999);
            Assert.IsFalse(a.Intersects(b));
        }
        [Test]
        public static void TestIntersectsPoint() {
            var a = new CircleI17F15(
                new Vector2I17F15(I17F15.FromBits(10000), I17F15.FromBits(10000)),
                U17F15.FromBits(10000)
            );
            Assert.IsTrue(a.Intersects(new Vector2I17F15(I17F15.FromBits(10000), I17F15.FromBits(10000))));
            Assert.IsTrue(a.Intersects(new Vector2I17F15(I17F15.FromBits(20000), I17F15.FromBits(10000))));
            Assert.IsTrue(a.Intersects(new Vector2I17F15(I17F15.FromBits(10000), I17F15.FromBits(20000))));
            Assert.IsTrue(a.Intersects(new Vector2I17F15(I17F15.FromBits(10000), I17F15.FromBits(0))));
            Assert.IsTrue(a.Intersects(new Vector2I17F15(I17F15.FromBits(0), I17F15.FromBits(10000))));
            Assert.IsFalse(a.Intersects(new Vector2I17F15(I17F15.FromBits(20000), I17F15.FromBits(10001))));
            Assert.IsFalse(a.Intersects(new Vector2I17F15(I17F15.FromBits(20001), I17F15.FromBits(10000))));
            Assert.IsFalse(a.Intersects(new Vector2I17F15(I17F15.FromBits(20000), I17F15.FromBits(9999))));
            Assert.IsFalse(a.Intersects(new Vector2I17F15(I17F15.FromBits(10001), I17F15.FromBits(20000))));
            Assert.IsFalse(a.Intersects(new Vector2I17F15(I17F15.FromBits(10000), I17F15.FromBits(20001))));
            Assert.IsFalse(a.Intersects(new Vector2I17F15(I17F15.FromBits(9999), I17F15.FromBits(20000))));
        }
    }
} // namespace Intar.Tests.Geometry
