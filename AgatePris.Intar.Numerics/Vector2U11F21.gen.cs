using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2U11F21 : IEquatable<Vector2U11F21>, IFormattable {
        // Fields
        // ---------------------------------------

        public U11F21 x;
        public U11F21 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2U11F21 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U11F21(U11F21 x, U11F21 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U11F21(Vector2U11F21 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator +(Vector2U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator -(Vector2U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator *(Vector2U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator *(Vector2U11F21 a, U11F21 b) => new Vector2U11F21(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator *(U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator /(Vector2U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator /(Vector2U11F21 a, U11F21 b) => new Vector2U11F21(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator /(U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U11F21 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(x, x); }
        public readonly Vector2U11F21 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(x, y); }
        public readonly Vector2U11F21 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(y, x); }
        public readonly Vector2U11F21 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(y, y); }
        public readonly Vector3U11F21 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(x, x, x); }
        public readonly Vector3U11F21 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(x, x, y); }
        public readonly Vector3U11F21 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(x, y, x); }
        public readonly Vector3U11F21 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(x, y, y); }
        public readonly Vector3U11F21 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(y, x, x); }
        public readonly Vector3U11F21 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(y, x, y); }
        public readonly Vector3U11F21 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(y, y, x); }
        public readonly Vector3U11F21 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(y, y, y); }
        public readonly Vector4U11F21 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, x, x, x); }
        public readonly Vector4U11F21 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, x, x, y); }
        public readonly Vector4U11F21 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, x, y, x); }
        public readonly Vector4U11F21 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, x, y, y); }
        public readonly Vector4U11F21 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, y, x, x); }
        public readonly Vector4U11F21 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, y, x, y); }
        public readonly Vector4U11F21 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, y, y, x); }
        public readonly Vector4U11F21 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(x, y, y, y); }
        public readonly Vector4U11F21 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, x, x, x); }
        public readonly Vector4U11F21 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, x, x, y); }
        public readonly Vector4U11F21 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, x, y, x); }
        public readonly Vector4U11F21 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, x, y, y); }
        public readonly Vector4U11F21 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, y, x, x); }
        public readonly Vector4U11F21 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, y, x, y); }
        public readonly Vector4U11F21 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, y, y, x); }
        public readonly Vector4U11F21 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U11F21 lhs, Vector2U11F21 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U11F21 lhs, Vector2U11F21 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U11F21 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U11F21({x}, {y})";

        // IEquatable<Vector2U11F21>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U11F21 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2U11F21({x}, {y})";
        }
    }
}
