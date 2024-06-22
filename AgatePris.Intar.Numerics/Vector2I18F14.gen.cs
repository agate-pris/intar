using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I18F14 : IEquatable<Vector2I18F14>, IFormattable {
        // Fields
        // ---------------------------------------

        public I18F14 x;
        public I18F14 y;

        // Constants
        // ---------------------------------------

        public static readonly Vector2I18F14 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14(I18F14 x, I18F14 y) {
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14(Vector2I18F14 xy) {
            x = xy.x;
            y = xy.y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator +(Vector2I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a.x + b.x,
            a.y + b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator -(Vector2I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a.x - b.x,
            a.y - b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator *(Vector2I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a.x * b.x,
            a.y * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator *(Vector2I18F14 a, I18F14 b) => new Vector2I18F14(
            a.x * b,
            a.y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator *(I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a * b.x,
            a * b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator /(Vector2I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a.x / b.x,
            a.y / b.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator /(Vector2I18F14 a, I18F14 b) => new Vector2I18F14(
            a.x / b,
            a.y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator /(I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a / b.x,
            a / b.y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I18F14 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(x, x); }
        public readonly Vector2I18F14 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(x, y); }
        public readonly Vector2I18F14 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(y, x); }
        public readonly Vector2I18F14 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(y, y); }
        public readonly Vector3I18F14 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(x, x, x); }
        public readonly Vector3I18F14 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(x, x, y); }
        public readonly Vector3I18F14 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(x, y, x); }
        public readonly Vector3I18F14 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(x, y, y); }
        public readonly Vector3I18F14 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(y, x, x); }
        public readonly Vector3I18F14 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(y, x, y); }
        public readonly Vector3I18F14 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(y, y, x); }
        public readonly Vector3I18F14 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(y, y, y); }
        public readonly Vector4I18F14 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(x, x, x, x); }
        public readonly Vector4I18F14 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(x, x, x, y); }
        public readonly Vector4I18F14 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(x, x, y, x); }
        public readonly Vector4I18F14 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(x, x, y, y); }
        public readonly Vector4I18F14 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(x, y, x, x); }
        public readonly Vector4I18F14 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(x, y, x, y); }
        public readonly Vector4I18F14 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(x, y, y, x); }
        public readonly Vector4I18F14 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(x, y, y, y); }
        public readonly Vector4I18F14 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(y, x, x, x); }
        public readonly Vector4I18F14 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(y, x, x, y); }
        public readonly Vector4I18F14 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(y, x, y, x); }
        public readonly Vector4I18F14 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(y, x, y, y); }
        public readonly Vector4I18F14 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(y, y, x, x); }
        public readonly Vector4I18F14 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(y, y, x, y); }
        public readonly Vector4I18F14 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(y, y, y, x); }
        public readonly Vector4I18F14 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(y, y, y, y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I18F14 lhs, Vector2I18F14 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I18F14 lhs, Vector2I18F14 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I18F14 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I18F14({x}, {y})";

        // IEquatable<Vector2I18F14>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I18F14 other)
            => other.x == x
            && other.y == y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = this.x.ToString(format, formatProvider);
            var y = this.y.ToString(format, formatProvider);
            return $"Vector2I18F14({x}, {y})";
        }
    }
}
