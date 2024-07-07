using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U17F15 : IEquatable<Vector2U17F15>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U17F15 X;
        public U17F15 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15(U17F15 x, U17F15 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15(U17F15 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15(Vector2U17F15 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U17F15 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U17F15(U17F15.Zero);
        }
        public static Vector2U17F15 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U17F15(U17F15.One);
        }
        public static Vector2U17F15 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U17F15(U17F15.One, U17F15.Zero);
        }
        public static Vector2U17F15 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U17F15(U17F15.Zero, U17F15.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator +(Vector2U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator -(Vector2U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator *(Vector2U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator *(Vector2U17F15 a, U17F15 b) => new Vector2U17F15(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator *(U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator /(Vector2U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator /(Vector2U17F15 a, U17F15 b) => new Vector2U17F15(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator /(U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U17F15 lhs, Vector2U17F15 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U17F15 lhs, Vector2U17F15 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U17F15 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(X, X); }
        public readonly Vector2U17F15 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(X, Y); }
        public readonly Vector2U17F15 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Y, X); }
        public readonly Vector2U17F15 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Y, Y); }
        public readonly Vector3U17F15 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, X, X); }
        public readonly Vector3U17F15 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, X, Y); }
        public readonly Vector3U17F15 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Y, X); }
        public readonly Vector3U17F15 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Y, Y); }
        public readonly Vector3U17F15 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, X, X); }
        public readonly Vector3U17F15 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, X, Y); }
        public readonly Vector3U17F15 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Y, X); }
        public readonly Vector3U17F15 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Y, Y); }
        public readonly Vector4U17F15 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, X, X); }
        public readonly Vector4U17F15 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, X, Y); }
        public readonly Vector4U17F15 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Y, X); }
        public readonly Vector4U17F15 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Y, Y); }
        public readonly Vector4U17F15 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, X, X); }
        public readonly Vector4U17F15 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, X, Y); }
        public readonly Vector4U17F15 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Y, X); }
        public readonly Vector4U17F15 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Y, Y); }
        public readonly Vector4U17F15 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, X, X); }
        public readonly Vector4U17F15 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, X, Y); }
        public readonly Vector4U17F15 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Y, X); }
        public readonly Vector4U17F15 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Y, Y); }
        public readonly Vector4U17F15 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, X, X); }
        public readonly Vector4U17F15 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, X, Y); }
        public readonly Vector4U17F15 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Y, X); }
        public readonly Vector4U17F15 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U17F15 other)
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

        public readonly Vector2U17F15 Half() => new Vector2U17F15(
            X.Half(),
            Y.Half());

        public readonly Vector2U17F15 Twice() => new Vector2U17F15(
            X.Twice(),
            Y.Twice());

        public readonly Vector2U17F15 Clamp(U17F15 min, U17F15 max) => new Vector2U17F15(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2U17F15 Clamp(
            Vector2U17F15 min, Vector2U17F15 max
        ) => new Vector2U17F15(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U17F15 SaturatingAdd(Vector2U17F15 other) => new Vector2U17F15(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U17F15 SaturatingMul(U17F15 other) => new Vector2U17F15(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U17F15 Dot(Vector2U17F15 other) {
            return
                X * other.X +
                Y * other.Y;
        }

    }

    partial struct U17F15 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U17F15 SaturatingMul(Vector2U17F15 other) => other.SaturatingMul(this);
    }
}
