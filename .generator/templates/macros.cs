{%- macro inttype(bits, signed) %}
    {%- if signed %}
        {%- set ofs = 0 %}{% else %}
        {%- set ofs = 5 %}
    {%- endif %}
    {{- [
        'sbyte', 'short', 'int', 'long', 'Int128',
        'byte', 'ushort', 'uint', 'ulong', 'UInt128'
    ] | nth(n = log_two(n = bits/8) + ofs) }}
{%- endmacro %}

{%- macro one(bits, signed) %}
    {%- if signed %}
        {%- set ofs = 0 %}{% else %}
        {%- set ofs = 3 %}
    {%- endif %}
    {{- [
        '1', '1L', '(Int128)1',
        '1U', '1UL', '(UInt128)1'
    ] | nth(n = log_two(n = bits/32)+ofs) }}
{%- endmacro %}

{%- macro fixed_type(s, i, f) %}
    {%- if s %}I
    {%- else %}U{% endif %}
    {{- i }}F
    {{- f }}
{%- endmacro -%}

{%- macro vector_type(dim, type) -%}
    Vector{{ dim }}{{ type }}
{%- endmacro -%}

{%- macro vector_primitive(dim, signed, bits) -%}
    Vector{{ dim }}{% if not signed %}U{% endif %}Int{{ bits }}
{%- endmacro -%}

{%- macro vector_bool(dim) -%}
    {{ self::vector_type(dim=dim, type='Bool') }}
{%- endmacro -%}
