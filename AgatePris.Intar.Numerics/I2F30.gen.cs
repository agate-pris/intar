using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct I2F30 : IEquatable<I2F30>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 2;
        public const int FracNbits = 30;

        const int oneRepr = 1 << FracNbits;

        // Fields
        // ------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public int Bits;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I2F30(int bits) {
            Bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 FromBits(int bits) => new I2F30(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 FromNum(int num) => FromBits(num * oneRepr);

        // Static Properties
        // -----------------

        public static I2F30 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(0);
        }
        public static I2F30 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(1);
        }
        public static I2F30 MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(int.MinValue);
        }
        public static I2F30 MaxValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(int.MaxValue);
        }

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 operator +(I2F30 left, I2F30 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 operator -(I2F30 left, I2F30 right) {
            return FromBits(left.Bits - right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 operator *(I2F30 left, I2F30 right) {
            long l = left.Bits;
            return FromBits((int)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 operator /(I2F30 left, I2F30 right) {
            long l = left.Bits;
            return FromBits((int)(l * oneRepr / right.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 operator +(I2F30 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I2F30 operator -(I2F30 x) => FromBits(-x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I2F30 lhs, I2F30 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I2F30 lhs, I2F30 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I2F30 left, I2F30 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I2F30 left, I2F30 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I2F30 left, I2F30 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I2F30 left, I2F30 right) => left.Bits >= right.Bits;

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(I2F30 x) => x.Bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(I2F30 x) => (uint)(x.Bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(I2F30 x) => x.Bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(I2F30 x) => (ulong)(x.Bits / oneRepr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I2F30 x) {
            const float k = 1.0f / oneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I2F30 x) {
            const double k = 1.0 / oneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I2F30 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(I2F30 x) => I31F1.FromBits(x.Bits / (1 << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(I2F30 x) => I30F2.FromBits(x.Bits / (1 << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(I2F30 x) => I29F3.FromBits(x.Bits / (1 << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(I2F30 x) => I28F4.FromBits(x.Bits / (1 << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(I2F30 x) => I27F5.FromBits(x.Bits / (1 << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(I2F30 x) => I26F6.FromBits(x.Bits / (1 << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(I2F30 x) => I25F7.FromBits(x.Bits / (1 << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(I2F30 x) => I24F8.FromBits(x.Bits / (1 << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(I2F30 x) => I23F9.FromBits(x.Bits / (1 << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(I2F30 x) => I22F10.FromBits(x.Bits / (1 << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(I2F30 x) => I21F11.FromBits(x.Bits / (1 << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(I2F30 x) => I20F12.FromBits(x.Bits / (1 << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(I2F30 x) => I19F13.FromBits(x.Bits / (1 << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(I2F30 x) => I18F14.FromBits(x.Bits / (1 << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(I2F30 x) => I17F15.FromBits(x.Bits / (1 << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(I2F30 x) => I16F16.FromBits(x.Bits / (1 << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(I2F30 x) => I15F17.FromBits(x.Bits / (1 << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(I2F30 x) => I14F18.FromBits(x.Bits / (1 << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(I2F30 x) => I13F19.FromBits(x.Bits / (1 << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(I2F30 x) => I12F20.FromBits(x.Bits / (1 << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(I2F30 x) => I11F21.FromBits(x.Bits / (1 << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(I2F30 x) => I10F22.FromBits(x.Bits / (1 << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(I2F30 x) => I9F23.FromBits(x.Bits / (1 << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(I2F30 x) => I8F24.FromBits(x.Bits / (1 << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(I2F30 x) => I7F25.FromBits(x.Bits / (1 << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(I2F30 x) => I6F26.FromBits(x.Bits / (1 << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(I2F30 x) => I5F27.FromBits(x.Bits / (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(I2F30 x) => I4F28.FromBits(x.Bits / (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(I2F30 x) => I3F29.FromBits(x.Bits / (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(I2F30 x) => U31F1.FromBits((uint)(x.Bits / (1 << 29)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(I2F30 x) => U30F2.FromBits((uint)(x.Bits / (1 << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(I2F30 x) => U29F3.FromBits((uint)(x.Bits / (1 << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(I2F30 x) => U28F4.FromBits((uint)(x.Bits / (1 << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(I2F30 x) => U27F5.FromBits((uint)(x.Bits / (1 << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(I2F30 x) => U26F6.FromBits((uint)(x.Bits / (1 << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(I2F30 x) => U25F7.FromBits((uint)(x.Bits / (1 << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(I2F30 x) => U24F8.FromBits((uint)(x.Bits / (1 << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(I2F30 x) => U23F9.FromBits((uint)(x.Bits / (1 << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(I2F30 x) => U22F10.FromBits((uint)(x.Bits / (1 << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(I2F30 x) => U21F11.FromBits((uint)(x.Bits / (1 << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(I2F30 x) => U20F12.FromBits((uint)(x.Bits / (1 << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(I2F30 x) => U19F13.FromBits((uint)(x.Bits / (1 << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(I2F30 x) => U18F14.FromBits((uint)(x.Bits / (1 << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(I2F30 x) => U17F15.FromBits((uint)(x.Bits / (1 << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(I2F30 x) => U16F16.FromBits((uint)(x.Bits / (1 << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(I2F30 x) => U15F17.FromBits((uint)(x.Bits / (1 << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(I2F30 x) => U14F18.FromBits((uint)(x.Bits / (1 << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(I2F30 x) => U13F19.FromBits((uint)(x.Bits / (1 << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(I2F30 x) => U12F20.FromBits((uint)(x.Bits / (1 << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(I2F30 x) => U11F21.FromBits((uint)(x.Bits / (1 << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(I2F30 x) => U10F22.FromBits((uint)(x.Bits / (1 << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(I2F30 x) => U9F23.FromBits((uint)(x.Bits / (1 << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(I2F30 x) => U8F24.FromBits((uint)(x.Bits / (1 << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(I2F30 x) => U7F25.FromBits((uint)(x.Bits / (1 << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(I2F30 x) => U6F26.FromBits((uint)(x.Bits / (1 << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(I2F30 x) => U5F27.FromBits((uint)(x.Bits / (1 << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(I2F30 x) => U4F28.FromBits((uint)(x.Bits / (1 << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(I2F30 x) => U3F29.FromBits((uint)(x.Bits / (1 << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(I2F30 x) => U2F30.FromBits((uint)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I63F1(I2F30 x) => I63F1.FromBits(x.Bits / (1 << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I62F2(I2F30 x) => I62F2.FromBits(x.Bits / (1 << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I61F3(I2F30 x) => I61F3.FromBits(x.Bits / (1 << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I60F4(I2F30 x) => I60F4.FromBits(x.Bits / (1 << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I59F5(I2F30 x) => I59F5.FromBits(x.Bits / (1 << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I58F6(I2F30 x) => I58F6.FromBits(x.Bits / (1 << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I57F7(I2F30 x) => I57F7.FromBits(x.Bits / (1 << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I56F8(I2F30 x) => I56F8.FromBits(x.Bits / (1 << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I55F9(I2F30 x) => I55F9.FromBits(x.Bits / (1 << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I54F10(I2F30 x) => I54F10.FromBits(x.Bits / (1 << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I53F11(I2F30 x) => I53F11.FromBits(x.Bits / (1 << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I52F12(I2F30 x) => I52F12.FromBits(x.Bits / (1 << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I51F13(I2F30 x) => I51F13.FromBits(x.Bits / (1 << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I50F14(I2F30 x) => I50F14.FromBits(x.Bits / (1 << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I49F15(I2F30 x) => I49F15.FromBits(x.Bits / (1 << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I48F16(I2F30 x) => I48F16.FromBits(x.Bits / (1 << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I47F17(I2F30 x) => I47F17.FromBits(x.Bits / (1 << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I46F18(I2F30 x) => I46F18.FromBits(x.Bits / (1 << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I45F19(I2F30 x) => I45F19.FromBits(x.Bits / (1 << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I44F20(I2F30 x) => I44F20.FromBits(x.Bits / (1 << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I43F21(I2F30 x) => I43F21.FromBits(x.Bits / (1 << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I42F22(I2F30 x) => I42F22.FromBits(x.Bits / (1 << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I41F23(I2F30 x) => I41F23.FromBits(x.Bits / (1 << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I40F24(I2F30 x) => I40F24.FromBits(x.Bits / (1 << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I39F25(I2F30 x) => I39F25.FromBits(x.Bits / (1 << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I38F26(I2F30 x) => I38F26.FromBits(x.Bits / (1 << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I37F27(I2F30 x) => I37F27.FromBits(x.Bits / (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I36F28(I2F30 x) => I36F28.FromBits(x.Bits / (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I35F29(I2F30 x) => I35F29.FromBits(x.Bits / (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I34F30(I2F30 x) => I34F30.FromBits(x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I33F31(I2F30 x) => I33F31.FromBits(x.Bits * (1L << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I32F32(I2F30 x) => I32F32.FromBits(x.Bits * (1L << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I31F33(I2F30 x) => I31F33.FromBits(x.Bits * (1L << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I30F34(I2F30 x) => I30F34.FromBits(x.Bits * (1L << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I29F35(I2F30 x) => I29F35.FromBits(x.Bits * (1L << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I28F36(I2F30 x) => I28F36.FromBits(x.Bits * (1L << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I27F37(I2F30 x) => I27F37.FromBits(x.Bits * (1L << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I26F38(I2F30 x) => I26F38.FromBits(x.Bits * (1L << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I25F39(I2F30 x) => I25F39.FromBits(x.Bits * (1L << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I24F40(I2F30 x) => I24F40.FromBits(x.Bits * (1L << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I23F41(I2F30 x) => I23F41.FromBits(x.Bits * (1L << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I22F42(I2F30 x) => I22F42.FromBits(x.Bits * (1L << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I21F43(I2F30 x) => I21F43.FromBits(x.Bits * (1L << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I20F44(I2F30 x) => I20F44.FromBits(x.Bits * (1L << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I19F45(I2F30 x) => I19F45.FromBits(x.Bits * (1L << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I18F46(I2F30 x) => I18F46.FromBits(x.Bits * (1L << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I17F47(I2F30 x) => I17F47.FromBits(x.Bits * (1L << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I16F48(I2F30 x) => I16F48.FromBits(x.Bits * (1L << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I15F49(I2F30 x) => I15F49.FromBits(x.Bits * (1L << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I14F50(I2F30 x) => I14F50.FromBits(x.Bits * (1L << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I13F51(I2F30 x) => I13F51.FromBits(x.Bits * (1L << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I12F52(I2F30 x) => I12F52.FromBits(x.Bits * (1L << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I11F53(I2F30 x) => I11F53.FromBits(x.Bits * (1L << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I10F54(I2F30 x) => I10F54.FromBits(x.Bits * (1L << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I9F55(I2F30 x) => I9F55.FromBits(x.Bits * (1L << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I8F56(I2F30 x) => I8F56.FromBits(x.Bits * (1L << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I7F57(I2F30 x) => I7F57.FromBits(x.Bits * (1L << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I6F58(I2F30 x) => I6F58.FromBits(x.Bits * (1L << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I5F59(I2F30 x) => I5F59.FromBits(x.Bits * (1L << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I4F60(I2F30 x) => I4F60.FromBits(x.Bits * (1L << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I3F61(I2F30 x) => I3F61.FromBits(x.Bits * (1L << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I2F62(I2F30 x) => I2F62.FromBits(x.Bits * (1L << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U63F1(I2F30 x) => U63F1.FromBits((ulong)(x.Bits / (1 << 29)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U62F2(I2F30 x) => U62F2.FromBits((ulong)(x.Bits / (1 << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U61F3(I2F30 x) => U61F3.FromBits((ulong)(x.Bits / (1 << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U60F4(I2F30 x) => U60F4.FromBits((ulong)(x.Bits / (1 << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U59F5(I2F30 x) => U59F5.FromBits((ulong)(x.Bits / (1 << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U58F6(I2F30 x) => U58F6.FromBits((ulong)(x.Bits / (1 << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U57F7(I2F30 x) => U57F7.FromBits((ulong)(x.Bits / (1 << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U56F8(I2F30 x) => U56F8.FromBits((ulong)(x.Bits / (1 << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U55F9(I2F30 x) => U55F9.FromBits((ulong)(x.Bits / (1 << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U54F10(I2F30 x) => U54F10.FromBits((ulong)(x.Bits / (1 << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U53F11(I2F30 x) => U53F11.FromBits((ulong)(x.Bits / (1 << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U52F12(I2F30 x) => U52F12.FromBits((ulong)(x.Bits / (1 << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U51F13(I2F30 x) => U51F13.FromBits((ulong)(x.Bits / (1 << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U50F14(I2F30 x) => U50F14.FromBits((ulong)(x.Bits / (1 << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U49F15(I2F30 x) => U49F15.FromBits((ulong)(x.Bits / (1 << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U48F16(I2F30 x) => U48F16.FromBits((ulong)(x.Bits / (1 << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U47F17(I2F30 x) => U47F17.FromBits((ulong)(x.Bits / (1 << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U46F18(I2F30 x) => U46F18.FromBits((ulong)(x.Bits / (1 << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U45F19(I2F30 x) => U45F19.FromBits((ulong)(x.Bits / (1 << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U44F20(I2F30 x) => U44F20.FromBits((ulong)(x.Bits / (1 << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U43F21(I2F30 x) => U43F21.FromBits((ulong)(x.Bits / (1 << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U42F22(I2F30 x) => U42F22.FromBits((ulong)(x.Bits / (1 << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U41F23(I2F30 x) => U41F23.FromBits((ulong)(x.Bits / (1 << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U40F24(I2F30 x) => U40F24.FromBits((ulong)(x.Bits / (1 << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U39F25(I2F30 x) => U39F25.FromBits((ulong)(x.Bits / (1 << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U38F26(I2F30 x) => U38F26.FromBits((ulong)(x.Bits / (1 << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U37F27(I2F30 x) => U37F27.FromBits((ulong)(x.Bits / (1 << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U36F28(I2F30 x) => U36F28.FromBits((ulong)(x.Bits / (1 << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U35F29(I2F30 x) => U35F29.FromBits((ulong)(x.Bits / (1 << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U34F30(I2F30 x) => U34F30.FromBits((ulong)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U33F31(I2F30 x) => U33F31.FromBits((ulong)x.Bits * (1UL << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U32F32(I2F30 x) => U32F32.FromBits((ulong)x.Bits * (1UL << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F33(I2F30 x) => U31F33.FromBits((ulong)x.Bits * (1UL << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F34(I2F30 x) => U30F34.FromBits((ulong)x.Bits * (1UL << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F35(I2F30 x) => U29F35.FromBits((ulong)x.Bits * (1UL << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F36(I2F30 x) => U28F36.FromBits((ulong)x.Bits * (1UL << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F37(I2F30 x) => U27F37.FromBits((ulong)x.Bits * (1UL << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F38(I2F30 x) => U26F38.FromBits((ulong)x.Bits * (1UL << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F39(I2F30 x) => U25F39.FromBits((ulong)x.Bits * (1UL << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F40(I2F30 x) => U24F40.FromBits((ulong)x.Bits * (1UL << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F41(I2F30 x) => U23F41.FromBits((ulong)x.Bits * (1UL << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F42(I2F30 x) => U22F42.FromBits((ulong)x.Bits * (1UL << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F43(I2F30 x) => U21F43.FromBits((ulong)x.Bits * (1UL << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F44(I2F30 x) => U20F44.FromBits((ulong)x.Bits * (1UL << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F45(I2F30 x) => U19F45.FromBits((ulong)x.Bits * (1UL << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F46(I2F30 x) => U18F46.FromBits((ulong)x.Bits * (1UL << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F47(I2F30 x) => U17F47.FromBits((ulong)x.Bits * (1UL << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F48(I2F30 x) => U16F48.FromBits((ulong)x.Bits * (1UL << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F49(I2F30 x) => U15F49.FromBits((ulong)x.Bits * (1UL << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F50(I2F30 x) => U14F50.FromBits((ulong)x.Bits * (1UL << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F51(I2F30 x) => U13F51.FromBits((ulong)x.Bits * (1UL << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F52(I2F30 x) => U12F52.FromBits((ulong)x.Bits * (1UL << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F53(I2F30 x) => U11F53.FromBits((ulong)x.Bits * (1UL << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F54(I2F30 x) => U10F54.FromBits((ulong)x.Bits * (1UL << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F55(I2F30 x) => U9F55.FromBits((ulong)x.Bits * (1UL << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F56(I2F30 x) => U8F56.FromBits((ulong)x.Bits * (1UL << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F57(I2F30 x) => U7F57.FromBits((ulong)x.Bits * (1UL << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F58(I2F30 x) => U6F58.FromBits((ulong)x.Bits * (1UL << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F59(I2F30 x) => U5F59.FromBits((ulong)x.Bits * (1UL << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F60(I2F30 x) => U4F60.FromBits((ulong)x.Bits * (1UL << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F61(I2F30 x) => U3F61.FromBits((ulong)x.Bits * (1UL << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F62(I2F30 x) => U2F62.FromBits((ulong)x.Bits * (1UL << 32));

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is I2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<I2F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(I2F30 other) => Bits == other.Bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 Min(I2F30 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 Max(I2F30 other) => FromBits(Math.Max(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 Abs() => FromBits(Math.Abs(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 Clamp(
            I2F30 min, I2F30 max
        ) => FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 Half() => FromBits(Mathi.Half(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 Twice() => FromBits(Mathi.Twice(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 WrappingAdd(I2F30 other) => FromBits(Overflowing.WrappingAdd(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 WrappingSub(I2F30 other) => FromBits(Overflowing.WrappingSub(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 WrappingMul(I2F30 other) => FromBits(Overflowing.WrappingMul(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 WrappingAddUnsigned(U2F30 other) => FromBits(Overflowing.WrappingAddUnsigned(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 WrappingSubUnsigned(U2F30 other) => FromBits(Overflowing.WrappingSubUnsigned(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 UnsignedAbs() {
            return U2F30.FromBits(Overflowing.UnsignedAbs(Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool OverflowingAdd(I2F30 other, out I2F30 result) {
            var b = Overflowing.OverflowingAdd(Bits, other.Bits, out var bits);
            result = FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30? CheckedAdd(I2F30 other) {
            I2F30? @null = null;
            return OverflowingAdd(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 SaturatingAdd(I2F30 other) {
            return CheckedAdd(other) ?? ((Bits < 0) && (other.Bits < 0)
                ? MinValue
                : MaxValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool OverflowingMul(I2F30 other, out I2F30 result) {
            var bits = ((long)Bits) * other.Bits / oneRepr;
            result = FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30? CheckedMul(I2F30 other) {
            I2F30? @null = null;
            return OverflowingMul(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 SaturatingMul(I2F30 other) {
            return CheckedMul(other) ?? (((Bits < 0) == (other.Bits < 0))
                ? MaxValue
                : MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 LosslessMul(int other) => FromBits(Bits * other);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 WideningMul(int other) => I34F30.FromBits((long)Bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I33F31 WideningMul(I31F1 other) => I33F31.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I32F32 WideningMul(I30F2 other) => I32F32.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I31F33 WideningMul(I29F3 other) => I31F33.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I30F34 WideningMul(I28F4 other) => I30F34.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I29F35 WideningMul(I27F5 other) => I29F35.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I28F36 WideningMul(I26F6 other) => I28F36.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I27F37 WideningMul(I25F7 other) => I27F37.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I26F38 WideningMul(I24F8 other) => I26F38.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I25F39 WideningMul(I23F9 other) => I25F39.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I24F40 WideningMul(I22F10 other) => I24F40.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I23F41 WideningMul(I21F11 other) => I23F41.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I22F42 WideningMul(I20F12 other) => I22F42.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I21F43 WideningMul(I19F13 other) => I21F43.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I20F44 WideningMul(I18F14 other) => I20F44.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I19F45 WideningMul(I17F15 other) => I19F45.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F46 WideningMul(I16F16 other) => I18F46.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F47 WideningMul(I15F17 other) => I17F47.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I16F48 WideningMul(I14F18 other) => I16F48.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I15F49 WideningMul(I13F19 other) => I15F49.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I14F50 WideningMul(I12F20 other) => I14F50.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I13F51 WideningMul(I11F21 other) => I13F51.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I12F52 WideningMul(I10F22 other) => I12F52.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I11F53 WideningMul(I9F23 other) => I11F53.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I10F54 WideningMul(I8F24 other) => I10F54.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I9F55 WideningMul(I7F25 other) => I9F55.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I8F56 WideningMul(I6F26 other) => I8F56.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I7F57 WideningMul(I5F27 other) => I7F57.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I6F58 WideningMul(I4F28 other) => I6F58.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I5F59 WideningMul(I3F29 other) => I5F59.FromBits((long)Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I4F60 WideningMul(I2F30 other) => I4F60.FromBits((long)Bits * other.Bits);

        // ベクトル型との演算
        // ------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 SaturatingMul(Vector2I2F30 other) => other.SaturatingMul(this);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 SaturatingMul(Vector3I2F30 other) => other.SaturatingMul(this);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 SaturatingMul(Vector4I2F30 other) => other.SaturatingMul(this);

    }
}
