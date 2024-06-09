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

    public struct I34F30 : IEquatable<I34F30>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 34;
        public const int FracNbits = 30;

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

        public static readonly I34F30 Zero = FromNum(0);
        public static readonly I34F30 One = FromNum(1);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I34F30(long bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 FromBits(long bits) => new I34F30(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 FromNum(long num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator +(I34F30 left, I34F30 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator -(I34F30 left, I34F30 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator *(I34F30 left, I34F30 right) {
            Int128 l = left.Bits;
            return FromBits((long)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator /(I34F30 left, I34F30 right) {
            Int128 l = left.Bits;
            return FromBits((long)(l * oneRepr / right.Bits));
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I34F30 operator -(I34F30 x) => FromBits(-x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I34F30 lhs, I34F30 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I34F30 lhs, I34F30 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I34F30 left, I34F30 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I34F30 left, I34F30 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I34F30 left, I34F30 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I34F30 left, I34F30 right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 Min(I34F30 other) => FromBits(System.Math.Min(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 Max(I34F30 other) => FromBits(System.Math.Max(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 Clamp(I34F30 min, I34F30 max) => FromBits(Math.Clamp(bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I33F31 LosslessMul(I63F1 other) => I33F31.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I32F32 LosslessMul(I62F2 other) => I32F32.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I31F33 LosslessMul(I61F3 other) => I31F33.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I30F34 LosslessMul(I60F4 other) => I30F34.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I29F35 LosslessMul(I59F5 other) => I29F35.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I28F36 LosslessMul(I58F6 other) => I28F36.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I27F37 LosslessMul(I57F7 other) => I27F37.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I26F38 LosslessMul(I56F8 other) => I26F38.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I25F39 LosslessMul(I55F9 other) => I25F39.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I24F40 LosslessMul(I54F10 other) => I24F40.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I23F41 LosslessMul(I53F11 other) => I23F41.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I22F42 LosslessMul(I52F12 other) => I22F42.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I21F43 LosslessMul(I51F13 other) => I21F43.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I20F44 LosslessMul(I50F14 other) => I20F44.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I19F45 LosslessMul(I49F15 other) => I19F45.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F46 LosslessMul(I48F16 other) => I18F46.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F47 LosslessMul(I47F17 other) => I17F47.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I16F48 LosslessMul(I46F18 other) => I16F48.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I15F49 LosslessMul(I45F19 other) => I15F49.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I14F50 LosslessMul(I44F20 other) => I14F50.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I13F51 LosslessMul(I43F21 other) => I13F51.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I12F52 LosslessMul(I42F22 other) => I12F52.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I11F53 LosslessMul(I41F23 other) => I11F53.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I10F54 LosslessMul(I40F24 other) => I10F54.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I9F55 LosslessMul(I39F25 other) => I9F55.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I8F56 LosslessMul(I38F26 other) => I8F56.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I7F57 LosslessMul(I37F27 other) => I7F57.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I6F58 LosslessMul(I36F28 other) => I6F58.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I5F59 LosslessMul(I35F29 other) => I5F59.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I4F60 LosslessMul(I34F30 other) => I4F60.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I3F61 LosslessMul(I33F31 other) => I3F61.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F62 LosslessMul(I32F32 other) => I2F62.FromBits(bits * other.Bits);

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(I34F30 x) => (int)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(I34F30 x) => (uint)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(I34F30 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(I34F30 x) => (ulong)(x.bits / oneRepr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I34F30 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I34F30 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I34F30 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(I34F30 x) => I31F1.FromBits((int)(x.Bits / (1L << 29)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(I34F30 x) => I30F2.FromBits((int)(x.Bits / (1L << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(I34F30 x) => I29F3.FromBits((int)(x.Bits / (1L << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(I34F30 x) => I28F4.FromBits((int)(x.Bits / (1L << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(I34F30 x) => I27F5.FromBits((int)(x.Bits / (1L << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(I34F30 x) => I26F6.FromBits((int)(x.Bits / (1L << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(I34F30 x) => I25F7.FromBits((int)(x.Bits / (1L << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(I34F30 x) => I24F8.FromBits((int)(x.Bits / (1L << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(I34F30 x) => I23F9.FromBits((int)(x.Bits / (1L << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(I34F30 x) => I22F10.FromBits((int)(x.Bits / (1L << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(I34F30 x) => I21F11.FromBits((int)(x.Bits / (1L << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(I34F30 x) => I20F12.FromBits((int)(x.Bits / (1L << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(I34F30 x) => I19F13.FromBits((int)(x.Bits / (1L << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(I34F30 x) => I18F14.FromBits((int)(x.Bits / (1L << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(I34F30 x) => I17F15.FromBits((int)(x.Bits / (1L << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(I34F30 x) => I16F16.FromBits((int)(x.Bits / (1L << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(I34F30 x) => I15F17.FromBits((int)(x.Bits / (1L << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(I34F30 x) => I14F18.FromBits((int)(x.Bits / (1L << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(I34F30 x) => I13F19.FromBits((int)(x.Bits / (1L << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(I34F30 x) => I12F20.FromBits((int)(x.Bits / (1L << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(I34F30 x) => I11F21.FromBits((int)(x.Bits / (1L << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(I34F30 x) => I10F22.FromBits((int)(x.Bits / (1L << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(I34F30 x) => I9F23.FromBits((int)(x.Bits / (1L << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(I34F30 x) => I8F24.FromBits((int)(x.Bits / (1L << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(I34F30 x) => I7F25.FromBits((int)(x.Bits / (1L << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(I34F30 x) => I6F26.FromBits((int)(x.Bits / (1L << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(I34F30 x) => I5F27.FromBits((int)(x.Bits / (1L << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(I34F30 x) => I4F28.FromBits((int)(x.Bits / (1L << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(I34F30 x) => I3F29.FromBits((int)(x.Bits / (1L << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(I34F30 x) => U31F1.FromBits((uint)(x.Bits / (1L << 29)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(I34F30 x) => U30F2.FromBits((uint)(x.Bits / (1L << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(I34F30 x) => U29F3.FromBits((uint)(x.Bits / (1L << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(I34F30 x) => U28F4.FromBits((uint)(x.Bits / (1L << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(I34F30 x) => U27F5.FromBits((uint)(x.Bits / (1L << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(I34F30 x) => U26F6.FromBits((uint)(x.Bits / (1L << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(I34F30 x) => U25F7.FromBits((uint)(x.Bits / (1L << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(I34F30 x) => U24F8.FromBits((uint)(x.Bits / (1L << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(I34F30 x) => U23F9.FromBits((uint)(x.Bits / (1L << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(I34F30 x) => U22F10.FromBits((uint)(x.Bits / (1L << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(I34F30 x) => U21F11.FromBits((uint)(x.Bits / (1L << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(I34F30 x) => U20F12.FromBits((uint)(x.Bits / (1L << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(I34F30 x) => U19F13.FromBits((uint)(x.Bits / (1L << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(I34F30 x) => U18F14.FromBits((uint)(x.Bits / (1L << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(I34F30 x) => U17F15.FromBits((uint)(x.Bits / (1L << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(I34F30 x) => U16F16.FromBits((uint)(x.Bits / (1L << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(I34F30 x) => U15F17.FromBits((uint)(x.Bits / (1L << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(I34F30 x) => U14F18.FromBits((uint)(x.Bits / (1L << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(I34F30 x) => U13F19.FromBits((uint)(x.Bits / (1L << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(I34F30 x) => U12F20.FromBits((uint)(x.Bits / (1L << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(I34F30 x) => U11F21.FromBits((uint)(x.Bits / (1L << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(I34F30 x) => U10F22.FromBits((uint)(x.Bits / (1L << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(I34F30 x) => U9F23.FromBits((uint)(x.Bits / (1L << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(I34F30 x) => U8F24.FromBits((uint)(x.Bits / (1L << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(I34F30 x) => U7F25.FromBits((uint)(x.Bits / (1L << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(I34F30 x) => U6F26.FromBits((uint)(x.Bits / (1L << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(I34F30 x) => U5F27.FromBits((uint)(x.Bits / (1L << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(I34F30 x) => U4F28.FromBits((uint)(x.Bits / (1L << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(I34F30 x) => U3F29.FromBits((uint)(x.Bits / (1L << 1)));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is I34F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<I34F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(I34F30 rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
