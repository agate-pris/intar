using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2U24F8 : IEquatable<Vector2U24F8>, IFormattable {
        // Fields
        // ---------------------------------------

        public U24F8 x;
        public U24F8 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2U24F8 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U24F8(U24F8 x, U24F8 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U24F8(Vector2U24F8 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 operator +(Vector2U24F8 a, Vector2U24F8 b) => new Vector2U24F8(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 operator -(Vector2U24F8 a, Vector2U24F8 b) => new Vector2U24F8(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 operator *(Vector2U24F8 a, Vector2U24F8 b) => new Vector2U24F8(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 operator *(Vector2U24F8 a, U24F8 b) => new Vector2U24F8(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 operator *(U24F8 a, Vector2U24F8 b) => new Vector2U24F8(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 operator /(Vector2U24F8 a, Vector2U24F8 b) => new Vector2U24F8(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 operator /(Vector2U24F8 a, U24F8 b) => new Vector2U24F8(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 operator /(U24F8 a, Vector2U24F8 b) => new Vector2U24F8(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U24F8 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(x, x); }
        public readonly Vector2U24F8 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(x, y); }
        public readonly Vector2U24F8 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(y, x); }
        public readonly Vector2U24F8 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(y, y); }
        public readonly Vector3U24F8 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, x, x); }
        public readonly Vector3U24F8 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, x, y); }
        public readonly Vector3U24F8 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, y, x); }
        public readonly Vector3U24F8 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(x, y, y); }
        public readonly Vector3U24F8 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, x, x); }
        public readonly Vector3U24F8 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, x, y); }
        public readonly Vector3U24F8 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, y, x); }
        public readonly Vector3U24F8 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(y, y, y); }
        public readonly Vector4U24F8 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, x, x); }
        public readonly Vector4U24F8 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, x, y); }
        public readonly Vector4U24F8 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, y, x); }
        public readonly Vector4U24F8 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, x, y, y); }
        public readonly Vector4U24F8 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, x, x); }
        public readonly Vector4U24F8 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, x, y); }
        public readonly Vector4U24F8 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, y, x); }
        public readonly Vector4U24F8 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(x, y, y, y); }
        public readonly Vector4U24F8 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, x, x); }
        public readonly Vector4U24F8 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, x, y); }
        public readonly Vector4U24F8 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, y, x); }
        public readonly Vector4U24F8 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, x, y, y); }
        public readonly Vector4U24F8 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, x, x); }
        public readonly Vector4U24F8 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, x, y); }
        public readonly Vector4U24F8 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, y, x); }
        public readonly Vector4U24F8 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U24F8 lhs, Vector2U24F8 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U24F8 lhs, Vector2U24F8 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U24F8 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U24F8({x}, {y})";

        // IEquatable<Vector2U24F8>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U24F8 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2U24F8({x}, {y})";
        }
    }
}
