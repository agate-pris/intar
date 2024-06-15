{%- macro aslong(i, d) %}

        public static long{{ d }} aslong(this {{ i }} x) => long{{ d }}(
            x.x,
            x.y{% if d > 2 %},
            x.z{% if d > 3 %},
            x.w{% endif %}{% endif %});
{%- endmacro -%}

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

        {%- for d in range(start=2, end=5) %}
            {{- self::aslong(i="int" ~ d, d=d) }}
        {%- endfor %}

    }

#pragma warning restore IDE1006 // 命名スタイル

}
