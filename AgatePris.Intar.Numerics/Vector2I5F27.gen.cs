using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I5F27 : IEquatable<Vector2I5F27>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I5F27 X;
        public I5F27 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I5F27(I5F27 x, I5F27 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I5F27(I5F27 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I5F27(Vector2I5F27 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I5F27 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I5F27(I5F27.Zero);
        }
        public static Vector2I5F27 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I5F27(I5F27.One);
        }
        public static Vector2I5F27 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I5F27(I5F27.One, I5F27.Zero);
        }
        public static Vector2I5F27 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I5F27(I5F27.Zero, I5F27.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 operator +(Vector2I5F27 a, Vector2I5F27 b) => new Vector2I5F27(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 operator -(Vector2I5F27 a, Vector2I5F27 b) => new Vector2I5F27(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 operator *(Vector2I5F27 a, Vector2I5F27 b) => new Vector2I5F27(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 operator *(Vector2I5F27 a, I5F27 b) => new Vector2I5F27(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 operator *(I5F27 a, Vector2I5F27 b) => new Vector2I5F27(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 operator /(Vector2I5F27 a, Vector2I5F27 b) => new Vector2I5F27(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 operator /(Vector2I5F27 a, I5F27 b) => new Vector2I5F27(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I5F27 operator /(I5F27 a, Vector2I5F27 b) => new Vector2I5F27(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I5F27 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(X, X); }
        public readonly Vector2I5F27 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(X, Y); }
        public readonly Vector2I5F27 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Y, X); }
        public readonly Vector2I5F27 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I5F27(Y, Y); }
        public readonly Vector3I5F27 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, X, X); }
        public readonly Vector3I5F27 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, X, Y); }
        public readonly Vector3I5F27 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Y, X); }
        public readonly Vector3I5F27 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(X, Y, Y); }
        public readonly Vector3I5F27 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, X, X); }
        public readonly Vector3I5F27 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, X, Y); }
        public readonly Vector3I5F27 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Y, X); }
        public readonly Vector3I5F27 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I5F27(Y, Y, Y); }
        public readonly Vector4I5F27 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, X, X); }
        public readonly Vector4I5F27 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, X, Y); }
        public readonly Vector4I5F27 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Y, X); }
        public readonly Vector4I5F27 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, X, Y, Y); }
        public readonly Vector4I5F27 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, X, X); }
        public readonly Vector4I5F27 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, X, Y); }
        public readonly Vector4I5F27 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Y, X); }
        public readonly Vector4I5F27 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(X, Y, Y, Y); }
        public readonly Vector4I5F27 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, X, X); }
        public readonly Vector4I5F27 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, X, Y); }
        public readonly Vector4I5F27 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Y, X); }
        public readonly Vector4I5F27 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, X, Y, Y); }
        public readonly Vector4I5F27 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, X, X); }
        public readonly Vector4I5F27 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, X, Y); }
        public readonly Vector4I5F27 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Y, X); }
        public readonly Vector4I5F27 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I5F27(Y, Y, Y, Y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I5F27 lhs, Vector2I5F27 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I5F27 lhs, Vector2I5F27 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I5F27 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I5F27>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I5F27 other)
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

        public readonly Vector2I5F27 Half() => new Vector2I5F27(
            X.Half(),
            Y.Half());

        public readonly Vector2I5F27 Twice() => new Vector2I5F27(
            X.Twice(),
            Y.Twice());

        public readonly Vector2I5F27 Clamp(I5F27 min, I5F27 max) => new Vector2I5F27(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2I5F27 Clamp(
            Vector2I5F27 min, Vector2I5F27 max
        ) => new Vector2I5F27(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I5F27 SaturatingAdd(Vector2I5F27 other) => new Vector2I5F27(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I5F27 SaturatingMul(I5F27 other) => new Vector2I5F27(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

    }
}
