using Intar.Geometry;
using Intar.Rand;
using NUnit.Framework;
using System.Collections.Generic;

#if !UNITY_5_3_OR_NEWER && NET462
using System.Drawing;
using System.Drawing.Imaging;
#endif

namespace Intar.Tests.Geometry {
    public class BoxTest {
        [Test]
        public static void TestPoint() {
            // 以下の場合, オーバーフローを引き起こす.
            //
            // - 辺が極端に長い場合.
            // - 点 p が極端に遠い場合.

            // 基本的なテスト.
            // 普通の正方形.
            {
                var a = I17F15.FromBits(I17F15.OneRepr + 1);
                var b = I17F15.FromBits(I17F15.OneRepr - 1);
                var boxes = new Box2I17F15[] {
                    new Box2I17F15(Vector2I17F15.Zero, Vector2I17F15.One),
                    new Box2I17F15(Vector2I17F15.Zero, Vector2I17F15.NegativeOne),
                    new Box2I17F15(Vector2I17F15.Zero, new Vector2I17F15(I17F15.One, I17F15.NegativeOne)),
                    new Box2I17F15(Vector2I17F15.Zero, new Vector2I17F15(I17F15.NegativeOne, I17F15.One)),
                };
                var l = new I17F15[] {
                    I17F15.Zero, I17F15.One, -I17F15.One, a, -a, b, -b
                };
                foreach (var box in boxes) {
                    foreach (var x in l) {
                        foreach (var y in l) {
                            var p = new Vector2I17F15(x, y);
                            if (x == a || x == -a ||
                                y == a || y == -a) {
                                if (box.Intersects(p) || box.Overlaps(p)) {
                                    Assert.Fail();
                                }
                            } else if (
                                x == I17F15.One || x == I17F15.NegativeOne ||
                                y == I17F15.One || y == I17F15.NegativeOne) {
                                if (!box.Intersects(p) || box.Overlaps(p)) {
                                    Assert.Fail();
                                }
                            } else {
                                if (!box.Intersects(box) || !box.Overlaps(p)) {
                                    Assert.Fail();
                                }
                            }
                        }
                    }
                }
            }

            // Extents.X == 0 の場合
            {
                var b = new Box2I17F15(Vector2I17F15.Zero, new Vector2I17F15(I17F15.Zero, I17F15.One));
                if (!b.Intersects(Vector2I17F15.Zero)) { Assert.Fail(); }
                if (!b.Intersects(Vector2I17F15.UnitY)) { Assert.Fail(); }
                if (!b.Intersects(-Vector2I17F15.UnitY)) { Assert.Fail(); }
                if (b.Intersects(Vector2I17F15.One)) { Assert.Fail(); }
                if (b.Intersects(Vector2I17F15.UnitX)) { Assert.Fail(); }
                if (b.Intersects(Vector2I17F15.UnitX - Vector2I17F15.UnitY)) { Assert.Fail(); }
                if (b.Intersects(Vector2I17F15.UnitY - Vector2I17F15.UnitX)) { Assert.Fail(); }
                if (b.Intersects(-Vector2I17F15.One)) { Assert.Fail(); }
                if (b.Intersects(-Vector2I17F15.UnitX)) { Assert.Fail(); }
                if (b.Overlaps(Vector2I17F15.Zero)) { Assert.Fail(); }
                if (b.Overlaps(Vector2I17F15.UnitX)) { Assert.Fail(); }
                if (b.Overlaps(Vector2I17F15.UnitY)) { Assert.Fail(); }
                if (b.Overlaps(Vector2I17F15.One)) { Assert.Fail(); }
                if (b.Overlaps(Vector2I17F15.UnitX - Vector2I17F15.UnitY)) { Assert.Fail(); }
                if (b.Overlaps(Vector2I17F15.UnitY - Vector2I17F15.UnitX)) { Assert.Fail(); }
                if (b.Overlaps(-Vector2I17F15.One)) { Assert.Fail(); }
                if (b.Overlaps(-Vector2I17F15.UnitX)) { Assert.Fail(); }
                if (b.Overlaps(-Vector2I17F15.UnitY)) { Assert.Fail(); }
            }

            // 点
            {
                var centers = new Vector2I17F15[] {
                    Vector2I17F15.Zero,
                    Vector2I17F15.One,
                    Vector2I17F15.UnitX,
                    Vector2I17F15.UnitY,
                    Vector2I17F15.UnitX - Vector2I17F15.UnitY,
                    Vector2I17F15.UnitY - Vector2I17F15.UnitX,
                    -Vector2I17F15.One,
                    -Vector2I17F15.UnitX,
                    -Vector2I17F15.UnitY,
                };
                foreach (var c in centers) {
                    var a = I17F15.FromBits(1);
                    var b = new Box2I17F15(c, Vector2I17F15.Zero);
                    if (!b.Intersects(c + Vector2I17F15.Zero)) { Assert.Fail(); }
                    if (b.Intersects(c + (Vector2I17F15.One * a))) { Assert.Fail(); }
                    if (b.Intersects(c + (Vector2I17F15.UnitX * a))) { Assert.Fail(); }
                    if (b.Intersects(c + (Vector2I17F15.UnitY * a))) { Assert.Fail(); }
                    if (b.Intersects(c - (Vector2I17F15.One * a))) { Assert.Fail(); }
                    if (b.Intersects(c - (Vector2I17F15.UnitX * a))) { Assert.Fail(); }
                    if (b.Intersects(c - (Vector2I17F15.UnitY * a))) { Assert.Fail(); }
                    if (b.Intersects(c + ((Vector2I17F15.UnitX - Vector2I17F15.UnitY) * a))) { Assert.Fail(); }
                    if (b.Intersects(c + ((Vector2I17F15.UnitY - Vector2I17F15.UnitX) * a))) { Assert.Fail(); }
                    if (b.Overlaps(c + Vector2I17F15.Zero)) { Assert.Fail(); }
                    if (b.Overlaps(c + (Vector2I17F15.One * a))) { Assert.Fail(); }
                    if (b.Overlaps(c + (Vector2I17F15.UnitX * a))) { Assert.Fail(); }
                    if (b.Overlaps(c + (Vector2I17F15.UnitY * a))) { Assert.Fail(); }
                    if (b.Overlaps(c - (Vector2I17F15.One * a))) { Assert.Fail(); }
                    if (b.Overlaps(c - (Vector2I17F15.UnitX * a))) { Assert.Fail(); }
                    if (b.Overlaps(c - (Vector2I17F15.UnitY * a))) { Assert.Fail(); }
                    if (b.Overlaps(c + ((Vector2I17F15.UnitX - Vector2I17F15.UnitY) * a))) { Assert.Fail(); }
                    if (b.Overlaps(c + ((Vector2I17F15.UnitY - Vector2I17F15.UnitX) * a))) { Assert.Fail(); }
                }
            }

            // ((-1, 0), (1, 0), (1, 0), (-1, 0))
            {
                var boxes = new Box2I17F15[] {
                    new Box2I17F15(Vector2I17F15.Zero, Vector2I17F15.UnitX),
                    new Box2I17F15(Vector2I17F15.Zero, -Vector2I17F15.UnitX),
                };
                var intersections = new Vector2I17F15[] {
                    Vector2I17F15.UnitX, -Vector2I17F15.UnitX,
                };
                var disjoints = System.Array.Empty<Vector2I17F15>();
                foreach (var box in boxes) {
                    foreach (var intersection in intersections) {
                        if (!box.Intersects(intersection)) { Assert.Fail(); }
                        if (box.Overlaps(intersection)) { Assert.Fail(); }
                    }
                    foreach (var disjoint in disjoints) {
                        if (box.Intersects(disjoint)) { Assert.Fail(); }
                        if (box.Overlaps(disjoint)) { Assert.Fail(); }
                    }
                }
            }

            // ((0, 1), (-0.5, 0), (0, -1), (0.5, 0))
            {
                var b = new Box2I17F15(
                    new AffineTransform2I17F15(
                        new Matrix2x2I17F15(
                            new Vector2I17F15((I17F15)(+0.25f), (I17F15)0.5f),
                            new Vector2I17F15((I17F15)(-0.25f), (I17F15)0.5f)
                        ), Vector2I17F15.Zero
                    ), Vector2I17F15.One
                );
                var l = new List<Vector2I17F15> {
                    Vector2I17F15.UnitX * (I17F15)(+0.5f),
                    Vector2I17F15.UnitX * (I17F15)(-0.5f),
                    Vector2I17F15.UnitY * (I17F15)(+1.0f),
                    Vector2I17F15.UnitY * (I17F15)(-1.0f),
                };
                Assert.IsTrue(b.Intersects(Vector2I17F15.Zero));
                Assert.IsTrue(b.Overlaps(Vector2I17F15.Zero));
                foreach (var p in l) {
                    Assert.IsTrue(b.Intersects(p));
                    Assert.IsFalse(b.Overlaps(p));
                }
            }
        }

