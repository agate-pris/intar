using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class BitOperations {

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int PopCount(uint x) => System.Numerics.BitOperations.PopCount(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int PopCount(ulong x) => System.Numerics.BitOperations.PopCount(x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint RotateLeft(uint x, int k) => System.Numerics.BitOperations.RotateLeft(x, k);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong RotateLeft(ulong x, int k) => System.Numerics.BitOperations.RotateLeft(x, k);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint RotateRight(uint x, int k) => System.Numerics.BitOperations.RotateRight(x, k);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong RotateRight(ulong x, int k) => System.Numerics.BitOperations.RotateRight(x, k);

#else

        const int bitsOfInt = sizeof(int) * 8;
        const int bitsOfLong = sizeof(long) * 8;

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
                return (int)x & ((bitsOfInt * 2) - 1);
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
                return (int)x & ((bitsOfLong * 2) - 1);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint RotateLeft(uint x, int k) => (x << k) | (x >> (bitsOfInt - k));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong RotateLeft(ulong x, int k) => (x << k) | (x >> (bitsOfLong - k));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint RotateRight(uint x, int k) => (x >> k) | (x << (bitsOfInt - k));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong RotateRight(ulong x, int k) => (x >> k) | (x << (bitsOfLong - k));

#endif

    }
}
