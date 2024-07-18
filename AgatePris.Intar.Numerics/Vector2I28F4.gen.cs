using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I28F4
    : IEquatable<Vector2I28F4>
    , IFormattable
    , IVector<U58F6, I58F6, U29F3, I29F3>
    , IVectorComponentRespective<I28F4> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I28F4 X;
        public I28F4 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4(I28F4 x, I28F4 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4(I28F4 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4(Vector2I28F4 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I28F4 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I28F4(I28F4.Zero);
        }
        public static Vector2I28F4 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I28F4(I28F4.One);
        }
        public static Vector2I28F4 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I28F4(I28F4.One, I28F4.Zero);
        }
        public static Vector2I28F4 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I28F4(I28F4.Zero, I28F4.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator +(Vector2I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator -(Vector2I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator *(Vector2I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator *(Vector2I28F4 a, I28F4 b) => new Vector2I28F4(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator *(I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator /(Vector2I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator /(Vector2I28F4 a, I28F4 b) => new Vector2I28F4(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I28F4 operator /(I28F4 a, Vector2I28F4 b) => new Vector2I28F4(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I28F4 lhs, Vector2I28F4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I28F4 lhs, Vector2I28F4 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I28F4 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector2I28F4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I28F4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2I28F4 other)
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
        public Vector2I28F4 Min(Vector2I28F4 other) => new Vector2I28F4(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4 Max(Vector2I28F4 other) => new Vector2I28F4(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4 Abs() => new Vector2I28F4(
            X.Abs(),
            Y.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4 Half() => new Vector2I28F4(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4 Twice() => new Vector2I28F4(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4 Clamp(I28F4 min, I28F4 max) => new Vector2I28F4(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4 Clamp(
            Vector2I28F4 min, Vector2I28F4 max
        ) => new Vector2I28F4(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4 WrappingAdd(Vector2I28F4 other) => new Vector2I28F4(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4 WrappingSub(Vector2I28F4 other) => new Vector2I28F4(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4 WrappingMul(Vector2I28F4 other) => new Vector2I28F4(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4 WrappingAddUnsigned(Vector2U28F4 other) => new Vector2I28F4(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4 WrappingSubUnsigned(Vector2U28F4 other) => new Vector2I28F4(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U28F4 UnsignedAbs() => new Vector2U28F4(
            X.UnsignedAbs(),
            Y.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4 SaturatingAdd(Vector2I28F4 other) => new Vector2I28F4(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4 SaturatingMul(I28F4 other) => new Vector2I28F4(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector2I28F4 other) {
            var x = ((long)X.Bits) * other.X.Bits;
            var y = ((long)Y.Bits) * other.Y.Bits;

            // オーバーフローを避けるため､ 事前に除算する｡
            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算に合わせて常に 4 で除算する｡
            return
                (x / 4) +
                (y / 4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I28F4 Dot(Vector2I28F4 other) {
            const long k = 1L << 2;
            return I28F4.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I28F4 SaturatingDot(Vector2I28F4 other) {
            const long k = 1L << 2;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I28F4.MaxValue;
            } else if (bits < int.MinValue) {
                return I28F4.MinValue;
            } else {
                return I28F4.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U58F6 LengthSquaredUnsigned() => U58F6.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I58F6 LengthSquaredSigned() => I58F6.FromBits(
            LengthSquaredInternal()
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
        public I58F6 LengthSquared() => LengthSquaredSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint LengthInternal() {
            var squared = LengthSquaredInternal();
            return (uint)Mathi.Sqrt((ulong)squared);
        }

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <see cref="LengthHalf">LengthHalf</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="LengthHalf">LengthHalf</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U28F4 LengthHalfUnsigned() => U28F4.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="LengthHalfUnsigned">LengthHalfUnsigned</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthHalfUnsigned">LengthHalfUnsigned</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I28F4 LengthHalf() => I28F4.FromBits(checked((int)LengthInternal()));

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
        /// <seealso cref="LengthHalfUnsigned"/>
        /// <seealso cref="LengthSigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U29F3 LengthUnsigned() => U29F3.FromBits(LengthInternal());

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
        /// <seealso cref="LengthHalf"/>
        /// <seealso cref="LengthUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I29F3 LengthSigned() => I29F3.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I29F3 Length() => LengthSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4? Normalize() {
            var x0 = X.Bits;
            var x1 = Y.Bits;
            var b0 = x0 < 0;
            var b1 = x1 < 0;
            var a0 = unchecked((uint)(b0 ? Overflowing.WrappingNeg(x0) : x0));
            var a1 = unchecked((uint)(b1 ? Overflowing.WrappingNeg(x1) : x1));

            var max = a0.Max(a1);
            if (max == 0) {
                return null;
            }

            ulong m = uint.MaxValue / max;
            var l0 = m * a0;
            var l1 = m * a1;
            var sum =
                (l0 * l0 / 4) +
                (l1 * l1 / 4);
            var ll = Mathi.Sqrt(sum);

            const ulong k = 1UL << 3;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);

            return new Vector2I28F4(
                I28F4.FromBits(b0 ? -y0 : y0),
                I28F4.FromBits(b1 ? -y1 : y1));
        }

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I28F4 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(X, X); }
        public Vector2I28F4 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(X, Y); }
        public Vector2I28F4 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Y, X); }
        public Vector2I28F4 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I28F4(Y, Y); }
        public Vector3I28F4 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, X, X); }
        public Vector3I28F4 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, X, Y); }
        public Vector3I28F4 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Y, X); }
        public Vector3I28F4 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(X, Y, Y); }
        public Vector3I28F4 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, X, X); }
        public Vector3I28F4 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, X, Y); }
        public Vector3I28F4 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Y, X); }
        public Vector3I28F4 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I28F4(Y, Y, Y); }
        public Vector4I28F4 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, X, X); }
        public Vector4I28F4 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, X, Y); }
        public Vector4I28F4 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Y, X); }
        public Vector4I28F4 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, X, Y, Y); }
        public Vector4I28F4 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, X, X); }
        public Vector4I28F4 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, X, Y); }
        public Vector4I28F4 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Y, X); }
        public Vector4I28F4 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(X, Y, Y, Y); }
        public Vector4I28F4 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, X, X); }
        public Vector4I28F4 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, X, Y); }
        public Vector4I28F4 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Y, X); }
        public Vector4I28F4 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, X, Y, Y); }
        public Vector4I28F4 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, X, X); }
        public Vector4I28F4 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, X, Y); }
        public Vector4I28F4 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Y, X); }
        public Vector4I28F4 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I28F4(Y, Y, Y, Y); }

    }

    partial struct I28F4 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I28F4 SaturatingMul(Vector2I28F4 other) => other.SaturatingMul(this);
    }
}
