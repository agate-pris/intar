using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U4F28 : IEquatable<Vector2U4F28>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U4F28 X;
        public U4F28 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U4F28(U4F28 x, U4F28 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U4F28(U4F28 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U4F28(Vector2U4F28 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U4F28 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U4F28(U4F28.Zero);
        }
        public static Vector2U4F28 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U4F28(U4F28.One);
        }
        public static Vector2U4F28 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U4F28(U4F28.One, U4F28.Zero);
        }
        public static Vector2U4F28 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U4F28(U4F28.Zero, U4F28.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 operator +(Vector2U4F28 a, Vector2U4F28 b) => new Vector2U4F28(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 operator -(Vector2U4F28 a, Vector2U4F28 b) => new Vector2U4F28(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 operator *(Vector2U4F28 a, Vector2U4F28 b) => new Vector2U4F28(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 operator *(Vector2U4F28 a, U4F28 b) => new Vector2U4F28(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 operator *(U4F28 a, Vector2U4F28 b) => new Vector2U4F28(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 operator /(Vector2U4F28 a, Vector2U4F28 b) => new Vector2U4F28(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 operator /(Vector2U4F28 a, U4F28 b) => new Vector2U4F28(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 operator /(U4F28 a, Vector2U4F28 b) => new Vector2U4F28(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2U4F28 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(X, X); }
        public readonly Vector2U4F28 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(X, Y); }
        public readonly Vector2U4F28 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Y, X); }
        public readonly Vector2U4F28 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Y, Y); }
        public readonly Vector3U4F28 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, X, X); }
        public readonly Vector3U4F28 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, X, Y); }
        public readonly Vector3U4F28 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Y, X); }
        public readonly Vector3U4F28 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Y, Y); }
        public readonly Vector3U4F28 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, X, X); }
        public readonly Vector3U4F28 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, X, Y); }
        public readonly Vector3U4F28 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Y, X); }
        public readonly Vector3U4F28 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Y, Y); }
        public readonly Vector4U4F28 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, X, X); }
        public readonly Vector4U4F28 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, X, Y); }
        public readonly Vector4U4F28 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Y, X); }
        public readonly Vector4U4F28 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Y, Y); }
        public readonly Vector4U4F28 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, X, X); }
        public readonly Vector4U4F28 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, X, Y); }
        public readonly Vector4U4F28 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Y, X); }
        public readonly Vector4U4F28 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Y, Y); }
        public readonly Vector4U4F28 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, X, X); }
        public readonly Vector4U4F28 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, X, Y); }
        public readonly Vector4U4F28 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Y, X); }
        public readonly Vector4U4F28 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Y, Y); }
        public readonly Vector4U4F28 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, X, X); }
        public readonly Vector4U4F28 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, X, Y); }
        public readonly Vector4U4F28 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Y, X); }
        public readonly Vector4U4F28 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U4F28 lhs, Vector2U4F28 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U4F28 lhs, Vector2U4F28 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U4F28 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2U4F28({X}, {Y})";

        // IEquatable<Vector2U4F28>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U4F28 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2U4F28({x}, {y})";
        }
    }
}
