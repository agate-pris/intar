using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I30F2
    : IEquatable<Vector4I30F2>
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
        public I30F2 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2(I30F2 x, I30F2 y, I30F2 z, I30F2 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2(I30F2 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2(I30F2 x, I30F2 y, Vector2I30F2 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2(I30F2 x, Vector3I30F2 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2(Vector2I30F2 xy, Vector2I30F2 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2(Vector4I30F2 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2(I30F2 x, Vector2I30F2 yz, I30F2 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2(Vector3I30F2 xyz, I30F2 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2(Vector2I30F2 xy, I30F2 z, I30F2 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I30F2 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I30F2(I30F2.Zero);
        }
        public static Vector4I30F2 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I30F2(I30F2.One);
        }
        public static Vector4I30F2 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I30F2(I30F2.One, I30F2.Zero, I30F2.Zero, I30F2.Zero);
        }
        public static Vector4I30F2 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I30F2(I30F2.Zero, I30F2.One, I30F2.Zero, I30F2.Zero);
        }
        public static Vector4I30F2 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I30F2(I30F2.Zero, I30F2.Zero, I30F2.One, I30F2.Zero);
        }
        public static Vector4I30F2 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I30F2(I30F2.Zero, I30F2.Zero, I30F2.Zero, I30F2.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 operator +(Vector4I30F2 a, Vector4I30F2 b) => new Vector4I30F2(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 operator -(Vector4I30F2 a, Vector4I30F2 b) => new Vector4I30F2(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 operator *(Vector4I30F2 a, Vector4I30F2 b) => new Vector4I30F2(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 operator *(Vector4I30F2 a, I30F2 b) => new Vector4I30F2(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 operator *(I30F2 a, Vector4I30F2 b) => new Vector4I30F2(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 operator /(Vector4I30F2 a, Vector4I30F2 b) => new Vector4I30F2(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 operator /(Vector4I30F2 a, I30F2 b) => new Vector4I30F2(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I30F2 operator /(I30F2 a, Vector4I30F2 b) => new Vector4I30F2(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I30F2 lhs, Vector4I30F2 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I30F2 lhs, Vector4I30F2 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I30F2 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4I30F2 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I30F2>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I30F2 other)
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
        public Vector4I30F2 Min(Vector4I30F2 other) => new Vector4I30F2(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2 Max(Vector4I30F2 other) => new Vector4I30F2(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2 Abs() => new Vector4I30F2(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2 Half() => new Vector4I30F2(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2 Twice() => new Vector4I30F2(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2 Clamp(I30F2 min, I30F2 max) => new Vector4I30F2(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2 Clamp(
            Vector4I30F2 min, Vector4I30F2 max
        ) => new Vector4I30F2(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2 WrappingAdd(Vector4I30F2 other) => new Vector4I30F2(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2 WrappingSub(Vector4I30F2 other) => new Vector4I30F2(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2 WrappingMul(Vector4I30F2 other) => new Vector4I30F2(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2 WrappingAddUnsigned(Vector4U30F2 other) => new Vector4I30F2(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2 WrappingSubUnsigned(Vector4U30F2 other) => new Vector4I30F2(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U30F2 UnsignedAbs() => new Vector4U30F2(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2 SaturatingAdd(Vector4I30F2 other) => new Vector4I30F2(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I30F2 SaturatingMul(I30F2 other) => new Vector4I30F2(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I30F2 other) {
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
        public I30F2 Dot(Vector4I30F2 other) {
            const long k = 1L << 0;
            return I30F2.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I30F2 SaturatingDot(Vector4I30F2 other) {
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
        public Vector4I30F2? Normalize() {
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

            const ulong k = 1UL << 1;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);
            var y3 = (int)(l3 * k / ll);

            return new Vector4I30F2(
                I30F2.FromBits(b0 ? -y0 : y0),
                I30F2.FromBits(b1 ? -y1 : y1),
                I30F2.FromBits(b2 ? -y2 : y2),
                I30F2.FromBits(b3 ? -y3 : y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 XX() => new Vector2I30F2(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 XY() => new Vector2I30F2(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 XZ() => new Vector2I30F2(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 XW() => new Vector2I30F2(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 YX() => new Vector2I30F2(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 YY() => new Vector2I30F2(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 YZ() => new Vector2I30F2(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 YW() => new Vector2I30F2(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 ZX() => new Vector2I30F2(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 ZY() => new Vector2I30F2(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 ZZ() => new Vector2I30F2(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 ZW() => new Vector2I30F2(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 WX() => new Vector2I30F2(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 WY() => new Vector2I30F2(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 WZ() => new Vector2I30F2(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I30F2 WW() => new Vector2I30F2(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XXX() => new Vector3I30F2(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XXY() => new Vector3I30F2(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XXZ() => new Vector3I30F2(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XXW() => new Vector3I30F2(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XYX() => new Vector3I30F2(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XYY() => new Vector3I30F2(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XYZ() => new Vector3I30F2(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XYW() => new Vector3I30F2(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XZX() => new Vector3I30F2(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XZY() => new Vector3I30F2(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XZZ() => new Vector3I30F2(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XZW() => new Vector3I30F2(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XWX() => new Vector3I30F2(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XWY() => new Vector3I30F2(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XWZ() => new Vector3I30F2(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 XWW() => new Vector3I30F2(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YXX() => new Vector3I30F2(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YXY() => new Vector3I30F2(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YXZ() => new Vector3I30F2(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YXW() => new Vector3I30F2(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YYX() => new Vector3I30F2(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YYY() => new Vector3I30F2(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YYZ() => new Vector3I30F2(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YYW() => new Vector3I30F2(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YZX() => new Vector3I30F2(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YZY() => new Vector3I30F2(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YZZ() => new Vector3I30F2(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YZW() => new Vector3I30F2(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YWX() => new Vector3I30F2(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YWY() => new Vector3I30F2(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YWZ() => new Vector3I30F2(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 YWW() => new Vector3I30F2(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZXX() => new Vector3I30F2(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZXY() => new Vector3I30F2(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZXZ() => new Vector3I30F2(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZXW() => new Vector3I30F2(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZYX() => new Vector3I30F2(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZYY() => new Vector3I30F2(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZYZ() => new Vector3I30F2(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZYW() => new Vector3I30F2(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZZX() => new Vector3I30F2(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZZY() => new Vector3I30F2(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZZZ() => new Vector3I30F2(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZZW() => new Vector3I30F2(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZWX() => new Vector3I30F2(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZWY() => new Vector3I30F2(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZWZ() => new Vector3I30F2(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 ZWW() => new Vector3I30F2(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 WXX() => new Vector3I30F2(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 WXY() => new Vector3I30F2(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 WXZ() => new Vector3I30F2(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 WXW() => new Vector3I30F2(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 WYX() => new Vector3I30F2(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 WYY() => new Vector3I30F2(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 WYZ() => new Vector3I30F2(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 WYW() => new Vector3I30F2(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 WZX() => new Vector3I30F2(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 WZY() => new Vector3I30F2(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 WZZ() => new Vector3I30F2(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 WZW() => new Vector3I30F2(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 WWX() => new Vector3I30F2(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 WWY() => new Vector3I30F2(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 WWZ() => new Vector3I30F2(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I30F2 WWW() => new Vector3I30F2(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXXX() => new Vector4I30F2(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXXY() => new Vector4I30F2(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXXZ() => new Vector4I30F2(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXXW() => new Vector4I30F2(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXYX() => new Vector4I30F2(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXYY() => new Vector4I30F2(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXYZ() => new Vector4I30F2(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXYW() => new Vector4I30F2(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXZX() => new Vector4I30F2(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXZY() => new Vector4I30F2(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXZZ() => new Vector4I30F2(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXZW() => new Vector4I30F2(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXWX() => new Vector4I30F2(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXWY() => new Vector4I30F2(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXWZ() => new Vector4I30F2(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XXWW() => new Vector4I30F2(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYXX() => new Vector4I30F2(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYXY() => new Vector4I30F2(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYXZ() => new Vector4I30F2(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYXW() => new Vector4I30F2(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYYX() => new Vector4I30F2(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYYY() => new Vector4I30F2(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYYZ() => new Vector4I30F2(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYYW() => new Vector4I30F2(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYZX() => new Vector4I30F2(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYZY() => new Vector4I30F2(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYZZ() => new Vector4I30F2(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYZW() => new Vector4I30F2(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYWX() => new Vector4I30F2(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYWY() => new Vector4I30F2(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYWZ() => new Vector4I30F2(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XYWW() => new Vector4I30F2(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZXX() => new Vector4I30F2(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZXY() => new Vector4I30F2(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZXZ() => new Vector4I30F2(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZXW() => new Vector4I30F2(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZYX() => new Vector4I30F2(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZYY() => new Vector4I30F2(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZYZ() => new Vector4I30F2(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZYW() => new Vector4I30F2(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZZX() => new Vector4I30F2(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZZY() => new Vector4I30F2(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZZZ() => new Vector4I30F2(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZZW() => new Vector4I30F2(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZWX() => new Vector4I30F2(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZWY() => new Vector4I30F2(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZWZ() => new Vector4I30F2(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XZWW() => new Vector4I30F2(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XWXX() => new Vector4I30F2(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XWXY() => new Vector4I30F2(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XWXZ() => new Vector4I30F2(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XWXW() => new Vector4I30F2(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XWYX() => new Vector4I30F2(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XWYY() => new Vector4I30F2(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XWYZ() => new Vector4I30F2(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XWYW() => new Vector4I30F2(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XWZX() => new Vector4I30F2(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XWZY() => new Vector4I30F2(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XWZZ() => new Vector4I30F2(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XWZW() => new Vector4I30F2(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XWWX() => new Vector4I30F2(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XWWY() => new Vector4I30F2(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XWWZ() => new Vector4I30F2(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 XWWW() => new Vector4I30F2(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXXX() => new Vector4I30F2(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXXY() => new Vector4I30F2(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXXZ() => new Vector4I30F2(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXXW() => new Vector4I30F2(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXYX() => new Vector4I30F2(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXYY() => new Vector4I30F2(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXYZ() => new Vector4I30F2(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXYW() => new Vector4I30F2(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXZX() => new Vector4I30F2(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXZY() => new Vector4I30F2(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXZZ() => new Vector4I30F2(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXZW() => new Vector4I30F2(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXWX() => new Vector4I30F2(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXWY() => new Vector4I30F2(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXWZ() => new Vector4I30F2(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YXWW() => new Vector4I30F2(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYXX() => new Vector4I30F2(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYXY() => new Vector4I30F2(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYXZ() => new Vector4I30F2(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYXW() => new Vector4I30F2(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYYX() => new Vector4I30F2(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYYY() => new Vector4I30F2(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYYZ() => new Vector4I30F2(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYYW() => new Vector4I30F2(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYZX() => new Vector4I30F2(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYZY() => new Vector4I30F2(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYZZ() => new Vector4I30F2(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYZW() => new Vector4I30F2(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYWX() => new Vector4I30F2(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYWY() => new Vector4I30F2(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYWZ() => new Vector4I30F2(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YYWW() => new Vector4I30F2(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZXX() => new Vector4I30F2(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZXY() => new Vector4I30F2(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZXZ() => new Vector4I30F2(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZXW() => new Vector4I30F2(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZYX() => new Vector4I30F2(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZYY() => new Vector4I30F2(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZYZ() => new Vector4I30F2(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZYW() => new Vector4I30F2(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZZX() => new Vector4I30F2(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZZY() => new Vector4I30F2(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZZZ() => new Vector4I30F2(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZZW() => new Vector4I30F2(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZWX() => new Vector4I30F2(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZWY() => new Vector4I30F2(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZWZ() => new Vector4I30F2(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YZWW() => new Vector4I30F2(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YWXX() => new Vector4I30F2(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YWXY() => new Vector4I30F2(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YWXZ() => new Vector4I30F2(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YWXW() => new Vector4I30F2(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YWYX() => new Vector4I30F2(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YWYY() => new Vector4I30F2(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YWYZ() => new Vector4I30F2(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YWYW() => new Vector4I30F2(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YWZX() => new Vector4I30F2(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YWZY() => new Vector4I30F2(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YWZZ() => new Vector4I30F2(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YWZW() => new Vector4I30F2(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YWWX() => new Vector4I30F2(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YWWY() => new Vector4I30F2(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YWWZ() => new Vector4I30F2(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 YWWW() => new Vector4I30F2(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXXX() => new Vector4I30F2(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXXY() => new Vector4I30F2(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXXZ() => new Vector4I30F2(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXXW() => new Vector4I30F2(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXYX() => new Vector4I30F2(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXYY() => new Vector4I30F2(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXYZ() => new Vector4I30F2(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXYW() => new Vector4I30F2(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXZX() => new Vector4I30F2(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXZY() => new Vector4I30F2(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXZZ() => new Vector4I30F2(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXZW() => new Vector4I30F2(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXWX() => new Vector4I30F2(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXWY() => new Vector4I30F2(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXWZ() => new Vector4I30F2(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZXWW() => new Vector4I30F2(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYXX() => new Vector4I30F2(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYXY() => new Vector4I30F2(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYXZ() => new Vector4I30F2(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYXW() => new Vector4I30F2(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYYX() => new Vector4I30F2(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYYY() => new Vector4I30F2(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYYZ() => new Vector4I30F2(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYYW() => new Vector4I30F2(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYZX() => new Vector4I30F2(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYZY() => new Vector4I30F2(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYZZ() => new Vector4I30F2(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYZW() => new Vector4I30F2(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYWX() => new Vector4I30F2(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYWY() => new Vector4I30F2(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYWZ() => new Vector4I30F2(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZYWW() => new Vector4I30F2(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZXX() => new Vector4I30F2(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZXY() => new Vector4I30F2(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZXZ() => new Vector4I30F2(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZXW() => new Vector4I30F2(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZYX() => new Vector4I30F2(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZYY() => new Vector4I30F2(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZYZ() => new Vector4I30F2(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZYW() => new Vector4I30F2(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZZX() => new Vector4I30F2(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZZY() => new Vector4I30F2(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZZZ() => new Vector4I30F2(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZZW() => new Vector4I30F2(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZWX() => new Vector4I30F2(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZWY() => new Vector4I30F2(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZWZ() => new Vector4I30F2(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZZWW() => new Vector4I30F2(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZWXX() => new Vector4I30F2(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZWXY() => new Vector4I30F2(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZWXZ() => new Vector4I30F2(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZWXW() => new Vector4I30F2(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZWYX() => new Vector4I30F2(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZWYY() => new Vector4I30F2(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZWYZ() => new Vector4I30F2(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZWYW() => new Vector4I30F2(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZWZX() => new Vector4I30F2(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZWZY() => new Vector4I30F2(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZWZZ() => new Vector4I30F2(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZWZW() => new Vector4I30F2(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZWWX() => new Vector4I30F2(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZWWY() => new Vector4I30F2(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZWWZ() => new Vector4I30F2(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 ZWWW() => new Vector4I30F2(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WXXX() => new Vector4I30F2(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WXXY() => new Vector4I30F2(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WXXZ() => new Vector4I30F2(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WXXW() => new Vector4I30F2(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WXYX() => new Vector4I30F2(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WXYY() => new Vector4I30F2(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WXYZ() => new Vector4I30F2(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WXYW() => new Vector4I30F2(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WXZX() => new Vector4I30F2(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WXZY() => new Vector4I30F2(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WXZZ() => new Vector4I30F2(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WXZW() => new Vector4I30F2(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WXWX() => new Vector4I30F2(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WXWY() => new Vector4I30F2(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WXWZ() => new Vector4I30F2(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WXWW() => new Vector4I30F2(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WYXX() => new Vector4I30F2(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WYXY() => new Vector4I30F2(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WYXZ() => new Vector4I30F2(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WYXW() => new Vector4I30F2(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WYYX() => new Vector4I30F2(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WYYY() => new Vector4I30F2(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WYYZ() => new Vector4I30F2(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WYYW() => new Vector4I30F2(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WYZX() => new Vector4I30F2(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WYZY() => new Vector4I30F2(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WYZZ() => new Vector4I30F2(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WYZW() => new Vector4I30F2(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WYWX() => new Vector4I30F2(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WYWY() => new Vector4I30F2(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WYWZ() => new Vector4I30F2(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WYWW() => new Vector4I30F2(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WZXX() => new Vector4I30F2(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WZXY() => new Vector4I30F2(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WZXZ() => new Vector4I30F2(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WZXW() => new Vector4I30F2(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WZYX() => new Vector4I30F2(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WZYY() => new Vector4I30F2(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WZYZ() => new Vector4I30F2(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WZYW() => new Vector4I30F2(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WZZX() => new Vector4I30F2(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WZZY() => new Vector4I30F2(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WZZZ() => new Vector4I30F2(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WZZW() => new Vector4I30F2(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WZWX() => new Vector4I30F2(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WZWY() => new Vector4I30F2(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WZWZ() => new Vector4I30F2(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WZWW() => new Vector4I30F2(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WWXX() => new Vector4I30F2(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WWXY() => new Vector4I30F2(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WWXZ() => new Vector4I30F2(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WWXW() => new Vector4I30F2(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WWYX() => new Vector4I30F2(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WWYY() => new Vector4I30F2(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WWYZ() => new Vector4I30F2(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WWYW() => new Vector4I30F2(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WWZX() => new Vector4I30F2(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WWZY() => new Vector4I30F2(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WWZZ() => new Vector4I30F2(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WWZW() => new Vector4I30F2(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WWWX() => new Vector4I30F2(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WWWY() => new Vector4I30F2(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WWWZ() => new Vector4I30F2(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I30F2 WWWW() => new Vector4I30F2(W, W, W, W);

    }
}
