using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I26F6 : IEquatable<Vector2I26F6>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I26F6 X;
        public I26F6 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector2I26F6 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I26F6(I26F6 x, I26F6 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I26F6(Vector2I26F6 xy) {
            X = xy.X;
            Y = xy.Y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator +(Vector2I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator -(Vector2I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator *(Vector2I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator *(Vector2I26F6 a, I26F6 b) => new Vector2I26F6(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator *(I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator /(Vector2I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator /(Vector2I26F6 a, I26F6 b) => new Vector2I26F6(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator /(I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I26F6 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(X, X); }
        public readonly Vector2I26F6 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(X, Y); }
        public readonly Vector2I26F6 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(Y, X); }
        public readonly Vector2I26F6 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(Y, Y); }
        public readonly Vector3I26F6 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, X, X); }
        public readonly Vector3I26F6 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, X, Y); }
        public readonly Vector3I26F6 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, Y, X); }
        public readonly Vector3I26F6 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, Y, Y); }
        public readonly Vector3I26F6 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, X, X); }
        public readonly Vector3I26F6 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, X, Y); }
        public readonly Vector3I26F6 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, Y, X); }
        public readonly Vector3I26F6 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, Y, Y); }
        public readonly Vector4I26F6 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, X, X); }
        public readonly Vector4I26F6 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, X, Y); }
        public readonly Vector4I26F6 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, Y, X); }
        public readonly Vector4I26F6 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, Y, Y); }
        public readonly Vector4I26F6 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, X, X); }
        public readonly Vector4I26F6 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, X, Y); }
        public readonly Vector4I26F6 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, Y, X); }
        public readonly Vector4I26F6 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, Y, Y); }
        public readonly Vector4I26F6 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, X, X); }
        public readonly Vector4I26F6 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, X, Y); }
        public readonly Vector4I26F6 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, Y, X); }
        public readonly Vector4I26F6 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, Y, Y); }
        public readonly Vector4I26F6 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, X, X); }
        public readonly Vector4I26F6 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, X, Y); }
        public readonly Vector4I26F6 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, Y, X); }
        public readonly Vector4I26F6 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I26F6 lhs, Vector2I26F6 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I26F6 lhs, Vector2I26F6 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I26F6 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I26F6({X}, {Y})";

        // IEquatable<Vector2I26F6>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I26F6 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2I26F6({x}, {y})";
        }
    }
}
