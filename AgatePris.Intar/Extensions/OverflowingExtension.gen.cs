using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Extensions {
    public static class OverflowingExtension {
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int WrappingAdd(this int x, int y) => Overflowing.WrappingAdd(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int WrappingSub(this int x, int y) => Overflowing.WrappingSub(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int WrappingMul(this int x, int y) => Overflowing.WrappingMul(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int WrappingNeg(this int x) => Overflowing.WrappingNeg(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint WrappingAdd(this uint x, uint y) => Overflowing.WrappingAdd(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint WrappingSub(this uint x, uint y) => Overflowing.WrappingSub(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint WrappingMul(this uint x, uint y) => Overflowing.WrappingMul(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint WrappingNeg(this uint x) => Overflowing.WrappingNeg(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long WrappingAdd(this long x, long y) => Overflowing.WrappingAdd(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long WrappingSub(this long x, long y) => Overflowing.WrappingSub(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long WrappingMul(this long x, long y) => Overflowing.WrappingMul(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long WrappingNeg(this long x) => Overflowing.WrappingNeg(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong WrappingAdd(this ulong x, ulong y) => Overflowing.WrappingAdd(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong WrappingSub(this ulong x, ulong y) => Overflowing.WrappingSub(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong WrappingMul(this ulong x, ulong y) => Overflowing.WrappingMul(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong WrappingNeg(this ulong x) => Overflowing.WrappingNeg(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint WrappingAddSigned(this uint x, int y) => Overflowing.WrappingAddSigned(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int WrappingAddUnsigned(this int x, uint y) => Overflowing.WrappingAddUnsigned(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int WrappingSubUnsigned(this int x, uint y) => Overflowing.WrappingSubUnsigned(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int WrappingAbs(this int x) => Overflowing.WrappingAbs(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong WrappingAddSigned(this ulong x, long y) => Overflowing.WrappingAddSigned(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long WrappingAddUnsigned(this long x, ulong y) => Overflowing.WrappingAddUnsigned(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long WrappingSubUnsigned(this long x, ulong y) => Overflowing.WrappingSubUnsigned(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long WrappingAbs(this long x) => Overflowing.WrappingAbs(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool OverflowingAdd(this int x, int y, out int result) => Overflowing.OverflowingAdd(x, y, out result);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int? CheckedAdd(this int x, int y) => Overflowing.CheckedAdd(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int SaturatingAdd(this int x, int y) => Overflowing.SaturatingAdd(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool OverflowingAdd(this uint x, uint y, out uint result) => Overflowing.OverflowingAdd(x, y, out result);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint? CheckedAdd(this uint x, uint y) => Overflowing.CheckedAdd(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint SaturatingAdd(this uint x, uint y) => Overflowing.SaturatingAdd(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool OverflowingAdd(this long x, long y, out long result) => Overflowing.OverflowingAdd(x, y, out result);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long? CheckedAdd(this long x, long y) => Overflowing.CheckedAdd(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long SaturatingAdd(this long x, long y) => Overflowing.SaturatingAdd(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool OverflowingAdd(this ulong x, ulong y, out ulong result) => Overflowing.OverflowingAdd(x, y, out result);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong? CheckedAdd(this ulong x, ulong y) => Overflowing.CheckedAdd(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong SaturatingAdd(this ulong x, ulong y) => Overflowing.SaturatingAdd(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool OverflowingMul(this int x, int y, out int result) => Overflowing.OverflowingMul(x, y, out result);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int? CheckedMul(this int x, int y) => Overflowing.CheckedMul(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int SaturatingMul(this int x, int y) => Overflowing.SaturatingMul(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool OverflowingMul(this uint x, uint y, out uint result) => Overflowing.OverflowingMul(x, y, out result);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint? CheckedMul(this uint x, uint y) => Overflowing.CheckedMul(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint SaturatingMul(this uint x, uint y) => Overflowing.SaturatingMul(x, y);
    }
}
