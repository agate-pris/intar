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

    public struct U34F30 : IEquatable<U34F30>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 34;
        public const int FracNbits = 30;

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

        public static readonly U34F30 Zero = FromNum(0);
        public static readonly U34F30 One = FromNum(1);

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        U34F30(ulong bits) {
            this.bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 FromBits(ulong bits) => new U34F30(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 FromNum(ulong num) => FromBits(num * oneRepr);

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 operator +(U34F30 left, U34F30 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 operator -(U34F30 left, U34F30 right) {
            return FromBits(left.Bits - right.Bits);
        }

        // 128 ビット整数型は .NET 7 以降にしか無いので,
        // 乗算, 除算演算子は .NET 7 以降でのみ使用可能.

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 operator *(U34F30 left, U34F30 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * right.Bits / oneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U34F30 operator /(U34F30 left, U34F30 right) {
            UInt128 l = left.Bits;
            return FromBits((ulong)(l * oneRepr / right.Bits));
        }

#endif

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U34F30 lhs, U34F30 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U34F30 lhs, U34F30 rhs) => !(lhs == rhs);

        // Methods
        // -------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U33F31 LosslessMul(U63F1 other) => U33F31.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U32F32 LosslessMul(U62F2 other) => U32F32.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U31F33 LosslessMul(U61F3 other) => U31F33.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U30F34 LosslessMul(U60F4 other) => U30F34.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U29F35 LosslessMul(U59F5 other) => U29F35.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U28F36 LosslessMul(U58F6 other) => U28F36.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U27F37 LosslessMul(U57F7 other) => U27F37.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U26F38 LosslessMul(U56F8 other) => U26F38.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U25F39 LosslessMul(U55F9 other) => U25F39.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U24F40 LosslessMul(U54F10 other) => U24F40.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U23F41 LosslessMul(U53F11 other) => U23F41.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U22F42 LosslessMul(U52F12 other) => U22F42.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U21F43 LosslessMul(U51F13 other) => U21F43.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U20F44 LosslessMul(U50F14 other) => U20F44.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U19F45 LosslessMul(U49F15 other) => U19F45.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U18F46 LosslessMul(U48F16 other) => U18F46.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U17F47 LosslessMul(U47F17 other) => U17F47.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U16F48 LosslessMul(U46F18 other) => U16F48.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U15F49 LosslessMul(U45F19 other) => U15F49.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U14F50 LosslessMul(U44F20 other) => U14F50.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U13F51 LosslessMul(U43F21 other) => U13F51.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U12F52 LosslessMul(U42F22 other) => U12F52.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U11F53 LosslessMul(U41F23 other) => U11F53.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U10F54 LosslessMul(U40F24 other) => U10F54.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U9F55 LosslessMul(U39F25 other) => U9F55.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U8F56 LosslessMul(U38F26 other) => U8F56.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U7F57 LosslessMul(U37F27 other) => U7F57.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U6F58 LosslessMul(U36F28 other) => U6F58.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U5F59 LosslessMul(U35F29 other) => U5F59.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U4F60 LosslessMul(U34F30 other) => U4F60.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U3F61 LosslessMul(U33F31 other) => U3F61.FromBits(bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public U2F62 LosslessMul(U32F32 other) => U2F62.FromBits(bits * other.Bits);

        // Explicit conversion operators
        // -----------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong(U34F30 x) {
            return x.bits / oneRepr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(U34F30 x) {
            const float k = 1.0f / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(U34F30 x) {
            const double k = 1.0 / oneRepr;
            return k * x.bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(U34F30 x) {
            const decimal k = 1.0M / oneRepr;
            return k * x.bits;
        }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is U34F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => ((double)this).ToString();

        // IEquatable<U34F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(U34F30 rhs) => bits == rhs.bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }
    }
}
