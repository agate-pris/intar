using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U25F7 : IEquatable<Vector2U25F7>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U25F7 X;
        public U25F7 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U25F7(U25F7 x, U25F7 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U25F7(U25F7 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U25F7(Vector2U25F7 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U25F7 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U25F7(U25F7.Zero);
        }
        public static Vector2U25F7 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U25F7(U25F7.One);
        }
        public static Vector2U25F7 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U25F7(U25F7.One, U25F7.Zero);
        }
        public static Vector2U25F7 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U25F7(U25F7.Zero, U25F7.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 operator +(Vector2U25F7 a, Vector2U25F7 b) => new Vector2U25F7(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 operator -(Vector2U25F7 a, Vector2U25F7 b) => new Vector2U25F7(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 operator *(Vector2U25F7 a, Vector2U25F7 b) => new Vector2U25F7(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 operator *(Vector2U25F7 a, U25F7 b) => new Vector2U25F7(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 operator *(U25F7 a, Vector2U25F7 b) => new Vector2U25F7(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 operator /(Vector2U25F7 a, Vector2U25F7 b) => new Vector2U25F7(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 operator /(Vector2U25F7 a, U25F7 b) => new Vector2U25F7(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U25F7 operator /(U25F7 a, Vector2U25F7 b) => new Vector2U25F7(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U25F7 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(X, X); }
        public readonly Vector2U25F7 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(X, Y); }
        public readonly Vector2U25F7 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Y, X); }
        public readonly Vector2U25F7 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U25F7(Y, Y); }
        public readonly Vector3U25F7 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, X, X); }
        public readonly Vector3U25F7 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, X, Y); }
        public readonly Vector3U25F7 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Y, X); }
        public readonly Vector3U25F7 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(X, Y, Y); }
        public readonly Vector3U25F7 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, X, X); }
        public readonly Vector3U25F7 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, X, Y); }
        public readonly Vector3U25F7 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Y, X); }
        public readonly Vector3U25F7 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U25F7(Y, Y, Y); }
        public readonly Vector4U25F7 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, X, X); }
        public readonly Vector4U25F7 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, X, Y); }
        public readonly Vector4U25F7 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Y, X); }
        public readonly Vector4U25F7 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, X, Y, Y); }
        public readonly Vector4U25F7 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, X, X); }
        public readonly Vector4U25F7 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, X, Y); }
        public readonly Vector4U25F7 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Y, X); }
        public readonly Vector4U25F7 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(X, Y, Y, Y); }
        public readonly Vector4U25F7 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, X, X); }
        public readonly Vector4U25F7 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, X, Y); }
        public readonly Vector4U25F7 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Y, X); }
        public readonly Vector4U25F7 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, X, Y, Y); }
        public readonly Vector4U25F7 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, X, X); }
        public readonly Vector4U25F7 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, X, Y); }
        public readonly Vector4U25F7 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Y, X); }
        public readonly Vector4U25F7 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U25F7(Y, Y, Y, Y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U25F7 lhs, Vector2U25F7 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U25F7 lhs, Vector2U25F7 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U25F7 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U25F7({X}, {Y})";

        // IEquatable<Vector2U25F7>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U25F7 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U25F7({x}, {y})";
        }

        // Methods
        // ---------------------------------------

        public readonly Vector2U25F7 Half() => new Vector2U25F7(
            X.Half(),
            Y.Half());

        public readonly Vector2U25F7 Twice() => new Vector2U25F7(
            X.Twice(),
            Y.Twice());

        public readonly Vector2U25F7 Clamp(U25F7 min, U25F7 max) => new Vector2U25F7(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2U25F7 Clamp(
            Vector2U25F7 min, Vector2U25F7 max
        ) => new Vector2U25F7(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

    }
}
