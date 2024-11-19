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
