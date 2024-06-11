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

    public struct U30F2 : IEquatable<U30F2>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 30;
        public const int FracNbits = 2;

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

        public static readonly U30F2 Zero = FromNum(0);
        public static readonly U30F2 One = FromNum(1);
        public static readonly U30F2 MinValue = FromNum(uint.MinValue);
        public static readonly U30F2 MaxValue = FromNum(uint.MaxValue);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        U30F2(uint bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U30F2 FromBits(uint bits) => new U30F2(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U30F2 FromNum(uint num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U30F2 operator +(U30F2 left, U30F2 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U30F2 operator -(U30F2 left, U30F2 right) {
            return FromBits(left.Bits - right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U30F2 operator *(U30F2 left, U30F2 right) {
            ulong l = left.Bits;
            return FromBits((uint)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U30F2 operator /(U30F2 left, U30F2 right) {
            ulong l = left.Bits;
            return FromBits((uint)(l * oneRepr / right.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U30F2 operator +(U30F2 x) => FromBits(+x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U30F2 lhs, U30F2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U30F2 lhs, U30F2 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U30F2 left, U30F2 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U30F2 left, U30F2 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U30F2 left, U30F2 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U30F2 left, U30F2 right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U30F2 Min(U30F2 other) => FromBits(System.Math.Min(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U30F2 Max(U30F2 other) => FromBits(System.Math.Max(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U30F2 Clamp(U30F2 min, U30F2 max) => FromBits(Math.Clamp(bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U29F3 LosslessMul(U31F1 other) => U29F3.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U28F4 LosslessMul(U30F2 other) => U28F4.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U27F5 LosslessMul(U29F3 other) => U27F5.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U26F6 LosslessMul(U28F4 other) => U26F6.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U25F7 LosslessMul(U27F5 other) => U25F7.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U24F8 LosslessMul(U26F6 other) => U24F8.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U23F9 LosslessMul(U25F7 other) => U23F9.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U22F10 LosslessMul(U24F8 other) => U22F10.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U21F11 LosslessMul(U23F9 other) => U21F11.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U20F12 LosslessMul(U22F10 other) => U20F12.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U19F13 LosslessMul(U21F11 other) => U19F13.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U18F14 LosslessMul(U20F12 other) => U18F14.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U17F15 LosslessMul(U19F13 other) => U17F15.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U16F16 LosslessMul(U18F14 other) => U16F16.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U15F17 LosslessMul(U17F15 other) => U15F17.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U14F18 LosslessMul(U16F16 other) => U14F18.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U13F19 LosslessMul(U15F17 other) => U13F19.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U12F20 LosslessMul(U14F18 other) => U12F20.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U11F21 LosslessMul(U13F19 other) => U11F21.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U10F22 LosslessMul(U12F20 other) => U10F22.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U9F23 LosslessMul(U11F21 other) => U9F23.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U8F24 LosslessMul(U10F22 other) => U8F24.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U7F25 LosslessMul(U9F23 other) => U7F25.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U6F26 LosslessMul(U8F24 other) => U6F26.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U5F27 LosslessMul(U7F25 other) => U5F27.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U4F28 LosslessMul(U6F26 other) => U4F28.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U3F29 LosslessMul(U5F27 other) => U3F29.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F30 LosslessMul(U4F28 other) => U2F30.FromBits(bits * other.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U62F2 WideningMul(uint other) => U62F2.FromBits((ulong)bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U61F3 WideningMul(U31F1 other) => U61F3.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U60F4 WideningMul(U30F2 other) => U60F4.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U59F5 WideningMul(U29F3 other) => U59F5.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U58F6 WideningMul(U28F4 other) => U58F6.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U57F7 WideningMul(U27F5 other) => U57F7.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U56F8 WideningMul(U26F6 other) => U56F8.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U55F9 WideningMul(U25F7 other) => U55F9.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U54F10 WideningMul(U24F8 other) => U54F10.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U53F11 WideningMul(U23F9 other) => U53F11.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U52F12 WideningMul(U22F10 other) => U52F12.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U51F13 WideningMul(U21F11 other) => U51F13.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U50F14 WideningMul(U20F12 other) => U50F14.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U49F15 WideningMul(U19F13 other) => U49F15.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U48F16 WideningMul(U18F14 other) => U48F16.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U47F17 WideningMul(U17F15 other) => U47F17.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U46F18 WideningMul(U16F16 other) => U46F18.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U45F19 WideningMul(U15F17 other) => U45F19.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U44F20 WideningMul(U14F18 other) => U44F20.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U43F21 WideningMul(U13F19 other) => U43F21.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U42F22 WideningMul(U12F20 other) => U42F22.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U41F23 WideningMul(U11F21 other) => U41F23.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U40F24 WideningMul(U10F22 other) => U40F24.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U39F25 WideningMul(U9F23 other) => U39F25.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U38F26 WideningMul(U8F24 other) => U38F26.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U37F27 WideningMul(U7F25 other) => U37F27.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U36F28 WideningMul(U6F26 other) => U36F28.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U35F29 WideningMul(U5F27 other) => U35F29.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 WideningMul(U4F28 other) => U34F30.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U33F31 WideningMul(U3F29 other) => U33F31.FromBits((ulong)bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U32F32 WideningMul(U2F30 other) => U32F32.FromBits((ulong)bits * other.Bits);

        // Implicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U62F2(U30F2 x) => U62F2.FromBits(x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U61F3(U30F2 x) => U61F3.FromBits((ulong)x.Bits << 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U60F4(U30F2 x) => U60F4.FromBits((ulong)x.Bits << 2);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U59F5(U30F2 x) => U59F5.FromBits((ulong)x.Bits << 3);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U58F6(U30F2 x) => U58F6.FromBits((ulong)x.Bits << 4);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U57F7(U30F2 x) => U57F7.FromBits((ulong)x.Bits << 5);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U56F8(U30F2 x) => U56F8.FromBits((ulong)x.Bits << 6);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U55F9(U30F2 x) => U55F9.FromBits((ulong)x.Bits << 7);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U54F10(U30F2 x) => U54F10.FromBits((ulong)x.Bits << 8);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U53F11(U30F2 x) => U53F11.FromBits((ulong)x.Bits << 9);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U52F12(U30F2 x) => U52F12.FromBits((ulong)x.Bits << 10);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U51F13(U30F2 x) => U51F13.FromBits((ulong)x.Bits << 11);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U50F14(U30F2 x) => U50F14.FromBits((ulong)x.Bits << 12);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U49F15(U30F2 x) => U49F15.FromBits((ulong)x.Bits << 13);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U48F16(U30F2 x) => U48F16.FromBits((ulong)x.Bits << 14);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U47F17(U30F2 x) => U47F17.FromBits((ulong)x.Bits << 15);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U46F18(U30F2 x) => U46F18.FromBits((ulong)x.Bits << 16);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U45F19(U30F2 x) => U45F19.FromBits((ulong)x.Bits << 17);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U44F20(U30F2 x) => U44F20.FromBits((ulong)x.Bits << 18);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U43F21(U30F2 x) => U43F21.FromBits((ulong)x.Bits << 19);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U42F22(U30F2 x) => U42F22.FromBits((ulong)x.Bits << 20);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U41F23(U30F2 x) => U41F23.FromBits((ulong)x.Bits << 21);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U40F24(U30F2 x) => U40F24.FromBits((ulong)x.Bits << 22);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U39F25(U30F2 x) => U39F25.FromBits((ulong)x.Bits << 23);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U38F26(U30F2 x) => U38F26.FromBits((ulong)x.Bits << 24);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U37F27(U30F2 x) => U37F27.FromBits((ulong)x.Bits << 25);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U36F28(U30F2 x) => U36F28.FromBits((ulong)x.Bits << 26);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U35F29(U30F2 x) => U35F29.FromBits((ulong)x.Bits << 27);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U34F30(U30F2 x) => U34F30.FromBits((ulong)x.Bits << 28);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U33F31(U30F2 x) => U33F31.FromBits((ulong)x.Bits << 29);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U32F32(U30F2 x) => U32F32.FromBits((ulong)x.Bits << 30);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U31F33(U30F2 x) => U31F33.FromBits((ulong)x.Bits << 31);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator U30F34(U30F2 x) => U30F34.FromBits((ulong)x.Bits << 32);

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(U30F2 x) => (int)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(U30F2 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(U30F2 x) => x.bits / oneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(U30F2 x) => x.bits / oneRepr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(U30F2 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(U30F2 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(U30F2 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(U30F2 x) => I31F1.FromBits((int)(x.Bits / (1U << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(U30F2 x) => I29F3.FromBits((int)x.Bits * (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(U30F2 x) => I28F4.FromBits((int)x.Bits * (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(U30F2 x) => I27F5.FromBits((int)x.Bits * (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(U30F2 x) => I26F6.FromBits((int)x.Bits * (1 << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(U30F2 x) => I25F7.FromBits((int)x.Bits * (1 << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(U30F2 x) => I24F8.FromBits((int)x.Bits * (1 << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(U30F2 x) => I23F9.FromBits((int)x.Bits * (1 << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(U30F2 x) => I22F10.FromBits((int)x.Bits * (1 << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(U30F2 x) => I21F11.FromBits((int)x.Bits * (1 << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(U30F2 x) => I20F12.FromBits((int)x.Bits * (1 << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(U30F2 x) => I19F13.FromBits((int)x.Bits * (1 << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(U30F2 x) => I18F14.FromBits((int)x.Bits * (1 << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(U30F2 x) => I17F15.FromBits((int)x.Bits * (1 << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(U30F2 x) => I16F16.FromBits((int)x.Bits * (1 << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(U30F2 x) => I15F17.FromBits((int)x.Bits * (1 << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(U30F2 x) => I14F18.FromBits((int)x.Bits * (1 << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(U30F2 x) => I13F19.FromBits((int)x.Bits * (1 << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(U30F2 x) => I12F20.FromBits((int)x.Bits * (1 << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(U30F2 x) => I11F21.FromBits((int)x.Bits * (1 << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(U30F2 x) => I10F22.FromBits((int)x.Bits * (1 << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(U30F2 x) => I9F23.FromBits((int)x.Bits * (1 << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(U30F2 x) => I8F24.FromBits((int)x.Bits * (1 << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(U30F2 x) => I7F25.FromBits((int)x.Bits * (1 << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(U30F2 x) => I6F26.FromBits((int)x.Bits * (1 << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(U30F2 x) => I5F27.FromBits((int)x.Bits * (1 << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(U30F2 x) => I4F28.FromBits((int)x.Bits * (1 << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(U30F2 x) => I3F29.FromBits((int)x.Bits * (1 << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(U30F2 x) => I2F30.FromBits((int)x.Bits * (1 << 28));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(U30F2 x) => U31F1.FromBits(x.Bits / (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(U30F2 x) => U29F3.FromBits(x.Bits * (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(U30F2 x) => U28F4.FromBits(x.Bits * (1U << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(U30F2 x) => U27F5.FromBits(x.Bits * (1U << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(U30F2 x) => U26F6.FromBits(x.Bits * (1U << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(U30F2 x) => U25F7.FromBits(x.Bits * (1U << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(U30F2 x) => U24F8.FromBits(x.Bits * (1U << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(U30F2 x) => U23F9.FromBits(x.Bits * (1U << 7));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(U30F2 x) => U22F10.FromBits(x.Bits * (1U << 8));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(U30F2 x) => U21F11.FromBits(x.Bits * (1U << 9));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(U30F2 x) => U20F12.FromBits(x.Bits * (1U << 10));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(U30F2 x) => U19F13.FromBits(x.Bits * (1U << 11));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(U30F2 x) => U18F14.FromBits(x.Bits * (1U << 12));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(U30F2 x) => U17F15.FromBits(x.Bits * (1U << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(U30F2 x) => U16F16.FromBits(x.Bits * (1U << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(U30F2 x) => U15F17.FromBits(x.Bits * (1U << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(U30F2 x) => U14F18.FromBits(x.Bits * (1U << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(U30F2 x) => U13F19.FromBits(x.Bits * (1U << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(U30F2 x) => U12F20.FromBits(x.Bits * (1U << 18));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(U30F2 x) => U11F21.FromBits(x.Bits * (1U << 19));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(U30F2 x) => U10F22.FromBits(x.Bits * (1U << 20));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(U30F2 x) => U9F23.FromBits(x.Bits * (1U << 21));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(U30F2 x) => U8F24.FromBits(x.Bits * (1U << 22));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(U30F2 x) => U7F25.FromBits(x.Bits * (1U << 23));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(U30F2 x) => U6F26.FromBits(x.Bits * (1U << 24));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(U30F2 x) => U5F27.FromBits(x.Bits * (1U << 25));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(U30F2 x) => U4F28.FromBits(x.Bits * (1U << 26));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(U30F2 x) => U3F29.FromBits(x.Bits * (1U << 27));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(U30F2 x) => U2F30.FromBits(x.Bits * (1U << 28));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is U30F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<U30F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(U30F2 rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
