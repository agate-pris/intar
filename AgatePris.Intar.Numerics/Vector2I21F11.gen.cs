using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I21F11 : IEquatable<Vector2I21F11>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I21F11 X;
        public I21F11 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11(I21F11 x, I21F11 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11(I21F11 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11(Vector2I21F11 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I21F11 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I21F11(I21F11.Zero);
        }
        public static Vector2I21F11 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I21F11(I21F11.One);
        }
        public static Vector2I21F11 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I21F11(I21F11.One, I21F11.Zero);
        }
        public static Vector2I21F11 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I21F11(I21F11.Zero, I21F11.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 operator +(Vector2I21F11 a, Vector2I21F11 b) => new Vector2I21F11(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 operator -(Vector2I21F11 a, Vector2I21F11 b) => new Vector2I21F11(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 operator *(Vector2I21F11 a, Vector2I21F11 b) => new Vector2I21F11(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 operator *(Vector2I21F11 a, I21F11 b) => new Vector2I21F11(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 operator *(I21F11 a, Vector2I21F11 b) => new Vector2I21F11(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 operator /(Vector2I21F11 a, Vector2I21F11 b) => new Vector2I21F11(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 operator /(Vector2I21F11 a, I21F11 b) => new Vector2I21F11(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 operator /(I21F11 a, Vector2I21F11 b) => new Vector2I21F11(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I21F11 lhs, Vector2I21F11 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I21F11 lhs, Vector2I21F11 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I21F11 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(X, X); }
        public readonly Vector2I21F11 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(X, Y); }
        public readonly Vector2I21F11 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(Y, X); }
        public readonly Vector2I21F11 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I21F11(Y, Y); }
        public readonly Vector3I21F11 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(X, X, X); }
        public readonly Vector3I21F11 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(X, X, Y); }
        public readonly Vector3I21F11 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(X, Y, X); }
        public readonly Vector3I21F11 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(X, Y, Y); }
        public readonly Vector3I21F11 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(Y, X, X); }
        public readonly Vector3I21F11 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(Y, X, Y); }
        public readonly Vector3I21F11 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(Y, Y, X); }
        public readonly Vector3I21F11 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I21F11(Y, Y, Y); }
        public readonly Vector4I21F11 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(X, X, X, X); }
        public readonly Vector4I21F11 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(X, X, X, Y); }
        public readonly Vector4I21F11 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(X, X, Y, X); }
        public readonly Vector4I21F11 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(X, X, Y, Y); }
        public readonly Vector4I21F11 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(X, Y, X, X); }
        public readonly Vector4I21F11 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(X, Y, X, Y); }
        public readonly Vector4I21F11 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(X, Y, Y, X); }
        public readonly Vector4I21F11 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(X, Y, Y, Y); }
        public readonly Vector4I21F11 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(Y, X, X, X); }
        public readonly Vector4I21F11 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(Y, X, X, Y); }
        public readonly Vector4I21F11 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(Y, X, Y, X); }
        public readonly Vector4I21F11 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(Y, X, Y, Y); }
        public readonly Vector4I21F11 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(Y, Y, X, X); }
        public readonly Vector4I21F11 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(Y, Y, X, Y); }
        public readonly Vector4I21F11 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(Y, Y, Y, X); }
        public readonly Vector4I21F11 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I21F11(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I21F11 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I21F11>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I21F11 other)
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

        public readonly Vector2I21F11 Half() => new Vector2I21F11(
            X.Half(),
            Y.Half());

        public readonly Vector2I21F11 Twice() => new Vector2I21F11(
            X.Twice(),
            Y.Twice());

        public readonly Vector2I21F11 Clamp(I21F11 min, I21F11 max) => new Vector2I21F11(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2I21F11 Clamp(
            Vector2I21F11 min, Vector2I21F11 max
        ) => new Vector2I21F11(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I21F11 SaturatingAdd(Vector2I21F11 other) => new Vector2I21F11(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I21F11 SaturatingMul(I21F11 other) => new Vector2I21F11(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long DotInternal(Vector2I21F11 other) {
            var x = ((long)X.Bits) * other.X.Bits;
            var y = ((long)Y.Bits) * other.Y.Bits;

            // オーバーフローを避けるため､ 事前に除算する｡
            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算に合わせて常に 4 で除算する｡
            return
                (x / 4) +
                (y / 4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I21F11 Dot(Vector2I21F11 other) {
            const long k = 1L << 9;
            return I21F11.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I21F11 SaturatingDot(Vector2I21F11 other) {
            const long k = 1L << 9;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I21F11.MaxValue;
            } else if (bits < int.MinValue) {
                return I21F11.MinValue;
            } else {
                return I21F11.FromBits((int)bits);
            }
        }

    }

    partial struct I21F11 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I21F11 SaturatingMul(Vector2I21F11 other) => other.SaturatingMul(this);
    }
}
