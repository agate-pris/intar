using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U13F19
    : IEquatable<Vector4U13F19>
    , IFormattable
    , IVector<U28F36, I28F36, U14F18, I14F18>
    , IVectorComponentRespective<U13F19> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U13F19 X;
        public U13F19 Y;
        public U13F19 Z;
        public U13F19 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(U13F19 x, U13F19 y, U13F19 z, U13F19 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(U13F19 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(U13F19 x, U13F19 y, Vector2U13F19 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(U13F19 x, Vector3U13F19 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(Vector2U13F19 xy, Vector2U13F19 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(Vector4U13F19 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(U13F19 x, Vector2U13F19 yz, U13F19 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(Vector3U13F19 xyz, U13F19 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19(Vector2U13F19 xy, U13F19 z, U13F19 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U13F19 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U13F19(U13F19.Zero);
        }
        public static Vector4U13F19 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U13F19(U13F19.One);
        }
        public static Vector4U13F19 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U13F19(U13F19.One, U13F19.Zero, U13F19.Zero, U13F19.Zero);
        }
        public static Vector4U13F19 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U13F19(U13F19.Zero, U13F19.One, U13F19.Zero, U13F19.Zero);
        }
        public static Vector4U13F19 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U13F19(U13F19.Zero, U13F19.Zero, U13F19.One, U13F19.Zero);
        }
        public static Vector4U13F19 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U13F19(U13F19.Zero, U13F19.Zero, U13F19.Zero, U13F19.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator +(Vector4U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator -(Vector4U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator *(Vector4U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator *(Vector4U13F19 a, U13F19 b) => new Vector4U13F19(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator *(U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator /(Vector4U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator /(Vector4U13F19 a, U13F19 b) => new Vector4U13F19(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U13F19 operator /(U13F19 a, Vector4U13F19 b) => new Vector4U13F19(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U13F19 lhs, Vector4U13F19 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U13F19 lhs, Vector4U13F19 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U13F19 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U13F19 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U13F19>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U13F19 other)
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
        public Vector4U13F19 Min(Vector4U13F19 other) => new Vector4U13F19(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19 Max(Vector4U13F19 other) => new Vector4U13F19(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19 Half() => new Vector4U13F19(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19 Twice() => new Vector4U13F19(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19 Clamp(U13F19 min, U13F19 max) => new Vector4U13F19(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19 Clamp(
            Vector4U13F19 min, Vector4U13F19 max
        ) => new Vector4U13F19(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19 WrappingAdd(Vector4U13F19 other) => new Vector4U13F19(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19 WrappingSub(Vector4U13F19 other) => new Vector4U13F19(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19 WrappingMul(Vector4U13F19 other) => new Vector4U13F19(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19 WrappingAddSigned(Vector4I13F19 other) => new Vector4U13F19(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19 SaturatingAdd(Vector4U13F19 other) => new Vector4U13F19(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19 SaturatingMul(U13F19 other) => new Vector4U13F19(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U13F19 other) {
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
        public U13F19 Dot(Vector4U13F19 other) {
            const ulong k = 1UL << 17;
            return U13F19.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U13F19 SaturatingDot(Vector4U13F19 other) {
            const ulong k = 1UL << 17;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U13F19.MaxValue;
            } else {
                return U13F19.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U28F36 LengthSquaredUnsigned() => U28F36.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I28F36 LengthSquaredSigned() => I28F36.FromBits(
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
        public U28F36 LengthSquared() => LengthSquaredUnsigned();

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
        public U13F19 LengthHalf() => U13F19.FromBits(LengthInternal());

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
        public I13F19 LengthHalfSigned() => I13F19.FromBits(checked((int)LengthInternal()));

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
        public U14F18 LengthUnsigned() => U14F18.FromBits(LengthInternal());

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
        public I14F18 LengthSigned() => I14F18.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U14F18 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U13F19? Normalize() {
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

            const ulong k = 1UL << 18;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U13F19(
                U13F19.FromBits(y0),
                U13F19.FromBits(y1),
                U13F19.FromBits(y2),
                U13F19.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U13F19 XX() => new Vector2U13F19(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U13F19 XY() => new Vector2U13F19(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U13F19 XZ() => new Vector2U13F19(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U13F19 XW() => new Vector2U13F19(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U13F19 YX() => new Vector2U13F19(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U13F19 YY() => new Vector2U13F19(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U13F19 YZ() => new Vector2U13F19(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U13F19 YW() => new Vector2U13F19(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U13F19 ZX() => new Vector2U13F19(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U13F19 ZY() => new Vector2U13F19(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U13F19 ZZ() => new Vector2U13F19(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U13F19 ZW() => new Vector2U13F19(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U13F19 WX() => new Vector2U13F19(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U13F19 WY() => new Vector2U13F19(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U13F19 WZ() => new Vector2U13F19(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U13F19 WW() => new Vector2U13F19(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 XXX() => new Vector3U13F19(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 XXY() => new Vector3U13F19(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 XXZ() => new Vector3U13F19(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 XXW() => new Vector3U13F19(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 XYX() => new Vector3U13F19(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 XYY() => new Vector3U13F19(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 XYZ() => new Vector3U13F19(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 XYW() => new Vector3U13F19(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 XZX() => new Vector3U13F19(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 XZY() => new Vector3U13F19(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 XZZ() => new Vector3U13F19(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 XZW() => new Vector3U13F19(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 XWX() => new Vector3U13F19(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 XWY() => new Vector3U13F19(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 XWZ() => new Vector3U13F19(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 XWW() => new Vector3U13F19(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 YXX() => new Vector3U13F19(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 YXY() => new Vector3U13F19(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 YXZ() => new Vector3U13F19(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 YXW() => new Vector3U13F19(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 YYX() => new Vector3U13F19(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 YYY() => new Vector3U13F19(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 YYZ() => new Vector3U13F19(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 YYW() => new Vector3U13F19(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 YZX() => new Vector3U13F19(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 YZY() => new Vector3U13F19(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 YZZ() => new Vector3U13F19(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 YZW() => new Vector3U13F19(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 YWX() => new Vector3U13F19(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 YWY() => new Vector3U13F19(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 YWZ() => new Vector3U13F19(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 YWW() => new Vector3U13F19(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 ZXX() => new Vector3U13F19(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 ZXY() => new Vector3U13F19(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 ZXZ() => new Vector3U13F19(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 ZXW() => new Vector3U13F19(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 ZYX() => new Vector3U13F19(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 ZYY() => new Vector3U13F19(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 ZYZ() => new Vector3U13F19(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 ZYW() => new Vector3U13F19(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 ZZX() => new Vector3U13F19(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 ZZY() => new Vector3U13F19(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 ZZZ() => new Vector3U13F19(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 ZZW() => new Vector3U13F19(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 ZWX() => new Vector3U13F19(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 ZWY() => new Vector3U13F19(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 ZWZ() => new Vector3U13F19(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 ZWW() => new Vector3U13F19(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 WXX() => new Vector3U13F19(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 WXY() => new Vector3U13F19(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 WXZ() => new Vector3U13F19(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 WXW() => new Vector3U13F19(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 WYX() => new Vector3U13F19(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 WYY() => new Vector3U13F19(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 WYZ() => new Vector3U13F19(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 WYW() => new Vector3U13F19(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 WZX() => new Vector3U13F19(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 WZY() => new Vector3U13F19(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 WZZ() => new Vector3U13F19(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 WZW() => new Vector3U13F19(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 WWX() => new Vector3U13F19(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 WWY() => new Vector3U13F19(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 WWZ() => new Vector3U13F19(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U13F19 WWW() => new Vector3U13F19(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XXXX() => new Vector4U13F19(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XXXY() => new Vector4U13F19(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XXXZ() => new Vector4U13F19(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XXXW() => new Vector4U13F19(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XXYX() => new Vector4U13F19(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XXYY() => new Vector4U13F19(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XXYZ() => new Vector4U13F19(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XXYW() => new Vector4U13F19(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XXZX() => new Vector4U13F19(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XXZY() => new Vector4U13F19(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XXZZ() => new Vector4U13F19(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XXZW() => new Vector4U13F19(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XXWX() => new Vector4U13F19(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XXWY() => new Vector4U13F19(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XXWZ() => new Vector4U13F19(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XXWW() => new Vector4U13F19(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XYXX() => new Vector4U13F19(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XYXY() => new Vector4U13F19(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XYXZ() => new Vector4U13F19(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XYXW() => new Vector4U13F19(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XYYX() => new Vector4U13F19(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XYYY() => new Vector4U13F19(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XYYZ() => new Vector4U13F19(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XYYW() => new Vector4U13F19(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XYZX() => new Vector4U13F19(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XYZY() => new Vector4U13F19(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XYZZ() => new Vector4U13F19(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XYZW() => new Vector4U13F19(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XYWX() => new Vector4U13F19(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XYWY() => new Vector4U13F19(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XYWZ() => new Vector4U13F19(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XYWW() => new Vector4U13F19(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XZXX() => new Vector4U13F19(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XZXY() => new Vector4U13F19(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XZXZ() => new Vector4U13F19(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XZXW() => new Vector4U13F19(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XZYX() => new Vector4U13F19(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XZYY() => new Vector4U13F19(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XZYZ() => new Vector4U13F19(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XZYW() => new Vector4U13F19(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XZZX() => new Vector4U13F19(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XZZY() => new Vector4U13F19(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XZZZ() => new Vector4U13F19(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XZZW() => new Vector4U13F19(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XZWX() => new Vector4U13F19(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XZWY() => new Vector4U13F19(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XZWZ() => new Vector4U13F19(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XZWW() => new Vector4U13F19(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XWXX() => new Vector4U13F19(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XWXY() => new Vector4U13F19(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XWXZ() => new Vector4U13F19(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XWXW() => new Vector4U13F19(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XWYX() => new Vector4U13F19(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XWYY() => new Vector4U13F19(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XWYZ() => new Vector4U13F19(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XWYW() => new Vector4U13F19(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XWZX() => new Vector4U13F19(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XWZY() => new Vector4U13F19(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XWZZ() => new Vector4U13F19(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XWZW() => new Vector4U13F19(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XWWX() => new Vector4U13F19(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XWWY() => new Vector4U13F19(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XWWZ() => new Vector4U13F19(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 XWWW() => new Vector4U13F19(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YXXX() => new Vector4U13F19(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YXXY() => new Vector4U13F19(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YXXZ() => new Vector4U13F19(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YXXW() => new Vector4U13F19(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YXYX() => new Vector4U13F19(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YXYY() => new Vector4U13F19(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YXYZ() => new Vector4U13F19(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YXYW() => new Vector4U13F19(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YXZX() => new Vector4U13F19(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YXZY() => new Vector4U13F19(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YXZZ() => new Vector4U13F19(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YXZW() => new Vector4U13F19(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YXWX() => new Vector4U13F19(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YXWY() => new Vector4U13F19(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YXWZ() => new Vector4U13F19(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YXWW() => new Vector4U13F19(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YYXX() => new Vector4U13F19(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YYXY() => new Vector4U13F19(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YYXZ() => new Vector4U13F19(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YYXW() => new Vector4U13F19(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YYYX() => new Vector4U13F19(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YYYY() => new Vector4U13F19(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YYYZ() => new Vector4U13F19(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YYYW() => new Vector4U13F19(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YYZX() => new Vector4U13F19(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YYZY() => new Vector4U13F19(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YYZZ() => new Vector4U13F19(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YYZW() => new Vector4U13F19(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YYWX() => new Vector4U13F19(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YYWY() => new Vector4U13F19(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YYWZ() => new Vector4U13F19(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YYWW() => new Vector4U13F19(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YZXX() => new Vector4U13F19(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YZXY() => new Vector4U13F19(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YZXZ() => new Vector4U13F19(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YZXW() => new Vector4U13F19(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YZYX() => new Vector4U13F19(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YZYY() => new Vector4U13F19(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YZYZ() => new Vector4U13F19(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YZYW() => new Vector4U13F19(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YZZX() => new Vector4U13F19(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YZZY() => new Vector4U13F19(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YZZZ() => new Vector4U13F19(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YZZW() => new Vector4U13F19(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YZWX() => new Vector4U13F19(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YZWY() => new Vector4U13F19(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YZWZ() => new Vector4U13F19(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YZWW() => new Vector4U13F19(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YWXX() => new Vector4U13F19(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YWXY() => new Vector4U13F19(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YWXZ() => new Vector4U13F19(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YWXW() => new Vector4U13F19(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YWYX() => new Vector4U13F19(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YWYY() => new Vector4U13F19(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YWYZ() => new Vector4U13F19(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YWYW() => new Vector4U13F19(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YWZX() => new Vector4U13F19(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YWZY() => new Vector4U13F19(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YWZZ() => new Vector4U13F19(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YWZW() => new Vector4U13F19(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YWWX() => new Vector4U13F19(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YWWY() => new Vector4U13F19(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YWWZ() => new Vector4U13F19(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 YWWW() => new Vector4U13F19(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZXXX() => new Vector4U13F19(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZXXY() => new Vector4U13F19(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZXXZ() => new Vector4U13F19(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZXXW() => new Vector4U13F19(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZXYX() => new Vector4U13F19(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZXYY() => new Vector4U13F19(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZXYZ() => new Vector4U13F19(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZXYW() => new Vector4U13F19(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZXZX() => new Vector4U13F19(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZXZY() => new Vector4U13F19(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZXZZ() => new Vector4U13F19(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZXZW() => new Vector4U13F19(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZXWX() => new Vector4U13F19(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZXWY() => new Vector4U13F19(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZXWZ() => new Vector4U13F19(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZXWW() => new Vector4U13F19(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZYXX() => new Vector4U13F19(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZYXY() => new Vector4U13F19(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZYXZ() => new Vector4U13F19(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZYXW() => new Vector4U13F19(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZYYX() => new Vector4U13F19(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZYYY() => new Vector4U13F19(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZYYZ() => new Vector4U13F19(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZYYW() => new Vector4U13F19(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZYZX() => new Vector4U13F19(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZYZY() => new Vector4U13F19(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZYZZ() => new Vector4U13F19(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZYZW() => new Vector4U13F19(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZYWX() => new Vector4U13F19(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZYWY() => new Vector4U13F19(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZYWZ() => new Vector4U13F19(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZYWW() => new Vector4U13F19(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZZXX() => new Vector4U13F19(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZZXY() => new Vector4U13F19(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZZXZ() => new Vector4U13F19(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZZXW() => new Vector4U13F19(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZZYX() => new Vector4U13F19(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZZYY() => new Vector4U13F19(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZZYZ() => new Vector4U13F19(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZZYW() => new Vector4U13F19(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZZZX() => new Vector4U13F19(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZZZY() => new Vector4U13F19(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZZZZ() => new Vector4U13F19(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZZZW() => new Vector4U13F19(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZZWX() => new Vector4U13F19(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZZWY() => new Vector4U13F19(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZZWZ() => new Vector4U13F19(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZZWW() => new Vector4U13F19(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZWXX() => new Vector4U13F19(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZWXY() => new Vector4U13F19(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZWXZ() => new Vector4U13F19(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZWXW() => new Vector4U13F19(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZWYX() => new Vector4U13F19(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZWYY() => new Vector4U13F19(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZWYZ() => new Vector4U13F19(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZWYW() => new Vector4U13F19(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZWZX() => new Vector4U13F19(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZWZY() => new Vector4U13F19(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZWZZ() => new Vector4U13F19(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZWZW() => new Vector4U13F19(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZWWX() => new Vector4U13F19(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZWWY() => new Vector4U13F19(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZWWZ() => new Vector4U13F19(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 ZWWW() => new Vector4U13F19(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WXXX() => new Vector4U13F19(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WXXY() => new Vector4U13F19(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WXXZ() => new Vector4U13F19(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WXXW() => new Vector4U13F19(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WXYX() => new Vector4U13F19(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WXYY() => new Vector4U13F19(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WXYZ() => new Vector4U13F19(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WXYW() => new Vector4U13F19(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WXZX() => new Vector4U13F19(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WXZY() => new Vector4U13F19(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WXZZ() => new Vector4U13F19(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WXZW() => new Vector4U13F19(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WXWX() => new Vector4U13F19(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WXWY() => new Vector4U13F19(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WXWZ() => new Vector4U13F19(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WXWW() => new Vector4U13F19(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WYXX() => new Vector4U13F19(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WYXY() => new Vector4U13F19(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WYXZ() => new Vector4U13F19(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WYXW() => new Vector4U13F19(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WYYX() => new Vector4U13F19(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WYYY() => new Vector4U13F19(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WYYZ() => new Vector4U13F19(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WYYW() => new Vector4U13F19(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WYZX() => new Vector4U13F19(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WYZY() => new Vector4U13F19(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WYZZ() => new Vector4U13F19(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WYZW() => new Vector4U13F19(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WYWX() => new Vector4U13F19(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WYWY() => new Vector4U13F19(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WYWZ() => new Vector4U13F19(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WYWW() => new Vector4U13F19(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WZXX() => new Vector4U13F19(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WZXY() => new Vector4U13F19(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WZXZ() => new Vector4U13F19(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WZXW() => new Vector4U13F19(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WZYX() => new Vector4U13F19(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WZYY() => new Vector4U13F19(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WZYZ() => new Vector4U13F19(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WZYW() => new Vector4U13F19(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WZZX() => new Vector4U13F19(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WZZY() => new Vector4U13F19(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WZZZ() => new Vector4U13F19(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WZZW() => new Vector4U13F19(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WZWX() => new Vector4U13F19(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WZWY() => new Vector4U13F19(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WZWZ() => new Vector4U13F19(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WZWW() => new Vector4U13F19(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WWXX() => new Vector4U13F19(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WWXY() => new Vector4U13F19(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WWXZ() => new Vector4U13F19(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WWXW() => new Vector4U13F19(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WWYX() => new Vector4U13F19(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WWYY() => new Vector4U13F19(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WWYZ() => new Vector4U13F19(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WWYW() => new Vector4U13F19(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WWZX() => new Vector4U13F19(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WWZY() => new Vector4U13F19(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WWZZ() => new Vector4U13F19(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WWZW() => new Vector4U13F19(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WWWX() => new Vector4U13F19(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WWWY() => new Vector4U13F19(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WWWZ() => new Vector4U13F19(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U13F19 WWWW() => new Vector4U13F19(W, W, W, W);

    }
}
