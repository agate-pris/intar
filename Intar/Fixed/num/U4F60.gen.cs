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

    public struct U4F60 : IEquatable<U4F60>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 4;
        public const int FracNbits = 60;

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

        public static readonly U4F60 Zero = FromNum(0);
        public static readonly U4F60 One = FromNum(1);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        U4F60(ulong bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F60 FromBits(ulong bits) => new U4F60(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F60 FromNum(ulong num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F60 operator +(U4F60 left, U4F60 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F60 operator -(U4F60 left, U4F60 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F60 operator *(U4F60 left, U4F60 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F60 operator /(U4F60 left, U4F60 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * oneRepr / right.Bits));
        }

#endif

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U4F60 lhs, U4F60 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U4F60 lhs, U4F60 rhs) => !(lhs == rhs);

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U3F61 LosslessMul(U63F1 other) => U3F61.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 LosslessMul(U62F2 other) => U2F62.FromBits(bits * other.Bits);

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong(U4F60 x) {
            return x.bits / oneRepr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(U4F60 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(U4F60 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(U4F60 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(U4F60 x) => I3F29.FromBits((int)(x.Bits / (1UL << 31)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I4F28(U4F60 x) => I4F28.FromBits((int)(x.Bits / (1UL << 32)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I5F27(U4F60 x) => I5F27.FromBits((int)(x.Bits / (1UL << 33)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F26(U4F60 x) => I6F26.FromBits((int)(x.Bits / (1UL << 34)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I7F25(U4F60 x) => I7F25.FromBits((int)(x.Bits / (1UL << 35)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I8F24(U4F60 x) => I8F24.FromBits((int)(x.Bits / (1UL << 36)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I9F23(U4F60 x) => I9F23.FromBits((int)(x.Bits / (1UL << 37)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I10F22(U4F60 x) => I10F22.FromBits((int)(x.Bits / (1UL << 38)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I11F21(U4F60 x) => I11F21.FromBits((int)(x.Bits / (1UL << 39)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I12F20(U4F60 x) => I12F20.FromBits((int)(x.Bits / (1UL << 40)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I13F19(U4F60 x) => I13F19.FromBits((int)(x.Bits / (1UL << 41)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I14F18(U4F60 x) => I14F18.FromBits((int)(x.Bits / (1UL << 42)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I15F17(U4F60 x) => I15F17.FromBits((int)(x.Bits / (1UL << 43)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I16F16(U4F60 x) => I16F16.FromBits((int)(x.Bits / (1UL << 44)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(U4F60 x) => I17F15.FromBits((int)(x.Bits / (1UL << 45)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(U4F60 x) => I18F14.FromBits((int)(x.Bits / (1UL << 46)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I19F13(U4F60 x) => I19F13.FromBits((int)(x.Bits / (1UL << 47)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I20F12(U4F60 x) => I20F12.FromBits((int)(x.Bits / (1UL << 48)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I21F11(U4F60 x) => I21F11.FromBits((int)(x.Bits / (1UL << 49)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I22F10(U4F60 x) => I22F10.FromBits((int)(x.Bits / (1UL << 50)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I23F9(U4F60 x) => I23F9.FromBits((int)(x.Bits / (1UL << 51)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I24F8(U4F60 x) => I24F8.FromBits((int)(x.Bits / (1UL << 52)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I25F7(U4F60 x) => I25F7.FromBits((int)(x.Bits / (1UL << 53)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I26F6(U4F60 x) => I26F6.FromBits((int)(x.Bits / (1UL << 54)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I27F5(U4F60 x) => I27F5.FromBits((int)(x.Bits / (1UL << 55)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I28F4(U4F60 x) => I28F4.FromBits((int)(x.Bits / (1UL << 56)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I29F3(U4F60 x) => I29F3.FromBits((int)(x.Bits / (1UL << 57)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I30F2(U4F60 x) => I30F2.FromBits((int)(x.Bits / (1UL << 58)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I31F1(U4F60 x) => I31F1.FromBits((int)(x.Bits / (1UL << 59)));

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is U4F60 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<U4F60>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(U4F60 rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
