using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U12F20 : IEquatable<Vector2U12F20>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U12F20 X;
        public U12F20 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector2U12F20 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U12F20(U12F20 x, U12F20 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U12F20(U12F20 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U12F20(Vector2U12F20 xy) : this(xy.X, xy.Y) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator +(Vector2U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator -(Vector2U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator *(Vector2U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator *(Vector2U12F20 a, U12F20 b) => new Vector2U12F20(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator *(U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator /(Vector2U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator /(Vector2U12F20 a, U12F20 b) => new Vector2U12F20(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U12F20 operator /(U12F20 a, Vector2U12F20 b) => new Vector2U12F20(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U12F20 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(X, X); }
        public readonly Vector2U12F20 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(X, Y); }
        public readonly Vector2U12F20 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(Y, X); }
        public readonly Vector2U12F20 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U12F20(Y, Y); }
        public readonly Vector3U12F20 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(X, X, X); }
        public readonly Vector3U12F20 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(X, X, Y); }
        public readonly Vector3U12F20 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(X, Y, X); }
        public readonly Vector3U12F20 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(X, Y, Y); }
        public readonly Vector3U12F20 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(Y, X, X); }
        public readonly Vector3U12F20 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(Y, X, Y); }
        public readonly Vector3U12F20 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(Y, Y, X); }
        public readonly Vector3U12F20 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U12F20(Y, Y, Y); }
        public readonly Vector4U12F20 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(X, X, X, X); }
        public readonly Vector4U12F20 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(X, X, X, Y); }
        public readonly Vector4U12F20 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(X, X, Y, X); }
        public readonly Vector4U12F20 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(X, X, Y, Y); }
        public readonly Vector4U12F20 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(X, Y, X, X); }
        public readonly Vector4U12F20 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(X, Y, X, Y); }
        public readonly Vector4U12F20 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(X, Y, Y, X); }
        public readonly Vector4U12F20 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(X, Y, Y, Y); }
        public readonly Vector4U12F20 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(Y, X, X, X); }
        public readonly Vector4U12F20 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(Y, X, X, Y); }
        public readonly Vector4U12F20 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(Y, X, Y, X); }
        public readonly Vector4U12F20 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(Y, X, Y, Y); }
        public readonly Vector4U12F20 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(Y, Y, X, X); }
        public readonly Vector4U12F20 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(Y, Y, X, Y); }
        public readonly Vector4U12F20 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(Y, Y, Y, X); }
        public readonly Vector4U12F20 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U12F20(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U12F20 lhs, Vector2U12F20 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U12F20 lhs, Vector2U12F20 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U12F20 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U12F20({X}, {Y})";

        // IEquatable<Vector2U12F20>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U12F20 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U12F20({x}, {y})";
        }
    }
}
