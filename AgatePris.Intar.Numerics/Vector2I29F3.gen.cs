using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I29F3 : IEquatable<Vector2I29F3>, IFormattable {
        // Fields
        // ---------------------------------------

        public I29F3 x;
        public I29F3 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I29F3 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I29F3(I29F3 x, I29F3 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I29F3(Vector2I29F3 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 operator +(Vector2I29F3 a, Vector2I29F3 b) => new Vector2I29F3(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 operator -(Vector2I29F3 a, Vector2I29F3 b) => new Vector2I29F3(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 operator *(Vector2I29F3 a, Vector2I29F3 b) => new Vector2I29F3(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 operator *(Vector2I29F3 a, I29F3 b) => new Vector2I29F3(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 operator *(I29F3 a, Vector2I29F3 b) => new Vector2I29F3(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 operator /(Vector2I29F3 a, Vector2I29F3 b) => new Vector2I29F3(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 operator /(Vector2I29F3 a, I29F3 b) => new Vector2I29F3(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 operator /(I29F3 a, Vector2I29F3 b) => new Vector2I29F3(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I29F3 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(x, x); }
        public readonly Vector2I29F3 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(x, y); }
        public readonly Vector2I29F3 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(y, x); }
        public readonly Vector2I29F3 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(y, y); }
        public readonly Vector3I29F3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(x, x, x); }
        public readonly Vector3I29F3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(x, x, y); }
        public readonly Vector3I29F3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(x, y, x); }
        public readonly Vector3I29F3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(x, y, y); }
        public readonly Vector3I29F3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(y, x, x); }
        public readonly Vector3I29F3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(y, x, y); }
        public readonly Vector3I29F3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(y, y, x); }
        public readonly Vector3I29F3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(y, y, y); }
        public readonly Vector4I29F3 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(x, x, x, x); }
        public readonly Vector4I29F3 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(x, x, x, y); }
        public readonly Vector4I29F3 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(x, x, y, x); }
        public readonly Vector4I29F3 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(x, x, y, y); }
        public readonly Vector4I29F3 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(x, y, x, x); }
        public readonly Vector4I29F3 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(x, y, x, y); }
        public readonly Vector4I29F3 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(x, y, y, x); }
        public readonly Vector4I29F3 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(x, y, y, y); }
        public readonly Vector4I29F3 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(y, x, x, x); }
        public readonly Vector4I29F3 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(y, x, x, y); }
        public readonly Vector4I29F3 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(y, x, y, x); }
        public readonly Vector4I29F3 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(y, x, y, y); }
        public readonly Vector4I29F3 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(y, y, x, x); }
        public readonly Vector4I29F3 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(y, y, x, y); }
        public readonly Vector4I29F3 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(y, y, y, x); }
        public readonly Vector4I29F3 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I29F3 lhs, Vector2I29F3 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I29F3 lhs, Vector2I29F3 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I29F3 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I29F3({x}, {y})";

        // IEquatable<Vector2I29F3>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I29F3 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I29F3({x}, {y})";
        }
    }
}
