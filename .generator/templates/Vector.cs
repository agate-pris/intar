{% import "macros.cs" as macros %}

{% macro swizzling(component_type) %}
        {%- if   dim == 2 %} {%- set cmp = ['X', 'Y'          ] %}
        {%- elif dim == 3 %} {%- set cmp = ['X', 'Y', 'Z'     ] %}
        {%- elif dim == 4 %} {%- set cmp = ['X', 'Y', 'Z', 'W'] %}
        {%- else %} {{- "Unexpected dim. dim: " ~ dim }}
        {%- endif -%}
        {%- for x in cmp %}
        {%- for y in cmp %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ macros::vector_type(dim=2, type=component_type) }} {{ x }}{{ y }}() => new {{ macros::vector_type(dim=2, type=component_type) }}({{ x }}, {{ y }});
        {%- endfor %}
        {%- endfor %}
        {%- for x in cmp %}
        {%- for y in cmp %}
        {%- for z in cmp %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ macros::vector_type(dim=3, type=component_type) }} {{ x }}{{ y }}{{ z }}() => new {{ macros::vector_type(dim=3, type=component_type) }}({{ x }}, {{ y }}, {{ z }});
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
        {%- for x in cmp %}
        {%- for y in cmp %}
        {%- for z in cmp %}
        {%- for w in cmp %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ macros::vector_type(dim=4, type=component_type) }} {{ x }}{{ y }}{{ z }}{{ w }}() => new {{ macros::vector_type(dim=4, type=component_type) }}({{ x }}, {{ y }}, {{ z }}, {{ w }});
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
{%- endmacro -%}

{%- set self_bits_type = macros::bits_type(s=signed, i=int_nbits, f=frac_nbits) %}
{%- set self_bits_signed_type = macros::signed_type(t=self_bits_type) %}
{%- set self_bits_unsigned_type = macros::unsigned_type(t=self_bits_type) %}
{%- set self_wide_bits_type = macros::wide_type(type=self_bits_type) %}
{%- set self_wide_bits_signed_type = macros::signed_type(t=self_wide_bits_type) %}
{%- set self_wide_bits_unsigned_type = macros::unsigned_type(t=self_wide_bits_type) %}
{%- set self_component_type = macros::fixed_type(s=signed, i=int_nbits, f=frac_nbits) %}
{%- set self_component_signed_type = macros::fixed_type(s=true, i=int_nbits, f=frac_nbits) %}
{%- set self_component_unsigned_type = macros::fixed_type(s=false, i=int_nbits, f=frac_nbits) %}
{%- set self_length_squared_unsigned_type = macros::fixed_type(s=false, i=2*int_nbits+2, f=2*frac_nbits-2) %}
{%- set self_length_squared_signed_type = macros::fixed_type(s=true, i=2*int_nbits+2, f=2*frac_nbits-2) %}
{%- set self_length_squared_type = macros::fixed_type(s=signed, i=2*int_nbits+2, f=2*frac_nbits-2) %}
{%- set self_length_unsigned_type = macros::fixed_type(s=false, i=int_nbits+1, f=frac_nbits-1) %}
{%- set self_length_signed_type = macros::fixed_type(s=true, i=int_nbits+1, f=frac_nbits-1) %}
{%- set self_length_type = macros::fixed_type(s=signed, i=int_nbits+1, f=frac_nbits-1) %}
{%- set self_type = macros::vector_type(dim=dim, type=self_component_type) -%}

