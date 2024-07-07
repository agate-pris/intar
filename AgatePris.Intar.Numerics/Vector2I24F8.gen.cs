using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I24F8 : IEquatable<Vector2I24F8>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I24F8 X;
        public I24F8 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I24F8(I24F8 x, I24F8 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I24F8(I24F8 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I24F8(Vector2I24F8 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I24F8 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I24F8(I24F8.Zero);
        }
        public static Vector2I24F8 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I24F8(I24F8.One);
        }
        public static Vector2I24F8 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I24F8(I24F8.One, I24F8.Zero);
        }
        public static Vector2I24F8 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I24F8(I24F8.Zero, I24F8.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 operator +(Vector2I24F8 a, Vector2I24F8 b) => new Vector2I24F8(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 operator -(Vector2I24F8 a, Vector2I24F8 b) => new Vector2I24F8(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 operator *(Vector2I24F8 a, Vector2I24F8 b) => new Vector2I24F8(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 operator *(Vector2I24F8 a, I24F8 b) => new Vector2I24F8(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 operator *(I24F8 a, Vector2I24F8 b) => new Vector2I24F8(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 operator /(Vector2I24F8 a, Vector2I24F8 b) => new Vector2I24F8(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 operator /(Vector2I24F8 a, I24F8 b) => new Vector2I24F8(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I24F8 operator /(I24F8 a, Vector2I24F8 b) => new Vector2I24F8(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I24F8 lhs, Vector2I24F8 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I24F8 lhs, Vector2I24F8 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I24F8 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(X, X); }
        public readonly Vector2I24F8 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(X, Y); }
        public readonly Vector2I24F8 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(Y, X); }
        public readonly Vector2I24F8 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I24F8(Y, Y); }
        public readonly Vector3I24F8 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, X, X); }
        public readonly Vector3I24F8 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, X, Y); }
        public readonly Vector3I24F8 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, Y, X); }
        public readonly Vector3I24F8 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(X, Y, Y); }
        public readonly Vector3I24F8 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, X, X); }
        public readonly Vector3I24F8 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, X, Y); }
        public readonly Vector3I24F8 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, Y, X); }
        public readonly Vector3I24F8 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I24F8(Y, Y, Y); }
        public readonly Vector4I24F8 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, X, X); }
        public readonly Vector4I24F8 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, X, Y); }
        public readonly Vector4I24F8 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, Y, X); }
        public readonly Vector4I24F8 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, X, Y, Y); }
        public readonly Vector4I24F8 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, X, X); }
        public readonly Vector4I24F8 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, X, Y); }
        public readonly Vector4I24F8 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, Y, X); }
        public readonly Vector4I24F8 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(X, Y, Y, Y); }
        public readonly Vector4I24F8 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, X, X); }
        public readonly Vector4I24F8 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, X, Y); }
        public readonly Vector4I24F8 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, Y, X); }
        public readonly Vector4I24F8 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, X, Y, Y); }
        public readonly Vector4I24F8 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, X, X); }
        public readonly Vector4I24F8 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, X, Y); }
        public readonly Vector4I24F8 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, Y, X); }
        public readonly Vector4I24F8 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I24F8(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I24F8 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I24F8>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I24F8 other)
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

        public readonly Vector2I24F8 Half() => new Vector2I24F8(
            X.Half(),
            Y.Half());

        public readonly Vector2I24F8 Twice() => new Vector2I24F8(
            X.Twice(),
            Y.Twice());

        public readonly Vector2I24F8 Clamp(I24F8 min, I24F8 max) => new Vector2I24F8(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2I24F8 Clamp(
            Vector2I24F8 min, Vector2I24F8 max
        ) => new Vector2I24F8(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I24F8 SaturatingAdd(Vector2I24F8 other) => new Vector2I24F8(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I24F8 SaturatingMul(I24F8 other) => new Vector2I24F8(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I50F14 Dot(Vector2I24F8 other) {
            var x = X.WideningMul(other.X);
            var y = Y.WideningMul(other.Y);

            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算結果に合わせる｡
            var bits =
                (x.Bits / 4) +
                (y.Bits / 4);
            return I50F14.FromBits(bits);
        }

    }

    partial struct I24F8 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I24F8 SaturatingMul(Vector2I24F8 other) => other.SaturatingMul(this);
    }
}
