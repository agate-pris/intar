using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class BitOperations {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int LeadingZeroCount(uint x) {
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            unchecked {
                return bitsOfInt - PopCount(x);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int LeadingZeroCount(ulong x) {
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            x |= x >> 32;
            unchecked {
                return bitsOfLong - PopCount(x);
            }
        }
    }
}
