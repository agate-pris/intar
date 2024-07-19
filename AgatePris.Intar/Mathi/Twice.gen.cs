using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class Mathi {

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int Twice(int x) => x * 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static uint Twice(uint x) => x * 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static long Twice(long x) => x * 2;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ulong Twice(ulong x) => x * 2;

    }
}
