using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U21F11 : IEquatable<Vector2U21F11>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U21F11 X;
        public U21F11 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector2U21F11 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U21F11(U21F11 x, U21F11 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U21F11(Vector2U21F11 xy) : this(xy.X, xy.Y) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 operator +(Vector2U21F11 a, Vector2U21F11 b) => new Vector2U21F11(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 operator -(Vector2U21F11 a, Vector2U21F11 b) => new Vector2U21F11(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 operator *(Vector2U21F11 a, Vector2U21F11 b) => new Vector2U21F11(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 operator *(Vector2U21F11 a, U21F11 b) => new Vector2U21F11(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 operator *(U21F11 a, Vector2U21F11 b) => new Vector2U21F11(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 operator /(Vector2U21F11 a, Vector2U21F11 b) => new Vector2U21F11(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 operator /(Vector2U21F11 a, U21F11 b) => new Vector2U21F11(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U21F11 operator /(U21F11 a, Vector2U21F11 b) => new Vector2U21F11(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U21F11 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(X, X); }
        public readonly Vector2U21F11 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(X, Y); }
        public readonly Vector2U21F11 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Y, X); }
        public readonly Vector2U21F11 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U21F11(Y, Y); }
        public readonly Vector3U21F11 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, X, X); }
        public readonly Vector3U21F11 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, X, Y); }
        public readonly Vector3U21F11 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Y, X); }
        public readonly Vector3U21F11 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(X, Y, Y); }
        public readonly Vector3U21F11 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, X, X); }
        public readonly Vector3U21F11 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, X, Y); }
        public readonly Vector3U21F11 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Y, X); }
        public readonly Vector3U21F11 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U21F11(Y, Y, Y); }
        public readonly Vector4U21F11 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, X, X); }
        public readonly Vector4U21F11 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, X, Y); }
        public readonly Vector4U21F11 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Y, X); }
        public readonly Vector4U21F11 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, X, Y, Y); }
        public readonly Vector4U21F11 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, X, X); }
        public readonly Vector4U21F11 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, X, Y); }
        public readonly Vector4U21F11 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Y, X); }
        public readonly Vector4U21F11 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(X, Y, Y, Y); }
        public readonly Vector4U21F11 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, X, X); }
        public readonly Vector4U21F11 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, X, Y); }
        public readonly Vector4U21F11 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Y, X); }
        public readonly Vector4U21F11 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, X, Y, Y); }
        public readonly Vector4U21F11 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, X, X); }
        public readonly Vector4U21F11 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, X, Y); }
        public readonly Vector4U21F11 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Y, X); }
        public readonly Vector4U21F11 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U21F11(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U21F11 lhs, Vector2U21F11 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U21F11 lhs, Vector2U21F11 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U21F11 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U21F11({X}, {Y})";

        // IEquatable<Vector2U21F11>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U21F11 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U21F11({x}, {y})";
        }
    }
}
