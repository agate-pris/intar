using System;

using NUnit.Framework;

namespace AgatePris.Intar.Tests.Mathi {
    public class AsinTest {
        [Test]
        public static void TestConsts() {
            var actual = new ulong[] {
                Intar.Mathi.AsinInternal.P3U32A,
                Intar.Mathi.AsinInternal.P3U32B,
                Intar.Mathi.AsinInternal.P3U32C,
                Intar.Mathi.AsinInternal.P3U32D,
                Intar.Mathi.AsinInternal.P3U64A,
                Intar.Mathi.AsinInternal.P3U64B,
                Intar.Mathi.AsinInternal.P3U64C,
                Intar.Mathi.AsinInternal.P3U64D,
            };
            for (var i = 0; i < actual.Length / 2; ++i) {
                Assert.IsTrue(actual[i] > 1U << 31);
            }
            for (var i = actual.Length / 2; i < actual.Length; ++i) {
                Assert.IsTrue(actual[i] > 1UL << 63);
            }
            foreach (var x in actual) {
                Console.WriteLine($"{x},");
            }
            Assert.AreEqual(new ulong[] {
                4294782660,
                2319904613,
                3248783419,
                3277490973,
                18445951068606135392,
                9963914441109755535,
                13953418538510380357,
                14076716544798613906,
            }, actual);
        }

        static void TestAsin(
            int[] expectedHead, int[] expectedTail,
            Func<int, int> asin, Func<int, uint> acos,
            double error
        ) {
            const int one = 1 << 15;
            for (var x = 0; x < expectedHead.Length; ++x) {
                Console.WriteLine($"{asin(x)},");
            }
            for (var x = 0; x < expectedTail.Length; ++x) {
                Console.WriteLine($"{asin(one - x)},");
            }
            const double toReal = 1.0 / one;
            const double toRad = Math.PI / (1U << 31);
            for (var x = -one; x <= one; ++x) {
                Utility.AssertAreEqual(Math.Asin(x * toReal), asin(x) * toRad, error);
                Utility.AssertAreEqual(Math.Acos(x * toReal), acos(x) * toRad, error);
            }
            const uint pi = 1U << 31;
            for (var iPos = 0; iPos < expectedHead.Length; ++iPos) {
                var ePos = expectedHead[iPos];
                var eNeg = -ePos;
                var iNeg = -iPos;
                Utility.AssertAreEqual(ePos, asin(iPos), iPos);
                Utility.AssertAreEqual(eNeg, asin(iNeg), iPos);
                Utility.AssertAreEqual(ePos + (pi / 2), acos(iNeg), iPos);
                Utility.AssertAreEqual(eNeg + (pi / 2), acos(iPos), iPos);
            }
            for (var iPos = 0; iPos < expectedTail.Length; ++iPos) {
                var ePos = expectedTail[iPos];
                var eNeg = -ePos;
                var iNeg = -iPos;
                var a = iNeg + one;
                var b = iPos - one;
                Utility.AssertAreEqual(ePos, asin(a), iPos);
                Utility.AssertAreEqual(eNeg, asin(b), iPos);
                Utility.AssertAreEqual(ePos + (pi / 2), acos(b), iPos);
                Utility.AssertAreEqual(eNeg + (pi / 2), acos(a), iPos);
            }
        }
        [Test]
        public static void TestAsinP3() {
            var head = new int[] {
                0, 98302,
                131068, 131068, 163834, 196599, 229364, 229364, 262129, 262129,
                294894, 294894, 360420, 360420, 393184, 393184, 425948, 425948,
                458712, 458712, 524233, 524233, 556996, 556996, 589759, 589759,
                622522, 655276, 688038, 688038, 720800, 720800, 753562, 753562,
                786324, 819074, 851835, 851835, 884596, 884596, 917357, 917357,
                982864, 982864,
            };
            var tail = new int[] {
                1073741824, 1068402324, 1066189824, 1064508324, 1063062824,
                1061823824, 1060673324, 1059640824, 1058637824, 1057723324,
                1056867252, 1056041224, 1055244697, 1054507172, 1053769647,
                1053061623, 1052383100, 1051734078, 1051085056, 1050465535,
            };
            TestAsin(head, tail, Intar.Mathi.AsinP3, Intar.Mathi.AcosP3, 0.00017);
        }
    }
}
