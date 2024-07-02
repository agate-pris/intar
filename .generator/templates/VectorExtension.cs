{% import "macros.cs" as macros %}

using AgatePris.Intar.Numerics;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static class VectorExtension {

{%- for s in [true, false] %}
{%- for i in range(start=2, end=32) %}
{%- set type = macros::fixed_type(s=s, i=i, f=32-i) %}
{%- for dim in range(start=2, end=5) %}
{%- set vector_type = macros::vector_type(dim=dim, type=type) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector_type }} SaturatingAdd(
            this {{ vector_type }} x, {{ vector_type }} y
        ) => new {{ vector_type }}(
            x.X.SaturatingAdd(y.X),
            x.Y.SaturatingAdd(y.Y){% if dim > 2 %},
            x.Z.SaturatingAdd(y.Z){% if dim > 3 %},
            x.W.SaturatingAdd(y.W){% endif %}{% endif %});

{%- endfor %}
{%- endfor %}
{%- endfor %}

{%- for s in [true, false] %}
{%- for i in range(start=2, end=32) %}
{%- set type = macros::fixed_type(s=s, i=i, f=32-i) %}
{%- for dim in range(start=2, end=5) %}
{%- set vector_type = macros::vector_type(dim=dim, type=type) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector_type }} SaturatingMul(
            this {{ type }} x, {{ vector_type }} y
        ) => new {{ vector_type }}(
            x.SaturatingMul(y.X),
            x.SaturatingMul(y.Y){%if dim > 2 %},
            x.SaturatingMul(y.Z){%if dim > 3 %},
            x.SaturatingMul(y.W){% endif %}{% endif %});
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector_type }} SaturatingMul(
            this {{ vector_type }} x, {{ type }} y
        ) => y.SaturatingMul(x);

{%- endfor %}
{%- endfor %}
{%- endfor %}

    }
}
