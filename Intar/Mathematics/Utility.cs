using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

#if UNITY_2018_3_OR_NEWER
using Unity.Mathematics;
#endif

namespace AgatePris.Intar.Mathematics {
    public static partial class Utility {
        [MethodImpl(AggressiveInlining)] public static uint2 UnsignedAbs(this int2 v) => new uint2(v.x.UnsignedAbs(), v.y.UnsignedAbs());
        [MethodImpl(AggressiveInlining)] public static ulong2 UnsignedAbs(this long2 v) => new ulong2(v.x.UnsignedAbs(), v.y.UnsignedAbs());
        [MethodImpl(AggressiveInlining)] public static int2 AsInt(this long2 v) => new int2((int)v.x, (int)v.y);
        [MethodImpl(AggressiveInlining)] public static uint2 AsUint(this ulong2 v) => new uint2((uint)v.x, (uint)v.y);
        [MethodImpl(AggressiveInlining)] public static ulong2 AsUlong(this uint2 v) => new ulong2(v.x, v.y);
        [MethodImpl(AggressiveInlining)] public static uint2 AbsDiff(this int2 x, int2 y) => new uint2(x.x.AbsDiff(y.x), x.y.AbsDiff(y.y));
        [MethodImpl(AggressiveInlining)] public static ulong2 AbsDiff(this long2 x, long2 y) => new ulong2(x.x.AbsDiff(y.x), x.y.AbsDiff(y.y));
        [MethodImpl(AggressiveInlining)] public static int Dot(this int2 x, int2 y) => (x.x * y.x) + (x.y * y.y);
        [MethodImpl(AggressiveInlining)] public static uint Dot(this uint2 x, uint2 y) => (x.x * y.x) + (x.y * y.y);
        [MethodImpl(AggressiveInlining)] public static long Dot(this long2 x, long2 y) => (x.x * y.x) + (x.y * y.y);
        [MethodImpl(AggressiveInlining)] public static ulong Dot(this ulong2 x, ulong2 y) => (x.x * y.x) + (x.y * y.y);
        [MethodImpl(AggressiveInlining)] static ulong Length(this ulong2 v) => Mathi.Sqrt(v.Dot(v));
        [MethodImpl(AggressiveInlining)] public static ulong Length(this uint2 v) => v.AsUlong().Length();
        [MethodImpl(AggressiveInlining)] public static ulong Length(this int2 v) => v.UnsignedAbs().Length();
        [MethodImpl(AggressiveInlining)] public static long SignedLength(this int2 v) => (long)v.Length();
        [MethodImpl(AggressiveInlining)] public static long SignedLength(this uint2 v) => (long)v.Length();
    }
}
