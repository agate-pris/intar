using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U6F26 : IEquatable<Vector2U6F26>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U6F26 X;
        public U6F26 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26(U6F26 x, U6F26 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26(U6F26 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26(Vector2U6F26 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U6F26 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U6F26(U6F26.Zero);
        }
        public static Vector2U6F26 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U6F26(U6F26.One);
        }
        public static Vector2U6F26 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U6F26(U6F26.One, U6F26.Zero);
        }
        public static Vector2U6F26 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U6F26(U6F26.Zero, U6F26.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 operator +(Vector2U6F26 a, Vector2U6F26 b) => new Vector2U6F26(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 operator -(Vector2U6F26 a, Vector2U6F26 b) => new Vector2U6F26(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 operator *(Vector2U6F26 a, Vector2U6F26 b) => new Vector2U6F26(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 operator *(Vector2U6F26 a, U6F26 b) => new Vector2U6F26(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 operator *(U6F26 a, Vector2U6F26 b) => new Vector2U6F26(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 operator /(Vector2U6F26 a, Vector2U6F26 b) => new Vector2U6F26(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 operator /(Vector2U6F26 a, U6F26 b) => new Vector2U6F26(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U6F26 operator /(U6F26 a, Vector2U6F26 b) => new Vector2U6F26(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U6F26 lhs, Vector2U6F26 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U6F26 lhs, Vector2U6F26 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U6F26 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(X, X); }
        public Vector2U6F26 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(X, Y); }
        public Vector2U6F26 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(Y, X); }
        public Vector2U6F26 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U6F26(Y, Y); }
        public Vector3U6F26 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, X, X); }
        public Vector3U6F26 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, X, Y); }
        public Vector3U6F26 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, Y, X); }
        public Vector3U6F26 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(X, Y, Y); }
        public Vector3U6F26 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, X, X); }
        public Vector3U6F26 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, X, Y); }
        public Vector3U6F26 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, Y, X); }
        public Vector3U6F26 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U6F26(Y, Y, Y); }
        public Vector4U6F26 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, X, X); }
        public Vector4U6F26 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, X, Y); }
        public Vector4U6F26 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, Y, X); }
        public Vector4U6F26 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, X, Y, Y); }
        public Vector4U6F26 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, X, X); }
        public Vector4U6F26 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, X, Y); }
        public Vector4U6F26 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, Y, X); }
        public Vector4U6F26 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(X, Y, Y, Y); }
        public Vector4U6F26 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, X, X); }
        public Vector4U6F26 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, X, Y); }
        public Vector4U6F26 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, Y, X); }
        public Vector4U6F26 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, X, Y, Y); }
        public Vector4U6F26 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, X, X); }
        public Vector4U6F26 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, X, Y); }
        public Vector4U6F26 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, Y, X); }
        public Vector4U6F26 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U6F26(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector2U6F26 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U6F26>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2U6F26 other)
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
        public Vector2U6F26 Min(Vector2U6F26 other) => new Vector2U6F26(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26 Max(Vector2U6F26 other) => new Vector2U6F26(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26 Half() => new Vector2U6F26(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26 Twice() => new Vector2U6F26(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26 Clamp(U6F26 min, U6F26 max) => new Vector2U6F26(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26 Clamp(
            Vector2U6F26 min, Vector2U6F26 max
        ) => new Vector2U6F26(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26 WrappingAdd(Vector2U6F26 other) => new Vector2U6F26(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26 WrappingSub(Vector2U6F26 other) => new Vector2U6F26(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26 WrappingMul(Vector2U6F26 other) => new Vector2U6F26(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26 WrappingAddSigned(Vector2I6F26 other) => new Vector2U6F26(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26 SaturatingAdd(Vector2U6F26 other) => new Vector2U6F26(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26 SaturatingMul(U6F26 other) => new Vector2U6F26(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector2U6F26 other) {
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
        public U6F26 Dot(Vector2U6F26 other) {
            const ulong k = 1UL << 24;
            return U6F26.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U6F26 SaturatingDot(Vector2U6F26 other) {
            const ulong k = 1UL << 24;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U6F26.MaxValue;
            } else {
                return U6F26.FromBits((uint)bits);
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
        public U14F50 LengthSquared() {
            return U14F50.FromBits(LengthSquaredInternal());
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
        public U6F26 LengthHalf() => U6F26.FromBits(LengthInternal());

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
        public I6F26 LengthHalfSigned() => I6F26.FromBits(checked((int)LengthInternal()));

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
        public U7F25 Length() => U7F25.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// <para><see cref="Length">Length</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="Length">Length</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfSigned"/>
        /// <seealso cref="Length"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I7F25 LengthSigned() => I7F25.FromBits(checked((int)LengthInternal()));

    }

    partial struct U6F26 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U6F26 SaturatingMul(Vector2U6F26 other) => other.SaturatingMul(this);
    }
}
