using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I16F16 : IEquatable<Vector2I16F16>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I16F16 X;
        public I16F16 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16(I16F16 x, I16F16 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16(I16F16 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16(Vector2I16F16 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I16F16 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I16F16(I16F16.Zero);
        }
        public static Vector2I16F16 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I16F16(I16F16.One);
        }
        public static Vector2I16F16 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I16F16(I16F16.One, I16F16.Zero);
        }
        public static Vector2I16F16 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I16F16(I16F16.Zero, I16F16.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator +(Vector2I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator -(Vector2I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator *(Vector2I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator *(Vector2I16F16 a, I16F16 b) => new Vector2I16F16(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator *(I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator /(Vector2I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator /(Vector2I16F16 a, I16F16 b) => new Vector2I16F16(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator /(I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I16F16 lhs, Vector2I16F16 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I16F16 lhs, Vector2I16F16 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I16F16 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(X, X); }
        public readonly Vector2I16F16 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(X, Y); }
        public readonly Vector2I16F16 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(Y, X); }
        public readonly Vector2I16F16 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(Y, Y); }
        public readonly Vector3I16F16 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, X, X); }
        public readonly Vector3I16F16 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, X, Y); }
        public readonly Vector3I16F16 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, Y, X); }
        public readonly Vector3I16F16 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, Y, Y); }
        public readonly Vector3I16F16 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, X, X); }
        public readonly Vector3I16F16 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, X, Y); }
        public readonly Vector3I16F16 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, Y, X); }
        public readonly Vector3I16F16 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, Y, Y); }
        public readonly Vector4I16F16 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, X, X); }
        public readonly Vector4I16F16 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, X, Y); }
        public readonly Vector4I16F16 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, Y, X); }
        public readonly Vector4I16F16 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, Y, Y); }
        public readonly Vector4I16F16 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, X, X); }
        public readonly Vector4I16F16 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, X, Y); }
        public readonly Vector4I16F16 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, Y, X); }
        public readonly Vector4I16F16 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, Y, Y); }
        public readonly Vector4I16F16 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, X, X); }
        public readonly Vector4I16F16 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, X, Y); }
        public readonly Vector4I16F16 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, Y, X); }
        public readonly Vector4I16F16 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, Y, Y); }
        public readonly Vector4I16F16 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, X, X); }
        public readonly Vector4I16F16 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, X, Y); }
        public readonly Vector4I16F16 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, Y, X); }
        public readonly Vector4I16F16 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I16F16 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I16F16>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I16F16 other)
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

        public readonly Vector2I16F16 Half() => new Vector2I16F16(
            X.Half(),
            Y.Half());

        public readonly Vector2I16F16 Twice() => new Vector2I16F16(
            X.Twice(),
            Y.Twice());

        public readonly Vector2I16F16 Clamp(I16F16 min, I16F16 max) => new Vector2I16F16(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2I16F16 Clamp(
            Vector2I16F16 min, Vector2I16F16 max
        ) => new Vector2I16F16(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I16F16 SaturatingAdd(Vector2I16F16 other) => new Vector2I16F16(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I16F16 SaturatingMul(I16F16 other) => new Vector2I16F16(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I16F16 Dot(Vector2I16F16 other) {
            return
                X * other.X +
                Y * other.Y;
        }

    }

    partial struct I16F16 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I16F16 SaturatingMul(Vector2I16F16 other) => other.SaturatingMul(this);
    }
}
