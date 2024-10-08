using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U3F29
    : IEquatable<Vector4U3F29>
    , IFormattable
    , IVector<U8F56, I8F56, U4F28, I4F28>
    , IVectorComponentRespective<U3F29> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U3F29 X;
        public U3F29 Y;
        public U3F29 Z;
        public U3F29 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(U3F29 x, U3F29 y, U3F29 z, U3F29 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(U3F29 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(U3F29 x, U3F29 y, Vector2U3F29 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(U3F29 x, Vector3U3F29 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(Vector2U3F29 xy, Vector2U3F29 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(Vector4U3F29 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(U3F29 x, Vector2U3F29 yz, U3F29 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(Vector3U3F29 xyz, U3F29 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29(Vector2U3F29 xy, U3F29 z, U3F29 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U3F29 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U3F29(U3F29.Zero);
        }
        public static Vector4U3F29 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U3F29(U3F29.One);
        }
        public static Vector4U3F29 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U3F29(U3F29.One, U3F29.Zero, U3F29.Zero, U3F29.Zero);
        }
        public static Vector4U3F29 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U3F29(U3F29.Zero, U3F29.One, U3F29.Zero, U3F29.Zero);
        }
        public static Vector4U3F29 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U3F29(U3F29.Zero, U3F29.Zero, U3F29.One, U3F29.Zero);
        }
        public static Vector4U3F29 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U3F29(U3F29.Zero, U3F29.Zero, U3F29.Zero, U3F29.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator +(Vector4U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator -(Vector4U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator *(Vector4U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator *(Vector4U3F29 a, U3F29 b) => new Vector4U3F29(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator *(U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator /(Vector4U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator /(Vector4U3F29 a, U3F29 b) => new Vector4U3F29(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U3F29 operator /(U3F29 a, Vector4U3F29 b) => new Vector4U3F29(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U3F29 lhs, Vector4U3F29 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U3F29 lhs, Vector4U3F29 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U3F29 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U3F29 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U3F29>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U3F29 other)
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
        public Vector4U3F29 Min(Vector4U3F29 other) => new Vector4U3F29(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 Max(Vector4U3F29 other) => new Vector4U3F29(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 Half() => new Vector4U3F29(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 Twice() => new Vector4U3F29(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 Clamp(U3F29 min, U3F29 max) => new Vector4U3F29(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 Clamp(
            Vector4U3F29 min, Vector4U3F29 max
        ) => new Vector4U3F29(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 WrappingAdd(Vector4U3F29 other) => new Vector4U3F29(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 WrappingSub(Vector4U3F29 other) => new Vector4U3F29(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 WrappingMul(Vector4U3F29 other) => new Vector4U3F29(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 WrappingAddSigned(Vector4I3F29 other) => new Vector4U3F29(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 SaturatingAdd(Vector4U3F29 other) => new Vector4U3F29(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29 SaturatingMul(U3F29 other) => new Vector4U3F29(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U3F29 other) {
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
        public U3F29 Dot(Vector4U3F29 other) {
            const ulong k = 1UL << 27;
            return U3F29.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U3F29 SaturatingDot(Vector4U3F29 other) {
            const ulong k = 1UL << 27;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U3F29.MaxValue;
            } else {
                return U3F29.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U8F56 LengthSquaredUnsigned() => U8F56.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I8F56 LengthSquaredSigned() => I8F56.FromBits(
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
        public U8F56 LengthSquared() => LengthSquaredUnsigned();

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
        public U3F29 LengthHalf() => U3F29.FromBits(LengthInternal());

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
        public I3F29 LengthHalfSigned() => I3F29.FromBits(checked((int)LengthInternal()));

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
        public U4F28 LengthUnsigned() => U4F28.FromBits(LengthInternal());

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
        public I4F28 LengthSigned() => I4F28.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F28 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U3F29? Normalize() {
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

            const ulong k = 1UL << 28;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U3F29(
                U3F29.FromBits(y0),
                U3F29.FromBits(y1),
                U3F29.FromBits(y2),
                U3F29.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U3F29 XX() => new Vector2U3F29(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U3F29 XY() => new Vector2U3F29(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U3F29 XZ() => new Vector2U3F29(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U3F29 XW() => new Vector2U3F29(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U3F29 YX() => new Vector2U3F29(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U3F29 YY() => new Vector2U3F29(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U3F29 YZ() => new Vector2U3F29(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U3F29 YW() => new Vector2U3F29(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U3F29 ZX() => new Vector2U3F29(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U3F29 ZY() => new Vector2U3F29(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U3F29 ZZ() => new Vector2U3F29(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U3F29 ZW() => new Vector2U3F29(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U3F29 WX() => new Vector2U3F29(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U3F29 WY() => new Vector2U3F29(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U3F29 WZ() => new Vector2U3F29(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U3F29 WW() => new Vector2U3F29(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 XXX() => new Vector3U3F29(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 XXY() => new Vector3U3F29(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 XXZ() => new Vector3U3F29(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 XXW() => new Vector3U3F29(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 XYX() => new Vector3U3F29(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 XYY() => new Vector3U3F29(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 XYZ() => new Vector3U3F29(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 XYW() => new Vector3U3F29(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 XZX() => new Vector3U3F29(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 XZY() => new Vector3U3F29(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 XZZ() => new Vector3U3F29(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 XZW() => new Vector3U3F29(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 XWX() => new Vector3U3F29(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 XWY() => new Vector3U3F29(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 XWZ() => new Vector3U3F29(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 XWW() => new Vector3U3F29(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 YXX() => new Vector3U3F29(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 YXY() => new Vector3U3F29(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 YXZ() => new Vector3U3F29(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 YXW() => new Vector3U3F29(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 YYX() => new Vector3U3F29(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 YYY() => new Vector3U3F29(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 YYZ() => new Vector3U3F29(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 YYW() => new Vector3U3F29(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 YZX() => new Vector3U3F29(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 YZY() => new Vector3U3F29(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 YZZ() => new Vector3U3F29(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 YZW() => new Vector3U3F29(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 YWX() => new Vector3U3F29(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 YWY() => new Vector3U3F29(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 YWZ() => new Vector3U3F29(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 YWW() => new Vector3U3F29(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 ZXX() => new Vector3U3F29(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 ZXY() => new Vector3U3F29(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 ZXZ() => new Vector3U3F29(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 ZXW() => new Vector3U3F29(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 ZYX() => new Vector3U3F29(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 ZYY() => new Vector3U3F29(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 ZYZ() => new Vector3U3F29(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 ZYW() => new Vector3U3F29(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 ZZX() => new Vector3U3F29(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 ZZY() => new Vector3U3F29(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 ZZZ() => new Vector3U3F29(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 ZZW() => new Vector3U3F29(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 ZWX() => new Vector3U3F29(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 ZWY() => new Vector3U3F29(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 ZWZ() => new Vector3U3F29(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 ZWW() => new Vector3U3F29(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 WXX() => new Vector3U3F29(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 WXY() => new Vector3U3F29(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 WXZ() => new Vector3U3F29(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 WXW() => new Vector3U3F29(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 WYX() => new Vector3U3F29(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 WYY() => new Vector3U3F29(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 WYZ() => new Vector3U3F29(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 WYW() => new Vector3U3F29(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 WZX() => new Vector3U3F29(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 WZY() => new Vector3U3F29(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 WZZ() => new Vector3U3F29(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 WZW() => new Vector3U3F29(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 WWX() => new Vector3U3F29(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 WWY() => new Vector3U3F29(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 WWZ() => new Vector3U3F29(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U3F29 WWW() => new Vector3U3F29(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XXXX() => new Vector4U3F29(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XXXY() => new Vector4U3F29(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XXXZ() => new Vector4U3F29(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XXXW() => new Vector4U3F29(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XXYX() => new Vector4U3F29(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XXYY() => new Vector4U3F29(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XXYZ() => new Vector4U3F29(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XXYW() => new Vector4U3F29(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XXZX() => new Vector4U3F29(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XXZY() => new Vector4U3F29(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XXZZ() => new Vector4U3F29(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XXZW() => new Vector4U3F29(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XXWX() => new Vector4U3F29(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XXWY() => new Vector4U3F29(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XXWZ() => new Vector4U3F29(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XXWW() => new Vector4U3F29(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XYXX() => new Vector4U3F29(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XYXY() => new Vector4U3F29(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XYXZ() => new Vector4U3F29(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XYXW() => new Vector4U3F29(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XYYX() => new Vector4U3F29(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XYYY() => new Vector4U3F29(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XYYZ() => new Vector4U3F29(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XYYW() => new Vector4U3F29(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XYZX() => new Vector4U3F29(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XYZY() => new Vector4U3F29(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XYZZ() => new Vector4U3F29(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XYZW() => new Vector4U3F29(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XYWX() => new Vector4U3F29(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XYWY() => new Vector4U3F29(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XYWZ() => new Vector4U3F29(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XYWW() => new Vector4U3F29(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XZXX() => new Vector4U3F29(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XZXY() => new Vector4U3F29(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XZXZ() => new Vector4U3F29(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XZXW() => new Vector4U3F29(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XZYX() => new Vector4U3F29(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XZYY() => new Vector4U3F29(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XZYZ() => new Vector4U3F29(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XZYW() => new Vector4U3F29(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XZZX() => new Vector4U3F29(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XZZY() => new Vector4U3F29(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XZZZ() => new Vector4U3F29(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XZZW() => new Vector4U3F29(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XZWX() => new Vector4U3F29(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XZWY() => new Vector4U3F29(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XZWZ() => new Vector4U3F29(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XZWW() => new Vector4U3F29(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XWXX() => new Vector4U3F29(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XWXY() => new Vector4U3F29(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XWXZ() => new Vector4U3F29(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XWXW() => new Vector4U3F29(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XWYX() => new Vector4U3F29(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XWYY() => new Vector4U3F29(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XWYZ() => new Vector4U3F29(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XWYW() => new Vector4U3F29(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XWZX() => new Vector4U3F29(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XWZY() => new Vector4U3F29(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XWZZ() => new Vector4U3F29(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XWZW() => new Vector4U3F29(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XWWX() => new Vector4U3F29(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XWWY() => new Vector4U3F29(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XWWZ() => new Vector4U3F29(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 XWWW() => new Vector4U3F29(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YXXX() => new Vector4U3F29(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YXXY() => new Vector4U3F29(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YXXZ() => new Vector4U3F29(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YXXW() => new Vector4U3F29(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YXYX() => new Vector4U3F29(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YXYY() => new Vector4U3F29(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YXYZ() => new Vector4U3F29(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YXYW() => new Vector4U3F29(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YXZX() => new Vector4U3F29(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YXZY() => new Vector4U3F29(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YXZZ() => new Vector4U3F29(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YXZW() => new Vector4U3F29(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YXWX() => new Vector4U3F29(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YXWY() => new Vector4U3F29(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YXWZ() => new Vector4U3F29(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YXWW() => new Vector4U3F29(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YYXX() => new Vector4U3F29(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YYXY() => new Vector4U3F29(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YYXZ() => new Vector4U3F29(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YYXW() => new Vector4U3F29(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YYYX() => new Vector4U3F29(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YYYY() => new Vector4U3F29(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YYYZ() => new Vector4U3F29(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YYYW() => new Vector4U3F29(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YYZX() => new Vector4U3F29(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YYZY() => new Vector4U3F29(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YYZZ() => new Vector4U3F29(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YYZW() => new Vector4U3F29(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YYWX() => new Vector4U3F29(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YYWY() => new Vector4U3F29(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YYWZ() => new Vector4U3F29(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YYWW() => new Vector4U3F29(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YZXX() => new Vector4U3F29(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YZXY() => new Vector4U3F29(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YZXZ() => new Vector4U3F29(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YZXW() => new Vector4U3F29(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YZYX() => new Vector4U3F29(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YZYY() => new Vector4U3F29(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YZYZ() => new Vector4U3F29(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YZYW() => new Vector4U3F29(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YZZX() => new Vector4U3F29(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YZZY() => new Vector4U3F29(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YZZZ() => new Vector4U3F29(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YZZW() => new Vector4U3F29(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YZWX() => new Vector4U3F29(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YZWY() => new Vector4U3F29(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YZWZ() => new Vector4U3F29(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YZWW() => new Vector4U3F29(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YWXX() => new Vector4U3F29(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YWXY() => new Vector4U3F29(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YWXZ() => new Vector4U3F29(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YWXW() => new Vector4U3F29(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YWYX() => new Vector4U3F29(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YWYY() => new Vector4U3F29(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YWYZ() => new Vector4U3F29(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YWYW() => new Vector4U3F29(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YWZX() => new Vector4U3F29(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YWZY() => new Vector4U3F29(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YWZZ() => new Vector4U3F29(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YWZW() => new Vector4U3F29(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YWWX() => new Vector4U3F29(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YWWY() => new Vector4U3F29(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YWWZ() => new Vector4U3F29(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 YWWW() => new Vector4U3F29(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZXXX() => new Vector4U3F29(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZXXY() => new Vector4U3F29(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZXXZ() => new Vector4U3F29(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZXXW() => new Vector4U3F29(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZXYX() => new Vector4U3F29(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZXYY() => new Vector4U3F29(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZXYZ() => new Vector4U3F29(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZXYW() => new Vector4U3F29(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZXZX() => new Vector4U3F29(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZXZY() => new Vector4U3F29(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZXZZ() => new Vector4U3F29(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZXZW() => new Vector4U3F29(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZXWX() => new Vector4U3F29(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZXWY() => new Vector4U3F29(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZXWZ() => new Vector4U3F29(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZXWW() => new Vector4U3F29(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZYXX() => new Vector4U3F29(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZYXY() => new Vector4U3F29(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZYXZ() => new Vector4U3F29(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZYXW() => new Vector4U3F29(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZYYX() => new Vector4U3F29(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZYYY() => new Vector4U3F29(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZYYZ() => new Vector4U3F29(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZYYW() => new Vector4U3F29(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZYZX() => new Vector4U3F29(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZYZY() => new Vector4U3F29(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZYZZ() => new Vector4U3F29(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZYZW() => new Vector4U3F29(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZYWX() => new Vector4U3F29(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZYWY() => new Vector4U3F29(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZYWZ() => new Vector4U3F29(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZYWW() => new Vector4U3F29(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZZXX() => new Vector4U3F29(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZZXY() => new Vector4U3F29(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZZXZ() => new Vector4U3F29(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZZXW() => new Vector4U3F29(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZZYX() => new Vector4U3F29(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZZYY() => new Vector4U3F29(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZZYZ() => new Vector4U3F29(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZZYW() => new Vector4U3F29(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZZZX() => new Vector4U3F29(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZZZY() => new Vector4U3F29(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZZZZ() => new Vector4U3F29(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZZZW() => new Vector4U3F29(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZZWX() => new Vector4U3F29(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZZWY() => new Vector4U3F29(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZZWZ() => new Vector4U3F29(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZZWW() => new Vector4U3F29(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZWXX() => new Vector4U3F29(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZWXY() => new Vector4U3F29(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZWXZ() => new Vector4U3F29(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZWXW() => new Vector4U3F29(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZWYX() => new Vector4U3F29(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZWYY() => new Vector4U3F29(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZWYZ() => new Vector4U3F29(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZWYW() => new Vector4U3F29(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZWZX() => new Vector4U3F29(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZWZY() => new Vector4U3F29(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZWZZ() => new Vector4U3F29(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZWZW() => new Vector4U3F29(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZWWX() => new Vector4U3F29(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZWWY() => new Vector4U3F29(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZWWZ() => new Vector4U3F29(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 ZWWW() => new Vector4U3F29(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WXXX() => new Vector4U3F29(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WXXY() => new Vector4U3F29(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WXXZ() => new Vector4U3F29(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WXXW() => new Vector4U3F29(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WXYX() => new Vector4U3F29(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WXYY() => new Vector4U3F29(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WXYZ() => new Vector4U3F29(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WXYW() => new Vector4U3F29(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WXZX() => new Vector4U3F29(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WXZY() => new Vector4U3F29(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WXZZ() => new Vector4U3F29(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WXZW() => new Vector4U3F29(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WXWX() => new Vector4U3F29(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WXWY() => new Vector4U3F29(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WXWZ() => new Vector4U3F29(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WXWW() => new Vector4U3F29(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WYXX() => new Vector4U3F29(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WYXY() => new Vector4U3F29(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WYXZ() => new Vector4U3F29(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WYXW() => new Vector4U3F29(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WYYX() => new Vector4U3F29(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WYYY() => new Vector4U3F29(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WYYZ() => new Vector4U3F29(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WYYW() => new Vector4U3F29(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WYZX() => new Vector4U3F29(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WYZY() => new Vector4U3F29(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WYZZ() => new Vector4U3F29(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WYZW() => new Vector4U3F29(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WYWX() => new Vector4U3F29(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WYWY() => new Vector4U3F29(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WYWZ() => new Vector4U3F29(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WYWW() => new Vector4U3F29(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WZXX() => new Vector4U3F29(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WZXY() => new Vector4U3F29(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WZXZ() => new Vector4U3F29(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WZXW() => new Vector4U3F29(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WZYX() => new Vector4U3F29(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WZYY() => new Vector4U3F29(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WZYZ() => new Vector4U3F29(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WZYW() => new Vector4U3F29(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WZZX() => new Vector4U3F29(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WZZY() => new Vector4U3F29(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WZZZ() => new Vector4U3F29(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WZZW() => new Vector4U3F29(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WZWX() => new Vector4U3F29(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WZWY() => new Vector4U3F29(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WZWZ() => new Vector4U3F29(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WZWW() => new Vector4U3F29(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WWXX() => new Vector4U3F29(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WWXY() => new Vector4U3F29(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WWXZ() => new Vector4U3F29(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WWXW() => new Vector4U3F29(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WWYX() => new Vector4U3F29(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WWYY() => new Vector4U3F29(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WWYZ() => new Vector4U3F29(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WWYW() => new Vector4U3F29(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WWZX() => new Vector4U3F29(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WWZY() => new Vector4U3F29(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WWZZ() => new Vector4U3F29(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WWZW() => new Vector4U3F29(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WWWX() => new Vector4U3F29(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WWWY() => new Vector4U3F29(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WWWZ() => new Vector4U3F29(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U3F29 WWWW() => new Vector4U3F29(W, W, W, W);

    }
}
