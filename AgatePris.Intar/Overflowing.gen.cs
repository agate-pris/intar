using System.Runtime.CompilerServices;

#if NET7_0_OR_GREATER

using System;

#endif // NET7_0_OR_GREATER

namespace AgatePris.Intar {
    static class Overflowing {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingAdd(int x, int y) {
            return unchecked(x + y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingAddUnsigned(int x, uint y) {
            return WrappingAdd(x, unchecked((int)y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint WrappingAdd(uint x, uint y) {
            return unchecked(x + y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint WrappingAddSigned(uint x, int y) {
            return WrappingAdd(x, unchecked((uint)y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingAdd(long x, long y) {
            return unchecked(x + y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingAddUnsigned(long x, ulong y) {
            return WrappingAdd(x, unchecked((long)y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong WrappingAdd(ulong x, ulong y) {
            return unchecked(x + y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong WrappingAddSigned(ulong x, long y) {
            return WrappingAdd(x, unchecked((ulong)y));
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 WrappingAdd(Int128 x, Int128 y) {
            return unchecked(x + y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 WrappingAddUnsigned(Int128 x, UInt128 y) {
            return WrappingAdd(x, unchecked((Int128)y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 WrappingAdd(UInt128 x, UInt128 y) {
            return unchecked(x + y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 WrappingAddSigned(UInt128 x, Int128 y) {
            return WrappingAdd(x, unchecked((UInt128)y));
        }

#endif // NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingSub(int x, int y) {
            return unchecked(x - y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingNeg(int x) {
            return WrappingSub(0, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingSubUnsigned(int x, uint y) {
            return WrappingSub(x, unchecked((int)y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingAbs(int x) {
            return (x < 0) ? WrappingNeg(x) : x;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint WrappingSub(uint x, uint y) {
            return unchecked(x - y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint WrappingNeg(uint x) {
            return WrappingSub(0, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingSub(long x, long y) {
            return unchecked(x - y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingNeg(long x) {
            return WrappingSub(0, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingSubUnsigned(long x, ulong y) {
            return WrappingSub(x, unchecked((long)y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingAbs(long x) {
            return (x < 0) ? WrappingNeg(x) : x;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong WrappingSub(ulong x, ulong y) {
            return unchecked(x - y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong WrappingNeg(ulong x) {
            return WrappingSub(0, x);
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 WrappingSub(Int128 x, Int128 y) {
            return unchecked(x - y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 WrappingNeg(Int128 x) {
            return WrappingSub(0, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 WrappingSubUnsigned(Int128 x, UInt128 y) {
            return WrappingSub(x, unchecked((Int128)y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 WrappingAbs(Int128 x) {
            return (x < 0) ? WrappingNeg(x) : x;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 WrappingSub(UInt128 x, UInt128 y) {
            return unchecked(x - y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 WrappingNeg(UInt128 x) {
            return WrappingSub(0, x);
        }

#endif // NET7_0_OR_GREATER

        /// <summary>
        /// <para>Calculates <c>x + y</c></para>
        /// </summary>
        /// <returns>
        /// Returns a boolean indicating whether an arithmetic overflow would occur.
        /// </returns>
        /// <example>
        /// Basic usage:
        /// <code>
        /// System.Assert.AreEqual(false, Overflowing.OverflowingAdd(5U, 2U, out var result));
        /// System.Assert.AreEqual(true, Overflowing.OverflowingAdd(uint.MaxValue, 1U, out result));
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(uint x, uint y, out uint result) {
            // unchecked コンテキストでは、整数の演算結果はラップアラウンドする。
            result = unchecked(x + y);

            // 結果がより小さくなったらオーバーフロー。
            return result < x;
        }

        /// <summary>
        /// <para>Calculates <c>x + y</c></para>
        /// </summary>
        /// <returns>
        /// Returns a boolean indicating whether an arithmetic overflow would occur.
        /// </returns>
        /// <example>
        /// Basic usage:
        /// <code>
        /// System.Assert.AreEqual(false, Overflowing.OverflowingAdd(5U, 2U, out var result));
        /// System.Assert.AreEqual(true, Overflowing.OverflowingAdd(uint.MaxValue, 1U, out result));
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(ulong x, ulong y, out ulong result) {
            // unchecked コンテキストでは、整数の演算結果はラップアラウンドする。
            result = unchecked(x + y);

            // 結果がより小さくなったらオーバーフロー。
            return result < x;
        }

        /// <summary>
        /// <para>Calculates <c>x + y</c></para>
        /// </summary>
        /// <returns>
        /// Returns a boolean indicating whether an arithmetic overflow would occur.
        /// </returns>
        /// <example>
        /// Basic usage:
        /// <code>
        /// System.Assert.AreEqual(false, Overflowing.OverflowingAdd(5U, 2U, out var result));
        /// System.Assert.AreEqual(true, Overflowing.OverflowingAdd(uint.MaxValue, 1U, out result));
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(int x, int y, out int result) {
            // unchecked コンテキストでは、整数の演算結果はラップアラウンドする。
            result = unchecked(x + y);

            // 右辺が 0 未満の場合、結果がより大きくなったらオーバーフロー。
            // それ以外の場合、結果がより小さくなったらオーバーフロー。
            return y < 0 ? result > x : result < x;
        }

        /// <summary>
        /// <para>Calculates <c>x + y</c></para>
        /// </summary>
        /// <returns>
        /// Returns a boolean indicating whether an arithmetic overflow would occur.
        /// </returns>
        /// <example>
        /// Basic usage:
        /// <code>
        /// System.Assert.AreEqual(false, Overflowing.OverflowingAdd(5U, 2U, out var result));
        /// System.Assert.AreEqual(true, Overflowing.OverflowingAdd(uint.MaxValue, 1U, out result));
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(long x, long y, out long result) {
            // unchecked コンテキストでは、整数の演算結果はラップアラウンドする。
            result = unchecked(x + y);

            // 右辺が 0 未満の場合、結果がより大きくなったらオーバーフロー。
            // それ以外の場合、結果がより小さくなったらオーバーフロー。
            return y < 0 ? result > x : result < x;
        }

    }
}
