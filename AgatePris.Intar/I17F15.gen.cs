using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct I17F15 : IEquatable<I17F15>, IFormattable {
        // Consts
        // ------

        public const int IntNbits = 17;
        public const int FracNbits = 15;

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
        I17F15(int bits) {
            Bits = bits;
        }

        // Static methods
        // --------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 FromBits(int bits) => new I17F15(bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 FromNum(int num) => FromBits(num * OneRepr);

        // Static Properties
        // -----------------

        public static I17F15 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(0);
        }
        public static I17F15 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromNum(1);
        }
        public static I17F15 MinValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(int.MinValue);
        }
        public static I17F15 MaxValue {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => FromBits(int.MaxValue);
        }

        // Arithmetic Operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 operator +(I17F15 left, I17F15 right) {
            return FromBits(left.Bits + right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 operator -(I17F15 left, I17F15 right) {
            return FromBits(left.Bits - right.Bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 operator *(I17F15 left, I17F15 right) {
            long l = left.Bits;
            return FromBits((int)(l * right.Bits / OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 operator /(I17F15 left, I17F15 right) {
            long l = left.Bits;
            return FromBits((int)(l * OneRepr / right.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 operator +(I17F15 x) => FromBits(+x.Bits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15 operator -(I17F15 x) => FromBits(-x.Bits);

        // Comparison operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I17F15 lhs, I17F15 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I17F15 lhs, I17F15 rhs) => !(lhs == rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <(I17F15 left, I17F15 right) => left.Bits < right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >(I17F15 left, I17F15 right) => left.Bits > right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator <=(I17F15 left, I17F15 right) => left.Bits <= right.Bits;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator >=(I17F15 left, I17F15 right) => left.Bits >= right.Bits;

        // Conversion operators
        // --------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator int(I17F15 x) => x.Bits / OneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator uint(I17F15 x) => (uint)(x.Bits / OneRepr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator long(I17F15 x) => x.Bits / OneRepr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator ulong(I17F15 x) => (ulong)(x.Bits / OneRepr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(I17F15 x) {
            const float k = 1.0f / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(I17F15 x) {
            const double k = 1.0 / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator decimal(I17F15 x) {
            const decimal k = 1.0M / OneRepr;
            return k * x.Bits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I18F14(I17F15 x) => I18F14.FromBits(x.Bits / (1 << 1));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I3F29(I17F15 x) => I3F29.FromBits(x.Bits * (1 << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F30(I17F15 x) => I2F30.FromBits(x.Bits * (1 << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I36F28(I17F15 x) => I36F28.FromBits(x.Bits * (1L << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static implicit operator I33F31(I17F15 x) => I33F31.FromBits(x.Bits * (1L << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I6F58(I17F15 x) => I6F58.FromBits(x.Bits * (1L << 43));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator I2F62(I17F15 x) => I2F62.FromBits(x.Bits * (1L << 47));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U18F14(I17F15 x) => U18F14.FromBits((uint)(x.Bits / (1 << 1)));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U17F15(I17F15 x) => U17F15.FromBits((uint)x.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U3F29(I17F15 x) => U3F29.FromBits((uint)x.Bits * (1U << 14));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F30(I17F15 x) => U2F30.FromBits((uint)x.Bits * (1U << 15));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U36F28(I17F15 x) => U36F28.FromBits((ulong)x.Bits * (1UL << 13));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U33F31(I17F15 x) => U33F31.FromBits((ulong)x.Bits * (1UL << 16));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U6F58(I17F15 x) => U6F58.FromBits((ulong)x.Bits * (1UL << 43));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static explicit operator U2F62(I17F15 x) => U2F62.FromBits((ulong)x.Bits * (1UL << 47));

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is I17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Bits.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ((double)this).ToString((IFormatProvider)null);

        // IEquatable<I17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(I17F15 other) => Bits == other.Bits;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return ((double)this).ToString(format, formatProvider);
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 Min(I17F15 other) => FromBits(Math.Min(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 Max(I17F15 other) => FromBits(Math.Max(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 Abs() => FromBits(Math.Abs(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15 Clamp(
            I17F15 min, I17F15 max
        ) => FromBits(Mathi.Clamp(Bits, min.Bits, max.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 Half() => FromBits(Mathi.Half(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 Twice() => FromBits(Mathi.Twice(Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 WrappingAdd(I17F15 other) => FromBits(Overflowing.WrappingAdd(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 WrappingSub(I17F15 other) => FromBits(Overflowing.WrappingSub(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 WrappingMul(I17F15 other) => FromBits(Overflowing.WrappingMul(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 WrappingAddUnsigned(U17F15 other) => FromBits(Overflowing.WrappingAddUnsigned(Bits, other.Bits));
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 WrappingSubUnsigned(U17F15 other) => FromBits(Overflowing.WrappingSubUnsigned(Bits, other.Bits));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 UnsignedAbs() {
            return U17F15.FromBits(Overflowing.UnsignedAbs(Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool OverflowingAdd(I17F15 other, out I17F15 result) {
            var b = Overflowing.OverflowingAdd(Bits, other.Bits, out var bits);
            result = FromBits(bits);
            return b;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15? CheckedAdd(I17F15 other) {
            I17F15? @null = null;
            return OverflowingAdd(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15 SaturatingAdd(I17F15 other) {
            return CheckedAdd(other) ?? ((Bits < 0) && (other.Bits < 0)
                ? MinValue
                : MaxValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool OverflowingMul(I17F15 other, out I17F15 result) {
            var bits = ((long)Bits) * other.Bits / OneRepr;
            result = FromBits(unchecked((int)bits));
            return bits < int.MinValue || bits > int.MaxValue;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15? CheckedMul(I17F15 other) {
            I17F15? @null = null;
            return OverflowingMul(other, out var result) ? @null : result;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15 SaturatingMul(I17F15 other) {
            return CheckedMul(other) ?? (((Bits < 0) == (other.Bits < 0))
                ? MaxValue
                : MinValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I17F15 LosslessMul(int other) => FromBits(Bits * other);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I3F29 LosslessMul(I18F14 other) => I3F29.FromBits(Bits * other.Bits);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public I2F30 LosslessMul(I17F15 other) => I2F30.FromBits(Bits * other.Bits);

        /// <summary>
        /// 4 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 SinP4() => I2F30.FromBits(Mathi.SinP4(Bits));

        /// <summary>
        /// 5 次の多項式で正弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>正弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 SinP5() => I2F30.FromBits(Mathi.SinP5(Bits));

        /// <summary>
        /// 4 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 CosP4() => I2F30.FromBits(Mathi.CosP4(Bits));

        /// <summary>
        /// 5 次の多項式で余弦比を近似する。
        /// </summary>
        /// <param name="x">直角に対する角度の比</param>
        /// <returns>余弦比</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 CosP5() => I2F30.FromBits(Mathi.CosP5(Bits));

        // ベクトル型との演算
        // ------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 SaturatingMul(Vector2I17F15 other) => other.SaturatingMul(this);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 SaturatingMul(Vector3I17F15 other) => other.SaturatingMul(this);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 SaturatingMul(Vector4I17F15 other) => other.SaturatingMul(this);

    }
} // namespace AgatePris.Intar
