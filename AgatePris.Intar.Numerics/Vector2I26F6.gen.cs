using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I26F6 : IEquatable<Vector2I26F6>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I26F6 X;
        public I26F6 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I26F6(I26F6 x, I26F6 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I26F6(I26F6 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I26F6(Vector2I26F6 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I26F6 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I26F6(I26F6.Zero);
        }
        public static Vector2I26F6 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I26F6(I26F6.One);
        }
        public static Vector2I26F6 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I26F6(I26F6.One, I26F6.Zero);
        }
        public static Vector2I26F6 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I26F6(I26F6.Zero, I26F6.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator +(Vector2I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator -(Vector2I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator *(Vector2I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator *(Vector2I26F6 a, I26F6 b) => new Vector2I26F6(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator *(I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator /(Vector2I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator /(Vector2I26F6 a, I26F6 b) => new Vector2I26F6(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I26F6 operator /(I26F6 a, Vector2I26F6 b) => new Vector2I26F6(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I26F6 lhs, Vector2I26F6 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I26F6 lhs, Vector2I26F6 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I26F6 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(X, X); }
        public readonly Vector2I26F6 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(X, Y); }
        public readonly Vector2I26F6 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(Y, X); }
        public readonly Vector2I26F6 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I26F6(Y, Y); }
        public readonly Vector3I26F6 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, X, X); }
        public readonly Vector3I26F6 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, X, Y); }
        public readonly Vector3I26F6 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, Y, X); }
        public readonly Vector3I26F6 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(X, Y, Y); }
        public readonly Vector3I26F6 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, X, X); }
        public readonly Vector3I26F6 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, X, Y); }
        public readonly Vector3I26F6 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, Y, X); }
        public readonly Vector3I26F6 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I26F6(Y, Y, Y); }
        public readonly Vector4I26F6 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, X, X); }
        public readonly Vector4I26F6 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, X, Y); }
        public readonly Vector4I26F6 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, Y, X); }
        public readonly Vector4I26F6 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, X, Y, Y); }
        public readonly Vector4I26F6 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, X, X); }
        public readonly Vector4I26F6 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, X, Y); }
        public readonly Vector4I26F6 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, Y, X); }
        public readonly Vector4I26F6 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(X, Y, Y, Y); }
        public readonly Vector4I26F6 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, X, X); }
        public readonly Vector4I26F6 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, X, Y); }
        public readonly Vector4I26F6 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, Y, X); }
        public readonly Vector4I26F6 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, X, Y, Y); }
        public readonly Vector4I26F6 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, X, X); }
        public readonly Vector4I26F6 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, X, Y); }
        public readonly Vector4I26F6 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, Y, X); }
        public readonly Vector4I26F6 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I26F6(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I26F6 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I26F6>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I26F6 other)
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
        public readonly Vector2I26F6 Min(Vector2I26F6 other) => new Vector2I26F6(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I26F6 Max(Vector2I26F6 other) => new Vector2I26F6(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I26F6 Abs() => new Vector2I26F6(
            X.Abs(),
            Y.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I26F6 Half() => new Vector2I26F6(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I26F6 Twice() => new Vector2I26F6(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I26F6 Clamp(I26F6 min, I26F6 max) => new Vector2I26F6(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I26F6 Clamp(
            Vector2I26F6 min, Vector2I26F6 max
        ) => new Vector2I26F6(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I26F6 SaturatingAdd(Vector2I26F6 other) => new Vector2I26F6(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I26F6 SaturatingMul(I26F6 other) => new Vector2I26F6(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long DotInternal(Vector2I26F6 other) {
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
        public readonly I26F6 Dot(Vector2I26F6 other) {
            const long k = 1L << 4;
            return I26F6.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I26F6 SaturatingDot(Vector2I26F6 other) {
            const long k = 1L << 4;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I26F6.MaxValue;
            } else if (bits < int.MinValue) {
                return I26F6.MinValue;
            } else {
                return I26F6.FromBits((int)bits);
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
        public readonly I54F10 LengthSquared() {
            return I54F10.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly int LengthInternal() {
            var squared = LengthSquaredInternal();
            return (int)Mathi.Sqrt((ulong)squared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I26F6 LengthHalf() => I26F6.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I27F5 Length() => I27F5.FromBits(LengthInternal());

    }

    partial struct I26F6 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I26F6 SaturatingMul(Vector2I26F6 other) => other.SaturatingMul(this);
    }
}
