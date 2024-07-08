using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U4F28 : IEquatable<Vector2U4F28>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U4F28 X;
        public U4F28 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U4F28(U4F28 x, U4F28 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U4F28(U4F28 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U4F28(Vector2U4F28 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U4F28 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U4F28(U4F28.Zero);
        }
        public static Vector2U4F28 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U4F28(U4F28.One);
        }
        public static Vector2U4F28 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U4F28(U4F28.One, U4F28.Zero);
        }
        public static Vector2U4F28 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U4F28(U4F28.Zero, U4F28.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 operator +(Vector2U4F28 a, Vector2U4F28 b) => new Vector2U4F28(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 operator -(Vector2U4F28 a, Vector2U4F28 b) => new Vector2U4F28(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 operator *(Vector2U4F28 a, Vector2U4F28 b) => new Vector2U4F28(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 operator *(Vector2U4F28 a, U4F28 b) => new Vector2U4F28(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 operator *(U4F28 a, Vector2U4F28 b) => new Vector2U4F28(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 operator /(Vector2U4F28 a, Vector2U4F28 b) => new Vector2U4F28(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 operator /(Vector2U4F28 a, U4F28 b) => new Vector2U4F28(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U4F28 operator /(U4F28 a, Vector2U4F28 b) => new Vector2U4F28(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U4F28 lhs, Vector2U4F28 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U4F28 lhs, Vector2U4F28 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U4F28 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(X, X); }
        public readonly Vector2U4F28 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(X, Y); }
        public readonly Vector2U4F28 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Y, X); }
        public readonly Vector2U4F28 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U4F28(Y, Y); }
        public readonly Vector3U4F28 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, X, X); }
        public readonly Vector3U4F28 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, X, Y); }
        public readonly Vector3U4F28 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Y, X); }
        public readonly Vector3U4F28 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(X, Y, Y); }
        public readonly Vector3U4F28 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, X, X); }
        public readonly Vector3U4F28 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, X, Y); }
        public readonly Vector3U4F28 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Y, X); }
        public readonly Vector3U4F28 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U4F28(Y, Y, Y); }
        public readonly Vector4U4F28 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, X, X); }
        public readonly Vector4U4F28 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, X, Y); }
        public readonly Vector4U4F28 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Y, X); }
        public readonly Vector4U4F28 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, X, Y, Y); }
        public readonly Vector4U4F28 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, X, X); }
        public readonly Vector4U4F28 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, X, Y); }
        public readonly Vector4U4F28 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Y, X); }
        public readonly Vector4U4F28 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(X, Y, Y, Y); }
        public readonly Vector4U4F28 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, X, X); }
        public readonly Vector4U4F28 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, X, Y); }
        public readonly Vector4U4F28 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Y, X); }
        public readonly Vector4U4F28 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, X, Y, Y); }
        public readonly Vector4U4F28 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, X, X); }
        public readonly Vector4U4F28 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, X, Y); }
        public readonly Vector4U4F28 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Y, X); }
        public readonly Vector4U4F28 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U4F28(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U4F28 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U4F28>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U4F28 other)
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

        public readonly Vector2U4F28 Half() => new Vector2U4F28(
            X.Half(),
            Y.Half());

        public readonly Vector2U4F28 Twice() => new Vector2U4F28(
            X.Twice(),
            Y.Twice());

        public readonly Vector2U4F28 Clamp(U4F28 min, U4F28 max) => new Vector2U4F28(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2U4F28 Clamp(
            Vector2U4F28 min, Vector2U4F28 max
        ) => new Vector2U4F28(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U4F28 SaturatingAdd(Vector2U4F28 other) => new Vector2U4F28(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U4F28 SaturatingMul(U4F28 other) => new Vector2U4F28(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly ulong DotInternal(Vector2U4F28 other) {
            var x = ((ulong)X.Bits) * other.X.Bits;
            var y = ((ulong)Y.Bits) * other.Y.Bits;

            // オーバーフローを避けるため､ 事前に除算する｡
            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算に合わせて常に 4 で除算する｡
            var bits =
                (x / 4) +
                (y / 4);

            const ulong k = 1UL << 26;
            return bits / k;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U4F28 Dot(Vector2U4F28 other) => U4F28.FromBits((uint)DotInternal(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U4F28 SaturatingDot(Vector2U4F28 other) {
            var bits = DotInternal(other);
            if (bits > uint.MaxValue) {
                return U4F28.MaxValue;
            } else {
                return U4F28.FromBits((uint)bits);
            }
        }

    }

    partial struct U4F28 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U4F28 SaturatingMul(Vector2U4F28 other) => other.SaturatingMul(this);
    }
}
