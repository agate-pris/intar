using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2U16F16 : IEquatable<Vector2U16F16>, IFormattable {
        // Fields
        // ---------------------------------------

        public U16F16 x;
        public U16F16 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2U16F16 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U16F16(U16F16 x, U16F16 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U16F16(Vector2U16F16 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 operator +(Vector2U16F16 a, Vector2U16F16 b) => new Vector2U16F16(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 operator -(Vector2U16F16 a, Vector2U16F16 b) => new Vector2U16F16(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 operator *(Vector2U16F16 a, Vector2U16F16 b) => new Vector2U16F16(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 operator *(Vector2U16F16 a, U16F16 b) => new Vector2U16F16(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 operator *(U16F16 a, Vector2U16F16 b) => new Vector2U16F16(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 operator /(Vector2U16F16 a, Vector2U16F16 b) => new Vector2U16F16(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 operator /(Vector2U16F16 a, U16F16 b) => new Vector2U16F16(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 operator /(U16F16 a, Vector2U16F16 b) => new Vector2U16F16(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U16F16 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(x, x); }
        public readonly Vector2U16F16 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(x, y); }
        public readonly Vector2U16F16 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(y, x); }
        public readonly Vector2U16F16 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(y, y); }
        public readonly Vector3U16F16 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, x, x); }
        public readonly Vector3U16F16 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, x, y); }
        public readonly Vector3U16F16 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, y, x); }
        public readonly Vector3U16F16 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(x, y, y); }
        public readonly Vector3U16F16 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, x, x); }
        public readonly Vector3U16F16 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, x, y); }
        public readonly Vector3U16F16 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, y, x); }
        public readonly Vector3U16F16 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(y, y, y); }
        public readonly Vector4U16F16 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, x, x); }
        public readonly Vector4U16F16 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, x, y); }
        public readonly Vector4U16F16 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, y, x); }
        public readonly Vector4U16F16 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, x, y, y); }
        public readonly Vector4U16F16 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, x, x); }
        public readonly Vector4U16F16 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, x, y); }
        public readonly Vector4U16F16 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, y, x); }
        public readonly Vector4U16F16 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(x, y, y, y); }
        public readonly Vector4U16F16 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, x, x); }
        public readonly Vector4U16F16 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, x, y); }
        public readonly Vector4U16F16 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, y, x); }
        public readonly Vector4U16F16 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, x, y, y); }
        public readonly Vector4U16F16 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, x, x); }
        public readonly Vector4U16F16 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, x, y); }
        public readonly Vector4U16F16 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, y, x); }
        public readonly Vector4U16F16 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U16F16 lhs, Vector2U16F16 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U16F16 lhs, Vector2U16F16 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U16F16 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U16F16({x}, {y})";

        // IEquatable<Vector2U16F16>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U16F16 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2U16F16({x}, {y})";
        }
    }
}
