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
            Assert.AreEqual(1, BitOperations.PopCount(1U));
            Assert.AreEqual(1, BitOperations.PopCount(2U));
            Assert.AreEqual(2, BitOperations.PopCount(3U));
            Assert.AreEqual(1, BitOperations.PopCount(4U));
            Assert.AreEqual(2, BitOperations.PopCount(5U));
            Assert.AreEqual(2, BitOperations.PopCount(6U));
            Assert.AreEqual(3, BitOperations.PopCount(7U));
            Assert.AreEqual(1, BitOperations.PopCount(8U));
            Assert.AreEqual(2, BitOperations.PopCount(9U));
            Assert.AreEqual(32, BitOperations.PopCount(uint.MaxValue));

            var processorCount = Environment.ProcessorCount;
            var denominator = (ulong)processorCount;
            _ = Parallel.For(0, processorCount, n => {
                const uint offset = 10U;
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
            Assert.AreEqual(1, BitOperations.PopCount(1UL));
            Assert.AreEqual(1, BitOperations.PopCount(2UL));
            Assert.AreEqual(2, BitOperations.PopCount(3UL));
            Assert.AreEqual(1, BitOperations.PopCount(4UL));
            Assert.AreEqual(2, BitOperations.PopCount(5UL));
            Assert.AreEqual(2, BitOperations.PopCount(6UL));
            Assert.AreEqual(3, BitOperations.PopCount(7UL));
            Assert.AreEqual(1, BitOperations.PopCount(8UL));
            Assert.AreEqual(2, BitOperations.PopCount(9UL));
            Assert.AreEqual(64, BitOperations.PopCount(ulong.MaxValue));

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
