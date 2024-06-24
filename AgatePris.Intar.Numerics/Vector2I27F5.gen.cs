using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I27F5 : IEquatable<Vector2I27F5>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I27F5 X;
        public I27F5 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I27F5(I27F5 x, I27F5 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I27F5(I27F5 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I27F5(Vector2I27F5 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I27F5 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I27F5(I27F5.Zero);
        }
        public static Vector2I27F5 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I27F5(I27F5.One);
        }
        public static Vector2I27F5 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I27F5(I27F5.One, I27F5.Zero);
        }
        public static Vector2I27F5 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I27F5(I27F5.Zero, I27F5.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator +(Vector2I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator -(Vector2I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator *(Vector2I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator *(Vector2I27F5 a, I27F5 b) => new Vector2I27F5(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator *(I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator /(Vector2I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator /(Vector2I27F5 a, I27F5 b) => new Vector2I27F5(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator /(I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I27F5 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(X, X); }
        public readonly Vector2I27F5 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(X, Y); }
        public readonly Vector2I27F5 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Y, X); }
        public readonly Vector2I27F5 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Y, Y); }
        public readonly Vector3I27F5 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, X, X); }
        public readonly Vector3I27F5 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, X, Y); }
        public readonly Vector3I27F5 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Y, X); }
        public readonly Vector3I27F5 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Y, Y); }
        public readonly Vector3I27F5 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, X, X); }
        public readonly Vector3I27F5 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, X, Y); }
        public readonly Vector3I27F5 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Y, X); }
        public readonly Vector3I27F5 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Y, Y); }
        public readonly Vector4I27F5 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, X, X); }
        public readonly Vector4I27F5 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, X, Y); }
        public readonly Vector4I27F5 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Y, X); }
        public readonly Vector4I27F5 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Y, Y); }
        public readonly Vector4I27F5 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, X, X); }
        public readonly Vector4I27F5 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, X, Y); }
        public readonly Vector4I27F5 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Y, X); }
        public readonly Vector4I27F5 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Y, Y); }
        public readonly Vector4I27F5 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, X, X); }
        public readonly Vector4I27F5 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, X, Y); }
        public readonly Vector4I27F5 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Y, X); }
        public readonly Vector4I27F5 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Y, Y); }
        public readonly Vector4I27F5 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, X, X); }
        public readonly Vector4I27F5 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, X, Y); }
        public readonly Vector4I27F5 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Y, X); }
        public readonly Vector4I27F5 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I27F5 lhs, Vector2I27F5 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I27F5 lhs, Vector2I27F5 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I27F5 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I27F5({X}, {Y})";

        // IEquatable<Vector2I27F5>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I27F5 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2I27F5({x}, {y})";
        }
    }
}
