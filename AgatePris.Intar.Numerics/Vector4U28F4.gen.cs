using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U28F4
    : IEquatable<Vector4U28F4>
    , IFormattable
    , IVector<U58F6, I58F6, U29F3, I29F3>
    , IVectorComponentRespective<U28F4> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U28F4 X;
        public U28F4 Y;
        public U28F4 Z;
        public U28F4 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(U28F4 x, U28F4 y, U28F4 z, U28F4 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(U28F4 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(U28F4 x, U28F4 y, Vector2U28F4 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(U28F4 x, Vector3U28F4 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(Vector2U28F4 xy, Vector2U28F4 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(Vector4U28F4 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(U28F4 x, Vector2U28F4 yz, U28F4 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(Vector3U28F4 xyz, U28F4 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4(Vector2U28F4 xy, U28F4 z, U28F4 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U28F4 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U28F4(U28F4.Zero);
        }
        public static Vector4U28F4 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U28F4(U28F4.One);
        }
        public static Vector4U28F4 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U28F4(U28F4.One, U28F4.Zero, U28F4.Zero, U28F4.Zero);
        }
        public static Vector4U28F4 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U28F4(U28F4.Zero, U28F4.One, U28F4.Zero, U28F4.Zero);
        }
        public static Vector4U28F4 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U28F4(U28F4.Zero, U28F4.Zero, U28F4.One, U28F4.Zero);
        }
        public static Vector4U28F4 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U28F4(U28F4.Zero, U28F4.Zero, U28F4.Zero, U28F4.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator +(Vector4U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator -(Vector4U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator *(Vector4U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator *(Vector4U28F4 a, U28F4 b) => new Vector4U28F4(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator *(U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator /(Vector4U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator /(Vector4U28F4 a, U28F4 b) => new Vector4U28F4(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U28F4 operator /(U28F4 a, Vector4U28F4 b) => new Vector4U28F4(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U28F4 lhs, Vector4U28F4 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U28F4 lhs, Vector4U28F4 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U28F4 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U28F4 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U28F4>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U28F4 other)
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
        public Vector4U28F4 Min(Vector4U28F4 other) => new Vector4U28F4(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4 Max(Vector4U28F4 other) => new Vector4U28F4(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4 Half() => new Vector4U28F4(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4 Twice() => new Vector4U28F4(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4 Clamp(U28F4 min, U28F4 max) => new Vector4U28F4(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4 Clamp(
            Vector4U28F4 min, Vector4U28F4 max
        ) => new Vector4U28F4(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4 WrappingAdd(Vector4U28F4 other) => new Vector4U28F4(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4 WrappingSub(Vector4U28F4 other) => new Vector4U28F4(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4 WrappingMul(Vector4U28F4 other) => new Vector4U28F4(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4 WrappingAddSigned(Vector4I28F4 other) => new Vector4U28F4(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4 SaturatingAdd(Vector4U28F4 other) => new Vector4U28F4(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4 SaturatingMul(U28F4 other) => new Vector4U28F4(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U28F4 other) {
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
        public U28F4 Dot(Vector4U28F4 other) {
            const ulong k = 1UL << 2;
            return U28F4.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U28F4 SaturatingDot(Vector4U28F4 other) {
            const ulong k = 1UL << 2;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U28F4.MaxValue;
            } else {
                return U28F4.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U58F6 LengthSquaredUnsigned() => U58F6.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I58F6 LengthSquaredSigned() => I58F6.FromBits(
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
        public U58F6 LengthSquared() => LengthSquaredUnsigned();

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
        public U28F4 LengthHalf() => U28F4.FromBits(LengthInternal());

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
        public I28F4 LengthHalfSigned() => I28F4.FromBits(checked((int)LengthInternal()));

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
        public U29F3 LengthUnsigned() => U29F3.FromBits(LengthInternal());

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
        public I29F3 LengthSigned() => I29F3.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U29F3 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U28F4? Normalize() {
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

            const ulong k = 1UL << 3;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U28F4(
                U28F4.FromBits(y0),
                U28F4.FromBits(y1),
                U28F4.FromBits(y2),
                U28F4.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U28F4 XX() => new Vector2U28F4(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U28F4 XY() => new Vector2U28F4(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U28F4 XZ() => new Vector2U28F4(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U28F4 XW() => new Vector2U28F4(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U28F4 YX() => new Vector2U28F4(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U28F4 YY() => new Vector2U28F4(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U28F4 YZ() => new Vector2U28F4(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U28F4 YW() => new Vector2U28F4(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U28F4 ZX() => new Vector2U28F4(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U28F4 ZY() => new Vector2U28F4(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U28F4 ZZ() => new Vector2U28F4(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U28F4 ZW() => new Vector2U28F4(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U28F4 WX() => new Vector2U28F4(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U28F4 WY() => new Vector2U28F4(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U28F4 WZ() => new Vector2U28F4(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U28F4 WW() => new Vector2U28F4(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 XXX() => new Vector3U28F4(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 XXY() => new Vector3U28F4(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 XXZ() => new Vector3U28F4(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 XXW() => new Vector3U28F4(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 XYX() => new Vector3U28F4(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 XYY() => new Vector3U28F4(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 XYZ() => new Vector3U28F4(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 XYW() => new Vector3U28F4(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 XZX() => new Vector3U28F4(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 XZY() => new Vector3U28F4(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 XZZ() => new Vector3U28F4(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 XZW() => new Vector3U28F4(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 XWX() => new Vector3U28F4(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 XWY() => new Vector3U28F4(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 XWZ() => new Vector3U28F4(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 XWW() => new Vector3U28F4(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 YXX() => new Vector3U28F4(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 YXY() => new Vector3U28F4(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 YXZ() => new Vector3U28F4(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 YXW() => new Vector3U28F4(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 YYX() => new Vector3U28F4(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 YYY() => new Vector3U28F4(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 YYZ() => new Vector3U28F4(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 YYW() => new Vector3U28F4(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 YZX() => new Vector3U28F4(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 YZY() => new Vector3U28F4(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 YZZ() => new Vector3U28F4(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 YZW() => new Vector3U28F4(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 YWX() => new Vector3U28F4(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 YWY() => new Vector3U28F4(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 YWZ() => new Vector3U28F4(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 YWW() => new Vector3U28F4(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 ZXX() => new Vector3U28F4(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 ZXY() => new Vector3U28F4(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 ZXZ() => new Vector3U28F4(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 ZXW() => new Vector3U28F4(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 ZYX() => new Vector3U28F4(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 ZYY() => new Vector3U28F4(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 ZYZ() => new Vector3U28F4(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 ZYW() => new Vector3U28F4(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 ZZX() => new Vector3U28F4(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 ZZY() => new Vector3U28F4(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 ZZZ() => new Vector3U28F4(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 ZZW() => new Vector3U28F4(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 ZWX() => new Vector3U28F4(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 ZWY() => new Vector3U28F4(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 ZWZ() => new Vector3U28F4(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 ZWW() => new Vector3U28F4(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 WXX() => new Vector3U28F4(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 WXY() => new Vector3U28F4(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 WXZ() => new Vector3U28F4(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 WXW() => new Vector3U28F4(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 WYX() => new Vector3U28F4(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 WYY() => new Vector3U28F4(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 WYZ() => new Vector3U28F4(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 WYW() => new Vector3U28F4(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 WZX() => new Vector3U28F4(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 WZY() => new Vector3U28F4(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 WZZ() => new Vector3U28F4(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 WZW() => new Vector3U28F4(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 WWX() => new Vector3U28F4(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 WWY() => new Vector3U28F4(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 WWZ() => new Vector3U28F4(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U28F4 WWW() => new Vector3U28F4(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XXXX() => new Vector4U28F4(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XXXY() => new Vector4U28F4(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XXXZ() => new Vector4U28F4(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XXXW() => new Vector4U28F4(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XXYX() => new Vector4U28F4(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XXYY() => new Vector4U28F4(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XXYZ() => new Vector4U28F4(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XXYW() => new Vector4U28F4(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XXZX() => new Vector4U28F4(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XXZY() => new Vector4U28F4(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XXZZ() => new Vector4U28F4(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XXZW() => new Vector4U28F4(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XXWX() => new Vector4U28F4(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XXWY() => new Vector4U28F4(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XXWZ() => new Vector4U28F4(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XXWW() => new Vector4U28F4(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XYXX() => new Vector4U28F4(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XYXY() => new Vector4U28F4(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XYXZ() => new Vector4U28F4(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XYXW() => new Vector4U28F4(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XYYX() => new Vector4U28F4(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XYYY() => new Vector4U28F4(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XYYZ() => new Vector4U28F4(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XYYW() => new Vector4U28F4(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XYZX() => new Vector4U28F4(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XYZY() => new Vector4U28F4(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XYZZ() => new Vector4U28F4(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XYZW() => new Vector4U28F4(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XYWX() => new Vector4U28F4(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XYWY() => new Vector4U28F4(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XYWZ() => new Vector4U28F4(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XYWW() => new Vector4U28F4(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XZXX() => new Vector4U28F4(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XZXY() => new Vector4U28F4(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XZXZ() => new Vector4U28F4(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XZXW() => new Vector4U28F4(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XZYX() => new Vector4U28F4(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XZYY() => new Vector4U28F4(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XZYZ() => new Vector4U28F4(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XZYW() => new Vector4U28F4(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XZZX() => new Vector4U28F4(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XZZY() => new Vector4U28F4(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XZZZ() => new Vector4U28F4(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XZZW() => new Vector4U28F4(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XZWX() => new Vector4U28F4(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XZWY() => new Vector4U28F4(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XZWZ() => new Vector4U28F4(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XZWW() => new Vector4U28F4(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XWXX() => new Vector4U28F4(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XWXY() => new Vector4U28F4(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XWXZ() => new Vector4U28F4(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XWXW() => new Vector4U28F4(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XWYX() => new Vector4U28F4(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XWYY() => new Vector4U28F4(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XWYZ() => new Vector4U28F4(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XWYW() => new Vector4U28F4(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XWZX() => new Vector4U28F4(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XWZY() => new Vector4U28F4(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XWZZ() => new Vector4U28F4(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XWZW() => new Vector4U28F4(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XWWX() => new Vector4U28F4(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XWWY() => new Vector4U28F4(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XWWZ() => new Vector4U28F4(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 XWWW() => new Vector4U28F4(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YXXX() => new Vector4U28F4(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YXXY() => new Vector4U28F4(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YXXZ() => new Vector4U28F4(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YXXW() => new Vector4U28F4(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YXYX() => new Vector4U28F4(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YXYY() => new Vector4U28F4(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YXYZ() => new Vector4U28F4(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YXYW() => new Vector4U28F4(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YXZX() => new Vector4U28F4(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YXZY() => new Vector4U28F4(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YXZZ() => new Vector4U28F4(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YXZW() => new Vector4U28F4(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YXWX() => new Vector4U28F4(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YXWY() => new Vector4U28F4(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YXWZ() => new Vector4U28F4(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YXWW() => new Vector4U28F4(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YYXX() => new Vector4U28F4(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YYXY() => new Vector4U28F4(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YYXZ() => new Vector4U28F4(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YYXW() => new Vector4U28F4(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YYYX() => new Vector4U28F4(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YYYY() => new Vector4U28F4(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YYYZ() => new Vector4U28F4(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YYYW() => new Vector4U28F4(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YYZX() => new Vector4U28F4(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YYZY() => new Vector4U28F4(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YYZZ() => new Vector4U28F4(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YYZW() => new Vector4U28F4(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YYWX() => new Vector4U28F4(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YYWY() => new Vector4U28F4(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YYWZ() => new Vector4U28F4(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YYWW() => new Vector4U28F4(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YZXX() => new Vector4U28F4(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YZXY() => new Vector4U28F4(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YZXZ() => new Vector4U28F4(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YZXW() => new Vector4U28F4(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YZYX() => new Vector4U28F4(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YZYY() => new Vector4U28F4(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YZYZ() => new Vector4U28F4(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YZYW() => new Vector4U28F4(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YZZX() => new Vector4U28F4(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YZZY() => new Vector4U28F4(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YZZZ() => new Vector4U28F4(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YZZW() => new Vector4U28F4(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YZWX() => new Vector4U28F4(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YZWY() => new Vector4U28F4(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YZWZ() => new Vector4U28F4(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YZWW() => new Vector4U28F4(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YWXX() => new Vector4U28F4(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YWXY() => new Vector4U28F4(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YWXZ() => new Vector4U28F4(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YWXW() => new Vector4U28F4(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YWYX() => new Vector4U28F4(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YWYY() => new Vector4U28F4(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YWYZ() => new Vector4U28F4(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YWYW() => new Vector4U28F4(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YWZX() => new Vector4U28F4(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YWZY() => new Vector4U28F4(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YWZZ() => new Vector4U28F4(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YWZW() => new Vector4U28F4(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YWWX() => new Vector4U28F4(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YWWY() => new Vector4U28F4(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YWWZ() => new Vector4U28F4(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 YWWW() => new Vector4U28F4(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZXXX() => new Vector4U28F4(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZXXY() => new Vector4U28F4(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZXXZ() => new Vector4U28F4(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZXXW() => new Vector4U28F4(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZXYX() => new Vector4U28F4(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZXYY() => new Vector4U28F4(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZXYZ() => new Vector4U28F4(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZXYW() => new Vector4U28F4(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZXZX() => new Vector4U28F4(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZXZY() => new Vector4U28F4(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZXZZ() => new Vector4U28F4(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZXZW() => new Vector4U28F4(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZXWX() => new Vector4U28F4(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZXWY() => new Vector4U28F4(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZXWZ() => new Vector4U28F4(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZXWW() => new Vector4U28F4(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZYXX() => new Vector4U28F4(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZYXY() => new Vector4U28F4(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZYXZ() => new Vector4U28F4(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZYXW() => new Vector4U28F4(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZYYX() => new Vector4U28F4(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZYYY() => new Vector4U28F4(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZYYZ() => new Vector4U28F4(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZYYW() => new Vector4U28F4(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZYZX() => new Vector4U28F4(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZYZY() => new Vector4U28F4(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZYZZ() => new Vector4U28F4(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZYZW() => new Vector4U28F4(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZYWX() => new Vector4U28F4(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZYWY() => new Vector4U28F4(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZYWZ() => new Vector4U28F4(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZYWW() => new Vector4U28F4(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZZXX() => new Vector4U28F4(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZZXY() => new Vector4U28F4(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZZXZ() => new Vector4U28F4(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZZXW() => new Vector4U28F4(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZZYX() => new Vector4U28F4(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZZYY() => new Vector4U28F4(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZZYZ() => new Vector4U28F4(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZZYW() => new Vector4U28F4(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZZZX() => new Vector4U28F4(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZZZY() => new Vector4U28F4(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZZZZ() => new Vector4U28F4(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZZZW() => new Vector4U28F4(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZZWX() => new Vector4U28F4(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZZWY() => new Vector4U28F4(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZZWZ() => new Vector4U28F4(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZZWW() => new Vector4U28F4(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZWXX() => new Vector4U28F4(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZWXY() => new Vector4U28F4(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZWXZ() => new Vector4U28F4(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZWXW() => new Vector4U28F4(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZWYX() => new Vector4U28F4(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZWYY() => new Vector4U28F4(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZWYZ() => new Vector4U28F4(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZWYW() => new Vector4U28F4(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZWZX() => new Vector4U28F4(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZWZY() => new Vector4U28F4(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZWZZ() => new Vector4U28F4(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZWZW() => new Vector4U28F4(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZWWX() => new Vector4U28F4(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZWWY() => new Vector4U28F4(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZWWZ() => new Vector4U28F4(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 ZWWW() => new Vector4U28F4(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WXXX() => new Vector4U28F4(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WXXY() => new Vector4U28F4(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WXXZ() => new Vector4U28F4(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WXXW() => new Vector4U28F4(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WXYX() => new Vector4U28F4(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WXYY() => new Vector4U28F4(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WXYZ() => new Vector4U28F4(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WXYW() => new Vector4U28F4(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WXZX() => new Vector4U28F4(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WXZY() => new Vector4U28F4(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WXZZ() => new Vector4U28F4(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WXZW() => new Vector4U28F4(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WXWX() => new Vector4U28F4(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WXWY() => new Vector4U28F4(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WXWZ() => new Vector4U28F4(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WXWW() => new Vector4U28F4(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WYXX() => new Vector4U28F4(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WYXY() => new Vector4U28F4(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WYXZ() => new Vector4U28F4(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WYXW() => new Vector4U28F4(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WYYX() => new Vector4U28F4(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WYYY() => new Vector4U28F4(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WYYZ() => new Vector4U28F4(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WYYW() => new Vector4U28F4(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WYZX() => new Vector4U28F4(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WYZY() => new Vector4U28F4(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WYZZ() => new Vector4U28F4(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WYZW() => new Vector4U28F4(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WYWX() => new Vector4U28F4(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WYWY() => new Vector4U28F4(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WYWZ() => new Vector4U28F4(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WYWW() => new Vector4U28F4(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WZXX() => new Vector4U28F4(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WZXY() => new Vector4U28F4(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WZXZ() => new Vector4U28F4(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WZXW() => new Vector4U28F4(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WZYX() => new Vector4U28F4(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WZYY() => new Vector4U28F4(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WZYZ() => new Vector4U28F4(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WZYW() => new Vector4U28F4(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WZZX() => new Vector4U28F4(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WZZY() => new Vector4U28F4(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WZZZ() => new Vector4U28F4(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WZZW() => new Vector4U28F4(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WZWX() => new Vector4U28F4(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WZWY() => new Vector4U28F4(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WZWZ() => new Vector4U28F4(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WZWW() => new Vector4U28F4(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WWXX() => new Vector4U28F4(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WWXY() => new Vector4U28F4(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WWXZ() => new Vector4U28F4(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WWXW() => new Vector4U28F4(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WWYX() => new Vector4U28F4(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WWYY() => new Vector4U28F4(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WWYZ() => new Vector4U28F4(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WWYW() => new Vector4U28F4(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WWZX() => new Vector4U28F4(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WWZY() => new Vector4U28F4(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WWZZ() => new Vector4U28F4(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WWZW() => new Vector4U28F4(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WWWX() => new Vector4U28F4(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WWWY() => new Vector4U28F4(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WWWZ() => new Vector4U28F4(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U28F4 WWWW() => new Vector4U28F4(W, W, W, W);

    }
}
