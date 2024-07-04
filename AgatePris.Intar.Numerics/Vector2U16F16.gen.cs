using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U16F16 : IEquatable<Vector2U16F16>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U16F16 X;
        public U16F16 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U16F16(U16F16 x, U16F16 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U16F16(U16F16 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U16F16(Vector2U16F16 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U16F16 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U16F16(U16F16.Zero);
        }
        public static Vector2U16F16 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U16F16(U16F16.One);
        }
        public static Vector2U16F16 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U16F16(U16F16.One, U16F16.Zero);
        }
        public static Vector2U16F16 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U16F16(U16F16.Zero, U16F16.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 operator +(Vector2U16F16 a, Vector2U16F16 b) => new Vector2U16F16(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 operator -(Vector2U16F16 a, Vector2U16F16 b) => new Vector2U16F16(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 operator *(Vector2U16F16 a, Vector2U16F16 b) => new Vector2U16F16(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 operator *(Vector2U16F16 a, U16F16 b) => new Vector2U16F16(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 operator *(U16F16 a, Vector2U16F16 b) => new Vector2U16F16(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 operator /(Vector2U16F16 a, Vector2U16F16 b) => new Vector2U16F16(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 operator /(Vector2U16F16 a, U16F16 b) => new Vector2U16F16(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U16F16 operator /(U16F16 a, Vector2U16F16 b) => new Vector2U16F16(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U16F16 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(X, X); }
        public readonly Vector2U16F16 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(X, Y); }
        public readonly Vector2U16F16 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Y, X); }
        public readonly Vector2U16F16 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U16F16(Y, Y); }
        public readonly Vector3U16F16 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, X, X); }
        public readonly Vector3U16F16 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, X, Y); }
        public readonly Vector3U16F16 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Y, X); }
        public readonly Vector3U16F16 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(X, Y, Y); }
        public readonly Vector3U16F16 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, X, X); }
        public readonly Vector3U16F16 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, X, Y); }
        public readonly Vector3U16F16 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Y, X); }
        public readonly Vector3U16F16 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U16F16(Y, Y, Y); }
        public readonly Vector4U16F16 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, X, X); }
        public readonly Vector4U16F16 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, X, Y); }
        public readonly Vector4U16F16 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Y, X); }
        public readonly Vector4U16F16 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, X, Y, Y); }
        public readonly Vector4U16F16 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, X, X); }
        public readonly Vector4U16F16 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, X, Y); }
        public readonly Vector4U16F16 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Y, X); }
        public readonly Vector4U16F16 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(X, Y, Y, Y); }
        public readonly Vector4U16F16 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, X, X); }
        public readonly Vector4U16F16 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, X, Y); }
        public readonly Vector4U16F16 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Y, X); }
        public readonly Vector4U16F16 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, X, Y, Y); }
        public readonly Vector4U16F16 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, X, X); }
        public readonly Vector4U16F16 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, X, Y); }
        public readonly Vector4U16F16 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Y, X); }
        public readonly Vector4U16F16 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U16F16(Y, Y, Y, Y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U16F16 lhs, Vector2U16F16 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U16F16 lhs, Vector2U16F16 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U16F16 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U16F16({X}, {Y})";

        // IEquatable<Vector2U16F16>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U16F16 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U16F16({x}, {y})";
        }

        // Methods
        // ---------------------------------------

        public readonly Vector2U16F16 Half() => new Vector2U16F16(
            X.Half(),
            Y.Half());

    }
}
