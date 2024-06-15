using AgatePris.Intar.Integer;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    public static partial class math {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint isqrt(uint x) {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong isqrt(ulong x) {
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
