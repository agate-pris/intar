using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2U13F19 : IEquatable<Vector2U13F19>, IFormattable {
        // Fields
        // ---------------------------------------

        public U13F19 x;
        public U13F19 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2U13F19 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U13F19(U13F19 x, U13F19 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U13F19(Vector2U13F19 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 operator +(Vector2U13F19 a, Vector2U13F19 b) => new Vector2U13F19(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 operator -(Vector2U13F19 a, Vector2U13F19 b) => new Vector2U13F19(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 operator *(Vector2U13F19 a, Vector2U13F19 b) => new Vector2U13F19(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 operator *(Vector2U13F19 a, U13F19 b) => new Vector2U13F19(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 operator *(U13F19 a, Vector2U13F19 b) => new Vector2U13F19(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 operator /(Vector2U13F19 a, Vector2U13F19 b) => new Vector2U13F19(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 operator /(Vector2U13F19 a, U13F19 b) => new Vector2U13F19(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 operator /(U13F19 a, Vector2U13F19 b) => new Vector2U13F19(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U13F19 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(x, x); }
        public readonly Vector2U13F19 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(x, y); }
        public readonly Vector2U13F19 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(y, x); }
        public readonly Vector2U13F19 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(y, y); }
        public readonly Vector3U13F19 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, x, x); }
        public readonly Vector3U13F19 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, x, y); }
        public readonly Vector3U13F19 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, y, x); }
        public readonly Vector3U13F19 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(x, y, y); }
        public readonly Vector3U13F19 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, x, x); }
        public readonly Vector3U13F19 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, x, y); }
        public readonly Vector3U13F19 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, y, x); }
        public readonly Vector3U13F19 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(y, y, y); }
        public readonly Vector4U13F19 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, x, x); }
        public readonly Vector4U13F19 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, x, y); }
        public readonly Vector4U13F19 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, y, x); }
        public readonly Vector4U13F19 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, x, y, y); }
        public readonly Vector4U13F19 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, x, x); }
        public readonly Vector4U13F19 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, x, y); }
        public readonly Vector4U13F19 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, y, x); }
        public readonly Vector4U13F19 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(x, y, y, y); }
        public readonly Vector4U13F19 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, x, x); }
        public readonly Vector4U13F19 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, x, y); }
        public readonly Vector4U13F19 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, y, x); }
        public readonly Vector4U13F19 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, x, y, y); }
        public readonly Vector4U13F19 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, x, x); }
        public readonly Vector4U13F19 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, x, y); }
        public readonly Vector4U13F19 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, y, x); }
        public readonly Vector4U13F19 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U13F19 lhs, Vector2U13F19 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U13F19 lhs, Vector2U13F19 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U13F19 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U13F19({x}, {y})";

        // IEquatable<Vector2U13F19>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U13F19 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2U13F19({x}, {y})";
        }
    }
}
