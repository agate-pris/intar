using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct I62F2 : IEquatable<I62F2>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 62;
        public const int FracNbits = 2;

        const long oneRepr = 1L << FracNbits;

        // Fields
        // ------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public long Bits;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I62F2(long bits) {
            Bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I62F2 FromBits(long bits) => new I62F2(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I62F2 FromNum(long num) => FromBits(num * oneRepr);

        // Static Properties
        // -----------------

        public static I62F2 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(0);
        }
        public static I62F2 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(1);
        }
        public static I62F2 MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(long.MinValue);
        }
        public static I62F2 MaxValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(long.MaxValue);
        }

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I62F2 operator +(I62F2 left, I62F2 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I62F2 operator -(I62F2 left, I62F2 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I62F2 operator *(I62F2 left, I62F2 right) {
            Int128 l = left.Bits;
            return FromBits((long)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I62F2 operator /(I62F2 left, I62F2 right) {
            Int128 l = left.Bits;
            return FromBits((long)(l * oneRepr / right.Bits));
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I62F2 operator +(I62F2 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I62F2 operator -(I62F2 x) => FromBits(-x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I62F2 lhs, I62F2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I62F2 lhs, I62F2 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I62F2 left, I62F2 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I62F2 left, I62F2 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I62F2 left, I62F2 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I62F2 left, I62F2 right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I62F2 Min(I62F2 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I62F2 Max(I62F2 other) => FromBits(Math.Max(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I62F2 Abs() => FromBits(Math.Abs(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I62F2 LosslessMul(long other) => FromBits(Bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I61F3 LosslessMul(I63F1 other) => I61F3.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I60F4 LosslessMul(I62F2 other) => I60F4.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I59F5 LosslessMul(I61F3 other) => I59F5.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I58F6 LosslessMul(I60F4 other) => I58F6.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I57F7 LosslessMul(I59F5 other) => I57F7.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I56F8 LosslessMul(I58F6 other) => I56F8.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I55F9 LosslessMul(I57F7 other) => I55F9.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I54F10 LosslessMul(I56F8 other) => I54F10.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I53F11 LosslessMul(I55F9 other) => I53F11.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I52F12 LosslessMul(I54F10 other) => I52F12.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I51F13 LosslessMul(I53F11 other) => I51F13.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I50F14 LosslessMul(I52F12 other) => I50F14.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I49F15 LosslessMul(I51F13 other) => I49F15.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I48F16 LosslessMul(I50F14 other) => I48F16.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I47F17 LosslessMul(I49F15 other) => I47F17.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I46F18 LosslessMul(I48F16 other) => I46F18.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I45F19 LosslessMul(I47F17 other) => I45F19.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I44F20 LosslessMul(I46F18 other) => I44F20.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I43F21 LosslessMul(I45F19 other) => I43F21.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I42F22 LosslessMul(I44F20 other) => I42F22.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I41F23 LosslessMul(I43F21 other) => I41F23.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I40F24 LosslessMul(I42F22 other) => I40F24.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I39F25 LosslessMul(I41F23 other) => I39F25.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I38F26 LosslessMul(I40F24 other) => I38F26.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I37F27 LosslessMul(I39F25 other) => I37F27.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I36F28 LosslessMul(I38F26 other) => I36F28.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I35F29 LosslessMul(I37F27 other) => I35F29.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I34F30 LosslessMul(I36F28 other) => I34F30.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I33F31 LosslessMul(I35F29 other) => I33F31.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I32F32 LosslessMul(I34F30 other) => I32F32.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I31F33 LosslessMul(I33F31 other) => I31F33.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I30F34 LosslessMul(I32F32 other) => I30F34.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I29F35 LosslessMul(I31F33 other) => I29F35.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I28F36 LosslessMul(I30F34 other) => I28F36.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I27F37 LosslessMul(I29F35 other) => I27F37.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I26F38 LosslessMul(I28F36 other) => I26F38.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I25F39 LosslessMul(I27F37 other) => I25F39.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I24F40 LosslessMul(I26F38 other) => I24F40.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I23F41 LosslessMul(I25F39 other) => I23F41.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I22F42 LosslessMul(I24F40 other) => I22F42.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I21F43 LosslessMul(I23F41 other) => I21F43.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I20F44 LosslessMul(I22F42 other) => I20F44.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I19F45 LosslessMul(I21F43 other) => I19F45.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I18F46 LosslessMul(I20F44 other) => I18F46.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I17F47 LosslessMul(I19F45 other) => I17F47.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I16F48 LosslessMul(I18F46 other) => I16F48.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I15F49 LosslessMul(I17F47 other) => I15F49.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I14F50 LosslessMul(I16F48 other) => I14F50.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I13F51 LosslessMul(I15F49 other) => I13F51.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I12F52 LosslessMul(I14F50 other) => I12F52.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I11F53 LosslessMul(I13F51 other) => I11F53.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I10F54 LosslessMul(I12F52 other) => I10F54.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I9F55 LosslessMul(I11F53 other) => I9F55.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I8F56 LosslessMul(I10F54 other) => I8F56.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I7F57 LosslessMul(I9F55 other) => I7F57.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I6F58 LosslessMul(I8F56 other) => I6F58.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I5F59 LosslessMul(I7F57 other) => I5F59.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I4F60 LosslessMul(I6F58 other) => I4F60.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I3F61 LosslessMul(I5F59 other) => I3F61.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I2F62 LosslessMul(I4F60 other) => I2F62.FromBits(Bits * other.Bits);

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(I62F2 x) => (int)(x.Bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(I62F2 x) => (uint)(x.Bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(I62F2 x) => x.Bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(I62F2 x) => (ulong)(x.Bits / oneRepr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I62F2 x) {
            const float k = 1.0f / oneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I62F2 x) {
            const double k = 1.0 / oneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I62F2 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(I62F2 x) => I31F1.FromBits((int)(x.Bits / (1L << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(I62F2 x) => I30F2.FromBits((int)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(I62F2 x) => I29F3.FromBits((int)x.Bits * (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(I62F2 x) => I28F4.FromBits((int)x.Bits * (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(I62F2 x) => I27F5.FromBits((int)x.Bits * (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(I62F2 x) => I26F6.FromBits((int)x.Bits * (1 << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(I62F2 x) => I25F7.FromBits((int)x.Bits * (1 << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(I62F2 x) => I24F8.FromBits((int)x.Bits * (1 << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(I62F2 x) => I23F9.FromBits((int)x.Bits * (1 << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(I62F2 x) => I22F10.FromBits((int)x.Bits * (1 << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(I62F2 x) => I21F11.FromBits((int)x.Bits * (1 << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(I62F2 x) => I20F12.FromBits((int)x.Bits * (1 << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(I62F2 x) => I19F13.FromBits((int)x.Bits * (1 << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(I62F2 x) => I18F14.FromBits((int)x.Bits * (1 << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(I62F2 x) => I17F15.FromBits((int)x.Bits * (1 << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(I62F2 x) => I16F16.FromBits((int)x.Bits * (1 << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(I62F2 x) => I15F17.FromBits((int)x.Bits * (1 << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(I62F2 x) => I14F18.FromBits((int)x.Bits * (1 << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(I62F2 x) => I13F19.FromBits((int)x.Bits * (1 << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(I62F2 x) => I12F20.FromBits((int)x.Bits * (1 << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(I62F2 x) => I11F21.FromBits((int)x.Bits * (1 << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(I62F2 x) => I10F22.FromBits((int)x.Bits * (1 << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(I62F2 x) => I9F23.FromBits((int)x.Bits * (1 << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(I62F2 x) => I8F24.FromBits((int)x.Bits * (1 << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(I62F2 x) => I7F25.FromBits((int)x.Bits * (1 << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(I62F2 x) => I6F26.FromBits((int)x.Bits * (1 << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(I62F2 x) => I5F27.FromBits((int)x.Bits * (1 << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(I62F2 x) => I4F28.FromBits((int)x.Bits * (1 << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(I62F2 x) => I3F29.FromBits((int)x.Bits * (1 << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(I62F2 x) => I2F30.FromBits((int)x.Bits * (1 << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(I62F2 x) => U31F1.FromBits((uint)(x.Bits / (1L << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(I62F2 x) => U30F2.FromBits((uint)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(I62F2 x) => U29F3.FromBits((uint)x.Bits * (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(I62F2 x) => U28F4.FromBits((uint)x.Bits * (1U << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(I62F2 x) => U27F5.FromBits((uint)x.Bits * (1U << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(I62F2 x) => U26F6.FromBits((uint)x.Bits * (1U << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(I62F2 x) => U25F7.FromBits((uint)x.Bits * (1U << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(I62F2 x) => U24F8.FromBits((uint)x.Bits * (1U << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(I62F2 x) => U23F9.FromBits((uint)x.Bits * (1U << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(I62F2 x) => U22F10.FromBits((uint)x.Bits * (1U << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(I62F2 x) => U21F11.FromBits((uint)x.Bits * (1U << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(I62F2 x) => U20F12.FromBits((uint)x.Bits * (1U << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(I62F2 x) => U19F13.FromBits((uint)x.Bits * (1U << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(I62F2 x) => U18F14.FromBits((uint)x.Bits * (1U << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(I62F2 x) => U17F15.FromBits((uint)x.Bits * (1U << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(I62F2 x) => U16F16.FromBits((uint)x.Bits * (1U << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(I62F2 x) => U15F17.FromBits((uint)x.Bits * (1U << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(I62F2 x) => U14F18.FromBits((uint)x.Bits * (1U << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(I62F2 x) => U13F19.FromBits((uint)x.Bits * (1U << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(I62F2 x) => U12F20.FromBits((uint)x.Bits * (1U << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(I62F2 x) => U11F21.FromBits((uint)x.Bits * (1U << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(I62F2 x) => U10F22.FromBits((uint)x.Bits * (1U << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(I62F2 x) => U9F23.FromBits((uint)x.Bits * (1U << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(I62F2 x) => U8F24.FromBits((uint)x.Bits * (1U << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(I62F2 x) => U7F25.FromBits((uint)x.Bits * (1U << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(I62F2 x) => U6F26.FromBits((uint)x.Bits * (1U << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(I62F2 x) => U5F27.FromBits((uint)x.Bits * (1U << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(I62F2 x) => U4F28.FromBits((uint)x.Bits * (1U << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(I62F2 x) => U3F29.FromBits((uint)x.Bits * (1U << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(I62F2 x) => U2F30.FromBits((uint)x.Bits * (1U << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I63F1(I62F2 x) => I63F1.FromBits(x.Bits / (1L << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I61F3(I62F2 x) => I61F3.FromBits(x.Bits * (1L << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I60F4(I62F2 x) => I60F4.FromBits(x.Bits * (1L << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I59F5(I62F2 x) => I59F5.FromBits(x.Bits * (1L << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I58F6(I62F2 x) => I58F6.FromBits(x.Bits * (1L << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I57F7(I62F2 x) => I57F7.FromBits(x.Bits * (1L << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I56F8(I62F2 x) => I56F8.FromBits(x.Bits * (1L << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I55F9(I62F2 x) => I55F9.FromBits(x.Bits * (1L << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I54F10(I62F2 x) => I54F10.FromBits(x.Bits * (1L << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I53F11(I62F2 x) => I53F11.FromBits(x.Bits * (1L << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I52F12(I62F2 x) => I52F12.FromBits(x.Bits * (1L << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I51F13(I62F2 x) => I51F13.FromBits(x.Bits * (1L << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I50F14(I62F2 x) => I50F14.FromBits(x.Bits * (1L << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I49F15(I62F2 x) => I49F15.FromBits(x.Bits * (1L << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I48F16(I62F2 x) => I48F16.FromBits(x.Bits * (1L << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I47F17(I62F2 x) => I47F17.FromBits(x.Bits * (1L << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I46F18(I62F2 x) => I46F18.FromBits(x.Bits * (1L << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I45F19(I62F2 x) => I45F19.FromBits(x.Bits * (1L << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I44F20(I62F2 x) => I44F20.FromBits(x.Bits * (1L << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I43F21(I62F2 x) => I43F21.FromBits(x.Bits * (1L << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I42F22(I62F2 x) => I42F22.FromBits(x.Bits * (1L << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I41F23(I62F2 x) => I41F23.FromBits(x.Bits * (1L << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I40F24(I62F2 x) => I40F24.FromBits(x.Bits * (1L << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I39F25(I62F2 x) => I39F25.FromBits(x.Bits * (1L << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I38F26(I62F2 x) => I38F26.FromBits(x.Bits * (1L << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I37F27(I62F2 x) => I37F27.FromBits(x.Bits * (1L << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I36F28(I62F2 x) => I36F28.FromBits(x.Bits * (1L << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I35F29(I62F2 x) => I35F29.FromBits(x.Bits * (1L << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I34F30(I62F2 x) => I34F30.FromBits(x.Bits * (1L << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I33F31(I62F2 x) => I33F31.FromBits(x.Bits * (1L << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I32F32(I62F2 x) => I32F32.FromBits(x.Bits * (1L << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F33(I62F2 x) => I31F33.FromBits(x.Bits * (1L << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F34(I62F2 x) => I30F34.FromBits(x.Bits * (1L << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F35(I62F2 x) => I29F35.FromBits(x.Bits * (1L << 33));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F36(I62F2 x) => I28F36.FromBits(x.Bits * (1L << 34));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F37(I62F2 x) => I27F37.FromBits(x.Bits * (1L << 35));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F38(I62F2 x) => I26F38.FromBits(x.Bits * (1L << 36));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F39(I62F2 x) => I25F39.FromBits(x.Bits * (1L << 37));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F40(I62F2 x) => I24F40.FromBits(x.Bits * (1L << 38));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F41(I62F2 x) => I23F41.FromBits(x.Bits * (1L << 39));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F42(I62F2 x) => I22F42.FromBits(x.Bits * (1L << 40));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F43(I62F2 x) => I21F43.FromBits(x.Bits * (1L << 41));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F44(I62F2 x) => I20F44.FromBits(x.Bits * (1L << 42));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F45(I62F2 x) => I19F45.FromBits(x.Bits * (1L << 43));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F46(I62F2 x) => I18F46.FromBits(x.Bits * (1L << 44));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F47(I62F2 x) => I17F47.FromBits(x.Bits * (1L << 45));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F48(I62F2 x) => I16F48.FromBits(x.Bits * (1L << 46));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F49(I62F2 x) => I15F49.FromBits(x.Bits * (1L << 47));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F50(I62F2 x) => I14F50.FromBits(x.Bits * (1L << 48));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F51(I62F2 x) => I13F51.FromBits(x.Bits * (1L << 49));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F52(I62F2 x) => I12F52.FromBits(x.Bits * (1L << 50));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F53(I62F2 x) => I11F53.FromBits(x.Bits * (1L << 51));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F54(I62F2 x) => I10F54.FromBits(x.Bits * (1L << 52));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F55(I62F2 x) => I9F55.FromBits(x.Bits * (1L << 53));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F56(I62F2 x) => I8F56.FromBits(x.Bits * (1L << 54));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F57(I62F2 x) => I7F57.FromBits(x.Bits * (1L << 55));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F58(I62F2 x) => I6F58.FromBits(x.Bits * (1L << 56));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F59(I62F2 x) => I5F59.FromBits(x.Bits * (1L << 57));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F60(I62F2 x) => I4F60.FromBits(x.Bits * (1L << 58));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F61(I62F2 x) => I3F61.FromBits(x.Bits * (1L << 59));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F62(I62F2 x) => I2F62.FromBits(x.Bits * (1L << 60));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U63F1(I62F2 x) => U63F1.FromBits((ulong)(x.Bits / (1L << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U62F2(I62F2 x) => U62F2.FromBits((ulong)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U61F3(I62F2 x) => U61F3.FromBits((ulong)x.Bits * (1UL << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U60F4(I62F2 x) => U60F4.FromBits((ulong)x.Bits * (1UL << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U59F5(I62F2 x) => U59F5.FromBits((ulong)x.Bits * (1UL << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U58F6(I62F2 x) => U58F6.FromBits((ulong)x.Bits * (1UL << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U57F7(I62F2 x) => U57F7.FromBits((ulong)x.Bits * (1UL << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U56F8(I62F2 x) => U56F8.FromBits((ulong)x.Bits * (1UL << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U55F9(I62F2 x) => U55F9.FromBits((ulong)x.Bits * (1UL << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U54F10(I62F2 x) => U54F10.FromBits((ulong)x.Bits * (1UL << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U53F11(I62F2 x) => U53F11.FromBits((ulong)x.Bits * (1UL << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U52F12(I62F2 x) => U52F12.FromBits((ulong)x.Bits * (1UL << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U51F13(I62F2 x) => U51F13.FromBits((ulong)x.Bits * (1UL << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U50F14(I62F2 x) => U50F14.FromBits((ulong)x.Bits * (1UL << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U49F15(I62F2 x) => U49F15.FromBits((ulong)x.Bits * (1UL << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U48F16(I62F2 x) => U48F16.FromBits((ulong)x.Bits * (1UL << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U47F17(I62F2 x) => U47F17.FromBits((ulong)x.Bits * (1UL << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U46F18(I62F2 x) => U46F18.FromBits((ulong)x.Bits * (1UL << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U45F19(I62F2 x) => U45F19.FromBits((ulong)x.Bits * (1UL << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U44F20(I62F2 x) => U44F20.FromBits((ulong)x.Bits * (1UL << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U43F21(I62F2 x) => U43F21.FromBits((ulong)x.Bits * (1UL << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U42F22(I62F2 x) => U42F22.FromBits((ulong)x.Bits * (1UL << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U41F23(I62F2 x) => U41F23.FromBits((ulong)x.Bits * (1UL << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U40F24(I62F2 x) => U40F24.FromBits((ulong)x.Bits * (1UL << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U39F25(I62F2 x) => U39F25.FromBits((ulong)x.Bits * (1UL << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U38F26(I62F2 x) => U38F26.FromBits((ulong)x.Bits * (1UL << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U37F27(I62F2 x) => U37F27.FromBits((ulong)x.Bits * (1UL << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U36F28(I62F2 x) => U36F28.FromBits((ulong)x.Bits * (1UL << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U35F29(I62F2 x) => U35F29.FromBits((ulong)x.Bits * (1UL << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U34F30(I62F2 x) => U34F30.FromBits((ulong)x.Bits * (1UL << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U33F31(I62F2 x) => U33F31.FromBits((ulong)x.Bits * (1UL << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U32F32(I62F2 x) => U32F32.FromBits((ulong)x.Bits * (1UL << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F33(I62F2 x) => U31F33.FromBits((ulong)x.Bits * (1UL << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F34(I62F2 x) => U30F34.FromBits((ulong)x.Bits * (1UL << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F35(I62F2 x) => U29F35.FromBits((ulong)x.Bits * (1UL << 33));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F36(I62F2 x) => U28F36.FromBits((ulong)x.Bits * (1UL << 34));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F37(I62F2 x) => U27F37.FromBits((ulong)x.Bits * (1UL << 35));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F38(I62F2 x) => U26F38.FromBits((ulong)x.Bits * (1UL << 36));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F39(I62F2 x) => U25F39.FromBits((ulong)x.Bits * (1UL << 37));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F40(I62F2 x) => U24F40.FromBits((ulong)x.Bits * (1UL << 38));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F41(I62F2 x) => U23F41.FromBits((ulong)x.Bits * (1UL << 39));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F42(I62F2 x) => U22F42.FromBits((ulong)x.Bits * (1UL << 40));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F43(I62F2 x) => U21F43.FromBits((ulong)x.Bits * (1UL << 41));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F44(I62F2 x) => U20F44.FromBits((ulong)x.Bits * (1UL << 42));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F45(I62F2 x) => U19F45.FromBits((ulong)x.Bits * (1UL << 43));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F46(I62F2 x) => U18F46.FromBits((ulong)x.Bits * (1UL << 44));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F47(I62F2 x) => U17F47.FromBits((ulong)x.Bits * (1UL << 45));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F48(I62F2 x) => U16F48.FromBits((ulong)x.Bits * (1UL << 46));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F49(I62F2 x) => U15F49.FromBits((ulong)x.Bits * (1UL << 47));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F50(I62F2 x) => U14F50.FromBits((ulong)x.Bits * (1UL << 48));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F51(I62F2 x) => U13F51.FromBits((ulong)x.Bits * (1UL << 49));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F52(I62F2 x) => U12F52.FromBits((ulong)x.Bits * (1UL << 50));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F53(I62F2 x) => U11F53.FromBits((ulong)x.Bits * (1UL << 51));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F54(I62F2 x) => U10F54.FromBits((ulong)x.Bits * (1UL << 52));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F55(I62F2 x) => U9F55.FromBits((ulong)x.Bits * (1UL << 53));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F56(I62F2 x) => U8F56.FromBits((ulong)x.Bits * (1UL << 54));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F57(I62F2 x) => U7F57.FromBits((ulong)x.Bits * (1UL << 55));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F58(I62F2 x) => U6F58.FromBits((ulong)x.Bits * (1UL << 56));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F59(I62F2 x) => U5F59.FromBits((ulong)x.Bits * (1UL << 57));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F60(I62F2 x) => U4F60.FromBits((ulong)x.Bits * (1UL << 58));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F61(I62F2 x) => U3F61.FromBits((ulong)x.Bits * (1UL << 59));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F62(I62F2 x) => U2F62.FromBits((ulong)x.Bits * (1UL << 60));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is I62F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<I62F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(I62F2 other) => Bits == other.Bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
