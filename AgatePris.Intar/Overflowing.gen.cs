using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static class Overflowing {
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
        public static int WrappingSub(int x, int y) => unchecked(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint WrappingSub(uint x, uint y) => unchecked(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingSub(long x, long y) => unchecked(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong WrappingSub(ulong x, ulong y) => unchecked(x - y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingSubUnsigned(int x, uint y) => WrappingSub(x, unchecked((int)y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingSubUnsigned(long x, ulong y) => WrappingSub(x, unchecked((long)y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint AbsDiff(int x, int y) {
            unchecked {
                var ux = (uint)x;
                var uy = (uint)y;
                return (x < y)
                    ? WrappingSub(uy, ux)
                    : WrappingSub(ux, uy);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong AbsDiff(long x, long y) {
            unchecked {
                var ux = (ulong)x;
                var uy = (ulong)y;
                return (x < y)
                    ? WrappingSub(uy, ux)
                    : WrappingSub(ux, uy);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingNeg(int x) => WrappingSub(0, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingNeg(long x) => WrappingSub(0L, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint WrappingNeg(uint x) => WrappingSub(0U, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong WrappingNeg(ulong x) => WrappingSub(0UL, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int WrappingAbs(int x) => (x < 0) ? WrappingNeg(x) : x;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long WrappingAbs(long x) => (x < 0) ? WrappingNeg(x) : x;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint UnsignedAbs(int x) => unchecked((uint)WrappingAbs(x));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong UnsignedAbs(long x) => unchecked((ulong)WrappingAbs(x));
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint AbsDiff(uint x, uint y) {
            return (x < y)
                ? y - x
                : x - y;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong AbsDiff(ulong x, ulong y) {
            return (x < y)
                ? y - x
                : x - y;
        }

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(int x, int y, out int result) {
            var tmp = ((long)x) + y;
            result = unchecked((int)tmp);
            return tmp < int.MinValue || tmp > int.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int? CheckedAdd(int x, int y) {
            int? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SaturatingAdd(int x, int y) {
            return CheckedAdd(x, y) ?? ((x < 0) && (y < 0)
                ? int.MinValue
                : int.MaxValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(uint x, uint y, out uint result) {
            var tmp = ((ulong)x) + y;
            result = unchecked((uint)tmp);
            return tmp > uint.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint? CheckedAdd(uint x, uint y) {
            uint? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SaturatingAdd(uint x, uint y) {
            return CheckedAdd(x, y) ?? uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(int x, int y, out int result) {
            long l = x;
            l *= y;
            result = unchecked((int)l);
            return l < int.MinValue || l > int.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int? CheckedMul(int x, int y) {
            int? @null = null;
            return OverflowingMul(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SaturatingMul(int x, int y) => CheckedMul(x, y) ?? (
            ((x < 0) == (y < 0))
            ? int.MaxValue
            : int.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(uint x, uint y, out uint result) {
            ulong l = x;
            l *= y;
            result = unchecked((uint)l);
            return l > int.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint? CheckedMul(uint x, uint y) {
            uint? @null = null;
            return OverflowingMul(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SaturatingMul(uint x, uint y) => CheckedMul(x, y) ?? uint.MaxValue;

    }
}
