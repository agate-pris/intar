using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I18F14 : IEquatable<Vector2I18F14>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I18F14 X;
        public I18F14 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14(I18F14 x, I18F14 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14(I18F14 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14(Vector2I18F14 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I18F14 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I18F14(I18F14.Zero);
        }
        public static Vector2I18F14 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I18F14(I18F14.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator +(Vector2I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator -(Vector2I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator *(Vector2I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator *(Vector2I18F14 a, I18F14 b) => new Vector2I18F14(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator *(I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator /(Vector2I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator /(Vector2I18F14 a, I18F14 b) => new Vector2I18F14(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator /(I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I18F14 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(X, X); }
        public readonly Vector2I18F14 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(X, Y); }
        public readonly Vector2I18F14 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Y, X); }
        public readonly Vector2I18F14 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Y, Y); }
        public readonly Vector3I18F14 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, X, X); }
        public readonly Vector3I18F14 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, X, Y); }
        public readonly Vector3I18F14 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Y, X); }
        public readonly Vector3I18F14 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Y, Y); }
        public readonly Vector3I18F14 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, X, X); }
        public readonly Vector3I18F14 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, X, Y); }
        public readonly Vector3I18F14 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Y, X); }
        public readonly Vector3I18F14 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Y, Y); }
        public readonly Vector4I18F14 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, X, X); }
        public readonly Vector4I18F14 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, X, Y); }
        public readonly Vector4I18F14 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Y, X); }
        public readonly Vector4I18F14 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Y, Y); }
        public readonly Vector4I18F14 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, X, X); }
        public readonly Vector4I18F14 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, X, Y); }
        public readonly Vector4I18F14 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Y, X); }
        public readonly Vector4I18F14 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Y, Y); }
        public readonly Vector4I18F14 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, X, X); }
        public readonly Vector4I18F14 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, X, Y); }
        public readonly Vector4I18F14 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Y, X); }
        public readonly Vector4I18F14 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Y, Y); }
        public readonly Vector4I18F14 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, X, X); }
        public readonly Vector4I18F14 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, X, Y); }
        public readonly Vector4I18F14 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Y, X); }
        public readonly Vector4I18F14 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I18F14 lhs, Vector2I18F14 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I18F14 lhs, Vector2I18F14 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I18F14 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I18F14({X}, {Y})";

        // IEquatable<Vector2I18F14>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I18F14 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2I18F14({x}, {y})";
        }
    }
}
