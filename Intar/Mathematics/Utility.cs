using System.Runtime.CompilerServices;
using AgatePris.Intar.Integer;
using static System.Runtime.CompilerServices.MethodImplOptions;

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0090 // 'new(...)' を使用する

#if UNITY_2018_3_OR_NEWER
using Unity.Mathematics;
#endif

namespace AgatePris.Intar.Mathematics {
    public static partial class Utility {
        [MethodImpl(AggressiveInlining)] public static uint2 UnsignedAbs(this int2 v) => new uint2(v.x.UnsignedAbs(), v.y.UnsignedAbs());
        [MethodImpl(AggressiveInlining)] public static Ulong2 UnsignedAbs(this Long2 v) => new Ulong2(v.X.UnsignedAbs(), v.Y.UnsignedAbs());
        [MethodImpl(AggressiveInlining)] public static int2 AsInt(this Long2 v) => new int2((int)v.X, (int)v.Y);
        [MethodImpl(AggressiveInlining)] public static Long2 AsLong(this int2 v) => new Long2(v.x, v.y);
        [MethodImpl(AggressiveInlining)] public static uint2 AsUint(this Ulong2 v) => new uint2((uint)v.X, (uint)v.Y);
        [MethodImpl(AggressiveInlining)] public static Ulong2 AsUlong(this uint2 v) => new Ulong2(v.x, v.y);
        [MethodImpl(AggressiveInlining)] public static uint2 AbsDiff(this int2 x, int2 y) => new uint2(x.x.AbsDiff(y.x), x.y.AbsDiff(y.y));
        [MethodImpl(AggressiveInlining)] public static Ulong2 AbsDiff(this Long2 x, Long2 y) => new Ulong2(x.X.AbsDiff(y.X), x.Y.AbsDiff(y.Y));
        [MethodImpl(AggressiveInlining)] public static int Dot(this int2 x, int2 y) => x.x * y.x + x.y * y.y;
        [MethodImpl(AggressiveInlining)] public static uint Dot(this uint2 x, uint2 y) => x.x * y.x + x.y * y.y;
        [MethodImpl(AggressiveInlining)] public static long Dot(this Long2 x, Long2 y) => x.X * y.X + x.Y * y.Y;
        [MethodImpl(AggressiveInlining)] public static ulong Dot(this Ulong2 x, Ulong2 y) => x.X * y.X + x.Y * y.Y;
        [MethodImpl(AggressiveInlining)] static ulong Length(this Ulong2 v) => v.Dot(v).Isqrt();
        [MethodImpl(AggressiveInlining)] public static ulong Length(this uint2 v) => v.AsUlong().Length();
        [MethodImpl(AggressiveInlining)] public static ulong Length(this int2 v) => v.UnsignedAbs().Length();
        [MethodImpl(AggressiveInlining)] public static long SignedLength(this int2 v) => (long)v.Length();
        [MethodImpl(AggressiveInlining)] public static long SignedLength(this uint2 v) => (long)v.Length();
    }
}
