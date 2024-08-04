using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I9F23
    : IEquatable<Vector4I9F23>
    , IFormattable
    , IVector<U20F44, I20F44, U10F22, I10F22>
    , IVectorComponentRespective<I9F23> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I9F23 X;
        public I9F23 Y;
        public I9F23 Z;
        public I9F23 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(I9F23 x, I9F23 y, I9F23 z, I9F23 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(I9F23 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(I9F23 x, I9F23 y, Vector2I9F23 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(I9F23 x, Vector3I9F23 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(Vector2I9F23 xy, Vector2I9F23 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(Vector4I9F23 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(I9F23 x, Vector2I9F23 yz, I9F23 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(Vector3I9F23 xyz, I9F23 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23(Vector2I9F23 xy, I9F23 z, I9F23 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I9F23 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I9F23(I9F23.Zero);
        }
        public static Vector4I9F23 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I9F23(I9F23.One);
        }
        public static Vector4I9F23 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I9F23(I9F23.One, I9F23.Zero, I9F23.Zero, I9F23.Zero);
        }
        public static Vector4I9F23 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I9F23(I9F23.Zero, I9F23.One, I9F23.Zero, I9F23.Zero);
        }
        public static Vector4I9F23 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I9F23(I9F23.Zero, I9F23.Zero, I9F23.One, I9F23.Zero);
        }
        public static Vector4I9F23 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I9F23(I9F23.Zero, I9F23.Zero, I9F23.Zero, I9F23.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 operator +(Vector4I9F23 a, Vector4I9F23 b) => new Vector4I9F23(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 operator -(Vector4I9F23 a, Vector4I9F23 b) => new Vector4I9F23(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 operator *(Vector4I9F23 a, Vector4I9F23 b) => new Vector4I9F23(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 operator *(Vector4I9F23 a, I9F23 b) => new Vector4I9F23(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 operator *(I9F23 a, Vector4I9F23 b) => new Vector4I9F23(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 operator /(Vector4I9F23 a, Vector4I9F23 b) => new Vector4I9F23(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 operator /(Vector4I9F23 a, I9F23 b) => new Vector4I9F23(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I9F23 operator /(I9F23 a, Vector4I9F23 b) => new Vector4I9F23(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I9F23 lhs, Vector4I9F23 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I9F23 lhs, Vector4I9F23 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I9F23 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4I9F23 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I9F23>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I9F23 other)
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
        public Vector4I9F23 Min(Vector4I9F23 other) => new Vector4I9F23(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23 Max(Vector4I9F23 other) => new Vector4I9F23(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23 Abs() => new Vector4I9F23(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23 Half() => new Vector4I9F23(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23 Twice() => new Vector4I9F23(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23 Clamp(I9F23 min, I9F23 max) => new Vector4I9F23(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23 Clamp(
            Vector4I9F23 min, Vector4I9F23 max
        ) => new Vector4I9F23(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23 WrappingAdd(Vector4I9F23 other) => new Vector4I9F23(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23 WrappingSub(Vector4I9F23 other) => new Vector4I9F23(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23 WrappingMul(Vector4I9F23 other) => new Vector4I9F23(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23 WrappingAddUnsigned(Vector4U9F23 other) => new Vector4I9F23(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23 WrappingSubUnsigned(Vector4U9F23 other) => new Vector4I9F23(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23 UnsignedAbs() => new Vector4U9F23(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23 SaturatingAdd(Vector4I9F23 other) => new Vector4I9F23(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23 SaturatingMul(I9F23 other) => new Vector4I9F23(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I9F23 other) {
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
        public I9F23 Dot(Vector4I9F23 other) {
            const long k = 1L << 21;
            return I9F23.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I9F23 SaturatingDot(Vector4I9F23 other) {
            const long k = 1L << 21;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I9F23.MaxValue;
            } else if (bits < int.MinValue) {
                return I9F23.MinValue;
            } else {
                return I9F23.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U20F44 LengthSquaredUnsigned() => U20F44.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I20F44 LengthSquaredSigned() => I20F44.FromBits(
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
        public I20F44 LengthSquared() => LengthSquaredSigned();

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
        public U9F23 LengthHalfUnsigned() => U9F23.FromBits(LengthInternal());

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
        public I9F23 LengthHalf() => I9F23.FromBits(checked((int)LengthInternal()));

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
        public U10F22 LengthUnsigned() => U10F22.FromBits(LengthInternal());

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
        public I10F22 LengthSigned() => I10F22.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I10F22 Length() => LengthSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I9F23? Normalize() {
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

            const ulong k = 1UL << 22;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);
            var y3 = (int)(l3 * k / ll);

            return new Vector4I9F23(
                I9F23.FromBits(b0 ? -y0 : y0),
                I9F23.FromBits(b1 ? -y1 : y1),
                I9F23.FromBits(b2 ? -y2 : y2),
                I9F23.FromBits(b3 ? -y3 : y3));
        }

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I9F23 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(X, X); }
        public Vector2I9F23 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(X, Y); }
        public Vector2I9F23 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(X, Z); }
        public Vector2I9F23 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(X, W); }
        public Vector2I9F23 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(Y, X); }
        public Vector2I9F23 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(Y, Y); }
        public Vector2I9F23 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(Y, Z); }
        public Vector2I9F23 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(Y, W); }
        public Vector2I9F23 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(Z, X); }
        public Vector2I9F23 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(Z, Y); }
        public Vector2I9F23 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(Z, Z); }
        public Vector2I9F23 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(Z, W); }
        public Vector2I9F23 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(W, X); }
        public Vector2I9F23 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(W, Y); }
        public Vector2I9F23 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(W, Z); }
        public Vector2I9F23 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I9F23(W, W); }
        public Vector3I9F23 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, X, X); }
        public Vector3I9F23 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, X, Y); }
        public Vector3I9F23 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, X, Z); }
        public Vector3I9F23 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, X, W); }
        public Vector3I9F23 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, Y, X); }
        public Vector3I9F23 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, Y, Y); }
        public Vector3I9F23 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, Y, Z); }
        public Vector3I9F23 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, Y, W); }
        public Vector3I9F23 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, Z, X); }
        public Vector3I9F23 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, Z, Y); }
        public Vector3I9F23 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, Z, Z); }
        public Vector3I9F23 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, Z, W); }
        public Vector3I9F23 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, W, X); }
        public Vector3I9F23 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, W, Y); }
        public Vector3I9F23 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, W, Z); }
        public Vector3I9F23 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(X, W, W); }
        public Vector3I9F23 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, X, X); }
        public Vector3I9F23 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, X, Y); }
        public Vector3I9F23 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, X, Z); }
        public Vector3I9F23 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, X, W); }
        public Vector3I9F23 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, Y, X); }
        public Vector3I9F23 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, Y, Y); }
        public Vector3I9F23 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, Y, Z); }
        public Vector3I9F23 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, Y, W); }
        public Vector3I9F23 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, Z, X); }
        public Vector3I9F23 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, Z, Y); }
        public Vector3I9F23 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, Z, Z); }
        public Vector3I9F23 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, Z, W); }
        public Vector3I9F23 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, W, X); }
        public Vector3I9F23 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, W, Y); }
        public Vector3I9F23 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, W, Z); }
        public Vector3I9F23 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Y, W, W); }
        public Vector3I9F23 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, X, X); }
        public Vector3I9F23 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, X, Y); }
        public Vector3I9F23 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, X, Z); }
        public Vector3I9F23 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, X, W); }
        public Vector3I9F23 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, Y, X); }
        public Vector3I9F23 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, Y, Y); }
        public Vector3I9F23 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, Y, Z); }
        public Vector3I9F23 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, Y, W); }
        public Vector3I9F23 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, Z, X); }
        public Vector3I9F23 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, Z, Y); }
        public Vector3I9F23 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, Z, Z); }
        public Vector3I9F23 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, Z, W); }
        public Vector3I9F23 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, W, X); }
        public Vector3I9F23 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, W, Y); }
        public Vector3I9F23 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, W, Z); }
        public Vector3I9F23 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(Z, W, W); }
        public Vector3I9F23 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(W, X, X); }
        public Vector3I9F23 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(W, X, Y); }
        public Vector3I9F23 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(W, X, Z); }
        public Vector3I9F23 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(W, X, W); }
        public Vector3I9F23 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(W, Y, X); }
        public Vector3I9F23 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(W, Y, Y); }
        public Vector3I9F23 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(W, Y, Z); }
        public Vector3I9F23 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(W, Y, W); }
        public Vector3I9F23 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(W, Z, X); }
        public Vector3I9F23 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(W, Z, Y); }
        public Vector3I9F23 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(W, Z, Z); }
        public Vector3I9F23 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(W, Z, W); }
        public Vector3I9F23 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(W, W, X); }
        public Vector3I9F23 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(W, W, Y); }
        public Vector3I9F23 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(W, W, Z); }
        public Vector3I9F23 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I9F23(W, W, W); }
        public Vector4I9F23 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, X, X); }
        public Vector4I9F23 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, X, Y); }
        public Vector4I9F23 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, X, Z); }
        public Vector4I9F23 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, X, W); }
        public Vector4I9F23 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, Y, X); }
        public Vector4I9F23 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, Y, Y); }
        public Vector4I9F23 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, Y, Z); }
        public Vector4I9F23 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, Y, W); }
        public Vector4I9F23 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, Z, X); }
        public Vector4I9F23 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, Z, Y); }
        public Vector4I9F23 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, Z, Z); }
        public Vector4I9F23 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, Z, W); }
        public Vector4I9F23 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, W, X); }
        public Vector4I9F23 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, W, Y); }
        public Vector4I9F23 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, W, Z); }
        public Vector4I9F23 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, X, W, W); }
        public Vector4I9F23 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, X, X); }
        public Vector4I9F23 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, X, Y); }
        public Vector4I9F23 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, X, Z); }
        public Vector4I9F23 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, X, W); }
        public Vector4I9F23 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, Y, X); }
        public Vector4I9F23 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, Y, Y); }
        public Vector4I9F23 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, Y, Z); }
        public Vector4I9F23 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, Y, W); }
        public Vector4I9F23 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, Z, X); }
        public Vector4I9F23 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, Z, Y); }
        public Vector4I9F23 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, Z, Z); }
        public Vector4I9F23 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, Z, W); }
        public Vector4I9F23 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, W, X); }
        public Vector4I9F23 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, W, Y); }
        public Vector4I9F23 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, W, Z); }
        public Vector4I9F23 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Y, W, W); }
        public Vector4I9F23 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, X, X); }
        public Vector4I9F23 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, X, Y); }
        public Vector4I9F23 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, X, Z); }
        public Vector4I9F23 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, X, W); }
        public Vector4I9F23 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, Y, X); }
        public Vector4I9F23 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, Y, Y); }
        public Vector4I9F23 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, Y, Z); }
        public Vector4I9F23 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, Y, W); }
        public Vector4I9F23 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, Z, X); }
        public Vector4I9F23 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, Z, Y); }
        public Vector4I9F23 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, Z, Z); }
        public Vector4I9F23 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, Z, W); }
        public Vector4I9F23 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, W, X); }
        public Vector4I9F23 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, W, Y); }
        public Vector4I9F23 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, W, Z); }
        public Vector4I9F23 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, Z, W, W); }
        public Vector4I9F23 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, W, X, X); }
        public Vector4I9F23 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, W, X, Y); }
        public Vector4I9F23 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, W, X, Z); }
        public Vector4I9F23 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, W, X, W); }
        public Vector4I9F23 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, W, Y, X); }
        public Vector4I9F23 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, W, Y, Y); }
        public Vector4I9F23 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, W, Y, Z); }
        public Vector4I9F23 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, W, Y, W); }
        public Vector4I9F23 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, W, Z, X); }
        public Vector4I9F23 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, W, Z, Y); }
        public Vector4I9F23 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, W, Z, Z); }
        public Vector4I9F23 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, W, Z, W); }
        public Vector4I9F23 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, W, W, X); }
        public Vector4I9F23 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, W, W, Y); }
        public Vector4I9F23 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, W, W, Z); }
        public Vector4I9F23 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(X, W, W, W); }
        public Vector4I9F23 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, X, X); }
        public Vector4I9F23 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, X, Y); }
        public Vector4I9F23 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, X, Z); }
        public Vector4I9F23 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, X, W); }
        public Vector4I9F23 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, Y, X); }
        public Vector4I9F23 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, Y, Y); }
        public Vector4I9F23 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, Y, Z); }
        public Vector4I9F23 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, Y, W); }
        public Vector4I9F23 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, Z, X); }
        public Vector4I9F23 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, Z, Y); }
        public Vector4I9F23 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, Z, Z); }
        public Vector4I9F23 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, Z, W); }
        public Vector4I9F23 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, W, X); }
        public Vector4I9F23 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, W, Y); }
        public Vector4I9F23 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, W, Z); }
        public Vector4I9F23 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, X, W, W); }
        public Vector4I9F23 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, X, X); }
        public Vector4I9F23 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, X, Y); }
        public Vector4I9F23 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, X, Z); }
        public Vector4I9F23 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, X, W); }
        public Vector4I9F23 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, Y, X); }
        public Vector4I9F23 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, Y, Y); }
        public Vector4I9F23 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, Y, Z); }
        public Vector4I9F23 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, Y, W); }
        public Vector4I9F23 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, Z, X); }
        public Vector4I9F23 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, Z, Y); }
        public Vector4I9F23 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, Z, Z); }
        public Vector4I9F23 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, Z, W); }
        public Vector4I9F23 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, W, X); }
        public Vector4I9F23 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, W, Y); }
        public Vector4I9F23 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, W, Z); }
        public Vector4I9F23 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Y, W, W); }
        public Vector4I9F23 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, X, X); }
        public Vector4I9F23 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, X, Y); }
        public Vector4I9F23 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, X, Z); }
        public Vector4I9F23 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, X, W); }
        public Vector4I9F23 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, Y, X); }
        public Vector4I9F23 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, Y, Y); }
        public Vector4I9F23 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, Y, Z); }
        public Vector4I9F23 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, Y, W); }
        public Vector4I9F23 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, Z, X); }
        public Vector4I9F23 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, Z, Y); }
        public Vector4I9F23 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, Z, Z); }
        public Vector4I9F23 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, Z, W); }
        public Vector4I9F23 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, W, X); }
        public Vector4I9F23 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, W, Y); }
        public Vector4I9F23 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, W, Z); }
        public Vector4I9F23 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, Z, W, W); }
        public Vector4I9F23 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, W, X, X); }
        public Vector4I9F23 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, W, X, Y); }
        public Vector4I9F23 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, W, X, Z); }
        public Vector4I9F23 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, W, X, W); }
        public Vector4I9F23 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, W, Y, X); }
        public Vector4I9F23 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, W, Y, Y); }
        public Vector4I9F23 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, W, Y, Z); }
        public Vector4I9F23 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, W, Y, W); }
        public Vector4I9F23 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, W, Z, X); }
        public Vector4I9F23 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, W, Z, Y); }
        public Vector4I9F23 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, W, Z, Z); }
        public Vector4I9F23 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, W, Z, W); }
        public Vector4I9F23 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, W, W, X); }
        public Vector4I9F23 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, W, W, Y); }
        public Vector4I9F23 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, W, W, Z); }
        public Vector4I9F23 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Y, W, W, W); }
        public Vector4I9F23 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, X, X); }
        public Vector4I9F23 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, X, Y); }
        public Vector4I9F23 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, X, Z); }
        public Vector4I9F23 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, X, W); }
        public Vector4I9F23 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, Y, X); }
        public Vector4I9F23 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, Y, Y); }
        public Vector4I9F23 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, Y, Z); }
        public Vector4I9F23 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, Y, W); }
        public Vector4I9F23 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, Z, X); }
        public Vector4I9F23 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, Z, Y); }
        public Vector4I9F23 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, Z, Z); }
        public Vector4I9F23 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, Z, W); }
        public Vector4I9F23 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, W, X); }
        public Vector4I9F23 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, W, Y); }
        public Vector4I9F23 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, W, Z); }
        public Vector4I9F23 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, X, W, W); }
        public Vector4I9F23 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, X, X); }
        public Vector4I9F23 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, X, Y); }
        public Vector4I9F23 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, X, Z); }
        public Vector4I9F23 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, X, W); }
        public Vector4I9F23 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, Y, X); }
        public Vector4I9F23 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, Y, Y); }
        public Vector4I9F23 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, Y, Z); }
        public Vector4I9F23 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, Y, W); }
        public Vector4I9F23 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, Z, X); }
        public Vector4I9F23 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, Z, Y); }
        public Vector4I9F23 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, Z, Z); }
        public Vector4I9F23 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, Z, W); }
        public Vector4I9F23 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, W, X); }
        public Vector4I9F23 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, W, Y); }
        public Vector4I9F23 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, W, Z); }
        public Vector4I9F23 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Y, W, W); }
        public Vector4I9F23 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, X, X); }
        public Vector4I9F23 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, X, Y); }
        public Vector4I9F23 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, X, Z); }
        public Vector4I9F23 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, X, W); }
        public Vector4I9F23 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, Y, X); }
        public Vector4I9F23 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, Y, Y); }
        public Vector4I9F23 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, Y, Z); }
        public Vector4I9F23 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, Y, W); }
        public Vector4I9F23 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, Z, X); }
        public Vector4I9F23 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, Z, Y); }
        public Vector4I9F23 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, Z, Z); }
        public Vector4I9F23 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, Z, W); }
        public Vector4I9F23 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, W, X); }
        public Vector4I9F23 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, W, Y); }
        public Vector4I9F23 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, W, Z); }
        public Vector4I9F23 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, Z, W, W); }
        public Vector4I9F23 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, W, X, X); }
        public Vector4I9F23 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, W, X, Y); }
        public Vector4I9F23 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, W, X, Z); }
        public Vector4I9F23 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, W, X, W); }
        public Vector4I9F23 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, W, Y, X); }
        public Vector4I9F23 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, W, Y, Y); }
        public Vector4I9F23 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, W, Y, Z); }
        public Vector4I9F23 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, W, Y, W); }
        public Vector4I9F23 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, W, Z, X); }
        public Vector4I9F23 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, W, Z, Y); }
        public Vector4I9F23 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, W, Z, Z); }
        public Vector4I9F23 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, W, Z, W); }
        public Vector4I9F23 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, W, W, X); }
        public Vector4I9F23 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, W, W, Y); }
        public Vector4I9F23 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, W, W, Z); }
        public Vector4I9F23 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(Z, W, W, W); }
        public Vector4I9F23 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, X, X, X); }
        public Vector4I9F23 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, X, X, Y); }
        public Vector4I9F23 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, X, X, Z); }
        public Vector4I9F23 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, X, X, W); }
        public Vector4I9F23 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, X, Y, X); }
        public Vector4I9F23 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, X, Y, Y); }
        public Vector4I9F23 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, X, Y, Z); }
        public Vector4I9F23 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, X, Y, W); }
        public Vector4I9F23 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, X, Z, X); }
        public Vector4I9F23 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, X, Z, Y); }
        public Vector4I9F23 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, X, Z, Z); }
        public Vector4I9F23 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, X, Z, W); }
        public Vector4I9F23 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, X, W, X); }
        public Vector4I9F23 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, X, W, Y); }
        public Vector4I9F23 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, X, W, Z); }
        public Vector4I9F23 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, X, W, W); }
        public Vector4I9F23 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Y, X, X); }
        public Vector4I9F23 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Y, X, Y); }
        public Vector4I9F23 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Y, X, Z); }
        public Vector4I9F23 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Y, X, W); }
        public Vector4I9F23 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Y, Y, X); }
        public Vector4I9F23 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Y, Y, Y); }
        public Vector4I9F23 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Y, Y, Z); }
        public Vector4I9F23 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Y, Y, W); }
        public Vector4I9F23 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Y, Z, X); }
        public Vector4I9F23 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Y, Z, Y); }
        public Vector4I9F23 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Y, Z, Z); }
        public Vector4I9F23 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Y, Z, W); }
        public Vector4I9F23 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Y, W, X); }
        public Vector4I9F23 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Y, W, Y); }
        public Vector4I9F23 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Y, W, Z); }
        public Vector4I9F23 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Y, W, W); }
        public Vector4I9F23 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Z, X, X); }
        public Vector4I9F23 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Z, X, Y); }
        public Vector4I9F23 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Z, X, Z); }
        public Vector4I9F23 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Z, X, W); }
        public Vector4I9F23 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Z, Y, X); }
        public Vector4I9F23 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Z, Y, Y); }
        public Vector4I9F23 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Z, Y, Z); }
        public Vector4I9F23 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Z, Y, W); }
        public Vector4I9F23 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Z, Z, X); }
        public Vector4I9F23 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Z, Z, Y); }
        public Vector4I9F23 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Z, Z, Z); }
        public Vector4I9F23 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Z, Z, W); }
        public Vector4I9F23 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Z, W, X); }
        public Vector4I9F23 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Z, W, Y); }
        public Vector4I9F23 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Z, W, Z); }
        public Vector4I9F23 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, Z, W, W); }
        public Vector4I9F23 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, W, X, X); }
        public Vector4I9F23 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, W, X, Y); }
        public Vector4I9F23 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, W, X, Z); }
        public Vector4I9F23 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, W, X, W); }
        public Vector4I9F23 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, W, Y, X); }
        public Vector4I9F23 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, W, Y, Y); }
        public Vector4I9F23 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, W, Y, Z); }
        public Vector4I9F23 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, W, Y, W); }
        public Vector4I9F23 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, W, Z, X); }
        public Vector4I9F23 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, W, Z, Y); }
        public Vector4I9F23 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, W, Z, Z); }
        public Vector4I9F23 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, W, Z, W); }
        public Vector4I9F23 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, W, W, X); }
        public Vector4I9F23 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, W, W, Y); }
        public Vector4I9F23 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, W, W, Z); }
        public Vector4I9F23 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I9F23(W, W, W, W); }

    }
}
