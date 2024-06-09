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

    public struct I58F6 : IEquatable<I58F6>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 58;
        public const int FracNbits = 6;

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

        public static readonly I58F6 Zero = FromNum(0);
        public static readonly I58F6 One = FromNum(1);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I58F6(long bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I58F6 FromBits(long bits) => new I58F6(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I58F6 FromNum(long num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I58F6 operator +(I58F6 left, I58F6 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I58F6 operator -(I58F6 left, I58F6 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I58F6 operator *(I58F6 left, I58F6 right) {
            Int128 l = left.Bits;
            return FromBits((long)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I58F6 operator /(I58F6 left, I58F6 right) {
            Int128 l = left.Bits;
            return FromBits((long)(l * oneRepr / right.Bits));
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I58F6 operator -(I58F6 x) => FromBits(-x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I58F6 lhs, I58F6 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I58F6 lhs, I58F6 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I58F6 left, I58F6 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I58F6 left, I58F6 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I58F6 left, I58F6 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I58F6 left, I58F6 right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I58F6 Min(I58F6 other) => FromBits(System.Math.Min(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I58F6 Max(I58F6 other) => FromBits(System.Math.Max(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I58F6 Clamp(I58F6 min, I58F6 max) => FromBits(Math.Clamp(bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I57F7 LosslessMul(I63F1 other) => I57F7.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I56F8 LosslessMul(I62F2 other) => I56F8.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I55F9 LosslessMul(I61F3 other) => I55F9.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I54F10 LosslessMul(I60F4 other) => I54F10.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I53F11 LosslessMul(I59F5 other) => I53F11.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I52F12 LosslessMul(I58F6 other) => I52F12.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I51F13 LosslessMul(I57F7 other) => I51F13.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I50F14 LosslessMul(I56F8 other) => I50F14.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I49F15 LosslessMul(I55F9 other) => I49F15.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I48F16 LosslessMul(I54F10 other) => I48F16.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I47F17 LosslessMul(I53F11 other) => I47F17.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I46F18 LosslessMul(I52F12 other) => I46F18.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I45F19 LosslessMul(I51F13 other) => I45F19.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I44F20 LosslessMul(I50F14 other) => I44F20.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I43F21 LosslessMul(I49F15 other) => I43F21.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I42F22 LosslessMul(I48F16 other) => I42F22.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I41F23 LosslessMul(I47F17 other) => I41F23.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I40F24 LosslessMul(I46F18 other) => I40F24.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I39F25 LosslessMul(I45F19 other) => I39F25.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I38F26 LosslessMul(I44F20 other) => I38F26.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I37F27 LosslessMul(I43F21 other) => I37F27.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I36F28 LosslessMul(I42F22 other) => I36F28.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I35F29 LosslessMul(I41F23 other) => I35F29.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 LosslessMul(I40F24 other) => I34F30.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I33F31 LosslessMul(I39F25 other) => I33F31.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I32F32 LosslessMul(I38F26 other) => I32F32.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I31F33 LosslessMul(I37F27 other) => I31F33.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I30F34 LosslessMul(I36F28 other) => I30F34.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I29F35 LosslessMul(I35F29 other) => I29F35.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I28F36 LosslessMul(I34F30 other) => I28F36.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I27F37 LosslessMul(I33F31 other) => I27F37.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I26F38 LosslessMul(I32F32 other) => I26F38.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I25F39 LosslessMul(I31F33 other) => I25F39.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I24F40 LosslessMul(I30F34 other) => I24F40.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I23F41 LosslessMul(I29F35 other) => I23F41.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I22F42 LosslessMul(I28F36 other) => I22F42.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I21F43 LosslessMul(I27F37 other) => I21F43.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I20F44 LosslessMul(I26F38 other) => I20F44.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I19F45 LosslessMul(I25F39 other) => I19F45.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F46 LosslessMul(I24F40 other) => I18F46.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F47 LosslessMul(I23F41 other) => I17F47.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I16F48 LosslessMul(I22F42 other) => I16F48.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I15F49 LosslessMul(I21F43 other) => I15F49.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I14F50 LosslessMul(I20F44 other) => I14F50.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I13F51 LosslessMul(I19F45 other) => I13F51.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I12F52 LosslessMul(I18F46 other) => I12F52.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I11F53 LosslessMul(I17F47 other) => I11F53.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I10F54 LosslessMul(I16F48 other) => I10F54.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I9F55 LosslessMul(I15F49 other) => I9F55.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I8F56 LosslessMul(I14F50 other) => I8F56.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I7F57 LosslessMul(I13F51 other) => I7F57.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I6F58 LosslessMul(I12F52 other) => I6F58.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I5F59 LosslessMul(I11F53 other) => I5F59.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I4F60 LosslessMul(I10F54 other) => I4F60.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I3F61 LosslessMul(I9F55 other) => I3F61.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F62 LosslessMul(I8F56 other) => I2F62.FromBits(bits * other.Bits);

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(I58F6 x) => (int)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(I58F6 x) => (uint)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(I58F6 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(I58F6 x) => (ulong)(x.bits / oneRepr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I58F6 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I58F6 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I58F6 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(I58F6 x) => I31F1.FromBits((int)(x.Bits / (1L << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(I58F6 x) => I30F2.FromBits((int)(x.Bits / (1L << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(I58F6 x) => I29F3.FromBits((int)(x.Bits / (1L << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(I58F6 x) => I28F4.FromBits((int)(x.Bits / (1L << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(I58F6 x) => I27F5.FromBits((int)(x.Bits / (1L << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(I58F6 x) => I25F7.FromBits((int)x.Bits * (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(I58F6 x) => I24F8.FromBits((int)x.Bits * (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(I58F6 x) => I23F9.FromBits((int)x.Bits * (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(I58F6 x) => I22F10.FromBits((int)x.Bits * (1 << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(I58F6 x) => I21F11.FromBits((int)x.Bits * (1 << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(I58F6 x) => I20F12.FromBits((int)x.Bits * (1 << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(I58F6 x) => I19F13.FromBits((int)x.Bits * (1 << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(I58F6 x) => I18F14.FromBits((int)x.Bits * (1 << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(I58F6 x) => I17F15.FromBits((int)x.Bits * (1 << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(I58F6 x) => I16F16.FromBits((int)x.Bits * (1 << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(I58F6 x) => I15F17.FromBits((int)x.Bits * (1 << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(I58F6 x) => I14F18.FromBits((int)x.Bits * (1 << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(I58F6 x) => I13F19.FromBits((int)x.Bits * (1 << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(I58F6 x) => I12F20.FromBits((int)x.Bits * (1 << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(I58F6 x) => I11F21.FromBits((int)x.Bits * (1 << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(I58F6 x) => I10F22.FromBits((int)x.Bits * (1 << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(I58F6 x) => I9F23.FromBits((int)x.Bits * (1 << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(I58F6 x) => I8F24.FromBits((int)x.Bits * (1 << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(I58F6 x) => I7F25.FromBits((int)x.Bits * (1 << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(I58F6 x) => I6F26.FromBits((int)x.Bits * (1 << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(I58F6 x) => I5F27.FromBits((int)x.Bits * (1 << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(I58F6 x) => I4F28.FromBits((int)x.Bits * (1 << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(I58F6 x) => I3F29.FromBits((int)x.Bits * (1 << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(I58F6 x) => I2F30.FromBits((int)x.Bits * (1 << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(I58F6 x) => U31F1.FromBits((uint)(x.Bits / (1L << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(I58F6 x) => U30F2.FromBits((uint)(x.Bits / (1L << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(I58F6 x) => U29F3.FromBits((uint)(x.Bits / (1L << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(I58F6 x) => U28F4.FromBits((uint)(x.Bits / (1L << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(I58F6 x) => U27F5.FromBits((uint)(x.Bits / (1L << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(I58F6 x) => U25F7.FromBits((uint)x.Bits * (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(I58F6 x) => U24F8.FromBits((uint)x.Bits * (1U << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(I58F6 x) => U23F9.FromBits((uint)x.Bits * (1U << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(I58F6 x) => U22F10.FromBits((uint)x.Bits * (1U << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(I58F6 x) => U21F11.FromBits((uint)x.Bits * (1U << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(I58F6 x) => U20F12.FromBits((uint)x.Bits * (1U << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(I58F6 x) => U19F13.FromBits((uint)x.Bits * (1U << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(I58F6 x) => U18F14.FromBits((uint)x.Bits * (1U << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(I58F6 x) => U17F15.FromBits((uint)x.Bits * (1U << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(I58F6 x) => U16F16.FromBits((uint)x.Bits * (1U << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(I58F6 x) => U15F17.FromBits((uint)x.Bits * (1U << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(I58F6 x) => U14F18.FromBits((uint)x.Bits * (1U << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(I58F6 x) => U13F19.FromBits((uint)x.Bits * (1U << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(I58F6 x) => U12F20.FromBits((uint)x.Bits * (1U << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(I58F6 x) => U11F21.FromBits((uint)x.Bits * (1U << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(I58F6 x) => U10F22.FromBits((uint)x.Bits * (1U << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(I58F6 x) => U9F23.FromBits((uint)x.Bits * (1U << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(I58F6 x) => U8F24.FromBits((uint)x.Bits * (1U << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(I58F6 x) => U7F25.FromBits((uint)x.Bits * (1U << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(I58F6 x) => U6F26.FromBits((uint)x.Bits * (1U << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(I58F6 x) => U5F27.FromBits((uint)x.Bits * (1U << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(I58F6 x) => U4F28.FromBits((uint)x.Bits * (1U << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(I58F6 x) => U3F29.FromBits((uint)x.Bits * (1U << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(I58F6 x) => U2F30.FromBits((uint)x.Bits * (1U << 24));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is I58F6 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<I58F6>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(I58F6 rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
