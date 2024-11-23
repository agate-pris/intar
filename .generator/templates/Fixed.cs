{% import "macros.cs" as macros %}
{%- set self_type = macros::fixed_type(s = signed, i = int_nbits, f = frac_nbits) %}
{%- set self_bits_type      = macros::inttype(bits=int_nbits  +frac_nbits,   signed=signed) %}
{%- set self_bits_utype     = macros::inttype(bits=int_nbits  +frac_nbits,   signed=false)  %}
{%- if 64 < int_nbits+frac_nbits %}
    {%- set const = 'static readonly' %}{%- else %}
    {%- set const = 'const' %}
{%- endif %}

{#- 固定小数点数の定義 -#}
{%- if 64 < int_nbits+frac_nbits -%}
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
        {%- if signed %}
        internal {{ const }} {{ self_bits_utype }} MaxReprUnsigned = {% if int_nbits + frac_nbits > 64 %}({{ self_bits_utype }}){% endif %}MaxRepr;
        {%- endif %}
        internal {{ const }} {{ self_bits_type }} EpsilonRepr = 1;

        internal {{ const }} {{ self_bits_type }} OneRepr = {{
            macros::one(bits=int_nbits+frac_nbits, signed=signed)
        }} << FracNbits;

        #endregion

        #region Fields

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public {{ self_bits_type }} Bits;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        #endregion

        #region Constructor, FromBits

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        {{ self_type }}({{ self_bits_type }} bits) {
            Bits = bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} FromBits({{ self_bits_type }} bits) => new {{ self_type }}(bits);

        #endregion

        #region Zero, One, MinValue, MaxValue, Epsilon

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
        public static readonly {{ self_type }} MinValue = new {{ self_type }}(MinRepr);
        public static readonly {{ self_type }} MaxValue = new {{ self_type }}(MaxRepr);
        internal static readonly {{ self_type }} Epsilon = new {{ self_type }}(EpsilonRepr);

        #endregion

        {%- if int_nbits+frac_nbits < 128 %}

        #region WideBits
        {%- if int_nbits+frac_nbits > 32 %}

#if NET7_0_OR_GREATER
        {%- endif %}

        internal {{
            macros::inttype(bits=int_nbits*2+frac_nbits*2, signed=signed)
        }} WideBits {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Bits;
        }
        {%- if int_nbits+frac_nbits > 32 %}

#endif // NET7_0_OR_GREATER
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

        {%- if int_nbits+frac_nbits < 128 %}

        #region IMultiplicationOperators, IDivisionOperators
        {%- if int_nbits+frac_nbits > 32 %}

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER
        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator *({{ self_type }} left, {{ self_type }} right) {
            return FromBits(({{ self_bits_type }})(left.WideBits * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator /({{ self_type }} left, {{ self_type }} right) {
            return FromBits(({{ self_bits_type }})(left.WideBits * OneRepr / right.Bits));
        }

        {%- if int_nbits+frac_nbits > 32 %}

#endif // NET7_0_OR_GREATER
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
        {%- endif %}

        #endregion

        #region IEqualityOperators, IComparisonOperators
{# 改行 #}
        {%- for op in ['==', '!=', '<', '>', '<=', '>='] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator {{ op }}({{ self_type }} left, {{ self_type }} right) => left.Bits {{ op }} right.Bits;
        {%- endfor %}

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is {{ self_type }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => {% if
            int_nbits + frac_nbits > 32
        %}Lossy{% endif %}ToDouble().ToString((IFormatProvider)null);

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ self_type }} other) => this == other;

        #endregion

        #region IFormattable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return {% if
                int_nbits + frac_nbits > 32
            %}Lossy{% endif %}ToDouble().ToString(format, formatProvider);
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
{# 改行 #}
        {%- for m in ['Min', 'Max'] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{
        self_type }} {{ m }}({{ self_type
        }} other) => FromBits({% if int_nbits+frac_nbits > 64
        %}{{ self_bits_type }}{% else
        %}Math{% endif %}.{{ m }}(Bits, other.Bits));
        {%- endfor %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} Clamp({{ self_type }} min, {{ self_type }} max) {
            {%- if int_nbits + frac_nbits > 64 %}
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
        }} Abs() => FromBits({% if int_nbits+frac_nbits > 64
        %}{{ self_bits_type }}{% else
        %}Math{% endif %}.Abs(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ macros::fixed_type(s=false, i=int_nbits, f=frac_nbits) }} UnsignedAbs() {
            return {{ macros::fixed_type(s=false, i=int_nbits, f=frac_nbits) }}.FromBits(Mathi.UnsignedAbs(Bits));
        }

        {%- endif %}

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal {{ self_type }} Half() => FromBits(Mathi.Half(Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal {{ self_type }} Twice() => FromBits(Mathi.Twice(Bits));

        #region BigMul

        {%- for output in fixed_list %}
        {%- for rhs in fixed_list %}
        {%- if  int_nbits + rhs[0] != output[0]
            or frac_nbits + rhs[1] != output[1] %}
            {%- continue %}
        {%- endif %}
        {%- set   signed_big = macros::fixed_type(s=true,  i=int_nbits+rhs[0], f=frac_nbits+rhs[1]) %}
        {%- set unsigned_big = macros::fixed_type(s=false, i=int_nbits+rhs[0], f=frac_nbits+rhs[1]) %}
        {%- if output[0] + output[1] > 64 %}

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
            {%- if int_nbits + frac_nbits > 32 %}
                {%- set c = '(' ~ u ~ ')' %}{% else %}
                {%- set c = '' %}
            {%- endif %}
            return {{ t }}.FromBits({{ c }}Bits * {{ c }}other.Bits);
        }

        {%- endif %}
        {%- endfor %}
        {%- if output[0] + output[1] > 64 %}

#endif // NET7_0_OR_GREATER
        {%- endif %}
        {%- endfor %}
        {%- endfor %}

        #endregion

        {%- if signed %}
        {%- if int_nbits == 17 and frac_nbits == 15
            or int_nbits == 33 and frac_nbits == 31 %}

        #region Asin, Acos, Atan
        {%- for order in [3, 7] %}
        {%- if order == 7 and int_nbits < 32 %}
            {%- continue %}
        {%- endif %}

        {%- set acos = macros::fixed_type(i=int_nbits-frac_nbits, f=2*frac_nbits, s=false) %}
        {%- set asin = macros::fixed_type(i=int_nbits-frac_nbits, f=2*frac_nbits, s=true ) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ acos }} AcosP{{ order }}() => {{ acos }}.FromBits(Mathi.AcosP{{ order }}(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ asin }} AsinP{{ order }}() => {{ asin }}.FromBits(Mathi.AsinP{{ order }}(Bits));
        {%- endfor %}

        {%- for order in [2, 3, 9] %}
        {%- set atan = macros::fixed_type(i=2, f=int_nbits+frac_nbits-2, s=true) %}
        {%- if order == 9 and int_nbits < 32 %}
            {%- continue %}
        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ atan }} AtanP{{ order }}() => {{ atan }}.FromBits(Mathi.AtanP{{ order }}(Bits));
        {%- endfor %}

        #endregion
        {%- endif %}

        #region Atan2

        {%- if int_nbits+frac_nbits > 32 %}

        // Atan2 は 32 ビットの固定小数点数に対してのみ定義されている。
        // 実装のために 128 ビット整数が必要なため、
        // 64 ビットの固定小数点数に対しては未実装。

        {%- else %}

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0002 // メンバー アクセスを単純化します

        {%- for order in [2, 3, 9] %}
        {%- if order < 9 %}
            {%- set f = 32-2 %}
        {%- else %}
            {%- set f = 64-2 %}
        {%- endif %}
        {%- set atan = macros::fixed_type(i=2, f=f, s=true) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ atan }} Atan2P{{ order }}({{ self_type }} other) {
            return {{ atan }}.FromBits(Mathi.Atan2P{{ order }}(Bits, other.Bits));
        }
        {%- endfor %}

