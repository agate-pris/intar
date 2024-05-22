using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace AgatePris.Intar.Integer {
    public static class Sign {
        [MethodImpl(AggressiveInlining)] public static bool IsZero(this int x) => x == 0;
        [MethodImpl(AggressiveInlining)] public static bool IsZero(this long x) => x == 0;

        [MethodImpl(AggressiveInlining)] public static bool IsPositiveExclusive(this int x) => x > 0;
        [MethodImpl(AggressiveInlining)] public static bool IsPositiveExclusive(this long x) => x > 0;
        [MethodImpl(AggressiveInlining)] public static bool IsNegativeInclusive(this int x) => x <= 0;
        [MethodImpl(AggressiveInlining)] public static bool IsNegativeInclusive(this long x) => x <= 0;
#if NET7_0_OR_GREATER
        [MethodImpl(AggressiveInlining)] public static bool IsNegativeExclusive(this int x) => int.IsNegative(x);
        [MethodImpl(AggressiveInlining)] public static bool IsNegativeExclusive(this long x) => long.IsNegative(x);
        [MethodImpl(AggressiveInlining)] public static bool IsPositiveInclusive(this int x) => int.IsPositive(x);
        [MethodImpl(AggressiveInlining)] public static bool IsPositiveInclusive(this long x) => long.IsPositive(x);
#else
        [MethodImpl(AggressiveInlining)] public static bool IsNegativeExclusive(this int x) => x < 0;
        [MethodImpl(AggressiveInlining)] public static bool IsNegativeExclusive(this long x) => x < 0;
        [MethodImpl(AggressiveInlining)] public static bool IsPositiveInclusive(this int x) => x >= 0;
        [MethodImpl(AggressiveInlining)] public static bool IsPositiveInclusive(this long x) => x >= 0;
#endif
    }
}
