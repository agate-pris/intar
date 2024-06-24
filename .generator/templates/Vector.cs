{% macro dim_type(dim) -%}
    Vector{{ dim }}{{ type }}
{%- endmacro -%}

{% macro self_type() -%}
    {{ self::dim_type(dim = dim) }}
{%- endmacro -%}

{% macro swizzling() %}
        {%- if dim == 2 %}   {%- set cmp = ['x', 'y'] %}
        {%- elif dim == 3 %} {%- set cmp = ['x', 'y', 'z'] %}
        {%- elif dim == 4 %} {%- set cmp = ['x', 'y', 'z', 'w'] %}
        {%- else %}          {{- "Unexpected dim. dim: " ~ dim }}
        {%- endif -%}
        {%- for x in cmp %}
        {%- for y in cmp %}
        public readonly {{ self::dim_type(dim = 2) }} {{ x }}{{ y }} { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 2) }}({% filter upper %}{{ x }}, {{ y }}{% endfilter %}); }
        {%- endfor %}
        {%- endfor %}
        {%- for x in cmp %}
        {%- for y in cmp %}
        {%- for z in cmp %}
        public readonly {{ self::dim_type(dim = 3) }} {{ x }}{{ y }}{{ z }} { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 3) }}({% filter upper %}{{ x }}, {{ y }}, {{ z }}{% endfilter %}); }
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
        {%- for x in cmp %}
        {%- for y in cmp %}
        {%- for z in cmp %}
        {%- for w in cmp %}
        public readonly {{ self::dim_type(dim = 4) }} {{ x }}{{ y }}{{ z }}{{ w }} { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ self::dim_type(dim = 4) }}({% filter upper %}{{ x }}, {{ y }}, {{ z }}, {{ w }}{% endfilter %}); }
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
{%- endmacro -%}

{% if unity %}#if !UNITY_2018_3_OR_NEWER

{% endif %}using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct {{ self::self_type() }} : IEquatable<{{ self::self_type() }}>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public {{ type }} X;
        public {{ type }} Y;{% if dim > 2 %}
        public {{ type }} Z;{% if dim > 3 %}
        public {{ type }} W;{% endif %}{% endif %}

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly {{ self::self_type() }} zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ type }} x, {{ type }} y{% if dim > 2 %}, {{ type }} z{% endif %}{% if dim > 3 %}, {{ type }} w{% endif %}) {
            X = x;
            Y = y;{% if dim > 2 %}
            Z = z;{% if dim > 3 %}
            W = w;{% endif %}{% endif %}
        } {%- if dim > 3 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ type }} x, {{ type }} y, {{ self::dim_type(dim = 2) }} zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ type }} x, {{ self::dim_type(dim = 3) }} yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ self::dim_type(dim = 2) }} xy, {{ self::dim_type(dim = 2) }} zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ self::dim_type(dim = 4) }} xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }
        {%- endif %} {%- if dim > 2 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ type }} x, {{ self::dim_type(dim = 2) }} yz{% if dim > 3 %}, {{ type }} w{% endif %}) : this(x, yz.X, yz.Y{% if dim > 3 %}, w{% endif %}) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ self::dim_type(dim = 3) }} xyz{% if dim > 3 %}, {{ type }} w{% endif %}) : this(xyz.X, xyz.Y, xyz.Z{% if dim > 3 %}, w{% endif %}) { }
        {%- endif %} {%- if dim > 1 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self::self_type() }}({{ self::dim_type(dim = 2) }} xy{% if dim > 2 %}, {{ type }} z{% endif %}{% if dim > 3 %}, {{ type }} w{% endif %}) : this(xy.X, xy.Y{% if dim > 2 %}, z{% endif %}{% if dim > 3 %}, w{% endif %}) { }
        {%- endif %}

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator +({{ self::self_type() }} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a.X + b.X,
            a.Y + b.Y{% if dim > 2 %},
            a.Z + b.Z{% if dim > 3 %},
            a.W + b.W{% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator -({{ self::self_type() }} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a.X - b.X,
            a.Y - b.Y{% if dim > 2 %},
            a.Z - b.Z{% if dim > 3 %},
            a.W - b.W{% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator *({{ self::self_type() }} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a.X * b.X,
            a.Y * b.Y{% if dim > 2 %},
            a.Z * b.Z{% if dim > 3 %},
            a.W * b.W{% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator *({{ self::self_type() }} a, {{type}} b) => new {{ self::self_type() }}(
            a.X * b,
            a.Y * b{% if dim > 2 %},
            a.Z * b{% if dim > 3 %},
            a.W * b{% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator *({{type}} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a * b.X,
            a * b.Y{% if dim > 2 %},
            a * b.Z{% if dim > 3 %},
            a * b.W{% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator /({{ self::self_type() }} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a.X / b.X,
            a.Y / b.Y{% if dim > 2 %},
            a.Z / b.Z{% if dim > 3 %},
            a.W / b.W{% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator /({{ self::self_type() }} a, {{type}} b) => new {{ self::self_type() }}(
            a.X / b,
            a.Y / b{% if dim > 2 %},
            a.Z / b{% if dim > 3 %},
            a.W / b{% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self::self_type() }} operator /({{type}} a, {{ self::self_type() }} b) => new {{ self::self_type() }}(
            a / b.X,
            a / b.Y{% if dim > 2 %},
            a / b.Z{% if dim > 3 %},
            a / b.W{% endif %}{% endif %});

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
        public override readonly int GetHashCode() => HashCode.Combine(X, Y{% if dim > 2 %}, Z{% endif %}{% if dim > 3 %}, W{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"{{ self::self_type() }}({X}, {Y}{% if dim > 2 %}, {Z}{% endif %}{% if dim > 3 %}, {W}{% endif %})";

        // IEquatable<{{ self::self_type() }}>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals({{ self::self_type() }} other)
            => other.X == X
            && other.Y == Y{% if dim > 2 %}
            && other.Z == Z{% if dim > 3 %}
            && other.W == W{% endif %}{% endif %};

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);{% if dim > 2 %}
            var z = Z.ToString(format, formatProvider);{% if dim > 3 %}
            var w = W.ToString(format, formatProvider);{% endif %}{% endif %}
            return $"{{ self::self_type() }}({x}, {y}{% if dim > 2 %}, {z}{% endif %}{% if dim > 3 %}, {w}{% endif %})";
        }
    }
} {%- if unity %}

#endif{% endif %}
