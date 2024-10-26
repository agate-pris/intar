{% import "macros.cs" as macros %}
{%- set self_type = macros::fixed_type(s = signed, i = int_nbits, f = frac_nbits) %}
{%- set self_bits_type      = macros::inttype(bits=int_nbits  +frac_nbits,   signed=signed) %}
{%- set self_wide_bits_type = macros::inttype(bits=int_nbits*2+frac_nbits*2, signed=signed) %}

{#- 固定小数点数の定義 -#}

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct {{ self_type }} : IEquatable<{{ self_type }}>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = {{ int_nbits }};
        public const int FracNbits = {{ frac_nbits }};

        internal const {{ self_bits_type }} MinRepr = {{ self_bits_type }}.MinValue;
        internal const {{ self_bits_type }} MaxRepr = {{ self_bits_type }}.MaxValue;

        const {{ self_bits_type }} OneRepr = {{
            macros::one(bits=int_nbits+frac_nbits, signed=signed)
        }} << FracNbits;

        // Fields
        // ------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public {{ self_bits_type }} Bits;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        {{ self_type }}({{ self_bits_type }} bits) {
            Bits = bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} FromBits({{ self_bits_type }} bits) => new {{ self_type }}(bits);

        // Static Properties
        // -----------------

        public static {{ self_type }} Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ self_type }}(0);
        }
        public static {{ self_type }} One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new {{ self_type }}(OneRepr);
        }
        public static {{ self_type }} MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(MinRepr);
        }
        public static {{ self_type }} MaxValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(MaxRepr);
        }

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator +({{ self_type }} left, {{ self_type }} right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator -({{ self_type }} left, {{ self_type }} right) {
            return FromBits(left.Bits - right.Bits);
        }

{%- if int_nbits + frac_nbits == 64 %}

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

{%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator *({{ self_type }} left, {{ self_type }} right) {
            {{ self_wide_bits_type }} l = left.Bits;
            return FromBits(({{ self_bits_type }})(l * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator /({{ self_type }} left, {{ self_type }} right) {
            {{ self_wide_bits_type }} l = left.Bits;
            return FromBits(({{ self_bits_type }})(l * OneRepr / right.Bits));
        }

{%- if int_nbits + frac_nbits == 64 %}

#endif

{%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator +({{ self_type }} x) => FromBits(+x.Bits);

{%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} operator -({{ self_type }} x) => FromBits(-x.Bits);
{%- endif %}

        // Comparison operators
        // --------------------
{# これは改行を挿入するためのコメントです #}
{%- for op in ['==', '!=', '<', '>', '<=', '>='] %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator {{ op }}({{ self_type }} left, {{ self_type }} right) => left.Bits {{ op }} right.Bits;
{%- endfor %}

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is {{ self_type }} o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => {% if
            int_nbits + frac_nbits > 32
        %}Lossy{% endif %}ToDouble().ToString((IFormatProvider)null);

        // IEquatable<{{ self_type }}>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals({{ self_type }} other) => this == other;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return {% if
                int_nbits + frac_nbits > 32
            %}Lossy{% endif %}ToDouble().ToString(format, formatProvider);
        }

        //
        // IComparable
        //

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

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} Min({{ self_type }} other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} Max({{ self_type }} other) => FromBits(Math.Max(Bits, other.Bits));
{%- if signed %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} Abs() => FromBits(Math.Abs(Bits));
{%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} Clamp(
            {{ self_type }} min, {{ self_type }} max
        ) => FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} Half() => FromBits(Mathi.Half(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ self_type }} Twice() => FromBits(Mathi.Twice(Bits));

        {%- if signed %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ macros::fixed_type(s=false, i=int_nbits, f=frac_nbits) }} UnsignedAbs() {
            return {{ macros::fixed_type(s=false, i=int_nbits, f=frac_nbits) }}.FromBits(Overflowing.UnsignedAbs(Bits));
        }

        {%- endif %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool OverflowingAdd({{ self_type }} other, out {{ self_type }} result) {
            var b = Overflowing.OverflowingAdd(Bits, other.Bits, out var bits);
            result = FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}? CheckedAdd({{ self_type }} other) {
            {{ self_type }}? @null = null;
            return OverflowingAdd(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} SaturatingAdd({{ self_type }} other) {
            return FromBits(Overflowing.SaturatingAdd(Bits, other.Bits));
        }

        {%- if int_nbits + frac_nbits <= 32 %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool OverflowingMul({{ self_type }} other, out {{ self_type }} result) {
            var b = Overflowing.OverflowingMul(Bits, other.Bits, out var bits);
            result = FromBits(unchecked(({{ self_bits_type }})bits));
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }}? CheckedMul({{ self_type }} other) {
            {{ self_type }}? @null = null;
            return OverflowingMul(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ self_type }} SaturatingMul({{ self_type }} other) {
            return FromBits(Overflowing.SaturatingMul(Bits, other.Bits));
        }

        {%- endif %}

{%- for output in fixed_list %}
    {%- for rhs in fixed_list %}
        {%- if int_nbits + rhs[0] == output[0]
            and frac_nbits + rhs[1] == output[1] %}
            {%- set   signed_big = macros::fixed_type(s=true,  i=int_nbits+rhs[0], f=frac_nbits+rhs[1]) %}
            {%- set unsigned_big = macros::fixed_type(s=false, i=int_nbits+rhs[0], f=frac_nbits+rhs[1]) %}
            {%- for s in [true, false] %}
                {%- if signed == s %}
                    {%- set t = macros::fixed_type(s=s,  i=int_nbits+rhs[0], f=frac_nbits+rhs[1]) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ t }} BigMul({{
            macros::fixed_type(s=s, i=rhs[0], f=rhs[1])
        }} other) {
            return {{ t }}.FromBits(({{
                self_wide_bits_type
            }})Bits * other.Bits);
        }

                {%- else %}
                    {%- set t = macros::fixed_type(s=true,  i=int_nbits+rhs[0], f=frac_nbits+rhs[1]) %}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ t }} BigMul({{
            macros::fixed_type(s=s, i=rhs[0], f=rhs[1])
        }} other) {
            return {{ t }}.FromBits(Bits * other.Bits);
        }

                {%- endif %}
            {%- endfor %}
        {%- endif %}
    {%- endfor %}
{%- endfor %}

        {%- if signed and int_nbits == 17 and frac_nbits == 15 %}
        {%- for name in [
            "SinP4",
            "SinP5",
            "CosP4",
            "CosP5",
        ] %}
        {%- set sin = name is starting_with("Sin") %}
        {%- set dim = name | trim_start_matches(pat="SinP") | trim_start_matches(pat="CosP") | truncate(length=1, end="") %}

        /// <summary>
        /// {{ dim }} 次の多項式で{% if sin %}正弦比{% else %}余弦比{% endif %}を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>{% if sin %}正弦比{% else %}余弦比{% endif %}</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 {{ name }}() => I2F30.FromBits(Mathi.{{ name }}(Bits));

        {%- endfor %}
        {%- endif %}

        {%- for v in vector_list %}
        {%- if v[0] == int_nbits and v[1] == frac_nbits %}

        // ベクトル型との演算
        // ------------------

{%- if not signed %}

#if AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

{%- endif %}
{# これは改行を挿入するためのコメントです #}

        {%- for dim in [2, 3, 4] %}
        {%- set vec_type = macros::vector_type(dim=dim, type=self_type) %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ vec_type }} SaturatingMul({{ vec_type }} other) => other.SaturatingMul(this);
        {%- endfor %}

{%-if not signed %}

#endif // AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

{%- endif %}

        {%- endif %}
        {%- endfor %}

        //
        // Convert from
        //

        // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079 // 不要な抑制を削除します

#pragma warning disable CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning disable IDE0004 // 不要なキャストの削除

{#- 整数型からの変換 #}
{%- for bits in [32, 64] %}
    {%- for s in [true, false] %}
        {%- set from = macros::inttype(bits=bits, signed=s) %}

        {#- 符号の有無が同じで整数部の桁数が相手以上か、
            自身が符号あり、相手が符号なしで
            符号を除いた整数部の桁数が相手以上なら必ず変換可能 #}
        {%- if signed == s and int_nbits >= bits
            or signed and not s and int_nbits - 1 >= bits %}

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="{{ from }}" /> value.</para>
        /// <para><see cref="{{ from }}" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = {{ self_type }}.From(1);
        /// System.Assert.AreEqual({{
            macros::one(bits=int_nbits+frac_nbits, signed=signed)
        }} &lt;&lt; {{ frac_nbits }}, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} From({{ from }} num) {
            // 自身と相手の符号が同じ場合、整数部が相手以上であるから乗算は必ず成功する。
            // 自身が符号あり、相手が符号なしの場合、
            // 自身の符号部分を除いた整数部について同様である。
            return FromBits(num * OneRepr);
        }

        {#- 変換に失敗する場合がある (表現の範囲外) 場合はこちら #}
        {%- else %}

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified <see cref="{{ from }}" /> value.</para>
        /// <para><see cref="{{ from }}" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = {{ self_type }}.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; {{ frac_nbits }}, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }}? CheckedFrom({{ from }} num) {

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
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified <see cref="{{ from }}" /> value.</para>
        /// <para><see cref="{{ from }}" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = {{ self_type }}.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; {{ frac_nbits }}, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} StrictFrom({{ from }} num) {
            return FromBits(checked(({{ self_bits_type }})num * OneRepr));
        }

        {%- endif %}
    {%- endfor %}
{%- endfor %}

        // decimal からの型変換は基数 (Radix) が 2 のべき乗でないため実装しない。

{#- 浮動小数点数型からの変換 #}
{%- for bits in [32, 64] %}
    {%-   if bits == 32 %}{% set from='float'  %}{% set one='1.0f' %}
    {%- elif bits == 64 %}{% set from='double' %}{% set one='1.0'  %}
    {%- endif %}

    {#- ビット数が自身よりも大きい場合、変換の際に精度を失う #}
    {%- if int_nbits + frac_nbits < bits %}

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified num.</para>
        /// <para>指定された数値から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = {{ self_type }}.StrictLossyFrom({{ one }});
        /// System.Assert.AreEqual(1 &lt;&lt; {{ frac_nbits }}, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }}? CheckedLossyFrom({{ from }} num) {
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
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified num.</para>
        /// <para>指定された数値から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = {{ self_type }}.StrictLossyFrom({{ one }});
        /// System.Assert.AreEqual(1 &lt;&lt; {{ frac_nbits }}, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} StrictLossyFrom({{ from }} num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked(({{ self_bits_type }})(num * OneRepr)));
        }

    {#- ビットが自身以下の場合、変換の際に精度は損なわれない
        半精度浮動小数点数はサポートしない。 #}
    {%- elif bits > 16 %}

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified num.</para>
        /// <para>指定された数値から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = {{ self_type }}.StrictFrom({{ one }});
        /// System.Assert.AreEqual(1 &lt;&lt; {{ frac_nbits }}, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }} StrictFrom({{ from }} num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked(({{ self_bits_type }})(num * OneRepr)));
        }

        {%- if int_nbits + frac_nbits < 64 %}

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified num.</para>
        /// <para>指定された数値から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = {{ self_type }}.StrictLossyFrom({{ one }});
        /// System.Assert.AreEqual(1 &lt;&lt; {{ frac_nbits }}, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {{ self_type }}? CheckedFrom({{ from }} num) {
            // より大きい型に変換して計算。
            return CheckedLossyFrom(num);
        }

        {%- else %}

        // 自身が 64 ビットの場合､ BitConverter を使用する必要がある。
        // 現時点では未実装。
        // https://learn.microsoft.com/ja-jp/dotnet/api/system.bitconverter

        {%- endif %}

    {%- endif %}
{%- endfor %}

        // 固定小数点数からの変換

{%- for s in [true, false] %}
    {%- for target in fixed_list %}
        {%- set i = target[0] %}
        {%- set f = target[1] %}
        {%- if s != signed or i != int_nbits or f != frac_nbits %}
            {%- set from = macros::fixed_type(s=s, i=i, f=f) %}
            {%- set lossy = frac_nbits < f %}
            {%- set failable = not signed and s
                or signed == s and int_nbits < i
                or signed and not s and int_nbits - 1 < i %}
            {%- set fb = macros::inttype(signed=s,     bits=i+f) %}
            {%- set fu = macros::inttype(signed=false, bits=i+f) %}
            {%- set tu = macros::inttype(signed=false, bits=int_nbits+frac_nbits) %}

            {#- コメントなどを共通化するためにループ処理でまかなう #}
            {%- for strict in [true, false] %}
                {%- if strict or failable %}

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="{{ from }}" /> value.</para>
        /// <para><see cref="{{ from }}" /> から新しく固定小数点数を構築します。</para>
        {%- if failable %}
            {%- if strict %}
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="Checked{% if lossy %}Lossy{% endif %}From({{ from }})"/>
            {%- else %}
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="Strict{% if lossy %}Lossy{% endif %}From({{ from }})"/>
            {%- endif %}
        {%- else %}
        /// </summary>
        {%- endif %}
        public static {{ self_type }}
        {%- if failable %}
            {%- if strict %} Strict
            {%- else %}? Checked
            {%- endif %}
        {%- else %} {% endif %}
        {%- if lossy %}Lossy{% endif %}From({{ from }} from) {
            {%- if strict or not failable %}
            return FromBits(
                {%- if failable %}checked({% endif %}({{ self_bits_type }})
                {%- if lossy -%}
                    (from.Bits / (({{ fb }})1 << {{ f-frac_nbits }}))
                {%- else -%}
                    from.Bits * (({{ self_bits_type }})1 << {{ frac_nbits-f }})
                {%- endif %}
                {%- if failable %}){% endif -%}
            );

            {#- checked #}
            {%- else %}

                {%- if lossy %}
            var tmp = from.Bits / (({{ fb }})1 << {{ f-frac_nbits }});

                    {%- if signed == s %}
            if (tmp < MinRepr ||
                tmp > MaxRepr) {
                return null;
            }
                    {%- elif signed %}
            if (tmp > ({{ tu }})MaxRepr) {
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
                    {%- set shift = frac_nbits - f %}
                    {%- set max = 'MaxRepr / ((' ~ self_bits_type ~ ')1 << ' ~ shift ~ ')' %}
                    {%- set min = 'MinRepr / ((' ~ self_bits_type ~ ')1 << ' ~ shift ~ ')' %}

                    {%- if signed == s %}
            if (from.Bits > ({{ max }}) ||
                from.Bits < ({{ min }})) {
                return null;
            }
                    {%- elif signed %}
            if (from.Bits > ({{ tu }})({{ max }})) {
                return null;
            }
                    {%- else %}
            if (from.Bits < 0) {
                return null;
            } else if (({{ fu }})from.Bits > {{ max }}) {
                return null;
            }
                    {%- endif %}
            return FromBits(({{ self_bits_type }})from.Bits * (({{ self_bits_type }})1 << {{ frac_nbits-f }}));
                {%- endif %}

            {%- endif %}
        }

                {%- endif %}
            {%- endfor %}

        {%- endif %}
    {%- endfor %}
{%- endfor %}

        //
        // Convert to
        //

        // 整数への変換で小数点以下の精度が失われるのは自明なので
        // わざわざ明記することはしない。

{#- 整数型への変換 #}
{%- for bits in [32, 64] %}
    {%- for s in [true, false] %}
        {%- set t = macros::inttype(bits=bits, signed=s) %}

        {#- 自身と相手の符号ありなしが同じか、
            自身が符号なしで相手が符号ありの場合、
            符号部を除いたビット数について、
            自身の整数部のそれよりも相手のそれの方が大きければ
            変換は必ず成功する。 #}
        {%- if signed == s and int_nbits <= bits
            or not signed and s and int_nbits <= bits - 1 %}

        /// <summary>
        /// <para><see cref="{{ t }}" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ t }} To{% if not s %}U{% endif %}Int{{ bits }}() {
            return ({{ t }})(Bits / OneRepr);
        }

        {#- 自身が符号ありで相手が符号なしか、
            相手の符号ビットを除いたビット数が自分の符号ビットを除いた整数部よりも大きい場合
            変換に失敗する場合がある。 #}
        {%- else %}

        /// <summary>
        /// <para><see cref="{{ t }}" /> への変換を行います。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedTo{% if not s %}U{% endif %}Int{{ bits }}"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ t }} StrictTo{% if not s %}U{% endif %}Int{{ bits }}() {
            return checked(({{ t }})(Bits / OneRepr));
        }

        /// <summary>
        /// <para><see cref="{{ t }}" /> への変換を行います。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictTo{% if not s %}U{% endif %}Int{{ bits }}"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ t }}? CheckedTo{% if not s %}U{% endif %}Int{{ bits }}() {
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
        }

        {%- endif %}

    {%- endfor %}
{%- endfor %}

        // 浮動小数点数への変換は必ず成功する。
        // 除算は最適化によって乗算に置き換えられることを期待する。
{# これは改行を挿入するためのコメントです #}

{#- 浮動小数点数型への変換 #}
{%- for bits in [32, 64] %}
    {%- if   bits == 32 %}{% set t='float'  %}
    {%- elif bits == 64 %}{% set t='double' %}{% endif %}

    {#- 相手のビット数が自身以下の場合、精度を失う。 #}
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public {{ t }} {% if
            bits <= int_nbits + frac_nbits
        %}Lossy{% endif %}To{% if
            bits == 32 %}Single{% elif
            bits == 64 %}Double{% endif %}() => ({{ t }})Bits / OneRepr;

{%- endfor %}

        // 固定小数点数への変換

{%- for s in [true, false] %}
    {%- for target in fixed_list %}
        {#- 自身と異なる型の場合のみ定義する #}
        {%- set i = target[0] %}
        {%- set f = target[1] %}
        {%- if s != signed or i != int_nbits or f != frac_nbits %}
            {%- set to = macros::fixed_type(s=s, i=i, f=f) %}

            {#- 相手の方が小数部のビット数が小さい場合、精度を失う #}
            {%- set lossy = frac_nbits > f %}

            {#- 自分が符号あり、相手が符号なしの場合、
                またはお互いの符号ビットを除いた整数部のビット数について、
                自分の方が大きい場合、変換に失敗する場合がある。 #}
            {%- set failable = signed and not s
                or not signed and s and int_nbits > i - 1
                or signed == s and int_nbits > i %}

            {%- for strict in [false, true] %}
                {%- if strict or failable %}

        /// <summary>
        /// <para>Converts to <see cref="{{ to }}" />.</para>
        /// <para><see cref="{{ to }}" /> へ変換します。</para>
        {%- if failable %}
            {%- if strict %}
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="Checked{% if lossy %}Lossy{% endif %}To{{ to }}"/>
            {%- else %}
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="Strict{% if lossy %}Lossy{% endif %}To{{ to }}"/>
            {%- endif %}
        {%- else %}
        /// </summary>
        {%- endif %}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {{ to }}
        {%- if failable %}
            {%- if strict %} Strict
            {%- else %}? Checked
            {%- endif %}
        {%- else %} {% endif %}
        {%- if lossy %}Lossy{% endif %}To{{ to }}() => {{ to }}.
            {%- if failable %}
                {%- if strict %}Strict
                {%- else %}Checked
                {%- endif %}
            {%- endif %}
            {%- if lossy %}Lossy{% endif %}From(this);

                {%- endif %}
            {%- endfor %}

        {%- endif %}
    {%- endfor %}
{%- endfor %}

#pragma warning restore CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning restore IDE0004 // 不要なキャストの削除

#pragma warning restore IDE0079 // 不要な抑制を削除します

    }
} // namespace AgatePris.Intar
