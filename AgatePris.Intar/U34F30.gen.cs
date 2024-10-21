using System;
using System.Runtime.CompilerServices;

#if NET7_0_OR_GREATER

using  U128 = System.UInt128;

#endif // NET7_0_OR_GREATER

namespace AgatePris.Intar {
    [Serializable]
    public struct U34F30 : IEquatable<U34F30>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 34;
        public const int FracNbits = 30;

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
        U34F30(ulong bits) {
            Bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 FromBits(ulong bits) => new U34F30(bits);

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified num.</para>
        /// <para>指定された数値から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドはオーバーフローを引き起こします。その場合の動作はビルド時の既定のオーバーフロー チェック コンテキストに従います。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = U34F30.FromNum(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 FromNum(ulong num) => FromBits(num * OneRepr);

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
        /// var a = U34F30.StrictFromNum(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 StrictFromNum(ulong num) => FromBits(checked(num * OneRepr));

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified num.</para>
        /// <para>指定された数値から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドはオーバーフローを引き起こします。その場合の動作はビルド時の既定のオーバーフロー チェック コンテキストに従います。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = U34F30.FromNum(1.0f);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 FromNum(float num) => FromBits((ulong)(num * OneRepr));

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
        /// var a = U34F30.StrictFromNum(1.0f);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 StrictFromNum(float num) => FromBits(checked((ulong)(num * OneRepr)));

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified num.</para>
        /// <para>指定された数値から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドはオーバーフローを引き起こします。その場合の動作はビルド時の既定のオーバーフロー チェック コンテキストに従います。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = U34F30.FromNum(1.0);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 FromNum(double num) => FromBits((ulong)(num * OneRepr));

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
        /// var a = U34F30.StrictFromNum(1.0);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 StrictFromNum(double num) => FromBits(checked((ulong)(num * OneRepr)));

        /// <summary>
        /// <para>Constructs a new fixed-point number from specified num.</para>
        /// <para>指定された数値から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドはオーバーフローを引き起こします。その場合の動作はビルド時の既定のオーバーフロー チェック コンテキストに従います。</para>
        /// </div>
        /// </summary>
        /// <example>
        /// Basic usage:
        /// <code>
        /// var a = U34F30.FromNum(1.0m);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 FromNum(decimal num) => FromBits((ulong)(num * OneRepr));

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
        /// var a = U34F30.StrictFromNum(1.0m);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 StrictFromNum(decimal num) => FromBits(checked((ulong)(num * OneRepr)));

        // Static Properties
        // -----------------

        public static U34F30 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(0);
        }
        public static U34F30 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(1);
        }
        public static U34F30 MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(ulong.MinValue);
        }
        public static U34F30 MaxValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(ulong.MaxValue);
        }

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
            U128 l = left.Bits;
            return FromBits((ulong)(l * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 operator /(U34F30 left, U34F30 right) {
            U128 l = left.Bits;
            return FromBits((ulong)(l * OneRepr / right.Bits));
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 operator +(U34F30 x) => FromBits(+x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U34F30 lhs, U34F30 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U34F30 lhs, U34F30 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U34F30 left, U34F30 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U34F30 left, U34F30 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U34F30 left, U34F30 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U34F30 left, U34F30 right) => left.Bits >= right.Bits;

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(U34F30 x) => (int)(x.Bits / OneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(U34F30 x) => (uint)(x.Bits / OneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(U34F30 x) => (long)(x.Bits / OneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(U34F30 x) => x.Bits / OneRepr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(U34F30 x) {
            const float k = 1.0f / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(U34F30 x) {
            const double k = 1.0 / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(U34F30 x) {
            const decimal k = 1.0M / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(U34F30 x) => I17F15.FromBits((int)(x.Bits / (1UL << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(U34F30 x) => I2F30.FromBits((int)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I34F30(U34F30 x) => I34F30.FromBits((long)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I33F31(U34F30 x) => I33F31.FromBits((long)x.Bits * (1L << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F60(U34F30 x) => I4F60.FromBits((long)x.Bits * (1L << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F62(U34F30 x) => I2F62.FromBits((long)x.Bits * (1L << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(U34F30 x) => U17F15.FromBits((uint)(x.Bits / (1UL << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(U34F30 x) => U2F30.FromBits((uint)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U33F31(U34F30 x) => U33F31.FromBits(x.Bits * (1UL << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F60(U34F30 x) => U4F60.FromBits(x.Bits * (1UL << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F62(U34F30 x) => U2F62.FromBits(x.Bits * (1UL << 32));

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is U34F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<U34F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(U34F30 other) => Bits == other.Bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 Min(U34F30 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 Max(U34F30 other) => FromBits(Math.Max(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 Clamp(
            U34F30 min, U34F30 max
        ) => FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 Half() => FromBits(Mathi.Half(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 Twice() => FromBits(Mathi.Twice(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 WrappingAdd(U34F30 other) => FromBits(Overflowing.WrappingAdd(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 WrappingSub(U34F30 other) => FromBits(Overflowing.WrappingSub(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 WrappingMul(U34F30 other) => FromBits(Overflowing.WrappingMul(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 WrappingAddSigned(I34F30 other) => FromBits(Overflowing.WrappingAddSigned(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 LosslessMul(ulong other) => FromBits(Bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U4F60 LosslessMul(U34F30 other) => U4F60.FromBits(Bits * other.Bits);

    }
} // namespace AgatePris.Intar
