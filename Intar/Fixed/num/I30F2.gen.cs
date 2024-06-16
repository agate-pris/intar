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

    struct I30F2 : IEquatable<I30F2>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 30;
        public const int FracNbits = 2;

        const int oneRepr = 1 << FracNbits;

        // Fields
        // ------

#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif

        int bits;

        // Properties
        // ----------

        public readonly int Bits {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => bits;
        }

        // Static readonly properties
        // --------------------------

        public static readonly I30F2 Zero = FromNum(0);
        public static readonly I30F2 One = FromNum(1);
        public static readonly I30F2 MinValue = FromBits(int.MinValue);
        public static readonly I30F2 MaxValue = FromBits(int.MaxValue);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I30F2(int bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I30F2 FromBits(int bits) => new I30F2(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I30F2 FromNum(int num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I30F2 operator +(I30F2 left, I30F2 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I30F2 operator -(I30F2 left, I30F2 right) {
            return FromBits(left.Bits - right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I30F2 operator *(I30F2 left, I30F2 right) {
            long l = left.Bits;
            return FromBits((int)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I30F2 operator /(I30F2 left, I30F2 right) {
            long l = left.Bits;
            return FromBits((int)(l * oneRepr / right.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I30F2 operator +(I30F2 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I30F2 operator -(I30F2 x) => FromBits(-x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I30F2 lhs, I30F2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I30F2 lhs, I30F2 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I30F2 left, I30F2 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I30F2 left, I30F2 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I30F2 left, I30F2 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I30F2 left, I30F2 right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I30F2 Min(I30F2 other) => FromBits(Math.Min(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I30F2 Max(I30F2 other) => FromBits(Math.Max(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I30F2 Clamp(I30F2 min, I30F2 max) => FromBits(Mathi.Clamp(bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I30F2 Abs() => FromBits(System.Math.Abs(bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I30F2 LosslessMul(int other) => FromBits(bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I29F3 LosslessMul(I31F1 other) => I29F3.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I28F4 LosslessMul(I30F2 other) => I28F4.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I27F5 LosslessMul(I29F3 other) => I27F5.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I26F6 LosslessMul(I28F4 other) => I26F6.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I25F7 LosslessMul(I27F5 other) => I25F7.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I24F8 LosslessMul(I26F6 other) => I24F8.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I23F9 LosslessMul(I25F7 other) => I23F9.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I22F10 LosslessMul(I24F8 other) => I22F10.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I21F11 LosslessMul(I23F9 other) => I21F11.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I20F12 LosslessMul(I22F10 other) => I20F12.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I19F13 LosslessMul(I21F11 other) => I19F13.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I18F14 LosslessMul(I20F12 other) => I18F14.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I17F15 LosslessMul(I19F13 other) => I17F15.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I16F16 LosslessMul(I18F14 other) => I16F16.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I15F17 LosslessMul(I17F15 other) => I15F17.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I14F18 LosslessMul(I16F16 other) => I14F18.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I13F19 LosslessMul(I15F17 other) => I13F19.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I12F20 LosslessMul(I14F18 other) => I12F20.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I11F21 LosslessMul(I13F19 other) => I11F21.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I10F22 LosslessMul(I12F20 other) => I10F22.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I9F23 LosslessMul(I11F21 other) => I9F23.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I8F24 LosslessMul(I10F22 other) => I8F24.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I7F25 LosslessMul(I9F23 other) => I7F25.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I6F26 LosslessMul(I8F24 other) => I6F26.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I5F27 LosslessMul(I7F25 other) => I5F27.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I4F28 LosslessMul(I6F26 other) => I4F28.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I3F29 LosslessMul(I5F27 other) => I3F29.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly I2F30 LosslessMul(I4F28 other) => I2F30.FromBits(bits * other.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I62F2 WideningMul(int other) => I62F2.FromBits((long)bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I61F3 WideningMul(I31F1 other) => I61F3.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I60F4 WideningMul(I30F2 other) => I60F4.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I59F5 WideningMul(I29F3 other) => I59F5.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I58F6 WideningMul(I28F4 other) => I58F6.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I57F7 WideningMul(I27F5 other) => I57F7.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I56F8 WideningMul(I26F6 other) => I56F8.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I55F9 WideningMul(I25F7 other) => I55F9.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I54F10 WideningMul(I24F8 other) => I54F10.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I53F11 WideningMul(I23F9 other) => I53F11.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I52F12 WideningMul(I22F10 other) => I52F12.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I51F13 WideningMul(I21F11 other) => I51F13.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I50F14 WideningMul(I20F12 other) => I50F14.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I49F15 WideningMul(I19F13 other) => I49F15.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I48F16 WideningMul(I18F14 other) => I48F16.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I47F17 WideningMul(I17F15 other) => I47F17.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I46F18 WideningMul(I16F16 other) => I46F18.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I45F19 WideningMul(I15F17 other) => I45F19.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I44F20 WideningMul(I14F18 other) => I44F20.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I43F21 WideningMul(I13F19 other) => I43F21.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I42F22 WideningMul(I12F20 other) => I42F22.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I41F23 WideningMul(I11F21 other) => I41F23.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I40F24 WideningMul(I10F22 other) => I40F24.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I39F25 WideningMul(I9F23 other) => I39F25.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I38F26 WideningMul(I8F24 other) => I38F26.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I37F27 WideningMul(I7F25 other) => I37F27.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I36F28 WideningMul(I6F26 other) => I36F28.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I35F29 WideningMul(I5F27 other) => I35F29.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 WideningMul(I4F28 other) => I34F30.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I33F31 WideningMul(I3F29 other) => I33F31.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I32F32 WideningMul(I2F30 other) => I32F32.FromBits((long)bits * other.Bits);

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(I30F2 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(I30F2 x) => (uint)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(I30F2 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(I30F2 x) => (ulong)(x.bits / oneRepr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I30F2 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I30F2 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I30F2 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(I30F2 x) => I31F1.FromBits(x.Bits / (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(I30F2 x) => I29F3.FromBits(x.Bits * (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(I30F2 x) => I28F4.FromBits(x.Bits * (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(I30F2 x) => I27F5.FromBits(x.Bits * (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(I30F2 x) => I26F6.FromBits(x.Bits * (1 << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(I30F2 x) => I25F7.FromBits(x.Bits * (1 << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(I30F2 x) => I24F8.FromBits(x.Bits * (1 << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(I30F2 x) => I23F9.FromBits(x.Bits * (1 << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(I30F2 x) => I22F10.FromBits(x.Bits * (1 << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(I30F2 x) => I21F11.FromBits(x.Bits * (1 << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(I30F2 x) => I20F12.FromBits(x.Bits * (1 << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(I30F2 x) => I19F13.FromBits(x.Bits * (1 << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(I30F2 x) => I18F14.FromBits(x.Bits * (1 << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(I30F2 x) => I17F15.FromBits(x.Bits * (1 << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(I30F2 x) => I16F16.FromBits(x.Bits * (1 << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(I30F2 x) => I15F17.FromBits(x.Bits * (1 << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(I30F2 x) => I14F18.FromBits(x.Bits * (1 << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(I30F2 x) => I13F19.FromBits(x.Bits * (1 << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(I30F2 x) => I12F20.FromBits(x.Bits * (1 << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(I30F2 x) => I11F21.FromBits(x.Bits * (1 << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(I30F2 x) => I10F22.FromBits(x.Bits * (1 << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(I30F2 x) => I9F23.FromBits(x.Bits * (1 << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(I30F2 x) => I8F24.FromBits(x.Bits * (1 << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(I30F2 x) => I7F25.FromBits(x.Bits * (1 << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(I30F2 x) => I6F26.FromBits(x.Bits * (1 << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(I30F2 x) => I5F27.FromBits(x.Bits * (1 << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(I30F2 x) => I4F28.FromBits(x.Bits * (1 << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(I30F2 x) => I3F29.FromBits(x.Bits * (1 << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(I30F2 x) => I2F30.FromBits(x.Bits * (1 << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(I30F2 x) => U31F1.FromBits((uint)(x.Bits / (1 << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(I30F2 x) => U30F2.FromBits((uint)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(I30F2 x) => U29F3.FromBits((uint)x.Bits * (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(I30F2 x) => U28F4.FromBits((uint)x.Bits * (1U << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(I30F2 x) => U27F5.FromBits((uint)x.Bits * (1U << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(I30F2 x) => U26F6.FromBits((uint)x.Bits * (1U << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(I30F2 x) => U25F7.FromBits((uint)x.Bits * (1U << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(I30F2 x) => U24F8.FromBits((uint)x.Bits * (1U << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(I30F2 x) => U23F9.FromBits((uint)x.Bits * (1U << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(I30F2 x) => U22F10.FromBits((uint)x.Bits * (1U << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(I30F2 x) => U21F11.FromBits((uint)x.Bits * (1U << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(I30F2 x) => U20F12.FromBits((uint)x.Bits * (1U << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(I30F2 x) => U19F13.FromBits((uint)x.Bits * (1U << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(I30F2 x) => U18F14.FromBits((uint)x.Bits * (1U << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(I30F2 x) => U17F15.FromBits((uint)x.Bits * (1U << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(I30F2 x) => U16F16.FromBits((uint)x.Bits * (1U << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(I30F2 x) => U15F17.FromBits((uint)x.Bits * (1U << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(I30F2 x) => U14F18.FromBits((uint)x.Bits * (1U << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(I30F2 x) => U13F19.FromBits((uint)x.Bits * (1U << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(I30F2 x) => U12F20.FromBits((uint)x.Bits * (1U << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(I30F2 x) => U11F21.FromBits((uint)x.Bits * (1U << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(I30F2 x) => U10F22.FromBits((uint)x.Bits * (1U << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(I30F2 x) => U9F23.FromBits((uint)x.Bits * (1U << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(I30F2 x) => U8F24.FromBits((uint)x.Bits * (1U << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(I30F2 x) => U7F25.FromBits((uint)x.Bits * (1U << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(I30F2 x) => U6F26.FromBits((uint)x.Bits * (1U << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(I30F2 x) => U5F27.FromBits((uint)x.Bits * (1U << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(I30F2 x) => U4F28.FromBits((uint)x.Bits * (1U << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(I30F2 x) => U3F29.FromBits((uint)x.Bits * (1U << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(I30F2 x) => U2F30.FromBits((uint)x.Bits * (1U << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I63F1(I30F2 x) => I63F1.FromBits(x.Bits / (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I62F2(I30F2 x) => I62F2.FromBits(x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I61F3(I30F2 x) => I61F3.FromBits(x.Bits * (1L << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I60F4(I30F2 x) => I60F4.FromBits(x.Bits * (1L << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I59F5(I30F2 x) => I59F5.FromBits(x.Bits * (1L << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I58F6(I30F2 x) => I58F6.FromBits(x.Bits * (1L << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I57F7(I30F2 x) => I57F7.FromBits(x.Bits * (1L << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I56F8(I30F2 x) => I56F8.FromBits(x.Bits * (1L << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I55F9(I30F2 x) => I55F9.FromBits(x.Bits * (1L << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I54F10(I30F2 x) => I54F10.FromBits(x.Bits * (1L << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I53F11(I30F2 x) => I53F11.FromBits(x.Bits * (1L << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I52F12(I30F2 x) => I52F12.FromBits(x.Bits * (1L << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I51F13(I30F2 x) => I51F13.FromBits(x.Bits * (1L << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I50F14(I30F2 x) => I50F14.FromBits(x.Bits * (1L << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I49F15(I30F2 x) => I49F15.FromBits(x.Bits * (1L << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I48F16(I30F2 x) => I48F16.FromBits(x.Bits * (1L << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I47F17(I30F2 x) => I47F17.FromBits(x.Bits * (1L << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I46F18(I30F2 x) => I46F18.FromBits(x.Bits * (1L << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I45F19(I30F2 x) => I45F19.FromBits(x.Bits * (1L << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I44F20(I30F2 x) => I44F20.FromBits(x.Bits * (1L << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I43F21(I30F2 x) => I43F21.FromBits(x.Bits * (1L << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I42F22(I30F2 x) => I42F22.FromBits(x.Bits * (1L << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I41F23(I30F2 x) => I41F23.FromBits(x.Bits * (1L << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I40F24(I30F2 x) => I40F24.FromBits(x.Bits * (1L << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I39F25(I30F2 x) => I39F25.FromBits(x.Bits * (1L << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I38F26(I30F2 x) => I38F26.FromBits(x.Bits * (1L << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I37F27(I30F2 x) => I37F27.FromBits(x.Bits * (1L << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I36F28(I30F2 x) => I36F28.FromBits(x.Bits * (1L << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I35F29(I30F2 x) => I35F29.FromBits(x.Bits * (1L << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I34F30(I30F2 x) => I34F30.FromBits(x.Bits * (1L << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I33F31(I30F2 x) => I33F31.FromBits(x.Bits * (1L << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I32F32(I30F2 x) => I32F32.FromBits(x.Bits * (1L << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I31F33(I30F2 x) => I31F33.FromBits(x.Bits * (1L << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I30F34(I30F2 x) => I30F34.FromBits(x.Bits * (1L << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F35(I30F2 x) => I29F35.FromBits(x.Bits * (1L << 33));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F36(I30F2 x) => I28F36.FromBits(x.Bits * (1L << 34));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F37(I30F2 x) => I27F37.FromBits(x.Bits * (1L << 35));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F38(I30F2 x) => I26F38.FromBits(x.Bits * (1L << 36));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F39(I30F2 x) => I25F39.FromBits(x.Bits * (1L << 37));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F40(I30F2 x) => I24F40.FromBits(x.Bits * (1L << 38));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F41(I30F2 x) => I23F41.FromBits(x.Bits * (1L << 39));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F42(I30F2 x) => I22F42.FromBits(x.Bits * (1L << 40));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F43(I30F2 x) => I21F43.FromBits(x.Bits * (1L << 41));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F44(I30F2 x) => I20F44.FromBits(x.Bits * (1L << 42));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F45(I30F2 x) => I19F45.FromBits(x.Bits * (1L << 43));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F46(I30F2 x) => I18F46.FromBits(x.Bits * (1L << 44));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F47(I30F2 x) => I17F47.FromBits(x.Bits * (1L << 45));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F48(I30F2 x) => I16F48.FromBits(x.Bits * (1L << 46));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F49(I30F2 x) => I15F49.FromBits(x.Bits * (1L << 47));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F50(I30F2 x) => I14F50.FromBits(x.Bits * (1L << 48));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F51(I30F2 x) => I13F51.FromBits(x.Bits * (1L << 49));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F52(I30F2 x) => I12F52.FromBits(x.Bits * (1L << 50));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F53(I30F2 x) => I11F53.FromBits(x.Bits * (1L << 51));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F54(I30F2 x) => I10F54.FromBits(x.Bits * (1L << 52));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F55(I30F2 x) => I9F55.FromBits(x.Bits * (1L << 53));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F56(I30F2 x) => I8F56.FromBits(x.Bits * (1L << 54));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F57(I30F2 x) => I7F57.FromBits(x.Bits * (1L << 55));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F58(I30F2 x) => I6F58.FromBits(x.Bits * (1L << 56));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F59(I30F2 x) => I5F59.FromBits(x.Bits * (1L << 57));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F60(I30F2 x) => I4F60.FromBits(x.Bits * (1L << 58));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F61(I30F2 x) => I3F61.FromBits(x.Bits * (1L << 59));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F62(I30F2 x) => I2F62.FromBits(x.Bits * (1L << 60));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U63F1(I30F2 x) => U63F1.FromBits((ulong)(x.Bits / (1 << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U62F2(I30F2 x) => U62F2.FromBits((ulong)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U61F3(I30F2 x) => U61F3.FromBits((ulong)x.Bits * (1UL << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U60F4(I30F2 x) => U60F4.FromBits((ulong)x.Bits * (1UL << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U59F5(I30F2 x) => U59F5.FromBits((ulong)x.Bits * (1UL << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U58F6(I30F2 x) => U58F6.FromBits((ulong)x.Bits * (1UL << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U57F7(I30F2 x) => U57F7.FromBits((ulong)x.Bits * (1UL << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U56F8(I30F2 x) => U56F8.FromBits((ulong)x.Bits * (1UL << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U55F9(I30F2 x) => U55F9.FromBits((ulong)x.Bits * (1UL << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U54F10(I30F2 x) => U54F10.FromBits((ulong)x.Bits * (1UL << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U53F11(I30F2 x) => U53F11.FromBits((ulong)x.Bits * (1UL << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U52F12(I30F2 x) => U52F12.FromBits((ulong)x.Bits * (1UL << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U51F13(I30F2 x) => U51F13.FromBits((ulong)x.Bits * (1UL << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U50F14(I30F2 x) => U50F14.FromBits((ulong)x.Bits * (1UL << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U49F15(I30F2 x) => U49F15.FromBits((ulong)x.Bits * (1UL << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U48F16(I30F2 x) => U48F16.FromBits((ulong)x.Bits * (1UL << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U47F17(I30F2 x) => U47F17.FromBits((ulong)x.Bits * (1UL << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U46F18(I30F2 x) => U46F18.FromBits((ulong)x.Bits * (1UL << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U45F19(I30F2 x) => U45F19.FromBits((ulong)x.Bits * (1UL << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U44F20(I30F2 x) => U44F20.FromBits((ulong)x.Bits * (1UL << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U43F21(I30F2 x) => U43F21.FromBits((ulong)x.Bits * (1UL << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U42F22(I30F2 x) => U42F22.FromBits((ulong)x.Bits * (1UL << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U41F23(I30F2 x) => U41F23.FromBits((ulong)x.Bits * (1UL << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U40F24(I30F2 x) => U40F24.FromBits((ulong)x.Bits * (1UL << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U39F25(I30F2 x) => U39F25.FromBits((ulong)x.Bits * (1UL << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U38F26(I30F2 x) => U38F26.FromBits((ulong)x.Bits * (1UL << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U37F27(I30F2 x) => U37F27.FromBits((ulong)x.Bits * (1UL << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U36F28(I30F2 x) => U36F28.FromBits((ulong)x.Bits * (1UL << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U35F29(I30F2 x) => U35F29.FromBits((ulong)x.Bits * (1UL << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U34F30(I30F2 x) => U34F30.FromBits((ulong)x.Bits * (1UL << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U33F31(I30F2 x) => U33F31.FromBits((ulong)x.Bits * (1UL << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U32F32(I30F2 x) => U32F32.FromBits((ulong)x.Bits * (1UL << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F33(I30F2 x) => U31F33.FromBits((ulong)x.Bits * (1UL << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F34(I30F2 x) => U30F34.FromBits((ulong)x.Bits * (1UL << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F35(I30F2 x) => U29F35.FromBits((ulong)x.Bits * (1UL << 33));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F36(I30F2 x) => U28F36.FromBits((ulong)x.Bits * (1UL << 34));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F37(I30F2 x) => U27F37.FromBits((ulong)x.Bits * (1UL << 35));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F38(I30F2 x) => U26F38.FromBits((ulong)x.Bits * (1UL << 36));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F39(I30F2 x) => U25F39.FromBits((ulong)x.Bits * (1UL << 37));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F40(I30F2 x) => U24F40.FromBits((ulong)x.Bits * (1UL << 38));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F41(I30F2 x) => U23F41.FromBits((ulong)x.Bits * (1UL << 39));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F42(I30F2 x) => U22F42.FromBits((ulong)x.Bits * (1UL << 40));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F43(I30F2 x) => U21F43.FromBits((ulong)x.Bits * (1UL << 41));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F44(I30F2 x) => U20F44.FromBits((ulong)x.Bits * (1UL << 42));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F45(I30F2 x) => U19F45.FromBits((ulong)x.Bits * (1UL << 43));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F46(I30F2 x) => U18F46.FromBits((ulong)x.Bits * (1UL << 44));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F47(I30F2 x) => U17F47.FromBits((ulong)x.Bits * (1UL << 45));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F48(I30F2 x) => U16F48.FromBits((ulong)x.Bits * (1UL << 46));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F49(I30F2 x) => U15F49.FromBits((ulong)x.Bits * (1UL << 47));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F50(I30F2 x) => U14F50.FromBits((ulong)x.Bits * (1UL << 48));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F51(I30F2 x) => U13F51.FromBits((ulong)x.Bits * (1UL << 49));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F52(I30F2 x) => U12F52.FromBits((ulong)x.Bits * (1UL << 50));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F53(I30F2 x) => U11F53.FromBits((ulong)x.Bits * (1UL << 51));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F54(I30F2 x) => U10F54.FromBits((ulong)x.Bits * (1UL << 52));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F55(I30F2 x) => U9F55.FromBits((ulong)x.Bits * (1UL << 53));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F56(I30F2 x) => U8F56.FromBits((ulong)x.Bits * (1UL << 54));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F57(I30F2 x) => U7F57.FromBits((ulong)x.Bits * (1UL << 55));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F58(I30F2 x) => U6F58.FromBits((ulong)x.Bits * (1UL << 56));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F59(I30F2 x) => U5F59.FromBits((ulong)x.Bits * (1UL << 57));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F60(I30F2 x) => U4F60.FromBits((ulong)x.Bits * (1UL << 58));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F61(I30F2 x) => U3F61.FromBits((ulong)x.Bits * (1UL << 59));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F62(I30F2 x) => U2F62.FromBits((ulong)x.Bits * (1UL << 60));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is I30F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<I30F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(I30F2 other) => bits == other.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
