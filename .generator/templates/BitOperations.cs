{% import "macros.cs" as macros %}

using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    public static partial class BitOperations {

#if NET7_0_OR_GREATER
{% for method in ['LeadingZeroCount', 'PopCount', 'RotateLeft', 'RotateRight'] %}
{%- for type in ['uint', 'ulong'] %}
{%- if method == 'RotateLeft' or method == 'RotateRight' %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static {{ type }} {{ method }}({{ type }} x, int k) => System.Numerics.BitOperations.{{ method }}(x, k);
{%- else %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static int {{ method }}({{ type }} x) => System.Numerics.BitOperations.{{ method }}(x);
{%- endif %}
{%- endfor %}
{%- endfor %}

#else
{% for type in ['int', 'long'] %}
        const int bitsOf{{ type | capitalize }} = sizeof({{ type }}) * 8;
{%- endfor %}

{%- for type in ['uint', 'ulong'] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int PopCount({{ type }} x) {
            const {{ type }} k55 = 0x5555_5555{% if type == 'ulong' %}_5555_5555{% endif %};
            const {{ type }} k33 = 0x3333_3333{% if type == 'ulong' %}_3333_3333{% endif %};
            const {{ type }} k0F = 0x0F0F_0F0F{% if type == 'ulong' %}_0F0F_0F0F{% endif %};
            unchecked {
                x -= (x >> 1) & k55;
                x = ((x >> 2) & k33) + (x & k33);
                x = ((x >> 4) + x) & k0F;
                x += x >> 8;
                x += x >> 16;{% if type == 'ulong' %}
                x += x >> 32;{% endif %}
                return (int)x & ((bitsOf{{ macros::signed_type(t=type) | capitalize }} * 2) - 1);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int LeadingZeroCount({{ type }} x) {
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;{% if type == 'ulong' %}
            x |= x >> 32;{% endif %}
            unchecked {
                return bitsOf{{ macros::signed_type(t=type) | capitalize }} - PopCount(x);
            }
        }

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
