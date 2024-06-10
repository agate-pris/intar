using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class Math {

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsZero(this int v) => v == 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsZero(this uint v) => v == 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsZero(this long v) => v == 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsZero(this ulong v) => v == 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsZero(this short v) => v == 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsZero(this ushort v) => v == 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsZero(this byte v) => v == 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsZero(this sbyte v) => v == 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsZero(this float v) => v == 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsZero(this double v) => v == 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsZero(this decimal v) => v == 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeExclusive(this int v) => v < 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeExclusive(this uint v) => v < 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeExclusive(this long v) => v < 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeExclusive(this ulong v) => v < 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeExclusive(this short v) => v < 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeExclusive(this ushort v) => v < 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeExclusive(this byte v) => v < 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeExclusive(this sbyte v) => v < 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeExclusive(this float v) => v < 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeExclusive(this double v) => v < 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeExclusive(this decimal v) => v < 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveExclusive(this int v) => v > 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveExclusive(this uint v) => v > 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveExclusive(this long v) => v > 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveExclusive(this ulong v) => v > 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveExclusive(this short v) => v > 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveExclusive(this ushort v) => v > 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveExclusive(this byte v) => v > 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveExclusive(this sbyte v) => v > 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveExclusive(this float v) => v > 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveExclusive(this double v) => v > 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveExclusive(this decimal v) => v > 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeInclusive(this int v) => v <= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeInclusive(this uint v) => v <= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeInclusive(this long v) => v <= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeInclusive(this ulong v) => v <= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeInclusive(this short v) => v <= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeInclusive(this ushort v) => v <= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeInclusive(this byte v) => v <= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeInclusive(this sbyte v) => v <= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeInclusive(this float v) => v <= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeInclusive(this double v) => v <= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsNegativeInclusive(this decimal v) => v <= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveInclusive(this int v) => v >= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveInclusive(this uint v) => v >= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveInclusive(this long v) => v >= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveInclusive(this ulong v) => v >= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveInclusive(this short v) => v >= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveInclusive(this ushort v) => v >= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveInclusive(this byte v) => v >= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveInclusive(this sbyte v) => v >= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveInclusive(this float v) => v >= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveInclusive(this double v) => v >= 0;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool IsPositiveInclusive(this decimal v) => v >= 0;

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

        /// <summary>
        /// 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(int v) => System.Math.Sign(v);

        /// <summary>
        /// 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(long v) => System.Math.Sign(v);

        /// <summary>
        /// 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(short v) => System.Math.Sign(v);

        /// <summary>
        /// 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(sbyte v) => System.Math.Sign(v);

        /// <summary>
        /// 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(float v) => System.Math.Sign(v);

        /// <summary>
        /// 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(double v) => System.Math.Sign(v);

        /// <summary>
        /// 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(decimal v) => System.Math.Sign(v);

        /// <summary>
        /// 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(uint v) => (v == 0) ? 0 : 1;

        /// <summary>
        /// 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(ulong v) => (v == 0) ? 0 : 1;

        /// <summary>
        /// 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(ushort v) => (v == 0) ? 0 : 1;

        /// <summary>
        /// 符号付き数値型の場合 <c>System.Math.Sign</c> を呼ぶ.
        /// 符号なし整数型の場合 <c>v</c> が 0 の場合は 0 を, 0 より大きい場合は 1 を返す.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(byte v) => (v == 0) ? 0 : 1;

    }
}
