{% macro min(type) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} min({{ type }} x, {{ type }} y) => x < y ? x : y;
{%- endmacro -%}

{% macro max(type) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} max({{ type }} x, {{ type }} y) => x > y ? x : y;
{%- endmacro -%}

{% macro clamp(type) -%}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ type }} clamp({{ type }} x, {{ type }} a, {{ type }} b) => max(a, min(b, x));
{%- endmacro -%}

// Unity 2018.3 以上の場合は Unity.Mathematics を使用する.
#if !UNITY_2018_3_OR_NEWER

using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {

#pragma warning disable IDE1006 // 命名スタイル

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CS8981 // 型名には、小文字の ASCII 文字のみが含まれています。このような名前は、プログラミング言語用に予約されている可能性があります。

    public static partial class math {

#pragma warning restore CS8981 // 型名には、小文字の ASCII 文字のみが含まれています。このような名前は、プログラミング言語用に予約されている可能性があります。
#pragma warning restore IDE0079 // 不要な抑制を削除します

        {{ self::min(type = "int") }}
        {{ self::min(type = "uint") }}
        {{ self::min(type = "long") }}
        {{ self::min(type = "ulong") }}
        {{ self::min(type = "short") }}
        {{ self::min(type = "ushort") }}
        {{ self::min(type = "byte") }}
        {{ self::min(type = "sbyte") }}
        {{ self::min(type = "float") }}
        {{ self::min(type = "double") }}
        {{ self::min(type = "decimal") }}

        {{ self::max(type = "int") }}
        {{ self::max(type = "uint") }}
        {{ self::max(type = "long") }}
        {{ self::max(type = "ulong") }}
        {{ self::max(type = "short") }}
        {{ self::max(type = "ushort") }}
        {{ self::max(type = "byte") }}
        {{ self::max(type = "sbyte") }}
        {{ self::max(type = "float") }}
        {{ self::max(type = "double") }}
        {{ self::max(type = "decimal") }}

        {{ self::clamp(type = "int") }}
        {{ self::clamp(type = "uint") }}
        {{ self::clamp(type = "long") }}
        {{ self::clamp(type = "ulong") }}
        {{ self::clamp(type = "short") }}
        {{ self::clamp(type = "ushort") }}
        {{ self::clamp(type = "byte") }}
        {{ self::clamp(type = "sbyte") }}
        {{ self::clamp(type = "float") }}
        {{ self::clamp(type = "double") }}
        {{ self::clamp(type = "decimal") }}
    }

#pragma warning restore IDE1006 // 命名スタイル

}

#endif
