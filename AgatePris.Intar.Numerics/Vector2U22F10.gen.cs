using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2U22F10 : IEquatable<Vector2U22F10>, IFormattable {
        // Fields
        // ---------------------------------------

        public U22F10 x;
        public U22F10 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2U22F10 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U22F10(U22F10 x, U22F10 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U22F10(Vector2U22F10 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 operator +(Vector2U22F10 a, Vector2U22F10 b) => new Vector2U22F10(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 operator -(Vector2U22F10 a, Vector2U22F10 b) => new Vector2U22F10(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 operator *(Vector2U22F10 a, Vector2U22F10 b) => new Vector2U22F10(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 operator *(Vector2U22F10 a, U22F10 b) => new Vector2U22F10(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 operator *(U22F10 a, Vector2U22F10 b) => new Vector2U22F10(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 operator /(Vector2U22F10 a, Vector2U22F10 b) => new Vector2U22F10(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 operator /(Vector2U22F10 a, U22F10 b) => new Vector2U22F10(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 operator /(U22F10 a, Vector2U22F10 b) => new Vector2U22F10(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U22F10 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(x, x); }
        public readonly Vector2U22F10 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(x, y); }
        public readonly Vector2U22F10 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(y, x); }
        public readonly Vector2U22F10 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(y, y); }
        public readonly Vector3U22F10 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(x, x, x); }
        public readonly Vector3U22F10 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(x, x, y); }
        public readonly Vector3U22F10 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(x, y, x); }
        public readonly Vector3U22F10 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(x, y, y); }
        public readonly Vector3U22F10 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(y, x, x); }
        public readonly Vector3U22F10 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(y, x, y); }
        public readonly Vector3U22F10 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(y, y, x); }
        public readonly Vector3U22F10 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(y, y, y); }
        public readonly Vector4U22F10 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, x, x, x); }
        public readonly Vector4U22F10 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, x, x, y); }
        public readonly Vector4U22F10 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, x, y, x); }
        public readonly Vector4U22F10 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, x, y, y); }
        public readonly Vector4U22F10 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, y, x, x); }
        public readonly Vector4U22F10 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, y, x, y); }
        public readonly Vector4U22F10 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, y, y, x); }
        public readonly Vector4U22F10 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(x, y, y, y); }
        public readonly Vector4U22F10 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, x, x, x); }
        public readonly Vector4U22F10 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, x, x, y); }
        public readonly Vector4U22F10 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, x, y, x); }
        public readonly Vector4U22F10 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, x, y, y); }
        public readonly Vector4U22F10 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, y, x, x); }
        public readonly Vector4U22F10 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, y, x, y); }
        public readonly Vector4U22F10 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, y, y, x); }
        public readonly Vector4U22F10 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U22F10 lhs, Vector2U22F10 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U22F10 lhs, Vector2U22F10 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U22F10 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U22F10({x}, {y})";

        // IEquatable<Vector2U22F10>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U22F10 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2U22F10({x}, {y})";
        }
    }
}
