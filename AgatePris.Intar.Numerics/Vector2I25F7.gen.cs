using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I25F7 : IEquatable<Vector2I25F7>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I25F7 X;
        public I25F7 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I25F7(I25F7 x, I25F7 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I25F7(I25F7 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I25F7(Vector2I25F7 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I25F7 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I25F7(I25F7.Zero);
        }
        public static Vector2I25F7 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I25F7(I25F7.One);
        }
        public static Vector2I25F7 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I25F7(I25F7.One, I25F7.Zero);
        }
        public static Vector2I25F7 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I25F7(I25F7.Zero, I25F7.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 operator +(Vector2I25F7 a, Vector2I25F7 b) => new Vector2I25F7(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 operator -(Vector2I25F7 a, Vector2I25F7 b) => new Vector2I25F7(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 operator *(Vector2I25F7 a, Vector2I25F7 b) => new Vector2I25F7(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 operator *(Vector2I25F7 a, I25F7 b) => new Vector2I25F7(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 operator *(I25F7 a, Vector2I25F7 b) => new Vector2I25F7(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 operator /(Vector2I25F7 a, Vector2I25F7 b) => new Vector2I25F7(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 operator /(Vector2I25F7 a, I25F7 b) => new Vector2I25F7(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I25F7 operator /(I25F7 a, Vector2I25F7 b) => new Vector2I25F7(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I25F7 lhs, Vector2I25F7 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I25F7 lhs, Vector2I25F7 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I25F7 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(X, X); }
        public readonly Vector2I25F7 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(X, Y); }
        public readonly Vector2I25F7 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(Y, X); }
        public readonly Vector2I25F7 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I25F7(Y, Y); }
        public readonly Vector3I25F7 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, X, X); }
        public readonly Vector3I25F7 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, X, Y); }
        public readonly Vector3I25F7 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, Y, X); }
        public readonly Vector3I25F7 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(X, Y, Y); }
        public readonly Vector3I25F7 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, X, X); }
        public readonly Vector3I25F7 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, X, Y); }
        public readonly Vector3I25F7 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, Y, X); }
        public readonly Vector3I25F7 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I25F7(Y, Y, Y); }
        public readonly Vector4I25F7 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, X, X); }
        public readonly Vector4I25F7 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, X, Y); }
        public readonly Vector4I25F7 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, Y, X); }
        public readonly Vector4I25F7 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, X, Y, Y); }
        public readonly Vector4I25F7 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, X, X); }
        public readonly Vector4I25F7 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, X, Y); }
        public readonly Vector4I25F7 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, Y, X); }
        public readonly Vector4I25F7 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(X, Y, Y, Y); }
        public readonly Vector4I25F7 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, X, X); }
        public readonly Vector4I25F7 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, X, Y); }
        public readonly Vector4I25F7 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, Y, X); }
        public readonly Vector4I25F7 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, X, Y, Y); }
        public readonly Vector4I25F7 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, X, X); }
        public readonly Vector4I25F7 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, X, Y); }
        public readonly Vector4I25F7 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, Y, X); }
        public readonly Vector4I25F7 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I25F7(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I25F7 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I25F7>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I25F7 other)
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

        public readonly Vector2I25F7 Half() => new Vector2I25F7(
            X.Half(),
            Y.Half());

        public readonly Vector2I25F7 Twice() => new Vector2I25F7(
            X.Twice(),
            Y.Twice());

        public readonly Vector2I25F7 Clamp(I25F7 min, I25F7 max) => new Vector2I25F7(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2I25F7 Clamp(
            Vector2I25F7 min, Vector2I25F7 max
        ) => new Vector2I25F7(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I25F7 SaturatingAdd(Vector2I25F7 other) => new Vector2I25F7(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I25F7 SaturatingMul(I25F7 other) => new Vector2I25F7(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I52F12 WideningDot(Vector2I25F7 other) {
            var x = X.WideningMul(other.X);
            var y = Y.WideningMul(other.Y);

            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算結果に合わせる｡
            var bits =
                (x.Bits / 4) +
                (y.Bits / 4);
            return I52F12.FromBits(bits);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I25F7 Dot(Vector2I25F7 other) => (I25F7)WideningDot(other);

    }

    partial struct I25F7 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I25F7 SaturatingMul(Vector2I25F7 other) => other.SaturatingMul(this);
    }
}
