using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I7F25 : IEquatable<Vector2I7F25>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I7F25 X;
        public I7F25 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector2I7F25 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I7F25(I7F25 x, I7F25 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I7F25(I7F25 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I7F25(Vector2I7F25 xy) : this(xy.X, xy.Y) { }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 operator +(Vector2I7F25 a, Vector2I7F25 b) => new Vector2I7F25(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 operator -(Vector2I7F25 a, Vector2I7F25 b) => new Vector2I7F25(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 operator *(Vector2I7F25 a, Vector2I7F25 b) => new Vector2I7F25(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 operator *(Vector2I7F25 a, I7F25 b) => new Vector2I7F25(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 operator *(I7F25 a, Vector2I7F25 b) => new Vector2I7F25(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 operator /(Vector2I7F25 a, Vector2I7F25 b) => new Vector2I7F25(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 operator /(Vector2I7F25 a, I7F25 b) => new Vector2I7F25(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I7F25 operator /(I7F25 a, Vector2I7F25 b) => new Vector2I7F25(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I7F25 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(X, X); }
        public readonly Vector2I7F25 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(X, Y); }
        public readonly Vector2I7F25 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Y, X); }
        public readonly Vector2I7F25 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Y, Y); }
        public readonly Vector3I7F25 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, X, X); }
        public readonly Vector3I7F25 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, X, Y); }
        public readonly Vector3I7F25 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Y, X); }
        public readonly Vector3I7F25 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Y, Y); }
        public readonly Vector3I7F25 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, X, X); }
        public readonly Vector3I7F25 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, X, Y); }
        public readonly Vector3I7F25 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Y, X); }
        public readonly Vector3I7F25 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Y, Y); }
        public readonly Vector4I7F25 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, X, X); }
        public readonly Vector4I7F25 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, X, Y); }
        public readonly Vector4I7F25 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Y, X); }
        public readonly Vector4I7F25 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Y, Y); }
        public readonly Vector4I7F25 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, X, X); }
        public readonly Vector4I7F25 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, X, Y); }
        public readonly Vector4I7F25 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Y, X); }
        public readonly Vector4I7F25 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Y, Y); }
        public readonly Vector4I7F25 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, X, X); }
        public readonly Vector4I7F25 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, X, Y); }
        public readonly Vector4I7F25 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Y, X); }
        public readonly Vector4I7F25 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Y, Y); }
        public readonly Vector4I7F25 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, X, X); }
        public readonly Vector4I7F25 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, X, Y); }
        public readonly Vector4I7F25 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Y, X); }
        public readonly Vector4I7F25 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I7F25 lhs, Vector2I7F25 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I7F25 lhs, Vector2I7F25 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I7F25 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I7F25({X}, {Y})";

        // IEquatable<Vector2I7F25>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I7F25 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2I7F25({x}, {y})";
        }
    }
}
