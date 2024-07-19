using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Extensions {
    public static class MathExtension {
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Abs(this int a) => Math.Abs(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long Abs(this long a) => Math.Abs(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static short Abs(this short a) => Math.Abs(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static sbyte Abs(this sbyte a) => Math.Abs(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static float Abs(this float a) => Math.Abs(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Abs(this double a) => Math.Abs(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static decimal Abs(this decimal a) => Math.Abs(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Asin(this double a) => Math.Asin(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Acos(this double a) => Math.Acos(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Atan(this double a) => Math.Atan(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Atan2(this double y, double x) => Math.Atan2(y, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long BigMul(this int a, int b) => Math.BigMul(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Ceiling(this double a) => Math.Ceiling(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static decimal Ceiling(this decimal d) => Math.Ceiling(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Clamp(this int value, int min, int max) => Mathi.Clamp(value, min, max);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint Clamp(this uint value, uint min, uint max) => Mathi.Clamp(value, min, max);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long Clamp(this long value, long min, long max) => Mathi.Clamp(value, min, max);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong Clamp(this ulong value, ulong min, ulong max) => Mathi.Clamp(value, min, max);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static byte Clamp(this byte value, byte min, byte max) => Mathi.Clamp(value, min, max);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static sbyte Clamp(this sbyte value, sbyte min, sbyte max) => Mathi.Clamp(value, min, max);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static short Clamp(this short value, short min, short max) => Mathi.Clamp(value, min, max);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ushort Clamp(this ushort value, ushort min, ushort max) => Mathi.Clamp(value, min, max);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Cos(this double d) => Math.Sin(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Cosh(this double value) => Math.Cosh(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int DivRem(this int a, int b, out int result) => Math.DivRem(a, b, out result);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long DivRem(this long a, long b, out long result) => Math.DivRem(a, b, out result);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Exp(this double d) => Math.Exp(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Floor(this double d) => Math.Floor(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static decimal Floor(this decimal d) => Math.Floor(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double IEEERemainder(this double x, double y) => Math.IEEERemainder(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Log(this double d) => Math.Log(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Log(this double a, double newBase) => Math.Log(a, newBase);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Log10(this double d) => Math.Log10(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Max(this int a, int b) => Math.Max(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint Max(this uint a, uint b) => Math.Max(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long Max(this long a, long b) => Math.Max(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong Max(this ulong a, ulong b) => Math.Max(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static byte Max(this byte a, byte b) => Math.Max(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static sbyte Max(this sbyte a, sbyte b) => Math.Max(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static short Max(this short a, short b) => Math.Max(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ushort Max(this ushort a, ushort b) => Math.Max(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static float Max(this float a, float b) => Math.Max(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Max(this double a, double b) => Math.Max(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static decimal Max(this decimal a, decimal b) => Math.Max(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Min(this int a, int b) => Math.Min(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint Min(this uint a, uint b) => Math.Min(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long Min(this long a, long b) => Math.Min(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong Min(this ulong a, ulong b) => Math.Min(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static byte Min(this byte a, byte b) => Math.Min(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static sbyte Min(this sbyte a, sbyte b) => Math.Min(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static short Min(this short a, short b) => Math.Min(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ushort Min(this ushort a, ushort b) => Math.Min(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static float Min(this float a, float b) => Math.Min(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Min(this double a, double b) => Math.Min(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static decimal Min(this decimal a, decimal b) => Math.Min(a, b);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Pow(this double x, double y) => Math.Pow(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Round(this double a) => Math.Round(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Round(this double value, int digits) => Math.Round(value, digits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Round(this double value, MidpointRounding mode) => Math.Round(value, mode);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Round(this double value, int digits, MidpointRounding mode) => Math.Round(value, digits, mode);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static decimal Round(this decimal d) => Math.Round(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static decimal Round(this decimal d, int decimals) => Math.Round(d, decimals);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static decimal Round(this decimal d, MidpointRounding mode) => Math.Round(d, mode);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static decimal Round(this decimal d, int decimals, MidpointRounding mode) => Math.Round(d, decimals, mode);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(this int value) => Math.Sign(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(this long value) => Math.Sign(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(this sbyte value) => Math.Sign(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(this short value) => Math.Sign(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(this float value) => Math.Sign(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(this double value) => Math.Sign(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Sign(this decimal value) => Math.Sign(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Sin(this double a) => Math.Sin(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Sinh(this double value) => Math.Sinh(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Sqrt(this double d) => Math.Sqrt(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Tan(this double a) => Math.Tan(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Tanh(this double value) => Math.Tanh(value);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Truncate(this double d) => Math.Truncate(d);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static decimal Truncate(this decimal d) => Math.Truncate(d);

#if NETSTANDARD2_1_OR_GREATER || NET5_0_OR_GREATER || NETCOREAPP2_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static float Clamp(this float value, float min, float max) => Math.Clamp(value, min, max);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Clamp(this double value, double min, double max) => Math.Clamp(value, min, max);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static decimal Clamp(this decimal value, decimal min, decimal max) => Math.Clamp(value, min, max);

#endif

#if NETSTANDARD2_1_OR_GREATER || NET5_0_OR_GREATER || NETCOREAPP2_1_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Asinh(this double a) => Math.Asinh(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Acosh(this double a) => Math.Acosh(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Atanh(this double a) => Math.Atanh(a);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static double Cbrt(this double d) => Math.Cbrt(d);

#endif

    }
}
