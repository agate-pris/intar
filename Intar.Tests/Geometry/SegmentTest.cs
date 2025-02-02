using Intar.Geometry;
using NUnit.Framework;

namespace Intar.Tests.Geometry {
    public class SegmentTest {
        static void AssertIntersects(Segment2I17F15 a, Segment2I17F15 b, bool cond) {
            var c = new Segment2I17F15(a.P2, a.P1);
            var d = new Segment2I17F15(b.P2, b.P1);
            var e = new Segment2I17F15(a.P1, a.P1);
            var f = new Segment2I17F15(a.P2, a.P2);
            var g = new Segment2I17F15(b.P1, b.P1);
            var h = new Segment2I17F15(b.P2, b.P2);
            if (!a.Intersects(a) ||
                !a.Intersects(c) ||
                !b.Intersects(b) ||
                !b.Intersects(d) ||
                !c.Intersects(a) ||
                !c.Intersects(c) ||
                !d.Intersects(b) ||
                !d.Intersects(d)) {
                Assert.Fail();
            }
            if (!e.Intersects(e) ||
                !f.Intersects(f) ||
                !g.Intersects(g) ||
                !h.Intersects(h)) {
                Assert.Fail();
            }
            if (!a.Intersects(e) ||
                !a.Intersects(f) ||
                !b.Intersects(g) ||
                !b.Intersects(h) ||
                !c.Intersects(e) ||
                !c.Intersects(f) ||
                !d.Intersects(g) ||
                !d.Intersects(h)) {
                Assert.Fail();
            }
            if (a.Intersects(b) != cond ||
                a.Intersects(d) != cond ||
                b.Intersects(a) != cond ||
                b.Intersects(c) != cond ||
                c.Intersects(b) != cond ||
                c.Intersects(d) != cond ||
                d.Intersects(a) != cond ||
                d.Intersects(c) != cond) {
                Assert.Fail();
            }
            if (!cond) {
                if (a.Intersects(g) ||
                    a.Intersects(h) ||
                    b.Intersects(e) ||
                    b.Intersects(f) ||
                    c.Intersects(g) ||
                    c.Intersects(h) ||
                    d.Intersects(e) ||
                    d.Intersects(f)) {
                    Assert.Fail();
                }
            }
        }
        static void AssertOverlaps(Segment2I17F15 a, Segment2I17F15 b, bool cond) {
            var c = new Segment2I17F15(a.P2, a.P1);
            var d = new Segment2I17F15(b.P2, b.P1);
            var e = new Segment2I17F15(a.P1, a.P1);
            var f = new Segment2I17F15(a.P2, a.P2);
            var g = new Segment2I17F15(b.P1, b.P1);
            var h = new Segment2I17F15(b.P2, b.P2);
            if (a.Overlaps(a) ||
                a.Overlaps(c) ||
                b.Overlaps(b) ||
                b.Overlaps(d) ||
                c.Overlaps(a) ||
                c.Overlaps(c) ||
                d.Overlaps(b) ||
                d.Overlaps(d)) {
                Assert.Fail();
            }
            if (a.Overlaps(b) != cond ||
                a.Overlaps(d) != cond ||
                b.Overlaps(a) != cond ||
                b.Overlaps(c) != cond ||
                c.Overlaps(b) != cond ||
                c.Overlaps(d) != cond ||
                d.Overlaps(a) != cond ||
                d.Overlaps(c) != cond) {
                Assert.Fail();
            }
            if (a.Overlaps(e) ||
                a.Overlaps(f) ||
                b.Overlaps(g) ||
                b.Overlaps(h) ||
                c.Overlaps(e) ||
                c.Overlaps(f) ||
                d.Overlaps(g) ||
                d.Overlaps(h) ||
                e.Overlaps(a) ||
                e.Overlaps(c) ||
                f.Overlaps(a) ||
                f.Overlaps(c) ||
                g.Overlaps(b) ||
                g.Overlaps(d) ||
                h.Overlaps(b) ||
                h.Overlaps(d)) {
                Assert.Fail();
            }
        }
        [Test]
        public static void TestSegment() {
            var p1 = Vector2I17F15.Zero;
            var p2 = Vector2I17F15.UnitX;
            var p3 = Vector2I17F15.UnitY;
            var p4 = Vector2I17F15.One;

            // 点と点
            {
                var segs = new Segment2I17F15[] {
                    new Segment2I17F15(p1, p1),
                    new Segment2I17F15(p2, p2),
                    new Segment2I17F15(p3, p3),
                    new Segment2I17F15(p4, p4),
                };
                foreach (var a in segs) {
                    foreach (var b in segs) {
                        if (a.Equals(b)) {
                            continue;
                        }
                        AssertIntersects(a, b, false);
                        AssertOverlaps(a, b, false);
                    }
                }
            }

            // !Intersects, !Overlaps
            {
                var l = new Segment2I17F15[][] {
                    new Segment2I17F15[] {
                        new Segment2I17F15(p1, p2),
                        new Segment2I17F15(p3, p4),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p1, p3),
                        new Segment2I17F15(p2, p4),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p2, p4),
                        new Segment2I17F15(p1, p3),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p3, p4),
                        new Segment2I17F15(p1, p2),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p1, p4),
                        new Segment2I17F15(p2, p2),
                        new Segment2I17F15(p3, p3),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p2, p3),
                        new Segment2I17F15(p1, p1),
                        new Segment2I17F15(p4, p4),
                    },
                };
                foreach (var segs in l) {
                    for (var i = 1; i < segs.Length; i++) {
                        AssertIntersects(segs[0], segs[i], false);
                        AssertOverlaps(segs[0], segs[i], false);
                    }
                }
            }

            // Intersects, !Overlaps
            {
                var l = new Segment2I17F15[][] {
                    new Segment2I17F15[] {
                        new Segment2I17F15(p1, p2),
                        new Segment2I17F15(p1, p3),
                        new Segment2I17F15(p2, p4),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p1, p3),
                        new Segment2I17F15(p1, p2),
                        new Segment2I17F15(p3, p4),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p2, p4),
                        new Segment2I17F15(p2, p1),
                        new Segment2I17F15(p4, p3),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p3, p4),
                        new Segment2I17F15(p3, p1),
                        new Segment2I17F15(p4, p2),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p1, p4),
                        new Segment2I17F15(p1, p2),
                        new Segment2I17F15(p1, p3),
                        new Segment2I17F15(p4, p2),
                        new Segment2I17F15(p4, p3),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p2, p3),
                        new Segment2I17F15(p2, p1),
                        new Segment2I17F15(p2, p4),
                        new Segment2I17F15(p3, p1),
                        new Segment2I17F15(p3, p4),
                    },
                };
                foreach (var segs in l) {
                    for (var i = 1; i < segs.Length; i++) {
                        AssertIntersects(segs[0], segs[i], true);
                        AssertOverlaps(segs[0], segs[i], false);
                    }
                }
            }

            // Intersects, Overlaps
            {
                var s1 = new Segment2I17F15(p1, p4);
                var s2 = new Segment2I17F15(p2, p3);
                AssertIntersects(s1, s2, true);
                AssertOverlaps(s1, s2, true);
            }
        }

        [Test]
        public static void TestCircle() {
            var c = new CircleI17F15(Vector2I17F15.One, U17F15.One);
            var p1 = Vector2I17F15.Zero;
            var p2 = new Vector2I17F15((I17F15)0.5f, I17F15.Zero);
            var p3 = new Vector2I17F15((I17F15)1.0f, I17F15.Zero);
            var p4 = new Vector2I17F15((I17F15)1.5f, I17F15.Zero);
            var p5 = new Vector2I17F15((I17F15)1.5f, (I17F15)0.5f);
            var p6 = new Vector2I17F15((I17F15)2.0f, (I17F15)0.5f);
            {
                var l = new Segment2I17F15[] {
                     new Segment2I17F15(p1, p1),
                     new Segment2I17F15(p1, p2),
                     new Segment2I17F15(p2, p2),
                     new Segment2I17F15(p4, p4),
                     new Segment2I17F15(p4, p6),
                     new Segment2I17F15(p6, p6),
                };
                foreach (var e in l) {
                    if (e.Intersects(c)) {
                        Assert.Fail($"{e}");
                    }
                    if (e.Overlaps(c)) {
                        Assert.Fail($"{e}");
                    }
                    if (!e.P1.Equals(e.P2)) {
                        var r = new Segment2I17F15(e.P2, e.P1);
                        if (r.Intersects(c)) {
                            Assert.Fail($"{r}");
                        }
                        if (r.Overlaps(c)) {
                            Assert.Fail($"{r}");
                        }
                    }
                }
            }
            {
                var l = new Segment2I17F15[] {
                     new Segment2I17F15(p1, p3),
                     new Segment2I17F15(p2, p3),
                     new Segment2I17F15(p2, p4),
                     new Segment2I17F15(p3, p3),
                     new Segment2I17F15(p3, p4),
                };
                foreach (var e in l) {
                    if (!e.Intersects(c)) {
                        Assert.Fail($"{e}");
                    }
                    if (e.Overlaps(c)) {
                        Assert.Fail($"{e}");
                    }
                    if (!e.P1.Equals(e.P2)) {
                        var r = new Segment2I17F15(e.P2, e.P1);
                        if (!r.Intersects(c)) {
                            Assert.Fail($"{r}");
                        }
                        if (r.Overlaps(c)) {
                            Assert.Fail($"{r}");
                        }
                    }
                }
            }
            {
                var l = new Segment2I17F15[] {
                    new Segment2I17F15(p1, p5),
                    new Segment2I17F15(p1, p6),
                    new Segment2I17F15(p2, p5),
                    new Segment2I17F15(p2, p6),
                    new Segment2I17F15(p3, p5),
                    new Segment2I17F15(p3, p6),
                    new Segment2I17F15(p4, p5),
                    new Segment2I17F15(p5, p5),
                    new Segment2I17F15(p5, p6),
                };
                foreach (var e in l) {
                    if (!e.Intersects(c)) {
                        Assert.Fail($"{e}");
                    }
                    if (!e.Overlaps(c)) {
                        Assert.Fail($"{e}");
                    }
                    if (!e.P1.Equals(e.P2)) {
                        var r = new Segment2I17F15(e.P2, e.P1);
                        if (!r.Intersects(c)) {
                            Assert.Fail($"{r}");
                        }
                        if (!r.Overlaps(c)) {
                            Assert.Fail($"{r}");
                        }
                    }
                }
            }
        }
    }
} // namespace Intar.Tests.Geometry
