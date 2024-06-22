using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct U4F28_2 : IEquatable<U4F28_2>, IFormattable {
        // Fields
        // ---------------------------------------

        public U4F28 x;
        public U4F28 y;

        // Constants
        // ---------------------------------------

        public static readonly U4F28_2 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F28_2(U4F28 x, U4F28 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F28_2(U4F28_2 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F28_2 operator +(U4F28_2 a, U4F28_2 b) => new U4F28_2(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F28_2 operator -(U4F28_2 a, U4F28_2 b) => new U4F28_2(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F28_2 operator *(U4F28_2 a, U4F28_2 b) => new U4F28_2(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F28_2 operator *(U4F28_2 a, U4F28 b) => new U4F28_2(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F28_2 operator *(U4F28 a, U4F28_2 b) => new U4F28_2(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F28_2 operator /(U4F28_2 a, U4F28_2 b) => new U4F28_2(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F28_2 operator /(U4F28_2 a, U4F28 b) => new U4F28_2(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F28_2 operator /(U4F28 a, U4F28_2 b) => new U4F28_2(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly U4F28_2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_2(x, x); }
        public readonly U4F28_2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_2(x, y); }
        public readonly U4F28_2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_2(y, x); }
        public readonly U4F28_2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_2(y, y); }
        public readonly U4F28_3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_3(x, x, x); }
        public readonly U4F28_3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_3(x, x, y); }
        public readonly U4F28_3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_3(x, y, x); }
        public readonly U4F28_3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_3(x, y, y); }
        public readonly U4F28_3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_3(y, x, x); }
        public readonly U4F28_3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_3(y, x, y); }
        public readonly U4F28_3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_3(y, y, x); }
        public readonly U4F28_3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_3(y, y, y); }
        public readonly U4F28_4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_4(x, x, x, x); }
        public readonly U4F28_4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_4(x, x, x, y); }
        public readonly U4F28_4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_4(x, x, y, x); }
        public readonly U4F28_4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_4(x, x, y, y); }
        public readonly U4F28_4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_4(x, y, x, x); }
        public readonly U4F28_4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_4(x, y, x, y); }
        public readonly U4F28_4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_4(x, y, y, x); }
        public readonly U4F28_4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_4(x, y, y, y); }
        public readonly U4F28_4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_4(y, x, x, x); }
        public readonly U4F28_4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_4(y, x, x, y); }
        public readonly U4F28_4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_4(y, x, y, x); }
        public readonly U4F28_4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_4(y, x, y, y); }
        public readonly U4F28_4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_4(y, y, x, x); }
        public readonly U4F28_4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_4(y, y, x, y); }
        public readonly U4F28_4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_4(y, y, y, x); }
        public readonly U4F28_4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new U4F28_4(y, y, y, y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(U4F28_2 lhs, U4F28_2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(U4F28_2 lhs, U4F28_2 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is U4F28_2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"U4F28_2({x}, {y})";

        // IEquatable<U4F28_2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(U4F28_2 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"U4F28_2({x}, {y})";
        }
    }

    public static partial class math {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F28_2 U4F28_2(U4F28 x, U4F28 y) => new U4F28_2(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static U4F28_2 U4F28_2(U4F28_2 xy) => new U4F28_2(xy);
    }
}
