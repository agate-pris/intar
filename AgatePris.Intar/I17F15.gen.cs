using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct I17F15 : IEquatable<I17F15>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 17;
        public const int FracNbits = 15;

        internal const int MinRepr = int.MinValue;
        internal const int MaxRepr = int.MaxValue;
        internal const uint MaxReprUnsigned = MaxRepr;
        internal const int EpsilonRepr = 1;

        internal const int OneRepr = 1 << FracNbits;

        // Fields
        // ------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public int Bits;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I17F15(int bits) {
            Bits = bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 FromBits(int bits) => new I17F15(bits);

        //
        // Static readonly fields
        //

        // > 14.5.6.2 Static field initialization
        // >
        // > ... If a static constructor (S.14.12) exists in the class,
        // > execution of the static field initializers occurs immediately prior to executing that static constructor.
        // > Otherwise, the static field initializers are executed at an implementation-dependent time prior to the first
        // > use of a static field of that class.
        //
        // -- ECMA-334 6th edition June 2022

        public static readonly I17F15 Zero;
        public static readonly I17F15 One = new I17F15(OneRepr);
        public static readonly I17F15 MinValue = new I17F15(MinRepr);
        public static readonly I17F15 MaxValue = new I17F15(MaxRepr);
        internal static readonly I17F15 Epsilon = new I17F15(EpsilonRepr);

        //
        // Properties
        //

        internal long WideBits {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Bits;
        }

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 operator +(I17F15 left, I17F15 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 operator -(I17F15 left, I17F15 right) {
            return FromBits(left.Bits - right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 operator *(I17F15 left, I17F15 right) {
            return FromBits((int)(left.WideBits * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 operator /(I17F15 left, I17F15 right) {
            return FromBits((int)(left.WideBits * OneRepr / right.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 operator +(I17F15 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 operator -(I17F15 x) => FromBits(-x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(I17F15 left, I17F15 right) => left.Bits == right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(I17F15 left, I17F15 right) => left.Bits != right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I17F15 left, I17F15 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I17F15 left, I17F15 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I17F15 left, I17F15 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I17F15 left, I17F15 right) => left.Bits >= right.Bits;

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is I17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ToDouble().ToString((IFormatProvider)null);

        // IEquatable<I17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(I17F15 other) => this == other;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return ToDouble().ToString(format, formatProvider);
        }

        //
        // IComparable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(I17F15 value) {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 Min(I17F15 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 Max(I17F15 other) => FromBits(Math.Max(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 Abs() => FromBits(Math.Abs(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15 Clamp(I17F15 min, I17F15 max) {
#if NET5_0_OR_GREATER
            return FromBits(Math.Clamp(Bits, min.Bits, max.Bits));
#else
            return FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal I17F15 Half() => FromBits(Mathi.Half(Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal I17F15 Twice() => FromBits(Mathi.Twice(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 UnsignedAbs() {
            return U17F15.FromBits(Mathi.UnsignedAbs(Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 BigMul(I17F15 other) {
            return I34F30.FromBits(WideBits * other.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 BigMul(U17F15 other) {
            return I34F30.FromBits(Bits * other.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 AcosP3() => U2F30.FromBits(Mathi.AcosP3(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 AsinP3() => I2F30.FromBits(Mathi.AsinP3(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 AtanP2() => I2F30.FromBits(Mathi.AtanP2(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 AtanP3() => I2F30.FromBits(Mathi.AtanP3(Bits));

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0002 // メンバー アクセスを単純化します

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 Atan2P2(I17F15 other) {
            return I2F30.FromBits(Mathi.Atan2P2(Bits, other.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 Atan2P3(I17F15 other) {
            return I2F30.FromBits(Mathi.Atan2P3(Bits, other.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 Atan2P9(I17F15 other) {
            return I2F62.FromBits(Mathi.Atan2P9(Bits, other.Bits));
        }

#pragma warning restore IDE0002 // メンバー アクセスを単純化します
#pragma warning restore IDE0079 // 不要な抑制を削除します

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 SinP4() => I2F30.FromBits(Mathi.SinP4(Bits));

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 SinP5() => I2F30.FromBits(Mathi.SinP5(Bits));

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 CosP4() => I2F30.FromBits(Mathi.CosP4(Bits));

        /// <summary>
        /// 5 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 CosP5() => I2F30.FromBits(Mathi.CosP5(Bits));

        //
        // Convert from
        //

        // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079 // 不要な抑制を削除します

#pragma warning disable CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning disable IDE0004 // 不要なキャストの削除

        #region Convert from integer

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="int" /> value.</para>
        /// <para><see cref="int" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom(int)"/>
        /// <seealso cref="CheckedFrom(int)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 StrictFrom(int num) {
            return FromBits(checked((int)num * OneRepr));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="int" /> value.</para>
        /// <para><see cref="int" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(int)"/>
        /// <seealso cref="CheckedFrom(int)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.UncheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 UncheckedFrom(int num) {
            return FromBits(unchecked((int)num * OneRepr));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="int" /> value.</para>
        /// <para><see cref="int" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(int)"/>
        /// <seealso cref="UncheckedFrom(int)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15? CheckedFrom(int num) {

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (num > MaxRepr / OneRepr ||
                num < MinRepr / OneRepr) {
                return null;
            }

            return FromBits((int)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="uint" /> value.</para>
        /// <para><see cref="uint" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom(uint)"/>
        /// <seealso cref="CheckedFrom(uint)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 StrictFrom(uint num) {
            return FromBits(checked((int)num * OneRepr));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="uint" /> value.</para>
        /// <para><see cref="uint" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(uint)"/>
        /// <seealso cref="CheckedFrom(uint)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.UncheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 UncheckedFrom(uint num) {
            return FromBits(unchecked((int)num * OneRepr));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="uint" /> value.</para>
        /// <para><see cref="uint" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(uint)"/>
        /// <seealso cref="UncheckedFrom(uint)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15? CheckedFrom(uint num) {

            // 自身が符号あり、相手が符号なしであるから、
            // 相手が最小値未満であることはありえない。
            // よって、自身の最大値を符号なしの型に変換して比較する。
            // この際、大きい方の型に暗黙に変換される。
            if (num > (uint)(MaxRepr / OneRepr)) {
                return null;
            }

            return FromBits((int)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="long" /> value.</para>
        /// <para><see cref="long" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom(long)"/>
        /// <seealso cref="CheckedFrom(long)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 StrictFrom(long num) {
            return FromBits(checked((int)num * OneRepr));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="long" /> value.</para>
        /// <para><see cref="long" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(long)"/>
        /// <seealso cref="CheckedFrom(long)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.UncheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 UncheckedFrom(long num) {
            return FromBits(unchecked((int)num * OneRepr));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="long" /> value.</para>
        /// <para><see cref="long" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(long)"/>
        /// <seealso cref="UncheckedFrom(long)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15? CheckedFrom(long num) {

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (num > MaxRepr / OneRepr ||
                num < MinRepr / OneRepr) {
                return null;
            }

            return FromBits((int)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="ulong" /> value.</para>
        /// <para><see cref="ulong" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom(ulong)"/>
        /// <seealso cref="CheckedFrom(ulong)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 StrictFrom(ulong num) {
            return FromBits(checked((int)num * OneRepr));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="ulong" /> value.</para>
        /// <para><see cref="ulong" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(ulong)"/>
        /// <seealso cref="CheckedFrom(ulong)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.UncheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 UncheckedFrom(ulong num) {
            return FromBits(unchecked((int)num * OneRepr));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="ulong" /> value.</para>
        /// <para><see cref="ulong" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(ulong)"/>
        /// <seealso cref="UncheckedFrom(ulong)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15? CheckedFrom(ulong num) {

            // 自身が符号あり、相手が符号なしであるから、
            // 相手が最小値未満であることはありえない。
            // よって、自身の最大値を符号なしの型に変換して比較する。
            // この際、大きい方の型に暗黙に変換される。
            if (num > (uint)(MaxRepr / OneRepr)) {
                return null;
            }

            return FromBits((int)num * OneRepr);
        }

        #endregion

        #region Convert from floating-point number

        // decimal からの型変換は基数 (Radix) が 2 のべき乗でないため実装しない。

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="float" /> value.</para>
        /// <para> <see cref="float" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom(float)"/>
        /// <seealso cref="CheckedFrom(float)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.StrictFrom(1.0f);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 StrictFrom(float num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((int)(num * OneRepr)));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="float" /> value.</para>
        /// <para> <see cref="float" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(float)"/>
        /// <seealso cref="CheckedFrom(float)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.UncheckedFrom(1.0f);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 UncheckedFrom(float num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(unchecked((int)(num * OneRepr)));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="float" /> value.</para>
        /// <para> <see cref="float" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(float)"/>
        /// <seealso cref="UncheckedFrom(float)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.CheckedFrom(1.0f);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15? CheckedFrom(float num) {
            // より大きい型に変換して計算。
            return CheckedLossyFrom(num);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="double" /> value.</para>
        /// <para> <see cref="double" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedLossyFrom(double)"/>
        /// <seealso cref="CheckedLossyFrom(double)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.StrictLossyFrom(1.0);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 StrictLossyFrom(double num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((int)(num * OneRepr)));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="double" /> value.</para>
        /// <para> <see cref="double" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(double)"/>
        /// <seealso cref="CheckedLossyFrom(double)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.UncheckedLossyFrom(1.0);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 UncheckedLossyFrom(double num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(unchecked((int)(num * OneRepr)));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="double" /> value.</para>
        /// <para> <see cref="double" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(double)"/>
        /// <seealso cref="UncheckedLossyFrom(double)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I17F15.CheckedLossyFrom(1.0);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15? CheckedLossyFrom(double num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            // また、整数の基数は 2 であるから、
            // 自身のビット数よりも相手の仮数部の方が大きい限り、
            // 最大値に 1 足した数と最小値から 1 引いた数は厳密に表現可能である。
            num *= OneRepr;
            if (double.IsNaN(num) ||
                double.IsInfinity(num) ||
                num >= int.MaxValue + 1.0 ||
                num <= int.MinValue - 1.0) {
                return null;
            }
            return FromBits((int)num);
        }

        #endregion

        #region Convert from fixed-point number

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F30" /> value.</para>
        /// <para><see cref="I2F30" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I17F15 LossyFrom(I2F30 from) {
            return FromBits(unchecked((int)(from.Bits / (I2F30.EpsilonRepr << 15)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I34F30" /> value.</para>
        /// <para><see cref="I34F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedLossyFrom(I34F30)"/>
        /// <seealso cref="CheckedLossyFrom(I34F30)"/>
        public static I17F15 StrictLossyFrom(I34F30 from) {
            return FromBits(checked((int)(from.Bits / (I34F30.EpsilonRepr << 15)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I34F30" /> value.</para>
        /// <para><see cref="I34F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(I34F30)"/>
        /// <seealso cref="CheckedLossyFrom(I34F30)"/>
        public static I17F15 UncheckedLossyFrom(I34F30 from) {
            return FromBits(unchecked((int)(from.Bits / (I34F30.EpsilonRepr << 15)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I34F30" /> value.</para>
        /// <para><see cref="I34F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(I34F30)"/>
        /// <seealso cref="UncheckedLossyFrom(I34F30)"/>
        public static I17F15? CheckedLossyFrom(I34F30 from) {
            var tmp = from.Bits / (I34F30.EpsilonRepr << 15);
            if (tmp < MinRepr ||
                tmp > MaxRepr) {
                return null;
            }
            return FromBits((int)tmp);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I33F31" /> value.</para>
        /// <para><see cref="I33F31" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedLossyFrom(I33F31)"/>
        /// <seealso cref="CheckedLossyFrom(I33F31)"/>
        public static I17F15 StrictLossyFrom(I33F31 from) {
            return FromBits(checked((int)(from.Bits / (I33F31.EpsilonRepr << 16)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I33F31" /> value.</para>
        /// <para><see cref="I33F31" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(I33F31)"/>
        /// <seealso cref="CheckedLossyFrom(I33F31)"/>
        public static I17F15 UncheckedLossyFrom(I33F31 from) {
            return FromBits(unchecked((int)(from.Bits / (I33F31.EpsilonRepr << 16)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I33F31" /> value.</para>
        /// <para><see cref="I33F31" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(I33F31)"/>
        /// <seealso cref="UncheckedLossyFrom(I33F31)"/>
        public static I17F15? CheckedLossyFrom(I33F31 from) {
            var tmp = from.Bits / (I33F31.EpsilonRepr << 16);
            if (tmp < MinRepr ||
                tmp > MaxRepr) {
                return null;
            }
            return FromBits((int)tmp);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I4F60" /> value.</para>
        /// <para><see cref="I4F60" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I17F15 LossyFrom(I4F60 from) {
            return FromBits(unchecked((int)(from.Bits / (I4F60.EpsilonRepr << 45)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F62" /> value.</para>
        /// <para><see cref="I2F62" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I17F15 LossyFrom(I2F62 from) {
            return FromBits(unchecked((int)(from.Bits / (I2F62.EpsilonRepr << 47)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U17F15" /> value.</para>
        /// <para><see cref="U17F15" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom(U17F15)"/>
        /// <seealso cref="CheckedFrom(U17F15)"/>
        public static I17F15 StrictFrom(U17F15 from) {
            return FromBits(checked((int)from.Bits * (EpsilonRepr << 0))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U17F15" /> value.</para>
        /// <para><see cref="U17F15" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(U17F15)"/>
        /// <seealso cref="CheckedFrom(U17F15)"/>
        public static I17F15 UncheckedFrom(U17F15 from) {
            return FromBits(unchecked((int)from.Bits * (EpsilonRepr << 0))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U17F15" /> value.</para>
        /// <para><see cref="U17F15" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(U17F15)"/>
        /// <seealso cref="UncheckedFrom(U17F15)"/>
        public static I17F15? CheckedFrom(U17F15 from) {
            const int shift = 0;
            const int k = EpsilonRepr << shift;
            const int max = MaxRepr / k;
            if (from.Bits > (uint)max) {
                return null;
            }
            return FromBits((int)from.Bits * k);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F30" /> value.</para>
        /// <para><see cref="U2F30" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I17F15 LossyFrom(U2F30 from) {
            return FromBits(unchecked((int)(from.Bits / (U2F30.EpsilonRepr << 15)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U34F30" /> value.</para>
        /// <para><see cref="U34F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedLossyFrom(U34F30)"/>
        /// <seealso cref="CheckedLossyFrom(U34F30)"/>
        public static I17F15 StrictLossyFrom(U34F30 from) {
            return FromBits(checked((int)(from.Bits / (U34F30.EpsilonRepr << 15)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U34F30" /> value.</para>
        /// <para><see cref="U34F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(U34F30)"/>
        /// <seealso cref="CheckedLossyFrom(U34F30)"/>
        public static I17F15 UncheckedLossyFrom(U34F30 from) {
            return FromBits(unchecked((int)(from.Bits / (U34F30.EpsilonRepr << 15)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U34F30" /> value.</para>
        /// <para><see cref="U34F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(U34F30)"/>
        /// <seealso cref="UncheckedLossyFrom(U34F30)"/>
        public static I17F15? CheckedLossyFrom(U34F30 from) {
            var tmp = from.Bits / (U34F30.EpsilonRepr << 15);
            if (tmp > MaxReprUnsigned) {
                return null;
            }
            return FromBits((int)tmp);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U33F31" /> value.</para>
        /// <para><see cref="U33F31" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedLossyFrom(U33F31)"/>
        /// <seealso cref="CheckedLossyFrom(U33F31)"/>
        public static I17F15 StrictLossyFrom(U33F31 from) {
            return FromBits(checked((int)(from.Bits / (U33F31.EpsilonRepr << 16)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U33F31" /> value.</para>
        /// <para><see cref="U33F31" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(U33F31)"/>
        /// <seealso cref="CheckedLossyFrom(U33F31)"/>
        public static I17F15 UncheckedLossyFrom(U33F31 from) {
            return FromBits(unchecked((int)(from.Bits / (U33F31.EpsilonRepr << 16)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U33F31" /> value.</para>
        /// <para><see cref="U33F31" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(U33F31)"/>
        /// <seealso cref="UncheckedLossyFrom(U33F31)"/>
        public static I17F15? CheckedLossyFrom(U33F31 from) {
            var tmp = from.Bits / (U33F31.EpsilonRepr << 16);
            if (tmp > MaxReprUnsigned) {
                return null;
            }
            return FromBits((int)tmp);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U4F60" /> value.</para>
        /// <para><see cref="U4F60" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I17F15 LossyFrom(U4F60 from) {
            return FromBits(unchecked((int)(from.Bits / (U4F60.EpsilonRepr << 45)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F62" /> value.</para>
        /// <para><see cref="U2F62" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I17F15 LossyFrom(U2F62 from) {
            return FromBits(unchecked((int)(from.Bits / (U2F62.EpsilonRepr << 47)))
            );
        }

        #endregion

        #region Convert to integer

        // 整数への変換で小数点以下の精度が失われるのは自明なので
        // わざわざ明記することはしない。

        /// <summary>
        /// <para><see cref="int" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int ToInt32() {
            return unchecked((int)(Bits / OneRepr));
        }

        /// <summary>
        /// <para><see cref="uint" /> への変換を行います。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedToUInt32"/>
        /// <seealso cref="CheckedToUInt32"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint StrictToUInt32() {
            return checked((uint)(Bits / OneRepr));
        }

        /// <summary>
        /// <para><see cref="uint" /> への変換を行います。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToUInt32"/>
        /// <seealso cref="CheckedToUInt32"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint UncheckedToUInt32() {
            return unchecked((uint)(Bits / OneRepr));
        }

        /// <summary>
        /// <para><see cref="uint" /> への変換を行います。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToUInt32"/>
        /// <seealso cref="UncheckedToUInt32"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint? CheckedToUInt32() {
            var tmp = Bits / OneRepr;

            // 自身が符号ありで、相手が符号なしの場合、
            // 自身が 0 未満、または
            // 自身が相手の最大値よりも大きければ null
            if (tmp < 0) {
                return null;
            } else if ((uint)tmp > uint.MaxValue) {
                return null;
            }

            return (uint)tmp;
        }

        /// <summary>
        /// <para><see cref="long" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long ToInt64() {
            return unchecked((long)(Bits / OneRepr));
        }

        /// <summary>
        /// <para><see cref="ulong" /> への変換を行います。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedToUInt64"/>
        /// <seealso cref="CheckedToUInt64"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong StrictToUInt64() {
            return checked((ulong)(Bits / OneRepr));
        }

        /// <summary>
        /// <para><see cref="ulong" /> への変換を行います。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToUInt64"/>
        /// <seealso cref="CheckedToUInt64"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong UncheckedToUInt64() {
            return unchecked((ulong)(Bits / OneRepr));
        }

        /// <summary>
        /// <para><see cref="ulong" /> への変換を行います。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToUInt64"/>
        /// <seealso cref="UncheckedToUInt64"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong? CheckedToUInt64() {
            var tmp = Bits / OneRepr;

            // 自身が符号ありで、相手が符号なしの場合、
            // 自身が 0 未満、または
            // 自身が相手の最大値よりも大きければ null
            if (tmp < 0) {
                return null;
            } else if ((uint)tmp > ulong.MaxValue) {
                return null;
            }

            return (ulong)tmp;
        }

        #endregion

        #region Convert to floating-point number

        // 浮動小数点数への変換は必ず成功する。
        // 除算は最適化によって乗算に置き換えられることを期待する。

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public float LossyToSingle() => (float)Bits / OneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public double ToDouble() => (double)Bits / OneRepr;

        #endregion

#pragma warning restore CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning restore IDE0004 // 不要なキャストの削除

#pragma warning restore IDE0079 // 不要な抑制を削除します

    }
} // namespace AgatePris.Intar
