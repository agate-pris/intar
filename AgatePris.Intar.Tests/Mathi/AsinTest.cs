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
                Intar.Mathi.AsinInternal.P7U64A,
                Intar.Mathi.AsinInternal.P7U64B,
                Intar.Mathi.AsinInternal.P7U64C,
                Intar.Mathi.AsinInternal.P7U64D,
                Intar.Mathi.AsinInternal.P7U64E,
                Intar.Mathi.AsinInternal.P7U64F,
                Intar.Mathi.AsinInternal.P7U64G,
                Intar.Mathi.AsinInternal.P7U64H,
            };
            for (var i = 0; i < 4; ++i) {
                Assert.IsTrue(actual[i] > 1U << 31);
            }
            for (var i = 4; i < actual.Length; ++i) {
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
                18446743817759831598,
                10080617338130213281,
                16718884102355766130,
                9427600920570779471,
                11608983047221464490,
                12843229610990092589,
                10026318940480150471,
                15181969944445121899,
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
        static void TestAsin(
            long[] expectedHead, long[] expectedTail,
            Func<long, long> asin, Func<long, ulong> acos,
            double error
        ) {
            const long one = 1L << 31;
            for (var x = 0; x < expectedHead.Length; ++x) {
                Console.WriteLine($"{asin(x)},");
            }
            for (var x = 0; x < expectedTail.Length; ++x) {
                Console.WriteLine($"{asin(one - x)},");
            }
            const double toReal = 1.0 / one;
            const double toRad = Math.PI / (1UL << 63);
            var rng = new Intar.Rand.Xoroshiro128StarStar(1, 2);
            for (var i = 0; i < 32768; ++i) {
                var xPos = rng.NextInt64(one + 1);
                var xNeg = -xPos;
                Utility.AssertAreEqual(Math.Asin(xPos * toReal), asin(xPos) * toRad, error, xPos);
                Utility.AssertAreEqual(Math.Acos(xPos * toReal), acos(xPos) * toRad, error, xPos);
                Utility.AssertAreEqual(Math.Asin(xNeg * toReal), asin(xNeg) * toRad, error, xPos);
                Utility.AssertAreEqual(Math.Acos(xNeg * toReal), acos(xNeg) * toRad, error, xPos);
            }
            const ulong pi = 1UL << 63;
            for (var iPos = 0; iPos < expectedHead.Length; ++iPos) {
                var ePos = expectedHead[iPos];
                var eNeg = -ePos;
                var iNeg = -iPos;
                Utility.AssertAreEqual(Math.Asin(iPos * toReal), asin(iPos) * toRad, error, iPos);
                Utility.AssertAreEqual(Math.Asin(iNeg * toReal), asin(iNeg) * toRad, error, iPos);
                Utility.AssertAreEqual(Math.Acos(iPos * toReal), acos(iPos) * toRad, error, iPos);
                Utility.AssertAreEqual(Math.Acos(iNeg * toReal), acos(iNeg) * toRad, error, iPos);
                Utility.AssertAreEqual(ePos, asin(iPos), iPos);
                Utility.AssertAreEqual(eNeg, asin(iNeg), iPos);
                Utility.AssertAreEqual((pi / 2) + (ulong)ePos, acos(iNeg), iPos);
                Utility.AssertAreEqual((pi / 2) - (ulong)ePos, acos(iPos), iPos);
            }
            for (var iPos = 0; iPos < expectedTail.Length; ++iPos) {
                var ePos = expectedTail[iPos];
                var eNeg = -ePos;
                var iNeg = -iPos;
                var a = iNeg + one;
                var b = iPos - one;
                Utility.AssertAreEqual(Math.Asin(a * toReal), asin(a) * toRad, error, iPos);
                Utility.AssertAreEqual(Math.Asin(b * toReal), asin(b) * toRad, error, iPos);
                Utility.AssertAreEqual(Math.Acos(b * toReal), acos(b) * toRad, error, iPos);
                Utility.AssertAreEqual(Math.Acos(a * toReal), acos(a) * toRad, error, iPos);
                Utility.AssertAreEqual(ePos, asin(a), iPos);
                Utility.AssertAreEqual(eNeg, asin(b), iPos);
                Utility.AssertAreEqual((pi / 2) + (ulong)ePos, acos(b), iPos);
                Utility.AssertAreEqual((pi / 2) - (ulong)ePos, acos(a), iPos);
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
        [Test]
        public static void TestAsinP3L() {
            var head = new long[] {
                0,
                198255690291041, 198257837682370, 198257837682370,
                198259985073699, 198259985073699, 198262132465028,
                198262132465028, 198266427340000, 198266427340000,
            };
            var tail = new long[] {
                4611686018427387904, 4611596428270291324, 4611559316214710272,
                4611530842243330936, 4611506836179872407, 4611485685633505627,
                4611466565075592697, 4611448981508937682, 4611432614002032640,
                4611417244089453490, 4611402705505332708, 4611388876450648994,
            };
            TestAsin(head, tail, Intar.Mathi.AsinP3, Intar.Mathi.AcosP3, 0.00007);
        }
        [Test]
        public static void TestAsinP7() {
            var head = new long[] {
                0,
                66571993058, 70866960322, 70866960322, 73014443939, 73014443939,
                75161927556, 75161927556, 77309411173, 79456894816, 81604378432,
                81604378432, 83751862048, 83751862048, 85899345664, 85899345664,
                88046829280, 90194312919, 92341796534, 92341796534, 94489280149,
                94489280149, 96636763764, 96636763764,
            };
            var tail = new long[] {
                4611686018427387904, 4611596423997743324, 4611559310172291072,
                4611530834842990136, 4611506827634684207, 4611485676079649427,
                4611466554609878497, 4611448970204664482, 4611432601917063168,
                4611417231271486068, 4611402691994306850, 4611388862279969994,
            };
            TestAsin(head, tail, Intar.Mathi.AsinP7, Intar.Mathi.AcosP7, 0.00000003);
        }
    }
}
