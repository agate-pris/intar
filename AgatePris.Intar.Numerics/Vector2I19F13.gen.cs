using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I19F13
    : IEquatable<Vector2I19F13>
    , IFormattable
    , IVector<U40F24, I40F24, U20F12, I20F12>
    , IVectorComponentRespective<I19F13> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I19F13 X;
        public I19F13 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13(I19F13 x, I19F13 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13(I19F13 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13(Vector2I19F13 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I19F13 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I19F13(I19F13.Zero);
        }
        public static Vector2I19F13 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I19F13(I19F13.One);
        }
        public static Vector2I19F13 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I19F13(I19F13.One, I19F13.Zero);
        }
        public static Vector2I19F13 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I19F13(I19F13.Zero, I19F13.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator +(Vector2I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator -(Vector2I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator *(Vector2I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator *(Vector2I19F13 a, I19F13 b) => new Vector2I19F13(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator *(I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator /(Vector2I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator /(Vector2I19F13 a, I19F13 b) => new Vector2I19F13(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I19F13 operator /(I19F13 a, Vector2I19F13 b) => new Vector2I19F13(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I19F13 lhs, Vector2I19F13 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I19F13 lhs, Vector2I19F13 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I19F13 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector2I19F13 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I19F13>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2I19F13 other)
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
        public Vector2I19F13 Min(Vector2I19F13 other) => new Vector2I19F13(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13 Max(Vector2I19F13 other) => new Vector2I19F13(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13 Abs() => new Vector2I19F13(
            X.Abs(),
            Y.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13 Half() => new Vector2I19F13(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13 Twice() => new Vector2I19F13(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13 Clamp(I19F13 min, I19F13 max) => new Vector2I19F13(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13 Clamp(
            Vector2I19F13 min, Vector2I19F13 max
        ) => new Vector2I19F13(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13 WrappingAdd(Vector2I19F13 other) => new Vector2I19F13(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13 WrappingSub(Vector2I19F13 other) => new Vector2I19F13(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13 WrappingMul(Vector2I19F13 other) => new Vector2I19F13(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13 WrappingAddUnsigned(Vector2U19F13 other) => new Vector2I19F13(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13 WrappingSubUnsigned(Vector2U19F13 other) => new Vector2I19F13(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U19F13 UnsignedAbs() => new Vector2U19F13(
            X.UnsignedAbs(),
            Y.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13 SaturatingAdd(Vector2I19F13 other) => new Vector2I19F13(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13 SaturatingMul(I19F13 other) => new Vector2I19F13(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector2I19F13 other) {
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
        public I19F13 Dot(Vector2I19F13 other) {
            const long k = 1L << 11;
            return I19F13.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I19F13 SaturatingDot(Vector2I19F13 other) {
            const long k = 1L << 11;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I19F13.MaxValue;
            } else if (bits < int.MinValue) {
                return I19F13.MinValue;
            } else {
                return I19F13.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U40F24 LengthSquaredUnsigned() => U40F24.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I40F24 LengthSquaredSigned() => I40F24.FromBits(
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
        public I40F24 LengthSquared() => LengthSquaredSigned();

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
        public U19F13 LengthHalfUnsigned() => U19F13.FromBits(LengthInternal());

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
        public I19F13 LengthHalf() => I19F13.FromBits(checked((int)LengthInternal()));

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
        public U20F12 LengthUnsigned() => U20F12.FromBits(LengthInternal());

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
        public I20F12 LengthSigned() => I20F12.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I20F12 Length() => LengthSigned();

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I19F13 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(X, X); }
        public Vector2I19F13 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(X, Y); }
        public Vector2I19F13 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Y, X); }
        public Vector2I19F13 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I19F13(Y, Y); }
        public Vector3I19F13 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, X, X); }
        public Vector3I19F13 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, X, Y); }
        public Vector3I19F13 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Y, X); }
        public Vector3I19F13 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(X, Y, Y); }
        public Vector3I19F13 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, X, X); }
        public Vector3I19F13 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, X, Y); }
        public Vector3I19F13 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Y, X); }
        public Vector3I19F13 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I19F13(Y, Y, Y); }
        public Vector4I19F13 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, X, X); }
        public Vector4I19F13 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, X, Y); }
        public Vector4I19F13 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Y, X); }
        public Vector4I19F13 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, X, Y, Y); }
        public Vector4I19F13 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, X, X); }
        public Vector4I19F13 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, X, Y); }
        public Vector4I19F13 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Y, X); }
        public Vector4I19F13 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(X, Y, Y, Y); }
        public Vector4I19F13 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, X, X); }
        public Vector4I19F13 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, X, Y); }
        public Vector4I19F13 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Y, X); }
        public Vector4I19F13 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, X, Y, Y); }
        public Vector4I19F13 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, X, X); }
        public Vector4I19F13 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, X, Y); }
        public Vector4I19F13 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Y, X); }
        public Vector4I19F13 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I19F13(Y, Y, Y, Y); }

    }

    partial struct I19F13 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I19F13 SaturatingMul(Vector2I19F13 other) => other.SaturatingMul(this);
    }
}
