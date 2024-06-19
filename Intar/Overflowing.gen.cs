using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static class Overflowing {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingAdd(this int x, int y) => unchecked(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint WrappingAdd(this uint x, uint y) => unchecked(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingAdd(this long x, long y) => unchecked(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong WrappingAdd(this ulong x, ulong y) => unchecked(x + y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingSub(this int x, int y) => unchecked(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint WrappingSub(this uint x, uint y) => unchecked(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingSub(this long x, long y) => unchecked(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong WrappingSub(this ulong x, ulong y) => unchecked(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingMul(this int x, int y) => unchecked(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint WrappingMul(this uint x, uint y) => unchecked(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingMul(this long x, long y) => unchecked(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong WrappingMul(this ulong x, ulong y) => unchecked(x * y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint WrappingAddSigned(this uint x, int y) => x.WrappingAdd(unchecked((uint)y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingAddUnsigned(this int x, uint y) => x.WrappingAdd(unchecked((int)y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingSubUnsigned(this int x, uint y) => x.WrappingSub(unchecked((int)y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong WrappingAddSigned(this ulong x, long y) => x.WrappingAdd(unchecked((ulong)y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingAddUnsigned(this long x, ulong y) => x.WrappingAdd(unchecked((long)y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingSubUnsigned(this long x, ulong y) => x.WrappingSub(unchecked((long)y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingNeg(this int x) => 0.WrappingSub(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingNeg(this long x) => 0L.WrappingSub(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint WrappingNeg(this uint x) => 0U.WrappingSub(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong WrappingNeg(this ulong x) => 0UL.WrappingSub(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingAbs(this int x) => (x < 0) ? x.WrappingNeg() : x;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingAbs(this long x) => (x < 0) ? x.WrappingNeg() : x;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint UnsignedAbs(this int x) => unchecked((uint)x.WrappingAbs());
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong UnsignedAbs(this long x) => unchecked((ulong)x.WrappingAbs());

        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingAbs(this int, out int result) {
        //    result = x.WrappingAbs();
        //    return x == int.MinValue;
        //}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingAbs(this long, out long result) {
        //    result = x.WrappingAbs();
        //    return x == long.MinValue;
        //}

        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingNeg(this int x, out int result) {
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
        //public static bool OverflowingNeg(this long x, out long result) {
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
        //public static bool OverflowingNeg(this uint x, out uint result) {
        //    result = (~x).WrappingAdd(1);
        //    return x != 0;
        //}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static bool OverflowingNeg(this ulong x, out ulong result) {
        //    result = (~x).WrappingAdd(1);
        //    return x != 0;
        //}

        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int? CheckedNeg(this int x) {
        //    var b = x.OverflowingNeg(out var result);
        //    return b ? (int?)null : result;
        //}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static long? CheckedNeg(this long x) {
        //    var b = x.OverflowingNeg(out var result);
        //    return b ? (long?)null : result;
        //}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static uint? CheckedNeg(this uint x) {
        //    var b = x.OverflowingNeg(out var result);
        //    return b ? (uint?)null : result;
        //}
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static ulong? CheckedNeg(this ulong x) {
        //    var b = x.OverflowingNeg(out var result);
        //    return b ? (ulong?)null : result;
        //}

        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static int? CheckedAbs(this int x) => (x < 0) ? x.CheckedNeg() : x;
        // まだテストを書いていないのでコメントアウトしておく
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static long? CheckedAbs(this long x) => (x < 0) ? x.CheckedNeg() : x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint AbsDiff(this int x, int y) {
            unchecked {
                var ux = (uint)x;
                var uy = (uint)y;
                return (x < y)
                    ? uy.WrappingSub(ux)
                    : ux.WrappingSub(uy);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong AbsDiff(this long x, long y) {
            unchecked {
                var ux = (ulong)x;
                var uy = (ulong)y;
                return (x < y)
                    ? uy.WrappingSub(ux)
                    : ux.WrappingSub(uy);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint AbsDiff(this uint x, uint y) {
            return (x < y)
                ? y - x
                : x - y;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong AbsDiff(this ulong x, ulong y) {
            return (x < y)
                ? y - x
                : x - y;
        }
    }
}