        [Test]
        public static void TestCircle() {
            // 以下の場合, オーバーフローを引き起こす.
            //
            // - 辺が極端に長い場合.
            // - 円の中心点 C が極端に遠い場合.

            // 平行四辺形が退化している (面積が非常に小さい) 場合,
            // 円と各辺との判定のみを行う.
            // 円と各辺との判定を行う際,
            // 辺が極端に短い場合,
            // 実際には円と端点との判定を行う.

            var v = I17F15.FromBits(90);
            var r = U17F15.FromBits(1);
            var l = new List<Box2I17F15> {
                new Box2I17F15(Vector2I17F15.Zero, Vector2I17F15.Zero),
                new Box2I17F15(Vector2I17F15.Zero, Vector2I17F15.One),
                new Box2I17F15(Vector2I17F15.Zero, Vector2I17F15.UnitX),
                new Box2I17F15(Vector2I17F15.Zero, Vector2I17F15.UnitY),
                new Box2I17F15(Vector2I17F15.Zero, new Vector2I17F15(v, v)),
                new Box2I17F15(
                    new AffineTransform2I17F15(
                        new Matrix2x2I17F15(
                            new Vector2I17F15((I17F15)(+0.25f), (I17F15)0.5f),
                            new Vector2I17F15((I17F15)(-0.25f), (I17F15)0.5f)
                        ), Vector2I17F15.Zero
                    ), Vector2I17F15.One
                ),
                new Box2I17F15(
                    new AffineTransform2I17F15(
                        new Matrix2x2I17F15(
                            new Vector2I17F15((I17F15)(+0.5f), I17F15.Zero),
                            new Vector2I17F15((I17F15)(-0.5f), I17F15.Zero)
                        ), Vector2I17F15.Zero
                    ), Vector2I17F15.One
                ),
                new Box2I17F15(
                    new AffineTransform2I17F15(
                        new Matrix2x2I17F15(
                            new Vector2I17F15(I17F15.Zero, (I17F15)0.5f),
                            new Vector2I17F15(I17F15.Zero, (I17F15)0.5f)
                        ), Vector2I17F15.Zero
                    ), Vector2I17F15.One
                ),
            };

            // 円がすっぽりボックスに収まる場合でも
            // ボックスが非常に小さい場合は Intersects は false となる.
            // ただし, 円の中に頂点が収まる場合 Intersects は true となる.
            foreach (var b in l) {
                Assert.IsTrue(b.Intersects(new CircleI17F15(b.P1, r)));
                Assert.IsTrue(b.Intersects(new CircleI17F15(b.P2, r)));
                Assert.IsTrue(b.Intersects(new CircleI17F15(b.P3, r)));
                Assert.IsTrue(b.Intersects(new CircleI17F15(b.P4, r)));
                Assert.IsTrue(b.Intersects(new CircleI17F15(b.P1, U17F15.Zero)));
                Assert.IsTrue(b.Intersects(new CircleI17F15(b.P2, U17F15.Zero)));
                Assert.IsTrue(b.Intersects(new CircleI17F15(b.P3, U17F15.Zero)));
                Assert.IsTrue(b.Intersects(new CircleI17F15(b.P4, U17F15.Zero)));
                Assert.IsTrue(b.Overlaps(new CircleI17F15(b.P1, r)));
                Assert.IsTrue(b.Overlaps(new CircleI17F15(b.P2, r)));
                Assert.IsTrue(b.Overlaps(new CircleI17F15(b.P3, r)));
                Assert.IsTrue(b.Overlaps(new CircleI17F15(b.P4, r)));
                Assert.IsFalse(b.Overlaps(new CircleI17F15(b.P1, U17F15.Zero)));
                Assert.IsFalse(b.Overlaps(new CircleI17F15(b.P2, U17F15.Zero)));
                Assert.IsFalse(b.Overlaps(new CircleI17F15(b.P3, U17F15.Zero)));
                Assert.IsFalse(b.Overlaps(new CircleI17F15(b.P4, U17F15.Zero)));
            }
        }

