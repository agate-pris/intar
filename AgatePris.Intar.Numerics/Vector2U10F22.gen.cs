using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct U10F22_2 : IEquatable<U10F22_2>, IFormattable {
        // Fields
        // ---------------------------------------

        public U10F22 x;
        public U10F22 y;

        // Constants
        // ---------------------------------------

        public static readonly U10F22_2 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U10F22_2(U10F22 x, U10F22 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U10F22_2(U10F22_2 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U10F22_2 operator +(U10F22_2 a, U10F22_2 b) => new U10F22_2(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U10F22_2 operator -(U10F22_2 a, U10F22_2 b) => new U10F22_2(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U10F22_2 operator *(U10F22_2 a, U10F22_2 b) => new U10F22_2(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U10F22_2 operator *(U10F22_2 a, U10F22 b) => new U10F22_2(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U10F22_2 operator *(U10F22 a, U10F22_2 b) => new U10F22_2(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U10F22_2 operator /(U10F22_2 a, U10F22_2 b) => new U10F22_2(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U10F22_2 operator /(U10F22_2 a, U10F22 b) => new U10F22_2(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U10F22_2 operator /(U10F22 a, U10F22_2 b) => new U10F22_2(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly U10F22_2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_2(x, x); }
        public readonly U10F22_2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_2(x, y); }
        public readonly U10F22_2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_2(y, x); }
        public readonly U10F22_2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_2(y, y); }
        public readonly U10F22_3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_3(x, x, x); }
        public readonly U10F22_3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_3(x, x, y); }
        public readonly U10F22_3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_3(x, y, x); }
        public readonly U10F22_3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_3(x, y, y); }
        public readonly U10F22_3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_3(y, x, x); }
        public readonly U10F22_3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_3(y, x, y); }
        public readonly U10F22_3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_3(y, y, x); }
        public readonly U10F22_3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_3(y, y, y); }
        public readonly U10F22_4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_4(x, x, x, x); }
        public readonly U10F22_4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_4(x, x, x, y); }
        public readonly U10F22_4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_4(x, x, y, x); }
        public readonly U10F22_4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_4(x, x, y, y); }
        public readonly U10F22_4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_4(x, y, x, x); }
        public readonly U10F22_4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_4(x, y, x, y); }
        public readonly U10F22_4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_4(x, y, y, x); }
        public readonly U10F22_4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_4(x, y, y, y); }
        public readonly U10F22_4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_4(y, x, x, x); }
        public readonly U10F22_4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_4(y, x, x, y); }
        public readonly U10F22_4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_4(y, x, y, x); }
        public readonly U10F22_4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_4(y, x, y, y); }
        public readonly U10F22_4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_4(y, y, x, x); }
        public readonly U10F22_4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_4(y, y, x, y); }
        public readonly U10F22_4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_4(y, y, y, x); }
        public readonly U10F22_4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U10F22_4(y, y, y, y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U10F22_2 lhs, U10F22_2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U10F22_2 lhs, U10F22_2 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is U10F22_2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"U10F22_2({x}, {y})";

        // IEquatable<U10F22_2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(U10F22_2 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"U10F22_2({x}, {y})";
        }
    }

    public static partial class math {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U10F22_2 U10F22_2(U10F22 x, U10F22 y) => new U10F22_2(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U10F22_2 U10F22_2(U10F22_2 xy) => new U10F22_2(xy);
    }
}
