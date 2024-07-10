using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I2F30 : IEquatable<Vector2I2F30>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I2F30 X;
        public I2F30 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30(I2F30 x, I2F30 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30(I2F30 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30(Vector2I2F30 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I2F30 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I2F30(I2F30.Zero);
        }
        public static Vector2I2F30 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I2F30(I2F30.One);
        }
        public static Vector2I2F30 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I2F30(I2F30.One, I2F30.Zero);
        }
        public static Vector2I2F30 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I2F30(I2F30.Zero, I2F30.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator +(Vector2I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator -(Vector2I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator *(Vector2I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator *(Vector2I2F30 a, I2F30 b) => new Vector2I2F30(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator *(I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator /(Vector2I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator /(Vector2I2F30 a, I2F30 b) => new Vector2I2F30(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator /(I2F30 a, Vector2I2F30 b) => new Vector2I2F30(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I2F30 lhs, Vector2I2F30 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I2F30 lhs, Vector2I2F30 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I2F30 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(X, X); }
        public readonly Vector2I2F30 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(X, Y); }
        public readonly Vector2I2F30 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Y, X); }
        public readonly Vector2I2F30 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I2F30(Y, Y); }
        public readonly Vector3I2F30 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, X, X); }
        public readonly Vector3I2F30 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, X, Y); }
        public readonly Vector3I2F30 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Y, X); }
        public readonly Vector3I2F30 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(X, Y, Y); }
        public readonly Vector3I2F30 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, X, X); }
        public readonly Vector3I2F30 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, X, Y); }
        public readonly Vector3I2F30 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Y, X); }
        public readonly Vector3I2F30 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I2F30(Y, Y, Y); }
        public readonly Vector4I2F30 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, X, X); }
        public readonly Vector4I2F30 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, X, Y); }
        public readonly Vector4I2F30 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Y, X); }
        public readonly Vector4I2F30 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, X, Y, Y); }
        public readonly Vector4I2F30 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, X, X); }
        public readonly Vector4I2F30 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, X, Y); }
        public readonly Vector4I2F30 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Y, X); }
        public readonly Vector4I2F30 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(X, Y, Y, Y); }
        public readonly Vector4I2F30 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, X, X); }
        public readonly Vector4I2F30 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, X, Y); }
        public readonly Vector4I2F30 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Y, X); }
        public readonly Vector4I2F30 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, X, Y, Y); }
        public readonly Vector4I2F30 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, X, X); }
        public readonly Vector4I2F30 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, X, Y); }
        public readonly Vector4I2F30 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Y, X); }
        public readonly Vector4I2F30 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I2F30(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I2F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I2F30 other)
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 Min(Vector2I2F30 other) => new Vector2I2F30(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 Max(Vector2I2F30 other) => new Vector2I2F30(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 Abs() => new Vector2I2F30(
            X.Abs(),
            Y.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 Half() => new Vector2I2F30(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 Twice() => new Vector2I2F30(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 Clamp(I2F30 min, I2F30 max) => new Vector2I2F30(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 Clamp(
            Vector2I2F30 min, Vector2I2F30 max
        ) => new Vector2I2F30(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 WrappingAdd(Vector2I2F30 other) => new Vector2I2F30(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 WrappingSub(Vector2I2F30 other) => new Vector2I2F30(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 WrappingMul(Vector2I2F30 other) => new Vector2I2F30(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 WrappingAddUnsigned(Vector2U2F30 other) => new Vector2I2F30(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 WrappingSubUnsigned(Vector2U2F30 other) => new Vector2I2F30(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 SaturatingAdd(Vector2I2F30 other) => new Vector2I2F30(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 SaturatingMul(I2F30 other) => new Vector2I2F30(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long DotInternal(Vector2I2F30 other) {
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
        public readonly I2F30 Dot(Vector2I2F30 other) {
            const long k = 1L << 28;
            return I2F30.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I2F30 SaturatingDot(Vector2I2F30 other) {
            const long k = 1L << 28;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I2F30.MaxValue;
            } else if (bits < int.MinValue) {
                return I2F30.MinValue;
            } else {
                return I2F30.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long LengthSquaredInternal() => DotInternal(this);

        /// <summary>
        /// ベクトルの長さの 2 乗を返します｡
        /// </summary>
        /// <remarks>
        /// オーバーフローを防ぐため､ 計算の過程で 4 で除算しています｡
        /// そのため､ 精度が犠牲になっています｡
        /// また､ 戻り値の型もそれに準じて小数部が 2 ビット小さい型になっています｡
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I6F58 LengthSquared() {
            return I6F58.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly int LengthInternal() {
            var squared = LengthSquaredInternal();
            return (int)Mathi.Sqrt((ulong)squared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I2F30 LengthHalf() => I2F30.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I3F29 Length() => I3F29.FromBits(LengthInternal());

    }

    partial struct I2F30 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I2F30 SaturatingMul(Vector2I2F30 other) => other.SaturatingMul(this);
    }
}
