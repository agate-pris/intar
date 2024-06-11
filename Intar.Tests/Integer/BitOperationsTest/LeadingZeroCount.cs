using AgatePris.Intar.Integer;
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

        [Test]
        public static void LeadingZeroCountTestUint() {
            static void Test(uint x) {
                var expected = LeadingZeroCount(x);
                var actual = x.LeadingZeroCount();
                if (expected != actual) {
                    Assert.Fail();
                }
            }

            Assert.AreEqual(32, 0U.LeadingZeroCount());
            Assert.AreEqual(0, uint.MaxValue.LeadingZeroCount());

            var processorCount = Environment.ProcessorCount;
            _ = Parallel.For(0, processorCount, n => {
                var begin = uint.MaxValue * (ulong)n / (ulong)processorCount;
                var end = uint.MaxValue * (ulong)(n + 1) / (ulong)processorCount;
                for (var x = (uint)begin; x < (uint)end; ++x) {
                    Test(x);
                }
            });
        }

        [Test]
        public static void LeadingZeroCountTestUlong() {
            static void Test(ulong x) {
                var expected = LeadingZeroCount(x);
                var actual = x.LeadingZeroCount();
                if (expected != actual) {
                    Assert.Fail();
                }
            }

            Assert.AreEqual(64, 0UL.LeadingZeroCount());
            Assert.AreEqual(0, ulong.MaxValue.LeadingZeroCount());

            var processorCount = Environment.ProcessorCount;
            _ = Parallel.For(0, processorCount, n => {
                var rng = new Intar.Rand.Xoroshiro128StarStar(1, 2);
                for (var i = 0; i < n; ++i) {
                    rng.Jump();
                }
                for (var i = 0; i < 99999; ++i) {
                    Test(rng.Next());
                }
            });
        }
    }
}
