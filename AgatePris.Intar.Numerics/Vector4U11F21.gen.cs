using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U11F21
    : IEquatable<Vector4U11F21>
    , IFormattable
    , IVector<U24F40, I24F40, U12F20, I12F20>
    , IVectorComponentRespective<U11F21> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U11F21 X;
        public U11F21 Y;
        public U11F21 Z;
        public U11F21 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(U11F21 x, U11F21 y, U11F21 z, U11F21 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(U11F21 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(U11F21 x, U11F21 y, Vector2U11F21 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(U11F21 x, Vector3U11F21 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(Vector2U11F21 xy, Vector2U11F21 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(Vector4U11F21 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(U11F21 x, Vector2U11F21 yz, U11F21 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(Vector3U11F21 xyz, U11F21 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21(Vector2U11F21 xy, U11F21 z, U11F21 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U11F21 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U11F21(U11F21.Zero);
        }
        public static Vector4U11F21 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U11F21(U11F21.One);
        }
        public static Vector4U11F21 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U11F21(U11F21.One, U11F21.Zero, U11F21.Zero, U11F21.Zero);
        }
        public static Vector4U11F21 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U11F21(U11F21.Zero, U11F21.One, U11F21.Zero, U11F21.Zero);
        }
        public static Vector4U11F21 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U11F21(U11F21.Zero, U11F21.Zero, U11F21.One, U11F21.Zero);
        }
        public static Vector4U11F21 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U11F21(U11F21.Zero, U11F21.Zero, U11F21.Zero, U11F21.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 operator +(Vector4U11F21 a, Vector4U11F21 b) => new Vector4U11F21(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 operator -(Vector4U11F21 a, Vector4U11F21 b) => new Vector4U11F21(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 operator *(Vector4U11F21 a, Vector4U11F21 b) => new Vector4U11F21(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 operator *(Vector4U11F21 a, U11F21 b) => new Vector4U11F21(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 operator *(U11F21 a, Vector4U11F21 b) => new Vector4U11F21(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 operator /(Vector4U11F21 a, Vector4U11F21 b) => new Vector4U11F21(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 operator /(Vector4U11F21 a, U11F21 b) => new Vector4U11F21(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U11F21 operator /(U11F21 a, Vector4U11F21 b) => new Vector4U11F21(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U11F21 lhs, Vector4U11F21 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U11F21 lhs, Vector4U11F21 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U11F21 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U11F21 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U11F21>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U11F21 other)
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
        public Vector4U11F21 Min(Vector4U11F21 other) => new Vector4U11F21(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 Max(Vector4U11F21 other) => new Vector4U11F21(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 Half() => new Vector4U11F21(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 Twice() => new Vector4U11F21(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 Clamp(U11F21 min, U11F21 max) => new Vector4U11F21(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 Clamp(
            Vector4U11F21 min, Vector4U11F21 max
        ) => new Vector4U11F21(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 WrappingAdd(Vector4U11F21 other) => new Vector4U11F21(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 WrappingSub(Vector4U11F21 other) => new Vector4U11F21(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 WrappingMul(Vector4U11F21 other) => new Vector4U11F21(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 WrappingAddSigned(Vector4I11F21 other) => new Vector4U11F21(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 SaturatingAdd(Vector4U11F21 other) => new Vector4U11F21(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21 SaturatingMul(U11F21 other) => new Vector4U11F21(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U11F21 other) {
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
        public U11F21 Dot(Vector4U11F21 other) {
            const ulong k = 1UL << 19;
            return U11F21.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U11F21 SaturatingDot(Vector4U11F21 other) {
            const ulong k = 1UL << 19;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U11F21.MaxValue;
            } else {
                return U11F21.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U24F40 LengthSquaredUnsigned() => U24F40.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I24F40 LengthSquaredSigned() => I24F40.FromBits(
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
        public U24F40 LengthSquared() => LengthSquaredUnsigned();

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
        public U11F21 LengthHalf() => U11F21.FromBits(LengthInternal());

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
        public I11F21 LengthHalfSigned() => I11F21.FromBits(checked((int)LengthInternal()));

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
        public U12F20 LengthUnsigned() => U12F20.FromBits(LengthInternal());

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
        public I12F20 LengthSigned() => I12F20.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U12F20 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U11F21? Normalize() {
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

            const ulong k = 1UL << 20;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U11F21(
                U11F21.FromBits(y0),
                U11F21.FromBits(y1),
                U11F21.FromBits(y2),
                U11F21.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U11F21 XX() => new Vector2U11F21(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U11F21 XY() => new Vector2U11F21(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U11F21 XZ() => new Vector2U11F21(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U11F21 XW() => new Vector2U11F21(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U11F21 YX() => new Vector2U11F21(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U11F21 YY() => new Vector2U11F21(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U11F21 YZ() => new Vector2U11F21(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U11F21 YW() => new Vector2U11F21(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U11F21 ZX() => new Vector2U11F21(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U11F21 ZY() => new Vector2U11F21(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U11F21 ZZ() => new Vector2U11F21(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U11F21 ZW() => new Vector2U11F21(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U11F21 WX() => new Vector2U11F21(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U11F21 WY() => new Vector2U11F21(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U11F21 WZ() => new Vector2U11F21(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U11F21 WW() => new Vector2U11F21(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 XXX() => new Vector3U11F21(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 XXY() => new Vector3U11F21(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 XXZ() => new Vector3U11F21(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 XXW() => new Vector3U11F21(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 XYX() => new Vector3U11F21(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 XYY() => new Vector3U11F21(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 XYZ() => new Vector3U11F21(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 XYW() => new Vector3U11F21(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 XZX() => new Vector3U11F21(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 XZY() => new Vector3U11F21(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 XZZ() => new Vector3U11F21(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 XZW() => new Vector3U11F21(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 XWX() => new Vector3U11F21(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 XWY() => new Vector3U11F21(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 XWZ() => new Vector3U11F21(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 XWW() => new Vector3U11F21(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 YXX() => new Vector3U11F21(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 YXY() => new Vector3U11F21(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 YXZ() => new Vector3U11F21(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 YXW() => new Vector3U11F21(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 YYX() => new Vector3U11F21(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 YYY() => new Vector3U11F21(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 YYZ() => new Vector3U11F21(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 YYW() => new Vector3U11F21(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 YZX() => new Vector3U11F21(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 YZY() => new Vector3U11F21(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 YZZ() => new Vector3U11F21(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 YZW() => new Vector3U11F21(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 YWX() => new Vector3U11F21(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 YWY() => new Vector3U11F21(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 YWZ() => new Vector3U11F21(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 YWW() => new Vector3U11F21(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 ZXX() => new Vector3U11F21(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 ZXY() => new Vector3U11F21(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 ZXZ() => new Vector3U11F21(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 ZXW() => new Vector3U11F21(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 ZYX() => new Vector3U11F21(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 ZYY() => new Vector3U11F21(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 ZYZ() => new Vector3U11F21(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 ZYW() => new Vector3U11F21(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 ZZX() => new Vector3U11F21(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 ZZY() => new Vector3U11F21(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 ZZZ() => new Vector3U11F21(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 ZZW() => new Vector3U11F21(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 ZWX() => new Vector3U11F21(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 ZWY() => new Vector3U11F21(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 ZWZ() => new Vector3U11F21(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 ZWW() => new Vector3U11F21(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 WXX() => new Vector3U11F21(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 WXY() => new Vector3U11F21(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 WXZ() => new Vector3U11F21(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 WXW() => new Vector3U11F21(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 WYX() => new Vector3U11F21(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 WYY() => new Vector3U11F21(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 WYZ() => new Vector3U11F21(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 WYW() => new Vector3U11F21(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 WZX() => new Vector3U11F21(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 WZY() => new Vector3U11F21(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 WZZ() => new Vector3U11F21(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 WZW() => new Vector3U11F21(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 WWX() => new Vector3U11F21(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 WWY() => new Vector3U11F21(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 WWZ() => new Vector3U11F21(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U11F21 WWW() => new Vector3U11F21(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XXXX() => new Vector4U11F21(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XXXY() => new Vector4U11F21(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XXXZ() => new Vector4U11F21(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XXXW() => new Vector4U11F21(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XXYX() => new Vector4U11F21(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XXYY() => new Vector4U11F21(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XXYZ() => new Vector4U11F21(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XXYW() => new Vector4U11F21(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XXZX() => new Vector4U11F21(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XXZY() => new Vector4U11F21(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XXZZ() => new Vector4U11F21(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XXZW() => new Vector4U11F21(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XXWX() => new Vector4U11F21(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XXWY() => new Vector4U11F21(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XXWZ() => new Vector4U11F21(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XXWW() => new Vector4U11F21(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XYXX() => new Vector4U11F21(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XYXY() => new Vector4U11F21(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XYXZ() => new Vector4U11F21(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XYXW() => new Vector4U11F21(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XYYX() => new Vector4U11F21(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XYYY() => new Vector4U11F21(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XYYZ() => new Vector4U11F21(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XYYW() => new Vector4U11F21(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XYZX() => new Vector4U11F21(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XYZY() => new Vector4U11F21(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XYZZ() => new Vector4U11F21(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XYZW() => new Vector4U11F21(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XYWX() => new Vector4U11F21(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XYWY() => new Vector4U11F21(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XYWZ() => new Vector4U11F21(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XYWW() => new Vector4U11F21(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XZXX() => new Vector4U11F21(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XZXY() => new Vector4U11F21(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XZXZ() => new Vector4U11F21(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XZXW() => new Vector4U11F21(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XZYX() => new Vector4U11F21(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XZYY() => new Vector4U11F21(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XZYZ() => new Vector4U11F21(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XZYW() => new Vector4U11F21(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XZZX() => new Vector4U11F21(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XZZY() => new Vector4U11F21(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XZZZ() => new Vector4U11F21(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XZZW() => new Vector4U11F21(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XZWX() => new Vector4U11F21(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XZWY() => new Vector4U11F21(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XZWZ() => new Vector4U11F21(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XZWW() => new Vector4U11F21(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XWXX() => new Vector4U11F21(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XWXY() => new Vector4U11F21(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XWXZ() => new Vector4U11F21(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XWXW() => new Vector4U11F21(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XWYX() => new Vector4U11F21(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XWYY() => new Vector4U11F21(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XWYZ() => new Vector4U11F21(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XWYW() => new Vector4U11F21(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XWZX() => new Vector4U11F21(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XWZY() => new Vector4U11F21(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XWZZ() => new Vector4U11F21(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XWZW() => new Vector4U11F21(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XWWX() => new Vector4U11F21(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XWWY() => new Vector4U11F21(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XWWZ() => new Vector4U11F21(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 XWWW() => new Vector4U11F21(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YXXX() => new Vector4U11F21(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YXXY() => new Vector4U11F21(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YXXZ() => new Vector4U11F21(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YXXW() => new Vector4U11F21(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YXYX() => new Vector4U11F21(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YXYY() => new Vector4U11F21(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YXYZ() => new Vector4U11F21(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YXYW() => new Vector4U11F21(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YXZX() => new Vector4U11F21(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YXZY() => new Vector4U11F21(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YXZZ() => new Vector4U11F21(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YXZW() => new Vector4U11F21(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YXWX() => new Vector4U11F21(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YXWY() => new Vector4U11F21(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YXWZ() => new Vector4U11F21(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YXWW() => new Vector4U11F21(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YYXX() => new Vector4U11F21(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YYXY() => new Vector4U11F21(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YYXZ() => new Vector4U11F21(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YYXW() => new Vector4U11F21(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YYYX() => new Vector4U11F21(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YYYY() => new Vector4U11F21(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YYYZ() => new Vector4U11F21(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YYYW() => new Vector4U11F21(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YYZX() => new Vector4U11F21(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YYZY() => new Vector4U11F21(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YYZZ() => new Vector4U11F21(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YYZW() => new Vector4U11F21(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YYWX() => new Vector4U11F21(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YYWY() => new Vector4U11F21(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YYWZ() => new Vector4U11F21(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YYWW() => new Vector4U11F21(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YZXX() => new Vector4U11F21(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YZXY() => new Vector4U11F21(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YZXZ() => new Vector4U11F21(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YZXW() => new Vector4U11F21(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YZYX() => new Vector4U11F21(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YZYY() => new Vector4U11F21(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YZYZ() => new Vector4U11F21(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YZYW() => new Vector4U11F21(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YZZX() => new Vector4U11F21(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YZZY() => new Vector4U11F21(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YZZZ() => new Vector4U11F21(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YZZW() => new Vector4U11F21(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YZWX() => new Vector4U11F21(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YZWY() => new Vector4U11F21(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YZWZ() => new Vector4U11F21(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YZWW() => new Vector4U11F21(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YWXX() => new Vector4U11F21(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YWXY() => new Vector4U11F21(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YWXZ() => new Vector4U11F21(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YWXW() => new Vector4U11F21(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YWYX() => new Vector4U11F21(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YWYY() => new Vector4U11F21(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YWYZ() => new Vector4U11F21(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YWYW() => new Vector4U11F21(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YWZX() => new Vector4U11F21(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YWZY() => new Vector4U11F21(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YWZZ() => new Vector4U11F21(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YWZW() => new Vector4U11F21(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YWWX() => new Vector4U11F21(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YWWY() => new Vector4U11F21(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YWWZ() => new Vector4U11F21(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 YWWW() => new Vector4U11F21(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZXXX() => new Vector4U11F21(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZXXY() => new Vector4U11F21(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZXXZ() => new Vector4U11F21(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZXXW() => new Vector4U11F21(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZXYX() => new Vector4U11F21(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZXYY() => new Vector4U11F21(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZXYZ() => new Vector4U11F21(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZXYW() => new Vector4U11F21(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZXZX() => new Vector4U11F21(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZXZY() => new Vector4U11F21(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZXZZ() => new Vector4U11F21(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZXZW() => new Vector4U11F21(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZXWX() => new Vector4U11F21(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZXWY() => new Vector4U11F21(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZXWZ() => new Vector4U11F21(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZXWW() => new Vector4U11F21(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZYXX() => new Vector4U11F21(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZYXY() => new Vector4U11F21(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZYXZ() => new Vector4U11F21(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZYXW() => new Vector4U11F21(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZYYX() => new Vector4U11F21(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZYYY() => new Vector4U11F21(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZYYZ() => new Vector4U11F21(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZYYW() => new Vector4U11F21(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZYZX() => new Vector4U11F21(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZYZY() => new Vector4U11F21(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZYZZ() => new Vector4U11F21(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZYZW() => new Vector4U11F21(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZYWX() => new Vector4U11F21(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZYWY() => new Vector4U11F21(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZYWZ() => new Vector4U11F21(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZYWW() => new Vector4U11F21(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZZXX() => new Vector4U11F21(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZZXY() => new Vector4U11F21(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZZXZ() => new Vector4U11F21(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZZXW() => new Vector4U11F21(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZZYX() => new Vector4U11F21(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZZYY() => new Vector4U11F21(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZZYZ() => new Vector4U11F21(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZZYW() => new Vector4U11F21(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZZZX() => new Vector4U11F21(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZZZY() => new Vector4U11F21(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZZZZ() => new Vector4U11F21(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZZZW() => new Vector4U11F21(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZZWX() => new Vector4U11F21(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZZWY() => new Vector4U11F21(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZZWZ() => new Vector4U11F21(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZZWW() => new Vector4U11F21(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZWXX() => new Vector4U11F21(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZWXY() => new Vector4U11F21(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZWXZ() => new Vector4U11F21(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZWXW() => new Vector4U11F21(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZWYX() => new Vector4U11F21(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZWYY() => new Vector4U11F21(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZWYZ() => new Vector4U11F21(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZWYW() => new Vector4U11F21(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZWZX() => new Vector4U11F21(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZWZY() => new Vector4U11F21(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZWZZ() => new Vector4U11F21(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZWZW() => new Vector4U11F21(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZWWX() => new Vector4U11F21(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZWWY() => new Vector4U11F21(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZWWZ() => new Vector4U11F21(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 ZWWW() => new Vector4U11F21(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WXXX() => new Vector4U11F21(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WXXY() => new Vector4U11F21(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WXXZ() => new Vector4U11F21(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WXXW() => new Vector4U11F21(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WXYX() => new Vector4U11F21(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WXYY() => new Vector4U11F21(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WXYZ() => new Vector4U11F21(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WXYW() => new Vector4U11F21(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WXZX() => new Vector4U11F21(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WXZY() => new Vector4U11F21(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WXZZ() => new Vector4U11F21(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WXZW() => new Vector4U11F21(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WXWX() => new Vector4U11F21(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WXWY() => new Vector4U11F21(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WXWZ() => new Vector4U11F21(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WXWW() => new Vector4U11F21(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WYXX() => new Vector4U11F21(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WYXY() => new Vector4U11F21(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WYXZ() => new Vector4U11F21(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WYXW() => new Vector4U11F21(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WYYX() => new Vector4U11F21(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WYYY() => new Vector4U11F21(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WYYZ() => new Vector4U11F21(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WYYW() => new Vector4U11F21(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WYZX() => new Vector4U11F21(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WYZY() => new Vector4U11F21(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WYZZ() => new Vector4U11F21(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WYZW() => new Vector4U11F21(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WYWX() => new Vector4U11F21(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WYWY() => new Vector4U11F21(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WYWZ() => new Vector4U11F21(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WYWW() => new Vector4U11F21(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WZXX() => new Vector4U11F21(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WZXY() => new Vector4U11F21(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WZXZ() => new Vector4U11F21(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WZXW() => new Vector4U11F21(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WZYX() => new Vector4U11F21(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WZYY() => new Vector4U11F21(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WZYZ() => new Vector4U11F21(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WZYW() => new Vector4U11F21(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WZZX() => new Vector4U11F21(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WZZY() => new Vector4U11F21(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WZZZ() => new Vector4U11F21(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WZZW() => new Vector4U11F21(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WZWX() => new Vector4U11F21(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WZWY() => new Vector4U11F21(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WZWZ() => new Vector4U11F21(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WZWW() => new Vector4U11F21(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WWXX() => new Vector4U11F21(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WWXY() => new Vector4U11F21(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WWXZ() => new Vector4U11F21(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WWXW() => new Vector4U11F21(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WWYX() => new Vector4U11F21(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WWYY() => new Vector4U11F21(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WWYZ() => new Vector4U11F21(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WWYW() => new Vector4U11F21(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WWZX() => new Vector4U11F21(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WWZY() => new Vector4U11F21(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WWZZ() => new Vector4U11F21(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WWZW() => new Vector4U11F21(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WWWX() => new Vector4U11F21(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WWWY() => new Vector4U11F21(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WWWZ() => new Vector4U11F21(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U11F21 WWWW() => new Vector4U11F21(W, W, W, W);

    }
}
