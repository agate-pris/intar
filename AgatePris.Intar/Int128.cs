using System.Runtime.CompilerServices;

#if NET7_0_OR_GREATER

using System;

#endif // NET7_0_OR_GREATER

/// <summary>
/// <c>System.Int128</c> を模した構造体。
/// ベクトルの 2 乗の内部表現に使用。
/// 比較演算、平方根以外は真面目に実装しない。
/// </summary>
namespace AgatePris.Intar {
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

        public static bool IsNegative(Int128 value) => unchecked((long)value.upper) < 0;

        //
        // IComparisonOperators
        //

        public static bool operator <(Int128 left, Int128 right) {
            if (IsNegative(left) == IsNegative(right)) {
                return (left.upper < right.upper)
                    || ((left.upper == right.upper) && (left.lower < right.lower));
            } else {
                return IsNegative(left);
            }
        }

        public static bool operator <=(Int128 left, Int128 right) {
            if (IsNegative(left) == IsNegative(right)) {
                return (left.upper < right.upper)
                    || ((left.upper == right.upper) && (left.lower <= right.lower));
            } else {
                return IsNegative(left);
            }
        }

        public static bool operator >(Int128 left, Int128 right) {
            if (IsNegative(left) == IsNegative(right)) {
                return (left.upper > right.upper)
                    || ((left.upper == right.upper) && (left.lower > right.lower));
            } else {
                return IsNegative(right);
            }
        }

        public static bool operator >=(Int128 left, Int128 right) {
            if (IsNegative(left) == IsNegative(right)) {
                return (left.upper > right.upper)
                    || ((left.upper == right.upper) && (left.lower >= right.lower));
            } else {
                return IsNegative(right);
            }
        }
    }
} // namespace AgatePris.Intar
