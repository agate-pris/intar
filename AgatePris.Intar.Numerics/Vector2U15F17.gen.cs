using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U15F17 : IEquatable<Vector2U15F17>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U15F17 X;
        public U15F17 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17(U15F17 x, U15F17 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17(U15F17 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17(Vector2U15F17 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U15F17 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U15F17(U15F17.Zero);
        }
        public static Vector2U15F17 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U15F17(U15F17.One);
        }
        public static Vector2U15F17 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U15F17(U15F17.One, U15F17.Zero);
        }
        public static Vector2U15F17 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U15F17(U15F17.Zero, U15F17.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 operator +(Vector2U15F17 a, Vector2U15F17 b) => new Vector2U15F17(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 operator -(Vector2U15F17 a, Vector2U15F17 b) => new Vector2U15F17(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 operator *(Vector2U15F17 a, Vector2U15F17 b) => new Vector2U15F17(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 operator *(Vector2U15F17 a, U15F17 b) => new Vector2U15F17(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 operator *(U15F17 a, Vector2U15F17 b) => new Vector2U15F17(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 operator /(Vector2U15F17 a, Vector2U15F17 b) => new Vector2U15F17(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 operator /(Vector2U15F17 a, U15F17 b) => new Vector2U15F17(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 operator /(U15F17 a, Vector2U15F17 b) => new Vector2U15F17(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U15F17 lhs, Vector2U15F17 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U15F17 lhs, Vector2U15F17 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U15F17 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(X, X); }
        public readonly Vector2U15F17 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(X, Y); }
        public readonly Vector2U15F17 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Y, X); }
        public readonly Vector2U15F17 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Y, Y); }
        public readonly Vector3U15F17 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, X, X); }
        public readonly Vector3U15F17 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, X, Y); }
        public readonly Vector3U15F17 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Y, X); }
        public readonly Vector3U15F17 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Y, Y); }
        public readonly Vector3U15F17 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, X, X); }
        public readonly Vector3U15F17 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, X, Y); }
        public readonly Vector3U15F17 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Y, X); }
        public readonly Vector3U15F17 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Y, Y); }
        public readonly Vector4U15F17 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, X, X); }
        public readonly Vector4U15F17 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, X, Y); }
        public readonly Vector4U15F17 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Y, X); }
        public readonly Vector4U15F17 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Y, Y); }
        public readonly Vector4U15F17 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, X, X); }
        public readonly Vector4U15F17 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, X, Y); }
        public readonly Vector4U15F17 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Y, X); }
        public readonly Vector4U15F17 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Y, Y); }
        public readonly Vector4U15F17 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, X, X); }
        public readonly Vector4U15F17 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, X, Y); }
        public readonly Vector4U15F17 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Y, X); }
        public readonly Vector4U15F17 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Y, Y); }
        public readonly Vector4U15F17 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, X, X); }
        public readonly Vector4U15F17 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, X, Y); }
        public readonly Vector4U15F17 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Y, X); }
        public readonly Vector4U15F17 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U15F17 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U15F17>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U15F17 other)
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

        public readonly Vector2U15F17 Half() => new Vector2U15F17(
            X.Half(),
            Y.Half());

        public readonly Vector2U15F17 Twice() => new Vector2U15F17(
            X.Twice(),
            Y.Twice());

        public readonly Vector2U15F17 Clamp(U15F17 min, U15F17 max) => new Vector2U15F17(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2U15F17 Clamp(
            Vector2U15F17 min, Vector2U15F17 max
        ) => new Vector2U15F17(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U15F17 SaturatingAdd(Vector2U15F17 other) => new Vector2U15F17(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U15F17 SaturatingMul(U15F17 other) => new Vector2U15F17(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U32F32 WideningDot(Vector2U15F17 other) {
            var x = X.WideningMul(other.X);
            var y = Y.WideningMul(other.Y);

            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算結果に合わせる｡
            var bits =
                (x.Bits / 4) +
                (y.Bits / 4);
            return U32F32.FromBits(bits);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U15F17 Dot(Vector2U15F17 other) => (U15F17)WideningDot(other);

    }

    partial struct U15F17 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U15F17 SaturatingMul(Vector2U15F17 other) => other.SaturatingMul(this);
    }
}
