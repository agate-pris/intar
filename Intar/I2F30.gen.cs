using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct I2F30 : IEquatable<I2F30>, IFormattable {
        #region Consts
        public const int IntNbits = 2;
        public const int FracNbits = 30;

        internal const int MinRepr = int.MinValue;
        internal const int MaxRepr = int.MaxValue;
        internal const int EpsilonRepr = 1;

        internal const int OneRepr = 1 << FracNbits;
        internal const int NegativeOneRepr = -OneRepr;
        #endregion
        #region Bits

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public int Bits;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I2F30(int bits) {
            Bits = bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 FromBits(int bits) => new I2F30(bits);
        #endregion
        #region Zero, One, NegativeOne, MinValue, MaxValue, Epsilon

        // > 14.5.6.2 Static field initialization
        // >
        // > ... If a static constructor (S.14.12) exists in the class,
        // > execution of the static field initializers occurs immediately prior to executing that static constructor.
        // > Otherwise, the static field initializers are executed at an implementation-dependent time prior to the first
        // > use of a static field of that class.
        //
        // -- ECMA-334 6th edition June 2022

        public static readonly I2F30 Zero;
        public static readonly I2F30 One = new I2F30(OneRepr);
        public static readonly I2F30 NegativeOne = new I2F30(NegativeOneRepr);
        public static readonly I2F30 MinValue = new I2F30(MinRepr);
        public static readonly I2F30 MaxValue = new I2F30(MaxRepr);
        internal static readonly I2F30 Epsilon = new I2F30(EpsilonRepr);
        #endregion
        #region WideBits
        internal long WideBits {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Bits;
        }
        #endregion
        #region IAdditionOperatos, ISubtractionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 operator +(I2F30 left, I2F30 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 operator -(I2F30 left, I2F30 right) {
            return FromBits(left.Bits - right.Bits);
        }
        #endregion
        #region IMultiplicationOperators, IDivisionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 operator *(I2F30 left, I2F30 right) {
            return FromBits((int)(left.WideBits * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 operator /(I2F30 left, I2F30 right) {
            return FromBits((int)(left.WideBits * OneRepr / right.Bits));
        }
        #endregion
        #region IUnaryPlusOperators, IUnaryNegationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 operator +(I2F30 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 operator -(I2F30 x) => FromBits(-x.Bits);
        #endregion
        #region IEqualityOperators, IComparisonOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(I2F30 left, I2F30 right) => left.Bits == right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(I2F30 left, I2F30 right) => left.Bits != right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I2F30 left, I2F30 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I2F30 left, I2F30 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I2F30 left, I2F30 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I2F30 left, I2F30 right) => left.Bits >= right.Bits;
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is I2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ((double)this).ToString((IFormatProvider)null);
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(I2F30 other) => this == other;
        #endregion
        #region IFormattable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
        #endregion
        #region IComparable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(I2F30 value) {
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
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 Min(I2F30 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 Max(I2F30 other) => FromBits(Math.Max(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 Clamp(I2F30 min, I2F30 max) {
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
        public I2F30 Abs() => FromBits(Math.Abs(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 UnsignedAbs() {
            return U2F30.FromBits(Mathi.UnsignedAbs(Bits));
        }
        #endregion
        #region AbsDiff
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 AbsDiff(I2F30 other) {
            return U2F30.FromBits(Mathi.AbsDiff(Bits, other.Bits));
        }
        #endregion
        #region Half, Twice
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal I2F30 Half() => FromBits(Mathi.Half(Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal I2F30 Twice() => FromBits(Mathi.Twice(Bits));
        #endregion
        #region BigMul

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F60 BigMul(I2F30 other) {
            return I4F60.FromBits(WideBits * other.WideBits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F60 BigMul(U2F30 other) {
            return I4F60.FromBits(Bits * other.Bits);
        }
        #endregion
        #region Atan2

#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable IDE0002 // メンバー アクセスを単純化します

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 Atan2P2(int y, int x) {
            return I2F30.FromBits(Mathi.Atan2P2(y, x));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 Atan2P2(I2F30 other) {
            return I2F30.Atan2P2(Bits, other.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 Atan2P3(int y, int x) {
            return I2F30.FromBits(Mathi.Atan2P3(y, x));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 Atan2P3(I2F30 other) {
            return I2F30.Atan2P3(Bits, other.Bits);
        }

#pragma warning restore IDE0002 // メンバー アクセスを単純化します
#pragma warning restore IDE0079 // 不要な抑制を削除します

        #endregion
        #region Swizzling
        public Vector2I2F30 X0() => Vector2I2F30.FromRepr(new Vector2Int32(Bits, 0));
        public Vector2I2F30 X1() => Vector2I2F30.FromRepr(new Vector2Int32(Bits, OneRepr));
        public Vector2I2F30 XX() => Vector2I2F30.FromRepr(new Vector2Int32(Bits, Bits));
        public Vector3I2F30 XX0() => Vector3I2F30.FromRepr(new Vector3Int32(Bits, Bits, 0));
        public Vector3I2F30 XX1() => Vector3I2F30.FromRepr(new Vector3Int32(Bits, Bits, OneRepr));
        public Vector3I2F30 XXX() => Vector3I2F30.FromRepr(new Vector3Int32(Bits, Bits, Bits));
        public Vector4I2F30 XXX0() => Vector4I2F30.FromRepr(new Vector4Int32(Bits, Bits, Bits, 0));
        public Vector4I2F30 XXX1() => Vector4I2F30.FromRepr(new Vector4Int32(Bits, Bits, Bits, OneRepr));
        public Vector4I2F30 XXXX() => Vector4I2F30.FromRepr(new Vector4Int32(Bits, Bits, Bits, Bits));
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
        public static explicit operator I2F30(int num) {
            return FromBits((int)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="uint" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I2F30(uint num) {
            return FromBits((int)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="long" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I2F30(long num) {
            return FromBits((int)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="ulong" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I2F30(ulong num) {
            return FromBits((int)num * OneRepr);
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="Int128" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I2F30(Int128 num) {
            return FromBits((int)num * OneRepr);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="UInt128" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I2F30(UInt128 num) {
            return FromBits((int)num * OneRepr);
        }

#endif // NET7_0_OR_GREATER

        #endregion
        #region Conversion from floating-point number

        // decimal からの型変換は基数 (Radix) が 2 のべき乗でないため実装しない。

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="float" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I2F30(float num) {
            // OneRepr は 2 の自然数冪であるから,
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない.
            return FromBits((int)(num * (float)OneRepr));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="double" /> value.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator I2F30(double num) {
            // OneRepr は 2 の自然数冪であるから,
            // その乗算および型変換によって精度が失われることは
            // 基数 (Radix) が 2 の自然数冪でない限りない.
            return FromBits((int)(num * (double)OneRepr));
        }
        #endregion
        #region Conversion from fixed-point number

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I17F15" /> value.</para>
        /// </summary>
        public static explicit operator I2F30(I17F15 from) {
            return FromBits((int)from.Bits * (EpsilonRepr << 15));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I34F30" /> value.</para>
        /// </summary>
        public static explicit operator I2F30(I34F30 from) {
            return FromBits((int)from.Bits);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I33F31" /> value.</para>
        /// </summary>
        public static explicit operator I2F30(I33F31 from) {
            return FromBits((int)(from.Bits / (I33F31.EpsilonRepr << 1)));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I4F60" /> value.</para>
        /// </summary>
        public static explicit operator I2F30(I4F60 from) {
            return FromBits((int)(from.Bits / (I4F60.EpsilonRepr << 30)));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I2F62" /> value.</para>
        /// </summary>
        public static explicit operator I2F30(I2F62 from) {
            return FromBits((int)(from.Bits / (I2F62.EpsilonRepr << 32)));
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I68F60" /> value.</para>
        /// </summary>
        public static explicit operator I2F30(I68F60 from) {
            return FromBits((int)(from.Bits / (I68F60.EpsilonRepr << 30)));
        }

#endif // NET7_0_OR_GREATER

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="I8F120" /> value.</para>
        /// </summary>
        public static explicit operator I2F30(I8F120 from) {
            return FromBits((int)(from.Bits / (I8F120.EpsilonRepr << 90)));
        }

#endif // NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U17F15" /> value.</para>
        /// </summary>
        public static explicit operator I2F30(U17F15 from) {
            return FromBits((int)from.Bits * (EpsilonRepr << 15));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F30" /> value.</para>
        /// </summary>
        public static explicit operator I2F30(U2F30 from) {
            return FromBits((int)from.Bits);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U34F30" /> value.</para>
        /// </summary>
        public static explicit operator I2F30(U34F30 from) {
            return FromBits((int)from.Bits);
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U33F31" /> value.</para>
        /// </summary>
        public static explicit operator I2F30(U33F31 from) {
            return FromBits((int)(from.Bits / (U33F31.EpsilonRepr << 1)));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U4F60" /> value.</para>
        /// </summary>
        public static explicit operator I2F30(U4F60 from) {
            return FromBits((int)(from.Bits / (U4F60.EpsilonRepr << 30)));
        }

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U2F62" /> value.</para>
        /// </summary>
        public static explicit operator I2F30(U2F62 from) {
            return FromBits((int)(from.Bits / (U2F62.EpsilonRepr << 32)));
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U68F60" /> value.</para>
        /// </summary>
        public static explicit operator I2F30(U68F60 from) {
            return FromBits((int)(from.Bits / (U68F60.EpsilonRepr << 30)));
        }

#endif // NET7_0_OR_GREATER

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para>Constructs a new fixed-point number from <see cref="U8F120" /> value.</para>
        /// </summary>
        public static explicit operator I2F30(U8F120 from) {
            return FromBits((int)(from.Bits / (U8F120.EpsilonRepr << 90)));
        }

#endif // NET7_0_OR_GREATER

        #endregion
        #region Conversion to integer

        /// <summary>
        /// <para><see cref="int" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(I2F30 v) {
            return (int)(v.Bits / OneRepr);
        }

        /// <summary>
        /// <para><see cref="uint" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(I2F30 v) {
            return (uint)(v.Bits / OneRepr);
        }

        /// <summary>
        /// <para><see cref="long" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long(I2F30 v) {
            return (long)(v.Bits / OneRepr);
        }

        /// <summary>
        /// <para><see cref="ulong" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong(I2F30 v) {
            return (ulong)(v.Bits / OneRepr);
        }

#if NET7_0_OR_GREATER

        /// <summary>
        /// <para><see cref="Int128" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int128(I2F30 v) {
            return (Int128)(v.Bits / OneRepr);
        }

        /// <summary>
        /// <para><see cref="UInt128" /> への変換を行います。</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt128(I2F30 v) {
            return (UInt128)(v.Bits / OneRepr);
        }

#endif // NET7_0_OR_GREATER

        #endregion
        #region Conversion to floating-point number

        // 浮動小数点数への変換は必ず成功する。
        // 除算は最適化によって乗算に置き換えられることを期待する。

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I2F30 v) => (float)v.Bits / (float)OneRepr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I2F30 v) => (double)v.Bits / (double)OneRepr;
        #endregion

#pragma warning restore CS0652 // 整数定数への比較は無意味です。定数が型の範囲外です
#pragma warning restore IDE0004 // 不要なキャストの削除
#pragma warning restore IDE0079 // 不要な抑制を削除します

    }
} // namespace Intar
