using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U4F28
    : IEquatable<Vector4U4F28>
    , IFormattable
    , IVector<U10F54, I10F54, U5F27, I5F27>
    , IVectorComponentRespective<U4F28> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U4F28 X;
        public U4F28 Y;
        public U4F28 Z;
        public U4F28 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(U4F28 x, U4F28 y, U4F28 z, U4F28 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(U4F28 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(U4F28 x, U4F28 y, Vector2U4F28 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(U4F28 x, Vector3U4F28 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(Vector2U4F28 xy, Vector2U4F28 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(Vector4U4F28 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(U4F28 x, Vector2U4F28 yz, U4F28 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(Vector3U4F28 xyz, U4F28 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28(Vector2U4F28 xy, U4F28 z, U4F28 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U4F28 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U4F28(U4F28.Zero);
        }
        public static Vector4U4F28 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U4F28(U4F28.One);
        }
        public static Vector4U4F28 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U4F28(U4F28.One, U4F28.Zero, U4F28.Zero, U4F28.Zero);
        }
        public static Vector4U4F28 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U4F28(U4F28.Zero, U4F28.One, U4F28.Zero, U4F28.Zero);
        }
        public static Vector4U4F28 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U4F28(U4F28.Zero, U4F28.Zero, U4F28.One, U4F28.Zero);
        }
        public static Vector4U4F28 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U4F28(U4F28.Zero, U4F28.Zero, U4F28.Zero, U4F28.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 operator +(Vector4U4F28 a, Vector4U4F28 b) => new Vector4U4F28(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 operator -(Vector4U4F28 a, Vector4U4F28 b) => new Vector4U4F28(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 operator *(Vector4U4F28 a, Vector4U4F28 b) => new Vector4U4F28(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 operator *(Vector4U4F28 a, U4F28 b) => new Vector4U4F28(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 operator *(U4F28 a, Vector4U4F28 b) => new Vector4U4F28(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 operator /(Vector4U4F28 a, Vector4U4F28 b) => new Vector4U4F28(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 operator /(Vector4U4F28 a, U4F28 b) => new Vector4U4F28(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U4F28 operator /(U4F28 a, Vector4U4F28 b) => new Vector4U4F28(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U4F28 lhs, Vector4U4F28 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U4F28 lhs, Vector4U4F28 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U4F28 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U4F28 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U4F28>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U4F28 other)
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
        public Vector4U4F28 Min(Vector4U4F28 other) => new Vector4U4F28(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28 Max(Vector4U4F28 other) => new Vector4U4F28(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28 Half() => new Vector4U4F28(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28 Twice() => new Vector4U4F28(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28 Clamp(U4F28 min, U4F28 max) => new Vector4U4F28(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28 Clamp(
            Vector4U4F28 min, Vector4U4F28 max
        ) => new Vector4U4F28(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28 WrappingAdd(Vector4U4F28 other) => new Vector4U4F28(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28 WrappingSub(Vector4U4F28 other) => new Vector4U4F28(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28 WrappingMul(Vector4U4F28 other) => new Vector4U4F28(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28 WrappingAddSigned(Vector4I4F28 other) => new Vector4U4F28(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28 SaturatingAdd(Vector4U4F28 other) => new Vector4U4F28(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28 SaturatingMul(U4F28 other) => new Vector4U4F28(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U4F28 other) {
            var x = ((ulong)X.Bits) * other.X.Bits;
            var y = ((ulong)Y.Bits) * other.Y.Bits;
            var z = ((ulong)Z.Bits) * other.Z.Bits;
            var w = ((ulong)W.Bits) * other.W.Bits;

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
        public U4F28 Dot(Vector4U4F28 other) {
            const ulong k = 1UL << 26;
            return U4F28.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F28 SaturatingDot(Vector4U4F28 other) {
            const ulong k = 1UL << 26;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U4F28.MaxValue;
            } else {
                return U4F28.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U10F54 LengthSquaredUnsigned() => U10F54.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I10F54 LengthSquaredSigned() => I10F54.FromBits(
            (long)LengthSquaredInternal()
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
        public U10F54 LengthSquared() => LengthSquaredUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint LengthInternal() {
            return (uint)Mathi.Sqrt(LengthSquaredInternal());
        }

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <see cref="LengthHalfSigned">LengthHalfSigned</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="LengthHalfSigned">LengthHalfSigned</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfSigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F28 LengthHalf() => U4F28.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="LengthHalf">LengthHalf</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthHalf">LengthHalf</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F28 LengthHalfSigned() => I4F28.FromBits(checked((int)LengthInternal()));

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
        /// <seealso cref="LengthHalf"/>
        /// <seealso cref="LengthSigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U5F27 LengthUnsigned() => U5F27.FromBits(LengthInternal());

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
        /// <seealso cref="LengthHalfSigned"/>
        /// <seealso cref="LengthUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I5F27 LengthSigned() => I5F27.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U5F27 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U4F28? Normalize() {
            var a0 = X.Bits;
            var a1 = Y.Bits;
            var a2 = Z.Bits;
            var a3 = W.Bits;

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

            const ulong k = 1UL << 27;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U4F28(
                U4F28.FromBits(y0),
                U4F28.FromBits(y1),
                U4F28.FromBits(y2),
                U4F28.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U4F28 XX() => new Vector2U4F28(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U4F28 XY() => new Vector2U4F28(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U4F28 XZ() => new Vector2U4F28(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U4F28 XW() => new Vector2U4F28(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U4F28 YX() => new Vector2U4F28(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U4F28 YY() => new Vector2U4F28(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U4F28 YZ() => new Vector2U4F28(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U4F28 YW() => new Vector2U4F28(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U4F28 ZX() => new Vector2U4F28(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U4F28 ZY() => new Vector2U4F28(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U4F28 ZZ() => new Vector2U4F28(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U4F28 ZW() => new Vector2U4F28(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U4F28 WX() => new Vector2U4F28(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U4F28 WY() => new Vector2U4F28(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U4F28 WZ() => new Vector2U4F28(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U4F28 WW() => new Vector2U4F28(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 XXX() => new Vector3U4F28(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 XXY() => new Vector3U4F28(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 XXZ() => new Vector3U4F28(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 XXW() => new Vector3U4F28(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 XYX() => new Vector3U4F28(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 XYY() => new Vector3U4F28(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 XYZ() => new Vector3U4F28(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 XYW() => new Vector3U4F28(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 XZX() => new Vector3U4F28(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 XZY() => new Vector3U4F28(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 XZZ() => new Vector3U4F28(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 XZW() => new Vector3U4F28(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 XWX() => new Vector3U4F28(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 XWY() => new Vector3U4F28(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 XWZ() => new Vector3U4F28(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 XWW() => new Vector3U4F28(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 YXX() => new Vector3U4F28(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 YXY() => new Vector3U4F28(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 YXZ() => new Vector3U4F28(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 YXW() => new Vector3U4F28(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 YYX() => new Vector3U4F28(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 YYY() => new Vector3U4F28(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 YYZ() => new Vector3U4F28(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 YYW() => new Vector3U4F28(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 YZX() => new Vector3U4F28(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 YZY() => new Vector3U4F28(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 YZZ() => new Vector3U4F28(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 YZW() => new Vector3U4F28(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 YWX() => new Vector3U4F28(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 YWY() => new Vector3U4F28(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 YWZ() => new Vector3U4F28(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 YWW() => new Vector3U4F28(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 ZXX() => new Vector3U4F28(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 ZXY() => new Vector3U4F28(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 ZXZ() => new Vector3U4F28(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 ZXW() => new Vector3U4F28(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 ZYX() => new Vector3U4F28(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 ZYY() => new Vector3U4F28(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 ZYZ() => new Vector3U4F28(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 ZYW() => new Vector3U4F28(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 ZZX() => new Vector3U4F28(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 ZZY() => new Vector3U4F28(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 ZZZ() => new Vector3U4F28(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 ZZW() => new Vector3U4F28(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 ZWX() => new Vector3U4F28(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 ZWY() => new Vector3U4F28(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 ZWZ() => new Vector3U4F28(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 ZWW() => new Vector3U4F28(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 WXX() => new Vector3U4F28(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 WXY() => new Vector3U4F28(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 WXZ() => new Vector3U4F28(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 WXW() => new Vector3U4F28(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 WYX() => new Vector3U4F28(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 WYY() => new Vector3U4F28(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 WYZ() => new Vector3U4F28(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 WYW() => new Vector3U4F28(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 WZX() => new Vector3U4F28(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 WZY() => new Vector3U4F28(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 WZZ() => new Vector3U4F28(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 WZW() => new Vector3U4F28(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 WWX() => new Vector3U4F28(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 WWY() => new Vector3U4F28(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 WWZ() => new Vector3U4F28(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U4F28 WWW() => new Vector3U4F28(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XXXX() => new Vector4U4F28(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XXXY() => new Vector4U4F28(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XXXZ() => new Vector4U4F28(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XXXW() => new Vector4U4F28(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XXYX() => new Vector4U4F28(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XXYY() => new Vector4U4F28(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XXYZ() => new Vector4U4F28(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XXYW() => new Vector4U4F28(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XXZX() => new Vector4U4F28(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XXZY() => new Vector4U4F28(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XXZZ() => new Vector4U4F28(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XXZW() => new Vector4U4F28(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XXWX() => new Vector4U4F28(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XXWY() => new Vector4U4F28(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XXWZ() => new Vector4U4F28(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XXWW() => new Vector4U4F28(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XYXX() => new Vector4U4F28(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XYXY() => new Vector4U4F28(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XYXZ() => new Vector4U4F28(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XYXW() => new Vector4U4F28(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XYYX() => new Vector4U4F28(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XYYY() => new Vector4U4F28(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XYYZ() => new Vector4U4F28(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XYYW() => new Vector4U4F28(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XYZX() => new Vector4U4F28(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XYZY() => new Vector4U4F28(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XYZZ() => new Vector4U4F28(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XYZW() => new Vector4U4F28(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XYWX() => new Vector4U4F28(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XYWY() => new Vector4U4F28(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XYWZ() => new Vector4U4F28(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XYWW() => new Vector4U4F28(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XZXX() => new Vector4U4F28(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XZXY() => new Vector4U4F28(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XZXZ() => new Vector4U4F28(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XZXW() => new Vector4U4F28(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XZYX() => new Vector4U4F28(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XZYY() => new Vector4U4F28(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XZYZ() => new Vector4U4F28(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XZYW() => new Vector4U4F28(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XZZX() => new Vector4U4F28(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XZZY() => new Vector4U4F28(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XZZZ() => new Vector4U4F28(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XZZW() => new Vector4U4F28(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XZWX() => new Vector4U4F28(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XZWY() => new Vector4U4F28(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XZWZ() => new Vector4U4F28(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XZWW() => new Vector4U4F28(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XWXX() => new Vector4U4F28(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XWXY() => new Vector4U4F28(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XWXZ() => new Vector4U4F28(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XWXW() => new Vector4U4F28(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XWYX() => new Vector4U4F28(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XWYY() => new Vector4U4F28(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XWYZ() => new Vector4U4F28(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XWYW() => new Vector4U4F28(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XWZX() => new Vector4U4F28(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XWZY() => new Vector4U4F28(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XWZZ() => new Vector4U4F28(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XWZW() => new Vector4U4F28(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XWWX() => new Vector4U4F28(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XWWY() => new Vector4U4F28(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XWWZ() => new Vector4U4F28(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 XWWW() => new Vector4U4F28(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YXXX() => new Vector4U4F28(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YXXY() => new Vector4U4F28(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YXXZ() => new Vector4U4F28(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YXXW() => new Vector4U4F28(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YXYX() => new Vector4U4F28(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YXYY() => new Vector4U4F28(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YXYZ() => new Vector4U4F28(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YXYW() => new Vector4U4F28(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YXZX() => new Vector4U4F28(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YXZY() => new Vector4U4F28(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YXZZ() => new Vector4U4F28(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YXZW() => new Vector4U4F28(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YXWX() => new Vector4U4F28(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YXWY() => new Vector4U4F28(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YXWZ() => new Vector4U4F28(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YXWW() => new Vector4U4F28(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YYXX() => new Vector4U4F28(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YYXY() => new Vector4U4F28(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YYXZ() => new Vector4U4F28(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YYXW() => new Vector4U4F28(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YYYX() => new Vector4U4F28(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YYYY() => new Vector4U4F28(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YYYZ() => new Vector4U4F28(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YYYW() => new Vector4U4F28(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YYZX() => new Vector4U4F28(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YYZY() => new Vector4U4F28(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YYZZ() => new Vector4U4F28(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YYZW() => new Vector4U4F28(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YYWX() => new Vector4U4F28(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YYWY() => new Vector4U4F28(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YYWZ() => new Vector4U4F28(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YYWW() => new Vector4U4F28(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YZXX() => new Vector4U4F28(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YZXY() => new Vector4U4F28(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YZXZ() => new Vector4U4F28(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YZXW() => new Vector4U4F28(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YZYX() => new Vector4U4F28(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YZYY() => new Vector4U4F28(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YZYZ() => new Vector4U4F28(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YZYW() => new Vector4U4F28(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YZZX() => new Vector4U4F28(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YZZY() => new Vector4U4F28(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YZZZ() => new Vector4U4F28(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YZZW() => new Vector4U4F28(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YZWX() => new Vector4U4F28(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YZWY() => new Vector4U4F28(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YZWZ() => new Vector4U4F28(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YZWW() => new Vector4U4F28(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YWXX() => new Vector4U4F28(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YWXY() => new Vector4U4F28(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YWXZ() => new Vector4U4F28(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YWXW() => new Vector4U4F28(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YWYX() => new Vector4U4F28(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YWYY() => new Vector4U4F28(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YWYZ() => new Vector4U4F28(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YWYW() => new Vector4U4F28(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YWZX() => new Vector4U4F28(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YWZY() => new Vector4U4F28(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YWZZ() => new Vector4U4F28(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YWZW() => new Vector4U4F28(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YWWX() => new Vector4U4F28(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YWWY() => new Vector4U4F28(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YWWZ() => new Vector4U4F28(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 YWWW() => new Vector4U4F28(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZXXX() => new Vector4U4F28(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZXXY() => new Vector4U4F28(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZXXZ() => new Vector4U4F28(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZXXW() => new Vector4U4F28(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZXYX() => new Vector4U4F28(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZXYY() => new Vector4U4F28(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZXYZ() => new Vector4U4F28(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZXYW() => new Vector4U4F28(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZXZX() => new Vector4U4F28(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZXZY() => new Vector4U4F28(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZXZZ() => new Vector4U4F28(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZXZW() => new Vector4U4F28(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZXWX() => new Vector4U4F28(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZXWY() => new Vector4U4F28(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZXWZ() => new Vector4U4F28(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZXWW() => new Vector4U4F28(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZYXX() => new Vector4U4F28(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZYXY() => new Vector4U4F28(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZYXZ() => new Vector4U4F28(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZYXW() => new Vector4U4F28(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZYYX() => new Vector4U4F28(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZYYY() => new Vector4U4F28(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZYYZ() => new Vector4U4F28(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZYYW() => new Vector4U4F28(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZYZX() => new Vector4U4F28(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZYZY() => new Vector4U4F28(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZYZZ() => new Vector4U4F28(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZYZW() => new Vector4U4F28(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZYWX() => new Vector4U4F28(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZYWY() => new Vector4U4F28(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZYWZ() => new Vector4U4F28(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZYWW() => new Vector4U4F28(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZZXX() => new Vector4U4F28(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZZXY() => new Vector4U4F28(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZZXZ() => new Vector4U4F28(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZZXW() => new Vector4U4F28(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZZYX() => new Vector4U4F28(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZZYY() => new Vector4U4F28(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZZYZ() => new Vector4U4F28(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZZYW() => new Vector4U4F28(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZZZX() => new Vector4U4F28(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZZZY() => new Vector4U4F28(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZZZZ() => new Vector4U4F28(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZZZW() => new Vector4U4F28(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZZWX() => new Vector4U4F28(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZZWY() => new Vector4U4F28(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZZWZ() => new Vector4U4F28(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZZWW() => new Vector4U4F28(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZWXX() => new Vector4U4F28(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZWXY() => new Vector4U4F28(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZWXZ() => new Vector4U4F28(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZWXW() => new Vector4U4F28(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZWYX() => new Vector4U4F28(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZWYY() => new Vector4U4F28(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZWYZ() => new Vector4U4F28(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZWYW() => new Vector4U4F28(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZWZX() => new Vector4U4F28(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZWZY() => new Vector4U4F28(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZWZZ() => new Vector4U4F28(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZWZW() => new Vector4U4F28(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZWWX() => new Vector4U4F28(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZWWY() => new Vector4U4F28(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZWWZ() => new Vector4U4F28(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 ZWWW() => new Vector4U4F28(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WXXX() => new Vector4U4F28(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WXXY() => new Vector4U4F28(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WXXZ() => new Vector4U4F28(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WXXW() => new Vector4U4F28(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WXYX() => new Vector4U4F28(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WXYY() => new Vector4U4F28(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WXYZ() => new Vector4U4F28(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WXYW() => new Vector4U4F28(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WXZX() => new Vector4U4F28(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WXZY() => new Vector4U4F28(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WXZZ() => new Vector4U4F28(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WXZW() => new Vector4U4F28(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WXWX() => new Vector4U4F28(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WXWY() => new Vector4U4F28(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WXWZ() => new Vector4U4F28(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WXWW() => new Vector4U4F28(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WYXX() => new Vector4U4F28(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WYXY() => new Vector4U4F28(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WYXZ() => new Vector4U4F28(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WYXW() => new Vector4U4F28(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WYYX() => new Vector4U4F28(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WYYY() => new Vector4U4F28(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WYYZ() => new Vector4U4F28(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WYYW() => new Vector4U4F28(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WYZX() => new Vector4U4F28(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WYZY() => new Vector4U4F28(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WYZZ() => new Vector4U4F28(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WYZW() => new Vector4U4F28(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WYWX() => new Vector4U4F28(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WYWY() => new Vector4U4F28(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WYWZ() => new Vector4U4F28(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WYWW() => new Vector4U4F28(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WZXX() => new Vector4U4F28(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WZXY() => new Vector4U4F28(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WZXZ() => new Vector4U4F28(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WZXW() => new Vector4U4F28(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WZYX() => new Vector4U4F28(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WZYY() => new Vector4U4F28(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WZYZ() => new Vector4U4F28(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WZYW() => new Vector4U4F28(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WZZX() => new Vector4U4F28(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WZZY() => new Vector4U4F28(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WZZZ() => new Vector4U4F28(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WZZW() => new Vector4U4F28(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WZWX() => new Vector4U4F28(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WZWY() => new Vector4U4F28(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WZWZ() => new Vector4U4F28(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WZWW() => new Vector4U4F28(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WWXX() => new Vector4U4F28(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WWXY() => new Vector4U4F28(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WWXZ() => new Vector4U4F28(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WWXW() => new Vector4U4F28(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WWYX() => new Vector4U4F28(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WWYY() => new Vector4U4F28(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WWYZ() => new Vector4U4F28(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WWYW() => new Vector4U4F28(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WWZX() => new Vector4U4F28(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WWZY() => new Vector4U4F28(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WWZZ() => new Vector4U4F28(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WWZW() => new Vector4U4F28(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WWWX() => new Vector4U4F28(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WWWY() => new Vector4U4F28(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WWWZ() => new Vector4U4F28(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U4F28 WWWW() => new Vector4U4F28(W, W, W, W);

    }
}
