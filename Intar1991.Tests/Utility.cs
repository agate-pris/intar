using System;
using System.Runtime.CompilerServices;

using Intar1991.Rand;
using NUnit.Framework;

namespace Intar1991.Tests {
    public class Utility {
        #region Log, LogError
        public static void Log(string message) {
#if UNITY_5_3_OR_NEWER
            UnityEngine.Debug.Log(message);
#else
            Console.WriteLine(message);
#endif
        }
        public static void LogError(string s) {
#if UNITY_5_3_OR_NEWER
            UnityEngine.Debug.LogError(s);
#else
            Assert.Warn(s);
#endif
        }
        #endregion
        #region AssertAreEqual
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
        #endregion
        #region RandomInt, RandomPosition, RandomAxis, RandomI17F15, Random01I17F15, Random01Single
        /// <summary>
        /// <c>float</c> で正確に表現可能な <c>int</c> の乱数を返す
        /// </summary>
        /// <param name="rng"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RandomInt(ref Xoroshiro128StarStar rng) {
            const int k = 1 << 23;
            return rng.Next(-k, k + 1);
        }

        /// <summary>
        /// <c>float</c> で正確に表現可能な乱数の座標を返す
        /// </summary>
        /// <param name="rng"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 RandomPosition(ref Xoroshiro128StarStar rng) {
            return new Vector3I17F15(
                I17F15.FromBits(RandomInt(ref rng)),
                I17F15.FromBits(RandomInt(ref rng)),
                I17F15.FromBits(RandomInt(ref rng))
            );
        }

        public static Vector3I2F30 RandomAxis(ref Xoroshiro128StarStar rng) {
            Vector3I2F30? v;
            do {
                v = new Vector3I2F30(new Vector3Int32(
                    RandomInt(ref rng),
                    RandomInt(ref rng),
                    RandomInt(ref rng)
                )).Normalize();
            } while (v == null);
            return v.Value;
        }
        public static I17F15 RandomI17F15(ref Xoroshiro128StarStar rng) {
            return I17F15.FromBits(RandomInt(ref rng));
        }
        public static I17F15 Random01I17F15(ref Xoroshiro128StarStar rng) {
            const int k = 1 << 15;
            return I17F15.FromBits(rng.Next(0, k + 1));
        }
        public static float Random01Single(ref Xoroshiro128StarStar rng) {
            const int k = 1 << 23;
            return (float)rng.Next(0, k + 1) / k;
        }
        #endregion
        #region Delta
        public static double Delta(System.Numerics.Vector3 v, Vector3I17F15 a) {
            var x = Math.Abs(a.X.ToDouble() - v.X);
            var y = Math.Abs(a.Y.ToDouble() - v.Y);
            var z = Math.Abs(a.Z.ToDouble() - v.Z);
            return Math.Max(Math.Max(x, y), z);
        }

#if UNITY_5_3_OR_NEWER
        public static double Delta(UnityEngine.Vector3 v, Vector3I17F15 a) {
            var x = Math.Abs(a.X.ToDouble() - v.x);
            var y = Math.Abs(a.Y.ToDouble() - v.y);
            var z = Math.Abs(a.Z.ToDouble() - v.z);
            return Math.Max(Math.Max(x, y), z);
        }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
        public static double Delta(Unity.Mathematics.float3 v, Vector3I17F15 a) {
            var x = Math.Abs(a.X.ToDouble() - v.x);
            var y = Math.Abs(a.Y.ToDouble() - v.y);
            var z = Math.Abs(a.Z.ToDouble() - v.z);
            return Math.Max(Math.Max(x, y), z);
        }
#endif // UNITY_2018_1_OR_NEWER
        #endregion

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
