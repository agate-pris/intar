{% macro dim_type(dim) %}
    {{- type }}{{ dim }}
{%- endmacro -%}

{% macro self_type() %}
    {{- self::dim_type(dim = dim) }}
{%- endmacro -%}

{% macro swizzling() %}
        {%- if dim == 2 %}   {%- set cmp = ['x', 'y'] %}
        {%- elif dim == 3 %} {%- set cmp = ['x', 'y', 'z'] %}
        {%- elif dim == 4 %} {%- set cmp = ['x', 'y', 'z', 'w'] %}
        {%- else %}          {{- "Unexpected dim. dim: " ~ dim }}
        {%- endif -%}
        {%- for x in cmp %}
        {%- for y in cmp %}
        public readonly {{ self::dim_type(dim = 2) }} {{ x }}{{ y }} { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}({{ x }}, {{ y }}); }
        {%- endfor %}
        {%- endfor %}
        {%- for x in cmp %}
        {%- for y in cmp %}
        {%- for z in cmp %}
        public readonly {{ self::dim_type(dim = 3) }} {{ x }}{{ y }}{{ z }} { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}({{ x }}, {{ y }}, {{ z }}); }
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
        {%- for x in cmp %}
        {%- for y in cmp %}
        {%- for z in cmp %}
        {%- for w in cmp %}
        public readonly {{ self::dim_type(dim = 4) }} {{ x }}{{ y }}{{ z }}{{ w }} { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}({{ x }}, {{ y }}, {{ z }}, {{ w }}); }
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
{%- endmacro -%}

{% if unity %}#if !UNITY_2018_3_OR_NEWER

{% endif %}using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]

