using System;
using AgatePris.Intar.Integer;
using AgatePris.Intar.Mathematics;
using NUnit.Framework;

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0090 // 'new(...)' を使用する

namespace AgatePris.Intar.Tests.Mathematics {
    public partial class MathTest {
        public readonly struct SinCase {
            public readonly Func<int, int> Sin { get; }
            public readonly Func<int, int> Cos { get; }
            public readonly string DataPath { get; }
            public readonly double AcceptableError { get; }

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
            public override readonly string ToString() {
                return $"{DataPath}";
            }
        }

        public static readonly SinCase[] SinCases = {
            new SinCase(math.sin_p2, math.cos_p2, "sin_p2.json", 0.056010),
            new SinCase(math.sin_p3_16384, math.cos_p3_16384, "sin_p3.json", 0.020017),
            new SinCase(math.sin_p4_7032, math.cos_p4_7032, "sin_p4_7032.json", 0.002819),
            new SinCase(math.sin_p4_7384, math.cos_p4_7384, "sin_p4_7384.json", 0.001174),
            new SinCase(math.sin_p5_51472, math.cos_p5_51472, "sin_p5_51472.json", 0.000425),
            new SinCase(math.sin_p5_51437, math.cos_p5_51437, "sin_p5_51437.json", 0.000226),
        };

        [Test]
        public void SinTest(
            [ValueSource(nameof(SinCases))] SinCase sinCase,
            [Random(1)] ulong s0,
            [Random(1)] ulong s1
        ) {
            var sin = sinCase.Sin;
            var cos = sinCase.Cos;
            var acceptableError = sinCase.AcceptableError;
            const int rightExp = 15;
            const int right = 1 << rightExp;
            const int rightMask = right - 1;
            const int straight = 2 * right;
            const int full = 2 * straight;
            const int negFull = -full;
            const int one = 1 << 30;
            var data = ReadInts(MakeUpPath(sinCase.DataPath));
            Assert.AreNotEqual(null, data);
            Assert.AreEqual(right + 1, data.Count);
            Assert.AreEqual(0, data[0]);
            Assert.AreEqual(one, data[right]);
            for (var i = 1; i < data.Count; i++) {
                if (data[i] <= 0) {
                    Assert.Fail($"data[{i}]: {data[i]}");
                }
            }

            static double ToRad(int x) {
                const double t = System.Math.PI / (1 << 16);
                return x * t;
            }
            static double ToReal(int x) {
                const double t = 1.0 / (1 << 30);
                return x * t;
            }

            void testSin(int x) {
                var actual = sin(x);
                {
                    var masked = x & rightMask;
                    var expected = ((x >> rightExp) & 3) switch {
                        0 => data[masked],
                        1 => data[right - masked],
                        2 => -data[masked],
#if NET7_0_OR_GREATER
                        3 => -data[right - masked],
                        _ => throw new System.Diagnostics.UnreachableException(),
#else
                        _ => -data[right - masked],
#endif
                    };
                    if (expected != actual) {
                        Assert.Fail(
                            $"{nameof(x)}: {x}, " +
                            $"{nameof(expected)}: {expected}, " +
                            $"{nameof(actual)}: {actual}"
                        );
                    }
                }
                {
                    var expected = System.Math.Sin(ToRad(x));
                    var actualReal = ToReal(actual);
                    if (System.Math.Abs(actualReal - expected) >= acceptableError) {
                        Assert.Fail(
                            $"{nameof(x)}: {x}, " +
                            $"{nameof(actual)}: {actual}, " +
                            $"{nameof(expected)}: {expected}, " +
                            $"{nameof(actualReal)}: {actualReal}"
                        );
                    }
                }
            }
            void testCos(int x) {
                var actual = cos(x);
                {
                    var masked = x & rightMask;
                    var expected = ((x >> rightExp) & 3) switch {
                        0 => data[right - masked],
                        1 => -data[masked],
                        2 => -data[right - masked],
#if NET7_0_OR_GREATER
                        3 => data[masked],
                        _ => throw new System.Diagnostics.UnreachableException(),
#else
                        _ => data[masked],
#endif
                    };
                    if (expected != actual) {
                        Assert.Fail();
                    }
                }
                {
                    var expected = System.Math.Cos(ToRad(x));
                    var actualReal = ToReal(actual);
                    if (System.Math.Abs(actualReal - expected) > acceptableError) {
                        Assert.Fail();
                    }
                }
            }

            for (var i = 0; i <= uint.MaxValue / right; ++i) {
                var x = i * right;
                testSin(x);
                testCos(x);
                testSin(x + 1);
                testCos(x + 1);
                testSin(x + rightMask);
                testCos(x + rightMask);
            }

            int[] starts = {
                int.MinValue.WrappingSub(full),
                int.MinValue,
                negFull,
                0
            };

            for (var q = 0; q < 4; ++q) {
                var qr = q * right;
                foreach (var start in starts) {
                    for (var x = 2; x < right - 1; ++x) {
                        testSin(start + qr + x);
                        testCos(start + qr + x);
                    }
                }
            }

            var rng = new Intar.Rand.Xoroshiro128StarStar(s0, s1);
            for (var i = 0; i < 999; ++i) {
                var x = unchecked(
#if UNITY_2018_3_OR_NEWER
                    (int)(uint)Unity.Mathematics.math.clamp(
                        rng.Next(), 0, uint.MaxValue
                    )
#else
                    (int)(uint)math.clamp(rng.Next(), 0, uint.MaxValue)
#endif
                );
                testSin(x);
                testCos(x);
            }
        }
    }
}
