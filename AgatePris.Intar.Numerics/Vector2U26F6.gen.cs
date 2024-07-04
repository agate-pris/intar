using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U26F6 : IEquatable<Vector2U26F6>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U26F6 X;
        public U26F6 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U26F6(U26F6 x, U26F6 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U26F6(U26F6 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U26F6(Vector2U26F6 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U26F6 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U26F6(U26F6.Zero);
        }
        public static Vector2U26F6 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U26F6(U26F6.One);
        }
        public static Vector2U26F6 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U26F6(U26F6.One, U26F6.Zero);
        }
        public static Vector2U26F6 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U26F6(U26F6.Zero, U26F6.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 operator +(Vector2U26F6 a, Vector2U26F6 b) => new Vector2U26F6(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 operator -(Vector2U26F6 a, Vector2U26F6 b) => new Vector2U26F6(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 operator *(Vector2U26F6 a, Vector2U26F6 b) => new Vector2U26F6(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 operator *(Vector2U26F6 a, U26F6 b) => new Vector2U26F6(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 operator *(U26F6 a, Vector2U26F6 b) => new Vector2U26F6(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 operator /(Vector2U26F6 a, Vector2U26F6 b) => new Vector2U26F6(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 operator /(Vector2U26F6 a, U26F6 b) => new Vector2U26F6(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U26F6 operator /(U26F6 a, Vector2U26F6 b) => new Vector2U26F6(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U26F6 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(X, X); }
        public readonly Vector2U26F6 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(X, Y); }
        public readonly Vector2U26F6 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Y, X); }
        public readonly Vector2U26F6 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Y, Y); }
        public readonly Vector3U26F6 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, X, X); }
        public readonly Vector3U26F6 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, X, Y); }
        public readonly Vector3U26F6 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Y, X); }
        public readonly Vector3U26F6 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Y, Y); }
        public readonly Vector3U26F6 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, X, X); }
        public readonly Vector3U26F6 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, X, Y); }
        public readonly Vector3U26F6 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Y, X); }
        public readonly Vector3U26F6 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Y, Y); }
        public readonly Vector4U26F6 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, X, X); }
        public readonly Vector4U26F6 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, X, Y); }
        public readonly Vector4U26F6 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Y, X); }
        public readonly Vector4U26F6 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Y, Y); }
        public readonly Vector4U26F6 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, X, X); }
        public readonly Vector4U26F6 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, X, Y); }
        public readonly Vector4U26F6 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Y, X); }
        public readonly Vector4U26F6 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Y, Y); }
        public readonly Vector4U26F6 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, X, X); }
        public readonly Vector4U26F6 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, X, Y); }
        public readonly Vector4U26F6 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Y, X); }
        public readonly Vector4U26F6 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Y, Y); }
        public readonly Vector4U26F6 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, X, X); }
        public readonly Vector4U26F6 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, X, Y); }
        public readonly Vector4U26F6 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Y, X); }
        public readonly Vector4U26F6 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Y, Y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U26F6 lhs, Vector2U26F6 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U26F6 lhs, Vector2U26F6 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U26F6 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U26F6({X}, {Y})";

        // IEquatable<Vector2U26F6>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U26F6 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U26F6({x}, {y})";
        }

        // Methods
        // ---------------------------------------

        public readonly Vector2U26F6 Half() => new Vector2U26F6(
            X.Half(),
            Y.Half());

    }
}
