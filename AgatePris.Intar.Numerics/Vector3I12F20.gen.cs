using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I12F20
    : IEquatable<Vector3I12F20>
    , IFormattable
    , IVector<U26F38, I26F38, U13F19, I13F19>
    , IVectorComponentRespective<I12F20> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I12F20 X;
        public I12F20 Y;
        public I12F20 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20(I12F20 x, I12F20 y, I12F20 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20(I12F20 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20(I12F20 x, Vector2I12F20 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20(Vector3I12F20 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20(Vector2I12F20 xy, I12F20 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I12F20 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I12F20(I12F20.Zero);
        }
        public static Vector3I12F20 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I12F20(I12F20.One);
        }
        public static Vector3I12F20 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I12F20(I12F20.One, I12F20.Zero, I12F20.Zero);
        }
        public static Vector3I12F20 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I12F20(I12F20.Zero, I12F20.One, I12F20.Zero);
        }
        public static Vector3I12F20 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I12F20(I12F20.Zero, I12F20.Zero, I12F20.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 operator +(Vector3I12F20 a, Vector3I12F20 b) => new Vector3I12F20(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 operator -(Vector3I12F20 a, Vector3I12F20 b) => new Vector3I12F20(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 operator *(Vector3I12F20 a, Vector3I12F20 b) => new Vector3I12F20(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 operator *(Vector3I12F20 a, I12F20 b) => new Vector3I12F20(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 operator *(I12F20 a, Vector3I12F20 b) => new Vector3I12F20(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 operator /(Vector3I12F20 a, Vector3I12F20 b) => new Vector3I12F20(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 operator /(Vector3I12F20 a, I12F20 b) => new Vector3I12F20(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I12F20 operator /(I12F20 a, Vector3I12F20 b) => new Vector3I12F20(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I12F20 lhs, Vector3I12F20 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I12F20 lhs, Vector3I12F20 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I12F20 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector3I12F20 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I12F20>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I12F20 other)
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
        public Vector3I12F20 Min(Vector3I12F20 other) => new Vector3I12F20(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20 Max(Vector3I12F20 other) => new Vector3I12F20(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20 Abs() => new Vector3I12F20(
            X.Abs(),
            Y.Abs(),
            Z.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20 Half() => new Vector3I12F20(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20 Twice() => new Vector3I12F20(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20 Clamp(I12F20 min, I12F20 max) => new Vector3I12F20(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20 Clamp(
            Vector3I12F20 min, Vector3I12F20 max
        ) => new Vector3I12F20(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20 WrappingAdd(Vector3I12F20 other) => new Vector3I12F20(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20 WrappingSub(Vector3I12F20 other) => new Vector3I12F20(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20 WrappingMul(Vector3I12F20 other) => new Vector3I12F20(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

#if AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20 WrappingAddUnsigned(Vector3U12F20 other) => new Vector3I12F20(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20 WrappingSubUnsigned(Vector3U12F20 other) => new Vector3I12F20(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U12F20 UnsignedAbs() => new Vector3U12F20(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs());

#endif // AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20 SaturatingAdd(Vector3I12F20 other) => new Vector3I12F20(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20 SaturatingMul(I12F20 other) => new Vector3I12F20(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CrossInternal(Vector3I12F20 other, out long x, out long y, out long z) {
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
        public Vector3I12F20 Cross(Vector3I12F20 other) {
            const long k = 1L << 20;
            CrossInternal(other, out var x, out var y, out var z);
            return new Vector3I12F20(
                I12F20.FromBits((int)(x / k)),
                I12F20.FromBits((int)(y / k)),
                I12F20.FromBits((int)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20 SaturatingCross(Vector3I12F20 other) {
            const long k = 1L << 20;
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
            return new Vector3I12F20(
                I12F20.FromBits((int)x),
                I12F20.FromBits((int)y),
                I12F20.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector3I12F20 other) {
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
        public I12F20 Dot(Vector3I12F20 other) {
            const long k = 1L << 18;
            return I12F20.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I12F20 SaturatingDot(Vector3I12F20 other) {
            const long k = 1L << 18;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I12F20.MaxValue;
            } else if (bits < int.MinValue) {
                return I12F20.MinValue;
            } else {
                return I12F20.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U26F38 LengthSquaredUnsigned() => U26F38.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I26F38 LengthSquaredSigned() => I26F38.FromBits(
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
        public I26F38 LengthSquared() => LengthSquaredSigned();

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
        public U12F20 LengthHalfUnsigned() => U12F20.FromBits(LengthInternal());

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
        public I12F20 LengthHalf() => I12F20.FromBits(checked((int)LengthInternal()));

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
        public U13F19 LengthUnsigned() => U13F19.FromBits(LengthInternal());

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
        public I13F19 LengthSigned() => I13F19.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I13F19 Length() => LengthSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I12F20? Normalize() {
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

            const ulong k = 1UL << 19;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);

            return new Vector3I12F20(
                I12F20.FromBits(b0 ? -y0 : y0),
                I12F20.FromBits(b1 ? -y1 : y1),
                I12F20.FromBits(b2 ? -y2 : y2));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 XX() => new Vector2I12F20(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 XY() => new Vector2I12F20(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 XZ() => new Vector2I12F20(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 YX() => new Vector2I12F20(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 YY() => new Vector2I12F20(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 YZ() => new Vector2I12F20(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 ZX() => new Vector2I12F20(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 ZY() => new Vector2I12F20(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 ZZ() => new Vector2I12F20(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XXX() => new Vector3I12F20(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XXY() => new Vector3I12F20(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XXZ() => new Vector3I12F20(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XYX() => new Vector3I12F20(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XYY() => new Vector3I12F20(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XYZ() => new Vector3I12F20(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XZX() => new Vector3I12F20(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XZY() => new Vector3I12F20(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XZZ() => new Vector3I12F20(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YXX() => new Vector3I12F20(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YXY() => new Vector3I12F20(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YXZ() => new Vector3I12F20(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YYX() => new Vector3I12F20(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YYY() => new Vector3I12F20(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YYZ() => new Vector3I12F20(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YZX() => new Vector3I12F20(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YZY() => new Vector3I12F20(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YZZ() => new Vector3I12F20(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZXX() => new Vector3I12F20(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZXY() => new Vector3I12F20(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZXZ() => new Vector3I12F20(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZYX() => new Vector3I12F20(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZYY() => new Vector3I12F20(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZYZ() => new Vector3I12F20(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZZX() => new Vector3I12F20(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZZY() => new Vector3I12F20(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZZZ() => new Vector3I12F20(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXXX() => new Vector4I12F20(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXXY() => new Vector4I12F20(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXXZ() => new Vector4I12F20(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXYX() => new Vector4I12F20(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXYY() => new Vector4I12F20(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXYZ() => new Vector4I12F20(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXZX() => new Vector4I12F20(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXZY() => new Vector4I12F20(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXZZ() => new Vector4I12F20(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYXX() => new Vector4I12F20(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYXY() => new Vector4I12F20(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYXZ() => new Vector4I12F20(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYYX() => new Vector4I12F20(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYYY() => new Vector4I12F20(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYYZ() => new Vector4I12F20(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYZX() => new Vector4I12F20(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYZY() => new Vector4I12F20(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYZZ() => new Vector4I12F20(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZXX() => new Vector4I12F20(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZXY() => new Vector4I12F20(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZXZ() => new Vector4I12F20(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZYX() => new Vector4I12F20(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZYY() => new Vector4I12F20(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZYZ() => new Vector4I12F20(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZZX() => new Vector4I12F20(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZZY() => new Vector4I12F20(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZZZ() => new Vector4I12F20(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXXX() => new Vector4I12F20(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXXY() => new Vector4I12F20(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXXZ() => new Vector4I12F20(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXYX() => new Vector4I12F20(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXYY() => new Vector4I12F20(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXYZ() => new Vector4I12F20(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXZX() => new Vector4I12F20(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXZY() => new Vector4I12F20(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXZZ() => new Vector4I12F20(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYXX() => new Vector4I12F20(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYXY() => new Vector4I12F20(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYXZ() => new Vector4I12F20(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYYX() => new Vector4I12F20(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYYY() => new Vector4I12F20(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYYZ() => new Vector4I12F20(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYZX() => new Vector4I12F20(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYZY() => new Vector4I12F20(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYZZ() => new Vector4I12F20(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZXX() => new Vector4I12F20(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZXY() => new Vector4I12F20(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZXZ() => new Vector4I12F20(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZYX() => new Vector4I12F20(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZYY() => new Vector4I12F20(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZYZ() => new Vector4I12F20(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZZX() => new Vector4I12F20(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZZY() => new Vector4I12F20(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZZZ() => new Vector4I12F20(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXXX() => new Vector4I12F20(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXXY() => new Vector4I12F20(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXXZ() => new Vector4I12F20(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXYX() => new Vector4I12F20(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXYY() => new Vector4I12F20(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXYZ() => new Vector4I12F20(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXZX() => new Vector4I12F20(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXZY() => new Vector4I12F20(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXZZ() => new Vector4I12F20(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYXX() => new Vector4I12F20(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYXY() => new Vector4I12F20(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYXZ() => new Vector4I12F20(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYYX() => new Vector4I12F20(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYYY() => new Vector4I12F20(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYYZ() => new Vector4I12F20(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYZX() => new Vector4I12F20(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYZY() => new Vector4I12F20(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYZZ() => new Vector4I12F20(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZXX() => new Vector4I12F20(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZXY() => new Vector4I12F20(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZXZ() => new Vector4I12F20(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZYX() => new Vector4I12F20(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZYY() => new Vector4I12F20(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZYZ() => new Vector4I12F20(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZZX() => new Vector4I12F20(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZZY() => new Vector4I12F20(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZZZ() => new Vector4I12F20(Z, Z, Z, Z);

    }
}
