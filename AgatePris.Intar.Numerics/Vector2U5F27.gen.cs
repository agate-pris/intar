using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U5F27
    : IEquatable<Vector2U5F27>
    , IFormattable
    , IVector<U12F52, I12F52, U6F26, I6F26>
    , IVectorComponentRespective<U5F27> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U5F27 X;
        public U5F27 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27(U5F27 x, U5F27 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27(U5F27 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27(Vector2U5F27 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U5F27 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U5F27(U5F27.Zero);
        }
        public static Vector2U5F27 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U5F27(U5F27.One);
        }
        public static Vector2U5F27 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U5F27(U5F27.One, U5F27.Zero);
        }
        public static Vector2U5F27 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U5F27(U5F27.Zero, U5F27.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 operator +(Vector2U5F27 a, Vector2U5F27 b) => new Vector2U5F27(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 operator -(Vector2U5F27 a, Vector2U5F27 b) => new Vector2U5F27(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 operator *(Vector2U5F27 a, Vector2U5F27 b) => new Vector2U5F27(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 operator *(Vector2U5F27 a, U5F27 b) => new Vector2U5F27(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 operator *(U5F27 a, Vector2U5F27 b) => new Vector2U5F27(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 operator /(Vector2U5F27 a, Vector2U5F27 b) => new Vector2U5F27(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 operator /(Vector2U5F27 a, U5F27 b) => new Vector2U5F27(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U5F27 operator /(U5F27 a, Vector2U5F27 b) => new Vector2U5F27(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U5F27 lhs, Vector2U5F27 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U5F27 lhs, Vector2U5F27 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U5F27 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                switch (index) {
                    case 0: return X;
                    case 1: return Y;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                switch (index) {
                    case 0: X = value; break;
                    case 1: Y = value; break;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
        }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector2U5F27 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U5F27>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2U5F27 other)
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
        public Vector2U5F27 Min(Vector2U5F27 other) => new Vector2U5F27(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27 Max(Vector2U5F27 other) => new Vector2U5F27(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27 Half() => new Vector2U5F27(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27 Twice() => new Vector2U5F27(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27 Clamp(U5F27 min, U5F27 max) => new Vector2U5F27(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27 Clamp(
            Vector2U5F27 min, Vector2U5F27 max
        ) => new Vector2U5F27(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27 WrappingAdd(Vector2U5F27 other) => new Vector2U5F27(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27 WrappingSub(Vector2U5F27 other) => new Vector2U5F27(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27 WrappingMul(Vector2U5F27 other) => new Vector2U5F27(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27 WrappingAddSigned(Vector2I5F27 other) => new Vector2U5F27(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27 SaturatingAdd(Vector2U5F27 other) => new Vector2U5F27(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27 SaturatingMul(U5F27 other) => new Vector2U5F27(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector2U5F27 other) {
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
        public U5F27 Dot(Vector2U5F27 other) {
            const ulong k = 1UL << 25;
            return U5F27.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U5F27 SaturatingDot(Vector2U5F27 other) {
            const ulong k = 1UL << 25;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U5F27.MaxValue;
            } else {
                return U5F27.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U12F52 LengthSquaredUnsigned() => U12F52.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I12F52 LengthSquaredSigned() => I12F52.FromBits(
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
        public U12F52 LengthSquared() => LengthSquaredUnsigned();

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
        public U5F27 LengthHalf() => U5F27.FromBits(LengthInternal());

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
        public I5F27 LengthHalfSigned() => I5F27.FromBits(checked((int)LengthInternal()));

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
        public U6F26 LengthUnsigned() => U6F26.FromBits(LengthInternal());

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
        public I6F26 LengthSigned() => I6F26.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U6F26 Length() => LengthUnsigned();

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U5F27 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(X, X); }
        public Vector2U5F27 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(X, Y); }
        public Vector2U5F27 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(Y, X); }
        public Vector2U5F27 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U5F27(Y, Y); }
        public Vector3U5F27 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, X, X); }
        public Vector3U5F27 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, X, Y); }
        public Vector3U5F27 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, Y, X); }
        public Vector3U5F27 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(X, Y, Y); }
        public Vector3U5F27 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, X, X); }
        public Vector3U5F27 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, X, Y); }
        public Vector3U5F27 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, Y, X); }
        public Vector3U5F27 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U5F27(Y, Y, Y); }
        public Vector4U5F27 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, X, X); }
        public Vector4U5F27 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, X, Y); }
        public Vector4U5F27 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, Y, X); }
        public Vector4U5F27 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, X, Y, Y); }
        public Vector4U5F27 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, X, X); }
        public Vector4U5F27 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, X, Y); }
        public Vector4U5F27 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, Y, X); }
        public Vector4U5F27 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(X, Y, Y, Y); }
        public Vector4U5F27 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, X, X); }
        public Vector4U5F27 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, X, Y); }
        public Vector4U5F27 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, Y, X); }
        public Vector4U5F27 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, X, Y, Y); }
        public Vector4U5F27 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, X, X); }
        public Vector4U5F27 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, X, Y); }
        public Vector4U5F27 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, Y, X); }
        public Vector4U5F27 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U5F27(Y, Y, Y, Y); }

    }

    partial struct U5F27 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U5F27 SaturatingMul(Vector2U5F27 other) => other.SaturatingMul(this);
    }
}
