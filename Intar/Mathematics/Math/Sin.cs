using AgatePris.Intar.Integer;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    public static partial class Math {
        const int sinRightExp = 8 * sizeof(int) / 2 - 1;
        const int sinRight = 1 << sinRightExp;
        const int sinRightMask = sinRight - 1;
        const int sinOne = sinRight * sinRight;

        enum SinQuadrant : byte {
            First,
            Second,
            Third,
            Fourth,
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static SinQuadrant ToSinQuadrant(int x) => (SinQuadrant)((x >> sinRightExp) & 3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int MakeSinArgOdd(int x) {
            var masked = x & sinRightMask;
            var z = ToSinQuadrant(x) switch {
                SinQuadrant.Second => sinRight - masked,
                SinQuadrant.Fourth => masked - sinRight,
                SinQuadrant.Third => -masked,
                SinQuadrant.First => masked,
                _ => throw new System.NotImplementedException(),
            };
            return z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int CosP2Detail(int z) {
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
        public static int CosP2(int x) {
            var masked = x & sinRightMask;
            return ToSinQuadrant(x) switch {
                SinQuadrant.Second => CosP2Detail(sinRight - masked) - sinOne,
                SinQuadrant.Fourth => sinOne - CosP2Detail(sinRight - masked),
                SinQuadrant.Third => CosP2Detail(masked) - sinOne,
                SinQuadrant.First => sinOne - CosP2Detail(masked),
                _ => throw new System.Exception("Unreachable"),
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
        public static int SinP2(int x) => CosP2(x.WrappingSub(sinRight));

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
        public static int SinP3_16384(int x) {
            const int b = sinRight / 2;
            const int a = sinRight + b;
            var z = MakeSinArgOdd(x);
            var z_2 = (z * z) >> sinRightExp;
            return (a - ((z_2 * b) >> sinRightExp)) * z;
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
        public static int CosP3_16384(int x) => SinP3_16384(x.WrappingAdd(sinRight));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int CosP4_7032Detail(int z) {
            const int b = 7032;
            const int a = b + sinRight;
            var z_2 = (z * z) >> sinRightExp;
            return (a - ((z_2 * b) >> sinRightExp)) * z_2;
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
        public static int CosP4_7032(int x) {
            var masked = x & sinRightMask;
            return ToSinQuadrant(x) switch {
                SinQuadrant.Second => CosP4_7032Detail(sinRight - masked) - sinOne,
                SinQuadrant.Fourth => sinOne - CosP4_7032Detail(sinRight - masked),
                SinQuadrant.Third => CosP4_7032Detail(masked) - sinOne,
                SinQuadrant.First => sinOne - CosP4_7032Detail(masked),
                _ => throw new System.Exception("Unreachable"),
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
        public static int SinP4_7032(int x) => CosP4_7032(x.WrappingSub(sinRight));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int CosP4_7384Detail(int z) {
            const int b = 7384;
            const int a = b + sinRight;
            var z_2 = (z * z) >> sinRightExp;
            return (a - ((z_2 * b) >> sinRightExp)) * z_2;
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
        public static int CosP4_7384(int x) {
            var masked = x & sinRightMask;
            return ToSinQuadrant(x) switch {
                SinQuadrant.Second => CosP4_7384Detail(sinRight - masked) - sinOne,
                SinQuadrant.Fourth => sinOne - CosP4_7384Detail(sinRight - masked),
                SinQuadrant.Third => CosP4_7384Detail(masked) - sinOne,
                SinQuadrant.First => sinOne - CosP4_7384Detail(masked),
                _ => throw new System.Exception("Unreachable"),
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
        public static int SinP4_7384(int x) => CosP4_7384(x.WrappingSub(sinRight));

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
        public static int SinP5_51472(int x) {
            const int k = 51472;
            const int a = k * 2 - sinRight * 5 / 2;
            const int b = k - sinRight * 3 / 2;
            var z = MakeSinArgOdd(x);
            var z_2 = (z * z) >> sinRightExp;
            return (k - ((a - ((z_2 * b) >> sinRightExp)) * z_2 >> sinRightExp)) * z;
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
        public static int CosP5_51472(int x) => SinP5_51472(x.WrappingAdd(sinRight));

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
        public static int SinP5_51437(int x) {
            const int k = 51437;
            const int a = k * 2 - sinRight * 5 / 2;
            const int b = k - sinRight * 3 / 2;
            var z = MakeSinArgOdd(x);
            var z_2 = (z * z) >> sinRightExp;
            return (k - ((a - ((z_2 * b) >> sinRightExp)) * z_2 >> sinRightExp)) * z;
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
        public static int CosP5_51437(int x) => SinP5_51437(x.WrappingAdd(sinRight));
    }
}
