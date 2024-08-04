using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I17F15
    : IEquatable<Vector3I17F15>
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
        public I17F15 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15(I17F15 x, I17F15 y, I17F15 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15(I17F15 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15(I17F15 x, Vector2I17F15 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15(Vector3I17F15 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15(Vector2I17F15 xy, I17F15 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I17F15 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I17F15(I17F15.Zero);
        }
        public static Vector3I17F15 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I17F15(I17F15.One);
        }
        public static Vector3I17F15 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I17F15(I17F15.One, I17F15.Zero, I17F15.Zero);
        }
        public static Vector3I17F15 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I17F15(I17F15.Zero, I17F15.One, I17F15.Zero);
        }
        public static Vector3I17F15 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I17F15(I17F15.Zero, I17F15.Zero, I17F15.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator +(Vector3I17F15 a, Vector3I17F15 b) => new Vector3I17F15(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator -(Vector3I17F15 a, Vector3I17F15 b) => new Vector3I17F15(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator *(Vector3I17F15 a, Vector3I17F15 b) => new Vector3I17F15(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator *(Vector3I17F15 a, I17F15 b) => new Vector3I17F15(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator *(I17F15 a, Vector3I17F15 b) => new Vector3I17F15(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator /(Vector3I17F15 a, Vector3I17F15 b) => new Vector3I17F15(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator /(Vector3I17F15 a, I17F15 b) => new Vector3I17F15(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator /(I17F15 a, Vector3I17F15 b) => new Vector3I17F15(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I17F15 lhs, Vector3I17F15 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I17F15 lhs, Vector3I17F15 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I17F15 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                switch (index) {
                    case 0: return X;
                    case 1: return Y;
                    case 2: return Z;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                switch (index) {
                    case 0: X = value; break;
                    case 1: Y = value; break;
                    case 2: Z = value; break;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
        }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3I17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I17F15 other)
            => other.X == X
            && other.Y == Y
            && other.Z == Z;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            var z = Z.ToString(format, formatProvider);
            return $"<{x}, {y}, {z}>";
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 Min(Vector3I17F15 other) => new Vector3I17F15(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 Max(Vector3I17F15 other) => new Vector3I17F15(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 Abs() => new Vector3I17F15(
            X.Abs(),
            Y.Abs(),
            Z.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 Half() => new Vector3I17F15(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 Twice() => new Vector3I17F15(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 Clamp(I17F15 min, I17F15 max) => new Vector3I17F15(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 Clamp(
            Vector3I17F15 min, Vector3I17F15 max
        ) => new Vector3I17F15(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 WrappingAdd(Vector3I17F15 other) => new Vector3I17F15(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 WrappingSub(Vector3I17F15 other) => new Vector3I17F15(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 WrappingMul(Vector3I17F15 other) => new Vector3I17F15(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 WrappingAddUnsigned(Vector3U17F15 other) => new Vector3I17F15(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 WrappingSubUnsigned(Vector3U17F15 other) => new Vector3I17F15(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U17F15 UnsignedAbs() => new Vector3U17F15(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 SaturatingAdd(Vector3I17F15 other) => new Vector3I17F15(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 SaturatingMul(I17F15 other) => new Vector3I17F15(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CrossInternal(Vector3I17F15 other, out long x, out long y, out long z) {
            var ax = (long)X.Bits;
            var ay = (long)Y.Bits;
            var az = (long)Z.Bits;
            var bx = (long)other.X.Bits;
            var by = (long)other.Y.Bits;
            var bz = (long)other.Z.Bits;

            x = (ay * bz) - (az * by);
            y = (az * bx) - (ax * bz);
            z = (ax * by) - (ay * bx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 Cross(Vector3I17F15 other) {
            const long k = 1L << 15;
            CrossInternal(other, out var x, out var y, out var z);
            return new Vector3I17F15(
                I17F15.FromBits((int)(x / k)),
                I17F15.FromBits((int)(y / k)),
                I17F15.FromBits((int)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 SaturatingCross(Vector3I17F15 other) {
            const long k = 1L << 15;
            CrossInternal(other, out var x, out var y, out var z);
            x /= k;
            if (x > int.MaxValue) {
                x = int.MaxValue;
            } else if (x < int.MinValue) {
                x = int.MinValue;
            }
            y /= k;
            if (y > int.MaxValue) {
                y = int.MaxValue;
            } else if (y < int.MinValue) {
                y = int.MinValue;
            }
            z /= k;
            if (z > int.MaxValue) {
                z = int.MaxValue;
            } else if (z < int.MinValue) {
                z = int.MinValue;
            }
            return new Vector3I17F15(
                I17F15.FromBits((int)x),
                I17F15.FromBits((int)y),
                I17F15.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector3I17F15 other) {
            var x = ((long)X.Bits) * other.X.Bits;
            var y = ((long)Y.Bits) * other.Y.Bits;
            var z = ((long)Z.Bits) * other.Z.Bits;

            // オーバーフローを避けるため､ 事前に除算する｡
            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算に合わせて常に 4 で除算する｡
            return
                (x / 4) +
                (y / 4) +
                (z / 4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15 Dot(Vector3I17F15 other) {
            const long k = 1L << 13;
            return I17F15.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15 SaturatingDot(Vector3I17F15 other) {
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
        public Vector3I17F15? Normalize() {
            var x0 = X.Bits;
            var x1 = Y.Bits;
            var x2 = Z.Bits;
            var b0 = x0 < 0;
            var b1 = x1 < 0;
            var b2 = x2 < 0;
            var a0 = unchecked((uint)(b0 ? Overflowing.WrappingNeg(x0) : x0));
            var a1 = unchecked((uint)(b1 ? Overflowing.WrappingNeg(x1) : x1));
            var a2 = unchecked((uint)(b2 ? Overflowing.WrappingNeg(x2) : x2));

            var max = a0.Max(a1).Max(a2);
            if (max == 0) {
                return null;
            }

            ulong m = uint.MaxValue / max;
            var l0 = m * a0;
            var l1 = m * a1;
            var l2 = m * a2;
            var sum =
                (l0 * l0 / 4) +
                (l1 * l1 / 4) +
                (l2 * l2 / 4);
            var ll = Mathi.Sqrt(sum);

            const ulong k = 1UL << 14;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);

            return new Vector3I17F15(
                I17F15.FromBits(b0 ? -y0 : y0),
                I17F15.FromBits(b1 ? -y1 : y1),
                I17F15.FromBits(b2 ? -y2 : y2));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 SinP2() => new Vector3I2F30(
            X.SinP2(),
            Y.SinP2(),
            Z.SinP2());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 SinP3A16384() => new Vector3I2F30(
            X.SinP3A16384(),
            Y.SinP3A16384(),
            Z.SinP3A16384());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 SinP4A7032() => new Vector3I2F30(
            X.SinP4A7032(),
            Y.SinP4A7032(),
            Z.SinP4A7032());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 SinP4A7384() => new Vector3I2F30(
            X.SinP4A7384(),
            Y.SinP4A7384(),
            Z.SinP4A7384());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 SinP5A51472() => new Vector3I2F30(
            X.SinP5A51472(),
            Y.SinP5A51472(),
            Z.SinP5A51472());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 SinP5A51437() => new Vector3I2F30(
            X.SinP5A51437(),
            Y.SinP5A51437(),
            Z.SinP5A51437());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 CosP2() => new Vector3I2F30(
            X.CosP2(),
            Y.CosP2(),
            Z.CosP2());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 CosP3A16384() => new Vector3I2F30(
            X.CosP3A16384(),
            Y.CosP3A16384(),
            Z.CosP3A16384());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 CosP4A7032() => new Vector3I2F30(
            X.CosP4A7032(),
            Y.CosP4A7032(),
            Z.CosP4A7032());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 CosP4A7384() => new Vector3I2F30(
            X.CosP4A7384(),
            Y.CosP4A7384(),
            Z.CosP4A7384());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 CosP5A51472() => new Vector3I2F30(
            X.CosP5A51472(),
            Y.CosP5A51472(),
            Z.CosP5A51472());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 CosP5A51437() => new Vector3I2F30(
            X.CosP5A51437(),
            Y.CosP5A51437(),
            Z.CosP5A51437());

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I17F15 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(X, X); }
        public Vector2I17F15 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(X, Y); }
        public Vector2I17F15 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(X, Z); }
        public Vector2I17F15 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Y, X); }
        public Vector2I17F15 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Y, Y); }
        public Vector2I17F15 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Y, Z); }
        public Vector2I17F15 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Z, X); }
        public Vector2I17F15 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Z, Y); }
        public Vector2I17F15 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I17F15(Z, Z); }
        public Vector3I17F15 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, X, X); }
        public Vector3I17F15 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, X, Y); }
        public Vector3I17F15 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, X, Z); }
        public Vector3I17F15 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Y, X); }
        public Vector3I17F15 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Y, Y); }
        public Vector3I17F15 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Y, Z); }
        public Vector3I17F15 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Z, X); }
        public Vector3I17F15 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Z, Y); }
        public Vector3I17F15 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(X, Z, Z); }
        public Vector3I17F15 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, X, X); }
        public Vector3I17F15 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, X, Y); }
        public Vector3I17F15 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, X, Z); }
        public Vector3I17F15 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Y, X); }
        public Vector3I17F15 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Y, Y); }
        public Vector3I17F15 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Y, Z); }
        public Vector3I17F15 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Z, X); }
        public Vector3I17F15 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Z, Y); }
        public Vector3I17F15 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Y, Z, Z); }
        public Vector3I17F15 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, X, X); }
        public Vector3I17F15 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, X, Y); }
        public Vector3I17F15 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, X, Z); }
        public Vector3I17F15 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, Y, X); }
        public Vector3I17F15 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, Y, Y); }
        public Vector3I17F15 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, Y, Z); }
        public Vector3I17F15 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, Z, X); }
        public Vector3I17F15 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, Z, Y); }
        public Vector3I17F15 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I17F15(Z, Z, Z); }
        public Vector4I17F15 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, X, X); }
        public Vector4I17F15 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, X, Y); }
        public Vector4I17F15 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, X, Z); }
        public Vector4I17F15 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Y, X); }
        public Vector4I17F15 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Y, Y); }
        public Vector4I17F15 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Y, Z); }
        public Vector4I17F15 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Z, X); }
        public Vector4I17F15 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Z, Y); }
        public Vector4I17F15 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, X, Z, Z); }
        public Vector4I17F15 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, X, X); }
        public Vector4I17F15 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, X, Y); }
        public Vector4I17F15 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, X, Z); }
        public Vector4I17F15 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Y, X); }
        public Vector4I17F15 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Y, Y); }
        public Vector4I17F15 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Y, Z); }
        public Vector4I17F15 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Z, X); }
        public Vector4I17F15 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Z, Y); }
        public Vector4I17F15 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Y, Z, Z); }
        public Vector4I17F15 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, X, X); }
        public Vector4I17F15 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, X, Y); }
        public Vector4I17F15 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, X, Z); }
        public Vector4I17F15 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, Y, X); }
        public Vector4I17F15 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, Y, Y); }
        public Vector4I17F15 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, Y, Z); }
        public Vector4I17F15 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, Z, X); }
        public Vector4I17F15 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, Z, Y); }
        public Vector4I17F15 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(X, Z, Z, Z); }
        public Vector4I17F15 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, X, X); }
        public Vector4I17F15 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, X, Y); }
        public Vector4I17F15 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, X, Z); }
        public Vector4I17F15 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Y, X); }
        public Vector4I17F15 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Y, Y); }
        public Vector4I17F15 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Y, Z); }
        public Vector4I17F15 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Z, X); }
        public Vector4I17F15 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Z, Y); }
        public Vector4I17F15 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, X, Z, Z); }
        public Vector4I17F15 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, X, X); }
        public Vector4I17F15 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, X, Y); }
        public Vector4I17F15 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, X, Z); }
        public Vector4I17F15 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Y, X); }
        public Vector4I17F15 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Y, Y); }
        public Vector4I17F15 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Y, Z); }
        public Vector4I17F15 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Z, X); }
        public Vector4I17F15 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Z, Y); }
        public Vector4I17F15 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Y, Z, Z); }
        public Vector4I17F15 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, X, X); }
        public Vector4I17F15 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, X, Y); }
        public Vector4I17F15 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, X, Z); }
        public Vector4I17F15 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, Y, X); }
        public Vector4I17F15 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, Y, Y); }
        public Vector4I17F15 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, Y, Z); }
        public Vector4I17F15 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, Z, X); }
        public Vector4I17F15 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, Z, Y); }
        public Vector4I17F15 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Y, Z, Z, Z); }
        public Vector4I17F15 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, X, X); }
        public Vector4I17F15 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, X, Y); }
        public Vector4I17F15 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, X, Z); }
        public Vector4I17F15 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, Y, X); }
        public Vector4I17F15 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, Y, Y); }
        public Vector4I17F15 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, Y, Z); }
        public Vector4I17F15 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, Z, X); }
        public Vector4I17F15 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, Z, Y); }
        public Vector4I17F15 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, X, Z, Z); }
        public Vector4I17F15 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, X, X); }
        public Vector4I17F15 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, X, Y); }
        public Vector4I17F15 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, X, Z); }
        public Vector4I17F15 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, Y, X); }
        public Vector4I17F15 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, Y, Y); }
        public Vector4I17F15 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, Y, Z); }
        public Vector4I17F15 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, Z, X); }
        public Vector4I17F15 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, Z, Y); }
        public Vector4I17F15 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Y, Z, Z); }
        public Vector4I17F15 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, X, X); }
        public Vector4I17F15 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, X, Y); }
        public Vector4I17F15 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, X, Z); }
        public Vector4I17F15 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, Y, X); }
        public Vector4I17F15 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, Y, Y); }
        public Vector4I17F15 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, Y, Z); }
        public Vector4I17F15 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, Z, X); }
        public Vector4I17F15 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, Z, Y); }
        public Vector4I17F15 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I17F15(Z, Z, Z, Z); }

    }
}
