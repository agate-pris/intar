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

    struct U24F8 : IEquatable<U24F8>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 24;
        public const int FracNbits = 8;

        const uint oneRepr = 1U << FracNbits;

        // Fields
        // ------

#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif

        uint bits;

        // Properties
        // ----------

        public readonly uint Bits {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => bits;
        }

        // Static readonly properties
        // --------------------------

        public static readonly U24F8 Zero = FromNum(0);
        public static readonly U24F8 One = FromNum(1);
        public static readonly U24F8 MinValue = FromBits(uint.MinValue);
        public static readonly U24F8 MaxValue = FromBits(uint.MaxValue);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        U24F8(uint bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F8 FromBits(uint bits) => new U24F8(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F8 FromNum(uint num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F8 operator +(U24F8 left, U24F8 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F8 operator -(U24F8 left, U24F8 right) {
            return FromBits(left.Bits - right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F8 operator *(U24F8 left, U24F8 right) {
            ulong l = left.Bits;
            return FromBits((uint)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F8 operator /(U24F8 left, U24F8 right) {
            ulong l = left.Bits;
            return FromBits((uint)(l * oneRepr / right.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U24F8 operator +(U24F8 x) => FromBits(+x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U24F8 lhs, U24F8 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U24F8 lhs, U24F8 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U24F8 left, U24F8 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U24F8 left, U24F8 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U24F8 left, U24F8 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U24F8 left, U24F8 right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U24F8 Min(U24F8 other) => FromBits(System.Math.Min(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U24F8 Max(U24F8 other) => FromBits(System.Math.Max(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U24F8 Clamp(U24F8 min, U24F8 max) => FromBits(Math.Clamp(bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U24F8 LosslessMul(uint other) => FromBits(bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U23F9 LosslessMul(U31F1 other) => U23F9.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U22F10 LosslessMul(U30F2 other) => U22F10.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U21F11 LosslessMul(U29F3 other) => U21F11.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U20F12 LosslessMul(U28F4 other) => U20F12.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U19F13 LosslessMul(U27F5 other) => U19F13.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U18F14 LosslessMul(U26F6 other) => U18F14.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U17F15 LosslessMul(U25F7 other) => U17F15.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U16F16 LosslessMul(U24F8 other) => U16F16.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U15F17 LosslessMul(U23F9 other) => U15F17.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U14F18 LosslessMul(U22F10 other) => U14F18.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U13F19 LosslessMul(U21F11 other) => U13F19.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U12F20 LosslessMul(U20F12 other) => U12F20.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U11F21 LosslessMul(U19F13 other) => U11F21.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U10F22 LosslessMul(U18F14 other) => U10F22.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U9F23 LosslessMul(U17F15 other) => U9F23.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U8F24 LosslessMul(U16F16 other) => U8F24.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U7F25 LosslessMul(U15F17 other) => U7F25.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U6F26 LosslessMul(U14F18 other) => U6F26.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U5F27 LosslessMul(U13F19 other) => U5F27.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U4F28 LosslessMul(U12F20 other) => U4F28.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U3F29 LosslessMul(U11F21 other) => U3F29.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public readonly U2F30 LosslessMul(U10F22 other) => U2F30.FromBits(bits * other.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U56F8 WideningMul(uint other) => U56F8.FromBits((ulong)bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U55F9 WideningMul(U31F1 other) => U55F9.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U54F10 WideningMul(U30F2 other) => U54F10.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U53F11 WideningMul(U29F3 other) => U53F11.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U52F12 WideningMul(U28F4 other) => U52F12.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U51F13 WideningMul(U27F5 other) => U51F13.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U50F14 WideningMul(U26F6 other) => U50F14.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U49F15 WideningMul(U25F7 other) => U49F15.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U48F16 WideningMul(U24F8 other) => U48F16.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U47F17 WideningMul(U23F9 other) => U47F17.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U46F18 WideningMul(U22F10 other) => U46F18.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U45F19 WideningMul(U21F11 other) => U45F19.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U44F20 WideningMul(U20F12 other) => U44F20.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U43F21 WideningMul(U19F13 other) => U43F21.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U42F22 WideningMul(U18F14 other) => U42F22.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U41F23 WideningMul(U17F15 other) => U41F23.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U40F24 WideningMul(U16F16 other) => U40F24.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U39F25 WideningMul(U15F17 other) => U39F25.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U38F26 WideningMul(U14F18 other) => U38F26.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U37F27 WideningMul(U13F19 other) => U37F27.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U36F28 WideningMul(U12F20 other) => U36F28.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U35F29 WideningMul(U11F21 other) => U35F29.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 WideningMul(U10F22 other) => U34F30.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U33F31 WideningMul(U9F23 other) => U33F31.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U32F32 WideningMul(U8F24 other) => U32F32.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U31F33 WideningMul(U7F25 other) => U31F33.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U30F34 WideningMul(U6F26 other) => U30F34.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U29F35 WideningMul(U5F27 other) => U29F35.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U28F36 WideningMul(U4F28 other) => U28F36.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U27F37 WideningMul(U3F29 other) => U27F37.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U26F38 WideningMul(U2F30 other) => U26F38.FromBits((ulong)bits * other.Bits);

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(U24F8 x) => (int)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(U24F8 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(U24F8 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(U24F8 x) => x.bits / oneRepr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(U24F8 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(U24F8 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(U24F8 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(U24F8 x) => I31F1.FromBits((int)(x.Bits / (1U << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(U24F8 x) => I30F2.FromBits((int)(x.Bits / (1U << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(U24F8 x) => I29F3.FromBits((int)(x.Bits / (1U << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(U24F8 x) => I28F4.FromBits((int)(x.Bits / (1U << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(U24F8 x) => I27F5.FromBits((int)(x.Bits / (1U << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(U24F8 x) => I26F6.FromBits((int)(x.Bits / (1U << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(U24F8 x) => I25F7.FromBits((int)(x.Bits / (1U << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(U24F8 x) => I24F8.FromBits((int)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(U24F8 x) => I23F9.FromBits((int)x.Bits * (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(U24F8 x) => I22F10.FromBits((int)x.Bits * (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(U24F8 x) => I21F11.FromBits((int)x.Bits * (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(U24F8 x) => I20F12.FromBits((int)x.Bits * (1 << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(U24F8 x) => I19F13.FromBits((int)x.Bits * (1 << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(U24F8 x) => I18F14.FromBits((int)x.Bits * (1 << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(U24F8 x) => I17F15.FromBits((int)x.Bits * (1 << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(U24F8 x) => I16F16.FromBits((int)x.Bits * (1 << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(U24F8 x) => I15F17.FromBits((int)x.Bits * (1 << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(U24F8 x) => I14F18.FromBits((int)x.Bits * (1 << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(U24F8 x) => I13F19.FromBits((int)x.Bits * (1 << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(U24F8 x) => I12F20.FromBits((int)x.Bits * (1 << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(U24F8 x) => I11F21.FromBits((int)x.Bits * (1 << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(U24F8 x) => I10F22.FromBits((int)x.Bits * (1 << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(U24F8 x) => I9F23.FromBits((int)x.Bits * (1 << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(U24F8 x) => I8F24.FromBits((int)x.Bits * (1 << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(U24F8 x) => I7F25.FromBits((int)x.Bits * (1 << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(U24F8 x) => I6F26.FromBits((int)x.Bits * (1 << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(U24F8 x) => I5F27.FromBits((int)x.Bits * (1 << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(U24F8 x) => I4F28.FromBits((int)x.Bits * (1 << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(U24F8 x) => I3F29.FromBits((int)x.Bits * (1 << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(U24F8 x) => I2F30.FromBits((int)x.Bits * (1 << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(U24F8 x) => U31F1.FromBits(x.Bits / (1U << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(U24F8 x) => U30F2.FromBits(x.Bits / (1U << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(U24F8 x) => U29F3.FromBits(x.Bits / (1U << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(U24F8 x) => U28F4.FromBits(x.Bits / (1U << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(U24F8 x) => U27F5.FromBits(x.Bits / (1U << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(U24F8 x) => U26F6.FromBits(x.Bits / (1U << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(U24F8 x) => U25F7.FromBits(x.Bits / (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(U24F8 x) => U23F9.FromBits(x.Bits * (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(U24F8 x) => U22F10.FromBits(x.Bits * (1U << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(U24F8 x) => U21F11.FromBits(x.Bits * (1U << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(U24F8 x) => U20F12.FromBits(x.Bits * (1U << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(U24F8 x) => U19F13.FromBits(x.Bits * (1U << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(U24F8 x) => U18F14.FromBits(x.Bits * (1U << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(U24F8 x) => U17F15.FromBits(x.Bits * (1U << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(U24F8 x) => U16F16.FromBits(x.Bits * (1U << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(U24F8 x) => U15F17.FromBits(x.Bits * (1U << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(U24F8 x) => U14F18.FromBits(x.Bits * (1U << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(U24F8 x) => U13F19.FromBits(x.Bits * (1U << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(U24F8 x) => U12F20.FromBits(x.Bits * (1U << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(U24F8 x) => U11F21.FromBits(x.Bits * (1U << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(U24F8 x) => U10F22.FromBits(x.Bits * (1U << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(U24F8 x) => U9F23.FromBits(x.Bits * (1U << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(U24F8 x) => U8F24.FromBits(x.Bits * (1U << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(U24F8 x) => U7F25.FromBits(x.Bits * (1U << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(U24F8 x) => U6F26.FromBits(x.Bits * (1U << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(U24F8 x) => U5F27.FromBits(x.Bits * (1U << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(U24F8 x) => U4F28.FromBits(x.Bits * (1U << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(U24F8 x) => U3F29.FromBits(x.Bits * (1U << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(U24F8 x) => U2F30.FromBits(x.Bits * (1U << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I63F1(U24F8 x) => I63F1.FromBits(x.Bits / (1U << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I62F2(U24F8 x) => I62F2.FromBits(x.Bits / (1U << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I61F3(U24F8 x) => I61F3.FromBits(x.Bits / (1U << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I60F4(U24F8 x) => I60F4.FromBits(x.Bits / (1U << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I59F5(U24F8 x) => I59F5.FromBits(x.Bits / (1U << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I58F6(U24F8 x) => I58F6.FromBits(x.Bits / (1U << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I57F7(U24F8 x) => I57F7.FromBits(x.Bits / (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I56F8(U24F8 x) => I56F8.FromBits(x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I55F9(U24F8 x) => I55F9.FromBits(x.Bits * (1L << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I54F10(U24F8 x) => I54F10.FromBits(x.Bits * (1L << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I53F11(U24F8 x) => I53F11.FromBits(x.Bits * (1L << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I52F12(U24F8 x) => I52F12.FromBits(x.Bits * (1L << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I51F13(U24F8 x) => I51F13.FromBits(x.Bits * (1L << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I50F14(U24F8 x) => I50F14.FromBits(x.Bits * (1L << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I49F15(U24F8 x) => I49F15.FromBits(x.Bits * (1L << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I48F16(U24F8 x) => I48F16.FromBits(x.Bits * (1L << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I47F17(U24F8 x) => I47F17.FromBits(x.Bits * (1L << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I46F18(U24F8 x) => I46F18.FromBits(x.Bits * (1L << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I45F19(U24F8 x) => I45F19.FromBits(x.Bits * (1L << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I44F20(U24F8 x) => I44F20.FromBits(x.Bits * (1L << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I43F21(U24F8 x) => I43F21.FromBits(x.Bits * (1L << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I42F22(U24F8 x) => I42F22.FromBits(x.Bits * (1L << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I41F23(U24F8 x) => I41F23.FromBits(x.Bits * (1L << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I40F24(U24F8 x) => I40F24.FromBits(x.Bits * (1L << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I39F25(U24F8 x) => I39F25.FromBits(x.Bits * (1L << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I38F26(U24F8 x) => I38F26.FromBits(x.Bits * (1L << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I37F27(U24F8 x) => I37F27.FromBits(x.Bits * (1L << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I36F28(U24F8 x) => I36F28.FromBits(x.Bits * (1L << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I35F29(U24F8 x) => I35F29.FromBits(x.Bits * (1L << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I34F30(U24F8 x) => I34F30.FromBits(x.Bits * (1L << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I33F31(U24F8 x) => I33F31.FromBits(x.Bits * (1L << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I32F32(U24F8 x) => I32F32.FromBits(x.Bits * (1L << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I31F33(U24F8 x) => I31F33.FromBits(x.Bits * (1L << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I30F34(U24F8 x) => I30F34.FromBits(x.Bits * (1L << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I29F35(U24F8 x) => I29F35.FromBits(x.Bits * (1L << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I28F36(U24F8 x) => I28F36.FromBits(x.Bits * (1L << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I27F37(U24F8 x) => I27F37.FromBits(x.Bits * (1L << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I26F38(U24F8 x) => I26F38.FromBits(x.Bits * (1L << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I25F39(U24F8 x) => I25F39.FromBits(x.Bits * (1L << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F40(U24F8 x) => I24F40.FromBits(x.Bits * (1L << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F41(U24F8 x) => I23F41.FromBits(x.Bits * (1L << 33));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F42(U24F8 x) => I22F42.FromBits(x.Bits * (1L << 34));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F43(U24F8 x) => I21F43.FromBits(x.Bits * (1L << 35));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F44(U24F8 x) => I20F44.FromBits(x.Bits * (1L << 36));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F45(U24F8 x) => I19F45.FromBits(x.Bits * (1L << 37));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F46(U24F8 x) => I18F46.FromBits(x.Bits * (1L << 38));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F47(U24F8 x) => I17F47.FromBits(x.Bits * (1L << 39));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F48(U24F8 x) => I16F48.FromBits(x.Bits * (1L << 40));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F49(U24F8 x) => I15F49.FromBits(x.Bits * (1L << 41));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F50(U24F8 x) => I14F50.FromBits(x.Bits * (1L << 42));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F51(U24F8 x) => I13F51.FromBits(x.Bits * (1L << 43));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F52(U24F8 x) => I12F52.FromBits(x.Bits * (1L << 44));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F53(U24F8 x) => I11F53.FromBits(x.Bits * (1L << 45));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F54(U24F8 x) => I10F54.FromBits(x.Bits * (1L << 46));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F55(U24F8 x) => I9F55.FromBits(x.Bits * (1L << 47));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F56(U24F8 x) => I8F56.FromBits(x.Bits * (1L << 48));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F57(U24F8 x) => I7F57.FromBits(x.Bits * (1L << 49));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F58(U24F8 x) => I6F58.FromBits(x.Bits * (1L << 50));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F59(U24F8 x) => I5F59.FromBits(x.Bits * (1L << 51));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F60(U24F8 x) => I4F60.FromBits(x.Bits * (1L << 52));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F61(U24F8 x) => I3F61.FromBits(x.Bits * (1L << 53));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F62(U24F8 x) => I2F62.FromBits(x.Bits * (1L << 54));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U63F1(U24F8 x) => U63F1.FromBits(x.Bits / (1U << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U62F2(U24F8 x) => U62F2.FromBits(x.Bits / (1U << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U61F3(U24F8 x) => U61F3.FromBits(x.Bits / (1U << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U60F4(U24F8 x) => U60F4.FromBits(x.Bits / (1U << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U59F5(U24F8 x) => U59F5.FromBits(x.Bits / (1U << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U58F6(U24F8 x) => U58F6.FromBits(x.Bits / (1U << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U57F7(U24F8 x) => U57F7.FromBits(x.Bits / (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U56F8(U24F8 x) => U56F8.FromBits(x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U55F9(U24F8 x) => U55F9.FromBits(x.Bits * (1UL << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U54F10(U24F8 x) => U54F10.FromBits(x.Bits * (1UL << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U53F11(U24F8 x) => U53F11.FromBits(x.Bits * (1UL << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U52F12(U24F8 x) => U52F12.FromBits(x.Bits * (1UL << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U51F13(U24F8 x) => U51F13.FromBits(x.Bits * (1UL << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U50F14(U24F8 x) => U50F14.FromBits(x.Bits * (1UL << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U49F15(U24F8 x) => U49F15.FromBits(x.Bits * (1UL << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U48F16(U24F8 x) => U48F16.FromBits(x.Bits * (1UL << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U47F17(U24F8 x) => U47F17.FromBits(x.Bits * (1UL << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U46F18(U24F8 x) => U46F18.FromBits(x.Bits * (1UL << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U45F19(U24F8 x) => U45F19.FromBits(x.Bits * (1UL << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U44F20(U24F8 x) => U44F20.FromBits(x.Bits * (1UL << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U43F21(U24F8 x) => U43F21.FromBits(x.Bits * (1UL << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U42F22(U24F8 x) => U42F22.FromBits(x.Bits * (1UL << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U41F23(U24F8 x) => U41F23.FromBits(x.Bits * (1UL << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U40F24(U24F8 x) => U40F24.FromBits(x.Bits * (1UL << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U39F25(U24F8 x) => U39F25.FromBits(x.Bits * (1UL << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U38F26(U24F8 x) => U38F26.FromBits(x.Bits * (1UL << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U37F27(U24F8 x) => U37F27.FromBits(x.Bits * (1UL << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U36F28(U24F8 x) => U36F28.FromBits(x.Bits * (1UL << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U35F29(U24F8 x) => U35F29.FromBits(x.Bits * (1UL << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U34F30(U24F8 x) => U34F30.FromBits(x.Bits * (1UL << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U33F31(U24F8 x) => U33F31.FromBits(x.Bits * (1UL << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U32F32(U24F8 x) => U32F32.FromBits(x.Bits * (1UL << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U31F33(U24F8 x) => U31F33.FromBits(x.Bits * (1UL << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U30F34(U24F8 x) => U30F34.FromBits(x.Bits * (1UL << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U29F35(U24F8 x) => U29F35.FromBits(x.Bits * (1UL << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U28F36(U24F8 x) => U28F36.FromBits(x.Bits * (1UL << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U27F37(U24F8 x) => U27F37.FromBits(x.Bits * (1UL << 29));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U26F38(U24F8 x) => U26F38.FromBits(x.Bits * (1UL << 30));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U25F39(U24F8 x) => U25F39.FromBits(x.Bits * (1UL << 31));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U24F40(U24F8 x) => U24F40.FromBits(x.Bits * (1UL << 32));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F41(U24F8 x) => U23F41.FromBits(x.Bits * (1UL << 33));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F42(U24F8 x) => U22F42.FromBits(x.Bits * (1UL << 34));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F43(U24F8 x) => U21F43.FromBits(x.Bits * (1UL << 35));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F44(U24F8 x) => U20F44.FromBits(x.Bits * (1UL << 36));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F45(U24F8 x) => U19F45.FromBits(x.Bits * (1UL << 37));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F46(U24F8 x) => U18F46.FromBits(x.Bits * (1UL << 38));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F47(U24F8 x) => U17F47.FromBits(x.Bits * (1UL << 39));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F48(U24F8 x) => U16F48.FromBits(x.Bits * (1UL << 40));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F49(U24F8 x) => U15F49.FromBits(x.Bits * (1UL << 41));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F50(U24F8 x) => U14F50.FromBits(x.Bits * (1UL << 42));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F51(U24F8 x) => U13F51.FromBits(x.Bits * (1UL << 43));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F52(U24F8 x) => U12F52.FromBits(x.Bits * (1UL << 44));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F53(U24F8 x) => U11F53.FromBits(x.Bits * (1UL << 45));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F54(U24F8 x) => U10F54.FromBits(x.Bits * (1UL << 46));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F55(U24F8 x) => U9F55.FromBits(x.Bits * (1UL << 47));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F56(U24F8 x) => U8F56.FromBits(x.Bits * (1UL << 48));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F57(U24F8 x) => U7F57.FromBits(x.Bits * (1UL << 49));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F58(U24F8 x) => U6F58.FromBits(x.Bits * (1UL << 50));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F59(U24F8 x) => U5F59.FromBits(x.Bits * (1UL << 51));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F60(U24F8 x) => U4F60.FromBits(x.Bits * (1UL << 52));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F61(U24F8 x) => U3F61.FromBits(x.Bits * (1UL << 53));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F62(U24F8 x) => U2F62.FromBits(x.Bits * (1UL << 54));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is U24F8 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<U24F8>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(U24F8 other) => bits == other.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
