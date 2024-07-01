using AgatePris.Intar.Numerics;
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
        public static bool OverflowingAdd(this I2F30 x, I2F30 y, out I2F30 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I2F30.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I3F29 x, I3F29 y, out I3F29 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I3F29.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I4F28 x, I4F28 y, out I4F28 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I4F28.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I5F27 x, I5F27 y, out I5F27 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I5F27.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I6F26 x, I6F26 y, out I6F26 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I6F26.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I7F25 x, I7F25 y, out I7F25 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I7F25.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I8F24 x, I8F24 y, out I8F24 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I8F24.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I9F23 x, I9F23 y, out I9F23 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I9F23.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I10F22 x, I10F22 y, out I10F22 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I10F22.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I11F21 x, I11F21 y, out I11F21 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I11F21.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I12F20 x, I12F20 y, out I12F20 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I12F20.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I13F19 x, I13F19 y, out I13F19 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I13F19.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I14F18 x, I14F18 y, out I14F18 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I14F18.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I15F17 x, I15F17 y, out I15F17 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I15F17.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I16F16 x, I16F16 y, out I16F16 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I16F16.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I17F15 x, I17F15 y, out I17F15 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I17F15.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I18F14 x, I18F14 y, out I18F14 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I18F14.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I19F13 x, I19F13 y, out I19F13 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I19F13.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I20F12 x, I20F12 y, out I20F12 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I20F12.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I21F11 x, I21F11 y, out I21F11 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I21F11.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I22F10 x, I22F10 y, out I22F10 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I22F10.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I23F9 x, I23F9 y, out I23F9 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I23F9.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I24F8 x, I24F8 y, out I24F8 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I24F8.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I25F7 x, I25F7 y, out I25F7 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I25F7.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I26F6 x, I26F6 y, out I26F6 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I26F6.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I27F5 x, I27F5 y, out I27F5 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I27F5.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I28F4 x, I28F4 y, out I28F4 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I28F4.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I29F3 x, I29F3 y, out I29F3 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I29F3.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I30F2 x, I30F2 y, out I30F2 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I30F2.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this I31F1 x, I31F1 y, out I31F1 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = I31F1.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int? CheckedAdd(int x, int y) {
            int? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30? CheckedAdd(this I2F30 x, I2F30 y) {
            I2F30? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F29? CheckedAdd(this I3F29 x, I3F29 y) {
            I3F29? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F28? CheckedAdd(this I4F28 x, I4F28 y) {
            I4F28? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I5F27? CheckedAdd(this I5F27 x, I5F27 y) {
            I5F27? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I6F26? CheckedAdd(this I6F26 x, I6F26 y) {
            I6F26? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I7F25? CheckedAdd(this I7F25 x, I7F25 y) {
            I7F25? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F24? CheckedAdd(this I8F24 x, I8F24 y) {
            I8F24? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I9F23? CheckedAdd(this I9F23 x, I9F23 y) {
            I9F23? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I10F22? CheckedAdd(this I10F22 x, I10F22 y) {
            I10F22? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I11F21? CheckedAdd(this I11F21 x, I11F21 y) {
            I11F21? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I12F20? CheckedAdd(this I12F20 x, I12F20 y) {
            I12F20? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I13F19? CheckedAdd(this I13F19 x, I13F19 y) {
            I13F19? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I14F18? CheckedAdd(this I14F18 x, I14F18 y) {
            I14F18? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I15F17? CheckedAdd(this I15F17 x, I15F17 y) {
            I15F17? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I16F16? CheckedAdd(this I16F16 x, I16F16 y) {
            I16F16? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15? CheckedAdd(this I17F15 x, I17F15 y) {
            I17F15? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I18F14? CheckedAdd(this I18F14 x, I18F14 y) {
            I18F14? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I19F13? CheckedAdd(this I19F13 x, I19F13 y) {
            I19F13? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I20F12? CheckedAdd(this I20F12 x, I20F12 y) {
            I20F12? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I21F11? CheckedAdd(this I21F11 x, I21F11 y) {
            I21F11? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I22F10? CheckedAdd(this I22F10 x, I22F10 y) {
            I22F10? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I23F9? CheckedAdd(this I23F9 x, I23F9 y) {
            I23F9? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I24F8? CheckedAdd(this I24F8 x, I24F8 y) {
            I24F8? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I25F7? CheckedAdd(this I25F7 x, I25F7 y) {
            I25F7? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F6? CheckedAdd(this I26F6 x, I26F6 y) {
            I26F6? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I27F5? CheckedAdd(this I27F5 x, I27F5 y) {
            I27F5? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I28F4? CheckedAdd(this I28F4 x, I28F4 y) {
            I28F4? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I29F3? CheckedAdd(this I29F3 x, I29F3 y) {
            I29F3? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I30F2? CheckedAdd(this I30F2 x, I30F2 y) {
            I30F2? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I31F1? CheckedAdd(this I31F1 x, I31F1 y) {
            I31F1? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SaturatingAdd(int x, int y) {
            return CheckedAdd(x, y) ?? ((x < 0) && (y < 0)
                ? int.MinValue
                : int.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 SaturatingAdd(this I2F30 x, I2F30 y) {
            return CheckedAdd(x, y) ?? ((x < I2F30.Zero) && (y < I2F30.Zero)
                ? I2F30.MinValue
                : I2F30.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 SaturatingAdd(
            this Vector2I2F30 x, Vector2I2F30 y
        ) => new Vector2I2F30(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 SaturatingAdd(
            this Vector3I2F30 x, Vector3I2F30 y
        ) => new Vector3I2F30(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 SaturatingAdd(
            this Vector4I2F30 x, Vector4I2F30 y
        ) => new Vector4I2F30(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F29 SaturatingAdd(this I3F29 x, I3F29 y) {
            return CheckedAdd(x, y) ?? ((x < I3F29.Zero) && (y < I3F29.Zero)
                ? I3F29.MinValue
                : I3F29.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 SaturatingAdd(
            this Vector2I3F29 x, Vector2I3F29 y
        ) => new Vector2I3F29(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 SaturatingAdd(
            this Vector3I3F29 x, Vector3I3F29 y
        ) => new Vector3I3F29(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 SaturatingAdd(
            this Vector4I3F29 x, Vector4I3F29 y
        ) => new Vector4I3F29(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F28 SaturatingAdd(this I4F28 x, I4F28 y) {
            return CheckedAdd(x, y) ?? ((x < I4F28.Zero) && (y < I4F28.Zero)
                ? I4F28.MinValue
                : I4F28.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 SaturatingAdd(
            this Vector2I4F28 x, Vector2I4F28 y
        ) => new Vector2I4F28(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 SaturatingAdd(
            this Vector3I4F28 x, Vector3I4F28 y
        ) => new Vector3I4F28(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 SaturatingAdd(
            this Vector4I4F28 x, Vector4I4F28 y
        ) => new Vector4I4F28(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I5F27 SaturatingAdd(this I5F27 x, I5F27 y) {
            return CheckedAdd(x, y) ?? ((x < I5F27.Zero) && (y < I5F27.Zero)
                ? I5F27.MinValue
                : I5F27.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 SaturatingAdd(
            this Vector2I5F27 x, Vector2I5F27 y
        ) => new Vector2I5F27(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 SaturatingAdd(
            this Vector3I5F27 x, Vector3I5F27 y
        ) => new Vector3I5F27(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 SaturatingAdd(
            this Vector4I5F27 x, Vector4I5F27 y
        ) => new Vector4I5F27(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I6F26 SaturatingAdd(this I6F26 x, I6F26 y) {
            return CheckedAdd(x, y) ?? ((x < I6F26.Zero) && (y < I6F26.Zero)
                ? I6F26.MinValue
                : I6F26.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 SaturatingAdd(
            this Vector2I6F26 x, Vector2I6F26 y
        ) => new Vector2I6F26(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 SaturatingAdd(
            this Vector3I6F26 x, Vector3I6F26 y
        ) => new Vector3I6F26(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 SaturatingAdd(
            this Vector4I6F26 x, Vector4I6F26 y
        ) => new Vector4I6F26(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I7F25 SaturatingAdd(this I7F25 x, I7F25 y) {
            return CheckedAdd(x, y) ?? ((x < I7F25.Zero) && (y < I7F25.Zero)
                ? I7F25.MinValue
                : I7F25.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 SaturatingAdd(
            this Vector2I7F25 x, Vector2I7F25 y
        ) => new Vector2I7F25(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 SaturatingAdd(
            this Vector3I7F25 x, Vector3I7F25 y
        ) => new Vector3I7F25(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 SaturatingAdd(
            this Vector4I7F25 x, Vector4I7F25 y
        ) => new Vector4I7F25(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F24 SaturatingAdd(this I8F24 x, I8F24 y) {
            return CheckedAdd(x, y) ?? ((x < I8F24.Zero) && (y < I8F24.Zero)
                ? I8F24.MinValue
                : I8F24.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 SaturatingAdd(
            this Vector2I8F24 x, Vector2I8F24 y
        ) => new Vector2I8F24(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 SaturatingAdd(
            this Vector3I8F24 x, Vector3I8F24 y
        ) => new Vector3I8F24(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 SaturatingAdd(
            this Vector4I8F24 x, Vector4I8F24 y
        ) => new Vector4I8F24(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I9F23 SaturatingAdd(this I9F23 x, I9F23 y) {
            return CheckedAdd(x, y) ?? ((x < I9F23.Zero) && (y < I9F23.Zero)
                ? I9F23.MinValue
                : I9F23.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 SaturatingAdd(
            this Vector2I9F23 x, Vector2I9F23 y
        ) => new Vector2I9F23(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 SaturatingAdd(
            this Vector3I9F23 x, Vector3I9F23 y
        ) => new Vector3I9F23(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 SaturatingAdd(
            this Vector4I9F23 x, Vector4I9F23 y
        ) => new Vector4I9F23(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I10F22 SaturatingAdd(this I10F22 x, I10F22 y) {
            return CheckedAdd(x, y) ?? ((x < I10F22.Zero) && (y < I10F22.Zero)
                ? I10F22.MinValue
                : I10F22.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I10F22 SaturatingAdd(
            this Vector2I10F22 x, Vector2I10F22 y
        ) => new Vector2I10F22(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 SaturatingAdd(
            this Vector3I10F22 x, Vector3I10F22 y
        ) => new Vector3I10F22(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 SaturatingAdd(
            this Vector4I10F22 x, Vector4I10F22 y
        ) => new Vector4I10F22(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I11F21 SaturatingAdd(this I11F21 x, I11F21 y) {
            return CheckedAdd(x, y) ?? ((x < I11F21.Zero) && (y < I11F21.Zero)
                ? I11F21.MinValue
                : I11F21.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 SaturatingAdd(
            this Vector2I11F21 x, Vector2I11F21 y
        ) => new Vector2I11F21(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 SaturatingAdd(
            this Vector3I11F21 x, Vector3I11F21 y
        ) => new Vector3I11F21(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 SaturatingAdd(
            this Vector4I11F21 x, Vector4I11F21 y
        ) => new Vector4I11F21(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I12F20 SaturatingAdd(this I12F20 x, I12F20 y) {
            return CheckedAdd(x, y) ?? ((x < I12F20.Zero) && (y < I12F20.Zero)
                ? I12F20.MinValue
                : I12F20.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 SaturatingAdd(
            this Vector2I12F20 x, Vector2I12F20 y
        ) => new Vector2I12F20(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 SaturatingAdd(
            this Vector3I12F20 x, Vector3I12F20 y
        ) => new Vector3I12F20(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 SaturatingAdd(
            this Vector4I12F20 x, Vector4I12F20 y
        ) => new Vector4I12F20(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I13F19 SaturatingAdd(this I13F19 x, I13F19 y) {
            return CheckedAdd(x, y) ?? ((x < I13F19.Zero) && (y < I13F19.Zero)
                ? I13F19.MinValue
                : I13F19.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 SaturatingAdd(
            this Vector2I13F19 x, Vector2I13F19 y
        ) => new Vector2I13F19(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 SaturatingAdd(
            this Vector3I13F19 x, Vector3I13F19 y
        ) => new Vector3I13F19(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 SaturatingAdd(
            this Vector4I13F19 x, Vector4I13F19 y
        ) => new Vector4I13F19(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I14F18 SaturatingAdd(this I14F18 x, I14F18 y) {
            return CheckedAdd(x, y) ?? ((x < I14F18.Zero) && (y < I14F18.Zero)
                ? I14F18.MinValue
                : I14F18.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 SaturatingAdd(
            this Vector2I14F18 x, Vector2I14F18 y
        ) => new Vector2I14F18(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 SaturatingAdd(
            this Vector3I14F18 x, Vector3I14F18 y
        ) => new Vector3I14F18(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 SaturatingAdd(
            this Vector4I14F18 x, Vector4I14F18 y
        ) => new Vector4I14F18(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I15F17 SaturatingAdd(this I15F17 x, I15F17 y) {
            return CheckedAdd(x, y) ?? ((x < I15F17.Zero) && (y < I15F17.Zero)
                ? I15F17.MinValue
                : I15F17.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 SaturatingAdd(
            this Vector2I15F17 x, Vector2I15F17 y
        ) => new Vector2I15F17(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 SaturatingAdd(
            this Vector3I15F17 x, Vector3I15F17 y
        ) => new Vector3I15F17(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 SaturatingAdd(
            this Vector4I15F17 x, Vector4I15F17 y
        ) => new Vector4I15F17(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I16F16 SaturatingAdd(this I16F16 x, I16F16 y) {
            return CheckedAdd(x, y) ?? ((x < I16F16.Zero) && (y < I16F16.Zero)
                ? I16F16.MinValue
                : I16F16.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 SaturatingAdd(
            this Vector2I16F16 x, Vector2I16F16 y
        ) => new Vector2I16F16(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 SaturatingAdd(
            this Vector3I16F16 x, Vector3I16F16 y
        ) => new Vector3I16F16(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I16F16 SaturatingAdd(
            this Vector4I16F16 x, Vector4I16F16 y
        ) => new Vector4I16F16(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 SaturatingAdd(this I17F15 x, I17F15 y) {
            return CheckedAdd(x, y) ?? ((x < I17F15.Zero) && (y < I17F15.Zero)
                ? I17F15.MinValue
                : I17F15.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 SaturatingAdd(
            this Vector2I17F15 x, Vector2I17F15 y
        ) => new Vector2I17F15(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 SaturatingAdd(
            this Vector3I17F15 x, Vector3I17F15 y
        ) => new Vector3I17F15(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 SaturatingAdd(
            this Vector4I17F15 x, Vector4I17F15 y
        ) => new Vector4I17F15(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I18F14 SaturatingAdd(this I18F14 x, I18F14 y) {
            return CheckedAdd(x, y) ?? ((x < I18F14.Zero) && (y < I18F14.Zero)
                ? I18F14.MinValue
                : I18F14.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 SaturatingAdd(
            this Vector2I18F14 x, Vector2I18F14 y
        ) => new Vector2I18F14(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 SaturatingAdd(
            this Vector3I18F14 x, Vector3I18F14 y
        ) => new Vector3I18F14(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 SaturatingAdd(
            this Vector4I18F14 x, Vector4I18F14 y
        ) => new Vector4I18F14(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I19F13 SaturatingAdd(this I19F13 x, I19F13 y) {
            return CheckedAdd(x, y) ?? ((x < I19F13.Zero) && (y < I19F13.Zero)
                ? I19F13.MinValue
                : I19F13.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 SaturatingAdd(
            this Vector2I19F13 x, Vector2I19F13 y
        ) => new Vector2I19F13(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 SaturatingAdd(
            this Vector3I19F13 x, Vector3I19F13 y
        ) => new Vector3I19F13(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 SaturatingAdd(
            this Vector4I19F13 x, Vector4I19F13 y
        ) => new Vector4I19F13(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I20F12 SaturatingAdd(this I20F12 x, I20F12 y) {
            return CheckedAdd(x, y) ?? ((x < I20F12.Zero) && (y < I20F12.Zero)
                ? I20F12.MinValue
                : I20F12.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 SaturatingAdd(
            this Vector2I20F12 x, Vector2I20F12 y
        ) => new Vector2I20F12(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 SaturatingAdd(
            this Vector3I20F12 x, Vector3I20F12 y
        ) => new Vector3I20F12(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 SaturatingAdd(
            this Vector4I20F12 x, Vector4I20F12 y
        ) => new Vector4I20F12(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I21F11 SaturatingAdd(this I21F11 x, I21F11 y) {
            return CheckedAdd(x, y) ?? ((x < I21F11.Zero) && (y < I21F11.Zero)
                ? I21F11.MinValue
                : I21F11.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 SaturatingAdd(
            this Vector2I21F11 x, Vector2I21F11 y
        ) => new Vector2I21F11(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 SaturatingAdd(
            this Vector3I21F11 x, Vector3I21F11 y
        ) => new Vector3I21F11(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 SaturatingAdd(
            this Vector4I21F11 x, Vector4I21F11 y
        ) => new Vector4I21F11(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I22F10 SaturatingAdd(this I22F10 x, I22F10 y) {
            return CheckedAdd(x, y) ?? ((x < I22F10.Zero) && (y < I22F10.Zero)
                ? I22F10.MinValue
                : I22F10.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I22F10 SaturatingAdd(
            this Vector2I22F10 x, Vector2I22F10 y
        ) => new Vector2I22F10(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 SaturatingAdd(
            this Vector3I22F10 x, Vector3I22F10 y
        ) => new Vector3I22F10(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I22F10 SaturatingAdd(
            this Vector4I22F10 x, Vector4I22F10 y
        ) => new Vector4I22F10(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I23F9 SaturatingAdd(this I23F9 x, I23F9 y) {
            return CheckedAdd(x, y) ?? ((x < I23F9.Zero) && (y < I23F9.Zero)
                ? I23F9.MinValue
                : I23F9.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 SaturatingAdd(
            this Vector2I23F9 x, Vector2I23F9 y
        ) => new Vector2I23F9(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 SaturatingAdd(
            this Vector3I23F9 x, Vector3I23F9 y
        ) => new Vector3I23F9(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 SaturatingAdd(
            this Vector4I23F9 x, Vector4I23F9 y
        ) => new Vector4I23F9(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I24F8 SaturatingAdd(this I24F8 x, I24F8 y) {
            return CheckedAdd(x, y) ?? ((x < I24F8.Zero) && (y < I24F8.Zero)
                ? I24F8.MinValue
                : I24F8.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 SaturatingAdd(
            this Vector2I24F8 x, Vector2I24F8 y
        ) => new Vector2I24F8(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 SaturatingAdd(
            this Vector3I24F8 x, Vector3I24F8 y
        ) => new Vector3I24F8(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 SaturatingAdd(
            this Vector4I24F8 x, Vector4I24F8 y
        ) => new Vector4I24F8(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I25F7 SaturatingAdd(this I25F7 x, I25F7 y) {
            return CheckedAdd(x, y) ?? ((x < I25F7.Zero) && (y < I25F7.Zero)
                ? I25F7.MinValue
                : I25F7.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 SaturatingAdd(
            this Vector2I25F7 x, Vector2I25F7 y
        ) => new Vector2I25F7(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 SaturatingAdd(
            this Vector3I25F7 x, Vector3I25F7 y
        ) => new Vector3I25F7(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 SaturatingAdd(
            this Vector4I25F7 x, Vector4I25F7 y
        ) => new Vector4I25F7(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F6 SaturatingAdd(this I26F6 x, I26F6 y) {
            return CheckedAdd(x, y) ?? ((x < I26F6.Zero) && (y < I26F6.Zero)
                ? I26F6.MinValue
                : I26F6.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 SaturatingAdd(
            this Vector2I26F6 x, Vector2I26F6 y
        ) => new Vector2I26F6(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 SaturatingAdd(
            this Vector3I26F6 x, Vector3I26F6 y
        ) => new Vector3I26F6(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 SaturatingAdd(
            this Vector4I26F6 x, Vector4I26F6 y
        ) => new Vector4I26F6(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I27F5 SaturatingAdd(this I27F5 x, I27F5 y) {
            return CheckedAdd(x, y) ?? ((x < I27F5.Zero) && (y < I27F5.Zero)
                ? I27F5.MinValue
                : I27F5.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 SaturatingAdd(
            this Vector2I27F5 x, Vector2I27F5 y
        ) => new Vector2I27F5(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 SaturatingAdd(
            this Vector3I27F5 x, Vector3I27F5 y
        ) => new Vector3I27F5(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 SaturatingAdd(
            this Vector4I27F5 x, Vector4I27F5 y
        ) => new Vector4I27F5(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I28F4 SaturatingAdd(this I28F4 x, I28F4 y) {
            return CheckedAdd(x, y) ?? ((x < I28F4.Zero) && (y < I28F4.Zero)
                ? I28F4.MinValue
                : I28F4.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 SaturatingAdd(
            this Vector2I28F4 x, Vector2I28F4 y
        ) => new Vector2I28F4(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 SaturatingAdd(
            this Vector3I28F4 x, Vector3I28F4 y
        ) => new Vector3I28F4(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 SaturatingAdd(
            this Vector4I28F4 x, Vector4I28F4 y
        ) => new Vector4I28F4(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I29F3 SaturatingAdd(this I29F3 x, I29F3 y) {
            return CheckedAdd(x, y) ?? ((x < I29F3.Zero) && (y < I29F3.Zero)
                ? I29F3.MinValue
                : I29F3.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 SaturatingAdd(
            this Vector2I29F3 x, Vector2I29F3 y
        ) => new Vector2I29F3(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 SaturatingAdd(
            this Vector3I29F3 x, Vector3I29F3 y
        ) => new Vector3I29F3(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 SaturatingAdd(
            this Vector4I29F3 x, Vector4I29F3 y
        ) => new Vector4I29F3(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I30F2 SaturatingAdd(this I30F2 x, I30F2 y) {
            return CheckedAdd(x, y) ?? ((x < I30F2.Zero) && (y < I30F2.Zero)
                ? I30F2.MinValue
                : I30F2.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 SaturatingAdd(
            this Vector2I30F2 x, Vector2I30F2 y
        ) => new Vector2I30F2(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 SaturatingAdd(
            this Vector3I30F2 x, Vector3I30F2 y
        ) => new Vector3I30F2(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 SaturatingAdd(
            this Vector4I30F2 x, Vector4I30F2 y
        ) => new Vector4I30F2(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I31F1 SaturatingAdd(this I31F1 x, I31F1 y) {
            return CheckedAdd(x, y) ?? ((x < I31F1.Zero) && (y < I31F1.Zero)
                ? I31F1.MinValue
                : I31F1.MaxValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 SaturatingAdd(
            this Vector2I31F1 x, Vector2I31F1 y
        ) => new Vector2I31F1(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 SaturatingAdd(
            this Vector3I31F1 x, Vector3I31F1 y
        ) => new Vector3I31F1(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 SaturatingAdd(
            this Vector4I31F1 x, Vector4I31F1 y
        ) => new Vector4I31F1(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(uint x, uint y, out uint result) {
            var tmp = ((ulong)x) + y;
            result = unchecked((uint)tmp);
            return tmp > uint.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U2F30 x, U2F30 y, out U2F30 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U2F30.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U3F29 x, U3F29 y, out U3F29 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U3F29.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U4F28 x, U4F28 y, out U4F28 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U4F28.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U5F27 x, U5F27 y, out U5F27 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U5F27.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U6F26 x, U6F26 y, out U6F26 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U6F26.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U7F25 x, U7F25 y, out U7F25 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U7F25.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U8F24 x, U8F24 y, out U8F24 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U8F24.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U9F23 x, U9F23 y, out U9F23 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U9F23.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U10F22 x, U10F22 y, out U10F22 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U10F22.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U11F21 x, U11F21 y, out U11F21 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U11F21.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U12F20 x, U12F20 y, out U12F20 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U12F20.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U13F19 x, U13F19 y, out U13F19 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U13F19.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U14F18 x, U14F18 y, out U14F18 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U14F18.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U15F17 x, U15F17 y, out U15F17 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U15F17.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U16F16 x, U16F16 y, out U16F16 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U16F16.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U17F15 x, U17F15 y, out U17F15 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U17F15.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U18F14 x, U18F14 y, out U18F14 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U18F14.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U19F13 x, U19F13 y, out U19F13 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U19F13.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U20F12 x, U20F12 y, out U20F12 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U20F12.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U21F11 x, U21F11 y, out U21F11 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U21F11.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U22F10 x, U22F10 y, out U22F10 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U22F10.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U23F9 x, U23F9 y, out U23F9 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U23F9.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U24F8 x, U24F8 y, out U24F8 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U24F8.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U25F7 x, U25F7 y, out U25F7 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U25F7.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U26F6 x, U26F6 y, out U26F6 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U26F6.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U27F5 x, U27F5 y, out U27F5 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U27F5.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U28F4 x, U28F4 y, out U28F4 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U28F4.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U29F3 x, U29F3 y, out U29F3 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U29F3.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U30F2 x, U30F2 y, out U30F2 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U30F2.FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingAdd(this U31F1 x, U31F1 y, out U31F1 result) {
            var b = OverflowingAdd(x.Bits, y.Bits, out var bits);
            result = U31F1.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint? CheckedAdd(uint x, uint y) {
            uint? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30? CheckedAdd(this U2F30 x, U2F30 y) {
            U2F30? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U3F29? CheckedAdd(this U3F29 x, U3F29 y) {
            U3F29? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F28? CheckedAdd(this U4F28 x, U4F28 y) {
            U4F28? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27? CheckedAdd(this U5F27 x, U5F27 y) {
            U5F27? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U6F26? CheckedAdd(this U6F26 x, U6F26 y) {
            U6F26? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U7F25? CheckedAdd(this U7F25 x, U7F25 y) {
            U7F25? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U8F24? CheckedAdd(this U8F24 x, U8F24 y) {
            U8F24? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U9F23? CheckedAdd(this U9F23 x, U9F23 y) {
            U9F23? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U10F22? CheckedAdd(this U10F22 x, U10F22 y) {
            U10F22? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U11F21? CheckedAdd(this U11F21 x, U11F21 y) {
            U11F21? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U12F20? CheckedAdd(this U12F20 x, U12F20 y) {
            U12F20? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U13F19? CheckedAdd(this U13F19 x, U13F19 y) {
            U13F19? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U14F18? CheckedAdd(this U14F18 x, U14F18 y) {
            U14F18? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U15F17? CheckedAdd(this U15F17 x, U15F17 y) {
            U15F17? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U16F16? CheckedAdd(this U16F16 x, U16F16 y) {
            U16F16? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15? CheckedAdd(this U17F15 x, U17F15 y) {
            U17F15? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U18F14? CheckedAdd(this U18F14 x, U18F14 y) {
            U18F14? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U19F13? CheckedAdd(this U19F13 x, U19F13 y) {
            U19F13? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U20F12? CheckedAdd(this U20F12 x, U20F12 y) {
            U20F12? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U21F11? CheckedAdd(this U21F11 x, U21F11 y) {
            U21F11? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U22F10? CheckedAdd(this U22F10 x, U22F10 y) {
            U22F10? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U23F9? CheckedAdd(this U23F9 x, U23F9 y) {
            U23F9? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F8? CheckedAdd(this U24F8 x, U24F8 y) {
            U24F8? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U25F7? CheckedAdd(this U25F7 x, U25F7 y) {
            U25F7? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U26F6? CheckedAdd(this U26F6 x, U26F6 y) {
            U26F6? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U27F5? CheckedAdd(this U27F5 x, U27F5 y) {
            U27F5? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U28F4? CheckedAdd(this U28F4 x, U28F4 y) {
            U28F4? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U29F3? CheckedAdd(this U29F3 x, U29F3 y) {
            U29F3? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U30F2? CheckedAdd(this U30F2 x, U30F2 y) {
            U30F2? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U31F1? CheckedAdd(this U31F1 x, U31F1 y) {
            U31F1? @null = null;
            return OverflowingAdd(x, y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint SaturatingAdd(uint x, uint y) {
            return CheckedAdd(x, y) ?? uint.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 SaturatingAdd(this U2F30 x, U2F30 y) {
            return CheckedAdd(x, y) ?? U2F30.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U2F30 SaturatingAdd(
            this Vector2U2F30 x, Vector2U2F30 y
        ) => new Vector2U2F30(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 SaturatingAdd(
            this Vector3U2F30 x, Vector3U2F30 y
        ) => new Vector3U2F30(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 SaturatingAdd(
            this Vector4U2F30 x, Vector4U2F30 y
        ) => new Vector4U2F30(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U3F29 SaturatingAdd(this U3F29 x, U3F29 y) {
            return CheckedAdd(x, y) ?? U3F29.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 SaturatingAdd(
            this Vector2U3F29 x, Vector2U3F29 y
        ) => new Vector2U3F29(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 SaturatingAdd(
            this Vector3U3F29 x, Vector3U3F29 y
        ) => new Vector3U3F29(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 SaturatingAdd(
            this Vector4U3F29 x, Vector4U3F29 y
        ) => new Vector4U3F29(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F28 SaturatingAdd(this U4F28 x, U4F28 y) {
            return CheckedAdd(x, y) ?? U4F28.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 SaturatingAdd(
            this Vector2U4F28 x, Vector2U4F28 y
        ) => new Vector2U4F28(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 SaturatingAdd(
            this Vector3U4F28 x, Vector3U4F28 y
        ) => new Vector3U4F28(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 SaturatingAdd(
            this Vector4U4F28 x, Vector4U4F28 y
        ) => new Vector4U4F28(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27 SaturatingAdd(this U5F27 x, U5F27 y) {
            return CheckedAdd(x, y) ?? U5F27.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 SaturatingAdd(
            this Vector2U5F27 x, Vector2U5F27 y
        ) => new Vector2U5F27(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 SaturatingAdd(
            this Vector3U5F27 x, Vector3U5F27 y
        ) => new Vector3U5F27(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 SaturatingAdd(
            this Vector4U5F27 x, Vector4U5F27 y
        ) => new Vector4U5F27(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U6F26 SaturatingAdd(this U6F26 x, U6F26 y) {
            return CheckedAdd(x, y) ?? U6F26.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 SaturatingAdd(
            this Vector2U6F26 x, Vector2U6F26 y
        ) => new Vector2U6F26(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 SaturatingAdd(
            this Vector3U6F26 x, Vector3U6F26 y
        ) => new Vector3U6F26(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 SaturatingAdd(
            this Vector4U6F26 x, Vector4U6F26 y
        ) => new Vector4U6F26(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U7F25 SaturatingAdd(this U7F25 x, U7F25 y) {
            return CheckedAdd(x, y) ?? U7F25.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 SaturatingAdd(
            this Vector2U7F25 x, Vector2U7F25 y
        ) => new Vector2U7F25(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 SaturatingAdd(
            this Vector3U7F25 x, Vector3U7F25 y
        ) => new Vector3U7F25(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 SaturatingAdd(
            this Vector4U7F25 x, Vector4U7F25 y
        ) => new Vector4U7F25(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U8F24 SaturatingAdd(this U8F24 x, U8F24 y) {
            return CheckedAdd(x, y) ?? U8F24.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 SaturatingAdd(
            this Vector2U8F24 x, Vector2U8F24 y
        ) => new Vector2U8F24(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 SaturatingAdd(
            this Vector3U8F24 x, Vector3U8F24 y
        ) => new Vector3U8F24(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 SaturatingAdd(
            this Vector4U8F24 x, Vector4U8F24 y
        ) => new Vector4U8F24(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U9F23 SaturatingAdd(this U9F23 x, U9F23 y) {
            return CheckedAdd(x, y) ?? U9F23.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 SaturatingAdd(
            this Vector2U9F23 x, Vector2U9F23 y
        ) => new Vector2U9F23(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 SaturatingAdd(
            this Vector3U9F23 x, Vector3U9F23 y
        ) => new Vector3U9F23(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 SaturatingAdd(
            this Vector4U9F23 x, Vector4U9F23 y
        ) => new Vector4U9F23(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U10F22 SaturatingAdd(this U10F22 x, U10F22 y) {
            return CheckedAdd(x, y) ?? U10F22.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 SaturatingAdd(
            this Vector2U10F22 x, Vector2U10F22 y
        ) => new Vector2U10F22(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 SaturatingAdd(
            this Vector3U10F22 x, Vector3U10F22 y
        ) => new Vector3U10F22(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 SaturatingAdd(
            this Vector4U10F22 x, Vector4U10F22 y
        ) => new Vector4U10F22(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U11F21 SaturatingAdd(this U11F21 x, U11F21 y) {
            return CheckedAdd(x, y) ?? U11F21.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 SaturatingAdd(
            this Vector2U11F21 x, Vector2U11F21 y
        ) => new Vector2U11F21(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 SaturatingAdd(
            this Vector3U11F21 x, Vector3U11F21 y
        ) => new Vector3U11F21(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 SaturatingAdd(
            this Vector4U11F21 x, Vector4U11F21 y
        ) => new Vector4U11F21(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U12F20 SaturatingAdd(this U12F20 x, U12F20 y) {
            return CheckedAdd(x, y) ?? U12F20.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 SaturatingAdd(
            this Vector2U12F20 x, Vector2U12F20 y
        ) => new Vector2U12F20(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 SaturatingAdd(
            this Vector3U12F20 x, Vector3U12F20 y
        ) => new Vector3U12F20(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U12F20 SaturatingAdd(
            this Vector4U12F20 x, Vector4U12F20 y
        ) => new Vector4U12F20(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U13F19 SaturatingAdd(this U13F19 x, U13F19 y) {
            return CheckedAdd(x, y) ?? U13F19.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 SaturatingAdd(
            this Vector2U13F19 x, Vector2U13F19 y
        ) => new Vector2U13F19(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 SaturatingAdd(
            this Vector3U13F19 x, Vector3U13F19 y
        ) => new Vector3U13F19(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 SaturatingAdd(
            this Vector4U13F19 x, Vector4U13F19 y
        ) => new Vector4U13F19(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U14F18 SaturatingAdd(this U14F18 x, U14F18 y) {
            return CheckedAdd(x, y) ?? U14F18.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 SaturatingAdd(
            this Vector2U14F18 x, Vector2U14F18 y
        ) => new Vector2U14F18(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 SaturatingAdd(
            this Vector3U14F18 x, Vector3U14F18 y
        ) => new Vector3U14F18(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 SaturatingAdd(
            this Vector4U14F18 x, Vector4U14F18 y
        ) => new Vector4U14F18(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U15F17 SaturatingAdd(this U15F17 x, U15F17 y) {
            return CheckedAdd(x, y) ?? U15F17.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 SaturatingAdd(
            this Vector2U15F17 x, Vector2U15F17 y
        ) => new Vector2U15F17(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 SaturatingAdd(
            this Vector3U15F17 x, Vector3U15F17 y
        ) => new Vector3U15F17(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 SaturatingAdd(
            this Vector4U15F17 x, Vector4U15F17 y
        ) => new Vector4U15F17(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U16F16 SaturatingAdd(this U16F16 x, U16F16 y) {
            return CheckedAdd(x, y) ?? U16F16.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 SaturatingAdd(
            this Vector2U16F16 x, Vector2U16F16 y
        ) => new Vector2U16F16(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 SaturatingAdd(
            this Vector3U16F16 x, Vector3U16F16 y
        ) => new Vector3U16F16(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 SaturatingAdd(
            this Vector4U16F16 x, Vector4U16F16 y
        ) => new Vector4U16F16(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15 SaturatingAdd(this U17F15 x, U17F15 y) {
            return CheckedAdd(x, y) ?? U17F15.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 SaturatingAdd(
            this Vector2U17F15 x, Vector2U17F15 y
        ) => new Vector2U17F15(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 SaturatingAdd(
            this Vector3U17F15 x, Vector3U17F15 y
        ) => new Vector3U17F15(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 SaturatingAdd(
            this Vector4U17F15 x, Vector4U17F15 y
        ) => new Vector4U17F15(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U18F14 SaturatingAdd(this U18F14 x, U18F14 y) {
            return CheckedAdd(x, y) ?? U18F14.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U18F14 SaturatingAdd(
            this Vector2U18F14 x, Vector2U18F14 y
        ) => new Vector2U18F14(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 SaturatingAdd(
            this Vector3U18F14 x, Vector3U18F14 y
        ) => new Vector3U18F14(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 SaturatingAdd(
            this Vector4U18F14 x, Vector4U18F14 y
        ) => new Vector4U18F14(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U19F13 SaturatingAdd(this U19F13 x, U19F13 y) {
            return CheckedAdd(x, y) ?? U19F13.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U19F13 SaturatingAdd(
            this Vector2U19F13 x, Vector2U19F13 y
        ) => new Vector2U19F13(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 SaturatingAdd(
            this Vector3U19F13 x, Vector3U19F13 y
        ) => new Vector3U19F13(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U19F13 SaturatingAdd(
            this Vector4U19F13 x, Vector4U19F13 y
        ) => new Vector4U19F13(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U20F12 SaturatingAdd(this U20F12 x, U20F12 y) {
            return CheckedAdd(x, y) ?? U20F12.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 SaturatingAdd(
            this Vector2U20F12 x, Vector2U20F12 y
        ) => new Vector2U20F12(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 SaturatingAdd(
            this Vector3U20F12 x, Vector3U20F12 y
        ) => new Vector3U20F12(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 SaturatingAdd(
            this Vector4U20F12 x, Vector4U20F12 y
        ) => new Vector4U20F12(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U21F11 SaturatingAdd(this U21F11 x, U21F11 y) {
            return CheckedAdd(x, y) ?? U21F11.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 SaturatingAdd(
            this Vector2U21F11 x, Vector2U21F11 y
        ) => new Vector2U21F11(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 SaturatingAdd(
            this Vector3U21F11 x, Vector3U21F11 y
        ) => new Vector3U21F11(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 SaturatingAdd(
            this Vector4U21F11 x, Vector4U21F11 y
        ) => new Vector4U21F11(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U22F10 SaturatingAdd(this U22F10 x, U22F10 y) {
            return CheckedAdd(x, y) ?? U22F10.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 SaturatingAdd(
            this Vector2U22F10 x, Vector2U22F10 y
        ) => new Vector2U22F10(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 SaturatingAdd(
            this Vector3U22F10 x, Vector3U22F10 y
        ) => new Vector3U22F10(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 SaturatingAdd(
            this Vector4U22F10 x, Vector4U22F10 y
        ) => new Vector4U22F10(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U23F9 SaturatingAdd(this U23F9 x, U23F9 y) {
            return CheckedAdd(x, y) ?? U23F9.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 SaturatingAdd(
            this Vector2U23F9 x, Vector2U23F9 y
        ) => new Vector2U23F9(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 SaturatingAdd(
            this Vector3U23F9 x, Vector3U23F9 y
        ) => new Vector3U23F9(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 SaturatingAdd(
            this Vector4U23F9 x, Vector4U23F9 y
        ) => new Vector4U23F9(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F8 SaturatingAdd(this U24F8 x, U24F8 y) {
            return CheckedAdd(x, y) ?? U24F8.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 SaturatingAdd(
            this Vector2U24F8 x, Vector2U24F8 y
        ) => new Vector2U24F8(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 SaturatingAdd(
            this Vector3U24F8 x, Vector3U24F8 y
        ) => new Vector3U24F8(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 SaturatingAdd(
            this Vector4U24F8 x, Vector4U24F8 y
        ) => new Vector4U24F8(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U25F7 SaturatingAdd(this U25F7 x, U25F7 y) {
            return CheckedAdd(x, y) ?? U25F7.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 SaturatingAdd(
            this Vector2U25F7 x, Vector2U25F7 y
        ) => new Vector2U25F7(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 SaturatingAdd(
            this Vector3U25F7 x, Vector3U25F7 y
        ) => new Vector3U25F7(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 SaturatingAdd(
            this Vector4U25F7 x, Vector4U25F7 y
        ) => new Vector4U25F7(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U26F6 SaturatingAdd(this U26F6 x, U26F6 y) {
            return CheckedAdd(x, y) ?? U26F6.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 SaturatingAdd(
            this Vector2U26F6 x, Vector2U26F6 y
        ) => new Vector2U26F6(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 SaturatingAdd(
            this Vector3U26F6 x, Vector3U26F6 y
        ) => new Vector3U26F6(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 SaturatingAdd(
            this Vector4U26F6 x, Vector4U26F6 y
        ) => new Vector4U26F6(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U27F5 SaturatingAdd(this U27F5 x, U27F5 y) {
            return CheckedAdd(x, y) ?? U27F5.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 SaturatingAdd(
            this Vector2U27F5 x, Vector2U27F5 y
        ) => new Vector2U27F5(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 SaturatingAdd(
            this Vector3U27F5 x, Vector3U27F5 y
        ) => new Vector3U27F5(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 SaturatingAdd(
            this Vector4U27F5 x, Vector4U27F5 y
        ) => new Vector4U27F5(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U28F4 SaturatingAdd(this U28F4 x, U28F4 y) {
            return CheckedAdd(x, y) ?? U28F4.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 SaturatingAdd(
            this Vector2U28F4 x, Vector2U28F4 y
        ) => new Vector2U28F4(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 SaturatingAdd(
            this Vector3U28F4 x, Vector3U28F4 y
        ) => new Vector3U28F4(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 SaturatingAdd(
            this Vector4U28F4 x, Vector4U28F4 y
        ) => new Vector4U28F4(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U29F3 SaturatingAdd(this U29F3 x, U29F3 y) {
            return CheckedAdd(x, y) ?? U29F3.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 SaturatingAdd(
            this Vector2U29F3 x, Vector2U29F3 y
        ) => new Vector2U29F3(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 SaturatingAdd(
            this Vector3U29F3 x, Vector3U29F3 y
        ) => new Vector3U29F3(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 SaturatingAdd(
            this Vector4U29F3 x, Vector4U29F3 y
        ) => new Vector4U29F3(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U30F2 SaturatingAdd(this U30F2 x, U30F2 y) {
            return CheckedAdd(x, y) ?? U30F2.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 SaturatingAdd(
            this Vector2U30F2 x, Vector2U30F2 y
        ) => new Vector2U30F2(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 SaturatingAdd(
            this Vector3U30F2 x, Vector3U30F2 y
        ) => new Vector3U30F2(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 SaturatingAdd(
            this Vector4U30F2 x, Vector4U30F2 y
        ) => new Vector4U30F2(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U31F1 SaturatingAdd(this U31F1 x, U31F1 y) {
            return CheckedAdd(x, y) ?? U31F1.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 SaturatingAdd(
            this Vector2U31F1 x, Vector2U31F1 y
        ) => new Vector2U31F1(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 SaturatingAdd(
            this Vector3U31F1 x, Vector3U31F1 y
        ) => new Vector3U31F1(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U31F1 SaturatingAdd(
            this Vector4U31F1 x, Vector4U31F1 y
        ) => new Vector4U31F1(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y),
            x.Z.SaturatingAdd(y.Z),
            x.W.SaturatingAdd(y.W));

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I2F30 x, I2F30 y, out I2F30 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I2F30.One.Bits;
            result = I2F30.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30? CheckedMul(this I2F30 x, I2F30 y) {
            I2F30? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 SaturatingMul(this I2F30 x, I2F30 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I2F30.MaxValue
            : I2F30.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I3F29 x, I3F29 y, out I3F29 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I3F29.One.Bits;
            result = I3F29.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F29? CheckedMul(this I3F29 x, I3F29 y) {
            I3F29? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F29 SaturatingMul(this I3F29 x, I3F29 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I3F29.MaxValue
            : I3F29.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I4F28 x, I4F28 y, out I4F28 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I4F28.One.Bits;
            result = I4F28.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F28? CheckedMul(this I4F28 x, I4F28 y) {
            I4F28? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F28 SaturatingMul(this I4F28 x, I4F28 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I4F28.MaxValue
            : I4F28.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I5F27 x, I5F27 y, out I5F27 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I5F27.One.Bits;
            result = I5F27.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I5F27? CheckedMul(this I5F27 x, I5F27 y) {
            I5F27? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I5F27 SaturatingMul(this I5F27 x, I5F27 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I5F27.MaxValue
            : I5F27.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I6F26 x, I6F26 y, out I6F26 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I6F26.One.Bits;
            result = I6F26.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I6F26? CheckedMul(this I6F26 x, I6F26 y) {
            I6F26? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I6F26 SaturatingMul(this I6F26 x, I6F26 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I6F26.MaxValue
            : I6F26.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I7F25 x, I7F25 y, out I7F25 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I7F25.One.Bits;
            result = I7F25.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I7F25? CheckedMul(this I7F25 x, I7F25 y) {
            I7F25? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I7F25 SaturatingMul(this I7F25 x, I7F25 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I7F25.MaxValue
            : I7F25.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I8F24 x, I8F24 y, out I8F24 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I8F24.One.Bits;
            result = I8F24.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F24? CheckedMul(this I8F24 x, I8F24 y) {
            I8F24? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F24 SaturatingMul(this I8F24 x, I8F24 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I8F24.MaxValue
            : I8F24.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I9F23 x, I9F23 y, out I9F23 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I9F23.One.Bits;
            result = I9F23.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I9F23? CheckedMul(this I9F23 x, I9F23 y) {
            I9F23? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I9F23 SaturatingMul(this I9F23 x, I9F23 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I9F23.MaxValue
            : I9F23.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I10F22 x, I10F22 y, out I10F22 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I10F22.One.Bits;
            result = I10F22.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I10F22? CheckedMul(this I10F22 x, I10F22 y) {
            I10F22? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I10F22 SaturatingMul(this I10F22 x, I10F22 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I10F22.MaxValue
            : I10F22.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I11F21 x, I11F21 y, out I11F21 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I11F21.One.Bits;
            result = I11F21.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I11F21? CheckedMul(this I11F21 x, I11F21 y) {
            I11F21? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I11F21 SaturatingMul(this I11F21 x, I11F21 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I11F21.MaxValue
            : I11F21.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I12F20 x, I12F20 y, out I12F20 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I12F20.One.Bits;
            result = I12F20.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I12F20? CheckedMul(this I12F20 x, I12F20 y) {
            I12F20? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I12F20 SaturatingMul(this I12F20 x, I12F20 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I12F20.MaxValue
            : I12F20.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I13F19 x, I13F19 y, out I13F19 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I13F19.One.Bits;
            result = I13F19.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I13F19? CheckedMul(this I13F19 x, I13F19 y) {
            I13F19? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I13F19 SaturatingMul(this I13F19 x, I13F19 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I13F19.MaxValue
            : I13F19.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I14F18 x, I14F18 y, out I14F18 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I14F18.One.Bits;
            result = I14F18.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I14F18? CheckedMul(this I14F18 x, I14F18 y) {
            I14F18? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I14F18 SaturatingMul(this I14F18 x, I14F18 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I14F18.MaxValue
            : I14F18.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I15F17 x, I15F17 y, out I15F17 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I15F17.One.Bits;
            result = I15F17.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I15F17? CheckedMul(this I15F17 x, I15F17 y) {
            I15F17? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I15F17 SaturatingMul(this I15F17 x, I15F17 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I15F17.MaxValue
            : I15F17.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I16F16 x, I16F16 y, out I16F16 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I16F16.One.Bits;
            result = I16F16.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I16F16? CheckedMul(this I16F16 x, I16F16 y) {
            I16F16? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I16F16 SaturatingMul(this I16F16 x, I16F16 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I16F16.MaxValue
            : I16F16.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I17F15 x, I17F15 y, out I17F15 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I17F15.One.Bits;
            result = I17F15.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15? CheckedMul(this I17F15 x, I17F15 y) {
            I17F15? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 SaturatingMul(this I17F15 x, I17F15 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I17F15.MaxValue
            : I17F15.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I18F14 x, I18F14 y, out I18F14 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I18F14.One.Bits;
            result = I18F14.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I18F14? CheckedMul(this I18F14 x, I18F14 y) {
            I18F14? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I18F14 SaturatingMul(this I18F14 x, I18F14 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I18F14.MaxValue
            : I18F14.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I19F13 x, I19F13 y, out I19F13 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I19F13.One.Bits;
            result = I19F13.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I19F13? CheckedMul(this I19F13 x, I19F13 y) {
            I19F13? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I19F13 SaturatingMul(this I19F13 x, I19F13 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I19F13.MaxValue
            : I19F13.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I20F12 x, I20F12 y, out I20F12 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I20F12.One.Bits;
            result = I20F12.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I20F12? CheckedMul(this I20F12 x, I20F12 y) {
            I20F12? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I20F12 SaturatingMul(this I20F12 x, I20F12 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I20F12.MaxValue
            : I20F12.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I21F11 x, I21F11 y, out I21F11 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I21F11.One.Bits;
            result = I21F11.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I21F11? CheckedMul(this I21F11 x, I21F11 y) {
            I21F11? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I21F11 SaturatingMul(this I21F11 x, I21F11 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I21F11.MaxValue
            : I21F11.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I22F10 x, I22F10 y, out I22F10 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I22F10.One.Bits;
            result = I22F10.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I22F10? CheckedMul(this I22F10 x, I22F10 y) {
            I22F10? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I22F10 SaturatingMul(this I22F10 x, I22F10 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I22F10.MaxValue
            : I22F10.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I23F9 x, I23F9 y, out I23F9 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I23F9.One.Bits;
            result = I23F9.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I23F9? CheckedMul(this I23F9 x, I23F9 y) {
            I23F9? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I23F9 SaturatingMul(this I23F9 x, I23F9 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I23F9.MaxValue
            : I23F9.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I24F8 x, I24F8 y, out I24F8 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I24F8.One.Bits;
            result = I24F8.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I24F8? CheckedMul(this I24F8 x, I24F8 y) {
            I24F8? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I24F8 SaturatingMul(this I24F8 x, I24F8 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I24F8.MaxValue
            : I24F8.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I25F7 x, I25F7 y, out I25F7 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I25F7.One.Bits;
            result = I25F7.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I25F7? CheckedMul(this I25F7 x, I25F7 y) {
            I25F7? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I25F7 SaturatingMul(this I25F7 x, I25F7 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I25F7.MaxValue
            : I25F7.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I26F6 x, I26F6 y, out I26F6 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I26F6.One.Bits;
            result = I26F6.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F6? CheckedMul(this I26F6 x, I26F6 y) {
            I26F6? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F6 SaturatingMul(this I26F6 x, I26F6 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I26F6.MaxValue
            : I26F6.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I27F5 x, I27F5 y, out I27F5 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I27F5.One.Bits;
            result = I27F5.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I27F5? CheckedMul(this I27F5 x, I27F5 y) {
            I27F5? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I27F5 SaturatingMul(this I27F5 x, I27F5 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I27F5.MaxValue
            : I27F5.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I28F4 x, I28F4 y, out I28F4 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I28F4.One.Bits;
            result = I28F4.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I28F4? CheckedMul(this I28F4 x, I28F4 y) {
            I28F4? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I28F4 SaturatingMul(this I28F4 x, I28F4 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I28F4.MaxValue
            : I28F4.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I29F3 x, I29F3 y, out I29F3 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I29F3.One.Bits;
            result = I29F3.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I29F3? CheckedMul(this I29F3 x, I29F3 y) {
            I29F3? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I29F3 SaturatingMul(this I29F3 x, I29F3 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I29F3.MaxValue
            : I29F3.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I30F2 x, I30F2 y, out I30F2 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I30F2.One.Bits;
            result = I30F2.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I30F2? CheckedMul(this I30F2 x, I30F2 y) {
            I30F2? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I30F2 SaturatingMul(this I30F2 x, I30F2 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I30F2.MaxValue
            : I30F2.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I31F1 x, I31F1 y, out I31F1 result) {
            long bits = x.Bits;
            bits *= y.Bits;
            bits /= I31F1.One.Bits;
            result = I31F1.FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I31F1? CheckedMul(this I31F1 x, I31F1 y) {
            I31F1? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I31F1 SaturatingMul(this I31F1 x, I31F1 y) => x.CheckedMul(y) ?? (
            ((x.Bits < 0) == (y.Bits < 0))
            ? I31F1.MaxValue
            : I31F1.MinValue
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U2F30 x, U2F30 y, out U2F30 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U2F30.One.Bits;
            result = U2F30.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30? CheckedMul(this U2F30 x, U2F30 y) {
            U2F30? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 SaturatingMul(this U2F30 x, U2F30 y) {
            return x.CheckedMul(y) ?? U2F30.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U3F29 x, U3F29 y, out U3F29 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U3F29.One.Bits;
            result = U3F29.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U3F29? CheckedMul(this U3F29 x, U3F29 y) {
            U3F29? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U3F29 SaturatingMul(this U3F29 x, U3F29 y) {
            return x.CheckedMul(y) ?? U3F29.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U4F28 x, U4F28 y, out U4F28 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U4F28.One.Bits;
            result = U4F28.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F28? CheckedMul(this U4F28 x, U4F28 y) {
            U4F28? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F28 SaturatingMul(this U4F28 x, U4F28 y) {
            return x.CheckedMul(y) ?? U4F28.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U5F27 x, U5F27 y, out U5F27 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U5F27.One.Bits;
            result = U5F27.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27? CheckedMul(this U5F27 x, U5F27 y) {
            U5F27? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27 SaturatingMul(this U5F27 x, U5F27 y) {
            return x.CheckedMul(y) ?? U5F27.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U6F26 x, U6F26 y, out U6F26 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U6F26.One.Bits;
            result = U6F26.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U6F26? CheckedMul(this U6F26 x, U6F26 y) {
            U6F26? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U6F26 SaturatingMul(this U6F26 x, U6F26 y) {
            return x.CheckedMul(y) ?? U6F26.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U7F25 x, U7F25 y, out U7F25 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U7F25.One.Bits;
            result = U7F25.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U7F25? CheckedMul(this U7F25 x, U7F25 y) {
            U7F25? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U7F25 SaturatingMul(this U7F25 x, U7F25 y) {
            return x.CheckedMul(y) ?? U7F25.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U8F24 x, U8F24 y, out U8F24 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U8F24.One.Bits;
            result = U8F24.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U8F24? CheckedMul(this U8F24 x, U8F24 y) {
            U8F24? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U8F24 SaturatingMul(this U8F24 x, U8F24 y) {
            return x.CheckedMul(y) ?? U8F24.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U9F23 x, U9F23 y, out U9F23 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U9F23.One.Bits;
            result = U9F23.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U9F23? CheckedMul(this U9F23 x, U9F23 y) {
            U9F23? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U9F23 SaturatingMul(this U9F23 x, U9F23 y) {
            return x.CheckedMul(y) ?? U9F23.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U10F22 x, U10F22 y, out U10F22 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U10F22.One.Bits;
            result = U10F22.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U10F22? CheckedMul(this U10F22 x, U10F22 y) {
            U10F22? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U10F22 SaturatingMul(this U10F22 x, U10F22 y) {
            return x.CheckedMul(y) ?? U10F22.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U11F21 x, U11F21 y, out U11F21 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U11F21.One.Bits;
            result = U11F21.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U11F21? CheckedMul(this U11F21 x, U11F21 y) {
            U11F21? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U11F21 SaturatingMul(this U11F21 x, U11F21 y) {
            return x.CheckedMul(y) ?? U11F21.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U12F20 x, U12F20 y, out U12F20 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U12F20.One.Bits;
            result = U12F20.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U12F20? CheckedMul(this U12F20 x, U12F20 y) {
            U12F20? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U12F20 SaturatingMul(this U12F20 x, U12F20 y) {
            return x.CheckedMul(y) ?? U12F20.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U13F19 x, U13F19 y, out U13F19 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U13F19.One.Bits;
            result = U13F19.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U13F19? CheckedMul(this U13F19 x, U13F19 y) {
            U13F19? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U13F19 SaturatingMul(this U13F19 x, U13F19 y) {
            return x.CheckedMul(y) ?? U13F19.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U14F18 x, U14F18 y, out U14F18 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U14F18.One.Bits;
            result = U14F18.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U14F18? CheckedMul(this U14F18 x, U14F18 y) {
            U14F18? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U14F18 SaturatingMul(this U14F18 x, U14F18 y) {
            return x.CheckedMul(y) ?? U14F18.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U15F17 x, U15F17 y, out U15F17 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U15F17.One.Bits;
            result = U15F17.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U15F17? CheckedMul(this U15F17 x, U15F17 y) {
            U15F17? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U15F17 SaturatingMul(this U15F17 x, U15F17 y) {
            return x.CheckedMul(y) ?? U15F17.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U16F16 x, U16F16 y, out U16F16 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U16F16.One.Bits;
            result = U16F16.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U16F16? CheckedMul(this U16F16 x, U16F16 y) {
            U16F16? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U16F16 SaturatingMul(this U16F16 x, U16F16 y) {
            return x.CheckedMul(y) ?? U16F16.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U17F15 x, U17F15 y, out U17F15 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U17F15.One.Bits;
            result = U17F15.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15? CheckedMul(this U17F15 x, U17F15 y) {
            U17F15? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15 SaturatingMul(this U17F15 x, U17F15 y) {
            return x.CheckedMul(y) ?? U17F15.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U18F14 x, U18F14 y, out U18F14 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U18F14.One.Bits;
            result = U18F14.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U18F14? CheckedMul(this U18F14 x, U18F14 y) {
            U18F14? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U18F14 SaturatingMul(this U18F14 x, U18F14 y) {
            return x.CheckedMul(y) ?? U18F14.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U19F13 x, U19F13 y, out U19F13 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U19F13.One.Bits;
            result = U19F13.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U19F13? CheckedMul(this U19F13 x, U19F13 y) {
            U19F13? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U19F13 SaturatingMul(this U19F13 x, U19F13 y) {
            return x.CheckedMul(y) ?? U19F13.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U20F12 x, U20F12 y, out U20F12 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U20F12.One.Bits;
            result = U20F12.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U20F12? CheckedMul(this U20F12 x, U20F12 y) {
            U20F12? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U20F12 SaturatingMul(this U20F12 x, U20F12 y) {
            return x.CheckedMul(y) ?? U20F12.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U21F11 x, U21F11 y, out U21F11 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U21F11.One.Bits;
            result = U21F11.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U21F11? CheckedMul(this U21F11 x, U21F11 y) {
            U21F11? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U21F11 SaturatingMul(this U21F11 x, U21F11 y) {
            return x.CheckedMul(y) ?? U21F11.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U22F10 x, U22F10 y, out U22F10 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U22F10.One.Bits;
            result = U22F10.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U22F10? CheckedMul(this U22F10 x, U22F10 y) {
            U22F10? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U22F10 SaturatingMul(this U22F10 x, U22F10 y) {
            return x.CheckedMul(y) ?? U22F10.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U23F9 x, U23F9 y, out U23F9 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U23F9.One.Bits;
            result = U23F9.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U23F9? CheckedMul(this U23F9 x, U23F9 y) {
            U23F9? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U23F9 SaturatingMul(this U23F9 x, U23F9 y) {
            return x.CheckedMul(y) ?? U23F9.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U24F8 x, U24F8 y, out U24F8 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U24F8.One.Bits;
            result = U24F8.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F8? CheckedMul(this U24F8 x, U24F8 y) {
            U24F8? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F8 SaturatingMul(this U24F8 x, U24F8 y) {
            return x.CheckedMul(y) ?? U24F8.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U25F7 x, U25F7 y, out U25F7 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U25F7.One.Bits;
            result = U25F7.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U25F7? CheckedMul(this U25F7 x, U25F7 y) {
            U25F7? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U25F7 SaturatingMul(this U25F7 x, U25F7 y) {
            return x.CheckedMul(y) ?? U25F7.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U26F6 x, U26F6 y, out U26F6 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U26F6.One.Bits;
            result = U26F6.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U26F6? CheckedMul(this U26F6 x, U26F6 y) {
            U26F6? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U26F6 SaturatingMul(this U26F6 x, U26F6 y) {
            return x.CheckedMul(y) ?? U26F6.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U27F5 x, U27F5 y, out U27F5 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U27F5.One.Bits;
            result = U27F5.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U27F5? CheckedMul(this U27F5 x, U27F5 y) {
            U27F5? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U27F5 SaturatingMul(this U27F5 x, U27F5 y) {
            return x.CheckedMul(y) ?? U27F5.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U28F4 x, U28F4 y, out U28F4 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U28F4.One.Bits;
            result = U28F4.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U28F4? CheckedMul(this U28F4 x, U28F4 y) {
            U28F4? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U28F4 SaturatingMul(this U28F4 x, U28F4 y) {
            return x.CheckedMul(y) ?? U28F4.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U29F3 x, U29F3 y, out U29F3 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U29F3.One.Bits;
            result = U29F3.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U29F3? CheckedMul(this U29F3 x, U29F3 y) {
            U29F3? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U29F3 SaturatingMul(this U29F3 x, U29F3 y) {
            return x.CheckedMul(y) ?? U29F3.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U30F2 x, U30F2 y, out U30F2 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U30F2.One.Bits;
            result = U30F2.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U30F2? CheckedMul(this U30F2 x, U30F2 y) {
            U30F2? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U30F2 SaturatingMul(this U30F2 x, U30F2 y) {
            return x.CheckedMul(y) ?? U30F2.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U31F1 x, U31F1 y, out U31F1 result) {
            ulong bits = x.Bits;
            bits *= y.Bits;
            bits /= U31F1.One.Bits;
            result = U31F1.FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U31F1? CheckedMul(this U31F1 x, U31F1 y) {
            U31F1? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U31F1 SaturatingMul(this U31F1 x, U31F1 y) {
            return x.CheckedMul(y) ?? U31F1.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 SaturatingMul(this I2F30 x, Vector2I2F30 y) {
            return new Vector2I2F30(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 SaturatingMul(this Vector2I2F30 x, I2F30 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 SaturatingMul(this I3F29 x, Vector2I3F29 y) {
            return new Vector2I3F29(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 SaturatingMul(this Vector2I3F29 x, I3F29 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 SaturatingMul(this I4F28 x, Vector2I4F28 y) {
            return new Vector2I4F28(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 SaturatingMul(this Vector2I4F28 x, I4F28 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 SaturatingMul(this I5F27 x, Vector2I5F27 y) {
            return new Vector2I5F27(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 SaturatingMul(this Vector2I5F27 x, I5F27 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 SaturatingMul(this I6F26 x, Vector2I6F26 y) {
            return new Vector2I6F26(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 SaturatingMul(this Vector2I6F26 x, I6F26 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 SaturatingMul(this I7F25 x, Vector2I7F25 y) {
            return new Vector2I7F25(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 SaturatingMul(this Vector2I7F25 x, I7F25 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 SaturatingMul(this I8F24 x, Vector2I8F24 y) {
            return new Vector2I8F24(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 SaturatingMul(this Vector2I8F24 x, I8F24 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 SaturatingMul(this I9F23 x, Vector2I9F23 y) {
            return new Vector2I9F23(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 SaturatingMul(this Vector2I9F23 x, I9F23 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I10F22 SaturatingMul(this I10F22 x, Vector2I10F22 y) {
            return new Vector2I10F22(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I10F22 SaturatingMul(this Vector2I10F22 x, I10F22 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 SaturatingMul(this I11F21 x, Vector2I11F21 y) {
            return new Vector2I11F21(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 SaturatingMul(this Vector2I11F21 x, I11F21 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 SaturatingMul(this I12F20 x, Vector2I12F20 y) {
            return new Vector2I12F20(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 SaturatingMul(this Vector2I12F20 x, I12F20 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 SaturatingMul(this I13F19 x, Vector2I13F19 y) {
            return new Vector2I13F19(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 SaturatingMul(this Vector2I13F19 x, I13F19 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 SaturatingMul(this I14F18 x, Vector2I14F18 y) {
            return new Vector2I14F18(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 SaturatingMul(this Vector2I14F18 x, I14F18 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 SaturatingMul(this I15F17 x, Vector2I15F17 y) {
            return new Vector2I15F17(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 SaturatingMul(this Vector2I15F17 x, I15F17 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 SaturatingMul(this I16F16 x, Vector2I16F16 y) {
            return new Vector2I16F16(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 SaturatingMul(this Vector2I16F16 x, I16F16 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 SaturatingMul(this I17F15 x, Vector2I17F15 y) {
            return new Vector2I17F15(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 SaturatingMul(this Vector2I17F15 x, I17F15 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 SaturatingMul(this I18F14 x, Vector2I18F14 y) {
            return new Vector2I18F14(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 SaturatingMul(this Vector2I18F14 x, I18F14 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 SaturatingMul(this I19F13 x, Vector2I19F13 y) {
            return new Vector2I19F13(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 SaturatingMul(this Vector2I19F13 x, I19F13 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 SaturatingMul(this I20F12 x, Vector2I20F12 y) {
            return new Vector2I20F12(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 SaturatingMul(this Vector2I20F12 x, I20F12 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 SaturatingMul(this I21F11 x, Vector2I21F11 y) {
            return new Vector2I21F11(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 SaturatingMul(this Vector2I21F11 x, I21F11 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I22F10 SaturatingMul(this I22F10 x, Vector2I22F10 y) {
            return new Vector2I22F10(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I22F10 SaturatingMul(this Vector2I22F10 x, I22F10 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 SaturatingMul(this I23F9 x, Vector2I23F9 y) {
            return new Vector2I23F9(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 SaturatingMul(this Vector2I23F9 x, I23F9 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 SaturatingMul(this I24F8 x, Vector2I24F8 y) {
            return new Vector2I24F8(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 SaturatingMul(this Vector2I24F8 x, I24F8 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 SaturatingMul(this I25F7 x, Vector2I25F7 y) {
            return new Vector2I25F7(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 SaturatingMul(this Vector2I25F7 x, I25F7 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 SaturatingMul(this I26F6 x, Vector2I26F6 y) {
            return new Vector2I26F6(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 SaturatingMul(this Vector2I26F6 x, I26F6 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 SaturatingMul(this I27F5 x, Vector2I27F5 y) {
            return new Vector2I27F5(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 SaturatingMul(this Vector2I27F5 x, I27F5 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 SaturatingMul(this I28F4 x, Vector2I28F4 y) {
            return new Vector2I28F4(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 SaturatingMul(this Vector2I28F4 x, I28F4 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 SaturatingMul(this I29F3 x, Vector2I29F3 y) {
            return new Vector2I29F3(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 SaturatingMul(this Vector2I29F3 x, I29F3 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 SaturatingMul(this I30F2 x, Vector2I30F2 y) {
            return new Vector2I30F2(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 SaturatingMul(this Vector2I30F2 x, I30F2 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 SaturatingMul(this I31F1 x, Vector2I31F1 y) {
            return new Vector2I31F1(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 SaturatingMul(this Vector2I31F1 x, I31F1 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U2F30 SaturatingMul(this U2F30 x, Vector2U2F30 y) {
            return new Vector2U2F30(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U2F30 SaturatingMul(this Vector2U2F30 x, U2F30 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 SaturatingMul(this U3F29 x, Vector2U3F29 y) {
            return new Vector2U3F29(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 SaturatingMul(this Vector2U3F29 x, U3F29 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 SaturatingMul(this U4F28 x, Vector2U4F28 y) {
            return new Vector2U4F28(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 SaturatingMul(this Vector2U4F28 x, U4F28 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 SaturatingMul(this U5F27 x, Vector2U5F27 y) {
            return new Vector2U5F27(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 SaturatingMul(this Vector2U5F27 x, U5F27 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 SaturatingMul(this U6F26 x, Vector2U6F26 y) {
            return new Vector2U6F26(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 SaturatingMul(this Vector2U6F26 x, U6F26 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 SaturatingMul(this U7F25 x, Vector2U7F25 y) {
            return new Vector2U7F25(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 SaturatingMul(this Vector2U7F25 x, U7F25 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 SaturatingMul(this U8F24 x, Vector2U8F24 y) {
            return new Vector2U8F24(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 SaturatingMul(this Vector2U8F24 x, U8F24 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 SaturatingMul(this U9F23 x, Vector2U9F23 y) {
            return new Vector2U9F23(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 SaturatingMul(this Vector2U9F23 x, U9F23 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 SaturatingMul(this U10F22 x, Vector2U10F22 y) {
            return new Vector2U10F22(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 SaturatingMul(this Vector2U10F22 x, U10F22 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 SaturatingMul(this U11F21 x, Vector2U11F21 y) {
            return new Vector2U11F21(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 SaturatingMul(this Vector2U11F21 x, U11F21 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 SaturatingMul(this U12F20 x, Vector2U12F20 y) {
            return new Vector2U12F20(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 SaturatingMul(this Vector2U12F20 x, U12F20 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 SaturatingMul(this U13F19 x, Vector2U13F19 y) {
            return new Vector2U13F19(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 SaturatingMul(this Vector2U13F19 x, U13F19 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 SaturatingMul(this U14F18 x, Vector2U14F18 y) {
            return new Vector2U14F18(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 SaturatingMul(this Vector2U14F18 x, U14F18 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 SaturatingMul(this U15F17 x, Vector2U15F17 y) {
            return new Vector2U15F17(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 SaturatingMul(this Vector2U15F17 x, U15F17 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 SaturatingMul(this U16F16 x, Vector2U16F16 y) {
            return new Vector2U16F16(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 SaturatingMul(this Vector2U16F16 x, U16F16 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 SaturatingMul(this U17F15 x, Vector2U17F15 y) {
            return new Vector2U17F15(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 SaturatingMul(this Vector2U17F15 x, U17F15 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U18F14 SaturatingMul(this U18F14 x, Vector2U18F14 y) {
            return new Vector2U18F14(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U18F14 SaturatingMul(this Vector2U18F14 x, U18F14 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U19F13 SaturatingMul(this U19F13 x, Vector2U19F13 y) {
            return new Vector2U19F13(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U19F13 SaturatingMul(this Vector2U19F13 x, U19F13 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 SaturatingMul(this U20F12 x, Vector2U20F12 y) {
            return new Vector2U20F12(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 SaturatingMul(this Vector2U20F12 x, U20F12 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 SaturatingMul(this U21F11 x, Vector2U21F11 y) {
            return new Vector2U21F11(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 SaturatingMul(this Vector2U21F11 x, U21F11 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 SaturatingMul(this U22F10 x, Vector2U22F10 y) {
            return new Vector2U22F10(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 SaturatingMul(this Vector2U22F10 x, U22F10 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 SaturatingMul(this U23F9 x, Vector2U23F9 y) {
            return new Vector2U23F9(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 SaturatingMul(this Vector2U23F9 x, U23F9 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 SaturatingMul(this U24F8 x, Vector2U24F8 y) {
            return new Vector2U24F8(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 SaturatingMul(this Vector2U24F8 x, U24F8 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 SaturatingMul(this U25F7 x, Vector2U25F7 y) {
            return new Vector2U25F7(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 SaturatingMul(this Vector2U25F7 x, U25F7 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 SaturatingMul(this U26F6 x, Vector2U26F6 y) {
            return new Vector2U26F6(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 SaturatingMul(this Vector2U26F6 x, U26F6 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 SaturatingMul(this U27F5 x, Vector2U27F5 y) {
            return new Vector2U27F5(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 SaturatingMul(this Vector2U27F5 x, U27F5 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 SaturatingMul(this U28F4 x, Vector2U28F4 y) {
            return new Vector2U28F4(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 SaturatingMul(this Vector2U28F4 x, U28F4 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 SaturatingMul(this U29F3 x, Vector2U29F3 y) {
            return new Vector2U29F3(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 SaturatingMul(this Vector2U29F3 x, U29F3 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 SaturatingMul(this U30F2 x, Vector2U30F2 y) {
            return new Vector2U30F2(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 SaturatingMul(this Vector2U30F2 x, U30F2 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 SaturatingMul(this U31F1 x, Vector2U31F1 y) {
            return new Vector2U31F1(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 SaturatingMul(this Vector2U31F1 x, U31F1 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 SaturatingMul(this I2F30 x, Vector3I2F30 y) {
            return new Vector3I2F30(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 SaturatingMul(this Vector3I2F30 x, I2F30 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 SaturatingMul(this I3F29 x, Vector3I3F29 y) {
            return new Vector3I3F29(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 SaturatingMul(this Vector3I3F29 x, I3F29 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 SaturatingMul(this I4F28 x, Vector3I4F28 y) {
            return new Vector3I4F28(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 SaturatingMul(this Vector3I4F28 x, I4F28 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 SaturatingMul(this I5F27 x, Vector3I5F27 y) {
            return new Vector3I5F27(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 SaturatingMul(this Vector3I5F27 x, I5F27 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 SaturatingMul(this I6F26 x, Vector3I6F26 y) {
            return new Vector3I6F26(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 SaturatingMul(this Vector3I6F26 x, I6F26 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 SaturatingMul(this I7F25 x, Vector3I7F25 y) {
            return new Vector3I7F25(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 SaturatingMul(this Vector3I7F25 x, I7F25 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 SaturatingMul(this I8F24 x, Vector3I8F24 y) {
            return new Vector3I8F24(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 SaturatingMul(this Vector3I8F24 x, I8F24 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 SaturatingMul(this I9F23 x, Vector3I9F23 y) {
            return new Vector3I9F23(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 SaturatingMul(this Vector3I9F23 x, I9F23 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 SaturatingMul(this I10F22 x, Vector3I10F22 y) {
            return new Vector3I10F22(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 SaturatingMul(this Vector3I10F22 x, I10F22 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 SaturatingMul(this I11F21 x, Vector3I11F21 y) {
            return new Vector3I11F21(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 SaturatingMul(this Vector3I11F21 x, I11F21 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 SaturatingMul(this I12F20 x, Vector3I12F20 y) {
            return new Vector3I12F20(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 SaturatingMul(this Vector3I12F20 x, I12F20 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 SaturatingMul(this I13F19 x, Vector3I13F19 y) {
            return new Vector3I13F19(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 SaturatingMul(this Vector3I13F19 x, I13F19 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 SaturatingMul(this I14F18 x, Vector3I14F18 y) {
            return new Vector3I14F18(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 SaturatingMul(this Vector3I14F18 x, I14F18 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 SaturatingMul(this I15F17 x, Vector3I15F17 y) {
            return new Vector3I15F17(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 SaturatingMul(this Vector3I15F17 x, I15F17 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 SaturatingMul(this I16F16 x, Vector3I16F16 y) {
            return new Vector3I16F16(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 SaturatingMul(this Vector3I16F16 x, I16F16 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 SaturatingMul(this I17F15 x, Vector3I17F15 y) {
            return new Vector3I17F15(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 SaturatingMul(this Vector3I17F15 x, I17F15 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 SaturatingMul(this I18F14 x, Vector3I18F14 y) {
            return new Vector3I18F14(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 SaturatingMul(this Vector3I18F14 x, I18F14 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 SaturatingMul(this I19F13 x, Vector3I19F13 y) {
            return new Vector3I19F13(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 SaturatingMul(this Vector3I19F13 x, I19F13 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 SaturatingMul(this I20F12 x, Vector3I20F12 y) {
            return new Vector3I20F12(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 SaturatingMul(this Vector3I20F12 x, I20F12 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 SaturatingMul(this I21F11 x, Vector3I21F11 y) {
            return new Vector3I21F11(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 SaturatingMul(this Vector3I21F11 x, I21F11 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 SaturatingMul(this I22F10 x, Vector3I22F10 y) {
            return new Vector3I22F10(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 SaturatingMul(this Vector3I22F10 x, I22F10 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 SaturatingMul(this I23F9 x, Vector3I23F9 y) {
            return new Vector3I23F9(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 SaturatingMul(this Vector3I23F9 x, I23F9 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 SaturatingMul(this I24F8 x, Vector3I24F8 y) {
            return new Vector3I24F8(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 SaturatingMul(this Vector3I24F8 x, I24F8 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 SaturatingMul(this I25F7 x, Vector3I25F7 y) {
            return new Vector3I25F7(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 SaturatingMul(this Vector3I25F7 x, I25F7 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 SaturatingMul(this I26F6 x, Vector3I26F6 y) {
            return new Vector3I26F6(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 SaturatingMul(this Vector3I26F6 x, I26F6 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 SaturatingMul(this I27F5 x, Vector3I27F5 y) {
            return new Vector3I27F5(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 SaturatingMul(this Vector3I27F5 x, I27F5 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 SaturatingMul(this I28F4 x, Vector3I28F4 y) {
            return new Vector3I28F4(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 SaturatingMul(this Vector3I28F4 x, I28F4 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 SaturatingMul(this I29F3 x, Vector3I29F3 y) {
            return new Vector3I29F3(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 SaturatingMul(this Vector3I29F3 x, I29F3 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 SaturatingMul(this I30F2 x, Vector3I30F2 y) {
            return new Vector3I30F2(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 SaturatingMul(this Vector3I30F2 x, I30F2 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 SaturatingMul(this I31F1 x, Vector3I31F1 y) {
            return new Vector3I31F1(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 SaturatingMul(this Vector3I31F1 x, I31F1 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 SaturatingMul(this U2F30 x, Vector3U2F30 y) {
            return new Vector3U2F30(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 SaturatingMul(this Vector3U2F30 x, U2F30 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 SaturatingMul(this U3F29 x, Vector3U3F29 y) {
            return new Vector3U3F29(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 SaturatingMul(this Vector3U3F29 x, U3F29 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 SaturatingMul(this U4F28 x, Vector3U4F28 y) {
            return new Vector3U4F28(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 SaturatingMul(this Vector3U4F28 x, U4F28 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 SaturatingMul(this U5F27 x, Vector3U5F27 y) {
            return new Vector3U5F27(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 SaturatingMul(this Vector3U5F27 x, U5F27 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 SaturatingMul(this U6F26 x, Vector3U6F26 y) {
            return new Vector3U6F26(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 SaturatingMul(this Vector3U6F26 x, U6F26 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 SaturatingMul(this U7F25 x, Vector3U7F25 y) {
            return new Vector3U7F25(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 SaturatingMul(this Vector3U7F25 x, U7F25 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 SaturatingMul(this U8F24 x, Vector3U8F24 y) {
            return new Vector3U8F24(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 SaturatingMul(this Vector3U8F24 x, U8F24 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 SaturatingMul(this U9F23 x, Vector3U9F23 y) {
            return new Vector3U9F23(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 SaturatingMul(this Vector3U9F23 x, U9F23 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 SaturatingMul(this U10F22 x, Vector3U10F22 y) {
            return new Vector3U10F22(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 SaturatingMul(this Vector3U10F22 x, U10F22 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 SaturatingMul(this U11F21 x, Vector3U11F21 y) {
            return new Vector3U11F21(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 SaturatingMul(this Vector3U11F21 x, U11F21 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 SaturatingMul(this U12F20 x, Vector3U12F20 y) {
            return new Vector3U12F20(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 SaturatingMul(this Vector3U12F20 x, U12F20 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 SaturatingMul(this U13F19 x, Vector3U13F19 y) {
            return new Vector3U13F19(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 SaturatingMul(this Vector3U13F19 x, U13F19 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 SaturatingMul(this U14F18 x, Vector3U14F18 y) {
            return new Vector3U14F18(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 SaturatingMul(this Vector3U14F18 x, U14F18 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 SaturatingMul(this U15F17 x, Vector3U15F17 y) {
            return new Vector3U15F17(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 SaturatingMul(this Vector3U15F17 x, U15F17 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 SaturatingMul(this U16F16 x, Vector3U16F16 y) {
            return new Vector3U16F16(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 SaturatingMul(this Vector3U16F16 x, U16F16 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 SaturatingMul(this U17F15 x, Vector3U17F15 y) {
            return new Vector3U17F15(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 SaturatingMul(this Vector3U17F15 x, U17F15 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 SaturatingMul(this U18F14 x, Vector3U18F14 y) {
            return new Vector3U18F14(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 SaturatingMul(this Vector3U18F14 x, U18F14 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 SaturatingMul(this U19F13 x, Vector3U19F13 y) {
            return new Vector3U19F13(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 SaturatingMul(this Vector3U19F13 x, U19F13 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 SaturatingMul(this U20F12 x, Vector3U20F12 y) {
            return new Vector3U20F12(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 SaturatingMul(this Vector3U20F12 x, U20F12 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 SaturatingMul(this U21F11 x, Vector3U21F11 y) {
            return new Vector3U21F11(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 SaturatingMul(this Vector3U21F11 x, U21F11 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 SaturatingMul(this U22F10 x, Vector3U22F10 y) {
            return new Vector3U22F10(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 SaturatingMul(this Vector3U22F10 x, U22F10 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 SaturatingMul(this U23F9 x, Vector3U23F9 y) {
            return new Vector3U23F9(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 SaturatingMul(this Vector3U23F9 x, U23F9 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 SaturatingMul(this U24F8 x, Vector3U24F8 y) {
            return new Vector3U24F8(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 SaturatingMul(this Vector3U24F8 x, U24F8 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 SaturatingMul(this U25F7 x, Vector3U25F7 y) {
            return new Vector3U25F7(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 SaturatingMul(this Vector3U25F7 x, U25F7 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 SaturatingMul(this U26F6 x, Vector3U26F6 y) {
            return new Vector3U26F6(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 SaturatingMul(this Vector3U26F6 x, U26F6 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 SaturatingMul(this U27F5 x, Vector3U27F5 y) {
            return new Vector3U27F5(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 SaturatingMul(this Vector3U27F5 x, U27F5 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 SaturatingMul(this U28F4 x, Vector3U28F4 y) {
            return new Vector3U28F4(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 SaturatingMul(this Vector3U28F4 x, U28F4 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 SaturatingMul(this U29F3 x, Vector3U29F3 y) {
            return new Vector3U29F3(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 SaturatingMul(this Vector3U29F3 x, U29F3 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 SaturatingMul(this U30F2 x, Vector3U30F2 y) {
            return new Vector3U30F2(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 SaturatingMul(this Vector3U30F2 x, U30F2 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 SaturatingMul(this U31F1 x, Vector3U31F1 y) {
            return new Vector3U31F1(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 SaturatingMul(this Vector3U31F1 x, U31F1 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 SaturatingMul(this I2F30 x, Vector4I2F30 y) {
            return new Vector4I2F30(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 SaturatingMul(this Vector4I2F30 x, I2F30 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 SaturatingMul(this I3F29 x, Vector4I3F29 y) {
            return new Vector4I3F29(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 SaturatingMul(this Vector4I3F29 x, I3F29 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 SaturatingMul(this I4F28 x, Vector4I4F28 y) {
            return new Vector4I4F28(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 SaturatingMul(this Vector4I4F28 x, I4F28 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 SaturatingMul(this I5F27 x, Vector4I5F27 y) {
            return new Vector4I5F27(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 SaturatingMul(this Vector4I5F27 x, I5F27 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 SaturatingMul(this I6F26 x, Vector4I6F26 y) {
            return new Vector4I6F26(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 SaturatingMul(this Vector4I6F26 x, I6F26 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 SaturatingMul(this I7F25 x, Vector4I7F25 y) {
            return new Vector4I7F25(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 SaturatingMul(this Vector4I7F25 x, I7F25 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 SaturatingMul(this I8F24 x, Vector4I8F24 y) {
            return new Vector4I8F24(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 SaturatingMul(this Vector4I8F24 x, I8F24 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 SaturatingMul(this I9F23 x, Vector4I9F23 y) {
            return new Vector4I9F23(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 SaturatingMul(this Vector4I9F23 x, I9F23 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 SaturatingMul(this I10F22 x, Vector4I10F22 y) {
            return new Vector4I10F22(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 SaturatingMul(this Vector4I10F22 x, I10F22 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 SaturatingMul(this I11F21 x, Vector4I11F21 y) {
            return new Vector4I11F21(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 SaturatingMul(this Vector4I11F21 x, I11F21 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 SaturatingMul(this I12F20 x, Vector4I12F20 y) {
            return new Vector4I12F20(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 SaturatingMul(this Vector4I12F20 x, I12F20 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 SaturatingMul(this I13F19 x, Vector4I13F19 y) {
            return new Vector4I13F19(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 SaturatingMul(this Vector4I13F19 x, I13F19 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 SaturatingMul(this I14F18 x, Vector4I14F18 y) {
            return new Vector4I14F18(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 SaturatingMul(this Vector4I14F18 x, I14F18 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 SaturatingMul(this I15F17 x, Vector4I15F17 y) {
            return new Vector4I15F17(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 SaturatingMul(this Vector4I15F17 x, I15F17 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I16F16 SaturatingMul(this I16F16 x, Vector4I16F16 y) {
            return new Vector4I16F16(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I16F16 SaturatingMul(this Vector4I16F16 x, I16F16 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 SaturatingMul(this I17F15 x, Vector4I17F15 y) {
            return new Vector4I17F15(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 SaturatingMul(this Vector4I17F15 x, I17F15 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 SaturatingMul(this I18F14 x, Vector4I18F14 y) {
            return new Vector4I18F14(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 SaturatingMul(this Vector4I18F14 x, I18F14 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 SaturatingMul(this I19F13 x, Vector4I19F13 y) {
            return new Vector4I19F13(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 SaturatingMul(this Vector4I19F13 x, I19F13 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 SaturatingMul(this I20F12 x, Vector4I20F12 y) {
            return new Vector4I20F12(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 SaturatingMul(this Vector4I20F12 x, I20F12 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 SaturatingMul(this I21F11 x, Vector4I21F11 y) {
            return new Vector4I21F11(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 SaturatingMul(this Vector4I21F11 x, I21F11 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I22F10 SaturatingMul(this I22F10 x, Vector4I22F10 y) {
            return new Vector4I22F10(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I22F10 SaturatingMul(this Vector4I22F10 x, I22F10 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 SaturatingMul(this I23F9 x, Vector4I23F9 y) {
            return new Vector4I23F9(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 SaturatingMul(this Vector4I23F9 x, I23F9 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 SaturatingMul(this I24F8 x, Vector4I24F8 y) {
            return new Vector4I24F8(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 SaturatingMul(this Vector4I24F8 x, I24F8 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 SaturatingMul(this I25F7 x, Vector4I25F7 y) {
            return new Vector4I25F7(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 SaturatingMul(this Vector4I25F7 x, I25F7 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 SaturatingMul(this I26F6 x, Vector4I26F6 y) {
            return new Vector4I26F6(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 SaturatingMul(this Vector4I26F6 x, I26F6 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 SaturatingMul(this I27F5 x, Vector4I27F5 y) {
            return new Vector4I27F5(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 SaturatingMul(this Vector4I27F5 x, I27F5 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 SaturatingMul(this I28F4 x, Vector4I28F4 y) {
            return new Vector4I28F4(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 SaturatingMul(this Vector4I28F4 x, I28F4 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 SaturatingMul(this I29F3 x, Vector4I29F3 y) {
            return new Vector4I29F3(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 SaturatingMul(this Vector4I29F3 x, I29F3 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 SaturatingMul(this I30F2 x, Vector4I30F2 y) {
            return new Vector4I30F2(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 SaturatingMul(this Vector4I30F2 x, I30F2 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 SaturatingMul(this I31F1 x, Vector4I31F1 y) {
            return new Vector4I31F1(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 SaturatingMul(this Vector4I31F1 x, I31F1 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 SaturatingMul(this U2F30 x, Vector4U2F30 y) {
            return new Vector4U2F30(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 SaturatingMul(this Vector4U2F30 x, U2F30 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 SaturatingMul(this U3F29 x, Vector4U3F29 y) {
            return new Vector4U3F29(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 SaturatingMul(this Vector4U3F29 x, U3F29 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 SaturatingMul(this U4F28 x, Vector4U4F28 y) {
            return new Vector4U4F28(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 SaturatingMul(this Vector4U4F28 x, U4F28 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 SaturatingMul(this U5F27 x, Vector4U5F27 y) {
            return new Vector4U5F27(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 SaturatingMul(this Vector4U5F27 x, U5F27 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 SaturatingMul(this U6F26 x, Vector4U6F26 y) {
            return new Vector4U6F26(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 SaturatingMul(this Vector4U6F26 x, U6F26 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 SaturatingMul(this U7F25 x, Vector4U7F25 y) {
            return new Vector4U7F25(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 SaturatingMul(this Vector4U7F25 x, U7F25 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 SaturatingMul(this U8F24 x, Vector4U8F24 y) {
            return new Vector4U8F24(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 SaturatingMul(this Vector4U8F24 x, U8F24 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 SaturatingMul(this U9F23 x, Vector4U9F23 y) {
            return new Vector4U9F23(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 SaturatingMul(this Vector4U9F23 x, U9F23 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 SaturatingMul(this U10F22 x, Vector4U10F22 y) {
            return new Vector4U10F22(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 SaturatingMul(this Vector4U10F22 x, U10F22 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 SaturatingMul(this U11F21 x, Vector4U11F21 y) {
            return new Vector4U11F21(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 SaturatingMul(this Vector4U11F21 x, U11F21 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U12F20 SaturatingMul(this U12F20 x, Vector4U12F20 y) {
            return new Vector4U12F20(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U12F20 SaturatingMul(this Vector4U12F20 x, U12F20 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 SaturatingMul(this U13F19 x, Vector4U13F19 y) {
            return new Vector4U13F19(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 SaturatingMul(this Vector4U13F19 x, U13F19 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 SaturatingMul(this U14F18 x, Vector4U14F18 y) {
            return new Vector4U14F18(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 SaturatingMul(this Vector4U14F18 x, U14F18 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 SaturatingMul(this U15F17 x, Vector4U15F17 y) {
            return new Vector4U15F17(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 SaturatingMul(this Vector4U15F17 x, U15F17 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 SaturatingMul(this U16F16 x, Vector4U16F16 y) {
            return new Vector4U16F16(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 SaturatingMul(this Vector4U16F16 x, U16F16 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 SaturatingMul(this U17F15 x, Vector4U17F15 y) {
            return new Vector4U17F15(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 SaturatingMul(this Vector4U17F15 x, U17F15 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 SaturatingMul(this U18F14 x, Vector4U18F14 y) {
            return new Vector4U18F14(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 SaturatingMul(this Vector4U18F14 x, U18F14 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U19F13 SaturatingMul(this U19F13 x, Vector4U19F13 y) {
            return new Vector4U19F13(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U19F13 SaturatingMul(this Vector4U19F13 x, U19F13 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 SaturatingMul(this U20F12 x, Vector4U20F12 y) {
            return new Vector4U20F12(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 SaturatingMul(this Vector4U20F12 x, U20F12 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 SaturatingMul(this U21F11 x, Vector4U21F11 y) {
            return new Vector4U21F11(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 SaturatingMul(this Vector4U21F11 x, U21F11 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 SaturatingMul(this U22F10 x, Vector4U22F10 y) {
            return new Vector4U22F10(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 SaturatingMul(this Vector4U22F10 x, U22F10 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 SaturatingMul(this U23F9 x, Vector4U23F9 y) {
            return new Vector4U23F9(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 SaturatingMul(this Vector4U23F9 x, U23F9 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 SaturatingMul(this U24F8 x, Vector4U24F8 y) {
            return new Vector4U24F8(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 SaturatingMul(this Vector4U24F8 x, U24F8 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 SaturatingMul(this U25F7 x, Vector4U25F7 y) {
            return new Vector4U25F7(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 SaturatingMul(this Vector4U25F7 x, U25F7 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 SaturatingMul(this U26F6 x, Vector4U26F6 y) {
            return new Vector4U26F6(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 SaturatingMul(this Vector4U26F6 x, U26F6 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 SaturatingMul(this U27F5 x, Vector4U27F5 y) {
            return new Vector4U27F5(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 SaturatingMul(this Vector4U27F5 x, U27F5 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 SaturatingMul(this U28F4 x, Vector4U28F4 y) {
            return new Vector4U28F4(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 SaturatingMul(this Vector4U28F4 x, U28F4 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 SaturatingMul(this U29F3 x, Vector4U29F3 y) {
            return new Vector4U29F3(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 SaturatingMul(this Vector4U29F3 x, U29F3 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 SaturatingMul(this U30F2 x, Vector4U30F2 y) {
            return new Vector4U30F2(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 SaturatingMul(this Vector4U30F2 x, U30F2 y) {
            return y.SaturatingMul(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U31F1 SaturatingMul(this U31F1 x, Vector4U31F1 y) {
            return new Vector4U31F1(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U31F1 SaturatingMul(this Vector4U31F1 x, U31F1 y) {
            return y.SaturatingMul(x);
        }

    }
}
