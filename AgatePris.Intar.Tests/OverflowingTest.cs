using NUnit.Framework;

using i32 = System.Int32;
using i64 = System.Int64;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace AgatePris.Intar.Tests {
    public class OverflowingTest {
        [Test]
        public void Test() {
            const i32 i32_0 = 0;
            const i64 i64_0 = 0;
            const u32 u32_0 = 0;
            const u64 u64_0 = 0;
            const i32 i32_2 = 2;
            const i64 i64_2 = 2;
            const u32 u32_2 = 2;
            const u64 u64_2 = 2;
            const i32 i32Neg2 = -2;
            const i64 i64Neg2 = -2;
            const i32 i32_100 = 100;
            const i64 i64_100 = 100;
            const u32 u32_1 = 1;
            const u64 u64_1 = 1;
            const u32 u32_100 = 100;
            const u64 u64_100 = 100;
            const u32 u32_200 = 200;
            const u64 u64_200 = 200;
            Utility.AssertAreEqual(Overflowing.WrappingAdd(i32_100, 27), 127);
            Utility.AssertAreEqual(Overflowing.WrappingAdd(i64_100, 27), 127);
            Utility.AssertAreEqual(Overflowing.WrappingAdd(u32_200, 55), 255);
            Utility.AssertAreEqual(Overflowing.WrappingAdd(u64_200, 55), 255);
            Utility.AssertAreEqual(Overflowing.WrappingAdd(i32.MaxValue, 2), i32.MinValue + 1);
            Utility.AssertAreEqual(Overflowing.WrappingAdd(i64.MaxValue, 2), i64.MinValue + 1);
            Utility.AssertAreEqual(Overflowing.WrappingAdd(u32_200, u32.MaxValue), 199);
            Utility.AssertAreEqual(Overflowing.WrappingAdd(u64_200, u64.MaxValue), 199);
            Utility.AssertAreEqual(Overflowing.WrappingSub(i32_0, 127), -127);
            Utility.AssertAreEqual(Overflowing.WrappingSub(i64_0, 127), -127);
            Utility.AssertAreEqual(Overflowing.WrappingSub(u32_100, 100), 0);
            Utility.AssertAreEqual(Overflowing.WrappingSub(u64_100, 100), 0);
            Utility.AssertAreEqual(Overflowing.WrappingSub(i32Neg2, i32.MaxValue), i32.MaxValue);
            Utility.AssertAreEqual(Overflowing.WrappingSub(i64Neg2, i64.MaxValue), i64.MaxValue);
            Utility.AssertAreEqual(Overflowing.WrappingSub(u32_100, u32.MaxValue), 101);
            Utility.AssertAreEqual(Overflowing.WrappingSub(u64_100, u64.MaxValue), 101);
            Utility.AssertAreEqual(Overflowing.WrappingAddUnsigned(i32_100, 27), 127);
            Utility.AssertAreEqual(Overflowing.WrappingAddUnsigned(i64_100, 27), 127);
            Utility.AssertAreEqual(Overflowing.WrappingAddUnsigned(i32_2, u32.MaxValue), 1);
            Utility.AssertAreEqual(Overflowing.WrappingAddUnsigned(i64_2, u64.MaxValue), 1);
            Utility.AssertAreEqual(Overflowing.WrappingSubUnsigned(i32_0, 127), -127);
            Utility.AssertAreEqual(Overflowing.WrappingSubUnsigned(i64_0, 127), -127);
            Utility.AssertAreEqual(Overflowing.WrappingSubUnsigned(i32Neg2, u32.MaxValue), -1);
            Utility.AssertAreEqual(Overflowing.WrappingSubUnsigned(i64Neg2, u64.MaxValue), -1);
            Utility.AssertAreEqual(Overflowing.WrappingAddSigned(u32_1, 2), 3);
            Utility.AssertAreEqual(Overflowing.WrappingAddSigned(u64_1, 2), 3);
            Utility.AssertAreEqual(Overflowing.WrappingAddSigned(u32_1, -2), u32.MaxValue);
            Utility.AssertAreEqual(Overflowing.WrappingAddSigned(u64_1, -2), u64.MaxValue);
            Utility.AssertAreEqual(Overflowing.WrappingAddSigned(u32.MaxValue, 2), 1);
            Utility.AssertAreEqual(Overflowing.WrappingAddSigned(u64.MaxValue, 2), 1);
            Utility.AssertAreEqual(Overflowing.WrappingNeg(i32_100), -100);
            Utility.AssertAreEqual(Overflowing.WrappingNeg(i64_100), -100);
            Utility.AssertAreEqual(Overflowing.WrappingNeg(i32.MinValue), i32.MinValue);
            Utility.AssertAreEqual(Overflowing.WrappingNeg(i64.MinValue), i64.MinValue);
            Utility.AssertAreEqual(Overflowing.WrappingNeg(u32_0), 0);
            Utility.AssertAreEqual(Overflowing.WrappingNeg(u64_0), 0);
            Utility.AssertAreEqual(Overflowing.WrappingNeg(u32.MaxValue), 1);
            Utility.AssertAreEqual(Overflowing.WrappingNeg(u64.MaxValue), 1);
            Utility.AssertAreEqual(Overflowing.WrappingNeg(u32_2), unchecked((u32)((~2) + 1)));
            Utility.AssertAreEqual(Overflowing.WrappingNeg(u64_2), unchecked((u64)((~2) + 1)));
            Utility.AssertAreEqual(Overflowing.WrappingNeg(u32_2), unchecked((u32)~1));
            Utility.AssertAreEqual(Overflowing.WrappingNeg(u64_2), unchecked((u64)~1));
            Utility.AssertAreEqual(Overflowing.WrappingAbs(i32_100), 100);
            Utility.AssertAreEqual(Overflowing.WrappingAbs(i64_100), 100);
            Utility.AssertAreEqual(Overflowing.WrappingAbs(i32Neg2), 2);
            Utility.AssertAreEqual(Overflowing.WrappingAbs(i64Neg2), 2);
            Utility.AssertAreEqual(Overflowing.WrappingAbs(i32.MinValue), i32.MinValue);
            Utility.AssertAreEqual(Overflowing.WrappingAbs(i64.MinValue), i64.MinValue);
            Utility.AssertAreEqual(unchecked((u32)Overflowing.WrappingAbs(i32.MinValue)), (u32)i32.MaxValue + 1);
            Utility.AssertAreEqual(unchecked((u64)Overflowing.WrappingAbs(i64.MinValue)), (u64)i64.MaxValue + 1);
        }

        [Test]
        public static void TestOverflowingAddInt() {
            var o01 = Overflowing.OverflowingAdd(int.MinValue, int.MinValue, out var _);
            var o02 = Overflowing.OverflowingAdd(int.MinValue, int.MaxValue, out var _);
            var o03 = Overflowing.OverflowingAdd(int.MaxValue, int.MinValue, out var _);
            var o04 = Overflowing.OverflowingAdd(int.MaxValue, int.MaxValue, out var _);
            var o05 = Overflowing.OverflowingAdd(int.MinValue, -1, out var _);
            var o06 = Overflowing.OverflowingAdd(int.MaxValue, -1, out var r06);
            var o07 = Overflowing.OverflowingAdd(int.MinValue, 0, out var r07);
            var o08 = Overflowing.OverflowingAdd(int.MaxValue, 0, out var r08);
            var o09 = Overflowing.OverflowingAdd(int.MinValue, 1, out var r09);
            var o10 = Overflowing.OverflowingAdd(int.MaxValue, 1, out var _);
            var o11 = Overflowing.OverflowingAdd(-1, int.MinValue, out var _);
            var o12 = Overflowing.OverflowingAdd(-1, int.MaxValue, out var r12);
            var o13 = Overflowing.OverflowingAdd(0, int.MinValue, out var r13);
            var o14 = Overflowing.OverflowingAdd(0, int.MaxValue, out var r14);
            var o15 = Overflowing.OverflowingAdd(1, int.MinValue, out var r15);
            var o16 = Overflowing.OverflowingAdd(1, int.MaxValue, out var _);
            var o17 = Overflowing.OverflowingAdd(-1, -1, out var r17);
            var o18 = Overflowing.OverflowingAdd(-1, 0, out var r18);
            var o19 = Overflowing.OverflowingAdd(-1, 1, out var r19);
            var o20 = Overflowing.OverflowingAdd(0, -1, out var r20);
            var o21 = Overflowing.OverflowingAdd(0, 0, out var r21);
            var o22 = Overflowing.OverflowingAdd(0, 1, out var r22);
            var o23 = Overflowing.OverflowingAdd(1, -1, out var r23);
            var o24 = Overflowing.OverflowingAdd(1, 0, out var r24);
            var o25 = Overflowing.OverflowingAdd(1, 1, out var r25);
            Assert.IsTrue(o01);
            Assert.IsFalse(o02);
            Assert.IsFalse(o03);
            Assert.IsTrue(o04);
            Assert.IsTrue(o05);
            Assert.IsFalse(o06);
            Assert.IsFalse(o07);
            Assert.IsFalse(o08);
            Assert.IsFalse(o09);
            Assert.IsTrue(o10);
            Assert.IsTrue(o11);
            Assert.IsFalse(o12);
            Assert.IsFalse(o13);
            Assert.IsFalse(o14);
            Assert.IsFalse(o15);
            Assert.IsTrue(o16);
            Assert.IsFalse(o17);
            Assert.IsFalse(o18);
            Assert.IsFalse(o19);
            Assert.IsFalse(o20);
            Assert.IsFalse(o21);
            Assert.IsFalse(o22);
            Assert.IsFalse(o23);
            Assert.IsFalse(o24);
            Assert.IsFalse(o25);
            Assert.AreEqual(int.MaxValue - 1, r06);
            Assert.AreEqual(int.MinValue, r07);
            Assert.AreEqual(int.MaxValue, r08);
            Assert.AreEqual(int.MinValue + 1, r09);
            Assert.AreEqual(int.MaxValue - 1, r12);
            Assert.AreEqual(int.MinValue, r13);
            Assert.AreEqual(int.MaxValue, r14);
            Assert.AreEqual(int.MinValue + 1, r15);
            Assert.AreEqual(-2, r17);
            Assert.AreEqual(-1, r18);
            Assert.AreEqual(0, r19);
            Assert.AreEqual(-1, r20);
            Assert.AreEqual(0, r21);
            Assert.AreEqual(1, r22);
            Assert.AreEqual(0, r23);
            Assert.AreEqual(1, r24);
            Assert.AreEqual(2, r25);
        }

        [Test]
        public static void TestOverflowingAddLong() {
            var o01 = Overflowing.OverflowingAdd(long.MinValue, long.MinValue, out var _);
            var o02 = Overflowing.OverflowingAdd(long.MinValue, long.MaxValue, out var _);
            var o03 = Overflowing.OverflowingAdd(long.MaxValue, long.MinValue, out var _);
            var o04 = Overflowing.OverflowingAdd(long.MaxValue, long.MaxValue, out var _);
            var o05 = Overflowing.OverflowingAdd(long.MinValue, -1, out var _);
            var o06 = Overflowing.OverflowingAdd(long.MaxValue, -1, out var r06);
            var o07 = Overflowing.OverflowingAdd(long.MinValue, 0, out var r07);
            var o08 = Overflowing.OverflowingAdd(long.MaxValue, 0, out var r08);
            var o09 = Overflowing.OverflowingAdd(long.MinValue, 1, out var r09);
            var o10 = Overflowing.OverflowingAdd(long.MaxValue, 1, out var _);
            var o11 = Overflowing.OverflowingAdd(-1, long.MinValue, out var _);
            var o12 = Overflowing.OverflowingAdd(-1, long.MaxValue, out var r12);
            var o13 = Overflowing.OverflowingAdd(0, long.MinValue, out var r13);
            var o14 = Overflowing.OverflowingAdd(0, long.MaxValue, out var r14);
            var o15 = Overflowing.OverflowingAdd(1, long.MinValue, out var r15);
            var o16 = Overflowing.OverflowingAdd(1, long.MaxValue, out var _);
            var o17 = Overflowing.OverflowingAdd(-1L, -1, out var r17);
            var o18 = Overflowing.OverflowingAdd(-1L, 0, out var r18);
            var o19 = Overflowing.OverflowingAdd(-1L, 1, out var r19);
            var o20 = Overflowing.OverflowingAdd(0L, -1, out var r20);
            var o21 = Overflowing.OverflowingAdd(0L, 0, out var r21);
            var o22 = Overflowing.OverflowingAdd(0L, 1, out var r22);
            var o23 = Overflowing.OverflowingAdd(1L, -1, out var r23);
            var o24 = Overflowing.OverflowingAdd(1L, 0, out var r24);
            var o25 = Overflowing.OverflowingAdd(1L, 1, out var r25);
            Assert.IsTrue(o01);
            Assert.IsFalse(o02);
            Assert.IsFalse(o03);
            Assert.IsTrue(o04);
            Assert.IsTrue(o05);
            Assert.IsFalse(o06);
            Assert.IsFalse(o07);
            Assert.IsFalse(o08);
            Assert.IsFalse(o09);
            Assert.IsTrue(o10);
            Assert.IsTrue(o11);
            Assert.IsFalse(o12);
            Assert.IsFalse(o13);
            Assert.IsFalse(o14);
            Assert.IsFalse(o15);
            Assert.IsTrue(o16);
            Assert.IsFalse(o17);
            Assert.IsFalse(o18);
            Assert.IsFalse(o19);
            Assert.IsFalse(o20);
            Assert.IsFalse(o21);
            Assert.IsFalse(o22);
            Assert.IsFalse(o23);
            Assert.IsFalse(o24);
            Assert.IsFalse(o25);
            Assert.AreEqual(long.MaxValue - 1, r06);
            Assert.AreEqual(long.MinValue, r07);
            Assert.AreEqual(long.MaxValue, r08);
            Assert.AreEqual(long.MinValue + 1, r09);
            Assert.AreEqual(long.MaxValue - 1, r12);
            Assert.AreEqual(long.MinValue, r13);
            Assert.AreEqual(long.MaxValue, r14);
            Assert.AreEqual(long.MinValue + 1, r15);
            Assert.AreEqual(-2, r17);
            Assert.AreEqual(-1, r18);
            Assert.AreEqual(0, r19);
            Assert.AreEqual(-1, r20);
            Assert.AreEqual(0, r21);
            Assert.AreEqual(1, r22);
            Assert.AreEqual(0, r23);
            Assert.AreEqual(1, r24);
            Assert.AreEqual(2, r25);
        }

        [Test]
        public static void TestOverflowingAddUInt() {
            var o01 = Overflowing.OverflowingAdd(uint.MinValue, uint.MinValue, out var r01);
            var o02 = Overflowing.OverflowingAdd(uint.MinValue, uint.MaxValue, out var r02);
            var o03 = Overflowing.OverflowingAdd(uint.MaxValue, uint.MinValue, out var r03);
            var o04 = Overflowing.OverflowingAdd(uint.MaxValue, uint.MaxValue, out var _);
            var o09 = Overflowing.OverflowingAdd(uint.MinValue, 1, out var r09);
            var o10 = Overflowing.OverflowingAdd(uint.MaxValue, 1, out var _);
            var o15 = Overflowing.OverflowingAdd(1, uint.MinValue, out var r15);
            var o16 = Overflowing.OverflowingAdd(1, uint.MaxValue, out var _);
            var o25 = Overflowing.OverflowingAdd(1U, 1, out var r25);
            Assert.IsFalse(o01);
            Assert.IsFalse(o02);
            Assert.IsFalse(o03);
            Assert.IsTrue(o04);
            Assert.IsFalse(o09);
            Assert.IsTrue(o10);
            Assert.IsFalse(o15);
            Assert.IsTrue(o16);
            Assert.IsFalse(o25);
            Assert.AreEqual(0, r01);
            Assert.AreEqual(uint.MaxValue, r02);
            Assert.AreEqual(uint.MaxValue, r03);
            Assert.AreEqual(0, r01);
            Assert.AreEqual(uint.MinValue + 1, r09);
            Assert.AreEqual(uint.MinValue + 1, r15);
            Assert.AreEqual(2, r25);
        }

        [Test]
        public static void TestOverflowingAddULong() {
            var o01 = Overflowing.OverflowingAdd(ulong.MinValue, ulong.MinValue, out var r01);
            var o02 = Overflowing.OverflowingAdd(ulong.MinValue, ulong.MaxValue, out var r02);
            var o03 = Overflowing.OverflowingAdd(ulong.MaxValue, ulong.MinValue, out var r03);
            var o04 = Overflowing.OverflowingAdd(ulong.MaxValue, ulong.MaxValue, out var _);
            var o09 = Overflowing.OverflowingAdd(ulong.MinValue, 1, out var r09);
            var o10 = Overflowing.OverflowingAdd(ulong.MaxValue, 1, out var _);
            var o15 = Overflowing.OverflowingAdd(1, ulong.MinValue, out var r15);
            var o16 = Overflowing.OverflowingAdd(1, ulong.MaxValue, out var _);
            var o25 = Overflowing.OverflowingAdd(1UL, 1, out var r25);
            Assert.IsFalse(o01);
            Assert.IsFalse(o02);
            Assert.IsFalse(o03);
            Assert.IsTrue(o04);
            Assert.IsFalse(o09);
            Assert.IsTrue(o10);
            Assert.IsFalse(o15);
            Assert.IsTrue(o16);
            Assert.IsFalse(o25);
            Assert.AreEqual(0, r01);
            Assert.AreEqual(ulong.MaxValue, r02);
            Assert.AreEqual(ulong.MaxValue, r03);
            Assert.AreEqual(0, r01);
            Assert.AreEqual(ulong.MinValue + 1, r09);
            Assert.AreEqual(ulong.MinValue + 1, r15);
            Assert.AreEqual(2, r25);
        }

        [Test]
        public static void TestSaturatingAdd() {
            Assert.AreEqual(ulong.MaxValue, Overflowing.SaturatingAdd(ulong.MaxValue - 1UL, 100UL));
            Assert.AreEqual(uint.MaxValue, Overflowing.SaturatingAdd(uint.MaxValue - 1U, 100U));
            Assert.AreEqual(101UL, Overflowing.SaturatingAdd(ulong.MinValue + 1UL, 100UL));
            Assert.AreEqual(101U, Overflowing.SaturatingAdd(uint.MinValue + 1U, 100U));
            Assert.AreEqual(long.MaxValue - 101, Overflowing.SaturatingAdd(long.MaxValue - 1, -100));
            Assert.AreEqual(long.MinValue + 101, Overflowing.SaturatingAdd(long.MinValue + 1, 100));
            Assert.AreEqual(int.MaxValue - 101, Overflowing.SaturatingAdd(int.MaxValue - 1, -100));
            Assert.AreEqual(int.MinValue + 101, Overflowing.SaturatingAdd(int.MinValue + 1, 100));
            Assert.AreEqual(long.MinValue, Overflowing.SaturatingAdd(long.MinValue + 1, -100));
            Assert.AreEqual(long.MaxValue, Overflowing.SaturatingAdd(long.MaxValue - 1, 100));
            Assert.AreEqual(int.MinValue, Overflowing.SaturatingAdd(int.MinValue + 1, -100));
            Assert.AreEqual(int.MaxValue, Overflowing.SaturatingAdd(int.MaxValue - 1, 100));
        }
    }
}
