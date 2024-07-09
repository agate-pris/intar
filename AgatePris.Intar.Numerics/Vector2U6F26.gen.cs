using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U6F26 : IEquatable<Vector2U6F26>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U6F26 X;
        public U6F26 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26(U6F26 x, U6F26 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26(U6F26 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26(Vector2U6F26 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U6F26 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U6F26(U6F26.Zero);
        }
        public static Vector2U6F26 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U6F26(U6F26.One);
        }
        public static Vector2U6F26 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U6F26(U6F26.One, U6F26.Zero);
        }
        public static Vector2U6F26 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U6F26(U6F26.Zero, U6F26.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 operator +(Vector2U6F26 a, Vector2U6F26 b) => new Vector2U6F26(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 operator -(Vector2U6F26 a, Vector2U6F26 b) => new Vector2U6F26(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 operator *(Vector2U6F26 a, Vector2U6F26 b) => new Vector2U6F26(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 operator *(Vector2U6F26 a, U6F26 b) => new Vector2U6F26(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 operator *(U6F26 a, Vector2U6F26 b) => new Vector2U6F26(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 operator /(Vector2U6F26 a, Vector2U6F26 b) => new Vector2U6F26(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 operator /(Vector2U6F26 a, U6F26 b) => new Vector2U6F26(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 operator /(U6F26 a, Vector2U6F26 b) => new Vector2U6F26(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U6F26 lhs, Vector2U6F26 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U6F26 lhs, Vector2U6F26 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U6F26 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(X, X); }
        public readonly Vector2U6F26 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(X, Y); }
        public readonly Vector2U6F26 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(Y, X); }
        public readonly Vector2U6F26 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(Y, Y); }
        public readonly Vector3U6F26 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, X, X); }
        public readonly Vector3U6F26 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, X, Y); }
        public readonly Vector3U6F26 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, Y, X); }
        public readonly Vector3U6F26 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, Y, Y); }
        public readonly Vector3U6F26 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, X, X); }
        public readonly Vector3U6F26 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, X, Y); }
        public readonly Vector3U6F26 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, Y, X); }
        public readonly Vector3U6F26 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, Y, Y); }
        public readonly Vector4U6F26 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, X, X); }
        public readonly Vector4U6F26 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, X, Y); }
        public readonly Vector4U6F26 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, Y, X); }
        public readonly Vector4U6F26 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, Y, Y); }
        public readonly Vector4U6F26 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, X, X); }
        public readonly Vector4U6F26 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, X, Y); }
        public readonly Vector4U6F26 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, Y, X); }
        public readonly Vector4U6F26 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, Y, Y); }
        public readonly Vector4U6F26 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, X, X); }
        public readonly Vector4U6F26 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, X, Y); }
        public readonly Vector4U6F26 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, Y, X); }
        public readonly Vector4U6F26 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, Y, Y); }
        public readonly Vector4U6F26 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, X, X); }
        public readonly Vector4U6F26 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, X, Y); }
        public readonly Vector4U6F26 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, Y, X); }
        public readonly Vector4U6F26 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U6F26 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U6F26>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U6F26 other)
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

        public readonly Vector2U6F26 Half() => new Vector2U6F26(
            X.Half(),
            Y.Half());

        public readonly Vector2U6F26 Twice() => new Vector2U6F26(
            X.Twice(),
            Y.Twice());

        public readonly Vector2U6F26 Clamp(U6F26 min, U6F26 max) => new Vector2U6F26(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        public readonly Vector2U6F26 Clamp(
            Vector2U6F26 min, Vector2U6F26 max
        ) => new Vector2U6F26(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U6F26 SaturatingAdd(Vector2U6F26 other) => new Vector2U6F26(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U6F26 SaturatingMul(U6F26 other) => new Vector2U6F26(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly ulong DotInternal(Vector2U6F26 other) {
            var x = ((ulong)X.Bits) * other.X.Bits;
            var y = ((ulong)Y.Bits) * other.Y.Bits;

            // オーバーフローを避けるため､ 事前に除算する｡
            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算に合わせて常に 4 で除算する｡
            return
                (x / 4) +
                (y / 4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U6F26 Dot(Vector2U6F26 other) {
            const ulong k = 1UL << 24;
            return U6F26.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U6F26 SaturatingDot(Vector2U6F26 other) {
            const ulong k = 1UL << 24;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U6F26.MaxValue;
            } else {
                return U6F26.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly ulong LengthSquaredInternal() => DotInternal(this);

        /// <summary>
        /// ベクトルの長さの 2 乗を返します｡
        /// </summary>
        /// <remarks>
        /// オーバーフローを防ぐため､ 計算の過程で 4 で除算しています｡
        /// そのため､ 精度が犠牲になっています｡
        /// また､ 戻り値の型もそれに準じて小数部が 2 ビット小さい型になっています｡
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U14F50 LengthSquared() {
            return U14F50.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly uint LengthInternal() {
            return (uint)Mathi.Sqrt(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U6F26 LengthHalf() => U6F26.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U7F25 Length() => U7F25.FromBits(LengthInternal());

    }

    partial struct U6F26 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U6F26 SaturatingMul(Vector2U6F26 other) => other.SaturatingMul(this);
    }
}