using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct {{ self_type }}
    : IEquatable<{{ self_type }}>
    , IFormattable
    , IVector<{{ self_length_squared_unsigned_type }}, {{ self_length_squared_signed_type }}, {{ self_length_unsigned_type }}, {{ self_length_signed_type }}>
    , IVectorComponentRespective<{{ self_component_type }}> {
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

        // Indexer
        // ---------------------------------------

        public {{ self_component_type }} this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                switch (index) {
                    case 0: return X;
                    case 1: return Y;{% if dim > 2 %}
                    case 2: return Z;{% if dim > 3 %}
                    case 3: return W;{% endif %}{% endif %}
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                switch (index) {
                    case 0: X = value; break;
                    case 1: Y = value; break;{% if dim > 2 %}
                    case 2: Z = value; break;{% if dim > 3 %}
                    case 3: W = value; break;{% endif %}{% endif %}
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
        }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is {{ self_type }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y{% if dim > 2 %}, Z{% endif %}{% if dim > 3 %}, W{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}{% if dim > 2 %}, {Z}{% if dim > 3 %}, {W}{% endif %}{% endif %}>";

        // IEquatable<{{ self_type }}>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ self_type }} other)
            => other.X == X
            && other.Y == Y{% if dim > 2 %}
            && other.Z == Z{% if dim > 3 %}
            && other.W == W{% endif %}{% endif %};

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);{% if dim > 2 %}
            var z = Z.ToString(format, formatProvider);{% if dim > 3 %}
            var w = W.ToString(format, formatProvider);{% endif %}{% endif %}
            return $"<{x}, {y}{% if dim > 2 %}, {z}{% if dim > 3 %}, {w}{% endif %}{% endif %}>";
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} Min({{ self_type }} other) => new {{ self_type }}(
            X.Min(other.X),
            Y.Min(other.Y){% if dim > 2 %},
            Z.Min(other.Z){% if dim > 3 %},
            W.Min(other.W){% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} Max({{ self_type }} other) => new {{ self_type }}(
            X.Max(other.X),
            Y.Max(other.Y){% if dim > 2 %},
            Z.Max(other.Z){% if dim > 3 %},
            W.Max(other.W){% endif %}{% endif %});

        {%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} Abs() => new {{ self_type }}(
            X.Abs(),
            Y.Abs(){% if dim > 2 %},
            Z.Abs(){% if dim > 3 %},
            W.Abs(){% endif %}{% endif %});

        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} Half() => new {{ self_type }}(
            X.Half(),
            Y.Half(){% if dim > 2 %},
            Z.Half(){% if dim > 3 %},
            W.Half(){% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} Twice() => new {{ self_type }}(
            X.Twice(),
            Y.Twice(){% if dim > 2 %},
            Z.Twice(){% if dim > 3 %},
            W.Twice(){% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} Clamp({{ self_component_type }} min, {{ self_component_type }} max) => new {{ self_type }}(
            X.Clamp(min, max),
            Y.Clamp(min, max){% if dim > 2 %},
            Z.Clamp(min, max){% if dim > 3 %},
            W.Clamp(min, max){% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} Clamp(
            {{ self_type }} min, {{ self_type }} max
        ) => new {{ self_type }}(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y){% if dim > 2 %},
            Z.Clamp(min.Z, max.Z){% if dim > 3 %},
            W.Clamp(min.W, max.W){% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} WrappingAdd({{ self_type }} other) => new {{ self_type }}(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y){% if dim > 2 %},
            Z.WrappingAdd(other.Z){% if dim > 3 %},
            W.WrappingAdd(other.W){% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} WrappingSub({{ self_type }} other) => new {{ self_type }}(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y){% if dim > 2 %},
            Z.WrappingSub(other.Z){% if dim > 3 %},
            W.WrappingSub(other.W){% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} WrappingMul({{ self_type }} other) => new {{ self_type }}(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y){% if dim > 2 %},
            Z.WrappingMul(other.Z){% if dim > 3 %},
            W.WrappingMul(other.W){% endif %}{% endif %});

        {%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} WrappingAddUnsigned({{ macros::vector_type(dim=dim, type=macros::fixed_type(s=false, i=int_nbits, f=frac_nbits)) }} other) => new {{ self_type }}(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y){% if dim > 2 %},
            Z.WrappingAddUnsigned(other.Z){% if dim > 3 %},
            W.WrappingAddUnsigned(other.W){% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} WrappingSubUnsigned({{ macros::vector_type(dim=dim, type=macros::fixed_type(s=false, i=int_nbits, f=frac_nbits)) }} other) => new {{ self_type }}(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y){% if dim > 2 %},
            Z.WrappingSubUnsigned(other.Z){% if dim > 3 %},
            W.WrappingSubUnsigned(other.W){% endif %}{% endif %});
        {%- else %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} WrappingAddSigned({{ macros::vector_type(dim=dim, type=macros::fixed_type(s=true, i=int_nbits, f=frac_nbits)) }} other) => new {{ self_type }}(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y){% if dim > 2 %},
            Z.WrappingAddSigned(other.Z){% if dim > 3 %},
            W.WrappingAddSigned(other.W){% endif %}{% endif %});
        {%- endif %}

        {%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ macros::vector_type(dim=dim, type=macros::fixed_type(s=false, i=int_nbits, f=frac_nbits)) }} UnsignedAbs() => new {{ macros::vector_type(dim=dim, type=macros::fixed_type(s=false, i=int_nbits, f=frac_nbits)) }}(
            X.UnsignedAbs(),
            Y.UnsignedAbs(){% if dim > 2 %},
            Z.UnsignedAbs(){% if dim > 3 %},
            W.UnsignedAbs(){% endif %}{% endif %});

        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} SaturatingAdd({{ self_type }} other) => new {{ self_type }}(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y){% if dim > 2 %},
            Z.SaturatingAdd(other.Z){% if dim > 3 %},
            W.SaturatingAdd(other.W){% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} SaturatingMul({{ self_component_type }} other) => new {{ self_type }}(
            X.SaturatingMul(other),
            Y.SaturatingMul(other){% if dim > 2 %},
            Z.SaturatingMul(other){% if dim > 3 %},
            W.SaturatingMul(other){% endif %}{% endif %});

        {%- if signed and dim == 3 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CrossInternal({{ self_type }} other, out {{ self_wide_bits_type }} x, out {{ self_wide_bits_type }} y, out {{ self_wide_bits_type }} z) {
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
        public {{ self_type }} Cross({{ self_type }} other) {
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
        public {{ self_type }} SaturatingCross({{ self_type }} other) {
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
        {{ self_wide_bits_type }} DotInternal({{ self_type }} other) {
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
        public {{ self_component_type }} Dot({{ self_type }} other) {
            const {{ self_wide_bits_type }} k =
            {%- if self_wide_bits_type == "long" %} 1L
            {%- elif self_wide_bits_type == "ulong" %} 1UL
            {%- else %}{{ throw(message = "invalid arguments. self_wide_bits_type: " ~ self_wide_bits_type) }}
            {%- endif %} << {{ frac_nbits - 2 }};
            return {{ self_component_type }}.FromBits(({{ self_bits_type }})(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_component_type }} SaturatingDot({{ self_type }} other) {
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
        {{ self_wide_bits_type }} LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_length_squared_unsigned_type }} LengthSquaredUnsigned() => {{ self_length_squared_unsigned_type }}.FromBits(
            {% if signed %}({{ self_wide_bits_unsigned_type }}){% endif %}LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_length_squared_signed_type }} LengthSquaredSigned() => {{ self_length_squared_signed_type }}.FromBits(
            {% if not signed %}({{ self_wide_bits_signed_type }}){% endif %}LengthSquaredInternal()
        );

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        /// <remarks>
        /// <div class="TIP alert alert-info">
        /// <h5>Tip</h5>
        /// <para>This method divides the square of each element by 4
        /// during the calculation to prevent overflow.</para>
        /// <para>このメソッドはオーバーフローを防ぐため､
        /// 計算の過程で各要素の 2 乗を 4 で除算します｡
        /// そのため､ 精度が犠牲になっています｡
        /// また､ 戻り値の型もそれに準じて小数部が 2 ビット小さい型になっています｡</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_length_squared_type }} LengthSquared() => LengthSquared{% if signed %}Signed{% else %}Unsigned{% endif %}();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        {{ self_bits_unsigned_type }} LengthInternal() {
            {%- if signed %}
            var squared = LengthSquaredInternal();
            return ({{ self_bits_unsigned_type }})Mathi.Sqrt(({{ self_wide_bits_unsigned_type }})squared);
            {%- else %}
            return ({{ self_bits_unsigned_type }})Mathi.Sqrt(LengthSquaredInternal());
            {%- endif %}
        }

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <see cref="LengthHalf{% if not signed %}Signed{% endif %}">LengthHalf{% if not signed %}Signed{% endif %}</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="LengthHalf{% if not signed %}Signed{% endif %}">LengthHalf{% if not signed %}Signed{% endif %}</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf{% if not signed %}Signed{% endif %}"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_component_unsigned_type }} LengthHalf{% if signed %}Unsigned
        {%- endif %}() => {{ self_component_unsigned_type }}.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="LengthHalf{% if signed %}Unsigned{% endif %}">LengthHalf{% if signed %}Unsigned{% endif %}</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthHalf{% if signed %}Unsigned{% endif %}">LengthHalf{% if signed %}Unsigned{% endif %}</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf{% if signed %}Unsigned{% endif %}"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_component_signed_type }} LengthHalf{% if not signed %}Signed
        {%- endif %}() => {{ self_component_signed_type }}.FromBits(checked(({{ self_bits_signed_type }})LengthInternal()));

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <see cref="LengthSigned">LengthSigned</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="LengthSigned">LengthSigned</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf{%if signed %}Unsigned{% endif %}"/>
        /// <seealso cref="LengthSigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_length_unsigned_type }} LengthUnsigned() => {{ self_length_unsigned_type }}.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="LengthUnsigned">LengthUnsigned</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthUnsigned">LengthUnsigned</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf{%if not signed %}Signed{% endif %}"/>
        /// <seealso cref="LengthUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_length_signed_type }} LengthSigned() => {{ self_length_signed_type }}.FromBits(checked(({{ self_bits_signed_type }})LengthInternal()));

        {%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_length_type }} Length() => LengthSigned();
        {%- else %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_length_type }} Length() => LengthUnsigned();
        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}? Normalize() {
            {% if signed -%}

            var x0 = X.Bits;
            var x1 = Y.Bits;{% if dim > 2 %}
            var x2 = Z.Bits;{% if dim > 3 %}
            var x3 = W.Bits;{% endif %}{% endif %}

            {%- for i in range(end=dim) %}
            var b{{ i }} = x{{ i }} < 0;
            {%- endfor %}

            {%- for i in range(end=dim) %}
            var a{{ i }} = unchecked(({{ self_bits_unsigned_type }})(b{{ i }} ? Overflowing.WrappingNeg(x{{ i }}) : x{{ i }}));
            {%- endfor %}

            {%- else -%}

            var a0 = X.Bits;
            var a1 = Y.Bits;{% if dim > 2 %}
            var a2 = Z.Bits;{% if dim > 3 %}
            var a3 = W.Bits;{% endif %}{% endif %}

            {%- endif %}

            var max = a0.Max(a1){% if dim > 2 %}.Max(a2){% if dim > 3 %}.Max(a3){% endif %}{% endif %};
            if (max == 0) {
                return null;
            }

            {{ self_wide_bits_unsigned_type }} m = {{ self_bits_unsigned_type }}.MaxValue / max;

            {%- for i in range(end=dim) %}
            var l{{ i }} = m * a{{ i }};
            {%- endfor %}
            var sum =
                (l0 * l0 / 4) +
                (l1 * l1 / 4){% if dim > 2 %} +
                (l2 * l2 / 4){% if dim > 3 %} +
                (l3 * l3 / 4){% endif %}{% endif %};
            var ll = Mathi.Sqrt(sum);

            const {{ self_wide_bits_unsigned_type }} k =
            {%- if self_wide_bits_unsigned_type == "ulong" %} 1UL
            {%- else %}{{ throw(message="self_wide_bits_unsigned_type: " ~ self_wide_bits_unsigned_type) }}
            {%- endif %} << {{ frac_nbits - 1 }};

            {%- for i in range(end=dim) %}
            var y{{ i }} = ({{ self_bits_type }})(l{{ i }} * k / ll);
            {%- endfor %}

            return new {{ self_type }}(
                {{ self_component_type }}.FromBits({% if signed %}b0 ? -y0 : {% endif %}y0),
                {{ self_component_type }}.FromBits({% if signed %}b1 ? -y1 : {% endif %}y1){% if dim > 2 %},
                {{ self_component_type }}.FromBits({% if signed %}b2 ? -y2 : {% endif %}y2){% if dim > 3 %},
                {{ self_component_type }}.FromBits({% if signed %}b3 ? -y3 : {% endif %}y3){% endif %}{% endif %});
        }

        {%- if self_component_type == "I17F15" %}
        {%- for name in [
            "SinP2",
            "SinP3A16384",
            "SinP4A7369",
            "SinP5A51436",
            "CosP2",
            "CosP3A16384",
            "CosP4A7369",
            "CosP5A51436",
        ] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ macros::vector_type(dim=dim, type="I2F30") }} {{ name }}() => new {{ macros::vector_type(dim=dim, type="I2F30") }}(
            X.{{ name }}(),
            Y.{{ name }}(){% if dim > 2 %},
            Z.{{ name }}(){% if dim > 3 %},
            W.{{ name }}(){% endif %}{% endif %});

        {%- endfor %}
        {%- endif %}

        // Swizzling
        // ---------
{{ self::swizzling(component_type=self_component_type) }}

    }
}
