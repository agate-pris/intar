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

    public struct I11F21 : IEquatable<I11F21>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 11;
        public const int FracNbits = 21;

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

        public static readonly I11F21 Zero = FromNum(0);
        public static readonly I11F21 One = FromNum(1);
        public static readonly I11F21 MinValue = FromNum(int.MinValue);
        public static readonly I11F21 MaxValue = FromNum(int.MaxValue);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I11F21(int bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I11F21 FromBits(int bits) => new I11F21(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I11F21 FromNum(int num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I11F21 operator +(I11F21 left, I11F21 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I11F21 operator -(I11F21 left, I11F21 right) {
            return FromBits(left.Bits - right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I11F21 operator *(I11F21 left, I11F21 right) {
            long l = left.Bits;
            return FromBits((int)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I11F21 operator /(I11F21 left, I11F21 right) {
            long l = left.Bits;
            return FromBits((int)(l * oneRepr / right.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I11F21 operator +(I11F21 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I11F21 operator -(I11F21 x) => FromBits(-x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I11F21 lhs, I11F21 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I11F21 lhs, I11F21 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I11F21 left, I11F21 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I11F21 left, I11F21 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I11F21 left, I11F21 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I11F21 left, I11F21 right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I11F21 Min(I11F21 other) => FromBits(System.Math.Min(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I11F21 Max(I11F21 other) => FromBits(System.Math.Max(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I11F21 Clamp(I11F21 min, I11F21 max) => FromBits(Math.Clamp(bits, min.Bits, max.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I11F21 Abs() => FromBits(System.Math.Abs(bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I11F21 LosslessMul(int other) => I11F21.FromBits(bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I10F22 LosslessMul(I31F1 other) => I10F22.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I9F23 LosslessMul(I30F2 other) => I9F23.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I8F24 LosslessMul(I29F3 other) => I8F24.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I7F25 LosslessMul(I28F4 other) => I7F25.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I6F26 LosslessMul(I27F5 other) => I6F26.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I5F27 LosslessMul(I26F6 other) => I5F27.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I4F28 LosslessMul(I25F7 other) => I4F28.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I3F29 LosslessMul(I24F8 other) => I3F29.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 LosslessMul(I23F9 other) => I2F30.FromBits(bits * other.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I43F21 WideningMul(int other) => I43F21.FromBits((long)bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I42F22 WideningMul(I31F1 other) => I42F22.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I41F23 WideningMul(I30F2 other) => I41F23.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I40F24 WideningMul(I29F3 other) => I40F24.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I39F25 WideningMul(I28F4 other) => I39F25.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I38F26 WideningMul(I27F5 other) => I38F26.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I37F27 WideningMul(I26F6 other) => I37F27.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I36F28 WideningMul(I25F7 other) => I36F28.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I35F29 WideningMul(I24F8 other) => I35F29.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I34F30 WideningMul(I23F9 other) => I34F30.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I33F31 WideningMul(I22F10 other) => I33F31.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I32F32 WideningMul(I21F11 other) => I32F32.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I31F33 WideningMul(I20F12 other) => I31F33.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I30F34 WideningMul(I19F13 other) => I30F34.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I29F35 WideningMul(I18F14 other) => I29F35.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I28F36 WideningMul(I17F15 other) => I28F36.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I27F37 WideningMul(I16F16 other) => I27F37.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I26F38 WideningMul(I15F17 other) => I26F38.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I25F39 WideningMul(I14F18 other) => I25F39.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I24F40 WideningMul(I13F19 other) => I24F40.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I23F41 WideningMul(I12F20 other) => I23F41.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I22F42 WideningMul(I11F21 other) => I22F42.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I21F43 WideningMul(I10F22 other) => I21F43.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I20F44 WideningMul(I9F23 other) => I20F44.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I19F45 WideningMul(I8F24 other) => I19F45.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F46 WideningMul(I7F25 other) => I18F46.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F47 WideningMul(I6F26 other) => I17F47.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I16F48 WideningMul(I5F27 other) => I16F48.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I15F49 WideningMul(I4F28 other) => I15F49.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I14F50 WideningMul(I3F29 other) => I14F50.FromBits((long)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I13F51 WideningMul(I2F30 other) => I13F51.FromBits((long)bits * other.Bits);

        // Implicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I43F21(I11F21 x) => I43F21.FromBits(x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I42F22(I11F21 x) => I42F22.FromBits((long)x.Bits << 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I41F23(I11F21 x) => I41F23.FromBits((long)x.Bits << 2);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I40F24(I11F21 x) => I40F24.FromBits((long)x.Bits << 3);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I39F25(I11F21 x) => I39F25.FromBits((long)x.Bits << 4);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I38F26(I11F21 x) => I38F26.FromBits((long)x.Bits << 5);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I37F27(I11F21 x) => I37F27.FromBits((long)x.Bits << 6);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I36F28(I11F21 x) => I36F28.FromBits((long)x.Bits << 7);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I35F29(I11F21 x) => I35F29.FromBits((long)x.Bits << 8);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I34F30(I11F21 x) => I34F30.FromBits((long)x.Bits << 9);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I33F31(I11F21 x) => I33F31.FromBits((long)x.Bits << 10);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I32F32(I11F21 x) => I32F32.FromBits((long)x.Bits << 11);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I31F33(I11F21 x) => I31F33.FromBits((long)x.Bits << 12);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I30F34(I11F21 x) => I30F34.FromBits((long)x.Bits << 13);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I29F35(I11F21 x) => I29F35.FromBits((long)x.Bits << 14);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I28F36(I11F21 x) => I28F36.FromBits((long)x.Bits << 15);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I27F37(I11F21 x) => I27F37.FromBits((long)x.Bits << 16);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I26F38(I11F21 x) => I26F38.FromBits((long)x.Bits << 17);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I25F39(I11F21 x) => I25F39.FromBits((long)x.Bits << 18);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I24F40(I11F21 x) => I24F40.FromBits((long)x.Bits << 19);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I23F41(I11F21 x) => I23F41.FromBits((long)x.Bits << 20);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I22F42(I11F21 x) => I22F42.FromBits((long)x.Bits << 21);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I21F43(I11F21 x) => I21F43.FromBits((long)x.Bits << 22);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I20F44(I11F21 x) => I20F44.FromBits((long)x.Bits << 23);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I19F45(I11F21 x) => I19F45.FromBits((long)x.Bits << 24);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I18F46(I11F21 x) => I18F46.FromBits((long)x.Bits << 25);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I17F47(I11F21 x) => I17F47.FromBits((long)x.Bits << 26);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I16F48(I11F21 x) => I16F48.FromBits((long)x.Bits << 27);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I15F49(I11F21 x) => I15F49.FromBits((long)x.Bits << 28);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I14F50(I11F21 x) => I14F50.FromBits((long)x.Bits << 29);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I13F51(I11F21 x) => I13F51.FromBits((long)x.Bits << 30);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I12F52(I11F21 x) => I12F52.FromBits((long)x.Bits << 31);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I11F53(I11F21 x) => I11F53.FromBits((long)x.Bits << 32);

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(I11F21 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(I11F21 x) => (uint)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(I11F21 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(I11F21 x) => (ulong)(x.bits / oneRepr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I11F21 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I11F21 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I11F21 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(I11F21 x) => I31F1.FromBits(x.Bits / (1 << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(I11F21 x) => I30F2.FromBits(x.Bits / (1 << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(I11F21 x) => I29F3.FromBits(x.Bits / (1 << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(I11F21 x) => I28F4.FromBits(x.Bits / (1 << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(I11F21 x) => I27F5.FromBits(x.Bits / (1 << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(I11F21 x) => I26F6.FromBits(x.Bits / (1 << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(I11F21 x) => I25F7.FromBits(x.Bits / (1 << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(I11F21 x) => I24F8.FromBits(x.Bits / (1 << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(I11F21 x) => I23F9.FromBits(x.Bits / (1 << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(I11F21 x) => I22F10.FromBits(x.Bits / (1 << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(I11F21 x) => I21F11.FromBits(x.Bits / (1 << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(I11F21 x) => I20F12.FromBits(x.Bits / (1 << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(I11F21 x) => I19F13.FromBits(x.Bits / (1 << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(I11F21 x) => I18F14.FromBits(x.Bits / (1 << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(I11F21 x) => I17F15.FromBits(x.Bits / (1 << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(I11F21 x) => I16F16.FromBits(x.Bits / (1 << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(I11F21 x) => I15F17.FromBits(x.Bits / (1 << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(I11F21 x) => I14F18.FromBits(x.Bits / (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(I11F21 x) => I13F19.FromBits(x.Bits / (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(I11F21 x) => I12F20.FromBits(x.Bits / (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(I11F21 x) => I10F22.FromBits(x.Bits * (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(I11F21 x) => I9F23.FromBits(x.Bits * (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(I11F21 x) => I8F24.FromBits(x.Bits * (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(I11F21 x) => I7F25.FromBits(x.Bits * (1 << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(I11F21 x) => I6F26.FromBits(x.Bits * (1 << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(I11F21 x) => I5F27.FromBits(x.Bits * (1 << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(I11F21 x) => I4F28.FromBits(x.Bits * (1 << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(I11F21 x) => I3F29.FromBits(x.Bits * (1 << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(I11F21 x) => I2F30.FromBits(x.Bits * (1 << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(I11F21 x) => U31F1.FromBits((uint)(x.Bits / (1 << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(I11F21 x) => U30F2.FromBits((uint)(x.Bits / (1 << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(I11F21 x) => U29F3.FromBits((uint)(x.Bits / (1 << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(I11F21 x) => U28F4.FromBits((uint)(x.Bits / (1 << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(I11F21 x) => U27F5.FromBits((uint)(x.Bits / (1 << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(I11F21 x) => U26F6.FromBits((uint)(x.Bits / (1 << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(I11F21 x) => U25F7.FromBits((uint)(x.Bits / (1 << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(I11F21 x) => U24F8.FromBits((uint)(x.Bits / (1 << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(I11F21 x) => U23F9.FromBits((uint)(x.Bits / (1 << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(I11F21 x) => U22F10.FromBits((uint)(x.Bits / (1 << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(I11F21 x) => U21F11.FromBits((uint)(x.Bits / (1 << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(I11F21 x) => U20F12.FromBits((uint)(x.Bits / (1 << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(I11F21 x) => U19F13.FromBits((uint)(x.Bits / (1 << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(I11F21 x) => U18F14.FromBits((uint)(x.Bits / (1 << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(I11F21 x) => U17F15.FromBits((uint)(x.Bits / (1 << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(I11F21 x) => U16F16.FromBits((uint)(x.Bits / (1 << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(I11F21 x) => U15F17.FromBits((uint)(x.Bits / (1 << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(I11F21 x) => U14F18.FromBits((uint)(x.Bits / (1 << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(I11F21 x) => U13F19.FromBits((uint)(x.Bits / (1 << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(I11F21 x) => U12F20.FromBits((uint)(x.Bits / (1 << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(I11F21 x) => U10F22.FromBits((uint)x.Bits * (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(I11F21 x) => U9F23.FromBits((uint)x.Bits * (1U << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(I11F21 x) => U8F24.FromBits((uint)x.Bits * (1U << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(I11F21 x) => U7F25.FromBits((uint)x.Bits * (1U << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(I11F21 x) => U6F26.FromBits((uint)x.Bits * (1U << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(I11F21 x) => U5F27.FromBits((uint)x.Bits * (1U << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(I11F21 x) => U4F28.FromBits((uint)x.Bits * (1U << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(I11F21 x) => U3F29.FromBits((uint)x.Bits * (1U << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(I11F21 x) => U2F30.FromBits((uint)x.Bits * (1U << 9));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is I11F21 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<I11F21>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(I11F21 rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
