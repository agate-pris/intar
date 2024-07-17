using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U9F23 : IEquatable<Vector2U9F23>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U9F23 X;
        public U9F23 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23(U9F23 x, U9F23 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23(U9F23 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23(Vector2U9F23 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U9F23 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U9F23(U9F23.Zero);
        }
        public static Vector2U9F23 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U9F23(U9F23.One);
        }
        public static Vector2U9F23 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U9F23(U9F23.One, U9F23.Zero);
        }
        public static Vector2U9F23 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U9F23(U9F23.Zero, U9F23.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator +(Vector2U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator -(Vector2U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator *(Vector2U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator *(Vector2U9F23 a, U9F23 b) => new Vector2U9F23(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator *(U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator /(Vector2U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator /(Vector2U9F23 a, U9F23 b) => new Vector2U9F23(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U9F23 operator /(U9F23 a, Vector2U9F23 b) => new Vector2U9F23(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U9F23 lhs, Vector2U9F23 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U9F23 lhs, Vector2U9F23 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U9F23 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(X, X); }
        public Vector2U9F23 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(X, Y); }
        public Vector2U9F23 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Y, X); }
        public Vector2U9F23 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U9F23(Y, Y); }
        public Vector3U9F23 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, X, X); }
        public Vector3U9F23 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, X, Y); }
        public Vector3U9F23 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Y, X); }
        public Vector3U9F23 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(X, Y, Y); }
        public Vector3U9F23 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, X, X); }
        public Vector3U9F23 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, X, Y); }
        public Vector3U9F23 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Y, X); }
        public Vector3U9F23 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U9F23(Y, Y, Y); }
        public Vector4U9F23 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, X, X); }
        public Vector4U9F23 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, X, Y); }
        public Vector4U9F23 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Y, X); }
        public Vector4U9F23 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, X, Y, Y); }
        public Vector4U9F23 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, X, X); }
        public Vector4U9F23 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, X, Y); }
        public Vector4U9F23 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Y, X); }
        public Vector4U9F23 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(X, Y, Y, Y); }
        public Vector4U9F23 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, X, X); }
        public Vector4U9F23 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, X, Y); }
        public Vector4U9F23 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Y, X); }
        public Vector4U9F23 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, X, Y, Y); }
        public Vector4U9F23 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, X, X); }
        public Vector4U9F23 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, X, Y); }
        public Vector4U9F23 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Y, X); }
        public Vector4U9F23 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U9F23(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector2U9F23 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U9F23>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2U9F23 other)
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
        public Vector2U9F23 Min(Vector2U9F23 other) => new Vector2U9F23(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23 Max(Vector2U9F23 other) => new Vector2U9F23(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23 Half() => new Vector2U9F23(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23 Twice() => new Vector2U9F23(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23 Clamp(U9F23 min, U9F23 max) => new Vector2U9F23(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23 Clamp(
            Vector2U9F23 min, Vector2U9F23 max
        ) => new Vector2U9F23(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23 WrappingAdd(Vector2U9F23 other) => new Vector2U9F23(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23 WrappingSub(Vector2U9F23 other) => new Vector2U9F23(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23 WrappingMul(Vector2U9F23 other) => new Vector2U9F23(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23 WrappingAddSigned(Vector2I9F23 other) => new Vector2U9F23(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23 SaturatingAdd(Vector2U9F23 other) => new Vector2U9F23(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23 SaturatingMul(U9F23 other) => new Vector2U9F23(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector2U9F23 other) {
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
        public U9F23 Dot(Vector2U9F23 other) {
            const ulong k = 1UL << 21;
            return U9F23.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U9F23 SaturatingDot(Vector2U9F23 other) {
            const ulong k = 1UL << 21;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U9F23.MaxValue;
            } else {
                return U9F23.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U20F44 LengthSquaredUnsigned() => U20F44.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I20F44 LengthSquaredSigned() => I20F44.FromBits(
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
        public U20F44 LengthSquared() => LengthSquaredUnsigned();

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
        public U9F23 LengthHalf() => U9F23.FromBits(LengthInternal());

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
        public I9F23 LengthHalfSigned() => I9F23.FromBits(checked((int)LengthInternal()));

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
        public U10F22 LengthUnsigned() => U10F22.FromBits(LengthInternal());

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
        public I10F22 LengthSigned() => I10F22.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U10F22 Length() => LengthUnsigned();

    }

    partial struct U9F23 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U9F23 SaturatingMul(Vector2U9F23 other) => other.SaturatingMul(this);
    }
}
