using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I8F24 : IEquatable<Vector2I8F24>, IFormattable {
        // Fields
        // ---------------------------------------

        public I8F24 x;
        public I8F24 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I8F24 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I8F24(I8F24 x, I8F24 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I8F24(Vector2I8F24 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 operator +(Vector2I8F24 a, Vector2I8F24 b) => new Vector2I8F24(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 operator -(Vector2I8F24 a, Vector2I8F24 b) => new Vector2I8F24(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 operator *(Vector2I8F24 a, Vector2I8F24 b) => new Vector2I8F24(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 operator *(Vector2I8F24 a, I8F24 b) => new Vector2I8F24(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 operator *(I8F24 a, Vector2I8F24 b) => new Vector2I8F24(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 operator /(Vector2I8F24 a, Vector2I8F24 b) => new Vector2I8F24(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 operator /(Vector2I8F24 a, I8F24 b) => new Vector2I8F24(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 operator /(I8F24 a, Vector2I8F24 b) => new Vector2I8F24(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I8F24 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(x, x); }
        public readonly Vector2I8F24 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(x, y); }
        public readonly Vector2I8F24 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(y, x); }
        public readonly Vector2I8F24 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(y, y); }
        public readonly Vector3I8F24 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, x, x); }
        public readonly Vector3I8F24 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, x, y); }
        public readonly Vector3I8F24 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, y, x); }
        public readonly Vector3I8F24 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(x, y, y); }
        public readonly Vector3I8F24 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, x, x); }
        public readonly Vector3I8F24 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, x, y); }
        public readonly Vector3I8F24 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, y, x); }
        public readonly Vector3I8F24 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(y, y, y); }
        public readonly Vector4I8F24 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, x, x); }
        public readonly Vector4I8F24 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, x, y); }
        public readonly Vector4I8F24 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, y, x); }
        public readonly Vector4I8F24 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, x, y, y); }
        public readonly Vector4I8F24 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, x, x); }
        public readonly Vector4I8F24 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, x, y); }
        public readonly Vector4I8F24 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, y, x); }
        public readonly Vector4I8F24 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(x, y, y, y); }
        public readonly Vector4I8F24 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, x, x); }
        public readonly Vector4I8F24 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, x, y); }
        public readonly Vector4I8F24 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, y, x); }
        public readonly Vector4I8F24 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, x, y, y); }
        public readonly Vector4I8F24 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, x, x); }
        public readonly Vector4I8F24 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, x, y); }
        public readonly Vector4I8F24 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, y, x); }
        public readonly Vector4I8F24 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I8F24 lhs, Vector2I8F24 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I8F24 lhs, Vector2I8F24 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I8F24 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I8F24({x}, {y})";

        // IEquatable<Vector2I8F24>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I8F24 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I8F24({x}, {y})";
        }
    }
}
