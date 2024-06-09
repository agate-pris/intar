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

    public struct U26F38 : IEquatable<U26F38>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 26;
        public const int FracNbits = 38;

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

        public static readonly U26F38 Zero = FromNum(0);
        public static readonly U26F38 One = FromNum(1);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        U26F38(ulong bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U26F38 FromBits(ulong bits) => new U26F38(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U26F38 FromNum(ulong num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U26F38 operator +(U26F38 left, U26F38 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U26F38 operator -(U26F38 left, U26F38 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U26F38 operator *(U26F38 left, U26F38 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U26F38 operator /(U26F38 left, U26F38 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * oneRepr / right.Bits));
        }

#endif

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U26F38 lhs, U26F38 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U26F38 lhs, U26F38 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U26F38 left, U26F38 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U26F38 left, U26F38 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U26F38 left, U26F38 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U26F38 left, U26F38 right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U25F39 LosslessMul(U63F1 other) => U25F39.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U24F40 LosslessMul(U62F2 other) => U24F40.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U23F41 LosslessMul(U61F3 other) => U23F41.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U22F42 LosslessMul(U60F4 other) => U22F42.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U21F43 LosslessMul(U59F5 other) => U21F43.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U20F44 LosslessMul(U58F6 other) => U20F44.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U19F45 LosslessMul(U57F7 other) => U19F45.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U18F46 LosslessMul(U56F8 other) => U18F46.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U17F47 LosslessMul(U55F9 other) => U17F47.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U16F48 LosslessMul(U54F10 other) => U16F48.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U15F49 LosslessMul(U53F11 other) => U15F49.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U14F50 LosslessMul(U52F12 other) => U14F50.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U13F51 LosslessMul(U51F13 other) => U13F51.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U12F52 LosslessMul(U50F14 other) => U12F52.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U11F53 LosslessMul(U49F15 other) => U11F53.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U10F54 LosslessMul(U48F16 other) => U10F54.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U9F55 LosslessMul(U47F17 other) => U9F55.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U8F56 LosslessMul(U46F18 other) => U8F56.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U7F57 LosslessMul(U45F19 other) => U7F57.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U6F58 LosslessMul(U44F20 other) => U6F58.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U5F59 LosslessMul(U43F21 other) => U5F59.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U4F60 LosslessMul(U42F22 other) => U4F60.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U3F61 LosslessMul(U41F23 other) => U3F61.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 LosslessMul(U40F24 other) => U2F62.FromBits(bits * other.Bits);

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(U26F38 x) => (int)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(U26F38 x) => (uint)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(U26F38 x) => (long)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(U26F38 x) => x.bits / oneRepr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(U26F38 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(U26F38 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(U26F38 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(U26F38 x) => I31F1.FromBits((int)(x.Bits / (1UL << 37)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(U26F38 x) => I30F2.FromBits((int)(x.Bits / (1UL << 36)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(U26F38 x) => I29F3.FromBits((int)(x.Bits / (1UL << 35)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(U26F38 x) => I28F4.FromBits((int)(x.Bits / (1UL << 34)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(U26F38 x) => I27F5.FromBits((int)(x.Bits / (1UL << 33)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(U26F38 x) => I26F6.FromBits((int)(x.Bits / (1UL << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(U26F38 x) => I25F7.FromBits((int)(x.Bits / (1UL << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(U26F38 x) => I24F8.FromBits((int)(x.Bits / (1UL << 30)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(U26F38 x) => I23F9.FromBits((int)(x.Bits / (1UL << 29)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(U26F38 x) => I22F10.FromBits((int)(x.Bits / (1UL << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(U26F38 x) => I21F11.FromBits((int)(x.Bits / (1UL << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(U26F38 x) => I20F12.FromBits((int)(x.Bits / (1UL << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(U26F38 x) => I19F13.FromBits((int)(x.Bits / (1UL << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(U26F38 x) => I18F14.FromBits((int)(x.Bits / (1UL << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(U26F38 x) => I17F15.FromBits((int)(x.Bits / (1UL << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(U26F38 x) => I16F16.FromBits((int)(x.Bits / (1UL << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(U26F38 x) => I15F17.FromBits((int)(x.Bits / (1UL << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(U26F38 x) => I14F18.FromBits((int)(x.Bits / (1UL << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(U26F38 x) => I13F19.FromBits((int)(x.Bits / (1UL << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(U26F38 x) => I12F20.FromBits((int)(x.Bits / (1UL << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(U26F38 x) => I11F21.FromBits((int)(x.Bits / (1UL << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(U26F38 x) => I10F22.FromBits((int)(x.Bits / (1UL << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(U26F38 x) => I9F23.FromBits((int)(x.Bits / (1UL << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(U26F38 x) => I8F24.FromBits((int)(x.Bits / (1UL << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(U26F38 x) => I7F25.FromBits((int)(x.Bits / (1UL << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(U26F38 x) => I6F26.FromBits((int)(x.Bits / (1UL << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(U26F38 x) => I5F27.FromBits((int)(x.Bits / (1UL << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(U26F38 x) => I4F28.FromBits((int)(x.Bits / (1UL << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(U26F38 x) => I3F29.FromBits((int)(x.Bits / (1UL << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(U26F38 x) => I2F30.FromBits((int)(x.Bits / (1UL << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(U26F38 x) => U31F1.FromBits((uint)(x.Bits / (1UL << 37)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(U26F38 x) => U30F2.FromBits((uint)(x.Bits / (1UL << 36)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(U26F38 x) => U29F3.FromBits((uint)(x.Bits / (1UL << 35)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(U26F38 x) => U28F4.FromBits((uint)(x.Bits / (1UL << 34)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(U26F38 x) => U27F5.FromBits((uint)(x.Bits / (1UL << 33)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(U26F38 x) => U26F6.FromBits((uint)(x.Bits / (1UL << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(U26F38 x) => U25F7.FromBits((uint)(x.Bits / (1UL << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(U26F38 x) => U24F8.FromBits((uint)(x.Bits / (1UL << 30)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(U26F38 x) => U23F9.FromBits((uint)(x.Bits / (1UL << 29)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(U26F38 x) => U22F10.FromBits((uint)(x.Bits / (1UL << 28)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(U26F38 x) => U21F11.FromBits((uint)(x.Bits / (1UL << 27)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(U26F38 x) => U20F12.FromBits((uint)(x.Bits / (1UL << 26)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(U26F38 x) => U19F13.FromBits((uint)(x.Bits / (1UL << 25)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(U26F38 x) => U18F14.FromBits((uint)(x.Bits / (1UL << 24)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(U26F38 x) => U17F15.FromBits((uint)(x.Bits / (1UL << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(U26F38 x) => U16F16.FromBits((uint)(x.Bits / (1UL << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(U26F38 x) => U15F17.FromBits((uint)(x.Bits / (1UL << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(U26F38 x) => U14F18.FromBits((uint)(x.Bits / (1UL << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(U26F38 x) => U13F19.FromBits((uint)(x.Bits / (1UL << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(U26F38 x) => U12F20.FromBits((uint)(x.Bits / (1UL << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(U26F38 x) => U11F21.FromBits((uint)(x.Bits / (1UL << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(U26F38 x) => U10F22.FromBits((uint)(x.Bits / (1UL << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(U26F38 x) => U9F23.FromBits((uint)(x.Bits / (1UL << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U8F24(U26F38 x) => U8F24.FromBits((uint)(x.Bits / (1UL << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(U26F38 x) => U7F25.FromBits((uint)(x.Bits / (1UL << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(U26F38 x) => U6F26.FromBits((uint)(x.Bits / (1UL << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(U26F38 x) => U5F27.FromBits((uint)(x.Bits / (1UL << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(U26F38 x) => U4F28.FromBits((uint)(x.Bits / (1UL << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(U26F38 x) => U3F29.FromBits((uint)(x.Bits / (1UL << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(U26F38 x) => U2F30.FromBits((uint)(x.Bits / (1UL << 8)));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is U26F38 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<U26F38>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(U26F38 rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
