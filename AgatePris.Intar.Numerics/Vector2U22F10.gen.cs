using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U22F10 : IEquatable<Vector2U22F10>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U22F10 X;
        public U22F10 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector2U22F10 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U22F10(U22F10 x, U22F10 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U22F10(U22F10 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U22F10(Vector2U22F10 xy) : this(xy.X, xy.Y) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 operator +(Vector2U22F10 a, Vector2U22F10 b) => new Vector2U22F10(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 operator -(Vector2U22F10 a, Vector2U22F10 b) => new Vector2U22F10(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 operator *(Vector2U22F10 a, Vector2U22F10 b) => new Vector2U22F10(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 operator *(Vector2U22F10 a, U22F10 b) => new Vector2U22F10(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 operator *(U22F10 a, Vector2U22F10 b) => new Vector2U22F10(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 operator /(Vector2U22F10 a, Vector2U22F10 b) => new Vector2U22F10(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 operator /(Vector2U22F10 a, U22F10 b) => new Vector2U22F10(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U22F10 operator /(U22F10 a, Vector2U22F10 b) => new Vector2U22F10(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U22F10 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(X, X); }
        public readonly Vector2U22F10 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(X, Y); }
        public readonly Vector2U22F10 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Y, X); }
        public readonly Vector2U22F10 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U22F10(Y, Y); }
        public readonly Vector3U22F10 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, X, X); }
        public readonly Vector3U22F10 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, X, Y); }
        public readonly Vector3U22F10 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Y, X); }
        public readonly Vector3U22F10 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(X, Y, Y); }
        public readonly Vector3U22F10 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, X, X); }
        public readonly Vector3U22F10 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, X, Y); }
        public readonly Vector3U22F10 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Y, X); }
        public readonly Vector3U22F10 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U22F10(Y, Y, Y); }
        public readonly Vector4U22F10 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, X, X); }
        public readonly Vector4U22F10 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, X, Y); }
        public readonly Vector4U22F10 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Y, X); }
        public readonly Vector4U22F10 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, X, Y, Y); }
        public readonly Vector4U22F10 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, X, X); }
        public readonly Vector4U22F10 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, X, Y); }
        public readonly Vector4U22F10 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Y, X); }
        public readonly Vector4U22F10 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(X, Y, Y, Y); }
        public readonly Vector4U22F10 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, X, X); }
        public readonly Vector4U22F10 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, X, Y); }
        public readonly Vector4U22F10 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Y, X); }
        public readonly Vector4U22F10 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, X, Y, Y); }
        public readonly Vector4U22F10 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, X, X); }
        public readonly Vector4U22F10 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, X, Y); }
        public readonly Vector4U22F10 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Y, X); }
        public readonly Vector4U22F10 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U22F10(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U22F10 lhs, Vector2U22F10 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U22F10 lhs, Vector2U22F10 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U22F10 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U22F10({X}, {Y})";

        // IEquatable<Vector2U22F10>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U22F10 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U22F10({x}, {y})";
        }
    }
}
