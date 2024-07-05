using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U31F1 : IEquatable<Vector2U31F1>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U31F1 X;
        public U31F1 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U31F1(U31F1 x, U31F1 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U31F1(U31F1 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U31F1(Vector2U31F1 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U31F1 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U31F1(U31F1.Zero);
        }
        public static Vector2U31F1 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U31F1(U31F1.One);
        }
        public static Vector2U31F1 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U31F1(U31F1.One, U31F1.Zero);
        }
        public static Vector2U31F1 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U31F1(U31F1.Zero, U31F1.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 operator +(Vector2U31F1 a, Vector2U31F1 b) => new Vector2U31F1(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 operator -(Vector2U31F1 a, Vector2U31F1 b) => new Vector2U31F1(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 operator *(Vector2U31F1 a, Vector2U31F1 b) => new Vector2U31F1(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 operator *(Vector2U31F1 a, U31F1 b) => new Vector2U31F1(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 operator *(U31F1 a, Vector2U31F1 b) => new Vector2U31F1(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 operator /(Vector2U31F1 a, Vector2U31F1 b) => new Vector2U31F1(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 operator /(Vector2U31F1 a, U31F1 b) => new Vector2U31F1(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 operator /(U31F1 a, Vector2U31F1 b) => new Vector2U31F1(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U31F1 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(X, X); }
        public readonly Vector2U31F1 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(X, Y); }
        public readonly Vector2U31F1 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(Y, X); }
        public readonly Vector2U31F1 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(Y, Y); }
        public readonly Vector3U31F1 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, X, X); }
        public readonly Vector3U31F1 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, X, Y); }
        public readonly Vector3U31F1 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, Y, X); }
        public readonly Vector3U31F1 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, Y, Y); }
        public readonly Vector3U31F1 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, X, X); }
        public readonly Vector3U31F1 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, X, Y); }
        public readonly Vector3U31F1 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, Y, X); }
        public readonly Vector3U31F1 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, Y, Y); }
        public readonly Vector4U31F1 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, X, X); }
        public readonly Vector4U31F1 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, X, Y); }
        public readonly Vector4U31F1 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, Y, X); }
        public readonly Vector4U31F1 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, Y, Y); }
        public readonly Vector4U31F1 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, X, X); }
        public readonly Vector4U31F1 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, X, Y); }
        public readonly Vector4U31F1 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, Y, X); }
        public readonly Vector4U31F1 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, Y, Y); }
        public readonly Vector4U31F1 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, X, X); }
        public readonly Vector4U31F1 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, X, Y); }
        public readonly Vector4U31F1 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, Y, X); }
        public readonly Vector4U31F1 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, Y, Y); }
        public readonly Vector4U31F1 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, X, X); }
        public readonly Vector4U31F1 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, X, Y); }
        public readonly Vector4U31F1 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, Y, X); }
        public readonly Vector4U31F1 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, Y, Y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U31F1 lhs, Vector2U31F1 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U31F1 lhs, Vector2U31F1 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U31F1 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U31F1>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U31F1 other)
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

        public readonly Vector2U31F1 Half() => new Vector2U31F1(
            X.Half(),
            Y.Half());

        public readonly Vector2U31F1 Twice() => new Vector2U31F1(
            X.Twice(),
            Y.Twice());

        public readonly Vector2U31F1 Clamp(U31F1 min, U31F1 max) => new Vector2U31F1(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2U31F1 Clamp(
            Vector2U31F1 min, Vector2U31F1 max
        ) => new Vector2U31F1(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U31F1 SaturatingAdd(Vector2U31F1 other) => new Vector2U31F1(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

    }
}
