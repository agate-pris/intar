using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2U21F11 : IEquatable<Vector2U21F11>, IFormattable {
        // Fields
        // ---------------------------------------

        public U21F11 x;
        public U21F11 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2U21F11 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U21F11(U21F11 x, U21F11 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U21F11(Vector2U21F11 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 operator +(Vector2U21F11 a, Vector2U21F11 b) => new Vector2U21F11(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 operator -(Vector2U21F11 a, Vector2U21F11 b) => new Vector2U21F11(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 operator *(Vector2U21F11 a, Vector2U21F11 b) => new Vector2U21F11(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 operator *(Vector2U21F11 a, U21F11 b) => new Vector2U21F11(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 operator *(U21F11 a, Vector2U21F11 b) => new Vector2U21F11(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 operator /(Vector2U21F11 a, Vector2U21F11 b) => new Vector2U21F11(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 operator /(Vector2U21F11 a, U21F11 b) => new Vector2U21F11(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 operator /(U21F11 a, Vector2U21F11 b) => new Vector2U21F11(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U21F11 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(x, x); }
        public readonly Vector2U21F11 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(x, y); }
        public readonly Vector2U21F11 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(y, x); }
        public readonly Vector2U21F11 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(y, y); }
        public readonly Vector3U21F11 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(x, x, x); }
        public readonly Vector3U21F11 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(x, x, y); }
        public readonly Vector3U21F11 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(x, y, x); }
        public readonly Vector3U21F11 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(x, y, y); }
        public readonly Vector3U21F11 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(y, x, x); }
        public readonly Vector3U21F11 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(y, x, y); }
        public readonly Vector3U21F11 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(y, y, x); }
        public readonly Vector3U21F11 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(y, y, y); }
        public readonly Vector4U21F11 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(x, x, x, x); }
        public readonly Vector4U21F11 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(x, x, x, y); }
        public readonly Vector4U21F11 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(x, x, y, x); }
        public readonly Vector4U21F11 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(x, x, y, y); }
        public readonly Vector4U21F11 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(x, y, x, x); }
        public readonly Vector4U21F11 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(x, y, x, y); }
        public readonly Vector4U21F11 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(x, y, y, x); }
        public readonly Vector4U21F11 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(x, y, y, y); }
        public readonly Vector4U21F11 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(y, x, x, x); }
        public readonly Vector4U21F11 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(y, x, x, y); }
        public readonly Vector4U21F11 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(y, x, y, x); }
        public readonly Vector4U21F11 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(y, x, y, y); }
        public readonly Vector4U21F11 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(y, y, x, x); }
        public readonly Vector4U21F11 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(y, y, x, y); }
        public readonly Vector4U21F11 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(y, y, y, x); }
        public readonly Vector4U21F11 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U21F11 lhs, Vector2U21F11 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U21F11 lhs, Vector2U21F11 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U21F11 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U21F11({x}, {y})";

        // IEquatable<Vector2U21F11>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U21F11 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2U21F11({x}, {y})";
        }
    }
}
