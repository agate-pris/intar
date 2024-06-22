using AgatePris.Intar.Numerics;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Mathematics {
    [Serializable]
    public struct Vector2I16F16 : IEquatable<Vector2I16F16>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I16F16 X;
        public I16F16 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constants
        // ---------------------------------------

        public static readonly Vector2I16F16 zero;

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16(I16F16 x, I16F16 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16(Vector2I16F16 xy) {
            X = xy.X;
            Y = xy.Y;
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator +(Vector2I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator -(Vector2I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator *(Vector2I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator *(Vector2I16F16 a, I16F16 b) => new Vector2I16F16(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator *(I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator /(Vector2I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator /(Vector2I16F16 a, I16F16 b) => new Vector2I16F16(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator /(I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a / b.X,
            a / b.Y);

        // Swizzling Properties
        // ---------------------------------------

#pragma warning disable IDE1006 // 命名スタイル

        public readonly Vector2I16F16 xx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(X, X); }
        public readonly Vector2I16F16 xy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(X, Y); }
        public readonly Vector2I16F16 yx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(Y, X); }
        public readonly Vector2I16F16 yy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(Y, Y); }
        public readonly Vector3I16F16 xxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, X, X); }
        public readonly Vector3I16F16 xxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, X, Y); }
        public readonly Vector3I16F16 xyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, Y, X); }
        public readonly Vector3I16F16 xyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, Y, Y); }
        public readonly Vector3I16F16 yxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, X, X); }
        public readonly Vector3I16F16 yxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, X, Y); }
        public readonly Vector3I16F16 yyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, Y, X); }
        public readonly Vector3I16F16 yyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, Y, Y); }
        public readonly Vector4I16F16 xxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, X, X); }
        public readonly Vector4I16F16 xxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, X, Y); }
        public readonly Vector4I16F16 xxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, Y, X); }
        public readonly Vector4I16F16 xxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, Y, Y); }
        public readonly Vector4I16F16 xyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, X, X); }
        public readonly Vector4I16F16 xyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, X, Y); }
        public readonly Vector4I16F16 xyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, Y, X); }
        public readonly Vector4I16F16 xyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, Y, Y); }
        public readonly Vector4I16F16 yxxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, X, X); }
        public readonly Vector4I16F16 yxxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, X, Y); }
        public readonly Vector4I16F16 yxyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, Y, X); }
        public readonly Vector4I16F16 yxyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, Y, Y); }
        public readonly Vector4I16F16 yyxx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, X, X); }
        public readonly Vector4I16F16 yyxy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, X, Y); }
        public readonly Vector4I16F16 yyyx { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, Y, X); }
        public readonly Vector4I16F16 yyyy { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, Y, Y); }

#pragma warning restore IDE1006 // 命名スタイル

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I16F16 lhs, Vector2I16F16 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I16F16 lhs, Vector2I16F16 rhs) => !(lhs == rhs);

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I16F16 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"Vector2I16F16({X}, {Y})";

        // IEquatable<Vector2I16F16>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I16F16 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"Vector2I16F16({x}, {y})";
        }
    }
}
