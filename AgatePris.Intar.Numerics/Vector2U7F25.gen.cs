using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U7F25 : IEquatable<Vector2U7F25>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U7F25 X;
        public U7F25 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25(U7F25 x, U7F25 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25(U7F25 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25(Vector2U7F25 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U7F25 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U7F25(U7F25.Zero);
        }
        public static Vector2U7F25 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U7F25(U7F25.One);
        }
        public static Vector2U7F25 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U7F25(U7F25.One, U7F25.Zero);
        }
        public static Vector2U7F25 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U7F25(U7F25.Zero, U7F25.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 operator +(Vector2U7F25 a, Vector2U7F25 b) => new Vector2U7F25(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 operator -(Vector2U7F25 a, Vector2U7F25 b) => new Vector2U7F25(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 operator *(Vector2U7F25 a, Vector2U7F25 b) => new Vector2U7F25(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 operator *(Vector2U7F25 a, U7F25 b) => new Vector2U7F25(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 operator *(U7F25 a, Vector2U7F25 b) => new Vector2U7F25(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 operator /(Vector2U7F25 a, Vector2U7F25 b) => new Vector2U7F25(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 operator /(Vector2U7F25 a, U7F25 b) => new Vector2U7F25(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U7F25 operator /(U7F25 a, Vector2U7F25 b) => new Vector2U7F25(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U7F25 lhs, Vector2U7F25 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U7F25 lhs, Vector2U7F25 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U7F25 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(X, X); }
        public Vector2U7F25 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(X, Y); }
        public Vector2U7F25 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(Y, X); }
        public Vector2U7F25 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U7F25(Y, Y); }
        public Vector3U7F25 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, X, X); }
        public Vector3U7F25 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, X, Y); }
        public Vector3U7F25 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, Y, X); }
        public Vector3U7F25 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(X, Y, Y); }
        public Vector3U7F25 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, X, X); }
        public Vector3U7F25 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, X, Y); }
        public Vector3U7F25 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, Y, X); }
        public Vector3U7F25 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U7F25(Y, Y, Y); }
        public Vector4U7F25 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, X, X); }
        public Vector4U7F25 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, X, Y); }
        public Vector4U7F25 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, Y, X); }
        public Vector4U7F25 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, X, Y, Y); }
        public Vector4U7F25 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, X, X); }
        public Vector4U7F25 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, X, Y); }
        public Vector4U7F25 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, Y, X); }
        public Vector4U7F25 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(X, Y, Y, Y); }
        public Vector4U7F25 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, X, X); }
        public Vector4U7F25 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, X, Y); }
        public Vector4U7F25 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, Y, X); }
        public Vector4U7F25 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, X, Y, Y); }
        public Vector4U7F25 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, X, X); }
        public Vector4U7F25 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, X, Y); }
        public Vector4U7F25 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, Y, X); }
        public Vector4U7F25 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U7F25(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector2U7F25 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U7F25>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2U7F25 other)
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
        public Vector2U7F25 Min(Vector2U7F25 other) => new Vector2U7F25(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25 Max(Vector2U7F25 other) => new Vector2U7F25(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25 Half() => new Vector2U7F25(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25 Twice() => new Vector2U7F25(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25 Clamp(U7F25 min, U7F25 max) => new Vector2U7F25(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25 Clamp(
            Vector2U7F25 min, Vector2U7F25 max
        ) => new Vector2U7F25(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25 WrappingAdd(Vector2U7F25 other) => new Vector2U7F25(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25 WrappingSub(Vector2U7F25 other) => new Vector2U7F25(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25 WrappingMul(Vector2U7F25 other) => new Vector2U7F25(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25 WrappingAddSigned(Vector2I7F25 other) => new Vector2U7F25(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25 SaturatingAdd(Vector2U7F25 other) => new Vector2U7F25(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25 SaturatingMul(U7F25 other) => new Vector2U7F25(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector2U7F25 other) {
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
        public U7F25 Dot(Vector2U7F25 other) {
            const ulong k = 1UL << 23;
            return U7F25.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U7F25 SaturatingDot(Vector2U7F25 other) {
            const ulong k = 1UL << 23;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U7F25.MaxValue;
            } else {
                return U7F25.FromBits((uint)bits);
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
        public U16F48 LengthSquared() {
            return U16F48.FromBits(LengthSquaredInternal());
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
        public U7F25 LengthHalf() => U7F25.FromBits(LengthInternal());

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
        public I7F25 LengthHalfSigned() => I7F25.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U8F24 Length() => U8F24.FromBits(LengthInternal());

    }

    partial struct U7F25 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U7F25 SaturatingMul(Vector2U7F25 other) => other.SaturatingMul(this);
    }
}
