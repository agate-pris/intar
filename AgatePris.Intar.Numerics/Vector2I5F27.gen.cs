using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I5F27 : IEquatable<Vector2I5F27>, IFormattable {
        // Fields
        // ---------------------------------------

        public I5F27 x;
        public I5F27 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I5F27 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I5F27(I5F27 x, I5F27 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I5F27(Vector2I5F27 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 operator +(Vector2I5F27 a, Vector2I5F27 b) => new Vector2I5F27(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 operator -(Vector2I5F27 a, Vector2I5F27 b) => new Vector2I5F27(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 operator *(Vector2I5F27 a, Vector2I5F27 b) => new Vector2I5F27(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 operator *(Vector2I5F27 a, I5F27 b) => new Vector2I5F27(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 operator *(I5F27 a, Vector2I5F27 b) => new Vector2I5F27(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 operator /(Vector2I5F27 a, Vector2I5F27 b) => new Vector2I5F27(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 operator /(Vector2I5F27 a, I5F27 b) => new Vector2I5F27(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 operator /(I5F27 a, Vector2I5F27 b) => new Vector2I5F27(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I5F27 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(x, x); }
        public readonly Vector2I5F27 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(x, y); }
        public readonly Vector2I5F27 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(y, x); }
        public readonly Vector2I5F27 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(y, y); }
        public readonly Vector3I5F27 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(x, x, x); }
        public readonly Vector3I5F27 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(x, x, y); }
        public readonly Vector3I5F27 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(x, y, x); }
        public readonly Vector3I5F27 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(x, y, y); }
        public readonly Vector3I5F27 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(y, x, x); }
        public readonly Vector3I5F27 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(y, x, y); }
        public readonly Vector3I5F27 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(y, y, x); }
        public readonly Vector3I5F27 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(y, y, y); }
        public readonly Vector4I5F27 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, x, x, x); }
        public readonly Vector4I5F27 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, x, x, y); }
        public readonly Vector4I5F27 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, x, y, x); }
        public readonly Vector4I5F27 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, x, y, y); }
        public readonly Vector4I5F27 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, y, x, x); }
        public readonly Vector4I5F27 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, y, x, y); }
        public readonly Vector4I5F27 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, y, y, x); }
        public readonly Vector4I5F27 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(x, y, y, y); }
        public readonly Vector4I5F27 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, x, x, x); }
        public readonly Vector4I5F27 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, x, x, y); }
        public readonly Vector4I5F27 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, x, y, x); }
        public readonly Vector4I5F27 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, x, y, y); }
        public readonly Vector4I5F27 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, y, x, x); }
        public readonly Vector4I5F27 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, y, x, y); }
        public readonly Vector4I5F27 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, y, y, x); }
        public readonly Vector4I5F27 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I5F27 lhs, Vector2I5F27 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I5F27 lhs, Vector2I5F27 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I5F27 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I5F27({x}, {y})";

        // IEquatable<Vector2I5F27>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I5F27 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I5F27({x}, {y})";
        }
    }
}
