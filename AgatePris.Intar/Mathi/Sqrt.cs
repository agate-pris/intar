using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class Mathi {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Sqrt(uint x) {
            if (x <= 1) {
                return x;
            }

            const int halfBits = sizeof(int) * 4;
            var k = halfBits - (BitOperations.LeadingZeroCount(x - 1) >> 1);
            var s = 1U << k;
            var t = (s + (x >> k)) >> 1;
            while (t < s) {
                s = t;
                t = (s + (x / s)) >> 1;
            }
            return s;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Sqrt(ulong x) {
            if (x <= 1) {
                return x;
            }

            const int halfBits = sizeof(long) * 4;
            var k = halfBits - (BitOperations.LeadingZeroCount(x - 1) >> 1);
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
