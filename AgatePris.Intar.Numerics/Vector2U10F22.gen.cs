using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U10F22 : IEquatable<Vector2U10F22>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U10F22 X;
        public U10F22 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22(U10F22 x, U10F22 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22(U10F22 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22(Vector2U10F22 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U10F22 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U10F22(U10F22.Zero);
        }
        public static Vector2U10F22 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U10F22(U10F22.One);
        }
        public static Vector2U10F22 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U10F22(U10F22.One, U10F22.Zero);
        }
        public static Vector2U10F22 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U10F22(U10F22.Zero, U10F22.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator +(Vector2U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator -(Vector2U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator *(Vector2U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator *(Vector2U10F22 a, U10F22 b) => new Vector2U10F22(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator *(U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator /(Vector2U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator /(Vector2U10F22 a, U10F22 b) => new Vector2U10F22(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator /(U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U10F22 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(X, X); }
        public readonly Vector2U10F22 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(X, Y); }
        public readonly Vector2U10F22 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(Y, X); }
        public readonly Vector2U10F22 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(Y, Y); }
        public readonly Vector3U10F22 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, X, X); }
        public readonly Vector3U10F22 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, X, Y); }
        public readonly Vector3U10F22 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, Y, X); }
        public readonly Vector3U10F22 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, Y, Y); }
        public readonly Vector3U10F22 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, X, X); }
        public readonly Vector3U10F22 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, X, Y); }
        public readonly Vector3U10F22 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, Y, X); }
        public readonly Vector3U10F22 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, Y, Y); }
        public readonly Vector4U10F22 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, X, X); }
        public readonly Vector4U10F22 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, X, Y); }
        public readonly Vector4U10F22 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, Y, X); }
        public readonly Vector4U10F22 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, Y, Y); }
        public readonly Vector4U10F22 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, X, X); }
        public readonly Vector4U10F22 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, X, Y); }
        public readonly Vector4U10F22 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, Y, X); }
        public readonly Vector4U10F22 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, Y, Y); }
        public readonly Vector4U10F22 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, X, X); }
        public readonly Vector4U10F22 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, X, Y); }
        public readonly Vector4U10F22 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, Y, X); }
        public readonly Vector4U10F22 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, Y, Y); }
        public readonly Vector4U10F22 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, X, X); }
        public readonly Vector4U10F22 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, X, Y); }
        public readonly Vector4U10F22 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, Y, X); }
        public readonly Vector4U10F22 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, Y, Y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U10F22 lhs, Vector2U10F22 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U10F22 lhs, Vector2U10F22 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U10F22 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U10F22({X}, {Y})";

        // IEquatable<Vector2U10F22>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U10F22 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U10F22({x}, {y})";
        }

        // Methods
        // ---------------------------------------

        public readonly Vector2U10F22 Half() => new Vector2U10F22(
            X.Half(),
            Y.Half());

        public readonly Vector2U10F22 Twice() => new Vector2U10F22(
            X.Twice(),
            Y.Twice());

    }
}
