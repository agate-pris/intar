using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U13F19 : IEquatable<Vector2U13F19>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U13F19 X;
        public U13F19 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U13F19(U13F19 x, U13F19 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U13F19(U13F19 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U13F19(Vector2U13F19 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U13F19 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U13F19(U13F19.Zero);
        }
        public static Vector2U13F19 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U13F19(U13F19.One);
        }
        public static Vector2U13F19 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U13F19(U13F19.One, U13F19.Zero);
        }
        public static Vector2U13F19 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U13F19(U13F19.Zero, U13F19.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 operator +(Vector2U13F19 a, Vector2U13F19 b) => new Vector2U13F19(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 operator -(Vector2U13F19 a, Vector2U13F19 b) => new Vector2U13F19(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 operator *(Vector2U13F19 a, Vector2U13F19 b) => new Vector2U13F19(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 operator *(Vector2U13F19 a, U13F19 b) => new Vector2U13F19(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 operator *(U13F19 a, Vector2U13F19 b) => new Vector2U13F19(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 operator /(Vector2U13F19 a, Vector2U13F19 b) => new Vector2U13F19(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 operator /(Vector2U13F19 a, U13F19 b) => new Vector2U13F19(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U13F19 operator /(U13F19 a, Vector2U13F19 b) => new Vector2U13F19(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U13F19 lhs, Vector2U13F19 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U13F19 lhs, Vector2U13F19 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U13F19 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(X, X); }
        public readonly Vector2U13F19 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(X, Y); }
        public readonly Vector2U13F19 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Y, X); }
        public readonly Vector2U13F19 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Y, Y); }
        public readonly Vector3U13F19 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, X, X); }
        public readonly Vector3U13F19 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, X, Y); }
        public readonly Vector3U13F19 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Y, X); }
        public readonly Vector3U13F19 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Y, Y); }
        public readonly Vector3U13F19 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, X, X); }
        public readonly Vector3U13F19 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, X, Y); }
        public readonly Vector3U13F19 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Y, X); }
        public readonly Vector3U13F19 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Y, Y); }
        public readonly Vector4U13F19 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, X, X); }
        public readonly Vector4U13F19 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, X, Y); }
        public readonly Vector4U13F19 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Y, X); }
        public readonly Vector4U13F19 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Y, Y); }
        public readonly Vector4U13F19 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, X, X); }
        public readonly Vector4U13F19 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, X, Y); }
        public readonly Vector4U13F19 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Y, X); }
        public readonly Vector4U13F19 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Y, Y); }
        public readonly Vector4U13F19 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, X, X); }
        public readonly Vector4U13F19 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, X, Y); }
        public readonly Vector4U13F19 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Y, X); }
        public readonly Vector4U13F19 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Y, Y); }
        public readonly Vector4U13F19 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, X, X); }
        public readonly Vector4U13F19 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, X, Y); }
        public readonly Vector4U13F19 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Y, X); }
        public readonly Vector4U13F19 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U13F19 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U13F19>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U13F19 other)
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

        public readonly Vector2U13F19 Half() => new Vector2U13F19(
            X.Half(),
            Y.Half());

        public readonly Vector2U13F19 Twice() => new Vector2U13F19(
            X.Twice(),
            Y.Twice());

        public readonly Vector2U13F19 Clamp(U13F19 min, U13F19 max) => new Vector2U13F19(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2U13F19 Clamp(
            Vector2U13F19 min, Vector2U13F19 max
        ) => new Vector2U13F19(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U13F19 SaturatingAdd(Vector2U13F19 other) => new Vector2U13F19(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U13F19 SaturatingMul(U13F19 other) => new Vector2U13F19(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly ulong DotInternal(Vector2U13F19 other) {
            var x = ((ulong)X.Bits) * other.X.Bits;
            var y = ((ulong)Y.Bits) * other.Y.Bits;

            // オーバーフローを避けるため､ 事前に除算する｡
            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算に合わせて常に 4 で除算する｡
            var bits =
                (x / 4) +
                (y / 4);

            const ulong k = 1UL << 17;
            return bits / k;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U13F19 Dot(Vector2U13F19 other) => U13F19.FromBits((uint)DotInternal(other));

    }

    partial struct U13F19 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U13F19 SaturatingMul(Vector2U13F19 other) => other.SaturatingMul(this);
    }
}
