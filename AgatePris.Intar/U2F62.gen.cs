using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct U2F62 : IEquatable<U2F62>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 2;
        public const int FracNbits = 62;

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
        U2F62(ulong bits) {
            Bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 FromBits(ulong bits) => new U2F62(bits);

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
        /// var a = U2F62.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62? CheckedFrom(int num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            // 自身が符号なしで相手が 0 未満の場合は null
            // この分岐は相手が符号なしなら最適化により消去される。
            if (num < 0) {
                return null;
            }

            // 相手が最大値より大きい場合は null
            // この時点で自身が 0 以上であることが確定しているので、
            // 相手を符号なしの型に変換してから比較する。
            // 自身もまた符号なしであるから、
            // 比較演算の際に必要なら暗黙の型変換が行われる。
            if ((uint)num > MaxValue.Bits / OneRepr) {
                return null;
            }

            return FromBits((ulong)num * OneRepr);

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
        /// var a = U2F62.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 StrictFrom(int num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            return FromBits(checked((ulong)num * OneRepr));

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
        /// var a = U2F62.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62? CheckedFrom(uint num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            // 自身が符号なしで相手が 0 未満の場合は null
            // この分岐は相手が符号なしなら最適化により消去される。
            if (num < 0) {
                return null;
            }

            // 相手が最大値より大きい場合は null
            // この時点で自身が 0 以上であることが確定しているので、
            // 相手を符号なしの型に変換してから比較する。
            // 自身もまた符号なしであるから、
            // 比較演算の際に必要なら暗黙の型変換が行われる。
            if ((uint)num > MaxValue.Bits / OneRepr) {
                return null;
            }

            return FromBits((ulong)num * OneRepr);

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
        /// var a = U2F62.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 StrictFrom(uint num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            return FromBits(checked((ulong)num * OneRepr));

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
        /// var a = U2F62.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62? CheckedFrom(long num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            // 自身が符号なしで相手が 0 未満の場合は null
            // この分岐は相手が符号なしなら最適化により消去される。
            if (num < 0) {
                return null;
            }

            // 相手が最大値より大きい場合は null
            // この時点で自身が 0 以上であることが確定しているので、
            // 相手を符号なしの型に変換してから比較する。
            // 自身もまた符号なしであるから、
            // 比較演算の際に必要なら暗黙の型変換が行われる。
            if ((ulong)num > MaxValue.Bits / OneRepr) {
                return null;
            }

            return FromBits((ulong)num * OneRepr);

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
        /// var a = U2F62.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 StrictFrom(long num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            return FromBits(checked((ulong)num * OneRepr));

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
        /// var a = U2F62.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62? CheckedFrom(ulong num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            // 自身が符号なしで相手が 0 未満の場合は null
            // この分岐は相手が符号なしなら最適化により消去される。
            if (num < 0) {
                return null;
            }

            // 相手が最大値より大きい場合は null
            // この時点で自身が 0 以上であることが確定しているので、
            // 相手を符号なしの型に変換してから比較する。
            // 自身もまた符号なしであるから、
            // 比較演算の際に必要なら暗黙の型変換が行われる。
            if ((ulong)num > MaxValue.Bits / OneRepr) {
                return null;
            }

            return FromBits((ulong)num * OneRepr);

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
        /// var a = U2F62.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 StrictFrom(ulong num) {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079
#pragma warning disable IDE0004

            return FromBits(checked((ulong)num * OneRepr));

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
        /// var a = U2F62.StrictFrom(1.0f);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 StrictFrom(float num) {
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
        /// var a = U2F62.StrictFrom(1.0);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 StrictFrom(double num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((ulong)(num * OneRepr)));
        }

        // 自身が 64 ビットの場合､ BitConverter を使用する必要がある。
        // 現時点では未実装。
        // https://learn.microsoft.com/ja-jp/dotnet/api/system.bitconverter

        // Static Properties
        // -----------------

        public static U2F62 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new U2F62(0);
        }
        public static U2F62 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new U2F62(OneRepr);
        }
        public static U2F62 MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(ulong.MinValue);
        }
        public static U2F62 MaxValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(ulong.MaxValue);
        }

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 operator +(U2F62 left, U2F62 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 operator -(U2F62 left, U2F62 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 operator *(U2F62 left, U2F62 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 operator /(U2F62 left, U2F62 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * OneRepr / right.Bits));
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 operator +(U2F62 x) => FromBits(+x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(U2F62 lhs, U2F62 rhs) => lhs.Bits == rhs.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(U2F62 lhs, U2F62 rhs) => lhs.Bits != rhs.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U2F62 left, U2F62 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U2F62 left, U2F62 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U2F62 left, U2F62 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U2F62 left, U2F62 right) => left.Bits >= right.Bits;

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(U2F62 x) {
            const float k = 1.0f / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(U2F62 x) {
            const double k = 1.0 / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(U2F62 x) {
            const decimal k = 1.0M / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(U2F62 x) => I17F15.FromBits((int)(x.Bits / (1UL << 47)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(U2F62 x) => I2F30.FromBits((int)(x.Bits / (1UL << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I34F30(U2F62 x) => I34F30.FromBits((long)(x.Bits / (1UL << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I33F31(U2F62 x) => I33F31.FromBits((long)(x.Bits / (1UL << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F60(U2F62 x) => I4F60.FromBits((long)(x.Bits / (1UL << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F62(U2F62 x) => I2F62.FromBits((long)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(U2F62 x) => U17F15.FromBits((uint)(x.Bits / (1UL << 47)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(U2F62 x) => U2F30.FromBits((uint)(x.Bits / (1UL << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U34F30(U2F62 x) => U34F30.FromBits(x.Bits / (1UL << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U33F31(U2F62 x) => U33F31.FromBits(x.Bits / (1UL << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F60(U2F62 x) => U4F60.FromBits(x.Bits / (1UL << 2));

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is U2F62 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<U2F62>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(U2F62 other) => Bits == other.Bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 Min(U2F62 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 Max(U2F62 other) => FromBits(Math.Max(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F62 Clamp(
            U2F62 min, U2F62 max
        ) => FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 Half() => FromBits(Mathi.Half(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 Twice() => FromBits(Mathi.Twice(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 WrappingAdd(U2F62 other) => FromBits(Overflowing.WrappingAdd(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 WrappingSub(U2F62 other) => FromBits(Overflowing.WrappingSub(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 WrappingMul(U2F62 other) => FromBits(Overflowing.WrappingMul(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 WrappingAddSigned(I2F62 other) => FromBits(Overflowing.WrappingAddSigned(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool OverflowingAdd(U2F62 other, out U2F62 result) {
            var b = Overflowing.OverflowingAdd(Bits, other.Bits, out var bits);
            result = FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F62? CheckedAdd(U2F62 other) {
            U2F62? @null = null;
            return OverflowingAdd(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F62 SaturatingAdd(U2F62 other) {
            return FromBits(Overflowing.SaturatingAdd(Bits, other.Bits));
        }

        //
        // Conversions
        //

        // 整数への変換で小数点以下の精度が失われるのは自明なので
        // わざわざ明記することはしない。

        /// <summary>
        /// <para><see cref="int" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int ToInt32() {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

            return (int)(Bits / OneRepr);

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        }

        /// <summary>
        /// <para><see cref="uint" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint ToUInt32() {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

            return (uint)(Bits / OneRepr);

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        }

        /// <summary>
        /// <para><see cref="long" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long ToInt64() {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

            return (long)(Bits / OneRepr);

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        }

        /// <summary>
        /// <para><see cref="ulong" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong ToUInt64() {
            // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0004 // 不要なキャストの削除

            return (ulong)(Bits / OneRepr);

#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

        }

    }
} // namespace AgatePris.Intar
