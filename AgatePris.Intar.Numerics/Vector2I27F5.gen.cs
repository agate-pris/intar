using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I27F5 : IEquatable<Vector2I27F5>, IFormattable {
        // Fields
        // ---------------------------------------

        public I27F5 x;
        public I27F5 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I27F5 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I27F5(I27F5 x, I27F5 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I27F5(Vector2I27F5 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator +(Vector2I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator -(Vector2I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator *(Vector2I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator *(Vector2I27F5 a, I27F5 b) => new Vector2I27F5(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator *(I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator /(Vector2I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator /(Vector2I27F5 a, I27F5 b) => new Vector2I27F5(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator /(I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I27F5 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(x, x); }
        public readonly Vector2I27F5 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(x, y); }
        public readonly Vector2I27F5 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(y, x); }
        public readonly Vector2I27F5 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(y, y); }
        public readonly Vector3I27F5 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(x, x, x); }
        public readonly Vector3I27F5 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(x, x, y); }
        public readonly Vector3I27F5 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(x, y, x); }
        public readonly Vector3I27F5 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(x, y, y); }
        public readonly Vector3I27F5 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(y, x, x); }
        public readonly Vector3I27F5 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(y, x, y); }
        public readonly Vector3I27F5 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(y, y, x); }
        public readonly Vector3I27F5 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(y, y, y); }
        public readonly Vector4I27F5 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(x, x, x, x); }
        public readonly Vector4I27F5 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(x, x, x, y); }
        public readonly Vector4I27F5 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(x, x, y, x); }
        public readonly Vector4I27F5 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(x, x, y, y); }
        public readonly Vector4I27F5 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(x, y, x, x); }
        public readonly Vector4I27F5 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(x, y, x, y); }
        public readonly Vector4I27F5 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(x, y, y, x); }
        public readonly Vector4I27F5 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(x, y, y, y); }
        public readonly Vector4I27F5 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(y, x, x, x); }
        public readonly Vector4I27F5 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(y, x, x, y); }
        public readonly Vector4I27F5 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(y, x, y, x); }
        public readonly Vector4I27F5 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(y, x, y, y); }
        public readonly Vector4I27F5 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(y, y, x, x); }
        public readonly Vector4I27F5 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(y, y, x, y); }
        public readonly Vector4I27F5 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(y, y, y, x); }
        public readonly Vector4I27F5 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I27F5 lhs, Vector2I27F5 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I27F5 lhs, Vector2I27F5 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I27F5 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I27F5({x}, {y})";

        // IEquatable<Vector2I27F5>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I27F5 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I27F5({x}, {y})";
        }
    }
}
