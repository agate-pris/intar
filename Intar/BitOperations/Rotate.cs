using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class BitOperations {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint RotateLeft(uint x, int k) {
            return (x << k) | (x >> (bitsOfInt - k));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong RotateLeft(ulong x, int k) {
            return (x << k) | (x >> (bitsOfLong - k));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint RotateRight(uint x, int k) {
            return (x >> k) | (x << (bitsOfInt - k));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong RotateRight(ulong x, int k) {
            return (x >> k) | (x << (bitsOfLong - k));
        }
    }
}
