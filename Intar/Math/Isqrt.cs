using System.Runtime.CompilerServices;
using static AgatePris.Intar.Integer.BitOperations;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace AgatePris.Intar {
    public static partial class Math {
        [MethodImpl(AggressiveInlining)]
        public static uint Isqrt(uint x) {
            if (x <= 1) {
                return x;
            }

            const int halfBits = sizeof(int) * 4;
            var k = halfBits - (LeadingZeroCount(x - 1) >> 1);
            var s = 1U << k;
            var t = (s + (x >> k)) >> 1;
            while (t < s) {
                s = t;
                t = (s + (x / s)) >> 1;
            }
            return s;
        }

        [MethodImpl(AggressiveInlining)]
        public static ulong Isqrt(ulong x) {
            if (x <= 1) {
                return x;
            }

            const int halfBits = sizeof(long) * 4;
            var k = halfBits - (LeadingZeroCount(x - 1) >> 1);
            var s = 1UL << k;
            var t = (s + (x >> k)) >> 1;
            while (t < s) {
                s = t;
                t = (s + (x / s)) >> 1;
            }
            return s;
        }
    }
}
