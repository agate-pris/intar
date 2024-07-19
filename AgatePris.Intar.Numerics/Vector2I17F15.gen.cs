using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector2I17F15
    : IEquatable<Vector2I17F15>
    , IFormattable
    , IVector<U36F28, I36F28, U18F14, I18F14>
    , IVectorComponentRespective<I17F15> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I17F15 X;
        public I17F15 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15(I17F15 x, I17F15 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15(I17F15 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15(Vector2I17F15 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I17F15 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I17F15(I17F15.Zero);
        }
        public static Vector2I17F15 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I17F15(I17F15.One);
        }
        public static Vector2I17F15 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I17F15(I17F15.One, I17F15.Zero);
        }
        public static Vector2I17F15 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I17F15(I17F15.Zero, I17F15.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator +(Vector2I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator -(Vector2I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator *(Vector2I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator *(Vector2I17F15 a, I17F15 b) => new Vector2I17F15(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator *(I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator /(Vector2I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator /(Vector2I17F15 a, I17F15 b) => new Vector2I17F15(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator /(I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I17F15 lhs, Vector2I17F15 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I17F15 lhs, Vector2I17F15 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I17F15 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector2I17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2I17F15 other)
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
        public Vector2I17F15 Min(Vector2I17F15 other) => new Vector2I17F15(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 Max(Vector2I17F15 other) => new Vector2I17F15(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 Abs() => new Vector2I17F15(
            X.Abs(),
            Y.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 Half() => new Vector2I17F15(
            X.Half(),
            Y.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 Twice() => new Vector2I17F15(
            X.Twice(),
            Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 Clamp(I17F15 min, I17F15 max) => new Vector2I17F15(
            X.Clamp(min, max),
            Y.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 Clamp(
            Vector2I17F15 min, Vector2I17F15 max
        ) => new Vector2I17F15(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 WrappingAdd(Vector2I17F15 other) => new Vector2I17F15(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 WrappingSub(Vector2I17F15 other) => new Vector2I17F15(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 WrappingMul(Vector2I17F15 other) => new Vector2I17F15(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 WrappingAddUnsigned(Vector2U17F15 other) => new Vector2I17F15(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 WrappingSubUnsigned(Vector2U17F15 other) => new Vector2I17F15(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15 UnsignedAbs() => new Vector2U17F15(
            X.UnsignedAbs(),
            Y.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 SaturatingAdd(Vector2I17F15 other) => new Vector2I17F15(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 SaturatingMul(I17F15 other) => new Vector2I17F15(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector2I17F15 other) {
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
        public I17F15 Dot(Vector2I17F15 other) {
            const long k = 1L << 13;
            return I17F15.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15 SaturatingDot(Vector2I17F15 other) {
            const long k = 1L << 13;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I17F15.MaxValue;
            } else if (bits < int.MinValue) {
                return I17F15.MinValue;
            } else {
                return I17F15.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U36F28 LengthSquaredUnsigned() => U36F28.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I36F28 LengthSquaredSigned() => I36F28.FromBits(
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
        public I36F28 LengthSquared() => LengthSquaredSigned();

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
        public U17F15 LengthHalfUnsigned() => U17F15.FromBits(LengthInternal());

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
        public I17F15 LengthHalf() => I17F15.FromBits(checked((int)LengthInternal()));

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
        public U18F14 LengthUnsigned() => U18F14.FromBits(LengthInternal());

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
        public I18F14 LengthSigned() => I18F14.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I18F14 Length() => LengthSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 SinP2() => new Vector2I2F30(
            X.SinP2(),
            Y.SinP2());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 SinP3A16384() => new Vector2I2F30(
            X.SinP3A16384(),
            Y.SinP3A16384());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 SinP4A7032() => new Vector2I2F30(
            X.SinP4A7032(),
            Y.SinP4A7032());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 SinP4A7384() => new Vector2I2F30(
            X.SinP4A7384(),
            Y.SinP4A7384());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 SinP5A51472() => new Vector2I2F30(
            X.SinP5A51472(),
            Y.SinP5A51472());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 SinP5A51437() => new Vector2I2F30(
            X.SinP5A51437(),
            Y.SinP5A51437());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 CosP2() => new Vector2I2F30(
            X.CosP2(),
            Y.CosP2());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 CosP3A16384() => new Vector2I2F30(
            X.CosP3A16384(),
            Y.CosP3A16384());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 CosP4A7032() => new Vector2I2F30(
            X.CosP4A7032(),
            Y.CosP4A7032());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 CosP4A7384() => new Vector2I2F30(
            X.CosP4A7384(),
            Y.CosP4A7384());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 CosP5A51472() => new Vector2I2F30(
            X.CosP5A51472(),
            Y.CosP5A51472());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 CosP5A51437() => new Vector2I2F30(
            X.CosP5A51437(),
            Y.CosP5A51437());

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I17F15 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(X, X); }
        public Vector2I17F15 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(X, Y); }
        public Vector2I17F15 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Y, X); }
        public Vector2I17F15 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Y, Y); }
        public Vector3I17F15 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, X, X); }
        public Vector3I17F15 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, X, Y); }
        public Vector3I17F15 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Y, X); }
        public Vector3I17F15 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Y, Y); }
        public Vector3I17F15 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, X, X); }
        public Vector3I17F15 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, X, Y); }
        public Vector3I17F15 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Y, X); }
        public Vector3I17F15 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Y, Y); }
        public Vector4I17F15 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, X, X); }
        public Vector4I17F15 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, X, Y); }
        public Vector4I17F15 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Y, X); }
        public Vector4I17F15 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Y, Y); }
        public Vector4I17F15 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, X, X); }
        public Vector4I17F15 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, X, Y); }
        public Vector4I17F15 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Y, X); }
        public Vector4I17F15 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Y, Y); }
        public Vector4I17F15 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, X, X); }
        public Vector4I17F15 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, X, Y); }
        public Vector4I17F15 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Y, X); }
        public Vector4I17F15 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Y, Y); }
        public Vector4I17F15 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, X, X); }
        public Vector4I17F15 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, X, Y); }
        public Vector4I17F15 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Y, X); }
        public Vector4I17F15 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Y, Y); }

    }

    partial struct I17F15 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 SaturatingMul(Vector2I17F15 other) => other.SaturatingMul(this);
    }
}
