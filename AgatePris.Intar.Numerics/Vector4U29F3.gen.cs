using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U29F3
    : IEquatable<Vector4U29F3>
    , IFormattable
    , IVector<U60F4, I60F4, U30F2, I30F2>
    , IVectorComponentRespective<U29F3> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U29F3 X;
        public U29F3 Y;
        public U29F3 Z;
        public U29F3 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(U29F3 x, U29F3 y, U29F3 z, U29F3 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(U29F3 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(U29F3 x, U29F3 y, Vector2U29F3 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(U29F3 x, Vector3U29F3 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(Vector2U29F3 xy, Vector2U29F3 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(Vector4U29F3 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(U29F3 x, Vector2U29F3 yz, U29F3 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(Vector3U29F3 xyz, U29F3 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3(Vector2U29F3 xy, U29F3 z, U29F3 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U29F3 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U29F3(U29F3.Zero);
        }
        public static Vector4U29F3 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U29F3(U29F3.One);
        }
        public static Vector4U29F3 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U29F3(U29F3.One, U29F3.Zero, U29F3.Zero, U29F3.Zero);
        }
        public static Vector4U29F3 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U29F3(U29F3.Zero, U29F3.One, U29F3.Zero, U29F3.Zero);
        }
        public static Vector4U29F3 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U29F3(U29F3.Zero, U29F3.Zero, U29F3.One, U29F3.Zero);
        }
        public static Vector4U29F3 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U29F3(U29F3.Zero, U29F3.Zero, U29F3.Zero, U29F3.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 operator +(Vector4U29F3 a, Vector4U29F3 b) => new Vector4U29F3(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 operator -(Vector4U29F3 a, Vector4U29F3 b) => new Vector4U29F3(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 operator *(Vector4U29F3 a, Vector4U29F3 b) => new Vector4U29F3(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 operator *(Vector4U29F3 a, U29F3 b) => new Vector4U29F3(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 operator *(U29F3 a, Vector4U29F3 b) => new Vector4U29F3(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 operator /(Vector4U29F3 a, Vector4U29F3 b) => new Vector4U29F3(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 operator /(Vector4U29F3 a, U29F3 b) => new Vector4U29F3(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U29F3 operator /(U29F3 a, Vector4U29F3 b) => new Vector4U29F3(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U29F3 lhs, Vector4U29F3 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U29F3 lhs, Vector4U29F3 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U29F3 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U29F3 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U29F3>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U29F3 other)
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
        public Vector4U29F3 Min(Vector4U29F3 other) => new Vector4U29F3(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3 Max(Vector4U29F3 other) => new Vector4U29F3(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3 Half() => new Vector4U29F3(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3 Twice() => new Vector4U29F3(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3 Clamp(U29F3 min, U29F3 max) => new Vector4U29F3(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3 Clamp(
            Vector4U29F3 min, Vector4U29F3 max
        ) => new Vector4U29F3(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3 WrappingAdd(Vector4U29F3 other) => new Vector4U29F3(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3 WrappingSub(Vector4U29F3 other) => new Vector4U29F3(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3 WrappingMul(Vector4U29F3 other) => new Vector4U29F3(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3 WrappingAddSigned(Vector4I29F3 other) => new Vector4U29F3(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3 SaturatingAdd(Vector4U29F3 other) => new Vector4U29F3(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3 SaturatingMul(U29F3 other) => new Vector4U29F3(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U29F3 other) {
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
        public U29F3 Dot(Vector4U29F3 other) {
            const ulong k = 1UL << 1;
            return U29F3.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U29F3 SaturatingDot(Vector4U29F3 other) {
            const ulong k = 1UL << 1;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U29F3.MaxValue;
            } else {
                return U29F3.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U60F4 LengthSquaredUnsigned() => U60F4.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I60F4 LengthSquaredSigned() => I60F4.FromBits(
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
        public U60F4 LengthSquared() => LengthSquaredUnsigned();

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
        public U29F3 LengthHalf() => U29F3.FromBits(LengthInternal());

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
        public I29F3 LengthHalfSigned() => I29F3.FromBits(checked((int)LengthInternal()));

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
        public U30F2 LengthUnsigned() => U30F2.FromBits(LengthInternal());

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
        public I30F2 LengthSigned() => I30F2.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U30F2 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U29F3? Normalize() {
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

            const ulong k = 1UL << 2;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U29F3(
                U29F3.FromBits(y0),
                U29F3.FromBits(y1),
                U29F3.FromBits(y2),
                U29F3.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U29F3 XX() => new Vector2U29F3(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U29F3 XY() => new Vector2U29F3(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U29F3 XZ() => new Vector2U29F3(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U29F3 XW() => new Vector2U29F3(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U29F3 YX() => new Vector2U29F3(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U29F3 YY() => new Vector2U29F3(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U29F3 YZ() => new Vector2U29F3(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U29F3 YW() => new Vector2U29F3(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U29F3 ZX() => new Vector2U29F3(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U29F3 ZY() => new Vector2U29F3(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U29F3 ZZ() => new Vector2U29F3(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U29F3 ZW() => new Vector2U29F3(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U29F3 WX() => new Vector2U29F3(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U29F3 WY() => new Vector2U29F3(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U29F3 WZ() => new Vector2U29F3(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U29F3 WW() => new Vector2U29F3(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 XXX() => new Vector3U29F3(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 XXY() => new Vector3U29F3(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 XXZ() => new Vector3U29F3(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 XXW() => new Vector3U29F3(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 XYX() => new Vector3U29F3(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 XYY() => new Vector3U29F3(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 XYZ() => new Vector3U29F3(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 XYW() => new Vector3U29F3(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 XZX() => new Vector3U29F3(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 XZY() => new Vector3U29F3(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 XZZ() => new Vector3U29F3(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 XZW() => new Vector3U29F3(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 XWX() => new Vector3U29F3(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 XWY() => new Vector3U29F3(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 XWZ() => new Vector3U29F3(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 XWW() => new Vector3U29F3(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 YXX() => new Vector3U29F3(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 YXY() => new Vector3U29F3(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 YXZ() => new Vector3U29F3(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 YXW() => new Vector3U29F3(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 YYX() => new Vector3U29F3(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 YYY() => new Vector3U29F3(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 YYZ() => new Vector3U29F3(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 YYW() => new Vector3U29F3(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 YZX() => new Vector3U29F3(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 YZY() => new Vector3U29F3(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 YZZ() => new Vector3U29F3(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 YZW() => new Vector3U29F3(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 YWX() => new Vector3U29F3(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 YWY() => new Vector3U29F3(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 YWZ() => new Vector3U29F3(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 YWW() => new Vector3U29F3(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 ZXX() => new Vector3U29F3(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 ZXY() => new Vector3U29F3(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 ZXZ() => new Vector3U29F3(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 ZXW() => new Vector3U29F3(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 ZYX() => new Vector3U29F3(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 ZYY() => new Vector3U29F3(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 ZYZ() => new Vector3U29F3(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 ZYW() => new Vector3U29F3(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 ZZX() => new Vector3U29F3(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 ZZY() => new Vector3U29F3(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 ZZZ() => new Vector3U29F3(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 ZZW() => new Vector3U29F3(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 ZWX() => new Vector3U29F3(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 ZWY() => new Vector3U29F3(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 ZWZ() => new Vector3U29F3(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 ZWW() => new Vector3U29F3(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 WXX() => new Vector3U29F3(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 WXY() => new Vector3U29F3(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 WXZ() => new Vector3U29F3(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 WXW() => new Vector3U29F3(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 WYX() => new Vector3U29F3(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 WYY() => new Vector3U29F3(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 WYZ() => new Vector3U29F3(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 WYW() => new Vector3U29F3(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 WZX() => new Vector3U29F3(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 WZY() => new Vector3U29F3(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 WZZ() => new Vector3U29F3(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 WZW() => new Vector3U29F3(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 WWX() => new Vector3U29F3(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 WWY() => new Vector3U29F3(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 WWZ() => new Vector3U29F3(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U29F3 WWW() => new Vector3U29F3(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XXXX() => new Vector4U29F3(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XXXY() => new Vector4U29F3(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XXXZ() => new Vector4U29F3(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XXXW() => new Vector4U29F3(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XXYX() => new Vector4U29F3(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XXYY() => new Vector4U29F3(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XXYZ() => new Vector4U29F3(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XXYW() => new Vector4U29F3(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XXZX() => new Vector4U29F3(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XXZY() => new Vector4U29F3(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XXZZ() => new Vector4U29F3(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XXZW() => new Vector4U29F3(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XXWX() => new Vector4U29F3(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XXWY() => new Vector4U29F3(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XXWZ() => new Vector4U29F3(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XXWW() => new Vector4U29F3(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XYXX() => new Vector4U29F3(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XYXY() => new Vector4U29F3(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XYXZ() => new Vector4U29F3(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XYXW() => new Vector4U29F3(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XYYX() => new Vector4U29F3(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XYYY() => new Vector4U29F3(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XYYZ() => new Vector4U29F3(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XYYW() => new Vector4U29F3(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XYZX() => new Vector4U29F3(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XYZY() => new Vector4U29F3(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XYZZ() => new Vector4U29F3(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XYZW() => new Vector4U29F3(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XYWX() => new Vector4U29F3(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XYWY() => new Vector4U29F3(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XYWZ() => new Vector4U29F3(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XYWW() => new Vector4U29F3(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XZXX() => new Vector4U29F3(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XZXY() => new Vector4U29F3(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XZXZ() => new Vector4U29F3(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XZXW() => new Vector4U29F3(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XZYX() => new Vector4U29F3(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XZYY() => new Vector4U29F3(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XZYZ() => new Vector4U29F3(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XZYW() => new Vector4U29F3(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XZZX() => new Vector4U29F3(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XZZY() => new Vector4U29F3(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XZZZ() => new Vector4U29F3(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XZZW() => new Vector4U29F3(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XZWX() => new Vector4U29F3(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XZWY() => new Vector4U29F3(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XZWZ() => new Vector4U29F3(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XZWW() => new Vector4U29F3(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XWXX() => new Vector4U29F3(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XWXY() => new Vector4U29F3(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XWXZ() => new Vector4U29F3(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XWXW() => new Vector4U29F3(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XWYX() => new Vector4U29F3(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XWYY() => new Vector4U29F3(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XWYZ() => new Vector4U29F3(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XWYW() => new Vector4U29F3(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XWZX() => new Vector4U29F3(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XWZY() => new Vector4U29F3(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XWZZ() => new Vector4U29F3(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XWZW() => new Vector4U29F3(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XWWX() => new Vector4U29F3(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XWWY() => new Vector4U29F3(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XWWZ() => new Vector4U29F3(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 XWWW() => new Vector4U29F3(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YXXX() => new Vector4U29F3(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YXXY() => new Vector4U29F3(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YXXZ() => new Vector4U29F3(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YXXW() => new Vector4U29F3(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YXYX() => new Vector4U29F3(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YXYY() => new Vector4U29F3(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YXYZ() => new Vector4U29F3(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YXYW() => new Vector4U29F3(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YXZX() => new Vector4U29F3(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YXZY() => new Vector4U29F3(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YXZZ() => new Vector4U29F3(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YXZW() => new Vector4U29F3(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YXWX() => new Vector4U29F3(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YXWY() => new Vector4U29F3(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YXWZ() => new Vector4U29F3(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YXWW() => new Vector4U29F3(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YYXX() => new Vector4U29F3(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YYXY() => new Vector4U29F3(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YYXZ() => new Vector4U29F3(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YYXW() => new Vector4U29F3(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YYYX() => new Vector4U29F3(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YYYY() => new Vector4U29F3(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YYYZ() => new Vector4U29F3(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YYYW() => new Vector4U29F3(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YYZX() => new Vector4U29F3(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YYZY() => new Vector4U29F3(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YYZZ() => new Vector4U29F3(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YYZW() => new Vector4U29F3(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YYWX() => new Vector4U29F3(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YYWY() => new Vector4U29F3(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YYWZ() => new Vector4U29F3(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YYWW() => new Vector4U29F3(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YZXX() => new Vector4U29F3(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YZXY() => new Vector4U29F3(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YZXZ() => new Vector4U29F3(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YZXW() => new Vector4U29F3(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YZYX() => new Vector4U29F3(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YZYY() => new Vector4U29F3(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YZYZ() => new Vector4U29F3(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YZYW() => new Vector4U29F3(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YZZX() => new Vector4U29F3(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YZZY() => new Vector4U29F3(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YZZZ() => new Vector4U29F3(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YZZW() => new Vector4U29F3(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YZWX() => new Vector4U29F3(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YZWY() => new Vector4U29F3(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YZWZ() => new Vector4U29F3(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YZWW() => new Vector4U29F3(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YWXX() => new Vector4U29F3(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YWXY() => new Vector4U29F3(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YWXZ() => new Vector4U29F3(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YWXW() => new Vector4U29F3(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YWYX() => new Vector4U29F3(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YWYY() => new Vector4U29F3(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YWYZ() => new Vector4U29F3(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YWYW() => new Vector4U29F3(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YWZX() => new Vector4U29F3(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YWZY() => new Vector4U29F3(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YWZZ() => new Vector4U29F3(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YWZW() => new Vector4U29F3(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YWWX() => new Vector4U29F3(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YWWY() => new Vector4U29F3(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YWWZ() => new Vector4U29F3(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 YWWW() => new Vector4U29F3(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZXXX() => new Vector4U29F3(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZXXY() => new Vector4U29F3(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZXXZ() => new Vector4U29F3(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZXXW() => new Vector4U29F3(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZXYX() => new Vector4U29F3(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZXYY() => new Vector4U29F3(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZXYZ() => new Vector4U29F3(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZXYW() => new Vector4U29F3(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZXZX() => new Vector4U29F3(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZXZY() => new Vector4U29F3(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZXZZ() => new Vector4U29F3(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZXZW() => new Vector4U29F3(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZXWX() => new Vector4U29F3(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZXWY() => new Vector4U29F3(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZXWZ() => new Vector4U29F3(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZXWW() => new Vector4U29F3(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZYXX() => new Vector4U29F3(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZYXY() => new Vector4U29F3(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZYXZ() => new Vector4U29F3(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZYXW() => new Vector4U29F3(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZYYX() => new Vector4U29F3(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZYYY() => new Vector4U29F3(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZYYZ() => new Vector4U29F3(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZYYW() => new Vector4U29F3(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZYZX() => new Vector4U29F3(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZYZY() => new Vector4U29F3(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZYZZ() => new Vector4U29F3(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZYZW() => new Vector4U29F3(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZYWX() => new Vector4U29F3(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZYWY() => new Vector4U29F3(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZYWZ() => new Vector4U29F3(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZYWW() => new Vector4U29F3(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZZXX() => new Vector4U29F3(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZZXY() => new Vector4U29F3(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZZXZ() => new Vector4U29F3(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZZXW() => new Vector4U29F3(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZZYX() => new Vector4U29F3(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZZYY() => new Vector4U29F3(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZZYZ() => new Vector4U29F3(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZZYW() => new Vector4U29F3(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZZZX() => new Vector4U29F3(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZZZY() => new Vector4U29F3(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZZZZ() => new Vector4U29F3(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZZZW() => new Vector4U29F3(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZZWX() => new Vector4U29F3(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZZWY() => new Vector4U29F3(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZZWZ() => new Vector4U29F3(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZZWW() => new Vector4U29F3(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZWXX() => new Vector4U29F3(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZWXY() => new Vector4U29F3(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZWXZ() => new Vector4U29F3(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZWXW() => new Vector4U29F3(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZWYX() => new Vector4U29F3(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZWYY() => new Vector4U29F3(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZWYZ() => new Vector4U29F3(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZWYW() => new Vector4U29F3(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZWZX() => new Vector4U29F3(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZWZY() => new Vector4U29F3(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZWZZ() => new Vector4U29F3(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZWZW() => new Vector4U29F3(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZWWX() => new Vector4U29F3(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZWWY() => new Vector4U29F3(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZWWZ() => new Vector4U29F3(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 ZWWW() => new Vector4U29F3(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WXXX() => new Vector4U29F3(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WXXY() => new Vector4U29F3(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WXXZ() => new Vector4U29F3(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WXXW() => new Vector4U29F3(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WXYX() => new Vector4U29F3(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WXYY() => new Vector4U29F3(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WXYZ() => new Vector4U29F3(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WXYW() => new Vector4U29F3(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WXZX() => new Vector4U29F3(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WXZY() => new Vector4U29F3(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WXZZ() => new Vector4U29F3(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WXZW() => new Vector4U29F3(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WXWX() => new Vector4U29F3(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WXWY() => new Vector4U29F3(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WXWZ() => new Vector4U29F3(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WXWW() => new Vector4U29F3(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WYXX() => new Vector4U29F3(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WYXY() => new Vector4U29F3(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WYXZ() => new Vector4U29F3(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WYXW() => new Vector4U29F3(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WYYX() => new Vector4U29F3(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WYYY() => new Vector4U29F3(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WYYZ() => new Vector4U29F3(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WYYW() => new Vector4U29F3(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WYZX() => new Vector4U29F3(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WYZY() => new Vector4U29F3(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WYZZ() => new Vector4U29F3(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WYZW() => new Vector4U29F3(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WYWX() => new Vector4U29F3(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WYWY() => new Vector4U29F3(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WYWZ() => new Vector4U29F3(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WYWW() => new Vector4U29F3(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WZXX() => new Vector4U29F3(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WZXY() => new Vector4U29F3(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WZXZ() => new Vector4U29F3(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WZXW() => new Vector4U29F3(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WZYX() => new Vector4U29F3(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WZYY() => new Vector4U29F3(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WZYZ() => new Vector4U29F3(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WZYW() => new Vector4U29F3(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WZZX() => new Vector4U29F3(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WZZY() => new Vector4U29F3(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WZZZ() => new Vector4U29F3(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WZZW() => new Vector4U29F3(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WZWX() => new Vector4U29F3(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WZWY() => new Vector4U29F3(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WZWZ() => new Vector4U29F3(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WZWW() => new Vector4U29F3(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WWXX() => new Vector4U29F3(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WWXY() => new Vector4U29F3(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WWXZ() => new Vector4U29F3(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WWXW() => new Vector4U29F3(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WWYX() => new Vector4U29F3(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WWYY() => new Vector4U29F3(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WWYZ() => new Vector4U29F3(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WWYW() => new Vector4U29F3(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WWZX() => new Vector4U29F3(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WWZY() => new Vector4U29F3(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WWZZ() => new Vector4U29F3(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WWZW() => new Vector4U29F3(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WWWX() => new Vector4U29F3(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WWWY() => new Vector4U29F3(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WWWZ() => new Vector4U29F3(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U29F3 WWWW() => new Vector4U29F3(W, W, W, W);

    }
}
