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

    public struct I6F26 : IEquatable<I6F26>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 6;
        public const int FracNbits = 26;

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

        public static readonly I6F26 Zero = FromNum(0);
        public static readonly I6F26 One = FromNum(1);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I6F26(int bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I6F26 FromBits(int bits) => new I6F26(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I6F26 FromNum(int num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I6F26 operator +(I6F26 left, I6F26 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I6F26 operator -(I6F26 left, I6F26 right) {
            return FromBits(left.Bits - right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I6F26 operator *(I6F26 left, I6F26 right) {
            long l = left.Bits;
            return FromBits((int)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I6F26 operator /(I6F26 left, I6F26 right) {
            long l = left.Bits;
            return FromBits((int)(l * oneRepr / right.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I6F26 operator -(I6F26 x) => FromBits(-x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I6F26 lhs, I6F26 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I6F26 lhs, I6F26 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I6F26 left, I6F26 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I6F26 left, I6F26 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I6F26 left, I6F26 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I6F26 left, I6F26 right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I6F26 Min(I6F26 other) => FromBits(System.Math.Min(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I6F26 Max(I6F26 other) => FromBits(System.Math.Max(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I6F26 Clamp(I6F26 min, I6F26 max) => FromBits(Math.Clamp(bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I5F27 LosslessMul(I31F1 other) => I5F27.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I4F28 LosslessMul(I30F2 other) => I4F28.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I3F29 LosslessMul(I29F3 other) => I3F29.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 LosslessMul(I28F4 other) => I2F30.FromBits(bits * other.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I38F26 WideningMul(int other) => I38F26.FromBits((long)bits * other);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I37F27 WideningMul(I31F1 other) => I37F27.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I36F28 WideningMul(I30F2 other) => I36F28.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I35F29 WideningMul(I29F3 other) => I35F29.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 WideningMul(I28F4 other) => I34F30.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I33F31 WideningMul(I27F5 other) => I33F31.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I32F32 WideningMul(I26F6 other) => I32F32.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I31F33 WideningMul(I25F7 other) => I31F33.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I30F34 WideningMul(I24F8 other) => I30F34.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I29F35 WideningMul(I23F9 other) => I29F35.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I28F36 WideningMul(I22F10 other) => I28F36.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I27F37 WideningMul(I21F11 other) => I27F37.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I26F38 WideningMul(I20F12 other) => I26F38.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I25F39 WideningMul(I19F13 other) => I25F39.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I24F40 WideningMul(I18F14 other) => I24F40.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I23F41 WideningMul(I17F15 other) => I23F41.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I22F42 WideningMul(I16F16 other) => I22F42.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I21F43 WideningMul(I15F17 other) => I21F43.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I20F44 WideningMul(I14F18 other) => I20F44.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I19F45 WideningMul(I13F19 other) => I19F45.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F46 WideningMul(I12F20 other) => I18F46.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F47 WideningMul(I11F21 other) => I17F47.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I16F48 WideningMul(I10F22 other) => I16F48.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I15F49 WideningMul(I9F23 other) => I15F49.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I14F50 WideningMul(I8F24 other) => I14F50.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I13F51 WideningMul(I7F25 other) => I13F51.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I12F52 WideningMul(I6F26 other) => I12F52.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I11F53 WideningMul(I5F27 other) => I11F53.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I10F54 WideningMul(I4F28 other) => I10F54.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I9F55 WideningMul(I3F29 other) => I9F55.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I8F56 WideningMul(I2F30 other) => I8F56.FromBits((long)bits * other.Bits);

        // Implicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I38F26(I6F26 x) => I38F26.FromBits(x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I37F27(I6F26 x) => I37F27.FromBits((long)x.Bits << 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I36F28(I6F26 x) => I36F28.FromBits((long)x.Bits << 2);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I35F29(I6F26 x) => I35F29.FromBits((long)x.Bits << 3);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I34F30(I6F26 x) => I34F30.FromBits((long)x.Bits << 4);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I33F31(I6F26 x) => I33F31.FromBits((long)x.Bits << 5);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I32F32(I6F26 x) => I32F32.FromBits((long)x.Bits << 6);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I31F33(I6F26 x) => I31F33.FromBits((long)x.Bits << 7);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I30F34(I6F26 x) => I30F34.FromBits((long)x.Bits << 8);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I29F35(I6F26 x) => I29F35.FromBits((long)x.Bits << 9);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I28F36(I6F26 x) => I28F36.FromBits((long)x.Bits << 10);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I27F37(I6F26 x) => I27F37.FromBits((long)x.Bits << 11);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I26F38(I6F26 x) => I26F38.FromBits((long)x.Bits << 12);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I25F39(I6F26 x) => I25F39.FromBits((long)x.Bits << 13);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I24F40(I6F26 x) => I24F40.FromBits((long)x.Bits << 14);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I23F41(I6F26 x) => I23F41.FromBits((long)x.Bits << 15);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I22F42(I6F26 x) => I22F42.FromBits((long)x.Bits << 16);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I21F43(I6F26 x) => I21F43.FromBits((long)x.Bits << 17);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I20F44(I6F26 x) => I20F44.FromBits((long)x.Bits << 18);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I19F45(I6F26 x) => I19F45.FromBits((long)x.Bits << 19);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I18F46(I6F26 x) => I18F46.FromBits((long)x.Bits << 20);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I17F47(I6F26 x) => I17F47.FromBits((long)x.Bits << 21);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I16F48(I6F26 x) => I16F48.FromBits((long)x.Bits << 22);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I15F49(I6F26 x) => I15F49.FromBits((long)x.Bits << 23);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I14F50(I6F26 x) => I14F50.FromBits((long)x.Bits << 24);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I13F51(I6F26 x) => I13F51.FromBits((long)x.Bits << 25);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I12F52(I6F26 x) => I12F52.FromBits((long)x.Bits << 26);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I11F53(I6F26 x) => I11F53.FromBits((long)x.Bits << 27);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I10F54(I6F26 x) => I10F54.FromBits((long)x.Bits << 28);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I9F55(I6F26 x) => I9F55.FromBits((long)x.Bits << 29);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I8F56(I6F26 x) => I8F56.FromBits((long)x.Bits << 30);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I7F57(I6F26 x) => I7F57.FromBits((long)x.Bits << 31);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I6F58(I6F26 x) => I6F58.FromBits((long)x.Bits << 32);

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(I6F26 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(I6F26 x) => (uint)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(I6F26 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(I6F26 x) => (ulong)(x.bits / oneRepr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I6F26 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I6F26 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I6F26 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(I6F26 x) => I31F1.FromBits(x.Bits / (1 << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(I6F26 x) => I30F2.FromBits(x.Bits / (1 << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(I6F26 x) => I29F3.FromBits(x.Bits / (1 << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(I6F26 x) => I28F4.FromBits(x.Bits / (1 << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(I6F26 x) => I27F5.FromBits(x.Bits / (1 << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(I6F26 x) => I26F6.FromBits(x.Bits / (1 << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(I6F26 x) => I25F7.FromBits(x.Bits / (1 << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(I6F26 x) => I24F8.FromBits(x.Bits / (1 << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(I6F26 x) => I23F9.FromBits(x.Bits / (1 << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(I6F26 x) => I22F10.FromBits(x.Bits / (1 << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(I6F26 x) => I21F11.FromBits(x.Bits / (1 << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(I6F26 x) => I20F12.FromBits(x.Bits / (1 << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(I6F26 x) => I19F13.FromBits(x.Bits / (1 << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(I6F26 x) => I18F14.FromBits(x.Bits / (1 << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(I6F26 x) => I17F15.FromBits(x.Bits / (1 << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(I6F26 x) => I16F16.FromBits(x.Bits / (1 << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(I6F26 x) => I15F17.FromBits(x.Bits / (1 << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(I6F26 x) => I14F18.FromBits(x.Bits / (1 << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(I6F26 x) => I13F19.FromBits(x.Bits / (1 << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(I6F26 x) => I12F20.FromBits(x.Bits / (1 << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(I6F26 x) => I11F21.FromBits(x.Bits / (1 << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(I6F26 x) => I10F22.FromBits(x.Bits / (1 << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(I6F26 x) => I9F23.FromBits(x.Bits / (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(I6F26 x) => I8F24.FromBits(x.Bits / (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(I6F26 x) => I7F25.FromBits(x.Bits / (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(I6F26 x) => I5F27.FromBits(x.Bits * (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(I6F26 x) => I4F28.FromBits(x.Bits * (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(I6F26 x) => I3F29.FromBits(x.Bits * (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(I6F26 x) => I2F30.FromBits(x.Bits * (1 << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(I6F26 x) => U31F1.FromBits((uint)(x.Bits / (1 << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(I6F26 x) => U30F2.FromBits((uint)(x.Bits / (1 << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(I6F26 x) => U29F3.FromBits((uint)(x.Bits / (1 << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(I6F26 x) => U28F4.FromBits((uint)(x.Bits / (1 << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(I6F26 x) => U27F5.FromBits((uint)(x.Bits / (1 << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(I6F26 x) => U26F6.FromBits((uint)(x.Bits / (1 << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(I6F26 x) => U25F7.FromBits((uint)(x.Bits / (1 << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(I6F26 x) => U24F8.FromBits((uint)(x.Bits / (1 << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(I6F26 x) => U23F9.FromBits((uint)(x.Bits / (1 << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(I6F26 x) => U22F10.FromBits((uint)(x.Bits / (1 << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(I6F26 x) => U21F11.FromBits((uint)(x.Bits / (1 << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(I6F26 x) => U20F12.FromBits((uint)(x.Bits / (1 << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(I6F26 x) => U19F13.FromBits((uint)(x.Bits / (1 << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(I6F26 x) => U18F14.FromBits((uint)(x.Bits / (1 << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(I6F26 x) => U17F15.FromBits((uint)(x.Bits / (1 << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(I6F26 x) => U16F16.FromBits((uint)(x.Bits / (1 << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(I6F26 x) => U15F17.FromBits((uint)(x.Bits / (1 << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(I6F26 x) => U14F18.FromBits((uint)(x.Bits / (1 << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(I6F26 x) => U13F19.FromBits((uint)(x.Bits / (1 << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(I6F26 x) => U12F20.FromBits((uint)(x.Bits / (1 << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(I6F26 x) => U11F21.FromBits((uint)(x.Bits / (1 << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(I6F26 x) => U10F22.FromBits((uint)(x.Bits / (1 << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(I6F26 x) => U9F23.FromBits((uint)(x.Bits / (1 << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(I6F26 x) => U8F24.FromBits((uint)(x.Bits / (1 << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(I6F26 x) => U7F25.FromBits((uint)(x.Bits / (1 << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(I6F26 x) => U5F27.FromBits((uint)x.Bits * (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(I6F26 x) => U4F28.FromBits((uint)x.Bits * (1U << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(I6F26 x) => U3F29.FromBits((uint)x.Bits * (1U << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(I6F26 x) => U2F30.FromBits((uint)x.Bits * (1U << 4));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is I6F26 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<I6F26>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(I6F26 rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
