using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I23F9
    : IEquatable<Vector4I23F9>
    , IFormattable
    , IVector<U48F16, I48F16, U24F8, I24F8>
    , IVectorComponentRespective<I23F9> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I23F9 X;
        public I23F9 Y;
        public I23F9 Z;
        public I23F9 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(I23F9 x, I23F9 y, I23F9 z, I23F9 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(I23F9 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(I23F9 x, I23F9 y, Vector2I23F9 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(I23F9 x, Vector3I23F9 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(Vector2I23F9 xy, Vector2I23F9 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(Vector4I23F9 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(I23F9 x, Vector2I23F9 yz, I23F9 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(Vector3I23F9 xyz, I23F9 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9(Vector2I23F9 xy, I23F9 z, I23F9 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I23F9 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I23F9(I23F9.Zero);
        }
        public static Vector4I23F9 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I23F9(I23F9.One);
        }
        public static Vector4I23F9 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I23F9(I23F9.One, I23F9.Zero, I23F9.Zero, I23F9.Zero);
        }
        public static Vector4I23F9 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I23F9(I23F9.Zero, I23F9.One, I23F9.Zero, I23F9.Zero);
        }
        public static Vector4I23F9 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I23F9(I23F9.Zero, I23F9.Zero, I23F9.One, I23F9.Zero);
        }
        public static Vector4I23F9 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I23F9(I23F9.Zero, I23F9.Zero, I23F9.Zero, I23F9.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 operator +(Vector4I23F9 a, Vector4I23F9 b) => new Vector4I23F9(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 operator -(Vector4I23F9 a, Vector4I23F9 b) => new Vector4I23F9(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 operator *(Vector4I23F9 a, Vector4I23F9 b) => new Vector4I23F9(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 operator *(Vector4I23F9 a, I23F9 b) => new Vector4I23F9(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 operator *(I23F9 a, Vector4I23F9 b) => new Vector4I23F9(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 operator /(Vector4I23F9 a, Vector4I23F9 b) => new Vector4I23F9(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 operator /(Vector4I23F9 a, I23F9 b) => new Vector4I23F9(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I23F9 operator /(I23F9 a, Vector4I23F9 b) => new Vector4I23F9(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I23F9 lhs, Vector4I23F9 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I23F9 lhs, Vector4I23F9 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I23F9 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4I23F9 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I23F9>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I23F9 other)
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
        public Vector4I23F9 Min(Vector4I23F9 other) => new Vector4I23F9(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 Max(Vector4I23F9 other) => new Vector4I23F9(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 Abs() => new Vector4I23F9(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 Half() => new Vector4I23F9(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 Twice() => new Vector4I23F9(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 Clamp(I23F9 min, I23F9 max) => new Vector4I23F9(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 Clamp(
            Vector4I23F9 min, Vector4I23F9 max
        ) => new Vector4I23F9(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 WrappingAdd(Vector4I23F9 other) => new Vector4I23F9(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 WrappingSub(Vector4I23F9 other) => new Vector4I23F9(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 WrappingMul(Vector4I23F9 other) => new Vector4I23F9(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 WrappingAddUnsigned(Vector4U23F9 other) => new Vector4I23F9(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 WrappingSubUnsigned(Vector4U23F9 other) => new Vector4I23F9(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U23F9 UnsignedAbs() => new Vector4U23F9(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 SaturatingAdd(Vector4I23F9 other) => new Vector4I23F9(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9 SaturatingMul(I23F9 other) => new Vector4I23F9(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I23F9 other) {
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
        public I23F9 Dot(Vector4I23F9 other) {
            const long k = 1L << 7;
            return I23F9.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I23F9 SaturatingDot(Vector4I23F9 other) {
            const long k = 1L << 7;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I23F9.MaxValue;
            } else if (bits < int.MinValue) {
                return I23F9.MinValue;
            } else {
                return I23F9.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U48F16 LengthSquaredUnsigned() => U48F16.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I48F16 LengthSquaredSigned() => I48F16.FromBits(
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
        public I48F16 LengthSquared() => LengthSquaredSigned();

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
        public U23F9 LengthHalfUnsigned() => U23F9.FromBits(LengthInternal());

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
        public I23F9 LengthHalf() => I23F9.FromBits(checked((int)LengthInternal()));

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
        public U24F8 LengthUnsigned() => U24F8.FromBits(LengthInternal());

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
        public I24F8 LengthSigned() => I24F8.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I24F8 Length() => LengthSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I23F9? Normalize() {
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

            const ulong k = 1UL << 8;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);
            var y3 = (int)(l3 * k / ll);

            return new Vector4I23F9(
                I23F9.FromBits(b0 ? -y0 : y0),
                I23F9.FromBits(b1 ? -y1 : y1),
                I23F9.FromBits(b2 ? -y2 : y2),
                I23F9.FromBits(b3 ? -y3 : y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I23F9 XX() => new Vector2I23F9(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I23F9 XY() => new Vector2I23F9(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I23F9 XZ() => new Vector2I23F9(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I23F9 XW() => new Vector2I23F9(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I23F9 YX() => new Vector2I23F9(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I23F9 YY() => new Vector2I23F9(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I23F9 YZ() => new Vector2I23F9(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I23F9 YW() => new Vector2I23F9(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I23F9 ZX() => new Vector2I23F9(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I23F9 ZY() => new Vector2I23F9(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I23F9 ZZ() => new Vector2I23F9(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I23F9 ZW() => new Vector2I23F9(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I23F9 WX() => new Vector2I23F9(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I23F9 WY() => new Vector2I23F9(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I23F9 WZ() => new Vector2I23F9(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I23F9 WW() => new Vector2I23F9(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 XXX() => new Vector3I23F9(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 XXY() => new Vector3I23F9(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 XXZ() => new Vector3I23F9(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 XXW() => new Vector3I23F9(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 XYX() => new Vector3I23F9(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 XYY() => new Vector3I23F9(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 XYZ() => new Vector3I23F9(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 XYW() => new Vector3I23F9(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 XZX() => new Vector3I23F9(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 XZY() => new Vector3I23F9(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 XZZ() => new Vector3I23F9(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 XZW() => new Vector3I23F9(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 XWX() => new Vector3I23F9(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 XWY() => new Vector3I23F9(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 XWZ() => new Vector3I23F9(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 XWW() => new Vector3I23F9(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 YXX() => new Vector3I23F9(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 YXY() => new Vector3I23F9(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 YXZ() => new Vector3I23F9(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 YXW() => new Vector3I23F9(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 YYX() => new Vector3I23F9(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 YYY() => new Vector3I23F9(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 YYZ() => new Vector3I23F9(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 YYW() => new Vector3I23F9(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 YZX() => new Vector3I23F9(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 YZY() => new Vector3I23F9(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 YZZ() => new Vector3I23F9(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 YZW() => new Vector3I23F9(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 YWX() => new Vector3I23F9(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 YWY() => new Vector3I23F9(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 YWZ() => new Vector3I23F9(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 YWW() => new Vector3I23F9(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 ZXX() => new Vector3I23F9(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 ZXY() => new Vector3I23F9(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 ZXZ() => new Vector3I23F9(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 ZXW() => new Vector3I23F9(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 ZYX() => new Vector3I23F9(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 ZYY() => new Vector3I23F9(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 ZYZ() => new Vector3I23F9(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 ZYW() => new Vector3I23F9(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 ZZX() => new Vector3I23F9(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 ZZY() => new Vector3I23F9(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 ZZZ() => new Vector3I23F9(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 ZZW() => new Vector3I23F9(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 ZWX() => new Vector3I23F9(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 ZWY() => new Vector3I23F9(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 ZWZ() => new Vector3I23F9(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 ZWW() => new Vector3I23F9(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 WXX() => new Vector3I23F9(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 WXY() => new Vector3I23F9(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 WXZ() => new Vector3I23F9(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 WXW() => new Vector3I23F9(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 WYX() => new Vector3I23F9(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 WYY() => new Vector3I23F9(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 WYZ() => new Vector3I23F9(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 WYW() => new Vector3I23F9(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 WZX() => new Vector3I23F9(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 WZY() => new Vector3I23F9(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 WZZ() => new Vector3I23F9(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 WZW() => new Vector3I23F9(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 WWX() => new Vector3I23F9(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 WWY() => new Vector3I23F9(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 WWZ() => new Vector3I23F9(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I23F9 WWW() => new Vector3I23F9(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XXXX() => new Vector4I23F9(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XXXY() => new Vector4I23F9(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XXXZ() => new Vector4I23F9(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XXXW() => new Vector4I23F9(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XXYX() => new Vector4I23F9(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XXYY() => new Vector4I23F9(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XXYZ() => new Vector4I23F9(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XXYW() => new Vector4I23F9(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XXZX() => new Vector4I23F9(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XXZY() => new Vector4I23F9(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XXZZ() => new Vector4I23F9(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XXZW() => new Vector4I23F9(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XXWX() => new Vector4I23F9(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XXWY() => new Vector4I23F9(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XXWZ() => new Vector4I23F9(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XXWW() => new Vector4I23F9(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XYXX() => new Vector4I23F9(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XYXY() => new Vector4I23F9(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XYXZ() => new Vector4I23F9(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XYXW() => new Vector4I23F9(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XYYX() => new Vector4I23F9(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XYYY() => new Vector4I23F9(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XYYZ() => new Vector4I23F9(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XYYW() => new Vector4I23F9(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XYZX() => new Vector4I23F9(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XYZY() => new Vector4I23F9(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XYZZ() => new Vector4I23F9(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XYZW() => new Vector4I23F9(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XYWX() => new Vector4I23F9(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XYWY() => new Vector4I23F9(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XYWZ() => new Vector4I23F9(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XYWW() => new Vector4I23F9(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XZXX() => new Vector4I23F9(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XZXY() => new Vector4I23F9(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XZXZ() => new Vector4I23F9(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XZXW() => new Vector4I23F9(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XZYX() => new Vector4I23F9(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XZYY() => new Vector4I23F9(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XZYZ() => new Vector4I23F9(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XZYW() => new Vector4I23F9(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XZZX() => new Vector4I23F9(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XZZY() => new Vector4I23F9(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XZZZ() => new Vector4I23F9(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XZZW() => new Vector4I23F9(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XZWX() => new Vector4I23F9(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XZWY() => new Vector4I23F9(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XZWZ() => new Vector4I23F9(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XZWW() => new Vector4I23F9(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XWXX() => new Vector4I23F9(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XWXY() => new Vector4I23F9(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XWXZ() => new Vector4I23F9(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XWXW() => new Vector4I23F9(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XWYX() => new Vector4I23F9(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XWYY() => new Vector4I23F9(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XWYZ() => new Vector4I23F9(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XWYW() => new Vector4I23F9(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XWZX() => new Vector4I23F9(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XWZY() => new Vector4I23F9(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XWZZ() => new Vector4I23F9(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XWZW() => new Vector4I23F9(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XWWX() => new Vector4I23F9(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XWWY() => new Vector4I23F9(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XWWZ() => new Vector4I23F9(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 XWWW() => new Vector4I23F9(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YXXX() => new Vector4I23F9(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YXXY() => new Vector4I23F9(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YXXZ() => new Vector4I23F9(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YXXW() => new Vector4I23F9(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YXYX() => new Vector4I23F9(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YXYY() => new Vector4I23F9(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YXYZ() => new Vector4I23F9(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YXYW() => new Vector4I23F9(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YXZX() => new Vector4I23F9(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YXZY() => new Vector4I23F9(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YXZZ() => new Vector4I23F9(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YXZW() => new Vector4I23F9(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YXWX() => new Vector4I23F9(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YXWY() => new Vector4I23F9(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YXWZ() => new Vector4I23F9(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YXWW() => new Vector4I23F9(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YYXX() => new Vector4I23F9(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YYXY() => new Vector4I23F9(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YYXZ() => new Vector4I23F9(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YYXW() => new Vector4I23F9(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YYYX() => new Vector4I23F9(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YYYY() => new Vector4I23F9(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YYYZ() => new Vector4I23F9(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YYYW() => new Vector4I23F9(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YYZX() => new Vector4I23F9(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YYZY() => new Vector4I23F9(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YYZZ() => new Vector4I23F9(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YYZW() => new Vector4I23F9(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YYWX() => new Vector4I23F9(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YYWY() => new Vector4I23F9(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YYWZ() => new Vector4I23F9(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YYWW() => new Vector4I23F9(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YZXX() => new Vector4I23F9(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YZXY() => new Vector4I23F9(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YZXZ() => new Vector4I23F9(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YZXW() => new Vector4I23F9(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YZYX() => new Vector4I23F9(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YZYY() => new Vector4I23F9(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YZYZ() => new Vector4I23F9(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YZYW() => new Vector4I23F9(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YZZX() => new Vector4I23F9(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YZZY() => new Vector4I23F9(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YZZZ() => new Vector4I23F9(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YZZW() => new Vector4I23F9(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YZWX() => new Vector4I23F9(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YZWY() => new Vector4I23F9(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YZWZ() => new Vector4I23F9(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YZWW() => new Vector4I23F9(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YWXX() => new Vector4I23F9(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YWXY() => new Vector4I23F9(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YWXZ() => new Vector4I23F9(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YWXW() => new Vector4I23F9(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YWYX() => new Vector4I23F9(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YWYY() => new Vector4I23F9(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YWYZ() => new Vector4I23F9(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YWYW() => new Vector4I23F9(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YWZX() => new Vector4I23F9(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YWZY() => new Vector4I23F9(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YWZZ() => new Vector4I23F9(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YWZW() => new Vector4I23F9(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YWWX() => new Vector4I23F9(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YWWY() => new Vector4I23F9(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YWWZ() => new Vector4I23F9(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 YWWW() => new Vector4I23F9(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZXXX() => new Vector4I23F9(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZXXY() => new Vector4I23F9(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZXXZ() => new Vector4I23F9(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZXXW() => new Vector4I23F9(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZXYX() => new Vector4I23F9(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZXYY() => new Vector4I23F9(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZXYZ() => new Vector4I23F9(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZXYW() => new Vector4I23F9(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZXZX() => new Vector4I23F9(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZXZY() => new Vector4I23F9(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZXZZ() => new Vector4I23F9(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZXZW() => new Vector4I23F9(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZXWX() => new Vector4I23F9(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZXWY() => new Vector4I23F9(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZXWZ() => new Vector4I23F9(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZXWW() => new Vector4I23F9(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZYXX() => new Vector4I23F9(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZYXY() => new Vector4I23F9(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZYXZ() => new Vector4I23F9(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZYXW() => new Vector4I23F9(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZYYX() => new Vector4I23F9(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZYYY() => new Vector4I23F9(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZYYZ() => new Vector4I23F9(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZYYW() => new Vector4I23F9(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZYZX() => new Vector4I23F9(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZYZY() => new Vector4I23F9(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZYZZ() => new Vector4I23F9(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZYZW() => new Vector4I23F9(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZYWX() => new Vector4I23F9(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZYWY() => new Vector4I23F9(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZYWZ() => new Vector4I23F9(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZYWW() => new Vector4I23F9(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZZXX() => new Vector4I23F9(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZZXY() => new Vector4I23F9(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZZXZ() => new Vector4I23F9(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZZXW() => new Vector4I23F9(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZZYX() => new Vector4I23F9(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZZYY() => new Vector4I23F9(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZZYZ() => new Vector4I23F9(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZZYW() => new Vector4I23F9(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZZZX() => new Vector4I23F9(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZZZY() => new Vector4I23F9(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZZZZ() => new Vector4I23F9(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZZZW() => new Vector4I23F9(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZZWX() => new Vector4I23F9(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZZWY() => new Vector4I23F9(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZZWZ() => new Vector4I23F9(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZZWW() => new Vector4I23F9(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZWXX() => new Vector4I23F9(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZWXY() => new Vector4I23F9(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZWXZ() => new Vector4I23F9(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZWXW() => new Vector4I23F9(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZWYX() => new Vector4I23F9(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZWYY() => new Vector4I23F9(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZWYZ() => new Vector4I23F9(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZWYW() => new Vector4I23F9(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZWZX() => new Vector4I23F9(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZWZY() => new Vector4I23F9(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZWZZ() => new Vector4I23F9(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZWZW() => new Vector4I23F9(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZWWX() => new Vector4I23F9(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZWWY() => new Vector4I23F9(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZWWZ() => new Vector4I23F9(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 ZWWW() => new Vector4I23F9(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WXXX() => new Vector4I23F9(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WXXY() => new Vector4I23F9(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WXXZ() => new Vector4I23F9(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WXXW() => new Vector4I23F9(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WXYX() => new Vector4I23F9(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WXYY() => new Vector4I23F9(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WXYZ() => new Vector4I23F9(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WXYW() => new Vector4I23F9(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WXZX() => new Vector4I23F9(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WXZY() => new Vector4I23F9(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WXZZ() => new Vector4I23F9(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WXZW() => new Vector4I23F9(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WXWX() => new Vector4I23F9(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WXWY() => new Vector4I23F9(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WXWZ() => new Vector4I23F9(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WXWW() => new Vector4I23F9(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WYXX() => new Vector4I23F9(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WYXY() => new Vector4I23F9(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WYXZ() => new Vector4I23F9(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WYXW() => new Vector4I23F9(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WYYX() => new Vector4I23F9(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WYYY() => new Vector4I23F9(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WYYZ() => new Vector4I23F9(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WYYW() => new Vector4I23F9(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WYZX() => new Vector4I23F9(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WYZY() => new Vector4I23F9(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WYZZ() => new Vector4I23F9(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WYZW() => new Vector4I23F9(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WYWX() => new Vector4I23F9(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WYWY() => new Vector4I23F9(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WYWZ() => new Vector4I23F9(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WYWW() => new Vector4I23F9(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WZXX() => new Vector4I23F9(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WZXY() => new Vector4I23F9(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WZXZ() => new Vector4I23F9(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WZXW() => new Vector4I23F9(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WZYX() => new Vector4I23F9(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WZYY() => new Vector4I23F9(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WZYZ() => new Vector4I23F9(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WZYW() => new Vector4I23F9(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WZZX() => new Vector4I23F9(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WZZY() => new Vector4I23F9(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WZZZ() => new Vector4I23F9(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WZZW() => new Vector4I23F9(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WZWX() => new Vector4I23F9(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WZWY() => new Vector4I23F9(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WZWZ() => new Vector4I23F9(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WZWW() => new Vector4I23F9(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WWXX() => new Vector4I23F9(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WWXY() => new Vector4I23F9(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WWXZ() => new Vector4I23F9(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WWXW() => new Vector4I23F9(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WWYX() => new Vector4I23F9(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WWYY() => new Vector4I23F9(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WWYZ() => new Vector4I23F9(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WWYW() => new Vector4I23F9(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WWZX() => new Vector4I23F9(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WWZY() => new Vector4I23F9(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WWZZ() => new Vector4I23F9(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WWZW() => new Vector4I23F9(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WWWX() => new Vector4I23F9(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WWWY() => new Vector4I23F9(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WWWZ() => new Vector4I23F9(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I23F9 WWWW() => new Vector4I23F9(W, W, W, W);

    }
}
