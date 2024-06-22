using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2U10F22 : IEquatable<Vector2U10F22>, IFormattable {
        // Fields
        // ---------------------------------------

        public U10F22 x;
        public U10F22 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2U10F22 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22(U10F22 x, U10F22 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22(Vector2U10F22 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator +(Vector2U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator -(Vector2U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator *(Vector2U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator *(Vector2U10F22 a, U10F22 b) => new Vector2U10F22(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator *(U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator /(Vector2U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator /(Vector2U10F22 a, U10F22 b) => new Vector2U10F22(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator /(U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U10F22 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(x, x); }
        public readonly Vector2U10F22 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(x, y); }
        public readonly Vector2U10F22 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(y, x); }
        public readonly Vector2U10F22 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(y, y); }
        public readonly Vector3U10F22 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(x, x, x); }
        public readonly Vector3U10F22 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(x, x, y); }
        public readonly Vector3U10F22 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(x, y, x); }
        public readonly Vector3U10F22 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(x, y, y); }
        public readonly Vector3U10F22 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(y, x, x); }
        public readonly Vector3U10F22 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(y, x, y); }
        public readonly Vector3U10F22 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(y, y, x); }
        public readonly Vector3U10F22 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(y, y, y); }
        public readonly Vector4U10F22 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, x, x, x); }
        public readonly Vector4U10F22 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, x, x, y); }
        public readonly Vector4U10F22 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, x, y, x); }
        public readonly Vector4U10F22 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, x, y, y); }
        public readonly Vector4U10F22 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, y, x, x); }
        public readonly Vector4U10F22 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, y, x, y); }
        public readonly Vector4U10F22 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, y, y, x); }
        public readonly Vector4U10F22 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(x, y, y, y); }
        public readonly Vector4U10F22 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, x, x, x); }
        public readonly Vector4U10F22 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, x, x, y); }
        public readonly Vector4U10F22 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, x, y, x); }
        public readonly Vector4U10F22 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, x, y, y); }
        public readonly Vector4U10F22 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, y, x, x); }
        public readonly Vector4U10F22 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, y, x, y); }
        public readonly Vector4U10F22 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, y, y, x); }
        public readonly Vector4U10F22 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U10F22 lhs, Vector2U10F22 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U10F22 lhs, Vector2U10F22 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U10F22 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U10F22({x}, {y})";

        // IEquatable<Vector2U10F22>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U10F22 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2U10F22({x}, {y})";
        }
    }
}
