using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace AgatePris.Intar.Integer {
    public static partial class BitOperations {
#if NET7_0_OR_GREATER
        [MethodImpl(AggressiveInlining)] public static int PopCount(this uint x) => System.Numerics.BitOperations.PopCount(x);
        [MethodImpl(AggressiveInlining)] public static int PopCount(this ulong x) => System.Numerics.BitOperations.PopCount(x);
#else
        [MethodImpl(AggressiveInlining)]
        public static int PopCount(this uint x) {
            const uint k55 = 0x5555_5555;
            const uint k33 = 0x3333_3333;
            const uint k0F = 0x0F0F_0F0F;
            unchecked {
                x -= x >> 1 & k55;
                x = (x >> 2 & k33) + (x & k33);
                x = (x >> 4) + x & k0F;
                x += x >> 8;
                x += x >> 16;
                return (int)x & (bitsOfInt * 2 - 1);
            }
        }

        [MethodImpl(AggressiveInlining)]
        public static int PopCount(this ulong x) {
            const ulong k55 = 0x5555_5555_5555_5555;
            const ulong k33 = 0x3333_3333_3333_3333;
            const ulong k0F = 0x0F0F_0F0F_0F0F_0F0F;
            unchecked {
                x -= x >> 1 & k55;
                x = (x >> 2 & k33) + (x & k33);
                x = (x >> 4) + x & k0F;
                x += x >> 8;
                x += x >> 16;
                x += x >> 32;
                return (int)x & (bitsOfLong * 2 - 1);
            }
        }
#endif
    }
}
