{% import "macros.cs" as macros %}

{% macro swizzling(component_type) %}
        {%- if dim == 2 %}   {%- set cmp = ['X', 'Y'] %}
        {%- elif dim == 3 %} {%- set cmp = ['X', 'Y', 'Z'] %}
        {%- elif dim == 4 %} {%- set cmp = ['X', 'Y', 'Z', 'W'] %}
        {%- else %}          {{- "Unexpected dim. dim: " ~ dim }}
        {%- endif -%}
        {%- for x in cmp %}
        {%- for y in cmp %}
        public readonly {{ macros::vector_type(dim=2, type=component_type) }} {{ x }}{{ y }} { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ macros::vector_type(dim=2, type=component_type) }}({{ x }}, {{ y }}); }
        {%- endfor %}
        {%- endfor %}
        {%- for x in cmp %}
        {%- for y in cmp %}
        {%- for z in cmp %}
        public readonly {{ macros::vector_type(dim=3, type=component_type) }} {{ x }}{{ y }}{{ z }} { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ macros::vector_type(dim=3, type=component_type) }}({{ x }}, {{ y }}, {{ z }}); }
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
        {%- for x in cmp %}
        {%- for y in cmp %}
        {%- for z in cmp %}
        {%- for w in cmp %}
        public readonly {{ macros::vector_type(dim=4, type=component_type) }} {{ x }}{{ y }}{{ z }}{{ w }} { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new {{ macros::vector_type(dim=4, type=component_type) }}({{ x }}, {{ y }}, {{ z }}, {{ w }}); }
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
{%- endmacro -%}

