using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct I18F14 : IEquatable<I18F14>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 18;
        public const int FracNbits = 14;

        const int OneRepr = 1 << FracNbits;

        // Fields
        // ------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public int Bits;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        I18F14(int bits) {
            Bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I18F14 FromBits(int bits) => new I18F14(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I18F14 FromNum(int num) => FromBits(num * OneRepr);

        // Static Properties
        // -----------------

        public static I18F14 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(0);
        }
        public static I18F14 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(1);
        }
        public static I18F14 MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(int.MinValue);
        }
        public static I18F14 MaxValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(int.MaxValue);
        }

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I18F14 operator +(I18F14 left, I18F14 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I18F14 operator -(I18F14 left, I18F14 right) {
            return FromBits(left.Bits - right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I18F14 operator *(I18F14 left, I18F14 right) {
            long l = left.Bits;
            return FromBits((int)(l * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I18F14 operator /(I18F14 left, I18F14 right) {
            long l = left.Bits;
            return FromBits((int)(l * OneRepr / right.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I18F14 operator +(I18F14 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I18F14 operator -(I18F14 x) => FromBits(-x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I18F14 lhs, I18F14 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I18F14 lhs, I18F14 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I18F14 left, I18F14 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I18F14 left, I18F14 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I18F14 left, I18F14 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I18F14 left, I18F14 right) => left.Bits >= right.Bits;

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(I18F14 x) => x.Bits / OneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(I18F14 x) => (uint)(x.Bits / OneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(I18F14 x) => x.Bits / OneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(I18F14 x) => (ulong)(x.Bits / OneRepr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I18F14 x) {
            const float k = 1.0f / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I18F14 x) {
            const double k = 1.0 / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I18F14 x) {
            const decimal k = 1.0M / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I17F15(I18F14 x) => I17F15.FromBits(x.Bits * (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(I18F14 x) => I3F29.FromBits(x.Bits * (1 << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(I18F14 x) => I2F30.FromBits(x.Bits * (1 << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I36F28(I18F14 x) => I36F28.FromBits(x.Bits * (1L << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I33F31(I18F14 x) => I33F31.FromBits(x.Bits * (1L << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F58(I18F14 x) => I6F58.FromBits(x.Bits * (1L << 44));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F62(I18F14 x) => I2F62.FromBits(x.Bits * (1L << 48));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(I18F14 x) => U18F14.FromBits((uint)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(I18F14 x) => U17F15.FromBits((uint)x.Bits * (1U << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(I18F14 x) => U3F29.FromBits((uint)x.Bits * (1U << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(I18F14 x) => U2F30.FromBits((uint)x.Bits * (1U << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U36F28(I18F14 x) => U36F28.FromBits((ulong)x.Bits * (1UL << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U33F31(I18F14 x) => U33F31.FromBits((ulong)x.Bits * (1UL << 17));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F58(I18F14 x) => U6F58.FromBits((ulong)x.Bits * (1UL << 44));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F62(I18F14 x) => U2F62.FromBits((ulong)x.Bits * (1UL << 48));

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is I18F14 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<I18F14>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(I18F14 other) => Bits == other.Bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F14 Min(I18F14 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F14 Max(I18F14 other) => FromBits(Math.Max(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F14 Abs() => FromBits(Math.Abs(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I18F14 Clamp(
            I18F14 min, I18F14 max
        ) => FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F14 Half() => FromBits(Mathi.Half(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F14 Twice() => FromBits(Mathi.Twice(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F14 WrappingAdd(I18F14 other) => FromBits(Overflowing.WrappingAdd(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F14 WrappingSub(I18F14 other) => FromBits(Overflowing.WrappingSub(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F14 WrappingMul(I18F14 other) => FromBits(Overflowing.WrappingMul(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F14 WrappingAddUnsigned(U18F14 other) => FromBits(Overflowing.WrappingAddUnsigned(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F14 WrappingSubUnsigned(U18F14 other) => FromBits(Overflowing.WrappingSubUnsigned(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U18F14 UnsignedAbs() {
            return U18F14.FromBits(Overflowing.UnsignedAbs(Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool OverflowingAdd(I18F14 other, out I18F14 result) {
            var b = Overflowing.OverflowingAdd(Bits, other.Bits, out var bits);
            result = FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I18F14? CheckedAdd(I18F14 other) {
            I18F14? @null = null;
            return OverflowingAdd(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I18F14 SaturatingAdd(I18F14 other) {
            return CheckedAdd(other) ?? ((Bits < 0) && (other.Bits < 0)
                ? MinValue
                : MaxValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool OverflowingMul(I18F14 other, out I18F14 result) {
            var bits = ((long)Bits) * other.Bits / OneRepr;
            result = FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I18F14? CheckedMul(I18F14 other) {
            I18F14? @null = null;
            return OverflowingMul(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I18F14 SaturatingMul(I18F14 other) {
            return CheckedMul(other) ?? (((Bits < 0) == (other.Bits < 0))
                ? MaxValue
                : MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I18F14 LosslessMul(int other) => FromBits(Bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I3F29 LosslessMul(I17F15 other) => I3F29.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I36F28 WideningMul(I18F14 other) => I36F28.FromBits((long)Bits * other.Bits);

    }
} // namespace AgatePris.Intar
