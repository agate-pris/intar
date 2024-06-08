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

    public struct I27F5 : IEquatable<I27F5>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 27;
        public const int FracNbits = 5;

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

        public static readonly I27F5 Zero = FromNum(0);
        public static readonly I27F5 One = FromNum(1);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I27F5(int bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I27F5 FromBits(int bits) => new I27F5(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I27F5 FromNum(int num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I27F5 operator +(I27F5 left, I27F5 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I27F5 operator -(I27F5 left, I27F5 right) {
            return FromBits(left.Bits - right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I27F5 operator *(I27F5 left, I27F5 right) {
            long l = left.Bits;
            return FromBits((int)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I27F5 operator /(I27F5 left, I27F5 right) {
            long l = left.Bits;
            return FromBits((int)(l * oneRepr / right.Bits));
        }

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I27F5 lhs, I27F5 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I27F5 lhs, I27F5 rhs) => !(lhs == rhs);

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I26F6 LosslessMul(I31F1 other) => I26F6.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I25F7 LosslessMul(I30F2 other) => I25F7.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I24F8 LosslessMul(I29F3 other) => I24F8.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I23F9 LosslessMul(I28F4 other) => I23F9.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I22F10 LosslessMul(I27F5 other) => I22F10.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I21F11 LosslessMul(I26F6 other) => I21F11.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I20F12 LosslessMul(I25F7 other) => I20F12.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I19F13 LosslessMul(I24F8 other) => I19F13.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F14 LosslessMul(I23F9 other) => I18F14.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 LosslessMul(I22F10 other) => I17F15.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I16F16 LosslessMul(I21F11 other) => I16F16.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I15F17 LosslessMul(I20F12 other) => I15F17.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I14F18 LosslessMul(I19F13 other) => I14F18.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I13F19 LosslessMul(I18F14 other) => I13F19.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I12F20 LosslessMul(I17F15 other) => I12F20.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I11F21 LosslessMul(I16F16 other) => I11F21.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I10F22 LosslessMul(I15F17 other) => I10F22.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I9F23 LosslessMul(I14F18 other) => I9F23.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I8F24 LosslessMul(I13F19 other) => I8F24.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I7F25 LosslessMul(I12F20 other) => I7F25.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I6F26 LosslessMul(I11F21 other) => I6F26.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I5F27 LosslessMul(I10F22 other) => I5F27.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I4F28 LosslessMul(I9F23 other) => I4F28.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I3F29 LosslessMul(I8F24 other) => I3F29.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 LosslessMul(I7F25 other) => I2F30.FromBits(bits * other.Bits);

        // Implicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I59F5(I27F5 x) => I59F5.FromBits(x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I58F6(I27F5 x) => I58F6.FromBits((long)x.Bits << 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I57F7(I27F5 x) => I57F7.FromBits((long)x.Bits << 2);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I56F8(I27F5 x) => I56F8.FromBits((long)x.Bits << 3);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I55F9(I27F5 x) => I55F9.FromBits((long)x.Bits << 4);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I54F10(I27F5 x) => I54F10.FromBits((long)x.Bits << 5);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I53F11(I27F5 x) => I53F11.FromBits((long)x.Bits << 6);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I52F12(I27F5 x) => I52F12.FromBits((long)x.Bits << 7);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I51F13(I27F5 x) => I51F13.FromBits((long)x.Bits << 8);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I50F14(I27F5 x) => I50F14.FromBits((long)x.Bits << 9);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I49F15(I27F5 x) => I49F15.FromBits((long)x.Bits << 10);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I48F16(I27F5 x) => I48F16.FromBits((long)x.Bits << 11);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I47F17(I27F5 x) => I47F17.FromBits((long)x.Bits << 12);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I46F18(I27F5 x) => I46F18.FromBits((long)x.Bits << 13);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I45F19(I27F5 x) => I45F19.FromBits((long)x.Bits << 14);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I44F20(I27F5 x) => I44F20.FromBits((long)x.Bits << 15);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I43F21(I27F5 x) => I43F21.FromBits((long)x.Bits << 16);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I42F22(I27F5 x) => I42F22.FromBits((long)x.Bits << 17);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I41F23(I27F5 x) => I41F23.FromBits((long)x.Bits << 18);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I40F24(I27F5 x) => I40F24.FromBits((long)x.Bits << 19);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I39F25(I27F5 x) => I39F25.FromBits((long)x.Bits << 20);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I38F26(I27F5 x) => I38F26.FromBits((long)x.Bits << 21);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I37F27(I27F5 x) => I37F27.FromBits((long)x.Bits << 22);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I36F28(I27F5 x) => I36F28.FromBits((long)x.Bits << 23);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I35F29(I27F5 x) => I35F29.FromBits((long)x.Bits << 24);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I34F30(I27F5 x) => I34F30.FromBits((long)x.Bits << 25);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I33F31(I27F5 x) => I33F31.FromBits((long)x.Bits << 26);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I32F32(I27F5 x) => I32F32.FromBits((long)x.Bits << 27);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I31F33(I27F5 x) => I31F33.FromBits((long)x.Bits << 28);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I30F34(I27F5 x) => I30F34.FromBits((long)x.Bits << 29);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I29F35(I27F5 x) => I29F35.FromBits((long)x.Bits << 30);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I28F36(I27F5 x) => I28F36.FromBits((long)x.Bits << 31);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator I27F37(I27F5 x) => I27F37.FromBits((long)x.Bits << 32);

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(I27F5 x) {
            return x.bits / oneRepr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I27F5 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I27F5 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I27F5 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is I27F5 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<I27F5>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(I27F5 rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
