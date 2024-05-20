using AgatePris.Intar.Mathematics;
using AgatePris.Intar.Splines;
using NUnit.Framework;

namespace AgatePris.Intar.Tests.Splines {
    public partial class BezierCurveTest {
        [Test]
        public void EvaluatePositionTest() {
            var curve = new BezierCurve2D(
                new Int2(0, 0),
                new Int2(0, 1000),
                new Int2(1000, 1000),
                new Int2(1000, 0)
            );

            var expected = new Int2[] {
                new Int2(0, 0),
                new Int2(2, 90),
                new Int2(11, 175),
                new Int2(24, 254),
                new Int2(42, 328),
                new Int2(65, 395),
                new Int2(92, 457),
                new Int2(122, 512),
                new Int2(156, 562),
                new Int2(192, 606),
                new Int2(231, 644),
                new Int2(273, 676),
                new Int2(316, 703),
                new Int2(361, 723),
                new Int2(406, 738),
                new Int2(453, 747),
                new Int2(500, 750),
                new Int2(546, 747),
                new Int2(593, 738),
                new Int2(638, 723),
                new Int2(683, 703),
                new Int2(726, 676),
                new Int2(768, 644),
                new Int2(807, 606),
                new Int2(843, 562),
                new Int2(877, 512),
                new Int2(907, 457),
                new Int2(934, 395),
                new Int2(957, 328),
                new Int2(975, 254),
                new Int2(988, 175),
                new Int2(997, 90),
                new Int2(1000, 0),
            };

            for (var i = 0; i <= 32; ++i) {
                var t = (1 << 30) / 32 * i;
                var p = CurveUtility.EvaluatePosition(curve, t);
                Assert.AreEqual(expected[i], p, $"i: {i}");
            }
        }
    }
}
