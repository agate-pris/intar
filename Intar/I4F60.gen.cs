using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct I4F60 : IEquatable<I4F60>, IFormattable {

        #region Consts

        public const int IntNbits = 4;
        public const int FracNbits = 60;

        internal const long MinRepr = long.MinValue;
        internal const long MaxRepr = long.MaxValue;
        internal const ulong MaxReprUnsigned = MaxRepr;
        internal const long EpsilonRepr = 1;

        internal const long OneRepr = 1L << FracNbits;

        #endregion

        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public long Bits;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion

        #region Constructor, FromBits

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I4F60(long bits) {
            Bits = bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F60 FromBits(long bits) => new I4F60(bits);

        #endregion

        #region Zero, One, MinValue, MaxValue, Epsilon

        // > 14.5.6.2 Static field initialization
        // >
        // > ... If a static constructor (S.14.12) exists in the class,
        // > execution of the static field initializers occurs immediately prior to executing that static constructor.
        // > Otherwise, the static field initializers are executed at an implementation-dependent time prior to the first
        // > use of a static field of that class.
        //
        // -- ECMA-334 6th edition June 2022

        public static readonly I4F60 Zero;
        public static readonly I4F60 One = new I4F60(OneRepr);
        public static readonly I4F60 MinValue = new I4F60(MinRepr);
        public static readonly I4F60 MaxValue = new I4F60(MaxRepr);
        internal static readonly I4F60 Epsilon = new I4F60(EpsilonRepr);

        #endregion

        #region WideBits

#if NET7_0_OR_GREATER

        internal Int128 WideBits {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Bits;
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region IAdditionOperatos, ISubtractionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F60 operator +(I4F60 left, I4F60 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F60 operator -(I4F60 left, I4F60 right) {
            return FromBits(left.Bits - right.Bits);
        }

        #endregion

        #region IMultiplicationOperators, IDivisionOperators

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F60 operator *(I4F60 left, I4F60 right) {
            return FromBits((long)(left.WideBits * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F60 operator /(I4F60 left, I4F60 right) {
            return FromBits((long)(left.WideBits * OneRepr / right.Bits));
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region IUnaryPlusOperators, IUnaryNegationOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F60 operator +(I4F60 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F60 operator -(I4F60 x) => FromBits(-x.Bits);

        #endregion

        #region IEqualityOperators, IComparisonOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(I4F60 left, I4F60 right) => left.Bits == right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(I4F60 left, I4F60 right) => left.Bits != right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I4F60 left, I4F60 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I4F60 left, I4F60 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I4F60 left, I4F60 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I4F60 left, I4F60 right) => left.Bits >= right.Bits;

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is I4F60 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ((double)this).ToString((IFormatProvider)null);

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(I4F60 other) => this == other;

        #endregion

        #region IFormattable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }

        #endregion

        #region IComparable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(I4F60 value) {
            if (this < value) {
                return -1;
            } else if (this > value) {
                return 1;
            } else {
                return 0;
            }
        }

        #endregion

        #region Min, Max, Clamp

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I4F60 Min(I4F60 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I4F60 Max(I4F60 other) => FromBits(Math.Max(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F60 Clamp(I4F60 min, I4F60 max) {
#if NET5_0_OR_GREATER
            return FromBits(Math.Clamp(Bits, min.Bits, max.Bits));
#else
            return FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));
#endif
        }

        #endregion

        #region IsNegative, Abs, UnsignedAbs

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNegative() => Bits < 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F60 Abs() => FromBits(Math.Abs(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F60 UnsignedAbs() {
            return U4F60.FromBits(Mathi.UnsignedAbs(Bits));
        }

        #endregion
        #region AbsDiff
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F60 AbsDiff(I4F60 other) {
            return U4F60.FromBits(Mathi.AbsDiff(Bits, other.Bits));
        }
        #endregion
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal I4F60 Half() => FromBits(Mathi.Half(Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal I4F60 Twice() => FromBits(Mathi.Twice(Bits));

        #region BigMul

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I8F120 BigMul(I4F60 other) {
            return I8F120.FromBits(WideBits * other.WideBits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I8F120 BigMul(U4F60 other) {
            return I8F120.FromBits((Int128)Bits * (Int128)other.Bits);
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region Atan2

#if NET7_0_OR_GREATER

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0002 // メンバー アクセスを単純化します

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 Atan2P2(I4F60 other) {
            return I2F62.Atan2P2(Bits, other.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 Atan2P3(I4F60 other) {
            return I2F62.Atan2P3(Bits, other.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 Atan2P9(I4F60 other) {
            return I2F62.Atan2P9(Bits, other.Bits);
        }

#pragma warning restore IDE0002 // メンバー アクセスを単純化します
#pragma warning restore IDE0079 // 不要な抑制を削除します

#endif // NET7_0_OR_GREATER

        #endregion

        // コード生成の簡単のため、冗長なキャストを許容する。

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning disable IDE0004 // 不要なキャストの削除

        #region Conversion from integer

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="int" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I4F60(int num) {
            return FromBits((long)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="uint" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I4F60(uint num) {
            return FromBits((long)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="long" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I4F60(long num) {
            return FromBits((long)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="ulong" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I4F60(ulong num) {
            return FromBits((long)num * OneRepr);
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="Int128" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I4F60(Int128 num) {
            return FromBits((long)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="UInt128" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I4F60(UInt128 num) {
            return FromBits((long)num * OneRepr);
        }

#endif // NET7_0_OR_GREATER

        #endregion
        #region Conversion from floating-point number

        // decimal からの型変換は基数 (Radix) が 2 のべき乗でないため実装しない。

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="float" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I4F60(float num) {
            // OneRepr は 2 の自然数冪であるから,
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない.
            return FromBits((long)(num * (float)OneRepr));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="double" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I4F60(double num) {
            // OneRepr は 2 の自然数冪であるから,
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない.
            return FromBits((long)(num * (double)OneRepr));
        }

        #endregion
        #region Conversion from fixed-point number

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I17F15" /> value.</para>
        /// </summary>
        public static explicit operator I4F60(I17F15 from) {
            return FromBits((long)from.Bits * (EpsilonRepr << 45));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F30" /> value.</para>
        /// </summary>
        public static explicit operator I4F60(I2F30 from) {
            return FromBits((long)from.Bits * (EpsilonRepr << 30));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I34F30" /> value.</para>
        /// </summary>
        public static explicit operator I4F60(I34F30 from) {
            return FromBits((long)from.Bits * (EpsilonRepr << 30));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I33F31" /> value.</para>
        /// </summary>
        public static explicit operator I4F60(I33F31 from) {
            return FromBits((long)from.Bits * (EpsilonRepr << 29));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F62" /> value.</para>
        /// </summary>
        public static explicit operator I4F60(I2F62 from) {
            return FromBits((long)(from.Bits / (I2F62.EpsilonRepr << 2)));
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I68F60" /> value.</para>
        /// </summary>
        public static explicit operator I4F60(I68F60 from) {
            return FromBits((long)from.Bits);
        }

#endif // NET7_0_OR_GREATER

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I8F120" /> value.</para>
        /// </summary>
        public static explicit operator I4F60(I8F120 from) {
            return FromBits((long)(from.Bits / (I8F120.EpsilonRepr << 60)));
        }

#endif // NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U17F15" /> value.</para>
        /// </summary>
        public static explicit operator I4F60(U17F15 from) {
            return FromBits((long)from.Bits * (EpsilonRepr << 45));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F30" /> value.</para>
        /// </summary>
        public static explicit operator I4F60(U2F30 from) {
            return FromBits((long)from.Bits * (EpsilonRepr << 30));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U34F30" /> value.</para>
        /// </summary>
        public static explicit operator I4F60(U34F30 from) {
            return FromBits((long)from.Bits * (EpsilonRepr << 30));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U33F31" /> value.</para>
        /// </summary>
        public static explicit operator I4F60(U33F31 from) {
            return FromBits((long)from.Bits * (EpsilonRepr << 29));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U4F60" /> value.</para>
        /// </summary>
        public static explicit operator I4F60(U4F60 from) {
            return FromBits((long)from.Bits);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F62" /> value.</para>
        /// </summary>
        public static explicit operator I4F60(U2F62 from) {
            return FromBits((long)(from.Bits / (U2F62.EpsilonRepr << 2)));
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U68F60" /> value.</para>
        /// </summary>
        public static explicit operator I4F60(U68F60 from) {
            return FromBits((long)from.Bits);
        }

#endif // NET7_0_OR_GREATER

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U8F120" /> value.</para>
        /// </summary>
        public static explicit operator I4F60(U8F120 from) {
            return FromBits((long)(from.Bits / (U8F120.EpsilonRepr << 60)));
        }

#endif // NET7_0_OR_GREATER

        #endregion
        #region Conversion to integer

        /// <summary>
        /// <para><see cref="int" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(I4F60 v) {
            return (int)(v.Bits / OneRepr);
        }

        /// <summary>
        /// <para><see cref="uint" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(I4F60 v) {
            return (uint)(v.Bits / OneRepr);
        }

        /// <summary>
        /// <para><see cref="long" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long(I4F60 v) {
            return (long)(v.Bits / OneRepr);
        }

        /// <summary>
        /// <para><see cref="ulong" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong(I4F60 v) {
            return (ulong)(v.Bits / OneRepr);
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para><see cref="Int128" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int128(I4F60 v) {
            return (Int128)(v.Bits / OneRepr);
        }

        /// <summary>
        /// <para><see cref="UInt128" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt128(I4F60 v) {
            return (UInt128)(v.Bits / OneRepr);
        }

#endif // NET7_0_OR_GREATER
        #endregion
        #region Conversion to floating-point number

        // 浮動小数点数への変換は必ず成功する。
        // 除算は最適化によって乗算に置き換えられることを期待する。

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I4F60 v) => (float)v.Bits / (float)OneRepr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I4F60 v) => (double)v.Bits / (double)OneRepr;

        #endregion

#pragma warning restore CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

    }
} // namespace Intar
