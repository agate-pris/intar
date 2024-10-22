using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct I17F15 : IEquatable<I17F15>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 17;
        public const int FracNbits = 15;

        const int OneRepr = 1 << FracNbits;

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

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 FromBits(int bits) => new I17F15(bits);

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
        /// var a = I17F15.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15? CheckedFrom(int num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            // 自身と相手の両方が符号ありの場合、
            // 比較演算の際に双方が大きい型に合わせて暗黙に変換される。
            if (num > MaxValue.Bits / OneRepr ||
                num < MinValue.Bits / OneRepr) {
                return null;
            }

            return FromBits((int)num * OneRepr);

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
        /// var a = I17F15.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 StrictFrom(int num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            return FromBits(checked((int)num * OneRepr));

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
        /// var a = I17F15.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15? CheckedFrom(uint num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            // 自身が符号あり、相手が符号なしであるから、
            // 相手が最小値未満であることはありえない。
            // よって、自身の最大値を符号なしの型に変換して比較する。
            // この際、大きい方の型に暗黙に変換される。
            if (num > (uint)(MaxValue.Bits / OneRepr)) {
                return null;
            }

            return FromBits((int)num * OneRepr);

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
        /// var a = I17F15.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 StrictFrom(uint num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            return FromBits(checked((int)num * OneRepr));

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
        /// var a = I17F15.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15? CheckedFrom(long num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            // 自身と相手の両方が符号ありの場合、
            // 比較演算の際に双方が大きい型に合わせて暗黙に変換される。
            if (num > MaxValue.Bits / OneRepr ||
                num < MinValue.Bits / OneRepr) {
                return null;
            }

            return FromBits((int)num * OneRepr);

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
        /// var a = I17F15.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 StrictFrom(long num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            return FromBits(checked((int)num * OneRepr));

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
        /// var a = I17F15.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15? CheckedFrom(ulong num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            // 自身が符号あり、相手が符号なしであるから、
            // 相手が最小値未満であることはありえない。
            // よって、自身の最大値を符号なしの型に変換して比較する。
            // この際、大きい方の型に暗黙に変換される。
            if (num > (uint)(MaxValue.Bits / OneRepr)) {
                return null;
            }

            return FromBits((int)num * OneRepr);

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
        /// var a = I17F15.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 StrictFrom(ulong num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            return FromBits(checked((int)num * OneRepr));

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
        /// var a = I17F15.StrictLossyFrom(1.0f);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 StrictLossyFrom(float num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((int)(num * OneRepr)));
        }

        public static I17F15? CheckedFrom(double num) {
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
                num <=  int.MinValue - 1.0) {
                return null;
            }
            return FromBits((int)num);
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
        /// var a = I17F15.StrictFrom(1.0);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 StrictFrom(double num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((int)(num * OneRepr)));
        }

        // Static Properties
        // -----------------

        public static I17F15 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new I17F15(0);
        }
        public static I17F15 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new I17F15(OneRepr);
        }
        public static I17F15 MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(int.MinValue);
        }
        public static I17F15 MaxValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(int.MaxValue);
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
            long l = left.Bits;
            return FromBits((int)(l * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 operator /(I17F15 left, I17F15 right) {
            long l = left.Bits;
            return FromBits((int)(l * OneRepr / right.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 operator +(I17F15 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 operator -(I17F15 x) => FromBits(-x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(I17F15 lhs, I17F15 rhs) => lhs.Bits == rhs.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(I17F15 lhs, I17F15 rhs) => lhs.Bits != rhs.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I17F15 left, I17F15 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I17F15 left, I17F15 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I17F15 left, I17F15 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I17F15 left, I17F15 right) => left.Bits >= right.Bits;

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(I17F15 x) => x.Bits / OneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(I17F15 x) => (uint)(x.Bits / OneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(I17F15 x) => x.Bits / OneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(I17F15 x) => (ulong)(x.Bits / OneRepr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I17F15 x) {
            const float k = 1.0f / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I17F15 x) {
            const double k = 1.0 / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I17F15 x) {
            const decimal k = 1.0M / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(I17F15 x) => I2F30.FromBits(x.Bits * (1 << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I34F30(I17F15 x) => I34F30.FromBits(x.Bits * (1L << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I33F31(I17F15 x) => I33F31.FromBits(x.Bits * (1L << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F60(I17F15 x) => I4F60.FromBits(x.Bits * (1L << 45));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F62(I17F15 x) => I2F62.FromBits(x.Bits * (1L << 47));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(I17F15 x) => U17F15.FromBits((uint)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(I17F15 x) => U2F30.FromBits((uint)x.Bits * (1U << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U34F30(I17F15 x) => U34F30.FromBits((ulong)x.Bits * (1UL << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U33F31(I17F15 x) => U33F31.FromBits((ulong)x.Bits * (1UL << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F60(I17F15 x) => U4F60.FromBits((ulong)x.Bits * (1UL << 45));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F62(I17F15 x) => U2F62.FromBits((ulong)x.Bits * (1UL << 47));

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is I17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<I17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(I17F15 other) => Bits == other.Bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 Min(I17F15 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 Max(I17F15 other) => FromBits(Math.Max(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 Abs() => FromBits(Math.Abs(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15 Clamp(
            I17F15 min, I17F15 max
        ) => FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 Half() => FromBits(Mathi.Half(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 Twice() => FromBits(Mathi.Twice(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 WrappingAdd(I17F15 other) => FromBits(Overflowing.WrappingAdd(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 WrappingSub(I17F15 other) => FromBits(Overflowing.WrappingSub(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 WrappingMul(I17F15 other) => FromBits(Overflowing.WrappingMul(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 WrappingAddUnsigned(U17F15 other) => FromBits(Overflowing.WrappingAddUnsigned(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 WrappingSubUnsigned(U17F15 other) => FromBits(Overflowing.WrappingSubUnsigned(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 UnsignedAbs() {
            return U17F15.FromBits(Overflowing.UnsignedAbs(Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool OverflowingAdd(I17F15 other, out I17F15 result) {
            var b = Overflowing.OverflowingAdd(Bits, other.Bits, out var bits);
            result = FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15? CheckedAdd(I17F15 other) {
            I17F15? @null = null;
            return OverflowingAdd(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15 SaturatingAdd(I17F15 other) {
            return FromBits(Overflowing.SaturatingAdd(Bits, other.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool OverflowingMul(I17F15 other, out I17F15 result) {
            var bits = ((long)Bits) * other.Bits / OneRepr;
            result = FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15? CheckedMul(I17F15 other) {
            I17F15? @null = null;
            return OverflowingMul(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15 SaturatingMul(I17F15 other) {
            return CheckedMul(other) ?? (((Bits < 0) == (other.Bits < 0))
                ? MaxValue
                : MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 BigMul(I17F15 other) {
            return I34F30.FromBits((long)Bits * other.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 BigMul(U17F15 other) {
            return I34F30.FromBits(Bits * other.Bits);
        }

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

        // ベクトル型との演算
        // ------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 SaturatingMul(Vector2I17F15 other) => other.SaturatingMul(this);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 SaturatingMul(Vector3I17F15 other) => other.SaturatingMul(this);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 SaturatingMul(Vector4I17F15 other) => other.SaturatingMul(this);

    }
} // namespace AgatePris.Intar
