using Intar.Geometry;
using NUnit.Framework;

namespace Intar.Tests.Geometry {
    public class SegmentTest {
        [Test]
        public static void TestSegment() {
            var p1 = Vector2I17F15.Zero;
            var p2 = Vector2I17F15.UnitX;
            var p3 = Vector2I17F15.UnitY;
            var p4 = Vector2I17F15.One;
            {
                var l = new Segment2I17F15[][] {
                    new Segment2I17F15[] {
                        new Segment2I17F15(p1, p1),
                        new Segment2I17F15(p1, p2),
                        new Segment2I17F15(p2, p2),
                        new Segment2I17F15(p3, p3),
                        new Segment2I17F15(p3, p4),
                        new Segment2I17F15(p4, p4),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p1, p1),
                        new Segment2I17F15(p1, p3),
                        new Segment2I17F15(p2, p2),
                        new Segment2I17F15(p2, p4),
                        new Segment2I17F15(p3, p3),
                        new Segment2I17F15(p4, p4),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p1, p1),
                        new Segment2I17F15(p1, p4),
                        new Segment2I17F15(p2, p2),
                        new Segment2I17F15(p3, p3),
                        new Segment2I17F15(p4, p4),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p1, p1),
                        new Segment2I17F15(p2, p2),
                        new Segment2I17F15(p2, p3),
                        new Segment2I17F15(p3, p3),
                        new Segment2I17F15(p4, p4),
                    },
                };
                foreach (var segments in l) {
                    foreach (var a in segments) {
                        foreach (var b in segments) {
                            if (!a.P1.Equals(a.P2)) {
                                var c = new Segment2I17F15(a.P2, a.P1);
                                if (!b.P1.Equals(b.P2)) {
                                    var d = new Segment2I17F15(b.P2, b.P1);
                                    Assert.IsFalse(c.Intersects(d));
                                    Assert.IsFalse(d.Intersects(c));
                                }
                                Assert.IsFalse(a.Intersects(c));
                                Assert.IsFalse(b.Intersects(c));
                                Assert.IsFalse(c.Intersects(a));
                                Assert.IsFalse(c.Intersects(b));
                                Assert.IsFalse(c.Intersects(c));
                            } else if (!b.P1.Equals(b.P2)) {
                                var d = new Segment2I17F15(b.P2, b.P1);
                                Assert.IsFalse(a.Intersects(d));
                                Assert.IsFalse(b.Intersects(d));
                                Assert.IsFalse(d.Intersects(a));
                                Assert.IsFalse(d.Intersects(b));
                                Assert.IsFalse(d.Intersects(d));
                            }
                            Assert.IsFalse(a.Intersects(a));
                            Assert.IsFalse(a.Intersects(b));
                            Assert.IsFalse(b.Intersects(a));
                            Assert.IsFalse(b.Intersects(b));
                        }
                    }
                }
            }
            {
                var l = new Segment2I17F15[][] {
                    new Segment2I17F15[] {
                        new Segment2I17F15(p1, p2),
                        new Segment2I17F15(p1, p3),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p1, p2),
                        new Segment2I17F15(p1, p4),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p1, p3),
                        new Segment2I17F15(p1, p4),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p2, p1),
                        new Segment2I17F15(p2, p3),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p2, p1),
                        new Segment2I17F15(p2, p4),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p2, p3),
                        new Segment2I17F15(p2, p4),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p3, p1),
                        new Segment2I17F15(p3, p2),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p3, p1),
                        new Segment2I17F15(p3, p4),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p3, p2),
                        new Segment2I17F15(p3, p4),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p4, p1),
                        new Segment2I17F15(p4, p2),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p4, p1),
                        new Segment2I17F15(p4, p3),
                    },
                    new Segment2I17F15[] {
                        new Segment2I17F15(p4, p2),
                        new Segment2I17F15(p4, p3),
                    },
                };
                foreach (var segments in l) {
                    var a = segments[0];
                    var b = segments[1];
                    var c = new Segment2I17F15(a.P2, a.P1);
                    var d = new Segment2I17F15(b.P2, b.P1);
                    Assert.IsFalse(a.Intersects(a));
                    Assert.IsFalse(a.Intersects(c));
                    Assert.IsFalse(b.Intersects(b));
                    Assert.IsFalse(b.Intersects(d));
                    Assert.IsFalse(c.Intersects(a));
                    Assert.IsFalse(c.Intersects(c));
                    Assert.IsFalse(d.Intersects(b));
                    Assert.IsFalse(d.Intersects(d));
                    Assert.IsTrue(a.Intersects(b));
                    Assert.IsTrue(a.Intersects(d));
                    Assert.IsTrue(b.Intersects(a));
                    Assert.IsTrue(b.Intersects(c));
                    Assert.IsTrue(c.Intersects(b));
                    Assert.IsTrue(c.Intersects(d));
                    Assert.IsTrue(d.Intersects(a));
                    Assert.IsTrue(d.Intersects(c));
                }
            }
            {
                var a = new Segment2I17F15(p1, p4);
                var b = new Segment2I17F15(p2, p3);
                var c = new Segment2I17F15(p4, p1);
                var d = new Segment2I17F15(p3, p2);
                Assert.IsFalse(a.Intersects(a));
                Assert.IsFalse(a.Intersects(c));
                Assert.IsFalse(b.Intersects(b));
                Assert.IsFalse(b.Intersects(d));
                Assert.IsFalse(c.Intersects(a));
                Assert.IsFalse(c.Intersects(c));
                Assert.IsFalse(d.Intersects(b));
                Assert.IsFalse(d.Intersects(d));
                Assert.IsTrue(a.Intersects(b));
                Assert.IsTrue(a.Intersects(d));
                Assert.IsTrue(b.Intersects(a));
                Assert.IsTrue(b.Intersects(c));
                Assert.IsTrue(c.Intersects(b));
                Assert.IsTrue(c.Intersects(d));
                Assert.IsTrue(d.Intersects(a));
                Assert.IsTrue(d.Intersects(c));
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
                    Assert.IsFalse(e.Intersects(c), $"{e}");
                    if (!e.P1.Equals(e.P2)) {
                        var r = new Segment2I17F15(e.P2, e.P1);
                        Assert.IsFalse(r.Intersects(c));
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
                    Assert.IsTrue(e.Intersects(c), $"{e}");
                    if (!e.P1.Equals(e.P2)) {
                        var r = new Segment2I17F15(e.P2, e.P1);
                        Assert.IsTrue(r.Intersects(c), $"{r}");
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
                    Assert.IsTrue(e.Intersects(c), $"{e}");
                    if (!e.P1.Equals(e.P2)) {
                        var r = new Segment2I17F15(e.P2, e.P1);
                        Assert.IsTrue(r.Intersects(c), $"{r}");
                    }
                }
            }
        }
    }
} // namespace Intar.Tests.Geometry
