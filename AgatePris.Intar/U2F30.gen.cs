using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct U2F30 : IEquatable<U2F30>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 2;
        public const int FracNbits = 30;

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
        U2F30(uint bits) {
            Bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 FromBits(uint bits) => new U2F30(bits);

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
        /// var a = U2F30.FromNum(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 FromNum(uint num) => FromBits(num * OneRepr);

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
        /// var a = U2F30.StrictFromNum(1);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 StrictFromNum(uint num) => FromBits(checked(num * OneRepr));

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
        /// var a = U2F30.FromNum(1.0f);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 FromNum(float num) => FromBits((uint)(num * OneRepr));

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
        /// var a = U2F30.StrictFromNum(1.0f);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 StrictFromNum(float num) => FromBits(checked((uint)(num * OneRepr)));

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
        /// var a = U2F30.FromNum(1.0);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 FromNum(double num) => FromBits((uint)(num * OneRepr));

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
        /// var a = U2F30.StrictFromNum(1.0);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 StrictFromNum(double num) => FromBits(checked((uint)(num * OneRepr)));

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
        /// var a = U2F30.FromNum(1.0m);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 FromNum(decimal num) => FromBits((uint)(num * OneRepr));

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
        /// var a = U2F30.StrictFromNum(1.0m);
        /// System.Assert.AreEqual(1 &lt;&lt; 30, a.Bits);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 StrictFromNum(decimal num) => FromBits(checked((uint)(num * OneRepr)));

        // Static Properties
        // -----------------

        public static U2F30 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(0);
        }
        public static U2F30 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(1);
        }
        public static U2F30 MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(uint.MinValue);
        }
        public static U2F30 MaxValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(uint.MaxValue);
        }

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 operator +(U2F30 left, U2F30 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 operator -(U2F30 left, U2F30 right) {
            return FromBits(left.Bits - right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 operator *(U2F30 left, U2F30 right) {
            ulong l = left.Bits;
            return FromBits((uint)(l * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 operator /(U2F30 left, U2F30 right) {
            ulong l = left.Bits;
            return FromBits((uint)(l * OneRepr / right.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F30 operator +(U2F30 x) => FromBits(+x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(U2F30 lhs, U2F30 rhs) => lhs.Bits == rhs.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(U2F30 lhs, U2F30 rhs) => lhs.Bits != rhs.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U2F30 left, U2F30 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U2F30 left, U2F30 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U2F30 left, U2F30 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U2F30 left, U2F30 right) => left.Bits >= right.Bits;

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(U2F30 x) => (int)(x.Bits / OneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(U2F30 x) => x.Bits / OneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(U2F30 x) => x.Bits / OneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(U2F30 x) => x.Bits / OneRepr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(U2F30 x) {
            const float k = 1.0f / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(U2F30 x) {
            const double k = 1.0 / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(U2F30 x) {
            const decimal k = 1.0M / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(U2F30 x) => I17F15.FromBits((int)(x.Bits / (1U << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(U2F30 x) => I2F30.FromBits((int)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I34F30(U2F30 x) => I34F30.FromBits(x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I33F31(U2F30 x) => I33F31.FromBits(x.Bits * (1L << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I4F60(U2F30 x) => I4F60.FromBits(x.Bits * (1L << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F62(U2F30 x) => I2F62.FromBits(x.Bits * (1L << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(U2F30 x) => U17F15.FromBits(x.Bits / (1U << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U34F30(U2F30 x) => U34F30.FromBits(x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U33F31(U2F30 x) => U33F31.FromBits(x.Bits * (1UL << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U4F60(U2F30 x) => U4F60.FromBits(x.Bits * (1UL << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U2F62(U2F30 x) => U2F62.FromBits(x.Bits * (1UL << 32));

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is U2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<U2F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(U2F30 other) => Bits == other.Bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F30 Min(U2F30 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F30 Max(U2F30 other) => FromBits(Math.Max(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 Clamp(
            U2F30 min, U2F30 max
        ) => FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F30 Half() => FromBits(Mathi.Half(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F30 Twice() => FromBits(Mathi.Twice(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F30 WrappingAdd(U2F30 other) => FromBits(Overflowing.WrappingAdd(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F30 WrappingSub(U2F30 other) => FromBits(Overflowing.WrappingSub(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F30 WrappingMul(U2F30 other) => FromBits(Overflowing.WrappingMul(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F30 WrappingAddSigned(I2F30 other) => FromBits(Overflowing.WrappingAddSigned(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool OverflowingAdd(U2F30 other, out U2F30 result) {
            var b = Overflowing.OverflowingAdd(Bits, other.Bits, out var bits);
            result = FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30? CheckedAdd(U2F30 other) {
            U2F30? @null = null;
            return OverflowingAdd(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 SaturatingAdd(U2F30 other) {
            return FromBits(Overflowing.SaturatingAdd(Bits, other.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool OverflowingMul(U2F30 other, out U2F30 result) {
            var bits = ((ulong)Bits) * other.Bits / OneRepr;
            result = FromBits(unchecked((uint)bits));
            return bits > uint.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30? CheckedMul(U2F30 other) {
            U2F30? @null = null;
            return OverflowingMul(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 SaturatingMul(U2F30 other) {
            return CheckedMul(other) ?? MaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F60 BigMul(I2F30 other) {
            return I4F60.FromBits(Bits * other.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F60 BigMul(U2F30 other) {
            return U4F60.FromBits((ulong)Bits * other.Bits);
        }

        // ベクトル型との演算
        // ------------------

#if AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 SaturatingMul(Vector2U2F30 other) => other.SaturatingMul(this);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 SaturatingMul(Vector3U2F30 other) => other.SaturatingMul(this);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 SaturatingMul(Vector4U2F30 other) => other.SaturatingMul(this);

#endif // AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

    }
} // namespace AgatePris.Intar
