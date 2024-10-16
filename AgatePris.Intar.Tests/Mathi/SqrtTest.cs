using NUnit.Framework;
using System.Threading.Tasks;

namespace AgatePris.Intar.Tests.Mathi {
    public class SqrtTest {
        [Test]
        public static void TestSqrtUint() {
            const uint max = 0xffff;
            Utility.AssertAreEqual(max, Intar.Mathi.Sqrt(uint.MaxValue));

            var processorCount = System.Environment.ProcessorCount;
            _ = Parallel.For(0, processorCount, n => {
                var begin = uint.MaxValue * (ulong)n / (ulong)processorCount;
                var end = uint.MaxValue * (ulong)(n + 1) / (ulong)processorCount;
                for (var x = (uint)begin; x < (uint)end; ++x) {
                    var actual = Intar.Mathi.Sqrt(x);
                    if (x < actual * actual) {
                        Assert.Fail();
                    }
                    if (actual != max) {
                        var incremented = actual + 1;
                        if (x >= incremented * incremented) {
                            Assert.Fail();
                        }
                    }
                }
            });
        }

        [Test]
        public static void IsqrtTestUlong() {
            const ulong max = 0xffff_ffff;
            Utility.AssertAreEqual(0, Intar.Mathi.Sqrt(0UL));
            Utility.AssertAreEqual(max, Intar.Mathi.Sqrt(ulong.MaxValue));

            var processorCount = System.Environment.ProcessorCount;
            _ = Parallel.For(0, processorCount, n => {
                var begin = 1 + (max * (ulong)n / (ulong)processorCount);
                var end = 1 + (max * (ulong)(n + 1) / (ulong)processorCount);
                for (var y = begin; y < end; ++y) {
                    {
                        var actual = Intar.Mathi.Sqrt(y * y);
                        if (actual != y) {
                            Assert.Fail($"y: {y}, actual: {actual}");
                        }
                    }
                    {
                        var actual = Intar.Mathi.Sqrt((y * y) - 1);
                        if (actual != y - 1) {
                            Assert.Fail($"y: {y}, actual: {actual}");
                        }
                    }
                }
            });
        }

#if NET7_0_OR_GREATER

        [Test]
        public static void TestSqrtUInt128() {
            {
                var a = Intar.Mathi.Sqrt(new System.UInt128(0, 0));
                var e = new System.UInt128(0, 0);
                if (e != a) {
                    Assert.AreEqual(e, a);
                }
            }
            {
                var a = Intar.Mathi.Sqrt(new System.UInt128(ulong.MaxValue, ulong.MaxValue));
                var e = new System.UInt128(0, ulong.MaxValue);
                if (e != a) {
                    Assert.AreEqual(e, a);
                }
            }

            var processorCount = System.Environment.ProcessorCount;
            var rng = new Intar.Rand.Xoroshiro128StarStar(1, 2);
            _ = Parallel.For(0, processorCount, n => {
                var r = rng;
                for (var i = 0; i < n; ++i) {
                    r.Jump();
                }
                for (var i = 0; i < 99999; i++) {
                    var x = new System.UInt128(
                        unchecked((uint)r.NextInt64()),
                        unchecked((uint)r.NextInt64()));
                    var a = Intar.Mathi.Sqrt(x);
                    if (a * a > x) {
                        Assert.Fail();
                    }
                    if (a != new System.UInt128(0, ulong.MaxValue)) {
                        if ((a + 1) * (a + 1) <= x) {
                            Assert.Fail();
                        }
                    }
                }
            });
        }

#endif // NET7_0_OR_GREATER

    }
}
