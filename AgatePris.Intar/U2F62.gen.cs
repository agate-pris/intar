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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 FromBits(ulong bits) => new U2F62(bits);

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(U2F62 left, U2F62 right) => left.Bits == right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(U2F62 left, U2F62 right) => left.Bits != right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U2F62 left, U2F62 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U2F62 left, U2F62 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U2F62 left, U2F62 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U2F62 left, U2F62 right) => left.Bits >= right.Bits;

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is U2F62 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => LossyToDouble().ToString((IFormatProvider)null);

        // IEquatable<U2F62>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(U2F62 other) => Bits == other.Bits;

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
        public int CompareTo(U2F62 value) {
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
        // Convert from
        //

        // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079 // 不要な抑制を削除します

#pragma warning disable CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning disable IDE0004 // 不要なキャストの削除

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
        /// var a = U2F62.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62? CheckedFrom(int num) {

            // 自身が符号なしで、相手が符号ありの場合、
            // 相手が 0 未満、または
            // 相手が自身の最大値よりも大きければ null
            if (num < 0) {
                return null;
            } else if ((uint)num > MaxValue.Bits / OneRepr) {
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
        /// var a = U2F62.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 StrictFrom(int num) {
            return FromBits(checked((ulong)num * OneRepr));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified <see cref="uint" /> value.</para>
        /// <para><see cref="uint" /> から新しく固定小数点数を構築します。</para>
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

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (num > MaxValue.Bits / OneRepr ||
                num < MinValue.Bits / OneRepr) {
                return null;
            }

            return FromBits((ulong)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified <see cref="uint" /> value.</para>
        /// <para><see cref="uint" /> から新しく固定小数点数を構築します。</para>
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
            return FromBits(checked((ulong)num * OneRepr));
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
        /// var a = U2F62.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62? CheckedFrom(long num) {

            // 自身が符号なしで、相手が符号ありの場合、
            // 相手が 0 未満、または
            // 相手が自身の最大値よりも大きければ null
            if (num < 0) {
                return null;
            } else if ((ulong)num > MaxValue.Bits / OneRepr) {
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
        /// var a = U2F62.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 StrictFrom(long num) {
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
        /// var a = U2F62.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62? CheckedFrom(ulong num) {

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (num > MaxValue.Bits / OneRepr ||
                num < MinValue.Bits / OneRepr) {
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
        /// var a = U2F62.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 62, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 StrictFrom(ulong num) {
            return FromBits(checked((ulong)num * OneRepr));
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

        //
        // Convert to
        //

        // 整数への変換で小数点以下の精度が失われるのは自明なので
        // わざわざ明記することはしない。

        /// <summary>
        /// <para><see cref="int" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int ToInt32() {
            return (int)(Bits / OneRepr);
        }

        /// <summary>
        /// <para><see cref="uint" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint ToUInt32() {
            return (uint)(Bits / OneRepr);
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

        // 浮動小数点数への変換は必ず成功する。
        // 除算は最適化によって乗算に置き換えられることを期待する。

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public float LossyToSingle() => (float)Bits / OneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public double LossyToDouble() => (double)Bits / OneRepr;

        // 固定小数点数への変換

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 LossyToI17F15() => I17F15.FromBits((int)(Bits / (1UL << 47)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 StrictLossyToI2F30() => I2F30.FromBits(checked((int)(Bits / (1UL << 32))));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 LossyToI34F30() => I34F30.FromBits((long)(Bits / (1UL << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I33F31 LossyToI33F31() => I33F31.FromBits((long)(Bits / (1UL << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I4F60 LossyToI4F60() => I4F60.FromBits((long)(Bits / (1UL << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F62 StrictToI2F62() => I2F62.FromBits(checked((long)Bits * (1L << 0)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U17F15 LossyToU17F15() => U17F15.FromBits((uint)(Bits / (1UL << 47)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F30 LossyToU2F30() => U2F30.FromBits((uint)(Bits / (1UL << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 LossyToU34F30() => U34F30.FromBits((ulong)(Bits / (1UL << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U33F31 LossyToU33F31() => U33F31.FromBits((ulong)(Bits / (1UL << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U4F60 LossyToU4F60() => U4F60.FromBits((ulong)(Bits / (1UL << 2)));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30? CheckedLossyToI2F30() {
            var tmp = Bits / (1UL << 32);

            // 自身が符号なしで、相手が符号ありの場合、
            // 自身が相手の最大値よりも大きければ null
            if (tmp > (uint)I2F30.MaxValue.Bits) {
                return null;
            }

            return I2F30.FromBits((int)tmp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62? CheckedToI2F62() {
            if (Bits > (ulong)I2F62.MaxValue.Bits / (1L << 0)) {
                return null;
            }

            return I2F62.FromBits((long)Bits * (1L << 0));
        }

#pragma warning restore CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning restore IDE0004 // 不要なキャストの削除

#pragma warning restore IDE0079 // 不要な抑制を削除します

    }
} // namespace AgatePris.Intar
