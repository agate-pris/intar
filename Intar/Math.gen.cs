using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class Math {

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> や
        /// <c>Intar.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// この関数は .NET 5 または .NET Standard 2.1 以降の場合 <c>System.Math.Clamp</c> を呼ぶ.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Clamp(int v, int min, int max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> や
        /// <c>Intar.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// この関数は .NET 5 または .NET Standard 2.1 以降の場合 <c>System.Math.Clamp</c> を呼ぶ.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Clamp(uint v, uint min, uint max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> や
        /// <c>Intar.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// この関数は .NET 5 または .NET Standard 2.1 以降の場合 <c>System.Math.Clamp</c> を呼ぶ.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Clamp(long v, long min, long max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> や
        /// <c>Intar.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// この関数は .NET 5 または .NET Standard 2.1 以降の場合 <c>System.Math.Clamp</c> を呼ぶ.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Clamp(ulong v, ulong min, ulong max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> や
        /// <c>Intar.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// この関数は .NET 5 または .NET Standard 2.1 以降の場合 <c>System.Math.Clamp</c> を呼ぶ.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Clamp(short v, short min, short max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> や
        /// <c>Intar.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// この関数は .NET 5 または .NET Standard 2.1 以降の場合 <c>System.Math.Clamp</c> を呼ぶ.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Clamp(ushort v, ushort min, ushort max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> や
        /// <c>Intar.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// この関数は .NET 5 または .NET Standard 2.1 以降の場合 <c>System.Math.Clamp</c> を呼ぶ.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Clamp(byte v, byte min, byte max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> や
        /// <c>Intar.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// この関数は .NET 5 または .NET Standard 2.1 以降の場合 <c>System.Math.Clamp</c> を呼ぶ.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Clamp(sbyte v, sbyte min, sbyte max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> や
        /// <c>Intar.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// この関数は .NET 5 または .NET Standard 2.1 以降の場合 <c>System.Math.Clamp</c> を呼ぶ.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp(float v, float min, float max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> や
        /// <c>Intar.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// この関数は .NET 5 または .NET Standard 2.1 以降の場合 <c>System.Math.Clamp</c> を呼ぶ.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp(double v, double min, double max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        /// <summary>
        /// この関数は <c>Unity.Mathematics.math.clamp</c> や
        /// <c>Intar.Mathematics.math.clamp</c> と異なり,
        /// <c>min</c> が <c>max</c> より大きい場合, 例外を送出する.
        /// この関数は .NET 5 または .NET Standard 2.1 以降の場合 <c>System.Math.Clamp</c> を呼ぶ.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal Clamp(decimal v, decimal min, decimal max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>int.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(int v) => int.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>uint.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(uint v) => uint.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>long.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(long v) => long.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>ulong.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(ulong v) => ulong.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>short.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(short v) => short.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>ushort.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(ushort v) => ushort.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>byte.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(byte v) => byte.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>sbyte.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(sbyte v) => sbyte.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>float.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(float v) => float.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>double.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(double v) => double.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>decimal.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(decimal v) => decimal.Sign(v);

#else

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>int.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(int v) => System.Math.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>long.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(long v) => System.Math.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>short.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(short v) => System.Math.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>sbyte.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(sbyte v) => System.Math.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>float.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(float v) => System.Math.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>double.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(double v) => System.Math.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>decimal.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(decimal v) => System.Math.Sign(v);

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>uint.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(uint v) => (v == 0) ? 0 : 1;

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>ulong.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(ulong v) => (v == 0) ? 0 : 1;

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>ushort.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(ushort v) => (v == 0) ? 0 : 1;

        /// <summary>
        /// この関数は .NET 7.0 以降の場合 <c>byte.Sign</c> を呼ぶ.
        /// .NET 6.0 以前の場合, 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(byte v) => (v == 0) ? 0 : 1;

#endif

    }
}
