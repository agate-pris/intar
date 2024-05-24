using System.Runtime.CompilerServices;
using AgatePris.Intar.Integer;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace AgatePris.Intar.Mathematics {
    public static partial class Utility {
        [MethodImpl(AggressiveInlining)] public static Int2 AsInt(this Long2 v) => new Int2((int)v.X, (int)v.Y);
        [MethodImpl(AggressiveInlining)] public static Long2 AsLong(this Int2 v) => new Long2(v.X, v.Y);
        [MethodImpl(AggressiveInlining)] public static Uint2 AsUint(this Ulong2 v) => new Uint2((uint)v.X, (uint)v.Y);
        [MethodImpl(AggressiveInlining)] public static Ulong2 AsUlong(this Uint2 v) => new Ulong2(v.X, v.Y);
        [MethodImpl(AggressiveInlining)] public static Uint2 AbsDiff(this Int2 x, Int2 y) => new Uint2(x.X.AbsDiff(y.X), x.Y.AbsDiff(y.Y));
        [MethodImpl(AggressiveInlining)] public static Ulong2 AbsDiff(this Long2 x, Long2 y) => new Ulong2(x.X.AbsDiff(y.X), x.Y.AbsDiff(y.Y));
        [MethodImpl(AggressiveInlining)] public static int Dot(this Int2 x, Int2 y) => x.X * y.X + x.Y * y.Y;
        [MethodImpl(AggressiveInlining)] public static uint Dot(this Uint2 x, Uint2 y) => x.X * y.X + x.Y * y.Y;
        [MethodImpl(AggressiveInlining)] public static long Dot(this Long2 x, Long2 y) => x.X * y.X + x.Y * y.Y;
        [MethodImpl(AggressiveInlining)] public static ulong Dot(this Ulong2 x, Ulong2 y) => x.X * y.X + x.Y * y.Y;
        [MethodImpl(AggressiveInlining)]
        public static long Length(this Int2 v) {
            var l = new Ulong2(v.X.UnsignedAbs(), v.Y.UnsignedAbs());
            return (long)l.Dot(l).Isqrt();
        }
        [MethodImpl(AggressiveInlining)]
        public static long Length(this Uint2 v) {
            var l = v.AsUlong();
            return (long) l.Dot(l).Isqrt();
        }
    }
}
