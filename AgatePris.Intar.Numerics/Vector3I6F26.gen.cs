using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I6F26
    : IEquatable<Vector3I6F26>
    , IFormattable
    , IVector<U14F50, I14F50, U7F25, I7F25>
    , IVectorComponentRespective<I6F26> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I6F26 X;
        public I6F26 Y;
        public I6F26 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26(I6F26 x, I6F26 y, I6F26 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26(I6F26 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26(I6F26 x, Vector2I6F26 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26(Vector3I6F26 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26(Vector2I6F26 xy, I6F26 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I6F26 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I6F26(I6F26.Zero);
        }
        public static Vector3I6F26 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I6F26(I6F26.One);
        }
        public static Vector3I6F26 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I6F26(I6F26.One, I6F26.Zero, I6F26.Zero);
        }
        public static Vector3I6F26 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I6F26(I6F26.Zero, I6F26.One, I6F26.Zero);
        }
        public static Vector3I6F26 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I6F26(I6F26.Zero, I6F26.Zero, I6F26.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 operator +(Vector3I6F26 a, Vector3I6F26 b) => new Vector3I6F26(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 operator -(Vector3I6F26 a, Vector3I6F26 b) => new Vector3I6F26(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 operator *(Vector3I6F26 a, Vector3I6F26 b) => new Vector3I6F26(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 operator *(Vector3I6F26 a, I6F26 b) => new Vector3I6F26(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 operator *(I6F26 a, Vector3I6F26 b) => new Vector3I6F26(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 operator /(Vector3I6F26 a, Vector3I6F26 b) => new Vector3I6F26(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 operator /(Vector3I6F26 a, I6F26 b) => new Vector3I6F26(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I6F26 operator /(I6F26 a, Vector3I6F26 b) => new Vector3I6F26(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I6F26 lhs, Vector3I6F26 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I6F26 lhs, Vector3I6F26 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I6F26 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector3I6F26 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I6F26>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I6F26 other)
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
        public Vector3I6F26 Min(Vector3I6F26 other) => new Vector3I6F26(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26 Max(Vector3I6F26 other) => new Vector3I6F26(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26 Abs() => new Vector3I6F26(
            X.Abs(),
            Y.Abs(),
            Z.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26 Half() => new Vector3I6F26(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26 Twice() => new Vector3I6F26(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26 Clamp(I6F26 min, I6F26 max) => new Vector3I6F26(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26 Clamp(
            Vector3I6F26 min, Vector3I6F26 max
        ) => new Vector3I6F26(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26 WrappingAdd(Vector3I6F26 other) => new Vector3I6F26(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26 WrappingSub(Vector3I6F26 other) => new Vector3I6F26(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26 WrappingMul(Vector3I6F26 other) => new Vector3I6F26(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26 WrappingAddUnsigned(Vector3U6F26 other) => new Vector3I6F26(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26 WrappingSubUnsigned(Vector3U6F26 other) => new Vector3I6F26(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U6F26 UnsignedAbs() => new Vector3U6F26(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26 SaturatingAdd(Vector3I6F26 other) => new Vector3I6F26(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26 SaturatingMul(I6F26 other) => new Vector3I6F26(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CrossInternal(Vector3I6F26 other, out long x, out long y, out long z) {
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
        public Vector3I6F26 Cross(Vector3I6F26 other) {
            const long k = 1L << 26;
            CrossInternal(other, out var x, out var y, out var z);
            return new Vector3I6F26(
                I6F26.FromBits((int)(x / k)),
                I6F26.FromBits((int)(y / k)),
                I6F26.FromBits((int)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26 SaturatingCross(Vector3I6F26 other) {
            const long k = 1L << 26;
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
            return new Vector3I6F26(
                I6F26.FromBits((int)x),
                I6F26.FromBits((int)y),
                I6F26.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector3I6F26 other) {
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
        public I6F26 Dot(Vector3I6F26 other) {
            const long k = 1L << 24;
            return I6F26.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I6F26 SaturatingDot(Vector3I6F26 other) {
            const long k = 1L << 24;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I6F26.MaxValue;
            } else if (bits < int.MinValue) {
                return I6F26.MinValue;
            } else {
                return I6F26.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U14F50 LengthSquaredUnsigned() => U14F50.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I14F50 LengthSquaredSigned() => I14F50.FromBits(
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
        public I14F50 LengthSquared() => LengthSquaredSigned();

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
        public U6F26 LengthHalfUnsigned() => U6F26.FromBits(LengthInternal());

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
        public I6F26 LengthHalf() => I6F26.FromBits(checked((int)LengthInternal()));

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
        public U7F25 LengthUnsigned() => U7F25.FromBits(LengthInternal());

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
        public I7F25 LengthSigned() => I7F25.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I7F25 Length() => LengthSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I6F26? Normalize() {
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

            const ulong k = 1UL << 25;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);

            return new Vector3I6F26(
                I6F26.FromBits(b0 ? -y0 : y0),
                I6F26.FromBits(b1 ? -y1 : y1),
                I6F26.FromBits(b2 ? -y2 : y2));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I6F26 XX() => new Vector2I6F26(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I6F26 XY() => new Vector2I6F26(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I6F26 XZ() => new Vector2I6F26(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I6F26 YX() => new Vector2I6F26(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I6F26 YY() => new Vector2I6F26(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I6F26 YZ() => new Vector2I6F26(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I6F26 ZX() => new Vector2I6F26(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I6F26 ZY() => new Vector2I6F26(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I6F26 ZZ() => new Vector2I6F26(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 XXX() => new Vector3I6F26(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 XXY() => new Vector3I6F26(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 XXZ() => new Vector3I6F26(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 XYX() => new Vector3I6F26(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 XYY() => new Vector3I6F26(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 XYZ() => new Vector3I6F26(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 XZX() => new Vector3I6F26(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 XZY() => new Vector3I6F26(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 XZZ() => new Vector3I6F26(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 YXX() => new Vector3I6F26(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 YXY() => new Vector3I6F26(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 YXZ() => new Vector3I6F26(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 YYX() => new Vector3I6F26(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 YYY() => new Vector3I6F26(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 YYZ() => new Vector3I6F26(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 YZX() => new Vector3I6F26(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 YZY() => new Vector3I6F26(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 YZZ() => new Vector3I6F26(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 ZXX() => new Vector3I6F26(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 ZXY() => new Vector3I6F26(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 ZXZ() => new Vector3I6F26(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 ZYX() => new Vector3I6F26(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 ZYY() => new Vector3I6F26(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 ZYZ() => new Vector3I6F26(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 ZZX() => new Vector3I6F26(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 ZZY() => new Vector3I6F26(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I6F26 ZZZ() => new Vector3I6F26(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XXXX() => new Vector4I6F26(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XXXY() => new Vector4I6F26(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XXXZ() => new Vector4I6F26(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XXYX() => new Vector4I6F26(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XXYY() => new Vector4I6F26(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XXYZ() => new Vector4I6F26(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XXZX() => new Vector4I6F26(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XXZY() => new Vector4I6F26(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XXZZ() => new Vector4I6F26(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XYXX() => new Vector4I6F26(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XYXY() => new Vector4I6F26(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XYXZ() => new Vector4I6F26(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XYYX() => new Vector4I6F26(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XYYY() => new Vector4I6F26(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XYYZ() => new Vector4I6F26(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XYZX() => new Vector4I6F26(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XYZY() => new Vector4I6F26(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XYZZ() => new Vector4I6F26(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XZXX() => new Vector4I6F26(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XZXY() => new Vector4I6F26(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XZXZ() => new Vector4I6F26(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XZYX() => new Vector4I6F26(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XZYY() => new Vector4I6F26(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XZYZ() => new Vector4I6F26(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XZZX() => new Vector4I6F26(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XZZY() => new Vector4I6F26(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 XZZZ() => new Vector4I6F26(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YXXX() => new Vector4I6F26(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YXXY() => new Vector4I6F26(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YXXZ() => new Vector4I6F26(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YXYX() => new Vector4I6F26(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YXYY() => new Vector4I6F26(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YXYZ() => new Vector4I6F26(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YXZX() => new Vector4I6F26(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YXZY() => new Vector4I6F26(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YXZZ() => new Vector4I6F26(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YYXX() => new Vector4I6F26(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YYXY() => new Vector4I6F26(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YYXZ() => new Vector4I6F26(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YYYX() => new Vector4I6F26(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YYYY() => new Vector4I6F26(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YYYZ() => new Vector4I6F26(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YYZX() => new Vector4I6F26(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YYZY() => new Vector4I6F26(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YYZZ() => new Vector4I6F26(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YZXX() => new Vector4I6F26(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YZXY() => new Vector4I6F26(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YZXZ() => new Vector4I6F26(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YZYX() => new Vector4I6F26(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YZYY() => new Vector4I6F26(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YZYZ() => new Vector4I6F26(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YZZX() => new Vector4I6F26(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YZZY() => new Vector4I6F26(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 YZZZ() => new Vector4I6F26(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZXXX() => new Vector4I6F26(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZXXY() => new Vector4I6F26(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZXXZ() => new Vector4I6F26(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZXYX() => new Vector4I6F26(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZXYY() => new Vector4I6F26(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZXYZ() => new Vector4I6F26(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZXZX() => new Vector4I6F26(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZXZY() => new Vector4I6F26(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZXZZ() => new Vector4I6F26(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZYXX() => new Vector4I6F26(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZYXY() => new Vector4I6F26(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZYXZ() => new Vector4I6F26(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZYYX() => new Vector4I6F26(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZYYY() => new Vector4I6F26(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZYYZ() => new Vector4I6F26(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZYZX() => new Vector4I6F26(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZYZY() => new Vector4I6F26(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZYZZ() => new Vector4I6F26(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZZXX() => new Vector4I6F26(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZZXY() => new Vector4I6F26(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZZXZ() => new Vector4I6F26(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZZYX() => new Vector4I6F26(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZZYY() => new Vector4I6F26(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZZYZ() => new Vector4I6F26(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZZZX() => new Vector4I6F26(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZZZY() => new Vector4I6F26(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I6F26 ZZZZ() => new Vector4I6F26(Z, Z, Z, Z);

    }
}
