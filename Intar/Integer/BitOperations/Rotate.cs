using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace AgatePris.Intar.Integer {
    public static partial class BitOperations {
        [MethodImpl(AggressiveInlining)]
        public static uint RotateLeft(this uint x, int k) {
            return (x << k) | (x >> (bitsOfInt - k));
        }
        [MethodImpl(AggressiveInlining)]
        public static ulong RotateLeft(this ulong x, int k) {
            return (x << k) | (x >> (bitsOfLong - k));
        }
        [MethodImpl(AggressiveInlining)]
        public static uint RotateRight(this uint x, int k) {
            return (x >> k) | (x << (bitsOfInt - k));
        }
        [MethodImpl(AggressiveInlining)]
        public static ulong RotateRight(this ulong x, int k) {
            return (x >> k) | (x << (bitsOfLong - k));
        }
    }
}
