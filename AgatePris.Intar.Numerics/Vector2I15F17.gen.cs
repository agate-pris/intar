using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I15F17 : IEquatable<Vector2I15F17>, IFormattable {
        // Fields
        // ---------------------------------------

        public I15F17 x;
        public I15F17 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I15F17 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I15F17(I15F17 x, I15F17 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I15F17(Vector2I15F17 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 operator +(Vector2I15F17 a, Vector2I15F17 b) => new Vector2I15F17(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 operator -(Vector2I15F17 a, Vector2I15F17 b) => new Vector2I15F17(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 operator *(Vector2I15F17 a, Vector2I15F17 b) => new Vector2I15F17(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 operator *(Vector2I15F17 a, I15F17 b) => new Vector2I15F17(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 operator *(I15F17 a, Vector2I15F17 b) => new Vector2I15F17(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 operator /(Vector2I15F17 a, Vector2I15F17 b) => new Vector2I15F17(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 operator /(Vector2I15F17 a, I15F17 b) => new Vector2I15F17(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I15F17 operator /(I15F17 a, Vector2I15F17 b) => new Vector2I15F17(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I15F17 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(x, x); }
        public readonly Vector2I15F17 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(x, y); }
        public readonly Vector2I15F17 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(y, x); }
        public readonly Vector2I15F17 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I15F17(y, y); }
        public readonly Vector3I15F17 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, x, x); }
        public readonly Vector3I15F17 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, x, y); }
        public readonly Vector3I15F17 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, y, x); }
        public readonly Vector3I15F17 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(x, y, y); }
        public readonly Vector3I15F17 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, x, x); }
        public readonly Vector3I15F17 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, x, y); }
        public readonly Vector3I15F17 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, y, x); }
        public readonly Vector3I15F17 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I15F17(y, y, y); }
        public readonly Vector4I15F17 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, x, x); }
        public readonly Vector4I15F17 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, x, y); }
        public readonly Vector4I15F17 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, y, x); }
        public readonly Vector4I15F17 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, x, y, y); }
        public readonly Vector4I15F17 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, x, x); }
        public readonly Vector4I15F17 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, x, y); }
        public readonly Vector4I15F17 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, y, x); }
        public readonly Vector4I15F17 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(x, y, y, y); }
        public readonly Vector4I15F17 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, x, x); }
        public readonly Vector4I15F17 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, x, y); }
        public readonly Vector4I15F17 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, y, x); }
        public readonly Vector4I15F17 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, x, y, y); }
        public readonly Vector4I15F17 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, x, x); }
        public readonly Vector4I15F17 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, x, y); }
        public readonly Vector4I15F17 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, y, x); }
        public readonly Vector4I15F17 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I15F17(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I15F17 lhs, Vector2I15F17 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I15F17 lhs, Vector2I15F17 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I15F17 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I15F17({x}, {y})";

        // IEquatable<Vector2I15F17>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I15F17 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I15F17({x}, {y})";
        }
    }
}
