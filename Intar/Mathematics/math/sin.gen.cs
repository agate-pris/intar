using AgatePris.Intar.Fixed;
using AgatePris.Intar.Integer;
using System.Runtime.CompilerServices;

#if UNITY_2018_3_OR_NEWER
using Unity.Mathematics;
using static Unity.Mathematics.math;
#endif

namespace AgatePris.Intar.Mathematics {
    public static partial class math {
        internal sealed class Sin {
            internal const int RightExp = (8 * sizeof(int) / 2) - 1;
            internal const int Right = 1 << RightExp;
            internal const int RightMask = Right - 1;
            internal const int One = Right * Right;

            internal enum Quadrant : byte {
                First,
                Second,
                Third,
                Fourth,
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static Quadrant ToQuadrant(int x) => (Quadrant)((x >> RightExp) & 3);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int MakeArgOdd(int x) {
                var masked = x & RightMask;
                var z = ToQuadrant(x) switch {
                    Quadrant.Second => Right - masked,
                    Quadrant.Fourth => masked - Right,
                    Quadrant.Third => -masked,
                    Quadrant.First => masked,
                    _ => throw new System.NotImplementedException(),
                };
                return z;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int cos_p2_detail(int z) {
            return z * z;
        }

        /// <summary>
        /// 2 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathematics.Math.CosP2(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.056010);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cos_p2(int x) {
            var masked = x & Sin.RightMask;
            return Sin.ToQuadrant(x) switch {
                Sin.Quadrant.Second => cos_p2_detail(Sin.Right - masked) - Sin.One,
                Sin.Quadrant.Fourth => Sin.One - cos_p2_detail(Sin.Right - masked),
                Sin.Quadrant.Third => cos_p2_detail(masked) - Sin.One,
                Sin.Quadrant.First => Sin.One - cos_p2_detail(masked),
#if NET7_0_OR_GREATER
                _ => throw new System.Diagnostics.UnreachableException(),
#else
                _ => throw new System.NotImplementedException(),
#endif
            };
        }

        /// <summary>
        /// 2 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathematics.Math.SinP2(x);
        /// var rad = System.Math.PI / 6;
        /// var expected = System.Math.Sin(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.056010);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int sin_p2(int x) => cos_p2(x.WrappingSub(Sin.Right));

        /// <summary>
        /// 3 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathematics.Math.SinP3_16384(x);
        /// var rad = System.Math.PI / 6;
        /// var expected = System.Math.Sin(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.020017);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int sin_p3_16384(int x) {
            const int b = Sin.Right / 2;
            const int a = Sin.Right + b;
            var z = Sin.MakeArgOdd(x);
            var z_2 = (z * z) >> Sin.RightExp;
            return (a - ((z_2 * b) >> Sin.RightExp)) * z;
        }

