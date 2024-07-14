using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I13F19 : IEquatable<Vector2I13F19>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I13F19 X;
        public I13F19 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19(I13F19 x, I13F19 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19(I13F19 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19(Vector2I13F19 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I13F19 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I13F19(I13F19.Zero);
        }
        public static Vector2I13F19 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I13F19(I13F19.One);
        }
        public static Vector2I13F19 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I13F19(I13F19.One, I13F19.Zero);
        }
        public static Vector2I13F19 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I13F19(I13F19.Zero, I13F19.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 operator +(Vector2I13F19 a, Vector2I13F19 b) => new Vector2I13F19(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 operator -(Vector2I13F19 a, Vector2I13F19 b) => new Vector2I13F19(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 operator *(Vector2I13F19 a, Vector2I13F19 b) => new Vector2I13F19(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 operator *(Vector2I13F19 a, I13F19 b) => new Vector2I13F19(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 operator *(I13F19 a, Vector2I13F19 b) => new Vector2I13F19(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 operator /(Vector2I13F19 a, Vector2I13F19 b) => new Vector2I13F19(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 operator /(Vector2I13F19 a, I13F19 b) => new Vector2I13F19(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I13F19 operator /(I13F19 a, Vector2I13F19 b) => new Vector2I13F19(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I13F19 lhs, Vector2I13F19 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I13F19 lhs, Vector2I13F19 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I13F19 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(X, X); }
        public Vector2I13F19 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(X, Y); }
        public Vector2I13F19 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(Y, X); }
        public Vector2I13F19 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I13F19(Y, Y); }
        public Vector3I13F19 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, X, X); }
        public Vector3I13F19 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, X, Y); }
        public Vector3I13F19 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, Y, X); }
        public Vector3I13F19 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(X, Y, Y); }
        public Vector3I13F19 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, X, X); }
        public Vector3I13F19 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, X, Y); }
        public Vector3I13F19 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, Y, X); }
        public Vector3I13F19 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I13F19(Y, Y, Y); }
        public Vector4I13F19 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, X, X); }
        public Vector4I13F19 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, X, Y); }
        public Vector4I13F19 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, Y, X); }
        public Vector4I13F19 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, X, Y, Y); }
        public Vector4I13F19 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, X, X); }
        public Vector4I13F19 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, X, Y); }
        public Vector4I13F19 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, Y, X); }
        public Vector4I13F19 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(X, Y, Y, Y); }
        public Vector4I13F19 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, X, X); }
        public Vector4I13F19 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, X, Y); }
        public Vector4I13F19 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, Y, X); }
        public Vector4I13F19 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, X, Y, Y); }
        public Vector4I13F19 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, X, X); }
        public Vector4I13F19 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, X, Y); }
        public Vector4I13F19 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, Y, X); }
        public Vector4I13F19 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I13F19(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector2I13F19 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I13F19>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2I13F19 other)
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
        public Vector2I13F19 Min(Vector2I13F19 other) => new Vector2I13F19(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19 Max(Vector2I13F19 other) => new Vector2I13F19(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19 Abs() => new Vector2I13F19(
            X.Abs(),
            Y.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19 Half() => new Vector2I13F19(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19 Twice() => new Vector2I13F19(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19 Clamp(I13F19 min, I13F19 max) => new Vector2I13F19(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19 Clamp(
            Vector2I13F19 min, Vector2I13F19 max
        ) => new Vector2I13F19(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19 WrappingAdd(Vector2I13F19 other) => new Vector2I13F19(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19 WrappingSub(Vector2I13F19 other) => new Vector2I13F19(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19 WrappingMul(Vector2I13F19 other) => new Vector2I13F19(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19 WrappingAddUnsigned(Vector2U13F19 other) => new Vector2I13F19(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19 WrappingSubUnsigned(Vector2U13F19 other) => new Vector2I13F19(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U13F19 UnsignedAbs() => new Vector2U13F19(
            X.UnsignedAbs(),
            Y.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19 SaturatingAdd(Vector2I13F19 other) => new Vector2I13F19(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19 SaturatingMul(I13F19 other) => new Vector2I13F19(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector2I13F19 other) {
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
        public I13F19 Dot(Vector2I13F19 other) {
            const long k = 1L << 17;
            return I13F19.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I13F19 SaturatingDot(Vector2I13F19 other) {
            const long k = 1L << 17;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I13F19.MaxValue;
            } else if (bits < int.MinValue) {
                return I13F19.MinValue;
            } else {
                return I13F19.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        /// <remarks>
        /// <div class="TIP alert alert-info">
        /// <h5>Tip</h5>
        /// <para>This method divides the square of each element by 4
        /// during the calculation to prevent overflow.</para>
        /// <para>このメソッドはオーバーフローを防ぐため､
        /// 計算の過程で各要素の 2 乗を 4 で除算します｡
        /// そのため､ 精度が犠牲になっています｡
        /// また､ 戻り値の型もそれに準じて小数部が 2 ビット小さい型になっています｡</para>
        /// </div>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I28F36 LengthSquared() {
            return I28F36.FromBits(LengthSquaredInternal());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint LengthInternal() {
            var squared = LengthSquaredInternal();
            return (uint)Mathi.Sqrt((ulong)squared);
        }

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <see cref="LengthHalf">LengthHalf</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="LengthHalf">LengthHalf</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U13F19 LengthHalfUnsigned() => U13F19.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="LengthHalfUnsigned">LengthHalfUnsigned</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthHalfUnsigned">LengthHalfUnsigned</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I13F19 LengthHalf() => I13F19.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I14F18 Length() => I14F18.FromBits((int)LengthInternal());

    }

    partial struct I13F19 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I13F19 SaturatingMul(Vector2I13F19 other) => other.SaturatingMul(this);
    }
}
