#if !UNITY_2018_3_OR_NEWER

using AgatePris.Intar.Mathematics;
using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace AgatePris.Intar.Tests.Mathematics {
    public partial class MathTest {
        [Test]
        public static void ClampTest() {
            AreEqual(math.clamp(-3, -2, 1), -2);
            AreEqual(math.clamp(0, -2, 1), 0);
            AreEqual(math.clamp(2, -2, 1), 1);
            AreEqual(math.clamp(0U, 1, 4), 1);
            AreEqual(math.clamp(3U, 1, 4), 3);
            AreEqual(math.clamp(5U, 1, 4), 4);
            AreEqual(math.clamp(-3L, -2, 1), -2L);
            AreEqual(math.clamp(0L, -2, 1), 0L);
            AreEqual(math.clamp(2L, -2, 1), 1L);
            AreEqual(math.clamp(0UL, 1, 4), 1);
            AreEqual(math.clamp(3UL, 1, 4), 3);
            AreEqual(math.clamp(5UL, 1, 4), 4);
        }
    }
}

#endif
