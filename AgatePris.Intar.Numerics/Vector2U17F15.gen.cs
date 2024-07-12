using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U17F15 : IEquatable<Vector2U17F15>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U17F15 X;
        public U17F15 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15(U17F15 x, U17F15 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15(U17F15 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15(Vector2U17F15 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U17F15 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U17F15(U17F15.Zero);
        }
        public static Vector2U17F15 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U17F15(U17F15.One);
        }
        public static Vector2U17F15 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U17F15(U17F15.One, U17F15.Zero);
        }
        public static Vector2U17F15 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U17F15(U17F15.Zero, U17F15.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator +(Vector2U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator -(Vector2U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator *(Vector2U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator *(Vector2U17F15 a, U17F15 b) => new Vector2U17F15(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator *(U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator /(Vector2U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator /(Vector2U17F15 a, U17F15 b) => new Vector2U17F15(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U17F15 operator /(U17F15 a, Vector2U17F15 b) => new Vector2U17F15(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U17F15 lhs, Vector2U17F15 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U17F15 lhs, Vector2U17F15 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U17F15 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(X, X); }
        public Vector2U17F15 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(X, Y); }
        public Vector2U17F15 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Y, X); }
        public Vector2U17F15 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U17F15(Y, Y); }
        public Vector3U17F15 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, X, X); }
        public Vector3U17F15 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, X, Y); }
        public Vector3U17F15 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Y, X); }
        public Vector3U17F15 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(X, Y, Y); }
        public Vector3U17F15 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, X, X); }
        public Vector3U17F15 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, X, Y); }
        public Vector3U17F15 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Y, X); }
        public Vector3U17F15 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U17F15(Y, Y, Y); }
        public Vector4U17F15 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, X, X); }
        public Vector4U17F15 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, X, Y); }
        public Vector4U17F15 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Y, X); }
        public Vector4U17F15 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, X, Y, Y); }
        public Vector4U17F15 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, X, X); }
        public Vector4U17F15 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, X, Y); }
        public Vector4U17F15 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Y, X); }
        public Vector4U17F15 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(X, Y, Y, Y); }
        public Vector4U17F15 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, X, X); }
        public Vector4U17F15 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, X, Y); }
        public Vector4U17F15 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Y, X); }
        public Vector4U17F15 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, X, Y, Y); }
        public Vector4U17F15 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, X, X); }
        public Vector4U17F15 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, X, Y); }
        public Vector4U17F15 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Y, X); }
        public Vector4U17F15 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U17F15(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector2U17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2U17F15 other)
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
        public Vector2U17F15 Min(Vector2U17F15 other) => new Vector2U17F15(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15 Max(Vector2U17F15 other) => new Vector2U17F15(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15 Half() => new Vector2U17F15(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15 Twice() => new Vector2U17F15(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15 Clamp(U17F15 min, U17F15 max) => new Vector2U17F15(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15 Clamp(
            Vector2U17F15 min, Vector2U17F15 max
        ) => new Vector2U17F15(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15 WrappingAdd(Vector2U17F15 other) => new Vector2U17F15(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15 WrappingSub(Vector2U17F15 other) => new Vector2U17F15(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15 WrappingMul(Vector2U17F15 other) => new Vector2U17F15(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15 WrappingAddSigned(Vector2I17F15 other) => new Vector2U17F15(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15 SaturatingAdd(Vector2U17F15 other) => new Vector2U17F15(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15 SaturatingMul(U17F15 other) => new Vector2U17F15(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector2U17F15 other) {
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
        public U17F15 Dot(Vector2U17F15 other) {
            const ulong k = 1UL << 13;
            return U17F15.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 SaturatingDot(Vector2U17F15 other) {
            const ulong k = 1UL << 13;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U17F15.MaxValue;
            } else {
                return U17F15.FromBits((uint)bits);
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
        public U36F28 LengthSquared() {
            return U36F28.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint LengthInternal() {
            return (uint)Mathi.Sqrt(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 LengthHalf() => U17F15.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U18F14 Length() => U18F14.FromBits(LengthInternal());

    }

    partial struct U17F15 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15 SaturatingMul(Vector2U17F15 other) => other.SaturatingMul(this);
    }
}
