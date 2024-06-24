using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U31F1 : IEquatable<Vector2U31F1>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U31F1 X;
        public U31F1 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U31F1(U31F1 x, U31F1 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U31F1(U31F1 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U31F1(Vector2U31F1 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U31F1 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U31F1(U31F1.Zero);
        }
        public static Vector2U31F1 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U31F1(U31F1.One);
        }
        public static Vector2U31F1 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U31F1(U31F1.One, U31F1.Zero);
        }
        public static Vector2U31F1 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U31F1(U31F1.Zero, U31F1.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 operator +(Vector2U31F1 a, Vector2U31F1 b) => new Vector2U31F1(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 operator -(Vector2U31F1 a, Vector2U31F1 b) => new Vector2U31F1(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 operator *(Vector2U31F1 a, Vector2U31F1 b) => new Vector2U31F1(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 operator *(Vector2U31F1 a, U31F1 b) => new Vector2U31F1(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 operator *(U31F1 a, Vector2U31F1 b) => new Vector2U31F1(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 operator /(Vector2U31F1 a, Vector2U31F1 b) => new Vector2U31F1(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 operator /(Vector2U31F1 a, U31F1 b) => new Vector2U31F1(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U31F1 operator /(U31F1 a, Vector2U31F1 b) => new Vector2U31F1(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U31F1 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(X, X); }
        public readonly Vector2U31F1 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(X, Y); }
        public readonly Vector2U31F1 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(Y, X); }
        public readonly Vector2U31F1 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U31F1(Y, Y); }
        public readonly Vector3U31F1 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, X, X); }
        public readonly Vector3U31F1 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, X, Y); }
        public readonly Vector3U31F1 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, Y, X); }
        public readonly Vector3U31F1 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(X, Y, Y); }
        public readonly Vector3U31F1 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, X, X); }
        public readonly Vector3U31F1 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, X, Y); }
        public readonly Vector3U31F1 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, Y, X); }
        public readonly Vector3U31F1 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U31F1(Y, Y, Y); }
        public readonly Vector4U31F1 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, X, X); }
        public readonly Vector4U31F1 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, X, Y); }
        public readonly Vector4U31F1 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, Y, X); }
        public readonly Vector4U31F1 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, X, Y, Y); }
        public readonly Vector4U31F1 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, X, X); }
        public readonly Vector4U31F1 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, X, Y); }
        public readonly Vector4U31F1 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, Y, X); }
        public readonly Vector4U31F1 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(X, Y, Y, Y); }
        public readonly Vector4U31F1 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, X, X); }
        public readonly Vector4U31F1 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, X, Y); }
        public readonly Vector4U31F1 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, Y, X); }
        public readonly Vector4U31F1 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, X, Y, Y); }
        public readonly Vector4U31F1 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, X, X); }
        public readonly Vector4U31F1 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, X, Y); }
        public readonly Vector4U31F1 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, Y, X); }
        public readonly Vector4U31F1 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U31F1(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U31F1 lhs, Vector2U31F1 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U31F1 lhs, Vector2U31F1 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U31F1 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U31F1({X}, {Y})";

        // IEquatable<Vector2U31F1>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U31F1 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U31F1({x}, {y})";
        }
    }
}
