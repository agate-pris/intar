using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U14F18 : IEquatable<Vector2U14F18>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U14F18 X;
        public U14F18 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18(U14F18 x, U14F18 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18(U14F18 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18(Vector2U14F18 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U14F18 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U14F18(U14F18.Zero);
        }
        public static Vector2U14F18 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U14F18(U14F18.One);
        }
        public static Vector2U14F18 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U14F18(U14F18.One, U14F18.Zero);
        }
        public static Vector2U14F18 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U14F18(U14F18.Zero, U14F18.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator +(Vector2U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator -(Vector2U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator *(Vector2U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator *(Vector2U14F18 a, U14F18 b) => new Vector2U14F18(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator *(U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator /(Vector2U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator /(Vector2U14F18 a, U14F18 b) => new Vector2U14F18(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U14F18 operator /(U14F18 a, Vector2U14F18 b) => new Vector2U14F18(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U14F18 lhs, Vector2U14F18 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U14F18 lhs, Vector2U14F18 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U14F18 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(X, X); }
        public Vector2U14F18 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(X, Y); }
        public Vector2U14F18 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(Y, X); }
        public Vector2U14F18 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U14F18(Y, Y); }
        public Vector3U14F18 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, X, X); }
        public Vector3U14F18 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, X, Y); }
        public Vector3U14F18 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, Y, X); }
        public Vector3U14F18 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(X, Y, Y); }
        public Vector3U14F18 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, X, X); }
        public Vector3U14F18 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, X, Y); }
        public Vector3U14F18 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, Y, X); }
        public Vector3U14F18 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U14F18(Y, Y, Y); }
        public Vector4U14F18 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, X, X); }
        public Vector4U14F18 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, X, Y); }
        public Vector4U14F18 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, Y, X); }
        public Vector4U14F18 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, X, Y, Y); }
        public Vector4U14F18 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, X, X); }
        public Vector4U14F18 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, X, Y); }
        public Vector4U14F18 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, Y, X); }
        public Vector4U14F18 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(X, Y, Y, Y); }
        public Vector4U14F18 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, X, X); }
        public Vector4U14F18 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, X, Y); }
        public Vector4U14F18 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, Y, X); }
        public Vector4U14F18 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, X, Y, Y); }
        public Vector4U14F18 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, X, X); }
        public Vector4U14F18 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, X, Y); }
        public Vector4U14F18 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, Y, X); }
        public Vector4U14F18 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U14F18(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector2U14F18 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U14F18>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2U14F18 other)
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
        public Vector2U14F18 Min(Vector2U14F18 other) => new Vector2U14F18(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18 Max(Vector2U14F18 other) => new Vector2U14F18(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18 Half() => new Vector2U14F18(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18 Twice() => new Vector2U14F18(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18 Clamp(U14F18 min, U14F18 max) => new Vector2U14F18(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18 Clamp(
            Vector2U14F18 min, Vector2U14F18 max
        ) => new Vector2U14F18(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18 WrappingAdd(Vector2U14F18 other) => new Vector2U14F18(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18 WrappingSub(Vector2U14F18 other) => new Vector2U14F18(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18 WrappingMul(Vector2U14F18 other) => new Vector2U14F18(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18 WrappingAddSigned(Vector2I14F18 other) => new Vector2U14F18(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18 SaturatingAdd(Vector2U14F18 other) => new Vector2U14F18(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18 SaturatingMul(U14F18 other) => new Vector2U14F18(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector2U14F18 other) {
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
        public U14F18 Dot(Vector2U14F18 other) {
            const ulong k = 1UL << 16;
            return U14F18.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U14F18 SaturatingDot(Vector2U14F18 other) {
            const ulong k = 1UL << 16;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U14F18.MaxValue;
            } else {
                return U14F18.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

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
        public U30F34 LengthSquared() {
            return U30F34.FromBits(LengthSquaredInternal());
        }

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
        public U14F18 LengthHalf() => U14F18.FromBits(LengthInternal());

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
        public I14F18 LengthHalfSigned() => I14F18.FromBits(checked((int)LengthInternal()));

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
        public U15F17 LengthUnsigned() => U15F17.FromBits(LengthInternal());

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
        public I15F17 LengthSigned() => I15F17.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U15F17 Length() => LengthUnsigned();

    }

    partial struct U14F18 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U14F18 SaturatingMul(Vector2U14F18 other) => other.SaturatingMul(this);
    }
}
