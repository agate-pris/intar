using AgatePris.Intar.Num;
using NUnit.Framework;

namespace AgatePris.Intar.Tests.Num {
    public class SignTest {
        [Test]
        public static void Test() {
            Assert.IsTrue(0.IsNegativeOrZero());
            Assert.IsTrue(0.IsPositiveOrZero());
            Assert.IsTrue(0.IsZero());
            Assert.IsTrue(0L.IsNegativeOrZero());
            Assert.IsTrue(0L.IsPositiveOrZero());
            Assert.IsTrue(0L.IsZero());
            Assert.IsTrue(1.IsGreaterThanZero());
            Assert.IsTrue(1.IsPositiveOrZero());
            Assert.IsTrue(1L.IsGreaterThanZero());
            Assert.IsTrue(1L.IsPositiveOrZero());
            Assert.IsTrue((-1).IsLessThanZero());
            Assert.IsTrue((-1).IsNegativeOrZero());
            Assert.IsTrue((-1L).IsLessThanZero());
            Assert.IsTrue((-1L).IsNegativeOrZero());
            Assert.IsFalse(0.IsGreaterThanZero());
            Assert.IsFalse(0.IsLessThanZero());
            Assert.IsFalse(0L.IsGreaterThanZero());
            Assert.IsFalse(0L.IsLessThanZero());
            Assert.IsFalse(1.IsLessThanZero());
            Assert.IsFalse(1.IsNegativeOrZero());
            Assert.IsFalse(1.IsZero());
            Assert.IsFalse(1L.IsLessThanZero());
            Assert.IsFalse(1L.IsNegativeOrZero());
            Assert.IsFalse(1L.IsZero());
            Assert.IsFalse((-1).IsGreaterThanZero());
            Assert.IsFalse((-1).IsPositiveOrZero());
            Assert.IsFalse((-1).IsZero());
            Assert.IsFalse((-1L).IsGreaterThanZero());
            Assert.IsFalse((-1L).IsPositiveOrZero());
            Assert.IsFalse((-1L).IsZero());
        }
    }
}
