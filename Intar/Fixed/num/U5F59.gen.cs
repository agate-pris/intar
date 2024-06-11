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

    public struct U5F59 : IEquatable<U5F59>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 5;
        public const int FracNbits = 59;

        const ulong oneRepr = 1UL << FracNbits;

        // Fields
        // ------

#if UNITY_5_6_OR_NEWER
        [SerializeField]
#else
        readonly
#endif

        ulong bits;

        // Properties
        // ----------

        public readonly ulong Bits {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => bits;
        }

        // Static readonly properties
        // --------------------------

        public static readonly U5F59 Zero = FromNum(0);
        public static readonly U5F59 One = FromNum(1);
        public static readonly U5F59 MinValue = FromNum(ulong.MinValue);
        public static readonly U5F59 MaxValue = FromNum(ulong.MaxValue);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        U5F59(ulong bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F59 FromBits(ulong bits) => new U5F59(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F59 FromNum(ulong num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F59 operator +(U5F59 left, U5F59 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F59 operator -(U5F59 left, U5F59 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F59 operator *(U5F59 left, U5F59 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F59 operator /(U5F59 left, U5F59 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * oneRepr / right.Bits));
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F59 operator +(U5F59 x) => FromBits(+x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U5F59 lhs, U5F59 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U5F59 lhs, U5F59 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U5F59 left, U5F59 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U5F59 left, U5F59 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U5F59 left, U5F59 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U5F59 left, U5F59 right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U5F59 Min(U5F59 other) => FromBits(System.Math.Min(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U5F59 Max(U5F59 other) => FromBits(System.Math.Max(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U5F59 Clamp(U5F59 min, U5F59 max) => FromBits(Math.Clamp(bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U5F59 LosslessMul(ulong other) => U5F59.FromBits(bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U4F60 LosslessMul(U63F1 other) => U4F60.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U3F61 LosslessMul(U62F2 other) => U3F61.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 LosslessMul(U61F3 other) => U2F62.FromBits(bits * other.Bits);

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(U5F59 x) => (int)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(U5F59 x) => (uint)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(U5F59 x) => (long)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(U5F59 x) => x.bits / oneRepr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(U5F59 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(U5F59 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(U5F59 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(U5F59 x) => I31F1.FromBits((int)(x.Bits / (1UL << 58)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(U5F59 x) => I30F2.FromBits((int)(x.Bits / (1UL << 57)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(U5F59 x) => I29F3.FromBits((int)(x.Bits / (1UL << 56)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(U5F59 x) => I28F4.FromBits((int)(x.Bits / (1UL << 55)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(U5F59 x) => I27F5.FromBits((int)(x.Bits / (1UL << 54)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(U5F59 x) => I26F6.FromBits((int)(x.Bits / (1UL << 53)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(U5F59 x) => I25F7.FromBits((int)(x.Bits / (1UL << 52)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(U5F59 x) => I24F8.FromBits((int)(x.Bits / (1UL << 51)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(U5F59 x) => I23F9.FromBits((int)(x.Bits / (1UL << 50)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(U5F59 x) => I22F10.FromBits((int)(x.Bits / (1UL << 49)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(U5F59 x) => I21F11.FromBits((int)(x.Bits / (1UL << 48)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(U5F59 x) => I20F12.FromBits((int)(x.Bits / (1UL << 47)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(U5F59 x) => I19F13.FromBits((int)(x.Bits / (1UL << 46)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(U5F59 x) => I18F14.FromBits((int)(x.Bits / (1UL << 45)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(U5F59 x) => I17F15.FromBits((int)(x.Bits / (1UL << 44)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(U5F59 x) => I16F16.FromBits((int)(x.Bits / (1UL << 43)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(U5F59 x) => I15F17.FromBits((int)(x.Bits / (1UL << 42)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(U5F59 x) => I14F18.FromBits((int)(x.Bits / (1UL << 41)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(U5F59 x) => I13F19.FromBits((int)(x.Bits / (1UL << 40)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(U5F59 x) => I12F20.FromBits((int)(x.Bits / (1UL << 39)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(U5F59 x) => I11F21.FromBits((int)(x.Bits / (1UL << 38)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(U5F59 x) => I10F22.FromBits((int)(x.Bits / (1UL << 37)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(U5F59 x) => I9F23.FromBits((int)(x.Bits / (1UL << 36)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(U5F59 x) => I8F24.FromBits((int)(x.Bits / (1UL << 35)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(U5F59 x) => I7F25.FromBits((int)(x.Bits / (1UL << 34)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(U5F59 x) => I6F26.FromBits((int)(x.Bits / (1UL << 33)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(U5F59 x) => I5F27.FromBits((int)(x.Bits / (1UL << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(U5F59 x) => I4F28.FromBits((int)(x.Bits / (1UL << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(U5F59 x) => I3F29.FromBits((int)(x.Bits / (1UL << 30)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(U5F59 x) => I2F30.FromBits((int)(x.Bits / (1UL << 29)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(U5F59 x) => U31F1.FromBits((uint)(x.Bits / (1UL << 58)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(U5F59 x) => U30F2.FromBits((uint)(x.Bits / (1UL << 57)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(U5F59 x) => U29F3.FromBits((uint)(x.Bits / (1UL << 56)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(U5F59 x) => U28F4.FromBits((uint)(x.Bits / (1UL << 55)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(U5F59 x) => U27F5.FromBits((uint)(x.Bits / (1UL << 54)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(U5F59 x) => U26F6.FromBits((uint)(x.Bits / (1UL << 53)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(U5F59 x) => U25F7.FromBits((uint)(x.Bits / (1UL << 52)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(U5F59 x) => U24F8.FromBits((uint)(x.Bits / (1UL << 51)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(U5F59 x) => U23F9.FromBits((uint)(x.Bits / (1UL << 50)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(U5F59 x) => U22F10.FromBits((uint)(x.Bits / (1UL << 49)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(U5F59 x) => U21F11.FromBits((uint)(x.Bits / (1UL << 48)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(U5F59 x) => U20F12.FromBits((uint)(x.Bits / (1UL << 47)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(U5F59 x) => U19F13.FromBits((uint)(x.Bits / (1UL << 46)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(U5F59 x) => U18F14.FromBits((uint)(x.Bits / (1UL << 45)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(U5F59 x) => U17F15.FromBits((uint)(x.Bits / (1UL << 44)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(U5F59 x) => U16F16.FromBits((uint)(x.Bits / (1UL << 43)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(U5F59 x) => U15F17.FromBits((uint)(x.Bits / (1UL << 42)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(U5F59 x) => U14F18.FromBits((uint)(x.Bits / (1UL << 41)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(U5F59 x) => U13F19.FromBits((uint)(x.Bits / (1UL << 40)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(U5F59 x) => U12F20.FromBits((uint)(x.Bits / (1UL << 39)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(U5F59 x) => U11F21.FromBits((uint)(x.Bits / (1UL << 38)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(U5F59 x) => U10F22.FromBits((uint)(x.Bits / (1UL << 37)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(U5F59 x) => U9F23.FromBits((uint)(x.Bits / (1UL << 36)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(U5F59 x) => U8F24.FromBits((uint)(x.Bits / (1UL << 35)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(U5F59 x) => U7F25.FromBits((uint)(x.Bits / (1UL << 34)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(U5F59 x) => U6F26.FromBits((uint)(x.Bits / (1UL << 33)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(U5F59 x) => U5F27.FromBits((uint)(x.Bits / (1UL << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(U5F59 x) => U4F28.FromBits((uint)(x.Bits / (1UL << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(U5F59 x) => U3F29.FromBits((uint)(x.Bits / (1UL << 30)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(U5F59 x) => U2F30.FromBits((uint)(x.Bits / (1UL << 29)));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is U5F59 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<U5F59>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(U5F59 rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
