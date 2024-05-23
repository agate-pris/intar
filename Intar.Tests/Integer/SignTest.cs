using AgatePris.Intar.Integer;
using NUnit.Framework;

namespace AgatePris.Intar.Tests.Integer {
    public class SignTest {
        [Test]
        public static void Test() {
#if NET7_0_OR_GREATER
            Assert.IsTrue(int.IsPositive(0));
            Assert.IsTrue(long.IsPositive(0));
            Assert.IsFalse(int.IsNegative(0));
            Assert.IsFalse(long.IsNegative(0));
#endif
            //Assert.IsTrue(0.IsNegativeInclusive());
            //Assert.IsTrue(0.IsPositiveInclusive());
            //Assert.IsTrue(0.IsZero());
            //Assert.IsTrue(0L.IsNegativeInclusive());
            //Assert.IsTrue(0L.IsPositiveInclusive());
            //Assert.IsTrue(0L.IsZero());
            //Assert.IsTrue(1.IsPositiveExclusive());
            //Assert.IsTrue(1.IsPositiveInclusive());
            //Assert.IsTrue(1L.IsPositiveExclusive());
            //Assert.IsTrue(1L.IsPositiveInclusive());
            Assert.IsTrue((-1).IsNegative());
            //Assert.IsTrue((-1).IsNegativeInclusive());
            Assert.IsTrue((-1L).IsNegative());
            //Assert.IsTrue((-1L).IsNegativeInclusive());
            Assert.IsFalse(0.IsNegative());
            //Assert.IsFalse(0.IsPositiveExclusive());
            Assert.IsFalse(0L.IsNegative());
            //Assert.IsFalse(0L.IsPositiveExclusive());
            Assert.IsFalse(1.IsNegative());
            //Assert.IsFalse(1.IsNegativeInclusive());
            //Assert.IsFalse(1.IsZero());
            Assert.IsFalse(1L.IsNegative());
            //Assert.IsFalse(1L.IsNegativeInclusive());
            //Assert.IsFalse(1L.IsZero());
            //Assert.IsFalse((-1).IsPositiveExclusive());
            //Assert.IsFalse((-1).IsPositiveInclusive());
            //Assert.IsFalse((-1).IsZero());
            //Assert.IsFalse((-1L).IsPositiveExclusive());
            //Assert.IsFalse((-1L).IsPositiveInclusive());
            //Assert.IsFalse((-1L).IsZero());
        }
    }
}