        [Test]
        public static void TestSegment() {
            var box1 = new Box2I17F15(Vector2I17F15.Zero, Vector2I17F15.Zero);
            var box2 = new Box2I17F15(Vector2I17F15.Zero, Vector2I17F15.One);
            {
                var l = new List<Segment2I17F15> {
                    new Segment2I17F15(Vector2I17F15.Zero, Vector2I17F15.Zero),
                    new Segment2I17F15(Vector2I17F15.Zero, Vector2I17F15.One),
                };
                foreach (var s in l) {
                    Assert.IsTrue(box1.Intersects(s));
                    Assert.IsTrue(box2.Intersects(s));
                    Assert.IsTrue(box2.Overlaps(s));
                    Assert.IsFalse(box1.Overlaps(s));
                }
            }
            {
                var l = new List<Segment2I17F15> {
                    new Segment2I17F15(Vector2I17F15.One, Vector2I17F15.One),
                    new Segment2I17F15(
                        new Vector2I17F15(I17F15.One, I17F15.One),
                        new Vector2I17F15(I17F15.One, I17F15.NegativeOne)
                    ),
                };
                foreach (var s in l) {
                    Assert.IsFalse(box1.Intersects(s));
                    Assert.IsTrue(box2.Intersects(s));
                    Assert.IsFalse(box1.Overlaps(s));
                    Assert.IsFalse(box2.Overlaps(s));
                }
            }
        }

