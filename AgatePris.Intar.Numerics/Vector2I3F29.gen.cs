using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I3F29 : IEquatable<Vector2I3F29>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I3F29 X;
        public I3F29 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I3F29(I3F29 x, I3F29 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I3F29(I3F29 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I3F29(Vector2I3F29 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I3F29 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I3F29(I3F29.Zero);
        }
        public static Vector2I3F29 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I3F29(I3F29.One);
        }
        public static Vector2I3F29 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I3F29(I3F29.One, I3F29.Zero);
        }
        public static Vector2I3F29 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I3F29(I3F29.Zero, I3F29.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 operator +(Vector2I3F29 a, Vector2I3F29 b) => new Vector2I3F29(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 operator -(Vector2I3F29 a, Vector2I3F29 b) => new Vector2I3F29(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 operator *(Vector2I3F29 a, Vector2I3F29 b) => new Vector2I3F29(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 operator *(Vector2I3F29 a, I3F29 b) => new Vector2I3F29(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 operator *(I3F29 a, Vector2I3F29 b) => new Vector2I3F29(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 operator /(Vector2I3F29 a, Vector2I3F29 b) => new Vector2I3F29(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 operator /(Vector2I3F29 a, I3F29 b) => new Vector2I3F29(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I3F29 operator /(I3F29 a, Vector2I3F29 b) => new Vector2I3F29(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I3F29 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(X, X); }
        public readonly Vector2I3F29 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(X, Y); }
        public readonly Vector2I3F29 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(Y, X); }
        public readonly Vector2I3F29 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I3F29(Y, Y); }
        public readonly Vector3I3F29 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(X, X, X); }
        public readonly Vector3I3F29 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(X, X, Y); }
        public readonly Vector3I3F29 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(X, Y, X); }
        public readonly Vector3I3F29 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(X, Y, Y); }
        public readonly Vector3I3F29 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Y, X, X); }
        public readonly Vector3I3F29 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Y, X, Y); }
        public readonly Vector3I3F29 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Y, Y, X); }
        public readonly Vector3I3F29 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I3F29(Y, Y, Y); }
        public readonly Vector4I3F29 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, X, X, X); }
        public readonly Vector4I3F29 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, X, X, Y); }
        public readonly Vector4I3F29 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, X, Y, X); }
        public readonly Vector4I3F29 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, X, Y, Y); }
        public readonly Vector4I3F29 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Y, X, X); }
        public readonly Vector4I3F29 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Y, X, Y); }
        public readonly Vector4I3F29 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Y, Y, X); }
        public readonly Vector4I3F29 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(X, Y, Y, Y); }
        public readonly Vector4I3F29 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, X, X, X); }
        public readonly Vector4I3F29 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, X, X, Y); }
        public readonly Vector4I3F29 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, X, Y, X); }
        public readonly Vector4I3F29 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, X, Y, Y); }
        public readonly Vector4I3F29 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Y, X, X); }
        public readonly Vector4I3F29 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Y, X, Y); }
        public readonly Vector4I3F29 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Y, Y, X); }
        public readonly Vector4I3F29 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I3F29(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I3F29 lhs, Vector2I3F29 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I3F29 lhs, Vector2I3F29 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I3F29 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I3F29({X}, {Y})";

        // IEquatable<Vector2I3F29>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I3F29 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2I3F29({x}, {y})";
        }
    }
}
