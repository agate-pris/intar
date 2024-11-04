using System.Runtime.CompilerServices;

#if NET7_0_OR_GREATER

using System;

#endif // NET7_0_OR_GREATER

namespace AgatePris.Intar {
    public static class Overflowing {

        /// <summary>
        /// <para>Adds two values together to compute their sum.</para>
        /// <para>2 つの値を加算し､ その合計を計算します｡</para>
        /// <remarks><div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int StrictAdd(int x, int y) => checked(x + y);

        /// <summary>
        /// <para>Subtracts two values to compute their difference.</para>
        /// <para>1 つの値からもう 1 つの値を引いて､ その差を計算します｡</para>
        /// <remarks><div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int StrictSub(int x, int y) => checked(x - y);

        /// <summary>
        /// <para>Multiplies two values together to compute their product.</para>
        /// <para>2 つの値を掛け合わせて､ その積を計算します｡</para>
        /// <remarks><div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int StrictMul(int x, int y) => checked(x * y);

        /// <summary>
        /// <para>Adds two values together to compute their sum.</para>
        /// <para>2 つの値を加算し､ その合計を計算します｡</para>
        /// <remarks><div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint StrictAdd(uint x, uint y) => checked(x + y);

        /// <summary>
        /// <para>Subtracts two values to compute their difference.</para>
        /// <para>1 つの値からもう 1 つの値を引いて､ その差を計算します｡</para>
        /// <remarks><div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint StrictSub(uint x, uint y) => checked(x - y);

        /// <summary>
        /// <para>Multiplies two values together to compute their product.</para>
        /// <para>2 つの値を掛け合わせて､ その積を計算します｡</para>
        /// <remarks><div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint StrictMul(uint x, uint y) => checked(x * y);

        /// <summary>
        /// <para>Adds two values together to compute their sum.</para>
        /// <para>2 つの値を加算し､ その合計を計算します｡</para>
        /// <remarks><div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long StrictAdd(long x, long y) => checked(x + y);

        /// <summary>
        /// <para>Subtracts two values to compute their difference.</para>
        /// <para>1 つの値からもう 1 つの値を引いて､ その差を計算します｡</para>
        /// <remarks><div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long StrictSub(long x, long y) => checked(x - y);

        /// <summary>
        /// <para>Multiplies two values together to compute their product.</para>
        /// <para>2 つの値を掛け合わせて､ その積を計算します｡</para>
        /// <remarks><div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long StrictMul(long x, long y) => checked(x * y);

        /// <summary>
        /// <para>Adds two values together to compute their sum.</para>
        /// <para>2 つの値を加算し､ その合計を計算します｡</para>
        /// <remarks><div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong StrictAdd(ulong x, ulong y) => checked(x + y);

        /// <summary>
        /// <para>Subtracts two values to compute their difference.</para>
        /// <para>1 つの値からもう 1 つの値を引いて､ その差を計算します｡</para>
        /// <remarks><div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong StrictSub(ulong x, ulong y) => checked(x - y);