#pragma warning restore IDE0002 // メンバー アクセスを単純化します
#pragma warning restore IDE0079 // 不要な抑制を削除します

        {%- endif %}

        #endregion
        {%- endif %}

        {%- if signed %}
        {%- if int_nbits == 17 and frac_nbits == 15
            or int_nbits == 33 and frac_nbits == 31 %}

        #region Sin, Cos
        {%- set sin = ['Sin', '正弦比'] %}
        {%- set cos = ['Cos', '余弦比'] %}
        {%- for m in [sin, cos] %}
        {%- for o in [2, 3, 4, 5, 10, 11] %}
        {%- if o > 5 and int_nbits + frac_nbits < 64 %}
            {%- continue %}
        {%- endif %}
        {%- set f = m[0] ~ 'P' ~ o %}
        {%- set t = macros::fixed_type(i=2, f=int_nbits+frac_nbits-2, s=true) %}

        /// <summary>
        /// {{ o }} 次の多項式で{{ m[1] }}を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>{{ m[1] }}</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ t }} {{ f }}() => {{ t }}.FromBits(Mathi.{{ f }}(Bits));

        {%- endfor %}
        {%- endfor %}

        #endregion
        {%- endif %}
        {%- endif %}

        // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning disable IDE0004 // 不要なキャストの削除

        #region Convert from integer

        {%- for bits in [32, 64] %}
        {%- for s in [true, false] %}
        {%- set from = macros::inttype(bits=bits, signed=s) %}

        {%- for method in ['from', 'strict', 'unchecked', 'checked'] %}
        {#- 自身の符号部を除いた整数部のビット数が
            相手の符号部を除いたビット数以上の場合
            暗黙に型変換可能. #}
        {%- set implicitly_convertible
            = signed == s and int_nbits >= bits
            or signed and not s and int_nbits - 1 >= bits %}

        {#- 暗黙に型変換可能な場合は From のみを定義する.
            それ以外の場合 From 以外 (StrictFrom, CheckedFrom) を定義する. #}
        {%- if implicitly_convertible %}
            {%- if method != 'from' %}
                {%- continue %}
            {%- endif %}
        {%- else %}
            {%- if method == 'from' %}
                {%- continue %}
            {%- endif %}
        {%- endif %}

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="{{ from }}" /> value.</para>
        /// <para><see cref="{{ from }}" /> から新しく固定小数点数を構築します。</para>
        {%- if method == 'strict' %}
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom({{ from }})"/>
        /// <seealso cref="CheckedFrom({{ from }})"/>
        {%- elif method == 'unchecked' %}
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom({{ from }})"/>
        /// <seealso cref="CheckedFrom({{ from }})"/>
        {%- elif method == 'checked' %}
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom({{ from }})"/>
        /// <seealso cref="UncheckedFrom({{ from }})"/>
        {%- else %}
        /// </summary>
        {%- endif %}
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = {{ self_type }}.
        {%- if method == 'strict' %}Strict{% endif %}
        {%- if method == 'unchecked' %}Unchecked{% endif %}
        {%- if method == 'checked' %}Checked{% endif %}From(1);
        /// System.Assert.AreEqual({{
            macros::one(bits=int_nbits+frac_nbits, signed=signed)
        }} &lt;&lt; {{ frac_nbits }}, a{% if method == 'checked' %}?{% endif %}.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }}
        {%- if method == 'checked' %}? Checked{% else %} {% endif %}
        {%- if method == 'strict' %}Strict{% endif %}
        {%- if method == 'unchecked' %}Unchecked{% endif %}From({{ from }} num) {

            {%- if method == 'from' %}
            // 自身と相手の符号が同じ場合、整数部が相手以上であるから乗算は必ず成功する。
            // 自身が符号あり、相手が符号なしの場合、
            // 自身の符号部分を除いた整数部について同様である。
            {%- endif %}

            {%- if method != 'checked' %}
            return FromBits(
                {%- if method == 'from' or method == 'unchecked' %}unchecked({% endif %}
                {%- if method == 'strict' %}checked({% endif %}
                {%- if method == 'strict' or method == 'unchecked' %}({{ self_bits_type }}){% endif -%}
                num * OneRepr
                {%- if method == 'from' or method == 'unchecked' %}){% endif %}
                {%- if method == 'strict' %}){% endif -%}
            );
            {%- else %}
            {%- if signed == s %}

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (num > MaxRepr / OneRepr ||
                num < MinRepr / OneRepr) {
                return null;
            }

            {%- elif signed and not s %}

            // 自身が符号あり、相手が符号なしであるから、
            // 相手が最小値未満であることはありえない。
            // よって、自身の最大値を符号なしの型に変換して比較する。
            // この際、大きい方の型に暗黙に変換される。
            if (num > ({{
                macros::inttype(bits=int_nbits+frac_nbits, signed=false)
            }})(MaxRepr / OneRepr)) {
                return null;
            }

            {%- else %}

            // 自身が符号なしで、相手が符号ありの場合、
            // 相手が 0 未満、または
            // 相手が自身の最大値よりも大きければ null
            if (num < 0) {
                return null;
            } else if (({{
                macros::inttype(bits=bits, signed=false)
            }})num > MaxRepr / OneRepr) {
                return null;
            }

            {%- endif %}

            return FromBits(({{ self_bits_type }})num * OneRepr);
            {%- endif %}
        }

        {%- endfor %}
        {%- endfor %}
        {%- endfor %}

        #endregion

        #region Convert from floating-point number

        // decimal からの型変換は基数 (Radix) が 2 のべき乗でないため実装しない。

        {%- for bits in [32, 64] %}
        {%-   if bits == 32 %}{% set from='float'  %}{% set one='1.0f' %}
        {%- elif bits == 64 %}{% set from='double' %}{% set one='1.0'  %}
        {%- endif %}

        {%- set lossy = int_nbits + frac_nbits < bits %}

        {%- for method in ['strict', 'unchecked', 'checked'] %}

        {#- メソッドが checked の場合, 精度が double 以上の場合は定義しない. #}
        {%- if method == 'checked' %}
        {%- if int_nbits + frac_nbits > 32 %}

        // 自身が 64 ビットの場合､ BitConverter を使用する必要がある。
        // 現時点では未実装。
        // https://learn.microsoft.com/ja-jp/dotnet/api/system.bitconverter

        {%- continue %}
        {%- endif %}
        {%- endif %}

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="{{ from }}" /> value.</para>
        /// <para> <see cref="{{ from }}" /> から新しく固定小数点数を構築します。</para>
        {%- if method == 'strict' %}
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="Unchecked{% if lossy %}Lossy{% endif %}From({{ from }})"/>
            {%- if int_nbits + frac_nbits < 64 %}
        /// <seealso cref="Checked{% if lossy %}Lossy{% endif %}From({{ from }})"/>
            {%- endif %}
        {%- elif method == 'unchecked' %}
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="Strict{% if lossy %}Lossy{% endif %}From({{ from }})"/>
            {%- if int_nbits + frac_nbits < 64 %}
        /// <seealso cref="Checked{% if lossy %}Lossy{% endif %}From({{ from }})"/>
            {%- endif %}
        {%- elif method == 'checked' %}
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="Strict{% if lossy %}Lossy{% endif %}From({{ from }})"/>
        /// <seealso cref="Unchecked{% if lossy %}Lossy{% endif %}From({{ from }})"/>
        {%- else %}
        /// </summary>
        {%- endif %}
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = {{ self_type }}.
        {%- if method == 'strict' %}Strict{% endif %}
        {%- if method == 'unchecked' %}Unchecked{% endif %}
        {%- if method == 'checked' %}Checked{% endif %}
        {%- if lossy %}Lossy{% endif %}From({{ one }});
        /// System.Assert.AreEqual({{
            macros::one(bits=int_nbits+frac_nbits, signed=signed)
        }} &lt;&lt; {{ frac_nbits }}, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }}
        {%- if method == 'checked' %}? Checked{% else %} {% endif %}
        {%- if method == 'strict' %}Strict{% endif %}
        {%- if method == 'unchecked' %}Unchecked{% endif %}
        {%- if lossy %}Lossy{% endif %}From({{ from }} num) {
            {%- if method != 'checked' %}
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(
                {%- if method == 'strict' %}checked
                {%- else %}unchecked{% endif %}(({{ self_bits_type }})(num * ({{ from }})OneRepr)));
            {%- else %}
            {%- if not lossy %}
            // より大きい型に変換して計算。
            return CheckedLossyFrom(num);
            {%- else %}
            // OneRepr は 2 の自然数冪であるから、
            // その乗算によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            // また、整数の基数は 2 であるから、
            // 自身のビット数よりも相手の仮数部の方が大きい限り、
            // 最大値に 1 足した数と最小値から 1 引いた数は厳密に表現可能である。
            num *= OneRepr;
            if ({{ from }}.IsNaN(num) ||
                {{ from }}.IsInfinity(num) ||
                num >= {{ self_bits_type }}.MaxValue + {{ one }}
            {%- if signed %} ||
                num <= {{ self_bits_type }}.MinValue - {{ one }}
            {%- endif %}) {
                return null;
            }
            return FromBits(({{ self_bits_type }})num);
            {%- endif %}
            {%- endif %}
        }

        {%- endfor %}
        {%- endfor %}

        #endregion

        #region Convert from fixed-point number

        {%- for s in [true, false] %}
        {%- for target in fixed_list %}
        {%- set i = target[0] %}
        {%- set f = target[1] %}
        {%- if s != signed or i != int_nbits or f != frac_nbits %}
        {%- if i + f > 64 %}

