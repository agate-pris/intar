using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I24F8
    : IEquatable<Vector4I24F8>
    , IFormattable
    , IVector<U50F14, I50F14, U25F7, I25F7>
    , IVectorComponentRespective<I24F8> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I24F8 X;
        public I24F8 Y;
        public I24F8 Z;
        public I24F8 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8(I24F8 x, I24F8 y, I24F8 z, I24F8 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8(I24F8 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8(I24F8 x, I24F8 y, Vector2I24F8 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8(I24F8 x, Vector3I24F8 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8(Vector2I24F8 xy, Vector2I24F8 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8(Vector4I24F8 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8(I24F8 x, Vector2I24F8 yz, I24F8 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8(Vector3I24F8 xyz, I24F8 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8(Vector2I24F8 xy, I24F8 z, I24F8 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I24F8 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I24F8(I24F8.Zero);
        }
        public static Vector4I24F8 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I24F8(I24F8.One);
        }
        public static Vector4I24F8 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I24F8(I24F8.One, I24F8.Zero, I24F8.Zero, I24F8.Zero);
        }
        public static Vector4I24F8 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I24F8(I24F8.Zero, I24F8.One, I24F8.Zero, I24F8.Zero);
        }
        public static Vector4I24F8 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I24F8(I24F8.Zero, I24F8.Zero, I24F8.One, I24F8.Zero);
        }
        public static Vector4I24F8 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I24F8(I24F8.Zero, I24F8.Zero, I24F8.Zero, I24F8.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 operator +(Vector4I24F8 a, Vector4I24F8 b) => new Vector4I24F8(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 operator -(Vector4I24F8 a, Vector4I24F8 b) => new Vector4I24F8(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 operator *(Vector4I24F8 a, Vector4I24F8 b) => new Vector4I24F8(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 operator *(Vector4I24F8 a, I24F8 b) => new Vector4I24F8(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 operator *(I24F8 a, Vector4I24F8 b) => new Vector4I24F8(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 operator /(Vector4I24F8 a, Vector4I24F8 b) => new Vector4I24F8(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 operator /(Vector4I24F8 a, I24F8 b) => new Vector4I24F8(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I24F8 operator /(I24F8 a, Vector4I24F8 b) => new Vector4I24F8(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I24F8 lhs, Vector4I24F8 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I24F8 lhs, Vector4I24F8 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I24F8 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4I24F8 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I24F8>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I24F8 other)
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
        public Vector4I24F8 Min(Vector4I24F8 other) => new Vector4I24F8(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8 Max(Vector4I24F8 other) => new Vector4I24F8(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8 Abs() => new Vector4I24F8(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8 Half() => new Vector4I24F8(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8 Twice() => new Vector4I24F8(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8 Clamp(I24F8 min, I24F8 max) => new Vector4I24F8(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8 Clamp(
            Vector4I24F8 min, Vector4I24F8 max
        ) => new Vector4I24F8(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8 WrappingAdd(Vector4I24F8 other) => new Vector4I24F8(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8 WrappingSub(Vector4I24F8 other) => new Vector4I24F8(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8 WrappingMul(Vector4I24F8 other) => new Vector4I24F8(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8 WrappingAddUnsigned(Vector4U24F8 other) => new Vector4I24F8(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8 WrappingSubUnsigned(Vector4U24F8 other) => new Vector4I24F8(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U24F8 UnsignedAbs() => new Vector4U24F8(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8 SaturatingAdd(Vector4I24F8 other) => new Vector4I24F8(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8 SaturatingMul(I24F8 other) => new Vector4I24F8(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I24F8 other) {
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
        public I24F8 Dot(Vector4I24F8 other) {
            const long k = 1L << 6;
            return I24F8.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I24F8 SaturatingDot(Vector4I24F8 other) {
            const long k = 1L << 6;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I24F8.MaxValue;
            } else if (bits < int.MinValue) {
                return I24F8.MinValue;
            } else {
                return I24F8.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U50F14 LengthSquaredUnsigned() => U50F14.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I50F14 LengthSquaredSigned() => I50F14.FromBits(
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
        public I50F14 LengthSquared() => LengthSquaredSigned();

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
        public U24F8 LengthHalfUnsigned() => U24F8.FromBits(LengthInternal());

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
        public I24F8 LengthHalf() => I24F8.FromBits(checked((int)LengthInternal()));

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
        public U25F7 LengthUnsigned() => U25F7.FromBits(LengthInternal());

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
        public I25F7 LengthSigned() => I25F7.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I25F7 Length() => LengthSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I24F8? Normalize() {
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

            const ulong k = 1UL << 7;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);
            var y3 = (int)(l3 * k / ll);

            return new Vector4I24F8(
                I24F8.FromBits(b0 ? -y0 : y0),
                I24F8.FromBits(b1 ? -y1 : y1),
                I24F8.FromBits(b2 ? -y2 : y2),
                I24F8.FromBits(b3 ? -y3 : y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I24F8 XX() => new Vector2I24F8(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I24F8 XY() => new Vector2I24F8(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I24F8 XZ() => new Vector2I24F8(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I24F8 XW() => new Vector2I24F8(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I24F8 YX() => new Vector2I24F8(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I24F8 YY() => new Vector2I24F8(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I24F8 YZ() => new Vector2I24F8(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I24F8 YW() => new Vector2I24F8(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I24F8 ZX() => new Vector2I24F8(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I24F8 ZY() => new Vector2I24F8(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I24F8 ZZ() => new Vector2I24F8(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I24F8 ZW() => new Vector2I24F8(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I24F8 WX() => new Vector2I24F8(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I24F8 WY() => new Vector2I24F8(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I24F8 WZ() => new Vector2I24F8(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I24F8 WW() => new Vector2I24F8(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 XXX() => new Vector3I24F8(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 XXY() => new Vector3I24F8(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 XXZ() => new Vector3I24F8(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 XXW() => new Vector3I24F8(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 XYX() => new Vector3I24F8(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 XYY() => new Vector3I24F8(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 XYZ() => new Vector3I24F8(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 XYW() => new Vector3I24F8(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 XZX() => new Vector3I24F8(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 XZY() => new Vector3I24F8(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 XZZ() => new Vector3I24F8(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 XZW() => new Vector3I24F8(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 XWX() => new Vector3I24F8(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 XWY() => new Vector3I24F8(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 XWZ() => new Vector3I24F8(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 XWW() => new Vector3I24F8(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 YXX() => new Vector3I24F8(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 YXY() => new Vector3I24F8(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 YXZ() => new Vector3I24F8(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 YXW() => new Vector3I24F8(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 YYX() => new Vector3I24F8(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 YYY() => new Vector3I24F8(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 YYZ() => new Vector3I24F8(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 YYW() => new Vector3I24F8(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 YZX() => new Vector3I24F8(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 YZY() => new Vector3I24F8(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 YZZ() => new Vector3I24F8(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 YZW() => new Vector3I24F8(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 YWX() => new Vector3I24F8(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 YWY() => new Vector3I24F8(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 YWZ() => new Vector3I24F8(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 YWW() => new Vector3I24F8(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 ZXX() => new Vector3I24F8(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 ZXY() => new Vector3I24F8(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 ZXZ() => new Vector3I24F8(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 ZXW() => new Vector3I24F8(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 ZYX() => new Vector3I24F8(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 ZYY() => new Vector3I24F8(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 ZYZ() => new Vector3I24F8(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 ZYW() => new Vector3I24F8(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 ZZX() => new Vector3I24F8(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 ZZY() => new Vector3I24F8(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 ZZZ() => new Vector3I24F8(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 ZZW() => new Vector3I24F8(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 ZWX() => new Vector3I24F8(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 ZWY() => new Vector3I24F8(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 ZWZ() => new Vector3I24F8(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 ZWW() => new Vector3I24F8(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 WXX() => new Vector3I24F8(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 WXY() => new Vector3I24F8(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 WXZ() => new Vector3I24F8(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 WXW() => new Vector3I24F8(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 WYX() => new Vector3I24F8(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 WYY() => new Vector3I24F8(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 WYZ() => new Vector3I24F8(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 WYW() => new Vector3I24F8(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 WZX() => new Vector3I24F8(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 WZY() => new Vector3I24F8(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 WZZ() => new Vector3I24F8(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 WZW() => new Vector3I24F8(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 WWX() => new Vector3I24F8(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 WWY() => new Vector3I24F8(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 WWZ() => new Vector3I24F8(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I24F8 WWW() => new Vector3I24F8(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XXXX() => new Vector4I24F8(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XXXY() => new Vector4I24F8(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XXXZ() => new Vector4I24F8(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XXXW() => new Vector4I24F8(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XXYX() => new Vector4I24F8(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XXYY() => new Vector4I24F8(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XXYZ() => new Vector4I24F8(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XXYW() => new Vector4I24F8(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XXZX() => new Vector4I24F8(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XXZY() => new Vector4I24F8(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XXZZ() => new Vector4I24F8(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XXZW() => new Vector4I24F8(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XXWX() => new Vector4I24F8(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XXWY() => new Vector4I24F8(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XXWZ() => new Vector4I24F8(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XXWW() => new Vector4I24F8(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XYXX() => new Vector4I24F8(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XYXY() => new Vector4I24F8(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XYXZ() => new Vector4I24F8(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XYXW() => new Vector4I24F8(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XYYX() => new Vector4I24F8(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XYYY() => new Vector4I24F8(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XYYZ() => new Vector4I24F8(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XYYW() => new Vector4I24F8(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XYZX() => new Vector4I24F8(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XYZY() => new Vector4I24F8(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XYZZ() => new Vector4I24F8(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XYZW() => new Vector4I24F8(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XYWX() => new Vector4I24F8(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XYWY() => new Vector4I24F8(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XYWZ() => new Vector4I24F8(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XYWW() => new Vector4I24F8(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XZXX() => new Vector4I24F8(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XZXY() => new Vector4I24F8(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XZXZ() => new Vector4I24F8(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XZXW() => new Vector4I24F8(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XZYX() => new Vector4I24F8(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XZYY() => new Vector4I24F8(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XZYZ() => new Vector4I24F8(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XZYW() => new Vector4I24F8(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XZZX() => new Vector4I24F8(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XZZY() => new Vector4I24F8(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XZZZ() => new Vector4I24F8(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XZZW() => new Vector4I24F8(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XZWX() => new Vector4I24F8(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XZWY() => new Vector4I24F8(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XZWZ() => new Vector4I24F8(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XZWW() => new Vector4I24F8(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XWXX() => new Vector4I24F8(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XWXY() => new Vector4I24F8(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XWXZ() => new Vector4I24F8(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XWXW() => new Vector4I24F8(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XWYX() => new Vector4I24F8(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XWYY() => new Vector4I24F8(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XWYZ() => new Vector4I24F8(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XWYW() => new Vector4I24F8(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XWZX() => new Vector4I24F8(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XWZY() => new Vector4I24F8(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XWZZ() => new Vector4I24F8(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XWZW() => new Vector4I24F8(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XWWX() => new Vector4I24F8(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XWWY() => new Vector4I24F8(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XWWZ() => new Vector4I24F8(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 XWWW() => new Vector4I24F8(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YXXX() => new Vector4I24F8(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YXXY() => new Vector4I24F8(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YXXZ() => new Vector4I24F8(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YXXW() => new Vector4I24F8(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YXYX() => new Vector4I24F8(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YXYY() => new Vector4I24F8(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YXYZ() => new Vector4I24F8(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YXYW() => new Vector4I24F8(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YXZX() => new Vector4I24F8(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YXZY() => new Vector4I24F8(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YXZZ() => new Vector4I24F8(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YXZW() => new Vector4I24F8(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YXWX() => new Vector4I24F8(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YXWY() => new Vector4I24F8(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YXWZ() => new Vector4I24F8(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YXWW() => new Vector4I24F8(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YYXX() => new Vector4I24F8(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YYXY() => new Vector4I24F8(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YYXZ() => new Vector4I24F8(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YYXW() => new Vector4I24F8(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YYYX() => new Vector4I24F8(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YYYY() => new Vector4I24F8(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YYYZ() => new Vector4I24F8(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YYYW() => new Vector4I24F8(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YYZX() => new Vector4I24F8(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YYZY() => new Vector4I24F8(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YYZZ() => new Vector4I24F8(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YYZW() => new Vector4I24F8(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YYWX() => new Vector4I24F8(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YYWY() => new Vector4I24F8(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YYWZ() => new Vector4I24F8(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YYWW() => new Vector4I24F8(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YZXX() => new Vector4I24F8(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YZXY() => new Vector4I24F8(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YZXZ() => new Vector4I24F8(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YZXW() => new Vector4I24F8(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YZYX() => new Vector4I24F8(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YZYY() => new Vector4I24F8(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YZYZ() => new Vector4I24F8(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YZYW() => new Vector4I24F8(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YZZX() => new Vector4I24F8(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YZZY() => new Vector4I24F8(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YZZZ() => new Vector4I24F8(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YZZW() => new Vector4I24F8(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YZWX() => new Vector4I24F8(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YZWY() => new Vector4I24F8(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YZWZ() => new Vector4I24F8(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YZWW() => new Vector4I24F8(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YWXX() => new Vector4I24F8(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YWXY() => new Vector4I24F8(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YWXZ() => new Vector4I24F8(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YWXW() => new Vector4I24F8(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YWYX() => new Vector4I24F8(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YWYY() => new Vector4I24F8(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YWYZ() => new Vector4I24F8(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YWYW() => new Vector4I24F8(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YWZX() => new Vector4I24F8(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YWZY() => new Vector4I24F8(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YWZZ() => new Vector4I24F8(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YWZW() => new Vector4I24F8(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YWWX() => new Vector4I24F8(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YWWY() => new Vector4I24F8(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YWWZ() => new Vector4I24F8(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 YWWW() => new Vector4I24F8(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZXXX() => new Vector4I24F8(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZXXY() => new Vector4I24F8(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZXXZ() => new Vector4I24F8(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZXXW() => new Vector4I24F8(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZXYX() => new Vector4I24F8(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZXYY() => new Vector4I24F8(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZXYZ() => new Vector4I24F8(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZXYW() => new Vector4I24F8(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZXZX() => new Vector4I24F8(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZXZY() => new Vector4I24F8(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZXZZ() => new Vector4I24F8(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZXZW() => new Vector4I24F8(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZXWX() => new Vector4I24F8(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZXWY() => new Vector4I24F8(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZXWZ() => new Vector4I24F8(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZXWW() => new Vector4I24F8(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZYXX() => new Vector4I24F8(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZYXY() => new Vector4I24F8(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZYXZ() => new Vector4I24F8(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZYXW() => new Vector4I24F8(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZYYX() => new Vector4I24F8(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZYYY() => new Vector4I24F8(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZYYZ() => new Vector4I24F8(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZYYW() => new Vector4I24F8(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZYZX() => new Vector4I24F8(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZYZY() => new Vector4I24F8(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZYZZ() => new Vector4I24F8(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZYZW() => new Vector4I24F8(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZYWX() => new Vector4I24F8(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZYWY() => new Vector4I24F8(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZYWZ() => new Vector4I24F8(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZYWW() => new Vector4I24F8(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZZXX() => new Vector4I24F8(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZZXY() => new Vector4I24F8(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZZXZ() => new Vector4I24F8(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZZXW() => new Vector4I24F8(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZZYX() => new Vector4I24F8(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZZYY() => new Vector4I24F8(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZZYZ() => new Vector4I24F8(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZZYW() => new Vector4I24F8(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZZZX() => new Vector4I24F8(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZZZY() => new Vector4I24F8(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZZZZ() => new Vector4I24F8(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZZZW() => new Vector4I24F8(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZZWX() => new Vector4I24F8(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZZWY() => new Vector4I24F8(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZZWZ() => new Vector4I24F8(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZZWW() => new Vector4I24F8(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZWXX() => new Vector4I24F8(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZWXY() => new Vector4I24F8(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZWXZ() => new Vector4I24F8(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZWXW() => new Vector4I24F8(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZWYX() => new Vector4I24F8(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZWYY() => new Vector4I24F8(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZWYZ() => new Vector4I24F8(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZWYW() => new Vector4I24F8(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZWZX() => new Vector4I24F8(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZWZY() => new Vector4I24F8(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZWZZ() => new Vector4I24F8(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZWZW() => new Vector4I24F8(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZWWX() => new Vector4I24F8(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZWWY() => new Vector4I24F8(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZWWZ() => new Vector4I24F8(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 ZWWW() => new Vector4I24F8(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WXXX() => new Vector4I24F8(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WXXY() => new Vector4I24F8(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WXXZ() => new Vector4I24F8(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WXXW() => new Vector4I24F8(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WXYX() => new Vector4I24F8(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WXYY() => new Vector4I24F8(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WXYZ() => new Vector4I24F8(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WXYW() => new Vector4I24F8(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WXZX() => new Vector4I24F8(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WXZY() => new Vector4I24F8(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WXZZ() => new Vector4I24F8(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WXZW() => new Vector4I24F8(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WXWX() => new Vector4I24F8(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WXWY() => new Vector4I24F8(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WXWZ() => new Vector4I24F8(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WXWW() => new Vector4I24F8(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WYXX() => new Vector4I24F8(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WYXY() => new Vector4I24F8(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WYXZ() => new Vector4I24F8(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WYXW() => new Vector4I24F8(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WYYX() => new Vector4I24F8(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WYYY() => new Vector4I24F8(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WYYZ() => new Vector4I24F8(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WYYW() => new Vector4I24F8(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WYZX() => new Vector4I24F8(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WYZY() => new Vector4I24F8(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WYZZ() => new Vector4I24F8(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WYZW() => new Vector4I24F8(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WYWX() => new Vector4I24F8(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WYWY() => new Vector4I24F8(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WYWZ() => new Vector4I24F8(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WYWW() => new Vector4I24F8(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WZXX() => new Vector4I24F8(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WZXY() => new Vector4I24F8(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WZXZ() => new Vector4I24F8(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WZXW() => new Vector4I24F8(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WZYX() => new Vector4I24F8(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WZYY() => new Vector4I24F8(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WZYZ() => new Vector4I24F8(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WZYW() => new Vector4I24F8(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WZZX() => new Vector4I24F8(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WZZY() => new Vector4I24F8(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WZZZ() => new Vector4I24F8(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WZZW() => new Vector4I24F8(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WZWX() => new Vector4I24F8(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WZWY() => new Vector4I24F8(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WZWZ() => new Vector4I24F8(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WZWW() => new Vector4I24F8(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WWXX() => new Vector4I24F8(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WWXY() => new Vector4I24F8(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WWXZ() => new Vector4I24F8(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WWXW() => new Vector4I24F8(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WWYX() => new Vector4I24F8(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WWYY() => new Vector4I24F8(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WWYZ() => new Vector4I24F8(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WWYW() => new Vector4I24F8(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WWZX() => new Vector4I24F8(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WWZY() => new Vector4I24F8(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WWZZ() => new Vector4I24F8(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WWZW() => new Vector4I24F8(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WWWX() => new Vector4I24F8(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WWWY() => new Vector4I24F8(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WWWZ() => new Vector4I24F8(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I24F8 WWWW() => new Vector4I24F8(W, W, W, W);

    }
}
