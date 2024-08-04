using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I20F12
    : IEquatable<Vector4I20F12>
    , IFormattable
    , IVector<U42F22, I42F22, U21F11, I21F11>
    , IVectorComponentRespective<I20F12> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I20F12 X;
        public I20F12 Y;
        public I20F12 Z;
        public I20F12 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(I20F12 x, I20F12 y, I20F12 z, I20F12 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(I20F12 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(I20F12 x, I20F12 y, Vector2I20F12 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(I20F12 x, Vector3I20F12 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(Vector2I20F12 xy, Vector2I20F12 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(Vector4I20F12 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(I20F12 x, Vector2I20F12 yz, I20F12 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(Vector3I20F12 xyz, I20F12 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(Vector2I20F12 xy, I20F12 z, I20F12 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I20F12 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I20F12(I20F12.Zero);
        }
        public static Vector4I20F12 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I20F12(I20F12.One);
        }
        public static Vector4I20F12 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I20F12(I20F12.One, I20F12.Zero, I20F12.Zero, I20F12.Zero);
        }
        public static Vector4I20F12 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I20F12(I20F12.Zero, I20F12.One, I20F12.Zero, I20F12.Zero);
        }
        public static Vector4I20F12 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I20F12(I20F12.Zero, I20F12.Zero, I20F12.One, I20F12.Zero);
        }
        public static Vector4I20F12 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I20F12(I20F12.Zero, I20F12.Zero, I20F12.Zero, I20F12.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 operator +(Vector4I20F12 a, Vector4I20F12 b) => new Vector4I20F12(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 operator -(Vector4I20F12 a, Vector4I20F12 b) => new Vector4I20F12(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 operator *(Vector4I20F12 a, Vector4I20F12 b) => new Vector4I20F12(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 operator *(Vector4I20F12 a, I20F12 b) => new Vector4I20F12(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 operator *(I20F12 a, Vector4I20F12 b) => new Vector4I20F12(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 operator /(Vector4I20F12 a, Vector4I20F12 b) => new Vector4I20F12(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 operator /(Vector4I20F12 a, I20F12 b) => new Vector4I20F12(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 operator /(I20F12 a, Vector4I20F12 b) => new Vector4I20F12(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I20F12 lhs, Vector4I20F12 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I20F12 lhs, Vector4I20F12 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I20F12 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4I20F12 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I20F12>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I20F12 other)
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
        public Vector4I20F12 Min(Vector4I20F12 other) => new Vector4I20F12(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 Max(Vector4I20F12 other) => new Vector4I20F12(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 Abs() => new Vector4I20F12(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 Half() => new Vector4I20F12(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 Twice() => new Vector4I20F12(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 Clamp(I20F12 min, I20F12 max) => new Vector4I20F12(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 Clamp(
            Vector4I20F12 min, Vector4I20F12 max
        ) => new Vector4I20F12(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 WrappingAdd(Vector4I20F12 other) => new Vector4I20F12(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 WrappingSub(Vector4I20F12 other) => new Vector4I20F12(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 WrappingMul(Vector4I20F12 other) => new Vector4I20F12(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 WrappingAddUnsigned(Vector4U20F12 other) => new Vector4I20F12(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 WrappingSubUnsigned(Vector4U20F12 other) => new Vector4I20F12(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12 UnsignedAbs() => new Vector4U20F12(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 SaturatingAdd(Vector4I20F12 other) => new Vector4I20F12(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 SaturatingMul(I20F12 other) => new Vector4I20F12(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I20F12 other) {
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
        public I20F12 Dot(Vector4I20F12 other) {
            const long k = 1L << 10;
            return I20F12.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I20F12 SaturatingDot(Vector4I20F12 other) {
            const long k = 1L << 10;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I20F12.MaxValue;
            } else if (bits < int.MinValue) {
                return I20F12.MinValue;
            } else {
                return I20F12.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U42F22 LengthSquaredUnsigned() => U42F22.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I42F22 LengthSquaredSigned() => I42F22.FromBits(
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
        public I42F22 LengthSquared() => LengthSquaredSigned();

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
        public U20F12 LengthHalfUnsigned() => U20F12.FromBits(LengthInternal());

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
        public I20F12 LengthHalf() => I20F12.FromBits(checked((int)LengthInternal()));

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
        public U21F11 LengthUnsigned() => U21F11.FromBits(LengthInternal());

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
        public I21F11 LengthSigned() => I21F11.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I21F11 Length() => LengthSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12? Normalize() {
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

            const ulong k = 1UL << 11;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);
            var y3 = (int)(l3 * k / ll);

            return new Vector4I20F12(
                I20F12.FromBits(b0 ? -y0 : y0),
                I20F12.FromBits(b1 ? -y1 : y1),
                I20F12.FromBits(b2 ? -y2 : y2),
                I20F12.FromBits(b3 ? -y3 : y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I20F12 XX() => new Vector2I20F12(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I20F12 XY() => new Vector2I20F12(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I20F12 XZ() => new Vector2I20F12(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I20F12 XW() => new Vector2I20F12(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I20F12 YX() => new Vector2I20F12(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I20F12 YY() => new Vector2I20F12(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I20F12 YZ() => new Vector2I20F12(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I20F12 YW() => new Vector2I20F12(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I20F12 ZX() => new Vector2I20F12(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I20F12 ZY() => new Vector2I20F12(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I20F12 ZZ() => new Vector2I20F12(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I20F12 ZW() => new Vector2I20F12(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I20F12 WX() => new Vector2I20F12(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I20F12 WY() => new Vector2I20F12(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I20F12 WZ() => new Vector2I20F12(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I20F12 WW() => new Vector2I20F12(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 XXX() => new Vector3I20F12(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 XXY() => new Vector3I20F12(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 XXZ() => new Vector3I20F12(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 XXW() => new Vector3I20F12(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 XYX() => new Vector3I20F12(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 XYY() => new Vector3I20F12(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 XYZ() => new Vector3I20F12(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 XYW() => new Vector3I20F12(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 XZX() => new Vector3I20F12(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 XZY() => new Vector3I20F12(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 XZZ() => new Vector3I20F12(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 XZW() => new Vector3I20F12(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 XWX() => new Vector3I20F12(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 XWY() => new Vector3I20F12(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 XWZ() => new Vector3I20F12(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 XWW() => new Vector3I20F12(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 YXX() => new Vector3I20F12(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 YXY() => new Vector3I20F12(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 YXZ() => new Vector3I20F12(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 YXW() => new Vector3I20F12(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 YYX() => new Vector3I20F12(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 YYY() => new Vector3I20F12(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 YYZ() => new Vector3I20F12(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 YYW() => new Vector3I20F12(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 YZX() => new Vector3I20F12(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 YZY() => new Vector3I20F12(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 YZZ() => new Vector3I20F12(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 YZW() => new Vector3I20F12(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 YWX() => new Vector3I20F12(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 YWY() => new Vector3I20F12(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 YWZ() => new Vector3I20F12(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 YWW() => new Vector3I20F12(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 ZXX() => new Vector3I20F12(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 ZXY() => new Vector3I20F12(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 ZXZ() => new Vector3I20F12(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 ZXW() => new Vector3I20F12(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 ZYX() => new Vector3I20F12(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 ZYY() => new Vector3I20F12(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 ZYZ() => new Vector3I20F12(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 ZYW() => new Vector3I20F12(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 ZZX() => new Vector3I20F12(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 ZZY() => new Vector3I20F12(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 ZZZ() => new Vector3I20F12(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 ZZW() => new Vector3I20F12(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 ZWX() => new Vector3I20F12(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 ZWY() => new Vector3I20F12(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 ZWZ() => new Vector3I20F12(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 ZWW() => new Vector3I20F12(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 WXX() => new Vector3I20F12(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 WXY() => new Vector3I20F12(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 WXZ() => new Vector3I20F12(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 WXW() => new Vector3I20F12(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 WYX() => new Vector3I20F12(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 WYY() => new Vector3I20F12(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 WYZ() => new Vector3I20F12(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 WYW() => new Vector3I20F12(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 WZX() => new Vector3I20F12(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 WZY() => new Vector3I20F12(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 WZZ() => new Vector3I20F12(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 WZW() => new Vector3I20F12(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 WWX() => new Vector3I20F12(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 WWY() => new Vector3I20F12(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 WWZ() => new Vector3I20F12(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I20F12 WWW() => new Vector3I20F12(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XXXX() => new Vector4I20F12(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XXXY() => new Vector4I20F12(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XXXZ() => new Vector4I20F12(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XXXW() => new Vector4I20F12(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XXYX() => new Vector4I20F12(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XXYY() => new Vector4I20F12(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XXYZ() => new Vector4I20F12(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XXYW() => new Vector4I20F12(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XXZX() => new Vector4I20F12(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XXZY() => new Vector4I20F12(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XXZZ() => new Vector4I20F12(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XXZW() => new Vector4I20F12(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XXWX() => new Vector4I20F12(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XXWY() => new Vector4I20F12(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XXWZ() => new Vector4I20F12(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XXWW() => new Vector4I20F12(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XYXX() => new Vector4I20F12(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XYXY() => new Vector4I20F12(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XYXZ() => new Vector4I20F12(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XYXW() => new Vector4I20F12(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XYYX() => new Vector4I20F12(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XYYY() => new Vector4I20F12(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XYYZ() => new Vector4I20F12(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XYYW() => new Vector4I20F12(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XYZX() => new Vector4I20F12(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XYZY() => new Vector4I20F12(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XYZZ() => new Vector4I20F12(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XYZW() => new Vector4I20F12(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XYWX() => new Vector4I20F12(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XYWY() => new Vector4I20F12(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XYWZ() => new Vector4I20F12(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XYWW() => new Vector4I20F12(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XZXX() => new Vector4I20F12(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XZXY() => new Vector4I20F12(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XZXZ() => new Vector4I20F12(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XZXW() => new Vector4I20F12(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XZYX() => new Vector4I20F12(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XZYY() => new Vector4I20F12(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XZYZ() => new Vector4I20F12(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XZYW() => new Vector4I20F12(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XZZX() => new Vector4I20F12(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XZZY() => new Vector4I20F12(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XZZZ() => new Vector4I20F12(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XZZW() => new Vector4I20F12(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XZWX() => new Vector4I20F12(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XZWY() => new Vector4I20F12(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XZWZ() => new Vector4I20F12(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XZWW() => new Vector4I20F12(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XWXX() => new Vector4I20F12(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XWXY() => new Vector4I20F12(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XWXZ() => new Vector4I20F12(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XWXW() => new Vector4I20F12(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XWYX() => new Vector4I20F12(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XWYY() => new Vector4I20F12(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XWYZ() => new Vector4I20F12(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XWYW() => new Vector4I20F12(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XWZX() => new Vector4I20F12(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XWZY() => new Vector4I20F12(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XWZZ() => new Vector4I20F12(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XWZW() => new Vector4I20F12(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XWWX() => new Vector4I20F12(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XWWY() => new Vector4I20F12(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XWWZ() => new Vector4I20F12(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 XWWW() => new Vector4I20F12(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YXXX() => new Vector4I20F12(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YXXY() => new Vector4I20F12(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YXXZ() => new Vector4I20F12(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YXXW() => new Vector4I20F12(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YXYX() => new Vector4I20F12(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YXYY() => new Vector4I20F12(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YXYZ() => new Vector4I20F12(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YXYW() => new Vector4I20F12(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YXZX() => new Vector4I20F12(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YXZY() => new Vector4I20F12(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YXZZ() => new Vector4I20F12(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YXZW() => new Vector4I20F12(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YXWX() => new Vector4I20F12(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YXWY() => new Vector4I20F12(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YXWZ() => new Vector4I20F12(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YXWW() => new Vector4I20F12(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YYXX() => new Vector4I20F12(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YYXY() => new Vector4I20F12(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YYXZ() => new Vector4I20F12(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YYXW() => new Vector4I20F12(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YYYX() => new Vector4I20F12(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YYYY() => new Vector4I20F12(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YYYZ() => new Vector4I20F12(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YYYW() => new Vector4I20F12(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YYZX() => new Vector4I20F12(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YYZY() => new Vector4I20F12(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YYZZ() => new Vector4I20F12(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YYZW() => new Vector4I20F12(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YYWX() => new Vector4I20F12(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YYWY() => new Vector4I20F12(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YYWZ() => new Vector4I20F12(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YYWW() => new Vector4I20F12(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YZXX() => new Vector4I20F12(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YZXY() => new Vector4I20F12(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YZXZ() => new Vector4I20F12(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YZXW() => new Vector4I20F12(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YZYX() => new Vector4I20F12(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YZYY() => new Vector4I20F12(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YZYZ() => new Vector4I20F12(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YZYW() => new Vector4I20F12(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YZZX() => new Vector4I20F12(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YZZY() => new Vector4I20F12(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YZZZ() => new Vector4I20F12(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YZZW() => new Vector4I20F12(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YZWX() => new Vector4I20F12(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YZWY() => new Vector4I20F12(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YZWZ() => new Vector4I20F12(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YZWW() => new Vector4I20F12(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YWXX() => new Vector4I20F12(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YWXY() => new Vector4I20F12(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YWXZ() => new Vector4I20F12(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YWXW() => new Vector4I20F12(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YWYX() => new Vector4I20F12(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YWYY() => new Vector4I20F12(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YWYZ() => new Vector4I20F12(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YWYW() => new Vector4I20F12(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YWZX() => new Vector4I20F12(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YWZY() => new Vector4I20F12(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YWZZ() => new Vector4I20F12(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YWZW() => new Vector4I20F12(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YWWX() => new Vector4I20F12(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YWWY() => new Vector4I20F12(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YWWZ() => new Vector4I20F12(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 YWWW() => new Vector4I20F12(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZXXX() => new Vector4I20F12(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZXXY() => new Vector4I20F12(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZXXZ() => new Vector4I20F12(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZXXW() => new Vector4I20F12(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZXYX() => new Vector4I20F12(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZXYY() => new Vector4I20F12(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZXYZ() => new Vector4I20F12(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZXYW() => new Vector4I20F12(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZXZX() => new Vector4I20F12(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZXZY() => new Vector4I20F12(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZXZZ() => new Vector4I20F12(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZXZW() => new Vector4I20F12(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZXWX() => new Vector4I20F12(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZXWY() => new Vector4I20F12(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZXWZ() => new Vector4I20F12(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZXWW() => new Vector4I20F12(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZYXX() => new Vector4I20F12(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZYXY() => new Vector4I20F12(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZYXZ() => new Vector4I20F12(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZYXW() => new Vector4I20F12(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZYYX() => new Vector4I20F12(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZYYY() => new Vector4I20F12(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZYYZ() => new Vector4I20F12(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZYYW() => new Vector4I20F12(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZYZX() => new Vector4I20F12(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZYZY() => new Vector4I20F12(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZYZZ() => new Vector4I20F12(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZYZW() => new Vector4I20F12(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZYWX() => new Vector4I20F12(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZYWY() => new Vector4I20F12(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZYWZ() => new Vector4I20F12(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZYWW() => new Vector4I20F12(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZZXX() => new Vector4I20F12(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZZXY() => new Vector4I20F12(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZZXZ() => new Vector4I20F12(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZZXW() => new Vector4I20F12(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZZYX() => new Vector4I20F12(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZZYY() => new Vector4I20F12(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZZYZ() => new Vector4I20F12(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZZYW() => new Vector4I20F12(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZZZX() => new Vector4I20F12(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZZZY() => new Vector4I20F12(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZZZZ() => new Vector4I20F12(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZZZW() => new Vector4I20F12(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZZWX() => new Vector4I20F12(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZZWY() => new Vector4I20F12(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZZWZ() => new Vector4I20F12(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZZWW() => new Vector4I20F12(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZWXX() => new Vector4I20F12(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZWXY() => new Vector4I20F12(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZWXZ() => new Vector4I20F12(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZWXW() => new Vector4I20F12(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZWYX() => new Vector4I20F12(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZWYY() => new Vector4I20F12(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZWYZ() => new Vector4I20F12(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZWYW() => new Vector4I20F12(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZWZX() => new Vector4I20F12(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZWZY() => new Vector4I20F12(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZWZZ() => new Vector4I20F12(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZWZW() => new Vector4I20F12(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZWWX() => new Vector4I20F12(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZWWY() => new Vector4I20F12(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZWWZ() => new Vector4I20F12(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 ZWWW() => new Vector4I20F12(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WXXX() => new Vector4I20F12(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WXXY() => new Vector4I20F12(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WXXZ() => new Vector4I20F12(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WXXW() => new Vector4I20F12(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WXYX() => new Vector4I20F12(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WXYY() => new Vector4I20F12(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WXYZ() => new Vector4I20F12(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WXYW() => new Vector4I20F12(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WXZX() => new Vector4I20F12(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WXZY() => new Vector4I20F12(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WXZZ() => new Vector4I20F12(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WXZW() => new Vector4I20F12(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WXWX() => new Vector4I20F12(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WXWY() => new Vector4I20F12(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WXWZ() => new Vector4I20F12(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WXWW() => new Vector4I20F12(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WYXX() => new Vector4I20F12(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WYXY() => new Vector4I20F12(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WYXZ() => new Vector4I20F12(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WYXW() => new Vector4I20F12(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WYYX() => new Vector4I20F12(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WYYY() => new Vector4I20F12(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WYYZ() => new Vector4I20F12(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WYYW() => new Vector4I20F12(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WYZX() => new Vector4I20F12(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WYZY() => new Vector4I20F12(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WYZZ() => new Vector4I20F12(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WYZW() => new Vector4I20F12(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WYWX() => new Vector4I20F12(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WYWY() => new Vector4I20F12(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WYWZ() => new Vector4I20F12(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WYWW() => new Vector4I20F12(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WZXX() => new Vector4I20F12(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WZXY() => new Vector4I20F12(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WZXZ() => new Vector4I20F12(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WZXW() => new Vector4I20F12(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WZYX() => new Vector4I20F12(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WZYY() => new Vector4I20F12(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WZYZ() => new Vector4I20F12(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WZYW() => new Vector4I20F12(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WZZX() => new Vector4I20F12(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WZZY() => new Vector4I20F12(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WZZZ() => new Vector4I20F12(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WZZW() => new Vector4I20F12(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WZWX() => new Vector4I20F12(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WZWY() => new Vector4I20F12(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WZWZ() => new Vector4I20F12(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WZWW() => new Vector4I20F12(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WWXX() => new Vector4I20F12(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WWXY() => new Vector4I20F12(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WWXZ() => new Vector4I20F12(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WWXW() => new Vector4I20F12(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WWYX() => new Vector4I20F12(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WWYY() => new Vector4I20F12(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WWYZ() => new Vector4I20F12(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WWYW() => new Vector4I20F12(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WWZX() => new Vector4I20F12(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WWZY() => new Vector4I20F12(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WWZZ() => new Vector4I20F12(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WWZW() => new Vector4I20F12(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WWWX() => new Vector4I20F12(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WWWY() => new Vector4I20F12(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WWWZ() => new Vector4I20F12(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I20F12 WWWW() => new Vector4I20F12(W, W, W, W);

    }
}
