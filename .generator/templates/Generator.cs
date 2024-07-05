{% import "macros.cs" as macros %}

using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    public static class Generator {
        {%- for s in [true, false] %}
        {%- for i in range(start=2, end=32) %}
        {%- set fixed_type = macros::fixed_type(s=s, i=i, f=32-i) %}
        {%- set type = macros::vector_type(dim=2, type=fixed_type) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Vector({{ fixed_type }} x, {{ fixed_type }} y) => new {{ type }}(x, y);
        {%- endfor %}
        {%- endfor %}

        {%- for s in [true, false] %}
        {%- for i in range(start=2, end=32) %}
        {%- set fixed_type = macros::fixed_type(s=s, i=i, f=32-i) %}
        {%- set type = macros::vector_type(dim=3, type=fixed_type) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Vector({{ fixed_type }} x, {{ fixed_type }} y, {{ fixed_type }} z) => new {{ type }}(x, y, z);
        {%- endfor %}
        {%- endfor %}

        {%- for s in [true, false] %}
        {%- for i in range(start=2, end=32) %}
        {%- set fixed_type = macros::fixed_type(s=s, i=i, f=32-i) %}
        {%- set type = macros::vector_type(dim=3, type=fixed_type) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Vector({{ fixed_type }} x, {{ macros::vector_type(dim=2, type=fixed_type) }} yz) => new {{ type }}(x, yz);
        {%- endfor %}
        {%- endfor %}

        {%- for s in [true, false] %}
        {%- for i in range(start=2, end=32) %}
        {%- set fixed_type = macros::fixed_type(s=s, i=i, f=32-i) %}
        {%- set type = macros::vector_type(dim=3, type=fixed_type) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Vector({{ macros::vector_type(dim=2, type=fixed_type) }} xy, {{ fixed_type }} z) => new {{ type }}(xy, z);
        {%- endfor %}
        {%- endfor %}

        {%- for s in [true, false] %}
        {%- for i in range(start=2, end=32) %}
        {%- set fixed_type = macros::fixed_type(s=s, i=i, f=32-i) %}
        {%- set type = macros::vector_type(dim=4, type=fixed_type) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Vector({{ fixed_type }} x, {{ fixed_type }} y, {{ fixed_type }} z, {{ fixed_type }} w) => new {{ type }}(x, y, z, w);
        {%- endfor %}
        {%- endfor %}

        {%- for s in [true, false] %}
        {%- for i in range(start=2, end=32) %}
        {%- set fixed_type = macros::fixed_type(s=s, i=i, f=32-i) %}
        {%- set type = macros::vector_type(dim=4, type=fixed_type) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Vector({{ fixed_type }} x, {{ fixed_type }} y, {{ macros::vector_type(dim=2, type=fixed_type) }} zw) => new {{ type }}(x, y, zw);
        {%- endfor %}
        {%- endfor %}

        {%- for s in [true, false] %}
        {%- for i in range(start=2, end=32) %}
        {%- set fixed_type = macros::fixed_type(s=s, i=i, f=32-i) %}
        {%- set type = macros::vector_type(dim=4, type=fixed_type) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Vector({{ fixed_type }} x, {{ macros::vector_type(dim=2, type=fixed_type) }} yz, {{ fixed_type }} w) => new {{ type }}(x, yz, w);
        {%- endfor %}
        {%- endfor %}

        {%- for s in [true, false] %}
        {%- for i in range(start=2, end=32) %}
        {%- set fixed_type = macros::fixed_type(s=s, i=i, f=32-i) %}
        {%- set type = macros::vector_type(dim=4, type=fixed_type) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Vector({{ macros::vector_type(dim=2, type=fixed_type) }} xy, {{ fixed_type }} z, {{ fixed_type }} w) => new {{ type }}(xy, z, w);
        {%- endfor %}
        {%- endfor %}

        {%- for s in [true, false] %}
        {%- for i in range(start=2, end=32) %}
        {%- set fixed_type = macros::fixed_type(s=s, i=i, f=32-i) %}
        {%- set type = macros::vector_type(dim=4, type=fixed_type) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Vector({{ macros::vector_type(dim=2, type=fixed_type) }} xy, {{ macros::vector_type(dim=2, type=fixed_type) }} zw) => new {{ type }}(xy, zw);
        {%- endfor %}
        {%- endfor %}

        {%- for s in [true, false] %}
        {%- for i in range(start=2, end=32) %}
        {%- set fixed_type = macros::fixed_type(s=s, i=i, f=32-i) %}
        {%- set type = macros::vector_type(dim=4, type=fixed_type) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Vector({{ fixed_type }} x, {{ macros::vector_type(dim=3, type=fixed_type) }} yzw) => new {{ type }}(x, yzw);
        {%- endfor %}
        {%- endfor %}

        {%- for s in [true, false] %}
        {%- for i in range(start=2, end=32) %}
        {%- set fixed_type = macros::fixed_type(s=s, i=i, f=32-i) %}
        {%- set type = macros::vector_type(dim=4, type=fixed_type) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Vector({{ macros::vector_type(dim=3, type=fixed_type) }} xyz, {{ fixed_type }} w) => new {{ type }}(xyz, w);
        {%- endfor %}
        {%- endfor %}
    }
}
