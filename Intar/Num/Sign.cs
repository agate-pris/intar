using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace AgatePris.Intar.Num {
    public static class Sign {
        [MethodImpl(AggressiveInlining)] public static bool IsZero(this int x) => x == 0;
        [MethodImpl(AggressiveInlining)] public static bool IsZero(this long x) => x == 0;

        [MethodImpl(AggressiveInlining)] public static bool IsGreaterThanZero(this int x) => x > 0;
        [MethodImpl(AggressiveInlining)] public static bool IsGreaterThanZero(this long x) => x > 0;
        [MethodImpl(AggressiveInlining)] public static bool IsNegativeOrZero(this int x) => x <= 0;
        [MethodImpl(AggressiveInlining)] public static bool IsNegativeOrZero(this long x) => x <= 0;
#if NET7_0_OR_GREATER
        [MethodImpl(AggressiveInlining)] public static bool IsLessThanZero(this int x) => int.IsNegative(x);
        [MethodImpl(AggressiveInlining)] public static bool IsLessThanZero(this long x) => long.IsNegative(x);
        [MethodImpl(AggressiveInlining)] public static bool IsPositiveOrZero(this int x) => int.IsPositive(x);
        [MethodImpl(AggressiveInlining)] public static bool IsPositiveOrZero(this long x) => long.IsPositive(x);
#else
        [MethodImpl(AggressiveInlining)] public static bool IsLessThanZero(this int x) => x < 0;
        [MethodImpl(AggressiveInlining)] public static bool IsLessThanZero(this long x) => x < 0;
        [MethodImpl(AggressiveInlining)] public static bool IsPositiveOrZero(this int x) => x >= 0;
        [MethodImpl(AggressiveInlining)] public static bool IsPositiveOrZero(this long x) => x >= 0;
#endif
    }
}
