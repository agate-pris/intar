using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2U7F25 : IEquatable<Vector2U7F25>, IFormattable {
        // Fields
        // ---------------------------------------

        public U7F25 x;
        public U7F25 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2U7F25 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25(U7F25 x, U7F25 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25(Vector2U7F25 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 operator +(Vector2U7F25 a, Vector2U7F25 b) => new Vector2U7F25(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 operator -(Vector2U7F25 a, Vector2U7F25 b) => new Vector2U7F25(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 operator *(Vector2U7F25 a, Vector2U7F25 b) => new Vector2U7F25(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 operator *(Vector2U7F25 a, U7F25 b) => new Vector2U7F25(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 operator *(U7F25 a, Vector2U7F25 b) => new Vector2U7F25(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 operator /(Vector2U7F25 a, Vector2U7F25 b) => new Vector2U7F25(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 operator /(Vector2U7F25 a, U7F25 b) => new Vector2U7F25(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 operator /(U7F25 a, Vector2U7F25 b) => new Vector2U7F25(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U7F25 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(x, x); }
        public readonly Vector2U7F25 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(x, y); }
        public readonly Vector2U7F25 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(y, x); }
        public readonly Vector2U7F25 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(y, y); }
        public readonly Vector3U7F25 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(x, x, x); }
        public readonly Vector3U7F25 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(x, x, y); }
        public readonly Vector3U7F25 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(x, y, x); }
        public readonly Vector3U7F25 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(x, y, y); }
        public readonly Vector3U7F25 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(y, x, x); }
        public readonly Vector3U7F25 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(y, x, y); }
        public readonly Vector3U7F25 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(y, y, x); }
        public readonly Vector3U7F25 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(y, y, y); }
        public readonly Vector4U7F25 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(x, x, x, x); }
        public readonly Vector4U7F25 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(x, x, x, y); }
        public readonly Vector4U7F25 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(x, x, y, x); }
        public readonly Vector4U7F25 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(x, x, y, y); }
        public readonly Vector4U7F25 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(x, y, x, x); }
        public readonly Vector4U7F25 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(x, y, x, y); }
        public readonly Vector4U7F25 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(x, y, y, x); }
        public readonly Vector4U7F25 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(x, y, y, y); }
        public readonly Vector4U7F25 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(y, x, x, x); }
        public readonly Vector4U7F25 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(y, x, x, y); }
        public readonly Vector4U7F25 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(y, x, y, x); }
        public readonly Vector4U7F25 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(y, x, y, y); }
        public readonly Vector4U7F25 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(y, y, x, x); }
        public readonly Vector4U7F25 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(y, y, x, y); }
        public readonly Vector4U7F25 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(y, y, y, x); }
        public readonly Vector4U7F25 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U7F25 lhs, Vector2U7F25 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U7F25 lhs, Vector2U7F25 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U7F25 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U7F25({x}, {y})";

        // IEquatable<Vector2U7F25>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U7F25 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2U7F25({x}, {y})";
        }
    }
}
