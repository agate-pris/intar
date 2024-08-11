using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U27F5
    : IEquatable<Vector4U27F5>
    , IFormattable
    , IVector<U56F8, I56F8, U28F4, I28F4>
    , IVectorComponentRespective<U27F5> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U27F5 X;
        public U27F5 Y;
        public U27F5 Z;
        public U27F5 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(U27F5 x, U27F5 y, U27F5 z, U27F5 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(U27F5 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(U27F5 x, U27F5 y, Vector2U27F5 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(U27F5 x, Vector3U27F5 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(Vector2U27F5 xy, Vector2U27F5 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(Vector4U27F5 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(U27F5 x, Vector2U27F5 yz, U27F5 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(Vector3U27F5 xyz, U27F5 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5(Vector2U27F5 xy, U27F5 z, U27F5 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U27F5 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U27F5(U27F5.Zero);
        }
        public static Vector4U27F5 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U27F5(U27F5.One);
        }
        public static Vector4U27F5 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U27F5(U27F5.One, U27F5.Zero, U27F5.Zero, U27F5.Zero);
        }
        public static Vector4U27F5 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U27F5(U27F5.Zero, U27F5.One, U27F5.Zero, U27F5.Zero);
        }
        public static Vector4U27F5 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U27F5(U27F5.Zero, U27F5.Zero, U27F5.One, U27F5.Zero);
        }
        public static Vector4U27F5 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U27F5(U27F5.Zero, U27F5.Zero, U27F5.Zero, U27F5.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator +(Vector4U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator -(Vector4U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator *(Vector4U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator *(Vector4U27F5 a, U27F5 b) => new Vector4U27F5(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator *(U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator /(Vector4U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator /(Vector4U27F5 a, U27F5 b) => new Vector4U27F5(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U27F5 operator /(U27F5 a, Vector4U27F5 b) => new Vector4U27F5(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U27F5 lhs, Vector4U27F5 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U27F5 lhs, Vector4U27F5 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U27F5 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U27F5 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U27F5>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U27F5 other)
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
        public Vector4U27F5 Min(Vector4U27F5 other) => new Vector4U27F5(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5 Max(Vector4U27F5 other) => new Vector4U27F5(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5 Half() => new Vector4U27F5(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5 Twice() => new Vector4U27F5(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5 Clamp(U27F5 min, U27F5 max) => new Vector4U27F5(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5 Clamp(
            Vector4U27F5 min, Vector4U27F5 max
        ) => new Vector4U27F5(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5 WrappingAdd(Vector4U27F5 other) => new Vector4U27F5(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5 WrappingSub(Vector4U27F5 other) => new Vector4U27F5(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5 WrappingMul(Vector4U27F5 other) => new Vector4U27F5(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5 WrappingAddSigned(Vector4I27F5 other) => new Vector4U27F5(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5 SaturatingAdd(Vector4U27F5 other) => new Vector4U27F5(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5 SaturatingMul(U27F5 other) => new Vector4U27F5(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U27F5 other) {
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
        public U27F5 Dot(Vector4U27F5 other) {
            const ulong k = 1UL << 3;
            return U27F5.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U27F5 SaturatingDot(Vector4U27F5 other) {
            const ulong k = 1UL << 3;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U27F5.MaxValue;
            } else {
                return U27F5.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U56F8 LengthSquaredUnsigned() => U56F8.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I56F8 LengthSquaredSigned() => I56F8.FromBits(
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
        public U56F8 LengthSquared() => LengthSquaredUnsigned();

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
        public U27F5 LengthHalf() => U27F5.FromBits(LengthInternal());

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
        public I27F5 LengthHalfSigned() => I27F5.FromBits(checked((int)LengthInternal()));

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
        public U28F4 LengthUnsigned() => U28F4.FromBits(LengthInternal());

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
        public I28F4 LengthSigned() => I28F4.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U28F4 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U27F5? Normalize() {
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

            const ulong k = 1UL << 4;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U27F5(
                U27F5.FromBits(y0),
                U27F5.FromBits(y1),
                U27F5.FromBits(y2),
                U27F5.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U27F5 XX() => new Vector2U27F5(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U27F5 XY() => new Vector2U27F5(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U27F5 XZ() => new Vector2U27F5(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U27F5 XW() => new Vector2U27F5(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U27F5 YX() => new Vector2U27F5(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U27F5 YY() => new Vector2U27F5(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U27F5 YZ() => new Vector2U27F5(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U27F5 YW() => new Vector2U27F5(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U27F5 ZX() => new Vector2U27F5(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U27F5 ZY() => new Vector2U27F5(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U27F5 ZZ() => new Vector2U27F5(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U27F5 ZW() => new Vector2U27F5(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U27F5 WX() => new Vector2U27F5(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U27F5 WY() => new Vector2U27F5(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U27F5 WZ() => new Vector2U27F5(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U27F5 WW() => new Vector2U27F5(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 XXX() => new Vector3U27F5(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 XXY() => new Vector3U27F5(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 XXZ() => new Vector3U27F5(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 XXW() => new Vector3U27F5(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 XYX() => new Vector3U27F5(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 XYY() => new Vector3U27F5(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 XYZ() => new Vector3U27F5(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 XYW() => new Vector3U27F5(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 XZX() => new Vector3U27F5(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 XZY() => new Vector3U27F5(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 XZZ() => new Vector3U27F5(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 XZW() => new Vector3U27F5(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 XWX() => new Vector3U27F5(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 XWY() => new Vector3U27F5(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 XWZ() => new Vector3U27F5(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 XWW() => new Vector3U27F5(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 YXX() => new Vector3U27F5(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 YXY() => new Vector3U27F5(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 YXZ() => new Vector3U27F5(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 YXW() => new Vector3U27F5(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 YYX() => new Vector3U27F5(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 YYY() => new Vector3U27F5(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 YYZ() => new Vector3U27F5(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 YYW() => new Vector3U27F5(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 YZX() => new Vector3U27F5(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 YZY() => new Vector3U27F5(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 YZZ() => new Vector3U27F5(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 YZW() => new Vector3U27F5(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 YWX() => new Vector3U27F5(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 YWY() => new Vector3U27F5(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 YWZ() => new Vector3U27F5(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 YWW() => new Vector3U27F5(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 ZXX() => new Vector3U27F5(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 ZXY() => new Vector3U27F5(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 ZXZ() => new Vector3U27F5(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 ZXW() => new Vector3U27F5(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 ZYX() => new Vector3U27F5(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 ZYY() => new Vector3U27F5(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 ZYZ() => new Vector3U27F5(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 ZYW() => new Vector3U27F5(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 ZZX() => new Vector3U27F5(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 ZZY() => new Vector3U27F5(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 ZZZ() => new Vector3U27F5(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 ZZW() => new Vector3U27F5(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 ZWX() => new Vector3U27F5(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 ZWY() => new Vector3U27F5(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 ZWZ() => new Vector3U27F5(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 ZWW() => new Vector3U27F5(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 WXX() => new Vector3U27F5(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 WXY() => new Vector3U27F5(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 WXZ() => new Vector3U27F5(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 WXW() => new Vector3U27F5(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 WYX() => new Vector3U27F5(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 WYY() => new Vector3U27F5(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 WYZ() => new Vector3U27F5(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 WYW() => new Vector3U27F5(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 WZX() => new Vector3U27F5(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 WZY() => new Vector3U27F5(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 WZZ() => new Vector3U27F5(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 WZW() => new Vector3U27F5(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 WWX() => new Vector3U27F5(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 WWY() => new Vector3U27F5(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 WWZ() => new Vector3U27F5(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U27F5 WWW() => new Vector3U27F5(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XXXX() => new Vector4U27F5(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XXXY() => new Vector4U27F5(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XXXZ() => new Vector4U27F5(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XXXW() => new Vector4U27F5(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XXYX() => new Vector4U27F5(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XXYY() => new Vector4U27F5(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XXYZ() => new Vector4U27F5(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XXYW() => new Vector4U27F5(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XXZX() => new Vector4U27F5(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XXZY() => new Vector4U27F5(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XXZZ() => new Vector4U27F5(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XXZW() => new Vector4U27F5(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XXWX() => new Vector4U27F5(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XXWY() => new Vector4U27F5(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XXWZ() => new Vector4U27F5(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XXWW() => new Vector4U27F5(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XYXX() => new Vector4U27F5(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XYXY() => new Vector4U27F5(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XYXZ() => new Vector4U27F5(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XYXW() => new Vector4U27F5(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XYYX() => new Vector4U27F5(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XYYY() => new Vector4U27F5(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XYYZ() => new Vector4U27F5(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XYYW() => new Vector4U27F5(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XYZX() => new Vector4U27F5(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XYZY() => new Vector4U27F5(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XYZZ() => new Vector4U27F5(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XYZW() => new Vector4U27F5(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XYWX() => new Vector4U27F5(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XYWY() => new Vector4U27F5(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XYWZ() => new Vector4U27F5(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XYWW() => new Vector4U27F5(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XZXX() => new Vector4U27F5(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XZXY() => new Vector4U27F5(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XZXZ() => new Vector4U27F5(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XZXW() => new Vector4U27F5(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XZYX() => new Vector4U27F5(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XZYY() => new Vector4U27F5(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XZYZ() => new Vector4U27F5(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XZYW() => new Vector4U27F5(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XZZX() => new Vector4U27F5(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XZZY() => new Vector4U27F5(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XZZZ() => new Vector4U27F5(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XZZW() => new Vector4U27F5(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XZWX() => new Vector4U27F5(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XZWY() => new Vector4U27F5(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XZWZ() => new Vector4U27F5(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XZWW() => new Vector4U27F5(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XWXX() => new Vector4U27F5(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XWXY() => new Vector4U27F5(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XWXZ() => new Vector4U27F5(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XWXW() => new Vector4U27F5(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XWYX() => new Vector4U27F5(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XWYY() => new Vector4U27F5(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XWYZ() => new Vector4U27F5(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XWYW() => new Vector4U27F5(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XWZX() => new Vector4U27F5(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XWZY() => new Vector4U27F5(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XWZZ() => new Vector4U27F5(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XWZW() => new Vector4U27F5(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XWWX() => new Vector4U27F5(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XWWY() => new Vector4U27F5(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XWWZ() => new Vector4U27F5(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 XWWW() => new Vector4U27F5(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YXXX() => new Vector4U27F5(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YXXY() => new Vector4U27F5(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YXXZ() => new Vector4U27F5(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YXXW() => new Vector4U27F5(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YXYX() => new Vector4U27F5(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YXYY() => new Vector4U27F5(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YXYZ() => new Vector4U27F5(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YXYW() => new Vector4U27F5(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YXZX() => new Vector4U27F5(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YXZY() => new Vector4U27F5(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YXZZ() => new Vector4U27F5(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YXZW() => new Vector4U27F5(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YXWX() => new Vector4U27F5(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YXWY() => new Vector4U27F5(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YXWZ() => new Vector4U27F5(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YXWW() => new Vector4U27F5(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YYXX() => new Vector4U27F5(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YYXY() => new Vector4U27F5(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YYXZ() => new Vector4U27F5(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YYXW() => new Vector4U27F5(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YYYX() => new Vector4U27F5(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YYYY() => new Vector4U27F5(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YYYZ() => new Vector4U27F5(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YYYW() => new Vector4U27F5(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YYZX() => new Vector4U27F5(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YYZY() => new Vector4U27F5(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YYZZ() => new Vector4U27F5(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YYZW() => new Vector4U27F5(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YYWX() => new Vector4U27F5(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YYWY() => new Vector4U27F5(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YYWZ() => new Vector4U27F5(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YYWW() => new Vector4U27F5(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YZXX() => new Vector4U27F5(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YZXY() => new Vector4U27F5(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YZXZ() => new Vector4U27F5(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YZXW() => new Vector4U27F5(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YZYX() => new Vector4U27F5(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YZYY() => new Vector4U27F5(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YZYZ() => new Vector4U27F5(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YZYW() => new Vector4U27F5(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YZZX() => new Vector4U27F5(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YZZY() => new Vector4U27F5(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YZZZ() => new Vector4U27F5(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YZZW() => new Vector4U27F5(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YZWX() => new Vector4U27F5(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YZWY() => new Vector4U27F5(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YZWZ() => new Vector4U27F5(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YZWW() => new Vector4U27F5(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YWXX() => new Vector4U27F5(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YWXY() => new Vector4U27F5(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YWXZ() => new Vector4U27F5(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YWXW() => new Vector4U27F5(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YWYX() => new Vector4U27F5(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YWYY() => new Vector4U27F5(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YWYZ() => new Vector4U27F5(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YWYW() => new Vector4U27F5(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YWZX() => new Vector4U27F5(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YWZY() => new Vector4U27F5(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YWZZ() => new Vector4U27F5(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YWZW() => new Vector4U27F5(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YWWX() => new Vector4U27F5(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YWWY() => new Vector4U27F5(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YWWZ() => new Vector4U27F5(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 YWWW() => new Vector4U27F5(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZXXX() => new Vector4U27F5(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZXXY() => new Vector4U27F5(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZXXZ() => new Vector4U27F5(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZXXW() => new Vector4U27F5(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZXYX() => new Vector4U27F5(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZXYY() => new Vector4U27F5(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZXYZ() => new Vector4U27F5(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZXYW() => new Vector4U27F5(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZXZX() => new Vector4U27F5(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZXZY() => new Vector4U27F5(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZXZZ() => new Vector4U27F5(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZXZW() => new Vector4U27F5(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZXWX() => new Vector4U27F5(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZXWY() => new Vector4U27F5(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZXWZ() => new Vector4U27F5(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZXWW() => new Vector4U27F5(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZYXX() => new Vector4U27F5(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZYXY() => new Vector4U27F5(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZYXZ() => new Vector4U27F5(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZYXW() => new Vector4U27F5(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZYYX() => new Vector4U27F5(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZYYY() => new Vector4U27F5(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZYYZ() => new Vector4U27F5(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZYYW() => new Vector4U27F5(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZYZX() => new Vector4U27F5(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZYZY() => new Vector4U27F5(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZYZZ() => new Vector4U27F5(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZYZW() => new Vector4U27F5(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZYWX() => new Vector4U27F5(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZYWY() => new Vector4U27F5(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZYWZ() => new Vector4U27F5(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZYWW() => new Vector4U27F5(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZZXX() => new Vector4U27F5(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZZXY() => new Vector4U27F5(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZZXZ() => new Vector4U27F5(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZZXW() => new Vector4U27F5(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZZYX() => new Vector4U27F5(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZZYY() => new Vector4U27F5(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZZYZ() => new Vector4U27F5(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZZYW() => new Vector4U27F5(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZZZX() => new Vector4U27F5(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZZZY() => new Vector4U27F5(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZZZZ() => new Vector4U27F5(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZZZW() => new Vector4U27F5(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZZWX() => new Vector4U27F5(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZZWY() => new Vector4U27F5(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZZWZ() => new Vector4U27F5(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZZWW() => new Vector4U27F5(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZWXX() => new Vector4U27F5(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZWXY() => new Vector4U27F5(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZWXZ() => new Vector4U27F5(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZWXW() => new Vector4U27F5(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZWYX() => new Vector4U27F5(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZWYY() => new Vector4U27F5(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZWYZ() => new Vector4U27F5(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZWYW() => new Vector4U27F5(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZWZX() => new Vector4U27F5(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZWZY() => new Vector4U27F5(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZWZZ() => new Vector4U27F5(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZWZW() => new Vector4U27F5(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZWWX() => new Vector4U27F5(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZWWY() => new Vector4U27F5(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZWWZ() => new Vector4U27F5(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 ZWWW() => new Vector4U27F5(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WXXX() => new Vector4U27F5(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WXXY() => new Vector4U27F5(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WXXZ() => new Vector4U27F5(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WXXW() => new Vector4U27F5(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WXYX() => new Vector4U27F5(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WXYY() => new Vector4U27F5(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WXYZ() => new Vector4U27F5(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WXYW() => new Vector4U27F5(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WXZX() => new Vector4U27F5(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WXZY() => new Vector4U27F5(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WXZZ() => new Vector4U27F5(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WXZW() => new Vector4U27F5(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WXWX() => new Vector4U27F5(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WXWY() => new Vector4U27F5(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WXWZ() => new Vector4U27F5(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WXWW() => new Vector4U27F5(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WYXX() => new Vector4U27F5(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WYXY() => new Vector4U27F5(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WYXZ() => new Vector4U27F5(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WYXW() => new Vector4U27F5(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WYYX() => new Vector4U27F5(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WYYY() => new Vector4U27F5(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WYYZ() => new Vector4U27F5(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WYYW() => new Vector4U27F5(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WYZX() => new Vector4U27F5(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WYZY() => new Vector4U27F5(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WYZZ() => new Vector4U27F5(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WYZW() => new Vector4U27F5(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WYWX() => new Vector4U27F5(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WYWY() => new Vector4U27F5(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WYWZ() => new Vector4U27F5(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WYWW() => new Vector4U27F5(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WZXX() => new Vector4U27F5(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WZXY() => new Vector4U27F5(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WZXZ() => new Vector4U27F5(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WZXW() => new Vector4U27F5(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WZYX() => new Vector4U27F5(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WZYY() => new Vector4U27F5(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WZYZ() => new Vector4U27F5(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WZYW() => new Vector4U27F5(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WZZX() => new Vector4U27F5(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WZZY() => new Vector4U27F5(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WZZZ() => new Vector4U27F5(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WZZW() => new Vector4U27F5(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WZWX() => new Vector4U27F5(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WZWY() => new Vector4U27F5(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WZWZ() => new Vector4U27F5(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WZWW() => new Vector4U27F5(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WWXX() => new Vector4U27F5(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WWXY() => new Vector4U27F5(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WWXZ() => new Vector4U27F5(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WWXW() => new Vector4U27F5(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WWYX() => new Vector4U27F5(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WWYY() => new Vector4U27F5(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WWYZ() => new Vector4U27F5(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WWYW() => new Vector4U27F5(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WWZX() => new Vector4U27F5(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WWZY() => new Vector4U27F5(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WWZZ() => new Vector4U27F5(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WWZW() => new Vector4U27F5(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WWWX() => new Vector4U27F5(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WWWY() => new Vector4U27F5(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WWWZ() => new Vector4U27F5(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U27F5 WWWW() => new Vector4U27F5(W, W, W, W);

    }
}
