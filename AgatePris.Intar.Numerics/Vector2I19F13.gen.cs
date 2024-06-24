using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I19F13 : IEquatable<Vector2I19F13>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I19F13 X;
        public I19F13 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13(I19F13 x, I19F13 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13(I19F13 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13(Vector2I19F13 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I19F13 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I19F13(I19F13.Zero);
        }
        public static Vector2I19F13 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I19F13(I19F13.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator +(Vector2I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator -(Vector2I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator *(Vector2I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator *(Vector2I19F13 a, I19F13 b) => new Vector2I19F13(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator *(I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator /(Vector2I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator /(Vector2I19F13 a, I19F13 b) => new Vector2I19F13(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator /(I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I19F13 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(X, X); }
        public readonly Vector2I19F13 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(X, Y); }
        public readonly Vector2I19F13 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Y, X); }
        public readonly Vector2I19F13 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Y, Y); }
        public readonly Vector3I19F13 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, X, X); }
        public readonly Vector3I19F13 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, X, Y); }
        public readonly Vector3I19F13 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Y, X); }
        public readonly Vector3I19F13 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Y, Y); }
        public readonly Vector3I19F13 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, X, X); }
        public readonly Vector3I19F13 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, X, Y); }
        public readonly Vector3I19F13 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Y, X); }
        public readonly Vector3I19F13 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Y, Y); }
        public readonly Vector4I19F13 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, X, X); }
        public readonly Vector4I19F13 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, X, Y); }
        public readonly Vector4I19F13 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Y, X); }
        public readonly Vector4I19F13 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Y, Y); }
        public readonly Vector4I19F13 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, X, X); }
        public readonly Vector4I19F13 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, X, Y); }
        public readonly Vector4I19F13 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Y, X); }
        public readonly Vector4I19F13 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Y, Y); }
        public readonly Vector4I19F13 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, X, X); }
        public readonly Vector4I19F13 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, X, Y); }
        public readonly Vector4I19F13 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Y, X); }
        public readonly Vector4I19F13 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Y, Y); }
        public readonly Vector4I19F13 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, X, X); }
        public readonly Vector4I19F13 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, X, Y); }
        public readonly Vector4I19F13 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Y, X); }
        public readonly Vector4I19F13 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I19F13 lhs, Vector2I19F13 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I19F13 lhs, Vector2I19F13 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I19F13 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I19F13({X}, {Y})";

        // IEquatable<Vector2I19F13>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I19F13 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2I19F13({x}, {y})";
        }
    }
}
