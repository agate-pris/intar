{% import "macros.cs" as macros %}

{%- macro aslong(i, d) %}

        public static long{{ d }} aslong(this {{ i }} x) => long{{ d }}(
            x.x,
            x.y{% if d > 2 %},
            x.z{% if d > 3 %},
            x.w{% endif %}{% endif %});
{%- endmacro -%}

{%- macro asbits(s, i, f, d) %}

        public static {{ macros::bits_type(s=s, i=i, f=f) }}{{ d }} asbits(this {{ macros::fixed_type(s=s, i=i, f=f) }}_{{ d }} x) => {{ macros::bits_type(s=s, i=i, f=f) }}{{ d }}(
            x.x.Bits,
            x.y.Bits{% if d > 2 %},
            x.z.Bits{% if d > 3 %},
            x.w.Bits{% endif %}{% endif %});
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

        {%- for d in range(start=2, end=5) %}
            {%- for s in [true, false] %}
                {%- for i in range(start=2, end=32) %}
                    {{- self::asbits(s=s,i=i, f=32-i, d=d) }}
                {%- endfor %}
            {%- endfor %}
        {%- endfor %}

    }
}
