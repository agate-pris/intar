using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I14F18
    : IEquatable<Vector4I14F18>
    , IFormattable
    , IVector<U30F34, I30F34, U15F17, I15F17>
    , IVectorComponentRespective<I14F18> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I14F18 X;
        public I14F18 Y;
        public I14F18 Z;
        public I14F18 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(I14F18 x, I14F18 y, I14F18 z, I14F18 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(I14F18 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(I14F18 x, I14F18 y, Vector2I14F18 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(I14F18 x, Vector3I14F18 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(Vector2I14F18 xy, Vector2I14F18 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(Vector4I14F18 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(I14F18 x, Vector2I14F18 yz, I14F18 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(Vector3I14F18 xyz, I14F18 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18(Vector2I14F18 xy, I14F18 z, I14F18 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I14F18 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I14F18(I14F18.Zero);
        }
        public static Vector4I14F18 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I14F18(I14F18.One);
        }
        public static Vector4I14F18 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I14F18(I14F18.One, I14F18.Zero, I14F18.Zero, I14F18.Zero);
        }
        public static Vector4I14F18 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I14F18(I14F18.Zero, I14F18.One, I14F18.Zero, I14F18.Zero);
        }
        public static Vector4I14F18 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I14F18(I14F18.Zero, I14F18.Zero, I14F18.One, I14F18.Zero);
        }
        public static Vector4I14F18 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I14F18(I14F18.Zero, I14F18.Zero, I14F18.Zero, I14F18.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 operator +(Vector4I14F18 a, Vector4I14F18 b) => new Vector4I14F18(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 operator -(Vector4I14F18 a, Vector4I14F18 b) => new Vector4I14F18(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 operator *(Vector4I14F18 a, Vector4I14F18 b) => new Vector4I14F18(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 operator *(Vector4I14F18 a, I14F18 b) => new Vector4I14F18(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 operator *(I14F18 a, Vector4I14F18 b) => new Vector4I14F18(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 operator /(Vector4I14F18 a, Vector4I14F18 b) => new Vector4I14F18(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 operator /(Vector4I14F18 a, I14F18 b) => new Vector4I14F18(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I14F18 operator /(I14F18 a, Vector4I14F18 b) => new Vector4I14F18(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I14F18 lhs, Vector4I14F18 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I14F18 lhs, Vector4I14F18 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I14F18 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4I14F18 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I14F18>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I14F18 other)
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
        public Vector4I14F18 Min(Vector4I14F18 other) => new Vector4I14F18(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 Max(Vector4I14F18 other) => new Vector4I14F18(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 Abs() => new Vector4I14F18(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 Half() => new Vector4I14F18(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 Twice() => new Vector4I14F18(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 Clamp(I14F18 min, I14F18 max) => new Vector4I14F18(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 Clamp(
            Vector4I14F18 min, Vector4I14F18 max
        ) => new Vector4I14F18(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 WrappingAdd(Vector4I14F18 other) => new Vector4I14F18(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 WrappingSub(Vector4I14F18 other) => new Vector4I14F18(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 WrappingMul(Vector4I14F18 other) => new Vector4I14F18(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 WrappingAddUnsigned(Vector4U14F18 other) => new Vector4I14F18(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 WrappingSubUnsigned(Vector4U14F18 other) => new Vector4I14F18(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U14F18 UnsignedAbs() => new Vector4U14F18(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 SaturatingAdd(Vector4I14F18 other) => new Vector4I14F18(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18 SaturatingMul(I14F18 other) => new Vector4I14F18(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I14F18 other) {
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
        public I14F18 Dot(Vector4I14F18 other) {
            const long k = 1L << 16;
            return I14F18.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I14F18 SaturatingDot(Vector4I14F18 other) {
            const long k = 1L << 16;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I14F18.MaxValue;
            } else if (bits < int.MinValue) {
                return I14F18.MinValue;
            } else {
                return I14F18.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U30F34 LengthSquaredUnsigned() => U30F34.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I30F34 LengthSquaredSigned() => I30F34.FromBits(
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
        public I30F34 LengthSquared() => LengthSquaredSigned();

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
        public U14F18 LengthHalfUnsigned() => U14F18.FromBits(LengthInternal());

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
        public I14F18 LengthHalf() => I14F18.FromBits(checked((int)LengthInternal()));

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
        public U15F17 LengthUnsigned() => U15F17.FromBits(LengthInternal());

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
        public I15F17 LengthSigned() => I15F17.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I15F17 Length() => LengthSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I14F18? Normalize() {
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

            const ulong k = 1UL << 17;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);
            var y3 = (int)(l3 * k / ll);

            return new Vector4I14F18(
                I14F18.FromBits(b0 ? -y0 : y0),
                I14F18.FromBits(b1 ? -y1 : y1),
                I14F18.FromBits(b2 ? -y2 : y2),
                I14F18.FromBits(b3 ? -y3 : y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I14F18 XX() => new Vector2I14F18(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I14F18 XY() => new Vector2I14F18(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I14F18 XZ() => new Vector2I14F18(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I14F18 XW() => new Vector2I14F18(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I14F18 YX() => new Vector2I14F18(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I14F18 YY() => new Vector2I14F18(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I14F18 YZ() => new Vector2I14F18(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I14F18 YW() => new Vector2I14F18(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I14F18 ZX() => new Vector2I14F18(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I14F18 ZY() => new Vector2I14F18(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I14F18 ZZ() => new Vector2I14F18(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I14F18 ZW() => new Vector2I14F18(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I14F18 WX() => new Vector2I14F18(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I14F18 WY() => new Vector2I14F18(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I14F18 WZ() => new Vector2I14F18(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I14F18 WW() => new Vector2I14F18(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 XXX() => new Vector3I14F18(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 XXY() => new Vector3I14F18(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 XXZ() => new Vector3I14F18(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 XXW() => new Vector3I14F18(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 XYX() => new Vector3I14F18(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 XYY() => new Vector3I14F18(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 XYZ() => new Vector3I14F18(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 XYW() => new Vector3I14F18(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 XZX() => new Vector3I14F18(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 XZY() => new Vector3I14F18(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 XZZ() => new Vector3I14F18(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 XZW() => new Vector3I14F18(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 XWX() => new Vector3I14F18(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 XWY() => new Vector3I14F18(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 XWZ() => new Vector3I14F18(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 XWW() => new Vector3I14F18(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 YXX() => new Vector3I14F18(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 YXY() => new Vector3I14F18(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 YXZ() => new Vector3I14F18(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 YXW() => new Vector3I14F18(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 YYX() => new Vector3I14F18(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 YYY() => new Vector3I14F18(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 YYZ() => new Vector3I14F18(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 YYW() => new Vector3I14F18(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 YZX() => new Vector3I14F18(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 YZY() => new Vector3I14F18(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 YZZ() => new Vector3I14F18(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 YZW() => new Vector3I14F18(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 YWX() => new Vector3I14F18(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 YWY() => new Vector3I14F18(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 YWZ() => new Vector3I14F18(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 YWW() => new Vector3I14F18(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 ZXX() => new Vector3I14F18(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 ZXY() => new Vector3I14F18(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 ZXZ() => new Vector3I14F18(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 ZXW() => new Vector3I14F18(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 ZYX() => new Vector3I14F18(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 ZYY() => new Vector3I14F18(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 ZYZ() => new Vector3I14F18(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 ZYW() => new Vector3I14F18(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 ZZX() => new Vector3I14F18(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 ZZY() => new Vector3I14F18(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 ZZZ() => new Vector3I14F18(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 ZZW() => new Vector3I14F18(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 ZWX() => new Vector3I14F18(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 ZWY() => new Vector3I14F18(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 ZWZ() => new Vector3I14F18(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 ZWW() => new Vector3I14F18(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 WXX() => new Vector3I14F18(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 WXY() => new Vector3I14F18(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 WXZ() => new Vector3I14F18(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 WXW() => new Vector3I14F18(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 WYX() => new Vector3I14F18(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 WYY() => new Vector3I14F18(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 WYZ() => new Vector3I14F18(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 WYW() => new Vector3I14F18(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 WZX() => new Vector3I14F18(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 WZY() => new Vector3I14F18(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 WZZ() => new Vector3I14F18(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 WZW() => new Vector3I14F18(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 WWX() => new Vector3I14F18(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 WWY() => new Vector3I14F18(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 WWZ() => new Vector3I14F18(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I14F18 WWW() => new Vector3I14F18(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XXXX() => new Vector4I14F18(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XXXY() => new Vector4I14F18(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XXXZ() => new Vector4I14F18(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XXXW() => new Vector4I14F18(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XXYX() => new Vector4I14F18(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XXYY() => new Vector4I14F18(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XXYZ() => new Vector4I14F18(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XXYW() => new Vector4I14F18(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XXZX() => new Vector4I14F18(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XXZY() => new Vector4I14F18(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XXZZ() => new Vector4I14F18(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XXZW() => new Vector4I14F18(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XXWX() => new Vector4I14F18(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XXWY() => new Vector4I14F18(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XXWZ() => new Vector4I14F18(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XXWW() => new Vector4I14F18(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XYXX() => new Vector4I14F18(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XYXY() => new Vector4I14F18(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XYXZ() => new Vector4I14F18(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XYXW() => new Vector4I14F18(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XYYX() => new Vector4I14F18(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XYYY() => new Vector4I14F18(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XYYZ() => new Vector4I14F18(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XYYW() => new Vector4I14F18(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XYZX() => new Vector4I14F18(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XYZY() => new Vector4I14F18(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XYZZ() => new Vector4I14F18(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XYZW() => new Vector4I14F18(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XYWX() => new Vector4I14F18(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XYWY() => new Vector4I14F18(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XYWZ() => new Vector4I14F18(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XYWW() => new Vector4I14F18(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XZXX() => new Vector4I14F18(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XZXY() => new Vector4I14F18(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XZXZ() => new Vector4I14F18(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XZXW() => new Vector4I14F18(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XZYX() => new Vector4I14F18(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XZYY() => new Vector4I14F18(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XZYZ() => new Vector4I14F18(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XZYW() => new Vector4I14F18(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XZZX() => new Vector4I14F18(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XZZY() => new Vector4I14F18(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XZZZ() => new Vector4I14F18(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XZZW() => new Vector4I14F18(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XZWX() => new Vector4I14F18(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XZWY() => new Vector4I14F18(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XZWZ() => new Vector4I14F18(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XZWW() => new Vector4I14F18(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XWXX() => new Vector4I14F18(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XWXY() => new Vector4I14F18(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XWXZ() => new Vector4I14F18(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XWXW() => new Vector4I14F18(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XWYX() => new Vector4I14F18(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XWYY() => new Vector4I14F18(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XWYZ() => new Vector4I14F18(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XWYW() => new Vector4I14F18(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XWZX() => new Vector4I14F18(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XWZY() => new Vector4I14F18(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XWZZ() => new Vector4I14F18(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XWZW() => new Vector4I14F18(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XWWX() => new Vector4I14F18(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XWWY() => new Vector4I14F18(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XWWZ() => new Vector4I14F18(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 XWWW() => new Vector4I14F18(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YXXX() => new Vector4I14F18(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YXXY() => new Vector4I14F18(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YXXZ() => new Vector4I14F18(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YXXW() => new Vector4I14F18(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YXYX() => new Vector4I14F18(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YXYY() => new Vector4I14F18(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YXYZ() => new Vector4I14F18(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YXYW() => new Vector4I14F18(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YXZX() => new Vector4I14F18(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YXZY() => new Vector4I14F18(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YXZZ() => new Vector4I14F18(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YXZW() => new Vector4I14F18(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YXWX() => new Vector4I14F18(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YXWY() => new Vector4I14F18(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YXWZ() => new Vector4I14F18(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YXWW() => new Vector4I14F18(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YYXX() => new Vector4I14F18(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YYXY() => new Vector4I14F18(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YYXZ() => new Vector4I14F18(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YYXW() => new Vector4I14F18(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YYYX() => new Vector4I14F18(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YYYY() => new Vector4I14F18(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YYYZ() => new Vector4I14F18(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YYYW() => new Vector4I14F18(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YYZX() => new Vector4I14F18(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YYZY() => new Vector4I14F18(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YYZZ() => new Vector4I14F18(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YYZW() => new Vector4I14F18(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YYWX() => new Vector4I14F18(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YYWY() => new Vector4I14F18(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YYWZ() => new Vector4I14F18(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YYWW() => new Vector4I14F18(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YZXX() => new Vector4I14F18(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YZXY() => new Vector4I14F18(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YZXZ() => new Vector4I14F18(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YZXW() => new Vector4I14F18(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YZYX() => new Vector4I14F18(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YZYY() => new Vector4I14F18(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YZYZ() => new Vector4I14F18(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YZYW() => new Vector4I14F18(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YZZX() => new Vector4I14F18(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YZZY() => new Vector4I14F18(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YZZZ() => new Vector4I14F18(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YZZW() => new Vector4I14F18(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YZWX() => new Vector4I14F18(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YZWY() => new Vector4I14F18(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YZWZ() => new Vector4I14F18(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YZWW() => new Vector4I14F18(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YWXX() => new Vector4I14F18(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YWXY() => new Vector4I14F18(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YWXZ() => new Vector4I14F18(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YWXW() => new Vector4I14F18(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YWYX() => new Vector4I14F18(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YWYY() => new Vector4I14F18(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YWYZ() => new Vector4I14F18(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YWYW() => new Vector4I14F18(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YWZX() => new Vector4I14F18(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YWZY() => new Vector4I14F18(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YWZZ() => new Vector4I14F18(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YWZW() => new Vector4I14F18(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YWWX() => new Vector4I14F18(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YWWY() => new Vector4I14F18(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YWWZ() => new Vector4I14F18(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 YWWW() => new Vector4I14F18(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZXXX() => new Vector4I14F18(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZXXY() => new Vector4I14F18(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZXXZ() => new Vector4I14F18(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZXXW() => new Vector4I14F18(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZXYX() => new Vector4I14F18(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZXYY() => new Vector4I14F18(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZXYZ() => new Vector4I14F18(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZXYW() => new Vector4I14F18(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZXZX() => new Vector4I14F18(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZXZY() => new Vector4I14F18(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZXZZ() => new Vector4I14F18(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZXZW() => new Vector4I14F18(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZXWX() => new Vector4I14F18(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZXWY() => new Vector4I14F18(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZXWZ() => new Vector4I14F18(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZXWW() => new Vector4I14F18(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZYXX() => new Vector4I14F18(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZYXY() => new Vector4I14F18(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZYXZ() => new Vector4I14F18(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZYXW() => new Vector4I14F18(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZYYX() => new Vector4I14F18(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZYYY() => new Vector4I14F18(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZYYZ() => new Vector4I14F18(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZYYW() => new Vector4I14F18(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZYZX() => new Vector4I14F18(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZYZY() => new Vector4I14F18(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZYZZ() => new Vector4I14F18(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZYZW() => new Vector4I14F18(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZYWX() => new Vector4I14F18(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZYWY() => new Vector4I14F18(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZYWZ() => new Vector4I14F18(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZYWW() => new Vector4I14F18(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZZXX() => new Vector4I14F18(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZZXY() => new Vector4I14F18(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZZXZ() => new Vector4I14F18(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZZXW() => new Vector4I14F18(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZZYX() => new Vector4I14F18(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZZYY() => new Vector4I14F18(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZZYZ() => new Vector4I14F18(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZZYW() => new Vector4I14F18(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZZZX() => new Vector4I14F18(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZZZY() => new Vector4I14F18(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZZZZ() => new Vector4I14F18(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZZZW() => new Vector4I14F18(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZZWX() => new Vector4I14F18(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZZWY() => new Vector4I14F18(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZZWZ() => new Vector4I14F18(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZZWW() => new Vector4I14F18(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZWXX() => new Vector4I14F18(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZWXY() => new Vector4I14F18(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZWXZ() => new Vector4I14F18(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZWXW() => new Vector4I14F18(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZWYX() => new Vector4I14F18(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZWYY() => new Vector4I14F18(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZWYZ() => new Vector4I14F18(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZWYW() => new Vector4I14F18(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZWZX() => new Vector4I14F18(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZWZY() => new Vector4I14F18(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZWZZ() => new Vector4I14F18(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZWZW() => new Vector4I14F18(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZWWX() => new Vector4I14F18(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZWWY() => new Vector4I14F18(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZWWZ() => new Vector4I14F18(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 ZWWW() => new Vector4I14F18(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WXXX() => new Vector4I14F18(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WXXY() => new Vector4I14F18(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WXXZ() => new Vector4I14F18(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WXXW() => new Vector4I14F18(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WXYX() => new Vector4I14F18(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WXYY() => new Vector4I14F18(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WXYZ() => new Vector4I14F18(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WXYW() => new Vector4I14F18(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WXZX() => new Vector4I14F18(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WXZY() => new Vector4I14F18(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WXZZ() => new Vector4I14F18(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WXZW() => new Vector4I14F18(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WXWX() => new Vector4I14F18(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WXWY() => new Vector4I14F18(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WXWZ() => new Vector4I14F18(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WXWW() => new Vector4I14F18(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WYXX() => new Vector4I14F18(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WYXY() => new Vector4I14F18(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WYXZ() => new Vector4I14F18(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WYXW() => new Vector4I14F18(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WYYX() => new Vector4I14F18(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WYYY() => new Vector4I14F18(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WYYZ() => new Vector4I14F18(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WYYW() => new Vector4I14F18(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WYZX() => new Vector4I14F18(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WYZY() => new Vector4I14F18(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WYZZ() => new Vector4I14F18(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WYZW() => new Vector4I14F18(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WYWX() => new Vector4I14F18(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WYWY() => new Vector4I14F18(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WYWZ() => new Vector4I14F18(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WYWW() => new Vector4I14F18(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WZXX() => new Vector4I14F18(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WZXY() => new Vector4I14F18(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WZXZ() => new Vector4I14F18(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WZXW() => new Vector4I14F18(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WZYX() => new Vector4I14F18(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WZYY() => new Vector4I14F18(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WZYZ() => new Vector4I14F18(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WZYW() => new Vector4I14F18(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WZZX() => new Vector4I14F18(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WZZY() => new Vector4I14F18(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WZZZ() => new Vector4I14F18(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WZZW() => new Vector4I14F18(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WZWX() => new Vector4I14F18(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WZWY() => new Vector4I14F18(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WZWZ() => new Vector4I14F18(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WZWW() => new Vector4I14F18(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WWXX() => new Vector4I14F18(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WWXY() => new Vector4I14F18(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WWXZ() => new Vector4I14F18(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WWXW() => new Vector4I14F18(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WWYX() => new Vector4I14F18(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WWYY() => new Vector4I14F18(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WWYZ() => new Vector4I14F18(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WWYW() => new Vector4I14F18(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WWZX() => new Vector4I14F18(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WWZY() => new Vector4I14F18(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WWZZ() => new Vector4I14F18(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WWZW() => new Vector4I14F18(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WWWX() => new Vector4I14F18(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WWWY() => new Vector4I14F18(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WWWZ() => new Vector4I14F18(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I14F18 WWWW() => new Vector4I14F18(W, W, W, W);

    }
}
