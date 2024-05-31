using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Math = AgatePris.Intar.Mathematics.Math;

#pragma warning disable IDE0090 // 'new(...)' を使用する
namespace AgatePris.Intar.Tests.Mathematics {
    public partial class MathTest {
        const int atanOne = 1 << 15;
        const int atanStraight = 1 << 30;
        const int atanStraightNeg = -atanStraight;
        const int atanRight = atanStraight / 2;
        const int atanRightHalf = atanRight / 2;
        const int atanRightHalfNeg = -atanRightHalf;
        const int atanRightHalfOpposite = atanRightHalf - atanStraight;
        const int atanRightHalfOppositeNeg = -atanRightHalfOpposite;
        const int atanRightNeg = -atanRight;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int CompareSteep((int, int) a, (int, int) b) {
            var aybx = (long)a.Item2 * b.Item1;
            var byax = (long)b.Item2 * a.Item1;
            return aybx < byax ? -1 : aybx > byax ? 1 : 0;
        }

        static List<(int, int)> CollectMostSteepPoints(int n) {
            const int width = 1 << 16;
            const int begin = int.MaxValue - (width - 1) + 1;
            var max = (begin, (int)(begin * (2 * n + 1L) / width));
            var list = new List<(int, int)> { max };
            for (var i = 1; i < width - 1; ++i) {
                var x = i + begin;
                var mul = x * (2 * n + 1L);
                var rem = mul % width;
                var y = (int)(mul / width - (rem == 0 ? 1 : 0));
                var item = (x, y);
                var cmp = CompareSteep(max, item);
                if (cmp == 1) {
                    continue;
                }
                if (cmp == -1) {
                    max = item;
                    list.Clear();
                    list.Add(item);
                    continue;
                }
                list.Add(item);
            }
            return list;
        }

        [Test]
        public void CollectMostSteepPointsTest() {
            var list = CollectMostSteepPoints(32);
            Assert.AreEqual(list.Count, 1);
            Assert.AreEqual((2147418113, 2129855), list[0]);
        }

        public struct AtanCase {
            public Func<int, int> Atan;
            public Func<int, int, int> Atan2;
            public string DataPath;
            public double AcceptableErrorAtan;
            public double AcceptableErrorAtan2;
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
            }
            public override readonly string ToString() {
                return DataPath;
            }
        }

