using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2U9F23 : IEquatable<Vector2U9F23>, IFormattable {
        // Fields
        // ---------------------------------------

        public U9F23 x;
        public U9F23 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2U9F23 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23(U9F23 x, U9F23 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23(Vector2U9F23 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator +(Vector2U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator -(Vector2U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator *(Vector2U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator *(Vector2U9F23 a, U9F23 b) => new Vector2U9F23(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator *(U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator /(Vector2U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator /(Vector2U9F23 a, U9F23 b) => new Vector2U9F23(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator /(U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U9F23 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(x, x); }
        public readonly Vector2U9F23 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(x, y); }
        public readonly Vector2U9F23 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(y, x); }
        public readonly Vector2U9F23 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(y, y); }
        public readonly Vector3U9F23 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(x, x, x); }
        public readonly Vector3U9F23 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(x, x, y); }
        public readonly Vector3U9F23 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(x, y, x); }
        public readonly Vector3U9F23 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(x, y, y); }
        public readonly Vector3U9F23 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(y, x, x); }
        public readonly Vector3U9F23 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(y, x, y); }
        public readonly Vector3U9F23 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(y, y, x); }
        public readonly Vector3U9F23 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(y, y, y); }
        public readonly Vector4U9F23 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, x, x, x); }
        public readonly Vector4U9F23 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, x, x, y); }
        public readonly Vector4U9F23 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, x, y, x); }
        public readonly Vector4U9F23 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, x, y, y); }
        public readonly Vector4U9F23 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, y, x, x); }
        public readonly Vector4U9F23 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, y, x, y); }
        public readonly Vector4U9F23 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, y, y, x); }
        public readonly Vector4U9F23 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(x, y, y, y); }
        public readonly Vector4U9F23 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, x, x, x); }
        public readonly Vector4U9F23 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, x, x, y); }
        public readonly Vector4U9F23 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, x, y, x); }
        public readonly Vector4U9F23 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, x, y, y); }
        public readonly Vector4U9F23 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, y, x, x); }
        public readonly Vector4U9F23 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, y, x, y); }
        public readonly Vector4U9F23 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, y, y, x); }
        public readonly Vector4U9F23 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U9F23 lhs, Vector2U9F23 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U9F23 lhs, Vector2U9F23 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U9F23 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U9F23({x}, {y})";

        // IEquatable<Vector2U9F23>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U9F23 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2U9F23({x}, {y})";
        }
    }
}
