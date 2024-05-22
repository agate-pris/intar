using AgatePris.Intar.Integer;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace AgatePris.Intar.Tests.Integer {
    public partial class BitOperationsTest {
        static int PopCount(uint x) {
            var mask = 1;
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
        public static void PopCountTestUint() {
            static void Test(uint x) {
                var expected = PopCount(x);
                var actual = x.PopCount();
                if (expected != actual) {
                    Assert.Fail();
                }
            }

            Assert.AreEqual(0, 0U.PopCount());
            Assert.AreEqual(32, uint.MaxValue.PopCount());

            var processorCount = Environment.ProcessorCount;
            Parallel.For(0, processorCount, n => {
                var begin = uint.MaxValue * (ulong)n / (ulong)processorCount;
                var end = uint.MaxValue * (ulong)(n + 1) / (ulong)processorCount;
                for (var x = (uint)begin; x < (uint)end; ++x) {
                    Test(x);
                }
            });
        }

        [Test]
        public static void PopCountTestUlong() {
            static void Test(ulong x) {
                var expected = PopCount(x);
                var actual = x.PopCount();
                if (expected != actual) {
                    Assert.Fail();
                }
            }

            Assert.AreEqual(0, 0UL.PopCount());
            Assert.AreEqual(64, ulong.MaxValue.PopCount());

            var processorCount = Environment.ProcessorCount;
            Parallel.For(0, processorCount, n => {
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
