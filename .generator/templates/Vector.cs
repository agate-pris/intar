{% import "macros.cs" as macros %}

{%- set self_bits_type               = macros::inttype(bits=int_nbits  +frac_nbits,   signed=signed) %}
{%- set self_bits_signed_type        = macros::inttype(bits=int_nbits  +frac_nbits,   signed=true  ) %}
{%- set self_bits_unsigned_type      = macros::inttype(bits=int_nbits  +frac_nbits,   signed=false ) %}
{%- set self_wide_bits_type          = macros::inttype(bits=int_nbits*2+frac_nbits*2, signed=signed) %}
{%- set self_wide_bits_signed_type   = macros::inttype(bits=int_nbits*2+frac_nbits*2, signed=true  ) %}
{%- set self_wide_bits_unsigned_type = macros::inttype(bits=int_nbits*2+frac_nbits*2, signed=false ) %}
{%- set self_component_type          = macros::fixed_type(s=signed, i=  int_nbits,   f=  frac_nbits  ) %}
{%- set self_component_signed_type   = macros::fixed_type(s=true,   i=  int_nbits,   f=  frac_nbits  ) %}
{%- set self_component_unsigned_type = macros::fixed_type(s=false,  i=  int_nbits,   f=  frac_nbits  ) %}
{%- set self_type = macros::vector_type(dim=dim, type=self_component_type) -%}
{%- set components = ['X', 'Y', 'Z', 'W']|slice(end=dim) -%}

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
        public {{ self_type }}({{ self_component_type }} value) : this(
{%- for i in range(end=dim) -%}
    value{% if not loop.last %}, {% endif %}
{%- endfor -%}
        ) { }

        // Constants
        // ---------------------------------------

        public static readonly {{ self_type }} Zero = new {{ self_type }}({{ self_component_type }}.Zero);
        public static readonly {{ self_type }} One = new {{ self_type }}({{ self_component_type }}.One);
{%- for i in range(end=dim) %}
    {%- if i >= dim %}{% continue %}{% endif %}
        public static readonly {{ self_type }} Unit{{ components[i] }} = new {{ self_type }}(
    {%- for j in range(end=dim) %}
        {{- self_component_type }}.
        {%- if i == j %}One{% else %}Zero{% endif %}
        {%- if not loop.last %}, {% endif %}
    {%- endfor %});
{%- endfor %}

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal {{ self_type }} Half() => new {{ self_type }}(X.Half(), Y.Half()
            {%- if dim > 2 %}, Z.Half()
            {%- if dim > 3 %}, W.Half(){% endif %}{% endif %});
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal {{ self_type }} Twice() => new {{ self_type }}(X.Twice(), Y.Twice()
            {%- if dim > 2 %}, Z.Twice()
            {%- if dim > 3 %}, W.Twice(){% endif %}{% endif %});

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} Clamp({{ self_component_type }} min, {{ self_component_type }} max) {
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

#if AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

        {%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ macros::vector_type(dim=dim, type=macros::fixed_type(s=false, i=int_nbits, f=frac_nbits)) }} UnsignedAbs() => new {{ macros::vector_type(dim=dim, type=macros::fixed_type(s=false, i=int_nbits, f=frac_nbits)) }}(
            X.UnsignedAbs(),
            Y.UnsignedAbs(){% if dim > 2 %},
            Z.UnsignedAbs(){% if dim > 3 %},
            W.UnsignedAbs(){% endif %}{% endif %});

        {%- endif %}

#endif // AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

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
            var s1 = ({{ self_wide_bits_unsigned_type }})a1 * a1;
            var s2 = ({{ self_wide_bits_unsigned_type }})a2 * a2;{% if dim > 2 %}
            var s3 = ({{ self_wide_bits_unsigned_type }})a3 * a3;{% if dim > 3 %}
            var s4 = ({{ self_wide_bits_unsigned_type }})a4 * a4;{% endif %}{% endif %}
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
        public {{ self_component_unsigned_type }} Length() {
            return {{ self_component_unsigned_type }}.FromBits(({{ self_bits_unsigned_type }})Mathi.Sqrt(LengthSquared().Bits));
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
            var a{{ i }} = unchecked(({{ self_bits_unsigned_type }})(b{{ i }} ? Overflowing.WrappingNeg(x{{ i }}) : x{{ i }}));
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

            // 小数部の桁をあわせる。

            const {{ self_wide_bits_unsigned_type }} k =
            {%- if self_wide_bits_unsigned_type == "ulong" %} 1UL
            {%- else %}{{ throw(message="self_wide_bits_unsigned_type: " ~ self_wide_bits_unsigned_type) }}
            {%- endif %} << {{ frac_nbits - 1 }};

            {%- for i in range(end=dim) %}
            var y{{ i }} = ({{ self_bits_type }})(l{{ i }} * k / ll);
            {%- endfor %}

            // 最後に符号をあわせて返す。

            return new {{ self_type }}(
                {{ self_component_type }}.FromBits({% if signed %}b0 ? -y0 : {% endif %}y0),
                {{ self_component_type }}.FromBits({% if signed %}b1 ? -y1 : {% endif %}y1){% if dim > 2 %},
                {{ self_component_type }}.FromBits({% if signed %}b2 ? -y2 : {% endif %}y2){% if dim > 3 %},
                {{ self_component_type }}.FromBits({% if signed %}b3 ? -y3 : {% endif %}y3){% endif %}{% endif %});
        }

        {%- if self_component_type == "I17F15" %}
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
            macros::vector_type(dim=2, type=self_component_type) }} {{ x -}}  {{ y -}}() => new {{
            macros::vector_type(dim=2, type=self_component_type) }}({{ x -}}, {{ y -}});
        {%- endfor %}
        {%- endfor %}
        {%- for x in cmp %}
        {%- for y in cmp %}
        {%- for z in cmp %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{
            macros::vector_type(dim=3, type=self_component_type) }} {{ x -}}  {{ y -}}  {{ z -}}() => new {{
            macros::vector_type(dim=3, type=self_component_type) }}({{ x -}}, {{ y -}}, {{ z -}});
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
        {%- for x in cmp %}
        {%- for y in cmp %}
        {%- for z in cmp %}
        {%- for w in cmp %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{
            macros::vector_type(dim=4, type=self_component_type) }} {{ x -}}  {{ y -}}  {{ z -}}  {{ w -}}() => new {{
            macros::vector_type(dim=4, type=self_component_type) }}({{ x -}}, {{ y -}}, {{ z -}}, {{ w -}});
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}
        {%- endfor %}

    }
} // // namespace AgatePris.Intar
