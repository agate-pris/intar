using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace AgatePris.Intar {
    public static partial class BitOperations {
#if NET7_0_OR_GREATER
        [MethodImpl(AggressiveInlining)] public static int LeadingZeroCount(this uint x) => System.Numerics.BitOperations.LeadingZeroCount(x);
        [MethodImpl(AggressiveInlining)] public static int LeadingZeroCount(this ulong x) => System.Numerics.BitOperations.LeadingZeroCount(x);
#else
        [MethodImpl(AggressiveInlining)]
        public static int LeadingZeroCount(this uint x) {
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            unchecked {
                return bitsOfInt - x.PopCount();
            }
        }

        [MethodImpl(AggressiveInlining)]
        public static int LeadingZeroCount(this ulong x) {
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            x |= x >> 32;
            unchecked {
                return bitsOfLong - x.PopCount();
            }
        }
#endif
    }
}
