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
    }
}
