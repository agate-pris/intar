using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I4F28 : IEquatable<Vector2I4F28>, IFormattable {
        // Fields
        // ---------------------------------------

        public I4F28 x;
        public I4F28 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I4F28 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28(I4F28 x, I4F28 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28(Vector2I4F28 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 operator +(Vector2I4F28 a, Vector2I4F28 b) => new Vector2I4F28(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 operator -(Vector2I4F28 a, Vector2I4F28 b) => new Vector2I4F28(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 operator *(Vector2I4F28 a, Vector2I4F28 b) => new Vector2I4F28(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 operator *(Vector2I4F28 a, I4F28 b) => new Vector2I4F28(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 operator *(I4F28 a, Vector2I4F28 b) => new Vector2I4F28(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 operator /(Vector2I4F28 a, Vector2I4F28 b) => new Vector2I4F28(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 operator /(Vector2I4F28 a, I4F28 b) => new Vector2I4F28(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 operator /(I4F28 a, Vector2I4F28 b) => new Vector2I4F28(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I4F28 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(x, x); }
        public readonly Vector2I4F28 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(x, y); }
        public readonly Vector2I4F28 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(y, x); }
        public readonly Vector2I4F28 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(y, y); }
        public readonly Vector3I4F28 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, x, x); }
        public readonly Vector3I4F28 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, x, y); }
        public readonly Vector3I4F28 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, y, x); }
        public readonly Vector3I4F28 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(x, y, y); }
        public readonly Vector3I4F28 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, x, x); }
        public readonly Vector3I4F28 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, x, y); }
        public readonly Vector3I4F28 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, y, x); }
        public readonly Vector3I4F28 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(y, y, y); }
        public readonly Vector4I4F28 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, x, x); }
        public readonly Vector4I4F28 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, x, y); }
        public readonly Vector4I4F28 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, y, x); }
        public readonly Vector4I4F28 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, x, y, y); }
        public readonly Vector4I4F28 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, x, x); }
        public readonly Vector4I4F28 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, x, y); }
        public readonly Vector4I4F28 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, y, x); }
        public readonly Vector4I4F28 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(x, y, y, y); }
        public readonly Vector4I4F28 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, x, x); }
        public readonly Vector4I4F28 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, x, y); }
        public readonly Vector4I4F28 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, y, x); }
        public readonly Vector4I4F28 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, x, y, y); }
        public readonly Vector4I4F28 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, x, x); }
        public readonly Vector4I4F28 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, x, y); }
        public readonly Vector4I4F28 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, y, x); }
        public readonly Vector4I4F28 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I4F28 lhs, Vector2I4F28 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I4F28 lhs, Vector2I4F28 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I4F28 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I4F28({x}, {y})";

        // IEquatable<Vector2I4F28>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I4F28 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I4F28({x}, {y})";
        }
    }
}
