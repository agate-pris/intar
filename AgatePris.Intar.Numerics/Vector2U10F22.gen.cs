using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U10F22 : IEquatable<Vector2U10F22>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U10F22 X;
        public U10F22 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22(U10F22 x, U10F22 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22(U10F22 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22(Vector2U10F22 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U10F22 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U10F22(U10F22.Zero);
        }
        public static Vector2U10F22 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U10F22(U10F22.One);
        }
        public static Vector2U10F22 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U10F22(U10F22.One, U10F22.Zero);
        }
        public static Vector2U10F22 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U10F22(U10F22.Zero, U10F22.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator +(Vector2U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator -(Vector2U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator *(Vector2U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator *(Vector2U10F22 a, U10F22 b) => new Vector2U10F22(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator *(U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator /(Vector2U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator /(Vector2U10F22 a, U10F22 b) => new Vector2U10F22(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U10F22 operator /(U10F22 a, Vector2U10F22 b) => new Vector2U10F22(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U10F22 lhs, Vector2U10F22 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U10F22 lhs, Vector2U10F22 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U10F22 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(X, X); }
        public Vector2U10F22 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(X, Y); }
        public Vector2U10F22 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(Y, X); }
        public Vector2U10F22 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U10F22(Y, Y); }
        public Vector3U10F22 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, X, X); }
        public Vector3U10F22 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, X, Y); }
        public Vector3U10F22 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, Y, X); }
        public Vector3U10F22 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(X, Y, Y); }
        public Vector3U10F22 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, X, X); }
        public Vector3U10F22 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, X, Y); }
        public Vector3U10F22 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, Y, X); }
        public Vector3U10F22 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U10F22(Y, Y, Y); }
        public Vector4U10F22 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, X, X); }
        public Vector4U10F22 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, X, Y); }
        public Vector4U10F22 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, Y, X); }
        public Vector4U10F22 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, X, Y, Y); }
        public Vector4U10F22 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, X, X); }
        public Vector4U10F22 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, X, Y); }
        public Vector4U10F22 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, Y, X); }
        public Vector4U10F22 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(X, Y, Y, Y); }
        public Vector4U10F22 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, X, X); }
        public Vector4U10F22 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, X, Y); }
        public Vector4U10F22 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, Y, X); }
        public Vector4U10F22 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, X, Y, Y); }
        public Vector4U10F22 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, X, X); }
        public Vector4U10F22 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, X, Y); }
        public Vector4U10F22 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, Y, X); }
        public Vector4U10F22 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U10F22(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector2U10F22 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U10F22>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2U10F22 other)
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
        public Vector2U10F22 Min(Vector2U10F22 other) => new Vector2U10F22(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22 Max(Vector2U10F22 other) => new Vector2U10F22(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22 Half() => new Vector2U10F22(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22 Twice() => new Vector2U10F22(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22 Clamp(U10F22 min, U10F22 max) => new Vector2U10F22(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22 Clamp(
            Vector2U10F22 min, Vector2U10F22 max
        ) => new Vector2U10F22(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22 WrappingAdd(Vector2U10F22 other) => new Vector2U10F22(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22 WrappingSub(Vector2U10F22 other) => new Vector2U10F22(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22 WrappingMul(Vector2U10F22 other) => new Vector2U10F22(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22 WrappingAddSigned(Vector2I10F22 other) => new Vector2U10F22(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22 SaturatingAdd(Vector2U10F22 other) => new Vector2U10F22(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22 SaturatingMul(U10F22 other) => new Vector2U10F22(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector2U10F22 other) {
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
        public U10F22 Dot(Vector2U10F22 other) {
            const ulong k = 1UL << 20;
            return U10F22.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U10F22 SaturatingDot(Vector2U10F22 other) {
            const ulong k = 1UL << 20;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U10F22.MaxValue;
            } else {
                return U10F22.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        /// <summary>
        /// ベクトルの長さの 2 乗を返します｡
        /// </summary>
        /// <remarks>
        /// オーバーフローを防ぐため､ 計算の過程で 4 で除算しています｡
        /// そのため､ 精度が犠牲になっています｡
        /// また､ 戻り値の型もそれに準じて小数部が 2 ビット小さい型になっています｡
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U22F42 LengthSquared() {
            return U22F42.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint LengthInternal() {
            return (uint)Mathi.Sqrt(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U10F22 LengthHalf() => U10F22.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U11F21 Length() => U11F21.FromBits(LengthInternal());

    }

    partial struct U10F22 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U10F22 SaturatingMul(Vector2U10F22 other) => other.SaturatingMul(this);
    }
}