        [Test]
        public static void TestBox() {
            // 以下の場合, オーバーフローを引き起こす.
            //
            // - 辺が極端に長い場合.
            // - 互いが極端に遠い場合.

            // 点・線分
            {
                var l = new List<Box2I17F15> {
                    new Box2I17F15(Vector2I17F15.Zero, Vector2I17F15.Zero),
                    new Box2I17F15(Vector2I17F15.Zero, Vector2I17F15.UnitX),
                    new Box2I17F15(Vector2I17F15.Zero, Vector2I17F15.UnitY),
                    new Box2I17F15(
                        new AffineTransform2I17F15(
                            new Matrix2x2I17F15(
                                new Vector2I17F15(I17F15.Zero, (I17F15)0.5f),
                                new Vector2I17F15(I17F15.Zero, (I17F15)0.5f)
                            ), Vector2I17F15.Zero
                        ), Vector2I17F15.One
                    ),
                    new Box2I17F15(
                        new AffineTransform2I17F15(
                            new Matrix2x2I17F15(
                                new Vector2I17F15((I17F15)(+0.5f), I17F15.Zero),
                                new Vector2I17F15((I17F15)(-0.5f), I17F15.Zero)
                            ), Vector2I17F15.Zero
                        ), Vector2I17F15.One
                    ),
                };
                foreach (var b in l) {
                    Assert.IsTrue(b.Intersects(b));
                    Assert.IsFalse(b.Overlaps(b));
                }
            }

            // 退化していない場合.
            {
                var l = new List<Box2I17F15> {
                    new Box2I17F15(Vector2I17F15.Zero, Vector2I17F15.One),
                    new Box2I17F15(
                        new AffineTransform2I17F15(
                            new Matrix2x2I17F15(
                                new Vector2I17F15((I17F15)(+0.25f), (I17F15)0.5f),
                                new Vector2I17F15((I17F15)(-0.25f), (I17F15)0.5f)
                            ), Vector2I17F15.Zero
                        ), Vector2I17F15.One
                    ),
                };
                foreach (var b in l) {
                    Assert.IsTrue(b.Intersects(b));
                    Assert.IsTrue(b.Overlaps(b));
                }
            }

            // 退化した平行四辺形の交差
            {
                var b1 = new Box2I17F15(Vector2I17F15.Zero, Vector2I17F15.UnitX);
                var b2 = new Box2I17F15(Vector2I17F15.Zero, Vector2I17F15.UnitY);
                Assert.IsTrue(b1.Intersects(b1));
                Assert.IsTrue(b1.Intersects(b2));
                Assert.IsTrue(b2.Intersects(b1));
                Assert.IsTrue(b2.Intersects(b2));
                Assert.IsTrue(b1.Overlaps(b2));
                Assert.IsTrue(b2.Overlaps(b1));
                Assert.IsFalse(b1.Overlaps(b1));
                Assert.IsFalse(b2.Overlaps(b2));
            }

            // 平行四辺形が接する場合
            {
                var r = new Matrix2x2I17F15(
                    new Vector2I17F15((I17F15)(+0.5f), (I17F15)0.5f),
                    new Vector2I17F15((I17F15)(-0.5f), (I17F15)0.5f)
                );
                var b1 = new Box2I17F15(
                    new AffineTransform2I17F15(
                        r, Vector2I17F15.Zero
                    ), Vector2I17F15.One
                );
                var b2 = new Box2I17F15(
                    new AffineTransform2I17F15(
                        r, Vector2I17F15.One
                    ), Vector2I17F15.One
                );
                Assert.IsTrue(b1.Intersects(b1));
                Assert.IsTrue(b1.Intersects(b2));
                Assert.IsTrue(b2.Intersects(b1));
                Assert.IsTrue(b2.Intersects(b2));
                Assert.IsTrue(b1.Overlaps(b1));
                Assert.IsTrue(b2.Overlaps(b2));
                Assert.IsFalse(b1.Overlaps(b2));
                Assert.IsFalse(b2.Overlaps(b1));
            }

            // 正方形と回転した正方形の判定
            {
                var b1 = new Box2I17F15(
                    Vector2I17F15.Zero, (I17F15)0.5f * Vector2I17F15.One
                );
                var b2 = new Box2I17F15(
                    (I17F15)0.5f * Vector2I17F15.One, (I17F15)0.5f * Vector2I17F15.One
                );
                var b3 = new Box2I17F15(
                    new AffineTransform2I17F15(
                        new Matrix2x2I17F15(
                            new Vector2I17F15((I17F15)(+0.5f), (I17F15)0.5f),
                            new Vector2I17F15((I17F15)(-0.5f), (I17F15)0.5f)
                        ), (I17F15)1.125f * Vector2I17F15.One
                    ), (I17F15)0.5f * Vector2I17F15.One
                );
                Assert.IsTrue(b1.Intersects(b1));
                Assert.IsTrue(b2.Intersects(b2));
                Assert.IsTrue(b2.Intersects(b3));
                Assert.IsTrue(b3.Intersects(b2));
                Assert.IsTrue(b3.Intersects(b3));
                Assert.IsTrue(b1.Overlaps(b1));
                Assert.IsTrue(b2.Overlaps(b2));
                Assert.IsTrue(b2.Overlaps(b3));
                Assert.IsTrue(b3.Overlaps(b2));
                Assert.IsTrue(b3.Overlaps(b3));
                Assert.IsFalse(b1.Intersects(b3));
                Assert.IsFalse(b3.Intersects(b1));
                Assert.IsFalse(b1.Overlaps(b3));
                Assert.IsFalse(b3.Overlaps(b1));
            }
        }

#if !UNITY_5_3_OR_NEWER && NET462
        static Point Transform(Vector2I17F15 p) {
            var x = (int)(32 * (float)p.X);
            var y = (int)(32 * (float)p.Y);
            return new Point(x + 128, y + 128);
        }
#endif

