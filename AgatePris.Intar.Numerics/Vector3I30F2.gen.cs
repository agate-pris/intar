using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I30F2
    : IEquatable<Vector3I30F2>
    , IFormattable
    , IVector<U62F2, I62F2, U31F1, I31F1>
    , IVectorComponentRespective<I30F2> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I30F2 X;
        public I30F2 Y;
        public I30F2 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(I30F2 x, I30F2 y, I30F2 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(I30F2 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(I30F2 x, Vector2I30F2 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(Vector3I30F2 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2(Vector2I30F2 xy, I30F2 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I30F2 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I30F2(I30F2.Zero);
        }
        public static Vector3I30F2 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I30F2(I30F2.One);
        }
        public static Vector3I30F2 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I30F2(I30F2.One, I30F2.Zero, I30F2.Zero);
        }
        public static Vector3I30F2 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I30F2(I30F2.Zero, I30F2.One, I30F2.Zero);
        }
        public static Vector3I30F2 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I30F2(I30F2.Zero, I30F2.Zero, I30F2.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator +(Vector3I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator -(Vector3I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator *(Vector3I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator *(Vector3I30F2 a, I30F2 b) => new Vector3I30F2(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator *(I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator /(Vector3I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator /(Vector3I30F2 a, I30F2 b) => new Vector3I30F2(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I30F2 operator /(I30F2 a, Vector3I30F2 b) => new Vector3I30F2(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I30F2 lhs, Vector3I30F2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I30F2 lhs, Vector3I30F2 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I30F2 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector3I30F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I30F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I30F2 other)
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
        public Vector3I30F2 Min(Vector3I30F2 other) => new Vector3I30F2(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2 Max(Vector3I30F2 other) => new Vector3I30F2(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2 Abs() => new Vector3I30F2(
            X.Abs(),
            Y.Abs(),
            Z.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2 Half() => new Vector3I30F2(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2 Twice() => new Vector3I30F2(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2 Clamp(I30F2 min, I30F2 max) => new Vector3I30F2(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2 Clamp(
            Vector3I30F2 min, Vector3I30F2 max
        ) => new Vector3I30F2(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2 WrappingAdd(Vector3I30F2 other) => new Vector3I30F2(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2 WrappingSub(Vector3I30F2 other) => new Vector3I30F2(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2 WrappingMul(Vector3I30F2 other) => new Vector3I30F2(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2 WrappingAddUnsigned(Vector3U30F2 other) => new Vector3I30F2(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2 WrappingSubUnsigned(Vector3U30F2 other) => new Vector3I30F2(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U30F2 UnsignedAbs() => new Vector3U30F2(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2 SaturatingAdd(Vector3I30F2 other) => new Vector3I30F2(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2 SaturatingMul(I30F2 other) => new Vector3I30F2(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CrossInternal(Vector3I30F2 other, out long x, out long y, out long z) {
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
        public Vector3I30F2 Cross(Vector3I30F2 other) {
            const long k = 1L << 2;
            CrossInternal(other, out var x, out var y, out var z);
            return new Vector3I30F2(
                I30F2.FromBits((int)(x / k)),
                I30F2.FromBits((int)(y / k)),
                I30F2.FromBits((int)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2 SaturatingCross(Vector3I30F2 other) {
            const long k = 1L << 2;
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
            return new Vector3I30F2(
                I30F2.FromBits((int)x),
                I30F2.FromBits((int)y),
                I30F2.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector3I30F2 other) {
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
        public I30F2 Dot(Vector3I30F2 other) {
            const long k = 1L << 0;
            return I30F2.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I30F2 SaturatingDot(Vector3I30F2 other) {
            const long k = 1L << 0;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I30F2.MaxValue;
            } else if (bits < int.MinValue) {
                return I30F2.MinValue;
            } else {
                return I30F2.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U62F2 LengthSquaredUnsigned() => U62F2.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I62F2 LengthSquaredSigned() => I62F2.FromBits(
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
        public I62F2 LengthSquared() => LengthSquaredSigned();

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
        public U30F2 LengthHalfUnsigned() => U30F2.FromBits(LengthInternal());

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
        public I30F2 LengthHalf() => I30F2.FromBits(checked((int)LengthInternal()));

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
        /// <seealso cref="LengthHalf"/>
        /// <seealso cref="LengthUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I31F1 LengthSigned() => I31F1.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I31F1 Length() => LengthSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I30F2? Normalize() {
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

            const ulong k = 1UL << 1;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);

            return new Vector3I30F2(
                I30F2.FromBits(b0 ? -y0 : y0),
                I30F2.FromBits(b1 ? -y1 : y1),
                I30F2.FromBits(b2 ? -y2 : y2));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 XX() => new Vector2I30F2(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 XY() => new Vector2I30F2(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 XZ() => new Vector2I30F2(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 YX() => new Vector2I30F2(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 YY() => new Vector2I30F2(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 YZ() => new Vector2I30F2(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 ZX() => new Vector2I30F2(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 ZY() => new Vector2I30F2(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 ZZ() => new Vector2I30F2(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XXX() => new Vector3I30F2(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XXY() => new Vector3I30F2(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XXZ() => new Vector3I30F2(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XYX() => new Vector3I30F2(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XYY() => new Vector3I30F2(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XYZ() => new Vector3I30F2(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XZX() => new Vector3I30F2(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XZY() => new Vector3I30F2(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XZZ() => new Vector3I30F2(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YXX() => new Vector3I30F2(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YXY() => new Vector3I30F2(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YXZ() => new Vector3I30F2(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YYX() => new Vector3I30F2(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YYY() => new Vector3I30F2(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YYZ() => new Vector3I30F2(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YZX() => new Vector3I30F2(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YZY() => new Vector3I30F2(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YZZ() => new Vector3I30F2(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZXX() => new Vector3I30F2(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZXY() => new Vector3I30F2(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZXZ() => new Vector3I30F2(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZYX() => new Vector3I30F2(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZYY() => new Vector3I30F2(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZYZ() => new Vector3I30F2(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZZX() => new Vector3I30F2(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZZY() => new Vector3I30F2(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZZZ() => new Vector3I30F2(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXXX() => new Vector4I30F2(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXXY() => new Vector4I30F2(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXXZ() => new Vector4I30F2(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXYX() => new Vector4I30F2(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXYY() => new Vector4I30F2(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXYZ() => new Vector4I30F2(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXZX() => new Vector4I30F2(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXZY() => new Vector4I30F2(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXZZ() => new Vector4I30F2(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYXX() => new Vector4I30F2(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYXY() => new Vector4I30F2(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYXZ() => new Vector4I30F2(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYYX() => new Vector4I30F2(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYYY() => new Vector4I30F2(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYYZ() => new Vector4I30F2(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYZX() => new Vector4I30F2(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYZY() => new Vector4I30F2(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYZZ() => new Vector4I30F2(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZXX() => new Vector4I30F2(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZXY() => new Vector4I30F2(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZXZ() => new Vector4I30F2(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZYX() => new Vector4I30F2(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZYY() => new Vector4I30F2(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZYZ() => new Vector4I30F2(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZZX() => new Vector4I30F2(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZZY() => new Vector4I30F2(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZZZ() => new Vector4I30F2(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXXX() => new Vector4I30F2(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXXY() => new Vector4I30F2(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXXZ() => new Vector4I30F2(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXYX() => new Vector4I30F2(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXYY() => new Vector4I30F2(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXYZ() => new Vector4I30F2(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXZX() => new Vector4I30F2(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXZY() => new Vector4I30F2(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXZZ() => new Vector4I30F2(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYXX() => new Vector4I30F2(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYXY() => new Vector4I30F2(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYXZ() => new Vector4I30F2(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYYX() => new Vector4I30F2(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYYY() => new Vector4I30F2(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYYZ() => new Vector4I30F2(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYZX() => new Vector4I30F2(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYZY() => new Vector4I30F2(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYZZ() => new Vector4I30F2(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZXX() => new Vector4I30F2(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZXY() => new Vector4I30F2(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZXZ() => new Vector4I30F2(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZYX() => new Vector4I30F2(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZYY() => new Vector4I30F2(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZYZ() => new Vector4I30F2(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZZX() => new Vector4I30F2(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZZY() => new Vector4I30F2(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZZZ() => new Vector4I30F2(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXXX() => new Vector4I30F2(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXXY() => new Vector4I30F2(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXXZ() => new Vector4I30F2(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXYX() => new Vector4I30F2(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXYY() => new Vector4I30F2(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXYZ() => new Vector4I30F2(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXZX() => new Vector4I30F2(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXZY() => new Vector4I30F2(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXZZ() => new Vector4I30F2(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYXX() => new Vector4I30F2(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYXY() => new Vector4I30F2(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYXZ() => new Vector4I30F2(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYYX() => new Vector4I30F2(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYYY() => new Vector4I30F2(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYYZ() => new Vector4I30F2(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYZX() => new Vector4I30F2(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYZY() => new Vector4I30F2(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYZZ() => new Vector4I30F2(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZXX() => new Vector4I30F2(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZXY() => new Vector4I30F2(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZXZ() => new Vector4I30F2(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZYX() => new Vector4I30F2(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZYY() => new Vector4I30F2(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZYZ() => new Vector4I30F2(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZZX() => new Vector4I30F2(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZZY() => new Vector4I30F2(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZZZ() => new Vector4I30F2(Z, Z, Z, Z);

    }
}
