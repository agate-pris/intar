using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I23F9 : IEquatable<Vector2I23F9>, IFormattable {
        // Fields
        // ---------------------------------------

        public I23F9 x;
        public I23F9 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I23F9 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I23F9(I23F9 x, I23F9 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I23F9(Vector2I23F9 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 operator +(Vector2I23F9 a, Vector2I23F9 b) => new Vector2I23F9(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 operator -(Vector2I23F9 a, Vector2I23F9 b) => new Vector2I23F9(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 operator *(Vector2I23F9 a, Vector2I23F9 b) => new Vector2I23F9(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 operator *(Vector2I23F9 a, I23F9 b) => new Vector2I23F9(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 operator *(I23F9 a, Vector2I23F9 b) => new Vector2I23F9(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 operator /(Vector2I23F9 a, Vector2I23F9 b) => new Vector2I23F9(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 operator /(Vector2I23F9 a, I23F9 b) => new Vector2I23F9(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 operator /(I23F9 a, Vector2I23F9 b) => new Vector2I23F9(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I23F9 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(x, x); }
        public readonly Vector2I23F9 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(x, y); }
        public readonly Vector2I23F9 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(y, x); }
        public readonly Vector2I23F9 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(y, y); }
        public readonly Vector3I23F9 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(x, x, x); }
        public readonly Vector3I23F9 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(x, x, y); }
        public readonly Vector3I23F9 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(x, y, x); }
        public readonly Vector3I23F9 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(x, y, y); }
        public readonly Vector3I23F9 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(y, x, x); }
        public readonly Vector3I23F9 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(y, x, y); }
        public readonly Vector3I23F9 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(y, y, x); }
        public readonly Vector3I23F9 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(y, y, y); }
        public readonly Vector4I23F9 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(x, x, x, x); }
        public readonly Vector4I23F9 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(x, x, x, y); }
        public readonly Vector4I23F9 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(x, x, y, x); }
        public readonly Vector4I23F9 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(x, x, y, y); }
        public readonly Vector4I23F9 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(x, y, x, x); }
        public readonly Vector4I23F9 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(x, y, x, y); }
        public readonly Vector4I23F9 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(x, y, y, x); }
        public readonly Vector4I23F9 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(x, y, y, y); }
        public readonly Vector4I23F9 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(y, x, x, x); }
        public readonly Vector4I23F9 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(y, x, x, y); }
        public readonly Vector4I23F9 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(y, x, y, x); }
        public readonly Vector4I23F9 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(y, x, y, y); }
        public readonly Vector4I23F9 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(y, y, x, x); }
        public readonly Vector4I23F9 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(y, y, x, y); }
        public readonly Vector4I23F9 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(y, y, y, x); }
        public readonly Vector4I23F9 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I23F9 lhs, Vector2I23F9 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I23F9 lhs, Vector2I23F9 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I23F9 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I23F9({x}, {y})";

        // IEquatable<Vector2I23F9>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I23F9 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I23F9({x}, {y})";
        }
    }
}
