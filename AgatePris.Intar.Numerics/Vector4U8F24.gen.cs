using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U8F24
    : IEquatable<Vector4U8F24>
    , IFormattable
    , IVector<U18F46, I18F46, U9F23, I9F23>
    , IVectorComponentRespective<U8F24> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U8F24 X;
        public U8F24 Y;
        public U8F24 Z;
        public U8F24 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(U8F24 x, U8F24 y, U8F24 z, U8F24 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(U8F24 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(U8F24 x, U8F24 y, Vector2U8F24 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(U8F24 x, Vector3U8F24 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(Vector2U8F24 xy, Vector2U8F24 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(Vector4U8F24 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(U8F24 x, Vector2U8F24 yz, U8F24 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(Vector3U8F24 xyz, U8F24 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24(Vector2U8F24 xy, U8F24 z, U8F24 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U8F24 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U8F24(U8F24.Zero);
        }
        public static Vector4U8F24 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U8F24(U8F24.One);
        }
        public static Vector4U8F24 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U8F24(U8F24.One, U8F24.Zero, U8F24.Zero, U8F24.Zero);
        }
        public static Vector4U8F24 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U8F24(U8F24.Zero, U8F24.One, U8F24.Zero, U8F24.Zero);
        }
        public static Vector4U8F24 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U8F24(U8F24.Zero, U8F24.Zero, U8F24.One, U8F24.Zero);
        }
        public static Vector4U8F24 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U8F24(U8F24.Zero, U8F24.Zero, U8F24.Zero, U8F24.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 operator +(Vector4U8F24 a, Vector4U8F24 b) => new Vector4U8F24(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 operator -(Vector4U8F24 a, Vector4U8F24 b) => new Vector4U8F24(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 operator *(Vector4U8F24 a, Vector4U8F24 b) => new Vector4U8F24(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 operator *(Vector4U8F24 a, U8F24 b) => new Vector4U8F24(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 operator *(U8F24 a, Vector4U8F24 b) => new Vector4U8F24(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 operator /(Vector4U8F24 a, Vector4U8F24 b) => new Vector4U8F24(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 operator /(Vector4U8F24 a, U8F24 b) => new Vector4U8F24(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U8F24 operator /(U8F24 a, Vector4U8F24 b) => new Vector4U8F24(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U8F24 lhs, Vector4U8F24 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U8F24 lhs, Vector4U8F24 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U8F24 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U8F24 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U8F24>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U8F24 other)
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
        public Vector4U8F24 Min(Vector4U8F24 other) => new Vector4U8F24(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24 Max(Vector4U8F24 other) => new Vector4U8F24(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24 Half() => new Vector4U8F24(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24 Twice() => new Vector4U8F24(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24 Clamp(U8F24 min, U8F24 max) => new Vector4U8F24(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24 Clamp(
            Vector4U8F24 min, Vector4U8F24 max
        ) => new Vector4U8F24(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24 WrappingAdd(Vector4U8F24 other) => new Vector4U8F24(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24 WrappingSub(Vector4U8F24 other) => new Vector4U8F24(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24 WrappingMul(Vector4U8F24 other) => new Vector4U8F24(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24 WrappingAddSigned(Vector4I8F24 other) => new Vector4U8F24(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24 SaturatingAdd(Vector4U8F24 other) => new Vector4U8F24(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24 SaturatingMul(U8F24 other) => new Vector4U8F24(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U8F24 other) {
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
        public U8F24 Dot(Vector4U8F24 other) {
            const ulong k = 1UL << 22;
            return U8F24.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U8F24 SaturatingDot(Vector4U8F24 other) {
            const ulong k = 1UL << 22;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U8F24.MaxValue;
            } else {
                return U8F24.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U18F46 LengthSquaredUnsigned() => U18F46.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I18F46 LengthSquaredSigned() => I18F46.FromBits(
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
        public U18F46 LengthSquared() => LengthSquaredUnsigned();

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
        public U8F24 LengthHalf() => U8F24.FromBits(LengthInternal());

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
        public I8F24 LengthHalfSigned() => I8F24.FromBits(checked((int)LengthInternal()));

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
        public U9F23 LengthUnsigned() => U9F23.FromBits(LengthInternal());

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
        public I9F23 LengthSigned() => I9F23.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U9F23 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U8F24? Normalize() {
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

            const ulong k = 1UL << 23;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U8F24(
                U8F24.FromBits(y0),
                U8F24.FromBits(y1),
                U8F24.FromBits(y2),
                U8F24.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 XX() => new Vector2U8F24(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 XY() => new Vector2U8F24(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 XZ() => new Vector2U8F24(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 XW() => new Vector2U8F24(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 YX() => new Vector2U8F24(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 YY() => new Vector2U8F24(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 YZ() => new Vector2U8F24(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 YW() => new Vector2U8F24(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 ZX() => new Vector2U8F24(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 ZY() => new Vector2U8F24(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 ZZ() => new Vector2U8F24(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 ZW() => new Vector2U8F24(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 WX() => new Vector2U8F24(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 WY() => new Vector2U8F24(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 WZ() => new Vector2U8F24(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 WW() => new Vector2U8F24(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XXX() => new Vector3U8F24(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XXY() => new Vector3U8F24(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XXZ() => new Vector3U8F24(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XXW() => new Vector3U8F24(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XYX() => new Vector3U8F24(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XYY() => new Vector3U8F24(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XYZ() => new Vector3U8F24(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XYW() => new Vector3U8F24(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XZX() => new Vector3U8F24(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XZY() => new Vector3U8F24(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XZZ() => new Vector3U8F24(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XZW() => new Vector3U8F24(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XWX() => new Vector3U8F24(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XWY() => new Vector3U8F24(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XWZ() => new Vector3U8F24(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XWW() => new Vector3U8F24(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YXX() => new Vector3U8F24(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YXY() => new Vector3U8F24(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YXZ() => new Vector3U8F24(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YXW() => new Vector3U8F24(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YYX() => new Vector3U8F24(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YYY() => new Vector3U8F24(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YYZ() => new Vector3U8F24(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YYW() => new Vector3U8F24(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YZX() => new Vector3U8F24(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YZY() => new Vector3U8F24(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YZZ() => new Vector3U8F24(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YZW() => new Vector3U8F24(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YWX() => new Vector3U8F24(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YWY() => new Vector3U8F24(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YWZ() => new Vector3U8F24(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YWW() => new Vector3U8F24(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZXX() => new Vector3U8F24(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZXY() => new Vector3U8F24(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZXZ() => new Vector3U8F24(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZXW() => new Vector3U8F24(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZYX() => new Vector3U8F24(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZYY() => new Vector3U8F24(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZYZ() => new Vector3U8F24(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZYW() => new Vector3U8F24(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZZX() => new Vector3U8F24(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZZY() => new Vector3U8F24(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZZZ() => new Vector3U8F24(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZZW() => new Vector3U8F24(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZWX() => new Vector3U8F24(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZWY() => new Vector3U8F24(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZWZ() => new Vector3U8F24(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZWW() => new Vector3U8F24(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 WXX() => new Vector3U8F24(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 WXY() => new Vector3U8F24(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 WXZ() => new Vector3U8F24(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 WXW() => new Vector3U8F24(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 WYX() => new Vector3U8F24(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 WYY() => new Vector3U8F24(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 WYZ() => new Vector3U8F24(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 WYW() => new Vector3U8F24(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 WZX() => new Vector3U8F24(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 WZY() => new Vector3U8F24(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 WZZ() => new Vector3U8F24(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 WZW() => new Vector3U8F24(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 WWX() => new Vector3U8F24(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 WWY() => new Vector3U8F24(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 WWZ() => new Vector3U8F24(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 WWW() => new Vector3U8F24(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXXX() => new Vector4U8F24(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXXY() => new Vector4U8F24(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXXZ() => new Vector4U8F24(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXXW() => new Vector4U8F24(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXYX() => new Vector4U8F24(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXYY() => new Vector4U8F24(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXYZ() => new Vector4U8F24(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXYW() => new Vector4U8F24(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXZX() => new Vector4U8F24(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXZY() => new Vector4U8F24(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXZZ() => new Vector4U8F24(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXZW() => new Vector4U8F24(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXWX() => new Vector4U8F24(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXWY() => new Vector4U8F24(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXWZ() => new Vector4U8F24(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXWW() => new Vector4U8F24(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYXX() => new Vector4U8F24(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYXY() => new Vector4U8F24(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYXZ() => new Vector4U8F24(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYXW() => new Vector4U8F24(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYYX() => new Vector4U8F24(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYYY() => new Vector4U8F24(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYYZ() => new Vector4U8F24(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYYW() => new Vector4U8F24(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYZX() => new Vector4U8F24(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYZY() => new Vector4U8F24(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYZZ() => new Vector4U8F24(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYZW() => new Vector4U8F24(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYWX() => new Vector4U8F24(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYWY() => new Vector4U8F24(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYWZ() => new Vector4U8F24(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYWW() => new Vector4U8F24(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZXX() => new Vector4U8F24(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZXY() => new Vector4U8F24(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZXZ() => new Vector4U8F24(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZXW() => new Vector4U8F24(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZYX() => new Vector4U8F24(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZYY() => new Vector4U8F24(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZYZ() => new Vector4U8F24(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZYW() => new Vector4U8F24(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZZX() => new Vector4U8F24(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZZY() => new Vector4U8F24(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZZZ() => new Vector4U8F24(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZZW() => new Vector4U8F24(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZWX() => new Vector4U8F24(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZWY() => new Vector4U8F24(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZWZ() => new Vector4U8F24(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZWW() => new Vector4U8F24(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XWXX() => new Vector4U8F24(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XWXY() => new Vector4U8F24(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XWXZ() => new Vector4U8F24(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XWXW() => new Vector4U8F24(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XWYX() => new Vector4U8F24(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XWYY() => new Vector4U8F24(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XWYZ() => new Vector4U8F24(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XWYW() => new Vector4U8F24(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XWZX() => new Vector4U8F24(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XWZY() => new Vector4U8F24(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XWZZ() => new Vector4U8F24(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XWZW() => new Vector4U8F24(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XWWX() => new Vector4U8F24(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XWWY() => new Vector4U8F24(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XWWZ() => new Vector4U8F24(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XWWW() => new Vector4U8F24(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXXX() => new Vector4U8F24(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXXY() => new Vector4U8F24(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXXZ() => new Vector4U8F24(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXXW() => new Vector4U8F24(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXYX() => new Vector4U8F24(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXYY() => new Vector4U8F24(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXYZ() => new Vector4U8F24(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXYW() => new Vector4U8F24(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXZX() => new Vector4U8F24(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXZY() => new Vector4U8F24(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXZZ() => new Vector4U8F24(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXZW() => new Vector4U8F24(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXWX() => new Vector4U8F24(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXWY() => new Vector4U8F24(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXWZ() => new Vector4U8F24(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXWW() => new Vector4U8F24(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYXX() => new Vector4U8F24(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYXY() => new Vector4U8F24(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYXZ() => new Vector4U8F24(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYXW() => new Vector4U8F24(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYYX() => new Vector4U8F24(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYYY() => new Vector4U8F24(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYYZ() => new Vector4U8F24(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYYW() => new Vector4U8F24(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYZX() => new Vector4U8F24(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYZY() => new Vector4U8F24(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYZZ() => new Vector4U8F24(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYZW() => new Vector4U8F24(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYWX() => new Vector4U8F24(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYWY() => new Vector4U8F24(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYWZ() => new Vector4U8F24(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYWW() => new Vector4U8F24(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZXX() => new Vector4U8F24(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZXY() => new Vector4U8F24(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZXZ() => new Vector4U8F24(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZXW() => new Vector4U8F24(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZYX() => new Vector4U8F24(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZYY() => new Vector4U8F24(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZYZ() => new Vector4U8F24(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZYW() => new Vector4U8F24(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZZX() => new Vector4U8F24(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZZY() => new Vector4U8F24(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZZZ() => new Vector4U8F24(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZZW() => new Vector4U8F24(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZWX() => new Vector4U8F24(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZWY() => new Vector4U8F24(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZWZ() => new Vector4U8F24(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZWW() => new Vector4U8F24(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YWXX() => new Vector4U8F24(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YWXY() => new Vector4U8F24(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YWXZ() => new Vector4U8F24(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YWXW() => new Vector4U8F24(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YWYX() => new Vector4U8F24(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YWYY() => new Vector4U8F24(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YWYZ() => new Vector4U8F24(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YWYW() => new Vector4U8F24(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YWZX() => new Vector4U8F24(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YWZY() => new Vector4U8F24(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YWZZ() => new Vector4U8F24(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YWZW() => new Vector4U8F24(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YWWX() => new Vector4U8F24(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YWWY() => new Vector4U8F24(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YWWZ() => new Vector4U8F24(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YWWW() => new Vector4U8F24(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXXX() => new Vector4U8F24(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXXY() => new Vector4U8F24(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXXZ() => new Vector4U8F24(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXXW() => new Vector4U8F24(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXYX() => new Vector4U8F24(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXYY() => new Vector4U8F24(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXYZ() => new Vector4U8F24(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXYW() => new Vector4U8F24(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXZX() => new Vector4U8F24(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXZY() => new Vector4U8F24(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXZZ() => new Vector4U8F24(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXZW() => new Vector4U8F24(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXWX() => new Vector4U8F24(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXWY() => new Vector4U8F24(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXWZ() => new Vector4U8F24(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXWW() => new Vector4U8F24(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYXX() => new Vector4U8F24(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYXY() => new Vector4U8F24(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYXZ() => new Vector4U8F24(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYXW() => new Vector4U8F24(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYYX() => new Vector4U8F24(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYYY() => new Vector4U8F24(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYYZ() => new Vector4U8F24(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYYW() => new Vector4U8F24(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYZX() => new Vector4U8F24(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYZY() => new Vector4U8F24(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYZZ() => new Vector4U8F24(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYZW() => new Vector4U8F24(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYWX() => new Vector4U8F24(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYWY() => new Vector4U8F24(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYWZ() => new Vector4U8F24(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYWW() => new Vector4U8F24(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZXX() => new Vector4U8F24(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZXY() => new Vector4U8F24(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZXZ() => new Vector4U8F24(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZXW() => new Vector4U8F24(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZYX() => new Vector4U8F24(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZYY() => new Vector4U8F24(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZYZ() => new Vector4U8F24(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZYW() => new Vector4U8F24(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZZX() => new Vector4U8F24(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZZY() => new Vector4U8F24(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZZZ() => new Vector4U8F24(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZZW() => new Vector4U8F24(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZWX() => new Vector4U8F24(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZWY() => new Vector4U8F24(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZWZ() => new Vector4U8F24(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZWW() => new Vector4U8F24(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZWXX() => new Vector4U8F24(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZWXY() => new Vector4U8F24(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZWXZ() => new Vector4U8F24(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZWXW() => new Vector4U8F24(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZWYX() => new Vector4U8F24(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZWYY() => new Vector4U8F24(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZWYZ() => new Vector4U8F24(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZWYW() => new Vector4U8F24(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZWZX() => new Vector4U8F24(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZWZY() => new Vector4U8F24(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZWZZ() => new Vector4U8F24(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZWZW() => new Vector4U8F24(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZWWX() => new Vector4U8F24(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZWWY() => new Vector4U8F24(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZWWZ() => new Vector4U8F24(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZWWW() => new Vector4U8F24(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WXXX() => new Vector4U8F24(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WXXY() => new Vector4U8F24(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WXXZ() => new Vector4U8F24(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WXXW() => new Vector4U8F24(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WXYX() => new Vector4U8F24(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WXYY() => new Vector4U8F24(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WXYZ() => new Vector4U8F24(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WXYW() => new Vector4U8F24(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WXZX() => new Vector4U8F24(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WXZY() => new Vector4U8F24(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WXZZ() => new Vector4U8F24(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WXZW() => new Vector4U8F24(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WXWX() => new Vector4U8F24(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WXWY() => new Vector4U8F24(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WXWZ() => new Vector4U8F24(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WXWW() => new Vector4U8F24(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WYXX() => new Vector4U8F24(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WYXY() => new Vector4U8F24(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WYXZ() => new Vector4U8F24(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WYXW() => new Vector4U8F24(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WYYX() => new Vector4U8F24(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WYYY() => new Vector4U8F24(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WYYZ() => new Vector4U8F24(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WYYW() => new Vector4U8F24(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WYZX() => new Vector4U8F24(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WYZY() => new Vector4U8F24(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WYZZ() => new Vector4U8F24(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WYZW() => new Vector4U8F24(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WYWX() => new Vector4U8F24(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WYWY() => new Vector4U8F24(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WYWZ() => new Vector4U8F24(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WYWW() => new Vector4U8F24(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WZXX() => new Vector4U8F24(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WZXY() => new Vector4U8F24(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WZXZ() => new Vector4U8F24(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WZXW() => new Vector4U8F24(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WZYX() => new Vector4U8F24(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WZYY() => new Vector4U8F24(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WZYZ() => new Vector4U8F24(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WZYW() => new Vector4U8F24(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WZZX() => new Vector4U8F24(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WZZY() => new Vector4U8F24(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WZZZ() => new Vector4U8F24(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WZZW() => new Vector4U8F24(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WZWX() => new Vector4U8F24(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WZWY() => new Vector4U8F24(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WZWZ() => new Vector4U8F24(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WZWW() => new Vector4U8F24(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WWXX() => new Vector4U8F24(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WWXY() => new Vector4U8F24(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WWXZ() => new Vector4U8F24(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WWXW() => new Vector4U8F24(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WWYX() => new Vector4U8F24(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WWYY() => new Vector4U8F24(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WWYZ() => new Vector4U8F24(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WWYW() => new Vector4U8F24(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WWZX() => new Vector4U8F24(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WWZY() => new Vector4U8F24(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WWZZ() => new Vector4U8F24(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WWZW() => new Vector4U8F24(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WWWX() => new Vector4U8F24(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WWWY() => new Vector4U8F24(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WWWZ() => new Vector4U8F24(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 WWWW() => new Vector4U8F24(W, W, W, W);

    }
}
