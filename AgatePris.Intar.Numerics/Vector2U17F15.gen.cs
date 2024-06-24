using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U17F15 : IEquatable<Vector2U17F15>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U17F15 X;
        public U17F15 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15(U17F15 x, U17F15 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15(U17F15 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15(Vector2U17F15 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U17F15 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U17F15(U17F15.Zero);
        }
        public static Vector2U17F15 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U17F15(U17F15.One);
        }
        public static Vector2U17F15 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U17F15(U17F15.One, U17F15.Zero);
        }
        public static Vector2U17F15 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U17F15(U17F15.Zero, U17F15.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator +(Vector2U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator -(Vector2U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator *(Vector2U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator *(Vector2U17F15 a, U17F15 b) => new Vector2U17F15(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator *(U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator /(Vector2U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator /(Vector2U17F15 a, U17F15 b) => new Vector2U17F15(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator /(U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U17F15 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(X, X); }
        public readonly Vector2U17F15 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(X, Y); }
        public readonly Vector2U17F15 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Y, X); }
        public readonly Vector2U17F15 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Y, Y); }
        public readonly Vector3U17F15 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, X, X); }
        public readonly Vector3U17F15 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, X, Y); }
        public readonly Vector3U17F15 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Y, X); }
        public readonly Vector3U17F15 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Y, Y); }
        public readonly Vector3U17F15 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, X, X); }
        public readonly Vector3U17F15 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, X, Y); }
        public readonly Vector3U17F15 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Y, X); }
        public readonly Vector3U17F15 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Y, Y); }
        public readonly Vector4U17F15 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, X, X); }
        public readonly Vector4U17F15 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, X, Y); }
        public readonly Vector4U17F15 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Y, X); }
        public readonly Vector4U17F15 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Y, Y); }
        public readonly Vector4U17F15 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, X, X); }
        public readonly Vector4U17F15 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, X, Y); }
        public readonly Vector4U17F15 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Y, X); }
        public readonly Vector4U17F15 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Y, Y); }
        public readonly Vector4U17F15 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, X, X); }
        public readonly Vector4U17F15 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, X, Y); }
        public readonly Vector4U17F15 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Y, X); }
        public readonly Vector4U17F15 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Y, Y); }
        public readonly Vector4U17F15 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, X, X); }
        public readonly Vector4U17F15 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, X, Y); }
        public readonly Vector4U17F15 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Y, X); }
        public readonly Vector4U17F15 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U17F15 lhs, Vector2U17F15 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U17F15 lhs, Vector2U17F15 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U17F15({X}, {Y})";

        // IEquatable<Vector2U17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U17F15 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U17F15({x}, {y})";
        }
    }
}
