using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace AgatePris.Intar.Tests.Mathi {
    public class SinTest {
        public readonly struct SinCase {
            public Func<int, int> Sin { get; }
            public Func<int, int> Cos { get; }
            public string DataPath { get; }
            public double AcceptableError { get; }

            public SinCase(
                Func<int, int> sin,
                Func<int, int> cos,
                string dataPath,
                double acceptableError
            ) {
                Sin = sin;
                Cos = cos;
                DataPath = dataPath;
                AcceptableError = acceptableError;
            }
            public override string ToString() {
                return $"{DataPath}";
            }
        }

        public static readonly SinCase[] SinCases = {
            new SinCase(Intar.Mathi.SinP2, Intar.Mathi.CosP2, "sin_p2.json", 0.056010),
            new SinCase(Intar.Mathi.SinP3A16384, Intar.Mathi.CosP3A16384, "sin_p3.json", 0.020017),
            new SinCase(Intar.Mathi.SinP4A7369, Intar.Mathi.CosP4A7369, "sin_p4_7369.json", 0.001091),
            new SinCase(Intar.Mathi.SinP5A51438, Intar.Mathi.CosP5A51438, "sin_p5_51438.json", 0.000232),
        };

        static double ToRad(int x) {
            const double t = Math.PI / (1 << 16);
            return x * t;
        }
        static double ToReal(int x) {
            const double t = 1.0 / (1 << 30);
            return x * t;
        }

        [Test]
        public void TestSin(
            [ValueSource(nameof(SinCases))] SinCase sinCase,
            [Random(1)] ulong s0,
            [Random(1)] ulong s1
        ) {
            const int rightExp = 15;
            const int right = 1 << rightExp;
            const int rightMask = right - 1;
            const int straight = 2 * right;
            const int full = 2 * straight;
            const int negFull = -full;
            const int one = 1 << 30;

            List<int> data;
            {
                var path = Utility.MakeUpPath(sinCase.DataPath);
                if (File.Exists(path)) {
                    data = Utility.ReadInts(path);
                } else {
                    data = new List<int>();
                    Utility.WriteInts(path, x => {
                        var v = sinCase.Sin(x);
                        data.Add(v);
                        return v;
                    }, right);
                }
            }

            Assert.AreNotEqual(null, data);
            Assert.AreEqual(right + 1, data.Count);
            Assert.AreEqual(0, data[0]);
            Assert.AreEqual(one, data[right]);
            for (var i = 1; i < data.Count; i++) {
                if (data[i] <= 0) {
                    Assert.Fail($"data[{i}]: {data[i]}");
                }
            }

            void testSinInt(int x, int actual) {
                var masked = x & rightMask;
                int expected;
                switch ((x >> rightExp) & 3) {
                    case 0: expected = data[masked]; break;
                    case 1: expected = data[right - masked]; break;
                    case 2: expected = -data[masked]; break;
                    case 3: expected = -data[right - masked]; break;
                    default: Assert.Fail(); return;
                };
                if (expected != actual) {
                    Assert.Fail(
                        $"{nameof(x)}: {x}, " +
                        $"{nameof(expected)}: {expected}, " +
                        $"{nameof(actual)}: {actual}"
                    );
                }
            }
            void testSinReal(int x, int actual, double expected, double actualReal, double error, double absError) {
                if (absError >= sinCase.AcceptableError) {
                    Assert.Fail(
                        $"{nameof(x)}: {x}, " +
                        $"{nameof(actual)}: {actual}, " +
                        $"{nameof(expected)}: {expected}, " +
                        $"{nameof(actualReal)}: {actualReal}"
                    );
                }
            }

            var maxError = 0.0;
            var errorSum = 0.0;
            var absoluteErrorSum = 0.0;
            var squaredErrorSum = 0.0;
            void acc(double error, double absError) {
                maxError = Math.Max(maxError, absError);
                errorSum += error;
                absoluteErrorSum += absError;
                squaredErrorSum += absError * absError;
            }

            void testSinWithoutStatistics(int x, int actual, double expected, double actualReal, double error, double absError) {
                testSinInt(x, actual);
                testSinReal(x, actual, expected, actualReal, error, absError);
            }
            void testSinWithStatistics(int x) {
                var actual = sinCase.Sin(x);
                var expected = Math.Sin(ToRad(x));
                var actualReal = ToReal(actual);
                var error = actualReal - expected;
                var absError = Math.Abs(error);
                testSinWithoutStatistics(x, actual, expected, actualReal, error, absError);
                acc(error, absError);
            }
            void testSin(int x) {
                var actual = sinCase.Sin(x);
                var expected = Math.Sin(ToRad(x));
                var actualReal = ToReal(actual);
                var error = actualReal - expected;
                var absError = Math.Abs(error);
                testSinWithoutStatistics(x, actual, expected, actualReal, error, absError);
            }
            void testCos(int x) {
                var actual = sinCase.Cos(x);
                {
                    var masked = x & rightMask;
                    int expected;
                    switch ((x >> rightExp) & 3) {
                        case 0: expected = data[right - masked]; break;
                        case 1: expected = -data[masked]; break;
                        case 2: expected = -data[right - masked]; break;
                        case 3: expected = data[masked]; break;
                        default: Assert.Fail(); return;
                    };
                    if (expected != actual) {
                        Assert.Fail();
                    }
                }
                {
                    var expected = Math.Cos(ToRad(x));
                    var actualReal = ToReal(actual);
                    if (Math.Abs(actualReal - expected) > sinCase.AcceptableError) {
                        Assert.Fail();
                    }
                }
            }

            for (var i = 0U; i < 2; ++i) {
                var x = unchecked((int)(i * right));
                testSinWithStatistics(x);
                if (i == 0) {
                    testSinWithStatistics(x + 1);
                    testSinWithStatistics(x + rightMask);
                } else {
                    testSin(x + 1);
                    testSin(x + rightMask);
                }
                testCos(x);
                testCos(x + 1);
                testCos(x + rightMask);
            }
            for (var i = 2U; i <= uint.MaxValue / right; ++i) {
                var x = unchecked((int)(i * right));
                testSin(x);
                testCos(x);
                testSin(x + 1);
                testCos(x + 1);
                testSin(x + rightMask);
                testCos(x + rightMask);
            }

            int[] starts = {
                Overflowing.WrappingSub(int.MinValue, full),
                int.MinValue,
                negFull,
                0
            };

            for (var q = 0; q < 4; ++q) {
                var qr = q * right;
                foreach (var start in starts) {
                    if (q == 0 && start == 0) {
                        for (var x = 2; x < right - 1; ++x) {
                            testSinWithStatistics(start + qr + x);
                            testCos(start + qr + x);
                        }
                    } else {
                        for (var x = 2; x < right - 1; ++x) {
                            testSin(start + qr + x);
                            testCos(start + qr + x);
                        }
                    }
                }
            }

            {
                const int count = right + 1;
                Console.WriteLine(
                    $"Count: {count}\n" +
                    $"Max Error: {maxError}\n" +
                    $"Mean Error: {errorSum / count}\n" +
                    $"MAE: {absoluteErrorSum / count}\n" +
                    $"MSE: {squaredErrorSum / count}\n" +
                    $"RMSE: {Math.Sqrt(squaredErrorSum / count)}");
            }

            var rng = new Intar.Rand.Xoroshiro128StarStar(s0, s1);
            for (var i = 0; i < 999; ++i) {
                var x = unchecked(
                    (int)(uint)Intar.Mathi.Clamp(rng.Next(), 0, uint.MaxValue)
                );
                testSin(x);
                testCos(x);
            }
        }
    }
}
