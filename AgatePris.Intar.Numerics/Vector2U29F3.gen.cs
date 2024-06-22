using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2U29F3 : IEquatable<Vector2U29F3>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U29F3 X;
        public U29F3 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector2U29F3 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U29F3(U29F3 x, U29F3 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U29F3(Vector2U29F3 xy) {
            X = xy.X;
            Y = xy.Y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 operator +(Vector2U29F3 a, Vector2U29F3 b) => new Vector2U29F3(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 operator -(Vector2U29F3 a, Vector2U29F3 b) => new Vector2U29F3(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 operator *(Vector2U29F3 a, Vector2U29F3 b) => new Vector2U29F3(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 operator *(Vector2U29F3 a, U29F3 b) => new Vector2U29F3(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 operator *(U29F3 a, Vector2U29F3 b) => new Vector2U29F3(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 operator /(Vector2U29F3 a, Vector2U29F3 b) => new Vector2U29F3(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 operator /(Vector2U29F3 a, U29F3 b) => new Vector2U29F3(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 operator /(U29F3 a, Vector2U29F3 b) => new Vector2U29F3(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U29F3 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(X, X); }
        public readonly Vector2U29F3 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(X, Y); }
        public readonly Vector2U29F3 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(Y, X); }
        public readonly Vector2U29F3 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(Y, Y); }
        public readonly Vector3U29F3 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, X, X); }
        public readonly Vector3U29F3 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, X, Y); }
        public readonly Vector3U29F3 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, Y, X); }
        public readonly Vector3U29F3 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, Y, Y); }
        public readonly Vector3U29F3 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, X, X); }
        public readonly Vector3U29F3 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, X, Y); }
        public readonly Vector3U29F3 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, Y, X); }
        public readonly Vector3U29F3 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, Y, Y); }
        public readonly Vector4U29F3 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, X, X); }
        public readonly Vector4U29F3 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, X, Y); }
        public readonly Vector4U29F3 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, Y, X); }
        public readonly Vector4U29F3 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, Y, Y); }
        public readonly Vector4U29F3 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, X, X); }
        public readonly Vector4U29F3 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, X, Y); }
        public readonly Vector4U29F3 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, Y, X); }
        public readonly Vector4U29F3 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, Y, Y); }
        public readonly Vector4U29F3 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, X, X); }
        public readonly Vector4U29F3 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, X, Y); }
        public readonly Vector4U29F3 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, Y, X); }
        public readonly Vector4U29F3 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, Y, Y); }
        public readonly Vector4U29F3 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, X, X); }
        public readonly Vector4U29F3 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, X, Y); }
        public readonly Vector4U29F3 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, Y, X); }
        public readonly Vector4U29F3 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U29F3 lhs, Vector2U29F3 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U29F3 lhs, Vector2U29F3 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U29F3 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U29F3({X}, {Y})";

        // IEquatable<Vector2U29F3>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U29F3 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U29F3({x}, {y})";
        }
    }
}
