using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I27F5 : IEquatable<Vector2I27F5>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I27F5 X;
        public I27F5 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I27F5(I27F5 x, I27F5 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I27F5(I27F5 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I27F5(Vector2I27F5 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I27F5 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I27F5(I27F5.Zero);
        }
        public static Vector2I27F5 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I27F5(I27F5.One);
        }
        public static Vector2I27F5 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I27F5(I27F5.One, I27F5.Zero);
        }
        public static Vector2I27F5 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I27F5(I27F5.Zero, I27F5.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator +(Vector2I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator -(Vector2I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator *(Vector2I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator *(Vector2I27F5 a, I27F5 b) => new Vector2I27F5(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator *(I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator /(Vector2I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator /(Vector2I27F5 a, I27F5 b) => new Vector2I27F5(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I27F5 operator /(I27F5 a, Vector2I27F5 b) => new Vector2I27F5(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I27F5 lhs, Vector2I27F5 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I27F5 lhs, Vector2I27F5 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I27F5 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(X, X); }
        public readonly Vector2I27F5 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(X, Y); }
        public readonly Vector2I27F5 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Y, X); }
        public readonly Vector2I27F5 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I27F5(Y, Y); }
        public readonly Vector3I27F5 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, X, X); }
        public readonly Vector3I27F5 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, X, Y); }
        public readonly Vector3I27F5 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Y, X); }
        public readonly Vector3I27F5 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(X, Y, Y); }
        public readonly Vector3I27F5 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, X, X); }
        public readonly Vector3I27F5 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, X, Y); }
        public readonly Vector3I27F5 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Y, X); }
        public readonly Vector3I27F5 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I27F5(Y, Y, Y); }
        public readonly Vector4I27F5 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, X, X); }
        public readonly Vector4I27F5 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, X, Y); }
        public readonly Vector4I27F5 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Y, X); }
        public readonly Vector4I27F5 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, X, Y, Y); }
        public readonly Vector4I27F5 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, X, X); }
        public readonly Vector4I27F5 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, X, Y); }
        public readonly Vector4I27F5 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Y, X); }
        public readonly Vector4I27F5 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(X, Y, Y, Y); }
        public readonly Vector4I27F5 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, X, X); }
        public readonly Vector4I27F5 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, X, Y); }
        public readonly Vector4I27F5 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Y, X); }
        public readonly Vector4I27F5 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, X, Y, Y); }
        public readonly Vector4I27F5 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, X, X); }
        public readonly Vector4I27F5 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, X, Y); }
        public readonly Vector4I27F5 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Y, X); }
        public readonly Vector4I27F5 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I27F5(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I27F5 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I27F5>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I27F5 other)
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
        public readonly Vector2I27F5 Min(Vector2I27F5 other) => new Vector2I27F5(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I27F5 Max(Vector2I27F5 other) => new Vector2I27F5(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I27F5 Abs() => new Vector2I27F5(
            X.Abs(),
            Y.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I27F5 Half() => new Vector2I27F5(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I27F5 Twice() => new Vector2I27F5(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I27F5 Clamp(I27F5 min, I27F5 max) => new Vector2I27F5(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I27F5 Clamp(
            Vector2I27F5 min, Vector2I27F5 max
        ) => new Vector2I27F5(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I27F5 WrappingAdd(Vector2I27F5 other) => new Vector2I27F5(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I27F5 WrappingSub(Vector2I27F5 other) => new Vector2I27F5(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I27F5 WrappingMul(Vector2I27F5 other) => new Vector2I27F5(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I27F5 WrappingAddUnsigned(Vector2U27F5 other) => new Vector2I27F5(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I27F5 WrappingSubUnsigned(Vector2U27F5 other) => new Vector2I27F5(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I27F5 SaturatingAdd(Vector2I27F5 other) => new Vector2I27F5(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I27F5 SaturatingMul(I27F5 other) => new Vector2I27F5(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long DotInternal(Vector2I27F5 other) {
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
        public readonly I27F5 Dot(Vector2I27F5 other) {
            const long k = 1L << 3;
            return I27F5.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I27F5 SaturatingDot(Vector2I27F5 other) {
            const long k = 1L << 3;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I27F5.MaxValue;
            } else if (bits < int.MinValue) {
                return I27F5.MinValue;
            } else {
                return I27F5.FromBits((int)bits);
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
        public readonly I56F8 LengthSquared() {
            return I56F8.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly int LengthInternal() {
            var squared = LengthSquaredInternal();
            return (int)Mathi.Sqrt((ulong)squared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I27F5 LengthHalf() => I27F5.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I28F4 Length() => I28F4.FromBits(LengthInternal());

    }

    partial struct I27F5 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I27F5 SaturatingMul(Vector2I27F5 other) => other.SaturatingMul(this);
    }
}
