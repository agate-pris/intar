using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3I10F22
    : IEquatable<Vector3I10F22>
    , IFormattable
    , IVector<U22F42, I22F42, U11F21, I11F21>
    , IVectorComponentRespective<I10F22> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I10F22 X;
        public I10F22 Y;
        public I10F22 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22(I10F22 x, I10F22 y, I10F22 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22(I10F22 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22(I10F22 x, Vector2I10F22 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22(Vector3I10F22 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22(Vector2I10F22 xy, I10F22 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3I10F22 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I10F22(I10F22.Zero);
        }
        public static Vector3I10F22 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I10F22(I10F22.One);
        }
        public static Vector3I10F22 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I10F22(I10F22.One, I10F22.Zero, I10F22.Zero);
        }
        public static Vector3I10F22 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I10F22(I10F22.Zero, I10F22.One, I10F22.Zero);
        }
        public static Vector3I10F22 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I10F22(I10F22.Zero, I10F22.Zero, I10F22.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 operator +(Vector3I10F22 a, Vector3I10F22 b) => new Vector3I10F22(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 operator -(Vector3I10F22 a, Vector3I10F22 b) => new Vector3I10F22(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 operator *(Vector3I10F22 a, Vector3I10F22 b) => new Vector3I10F22(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 operator *(Vector3I10F22 a, I10F22 b) => new Vector3I10F22(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 operator *(I10F22 a, Vector3I10F22 b) => new Vector3I10F22(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 operator /(Vector3I10F22 a, Vector3I10F22 b) => new Vector3I10F22(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 operator /(Vector3I10F22 a, I10F22 b) => new Vector3I10F22(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I10F22 operator /(I10F22 a, Vector3I10F22 b) => new Vector3I10F22(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I10F22 lhs, Vector3I10F22 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I10F22 lhs, Vector3I10F22 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I10F22 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector3I10F22 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I10F22>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I10F22 other)
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
        public Vector3I10F22 Min(Vector3I10F22 other) => new Vector3I10F22(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22 Max(Vector3I10F22 other) => new Vector3I10F22(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22 Abs() => new Vector3I10F22(
            X.Abs(),
            Y.Abs(),
            Z.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22 Half() => new Vector3I10F22(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22 Twice() => new Vector3I10F22(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22 Clamp(I10F22 min, I10F22 max) => new Vector3I10F22(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22 Clamp(
            Vector3I10F22 min, Vector3I10F22 max
        ) => new Vector3I10F22(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22 WrappingAdd(Vector3I10F22 other) => new Vector3I10F22(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22 WrappingSub(Vector3I10F22 other) => new Vector3I10F22(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22 WrappingMul(Vector3I10F22 other) => new Vector3I10F22(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22 WrappingAddUnsigned(Vector3U10F22 other) => new Vector3I10F22(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22 WrappingSubUnsigned(Vector3U10F22 other) => new Vector3I10F22(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U10F22 UnsignedAbs() => new Vector3U10F22(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22 SaturatingAdd(Vector3I10F22 other) => new Vector3I10F22(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22 SaturatingMul(I10F22 other) => new Vector3I10F22(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CrossInternal(Vector3I10F22 other, out long x, out long y, out long z) {
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
        public Vector3I10F22 Cross(Vector3I10F22 other) {
            const long k = 1L << 22;
            CrossInternal(other, out var x, out var y, out var z);
            return new Vector3I10F22(
                I10F22.FromBits((int)(x / k)),
                I10F22.FromBits((int)(y / k)),
                I10F22.FromBits((int)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22 SaturatingCross(Vector3I10F22 other) {
            const long k = 1L << 22;
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
            return new Vector3I10F22(
                I10F22.FromBits((int)x),
                I10F22.FromBits((int)y),
                I10F22.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector3I10F22 other) {
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
        public I10F22 Dot(Vector3I10F22 other) {
            const long k = 1L << 20;
            return I10F22.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I10F22 SaturatingDot(Vector3I10F22 other) {
            const long k = 1L << 20;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I10F22.MaxValue;
            } else if (bits < int.MinValue) {
                return I10F22.MinValue;
            } else {
                return I10F22.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U22F42 LengthSquaredUnsigned() => U22F42.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I22F42 LengthSquaredSigned() => I22F42.FromBits(
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
        public I22F42 LengthSquared() => LengthSquaredSigned();

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
        public U10F22 LengthHalfUnsigned() => U10F22.FromBits(LengthInternal());

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
        public I10F22 LengthHalf() => I10F22.FromBits(checked((int)LengthInternal()));

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
        public U11F21 LengthUnsigned() => U11F21.FromBits(LengthInternal());

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
        public I11F21 LengthSigned() => I11F21.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I11F21 Length() => LengthSigned();

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I10F22 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(X, X); }
        public Vector2I10F22 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(X, Y); }
        public Vector2I10F22 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(X, Z); }
        public Vector2I10F22 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Y, X); }
        public Vector2I10F22 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Y, Y); }
        public Vector2I10F22 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Y, Z); }
        public Vector2I10F22 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Z, X); }
        public Vector2I10F22 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Z, Y); }
        public Vector2I10F22 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I10F22(Z, Z); }
        public Vector3I10F22 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, X, X); }
        public Vector3I10F22 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, X, Y); }
        public Vector3I10F22 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, X, Z); }
        public Vector3I10F22 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Y, X); }
        public Vector3I10F22 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Y, Y); }
        public Vector3I10F22 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Y, Z); }
        public Vector3I10F22 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Z, X); }
        public Vector3I10F22 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Z, Y); }
        public Vector3I10F22 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(X, Z, Z); }
        public Vector3I10F22 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, X, X); }
        public Vector3I10F22 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, X, Y); }
        public Vector3I10F22 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, X, Z); }
        public Vector3I10F22 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Y, X); }
        public Vector3I10F22 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Y, Y); }
        public Vector3I10F22 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Y, Z); }
        public Vector3I10F22 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Z, X); }
        public Vector3I10F22 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Z, Y); }
        public Vector3I10F22 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Y, Z, Z); }
        public Vector3I10F22 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, X, X); }
        public Vector3I10F22 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, X, Y); }
        public Vector3I10F22 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, X, Z); }
        public Vector3I10F22 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Y, X); }
        public Vector3I10F22 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Y, Y); }
        public Vector3I10F22 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Y, Z); }
        public Vector3I10F22 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Z, X); }
        public Vector3I10F22 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Z, Y); }
        public Vector3I10F22 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I10F22(Z, Z, Z); }
        public Vector4I10F22 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, X, X); }
        public Vector4I10F22 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, X, Y); }
        public Vector4I10F22 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, X, Z); }
        public Vector4I10F22 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Y, X); }
        public Vector4I10F22 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Y, Y); }
        public Vector4I10F22 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Y, Z); }
        public Vector4I10F22 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Z, X); }
        public Vector4I10F22 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Z, Y); }
        public Vector4I10F22 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, X, Z, Z); }
        public Vector4I10F22 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, X, X); }
        public Vector4I10F22 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, X, Y); }
        public Vector4I10F22 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, X, Z); }
        public Vector4I10F22 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Y, X); }
        public Vector4I10F22 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Y, Y); }
        public Vector4I10F22 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Y, Z); }
        public Vector4I10F22 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Z, X); }
        public Vector4I10F22 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Z, Y); }
        public Vector4I10F22 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Y, Z, Z); }
        public Vector4I10F22 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, X, X); }
        public Vector4I10F22 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, X, Y); }
        public Vector4I10F22 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, X, Z); }
        public Vector4I10F22 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Y, X); }
        public Vector4I10F22 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Y, Y); }
        public Vector4I10F22 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Y, Z); }
        public Vector4I10F22 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Z, X); }
        public Vector4I10F22 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Z, Y); }
        public Vector4I10F22 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(X, Z, Z, Z); }
        public Vector4I10F22 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, X, X); }
        public Vector4I10F22 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, X, Y); }
        public Vector4I10F22 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, X, Z); }
        public Vector4I10F22 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Y, X); }
        public Vector4I10F22 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Y, Y); }
        public Vector4I10F22 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Y, Z); }
        public Vector4I10F22 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Z, X); }
        public Vector4I10F22 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Z, Y); }
        public Vector4I10F22 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, X, Z, Z); }
        public Vector4I10F22 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, X, X); }
        public Vector4I10F22 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, X, Y); }
        public Vector4I10F22 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, X, Z); }
        public Vector4I10F22 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Y, X); }
        public Vector4I10F22 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Y, Y); }
        public Vector4I10F22 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Y, Z); }
        public Vector4I10F22 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Z, X); }
        public Vector4I10F22 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Z, Y); }
        public Vector4I10F22 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Y, Z, Z); }
        public Vector4I10F22 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, X, X); }
        public Vector4I10F22 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, X, Y); }
        public Vector4I10F22 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, X, Z); }
        public Vector4I10F22 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Y, X); }
        public Vector4I10F22 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Y, Y); }
        public Vector4I10F22 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Y, Z); }
        public Vector4I10F22 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Z, X); }
        public Vector4I10F22 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Z, Y); }
        public Vector4I10F22 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Y, Z, Z, Z); }
        public Vector4I10F22 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, X, X); }
        public Vector4I10F22 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, X, Y); }
        public Vector4I10F22 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, X, Z); }
        public Vector4I10F22 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Y, X); }
        public Vector4I10F22 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Y, Y); }
        public Vector4I10F22 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Y, Z); }
        public Vector4I10F22 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Z, X); }
        public Vector4I10F22 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Z, Y); }
        public Vector4I10F22 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, X, Z, Z); }
        public Vector4I10F22 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, X, X); }
        public Vector4I10F22 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, X, Y); }
        public Vector4I10F22 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, X, Z); }
        public Vector4I10F22 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Y, X); }
        public Vector4I10F22 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Y, Y); }
        public Vector4I10F22 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Y, Z); }
        public Vector4I10F22 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Z, X); }
        public Vector4I10F22 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Z, Y); }
        public Vector4I10F22 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Y, Z, Z); }
        public Vector4I10F22 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, X, X); }
        public Vector4I10F22 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, X, Y); }
        public Vector4I10F22 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, X, Z); }
        public Vector4I10F22 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Y, X); }
        public Vector4I10F22 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Y, Y); }
        public Vector4I10F22 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Y, Z); }
        public Vector4I10F22 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Z, X); }
        public Vector4I10F22 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Z, Y); }
        public Vector4I10F22 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I10F22(Z, Z, Z, Z); }

    }

    partial struct I10F22 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I10F22 SaturatingMul(Vector3I10F22 other) => other.SaturatingMul(this);
    }
}
