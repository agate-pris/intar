using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I23F9 : IEquatable<Vector2I23F9>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I23F9 X;
        public I23F9 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I23F9(I23F9 x, I23F9 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I23F9(I23F9 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I23F9(Vector2I23F9 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I23F9 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I23F9(I23F9.Zero);
        }
        public static Vector2I23F9 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I23F9(I23F9.One);
        }
        public static Vector2I23F9 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I23F9(I23F9.One, I23F9.Zero);
        }
        public static Vector2I23F9 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I23F9(I23F9.Zero, I23F9.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 operator +(Vector2I23F9 a, Vector2I23F9 b) => new Vector2I23F9(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 operator -(Vector2I23F9 a, Vector2I23F9 b) => new Vector2I23F9(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 operator *(Vector2I23F9 a, Vector2I23F9 b) => new Vector2I23F9(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 operator *(Vector2I23F9 a, I23F9 b) => new Vector2I23F9(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 operator *(I23F9 a, Vector2I23F9 b) => new Vector2I23F9(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 operator /(Vector2I23F9 a, Vector2I23F9 b) => new Vector2I23F9(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 operator /(Vector2I23F9 a, I23F9 b) => new Vector2I23F9(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I23F9 operator /(I23F9 a, Vector2I23F9 b) => new Vector2I23F9(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I23F9 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(X, X); }
        public readonly Vector2I23F9 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(X, Y); }
        public readonly Vector2I23F9 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(Y, X); }
        public readonly Vector2I23F9 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I23F9(Y, Y); }
        public readonly Vector3I23F9 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, X, X); }
        public readonly Vector3I23F9 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, X, Y); }
        public readonly Vector3I23F9 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, Y, X); }
        public readonly Vector3I23F9 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(X, Y, Y); }
        public readonly Vector3I23F9 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, X, X); }
        public readonly Vector3I23F9 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, X, Y); }
        public readonly Vector3I23F9 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, Y, X); }
        public readonly Vector3I23F9 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I23F9(Y, Y, Y); }
        public readonly Vector4I23F9 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, X, X); }
        public readonly Vector4I23F9 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, X, Y); }
        public readonly Vector4I23F9 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, Y, X); }
        public readonly Vector4I23F9 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, X, Y, Y); }
        public readonly Vector4I23F9 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, X, X); }
        public readonly Vector4I23F9 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, X, Y); }
        public readonly Vector4I23F9 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, Y, X); }
        public readonly Vector4I23F9 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(X, Y, Y, Y); }
        public readonly Vector4I23F9 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, X, X); }
        public readonly Vector4I23F9 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, X, Y); }
        public readonly Vector4I23F9 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, Y, X); }
        public readonly Vector4I23F9 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, X, Y, Y); }
        public readonly Vector4I23F9 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, X, X); }
        public readonly Vector4I23F9 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, X, Y); }
        public readonly Vector4I23F9 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, Y, X); }
        public readonly Vector4I23F9 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I23F9(Y, Y, Y, Y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I23F9 lhs, Vector2I23F9 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I23F9 lhs, Vector2I23F9 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I23F9 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I23F9({X}, {Y})";

        // IEquatable<Vector2I23F9>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I23F9 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2I23F9({x}, {y})";
        }

        // Methods
        // ---------------------------------------

        public readonly Vector2I23F9 Half() => new Vector2I23F9(
            X.Half(),
            Y.Half());

    }
}
