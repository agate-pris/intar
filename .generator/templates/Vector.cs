{% import "macros.cs" as macros %}

{%- set bits        = macros::inttype(bits=int_nbits  +frac_nbits,   signed=signed) %}
{%- set bits_u      = macros::inttype(bits=int_nbits  +frac_nbits,   signed=false ) %}
{%- set wide_bits   = macros::inttype(bits=int_nbits*2+frac_nbits*2, signed=signed) %}
{%- set wide_bits_u = macros::inttype(bits=int_nbits*2+frac_nbits*2, signed=false ) %}
{%- set component   = macros::fixed_type(s=signed, i=  int_nbits,   f=  frac_nbits  ) %}
{%- set component_u = macros::fixed_type(s=false,  i=  int_nbits,   f=  frac_nbits  ) %}
{%- set self_type = macros::vector_type(dim=dim, type=component) -%}
{%- set components = ['X', 'Y', 'Z', 'W']|slice(end=dim) -%}
{%- set repr = macros::vector_primitive(dim=dim, bits=int_nbits+frac_nbits, signed=signed) -%}

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct {{ self_type }}
    : IEquatable<{{ self_type }}>
    , IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public {{ repr }} Repr;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        internal {{ macros::vector_primitive(dim=dim, signed=signed, bits=int_nbits*2+frac_nbits*2)
        }} WideRepr {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Repr;
        }
{% for c in components %}
        public {{ component }} {{ c }} {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => {{ component }}.FromBits(Repr.{{ c }});
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.{{ c }} = value.Bits;
        }
{%- endfor %}

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ repr }} repr) {
            Repr = repr;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}(
{%- for c in components -%}
    {{ component }} {{ c|lower }}{% if not loop.last %}, {% endif %}
{%- endfor -%}
        ) : this(new {{ repr }}(
{%- for c in components -%}
    {{ c|lower }}.Bits{% if not loop.last %}, {% endif %}
{%- endfor -%}
        )) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}({{ component }} value) : this(
{%- for i in range(end=dim) -%}
    value{% if not loop.last %}, {% endif %}
{%- endfor -%}
        ) { }

        // Constants
        // ---------------------------------------

        public static readonly {{ self_type }} Zero = new {{ self_type }}({{ component }}.Zero);
        public static readonly {{ self_type }} One = new {{ self_type }}({{ component }}.One);
{%- for i in range(end=dim) %}
    {%- if i >= dim %}{% continue %}{% endif %}
        public static readonly {{ self_type }} Unit{{ components[i] }} = new {{ self_type }}(
    {%- for j in range(end=dim) %}
        {{- component }}.
        {%- if i == j %}One{% else %}Zero{% endif %}
        {%- if not loop.last %}, {% endif %}
    {%- endfor %});
{%- endfor %}

        // Arithmetic Operators
        // ---------------------------------------

