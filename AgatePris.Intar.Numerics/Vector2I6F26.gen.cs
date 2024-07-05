using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I6F26 : IEquatable<Vector2I6F26>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I6F26 X;
        public I6F26 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I6F26(I6F26 x, I6F26 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I6F26(I6F26 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I6F26(Vector2I6F26 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I6F26 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I6F26(I6F26.Zero);
        }
        public static Vector2I6F26 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I6F26(I6F26.One);
        }
        public static Vector2I6F26 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I6F26(I6F26.One, I6F26.Zero);
        }
        public static Vector2I6F26 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I6F26(I6F26.Zero, I6F26.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 operator +(Vector2I6F26 a, Vector2I6F26 b) => new Vector2I6F26(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 operator -(Vector2I6F26 a, Vector2I6F26 b) => new Vector2I6F26(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 operator *(Vector2I6F26 a, Vector2I6F26 b) => new Vector2I6F26(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 operator *(Vector2I6F26 a, I6F26 b) => new Vector2I6F26(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 operator *(I6F26 a, Vector2I6F26 b) => new Vector2I6F26(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 operator /(Vector2I6F26 a, Vector2I6F26 b) => new Vector2I6F26(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 operator /(Vector2I6F26 a, I6F26 b) => new Vector2I6F26(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I6F26 operator /(I6F26 a, Vector2I6F26 b) => new Vector2I6F26(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I6F26 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(X, X); }
        public readonly Vector2I6F26 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(X, Y); }
        public readonly Vector2I6F26 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Y, X); }
        public readonly Vector2I6F26 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I6F26(Y, Y); }
        public readonly Vector3I6F26 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, X, X); }
        public readonly Vector3I6F26 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, X, Y); }
        public readonly Vector3I6F26 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Y, X); }
        public readonly Vector3I6F26 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(X, Y, Y); }
        public readonly Vector3I6F26 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, X, X); }
        public readonly Vector3I6F26 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, X, Y); }
        public readonly Vector3I6F26 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Y, X); }
        public readonly Vector3I6F26 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I6F26(Y, Y, Y); }
        public readonly Vector4I6F26 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, X, X); }
        public readonly Vector4I6F26 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, X, Y); }
        public readonly Vector4I6F26 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Y, X); }
        public readonly Vector4I6F26 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, X, Y, Y); }
        public readonly Vector4I6F26 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, X, X); }
        public readonly Vector4I6F26 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, X, Y); }
        public readonly Vector4I6F26 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Y, X); }
        public readonly Vector4I6F26 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(X, Y, Y, Y); }
        public readonly Vector4I6F26 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, X, X); }
        public readonly Vector4I6F26 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, X, Y); }
        public readonly Vector4I6F26 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Y, X); }
        public readonly Vector4I6F26 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, X, Y, Y); }
        public readonly Vector4I6F26 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, X, X); }
        public readonly Vector4I6F26 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, X, Y); }
        public readonly Vector4I6F26 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Y, X); }
        public readonly Vector4I6F26 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I6F26(Y, Y, Y, Y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I6F26 lhs, Vector2I6F26 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I6F26 lhs, Vector2I6F26 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I6F26 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I6F26>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I6F26 other)
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

        public readonly Vector2I6F26 Half() => new Vector2I6F26(
            X.Half(),
            Y.Half());

        public readonly Vector2I6F26 Twice() => new Vector2I6F26(
            X.Twice(),
            Y.Twice());

        public readonly Vector2I6F26 Clamp(I6F26 min, I6F26 max) => new Vector2I6F26(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2I6F26 Clamp(
            Vector2I6F26 min, Vector2I6F26 max
        ) => new Vector2I6F26(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I6F26 SaturatingAdd(Vector2I6F26 other) => new Vector2I6F26(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I6F26 SaturatingMul(I6F26 other) => new Vector2I6F26(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

    }

    partial struct I6F26 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I6F26 SaturatingMul(Vector2I6F26 other) => other.SaturatingMul(this);
    }
}
