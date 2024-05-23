using AgatePris.Intar.Integer;
using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace AgatePris.Intar.Tests.Integer {
    public partial class MathTest {
        [Test]
        public static void ClampTest() {
            AreEqual((-3).Clamp(-2, 1), -2);
            AreEqual(0.Clamp(-2, 1), 0);
            AreEqual(2.Clamp(-2, 1), 1);
            AreEqual(0U.Clamp(1, 4), 1);
            AreEqual(3U.Clamp(1, 4), 3);
            AreEqual(5U.Clamp(1, 4), 4);
            AreEqual((-3L).Clamp(-2, 1), -2L);
            AreEqual(0L.Clamp(-2, 1), 0L);
            AreEqual(2L.Clamp(-2, 1), 1L);
            AreEqual(0UL.Clamp(1, 4), 1);
            AreEqual(3UL.Clamp(1, 4), 3);
            AreEqual(5UL.Clamp(1, 4), 4);
        }
    }
}
