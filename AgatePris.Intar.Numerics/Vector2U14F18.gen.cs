using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U14F18 : IEquatable<Vector2U14F18>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U14F18 X;
        public U14F18 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18(U14F18 x, U14F18 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18(U14F18 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18(Vector2U14F18 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U14F18 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U14F18(U14F18.Zero);
        }
        public static Vector2U14F18 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U14F18(U14F18.One);
        }
        public static Vector2U14F18 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U14F18(U14F18.One, U14F18.Zero);
        }
        public static Vector2U14F18 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U14F18(U14F18.Zero, U14F18.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator +(Vector2U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator -(Vector2U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator *(Vector2U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator *(Vector2U14F18 a, U14F18 b) => new Vector2U14F18(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator *(U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator /(Vector2U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator /(Vector2U14F18 a, U14F18 b) => new Vector2U14F18(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator /(U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U14F18 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(X, X); }
        public readonly Vector2U14F18 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(X, Y); }
        public readonly Vector2U14F18 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(Y, X); }
        public readonly Vector2U14F18 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(Y, Y); }
        public readonly Vector3U14F18 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, X, X); }
        public readonly Vector3U14F18 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, X, Y); }
        public readonly Vector3U14F18 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, Y, X); }
        public readonly Vector3U14F18 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, Y, Y); }
        public readonly Vector3U14F18 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, X, X); }
        public readonly Vector3U14F18 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, X, Y); }
        public readonly Vector3U14F18 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, Y, X); }
        public readonly Vector3U14F18 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, Y, Y); }
        public readonly Vector4U14F18 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, X, X); }
        public readonly Vector4U14F18 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, X, Y); }
        public readonly Vector4U14F18 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, Y, X); }
        public readonly Vector4U14F18 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, Y, Y); }
        public readonly Vector4U14F18 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, X, X); }
        public readonly Vector4U14F18 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, X, Y); }
        public readonly Vector4U14F18 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, Y, X); }
        public readonly Vector4U14F18 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, Y, Y); }
        public readonly Vector4U14F18 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, X, X); }
        public readonly Vector4U14F18 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, X, Y); }
        public readonly Vector4U14F18 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, Y, X); }
        public readonly Vector4U14F18 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, Y, Y); }
        public readonly Vector4U14F18 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, X, X); }
        public readonly Vector4U14F18 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, X, Y); }
        public readonly Vector4U14F18 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, Y, X); }
        public readonly Vector4U14F18 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U14F18 lhs, Vector2U14F18 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U14F18 lhs, Vector2U14F18 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U14F18 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U14F18({X}, {Y})";

        // IEquatable<Vector2U14F18>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U14F18 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U14F18({x}, {y})";
        }
    }
}
