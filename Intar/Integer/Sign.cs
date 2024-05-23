using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;
using i08 = System.SByte;
using i16 = System.Int16;
using i32 = System.Int32;
using i64 = System.Int64;
//using u08 = System.Byte;
//using u16 = System.UInt16;
//using u32 = System.UInt32;
//using u64 = System.UInt64;

namespace AgatePris.Intar.Integer {
    public static class Sign {
        //[MethodImpl(AggressiveInlining)] public static bool IsZero(this i08 x) => x == 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsZero(this i16 x) => x == 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsZero(this i32 x) => x == 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsZero(this i64 x) => x == 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsZero(this u08 x) => x == 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsZero(this u16 x) => x == 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsZero(this u32 x) => x == 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsZero(this u64 x) => x == 0;

        //[MethodImpl(AggressiveInlining)] public static bool IsNegativeInclusive(this i08 x) => x <= 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsNegativeInclusive(this i16 x) => x <= 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsNegativeInclusive(this i32 x) => x <= 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsNegativeInclusive(this i64 x) => x <= 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsPositiveExclusive(this i08 x) => x > 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsPositiveExclusive(this i16 x) => x > 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsPositiveExclusive(this i32 x) => x > 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsPositiveExclusive(this i64 x) => x > 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsPositiveExclusive(this u08 x) => x > 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsPositiveExclusive(this u16 x) => x > 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsPositiveExclusive(this u32 x) => x > 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsPositiveExclusive(this u64 x) => x > 0;

#if NET7_0_OR_GREATER
        [MethodImpl(AggressiveInlining)] public static bool IsNegative(this i08 x) => i08.IsNegative(x);
        [MethodImpl(AggressiveInlining)] public static bool IsNegative(this i16 x) => i16.IsNegative(x);
        [MethodImpl(AggressiveInlining)] public static bool IsNegative(this i32 x) => i32.IsNegative(x);
        [MethodImpl(AggressiveInlining)] public static bool IsNegative(this i64 x) => i64.IsNegative(x);
        //[MethodImpl(AggressiveInlining)] public static bool IsPositiveInclusive(this i08 x) => i08.IsPositive(x);
        //[MethodImpl(AggressiveInlining)] public static bool IsPositiveInclusive(this i16 x) => i16.IsPositive(x);
        //[MethodImpl(AggressiveInlining)] public static bool IsPositiveInclusive(this i32 x) => i32.IsPositive(x);
        //[MethodImpl(AggressiveInlining)] public static bool IsPositiveInclusive(this i64 x) => i64.IsPositive(x);
#else
        [MethodImpl(AggressiveInlining)] public static bool IsNegative(this i08 x) => x < 0;
        [MethodImpl(AggressiveInlining)] public static bool IsNegative(this i16 x) => x < 0;
        [MethodImpl(AggressiveInlining)] public static bool IsNegative(this i32 x) => x < 0;
        [MethodImpl(AggressiveInlining)] public static bool IsNegative(this i64 x) => x < 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsPositiveInclusive(this i08 x) => x >= 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsPositiveInclusive(this i16 x) => x >= 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsPositiveInclusive(this i32 x) => x >= 0;
        //[MethodImpl(AggressiveInlining)] public static bool IsPositiveInclusive(this i64 x) => x >= 0;
#endif
    }
}
