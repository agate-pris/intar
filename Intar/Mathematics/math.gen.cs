#if UNITY_2018_3_OR_NEWER
using Unity.Mathematics;
using static Unity.Mathematics.math;
#endif

namespace AgatePris.Intar.Mathematics {
    public static partial class math {

        public static long2 aslong(this int2 x) => long2(
            x.x,
            x.y);

        public static long3 aslong(this int3 x) => long3(
            x.x,
            x.y,
            x.z);

        public static long4 aslong(this int4 x) => long4(
            x.x,
            x.y,
            x.z,
            x.w);

    }
}
