using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public partial struct U35F29 : IEquatable<U35F29>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 35;
        public const int FracNbits = 29;

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
        U35F29(ulong bits) {
            Bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U35F29 FromBits(ulong bits) => new U35F29(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U35F29 FromNum(ulong num) => FromBits(num * oneRepr);

        // Static Properties
        // -----------------

        public static U35F29 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(0);
        }
        public static U35F29 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(1);
        }
        public static U35F29 MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(ulong.MinValue);
        }
        public static U35F29 MaxValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(ulong.MaxValue);
        }

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U35F29 operator +(U35F29 left, U35F29 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U35F29 operator -(U35F29 left, U35F29 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U35F29 operator *(U35F29 left, U35F29 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U35F29 operator /(U35F29 left, U35F29 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * oneRepr / right.Bits));
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U35F29 operator +(U35F29 x) => FromBits(+x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U35F29 lhs, U35F29 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U35F29 lhs, U35F29 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U35F29 left, U35F29 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U35F29 left, U35F29 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U35F29 left, U35F29 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U35F29 left, U35F29 right) => left.Bits >= right.Bits;

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(U35F29 x) => (int)(x.Bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(U35F29 x) => (uint)(x.Bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(U35F29 x) => (long)(x.Bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(U35F29 x) => x.Bits / oneRepr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(U35F29 x) {
            const float k = 1.0f / oneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(U35F29 x) {
            const double k = 1.0 / oneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(U35F29 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(U35F29 x) => I31F1.FromBits((int)(x.Bits / (1UL << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(U35F29 x) => I30F2.FromBits((int)(x.Bits / (1UL << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(U35F29 x) => I29F3.FromBits((int)(x.Bits / (1UL << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(U35F29 x) => I28F4.FromBits((int)(x.Bits / (1UL << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(U35F29 x) => I27F5.FromBits((int)(x.Bits / (1UL << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(U35F29 x) => I26F6.FromBits((int)(x.Bits / (1UL << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(U35F29 x) => I25F7.FromBits((int)(x.Bits / (1UL << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(U35F29 x) => I24F8.FromBits((int)(x.Bits / (1UL << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(U35F29 x) => I23F9.FromBits((int)(x.Bits / (1UL << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(U35F29 x) => I22F10.FromBits((int)(x.Bits / (1UL << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(U35F29 x) => I21F11.FromBits((int)(x.Bits / (1UL << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(U35F29 x) => I20F12.FromBits((int)(x.Bits / (1UL << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(U35F29 x) => I19F13.FromBits((int)(x.Bits / (1UL << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(U35F29 x) => I18F14.FromBits((int)(x.Bits / (1UL << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(U35F29 x) => I17F15.FromBits((int)(x.Bits / (1UL << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(U35F29 x) => I16F16.FromBits((int)(x.Bits / (1UL << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(U35F29 x) => I15F17.FromBits((int)(x.Bits / (1UL << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(U35F29 x) => I14F18.FromBits((int)(x.Bits / (1UL << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(U35F29 x) => I13F19.FromBits((int)(x.Bits / (1UL << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(U35F29 x) => I12F20.FromBits((int)(x.Bits / (1UL << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(U35F29 x) => I11F21.FromBits((int)(x.Bits / (1UL << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(U35F29 x) => I10F22.FromBits((int)(x.Bits / (1UL << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(U35F29 x) => I9F23.FromBits((int)(x.Bits / (1UL << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(U35F29 x) => I8F24.FromBits((int)(x.Bits / (1UL << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(U35F29 x) => I7F25.FromBits((int)(x.Bits / (1UL << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(U35F29 x) => I6F26.FromBits((int)(x.Bits / (1UL << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(U35F29 x) => I5F27.FromBits((int)(x.Bits / (1UL << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(U35F29 x) => I4F28.FromBits((int)(x.Bits / (1UL << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(U35F29 x) => I3F29.FromBits((int)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(U35F29 x) => I2F30.FromBits((int)x.Bits * (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(U35F29 x) => U31F1.FromBits((uint)(x.Bits / (1UL << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(U35F29 x) => U30F2.FromBits((uint)(x.Bits / (1UL << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(U35F29 x) => U29F3.FromBits((uint)(x.Bits / (1UL << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(U35F29 x) => U28F4.FromBits((uint)(x.Bits / (1UL << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(U35F29 x) => U27F5.FromBits((uint)(x.Bits / (1UL << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(U35F29 x) => U26F6.FromBits((uint)(x.Bits / (1UL << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(U35F29 x) => U25F7.FromBits((uint)(x.Bits / (1UL << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(U35F29 x) => U24F8.FromBits((uint)(x.Bits / (1UL << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(U35F29 x) => U23F9.FromBits((uint)(x.Bits / (1UL << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(U35F29 x) => U22F10.FromBits((uint)(x.Bits / (1UL << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(U35F29 x) => U21F11.FromBits((uint)(x.Bits / (1UL << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(U35F29 x) => U20F12.FromBits((uint)(x.Bits / (1UL << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(U35F29 x) => U19F13.FromBits((uint)(x.Bits / (1UL << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(U35F29 x) => U18F14.FromBits((uint)(x.Bits / (1UL << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(U35F29 x) => U17F15.FromBits((uint)(x.Bits / (1UL << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(U35F29 x) => U16F16.FromBits((uint)(x.Bits / (1UL << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(U35F29 x) => U15F17.FromBits((uint)(x.Bits / (1UL << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(U35F29 x) => U14F18.FromBits((uint)(x.Bits / (1UL << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(U35F29 x) => U13F19.FromBits((uint)(x.Bits / (1UL << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(U35F29 x) => U12F20.FromBits((uint)(x.Bits / (1UL << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(U35F29 x) => U11F21.FromBits((uint)(x.Bits / (1UL << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(U35F29 x) => U10F22.FromBits((uint)(x.Bits / (1UL << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(U35F29 x) => U9F23.FromBits((uint)(x.Bits / (1UL << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(U35F29 x) => U8F24.FromBits((uint)(x.Bits / (1UL << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(U35F29 x) => U7F25.FromBits((uint)(x.Bits / (1UL << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(U35F29 x) => U6F26.FromBits((uint)(x.Bits / (1UL << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(U35F29 x) => U5F27.FromBits((uint)(x.Bits / (1UL << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(U35F29 x) => U4F28.FromBits((uint)(x.Bits / (1UL << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(U35F29 x) => U3F29.FromBits((uint)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(U35F29 x) => U2F30.FromBits((uint)x.Bits * (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I63F1(U35F29 x) => I63F1.FromBits((long)(x.Bits / (1UL << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I62F2(U35F29 x) => I62F2.FromBits((long)(x.Bits / (1UL << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I61F3(U35F29 x) => I61F3.FromBits((long)(x.Bits / (1UL << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I60F4(U35F29 x) => I60F4.FromBits((long)(x.Bits / (1UL << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I59F5(U35F29 x) => I59F5.FromBits((long)(x.Bits / (1UL << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I58F6(U35F29 x) => I58F6.FromBits((long)(x.Bits / (1UL << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I57F7(U35F29 x) => I57F7.FromBits((long)(x.Bits / (1UL << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I56F8(U35F29 x) => I56F8.FromBits((long)(x.Bits / (1UL << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I55F9(U35F29 x) => I55F9.FromBits((long)(x.Bits / (1UL << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I54F10(U35F29 x) => I54F10.FromBits((long)(x.Bits / (1UL << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I53F11(U35F29 x) => I53F11.FromBits((long)(x.Bits / (1UL << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I52F12(U35F29 x) => I52F12.FromBits((long)(x.Bits / (1UL << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I51F13(U35F29 x) => I51F13.FromBits((long)(x.Bits / (1UL << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I50F14(U35F29 x) => I50F14.FromBits((long)(x.Bits / (1UL << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I49F15(U35F29 x) => I49F15.FromBits((long)(x.Bits / (1UL << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I48F16(U35F29 x) => I48F16.FromBits((long)(x.Bits / (1UL << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I47F17(U35F29 x) => I47F17.FromBits((long)(x.Bits / (1UL << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I46F18(U35F29 x) => I46F18.FromBits((long)(x.Bits / (1UL << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I45F19(U35F29 x) => I45F19.FromBits((long)(x.Bits / (1UL << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I44F20(U35F29 x) => I44F20.FromBits((long)(x.Bits / (1UL << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I43F21(U35F29 x) => I43F21.FromBits((long)(x.Bits / (1UL << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I42F22(U35F29 x) => I42F22.FromBits((long)(x.Bits / (1UL << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I41F23(U35F29 x) => I41F23.FromBits((long)(x.Bits / (1UL << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I40F24(U35F29 x) => I40F24.FromBits((long)(x.Bits / (1UL << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I39F25(U35F29 x) => I39F25.FromBits((long)(x.Bits / (1UL << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I38F26(U35F29 x) => I38F26.FromBits((long)(x.Bits / (1UL << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I37F27(U35F29 x) => I37F27.FromBits((long)(x.Bits / (1UL << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I36F28(U35F29 x) => I36F28.FromBits((long)(x.Bits / (1UL << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I35F29(U35F29 x) => I35F29.FromBits((long)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I34F30(U35F29 x) => I34F30.FromBits((long)x.Bits * (1L << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I33F31(U35F29 x) => I33F31.FromBits((long)x.Bits * (1L << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I32F32(U35F29 x) => I32F32.FromBits((long)x.Bits * (1L << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F33(U35F29 x) => I31F33.FromBits((long)x.Bits * (1L << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F34(U35F29 x) => I30F34.FromBits((long)x.Bits * (1L << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F35(U35F29 x) => I29F35.FromBits((long)x.Bits * (1L << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F36(U35F29 x) => I28F36.FromBits((long)x.Bits * (1L << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F37(U35F29 x) => I27F37.FromBits((long)x.Bits * (1L << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F38(U35F29 x) => I26F38.FromBits((long)x.Bits * (1L << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F39(U35F29 x) => I25F39.FromBits((long)x.Bits * (1L << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F40(U35F29 x) => I24F40.FromBits((long)x.Bits * (1L << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F41(U35F29 x) => I23F41.FromBits((long)x.Bits * (1L << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F42(U35F29 x) => I22F42.FromBits((long)x.Bits * (1L << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F43(U35F29 x) => I21F43.FromBits((long)x.Bits * (1L << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F44(U35F29 x) => I20F44.FromBits((long)x.Bits * (1L << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F45(U35F29 x) => I19F45.FromBits((long)x.Bits * (1L << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F46(U35F29 x) => I18F46.FromBits((long)x.Bits * (1L << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F47(U35F29 x) => I17F47.FromBits((long)x.Bits * (1L << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F48(U35F29 x) => I16F48.FromBits((long)x.Bits * (1L << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F49(U35F29 x) => I15F49.FromBits((long)x.Bits * (1L << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F50(U35F29 x) => I14F50.FromBits((long)x.Bits * (1L << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F51(U35F29 x) => I13F51.FromBits((long)x.Bits * (1L << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F52(U35F29 x) => I12F52.FromBits((long)x.Bits * (1L << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F53(U35F29 x) => I11F53.FromBits((long)x.Bits * (1L << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F54(U35F29 x) => I10F54.FromBits((long)x.Bits * (1L << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F55(U35F29 x) => I9F55.FromBits((long)x.Bits * (1L << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F56(U35F29 x) => I8F56.FromBits((long)x.Bits * (1L << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F57(U35F29 x) => I7F57.FromBits((long)x.Bits * (1L << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F58(U35F29 x) => I6F58.FromBits((long)x.Bits * (1L << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F59(U35F29 x) => I5F59.FromBits((long)x.Bits * (1L << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F60(U35F29 x) => I4F60.FromBits((long)x.Bits * (1L << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F61(U35F29 x) => I3F61.FromBits((long)x.Bits * (1L << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F62(U35F29 x) => I2F62.FromBits((long)x.Bits * (1L << 33));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U63F1(U35F29 x) => U63F1.FromBits(x.Bits / (1UL << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U62F2(U35F29 x) => U62F2.FromBits(x.Bits / (1UL << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U61F3(U35F29 x) => U61F3.FromBits(x.Bits / (1UL << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U60F4(U35F29 x) => U60F4.FromBits(x.Bits / (1UL << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U59F5(U35F29 x) => U59F5.FromBits(x.Bits / (1UL << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U58F6(U35F29 x) => U58F6.FromBits(x.Bits / (1UL << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U57F7(U35F29 x) => U57F7.FromBits(x.Bits / (1UL << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U56F8(U35F29 x) => U56F8.FromBits(x.Bits / (1UL << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U55F9(U35F29 x) => U55F9.FromBits(x.Bits / (1UL << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U54F10(U35F29 x) => U54F10.FromBits(x.Bits / (1UL << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U53F11(U35F29 x) => U53F11.FromBits(x.Bits / (1UL << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U52F12(U35F29 x) => U52F12.FromBits(x.Bits / (1UL << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U51F13(U35F29 x) => U51F13.FromBits(x.Bits / (1UL << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U50F14(U35F29 x) => U50F14.FromBits(x.Bits / (1UL << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U49F15(U35F29 x) => U49F15.FromBits(x.Bits / (1UL << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U48F16(U35F29 x) => U48F16.FromBits(x.Bits / (1UL << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U47F17(U35F29 x) => U47F17.FromBits(x.Bits / (1UL << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U46F18(U35F29 x) => U46F18.FromBits(x.Bits / (1UL << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U45F19(U35F29 x) => U45F19.FromBits(x.Bits / (1UL << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U44F20(U35F29 x) => U44F20.FromBits(x.Bits / (1UL << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U43F21(U35F29 x) => U43F21.FromBits(x.Bits / (1UL << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U42F22(U35F29 x) => U42F22.FromBits(x.Bits / (1UL << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U41F23(U35F29 x) => U41F23.FromBits(x.Bits / (1UL << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U40F24(U35F29 x) => U40F24.FromBits(x.Bits / (1UL << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U39F25(U35F29 x) => U39F25.FromBits(x.Bits / (1UL << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U38F26(U35F29 x) => U38F26.FromBits(x.Bits / (1UL << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U37F27(U35F29 x) => U37F27.FromBits(x.Bits / (1UL << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U36F28(U35F29 x) => U36F28.FromBits(x.Bits / (1UL << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U34F30(U35F29 x) => U34F30.FromBits(x.Bits * (1UL << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U33F31(U35F29 x) => U33F31.FromBits(x.Bits * (1UL << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U32F32(U35F29 x) => U32F32.FromBits(x.Bits * (1UL << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F33(U35F29 x) => U31F33.FromBits(x.Bits * (1UL << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F34(U35F29 x) => U30F34.FromBits(x.Bits * (1UL << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F35(U35F29 x) => U29F35.FromBits(x.Bits * (1UL << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F36(U35F29 x) => U28F36.FromBits(x.Bits * (1UL << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F37(U35F29 x) => U27F37.FromBits(x.Bits * (1UL << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F38(U35F29 x) => U26F38.FromBits(x.Bits * (1UL << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F39(U35F29 x) => U25F39.FromBits(x.Bits * (1UL << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F40(U35F29 x) => U24F40.FromBits(x.Bits * (1UL << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F41(U35F29 x) => U23F41.FromBits(x.Bits * (1UL << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F42(U35F29 x) => U22F42.FromBits(x.Bits * (1UL << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F43(U35F29 x) => U21F43.FromBits(x.Bits * (1UL << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F44(U35F29 x) => U20F44.FromBits(x.Bits * (1UL << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F45(U35F29 x) => U19F45.FromBits(x.Bits * (1UL << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F46(U35F29 x) => U18F46.FromBits(x.Bits * (1UL << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F47(U35F29 x) => U17F47.FromBits(x.Bits * (1UL << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F48(U35F29 x) => U16F48.FromBits(x.Bits * (1UL << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F49(U35F29 x) => U15F49.FromBits(x.Bits * (1UL << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F50(U35F29 x) => U14F50.FromBits(x.Bits * (1UL << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F51(U35F29 x) => U13F51.FromBits(x.Bits * (1UL << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F52(U35F29 x) => U12F52.FromBits(x.Bits * (1UL << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F53(U35F29 x) => U11F53.FromBits(x.Bits * (1UL << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F54(U35F29 x) => U10F54.FromBits(x.Bits * (1UL << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F55(U35F29 x) => U9F55.FromBits(x.Bits * (1UL << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F56(U35F29 x) => U8F56.FromBits(x.Bits * (1UL << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F57(U35F29 x) => U7F57.FromBits(x.Bits * (1UL << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F58(U35F29 x) => U6F58.FromBits(x.Bits * (1UL << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F59(U35F29 x) => U5F59.FromBits(x.Bits * (1UL << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F60(U35F29 x) => U4F60.FromBits(x.Bits * (1UL << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F61(U35F29 x) => U3F61.FromBits(x.Bits * (1UL << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F62(U35F29 x) => U2F62.FromBits(x.Bits * (1UL << 33));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is U35F29 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<U35F29>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(U35F29 other) => Bits == other.Bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U35F29 Min(U35F29 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U35F29 Max(U35F29 other) => FromBits(Math.Max(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U35F29 Clamp(
            U35F29 min, U35F29 max
        ) => FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U35F29 Half() => FromBits(Mathi.Half(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U35F29 Twice() => FromBits(Mathi.Twice(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U35F29 LosslessMul(ulong other) => FromBits(Bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U34F30 LosslessMul(U63F1 other) => U34F30.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U33F31 LosslessMul(U62F2 other) => U33F31.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U32F32 LosslessMul(U61F3 other) => U32F32.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U31F33 LosslessMul(U60F4 other) => U31F33.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U30F34 LosslessMul(U59F5 other) => U30F34.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U29F35 LosslessMul(U58F6 other) => U29F35.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U28F36 LosslessMul(U57F7 other) => U28F36.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U27F37 LosslessMul(U56F8 other) => U27F37.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U26F38 LosslessMul(U55F9 other) => U26F38.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U25F39 LosslessMul(U54F10 other) => U25F39.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U24F40 LosslessMul(U53F11 other) => U24F40.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U23F41 LosslessMul(U52F12 other) => U23F41.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U22F42 LosslessMul(U51F13 other) => U22F42.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U21F43 LosslessMul(U50F14 other) => U21F43.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U20F44 LosslessMul(U49F15 other) => U20F44.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U19F45 LosslessMul(U48F16 other) => U19F45.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U18F46 LosslessMul(U47F17 other) => U18F46.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U17F47 LosslessMul(U46F18 other) => U17F47.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U16F48 LosslessMul(U45F19 other) => U16F48.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U15F49 LosslessMul(U44F20 other) => U15F49.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U14F50 LosslessMul(U43F21 other) => U14F50.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U13F51 LosslessMul(U42F22 other) => U13F51.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U12F52 LosslessMul(U41F23 other) => U12F52.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U11F53 LosslessMul(U40F24 other) => U11F53.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U10F54 LosslessMul(U39F25 other) => U10F54.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U9F55 LosslessMul(U38F26 other) => U9F55.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U8F56 LosslessMul(U37F27 other) => U8F56.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U7F57 LosslessMul(U36F28 other) => U7F57.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U6F58 LosslessMul(U35F29 other) => U6F58.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U5F59 LosslessMul(U34F30 other) => U5F59.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U4F60 LosslessMul(U33F31 other) => U4F60.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U3F61 LosslessMul(U32F32 other) => U3F61.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U2F62 LosslessMul(U31F33 other) => U2F62.FromBits(Bits * other.Bits);

    }
}
