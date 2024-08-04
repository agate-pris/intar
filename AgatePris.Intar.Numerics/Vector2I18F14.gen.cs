using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I18F14
    : IEquatable<Vector2I18F14>
    , IFormattable
    , IVector<U38F26, I38F26, U19F13, I19F13>
    , IVectorComponentRespective<I18F14> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I18F14 X;
        public I18F14 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14(I18F14 x, I18F14 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14(I18F14 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14(Vector2I18F14 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I18F14 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I18F14(I18F14.Zero);
        }
        public static Vector2I18F14 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I18F14(I18F14.One);
        }
        public static Vector2I18F14 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I18F14(I18F14.One, I18F14.Zero);
        }
        public static Vector2I18F14 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I18F14(I18F14.Zero, I18F14.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator +(Vector2I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator -(Vector2I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator *(Vector2I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator *(Vector2I18F14 a, I18F14 b) => new Vector2I18F14(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator *(I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator /(Vector2I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator /(Vector2I18F14 a, I18F14 b) => new Vector2I18F14(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I18F14 operator /(I18F14 a, Vector2I18F14 b) => new Vector2I18F14(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I18F14 lhs, Vector2I18F14 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I18F14 lhs, Vector2I18F14 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I18F14 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector2I18F14 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I18F14>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2I18F14 other)
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
        public Vector2I18F14 Min(Vector2I18F14 other) => new Vector2I18F14(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14 Max(Vector2I18F14 other) => new Vector2I18F14(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14 Abs() => new Vector2I18F14(
            X.Abs(),
            Y.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14 Half() => new Vector2I18F14(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14 Twice() => new Vector2I18F14(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14 Clamp(I18F14 min, I18F14 max) => new Vector2I18F14(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14 Clamp(
            Vector2I18F14 min, Vector2I18F14 max
        ) => new Vector2I18F14(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14 WrappingAdd(Vector2I18F14 other) => new Vector2I18F14(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14 WrappingSub(Vector2I18F14 other) => new Vector2I18F14(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14 WrappingMul(Vector2I18F14 other) => new Vector2I18F14(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14 WrappingAddUnsigned(Vector2U18F14 other) => new Vector2I18F14(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14 WrappingSubUnsigned(Vector2U18F14 other) => new Vector2I18F14(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U18F14 UnsignedAbs() => new Vector2U18F14(
            X.UnsignedAbs(),
            Y.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14 SaturatingAdd(Vector2I18F14 other) => new Vector2I18F14(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14 SaturatingMul(I18F14 other) => new Vector2I18F14(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector2I18F14 other) {
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
        public I18F14 Dot(Vector2I18F14 other) {
            const long k = 1L << 12;
            return I18F14.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I18F14 SaturatingDot(Vector2I18F14 other) {
            const long k = 1L << 12;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I18F14.MaxValue;
            } else if (bits < int.MinValue) {
                return I18F14.MinValue;
            } else {
                return I18F14.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U38F26 LengthSquaredUnsigned() => U38F26.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I38F26 LengthSquaredSigned() => I38F26.FromBits(
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
        public I38F26 LengthSquared() => LengthSquaredSigned();

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
        public U18F14 LengthHalfUnsigned() => U18F14.FromBits(LengthInternal());

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
        public I18F14 LengthHalf() => I18F14.FromBits(checked((int)LengthInternal()));

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
        public U19F13 LengthUnsigned() => U19F13.FromBits(LengthInternal());

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
        public I19F13 LengthSigned() => I19F13.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I19F13 Length() => LengthSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I18F14? Normalize() {
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

            const ulong k = 1UL << 13;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);

            return new Vector2I18F14(
                I18F14.FromBits(b0 ? -y0 : y0),
                I18F14.FromBits(b1 ? -y1 : y1));
        }

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I18F14 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(X, X); }
        public Vector2I18F14 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(X, Y); }
        public Vector2I18F14 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Y, X); }
        public Vector2I18F14 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I18F14(Y, Y); }
        public Vector3I18F14 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, X, X); }
        public Vector3I18F14 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, X, Y); }
        public Vector3I18F14 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Y, X); }
        public Vector3I18F14 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(X, Y, Y); }
        public Vector3I18F14 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, X, X); }
        public Vector3I18F14 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, X, Y); }
        public Vector3I18F14 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Y, X); }
        public Vector3I18F14 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I18F14(Y, Y, Y); }
        public Vector4I18F14 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, X, X); }
        public Vector4I18F14 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, X, Y); }
        public Vector4I18F14 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Y, X); }
        public Vector4I18F14 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, X, Y, Y); }
        public Vector4I18F14 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, X, X); }
        public Vector4I18F14 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, X, Y); }
        public Vector4I18F14 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Y, X); }
        public Vector4I18F14 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(X, Y, Y, Y); }
        public Vector4I18F14 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, X, X); }
        public Vector4I18F14 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, X, Y); }
        public Vector4I18F14 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Y, X); }
        public Vector4I18F14 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, X, Y, Y); }
        public Vector4I18F14 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, X, X); }
        public Vector4I18F14 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, X, Y); }
        public Vector4I18F14 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Y, X); }
        public Vector4I18F14 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I18F14(Y, Y, Y, Y); }

    }
}
