using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct I2F62 : IEquatable<I2F62>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 2;
        public const int FracNbits = 62;

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
        I2F62(long bits) {
            Bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 FromBits(long bits) => new I2F62(bits);

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
        /// var a = I2F62.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62? CheckedFrom(int num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            // 自身と相手の両方が符号ありの場合、
            // 比較演算の際に双方が大きい型に合わせて暗黙に変換される。
            if (num > MaxValue.Bits / OneRepr ||
                num < MinValue.Bits / OneRepr) {
                return null;
            }

            return FromBits((long)num * OneRepr);

#pragma warning restore IDE0004
#pragma warning restore IDE0079

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
        /// var a = I2F62.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 StrictFrom(int num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            return FromBits(checked((long)num * OneRepr));

#pragma warning restore IDE0004
#pragma warning restore IDE0079

        }

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
        /// var a = I2F62.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62? CheckedFrom(uint num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            // 自身が符号あり、相手が符号なしであるから、
            // 相手が最小値未満であることはありえない。
            // よって、自身の最大値を符号なしの型に変換して比較する。
            // この際、大きい方の型に暗黙に変換される。
            if (num > (ulong)(MaxValue.Bits / OneRepr)) {
                return null;
            }

            return FromBits((long)num * OneRepr);

#pragma warning restore IDE0004
#pragma warning restore IDE0079

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
        /// var a = I2F62.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 StrictFrom(uint num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            return FromBits(checked((long)num * OneRepr));

#pragma warning restore IDE0004
#pragma warning restore IDE0079

        }

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
        /// var a = I2F62.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62? CheckedFrom(long num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            // 自身と相手の両方が符号ありの場合、
            // 比較演算の際に双方が大きい型に合わせて暗黙に変換される。
            if (num > MaxValue.Bits / OneRepr ||
                num < MinValue.Bits / OneRepr) {
                return null;
            }

            return FromBits((long)num * OneRepr);

#pragma warning restore IDE0004
#pragma warning restore IDE0079

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
        /// var a = I2F62.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 StrictFrom(long num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            return FromBits(checked((long)num * OneRepr));

#pragma warning restore IDE0004
#pragma warning restore IDE0079

        }

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
        /// var a = I2F62.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62? CheckedFrom(ulong num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            // 自身が符号あり、相手が符号なしであるから、
            // 相手が最小値未満であることはありえない。
            // よって、自身の最大値を符号なしの型に変換して比較する。
            // この際、大きい方の型に暗黙に変換される。
            if (num > (ulong)(MaxValue.Bits / OneRepr)) {
                return null;
            }

            return FromBits((long)num * OneRepr);

#pragma warning restore IDE0004
#pragma warning restore IDE0079

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
        /// var a = I2F62.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 StrictFrom(ulong num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            return FromBits(checked((long)num * OneRepr));

#pragma warning restore IDE0004
#pragma warning restore IDE0079

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
        /// var a = I2F62.StrictFrom(1.0f);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 StrictFrom(float num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((long)(num * OneRepr)));
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
        /// var a = I2F62.StrictFrom(1.0);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 StrictFrom(double num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((long)(num * OneRepr)));
        }

        // Static Properties
        // -----------------

        public static I2F62 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new I2F62(0);
        }
        public static I2F62 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new I2F62(OneRepr);
        }
        public static I2F62 MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(long.MinValue);
        }
        public static I2F62 MaxValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(long.MaxValue);
        }

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 operator +(I2F62 left, I2F62 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 operator -(I2F62 left, I2F62 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 operator *(I2F62 left, I2F62 right) {
            Int128 l = left.Bits;
            return FromBits((long)(l * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 operator /(I2F62 left, I2F62 right) {
            Int128 l = left.Bits;
            return FromBits((long)(l * OneRepr / right.Bits));
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 operator +(I2F62 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 operator -(I2F62 x) => FromBits(-x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(I2F62 lhs, I2F62 rhs) => lhs.Bits == rhs.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(I2F62 lhs, I2F62 rhs) => lhs.Bits != rhs.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I2F62 left, I2F62 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I2F62 left, I2F62 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I2F62 left, I2F62 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I2F62 left, I2F62 right) => left.Bits >= right.Bits;

        // Conversion operators
        // --------------------

#pragma warning disable IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(I2F62 x) => (int)(x.Bits / OneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(I2F62 x) => (uint)(x.Bits / OneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(I2F62 x) => (long)(x.Bits / OneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(I2F62 x) => (ulong)(x.Bits / OneRepr);

#pragma warning restore IDE0004 // 不要なキャストの削除

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I2F62 x) {
            const float k = 1.0f / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I2F62 x) {
            const double k = 1.0 / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I2F62 x) {
            const decimal k = 1.0M / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(I2F62 x) => I17F15.FromBits((int)(x.Bits / (1L << 47)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(I2F62 x) => I2F30.FromBits((int)(x.Bits / (1L << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I34F30(I2F62 x) => I34F30.FromBits(x.Bits / (1L << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I33F31(I2F62 x) => I33F31.FromBits(x.Bits / (1L << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F60(I2F62 x) => I4F60.FromBits(x.Bits / (1L << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(I2F62 x) => U17F15.FromBits((uint)(x.Bits / (1L << 47)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(I2F62 x) => U2F30.FromBits((uint)(x.Bits / (1L << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U34F30(I2F62 x) => U34F30.FromBits((ulong)(x.Bits / (1L << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U33F31(I2F62 x) => U33F31.FromBits((ulong)(x.Bits / (1L << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F60(I2F62 x) => U4F60.FromBits((ulong)(x.Bits / (1L << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F62(I2F62 x) => U2F62.FromBits((ulong)x.Bits);

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is I2F62 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<I2F62>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(I2F62 other) => Bits == other.Bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F62 Min(I2F62 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F62 Max(I2F62 other) => FromBits(Math.Max(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F62 Abs() => FromBits(Math.Abs(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 Clamp(
            I2F62 min, I2F62 max
        ) => FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F62 Half() => FromBits(Mathi.Half(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F62 Twice() => FromBits(Mathi.Twice(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F62 WrappingAdd(I2F62 other) => FromBits(Overflowing.WrappingAdd(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F62 WrappingSub(I2F62 other) => FromBits(Overflowing.WrappingSub(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F62 WrappingMul(I2F62 other) => FromBits(Overflowing.WrappingMul(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F62 WrappingAddUnsigned(U2F62 other) => FromBits(Overflowing.WrappingAddUnsigned(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F62 WrappingSubUnsigned(U2F62 other) => FromBits(Overflowing.WrappingSubUnsigned(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F62 UnsignedAbs() {
            return U2F62.FromBits(Overflowing.UnsignedAbs(Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool OverflowingAdd(I2F62 other, out I2F62 result) {
            var b = Overflowing.OverflowingAdd(Bits, other.Bits, out var bits);
            result = FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62? CheckedAdd(I2F62 other) {
            I2F62? @null = null;
            return OverflowingAdd(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 SaturatingAdd(I2F62 other) {
            return FromBits(Overflowing.SaturatingAdd(Bits, other.Bits));
        }

    }
} // namespace AgatePris.Intar
