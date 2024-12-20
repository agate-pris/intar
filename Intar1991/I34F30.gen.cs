using System;
using System.Runtime.CompilerServices;

namespace Intar1991 {
    [Serializable]
    public struct I34F30 : IEquatable<I34F30>, IFormattable {

        #region Consts

        public const int IntNbits = 34;
        public const int FracNbits = 30;

        internal const long MinRepr = long.MinValue;
        internal const long MaxRepr = long.MaxValue;
        internal const ulong MaxReprUnsigned = MaxRepr;
        internal const long EpsilonRepr = 1;

        internal const long OneRepr = 1L << FracNbits;

        #endregion

        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public long Bits;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion

        #region Constructor, FromBits

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I34F30(long bits) {
            Bits = bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 FromBits(long bits) => new I34F30(bits);

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

        public static readonly I34F30 Zero;
        public static readonly I34F30 One = new I34F30(OneRepr);
        public static readonly I34F30 MinValue = new I34F30(MinRepr);
        public static readonly I34F30 MaxValue = new I34F30(MaxRepr);
        internal static readonly I34F30 Epsilon = new I34F30(EpsilonRepr);

        #endregion

        #region WideBits

#if NET7_0_OR_GREATER

        internal Int128 WideBits {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Bits;
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region IAdditionOperatos, ISubtractionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator +(I34F30 left, I34F30 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator -(I34F30 left, I34F30 right) {
            return FromBits(left.Bits - right.Bits);
        }

        #endregion

        #region IMultiplicationOperators, IDivisionOperators

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator *(I34F30 left, I34F30 right) {
            return FromBits((long)(left.WideBits * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator /(I34F30 left, I34F30 right) {
            return FromBits((long)(left.WideBits * OneRepr / right.Bits));
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region IUnaryPlusOperators, IUnaryNegationOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator +(I34F30 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator -(I34F30 x) => FromBits(-x.Bits);

        #endregion

        #region IEqualityOperators, IComparisonOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(I34F30 left, I34F30 right) => left.Bits == right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(I34F30 left, I34F30 right) => left.Bits != right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I34F30 left, I34F30 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I34F30 left, I34F30 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I34F30 left, I34F30 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I34F30 left, I34F30 right) => left.Bits >= right.Bits;

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is I34F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => LossyToDouble().ToString((IFormatProvider)null);

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(I34F30 other) => this == other;

        #endregion

        #region IFormattable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return LossyToDouble().ToString(format, formatProvider);
        }

        #endregion

        #region IComparable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(I34F30 value) {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 Min(I34F30 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 Max(I34F30 other) => FromBits(Math.Max(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 Clamp(I34F30 min, I34F30 max) {
#if NET5_0_OR_GREATER
            return FromBits(Math.Clamp(Bits, min.Bits, max.Bits));
#else
            return FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));
#endif
        }

        #endregion

        #region IsNegative, Abs, UnsignedAbs

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNegative() => Bits < 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 Abs() => FromBits(Math.Abs(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 UnsignedAbs() {
            return U34F30.FromBits(Mathi.UnsignedAbs(Bits));
        }

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal I34F30 Half() => FromBits(Mathi.Half(Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal I34F30 Twice() => FromBits(Mathi.Twice(Bits));

        #region BigMul

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I68F60 BigMul(I34F30 other) {
            return I68F60.FromBits(WideBits * other.WideBits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I68F60 BigMul(U34F30 other) {
            return I68F60.FromBits((Int128)Bits * (Int128)other.Bits);
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region Atan2

#if NET7_0_OR_GREATER

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0002 // メンバー アクセスを単純化します

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 Atan2P2(I34F30 other) {
            return I2F62.Atan2P2(Bits, other.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 Atan2P3(I34F30 other) {
            return I2F62.Atan2P3(Bits, other.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 Atan2P9(I34F30 other) {
            return I2F62.Atan2P9(Bits, other.Bits);
        }

#pragma warning restore IDE0002 // メンバー アクセスを単純化します
#pragma warning restore IDE0079 // 不要な抑制を削除します

#endif // NET7_0_OR_GREATER

        #endregion

        // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning disable IDE0004 // 不要なキャストの削除

        #region Convert from integer

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="int" /> value.</para>
        /// <para><see cref="int" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I34F30.From(1);
        /// System.Assert.AreEqual(1L &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 From(int num) {
            // 自身と相手の符号が同じ場合、整数部が相手以上であるから乗算は必ず成功する。
            // 自身が符号あり、相手が符号なしの場合、
            // 自身の符号部分を除いた整数部について同様である。
            return FromBits(unchecked(num * OneRepr));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="uint" /> value.</para>
        /// <para><see cref="uint" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = I34F30.From(1);
        /// System.Assert.AreEqual(1L &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 From(uint num) {
            // 自身と相手の符号が同じ場合、整数部が相手以上であるから乗算は必ず成功する。
            // 自身が符号あり、相手が符号なしの場合、
            // 自身の符号部分を除いた整数部について同様である。
            return FromBits(unchecked(num * OneRepr));
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
        /// var a = I34F30.StrictFrom(1);
        /// System.Assert.AreEqual(1L &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 StrictFrom(long num) {
            return FromBits(checked((long)num * OneRepr));
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
        /// var a = I34F30.UncheckedFrom(1);
        /// System.Assert.AreEqual(1L &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 UncheckedFrom(long num) {
            return FromBits(unchecked((long)num * OneRepr));
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
        /// var a = I34F30.CheckedFrom(1);
        /// System.Assert.AreEqual(1L &lt;&lt; 30, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30? CheckedFrom(long num) {

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (num > MaxRepr / OneRepr ||
                num < MinRepr / OneRepr) {
                return null;
            }

            return FromBits((long)num * OneRepr);
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
        /// var a = I34F30.StrictFrom(1);
        /// System.Assert.AreEqual(1L &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 StrictFrom(ulong num) {
            return FromBits(checked((long)num * OneRepr));
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
        /// var a = I34F30.UncheckedFrom(1);
        /// System.Assert.AreEqual(1L &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 UncheckedFrom(ulong num) {
            return FromBits(unchecked((long)num * OneRepr));
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
        /// var a = I34F30.CheckedFrom(1);
        /// System.Assert.AreEqual(1L &lt;&lt; 30, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30? CheckedFrom(ulong num) {

            // 自身が符号あり、相手が符号なしであるから、
            // 相手が最小値未満であることはありえない。
            // よって、自身の最大値を符号なしの型に変換して比較する。
            // この際、大きい方の型に暗黙に変換される。
            if (num > (ulong)(MaxRepr / OneRepr)) {
                return null;
            }

            return FromBits((long)num * OneRepr);
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
        /// var a = I34F30.StrictFrom(1.0f);
        /// System.Assert.AreEqual(1L &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 StrictFrom(float num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((long)(num * (float)OneRepr)));
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
        /// var a = I34F30.UncheckedFrom(1.0f);
        /// System.Assert.AreEqual(1L &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 UncheckedFrom(float num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(unchecked((long)(num * (float)OneRepr)));
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
        /// var a = I34F30.StrictFrom(1.0);
        /// System.Assert.AreEqual(1L &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 StrictFrom(double num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((long)(num * (double)OneRepr)));
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
        /// var a = I34F30.UncheckedFrom(1.0);
        /// System.Assert.AreEqual(1L &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 UncheckedFrom(double num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(unchecked((long)(num * (double)OneRepr)));
        }

        // 自身が 64 ビットの場合､ BitConverter を使用する必要がある。
        // 現時点では未実装。
        // https://learn.microsoft.com/ja-jp/dotnet/api/system.bitconverter

        #endregion

        #region Convert from fixed-point number

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I17F15" /> value.</para>
        /// <para><see cref="I17F15" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I34F30 From(I17F15 from) {
            return FromBits(unchecked((long)from.Bits * (EpsilonRepr << 15))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F30" /> value.</para>
        /// <para><see cref="I2F30" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I34F30 From(I2F30 from) {
            return FromBits(unchecked((long)from.Bits * (EpsilonRepr << 0))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I33F31" /> value.</para>
        /// <para><see cref="I33F31" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I34F30 LossyFrom(I33F31 from) {
            return FromBits(unchecked((long)(from.Bits / (I33F31.EpsilonRepr << 1)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I4F60" /> value.</para>
        /// <para><see cref="I4F60" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I34F30 LossyFrom(I4F60 from) {
            return FromBits(unchecked((long)(from.Bits / (I4F60.EpsilonRepr << 30)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F62" /> value.</para>
        /// <para><see cref="I2F62" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I34F30 LossyFrom(I2F62 from) {
            return FromBits(unchecked((long)(from.Bits / (I2F62.EpsilonRepr << 32)))
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
        /// <seealso cref="UncheckedLossyFrom(I68F60)"/>
        /// <seealso cref="CheckedLossyFrom(I68F60)"/>
        public static I34F30 StrictLossyFrom(I68F60 from) {
            return FromBits(checked((long)(from.Bits / (I68F60.EpsilonRepr << 30)))
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
        /// <seealso cref="StrictLossyFrom(I68F60)"/>
        /// <seealso cref="CheckedLossyFrom(I68F60)"/>
        public static I34F30 UncheckedLossyFrom(I68F60 from) {
            return FromBits(unchecked((long)(from.Bits / (I68F60.EpsilonRepr << 30)))
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
        /// <seealso cref="StrictLossyFrom(I68F60)"/>
        /// <seealso cref="UncheckedLossyFrom(I68F60)"/>
        public static I34F30? CheckedLossyFrom(I68F60 from) {
            var tmp = from.Bits / (I68F60.EpsilonRepr << 30);
            if (tmp < MinRepr ||
                tmp > MaxRepr) {
                return null;
            }
            return FromBits((long)tmp);
        }

#endif // NET7_0_OR_GREATER

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I8F120" /> value.</para>
        /// <para><see cref="I8F120" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I34F30 LossyFrom(I8F120 from) {
            return FromBits(unchecked((long)(from.Bits / (I8F120.EpsilonRepr << 90)))
            );
        }

#endif // NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U17F15" /> value.</para>
        /// <para><see cref="U17F15" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I34F30 From(U17F15 from) {
            return FromBits(unchecked((long)from.Bits * (EpsilonRepr << 15))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F30" /> value.</para>
        /// <para><see cref="U2F30" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I34F30 From(U2F30 from) {
            return FromBits(unchecked((long)from.Bits * (EpsilonRepr << 0))
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
        public static I34F30 StrictFrom(U34F30 from) {
            return FromBits(checked((long)from.Bits * (EpsilonRepr << 0))
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
        public static I34F30 UncheckedFrom(U34F30 from) {
            return FromBits(unchecked((long)from.Bits * (EpsilonRepr << 0))
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
        public static I34F30? CheckedFrom(U34F30 from) {
            const int shift = 0;
            const long k = EpsilonRepr << shift;
            const long max = MaxRepr / k;
            if (from.Bits > (ulong)max) {
                return null;
            }
            return FromBits((long)from.Bits * k);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U33F31" /> value.</para>
        /// <para><see cref="U33F31" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I34F30 LossyFrom(U33F31 from) {
            return FromBits(unchecked((long)(from.Bits / (U33F31.EpsilonRepr << 1)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U4F60" /> value.</para>
        /// <para><see cref="U4F60" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I34F30 LossyFrom(U4F60 from) {
            return FromBits(unchecked((long)(from.Bits / (U4F60.EpsilonRepr << 30)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F62" /> value.</para>
        /// <para><see cref="U2F62" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I34F30 LossyFrom(U2F62 from) {
            return FromBits(unchecked((long)(from.Bits / (U2F62.EpsilonRepr << 32)))
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
        /// <seealso cref="UncheckedLossyFrom(U68F60)"/>
        /// <seealso cref="CheckedLossyFrom(U68F60)"/>
        public static I34F30 StrictLossyFrom(U68F60 from) {
            return FromBits(checked((long)(from.Bits / (U68F60.EpsilonRepr << 30)))
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
        /// <seealso cref="StrictLossyFrom(U68F60)"/>
        /// <seealso cref="CheckedLossyFrom(U68F60)"/>
        public static I34F30 UncheckedLossyFrom(U68F60 from) {
            return FromBits(unchecked((long)(from.Bits / (U68F60.EpsilonRepr << 30)))
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
        /// <seealso cref="StrictLossyFrom(U68F60)"/>
        /// <seealso cref="UncheckedLossyFrom(U68F60)"/>
        public static I34F30? CheckedLossyFrom(U68F60 from) {
            var tmp = from.Bits / (U68F60.EpsilonRepr << 30);
            if (tmp > MaxReprUnsigned) {
                return null;
            }
            return FromBits((long)tmp);
        }

#endif // NET7_0_OR_GREATER

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U8F120" /> value.</para>
        /// <para><see cref="U8F120" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I34F30 LossyFrom(U8F120 from) {
            return FromBits(unchecked((long)(from.Bits / (U8F120.EpsilonRepr << 90)))
            );
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region Convert to integer

        // 整数への変換で小数点以下の精度が失われるのは自明なので
        // わざわざ明記することはしない。

        /// <summary>
        /// <para><see cref="int" /> への変換を行います。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedToInt32"/>
        /// <seealso cref="CheckedToInt32"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int StrictToInt32() {
            return checked((int)(Bits / OneRepr));
        }

        /// <summary>
        /// <para><see cref="int" /> への変換を行います。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToInt32"/>
        /// <seealso cref="CheckedToInt32"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int UncheckedToInt32() {
            return unchecked((int)(Bits / OneRepr));
        }

        /// <summary>
        /// <para><see cref="int" /> への変換を行います。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToInt32"/>
        /// <seealso cref="UncheckedToInt32"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int? CheckedToInt32() {
            var tmp = Bits / OneRepr;

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (tmp < int.MinValue ||
                tmp > int.MaxValue) {
                return null;
            }

            return (int)tmp;
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
            } else if ((ulong)tmp > uint.MaxValue) {
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
            } else if ((ulong)tmp > ulong.MaxValue) {
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
} // namespace Intar1991
