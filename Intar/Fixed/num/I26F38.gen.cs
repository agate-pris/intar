using System;
using System.Runtime.CompilerServices;

#if UNITY_5_6_OR_NEWER
using UnityEngine;
#endif

namespace AgatePris.Intar.Fixed {
    [Serializable]
    public struct I26F38 : IEquatable<I26F38>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 26;
        public const int FracNbits = 38;

        const long oneRepr = 1L << FracNbits;

        // Fields
        // ------

        public long bits;

        // Static readonly properties
        // --------------------------

        public static readonly I26F38 Zero = FromNum(0);
        public static readonly I26F38 One = FromNum(1);
        public static readonly I26F38 MinValue = FromBits(long.MinValue);
        public static readonly I26F38 MaxValue = FromBits(long.MaxValue);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I26F38(long bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F38 FromBits(long bits) => new I26F38(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F38 FromNum(long num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F38 operator +(I26F38 left, I26F38 right) {
            return FromBits(left.bits + right.bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F38 operator -(I26F38 left, I26F38 right) {
            return FromBits(left.bits - right.bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F38 operator *(I26F38 left, I26F38 right) {
            Int128 l = left.bits;
            return FromBits((long)(l * right.bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F38 operator /(I26F38 left, I26F38 right) {
            Int128 l = left.bits;
            return FromBits((long)(l * oneRepr / right.bits));
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F38 operator +(I26F38 x) => FromBits(+x.bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I26F38 operator -(I26F38 x) => FromBits(-x.bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I26F38 lhs, I26F38 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I26F38 lhs, I26F38 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I26F38 left, I26F38 right) => left.bits < right.bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I26F38 left, I26F38 right) => left.bits > right.bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I26F38 left, I26F38 right) => left.bits <= right.bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I26F38 left, I26F38 right) => left.bits >= right.bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I26F38 Min(I26F38 other) => FromBits(Math.Min(bits, other.bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I26F38 Max(I26F38 other) => FromBits(Math.Max(bits, other.bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I26F38 Clamp(I26F38 min, I26F38 max) => FromBits(Mathi.Clamp(bits, min.bits, max.bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I26F38 Abs() => FromBits(System.Math.Abs(bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I26F38 LosslessMul(long other) => FromBits(bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I25F39 LosslessMul(I63F1 other) => I25F39.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I24F40 LosslessMul(I62F2 other) => I24F40.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I23F41 LosslessMul(I61F3 other) => I23F41.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I22F42 LosslessMul(I60F4 other) => I22F42.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I21F43 LosslessMul(I59F5 other) => I21F43.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I20F44 LosslessMul(I58F6 other) => I20F44.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I19F45 LosslessMul(I57F7 other) => I19F45.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I18F46 LosslessMul(I56F8 other) => I18F46.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I17F47 LosslessMul(I55F9 other) => I17F47.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I16F48 LosslessMul(I54F10 other) => I16F48.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I15F49 LosslessMul(I53F11 other) => I15F49.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I14F50 LosslessMul(I52F12 other) => I14F50.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I13F51 LosslessMul(I51F13 other) => I13F51.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I12F52 LosslessMul(I50F14 other) => I12F52.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I11F53 LosslessMul(I49F15 other) => I11F53.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I10F54 LosslessMul(I48F16 other) => I10F54.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I9F55 LosslessMul(I47F17 other) => I9F55.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I8F56 LosslessMul(I46F18 other) => I8F56.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I7F57 LosslessMul(I45F19 other) => I7F57.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I6F58 LosslessMul(I44F20 other) => I6F58.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I5F59 LosslessMul(I43F21 other) => I5F59.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I4F60 LosslessMul(I42F22 other) => I4F60.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I3F61 LosslessMul(I41F23 other) => I3F61.FromBits(bits * other.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I2F62 LosslessMul(I40F24 other) => I2F62.FromBits(bits * other.bits);

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(I26F38 x) => (int)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(I26F38 x) => (uint)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(I26F38 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(I26F38 x) => (ulong)(x.bits / oneRepr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I26F38 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I26F38 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I26F38 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(I26F38 x) => I31F1.FromBits((int)(x.bits / (1L << 37)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(I26F38 x) => I30F2.FromBits((int)(x.bits / (1L << 36)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(I26F38 x) => I29F3.FromBits((int)(x.bits / (1L << 35)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(I26F38 x) => I28F4.FromBits((int)(x.bits / (1L << 34)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(I26F38 x) => I27F5.FromBits((int)(x.bits / (1L << 33)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(I26F38 x) => I26F6.FromBits((int)(x.bits / (1L << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(I26F38 x) => I25F7.FromBits((int)(x.bits / (1L << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(I26F38 x) => I24F8.FromBits((int)(x.bits / (1L << 30)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(I26F38 x) => I23F9.FromBits((int)(x.bits / (1L << 29)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(I26F38 x) => I22F10.FromBits((int)(x.bits / (1L << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(I26F38 x) => I21F11.FromBits((int)(x.bits / (1L << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(I26F38 x) => I20F12.FromBits((int)(x.bits / (1L << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(I26F38 x) => I19F13.FromBits((int)(x.bits / (1L << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(I26F38 x) => I18F14.FromBits((int)(x.bits / (1L << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(I26F38 x) => I17F15.FromBits((int)(x.bits / (1L << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(I26F38 x) => I16F16.FromBits((int)(x.bits / (1L << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(I26F38 x) => I15F17.FromBits((int)(x.bits / (1L << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(I26F38 x) => I14F18.FromBits((int)(x.bits / (1L << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(I26F38 x) => I13F19.FromBits((int)(x.bits / (1L << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(I26F38 x) => I12F20.FromBits((int)(x.bits / (1L << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(I26F38 x) => I11F21.FromBits((int)(x.bits / (1L << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(I26F38 x) => I10F22.FromBits((int)(x.bits / (1L << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(I26F38 x) => I9F23.FromBits((int)(x.bits / (1L << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(I26F38 x) => I8F24.FromBits((int)(x.bits / (1L << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(I26F38 x) => I7F25.FromBits((int)(x.bits / (1L << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(I26F38 x) => I6F26.FromBits((int)(x.bits / (1L << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(I26F38 x) => I5F27.FromBits((int)(x.bits / (1L << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(I26F38 x) => I4F28.FromBits((int)(x.bits / (1L << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(I26F38 x) => I3F29.FromBits((int)(x.bits / (1L << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(I26F38 x) => I2F30.FromBits((int)(x.bits / (1L << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(I26F38 x) => U31F1.FromBits((uint)(x.bits / (1L << 37)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(I26F38 x) => U30F2.FromBits((uint)(x.bits / (1L << 36)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(I26F38 x) => U29F3.FromBits((uint)(x.bits / (1L << 35)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(I26F38 x) => U28F4.FromBits((uint)(x.bits / (1L << 34)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(I26F38 x) => U27F5.FromBits((uint)(x.bits / (1L << 33)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(I26F38 x) => U26F6.FromBits((uint)(x.bits / (1L << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(I26F38 x) => U25F7.FromBits((uint)(x.bits / (1L << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(I26F38 x) => U24F8.FromBits((uint)(x.bits / (1L << 30)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(I26F38 x) => U23F9.FromBits((uint)(x.bits / (1L << 29)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(I26F38 x) => U22F10.FromBits((uint)(x.bits / (1L << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(I26F38 x) => U21F11.FromBits((uint)(x.bits / (1L << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(I26F38 x) => U20F12.FromBits((uint)(x.bits / (1L << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(I26F38 x) => U19F13.FromBits((uint)(x.bits / (1L << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(I26F38 x) => U18F14.FromBits((uint)(x.bits / (1L << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(I26F38 x) => U17F15.FromBits((uint)(x.bits / (1L << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(I26F38 x) => U16F16.FromBits((uint)(x.bits / (1L << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(I26F38 x) => U15F17.FromBits((uint)(x.bits / (1L << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(I26F38 x) => U14F18.FromBits((uint)(x.bits / (1L << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(I26F38 x) => U13F19.FromBits((uint)(x.bits / (1L << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(I26F38 x) => U12F20.FromBits((uint)(x.bits / (1L << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(I26F38 x) => U11F21.FromBits((uint)(x.bits / (1L << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(I26F38 x) => U10F22.FromBits((uint)(x.bits / (1L << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(I26F38 x) => U9F23.FromBits((uint)(x.bits / (1L << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(I26F38 x) => U8F24.FromBits((uint)(x.bits / (1L << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(I26F38 x) => U7F25.FromBits((uint)(x.bits / (1L << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(I26F38 x) => U6F26.FromBits((uint)(x.bits / (1L << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(I26F38 x) => U5F27.FromBits((uint)(x.bits / (1L << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(I26F38 x) => U4F28.FromBits((uint)(x.bits / (1L << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(I26F38 x) => U3F29.FromBits((uint)(x.bits / (1L << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(I26F38 x) => U2F30.FromBits((uint)(x.bits / (1L << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I63F1(I26F38 x) => I63F1.FromBits(x.bits / (1L << 37));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I62F2(I26F38 x) => I62F2.FromBits(x.bits / (1L << 36));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I61F3(I26F38 x) => I61F3.FromBits(x.bits / (1L << 35));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I60F4(I26F38 x) => I60F4.FromBits(x.bits / (1L << 34));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I59F5(I26F38 x) => I59F5.FromBits(x.bits / (1L << 33));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I58F6(I26F38 x) => I58F6.FromBits(x.bits / (1L << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I57F7(I26F38 x) => I57F7.FromBits(x.bits / (1L << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I56F8(I26F38 x) => I56F8.FromBits(x.bits / (1L << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I55F9(I26F38 x) => I55F9.FromBits(x.bits / (1L << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I54F10(I26F38 x) => I54F10.FromBits(x.bits / (1L << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I53F11(I26F38 x) => I53F11.FromBits(x.bits / (1L << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I52F12(I26F38 x) => I52F12.FromBits(x.bits / (1L << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I51F13(I26F38 x) => I51F13.FromBits(x.bits / (1L << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I50F14(I26F38 x) => I50F14.FromBits(x.bits / (1L << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I49F15(I26F38 x) => I49F15.FromBits(x.bits / (1L << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I48F16(I26F38 x) => I48F16.FromBits(x.bits / (1L << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I47F17(I26F38 x) => I47F17.FromBits(x.bits / (1L << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I46F18(I26F38 x) => I46F18.FromBits(x.bits / (1L << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I45F19(I26F38 x) => I45F19.FromBits(x.bits / (1L << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I44F20(I26F38 x) => I44F20.FromBits(x.bits / (1L << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I43F21(I26F38 x) => I43F21.FromBits(x.bits / (1L << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I42F22(I26F38 x) => I42F22.FromBits(x.bits / (1L << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I41F23(I26F38 x) => I41F23.FromBits(x.bits / (1L << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I40F24(I26F38 x) => I40F24.FromBits(x.bits / (1L << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I39F25(I26F38 x) => I39F25.FromBits(x.bits / (1L << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I38F26(I26F38 x) => I38F26.FromBits(x.bits / (1L << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I37F27(I26F38 x) => I37F27.FromBits(x.bits / (1L << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I36F28(I26F38 x) => I36F28.FromBits(x.bits / (1L << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I35F29(I26F38 x) => I35F29.FromBits(x.bits / (1L << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I34F30(I26F38 x) => I34F30.FromBits(x.bits / (1L << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I33F31(I26F38 x) => I33F31.FromBits(x.bits / (1L << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I32F32(I26F38 x) => I32F32.FromBits(x.bits / (1L << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F33(I26F38 x) => I31F33.FromBits(x.bits / (1L << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F34(I26F38 x) => I30F34.FromBits(x.bits / (1L << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F35(I26F38 x) => I29F35.FromBits(x.bits / (1L << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F36(I26F38 x) => I28F36.FromBits(x.bits / (1L << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F37(I26F38 x) => I27F37.FromBits(x.bits / (1L << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F39(I26F38 x) => I25F39.FromBits(x.bits * (1L << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F40(I26F38 x) => I24F40.FromBits(x.bits * (1L << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F41(I26F38 x) => I23F41.FromBits(x.bits * (1L << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F42(I26F38 x) => I22F42.FromBits(x.bits * (1L << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F43(I26F38 x) => I21F43.FromBits(x.bits * (1L << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F44(I26F38 x) => I20F44.FromBits(x.bits * (1L << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F45(I26F38 x) => I19F45.FromBits(x.bits * (1L << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F46(I26F38 x) => I18F46.FromBits(x.bits * (1L << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F47(I26F38 x) => I17F47.FromBits(x.bits * (1L << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F48(I26F38 x) => I16F48.FromBits(x.bits * (1L << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F49(I26F38 x) => I15F49.FromBits(x.bits * (1L << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F50(I26F38 x) => I14F50.FromBits(x.bits * (1L << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F51(I26F38 x) => I13F51.FromBits(x.bits * (1L << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F52(I26F38 x) => I12F52.FromBits(x.bits * (1L << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F53(I26F38 x) => I11F53.FromBits(x.bits * (1L << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F54(I26F38 x) => I10F54.FromBits(x.bits * (1L << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F55(I26F38 x) => I9F55.FromBits(x.bits * (1L << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F56(I26F38 x) => I8F56.FromBits(x.bits * (1L << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F57(I26F38 x) => I7F57.FromBits(x.bits * (1L << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F58(I26F38 x) => I6F58.FromBits(x.bits * (1L << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F59(I26F38 x) => I5F59.FromBits(x.bits * (1L << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F60(I26F38 x) => I4F60.FromBits(x.bits * (1L << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F61(I26F38 x) => I3F61.FromBits(x.bits * (1L << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F62(I26F38 x) => I2F62.FromBits(x.bits * (1L << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U63F1(I26F38 x) => U63F1.FromBits((ulong)(x.bits / (1L << 37)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U62F2(I26F38 x) => U62F2.FromBits((ulong)(x.bits / (1L << 36)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U61F3(I26F38 x) => U61F3.FromBits((ulong)(x.bits / (1L << 35)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U60F4(I26F38 x) => U60F4.FromBits((ulong)(x.bits / (1L << 34)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U59F5(I26F38 x) => U59F5.FromBits((ulong)(x.bits / (1L << 33)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U58F6(I26F38 x) => U58F6.FromBits((ulong)(x.bits / (1L << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U57F7(I26F38 x) => U57F7.FromBits((ulong)(x.bits / (1L << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U56F8(I26F38 x) => U56F8.FromBits((ulong)(x.bits / (1L << 30)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U55F9(I26F38 x) => U55F9.FromBits((ulong)(x.bits / (1L << 29)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U54F10(I26F38 x) => U54F10.FromBits((ulong)(x.bits / (1L << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U53F11(I26F38 x) => U53F11.FromBits((ulong)(x.bits / (1L << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U52F12(I26F38 x) => U52F12.FromBits((ulong)(x.bits / (1L << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U51F13(I26F38 x) => U51F13.FromBits((ulong)(x.bits / (1L << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U50F14(I26F38 x) => U50F14.FromBits((ulong)(x.bits / (1L << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U49F15(I26F38 x) => U49F15.FromBits((ulong)(x.bits / (1L << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U48F16(I26F38 x) => U48F16.FromBits((ulong)(x.bits / (1L << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U47F17(I26F38 x) => U47F17.FromBits((ulong)(x.bits / (1L << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U46F18(I26F38 x) => U46F18.FromBits((ulong)(x.bits / (1L << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U45F19(I26F38 x) => U45F19.FromBits((ulong)(x.bits / (1L << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U44F20(I26F38 x) => U44F20.FromBits((ulong)(x.bits / (1L << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U43F21(I26F38 x) => U43F21.FromBits((ulong)(x.bits / (1L << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U42F22(I26F38 x) => U42F22.FromBits((ulong)(x.bits / (1L << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U41F23(I26F38 x) => U41F23.FromBits((ulong)(x.bits / (1L << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U40F24(I26F38 x) => U40F24.FromBits((ulong)(x.bits / (1L << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U39F25(I26F38 x) => U39F25.FromBits((ulong)(x.bits / (1L << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U38F26(I26F38 x) => U38F26.FromBits((ulong)(x.bits / (1L << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U37F27(I26F38 x) => U37F27.FromBits((ulong)(x.bits / (1L << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U36F28(I26F38 x) => U36F28.FromBits((ulong)(x.bits / (1L << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U35F29(I26F38 x) => U35F29.FromBits((ulong)(x.bits / (1L << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U34F30(I26F38 x) => U34F30.FromBits((ulong)(x.bits / (1L << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U33F31(I26F38 x) => U33F31.FromBits((ulong)(x.bits / (1L << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U32F32(I26F38 x) => U32F32.FromBits((ulong)(x.bits / (1L << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F33(I26F38 x) => U31F33.FromBits((ulong)(x.bits / (1L << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F34(I26F38 x) => U30F34.FromBits((ulong)(x.bits / (1L << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F35(I26F38 x) => U29F35.FromBits((ulong)(x.bits / (1L << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F36(I26F38 x) => U28F36.FromBits((ulong)(x.bits / (1L << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F37(I26F38 x) => U27F37.FromBits((ulong)(x.bits / (1L << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F38(I26F38 x) => U26F38.FromBits((ulong)x.bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F39(I26F38 x) => U25F39.FromBits((ulong)x.bits * (1UL << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F40(I26F38 x) => U24F40.FromBits((ulong)x.bits * (1UL << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F41(I26F38 x) => U23F41.FromBits((ulong)x.bits * (1UL << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F42(I26F38 x) => U22F42.FromBits((ulong)x.bits * (1UL << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F43(I26F38 x) => U21F43.FromBits((ulong)x.bits * (1UL << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F44(I26F38 x) => U20F44.FromBits((ulong)x.bits * (1UL << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F45(I26F38 x) => U19F45.FromBits((ulong)x.bits * (1UL << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F46(I26F38 x) => U18F46.FromBits((ulong)x.bits * (1UL << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F47(I26F38 x) => U17F47.FromBits((ulong)x.bits * (1UL << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F48(I26F38 x) => U16F48.FromBits((ulong)x.bits * (1UL << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F49(I26F38 x) => U15F49.FromBits((ulong)x.bits * (1UL << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F50(I26F38 x) => U14F50.FromBits((ulong)x.bits * (1UL << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F51(I26F38 x) => U13F51.FromBits((ulong)x.bits * (1UL << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F52(I26F38 x) => U12F52.FromBits((ulong)x.bits * (1UL << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F53(I26F38 x) => U11F53.FromBits((ulong)x.bits * (1UL << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F54(I26F38 x) => U10F54.FromBits((ulong)x.bits * (1UL << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F55(I26F38 x) => U9F55.FromBits((ulong)x.bits * (1UL << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F56(I26F38 x) => U8F56.FromBits((ulong)x.bits * (1UL << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F57(I26F38 x) => U7F57.FromBits((ulong)x.bits * (1UL << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F58(I26F38 x) => U6F58.FromBits((ulong)x.bits * (1UL << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F59(I26F38 x) => U5F59.FromBits((ulong)x.bits * (1UL << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F60(I26F38 x) => U4F60.FromBits((ulong)x.bits * (1UL << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F61(I26F38 x) => U3F61.FromBits((ulong)x.bits * (1UL << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F62(I26F38 x) => U2F62.FromBits((ulong)x.bits * (1UL << 24));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is I26F38 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<I26F38>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(I26F38 other) => bits == other.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
