{% import "macros.cs" as macros %}

{% macro dim_type(dim) -%}
    {{ macros::vector_type(dim=dim, type=type) }}
{%- endmacro -%}

{% macro swizzling() %}
        {%- if dim == 2 %}   {%- set cmp = ['X', 'Y'] %}
        {%- elif dim == 3 %} {%- set cmp = ['X', 'Y', 'Z'] %}
        {%- elif dim == 4 %} {%- set cmp = ['X', 'Y', 'Z', 'W'] %}
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

{%- set self_type = self::dim_type(dim = dim) %}

{%- if unity %}#if !UNITY_2018_3_OR_NEWER

{% endif %}using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct {{ self_type }} : IEquatable<{{ self_type }}>, IFormattable {
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

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ type }} x, {{ type }} y{% if dim > 2 %}, {{ type }} z{% endif %}{% if dim > 3 %}, {{ type }} w{% endif %}) {
            X = x;
            Y = y;{% if dim > 2 %}
            Z = z;{% if dim > 3 %}
            W = w;{% endif %}{% endif %}
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ type }} value) : this(value, value{% if dim > 2 %}, value{% endif %}{% if dim > 3 %}, value{% endif %}) { } {%- if dim > 3 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ type }} x, {{ type }} y, {{ self::dim_type(dim = 2) }} zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ type }} x, {{ self::dim_type(dim = 3) }} yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ self::dim_type(dim = 2) }} xy, {{ self::dim_type(dim = 2) }} zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ self::dim_type(dim = 4) }} xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }
        {%- endif %} {%- if dim > 2 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ type }} x, {{ self::dim_type(dim = 2) }} yz{% if dim > 3 %}, {{ type }} w{% endif %}) : this(x, yz.X, yz.Y{% if dim > 3 %}, w{% endif %}) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ self::dim_type(dim = 3) }} xyz{% if dim > 3 %}, {{ type }} w{% endif %}) : this(xyz.X, xyz.Y, xyz.Z{% if dim > 3 %}, w{% endif %}) { }
        {%- endif %} {%- if dim > 1 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ self::dim_type(dim = 2) }} xy{% if dim > 2 %}, {{ type }} z{% endif %}{% if dim > 3 %}, {{ type }} w{% endif %}) : this(xy.X, xy.Y{% if dim > 2 %}, z{% endif %}{% if dim > 3 %}, w{% endif %}) { }
        {%- endif %}

        // Constants
        // ---------------------------------------

        public static {{ self_type }} Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ self_type }}({{ type }}.Zero);
        }
        public static {{ self_type }} One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ self_type }}({{ type }}.One);
        }
        public static {{ self_type }} UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ self_type }}({{ type }}.One, {{ type }}.Zero{% if dim > 2 %}, {{ type }}.Zero{% endif %}{% if dim > 3 %}, {{ type }}.Zero{% endif %});
        }
        public static {{ self_type }} UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ self_type }}({{ type }}.Zero, {{ type }}.One{% if dim > 2 %}, {{ type }}.Zero{% endif %}{% if dim > 3 %}, {{ type }}.Zero{% endif %});
        } {%- if dim > 2 %}
        public static {{ self_type }} UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ self_type }}({{ type }}.Zero, {{ type }}.Zero, {{ type }}.One{% if dim > 3 %}, {{ type }}.Zero{% endif %});
        } {%- endif %} {%- if dim > 3 %}
        public static {{ self_type }} UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ self_type }}({{ type }}.Zero, {{ type }}.Zero, {{ type }}.Zero, {{ type }}.One);
        } {%- endif %}

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator +({{ self_type }} a, {{ self_type }} b) => new {{ self_type }}(
            a.X + b.X,
            a.Y + b.Y{% if dim > 2 %},
            a.Z + b.Z{% if dim > 3 %},
            a.W + b.W{% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator -({{ self_type }} a, {{ self_type }} b) => new {{ self_type }}(
            a.X - b.X,
            a.Y - b.Y{% if dim > 2 %},
            a.Z - b.Z{% if dim > 3 %},
            a.W - b.W{% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator *({{ self_type }} a, {{ self_type }} b) => new {{ self_type }}(
            a.X * b.X,
            a.Y * b.Y{% if dim > 2 %},
            a.Z * b.Z{% if dim > 3 %},
            a.W * b.W{% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator *({{ self_type }} a, {{type}} b) => new {{ self_type }}(
            a.X * b,
            a.Y * b{% if dim > 2 %},
            a.Z * b{% if dim > 3 %},
            a.W * b{% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator *({{type}} a, {{ self_type }} b) => new {{ self_type }}(
            a * b.X,
            a * b.Y{% if dim > 2 %},
            a * b.Z{% if dim > 3 %},
            a * b.W{% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator /({{ self_type }} a, {{ self_type }} b) => new {{ self_type }}(
            a.X / b.X,
            a.Y / b.Y{% if dim > 2 %},
            a.Z / b.Z{% if dim > 3 %},
            a.W / b.W{% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator /({{ self_type }} a, {{type}} b) => new {{ self_type }}(
            a.X / b,
            a.Y / b{% if dim > 2 %},
            a.Z / b{% if dim > 3 %},
            a.W / b{% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator /({{type}} a, {{ self_type }} b) => new {{ self_type }}(
            a / b.X,
            a / b.Y{% if dim > 2 %},
            a / b.Z{% if dim > 3 %},
            a / b.W{% endif %}{% endif %});

        // Swizzling Properties
        // ---------------------------------------
{{ self::swizzling() }}

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==({{ self_type }} lhs, {{ self_type }} rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=({{ self_type }} lhs, {{ self_type }} rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is {{ self_type }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y{% if dim > 2 %}, Z{% endif %}{% if dim > 3 %}, W{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}{% if dim > 2 %}, {Z}{% if dim > 3 %}, {W}{% endif %}{% endif %}>";

        // IEquatable<{{ self_type }}>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals({{ self_type }} other)
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
            return $"<{x}, {y}{% if dim > 2 %}, {z}{% if dim > 3 %}, {w}{% endif %}{% endif %}>";
        }

        // Methods
        // ---------------------------------------

        public readonly {{ self_type }} Half() => new {{ self_type }}(
            X.Half(),
            Y.Half(){% if dim > 2 %},
            Z.Half(){% if dim > 3 %},
            W.Half(){% endif %}{% endif %});

        public readonly {{ self_type }} Twice() => new {{ self_type }}(
            X.Twice(),
            Y.Twice(){% if dim > 2 %},
            Z.Twice(){% if dim > 3 %},
            W.Twice(){% endif %}{% endif %});

        public readonly {{ self_type }} Clamp({{ type }} min, {{ type }} max) => new {{ self_type }}(
            X.Clamp(min, max),
            Y.Clamp(min, max){% if dim > 2 %},
            Z.Clamp(min, max){% if dim > 3 %},
            W.Clamp(min, max){% endif %}{% endif %});

        public readonly {{ self_type }} Clamp(
            {{ self_type }} min, {{ self_type }} max
        ) => new {{ self_type }}(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y){% if dim > 2 %},
            Z.Clamp(min.Z, max.Z){% if dim > 3 %},
            W.Clamp(min.W, max.W){% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly {{ self_type }} SaturatingAdd({{ self_type }} other) => new {{ self_type }}(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y){% if dim > 2 %},
            Z.SaturatingAdd(other.Z){% if dim > 3 %},
            W.SaturatingAdd(other.W){% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly {{ self_type }} SaturatingMul({{ type }} other) => new {{ self_type }}(
            X.SaturatingMul(other),
            Y.SaturatingMul(other){% if dim > 2 %},
            Z.SaturatingMul(other){% if dim > 3 %},
            W.SaturatingMul(other){% endif %}{% endif %});

        {%- if type == "I17F15" %}
        {%- for name in [
            "SinP2",
            "SinP3A16384",
            "SinP4A7032",
            "SinP4A7384",
            "SinP5A51472",
            "SinP5A51437",
            "CosP2",
            "CosP3A16384",
            "CosP4A7032",
            "CosP4A7384",
            "CosP5A51472",
            "CosP5A51437",
        ] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly {{ macros::vector_type(dim=dim, type="I2F30") }} {{ name }}() => new {{ macros::vector_type(dim=dim, type="I2F30") }}(
            X.{{ name }}(),
            Y.{{ name }}(){% if dim > 2 %},
            Z.{{ name }}(){% if dim > 3 %},
            W.{{ name }}(){% endif %}{% endif %});

        {%- endfor %}
        {%- endif %}

    }
} {%- if unity %}

#endif{% endif %}
