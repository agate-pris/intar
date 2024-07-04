using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I2F30 : IEquatable<Vector2I2F30>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I2F30 X;
        public I2F30 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30(I2F30 x, I2F30 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30(I2F30 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30(Vector2I2F30 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I2F30 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I2F30(I2F30.Zero);
        }
        public static Vector2I2F30 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I2F30(I2F30.One);
        }
        public static Vector2I2F30 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I2F30(I2F30.One, I2F30.Zero);
        }
        public static Vector2I2F30 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I2F30(I2F30.Zero, I2F30.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator +(Vector2I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator -(Vector2I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator *(Vector2I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator *(Vector2I2F30 a, I2F30 b) => new Vector2I2F30(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator *(I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator /(Vector2I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator /(Vector2I2F30 a, I2F30 b) => new Vector2I2F30(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator /(I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I2F30 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(X, X); }
        public readonly Vector2I2F30 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(X, Y); }
        public readonly Vector2I2F30 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Y, X); }
        public readonly Vector2I2F30 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Y, Y); }
        public readonly Vector3I2F30 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, X, X); }
        public readonly Vector3I2F30 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, X, Y); }
        public readonly Vector3I2F30 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Y, X); }
        public readonly Vector3I2F30 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Y, Y); }
        public readonly Vector3I2F30 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, X, X); }
        public readonly Vector3I2F30 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, X, Y); }
        public readonly Vector3I2F30 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Y, X); }
        public readonly Vector3I2F30 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Y, Y); }
        public readonly Vector4I2F30 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, X, X); }
        public readonly Vector4I2F30 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, X, Y); }
        public readonly Vector4I2F30 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Y, X); }
        public readonly Vector4I2F30 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Y, Y); }
        public readonly Vector4I2F30 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, X, X); }
        public readonly Vector4I2F30 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, X, Y); }
        public readonly Vector4I2F30 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Y, X); }
        public readonly Vector4I2F30 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Y, Y); }
        public readonly Vector4I2F30 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, X, X); }
        public readonly Vector4I2F30 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, X, Y); }
        public readonly Vector4I2F30 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Y, X); }
        public readonly Vector4I2F30 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Y, Y); }
        public readonly Vector4I2F30 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, X, X); }
        public readonly Vector4I2F30 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, X, Y); }
        public readonly Vector4I2F30 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Y, X); }
        public readonly Vector4I2F30 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Y, Y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I2F30 lhs, Vector2I2F30 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I2F30 lhs, Vector2I2F30 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I2F30({X}, {Y})";

        // IEquatable<Vector2I2F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I2F30 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2I2F30({x}, {y})";
        }

        // Methods
        // ---------------------------------------

        public readonly Vector2I2F30 Half() => new Vector2I2F30(
            X.Half(),
            Y.Half());

    }
}