        /// <summary>
        /// 3 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathematics.Math.CosP3_16384(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.020017);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cos_p3_16384(int x) => sin_p3_16384(x.WrappingAdd(Sin.Right));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int cos_p4_7032_detail(int z) {
            const int b = 7032;
            const int a = b + Sin.Right;
            var z_2 = (z * z) >> Sin.RightExp;
            return (a - ((z_2 * b) >> Sin.RightExp)) * z_2;
        }

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathematics.Math.CosP4_7032(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.002819);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cos_p4_7032(int x) {
            var masked = x & Sin.RightMask;
            return Sin.ToQuadrant(x) switch {
                Sin.Quadrant.Second => cos_p4_7032_detail(Sin.Right - masked) - Sin.One,
                Sin.Quadrant.Fourth => Sin.One - cos_p4_7032_detail(Sin.Right - masked),
                Sin.Quadrant.Third => cos_p4_7032_detail(masked) - Sin.One,
                Sin.Quadrant.First => Sin.One - cos_p4_7032_detail(masked),
#if NET7_0_OR_GREATER
                _ => throw new System.Diagnostics.UnreachableException(),
#else
                _ => throw new System.NotImplementedException(),
#endif
            };
        }

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathematics.Math.SinP4_7032(x);
        /// var rad = System.Math.PI / 6;
        /// var expected = System.Math.Sin(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.002819);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int sin_p4_7032(int x) => cos_p4_7032(x.WrappingSub(Sin.Right));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int cos_p4_7384_detail(int z) {
            const int b = 7384;
            const int a = b + Sin.Right;
            var z_2 = (z * z) >> Sin.RightExp;
            return (a - ((z_2 * b) >> Sin.RightExp)) * z_2;
        }

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathematics.Math.CosP4_7384(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.001174);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cos_p4_7384(int x) {
            var masked = x & Sin.RightMask;
            return Sin.ToQuadrant(x) switch {
                Sin.Quadrant.Second => cos_p4_7384_detail(Sin.Right - masked) - Sin.One,
                Sin.Quadrant.Fourth => Sin.One - cos_p4_7384_detail(Sin.Right - masked),
                Sin.Quadrant.Third => cos_p4_7384_detail(masked) - Sin.One,
                Sin.Quadrant.First => Sin.One - cos_p4_7384_detail(masked),
#if NET7_0_OR_GREATER
                _ => throw new System.Diagnostics.UnreachableException(),
#else
                _ => throw new System.NotImplementedException(),
#endif
            };
        }

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathematics.Math.SinP4_7384(x);
        /// var rad = System.Math.PI / 6;
        /// var expected = System.Math.Sin(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.001174);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int sin_p4_7384(int x) => cos_p4_7384(x.WrappingSub(Sin.Right));

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathematics.Math.SinP5_51472(x);
        /// var rad = System.Math.PI / 6;
        /// var expected = System.Math.Sin(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.000425);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int sin_p5_51472(int x) {
            const int k = 51472;
            const int a = (k * 2) - (Sin.Right * 5 / 2);
            const int b = k - (Sin.Right * 3 / 2);
            var z = Sin.MakeArgOdd(x);
            var z_2 = (z * z) >> Sin.RightExp;
            return (k - (((a - ((z_2 * b) >> Sin.RightExp)) * z_2) >> Sin.RightExp)) * z;
        }

        /// <summary>
        /// 5 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathematics.Math.CosP5_51472(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.000425);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cos_p5_51472(int x) => sin_p5_51472(x.WrappingAdd(Sin.Right));

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathematics.Math.SinP5_51437(x);
        /// var rad = System.Math.PI / 6;
        /// var expected = System.Math.Sin(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.000226);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int sin_p5_51437(int x) {
            const int k = 51437;
            const int a = (k * 2) - (Sin.Right * 5 / 2);
            const int b = k - (Sin.Right * 3 / 2);
            var z = Sin.MakeArgOdd(x);
            var z_2 = (z * z) >> Sin.RightExp;
            return (k - (((a - ((z_2 * b) >> Sin.RightExp)) * z_2) >> Sin.RightExp)) * z;
        }

        /// <summary>
        /// 5 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathematics.Math.CosP5_51472(x);
        /// var rad = System.Math.PI / 3;
        /// var expected = System.Math.Cos(rad);
        /// var a = actual / (float)(1 &lt;&lt; 30);
        /// Assert.AreEqual(expected, a, 0.000226);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="x">2 の 15 乗を直角とする角度</param>
        /// <returns>2 の 30 乗を 1 とする余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cos_p5_51437(int x) => sin_p5_51437(x.WrappingAdd(Sin.Right));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos_p2(int x, out int s, out int c) {
            s = sin_p2(x);
            c = cos_p2(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos_p3_16384(int x, out int s, out int c) {
            s = sin_p3_16384(x);
            c = cos_p3_16384(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos_p4_7032(int x, out int s, out int c) {
            s = sin_p4_7032(x);
            c = cos_p4_7032(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos_p4_7384(int x, out int s, out int c) {
            s = sin_p4_7384(x);
            c = cos_p4_7384(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos_p5_51472(int x, out int s, out int c) {
            s = sin_p5_51472(x);
            c = cos_p5_51472(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos_p5_51437(int x, out int s, out int c) {
            s = sin_p5_51437(x);
            c = cos_p5_51437(x);
        }

        /// <summary>
        /// 2 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 sin_p2(I17F15 x) => I2F30.FromBits(sin_p2(x.Bits));

        /// <summary>
        /// 3 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 sin_p3_16384(I17F15 x) => I2F30.FromBits(sin_p3_16384(x.Bits));

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 sin_p4_7032(I17F15 x) => I2F30.FromBits(sin_p4_7032(x.Bits));

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 sin_p4_7384(I17F15 x) => I2F30.FromBits(sin_p4_7384(x.Bits));

        /// <summary>
        /// 5 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 cos_p5_51472(I17F15 x) => I2F30.FromBits(cos_p5_51472(x.Bits));

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 sin_p5_51437(I17F15 x) => I2F30.FromBits(sin_p5_51437(x.Bits));

        /// <summary>
        /// 2 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 cos_p2(I17F15 x) => I2F30.FromBits(cos_p2(x.Bits));

        /// <summary>
        /// 3 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 cos_p3_16384(I17F15 x) => I2F30.FromBits(cos_p3_16384(x.Bits));

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 cos_p4_7032(I17F15 x) => I2F30.FromBits(cos_p4_7032(x.Bits));

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 cos_p4_7384(I17F15 x) => I2F30.FromBits(cos_p4_7384(x.Bits));

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 sin_p5_51472(I17F15 x) => I2F30.FromBits(sin_p5_51472(x.Bits));

        /// <summary>
        /// 5 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 cos_p5_51437(I17F15 x) => I2F30.FromBits(cos_p5_51437(x.Bits));

        public static int2 sin_p2(int2 x) => int2(
            sin_p2(x.x),
            sin_p2(x.y));

        public static int3 sin_p2(int3 x) => int3(
            sin_p2(x.x),
            sin_p2(x.y),
            sin_p2(x.z));

        public static int4 sin_p2(int4 x) => int4(
            sin_p2(x.x),
            sin_p2(x.y),
            sin_p2(x.z),
            sin_p2(x.w));

        public static int2 sin_p3_16384(int2 x) => int2(
            sin_p3_16384(x.x),
            sin_p3_16384(x.y));

        public static int3 sin_p3_16384(int3 x) => int3(
            sin_p3_16384(x.x),
            sin_p3_16384(x.y),
            sin_p3_16384(x.z));

        public static int4 sin_p3_16384(int4 x) => int4(
            sin_p3_16384(x.x),
            sin_p3_16384(x.y),
            sin_p3_16384(x.z),
            sin_p3_16384(x.w));

        public static int2 sin_p4_7032(int2 x) => int2(
            sin_p4_7032(x.x),
            sin_p4_7032(x.y));

        public static int3 sin_p4_7032(int3 x) => int3(
            sin_p4_7032(x.x),
            sin_p4_7032(x.y),
            sin_p4_7032(x.z));

        public static int4 sin_p4_7032(int4 x) => int4(
            sin_p4_7032(x.x),
            sin_p4_7032(x.y),
            sin_p4_7032(x.z),
            sin_p4_7032(x.w));

        public static int2 sin_p4_7384(int2 x) => int2(
            sin_p4_7384(x.x),
            sin_p4_7384(x.y));

        public static int3 sin_p4_7384(int3 x) => int3(
            sin_p4_7384(x.x),
            sin_p4_7384(x.y),
            sin_p4_7384(x.z));

        public static int4 sin_p4_7384(int4 x) => int4(
            sin_p4_7384(x.x),
            sin_p4_7384(x.y),
            sin_p4_7384(x.z),
            sin_p4_7384(x.w));

        public static int2 sin_p5_51472(int2 x) => int2(
            sin_p5_51472(x.x),
            sin_p5_51472(x.y));

        public static int3 sin_p5_51472(int3 x) => int3(
            sin_p5_51472(x.x),
            sin_p5_51472(x.y),
            sin_p5_51472(x.z));

        public static int4 sin_p5_51472(int4 x) => int4(
            sin_p5_51472(x.x),
            sin_p5_51472(x.y),
            sin_p5_51472(x.z),
            sin_p5_51472(x.w));

        public static int2 sin_p5_51437(int2 x) => int2(
            sin_p5_51437(x.x),
            sin_p5_51437(x.y));

        public static int3 sin_p5_51437(int3 x) => int3(
            sin_p5_51437(x.x),
            sin_p5_51437(x.y),
            sin_p5_51437(x.z));

        public static int4 sin_p5_51437(int4 x) => int4(
            sin_p5_51437(x.x),
            sin_p5_51437(x.y),
            sin_p5_51437(x.z),
            sin_p5_51437(x.w));

        public static int2 cos_p2(int2 x) => int2(
            cos_p2(x.x),
            cos_p2(x.y));

        public static int3 cos_p2(int3 x) => int3(
            cos_p2(x.x),
            cos_p2(x.y),
            cos_p2(x.z));

        public static int4 cos_p2(int4 x) => int4(
            cos_p2(x.x),
            cos_p2(x.y),
            cos_p2(x.z),
            cos_p2(x.w));

        public static int2 cos_p3_16384(int2 x) => int2(
            cos_p3_16384(x.x),
            cos_p3_16384(x.y));

        public static int3 cos_p3_16384(int3 x) => int3(
            cos_p3_16384(x.x),
            cos_p3_16384(x.y),
            cos_p3_16384(x.z));

        public static int4 cos_p3_16384(int4 x) => int4(
            cos_p3_16384(x.x),
            cos_p3_16384(x.y),
            cos_p3_16384(x.z),
            cos_p3_16384(x.w));

        public static int2 cos_p4_7032(int2 x) => int2(
            cos_p4_7032(x.x),
            cos_p4_7032(x.y));

        public static int3 cos_p4_7032(int3 x) => int3(
            cos_p4_7032(x.x),
            cos_p4_7032(x.y),
            cos_p4_7032(x.z));

        public static int4 cos_p4_7032(int4 x) => int4(
            cos_p4_7032(x.x),
            cos_p4_7032(x.y),
            cos_p4_7032(x.z),
            cos_p4_7032(x.w));

        public static int2 cos_p4_7384(int2 x) => int2(
            cos_p4_7384(x.x),
            cos_p4_7384(x.y));

        public static int3 cos_p4_7384(int3 x) => int3(
            cos_p4_7384(x.x),
            cos_p4_7384(x.y),
            cos_p4_7384(x.z));

        public static int4 cos_p4_7384(int4 x) => int4(
            cos_p4_7384(x.x),
            cos_p4_7384(x.y),
            cos_p4_7384(x.z),
            cos_p4_7384(x.w));

        public static int2 cos_p5_51472(int2 x) => int2(
            cos_p5_51472(x.x),
            cos_p5_51472(x.y));

        public static int3 cos_p5_51472(int3 x) => int3(
            cos_p5_51472(x.x),
            cos_p5_51472(x.y),
            cos_p5_51472(x.z));

        public static int4 cos_p5_51472(int4 x) => int4(
            cos_p5_51472(x.x),
            cos_p5_51472(x.y),
            cos_p5_51472(x.z),
            cos_p5_51472(x.w));

        public static int2 cos_p5_51437(int2 x) => int2(
            cos_p5_51437(x.x),
            cos_p5_51437(x.y));

        public static int3 cos_p5_51437(int3 x) => int3(
            cos_p5_51437(x.x),
            cos_p5_51437(x.y),
            cos_p5_51437(x.z));

        public static int4 cos_p5_51437(int4 x) => int4(
            cos_p5_51437(x.x),
            cos_p5_51437(x.y),
            cos_p5_51437(x.z),
            cos_p5_51437(x.w));
    }
}