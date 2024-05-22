using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace AgatePris.Intar.Integer {
    public static partial class BitOperations {
        [MethodImpl(AggressiveInlining)]
        public static uint RotateLeft(uint x, int k) {
            return (x << k) | (x >> (bitsOfInt - k));
        }
        [MethodImpl(AggressiveInlining)]
        public static ulong RotateLeft(ulong x, int k) {
            return (x << k) | (x >> (bitsOfLong - k));
        }
        [MethodImpl(AggressiveInlining)]
        public static uint RotateRight(uint x, int k) {
            return (x >> k) | (x << (bitsOfInt - k));
        }
        [MethodImpl(AggressiveInlining)]
        public static ulong RotateRight(ulong x, int k) {
            return (x >> k) | (x << (bitsOfLong - k));
        }
    }
}
