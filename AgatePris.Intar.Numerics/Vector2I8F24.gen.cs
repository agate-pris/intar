using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I8F24 : IEquatable<Vector2I8F24>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I8F24 X;
        public I8F24 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I8F24(I8F24 x, I8F24 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I8F24(I8F24 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I8F24(Vector2I8F24 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I8F24 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I8F24(I8F24.Zero);
        }
        public static Vector2I8F24 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I8F24(I8F24.One);
        }
        public static Vector2I8F24 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I8F24(I8F24.One, I8F24.Zero);
        }
        public static Vector2I8F24 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I8F24(I8F24.Zero, I8F24.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 operator +(Vector2I8F24 a, Vector2I8F24 b) => new Vector2I8F24(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 operator -(Vector2I8F24 a, Vector2I8F24 b) => new Vector2I8F24(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 operator *(Vector2I8F24 a, Vector2I8F24 b) => new Vector2I8F24(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 operator *(Vector2I8F24 a, I8F24 b) => new Vector2I8F24(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 operator *(I8F24 a, Vector2I8F24 b) => new Vector2I8F24(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 operator /(Vector2I8F24 a, Vector2I8F24 b) => new Vector2I8F24(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 operator /(Vector2I8F24 a, I8F24 b) => new Vector2I8F24(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F24 operator /(I8F24 a, Vector2I8F24 b) => new Vector2I8F24(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I8F24 lhs, Vector2I8F24 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I8F24 lhs, Vector2I8F24 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I8F24 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(X, X); }
        public readonly Vector2I8F24 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(X, Y); }
        public readonly Vector2I8F24 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Y, X); }
        public readonly Vector2I8F24 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I8F24(Y, Y); }
        public readonly Vector3I8F24 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, X, X); }
        public readonly Vector3I8F24 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, X, Y); }
        public readonly Vector3I8F24 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Y, X); }
        public readonly Vector3I8F24 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(X, Y, Y); }
        public readonly Vector3I8F24 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, X, X); }
        public readonly Vector3I8F24 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, X, Y); }
        public readonly Vector3I8F24 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Y, X); }
        public readonly Vector3I8F24 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I8F24(Y, Y, Y); }
        public readonly Vector4I8F24 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, X, X); }
        public readonly Vector4I8F24 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, X, Y); }
        public readonly Vector4I8F24 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Y, X); }
        public readonly Vector4I8F24 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, X, Y, Y); }
        public readonly Vector4I8F24 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, X, X); }
        public readonly Vector4I8F24 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, X, Y); }
        public readonly Vector4I8F24 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Y, X); }
        public readonly Vector4I8F24 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(X, Y, Y, Y); }
        public readonly Vector4I8F24 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, X, X); }
        public readonly Vector4I8F24 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, X, Y); }
        public readonly Vector4I8F24 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Y, X); }
        public readonly Vector4I8F24 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, X, Y, Y); }
        public readonly Vector4I8F24 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, X, X); }
        public readonly Vector4I8F24 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, X, Y); }
        public readonly Vector4I8F24 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Y, X); }
        public readonly Vector4I8F24 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I8F24(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I8F24 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I8F24>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I8F24 other)
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
        public readonly Vector2I8F24 Half() => new Vector2I8F24(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I8F24 Twice() => new Vector2I8F24(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I8F24 Clamp(I8F24 min, I8F24 max) => new Vector2I8F24(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I8F24 Clamp(
            Vector2I8F24 min, Vector2I8F24 max
        ) => new Vector2I8F24(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I8F24 SaturatingAdd(Vector2I8F24 other) => new Vector2I8F24(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I8F24 SaturatingMul(I8F24 other) => new Vector2I8F24(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long DotInternal(Vector2I8F24 other) {
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
        public readonly I8F24 Dot(Vector2I8F24 other) {
            const long k = 1L << 22;
            return I8F24.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I8F24 SaturatingDot(Vector2I8F24 other) {
            const long k = 1L << 22;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I8F24.MaxValue;
            } else if (bits < int.MinValue) {
                return I8F24.MinValue;
            } else {
                return I8F24.FromBits((int)bits);
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
        public readonly I18F46 LengthSquared() {
            return I18F46.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly int LengthInternal() {
            var squared = LengthSquaredInternal();
            return (int)Mathi.Sqrt((ulong)squared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I8F24 LengthHalf() => I8F24.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I9F23 Length() => I9F23.FromBits(LengthInternal());

    }

    partial struct I8F24 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I8F24 SaturatingMul(Vector2I8F24 other) => other.SaturatingMul(this);
    }
}
