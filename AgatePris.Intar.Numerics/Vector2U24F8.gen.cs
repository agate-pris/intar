using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U24F8 : IEquatable<Vector2U24F8>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U24F8 X;
        public U24F8 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector2U24F8 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U24F8(U24F8 x, U24F8 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U24F8(Vector2U24F8 xy) {
            X = xy.X;
            Y = xy.Y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 operator +(Vector2U24F8 a, Vector2U24F8 b) => new Vector2U24F8(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 operator -(Vector2U24F8 a, Vector2U24F8 b) => new Vector2U24F8(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 operator *(Vector2U24F8 a, Vector2U24F8 b) => new Vector2U24F8(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 operator *(Vector2U24F8 a, U24F8 b) => new Vector2U24F8(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 operator *(U24F8 a, Vector2U24F8 b) => new Vector2U24F8(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 operator /(Vector2U24F8 a, Vector2U24F8 b) => new Vector2U24F8(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 operator /(Vector2U24F8 a, U24F8 b) => new Vector2U24F8(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U24F8 operator /(U24F8 a, Vector2U24F8 b) => new Vector2U24F8(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U24F8 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(X, X); }
        public readonly Vector2U24F8 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(X, Y); }
        public readonly Vector2U24F8 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Y, X); }
        public readonly Vector2U24F8 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U24F8(Y, Y); }
        public readonly Vector3U24F8 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, X, X); }
        public readonly Vector3U24F8 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, X, Y); }
        public readonly Vector3U24F8 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Y, X); }
        public readonly Vector3U24F8 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(X, Y, Y); }
        public readonly Vector3U24F8 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, X, X); }
        public readonly Vector3U24F8 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, X, Y); }
        public readonly Vector3U24F8 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Y, X); }
        public readonly Vector3U24F8 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U24F8(Y, Y, Y); }
        public readonly Vector4U24F8 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, X, X); }
        public readonly Vector4U24F8 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, X, Y); }
        public readonly Vector4U24F8 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Y, X); }
        public readonly Vector4U24F8 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, X, Y, Y); }
        public readonly Vector4U24F8 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, X, X); }
        public readonly Vector4U24F8 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, X, Y); }
        public readonly Vector4U24F8 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Y, X); }
        public readonly Vector4U24F8 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(X, Y, Y, Y); }
        public readonly Vector4U24F8 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, X, X); }
        public readonly Vector4U24F8 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, X, Y); }
        public readonly Vector4U24F8 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Y, X); }
        public readonly Vector4U24F8 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, X, Y, Y); }
        public readonly Vector4U24F8 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, X, X); }
        public readonly Vector4U24F8 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, X, Y); }
        public readonly Vector4U24F8 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Y, X); }
        public readonly Vector4U24F8 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U24F8(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U24F8 lhs, Vector2U24F8 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U24F8 lhs, Vector2U24F8 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U24F8 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U24F8({X}, {Y})";

        // IEquatable<Vector2U24F8>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U24F8 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U24F8({x}, {y})";
        }
    }
}