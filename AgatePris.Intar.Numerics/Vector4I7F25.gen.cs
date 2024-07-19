using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I7F25
    : IEquatable<Vector4I7F25>
    , IFormattable
    , IVector<U16F48, I16F48, U8F24, I8F24>
    , IVectorComponentRespective<I7F25> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I7F25 X;
        public I7F25 Y;
        public I7F25 Z;
        public I7F25 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(I7F25 x, I7F25 y, I7F25 z, I7F25 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(I7F25 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(I7F25 x, I7F25 y, Vector2I7F25 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(I7F25 x, Vector3I7F25 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(Vector2I7F25 xy, Vector2I7F25 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(Vector4I7F25 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(I7F25 x, Vector2I7F25 yz, I7F25 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(Vector3I7F25 xyz, I7F25 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25(Vector2I7F25 xy, I7F25 z, I7F25 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I7F25 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I7F25(I7F25.Zero);
        }
        public static Vector4I7F25 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I7F25(I7F25.One);
        }
        public static Vector4I7F25 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I7F25(I7F25.One, I7F25.Zero, I7F25.Zero, I7F25.Zero);
        }
        public static Vector4I7F25 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I7F25(I7F25.Zero, I7F25.One, I7F25.Zero, I7F25.Zero);
        }
        public static Vector4I7F25 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I7F25(I7F25.Zero, I7F25.Zero, I7F25.One, I7F25.Zero);
        }
        public static Vector4I7F25 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I7F25(I7F25.Zero, I7F25.Zero, I7F25.Zero, I7F25.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 operator +(Vector4I7F25 a, Vector4I7F25 b) => new Vector4I7F25(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 operator -(Vector4I7F25 a, Vector4I7F25 b) => new Vector4I7F25(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 operator *(Vector4I7F25 a, Vector4I7F25 b) => new Vector4I7F25(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 operator *(Vector4I7F25 a, I7F25 b) => new Vector4I7F25(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 operator *(I7F25 a, Vector4I7F25 b) => new Vector4I7F25(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 operator /(Vector4I7F25 a, Vector4I7F25 b) => new Vector4I7F25(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 operator /(Vector4I7F25 a, I7F25 b) => new Vector4I7F25(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I7F25 operator /(I7F25 a, Vector4I7F25 b) => new Vector4I7F25(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I7F25 lhs, Vector4I7F25 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I7F25 lhs, Vector4I7F25 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I7F25 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4I7F25 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I7F25>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I7F25 other)
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
        public Vector4I7F25 Min(Vector4I7F25 other) => new Vector4I7F25(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25 Max(Vector4I7F25 other) => new Vector4I7F25(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25 Abs() => new Vector4I7F25(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25 Half() => new Vector4I7F25(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25 Twice() => new Vector4I7F25(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25 Clamp(I7F25 min, I7F25 max) => new Vector4I7F25(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25 Clamp(
            Vector4I7F25 min, Vector4I7F25 max
        ) => new Vector4I7F25(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25 WrappingAdd(Vector4I7F25 other) => new Vector4I7F25(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25 WrappingSub(Vector4I7F25 other) => new Vector4I7F25(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25 WrappingMul(Vector4I7F25 other) => new Vector4I7F25(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25 WrappingAddUnsigned(Vector4U7F25 other) => new Vector4I7F25(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25 WrappingSubUnsigned(Vector4U7F25 other) => new Vector4I7F25(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25 UnsignedAbs() => new Vector4U7F25(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25 SaturatingAdd(Vector4I7F25 other) => new Vector4I7F25(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25 SaturatingMul(I7F25 other) => new Vector4I7F25(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I7F25 other) {
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
        public I7F25 Dot(Vector4I7F25 other) {
            const long k = 1L << 23;
            return I7F25.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I7F25 SaturatingDot(Vector4I7F25 other) {
            const long k = 1L << 23;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I7F25.MaxValue;
            } else if (bits < int.MinValue) {
                return I7F25.MinValue;
            } else {
                return I7F25.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U16F48 LengthSquaredUnsigned() => U16F48.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I16F48 LengthSquaredSigned() => I16F48.FromBits(
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
        public I16F48 LengthSquared() => LengthSquaredSigned();

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
        public U7F25 LengthHalfUnsigned() => U7F25.FromBits(LengthInternal());

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
        public I7F25 LengthHalf() => I7F25.FromBits(checked((int)LengthInternal()));

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
        public U8F24 LengthUnsigned() => U8F24.FromBits(LengthInternal());

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
        public I8F24 LengthSigned() => I8F24.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I8F24 Length() => LengthSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25? Normalize() {
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

            const ulong k = 1UL << 24;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);
            var y3 = (int)(l3 * k / ll);

            return new Vector4I7F25(
                I7F25.FromBits(b0 ? -y0 : y0),
                I7F25.FromBits(b1 ? -y1 : y1),
                I7F25.FromBits(b2 ? -y2 : y2),
                I7F25.FromBits(b3 ? -y3 : y3));
        }

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I7F25 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(X, X); }
        public Vector2I7F25 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(X, Y); }
        public Vector2I7F25 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(X, Z); }
        public Vector2I7F25 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(X, W); }
        public Vector2I7F25 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Y, X); }
        public Vector2I7F25 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Y, Y); }
        public Vector2I7F25 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Y, Z); }
        public Vector2I7F25 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Y, W); }
        public Vector2I7F25 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Z, X); }
        public Vector2I7F25 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Z, Y); }
        public Vector2I7F25 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Z, Z); }
        public Vector2I7F25 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(Z, W); }
        public Vector2I7F25 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(W, X); }
        public Vector2I7F25 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(W, Y); }
        public Vector2I7F25 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(W, Z); }
        public Vector2I7F25 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I7F25(W, W); }
        public Vector3I7F25 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, X, X); }
        public Vector3I7F25 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, X, Y); }
        public Vector3I7F25 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, X, Z); }
        public Vector3I7F25 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, X, W); }
        public Vector3I7F25 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Y, X); }
        public Vector3I7F25 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Y, Y); }
        public Vector3I7F25 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Y, Z); }
        public Vector3I7F25 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Y, W); }
        public Vector3I7F25 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Z, X); }
        public Vector3I7F25 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Z, Y); }
        public Vector3I7F25 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Z, Z); }
        public Vector3I7F25 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, Z, W); }
        public Vector3I7F25 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, W, X); }
        public Vector3I7F25 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, W, Y); }
        public Vector3I7F25 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, W, Z); }
        public Vector3I7F25 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(X, W, W); }
        public Vector3I7F25 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, X, X); }
        public Vector3I7F25 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, X, Y); }
        public Vector3I7F25 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, X, Z); }
        public Vector3I7F25 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, X, W); }
        public Vector3I7F25 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Y, X); }
        public Vector3I7F25 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Y, Y); }
        public Vector3I7F25 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Y, Z); }
        public Vector3I7F25 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Y, W); }
        public Vector3I7F25 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Z, X); }
        public Vector3I7F25 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Z, Y); }
        public Vector3I7F25 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Z, Z); }
        public Vector3I7F25 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, Z, W); }
        public Vector3I7F25 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, W, X); }
        public Vector3I7F25 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, W, Y); }
        public Vector3I7F25 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, W, Z); }
        public Vector3I7F25 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Y, W, W); }
        public Vector3I7F25 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, X, X); }
        public Vector3I7F25 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, X, Y); }
        public Vector3I7F25 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, X, Z); }
        public Vector3I7F25 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, X, W); }
        public Vector3I7F25 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Y, X); }
        public Vector3I7F25 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Y, Y); }
        public Vector3I7F25 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Y, Z); }
        public Vector3I7F25 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Y, W); }
        public Vector3I7F25 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Z, X); }
        public Vector3I7F25 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Z, Y); }
        public Vector3I7F25 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Z, Z); }
        public Vector3I7F25 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, Z, W); }
        public Vector3I7F25 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, W, X); }
        public Vector3I7F25 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, W, Y); }
        public Vector3I7F25 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, W, Z); }
        public Vector3I7F25 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(Z, W, W); }
        public Vector3I7F25 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(W, X, X); }
        public Vector3I7F25 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(W, X, Y); }
        public Vector3I7F25 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(W, X, Z); }
        public Vector3I7F25 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(W, X, W); }
        public Vector3I7F25 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(W, Y, X); }
        public Vector3I7F25 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(W, Y, Y); }
        public Vector3I7F25 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(W, Y, Z); }
        public Vector3I7F25 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(W, Y, W); }
        public Vector3I7F25 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(W, Z, X); }
        public Vector3I7F25 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(W, Z, Y); }
        public Vector3I7F25 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(W, Z, Z); }
        public Vector3I7F25 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(W, Z, W); }
        public Vector3I7F25 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(W, W, X); }
        public Vector3I7F25 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(W, W, Y); }
        public Vector3I7F25 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(W, W, Z); }
        public Vector3I7F25 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I7F25(W, W, W); }
        public Vector4I7F25 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, X, X); }
        public Vector4I7F25 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, X, Y); }
        public Vector4I7F25 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, X, Z); }
        public Vector4I7F25 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, X, W); }
        public Vector4I7F25 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Y, X); }
        public Vector4I7F25 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Y, Y); }
        public Vector4I7F25 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Y, Z); }
        public Vector4I7F25 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Y, W); }
        public Vector4I7F25 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Z, X); }
        public Vector4I7F25 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Z, Y); }
        public Vector4I7F25 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Z, Z); }
        public Vector4I7F25 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, Z, W); }
        public Vector4I7F25 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, W, X); }
        public Vector4I7F25 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, W, Y); }
        public Vector4I7F25 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, W, Z); }
        public Vector4I7F25 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, X, W, W); }
        public Vector4I7F25 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, X, X); }
        public Vector4I7F25 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, X, Y); }
        public Vector4I7F25 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, X, Z); }
        public Vector4I7F25 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, X, W); }
        public Vector4I7F25 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Y, X); }
        public Vector4I7F25 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Y, Y); }
        public Vector4I7F25 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Y, Z); }
        public Vector4I7F25 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Y, W); }
        public Vector4I7F25 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Z, X); }
        public Vector4I7F25 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Z, Y); }
        public Vector4I7F25 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Z, Z); }
        public Vector4I7F25 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, Z, W); }
        public Vector4I7F25 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, W, X); }
        public Vector4I7F25 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, W, Y); }
        public Vector4I7F25 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, W, Z); }
        public Vector4I7F25 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Y, W, W); }
        public Vector4I7F25 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, X, X); }
        public Vector4I7F25 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, X, Y); }
        public Vector4I7F25 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, X, Z); }
        public Vector4I7F25 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, X, W); }
        public Vector4I7F25 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Y, X); }
        public Vector4I7F25 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Y, Y); }
        public Vector4I7F25 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Y, Z); }
        public Vector4I7F25 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Y, W); }
        public Vector4I7F25 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Z, X); }
        public Vector4I7F25 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Z, Y); }
        public Vector4I7F25 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Z, Z); }
        public Vector4I7F25 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, Z, W); }
        public Vector4I7F25 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, W, X); }
        public Vector4I7F25 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, W, Y); }
        public Vector4I7F25 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, W, Z); }
        public Vector4I7F25 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, Z, W, W); }
        public Vector4I7F25 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, W, X, X); }
        public Vector4I7F25 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, W, X, Y); }
        public Vector4I7F25 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, W, X, Z); }
        public Vector4I7F25 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, W, X, W); }
        public Vector4I7F25 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, W, Y, X); }
        public Vector4I7F25 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, W, Y, Y); }
        public Vector4I7F25 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, W, Y, Z); }
        public Vector4I7F25 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, W, Y, W); }
        public Vector4I7F25 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, W, Z, X); }
        public Vector4I7F25 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, W, Z, Y); }
        public Vector4I7F25 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, W, Z, Z); }
        public Vector4I7F25 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, W, Z, W); }
        public Vector4I7F25 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, W, W, X); }
        public Vector4I7F25 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, W, W, Y); }
        public Vector4I7F25 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, W, W, Z); }
        public Vector4I7F25 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(X, W, W, W); }
        public Vector4I7F25 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, X, X); }
        public Vector4I7F25 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, X, Y); }
        public Vector4I7F25 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, X, Z); }
        public Vector4I7F25 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, X, W); }
        public Vector4I7F25 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Y, X); }
        public Vector4I7F25 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Y, Y); }
        public Vector4I7F25 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Y, Z); }
        public Vector4I7F25 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Y, W); }
        public Vector4I7F25 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Z, X); }
        public Vector4I7F25 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Z, Y); }
        public Vector4I7F25 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Z, Z); }
        public Vector4I7F25 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, Z, W); }
        public Vector4I7F25 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, W, X); }
        public Vector4I7F25 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, W, Y); }
        public Vector4I7F25 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, W, Z); }
        public Vector4I7F25 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, X, W, W); }
        public Vector4I7F25 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, X, X); }
        public Vector4I7F25 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, X, Y); }
        public Vector4I7F25 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, X, Z); }
        public Vector4I7F25 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, X, W); }
        public Vector4I7F25 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Y, X); }
        public Vector4I7F25 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Y, Y); }
        public Vector4I7F25 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Y, Z); }
        public Vector4I7F25 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Y, W); }
        public Vector4I7F25 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Z, X); }
        public Vector4I7F25 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Z, Y); }
        public Vector4I7F25 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Z, Z); }
        public Vector4I7F25 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, Z, W); }
        public Vector4I7F25 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, W, X); }
        public Vector4I7F25 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, W, Y); }
        public Vector4I7F25 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, W, Z); }
        public Vector4I7F25 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Y, W, W); }
        public Vector4I7F25 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, X, X); }
        public Vector4I7F25 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, X, Y); }
        public Vector4I7F25 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, X, Z); }
        public Vector4I7F25 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, X, W); }
        public Vector4I7F25 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Y, X); }
        public Vector4I7F25 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Y, Y); }
        public Vector4I7F25 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Y, Z); }
        public Vector4I7F25 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Y, W); }
        public Vector4I7F25 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Z, X); }
        public Vector4I7F25 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Z, Y); }
        public Vector4I7F25 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Z, Z); }
        public Vector4I7F25 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, Z, W); }
        public Vector4I7F25 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, W, X); }
        public Vector4I7F25 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, W, Y); }
        public Vector4I7F25 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, W, Z); }
        public Vector4I7F25 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, Z, W, W); }
        public Vector4I7F25 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, W, X, X); }
        public Vector4I7F25 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, W, X, Y); }
        public Vector4I7F25 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, W, X, Z); }
        public Vector4I7F25 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, W, X, W); }
        public Vector4I7F25 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, W, Y, X); }
        public Vector4I7F25 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, W, Y, Y); }
        public Vector4I7F25 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, W, Y, Z); }
        public Vector4I7F25 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, W, Y, W); }
        public Vector4I7F25 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, W, Z, X); }
        public Vector4I7F25 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, W, Z, Y); }
        public Vector4I7F25 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, W, Z, Z); }
        public Vector4I7F25 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, W, Z, W); }
        public Vector4I7F25 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, W, W, X); }
        public Vector4I7F25 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, W, W, Y); }
        public Vector4I7F25 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, W, W, Z); }
        public Vector4I7F25 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Y, W, W, W); }
        public Vector4I7F25 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, X, X); }
        public Vector4I7F25 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, X, Y); }
        public Vector4I7F25 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, X, Z); }
        public Vector4I7F25 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, X, W); }
        public Vector4I7F25 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Y, X); }
        public Vector4I7F25 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Y, Y); }
        public Vector4I7F25 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Y, Z); }
        public Vector4I7F25 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Y, W); }
        public Vector4I7F25 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Z, X); }
        public Vector4I7F25 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Z, Y); }
        public Vector4I7F25 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Z, Z); }
        public Vector4I7F25 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, Z, W); }
        public Vector4I7F25 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, W, X); }
        public Vector4I7F25 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, W, Y); }
        public Vector4I7F25 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, W, Z); }
        public Vector4I7F25 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, X, W, W); }
        public Vector4I7F25 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, X, X); }
        public Vector4I7F25 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, X, Y); }
        public Vector4I7F25 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, X, Z); }
        public Vector4I7F25 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, X, W); }
        public Vector4I7F25 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Y, X); }
        public Vector4I7F25 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Y, Y); }
        public Vector4I7F25 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Y, Z); }
        public Vector4I7F25 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Y, W); }
        public Vector4I7F25 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Z, X); }
        public Vector4I7F25 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Z, Y); }
        public Vector4I7F25 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Z, Z); }
        public Vector4I7F25 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, Z, W); }
        public Vector4I7F25 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, W, X); }
        public Vector4I7F25 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, W, Y); }
        public Vector4I7F25 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, W, Z); }
        public Vector4I7F25 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Y, W, W); }
        public Vector4I7F25 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, X, X); }
        public Vector4I7F25 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, X, Y); }
        public Vector4I7F25 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, X, Z); }
        public Vector4I7F25 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, X, W); }
        public Vector4I7F25 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Y, X); }
        public Vector4I7F25 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Y, Y); }
        public Vector4I7F25 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Y, Z); }
        public Vector4I7F25 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Y, W); }
        public Vector4I7F25 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Z, X); }
        public Vector4I7F25 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Z, Y); }
        public Vector4I7F25 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Z, Z); }
        public Vector4I7F25 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, Z, W); }
        public Vector4I7F25 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, W, X); }
        public Vector4I7F25 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, W, Y); }
        public Vector4I7F25 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, W, Z); }
        public Vector4I7F25 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, Z, W, W); }
        public Vector4I7F25 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, W, X, X); }
        public Vector4I7F25 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, W, X, Y); }
        public Vector4I7F25 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, W, X, Z); }
        public Vector4I7F25 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, W, X, W); }
        public Vector4I7F25 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, W, Y, X); }
        public Vector4I7F25 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, W, Y, Y); }
        public Vector4I7F25 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, W, Y, Z); }
        public Vector4I7F25 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, W, Y, W); }
        public Vector4I7F25 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, W, Z, X); }
        public Vector4I7F25 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, W, Z, Y); }
        public Vector4I7F25 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, W, Z, Z); }
        public Vector4I7F25 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, W, Z, W); }
        public Vector4I7F25 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, W, W, X); }
        public Vector4I7F25 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, W, W, Y); }
        public Vector4I7F25 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, W, W, Z); }
        public Vector4I7F25 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(Z, W, W, W); }
        public Vector4I7F25 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, X, X, X); }
        public Vector4I7F25 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, X, X, Y); }
        public Vector4I7F25 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, X, X, Z); }
        public Vector4I7F25 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, X, X, W); }
        public Vector4I7F25 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, X, Y, X); }
        public Vector4I7F25 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, X, Y, Y); }
        public Vector4I7F25 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, X, Y, Z); }
        public Vector4I7F25 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, X, Y, W); }
        public Vector4I7F25 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, X, Z, X); }
        public Vector4I7F25 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, X, Z, Y); }
        public Vector4I7F25 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, X, Z, Z); }
        public Vector4I7F25 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, X, Z, W); }
        public Vector4I7F25 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, X, W, X); }
        public Vector4I7F25 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, X, W, Y); }
        public Vector4I7F25 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, X, W, Z); }
        public Vector4I7F25 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, X, W, W); }
        public Vector4I7F25 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Y, X, X); }
        public Vector4I7F25 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Y, X, Y); }
        public Vector4I7F25 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Y, X, Z); }
        public Vector4I7F25 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Y, X, W); }
        public Vector4I7F25 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Y, Y, X); }
        public Vector4I7F25 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Y, Y, Y); }
        public Vector4I7F25 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Y, Y, Z); }
        public Vector4I7F25 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Y, Y, W); }
        public Vector4I7F25 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Y, Z, X); }
        public Vector4I7F25 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Y, Z, Y); }
        public Vector4I7F25 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Y, Z, Z); }
        public Vector4I7F25 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Y, Z, W); }
        public Vector4I7F25 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Y, W, X); }
        public Vector4I7F25 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Y, W, Y); }
        public Vector4I7F25 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Y, W, Z); }
        public Vector4I7F25 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Y, W, W); }
        public Vector4I7F25 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Z, X, X); }
        public Vector4I7F25 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Z, X, Y); }
        public Vector4I7F25 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Z, X, Z); }
        public Vector4I7F25 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Z, X, W); }
        public Vector4I7F25 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Z, Y, X); }
        public Vector4I7F25 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Z, Y, Y); }
        public Vector4I7F25 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Z, Y, Z); }
        public Vector4I7F25 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Z, Y, W); }
        public Vector4I7F25 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Z, Z, X); }
        public Vector4I7F25 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Z, Z, Y); }
        public Vector4I7F25 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Z, Z, Z); }
        public Vector4I7F25 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Z, Z, W); }
        public Vector4I7F25 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Z, W, X); }
        public Vector4I7F25 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Z, W, Y); }
        public Vector4I7F25 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Z, W, Z); }
        public Vector4I7F25 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, Z, W, W); }
        public Vector4I7F25 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, W, X, X); }
        public Vector4I7F25 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, W, X, Y); }
        public Vector4I7F25 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, W, X, Z); }
        public Vector4I7F25 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, W, X, W); }
        public Vector4I7F25 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, W, Y, X); }
        public Vector4I7F25 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, W, Y, Y); }
        public Vector4I7F25 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, W, Y, Z); }
        public Vector4I7F25 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, W, Y, W); }
        public Vector4I7F25 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, W, Z, X); }
        public Vector4I7F25 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, W, Z, Y); }
        public Vector4I7F25 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, W, Z, Z); }
        public Vector4I7F25 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, W, Z, W); }
        public Vector4I7F25 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, W, W, X); }
        public Vector4I7F25 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, W, W, Y); }
        public Vector4I7F25 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, W, W, Z); }
        public Vector4I7F25 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I7F25(W, W, W, W); }

    }

    partial struct I7F25 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I7F25 SaturatingMul(Vector4I7F25 other) => other.SaturatingMul(this);
    }
}
