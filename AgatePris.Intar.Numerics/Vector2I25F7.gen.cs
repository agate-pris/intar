using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I25F7 : IEquatable<Vector2I25F7>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I25F7 X;
        public I25F7 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector2I25F7 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I25F7(I25F7 x, I25F7 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I25F7(Vector2I25F7 xy) {
            X = xy.X;
            Y = xy.Y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 operator +(Vector2I25F7 a, Vector2I25F7 b) => new Vector2I25F7(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 operator -(Vector2I25F7 a, Vector2I25F7 b) => new Vector2I25F7(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 operator *(Vector2I25F7 a, Vector2I25F7 b) => new Vector2I25F7(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 operator *(Vector2I25F7 a, I25F7 b) => new Vector2I25F7(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 operator *(I25F7 a, Vector2I25F7 b) => new Vector2I25F7(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 operator /(Vector2I25F7 a, Vector2I25F7 b) => new Vector2I25F7(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 operator /(Vector2I25F7 a, I25F7 b) => new Vector2I25F7(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 operator /(I25F7 a, Vector2I25F7 b) => new Vector2I25F7(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I25F7 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(X, X); }
        public readonly Vector2I25F7 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(X, Y); }
        public readonly Vector2I25F7 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(Y, X); }
        public readonly Vector2I25F7 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(Y, Y); }
        public readonly Vector3I25F7 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, X, X); }
        public readonly Vector3I25F7 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, X, Y); }
        public readonly Vector3I25F7 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, Y, X); }
        public readonly Vector3I25F7 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, Y, Y); }
        public readonly Vector3I25F7 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, X, X); }
        public readonly Vector3I25F7 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, X, Y); }
        public readonly Vector3I25F7 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, Y, X); }
        public readonly Vector3I25F7 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, Y, Y); }
        public readonly Vector4I25F7 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, X, X); }
        public readonly Vector4I25F7 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, X, Y); }
        public readonly Vector4I25F7 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, Y, X); }
        public readonly Vector4I25F7 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, Y, Y); }
        public readonly Vector4I25F7 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, X, X); }
        public readonly Vector4I25F7 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, X, Y); }
        public readonly Vector4I25F7 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, Y, X); }
        public readonly Vector4I25F7 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, Y, Y); }
        public readonly Vector4I25F7 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, X, X); }
        public readonly Vector4I25F7 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, X, Y); }
        public readonly Vector4I25F7 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, Y, X); }
        public readonly Vector4I25F7 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, Y, Y); }
        public readonly Vector4I25F7 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, X, X); }
        public readonly Vector4I25F7 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, X, Y); }
        public readonly Vector4I25F7 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, Y, X); }
        public readonly Vector4I25F7 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I25F7 lhs, Vector2I25F7 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I25F7 lhs, Vector2I25F7 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I25F7 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I25F7({X}, {Y})";

        // IEquatable<Vector2I25F7>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I25F7 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2I25F7({x}, {y})";
        }
    }
}