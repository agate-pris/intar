using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U20F12 : IEquatable<Vector2U20F12>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U20F12 X;
        public U20F12 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U20F12(U20F12 x, U20F12 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U20F12(U20F12 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U20F12(Vector2U20F12 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U20F12 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U20F12(U20F12.Zero);
        }
        public static Vector2U20F12 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U20F12(U20F12.One);
        }
        public static Vector2U20F12 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U20F12(U20F12.One, U20F12.Zero);
        }
        public static Vector2U20F12 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U20F12(U20F12.Zero, U20F12.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 operator +(Vector2U20F12 a, Vector2U20F12 b) => new Vector2U20F12(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 operator -(Vector2U20F12 a, Vector2U20F12 b) => new Vector2U20F12(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 operator *(Vector2U20F12 a, Vector2U20F12 b) => new Vector2U20F12(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 operator *(Vector2U20F12 a, U20F12 b) => new Vector2U20F12(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 operator *(U20F12 a, Vector2U20F12 b) => new Vector2U20F12(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 operator /(Vector2U20F12 a, Vector2U20F12 b) => new Vector2U20F12(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 operator /(Vector2U20F12 a, U20F12 b) => new Vector2U20F12(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U20F12 operator /(U20F12 a, Vector2U20F12 b) => new Vector2U20F12(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U20F12 lhs, Vector2U20F12 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U20F12 lhs, Vector2U20F12 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U20F12 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(X, X); }
        public Vector2U20F12 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(X, Y); }
        public Vector2U20F12 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(Y, X); }
        public Vector2U20F12 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U20F12(Y, Y); }
        public Vector3U20F12 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, X, X); }
        public Vector3U20F12 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, X, Y); }
        public Vector3U20F12 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, Y, X); }
        public Vector3U20F12 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(X, Y, Y); }
        public Vector3U20F12 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, X, X); }
        public Vector3U20F12 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, X, Y); }
        public Vector3U20F12 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, Y, X); }
        public Vector3U20F12 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U20F12(Y, Y, Y); }
        public Vector4U20F12 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, X, X); }
        public Vector4U20F12 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, X, Y); }
        public Vector4U20F12 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, Y, X); }
        public Vector4U20F12 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, X, Y, Y); }
        public Vector4U20F12 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, X, X); }
        public Vector4U20F12 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, X, Y); }
        public Vector4U20F12 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, Y, X); }
        public Vector4U20F12 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(X, Y, Y, Y); }
        public Vector4U20F12 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, X, X); }
        public Vector4U20F12 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, X, Y); }
        public Vector4U20F12 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, Y, X); }
        public Vector4U20F12 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, X, Y, Y); }
        public Vector4U20F12 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, X, X); }
        public Vector4U20F12 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, X, Y); }
        public Vector4U20F12 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, Y, X); }
        public Vector4U20F12 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U20F12(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector2U20F12 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U20F12>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2U20F12 other)
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
        public Vector2U20F12 Min(Vector2U20F12 other) => new Vector2U20F12(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U20F12 Max(Vector2U20F12 other) => new Vector2U20F12(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U20F12 Half() => new Vector2U20F12(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U20F12 Twice() => new Vector2U20F12(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U20F12 Clamp(U20F12 min, U20F12 max) => new Vector2U20F12(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U20F12 Clamp(
            Vector2U20F12 min, Vector2U20F12 max
        ) => new Vector2U20F12(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U20F12 WrappingAdd(Vector2U20F12 other) => new Vector2U20F12(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U20F12 WrappingSub(Vector2U20F12 other) => new Vector2U20F12(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U20F12 WrappingMul(Vector2U20F12 other) => new Vector2U20F12(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U20F12 WrappingAddSigned(Vector2I20F12 other) => new Vector2U20F12(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U20F12 SaturatingAdd(Vector2U20F12 other) => new Vector2U20F12(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U20F12 SaturatingMul(U20F12 other) => new Vector2U20F12(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector2U20F12 other) {
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
        public U20F12 Dot(Vector2U20F12 other) {
            const ulong k = 1UL << 10;
            return U20F12.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U20F12 SaturatingDot(Vector2U20F12 other) {
            const ulong k = 1UL << 10;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U20F12.MaxValue;
            } else {
                return U20F12.FromBits((uint)bits);
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
        public U42F22 LengthSquared() {
            return U42F22.FromBits(LengthSquaredInternal());
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
        public U20F12 LengthHalf() => U20F12.FromBits(LengthInternal());

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
        public I20F12 LengthHalfSigned() => I20F12.FromBits(checked((int)LengthInternal()));

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
        public U21F11 Length() => U21F11.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
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
        public I21F11 LengthSigned() => I21F11.FromBits(checked((int)LengthInternal()));

    }

    partial struct U20F12 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U20F12 SaturatingMul(Vector2U20F12 other) => other.SaturatingMul(this);
    }
}
