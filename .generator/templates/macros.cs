{%- macro fixed_type(s, i, f) %}
    {%- if s %}I
    {%- else %}U{% endif %}
    {{- i }}F
    {{- f }}
{%- endmacro -%}

{%- macro bits_type(s, i, f) %}
    {%- if s %}
        {%- if i + f == 32 %}int
        {%- elif i + f == 64 %}long
        {%- else %}{{ throw(message = "invalid arguments. i: " ~ i ~ ", f: " ~ f ) }}
        {%- endif %}
    {%- else %}
        {%- if i + f == 32 %}uint
        {%- elif i + f == 64 %}ulong
        {%- else %}{{ throw(message = "invalid arguments. i: " ~ i ~ ", f: " ~ f ) }}
        {%- endif %}
    {%- endif %}
{%- endmacro %}

{%- macro wide_type(type) %}
    {%- if   type == "int"   %}long
    {%- elif type == "uint"  %}ulong
    {%- elif type == "long"  %}Int128
    {%- elif type == "ulong" %}UInt128
    {%- else %}{{ throw(message = "invalid arguments. type: " ~ type) }}
    {%- endif %}
{%- endmacro %}

{%- macro wide_bits_type(s, i, f) %}
    {{- self::wide_type(type=self::bits_type(s=s, i=i, f=f)) }}
{%- endmacro -%}

{%- macro vector_type(dim, type) -%}
    Vector{{ dim }}{{ type }}
{%- endmacro -%}
