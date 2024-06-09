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

    public struct U17F47 : IEquatable<U17F47>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 17;
        public const int FracNbits = 47;

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

        public static readonly U17F47 Zero = FromNum(0);
        public static readonly U17F47 One = FromNum(1);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        U17F47(ulong bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F47 FromBits(ulong bits) => new U17F47(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F47 FromNum(ulong num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F47 operator +(U17F47 left, U17F47 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F47 operator -(U17F47 left, U17F47 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F47 operator *(U17F47 left, U17F47 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U17F47 operator /(U17F47 left, U17F47 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * oneRepr / right.Bits));
        }

#endif

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U17F47 lhs, U17F47 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U17F47 lhs, U17F47 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U17F47 left, U17F47 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U17F47 left, U17F47 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U17F47 left, U17F47 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U17F47 left, U17F47 right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U17F47 Min(U17F47 other) => FromBits(System.Math.Min(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U17F47 Max(U17F47 other) => FromBits(System.Math.Max(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U17F47 Clamp(U17F47 min, U17F47 max) => FromBits(Math.Clamp(bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U16F48 LosslessMul(U63F1 other) => U16F48.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U15F49 LosslessMul(U62F2 other) => U15F49.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U14F50 LosslessMul(U61F3 other) => U14F50.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U13F51 LosslessMul(U60F4 other) => U13F51.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U12F52 LosslessMul(U59F5 other) => U12F52.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U11F53 LosslessMul(U58F6 other) => U11F53.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U10F54 LosslessMul(U57F7 other) => U10F54.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U9F55 LosslessMul(U56F8 other) => U9F55.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U8F56 LosslessMul(U55F9 other) => U8F56.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U7F57 LosslessMul(U54F10 other) => U7F57.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U6F58 LosslessMul(U53F11 other) => U6F58.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U5F59 LosslessMul(U52F12 other) => U5F59.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U4F60 LosslessMul(U51F13 other) => U4F60.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U3F61 LosslessMul(U50F14 other) => U3F61.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 LosslessMul(U49F15 other) => U2F62.FromBits(bits * other.Bits);

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(U17F47 x) => (int)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(U17F47 x) => (uint)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(U17F47 x) => (long)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(U17F47 x) => x.bits / oneRepr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(U17F47 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(U17F47 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(U17F47 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(U17F47 x) => I31F1.FromBits((int)(x.Bits / (1UL << 46)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(U17F47 x) => I30F2.FromBits((int)(x.Bits / (1UL << 45)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(U17F47 x) => I29F3.FromBits((int)(x.Bits / (1UL << 44)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(U17F47 x) => I28F4.FromBits((int)(x.Bits / (1UL << 43)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(U17F47 x) => I27F5.FromBits((int)(x.Bits / (1UL << 42)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(U17F47 x) => I26F6.FromBits((int)(x.Bits / (1UL << 41)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(U17F47 x) => I25F7.FromBits((int)(x.Bits / (1UL << 40)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(U17F47 x) => I24F8.FromBits((int)(x.Bits / (1UL << 39)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(U17F47 x) => I23F9.FromBits((int)(x.Bits / (1UL << 38)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(U17F47 x) => I22F10.FromBits((int)(x.Bits / (1UL << 37)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(U17F47 x) => I21F11.FromBits((int)(x.Bits / (1UL << 36)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(U17F47 x) => I20F12.FromBits((int)(x.Bits / (1UL << 35)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(U17F47 x) => I19F13.FromBits((int)(x.Bits / (1UL << 34)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(U17F47 x) => I18F14.FromBits((int)(x.Bits / (1UL << 33)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(U17F47 x) => I17F15.FromBits((int)(x.Bits / (1UL << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(U17F47 x) => I16F16.FromBits((int)(x.Bits / (1UL << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(U17F47 x) => I15F17.FromBits((int)(x.Bits / (1UL << 30)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(U17F47 x) => I14F18.FromBits((int)(x.Bits / (1UL << 29)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(U17F47 x) => I13F19.FromBits((int)(x.Bits / (1UL << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(U17F47 x) => I12F20.FromBits((int)(x.Bits / (1UL << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(U17F47 x) => I11F21.FromBits((int)(x.Bits / (1UL << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(U17F47 x) => I10F22.FromBits((int)(x.Bits / (1UL << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(U17F47 x) => I9F23.FromBits((int)(x.Bits / (1UL << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(U17F47 x) => I8F24.FromBits((int)(x.Bits / (1UL << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(U17F47 x) => I7F25.FromBits((int)(x.Bits / (1UL << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(U17F47 x) => I6F26.FromBits((int)(x.Bits / (1UL << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(U17F47 x) => I5F27.FromBits((int)(x.Bits / (1UL << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(U17F47 x) => I4F28.FromBits((int)(x.Bits / (1UL << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(U17F47 x) => I3F29.FromBits((int)(x.Bits / (1UL << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(U17F47 x) => I2F30.FromBits((int)(x.Bits / (1UL << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(U17F47 x) => U31F1.FromBits((uint)(x.Bits / (1UL << 46)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(U17F47 x) => U30F2.FromBits((uint)(x.Bits / (1UL << 45)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(U17F47 x) => U29F3.FromBits((uint)(x.Bits / (1UL << 44)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(U17F47 x) => U28F4.FromBits((uint)(x.Bits / (1UL << 43)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(U17F47 x) => U27F5.FromBits((uint)(x.Bits / (1UL << 42)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(U17F47 x) => U26F6.FromBits((uint)(x.Bits / (1UL << 41)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(U17F47 x) => U25F7.FromBits((uint)(x.Bits / (1UL << 40)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(U17F47 x) => U24F8.FromBits((uint)(x.Bits / (1UL << 39)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(U17F47 x) => U23F9.FromBits((uint)(x.Bits / (1UL << 38)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(U17F47 x) => U22F10.FromBits((uint)(x.Bits / (1UL << 37)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(U17F47 x) => U21F11.FromBits((uint)(x.Bits / (1UL << 36)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(U17F47 x) => U20F12.FromBits((uint)(x.Bits / (1UL << 35)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(U17F47 x) => U19F13.FromBits((uint)(x.Bits / (1UL << 34)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(U17F47 x) => U18F14.FromBits((uint)(x.Bits / (1UL << 33)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(U17F47 x) => U17F15.FromBits((uint)(x.Bits / (1UL << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(U17F47 x) => U16F16.FromBits((uint)(x.Bits / (1UL << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(U17F47 x) => U15F17.FromBits((uint)(x.Bits / (1UL << 30)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(U17F47 x) => U14F18.FromBits((uint)(x.Bits / (1UL << 29)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(U17F47 x) => U13F19.FromBits((uint)(x.Bits / (1UL << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(U17F47 x) => U12F20.FromBits((uint)(x.Bits / (1UL << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(U17F47 x) => U11F21.FromBits((uint)(x.Bits / (1UL << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(U17F47 x) => U10F22.FromBits((uint)(x.Bits / (1UL << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(U17F47 x) => U9F23.FromBits((uint)(x.Bits / (1UL << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(U17F47 x) => U8F24.FromBits((uint)(x.Bits / (1UL << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(U17F47 x) => U7F25.FromBits((uint)(x.Bits / (1UL << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(U17F47 x) => U6F26.FromBits((uint)(x.Bits / (1UL << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(U17F47 x) => U5F27.FromBits((uint)(x.Bits / (1UL << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(U17F47 x) => U4F28.FromBits((uint)(x.Bits / (1UL << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(U17F47 x) => U3F29.FromBits((uint)(x.Bits / (1UL << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(U17F47 x) => U2F30.FromBits((uint)(x.Bits / (1UL << 17)));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is U17F47 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<U17F47>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(U17F47 rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
