using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I31F1 : IEquatable<Vector2I31F1>, IFormattable {
        // Fields
        // ---------------------------------------

        public I31F1 x;
        public I31F1 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I31F1 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I31F1(I31F1 x, I31F1 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I31F1(Vector2I31F1 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 operator +(Vector2I31F1 a, Vector2I31F1 b) => new Vector2I31F1(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 operator -(Vector2I31F1 a, Vector2I31F1 b) => new Vector2I31F1(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 operator *(Vector2I31F1 a, Vector2I31F1 b) => new Vector2I31F1(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 operator *(Vector2I31F1 a, I31F1 b) => new Vector2I31F1(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 operator *(I31F1 a, Vector2I31F1 b) => new Vector2I31F1(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 operator /(Vector2I31F1 a, Vector2I31F1 b) => new Vector2I31F1(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 operator /(Vector2I31F1 a, I31F1 b) => new Vector2I31F1(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I31F1 operator /(I31F1 a, Vector2I31F1 b) => new Vector2I31F1(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I31F1 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(x, x); }
        public readonly Vector2I31F1 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(x, y); }
        public readonly Vector2I31F1 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(y, x); }
        public readonly Vector2I31F1 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I31F1(y, y); }
        public readonly Vector3I31F1 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, x, x); }
        public readonly Vector3I31F1 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, x, y); }
        public readonly Vector3I31F1 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, y, x); }
        public readonly Vector3I31F1 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(x, y, y); }
        public readonly Vector3I31F1 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, x, x); }
        public readonly Vector3I31F1 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, x, y); }
        public readonly Vector3I31F1 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, y, x); }
        public readonly Vector3I31F1 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I31F1(y, y, y); }
        public readonly Vector4I31F1 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, x, x); }
        public readonly Vector4I31F1 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, x, y); }
        public readonly Vector4I31F1 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, y, x); }
        public readonly Vector4I31F1 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, x, y, y); }
        public readonly Vector4I31F1 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, x, x); }
        public readonly Vector4I31F1 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, x, y); }
        public readonly Vector4I31F1 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, y, x); }
        public readonly Vector4I31F1 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(x, y, y, y); }
        public readonly Vector4I31F1 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, x, x); }
        public readonly Vector4I31F1 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, x, y); }
        public readonly Vector4I31F1 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, y, x); }
        public readonly Vector4I31F1 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, x, y, y); }
        public readonly Vector4I31F1 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, x, x); }
        public readonly Vector4I31F1 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, x, y); }
        public readonly Vector4I31F1 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, y, x); }
        public readonly Vector4I31F1 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I31F1(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I31F1 lhs, Vector2I31F1 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I31F1 lhs, Vector2I31F1 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I31F1 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I31F1({x}, {y})";

        // IEquatable<Vector2I31F1>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I31F1 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I31F1({x}, {y})";
        }
    }
}
