using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I19F13
    : IEquatable<Vector4I19F13>
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
        public I19F13 Z;
        public I19F13 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(I19F13 x, I19F13 y, I19F13 z, I19F13 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(I19F13 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(I19F13 x, I19F13 y, Vector2I19F13 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(I19F13 x, Vector3I19F13 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(Vector2I19F13 xy, Vector2I19F13 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(Vector4I19F13 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(I19F13 x, Vector2I19F13 yz, I19F13 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(Vector3I19F13 xyz, I19F13 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13(Vector2I19F13 xy, I19F13 z, I19F13 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I19F13 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I19F13(I19F13.Zero);
        }
        public static Vector4I19F13 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I19F13(I19F13.One);
        }
        public static Vector4I19F13 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I19F13(I19F13.One, I19F13.Zero, I19F13.Zero, I19F13.Zero);
        }
        public static Vector4I19F13 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I19F13(I19F13.Zero, I19F13.One, I19F13.Zero, I19F13.Zero);
        }
        public static Vector4I19F13 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I19F13(I19F13.Zero, I19F13.Zero, I19F13.One, I19F13.Zero);
        }
        public static Vector4I19F13 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I19F13(I19F13.Zero, I19F13.Zero, I19F13.Zero, I19F13.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator +(Vector4I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator -(Vector4I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator *(Vector4I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator *(Vector4I19F13 a, I19F13 b) => new Vector4I19F13(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator *(I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator /(Vector4I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator /(Vector4I19F13 a, I19F13 b) => new Vector4I19F13(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I19F13 operator /(I19F13 a, Vector4I19F13 b) => new Vector4I19F13(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I19F13 lhs, Vector4I19F13 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I19F13 lhs, Vector4I19F13 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I19F13 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4I19F13 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I19F13>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I19F13 other)
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
        public Vector4I19F13 Min(Vector4I19F13 other) => new Vector4I19F13(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 Max(Vector4I19F13 other) => new Vector4I19F13(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 Abs() => new Vector4I19F13(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 Half() => new Vector4I19F13(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 Twice() => new Vector4I19F13(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 Clamp(I19F13 min, I19F13 max) => new Vector4I19F13(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 Clamp(
            Vector4I19F13 min, Vector4I19F13 max
        ) => new Vector4I19F13(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 WrappingAdd(Vector4I19F13 other) => new Vector4I19F13(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 WrappingSub(Vector4I19F13 other) => new Vector4I19F13(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 WrappingMul(Vector4I19F13 other) => new Vector4I19F13(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

#if AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 WrappingAddUnsigned(Vector4U19F13 other) => new Vector4I19F13(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 WrappingSubUnsigned(Vector4U19F13 other) => new Vector4I19F13(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U19F13 UnsignedAbs() => new Vector4U19F13(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

#endif // AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 SaturatingAdd(Vector4I19F13 other) => new Vector4I19F13(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13 SaturatingMul(I19F13 other) => new Vector4I19F13(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I19F13 other) {
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
        public I19F13 Dot(Vector4I19F13 other) {
            const long k = 1L << 11;
            return I19F13.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I19F13 SaturatingDot(Vector4I19F13 other) {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I19F13? Normalize() {
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

            const ulong k = 1UL << 12;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);
            var y3 = (int)(l3 * k / ll);

            return new Vector4I19F13(
                I19F13.FromBits(b0 ? -y0 : y0),
                I19F13.FromBits(b1 ? -y1 : y1),
                I19F13.FromBits(b2 ? -y2 : y2),
                I19F13.FromBits(b3 ? -y3 : y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I19F13 XX() => new Vector2I19F13(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I19F13 XY() => new Vector2I19F13(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I19F13 XZ() => new Vector2I19F13(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I19F13 XW() => new Vector2I19F13(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I19F13 YX() => new Vector2I19F13(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I19F13 YY() => new Vector2I19F13(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I19F13 YZ() => new Vector2I19F13(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I19F13 YW() => new Vector2I19F13(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I19F13 ZX() => new Vector2I19F13(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I19F13 ZY() => new Vector2I19F13(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I19F13 ZZ() => new Vector2I19F13(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I19F13 ZW() => new Vector2I19F13(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I19F13 WX() => new Vector2I19F13(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I19F13 WY() => new Vector2I19F13(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I19F13 WZ() => new Vector2I19F13(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I19F13 WW() => new Vector2I19F13(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 XXX() => new Vector3I19F13(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 XXY() => new Vector3I19F13(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 XXZ() => new Vector3I19F13(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 XXW() => new Vector3I19F13(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 XYX() => new Vector3I19F13(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 XYY() => new Vector3I19F13(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 XYZ() => new Vector3I19F13(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 XYW() => new Vector3I19F13(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 XZX() => new Vector3I19F13(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 XZY() => new Vector3I19F13(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 XZZ() => new Vector3I19F13(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 XZW() => new Vector3I19F13(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 XWX() => new Vector3I19F13(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 XWY() => new Vector3I19F13(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 XWZ() => new Vector3I19F13(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 XWW() => new Vector3I19F13(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 YXX() => new Vector3I19F13(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 YXY() => new Vector3I19F13(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 YXZ() => new Vector3I19F13(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 YXW() => new Vector3I19F13(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 YYX() => new Vector3I19F13(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 YYY() => new Vector3I19F13(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 YYZ() => new Vector3I19F13(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 YYW() => new Vector3I19F13(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 YZX() => new Vector3I19F13(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 YZY() => new Vector3I19F13(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 YZZ() => new Vector3I19F13(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 YZW() => new Vector3I19F13(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 YWX() => new Vector3I19F13(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 YWY() => new Vector3I19F13(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 YWZ() => new Vector3I19F13(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 YWW() => new Vector3I19F13(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 ZXX() => new Vector3I19F13(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 ZXY() => new Vector3I19F13(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 ZXZ() => new Vector3I19F13(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 ZXW() => new Vector3I19F13(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 ZYX() => new Vector3I19F13(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 ZYY() => new Vector3I19F13(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 ZYZ() => new Vector3I19F13(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 ZYW() => new Vector3I19F13(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 ZZX() => new Vector3I19F13(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 ZZY() => new Vector3I19F13(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 ZZZ() => new Vector3I19F13(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 ZZW() => new Vector3I19F13(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 ZWX() => new Vector3I19F13(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 ZWY() => new Vector3I19F13(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 ZWZ() => new Vector3I19F13(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 ZWW() => new Vector3I19F13(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 WXX() => new Vector3I19F13(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 WXY() => new Vector3I19F13(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 WXZ() => new Vector3I19F13(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 WXW() => new Vector3I19F13(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 WYX() => new Vector3I19F13(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 WYY() => new Vector3I19F13(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 WYZ() => new Vector3I19F13(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 WYW() => new Vector3I19F13(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 WZX() => new Vector3I19F13(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 WZY() => new Vector3I19F13(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 WZZ() => new Vector3I19F13(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 WZW() => new Vector3I19F13(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 WWX() => new Vector3I19F13(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 WWY() => new Vector3I19F13(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 WWZ() => new Vector3I19F13(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I19F13 WWW() => new Vector3I19F13(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XXXX() => new Vector4I19F13(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XXXY() => new Vector4I19F13(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XXXZ() => new Vector4I19F13(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XXXW() => new Vector4I19F13(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XXYX() => new Vector4I19F13(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XXYY() => new Vector4I19F13(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XXYZ() => new Vector4I19F13(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XXYW() => new Vector4I19F13(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XXZX() => new Vector4I19F13(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XXZY() => new Vector4I19F13(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XXZZ() => new Vector4I19F13(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XXZW() => new Vector4I19F13(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XXWX() => new Vector4I19F13(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XXWY() => new Vector4I19F13(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XXWZ() => new Vector4I19F13(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XXWW() => new Vector4I19F13(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XYXX() => new Vector4I19F13(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XYXY() => new Vector4I19F13(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XYXZ() => new Vector4I19F13(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XYXW() => new Vector4I19F13(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XYYX() => new Vector4I19F13(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XYYY() => new Vector4I19F13(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XYYZ() => new Vector4I19F13(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XYYW() => new Vector4I19F13(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XYZX() => new Vector4I19F13(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XYZY() => new Vector4I19F13(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XYZZ() => new Vector4I19F13(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XYZW() => new Vector4I19F13(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XYWX() => new Vector4I19F13(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XYWY() => new Vector4I19F13(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XYWZ() => new Vector4I19F13(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XYWW() => new Vector4I19F13(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XZXX() => new Vector4I19F13(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XZXY() => new Vector4I19F13(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XZXZ() => new Vector4I19F13(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XZXW() => new Vector4I19F13(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XZYX() => new Vector4I19F13(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XZYY() => new Vector4I19F13(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XZYZ() => new Vector4I19F13(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XZYW() => new Vector4I19F13(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XZZX() => new Vector4I19F13(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XZZY() => new Vector4I19F13(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XZZZ() => new Vector4I19F13(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XZZW() => new Vector4I19F13(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XZWX() => new Vector4I19F13(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XZWY() => new Vector4I19F13(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XZWZ() => new Vector4I19F13(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XZWW() => new Vector4I19F13(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XWXX() => new Vector4I19F13(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XWXY() => new Vector4I19F13(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XWXZ() => new Vector4I19F13(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XWXW() => new Vector4I19F13(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XWYX() => new Vector4I19F13(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XWYY() => new Vector4I19F13(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XWYZ() => new Vector4I19F13(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XWYW() => new Vector4I19F13(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XWZX() => new Vector4I19F13(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XWZY() => new Vector4I19F13(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XWZZ() => new Vector4I19F13(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XWZW() => new Vector4I19F13(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XWWX() => new Vector4I19F13(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XWWY() => new Vector4I19F13(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XWWZ() => new Vector4I19F13(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 XWWW() => new Vector4I19F13(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YXXX() => new Vector4I19F13(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YXXY() => new Vector4I19F13(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YXXZ() => new Vector4I19F13(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YXXW() => new Vector4I19F13(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YXYX() => new Vector4I19F13(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YXYY() => new Vector4I19F13(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YXYZ() => new Vector4I19F13(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YXYW() => new Vector4I19F13(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YXZX() => new Vector4I19F13(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YXZY() => new Vector4I19F13(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YXZZ() => new Vector4I19F13(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YXZW() => new Vector4I19F13(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YXWX() => new Vector4I19F13(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YXWY() => new Vector4I19F13(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YXWZ() => new Vector4I19F13(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YXWW() => new Vector4I19F13(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YYXX() => new Vector4I19F13(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YYXY() => new Vector4I19F13(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YYXZ() => new Vector4I19F13(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YYXW() => new Vector4I19F13(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YYYX() => new Vector4I19F13(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YYYY() => new Vector4I19F13(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YYYZ() => new Vector4I19F13(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YYYW() => new Vector4I19F13(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YYZX() => new Vector4I19F13(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YYZY() => new Vector4I19F13(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YYZZ() => new Vector4I19F13(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YYZW() => new Vector4I19F13(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YYWX() => new Vector4I19F13(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YYWY() => new Vector4I19F13(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YYWZ() => new Vector4I19F13(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YYWW() => new Vector4I19F13(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YZXX() => new Vector4I19F13(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YZXY() => new Vector4I19F13(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YZXZ() => new Vector4I19F13(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YZXW() => new Vector4I19F13(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YZYX() => new Vector4I19F13(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YZYY() => new Vector4I19F13(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YZYZ() => new Vector4I19F13(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YZYW() => new Vector4I19F13(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YZZX() => new Vector4I19F13(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YZZY() => new Vector4I19F13(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YZZZ() => new Vector4I19F13(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YZZW() => new Vector4I19F13(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YZWX() => new Vector4I19F13(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YZWY() => new Vector4I19F13(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YZWZ() => new Vector4I19F13(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YZWW() => new Vector4I19F13(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YWXX() => new Vector4I19F13(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YWXY() => new Vector4I19F13(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YWXZ() => new Vector4I19F13(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YWXW() => new Vector4I19F13(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YWYX() => new Vector4I19F13(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YWYY() => new Vector4I19F13(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YWYZ() => new Vector4I19F13(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YWYW() => new Vector4I19F13(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YWZX() => new Vector4I19F13(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YWZY() => new Vector4I19F13(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YWZZ() => new Vector4I19F13(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YWZW() => new Vector4I19F13(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YWWX() => new Vector4I19F13(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YWWY() => new Vector4I19F13(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YWWZ() => new Vector4I19F13(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 YWWW() => new Vector4I19F13(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZXXX() => new Vector4I19F13(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZXXY() => new Vector4I19F13(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZXXZ() => new Vector4I19F13(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZXXW() => new Vector4I19F13(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZXYX() => new Vector4I19F13(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZXYY() => new Vector4I19F13(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZXYZ() => new Vector4I19F13(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZXYW() => new Vector4I19F13(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZXZX() => new Vector4I19F13(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZXZY() => new Vector4I19F13(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZXZZ() => new Vector4I19F13(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZXZW() => new Vector4I19F13(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZXWX() => new Vector4I19F13(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZXWY() => new Vector4I19F13(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZXWZ() => new Vector4I19F13(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZXWW() => new Vector4I19F13(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZYXX() => new Vector4I19F13(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZYXY() => new Vector4I19F13(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZYXZ() => new Vector4I19F13(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZYXW() => new Vector4I19F13(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZYYX() => new Vector4I19F13(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZYYY() => new Vector4I19F13(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZYYZ() => new Vector4I19F13(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZYYW() => new Vector4I19F13(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZYZX() => new Vector4I19F13(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZYZY() => new Vector4I19F13(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZYZZ() => new Vector4I19F13(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZYZW() => new Vector4I19F13(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZYWX() => new Vector4I19F13(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZYWY() => new Vector4I19F13(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZYWZ() => new Vector4I19F13(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZYWW() => new Vector4I19F13(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZZXX() => new Vector4I19F13(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZZXY() => new Vector4I19F13(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZZXZ() => new Vector4I19F13(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZZXW() => new Vector4I19F13(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZZYX() => new Vector4I19F13(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZZYY() => new Vector4I19F13(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZZYZ() => new Vector4I19F13(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZZYW() => new Vector4I19F13(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZZZX() => new Vector4I19F13(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZZZY() => new Vector4I19F13(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZZZZ() => new Vector4I19F13(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZZZW() => new Vector4I19F13(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZZWX() => new Vector4I19F13(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZZWY() => new Vector4I19F13(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZZWZ() => new Vector4I19F13(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZZWW() => new Vector4I19F13(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZWXX() => new Vector4I19F13(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZWXY() => new Vector4I19F13(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZWXZ() => new Vector4I19F13(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZWXW() => new Vector4I19F13(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZWYX() => new Vector4I19F13(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZWYY() => new Vector4I19F13(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZWYZ() => new Vector4I19F13(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZWYW() => new Vector4I19F13(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZWZX() => new Vector4I19F13(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZWZY() => new Vector4I19F13(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZWZZ() => new Vector4I19F13(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZWZW() => new Vector4I19F13(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZWWX() => new Vector4I19F13(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZWWY() => new Vector4I19F13(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZWWZ() => new Vector4I19F13(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 ZWWW() => new Vector4I19F13(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WXXX() => new Vector4I19F13(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WXXY() => new Vector4I19F13(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WXXZ() => new Vector4I19F13(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WXXW() => new Vector4I19F13(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WXYX() => new Vector4I19F13(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WXYY() => new Vector4I19F13(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WXYZ() => new Vector4I19F13(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WXYW() => new Vector4I19F13(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WXZX() => new Vector4I19F13(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WXZY() => new Vector4I19F13(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WXZZ() => new Vector4I19F13(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WXZW() => new Vector4I19F13(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WXWX() => new Vector4I19F13(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WXWY() => new Vector4I19F13(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WXWZ() => new Vector4I19F13(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WXWW() => new Vector4I19F13(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WYXX() => new Vector4I19F13(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WYXY() => new Vector4I19F13(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WYXZ() => new Vector4I19F13(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WYXW() => new Vector4I19F13(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WYYX() => new Vector4I19F13(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WYYY() => new Vector4I19F13(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WYYZ() => new Vector4I19F13(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WYYW() => new Vector4I19F13(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WYZX() => new Vector4I19F13(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WYZY() => new Vector4I19F13(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WYZZ() => new Vector4I19F13(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WYZW() => new Vector4I19F13(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WYWX() => new Vector4I19F13(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WYWY() => new Vector4I19F13(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WYWZ() => new Vector4I19F13(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WYWW() => new Vector4I19F13(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WZXX() => new Vector4I19F13(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WZXY() => new Vector4I19F13(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WZXZ() => new Vector4I19F13(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WZXW() => new Vector4I19F13(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WZYX() => new Vector4I19F13(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WZYY() => new Vector4I19F13(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WZYZ() => new Vector4I19F13(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WZYW() => new Vector4I19F13(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WZZX() => new Vector4I19F13(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WZZY() => new Vector4I19F13(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WZZZ() => new Vector4I19F13(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WZZW() => new Vector4I19F13(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WZWX() => new Vector4I19F13(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WZWY() => new Vector4I19F13(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WZWZ() => new Vector4I19F13(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WZWW() => new Vector4I19F13(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WWXX() => new Vector4I19F13(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WWXY() => new Vector4I19F13(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WWXZ() => new Vector4I19F13(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WWXW() => new Vector4I19F13(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WWYX() => new Vector4I19F13(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WWYY() => new Vector4I19F13(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WWYZ() => new Vector4I19F13(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WWYW() => new Vector4I19F13(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WWZX() => new Vector4I19F13(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WWZY() => new Vector4I19F13(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WWZZ() => new Vector4I19F13(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WWZW() => new Vector4I19F13(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WWWX() => new Vector4I19F13(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WWWY() => new Vector4I19F13(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WWWZ() => new Vector4I19F13(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I19F13 WWWW() => new Vector4I19F13(W, W, W, W);

    }
}
