using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I29F3 : IEquatable<Vector2I29F3>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I29F3 X;
        public I29F3 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I29F3(I29F3 x, I29F3 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I29F3(I29F3 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I29F3(Vector2I29F3 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I29F3 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I29F3(I29F3.Zero);
        }
        public static Vector2I29F3 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I29F3(I29F3.One);
        }
        public static Vector2I29F3 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I29F3(I29F3.One, I29F3.Zero);
        }
        public static Vector2I29F3 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I29F3(I29F3.Zero, I29F3.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 operator +(Vector2I29F3 a, Vector2I29F3 b) => new Vector2I29F3(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 operator -(Vector2I29F3 a, Vector2I29F3 b) => new Vector2I29F3(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 operator *(Vector2I29F3 a, Vector2I29F3 b) => new Vector2I29F3(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 operator *(Vector2I29F3 a, I29F3 b) => new Vector2I29F3(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 operator *(I29F3 a, Vector2I29F3 b) => new Vector2I29F3(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 operator /(Vector2I29F3 a, Vector2I29F3 b) => new Vector2I29F3(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 operator /(Vector2I29F3 a, I29F3 b) => new Vector2I29F3(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I29F3 operator /(I29F3 a, Vector2I29F3 b) => new Vector2I29F3(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I29F3 lhs, Vector2I29F3 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I29F3 lhs, Vector2I29F3 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I29F3 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(X, X); }
        public readonly Vector2I29F3 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(X, Y); }
        public readonly Vector2I29F3 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Y, X); }
        public readonly Vector2I29F3 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I29F3(Y, Y); }
        public readonly Vector3I29F3 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, X, X); }
        public readonly Vector3I29F3 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, X, Y); }
        public readonly Vector3I29F3 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Y, X); }
        public readonly Vector3I29F3 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(X, Y, Y); }
        public readonly Vector3I29F3 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, X, X); }
        public readonly Vector3I29F3 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, X, Y); }
        public readonly Vector3I29F3 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Y, X); }
        public readonly Vector3I29F3 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I29F3(Y, Y, Y); }
        public readonly Vector4I29F3 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, X, X); }
        public readonly Vector4I29F3 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, X, Y); }
        public readonly Vector4I29F3 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Y, X); }
        public readonly Vector4I29F3 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, X, Y, Y); }
        public readonly Vector4I29F3 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, X, X); }
        public readonly Vector4I29F3 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, X, Y); }
        public readonly Vector4I29F3 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Y, X); }
        public readonly Vector4I29F3 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(X, Y, Y, Y); }
        public readonly Vector4I29F3 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, X, X); }
        public readonly Vector4I29F3 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, X, Y); }
        public readonly Vector4I29F3 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Y, X); }
        public readonly Vector4I29F3 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, X, Y, Y); }
        public readonly Vector4I29F3 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, X, X); }
        public readonly Vector4I29F3 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, X, Y); }
        public readonly Vector4I29F3 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Y, X); }
        public readonly Vector4I29F3 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I29F3(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I29F3 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I29F3>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I29F3 other)
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
        public readonly Vector2I29F3 Min(Vector2I29F3 other) => new Vector2I29F3(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I29F3 Max(Vector2I29F3 other) => new Vector2I29F3(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I29F3 Abs() => new Vector2I29F3(
            X.Abs(),
            Y.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I29F3 Half() => new Vector2I29F3(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I29F3 Twice() => new Vector2I29F3(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I29F3 Clamp(I29F3 min, I29F3 max) => new Vector2I29F3(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I29F3 Clamp(
            Vector2I29F3 min, Vector2I29F3 max
        ) => new Vector2I29F3(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I29F3 WrappingAdd(Vector2I29F3 other) => new Vector2I29F3(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I29F3 WrappingSub(Vector2I29F3 other) => new Vector2I29F3(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I29F3 WrappingMul(Vector2I29F3 other) => new Vector2I29F3(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I29F3 WrappingAddUnsigned(Vector2U29F3 other) => new Vector2I29F3(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I29F3 WrappingSubUnsigned(Vector2U29F3 other) => new Vector2I29F3(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U29F3 UnsignedAbs() => new Vector2U29F3(
            X.UnsignedAbs(),
            Y.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I29F3 SaturatingAdd(Vector2I29F3 other) => new Vector2I29F3(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I29F3 SaturatingMul(I29F3 other) => new Vector2I29F3(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long DotInternal(Vector2I29F3 other) {
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
        public readonly I29F3 Dot(Vector2I29F3 other) {
            const long k = 1L << 1;
            return I29F3.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I29F3 SaturatingDot(Vector2I29F3 other) {
            const long k = 1L << 1;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I29F3.MaxValue;
            } else if (bits < int.MinValue) {
                return I29F3.MinValue;
            } else {
                return I29F3.FromBits((int)bits);
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
        public readonly I60F4 LengthSquared() {
            return I60F4.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly int LengthInternal() {
            var squared = LengthSquaredInternal();
            return (int)Mathi.Sqrt((ulong)squared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I29F3 LengthHalf() => I29F3.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I30F2 Length() => I30F2.FromBits(LengthInternal());

    }

    partial struct I29F3 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I29F3 SaturatingMul(Vector2I29F3 other) => other.SaturatingMul(this);
    }
}
