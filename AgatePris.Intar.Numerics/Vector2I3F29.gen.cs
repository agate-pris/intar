using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I3F29 : IEquatable<Vector2I3F29>, IFormattable {
        // Fields
        // ---------------------------------------

        public I3F29 x;
        public I3F29 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I3F29 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I3F29(I3F29 x, I3F29 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I3F29(Vector2I3F29 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 operator +(Vector2I3F29 a, Vector2I3F29 b) => new Vector2I3F29(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 operator -(Vector2I3F29 a, Vector2I3F29 b) => new Vector2I3F29(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 operator *(Vector2I3F29 a, Vector2I3F29 b) => new Vector2I3F29(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 operator *(Vector2I3F29 a, I3F29 b) => new Vector2I3F29(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 operator *(I3F29 a, Vector2I3F29 b) => new Vector2I3F29(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 operator /(Vector2I3F29 a, Vector2I3F29 b) => new Vector2I3F29(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 operator /(Vector2I3F29 a, I3F29 b) => new Vector2I3F29(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 operator /(I3F29 a, Vector2I3F29 b) => new Vector2I3F29(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I3F29 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(x, x); }
        public readonly Vector2I3F29 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(x, y); }
        public readonly Vector2I3F29 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(y, x); }
        public readonly Vector2I3F29 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(y, y); }
        public readonly Vector3I3F29 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, x, x); }
        public readonly Vector3I3F29 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, x, y); }
        public readonly Vector3I3F29 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, y, x); }
        public readonly Vector3I3F29 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(x, y, y); }
        public readonly Vector3I3F29 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, x, x); }
        public readonly Vector3I3F29 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, x, y); }
        public readonly Vector3I3F29 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, y, x); }
        public readonly Vector3I3F29 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(y, y, y); }
        public readonly Vector4I3F29 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, x, x); }
        public readonly Vector4I3F29 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, x, y); }
        public readonly Vector4I3F29 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, y, x); }
        public readonly Vector4I3F29 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, x, y, y); }
        public readonly Vector4I3F29 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, x, x); }
        public readonly Vector4I3F29 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, x, y); }
        public readonly Vector4I3F29 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, y, x); }
        public readonly Vector4I3F29 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(x, y, y, y); }
        public readonly Vector4I3F29 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, x, x); }
        public readonly Vector4I3F29 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, x, y); }
        public readonly Vector4I3F29 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, y, x); }
        public readonly Vector4I3F29 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, x, y, y); }
        public readonly Vector4I3F29 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, x, x); }
        public readonly Vector4I3F29 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, x, y); }
        public readonly Vector4I3F29 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, y, x); }
        public readonly Vector4I3F29 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I3F29 lhs, Vector2I3F29 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I3F29 lhs, Vector2I3F29 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I3F29 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I3F29({x}, {y})";

        // IEquatable<Vector2I3F29>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I3F29 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I3F29({x}, {y})";
        }
    }
}