        /// <summary>
        /// <para>Multiplies two values together to compute their product.</para>
        /// <para>2 つの値を掛け合わせて､ その積を計算します｡</para>
        /// <remarks><div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong StrictMul(ulong x, ulong y) => checked(x * y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingAdd(int x, int y) => unchecked(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint WrappingAdd(uint x, uint y) => unchecked(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingAdd(long x, long y) => unchecked(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong WrappingAdd(ulong x, ulong y) => unchecked(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint WrappingAddSigned(uint x, int y) => WrappingAdd(x, unchecked((uint)y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong WrappingAddSigned(ulong x, long y) => WrappingAdd(x, unchecked((ulong)y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingAddUnsigned(int x, uint y) => WrappingAdd(x, unchecked((int)y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingAddUnsigned(long x, ulong y) => WrappingAdd(x, unchecked((long)y));
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingNeg(uint x, out uint result) {
        //    result = WrappingAdd(~x, 1);
        //    return x != 0;
        //}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingNeg(ulong x, out ulong result) {
        //    result = WrappingAdd(~x, 1);
        //    return x != 0;
        //}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static uint? CheckedNeg(uint x) {
        //    var b = OverflowingNeg(x, out var result);
        //    return b ? (uint?)null : result;
        //}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static ulong? CheckedNeg(ulong x) {
        //    var b = OverflowingNeg(x, out var result);
        //    return b ? (ulong?)null : result;
        //}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int? CheckedAbs(int x) => (x < 0) ? x.CheckedNeg() : x;
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static long? CheckedAbs(long x) => (x < 0) ? x.CheckedNeg() : x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingSub(int x, int y) {
            return unchecked(x - y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingNeg(int x) {
            return WrappingSub(0, x);
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
        public static UInt128 WrappingSub(UInt128 x, UInt128 y) {
            return unchecked(x - y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 WrappingNeg(UInt128 x) {
            return WrappingSub(0, x);
        }

#endif // NET7_0_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingSubUnsigned(int x, uint y) => WrappingSub(x, unchecked((int)y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingSubUnsigned(long x, ulong y) => WrappingSub(x, unchecked((long)y));

#if NET7_0_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 WrappingSubUnsigned(Int128 x, UInt128 y) => WrappingSub(x, unchecked((Int128)y));

#endif // NET7_0_OR_GREATER

        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingAbs(int, out int result) {
        //    result = WrappingAbs(x);
        //    return x == int.MinValue;
        //}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingAbs(long, out long result) {
        //    result = WrappingAbs(x);
        //    return x == long.MinValue;
        //}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingMul(int x, int y) => unchecked(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint WrappingMul(uint x, uint y) => unchecked(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingMul(long x, long y) => unchecked(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong WrappingMul(ulong x, ulong y) => unchecked(x * y);

        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingNeg(int x, out int result) {
        //    if (x == int.MinValue) {
        //        result = int.MinValue;
        //        return true;
        //    } else {
        //        result = -x;
        //        return false;
        //    }
        //}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingNeg(long x, out long result) {
        //    if (x == long.MinValue) {
        //        result = long.MinValue;
        //        return true;
        //    } else {
        //        result = -x;
        //        return false;
        //    }
        //}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int? CheckedNeg(int x) {
        //    var b = OverflowingNeg(x, out var result);
        //    return b ? (int?)null : result;
        //}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static long? CheckedNeg(long x) {
        //    var b = OverflowingNeg(x, out var result);
        //    return b ? (long?)null : result;
        //}

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
        /// Checked integer addition. Computes <c>x + y</c>,
        /// returning <c>null</c> if overflow occured.
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// System.Assert.AreEqual(uint.MaxValue - 1U, Overflowing.CheckedAdd(uint.MaxValue - 2U, 1U));
        /// System.Assert.AreEqual(null, Overflowing.CheckedAdd(uint.MaxValue - 2U, 3U));
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint? CheckedAdd(uint x, uint y) {
            uint? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }

        /// <summary>
        /// Saturating integer addition. Computes <c>x + y</c>, saturating at the numeric bounds instead of overflowing.
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// System.Assert.AreEqual(101U, Overflowing.SaturatingAdd(100U, 1U));
        /// System.Assert.AreEqual(uint.MaxValue, Overflowing.SaturatingAdd(uint.MaxValue, 127U));
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SaturatingAdd(uint x, uint y) => CheckedAdd(x, y) ?? uint.MaxValue;

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
        /// Checked integer addition. Computes <c>x + y</c>,
        /// returning <c>null</c> if overflow occured.
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// System.Assert.AreEqual(uint.MaxValue - 1U, Overflowing.CheckedAdd(uint.MaxValue - 2U, 1U));
        /// System.Assert.AreEqual(null, Overflowing.CheckedAdd(uint.MaxValue - 2U, 3U));
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong? CheckedAdd(ulong x, ulong y) {
            ulong? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }

        /// <summary>
        /// Saturating integer addition. Computes <c>x + y</c>, saturating at the numeric bounds instead of overflowing.
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// System.Assert.AreEqual(101U, Overflowing.SaturatingAdd(100U, 1U));
        /// System.Assert.AreEqual(uint.MaxValue, Overflowing.SaturatingAdd(uint.MaxValue, 127U));
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong SaturatingAdd(ulong x, ulong y) => CheckedAdd(x, y) ?? ulong.MaxValue;

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
        /// Checked integer addition. Computes <c>x + y</c>,
        /// returning <c>null</c> if overflow occured.
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// System.Assert.AreEqual(uint.MaxValue - 1U, Overflowing.CheckedAdd(uint.MaxValue - 2U, 1U));
        /// System.Assert.AreEqual(null, Overflowing.CheckedAdd(uint.MaxValue - 2U, 3U));
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int? CheckedAdd(int x, int y) {
            int? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }

        /// <summary>
        /// Saturating integer addition. Computes <c>x + y</c>, saturating at the numeric bounds instead of overflowing.
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// System.Assert.AreEqual(101U, Overflowing.SaturatingAdd(100U, 1U));
        /// System.Assert.AreEqual(uint.MaxValue, Overflowing.SaturatingAdd(uint.MaxValue, 127U));
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SaturatingAdd(int x, int y) {
            // オーバーフローが起きた場合、両辺が負の場合は負方向のオーバーフロー、
            // それ以外の場合は必ず正方向のオーバーフローとなる。
            // 両辺の符号が異なる場合はオーバーフローが起きないが、
            // それを検査するのは CheckedAdd の責務である。
            return CheckedAdd(x, y) ?? ((x < 0) && (y < 0)
                ? int.MinValue
                : int.MaxValue);
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

        /// <summary>
        /// Checked integer addition. Computes <c>x + y</c>,
        /// returning <c>null</c> if overflow occured.
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// System.Assert.AreEqual(uint.MaxValue - 1U, Overflowing.CheckedAdd(uint.MaxValue - 2U, 1U));
        /// System.Assert.AreEqual(null, Overflowing.CheckedAdd(uint.MaxValue - 2U, 3U));
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long? CheckedAdd(long x, long y) {
            long? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }

        /// <summary>
        /// Saturating integer addition. Computes <c>x + y</c>, saturating at the numeric bounds instead of overflowing.
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// System.Assert.AreEqual(101U, Overflowing.SaturatingAdd(100U, 1U));
        /// System.Assert.AreEqual(uint.MaxValue, Overflowing.SaturatingAdd(uint.MaxValue, 127U));
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long SaturatingAdd(long x, long y) {
            // オーバーフローが起きた場合、両辺が負の場合は負方向のオーバーフロー、
            // それ以外の場合は必ず正方向のオーバーフローとなる。
            // 両辺の符号が異なる場合はオーバーフローが起きないが、
            // それを検査するのは CheckedAdd の責務である。
            return CheckedAdd(x, y) ?? ((x < 0) && (y < 0)
                ? long.MinValue
                : long.MaxValue);
        }

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingMul(int x, int y, out int result) {
        //    var l = Math.BigMul(x, y);
        //    result = unchecked((int)l);
        //    return l < int.MinValue || l > int.MaxValue;
        //}
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int? CheckedMul(int x, int y) {
        //    int? @null = null;
        //    return OverflowingMul(x, y, out var result) ? @null : result;
        //}
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int SaturatingMul(int x, int y) => CheckedMul(x, y) ?? (
        //    ((x < 0) == (y < 0))
        //    ? int.MaxValue
        //    : int.MinValue
        //);

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingMul(uint x, uint y, out uint result) {
        //    var l = ((ulong)x) * y;
        //    result = unchecked((uint)l);
        //    return l > uint.MaxValue;
        //}
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static uint? CheckedMul(uint x, uint y) {
        //    uint? @null = null;
        //    return OverflowingMul(x, y, out var result) ? @null : result;
        //}
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static uint SaturatingMul(uint x, uint y) => CheckedMul(x, y) ?? uint.MaxValue;

#if NET5_0_OR_GREATER

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingMul(long x, long y, out long result) {
        //    var high = Math.BigMul(x, y, out result);
        //    return result < 0
        //        ? high != -1
        //        : high != 0;
        //}
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static long? CheckedMul(long x, long y) {
        //    long? @null = null;
        //    return OverflowingMul(x, y, out var result) ? @null : result;
        //}
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static long SaturatingMul(long x, long y) => CheckedMul(x, y) ?? (
        //    ((x < 0) == (y < 0))
        //    ? long.MaxValue
        //    : long.MinValue
        //);

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingMul(ulong x, ulong y, out ulong result) {
        //    var high = Math.BigMul(x, y, out result);
        //    return high != 0;
        //}
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static ulong? CheckedMul(ulong x, ulong y) {
        //    ulong? @null = null;
        //    return OverflowingMul(x, y, out var result) ? @null : result;
        //}
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static ulong SaturatingMul(ulong x, ulong y) => CheckedMul(x, y) ?? ulong.MaxValue;

#endif // NET5_0_OR_GREATER

    }
}
