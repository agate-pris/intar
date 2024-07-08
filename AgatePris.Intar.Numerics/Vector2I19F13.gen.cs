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
        public static Vector2I19F13 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I19F13(I19F13.One, I19F13.Zero);
        }
        public static Vector2I19F13 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I19F13(I19F13.Zero, I19F13.One);
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

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I19F13 lhs, Vector2I19F13 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I19F13 lhs, Vector2I19F13 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I19F13 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(X, X); }
        public readonly Vector2I19F13 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(X, Y); }
        public readonly Vector2I19F13 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Y, X); }
        public readonly Vector2I19F13 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Y, Y); }
        public readonly Vector3I19F13 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, X, X); }
        public readonly Vector3I19F13 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, X, Y); }
        public readonly Vector3I19F13 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Y, X); }
        public readonly Vector3I19F13 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Y, Y); }
        public readonly Vector3I19F13 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, X, X); }
        public readonly Vector3I19F13 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, X, Y); }
        public readonly Vector3I19F13 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Y, X); }
        public readonly Vector3I19F13 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Y, Y); }
        public readonly Vector4I19F13 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, X, X); }
        public readonly Vector4I19F13 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, X, Y); }
        public readonly Vector4I19F13 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Y, X); }
        public readonly Vector4I19F13 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Y, Y); }
        public readonly Vector4I19F13 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, X, X); }
        public readonly Vector4I19F13 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, X, Y); }
        public readonly Vector4I19F13 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Y, X); }
        public readonly Vector4I19F13 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Y, Y); }
        public readonly Vector4I19F13 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, X, X); }
        public readonly Vector4I19F13 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, X, Y); }
        public readonly Vector4I19F13 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Y, X); }
        public readonly Vector4I19F13 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Y, Y); }
        public readonly Vector4I19F13 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, X, X); }
        public readonly Vector4I19F13 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, X, Y); }
        public readonly Vector4I19F13 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Y, X); }
        public readonly Vector4I19F13 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I19F13 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

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
            return $"<{x}, {y}>";
        }

        // Methods
        // ---------------------------------------

        public readonly Vector2I19F13 Half() => new Vector2I19F13(
            X.Half(),
            Y.Half());

        public readonly Vector2I19F13 Twice() => new Vector2I19F13(
            X.Twice(),
            Y.Twice());

        public readonly Vector2I19F13 Clamp(I19F13 min, I19F13 max) => new Vector2I19F13(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2I19F13 Clamp(
            Vector2I19F13 min, Vector2I19F13 max
        ) => new Vector2I19F13(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I19F13 SaturatingAdd(Vector2I19F13 other) => new Vector2I19F13(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I19F13 SaturatingMul(I19F13 other) => new Vector2I19F13(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long DotInternal(Vector2I19F13 other) {
            var x = ((long)X.Bits) * other.X.Bits;
            var y = ((long)Y.Bits) * other.Y.Bits;

            // オーバーフローを避けるため､ 事前に除算する｡
            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算に合わせて常に 4 で除算する｡
            var bits =
                (x / 4) +
                (y / 4);

            const long k = 1L << 11;
            return bits / k;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I19F13 Dot(Vector2I19F13 other) => I19F13.FromBits((int)DotInternal(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I19F13 SaturatingDot(Vector2I19F13 other) {
            var bits = DotInternal(other);
            if (bits > int.MaxValue) {
                return I19F13.MaxValue;
            } else if (bits < int.MinValue) {
                return I19F13.MinValue;
            } else {
                return I19F13.FromBits((int)bits);
            }
        }

    }

    partial struct I19F13 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I19F13 SaturatingMul(Vector2I19F13 other) => other.SaturatingMul(this);
    }
}
