using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I30F2 : IEquatable<Vector2I30F2>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I30F2 X;
        public I30F2 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I30F2(I30F2 x, I30F2 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I30F2(I30F2 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I30F2(Vector2I30F2 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I30F2 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I30F2(I30F2.Zero);
        }
        public static Vector2I30F2 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I30F2(I30F2.One);
        }
        public static Vector2I30F2 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I30F2(I30F2.One, I30F2.Zero);
        }
        public static Vector2I30F2 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I30F2(I30F2.Zero, I30F2.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 operator +(Vector2I30F2 a, Vector2I30F2 b) => new Vector2I30F2(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 operator -(Vector2I30F2 a, Vector2I30F2 b) => new Vector2I30F2(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 operator *(Vector2I30F2 a, Vector2I30F2 b) => new Vector2I30F2(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 operator *(Vector2I30F2 a, I30F2 b) => new Vector2I30F2(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 operator *(I30F2 a, Vector2I30F2 b) => new Vector2I30F2(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 operator /(Vector2I30F2 a, Vector2I30F2 b) => new Vector2I30F2(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 operator /(Vector2I30F2 a, I30F2 b) => new Vector2I30F2(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I30F2 operator /(I30F2 a, Vector2I30F2 b) => new Vector2I30F2(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I30F2 lhs, Vector2I30F2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I30F2 lhs, Vector2I30F2 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I30F2 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(X, X); }
        public readonly Vector2I30F2 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(X, Y); }
        public readonly Vector2I30F2 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(Y, X); }
        public readonly Vector2I30F2 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I30F2(Y, Y); }
        public readonly Vector3I30F2 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, X, X); }
        public readonly Vector3I30F2 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, X, Y); }
        public readonly Vector3I30F2 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, Y, X); }
        public readonly Vector3I30F2 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(X, Y, Y); }
        public readonly Vector3I30F2 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, X, X); }
        public readonly Vector3I30F2 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, X, Y); }
        public readonly Vector3I30F2 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, Y, X); }
        public readonly Vector3I30F2 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I30F2(Y, Y, Y); }
        public readonly Vector4I30F2 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, X, X); }
        public readonly Vector4I30F2 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, X, Y); }
        public readonly Vector4I30F2 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, Y, X); }
        public readonly Vector4I30F2 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, X, Y, Y); }
        public readonly Vector4I30F2 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, X, X); }
        public readonly Vector4I30F2 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, X, Y); }
        public readonly Vector4I30F2 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, Y, X); }
        public readonly Vector4I30F2 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(X, Y, Y, Y); }
        public readonly Vector4I30F2 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, X, X); }
        public readonly Vector4I30F2 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, X, Y); }
        public readonly Vector4I30F2 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, Y, X); }
        public readonly Vector4I30F2 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, X, Y, Y); }
        public readonly Vector4I30F2 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, X, X); }
        public readonly Vector4I30F2 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, X, Y); }
        public readonly Vector4I30F2 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, Y, X); }
        public readonly Vector4I30F2 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I30F2(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I30F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I30F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I30F2 other)
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
        public readonly Vector2I30F2 Min(Vector2I30F2 other) => new Vector2I30F2(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I30F2 Max(Vector2I30F2 other) => new Vector2I30F2(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I30F2 Abs() => new Vector2I30F2(
            X.Abs(),
            Y.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I30F2 Half() => new Vector2I30F2(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I30F2 Twice() => new Vector2I30F2(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I30F2 Clamp(I30F2 min, I30F2 max) => new Vector2I30F2(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I30F2 Clamp(
            Vector2I30F2 min, Vector2I30F2 max
        ) => new Vector2I30F2(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I30F2 WrappingAdd(Vector2I30F2 other) => new Vector2I30F2(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I30F2 WrappingSub(Vector2I30F2 other) => new Vector2I30F2(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I30F2 WrappingMul(Vector2I30F2 other) => new Vector2I30F2(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I30F2 WrappingAddUnsigned(Vector2U30F2 other) => new Vector2I30F2(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I30F2 WrappingSubUnsigned(Vector2U30F2 other) => new Vector2I30F2(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U30F2 UnsignedAbs() => new Vector2U30F2(
            X.UnsignedAbs(),
            Y.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I30F2 SaturatingAdd(Vector2I30F2 other) => new Vector2I30F2(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I30F2 SaturatingMul(I30F2 other) => new Vector2I30F2(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long DotInternal(Vector2I30F2 other) {
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
        public readonly I30F2 Dot(Vector2I30F2 other) {
            const long k = 1L << 0;
            return I30F2.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I30F2 SaturatingDot(Vector2I30F2 other) {
            const long k = 1L << 0;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I30F2.MaxValue;
            } else if (bits < int.MinValue) {
                return I30F2.MinValue;
            } else {
                return I30F2.FromBits((int)bits);
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
        public readonly I62F2 LengthSquared() {
            return I62F2.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly int LengthInternal() {
            var squared = LengthSquaredInternal();
            return (int)Mathi.Sqrt((ulong)squared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I30F2 LengthHalf() => I30F2.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I31F1 Length() => I31F1.FromBits(LengthInternal());

    }

    partial struct I30F2 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I30F2 SaturatingMul(Vector2I30F2 other) => other.SaturatingMul(this);
    }
}
