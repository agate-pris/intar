{% import "macros.cs" as macros %}

using AgatePris.Intar.Numerics;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class Mathi {
{% for type in ["int", "uint", "long", "ulong"] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Twice({{ type }} x) => x * 2;
{%- endfor %}

{%- for s in [true, false] %}
{%- for i in range(start=2, end=32) %}
{%- set type = macros::fixed_type(s=s, i=i, f=32-i) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Twice(this {{ type }} x) => {{ type }}.FromBits(Twice(x.Bits));
{%- endfor %}
{%- endfor %}

{%- for s in [true, false] %}
{%- for i in range(start=2, end=32) %}
{%- set type = macros::fixed_type(s=s, i=i, f=64-i) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Twice(this {{ type }} x) => {{ type }}.FromBits(Twice(x.Bits));
{%- endfor %}
{%- endfor %}

{%- for dim in range(start=2, end=5) %}
{%- for s in [true, false] %}
{%- for i in range(start=2, end=32) %}
{%- set type = macros::fixed_type(s=s, i=i, f=32-i) %}
{%- set vector_type = macros::vector_type(dim=dim, type=type) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ vector_type }} Twice(this {{ vector_type }} x) => new {{ vector_type }}(
            x.X.Twice(),
            x.Y.Twice(){% if dim > 2 %},
            x.Z.Twice(){% if dim > 3 %},
            x.W.Twice(){% endif %}{% endif %});
{%- endfor %}
{%- endfor %}
{%- endfor %}

    }
}
