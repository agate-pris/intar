using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct U24F40 : IEquatable<U24F40>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 24;
        public const int FracNbits = 40;

        const ulong oneRepr = 1UL << FracNbits;

        // Fields
        // ------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public ulong Bits;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        U24F40(ulong bits) {
            Bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F40 FromBits(ulong bits) => new U24F40(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F40 FromNum(ulong num) => FromBits(num * oneRepr);

        // Static Properties
        // -----------------

        public static U24F40 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(0);
        }
        public static U24F40 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(1);
        }
        public static U24F40 MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(ulong.MinValue);
        }
        public static U24F40 MaxValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(ulong.MaxValue);
        }

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F40 operator +(U24F40 left, U24F40 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F40 operator -(U24F40 left, U24F40 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F40 operator *(U24F40 left, U24F40 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F40 operator /(U24F40 left, U24F40 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * oneRepr / right.Bits));
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F40 operator +(U24F40 x) => FromBits(+x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U24F40 lhs, U24F40 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U24F40 lhs, U24F40 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U24F40 left, U24F40 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U24F40 left, U24F40 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U24F40 left, U24F40 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U24F40 left, U24F40 right) => left.Bits >= right.Bits;

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(U24F40 x) => (int)(x.Bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(U24F40 x) => (uint)(x.Bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(U24F40 x) => (long)(x.Bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(U24F40 x) => x.Bits / oneRepr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(U24F40 x) {
            const float k = 1.0f / oneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(U24F40 x) {
            const double k = 1.0 / oneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(U24F40 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(U24F40 x) => I31F1.FromBits((int)(x.Bits / (1UL << 39)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(U24F40 x) => I30F2.FromBits((int)(x.Bits / (1UL << 38)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(U24F40 x) => I29F3.FromBits((int)(x.Bits / (1UL << 37)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(U24F40 x) => I28F4.FromBits((int)(x.Bits / (1UL << 36)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(U24F40 x) => I27F5.FromBits((int)(x.Bits / (1UL << 35)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(U24F40 x) => I26F6.FromBits((int)(x.Bits / (1UL << 34)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(U24F40 x) => I25F7.FromBits((int)(x.Bits / (1UL << 33)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(U24F40 x) => I24F8.FromBits((int)(x.Bits / (1UL << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(U24F40 x) => I23F9.FromBits((int)(x.Bits / (1UL << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(U24F40 x) => I22F10.FromBits((int)(x.Bits / (1UL << 30)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(U24F40 x) => I21F11.FromBits((int)(x.Bits / (1UL << 29)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(U24F40 x) => I20F12.FromBits((int)(x.Bits / (1UL << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(U24F40 x) => I19F13.FromBits((int)(x.Bits / (1UL << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(U24F40 x) => I18F14.FromBits((int)(x.Bits / (1UL << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(U24F40 x) => I17F15.FromBits((int)(x.Bits / (1UL << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(U24F40 x) => I16F16.FromBits((int)(x.Bits / (1UL << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(U24F40 x) => I15F17.FromBits((int)(x.Bits / (1UL << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(U24F40 x) => I14F18.FromBits((int)(x.Bits / (1UL << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(U24F40 x) => I13F19.FromBits((int)(x.Bits / (1UL << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(U24F40 x) => I12F20.FromBits((int)(x.Bits / (1UL << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(U24F40 x) => I11F21.FromBits((int)(x.Bits / (1UL << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(U24F40 x) => I10F22.FromBits((int)(x.Bits / (1UL << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(U24F40 x) => I9F23.FromBits((int)(x.Bits / (1UL << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(U24F40 x) => I8F24.FromBits((int)(x.Bits / (1UL << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(U24F40 x) => I7F25.FromBits((int)(x.Bits / (1UL << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(U24F40 x) => I6F26.FromBits((int)(x.Bits / (1UL << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(U24F40 x) => I5F27.FromBits((int)(x.Bits / (1UL << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(U24F40 x) => I4F28.FromBits((int)(x.Bits / (1UL << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(U24F40 x) => I3F29.FromBits((int)(x.Bits / (1UL << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(U24F40 x) => I2F30.FromBits((int)(x.Bits / (1UL << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(U24F40 x) => U31F1.FromBits((uint)(x.Bits / (1UL << 39)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(U24F40 x) => U30F2.FromBits((uint)(x.Bits / (1UL << 38)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(U24F40 x) => U29F3.FromBits((uint)(x.Bits / (1UL << 37)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(U24F40 x) => U28F4.FromBits((uint)(x.Bits / (1UL << 36)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(U24F40 x) => U27F5.FromBits((uint)(x.Bits / (1UL << 35)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(U24F40 x) => U26F6.FromBits((uint)(x.Bits / (1UL << 34)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(U24F40 x) => U25F7.FromBits((uint)(x.Bits / (1UL << 33)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(U24F40 x) => U24F8.FromBits((uint)(x.Bits / (1UL << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(U24F40 x) => U23F9.FromBits((uint)(x.Bits / (1UL << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(U24F40 x) => U22F10.FromBits((uint)(x.Bits / (1UL << 30)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(U24F40 x) => U21F11.FromBits((uint)(x.Bits / (1UL << 29)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(U24F40 x) => U20F12.FromBits((uint)(x.Bits / (1UL << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(U24F40 x) => U19F13.FromBits((uint)(x.Bits / (1UL << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(U24F40 x) => U18F14.FromBits((uint)(x.Bits / (1UL << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(U24F40 x) => U17F15.FromBits((uint)(x.Bits / (1UL << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(U24F40 x) => U16F16.FromBits((uint)(x.Bits / (1UL << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(U24F40 x) => U15F17.FromBits((uint)(x.Bits / (1UL << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(U24F40 x) => U14F18.FromBits((uint)(x.Bits / (1UL << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(U24F40 x) => U13F19.FromBits((uint)(x.Bits / (1UL << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(U24F40 x) => U12F20.FromBits((uint)(x.Bits / (1UL << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(U24F40 x) => U11F21.FromBits((uint)(x.Bits / (1UL << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(U24F40 x) => U10F22.FromBits((uint)(x.Bits / (1UL << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(U24F40 x) => U9F23.FromBits((uint)(x.Bits / (1UL << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(U24F40 x) => U8F24.FromBits((uint)(x.Bits / (1UL << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(U24F40 x) => U7F25.FromBits((uint)(x.Bits / (1UL << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(U24F40 x) => U6F26.FromBits((uint)(x.Bits / (1UL << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(U24F40 x) => U5F27.FromBits((uint)(x.Bits / (1UL << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(U24F40 x) => U4F28.FromBits((uint)(x.Bits / (1UL << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(U24F40 x) => U3F29.FromBits((uint)(x.Bits / (1UL << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(U24F40 x) => U2F30.FromBits((uint)(x.Bits / (1UL << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I63F1(U24F40 x) => I63F1.FromBits((long)(x.Bits / (1UL << 39)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I62F2(U24F40 x) => I62F2.FromBits((long)(x.Bits / (1UL << 38)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I61F3(U24F40 x) => I61F3.FromBits((long)(x.Bits / (1UL << 37)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I60F4(U24F40 x) => I60F4.FromBits((long)(x.Bits / (1UL << 36)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I59F5(U24F40 x) => I59F5.FromBits((long)(x.Bits / (1UL << 35)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I58F6(U24F40 x) => I58F6.FromBits((long)(x.Bits / (1UL << 34)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I57F7(U24F40 x) => I57F7.FromBits((long)(x.Bits / (1UL << 33)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I56F8(U24F40 x) => I56F8.FromBits((long)(x.Bits / (1UL << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I55F9(U24F40 x) => I55F9.FromBits((long)(x.Bits / (1UL << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I54F10(U24F40 x) => I54F10.FromBits((long)(x.Bits / (1UL << 30)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I53F11(U24F40 x) => I53F11.FromBits((long)(x.Bits / (1UL << 29)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I52F12(U24F40 x) => I52F12.FromBits((long)(x.Bits / (1UL << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I51F13(U24F40 x) => I51F13.FromBits((long)(x.Bits / (1UL << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I50F14(U24F40 x) => I50F14.FromBits((long)(x.Bits / (1UL << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I49F15(U24F40 x) => I49F15.FromBits((long)(x.Bits / (1UL << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I48F16(U24F40 x) => I48F16.FromBits((long)(x.Bits / (1UL << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I47F17(U24F40 x) => I47F17.FromBits((long)(x.Bits / (1UL << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I46F18(U24F40 x) => I46F18.FromBits((long)(x.Bits / (1UL << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I45F19(U24F40 x) => I45F19.FromBits((long)(x.Bits / (1UL << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I44F20(U24F40 x) => I44F20.FromBits((long)(x.Bits / (1UL << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I43F21(U24F40 x) => I43F21.FromBits((long)(x.Bits / (1UL << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I42F22(U24F40 x) => I42F22.FromBits((long)(x.Bits / (1UL << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I41F23(U24F40 x) => I41F23.FromBits((long)(x.Bits / (1UL << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I40F24(U24F40 x) => I40F24.FromBits((long)(x.Bits / (1UL << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I39F25(U24F40 x) => I39F25.FromBits((long)(x.Bits / (1UL << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I38F26(U24F40 x) => I38F26.FromBits((long)(x.Bits / (1UL << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I37F27(U24F40 x) => I37F27.FromBits((long)(x.Bits / (1UL << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I36F28(U24F40 x) => I36F28.FromBits((long)(x.Bits / (1UL << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I35F29(U24F40 x) => I35F29.FromBits((long)(x.Bits / (1UL << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I34F30(U24F40 x) => I34F30.FromBits((long)(x.Bits / (1UL << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I33F31(U24F40 x) => I33F31.FromBits((long)(x.Bits / (1UL << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I32F32(U24F40 x) => I32F32.FromBits((long)(x.Bits / (1UL << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F33(U24F40 x) => I31F33.FromBits((long)(x.Bits / (1UL << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F34(U24F40 x) => I30F34.FromBits((long)(x.Bits / (1UL << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F35(U24F40 x) => I29F35.FromBits((long)(x.Bits / (1UL << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F36(U24F40 x) => I28F36.FromBits((long)(x.Bits / (1UL << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F37(U24F40 x) => I27F37.FromBits((long)(x.Bits / (1UL << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F38(U24F40 x) => I26F38.FromBits((long)(x.Bits / (1UL << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F39(U24F40 x) => I25F39.FromBits((long)(x.Bits / (1UL << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F40(U24F40 x) => I24F40.FromBits((long)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F41(U24F40 x) => I23F41.FromBits((long)x.Bits * (1L << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F42(U24F40 x) => I22F42.FromBits((long)x.Bits * (1L << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F43(U24F40 x) => I21F43.FromBits((long)x.Bits * (1L << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F44(U24F40 x) => I20F44.FromBits((long)x.Bits * (1L << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F45(U24F40 x) => I19F45.FromBits((long)x.Bits * (1L << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F46(U24F40 x) => I18F46.FromBits((long)x.Bits * (1L << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F47(U24F40 x) => I17F47.FromBits((long)x.Bits * (1L << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F48(U24F40 x) => I16F48.FromBits((long)x.Bits * (1L << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F49(U24F40 x) => I15F49.FromBits((long)x.Bits * (1L << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F50(U24F40 x) => I14F50.FromBits((long)x.Bits * (1L << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F51(U24F40 x) => I13F51.FromBits((long)x.Bits * (1L << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F52(U24F40 x) => I12F52.FromBits((long)x.Bits * (1L << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F53(U24F40 x) => I11F53.FromBits((long)x.Bits * (1L << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F54(U24F40 x) => I10F54.FromBits((long)x.Bits * (1L << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F55(U24F40 x) => I9F55.FromBits((long)x.Bits * (1L << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F56(U24F40 x) => I8F56.FromBits((long)x.Bits * (1L << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F57(U24F40 x) => I7F57.FromBits((long)x.Bits * (1L << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F58(U24F40 x) => I6F58.FromBits((long)x.Bits * (1L << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F59(U24F40 x) => I5F59.FromBits((long)x.Bits * (1L << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F60(U24F40 x) => I4F60.FromBits((long)x.Bits * (1L << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F61(U24F40 x) => I3F61.FromBits((long)x.Bits * (1L << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F62(U24F40 x) => I2F62.FromBits((long)x.Bits * (1L << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U63F1(U24F40 x) => U63F1.FromBits(x.Bits / (1UL << 39));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U62F2(U24F40 x) => U62F2.FromBits(x.Bits / (1UL << 38));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U61F3(U24F40 x) => U61F3.FromBits(x.Bits / (1UL << 37));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U60F4(U24F40 x) => U60F4.FromBits(x.Bits / (1UL << 36));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U59F5(U24F40 x) => U59F5.FromBits(x.Bits / (1UL << 35));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U58F6(U24F40 x) => U58F6.FromBits(x.Bits / (1UL << 34));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U57F7(U24F40 x) => U57F7.FromBits(x.Bits / (1UL << 33));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U56F8(U24F40 x) => U56F8.FromBits(x.Bits / (1UL << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U55F9(U24F40 x) => U55F9.FromBits(x.Bits / (1UL << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U54F10(U24F40 x) => U54F10.FromBits(x.Bits / (1UL << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U53F11(U24F40 x) => U53F11.FromBits(x.Bits / (1UL << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U52F12(U24F40 x) => U52F12.FromBits(x.Bits / (1UL << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U51F13(U24F40 x) => U51F13.FromBits(x.Bits / (1UL << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U50F14(U24F40 x) => U50F14.FromBits(x.Bits / (1UL << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U49F15(U24F40 x) => U49F15.FromBits(x.Bits / (1UL << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U48F16(U24F40 x) => U48F16.FromBits(x.Bits / (1UL << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U47F17(U24F40 x) => U47F17.FromBits(x.Bits / (1UL << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U46F18(U24F40 x) => U46F18.FromBits(x.Bits / (1UL << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U45F19(U24F40 x) => U45F19.FromBits(x.Bits / (1UL << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U44F20(U24F40 x) => U44F20.FromBits(x.Bits / (1UL << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U43F21(U24F40 x) => U43F21.FromBits(x.Bits / (1UL << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U42F22(U24F40 x) => U42F22.FromBits(x.Bits / (1UL << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U41F23(U24F40 x) => U41F23.FromBits(x.Bits / (1UL << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U40F24(U24F40 x) => U40F24.FromBits(x.Bits / (1UL << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U39F25(U24F40 x) => U39F25.FromBits(x.Bits / (1UL << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U38F26(U24F40 x) => U38F26.FromBits(x.Bits / (1UL << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U37F27(U24F40 x) => U37F27.FromBits(x.Bits / (1UL << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U36F28(U24F40 x) => U36F28.FromBits(x.Bits / (1UL << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U35F29(U24F40 x) => U35F29.FromBits(x.Bits / (1UL << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U34F30(U24F40 x) => U34F30.FromBits(x.Bits / (1UL << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U33F31(U24F40 x) => U33F31.FromBits(x.Bits / (1UL << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U32F32(U24F40 x) => U32F32.FromBits(x.Bits / (1UL << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F33(U24F40 x) => U31F33.FromBits(x.Bits / (1UL << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F34(U24F40 x) => U30F34.FromBits(x.Bits / (1UL << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F35(U24F40 x) => U29F35.FromBits(x.Bits / (1UL << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F36(U24F40 x) => U28F36.FromBits(x.Bits / (1UL << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F37(U24F40 x) => U27F37.FromBits(x.Bits / (1UL << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F38(U24F40 x) => U26F38.FromBits(x.Bits / (1UL << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F39(U24F40 x) => U25F39.FromBits(x.Bits / (1UL << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F41(U24F40 x) => U23F41.FromBits(x.Bits * (1UL << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F42(U24F40 x) => U22F42.FromBits(x.Bits * (1UL << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F43(U24F40 x) => U21F43.FromBits(x.Bits * (1UL << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F44(U24F40 x) => U20F44.FromBits(x.Bits * (1UL << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F45(U24F40 x) => U19F45.FromBits(x.Bits * (1UL << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F46(U24F40 x) => U18F46.FromBits(x.Bits * (1UL << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F47(U24F40 x) => U17F47.FromBits(x.Bits * (1UL << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F48(U24F40 x) => U16F48.FromBits(x.Bits * (1UL << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F49(U24F40 x) => U15F49.FromBits(x.Bits * (1UL << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F50(U24F40 x) => U14F50.FromBits(x.Bits * (1UL << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F51(U24F40 x) => U13F51.FromBits(x.Bits * (1UL << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F52(U24F40 x) => U12F52.FromBits(x.Bits * (1UL << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F53(U24F40 x) => U11F53.FromBits(x.Bits * (1UL << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F54(U24F40 x) => U10F54.FromBits(x.Bits * (1UL << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F55(U24F40 x) => U9F55.FromBits(x.Bits * (1UL << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F56(U24F40 x) => U8F56.FromBits(x.Bits * (1UL << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F57(U24F40 x) => U7F57.FromBits(x.Bits * (1UL << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F58(U24F40 x) => U6F58.FromBits(x.Bits * (1UL << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F59(U24F40 x) => U5F59.FromBits(x.Bits * (1UL << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F60(U24F40 x) => U4F60.FromBits(x.Bits * (1UL << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F61(U24F40 x) => U3F61.FromBits(x.Bits * (1UL << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F62(U24F40 x) => U2F62.FromBits(x.Bits * (1UL << 22));

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is U24F40 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<U24F40>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(U24F40 other) => Bits == other.Bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U24F40 Min(U24F40 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U24F40 Max(U24F40 other) => FromBits(Math.Max(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U24F40 Clamp(
            U24F40 min, U24F40 max
        ) => FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U24F40 Half() => FromBits(Mathi.Half(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U24F40 Twice() => FromBits(Mathi.Twice(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U24F40 WrappingAdd(U24F40 other) => FromBits(Overflowing.WrappingAdd(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U24F40 WrappingSub(U24F40 other) => FromBits(Overflowing.WrappingSub(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U24F40 WrappingMul(U24F40 other) => FromBits(Overflowing.WrappingMul(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U24F40 WrappingAddSigned(I24F40 other) => FromBits(Overflowing.WrappingAddSigned(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U24F40 LosslessMul(ulong other) => FromBits(Bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U23F41 LosslessMul(U63F1 other) => U23F41.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U22F42 LosslessMul(U62F2 other) => U22F42.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U21F43 LosslessMul(U61F3 other) => U21F43.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U20F44 LosslessMul(U60F4 other) => U20F44.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U19F45 LosslessMul(U59F5 other) => U19F45.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U18F46 LosslessMul(U58F6 other) => U18F46.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U17F47 LosslessMul(U57F7 other) => U17F47.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U16F48 LosslessMul(U56F8 other) => U16F48.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U15F49 LosslessMul(U55F9 other) => U15F49.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U14F50 LosslessMul(U54F10 other) => U14F50.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U13F51 LosslessMul(U53F11 other) => U13F51.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U12F52 LosslessMul(U52F12 other) => U12F52.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U11F53 LosslessMul(U51F13 other) => U11F53.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U10F54 LosslessMul(U50F14 other) => U10F54.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U9F55 LosslessMul(U49F15 other) => U9F55.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U8F56 LosslessMul(U48F16 other) => U8F56.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U7F57 LosslessMul(U47F17 other) => U7F57.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U6F58 LosslessMul(U46F18 other) => U6F58.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U5F59 LosslessMul(U45F19 other) => U5F59.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U4F60 LosslessMul(U44F20 other) => U4F60.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U3F61 LosslessMul(U43F21 other) => U3F61.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 LosslessMul(U42F22 other) => U2F62.FromBits(Bits * other.Bits);

    }
}
