using NUnit.Framework;

namespace AgatePris.Intar.Tests.Mathi {
    public static class MiscTest {
        [Test]
        public static void TestAbsDiff() {
            Utility.AssertAreEqual(Intar.Mathi.AbsDiff(2, 100), 98);
            Utility.AssertAreEqual(Intar.Mathi.AbsDiff(2U, 100U), 98);
            Utility.AssertAreEqual(Intar.Mathi.AbsDiff(2L, 100L), 98);
            Utility.AssertAreEqual(Intar.Mathi.AbsDiff(2UL, 100UL), 98);
            Utility.AssertAreEqual(Intar.Mathi.AbsDiff(100, 2), 98);
            Utility.AssertAreEqual(Intar.Mathi.AbsDiff(100L, 2L), 98);
            Utility.AssertAreEqual(Intar.Mathi.AbsDiff(100U, 2U), 98);
            Utility.AssertAreEqual(Intar.Mathi.AbsDiff(100UL, 2UL), 98);
            Utility.AssertAreEqual(Intar.Mathi.AbsDiff(-2, 100), 102);
            Utility.AssertAreEqual(Intar.Mathi.AbsDiff(-2, -100), 98);
            Utility.AssertAreEqual(Intar.Mathi.AbsDiff(-2L, 100L), 102);
            Utility.AssertAreEqual(Intar.Mathi.AbsDiff(-2L, -100L), 98);
            Utility.AssertAreEqual(Intar.Mathi.AbsDiff(int.MinValue, int.MaxValue), uint.MaxValue);
            Utility.AssertAreEqual(Intar.Mathi.AbsDiff(long.MinValue, long.MaxValue), ulong.MaxValue);
        }
    }
}
