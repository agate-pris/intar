namespace AgatePris.Intar {
    public static partial class BitOperations {

#if !NET7_0_OR_GREATER
{% for type in ['int', 'long'] %}
        const int bitsOf{{ type | capitalize }} = sizeof({{ type }}) * 8;
{%- endfor %}

#endif

    }
}
