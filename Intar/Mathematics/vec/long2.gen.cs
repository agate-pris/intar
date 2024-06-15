using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct long2 : IEquatable<long2>, IFormattable {
        // Fields
        // ---------------------------------------

        public long x;
        public long y;

        // Constants
        // ---------------------------------------

        public static readonly long2 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long2(long x, long y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long2(long2 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 operator +(long2 a, long2 b) => new long2(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 operator -(long2 a, long2 b) => new long2(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 operator *(long2 a, long2 b) => new long2(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 operator *(long2 a, long b) => new long2(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 operator *(long a, long2 b) => new long2(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 operator /(long2 a, long2 b) => new long2(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 operator /(long2 a, long b) => new long2(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 operator /(long a, long2 b) => new long2(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly long2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(x, x); }
        public readonly long2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(x, y); }
        public readonly long2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(y, x); }
        public readonly long2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long2(y, y); }
        public readonly long3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, x, x); }
        public readonly long3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, x, y); }
        public readonly long3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, y, x); }
        public readonly long3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(x, y, y); }
        public readonly long3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, x, x); }
        public readonly long3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, x, y); }
        public readonly long3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, y, x); }
        public readonly long3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long3(y, y, y); }
        public readonly long4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, x, x); }
        public readonly long4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, x, y); }
        public readonly long4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, y, x); }
        public readonly long4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, x, y, y); }
        public readonly long4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, x, x); }
        public readonly long4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, x, y); }
        public readonly long4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, y, x); }
        public readonly long4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(x, y, y, y); }
        public readonly long4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, x, x); }
        public readonly long4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, x, y); }
        public readonly long4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, y, x); }
        public readonly long4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, x, y, y); }
        public readonly long4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, x, x); }
        public readonly long4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, x, y); }
        public readonly long4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, y, x); }
        public readonly long4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new long4(y, y, y, y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(long2 lhs, long2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(long2 lhs, long2 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is long2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"long2({x}, {y})";

        // IEquatable<long2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(long2 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"long2({x}, {y})";
        }
    }

    public static partial class math {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 long2(long x, long y) => new long2(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 long2(long2 xy) => new long2(xy);
    }
}
