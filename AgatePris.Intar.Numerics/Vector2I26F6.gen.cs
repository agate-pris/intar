using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I26F6 : IEquatable<Vector2I26F6>, IFormattable {
        // Fields
        // ---------------------------------------

        public I26F6 x;
        public I26F6 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I26F6 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I26F6(I26F6 x, I26F6 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I26F6(Vector2I26F6 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator +(Vector2I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator -(Vector2I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator *(Vector2I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator *(Vector2I26F6 a, I26F6 b) => new Vector2I26F6(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator *(I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator /(Vector2I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator /(Vector2I26F6 a, I26F6 b) => new Vector2I26F6(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator /(I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I26F6 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(x, x); }
        public readonly Vector2I26F6 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(x, y); }
        public readonly Vector2I26F6 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(y, x); }
        public readonly Vector2I26F6 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(y, y); }
        public readonly Vector3I26F6 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, x, x); }
        public readonly Vector3I26F6 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, x, y); }
        public readonly Vector3I26F6 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, y, x); }
        public readonly Vector3I26F6 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(x, y, y); }
        public readonly Vector3I26F6 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, x, x); }
        public readonly Vector3I26F6 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, x, y); }
        public readonly Vector3I26F6 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, y, x); }
        public readonly Vector3I26F6 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(y, y, y); }
        public readonly Vector4I26F6 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, x, x); }
        public readonly Vector4I26F6 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, x, y); }
        public readonly Vector4I26F6 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, y, x); }
        public readonly Vector4I26F6 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, x, y, y); }
        public readonly Vector4I26F6 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, x, x); }
        public readonly Vector4I26F6 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, x, y); }
        public readonly Vector4I26F6 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, y, x); }
        public readonly Vector4I26F6 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(x, y, y, y); }
        public readonly Vector4I26F6 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, x, x); }
        public readonly Vector4I26F6 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, x, y); }
        public readonly Vector4I26F6 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, y, x); }
        public readonly Vector4I26F6 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, x, y, y); }
        public readonly Vector4I26F6 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, x, x); }
        public readonly Vector4I26F6 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, x, y); }
        public readonly Vector4I26F6 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, y, x); }
        public readonly Vector4I26F6 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I26F6 lhs, Vector2I26F6 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I26F6 lhs, Vector2I26F6 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I26F6 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I26F6({x}, {y})";

        // IEquatable<Vector2I26F6>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I26F6 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I26F6({x}, {y})";
        }
    }
}
