{% import "macros.cs" as macros %}
{%- set self_type = macros::fixed_type(s=signed, i=int_nbits, f=frac_nbits) %}
{%- set type_u    = macros::fixed_type(s=false,  i=int_nbits, f=frac_nbits) %}
{%- set self_bits_type  = macros::inttype(bits = int_nbits+frac_nbits, signed = signed) %}
{%- set self_bits_utype = macros::inttype(bits = int_nbits+frac_nbits, signed = false)  %}
{%- set bits = int_nbits+frac_nbits %}
{%- if bits > 64 %}
    {%- set const = 'static readonly' %}{%- else %}
    {%- set const = 'const' %}
{%- endif %}

{#- 固定小数点数の定義 -#}
{%- if bits > 64 -%}
#if NET7_0_OR_GREATER

{% endif -%}
using System;
using System.Runtime.CompilerServices;

namespace {{ namespace }} {
    [Serializable]
    public struct {{ self_type }} : IEquatable<{{ self_type }}>, IFormattable {
        #region Consts
        public const int IntNbits = {{ int_nbits }};
        public const int FracNbits = {{ frac_nbits }};

        internal {{ const }} {{ self_bits_type }} MinRepr = {{ self_bits_type }}.MinValue;
        internal {{ const }} {{ self_bits_type }} MaxRepr = {{ self_bits_type }}.MaxValue;
        internal {{ const }} {{ self_bits_type }} EpsilonRepr = 1;

        internal {{ const }} {{ self_bits_type }} OneRepr = {{
            macros::one(bits=bits, signed=signed)
        }} << FracNbits;
        {%- if signed %}
        internal {{ const }} {{ self_bits_type }} NegativeOneRepr = -OneRepr;
        {%- endif %}
        #endregion
        #region Bits

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public {{ self_bits_type }} Bits;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        {{ self_type }}({{ self_bits_type }} bits) {
            Bits = bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} FromBits({{ self_bits_type }} bits) => new {{ self_type }}(bits);
        #endregion
        #region Zero, One, {% if signed %}NegativeOne, {% endif %}MinValue, MaxValue, Epsilon

        // > 14.5.6.2 Static field initialization
        // >
        // > ... If a static constructor (S.14.12) exists in the class,
        // > execution of the static field initializers occurs immediately prior to executing that static constructor.
        // > Otherwise, the static field initializers are executed at an implementation-dependent time prior to the first
        // > use of a static field of that class.
        //
        // -- ECMA-334 6th edition June 2022

        public static readonly {{ self_type }} Zero;
        public static readonly {{ self_type }} One = new {{ self_type }}(OneRepr);
        {%- if signed %}
        public static readonly {{ self_type }} NegativeOne = new {{ self_type }}(NegativeOneRepr);
        {%- endif %}
        public static readonly {{ self_type }} MinValue = new {{ self_type }}(MinRepr);
        public static readonly {{ self_type }} MaxValue = new {{ self_type }}(MaxRepr);
        internal static readonly {{ self_type }} Epsilon = new {{ self_type }}(EpsilonRepr);
        #endregion
        {%- if bits < 128 %}
        #region WideBits
        {%- if bits == 64 %}

#if NET7_0_OR_GREATER
{# lf #}
        {%- endif %}
        internal {{
            macros::inttype(bits=int_nbits*2+frac_nbits*2, signed=signed)
        }} WideBits {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Bits;
        }
        {%- if bits == 64 %}

#endif // NET7_0_OR_GREATER
{# lf #}
        {%- endif %}
        #endregion
        {%- endif %}
        #region IAdditionOperatos, ISubtractionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator +({{ self_type }} left, {{ self_type }} right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator -({{ self_type }} left, {{ self_type }} right) {
            return FromBits(left.Bits - right.Bits);
        }
        #endregion
        {%- if bits < 128 %}
        #region IMultiplicationOperators, IDivisionOperators
        {%- if bits == 64 %}

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER
{# lf #}
        {%- endif %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator *({{ self_type }} left, {{ self_type }} right) {
            return FromBits(({{ self_bits_type }})(left.WideBits * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator /({{ self_type }} left, {{ self_type }} right) {
            return FromBits(({{ self_bits_type }})(left.WideBits * OneRepr / right.Bits));
        }
        {%- if bits == 64 %}

#endif // NET7_0_OR_GREATER
{# lf #}
        {%- endif %}
        #endregion
        {%- endif %}
        #region IUnaryPlusOperators, IUnaryNegationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator +({{ self_type }} x) => FromBits(+x.Bits);

        {%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator -({{ self_type }} x) => FromBits(-x.Bits);
        {%- else %}

        // 符号なし固定小数点数は単項マイナス演算子を持たない。
{# lf #}
        {%- endif %}
        #endregion
        #region IEqualityOperators, IComparisonOperators
        {%- for op in ['==', '!=', '<', '>', '<=', '>='] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator {{ op }}({{ self_type }} left, {{ self_type }} right) => left.Bits {{ op }} right.Bits;
        {%- endfor %}
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is {{ self_type }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ((double)this).ToString((IFormatProvider)null);
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ self_type }} other) => this == other;
        #endregion
        #region IFormattable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
        #endregion
        #region IComparable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo({{ self_type }} value) {
            if (this < value) {
                return -1;
            } else if (this > value) {
                return 1;
            } else {
                return 0;
            }
        }
        #endregion
        #region Min, Max, Clamp
        {%- for m in ['Min', 'Max'] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{
        self_type }} {{ m }}({{ self_type
        }} other) => FromBits({% if bits > 64
        %}{{ self_bits_type }}{% else
        %}Math{% endif %}.{{ m }}(Bits, other.Bits));
        {%- endfor %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} Clamp({{ self_type }} min, {{ self_type }} max) {
            {%- if bits > 64 %}
            return FromBits({{ self_bits_type }}.Clamp(Bits, min.Bits, max.Bits));
            {%- else %}
#if NET5_0_OR_GREATER
            return FromBits(Math.Clamp(Bits, min.Bits, max.Bits));
#else
            return FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));
#endif
            {%- endif %}
        }
        #endregion
        #region IsNegative, Abs, UnsignedAbs
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNegative() => Bits < 0;

        {%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type
        }} Abs() => FromBits({% if bits > 64
        %}{{ self_bits_type }}{% else
        %}Math{% endif %}.Abs(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ macros::fixed_type(s=false, i=int_nbits, f=frac_nbits) }} UnsignedAbs() {
            return {{ macros::fixed_type(s=false, i=int_nbits, f=frac_nbits) }}.FromBits(Mathi.UnsignedAbs(Bits));
        }
        {%- endif %}
        #endregion
        {%- if signed %}
        #region AbsDiff
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ type_u }} AbsDiff({{ self_type }} other) {
            return {{ type_u }}.FromBits(Mathi.AbsDiff(Bits, other.Bits));
        }
        #endregion
        {%- endif %}
        #region Half, Twice
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal {{ self_type }} Half() => FromBits(Mathi.Half(Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal {{ self_type }} Twice() => FromBits(Mathi.Twice(Bits));
        #endregion
        #region BigMul
        {%- for output in fixed_list %}
        {%- for rhs in fixed_list %}
        {%- if  int_nbits + rhs[0] != output[0]
            or frac_nbits + rhs[1] != output[1] %}
            {%- continue %}
        {%- endif %}
        {%- set   signed_big = macros::fixed_type(s=true,  i=int_nbits+rhs[0], f=frac_nbits+rhs[1]) %}
        {%- set unsigned_big = macros::fixed_type(s=false, i=int_nbits+rhs[0], f=frac_nbits+rhs[1]) %}
        {%- if output[0] + output[1] > 64 and bits < 128 %}

#if NET7_0_OR_GREATER
        {%- endif %}
        {%- for s in [true, false] %}
        {%- if signed == s %}
        {%- set t = macros::fixed_type(s=s, i=int_nbits+rhs[0], f=frac_nbits+rhs[1]) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ t }} BigMul({{
            macros::fixed_type(s=s, i=rhs[0], f=rhs[1])
        }} other) {
            return {{ t }}.FromBits(WideBits * other.WideBits);
        }
        {%- else %}
        {%- set t = macros::fixed_type(s=true,  i=int_nbits+rhs[0], f=frac_nbits+rhs[1]) %}
        {%- set u = macros::inttype(signed=true,  bits=int_nbits+rhs[0]+frac_nbits+rhs[1]) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ t }} BigMul({{
            macros::fixed_type(s=s, i=rhs[0], f=rhs[1])
        }} other) {
            {%- if bits > 32 %}
                {%- set c = '(' ~ u ~ ')' %}{% else %}
                {%- set c = '' %}
            {%- endif %}
            return {{ t }}.FromBits({{ c }}Bits * {{ c }}other.Bits);
        }
        {%- endif %}
        {%- endfor %}
        {%- if output[0] + output[1] > 64 and bits < 128 %}

#endif // NET7_0_OR_GREATER
{# lf #}
        {%- endif %}
        {%- endfor %}
        {%- endfor %}
        #endregion
        {%- if signed %}
        {%- if bits < 128 %}
        {%- if int_nbits == 2 %}
        #region Asin, Atan
        {%- set arg = macros::fixed_type(i=2+frac_nbits/2, f=frac_nbits/2, s=true) %}
        {%- for order in [3, 7] %}
        {%- if order > 3 and bits < 64 %}
            {%- continue %}
        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} AsinP{{ order }}({{ arg }} x) => FromBits(Mathi.AsinP{{ order }}(x.Bits));
        {%- endfor %}
        {%- for order in [2, 3, 9] %}
        {%- if order > 3 and bits < 64 %}
            {%- continue %}
        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} AtanP{{ order }}({{ arg }} x) => FromBits(Mathi.AtanP{{ order }}(x.Bits));
        {%- endfor %}
        #endregion
        {%- elif int_nbits - frac_nbits == 2 %}
        #region Asin, Acos
        {%- for fixed in fixed_list %}
        {%- if fixed[0] - fixed[1] != 2 %}{% continue %}{% endif %}
        {%- set arg = macros::fixed_type(i=fixed[0], f=fixed[1], s=true) %}
        {%- for order in [3, 7] %}
        {%- if order > 3 and fixed[0]+fixed[1] < 64 %}
            {%- continue %}
        {%- endif %}
        {%- if frac_nbits > 2*fixed[1] %}
            {%- continue %}
        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} AcosP{{ order }}({{ arg }} x) {
            switch (Math.Sign(x.Bits)) {
                case 0: return One;
                case 1: {
                    var bits = Mathi.AsinInternal.P{{ order }}(({{
                        macros::inttype(
                            bits=fixed[0]+fixed[1], signed=false
                        )
                    }})x.Bits);
                    bits /= {{ macros::one(
                        bits=fixed[0]+fixed[1], signed=false
                    ) }} << {{ 2*fixed[1] - frac_nbits }};
                    return FromBits(({{ self_bits_type }})bits);
                }
                default: {
                    var bits = Mathi.AsinInternal.P{{ order }}(({{
                        macros::inttype(
                            bits=fixed[0]+fixed[1], signed=false
                        )
                    }})-x.Bits);
                    bits /= {{ macros::one(
                        bits=fixed[0]+fixed[1], signed=false
                    ) }} << {{ 2*fixed[1] - frac_nbits }};
                    return FromBits(2 * OneRepr) - FromBits(({{ self_bits_type }})bits);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} AsinP{{ order }}({{ arg }} x) {
            switch (Math.Sign(x.Bits)) {
                case 0: return Zero;
                case 1: {
                    var bits = Mathi.AsinInternal.P{{ order }}(({{
                        macros::inttype(
                            bits=fixed[0]+fixed[1], signed=false
                        )
                    }})x.Bits);
                    bits /= {{ macros::one(
                        bits=fixed[0]+fixed[1], signed=false
                    ) }} << {{ 2*fixed[1] - frac_nbits }};
                    return One - FromBits(({{ self_bits_type }})bits);
                }
                default: {
                    var bits = Mathi.AsinInternal.P{{ order }}(({{
                        macros::inttype(
                            bits=fixed[0]+fixed[1], signed=false
                        )
                    }})-x.Bits);
                    bits /= {{ macros::one(
                        bits=fixed[0]+fixed[1], signed=false
                    ) }} << {{ 2*fixed[1] - frac_nbits }};
                    return FromBits(({{ self_bits_type }})bits) - One;
                }
            }
        }
        {%- endfor %}{# order in [3, 7] #}
        {%- endfor %}{# fixed in fixed_list #}
        #endregion
        {%- endif %}
        {%- endif %}
        {%- if bits < 128 %}
        {%- if int_nbits == 2 or int_nbits - frac_nbits == 2 %}
        #region Atan2
        {%- if bits == 64 %}

#if NET7_0_OR_GREATER
        {%- endif %}

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0002 // メンバー アクセスを単純化します

        {%- for order in [2, 3, 9] %}
        {%- if order > 3 and bits < 64 %}{% continue %}{% endif %}

        /// <summary>
        {%- if int_nbits == 2 %}
        /// <see cref="One" /> を PI とする逆正接の値を返す｡
        {%- elif int_nbits - frac_nbits == 2 %}
        /// <see cref="One" /> を PI / 2 とする逆正接の値を返す｡
        {%- endif %}
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} Atan2P{{ order }}({{ self_bits_type }} y, {{ self_bits_type }} x) {
            {%- if int_nbits == 2 %}
            return FromBits(Mathi.Atan2P{{ order }}(y, x));
            {%- else %}
            {{ const }} {{ self_bits_type }} pi = 2 * OneRepr;
            {{ const }} {{ self_bits_type }} pi_4 = pi / 4;
            if (y < 0) {
                if (x < 0) {
                    var bits = y < x
                        ? NegativeOneRepr - (Mathi.AtanInternal.P{{ order }}(Mathi.AtanInternal.Div(x, y)) / (OneRepr / 2))
                        : y > x ? (Mathi.AtanInternal.P{{ order }}(Mathi.AtanInternal.Div(y, x)) / (OneRepr / 2)) - pi
                        : pi_4 - pi;
                    return FromBits(bits);
                } else if (x > 0) {
                    var bits = y < -x
                        ? NegativeOneRepr - (Mathi.AtanInternal.P{{ order }}(Mathi.AtanInternal.Div(x, y)) / (OneRepr / 2))
                        : y > -x ? Mathi.AtanInternal.P{{ order }}(Mathi.AtanInternal.Div(y, x)) / (OneRepr / 2)
                        : -pi_4;
                    return FromBits(bits);
                } else {
                    return NegativeOne;
                }
            } else if (y > 0) {
                if (x < 0) {
                    var bits = -y < x
                        ? OneRepr - (Mathi.AtanInternal.P{{ order }}(Mathi.AtanInternal.Div(x, y)) / (OneRepr / 2))
                        : -y > x ? pi + (Mathi.AtanInternal.P{{ order }}(Mathi.AtanInternal.Div(y, x)) / (OneRepr / 2))
                        : pi - pi_4;
                    return FromBits(bits);
                } else if (x > 0) {
                    var bits = y > x
                        ? OneRepr - (Mathi.AtanInternal.P{{ order }}(Mathi.AtanInternal.Div(x, y)) / (OneRepr / 2))
                        : y < x ? Mathi.AtanInternal.P{{ order }}(Mathi.AtanInternal.Div(y, x)) / (OneRepr / 2)
                        : pi_4;
                    return FromBits(bits);
                } else {
                    return One;
                }
            } else {
                return FromBits((x < 0) ? pi : 0);
            }
            {%- endif %}
        }

        {%- for f in fixed_list %}
        {%- if f[0] + f[1] > bits %}{% continue %}{% endif %}

        /// <summary>
        {%- if int_nbits == 2 %}
        /// <see cref="One" /> を PI とする逆正接の値を返す｡
        {%- elif int_nbits - frac_nbits == 2 %}
        /// <see cref="One" /> を PI / 2 とする逆正接の値を返す｡
        {%- endif %}
        /// </summary>
        {%- set arg = macros::fixed_type(i=f[0], f=f[1], s=true) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} Atan2P{{ order }}({{ arg }} y, {{ arg }} x) {
            return Atan2P{{ order }}(y.Bits, x.Bits);
        }
        {%- endfor %}
        {%- for v in vector_list %}
        {%- if v[0] + v[1] > bits %}{% continue %}{% endif %}
        {%- set arg = macros::vector_type(dim=2, type=macros::fixed_type(i=v[0], f=v[1], s=true)) %}

        /// <summary>
        {%- if int_nbits == 2 %}
        /// <see cref="One" /> を PI とする逆正接の値を返す｡
        {%- elif int_nbits - frac_nbits == 2 %}
        /// <see cref="One" /> を PI / 2 とする逆正接の値を返す｡
        {%- endif %}
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} Atan2P{{ order }}({{ arg }} v) {
            return Atan2P{{ order }}(v.Y.Bits, v.X.Bits);
        }
        {%- endfor %}
        {%- endfor %}

#pragma warning restore IDE0002 // メンバー アクセスを単純化します
#pragma warning restore IDE0079 // 不要な抑制を削除します
        {%- if bits == 64 %}

#endif // NET7_0_OR_GREATER
        {%- endif %}

        #endregion
        {%- endif %}
        {%- endif %}
        {%- else %}
        {%- if bits < 128 %}
        {%- if int_nbits == 2 %}
        #region Acos
        {%- set arg = macros::fixed_type(i=2+frac_nbits/2, f=frac_nbits/2, s=true) %}
        {%- for order in [3, 7] %}
        {%- if order > 3 and bits < 64 %}
            {%- continue %}
        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} AcosP{{ order }}({{ arg }} x) => FromBits(Mathi.AcosP{{ order }}(x.Bits));
        {%- endfor %}
        #endregion
        {%- endif %}
        {%- endif %}
        {%- endif %}
        {%- if signed and bits < 128 and int_nbits - frac_nbits ==  2 %}
        #region Sin, Cos
        {%- set sin = ['Sin', '正弦比'] %}
        {%- set cos = ['Cos', '余弦比'] %}
        {%- for m in [sin, cos] %}
        {%- for o in [2, 3, 4, 5, 10, 11] %}
        {%- if o > 5 and bits < 64 %}
            {%- continue %}
        {%- endif %}
        {%- set f = m[0] ~ 'P' ~ o %}
        {%- set t = macros::fixed_type(i=2, f=bits-2, s=true) %}

        /// <summary>
        /// {{ o }} 次の多項式で{{ m[1] }}を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>{{ m[1] }}</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ t }} {{ f }}({{ self_bits_type }} x) => {{ t }}.FromBits(Mathi.{{ f }}(x));

        /// <summary>
        /// {{ o }} 次の多項式で{{ m[1] }}を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>{{ m[1] }}</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ t }} {{ f }}() => {{ f }}(Bits);
        {%- endfor %}
        {%- endfor %}
        #endregion
        {%- endif %}
        {%- if signed and frac_nbits%15 == 0 %}
        #region Swizzling
        {%- for d in range(start=2, end=5) %}
        {%- for e in ['0', '1', 'X'] %}
        public {{ macros::vector_type(dim=d, type=self_type)
        }} {% for i in range(end=d-1) %}X{% endfor %}{{ e }}() => {{ macros::vector_type(dim=d, type=self_type)
        }}.FromRepr(new {{ macros::vector_primitive(dim=d, signed=signed, bits=bits)
        }}({% for i in range(end=d-1) %}Bits, {% endfor %}{% if e == 'X' %}Bits{% elif e == '1' %}OneRepr{% else %}{{ e }}{% endif %}));
        {%- endfor %}
        {%- endfor %}
        #endregion
        {%- endif %}

        // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning disable IDE0004 // 不要なキャストの削除

        #region Conversion from integer
        {%- for bits in [32, 64, 128] %}
        {%- if bits > 64 %}

#if NET7_0_OR_GREATER
        {%- endif %}
        {%- for s in [true, false] %}
        {%- set from = macros::inttype(bits=bits, signed=s) %}

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="{{ from }}" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator {{ self_type }}({{ macros::inttype(bits=bits, signed=s) }} num) {
            return FromBits(({{ self_bits_type }})num * OneRepr);
        }
        {%- endfor %}
        {%- if bits > 64 %}

#endif // NET7_0_OR_GREATER
        {%- endif %}
        {%- endfor %}

        #endregion
        #region Conversion from floating-point number

        // decimal からの型変換は基数 (Radix) が 2 のべき乗でないため実装しない。

        {%- for bits in [32, 64] %}
        {%-   if bits == 32 %}{% set from='float'  %}
        {%- elif bits == 64 %}{% set from='double' %}
        {%- endif %}

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="{{ from }}" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator {{ self_type }}({{ from }} num) {
            // OneRepr は 2 の自然数冪であるから,
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない.
            return FromBits(({{ self_bits_type }})(num * ({{ from }})OneRepr));
        }
        {%- endfor %}
        #endregion
        #region Conversion from fixed-point number

        {%- for s in [true, false] %}
        {%- for target in fixed_list %}
        {%- set i = target[0] %}
        {%- set f = target[1] %}
        {%- if s != signed or i != int_nbits or f != frac_nbits %}
        {%- if i + f > 64 %}

#if NET7_0_OR_GREATER
        {%- endif %}
        {%- set from = macros::fixed_type(s=s, i=i, f=f) %}

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="{{ from }}" /> value.</para>
        /// </summary>
        public static explicit operator {{ self_type }}({{ from }} from) {
            return FromBits(({{ self_bits_type }})
                {%- if frac_nbits < f -%}
                (from.Bits / ({{ from }}.EpsilonRepr << {{ f-frac_nbits }}))
                {%- elif frac_nbits > f -%}
                from.Bits * (EpsilonRepr << {{ frac_nbits-f }})
                {%- else -%}
                from.Bits
                {%- endif -%}
            );
        }
        {%- if i + f > 64 %}

#endif // NET7_0_OR_GREATER
        {%- endif %}
        {%- endif %}
        {%- endfor %}
        {%- endfor %}

        #endregion
        #region Conversion to integer
        {%- for bits in [32, 64, 128] %}
        {%- if bits > 64 %}

#if NET7_0_OR_GREATER
        {%- endif %}
        {%- for s in [true, false] %}
        {%- set t = macros::inttype(bits=bits, signed=s) %}

        /// <summary>
        /// <para><see cref="{{ t }}" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator {{ t }}({{ self_type }} v) {
            return ({{ t }})(v.Bits / OneRepr);
        }
        {%- endfor %}
        {%- if bits > 64 %}

#endif // NET7_0_OR_GREATER
        {%- endif %}
        {%- endfor %}

        #endregion
        #region Conversion to floating-point number

        // 浮動小数点数への変換は必ず成功する。
        // 除算は最適化によって乗算に置き換えられることを期待する。
        {%- for bits in [32, 64] %}
        {%- if   bits == 32 %}{% set t='float'  %}
        {%- elif bits == 64 %}{% set t='double' %}{% endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator {{ t }}({{ self_type }} v) => ({{ t }})v.Bits / ({{ t }})OneRepr;
        {%- endfor %}
        #endregion

#pragma warning restore CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

    }
} // namespace {{ namespace }}

{%- if bits > 64 %}

#endif // NET7_0_OR_GREATER
{%- endif %}
