using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U30F2
    : IEquatable<Vector2U30F2>
    , IFormattable
    , IVector<U62F2, I62F2, U31F1, I31F1>
    , IVectorComponentRespective<U30F2> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U30F2 X;
        public U30F2 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2(U30F2 x, U30F2 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2(U30F2 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2(Vector2U30F2 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U30F2 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U30F2(U30F2.Zero);
        }
        public static Vector2U30F2 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U30F2(U30F2.One);
        }
        public static Vector2U30F2 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U30F2(U30F2.One, U30F2.Zero);
        }
        public static Vector2U30F2 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U30F2(U30F2.Zero, U30F2.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator +(Vector2U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator -(Vector2U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator *(Vector2U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator *(Vector2U30F2 a, U30F2 b) => new Vector2U30F2(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator *(U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator /(Vector2U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator /(Vector2U30F2 a, U30F2 b) => new Vector2U30F2(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U30F2 operator /(U30F2 a, Vector2U30F2 b) => new Vector2U30F2(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U30F2 lhs, Vector2U30F2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U30F2 lhs, Vector2U30F2 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U30F2 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector2U30F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U30F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2U30F2 other)
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
        public Vector2U30F2 Min(Vector2U30F2 other) => new Vector2U30F2(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2 Max(Vector2U30F2 other) => new Vector2U30F2(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2 Half() => new Vector2U30F2(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2 Twice() => new Vector2U30F2(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2 Clamp(U30F2 min, U30F2 max) => new Vector2U30F2(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2 Clamp(
            Vector2U30F2 min, Vector2U30F2 max
        ) => new Vector2U30F2(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2 WrappingAdd(Vector2U30F2 other) => new Vector2U30F2(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2 WrappingSub(Vector2U30F2 other) => new Vector2U30F2(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2 WrappingMul(Vector2U30F2 other) => new Vector2U30F2(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2 WrappingAddSigned(Vector2I30F2 other) => new Vector2U30F2(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2 SaturatingAdd(Vector2U30F2 other) => new Vector2U30F2(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2 SaturatingMul(U30F2 other) => new Vector2U30F2(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector2U30F2 other) {
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
        public U30F2 Dot(Vector2U30F2 other) {
            const ulong k = 1UL << 0;
            return U30F2.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U30F2 SaturatingDot(Vector2U30F2 other) {
            const ulong k = 1UL << 0;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U30F2.MaxValue;
            } else {
                return U30F2.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U62F2 LengthSquaredUnsigned() => U62F2.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I62F2 LengthSquaredSigned() => I62F2.FromBits(
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
        public U62F2 LengthSquared() => LengthSquaredUnsigned();

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
        public U30F2 LengthHalf() => U30F2.FromBits(LengthInternal());

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
        public I30F2 LengthHalfSigned() => I30F2.FromBits(checked((int)LengthInternal()));

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
        public U31F1 LengthUnsigned() => U31F1.FromBits(LengthInternal());

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
        public I31F1 LengthSigned() => I31F1.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U31F1 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2? Normalize() {
            var a0 = X.Bits;
            var a1 = Y.Bits;

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

            const ulong k = 1UL << 1;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);

            return new Vector2U30F2(
                U30F2.FromBits(y0),
                U30F2.FromBits(y1));
        }

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U30F2 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(X, X); }
        public Vector2U30F2 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(X, Y); }
        public Vector2U30F2 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Y, X); }
        public Vector2U30F2 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U30F2(Y, Y); }
        public Vector3U30F2 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, X, X); }
        public Vector3U30F2 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, X, Y); }
        public Vector3U30F2 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Y, X); }
        public Vector3U30F2 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(X, Y, Y); }
        public Vector3U30F2 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, X, X); }
        public Vector3U30F2 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, X, Y); }
        public Vector3U30F2 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Y, X); }
        public Vector3U30F2 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U30F2(Y, Y, Y); }
        public Vector4U30F2 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, X, X); }
        public Vector4U30F2 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, X, Y); }
        public Vector4U30F2 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Y, X); }
        public Vector4U30F2 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, X, Y, Y); }
        public Vector4U30F2 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, X, X); }
        public Vector4U30F2 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, X, Y); }
        public Vector4U30F2 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Y, X); }
        public Vector4U30F2 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(X, Y, Y, Y); }
        public Vector4U30F2 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, X, X); }
        public Vector4U30F2 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, X, Y); }
        public Vector4U30F2 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Y, X); }
        public Vector4U30F2 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, X, Y, Y); }
        public Vector4U30F2 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, X, X); }
        public Vector4U30F2 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, X, Y); }
        public Vector4U30F2 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Y, X); }
        public Vector4U30F2 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U30F2(Y, Y, Y, Y); }

    }

    partial struct U30F2 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U30F2 SaturatingMul(Vector2U30F2 other) => other.SaturatingMul(this);
    }
}
