using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U28F4 : IEquatable<Vector2U28F4>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U28F4 X;
        public U28F4 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector2U28F4 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4(U28F4 x, U28F4 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4(U28F4 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4(Vector2U28F4 xy) : this(xy.X, xy.Y) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 operator +(Vector2U28F4 a, Vector2U28F4 b) => new Vector2U28F4(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 operator -(Vector2U28F4 a, Vector2U28F4 b) => new Vector2U28F4(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 operator *(Vector2U28F4 a, Vector2U28F4 b) => new Vector2U28F4(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 operator *(Vector2U28F4 a, U28F4 b) => new Vector2U28F4(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 operator *(U28F4 a, Vector2U28F4 b) => new Vector2U28F4(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 operator /(Vector2U28F4 a, Vector2U28F4 b) => new Vector2U28F4(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 operator /(Vector2U28F4 a, U28F4 b) => new Vector2U28F4(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 operator /(U28F4 a, Vector2U28F4 b) => new Vector2U28F4(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U28F4 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(X, X); }
        public readonly Vector2U28F4 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(X, Y); }
        public readonly Vector2U28F4 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Y, X); }
        public readonly Vector2U28F4 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Y, Y); }
        public readonly Vector3U28F4 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, X, X); }
        public readonly Vector3U28F4 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, X, Y); }
        public readonly Vector3U28F4 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Y, X); }
        public readonly Vector3U28F4 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Y, Y); }
        public readonly Vector3U28F4 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, X, X); }
        public readonly Vector3U28F4 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, X, Y); }
        public readonly Vector3U28F4 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Y, X); }
        public readonly Vector3U28F4 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Y, Y); }
        public readonly Vector4U28F4 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, X, X); }
        public readonly Vector4U28F4 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, X, Y); }
        public readonly Vector4U28F4 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Y, X); }
        public readonly Vector4U28F4 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Y, Y); }
        public readonly Vector4U28F4 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, X, X); }
        public readonly Vector4U28F4 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, X, Y); }
        public readonly Vector4U28F4 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Y, X); }
        public readonly Vector4U28F4 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Y, Y); }
        public readonly Vector4U28F4 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, X, X); }
        public readonly Vector4U28F4 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, X, Y); }
        public readonly Vector4U28F4 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Y, X); }
        public readonly Vector4U28F4 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Y, Y); }
        public readonly Vector4U28F4 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, X, X); }
        public readonly Vector4U28F4 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, X, Y); }
        public readonly Vector4U28F4 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Y, X); }
        public readonly Vector4U28F4 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U28F4 lhs, Vector2U28F4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U28F4 lhs, Vector2U28F4 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U28F4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U28F4({X}, {Y})";

        // IEquatable<Vector2U28F4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U28F4 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U28F4({x}, {y})";
        }
    }
}
