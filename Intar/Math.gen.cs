using System.Runtime.CompilerServices;

#if !NET_STANDARD_2_1 && !NET5_0_OR_GREATER
using System;
#endif

namespace AgatePris.Intar {
    public static partial class Math {

#if NET_STANDARD_2_1 || NET5_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Clamp(int x, int a, int b) => System.Math.Clamp(x, a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint Clamp(uint x, uint a, uint b) => System.Math.Clamp(x, a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long Clamp(long x, long a, long b) => System.Math.Clamp(x, a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong Clamp(ulong x, ulong a, ulong b) => System.Math.Clamp(x, a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static short Clamp(short x, short a, short b) => System.Math.Clamp(x, a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ushort Clamp(ushort x, ushort a, ushort b) => System.Math.Clamp(x, a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static byte Clamp(byte x, byte a, byte b) => System.Math.Clamp(x, a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static sbyte Clamp(sbyte x, sbyte a, sbyte b) => System.Math.Clamp(x, a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static float Clamp(float x, float a, float b) => System.Math.Clamp(x, a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Clamp(double x, double a, double b) => System.Math.Clamp(x, a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static decimal Clamp(decimal x, decimal a, decimal b) => System.Math.Clamp(x, a, b);

#else

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Clamp(int v, int min, int max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Clamp(uint v, uint min, uint max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Clamp(long v, long min, long max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Clamp(ulong v, ulong min, ulong max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Clamp(short v, short min, short max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Clamp(ushort v, ushort min, ushort max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Clamp(byte v, byte min, byte max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Clamp(sbyte v, sbyte min, sbyte max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp(float v, float min, float max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp(double v, double min, double max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal Clamp(decimal v, decimal min, decimal max) {
            if (min > max) {
                throw new ArgumentException($"'{min}' cannot be greater than {max}.");
            }
            return v < min
                ? min : v > max
                ? max : v;
        }

#endif

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(int v) => int.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(uint v) => uint.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(long v) => long.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(ulong v) => ulong.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(short v) => short.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(ushort v) => ushort.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(byte v) => byte.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(sbyte v) => sbyte.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(float v) => float.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(double v) => double.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(decimal v) => decimal.Sign(v);

#else

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(int v) => System.Math.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(long v) => System.Math.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(short v) => System.Math.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(sbyte v) => System.Math.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(float v) => System.Math.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(double v) => System.Math.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(decimal v) => System.Math.Sign(v);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(uint v) => (v == 0) ? 0 : 1;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(ulong v) => (v == 0) ? 0 : 1;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(ushort v) => (v == 0) ? 0 : 1;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(byte v) => (v == 0) ? 0 : 1;

#endif

    }
}
