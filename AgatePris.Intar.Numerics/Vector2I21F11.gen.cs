using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I21F11
    : IEquatable<Vector2I21F11>
    , IFormattable
    , IVector<U44F20, I44F20, U22F10, I22F10>
    , IVectorComponentRespective<I21F11> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I21F11 X;
        public I21F11 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11(I21F11 x, I21F11 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11(I21F11 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11(Vector2I21F11 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I21F11 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I21F11(I21F11.Zero);
        }
        public static Vector2I21F11 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I21F11(I21F11.One);
        }
        public static Vector2I21F11 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I21F11(I21F11.One, I21F11.Zero);
        }
        public static Vector2I21F11 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I21F11(I21F11.Zero, I21F11.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 operator +(Vector2I21F11 a, Vector2I21F11 b) => new Vector2I21F11(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 operator -(Vector2I21F11 a, Vector2I21F11 b) => new Vector2I21F11(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 operator *(Vector2I21F11 a, Vector2I21F11 b) => new Vector2I21F11(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 operator *(Vector2I21F11 a, I21F11 b) => new Vector2I21F11(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 operator *(I21F11 a, Vector2I21F11 b) => new Vector2I21F11(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 operator /(Vector2I21F11 a, Vector2I21F11 b) => new Vector2I21F11(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 operator /(Vector2I21F11 a, I21F11 b) => new Vector2I21F11(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I21F11 operator /(I21F11 a, Vector2I21F11 b) => new Vector2I21F11(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I21F11 lhs, Vector2I21F11 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I21F11 lhs, Vector2I21F11 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I21F11 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector2I21F11 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I21F11>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2I21F11 other)
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
        public Vector2I21F11 Min(Vector2I21F11 other) => new Vector2I21F11(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11 Max(Vector2I21F11 other) => new Vector2I21F11(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11 Abs() => new Vector2I21F11(
            X.Abs(),
            Y.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11 Half() => new Vector2I21F11(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11 Twice() => new Vector2I21F11(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11 Clamp(I21F11 min, I21F11 max) => new Vector2I21F11(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11 Clamp(
            Vector2I21F11 min, Vector2I21F11 max
        ) => new Vector2I21F11(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11 WrappingAdd(Vector2I21F11 other) => new Vector2I21F11(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11 WrappingSub(Vector2I21F11 other) => new Vector2I21F11(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11 WrappingMul(Vector2I21F11 other) => new Vector2I21F11(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11 WrappingAddUnsigned(Vector2U21F11 other) => new Vector2I21F11(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11 WrappingSubUnsigned(Vector2U21F11 other) => new Vector2I21F11(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U21F11 UnsignedAbs() => new Vector2U21F11(
            X.UnsignedAbs(),
            Y.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11 SaturatingAdd(Vector2I21F11 other) => new Vector2I21F11(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11 SaturatingMul(I21F11 other) => new Vector2I21F11(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector2I21F11 other) {
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
        public I21F11 Dot(Vector2I21F11 other) {
            const long k = 1L << 9;
            return I21F11.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I21F11 SaturatingDot(Vector2I21F11 other) {
            const long k = 1L << 9;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I21F11.MaxValue;
            } else if (bits < int.MinValue) {
                return I21F11.MinValue;
            } else {
                return I21F11.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U44F20 LengthSquaredUnsigned() => U44F20.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I44F20 LengthSquaredSigned() => I44F20.FromBits(
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
        public I44F20 LengthSquared() => LengthSquaredSigned();

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
        public U21F11 LengthHalfUnsigned() => U21F11.FromBits(LengthInternal());

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
        public I21F11 LengthHalf() => I21F11.FromBits(checked((int)LengthInternal()));

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
        public U22F10 LengthUnsigned() => U22F10.FromBits(LengthInternal());

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
        public I22F10 LengthSigned() => I22F10.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I22F10 Length() => LengthSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I21F11? Normalize() {
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

            const ulong k = 1UL << 10;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);

            return new Vector2I21F11(
                I21F11.FromBits(b0 ? -y0 : y0),
                I21F11.FromBits(b1 ? -y1 : y1));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I21F11 XX() => new Vector2I21F11(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I21F11 XY() => new Vector2I21F11(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I21F11 YX() => new Vector2I21F11(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I21F11 YY() => new Vector2I21F11(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I21F11 XXX() => new Vector3I21F11(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I21F11 XXY() => new Vector3I21F11(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I21F11 XYX() => new Vector3I21F11(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I21F11 XYY() => new Vector3I21F11(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I21F11 YXX() => new Vector3I21F11(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I21F11 YXY() => new Vector3I21F11(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I21F11 YYX() => new Vector3I21F11(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I21F11 YYY() => new Vector3I21F11(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I21F11 XXXX() => new Vector4I21F11(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I21F11 XXXY() => new Vector4I21F11(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I21F11 XXYX() => new Vector4I21F11(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I21F11 XXYY() => new Vector4I21F11(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I21F11 XYXX() => new Vector4I21F11(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I21F11 XYXY() => new Vector4I21F11(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I21F11 XYYX() => new Vector4I21F11(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I21F11 XYYY() => new Vector4I21F11(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I21F11 YXXX() => new Vector4I21F11(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I21F11 YXXY() => new Vector4I21F11(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I21F11 YXYX() => new Vector4I21F11(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I21F11 YXYY() => new Vector4I21F11(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I21F11 YYXX() => new Vector4I21F11(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I21F11 YYXY() => new Vector4I21F11(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I21F11 YYYX() => new Vector4I21F11(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I21F11 YYYY() => new Vector4I21F11(Y, Y, Y, Y);

    }
}
