using System;
using System.Runtime.CompilerServices;

#if UNITY_5_6_OR_NEWER
using UnityEngine;
#endif

namespace AgatePris.Intar.Fixed {
    [Serializable]

#if !UNITY_5_6_OR_NEWER
    readonly
#endif

    public struct I3F61 : IEquatable<I3F61>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 3;
        public const int FracNbits = 61;

        const long oneRepr = 1L << FracNbits;

        // Fields
        // ------

#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif

        long bits;

        // Properties
        // ----------

        public readonly long Bits {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => bits;
        }

        // Static readonly properties
        // --------------------------

        public static readonly I3F61 Zero = FromNum(0);
        public static readonly I3F61 One = FromNum(1);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I3F61(long bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F61 FromBits(long bits) => new I3F61(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F61 FromNum(long num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F61 operator +(I3F61 left, I3F61 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F61 operator -(I3F61 left, I3F61 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F61 operator *(I3F61 left, I3F61 right) {
            Int128 l = left.Bits;
            return FromBits((long)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F61 operator /(I3F61 left, I3F61 right) {
            Int128 l = left.Bits;
            return FromBits((long)(l * oneRepr / right.Bits));
        }

#endif

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I3F61 lhs, I3F61 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I3F61 lhs, I3F61 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I3F61 left, I3F61 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I3F61 left, I3F61 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I3F61 left, I3F61 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I3F61 left, I3F61 right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F62 LosslessMul(I63F1 other) => I2F62.FromBits(bits * other.Bits);

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(I3F61 x) => (int)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(I3F61 x) => (uint)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(I3F61 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(I3F61 x) => (ulong)(x.bits / oneRepr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I3F61 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I3F61 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I3F61 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(I3F61 x) => I31F1.FromBits((int)(x.Bits / (1L << 60)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(I3F61 x) => I30F2.FromBits((int)(x.Bits / (1L << 59)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(I3F61 x) => I29F3.FromBits((int)(x.Bits / (1L << 58)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(I3F61 x) => I28F4.FromBits((int)(x.Bits / (1L << 57)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(I3F61 x) => I27F5.FromBits((int)(x.Bits / (1L << 56)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(I3F61 x) => I26F6.FromBits((int)(x.Bits / (1L << 55)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(I3F61 x) => I25F7.FromBits((int)(x.Bits / (1L << 54)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(I3F61 x) => I24F8.FromBits((int)(x.Bits / (1L << 53)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(I3F61 x) => I23F9.FromBits((int)(x.Bits / (1L << 52)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(I3F61 x) => I22F10.FromBits((int)(x.Bits / (1L << 51)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(I3F61 x) => I21F11.FromBits((int)(x.Bits / (1L << 50)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(I3F61 x) => I20F12.FromBits((int)(x.Bits / (1L << 49)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(I3F61 x) => I19F13.FromBits((int)(x.Bits / (1L << 48)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(I3F61 x) => I18F14.FromBits((int)(x.Bits / (1L << 47)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(I3F61 x) => I17F15.FromBits((int)(x.Bits / (1L << 46)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(I3F61 x) => I16F16.FromBits((int)(x.Bits / (1L << 45)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(I3F61 x) => I15F17.FromBits((int)(x.Bits / (1L << 44)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(I3F61 x) => I14F18.FromBits((int)(x.Bits / (1L << 43)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(I3F61 x) => I13F19.FromBits((int)(x.Bits / (1L << 42)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(I3F61 x) => I12F20.FromBits((int)(x.Bits / (1L << 41)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(I3F61 x) => I11F21.FromBits((int)(x.Bits / (1L << 40)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(I3F61 x) => I10F22.FromBits((int)(x.Bits / (1L << 39)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(I3F61 x) => I9F23.FromBits((int)(x.Bits / (1L << 38)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(I3F61 x) => I8F24.FromBits((int)(x.Bits / (1L << 37)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(I3F61 x) => I7F25.FromBits((int)(x.Bits / (1L << 36)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(I3F61 x) => I6F26.FromBits((int)(x.Bits / (1L << 35)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(I3F61 x) => I5F27.FromBits((int)(x.Bits / (1L << 34)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(I3F61 x) => I4F28.FromBits((int)(x.Bits / (1L << 33)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(I3F61 x) => I3F29.FromBits((int)(x.Bits / (1L << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(I3F61 x) => I2F30.FromBits((int)(x.Bits / (1L << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(I3F61 x) => U31F1.FromBits((uint)(x.Bits / (1L << 60)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(I3F61 x) => U30F2.FromBits((uint)(x.Bits / (1L << 59)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(I3F61 x) => U29F3.FromBits((uint)(x.Bits / (1L << 58)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(I3F61 x) => U28F4.FromBits((uint)(x.Bits / (1L << 57)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(I3F61 x) => U27F5.FromBits((uint)(x.Bits / (1L << 56)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(I3F61 x) => U26F6.FromBits((uint)(x.Bits / (1L << 55)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(I3F61 x) => U25F7.FromBits((uint)(x.Bits / (1L << 54)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(I3F61 x) => U24F8.FromBits((uint)(x.Bits / (1L << 53)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(I3F61 x) => U23F9.FromBits((uint)(x.Bits / (1L << 52)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(I3F61 x) => U22F10.FromBits((uint)(x.Bits / (1L << 51)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(I3F61 x) => U21F11.FromBits((uint)(x.Bits / (1L << 50)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(I3F61 x) => U20F12.FromBits((uint)(x.Bits / (1L << 49)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(I3F61 x) => U19F13.FromBits((uint)(x.Bits / (1L << 48)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(I3F61 x) => U18F14.FromBits((uint)(x.Bits / (1L << 47)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(I3F61 x) => U17F15.FromBits((uint)(x.Bits / (1L << 46)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(I3F61 x) => U16F16.FromBits((uint)(x.Bits / (1L << 45)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(I3F61 x) => U15F17.FromBits((uint)(x.Bits / (1L << 44)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(I3F61 x) => U14F18.FromBits((uint)(x.Bits / (1L << 43)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(I3F61 x) => U13F19.FromBits((uint)(x.Bits / (1L << 42)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(I3F61 x) => U12F20.FromBits((uint)(x.Bits / (1L << 41)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(I3F61 x) => U11F21.FromBits((uint)(x.Bits / (1L << 40)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(I3F61 x) => U10F22.FromBits((uint)(x.Bits / (1L << 39)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(I3F61 x) => U9F23.FromBits((uint)(x.Bits / (1L << 38)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(I3F61 x) => U8F24.FromBits((uint)(x.Bits / (1L << 37)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(I3F61 x) => U7F25.FromBits((uint)(x.Bits / (1L << 36)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(I3F61 x) => U6F26.FromBits((uint)(x.Bits / (1L << 35)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(I3F61 x) => U5F27.FromBits((uint)(x.Bits / (1L << 34)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(I3F61 x) => U4F28.FromBits((uint)(x.Bits / (1L << 33)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(I3F61 x) => U3F29.FromBits((uint)(x.Bits / (1L << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(I3F61 x) => U2F30.FromBits((uint)(x.Bits / (1L << 31)));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is I3F61 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<I3F61>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(I3F61 rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
