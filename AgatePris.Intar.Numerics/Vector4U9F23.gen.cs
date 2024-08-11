using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U9F23
    : IEquatable<Vector4U9F23>
    , IFormattable
    , IVector<U20F44, I20F44, U10F22, I10F22>
    , IVectorComponentRespective<U9F23> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U9F23 X;
        public U9F23 Y;
        public U9F23 Z;
        public U9F23 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(U9F23 x, U9F23 y, U9F23 z, U9F23 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(U9F23 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(U9F23 x, U9F23 y, Vector2U9F23 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(U9F23 x, Vector3U9F23 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(Vector2U9F23 xy, Vector2U9F23 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(Vector4U9F23 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(U9F23 x, Vector2U9F23 yz, U9F23 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(Vector3U9F23 xyz, U9F23 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23(Vector2U9F23 xy, U9F23 z, U9F23 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U9F23 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U9F23(U9F23.Zero);
        }
        public static Vector4U9F23 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U9F23(U9F23.One);
        }
        public static Vector4U9F23 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U9F23(U9F23.One, U9F23.Zero, U9F23.Zero, U9F23.Zero);
        }
        public static Vector4U9F23 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U9F23(U9F23.Zero, U9F23.One, U9F23.Zero, U9F23.Zero);
        }
        public static Vector4U9F23 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U9F23(U9F23.Zero, U9F23.Zero, U9F23.One, U9F23.Zero);
        }
        public static Vector4U9F23 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U9F23(U9F23.Zero, U9F23.Zero, U9F23.Zero, U9F23.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 operator +(Vector4U9F23 a, Vector4U9F23 b) => new Vector4U9F23(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 operator -(Vector4U9F23 a, Vector4U9F23 b) => new Vector4U9F23(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 operator *(Vector4U9F23 a, Vector4U9F23 b) => new Vector4U9F23(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 operator *(Vector4U9F23 a, U9F23 b) => new Vector4U9F23(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 operator *(U9F23 a, Vector4U9F23 b) => new Vector4U9F23(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 operator /(Vector4U9F23 a, Vector4U9F23 b) => new Vector4U9F23(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 operator /(Vector4U9F23 a, U9F23 b) => new Vector4U9F23(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U9F23 operator /(U9F23 a, Vector4U9F23 b) => new Vector4U9F23(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U9F23 lhs, Vector4U9F23 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U9F23 lhs, Vector4U9F23 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U9F23 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U9F23 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U9F23>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U9F23 other)
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
        public Vector4U9F23 Min(Vector4U9F23 other) => new Vector4U9F23(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23 Max(Vector4U9F23 other) => new Vector4U9F23(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23 Half() => new Vector4U9F23(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23 Twice() => new Vector4U9F23(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23 Clamp(U9F23 min, U9F23 max) => new Vector4U9F23(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23 Clamp(
            Vector4U9F23 min, Vector4U9F23 max
        ) => new Vector4U9F23(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23 WrappingAdd(Vector4U9F23 other) => new Vector4U9F23(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23 WrappingSub(Vector4U9F23 other) => new Vector4U9F23(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23 WrappingMul(Vector4U9F23 other) => new Vector4U9F23(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23 WrappingAddSigned(Vector4I9F23 other) => new Vector4U9F23(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23 SaturatingAdd(Vector4U9F23 other) => new Vector4U9F23(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23 SaturatingMul(U9F23 other) => new Vector4U9F23(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U9F23 other) {
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
        public U9F23 Dot(Vector4U9F23 other) {
            const ulong k = 1UL << 21;
            return U9F23.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U9F23 SaturatingDot(Vector4U9F23 other) {
            const ulong k = 1UL << 21;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U9F23.MaxValue;
            } else {
                return U9F23.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U20F44 LengthSquaredUnsigned() => U20F44.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I20F44 LengthSquaredSigned() => I20F44.FromBits(
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
        public U20F44 LengthSquared() => LengthSquaredUnsigned();

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
        public U9F23 LengthHalf() => U9F23.FromBits(LengthInternal());

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
        public I9F23 LengthHalfSigned() => I9F23.FromBits(checked((int)LengthInternal()));

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
        /// <seealso cref="LengthHalfSigned"/>
        /// <seealso cref="LengthUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I10F22 LengthSigned() => I10F22.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U10F22 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U9F23? Normalize() {
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

            const ulong k = 1UL << 22;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U9F23(
                U9F23.FromBits(y0),
                U9F23.FromBits(y1),
                U9F23.FromBits(y2),
                U9F23.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U9F23 XX() => new Vector2U9F23(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U9F23 XY() => new Vector2U9F23(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U9F23 XZ() => new Vector2U9F23(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U9F23 XW() => new Vector2U9F23(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U9F23 YX() => new Vector2U9F23(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U9F23 YY() => new Vector2U9F23(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U9F23 YZ() => new Vector2U9F23(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U9F23 YW() => new Vector2U9F23(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U9F23 ZX() => new Vector2U9F23(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U9F23 ZY() => new Vector2U9F23(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U9F23 ZZ() => new Vector2U9F23(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U9F23 ZW() => new Vector2U9F23(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U9F23 WX() => new Vector2U9F23(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U9F23 WY() => new Vector2U9F23(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U9F23 WZ() => new Vector2U9F23(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U9F23 WW() => new Vector2U9F23(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 XXX() => new Vector3U9F23(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 XXY() => new Vector3U9F23(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 XXZ() => new Vector3U9F23(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 XXW() => new Vector3U9F23(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 XYX() => new Vector3U9F23(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 XYY() => new Vector3U9F23(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 XYZ() => new Vector3U9F23(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 XYW() => new Vector3U9F23(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 XZX() => new Vector3U9F23(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 XZY() => new Vector3U9F23(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 XZZ() => new Vector3U9F23(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 XZW() => new Vector3U9F23(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 XWX() => new Vector3U9F23(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 XWY() => new Vector3U9F23(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 XWZ() => new Vector3U9F23(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 XWW() => new Vector3U9F23(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 YXX() => new Vector3U9F23(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 YXY() => new Vector3U9F23(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 YXZ() => new Vector3U9F23(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 YXW() => new Vector3U9F23(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 YYX() => new Vector3U9F23(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 YYY() => new Vector3U9F23(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 YYZ() => new Vector3U9F23(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 YYW() => new Vector3U9F23(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 YZX() => new Vector3U9F23(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 YZY() => new Vector3U9F23(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 YZZ() => new Vector3U9F23(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 YZW() => new Vector3U9F23(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 YWX() => new Vector3U9F23(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 YWY() => new Vector3U9F23(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 YWZ() => new Vector3U9F23(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 YWW() => new Vector3U9F23(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 ZXX() => new Vector3U9F23(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 ZXY() => new Vector3U9F23(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 ZXZ() => new Vector3U9F23(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 ZXW() => new Vector3U9F23(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 ZYX() => new Vector3U9F23(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 ZYY() => new Vector3U9F23(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 ZYZ() => new Vector3U9F23(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 ZYW() => new Vector3U9F23(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 ZZX() => new Vector3U9F23(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 ZZY() => new Vector3U9F23(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 ZZZ() => new Vector3U9F23(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 ZZW() => new Vector3U9F23(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 ZWX() => new Vector3U9F23(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 ZWY() => new Vector3U9F23(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 ZWZ() => new Vector3U9F23(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 ZWW() => new Vector3U9F23(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 WXX() => new Vector3U9F23(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 WXY() => new Vector3U9F23(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 WXZ() => new Vector3U9F23(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 WXW() => new Vector3U9F23(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 WYX() => new Vector3U9F23(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 WYY() => new Vector3U9F23(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 WYZ() => new Vector3U9F23(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 WYW() => new Vector3U9F23(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 WZX() => new Vector3U9F23(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 WZY() => new Vector3U9F23(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 WZZ() => new Vector3U9F23(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 WZW() => new Vector3U9F23(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 WWX() => new Vector3U9F23(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 WWY() => new Vector3U9F23(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 WWZ() => new Vector3U9F23(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U9F23 WWW() => new Vector3U9F23(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XXXX() => new Vector4U9F23(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XXXY() => new Vector4U9F23(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XXXZ() => new Vector4U9F23(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XXXW() => new Vector4U9F23(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XXYX() => new Vector4U9F23(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XXYY() => new Vector4U9F23(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XXYZ() => new Vector4U9F23(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XXYW() => new Vector4U9F23(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XXZX() => new Vector4U9F23(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XXZY() => new Vector4U9F23(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XXZZ() => new Vector4U9F23(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XXZW() => new Vector4U9F23(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XXWX() => new Vector4U9F23(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XXWY() => new Vector4U9F23(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XXWZ() => new Vector4U9F23(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XXWW() => new Vector4U9F23(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XYXX() => new Vector4U9F23(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XYXY() => new Vector4U9F23(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XYXZ() => new Vector4U9F23(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XYXW() => new Vector4U9F23(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XYYX() => new Vector4U9F23(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XYYY() => new Vector4U9F23(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XYYZ() => new Vector4U9F23(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XYYW() => new Vector4U9F23(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XYZX() => new Vector4U9F23(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XYZY() => new Vector4U9F23(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XYZZ() => new Vector4U9F23(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XYZW() => new Vector4U9F23(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XYWX() => new Vector4U9F23(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XYWY() => new Vector4U9F23(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XYWZ() => new Vector4U9F23(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XYWW() => new Vector4U9F23(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XZXX() => new Vector4U9F23(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XZXY() => new Vector4U9F23(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XZXZ() => new Vector4U9F23(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XZXW() => new Vector4U9F23(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XZYX() => new Vector4U9F23(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XZYY() => new Vector4U9F23(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XZYZ() => new Vector4U9F23(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XZYW() => new Vector4U9F23(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XZZX() => new Vector4U9F23(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XZZY() => new Vector4U9F23(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XZZZ() => new Vector4U9F23(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XZZW() => new Vector4U9F23(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XZWX() => new Vector4U9F23(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XZWY() => new Vector4U9F23(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XZWZ() => new Vector4U9F23(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XZWW() => new Vector4U9F23(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XWXX() => new Vector4U9F23(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XWXY() => new Vector4U9F23(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XWXZ() => new Vector4U9F23(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XWXW() => new Vector4U9F23(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XWYX() => new Vector4U9F23(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XWYY() => new Vector4U9F23(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XWYZ() => new Vector4U9F23(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XWYW() => new Vector4U9F23(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XWZX() => new Vector4U9F23(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XWZY() => new Vector4U9F23(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XWZZ() => new Vector4U9F23(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XWZW() => new Vector4U9F23(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XWWX() => new Vector4U9F23(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XWWY() => new Vector4U9F23(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XWWZ() => new Vector4U9F23(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 XWWW() => new Vector4U9F23(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YXXX() => new Vector4U9F23(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YXXY() => new Vector4U9F23(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YXXZ() => new Vector4U9F23(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YXXW() => new Vector4U9F23(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YXYX() => new Vector4U9F23(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YXYY() => new Vector4U9F23(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YXYZ() => new Vector4U9F23(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YXYW() => new Vector4U9F23(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YXZX() => new Vector4U9F23(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YXZY() => new Vector4U9F23(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YXZZ() => new Vector4U9F23(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YXZW() => new Vector4U9F23(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YXWX() => new Vector4U9F23(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YXWY() => new Vector4U9F23(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YXWZ() => new Vector4U9F23(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YXWW() => new Vector4U9F23(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YYXX() => new Vector4U9F23(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YYXY() => new Vector4U9F23(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YYXZ() => new Vector4U9F23(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YYXW() => new Vector4U9F23(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YYYX() => new Vector4U9F23(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YYYY() => new Vector4U9F23(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YYYZ() => new Vector4U9F23(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YYYW() => new Vector4U9F23(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YYZX() => new Vector4U9F23(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YYZY() => new Vector4U9F23(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YYZZ() => new Vector4U9F23(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YYZW() => new Vector4U9F23(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YYWX() => new Vector4U9F23(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YYWY() => new Vector4U9F23(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YYWZ() => new Vector4U9F23(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YYWW() => new Vector4U9F23(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YZXX() => new Vector4U9F23(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YZXY() => new Vector4U9F23(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YZXZ() => new Vector4U9F23(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YZXW() => new Vector4U9F23(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YZYX() => new Vector4U9F23(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YZYY() => new Vector4U9F23(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YZYZ() => new Vector4U9F23(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YZYW() => new Vector4U9F23(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YZZX() => new Vector4U9F23(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YZZY() => new Vector4U9F23(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YZZZ() => new Vector4U9F23(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YZZW() => new Vector4U9F23(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YZWX() => new Vector4U9F23(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YZWY() => new Vector4U9F23(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YZWZ() => new Vector4U9F23(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YZWW() => new Vector4U9F23(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YWXX() => new Vector4U9F23(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YWXY() => new Vector4U9F23(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YWXZ() => new Vector4U9F23(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YWXW() => new Vector4U9F23(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YWYX() => new Vector4U9F23(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YWYY() => new Vector4U9F23(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YWYZ() => new Vector4U9F23(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YWYW() => new Vector4U9F23(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YWZX() => new Vector4U9F23(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YWZY() => new Vector4U9F23(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YWZZ() => new Vector4U9F23(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YWZW() => new Vector4U9F23(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YWWX() => new Vector4U9F23(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YWWY() => new Vector4U9F23(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YWWZ() => new Vector4U9F23(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 YWWW() => new Vector4U9F23(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZXXX() => new Vector4U9F23(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZXXY() => new Vector4U9F23(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZXXZ() => new Vector4U9F23(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZXXW() => new Vector4U9F23(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZXYX() => new Vector4U9F23(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZXYY() => new Vector4U9F23(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZXYZ() => new Vector4U9F23(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZXYW() => new Vector4U9F23(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZXZX() => new Vector4U9F23(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZXZY() => new Vector4U9F23(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZXZZ() => new Vector4U9F23(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZXZW() => new Vector4U9F23(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZXWX() => new Vector4U9F23(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZXWY() => new Vector4U9F23(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZXWZ() => new Vector4U9F23(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZXWW() => new Vector4U9F23(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZYXX() => new Vector4U9F23(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZYXY() => new Vector4U9F23(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZYXZ() => new Vector4U9F23(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZYXW() => new Vector4U9F23(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZYYX() => new Vector4U9F23(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZYYY() => new Vector4U9F23(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZYYZ() => new Vector4U9F23(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZYYW() => new Vector4U9F23(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZYZX() => new Vector4U9F23(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZYZY() => new Vector4U9F23(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZYZZ() => new Vector4U9F23(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZYZW() => new Vector4U9F23(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZYWX() => new Vector4U9F23(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZYWY() => new Vector4U9F23(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZYWZ() => new Vector4U9F23(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZYWW() => new Vector4U9F23(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZZXX() => new Vector4U9F23(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZZXY() => new Vector4U9F23(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZZXZ() => new Vector4U9F23(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZZXW() => new Vector4U9F23(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZZYX() => new Vector4U9F23(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZZYY() => new Vector4U9F23(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZZYZ() => new Vector4U9F23(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZZYW() => new Vector4U9F23(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZZZX() => new Vector4U9F23(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZZZY() => new Vector4U9F23(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZZZZ() => new Vector4U9F23(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZZZW() => new Vector4U9F23(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZZWX() => new Vector4U9F23(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZZWY() => new Vector4U9F23(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZZWZ() => new Vector4U9F23(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZZWW() => new Vector4U9F23(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZWXX() => new Vector4U9F23(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZWXY() => new Vector4U9F23(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZWXZ() => new Vector4U9F23(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZWXW() => new Vector4U9F23(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZWYX() => new Vector4U9F23(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZWYY() => new Vector4U9F23(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZWYZ() => new Vector4U9F23(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZWYW() => new Vector4U9F23(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZWZX() => new Vector4U9F23(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZWZY() => new Vector4U9F23(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZWZZ() => new Vector4U9F23(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZWZW() => new Vector4U9F23(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZWWX() => new Vector4U9F23(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZWWY() => new Vector4U9F23(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZWWZ() => new Vector4U9F23(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 ZWWW() => new Vector4U9F23(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WXXX() => new Vector4U9F23(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WXXY() => new Vector4U9F23(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WXXZ() => new Vector4U9F23(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WXXW() => new Vector4U9F23(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WXYX() => new Vector4U9F23(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WXYY() => new Vector4U9F23(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WXYZ() => new Vector4U9F23(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WXYW() => new Vector4U9F23(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WXZX() => new Vector4U9F23(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WXZY() => new Vector4U9F23(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WXZZ() => new Vector4U9F23(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WXZW() => new Vector4U9F23(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WXWX() => new Vector4U9F23(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WXWY() => new Vector4U9F23(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WXWZ() => new Vector4U9F23(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WXWW() => new Vector4U9F23(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WYXX() => new Vector4U9F23(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WYXY() => new Vector4U9F23(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WYXZ() => new Vector4U9F23(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WYXW() => new Vector4U9F23(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WYYX() => new Vector4U9F23(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WYYY() => new Vector4U9F23(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WYYZ() => new Vector4U9F23(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WYYW() => new Vector4U9F23(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WYZX() => new Vector4U9F23(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WYZY() => new Vector4U9F23(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WYZZ() => new Vector4U9F23(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WYZW() => new Vector4U9F23(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WYWX() => new Vector4U9F23(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WYWY() => new Vector4U9F23(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WYWZ() => new Vector4U9F23(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WYWW() => new Vector4U9F23(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WZXX() => new Vector4U9F23(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WZXY() => new Vector4U9F23(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WZXZ() => new Vector4U9F23(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WZXW() => new Vector4U9F23(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WZYX() => new Vector4U9F23(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WZYY() => new Vector4U9F23(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WZYZ() => new Vector4U9F23(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WZYW() => new Vector4U9F23(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WZZX() => new Vector4U9F23(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WZZY() => new Vector4U9F23(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WZZZ() => new Vector4U9F23(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WZZW() => new Vector4U9F23(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WZWX() => new Vector4U9F23(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WZWY() => new Vector4U9F23(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WZWZ() => new Vector4U9F23(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WZWW() => new Vector4U9F23(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WWXX() => new Vector4U9F23(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WWXY() => new Vector4U9F23(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WWXZ() => new Vector4U9F23(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WWXW() => new Vector4U9F23(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WWYX() => new Vector4U9F23(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WWYY() => new Vector4U9F23(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WWYZ() => new Vector4U9F23(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WWYW() => new Vector4U9F23(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WWZX() => new Vector4U9F23(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WWZY() => new Vector4U9F23(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WWZZ() => new Vector4U9F23(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WWZW() => new Vector4U9F23(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WWWX() => new Vector4U9F23(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WWWY() => new Vector4U9F23(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WWWZ() => new Vector4U9F23(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U9F23 WWWW() => new Vector4U9F23(W, W, W, W);

    }
}
