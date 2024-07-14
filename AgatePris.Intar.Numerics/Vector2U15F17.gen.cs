using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U15F17 : IEquatable<Vector2U15F17>, IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U15F17 X;
        public U15F17 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17(U15F17 x, U15F17 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17(U15F17 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17(Vector2U15F17 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U15F17 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U15F17(U15F17.Zero);
        }
        public static Vector2U15F17 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U15F17(U15F17.One);
        }
        public static Vector2U15F17 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U15F17(U15F17.One, U15F17.Zero);
        }
        public static Vector2U15F17 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U15F17(U15F17.Zero, U15F17.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 operator +(Vector2U15F17 a, Vector2U15F17 b) => new Vector2U15F17(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 operator -(Vector2U15F17 a, Vector2U15F17 b) => new Vector2U15F17(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 operator *(Vector2U15F17 a, Vector2U15F17 b) => new Vector2U15F17(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 operator *(Vector2U15F17 a, U15F17 b) => new Vector2U15F17(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 operator *(U15F17 a, Vector2U15F17 b) => new Vector2U15F17(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 operator /(Vector2U15F17 a, Vector2U15F17 b) => new Vector2U15F17(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 operator /(Vector2U15F17 a, U15F17 b) => new Vector2U15F17(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U15F17 operator /(U15F17 a, Vector2U15F17 b) => new Vector2U15F17(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U15F17 lhs, Vector2U15F17 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U15F17 lhs, Vector2U15F17 rhs) => !(lhs == rhs);

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U15F17 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(X, X); }
        public Vector2U15F17 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(X, Y); }
        public Vector2U15F17 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Y, X); }
        public Vector2U15F17 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Y, Y); }
        public Vector3U15F17 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, X, X); }
        public Vector3U15F17 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, X, Y); }
        public Vector3U15F17 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Y, X); }
        public Vector3U15F17 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Y, Y); }
        public Vector3U15F17 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, X, X); }
        public Vector3U15F17 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, X, Y); }
        public Vector3U15F17 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Y, X); }
        public Vector3U15F17 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Y, Y); }
        public Vector4U15F17 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, X, X); }
        public Vector4U15F17 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, X, Y); }
        public Vector4U15F17 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Y, X); }
        public Vector4U15F17 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Y, Y); }
        public Vector4U15F17 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, X, X); }
        public Vector4U15F17 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, X, Y); }
        public Vector4U15F17 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Y, X); }
        public Vector4U15F17 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Y, Y); }
        public Vector4U15F17 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, X, X); }
        public Vector4U15F17 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, X, Y); }
        public Vector4U15F17 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Y, X); }
        public Vector4U15F17 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Y, Y); }
        public Vector4U15F17 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, X, X); }
        public Vector4U15F17 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, X, Y); }
        public Vector4U15F17 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Y, X); }
        public Vector4U15F17 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Y, Y); }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector2U15F17 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U15F17>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2U15F17 other)
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
        public Vector2U15F17 Min(Vector2U15F17 other) => new Vector2U15F17(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17 Max(Vector2U15F17 other) => new Vector2U15F17(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17 Half() => new Vector2U15F17(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17 Twice() => new Vector2U15F17(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17 Clamp(U15F17 min, U15F17 max) => new Vector2U15F17(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17 Clamp(
            Vector2U15F17 min, Vector2U15F17 max
        ) => new Vector2U15F17(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17 WrappingAdd(Vector2U15F17 other) => new Vector2U15F17(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17 WrappingSub(Vector2U15F17 other) => new Vector2U15F17(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17 WrappingMul(Vector2U15F17 other) => new Vector2U15F17(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17 WrappingAddSigned(Vector2I15F17 other) => new Vector2U15F17(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17 SaturatingAdd(Vector2U15F17 other) => new Vector2U15F17(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17 SaturatingMul(U15F17 other) => new Vector2U15F17(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector2U15F17 other) {
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
        public U15F17 Dot(Vector2U15F17 other) {
            const ulong k = 1UL << 15;
            return U15F17.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U15F17 SaturatingDot(Vector2U15F17 other) {
            const ulong k = 1UL << 15;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U15F17.MaxValue;
            } else {
                return U15F17.FromBits((uint)bits);
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
        public U32F32 LengthSquared() {
            return U32F32.FromBits(LengthSquaredInternal());
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
        public U15F17 LengthHalf() => U15F17.FromBits(LengthInternal());

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
        public I15F17 LengthHalfSigned() => I15F17.FromBits(checked((int)LengthInternal()));

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
        public U16F16 Length() => U16F16.FromBits(LengthInternal());

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
        public I16F16 LengthSigned() => I16F16.FromBits(checked((int)LengthInternal()));

    }

    partial struct U15F17 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U15F17 SaturatingMul(Vector2U15F17 other) => other.SaturatingMul(this);
    }
}
