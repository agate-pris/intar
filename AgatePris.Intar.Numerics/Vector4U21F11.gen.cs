using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U21F11
    : IEquatable<Vector4U21F11>
    , IFormattable
    , IVector<U44F20, I44F20, U22F10, I22F10>
    , IVectorComponentRespective<U21F11> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U21F11 X;
        public U21F11 Y;
        public U21F11 Z;
        public U21F11 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(U21F11 x, U21F11 y, U21F11 z, U21F11 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(U21F11 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(U21F11 x, U21F11 y, Vector2U21F11 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(U21F11 x, Vector3U21F11 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(Vector2U21F11 xy, Vector2U21F11 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(Vector4U21F11 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(U21F11 x, Vector2U21F11 yz, U21F11 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(Vector3U21F11 xyz, U21F11 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11(Vector2U21F11 xy, U21F11 z, U21F11 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U21F11 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U21F11(U21F11.Zero);
        }
        public static Vector4U21F11 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U21F11(U21F11.One);
        }
        public static Vector4U21F11 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U21F11(U21F11.One, U21F11.Zero, U21F11.Zero, U21F11.Zero);
        }
        public static Vector4U21F11 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U21F11(U21F11.Zero, U21F11.One, U21F11.Zero, U21F11.Zero);
        }
        public static Vector4U21F11 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U21F11(U21F11.Zero, U21F11.Zero, U21F11.One, U21F11.Zero);
        }
        public static Vector4U21F11 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U21F11(U21F11.Zero, U21F11.Zero, U21F11.Zero, U21F11.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator +(Vector4U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator -(Vector4U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator *(Vector4U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator *(Vector4U21F11 a, U21F11 b) => new Vector4U21F11(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator *(U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator /(Vector4U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator /(Vector4U21F11 a, U21F11 b) => new Vector4U21F11(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U21F11 operator /(U21F11 a, Vector4U21F11 b) => new Vector4U21F11(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U21F11 lhs, Vector4U21F11 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U21F11 lhs, Vector4U21F11 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U21F11 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U21F11 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U21F11>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U21F11 other)
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
        public Vector4U21F11 Min(Vector4U21F11 other) => new Vector4U21F11(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 Max(Vector4U21F11 other) => new Vector4U21F11(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 Half() => new Vector4U21F11(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 Twice() => new Vector4U21F11(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 Clamp(U21F11 min, U21F11 max) => new Vector4U21F11(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 Clamp(
            Vector4U21F11 min, Vector4U21F11 max
        ) => new Vector4U21F11(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 WrappingAdd(Vector4U21F11 other) => new Vector4U21F11(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 WrappingSub(Vector4U21F11 other) => new Vector4U21F11(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 WrappingMul(Vector4U21F11 other) => new Vector4U21F11(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 WrappingAddSigned(Vector4I21F11 other) => new Vector4U21F11(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 SaturatingAdd(Vector4U21F11 other) => new Vector4U21F11(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11 SaturatingMul(U21F11 other) => new Vector4U21F11(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U21F11 other) {
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
        public U21F11 Dot(Vector4U21F11 other) {
            const ulong k = 1UL << 9;
            return U21F11.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U21F11 SaturatingDot(Vector4U21F11 other) {
            const ulong k = 1UL << 9;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U21F11.MaxValue;
            } else {
                return U21F11.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U44F20 LengthSquaredUnsigned() => U44F20.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I44F20 LengthSquaredSigned() => I44F20.FromBits(
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
        public U44F20 LengthSquared() => LengthSquaredUnsigned();

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
        public U21F11 LengthHalf() => U21F11.FromBits(LengthInternal());

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
        public I21F11 LengthHalfSigned() => I21F11.FromBits(checked((int)LengthInternal()));

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
        public U22F10 LengthUnsigned() => U22F10.FromBits(LengthInternal());

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
        public I22F10 LengthSigned() => I22F10.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U22F10 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U21F11? Normalize() {
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

            const ulong k = 1UL << 10;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U21F11(
                U21F11.FromBits(y0),
                U21F11.FromBits(y1),
                U21F11.FromBits(y2),
                U21F11.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 XX() => new Vector2U21F11(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 XY() => new Vector2U21F11(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 XZ() => new Vector2U21F11(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 XW() => new Vector2U21F11(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 YX() => new Vector2U21F11(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 YY() => new Vector2U21F11(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 YZ() => new Vector2U21F11(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 YW() => new Vector2U21F11(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 ZX() => new Vector2U21F11(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 ZY() => new Vector2U21F11(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 ZZ() => new Vector2U21F11(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 ZW() => new Vector2U21F11(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 WX() => new Vector2U21F11(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 WY() => new Vector2U21F11(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 WZ() => new Vector2U21F11(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 WW() => new Vector2U21F11(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XXX() => new Vector3U21F11(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XXY() => new Vector3U21F11(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XXZ() => new Vector3U21F11(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XXW() => new Vector3U21F11(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XYX() => new Vector3U21F11(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XYY() => new Vector3U21F11(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XYZ() => new Vector3U21F11(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XYW() => new Vector3U21F11(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XZX() => new Vector3U21F11(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XZY() => new Vector3U21F11(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XZZ() => new Vector3U21F11(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XZW() => new Vector3U21F11(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XWX() => new Vector3U21F11(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XWY() => new Vector3U21F11(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XWZ() => new Vector3U21F11(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XWW() => new Vector3U21F11(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YXX() => new Vector3U21F11(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YXY() => new Vector3U21F11(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YXZ() => new Vector3U21F11(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YXW() => new Vector3U21F11(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YYX() => new Vector3U21F11(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YYY() => new Vector3U21F11(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YYZ() => new Vector3U21F11(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YYW() => new Vector3U21F11(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YZX() => new Vector3U21F11(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YZY() => new Vector3U21F11(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YZZ() => new Vector3U21F11(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YZW() => new Vector3U21F11(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YWX() => new Vector3U21F11(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YWY() => new Vector3U21F11(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YWZ() => new Vector3U21F11(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YWW() => new Vector3U21F11(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZXX() => new Vector3U21F11(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZXY() => new Vector3U21F11(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZXZ() => new Vector3U21F11(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZXW() => new Vector3U21F11(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZYX() => new Vector3U21F11(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZYY() => new Vector3U21F11(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZYZ() => new Vector3U21F11(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZYW() => new Vector3U21F11(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZZX() => new Vector3U21F11(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZZY() => new Vector3U21F11(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZZZ() => new Vector3U21F11(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZZW() => new Vector3U21F11(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZWX() => new Vector3U21F11(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZWY() => new Vector3U21F11(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZWZ() => new Vector3U21F11(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZWW() => new Vector3U21F11(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 WXX() => new Vector3U21F11(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 WXY() => new Vector3U21F11(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 WXZ() => new Vector3U21F11(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 WXW() => new Vector3U21F11(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 WYX() => new Vector3U21F11(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 WYY() => new Vector3U21F11(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 WYZ() => new Vector3U21F11(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 WYW() => new Vector3U21F11(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 WZX() => new Vector3U21F11(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 WZY() => new Vector3U21F11(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 WZZ() => new Vector3U21F11(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 WZW() => new Vector3U21F11(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 WWX() => new Vector3U21F11(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 WWY() => new Vector3U21F11(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 WWZ() => new Vector3U21F11(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 WWW() => new Vector3U21F11(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXXX() => new Vector4U21F11(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXXY() => new Vector4U21F11(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXXZ() => new Vector4U21F11(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXXW() => new Vector4U21F11(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXYX() => new Vector4U21F11(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXYY() => new Vector4U21F11(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXYZ() => new Vector4U21F11(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXYW() => new Vector4U21F11(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXZX() => new Vector4U21F11(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXZY() => new Vector4U21F11(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXZZ() => new Vector4U21F11(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXZW() => new Vector4U21F11(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXWX() => new Vector4U21F11(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXWY() => new Vector4U21F11(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXWZ() => new Vector4U21F11(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXWW() => new Vector4U21F11(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYXX() => new Vector4U21F11(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYXY() => new Vector4U21F11(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYXZ() => new Vector4U21F11(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYXW() => new Vector4U21F11(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYYX() => new Vector4U21F11(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYYY() => new Vector4U21F11(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYYZ() => new Vector4U21F11(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYYW() => new Vector4U21F11(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYZX() => new Vector4U21F11(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYZY() => new Vector4U21F11(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYZZ() => new Vector4U21F11(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYZW() => new Vector4U21F11(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYWX() => new Vector4U21F11(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYWY() => new Vector4U21F11(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYWZ() => new Vector4U21F11(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYWW() => new Vector4U21F11(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZXX() => new Vector4U21F11(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZXY() => new Vector4U21F11(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZXZ() => new Vector4U21F11(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZXW() => new Vector4U21F11(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZYX() => new Vector4U21F11(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZYY() => new Vector4U21F11(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZYZ() => new Vector4U21F11(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZYW() => new Vector4U21F11(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZZX() => new Vector4U21F11(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZZY() => new Vector4U21F11(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZZZ() => new Vector4U21F11(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZZW() => new Vector4U21F11(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZWX() => new Vector4U21F11(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZWY() => new Vector4U21F11(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZWZ() => new Vector4U21F11(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZWW() => new Vector4U21F11(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XWXX() => new Vector4U21F11(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XWXY() => new Vector4U21F11(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XWXZ() => new Vector4U21F11(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XWXW() => new Vector4U21F11(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XWYX() => new Vector4U21F11(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XWYY() => new Vector4U21F11(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XWYZ() => new Vector4U21F11(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XWYW() => new Vector4U21F11(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XWZX() => new Vector4U21F11(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XWZY() => new Vector4U21F11(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XWZZ() => new Vector4U21F11(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XWZW() => new Vector4U21F11(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XWWX() => new Vector4U21F11(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XWWY() => new Vector4U21F11(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XWWZ() => new Vector4U21F11(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XWWW() => new Vector4U21F11(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXXX() => new Vector4U21F11(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXXY() => new Vector4U21F11(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXXZ() => new Vector4U21F11(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXXW() => new Vector4U21F11(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXYX() => new Vector4U21F11(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXYY() => new Vector4U21F11(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXYZ() => new Vector4U21F11(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXYW() => new Vector4U21F11(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXZX() => new Vector4U21F11(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXZY() => new Vector4U21F11(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXZZ() => new Vector4U21F11(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXZW() => new Vector4U21F11(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXWX() => new Vector4U21F11(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXWY() => new Vector4U21F11(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXWZ() => new Vector4U21F11(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXWW() => new Vector4U21F11(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYXX() => new Vector4U21F11(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYXY() => new Vector4U21F11(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYXZ() => new Vector4U21F11(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYXW() => new Vector4U21F11(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYYX() => new Vector4U21F11(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYYY() => new Vector4U21F11(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYYZ() => new Vector4U21F11(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYYW() => new Vector4U21F11(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYZX() => new Vector4U21F11(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYZY() => new Vector4U21F11(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYZZ() => new Vector4U21F11(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYZW() => new Vector4U21F11(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYWX() => new Vector4U21F11(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYWY() => new Vector4U21F11(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYWZ() => new Vector4U21F11(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYWW() => new Vector4U21F11(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZXX() => new Vector4U21F11(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZXY() => new Vector4U21F11(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZXZ() => new Vector4U21F11(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZXW() => new Vector4U21F11(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZYX() => new Vector4U21F11(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZYY() => new Vector4U21F11(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZYZ() => new Vector4U21F11(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZYW() => new Vector4U21F11(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZZX() => new Vector4U21F11(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZZY() => new Vector4U21F11(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZZZ() => new Vector4U21F11(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZZW() => new Vector4U21F11(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZWX() => new Vector4U21F11(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZWY() => new Vector4U21F11(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZWZ() => new Vector4U21F11(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZWW() => new Vector4U21F11(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YWXX() => new Vector4U21F11(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YWXY() => new Vector4U21F11(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YWXZ() => new Vector4U21F11(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YWXW() => new Vector4U21F11(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YWYX() => new Vector4U21F11(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YWYY() => new Vector4U21F11(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YWYZ() => new Vector4U21F11(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YWYW() => new Vector4U21F11(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YWZX() => new Vector4U21F11(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YWZY() => new Vector4U21F11(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YWZZ() => new Vector4U21F11(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YWZW() => new Vector4U21F11(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YWWX() => new Vector4U21F11(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YWWY() => new Vector4U21F11(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YWWZ() => new Vector4U21F11(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YWWW() => new Vector4U21F11(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXXX() => new Vector4U21F11(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXXY() => new Vector4U21F11(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXXZ() => new Vector4U21F11(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXXW() => new Vector4U21F11(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXYX() => new Vector4U21F11(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXYY() => new Vector4U21F11(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXYZ() => new Vector4U21F11(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXYW() => new Vector4U21F11(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXZX() => new Vector4U21F11(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXZY() => new Vector4U21F11(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXZZ() => new Vector4U21F11(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXZW() => new Vector4U21F11(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXWX() => new Vector4U21F11(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXWY() => new Vector4U21F11(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXWZ() => new Vector4U21F11(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXWW() => new Vector4U21F11(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYXX() => new Vector4U21F11(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYXY() => new Vector4U21F11(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYXZ() => new Vector4U21F11(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYXW() => new Vector4U21F11(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYYX() => new Vector4U21F11(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYYY() => new Vector4U21F11(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYYZ() => new Vector4U21F11(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYYW() => new Vector4U21F11(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYZX() => new Vector4U21F11(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYZY() => new Vector4U21F11(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYZZ() => new Vector4U21F11(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYZW() => new Vector4U21F11(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYWX() => new Vector4U21F11(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYWY() => new Vector4U21F11(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYWZ() => new Vector4U21F11(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYWW() => new Vector4U21F11(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZXX() => new Vector4U21F11(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZXY() => new Vector4U21F11(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZXZ() => new Vector4U21F11(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZXW() => new Vector4U21F11(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZYX() => new Vector4U21F11(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZYY() => new Vector4U21F11(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZYZ() => new Vector4U21F11(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZYW() => new Vector4U21F11(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZZX() => new Vector4U21F11(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZZY() => new Vector4U21F11(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZZZ() => new Vector4U21F11(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZZW() => new Vector4U21F11(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZWX() => new Vector4U21F11(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZWY() => new Vector4U21F11(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZWZ() => new Vector4U21F11(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZWW() => new Vector4U21F11(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZWXX() => new Vector4U21F11(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZWXY() => new Vector4U21F11(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZWXZ() => new Vector4U21F11(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZWXW() => new Vector4U21F11(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZWYX() => new Vector4U21F11(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZWYY() => new Vector4U21F11(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZWYZ() => new Vector4U21F11(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZWYW() => new Vector4U21F11(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZWZX() => new Vector4U21F11(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZWZY() => new Vector4U21F11(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZWZZ() => new Vector4U21F11(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZWZW() => new Vector4U21F11(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZWWX() => new Vector4U21F11(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZWWY() => new Vector4U21F11(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZWWZ() => new Vector4U21F11(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZWWW() => new Vector4U21F11(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WXXX() => new Vector4U21F11(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WXXY() => new Vector4U21F11(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WXXZ() => new Vector4U21F11(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WXXW() => new Vector4U21F11(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WXYX() => new Vector4U21F11(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WXYY() => new Vector4U21F11(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WXYZ() => new Vector4U21F11(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WXYW() => new Vector4U21F11(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WXZX() => new Vector4U21F11(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WXZY() => new Vector4U21F11(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WXZZ() => new Vector4U21F11(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WXZW() => new Vector4U21F11(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WXWX() => new Vector4U21F11(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WXWY() => new Vector4U21F11(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WXWZ() => new Vector4U21F11(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WXWW() => new Vector4U21F11(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WYXX() => new Vector4U21F11(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WYXY() => new Vector4U21F11(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WYXZ() => new Vector4U21F11(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WYXW() => new Vector4U21F11(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WYYX() => new Vector4U21F11(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WYYY() => new Vector4U21F11(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WYYZ() => new Vector4U21F11(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WYYW() => new Vector4U21F11(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WYZX() => new Vector4U21F11(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WYZY() => new Vector4U21F11(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WYZZ() => new Vector4U21F11(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WYZW() => new Vector4U21F11(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WYWX() => new Vector4U21F11(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WYWY() => new Vector4U21F11(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WYWZ() => new Vector4U21F11(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WYWW() => new Vector4U21F11(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WZXX() => new Vector4U21F11(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WZXY() => new Vector4U21F11(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WZXZ() => new Vector4U21F11(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WZXW() => new Vector4U21F11(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WZYX() => new Vector4U21F11(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WZYY() => new Vector4U21F11(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WZYZ() => new Vector4U21F11(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WZYW() => new Vector4U21F11(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WZZX() => new Vector4U21F11(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WZZY() => new Vector4U21F11(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WZZZ() => new Vector4U21F11(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WZZW() => new Vector4U21F11(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WZWX() => new Vector4U21F11(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WZWY() => new Vector4U21F11(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WZWZ() => new Vector4U21F11(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WZWW() => new Vector4U21F11(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WWXX() => new Vector4U21F11(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WWXY() => new Vector4U21F11(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WWXZ() => new Vector4U21F11(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WWXW() => new Vector4U21F11(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WWYX() => new Vector4U21F11(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WWYY() => new Vector4U21F11(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WWYZ() => new Vector4U21F11(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WWYW() => new Vector4U21F11(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WWZX() => new Vector4U21F11(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WWZY() => new Vector4U21F11(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WWZZ() => new Vector4U21F11(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WWZW() => new Vector4U21F11(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WWWX() => new Vector4U21F11(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WWWY() => new Vector4U21F11(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WWWZ() => new Vector4U21F11(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 WWWW() => new Vector4U21F11(W, W, W, W);

    }
}
