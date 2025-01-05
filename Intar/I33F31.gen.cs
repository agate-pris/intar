using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct I33F31 : IEquatable<I33F31>, IFormattable {

        #region Consts

        public const int IntNbits = 33;
        public const int FracNbits = 31;

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
        I33F31(long bits) {
            Bits = bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I33F31 FromBits(long bits) => new I33F31(bits);

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

        public static readonly I33F31 Zero;
        public static readonly I33F31 One = new I33F31(OneRepr);
        public static readonly I33F31 MinValue = new I33F31(MinRepr);
        public static readonly I33F31 MaxValue = new I33F31(MaxRepr);
        internal static readonly I33F31 Epsilon = new I33F31(EpsilonRepr);

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
        public static I33F31 operator +(I33F31 left, I33F31 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I33F31 operator -(I33F31 left, I33F31 right) {
            return FromBits(left.Bits - right.Bits);
        }

        #endregion

        #region IMultiplicationOperators, IDivisionOperators

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I33F31 operator *(I33F31 left, I33F31 right) {
            return FromBits((long)(left.WideBits * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I33F31 operator /(I33F31 left, I33F31 right) {
            return FromBits((long)(left.WideBits * OneRepr / right.Bits));
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region IUnaryPlusOperators, IUnaryNegationOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I33F31 operator +(I33F31 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I33F31 operator -(I33F31 x) => FromBits(-x.Bits);

        #endregion

        #region IEqualityOperators, IComparisonOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(I33F31 left, I33F31 right) => left.Bits == right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(I33F31 left, I33F31 right) => left.Bits != right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I33F31 left, I33F31 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I33F31 left, I33F31 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I33F31 left, I33F31 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I33F31 left, I33F31 right) => left.Bits >= right.Bits;

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is I33F31 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => LossyToDouble().ToString((IFormatProvider)null);

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(I33F31 other) => this == other;

        #endregion

        #region IFormattable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return LossyToDouble().ToString(format, formatProvider);
        }

        #endregion

        #region IComparable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(I33F31 value) {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I33F31 Min(I33F31 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I33F31 Max(I33F31 other) => FromBits(Math.Max(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I33F31 Clamp(I33F31 min, I33F31 max) {
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
        public I33F31 Abs() => FromBits(Math.Abs(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U33F31 UnsignedAbs() {
            return U33F31.FromBits(Mathi.UnsignedAbs(Bits));
        }

        #endregion
        #region AbsDiff
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U33F31 AbsDiff(I33F31 other) {
            return U33F31.FromBits(Mathi.AbsDiff(Bits, other.Bits));
        }
        #endregion
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal I33F31 Half() => FromBits(Mathi.Half(Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal I33F31 Twice() => FromBits(Mathi.Twice(Bits));

        #region BigMul

        #endregion

        #region Asin, Acos, Atan

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 AcosP3(long bits) => U2F62.FromBits(Mathi.AcosP3(bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 AsinP3(long bits) => I2F62.FromBits(Mathi.AsinP3(bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F62 AcosP3() => AcosP3(Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 AsinP3() => AsinP3(Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U2F62 AcosP7(long bits) => U2F62.FromBits(Mathi.AcosP7(bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 AsinP7(long bits) => I2F62.FromBits(Mathi.AsinP7(bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F62 AcosP7() => AcosP7(Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 AsinP7() => AsinP7(Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 AtanP2(long x) => I2F62.FromBits(Mathi.AtanP2(x));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 AtanP2() => AtanP2(Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 AtanP3(long x) => I2F62.FromBits(Mathi.AtanP3(x));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 AtanP3() => AtanP3(Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 AtanP9(long x) => I2F62.FromBits(Mathi.AtanP9(x));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 AtanP9() => AtanP9(Bits);

        #endregion

        #region Atan2

#if NET7_0_OR_GREATER

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0002 // メンバー アクセスを単純化します

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 Atan2P2(I33F31 other) {
            return I2F62.Atan2P2(Bits, other.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 Atan2P3(I33F31 other) {
            return I2F62.Atan2P3(Bits, other.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 Atan2P9(I33F31 other) {
            return I2F62.Atan2P9(Bits, other.Bits);
        }

#pragma warning restore IDE0002 // メンバー アクセスを単純化します
#pragma warning restore IDE0079 // 不要な抑制を削除します

#endif // NET7_0_OR_GREATER

        #endregion

        #region Sin, Cos

        /// <summary>
        /// 2 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 SinP2(long x) => I2F62.FromBits(Mathi.SinP2(x));

        /// <summary>
        /// 2 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 SinP2() => SinP2(Bits);

        /// <summary>
        /// 3 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 SinP3(long x) => I2F62.FromBits(Mathi.SinP3(x));

        /// <summary>
        /// 3 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 SinP3() => SinP3(Bits);

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 SinP4(long x) => I2F62.FromBits(Mathi.SinP4(x));

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 SinP4() => SinP4(Bits);

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 SinP5(long x) => I2F62.FromBits(Mathi.SinP5(x));

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 SinP5() => SinP5(Bits);

        /// <summary>
        /// 10 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 SinP10(long x) => I2F62.FromBits(Mathi.SinP10(x));

        /// <summary>
        /// 10 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 SinP10() => SinP10(Bits);

        /// <summary>
        /// 11 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 SinP11(long x) => I2F62.FromBits(Mathi.SinP11(x));

        /// <summary>
        /// 11 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 SinP11() => SinP11(Bits);

        /// <summary>
        /// 2 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 CosP2(long x) => I2F62.FromBits(Mathi.CosP2(x));

        /// <summary>
        /// 2 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 CosP2() => CosP2(Bits);

        /// <summary>
        /// 3 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 CosP3(long x) => I2F62.FromBits(Mathi.CosP3(x));

        /// <summary>
        /// 3 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 CosP3() => CosP3(Bits);

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 CosP4(long x) => I2F62.FromBits(Mathi.CosP4(x));

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 CosP4() => CosP4(Bits);

        /// <summary>
        /// 5 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 CosP5(long x) => I2F62.FromBits(Mathi.CosP5(x));

        /// <summary>
        /// 5 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 CosP5() => CosP5(Bits);

        /// <summary>
        /// 10 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 CosP10(long x) => I2F62.FromBits(Mathi.CosP10(x));

        /// <summary>
        /// 10 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 CosP10() => CosP10(Bits);

        /// <summary>
        /// 11 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F62 CosP11(long x) => I2F62.FromBits(Mathi.CosP11(x));

        /// <summary>
        /// 11 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F62 CosP11() => CosP11(Bits);

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
        public static explicit operator I33F31(int num) {
            return FromBits((long)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="uint" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I33F31(uint num) {
            return FromBits((long)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="long" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I33F31(long num) {
            return FromBits((long)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="ulong" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I33F31(ulong num) {
            return FromBits((long)num * OneRepr);
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="Int128" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I33F31(Int128 num) {
            return FromBits((long)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="UInt128" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I33F31(UInt128 num) {
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
        public static explicit operator I33F31(float num) {
            // OneRepr は 2 の自然数冪であるから,
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない.
            return FromBits(((long)(num * (float)OneRepr)));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="double" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I33F31(double num) {
            // OneRepr は 2 の自然数冪であるから,
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない.
            return FromBits(((long)(num * (double)OneRepr)));
        }

        #endregion

        #region Convert from fixed-point number

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I17F15" /> value.</para>
        /// <para><see cref="I17F15" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I33F31 From(I17F15 from) {
            return FromBits(unchecked((long)from.Bits * (EpsilonRepr << 16))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F30" /> value.</para>
        /// <para><see cref="I2F30" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I33F31 From(I2F30 from) {
            return FromBits(unchecked((long)from.Bits * (EpsilonRepr << 1))
            );
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
        public static I33F31 StrictFrom(I34F30 from) {
            return FromBits(checked((long)from.Bits * (EpsilonRepr << 1))
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
        public static I33F31 UncheckedFrom(I34F30 from) {
            return FromBits(unchecked((long)from.Bits * (EpsilonRepr << 1))
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
        public static I33F31? CheckedFrom(I34F30 from) {
            const int shift = 1;
            const long k = EpsilonRepr << shift;
            const long max = MaxRepr / k;
            const long min = MinRepr / k;
            if (from.Bits > max ||
                from.Bits < min) {
                return null;
            }
            return FromBits((long)from.Bits * k);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I4F60" /> value.</para>
        /// <para><see cref="I4F60" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I33F31 LossyFrom(I4F60 from) {
            return FromBits(unchecked((long)(from.Bits / (I4F60.EpsilonRepr << 29)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F62" /> value.</para>
        /// <para><see cref="I2F62" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I33F31 LossyFrom(I2F62 from) {
            return FromBits(unchecked((long)(from.Bits / (I2F62.EpsilonRepr << 31)))
            );
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I68F60" /> value.</para>
        /// <para><see cref="I68F60" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedLossyFrom(I68F60)"/>
        /// <seealso cref="CheckedLossyFrom(I68F60)"/>
        public static I33F31 StrictLossyFrom(I68F60 from) {
            return FromBits(checked((long)(from.Bits / (I68F60.EpsilonRepr << 29)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I68F60" /> value.</para>
        /// <para><see cref="I68F60" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(I68F60)"/>
        /// <seealso cref="CheckedLossyFrom(I68F60)"/>
        public static I33F31 UncheckedLossyFrom(I68F60 from) {
            return FromBits(unchecked((long)(from.Bits / (I68F60.EpsilonRepr << 29)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I68F60" /> value.</para>
        /// <para><see cref="I68F60" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(I68F60)"/>
        /// <seealso cref="UncheckedLossyFrom(I68F60)"/>
        public static I33F31? CheckedLossyFrom(I68F60 from) {
            var tmp = from.Bits / (I68F60.EpsilonRepr << 29);
            if (tmp < MinRepr ||
                tmp > MaxRepr) {
                return null;
            }
            return FromBits((long)tmp);
        }

#endif // NET7_0_OR_GREATER

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I8F120" /> value.</para>
        /// <para><see cref="I8F120" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I33F31 LossyFrom(I8F120 from) {
            return FromBits(unchecked((long)(from.Bits / (I8F120.EpsilonRepr << 89)))
            );
        }

#endif // NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U17F15" /> value.</para>
        /// <para><see cref="U17F15" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I33F31 From(U17F15 from) {
            return FromBits(unchecked((long)from.Bits * (EpsilonRepr << 16))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F30" /> value.</para>
        /// <para><see cref="U2F30" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I33F31 From(U2F30 from) {
            return FromBits(unchecked((long)from.Bits * (EpsilonRepr << 1))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U34F30" /> value.</para>
        /// <para><see cref="U34F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom(U34F30)"/>
        /// <seealso cref="CheckedFrom(U34F30)"/>
        public static I33F31 StrictFrom(U34F30 from) {
            return FromBits(checked((long)from.Bits * (EpsilonRepr << 1))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U34F30" /> value.</para>
        /// <para><see cref="U34F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(U34F30)"/>
        /// <seealso cref="CheckedFrom(U34F30)"/>
        public static I33F31 UncheckedFrom(U34F30 from) {
            return FromBits(unchecked((long)from.Bits * (EpsilonRepr << 1))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U34F30" /> value.</para>
        /// <para><see cref="U34F30" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(U34F30)"/>
        /// <seealso cref="UncheckedFrom(U34F30)"/>
        public static I33F31? CheckedFrom(U34F30 from) {
            const int shift = 1;
            const long k = EpsilonRepr << shift;
            const long max = MaxRepr / k;
            if (from.Bits > (ulong)max) {
                return null;
            }
            return FromBits((long)from.Bits * k);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U33F31" /> value.</para>
        /// <para><see cref="U33F31" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedFrom(U33F31)"/>
        /// <seealso cref="CheckedFrom(U33F31)"/>
        public static I33F31 StrictFrom(U33F31 from) {
            return FromBits(checked((long)from.Bits * (EpsilonRepr << 0))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U33F31" /> value.</para>
        /// <para><see cref="U33F31" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(U33F31)"/>
        /// <seealso cref="CheckedFrom(U33F31)"/>
        public static I33F31 UncheckedFrom(U33F31 from) {
            return FromBits(unchecked((long)from.Bits * (EpsilonRepr << 0))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U33F31" /> value.</para>
        /// <para><see cref="U33F31" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictFrom(U33F31)"/>
        /// <seealso cref="UncheckedFrom(U33F31)"/>
        public static I33F31? CheckedFrom(U33F31 from) {
            const int shift = 0;
            const long k = EpsilonRepr << shift;
            const long max = MaxRepr / k;
            if (from.Bits > (ulong)max) {
                return null;
            }
            return FromBits((long)from.Bits * k);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U4F60" /> value.</para>
        /// <para><see cref="U4F60" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I33F31 LossyFrom(U4F60 from) {
            return FromBits(unchecked((long)(from.Bits / (U4F60.EpsilonRepr << 29)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F62" /> value.</para>
        /// <para><see cref="U2F62" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I33F31 LossyFrom(U2F62 from) {
            return FromBits(unchecked((long)(from.Bits / (U2F62.EpsilonRepr << 31)))
            );
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U68F60" /> value.</para>
        /// <para><see cref="U68F60" /> から新しく固定小数点数を構築します。</para>
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedLossyFrom(U68F60)"/>
        /// <seealso cref="CheckedLossyFrom(U68F60)"/>
        public static I33F31 StrictLossyFrom(U68F60 from) {
            return FromBits(checked((long)(from.Bits / (U68F60.EpsilonRepr << 29)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U68F60" /> value.</para>
        /// <para><see cref="U68F60" /> から新しく固定小数点数を構築します。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(U68F60)"/>
        /// <seealso cref="CheckedLossyFrom(U68F60)"/>
        public static I33F31 UncheckedLossyFrom(U68F60 from) {
            return FromBits(unchecked((long)(from.Bits / (U68F60.EpsilonRepr << 29)))
            );
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U68F60" /> value.</para>
        /// <para><see cref="U68F60" /> から新しく固定小数点数を構築します。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictLossyFrom(U68F60)"/>
        /// <seealso cref="UncheckedLossyFrom(U68F60)"/>
        public static I33F31? CheckedLossyFrom(U68F60 from) {
            var tmp = from.Bits / (U68F60.EpsilonRepr << 29);
            if (tmp > MaxReprUnsigned) {
                return null;
            }
            return FromBits((long)tmp);
        }

#endif // NET7_0_OR_GREATER

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U8F120" /> value.</para>
        /// <para><see cref="U8F120" /> から新しく固定小数点数を構築します。</para>
        /// </summary>
        public static I33F31 LossyFrom(U8F120 from) {
            return FromBits(unchecked((long)(from.Bits / (U8F120.EpsilonRepr << 89)))
            );
        }

#endif // NET7_0_OR_GREATER

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

            // 自身と相手の符号が同じ場合、
            // 暗黙に大きい方の型にキャストされる。
            if (tmp < int.MinValue ||
                tmp > int.MaxValue) {
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

            // 自身が符号ありで、相手が符号なしの場合、
            // 自身が 0 未満、または
            // 自身が相手の最大値よりも大きければ null
            if (tmp < 0) {
                return null;
            } else if ((ulong)tmp > uint.MaxValue) {
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
        /// <div class="WARNING alert alert-info">
        /// <h5>Warning</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは例外を送出します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="UncheckedToUInt64"/>
        /// <seealso cref="CheckedToUInt64"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong StrictToUInt64() {
            return checked((ulong)(Bits / OneRepr));
        }

        /// <summary>
        /// <para><see cref="ulong" /> への変換を行います。</para>
        /// <div class="CAUTION alert alert-info">
        /// <h5>Caution</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは誤った値を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToUInt64"/>
        /// <seealso cref="CheckedToUInt64"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong UncheckedToUInt64() {
            return unchecked((ulong)(Bits / OneRepr));
        }

        /// <summary>
        /// <para><see cref="ulong" /> への変換を行います。</para>
        /// <div class="NOTE alert alert-info">
        /// <h5>Note</h5>
        /// <para>結果が表現できる値の範囲外の場合、このメソッドは <c>null</c> を返します。</para>
        /// </div>
        /// </summary>
        /// <seealso cref="StrictToUInt64"/>
        /// <seealso cref="UncheckedToUInt64"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong? CheckedToUInt64() {
            var tmp = Bits / OneRepr;

            // 自身が符号ありで、相手が符号なしの場合、
            // 自身が 0 未満、または
            // 自身が相手の最大値よりも大きければ null
            if (tmp < 0) {
                return null;
            } else if ((ulong)tmp > ulong.MaxValue) {
                return null;
            }

            return (ulong)tmp;
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
