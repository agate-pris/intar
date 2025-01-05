using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct U2F62 : IEquatable<U2F62>, IFormattable {

        #region Consts

        public const int IntNbits = 2;
        public const int FracNbits = 62;

        internal const ulong MinRepr = ulong.MinValue;
        internal const ulong MaxRepr = ulong.MaxValue;
        internal const ulong EpsilonRepr = 1;

        internal const ulong OneRepr = 1UL << FracNbits;

        #endregion

        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public ulong Bits;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion

        #region Constructor, FromBits

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        U2F62(ulong bits) {
            Bits = bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 FromBits(ulong bits) => new U2F62(bits);

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

        public static readonly U2F62 Zero;
        public static readonly U2F62 One = new U2F62(OneRepr);
        public static readonly U2F62 MinValue = new U2F62(MinRepr);
        public static readonly U2F62 MaxValue = new U2F62(MaxRepr);
        internal static readonly U2F62 Epsilon = new U2F62(EpsilonRepr);

        #endregion

        #region WideBits

#if NET7_0_OR_GREATER

        internal UInt128 WideBits {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Bits;
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region IAdditionOperatos, ISubtractionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 operator +(U2F62 left, U2F62 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 operator -(U2F62 left, U2F62 right) {
            return FromBits(left.Bits - right.Bits);
        }

        #endregion

        #region IMultiplicationOperators, IDivisionOperators

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 operator *(U2F62 left, U2F62 right) {
            return FromBits((ulong)(left.WideBits * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 operator /(U2F62 left, U2F62 right) {
            return FromBits((ulong)(left.WideBits * OneRepr / right.Bits));
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region IUnaryPlusOperators, IUnaryNegationOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 operator +(U2F62 x) => FromBits(+x.Bits);

        // 符号なし固定小数点数は単項マイナス演算子を持たない。

        #endregion

        #region IEqualityOperators, IComparisonOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(U2F62 left, U2F62 right) => left.Bits == right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(U2F62 left, U2F62 right) => left.Bits != right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U2F62 left, U2F62 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U2F62 left, U2F62 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U2F62 left, U2F62 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U2F62 left, U2F62 right) => left.Bits >= right.Bits;

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is U2F62 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => LossyToDouble().ToString((IFormatProvider)null);

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(U2F62 other) => this == other;

        #endregion

        #region IFormattable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return LossyToDouble().ToString(format, formatProvider);
        }

        #endregion

        #region IComparable

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

        #endregion

        #region Min, Max, Clamp

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 Min(U2F62 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 Max(U2F62 other) => FromBits(Math.Max(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F62 Clamp(U2F62 min, U2F62 max) {
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

        #endregion
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal U2F62 Half() => FromBits(Mathi.Half(Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal U2F62 Twice() => FromBits(Mathi.Twice(Bits));

        #region BigMul

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
        public static explicit operator U2F62(int num) {
            return FromBits((ulong)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="uint" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator U2F62(uint num) {
            return FromBits((ulong)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="long" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator U2F62(long num) {
            return FromBits((ulong)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="ulong" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator U2F62(ulong num) {
            return FromBits((ulong)num * OneRepr);
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="Int128" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator U2F62(Int128 num) {
            return FromBits((ulong)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="UInt128" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator U2F62(UInt128 num) {
            return FromBits((ulong)num * OneRepr);
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region Conversion from floating-point number

        // decimal からの型変換は基数 (Radix) が 2 のべき乗でないため実装しない。

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="float" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator U2F62(float num) {
            // OneRepr は 2 の自然数冪であるから,
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない.
            return FromBits((ulong)(num * (float)OneRepr));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="double" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator U2F62(double num) {
            // OneRepr は 2 の自然数冪であるから,
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない.
            return FromBits((ulong)(num * (double)OneRepr));
        }

        #endregion

        #region Conversion from fixed-point number

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I17F15" /> value.</para>
        /// </summary>
        public static explicit operator U2F62(I17F15 from) {
            return FromBits((ulong)from.Bits * (EpsilonRepr << 47));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F30" /> value.</para>
        /// </summary>
        public static explicit operator U2F62(I2F30 from) {
            return FromBits((ulong)from.Bits * (EpsilonRepr << 32));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I34F30" /> value.</para>
        /// </summary>
        public static explicit operator U2F62(I34F30 from) {
            return FromBits((ulong)from.Bits * (EpsilonRepr << 32));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I33F31" /> value.</para>
        /// </summary>
        public static explicit operator U2F62(I33F31 from) {
            return FromBits((ulong)from.Bits * (EpsilonRepr << 31));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I4F60" /> value.</para>
        /// </summary>
        public static explicit operator U2F62(I4F60 from) {
            return FromBits((ulong)from.Bits * (EpsilonRepr << 2));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F62" /> value.</para>
        /// </summary>
        public static explicit operator U2F62(I2F62 from) {
            return FromBits((ulong)from.Bits);
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I68F60" /> value.</para>
        /// </summary>
        public static explicit operator U2F62(I68F60 from) {
            return FromBits((ulong)from.Bits * (EpsilonRepr << 2));
        }

#endif // NET7_0_OR_GREATER

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I8F120" /> value.</para>
        /// </summary>
        public static explicit operator U2F62(I8F120 from) {
            return FromBits((ulong)(from.Bits / (I8F120.EpsilonRepr << 58)));
        }

#endif // NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U17F15" /> value.</para>
        /// </summary>
        public static explicit operator U2F62(U17F15 from) {
            return FromBits((ulong)from.Bits * (EpsilonRepr << 47));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F30" /> value.</para>
        /// </summary>
        public static explicit operator U2F62(U2F30 from) {
            return FromBits((ulong)from.Bits * (EpsilonRepr << 32));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U34F30" /> value.</para>
        /// </summary>
        public static explicit operator U2F62(U34F30 from) {
            return FromBits((ulong)from.Bits * (EpsilonRepr << 32));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U33F31" /> value.</para>
        /// </summary>
        public static explicit operator U2F62(U33F31 from) {
            return FromBits((ulong)from.Bits * (EpsilonRepr << 31));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U4F60" /> value.</para>
        /// </summary>
        public static explicit operator U2F62(U4F60 from) {
            return FromBits((ulong)from.Bits * (EpsilonRepr << 2));
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U68F60" /> value.</para>
        /// </summary>
        public static explicit operator U2F62(U68F60 from) {
            return FromBits((ulong)from.Bits * (EpsilonRepr << 2));
        }

#endif // NET7_0_OR_GREATER

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U8F120" /> value.</para>
        /// </summary>
        public static explicit operator U2F62(U8F120 from) {
            return FromBits((ulong)(from.Bits / (U8F120.EpsilonRepr << 58)));
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region Convert to integer

        // 整数への変換で小数点以下の精度が失われるのは自明なので
        // わざわざ明記することはしない。

        /// <summary>
        /// <para><see cref="int" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int ToInt32() {
            return unchecked((int)(Bits / OneRepr));
        }

        /// <summary>
        /// <para><see cref="uint" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint ToUInt32() {
            return unchecked((uint)(Bits / OneRepr));
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public float LossyToSingle() => (float)Bits / (float)OneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public double LossyToDouble() => (double)Bits / (double)OneRepr;

        #endregion

#pragma warning restore CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

    }
} // namespace Intar
