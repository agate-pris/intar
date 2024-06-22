using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2U30F2 : IEquatable<Vector2U30F2>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U30F2 X;
        public U30F2 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector2U30F2 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2(U30F2 x, U30F2 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2(Vector2U30F2 xy) {
            X = xy.X;
            Y = xy.Y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator +(Vector2U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator -(Vector2U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator *(Vector2U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator *(Vector2U30F2 a, U30F2 b) => new Vector2U30F2(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator *(U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator /(Vector2U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator /(Vector2U30F2 a, U30F2 b) => new Vector2U30F2(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator /(U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U30F2 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(X, X); }
        public readonly Vector2U30F2 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(X, Y); }
        public readonly Vector2U30F2 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Y, X); }
        public readonly Vector2U30F2 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Y, Y); }
        public readonly Vector3U30F2 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, X, X); }
        public readonly Vector3U30F2 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, X, Y); }
        public readonly Vector3U30F2 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Y, X); }
        public readonly Vector3U30F2 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Y, Y); }
        public readonly Vector3U30F2 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, X, X); }
        public readonly Vector3U30F2 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, X, Y); }
        public readonly Vector3U30F2 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Y, X); }
        public readonly Vector3U30F2 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Y, Y); }
        public readonly Vector4U30F2 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, X, X); }
        public readonly Vector4U30F2 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, X, Y); }
        public readonly Vector4U30F2 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Y, X); }
        public readonly Vector4U30F2 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Y, Y); }
        public readonly Vector4U30F2 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, X, X); }
        public readonly Vector4U30F2 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, X, Y); }
        public readonly Vector4U30F2 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Y, X); }
        public readonly Vector4U30F2 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Y, Y); }
        public readonly Vector4U30F2 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, X, X); }
        public readonly Vector4U30F2 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, X, Y); }
        public readonly Vector4U30F2 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Y, X); }
        public readonly Vector4U30F2 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Y, Y); }
        public readonly Vector4U30F2 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, X, X); }
        public readonly Vector4U30F2 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, X, Y); }
        public readonly Vector4U30F2 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Y, X); }
        public readonly Vector4U30F2 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U30F2 lhs, Vector2U30F2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U30F2 lhs, Vector2U30F2 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U30F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U30F2({X}, {Y})";

        // IEquatable<Vector2U30F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U30F2 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U30F2({x}, {y})";
        }
    }
}
