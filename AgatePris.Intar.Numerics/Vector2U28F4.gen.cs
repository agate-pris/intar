using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U28F4 : IEquatable<Vector2U28F4>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U28F4 X;
        public U28F4 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4(U28F4 x, U28F4 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4(U28F4 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4(Vector2U28F4 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U28F4 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U28F4(U28F4.Zero);
        }
        public static Vector2U28F4 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U28F4(U28F4.One);
        }
        public static Vector2U28F4 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U28F4(U28F4.One, U28F4.Zero);
        }
        public static Vector2U28F4 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U28F4(U28F4.Zero, U28F4.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 operator +(Vector2U28F4 a, Vector2U28F4 b) => new Vector2U28F4(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 operator -(Vector2U28F4 a, Vector2U28F4 b) => new Vector2U28F4(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 operator *(Vector2U28F4 a, Vector2U28F4 b) => new Vector2U28F4(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 operator *(Vector2U28F4 a, U28F4 b) => new Vector2U28F4(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 operator *(U28F4 a, Vector2U28F4 b) => new Vector2U28F4(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 operator /(Vector2U28F4 a, Vector2U28F4 b) => new Vector2U28F4(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 operator /(Vector2U28F4 a, U28F4 b) => new Vector2U28F4(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U28F4 operator /(U28F4 a, Vector2U28F4 b) => new Vector2U28F4(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U28F4 lhs, Vector2U28F4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U28F4 lhs, Vector2U28F4 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U28F4 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(X, X); }
        public Vector2U28F4 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(X, Y); }
        public Vector2U28F4 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Y, X); }
        public Vector2U28F4 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U28F4(Y, Y); }
        public Vector3U28F4 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, X, X); }
        public Vector3U28F4 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, X, Y); }
        public Vector3U28F4 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Y, X); }
        public Vector3U28F4 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(X, Y, Y); }
        public Vector3U28F4 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, X, X); }
        public Vector3U28F4 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, X, Y); }
        public Vector3U28F4 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Y, X); }
        public Vector3U28F4 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U28F4(Y, Y, Y); }
        public Vector4U28F4 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, X, X); }
        public Vector4U28F4 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, X, Y); }
        public Vector4U28F4 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Y, X); }
        public Vector4U28F4 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, X, Y, Y); }
        public Vector4U28F4 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, X, X); }
        public Vector4U28F4 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, X, Y); }
        public Vector4U28F4 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Y, X); }
        public Vector4U28F4 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(X, Y, Y, Y); }
        public Vector4U28F4 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, X, X); }
        public Vector4U28F4 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, X, Y); }
        public Vector4U28F4 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Y, X); }
        public Vector4U28F4 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, X, Y, Y); }
        public Vector4U28F4 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, X, X); }
        public Vector4U28F4 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, X, Y); }
        public Vector4U28F4 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Y, X); }
        public Vector4U28F4 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U28F4(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector2U28F4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U28F4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2U28F4 other)
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
        public Vector2U28F4 Min(Vector2U28F4 other) => new Vector2U28F4(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4 Max(Vector2U28F4 other) => new Vector2U28F4(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4 Half() => new Vector2U28F4(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4 Twice() => new Vector2U28F4(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4 Clamp(U28F4 min, U28F4 max) => new Vector2U28F4(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4 Clamp(
            Vector2U28F4 min, Vector2U28F4 max
        ) => new Vector2U28F4(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4 WrappingAdd(Vector2U28F4 other) => new Vector2U28F4(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4 WrappingSub(Vector2U28F4 other) => new Vector2U28F4(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4 WrappingMul(Vector2U28F4 other) => new Vector2U28F4(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4 WrappingAddSigned(Vector2I28F4 other) => new Vector2U28F4(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4 SaturatingAdd(Vector2U28F4 other) => new Vector2U28F4(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4 SaturatingMul(U28F4 other) => new Vector2U28F4(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector2U28F4 other) {
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
        public U28F4 Dot(Vector2U28F4 other) {
            const ulong k = 1UL << 2;
            return U28F4.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U28F4 SaturatingDot(Vector2U28F4 other) {
            const ulong k = 1UL << 2;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U28F4.MaxValue;
            } else {
                return U28F4.FromBits((uint)bits);
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
        public U58F6 LengthSquared() {
            return U58F6.FromBits(LengthSquaredInternal());
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
        public U28F4 LengthHalf() => U28F4.FromBits(LengthInternal());

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
        public I28F4 LengthHalfSigned() => I28F4.FromBits(checked((int)LengthInternal()));

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <c>LengthSigned</c> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <c>LengthSigned</c> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U29F3 Length() => U29F3.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// <para><c>Length</c> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><c>Length</c> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I29F3 LengthSigned() => I29F3.FromBits(checked((int)LengthInternal()));

    }

    partial struct U28F4 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4 SaturatingMul(Vector2U28F4 other) => other.SaturatingMul(this);
    }
}
