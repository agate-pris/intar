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

    public struct I4F28 : IEquatable<I4F28>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 4;
        public const int FracNbits = 28;

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

        public static readonly I4F28 Zero = FromNum(0);
        public static readonly I4F28 One = FromNum(1);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I4F28(int bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F28 FromBits(int bits) => new I4F28(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F28 FromNum(int num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F28 operator +(I4F28 left, I4F28 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F28 operator -(I4F28 left, I4F28 right) {
            return FromBits(left.Bits - right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F28 operator *(I4F28 left, I4F28 right) {
            long l = left.Bits;
            return FromBits((int)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I4F28 operator /(I4F28 left, I4F28 right) {
            long l = left.Bits;
            return FromBits((int)(l * oneRepr / right.Bits));
        }

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I4F28 lhs, I4F28 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I4F28 lhs, I4F28 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I4F28 left, I4F28 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I4F28 left, I4F28 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I4F28 left, I4F28 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I4F28 left, I4F28 right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I3F29 LosslessMul(I31F1 other) => I3F29.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 LosslessMul(I30F2 other) => I2F30.FromBits(bits * other.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I36F28 WideningMul(int other) => I36F28.FromBits((long)bits * other);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I35F29 WideningMul(I31F1 other) => I35F29.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 WideningMul(I30F2 other) => I34F30.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I33F31 WideningMul(I29F3 other) => I33F31.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I32F32 WideningMul(I28F4 other) => I32F32.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I31F33 WideningMul(I27F5 other) => I31F33.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I30F34 WideningMul(I26F6 other) => I30F34.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I29F35 WideningMul(I25F7 other) => I29F35.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I28F36 WideningMul(I24F8 other) => I28F36.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I27F37 WideningMul(I23F9 other) => I27F37.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I26F38 WideningMul(I22F10 other) => I26F38.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I25F39 WideningMul(I21F11 other) => I25F39.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I24F40 WideningMul(I20F12 other) => I24F40.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I23F41 WideningMul(I19F13 other) => I23F41.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I22F42 WideningMul(I18F14 other) => I22F42.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I21F43 WideningMul(I17F15 other) => I21F43.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I20F44 WideningMul(I16F16 other) => I20F44.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I19F45 WideningMul(I15F17 other) => I19F45.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F46 WideningMul(I14F18 other) => I18F46.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F47 WideningMul(I13F19 other) => I17F47.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I16F48 WideningMul(I12F20 other) => I16F48.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I15F49 WideningMul(I11F21 other) => I15F49.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I14F50 WideningMul(I10F22 other) => I14F50.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I13F51 WideningMul(I9F23 other) => I13F51.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I12F52 WideningMul(I8F24 other) => I12F52.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I11F53 WideningMul(I7F25 other) => I11F53.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I10F54 WideningMul(I6F26 other) => I10F54.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I9F55 WideningMul(I5F27 other) => I9F55.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I8F56 WideningMul(I4F28 other) => I8F56.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I7F57 WideningMul(I3F29 other) => I7F57.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I6F58 WideningMul(I2F30 other) => I6F58.FromBits((long)bits * other.Bits);

        // Implicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I36F28(I4F28 x) => I36F28.FromBits(x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I35F29(I4F28 x) => I35F29.FromBits((long)x.Bits << 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I34F30(I4F28 x) => I34F30.FromBits((long)x.Bits << 2);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I33F31(I4F28 x) => I33F31.FromBits((long)x.Bits << 3);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I32F32(I4F28 x) => I32F32.FromBits((long)x.Bits << 4);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I31F33(I4F28 x) => I31F33.FromBits((long)x.Bits << 5);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I30F34(I4F28 x) => I30F34.FromBits((long)x.Bits << 6);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I29F35(I4F28 x) => I29F35.FromBits((long)x.Bits << 7);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I28F36(I4F28 x) => I28F36.FromBits((long)x.Bits << 8);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I27F37(I4F28 x) => I27F37.FromBits((long)x.Bits << 9);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I26F38(I4F28 x) => I26F38.FromBits((long)x.Bits << 10);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I25F39(I4F28 x) => I25F39.FromBits((long)x.Bits << 11);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I24F40(I4F28 x) => I24F40.FromBits((long)x.Bits << 12);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I23F41(I4F28 x) => I23F41.FromBits((long)x.Bits << 13);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I22F42(I4F28 x) => I22F42.FromBits((long)x.Bits << 14);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I21F43(I4F28 x) => I21F43.FromBits((long)x.Bits << 15);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I20F44(I4F28 x) => I20F44.FromBits((long)x.Bits << 16);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I19F45(I4F28 x) => I19F45.FromBits((long)x.Bits << 17);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I18F46(I4F28 x) => I18F46.FromBits((long)x.Bits << 18);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I17F47(I4F28 x) => I17F47.FromBits((long)x.Bits << 19);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I16F48(I4F28 x) => I16F48.FromBits((long)x.Bits << 20);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I15F49(I4F28 x) => I15F49.FromBits((long)x.Bits << 21);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I14F50(I4F28 x) => I14F50.FromBits((long)x.Bits << 22);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I13F51(I4F28 x) => I13F51.FromBits((long)x.Bits << 23);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I12F52(I4F28 x) => I12F52.FromBits((long)x.Bits << 24);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I11F53(I4F28 x) => I11F53.FromBits((long)x.Bits << 25);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I10F54(I4F28 x) => I10F54.FromBits((long)x.Bits << 26);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I9F55(I4F28 x) => I9F55.FromBits((long)x.Bits << 27);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I8F56(I4F28 x) => I8F56.FromBits((long)x.Bits << 28);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I7F57(I4F28 x) => I7F57.FromBits((long)x.Bits << 29);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I6F58(I4F28 x) => I6F58.FromBits((long)x.Bits << 30);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I5F59(I4F28 x) => I5F59.FromBits((long)x.Bits << 31);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I4F60(I4F28 x) => I4F60.FromBits((long)x.Bits << 32);

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(I4F28 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(I4F28 x) => (uint)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(I4F28 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(I4F28 x) => (ulong)(x.bits / oneRepr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I4F28 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I4F28 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I4F28 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(I4F28 x) => I31F1.FromBits(x.Bits / (1 << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(I4F28 x) => I30F2.FromBits(x.Bits / (1 << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(I4F28 x) => I29F3.FromBits(x.Bits / (1 << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(I4F28 x) => I28F4.FromBits(x.Bits / (1 << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(I4F28 x) => I27F5.FromBits(x.Bits / (1 << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(I4F28 x) => I26F6.FromBits(x.Bits / (1 << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(I4F28 x) => I25F7.FromBits(x.Bits / (1 << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(I4F28 x) => I24F8.FromBits(x.Bits / (1 << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(I4F28 x) => I23F9.FromBits(x.Bits / (1 << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(I4F28 x) => I22F10.FromBits(x.Bits / (1 << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(I4F28 x) => I21F11.FromBits(x.Bits / (1 << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(I4F28 x) => I20F12.FromBits(x.Bits / (1 << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(I4F28 x) => I19F13.FromBits(x.Bits / (1 << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(I4F28 x) => I18F14.FromBits(x.Bits / (1 << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(I4F28 x) => I17F15.FromBits(x.Bits / (1 << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(I4F28 x) => I16F16.FromBits(x.Bits / (1 << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(I4F28 x) => I15F17.FromBits(x.Bits / (1 << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(I4F28 x) => I14F18.FromBits(x.Bits / (1 << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(I4F28 x) => I13F19.FromBits(x.Bits / (1 << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(I4F28 x) => I12F20.FromBits(x.Bits / (1 << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(I4F28 x) => I11F21.FromBits(x.Bits / (1 << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(I4F28 x) => I10F22.FromBits(x.Bits / (1 << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(I4F28 x) => I9F23.FromBits(x.Bits / (1 << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(I4F28 x) => I8F24.FromBits(x.Bits / (1 << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(I4F28 x) => I7F25.FromBits(x.Bits / (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(I4F28 x) => I6F26.FromBits(x.Bits / (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(I4F28 x) => I5F27.FromBits(x.Bits / (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(I4F28 x) => I3F29.FromBits(x.Bits * (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(I4F28 x) => I2F30.FromBits(x.Bits * (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(I4F28 x) => U31F1.FromBits((uint)(x.Bits / (1 << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(I4F28 x) => U30F2.FromBits((uint)(x.Bits / (1 << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(I4F28 x) => U29F3.FromBits((uint)(x.Bits / (1 << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(I4F28 x) => U28F4.FromBits((uint)(x.Bits / (1 << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(I4F28 x) => U27F5.FromBits((uint)(x.Bits / (1 << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(I4F28 x) => U26F6.FromBits((uint)(x.Bits / (1 << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(I4F28 x) => U25F7.FromBits((uint)(x.Bits / (1 << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(I4F28 x) => U24F8.FromBits((uint)(x.Bits / (1 << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(I4F28 x) => U23F9.FromBits((uint)(x.Bits / (1 << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(I4F28 x) => U22F10.FromBits((uint)(x.Bits / (1 << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(I4F28 x) => U21F11.FromBits((uint)(x.Bits / (1 << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(I4F28 x) => U20F12.FromBits((uint)(x.Bits / (1 << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(I4F28 x) => U19F13.FromBits((uint)(x.Bits / (1 << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(I4F28 x) => U18F14.FromBits((uint)(x.Bits / (1 << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(I4F28 x) => U17F15.FromBits((uint)(x.Bits / (1 << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(I4F28 x) => U16F16.FromBits((uint)(x.Bits / (1 << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(I4F28 x) => U15F17.FromBits((uint)(x.Bits / (1 << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(I4F28 x) => U14F18.FromBits((uint)(x.Bits / (1 << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(I4F28 x) => U13F19.FromBits((uint)(x.Bits / (1 << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(I4F28 x) => U12F20.FromBits((uint)(x.Bits / (1 << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(I4F28 x) => U11F21.FromBits((uint)(x.Bits / (1 << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(I4F28 x) => U10F22.FromBits((uint)(x.Bits / (1 << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(I4F28 x) => U9F23.FromBits((uint)(x.Bits / (1 << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(I4F28 x) => U8F24.FromBits((uint)(x.Bits / (1 << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(I4F28 x) => U7F25.FromBits((uint)(x.Bits / (1 << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(I4F28 x) => U6F26.FromBits((uint)(x.Bits / (1 << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(I4F28 x) => U5F27.FromBits((uint)(x.Bits / (1 << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(I4F28 x) => U3F29.FromBits((uint)x.Bits * (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(I4F28 x) => U2F30.FromBits((uint)x.Bits * (1U << 2));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is I4F28 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<I4F28>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(I4F28 rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