{%- for o in ['+', '-'] %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator {{ o }}({{ self_type }} a, {{ self_type }} b) {
            return new {{ self_type }}(a.Repr {{ o }} b.Repr);
        }

{%- endfor %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator *({{ self_type }} a, {{ self_type }} b) {
            return new {{ self_type }}(({{ repr }})(a.WideRepr * b.Repr / {{ component }}.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator *({{ self_type }} a, {{component}} b) {
            return new {{ self_type }}(({{ repr }})(a.WideRepr * b.Bits / {{ component }}.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator *({{ component }} a, {{ self_type }} b) {
            return new {{ self_type }}(({{ repr }})(a.Bits * b.WideRepr / {{ component }}.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator /({{ self_type }} a, {{ self_type }} b) {
            return new {{ self_type }}(({{ repr }})(a.WideRepr * {{ component }}.OneRepr / b.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator /({{ self_type }} a, {{ component }} b) {
            return new {{ self_type }}(({{ repr }})(a.WideRepr * {{ component }}.OneRepr / b.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator /({{ component }} a, {{ self_type }} b) {
            return new {{ self_type }}(({{ repr }})(a.WideBits * {{ component }}.OneRepr / b.WideRepr));
        }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==({{ self_type }} lhs, {{ self_type }} rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=({{ self_type }} lhs, {{ self_type }} rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public {{ component }} this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                switch (index) {
{%- for i in range(end=dim) %}
                    case {{ i }}: return {{ components[i] }};
{%- endfor %}
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                switch (index) {
{%- for i in range(end=dim) %}
                    case {{ i }}: {{ components[i] }} = value; break;
{%- endfor %}
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
        }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is {{ self_type }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(
{%- for c in components -%}
    {{ c }}{% if not loop.last %}, {% endif %}
{%- endfor -%}
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<
{%- for c in components -%}
    { {{- c -}} } {%- if not loop.last %}, {% endif %}
{%- endfor -%}
        >";

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
            return $"<
{%- for c in components -%}
    { {{- c }}.ToString(format, formatProvider)} {%- if not loop.last %}, {% endif %}
{%- endfor -%}
            >";
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal {{ self_type }} Half() => new {{ self_type }}(X.Half(), Y.Half()
            {%- if dim > 2 %}, Z.Half()
            {%- if dim > 3 %}, W.Half(){% endif %}{% endif %});
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal {{ self_type }} Twice() => new {{ self_type }}(X.Twice(), Y.Twice()
            {%- if dim > 2 %}, Z.Twice()
            {%- if dim > 3 %}, W.Twice(){% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} Clamp({{ component }} min, {{ component }} max) {
            return new {{ self_type }}({#             -#}
                X.Clamp(min, max), {#                 -#}
                Y.Clamp(min, max){% if dim > 2 %}, {# -#}
                Z.Clamp(min, max){% if dim > 3 %}, {# -#}
                W.Clamp(min, max){% endif %}{% endif %});
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} Clamp({{ self_type }} min, {{ self_type }} max) {
            return new {{ self_type }}({#                 -#}
                X.Clamp(min.X, max.X), {#                 -#}
                Y.Clamp(min.Y, max.Y){% if dim > 2 %}, {# -#}
                Z.Clamp(min.Z, max.Z){% if dim > 3 %}, {# -#}
                W.Clamp(min.W, max.W){% endif %}{% endif %});
        }

        {%- if signed and dim == 3 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void CrossInternal({{ self_type }} other, out {{ wide_bits }} x, out {{ wide_bits }} y, out {{ wide_bits }} z) {
            var ax = ({{ wide_bits }})X.Bits;
            var ay = ({{ wide_bits }})Y.Bits;
            var az = ({{ wide_bits }})Z.Bits;
            var bx = ({{ wide_bits }})other.X.Bits;
            var by = ({{ wide_bits }})other.Y.Bits;
            var bz = ({{ wide_bits }})other.Z.Bits;

            x = (ay * bz) - (az * by);
            y = (az * bx) - (ax * bz);
            z = (ax * by) - (ay * bx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} Cross({{ self_type }} other) {
            const {{ wide_bits }} k =
            {%- if wide_bits == "long" %} 1L
            {%- elif wide_bits == "ulong" %} 1UL
            {%- else %}{{ throw(message = "invalid arguments. wide_bits: " ~ wide_bits) }}
            {%- endif %} << {{ frac_nbits }};
            CrossInternal(other, out var x, out var y, out var z);
            return new {{ self_type }}(
                {{ component }}.FromBits(({{ bits }})(x / k)),
                {{ component }}.FromBits(({{ bits }})(y / k)),
                {{ component }}.FromBits(({{ bits }})(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} SaturatingCross({{ self_type }} other) {
            const {{ wide_bits }} k =
            {%- if wide_bits == "long" %} 1L
            {%- elif wide_bits == "ulong" %} 1UL
            {%- else %}{{ throw(message = "invalid arguments. wide_bits: " ~ wide_bits) }}
            {%- endif %} << {{ frac_nbits }};
            CrossInternal(other, out var x, out var y, out var z);
            {%- for c in components %}
            {{ c|lower }} /= k;
            if ({{ c|lower }} > {{ bits }}.MaxValue) {
                {{ c|lower }} = {{ bits }}.MaxValue;
            } else if ({{ c|lower }} < {{ bits }}.MinValue) {
                {{ c|lower }} = {{ bits }}.MinValue;
            }
            {%- endfor %}
            return new {{ self_type }}(
                {{ component }}.FromBits(({{ bits }})x),
                {{ component }}.FromBits(({{ bits }})y),
                {{ component }}.FromBits(({{ bits }})z));
        }

        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        {{ wide_bits }} DotInternal({{ self_type }} other) {
            var x = (({{ wide_bits }})X.Bits) * other.X.Bits;
            var y = (({{ wide_bits }})Y.Bits) * other.Y.Bits;{% if dim > 2 %}
            var z = (({{ wide_bits }})Z.Bits) * other.Z.Bits;{% if dim > 3 %}
            var w = (({{ wide_bits }})W.Bits) * other.W.Bits;{% endif %}{% endif %}

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
        public {{ component }} Dot({{ self_type }} other) {
            const {{ wide_bits }} k =
            {%- if wide_bits == "long" %} 1L
            {%- elif wide_bits == "ulong" %} 1UL
            {%- else %}{{ throw(message = "invalid arguments. wide_bits: " ~ wide_bits) }}
            {%- endif %} << {{ frac_nbits - 2 }};
            return {{ component }}.FromBits(({{ bits }})(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ component }} SaturatingDot({{ self_type }} other) {
            const {{ wide_bits }} k =
            {%- if wide_bits == "long" %} 1L
            {%- elif wide_bits == "ulong" %} 1UL
            {%- else %}{{ throw(message = "invalid arguments. wide_bits: " ~ wide_bits) }}
            {%- endif %} << {{ frac_nbits - 2 }};
            var bits = DotInternal(other) / k;
            if (bits > {{ bits }}.MaxValue) {
                return {{ component }}.MaxValue;
            {%- if signed %}
            } else if (bits < {{ bits }}.MinValue) {
                return {{ component }}.MinValue;
            {%- endif %}
            } else {
                return {{ component }}.FromBits(({{ bits }})bits);
            }
        }

        {%- if not signed or dim > 3 %}

        // ベクトルの長さは符号つき、
        // かつ次元が 3 以下の場合のみ定義される。

        {%- else %}

        {%- set len_sqr_ty = macros::fixed_type(s=false, i=int_nbits*2, f=frac_nbits * 2) %}

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ len_sqr_ty }} LengthSquared() {
            var a1 = Mathi.UnsignedAbs(X.Bits);
            var a2 = Mathi.UnsignedAbs(Y.Bits);{% if dim > 2 %}
            var a3 = Mathi.UnsignedAbs(Z.Bits);{% if dim > 3 %}
            var a4 = Mathi.UnsignedAbs(W.Bits);{% endif %}{% endif %}
            var s1 = ({{ wide_bits_u }})a1 * a1;
            var s2 = ({{ wide_bits_u }})a2 * a2;{% if dim > 2 %}
            var s3 = ({{ wide_bits_u }})a3 * a3;{% if dim > 3 %}
            var s4 = ({{ wide_bits_u }})a4 * a4;{% endif %}{% endif %}
            return {{ len_sqr_ty }}.FromBits(s1 + s2
            {%- if dim > 2 %} + s3
            {%- if dim > 3 %} + s4
            {%- endif %}{% endif %});
        }

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ component_u }} Length() {
            return {{ component_u }}.FromBits(({{ bits_u }})Mathi.Sqrt(LengthSquared().Bits));
        }

        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}? Normalize() {
            {%- if signed %}

            // 各要素の内部表現型を取り出し、
            // その絶対値を得る。

            var x0 = X.Bits;
            var x1 = Y.Bits;{% if dim > 2 %}
            var x2 = Z.Bits;{% if dim > 3 %}
            var x3 = W.Bits;{% endif %}{% endif %}

            {%- for i in range(end=dim) %}
            var b{{ i }} = x{{ i }} < 0;
            {%- endfor %}

            {%- for i in range(end=dim) %}
            var a{{ i }} = unchecked(({{ bits_u }})(b{{ i }} ? Overflowing.WrappingNeg(x{{ i }}) : x{{ i }}));
            {%- endfor %}

            {%- else -%}

            var a0 = X.Bits;
            var a1 = Y.Bits;{% if dim > 2 %}
            var a2 = Z.Bits;{% if dim > 3 %}
            var a3 = W.Bits;{% endif %}{% endif %}

            {%- endif %}

            // 各要素の最大値が 0 の場合は null を返す。

            var max = {% if dim > 2 %}Math.Max({% endif -%}
                Math.Max(a0, a1)
                {%- if dim == 3 %}, a2{% endif %}
                {%- if dim == 4 %}, Math.Max(a2, a3){% endif %}
                {%- if dim > 2 %}){% endif %};
            if (max == 0) {
                return null;
            }

            // ベクトルの大きさが小さい時の誤差を小さくするため、
            // 最大の要素が表現型の範囲に収まるように拡大する。
            // 最大の要素以外にも同じ値を乗算する。

            {{ wide_bits_u }} m = {{ bits_u }}.MaxValue / max;

            {%- for i in range(end=dim) %}
            var l{{ i }} = m * a{{ i }};
            {%- endfor %}
            var sum =
                (l0 * l0 / 4) +
                (l1 * l1 / 4){% if dim > 2 %} +
                (l2 * l2 / 4){% if dim > 3 %} +
                (l3 * l3 / 4){% endif %}{% endif %};
            var ll = Mathi.Sqrt(sum);

            // 小数部の桁をあわせる。

            const {{ wide_bits_u }} k =
            {%- if wide_bits_u == "ulong" %} 1UL
            {%- else %}{{ throw(message="wide_bits_u: " ~ wide_bits_u) }}
            {%- endif %} << {{ frac_nbits - 1 }};

            {%- for i in range(end=dim) %}
            var y{{ i }} = ({{ bits }})(l{{ i }} * k / ll);
            {%- endfor %}

            // 最後に符号をあわせて返す。

            return new {{ self_type }}(
                {{ component }}.FromBits({% if signed %}b0 ? -y0 : {% endif %}y0),
                {{ component }}.FromBits({% if signed %}b1 ? -y1 : {% endif %}y1){% if dim > 2 %},
                {{ component }}.FromBits({% if signed %}b2 ? -y2 : {% endif %}y2){% if dim > 3 %},
                {{ component }}.FromBits({% if signed %}b3 ? -y3 : {% endif %}y3){% endif %}{% endif %});
        }

        {%- if component == "I17F15" %}
        {%- for name in [
            "SinP4",
            "SinP5",
            "CosP4",
            "CosP5",
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
{# これは改行を挿入するためのコメントです #}

        {%- if   dim == 2 %} {%- set cmp = ['X', 'Y'          ] %}
        {%- elif dim == 3 %} {%- set cmp = ['X', 'Y', 'Z'     ] %}
        {%- elif dim == 4 %} {%- set cmp = ['X', 'Y', 'Z', 'W'] %}
        {%- else %} {{- "Unexpected dim. dim: " ~ dim }}
        {%- endif -%}
        {%- for x in cmp %}
        {%- for y in cmp %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{
            macros::vector_type(dim=2, type=component) }} {{ x -}}  {{ y -}}() => new {{
            macros::vector_type(dim=2, type=component) }}({{ x -}}, {{ y -}});
        {%- endfor %}
        {%- endfor %}
        {%- for x in cmp %}
        {%- for y in cmp %}
        {%- for z in cmp %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{
            macros::vector_type(dim=3, type=component) }} {{ x -}}  {{ y -}}  {{ z -}}() => new {{
            macros::vector_type(dim=3, type=component) }}({{ x -}}, {{ y -}}, {{ z -}});
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
        {%- for x in cmp %}
        {%- for y in cmp %}
        {%- for z in cmp %}
        {%- for w in cmp %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{
            macros::vector_type(dim=4, type=component) }} {{ x -}}  {{ y -}}  {{ z -}}  {{ w -}}() => new {{
            macros::vector_type(dim=4, type=component) }}({{ x -}}, {{ y -}}, {{ z -}}, {{ w -}});
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}

    }
} // // namespace AgatePris.Intar
