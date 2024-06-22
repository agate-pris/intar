using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2U14F18 : IEquatable<Vector2U14F18>, IFormattable {
        // Fields
        // ---------------------------------------

        public U14F18 x;
        public U14F18 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2U14F18 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18(U14F18 x, U14F18 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18(Vector2U14F18 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator +(Vector2U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator -(Vector2U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator *(Vector2U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator *(Vector2U14F18 a, U14F18 b) => new Vector2U14F18(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator *(U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator /(Vector2U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator /(Vector2U14F18 a, U14F18 b) => new Vector2U14F18(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator /(U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U14F18 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(x, x); }
        public readonly Vector2U14F18 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(x, y); }
        public readonly Vector2U14F18 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(y, x); }
        public readonly Vector2U14F18 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(y, y); }
        public readonly Vector3U14F18 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, x, x); }
        public readonly Vector3U14F18 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, x, y); }
        public readonly Vector3U14F18 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, y, x); }
        public readonly Vector3U14F18 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(x, y, y); }
        public readonly Vector3U14F18 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, x, x); }
        public readonly Vector3U14F18 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, x, y); }
        public readonly Vector3U14F18 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, y, x); }
        public readonly Vector3U14F18 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(y, y, y); }
        public readonly Vector4U14F18 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, x, x); }
        public readonly Vector4U14F18 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, x, y); }
        public readonly Vector4U14F18 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, y, x); }
        public readonly Vector4U14F18 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, x, y, y); }
        public readonly Vector4U14F18 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, x, x); }
        public readonly Vector4U14F18 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, x, y); }
        public readonly Vector4U14F18 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, y, x); }
        public readonly Vector4U14F18 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(x, y, y, y); }
        public readonly Vector4U14F18 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, x, x); }
        public readonly Vector4U14F18 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, x, y); }
        public readonly Vector4U14F18 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, y, x); }
        public readonly Vector4U14F18 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, x, y, y); }
        public readonly Vector4U14F18 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, x, x); }
        public readonly Vector4U14F18 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, x, y); }
        public readonly Vector4U14F18 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, y, x); }
        public readonly Vector4U14F18 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U14F18 lhs, Vector2U14F18 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U14F18 lhs, Vector2U14F18 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U14F18 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U14F18({x}, {y})";

        // IEquatable<Vector2U14F18>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U14F18 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2U14F18({x}, {y})";
        }
    }
}
