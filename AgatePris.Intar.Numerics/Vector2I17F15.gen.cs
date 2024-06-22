using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct I17F15_2 : IEquatable<I17F15_2>, IFormattable {
        // Fields
        // ---------------------------------------

        public I17F15 x;
        public I17F15 y;

        // Constants
        // ---------------------------------------

        public static readonly I17F15_2 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15_2(I17F15 x, I17F15 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15_2(I17F15_2 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15_2 operator +(I17F15_2 a, I17F15_2 b) => new I17F15_2(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15_2 operator -(I17F15_2 a, I17F15_2 b) => new I17F15_2(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15_2 operator *(I17F15_2 a, I17F15_2 b) => new I17F15_2(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15_2 operator *(I17F15_2 a, I17F15 b) => new I17F15_2(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15_2 operator *(I17F15 a, I17F15_2 b) => new I17F15_2(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15_2 operator /(I17F15_2 a, I17F15_2 b) => new I17F15_2(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15_2 operator /(I17F15_2 a, I17F15 b) => new I17F15_2(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15_2 operator /(I17F15 a, I17F15_2 b) => new I17F15_2(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly I17F15_2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_2(x, x); }
        public readonly I17F15_2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_2(x, y); }
        public readonly I17F15_2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_2(y, x); }
        public readonly I17F15_2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_2(y, y); }
        public readonly I17F15_3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_3(x, x, x); }
        public readonly I17F15_3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_3(x, x, y); }
        public readonly I17F15_3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_3(x, y, x); }
        public readonly I17F15_3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_3(x, y, y); }
        public readonly I17F15_3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_3(y, x, x); }
        public readonly I17F15_3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_3(y, x, y); }
        public readonly I17F15_3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_3(y, y, x); }
        public readonly I17F15_3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_3(y, y, y); }
        public readonly I17F15_4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_4(x, x, x, x); }
        public readonly I17F15_4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_4(x, x, x, y); }
        public readonly I17F15_4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_4(x, x, y, x); }
        public readonly I17F15_4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_4(x, x, y, y); }
        public readonly I17F15_4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_4(x, y, x, x); }
        public readonly I17F15_4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_4(x, y, x, y); }
        public readonly I17F15_4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_4(x, y, y, x); }
        public readonly I17F15_4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_4(x, y, y, y); }
        public readonly I17F15_4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_4(y, x, x, x); }
        public readonly I17F15_4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_4(y, x, x, y); }
        public readonly I17F15_4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_4(y, x, y, x); }
        public readonly I17F15_4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_4(y, x, y, y); }
        public readonly I17F15_4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_4(y, y, x, x); }
        public readonly I17F15_4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_4(y, y, x, y); }
        public readonly I17F15_4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_4(y, y, y, x); }
        public readonly I17F15_4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I17F15_4(y, y, y, y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I17F15_2 lhs, I17F15_2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I17F15_2 lhs, I17F15_2 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is I17F15_2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"I17F15_2({x}, {y})";

        // IEquatable<I17F15_2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(I17F15_2 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"I17F15_2({x}, {y})";
        }
    }

    public static partial class math {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15_2 I17F15_2(I17F15 x, I17F15 y) => new I17F15_2(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I17F15_2 I17F15_2(I17F15_2 xy) => new I17F15_2(xy);
    }
}
