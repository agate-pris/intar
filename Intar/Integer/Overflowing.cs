using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;
using i08 = System.SByte;
using i16 = System.Int16;
using i32 = System.Int32;
using i64 = System.Int64;
using u08 = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace AgatePris.Intar.Integer {
    public static class Overflowing {
        const i08 zeroI08 = 0;
        const i16 zeroI16 = 0;
        const i32 zeroI32 = 0;
        const i64 zeroI64 = 0;
        const u08 zeroU08 = 0;
        const u16 zeroU16 = 0;
        const u32 zeroU32 = 0;
        const u64 zeroU64 = 0;

        [MethodImpl(AggressiveInlining)] public static i32 WrappingAdd(this i32 x, i32 y) => unchecked(x + y);
        [MethodImpl(AggressiveInlining)] public static i64 WrappingAdd(this i64 x, i64 y) => unchecked(x + y);
        [MethodImpl(AggressiveInlining)] public static u32 WrappingAdd(this u32 x, u32 y) => unchecked(x + y);
        [MethodImpl(AggressiveInlining)] public static u64 WrappingAdd(this u64 x, u64 y) => unchecked(x + y);
        [MethodImpl(AggressiveInlining)] public static i32 WrappingSub(this i32 x, i32 y) => unchecked(x - y);
        [MethodImpl(AggressiveInlining)] public static i64 WrappingSub(this i64 x, i64 y) => unchecked(x - y);
        [MethodImpl(AggressiveInlining)] public static u32 WrappingSub(this u32 x, u32 y) => unchecked(x - y);
        [MethodImpl(AggressiveInlining)] public static u64 WrappingSub(this u64 x, u64 y) => unchecked(x - y);
        [MethodImpl(AggressiveInlining)] public static i32 WrappingMul(this i32 x, i32 y) => unchecked(x * y);
        [MethodImpl(AggressiveInlining)] public static i64 WrappingMul(this i64 x, i64 y) => unchecked(x * y);
        [MethodImpl(AggressiveInlining)] public static u32 WrappingMul(this u32 x, u32 y) => unchecked(x * y);
        [MethodImpl(AggressiveInlining)] public static u64 WrappingMul(this u64 x, u64 y) => unchecked(x * y);
        [MethodImpl(AggressiveInlining)] public static i08 WrappingAdd(this i08 x, i08 y) => unchecked((i08)(x + y));
        [MethodImpl(AggressiveInlining)] public static i16 WrappingAdd(this i16 x, i16 y) => unchecked((i16)(x + y));
        [MethodImpl(AggressiveInlining)] public static u08 WrappingAdd(this u08 x, u08 y) => unchecked((u08)(x + y));
        [MethodImpl(AggressiveInlining)] public static u16 WrappingAdd(this u16 x, u16 y) => unchecked((u16)(x + y));
        [MethodImpl(AggressiveInlining)] public static i08 WrappingSub(this i08 x, i08 y) => unchecked((i08)(x - y));
        [MethodImpl(AggressiveInlining)] public static i16 WrappingSub(this i16 x, i16 y) => unchecked((i16)(x - y));
        [MethodImpl(AggressiveInlining)] public static u08 WrappingSub(this u08 x, u08 y) => unchecked((u08)(x - y));
        [MethodImpl(AggressiveInlining)] public static u16 WrappingSub(this u16 x, u16 y) => unchecked((u16)(x - y));
        [MethodImpl(AggressiveInlining)] public static i08 WrappingMul(this i08 x, i08 y) => unchecked((i08)(x * y));
        [MethodImpl(AggressiveInlining)] public static i16 WrappingMul(this i16 x, i16 y) => unchecked((i16)(x * y));
        [MethodImpl(AggressiveInlining)] public static u08 WrappingMul(this u08 x, u08 y) => unchecked((u08)(x * y));
        [MethodImpl(AggressiveInlining)] public static u16 WrappingMul(this u16 x, u16 y) => unchecked((u16)(x * y));
        [MethodImpl(AggressiveInlining)] public static u32 WrappingAddSigned(this u08 x, i08 y) => x.WrappingAdd(unchecked((u08)y));
        [MethodImpl(AggressiveInlining)] public static u32 WrappingAddSigned(this u16 x, i16 y) => x.WrappingAdd(unchecked((u16)y));
        [MethodImpl(AggressiveInlining)] public static u32 WrappingAddSigned(this u32 x, i32 y) => x.WrappingAdd(unchecked((u32)y));
        [MethodImpl(AggressiveInlining)] public static u64 WrappingAddSigned(this u64 x, i64 y) => x.WrappingAdd(unchecked((u64)y));
        [MethodImpl(AggressiveInlining)] public static i08 WrappingAddUnsigned(this i08 x, u08 y) => x.WrappingAdd(unchecked((i08)y));
        [MethodImpl(AggressiveInlining)] public static i16 WrappingAddUnsigned(this i16 x, u16 y) => x.WrappingAdd(unchecked((i16)y));
        [MethodImpl(AggressiveInlining)] public static i32 WrappingAddUnsigned(this i32 x, u32 y) => x.WrappingAdd(unchecked((i32)y));
        [MethodImpl(AggressiveInlining)] public static i64 WrappingAddUnsigned(this i64 x, u64 y) => x.WrappingAdd(unchecked((i64)y));
        [MethodImpl(AggressiveInlining)] public static i08 WrappingSubUnsigned(this i08 x, u08 y) => x.WrappingSub(unchecked((i08)y));
        [MethodImpl(AggressiveInlining)] public static i16 WrappingSubUnsigned(this i16 x, u16 y) => x.WrappingSub(unchecked((i16)y));
        [MethodImpl(AggressiveInlining)] public static i32 WrappingSubUnsigned(this i32 x, u32 y) => x.WrappingSub(unchecked((i32)y));
        [MethodImpl(AggressiveInlining)] public static i64 WrappingSubUnsigned(this i64 x, u64 y) => x.WrappingSub(unchecked((i64)y));
        [MethodImpl(AggressiveInlining)] public static i08 WrappingNeg(this i08 x) => zeroI08.WrappingSub(x);
        [MethodImpl(AggressiveInlining)] public static i16 WrappingNeg(this i16 x) => zeroI16.WrappingSub(x);
        [MethodImpl(AggressiveInlining)] public static i32 WrappingNeg(this i32 x) => zeroI32.WrappingSub(x);
        [MethodImpl(AggressiveInlining)] public static i64 WrappingNeg(this i64 x) => zeroI64.WrappingSub(x);
        [MethodImpl(AggressiveInlining)] public static u08 WrappingNeg(this u08 x) => zeroU08.WrappingSub(x);
        [MethodImpl(AggressiveInlining)] public static u16 WrappingNeg(this u16 x) => zeroU16.WrappingSub(x);
        [MethodImpl(AggressiveInlining)] public static u32 WrappingNeg(this u32 x) => zeroU32.WrappingSub(x);
        [MethodImpl(AggressiveInlining)] public static u64 WrappingNeg(this u64 x) => zeroU64.WrappingSub(x);
        [MethodImpl(AggressiveInlining)] public static i08 WrappingAbs(this i08 x) => x.IsNegative() ? x.WrappingNeg() : x;
        [MethodImpl(AggressiveInlining)] public static i16 WrappingAbs(this i16 x) => x.IsNegative() ? x.WrappingNeg() : x;
        [MethodImpl(AggressiveInlining)] public static i32 WrappingAbs(this i32 x) => x.IsNegative() ? x.WrappingNeg() : x;
        [MethodImpl(AggressiveInlining)] public static i64 WrappingAbs(this i64 x) => x.IsNegative() ? x.WrappingNeg() : x;
        [MethodImpl(AggressiveInlining)] public static u08 UnsignedAbs(this i08 x) => unchecked((u08)x.WrappingAbs());
        [MethodImpl(AggressiveInlining)] public static u16 UnsignedAbs(this i16 x) => unchecked((u16)x.WrappingAbs());
        [MethodImpl(AggressiveInlining)] public static u32 UnsignedAbs(this i32 x) => unchecked((u32)x.WrappingAbs());
        [MethodImpl(AggressiveInlining)] public static u64 UnsignedAbs(this i64 x) => unchecked((u64)x.WrappingAbs());
        //[MethodImpl(AggressiveInlining)] public static bool OverflowingAbs(this i08 x, out i08 result) { result = x.WrappingAbs(); return x == i08.MinValue; }
        //[MethodImpl(AggressiveInlining)] public static bool OverflowingAbs(this i16 x, out i16 result) { result = x.WrappingAbs(); return x == i16.MinValue; }
        //[MethodImpl(AggressiveInlining)] public static bool OverflowingAbs(this i32 x, out i32 result) { result = x.WrappingAbs(); return x == i32.MinValue; }
        //[MethodImpl(AggressiveInlining)] public static bool OverflowingAbs(this i64 x, out i64 result) { result = x.WrappingAbs(); return x == i64.MinValue; }
        //[MethodImpl(AggressiveInlining)] public static bool OverflowingNeg(this i32 x, out i32 result) { if (x == i32.MinValue) { result = i32.MinValue; return true; } else { result = -x; return false; } }
        //[MethodImpl(AggressiveInlining)] public static bool OverflowingNeg(this i64 x, out i64 result) { if (x == i64.MinValue) { result = i64.MinValue; return true; } else { result = -x; return false; } }
        //[MethodImpl(AggressiveInlining)] public static bool OverflowingNeg(this i08 x, out i08 result) { if (x == i08.MinValue) { result = i08.MinValue; return true; } else { result = (i08)(-x); return false; } }
        //[MethodImpl(AggressiveInlining)] public static bool OverflowingNeg(this i16 x, out i16 result) { if (x == i16.MinValue) { result = i16.MinValue; return true; } else { result = (i16)(-x); return false; } }
        //[MethodImpl(AggressiveInlining)] public static bool OverflowingNeg(this u32 x, out u32 result) { result = (~x).WrappingAdd(1); return x != 0; }
        //[MethodImpl(AggressiveInlining)] public static bool OverflowingNeg(this u64 x, out u64 result) { result = (~x).WrappingAdd(1); return x != 0; }
        //[MethodImpl(AggressiveInlining)] public static bool OverflowingNeg(this u08 x, out u08 result) { result = ((u08)~x).WrappingAdd(1); return x != 0; }
        //[MethodImpl(AggressiveInlining)] public static bool OverflowingNeg(this u16 x, out u16 result) { result = ((u16)~x).WrappingAdd(1); return x != 0; }
        //[MethodImpl(AggressiveInlining)] public static i08? CheckedNeg(this i08 x) { var b = x.OverflowingNeg(out var result); return b ? (i08?)null : result; }
        //[MethodImpl(AggressiveInlining)] public static i16? CheckedNeg(this i16 x) { var b = x.OverflowingNeg(out var result); return b ? (i16?)null : result; }
        //[MethodImpl(AggressiveInlining)] public static i32? CheckedNeg(this i32 x) { var b = x.OverflowingNeg(out var result); return b ? (i32?)null : result; }
        //[MethodImpl(AggressiveInlining)] public static i64? CheckedNeg(this i64 x) { var b = x.OverflowingNeg(out var result); return b ? (i64?)null : result; }
        //[MethodImpl(AggressiveInlining)] public static u08? CheckedNeg(this u08 x) { var b = x.OverflowingNeg(out var result); return b ? (u08?)null : result; }
        //[MethodImpl(AggressiveInlining)] public static u16? CheckedNeg(this u16 x) { var b = x.OverflowingNeg(out var result); return b ? (u16?)null : result; }
        //[MethodImpl(AggressiveInlining)] public static u32? CheckedNeg(this u32 x) { var b = x.OverflowingNeg(out var result); return b ? (u32?)null : result; }
        //[MethodImpl(AggressiveInlining)] public static u64? CheckedNeg(this u64 x) { var b = x.OverflowingNeg(out var result); return b ? (u64?)null : result; }
        //[MethodImpl(AggressiveInlining)] public static i08? CheckedAbs(this i08 x) => x.IsNegative() ? x.CheckedNeg() : x;
        //[MethodImpl(AggressiveInlining)] public static i16? CheckedAbs(this i16 x) => x.IsNegative() ? x.CheckedNeg() : x;
        //[MethodImpl(AggressiveInlining)] public static i32? CheckedAbs(this i32 x) => x.IsNegative() ? x.CheckedNeg() : x;
        //[MethodImpl(AggressiveInlining)] public static i64? CheckedAbs(this i64 x) => x.IsNegative() ? x.CheckedNeg() : x;
        [MethodImpl(AggressiveInlining)] public static u08 AbsDiff(this i08 x, i08 y) { unchecked { var ux = (u08)x; var uy = (u08)y; return (x < y) ? uy.WrappingSub(ux) : ux.WrappingSub(uy); } }
        [MethodImpl(AggressiveInlining)] public static u16 AbsDiff(this i16 x, i16 y) { unchecked { var ux = (u16)x; var uy = (u16)y; return (x < y) ? uy.WrappingSub(ux) : ux.WrappingSub(uy); } }
        [MethodImpl(AggressiveInlining)] public static u32 AbsDiff(this i32 x, i32 y) { unchecked { var ux = (u32)x; var uy = (u32)y; return (x < y) ? uy.WrappingSub(ux) : ux.WrappingSub(uy); } }
        [MethodImpl(AggressiveInlining)] public static u64 AbsDiff(this i64 x, i64 y) { unchecked { var ux = (u64)x; var uy = (u64)y; return (x < y) ? uy.WrappingSub(ux) : ux.WrappingSub(uy); } }
        [MethodImpl(AggressiveInlining)] public static u08 AbsDiff(this u08 x, u08 y) { var ix = (i32)x; unchecked { return (u08)System.Math.Abs(ix.WrappingSub(y)); } }
        [MethodImpl(AggressiveInlining)] public static u16 AbsDiff(this u16 x, u16 y) { if (x < y) { return (u16)(y - x); } else { return (u16)(x - y); } }
        [MethodImpl(AggressiveInlining)] public static u32 AbsDiff(this u32 x, u32 y) { if (x < y) { return y - x; } else { return x - y; } }
        [MethodImpl(AggressiveInlining)] public static u64 AbsDiff(this u64 x, u64 y) { if (x < y) { return y - x; } else { return x - y; } }
    }
}
