using System;
using System.Runtime.CompilerServices;

#if UNITY_5_6_OR_NEWER
using UnityEngine;
#endif

namespace AgatePris.Intar.Fixed {
    [Serializable]
    public

#if !UNITY_5_6_OR_NEWER
    readonly
#endif

    struct I43F21 : IEquatable<I43F21>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 43;
        public const int FracNbits = 21;

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

        public static readonly I43F21 Zero = FromNum(0);
        public static readonly I43F21 One = FromNum(1);
        public static readonly I43F21 MinValue = FromBits(long.MinValue);
        public static readonly I43F21 MaxValue = FromBits(long.MaxValue);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I43F21(long bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I43F21 FromBits(long bits) => new I43F21(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I43F21 FromNum(long num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I43F21 operator +(I43F21 left, I43F21 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I43F21 operator -(I43F21 left, I43F21 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I43F21 operator *(I43F21 left, I43F21 right) {
            Int128 l = left.Bits;
            return FromBits((long)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I43F21 operator /(I43F21 left, I43F21 right) {
            Int128 l = left.Bits;
            return FromBits((long)(l * oneRepr / right.Bits));
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I43F21 operator +(I43F21 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I43F21 operator -(I43F21 x) => FromBits(-x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I43F21 lhs, I43F21 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I43F21 lhs, I43F21 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I43F21 left, I43F21 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I43F21 left, I43F21 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I43F21 left, I43F21 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I43F21 left, I43F21 right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I43F21 Min(I43F21 other) => FromBits(System.Math.Min(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I43F21 Max(I43F21 other) => FromBits(System.Math.Max(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I43F21 Clamp(I43F21 min, I43F21 max) => FromBits(Math.Clamp(bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I43F21 Abs() => FromBits(System.Math.Abs(bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I43F21 LosslessMul(long other) => FromBits(bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I42F22 LosslessMul(I63F1 other) => I42F22.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I41F23 LosslessMul(I62F2 other) => I41F23.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I40F24 LosslessMul(I61F3 other) => I40F24.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I39F25 LosslessMul(I60F4 other) => I39F25.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I38F26 LosslessMul(I59F5 other) => I38F26.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I37F27 LosslessMul(I58F6 other) => I37F27.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I36F28 LosslessMul(I57F7 other) => I36F28.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I35F29 LosslessMul(I56F8 other) => I35F29.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I34F30 LosslessMul(I55F9 other) => I34F30.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I33F31 LosslessMul(I54F10 other) => I33F31.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I32F32 LosslessMul(I53F11 other) => I32F32.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I31F33 LosslessMul(I52F12 other) => I31F33.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I30F34 LosslessMul(I51F13 other) => I30F34.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I29F35 LosslessMul(I50F14 other) => I29F35.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I28F36 LosslessMul(I49F15 other) => I28F36.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I27F37 LosslessMul(I48F16 other) => I27F37.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I26F38 LosslessMul(I47F17 other) => I26F38.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I25F39 LosslessMul(I46F18 other) => I25F39.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I24F40 LosslessMul(I45F19 other) => I24F40.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I23F41 LosslessMul(I44F20 other) => I23F41.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I22F42 LosslessMul(I43F21 other) => I22F42.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I21F43 LosslessMul(I42F22 other) => I21F43.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I20F44 LosslessMul(I41F23 other) => I20F44.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I19F45 LosslessMul(I40F24 other) => I19F45.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I18F46 LosslessMul(I39F25 other) => I18F46.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I17F47 LosslessMul(I38F26 other) => I17F47.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I16F48 LosslessMul(I37F27 other) => I16F48.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I15F49 LosslessMul(I36F28 other) => I15F49.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I14F50 LosslessMul(I35F29 other) => I14F50.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I13F51 LosslessMul(I34F30 other) => I13F51.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I12F52 LosslessMul(I33F31 other) => I12F52.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I11F53 LosslessMul(I32F32 other) => I11F53.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I10F54 LosslessMul(I31F33 other) => I10F54.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I9F55 LosslessMul(I30F34 other) => I9F55.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I8F56 LosslessMul(I29F35 other) => I8F56.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I7F57 LosslessMul(I28F36 other) => I7F57.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I6F58 LosslessMul(I27F37 other) => I6F58.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I5F59 LosslessMul(I26F38 other) => I5F59.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I4F60 LosslessMul(I25F39 other) => I4F60.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I3F61 LosslessMul(I24F40 other) => I3F61.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I2F62 LosslessMul(I23F41 other) => I2F62.FromBits(bits * other.Bits);

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(I43F21 x) => (int)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(I43F21 x) => (uint)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(I43F21 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(I43F21 x) => (ulong)(x.bits / oneRepr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I43F21 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I43F21 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I43F21 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(I43F21 x) => I31F1.FromBits((int)(x.Bits / (1L << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(I43F21 x) => I30F2.FromBits((int)(x.Bits / (1L << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(I43F21 x) => I29F3.FromBits((int)(x.Bits / (1L << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(I43F21 x) => I28F4.FromBits((int)(x.Bits / (1L << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(I43F21 x) => I27F5.FromBits((int)(x.Bits / (1L << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(I43F21 x) => I26F6.FromBits((int)(x.Bits / (1L << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(I43F21 x) => I25F7.FromBits((int)(x.Bits / (1L << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(I43F21 x) => I24F8.FromBits((int)(x.Bits / (1L << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(I43F21 x) => I23F9.FromBits((int)(x.Bits / (1L << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(I43F21 x) => I22F10.FromBits((int)(x.Bits / (1L << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(I43F21 x) => I21F11.FromBits((int)(x.Bits / (1L << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(I43F21 x) => I20F12.FromBits((int)(x.Bits / (1L << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(I43F21 x) => I19F13.FromBits((int)(x.Bits / (1L << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(I43F21 x) => I18F14.FromBits((int)(x.Bits / (1L << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(I43F21 x) => I17F15.FromBits((int)(x.Bits / (1L << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(I43F21 x) => I16F16.FromBits((int)(x.Bits / (1L << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(I43F21 x) => I15F17.FromBits((int)(x.Bits / (1L << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(I43F21 x) => I14F18.FromBits((int)(x.Bits / (1L << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(I43F21 x) => I13F19.FromBits((int)(x.Bits / (1L << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(I43F21 x) => I12F20.FromBits((int)(x.Bits / (1L << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(I43F21 x) => I11F21.FromBits((int)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(I43F21 x) => I10F22.FromBits((int)x.Bits * (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(I43F21 x) => I9F23.FromBits((int)x.Bits * (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(I43F21 x) => I8F24.FromBits((int)x.Bits * (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(I43F21 x) => I7F25.FromBits((int)x.Bits * (1 << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(I43F21 x) => I6F26.FromBits((int)x.Bits * (1 << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(I43F21 x) => I5F27.FromBits((int)x.Bits * (1 << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(I43F21 x) => I4F28.FromBits((int)x.Bits * (1 << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(I43F21 x) => I3F29.FromBits((int)x.Bits * (1 << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(I43F21 x) => I2F30.FromBits((int)x.Bits * (1 << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(I43F21 x) => U31F1.FromBits((uint)(x.Bits / (1L << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(I43F21 x) => U30F2.FromBits((uint)(x.Bits / (1L << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(I43F21 x) => U29F3.FromBits((uint)(x.Bits / (1L << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(I43F21 x) => U28F4.FromBits((uint)(x.Bits / (1L << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(I43F21 x) => U27F5.FromBits((uint)(x.Bits / (1L << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(I43F21 x) => U26F6.FromBits((uint)(x.Bits / (1L << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(I43F21 x) => U25F7.FromBits((uint)(x.Bits / (1L << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(I43F21 x) => U24F8.FromBits((uint)(x.Bits / (1L << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(I43F21 x) => U23F9.FromBits((uint)(x.Bits / (1L << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(I43F21 x) => U22F10.FromBits((uint)(x.Bits / (1L << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(I43F21 x) => U21F11.FromBits((uint)(x.Bits / (1L << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(I43F21 x) => U20F12.FromBits((uint)(x.Bits / (1L << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(I43F21 x) => U19F13.FromBits((uint)(x.Bits / (1L << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(I43F21 x) => U18F14.FromBits((uint)(x.Bits / (1L << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(I43F21 x) => U17F15.FromBits((uint)(x.Bits / (1L << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(I43F21 x) => U16F16.FromBits((uint)(x.Bits / (1L << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(I43F21 x) => U15F17.FromBits((uint)(x.Bits / (1L << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(I43F21 x) => U14F18.FromBits((uint)(x.Bits / (1L << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(I43F21 x) => U13F19.FromBits((uint)(x.Bits / (1L << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(I43F21 x) => U12F20.FromBits((uint)(x.Bits / (1L << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(I43F21 x) => U11F21.FromBits((uint)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(I43F21 x) => U10F22.FromBits((uint)x.Bits * (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(I43F21 x) => U9F23.FromBits((uint)x.Bits * (1U << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(I43F21 x) => U8F24.FromBits((uint)x.Bits * (1U << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(I43F21 x) => U7F25.FromBits((uint)x.Bits * (1U << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(I43F21 x) => U6F26.FromBits((uint)x.Bits * (1U << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(I43F21 x) => U5F27.FromBits((uint)x.Bits * (1U << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(I43F21 x) => U4F28.FromBits((uint)x.Bits * (1U << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(I43F21 x) => U3F29.FromBits((uint)x.Bits * (1U << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(I43F21 x) => U2F30.FromBits((uint)x.Bits * (1U << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I63F1(I43F21 x) => I63F1.FromBits(x.Bits / (1L << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I62F2(I43F21 x) => I62F2.FromBits(x.Bits / (1L << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I61F3(I43F21 x) => I61F3.FromBits(x.Bits / (1L << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I60F4(I43F21 x) => I60F4.FromBits(x.Bits / (1L << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I59F5(I43F21 x) => I59F5.FromBits(x.Bits / (1L << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I58F6(I43F21 x) => I58F6.FromBits(x.Bits / (1L << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I57F7(I43F21 x) => I57F7.FromBits(x.Bits / (1L << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I56F8(I43F21 x) => I56F8.FromBits(x.Bits / (1L << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I55F9(I43F21 x) => I55F9.FromBits(x.Bits / (1L << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I54F10(I43F21 x) => I54F10.FromBits(x.Bits / (1L << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I53F11(I43F21 x) => I53F11.FromBits(x.Bits / (1L << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I52F12(I43F21 x) => I52F12.FromBits(x.Bits / (1L << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I51F13(I43F21 x) => I51F13.FromBits(x.Bits / (1L << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I50F14(I43F21 x) => I50F14.FromBits(x.Bits / (1L << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I49F15(I43F21 x) => I49F15.FromBits(x.Bits / (1L << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I48F16(I43F21 x) => I48F16.FromBits(x.Bits / (1L << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I47F17(I43F21 x) => I47F17.FromBits(x.Bits / (1L << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I46F18(I43F21 x) => I46F18.FromBits(x.Bits / (1L << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I45F19(I43F21 x) => I45F19.FromBits(x.Bits / (1L << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I44F20(I43F21 x) => I44F20.FromBits(x.Bits / (1L << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I42F22(I43F21 x) => I42F22.FromBits(x.Bits * (1L << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I41F23(I43F21 x) => I41F23.FromBits(x.Bits * (1L << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I40F24(I43F21 x) => I40F24.FromBits(x.Bits * (1L << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I39F25(I43F21 x) => I39F25.FromBits(x.Bits * (1L << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I38F26(I43F21 x) => I38F26.FromBits(x.Bits * (1L << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I37F27(I43F21 x) => I37F27.FromBits(x.Bits * (1L << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I36F28(I43F21 x) => I36F28.FromBits(x.Bits * (1L << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I35F29(I43F21 x) => I35F29.FromBits(x.Bits * (1L << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I34F30(I43F21 x) => I34F30.FromBits(x.Bits * (1L << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I33F31(I43F21 x) => I33F31.FromBits(x.Bits * (1L << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I32F32(I43F21 x) => I32F32.FromBits(x.Bits * (1L << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F33(I43F21 x) => I31F33.FromBits(x.Bits * (1L << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F34(I43F21 x) => I30F34.FromBits(x.Bits * (1L << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F35(I43F21 x) => I29F35.FromBits(x.Bits * (1L << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F36(I43F21 x) => I28F36.FromBits(x.Bits * (1L << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F37(I43F21 x) => I27F37.FromBits(x.Bits * (1L << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F38(I43F21 x) => I26F38.FromBits(x.Bits * (1L << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F39(I43F21 x) => I25F39.FromBits(x.Bits * (1L << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F40(I43F21 x) => I24F40.FromBits(x.Bits * (1L << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F41(I43F21 x) => I23F41.FromBits(x.Bits * (1L << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F42(I43F21 x) => I22F42.FromBits(x.Bits * (1L << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F43(I43F21 x) => I21F43.FromBits(x.Bits * (1L << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F44(I43F21 x) => I20F44.FromBits(x.Bits * (1L << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F45(I43F21 x) => I19F45.FromBits(x.Bits * (1L << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F46(I43F21 x) => I18F46.FromBits(x.Bits * (1L << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F47(I43F21 x) => I17F47.FromBits(x.Bits * (1L << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F48(I43F21 x) => I16F48.FromBits(x.Bits * (1L << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F49(I43F21 x) => I15F49.FromBits(x.Bits * (1L << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F50(I43F21 x) => I14F50.FromBits(x.Bits * (1L << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F51(I43F21 x) => I13F51.FromBits(x.Bits * (1L << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F52(I43F21 x) => I12F52.FromBits(x.Bits * (1L << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F53(I43F21 x) => I11F53.FromBits(x.Bits * (1L << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F54(I43F21 x) => I10F54.FromBits(x.Bits * (1L << 33));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F55(I43F21 x) => I9F55.FromBits(x.Bits * (1L << 34));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F56(I43F21 x) => I8F56.FromBits(x.Bits * (1L << 35));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F57(I43F21 x) => I7F57.FromBits(x.Bits * (1L << 36));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F58(I43F21 x) => I6F58.FromBits(x.Bits * (1L << 37));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F59(I43F21 x) => I5F59.FromBits(x.Bits * (1L << 38));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F60(I43F21 x) => I4F60.FromBits(x.Bits * (1L << 39));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F61(I43F21 x) => I3F61.FromBits(x.Bits * (1L << 40));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F62(I43F21 x) => I2F62.FromBits(x.Bits * (1L << 41));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U63F1(I43F21 x) => U63F1.FromBits((ulong)(x.Bits / (1L << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U62F2(I43F21 x) => U62F2.FromBits((ulong)(x.Bits / (1L << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U61F3(I43F21 x) => U61F3.FromBits((ulong)(x.Bits / (1L << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U60F4(I43F21 x) => U60F4.FromBits((ulong)(x.Bits / (1L << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U59F5(I43F21 x) => U59F5.FromBits((ulong)(x.Bits / (1L << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U58F6(I43F21 x) => U58F6.FromBits((ulong)(x.Bits / (1L << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U57F7(I43F21 x) => U57F7.FromBits((ulong)(x.Bits / (1L << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U56F8(I43F21 x) => U56F8.FromBits((ulong)(x.Bits / (1L << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U55F9(I43F21 x) => U55F9.FromBits((ulong)(x.Bits / (1L << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U54F10(I43F21 x) => U54F10.FromBits((ulong)(x.Bits / (1L << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U53F11(I43F21 x) => U53F11.FromBits((ulong)(x.Bits / (1L << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U52F12(I43F21 x) => U52F12.FromBits((ulong)(x.Bits / (1L << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U51F13(I43F21 x) => U51F13.FromBits((ulong)(x.Bits / (1L << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U50F14(I43F21 x) => U50F14.FromBits((ulong)(x.Bits / (1L << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U49F15(I43F21 x) => U49F15.FromBits((ulong)(x.Bits / (1L << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U48F16(I43F21 x) => U48F16.FromBits((ulong)(x.Bits / (1L << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U47F17(I43F21 x) => U47F17.FromBits((ulong)(x.Bits / (1L << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U46F18(I43F21 x) => U46F18.FromBits((ulong)(x.Bits / (1L << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U45F19(I43F21 x) => U45F19.FromBits((ulong)(x.Bits / (1L << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U44F20(I43F21 x) => U44F20.FromBits((ulong)(x.Bits / (1L << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U43F21(I43F21 x) => U43F21.FromBits((ulong)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U42F22(I43F21 x) => U42F22.FromBits((ulong)x.Bits * (1UL << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U41F23(I43F21 x) => U41F23.FromBits((ulong)x.Bits * (1UL << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U40F24(I43F21 x) => U40F24.FromBits((ulong)x.Bits * (1UL << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U39F25(I43F21 x) => U39F25.FromBits((ulong)x.Bits * (1UL << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U38F26(I43F21 x) => U38F26.FromBits((ulong)x.Bits * (1UL << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U37F27(I43F21 x) => U37F27.FromBits((ulong)x.Bits * (1UL << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U36F28(I43F21 x) => U36F28.FromBits((ulong)x.Bits * (1UL << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U35F29(I43F21 x) => U35F29.FromBits((ulong)x.Bits * (1UL << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U34F30(I43F21 x) => U34F30.FromBits((ulong)x.Bits * (1UL << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U33F31(I43F21 x) => U33F31.FromBits((ulong)x.Bits * (1UL << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U32F32(I43F21 x) => U32F32.FromBits((ulong)x.Bits * (1UL << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F33(I43F21 x) => U31F33.FromBits((ulong)x.Bits * (1UL << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F34(I43F21 x) => U30F34.FromBits((ulong)x.Bits * (1UL << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F35(I43F21 x) => U29F35.FromBits((ulong)x.Bits * (1UL << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F36(I43F21 x) => U28F36.FromBits((ulong)x.Bits * (1UL << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F37(I43F21 x) => U27F37.FromBits((ulong)x.Bits * (1UL << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F38(I43F21 x) => U26F38.FromBits((ulong)x.Bits * (1UL << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F39(I43F21 x) => U25F39.FromBits((ulong)x.Bits * (1UL << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F40(I43F21 x) => U24F40.FromBits((ulong)x.Bits * (1UL << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F41(I43F21 x) => U23F41.FromBits((ulong)x.Bits * (1UL << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F42(I43F21 x) => U22F42.FromBits((ulong)x.Bits * (1UL << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F43(I43F21 x) => U21F43.FromBits((ulong)x.Bits * (1UL << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F44(I43F21 x) => U20F44.FromBits((ulong)x.Bits * (1UL << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F45(I43F21 x) => U19F45.FromBits((ulong)x.Bits * (1UL << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F46(I43F21 x) => U18F46.FromBits((ulong)x.Bits * (1UL << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F47(I43F21 x) => U17F47.FromBits((ulong)x.Bits * (1UL << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F48(I43F21 x) => U16F48.FromBits((ulong)x.Bits * (1UL << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F49(I43F21 x) => U15F49.FromBits((ulong)x.Bits * (1UL << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F50(I43F21 x) => U14F50.FromBits((ulong)x.Bits * (1UL << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F51(I43F21 x) => U13F51.FromBits((ulong)x.Bits * (1UL << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F52(I43F21 x) => U12F52.FromBits((ulong)x.Bits * (1UL << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F53(I43F21 x) => U11F53.FromBits((ulong)x.Bits * (1UL << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F54(I43F21 x) => U10F54.FromBits((ulong)x.Bits * (1UL << 33));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F55(I43F21 x) => U9F55.FromBits((ulong)x.Bits * (1UL << 34));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F56(I43F21 x) => U8F56.FromBits((ulong)x.Bits * (1UL << 35));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F57(I43F21 x) => U7F57.FromBits((ulong)x.Bits * (1UL << 36));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F58(I43F21 x) => U6F58.FromBits((ulong)x.Bits * (1UL << 37));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F59(I43F21 x) => U5F59.FromBits((ulong)x.Bits * (1UL << 38));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F60(I43F21 x) => U4F60.FromBits((ulong)x.Bits * (1UL << 39));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F61(I43F21 x) => U3F61.FromBits((ulong)x.Bits * (1UL << 40));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F62(I43F21 x) => U2F62.FromBits((ulong)x.Bits * (1UL << 41));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is I43F21 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<I43F21>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(I43F21 other) => bits == other.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
