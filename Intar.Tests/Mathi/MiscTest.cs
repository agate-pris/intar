using NUnit.Framework;

#if NET7_0_OR_GREATER

using System;

#endif // NET7_0_OR_GREATER

namespace Intar.Tests.Mathi {
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

#if NET7_0_OR_GREATER

            Assert.AreEqual(Intar.Mathi.AbsDiff((Int128)2, (Int128)100), (UInt128)98);
            Assert.AreEqual(Intar.Mathi.AbsDiff((Int128)100, (Int128)2), (UInt128)98);
            Assert.AreEqual(Intar.Mathi.AbsDiff((Int128)(-2), (Int128)100), (UInt128)102);
            Assert.AreEqual(Intar.Mathi.AbsDiff((Int128)(-2), (Int128)(-100)), (UInt128)98);
            Assert.AreEqual(Intar.Mathi.AbsDiff((UInt128)2, (UInt128)100), (UInt128)98);
            Assert.AreEqual(Intar.Mathi.AbsDiff((UInt128)100, (UInt128)2), (UInt128)98);
            Assert.AreEqual(Intar.Mathi.AbsDiff(Int128.MinValue, Int128.MaxValue), UInt128.MaxValue);

#endif // NET7_0_OR_GREATER

        }

        [Test]
        public static void TestUnsignedAbs() {
            Utility.AssertAreEqual(Intar.Mathi.UnsignedAbs(100), 100);
            Utility.AssertAreEqual(Intar.Mathi.UnsignedAbs(100L), 100);
            Utility.AssertAreEqual(Intar.Mathi.UnsignedAbs(-2), 2);
            Utility.AssertAreEqual(Intar.Mathi.UnsignedAbs(-2L), 2);
            Utility.AssertAreEqual(Intar.Mathi.UnsignedAbs(int.MinValue), (uint)int.MaxValue + 1);
            Utility.AssertAreEqual(Intar.Mathi.UnsignedAbs(long.MinValue), (ulong)long.MaxValue + 1);
        }
    }
}