        static void AtanTest(
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
                const double scale = System.Math.PI / atanStraight;
                var expectedReal = System.Math.Atan(x / (double)atanOne);
                var actualReal = scale * actual;
                if (System.Math.Abs(actualReal - expectedReal) >= acceptableError) {
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
                expected -= atanRight;
                test((int)(kNeg / 3) - 1, expected);
                test(int.MinValue, expected);
                expected = -expected;
                test((int)(k / 3) + 1, expected);
                test(int.MaxValue, expected);
            }
            var processorCount = Environment.ProcessorCount;
            Parallel.For(0, processorCount, n => {
                var begin = 2 + (atanOne - 1) * n / processorCount;
                var end = 2 + (atanOne - 1) * (n + 1) / processorCount;
                for (var i = begin; i < end; ++i) {
                    var expected = data[i];
                    test(i, expected);
                    test(-i, -expected);
                    var i2 = 2 * i;
                    var i2Add = i2 + 1;
                    var i2Sub = i2 - 1;
                    expected -= atanRight;
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
                var expectedReal = System.Math.Atan2(y, x);
                var actualReal = System.Math.PI * actual / atanStraight;
                if (System.Math.Abs(actualReal - expectedReal) >= acceptableError) {
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
            test(1, 1, atanRightHalf);
            test(1, 0, atanRight);
            test(1, -1, atanRightHalfOppositeNeg);
            test(0, -1, atanStraight);
            test(-1, 1, atanRightHalfNeg);
            test(-1, 0, atanRightNeg);
            test(-1, -1, atanRightHalfOpposite);
            test(0, int.MaxValue, 0);
            test(0, int.MinValue, atanStraight);
            test(int.MaxValue, 0, atanRight);
            test(int.MinValue, 0, atanRightNeg);
            test(int.MaxValue, int.MaxValue, atanRightHalf);
            test(int.MinValue, int.MinValue, atanRightHalfOpposite);
            test(int.MinValue, int.MaxValue, atanRightHalfNeg);
            test(int.MaxValue, int.MinValue, atanRightHalfOppositeNeg);
            test(0, -int.MaxValue, atanStraight);
            test(int.MinValue, -int.MaxValue, atanRightHalfOpposite);
            test(int.MaxValue, -int.MaxValue, atanRightHalfOppositeNeg);
            test(-int.MaxValue, 0, atanRightNeg);
            test(-int.MaxValue, int.MinValue, atanRightHalfOpposite);
            test(-int.MaxValue, int.MaxValue, atanRightHalfNeg);
            test(-int.MaxValue, -int.MaxValue, atanRightHalfOpposite);
            test(1, int.MaxValue, 0);
            test(1, int.MinValue, atanStraight);
            test(1, -int.MaxValue, atanStraight);
            test(-1, int.MaxValue, 0);
            test(-1, int.MinValue, atanStraightNeg);
            test(-1, -int.MaxValue, atanStraightNeg);
            test(int.MinValue, 1, atanRightNeg);
            test(int.MaxValue, 1, atanRight);
            test(int.MinValue, -1, atanRightNeg);
            test(int.MaxValue, -1, atanRight);
            test(-int.MaxValue, 1, atanRightNeg);
            test(-int.MaxValue, -1, atanRightNeg);

            // Test each of the 8 regions partitioned by the following 4 lines.
            // * x-axis
            // * y-axis
            // * y = x
            // * y = -x
            void testDefault(int y, int x, int expected) {
                test(y, x, expected);
                test(-y, x, -expected);
                test(y, -x, atanStraight - expected);
                test(-y, -x, expected - atanStraight);
                test(x, y, atanRight - expected);
                test(-x, y, atanRightNeg + expected);
                test(x, -y, atanRight + expected);
                test(-x, -y, atanRightNeg - expected);
            }

            var processorCount = Environment.ProcessorCount;
            Parallel.For(0, processorCount, n => {
                // Test far from x-axis
                {
                    var begin = atanOne * n / processorCount;
                    var end = atanOne * (n + 1) / processorCount;
                    for (var i = begin; i < end; ++i) {
                        var list = CollectMostSteepPoints(i);
                        foreach (var (x, y) in list) {
                            testDefault(y, x, data[i]);
                        }
                    }
                }

                // Test near to x-axis
                {
                    var begin = 1 + atanOne * n / processorCount;
                    var end = 1 + atanOne * (n + 1) / processorCount;
                    for (var i = begin; i < end; ++i) {
                        var x = 1 << 16;
                        var y = 2 * i - 1;
                        testDefault(y, x, data[i]);
                    }
                }
            });
        }

        public static readonly AtanCase[] AtanCases = {
            new AtanCase(Math.AtanP2_2850, Math.Atan2P2_2850, "atan_p2_i17f15.json", 0.003778, 0.003778),
            new AtanCase(Math.AtanP3_2555_691, Math.Atan2P3_2555_691, "atan_p3_i17f15.json", 0.001543, 0.001543),
            new AtanCase(Math.AtanP5_787_2968, Math.Atan2P5_787_2968, "atan_p5_i17f15.json", 0.000767, 0.000767),
        };

        [Test]
        public static void AtanTest(
            [ValueSource(nameof(AtanCases))] AtanCase atanCase
        ) {
            var data = ReadInts(MakeUpPath(atanCase.DataPath));
            Assert.AreEqual(data.Count, atanOne + 1);
            Assert.AreEqual(data[0], 0);
            Assert.AreEqual(data[atanOne], atanRightHalf);
            Atan2Test(atanCase.Atan2, data, atanCase.AcceptableErrorAtan2);
            AtanTest(atanCase.Atan, data, atanCase.AcceptableErrorAtan);
        }
    }
}
#pragma warning restore IDE0090 // 'new(...)' を使用する
