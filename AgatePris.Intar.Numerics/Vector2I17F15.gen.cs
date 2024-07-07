using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I17F15 : IEquatable<Vector2I17F15>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I17F15 X;
        public I17F15 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15(I17F15 x, I17F15 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15(I17F15 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15(Vector2I17F15 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I17F15 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I17F15(I17F15.Zero);
        }
        public static Vector2I17F15 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I17F15(I17F15.One);
        }
        public static Vector2I17F15 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I17F15(I17F15.One, I17F15.Zero);
        }
        public static Vector2I17F15 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I17F15(I17F15.Zero, I17F15.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator +(Vector2I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator -(Vector2I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator *(Vector2I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator *(Vector2I17F15 a, I17F15 b) => new Vector2I17F15(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator *(I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator /(Vector2I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator /(Vector2I17F15 a, I17F15 b) => new Vector2I17F15(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator /(I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I17F15 lhs, Vector2I17F15 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I17F15 lhs, Vector2I17F15 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I17F15 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(X, X); }
        public readonly Vector2I17F15 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(X, Y); }
        public readonly Vector2I17F15 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Y, X); }
        public readonly Vector2I17F15 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Y, Y); }
        public readonly Vector3I17F15 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, X, X); }
        public readonly Vector3I17F15 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, X, Y); }
        public readonly Vector3I17F15 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Y, X); }
        public readonly Vector3I17F15 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Y, Y); }
        public readonly Vector3I17F15 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, X, X); }
        public readonly Vector3I17F15 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, X, Y); }
        public readonly Vector3I17F15 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Y, X); }
        public readonly Vector3I17F15 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Y, Y); }
        public readonly Vector4I17F15 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, X, X); }
        public readonly Vector4I17F15 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, X, Y); }
        public readonly Vector4I17F15 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Y, X); }
        public readonly Vector4I17F15 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Y, Y); }
        public readonly Vector4I17F15 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, X, X); }
        public readonly Vector4I17F15 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, X, Y); }
        public readonly Vector4I17F15 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Y, X); }
        public readonly Vector4I17F15 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Y, Y); }
        public readonly Vector4I17F15 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, X, X); }
        public readonly Vector4I17F15 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, X, Y); }
        public readonly Vector4I17F15 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Y, X); }
        public readonly Vector4I17F15 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Y, Y); }
        public readonly Vector4I17F15 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, X, X); }
        public readonly Vector4I17F15 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, X, Y); }
        public readonly Vector4I17F15 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Y, X); }
        public readonly Vector4I17F15 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I17F15 other)
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

        public readonly Vector2I17F15 Half() => new Vector2I17F15(
            X.Half(),
            Y.Half());

        public readonly Vector2I17F15 Twice() => new Vector2I17F15(
            X.Twice(),
            Y.Twice());

        public readonly Vector2I17F15 Clamp(I17F15 min, I17F15 max) => new Vector2I17F15(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2I17F15 Clamp(
            Vector2I17F15 min, Vector2I17F15 max
        ) => new Vector2I17F15(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I17F15 SaturatingAdd(Vector2I17F15 other) => new Vector2I17F15(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I17F15 SaturatingMul(I17F15 other) => new Vector2I17F15(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I36F28 Dot(Vector2I17F15 other) {
            var x = X.WideningMul(other.X);
            var y = Y.WideningMul(other.Y);

            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算結果に合わせる｡
            var bits =
                (x.Bits / 4) +
                (y.Bits / 4);
            return I36F28.FromBits(bits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 SinP2() => new Vector2I2F30(
            X.SinP2(),
            Y.SinP2());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 SinP3A16384() => new Vector2I2F30(
            X.SinP3A16384(),
            Y.SinP3A16384());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 SinP4A7032() => new Vector2I2F30(
            X.SinP4A7032(),
            Y.SinP4A7032());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 SinP4A7384() => new Vector2I2F30(
            X.SinP4A7384(),
            Y.SinP4A7384());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 SinP5A51472() => new Vector2I2F30(
            X.SinP5A51472(),
            Y.SinP5A51472());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 SinP5A51437() => new Vector2I2F30(
            X.SinP5A51437(),
            Y.SinP5A51437());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 CosP2() => new Vector2I2F30(
            X.CosP2(),
            Y.CosP2());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 CosP3A16384() => new Vector2I2F30(
            X.CosP3A16384(),
            Y.CosP3A16384());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 CosP4A7032() => new Vector2I2F30(
            X.CosP4A7032(),
            Y.CosP4A7032());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 CosP4A7384() => new Vector2I2F30(
            X.CosP4A7384(),
            Y.CosP4A7384());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 CosP5A51472() => new Vector2I2F30(
            X.CosP5A51472(),
            Y.CosP5A51472());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 CosP5A51437() => new Vector2I2F30(
            X.CosP5A51437(),
            Y.CosP5A51437());

    }

    partial struct I17F15 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I17F15 SaturatingMul(Vector2I17F15 other) => other.SaturatingMul(this);
    }
}
