using System;
using System.Runtime.CompilerServices;

#if UNITY_5_6_OR_NEWER
using UnityEngine;
#endif

namespace AgatePris.Intar.Fixed {
    [Serializable]
    public struct I3F29 : IEquatable<I3F29>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 3;
        public const int FracNbits = 29;

        const int oneRepr = 1 << FracNbits;

        // Fields
        // ------

        public int bits;

        // Static readonly properties
        // --------------------------

        public static readonly I3F29 Zero = FromNum(0);
        public static readonly I3F29 One = FromNum(1);
        public static readonly I3F29 MinValue = FromBits(int.MinValue);
        public static readonly I3F29 MaxValue = FromBits(int.MaxValue);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I3F29(int bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F29 FromBits(int bits) => new I3F29(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F29 FromNum(int num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F29 operator +(I3F29 left, I3F29 right) {
            return FromBits(left.bits + right.bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F29 operator -(I3F29 left, I3F29 right) {
            return FromBits(left.bits - right.bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F29 operator *(I3F29 left, I3F29 right) {
            long l = left.bits;
            return FromBits((int)(l * right.bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F29 operator /(I3F29 left, I3F29 right) {
            long l = left.bits;
            return FromBits((int)(l * oneRepr / right.bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F29 operator +(I3F29 x) => FromBits(+x.bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I3F29 operator -(I3F29 x) => FromBits(-x.bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I3F29 lhs, I3F29 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I3F29 lhs, I3F29 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I3F29 left, I3F29 right) => left.bits < right.bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I3F29 left, I3F29 right) => left.bits > right.bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I3F29 left, I3F29 right) => left.bits <= right.bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I3F29 left, I3F29 right) => left.bits >= right.bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I3F29 Min(I3F29 other) => FromBits(Math.Min(bits, other.bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I3F29 Max(I3F29 other) => FromBits(Math.Max(bits, other.bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I3F29 Clamp(I3F29 min, I3F29 max) => FromBits(Mathi.Clamp(bits, min.bits, max.bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I3F29 Abs() => FromBits(System.Math.Abs(bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I3F29 LosslessMul(int other) => FromBits(bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I2F30 LosslessMul(I31F1 other) => I2F30.FromBits(bits * other.bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I35F29 WideningMul(int other) => I35F29.FromBits((long)bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 WideningMul(I31F1 other) => I34F30.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I33F31 WideningMul(I30F2 other) => I33F31.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I32F32 WideningMul(I29F3 other) => I32F32.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I31F33 WideningMul(I28F4 other) => I31F33.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I30F34 WideningMul(I27F5 other) => I30F34.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I29F35 WideningMul(I26F6 other) => I29F35.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I28F36 WideningMul(I25F7 other) => I28F36.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I27F37 WideningMul(I24F8 other) => I27F37.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I26F38 WideningMul(I23F9 other) => I26F38.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I25F39 WideningMul(I22F10 other) => I25F39.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I24F40 WideningMul(I21F11 other) => I24F40.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I23F41 WideningMul(I20F12 other) => I23F41.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I22F42 WideningMul(I19F13 other) => I22F42.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I21F43 WideningMul(I18F14 other) => I21F43.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I20F44 WideningMul(I17F15 other) => I20F44.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I19F45 WideningMul(I16F16 other) => I19F45.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F46 WideningMul(I15F17 other) => I18F46.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F47 WideningMul(I14F18 other) => I17F47.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I16F48 WideningMul(I13F19 other) => I16F48.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I15F49 WideningMul(I12F20 other) => I15F49.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I14F50 WideningMul(I11F21 other) => I14F50.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I13F51 WideningMul(I10F22 other) => I13F51.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I12F52 WideningMul(I9F23 other) => I12F52.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I11F53 WideningMul(I8F24 other) => I11F53.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I10F54 WideningMul(I7F25 other) => I10F54.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I9F55 WideningMul(I6F26 other) => I9F55.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I8F56 WideningMul(I5F27 other) => I8F56.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I7F57 WideningMul(I4F28 other) => I7F57.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I6F58 WideningMul(I3F29 other) => I6F58.FromBits((long)bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I5F59 WideningMul(I2F30 other) => I5F59.FromBits((long)bits * other.bits);

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(I3F29 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(I3F29 x) => (uint)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(I3F29 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(I3F29 x) => (ulong)(x.bits / oneRepr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I3F29 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I3F29 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I3F29 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(I3F29 x) => I31F1.FromBits(x.bits / (1 << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(I3F29 x) => I30F2.FromBits(x.bits / (1 << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(I3F29 x) => I29F3.FromBits(x.bits / (1 << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(I3F29 x) => I28F4.FromBits(x.bits / (1 << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(I3F29 x) => I27F5.FromBits(x.bits / (1 << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(I3F29 x) => I26F6.FromBits(x.bits / (1 << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(I3F29 x) => I25F7.FromBits(x.bits / (1 << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(I3F29 x) => I24F8.FromBits(x.bits / (1 << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(I3F29 x) => I23F9.FromBits(x.bits / (1 << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(I3F29 x) => I22F10.FromBits(x.bits / (1 << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(I3F29 x) => I21F11.FromBits(x.bits / (1 << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(I3F29 x) => I20F12.FromBits(x.bits / (1 << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(I3F29 x) => I19F13.FromBits(x.bits / (1 << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(I3F29 x) => I18F14.FromBits(x.bits / (1 << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(I3F29 x) => I17F15.FromBits(x.bits / (1 << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(I3F29 x) => I16F16.FromBits(x.bits / (1 << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(I3F29 x) => I15F17.FromBits(x.bits / (1 << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(I3F29 x) => I14F18.FromBits(x.bits / (1 << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(I3F29 x) => I13F19.FromBits(x.bits / (1 << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(I3F29 x) => I12F20.FromBits(x.bits / (1 << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(I3F29 x) => I11F21.FromBits(x.bits / (1 << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(I3F29 x) => I10F22.FromBits(x.bits / (1 << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(I3F29 x) => I9F23.FromBits(x.bits / (1 << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(I3F29 x) => I8F24.FromBits(x.bits / (1 << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(I3F29 x) => I7F25.FromBits(x.bits / (1 << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(I3F29 x) => I6F26.FromBits(x.bits / (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(I3F29 x) => I5F27.FromBits(x.bits / (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(I3F29 x) => I4F28.FromBits(x.bits / (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(I3F29 x) => I2F30.FromBits(x.bits * (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(I3F29 x) => U31F1.FromBits((uint)(x.bits / (1 << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(I3F29 x) => U30F2.FromBits((uint)(x.bits / (1 << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(I3F29 x) => U29F3.FromBits((uint)(x.bits / (1 << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(I3F29 x) => U28F4.FromBits((uint)(x.bits / (1 << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(I3F29 x) => U27F5.FromBits((uint)(x.bits / (1 << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(I3F29 x) => U26F6.FromBits((uint)(x.bits / (1 << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(I3F29 x) => U25F7.FromBits((uint)(x.bits / (1 << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(I3F29 x) => U24F8.FromBits((uint)(x.bits / (1 << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(I3F29 x) => U23F9.FromBits((uint)(x.bits / (1 << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(I3F29 x) => U22F10.FromBits((uint)(x.bits / (1 << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(I3F29 x) => U21F11.FromBits((uint)(x.bits / (1 << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(I3F29 x) => U20F12.FromBits((uint)(x.bits / (1 << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(I3F29 x) => U19F13.FromBits((uint)(x.bits / (1 << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(I3F29 x) => U18F14.FromBits((uint)(x.bits / (1 << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(I3F29 x) => U17F15.FromBits((uint)(x.bits / (1 << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(I3F29 x) => U16F16.FromBits((uint)(x.bits / (1 << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(I3F29 x) => U15F17.FromBits((uint)(x.bits / (1 << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(I3F29 x) => U14F18.FromBits((uint)(x.bits / (1 << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(I3F29 x) => U13F19.FromBits((uint)(x.bits / (1 << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(I3F29 x) => U12F20.FromBits((uint)(x.bits / (1 << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(I3F29 x) => U11F21.FromBits((uint)(x.bits / (1 << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(I3F29 x) => U10F22.FromBits((uint)(x.bits / (1 << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(I3F29 x) => U9F23.FromBits((uint)(x.bits / (1 << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(I3F29 x) => U8F24.FromBits((uint)(x.bits / (1 << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(I3F29 x) => U7F25.FromBits((uint)(x.bits / (1 << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(I3F29 x) => U6F26.FromBits((uint)(x.bits / (1 << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(I3F29 x) => U5F27.FromBits((uint)(x.bits / (1 << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(I3F29 x) => U4F28.FromBits((uint)(x.bits / (1 << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(I3F29 x) => U3F29.FromBits((uint)x.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(I3F29 x) => U2F30.FromBits((uint)x.bits * (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I63F1(I3F29 x) => I63F1.FromBits(x.bits / (1 << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I62F2(I3F29 x) => I62F2.FromBits(x.bits / (1 << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I61F3(I3F29 x) => I61F3.FromBits(x.bits / (1 << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I60F4(I3F29 x) => I60F4.FromBits(x.bits / (1 << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I59F5(I3F29 x) => I59F5.FromBits(x.bits / (1 << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I58F6(I3F29 x) => I58F6.FromBits(x.bits / (1 << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I57F7(I3F29 x) => I57F7.FromBits(x.bits / (1 << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I56F8(I3F29 x) => I56F8.FromBits(x.bits / (1 << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I55F9(I3F29 x) => I55F9.FromBits(x.bits / (1 << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I54F10(I3F29 x) => I54F10.FromBits(x.bits / (1 << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I53F11(I3F29 x) => I53F11.FromBits(x.bits / (1 << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I52F12(I3F29 x) => I52F12.FromBits(x.bits / (1 << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I51F13(I3F29 x) => I51F13.FromBits(x.bits / (1 << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I50F14(I3F29 x) => I50F14.FromBits(x.bits / (1 << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I49F15(I3F29 x) => I49F15.FromBits(x.bits / (1 << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I48F16(I3F29 x) => I48F16.FromBits(x.bits / (1 << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I47F17(I3F29 x) => I47F17.FromBits(x.bits / (1 << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I46F18(I3F29 x) => I46F18.FromBits(x.bits / (1 << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I45F19(I3F29 x) => I45F19.FromBits(x.bits / (1 << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I44F20(I3F29 x) => I44F20.FromBits(x.bits / (1 << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I43F21(I3F29 x) => I43F21.FromBits(x.bits / (1 << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I42F22(I3F29 x) => I42F22.FromBits(x.bits / (1 << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I41F23(I3F29 x) => I41F23.FromBits(x.bits / (1 << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I40F24(I3F29 x) => I40F24.FromBits(x.bits / (1 << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I39F25(I3F29 x) => I39F25.FromBits(x.bits / (1 << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I38F26(I3F29 x) => I38F26.FromBits(x.bits / (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I37F27(I3F29 x) => I37F27.FromBits(x.bits / (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I36F28(I3F29 x) => I36F28.FromBits(x.bits / (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I35F29(I3F29 x) => I35F29.FromBits(x.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I34F30(I3F29 x) => I34F30.FromBits(x.bits * (1L << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I33F31(I3F29 x) => I33F31.FromBits(x.bits * (1L << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I32F32(I3F29 x) => I32F32.FromBits(x.bits * (1L << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I31F33(I3F29 x) => I31F33.FromBits(x.bits * (1L << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I30F34(I3F29 x) => I30F34.FromBits(x.bits * (1L << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I29F35(I3F29 x) => I29F35.FromBits(x.bits * (1L << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I28F36(I3F29 x) => I28F36.FromBits(x.bits * (1L << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I27F37(I3F29 x) => I27F37.FromBits(x.bits * (1L << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I26F38(I3F29 x) => I26F38.FromBits(x.bits * (1L << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I25F39(I3F29 x) => I25F39.FromBits(x.bits * (1L << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I24F40(I3F29 x) => I24F40.FromBits(x.bits * (1L << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I23F41(I3F29 x) => I23F41.FromBits(x.bits * (1L << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I22F42(I3F29 x) => I22F42.FromBits(x.bits * (1L << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I21F43(I3F29 x) => I21F43.FromBits(x.bits * (1L << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I20F44(I3F29 x) => I20F44.FromBits(x.bits * (1L << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I19F45(I3F29 x) => I19F45.FromBits(x.bits * (1L << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I18F46(I3F29 x) => I18F46.FromBits(x.bits * (1L << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I17F47(I3F29 x) => I17F47.FromBits(x.bits * (1L << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I16F48(I3F29 x) => I16F48.FromBits(x.bits * (1L << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I15F49(I3F29 x) => I15F49.FromBits(x.bits * (1L << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I14F50(I3F29 x) => I14F50.FromBits(x.bits * (1L << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I13F51(I3F29 x) => I13F51.FromBits(x.bits * (1L << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I12F52(I3F29 x) => I12F52.FromBits(x.bits * (1L << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I11F53(I3F29 x) => I11F53.FromBits(x.bits * (1L << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I10F54(I3F29 x) => I10F54.FromBits(x.bits * (1L << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I9F55(I3F29 x) => I9F55.FromBits(x.bits * (1L << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I8F56(I3F29 x) => I8F56.FromBits(x.bits * (1L << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I7F57(I3F29 x) => I7F57.FromBits(x.bits * (1L << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I6F58(I3F29 x) => I6F58.FromBits(x.bits * (1L << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I5F59(I3F29 x) => I5F59.FromBits(x.bits * (1L << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I4F60(I3F29 x) => I4F60.FromBits(x.bits * (1L << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I3F61(I3F29 x) => I3F61.FromBits(x.bits * (1L << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F62(I3F29 x) => I2F62.FromBits(x.bits * (1L << 33));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U63F1(I3F29 x) => U63F1.FromBits((ulong)(x.bits / (1 << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U62F2(I3F29 x) => U62F2.FromBits((ulong)(x.bits / (1 << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U61F3(I3F29 x) => U61F3.FromBits((ulong)(x.bits / (1 << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U60F4(I3F29 x) => U60F4.FromBits((ulong)(x.bits / (1 << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U59F5(I3F29 x) => U59F5.FromBits((ulong)(x.bits / (1 << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U58F6(I3F29 x) => U58F6.FromBits((ulong)(x.bits / (1 << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U57F7(I3F29 x) => U57F7.FromBits((ulong)(x.bits / (1 << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U56F8(I3F29 x) => U56F8.FromBits((ulong)(x.bits / (1 << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U55F9(I3F29 x) => U55F9.FromBits((ulong)(x.bits / (1 << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U54F10(I3F29 x) => U54F10.FromBits((ulong)(x.bits / (1 << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U53F11(I3F29 x) => U53F11.FromBits((ulong)(x.bits / (1 << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U52F12(I3F29 x) => U52F12.FromBits((ulong)(x.bits / (1 << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U51F13(I3F29 x) => U51F13.FromBits((ulong)(x.bits / (1 << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U50F14(I3F29 x) => U50F14.FromBits((ulong)(x.bits / (1 << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U49F15(I3F29 x) => U49F15.FromBits((ulong)(x.bits / (1 << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U48F16(I3F29 x) => U48F16.FromBits((ulong)(x.bits / (1 << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U47F17(I3F29 x) => U47F17.FromBits((ulong)(x.bits / (1 << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U46F18(I3F29 x) => U46F18.FromBits((ulong)(x.bits / (1 << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U45F19(I3F29 x) => U45F19.FromBits((ulong)(x.bits / (1 << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U44F20(I3F29 x) => U44F20.FromBits((ulong)(x.bits / (1 << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U43F21(I3F29 x) => U43F21.FromBits((ulong)(x.bits / (1 << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U42F22(I3F29 x) => U42F22.FromBits((ulong)(x.bits / (1 << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U41F23(I3F29 x) => U41F23.FromBits((ulong)(x.bits / (1 << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U40F24(I3F29 x) => U40F24.FromBits((ulong)(x.bits / (1 << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U39F25(I3F29 x) => U39F25.FromBits((ulong)(x.bits / (1 << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U38F26(I3F29 x) => U38F26.FromBits((ulong)(x.bits / (1 << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U37F27(I3F29 x) => U37F27.FromBits((ulong)(x.bits / (1 << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U36F28(I3F29 x) => U36F28.FromBits((ulong)(x.bits / (1 << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U35F29(I3F29 x) => U35F29.FromBits((ulong)x.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U34F30(I3F29 x) => U34F30.FromBits((ulong)x.bits * (1UL << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U33F31(I3F29 x) => U33F31.FromBits((ulong)x.bits * (1UL << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U32F32(I3F29 x) => U32F32.FromBits((ulong)x.bits * (1UL << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F33(I3F29 x) => U31F33.FromBits((ulong)x.bits * (1UL << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F34(I3F29 x) => U30F34.FromBits((ulong)x.bits * (1UL << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F35(I3F29 x) => U29F35.FromBits((ulong)x.bits * (1UL << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F36(I3F29 x) => U28F36.FromBits((ulong)x.bits * (1UL << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F37(I3F29 x) => U27F37.FromBits((ulong)x.bits * (1UL << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F38(I3F29 x) => U26F38.FromBits((ulong)x.bits * (1UL << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F39(I3F29 x) => U25F39.FromBits((ulong)x.bits * (1UL << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F40(I3F29 x) => U24F40.FromBits((ulong)x.bits * (1UL << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F41(I3F29 x) => U23F41.FromBits((ulong)x.bits * (1UL << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F42(I3F29 x) => U22F42.FromBits((ulong)x.bits * (1UL << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F43(I3F29 x) => U21F43.FromBits((ulong)x.bits * (1UL << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F44(I3F29 x) => U20F44.FromBits((ulong)x.bits * (1UL << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F45(I3F29 x) => U19F45.FromBits((ulong)x.bits * (1UL << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F46(I3F29 x) => U18F46.FromBits((ulong)x.bits * (1UL << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F47(I3F29 x) => U17F47.FromBits((ulong)x.bits * (1UL << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F48(I3F29 x) => U16F48.FromBits((ulong)x.bits * (1UL << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F49(I3F29 x) => U15F49.FromBits((ulong)x.bits * (1UL << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F50(I3F29 x) => U14F50.FromBits((ulong)x.bits * (1UL << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F51(I3F29 x) => U13F51.FromBits((ulong)x.bits * (1UL << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F52(I3F29 x) => U12F52.FromBits((ulong)x.bits * (1UL << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F53(I3F29 x) => U11F53.FromBits((ulong)x.bits * (1UL << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F54(I3F29 x) => U10F54.FromBits((ulong)x.bits * (1UL << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F55(I3F29 x) => U9F55.FromBits((ulong)x.bits * (1UL << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F56(I3F29 x) => U8F56.FromBits((ulong)x.bits * (1UL << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F57(I3F29 x) => U7F57.FromBits((ulong)x.bits * (1UL << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F58(I3F29 x) => U6F58.FromBits((ulong)x.bits * (1UL << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F59(I3F29 x) => U5F59.FromBits((ulong)x.bits * (1UL << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F60(I3F29 x) => U4F60.FromBits((ulong)x.bits * (1UL << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F61(I3F29 x) => U3F61.FromBits((ulong)x.bits * (1UL << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F62(I3F29 x) => U2F62.FromBits((ulong)x.bits * (1UL << 33));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is I3F29 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<I3F29>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(I3F29 other) => bits == other.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
