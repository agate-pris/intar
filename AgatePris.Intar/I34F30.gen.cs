using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct I34F30 : IEquatable<I34F30>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 34;
        public const int FracNbits = 30;

        const long OneRepr = 1L << FracNbits;

        // Fields
        // ------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public long Bits;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I34F30(long bits) {
            Bits = bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 FromBits(long bits) => new I34F30(bits);

        // Static Properties
        // -----------------

        public static I34F30 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new I34F30(0);
        }
        public static I34F30 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new I34F30(OneRepr);
        }
        public static I34F30 MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(long.MinValue);
        }
        public static I34F30 MaxValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(long.MaxValue);
        }

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator +(I34F30 left, I34F30 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator -(I34F30 left, I34F30 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator *(I34F30 left, I34F30 right) {
            Int128 l = left.Bits;
            return FromBits((long)(l * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator /(I34F30 left, I34F30 right) {
            Int128 l = left.Bits;
            return FromBits((long)(l * OneRepr / right.Bits));
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator +(I34F30 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator -(I34F30 x) => FromBits(-x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(I34F30 left, I34F30 right) => left.Bits == right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(I34F30 left, I34F30 right) => left.Bits != right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I34F30 left, I34F30 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I34F30 left, I34F30 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I34F30 left, I34F30 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I34F30 left, I34F30 right) => left.Bits >= right.Bits;

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is I34F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => LossyToDouble().ToString((IFormatProvider)null);

        // IEquatable<I34F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(I34F30 other) => Bits == other.Bits;

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
        public int CompareTo(I34F30 value) {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 Min(I34F30 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 Max(I34F30 other) => FromBits(Math.Max(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 Abs() => FromBits(Math.Abs(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 Clamp(
            I34F30 min, I34F30 max
        ) => FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 Half() => FromBits(Mathi.Half(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 Twice() => FromBits(Mathi.Twice(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 WrappingAdd(I34F30 other) => FromBits(Overflowing.WrappingAdd(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 WrappingSub(I34F30 other) => FromBits(Overflowing.WrappingSub(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 WrappingMul(I34F30 other) => FromBits(Overflowing.WrappingMul(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 WrappingAddUnsigned(U34F30 other) => FromBits(Overflowing.WrappingAddUnsigned(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 WrappingSubUnsigned(U34F30 other) => FromBits(Overflowing.WrappingSubUnsigned(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 UnsignedAbs() {
            return U34F30.FromBits(Overflowing.UnsignedAbs(Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool OverflowingAdd(I34F30 other, out I34F30 result) {
            var b = Overflowing.OverflowingAdd(Bits, other.Bits, out var bits);
            result = FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30? CheckedAdd(I34F30 other) {
            I34F30? @null = null;
            return OverflowingAdd(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 SaturatingAdd(I34F30 other) {
            return FromBits(Overflowing.SaturatingAdd(Bits, other.Bits));
        }

        //
        // Convert from
        //

        // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079 // 不要な抑制を削除します

#pragma warning disable CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning disable IDE0004 // 不要なキャストの削除

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
            return FromBits(num * OneRepr);
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
        /// var a = I34F30.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30? CheckedFrom(long num) {

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (num > MaxValue.Bits / OneRepr ||
                num < MinValue.Bits / OneRepr) {
                return null;
            }

            return FromBits((long)num * OneRepr);
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
        /// var a = I34F30.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 StrictFrom(long num) {
            return FromBits(checked((long)num * OneRepr));
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
        /// var a = I34F30.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30? CheckedFrom(ulong num) {

            // 自身が符号あり、相手が符号なしであるから、
            // 相手が最小値未満であることはありえない。
            // よって、自身の最大値を符号なしの型に変換して比較する。
            // この際、大きい方の型に暗黙に変換される。
            if (num > (ulong)(MaxValue.Bits / OneRepr)) {
                return null;
            }

            return FromBits((long)num * OneRepr);
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
        /// var a = I34F30.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 StrictFrom(ulong num) {
            return FromBits(checked((long)num * OneRepr));
        }

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
        /// var a = I34F30.StrictFrom(1.0f);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 StrictFrom(float num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((long)(num * OneRepr)));
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
        /// var a = I34F30.StrictFrom(1.0);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 StrictFrom(double num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((long)(num * OneRepr)));
        }

        // 自身が 64 ビットの場合､ BitConverter を使用する必要がある。
        // 現時点では未実装。
        // https://learn.microsoft.com/ja-jp/dotnet/api/system.bitconverter

        //
        // Convert to
        //

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
            return (long)(Bits / OneRepr);
        }

        /// <summary>
        /// <para><see cref="ulong" /> への変換を行います。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedToUInt64"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong StrictToUInt64() {
            return checked((ulong)(Bits / OneRepr));
        }

        /// <summary>
        /// <para><see cref="ulong" /> への変換を行います。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToUInt64"/>
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

        // 浮動小数点数への変換は必ず成功する。
        // 除算は最適化によって乗算に置き換えられることを期待する。

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public float LossyToSingle() => (float)Bits / OneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public double LossyToDouble() => (double)Bits / OneRepr;

        // 固定小数点数への変換

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 StrictLossyToI17F15() => I17F15.FromBits(checked((int)(Bits / (1L << 15))));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 StrictToI2F30() => I2F30.FromBits(checked((int)Bits * (1 << 0)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I33F31 StrictToI33F31() => I33F31.FromBits(checked((long)Bits * (1L << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I4F60 StrictToI4F60() => I4F60.FromBits(checked((long)Bits * (1L << 30)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F62 StrictToI2F62() => I2F62.FromBits(checked((long)Bits * (1L << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U17F15 StrictLossyToU17F15() => U17F15.FromBits(checked((uint)(Bits / (1L << 15))));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F30 StrictToU2F30() => U2F30.FromBits(checked((uint)Bits * (1U << 0)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 StrictToU34F30() => U34F30.FromBits(checked((ulong)Bits * (1UL << 0)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U33F31 StrictToU33F31() => U33F31.FromBits(checked((ulong)Bits * (1UL << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U4F60 StrictToU4F60() => U4F60.FromBits(checked((ulong)Bits * (1UL << 30)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 StrictToU2F62() => U2F62.FromBits(checked((ulong)Bits * (1UL << 32)));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15? CheckedLossyToI17F15() {
            var tmp = Bits / (1L << 15);

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (tmp < I17F15.MinValue.Bits ||
                tmp > I17F15.MaxValue.Bits) {
                return null;
            }

            return I17F15.FromBits((int)tmp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30? CheckedToI2F30() {
            if (Bits > I2F30.MaxValue.Bits / (1 << 0) ||
                Bits < I2F30.MinValue.Bits / (1 << 0)) {
                return null;
            }

            return I2F30.FromBits((int)Bits * (1 << 0));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I33F31? CheckedToI33F31() {
            if (Bits > I33F31.MaxValue.Bits / (1L << 1) ||
                Bits < I33F31.MinValue.Bits / (1L << 1)) {
                return null;
            }

            return I33F31.FromBits((long)Bits * (1L << 1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F60? CheckedToI4F60() {
            if (Bits > I4F60.MaxValue.Bits / (1L << 30) ||
                Bits < I4F60.MinValue.Bits / (1L << 30)) {
                return null;
            }

            return I4F60.FromBits((long)Bits * (1L << 30));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62? CheckedToI2F62() {
            if (Bits > I2F62.MaxValue.Bits / (1L << 32) ||
                Bits < I2F62.MinValue.Bits / (1L << 32)) {
                return null;
            }

            return I2F62.FromBits((long)Bits * (1L << 32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15? CheckedLossyToU17F15() {
            var tmp = Bits / (1L << 15);

            // 自身が符号ありで、相手が符号なしの場合、
            // 自身が 0 未満、または
            // 自身が相手の最大値よりも大きければ null
            if (tmp < 0) {
                return null;
            } else if ((ulong)tmp > U17F15.MaxValue.Bits) {
                return null;
            }

            return U17F15.FromBits((uint)tmp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30? CheckedToU2F30() {
            if (Bits < 0) {
                return null;
            } else if ((ulong)Bits > U2F30.MaxValue.Bits / (1U << 0)) {
                return null;
            }

            return U2F30.FromBits((uint)Bits * (1U << 0));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30? CheckedToU34F30() {
            if (Bits < 0) {
                return null;
            } else if ((ulong)Bits > U34F30.MaxValue.Bits / (1UL << 0)) {
                return null;
            }

            return U34F30.FromBits((ulong)Bits * (1UL << 0));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U33F31? CheckedToU33F31() {
            if (Bits < 0) {
                return null;
            } else if ((ulong)Bits > U33F31.MaxValue.Bits / (1UL << 1)) {
                return null;
            }

            return U33F31.FromBits((ulong)Bits * (1UL << 1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F60? CheckedToU4F60() {
            if (Bits < 0) {
                return null;
            } else if ((ulong)Bits > U4F60.MaxValue.Bits / (1UL << 30)) {
                return null;
            }

            return U4F60.FromBits((ulong)Bits * (1UL << 30));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F62? CheckedToU2F62() {
            if (Bits < 0) {
                return null;
            } else if ((ulong)Bits > U2F62.MaxValue.Bits / (1UL << 32)) {
                return null;
            }

            return U2F62.FromBits((ulong)Bits * (1UL << 32));
        }

#pragma warning restore CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning restore IDE0004 // 不要なキャストの削除

#pragma warning restore IDE0079 // 不要な抑制を削除します

    }
} // namespace AgatePris.Intar
