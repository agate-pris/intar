using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I11F21 : IEquatable<Vector2I11F21>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I11F21 X;
        public I11F21 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I11F21(I11F21 x, I11F21 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I11F21(I11F21 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I11F21(Vector2I11F21 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I11F21 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I11F21(I11F21.Zero);
        }
        public static Vector2I11F21 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I11F21(I11F21.One);
        }
        public static Vector2I11F21 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I11F21(I11F21.One, I11F21.Zero);
        }
        public static Vector2I11F21 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I11F21(I11F21.Zero, I11F21.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 operator +(Vector2I11F21 a, Vector2I11F21 b) => new Vector2I11F21(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 operator -(Vector2I11F21 a, Vector2I11F21 b) => new Vector2I11F21(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 operator *(Vector2I11F21 a, Vector2I11F21 b) => new Vector2I11F21(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 operator *(Vector2I11F21 a, I11F21 b) => new Vector2I11F21(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 operator *(I11F21 a, Vector2I11F21 b) => new Vector2I11F21(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 operator /(Vector2I11F21 a, Vector2I11F21 b) => new Vector2I11F21(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 operator /(Vector2I11F21 a, I11F21 b) => new Vector2I11F21(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I11F21 operator /(I11F21 a, Vector2I11F21 b) => new Vector2I11F21(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I11F21 lhs, Vector2I11F21 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I11F21 lhs, Vector2I11F21 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I11F21 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(X, X); }
        public readonly Vector2I11F21 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(X, Y); }
        public readonly Vector2I11F21 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Y, X); }
        public readonly Vector2I11F21 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I11F21(Y, Y); }
        public readonly Vector3I11F21 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, X, X); }
        public readonly Vector3I11F21 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, X, Y); }
        public readonly Vector3I11F21 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Y, X); }
        public readonly Vector3I11F21 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(X, Y, Y); }
        public readonly Vector3I11F21 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, X, X); }
        public readonly Vector3I11F21 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, X, Y); }
        public readonly Vector3I11F21 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Y, X); }
        public readonly Vector3I11F21 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I11F21(Y, Y, Y); }
        public readonly Vector4I11F21 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, X, X); }
        public readonly Vector4I11F21 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, X, Y); }
        public readonly Vector4I11F21 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Y, X); }
        public readonly Vector4I11F21 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, X, Y, Y); }
        public readonly Vector4I11F21 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, X, X); }
        public readonly Vector4I11F21 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, X, Y); }
        public readonly Vector4I11F21 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Y, X); }
        public readonly Vector4I11F21 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(X, Y, Y, Y); }
        public readonly Vector4I11F21 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, X, X); }
        public readonly Vector4I11F21 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, X, Y); }
        public readonly Vector4I11F21 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Y, X); }
        public readonly Vector4I11F21 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, X, Y, Y); }
        public readonly Vector4I11F21 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, X, X); }
        public readonly Vector4I11F21 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, X, Y); }
        public readonly Vector4I11F21 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Y, X); }
        public readonly Vector4I11F21 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I11F21(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I11F21 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I11F21>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I11F21 other)
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
        public readonly Vector2I11F21 Min(Vector2I11F21 other) => new Vector2I11F21(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I11F21 Max(Vector2I11F21 other) => new Vector2I11F21(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I11F21 Abs() => new Vector2I11F21(
            X.Abs(),
            Y.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I11F21 Half() => new Vector2I11F21(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I11F21 Twice() => new Vector2I11F21(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I11F21 Clamp(I11F21 min, I11F21 max) => new Vector2I11F21(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I11F21 Clamp(
            Vector2I11F21 min, Vector2I11F21 max
        ) => new Vector2I11F21(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I11F21 WrappingAdd(Vector2I11F21 other) => new Vector2I11F21(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I11F21 WrappingSub(Vector2I11F21 other) => new Vector2I11F21(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I11F21 WrappingMul(Vector2I11F21 other) => new Vector2I11F21(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I11F21 WrappingAddUnsigned(Vector2U11F21 other) => new Vector2I11F21(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I11F21 WrappingSubUnsigned(Vector2U11F21 other) => new Vector2I11F21(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U11F21 UnsignedAbs() => new Vector2U11F21(
            X.UnsignedAbs(),
            Y.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I11F21 SaturatingAdd(Vector2I11F21 other) => new Vector2I11F21(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I11F21 SaturatingMul(I11F21 other) => new Vector2I11F21(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long DotInternal(Vector2I11F21 other) {
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
        public readonly I11F21 Dot(Vector2I11F21 other) {
            const long k = 1L << 19;
            return I11F21.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I11F21 SaturatingDot(Vector2I11F21 other) {
            const long k = 1L << 19;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I11F21.MaxValue;
            } else if (bits < int.MinValue) {
                return I11F21.MinValue;
            } else {
                return I11F21.FromBits((int)bits);
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
        public readonly I24F40 LengthSquared() {
            return I24F40.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly int LengthInternal() {
            var squared = LengthSquaredInternal();
            return (int)Mathi.Sqrt((ulong)squared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I11F21 LengthHalf() => I11F21.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I12F20 Length() => I12F20.FromBits(LengthInternal());

    }

    partial struct I11F21 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I11F21 SaturatingMul(Vector2I11F21 other) => other.SaturatingMul(this);
    }
}
