using NUnit.Framework;
using System;
using System.IO;

namespace AgatePris.Intar.Tests.Mathi {
    public class AsinTest {
        [TestCase("asin.json")]
        public static void TestAsin(string path) {
            Assert.Zero(Math.Asin(0));
            Assert.Zero(Intar.Mathi.Asin(0));

            const int end = 1 << 15;

            path = Utility.MakeUpPath(path);
            if (File.Exists(path)) {
                var data = Utility.ReadInts(path);
                Assert.Zero(data[0]);
                if (end * end != data[end]) {
                    Assert.Fail();
                }

                var max = 0.0;
                for (var x = 1; x <= end; ++x) {
                    const double epsilon = 2e-4;
                    const double toSin = 1 / (double)end;
                    const double toSinNeg = -toSin;
                    const double toAsin = Math.PI / (1L << 31);
                    {
                        var actual = Intar.Mathi.Asin(x);
                        if (data[x] != actual) {
                            Assert.Fail();
                        }
                        var expected = Math.Asin(toSin * x);
                        var a = toAsin * actual;
                        Assert.AreEqual(expected, a, epsilon);
                        max = Math.Max(max, Math.Abs(a - expected));
                    }
                    {
                        var actual = Intar.Mathi.Asin(-x);
                        if (-data[x] != actual) {
                            Assert.Fail();
                        }
                        var expected = Math.Asin(toSinNeg * x);
                        var a = toAsin * actual;
                        Assert.AreEqual(expected, a, epsilon);
                        max = Math.Max(max, Math.Abs(a - expected));
                    }
                }
                Console.WriteLine($"max error: {max}");
            } else {
                Utility.WriteInts(path, Intar.Mathi.Asin, end);
            }
        }

        [TestCase("asin.json")]
        public static void TestAcos(string path) {
            Assert.Zero(Math.Acos(1));
            Assert.Zero(Intar.Mathi.Acos(1 << 15));

            path = Utility.MakeUpPath(path);
            if (!File.Exists(path)) {
                return;
            }
            var data = Utility.ReadInts(path);

            const int end = 1 << 15;
            Assert.Zero(data[0]);
            if (end * end != data[end]) {
                Assert.Fail();
            }

            const double epsilon = 2e-4;
            const double toSin = 1 / (double)end;
            const double toAsin = Math.PI / (1L << 31);
            var max = 0.0;
            for (var x = -32768; x < 0; ++x) {
                var actual = Intar.Mathi.Acos(x);
                if ((1 << 30) + (uint)data[-x] != actual) {
                    Assert.Fail();
                }
                var expected = Math.Acos(toSin * x);
                var a = toAsin * actual;
                Assert.AreEqual(expected, a, epsilon);
                max = Math.Max(max, Math.Abs(a - expected));
            }
            for (var x = 0; x < 32768; ++x) {
                var actual = Intar.Mathi.Acos(x);
                if ((1 << 30) - (uint)data[x] != actual) {
                    Assert.Fail();
                }
                var expected = Math.Acos(toSin * x);
                var a = toAsin * actual;
                Assert.AreEqual(expected, a, epsilon);
                max = Math.Max(max, Math.Abs(a - expected));
            }
            Console.WriteLine($"max error: {max}");
        }
    }
}
