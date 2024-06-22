using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace AgatePris.Intar.Extensions {
    public static class BitOperations {
        [MethodImpl(AggressiveInlining)] public static int LeadingZeroCount(this uint x) => Intar.BitOperations.LeadingZeroCount(x);
        [MethodImpl(AggressiveInlining)] public static int LeadingZeroCount(this ulong x) => Intar.BitOperations.LeadingZeroCount(x);
        [MethodImpl(AggressiveInlining)] public static int PopCount(this uint x) => Intar.BitOperations.PopCount(x);
        [MethodImpl(AggressiveInlining)] public static int PopCount(this ulong x) => Intar.BitOperations.PopCount(x);
        [MethodImpl(AggressiveInlining)] public static uint RotateLeft(this uint x, int k) => Intar.BitOperations.RotateLeft(x, k);
        [MethodImpl(AggressiveInlining)] public static ulong RotateLeft(this ulong x, int k) => Intar.BitOperations.RotateLeft(x, k);
        [MethodImpl(AggressiveInlining)] public static uint RotateRight(this uint x, int k) => Intar.BitOperations.RotateRight(x, k);
        [MethodImpl(AggressiveInlining)] public static ulong RotateRight(this ulong x, int k) => Intar.BitOperations.RotateRight(x, k);
    }
}
