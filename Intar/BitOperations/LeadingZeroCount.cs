using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace AgatePris.Intar {
    public static partial class BitOperations {
        [MethodImpl(AggressiveInlining)]
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

        [MethodImpl(AggressiveInlining)]
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
