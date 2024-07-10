using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I14F18 : IEquatable<Vector2I14F18>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I14F18 X;
        public I14F18 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I14F18(I14F18 x, I14F18 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I14F18(I14F18 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I14F18(Vector2I14F18 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I14F18 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I14F18(I14F18.Zero);
        }
        public static Vector2I14F18 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I14F18(I14F18.One);
        }
        public static Vector2I14F18 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I14F18(I14F18.One, I14F18.Zero);
        }
        public static Vector2I14F18 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I14F18(I14F18.Zero, I14F18.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 operator +(Vector2I14F18 a, Vector2I14F18 b) => new Vector2I14F18(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 operator -(Vector2I14F18 a, Vector2I14F18 b) => new Vector2I14F18(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 operator *(Vector2I14F18 a, Vector2I14F18 b) => new Vector2I14F18(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 operator *(Vector2I14F18 a, I14F18 b) => new Vector2I14F18(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 operator *(I14F18 a, Vector2I14F18 b) => new Vector2I14F18(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 operator /(Vector2I14F18 a, Vector2I14F18 b) => new Vector2I14F18(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 operator /(Vector2I14F18 a, I14F18 b) => new Vector2I14F18(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I14F18 operator /(I14F18 a, Vector2I14F18 b) => new Vector2I14F18(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I14F18 lhs, Vector2I14F18 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I14F18 lhs, Vector2I14F18 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I14F18 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(X, X); }
        public readonly Vector2I14F18 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(X, Y); }
        public readonly Vector2I14F18 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Y, X); }
        public readonly Vector2I14F18 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I14F18(Y, Y); }
        public readonly Vector3I14F18 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, X, X); }
        public readonly Vector3I14F18 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, X, Y); }
        public readonly Vector3I14F18 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Y, X); }
        public readonly Vector3I14F18 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(X, Y, Y); }
        public readonly Vector3I14F18 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, X, X); }
        public readonly Vector3I14F18 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, X, Y); }
        public readonly Vector3I14F18 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Y, X); }
        public readonly Vector3I14F18 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I14F18(Y, Y, Y); }
        public readonly Vector4I14F18 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, X, X); }
        public readonly Vector4I14F18 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, X, Y); }
        public readonly Vector4I14F18 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Y, X); }
        public readonly Vector4I14F18 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, X, Y, Y); }
        public readonly Vector4I14F18 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, X, X); }
        public readonly Vector4I14F18 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, X, Y); }
        public readonly Vector4I14F18 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Y, X); }
        public readonly Vector4I14F18 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(X, Y, Y, Y); }
        public readonly Vector4I14F18 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, X, X); }
        public readonly Vector4I14F18 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, X, Y); }
        public readonly Vector4I14F18 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Y, X); }
        public readonly Vector4I14F18 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, X, Y, Y); }
        public readonly Vector4I14F18 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, X, X); }
        public readonly Vector4I14F18 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, X, Y); }
        public readonly Vector4I14F18 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Y, X); }
        public readonly Vector4I14F18 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I14F18(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I14F18 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I14F18>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I14F18 other)
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
        public readonly Vector2I14F18 Min(Vector2I14F18 other) => new Vector2I14F18(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I14F18 Max(Vector2I14F18 other) => new Vector2I14F18(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I14F18 Abs() => new Vector2I14F18(
            X.Abs(),
            Y.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I14F18 Half() => new Vector2I14F18(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I14F18 Twice() => new Vector2I14F18(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I14F18 Clamp(I14F18 min, I14F18 max) => new Vector2I14F18(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I14F18 Clamp(
            Vector2I14F18 min, Vector2I14F18 max
        ) => new Vector2I14F18(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I14F18 SaturatingAdd(Vector2I14F18 other) => new Vector2I14F18(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I14F18 SaturatingMul(I14F18 other) => new Vector2I14F18(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long DotInternal(Vector2I14F18 other) {
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
        public readonly I14F18 Dot(Vector2I14F18 other) {
            const long k = 1L << 16;
            return I14F18.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I14F18 SaturatingDot(Vector2I14F18 other) {
            const long k = 1L << 16;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I14F18.MaxValue;
            } else if (bits < int.MinValue) {
                return I14F18.MinValue;
            } else {
                return I14F18.FromBits((int)bits);
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
        public readonly I30F34 LengthSquared() {
            return I30F34.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly int LengthInternal() {
            var squared = LengthSquaredInternal();
            return (int)Mathi.Sqrt((ulong)squared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I14F18 LengthHalf() => I14F18.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I15F17 Length() => I15F17.FromBits(LengthInternal());

    }

    partial struct I14F18 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I14F18 SaturatingMul(Vector2I14F18 other) => other.SaturatingMul(this);
    }
}
