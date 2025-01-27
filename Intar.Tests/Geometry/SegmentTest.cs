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
                                    if (c.Intersects(d)) {
                                        Assert.Fail();
                                    }
                                    if (d.Intersects(c)) {
                                        Assert.Fail();
                                    }
                                    if (c.Overlaps(d)) {
                                        Assert.Fail();
                                    }
                                    if (d.Overlaps(c)) {
                                        Assert.Fail();
                                    }
                                }
                                if (a.Intersects(c)) {
                                    Assert.Fail();
                                }
                                if (b.Intersects(c)) {
                                    Assert.Fail();
                                }
                                if (c.Intersects(a)) {
                                    Assert.Fail();
                                }
                                if (c.Intersects(b)) {
                                    Assert.Fail();
                                }
                                if (c.Intersects(c)) {
                                    Assert.Fail();
                                }
                                if (a.Overlaps(c)) {
                                    Assert.Fail();
                                }
                                if (b.Overlaps(c)) {
                                    Assert.Fail();
                                }
                                if (c.Overlaps(a)) {
                                    Assert.Fail();
                                }
                                if (c.Overlaps(b)) {
                                    Assert.Fail();
                                }
                                if (c.Overlaps(c)) {
                                    Assert.Fail();
                                }
                            } else if (!b.P1.Equals(b.P2)) {
                                var d = new Segment2I17F15(b.P2, b.P1);
                                if (a.Intersects(d)) {
                                    Assert.Fail();
                                }
                                if (b.Intersects(d)) {
                                    Assert.Fail();
                                }
                                if (d.Intersects(a)) {
                                    Assert.Fail();
                                }
                                if (d.Intersects(b)) {
                                    Assert.Fail();
                                }
                                if (d.Intersects(d)) {
                                    Assert.Fail();
                                }
                                if (a.Overlaps(d)) {
                                    Assert.Fail();
                                }
                                if (b.Overlaps(d)) {
                                    Assert.Fail();
                                }
                                if (d.Overlaps(a)) {
                                    Assert.Fail();
                                }
                                if (d.Overlaps(b)) {
                                    Assert.Fail();
                                }
                                if (d.Overlaps(d)) {
                                    Assert.Fail();
                                }
                            }
                            if (a.Intersects(a)) {
                                Assert.Fail();
                            }
                            if (a.Intersects(b)) {
                                Assert.Fail();
                            }
                            if (b.Intersects(a)) {
                                Assert.Fail();
                            }
                            if (b.Intersects(b)) {
                                Assert.Fail();
                            }
                            if (a.Overlaps(a)) {
                                Assert.Fail();
                            }
                            if (a.Overlaps(b)) {
                                Assert.Fail();
                            }
                            if (b.Overlaps(a)) {
                                Assert.Fail();
                            }
                            if (b.Overlaps(b)) {
                                Assert.Fail();
                            }
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
                    if (a.Intersects(a)) {
                        Assert.Fail();
                    }
                    if (a.Intersects(c)) {
                        Assert.Fail();
                    }
                    if (b.Intersects(b)) {
                        Assert.Fail();
                    }
                    if (b.Intersects(d)) {
                        Assert.Fail();
                    }
                    if (c.Intersects(a)) {
                        Assert.Fail();
                    }
                    if (c.Intersects(c)) {
                        Assert.Fail();
                    }
                    if (d.Intersects(b)) {
                        Assert.Fail();
                    }
                    if (d.Intersects(d)) {
                        Assert.Fail();
                    }
                    if (a.Overlaps(a)) {
                        Assert.Fail();
                    }
                    if (a.Overlaps(b)) {
                        Assert.Fail();
                    }
                    if (a.Overlaps(c)) {
                        Assert.Fail();
                    }
                    if (a.Overlaps(d)) {
                        Assert.Fail();
                    }
                    if (b.Overlaps(a)) {
                        Assert.Fail();
                    }
                    if (b.Overlaps(b)) {
                        Assert.Fail();
                    }
                    if (b.Overlaps(c)) {
                        Assert.Fail();
                    }
                    if (b.Overlaps(d)) {
                        Assert.Fail();
                    }
                    if (c.Overlaps(a)) {
                        Assert.Fail();
                    }
                    if (c.Overlaps(b)) {
                        Assert.Fail();
                    }
                    if (c.Overlaps(c)) {
                        Assert.Fail();
                    }
                    if (c.Overlaps(d)) {
                        Assert.Fail();
                    }
                    if (d.Overlaps(a)) {
                        Assert.Fail();
                    }
                    if (d.Overlaps(b)) {
                        Assert.Fail();
                    }
                    if (d.Overlaps(c)) {
                        Assert.Fail();
                    }
                    if (d.Overlaps(d)) {
                        Assert.Fail();
                    }
                    if (!a.Intersects(b)) {
                        Assert.Fail();
                    }
                    if (!a.Intersects(d)) {
                        Assert.Fail();
                    }
                    if (!b.Intersects(a)) {
                        Assert.Fail();
                    }
                    if (!b.Intersects(c)) {
                        Assert.Fail();
                    }
                    if (!c.Intersects(b)) {
                        Assert.Fail();
                    }
                    if (!c.Intersects(d)) {
                        Assert.Fail();
                    }
                    if (!d.Intersects(a)) {
                        Assert.Fail();
                    }
                    if (!d.Intersects(c)) {
                        Assert.Fail();
                    }
                }
            }
            {
                var a = new Segment2I17F15(p1, p4);
                var b = new Segment2I17F15(p2, p3);
                var c = new Segment2I17F15(p4, p1);
                var d = new Segment2I17F15(p3, p2);
                if (a.Intersects(a)) {
                    Assert.Fail();
                }
                if (a.Intersects(c)) {
                    Assert.Fail();
                }
                if (b.Intersects(b)) {
                    Assert.Fail();
                }
                if (b.Intersects(d)) {
                    Assert.Fail();
                }
                if (c.Intersects(a)) {
                    Assert.Fail();
                }
                if (c.Intersects(c)) {
                    Assert.Fail();
                }
                if (d.Intersects(b)) {
                    Assert.Fail();
                }
                if (d.Intersects(d)) {
                    Assert.Fail();
                }
                if (a.Overlaps(a)) {
                    Assert.Fail();
                }
                if (a.Overlaps(c)) {
                    Assert.Fail();
                }
                if (b.Overlaps(b)) {
                    Assert.Fail();
                }
                if (b.Overlaps(d)) {
                    Assert.Fail();
                }
                if (c.Overlaps(a)) {
                    Assert.Fail();
                }
                if (c.Overlaps(c)) {
                    Assert.Fail();
                }
                if (d.Overlaps(b)) {
                    Assert.Fail();
                }
                if (d.Overlaps(d)) {
                    Assert.Fail();
                }
                if (!a.Intersects(b)) {
                    Assert.Fail();
                }
                if (!a.Intersects(d)) {
                    Assert.Fail();
                }
                if (!b.Intersects(a)) {
                    Assert.Fail();
                }
                if (!b.Intersects(c)) {
                    Assert.Fail();
                }
                if (!c.Intersects(b)) {
                    Assert.Fail();
                }
                if (!c.Intersects(d)) {
                    Assert.Fail();
                }
                if (!d.Intersects(a)) {
                    Assert.Fail();
                }
                if (!d.Intersects(c)) {
                    Assert.Fail();
                }
                if (!a.Overlaps(b)) {
                    Assert.Fail();
                }
                if (!a.Overlaps(d)) {
                    Assert.Fail();
                }
                if (!b.Overlaps(a)) {
                    Assert.Fail();
                }
                if (!b.Overlaps(c)) {
                    Assert.Fail();
                }
                if (!c.Overlaps(b)) {
                    Assert.Fail();
                }
                if (!c.Overlaps(d)) {
                    Assert.Fail();
                }
                if (!d.Overlaps(a)) {
                    Assert.Fail();
                }
                if (!d.Overlaps(c)) {
                    Assert.Fail();
                }
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
