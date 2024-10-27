using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct U17F15 : IEquatable<U17F15>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 17;
        public const int FracNbits = 15;

        internal const uint MinRepr = uint.MinValue;
        internal const uint MaxRepr = uint.MaxValue;
        internal const uint EpsilonRepr = 1;

        const uint OneRepr = 1U << FracNbits;

        // Fields
        // ------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public uint Bits;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        U17F15(uint bits) {
            Bits = bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15 FromBits(uint bits) => new U17F15(bits);

        // Static Properties
        // -----------------

        public static U17F15 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new U17F15(0);
        }
        public static U17F15 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new U17F15(OneRepr);
        }
        public static U17F15 MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(MinRepr);
        }
        public static U17F15 MaxValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(MaxRepr);
        }

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15 operator +(U17F15 left, U17F15 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15 operator -(U17F15 left, U17F15 right) {
            return FromBits(left.Bits - right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15 operator *(U17F15 left, U17F15 right) {
            ulong l = left.Bits;
            return FromBits((uint)(l * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15 operator /(U17F15 left, U17F15 right) {
            ulong l = left.Bits;
            return FromBits((uint)(l * OneRepr / right.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15 operator +(U17F15 x) => FromBits(+x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(U17F15 left, U17F15 right) => left.Bits == right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(U17F15 left, U17F15 right) => left.Bits != right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U17F15 left, U17F15 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U17F15 left, U17F15 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U17F15 left, U17F15 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U17F15 left, U17F15 right) => left.Bits >= right.Bits;

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is U17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ToDouble().ToString((IFormatProvider)null);

        // IEquatable<U17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(U17F15 other) => this == other;

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
        public int CompareTo(U17F15 value) {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U17F15 Min(U17F15 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U17F15 Max(U17F15 other) => FromBits(Math.Max(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 Clamp(
            U17F15 min, U17F15 max
        ) => FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U17F15 Half() => FromBits(Mathi.Half(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U17F15 Twice() => FromBits(Mathi.Twice(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool OverflowingAdd(U17F15 other, out U17F15 result) {
            var b = Overflowing.OverflowingAdd(Bits, other.Bits, out var bits);
            result = FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15? CheckedAdd(U17F15 other) {
            U17F15? @null = null;
            var b = OverflowingAdd(other, out var result);
            return b ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 SaturatingAdd(U17F15 other) {
            return FromBits(Overflowing.SaturatingAdd(Bits, other.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool OverflowingMul(U17F15 other, out U17F15 result) {
            var bits = ((ulong)Bits) * other.Bits / OneRepr;
            result = FromBits(unchecked((uint)bits));
            return bits < uint.MinValue || bits > uint.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15? CheckedMul(U17F15 other) {
            U17F15? @null = null;
            var b = OverflowingMul(other, out var result);
            return b ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 SaturatingMul(U17F15 other) => CheckedMul(other) ?? MaxValue;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 BigMul(I17F15 other) {
            return I34F30.FromBits(Bits * other.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 BigMul(U17F15 other) {
            return U34F30.FromBits((ulong)Bits * other.Bits);
        }

        // ベクトル型との演算
        // ------------------

#if AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U17F15 SaturatingMul(Vector2U17F15 other) => other.SaturatingMul(this);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U17F15 SaturatingMul(Vector3U17F15 other) => other.SaturatingMul(this);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U17F15 SaturatingMul(Vector4U17F15 other) => other.SaturatingMul(this);

#endif // AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

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
        /// var a = U17F15.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15? CheckedFrom(int num) {

            // 自身が符号なしで、相手が符号ありの場合、
            // 相手が 0 未満、または
            // 相手が自身の最大値よりも大きければ null
            if (num < 0) {
                return null;
            } else if ((uint)num > MaxRepr / OneRepr) {
                return null;
            }

            return FromBits((uint)num * OneRepr);
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
        /// var a = U17F15.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15 StrictFrom(int num) {
            return FromBits(checked((uint)num * OneRepr));
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
        /// var a = U17F15.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15? CheckedFrom(uint num) {

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (num > MaxRepr / OneRepr ||
                num < MinRepr / OneRepr) {
                return null;
            }

            return FromBits((uint)num * OneRepr);
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
        /// var a = U17F15.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15 StrictFrom(uint num) {
            return FromBits(checked((uint)num * OneRepr));
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
        /// var a = U17F15.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15? CheckedFrom(long num) {

            // 自身が符号なしで、相手が符号ありの場合、
            // 相手が 0 未満、または
            // 相手が自身の最大値よりも大きければ null
            if (num < 0) {
                return null;
            } else if ((ulong)num > MaxRepr / OneRepr) {
                return null;
            }

            return FromBits((uint)num * OneRepr);
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
        /// var a = U17F15.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15 StrictFrom(long num) {
            return FromBits(checked((uint)num * OneRepr));
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
        /// var a = U17F15.CheckedFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a?.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15? CheckedFrom(ulong num) {

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (num > MaxRepr / OneRepr ||
                num < MinRepr / OneRepr) {
                return null;
            }

            return FromBits((uint)num * OneRepr);
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
        /// var a = U17F15.StrictFrom(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15 StrictFrom(ulong num) {
            return FromBits(checked((uint)num * OneRepr));
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
        /// var a = U17F15.StrictFrom(1.0f);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15 StrictFrom(float num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((uint)(num * OneRepr)));
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
        /// var a = U17F15.StrictLossyFrom(1.0f);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15? CheckedFrom(float num) {
            // より大きい型に変換して計算。
            return CheckedLossyFrom(num);
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
        /// var a = U17F15.StrictLossyFrom(1.0);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15? CheckedLossyFrom(double num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            // また、整数の基数は 2 であるから、
            // 自身のビット数よりも相手の仮数部の方が大きい限り、
            // 最大値に 1 足した数と最小値から 1 引いた数は厳密に表現可能である。
            num *= OneRepr;
            if (double.IsNaN(num) ||
                double.IsInfinity(num) ||
                num >= uint.MaxValue + 1.0) {
                return null;
            }
            return FromBits((uint)num);
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
        /// var a = U17F15.StrictLossyFrom(1.0);
        /// System.Assert.AreEqual(1 &lt;&lt; 15, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F15 StrictLossyFrom(double num) {
            // OneRepr は 2 の自然数冪であるから、
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない。
            return FromBits(checked((uint)(num * OneRepr)));
        }

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
        public static U17F15 StrictFrom(I17F15 from) {
            return FromBits(checked((uint)from.Bits * ((uint)1 << 0)));
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
        public static U17F15? CheckedFrom(I17F15 from) {
            if (from.Bits < 0) {
                return null;
            } else if ((uint)from.Bits > MaxRepr / ((uint)1 << 0)) {
                return null;
            }
            return FromBits((uint)from.Bits * ((uint)1 << 0));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F30" /> value.</para>
        /// <para><see cref="I2F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedLossyFrom(I2F30)"/>
        public static U17F15 StrictLossyFrom(I2F30 from) {
            return FromBits(checked((uint)(from.Bits / ((int)1 << 15))));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F30" /> value.</para>
        /// <para><see cref="I2F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(I2F30)"/>
        public static U17F15? CheckedLossyFrom(I2F30 from) {
            var tmp = from.Bits / ((int)1 << 15);
            if (tmp < 0) {
                return null;
            } else if ((uint)tmp > MaxRepr) {
                return null;
            }
            return FromBits((uint)tmp);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I34F30" /> value.</para>
        /// <para><see cref="I34F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedLossyFrom(I34F30)"/>
        public static U17F15 StrictLossyFrom(I34F30 from) {
            return FromBits(checked((uint)(from.Bits / ((long)1 << 15))));
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
        public static U17F15? CheckedLossyFrom(I34F30 from) {
            var tmp = from.Bits / ((long)1 << 15);
            if (tmp < 0) {
                return null;
            } else if ((ulong)tmp > MaxRepr) {
                return null;
            }
            return FromBits((uint)tmp);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I33F31" /> value.</para>
        /// <para><see cref="I33F31" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedLossyFrom(I33F31)"/>
        public static U17F15 StrictLossyFrom(I33F31 from) {
            return FromBits(checked((uint)(from.Bits / ((long)1 << 16))));
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
        public static U17F15? CheckedLossyFrom(I33F31 from) {
            var tmp = from.Bits / ((long)1 << 16);
            if (tmp < 0) {
                return null;
            } else if ((ulong)tmp > MaxRepr) {
                return null;
            }
            return FromBits((uint)tmp);
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
        public static U17F15 StrictLossyFrom(I4F60 from) {
            return FromBits(checked((uint)(from.Bits / ((long)1 << 45))));
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
        public static U17F15? CheckedLossyFrom(I4F60 from) {
            var tmp = from.Bits / ((long)1 << 45);
            if (tmp < 0) {
                return null;
            } else if ((ulong)tmp > MaxRepr) {
                return null;
            }
            return FromBits((uint)tmp);
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
        public static U17F15 StrictLossyFrom(I2F62 from) {
            return FromBits(checked((uint)(from.Bits / ((long)1 << 47))));
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
        public static U17F15? CheckedLossyFrom(I2F62 from) {
            var tmp = from.Bits / ((long)1 << 47);
            if (tmp < 0) {
                return null;
            } else if ((ulong)tmp > MaxRepr) {
                return null;
            }
            return FromBits((uint)tmp);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F30" /> value.</para>
        /// <para><see cref="U2F30" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static U17F15 LossyFrom(U2F30 from) {
            return FromBits((uint)(from.Bits / ((uint)1 << 15)));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U34F30" /> value.</para>
        /// <para><see cref="U34F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedLossyFrom(U34F30)"/>
        public static U17F15 StrictLossyFrom(U34F30 from) {
            return FromBits(checked((uint)(from.Bits / ((ulong)1 << 15))));
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
        public static U17F15? CheckedLossyFrom(U34F30 from) {
            var tmp = from.Bits / ((ulong)1 << 15);
            if (tmp < MinRepr ||
                tmp > MaxRepr) {
                return null;
            }
            return FromBits((uint)tmp);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U33F31" /> value.</para>
        /// <para><see cref="U33F31" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedLossyFrom(U33F31)"/>
        public static U17F15 StrictLossyFrom(U33F31 from) {
            return FromBits(checked((uint)(from.Bits / ((ulong)1 << 16))));
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
        public static U17F15? CheckedLossyFrom(U33F31 from) {
            var tmp = from.Bits / ((ulong)1 << 16);
            if (tmp < MinRepr ||
                tmp > MaxRepr) {
                return null;
            }
            return FromBits((uint)tmp);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U4F60" /> value.</para>
        /// <para><see cref="U4F60" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static U17F15 LossyFrom(U4F60 from) {
            return FromBits((uint)(from.Bits / ((ulong)1 << 45)));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F62" /> value.</para>
        /// <para><see cref="U2F62" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static U17F15 LossyFrom(U2F62 from) {
            return FromBits((uint)(from.Bits / ((ulong)1 << 47)));
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

        #endregion

        #region Convert to floating-point number

        // 浮動小数点数への変換は必ず成功する。
        // 除算は最適化によって乗算に置き換えられることを期待する。

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public float LossyToSingle() => (float)Bits / OneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public double ToDouble() => (double)Bits / OneRepr;

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
        /// <seealso cref="StrictToI17F15"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15? CheckedToI17F15() => I17F15.CheckedFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="I17F15" />.</para>
        /// <para><see cref="I17F15" /> へ変換します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedToI17F15"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15 StrictToI17F15() => I17F15.StrictFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="I2F30" />.</para>
        /// <para><see cref="I2F30" /> へ変換します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToI2F30"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30? CheckedToI2F30() => I2F30.CheckedFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="I2F30" />.</para>
        /// <para><see cref="I2F30" /> へ変換します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedToI2F30"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 StrictToI2F30() => I2F30.StrictFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="I34F30" />.</para>
        /// <para><see cref="I34F30" /> へ変換します。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 ToI34F30() => I34F30.From(this);

        /// <summary>
        /// <para>Converts to <see cref="I33F31" />.</para>
        /// <para><see cref="I33F31" /> へ変換します。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I33F31 ToI33F31() => I33F31.From(this);

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
        /// <para>Converts to <see cref="U2F30" />.</para>
        /// <para><see cref="U2F30" /> へ変換します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToU2F30"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30? CheckedToU2F30() => U2F30.CheckedFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="U2F30" />.</para>
        /// <para><see cref="U2F30" /> へ変換します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="CheckedToU2F30"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 StrictToU2F30() => U2F30.StrictFrom(this);

        /// <summary>
        /// <para>Converts to <see cref="U34F30" />.</para>
        /// <para><see cref="U34F30" /> へ変換します。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 ToU34F30() => U34F30.From(this);

        /// <summary>
        /// <para>Converts to <see cref="U33F31" />.</para>
        /// <para><see cref="U33F31" /> へ変換します。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U33F31 ToU33F31() => U33F31.From(this);

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
