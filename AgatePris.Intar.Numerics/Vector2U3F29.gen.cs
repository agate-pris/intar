using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U3F29
    : IEquatable<Vector2U3F29>
    , IFormattable
    , IVector<
        U8F56, I8F56,
        U4F28, I4F28
    > {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U3F29 X;
        public U3F29 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U3F29(U3F29 x, U3F29 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U3F29(U3F29 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U3F29(Vector2U3F29 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U3F29 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U3F29(U3F29.Zero);
        }
        public static Vector2U3F29 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U3F29(U3F29.One);
        }
        public static Vector2U3F29 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U3F29(U3F29.One, U3F29.Zero);
        }
        public static Vector2U3F29 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U3F29(U3F29.Zero, U3F29.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 operator +(Vector2U3F29 a, Vector2U3F29 b) => new Vector2U3F29(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 operator -(Vector2U3F29 a, Vector2U3F29 b) => new Vector2U3F29(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 operator *(Vector2U3F29 a, Vector2U3F29 b) => new Vector2U3F29(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 operator *(Vector2U3F29 a, U3F29 b) => new Vector2U3F29(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 operator *(U3F29 a, Vector2U3F29 b) => new Vector2U3F29(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 operator /(Vector2U3F29 a, Vector2U3F29 b) => new Vector2U3F29(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 operator /(Vector2U3F29 a, U3F29 b) => new Vector2U3F29(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U3F29 operator /(U3F29 a, Vector2U3F29 b) => new Vector2U3F29(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U3F29 lhs, Vector2U3F29 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U3F29 lhs, Vector2U3F29 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U3F29 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(X, X); }
        public Vector2U3F29 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(X, Y); }
        public Vector2U3F29 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Y, X); }
        public Vector2U3F29 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U3F29(Y, Y); }
        public Vector3U3F29 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, X, X); }
        public Vector3U3F29 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, X, Y); }
        public Vector3U3F29 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Y, X); }
        public Vector3U3F29 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(X, Y, Y); }
        public Vector3U3F29 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, X, X); }
        public Vector3U3F29 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, X, Y); }
        public Vector3U3F29 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Y, X); }
        public Vector3U3F29 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U3F29(Y, Y, Y); }
        public Vector4U3F29 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, X, X); }
        public Vector4U3F29 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, X, Y); }
        public Vector4U3F29 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Y, X); }
        public Vector4U3F29 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, X, Y, Y); }
        public Vector4U3F29 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, X, X); }
        public Vector4U3F29 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, X, Y); }
        public Vector4U3F29 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Y, X); }
        public Vector4U3F29 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(X, Y, Y, Y); }
        public Vector4U3F29 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, X, X); }
        public Vector4U3F29 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, X, Y); }
        public Vector4U3F29 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Y, X); }
        public Vector4U3F29 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, X, Y, Y); }
        public Vector4U3F29 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, X, X); }
        public Vector4U3F29 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, X, Y); }
        public Vector4U3F29 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Y, X); }
        public Vector4U3F29 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U3F29(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector2U3F29 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U3F29>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2U3F29 other)
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
        public Vector2U3F29 Min(Vector2U3F29 other) => new Vector2U3F29(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U3F29 Max(Vector2U3F29 other) => new Vector2U3F29(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U3F29 Half() => new Vector2U3F29(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U3F29 Twice() => new Vector2U3F29(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U3F29 Clamp(U3F29 min, U3F29 max) => new Vector2U3F29(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U3F29 Clamp(
            Vector2U3F29 min, Vector2U3F29 max
        ) => new Vector2U3F29(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U3F29 WrappingAdd(Vector2U3F29 other) => new Vector2U3F29(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U3F29 WrappingSub(Vector2U3F29 other) => new Vector2U3F29(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U3F29 WrappingMul(Vector2U3F29 other) => new Vector2U3F29(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U3F29 WrappingAddSigned(Vector2I3F29 other) => new Vector2U3F29(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U3F29 SaturatingAdd(Vector2U3F29 other) => new Vector2U3F29(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U3F29 SaturatingMul(U3F29 other) => new Vector2U3F29(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector2U3F29 other) {
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
        public U3F29 Dot(Vector2U3F29 other) {
            const ulong k = 1UL << 27;
            return U3F29.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U3F29 SaturatingDot(Vector2U3F29 other) {
            const ulong k = 1UL << 27;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U3F29.MaxValue;
            } else {
                return U3F29.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U8F56 LengthSquaredUnsigned() => U8F56.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I8F56 LengthSquaredSigned() => I8F56.FromBits(
            (long)LengthSquaredInternal()
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
        public U8F56 LengthSquared() => LengthSquaredUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint LengthInternal() {
            return (uint)Mathi.Sqrt(LengthSquaredInternal());
        }

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <see cref="LengthHalfSigned">LengthHalfSigned</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="LengthHalfSigned">LengthHalfSigned</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfSigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U3F29 LengthHalf() => U3F29.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="LengthHalf">LengthHalf</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthHalf">LengthHalf</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I3F29 LengthHalfSigned() => I3F29.FromBits(checked((int)LengthInternal()));

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
        /// <seealso cref="LengthHalf"/>
        /// <seealso cref="LengthSigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F28 LengthUnsigned() => U4F28.FromBits(LengthInternal());

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
        /// <seealso cref="LengthHalfSigned"/>
        /// <seealso cref="LengthUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F28 LengthSigned() => I4F28.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F28 Length() => LengthUnsigned();

    }

    partial struct U3F29 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U3F29 SaturatingMul(Vector2U3F29 other) => other.SaturatingMul(this);
    }
}
