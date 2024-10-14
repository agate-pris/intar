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

{%- for t in ['int', 'uint', 'long', 'ulong'] %}
        {{ inl }} public static bool OverflowingAdd(this {{ t }} x, {{ t }} y, out {{ t }} result) => Overflowing.OverflowingAdd(x, y, out result);
        {{ inl }} public static {{ t }}? CheckedAdd(this {{ t }} x, {{ t }} y) => Overflowing.CheckedAdd(x, y);
        {{ inl }} public static {{ t }} SaturatingAdd(this {{ t }} x, {{ t }} y) => Overflowing.SaturatingAdd(x, y);
{%- endfor %}

{%- for t in ["int", "uint"] %}
        {{ inl }} public static bool OverflowingMul(this {{ t }} x, {{ t }} y, out {{ t }} result) => Overflowing.OverflowingMul(x, y, out result);
        {{ inl }} public static {{ t }}? CheckedMul(this {{ t }} x, {{ t }} y) => Overflowing.CheckedMul(x, y);
        {{ inl }} public static {{ t }} SaturatingMul(this {{ t }} x, {{ t }} y) => Overflowing.SaturatingMul(x, y);
{%- endfor %}
    }
}
