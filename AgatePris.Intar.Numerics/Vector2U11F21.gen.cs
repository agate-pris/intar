using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U11F21 : IEquatable<Vector2U11F21>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U11F21 X;
        public U11F21 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U11F21(U11F21 x, U11F21 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U11F21(U11F21 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U11F21(Vector2U11F21 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U11F21 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U11F21(U11F21.Zero);
        }
        public static Vector2U11F21 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U11F21(U11F21.One);
        }
        public static Vector2U11F21 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U11F21(U11F21.One, U11F21.Zero);
        }
        public static Vector2U11F21 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U11F21(U11F21.Zero, U11F21.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator +(Vector2U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator -(Vector2U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator *(Vector2U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator *(Vector2U11F21 a, U11F21 b) => new Vector2U11F21(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator *(U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator /(Vector2U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator /(Vector2U11F21 a, U11F21 b) => new Vector2U11F21(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U11F21 operator /(U11F21 a, Vector2U11F21 b) => new Vector2U11F21(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U11F21 lhs, Vector2U11F21 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U11F21 lhs, Vector2U11F21 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U11F21 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(X, X); }
        public readonly Vector2U11F21 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(X, Y); }
        public readonly Vector2U11F21 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Y, X); }
        public readonly Vector2U11F21 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U11F21(Y, Y); }
        public readonly Vector3U11F21 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, X, X); }
        public readonly Vector3U11F21 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, X, Y); }
        public readonly Vector3U11F21 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Y, X); }
        public readonly Vector3U11F21 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(X, Y, Y); }
        public readonly Vector3U11F21 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, X, X); }
        public readonly Vector3U11F21 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, X, Y); }
        public readonly Vector3U11F21 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Y, X); }
        public readonly Vector3U11F21 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U11F21(Y, Y, Y); }
        public readonly Vector4U11F21 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, X, X); }
        public readonly Vector4U11F21 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, X, Y); }
        public readonly Vector4U11F21 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Y, X); }
        public readonly Vector4U11F21 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, X, Y, Y); }
        public readonly Vector4U11F21 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, X, X); }
        public readonly Vector4U11F21 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, X, Y); }
        public readonly Vector4U11F21 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Y, X); }
        public readonly Vector4U11F21 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(X, Y, Y, Y); }
        public readonly Vector4U11F21 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, X, X); }
        public readonly Vector4U11F21 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, X, Y); }
        public readonly Vector4U11F21 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Y, X); }
        public readonly Vector4U11F21 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, X, Y, Y); }
        public readonly Vector4U11F21 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, X, X); }
        public readonly Vector4U11F21 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, X, Y); }
        public readonly Vector4U11F21 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Y, X); }
        public readonly Vector4U11F21 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U11F21(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U11F21 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U11F21>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U11F21 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"<{x}, {y}>";
        }

        // Methods
        // ---------------------------------------

        public readonly Vector2U11F21 Half() => new Vector2U11F21(
            X.Half(),
            Y.Half());

        public readonly Vector2U11F21 Twice() => new Vector2U11F21(
            X.Twice(),
            Y.Twice());

        public readonly Vector2U11F21 Clamp(U11F21 min, U11F21 max) => new Vector2U11F21(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2U11F21 Clamp(
            Vector2U11F21 min, Vector2U11F21 max
        ) => new Vector2U11F21(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U11F21 SaturatingAdd(Vector2U11F21 other) => new Vector2U11F21(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U11F21 SaturatingMul(U11F21 other) => new Vector2U11F21(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U11F21 Dot(Vector2U11F21 other) {
            var x = ((ulong)X.Bits) * other.X.Bits;
            var y = ((ulong)Y.Bits) * other.Y.Bits;

            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算結果に合わせる｡
            var bits =
                (x / 4) +
                (y / 4);

            const ulong k = 1UL << 19;
            return U11F21.FromBits((uint)(bits / k));
        }

    }

    partial struct U11F21 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U11F21 SaturatingMul(Vector2U11F21 other) => other.SaturatingMul(this);
    }
}
