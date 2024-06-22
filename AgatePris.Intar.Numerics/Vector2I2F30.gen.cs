using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I2F30 : IEquatable<Vector2I2F30>, IFormattable {
        // Fields
        // ---------------------------------------

        public I2F30 x;
        public I2F30 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I2F30 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30(I2F30 x, I2F30 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30(Vector2I2F30 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator +(Vector2I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator -(Vector2I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator *(Vector2I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator *(Vector2I2F30 a, I2F30 b) => new Vector2I2F30(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator *(I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator /(Vector2I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator /(Vector2I2F30 a, I2F30 b) => new Vector2I2F30(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator /(I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I2F30 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(x, x); }
        public readonly Vector2I2F30 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(x, y); }
        public readonly Vector2I2F30 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(y, x); }
        public readonly Vector2I2F30 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(y, y); }
        public readonly Vector3I2F30 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(x, x, x); }
        public readonly Vector3I2F30 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(x, x, y); }
        public readonly Vector3I2F30 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(x, y, x); }
        public readonly Vector3I2F30 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(x, y, y); }
        public readonly Vector3I2F30 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(y, x, x); }
        public readonly Vector3I2F30 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(y, x, y); }
        public readonly Vector3I2F30 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(y, y, x); }
        public readonly Vector3I2F30 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(y, y, y); }
        public readonly Vector4I2F30 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, x, x, x); }
        public readonly Vector4I2F30 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, x, x, y); }
        public readonly Vector4I2F30 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, x, y, x); }
        public readonly Vector4I2F30 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, x, y, y); }
        public readonly Vector4I2F30 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, y, x, x); }
        public readonly Vector4I2F30 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, y, x, y); }
        public readonly Vector4I2F30 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, y, y, x); }
        public readonly Vector4I2F30 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(x, y, y, y); }
        public readonly Vector4I2F30 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, x, x, x); }
        public readonly Vector4I2F30 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, x, x, y); }
        public readonly Vector4I2F30 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, x, y, x); }
        public readonly Vector4I2F30 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, x, y, y); }
        public readonly Vector4I2F30 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, y, x, x); }
        public readonly Vector4I2F30 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, y, x, y); }
        public readonly Vector4I2F30 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, y, y, x); }
        public readonly Vector4I2F30 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I2F30 lhs, Vector2I2F30 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I2F30 lhs, Vector2I2F30 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I2F30({x}, {y})";

        // IEquatable<Vector2I2F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I2F30 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I2F30({x}, {y})";
        }
    }
}
