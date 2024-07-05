using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U27F5 : IEquatable<Vector2U27F5>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U27F5 X;
        public U27F5 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U27F5(U27F5 x, U27F5 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U27F5(U27F5 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U27F5(Vector2U27F5 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U27F5 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U27F5(U27F5.Zero);
        }
        public static Vector2U27F5 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U27F5(U27F5.One);
        }
        public static Vector2U27F5 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U27F5(U27F5.One, U27F5.Zero);
        }
        public static Vector2U27F5 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U27F5(U27F5.Zero, U27F5.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 operator +(Vector2U27F5 a, Vector2U27F5 b) => new Vector2U27F5(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 operator -(Vector2U27F5 a, Vector2U27F5 b) => new Vector2U27F5(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 operator *(Vector2U27F5 a, Vector2U27F5 b) => new Vector2U27F5(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 operator *(Vector2U27F5 a, U27F5 b) => new Vector2U27F5(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 operator *(U27F5 a, Vector2U27F5 b) => new Vector2U27F5(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 operator /(Vector2U27F5 a, Vector2U27F5 b) => new Vector2U27F5(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 operator /(Vector2U27F5 a, U27F5 b) => new Vector2U27F5(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U27F5 operator /(U27F5 a, Vector2U27F5 b) => new Vector2U27F5(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U27F5 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(X, X); }
        public readonly Vector2U27F5 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(X, Y); }
        public readonly Vector2U27F5 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(Y, X); }
        public readonly Vector2U27F5 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U27F5(Y, Y); }
        public readonly Vector3U27F5 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, X, X); }
        public readonly Vector3U27F5 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, X, Y); }
        public readonly Vector3U27F5 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, Y, X); }
        public readonly Vector3U27F5 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(X, Y, Y); }
        public readonly Vector3U27F5 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, X, X); }
        public readonly Vector3U27F5 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, X, Y); }
        public readonly Vector3U27F5 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, Y, X); }
        public readonly Vector3U27F5 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U27F5(Y, Y, Y); }
        public readonly Vector4U27F5 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, X, X); }
        public readonly Vector4U27F5 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, X, Y); }
        public readonly Vector4U27F5 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, Y, X); }
        public readonly Vector4U27F5 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, X, Y, Y); }
        public readonly Vector4U27F5 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, X, X); }
        public readonly Vector4U27F5 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, X, Y); }
        public readonly Vector4U27F5 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, Y, X); }
        public readonly Vector4U27F5 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(X, Y, Y, Y); }
        public readonly Vector4U27F5 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, X, X); }
        public readonly Vector4U27F5 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, X, Y); }
        public readonly Vector4U27F5 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, Y, X); }
        public readonly Vector4U27F5 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, X, Y, Y); }
        public readonly Vector4U27F5 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, X, X); }
        public readonly Vector4U27F5 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, X, Y); }
        public readonly Vector4U27F5 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, Y, X); }
        public readonly Vector4U27F5 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U27F5(Y, Y, Y, Y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U27F5 lhs, Vector2U27F5 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U27F5 lhs, Vector2U27F5 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U27F5 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U27F5>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U27F5 other)
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

        public readonly Vector2U27F5 Half() => new Vector2U27F5(
            X.Half(),
            Y.Half());

        public readonly Vector2U27F5 Twice() => new Vector2U27F5(
            X.Twice(),
            Y.Twice());

        public readonly Vector2U27F5 Clamp(U27F5 min, U27F5 max) => new Vector2U27F5(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2U27F5 Clamp(
            Vector2U27F5 min, Vector2U27F5 max
        ) => new Vector2U27F5(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U27F5 SaturatingAdd(Vector2U27F5 other) => new Vector2U27F5(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

    }
}
