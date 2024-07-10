using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I28F4 : IEquatable<Vector2I28F4>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I28F4 X;
        public I28F4 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4(I28F4 x, I28F4 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4(I28F4 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4(Vector2I28F4 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I28F4 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I28F4(I28F4.Zero);
        }
        public static Vector2I28F4 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I28F4(I28F4.One);
        }
        public static Vector2I28F4 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I28F4(I28F4.One, I28F4.Zero);
        }
        public static Vector2I28F4 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I28F4(I28F4.Zero, I28F4.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator +(Vector2I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator -(Vector2I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator *(Vector2I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator *(Vector2I28F4 a, I28F4 b) => new Vector2I28F4(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator *(I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator /(Vector2I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator /(Vector2I28F4 a, I28F4 b) => new Vector2I28F4(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator /(I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I28F4 lhs, Vector2I28F4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I28F4 lhs, Vector2I28F4 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I28F4 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(X, X); }
        public readonly Vector2I28F4 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(X, Y); }
        public readonly Vector2I28F4 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Y, X); }
        public readonly Vector2I28F4 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Y, Y); }
        public readonly Vector3I28F4 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, X, X); }
        public readonly Vector3I28F4 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, X, Y); }
        public readonly Vector3I28F4 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Y, X); }
        public readonly Vector3I28F4 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Y, Y); }
        public readonly Vector3I28F4 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, X, X); }
        public readonly Vector3I28F4 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, X, Y); }
        public readonly Vector3I28F4 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Y, X); }
        public readonly Vector3I28F4 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Y, Y); }
        public readonly Vector4I28F4 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, X, X); }
        public readonly Vector4I28F4 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, X, Y); }
        public readonly Vector4I28F4 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Y, X); }
        public readonly Vector4I28F4 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Y, Y); }
        public readonly Vector4I28F4 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, X, X); }
        public readonly Vector4I28F4 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, X, Y); }
        public readonly Vector4I28F4 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Y, X); }
        public readonly Vector4I28F4 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Y, Y); }
        public readonly Vector4I28F4 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, X, X); }
        public readonly Vector4I28F4 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, X, Y); }
        public readonly Vector4I28F4 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Y, X); }
        public readonly Vector4I28F4 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Y, Y); }
        public readonly Vector4I28F4 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, X, X); }
        public readonly Vector4I28F4 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, X, Y); }
        public readonly Vector4I28F4 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Y, X); }
        public readonly Vector4I28F4 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I28F4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I28F4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I28F4 other)
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
        public readonly Vector2I28F4 Half() => new Vector2I28F4(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I28F4 Twice() => new Vector2I28F4(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I28F4 Clamp(I28F4 min, I28F4 max) => new Vector2I28F4(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I28F4 Clamp(
            Vector2I28F4 min, Vector2I28F4 max
        ) => new Vector2I28F4(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I28F4 SaturatingAdd(Vector2I28F4 other) => new Vector2I28F4(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I28F4 SaturatingMul(I28F4 other) => new Vector2I28F4(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long DotInternal(Vector2I28F4 other) {
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
        public readonly I28F4 Dot(Vector2I28F4 other) {
            const long k = 1L << 2;
            return I28F4.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I28F4 SaturatingDot(Vector2I28F4 other) {
            const long k = 1L << 2;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I28F4.MaxValue;
            } else if (bits < int.MinValue) {
                return I28F4.MinValue;
            } else {
                return I28F4.FromBits((int)bits);
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
        public readonly I58F6 LengthSquared() {
            return I58F6.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly int LengthInternal() {
            var squared = LengthSquaredInternal();
            return (int)Mathi.Sqrt((ulong)squared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I28F4 LengthHalf() => I28F4.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I29F3 Length() => I29F3.FromBits(LengthInternal());

    }

    partial struct I28F4 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I28F4 SaturatingMul(Vector2I28F4 other) => other.SaturatingMul(this);
    }
}
