using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I12F20 : IEquatable<Vector2I12F20>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I12F20 X;
        public I12F20 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I12F20(I12F20 x, I12F20 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I12F20(I12F20 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I12F20(Vector2I12F20 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I12F20 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I12F20(I12F20.Zero);
        }
        public static Vector2I12F20 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I12F20(I12F20.One);
        }
        public static Vector2I12F20 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I12F20(I12F20.One, I12F20.Zero);
        }
        public static Vector2I12F20 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I12F20(I12F20.Zero, I12F20.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 operator +(Vector2I12F20 a, Vector2I12F20 b) => new Vector2I12F20(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 operator -(Vector2I12F20 a, Vector2I12F20 b) => new Vector2I12F20(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 operator *(Vector2I12F20 a, Vector2I12F20 b) => new Vector2I12F20(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 operator *(Vector2I12F20 a, I12F20 b) => new Vector2I12F20(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 operator *(I12F20 a, Vector2I12F20 b) => new Vector2I12F20(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 operator /(Vector2I12F20 a, Vector2I12F20 b) => new Vector2I12F20(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 operator /(Vector2I12F20 a, I12F20 b) => new Vector2I12F20(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I12F20 operator /(I12F20 a, Vector2I12F20 b) => new Vector2I12F20(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I12F20 lhs, Vector2I12F20 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I12F20 lhs, Vector2I12F20 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public readonly Vector2I12F20 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(X, X); }
        public readonly Vector2I12F20 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(X, Y); }
        public readonly Vector2I12F20 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Y, X); }
        public readonly Vector2I12F20 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Y, Y); }
        public readonly Vector3I12F20 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, X, X); }
        public readonly Vector3I12F20 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, X, Y); }
        public readonly Vector3I12F20 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Y, X); }
        public readonly Vector3I12F20 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Y, Y); }
        public readonly Vector3I12F20 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, X, X); }
        public readonly Vector3I12F20 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, X, Y); }
        public readonly Vector3I12F20 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Y, X); }
        public readonly Vector3I12F20 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Y, Y); }
        public readonly Vector4I12F20 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, X, X); }
        public readonly Vector4I12F20 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, X, Y); }
        public readonly Vector4I12F20 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Y, X); }
        public readonly Vector4I12F20 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Y, Y); }
        public readonly Vector4I12F20 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, X, X); }
        public readonly Vector4I12F20 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, X, Y); }
        public readonly Vector4I12F20 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Y, X); }
        public readonly Vector4I12F20 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Y, Y); }
        public readonly Vector4I12F20 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, X, X); }
        public readonly Vector4I12F20 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, X, Y); }
        public readonly Vector4I12F20 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Y, X); }
        public readonly Vector4I12F20 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Y, Y); }
        public readonly Vector4I12F20 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, X, X); }
        public readonly Vector4I12F20 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, X, Y); }
        public readonly Vector4I12F20 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Y, X); }
        public readonly Vector4I12F20 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override readonly bool Equals(object obj) => obj is Vector2I12F20 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I12F20>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Vector2I12F20 other)
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
        public readonly Vector2I12F20 Half() => new Vector2I12F20(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I12F20 Twice() => new Vector2I12F20(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I12F20 Clamp(I12F20 min, I12F20 max) => new Vector2I12F20(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I12F20 Clamp(
            Vector2I12F20 min, Vector2I12F20 max
        ) => new Vector2I12F20(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I12F20 SaturatingAdd(Vector2I12F20 other) => new Vector2I12F20(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I12F20 SaturatingMul(I12F20 other) => new Vector2I12F20(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly long DotInternal(Vector2I12F20 other) {
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
        public readonly I12F20 Dot(Vector2I12F20 other) {
            const long k = 1L << 18;
            return I12F20.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I12F20 SaturatingDot(Vector2I12F20 other) {
            const long k = 1L << 18;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I12F20.MaxValue;
            } else if (bits < int.MinValue) {
                return I12F20.MinValue;
            } else {
                return I12F20.FromBits((int)bits);
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
        public readonly I26F38 LengthSquared() {
            return I26F38.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly int LengthInternal() {
            var squared = LengthSquaredInternal();
            return (int)Mathi.Sqrt((ulong)squared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I12F20 LengthHalf() => I12F20.FromBits(LengthInternal());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly I13F19 Length() => I13F19.FromBits(LengthInternal());

    }

    partial struct I12F20 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Vector2I12F20 SaturatingMul(Vector2I12F20 other) => other.SaturatingMul(this);
    }
}
