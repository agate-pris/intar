using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I17F15 : IEquatable<Vector2I17F15>, IFormattable {
        // Fields
        // ---------------------------------------

        public I17F15 x;
        public I17F15 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I17F15 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15(I17F15 x, I17F15 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15(Vector2I17F15 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator +(Vector2I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator -(Vector2I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator *(Vector2I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator *(Vector2I17F15 a, I17F15 b) => new Vector2I17F15(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator *(I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator /(Vector2I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator /(Vector2I17F15 a, I17F15 b) => new Vector2I17F15(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator /(I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I17F15 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(x, x); }
        public readonly Vector2I17F15 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(x, y); }
        public readonly Vector2I17F15 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(y, x); }
        public readonly Vector2I17F15 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(y, y); }
        public readonly Vector3I17F15 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(x, x, x); }
        public readonly Vector3I17F15 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(x, x, y); }
        public readonly Vector3I17F15 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(x, y, x); }
        public readonly Vector3I17F15 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(x, y, y); }
        public readonly Vector3I17F15 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(y, x, x); }
        public readonly Vector3I17F15 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(y, x, y); }
        public readonly Vector3I17F15 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(y, y, x); }
        public readonly Vector3I17F15 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(y, y, y); }
        public readonly Vector4I17F15 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(x, x, x, x); }
        public readonly Vector4I17F15 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(x, x, x, y); }
        public readonly Vector4I17F15 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(x, x, y, x); }
        public readonly Vector4I17F15 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(x, x, y, y); }
        public readonly Vector4I17F15 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(x, y, x, x); }
        public readonly Vector4I17F15 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(x, y, x, y); }
        public readonly Vector4I17F15 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(x, y, y, x); }
        public readonly Vector4I17F15 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(x, y, y, y); }
        public readonly Vector4I17F15 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(y, x, x, x); }
        public readonly Vector4I17F15 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(y, x, x, y); }
        public readonly Vector4I17F15 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(y, x, y, x); }
        public readonly Vector4I17F15 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(y, x, y, y); }
        public readonly Vector4I17F15 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(y, y, x, x); }
        public readonly Vector4I17F15 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(y, y, x, y); }
        public readonly Vector4I17F15 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(y, y, y, x); }
        public readonly Vector4I17F15 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I17F15 lhs, Vector2I17F15 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I17F15 lhs, Vector2I17F15 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I17F15({x}, {y})";

        // IEquatable<Vector2I17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I17F15 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I17F15({x}, {y})";
        }
    }
}