#pragma warning disable IDE1006 // 命名スタイル

    public struct {{ self::self_type() }} : IEquatable<{{ self::self_type() }}>, IFormattable {

#pragma warning restore IDE1006 // 命名スタイル

        // Fields
        // ---------------------------------------

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します

        public {{ type }} x;
        public {{ type }} y;{% if dim > 2 %}
        public {{ type }} z;{% endif %}{% if dim > 3 %}
        public {{ type }} w;{% endif %}

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します

        // Constants
        // ---------------------------------------

        public static readonly {{ self::self_type() }} zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ type }} x, {{ type }} y{% if dim > 2 %}, {{ type }} z{% endif %}{% if dim > 3 %}, {{ type }} w{% endif %}) {
            this.x = x;
            this.y = y;{% if dim > 2 %}
            this.z = z;{% endif %}{% if dim > 3 %}
            this.w = w;{% endif %}
        } {%- if dim > 3 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ type }} x, {{ type }} y, {{ self::dim_type(dim = 2) }} zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ type }} x, {{ self::dim_type(dim = 3) }} yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ self::dim_type(dim = 2) }} xy, {{ self::dim_type(dim = 2) }} zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ self::dim_type(dim = 4) }} xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        } {%- endif %} {%- if dim > 2 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ type }} x, {{ self::dim_type(dim = 2) }} yz{% if dim > 3 %}, {{ type }} w{% endif %}) {
            this.x = x;
            y = yz.x;
            z = yz.y;{% if dim > 3 %}
            this.w = w;{% endif %}
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ self::dim_type(dim = 3) }} xyz{% if dim > 3 %}, {{ type }} w{% endif %}) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;{% if dim > 3 %}
            this.w = w;{% endif %}
        } {%- endif %} {%- if dim > 1 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ self::dim_type(dim = 2) }} xy{% if dim > 2 %}, {{ type }} z{% endif %}{% if dim > 3 %}, {{ type }} w{% endif %}) {
            x = xy.x;
            y = xy.y;{% if dim > 2 %}
            this.z = z;{% endif %}{% if dim > 3 %}
            this.w = w;{% endif %}
        } {%- endif %}

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator +({{ self::self_type() }} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a.x + b.x,
            a.y + b.y{% if dim > 2 %},
            a.z + b.z{% endif %}{% if dim > 3 %},
            a.w + b.w{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator -({{ self::self_type() }} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a.x - b.x,
            a.y - b.y{% if dim > 2 %},
            a.z - b.z{% endif %}{% if dim > 3 %},
            a.w - b.w{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator *({{ self::self_type() }} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a.x * b.x,
            a.y * b.y{% if dim > 2 %},
            a.z * b.z{% endif %}{% if dim > 3 %},
            a.w * b.w{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator *({{ self::self_type() }} a, {{type}} b) => new {{ self::self_type() }}(
            a.x * b,
            a.y * b{% if dim > 2 %},
            a.z * b{% endif %}{% if dim > 3 %},
            a.w * b{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator *({{type}} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a * b.x,
            a * b.y{% if dim > 2 %},
            a * b.z{% endif %}{% if dim > 3 %},
            a * b.w{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator /({{ self::self_type() }} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a.x / b.x,
            a.y / b.y{% if dim > 2 %},
            a.z / b.z{% endif %}{% if dim > 3 %},
            a.w / b.w{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator /({{ self::self_type() }} a, {{type}} b) => new {{ self::self_type() }}(
            a.x / b,
            a.y / b{% if dim > 2 %},
            a.z / b{% endif %}{% if dim > 3 %},
            a.w / b{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator /({{type}} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a / b.x,
            a / b.y{% if dim > 2 %},
            a / b.z{% endif %}{% if dim > 3 %},
            a / b.w{% endif %});

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル
{{ self::swizzling() }}

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==({{ self::self_type() }} lhs, {{ self::self_type() }} rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=({{ self::self_type() }} lhs, {{ self::self_type() }} rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is {{ self::self_type() }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y{% if dim > 2 %}, z{% endif %}{% if dim > 3 %}, w{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{{ self::self_type() }}({x}, {y}{% if dim > 2 %}, {z}{% endif %}{% if dim > 3 %}, {w}{% endif %})";

        // IEquatable<{{ self::self_type() }}>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals({{ self::self_type() }} other)
            => other.x == x
            && other.y == y{% if dim > 2 %}
            && other.z == z{% endif %}{% if dim > 3 %}
            && other.w == w{% endif %};

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);{% if dim > 2 %}
            var z = this.z.ToString(format, formatProvider);{% endif %}{% if dim > 3 %}
            var w = this.w.ToString(format, formatProvider);{% endif %}
            return $"{{ self::self_type() }}({x}, {y}{% if dim > 2 %}, {z}{% endif %}{% if dim > 3 %}, {w}{% endif %})";
        }
    }

#pragma warning disable IDE1006 // 命名スタイル

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CS8981 // 型名には、小文字の ASCII 文字のみが含まれています。このような名前は、プログラミング言語用に予約されている可能性があります。

    public static partial class math {

#pragma warning restore CS8981 // 型名には、小文字の ASCII 文字のみが含まれています。このような名前は、プログラミング言語用に予約されている可能性があります。
#pragma warning restore IDE0079 // 不要な抑制を削除します

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} {{ self::self_type() }}({{ type }} x, {{ type }} y{% if dim > 2 %}, {{ type }} z{% endif %}{% if dim > 3 %}, {{ type }} w{% endif %}) => new {{ self::self_type() }}(x, y{% if dim > 2 %}, z{% if dim > 3 %}, w{% endif %}{% endif %}); {%- if dim > 3 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} {{ self::self_type() }}({{ type }} x, {{ type }} y, {{ self::dim_type(dim = 2) }} zw) => new {{ self::self_type() }}(x, y, zw);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} {{ self::self_type() }}({{ type }} x, {{ self::dim_type(dim = 3) }} yzw) => new {{ self::self_type() }}(x, yzw);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} {{ self::self_type() }}({{ self::dim_type(dim = 2) }} xy, {{ self::dim_type(dim = 2) }} zw) => new {{ self::self_type() }}(xy, zw);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} {{ self::self_type() }}({{ self::dim_type(dim = 4) }} xyzw) => new {{ self::self_type() }}(xyzw);
        {%- endif %} {%- if dim > 2 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} {{ self::self_type() }}({{ type }} x, {{ self::dim_type(dim = 2) }} yz{% if dim > 3 %}, {{ type }} w{% endif %}) => new {{ self::self_type() }}(x, yz{% if dim > 3 %}, w{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} {{ self::self_type() }}({{ self::dim_type(dim = 3) }} xyz{% if dim > 3 %}, {{ type }} w{% endif %}) => new {{ self::self_type() }}(xyz{% if dim > 3 %}, w{% endif %});
        {%- endif %} {%- if dim > 1 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} {{ self::self_type() }}({{ self::dim_type(dim = 2) }} xy{% if dim > 2 %}, {{ type }} z{% endif %}{% if dim > 3 %}, {{ type }} w{% endif %}) => new {{ self::self_type() }}(xy{% if dim > 2 %}, z{% endif %}{% if dim > 3 %}, w{% endif %});
        {%- endif %}
    }

#pragma warning restore IDE1006 // 命名スタイル

} {%- if unity %}

#endif{% endif %}
