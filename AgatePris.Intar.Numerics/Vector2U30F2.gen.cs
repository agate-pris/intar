using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2U30F2 : IEquatable<Vector2U30F2>, IFormattable {
        // Fields
        // ---------------------------------------

        public U30F2 x;
        public U30F2 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2U30F2 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2(U30F2 x, U30F2 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2(Vector2U30F2 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator +(Vector2U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator -(Vector2U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator *(Vector2U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator *(Vector2U30F2 a, U30F2 b) => new Vector2U30F2(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator *(U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator /(Vector2U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator /(Vector2U30F2 a, U30F2 b) => new Vector2U30F2(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator /(U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U30F2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(x, x); }
        public readonly Vector2U30F2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(x, y); }
        public readonly Vector2U30F2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(y, x); }
        public readonly Vector2U30F2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(y, y); }
        public readonly Vector3U30F2 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, x, x); }
        public readonly Vector3U30F2 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, x, y); }
        public readonly Vector3U30F2 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, y, x); }
        public readonly Vector3U30F2 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(x, y, y); }
        public readonly Vector3U30F2 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, x, x); }
        public readonly Vector3U30F2 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, x, y); }
        public readonly Vector3U30F2 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, y, x); }
        public readonly Vector3U30F2 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(y, y, y); }
        public readonly Vector4U30F2 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, x, x); }
        public readonly Vector4U30F2 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, x, y); }
        public readonly Vector4U30F2 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, y, x); }
        public readonly Vector4U30F2 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, x, y, y); }
        public readonly Vector4U30F2 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, x, x); }
        public readonly Vector4U30F2 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, x, y); }
        public readonly Vector4U30F2 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, y, x); }
        public readonly Vector4U30F2 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(x, y, y, y); }
        public readonly Vector4U30F2 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, x, x); }
        public readonly Vector4U30F2 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, x, y); }
        public readonly Vector4U30F2 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, y, x); }
        public readonly Vector4U30F2 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, x, y, y); }
        public readonly Vector4U30F2 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, x, x); }
        public readonly Vector4U30F2 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, x, y); }
        public readonly Vector4U30F2 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, y, x); }
        public readonly Vector4U30F2 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U30F2 lhs, Vector2U30F2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U30F2 lhs, Vector2U30F2 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U30F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U30F2({x}, {y})";

        // IEquatable<Vector2U30F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U30F2 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2U30F2({x}, {y})";
        }
    }
}