#if NET7_0_OR_GREATER
        {%- endif %}

        {%- set from = macros::fixed_type(s=s, i=i, f=f) %}
        {%- set lossy = frac_nbits < f %}
        {%- set failable = not signed and s
            or signed == s and int_nbits < i
            or signed and not s and int_nbits - 1 < i %}
        {%- set fu = macros::inttype(signed=false, bits=i+f) %}
        {%- set tu = macros::inttype(signed=false, bits=int_nbits+frac_nbits) %}

        {#- コメントなどを共通化するためにループ処理でまかなう #}
        {%- for method in ['from', 'strict', 'unchecked', 'checked'] %}

        {#- 失敗しうる場合 From は定義しない.
            それ以外の場合 From 以外は定義しない. #}
        {%- if failable %}
            {%- if method == 'from' %}
                {%- continue %}
            {%- endif %}
        {%- else %}
            {%- if method != 'from' %}
                {%- continue %}
            {%- endif %}
        {%- endif %}

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="{{ from }}" /> value.</para>
        /// <para><see cref="{{ from }}" /> から新しく固定小数点数を構築します。</para>
        {%- if method == 'strict' %}
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="Unchecked{% if lossy %}Lossy{% endif %}From({{ from }})"/>
        /// <seealso cref="Checked{% if lossy %}Lossy{% endif %}From({{ from }})"/>
        {%- elif method == 'unchecked' %}
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="Strict{% if lossy %}Lossy{% endif %}From({{ from }})"/>
        /// <seealso cref="Checked{% if lossy %}Lossy{% endif %}From({{ from }})"/>
        {%- elif method == 'checked' %}
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="Strict{% if lossy %}Lossy{% endif %}From({{ from }})"/>
        /// <seealso cref="Unchecked{% if lossy %}Lossy{% endif %}From({{ from }})"/>
        {%- else %}
        /// </summary>
        {%- endif %}
        public static {{ self_type }}
        {%- if method == 'checked' %}? Checked{% else %} {% endif %}
        {%- if method == 'strict' %}Strict{% endif %}
        {%- if method == 'unchecked' %}Unchecked{% endif %}
        {%- if lossy %}Lossy{% endif %}From({{ from }} from) {
            {%- if method != 'checked' %}
            return FromBits(
                {%- if method == 'strict' %}checked
                {%- else %}unchecked{% endif %}(({{ self_bits_type }})
                {%- if lossy -%}
                    (from.Bits / ({{ from }}.EpsilonRepr << {{ f-frac_nbits }}))
                {%- else -%}
                    from.Bits * (EpsilonRepr << {{ frac_nbits-f }})
                {%- endif %})
            );

            {%- else %}

            {%- if lossy %}
            var tmp = from.Bits / ({{ from }}.EpsilonRepr << {{ f-frac_nbits }});

            {%- if signed == s %}
            if (tmp < MinRepr ||
                tmp > MaxRepr) {
                return null;
            }
            {%- elif signed %}
            if (tmp > MaxReprUnsigned) {
                return null;
            }
            {%- else %}
            if (tmp < 0) {
                return null;
            } else if (({{ fu }})tmp > MaxRepr) {
                return null;
            }
            {%- endif %}
            return FromBits(({{ self_bits_type }})tmp);

            {%- else %}
            const int shift = {{ frac_nbits-f }};
            {%- if int_nbits + frac_nbits > 64 %}
                {%- set lc = 'var' %}{%- else %}
                {%- set lc = 'const ' ~ self_bits_type %}
            {%- endif %}
            {{ lc }} k = EpsilonRepr << shift;
            {{ lc }} max = MaxRepr / k;

            {%- if signed == s %}
            {{ lc }} min = MinRepr / k;
            if (from.Bits > max ||
                from.Bits < min) {
                return null;
            }
            {%- elif signed %}
            if (from.Bits > ({{ tu }})max) {
                return null;
            }
            {%- else %}
            if (from.Bits < 0) {
                return null;
            } else if (({{ fu }})from.Bits > max) {
                return null;
            }
            {%- endif %}
            return FromBits(({{ self_bits_type }})from.Bits * k);
            {%- endif %}

            {%- endif %}
        }

        {%- endfor %}

        {%- if i + f > 64 %}

#endif // NET7_0_OR_GREATER
        {%- endif %}
        {%- endif %}
        {%- endfor %}
        {%- endfor %}

        #endregion

        #region Convert to integer

        // 整数への変換で小数点以下の精度が失われるのは自明なので
        // わざわざ明記することはしない。

        {%- for bits in [32, 64] %}
        {%- for s in [true, false] %}
        {%- set t = macros::inttype(bits=bits, signed=s) %}

        {#- 自身と相手の符号ありなしが同じか、
            自身が符号なしで相手が符号ありの場合、
            符号部を除いたビット数について、
            自身の整数部のそれよりも相手のそれの方が大きければ
            変換は必ず成功する。 #}
        {%- set implicitly_convertible
            = signed == s and int_nbits <= bits
            or not signed and s and int_nbits <= bits - 1 %}

        {%- for method in ['to', 'strict', 'unchecked', 'checked'] %}

        {#- 暗黙に変換可能な場合 To 以外は定義しない. #}
        {%- if implicitly_convertible %}
            {%- if method != 'to' %}
                {%- continue %}
            {%- endif %}
        {%- else %}
            {%- if method == 'to' %}
                {%- continue %}
            {%- endif %}
        {%- endif %}

        /// <summary>
        /// <para><see cref="{{ t }}" /> への変換を行います。</para>
        {%- if method == 'strict' %}
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedTo{% if not s %}U{% endif %}Int{{ bits }}"/>
        /// <seealso cref="CheckedTo{% if not s %}U{% endif %}Int{{ bits }}"/>
        {%- elif method == 'unchecked' %}
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictTo{% if not s %}U{% endif %}Int{{ bits }}"/>
        /// <seealso cref="CheckedTo{% if not s %}U{% endif %}Int{{ bits }}"/>
        {%- elif method == 'checked' %}
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictTo{% if not s %}U{% endif %}Int{{ bits }}"/>
        /// <seealso cref="UncheckedTo{% if not s %}U{% endif %}Int{{ bits }}"/>
        {%- else %}
        /// </summary>
        {%- endif %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ t }}
        {%- if method == 'checked' %}? Checked{% else %} {% endif %}
        {%- if method == 'strict' %}Strict{% endif %}
        {%- if method == 'unchecked' %}Unchecked{% endif -%}
        To{% if not s %}U{% endif %}Int{{ bits }}() {
            {%- if method != 'checked' %}
            return {% if method == 'strict' %}checked
            {%- else %}unchecked{% endif %}(({{ t }})(Bits / OneRepr));

            {%- else %}
            var tmp = Bits / OneRepr;

            {%- if signed == s %}

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (tmp < {{ t }}.MinValue ||
                tmp > {{ t }}.MaxValue) {
                return null;
            }

            {%- elif signed and not s %}

            // 自身が符号ありで、相手が符号なしの場合、
            // 自身が 0 未満、または
            // 自身が相手の最大値よりも大きければ null
            if (tmp < 0) {
                return null;
            } else if (({{
                macros::inttype(signed=false, bits=int_nbits+frac_nbits)
            }})tmp > {{ t }}.MaxValue) {
                return null;
            }

            {%- else %}

            // 自身が符号なしで、相手が符号ありの場合、
            // 自身が相手の最大値よりも大きければ null
            if (tmp > {{ t }}.MaxValue) {
                return null;
            }

            {%- endif %}

            return ({{ t }})tmp;

            {%- endif %}
        }

        {%- endfor %}

        {%- endfor %}
        {%- endfor %}

        #endregion

        #region Convert to floating-point number

        // 浮動小数点数への変換は必ず成功する。
        // 除算は最適化によって乗算に置き換えられることを期待する。
{# 改行 #}

        {#- 浮動小数点数型への変換 #}
        {%- for bits in [32, 64] %}
        {%- if   bits == 32 %}{% set t='float'  %}
        {%- elif bits == 64 %}{% set t='double' %}{% endif %}

        {#- 相手のビット数が自身以下の場合、精度を失う。 #}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ t }} {% if
            bits <= int_nbits + frac_nbits
        %}Lossy{% endif %}To{% if
            bits == 32 %}Single{% elif
            bits == 64 %}Double{% endif %}() => ({{ t }})Bits / ({{ t }})OneRepr;

        {%- endfor %}

        #endregion

#pragma warning restore CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

    }
} // namespace {{ namespace }}

{%- if 64 < int_nbits+frac_nbits %}

#endif // NET7_0_OR_GREATER
{%- endif %}
