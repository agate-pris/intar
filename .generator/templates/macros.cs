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

{%- macro unsigned_type(t) %}
    {%- if   t == "int"     %}uint
    {%- elif t == "uint"    %}uint
    {%- elif t == "long"    %}ulong
    {%- elif t == "ulong"   %}ulong
    {%- elif t == "short"   %}ushort
    {%- elif t == "ushort"  %}ushort
    {%- elif t == "byte"    %}byte
    {%- elif t == "sbyte"   %}byte
    {%- elif t == "Int128"  %}UInt128
    {%- elif t == "UInt128" %}UInt128
    {%- else                %}{{ throw(message = "invalid arguments. t: " ~ t) }}
    {%- endif               %}
{%- endmacro %}

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
