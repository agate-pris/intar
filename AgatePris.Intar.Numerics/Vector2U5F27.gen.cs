using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U5F27 : IEquatable<Vector2U5F27>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U5F27 X;
        public U5F27 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector2U5F27 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27(U5F27 x, U5F27 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27(Vector2U5F27 xy) : this(xy.X, xy.Y) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 operator +(Vector2U5F27 a, Vector2U5F27 b) => new Vector2U5F27(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 operator -(Vector2U5F27 a, Vector2U5F27 b) => new Vector2U5F27(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 operator *(Vector2U5F27 a, Vector2U5F27 b) => new Vector2U5F27(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 operator *(Vector2U5F27 a, U5F27 b) => new Vector2U5F27(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 operator *(U5F27 a, Vector2U5F27 b) => new Vector2U5F27(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 operator /(Vector2U5F27 a, Vector2U5F27 b) => new Vector2U5F27(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 operator /(Vector2U5F27 a, U5F27 b) => new Vector2U5F27(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 operator /(U5F27 a, Vector2U5F27 b) => new Vector2U5F27(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U5F27 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(X, X); }
        public readonly Vector2U5F27 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(X, Y); }
        public readonly Vector2U5F27 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(Y, X); }
        public readonly Vector2U5F27 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(Y, Y); }
        public readonly Vector3U5F27 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, X, X); }
        public readonly Vector3U5F27 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, X, Y); }
        public readonly Vector3U5F27 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, Y, X); }
        public readonly Vector3U5F27 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, Y, Y); }
        public readonly Vector3U5F27 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, X, X); }
        public readonly Vector3U5F27 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, X, Y); }
        public readonly Vector3U5F27 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, Y, X); }
        public readonly Vector3U5F27 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, Y, Y); }
        public readonly Vector4U5F27 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, X, X); }
        public readonly Vector4U5F27 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, X, Y); }
        public readonly Vector4U5F27 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, Y, X); }
        public readonly Vector4U5F27 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, Y, Y); }
        public readonly Vector4U5F27 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, X, X); }
        public readonly Vector4U5F27 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, X, Y); }
        public readonly Vector4U5F27 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, Y, X); }
        public readonly Vector4U5F27 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, Y, Y); }
        public readonly Vector4U5F27 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, X, X); }
        public readonly Vector4U5F27 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, X, Y); }
        public readonly Vector4U5F27 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, Y, X); }
        public readonly Vector4U5F27 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, Y, Y); }
        public readonly Vector4U5F27 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, X, X); }
        public readonly Vector4U5F27 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, X, Y); }
        public readonly Vector4U5F27 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, Y, X); }
        public readonly Vector4U5F27 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U5F27 lhs, Vector2U5F27 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U5F27 lhs, Vector2U5F27 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U5F27 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U5F27({X}, {Y})";

        // IEquatable<Vector2U5F27>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U5F27 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U5F27({x}, {y})";
        }
    }
}
