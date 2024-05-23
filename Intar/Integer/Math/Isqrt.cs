using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace AgatePris.Intar.Integer {
    public static partial class Math {
        [MethodImpl(AggressiveInlining)]
        public static uint Isqrt(this uint x) {
            if (x <= 1) {
                return x;
            }

            const int halfBits = sizeof(int) * 4;
            var k = halfBits - ((x - 1).LeadingZeroCount() >> 1);
            var s = 1U << k;
            var t = (s + (x >> k)) >> 1;
            while (t < s) {
                s = t;
                t = (s + (x / s)) >> 1;
            }
            return s;
        }

        [MethodImpl(AggressiveInlining)]
        public static ulong Isqrt(this ulong x) {
            if (x <= 1) {
                return x;
            }

            const int halfBits = sizeof(long) * 4;
            var k = halfBits - ((x - 1).LeadingZeroCount() >> 1);
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
