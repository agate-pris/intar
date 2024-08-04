using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U6F26
    : IEquatable<Vector4U6F26>
    , IFormattable
    , IVector<U14F50, I14F50, U7F25, I7F25>
    , IVectorComponentRespective<U6F26> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U6F26 X;
        public U6F26 Y;
        public U6F26 Z;
        public U6F26 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26(U6F26 x, U6F26 y, U6F26 z, U6F26 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26(U6F26 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26(U6F26 x, U6F26 y, Vector2U6F26 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26(U6F26 x, Vector3U6F26 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26(Vector2U6F26 xy, Vector2U6F26 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26(Vector4U6F26 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26(U6F26 x, Vector2U6F26 yz, U6F26 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26(Vector3U6F26 xyz, U6F26 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26(Vector2U6F26 xy, U6F26 z, U6F26 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U6F26 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U6F26(U6F26.Zero);
        }
        public static Vector4U6F26 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U6F26(U6F26.One);
        }
        public static Vector4U6F26 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U6F26(U6F26.One, U6F26.Zero, U6F26.Zero, U6F26.Zero);
        }
        public static Vector4U6F26 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U6F26(U6F26.Zero, U6F26.One, U6F26.Zero, U6F26.Zero);
        }
        public static Vector4U6F26 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U6F26(U6F26.Zero, U6F26.Zero, U6F26.One, U6F26.Zero);
        }
        public static Vector4U6F26 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U6F26(U6F26.Zero, U6F26.Zero, U6F26.Zero, U6F26.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 operator +(Vector4U6F26 a, Vector4U6F26 b) => new Vector4U6F26(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 operator -(Vector4U6F26 a, Vector4U6F26 b) => new Vector4U6F26(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 operator *(Vector4U6F26 a, Vector4U6F26 b) => new Vector4U6F26(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 operator *(Vector4U6F26 a, U6F26 b) => new Vector4U6F26(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 operator *(U6F26 a, Vector4U6F26 b) => new Vector4U6F26(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 operator /(Vector4U6F26 a, Vector4U6F26 b) => new Vector4U6F26(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 operator /(Vector4U6F26 a, U6F26 b) => new Vector4U6F26(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U6F26 operator /(U6F26 a, Vector4U6F26 b) => new Vector4U6F26(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U6F26 lhs, Vector4U6F26 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U6F26 lhs, Vector4U6F26 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U6F26 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U6F26 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U6F26>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U6F26 other)
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
        public Vector4U6F26 Min(Vector4U6F26 other) => new Vector4U6F26(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26 Max(Vector4U6F26 other) => new Vector4U6F26(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26 Half() => new Vector4U6F26(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26 Twice() => new Vector4U6F26(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26 Clamp(U6F26 min, U6F26 max) => new Vector4U6F26(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26 Clamp(
            Vector4U6F26 min, Vector4U6F26 max
        ) => new Vector4U6F26(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26 WrappingAdd(Vector4U6F26 other) => new Vector4U6F26(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26 WrappingSub(Vector4U6F26 other) => new Vector4U6F26(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26 WrappingMul(Vector4U6F26 other) => new Vector4U6F26(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26 WrappingAddSigned(Vector4I6F26 other) => new Vector4U6F26(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26 SaturatingAdd(Vector4U6F26 other) => new Vector4U6F26(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26 SaturatingMul(U6F26 other) => new Vector4U6F26(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U6F26 other) {
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
        public U6F26 Dot(Vector4U6F26 other) {
            const ulong k = 1UL << 24;
            return U6F26.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U6F26 SaturatingDot(Vector4U6F26 other) {
            const ulong k = 1UL << 24;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U6F26.MaxValue;
            } else {
                return U6F26.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U14F50 LengthSquaredUnsigned() => U14F50.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I14F50 LengthSquaredSigned() => I14F50.FromBits(
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
        public U14F50 LengthSquared() => LengthSquaredUnsigned();

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
        public U6F26 LengthHalf() => U6F26.FromBits(LengthInternal());

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
        public I6F26 LengthHalfSigned() => I6F26.FromBits(checked((int)LengthInternal()));

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
        public U7F25 LengthUnsigned() => U7F25.FromBits(LengthInternal());

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
        public I7F25 LengthSigned() => I7F25.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U7F25 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U6F26? Normalize() {
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

            const ulong k = 1UL << 25;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U6F26(
                U6F26.FromBits(y0),
                U6F26.FromBits(y1),
                U6F26.FromBits(y2),
                U6F26.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U6F26 XX() => new Vector2U6F26(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U6F26 XY() => new Vector2U6F26(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U6F26 XZ() => new Vector2U6F26(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U6F26 XW() => new Vector2U6F26(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U6F26 YX() => new Vector2U6F26(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U6F26 YY() => new Vector2U6F26(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U6F26 YZ() => new Vector2U6F26(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U6F26 YW() => new Vector2U6F26(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U6F26 ZX() => new Vector2U6F26(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U6F26 ZY() => new Vector2U6F26(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U6F26 ZZ() => new Vector2U6F26(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U6F26 ZW() => new Vector2U6F26(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U6F26 WX() => new Vector2U6F26(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U6F26 WY() => new Vector2U6F26(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U6F26 WZ() => new Vector2U6F26(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U6F26 WW() => new Vector2U6F26(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 XXX() => new Vector3U6F26(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 XXY() => new Vector3U6F26(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 XXZ() => new Vector3U6F26(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 XXW() => new Vector3U6F26(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 XYX() => new Vector3U6F26(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 XYY() => new Vector3U6F26(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 XYZ() => new Vector3U6F26(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 XYW() => new Vector3U6F26(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 XZX() => new Vector3U6F26(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 XZY() => new Vector3U6F26(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 XZZ() => new Vector3U6F26(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 XZW() => new Vector3U6F26(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 XWX() => new Vector3U6F26(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 XWY() => new Vector3U6F26(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 XWZ() => new Vector3U6F26(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 XWW() => new Vector3U6F26(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 YXX() => new Vector3U6F26(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 YXY() => new Vector3U6F26(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 YXZ() => new Vector3U6F26(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 YXW() => new Vector3U6F26(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 YYX() => new Vector3U6F26(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 YYY() => new Vector3U6F26(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 YYZ() => new Vector3U6F26(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 YYW() => new Vector3U6F26(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 YZX() => new Vector3U6F26(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 YZY() => new Vector3U6F26(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 YZZ() => new Vector3U6F26(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 YZW() => new Vector3U6F26(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 YWX() => new Vector3U6F26(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 YWY() => new Vector3U6F26(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 YWZ() => new Vector3U6F26(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 YWW() => new Vector3U6F26(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 ZXX() => new Vector3U6F26(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 ZXY() => new Vector3U6F26(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 ZXZ() => new Vector3U6F26(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 ZXW() => new Vector3U6F26(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 ZYX() => new Vector3U6F26(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 ZYY() => new Vector3U6F26(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 ZYZ() => new Vector3U6F26(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 ZYW() => new Vector3U6F26(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 ZZX() => new Vector3U6F26(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 ZZY() => new Vector3U6F26(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 ZZZ() => new Vector3U6F26(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 ZZW() => new Vector3U6F26(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 ZWX() => new Vector3U6F26(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 ZWY() => new Vector3U6F26(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 ZWZ() => new Vector3U6F26(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 ZWW() => new Vector3U6F26(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 WXX() => new Vector3U6F26(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 WXY() => new Vector3U6F26(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 WXZ() => new Vector3U6F26(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 WXW() => new Vector3U6F26(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 WYX() => new Vector3U6F26(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 WYY() => new Vector3U6F26(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 WYZ() => new Vector3U6F26(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 WYW() => new Vector3U6F26(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 WZX() => new Vector3U6F26(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 WZY() => new Vector3U6F26(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 WZZ() => new Vector3U6F26(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 WZW() => new Vector3U6F26(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 WWX() => new Vector3U6F26(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 WWY() => new Vector3U6F26(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 WWZ() => new Vector3U6F26(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U6F26 WWW() => new Vector3U6F26(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XXXX() => new Vector4U6F26(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XXXY() => new Vector4U6F26(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XXXZ() => new Vector4U6F26(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XXXW() => new Vector4U6F26(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XXYX() => new Vector4U6F26(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XXYY() => new Vector4U6F26(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XXYZ() => new Vector4U6F26(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XXYW() => new Vector4U6F26(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XXZX() => new Vector4U6F26(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XXZY() => new Vector4U6F26(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XXZZ() => new Vector4U6F26(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XXZW() => new Vector4U6F26(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XXWX() => new Vector4U6F26(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XXWY() => new Vector4U6F26(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XXWZ() => new Vector4U6F26(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XXWW() => new Vector4U6F26(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XYXX() => new Vector4U6F26(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XYXY() => new Vector4U6F26(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XYXZ() => new Vector4U6F26(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XYXW() => new Vector4U6F26(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XYYX() => new Vector4U6F26(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XYYY() => new Vector4U6F26(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XYYZ() => new Vector4U6F26(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XYYW() => new Vector4U6F26(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XYZX() => new Vector4U6F26(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XYZY() => new Vector4U6F26(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XYZZ() => new Vector4U6F26(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XYZW() => new Vector4U6F26(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XYWX() => new Vector4U6F26(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XYWY() => new Vector4U6F26(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XYWZ() => new Vector4U6F26(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XYWW() => new Vector4U6F26(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XZXX() => new Vector4U6F26(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XZXY() => new Vector4U6F26(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XZXZ() => new Vector4U6F26(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XZXW() => new Vector4U6F26(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XZYX() => new Vector4U6F26(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XZYY() => new Vector4U6F26(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XZYZ() => new Vector4U6F26(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XZYW() => new Vector4U6F26(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XZZX() => new Vector4U6F26(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XZZY() => new Vector4U6F26(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XZZZ() => new Vector4U6F26(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XZZW() => new Vector4U6F26(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XZWX() => new Vector4U6F26(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XZWY() => new Vector4U6F26(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XZWZ() => new Vector4U6F26(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XZWW() => new Vector4U6F26(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XWXX() => new Vector4U6F26(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XWXY() => new Vector4U6F26(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XWXZ() => new Vector4U6F26(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XWXW() => new Vector4U6F26(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XWYX() => new Vector4U6F26(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XWYY() => new Vector4U6F26(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XWYZ() => new Vector4U6F26(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XWYW() => new Vector4U6F26(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XWZX() => new Vector4U6F26(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XWZY() => new Vector4U6F26(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XWZZ() => new Vector4U6F26(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XWZW() => new Vector4U6F26(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XWWX() => new Vector4U6F26(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XWWY() => new Vector4U6F26(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XWWZ() => new Vector4U6F26(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 XWWW() => new Vector4U6F26(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YXXX() => new Vector4U6F26(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YXXY() => new Vector4U6F26(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YXXZ() => new Vector4U6F26(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YXXW() => new Vector4U6F26(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YXYX() => new Vector4U6F26(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YXYY() => new Vector4U6F26(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YXYZ() => new Vector4U6F26(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YXYW() => new Vector4U6F26(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YXZX() => new Vector4U6F26(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YXZY() => new Vector4U6F26(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YXZZ() => new Vector4U6F26(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YXZW() => new Vector4U6F26(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YXWX() => new Vector4U6F26(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YXWY() => new Vector4U6F26(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YXWZ() => new Vector4U6F26(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YXWW() => new Vector4U6F26(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YYXX() => new Vector4U6F26(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YYXY() => new Vector4U6F26(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YYXZ() => new Vector4U6F26(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YYXW() => new Vector4U6F26(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YYYX() => new Vector4U6F26(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YYYY() => new Vector4U6F26(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YYYZ() => new Vector4U6F26(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YYYW() => new Vector4U6F26(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YYZX() => new Vector4U6F26(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YYZY() => new Vector4U6F26(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YYZZ() => new Vector4U6F26(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YYZW() => new Vector4U6F26(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YYWX() => new Vector4U6F26(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YYWY() => new Vector4U6F26(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YYWZ() => new Vector4U6F26(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YYWW() => new Vector4U6F26(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YZXX() => new Vector4U6F26(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YZXY() => new Vector4U6F26(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YZXZ() => new Vector4U6F26(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YZXW() => new Vector4U6F26(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YZYX() => new Vector4U6F26(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YZYY() => new Vector4U6F26(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YZYZ() => new Vector4U6F26(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YZYW() => new Vector4U6F26(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YZZX() => new Vector4U6F26(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YZZY() => new Vector4U6F26(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YZZZ() => new Vector4U6F26(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YZZW() => new Vector4U6F26(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YZWX() => new Vector4U6F26(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YZWY() => new Vector4U6F26(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YZWZ() => new Vector4U6F26(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YZWW() => new Vector4U6F26(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YWXX() => new Vector4U6F26(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YWXY() => new Vector4U6F26(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YWXZ() => new Vector4U6F26(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YWXW() => new Vector4U6F26(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YWYX() => new Vector4U6F26(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YWYY() => new Vector4U6F26(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YWYZ() => new Vector4U6F26(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YWYW() => new Vector4U6F26(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YWZX() => new Vector4U6F26(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YWZY() => new Vector4U6F26(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YWZZ() => new Vector4U6F26(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YWZW() => new Vector4U6F26(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YWWX() => new Vector4U6F26(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YWWY() => new Vector4U6F26(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YWWZ() => new Vector4U6F26(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 YWWW() => new Vector4U6F26(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZXXX() => new Vector4U6F26(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZXXY() => new Vector4U6F26(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZXXZ() => new Vector4U6F26(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZXXW() => new Vector4U6F26(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZXYX() => new Vector4U6F26(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZXYY() => new Vector4U6F26(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZXYZ() => new Vector4U6F26(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZXYW() => new Vector4U6F26(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZXZX() => new Vector4U6F26(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZXZY() => new Vector4U6F26(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZXZZ() => new Vector4U6F26(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZXZW() => new Vector4U6F26(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZXWX() => new Vector4U6F26(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZXWY() => new Vector4U6F26(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZXWZ() => new Vector4U6F26(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZXWW() => new Vector4U6F26(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZYXX() => new Vector4U6F26(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZYXY() => new Vector4U6F26(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZYXZ() => new Vector4U6F26(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZYXW() => new Vector4U6F26(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZYYX() => new Vector4U6F26(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZYYY() => new Vector4U6F26(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZYYZ() => new Vector4U6F26(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZYYW() => new Vector4U6F26(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZYZX() => new Vector4U6F26(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZYZY() => new Vector4U6F26(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZYZZ() => new Vector4U6F26(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZYZW() => new Vector4U6F26(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZYWX() => new Vector4U6F26(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZYWY() => new Vector4U6F26(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZYWZ() => new Vector4U6F26(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZYWW() => new Vector4U6F26(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZZXX() => new Vector4U6F26(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZZXY() => new Vector4U6F26(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZZXZ() => new Vector4U6F26(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZZXW() => new Vector4U6F26(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZZYX() => new Vector4U6F26(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZZYY() => new Vector4U6F26(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZZYZ() => new Vector4U6F26(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZZYW() => new Vector4U6F26(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZZZX() => new Vector4U6F26(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZZZY() => new Vector4U6F26(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZZZZ() => new Vector4U6F26(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZZZW() => new Vector4U6F26(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZZWX() => new Vector4U6F26(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZZWY() => new Vector4U6F26(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZZWZ() => new Vector4U6F26(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZZWW() => new Vector4U6F26(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZWXX() => new Vector4U6F26(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZWXY() => new Vector4U6F26(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZWXZ() => new Vector4U6F26(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZWXW() => new Vector4U6F26(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZWYX() => new Vector4U6F26(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZWYY() => new Vector4U6F26(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZWYZ() => new Vector4U6F26(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZWYW() => new Vector4U6F26(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZWZX() => new Vector4U6F26(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZWZY() => new Vector4U6F26(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZWZZ() => new Vector4U6F26(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZWZW() => new Vector4U6F26(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZWWX() => new Vector4U6F26(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZWWY() => new Vector4U6F26(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZWWZ() => new Vector4U6F26(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 ZWWW() => new Vector4U6F26(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WXXX() => new Vector4U6F26(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WXXY() => new Vector4U6F26(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WXXZ() => new Vector4U6F26(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WXXW() => new Vector4U6F26(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WXYX() => new Vector4U6F26(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WXYY() => new Vector4U6F26(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WXYZ() => new Vector4U6F26(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WXYW() => new Vector4U6F26(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WXZX() => new Vector4U6F26(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WXZY() => new Vector4U6F26(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WXZZ() => new Vector4U6F26(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WXZW() => new Vector4U6F26(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WXWX() => new Vector4U6F26(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WXWY() => new Vector4U6F26(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WXWZ() => new Vector4U6F26(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WXWW() => new Vector4U6F26(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WYXX() => new Vector4U6F26(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WYXY() => new Vector4U6F26(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WYXZ() => new Vector4U6F26(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WYXW() => new Vector4U6F26(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WYYX() => new Vector4U6F26(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WYYY() => new Vector4U6F26(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WYYZ() => new Vector4U6F26(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WYYW() => new Vector4U6F26(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WYZX() => new Vector4U6F26(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WYZY() => new Vector4U6F26(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WYZZ() => new Vector4U6F26(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WYZW() => new Vector4U6F26(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WYWX() => new Vector4U6F26(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WYWY() => new Vector4U6F26(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WYWZ() => new Vector4U6F26(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WYWW() => new Vector4U6F26(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WZXX() => new Vector4U6F26(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WZXY() => new Vector4U6F26(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WZXZ() => new Vector4U6F26(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WZXW() => new Vector4U6F26(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WZYX() => new Vector4U6F26(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WZYY() => new Vector4U6F26(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WZYZ() => new Vector4U6F26(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WZYW() => new Vector4U6F26(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WZZX() => new Vector4U6F26(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WZZY() => new Vector4U6F26(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WZZZ() => new Vector4U6F26(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WZZW() => new Vector4U6F26(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WZWX() => new Vector4U6F26(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WZWY() => new Vector4U6F26(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WZWZ() => new Vector4U6F26(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WZWW() => new Vector4U6F26(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WWXX() => new Vector4U6F26(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WWXY() => new Vector4U6F26(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WWXZ() => new Vector4U6F26(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WWXW() => new Vector4U6F26(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WWYX() => new Vector4U6F26(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WWYY() => new Vector4U6F26(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WWYZ() => new Vector4U6F26(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WWYW() => new Vector4U6F26(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WWZX() => new Vector4U6F26(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WWZY() => new Vector4U6F26(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WWZZ() => new Vector4U6F26(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WWZW() => new Vector4U6F26(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WWWX() => new Vector4U6F26(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WWWY() => new Vector4U6F26(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WWWZ() => new Vector4U6F26(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U6F26 WWWW() => new Vector4U6F26(W, W, W, W);

    }
}
