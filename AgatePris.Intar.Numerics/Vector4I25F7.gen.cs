using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I25F7
    : IEquatable<Vector4I25F7>
    , IFormattable
    , IVector<U52F12, I52F12, U26F6, I26F6>
    , IVectorComponentRespective<I25F7> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I25F7 X;
        public I25F7 Y;
        public I25F7 Z;
        public I25F7 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7(I25F7 x, I25F7 y, I25F7 z, I25F7 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7(I25F7 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7(I25F7 x, I25F7 y, Vector2I25F7 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7(I25F7 x, Vector3I25F7 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7(Vector2I25F7 xy, Vector2I25F7 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7(Vector4I25F7 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7(I25F7 x, Vector2I25F7 yz, I25F7 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7(Vector3I25F7 xyz, I25F7 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7(Vector2I25F7 xy, I25F7 z, I25F7 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I25F7 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I25F7(I25F7.Zero);
        }
        public static Vector4I25F7 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I25F7(I25F7.One);
        }
        public static Vector4I25F7 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I25F7(I25F7.One, I25F7.Zero, I25F7.Zero, I25F7.Zero);
        }
        public static Vector4I25F7 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I25F7(I25F7.Zero, I25F7.One, I25F7.Zero, I25F7.Zero);
        }
        public static Vector4I25F7 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I25F7(I25F7.Zero, I25F7.Zero, I25F7.One, I25F7.Zero);
        }
        public static Vector4I25F7 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I25F7(I25F7.Zero, I25F7.Zero, I25F7.Zero, I25F7.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 operator +(Vector4I25F7 a, Vector4I25F7 b) => new Vector4I25F7(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 operator -(Vector4I25F7 a, Vector4I25F7 b) => new Vector4I25F7(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 operator *(Vector4I25F7 a, Vector4I25F7 b) => new Vector4I25F7(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 operator *(Vector4I25F7 a, I25F7 b) => new Vector4I25F7(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 operator *(I25F7 a, Vector4I25F7 b) => new Vector4I25F7(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 operator /(Vector4I25F7 a, Vector4I25F7 b) => new Vector4I25F7(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 operator /(Vector4I25F7 a, I25F7 b) => new Vector4I25F7(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I25F7 operator /(I25F7 a, Vector4I25F7 b) => new Vector4I25F7(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I25F7 lhs, Vector4I25F7 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I25F7 lhs, Vector4I25F7 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I25F7 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4I25F7 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I25F7>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I25F7 other)
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
        public Vector4I25F7 Min(Vector4I25F7 other) => new Vector4I25F7(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7 Max(Vector4I25F7 other) => new Vector4I25F7(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7 Abs() => new Vector4I25F7(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7 Half() => new Vector4I25F7(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7 Twice() => new Vector4I25F7(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7 Clamp(I25F7 min, I25F7 max) => new Vector4I25F7(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7 Clamp(
            Vector4I25F7 min, Vector4I25F7 max
        ) => new Vector4I25F7(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7 WrappingAdd(Vector4I25F7 other) => new Vector4I25F7(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7 WrappingSub(Vector4I25F7 other) => new Vector4I25F7(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7 WrappingMul(Vector4I25F7 other) => new Vector4I25F7(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7 WrappingAddUnsigned(Vector4U25F7 other) => new Vector4I25F7(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7 WrappingSubUnsigned(Vector4U25F7 other) => new Vector4I25F7(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U25F7 UnsignedAbs() => new Vector4U25F7(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7 SaturatingAdd(Vector4I25F7 other) => new Vector4I25F7(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7 SaturatingMul(I25F7 other) => new Vector4I25F7(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I25F7 other) {
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
        public I25F7 Dot(Vector4I25F7 other) {
            const long k = 1L << 5;
            return I25F7.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I25F7 SaturatingDot(Vector4I25F7 other) {
            const long k = 1L << 5;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I25F7.MaxValue;
            } else if (bits < int.MinValue) {
                return I25F7.MinValue;
            } else {
                return I25F7.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U52F12 LengthSquaredUnsigned() => U52F12.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I52F12 LengthSquaredSigned() => I52F12.FromBits(
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
        public I52F12 LengthSquared() => LengthSquaredSigned();

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
        public U25F7 LengthHalfUnsigned() => U25F7.FromBits(LengthInternal());

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
        public I25F7 LengthHalf() => I25F7.FromBits(checked((int)LengthInternal()));

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
        public U26F6 LengthUnsigned() => U26F6.FromBits(LengthInternal());

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
        public I26F6 LengthSigned() => I26F6.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I26F6 Length() => LengthSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I25F7? Normalize() {
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

            const ulong k = 1UL << 6;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);
            var y3 = (int)(l3 * k / ll);

            return new Vector4I25F7(
                I25F7.FromBits(b0 ? -y0 : y0),
                I25F7.FromBits(b1 ? -y1 : y1),
                I25F7.FromBits(b2 ? -y2 : y2),
                I25F7.FromBits(b3 ? -y3 : y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I25F7 XX() => new Vector2I25F7(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I25F7 XY() => new Vector2I25F7(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I25F7 XZ() => new Vector2I25F7(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I25F7 XW() => new Vector2I25F7(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I25F7 YX() => new Vector2I25F7(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I25F7 YY() => new Vector2I25F7(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I25F7 YZ() => new Vector2I25F7(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I25F7 YW() => new Vector2I25F7(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I25F7 ZX() => new Vector2I25F7(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I25F7 ZY() => new Vector2I25F7(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I25F7 ZZ() => new Vector2I25F7(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I25F7 ZW() => new Vector2I25F7(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I25F7 WX() => new Vector2I25F7(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I25F7 WY() => new Vector2I25F7(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I25F7 WZ() => new Vector2I25F7(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I25F7 WW() => new Vector2I25F7(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 XXX() => new Vector3I25F7(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 XXY() => new Vector3I25F7(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 XXZ() => new Vector3I25F7(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 XXW() => new Vector3I25F7(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 XYX() => new Vector3I25F7(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 XYY() => new Vector3I25F7(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 XYZ() => new Vector3I25F7(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 XYW() => new Vector3I25F7(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 XZX() => new Vector3I25F7(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 XZY() => new Vector3I25F7(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 XZZ() => new Vector3I25F7(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 XZW() => new Vector3I25F7(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 XWX() => new Vector3I25F7(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 XWY() => new Vector3I25F7(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 XWZ() => new Vector3I25F7(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 XWW() => new Vector3I25F7(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 YXX() => new Vector3I25F7(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 YXY() => new Vector3I25F7(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 YXZ() => new Vector3I25F7(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 YXW() => new Vector3I25F7(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 YYX() => new Vector3I25F7(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 YYY() => new Vector3I25F7(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 YYZ() => new Vector3I25F7(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 YYW() => new Vector3I25F7(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 YZX() => new Vector3I25F7(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 YZY() => new Vector3I25F7(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 YZZ() => new Vector3I25F7(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 YZW() => new Vector3I25F7(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 YWX() => new Vector3I25F7(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 YWY() => new Vector3I25F7(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 YWZ() => new Vector3I25F7(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 YWW() => new Vector3I25F7(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 ZXX() => new Vector3I25F7(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 ZXY() => new Vector3I25F7(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 ZXZ() => new Vector3I25F7(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 ZXW() => new Vector3I25F7(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 ZYX() => new Vector3I25F7(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 ZYY() => new Vector3I25F7(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 ZYZ() => new Vector3I25F7(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 ZYW() => new Vector3I25F7(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 ZZX() => new Vector3I25F7(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 ZZY() => new Vector3I25F7(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 ZZZ() => new Vector3I25F7(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 ZZW() => new Vector3I25F7(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 ZWX() => new Vector3I25F7(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 ZWY() => new Vector3I25F7(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 ZWZ() => new Vector3I25F7(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 ZWW() => new Vector3I25F7(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 WXX() => new Vector3I25F7(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 WXY() => new Vector3I25F7(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 WXZ() => new Vector3I25F7(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 WXW() => new Vector3I25F7(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 WYX() => new Vector3I25F7(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 WYY() => new Vector3I25F7(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 WYZ() => new Vector3I25F7(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 WYW() => new Vector3I25F7(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 WZX() => new Vector3I25F7(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 WZY() => new Vector3I25F7(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 WZZ() => new Vector3I25F7(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 WZW() => new Vector3I25F7(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 WWX() => new Vector3I25F7(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 WWY() => new Vector3I25F7(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 WWZ() => new Vector3I25F7(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I25F7 WWW() => new Vector3I25F7(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XXXX() => new Vector4I25F7(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XXXY() => new Vector4I25F7(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XXXZ() => new Vector4I25F7(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XXXW() => new Vector4I25F7(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XXYX() => new Vector4I25F7(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XXYY() => new Vector4I25F7(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XXYZ() => new Vector4I25F7(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XXYW() => new Vector4I25F7(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XXZX() => new Vector4I25F7(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XXZY() => new Vector4I25F7(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XXZZ() => new Vector4I25F7(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XXZW() => new Vector4I25F7(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XXWX() => new Vector4I25F7(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XXWY() => new Vector4I25F7(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XXWZ() => new Vector4I25F7(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XXWW() => new Vector4I25F7(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XYXX() => new Vector4I25F7(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XYXY() => new Vector4I25F7(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XYXZ() => new Vector4I25F7(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XYXW() => new Vector4I25F7(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XYYX() => new Vector4I25F7(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XYYY() => new Vector4I25F7(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XYYZ() => new Vector4I25F7(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XYYW() => new Vector4I25F7(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XYZX() => new Vector4I25F7(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XYZY() => new Vector4I25F7(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XYZZ() => new Vector4I25F7(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XYZW() => new Vector4I25F7(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XYWX() => new Vector4I25F7(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XYWY() => new Vector4I25F7(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XYWZ() => new Vector4I25F7(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XYWW() => new Vector4I25F7(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XZXX() => new Vector4I25F7(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XZXY() => new Vector4I25F7(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XZXZ() => new Vector4I25F7(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XZXW() => new Vector4I25F7(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XZYX() => new Vector4I25F7(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XZYY() => new Vector4I25F7(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XZYZ() => new Vector4I25F7(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XZYW() => new Vector4I25F7(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XZZX() => new Vector4I25F7(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XZZY() => new Vector4I25F7(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XZZZ() => new Vector4I25F7(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XZZW() => new Vector4I25F7(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XZWX() => new Vector4I25F7(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XZWY() => new Vector4I25F7(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XZWZ() => new Vector4I25F7(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XZWW() => new Vector4I25F7(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XWXX() => new Vector4I25F7(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XWXY() => new Vector4I25F7(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XWXZ() => new Vector4I25F7(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XWXW() => new Vector4I25F7(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XWYX() => new Vector4I25F7(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XWYY() => new Vector4I25F7(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XWYZ() => new Vector4I25F7(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XWYW() => new Vector4I25F7(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XWZX() => new Vector4I25F7(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XWZY() => new Vector4I25F7(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XWZZ() => new Vector4I25F7(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XWZW() => new Vector4I25F7(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XWWX() => new Vector4I25F7(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XWWY() => new Vector4I25F7(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XWWZ() => new Vector4I25F7(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 XWWW() => new Vector4I25F7(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YXXX() => new Vector4I25F7(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YXXY() => new Vector4I25F7(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YXXZ() => new Vector4I25F7(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YXXW() => new Vector4I25F7(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YXYX() => new Vector4I25F7(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YXYY() => new Vector4I25F7(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YXYZ() => new Vector4I25F7(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YXYW() => new Vector4I25F7(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YXZX() => new Vector4I25F7(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YXZY() => new Vector4I25F7(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YXZZ() => new Vector4I25F7(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YXZW() => new Vector4I25F7(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YXWX() => new Vector4I25F7(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YXWY() => new Vector4I25F7(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YXWZ() => new Vector4I25F7(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YXWW() => new Vector4I25F7(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YYXX() => new Vector4I25F7(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YYXY() => new Vector4I25F7(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YYXZ() => new Vector4I25F7(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YYXW() => new Vector4I25F7(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YYYX() => new Vector4I25F7(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YYYY() => new Vector4I25F7(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YYYZ() => new Vector4I25F7(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YYYW() => new Vector4I25F7(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YYZX() => new Vector4I25F7(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YYZY() => new Vector4I25F7(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YYZZ() => new Vector4I25F7(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YYZW() => new Vector4I25F7(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YYWX() => new Vector4I25F7(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YYWY() => new Vector4I25F7(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YYWZ() => new Vector4I25F7(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YYWW() => new Vector4I25F7(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YZXX() => new Vector4I25F7(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YZXY() => new Vector4I25F7(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YZXZ() => new Vector4I25F7(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YZXW() => new Vector4I25F7(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YZYX() => new Vector4I25F7(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YZYY() => new Vector4I25F7(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YZYZ() => new Vector4I25F7(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YZYW() => new Vector4I25F7(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YZZX() => new Vector4I25F7(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YZZY() => new Vector4I25F7(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YZZZ() => new Vector4I25F7(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YZZW() => new Vector4I25F7(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YZWX() => new Vector4I25F7(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YZWY() => new Vector4I25F7(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YZWZ() => new Vector4I25F7(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YZWW() => new Vector4I25F7(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YWXX() => new Vector4I25F7(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YWXY() => new Vector4I25F7(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YWXZ() => new Vector4I25F7(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YWXW() => new Vector4I25F7(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YWYX() => new Vector4I25F7(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YWYY() => new Vector4I25F7(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YWYZ() => new Vector4I25F7(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YWYW() => new Vector4I25F7(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YWZX() => new Vector4I25F7(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YWZY() => new Vector4I25F7(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YWZZ() => new Vector4I25F7(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YWZW() => new Vector4I25F7(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YWWX() => new Vector4I25F7(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YWWY() => new Vector4I25F7(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YWWZ() => new Vector4I25F7(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 YWWW() => new Vector4I25F7(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZXXX() => new Vector4I25F7(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZXXY() => new Vector4I25F7(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZXXZ() => new Vector4I25F7(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZXXW() => new Vector4I25F7(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZXYX() => new Vector4I25F7(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZXYY() => new Vector4I25F7(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZXYZ() => new Vector4I25F7(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZXYW() => new Vector4I25F7(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZXZX() => new Vector4I25F7(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZXZY() => new Vector4I25F7(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZXZZ() => new Vector4I25F7(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZXZW() => new Vector4I25F7(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZXWX() => new Vector4I25F7(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZXWY() => new Vector4I25F7(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZXWZ() => new Vector4I25F7(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZXWW() => new Vector4I25F7(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZYXX() => new Vector4I25F7(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZYXY() => new Vector4I25F7(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZYXZ() => new Vector4I25F7(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZYXW() => new Vector4I25F7(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZYYX() => new Vector4I25F7(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZYYY() => new Vector4I25F7(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZYYZ() => new Vector4I25F7(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZYYW() => new Vector4I25F7(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZYZX() => new Vector4I25F7(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZYZY() => new Vector4I25F7(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZYZZ() => new Vector4I25F7(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZYZW() => new Vector4I25F7(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZYWX() => new Vector4I25F7(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZYWY() => new Vector4I25F7(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZYWZ() => new Vector4I25F7(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZYWW() => new Vector4I25F7(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZZXX() => new Vector4I25F7(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZZXY() => new Vector4I25F7(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZZXZ() => new Vector4I25F7(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZZXW() => new Vector4I25F7(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZZYX() => new Vector4I25F7(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZZYY() => new Vector4I25F7(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZZYZ() => new Vector4I25F7(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZZYW() => new Vector4I25F7(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZZZX() => new Vector4I25F7(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZZZY() => new Vector4I25F7(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZZZZ() => new Vector4I25F7(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZZZW() => new Vector4I25F7(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZZWX() => new Vector4I25F7(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZZWY() => new Vector4I25F7(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZZWZ() => new Vector4I25F7(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZZWW() => new Vector4I25F7(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZWXX() => new Vector4I25F7(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZWXY() => new Vector4I25F7(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZWXZ() => new Vector4I25F7(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZWXW() => new Vector4I25F7(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZWYX() => new Vector4I25F7(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZWYY() => new Vector4I25F7(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZWYZ() => new Vector4I25F7(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZWYW() => new Vector4I25F7(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZWZX() => new Vector4I25F7(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZWZY() => new Vector4I25F7(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZWZZ() => new Vector4I25F7(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZWZW() => new Vector4I25F7(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZWWX() => new Vector4I25F7(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZWWY() => new Vector4I25F7(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZWWZ() => new Vector4I25F7(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 ZWWW() => new Vector4I25F7(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WXXX() => new Vector4I25F7(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WXXY() => new Vector4I25F7(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WXXZ() => new Vector4I25F7(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WXXW() => new Vector4I25F7(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WXYX() => new Vector4I25F7(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WXYY() => new Vector4I25F7(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WXYZ() => new Vector4I25F7(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WXYW() => new Vector4I25F7(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WXZX() => new Vector4I25F7(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WXZY() => new Vector4I25F7(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WXZZ() => new Vector4I25F7(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WXZW() => new Vector4I25F7(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WXWX() => new Vector4I25F7(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WXWY() => new Vector4I25F7(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WXWZ() => new Vector4I25F7(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WXWW() => new Vector4I25F7(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WYXX() => new Vector4I25F7(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WYXY() => new Vector4I25F7(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WYXZ() => new Vector4I25F7(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WYXW() => new Vector4I25F7(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WYYX() => new Vector4I25F7(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WYYY() => new Vector4I25F7(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WYYZ() => new Vector4I25F7(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WYYW() => new Vector4I25F7(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WYZX() => new Vector4I25F7(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WYZY() => new Vector4I25F7(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WYZZ() => new Vector4I25F7(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WYZW() => new Vector4I25F7(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WYWX() => new Vector4I25F7(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WYWY() => new Vector4I25F7(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WYWZ() => new Vector4I25F7(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WYWW() => new Vector4I25F7(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WZXX() => new Vector4I25F7(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WZXY() => new Vector4I25F7(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WZXZ() => new Vector4I25F7(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WZXW() => new Vector4I25F7(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WZYX() => new Vector4I25F7(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WZYY() => new Vector4I25F7(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WZYZ() => new Vector4I25F7(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WZYW() => new Vector4I25F7(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WZZX() => new Vector4I25F7(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WZZY() => new Vector4I25F7(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WZZZ() => new Vector4I25F7(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WZZW() => new Vector4I25F7(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WZWX() => new Vector4I25F7(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WZWY() => new Vector4I25F7(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WZWZ() => new Vector4I25F7(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WZWW() => new Vector4I25F7(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WWXX() => new Vector4I25F7(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WWXY() => new Vector4I25F7(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WWXZ() => new Vector4I25F7(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WWXW() => new Vector4I25F7(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WWYX() => new Vector4I25F7(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WWYY() => new Vector4I25F7(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WWYZ() => new Vector4I25F7(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WWYW() => new Vector4I25F7(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WWZX() => new Vector4I25F7(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WWZY() => new Vector4I25F7(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WWZZ() => new Vector4I25F7(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WWZW() => new Vector4I25F7(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WWWX() => new Vector4I25F7(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WWWY() => new Vector4I25F7(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WWWZ() => new Vector4I25F7(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I25F7 WWWW() => new Vector4I25F7(W, W, W, W);

    }
}
