using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I10F22
    : IEquatable<Vector4I10F22>
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
        public I10F22 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(I10F22 x, I10F22 y, I10F22 z, I10F22 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(I10F22 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(I10F22 x, I10F22 y, Vector2I10F22 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(I10F22 x, Vector3I10F22 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(Vector2I10F22 xy, Vector2I10F22 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(Vector4I10F22 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(I10F22 x, Vector2I10F22 yz, I10F22 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(Vector3I10F22 xyz, I10F22 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22(Vector2I10F22 xy, I10F22 z, I10F22 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I10F22 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I10F22(I10F22.Zero);
        }
        public static Vector4I10F22 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I10F22(I10F22.One);
        }
        public static Vector4I10F22 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I10F22(I10F22.One, I10F22.Zero, I10F22.Zero, I10F22.Zero);
        }
        public static Vector4I10F22 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I10F22(I10F22.Zero, I10F22.One, I10F22.Zero, I10F22.Zero);
        }
        public static Vector4I10F22 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I10F22(I10F22.Zero, I10F22.Zero, I10F22.One, I10F22.Zero);
        }
        public static Vector4I10F22 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I10F22(I10F22.Zero, I10F22.Zero, I10F22.Zero, I10F22.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 operator +(Vector4I10F22 a, Vector4I10F22 b) => new Vector4I10F22(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 operator -(Vector4I10F22 a, Vector4I10F22 b) => new Vector4I10F22(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 operator *(Vector4I10F22 a, Vector4I10F22 b) => new Vector4I10F22(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 operator *(Vector4I10F22 a, I10F22 b) => new Vector4I10F22(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 operator *(I10F22 a, Vector4I10F22 b) => new Vector4I10F22(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 operator /(Vector4I10F22 a, Vector4I10F22 b) => new Vector4I10F22(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 operator /(Vector4I10F22 a, I10F22 b) => new Vector4I10F22(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I10F22 operator /(I10F22 a, Vector4I10F22 b) => new Vector4I10F22(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I10F22 lhs, Vector4I10F22 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I10F22 lhs, Vector4I10F22 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I10F22 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4I10F22 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I10F22>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I10F22 other)
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
        public Vector4I10F22 Min(Vector4I10F22 other) => new Vector4I10F22(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22 Max(Vector4I10F22 other) => new Vector4I10F22(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22 Abs() => new Vector4I10F22(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22 Half() => new Vector4I10F22(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22 Twice() => new Vector4I10F22(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22 Clamp(I10F22 min, I10F22 max) => new Vector4I10F22(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22 Clamp(
            Vector4I10F22 min, Vector4I10F22 max
        ) => new Vector4I10F22(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22 WrappingAdd(Vector4I10F22 other) => new Vector4I10F22(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22 WrappingSub(Vector4I10F22 other) => new Vector4I10F22(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22 WrappingMul(Vector4I10F22 other) => new Vector4I10F22(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22 WrappingAddUnsigned(Vector4U10F22 other) => new Vector4I10F22(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22 WrappingSubUnsigned(Vector4U10F22 other) => new Vector4I10F22(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U10F22 UnsignedAbs() => new Vector4U10F22(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22 SaturatingAdd(Vector4I10F22 other) => new Vector4I10F22(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22 SaturatingMul(I10F22 other) => new Vector4I10F22(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I10F22 other) {
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
        public I10F22 Dot(Vector4I10F22 other) {
            const long k = 1L << 20;
            return I10F22.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I10F22 SaturatingDot(Vector4I10F22 other) {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I10F22? Normalize() {
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

            const ulong k = 1UL << 21;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);
            var y3 = (int)(l3 * k / ll);

            return new Vector4I10F22(
                I10F22.FromBits(b0 ? -y0 : y0),
                I10F22.FromBits(b1 ? -y1 : y1),
                I10F22.FromBits(b2 ? -y2 : y2),
                I10F22.FromBits(b3 ? -y3 : y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I10F22 XX() => new Vector2I10F22(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I10F22 XY() => new Vector2I10F22(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I10F22 XZ() => new Vector2I10F22(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I10F22 XW() => new Vector2I10F22(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I10F22 YX() => new Vector2I10F22(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I10F22 YY() => new Vector2I10F22(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I10F22 YZ() => new Vector2I10F22(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I10F22 YW() => new Vector2I10F22(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I10F22 ZX() => new Vector2I10F22(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I10F22 ZY() => new Vector2I10F22(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I10F22 ZZ() => new Vector2I10F22(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I10F22 ZW() => new Vector2I10F22(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I10F22 WX() => new Vector2I10F22(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I10F22 WY() => new Vector2I10F22(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I10F22 WZ() => new Vector2I10F22(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I10F22 WW() => new Vector2I10F22(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 XXX() => new Vector3I10F22(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 XXY() => new Vector3I10F22(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 XXZ() => new Vector3I10F22(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 XXW() => new Vector3I10F22(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 XYX() => new Vector3I10F22(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 XYY() => new Vector3I10F22(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 XYZ() => new Vector3I10F22(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 XYW() => new Vector3I10F22(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 XZX() => new Vector3I10F22(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 XZY() => new Vector3I10F22(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 XZZ() => new Vector3I10F22(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 XZW() => new Vector3I10F22(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 XWX() => new Vector3I10F22(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 XWY() => new Vector3I10F22(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 XWZ() => new Vector3I10F22(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 XWW() => new Vector3I10F22(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 YXX() => new Vector3I10F22(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 YXY() => new Vector3I10F22(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 YXZ() => new Vector3I10F22(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 YXW() => new Vector3I10F22(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 YYX() => new Vector3I10F22(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 YYY() => new Vector3I10F22(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 YYZ() => new Vector3I10F22(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 YYW() => new Vector3I10F22(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 YZX() => new Vector3I10F22(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 YZY() => new Vector3I10F22(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 YZZ() => new Vector3I10F22(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 YZW() => new Vector3I10F22(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 YWX() => new Vector3I10F22(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 YWY() => new Vector3I10F22(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 YWZ() => new Vector3I10F22(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 YWW() => new Vector3I10F22(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 ZXX() => new Vector3I10F22(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 ZXY() => new Vector3I10F22(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 ZXZ() => new Vector3I10F22(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 ZXW() => new Vector3I10F22(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 ZYX() => new Vector3I10F22(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 ZYY() => new Vector3I10F22(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 ZYZ() => new Vector3I10F22(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 ZYW() => new Vector3I10F22(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 ZZX() => new Vector3I10F22(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 ZZY() => new Vector3I10F22(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 ZZZ() => new Vector3I10F22(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 ZZW() => new Vector3I10F22(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 ZWX() => new Vector3I10F22(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 ZWY() => new Vector3I10F22(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 ZWZ() => new Vector3I10F22(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 ZWW() => new Vector3I10F22(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 WXX() => new Vector3I10F22(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 WXY() => new Vector3I10F22(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 WXZ() => new Vector3I10F22(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 WXW() => new Vector3I10F22(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 WYX() => new Vector3I10F22(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 WYY() => new Vector3I10F22(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 WYZ() => new Vector3I10F22(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 WYW() => new Vector3I10F22(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 WZX() => new Vector3I10F22(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 WZY() => new Vector3I10F22(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 WZZ() => new Vector3I10F22(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 WZW() => new Vector3I10F22(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 WWX() => new Vector3I10F22(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 WWY() => new Vector3I10F22(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 WWZ() => new Vector3I10F22(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I10F22 WWW() => new Vector3I10F22(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XXXX() => new Vector4I10F22(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XXXY() => new Vector4I10F22(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XXXZ() => new Vector4I10F22(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XXXW() => new Vector4I10F22(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XXYX() => new Vector4I10F22(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XXYY() => new Vector4I10F22(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XXYZ() => new Vector4I10F22(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XXYW() => new Vector4I10F22(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XXZX() => new Vector4I10F22(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XXZY() => new Vector4I10F22(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XXZZ() => new Vector4I10F22(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XXZW() => new Vector4I10F22(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XXWX() => new Vector4I10F22(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XXWY() => new Vector4I10F22(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XXWZ() => new Vector4I10F22(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XXWW() => new Vector4I10F22(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XYXX() => new Vector4I10F22(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XYXY() => new Vector4I10F22(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XYXZ() => new Vector4I10F22(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XYXW() => new Vector4I10F22(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XYYX() => new Vector4I10F22(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XYYY() => new Vector4I10F22(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XYYZ() => new Vector4I10F22(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XYYW() => new Vector4I10F22(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XYZX() => new Vector4I10F22(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XYZY() => new Vector4I10F22(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XYZZ() => new Vector4I10F22(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XYZW() => new Vector4I10F22(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XYWX() => new Vector4I10F22(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XYWY() => new Vector4I10F22(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XYWZ() => new Vector4I10F22(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XYWW() => new Vector4I10F22(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XZXX() => new Vector4I10F22(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XZXY() => new Vector4I10F22(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XZXZ() => new Vector4I10F22(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XZXW() => new Vector4I10F22(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XZYX() => new Vector4I10F22(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XZYY() => new Vector4I10F22(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XZYZ() => new Vector4I10F22(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XZYW() => new Vector4I10F22(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XZZX() => new Vector4I10F22(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XZZY() => new Vector4I10F22(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XZZZ() => new Vector4I10F22(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XZZW() => new Vector4I10F22(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XZWX() => new Vector4I10F22(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XZWY() => new Vector4I10F22(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XZWZ() => new Vector4I10F22(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XZWW() => new Vector4I10F22(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XWXX() => new Vector4I10F22(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XWXY() => new Vector4I10F22(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XWXZ() => new Vector4I10F22(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XWXW() => new Vector4I10F22(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XWYX() => new Vector4I10F22(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XWYY() => new Vector4I10F22(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XWYZ() => new Vector4I10F22(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XWYW() => new Vector4I10F22(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XWZX() => new Vector4I10F22(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XWZY() => new Vector4I10F22(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XWZZ() => new Vector4I10F22(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XWZW() => new Vector4I10F22(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XWWX() => new Vector4I10F22(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XWWY() => new Vector4I10F22(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XWWZ() => new Vector4I10F22(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 XWWW() => new Vector4I10F22(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YXXX() => new Vector4I10F22(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YXXY() => new Vector4I10F22(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YXXZ() => new Vector4I10F22(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YXXW() => new Vector4I10F22(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YXYX() => new Vector4I10F22(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YXYY() => new Vector4I10F22(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YXYZ() => new Vector4I10F22(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YXYW() => new Vector4I10F22(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YXZX() => new Vector4I10F22(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YXZY() => new Vector4I10F22(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YXZZ() => new Vector4I10F22(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YXZW() => new Vector4I10F22(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YXWX() => new Vector4I10F22(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YXWY() => new Vector4I10F22(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YXWZ() => new Vector4I10F22(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YXWW() => new Vector4I10F22(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YYXX() => new Vector4I10F22(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YYXY() => new Vector4I10F22(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YYXZ() => new Vector4I10F22(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YYXW() => new Vector4I10F22(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YYYX() => new Vector4I10F22(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YYYY() => new Vector4I10F22(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YYYZ() => new Vector4I10F22(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YYYW() => new Vector4I10F22(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YYZX() => new Vector4I10F22(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YYZY() => new Vector4I10F22(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YYZZ() => new Vector4I10F22(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YYZW() => new Vector4I10F22(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YYWX() => new Vector4I10F22(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YYWY() => new Vector4I10F22(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YYWZ() => new Vector4I10F22(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YYWW() => new Vector4I10F22(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YZXX() => new Vector4I10F22(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YZXY() => new Vector4I10F22(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YZXZ() => new Vector4I10F22(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YZXW() => new Vector4I10F22(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YZYX() => new Vector4I10F22(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YZYY() => new Vector4I10F22(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YZYZ() => new Vector4I10F22(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YZYW() => new Vector4I10F22(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YZZX() => new Vector4I10F22(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YZZY() => new Vector4I10F22(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YZZZ() => new Vector4I10F22(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YZZW() => new Vector4I10F22(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YZWX() => new Vector4I10F22(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YZWY() => new Vector4I10F22(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YZWZ() => new Vector4I10F22(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YZWW() => new Vector4I10F22(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YWXX() => new Vector4I10F22(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YWXY() => new Vector4I10F22(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YWXZ() => new Vector4I10F22(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YWXW() => new Vector4I10F22(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YWYX() => new Vector4I10F22(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YWYY() => new Vector4I10F22(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YWYZ() => new Vector4I10F22(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YWYW() => new Vector4I10F22(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YWZX() => new Vector4I10F22(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YWZY() => new Vector4I10F22(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YWZZ() => new Vector4I10F22(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YWZW() => new Vector4I10F22(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YWWX() => new Vector4I10F22(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YWWY() => new Vector4I10F22(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YWWZ() => new Vector4I10F22(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 YWWW() => new Vector4I10F22(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZXXX() => new Vector4I10F22(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZXXY() => new Vector4I10F22(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZXXZ() => new Vector4I10F22(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZXXW() => new Vector4I10F22(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZXYX() => new Vector4I10F22(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZXYY() => new Vector4I10F22(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZXYZ() => new Vector4I10F22(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZXYW() => new Vector4I10F22(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZXZX() => new Vector4I10F22(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZXZY() => new Vector4I10F22(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZXZZ() => new Vector4I10F22(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZXZW() => new Vector4I10F22(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZXWX() => new Vector4I10F22(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZXWY() => new Vector4I10F22(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZXWZ() => new Vector4I10F22(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZXWW() => new Vector4I10F22(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZYXX() => new Vector4I10F22(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZYXY() => new Vector4I10F22(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZYXZ() => new Vector4I10F22(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZYXW() => new Vector4I10F22(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZYYX() => new Vector4I10F22(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZYYY() => new Vector4I10F22(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZYYZ() => new Vector4I10F22(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZYYW() => new Vector4I10F22(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZYZX() => new Vector4I10F22(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZYZY() => new Vector4I10F22(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZYZZ() => new Vector4I10F22(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZYZW() => new Vector4I10F22(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZYWX() => new Vector4I10F22(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZYWY() => new Vector4I10F22(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZYWZ() => new Vector4I10F22(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZYWW() => new Vector4I10F22(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZZXX() => new Vector4I10F22(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZZXY() => new Vector4I10F22(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZZXZ() => new Vector4I10F22(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZZXW() => new Vector4I10F22(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZZYX() => new Vector4I10F22(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZZYY() => new Vector4I10F22(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZZYZ() => new Vector4I10F22(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZZYW() => new Vector4I10F22(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZZZX() => new Vector4I10F22(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZZZY() => new Vector4I10F22(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZZZZ() => new Vector4I10F22(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZZZW() => new Vector4I10F22(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZZWX() => new Vector4I10F22(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZZWY() => new Vector4I10F22(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZZWZ() => new Vector4I10F22(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZZWW() => new Vector4I10F22(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZWXX() => new Vector4I10F22(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZWXY() => new Vector4I10F22(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZWXZ() => new Vector4I10F22(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZWXW() => new Vector4I10F22(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZWYX() => new Vector4I10F22(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZWYY() => new Vector4I10F22(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZWYZ() => new Vector4I10F22(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZWYW() => new Vector4I10F22(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZWZX() => new Vector4I10F22(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZWZY() => new Vector4I10F22(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZWZZ() => new Vector4I10F22(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZWZW() => new Vector4I10F22(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZWWX() => new Vector4I10F22(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZWWY() => new Vector4I10F22(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZWWZ() => new Vector4I10F22(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 ZWWW() => new Vector4I10F22(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WXXX() => new Vector4I10F22(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WXXY() => new Vector4I10F22(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WXXZ() => new Vector4I10F22(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WXXW() => new Vector4I10F22(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WXYX() => new Vector4I10F22(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WXYY() => new Vector4I10F22(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WXYZ() => new Vector4I10F22(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WXYW() => new Vector4I10F22(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WXZX() => new Vector4I10F22(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WXZY() => new Vector4I10F22(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WXZZ() => new Vector4I10F22(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WXZW() => new Vector4I10F22(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WXWX() => new Vector4I10F22(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WXWY() => new Vector4I10F22(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WXWZ() => new Vector4I10F22(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WXWW() => new Vector4I10F22(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WYXX() => new Vector4I10F22(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WYXY() => new Vector4I10F22(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WYXZ() => new Vector4I10F22(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WYXW() => new Vector4I10F22(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WYYX() => new Vector4I10F22(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WYYY() => new Vector4I10F22(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WYYZ() => new Vector4I10F22(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WYYW() => new Vector4I10F22(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WYZX() => new Vector4I10F22(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WYZY() => new Vector4I10F22(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WYZZ() => new Vector4I10F22(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WYZW() => new Vector4I10F22(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WYWX() => new Vector4I10F22(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WYWY() => new Vector4I10F22(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WYWZ() => new Vector4I10F22(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WYWW() => new Vector4I10F22(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WZXX() => new Vector4I10F22(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WZXY() => new Vector4I10F22(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WZXZ() => new Vector4I10F22(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WZXW() => new Vector4I10F22(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WZYX() => new Vector4I10F22(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WZYY() => new Vector4I10F22(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WZYZ() => new Vector4I10F22(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WZYW() => new Vector4I10F22(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WZZX() => new Vector4I10F22(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WZZY() => new Vector4I10F22(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WZZZ() => new Vector4I10F22(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WZZW() => new Vector4I10F22(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WZWX() => new Vector4I10F22(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WZWY() => new Vector4I10F22(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WZWZ() => new Vector4I10F22(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WZWW() => new Vector4I10F22(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WWXX() => new Vector4I10F22(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WWXY() => new Vector4I10F22(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WWXZ() => new Vector4I10F22(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WWXW() => new Vector4I10F22(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WWYX() => new Vector4I10F22(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WWYY() => new Vector4I10F22(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WWYZ() => new Vector4I10F22(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WWYW() => new Vector4I10F22(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WWZX() => new Vector4I10F22(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WWZY() => new Vector4I10F22(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WWZZ() => new Vector4I10F22(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WWZW() => new Vector4I10F22(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WWWX() => new Vector4I10F22(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WWWY() => new Vector4I10F22(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WWWZ() => new Vector4I10F22(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I10F22 WWWW() => new Vector4I10F22(W, W, W, W);

    }
}
