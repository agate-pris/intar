using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace AgatePris.Intar.Tests.Mathi {
    public class SinTest {
        [Test]
        public static void TestConsts() {
            Assert.AreEqual(Intar.Mathi.SinInternal.P11I64A, 7244019458077122842);
            Assert.AreEqual(Intar.Mathi.SinInternal.P11I64B, 5957967184218496005);
            Assert.AreEqual(Intar.Mathi.SinInternal.P11I64C, 5880276630038185627);
            Assert.AreEqual(Intar.Mathi.SinInternal.P11I64D, 5527136674668279497);
            Assert.AreEqual(Intar.Mathi.SinInternal.P11I64E, 6054407851785858183);
            Assert.AreEqual(Intar.Mathi.SinInternal.P11I64F, 8301301681792740747);
            Assert.AreEqual(Intar.Mathi.SinInternal.P10I64A, 5689439535887298204);
            Assert.AreEqual(Intar.Mathi.SinInternal.P10I64B, 4679373698902585566);
            Assert.AreEqual(Intar.Mathi.SinInternal.P10I64C, 6157594556960820448);
            Assert.AreEqual(Intar.Mathi.SinInternal.P10I64D, 8667924621372700220);
            Assert.AreEqual(Intar.Mathi.SinInternal.P10I64E, 7200226522060996872);
            Assert.AreEqual(Intar.Mathi.SinInternal.P5I32A, 1686629713);
            Assert.AreEqual(Intar.Mathi.SinInternal.P5I32B, 1382064706);
            Assert.AreEqual(Intar.Mathi.SinInternal.P5I32C, 1250270241);
            Assert.AreEqual(Intar.Mathi.SinInternal.P4I32A, 1315933018);
            Assert.AreEqual(Intar.Mathi.SinInternal.P4I32B, 1937570784);
        }

        static void TestErrorInt(double expected, int actual, double delta) {
            const double k = 1.0 / (1 << 30);
            var error = (actual * k) - expected;
            if (Math.Abs(error) > delta) {
                Assert.AreEqual(expected, actual * k, delta);
            }
        }

        static void TestErrorLong(double expected, long actual, double delta) {
            const double k = 1.0 / (1L << 62);
            var error = (actual * k) - expected;
            if (Math.Abs(error) > delta) {
                Assert.AreEqual(expected, actual * k, delta);
            }
        }

        static void Test(int expected, int actual, int x) {
            if (expected != actual) {
                Assert.AreEqual(expected, actual, $"x: {x}");
            }
        }
        static void Test(long expected, long actual, long x) {
            if (expected != actual) {
                Assert.AreEqual(expected, actual, $"x: {x}");
            }
        }
        static void TestSinP4(int expected, int x) => Test(expected, Intar.Mathi.SinP4(x), x);
        static void TestSinP5(int expected, int x) => Test(expected, Intar.Mathi.SinP5(x), x);
        static void TestCosP4(int expected, int x) => Test(expected, Intar.Mathi.CosP4(x), x);
        static void TestCosP5(int expected, int x) => Test(expected, Intar.Mathi.CosP5(x), x);
        static void TestSinP10(long expected, long x) => Test(expected, Intar.Mathi.SinP10(x), x);
        static void TestSinP11(long expected, long x) => Test(expected, Intar.Mathi.SinP11(x), x);
        static void TestCosP10(long expected, long x) => Test(expected, Intar.Mathi.CosP10(x), x);
        static void TestCosP11(long expected, long x) => Test(expected, Intar.Mathi.CosP11(x), x);

        [Test]
        public static void TestSymmetryInt() {
            const int pi = 1 << 16;
            TestSinP4(-Intar.Mathi.SinP4(pi / 2), -pi / 2);
            TestSinP5(-Intar.Mathi.SinP5(pi / 2), -pi / 2);
            TestCosP4(-Intar.Mathi.CosP4(pi / 2), -pi / 2);
            TestCosP5(-Intar.Mathi.CosP5(pi / 2), -pi / 2);
            for (var x = 0; x < pi / 2; ++x) {
                var cos = Math.Cos(x * Math.PI / pi);
                int fx;
                fx = Intar.Mathi.CosP4(x);
                TestErrorInt(cos, fx, 0.0018);
                TestSinP4(fx, (pi / 2) - x);
                TestSinP4(fx, (pi / 2) + x);
                TestCosP4(fx, -x);
                TestSinP4(-fx, -(pi / 2) - x);
                TestSinP4(-fx, -(pi / 2) + x);
                TestCosP4(-fx, pi - x);
                TestCosP4(-fx, x - pi);
                fx = Intar.Mathi.CosP5(x);
                TestErrorInt(cos, fx, 0.0004);
                TestSinP5(fx, (pi / 2) - x);
                TestSinP5(fx, (pi / 2) + x);
                TestCosP5(fx, -x);
                TestSinP5(-fx, -(pi / 2) - x);
                TestSinP5(-fx, -(pi / 2) + x);
                TestCosP5(-fx, pi - x);
                TestCosP5(-fx, x - pi);
            }
        }

        [Test]
        public static void TestSymmetryLong() {
            const long pi = 1L << 32;
            const long step = pi / 2 / (1 << 16);
            TestSinP10(-Intar.Mathi.SinP10(pi / 2), -pi / 2);
            TestSinP11(-Intar.Mathi.SinP11(pi / 2), -pi / 2);
            TestCosP10(-Intar.Mathi.CosP10(pi / 2), -pi / 2);
            TestCosP11(-Intar.Mathi.CosP11(pi / 2), -pi / 2);
            var ofss = new long[] { 0, 1, step - 1 };
            foreach (var ofs in ofss) {
                for (var xBase = 0L; xBase < pi / 2; xBase += step) {
                    var x = xBase + ofs;
                    var cos = Math.Cos(x * Math.PI / pi);
                    long fx;
                    fx = Intar.Mathi.CosP10(x);
                    TestErrorLong(cos, fx, 0.000000004);
                    TestSinP10(fx, (pi / 2) - x);
                    TestSinP10(fx, (pi / 2) + x);
                    TestCosP10(fx, -x);
                    TestSinP10(-fx, -(pi / 2) - x);
                    TestSinP10(-fx, -(pi / 2) + x);
                    TestCosP10(-fx, pi - x);
                    TestCosP10(-fx, x - pi);
                    fx = Intar.Mathi.CosP11(x);
                    TestErrorLong(cos, fx, 0.000000004);
                    TestSinP11(fx, (pi / 2) - x);
                    TestSinP11(fx, (pi / 2) + x);
                    TestCosP11(fx, -x);
                    TestSinP11(-fx, -(pi / 2) - x);
                    TestSinP11(-fx, -(pi / 2) + x);
                    TestCosP11(-fx, pi - x);
                    TestCosP11(-fx, x - pi);
                }
            }
        }

        [Test]
        public static void TestPeriodicityInt() {
            const int pi = 1 << 16;
            var ofss = new List<int>();
            {
                var tmp = new int[] { 0, 1, (pi / 2) - 1 };
                for (var i = 0; i < 4; ++i) {
                    foreach (var v in tmp) {
                        ofss.Add((i * pi / 2) + v);
                    }
                }
            }
            foreach (var ofs in ofss) {
                var sinP4 = Intar.Mathi.SinP4(ofs);
                var sinP5 = Intar.Mathi.SinP5(ofs);
                var cosP4 = Intar.Mathi.CosP4(ofs);
                var cosP5 = Intar.Mathi.CosP5(ofs);
                for (var x = int.MinValue; x <= int.MaxValue - (2 * pi); x += 2 * pi) {
                    TestSinP4(sinP4, x + ofs);
                    TestSinP5(sinP5, x + ofs);
                    TestCosP4(cosP4, x + ofs);
                    TestCosP5(cosP5, x + ofs);
                }
            }
        }

        [Test]
        public static void TestPeriodicityLong() {
            const long pi = 1L << 32;
            var ofss = new List<long>();
            {
                var tmp = new long[] { 0, 1, (pi / 2) - 1 };
                for (var i = 0; i < 4; ++i) {
                    foreach (var v in tmp) {
                        ofss.Add((i * pi / 2) + v);
                    }
                }
            }
            foreach (var ofs in ofss) {
                var sinP10 = Intar.Mathi.SinP10(ofs);
                var sinP11 = Intar.Mathi.SinP11(ofs);
                var cosP10 = Intar.Mathi.CosP10(ofs);
                var cosP11 = Intar.Mathi.CosP11(ofs);

                const long step = 2 * pi * (1L << 16);
                for (var x = long.MinValue; x <= long.MaxValue - step; x += step) {
                    TestSinP10(sinP10, x + ofs);
                    TestSinP11(sinP11, x + ofs);
                    TestCosP10(cosP10, x + ofs);
                    TestCosP11(cosP11, x + ofs);
                }
            }
        }

        [Test]
        public static void TestP4() {
            List<int> data;
            var path = Utility.MakeUpPath("sin_p4.json");
            if (File.Exists(path)) {
                data = Utility.ReadInts(path);
                for (var i = 0; i < data.Count; ++i) {
                    TestSinP4(data[i], i);
                }
            } else {
                data = new List<int>();
                Utility.WriteInts(path, x => {
                    var v = Intar.Mathi.SinP4(x);
                    data.Add(v);
                    return v;
                }, 1 << 15);
            }
        }
        [Test]
        public static void TestP5() {
            List<int> data;
            var path = Utility.MakeUpPath("sin_p5.json");
            if (File.Exists(path)) {
                data = Utility.ReadInts(path);
                for (var i = 0; i < data.Count; ++i) {
                    TestSinP5(data[i], i);
                }
            } else {
                data = new List<int>();
                Utility.WriteInts(path, x => {
                    var v = Intar.Mathi.SinP5(x);
                    data.Add(v);
                    return v;
                }, 1 << 15);
            }
        }
        [Test]
        public static void TestLong() {
            const long one = 1L << 62;
            var sinP10 = new long[] {
                10737418240, 15032385526,
                17179869168, 21474836456,
                23622320104, 27917287394,
                30064771048, 34359738340,
                36507222000, 40802189294,
            };
            var sinP11 = new long[] {
                0,
                3373259426,
                6746518852,
                10119778278,
                13493037704,
                16866297130,
                20239556556,
                23612815982,
                26986075408,
                30359334834,
            };
            var cosP11 = new long[] {
                4611686007689969664, 4611686007689969668,
                4611686007689969670, 4611686007689969670,
                4611686007689969668, 4611686005542486021,
                4611686005542486016, 4611686007689969650,
                4611686007689969640, 4611686007689969628,
            };
            for (var x = 0; x < 10; ++x) {
                Console.WriteLine(Intar.Mathi.SinP10(x));
            }
            for (var x = 0; x < 10; ++x) {
                Console.WriteLine(Intar.Mathi.SinP11(x));
            }
            for (var x = 0; x < 10; ++x) {
                Console.WriteLine(Intar.Mathi.CosP11(x));
            }
            for (var x = 0; x < 10; ++x) {
                TestSinP10(sinP10[x], x);
                TestSinP11(sinP11[x], x);
                TestCosP10(one, x);
                TestCosP11(cosP11[x], x);
            }
        }
    }
}
