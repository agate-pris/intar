using AgatePris.Intar.Fixed;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct U5F27_2 : IEquatable<U5F27_2>, IFormattable {
        // Fields
        // ---------------------------------------

        public U5F27 x;
        public U5F27 y;

        // Constants
        // ---------------------------------------

        public static readonly U5F27_2 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U5F27_2(U5F27 x, U5F27 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U5F27_2(U5F27_2 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27_2 operator +(U5F27_2 a, U5F27_2 b) => new U5F27_2(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27_2 operator -(U5F27_2 a, U5F27_2 b) => new U5F27_2(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27_2 operator *(U5F27_2 a, U5F27_2 b) => new U5F27_2(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27_2 operator *(U5F27_2 a, U5F27 b) => new U5F27_2(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27_2 operator *(U5F27 a, U5F27_2 b) => new U5F27_2(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27_2 operator /(U5F27_2 a, U5F27_2 b) => new U5F27_2(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27_2 operator /(U5F27_2 a, U5F27 b) => new U5F27_2(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27_2 operator /(U5F27 a, U5F27_2 b) => new U5F27_2(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly U5F27_2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_2(x, x); }
        public readonly U5F27_2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_2(x, y); }
        public readonly U5F27_2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_2(y, x); }
        public readonly U5F27_2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_2(y, y); }
        public readonly U5F27_3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_3(x, x, x); }
        public readonly U5F27_3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_3(x, x, y); }
        public readonly U5F27_3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_3(x, y, x); }
        public readonly U5F27_3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_3(x, y, y); }
        public readonly U5F27_3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_3(y, x, x); }
        public readonly U5F27_3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_3(y, x, y); }
        public readonly U5F27_3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_3(y, y, x); }
        public readonly U5F27_3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_3(y, y, y); }
        public readonly U5F27_4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_4(x, x, x, x); }
        public readonly U5F27_4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_4(x, x, x, y); }
        public readonly U5F27_4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_4(x, x, y, x); }
        public readonly U5F27_4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_4(x, x, y, y); }
        public readonly U5F27_4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_4(x, y, x, x); }
        public readonly U5F27_4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_4(x, y, x, y); }
        public readonly U5F27_4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_4(x, y, y, x); }
        public readonly U5F27_4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_4(x, y, y, y); }
        public readonly U5F27_4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_4(y, x, x, x); }
        public readonly U5F27_4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_4(y, x, x, y); }
        public readonly U5F27_4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_4(y, x, y, x); }
        public readonly U5F27_4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_4(y, x, y, y); }
        public readonly U5F27_4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_4(y, y, x, x); }
        public readonly U5F27_4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_4(y, y, x, y); }
        public readonly U5F27_4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_4(y, y, y, x); }
        public readonly U5F27_4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U5F27_4(y, y, y, y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U5F27_2 lhs, U5F27_2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U5F27_2 lhs, U5F27_2 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is U5F27_2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"U5F27_2({x}, {y})";

        // IEquatable<U5F27_2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(U5F27_2 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"U5F27_2({x}, {y})";
        }
    }

    public static partial class math {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27_2 U5F27_2(U5F27 x, U5F27 y) => new U5F27_2(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U5F27_2 U5F27_2(U5F27_2 xy) => new U5F27_2(xy);
    }
}
