using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I28F4 : IEquatable<Vector2I28F4>, IFormattable {
        // Fields
        // ---------------------------------------

        public I28F4 x;
        public I28F4 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I28F4 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4(I28F4 x, I28F4 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4(Vector2I28F4 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator +(Vector2I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator -(Vector2I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator *(Vector2I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator *(Vector2I28F4 a, I28F4 b) => new Vector2I28F4(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator *(I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator /(Vector2I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator /(Vector2I28F4 a, I28F4 b) => new Vector2I28F4(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator /(I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I28F4 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(x, x); }
        public readonly Vector2I28F4 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(x, y); }
        public readonly Vector2I28F4 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(y, x); }
        public readonly Vector2I28F4 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(y, y); }
        public readonly Vector3I28F4 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(x, x, x); }
        public readonly Vector3I28F4 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(x, x, y); }
        public readonly Vector3I28F4 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(x, y, x); }
        public readonly Vector3I28F4 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(x, y, y); }
        public readonly Vector3I28F4 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(y, x, x); }
        public readonly Vector3I28F4 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(y, x, y); }
        public readonly Vector3I28F4 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(y, y, x); }
        public readonly Vector3I28F4 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(y, y, y); }
        public readonly Vector4I28F4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(x, x, x, x); }
        public readonly Vector4I28F4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(x, x, x, y); }
        public readonly Vector4I28F4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(x, x, y, x); }
        public readonly Vector4I28F4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(x, x, y, y); }
        public readonly Vector4I28F4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(x, y, x, x); }
        public readonly Vector4I28F4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(x, y, x, y); }
        public readonly Vector4I28F4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(x, y, y, x); }
        public readonly Vector4I28F4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(x, y, y, y); }
        public readonly Vector4I28F4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(y, x, x, x); }
        public readonly Vector4I28F4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(y, x, x, y); }
        public readonly Vector4I28F4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(y, x, y, x); }
        public readonly Vector4I28F4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(y, x, y, y); }
        public readonly Vector4I28F4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(y, y, x, x); }
        public readonly Vector4I28F4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(y, y, x, y); }
        public readonly Vector4I28F4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(y, y, y, x); }
        public readonly Vector4I28F4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I28F4 lhs, Vector2I28F4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I28F4 lhs, Vector2I28F4 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I28F4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I28F4({x}, {y})";

        // IEquatable<Vector2I28F4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I28F4 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I28F4({x}, {y})";
        }
    }
}
