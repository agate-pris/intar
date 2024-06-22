using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I19F13 : IEquatable<Vector2I19F13>, IFormattable {
        // Fields
        // ---------------------------------------

        public I19F13 x;
        public I19F13 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I19F13 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13(I19F13 x, I19F13 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13(Vector2I19F13 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator +(Vector2I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator -(Vector2I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator *(Vector2I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator *(Vector2I19F13 a, I19F13 b) => new Vector2I19F13(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator *(I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator /(Vector2I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator /(Vector2I19F13 a, I19F13 b) => new Vector2I19F13(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator /(I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I19F13 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(x, x); }
        public readonly Vector2I19F13 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(x, y); }
        public readonly Vector2I19F13 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(y, x); }
        public readonly Vector2I19F13 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(y, y); }
        public readonly Vector3I19F13 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, x, x); }
        public readonly Vector3I19F13 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, x, y); }
        public readonly Vector3I19F13 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, y, x); }
        public readonly Vector3I19F13 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(x, y, y); }
        public readonly Vector3I19F13 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, x, x); }
        public readonly Vector3I19F13 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, x, y); }
        public readonly Vector3I19F13 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, y, x); }
        public readonly Vector3I19F13 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(y, y, y); }
        public readonly Vector4I19F13 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, x, x); }
        public readonly Vector4I19F13 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, x, y); }
        public readonly Vector4I19F13 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, y, x); }
        public readonly Vector4I19F13 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, x, y, y); }
        public readonly Vector4I19F13 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, x, x); }
        public readonly Vector4I19F13 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, x, y); }
        public readonly Vector4I19F13 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, y, x); }
        public readonly Vector4I19F13 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(x, y, y, y); }
        public readonly Vector4I19F13 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, x, x); }
        public readonly Vector4I19F13 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, x, y); }
        public readonly Vector4I19F13 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, y, x); }
        public readonly Vector4I19F13 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, x, y, y); }
        public readonly Vector4I19F13 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, x, x); }
        public readonly Vector4I19F13 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, x, y); }
        public readonly Vector4I19F13 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, y, x); }
        public readonly Vector4I19F13 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I19F13 lhs, Vector2I19F13 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I19F13 lhs, Vector2I19F13 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I19F13 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I19F13({x}, {y})";

        // IEquatable<Vector2I19F13>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I19F13 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I19F13({x}, {y})";
        }
    }
}
