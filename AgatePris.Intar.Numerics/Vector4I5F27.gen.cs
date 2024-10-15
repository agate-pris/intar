using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I5F27
    : IEquatable<Vector4I5F27>
    , IFormattable
    , IVector<U12F52, I12F52, U6F26, I6F26>
    , IVectorComponentRespective<I5F27> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I5F27 X;
        public I5F27 Y;
        public I5F27 Z;
        public I5F27 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(I5F27 x, I5F27 y, I5F27 z, I5F27 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(I5F27 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(I5F27 x, I5F27 y, Vector2I5F27 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(I5F27 x, Vector3I5F27 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(Vector2I5F27 xy, Vector2I5F27 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(Vector4I5F27 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(I5F27 x, Vector2I5F27 yz, I5F27 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(Vector3I5F27 xyz, I5F27 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27(Vector2I5F27 xy, I5F27 z, I5F27 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I5F27 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I5F27(I5F27.Zero);
        }
        public static Vector4I5F27 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I5F27(I5F27.One);
        }
        public static Vector4I5F27 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I5F27(I5F27.One, I5F27.Zero, I5F27.Zero, I5F27.Zero);
        }
        public static Vector4I5F27 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I5F27(I5F27.Zero, I5F27.One, I5F27.Zero, I5F27.Zero);
        }
        public static Vector4I5F27 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I5F27(I5F27.Zero, I5F27.Zero, I5F27.One, I5F27.Zero);
        }
        public static Vector4I5F27 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I5F27(I5F27.Zero, I5F27.Zero, I5F27.Zero, I5F27.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator +(Vector4I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator -(Vector4I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator *(Vector4I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator *(Vector4I5F27 a, I5F27 b) => new Vector4I5F27(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator *(I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator /(Vector4I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator /(Vector4I5F27 a, I5F27 b) => new Vector4I5F27(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I5F27 operator /(I5F27 a, Vector4I5F27 b) => new Vector4I5F27(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I5F27 lhs, Vector4I5F27 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I5F27 lhs, Vector4I5F27 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I5F27 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                switch (index) {
                    case 0: return X;
                    case 1: return Y;
                    case 2: return Z;
                    case 3: return W;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                switch (index) {
                    case 0: X = value; break;
                    case 1: Y = value; break;
                    case 2: Z = value; break;
                    case 3: W = value; break;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
        }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector4I5F27 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I5F27>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I5F27 other)
            => other.X == X
            && other.Y == Y
            && other.Z == Z
            && other.W == W;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            var z = Z.ToString(format, formatProvider);
            var w = W.ToString(format, formatProvider);
            return $"<{x}, {y}, {z}, {w}>";
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27 Min(Vector4I5F27 other) => new Vector4I5F27(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27 Max(Vector4I5F27 other) => new Vector4I5F27(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27 Abs() => new Vector4I5F27(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27 Half() => new Vector4I5F27(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27 Twice() => new Vector4I5F27(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27 Clamp(I5F27 min, I5F27 max) => new Vector4I5F27(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27 Clamp(
            Vector4I5F27 min, Vector4I5F27 max
        ) => new Vector4I5F27(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27 WrappingAdd(Vector4I5F27 other) => new Vector4I5F27(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27 WrappingSub(Vector4I5F27 other) => new Vector4I5F27(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27 WrappingMul(Vector4I5F27 other) => new Vector4I5F27(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

#if AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27 WrappingAddUnsigned(Vector4U5F27 other) => new Vector4I5F27(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27 WrappingSubUnsigned(Vector4U5F27 other) => new Vector4I5F27(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U5F27 UnsignedAbs() => new Vector4U5F27(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

#endif // AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27 SaturatingAdd(Vector4I5F27 other) => new Vector4I5F27(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27 SaturatingMul(I5F27 other) => new Vector4I5F27(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I5F27 other) {
            var x = ((long)X.Bits) * other.X.Bits;
            var y = ((long)Y.Bits) * other.Y.Bits;
            var z = ((long)Z.Bits) * other.Z.Bits;
            var w = ((long)W.Bits) * other.W.Bits;

            // オーバーフローを避けるため､ 事前に除算する｡
            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算に合わせて常に 4 で除算する｡
            return
                (x / 4) +
                (y / 4) +
                (z / 4) +
                (w / 4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I5F27 Dot(Vector4I5F27 other) {
            const long k = 1L << 25;
            return I5F27.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I5F27 SaturatingDot(Vector4I5F27 other) {
            const long k = 1L << 25;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I5F27.MaxValue;
            } else if (bits < int.MinValue) {
                return I5F27.MinValue;
            } else {
                return I5F27.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U12F52 LengthSquaredUnsigned() => U12F52.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I12F52 LengthSquaredSigned() => I12F52.FromBits(
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
        public I12F52 LengthSquared() => LengthSquaredSigned();

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
        public U5F27 LengthHalfUnsigned() => U5F27.FromBits(LengthInternal());

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
        public I5F27 LengthHalf() => I5F27.FromBits(checked((int)LengthInternal()));

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
        public U6F26 LengthUnsigned() => U6F26.FromBits(LengthInternal());

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
        public I6F26 LengthSigned() => I6F26.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I6F26 Length() => LengthSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I5F27? Normalize() {
            var x0 = X.Bits;
            var x1 = Y.Bits;
            var x2 = Z.Bits;
            var x3 = W.Bits;
            var b0 = x0 < 0;
            var b1 = x1 < 0;
            var b2 = x2 < 0;
            var b3 = x3 < 0;
            var a0 = unchecked((uint)(b0 ? Overflowing.WrappingNeg(x0) : x0));
            var a1 = unchecked((uint)(b1 ? Overflowing.WrappingNeg(x1) : x1));
            var a2 = unchecked((uint)(b2 ? Overflowing.WrappingNeg(x2) : x2));
            var a3 = unchecked((uint)(b3 ? Overflowing.WrappingNeg(x3) : x3));

            var max = a0.Max(a1).Max(a2).Max(a3);
            if (max == 0) {
                return null;
            }

            ulong m = uint.MaxValue / max;
            var l0 = m * a0;
            var l1 = m * a1;
            var l2 = m * a2;
            var l3 = m * a3;
            var sum =
                (l0 * l0 / 4) +
                (l1 * l1 / 4) +
                (l2 * l2 / 4) +
                (l3 * l3 / 4);
            var ll = Mathi.Sqrt(sum);

            const ulong k = 1UL << 26;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);
            var y3 = (int)(l3 * k / ll);

            return new Vector4I5F27(
                I5F27.FromBits(b0 ? -y0 : y0),
                I5F27.FromBits(b1 ? -y1 : y1),
                I5F27.FromBits(b2 ? -y2 : y2),
                I5F27.FromBits(b3 ? -y3 : y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I5F27 XX() => new Vector2I5F27(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I5F27 XY() => new Vector2I5F27(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I5F27 XZ() => new Vector2I5F27(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I5F27 XW() => new Vector2I5F27(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I5F27 YX() => new Vector2I5F27(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I5F27 YY() => new Vector2I5F27(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I5F27 YZ() => new Vector2I5F27(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I5F27 YW() => new Vector2I5F27(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I5F27 ZX() => new Vector2I5F27(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I5F27 ZY() => new Vector2I5F27(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I5F27 ZZ() => new Vector2I5F27(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I5F27 ZW() => new Vector2I5F27(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I5F27 WX() => new Vector2I5F27(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I5F27 WY() => new Vector2I5F27(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I5F27 WZ() => new Vector2I5F27(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I5F27 WW() => new Vector2I5F27(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 XXX() => new Vector3I5F27(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 XXY() => new Vector3I5F27(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 XXZ() => new Vector3I5F27(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 XXW() => new Vector3I5F27(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 XYX() => new Vector3I5F27(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 XYY() => new Vector3I5F27(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 XYZ() => new Vector3I5F27(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 XYW() => new Vector3I5F27(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 XZX() => new Vector3I5F27(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 XZY() => new Vector3I5F27(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 XZZ() => new Vector3I5F27(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 XZW() => new Vector3I5F27(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 XWX() => new Vector3I5F27(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 XWY() => new Vector3I5F27(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 XWZ() => new Vector3I5F27(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 XWW() => new Vector3I5F27(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 YXX() => new Vector3I5F27(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 YXY() => new Vector3I5F27(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 YXZ() => new Vector3I5F27(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 YXW() => new Vector3I5F27(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 YYX() => new Vector3I5F27(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 YYY() => new Vector3I5F27(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 YYZ() => new Vector3I5F27(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 YYW() => new Vector3I5F27(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 YZX() => new Vector3I5F27(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 YZY() => new Vector3I5F27(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 YZZ() => new Vector3I5F27(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 YZW() => new Vector3I5F27(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 YWX() => new Vector3I5F27(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 YWY() => new Vector3I5F27(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 YWZ() => new Vector3I5F27(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 YWW() => new Vector3I5F27(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 ZXX() => new Vector3I5F27(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 ZXY() => new Vector3I5F27(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 ZXZ() => new Vector3I5F27(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 ZXW() => new Vector3I5F27(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 ZYX() => new Vector3I5F27(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 ZYY() => new Vector3I5F27(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 ZYZ() => new Vector3I5F27(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 ZYW() => new Vector3I5F27(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 ZZX() => new Vector3I5F27(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 ZZY() => new Vector3I5F27(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 ZZZ() => new Vector3I5F27(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 ZZW() => new Vector3I5F27(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 ZWX() => new Vector3I5F27(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 ZWY() => new Vector3I5F27(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 ZWZ() => new Vector3I5F27(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 ZWW() => new Vector3I5F27(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 WXX() => new Vector3I5F27(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 WXY() => new Vector3I5F27(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 WXZ() => new Vector3I5F27(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 WXW() => new Vector3I5F27(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 WYX() => new Vector3I5F27(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 WYY() => new Vector3I5F27(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 WYZ() => new Vector3I5F27(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 WYW() => new Vector3I5F27(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 WZX() => new Vector3I5F27(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 WZY() => new Vector3I5F27(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 WZZ() => new Vector3I5F27(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 WZW() => new Vector3I5F27(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 WWX() => new Vector3I5F27(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 WWY() => new Vector3I5F27(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 WWZ() => new Vector3I5F27(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I5F27 WWW() => new Vector3I5F27(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XXXX() => new Vector4I5F27(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XXXY() => new Vector4I5F27(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XXXZ() => new Vector4I5F27(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XXXW() => new Vector4I5F27(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XXYX() => new Vector4I5F27(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XXYY() => new Vector4I5F27(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XXYZ() => new Vector4I5F27(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XXYW() => new Vector4I5F27(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XXZX() => new Vector4I5F27(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XXZY() => new Vector4I5F27(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XXZZ() => new Vector4I5F27(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XXZW() => new Vector4I5F27(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XXWX() => new Vector4I5F27(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XXWY() => new Vector4I5F27(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XXWZ() => new Vector4I5F27(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XXWW() => new Vector4I5F27(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XYXX() => new Vector4I5F27(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XYXY() => new Vector4I5F27(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XYXZ() => new Vector4I5F27(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XYXW() => new Vector4I5F27(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XYYX() => new Vector4I5F27(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XYYY() => new Vector4I5F27(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XYYZ() => new Vector4I5F27(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XYYW() => new Vector4I5F27(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XYZX() => new Vector4I5F27(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XYZY() => new Vector4I5F27(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XYZZ() => new Vector4I5F27(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XYZW() => new Vector4I5F27(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XYWX() => new Vector4I5F27(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XYWY() => new Vector4I5F27(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XYWZ() => new Vector4I5F27(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XYWW() => new Vector4I5F27(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XZXX() => new Vector4I5F27(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XZXY() => new Vector4I5F27(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XZXZ() => new Vector4I5F27(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XZXW() => new Vector4I5F27(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XZYX() => new Vector4I5F27(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XZYY() => new Vector4I5F27(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XZYZ() => new Vector4I5F27(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XZYW() => new Vector4I5F27(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XZZX() => new Vector4I5F27(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XZZY() => new Vector4I5F27(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XZZZ() => new Vector4I5F27(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XZZW() => new Vector4I5F27(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XZWX() => new Vector4I5F27(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XZWY() => new Vector4I5F27(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XZWZ() => new Vector4I5F27(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XZWW() => new Vector4I5F27(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XWXX() => new Vector4I5F27(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XWXY() => new Vector4I5F27(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XWXZ() => new Vector4I5F27(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XWXW() => new Vector4I5F27(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XWYX() => new Vector4I5F27(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XWYY() => new Vector4I5F27(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XWYZ() => new Vector4I5F27(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XWYW() => new Vector4I5F27(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XWZX() => new Vector4I5F27(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XWZY() => new Vector4I5F27(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XWZZ() => new Vector4I5F27(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XWZW() => new Vector4I5F27(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XWWX() => new Vector4I5F27(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XWWY() => new Vector4I5F27(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XWWZ() => new Vector4I5F27(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 XWWW() => new Vector4I5F27(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YXXX() => new Vector4I5F27(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YXXY() => new Vector4I5F27(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YXXZ() => new Vector4I5F27(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YXXW() => new Vector4I5F27(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YXYX() => new Vector4I5F27(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YXYY() => new Vector4I5F27(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YXYZ() => new Vector4I5F27(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YXYW() => new Vector4I5F27(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YXZX() => new Vector4I5F27(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YXZY() => new Vector4I5F27(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YXZZ() => new Vector4I5F27(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YXZW() => new Vector4I5F27(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YXWX() => new Vector4I5F27(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YXWY() => new Vector4I5F27(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YXWZ() => new Vector4I5F27(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YXWW() => new Vector4I5F27(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YYXX() => new Vector4I5F27(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YYXY() => new Vector4I5F27(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YYXZ() => new Vector4I5F27(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YYXW() => new Vector4I5F27(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YYYX() => new Vector4I5F27(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YYYY() => new Vector4I5F27(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YYYZ() => new Vector4I5F27(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YYYW() => new Vector4I5F27(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YYZX() => new Vector4I5F27(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YYZY() => new Vector4I5F27(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YYZZ() => new Vector4I5F27(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YYZW() => new Vector4I5F27(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YYWX() => new Vector4I5F27(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YYWY() => new Vector4I5F27(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YYWZ() => new Vector4I5F27(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YYWW() => new Vector4I5F27(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YZXX() => new Vector4I5F27(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YZXY() => new Vector4I5F27(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YZXZ() => new Vector4I5F27(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YZXW() => new Vector4I5F27(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YZYX() => new Vector4I5F27(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YZYY() => new Vector4I5F27(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YZYZ() => new Vector4I5F27(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YZYW() => new Vector4I5F27(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YZZX() => new Vector4I5F27(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YZZY() => new Vector4I5F27(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YZZZ() => new Vector4I5F27(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YZZW() => new Vector4I5F27(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YZWX() => new Vector4I5F27(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YZWY() => new Vector4I5F27(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YZWZ() => new Vector4I5F27(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YZWW() => new Vector4I5F27(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YWXX() => new Vector4I5F27(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YWXY() => new Vector4I5F27(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YWXZ() => new Vector4I5F27(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YWXW() => new Vector4I5F27(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YWYX() => new Vector4I5F27(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YWYY() => new Vector4I5F27(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YWYZ() => new Vector4I5F27(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YWYW() => new Vector4I5F27(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YWZX() => new Vector4I5F27(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YWZY() => new Vector4I5F27(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YWZZ() => new Vector4I5F27(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YWZW() => new Vector4I5F27(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YWWX() => new Vector4I5F27(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YWWY() => new Vector4I5F27(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YWWZ() => new Vector4I5F27(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 YWWW() => new Vector4I5F27(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZXXX() => new Vector4I5F27(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZXXY() => new Vector4I5F27(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZXXZ() => new Vector4I5F27(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZXXW() => new Vector4I5F27(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZXYX() => new Vector4I5F27(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZXYY() => new Vector4I5F27(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZXYZ() => new Vector4I5F27(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZXYW() => new Vector4I5F27(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZXZX() => new Vector4I5F27(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZXZY() => new Vector4I5F27(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZXZZ() => new Vector4I5F27(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZXZW() => new Vector4I5F27(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZXWX() => new Vector4I5F27(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZXWY() => new Vector4I5F27(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZXWZ() => new Vector4I5F27(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZXWW() => new Vector4I5F27(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZYXX() => new Vector4I5F27(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZYXY() => new Vector4I5F27(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZYXZ() => new Vector4I5F27(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZYXW() => new Vector4I5F27(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZYYX() => new Vector4I5F27(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZYYY() => new Vector4I5F27(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZYYZ() => new Vector4I5F27(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZYYW() => new Vector4I5F27(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZYZX() => new Vector4I5F27(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZYZY() => new Vector4I5F27(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZYZZ() => new Vector4I5F27(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZYZW() => new Vector4I5F27(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZYWX() => new Vector4I5F27(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZYWY() => new Vector4I5F27(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZYWZ() => new Vector4I5F27(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZYWW() => new Vector4I5F27(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZZXX() => new Vector4I5F27(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZZXY() => new Vector4I5F27(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZZXZ() => new Vector4I5F27(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZZXW() => new Vector4I5F27(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZZYX() => new Vector4I5F27(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZZYY() => new Vector4I5F27(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZZYZ() => new Vector4I5F27(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZZYW() => new Vector4I5F27(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZZZX() => new Vector4I5F27(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZZZY() => new Vector4I5F27(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZZZZ() => new Vector4I5F27(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZZZW() => new Vector4I5F27(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZZWX() => new Vector4I5F27(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZZWY() => new Vector4I5F27(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZZWZ() => new Vector4I5F27(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZZWW() => new Vector4I5F27(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZWXX() => new Vector4I5F27(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZWXY() => new Vector4I5F27(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZWXZ() => new Vector4I5F27(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZWXW() => new Vector4I5F27(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZWYX() => new Vector4I5F27(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZWYY() => new Vector4I5F27(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZWYZ() => new Vector4I5F27(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZWYW() => new Vector4I5F27(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZWZX() => new Vector4I5F27(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZWZY() => new Vector4I5F27(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZWZZ() => new Vector4I5F27(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZWZW() => new Vector4I5F27(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZWWX() => new Vector4I5F27(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZWWY() => new Vector4I5F27(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZWWZ() => new Vector4I5F27(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 ZWWW() => new Vector4I5F27(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WXXX() => new Vector4I5F27(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WXXY() => new Vector4I5F27(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WXXZ() => new Vector4I5F27(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WXXW() => new Vector4I5F27(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WXYX() => new Vector4I5F27(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WXYY() => new Vector4I5F27(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WXYZ() => new Vector4I5F27(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WXYW() => new Vector4I5F27(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WXZX() => new Vector4I5F27(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WXZY() => new Vector4I5F27(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WXZZ() => new Vector4I5F27(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WXZW() => new Vector4I5F27(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WXWX() => new Vector4I5F27(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WXWY() => new Vector4I5F27(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WXWZ() => new Vector4I5F27(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WXWW() => new Vector4I5F27(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WYXX() => new Vector4I5F27(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WYXY() => new Vector4I5F27(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WYXZ() => new Vector4I5F27(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WYXW() => new Vector4I5F27(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WYYX() => new Vector4I5F27(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WYYY() => new Vector4I5F27(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WYYZ() => new Vector4I5F27(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WYYW() => new Vector4I5F27(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WYZX() => new Vector4I5F27(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WYZY() => new Vector4I5F27(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WYZZ() => new Vector4I5F27(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WYZW() => new Vector4I5F27(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WYWX() => new Vector4I5F27(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WYWY() => new Vector4I5F27(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WYWZ() => new Vector4I5F27(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WYWW() => new Vector4I5F27(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WZXX() => new Vector4I5F27(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WZXY() => new Vector4I5F27(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WZXZ() => new Vector4I5F27(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WZXW() => new Vector4I5F27(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WZYX() => new Vector4I5F27(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WZYY() => new Vector4I5F27(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WZYZ() => new Vector4I5F27(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WZYW() => new Vector4I5F27(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WZZX() => new Vector4I5F27(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WZZY() => new Vector4I5F27(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WZZZ() => new Vector4I5F27(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WZZW() => new Vector4I5F27(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WZWX() => new Vector4I5F27(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WZWY() => new Vector4I5F27(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WZWZ() => new Vector4I5F27(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WZWW() => new Vector4I5F27(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WWXX() => new Vector4I5F27(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WWXY() => new Vector4I5F27(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WWXZ() => new Vector4I5F27(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WWXW() => new Vector4I5F27(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WWYX() => new Vector4I5F27(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WWYY() => new Vector4I5F27(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WWYZ() => new Vector4I5F27(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WWYW() => new Vector4I5F27(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WWZX() => new Vector4I5F27(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WWZY() => new Vector4I5F27(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WWZZ() => new Vector4I5F27(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WWZW() => new Vector4I5F27(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WWWX() => new Vector4I5F27(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WWWY() => new Vector4I5F27(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WWWZ() => new Vector4I5F27(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I5F27 WWWW() => new Vector4I5F27(W, W, W, W);

    }
}
