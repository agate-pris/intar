using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2U25F7 : IEquatable<Vector2U25F7>, IFormattable {
        // Fields
        // ---------------------------------------

        public U25F7 x;
        public U25F7 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2U25F7 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U25F7(U25F7 x, U25F7 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U25F7(Vector2U25F7 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 operator +(Vector2U25F7 a, Vector2U25F7 b) => new Vector2U25F7(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 operator -(Vector2U25F7 a, Vector2U25F7 b) => new Vector2U25F7(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 operator *(Vector2U25F7 a, Vector2U25F7 b) => new Vector2U25F7(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 operator *(Vector2U25F7 a, U25F7 b) => new Vector2U25F7(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 operator *(U25F7 a, Vector2U25F7 b) => new Vector2U25F7(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 operator /(Vector2U25F7 a, Vector2U25F7 b) => new Vector2U25F7(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 operator /(Vector2U25F7 a, U25F7 b) => new Vector2U25F7(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 operator /(U25F7 a, Vector2U25F7 b) => new Vector2U25F7(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U25F7 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(x, x); }
        public readonly Vector2U25F7 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(x, y); }
        public readonly Vector2U25F7 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(y, x); }
        public readonly Vector2U25F7 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(y, y); }
        public readonly Vector3U25F7 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, x, x); }
        public readonly Vector3U25F7 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, x, y); }
        public readonly Vector3U25F7 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, y, x); }
        public readonly Vector3U25F7 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(x, y, y); }
        public readonly Vector3U25F7 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, x, x); }
        public readonly Vector3U25F7 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, x, y); }
        public readonly Vector3U25F7 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, y, x); }
        public readonly Vector3U25F7 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(y, y, y); }
        public readonly Vector4U25F7 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, x, x); }
        public readonly Vector4U25F7 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, x, y); }
        public readonly Vector4U25F7 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, y, x); }
        public readonly Vector4U25F7 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, x, y, y); }
        public readonly Vector4U25F7 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, x, x); }
        public readonly Vector4U25F7 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, x, y); }
        public readonly Vector4U25F7 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, y, x); }
        public readonly Vector4U25F7 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(x, y, y, y); }
        public readonly Vector4U25F7 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, x, x); }
        public readonly Vector4U25F7 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, x, y); }
        public readonly Vector4U25F7 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, y, x); }
        public readonly Vector4U25F7 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, x, y, y); }
        public readonly Vector4U25F7 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, x, x); }
        public readonly Vector4U25F7 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, x, y); }
        public readonly Vector4U25F7 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, y, x); }
        public readonly Vector4U25F7 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U25F7 lhs, Vector2U25F7 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U25F7 lhs, Vector2U25F7 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U25F7 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U25F7({x}, {y})";

        // IEquatable<Vector2U25F7>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U25F7 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2U25F7({x}, {y})";
        }
    }
}
