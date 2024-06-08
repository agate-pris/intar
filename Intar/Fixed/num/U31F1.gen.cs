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

    public struct U31F1 : IEquatable<U31F1>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 31;
        public const int FracNbits = 1;

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

        public static readonly U31F1 Zero = FromNum(0);
        public static readonly U31F1 One = FromNum(1);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        U31F1(uint bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U31F1 FromBits(uint bits) => new U31F1(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U31F1 FromNum(uint num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U31F1 operator +(U31F1 left, U31F1 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U31F1 operator -(U31F1 left, U31F1 right) {
            return FromBits(left.Bits - right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U31F1 operator *(U31F1 left, U31F1 right) {
            ulong l = left.Bits;
            return FromBits((uint)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U31F1 operator /(U31F1 left, U31F1 right) {
            ulong l = left.Bits;
            return FromBits((uint)(l * oneRepr / right.Bits));
        }

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U31F1 lhs, U31F1 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U31F1 lhs, U31F1 rhs) => !(lhs == rhs);

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U30F2 LosslessMul(U31F1 other) => U30F2.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U29F3 LosslessMul(U30F2 other) => U29F3.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U28F4 LosslessMul(U29F3 other) => U28F4.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U27F5 LosslessMul(U28F4 other) => U27F5.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U26F6 LosslessMul(U27F5 other) => U26F6.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U25F7 LosslessMul(U26F6 other) => U25F7.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U24F8 LosslessMul(U25F7 other) => U24F8.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U23F9 LosslessMul(U24F8 other) => U23F9.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U22F10 LosslessMul(U23F9 other) => U22F10.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U21F11 LosslessMul(U22F10 other) => U21F11.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U20F12 LosslessMul(U21F11 other) => U20F12.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U19F13 LosslessMul(U20F12 other) => U19F13.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U18F14 LosslessMul(U19F13 other) => U18F14.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U17F15 LosslessMul(U18F14 other) => U17F15.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U16F16 LosslessMul(U17F15 other) => U16F16.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U15F17 LosslessMul(U16F16 other) => U15F17.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U14F18 LosslessMul(U15F17 other) => U14F18.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U13F19 LosslessMul(U14F18 other) => U13F19.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U12F20 LosslessMul(U13F19 other) => U12F20.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U11F21 LosslessMul(U12F20 other) => U11F21.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U10F22 LosslessMul(U11F21 other) => U10F22.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U9F23 LosslessMul(U10F22 other) => U9F23.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U8F24 LosslessMul(U9F23 other) => U8F24.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U7F25 LosslessMul(U8F24 other) => U7F25.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U6F26 LosslessMul(U7F25 other) => U6F26.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U5F27 LosslessMul(U6F26 other) => U5F27.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U4F28 LosslessMul(U5F27 other) => U4F28.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U3F29 LosslessMul(U4F28 other) => U3F29.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F30 LosslessMul(U3F29 other) => U2F30.FromBits(bits * other.Bits);

        // Implicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U63F1(U31F1 x) => U63F1.FromBits(x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U62F2(U31F1 x) => U62F2.FromBits((ulong)x.Bits << 1);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U61F3(U31F1 x) => U61F3.FromBits((ulong)x.Bits << 2);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U60F4(U31F1 x) => U60F4.FromBits((ulong)x.Bits << 3);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U59F5(U31F1 x) => U59F5.FromBits((ulong)x.Bits << 4);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U58F6(U31F1 x) => U58F6.FromBits((ulong)x.Bits << 5);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U57F7(U31F1 x) => U57F7.FromBits((ulong)x.Bits << 6);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U56F8(U31F1 x) => U56F8.FromBits((ulong)x.Bits << 7);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U55F9(U31F1 x) => U55F9.FromBits((ulong)x.Bits << 8);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U54F10(U31F1 x) => U54F10.FromBits((ulong)x.Bits << 9);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U53F11(U31F1 x) => U53F11.FromBits((ulong)x.Bits << 10);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U52F12(U31F1 x) => U52F12.FromBits((ulong)x.Bits << 11);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U51F13(U31F1 x) => U51F13.FromBits((ulong)x.Bits << 12);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U50F14(U31F1 x) => U50F14.FromBits((ulong)x.Bits << 13);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U49F15(U31F1 x) => U49F15.FromBits((ulong)x.Bits << 14);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U48F16(U31F1 x) => U48F16.FromBits((ulong)x.Bits << 15);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U47F17(U31F1 x) => U47F17.FromBits((ulong)x.Bits << 16);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U46F18(U31F1 x) => U46F18.FromBits((ulong)x.Bits << 17);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U45F19(U31F1 x) => U45F19.FromBits((ulong)x.Bits << 18);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U44F20(U31F1 x) => U44F20.FromBits((ulong)x.Bits << 19);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U43F21(U31F1 x) => U43F21.FromBits((ulong)x.Bits << 20);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U42F22(U31F1 x) => U42F22.FromBits((ulong)x.Bits << 21);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U41F23(U31F1 x) => U41F23.FromBits((ulong)x.Bits << 22);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U40F24(U31F1 x) => U40F24.FromBits((ulong)x.Bits << 23);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U39F25(U31F1 x) => U39F25.FromBits((ulong)x.Bits << 24);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U38F26(U31F1 x) => U38F26.FromBits((ulong)x.Bits << 25);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U37F27(U31F1 x) => U37F27.FromBits((ulong)x.Bits << 26);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U36F28(U31F1 x) => U36F28.FromBits((ulong)x.Bits << 27);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U35F29(U31F1 x) => U35F29.FromBits((ulong)x.Bits << 28);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U34F30(U31F1 x) => U34F30.FromBits((ulong)x.Bits << 29);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U33F31(U31F1 x) => U33F31.FromBits((ulong)x.Bits << 30);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U32F32(U31F1 x) => U32F32.FromBits((ulong)x.Bits << 31);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator U31F33(U31F1 x) => U31F33.FromBits((ulong)x.Bits << 32);

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(U31F1 x) {
            return x.bits / oneRepr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(U31F1 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(U31F1 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(U31F1 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is U31F1 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<U31F1>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(U31F1 rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
