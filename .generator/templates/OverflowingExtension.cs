{% import "macros.cs" as macros -%}

{%- set inl = "[MethodImpl(MethodImplOptions.AggressiveInlining)]" -%}

using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Extensions {
    public static class OverflowingExtension {

{%- for t in ["int", "uint", "long", "ulong"] %}
    {%- for m in ["WrappingAdd", "WrappingSub", "WrappingMul"] %}
        {{ inl }} public static {{ t }} {{ m }}(this {{ t }} x, {{ t }} y) => Overflowing.{{ m }}(x, y);
    {%- endfor %}
    {%- for m in ["WrappingNeg"] %}
        {{ inl }} public static {{ t }} {{ m }}(this {{ t }} x) => Overflowing.{{ m }}(x);
    {%- endfor %}
{%- endfor %}

{%- for bits in [32, 64] %}
    {%- set t  = macros::inttype(bits=bits, signed=true ) %}
    {%- set ut = macros::inttype(bits=bits, signed=false) %}
    {%- for m in ["WrappingAddSigned"] %}
        {{ inl }} public static {{ ut }} {{ m }}(this {{ ut }} x, {{ t }} y) => Overflowing.{{ m }}(x, y);
    {%- endfor %}
    {%- for m in ["WrappingAddUnsigned", "WrappingSubUnsigned"] %}
        {{ inl }} public static {{ t }} {{ m }}(this {{ t }} x, {{ ut }} y) => Overflowing.{{ m }}(x, y);
    {%- endfor %}
    {%- for m in ["AbsDiff"] %}
        {{ inl }} public static {{ ut }} {{ m }}(this {{ t }} x, {{ t }} y) => Overflowing.{{ m }}(x, y);
    {%- endfor %}
    {%- for m in ["AbsDiff"] %}
        {{ inl }} public static {{ ut }} {{ m }}(this {{ ut }} x, {{ ut }} y) => Overflowing.{{ m }}(x, y);
    {%- endfor %}
    {%- for m in ["WrappingAbs"] %}
        {{ inl }} public static {{ t }} {{ m }}(this {{ t }} x) => Overflowing.{{ m }}(x);
    {%- endfor %}
    {%- for m in ["UnsignedAbs"] %}
        {{ inl }} public static {{ ut }} {{ m }}(this {{ t }} x) => Overflowing.{{ m }}(x);
    {%- endfor %}
{%- endfor %}

{%- for t in ["int", "uint"] %}
    {%- for m in ["OverflowingAdd", "OverflowingMul"] %}
        {{ inl }} public static bool {{ m }}(this {{ t }} x, {{ t }} y, out {{ t }} result) => Overflowing.{{ m }}(x, y, out result);
    {%- endfor %}
    {%- for m in ["CheckedAdd", "CheckedMul"] %}
        {{ inl }} public static {{ t }}? {{ m }}(this {{ t }} x, {{ t }} y) => Overflowing.{{ m }}(x, y);
    {%- endfor %}
    {%- for m in ["SaturatingAdd", "SaturatingMul"] %}
        {{ inl }} public static {{ t }} {{ m }}(this {{ t }} x, {{ t }} y) => Overflowing.{{ m }}(x, y);
    {%- endfor %}
{%- endfor %}
    }
}
