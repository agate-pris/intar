#if UNITY_2018_3_OR_NEWER
using Unity.Mathematics;
using static Unity.Mathematics.math;
#endif

namespace AgatePris.Intar.Mathematics {

#pragma warning disable IDE1006 // 命名スタイル

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CS8981 // 型名には、小文字の ASCII 文字のみが含まれています。このような名前は、プログラミング言語用に予約されている可能性があります。

    public static partial class math {

#pragma warning restore CS8981 // 型名には、小文字の ASCII 文字のみが含まれています。このような名前は、プログラミング言語用に予約されている可能性があります。
#pragma warning restore IDE0079 // 不要な抑制を削除します

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

#pragma warning restore IDE1006 // 命名スタイル

}