{%- set self_bits_type = macros::bits_type(s=signed, i=int_nbits, f=frac_nbits) %}
{%- set self_wide_bits_type = macros::wide_type(type=self_bits_type) %}
{%- set self_component_type = macros::fixed_type(s=signed, i=int_nbits, f=frac_nbits) %}
{%- set self_type = macros::vector_type(dim=dim, type=self_component_type) %}

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

        public {{ self_component_type }} X;
        public {{ self_component_type }} Y;{% if dim > 2 %}
        public {{ self_component_type }} Z;{% if dim > 3 %}
        public {{ self_component_type }} W;{% endif %}{% endif %}

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ self_component_type }} x, {{ self_component_type }} y{% if dim > 2 %}, {{ self_component_type }} z{% endif %}{% if dim > 3 %}, {{ self_component_type }} w{% endif %}) {
            X = x;
            Y = y;{% if dim > 2 %}
            Z = z;{% if dim > 3 %}
            W = w;{% endif %}{% endif %}
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ self_component_type }} value) : this(value, value{% if dim > 2 %}, value{% endif %}{% if dim > 3 %}, value{% endif %}) { } {%- if dim > 3 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ self_component_type }} x, {{ self_component_type }} y, {{ macros::vector_type(dim=2, type=self_component_type) }} zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ self_component_type }} x, {{ macros::vector_type(dim=3, type=self_component_type) }} yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ macros::vector_type(dim=2, type=self_component_type) }} xy, {{ macros::vector_type(dim=2, type=self_component_type) }} zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ macros::vector_type(dim=4, type=self_component_type) }} xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }
        {%- endif %} {%- if dim > 2 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ self_component_type }} x, {{ macros::vector_type(dim=2, type=self_component_type) }} yz{% if dim > 3 %}, {{ self_component_type }} w{% endif %}) : this(x, yz.X, yz.Y{% if dim > 3 %}, w{% endif %}) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ macros::vector_type(dim=3, type=self_component_type) }} xyz{% if dim > 3 %}, {{ self_component_type }} w{% endif %}) : this(xyz.X, xyz.Y, xyz.Z{% if dim > 3 %}, w{% endif %}) { }
        {%- endif %} {%- if dim > 1 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ macros::vector_type(dim=2, type=self_component_type) }} xy{% if dim > 2 %}, {{ self_component_type }} z{% endif %}{% if dim > 3 %}, {{ self_component_type }} w{% endif %}) : this(xy.X, xy.Y{% if dim > 2 %}, z{% endif %}{% if dim > 3 %}, w{% endif %}) { }
        {%- endif %}

        // Constants
        // ---------------------------------------

        public static {{ self_type }} Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ self_type }}({{ self_component_type }}.Zero);
        }
        public static {{ self_type }} One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ self_type }}({{ self_component_type }}.One);
        }
        public static {{ self_type }} UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ self_type }}({{ self_component_type }}.One, {{ self_component_type }}.Zero{% if dim > 2 %}, {{ self_component_type }}.Zero{% endif %}{% if dim > 3 %}, {{ self_component_type }}.Zero{% endif %});
        }
        public static {{ self_type }} UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ self_type }}({{ self_component_type }}.Zero, {{ self_component_type }}.One{% if dim > 2 %}, {{ self_component_type }}.Zero{% endif %}{% if dim > 3 %}, {{ self_component_type }}.Zero{% endif %});
        } {%- if dim > 2 %}
        public static {{ self_type }} UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ self_type }}({{ self_component_type }}.Zero, {{ self_component_type }}.Zero, {{ self_component_type }}.One{% if dim > 3 %}, {{ self_component_type }}.Zero{% endif %});
        } {%- endif %} {%- if dim > 3 %}
        public static {{ self_type }} UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ self_type }}({{ self_component_type }}.Zero, {{ self_component_type }}.Zero, {{ self_component_type }}.Zero, {{ self_component_type }}.One);
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
        public static {{ self_type }} operator *({{ self_type }} a, {{self_component_type}} b) => new {{ self_type }}(
            a.X * b,
            a.Y * b{% if dim > 2 %},
            a.Z * b{% if dim > 3 %},
            a.W * b{% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator *({{ self_component_type }} a, {{ self_type }} b) => new {{ self_type }}(
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
        public static {{ self_type }} operator /({{ self_type }} a, {{ self_component_type }} b) => new {{ self_type }}(
            a.X / b,
            a.Y / b{% if dim > 2 %},
            a.Z / b{% if dim > 3 %},
            a.W / b{% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator /({{ self_component_type }} a, {{ self_type }} b) => new {{ self_type }}(
            a / b.X,
            a / b.Y{% if dim > 2 %},
            a / b.Z{% if dim > 3 %},
            a / b.W{% endif %}{% endif %});

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==({{ self_type }} lhs, {{ self_type }} rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=({{ self_type }} lhs, {{ self_type }} rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------
{{ self::swizzling(component_type=self_component_type) }}

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

        public readonly {{ self_type }} Clamp({{ self_component_type }} min, {{ self_component_type }} max) => new {{ self_type }}(
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
        public readonly {{ self_type }} SaturatingMul({{ self_component_type }} other) => new {{ self_type }}(
            X.SaturatingMul(other),
            Y.SaturatingMul(other){% if dim > 2 %},
            Z.SaturatingMul(other){% if dim > 3 %},
            W.SaturatingMul(other){% endif %}{% endif %});

        {%- if signed and dim == 3 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CrossInternal({{ self_type }} other, out {{ self_wide_bits_type }} x, out {{ self_wide_bits_type }} y, out {{ self_wide_bits_type }} z) {
            var ax = ({{ self_wide_bits_type }})X.Bits;
            var ay = ({{ self_wide_bits_type }})Y.Bits;
            var az = ({{ self_wide_bits_type }})Z.Bits;
            var bx = ({{ self_wide_bits_type }})other.X.Bits;
            var by = ({{ self_wide_bits_type }})other.Y.Bits;
            var bz = ({{ self_wide_bits_type }})other.Z.Bits;

            x = (ay * bz) - (az * by);
            y = (az * bx) - (ax * bz);
            z = (ax * by) - (ay * bx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly {{ self_type }} Cross({{ self_type }} other) {
            const {{ self_wide_bits_type }} k =
            {%- if self_wide_bits_type == "long" %} 1L
            {%- elif self_wide_bits_type == "ulong" %} 1UL
            {%- else %}{{ throw(message = "invalid arguments. self_wide_bits_type: " ~ self_wide_bits_type) }}
            {%- endif %} << {{ frac_nbits }};
            CrossInternal(other, out var x, out var y, out var z);
            return new {{ self_type }}(
                {{ self_component_type }}.FromBits(({{ self_bits_type }})(x / k)),
                {{ self_component_type }}.FromBits(({{ self_bits_type }})(y / k)),
                {{ self_component_type }}.FromBits(({{ self_bits_type }})(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly {{ self_type }} SaturatingCross({{ self_type }} other) {
            const {{ self_wide_bits_type }} k =
            {%- if self_wide_bits_type == "long" %} 1L
            {%- elif self_wide_bits_type == "ulong" %} 1UL
            {%- else %}{{ throw(message = "invalid arguments. self_wide_bits_type: " ~ self_wide_bits_type) }}
            {%- endif %} << {{ frac_nbits }};
            CrossInternal(other, out var x, out var y, out var z);
            {%- for component in ["x", "y", "z"] %}
            {{ component }} /= k;
            if ({{ component }} > {{ self_bits_type }}.MaxValue) {
                {{ component }} = {{ self_bits_type }}.MaxValue;
            } else if ({{ component }} < {{ self_bits_type }}.MinValue) {
                {{ component }} = {{ self_bits_type }}.MinValue;
            }
            {%- endfor %}
            return new {{ self_type }}(
                {{ self_component_type }}.FromBits(({{ self_bits_type }})x),
                {{ self_component_type }}.FromBits(({{ self_bits_type }})y),
                {{ self_component_type }}.FromBits(({{ self_bits_type }})z));
        }

        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly {{ self_wide_bits_type }} DotInternal({{ self_type }} other) {
            var x = (({{ self_wide_bits_type }})X.Bits) * other.X.Bits;
            var y = (({{ self_wide_bits_type }})Y.Bits) * other.Y.Bits;{% if dim > 2 %}
            var z = (({{ self_wide_bits_type }})Z.Bits) * other.Z.Bits;{% if dim > 3 %}
            var w = (({{ self_wide_bits_type }})W.Bits) * other.W.Bits;{% endif %}{% endif %}

            // オーバーフローを避けるため､ 事前に除算する｡
            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算に合わせて常に 4 で除算する｡
            return
                (x / 4) +
                (y / 4){% if dim > 2 %} +
                (z / 4){% if dim > 3 %} +
                (w / 4){% endif %}{% endif %};
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly {{ self_component_type }} Dot({{ self_type }} other) {
            const {{ self_wide_bits_type }} k =
            {%- if self_wide_bits_type == "long" %} 1L
            {%- elif self_wide_bits_type == "ulong" %} 1UL
            {%- else %}{{ throw(message = "invalid arguments. self_wide_bits_type: " ~ self_wide_bits_type) }}
            {%- endif %} << {{ frac_nbits - 2 }};
            return {{ self_component_type }}.FromBits(({{ self_bits_type }})(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly {{ self_component_type }} SaturatingDot({{ self_type }} other) {
            const {{ self_wide_bits_type }} k =
            {%- if self_wide_bits_type == "long" %} 1L
            {%- elif self_wide_bits_type == "ulong" %} 1UL
            {%- else %}{{ throw(message = "invalid arguments. self_wide_bits_type: " ~ self_wide_bits_type) }}
            {%- endif %} << {{ frac_nbits - 2 }};
            var bits = DotInternal(other) / k;
            if (bits > {{ self_bits_type }}.MaxValue) {
                return {{ self_component_type }}.MaxValue;
            {%- if signed %}
            } else if (bits < {{ self_bits_type }}.MinValue) {
                return {{ self_component_type }}.MinValue;
            {%- endif %}
            } else {
                return {{ self_component_type }}.FromBits(({{ self_bits_type }})bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly {{ self_wide_bits_type }} LengthSquaredInternal() => DotInternal(this);

        /// <summary>
        /// ベクトルの長さの 2 乗を返します｡
        /// </summary>
        /// <remarks>
        /// オーバーフローを防ぐため､ 計算の過程で 4 で除算しています｡
        /// そのため､ 精度が犠牲になっています｡
        /// また､ 戻り値の型もそれに準じて小数部が 2 ビット小さい型になっています｡
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly {{ macros::fixed_type(s=signed, i=2*int_nbits+2, f=2*frac_nbits-2) }} LengthSquared() {
            return {{ macros::fixed_type(s=signed, i=2*int_nbits+2, f=2*frac_nbits-2) }}.FromBits(LengthSquaredInternal());
        }

        {%- if self_component_type == "I17F15" %}
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

    partial struct {{ self_component_type }} {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly {{ self_type }} SaturatingMul({{ self_type }} other) => other.SaturatingMul(this);
    }
} {%- if unity %}

#endif{% endif %}
