{% import "macros.cs" as macros %}

using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class Mathi {
{% for type in ["int", "uint", "long", "ulong"] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} Twice({{ type }} x) => x * 2;
{%- endfor %}

    }
}
