using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U8F24 : IEquatable<Vector2U8F24>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U8F24 X;
        public U8F24 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U8F24(U8F24 x, U8F24 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U8F24(U8F24 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U8F24(Vector2U8F24 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U8F24 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U8F24(U8F24.Zero);
        }
        public static Vector2U8F24 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U8F24(U8F24.One);
        }
        public static Vector2U8F24 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U8F24(U8F24.One, U8F24.Zero);
        }
        public static Vector2U8F24 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U8F24(U8F24.Zero, U8F24.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 operator +(Vector2U8F24 a, Vector2U8F24 b) => new Vector2U8F24(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 operator -(Vector2U8F24 a, Vector2U8F24 b) => new Vector2U8F24(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 operator *(Vector2U8F24 a, Vector2U8F24 b) => new Vector2U8F24(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 operator *(Vector2U8F24 a, U8F24 b) => new Vector2U8F24(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 operator *(U8F24 a, Vector2U8F24 b) => new Vector2U8F24(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 operator /(Vector2U8F24 a, Vector2U8F24 b) => new Vector2U8F24(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 operator /(Vector2U8F24 a, U8F24 b) => new Vector2U8F24(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U8F24 operator /(U8F24 a, Vector2U8F24 b) => new Vector2U8F24(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U8F24 lhs, Vector2U8F24 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U8F24 lhs, Vector2U8F24 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U8F24 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(X, X); }
        public Vector2U8F24 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(X, Y); }
        public Vector2U8F24 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(Y, X); }
        public Vector2U8F24 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U8F24(Y, Y); }
        public Vector3U8F24 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, X, X); }
        public Vector3U8F24 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, X, Y); }
        public Vector3U8F24 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, Y, X); }
        public Vector3U8F24 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(X, Y, Y); }
        public Vector3U8F24 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, X, X); }
        public Vector3U8F24 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, X, Y); }
        public Vector3U8F24 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, Y, X); }
        public Vector3U8F24 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U8F24(Y, Y, Y); }
        public Vector4U8F24 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, X, X); }
        public Vector4U8F24 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, X, Y); }
        public Vector4U8F24 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, Y, X); }
        public Vector4U8F24 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, X, Y, Y); }
        public Vector4U8F24 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, X, X); }
        public Vector4U8F24 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, X, Y); }
        public Vector4U8F24 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, Y, X); }
        public Vector4U8F24 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(X, Y, Y, Y); }
        public Vector4U8F24 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, X, X); }
        public Vector4U8F24 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, X, Y); }
        public Vector4U8F24 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, Y, X); }
        public Vector4U8F24 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, X, Y, Y); }
        public Vector4U8F24 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, X, X); }
        public Vector4U8F24 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, X, Y); }
        public Vector4U8F24 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, Y, X); }
        public Vector4U8F24 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U8F24(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector2U8F24 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U8F24>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2U8F24 other)
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
        public Vector2U8F24 Min(Vector2U8F24 other) => new Vector2U8F24(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U8F24 Max(Vector2U8F24 other) => new Vector2U8F24(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U8F24 Half() => new Vector2U8F24(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U8F24 Twice() => new Vector2U8F24(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U8F24 Clamp(U8F24 min, U8F24 max) => new Vector2U8F24(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U8F24 Clamp(
            Vector2U8F24 min, Vector2U8F24 max
        ) => new Vector2U8F24(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U8F24 WrappingAdd(Vector2U8F24 other) => new Vector2U8F24(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U8F24 WrappingSub(Vector2U8F24 other) => new Vector2U8F24(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U8F24 WrappingMul(Vector2U8F24 other) => new Vector2U8F24(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U8F24 WrappingAddSigned(Vector2I8F24 other) => new Vector2U8F24(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U8F24 SaturatingAdd(Vector2U8F24 other) => new Vector2U8F24(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U8F24 SaturatingMul(U8F24 other) => new Vector2U8F24(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector2U8F24 other) {
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
        public U8F24 Dot(Vector2U8F24 other) {
            const ulong k = 1UL << 22;
            return U8F24.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U8F24 SaturatingDot(Vector2U8F24 other) {
            const ulong k = 1UL << 22;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U8F24.MaxValue;
            } else {
                return U8F24.FromBits((uint)bits);
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
        public U18F46 LengthSquared() {
            return U18F46.FromBits(LengthSquaredInternal());
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
        public U8F24 LengthHalf() => U8F24.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外をスローします｡</para>
        /// <para><see cref="LengthHalf">LengthHalf</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthHalf">LengthHalf</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I8F24 LengthHalfSigned() => I8F24.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U9F23 Length() => U9F23.FromBits(LengthInternal());

    }

    partial struct U8F24 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U8F24 SaturatingMul(Vector2U8F24 other) => other.SaturatingMul(this);
    }
}
