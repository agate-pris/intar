{% import "macros.cs" as macros %}

using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class BitOperations {

#if NET7_0_OR_GREATER
{% for method in ['RotateLeft', 'RotateRight'] %}
{%- for type in ['uint', 'ulong'] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} {{ method }}({{ type }} x, int k) => System.Numerics.BitOperations.{{ method }}(x, k);
{%- endfor %}
{%- endfor %}

#else
{% for type in ['int', 'long'] %}
        const int bitsOf{{ type | capitalize }} = sizeof({{ type }}) * 8;
{%- endfor %}
{% for type in ['uint', 'ulong'] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} RotateLeft({{ type }} x, int k) => (x << k) | (x >> (bitsOf{{ macros::signed_type(t=type) | capitalize }} - k));
{%- endfor %}
{%- for type in ['uint', 'ulong'] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} RotateRight({{ type }} x, int k) => (x >> k) | (x << (bitsOf{{ macros::signed_type(t=type) | capitalize }} - k));
{%- endfor %}

#endif

    }
}
