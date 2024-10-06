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

{%- macro wide_type(type) %}
    {%- if   type == "int"   %}long
    {%- elif type == "uint"  %}ulong
    {%- elif type == "long"  %}Int128
    {%- elif type == "ulong" %}UInt128
    {%- else %}{{ throw(message = "invalid arguments. type: " ~ type) }}
    {%- endif %}
{%- endmacro %}

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

{%- macro saturating_add_unsigned(type, ext) -%}
[MethodImpl(MethodImplOptions.AggressiveInlining)]
public static {{ type }} SaturatingAdd({% if ext %}this {% endif %}{{ type }} x, {{ type }} y) {
    return CheckedAdd(x, y) ?? {{ type }}.MaxValue;
}
{%- endmacro -%}

{%- macro one_literal(t) %}
    {%- if   t == "int"   -%}1
    {%- elif t == "uint"  -%}1U
    {%- elif t == "long"  -%}1L
    {%- elif t == "ulong" -%}1UL
    {%- else %}
        {{ throw(message=t) }}
    {%- endif %}
{%- endmacro %}
