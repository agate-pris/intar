using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I20F12 : IEquatable<Vector2I20F12>, IFormattable {
        // Fields
        // ---------------------------------------

        public I20F12 x;
        public I20F12 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I20F12 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I20F12(I20F12 x, I20F12 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I20F12(Vector2I20F12 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 operator +(Vector2I20F12 a, Vector2I20F12 b) => new Vector2I20F12(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 operator -(Vector2I20F12 a, Vector2I20F12 b) => new Vector2I20F12(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 operator *(Vector2I20F12 a, Vector2I20F12 b) => new Vector2I20F12(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 operator *(Vector2I20F12 a, I20F12 b) => new Vector2I20F12(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 operator *(I20F12 a, Vector2I20F12 b) => new Vector2I20F12(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 operator /(Vector2I20F12 a, Vector2I20F12 b) => new Vector2I20F12(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 operator /(Vector2I20F12 a, I20F12 b) => new Vector2I20F12(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 operator /(I20F12 a, Vector2I20F12 b) => new Vector2I20F12(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I20F12 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(x, x); }
        public readonly Vector2I20F12 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(x, y); }
        public readonly Vector2I20F12 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(y, x); }
        public readonly Vector2I20F12 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(y, y); }
        public readonly Vector3I20F12 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(x, x, x); }
        public readonly Vector3I20F12 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(x, x, y); }
        public readonly Vector3I20F12 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(x, y, x); }
        public readonly Vector3I20F12 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(x, y, y); }
        public readonly Vector3I20F12 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(y, x, x); }
        public readonly Vector3I20F12 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(y, x, y); }
        public readonly Vector3I20F12 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(y, y, x); }
        public readonly Vector3I20F12 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(y, y, y); }
        public readonly Vector4I20F12 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(x, x, x, x); }
        public readonly Vector4I20F12 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(x, x, x, y); }
        public readonly Vector4I20F12 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(x, x, y, x); }
        public readonly Vector4I20F12 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(x, x, y, y); }
        public readonly Vector4I20F12 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(x, y, x, x); }
        public readonly Vector4I20F12 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(x, y, x, y); }
        public readonly Vector4I20F12 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(x, y, y, x); }
        public readonly Vector4I20F12 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(x, y, y, y); }
        public readonly Vector4I20F12 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(y, x, x, x); }
        public readonly Vector4I20F12 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(y, x, x, y); }
        public readonly Vector4I20F12 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(y, x, y, x); }
        public readonly Vector4I20F12 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(y, x, y, y); }
        public readonly Vector4I20F12 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(y, y, x, x); }
        public readonly Vector4I20F12 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(y, y, x, y); }
        public readonly Vector4I20F12 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(y, y, y, x); }
        public readonly Vector4I20F12 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I20F12 lhs, Vector2I20F12 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I20F12 lhs, Vector2I20F12 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I20F12 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I20F12({x}, {y})";

        // IEquatable<Vector2I20F12>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I20F12 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I20F12({x}, {y})";
        }
    }
}
