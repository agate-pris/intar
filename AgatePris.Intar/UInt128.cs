using System.Runtime.CompilerServices;

#if NET7_0_OR_GREATER

using System;

#endif // NET7_0_OR_GREATER

namespace AgatePris.Intar {
    /// <summary>
    /// <c>System.UInt128</c> を模した構造体。
    /// ベクトルの 2 乗の内部表現に使用。
    /// 比較演算、平方根以外は真面目に実装しない。
    /// </summary>
#if NET7_0_OR_GREATER
    [Obsolete("This struct is obsolete. Use System.UInt128 instead.",
#if NET8_0_OR_GREATER
        true
#else // NET8_0_OR_GREATER
        false
#endif // NET8_0_OR_GREATER
    )]
#endif // NET7_0_OR_GREATER
    readonly struct UInt128 {

#if BIGENDIAN

        readonly ulong upper;
        readonly ulong lower;

#else

        readonly ulong lower;
        readonly ulong upper;

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt128(ulong upper, ulong lower) {
            this.lower = lower;
            this.upper = upper;
        }

        //
        // Object
        //

        public override bool Equals(object obj) => obj is UInt128 o && Equals(o);
        public override int GetHashCode() => HashCode.Combine(lower, upper);

        //
        // IEquatable<UInt128>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(UInt128 other) => this == other;

        //
        // IComparisonOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <(UInt128 left, UInt128 right) {
            var cmp = left.upper.CompareTo(right.upper);
            return (cmp < 0) || ((cmp == 0) && (left.lower < right.lower));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <=(UInt128 left, UInt128 right) {
            var cmp = left.upper.CompareTo(right.upper);
            return (cmp < 0) || ((cmp == 0) && (left.lower <= right.lower));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >(UInt128 left, UInt128 right) {
            var cmp = left.upper.CompareTo(right.upper);
            return (cmp > 0) || ((cmp == 0) && (left.lower > right.lower));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >=(UInt128 left, UInt128 right) {
            var cmp = left.upper.CompareTo(right.upper);
            return (cmp > 0) || ((cmp == 0) && (left.lower >= right.lower));
        }

        //
        // IEqualityOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(UInt128 left, UInt128 right) => (left.lower == right.lower) && (left.upper == right.upper);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(UInt128 left, UInt128 right) => (left.lower != right.lower) || (left.upper != right.upper);

        //
        // INumberBase
        //

        public static UInt128 One => new UInt128(0, 1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative(UInt128 _) => false;

        //
        // ISubtractionOperators
        //

        public static UInt128 operator -(UInt128 left, UInt128 right) {
            var borrow = Overflowing.OverflowingSub(left.lower, right.lower, out var lower);
            var upper = left.upper - right.upper - (borrow ? 1UL : 0UL);
            return new UInt128(upper, lower);
        }
    }
} // namespace AgatePris.Intar
