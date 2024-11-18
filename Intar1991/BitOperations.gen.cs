using System.Runtime.CompilerServices;

namespace Intar1991 {
    public static class BitOperations {

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int LeadingZeroCount(uint x) => System.Numerics.BitOperations.LeadingZeroCount(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int LeadingZeroCount(ulong x) => System.Numerics.BitOperations.LeadingZeroCount(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int PopCount(uint x) => System.Numerics.BitOperations.PopCount(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int PopCount(ulong x) => System.Numerics.BitOperations.PopCount(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint RotateLeft(uint x, int k) => System.Numerics.BitOperations.RotateLeft(x, k);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong RotateLeft(ulong x, int k) => System.Numerics.BitOperations.RotateLeft(x, k);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint RotateRight(uint x, int k) => System.Numerics.BitOperations.RotateRight(x, k);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong RotateRight(ulong x, int k) => System.Numerics.BitOperations.RotateRight(x, k);

#else

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int PopCount(uint x) {
            const uint k55 = 0x5555_5555;
            const uint k33 = 0x3333_3333;
            const uint k0F = 0x0F0F_0F0F;
            unchecked {
                x -= (x >> 1) & k55;
                x = ((x >> 2) & k33) + (x & k33);
                x = ((x >> 4) + x) & k0F;
                x += x >> 8;
                x += x >> 16;
                return (int)x & ((32 * 2) - 1);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int LeadingZeroCount(uint x) {
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            unchecked {
                return 32 - PopCount(x);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int PopCount(ulong x) {
            const ulong k55 = 0x5555_5555_5555_5555;
            const ulong k33 = 0x3333_3333_3333_3333;
            const ulong k0F = 0x0F0F_0F0F_0F0F_0F0F;
            unchecked {
                x -= (x >> 1) & k55;
                x = ((x >> 2) & k33) + (x & k33);
                x = ((x >> 4) + x) & k0F;
                x += x >> 8;
                x += x >> 16;
                x += x >> 32;
                return (int)x & ((64 * 2) - 1);
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
                return 64 - PopCount(x);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint RotateLeft(uint x, int k) => (x << k) | (x >> (32 - k));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong RotateLeft(ulong x, int k) => (x << k) | (x >> (64 - k));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint RotateRight(uint x, int k) => (x >> k) | (x << (32 - k));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong RotateRight(ulong x, int k) => (x >> k) | (x << (64 - k));

#endif

    }
} // namespace Intar1991
