using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I6F26 : IEquatable<Vector2I6F26>, IFormattable {
        // Fields
        // ---------------------------------------

        public I6F26 x;
        public I6F26 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I6F26 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I6F26(I6F26 x, I6F26 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I6F26(Vector2I6F26 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 operator +(Vector2I6F26 a, Vector2I6F26 b) => new Vector2I6F26(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 operator -(Vector2I6F26 a, Vector2I6F26 b) => new Vector2I6F26(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 operator *(Vector2I6F26 a, Vector2I6F26 b) => new Vector2I6F26(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 operator *(Vector2I6F26 a, I6F26 b) => new Vector2I6F26(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 operator *(I6F26 a, Vector2I6F26 b) => new Vector2I6F26(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 operator /(Vector2I6F26 a, Vector2I6F26 b) => new Vector2I6F26(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 operator /(Vector2I6F26 a, I6F26 b) => new Vector2I6F26(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 operator /(I6F26 a, Vector2I6F26 b) => new Vector2I6F26(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I6F26 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(x, x); }
        public readonly Vector2I6F26 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(x, y); }
        public readonly Vector2I6F26 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(y, x); }
        public readonly Vector2I6F26 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(y, y); }
        public readonly Vector3I6F26 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, x, x); }
        public readonly Vector3I6F26 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, x, y); }
        public readonly Vector3I6F26 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, y, x); }
        public readonly Vector3I6F26 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(x, y, y); }
        public readonly Vector3I6F26 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, x, x); }
        public readonly Vector3I6F26 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, x, y); }
        public readonly Vector3I6F26 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, y, x); }
        public readonly Vector3I6F26 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(y, y, y); }
        public readonly Vector4I6F26 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, x, x); }
        public readonly Vector4I6F26 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, x, y); }
        public readonly Vector4I6F26 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, y, x); }
        public readonly Vector4I6F26 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, x, y, y); }
        public readonly Vector4I6F26 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, x, x); }
        public readonly Vector4I6F26 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, x, y); }
        public readonly Vector4I6F26 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, y, x); }
        public readonly Vector4I6F26 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(x, y, y, y); }
        public readonly Vector4I6F26 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, x, x); }
        public readonly Vector4I6F26 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, x, y); }
        public readonly Vector4I6F26 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, y, x); }
        public readonly Vector4I6F26 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, x, y, y); }
        public readonly Vector4I6F26 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, x, x); }
        public readonly Vector4I6F26 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, x, y); }
        public readonly Vector4I6F26 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, y, x); }
        public readonly Vector4I6F26 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I6F26 lhs, Vector2I6F26 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I6F26 lhs, Vector2I6F26 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I6F26 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I6F26({x}, {y})";

        // IEquatable<Vector2I6F26>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I6F26 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I6F26({x}, {y})";
        }
    }
}