        [Test]
        public static void TestBounds() {
            var rng = new Xoroshiro128StarStar(1, 2);
            for (var z = 0; z < 65536; z++) {
                var a = I17F15.FromBits(rng.Next(-65536, 65536));
                var b = I17F15.FromBits(rng.Next(-65536, 65536));
                var c = I17F15.FromBits(rng.Next(-65536, 65536));
                var d = I17F15.FromBits(rng.Next(-65536, 65536));
                var e = I17F15.FromBits(rng.Next(-65536, 65536));
                var f = I17F15.FromBits(rng.Next(-65536, 65536));
                var g = I17F15.FromBits(rng.Next(-65536, 65536));
                var h = I17F15.FromBits(rng.Next(-65536, 65536));
                var i = I17F15.FromBits(rng.Next(-65536, 65536));
                var j = I17F15.FromBits(rng.Next(-65536, 65536));
                var k = I17F15.FromBits(rng.Next(-65536, 65536));
                var l = I17F15.FromBits(rng.Next(-65536, 65536));

                var bounds = new Aabb2I17F15(new Segment2I17F15(
                    new Vector2I17F15(a, b),
                    new Vector2I17F15(c, d)
                ));
                var box = new Box2I17F15(
                    new AffineTransform2I17F15(
                        new Matrix2x2I17F15(
                            new Vector2I17F15(g, h),
                            new Vector2I17F15(i, j)
                        ),
                        new Vector2I17F15(k, l)
                    ),
                    new Vector2I17F15(e, f)
                );
                {
                    var p0 = box.P1;
                    var p1 = box.P2;
                    var p2 = box.P3;
                    var p3 = box.P4;
                    var p4 = new Vector2I17F15(bounds.MaxX, bounds.MinY);
                    var p5 = new Vector2I17F15(bounds.MinX, bounds.MinY);
                    var p6 = new Vector2I17F15(bounds.MinX, bounds.MaxY);
                    var p7 = new Vector2I17F15(bounds.MaxX, bounds.MaxY);
                    bool expected1, expected2;
                    {
                        var e0 = new Segment2I17F15(p0, p1);
                        var e1 = new Segment2I17F15(p1, p2);
                        var e2 = new Segment2I17F15(p2, p3);
                        var e3 = new Segment2I17F15(p3, p0);
                        var e4 = new Segment2I17F15(p4, p5);
                        var e5 = new Segment2I17F15(p5, p6);
                        var e6 = new Segment2I17F15(p6, p7);
                        var e7 = new Segment2I17F15(p7, p4);
                        expected1 =
                            bounds.Intersects(p0) ||
                            bounds.Intersects(p1) ||
                            bounds.Intersects(p2) ||
                            bounds.Intersects(p3) ||
                            box.Intersects(p4) ||
                            box.Intersects(p5) ||
                            box.Intersects(p6) ||
                            box.Intersects(p7) ||
                            e0.Intersects(e4) ||
                            e0.Intersects(e5) ||
                            e0.Intersects(e6) ||
                            e0.Intersects(e7) ||
                            e1.Intersects(e4) ||
                            e1.Intersects(e5) ||
                            e1.Intersects(e6) ||
                            e1.Intersects(e7) ||
                            e2.Intersects(e4) ||
                            e2.Intersects(e5) ||
                            e2.Intersects(e6) ||
                            e2.Intersects(e7) ||
                            e3.Intersects(e4) ||
                            e3.Intersects(e5) ||
                            e3.Intersects(e6) ||
                            e3.Intersects(e7);
                        expected2 =
                            bounds.Overlaps(p0) ||
                            bounds.Overlaps(p1) ||
                            bounds.Overlaps(p2) ||
                            bounds.Overlaps(p3) ||
                            box.Overlaps(p4) ||
                            box.Overlaps(p5) ||
                            box.Overlaps(p6) ||
                            box.Overlaps(p7) ||
                            e0.Overlaps(e4) ||
                            e0.Overlaps(e5) ||
                            e0.Overlaps(e6) ||
                            e0.Overlaps(e7) ||
                            e1.Overlaps(e4) ||
                            e1.Overlaps(e5) ||
                            e1.Overlaps(e6) ||
                            e1.Overlaps(e7) ||
                            e2.Overlaps(e4) ||
                            e2.Overlaps(e5) ||
                            e2.Overlaps(e6) ||
                            e2.Overlaps(e7) ||
                            e3.Overlaps(e4) ||
                            e3.Overlaps(e5) ||
                            e3.Overlaps(e6) ||
                            e3.Overlaps(e7);
                    }
                    var actual1 = box.Intersects(bounds);
                    var actual2 = box.Overlaps(bounds);
                    if (expected1 != actual1 || expected2 != actual2) {
#if !UNITY_5_3_OR_NEWER && NET462
                        var red = new Pen(Color.Red);
                        var blue = new Pen(Color.Blue);
                        var width = 256;
                        var height = 256;
                        var bitmap = new Bitmap(width, height);
                        var graphics = Graphics.FromImage(bitmap);
                        graphics.Clear(Color.White);
                        var pt0 = Transform(p0);
                        var pt1 = Transform(p1);
                        var pt2 = Transform(p2);
                        var pt3 = Transform(p3);
                        var pt4 = Transform(p4);
                        var pt5 = Transform(p5);
                        var pt6 = Transform(p6);
                        var pt7 = Transform(p7);
                        graphics.DrawLine(red, pt0, pt1);
                        graphics.DrawLine(red, pt1, pt2);
                        graphics.DrawLine(red, pt2, pt3);
                        graphics.DrawLine(red, pt3, pt0);
                        graphics.DrawLine(blue, pt4, pt5);
                        graphics.DrawLine(blue, pt5, pt6);
                        graphics.DrawLine(blue, pt6, pt7);
                        graphics.DrawLine(blue, pt7, pt4);
                        bitmap.Save($"output{z}.png", ImageFormat.Png);
#endif
                        Assert.Fail();
                    }
                }
            }
            {
                var box = new Box2I17F15(
                    new AffineTransform2I17F15(
                        Matrix2x2I17F15.Identity,
                        Vector2I17F15.Zero
                    ), Vector2I17F15.One
                );
                var b0 = new Aabb2I17F15(new Segment2I17F15(
                    Vector2I17F15.Zero,
                    Vector2I17F15.Zero
                ));
                var b1 = new Aabb2I17F15(new Segment2I17F15(
                    Vector2I17F15.UnitX,
                    Vector2I17F15.UnitX
                ));
                var b2 = new Aabb2I17F15(new Segment2I17F15(
                    Vector2I17F15.UnitY,
                    Vector2I17F15.UnitY
                ));
                var b3 = new Aabb2I17F15(new Segment2I17F15(
                    Vector2I17F15.One,
                    Vector2I17F15.One
                ));
                Assert.IsTrue(box.Intersects(b0));
                Assert.IsTrue(box.Intersects(b1));
                Assert.IsTrue(box.Intersects(b2));
                Assert.IsTrue(box.Intersects(b3));
                Assert.IsTrue(box.Overlaps(b0));
                Assert.IsFalse(box.Overlaps(b1));
                Assert.IsFalse(box.Overlaps(b2));
                Assert.IsFalse(box.Overlaps(b3));
            }
        }
    }
} // namespace Intar.Tests.Geometry
