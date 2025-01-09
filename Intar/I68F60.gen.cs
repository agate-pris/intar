#if NET7_0_OR_GREATER

using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct I68F60 : IEquatable<I68F60>, IFormattable {

        #region Consts

        public const int IntNbits = 68;
        public const int FracNbits = 60;

        internal static readonly Int128 MinRepr = Int128.MinValue;
        internal static readonly Int128 MaxRepr = Int128.MaxValue;
        internal static readonly UInt128 MaxReprUnsigned = (UInt128)MaxRepr;
        internal static readonly Int128 EpsilonRepr = 1;

        internal static readonly Int128 OneRepr = (Int128)1 << FracNbits;

        #endregion

        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public Int128 Bits;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion

        #region Constructor, FromBits

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I68F60(Int128 bits) {
            Bits = bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I68F60 FromBits(Int128 bits) => new I68F60(bits);

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

        public static readonly I68F60 Zero;
        public static readonly I68F60 One = new I68F60(OneRepr);
        public static readonly I68F60 MinValue = new I68F60(MinRepr);
        public static readonly I68F60 MaxValue = new I68F60(MaxRepr);
        internal static readonly I68F60 Epsilon = new I68F60(EpsilonRepr);

        #endregion

        #region IAdditionOperatos, ISubtractionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I68F60 operator +(I68F60 left, I68F60 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I68F60 operator -(I68F60 left, I68F60 right) {
            return FromBits(left.Bits - right.Bits);
        }

        #endregion

        #region IUnaryPlusOperators, IUnaryNegationOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I68F60 operator +(I68F60 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I68F60 operator -(I68F60 x) => FromBits(-x.Bits);

        #endregion

        #region IEqualityOperators, IComparisonOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(I68F60 left, I68F60 right) => left.Bits == right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(I68F60 left, I68F60 right) => left.Bits != right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I68F60 left, I68F60 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I68F60 left, I68F60 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I68F60 left, I68F60 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I68F60 left, I68F60 right) => left.Bits >= right.Bits;

        #endregion

        #region Object

        public override bool Equals(object obj) => obj is I68F60 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ((double)this).ToString((IFormatProvider)null);

        #endregion

        #region IEquatable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(I68F60 other) => this == other;

        #endregion

        #region IFormattable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }

        #endregion

        #region IComparable

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(I68F60 value) {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I68F60 Min(I68F60 other) => FromBits(Int128.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I68F60 Max(I68F60 other) => FromBits(Int128.Max(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I68F60 Clamp(I68F60 min, I68F60 max) {
            return FromBits(Int128.Clamp(Bits, min.Bits, max.Bits));
        }

        #endregion

        #region IsNegative, Abs, UnsignedAbs

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNegative() => Bits < 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I68F60 Abs() => FromBits(Int128.Abs(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U68F60 UnsignedAbs() {
            return U68F60.FromBits(Mathi.UnsignedAbs(Bits));
        }

        #endregion
        #region AbsDiff
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U68F60 AbsDiff(I68F60 other) {
            return U68F60.FromBits(Mathi.AbsDiff(Bits, other.Bits));
        }
        #endregion
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal I68F60 Half() => FromBits(Mathi.Half(Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal I68F60 Twice() => FromBits(Mathi.Twice(Bits));

        #region BigMul

        #endregion
        #region Swizzling
        public Vector2I68F60 X0() => Vector2I68F60.FromRepr(new Vector2Int128(Bits, 0));
        public Vector2I68F60 X1() => Vector2I68F60.FromRepr(new Vector2Int128(Bits, OneRepr));
        public Vector2I68F60 XX() => Vector2I68F60.FromRepr(new Vector2Int128(Bits, Bits));
        public Vector3I68F60 XX0() => Vector3I68F60.FromRepr(new Vector3Int128(Bits, Bits, 0));
        public Vector3I68F60 XX1() => Vector3I68F60.FromRepr(new Vector3Int128(Bits, Bits, OneRepr));
        public Vector3I68F60 XXX() => Vector3I68F60.FromRepr(new Vector3Int128(Bits, Bits, Bits));
        public Vector4I68F60 XXX0() => Vector4I68F60.FromRepr(new Vector4Int128(Bits, Bits, Bits, 0));
        public Vector4I68F60 XXX1() => Vector4I68F60.FromRepr(new Vector4Int128(Bits, Bits, Bits, OneRepr));
        public Vector4I68F60 XXXX() => Vector4I68F60.FromRepr(new Vector4Int128(Bits, Bits, Bits, Bits));
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
        public static explicit operator I68F60(int num) {
            return FromBits((Int128)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="uint" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I68F60(uint num) {
            return FromBits((Int128)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="long" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I68F60(long num) {
            return FromBits((Int128)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="ulong" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I68F60(ulong num) {
            return FromBits((Int128)num * OneRepr);
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="Int128" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I68F60(Int128 num) {
            return FromBits((Int128)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="UInt128" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I68F60(UInt128 num) {
            return FromBits((Int128)num * OneRepr);
        }

#endif // NET7_0_OR_GREATER

        #endregion
        #region Conversion from floating-point number

        // decimal からの型変換は基数 (Radix) が 2 のべき乗でないため実装しない。

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="float" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I68F60(float num) {
            // OneRepr は 2 の自然数冪であるから,
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない.
            return FromBits((Int128)(num * (float)OneRepr));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="double" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I68F60(double num) {
            // OneRepr は 2 の自然数冪であるから,
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない.
            return FromBits((Int128)(num * (double)OneRepr));
        }

        #endregion
        #region Conversion from fixed-point number

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I17F15" /> value.</para>
        /// </summary>
        public static explicit operator I68F60(I17F15 from) {
            return FromBits((Int128)from.Bits * (EpsilonRepr << 45));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F30" /> value.</para>
        /// </summary>
        public static explicit operator I68F60(I2F30 from) {
            return FromBits((Int128)from.Bits * (EpsilonRepr << 30));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I34F30" /> value.</para>
        /// </summary>
        public static explicit operator I68F60(I34F30 from) {
            return FromBits((Int128)from.Bits * (EpsilonRepr << 30));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I33F31" /> value.</para>
        /// </summary>
        public static explicit operator I68F60(I33F31 from) {
            return FromBits((Int128)from.Bits * (EpsilonRepr << 29));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I4F60" /> value.</para>
        /// </summary>
        public static explicit operator I68F60(I4F60 from) {
            return FromBits((Int128)from.Bits);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F62" /> value.</para>
        /// </summary>
        public static explicit operator I68F60(I2F62 from) {
            return FromBits((Int128)(from.Bits / (I2F62.EpsilonRepr << 2)));
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I8F120" /> value.</para>
        /// </summary>
        public static explicit operator I68F60(I8F120 from) {
            return FromBits((Int128)(from.Bits / (I8F120.EpsilonRepr << 60)));
        }

#endif // NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U17F15" /> value.</para>
        /// </summary>
        public static explicit operator I68F60(U17F15 from) {
            return FromBits((Int128)from.Bits * (EpsilonRepr << 45));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F30" /> value.</para>
        /// </summary>
        public static explicit operator I68F60(U2F30 from) {
            return FromBits((Int128)from.Bits * (EpsilonRepr << 30));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U34F30" /> value.</para>
        /// </summary>
        public static explicit operator I68F60(U34F30 from) {
            return FromBits((Int128)from.Bits * (EpsilonRepr << 30));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U33F31" /> value.</para>
        /// </summary>
        public static explicit operator I68F60(U33F31 from) {
            return FromBits((Int128)from.Bits * (EpsilonRepr << 29));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U4F60" /> value.</para>
        /// </summary>
        public static explicit operator I68F60(U4F60 from) {
            return FromBits((Int128)from.Bits);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F62" /> value.</para>
        /// </summary>
        public static explicit operator I68F60(U2F62 from) {
            return FromBits((Int128)(from.Bits / (U2F62.EpsilonRepr << 2)));
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U68F60" /> value.</para>
        /// </summary>
        public static explicit operator I68F60(U68F60 from) {
            return FromBits((Int128)from.Bits);
        }

#endif // NET7_0_OR_GREATER

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U8F120" /> value.</para>
        /// </summary>
        public static explicit operator I68F60(U8F120 from) {
            return FromBits((Int128)(from.Bits / (U8F120.EpsilonRepr << 60)));
        }

#endif // NET7_0_OR_GREATER

        #endregion
        #region Conversion to integer

        /// <summary>
        /// <para><see cref="int" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(I68F60 v) {
            return (int)(v.Bits / OneRepr);
        }

        /// <summary>
        /// <para><see cref="uint" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(I68F60 v) {
            return (uint)(v.Bits / OneRepr);
        }

        /// <summary>
        /// <para><see cref="long" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long(I68F60 v) {
            return (long)(v.Bits / OneRepr);
        }

        /// <summary>
        /// <para><see cref="ulong" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong(I68F60 v) {
            return (ulong)(v.Bits / OneRepr);
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para><see cref="Int128" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int128(I68F60 v) {
            return (Int128)(v.Bits / OneRepr);
        }

        /// <summary>
        /// <para><see cref="UInt128" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt128(I68F60 v) {
            return (UInt128)(v.Bits / OneRepr);
        }

#endif // NET7_0_OR_GREATER
        #endregion
        #region Conversion to floating-point number

        // 浮動小数点数への変換は必ず成功する。
        // 除算は最適化によって乗算に置き換えられることを期待する。

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I68F60 v) => (float)v.Bits / (float)OneRepr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I68F60 v) => (double)v.Bits / (double)OneRepr;

        #endregion

#pragma warning restore CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

    }
} // namespace Intar

#endif // NET7_0_OR_GREATER
