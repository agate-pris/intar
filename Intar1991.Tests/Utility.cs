using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

using NUnit.Framework;

namespace Intar1991.Tests {
    public class Utility {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AssertAreEqual(int expected, int actual) {
            if (expected != actual) {
                Assert.AreEqual(expected, actual);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AssertAreEqual(int expected, int actual, int x) {
            if (expected != actual) {
                Assert.AreEqual(expected, actual, $"x: {x}");
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AssertAreEqual(long expected, long actual) {
            if (expected != actual) {
                Assert.AreEqual(expected, actual);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AssertAreEqual(long expected, long actual, long x) {
            if (expected != actual) {
                Assert.AreEqual(expected, actual, $"x: {x}");
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AssertAreEqual(uint expected, uint actual) {
            if (expected != actual) {
                Assert.AreEqual(expected, actual);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AssertAreEqual(ulong expected, ulong actual) {
            if (expected != actual) {
                Assert.AreEqual(expected, actual);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AssertAreEqual(double expected, double actual, double delta) {
            if (Math.Abs(expected - actual) > delta) {
                Assert.AreEqual(expected, actual, delta);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AssertAreEqual(double expected, double actual, double delta, int x) {
            if (Math.Abs(expected - actual) > delta) {
                Assert.AreEqual(expected, actual, delta, $"x: {x}");
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AssertAreEqual(double expected, double actual, double delta, long x) {
            if (Math.Abs(expected - actual) > delta) {
                Assert.AreEqual(expected, actual, delta, $"x: {x}");
            }
        }

        internal static string MakeUpPath(string path) {
#if UNITY_5_6_OR_NEWER
            return Path.GetFullPath(
                Path.Combine(
                    "Packages/dev.agate-pris.intar/.data",
                    path
                )
            );
#else
            return Path.Combine(
                Environment.GetEnvironmentVariable("Data"),
                path
            );
#endif
        }

        internal static List<int> ReadInts(string path) {
            var ints = new List<int>();
            foreach (var line in File.ReadLines(path)) {
                foreach (var s in line.Split(',')) {
                    if (int.TryParse(s, out var v)) {
                        ints.Add(v);
                    }
                }
            }
            return ints;
        }
        internal static void WriteInts(string path, List<int> ints) {
            var file = File.CreateText(path);
            file.WriteLine("[");
            var last = ints.Count - 1;
            for (var i = 0; i < last; ++i) {
                file.WriteLine($"{ints[i]},");
            }
            if (0 <= last) {
                file.WriteLine($"{ints[last]}");
            }
            file.WriteLine("]");
            file.Close();
        }
        internal static void WriteInts(string path, Func<int, int> a, int first, int last) {
            var file = File.CreateText(path);
            file.WriteLine("[");
            for (var v = first; v < last; ++v) {
                file.WriteLine($"{a(v)},");
            }
            if (first <= last) {
                file.WriteLine($"{a(last)}");
            }
            file.WriteLine("]");
            file.Close();
        }
        internal static void WriteInts(string path, Func<int, int> a, int last) {
            WriteInts(path, a, 0, last);
        }

        public class ErrorAccumulation {
            int count;
            double sqrSum;
            double absSum;
            double sum;
            double maxError;

            public void Add(double error) {
                ++count;
                sqrSum += error * error;
                absSum += Math.Abs(error);
                sum += error;
                maxError = Math.Max(maxError, error);
            }
            public void Concat(ErrorAccumulation acc) {
                count += acc.count;
                sqrSum += acc.sqrSum;
                absSum += acc.absSum;
                sum += acc.sum;
                maxError = Math.Max(maxError, acc.maxError);
            }
            public void Print() {
                Console.WriteLine(
                    $"count: {count}, " +
                    $"RMSE: {Math.Sqrt(sqrSum / count)}, " +
                    $"MAE: {absSum / count}, " +
                    $"Max Error: {maxError}"
                );
            }
        }
    }
}
