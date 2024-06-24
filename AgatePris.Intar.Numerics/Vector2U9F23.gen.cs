using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U9F23 : IEquatable<Vector2U9F23>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U9F23 X;
        public U9F23 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23(U9F23 x, U9F23 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23(U9F23 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23(Vector2U9F23 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U9F23 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U9F23(U9F23.Zero);
        }
        public static Vector2U9F23 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U9F23(U9F23.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator +(Vector2U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator -(Vector2U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator *(Vector2U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator *(Vector2U9F23 a, U9F23 b) => new Vector2U9F23(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator *(U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator /(Vector2U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator /(Vector2U9F23 a, U9F23 b) => new Vector2U9F23(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator /(U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U9F23 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(X, X); }
        public readonly Vector2U9F23 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(X, Y); }
        public readonly Vector2U9F23 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Y, X); }
        public readonly Vector2U9F23 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Y, Y); }
        public readonly Vector3U9F23 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, X, X); }
        public readonly Vector3U9F23 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, X, Y); }
        public readonly Vector3U9F23 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Y, X); }
        public readonly Vector3U9F23 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Y, Y); }
        public readonly Vector3U9F23 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, X, X); }
        public readonly Vector3U9F23 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, X, Y); }
        public readonly Vector3U9F23 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Y, X); }
        public readonly Vector3U9F23 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Y, Y); }
        public readonly Vector4U9F23 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, X, X); }
        public readonly Vector4U9F23 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, X, Y); }
        public readonly Vector4U9F23 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Y, X); }
        public readonly Vector4U9F23 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Y, Y); }
        public readonly Vector4U9F23 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, X, X); }
        public readonly Vector4U9F23 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, X, Y); }
        public readonly Vector4U9F23 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Y, X); }
        public readonly Vector4U9F23 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Y, Y); }
        public readonly Vector4U9F23 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, X, X); }
        public readonly Vector4U9F23 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, X, Y); }
        public readonly Vector4U9F23 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Y, X); }
        public readonly Vector4U9F23 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Y, Y); }
        public readonly Vector4U9F23 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, X, X); }
        public readonly Vector4U9F23 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, X, Y); }
        public readonly Vector4U9F23 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Y, X); }
        public readonly Vector4U9F23 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U9F23 lhs, Vector2U9F23 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U9F23 lhs, Vector2U9F23 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U9F23 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U9F23({X}, {Y})";

        // IEquatable<Vector2U9F23>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U9F23 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U9F23({x}, {y})";
        }
    }
}
