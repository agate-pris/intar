using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U18F14
    : IEquatable<Vector4U18F14>
    , IFormattable
    , IVector<U38F26, I38F26, U19F13, I19F13>
    , IVectorComponentRespective<U18F14> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U18F14 X;
        public U18F14 Y;
        public U18F14 Z;
        public U18F14 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(U18F14 x, U18F14 y, U18F14 z, U18F14 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(U18F14 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(U18F14 x, U18F14 y, Vector2U18F14 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(U18F14 x, Vector3U18F14 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(Vector2U18F14 xy, Vector2U18F14 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(Vector4U18F14 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(U18F14 x, Vector2U18F14 yz, U18F14 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(Vector3U18F14 xyz, U18F14 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14(Vector2U18F14 xy, U18F14 z, U18F14 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U18F14 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U18F14(U18F14.Zero);
        }
        public static Vector4U18F14 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U18F14(U18F14.One);
        }
        public static Vector4U18F14 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U18F14(U18F14.One, U18F14.Zero, U18F14.Zero, U18F14.Zero);
        }
        public static Vector4U18F14 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U18F14(U18F14.Zero, U18F14.One, U18F14.Zero, U18F14.Zero);
        }
        public static Vector4U18F14 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U18F14(U18F14.Zero, U18F14.Zero, U18F14.One, U18F14.Zero);
        }
        public static Vector4U18F14 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U18F14(U18F14.Zero, U18F14.Zero, U18F14.Zero, U18F14.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 operator +(Vector4U18F14 a, Vector4U18F14 b) => new Vector4U18F14(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 operator -(Vector4U18F14 a, Vector4U18F14 b) => new Vector4U18F14(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 operator *(Vector4U18F14 a, Vector4U18F14 b) => new Vector4U18F14(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 operator *(Vector4U18F14 a, U18F14 b) => new Vector4U18F14(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 operator *(U18F14 a, Vector4U18F14 b) => new Vector4U18F14(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 operator /(Vector4U18F14 a, Vector4U18F14 b) => new Vector4U18F14(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 operator /(Vector4U18F14 a, U18F14 b) => new Vector4U18F14(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U18F14 operator /(U18F14 a, Vector4U18F14 b) => new Vector4U18F14(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U18F14 lhs, Vector4U18F14 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U18F14 lhs, Vector4U18F14 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U18F14 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U18F14 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U18F14>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U18F14 other)
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
        public Vector4U18F14 Min(Vector4U18F14 other) => new Vector4U18F14(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14 Max(Vector4U18F14 other) => new Vector4U18F14(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14 Half() => new Vector4U18F14(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14 Twice() => new Vector4U18F14(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14 Clamp(U18F14 min, U18F14 max) => new Vector4U18F14(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14 Clamp(
            Vector4U18F14 min, Vector4U18F14 max
        ) => new Vector4U18F14(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14 WrappingAdd(Vector4U18F14 other) => new Vector4U18F14(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14 WrappingSub(Vector4U18F14 other) => new Vector4U18F14(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14 WrappingMul(Vector4U18F14 other) => new Vector4U18F14(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14 WrappingAddSigned(Vector4I18F14 other) => new Vector4U18F14(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14 SaturatingAdd(Vector4U18F14 other) => new Vector4U18F14(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14 SaturatingMul(U18F14 other) => new Vector4U18F14(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U18F14 other) {
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
        public U18F14 Dot(Vector4U18F14 other) {
            const ulong k = 1UL << 12;
            return U18F14.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U18F14 SaturatingDot(Vector4U18F14 other) {
            const ulong k = 1UL << 12;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U18F14.MaxValue;
            } else {
                return U18F14.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U38F26 LengthSquaredUnsigned() => U38F26.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I38F26 LengthSquaredSigned() => I38F26.FromBits(
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
        public U38F26 LengthSquared() => LengthSquaredUnsigned();

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
        public U18F14 LengthHalf() => U18F14.FromBits(LengthInternal());

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
        public I18F14 LengthHalfSigned() => I18F14.FromBits(checked((int)LengthInternal()));

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
        public U19F13 LengthUnsigned() => U19F13.FromBits(LengthInternal());

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
        public I19F13 LengthSigned() => I19F13.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U19F13 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U18F14? Normalize() {
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

            const ulong k = 1UL << 13;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U18F14(
                U18F14.FromBits(y0),
                U18F14.FromBits(y1),
                U18F14.FromBits(y2),
                U18F14.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U18F14 XX() => new Vector2U18F14(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U18F14 XY() => new Vector2U18F14(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U18F14 XZ() => new Vector2U18F14(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U18F14 XW() => new Vector2U18F14(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U18F14 YX() => new Vector2U18F14(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U18F14 YY() => new Vector2U18F14(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U18F14 YZ() => new Vector2U18F14(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U18F14 YW() => new Vector2U18F14(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U18F14 ZX() => new Vector2U18F14(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U18F14 ZY() => new Vector2U18F14(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U18F14 ZZ() => new Vector2U18F14(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U18F14 ZW() => new Vector2U18F14(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U18F14 WX() => new Vector2U18F14(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U18F14 WY() => new Vector2U18F14(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U18F14 WZ() => new Vector2U18F14(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U18F14 WW() => new Vector2U18F14(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 XXX() => new Vector3U18F14(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 XXY() => new Vector3U18F14(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 XXZ() => new Vector3U18F14(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 XXW() => new Vector3U18F14(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 XYX() => new Vector3U18F14(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 XYY() => new Vector3U18F14(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 XYZ() => new Vector3U18F14(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 XYW() => new Vector3U18F14(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 XZX() => new Vector3U18F14(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 XZY() => new Vector3U18F14(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 XZZ() => new Vector3U18F14(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 XZW() => new Vector3U18F14(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 XWX() => new Vector3U18F14(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 XWY() => new Vector3U18F14(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 XWZ() => new Vector3U18F14(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 XWW() => new Vector3U18F14(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 YXX() => new Vector3U18F14(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 YXY() => new Vector3U18F14(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 YXZ() => new Vector3U18F14(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 YXW() => new Vector3U18F14(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 YYX() => new Vector3U18F14(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 YYY() => new Vector3U18F14(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 YYZ() => new Vector3U18F14(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 YYW() => new Vector3U18F14(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 YZX() => new Vector3U18F14(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 YZY() => new Vector3U18F14(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 YZZ() => new Vector3U18F14(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 YZW() => new Vector3U18F14(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 YWX() => new Vector3U18F14(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 YWY() => new Vector3U18F14(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 YWZ() => new Vector3U18F14(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 YWW() => new Vector3U18F14(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 ZXX() => new Vector3U18F14(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 ZXY() => new Vector3U18F14(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 ZXZ() => new Vector3U18F14(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 ZXW() => new Vector3U18F14(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 ZYX() => new Vector3U18F14(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 ZYY() => new Vector3U18F14(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 ZYZ() => new Vector3U18F14(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 ZYW() => new Vector3U18F14(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 ZZX() => new Vector3U18F14(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 ZZY() => new Vector3U18F14(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 ZZZ() => new Vector3U18F14(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 ZZW() => new Vector3U18F14(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 ZWX() => new Vector3U18F14(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 ZWY() => new Vector3U18F14(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 ZWZ() => new Vector3U18F14(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 ZWW() => new Vector3U18F14(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 WXX() => new Vector3U18F14(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 WXY() => new Vector3U18F14(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 WXZ() => new Vector3U18F14(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 WXW() => new Vector3U18F14(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 WYX() => new Vector3U18F14(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 WYY() => new Vector3U18F14(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 WYZ() => new Vector3U18F14(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 WYW() => new Vector3U18F14(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 WZX() => new Vector3U18F14(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 WZY() => new Vector3U18F14(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 WZZ() => new Vector3U18F14(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 WZW() => new Vector3U18F14(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 WWX() => new Vector3U18F14(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 WWY() => new Vector3U18F14(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 WWZ() => new Vector3U18F14(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U18F14 WWW() => new Vector3U18F14(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XXXX() => new Vector4U18F14(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XXXY() => new Vector4U18F14(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XXXZ() => new Vector4U18F14(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XXXW() => new Vector4U18F14(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XXYX() => new Vector4U18F14(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XXYY() => new Vector4U18F14(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XXYZ() => new Vector4U18F14(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XXYW() => new Vector4U18F14(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XXZX() => new Vector4U18F14(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XXZY() => new Vector4U18F14(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XXZZ() => new Vector4U18F14(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XXZW() => new Vector4U18F14(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XXWX() => new Vector4U18F14(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XXWY() => new Vector4U18F14(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XXWZ() => new Vector4U18F14(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XXWW() => new Vector4U18F14(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XYXX() => new Vector4U18F14(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XYXY() => new Vector4U18F14(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XYXZ() => new Vector4U18F14(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XYXW() => new Vector4U18F14(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XYYX() => new Vector4U18F14(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XYYY() => new Vector4U18F14(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XYYZ() => new Vector4U18F14(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XYYW() => new Vector4U18F14(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XYZX() => new Vector4U18F14(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XYZY() => new Vector4U18F14(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XYZZ() => new Vector4U18F14(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XYZW() => new Vector4U18F14(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XYWX() => new Vector4U18F14(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XYWY() => new Vector4U18F14(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XYWZ() => new Vector4U18F14(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XYWW() => new Vector4U18F14(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XZXX() => new Vector4U18F14(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XZXY() => new Vector4U18F14(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XZXZ() => new Vector4U18F14(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XZXW() => new Vector4U18F14(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XZYX() => new Vector4U18F14(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XZYY() => new Vector4U18F14(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XZYZ() => new Vector4U18F14(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XZYW() => new Vector4U18F14(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XZZX() => new Vector4U18F14(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XZZY() => new Vector4U18F14(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XZZZ() => new Vector4U18F14(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XZZW() => new Vector4U18F14(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XZWX() => new Vector4U18F14(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XZWY() => new Vector4U18F14(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XZWZ() => new Vector4U18F14(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XZWW() => new Vector4U18F14(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XWXX() => new Vector4U18F14(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XWXY() => new Vector4U18F14(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XWXZ() => new Vector4U18F14(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XWXW() => new Vector4U18F14(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XWYX() => new Vector4U18F14(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XWYY() => new Vector4U18F14(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XWYZ() => new Vector4U18F14(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XWYW() => new Vector4U18F14(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XWZX() => new Vector4U18F14(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XWZY() => new Vector4U18F14(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XWZZ() => new Vector4U18F14(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XWZW() => new Vector4U18F14(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XWWX() => new Vector4U18F14(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XWWY() => new Vector4U18F14(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XWWZ() => new Vector4U18F14(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 XWWW() => new Vector4U18F14(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YXXX() => new Vector4U18F14(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YXXY() => new Vector4U18F14(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YXXZ() => new Vector4U18F14(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YXXW() => new Vector4U18F14(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YXYX() => new Vector4U18F14(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YXYY() => new Vector4U18F14(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YXYZ() => new Vector4U18F14(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YXYW() => new Vector4U18F14(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YXZX() => new Vector4U18F14(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YXZY() => new Vector4U18F14(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YXZZ() => new Vector4U18F14(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YXZW() => new Vector4U18F14(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YXWX() => new Vector4U18F14(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YXWY() => new Vector4U18F14(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YXWZ() => new Vector4U18F14(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YXWW() => new Vector4U18F14(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YYXX() => new Vector4U18F14(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YYXY() => new Vector4U18F14(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YYXZ() => new Vector4U18F14(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YYXW() => new Vector4U18F14(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YYYX() => new Vector4U18F14(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YYYY() => new Vector4U18F14(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YYYZ() => new Vector4U18F14(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YYYW() => new Vector4U18F14(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YYZX() => new Vector4U18F14(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YYZY() => new Vector4U18F14(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YYZZ() => new Vector4U18F14(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YYZW() => new Vector4U18F14(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YYWX() => new Vector4U18F14(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YYWY() => new Vector4U18F14(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YYWZ() => new Vector4U18F14(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YYWW() => new Vector4U18F14(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YZXX() => new Vector4U18F14(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YZXY() => new Vector4U18F14(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YZXZ() => new Vector4U18F14(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YZXW() => new Vector4U18F14(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YZYX() => new Vector4U18F14(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YZYY() => new Vector4U18F14(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YZYZ() => new Vector4U18F14(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YZYW() => new Vector4U18F14(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YZZX() => new Vector4U18F14(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YZZY() => new Vector4U18F14(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YZZZ() => new Vector4U18F14(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YZZW() => new Vector4U18F14(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YZWX() => new Vector4U18F14(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YZWY() => new Vector4U18F14(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YZWZ() => new Vector4U18F14(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YZWW() => new Vector4U18F14(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YWXX() => new Vector4U18F14(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YWXY() => new Vector4U18F14(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YWXZ() => new Vector4U18F14(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YWXW() => new Vector4U18F14(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YWYX() => new Vector4U18F14(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YWYY() => new Vector4U18F14(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YWYZ() => new Vector4U18F14(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YWYW() => new Vector4U18F14(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YWZX() => new Vector4U18F14(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YWZY() => new Vector4U18F14(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YWZZ() => new Vector4U18F14(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YWZW() => new Vector4U18F14(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YWWX() => new Vector4U18F14(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YWWY() => new Vector4U18F14(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YWWZ() => new Vector4U18F14(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 YWWW() => new Vector4U18F14(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZXXX() => new Vector4U18F14(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZXXY() => new Vector4U18F14(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZXXZ() => new Vector4U18F14(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZXXW() => new Vector4U18F14(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZXYX() => new Vector4U18F14(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZXYY() => new Vector4U18F14(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZXYZ() => new Vector4U18F14(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZXYW() => new Vector4U18F14(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZXZX() => new Vector4U18F14(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZXZY() => new Vector4U18F14(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZXZZ() => new Vector4U18F14(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZXZW() => new Vector4U18F14(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZXWX() => new Vector4U18F14(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZXWY() => new Vector4U18F14(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZXWZ() => new Vector4U18F14(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZXWW() => new Vector4U18F14(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZYXX() => new Vector4U18F14(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZYXY() => new Vector4U18F14(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZYXZ() => new Vector4U18F14(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZYXW() => new Vector4U18F14(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZYYX() => new Vector4U18F14(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZYYY() => new Vector4U18F14(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZYYZ() => new Vector4U18F14(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZYYW() => new Vector4U18F14(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZYZX() => new Vector4U18F14(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZYZY() => new Vector4U18F14(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZYZZ() => new Vector4U18F14(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZYZW() => new Vector4U18F14(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZYWX() => new Vector4U18F14(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZYWY() => new Vector4U18F14(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZYWZ() => new Vector4U18F14(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZYWW() => new Vector4U18F14(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZZXX() => new Vector4U18F14(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZZXY() => new Vector4U18F14(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZZXZ() => new Vector4U18F14(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZZXW() => new Vector4U18F14(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZZYX() => new Vector4U18F14(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZZYY() => new Vector4U18F14(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZZYZ() => new Vector4U18F14(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZZYW() => new Vector4U18F14(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZZZX() => new Vector4U18F14(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZZZY() => new Vector4U18F14(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZZZZ() => new Vector4U18F14(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZZZW() => new Vector4U18F14(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZZWX() => new Vector4U18F14(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZZWY() => new Vector4U18F14(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZZWZ() => new Vector4U18F14(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZZWW() => new Vector4U18F14(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZWXX() => new Vector4U18F14(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZWXY() => new Vector4U18F14(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZWXZ() => new Vector4U18F14(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZWXW() => new Vector4U18F14(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZWYX() => new Vector4U18F14(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZWYY() => new Vector4U18F14(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZWYZ() => new Vector4U18F14(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZWYW() => new Vector4U18F14(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZWZX() => new Vector4U18F14(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZWZY() => new Vector4U18F14(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZWZZ() => new Vector4U18F14(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZWZW() => new Vector4U18F14(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZWWX() => new Vector4U18F14(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZWWY() => new Vector4U18F14(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZWWZ() => new Vector4U18F14(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 ZWWW() => new Vector4U18F14(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WXXX() => new Vector4U18F14(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WXXY() => new Vector4U18F14(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WXXZ() => new Vector4U18F14(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WXXW() => new Vector4U18F14(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WXYX() => new Vector4U18F14(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WXYY() => new Vector4U18F14(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WXYZ() => new Vector4U18F14(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WXYW() => new Vector4U18F14(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WXZX() => new Vector4U18F14(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WXZY() => new Vector4U18F14(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WXZZ() => new Vector4U18F14(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WXZW() => new Vector4U18F14(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WXWX() => new Vector4U18F14(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WXWY() => new Vector4U18F14(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WXWZ() => new Vector4U18F14(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WXWW() => new Vector4U18F14(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WYXX() => new Vector4U18F14(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WYXY() => new Vector4U18F14(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WYXZ() => new Vector4U18F14(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WYXW() => new Vector4U18F14(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WYYX() => new Vector4U18F14(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WYYY() => new Vector4U18F14(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WYYZ() => new Vector4U18F14(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WYYW() => new Vector4U18F14(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WYZX() => new Vector4U18F14(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WYZY() => new Vector4U18F14(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WYZZ() => new Vector4U18F14(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WYZW() => new Vector4U18F14(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WYWX() => new Vector4U18F14(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WYWY() => new Vector4U18F14(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WYWZ() => new Vector4U18F14(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WYWW() => new Vector4U18F14(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WZXX() => new Vector4U18F14(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WZXY() => new Vector4U18F14(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WZXZ() => new Vector4U18F14(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WZXW() => new Vector4U18F14(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WZYX() => new Vector4U18F14(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WZYY() => new Vector4U18F14(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WZYZ() => new Vector4U18F14(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WZYW() => new Vector4U18F14(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WZZX() => new Vector4U18F14(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WZZY() => new Vector4U18F14(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WZZZ() => new Vector4U18F14(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WZZW() => new Vector4U18F14(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WZWX() => new Vector4U18F14(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WZWY() => new Vector4U18F14(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WZWZ() => new Vector4U18F14(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WZWW() => new Vector4U18F14(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WWXX() => new Vector4U18F14(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WWXY() => new Vector4U18F14(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WWXZ() => new Vector4U18F14(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WWXW() => new Vector4U18F14(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WWYX() => new Vector4U18F14(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WWYY() => new Vector4U18F14(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WWYZ() => new Vector4U18F14(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WWYW() => new Vector4U18F14(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WWZX() => new Vector4U18F14(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WWZY() => new Vector4U18F14(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WWZZ() => new Vector4U18F14(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WWZW() => new Vector4U18F14(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WWWX() => new Vector4U18F14(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WWWY() => new Vector4U18F14(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WWWZ() => new Vector4U18F14(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U18F14 WWWW() => new Vector4U18F14(W, W, W, W);

    }
}
