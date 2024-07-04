using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I24F8 : IEquatable<Vector2I24F8>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I24F8 X;
        public I24F8 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I24F8(I24F8 x, I24F8 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I24F8(I24F8 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I24F8(Vector2I24F8 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I24F8 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I24F8(I24F8.Zero);
        }
        public static Vector2I24F8 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I24F8(I24F8.One);
        }
        public static Vector2I24F8 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I24F8(I24F8.One, I24F8.Zero);
        }
        public static Vector2I24F8 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I24F8(I24F8.Zero, I24F8.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 operator +(Vector2I24F8 a, Vector2I24F8 b) => new Vector2I24F8(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 operator -(Vector2I24F8 a, Vector2I24F8 b) => new Vector2I24F8(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 operator *(Vector2I24F8 a, Vector2I24F8 b) => new Vector2I24F8(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 operator *(Vector2I24F8 a, I24F8 b) => new Vector2I24F8(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 operator *(I24F8 a, Vector2I24F8 b) => new Vector2I24F8(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 operator /(Vector2I24F8 a, Vector2I24F8 b) => new Vector2I24F8(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 operator /(Vector2I24F8 a, I24F8 b) => new Vector2I24F8(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 operator /(I24F8 a, Vector2I24F8 b) => new Vector2I24F8(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I24F8 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(X, X); }
        public readonly Vector2I24F8 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(X, Y); }
        public readonly Vector2I24F8 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(Y, X); }
        public readonly Vector2I24F8 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(Y, Y); }
        public readonly Vector3I24F8 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, X, X); }
        public readonly Vector3I24F8 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, X, Y); }
        public readonly Vector3I24F8 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, Y, X); }
        public readonly Vector3I24F8 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, Y, Y); }
        public readonly Vector3I24F8 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, X, X); }
        public readonly Vector3I24F8 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, X, Y); }
        public readonly Vector3I24F8 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, Y, X); }
        public readonly Vector3I24F8 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, Y, Y); }
        public readonly Vector4I24F8 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, X, X); }
        public readonly Vector4I24F8 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, X, Y); }
        public readonly Vector4I24F8 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, Y, X); }
        public readonly Vector4I24F8 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, Y, Y); }
        public readonly Vector4I24F8 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, X, X); }
        public readonly Vector4I24F8 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, X, Y); }
        public readonly Vector4I24F8 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, Y, X); }
        public readonly Vector4I24F8 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, Y, Y); }
        public readonly Vector4I24F8 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, X, X); }
        public readonly Vector4I24F8 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, X, Y); }
        public readonly Vector4I24F8 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, Y, X); }
        public readonly Vector4I24F8 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, Y, Y); }
        public readonly Vector4I24F8 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, X, X); }
        public readonly Vector4I24F8 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, X, Y); }
        public readonly Vector4I24F8 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, Y, X); }
        public readonly Vector4I24F8 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, Y, Y); }

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I24F8 lhs, Vector2I24F8 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I24F8 lhs, Vector2I24F8 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I24F8 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I24F8({X}, {Y})";

        // IEquatable<Vector2I24F8>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I24F8 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2I24F8({x}, {y})";
        }

        // Methods
        // ---------------------------------------

        public readonly Vector2I24F8 Half() => new Vector2I24F8(
            X.Half(),
            Y.Half());

    }
}
