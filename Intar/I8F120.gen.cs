#if NET7_0_OR_GREATER

using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct I8F120 : IEquatable<I8F120>, IFormattable {

        #region Consts

        public const int IntNbits = 8;
        public const int FracNbits = 120;

        internal static readonly Int128 MinRepr = Int128.MinValue;
        internal static readonly Int128 MaxRepr = Int128.MaxValue;
        internal static readonly UInt128 MaxReprUnsigned = (UInt128)MaxRepr;
        internal static readonly Int128 EpsilonRepr = 1;

        internal static readonly Int128 OneRepr = (Int128)1 << FracNbits;

        #endregion

        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public Int128 Bits;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion

        #region Constructor, FromBits

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I8F120(Int128 bits) {
            Bits = bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 FromBits(Int128 bits) => new I8F120(bits);

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

        public static readonly I8F120 Zero;
        public static readonly I8F120 One = new I8F120(OneRepr);
        public static readonly I8F120 MinValue = new I8F120(MinRepr);
        public static readonly I8F120 MaxValue = new I8F120(MaxRepr);
        internal static readonly I8F120 Epsilon = new I8F120(EpsilonRepr);

        #endregion

        #region IAdditionOperatos, ISubtractionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 operator +(I8F120 left, I8F120 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 operator -(I8F120 left, I8F120 right) {
            return FromBits(left.Bits - right.Bits);
        }

        #endregion

        #region IUnaryPlusOperators, IUnaryNegationOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 operator +(I8F120 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 operator -(I8F120 x) => FromBits(-x.Bits);

        #endregion

        #region IEqualityOperators, IComparisonOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(I8F120 left, I8F120 right) => left.Bits == right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(I8F120 left, I8F120 right) => left.Bits != right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I8F120 left, I8F120 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I8F120 left, I8F120 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I8F120 left, I8F120 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I8F120 left, I8F120 right) => left.Bits >= right.Bits;

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is I8F120 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => LossyToDouble().ToString((IFormatProvider)null);

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(I8F120 other) => this == other;

        #endregion

        #region IFormattable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return LossyToDouble().ToString(format, formatProvider);
        }

        #endregion

        #region IComparable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(I8F120 value) {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I8F120 Min(I8F120 other) => FromBits(Int128.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I8F120 Max(I8F120 other) => FromBits(Int128.Max(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I8F120 Clamp(I8F120 min, I8F120 max) {
            return FromBits(Int128.Clamp(Bits, min.Bits, max.Bits));
        }

        #endregion

        #region IsNegative, Abs, UnsignedAbs

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNegative() => Bits < 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I8F120 Abs() => FromBits(Int128.Abs(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U8F120 UnsignedAbs() {
            return U8F120.FromBits(Mathi.UnsignedAbs(Bits));
        }

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal I8F120 Half() => FromBits(Mathi.Half(Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal I8F120 Twice() => FromBits(Mathi.Twice(Bits));

        #region BigMul

        #endregion

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
        /// var a = I8F120.StrictFrom(1);
        /// System.Assert.AreEqual((Int128)1 &lt;&lt; 120, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 StrictFrom(int num) {
            return FromBits(checked((Int128)num * OneRepr));
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
        /// var a = I8F120.UncheckedFrom(1);
        /// System.Assert.AreEqual((Int128)1 &lt;&lt; 120, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 UncheckedFrom(int num) {
            return FromBits(unchecked((Int128)num * OneRepr));
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
        /// var a = I8F120.CheckedFrom(1);
        /// System.Assert.AreEqual((Int128)1 &lt;&lt; 120, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120? CheckedFrom(int num) {

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (num > MaxRepr / OneRepr ||
                num < MinRepr / OneRepr) {
                return null;
            }

            return FromBits((Int128)num * OneRepr);
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
        /// var a = I8F120.StrictFrom(1);
        /// System.Assert.AreEqual((Int128)1 &lt;&lt; 120, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 StrictFrom(uint num) {
            return FromBits(checked((Int128)num * OneRepr));
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
        /// var a = I8F120.UncheckedFrom(1);
        /// System.Assert.AreEqual((Int128)1 &lt;&lt; 120, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 UncheckedFrom(uint num) {
            return FromBits(unchecked((Int128)num * OneRepr));
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
        /// var a = I8F120.CheckedFrom(1);
        /// System.Assert.AreEqual((Int128)1 &lt;&lt; 120, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120? CheckedFrom(uint num) {

            // 自身が符号あり、相手が符号なしであるから、
            // 相手が最小値未満であることはありえない。
            // よって、自身の最大値を符号なしの型に変換して比較する。
            // この際、大きい方の型に暗黙に変換される。
            if (num > (UInt128)(MaxRepr / OneRepr)) {
                return null;
            }

            return FromBits((Int128)num * OneRepr);
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
        /// var a = I8F120.StrictFrom(1);
        /// System.Assert.AreEqual((Int128)1 &lt;&lt; 120, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 StrictFrom(long num) {
            return FromBits(checked((Int128)num * OneRepr));
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
        /// var a = I8F120.UncheckedFrom(1);
        /// System.Assert.AreEqual((Int128)1 &lt;&lt; 120, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 UncheckedFrom(long num) {
            return FromBits(unchecked((Int128)num * OneRepr));
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
        /// var a = I8F120.CheckedFrom(1);
        /// System.Assert.AreEqual((Int128)1 &lt;&lt; 120, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120? CheckedFrom(long num) {

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (num > MaxRepr / OneRepr ||
                num < MinRepr / OneRepr) {
                return null;
            }

            return FromBits((Int128)num * OneRepr);
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
        /// var a = I8F120.StrictFrom(1);
        /// System.Assert.AreEqual((Int128)1 &lt;&lt; 120, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 StrictFrom(ulong num) {
            return FromBits(checked((Int128)num * OneRepr));
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
        /// var a = I8F120.UncheckedFrom(1);
        /// System.Assert.AreEqual((Int128)1 &lt;&lt; 120, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 UncheckedFrom(ulong num) {
            return FromBits(unchecked((Int128)num * OneRepr));
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
        /// var a = I8F120.CheckedFrom(1);
        /// System.Assert.AreEqual((Int128)1 &lt;&lt; 120, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120? CheckedFrom(ulong num) {

            // 自身が符号あり、相手が符号なしであるから、
            // 相手が最小値未満であることはありえない。
            // よって、自身の最大値を符号なしの型に変換して比較する。
            // この際、大きい方の型に暗黙に変換される。
            if (num > (UInt128)(MaxRepr / OneRepr)) {
                return null;
            }

            return FromBits((Int128)num * OneRepr);
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
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I8F120.StrictFrom(1.0f);
        /// System.Assert.AreEqual((Int128)1 &lt;&lt; 120, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 StrictFrom(float num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((Int128)(num * (float)OneRepr)));
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
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I8F120.UncheckedFrom(1.0f);
        /// System.Assert.AreEqual((Int128)1 &lt;&lt; 120, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 UncheckedFrom(float num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(unchecked((Int128)(num * (float)OneRepr)));
        }

        // 自身が 64 ビットの場合､ BitConverter を使用する必要がある。
        // 現時点では未実装。
        // https://learn.microsoft.com/ja-jp/dotnet/api/system.bitconverter

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="double" /> value.</para>
        /// <para> <see cref="double" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom(double)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I8F120.StrictFrom(1.0);
        /// System.Assert.AreEqual((Int128)1 &lt;&lt; 120, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 StrictFrom(double num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((Int128)(num * (double)OneRepr)));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="double" /> value.</para>
        /// <para> <see cref="double" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(double)"/>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I8F120.UncheckedFrom(1.0);
        /// System.Assert.AreEqual((Int128)1 &lt;&lt; 120, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I8F120 UncheckedFrom(double num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(unchecked((Int128)(num * (double)OneRepr)));
        }

        // 自身が 64 ビットの場合､ BitConverter を使用する必要がある。
        // 現時点では未実装。
        // https://learn.microsoft.com/ja-jp/dotnet/api/system.bitconverter

        #endregion

        #region Convert from fixed-point number

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I17F15" /> value.</para>
        /// <para><see cref="I17F15" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom(I17F15)"/>
        /// <seealso cref="CheckedFrom(I17F15)"/>
        public static I8F120 StrictFrom(I17F15 from) {
            return FromBits(checked((Int128)from.Bits * (EpsilonRepr << 105))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I17F15" /> value.</para>
        /// <para><see cref="I17F15" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(I17F15)"/>
        /// <seealso cref="CheckedFrom(I17F15)"/>
        public static I8F120 UncheckedFrom(I17F15 from) {
            return FromBits(unchecked((Int128)from.Bits * (EpsilonRepr << 105))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I17F15" /> value.</para>
        /// <para><see cref="I17F15" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(I17F15)"/>
        /// <seealso cref="UncheckedFrom(I17F15)"/>
        public static I8F120? CheckedFrom(I17F15 from) {
            const int shift = 105;
            var k = EpsilonRepr << shift;
            var max = MaxRepr / k;
            var min = MinRepr / k;
            if (from.Bits > max ||
                from.Bits < min) {
                return null;
            }
            return FromBits((Int128)from.Bits * k);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F30" /> value.</para>
        /// <para><see cref="I2F30" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I8F120 From(I2F30 from) {
            return FromBits(unchecked((Int128)from.Bits * (EpsilonRepr << 90))
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
        /// <seealso cref="UncheckedFrom(I34F30)"/>
        /// <seealso cref="CheckedFrom(I34F30)"/>
        public static I8F120 StrictFrom(I34F30 from) {
            return FromBits(checked((Int128)from.Bits * (EpsilonRepr << 90))
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
        /// <seealso cref="StrictFrom(I34F30)"/>
        /// <seealso cref="CheckedFrom(I34F30)"/>
        public static I8F120 UncheckedFrom(I34F30 from) {
            return FromBits(unchecked((Int128)from.Bits * (EpsilonRepr << 90))
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
        /// <seealso cref="StrictFrom(I34F30)"/>
        /// <seealso cref="UncheckedFrom(I34F30)"/>
        public static I8F120? CheckedFrom(I34F30 from) {
            const int shift = 90;
            var k = EpsilonRepr << shift;
            var max = MaxRepr / k;
            var min = MinRepr / k;
            if (from.Bits > max ||
                from.Bits < min) {
                return null;
            }
            return FromBits((Int128)from.Bits * k);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I33F31" /> value.</para>
        /// <para><see cref="I33F31" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom(I33F31)"/>
        /// <seealso cref="CheckedFrom(I33F31)"/>
        public static I8F120 StrictFrom(I33F31 from) {
            return FromBits(checked((Int128)from.Bits * (EpsilonRepr << 89))
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
        /// <seealso cref="StrictFrom(I33F31)"/>
        /// <seealso cref="CheckedFrom(I33F31)"/>
        public static I8F120 UncheckedFrom(I33F31 from) {
            return FromBits(unchecked((Int128)from.Bits * (EpsilonRepr << 89))
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
        /// <seealso cref="StrictFrom(I33F31)"/>
        /// <seealso cref="UncheckedFrom(I33F31)"/>
        public static I8F120? CheckedFrom(I33F31 from) {
            const int shift = 89;
            var k = EpsilonRepr << shift;
            var max = MaxRepr / k;
            var min = MinRepr / k;
            if (from.Bits > max ||
                from.Bits < min) {
                return null;
            }
            return FromBits((Int128)from.Bits * k);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I4F60" /> value.</para>
        /// <para><see cref="I4F60" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I8F120 From(I4F60 from) {
            return FromBits(unchecked((Int128)from.Bits * (EpsilonRepr << 60))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F62" /> value.</para>
        /// <para><see cref="I2F62" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I8F120 From(I2F62 from) {
            return FromBits(unchecked((Int128)from.Bits * (EpsilonRepr << 58))
            );
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I68F60" /> value.</para>
        /// <para><see cref="I68F60" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom(I68F60)"/>
        /// <seealso cref="CheckedFrom(I68F60)"/>
        public static I8F120 StrictFrom(I68F60 from) {
            return FromBits(checked((Int128)from.Bits * (EpsilonRepr << 60))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I68F60" /> value.</para>
        /// <para><see cref="I68F60" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(I68F60)"/>
        /// <seealso cref="CheckedFrom(I68F60)"/>
        public static I8F120 UncheckedFrom(I68F60 from) {
            return FromBits(unchecked((Int128)from.Bits * (EpsilonRepr << 60))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I68F60" /> value.</para>
        /// <para><see cref="I68F60" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(I68F60)"/>
        /// <seealso cref="UncheckedFrom(I68F60)"/>
        public static I8F120? CheckedFrom(I68F60 from) {
            const int shift = 60;
            var k = EpsilonRepr << shift;
            var max = MaxRepr / k;
            var min = MinRepr / k;
            if (from.Bits > max ||
                from.Bits < min) {
                return null;
            }
            return FromBits((Int128)from.Bits * k);
        }

#endif // NET7_0_OR_GREATER

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
        public static I8F120 StrictFrom(U17F15 from) {
            return FromBits(checked((Int128)from.Bits * (EpsilonRepr << 105))
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
        public static I8F120 UncheckedFrom(U17F15 from) {
            return FromBits(unchecked((Int128)from.Bits * (EpsilonRepr << 105))
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
        public static I8F120? CheckedFrom(U17F15 from) {
            const int shift = 105;
            var k = EpsilonRepr << shift;
            var max = MaxRepr / k;
            if (from.Bits > (UInt128)max) {
                return null;
            }
            return FromBits((Int128)from.Bits * k);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F30" /> value.</para>
        /// <para><see cref="U2F30" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I8F120 From(U2F30 from) {
            return FromBits(unchecked((Int128)from.Bits * (EpsilonRepr << 90))
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
        /// <seealso cref="UncheckedFrom(U34F30)"/>
        /// <seealso cref="CheckedFrom(U34F30)"/>
        public static I8F120 StrictFrom(U34F30 from) {
            return FromBits(checked((Int128)from.Bits * (EpsilonRepr << 90))
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
        /// <seealso cref="StrictFrom(U34F30)"/>
        /// <seealso cref="CheckedFrom(U34F30)"/>
        public static I8F120 UncheckedFrom(U34F30 from) {
            return FromBits(unchecked((Int128)from.Bits * (EpsilonRepr << 90))
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
        /// <seealso cref="StrictFrom(U34F30)"/>
        /// <seealso cref="UncheckedFrom(U34F30)"/>
        public static I8F120? CheckedFrom(U34F30 from) {
            const int shift = 90;
            var k = EpsilonRepr << shift;
            var max = MaxRepr / k;
            if (from.Bits > (UInt128)max) {
                return null;
            }
            return FromBits((Int128)from.Bits * k);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U33F31" /> value.</para>
        /// <para><see cref="U33F31" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom(U33F31)"/>
        /// <seealso cref="CheckedFrom(U33F31)"/>
        public static I8F120 StrictFrom(U33F31 from) {
            return FromBits(checked((Int128)from.Bits * (EpsilonRepr << 89))
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
        /// <seealso cref="StrictFrom(U33F31)"/>
        /// <seealso cref="CheckedFrom(U33F31)"/>
        public static I8F120 UncheckedFrom(U33F31 from) {
            return FromBits(unchecked((Int128)from.Bits * (EpsilonRepr << 89))
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
        /// <seealso cref="StrictFrom(U33F31)"/>
        /// <seealso cref="UncheckedFrom(U33F31)"/>
        public static I8F120? CheckedFrom(U33F31 from) {
            const int shift = 89;
            var k = EpsilonRepr << shift;
            var max = MaxRepr / k;
            if (from.Bits > (UInt128)max) {
                return null;
            }
            return FromBits((Int128)from.Bits * k);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U4F60" /> value.</para>
        /// <para><see cref="U4F60" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I8F120 From(U4F60 from) {
            return FromBits(unchecked((Int128)from.Bits * (EpsilonRepr << 60))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F62" /> value.</para>
        /// <para><see cref="U2F62" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I8F120 From(U2F62 from) {
            return FromBits(unchecked((Int128)from.Bits * (EpsilonRepr << 58))
            );
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U68F60" /> value.</para>
        /// <para><see cref="U68F60" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom(U68F60)"/>
        /// <seealso cref="CheckedFrom(U68F60)"/>
        public static I8F120 StrictFrom(U68F60 from) {
            return FromBits(checked((Int128)from.Bits * (EpsilonRepr << 60))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U68F60" /> value.</para>
        /// <para><see cref="U68F60" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(U68F60)"/>
        /// <seealso cref="CheckedFrom(U68F60)"/>
        public static I8F120 UncheckedFrom(U68F60 from) {
            return FromBits(unchecked((Int128)from.Bits * (EpsilonRepr << 60))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U68F60" /> value.</para>
        /// <para><see cref="U68F60" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(U68F60)"/>
        /// <seealso cref="UncheckedFrom(U68F60)"/>
        public static I8F120? CheckedFrom(U68F60 from) {
            const int shift = 60;
            var k = EpsilonRepr << shift;
            var max = MaxRepr / k;
            if (from.Bits > (UInt128)max) {
                return null;
            }
            return FromBits((Int128)from.Bits * k);
        }

#endif // NET7_0_OR_GREATER

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U8F120" /> value.</para>
        /// <para><see cref="U8F120" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom(U8F120)"/>
        /// <seealso cref="CheckedFrom(U8F120)"/>
        public static I8F120 StrictFrom(U8F120 from) {
            return FromBits(checked((Int128)from.Bits * (EpsilonRepr << 0))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U8F120" /> value.</para>
        /// <para><see cref="U8F120" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(U8F120)"/>
        /// <seealso cref="CheckedFrom(U8F120)"/>
        public static I8F120 UncheckedFrom(U8F120 from) {
            return FromBits(unchecked((Int128)from.Bits * (EpsilonRepr << 0))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U8F120" /> value.</para>
        /// <para><see cref="U8F120" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(U8F120)"/>
        /// <seealso cref="UncheckedFrom(U8F120)"/>
        public static I8F120? CheckedFrom(U8F120 from) {
            const int shift = 0;
            var k = EpsilonRepr << shift;
            var max = MaxRepr / k;
            if (from.Bits > (UInt128)max) {
                return null;
            }
            return FromBits((Int128)from.Bits * k);
        }

#endif // NET7_0_OR_GREATER

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
            } else if ((UInt128)tmp > uint.MaxValue) {
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
            } else if ((UInt128)tmp > ulong.MaxValue) {
                return null;
            }

            return (ulong)tmp;
        }

        #endregion

        #region Convert to floating-point number

        // 浮動小数点数への変換は必ず成功する。
        // 除算は最適化によって乗算に置き換えられることを期待する。

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public float LossyToSingle() => (float)Bits / (float)OneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public double LossyToDouble() => (double)Bits / (double)OneRepr;

        #endregion

#pragma warning restore CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

    }
} // namespace Intar

#endif // NET7_0_OR_GREATER