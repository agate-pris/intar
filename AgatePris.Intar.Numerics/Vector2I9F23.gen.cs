using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I9F23 : IEquatable<Vector2I9F23>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I9F23 X;
        public I9F23 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I9F23(I9F23 x, I9F23 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I9F23(I9F23 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I9F23(Vector2I9F23 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I9F23 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I9F23(I9F23.Zero);
        }
        public static Vector2I9F23 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I9F23(I9F23.One);
        }
        public static Vector2I9F23 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I9F23(I9F23.One, I9F23.Zero);
        }
        public static Vector2I9F23 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I9F23(I9F23.Zero, I9F23.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 operator +(Vector2I9F23 a, Vector2I9F23 b) => new Vector2I9F23(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 operator -(Vector2I9F23 a, Vector2I9F23 b) => new Vector2I9F23(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 operator *(Vector2I9F23 a, Vector2I9F23 b) => new Vector2I9F23(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 operator *(Vector2I9F23 a, I9F23 b) => new Vector2I9F23(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 operator *(I9F23 a, Vector2I9F23 b) => new Vector2I9F23(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 operator /(Vector2I9F23 a, Vector2I9F23 b) => new Vector2I9F23(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 operator /(Vector2I9F23 a, I9F23 b) => new Vector2I9F23(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I9F23 operator /(I9F23 a, Vector2I9F23 b) => new Vector2I9F23(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I9F23 lhs, Vector2I9F23 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I9F23 lhs, Vector2I9F23 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I9F23 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(X, X); }
        public readonly Vector2I9F23 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(X, Y); }
        public readonly Vector2I9F23 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(Y, X); }
        public readonly Vector2I9F23 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(Y, Y); }
        public readonly Vector3I9F23 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, X, X); }
        public readonly Vector3I9F23 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, X, Y); }
        public readonly Vector3I9F23 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, Y, X); }
        public readonly Vector3I9F23 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, Y, Y); }
        public readonly Vector3I9F23 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, X, X); }
        public readonly Vector3I9F23 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, X, Y); }
        public readonly Vector3I9F23 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, Y, X); }
        public readonly Vector3I9F23 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, Y, Y); }
        public readonly Vector4I9F23 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, X, X); }
        public readonly Vector4I9F23 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, X, Y); }
        public readonly Vector4I9F23 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, Y, X); }
        public readonly Vector4I9F23 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, Y, Y); }
        public readonly Vector4I9F23 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, X, X); }
        public readonly Vector4I9F23 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, X, Y); }
        public readonly Vector4I9F23 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, Y, X); }
        public readonly Vector4I9F23 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, Y, Y); }
        public readonly Vector4I9F23 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, X, X); }
        public readonly Vector4I9F23 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, X, Y); }
        public readonly Vector4I9F23 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, Y, X); }
        public readonly Vector4I9F23 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, Y, Y); }
        public readonly Vector4I9F23 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, X, X); }
        public readonly Vector4I9F23 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, X, Y); }
        public readonly Vector4I9F23 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, Y, X); }
        public readonly Vector4I9F23 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I9F23 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I9F23>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I9F23 other)
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

        public readonly Vector2I9F23 Half() => new Vector2I9F23(
            X.Half(),
            Y.Half());

        public readonly Vector2I9F23 Twice() => new Vector2I9F23(
            X.Twice(),
            Y.Twice());

        public readonly Vector2I9F23 Clamp(I9F23 min, I9F23 max) => new Vector2I9F23(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2I9F23 Clamp(
            Vector2I9F23 min, Vector2I9F23 max
        ) => new Vector2I9F23(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I9F23 SaturatingAdd(Vector2I9F23 other) => new Vector2I9F23(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I9F23 SaturatingMul(I9F23 other) => new Vector2I9F23(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I9F23 Dot(Vector2I9F23 other) {
            return
                X * other.X +
                Y * other.Y;
        }

    }

    partial struct I9F23 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I9F23 SaturatingMul(Vector2I9F23 other) => other.SaturatingMul(this);
    }
}
