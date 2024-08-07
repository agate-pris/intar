using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U2F30
    : IEquatable<Vector4U2F30>
    , IFormattable
    , IVector<U6F58, I6F58, U3F29, I3F29>
    , IVectorComponentRespective<U2F30> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U2F30 X;
        public U2F30 Y;
        public U2F30 Z;
        public U2F30 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(U2F30 x, U2F30 y, U2F30 z, U2F30 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(U2F30 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(U2F30 x, U2F30 y, Vector2U2F30 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(U2F30 x, Vector3U2F30 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(Vector2U2F30 xy, Vector2U2F30 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(Vector4U2F30 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(U2F30 x, Vector2U2F30 yz, U2F30 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(Vector3U2F30 xyz, U2F30 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30(Vector2U2F30 xy, U2F30 z, U2F30 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U2F30 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U2F30(U2F30.Zero);
        }
        public static Vector4U2F30 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U2F30(U2F30.One);
        }
        public static Vector4U2F30 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U2F30(U2F30.One, U2F30.Zero, U2F30.Zero, U2F30.Zero);
        }
        public static Vector4U2F30 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U2F30(U2F30.Zero, U2F30.One, U2F30.Zero, U2F30.Zero);
        }
        public static Vector4U2F30 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U2F30(U2F30.Zero, U2F30.Zero, U2F30.One, U2F30.Zero);
        }
        public static Vector4U2F30 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U2F30(U2F30.Zero, U2F30.Zero, U2F30.Zero, U2F30.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator +(Vector4U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator -(Vector4U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator *(Vector4U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator *(Vector4U2F30 a, U2F30 b) => new Vector4U2F30(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator *(U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator /(Vector4U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator /(Vector4U2F30 a, U2F30 b) => new Vector4U2F30(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U2F30 operator /(U2F30 a, Vector4U2F30 b) => new Vector4U2F30(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U2F30 lhs, Vector4U2F30 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U2F30 lhs, Vector4U2F30 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U2F30 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U2F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U2F30 other)
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
        public Vector4U2F30 Min(Vector4U2F30 other) => new Vector4U2F30(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 Max(Vector4U2F30 other) => new Vector4U2F30(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 Half() => new Vector4U2F30(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 Twice() => new Vector4U2F30(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 Clamp(U2F30 min, U2F30 max) => new Vector4U2F30(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 Clamp(
            Vector4U2F30 min, Vector4U2F30 max
        ) => new Vector4U2F30(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 WrappingAdd(Vector4U2F30 other) => new Vector4U2F30(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 WrappingSub(Vector4U2F30 other) => new Vector4U2F30(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 WrappingMul(Vector4U2F30 other) => new Vector4U2F30(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 WrappingAddSigned(Vector4I2F30 other) => new Vector4U2F30(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 SaturatingAdd(Vector4U2F30 other) => new Vector4U2F30(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 SaturatingMul(U2F30 other) => new Vector4U2F30(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U2F30 other) {
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
        public U2F30 Dot(Vector4U2F30 other) {
            const ulong k = 1UL << 28;
            return U2F30.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 SaturatingDot(Vector4U2F30 other) {
            const ulong k = 1UL << 28;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U2F30.MaxValue;
            } else {
                return U2F30.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U6F58 LengthSquaredUnsigned() => U6F58.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I6F58 LengthSquaredSigned() => I6F58.FromBits(
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
        public U6F58 LengthSquared() => LengthSquaredUnsigned();

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
        public U2F30 LengthHalf() => U2F30.FromBits(LengthInternal());

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
        public I2F30 LengthHalfSigned() => I2F30.FromBits(checked((int)LengthInternal()));

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
        public U3F29 LengthUnsigned() => U3F29.FromBits(LengthInternal());

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
        public I3F29 LengthSigned() => I3F29.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U3F29 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30? Normalize() {
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

            const ulong k = 1UL << 29;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U2F30(
                U2F30.FromBits(y0),
                U2F30.FromBits(y1),
                U2F30.FromBits(y2),
                U2F30.FromBits(y3));
        }

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U2F30 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(X, X); }
        public Vector2U2F30 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(X, Y); }
        public Vector2U2F30 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(X, Z); }
        public Vector2U2F30 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(X, W); }
        public Vector2U2F30 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Y, X); }
        public Vector2U2F30 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Y, Y); }
        public Vector2U2F30 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Y, Z); }
        public Vector2U2F30 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Y, W); }
        public Vector2U2F30 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Z, X); }
        public Vector2U2F30 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Z, Y); }
        public Vector2U2F30 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Z, Z); }
        public Vector2U2F30 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(Z, W); }
        public Vector2U2F30 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(W, X); }
        public Vector2U2F30 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(W, Y); }
        public Vector2U2F30 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(W, Z); }
        public Vector2U2F30 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U2F30(W, W); }
        public Vector3U2F30 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, X, X); }
        public Vector3U2F30 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, X, Y); }
        public Vector3U2F30 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, X, Z); }
        public Vector3U2F30 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, X, W); }
        public Vector3U2F30 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Y, X); }
        public Vector3U2F30 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Y, Y); }
        public Vector3U2F30 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Y, Z); }
        public Vector3U2F30 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Y, W); }
        public Vector3U2F30 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Z, X); }
        public Vector3U2F30 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Z, Y); }
        public Vector3U2F30 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Z, Z); }
        public Vector3U2F30 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, Z, W); }
        public Vector3U2F30 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, W, X); }
        public Vector3U2F30 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, W, Y); }
        public Vector3U2F30 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, W, Z); }
        public Vector3U2F30 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(X, W, W); }
        public Vector3U2F30 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, X, X); }
        public Vector3U2F30 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, X, Y); }
        public Vector3U2F30 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, X, Z); }
        public Vector3U2F30 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, X, W); }
        public Vector3U2F30 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Y, X); }
        public Vector3U2F30 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Y, Y); }
        public Vector3U2F30 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Y, Z); }
        public Vector3U2F30 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Y, W); }
        public Vector3U2F30 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Z, X); }
        public Vector3U2F30 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Z, Y); }
        public Vector3U2F30 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Z, Z); }
        public Vector3U2F30 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, Z, W); }
        public Vector3U2F30 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, W, X); }
        public Vector3U2F30 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, W, Y); }
        public Vector3U2F30 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, W, Z); }
        public Vector3U2F30 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Y, W, W); }
        public Vector3U2F30 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, X, X); }
        public Vector3U2F30 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, X, Y); }
        public Vector3U2F30 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, X, Z); }
        public Vector3U2F30 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, X, W); }
        public Vector3U2F30 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Y, X); }
        public Vector3U2F30 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Y, Y); }
        public Vector3U2F30 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Y, Z); }
        public Vector3U2F30 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Y, W); }
        public Vector3U2F30 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Z, X); }
        public Vector3U2F30 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Z, Y); }
        public Vector3U2F30 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Z, Z); }
        public Vector3U2F30 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, Z, W); }
        public Vector3U2F30 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, W, X); }
        public Vector3U2F30 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, W, Y); }
        public Vector3U2F30 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, W, Z); }
        public Vector3U2F30 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(Z, W, W); }
        public Vector3U2F30 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(W, X, X); }
        public Vector3U2F30 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(W, X, Y); }
        public Vector3U2F30 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(W, X, Z); }
        public Vector3U2F30 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(W, X, W); }
        public Vector3U2F30 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(W, Y, X); }
        public Vector3U2F30 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(W, Y, Y); }
        public Vector3U2F30 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(W, Y, Z); }
        public Vector3U2F30 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(W, Y, W); }
        public Vector3U2F30 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(W, Z, X); }
        public Vector3U2F30 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(W, Z, Y); }
        public Vector3U2F30 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(W, Z, Z); }
        public Vector3U2F30 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(W, Z, W); }
        public Vector3U2F30 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(W, W, X); }
        public Vector3U2F30 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(W, W, Y); }
        public Vector3U2F30 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(W, W, Z); }
        public Vector3U2F30 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U2F30(W, W, W); }
        public Vector4U2F30 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, X, X); }
        public Vector4U2F30 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, X, Y); }
        public Vector4U2F30 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, X, Z); }
        public Vector4U2F30 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, X, W); }
        public Vector4U2F30 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Y, X); }
        public Vector4U2F30 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Y, Y); }
        public Vector4U2F30 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Y, Z); }
        public Vector4U2F30 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Y, W); }
        public Vector4U2F30 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Z, X); }
        public Vector4U2F30 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Z, Y); }
        public Vector4U2F30 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Z, Z); }
        public Vector4U2F30 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, Z, W); }
        public Vector4U2F30 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, W, X); }
        public Vector4U2F30 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, W, Y); }
        public Vector4U2F30 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, W, Z); }
        public Vector4U2F30 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, X, W, W); }
        public Vector4U2F30 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, X, X); }
        public Vector4U2F30 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, X, Y); }
        public Vector4U2F30 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, X, Z); }
        public Vector4U2F30 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, X, W); }
        public Vector4U2F30 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Y, X); }
        public Vector4U2F30 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Y, Y); }
        public Vector4U2F30 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Y, Z); }
        public Vector4U2F30 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Y, W); }
        public Vector4U2F30 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Z, X); }
        public Vector4U2F30 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Z, Y); }
        public Vector4U2F30 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Z, Z); }
        public Vector4U2F30 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, Z, W); }
        public Vector4U2F30 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, W, X); }
        public Vector4U2F30 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, W, Y); }
        public Vector4U2F30 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, W, Z); }
        public Vector4U2F30 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Y, W, W); }
        public Vector4U2F30 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, X, X); }
        public Vector4U2F30 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, X, Y); }
        public Vector4U2F30 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, X, Z); }
        public Vector4U2F30 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, X, W); }
        public Vector4U2F30 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Y, X); }
        public Vector4U2F30 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Y, Y); }
        public Vector4U2F30 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Y, Z); }
        public Vector4U2F30 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Y, W); }
        public Vector4U2F30 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Z, X); }
        public Vector4U2F30 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Z, Y); }
        public Vector4U2F30 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Z, Z); }
        public Vector4U2F30 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, Z, W); }
        public Vector4U2F30 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, W, X); }
        public Vector4U2F30 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, W, Y); }
        public Vector4U2F30 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, W, Z); }
        public Vector4U2F30 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, Z, W, W); }
        public Vector4U2F30 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, W, X, X); }
        public Vector4U2F30 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, W, X, Y); }
        public Vector4U2F30 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, W, X, Z); }
        public Vector4U2F30 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, W, X, W); }
        public Vector4U2F30 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, W, Y, X); }
        public Vector4U2F30 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, W, Y, Y); }
        public Vector4U2F30 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, W, Y, Z); }
        public Vector4U2F30 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, W, Y, W); }
        public Vector4U2F30 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, W, Z, X); }
        public Vector4U2F30 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, W, Z, Y); }
        public Vector4U2F30 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, W, Z, Z); }
        public Vector4U2F30 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, W, Z, W); }
        public Vector4U2F30 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, W, W, X); }
        public Vector4U2F30 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, W, W, Y); }
        public Vector4U2F30 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, W, W, Z); }
        public Vector4U2F30 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(X, W, W, W); }
        public Vector4U2F30 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, X, X); }
        public Vector4U2F30 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, X, Y); }
        public Vector4U2F30 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, X, Z); }
        public Vector4U2F30 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, X, W); }
        public Vector4U2F30 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Y, X); }
        public Vector4U2F30 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Y, Y); }
        public Vector4U2F30 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Y, Z); }
        public Vector4U2F30 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Y, W); }
        public Vector4U2F30 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Z, X); }
        public Vector4U2F30 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Z, Y); }
        public Vector4U2F30 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Z, Z); }
        public Vector4U2F30 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, Z, W); }
        public Vector4U2F30 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, W, X); }
        public Vector4U2F30 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, W, Y); }
        public Vector4U2F30 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, W, Z); }
        public Vector4U2F30 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, X, W, W); }
        public Vector4U2F30 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, X, X); }
        public Vector4U2F30 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, X, Y); }
        public Vector4U2F30 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, X, Z); }
        public Vector4U2F30 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, X, W); }
        public Vector4U2F30 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Y, X); }
        public Vector4U2F30 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Y, Y); }
        public Vector4U2F30 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Y, Z); }
        public Vector4U2F30 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Y, W); }
        public Vector4U2F30 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Z, X); }
        public Vector4U2F30 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Z, Y); }
        public Vector4U2F30 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Z, Z); }
        public Vector4U2F30 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, Z, W); }
        public Vector4U2F30 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, W, X); }
        public Vector4U2F30 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, W, Y); }
        public Vector4U2F30 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, W, Z); }
        public Vector4U2F30 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Y, W, W); }
        public Vector4U2F30 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, X, X); }
        public Vector4U2F30 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, X, Y); }
        public Vector4U2F30 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, X, Z); }
        public Vector4U2F30 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, X, W); }
        public Vector4U2F30 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Y, X); }
        public Vector4U2F30 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Y, Y); }
        public Vector4U2F30 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Y, Z); }
        public Vector4U2F30 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Y, W); }
        public Vector4U2F30 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Z, X); }
        public Vector4U2F30 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Z, Y); }
        public Vector4U2F30 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Z, Z); }
        public Vector4U2F30 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, Z, W); }
        public Vector4U2F30 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, W, X); }
        public Vector4U2F30 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, W, Y); }
        public Vector4U2F30 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, W, Z); }
        public Vector4U2F30 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, Z, W, W); }
        public Vector4U2F30 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, W, X, X); }
        public Vector4U2F30 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, W, X, Y); }
        public Vector4U2F30 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, W, X, Z); }
        public Vector4U2F30 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, W, X, W); }
        public Vector4U2F30 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, W, Y, X); }
        public Vector4U2F30 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, W, Y, Y); }
        public Vector4U2F30 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, W, Y, Z); }
        public Vector4U2F30 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, W, Y, W); }
        public Vector4U2F30 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, W, Z, X); }
        public Vector4U2F30 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, W, Z, Y); }
        public Vector4U2F30 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, W, Z, Z); }
        public Vector4U2F30 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, W, Z, W); }
        public Vector4U2F30 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, W, W, X); }
        public Vector4U2F30 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, W, W, Y); }
        public Vector4U2F30 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, W, W, Z); }
        public Vector4U2F30 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Y, W, W, W); }
        public Vector4U2F30 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, X, X); }
        public Vector4U2F30 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, X, Y); }
        public Vector4U2F30 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, X, Z); }
        public Vector4U2F30 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, X, W); }
        public Vector4U2F30 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Y, X); }
        public Vector4U2F30 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Y, Y); }
        public Vector4U2F30 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Y, Z); }
        public Vector4U2F30 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Y, W); }
        public Vector4U2F30 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Z, X); }
        public Vector4U2F30 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Z, Y); }
        public Vector4U2F30 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Z, Z); }
        public Vector4U2F30 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, Z, W); }
        public Vector4U2F30 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, W, X); }
        public Vector4U2F30 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, W, Y); }
        public Vector4U2F30 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, W, Z); }
        public Vector4U2F30 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, X, W, W); }
        public Vector4U2F30 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, X, X); }
        public Vector4U2F30 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, X, Y); }
        public Vector4U2F30 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, X, Z); }
        public Vector4U2F30 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, X, W); }
        public Vector4U2F30 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Y, X); }
        public Vector4U2F30 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Y, Y); }
        public Vector4U2F30 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Y, Z); }
        public Vector4U2F30 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Y, W); }
        public Vector4U2F30 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Z, X); }
        public Vector4U2F30 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Z, Y); }
        public Vector4U2F30 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Z, Z); }
        public Vector4U2F30 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, Z, W); }
        public Vector4U2F30 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, W, X); }
        public Vector4U2F30 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, W, Y); }
        public Vector4U2F30 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, W, Z); }
        public Vector4U2F30 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Y, W, W); }
        public Vector4U2F30 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, X, X); }
        public Vector4U2F30 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, X, Y); }
        public Vector4U2F30 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, X, Z); }
        public Vector4U2F30 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, X, W); }
        public Vector4U2F30 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Y, X); }
        public Vector4U2F30 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Y, Y); }
        public Vector4U2F30 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Y, Z); }
        public Vector4U2F30 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Y, W); }
        public Vector4U2F30 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Z, X); }
        public Vector4U2F30 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Z, Y); }
        public Vector4U2F30 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Z, Z); }
        public Vector4U2F30 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, Z, W); }
        public Vector4U2F30 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, W, X); }
        public Vector4U2F30 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, W, Y); }
        public Vector4U2F30 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, W, Z); }
        public Vector4U2F30 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, Z, W, W); }
        public Vector4U2F30 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, W, X, X); }
        public Vector4U2F30 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, W, X, Y); }
        public Vector4U2F30 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, W, X, Z); }
        public Vector4U2F30 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, W, X, W); }
        public Vector4U2F30 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, W, Y, X); }
        public Vector4U2F30 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, W, Y, Y); }
        public Vector4U2F30 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, W, Y, Z); }
        public Vector4U2F30 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, W, Y, W); }
        public Vector4U2F30 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, W, Z, X); }
        public Vector4U2F30 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, W, Z, Y); }
        public Vector4U2F30 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, W, Z, Z); }
        public Vector4U2F30 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, W, Z, W); }
        public Vector4U2F30 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, W, W, X); }
        public Vector4U2F30 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, W, W, Y); }
        public Vector4U2F30 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, W, W, Z); }
        public Vector4U2F30 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(Z, W, W, W); }
        public Vector4U2F30 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, X, X, X); }
        public Vector4U2F30 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, X, X, Y); }
        public Vector4U2F30 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, X, X, Z); }
        public Vector4U2F30 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, X, X, W); }
        public Vector4U2F30 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, X, Y, X); }
        public Vector4U2F30 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, X, Y, Y); }
        public Vector4U2F30 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, X, Y, Z); }
        public Vector4U2F30 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, X, Y, W); }
        public Vector4U2F30 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, X, Z, X); }
        public Vector4U2F30 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, X, Z, Y); }
        public Vector4U2F30 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, X, Z, Z); }
        public Vector4U2F30 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, X, Z, W); }
        public Vector4U2F30 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, X, W, X); }
        public Vector4U2F30 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, X, W, Y); }
        public Vector4U2F30 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, X, W, Z); }
        public Vector4U2F30 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, X, W, W); }
        public Vector4U2F30 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Y, X, X); }
        public Vector4U2F30 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Y, X, Y); }
        public Vector4U2F30 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Y, X, Z); }
        public Vector4U2F30 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Y, X, W); }
        public Vector4U2F30 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Y, Y, X); }
        public Vector4U2F30 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Y, Y, Y); }
        public Vector4U2F30 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Y, Y, Z); }
        public Vector4U2F30 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Y, Y, W); }
        public Vector4U2F30 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Y, Z, X); }
        public Vector4U2F30 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Y, Z, Y); }
        public Vector4U2F30 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Y, Z, Z); }
        public Vector4U2F30 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Y, Z, W); }
        public Vector4U2F30 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Y, W, X); }
        public Vector4U2F30 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Y, W, Y); }
        public Vector4U2F30 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Y, W, Z); }
        public Vector4U2F30 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Y, W, W); }
        public Vector4U2F30 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Z, X, X); }
        public Vector4U2F30 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Z, X, Y); }
        public Vector4U2F30 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Z, X, Z); }
        public Vector4U2F30 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Z, X, W); }
        public Vector4U2F30 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Z, Y, X); }
        public Vector4U2F30 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Z, Y, Y); }
        public Vector4U2F30 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Z, Y, Z); }
        public Vector4U2F30 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Z, Y, W); }
        public Vector4U2F30 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Z, Z, X); }
        public Vector4U2F30 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Z, Z, Y); }
        public Vector4U2F30 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Z, Z, Z); }
        public Vector4U2F30 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Z, Z, W); }
        public Vector4U2F30 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Z, W, X); }
        public Vector4U2F30 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Z, W, Y); }
        public Vector4U2F30 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Z, W, Z); }
        public Vector4U2F30 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, Z, W, W); }
        public Vector4U2F30 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, W, X, X); }
        public Vector4U2F30 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, W, X, Y); }
        public Vector4U2F30 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, W, X, Z); }
        public Vector4U2F30 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, W, X, W); }
        public Vector4U2F30 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, W, Y, X); }
        public Vector4U2F30 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, W, Y, Y); }
        public Vector4U2F30 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, W, Y, Z); }
        public Vector4U2F30 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, W, Y, W); }
        public Vector4U2F30 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, W, Z, X); }
        public Vector4U2F30 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, W, Z, Y); }
        public Vector4U2F30 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, W, Z, Z); }
        public Vector4U2F30 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, W, Z, W); }
        public Vector4U2F30 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, W, W, X); }
        public Vector4U2F30 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, W, W, Y); }
        public Vector4U2F30 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, W, W, Z); }
        public Vector4U2F30 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U2F30(W, W, W, W); }

    }

    partial struct U2F30 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U2F30 SaturatingMul(Vector4U2F30 other) => other.SaturatingMul(this);
    }
}
