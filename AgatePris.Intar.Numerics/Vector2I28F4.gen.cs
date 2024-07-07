using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I28F4 : IEquatable<Vector2I28F4>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I28F4 X;
        public I28F4 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4(I28F4 x, I28F4 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4(I28F4 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4(Vector2I28F4 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I28F4 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I28F4(I28F4.Zero);
        }
        public static Vector2I28F4 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I28F4(I28F4.One);
        }
        public static Vector2I28F4 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I28F4(I28F4.One, I28F4.Zero);
        }
        public static Vector2I28F4 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I28F4(I28F4.Zero, I28F4.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator +(Vector2I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator -(Vector2I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator *(Vector2I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator *(Vector2I28F4 a, I28F4 b) => new Vector2I28F4(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator *(I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator /(Vector2I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator /(Vector2I28F4 a, I28F4 b) => new Vector2I28F4(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator /(I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I28F4 lhs, Vector2I28F4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I28F4 lhs, Vector2I28F4 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I28F4 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(X, X); }
        public readonly Vector2I28F4 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(X, Y); }
        public readonly Vector2I28F4 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Y, X); }
        public readonly Vector2I28F4 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Y, Y); }
        public readonly Vector3I28F4 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, X, X); }
        public readonly Vector3I28F4 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, X, Y); }
        public readonly Vector3I28F4 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Y, X); }
        public readonly Vector3I28F4 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Y, Y); }
        public readonly Vector3I28F4 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, X, X); }
        public readonly Vector3I28F4 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, X, Y); }
        public readonly Vector3I28F4 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Y, X); }
        public readonly Vector3I28F4 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Y, Y); }
        public readonly Vector4I28F4 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, X, X); }
        public readonly Vector4I28F4 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, X, Y); }
        public readonly Vector4I28F4 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Y, X); }
        public readonly Vector4I28F4 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Y, Y); }
        public readonly Vector4I28F4 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, X, X); }
        public readonly Vector4I28F4 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, X, Y); }
        public readonly Vector4I28F4 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Y, X); }
        public readonly Vector4I28F4 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Y, Y); }
        public readonly Vector4I28F4 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, X, X); }
        public readonly Vector4I28F4 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, X, Y); }
        public readonly Vector4I28F4 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Y, X); }
        public readonly Vector4I28F4 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Y, Y); }
        public readonly Vector4I28F4 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, X, X); }
        public readonly Vector4I28F4 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, X, Y); }
        public readonly Vector4I28F4 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Y, X); }
        public readonly Vector4I28F4 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I28F4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I28F4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I28F4 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"<{x}, {y}>";
        }

        // Methods
        // ---------------------------------------

        public readonly Vector2I28F4 Half() => new Vector2I28F4(
            X.Half(),
            Y.Half());

        public readonly Vector2I28F4 Twice() => new Vector2I28F4(
            X.Twice(),
            Y.Twice());

        public readonly Vector2I28F4 Clamp(I28F4 min, I28F4 max) => new Vector2I28F4(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2I28F4 Clamp(
            Vector2I28F4 min, Vector2I28F4 max
        ) => new Vector2I28F4(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I28F4 SaturatingAdd(Vector2I28F4 other) => new Vector2I28F4(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I28F4 SaturatingMul(I28F4 other) => new Vector2I28F4(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

    }

    partial struct I28F4 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I28F4 SaturatingMul(Vector2I28F4 other) => other.SaturatingMul(this);
    }
}
