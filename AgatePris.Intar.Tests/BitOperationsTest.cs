using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace AgatePris.Intar.Tests {
    public partial class BitOperationsTest {
        static int PopCount(uint x) {
            var mask = 1U;
            var count = 0;
            while (mask != 0) {
                if ((mask & x) != 0) {
                    ++count;
                }
                mask <<= 1;
            }
            return count;
        }

        static int PopCount(ulong x) {
            var mask = 1UL;
            var count = 0;
            while (mask != 0) {
                if ((mask & x) != 0) {
                    ++count;
                }
                mask <<= 1;
            }
            return count;
        }

        [Test]
        public static void TestPopCountUint() {
            Assert.AreEqual(0, BitOperations.PopCount(0U));
            Assert.AreEqual(32, BitOperations.PopCount(uint.MaxValue));
            for (var i = 0; i < 32; ++i) {
                var x = 1U << i;
                Assert.AreEqual(1, BitOperations.PopCount(x));
                Assert.AreEqual(31, BitOperations.PopCount(~x));

                for (var j = i + 1; j < 32; ++j) {
                    var y = 1U << j;
                    Assert.AreEqual(2, BitOperations.PopCount(x | y));
                    Assert.AreEqual(30, BitOperations.PopCount(~(x | y)));
                }
            }

            var processorCount = Environment.ProcessorCount;
            var denominator = (ulong)processorCount;
            _ = Parallel.For(0, processorCount, n => {
                const uint offset = 2U;
                const uint k = uint.MaxValue - offset;
                var curr = (ulong)n;
                var next = curr + 1;
                var begin = offset + (uint)(k * curr / denominator);
                var end = offset + (uint)(k * next / denominator);
                for (var x = begin; x < end; ++x) {
                    var expected = PopCount(x);
                    var actual = BitOperations.PopCount(x);
                    if (expected != actual) {
                        Assert.Fail();
                    }
                }
            });
        }

        [Test]
        public static void TestPopCountUlong() {
            Assert.AreEqual(0, BitOperations.PopCount(0UL));
            Assert.AreEqual(64, BitOperations.PopCount(ulong.MaxValue));
            for (var i = 0; i < 64; ++i) {
                var x = 1UL << i;
                Assert.AreEqual(1, BitOperations.PopCount(x));
                Assert.AreEqual(63, BitOperations.PopCount(~x));

                for (var j = i + 1; j < 64; ++j) {
                    var y = 1UL << j;
                    Assert.AreEqual(2, BitOperations.PopCount(x | y));
                    Assert.AreEqual(62, BitOperations.PopCount(~(x | y)));
                }
            }

            var processorCount = Environment.ProcessorCount;
            _ = Parallel.For(0, processorCount, n => {
                var rng = new Intar.Rand.Xoroshiro128StarStar(1, 2);
                for (var i = 0; i < n; ++i) {
                    rng.Jump();
                }
                for (var i = 0; i < 99999; ++i) {
                    var x = rng.Next();
                    var expected = PopCount(x);
                    var actual = BitOperations.PopCount(x);
                    if (expected != actual) {
                        Assert.Fail();
                    }
                }
            });
        }
    }
}
