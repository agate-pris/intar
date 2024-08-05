using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace AgatePris.Intar.Tests {
    public partial class BitOperationsTest {
        static int LeadingZeroCount(uint x) {
            const int bitsOfInt = sizeof(int) * 8;
            for (var rhs = 1; rhs < bitsOfInt; rhs <<= 1) {
                x |= x >> rhs;
            }
            unchecked {
                return bitsOfInt - PopCount(x);
            }
        }

        static int LeadingZeroCount(ulong x) {
            const int bitsOfLong = sizeof(long) * 8;
            for (var rhs = 1; rhs < bitsOfLong; rhs <<= 1) {
                x |= x >> rhs;
            }
            unchecked {
                return bitsOfLong - PopCount(x);
            }
        }

        [Test]
        public static void TestLeadingZeroCountUint() {
            Assert.AreEqual(0, BitOperations.LeadingZeroCount(uint.MaxValue));

            var processorCount = Environment.ProcessorCount;
            var denominator = (ulong)processorCount;
            _ = Parallel.For(0, processorCount, n => {
                var curr = (ulong)n;
                var next = curr + 1;
                var begin = (uint)(uint.MaxValue * curr / denominator);
                var end = (uint)(uint.MaxValue * next / denominator);
                for (var x = begin; x < end; ++x) {
                    var expected = LeadingZeroCount(x);
                    var actual = BitOperations.LeadingZeroCount(x);
                    if (expected != actual) {
                        Assert.Fail();
                    }
                }
            });
        }

        static void TestLeadingZeroCount(ulong x) {
            var expected = LeadingZeroCount(x);
            var actual = BitOperations.LeadingZeroCount(x);
            if (expected != actual) {
                Assert.Fail();
            }
        }

        [Test]
        public static void LeadingZeroCountTestUlong() {
            Assert.AreEqual(64, BitOperations.LeadingZeroCount(0UL));
            Assert.AreEqual(0, BitOperations.LeadingZeroCount(ulong.MaxValue));

            var processorCount = Environment.ProcessorCount;
            _ = Parallel.For(0, processorCount, n => {
                var rng = new Intar.Rand.Xoroshiro128StarStar(1, 2);
                for (var i = 0; i < n; ++i) {
                    rng.Jump();
                }
                for (var i = 0; i < 99999; ++i) {
                    TestLeadingZeroCount(rng.Next());
                }
            });
        }
    }
}
