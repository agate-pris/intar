using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {

    /// <summary>
    /// <c>System.Int128</c> を模した構造体。
    /// ベクトルの 2 乗の内部表現に使用。
    /// 比較演算、平方根以外は真面目に実装しない。
    /// </summary>
#if NET7_0_OR_GREATER
    [Obsolete("This struct is obsolete. Use System.Int128 instead.",
#if NET8_0_OR_GREATER
        true
#else // NET8_0_OR_GREATER
        false
#endif // NET8_0_OR_GREATER
    )]
#endif // NET7_0_OR_GREATER
    readonly struct Int128 {

#if BIGENDIAN

        readonly ulong upper;
        readonly ulong lower;

#else

        readonly ulong lower;
        readonly ulong upper;

#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int128(ulong upper, ulong lower) {
            this.lower = lower;
            this.upper = upper;
        }

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Int128 o && Equals(o);
        public override int GetHashCode() => HashCode.Combine(lower, upper);

        //
        // IEquatable<Int128>
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Int128 other) => this == other;

        //
        // IComparisonOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <(Int128 left, Int128 right) {
            if (IsNegative(left) == IsNegative(right)) {
                var cmp = left.upper.CompareTo(right.upper);
                return (cmp < 0) || ((cmp == 0) && (left.lower < right.lower));
            } else {
                return IsNegative(left);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <=(Int128 left, Int128 right) {
            if (IsNegative(left) == IsNegative(right)) {
                var cmp = left.upper.CompareTo(right.upper);
                return (cmp < 0) || ((cmp == 0) && (left.lower <= right.lower));
            } else {
                return IsNegative(left);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >(Int128 left, Int128 right) {
            if (IsNegative(left) == IsNegative(right)) {
                var cmp = left.upper.CompareTo(right.upper);
                return (cmp > 0) || ((cmp == 0) && (left.lower > right.lower));
            } else {
                return IsNegative(right);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >=(Int128 left, Int128 right) {
            if (IsNegative(left) == IsNegative(right)) {
                var cmp = left.upper.CompareTo(right.upper);
                return (cmp > 0) || ((cmp == 0) && (left.lower >= right.lower));
            } else {
                return IsNegative(right);
            }
        }

        //
        // IEqualityOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator ==(Int128 left, Int128 right) => (left.lower == right.lower) && (left.upper == right.upper);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static bool operator !=(Int128 left, Int128 right) => (left.lower != right.lower) || (left.upper != right.upper);

        //
        // INumberBase
        //

        public static Int128 One => new Int128(0, 1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative(Int128 value) => unchecked((long)value.upper) < 0;

    }
} // namespace AgatePris.Intar
