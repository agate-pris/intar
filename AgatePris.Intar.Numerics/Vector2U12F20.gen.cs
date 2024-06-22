using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2U12F20 : IEquatable<Vector2U12F20>, IFormattable {
        // Fields
        // ---------------------------------------

        public U12F20 x;
        public U12F20 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2U12F20 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U12F20(U12F20 x, U12F20 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U12F20(Vector2U12F20 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator +(Vector2U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator -(Vector2U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator *(Vector2U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator *(Vector2U12F20 a, U12F20 b) => new Vector2U12F20(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator *(U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator /(Vector2U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator /(Vector2U12F20 a, U12F20 b) => new Vector2U12F20(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator /(U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U12F20 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(x, x); }
        public readonly Vector2U12F20 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(x, y); }
        public readonly Vector2U12F20 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(y, x); }
        public readonly Vector2U12F20 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(y, y); }
        public readonly Vector3U12F20 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(x, x, x); }
        public readonly Vector3U12F20 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(x, x, y); }
        public readonly Vector3U12F20 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(x, y, x); }
        public readonly Vector3U12F20 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(x, y, y); }
        public readonly Vector3U12F20 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(y, x, x); }
        public readonly Vector3U12F20 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(y, x, y); }
        public readonly Vector3U12F20 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(y, y, x); }
        public readonly Vector3U12F20 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(y, y, y); }
        public readonly Vector4U12F20 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, x, x, x); }
        public readonly Vector4U12F20 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, x, x, y); }
        public readonly Vector4U12F20 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, x, y, x); }
        public readonly Vector4U12F20 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, x, y, y); }
        public readonly Vector4U12F20 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, y, x, x); }
        public readonly Vector4U12F20 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, y, x, y); }
        public readonly Vector4U12F20 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, y, y, x); }
        public readonly Vector4U12F20 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(x, y, y, y); }
        public readonly Vector4U12F20 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, x, x, x); }
        public readonly Vector4U12F20 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, x, x, y); }
        public readonly Vector4U12F20 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, x, y, x); }
        public readonly Vector4U12F20 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, x, y, y); }
        public readonly Vector4U12F20 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, y, x, x); }
        public readonly Vector4U12F20 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, y, x, y); }
        public readonly Vector4U12F20 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, y, y, x); }
        public readonly Vector4U12F20 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U12F20 lhs, Vector2U12F20 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U12F20 lhs, Vector2U12F20 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U12F20 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U12F20({x}, {y})";

        // IEquatable<Vector2U12F20>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U12F20 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2U12F20({x}, {y})";
        }
    }
}
