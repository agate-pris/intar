using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U29F3 : IEquatable<Vector2U29F3>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U29F3 X;
        public U29F3 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U29F3(U29F3 x, U29F3 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U29F3(U29F3 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U29F3(Vector2U29F3 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U29F3 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U29F3(U29F3.Zero);
        }
        public static Vector2U29F3 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U29F3(U29F3.One);
        }
        public static Vector2U29F3 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U29F3(U29F3.One, U29F3.Zero);
        }
        public static Vector2U29F3 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U29F3(U29F3.Zero, U29F3.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 operator +(Vector2U29F3 a, Vector2U29F3 b) => new Vector2U29F3(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 operator -(Vector2U29F3 a, Vector2U29F3 b) => new Vector2U29F3(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 operator *(Vector2U29F3 a, Vector2U29F3 b) => new Vector2U29F3(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 operator *(Vector2U29F3 a, U29F3 b) => new Vector2U29F3(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 operator *(U29F3 a, Vector2U29F3 b) => new Vector2U29F3(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 operator /(Vector2U29F3 a, Vector2U29F3 b) => new Vector2U29F3(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 operator /(Vector2U29F3 a, U29F3 b) => new Vector2U29F3(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U29F3 operator /(U29F3 a, Vector2U29F3 b) => new Vector2U29F3(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U29F3 lhs, Vector2U29F3 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U29F3 lhs, Vector2U29F3 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2U29F3 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(X, X); }
        public readonly Vector2U29F3 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(X, Y); }
        public readonly Vector2U29F3 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(Y, X); }
        public readonly Vector2U29F3 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U29F3(Y, Y); }
        public readonly Vector3U29F3 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, X, X); }
        public readonly Vector3U29F3 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, X, Y); }
        public readonly Vector3U29F3 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, Y, X); }
        public readonly Vector3U29F3 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(X, Y, Y); }
        public readonly Vector3U29F3 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, X, X); }
        public readonly Vector3U29F3 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, X, Y); }
        public readonly Vector3U29F3 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, Y, X); }
        public readonly Vector3U29F3 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U29F3(Y, Y, Y); }
        public readonly Vector4U29F3 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, X, X); }
        public readonly Vector4U29F3 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, X, Y); }
        public readonly Vector4U29F3 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, Y, X); }
        public readonly Vector4U29F3 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, X, Y, Y); }
        public readonly Vector4U29F3 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, X, X); }
        public readonly Vector4U29F3 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, X, Y); }
        public readonly Vector4U29F3 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, Y, X); }
        public readonly Vector4U29F3 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(X, Y, Y, Y); }
        public readonly Vector4U29F3 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, X, X); }
        public readonly Vector4U29F3 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, X, Y); }
        public readonly Vector4U29F3 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, Y, X); }
        public readonly Vector4U29F3 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, X, Y, Y); }
        public readonly Vector4U29F3 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, X, X); }
        public readonly Vector4U29F3 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, X, Y); }
        public readonly Vector4U29F3 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, Y, X); }
        public readonly Vector4U29F3 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U29F3(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2U29F3 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U29F3>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2U29F3 other)
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
        public readonly Vector2U29F3 Min(Vector2U29F3 other) => new Vector2U29F3(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U29F3 Max(Vector2U29F3 other) => new Vector2U29F3(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U29F3 Half() => new Vector2U29F3(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U29F3 Twice() => new Vector2U29F3(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U29F3 Clamp(U29F3 min, U29F3 max) => new Vector2U29F3(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U29F3 Clamp(
            Vector2U29F3 min, Vector2U29F3 max
        ) => new Vector2U29F3(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U29F3 SaturatingAdd(Vector2U29F3 other) => new Vector2U29F3(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U29F3 SaturatingMul(U29F3 other) => new Vector2U29F3(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly ulong DotInternal(Vector2U29F3 other) {
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
        public readonly U29F3 Dot(Vector2U29F3 other) {
            const ulong k = 1UL << 1;
            return U29F3.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U29F3 SaturatingDot(Vector2U29F3 other) {
            const ulong k = 1UL << 1;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U29F3.MaxValue;
            } else {
                return U29F3.FromBits((uint)bits);
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
        public readonly U60F4 LengthSquared() {
            return U60F4.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly uint LengthInternal() {
            return (uint)Mathi.Sqrt(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U29F3 LengthHalf() => U29F3.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly U30F2 Length() => U30F2.FromBits(LengthInternal());

    }

    partial struct U29F3 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2U29F3 SaturatingMul(Vector2U29F3 other) => other.SaturatingMul(this);
    }
}
