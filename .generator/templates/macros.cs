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
