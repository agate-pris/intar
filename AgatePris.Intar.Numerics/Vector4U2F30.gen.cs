using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U2F30
    : IEquatable<Vector4U2F30>
    , IFormattable
    , IVector<U6F58, I6F58, U3F29, I3F29>
    , IVectorComponentRespective<U2F30> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U2F30 X;
        public U2F30 Y;
        public U2F30 Z;
        public U2F30 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(U2F30 x, U2F30 y, U2F30 z, U2F30 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(U2F30 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(U2F30 x, U2F30 y, Vector2U2F30 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(U2F30 x, Vector3U2F30 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(Vector2U2F30 xy, Vector2U2F30 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(Vector4U2F30 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(U2F30 x, Vector2U2F30 yz, U2F30 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(Vector3U2F30 xyz, U2F30 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(Vector2U2F30 xy, U2F30 z, U2F30 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U2F30 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U2F30(U2F30.Zero);
        }
        public static Vector4U2F30 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U2F30(U2F30.One);
        }
        public static Vector4U2F30 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U2F30(U2F30.One, U2F30.Zero, U2F30.Zero, U2F30.Zero);
        }
        public static Vector4U2F30 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U2F30(U2F30.Zero, U2F30.One, U2F30.Zero, U2F30.Zero);
        }
        public static Vector4U2F30 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U2F30(U2F30.Zero, U2F30.Zero, U2F30.One, U2F30.Zero);
        }
        public static Vector4U2F30 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U2F30(U2F30.Zero, U2F30.Zero, U2F30.Zero, U2F30.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator +(Vector4U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator -(Vector4U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator *(Vector4U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator *(Vector4U2F30 a, U2F30 b) => new Vector4U2F30(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator *(U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator /(Vector4U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator /(Vector4U2F30 a, U2F30 b) => new Vector4U2F30(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator /(U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U2F30 lhs, Vector4U2F30 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U2F30 lhs, Vector4U2F30 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U2F30 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U2F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U2F30 other)
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
        public Vector4U2F30 Min(Vector4U2F30 other) => new Vector4U2F30(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 Max(Vector4U2F30 other) => new Vector4U2F30(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 Half() => new Vector4U2F30(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 Twice() => new Vector4U2F30(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 Clamp(U2F30 min, U2F30 max) => new Vector4U2F30(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 Clamp(
            Vector4U2F30 min, Vector4U2F30 max
        ) => new Vector4U2F30(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 WrappingAdd(Vector4U2F30 other) => new Vector4U2F30(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 WrappingSub(Vector4U2F30 other) => new Vector4U2F30(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 WrappingMul(Vector4U2F30 other) => new Vector4U2F30(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 WrappingAddSigned(Vector4I2F30 other) => new Vector4U2F30(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 SaturatingAdd(Vector4U2F30 other) => new Vector4U2F30(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 SaturatingMul(U2F30 other) => new Vector4U2F30(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U2F30 other) {
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
        public U2F30 Dot(Vector4U2F30 other) {
            const ulong k = 1UL << 28;
            return U2F30.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 SaturatingDot(Vector4U2F30 other) {
            const ulong k = 1UL << 28;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U2F30.MaxValue;
            } else {
                return U2F30.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U6F58 LengthSquaredUnsigned() => U6F58.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I6F58 LengthSquaredSigned() => I6F58.FromBits(
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
        public U6F58 LengthSquared() => LengthSquaredUnsigned();

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
        public U2F30 LengthHalf() => U2F30.FromBits(LengthInternal());

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
        public I2F30 LengthHalfSigned() => I2F30.FromBits(checked((int)LengthInternal()));

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
        public U3F29 LengthUnsigned() => U3F29.FromBits(LengthInternal());

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
        public I3F29 LengthSigned() => I3F29.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U3F29 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30? Normalize() {
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

            const ulong k = 1UL << 29;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U2F30(
                U2F30.FromBits(y0),
                U2F30.FromBits(y1),
                U2F30.FromBits(y2),
                U2F30.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 XX() => new Vector2U2F30(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 XY() => new Vector2U2F30(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 XZ() => new Vector2U2F30(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 XW() => new Vector2U2F30(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 YX() => new Vector2U2F30(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 YY() => new Vector2U2F30(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 YZ() => new Vector2U2F30(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 YW() => new Vector2U2F30(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 ZX() => new Vector2U2F30(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 ZY() => new Vector2U2F30(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 ZZ() => new Vector2U2F30(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 ZW() => new Vector2U2F30(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 WX() => new Vector2U2F30(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 WY() => new Vector2U2F30(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 WZ() => new Vector2U2F30(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U2F30 WW() => new Vector2U2F30(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 XXX() => new Vector3U2F30(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 XXY() => new Vector3U2F30(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 XXZ() => new Vector3U2F30(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 XXW() => new Vector3U2F30(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 XYX() => new Vector3U2F30(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 XYY() => new Vector3U2F30(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 XYZ() => new Vector3U2F30(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 XYW() => new Vector3U2F30(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 XZX() => new Vector3U2F30(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 XZY() => new Vector3U2F30(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 XZZ() => new Vector3U2F30(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 XZW() => new Vector3U2F30(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 XWX() => new Vector3U2F30(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 XWY() => new Vector3U2F30(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 XWZ() => new Vector3U2F30(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 XWW() => new Vector3U2F30(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 YXX() => new Vector3U2F30(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 YXY() => new Vector3U2F30(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 YXZ() => new Vector3U2F30(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 YXW() => new Vector3U2F30(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 YYX() => new Vector3U2F30(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 YYY() => new Vector3U2F30(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 YYZ() => new Vector3U2F30(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 YYW() => new Vector3U2F30(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 YZX() => new Vector3U2F30(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 YZY() => new Vector3U2F30(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 YZZ() => new Vector3U2F30(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 YZW() => new Vector3U2F30(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 YWX() => new Vector3U2F30(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 YWY() => new Vector3U2F30(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 YWZ() => new Vector3U2F30(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 YWW() => new Vector3U2F30(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 ZXX() => new Vector3U2F30(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 ZXY() => new Vector3U2F30(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 ZXZ() => new Vector3U2F30(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 ZXW() => new Vector3U2F30(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 ZYX() => new Vector3U2F30(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 ZYY() => new Vector3U2F30(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 ZYZ() => new Vector3U2F30(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 ZYW() => new Vector3U2F30(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 ZZX() => new Vector3U2F30(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 ZZY() => new Vector3U2F30(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 ZZZ() => new Vector3U2F30(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 ZZW() => new Vector3U2F30(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 ZWX() => new Vector3U2F30(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 ZWY() => new Vector3U2F30(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 ZWZ() => new Vector3U2F30(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 ZWW() => new Vector3U2F30(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 WXX() => new Vector3U2F30(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 WXY() => new Vector3U2F30(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 WXZ() => new Vector3U2F30(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 WXW() => new Vector3U2F30(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 WYX() => new Vector3U2F30(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 WYY() => new Vector3U2F30(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 WYZ() => new Vector3U2F30(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 WYW() => new Vector3U2F30(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 WZX() => new Vector3U2F30(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 WZY() => new Vector3U2F30(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 WZZ() => new Vector3U2F30(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 WZW() => new Vector3U2F30(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 WWX() => new Vector3U2F30(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 WWY() => new Vector3U2F30(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 WWZ() => new Vector3U2F30(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U2F30 WWW() => new Vector3U2F30(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XXXX() => new Vector4U2F30(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XXXY() => new Vector4U2F30(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XXXZ() => new Vector4U2F30(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XXXW() => new Vector4U2F30(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XXYX() => new Vector4U2F30(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XXYY() => new Vector4U2F30(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XXYZ() => new Vector4U2F30(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XXYW() => new Vector4U2F30(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XXZX() => new Vector4U2F30(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XXZY() => new Vector4U2F30(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XXZZ() => new Vector4U2F30(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XXZW() => new Vector4U2F30(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XXWX() => new Vector4U2F30(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XXWY() => new Vector4U2F30(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XXWZ() => new Vector4U2F30(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XXWW() => new Vector4U2F30(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XYXX() => new Vector4U2F30(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XYXY() => new Vector4U2F30(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XYXZ() => new Vector4U2F30(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XYXW() => new Vector4U2F30(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XYYX() => new Vector4U2F30(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XYYY() => new Vector4U2F30(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XYYZ() => new Vector4U2F30(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XYYW() => new Vector4U2F30(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XYZX() => new Vector4U2F30(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XYZY() => new Vector4U2F30(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XYZZ() => new Vector4U2F30(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XYZW() => new Vector4U2F30(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XYWX() => new Vector4U2F30(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XYWY() => new Vector4U2F30(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XYWZ() => new Vector4U2F30(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XYWW() => new Vector4U2F30(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XZXX() => new Vector4U2F30(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XZXY() => new Vector4U2F30(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XZXZ() => new Vector4U2F30(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XZXW() => new Vector4U2F30(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XZYX() => new Vector4U2F30(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XZYY() => new Vector4U2F30(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XZYZ() => new Vector4U2F30(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XZYW() => new Vector4U2F30(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XZZX() => new Vector4U2F30(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XZZY() => new Vector4U2F30(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XZZZ() => new Vector4U2F30(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XZZW() => new Vector4U2F30(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XZWX() => new Vector4U2F30(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XZWY() => new Vector4U2F30(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XZWZ() => new Vector4U2F30(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XZWW() => new Vector4U2F30(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XWXX() => new Vector4U2F30(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XWXY() => new Vector4U2F30(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XWXZ() => new Vector4U2F30(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XWXW() => new Vector4U2F30(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XWYX() => new Vector4U2F30(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XWYY() => new Vector4U2F30(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XWYZ() => new Vector4U2F30(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XWYW() => new Vector4U2F30(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XWZX() => new Vector4U2F30(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XWZY() => new Vector4U2F30(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XWZZ() => new Vector4U2F30(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XWZW() => new Vector4U2F30(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XWWX() => new Vector4U2F30(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XWWY() => new Vector4U2F30(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XWWZ() => new Vector4U2F30(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 XWWW() => new Vector4U2F30(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YXXX() => new Vector4U2F30(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YXXY() => new Vector4U2F30(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YXXZ() => new Vector4U2F30(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YXXW() => new Vector4U2F30(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YXYX() => new Vector4U2F30(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YXYY() => new Vector4U2F30(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YXYZ() => new Vector4U2F30(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YXYW() => new Vector4U2F30(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YXZX() => new Vector4U2F30(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YXZY() => new Vector4U2F30(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YXZZ() => new Vector4U2F30(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YXZW() => new Vector4U2F30(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YXWX() => new Vector4U2F30(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YXWY() => new Vector4U2F30(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YXWZ() => new Vector4U2F30(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YXWW() => new Vector4U2F30(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YYXX() => new Vector4U2F30(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YYXY() => new Vector4U2F30(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YYXZ() => new Vector4U2F30(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YYXW() => new Vector4U2F30(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YYYX() => new Vector4U2F30(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YYYY() => new Vector4U2F30(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YYYZ() => new Vector4U2F30(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YYYW() => new Vector4U2F30(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YYZX() => new Vector4U2F30(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YYZY() => new Vector4U2F30(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YYZZ() => new Vector4U2F30(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YYZW() => new Vector4U2F30(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YYWX() => new Vector4U2F30(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YYWY() => new Vector4U2F30(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YYWZ() => new Vector4U2F30(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YYWW() => new Vector4U2F30(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YZXX() => new Vector4U2F30(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YZXY() => new Vector4U2F30(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YZXZ() => new Vector4U2F30(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YZXW() => new Vector4U2F30(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YZYX() => new Vector4U2F30(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YZYY() => new Vector4U2F30(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YZYZ() => new Vector4U2F30(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YZYW() => new Vector4U2F30(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YZZX() => new Vector4U2F30(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YZZY() => new Vector4U2F30(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YZZZ() => new Vector4U2F30(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YZZW() => new Vector4U2F30(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YZWX() => new Vector4U2F30(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YZWY() => new Vector4U2F30(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YZWZ() => new Vector4U2F30(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YZWW() => new Vector4U2F30(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YWXX() => new Vector4U2F30(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YWXY() => new Vector4U2F30(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YWXZ() => new Vector4U2F30(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YWXW() => new Vector4U2F30(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YWYX() => new Vector4U2F30(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YWYY() => new Vector4U2F30(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YWYZ() => new Vector4U2F30(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YWYW() => new Vector4U2F30(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YWZX() => new Vector4U2F30(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YWZY() => new Vector4U2F30(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YWZZ() => new Vector4U2F30(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YWZW() => new Vector4U2F30(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YWWX() => new Vector4U2F30(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YWWY() => new Vector4U2F30(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YWWZ() => new Vector4U2F30(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 YWWW() => new Vector4U2F30(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZXXX() => new Vector4U2F30(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZXXY() => new Vector4U2F30(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZXXZ() => new Vector4U2F30(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZXXW() => new Vector4U2F30(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZXYX() => new Vector4U2F30(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZXYY() => new Vector4U2F30(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZXYZ() => new Vector4U2F30(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZXYW() => new Vector4U2F30(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZXZX() => new Vector4U2F30(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZXZY() => new Vector4U2F30(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZXZZ() => new Vector4U2F30(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZXZW() => new Vector4U2F30(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZXWX() => new Vector4U2F30(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZXWY() => new Vector4U2F30(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZXWZ() => new Vector4U2F30(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZXWW() => new Vector4U2F30(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZYXX() => new Vector4U2F30(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZYXY() => new Vector4U2F30(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZYXZ() => new Vector4U2F30(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZYXW() => new Vector4U2F30(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZYYX() => new Vector4U2F30(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZYYY() => new Vector4U2F30(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZYYZ() => new Vector4U2F30(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZYYW() => new Vector4U2F30(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZYZX() => new Vector4U2F30(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZYZY() => new Vector4U2F30(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZYZZ() => new Vector4U2F30(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZYZW() => new Vector4U2F30(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZYWX() => new Vector4U2F30(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZYWY() => new Vector4U2F30(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZYWZ() => new Vector4U2F30(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZYWW() => new Vector4U2F30(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZZXX() => new Vector4U2F30(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZZXY() => new Vector4U2F30(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZZXZ() => new Vector4U2F30(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZZXW() => new Vector4U2F30(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZZYX() => new Vector4U2F30(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZZYY() => new Vector4U2F30(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZZYZ() => new Vector4U2F30(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZZYW() => new Vector4U2F30(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZZZX() => new Vector4U2F30(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZZZY() => new Vector4U2F30(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZZZZ() => new Vector4U2F30(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZZZW() => new Vector4U2F30(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZZWX() => new Vector4U2F30(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZZWY() => new Vector4U2F30(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZZWZ() => new Vector4U2F30(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZZWW() => new Vector4U2F30(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZWXX() => new Vector4U2F30(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZWXY() => new Vector4U2F30(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZWXZ() => new Vector4U2F30(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZWXW() => new Vector4U2F30(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZWYX() => new Vector4U2F30(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZWYY() => new Vector4U2F30(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZWYZ() => new Vector4U2F30(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZWYW() => new Vector4U2F30(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZWZX() => new Vector4U2F30(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZWZY() => new Vector4U2F30(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZWZZ() => new Vector4U2F30(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZWZW() => new Vector4U2F30(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZWWX() => new Vector4U2F30(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZWWY() => new Vector4U2F30(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZWWZ() => new Vector4U2F30(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 ZWWW() => new Vector4U2F30(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WXXX() => new Vector4U2F30(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WXXY() => new Vector4U2F30(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WXXZ() => new Vector4U2F30(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WXXW() => new Vector4U2F30(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WXYX() => new Vector4U2F30(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WXYY() => new Vector4U2F30(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WXYZ() => new Vector4U2F30(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WXYW() => new Vector4U2F30(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WXZX() => new Vector4U2F30(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WXZY() => new Vector4U2F30(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WXZZ() => new Vector4U2F30(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WXZW() => new Vector4U2F30(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WXWX() => new Vector4U2F30(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WXWY() => new Vector4U2F30(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WXWZ() => new Vector4U2F30(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WXWW() => new Vector4U2F30(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WYXX() => new Vector4U2F30(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WYXY() => new Vector4U2F30(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WYXZ() => new Vector4U2F30(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WYXW() => new Vector4U2F30(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WYYX() => new Vector4U2F30(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WYYY() => new Vector4U2F30(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WYYZ() => new Vector4U2F30(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WYYW() => new Vector4U2F30(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WYZX() => new Vector4U2F30(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WYZY() => new Vector4U2F30(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WYZZ() => new Vector4U2F30(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WYZW() => new Vector4U2F30(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WYWX() => new Vector4U2F30(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WYWY() => new Vector4U2F30(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WYWZ() => new Vector4U2F30(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WYWW() => new Vector4U2F30(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WZXX() => new Vector4U2F30(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WZXY() => new Vector4U2F30(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WZXZ() => new Vector4U2F30(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WZXW() => new Vector4U2F30(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WZYX() => new Vector4U2F30(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WZYY() => new Vector4U2F30(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WZYZ() => new Vector4U2F30(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WZYW() => new Vector4U2F30(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WZZX() => new Vector4U2F30(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WZZY() => new Vector4U2F30(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WZZZ() => new Vector4U2F30(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WZZW() => new Vector4U2F30(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WZWX() => new Vector4U2F30(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WZWY() => new Vector4U2F30(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WZWZ() => new Vector4U2F30(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WZWW() => new Vector4U2F30(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WWXX() => new Vector4U2F30(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WWXY() => new Vector4U2F30(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WWXZ() => new Vector4U2F30(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WWXW() => new Vector4U2F30(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WWYX() => new Vector4U2F30(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WWYY() => new Vector4U2F30(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WWYZ() => new Vector4U2F30(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WWYW() => new Vector4U2F30(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WWZX() => new Vector4U2F30(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WWZY() => new Vector4U2F30(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WWZZ() => new Vector4U2F30(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WWZW() => new Vector4U2F30(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WWWX() => new Vector4U2F30(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WWWY() => new Vector4U2F30(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WWWZ() => new Vector4U2F30(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U2F30 WWWW() => new Vector4U2F30(W, W, W, W);

    }
}
