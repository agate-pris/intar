using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I20F12 : IEquatable<Vector2I20F12>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I20F12 X;
        public I20F12 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I20F12(I20F12 x, I20F12 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I20F12(I20F12 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I20F12(Vector2I20F12 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I20F12 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I20F12(I20F12.Zero);
        }
        public static Vector2I20F12 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I20F12(I20F12.One);
        }
        public static Vector2I20F12 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I20F12(I20F12.One, I20F12.Zero);
        }
        public static Vector2I20F12 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I20F12(I20F12.Zero, I20F12.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 operator +(Vector2I20F12 a, Vector2I20F12 b) => new Vector2I20F12(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 operator -(Vector2I20F12 a, Vector2I20F12 b) => new Vector2I20F12(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 operator *(Vector2I20F12 a, Vector2I20F12 b) => new Vector2I20F12(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 operator *(Vector2I20F12 a, I20F12 b) => new Vector2I20F12(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 operator *(I20F12 a, Vector2I20F12 b) => new Vector2I20F12(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 operator /(Vector2I20F12 a, Vector2I20F12 b) => new Vector2I20F12(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 operator /(Vector2I20F12 a, I20F12 b) => new Vector2I20F12(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I20F12 operator /(I20F12 a, Vector2I20F12 b) => new Vector2I20F12(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I20F12 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(X, X); }
        public readonly Vector2I20F12 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(X, Y); }
        public readonly Vector2I20F12 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Y, X); }
        public readonly Vector2I20F12 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Y, Y); }
        public readonly Vector3I20F12 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, X, X); }
        public readonly Vector3I20F12 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, X, Y); }
        public readonly Vector3I20F12 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Y, X); }
        public readonly Vector3I20F12 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Y, Y); }
        public readonly Vector3I20F12 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, X, X); }
        public readonly Vector3I20F12 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, X, Y); }
        public readonly Vector3I20F12 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Y, X); }
        public readonly Vector3I20F12 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Y, Y); }
        public readonly Vector4I20F12 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, X, X); }
        public readonly Vector4I20F12 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, X, Y); }
        public readonly Vector4I20F12 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Y, X); }
        public readonly Vector4I20F12 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Y, Y); }
        public readonly Vector4I20F12 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, X, X); }
        public readonly Vector4I20F12 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, X, Y); }
        public readonly Vector4I20F12 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Y, X); }
        public readonly Vector4I20F12 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Y, Y); }
        public readonly Vector4I20F12 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, X, X); }
        public readonly Vector4I20F12 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, X, Y); }
        public readonly Vector4I20F12 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Y, X); }
        public readonly Vector4I20F12 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Y, Y); }
        public readonly Vector4I20F12 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, X, X); }
        public readonly Vector4I20F12 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, X, Y); }
        public readonly Vector4I20F12 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Y, X); }
        public readonly Vector4I20F12 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I20F12 lhs, Vector2I20F12 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I20F12 lhs, Vector2I20F12 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I20F12 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I20F12({X}, {Y})";

        // IEquatable<Vector2I20F12>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I20F12 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2I20F12({x}, {y})";
        }
    }
}
