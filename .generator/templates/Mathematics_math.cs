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
    public static partial class math {
        {%- for d in range(start=2, end=5) %}
            {{- self::aslong(i="int" ~ d, d=d) }}
        {%- endfor %}

    }
}
