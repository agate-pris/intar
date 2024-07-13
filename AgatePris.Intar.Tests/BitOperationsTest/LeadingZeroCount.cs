using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace AgatePris.Intar.Tests.Integer {
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

        static void TestLeadingZeroCount(uint x) {
            var expected = LeadingZeroCount(x);
            var actual = BitOperations.LeadingZeroCount(x);
            if (expected != actual) {
                Assert.Fail();
            }
        }

        [Test]
        public static void LeadingZeroCountTestUint() {
            Assert.AreEqual(32, BitOperations.LeadingZeroCount(0U));
            Assert.AreEqual(0, BitOperations.LeadingZeroCount(uint.MaxValue));

            var processorCount = Environment.ProcessorCount;
            _ = Parallel.For(0, processorCount, n => {
                var begin = uint.MaxValue * (ulong)n / (ulong)processorCount;
                var end = uint.MaxValue * (ulong)(n + 1) / (ulong)processorCount;
                for (var x = (uint)begin; x < (uint)end; ++x) {
                    TestLeadingZeroCount(x);
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
