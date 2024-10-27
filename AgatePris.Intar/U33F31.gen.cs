using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct U33F31 : IEquatable<U33F31>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 33;
        public const int FracNbits = 31;

        internal const ulong MinRepr = ulong.MinValue;
        internal const ulong MaxRepr = ulong.MaxValue;
        internal const ulong EpsilonRepr = 1;

        const ulong OneRepr = 1UL << FracNbits;

        // Fields
        // ------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public ulong Bits;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        U33F31(ulong bits) {
            Bits = bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U33F31 FromBits(ulong bits) => new U33F31(bits);

        // Static Properties
        // -----------------

        public static U33F31 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new U33F31(0);
        }
        public static U33F31 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new U33F31(OneRepr);
        }
        public static U33F31 MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(MinRepr);
        }
        public static U33F31 MaxValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(MaxRepr);
        }
        internal static U33F31 Epsilon {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(EpsilonRepr);
        }

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U33F31 operator +(U33F31 left, U33F31 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U33F31 operator -(U33F31 left, U33F31 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U33F31 operator *(U33F31 left, U33F31 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U33F31 operator /(U33F31 left, U33F31 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * OneRepr / right.Bits));
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U33F31 operator +(U33F31 x) => FromBits(+x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(U33F31 left, U33F31 right) => left.Bits == right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(U33F31 left, U33F31 right) => left.Bits != right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U33F31 left, U33F31 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U33F31 left, U33F31 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U33F31 left, U33F31 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U33F31 left, U33F31 right) => left.Bits >= right.Bits;

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is U33F31 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => LossyToDouble().ToString((IFormatProvider)null);

        // IEquatable<U33F31>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(U33F31 other) => this == other;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return LossyToDouble().ToString(format, formatProvider);
        }

        //
        // IComparable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(U33F31 value) {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U33F31 Min(U33F31 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U33F31 Max(U33F31 other) => FromBits(Math.Max(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U33F31 Clamp(
            U33F31 min, U33F31 max
        ) => FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U33F31 Half() => FromBits(Mathi.Half(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U33F31 Twice() => FromBits(Mathi.Twice(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool OverflowingAdd(U33F31 other, out U33F31 result) {
            var b = Overflowing.OverflowingAdd(Bits, other.Bits, out var bits);
            result = FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U33F31? CheckedAdd(U33F31 other) {
            U33F31? @null = null;
            var b = OverflowingAdd(other, out var result);
            return b ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U33F31 SaturatingAdd(U33F31 other) {
            return FromBits(Overflowing.SaturatingAdd(Bits, other.Bits));
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool OverflowingMul(U33F31 other, out U33F31 result) {
            var bits = ((UInt128)Bits) * other.Bits / OneRepr;
            result = FromBits(unchecked((ulong)bits));
            return bits < ulong.MinValue || bits > ulong.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U33F31? CheckedMul(U33F31 other) {
            U33F31? @null = null;
            var b = OverflowingMul(other, out var result);
            return b ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U33F31 SaturatingMul(U33F31 other) => CheckedMul(other) ?? MaxValue;

#endif

        //
        // Convert from
        //

        // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079 // 不要な抑制を削除します

#pragma warning disable CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning disable IDE0004 // 不要なキャストの削除

        #region Convert from integer

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified <see cref="int" /> value.</para>
        /// <para><see cref="int" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = U33F31.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 31, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U33F31? CheckedFrom(int num) {

            // 自身が符号なしで、相手が符号ありの場合、
            // 相手が 0 未満、または
            // 相手が自身の最大値よりも大きければ null
            if (num < 0) {
                return null;
            } else if ((uint)num > MaxRepr / OneRepr) {
                return null;
            }

            return FromBits((ulong)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified <see cref="int" /> value.</para>
        /// <para><see cref="int" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = U33F31.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 31, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U33F31 StrictFrom(int num) {
            return FromBits(checked((ulong)num * OneRepr));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="uint" /> value.</para>
        /// <para><see cref="uint" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = U33F31.From(1);
        /// System.Assert.AreEqual(1UL &lt;&lt; 31, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U33F31 From(uint num) {
            // 自身と相手の符号が同じ場合、整数部が相手以上であるから乗算は必ず成功する。
            // 自身が符号あり、相手が符号なしの場合、
            // 自身の符号部分を除いた整数部について同様である。
            return FromBits(num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified <see cref="long" /> value.</para>
        /// <para><see cref="long" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = U33F31.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 31, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U33F31? CheckedFrom(long num) {

            // 自身が符号なしで、相手が符号ありの場合、
            // 相手が 0 未満、または
            // 相手が自身の最大値よりも大きければ null
            if (num < 0) {
                return null;
            } else if ((ulong)num > MaxRepr / OneRepr) {
                return null;
            }

            return FromBits((ulong)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified <see cref="long" /> value.</para>
        /// <para><see cref="long" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = U33F31.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 31, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U33F31 StrictFrom(long num) {
            return FromBits(checked((ulong)num * OneRepr));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified <see cref="ulong" /> value.</para>
        /// <para><see cref="ulong" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = U33F31.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 31, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U33F31? CheckedFrom(ulong num) {

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (num > MaxRepr / OneRepr ||
                num < MinRepr / OneRepr) {
                return null;
            }

            return FromBits((ulong)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified <see cref="ulong" /> value.</para>
        /// <para><see cref="ulong" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = U33F31.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 31, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U33F31 StrictFrom(ulong num) {
            return FromBits(checked((ulong)num * OneRepr));
        }

        #endregion

        #region Convert from floating-point number

        // decimal からの型変換は基数 (Radix) が 2 のべき乗でないため実装しない。

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
        /// var a = U33F31.StrictFrom(1.0f);
        /// System.Assert.AreEqual(1 &lt;&lt; 31, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U33F31 StrictFrom(float num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((ulong)(num * OneRepr)));
        }

        // 自身が 64 ビットの場合､ BitConverter を使用する必要がある。
        // 現時点では未実装。
        // https://learn.microsoft.com/ja-jp/dotnet/api/system.bitconverter

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
        /// var a = U33F31.StrictFrom(1.0);
        /// System.Assert.AreEqual(1 &lt;&lt; 31, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U33F31 StrictFrom(double num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((ulong)(num * OneRepr)));
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
        /// <seealso cref="CheckedFrom(I17F15)"/>
        public static U33F31 StrictFrom(I17F15 from) {
            return FromBits(checked((ulong)from.Bits * ((ulong)1 << 16)));
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
        public static U33F31? CheckedFrom(I17F15 from) {
            if (from.Bits < 0) {
                return null;
            } else if ((uint)from.Bits > MaxRepr / ((ulong)1 << 16)) {
                return null;
            }
            return FromBits((ulong)from.Bits * ((ulong)1 << 16));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F30" /> value.</para>
        /// <para><see cref="I2F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedFrom(I2F30)"/>
        public static U33F31 StrictFrom(I2F30 from) {
            return FromBits(checked((ulong)from.Bits * ((ulong)1 << 1)));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F30" /> value.</para>
        /// <para><see cref="I2F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(I2F30)"/>
        public static U33F31? CheckedFrom(I2F30 from) {
            if (from.Bits < 0) {
                return null;
            } else if ((uint)from.Bits > MaxRepr / ((ulong)1 << 1)) {
                return null;
            }
            return FromBits((ulong)from.Bits * ((ulong)1 << 1));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I34F30" /> value.</para>
        /// <para><see cref="I34F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedFrom(I34F30)"/>
        public static U33F31 StrictFrom(I34F30 from) {
            return FromBits(checked((ulong)from.Bits * ((ulong)1 << 1)));
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
        public static U33F31? CheckedFrom(I34F30 from) {
            if (from.Bits < 0) {
                return null;
            } else if ((ulong)from.Bits > MaxRepr / ((ulong)1 << 1)) {
                return null;
            }
            return FromBits((ulong)from.Bits * ((ulong)1 << 1));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I33F31" /> value.</para>
        /// <para><see cref="I33F31" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedFrom(I33F31)"/>
        public static U33F31 StrictFrom(I33F31 from) {
            return FromBits(checked((ulong)from.Bits * ((ulong)1 << 0)));
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
        public static U33F31? CheckedFrom(I33F31 from) {
            if (from.Bits < 0) {
                return null;
            } else if ((ulong)from.Bits > MaxRepr / ((ulong)1 << 0)) {
                return null;
            }
            return FromBits((ulong)from.Bits * ((ulong)1 << 0));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I4F60" /> value.</para>
        /// <para><see cref="I4F60" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedLossyFrom(I4F60)"/>
        public static U33F31 StrictLossyFrom(I4F60 from) {
            return FromBits(checked((ulong)(from.Bits / ((long)1 << 29))));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I4F60" /> value.</para>
        /// <para><see cref="I4F60" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(I4F60)"/>
        public static U33F31? CheckedLossyFrom(I4F60 from) {
            var tmp = from.Bits / ((long)1 << 29);
            if (tmp < 0) {
                return null;
            } else if ((ulong)tmp > MaxRepr) {
                return null;
            }
            return FromBits((ulong)tmp);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F62" /> value.</para>
        /// <para><see cref="I2F62" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedLossyFrom(I2F62)"/>
        public static U33F31 StrictLossyFrom(I2F62 from) {
            return FromBits(checked((ulong)(from.Bits / ((long)1 << 31))));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F62" /> value.</para>
        /// <para><see cref="I2F62" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(I2F62)"/>
        public static U33F31? CheckedLossyFrom(I2F62 from) {
            var tmp = from.Bits / ((long)1 << 31);
            if (tmp < 0) {
                return null;
            } else if ((ulong)tmp > MaxRepr) {
                return null;
            }
            return FromBits((ulong)tmp);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U17F15" /> value.</para>
        /// <para><see cref="U17F15" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static U33F31 From(U17F15 from) {
            return FromBits((ulong)from.Bits * ((ulong)1 << 16));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F30" /> value.</para>
        /// <para><see cref="U2F30" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static U33F31 From(U2F30 from) {
            return FromBits((ulong)from.Bits * ((ulong)1 << 1));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U34F30" /> value.</para>
        /// <para><see cref="U34F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedFrom(U34F30)"/>
        public static U33F31 StrictFrom(U34F30 from) {
            return FromBits(checked((ulong)from.Bits * ((ulong)1 << 1)));
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
        public static U33F31? CheckedFrom(U34F30 from) {
            if (from.Bits > (MaxRepr / ((ulong)1 << 1)) ||
                from.Bits < (MinRepr / ((ulong)1 << 1))) {
                return null;
            }
            return FromBits((ulong)from.Bits * ((ulong)1 << 1));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U4F60" /> value.</para>
        /// <para><see cref="U4F60" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static U33F31 LossyFrom(U4F60 from) {
            return FromBits((ulong)(from.Bits / ((ulong)1 << 29)));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F62" /> value.</para>
        /// <para><see cref="U2F62" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static U33F31 LossyFrom(U2F62 from) {
            return FromBits((ulong)(from.Bits / ((ulong)1 << 31)));
        }

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
        /// <seealso cref="CheckedToInt32"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int StrictToInt32() {
            return checked((int)(Bits / OneRepr));
        }

        /// <summary>
        /// <para><see cref="int" /> への変換を行います。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToInt32"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int? CheckedToInt32() {
            var tmp = Bits / OneRepr;

            // 自身が符号なしで、相手が符号ありの場合、
            // 自身が相手の最大値よりも大きければ null
            if (tmp > int.MaxValue) {
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
        /// <seealso cref="CheckedToUInt32"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint StrictToUInt32() {
            return checked((uint)(Bits / OneRepr));
        }

        /// <summary>
        /// <para><see cref="uint" /> への変換を行います。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToUInt32"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint? CheckedToUInt32() {
            var tmp = Bits / OneRepr;

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (tmp < uint.MinValue ||
                tmp > uint.MaxValue) {
                return null;
            }

            return (uint)tmp;
        }

        /// <summary>
        /// <para><see cref="long" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long ToInt64() {
            return (long)(Bits / OneRepr);
        }

        /// <summary>
        /// <para><see cref="ulong" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong ToUInt64() {
            return (ulong)(Bits / OneRepr);
        }

        #endregion

        #region Convert to floating-point number

        // 浮動小数点数への変換は必ず成功する。
        // 除算は最適化によって乗算に置き換えられることを期待する。

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public float LossyToSingle() => (float)Bits / OneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public double LossyToDouble() => (double)Bits / OneRepr;

        #endregion

        #region Convert to fixed-point number

        /// <summary>
        /// <para>Converts to <see cref="I17F15" />.</para>
        /// <para><see cref="I17F15" /> へ変換します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyToI17F15"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15? CheckedLossyToI17F15() => I17F15.CheckedLossyFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="I17F15" />.</para>
        /// <para><see cref="I17F15" /> へ変換します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedLossyToI17F15"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15 StrictLossyToI17F15() => I17F15.StrictLossyFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="I2F30" />.</para>
        /// <para><see cref="I2F30" /> へ変換します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyToI2F30"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30? CheckedLossyToI2F30() => I2F30.CheckedLossyFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="I2F30" />.</para>
        /// <para><see cref="I2F30" /> へ変換します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedLossyToI2F30"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 StrictLossyToI2F30() => I2F30.StrictLossyFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="I34F30" />.</para>
        /// <para><see cref="I34F30" /> へ変換します。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 LossyToI34F30() => I34F30.LossyFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="I33F31" />.</para>
        /// <para><see cref="I33F31" /> へ変換します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToI33F31"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I33F31? CheckedToI33F31() => I33F31.CheckedFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="I33F31" />.</para>
        /// <para><see cref="I33F31" /> へ変換します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedToI33F31"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I33F31 StrictToI33F31() => I33F31.StrictFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="I4F60" />.</para>
        /// <para><see cref="I4F60" /> へ変換します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToI4F60"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F60? CheckedToI4F60() => I4F60.CheckedFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="I4F60" />.</para>
        /// <para><see cref="I4F60" /> へ変換します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedToI4F60"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F60 StrictToI4F60() => I4F60.StrictFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="I2F62" />.</para>
        /// <para><see cref="I2F62" /> へ変換します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToI2F62"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62? CheckedToI2F62() => I2F62.CheckedFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="I2F62" />.</para>
        /// <para><see cref="I2F62" /> へ変換します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedToI2F62"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 StrictToI2F62() => I2F62.StrictFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="U17F15" />.</para>
        /// <para><see cref="U17F15" /> へ変換します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyToU17F15"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15? CheckedLossyToU17F15() => U17F15.CheckedLossyFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="U17F15" />.</para>
        /// <para><see cref="U17F15" /> へ変換します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedLossyToU17F15"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 StrictLossyToU17F15() => U17F15.StrictLossyFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="U2F30" />.</para>
        /// <para><see cref="U2F30" /> へ変換します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyToU2F30"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30? CheckedLossyToU2F30() => U2F30.CheckedLossyFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="U2F30" />.</para>
        /// <para><see cref="U2F30" /> へ変換します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedLossyToU2F30"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 StrictLossyToU2F30() => U2F30.StrictLossyFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="U34F30" />.</para>
        /// <para><see cref="U34F30" /> へ変換します。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 LossyToU34F30() => U34F30.LossyFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="U4F60" />.</para>
        /// <para><see cref="U4F60" /> へ変換します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToU4F60"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F60? CheckedToU4F60() => U4F60.CheckedFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="U4F60" />.</para>
        /// <para><see cref="U4F60" /> へ変換します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedToU4F60"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F60 StrictToU4F60() => U4F60.StrictFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="U2F62" />.</para>
        /// <para><see cref="U2F62" /> へ変換します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToU2F62"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F62? CheckedToU2F62() => U2F62.CheckedFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="U2F62" />.</para>
        /// <para><see cref="U2F62" /> へ変換します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedToU2F62"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F62 StrictToU2F62() => U2F62.StrictFrom(this);

        #endregion

#pragma warning restore CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning restore IDE0004 // 不要なキャストの削除

#pragma warning restore IDE0079 // 不要な抑制を削除します

    }
} // namespace AgatePris.Intar
