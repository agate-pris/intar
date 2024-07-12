using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I16F16 : IEquatable<Vector2I16F16>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I16F16 X;
        public I16F16 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16(I16F16 x, I16F16 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16(I16F16 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16(Vector2I16F16 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I16F16 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I16F16(I16F16.Zero);
        }
        public static Vector2I16F16 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I16F16(I16F16.One);
        }
        public static Vector2I16F16 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I16F16(I16F16.One, I16F16.Zero);
        }
        public static Vector2I16F16 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I16F16(I16F16.Zero, I16F16.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator +(Vector2I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator -(Vector2I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator *(Vector2I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator *(Vector2I16F16 a, I16F16 b) => new Vector2I16F16(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator *(I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator /(Vector2I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator /(Vector2I16F16 a, I16F16 b) => new Vector2I16F16(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I16F16 operator /(I16F16 a, Vector2I16F16 b) => new Vector2I16F16(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I16F16 lhs, Vector2I16F16 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I16F16 lhs, Vector2I16F16 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I16F16 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(X, X); }
        public Vector2I16F16 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(X, Y); }
        public Vector2I16F16 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(Y, X); }
        public Vector2I16F16 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I16F16(Y, Y); }
        public Vector3I16F16 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, X, X); }
        public Vector3I16F16 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, X, Y); }
        public Vector3I16F16 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, Y, X); }
        public Vector3I16F16 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(X, Y, Y); }
        public Vector3I16F16 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, X, X); }
        public Vector3I16F16 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, X, Y); }
        public Vector3I16F16 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, Y, X); }
        public Vector3I16F16 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I16F16(Y, Y, Y); }
        public Vector4I16F16 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, X, X); }
        public Vector4I16F16 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, X, Y); }
        public Vector4I16F16 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, Y, X); }
        public Vector4I16F16 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, X, Y, Y); }
        public Vector4I16F16 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, X, X); }
        public Vector4I16F16 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, X, Y); }
        public Vector4I16F16 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, Y, X); }
        public Vector4I16F16 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(X, Y, Y, Y); }
        public Vector4I16F16 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, X, X); }
        public Vector4I16F16 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, X, Y); }
        public Vector4I16F16 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, Y, X); }
        public Vector4I16F16 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, X, Y, Y); }
        public Vector4I16F16 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, X, X); }
        public Vector4I16F16 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, X, Y); }
        public Vector4I16F16 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, Y, X); }
        public Vector4I16F16 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I16F16(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector2I16F16 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I16F16>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2I16F16 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"<{x}, {y}>";
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16 Min(Vector2I16F16 other) => new Vector2I16F16(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16 Max(Vector2I16F16 other) => new Vector2I16F16(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16 Abs() => new Vector2I16F16(
            X.Abs(),
            Y.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16 Half() => new Vector2I16F16(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16 Twice() => new Vector2I16F16(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16 Clamp(I16F16 min, I16F16 max) => new Vector2I16F16(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16 Clamp(
            Vector2I16F16 min, Vector2I16F16 max
        ) => new Vector2I16F16(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16 WrappingAdd(Vector2I16F16 other) => new Vector2I16F16(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16 WrappingSub(Vector2I16F16 other) => new Vector2I16F16(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16 WrappingMul(Vector2I16F16 other) => new Vector2I16F16(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16 WrappingAddUnsigned(Vector2U16F16 other) => new Vector2I16F16(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16 WrappingSubUnsigned(Vector2U16F16 other) => new Vector2I16F16(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U16F16 UnsignedAbs() => new Vector2U16F16(
            X.UnsignedAbs(),
            Y.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16 SaturatingAdd(Vector2I16F16 other) => new Vector2I16F16(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16 SaturatingMul(I16F16 other) => new Vector2I16F16(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector2I16F16 other) {
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
        public I16F16 Dot(Vector2I16F16 other) {
            const long k = 1L << 14;
            return I16F16.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I16F16 SaturatingDot(Vector2I16F16 other) {
            const long k = 1L << 14;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I16F16.MaxValue;
            } else if (bits < int.MinValue) {
                return I16F16.MinValue;
            } else {
                return I16F16.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        /// <summary>
        /// ベクトルの長さの 2 乗を返します｡
        /// </summary>
        /// <remarks>
        /// オーバーフローを防ぐため､ 計算の過程で 4 で除算しています｡
        /// そのため､ 精度が犠牲になっています｡
        /// また､ 戻り値の型もそれに準じて小数部が 2 ビット小さい型になっています｡
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 LengthSquared() {
            return I34F30.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        int LengthInternal() {
            var squared = LengthSquaredInternal();
            return (int)Mathi.Sqrt((ulong)squared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I16F16 LengthHalf() => I16F16.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15 Length() => I17F15.FromBits(LengthInternal());

    }

    partial struct I16F16 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I16F16 SaturatingMul(Vector2I16F16 other) => other.SaturatingMul(this);
    }
}
