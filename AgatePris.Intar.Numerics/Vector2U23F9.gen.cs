using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2U23F9
    : IEquatable<Vector2U23F9>
    , IFormattable
    , IVector<U48F16, I48F16, U24F8, I24F8>
    , IVectorComponentRespective<U23F9> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U23F9 X;
        public U23F9 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U23F9(U23F9 x, U23F9 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U23F9(U23F9 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U23F9(Vector2U23F9 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2U23F9 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U23F9(U23F9.Zero);
        }
        public static Vector2U23F9 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U23F9(U23F9.One);
        }
        public static Vector2U23F9 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U23F9(U23F9.One, U23F9.Zero);
        }
        public static Vector2U23F9 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2U23F9(U23F9.Zero, U23F9.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 operator +(Vector2U23F9 a, Vector2U23F9 b) => new Vector2U23F9(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 operator -(Vector2U23F9 a, Vector2U23F9 b) => new Vector2U23F9(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 operator *(Vector2U23F9 a, Vector2U23F9 b) => new Vector2U23F9(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 operator *(Vector2U23F9 a, U23F9 b) => new Vector2U23F9(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 operator *(U23F9 a, Vector2U23F9 b) => new Vector2U23F9(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 operator /(Vector2U23F9 a, Vector2U23F9 b) => new Vector2U23F9(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 operator /(Vector2U23F9 a, U23F9 b) => new Vector2U23F9(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2U23F9 operator /(U23F9 a, Vector2U23F9 b) => new Vector2U23F9(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2U23F9 lhs, Vector2U23F9 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2U23F9 lhs, Vector2U23F9 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U23F9 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector2U23F9 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2U23F9>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2U23F9 other)
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
        public Vector2U23F9 Min(Vector2U23F9 other) => new Vector2U23F9(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U23F9 Max(Vector2U23F9 other) => new Vector2U23F9(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U23F9 Half() => new Vector2U23F9(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U23F9 Twice() => new Vector2U23F9(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U23F9 Clamp(U23F9 min, U23F9 max) => new Vector2U23F9(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U23F9 Clamp(
            Vector2U23F9 min, Vector2U23F9 max
        ) => new Vector2U23F9(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U23F9 WrappingAdd(Vector2U23F9 other) => new Vector2U23F9(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U23F9 WrappingSub(Vector2U23F9 other) => new Vector2U23F9(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U23F9 WrappingMul(Vector2U23F9 other) => new Vector2U23F9(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U23F9 WrappingAddSigned(Vector2I23F9 other) => new Vector2U23F9(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U23F9 SaturatingAdd(Vector2U23F9 other) => new Vector2U23F9(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U23F9 SaturatingMul(U23F9 other) => new Vector2U23F9(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector2U23F9 other) {
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
        public U23F9 Dot(Vector2U23F9 other) {
            const ulong k = 1UL << 7;
            return U23F9.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U23F9 SaturatingDot(Vector2U23F9 other) {
            const ulong k = 1UL << 7;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U23F9.MaxValue;
            } else {
                return U23F9.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U48F16 LengthSquaredUnsigned() => U48F16.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I48F16 LengthSquaredSigned() => I48F16.FromBits(
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
        public U48F16 LengthSquared() => LengthSquaredUnsigned();

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
        public U23F9 LengthHalf() => U23F9.FromBits(LengthInternal());

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
        public I23F9 LengthHalfSigned() => I23F9.FromBits(checked((int)LengthInternal()));

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
        public U24F8 LengthUnsigned() => U24F8.FromBits(LengthInternal());

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
        public I24F8 LengthSigned() => I24F8.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U24F8 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U23F9? Normalize() {
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

            const ulong k = 1UL << 8;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);

            return new Vector2U23F9(
                U23F9.FromBits(y0),
                U23F9.FromBits(y1));
        }

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U23F9 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(X, X); }
        public Vector2U23F9 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(X, Y); }
        public Vector2U23F9 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(Y, X); }
        public Vector2U23F9 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U23F9(Y, Y); }
        public Vector3U23F9 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, X, X); }
        public Vector3U23F9 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, X, Y); }
        public Vector3U23F9 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, Y, X); }
        public Vector3U23F9 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(X, Y, Y); }
        public Vector3U23F9 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, X, X); }
        public Vector3U23F9 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, X, Y); }
        public Vector3U23F9 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, Y, X); }
        public Vector3U23F9 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U23F9(Y, Y, Y); }
        public Vector4U23F9 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, X, X); }
        public Vector4U23F9 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, X, Y); }
        public Vector4U23F9 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, Y, X); }
        public Vector4U23F9 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, X, Y, Y); }
        public Vector4U23F9 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, X, X); }
        public Vector4U23F9 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, X, Y); }
        public Vector4U23F9 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, Y, X); }
        public Vector4U23F9 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(X, Y, Y, Y); }
        public Vector4U23F9 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, X, X); }
        public Vector4U23F9 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, X, Y); }
        public Vector4U23F9 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, Y, X); }
        public Vector4U23F9 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, X, Y, Y); }
        public Vector4U23F9 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, X, X); }
        public Vector4U23F9 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, X, Y); }
        public Vector4U23F9 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, Y, X); }
        public Vector4U23F9 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U23F9(Y, Y, Y, Y); }

    }

    partial struct U23F9 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U23F9 SaturatingMul(Vector2U23F9 other) => other.SaturatingMul(this);
    }
}
