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

    public struct U40F24 : IEquatable<U40F24>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 40;
        public const int FracNbits = 24;

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

        public static readonly U40F24 Zero = FromNum(0);
        public static readonly U40F24 One = FromNum(1);
        public static readonly U40F24 MinValue = FromNum(ulong.MinValue);
        public static readonly U40F24 MaxValue = FromNum(ulong.MaxValue);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        U40F24(ulong bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U40F24 FromBits(ulong bits) => new U40F24(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U40F24 FromNum(ulong num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U40F24 operator +(U40F24 left, U40F24 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U40F24 operator -(U40F24 left, U40F24 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U40F24 operator *(U40F24 left, U40F24 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U40F24 operator /(U40F24 left, U40F24 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * oneRepr / right.Bits));
        }

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U40F24 operator +(U40F24 x) => FromBits(+x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U40F24 lhs, U40F24 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U40F24 lhs, U40F24 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(U40F24 left, U40F24 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(U40F24 left, U40F24 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(U40F24 left, U40F24 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(U40F24 left, U40F24 right) => left.Bits >= right.Bits;

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U40F24 Min(U40F24 other) => FromBits(System.Math.Min(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U40F24 Max(U40F24 other) => FromBits(System.Math.Max(bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U40F24 Clamp(U40F24 min, U40F24 max) => FromBits(Math.Clamp(bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U40F24 LosslessMul(ulong other) => U40F24.FromBits(bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U39F25 LosslessMul(U63F1 other) => U39F25.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U38F26 LosslessMul(U62F2 other) => U38F26.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U37F27 LosslessMul(U61F3 other) => U37F27.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U36F28 LosslessMul(U60F4 other) => U36F28.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U35F29 LosslessMul(U59F5 other) => U35F29.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U34F30 LosslessMul(U58F6 other) => U34F30.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U33F31 LosslessMul(U57F7 other) => U33F31.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U32F32 LosslessMul(U56F8 other) => U32F32.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U31F33 LosslessMul(U55F9 other) => U31F33.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U30F34 LosslessMul(U54F10 other) => U30F34.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U29F35 LosslessMul(U53F11 other) => U29F35.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U28F36 LosslessMul(U52F12 other) => U28F36.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U27F37 LosslessMul(U51F13 other) => U27F37.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U26F38 LosslessMul(U50F14 other) => U26F38.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U25F39 LosslessMul(U49F15 other) => U25F39.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U24F40 LosslessMul(U48F16 other) => U24F40.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U23F41 LosslessMul(U47F17 other) => U23F41.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U22F42 LosslessMul(U46F18 other) => U22F42.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U21F43 LosslessMul(U45F19 other) => U21F43.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U20F44 LosslessMul(U44F20 other) => U20F44.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U19F45 LosslessMul(U43F21 other) => U19F45.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U18F46 LosslessMul(U42F22 other) => U18F46.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U17F47 LosslessMul(U41F23 other) => U17F47.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U16F48 LosslessMul(U40F24 other) => U16F48.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U15F49 LosslessMul(U39F25 other) => U15F49.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U14F50 LosslessMul(U38F26 other) => U14F50.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U13F51 LosslessMul(U37F27 other) => U13F51.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U12F52 LosslessMul(U36F28 other) => U12F52.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U11F53 LosslessMul(U35F29 other) => U11F53.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U10F54 LosslessMul(U34F30 other) => U10F54.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U9F55 LosslessMul(U33F31 other) => U9F55.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U8F56 LosslessMul(U32F32 other) => U8F56.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U7F57 LosslessMul(U31F33 other) => U7F57.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U6F58 LosslessMul(U30F34 other) => U6F58.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U5F59 LosslessMul(U29F35 other) => U5F59.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U4F60 LosslessMul(U28F36 other) => U4F60.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U3F61 LosslessMul(U27F37 other) => U3F61.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 LosslessMul(U26F38 other) => U2F62.FromBits(bits * other.Bits);

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(U40F24 x) => (int)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(U40F24 x) => (uint)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(U40F24 x) => (long)(x.bits / oneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(U40F24 x) => x.bits / oneRepr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(U40F24 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(U40F24 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(U40F24 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(U40F24 x) => I31F1.FromBits((int)(x.Bits / (1UL << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(U40F24 x) => I30F2.FromBits((int)(x.Bits / (1UL << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(U40F24 x) => I29F3.FromBits((int)(x.Bits / (1UL << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(U40F24 x) => I28F4.FromBits((int)(x.Bits / (1UL << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(U40F24 x) => I27F5.FromBits((int)(x.Bits / (1UL << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(U40F24 x) => I26F6.FromBits((int)(x.Bits / (1UL << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(U40F24 x) => I25F7.FromBits((int)(x.Bits / (1UL << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(U40F24 x) => I24F8.FromBits((int)(x.Bits / (1UL << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(U40F24 x) => I23F9.FromBits((int)(x.Bits / (1UL << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(U40F24 x) => I22F10.FromBits((int)(x.Bits / (1UL << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(U40F24 x) => I21F11.FromBits((int)(x.Bits / (1UL << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(U40F24 x) => I20F12.FromBits((int)(x.Bits / (1UL << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(U40F24 x) => I19F13.FromBits((int)(x.Bits / (1UL << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(U40F24 x) => I18F14.FromBits((int)(x.Bits / (1UL << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(U40F24 x) => I17F15.FromBits((int)(x.Bits / (1UL << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(U40F24 x) => I16F16.FromBits((int)(x.Bits / (1UL << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(U40F24 x) => I15F17.FromBits((int)(x.Bits / (1UL << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(U40F24 x) => I14F18.FromBits((int)(x.Bits / (1UL << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(U40F24 x) => I13F19.FromBits((int)(x.Bits / (1UL << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(U40F24 x) => I12F20.FromBits((int)(x.Bits / (1UL << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(U40F24 x) => I11F21.FromBits((int)(x.Bits / (1UL << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(U40F24 x) => I10F22.FromBits((int)(x.Bits / (1UL << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(U40F24 x) => I9F23.FromBits((int)(x.Bits / (1UL << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(U40F24 x) => I7F25.FromBits((int)x.Bits * (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(U40F24 x) => I6F26.FromBits((int)x.Bits * (1 << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(U40F24 x) => I5F27.FromBits((int)x.Bits * (1 << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(U40F24 x) => I4F28.FromBits((int)x.Bits * (1 << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(U40F24 x) => I3F29.FromBits((int)x.Bits * (1 << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(U40F24 x) => I2F30.FromBits((int)x.Bits * (1 << 6));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U31F1(U40F24 x) => U31F1.FromBits((uint)(x.Bits / (1UL << 23)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U30F2(U40F24 x) => U30F2.FromBits((uint)(x.Bits / (1UL << 22)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U29F3(U40F24 x) => U29F3.FromBits((uint)(x.Bits / (1UL << 21)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U28F4(U40F24 x) => U28F4.FromBits((uint)(x.Bits / (1UL << 20)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U27F5(U40F24 x) => U27F5.FromBits((uint)(x.Bits / (1UL << 19)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U26F6(U40F24 x) => U26F6.FromBits((uint)(x.Bits / (1UL << 18)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U25F7(U40F24 x) => U25F7.FromBits((uint)(x.Bits / (1UL << 17)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U24F8(U40F24 x) => U24F8.FromBits((uint)(x.Bits / (1UL << 16)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U23F9(U40F24 x) => U23F9.FromBits((uint)(x.Bits / (1UL << 15)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U22F10(U40F24 x) => U22F10.FromBits((uint)(x.Bits / (1UL << 14)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U21F11(U40F24 x) => U21F11.FromBits((uint)(x.Bits / (1UL << 13)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U20F12(U40F24 x) => U20F12.FromBits((uint)(x.Bits / (1UL << 12)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U19F13(U40F24 x) => U19F13.FromBits((uint)(x.Bits / (1UL << 11)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(U40F24 x) => U18F14.FromBits((uint)(x.Bits / (1UL << 10)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(U40F24 x) => U17F15.FromBits((uint)(x.Bits / (1UL << 9)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U16F16(U40F24 x) => U16F16.FromBits((uint)(x.Bits / (1UL << 8)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U15F17(U40F24 x) => U15F17.FromBits((uint)(x.Bits / (1UL << 7)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U14F18(U40F24 x) => U14F18.FromBits((uint)(x.Bits / (1UL << 6)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U13F19(U40F24 x) => U13F19.FromBits((uint)(x.Bits / (1UL << 5)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U12F20(U40F24 x) => U12F20.FromBits((uint)(x.Bits / (1UL << 4)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U11F21(U40F24 x) => U11F21.FromBits((uint)(x.Bits / (1UL << 3)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U10F22(U40F24 x) => U10F22.FromBits((uint)(x.Bits / (1UL << 2)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U9F23(U40F24 x) => U9F23.FromBits((uint)(x.Bits / (1UL << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U7F25(U40F24 x) => U7F25.FromBits((uint)x.Bits * (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F26(U40F24 x) => U6F26.FromBits((uint)x.Bits * (1U << 2));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U5F27(U40F24 x) => U5F27.FromBits((uint)x.Bits * (1U << 3));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U4F28(U40F24 x) => U4F28.FromBits((uint)x.Bits * (1U << 4));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(U40F24 x) => U3F29.FromBits((uint)x.Bits * (1U << 5));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(U40F24 x) => U2F30.FromBits((uint)x.Bits * (1U << 6));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is U40F24 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<U40F24>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(U40F24 rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}