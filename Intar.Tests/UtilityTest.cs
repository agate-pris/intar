using NUnit.Framework;

namespace Intar.Tests {
    public class UtilityTest {
        [Test]
        public static void Test() {
            for (var n1 = 1; n1 < 9; n1++) {
                var n2 = -n1;
                for (var r1 = 0; r1 < n1; r1++) {
                    var a1 = r1 + n1;
                    var a2 = -a1;
                    var r2 = r1 == 0 ? 0 : n1 - r1;
                    var r3 = -r1;
                    var r4 = -r2;
                    Utility.AssertAreEqual(r1, Intar.Utility.TruncatedRem(a1, n1));
                    Utility.AssertAreEqual(r1, Intar.Utility.TruncatedRem(a1, n2));
                    Utility.AssertAreEqual(r3, Intar.Utility.TruncatedRem(a2, n1));
                    Utility.AssertAreEqual(r3, Intar.Utility.TruncatedRem(a2, n2));
                    Utility.AssertAreEqual(r1, Intar.Utility.FlooredRem(a1, n1));
                    Utility.AssertAreEqual(r4, Intar.Utility.FlooredRem(a1, n2));
                    Utility.AssertAreEqual(r2, Intar.Utility.FlooredRem(a2, n1));
                    Utility.AssertAreEqual(r3, Intar.Utility.FlooredRem(a2, n2));
                    Utility.AssertAreEqual(r1, Intar.Utility.EuclideanRem(a1, n1));
                    Utility.AssertAreEqual(r1, Intar.Utility.EuclideanRem(a1, n2));
                    Utility.AssertAreEqual(r2, Intar.Utility.EuclideanRem(a2, n1));
                    Utility.AssertAreEqual(r2, Intar.Utility.EuclideanRem(a2, n2));
                }
            }
        }
    }
}
