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

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I12F20 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(X, X); }
        public Vector2I12F20 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(X, Y); }
        public Vector2I12F20 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(X, Z); }
        public Vector2I12F20 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(X, W); }
        public Vector2I12F20 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Y, X); }
        public Vector2I12F20 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Y, Y); }
        public Vector2I12F20 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Y, Z); }
        public Vector2I12F20 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Y, W); }
        public Vector2I12F20 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Z, X); }
        public Vector2I12F20 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Z, Y); }
        public Vector2I12F20 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Z, Z); }
        public Vector2I12F20 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(Z, W); }
        public Vector2I12F20 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(W, X); }
        public Vector2I12F20 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(W, Y); }
        public Vector2I12F20 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(W, Z); }
        public Vector2I12F20 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I12F20(W, W); }
        public Vector3I12F20 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, X, X); }
        public Vector3I12F20 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, X, Y); }
        public Vector3I12F20 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, X, Z); }
        public Vector3I12F20 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, X, W); }
        public Vector3I12F20 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Y, X); }
        public Vector3I12F20 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Y, Y); }
        public Vector3I12F20 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Y, Z); }
        public Vector3I12F20 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Y, W); }
        public Vector3I12F20 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Z, X); }
        public Vector3I12F20 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Z, Y); }
        public Vector3I12F20 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Z, Z); }
        public Vector3I12F20 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, Z, W); }
        public Vector3I12F20 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, W, X); }
        public Vector3I12F20 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, W, Y); }
        public Vector3I12F20 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, W, Z); }
        public Vector3I12F20 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(X, W, W); }
        public Vector3I12F20 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, X, X); }
        public Vector3I12F20 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, X, Y); }
        public Vector3I12F20 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, X, Z); }
        public Vector3I12F20 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, X, W); }
        public Vector3I12F20 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Y, X); }
        public Vector3I12F20 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Y, Y); }
        public Vector3I12F20 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Y, Z); }
        public Vector3I12F20 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Y, W); }
        public Vector3I12F20 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Z, X); }
        public Vector3I12F20 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Z, Y); }
        public Vector3I12F20 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Z, Z); }
        public Vector3I12F20 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, Z, W); }
        public Vector3I12F20 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, W, X); }
        public Vector3I12F20 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, W, Y); }
        public Vector3I12F20 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, W, Z); }
        public Vector3I12F20 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Y, W, W); }
        public Vector3I12F20 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, X, X); }
        public Vector3I12F20 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, X, Y); }
        public Vector3I12F20 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, X, Z); }
        public Vector3I12F20 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, X, W); }
        public Vector3I12F20 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Y, X); }
        public Vector3I12F20 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Y, Y); }
        public Vector3I12F20 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Y, Z); }
        public Vector3I12F20 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Y, W); }
        public Vector3I12F20 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Z, X); }
        public Vector3I12F20 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Z, Y); }
        public Vector3I12F20 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Z, Z); }
        public Vector3I12F20 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, Z, W); }
        public Vector3I12F20 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, W, X); }
        public Vector3I12F20 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, W, Y); }
        public Vector3I12F20 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, W, Z); }
        public Vector3I12F20 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(Z, W, W); }
        public Vector3I12F20 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, X, X); }
        public Vector3I12F20 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, X, Y); }
        public Vector3I12F20 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, X, Z); }
        public Vector3I12F20 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, X, W); }
        public Vector3I12F20 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, Y, X); }
        public Vector3I12F20 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, Y, Y); }
        public Vector3I12F20 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, Y, Z); }
        public Vector3I12F20 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, Y, W); }
        public Vector3I12F20 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, Z, X); }
        public Vector3I12F20 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, Z, Y); }
        public Vector3I12F20 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, Z, Z); }
        public Vector3I12F20 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, Z, W); }
        public Vector3I12F20 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, W, X); }
        public Vector3I12F20 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, W, Y); }
        public Vector3I12F20 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, W, Z); }
        public Vector3I12F20 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I12F20(W, W, W); }
        public Vector4I12F20 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, X, X); }
        public Vector4I12F20 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, X, Y); }
        public Vector4I12F20 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, X, Z); }
        public Vector4I12F20 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, X, W); }
        public Vector4I12F20 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Y, X); }
        public Vector4I12F20 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Y, Y); }
        public Vector4I12F20 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Y, Z); }
        public Vector4I12F20 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Y, W); }
        public Vector4I12F20 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Z, X); }
        public Vector4I12F20 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Z, Y); }
        public Vector4I12F20 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Z, Z); }
        public Vector4I12F20 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, Z, W); }
        public Vector4I12F20 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, W, X); }
        public Vector4I12F20 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, W, Y); }
        public Vector4I12F20 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, W, Z); }
        public Vector4I12F20 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, X, W, W); }
        public Vector4I12F20 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, X, X); }
        public Vector4I12F20 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, X, Y); }
        public Vector4I12F20 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, X, Z); }
        public Vector4I12F20 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, X, W); }
        public Vector4I12F20 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Y, X); }
        public Vector4I12F20 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Y, Y); }
        public Vector4I12F20 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Y, Z); }
        public Vector4I12F20 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Y, W); }
        public Vector4I12F20 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Z, X); }
        public Vector4I12F20 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Z, Y); }
        public Vector4I12F20 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Z, Z); }
        public Vector4I12F20 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, Z, W); }
        public Vector4I12F20 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, W, X); }
        public Vector4I12F20 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, W, Y); }
        public Vector4I12F20 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, W, Z); }
        public Vector4I12F20 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Y, W, W); }
        public Vector4I12F20 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, X, X); }
        public Vector4I12F20 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, X, Y); }
        public Vector4I12F20 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, X, Z); }
        public Vector4I12F20 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, X, W); }
        public Vector4I12F20 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Y, X); }
        public Vector4I12F20 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Y, Y); }
        public Vector4I12F20 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Y, Z); }
        public Vector4I12F20 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Y, W); }
        public Vector4I12F20 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Z, X); }
        public Vector4I12F20 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Z, Y); }
        public Vector4I12F20 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Z, Z); }
        public Vector4I12F20 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, Z, W); }
        public Vector4I12F20 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, W, X); }
        public Vector4I12F20 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, W, Y); }
        public Vector4I12F20 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, W, Z); }
        public Vector4I12F20 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, Z, W, W); }
        public Vector4I12F20 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, X, X); }
        public Vector4I12F20 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, X, Y); }
        public Vector4I12F20 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, X, Z); }
        public Vector4I12F20 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, X, W); }
        public Vector4I12F20 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, Y, X); }
        public Vector4I12F20 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, Y, Y); }
        public Vector4I12F20 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, Y, Z); }
        public Vector4I12F20 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, Y, W); }
        public Vector4I12F20 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, Z, X); }
        public Vector4I12F20 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, Z, Y); }
        public Vector4I12F20 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, Z, Z); }
        public Vector4I12F20 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, Z, W); }
        public Vector4I12F20 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, W, X); }
        public Vector4I12F20 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, W, Y); }
        public Vector4I12F20 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, W, Z); }
        public Vector4I12F20 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(X, W, W, W); }
        public Vector4I12F20 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, X, X); }
        public Vector4I12F20 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, X, Y); }
        public Vector4I12F20 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, X, Z); }
        public Vector4I12F20 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, X, W); }
        public Vector4I12F20 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Y, X); }
        public Vector4I12F20 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Y, Y); }
        public Vector4I12F20 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Y, Z); }
        public Vector4I12F20 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Y, W); }
        public Vector4I12F20 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Z, X); }
        public Vector4I12F20 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Z, Y); }
        public Vector4I12F20 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Z, Z); }
        public Vector4I12F20 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, Z, W); }
        public Vector4I12F20 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, W, X); }
        public Vector4I12F20 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, W, Y); }
        public Vector4I12F20 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, W, Z); }
        public Vector4I12F20 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, X, W, W); }
        public Vector4I12F20 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, X, X); }
        public Vector4I12F20 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, X, Y); }
        public Vector4I12F20 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, X, Z); }
        public Vector4I12F20 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, X, W); }
        public Vector4I12F20 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Y, X); }
        public Vector4I12F20 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Y, Y); }
        public Vector4I12F20 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Y, Z); }
        public Vector4I12F20 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Y, W); }
        public Vector4I12F20 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Z, X); }
        public Vector4I12F20 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Z, Y); }
        public Vector4I12F20 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Z, Z); }
        public Vector4I12F20 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, Z, W); }
        public Vector4I12F20 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, W, X); }
        public Vector4I12F20 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, W, Y); }
        public Vector4I12F20 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, W, Z); }
        public Vector4I12F20 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Y, W, W); }
        public Vector4I12F20 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, X, X); }
        public Vector4I12F20 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, X, Y); }
        public Vector4I12F20 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, X, Z); }
        public Vector4I12F20 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, X, W); }
        public Vector4I12F20 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Y, X); }
        public Vector4I12F20 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Y, Y); }
        public Vector4I12F20 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Y, Z); }
        public Vector4I12F20 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Y, W); }
        public Vector4I12F20 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Z, X); }
        public Vector4I12F20 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Z, Y); }
        public Vector4I12F20 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Z, Z); }
        public Vector4I12F20 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, Z, W); }
        public Vector4I12F20 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, W, X); }
        public Vector4I12F20 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, W, Y); }
        public Vector4I12F20 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, W, Z); }
        public Vector4I12F20 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, Z, W, W); }
        public Vector4I12F20 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, X, X); }
        public Vector4I12F20 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, X, Y); }
        public Vector4I12F20 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, X, Z); }
        public Vector4I12F20 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, X, W); }
        public Vector4I12F20 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, Y, X); }
        public Vector4I12F20 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, Y, Y); }
        public Vector4I12F20 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, Y, Z); }
        public Vector4I12F20 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, Y, W); }
        public Vector4I12F20 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, Z, X); }
        public Vector4I12F20 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, Z, Y); }
        public Vector4I12F20 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, Z, Z); }
        public Vector4I12F20 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, Z, W); }
        public Vector4I12F20 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, W, X); }
        public Vector4I12F20 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, W, Y); }
        public Vector4I12F20 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, W, Z); }
        public Vector4I12F20 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Y, W, W, W); }
        public Vector4I12F20 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, X, X); }
        public Vector4I12F20 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, X, Y); }
        public Vector4I12F20 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, X, Z); }
        public Vector4I12F20 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, X, W); }
        public Vector4I12F20 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Y, X); }
        public Vector4I12F20 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Y, Y); }
        public Vector4I12F20 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Y, Z); }
        public Vector4I12F20 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Y, W); }
        public Vector4I12F20 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Z, X); }
        public Vector4I12F20 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Z, Y); }
        public Vector4I12F20 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Z, Z); }
        public Vector4I12F20 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, Z, W); }
        public Vector4I12F20 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, W, X); }
        public Vector4I12F20 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, W, Y); }
        public Vector4I12F20 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, W, Z); }
        public Vector4I12F20 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, X, W, W); }
        public Vector4I12F20 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, X, X); }
        public Vector4I12F20 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, X, Y); }
        public Vector4I12F20 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, X, Z); }
        public Vector4I12F20 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, X, W); }
        public Vector4I12F20 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Y, X); }
        public Vector4I12F20 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Y, Y); }
        public Vector4I12F20 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Y, Z); }
        public Vector4I12F20 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Y, W); }
        public Vector4I12F20 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Z, X); }
        public Vector4I12F20 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Z, Y); }
        public Vector4I12F20 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Z, Z); }
        public Vector4I12F20 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, Z, W); }
        public Vector4I12F20 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, W, X); }
        public Vector4I12F20 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, W, Y); }
        public Vector4I12F20 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, W, Z); }
        public Vector4I12F20 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Y, W, W); }
        public Vector4I12F20 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, X, X); }
        public Vector4I12F20 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, X, Y); }
        public Vector4I12F20 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, X, Z); }
        public Vector4I12F20 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, X, W); }
        public Vector4I12F20 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Y, X); }
        public Vector4I12F20 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Y, Y); }
        public Vector4I12F20 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Y, Z); }
        public Vector4I12F20 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Y, W); }
        public Vector4I12F20 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Z, X); }
        public Vector4I12F20 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Z, Y); }
        public Vector4I12F20 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Z, Z); }
        public Vector4I12F20 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, Z, W); }
        public Vector4I12F20 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, W, X); }
        public Vector4I12F20 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, W, Y); }
        public Vector4I12F20 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, W, Z); }
        public Vector4I12F20 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, Z, W, W); }
        public Vector4I12F20 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, X, X); }
        public Vector4I12F20 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, X, Y); }
        public Vector4I12F20 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, X, Z); }
        public Vector4I12F20 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, X, W); }
        public Vector4I12F20 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, Y, X); }
        public Vector4I12F20 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, Y, Y); }
        public Vector4I12F20 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, Y, Z); }
        public Vector4I12F20 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, Y, W); }
        public Vector4I12F20 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, Z, X); }
        public Vector4I12F20 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, Z, Y); }
        public Vector4I12F20 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, Z, Z); }
        public Vector4I12F20 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, Z, W); }
        public Vector4I12F20 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, W, X); }
        public Vector4I12F20 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, W, Y); }
        public Vector4I12F20 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, W, Z); }
        public Vector4I12F20 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(Z, W, W, W); }
        public Vector4I12F20 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, X, X); }
        public Vector4I12F20 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, X, Y); }
        public Vector4I12F20 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, X, Z); }
        public Vector4I12F20 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, X, W); }
        public Vector4I12F20 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, Y, X); }
        public Vector4I12F20 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, Y, Y); }
        public Vector4I12F20 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, Y, Z); }
        public Vector4I12F20 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, Y, W); }
        public Vector4I12F20 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, Z, X); }
        public Vector4I12F20 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, Z, Y); }
        public Vector4I12F20 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, Z, Z); }
        public Vector4I12F20 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, Z, W); }
        public Vector4I12F20 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, W, X); }
        public Vector4I12F20 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, W, Y); }
        public Vector4I12F20 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, W, Z); }
        public Vector4I12F20 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, X, W, W); }
        public Vector4I12F20 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, X, X); }
        public Vector4I12F20 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, X, Y); }
        public Vector4I12F20 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, X, Z); }
        public Vector4I12F20 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, X, W); }
        public Vector4I12F20 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, Y, X); }
        public Vector4I12F20 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, Y, Y); }
        public Vector4I12F20 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, Y, Z); }
        public Vector4I12F20 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, Y, W); }
        public Vector4I12F20 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, Z, X); }
        public Vector4I12F20 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, Z, Y); }
        public Vector4I12F20 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, Z, Z); }
        public Vector4I12F20 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, Z, W); }
        public Vector4I12F20 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, W, X); }
        public Vector4I12F20 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, W, Y); }
        public Vector4I12F20 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, W, Z); }
        public Vector4I12F20 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Y, W, W); }
        public Vector4I12F20 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, X, X); }
        public Vector4I12F20 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, X, Y); }
        public Vector4I12F20 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, X, Z); }
        public Vector4I12F20 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, X, W); }
        public Vector4I12F20 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, Y, X); }
        public Vector4I12F20 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, Y, Y); }
        public Vector4I12F20 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, Y, Z); }
        public Vector4I12F20 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, Y, W); }
        public Vector4I12F20 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, Z, X); }
        public Vector4I12F20 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, Z, Y); }
        public Vector4I12F20 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, Z, Z); }
        public Vector4I12F20 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, Z, W); }
        public Vector4I12F20 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, W, X); }
        public Vector4I12F20 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, W, Y); }
        public Vector4I12F20 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, W, Z); }
        public Vector4I12F20 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, Z, W, W); }
        public Vector4I12F20 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, X, X); }
        public Vector4I12F20 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, X, Y); }
        public Vector4I12F20 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, X, Z); }
        public Vector4I12F20 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, X, W); }
        public Vector4I12F20 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, Y, X); }
        public Vector4I12F20 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, Y, Y); }
        public Vector4I12F20 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, Y, Z); }
        public Vector4I12F20 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, Y, W); }
        public Vector4I12F20 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, Z, X); }
        public Vector4I12F20 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, Z, Y); }
        public Vector4I12F20 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, Z, Z); }
        public Vector4I12F20 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, Z, W); }
        public Vector4I12F20 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, W, X); }
        public Vector4I12F20 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, W, Y); }
        public Vector4I12F20 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, W, Z); }
        public Vector4I12F20 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I12F20(W, W, W, W); }

    }
}
