using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I11F21 : IEquatable<Vector2I11F21>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I11F21 X;
        public I11F21 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I11F21(I11F21 x, I11F21 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I11F21(I11F21 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I11F21(Vector2I11F21 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I11F21 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I11F21(I11F21.Zero);
        }
        public static Vector2I11F21 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I11F21(I11F21.One);
        }
        public static Vector2I11F21 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I11F21(I11F21.One, I11F21.Zero);
        }
        public static Vector2I11F21 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I11F21(I11F21.Zero, I11F21.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 operator +(Vector2I11F21 a, Vector2I11F21 b) => new Vector2I11F21(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 operator -(Vector2I11F21 a, Vector2I11F21 b) => new Vector2I11F21(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 operator *(Vector2I11F21 a, Vector2I11F21 b) => new Vector2I11F21(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 operator *(Vector2I11F21 a, I11F21 b) => new Vector2I11F21(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 operator *(I11F21 a, Vector2I11F21 b) => new Vector2I11F21(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 operator /(Vector2I11F21 a, Vector2I11F21 b) => new Vector2I11F21(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 operator /(Vector2I11F21 a, I11F21 b) => new Vector2I11F21(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 operator /(I11F21 a, Vector2I11F21 b) => new Vector2I11F21(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I11F21 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(X, X); }
        public readonly Vector2I11F21 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(X, Y); }
        public readonly Vector2I11F21 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Y, X); }
        public readonly Vector2I11F21 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Y, Y); }
        public readonly Vector3I11F21 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, X, X); }
        public readonly Vector3I11F21 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, X, Y); }
        public readonly Vector3I11F21 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Y, X); }
        public readonly Vector3I11F21 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Y, Y); }
        public readonly Vector3I11F21 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, X, X); }
        public readonly Vector3I11F21 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, X, Y); }
        public readonly Vector3I11F21 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Y, X); }
        public readonly Vector3I11F21 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Y, Y); }
        public readonly Vector4I11F21 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, X, X); }
        public readonly Vector4I11F21 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, X, Y); }
        public readonly Vector4I11F21 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Y, X); }
        public readonly Vector4I11F21 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Y, Y); }
        public readonly Vector4I11F21 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, X, X); }
        public readonly Vector4I11F21 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, X, Y); }
        public readonly Vector4I11F21 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Y, X); }
        public readonly Vector4I11F21 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Y, Y); }
        public readonly Vector4I11F21 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, X, X); }
        public readonly Vector4I11F21 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, X, Y); }
        public readonly Vector4I11F21 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Y, X); }
        public readonly Vector4I11F21 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Y, Y); }
        public readonly Vector4I11F21 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, X, X); }
        public readonly Vector4I11F21 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, X, Y); }
        public readonly Vector4I11F21 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Y, X); }
        public readonly Vector4I11F21 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Y, Y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I11F21 lhs, Vector2I11F21 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I11F21 lhs, Vector2I11F21 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I11F21 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I11F21>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I11F21 other)
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

        public readonly Vector2I11F21 Half() => new Vector2I11F21(
            X.Half(),
            Y.Half());

        public readonly Vector2I11F21 Twice() => new Vector2I11F21(
            X.Twice(),
            Y.Twice());

        public readonly Vector2I11F21 Clamp(I11F21 min, I11F21 max) => new Vector2I11F21(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2I11F21 Clamp(
            Vector2I11F21 min, Vector2I11F21 max
        ) => new Vector2I11F21(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I11F21 SaturatingAdd(Vector2I11F21 other) => new Vector2I11F21(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I11F21 SaturatingMul(I11F21 other) => new Vector2I11F21(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

    }
}
