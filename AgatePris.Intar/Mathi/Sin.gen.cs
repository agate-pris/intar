using AgatePris.Intar.Numerics;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class Mathi {
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

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int CosP2(int z) {
                return z * z;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int CosP4A7032(int z) {
                const int a = 7032;
                const int b = a + Right;
                var z_2 = (z * z) >> RightExp;
                return (b - ((z_2 * a) >> RightExp)) * z_2;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int CosP4A7384(int z) {
                const int a = 7384;
                const int b = a + Right;
                var z_2 = (z * z) >> RightExp;
                return (b - ((z_2 * a) >> RightExp)) * z_2;
            }
        }

        /// <summary>
        /// 2 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathi.CosP2(x);
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
        public static int CosP2(int x) {
            var masked = x & Sin.RightMask;
            return Sin.ToQuadrant(x) switch {
                Sin.Quadrant.Second => Sin.CosP2(Sin.Right - masked) - Sin.One,
                Sin.Quadrant.Fourth => Sin.One - Sin.CosP2(Sin.Right - masked),
                Sin.Quadrant.Third => Sin.CosP2(masked) - Sin.One,
                Sin.Quadrant.First => Sin.One - Sin.CosP2(masked),
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
        /// var actual = Intar.Mathi.SinP2(x);
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
        public static int SinP2(int x) => CosP2(Overflowing.WrappingSub(x, Sin.Right));

        /// <summary>
        /// 3 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathi.SinP3_16384(x);
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
        public static int SinP3A16384(int x) {
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
        /// var actual = Intar.Mathi.CosP3_16384(x);
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
        public static int CosP3A16384(int x) => SinP3A16384(Overflowing.WrappingAdd(x, Sin.Right));

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathi.CosP4_7032(x);
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
        public static int CosP4A7032(int x) {
            var masked = x & Sin.RightMask;
            return Sin.ToQuadrant(x) switch {
                Sin.Quadrant.Second => Sin.CosP4A7032(Sin.Right - masked) - Sin.One,
                Sin.Quadrant.Fourth => Sin.One - Sin.CosP4A7032(Sin.Right - masked),
                Sin.Quadrant.Third => Sin.CosP4A7032(masked) - Sin.One,
                Sin.Quadrant.First => Sin.One - Sin.CosP4A7032(masked),
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
        /// var actual = Intar.Mathi.SinP4_7032(x);
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
        public static int SinP4A7032(int x) => CosP4A7032(Overflowing.WrappingSub(x, Sin.Right));

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 60 / 90;
        /// var actual = Intar.Mathi.CosP4_7384(x);
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
        public static int CosP4A7384(int x) {
            var masked = x & Sin.RightMask;
            return Sin.ToQuadrant(x) switch {
                Sin.Quadrant.Second => Sin.CosP4A7384(Sin.Right - masked) - Sin.One,
                Sin.Quadrant.Fourth => Sin.One - Sin.CosP4A7384(Sin.Right - masked),
                Sin.Quadrant.Third => Sin.CosP4A7384(masked) - Sin.One,
                Sin.Quadrant.First => Sin.One - Sin.CosP4A7384(masked),
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
        /// var actual = Intar.Mathi.SinP4_7384(x);
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
        public static int SinP4A7384(int x) => CosP4A7384(Overflowing.WrappingSub(x, Sin.Right));

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathi.SinP5_51472(x);
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
        public static int SinP5A51472(int x) {
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
        /// var actual = Intar.Mathi.CosP5_51472(x);
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
        public static int CosP5A51472(int x) => SinP5A51472(Overflowing.WrappingAdd(x, Sin.Right));

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// <example>
        /// <code>
        /// var x = (1 &lt;&lt; 15) * 30 / 90;
        /// var actual = Intar.Mathi.SinP5_51437(x);
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
        public static int SinP5A51437(int x) {
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
        /// var actual = Intar.Mathi.CosP5_51472(x);
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
        public static int CosP5A51437(int x) => SinP5A51437(Overflowing.WrappingAdd(x, Sin.Right));

        /// <summary>
        /// 2 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 SinP2(I17F15 x) => I2F30.FromBits(SinP2(x.Bits));

        /// <summary>
        /// 3 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 SinP3A16384(I17F15 x) => I2F30.FromBits(SinP3A16384(x.Bits));

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 SinP4A7032(I17F15 x) => I2F30.FromBits(SinP4A7032(x.Bits));

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 SinP4A7384(I17F15 x) => I2F30.FromBits(SinP4A7384(x.Bits));

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 SinP5A51472(I17F15 x) => I2F30.FromBits(SinP5A51472(x.Bits));

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 SinP5A51437(I17F15 x) => I2F30.FromBits(SinP5A51437(x.Bits));

        /// <summary>
        /// 2 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 CosP2(I17F15 x) => I2F30.FromBits(CosP2(x.Bits));

        /// <summary>
        /// 3 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 CosP3A16384(I17F15 x) => I2F30.FromBits(CosP3A16384(x.Bits));

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 CosP4A7032(I17F15 x) => I2F30.FromBits(CosP4A7032(x.Bits));

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 CosP4A7384(I17F15 x) => I2F30.FromBits(CosP4A7384(x.Bits));

        /// <summary>
        /// 5 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 CosP5A51472(I17F15 x) => I2F30.FromBits(CosP5A51472(x.Bits));

        /// <summary>
        /// 5 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 CosP5A51437(I17F15 x) => I2F30.FromBits(CosP5A51437(x.Bits));
    }
}
