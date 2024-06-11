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

    public struct U5F27 : IEquatable<U5F27>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 5;
        public const int FracNbits = 27;

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

        public static readonly U5F27 Zero = FromNum(0);
        public static readonly U5F27 One = FromNum(1);
        public static readonly U5F27 MinValue = FromNum(uint.MinValue);
        public static readonly U5F27 MaxValue = FromNum(uint.MaxValue);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        U5F27(uint bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27 FromBits(uint bits) => new U5F27(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27 FromNum(uint num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27 operator +(U5F27 left, U5F27 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27 operator -(U5F27 left, U5F27 right) {
            return FromBits(left.Bits - right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27 operator *(U5F27 left, U5F27 right) {
            ulong l = left.Bits;
            return FromBits((uint)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27 operator /(U5F27 left, U5F27 right) {
            ulong l = left.Bits;
            return FromBits((uint)(l * oneRepr / right.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27 operator +(U5F27 x) => FromBits(+x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U5F27 lhs, U5F27 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U5F27 lhs, U5F27 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U5F27 left, U5F27 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U5F27 left, U5F27 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U5F27 left, U5F27 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U5F27 left, U5F27 right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U5F27 Min(U5F27 other) => FromBits(System.Math.Min(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U5F27 Max(U5F27 other) => FromBits(System.Math.Max(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U5F27 Clamp(U5F27 min, U5F27 max) => FromBits(Math.Clamp(bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U4F28 LosslessMul(U31F1 other) => U4F28.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U3F29 LosslessMul(U30F2 other) => U3F29.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F30 LosslessMul(U29F3 other) => U2F30.FromBits(bits * other.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U37F27 WideningMul(uint other) => U37F27.FromBits((ulong)bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U36F28 WideningMul(U31F1 other) => U36F28.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U35F29 WideningMul(U30F2 other) => U35F29.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 WideningMul(U29F3 other) => U34F30.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U33F31 WideningMul(U28F4 other) => U33F31.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U32F32 WideningMul(U27F5 other) => U32F32.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U31F33 WideningMul(U26F6 other) => U31F33.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U30F34 WideningMul(U25F7 other) => U30F34.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U29F35 WideningMul(U24F8 other) => U29F35.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U28F36 WideningMul(U23F9 other) => U28F36.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U27F37 WideningMul(U22F10 other) => U27F37.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U26F38 WideningMul(U21F11 other) => U26F38.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U25F39 WideningMul(U20F12 other) => U25F39.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U24F40 WideningMul(U19F13 other) => U24F40.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U23F41 WideningMul(U18F14 other) => U23F41.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U22F42 WideningMul(U17F15 other) => U22F42.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U21F43 WideningMul(U16F16 other) => U21F43.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U20F44 WideningMul(U15F17 other) => U20F44.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U19F45 WideningMul(U14F18 other) => U19F45.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U18F46 WideningMul(U13F19 other) => U18F46.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U17F47 WideningMul(U12F20 other) => U17F47.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U16F48 WideningMul(U11F21 other) => U16F48.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U15F49 WideningMul(U10F22 other) => U15F49.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U14F50 WideningMul(U9F23 other) => U14F50.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U13F51 WideningMul(U8F24 other) => U13F51.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U12F52 WideningMul(U7F25 other) => U12F52.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U11F53 WideningMul(U6F26 other) => U11F53.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U10F54 WideningMul(U5F27 other) => U10F54.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U9F55 WideningMul(U4F28 other) => U9F55.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U8F56 WideningMul(U3F29 other) => U8F56.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U7F57 WideningMul(U2F30 other) => U7F57.FromBits((ulong)bits * other.Bits);

        // Implicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U37F27(U5F27 x) => U37F27.FromBits(x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U36F28(U5F27 x) => U36F28.FromBits((ulong)x.Bits << 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U35F29(U5F27 x) => U35F29.FromBits((ulong)x.Bits << 2);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U34F30(U5F27 x) => U34F30.FromBits((ulong)x.Bits << 3);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U33F31(U5F27 x) => U33F31.FromBits((ulong)x.Bits << 4);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U32F32(U5F27 x) => U32F32.FromBits((ulong)x.Bits << 5);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U31F33(U5F27 x) => U31F33.FromBits((ulong)x.Bits << 6);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U30F34(U5F27 x) => U30F34.FromBits((ulong)x.Bits << 7);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U29F35(U5F27 x) => U29F35.FromBits((ulong)x.Bits << 8);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U28F36(U5F27 x) => U28F36.FromBits((ulong)x.Bits << 9);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U27F37(U5F27 x) => U27F37.FromBits((ulong)x.Bits << 10);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U26F38(U5F27 x) => U26F38.FromBits((ulong)x.Bits << 11);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U25F39(U5F27 x) => U25F39.FromBits((ulong)x.Bits << 12);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U24F40(U5F27 x) => U24F40.FromBits((ulong)x.Bits << 13);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U23F41(U5F27 x) => U23F41.FromBits((ulong)x.Bits << 14);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U22F42(U5F27 x) => U22F42.FromBits((ulong)x.Bits << 15);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U21F43(U5F27 x) => U21F43.FromBits((ulong)x.Bits << 16);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U20F44(U5F27 x) => U20F44.FromBits((ulong)x.Bits << 17);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U19F45(U5F27 x) => U19F45.FromBits((ulong)x.Bits << 18);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U18F46(U5F27 x) => U18F46.FromBits((ulong)x.Bits << 19);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U17F47(U5F27 x) => U17F47.FromBits((ulong)x.Bits << 20);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U16F48(U5F27 x) => U16F48.FromBits((ulong)x.Bits << 21);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U15F49(U5F27 x) => U15F49.FromBits((ulong)x.Bits << 22);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U14F50(U5F27 x) => U14F50.FromBits((ulong)x.Bits << 23);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U13F51(U5F27 x) => U13F51.FromBits((ulong)x.Bits << 24);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U12F52(U5F27 x) => U12F52.FromBits((ulong)x.Bits << 25);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U11F53(U5F27 x) => U11F53.FromBits((ulong)x.Bits << 26);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U10F54(U5F27 x) => U10F54.FromBits((ulong)x.Bits << 27);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U9F55(U5F27 x) => U9F55.FromBits((ulong)x.Bits << 28);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U8F56(U5F27 x) => U8F56.FromBits((ulong)x.Bits << 29);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U7F57(U5F27 x) => U7F57.FromBits((ulong)x.Bits << 30);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U6F58(U5F27 x) => U6F58.FromBits((ulong)x.Bits << 31);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U5F59(U5F27 x) => U5F59.FromBits((ulong)x.Bits << 32);

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(U5F27 x) => (int)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(U5F27 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(U5F27 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(U5F27 x) => x.bits / oneRepr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(U5F27 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(U5F27 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(U5F27 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(U5F27 x) => I31F1.FromBits((int)(x.Bits / (1U << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(U5F27 x) => I30F2.FromBits((int)(x.Bits / (1U << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(U5F27 x) => I29F3.FromBits((int)(x.Bits / (1U << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(U5F27 x) => I28F4.FromBits((int)(x.Bits / (1U << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(U5F27 x) => I27F5.FromBits((int)(x.Bits / (1U << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(U5F27 x) => I26F6.FromBits((int)(x.Bits / (1U << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(U5F27 x) => I25F7.FromBits((int)(x.Bits / (1U << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(U5F27 x) => I24F8.FromBits((int)(x.Bits / (1U << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(U5F27 x) => I23F9.FromBits((int)(x.Bits / (1U << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(U5F27 x) => I22F10.FromBits((int)(x.Bits / (1U << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(U5F27 x) => I21F11.FromBits((int)(x.Bits / (1U << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(U5F27 x) => I20F12.FromBits((int)(x.Bits / (1U << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(U5F27 x) => I19F13.FromBits((int)(x.Bits / (1U << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(U5F27 x) => I18F14.FromBits((int)(x.Bits / (1U << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(U5F27 x) => I17F15.FromBits((int)(x.Bits / (1U << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(U5F27 x) => I16F16.FromBits((int)(x.Bits / (1U << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(U5F27 x) => I15F17.FromBits((int)(x.Bits / (1U << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(U5F27 x) => I14F18.FromBits((int)(x.Bits / (1U << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(U5F27 x) => I13F19.FromBits((int)(x.Bits / (1U << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(U5F27 x) => I12F20.FromBits((int)(x.Bits / (1U << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(U5F27 x) => I11F21.FromBits((int)(x.Bits / (1U << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(U5F27 x) => I10F22.FromBits((int)(x.Bits / (1U << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(U5F27 x) => I9F23.FromBits((int)(x.Bits / (1U << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(U5F27 x) => I8F24.FromBits((int)(x.Bits / (1U << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(U5F27 x) => I7F25.FromBits((int)(x.Bits / (1U << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(U5F27 x) => I6F26.FromBits((int)(x.Bits / (1U << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(U5F27 x) => I4F28.FromBits((int)x.Bits * (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(U5F27 x) => I3F29.FromBits((int)x.Bits * (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(U5F27 x) => I2F30.FromBits((int)x.Bits * (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(U5F27 x) => U31F1.FromBits(x.Bits / (1U << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(U5F27 x) => U30F2.FromBits(x.Bits / (1U << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(U5F27 x) => U29F3.FromBits(x.Bits / (1U << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(U5F27 x) => U28F4.FromBits(x.Bits / (1U << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(U5F27 x) => U27F5.FromBits(x.Bits / (1U << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(U5F27 x) => U26F6.FromBits(x.Bits / (1U << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(U5F27 x) => U25F7.FromBits(x.Bits / (1U << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(U5F27 x) => U24F8.FromBits(x.Bits / (1U << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(U5F27 x) => U23F9.FromBits(x.Bits / (1U << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(U5F27 x) => U22F10.FromBits(x.Bits / (1U << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(U5F27 x) => U21F11.FromBits(x.Bits / (1U << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(U5F27 x) => U20F12.FromBits(x.Bits / (1U << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(U5F27 x) => U19F13.FromBits(x.Bits / (1U << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(U5F27 x) => U18F14.FromBits(x.Bits / (1U << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(U5F27 x) => U17F15.FromBits(x.Bits / (1U << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(U5F27 x) => U16F16.FromBits(x.Bits / (1U << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(U5F27 x) => U15F17.FromBits(x.Bits / (1U << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(U5F27 x) => U14F18.FromBits(x.Bits / (1U << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(U5F27 x) => U13F19.FromBits(x.Bits / (1U << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(U5F27 x) => U12F20.FromBits(x.Bits / (1U << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(U5F27 x) => U11F21.FromBits(x.Bits / (1U << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(U5F27 x) => U10F22.FromBits(x.Bits / (1U << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(U5F27 x) => U9F23.FromBits(x.Bits / (1U << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(U5F27 x) => U8F24.FromBits(x.Bits / (1U << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(U5F27 x) => U7F25.FromBits(x.Bits / (1U << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(U5F27 x) => U6F26.FromBits(x.Bits / (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(U5F27 x) => U4F28.FromBits(x.Bits * (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(U5F27 x) => U3F29.FromBits(x.Bits * (1U << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(U5F27 x) => U2F30.FromBits(x.Bits * (1U << 3));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is U5F27 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<U5F27>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(U5F27 rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
