using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct U34F30 : IEquatable<U34F30>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 34;
        public const int FracNbits = 30;

        internal const ulong MinRepr = ulong.MinValue;
        internal const ulong MaxRepr = ulong.MaxValue;
        internal const ulong EpsilonRepr = 1;

        internal const ulong OneRepr = 1UL << FracNbits;

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
        U34F30(ulong bits) {
            Bits = bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 FromBits(ulong bits) => new U34F30(bits);

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

        public static readonly U34F30 Zero;
        public static readonly U34F30 One = new U34F30(OneRepr);
        public static readonly U34F30 MinValue = new U34F30(MinRepr);
        public static readonly U34F30 MaxValue = new U34F30(MaxRepr);
        internal static readonly U34F30 Epsilon = new U34F30(EpsilonRepr);

        //
        // Properties
        //

#if NET7_0_OR_GREATER

        internal UInt128 WideBits {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Bits;
        }

#endif // NET7_0_OR_GREATER

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 operator +(U34F30 left, U34F30 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 operator -(U34F30 left, U34F30 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 operator *(U34F30 left, U34F30 right) {
            return FromBits((ulong)(left.WideBits * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 operator /(U34F30 left, U34F30 right) {
            return FromBits((ulong)(left.WideBits * OneRepr / right.Bits));
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 operator +(U34F30 x) => FromBits(+x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(U34F30 left, U34F30 right) => left.Bits == right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(U34F30 left, U34F30 right) => left.Bits != right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U34F30 left, U34F30 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U34F30 left, U34F30 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U34F30 left, U34F30 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U34F30 left, U34F30 right) => left.Bits >= right.Bits;

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is U34F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => LossyToDouble().ToString((IFormatProvider)null);

        // IEquatable<U34F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(U34F30 other) => this == other;

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
        public int CompareTo(U34F30 value) {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 Min(U34F30 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 Max(U34F30 other) => FromBits(Math.Max(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 Clamp(
            U34F30 min, U34F30 max
        ) => FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal U34F30 Half() => FromBits(Mathi.Half(Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal U34F30 Twice() => FromBits(Mathi.Twice(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool OverflowingAdd(U34F30 other, out U34F30 result) {
            var b = Overflowing.OverflowingAdd(Bits, other.Bits, out var bits);
            result = FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30? CheckedAdd(U34F30 other) {
            U34F30? @null = null;
            var b = OverflowingAdd(other, out var result);
            return b ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 SaturatingAdd(U34F30 other) {
            return FromBits(Overflowing.SaturatingAdd(Bits, other.Bits));
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool OverflowingMul(U34F30 other, out U34F30 result) {
            var bits = WideBits * other.Bits / OneRepr;
            result = FromBits(unchecked((ulong)bits));
            return bits < ulong.MinValue || bits > ulong.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30? CheckedMul(U34F30 other) {
            U34F30? @null = null;
            var b = OverflowingMul(other, out var result);
            return b ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 SaturatingMul(U34F30 other) => CheckedMul(other) ?? MaxValue;

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
        /// var a = U34F30.StrictFrom(1);
        /// System.Assert.AreEqual(1UL &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 StrictFrom(int num) {
            return FromBits(checked((ulong)num * OneRepr));
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
        /// var a = U34F30.UncheckedFrom(1);
        /// System.Assert.AreEqual(1UL &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 UncheckedFrom(int num) {
            return FromBits(unchecked((ulong)num * OneRepr));
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
        /// var a = U34F30.CheckedFrom(1);
        /// System.Assert.AreEqual(1UL &lt;&lt; 30, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30? CheckedFrom(int num) {

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
        /// <para>Constructs a new fixed-point number from <see cref="uint" /> value.</para>
        /// <para><see cref="uint" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = U34F30.From(1);
        /// System.Assert.AreEqual(1UL &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 From(uint num) {
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
        /// var a = U34F30.StrictFrom(1);
        /// System.Assert.AreEqual(1UL &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 StrictFrom(long num) {
            return FromBits(checked((ulong)num * OneRepr));
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
        /// var a = U34F30.UncheckedFrom(1);
        /// System.Assert.AreEqual(1UL &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 UncheckedFrom(long num) {
            return FromBits(unchecked((ulong)num * OneRepr));
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
        /// var a = U34F30.CheckedFrom(1);
        /// System.Assert.AreEqual(1UL &lt;&lt; 30, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30? CheckedFrom(long num) {

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
        /// var a = U34F30.StrictFrom(1);
        /// System.Assert.AreEqual(1UL &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 StrictFrom(ulong num) {
            return FromBits(checked((ulong)num * OneRepr));
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
        /// var a = U34F30.UncheckedFrom(1);
        /// System.Assert.AreEqual(1UL &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 UncheckedFrom(ulong num) {
            return FromBits(unchecked((ulong)num * OneRepr));
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
        /// var a = U34F30.CheckedFrom(1);
        /// System.Assert.AreEqual(1UL &lt;&lt; 30, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30? CheckedFrom(ulong num) {

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (num > MaxRepr / OneRepr ||
                num < MinRepr / OneRepr) {
                return null;
            }

            return FromBits((ulong)num * OneRepr);
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
        /// var a = U34F30.StrictFrom(1.0f);
        /// System.Assert.AreEqual(1UL &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 StrictFrom(float num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((ulong)(num * OneRepr)));
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
        /// var a = U34F30.UncheckedFrom(1.0f);
        /// System.Assert.AreEqual(1UL &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 UncheckedFrom(float num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(unchecked((ulong)(num * OneRepr)));
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
        /// var a = U34F30.StrictFrom(1.0);
        /// System.Assert.AreEqual(1UL &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 StrictFrom(double num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((ulong)(num * OneRepr)));
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
        /// var a = U34F30.UncheckedFrom(1.0);
        /// System.Assert.AreEqual(1UL &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 UncheckedFrom(double num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(unchecked((ulong)(num * OneRepr)));
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
        public static U34F30 StrictFrom(I17F15 from) {
            return FromBits(checked((ulong)from.Bits * (EpsilonRepr << 15))
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
        public static U34F30 UncheckedFrom(I17F15 from) {
            return FromBits(unchecked((ulong)from.Bits * (EpsilonRepr << 15))
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
        public static U34F30? CheckedFrom(I17F15 from) {
            const int shift = 15;
            const ulong k = EpsilonRepr << shift;
            const ulong max = MaxRepr / k;
            if (from.Bits < 0) {
                return null;
            } else if ((uint)from.Bits > max) {
                return null;
            }
            return FromBits((ulong)from.Bits * k);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F30" /> value.</para>
        /// <para><see cref="I2F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom(I2F30)"/>
        /// <seealso cref="CheckedFrom(I2F30)"/>
        public static U34F30 StrictFrom(I2F30 from) {
            return FromBits(checked((ulong)from.Bits * (EpsilonRepr << 0))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F30" /> value.</para>
        /// <para><see cref="I2F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(I2F30)"/>
        /// <seealso cref="CheckedFrom(I2F30)"/>
        public static U34F30 UncheckedFrom(I2F30 from) {
            return FromBits(unchecked((ulong)from.Bits * (EpsilonRepr << 0))
            );
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
        /// <seealso cref="UncheckedFrom(I2F30)"/>
        public static U34F30? CheckedFrom(I2F30 from) {
            const int shift = 0;
            const ulong k = EpsilonRepr << shift;
            const ulong max = MaxRepr / k;
            if (from.Bits < 0) {
                return null;
            } else if ((uint)from.Bits > max) {
                return null;
            }
            return FromBits((ulong)from.Bits * k);
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
        public static U34F30 StrictFrom(I34F30 from) {
            return FromBits(checked((ulong)from.Bits * (EpsilonRepr << 0))
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
        public static U34F30 UncheckedFrom(I34F30 from) {
            return FromBits(unchecked((ulong)from.Bits * (EpsilonRepr << 0))
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
        public static U34F30? CheckedFrom(I34F30 from) {
            const int shift = 0;
            const ulong k = EpsilonRepr << shift;
            const ulong max = MaxRepr / k;
            if (from.Bits < 0) {
                return null;
            } else if ((ulong)from.Bits > max) {
                return null;
            }
            return FromBits((ulong)from.Bits * k);
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
        public static U34F30 StrictLossyFrom(I33F31 from) {
            return FromBits(checked((ulong)(from.Bits / (I33F31.EpsilonRepr << 1)))
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
        public static U34F30 UncheckedLossyFrom(I33F31 from) {
            return FromBits(unchecked((ulong)(from.Bits / (I33F31.EpsilonRepr << 1)))
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
        public static U34F30? CheckedLossyFrom(I33F31 from) {
            var tmp = from.Bits / (I33F31.EpsilonRepr << 1);
            if (tmp < 0) {
                return null;
            } else if ((ulong)tmp > MaxRepr) {
                return null;
            }
            return FromBits((ulong)tmp);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I4F60" /> value.</para>
        /// <para><see cref="I4F60" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedLossyFrom(I4F60)"/>
        /// <seealso cref="CheckedLossyFrom(I4F60)"/>
        public static U34F30 StrictLossyFrom(I4F60 from) {
            return FromBits(checked((ulong)(from.Bits / (I4F60.EpsilonRepr << 30)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I4F60" /> value.</para>
        /// <para><see cref="I4F60" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(I4F60)"/>
        /// <seealso cref="CheckedLossyFrom(I4F60)"/>
        public static U34F30 UncheckedLossyFrom(I4F60 from) {
            return FromBits(unchecked((ulong)(from.Bits / (I4F60.EpsilonRepr << 30)))
            );
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
        /// <seealso cref="UncheckedLossyFrom(I4F60)"/>
        public static U34F30? CheckedLossyFrom(I4F60 from) {
            var tmp = from.Bits / (I4F60.EpsilonRepr << 30);
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
        /// <seealso cref="UncheckedLossyFrom(I2F62)"/>
        /// <seealso cref="CheckedLossyFrom(I2F62)"/>
        public static U34F30 StrictLossyFrom(I2F62 from) {
            return FromBits(checked((ulong)(from.Bits / (I2F62.EpsilonRepr << 32)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F62" /> value.</para>
        /// <para><see cref="I2F62" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(I2F62)"/>
        /// <seealso cref="CheckedLossyFrom(I2F62)"/>
        public static U34F30 UncheckedLossyFrom(I2F62 from) {
            return FromBits(unchecked((ulong)(from.Bits / (I2F62.EpsilonRepr << 32)))
            );
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
        /// <seealso cref="UncheckedLossyFrom(I2F62)"/>
        public static U34F30? CheckedLossyFrom(I2F62 from) {
            var tmp = from.Bits / (I2F62.EpsilonRepr << 32);
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
        public static U34F30 From(U17F15 from) {
            return FromBits(unchecked((ulong)from.Bits * (EpsilonRepr << 15))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F30" /> value.</para>
        /// <para><see cref="U2F30" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static U34F30 From(U2F30 from) {
            return FromBits(unchecked((ulong)from.Bits * (EpsilonRepr << 0))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U33F31" /> value.</para>
        /// <para><see cref="U33F31" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static U34F30 LossyFrom(U33F31 from) {
            return FromBits(unchecked((ulong)(from.Bits / (U33F31.EpsilonRepr << 1)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U4F60" /> value.</para>
        /// <para><see cref="U4F60" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static U34F30 LossyFrom(U4F60 from) {
            return FromBits(unchecked((ulong)(from.Bits / (U4F60.EpsilonRepr << 30)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F62" /> value.</para>
        /// <para><see cref="U2F62" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static U34F30 LossyFrom(U2F62 from) {
            return FromBits(unchecked((ulong)(from.Bits / (U2F62.EpsilonRepr << 32)))
            );
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
            return unchecked((long)(Bits / OneRepr));
        }

        /// <summary>
        /// <para><see cref="ulong" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong ToUInt64() {
            return unchecked((ulong)(Bits / OneRepr));
        }

        #endregion

        #region Convert to floating-point number

        // 浮動小数点数への変換は必ず成功する。
        // 除算は最適化によって乗算に置き換えられることを期待する。

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public float LossyToSingle() => (float)Bits / OneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public double LossyToDouble() => (double)Bits / OneRepr;

        #endregion

#pragma warning restore CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning restore IDE0004 // 不要なキャストの削除

#pragma warning restore IDE0079 // 不要な抑制を削除します

    }
} // namespace AgatePris.Intar
