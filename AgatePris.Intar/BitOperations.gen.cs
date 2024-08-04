using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class BitOperations {

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint RotateLeft(uint x, int k) => System.Numerics.BitOperations.RotateLeft(x, k);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong RotateLeft(ulong x, int k) => System.Numerics.BitOperations.RotateLeft(x, k);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint RotateRight(uint x, int k) => System.Numerics.BitOperations.RotateRight(x, k);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong RotateRight(ulong x, int k) => System.Numerics.BitOperations.RotateRight(x, k);

#else

        const int bitsOfInt = sizeof(int) * 8;
        const int bitsOfLong = sizeof(long) * 8;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint RotateLeft(uint x, int k) => (x << k) | (x >> (bitsOfInt - k));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong RotateLeft(ulong x, int k) => (x << k) | (x >> (bitsOfLong - k));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint RotateRight(uint x, int k) => (x >> k) | (x << (bitsOfInt - k));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong RotateRight(ulong x, int k) => (x >> k) | (x << (bitsOfLong - k));

#endif

    }
}
