using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct I25F7_2 : IEquatable<I25F7_2>, IFormattable {
        // Fields
        // ---------------------------------------

        public I25F7 x;
        public I25F7 y;

        // Constants
        // ---------------------------------------

        public static readonly I25F7_2 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I25F7_2(I25F7 x, I25F7 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I25F7_2(I25F7_2 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I25F7_2 operator +(I25F7_2 a, I25F7_2 b) => new I25F7_2(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I25F7_2 operator -(I25F7_2 a, I25F7_2 b) => new I25F7_2(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I25F7_2 operator *(I25F7_2 a, I25F7_2 b) => new I25F7_2(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I25F7_2 operator *(I25F7_2 a, I25F7 b) => new I25F7_2(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I25F7_2 operator *(I25F7 a, I25F7_2 b) => new I25F7_2(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I25F7_2 operator /(I25F7_2 a, I25F7_2 b) => new I25F7_2(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I25F7_2 operator /(I25F7_2 a, I25F7 b) => new I25F7_2(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I25F7_2 operator /(I25F7 a, I25F7_2 b) => new I25F7_2(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly I25F7_2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_2(x, x); }
        public readonly I25F7_2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_2(x, y); }
        public readonly I25F7_2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_2(y, x); }
        public readonly I25F7_2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_2(y, y); }
        public readonly I25F7_3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_3(x, x, x); }
        public readonly I25F7_3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_3(x, x, y); }
        public readonly I25F7_3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_3(x, y, x); }
        public readonly I25F7_3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_3(x, y, y); }
        public readonly I25F7_3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_3(y, x, x); }
        public readonly I25F7_3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_3(y, x, y); }
        public readonly I25F7_3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_3(y, y, x); }
        public readonly I25F7_3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_3(y, y, y); }
        public readonly I25F7_4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_4(x, x, x, x); }
        public readonly I25F7_4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_4(x, x, x, y); }
        public readonly I25F7_4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_4(x, x, y, x); }
        public readonly I25F7_4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_4(x, x, y, y); }
        public readonly I25F7_4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_4(x, y, x, x); }
        public readonly I25F7_4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_4(x, y, x, y); }
        public readonly I25F7_4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_4(x, y, y, x); }
        public readonly I25F7_4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_4(x, y, y, y); }
        public readonly I25F7_4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_4(y, x, x, x); }
        public readonly I25F7_4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_4(y, x, x, y); }
        public readonly I25F7_4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_4(y, x, y, x); }
        public readonly I25F7_4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_4(y, x, y, y); }
        public readonly I25F7_4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_4(y, y, x, x); }
        public readonly I25F7_4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_4(y, y, x, y); }
        public readonly I25F7_4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_4(y, y, y, x); }
        public readonly I25F7_4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new I25F7_4(y, y, y, y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(I25F7_2 lhs, I25F7_2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(I25F7_2 lhs, I25F7_2 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is I25F7_2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"I25F7_2({x}, {y})";

        // IEquatable<I25F7_2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(I25F7_2 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"I25F7_2({x}, {y})";
        }
    }

    public static partial class math {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I25F7_2 I25F7_2(I25F7 x, I25F7 y) => new I25F7_2(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static I25F7_2 I25F7_2(I25F7_2 xy) => new I25F7_2(xy);
    }
}
