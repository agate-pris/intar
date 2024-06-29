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
        public static int SaturatingMul(int x, int y) {
            return CheckedMul(x, y) ?? ((x < 0) == (y < 0)
                ? int.MaxValue
                : int.MinValue);
        }

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
        public static uint SaturatingMul(uint x, uint y) {
            return CheckedMul(x, y) ?? uint.MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I2F30 x, I2F30 y, out I2F30 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I2F30.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30? CheckedMul(this I2F30 x, I2F30 y) {
            I2F30? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 SaturatingMul(this I2F30 x, I2F30 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I2F30.MaxValue
                : I2F30.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I3F29 x, I3F29 y, out I3F29 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I3F29.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F29? CheckedMul(this I3F29 x, I3F29 y) {
            I3F29? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F29 SaturatingMul(this I3F29 x, I3F29 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I3F29.MaxValue
                : I3F29.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I4F28 x, I4F28 y, out I4F28 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I4F28.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F28? CheckedMul(this I4F28 x, I4F28 y) {
            I4F28? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F28 SaturatingMul(this I4F28 x, I4F28 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I4F28.MaxValue
                : I4F28.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I5F27 x, I5F27 y, out I5F27 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I5F27.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I5F27? CheckedMul(this I5F27 x, I5F27 y) {
            I5F27? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I5F27 SaturatingMul(this I5F27 x, I5F27 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I5F27.MaxValue
                : I5F27.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I6F26 x, I6F26 y, out I6F26 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I6F26.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I6F26? CheckedMul(this I6F26 x, I6F26 y) {
            I6F26? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I6F26 SaturatingMul(this I6F26 x, I6F26 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I6F26.MaxValue
                : I6F26.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I7F25 x, I7F25 y, out I7F25 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I7F25.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I7F25? CheckedMul(this I7F25 x, I7F25 y) {
            I7F25? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I7F25 SaturatingMul(this I7F25 x, I7F25 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I7F25.MaxValue
                : I7F25.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I8F24 x, I8F24 y, out I8F24 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I8F24.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F24? CheckedMul(this I8F24 x, I8F24 y) {
            I8F24? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F24 SaturatingMul(this I8F24 x, I8F24 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I8F24.MaxValue
                : I8F24.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I9F23 x, I9F23 y, out I9F23 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I9F23.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I9F23? CheckedMul(this I9F23 x, I9F23 y) {
            I9F23? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I9F23 SaturatingMul(this I9F23 x, I9F23 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I9F23.MaxValue
                : I9F23.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I10F22 x, I10F22 y, out I10F22 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I10F22.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I10F22? CheckedMul(this I10F22 x, I10F22 y) {
            I10F22? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I10F22 SaturatingMul(this I10F22 x, I10F22 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I10F22.MaxValue
                : I10F22.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I11F21 x, I11F21 y, out I11F21 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I11F21.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I11F21? CheckedMul(this I11F21 x, I11F21 y) {
            I11F21? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I11F21 SaturatingMul(this I11F21 x, I11F21 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I11F21.MaxValue
                : I11F21.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I12F20 x, I12F20 y, out I12F20 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I12F20.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I12F20? CheckedMul(this I12F20 x, I12F20 y) {
            I12F20? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I12F20 SaturatingMul(this I12F20 x, I12F20 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I12F20.MaxValue
                : I12F20.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I13F19 x, I13F19 y, out I13F19 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I13F19.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I13F19? CheckedMul(this I13F19 x, I13F19 y) {
            I13F19? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I13F19 SaturatingMul(this I13F19 x, I13F19 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I13F19.MaxValue
                : I13F19.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I14F18 x, I14F18 y, out I14F18 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I14F18.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I14F18? CheckedMul(this I14F18 x, I14F18 y) {
            I14F18? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I14F18 SaturatingMul(this I14F18 x, I14F18 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I14F18.MaxValue
                : I14F18.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I15F17 x, I15F17 y, out I15F17 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I15F17.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I15F17? CheckedMul(this I15F17 x, I15F17 y) {
            I15F17? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I15F17 SaturatingMul(this I15F17 x, I15F17 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I15F17.MaxValue
                : I15F17.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I16F16 x, I16F16 y, out I16F16 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I16F16.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I16F16? CheckedMul(this I16F16 x, I16F16 y) {
            I16F16? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I16F16 SaturatingMul(this I16F16 x, I16F16 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I16F16.MaxValue
                : I16F16.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I17F15 x, I17F15 y, out I17F15 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I17F15.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15? CheckedMul(this I17F15 x, I17F15 y) {
            I17F15? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 SaturatingMul(this I17F15 x, I17F15 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I17F15.MaxValue
                : I17F15.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I18F14 x, I18F14 y, out I18F14 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I18F14.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I18F14? CheckedMul(this I18F14 x, I18F14 y) {
            I18F14? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I18F14 SaturatingMul(this I18F14 x, I18F14 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I18F14.MaxValue
                : I18F14.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I19F13 x, I19F13 y, out I19F13 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I19F13.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I19F13? CheckedMul(this I19F13 x, I19F13 y) {
            I19F13? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I19F13 SaturatingMul(this I19F13 x, I19F13 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I19F13.MaxValue
                : I19F13.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I20F12 x, I20F12 y, out I20F12 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I20F12.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I20F12? CheckedMul(this I20F12 x, I20F12 y) {
            I20F12? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I20F12 SaturatingMul(this I20F12 x, I20F12 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I20F12.MaxValue
                : I20F12.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I21F11 x, I21F11 y, out I21F11 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I21F11.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I21F11? CheckedMul(this I21F11 x, I21F11 y) {
            I21F11? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I21F11 SaturatingMul(this I21F11 x, I21F11 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I21F11.MaxValue
                : I21F11.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I22F10 x, I22F10 y, out I22F10 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I22F10.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I22F10? CheckedMul(this I22F10 x, I22F10 y) {
            I22F10? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I22F10 SaturatingMul(this I22F10 x, I22F10 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I22F10.MaxValue
                : I22F10.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I23F9 x, I23F9 y, out I23F9 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I23F9.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I23F9? CheckedMul(this I23F9 x, I23F9 y) {
            I23F9? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I23F9 SaturatingMul(this I23F9 x, I23F9 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I23F9.MaxValue
                : I23F9.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I24F8 x, I24F8 y, out I24F8 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I24F8.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I24F8? CheckedMul(this I24F8 x, I24F8 y) {
            I24F8? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I24F8 SaturatingMul(this I24F8 x, I24F8 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I24F8.MaxValue
                : I24F8.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I25F7 x, I25F7 y, out I25F7 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I25F7.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I25F7? CheckedMul(this I25F7 x, I25F7 y) {
            I25F7? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I25F7 SaturatingMul(this I25F7 x, I25F7 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I25F7.MaxValue
                : I25F7.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I26F6 x, I26F6 y, out I26F6 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I26F6.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F6? CheckedMul(this I26F6 x, I26F6 y) {
            I26F6? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F6 SaturatingMul(this I26F6 x, I26F6 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I26F6.MaxValue
                : I26F6.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I27F5 x, I27F5 y, out I27F5 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I27F5.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I27F5? CheckedMul(this I27F5 x, I27F5 y) {
            I27F5? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I27F5 SaturatingMul(this I27F5 x, I27F5 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I27F5.MaxValue
                : I27F5.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I28F4 x, I28F4 y, out I28F4 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I28F4.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I28F4? CheckedMul(this I28F4 x, I28F4 y) {
            I28F4? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I28F4 SaturatingMul(this I28F4 x, I28F4 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I28F4.MaxValue
                : I28F4.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I29F3 x, I29F3 y, out I29F3 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I29F3.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I29F3? CheckedMul(this I29F3 x, I29F3 y) {
            I29F3? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I29F3 SaturatingMul(this I29F3 x, I29F3 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I29F3.MaxValue
                : I29F3.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I30F2 x, I30F2 y, out I30F2 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I30F2.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I30F2? CheckedMul(this I30F2 x, I30F2 y) {
            I30F2? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I30F2 SaturatingMul(this I30F2 x, I30F2 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I30F2.MaxValue
                : I30F2.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this I31F1 x, I31F1 y, out I31F1 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = I31F1.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I31F1? CheckedMul(this I31F1 x, I31F1 y) {
            I31F1? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I31F1 SaturatingMul(this I31F1 x, I31F1 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? I31F1.MaxValue
                : I31F1.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U2F30 x, U2F30 y, out U2F30 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U2F30.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30? CheckedMul(this U2F30 x, U2F30 y) {
            U2F30? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 SaturatingMul(this U2F30 x, U2F30 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U2F30.MaxValue
                : U2F30.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U3F29 x, U3F29 y, out U3F29 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U3F29.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U3F29? CheckedMul(this U3F29 x, U3F29 y) {
            U3F29? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U3F29 SaturatingMul(this U3F29 x, U3F29 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U3F29.MaxValue
                : U3F29.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U4F28 x, U4F28 y, out U4F28 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U4F28.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F28? CheckedMul(this U4F28 x, U4F28 y) {
            U4F28? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F28 SaturatingMul(this U4F28 x, U4F28 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U4F28.MaxValue
                : U4F28.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U5F27 x, U5F27 y, out U5F27 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U5F27.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27? CheckedMul(this U5F27 x, U5F27 y) {
            U5F27? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27 SaturatingMul(this U5F27 x, U5F27 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U5F27.MaxValue
                : U5F27.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U6F26 x, U6F26 y, out U6F26 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U6F26.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U6F26? CheckedMul(this U6F26 x, U6F26 y) {
            U6F26? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U6F26 SaturatingMul(this U6F26 x, U6F26 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U6F26.MaxValue
                : U6F26.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U7F25 x, U7F25 y, out U7F25 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U7F25.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U7F25? CheckedMul(this U7F25 x, U7F25 y) {
            U7F25? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U7F25 SaturatingMul(this U7F25 x, U7F25 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U7F25.MaxValue
                : U7F25.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U8F24 x, U8F24 y, out U8F24 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U8F24.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U8F24? CheckedMul(this U8F24 x, U8F24 y) {
            U8F24? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U8F24 SaturatingMul(this U8F24 x, U8F24 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U8F24.MaxValue
                : U8F24.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U9F23 x, U9F23 y, out U9F23 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U9F23.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U9F23? CheckedMul(this U9F23 x, U9F23 y) {
            U9F23? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U9F23 SaturatingMul(this U9F23 x, U9F23 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U9F23.MaxValue
                : U9F23.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U10F22 x, U10F22 y, out U10F22 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U10F22.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U10F22? CheckedMul(this U10F22 x, U10F22 y) {
            U10F22? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U10F22 SaturatingMul(this U10F22 x, U10F22 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U10F22.MaxValue
                : U10F22.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U11F21 x, U11F21 y, out U11F21 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U11F21.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U11F21? CheckedMul(this U11F21 x, U11F21 y) {
            U11F21? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U11F21 SaturatingMul(this U11F21 x, U11F21 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U11F21.MaxValue
                : U11F21.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U12F20 x, U12F20 y, out U12F20 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U12F20.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U12F20? CheckedMul(this U12F20 x, U12F20 y) {
            U12F20? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U12F20 SaturatingMul(this U12F20 x, U12F20 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U12F20.MaxValue
                : U12F20.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U13F19 x, U13F19 y, out U13F19 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U13F19.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U13F19? CheckedMul(this U13F19 x, U13F19 y) {
            U13F19? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U13F19 SaturatingMul(this U13F19 x, U13F19 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U13F19.MaxValue
                : U13F19.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U14F18 x, U14F18 y, out U14F18 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U14F18.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U14F18? CheckedMul(this U14F18 x, U14F18 y) {
            U14F18? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U14F18 SaturatingMul(this U14F18 x, U14F18 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U14F18.MaxValue
                : U14F18.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U15F17 x, U15F17 y, out U15F17 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U15F17.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U15F17? CheckedMul(this U15F17 x, U15F17 y) {
            U15F17? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U15F17 SaturatingMul(this U15F17 x, U15F17 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U15F17.MaxValue
                : U15F17.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U16F16 x, U16F16 y, out U16F16 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U16F16.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U16F16? CheckedMul(this U16F16 x, U16F16 y) {
            U16F16? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U16F16 SaturatingMul(this U16F16 x, U16F16 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U16F16.MaxValue
                : U16F16.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U17F15 x, U17F15 y, out U17F15 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U17F15.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15? CheckedMul(this U17F15 x, U17F15 y) {
            U17F15? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15 SaturatingMul(this U17F15 x, U17F15 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U17F15.MaxValue
                : U17F15.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U18F14 x, U18F14 y, out U18F14 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U18F14.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U18F14? CheckedMul(this U18F14 x, U18F14 y) {
            U18F14? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U18F14 SaturatingMul(this U18F14 x, U18F14 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U18F14.MaxValue
                : U18F14.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U19F13 x, U19F13 y, out U19F13 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U19F13.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U19F13? CheckedMul(this U19F13 x, U19F13 y) {
            U19F13? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U19F13 SaturatingMul(this U19F13 x, U19F13 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U19F13.MaxValue
                : U19F13.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U20F12 x, U20F12 y, out U20F12 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U20F12.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U20F12? CheckedMul(this U20F12 x, U20F12 y) {
            U20F12? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U20F12 SaturatingMul(this U20F12 x, U20F12 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U20F12.MaxValue
                : U20F12.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U21F11 x, U21F11 y, out U21F11 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U21F11.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U21F11? CheckedMul(this U21F11 x, U21F11 y) {
            U21F11? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U21F11 SaturatingMul(this U21F11 x, U21F11 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U21F11.MaxValue
                : U21F11.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U22F10 x, U22F10 y, out U22F10 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U22F10.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U22F10? CheckedMul(this U22F10 x, U22F10 y) {
            U22F10? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U22F10 SaturatingMul(this U22F10 x, U22F10 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U22F10.MaxValue
                : U22F10.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U23F9 x, U23F9 y, out U23F9 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U23F9.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U23F9? CheckedMul(this U23F9 x, U23F9 y) {
            U23F9? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U23F9 SaturatingMul(this U23F9 x, U23F9 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U23F9.MaxValue
                : U23F9.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U24F8 x, U24F8 y, out U24F8 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U24F8.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F8? CheckedMul(this U24F8 x, U24F8 y) {
            U24F8? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F8 SaturatingMul(this U24F8 x, U24F8 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U24F8.MaxValue
                : U24F8.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U25F7 x, U25F7 y, out U25F7 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U25F7.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U25F7? CheckedMul(this U25F7 x, U25F7 y) {
            U25F7? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U25F7 SaturatingMul(this U25F7 x, U25F7 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U25F7.MaxValue
                : U25F7.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U26F6 x, U26F6 y, out U26F6 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U26F6.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U26F6? CheckedMul(this U26F6 x, U26F6 y) {
            U26F6? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U26F6 SaturatingMul(this U26F6 x, U26F6 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U26F6.MaxValue
                : U26F6.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U27F5 x, U27F5 y, out U27F5 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U27F5.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U27F5? CheckedMul(this U27F5 x, U27F5 y) {
            U27F5? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U27F5 SaturatingMul(this U27F5 x, U27F5 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U27F5.MaxValue
                : U27F5.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U28F4 x, U28F4 y, out U28F4 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U28F4.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U28F4? CheckedMul(this U28F4 x, U28F4 y) {
            U28F4? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U28F4 SaturatingMul(this U28F4 x, U28F4 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U28F4.MaxValue
                : U28F4.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U29F3 x, U29F3 y, out U29F3 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U29F3.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U29F3? CheckedMul(this U29F3 x, U29F3 y) {
            U29F3? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U29F3 SaturatingMul(this U29F3 x, U29F3 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U29F3.MaxValue
                : U29F3.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U30F2 x, U30F2 y, out U30F2 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U30F2.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U30F2? CheckedMul(this U30F2 x, U30F2 y) {
            U30F2? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U30F2 SaturatingMul(this U30F2 x, U30F2 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U30F2.MaxValue
                : U30F2.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OverflowingMul(this U31F1 x, U31F1 y, out U31F1 result) {
            var b = OverflowingMul(x.Bits, y.Bits, out var bits);
            result = U31F1.FromBits(bits);
            return b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U31F1? CheckedMul(this U31F1 x, U31F1 y) {
            U31F1? @null = null;
            return x.OverflowingMul(y, out var result) ? @null : result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U31F1 SaturatingMul(this U31F1 x, U31F1 y) {
            return x.CheckedMul(y) ?? ((x.Bits < 0) == (y.Bits < 0)
                ? U31F1.MaxValue
                : U31F1.MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 SaturatingMul(this I2F30 x, Vector2I2F30 y) {
            return new Vector2I2F30(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I2F30 SaturatingMul(this Vector2I2F30 x, I2F30 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 SaturatingMul(this I3F29 x, Vector2I3F29 y) {
            return new Vector2I3F29(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I3F29 SaturatingMul(this Vector2I3F29 x, I3F29 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 SaturatingMul(this I4F28 x, Vector2I4F28 y) {
            return new Vector2I4F28(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I4F28 SaturatingMul(this Vector2I4F28 x, I4F28 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 SaturatingMul(this I5F27 x, Vector2I5F27 y) {
            return new Vector2I5F27(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I5F27 SaturatingMul(this Vector2I5F27 x, I5F27 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 SaturatingMul(this I6F26 x, Vector2I6F26 y) {
            return new Vector2I6F26(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I6F26 SaturatingMul(this Vector2I6F26 x, I6F26 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 SaturatingMul(this I7F25 x, Vector2I7F25 y) {
            return new Vector2I7F25(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I7F25 SaturatingMul(this Vector2I7F25 x, I7F25 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 SaturatingMul(this I8F24 x, Vector2I8F24 y) {
            return new Vector2I8F24(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I8F24 SaturatingMul(this Vector2I8F24 x, I8F24 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 SaturatingMul(this I9F23 x, Vector2I9F23 y) {
            return new Vector2I9F23(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I9F23 SaturatingMul(this Vector2I9F23 x, I9F23 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I10F22 SaturatingMul(this I10F22 x, Vector2I10F22 y) {
            return new Vector2I10F22(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I10F22 SaturatingMul(this Vector2I10F22 x, I10F22 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 SaturatingMul(this I11F21 x, Vector2I11F21 y) {
            return new Vector2I11F21(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I11F21 SaturatingMul(this Vector2I11F21 x, I11F21 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 SaturatingMul(this I12F20 x, Vector2I12F20 y) {
            return new Vector2I12F20(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I12F20 SaturatingMul(this Vector2I12F20 x, I12F20 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 SaturatingMul(this I13F19 x, Vector2I13F19 y) {
            return new Vector2I13F19(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I13F19 SaturatingMul(this Vector2I13F19 x, I13F19 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 SaturatingMul(this I14F18 x, Vector2I14F18 y) {
            return new Vector2I14F18(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I14F18 SaturatingMul(this Vector2I14F18 x, I14F18 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 SaturatingMul(this I15F17 x, Vector2I15F17 y) {
            return new Vector2I15F17(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I15F17 SaturatingMul(this Vector2I15F17 x, I15F17 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 SaturatingMul(this I16F16 x, Vector2I16F16 y) {
            return new Vector2I16F16(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I16F16 SaturatingMul(this Vector2I16F16 x, I16F16 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 SaturatingMul(this I17F15 x, Vector2I17F15 y) {
            return new Vector2I17F15(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I17F15 SaturatingMul(this Vector2I17F15 x, I17F15 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 SaturatingMul(this I18F14 x, Vector2I18F14 y) {
            return new Vector2I18F14(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I18F14 SaturatingMul(this Vector2I18F14 x, I18F14 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 SaturatingMul(this I19F13 x, Vector2I19F13 y) {
            return new Vector2I19F13(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I19F13 SaturatingMul(this Vector2I19F13 x, I19F13 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 SaturatingMul(this I20F12 x, Vector2I20F12 y) {
            return new Vector2I20F12(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I20F12 SaturatingMul(this Vector2I20F12 x, I20F12 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 SaturatingMul(this I21F11 x, Vector2I21F11 y) {
            return new Vector2I21F11(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I21F11 SaturatingMul(this Vector2I21F11 x, I21F11 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I22F10 SaturatingMul(this I22F10 x, Vector2I22F10 y) {
            return new Vector2I22F10(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I22F10 SaturatingMul(this Vector2I22F10 x, I22F10 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 SaturatingMul(this I23F9 x, Vector2I23F9 y) {
            return new Vector2I23F9(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I23F9 SaturatingMul(this Vector2I23F9 x, I23F9 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 SaturatingMul(this I24F8 x, Vector2I24F8 y) {
            return new Vector2I24F8(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I24F8 SaturatingMul(this Vector2I24F8 x, I24F8 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 SaturatingMul(this I25F7 x, Vector2I25F7 y) {
            return new Vector2I25F7(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I25F7 SaturatingMul(this Vector2I25F7 x, I25F7 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 SaturatingMul(this I26F6 x, Vector2I26F6 y) {
            return new Vector2I26F6(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I26F6 SaturatingMul(this Vector2I26F6 x, I26F6 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 SaturatingMul(this I27F5 x, Vector2I27F5 y) {
            return new Vector2I27F5(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I27F5 SaturatingMul(this Vector2I27F5 x, I27F5 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 SaturatingMul(this I28F4 x, Vector2I28F4 y) {
            return new Vector2I28F4(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I28F4 SaturatingMul(this Vector2I28F4 x, I28F4 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 SaturatingMul(this I29F3 x, Vector2I29F3 y) {
            return new Vector2I29F3(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I29F3 SaturatingMul(this Vector2I29F3 x, I29F3 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 SaturatingMul(this I30F2 x, Vector2I30F2 y) {
            return new Vector2I30F2(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I30F2 SaturatingMul(this Vector2I30F2 x, I30F2 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 SaturatingMul(this I31F1 x, Vector2I31F1 y) {
            return new Vector2I31F1(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2I31F1 SaturatingMul(this Vector2I31F1 x, I31F1 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U2F30 SaturatingMul(this U2F30 x, Vector2U2F30 y) {
            return new Vector2U2F30(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U2F30 SaturatingMul(this Vector2U2F30 x, U2F30 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 SaturatingMul(this U3F29 x, Vector2U3F29 y) {
            return new Vector2U3F29(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U3F29 SaturatingMul(this Vector2U3F29 x, U3F29 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 SaturatingMul(this U4F28 x, Vector2U4F28 y) {
            return new Vector2U4F28(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U4F28 SaturatingMul(this Vector2U4F28 x, U4F28 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 SaturatingMul(this U5F27 x, Vector2U5F27 y) {
            return new Vector2U5F27(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U5F27 SaturatingMul(this Vector2U5F27 x, U5F27 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 SaturatingMul(this U6F26 x, Vector2U6F26 y) {
            return new Vector2U6F26(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U6F26 SaturatingMul(this Vector2U6F26 x, U6F26 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 SaturatingMul(this U7F25 x, Vector2U7F25 y) {
            return new Vector2U7F25(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U7F25 SaturatingMul(this Vector2U7F25 x, U7F25 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 SaturatingMul(this U8F24 x, Vector2U8F24 y) {
            return new Vector2U8F24(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U8F24 SaturatingMul(this Vector2U8F24 x, U8F24 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 SaturatingMul(this U9F23 x, Vector2U9F23 y) {
            return new Vector2U9F23(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U9F23 SaturatingMul(this Vector2U9F23 x, U9F23 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 SaturatingMul(this U10F22 x, Vector2U10F22 y) {
            return new Vector2U10F22(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U10F22 SaturatingMul(this Vector2U10F22 x, U10F22 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 SaturatingMul(this U11F21 x, Vector2U11F21 y) {
            return new Vector2U11F21(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U11F21 SaturatingMul(this Vector2U11F21 x, U11F21 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 SaturatingMul(this U12F20 x, Vector2U12F20 y) {
            return new Vector2U12F20(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U12F20 SaturatingMul(this Vector2U12F20 x, U12F20 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 SaturatingMul(this U13F19 x, Vector2U13F19 y) {
            return new Vector2U13F19(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U13F19 SaturatingMul(this Vector2U13F19 x, U13F19 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 SaturatingMul(this U14F18 x, Vector2U14F18 y) {
            return new Vector2U14F18(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U14F18 SaturatingMul(this Vector2U14F18 x, U14F18 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 SaturatingMul(this U15F17 x, Vector2U15F17 y) {
            return new Vector2U15F17(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U15F17 SaturatingMul(this Vector2U15F17 x, U15F17 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 SaturatingMul(this U16F16 x, Vector2U16F16 y) {
            return new Vector2U16F16(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U16F16 SaturatingMul(this Vector2U16F16 x, U16F16 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 SaturatingMul(this U17F15 x, Vector2U17F15 y) {
            return new Vector2U17F15(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U17F15 SaturatingMul(this Vector2U17F15 x, U17F15 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U18F14 SaturatingMul(this U18F14 x, Vector2U18F14 y) {
            return new Vector2U18F14(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U18F14 SaturatingMul(this Vector2U18F14 x, U18F14 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U19F13 SaturatingMul(this U19F13 x, Vector2U19F13 y) {
            return new Vector2U19F13(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U19F13 SaturatingMul(this Vector2U19F13 x, U19F13 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 SaturatingMul(this U20F12 x, Vector2U20F12 y) {
            return new Vector2U20F12(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U20F12 SaturatingMul(this Vector2U20F12 x, U20F12 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 SaturatingMul(this U21F11 x, Vector2U21F11 y) {
            return new Vector2U21F11(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U21F11 SaturatingMul(this Vector2U21F11 x, U21F11 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 SaturatingMul(this U22F10 x, Vector2U22F10 y) {
            return new Vector2U22F10(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U22F10 SaturatingMul(this Vector2U22F10 x, U22F10 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 SaturatingMul(this U23F9 x, Vector2U23F9 y) {
            return new Vector2U23F9(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U23F9 SaturatingMul(this Vector2U23F9 x, U23F9 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 SaturatingMul(this U24F8 x, Vector2U24F8 y) {
            return new Vector2U24F8(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U24F8 SaturatingMul(this Vector2U24F8 x, U24F8 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 SaturatingMul(this U25F7 x, Vector2U25F7 y) {
            return new Vector2U25F7(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U25F7 SaturatingMul(this Vector2U25F7 x, U25F7 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 SaturatingMul(this U26F6 x, Vector2U26F6 y) {
            return new Vector2U26F6(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U26F6 SaturatingMul(this Vector2U26F6 x, U26F6 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 SaturatingMul(this U27F5 x, Vector2U27F5 y) {
            return new Vector2U27F5(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U27F5 SaturatingMul(this Vector2U27F5 x, U27F5 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 SaturatingMul(this U28F4 x, Vector2U28F4 y) {
            return new Vector2U28F4(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U28F4 SaturatingMul(this Vector2U28F4 x, U28F4 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 SaturatingMul(this U29F3 x, Vector2U29F3 y) {
            return new Vector2U29F3(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U29F3 SaturatingMul(this Vector2U29F3 x, U29F3 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 SaturatingMul(this U30F2 x, Vector2U30F2 y) {
            return new Vector2U30F2(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U30F2 SaturatingMul(this Vector2U30F2 x, U30F2 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 SaturatingMul(this U31F1 x, Vector2U31F1 y) {
            return new Vector2U31F1(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector2U31F1 SaturatingMul(this Vector2U31F1 x, U31F1 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 SaturatingMul(this I2F30 x, Vector3I2F30 y) {
            return new Vector3I2F30(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I2F30 SaturatingMul(this Vector3I2F30 x, I2F30 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I3F29 SaturatingMul(this I3F29 x, Vector3I3F29 y) {
            return new Vector3I3F29(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I3F29 SaturatingMul(this Vector3I3F29 x, I3F29 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F28 SaturatingMul(this I4F28 x, Vector3I4F28 y) {
            return new Vector3I4F28(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I4F28 SaturatingMul(this Vector3I4F28 x, I4F28 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I5F27 SaturatingMul(this I5F27 x, Vector3I5F27 y) {
            return new Vector3I5F27(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I5F27 SaturatingMul(this Vector3I5F27 x, I5F27 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 SaturatingMul(this I6F26 x, Vector3I6F26 y) {
            return new Vector3I6F26(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I6F26 SaturatingMul(this Vector3I6F26 x, I6F26 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I7F25 SaturatingMul(this I7F25 x, Vector3I7F25 y) {
            return new Vector3I7F25(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I7F25 SaturatingMul(this Vector3I7F25 x, I7F25 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F24 SaturatingMul(this I8F24 x, Vector3I8F24 y) {
            return new Vector3I8F24(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I8F24 SaturatingMul(this Vector3I8F24 x, I8F24 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I9F23 SaturatingMul(this I9F23 x, Vector3I9F23 y) {
            return new Vector3I9F23(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I9F23 SaturatingMul(this Vector3I9F23 x, I9F23 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 SaturatingMul(this I10F22 x, Vector3I10F22 y) {
            return new Vector3I10F22(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I10F22 SaturatingMul(this Vector3I10F22 x, I10F22 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I11F21 SaturatingMul(this I11F21 x, Vector3I11F21 y) {
            return new Vector3I11F21(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I11F21 SaturatingMul(this Vector3I11F21 x, I11F21 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 SaturatingMul(this I12F20 x, Vector3I12F20 y) {
            return new Vector3I12F20(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I12F20 SaturatingMul(this Vector3I12F20 x, I12F20 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I13F19 SaturatingMul(this I13F19 x, Vector3I13F19 y) {
            return new Vector3I13F19(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I13F19 SaturatingMul(this Vector3I13F19 x, I13F19 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I14F18 SaturatingMul(this I14F18 x, Vector3I14F18 y) {
            return new Vector3I14F18(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I14F18 SaturatingMul(this Vector3I14F18 x, I14F18 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I15F17 SaturatingMul(this I15F17 x, Vector3I15F17 y) {
            return new Vector3I15F17(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I15F17 SaturatingMul(this Vector3I15F17 x, I15F17 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I16F16 SaturatingMul(this I16F16 x, Vector3I16F16 y) {
            return new Vector3I16F16(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I16F16 SaturatingMul(this Vector3I16F16 x, I16F16 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 SaturatingMul(this I17F15 x, Vector3I17F15 y) {
            return new Vector3I17F15(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I17F15 SaturatingMul(this Vector3I17F15 x, I17F15 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I18F14 SaturatingMul(this I18F14 x, Vector3I18F14 y) {
            return new Vector3I18F14(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I18F14 SaturatingMul(this Vector3I18F14 x, I18F14 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I19F13 SaturatingMul(this I19F13 x, Vector3I19F13 y) {
            return new Vector3I19F13(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I19F13 SaturatingMul(this Vector3I19F13 x, I19F13 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I20F12 SaturatingMul(this I20F12 x, Vector3I20F12 y) {
            return new Vector3I20F12(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I20F12 SaturatingMul(this Vector3I20F12 x, I20F12 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I21F11 SaturatingMul(this I21F11 x, Vector3I21F11 y) {
            return new Vector3I21F11(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I21F11 SaturatingMul(this Vector3I21F11 x, I21F11 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I22F10 SaturatingMul(this I22F10 x, Vector3I22F10 y) {
            return new Vector3I22F10(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I22F10 SaturatingMul(this Vector3I22F10 x, I22F10 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I23F9 SaturatingMul(this I23F9 x, Vector3I23F9 y) {
            return new Vector3I23F9(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I23F9 SaturatingMul(this Vector3I23F9 x, I23F9 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I24F8 SaturatingMul(this I24F8 x, Vector3I24F8 y) {
            return new Vector3I24F8(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I24F8 SaturatingMul(this Vector3I24F8 x, I24F8 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I25F7 SaturatingMul(this I25F7 x, Vector3I25F7 y) {
            return new Vector3I25F7(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I25F7 SaturatingMul(this Vector3I25F7 x, I25F7 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I26F6 SaturatingMul(this I26F6 x, Vector3I26F6 y) {
            return new Vector3I26F6(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I26F6 SaturatingMul(this Vector3I26F6 x, I26F6 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I27F5 SaturatingMul(this I27F5 x, Vector3I27F5 y) {
            return new Vector3I27F5(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I27F5 SaturatingMul(this Vector3I27F5 x, I27F5 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I28F4 SaturatingMul(this I28F4 x, Vector3I28F4 y) {
            return new Vector3I28F4(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I28F4 SaturatingMul(this Vector3I28F4 x, I28F4 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I29F3 SaturatingMul(this I29F3 x, Vector3I29F3 y) {
            return new Vector3I29F3(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I29F3 SaturatingMul(this Vector3I29F3 x, I29F3 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 SaturatingMul(this I30F2 x, Vector3I30F2 y) {
            return new Vector3I30F2(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I30F2 SaturatingMul(this Vector3I30F2 x, I30F2 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I31F1 SaturatingMul(this I31F1 x, Vector3I31F1 y) {
            return new Vector3I31F1(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3I31F1 SaturatingMul(this Vector3I31F1 x, I31F1 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U2F30 SaturatingMul(this U2F30 x, Vector3U2F30 y) {
            return new Vector3U2F30(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U2F30 SaturatingMul(this Vector3U2F30 x, U2F30 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U3F29 SaturatingMul(this U3F29 x, Vector3U3F29 y) {
            return new Vector3U3F29(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U3F29 SaturatingMul(this Vector3U3F29 x, U3F29 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U4F28 SaturatingMul(this U4F28 x, Vector3U4F28 y) {
            return new Vector3U4F28(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U4F28 SaturatingMul(this Vector3U4F28 x, U4F28 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U5F27 SaturatingMul(this U5F27 x, Vector3U5F27 y) {
            return new Vector3U5F27(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U5F27 SaturatingMul(this Vector3U5F27 x, U5F27 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U6F26 SaturatingMul(this U6F26 x, Vector3U6F26 y) {
            return new Vector3U6F26(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U6F26 SaturatingMul(this Vector3U6F26 x, U6F26 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U7F25 SaturatingMul(this U7F25 x, Vector3U7F25 y) {
            return new Vector3U7F25(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U7F25 SaturatingMul(this Vector3U7F25 x, U7F25 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 SaturatingMul(this U8F24 x, Vector3U8F24 y) {
            return new Vector3U8F24(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U8F24 SaturatingMul(this Vector3U8F24 x, U8F24 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U9F23 SaturatingMul(this U9F23 x, Vector3U9F23 y) {
            return new Vector3U9F23(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U9F23 SaturatingMul(this Vector3U9F23 x, U9F23 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U10F22 SaturatingMul(this U10F22 x, Vector3U10F22 y) {
            return new Vector3U10F22(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U10F22 SaturatingMul(this Vector3U10F22 x, U10F22 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U11F21 SaturatingMul(this U11F21 x, Vector3U11F21 y) {
            return new Vector3U11F21(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U11F21 SaturatingMul(this Vector3U11F21 x, U11F21 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U12F20 SaturatingMul(this U12F20 x, Vector3U12F20 y) {
            return new Vector3U12F20(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U12F20 SaturatingMul(this Vector3U12F20 x, U12F20 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 SaturatingMul(this U13F19 x, Vector3U13F19 y) {
            return new Vector3U13F19(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U13F19 SaturatingMul(this Vector3U13F19 x, U13F19 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U14F18 SaturatingMul(this U14F18 x, Vector3U14F18 y) {
            return new Vector3U14F18(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U14F18 SaturatingMul(this Vector3U14F18 x, U14F18 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 SaturatingMul(this U15F17 x, Vector3U15F17 y) {
            return new Vector3U15F17(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U15F17 SaturatingMul(this Vector3U15F17 x, U15F17 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U16F16 SaturatingMul(this U16F16 x, Vector3U16F16 y) {
            return new Vector3U16F16(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U16F16 SaturatingMul(this Vector3U16F16 x, U16F16 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U17F15 SaturatingMul(this U17F15 x, Vector3U17F15 y) {
            return new Vector3U17F15(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U17F15 SaturatingMul(this Vector3U17F15 x, U17F15 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U18F14 SaturatingMul(this U18F14 x, Vector3U18F14 y) {
            return new Vector3U18F14(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U18F14 SaturatingMul(this Vector3U18F14 x, U18F14 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U19F13 SaturatingMul(this U19F13 x, Vector3U19F13 y) {
            return new Vector3U19F13(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U19F13 SaturatingMul(this Vector3U19F13 x, U19F13 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U20F12 SaturatingMul(this U20F12 x, Vector3U20F12 y) {
            return new Vector3U20F12(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U20F12 SaturatingMul(this Vector3U20F12 x, U20F12 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 SaturatingMul(this U21F11 x, Vector3U21F11 y) {
            return new Vector3U21F11(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U21F11 SaturatingMul(this Vector3U21F11 x, U21F11 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U22F10 SaturatingMul(this U22F10 x, Vector3U22F10 y) {
            return new Vector3U22F10(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U22F10 SaturatingMul(this Vector3U22F10 x, U22F10 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 SaturatingMul(this U23F9 x, Vector3U23F9 y) {
            return new Vector3U23F9(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U23F9 SaturatingMul(this Vector3U23F9 x, U23F9 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U24F8 SaturatingMul(this U24F8 x, Vector3U24F8 y) {
            return new Vector3U24F8(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U24F8 SaturatingMul(this Vector3U24F8 x, U24F8 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 SaturatingMul(this U25F7 x, Vector3U25F7 y) {
            return new Vector3U25F7(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U25F7 SaturatingMul(this Vector3U25F7 x, U25F7 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 SaturatingMul(this U26F6 x, Vector3U26F6 y) {
            return new Vector3U26F6(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U26F6 SaturatingMul(this Vector3U26F6 x, U26F6 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U27F5 SaturatingMul(this U27F5 x, Vector3U27F5 y) {
            return new Vector3U27F5(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U27F5 SaturatingMul(this Vector3U27F5 x, U27F5 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U28F4 SaturatingMul(this U28F4 x, Vector3U28F4 y) {
            return new Vector3U28F4(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U28F4 SaturatingMul(this Vector3U28F4 x, U28F4 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U29F3 SaturatingMul(this U29F3 x, Vector3U29F3 y) {
            return new Vector3U29F3(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U29F3 SaturatingMul(this Vector3U29F3 x, U29F3 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U30F2 SaturatingMul(this U30F2 x, Vector3U30F2 y) {
            return new Vector3U30F2(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U30F2 SaturatingMul(this Vector3U30F2 x, U30F2 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U31F1 SaturatingMul(this U31F1 x, Vector3U31F1 y) {
            return new Vector3U31F1(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector3U31F1 SaturatingMul(this Vector3U31F1 x, U31F1 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 SaturatingMul(this I2F30 x, Vector4I2F30 y) {
            return new Vector4I2F30(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I2F30 SaturatingMul(this Vector4I2F30 x, I2F30 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I3F29 SaturatingMul(this I3F29 x, Vector4I3F29 y) {
            return new Vector4I3F29(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I3F29 SaturatingMul(this Vector4I3F29 x, I3F29 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F28 SaturatingMul(this I4F28 x, Vector4I4F28 y) {
            return new Vector4I4F28(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I4F28 SaturatingMul(this Vector4I4F28 x, I4F28 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 SaturatingMul(this I5F27 x, Vector4I5F27 y) {
            return new Vector4I5F27(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I5F27 SaturatingMul(this Vector4I5F27 x, I5F27 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I6F26 SaturatingMul(this I6F26 x, Vector4I6F26 y) {
            return new Vector4I6F26(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I6F26 SaturatingMul(this Vector4I6F26 x, I6F26 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 SaturatingMul(this I7F25 x, Vector4I7F25 y) {
            return new Vector4I7F25(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I7F25 SaturatingMul(this Vector4I7F25 x, I7F25 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F24 SaturatingMul(this I8F24 x, Vector4I8F24 y) {
            return new Vector4I8F24(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I8F24 SaturatingMul(this Vector4I8F24 x, I8F24 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 SaturatingMul(this I9F23 x, Vector4I9F23 y) {
            return new Vector4I9F23(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I9F23 SaturatingMul(this Vector4I9F23 x, I9F23 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 SaturatingMul(this I10F22 x, Vector4I10F22 y) {
            return new Vector4I10F22(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I10F22 SaturatingMul(this Vector4I10F22 x, I10F22 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I11F21 SaturatingMul(this I11F21 x, Vector4I11F21 y) {
            return new Vector4I11F21(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I11F21 SaturatingMul(this Vector4I11F21 x, I11F21 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 SaturatingMul(this I12F20 x, Vector4I12F20 y) {
            return new Vector4I12F20(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I12F20 SaturatingMul(this Vector4I12F20 x, I12F20 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I13F19 SaturatingMul(this I13F19 x, Vector4I13F19 y) {
            return new Vector4I13F19(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I13F19 SaturatingMul(this Vector4I13F19 x, I13F19 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 SaturatingMul(this I14F18 x, Vector4I14F18 y) {
            return new Vector4I14F18(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I14F18 SaturatingMul(this Vector4I14F18 x, I14F18 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I15F17 SaturatingMul(this I15F17 x, Vector4I15F17 y) {
            return new Vector4I15F17(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I15F17 SaturatingMul(this Vector4I15F17 x, I15F17 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I16F16 SaturatingMul(this I16F16 x, Vector4I16F16 y) {
            return new Vector4I16F16(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I16F16 SaturatingMul(this Vector4I16F16 x, I16F16 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 SaturatingMul(this I17F15 x, Vector4I17F15 y) {
            return new Vector4I17F15(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I17F15 SaturatingMul(this Vector4I17F15 x, I17F15 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I18F14 SaturatingMul(this I18F14 x, Vector4I18F14 y) {
            return new Vector4I18F14(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I18F14 SaturatingMul(this Vector4I18F14 x, I18F14 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 SaturatingMul(this I19F13 x, Vector4I19F13 y) {
            return new Vector4I19F13(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I19F13 SaturatingMul(this Vector4I19F13 x, I19F13 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 SaturatingMul(this I20F12 x, Vector4I20F12 y) {
            return new Vector4I20F12(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I20F12 SaturatingMul(this Vector4I20F12 x, I20F12 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I21F11 SaturatingMul(this I21F11 x, Vector4I21F11 y) {
            return new Vector4I21F11(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I21F11 SaturatingMul(this Vector4I21F11 x, I21F11 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I22F10 SaturatingMul(this I22F10 x, Vector4I22F10 y) {
            return new Vector4I22F10(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I22F10 SaturatingMul(this Vector4I22F10 x, I22F10 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 SaturatingMul(this I23F9 x, Vector4I23F9 y) {
            return new Vector4I23F9(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I23F9 SaturatingMul(this Vector4I23F9 x, I23F9 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 SaturatingMul(this I24F8 x, Vector4I24F8 y) {
            return new Vector4I24F8(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I24F8 SaturatingMul(this Vector4I24F8 x, I24F8 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 SaturatingMul(this I25F7 x, Vector4I25F7 y) {
            return new Vector4I25F7(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I25F7 SaturatingMul(this Vector4I25F7 x, I25F7 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I26F6 SaturatingMul(this I26F6 x, Vector4I26F6 y) {
            return new Vector4I26F6(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I26F6 SaturatingMul(this Vector4I26F6 x, I26F6 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I27F5 SaturatingMul(this I27F5 x, Vector4I27F5 y) {
            return new Vector4I27F5(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I27F5 SaturatingMul(this Vector4I27F5 x, I27F5 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I28F4 SaturatingMul(this I28F4 x, Vector4I28F4 y) {
            return new Vector4I28F4(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I28F4 SaturatingMul(this Vector4I28F4 x, I28F4 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I29F3 SaturatingMul(this I29F3 x, Vector4I29F3 y) {
            return new Vector4I29F3(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I29F3 SaturatingMul(this Vector4I29F3 x, I29F3 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 SaturatingMul(this I30F2 x, Vector4I30F2 y) {
            return new Vector4I30F2(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I30F2 SaturatingMul(this Vector4I30F2 x, I30F2 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I31F1 SaturatingMul(this I31F1 x, Vector4I31F1 y) {
            return new Vector4I31F1(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4I31F1 SaturatingMul(this Vector4I31F1 x, I31F1 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 SaturatingMul(this U2F30 x, Vector4U2F30 y) {
            return new Vector4U2F30(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U2F30 SaturatingMul(this Vector4U2F30 x, U2F30 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 SaturatingMul(this U3F29 x, Vector4U3F29 y) {
            return new Vector4U3F29(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U3F29 SaturatingMul(this Vector4U3F29 x, U3F29 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 SaturatingMul(this U4F28 x, Vector4U4F28 y) {
            return new Vector4U4F28(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U4F28 SaturatingMul(this Vector4U4F28 x, U4F28 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U5F27 SaturatingMul(this U5F27 x, Vector4U5F27 y) {
            return new Vector4U5F27(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U5F27 SaturatingMul(this Vector4U5F27 x, U5F27 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 SaturatingMul(this U6F26 x, Vector4U6F26 y) {
            return new Vector4U6F26(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U6F26 SaturatingMul(this Vector4U6F26 x, U6F26 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 SaturatingMul(this U7F25 x, Vector4U7F25 y) {
            return new Vector4U7F25(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U7F25 SaturatingMul(this Vector4U7F25 x, U7F25 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 SaturatingMul(this U8F24 x, Vector4U8F24 y) {
            return new Vector4U8F24(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U8F24 SaturatingMul(this Vector4U8F24 x, U8F24 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 SaturatingMul(this U9F23 x, Vector4U9F23 y) {
            return new Vector4U9F23(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U9F23 SaturatingMul(this Vector4U9F23 x, U9F23 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U10F22 SaturatingMul(this U10F22 x, Vector4U10F22 y) {
            return new Vector4U10F22(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U10F22 SaturatingMul(this Vector4U10F22 x, U10F22 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 SaturatingMul(this U11F21 x, Vector4U11F21 y) {
            return new Vector4U11F21(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U11F21 SaturatingMul(this Vector4U11F21 x, U11F21 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U12F20 SaturatingMul(this U12F20 x, Vector4U12F20 y) {
            return new Vector4U12F20(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U12F20 SaturatingMul(this Vector4U12F20 x, U12F20 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 SaturatingMul(this U13F19 x, Vector4U13F19 y) {
            return new Vector4U13F19(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U13F19 SaturatingMul(this Vector4U13F19 x, U13F19 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U14F18 SaturatingMul(this U14F18 x, Vector4U14F18 y) {
            return new Vector4U14F18(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U14F18 SaturatingMul(this Vector4U14F18 x, U14F18 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 SaturatingMul(this U15F17 x, Vector4U15F17 y) {
            return new Vector4U15F17(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U15F17 SaturatingMul(this Vector4U15F17 x, U15F17 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 SaturatingMul(this U16F16 x, Vector4U16F16 y) {
            return new Vector4U16F16(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U16F16 SaturatingMul(this Vector4U16F16 x, U16F16 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U17F15 SaturatingMul(this U17F15 x, Vector4U17F15 y) {
            return new Vector4U17F15(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U17F15 SaturatingMul(this Vector4U17F15 x, U17F15 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 SaturatingMul(this U18F14 x, Vector4U18F14 y) {
            return new Vector4U18F14(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U18F14 SaturatingMul(this Vector4U18F14 x, U18F14 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U19F13 SaturatingMul(this U19F13 x, Vector4U19F13 y) {
            return new Vector4U19F13(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U19F13 SaturatingMul(this Vector4U19F13 x, U19F13 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U20F12 SaturatingMul(this U20F12 x, Vector4U20F12 y) {
            return new Vector4U20F12(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U20F12 SaturatingMul(this Vector4U20F12 x, U20F12 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 SaturatingMul(this U21F11 x, Vector4U21F11 y) {
            return new Vector4U21F11(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U21F11 SaturatingMul(this Vector4U21F11 x, U21F11 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 SaturatingMul(this U22F10 x, Vector4U22F10 y) {
            return new Vector4U22F10(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U22F10 SaturatingMul(this Vector4U22F10 x, U22F10 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U23F9 SaturatingMul(this U23F9 x, Vector4U23F9 y) {
            return new Vector4U23F9(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U23F9 SaturatingMul(this Vector4U23F9 x, U23F9 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U24F8 SaturatingMul(this U24F8 x, Vector4U24F8 y) {
            return new Vector4U24F8(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U24F8 SaturatingMul(this Vector4U24F8 x, U24F8 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U25F7 SaturatingMul(this U25F7 x, Vector4U25F7 y) {
            return new Vector4U25F7(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U25F7 SaturatingMul(this Vector4U25F7 x, U25F7 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 SaturatingMul(this U26F6 x, Vector4U26F6 y) {
            return new Vector4U26F6(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U26F6 SaturatingMul(this Vector4U26F6 x, U26F6 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 SaturatingMul(this U27F5 x, Vector4U27F5 y) {
            return new Vector4U27F5(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U27F5 SaturatingMul(this Vector4U27F5 x, U27F5 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 SaturatingMul(this U28F4 x, Vector4U28F4 y) {
            return new Vector4U28F4(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U28F4 SaturatingMul(this Vector4U28F4 x, U28F4 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 SaturatingMul(this U29F3 x, Vector4U29F3 y) {
            return new Vector4U29F3(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U29F3 SaturatingMul(this Vector4U29F3 x, U29F3 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U30F2 SaturatingMul(this U30F2 x, Vector4U30F2 y) {
            return new Vector4U30F2(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U30F2 SaturatingMul(this Vector4U30F2 x, U30F2 y) => y.SaturatingMul(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U31F1 SaturatingMul(this U31F1 x, Vector4U31F1 y) {
            return new Vector4U31F1(
                x.SaturatingMul(y.X),
                x.SaturatingMul(y.Y),
                x.SaturatingMul(y.Z),
                x.SaturatingMul(y.W));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static Vector4U31F1 SaturatingMul(this Vector4U31F1 x, U31F1 y) => y.SaturatingMul(x);

    }
}
