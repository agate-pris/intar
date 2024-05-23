using AgatePris.Intar.Integer;
using NUnit.Framework;
using System.Threading.Tasks;

namespace AgatePris.Intar.Tests.Integer {
    public partial class MathTest {
        [Test]
        public static void IsqrtTestUint() {
            const uint max = 0xffff;
            Assert.AreEqual(max, uint.MaxValue.Isqrt());

            var processorCount = System.Environment.ProcessorCount;
            Parallel.For(0, processorCount, n => {
                var begin = uint.MaxValue * (ulong)n / (ulong)processorCount;
                var end = uint.MaxValue * (ulong)(n + 1) / (ulong)processorCount;
                for (var x = (uint)begin; x < (uint)end; ++x) {
                    var actual = x.Isqrt();
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
            Assert.AreEqual(0, 0UL.Isqrt());
            Assert.AreEqual(max, ulong.MaxValue.Isqrt());

            var processorCount = System.Environment.ProcessorCount;
            Parallel.For(0, processorCount, n => {
                var begin = 1 + max * (ulong)n / (ulong)processorCount;
                var end = 1 + max * (ulong)(n + 1) / (ulong)processorCount;
                for (var y = begin; y < end; ++y) {
                    {
                        var actual = (y * y).Isqrt();
                        if (actual != y) {
                            Assert.Fail($"y: {y}, actual: {actual}");
                        }
                    }
                    {
                        var actual = (y * y - 1).Isqrt();
                        if (actual != y - 1) {
                            Assert.Fail($"y: {y}, actual: {actual}");
                        }
                    }
                }
            });
        }
    }
}
