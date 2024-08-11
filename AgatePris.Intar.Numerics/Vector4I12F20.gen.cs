using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I12F20
    : IEquatable<Vector4I12F20>
    , IFormattable
    , IVector<U26F38, I26F38, U13F19, I13F19>
    , IVectorComponentRespective<I12F20> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I12F20 X;
        public I12F20 Y;
        public I12F20 Z;
        public I12F20 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(I12F20 x, I12F20 y, I12F20 z, I12F20 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(I12F20 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(I12F20 x, I12F20 y, Vector2I12F20 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(I12F20 x, Vector3I12F20 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(Vector2I12F20 xy, Vector2I12F20 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(Vector4I12F20 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(I12F20 x, Vector2I12F20 yz, I12F20 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(Vector3I12F20 xyz, I12F20 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20(Vector2I12F20 xy, I12F20 z, I12F20 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I12F20 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I12F20(I12F20.Zero);
        }
        public static Vector4I12F20 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I12F20(I12F20.One);
        }
        public static Vector4I12F20 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I12F20(I12F20.One, I12F20.Zero, I12F20.Zero, I12F20.Zero);
        }
        public static Vector4I12F20 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I12F20(I12F20.Zero, I12F20.One, I12F20.Zero, I12F20.Zero);
        }
        public static Vector4I12F20 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I12F20(I12F20.Zero, I12F20.Zero, I12F20.One, I12F20.Zero);
        }
        public static Vector4I12F20 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I12F20(I12F20.Zero, I12F20.Zero, I12F20.Zero, I12F20.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 operator +(Vector4I12F20 a, Vector4I12F20 b) => new Vector4I12F20(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 operator -(Vector4I12F20 a, Vector4I12F20 b) => new Vector4I12F20(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 operator *(Vector4I12F20 a, Vector4I12F20 b) => new Vector4I12F20(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 operator *(Vector4I12F20 a, I12F20 b) => new Vector4I12F20(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 operator *(I12F20 a, Vector4I12F20 b) => new Vector4I12F20(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 operator /(Vector4I12F20 a, Vector4I12F20 b) => new Vector4I12F20(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 operator /(Vector4I12F20 a, I12F20 b) => new Vector4I12F20(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I12F20 operator /(I12F20 a, Vector4I12F20 b) => new Vector4I12F20(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I12F20 lhs, Vector4I12F20 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I12F20 lhs, Vector4I12F20 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I12F20 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4I12F20 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I12F20>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I12F20 other)
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
        public Vector4I12F20 Min(Vector4I12F20 other) => new Vector4I12F20(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20 Max(Vector4I12F20 other) => new Vector4I12F20(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20 Abs() => new Vector4I12F20(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20 Half() => new Vector4I12F20(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20 Twice() => new Vector4I12F20(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20 Clamp(I12F20 min, I12F20 max) => new Vector4I12F20(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20 Clamp(
            Vector4I12F20 min, Vector4I12F20 max
        ) => new Vector4I12F20(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20 WrappingAdd(Vector4I12F20 other) => new Vector4I12F20(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20 WrappingSub(Vector4I12F20 other) => new Vector4I12F20(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20 WrappingMul(Vector4I12F20 other) => new Vector4I12F20(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20 WrappingAddUnsigned(Vector4U12F20 other) => new Vector4I12F20(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20 WrappingSubUnsigned(Vector4U12F20 other) => new Vector4I12F20(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U12F20 UnsignedAbs() => new Vector4U12F20(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20 SaturatingAdd(Vector4I12F20 other) => new Vector4I12F20(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20 SaturatingMul(I12F20 other) => new Vector4I12F20(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I12F20 other) {
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
        public I12F20 Dot(Vector4I12F20 other) {
            const long k = 1L << 18;
            return I12F20.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I12F20 SaturatingDot(Vector4I12F20 other) {
            const long k = 1L << 18;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I12F20.MaxValue;
            } else if (bits < int.MinValue) {
                return I12F20.MinValue;
            } else {
                return I12F20.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U26F38 LengthSquaredUnsigned() => U26F38.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I26F38 LengthSquaredSigned() => I26F38.FromBits(
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
        public I26F38 LengthSquared() => LengthSquaredSigned();

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
        public U12F20 LengthHalfUnsigned() => U12F20.FromBits(LengthInternal());

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
        public I12F20 LengthHalf() => I12F20.FromBits(checked((int)LengthInternal()));

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
        public U13F19 LengthUnsigned() => U13F19.FromBits(LengthInternal());

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
        public I13F19 LengthSigned() => I13F19.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I13F19 Length() => LengthSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I12F20? Normalize() {
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

            const ulong k = 1UL << 19;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);
            var y3 = (int)(l3 * k / ll);

            return new Vector4I12F20(
                I12F20.FromBits(b0 ? -y0 : y0),
                I12F20.FromBits(b1 ? -y1 : y1),
                I12F20.FromBits(b2 ? -y2 : y2),
                I12F20.FromBits(b3 ? -y3 : y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 XX() => new Vector2I12F20(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 XY() => new Vector2I12F20(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 XZ() => new Vector2I12F20(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 XW() => new Vector2I12F20(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 YX() => new Vector2I12F20(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 YY() => new Vector2I12F20(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 YZ() => new Vector2I12F20(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 YW() => new Vector2I12F20(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 ZX() => new Vector2I12F20(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 ZY() => new Vector2I12F20(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 ZZ() => new Vector2I12F20(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 ZW() => new Vector2I12F20(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 WX() => new Vector2I12F20(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 WY() => new Vector2I12F20(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 WZ() => new Vector2I12F20(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I12F20 WW() => new Vector2I12F20(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XXX() => new Vector3I12F20(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XXY() => new Vector3I12F20(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XXZ() => new Vector3I12F20(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XXW() => new Vector3I12F20(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XYX() => new Vector3I12F20(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XYY() => new Vector3I12F20(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XYZ() => new Vector3I12F20(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XYW() => new Vector3I12F20(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XZX() => new Vector3I12F20(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XZY() => new Vector3I12F20(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XZZ() => new Vector3I12F20(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XZW() => new Vector3I12F20(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XWX() => new Vector3I12F20(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XWY() => new Vector3I12F20(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XWZ() => new Vector3I12F20(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 XWW() => new Vector3I12F20(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YXX() => new Vector3I12F20(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YXY() => new Vector3I12F20(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YXZ() => new Vector3I12F20(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YXW() => new Vector3I12F20(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YYX() => new Vector3I12F20(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YYY() => new Vector3I12F20(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YYZ() => new Vector3I12F20(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YYW() => new Vector3I12F20(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YZX() => new Vector3I12F20(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YZY() => new Vector3I12F20(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YZZ() => new Vector3I12F20(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YZW() => new Vector3I12F20(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YWX() => new Vector3I12F20(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YWY() => new Vector3I12F20(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YWZ() => new Vector3I12F20(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 YWW() => new Vector3I12F20(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZXX() => new Vector3I12F20(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZXY() => new Vector3I12F20(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZXZ() => new Vector3I12F20(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZXW() => new Vector3I12F20(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZYX() => new Vector3I12F20(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZYY() => new Vector3I12F20(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZYZ() => new Vector3I12F20(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZYW() => new Vector3I12F20(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZZX() => new Vector3I12F20(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZZY() => new Vector3I12F20(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZZZ() => new Vector3I12F20(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZZW() => new Vector3I12F20(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZWX() => new Vector3I12F20(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZWY() => new Vector3I12F20(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZWZ() => new Vector3I12F20(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 ZWW() => new Vector3I12F20(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 WXX() => new Vector3I12F20(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 WXY() => new Vector3I12F20(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 WXZ() => new Vector3I12F20(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 WXW() => new Vector3I12F20(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 WYX() => new Vector3I12F20(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 WYY() => new Vector3I12F20(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 WYZ() => new Vector3I12F20(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 WYW() => new Vector3I12F20(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 WZX() => new Vector3I12F20(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 WZY() => new Vector3I12F20(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 WZZ() => new Vector3I12F20(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 WZW() => new Vector3I12F20(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 WWX() => new Vector3I12F20(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 WWY() => new Vector3I12F20(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 WWZ() => new Vector3I12F20(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I12F20 WWW() => new Vector3I12F20(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXXX() => new Vector4I12F20(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXXY() => new Vector4I12F20(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXXZ() => new Vector4I12F20(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXXW() => new Vector4I12F20(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXYX() => new Vector4I12F20(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXYY() => new Vector4I12F20(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXYZ() => new Vector4I12F20(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXYW() => new Vector4I12F20(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXZX() => new Vector4I12F20(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXZY() => new Vector4I12F20(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXZZ() => new Vector4I12F20(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXZW() => new Vector4I12F20(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXWX() => new Vector4I12F20(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXWY() => new Vector4I12F20(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXWZ() => new Vector4I12F20(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XXWW() => new Vector4I12F20(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYXX() => new Vector4I12F20(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYXY() => new Vector4I12F20(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYXZ() => new Vector4I12F20(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYXW() => new Vector4I12F20(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYYX() => new Vector4I12F20(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYYY() => new Vector4I12F20(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYYZ() => new Vector4I12F20(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYYW() => new Vector4I12F20(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYZX() => new Vector4I12F20(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYZY() => new Vector4I12F20(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYZZ() => new Vector4I12F20(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYZW() => new Vector4I12F20(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYWX() => new Vector4I12F20(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYWY() => new Vector4I12F20(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYWZ() => new Vector4I12F20(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XYWW() => new Vector4I12F20(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZXX() => new Vector4I12F20(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZXY() => new Vector4I12F20(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZXZ() => new Vector4I12F20(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZXW() => new Vector4I12F20(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZYX() => new Vector4I12F20(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZYY() => new Vector4I12F20(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZYZ() => new Vector4I12F20(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZYW() => new Vector4I12F20(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZZX() => new Vector4I12F20(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZZY() => new Vector4I12F20(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZZZ() => new Vector4I12F20(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZZW() => new Vector4I12F20(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZWX() => new Vector4I12F20(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZWY() => new Vector4I12F20(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZWZ() => new Vector4I12F20(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XZWW() => new Vector4I12F20(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XWXX() => new Vector4I12F20(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XWXY() => new Vector4I12F20(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XWXZ() => new Vector4I12F20(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XWXW() => new Vector4I12F20(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XWYX() => new Vector4I12F20(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XWYY() => new Vector4I12F20(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XWYZ() => new Vector4I12F20(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XWYW() => new Vector4I12F20(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XWZX() => new Vector4I12F20(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XWZY() => new Vector4I12F20(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XWZZ() => new Vector4I12F20(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XWZW() => new Vector4I12F20(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XWWX() => new Vector4I12F20(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XWWY() => new Vector4I12F20(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XWWZ() => new Vector4I12F20(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 XWWW() => new Vector4I12F20(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXXX() => new Vector4I12F20(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXXY() => new Vector4I12F20(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXXZ() => new Vector4I12F20(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXXW() => new Vector4I12F20(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXYX() => new Vector4I12F20(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXYY() => new Vector4I12F20(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXYZ() => new Vector4I12F20(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXYW() => new Vector4I12F20(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXZX() => new Vector4I12F20(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXZY() => new Vector4I12F20(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXZZ() => new Vector4I12F20(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXZW() => new Vector4I12F20(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXWX() => new Vector4I12F20(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXWY() => new Vector4I12F20(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXWZ() => new Vector4I12F20(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YXWW() => new Vector4I12F20(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYXX() => new Vector4I12F20(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYXY() => new Vector4I12F20(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYXZ() => new Vector4I12F20(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYXW() => new Vector4I12F20(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYYX() => new Vector4I12F20(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYYY() => new Vector4I12F20(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYYZ() => new Vector4I12F20(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYYW() => new Vector4I12F20(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYZX() => new Vector4I12F20(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYZY() => new Vector4I12F20(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYZZ() => new Vector4I12F20(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYZW() => new Vector4I12F20(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYWX() => new Vector4I12F20(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYWY() => new Vector4I12F20(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYWZ() => new Vector4I12F20(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YYWW() => new Vector4I12F20(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZXX() => new Vector4I12F20(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZXY() => new Vector4I12F20(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZXZ() => new Vector4I12F20(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZXW() => new Vector4I12F20(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZYX() => new Vector4I12F20(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZYY() => new Vector4I12F20(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZYZ() => new Vector4I12F20(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZYW() => new Vector4I12F20(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZZX() => new Vector4I12F20(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZZY() => new Vector4I12F20(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZZZ() => new Vector4I12F20(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZZW() => new Vector4I12F20(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZWX() => new Vector4I12F20(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZWY() => new Vector4I12F20(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZWZ() => new Vector4I12F20(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YZWW() => new Vector4I12F20(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YWXX() => new Vector4I12F20(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YWXY() => new Vector4I12F20(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YWXZ() => new Vector4I12F20(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YWXW() => new Vector4I12F20(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YWYX() => new Vector4I12F20(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YWYY() => new Vector4I12F20(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YWYZ() => new Vector4I12F20(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YWYW() => new Vector4I12F20(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YWZX() => new Vector4I12F20(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YWZY() => new Vector4I12F20(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YWZZ() => new Vector4I12F20(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YWZW() => new Vector4I12F20(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YWWX() => new Vector4I12F20(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YWWY() => new Vector4I12F20(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YWWZ() => new Vector4I12F20(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 YWWW() => new Vector4I12F20(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXXX() => new Vector4I12F20(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXXY() => new Vector4I12F20(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXXZ() => new Vector4I12F20(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXXW() => new Vector4I12F20(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXYX() => new Vector4I12F20(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXYY() => new Vector4I12F20(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXYZ() => new Vector4I12F20(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXYW() => new Vector4I12F20(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXZX() => new Vector4I12F20(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXZY() => new Vector4I12F20(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXZZ() => new Vector4I12F20(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXZW() => new Vector4I12F20(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXWX() => new Vector4I12F20(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXWY() => new Vector4I12F20(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXWZ() => new Vector4I12F20(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZXWW() => new Vector4I12F20(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYXX() => new Vector4I12F20(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYXY() => new Vector4I12F20(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYXZ() => new Vector4I12F20(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYXW() => new Vector4I12F20(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYYX() => new Vector4I12F20(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYYY() => new Vector4I12F20(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYYZ() => new Vector4I12F20(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYYW() => new Vector4I12F20(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYZX() => new Vector4I12F20(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYZY() => new Vector4I12F20(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYZZ() => new Vector4I12F20(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYZW() => new Vector4I12F20(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYWX() => new Vector4I12F20(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYWY() => new Vector4I12F20(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYWZ() => new Vector4I12F20(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZYWW() => new Vector4I12F20(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZXX() => new Vector4I12F20(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZXY() => new Vector4I12F20(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZXZ() => new Vector4I12F20(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZXW() => new Vector4I12F20(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZYX() => new Vector4I12F20(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZYY() => new Vector4I12F20(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZYZ() => new Vector4I12F20(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZYW() => new Vector4I12F20(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZZX() => new Vector4I12F20(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZZY() => new Vector4I12F20(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZZZ() => new Vector4I12F20(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZZW() => new Vector4I12F20(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZWX() => new Vector4I12F20(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZWY() => new Vector4I12F20(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZWZ() => new Vector4I12F20(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZZWW() => new Vector4I12F20(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZWXX() => new Vector4I12F20(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZWXY() => new Vector4I12F20(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZWXZ() => new Vector4I12F20(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZWXW() => new Vector4I12F20(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZWYX() => new Vector4I12F20(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZWYY() => new Vector4I12F20(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZWYZ() => new Vector4I12F20(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZWYW() => new Vector4I12F20(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZWZX() => new Vector4I12F20(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZWZY() => new Vector4I12F20(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZWZZ() => new Vector4I12F20(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZWZW() => new Vector4I12F20(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZWWX() => new Vector4I12F20(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZWWY() => new Vector4I12F20(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZWWZ() => new Vector4I12F20(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 ZWWW() => new Vector4I12F20(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WXXX() => new Vector4I12F20(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WXXY() => new Vector4I12F20(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WXXZ() => new Vector4I12F20(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WXXW() => new Vector4I12F20(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WXYX() => new Vector4I12F20(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WXYY() => new Vector4I12F20(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WXYZ() => new Vector4I12F20(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WXYW() => new Vector4I12F20(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WXZX() => new Vector4I12F20(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WXZY() => new Vector4I12F20(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WXZZ() => new Vector4I12F20(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WXZW() => new Vector4I12F20(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WXWX() => new Vector4I12F20(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WXWY() => new Vector4I12F20(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WXWZ() => new Vector4I12F20(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WXWW() => new Vector4I12F20(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WYXX() => new Vector4I12F20(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WYXY() => new Vector4I12F20(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WYXZ() => new Vector4I12F20(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WYXW() => new Vector4I12F20(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WYYX() => new Vector4I12F20(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WYYY() => new Vector4I12F20(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WYYZ() => new Vector4I12F20(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WYYW() => new Vector4I12F20(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WYZX() => new Vector4I12F20(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WYZY() => new Vector4I12F20(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WYZZ() => new Vector4I12F20(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WYZW() => new Vector4I12F20(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WYWX() => new Vector4I12F20(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WYWY() => new Vector4I12F20(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WYWZ() => new Vector4I12F20(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WYWW() => new Vector4I12F20(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WZXX() => new Vector4I12F20(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WZXY() => new Vector4I12F20(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WZXZ() => new Vector4I12F20(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WZXW() => new Vector4I12F20(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WZYX() => new Vector4I12F20(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WZYY() => new Vector4I12F20(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WZYZ() => new Vector4I12F20(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WZYW() => new Vector4I12F20(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WZZX() => new Vector4I12F20(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WZZY() => new Vector4I12F20(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WZZZ() => new Vector4I12F20(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WZZW() => new Vector4I12F20(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WZWX() => new Vector4I12F20(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WZWY() => new Vector4I12F20(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WZWZ() => new Vector4I12F20(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WZWW() => new Vector4I12F20(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WWXX() => new Vector4I12F20(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WWXY() => new Vector4I12F20(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WWXZ() => new Vector4I12F20(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WWXW() => new Vector4I12F20(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WWYX() => new Vector4I12F20(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WWYY() => new Vector4I12F20(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WWYZ() => new Vector4I12F20(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WWYW() => new Vector4I12F20(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WWZX() => new Vector4I12F20(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WWZY() => new Vector4I12F20(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WWZZ() => new Vector4I12F20(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WWZW() => new Vector4I12F20(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WWWX() => new Vector4I12F20(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WWWY() => new Vector4I12F20(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WWWZ() => new Vector4I12F20(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I12F20 WWWW() => new Vector4I12F20(W, W, W, W);

    }
}
