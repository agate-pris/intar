using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I4F28
    : IEquatable<Vector2I4F28>
    , IFormattable
    , IVector<
        U10F54, I10F54,
        U5F27, I5F27
    > {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I4F28 X;
        public I4F28 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28(I4F28 x, I4F28 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28(I4F28 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28(Vector2I4F28 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I4F28 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I4F28(I4F28.Zero);
        }
        public static Vector2I4F28 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I4F28(I4F28.One);
        }
        public static Vector2I4F28 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I4F28(I4F28.One, I4F28.Zero);
        }
        public static Vector2I4F28 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I4F28(I4F28.Zero, I4F28.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 operator +(Vector2I4F28 a, Vector2I4F28 b) => new Vector2I4F28(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 operator -(Vector2I4F28 a, Vector2I4F28 b) => new Vector2I4F28(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 operator *(Vector2I4F28 a, Vector2I4F28 b) => new Vector2I4F28(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 operator *(Vector2I4F28 a, I4F28 b) => new Vector2I4F28(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 operator *(I4F28 a, Vector2I4F28 b) => new Vector2I4F28(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 operator /(Vector2I4F28 a, Vector2I4F28 b) => new Vector2I4F28(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 operator /(Vector2I4F28 a, I4F28 b) => new Vector2I4F28(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F28 operator /(I4F28 a, Vector2I4F28 b) => new Vector2I4F28(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I4F28 lhs, Vector2I4F28 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I4F28 lhs, Vector2I4F28 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I4F28 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(X, X); }
        public Vector2I4F28 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(X, Y); }
        public Vector2I4F28 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Y, X); }
        public Vector2I4F28 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I4F28(Y, Y); }
        public Vector3I4F28 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, X, X); }
        public Vector3I4F28 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, X, Y); }
        public Vector3I4F28 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Y, X); }
        public Vector3I4F28 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(X, Y, Y); }
        public Vector3I4F28 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, X, X); }
        public Vector3I4F28 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, X, Y); }
        public Vector3I4F28 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Y, X); }
        public Vector3I4F28 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I4F28(Y, Y, Y); }
        public Vector4I4F28 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, X, X); }
        public Vector4I4F28 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, X, Y); }
        public Vector4I4F28 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Y, X); }
        public Vector4I4F28 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, X, Y, Y); }
        public Vector4I4F28 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, X, X); }
        public Vector4I4F28 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, X, Y); }
        public Vector4I4F28 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Y, X); }
        public Vector4I4F28 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(X, Y, Y, Y); }
        public Vector4I4F28 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, X, X); }
        public Vector4I4F28 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, X, Y); }
        public Vector4I4F28 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Y, X); }
        public Vector4I4F28 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, X, Y, Y); }
        public Vector4I4F28 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, X, X); }
        public Vector4I4F28 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, X, Y); }
        public Vector4I4F28 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Y, X); }
        public Vector4I4F28 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I4F28(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector2I4F28 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I4F28>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2I4F28 other)
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
        public Vector2I4F28 Min(Vector2I4F28 other) => new Vector2I4F28(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28 Max(Vector2I4F28 other) => new Vector2I4F28(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28 Abs() => new Vector2I4F28(
            X.Abs(),
            Y.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28 Half() => new Vector2I4F28(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28 Twice() => new Vector2I4F28(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28 Clamp(I4F28 min, I4F28 max) => new Vector2I4F28(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28 Clamp(
            Vector2I4F28 min, Vector2I4F28 max
        ) => new Vector2I4F28(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28 WrappingAdd(Vector2I4F28 other) => new Vector2I4F28(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28 WrappingSub(Vector2I4F28 other) => new Vector2I4F28(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28 WrappingMul(Vector2I4F28 other) => new Vector2I4F28(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28 WrappingAddUnsigned(Vector2U4F28 other) => new Vector2I4F28(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28 WrappingSubUnsigned(Vector2U4F28 other) => new Vector2I4F28(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U4F28 UnsignedAbs() => new Vector2U4F28(
            X.UnsignedAbs(),
            Y.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28 SaturatingAdd(Vector2I4F28 other) => new Vector2I4F28(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28 SaturatingMul(I4F28 other) => new Vector2I4F28(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector2I4F28 other) {
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
        public I4F28 Dot(Vector2I4F28 other) {
            const long k = 1L << 26;
            return I4F28.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F28 SaturatingDot(Vector2I4F28 other) {
            const long k = 1L << 26;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I4F28.MaxValue;
            } else if (bits < int.MinValue) {
                return I4F28.MinValue;
            } else {
                return I4F28.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U10F54 LengthSquaredUnsigned() => U10F54.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I10F54 LengthSquaredSigned() => I10F54.FromBits(
            LengthSquaredInternal()
        );

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
        public I10F54 LengthSquared() => LengthSquaredSigned();

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
        public U4F28 LengthHalfUnsigned() => U4F28.FromBits(LengthInternal());

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
        public I4F28 LengthHalf() => I4F28.FromBits(checked((int)LengthInternal()));

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <see cref="LengthSigned">LengthSigned</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="LengthSigned">LengthSigned</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfUnsigned"/>
        /// <seealso cref="LengthSigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U5F27 LengthUnsigned() => U5F27.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="LengthUnsigned">LengthUnsigned</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthUnsigned">LengthUnsigned</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf"/>
        /// <seealso cref="LengthUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I5F27 LengthSigned() => I5F27.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I5F27 Length() => LengthSigned();

    }

    partial struct I4F28 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F28 SaturatingMul(Vector2I4F28 other) => other.SaturatingMul(this);
    }
}
