using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U14F18 : IEquatable<Vector2U14F18>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U14F18 X;
        public U14F18 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18(U14F18 x, U14F18 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18(U14F18 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18(Vector2U14F18 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U14F18 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U14F18(U14F18.Zero);
        }
        public static Vector2U14F18 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U14F18(U14F18.One);
        }
        public static Vector2U14F18 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U14F18(U14F18.One, U14F18.Zero);
        }
        public static Vector2U14F18 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U14F18(U14F18.Zero, U14F18.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator +(Vector2U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator -(Vector2U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator *(Vector2U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator *(Vector2U14F18 a, U14F18 b) => new Vector2U14F18(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator *(U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator /(Vector2U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator /(Vector2U14F18 a, U14F18 b) => new Vector2U14F18(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator /(U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U14F18 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(X, X); }
        public readonly Vector2U14F18 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(X, Y); }
        public readonly Vector2U14F18 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(Y, X); }
        public readonly Vector2U14F18 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(Y, Y); }
        public readonly Vector3U14F18 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, X, X); }
        public readonly Vector3U14F18 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, X, Y); }
        public readonly Vector3U14F18 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, Y, X); }
        public readonly Vector3U14F18 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, Y, Y); }
        public readonly Vector3U14F18 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, X, X); }
        public readonly Vector3U14F18 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, X, Y); }
        public readonly Vector3U14F18 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, Y, X); }
        public readonly Vector3U14F18 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, Y, Y); }
        public readonly Vector4U14F18 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, X, X); }
        public readonly Vector4U14F18 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, X, Y); }
        public readonly Vector4U14F18 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, Y, X); }
        public readonly Vector4U14F18 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, Y, Y); }
        public readonly Vector4U14F18 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, X, X); }
        public readonly Vector4U14F18 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, X, Y); }
        public readonly Vector4U14F18 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, Y, X); }
        public readonly Vector4U14F18 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, Y, Y); }
        public readonly Vector4U14F18 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, X, X); }
        public readonly Vector4U14F18 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, X, Y); }
        public readonly Vector4U14F18 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, Y, X); }
        public readonly Vector4U14F18 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, Y, Y); }
        public readonly Vector4U14F18 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, X, X); }
        public readonly Vector4U14F18 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, X, Y); }
        public readonly Vector4U14F18 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, Y, X); }
        public readonly Vector4U14F18 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, Y, Y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U14F18 lhs, Vector2U14F18 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U14F18 lhs, Vector2U14F18 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U14F18 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U14F18>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U14F18 other)
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

        public readonly Vector2U14F18 Half() => new Vector2U14F18(
            X.Half(),
            Y.Half());

        public readonly Vector2U14F18 Twice() => new Vector2U14F18(
            X.Twice(),
            Y.Twice());

        public readonly Vector2U14F18 Clamp(U14F18 min, U14F18 max) => new Vector2U14F18(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2U14F18 Clamp(
            Vector2U14F18 min, Vector2U14F18 max
        ) => new Vector2U14F18(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

    }
}
