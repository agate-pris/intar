using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U11F21 : IEquatable<Vector2U11F21>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U11F21 X;
        public U11F21 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector2U11F21 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U11F21(U11F21 x, U11F21 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U11F21(U11F21 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U11F21(Vector2U11F21 xy) : this(xy.X, xy.Y) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator +(Vector2U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator -(Vector2U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator *(Vector2U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator *(Vector2U11F21 a, U11F21 b) => new Vector2U11F21(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator *(U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator /(Vector2U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator /(Vector2U11F21 a, U11F21 b) => new Vector2U11F21(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator /(U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U11F21 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(X, X); }
        public readonly Vector2U11F21 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(X, Y); }
        public readonly Vector2U11F21 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Y, X); }
        public readonly Vector2U11F21 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Y, Y); }
        public readonly Vector3U11F21 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, X, X); }
        public readonly Vector3U11F21 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, X, Y); }
        public readonly Vector3U11F21 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Y, X); }
        public readonly Vector3U11F21 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Y, Y); }
        public readonly Vector3U11F21 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, X, X); }
        public readonly Vector3U11F21 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, X, Y); }
        public readonly Vector3U11F21 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Y, X); }
        public readonly Vector3U11F21 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Y, Y); }
        public readonly Vector4U11F21 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, X, X); }
        public readonly Vector4U11F21 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, X, Y); }
        public readonly Vector4U11F21 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Y, X); }
        public readonly Vector4U11F21 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Y, Y); }
        public readonly Vector4U11F21 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, X, X); }
        public readonly Vector4U11F21 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, X, Y); }
        public readonly Vector4U11F21 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Y, X); }
        public readonly Vector4U11F21 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Y, Y); }
        public readonly Vector4U11F21 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, X, X); }
        public readonly Vector4U11F21 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, X, Y); }
        public readonly Vector4U11F21 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Y, X); }
        public readonly Vector4U11F21 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Y, Y); }
        public readonly Vector4U11F21 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, X, X); }
        public readonly Vector4U11F21 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, X, Y); }
        public readonly Vector4U11F21 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Y, X); }
        public readonly Vector4U11F21 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U11F21 lhs, Vector2U11F21 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U11F21 lhs, Vector2U11F21 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U11F21 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U11F21({X}, {Y})";

        // IEquatable<Vector2U11F21>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U11F21 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U11F21({x}, {y})";
        }
    }
}
