{%- macro inttype(bits, signed) %}
{%- if   bits ==  32 %}{% if signed -%} int   {%- else -%}uint   {%- endif %}
{%- elif bits ==  64 %}{% if signed -%} long  {%- else -%}ulong  {%- endif %}
{%- elif bits ==  16 %}{% if signed -%} short {%- else -%}ushort {%- endif %}
{%- elif bits ==   8 %}{% if signed -%}sbyte  {%- else -%} byte  {%- endif %}
{%- elif bits == 128 %}{% if signed -%} Int128{%- else -%}UInt128{%- endif %}
{%- else %}{{ throw(message = "invalid arguments. bits: " ~ bits) }}{% endif %}
{%- endmacro %}

{%- macro one(bits, signed) %}
{%- if   bits == 32 %}{% if signed %}1 {%- else %}1U {%- endif %}
{%- elif bits == 64 %}{% if signed %}1L{%- else %}1UL{%- endif %}
{%- else %}{{ throw(message = "invalid arguments. bits: " ~ bits) }}{% endif %}
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

{%- macro checked_add(type, ext) -%}
[MethodImpl(MethodImplOptions.AggressiveInlining)]
public static {{ type }}? CheckedAdd({% if ext %}this {% endif %}{{ type }} x, {{ type }} y) {
    {{ type }}? @null = null;
    return OverflowingAdd(x, y, out var result) ? @null : result;
}
{%- endmacro -%}
