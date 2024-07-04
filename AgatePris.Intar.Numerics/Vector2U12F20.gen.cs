using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U12F20 : IEquatable<Vector2U12F20>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U12F20 X;
        public U12F20 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U12F20(U12F20 x, U12F20 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U12F20(U12F20 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U12F20(Vector2U12F20 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U12F20 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U12F20(U12F20.Zero);
        }
        public static Vector2U12F20 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U12F20(U12F20.One);
        }
        public static Vector2U12F20 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U12F20(U12F20.One, U12F20.Zero);
        }
        public static Vector2U12F20 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U12F20(U12F20.Zero, U12F20.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator +(Vector2U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator -(Vector2U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator *(Vector2U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator *(Vector2U12F20 a, U12F20 b) => new Vector2U12F20(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator *(U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator /(Vector2U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator /(Vector2U12F20 a, U12F20 b) => new Vector2U12F20(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator /(U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U12F20 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(X, X); }
        public readonly Vector2U12F20 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(X, Y); }
        public readonly Vector2U12F20 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(Y, X); }
        public readonly Vector2U12F20 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(Y, Y); }
        public readonly Vector3U12F20 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(X, X, X); }
        public readonly Vector3U12F20 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(X, X, Y); }
        public readonly Vector3U12F20 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(X, Y, X); }
        public readonly Vector3U12F20 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(X, Y, Y); }
        public readonly Vector3U12F20 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(Y, X, X); }
        public readonly Vector3U12F20 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(Y, X, Y); }
        public readonly Vector3U12F20 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(Y, Y, X); }
        public readonly Vector3U12F20 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(Y, Y, Y); }
        public readonly Vector4U12F20 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(X, X, X, X); }
        public readonly Vector4U12F20 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(X, X, X, Y); }
        public readonly Vector4U12F20 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(X, X, Y, X); }
        public readonly Vector4U12F20 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(X, X, Y, Y); }
        public readonly Vector4U12F20 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(X, Y, X, X); }
        public readonly Vector4U12F20 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(X, Y, X, Y); }
        public readonly Vector4U12F20 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(X, Y, Y, X); }
        public readonly Vector4U12F20 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(X, Y, Y, Y); }
        public readonly Vector4U12F20 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(Y, X, X, X); }
        public readonly Vector4U12F20 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(Y, X, X, Y); }
        public readonly Vector4U12F20 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(Y, X, Y, X); }
        public readonly Vector4U12F20 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(Y, X, Y, Y); }
        public readonly Vector4U12F20 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(Y, Y, X, X); }
        public readonly Vector4U12F20 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(Y, Y, X, Y); }
        public readonly Vector4U12F20 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(Y, Y, Y, X); }
        public readonly Vector4U12F20 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(Y, Y, Y, Y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U12F20 lhs, Vector2U12F20 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U12F20 lhs, Vector2U12F20 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U12F20 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U12F20({X}, {Y})";

        // IEquatable<Vector2U12F20>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U12F20 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U12F20({x}, {y})";
        }

        // Methods
        // ---------------------------------------

        public readonly Vector2U12F20 Half() => new Vector2U12F20(
            X.Half(),
            Y.Half());

        public readonly Vector2U12F20 Twice() => new Vector2U12F20(
            X.Twice(),
            Y.Twice());

    }
}
