using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AgatePris.Intar.Tests.Mathi {
    public class AtanTest {
        public const int One = 1 << 15;
        public const int Straight = 1 << 30;
        public const int StraightNeg = -Straight;
        public const int Right = Straight / 2;
        public const int RightHalf = Right / 2;
        public const int RightHalfNeg = -RightHalf;
        public const int RightHalfOpposite = RightHalf - Straight;
        public const int RightHalfOppositeNeg = -RightHalfOpposite;
        public const int RightNeg = -Right;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int CompareSteep((int, int) a, (int, int) b) {
            var aybx = (long)a.Item2 * b.Item1;
            var byax = (long)b.Item2 * a.Item1;
            return aybx < byax ? -1 : aybx > byax ? 1 : 0;
        }

        /// <summary>
        /// <c>int</c> で表現できる範囲で最も傾きの大きな点のリストを得る｡
        /// 傾きの分母は 32768 とし､ 四捨五入されるものとして取り扱う｡
        /// </summary>
        /// <param name="n">分母を 32768 とした場合の傾きの分子</param>
        /// <returns><c>int</c> で表現できる範囲で最も傾きの大きな点のリスト</returns>
        static List<(int, int)> CollectMostSteepPoints(int n) {
            const int resolutionTwice = 1 << 16;
            const int lastCrossPointX = int.MaxValue - resolutionTwice + 1;
            const int begin = lastCrossPointX + 1;

            // 四捨五入することを考慮して､ 2 倍の分解能で計算する｡
            // このため､ 分子も 2 倍になる｡
            var steep = (2 * n) + 1L;
            var max = (begin, (int)(begin * steep / resolutionTwice));
            var points = new List<(int, int)> { max };

            // for_iterator でのオーバーフローを防ぐため､ for_initializer､ for_condition､
            // for_iterator で直接 X 座標を取り扱わず､ lastCrossPointX との差分を計算する｡
            // このため､ すでに計算済みの 1 を飛ばし 2 から始める｡
            for (var i = 2; i < resolutionTwice; ++i) {
                var x = i + lastCrossPointX;
                var mul = x * steep;
#if DEBUG
                var rem = mul % resolutionTwice;
                if (rem == 0) {
                    Assert.Fail();
                }
#endif
                //var y = (int)(mul / resolutionTwice - (rem == 0 ? 1 : 0));
                var y = (int)(mul / resolutionTwice);
                var p = (x, y);
                var cmp = CompareSteep(max, p);
                if (cmp > 0) {
                    continue;
                }
                if (cmp < 0) {
                    max = p;
                    points.Clear();
                    points.Add(p);
                } else {
                    points.Add(p);
                }
            }
            return points;
        }

        [Test]
        public void CollectMostSteepPointsTest() {
            var list = CollectMostSteepPoints(32);
            Assert.AreEqual(list.Count, 1);
            Assert.AreEqual((2147422145, 2129859), list[0]);
        }

        public readonly struct AtanCase {
            public Func<int, int> Atan { get; }
            public Func<int, int, int> Atan2 { get; }
            public string DataPath { get; }
            public double AcceptableErrorAtan { get; }
            public double AcceptableErrorAtan2 { get; }

            public AtanCase(
                Func<int, int> atan,
                Func<int, int, int> atan2,
                string dataPath,
                double acceptableErrorAtan,
                double acceptableErrorAtan2
            ) {
                Atan = atan;
                Atan2 = atan2;
                DataPath = dataPath;
                AcceptableErrorAtan = acceptableErrorAtan;
                AcceptableErrorAtan2 = acceptableErrorAtan2;
                Write();
            }
            public override string ToString() {
                return DataPath;
            }
            public void Write() {
                var path = Utility.MakeUpPath(DataPath);
                if (System.IO.File.Exists(path)) {
                    return;
                }
                var data = new List<int>();
                var atan = Atan;
                Utility.WriteInts(path, x => {
                    var v = atan(x);
                    data.Add(v);
                    return v;
                }, One);
            }
        }

        static void TestAtan(
            Func<int, int> atan,
            List<int> data,
            double acceptableError
        ) {
            void test(int x, int expected) {
                var actual = atan(x);
                if (actual != expected) {
                    Assert.Fail(
                        $"{nameof(x)}: {x}, " +
                        $"{nameof(expected)}: {expected}, " +
                        $"{nameof(actual)}: {actual}"
                    );
                }
                const double scale = Math.PI / Straight;
                var expectedReal = Math.Atan(x / (double)One);
                var actualReal = scale * actual;
                if (Math.Abs(actualReal - expectedReal) >= acceptableError) {
                    Assert.Fail(
                        $"{nameof(x)}: {x}, " +
                        $"{nameof(expected)}: {expected}, " +
                        $"{nameof(actual)}: {actual}, " +
                        $"{nameof(expectedReal)}: {expectedReal}, " +
                        $"{nameof(actualReal)}: {actualReal}"
                    );
                }
            }

            const long k = 1L << 31;
            const long kNeg = -k;
            test(0, data[0]);
            {
                var expected = data[1];
                test(1, expected);
                test(-1, -expected);
                expected -= Right;
                test((int)(kNeg / 3) - 1, expected);
                test(int.MinValue, expected);
                expected = -expected;
                test((int)(k / 3) + 1, expected);
                test(int.MaxValue, expected);
            }
            var processorCount = Environment.ProcessorCount;
            _ = Parallel.For(0, processorCount, n => {
                var begin = 2 + ((One - 1) * n / processorCount);
                var end = 2 + ((One - 1) * (n + 1) / processorCount);
                for (var i = begin; i < end; ++i) {
                    var expected = data[i];
                    test(i, expected);
                    test(-i, -expected);
                    var i2 = 2 * i;
                    var i2Add = i2 + 1;
                    var i2Sub = i2 - 1;
                    expected -= Right;
                    test((int)(kNeg / i2Add) - 1, expected);
                    test((int)(kNeg / i2Sub), expected);
                    expected = -expected;
                    test((int)(k / i2Add) + 1, expected);
                    test((int)(k / i2Sub), expected);
                }
            });
        }

        static void Atan2Test(
            Func<int, int, int> atan2,
            List<int> data,
            double acceptableError
        ) {
            void test(int y, int x, int expected) {
                var actual = atan2(y, x);
                if (actual != expected) {
                    Assert.Fail(
                        $"{nameof(y)}: {y}, " +
                        $"{nameof(x)}: {x}, " +
                        $"{nameof(expected)}: {expected}, " +
                        $"{nameof(actual)}: {actual}"
                    );
                }
                var expectedReal = Math.Atan2(y, x);
                var actualReal = Math.PI * actual / Straight;
                if (Math.Abs(actualReal - expectedReal) >= acceptableError) {
                    Assert.Fail(
                        $"{nameof(y)}: {y}, " +
                        $"{nameof(x)}: {x}, " +
                        $"{nameof(expected)}: {expected}, " +
                        $"{nameof(actual)}: {actual}, " +
                        $"{nameof(expectedReal)}: {expectedReal}, " +
                        $"{nameof(actualReal)}: {actualReal}"
                    );
                }
            }
            test(0, 0, 0);
            test(0, 1, 0);
            test(1, 1, RightHalf);
            test(1, 0, Right);
            test(1, -1, RightHalfOppositeNeg);
            test(0, -1, Straight);
            test(-1, 1, RightHalfNeg);
            test(-1, 0, RightNeg);
            test(-1, -1, RightHalfOpposite);
            test(0, int.MaxValue, 0);
            test(0, int.MinValue, Straight);
            test(int.MaxValue, 0, Right);
            test(int.MinValue, 0, RightNeg);
            test(int.MaxValue, int.MaxValue, RightHalf);
            test(int.MinValue, int.MinValue, RightHalfOpposite);
            test(int.MinValue, int.MaxValue, RightHalfNeg);
            test(int.MaxValue, int.MinValue, RightHalfOppositeNeg);
            test(0, -int.MaxValue, Straight);
            test(int.MinValue, -int.MaxValue, RightHalfOpposite);
            test(int.MaxValue, -int.MaxValue, RightHalfOppositeNeg);
            test(-int.MaxValue, 0, RightNeg);
            test(-int.MaxValue, int.MinValue, RightHalfOpposite);
            test(-int.MaxValue, int.MaxValue, RightHalfNeg);
            test(-int.MaxValue, -int.MaxValue, RightHalfOpposite);
            test(1, int.MaxValue, 0);
            test(1, int.MinValue, Straight);
            test(1, -int.MaxValue, Straight);
            test(-1, int.MaxValue, 0);
            test(-1, int.MinValue, StraightNeg);
            test(-1, -int.MaxValue, StraightNeg);
            test(int.MinValue, 1, RightNeg);
            test(int.MaxValue, 1, Right);
            test(int.MinValue, -1, RightNeg);
            test(int.MaxValue, -1, Right);
            test(-int.MaxValue, 1, RightNeg);
            test(-int.MaxValue, -1, RightNeg);

            // Test each of the 8 regions partitioned by the following 4 lines.
            // * x-axis
            // * y-axis
            // * y = x
            // * y = -x
            void testDefault(int y, int x, int expected) {
                test(y, x, expected);
                test(-y, x, -expected);
                test(y, -x, Straight - expected);
                test(-y, -x, expected - Straight);
                test(x, y, Right - expected);
                test(-x, y, RightNeg + expected);
                test(x, -y, Right + expected);
                test(-x, -y, RightNeg - expected);
            }

            var processorCount = Environment.ProcessorCount;
            _ = Parallel.For(0, processorCount, n => {
                // Test far from x-axis
                {
                    var begin = One * n / processorCount;
                    var end = One * (n + 1) / processorCount;
                    for (var i = begin; i < end; ++i) {
                        var list = CollectMostSteepPoints(i);
                        foreach (var (x, y) in list) {
                            testDefault(y, x, data[i]);
                        }
                    }
                }

                // Test near to x-axis
                {
                    var begin = 1 + (One * n / processorCount);
                    var end = 1 + (One * (n + 1) / processorCount);
                    for (var i = begin; i < end; ++i) {
                        var x = 1 << 16;
                        var y = (2 * i) - 1;
                        testDefault(y, x, data[i]);
                    }
                }
            });
        }

        public static readonly AtanCase[] AtanCases = {
            new AtanCase(Intar.Mathi.AtanP2A2909, Intar.Mathi.Atan2P2A2909, "atan_p2_a2909.json", 0.004507, 0.004507),
            new AtanCase(Intar.Mathi.AtanP3A2577B664, Intar.Mathi.Atan2P3A2577B664, "atan_p3_a2577_b664.json", 0.001730, 0.001730),
            new AtanCase(Intar.Mathi.AtanP5A787B2968, Intar.Mathi.Atan2P5A787B2968, "atan_p5_i17f15.json", 0.000767, 0.000767),
        };

        [Test]
        public static void DocTest() {
            {
                var x = (1 << 15) * 2 / 3;
                var actual = Intar.Mathi.AtanP2A2909(x);
                var expected = Math.Atan2(2, 3);
                var a = actual * Math.PI / (1 << 30);
                Assert.AreEqual(expected, a, 0.004507);
            }
            {
                var y = 2;
                var x = 3;
                var actual = Intar.Mathi.Atan2P2A2909(y, x);
                var expected = Math.Atan2(2, 3);
                var a = actual * Math.PI / (1 << 30);
                Assert.AreEqual(expected, a, 0.004507);
            }
            {
                var x = (1 << 15) * 2 / 3;
                var actual = Intar.Mathi.AtanP3A2577B664(x);
                var expected = Math.Atan2(2, 3);
                var a = actual * Math.PI / (1 << 30);
                Assert.AreEqual(expected, a, 0.001730);
            }
            {
                var y = 2;
                var x = 3;
                var actual = Intar.Mathi.Atan2P3A2577B664(y, x);
                var expected = Math.Atan2(2, 3);
                var a = actual * Math.PI / (1 << 30);
                Assert.AreEqual(expected, a, 0.001730);
            }
            {
                var x = (1 << 15) * 2 / 3;
                var actual = Intar.Mathi.AtanP5A787B2968(x);
                var expected = Math.Atan2(2, 3);
                var a = actual * Math.PI / (1 << 30);
                Assert.AreEqual(expected, a, 0.000767);
            }
            {
                var y = 2;
                var x = 3;
                var actual = Intar.Mathi.Atan2P5A787B2968(y, x);
                var expected = Math.Atan2(2, 3);
                var a = actual * Math.PI / (1 << 30);
                Assert.AreEqual(expected, a, 0.000767);
            }
        }

        [Test]
        public static void TestAtan(
            [ValueSource(nameof(AtanCases))] AtanCase atanCase
        ) {
            var data = Utility.ReadInts(Utility.MakeUpPath(atanCase.DataPath));
            Assert.AreEqual(data.Count, One + 1);
            Assert.AreEqual(data[0], 0);
            Assert.AreEqual(data[One], RightHalf);
            Atan2Test(atanCase.Atan2, data, atanCase.AcceptableErrorAtan2);
            TestAtan(atanCase.Atan, data, atanCase.AcceptableErrorAtan);
        }
    }
}
