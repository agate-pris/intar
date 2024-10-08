using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U26F6
    : IEquatable<Vector4U26F6>
    , IFormattable
    , IVector<U54F10, I54F10, U27F5, I27F5>
    , IVectorComponentRespective<U26F6> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U26F6 X;
        public U26F6 Y;
        public U26F6 Z;
        public U26F6 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(U26F6 x, U26F6 y, U26F6 z, U26F6 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(U26F6 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(U26F6 x, U26F6 y, Vector2U26F6 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(U26F6 x, Vector3U26F6 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(Vector2U26F6 xy, Vector2U26F6 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(Vector4U26F6 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(U26F6 x, Vector2U26F6 yz, U26F6 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(Vector3U26F6 xyz, U26F6 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6(Vector2U26F6 xy, U26F6 z, U26F6 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U26F6 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.Zero);
        }
        public static Vector4U26F6 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.One);
        }
        public static Vector4U26F6 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.One, U26F6.Zero, U26F6.Zero, U26F6.Zero);
        }
        public static Vector4U26F6 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.Zero, U26F6.One, U26F6.Zero, U26F6.Zero);
        }
        public static Vector4U26F6 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.Zero, U26F6.Zero, U26F6.One, U26F6.Zero);
        }
        public static Vector4U26F6 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U26F6(U26F6.Zero, U26F6.Zero, U26F6.Zero, U26F6.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator +(Vector4U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator -(Vector4U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator *(Vector4U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator *(Vector4U26F6 a, U26F6 b) => new Vector4U26F6(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator *(U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator /(Vector4U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator /(Vector4U26F6 a, U26F6 b) => new Vector4U26F6(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U26F6 operator /(U26F6 a, Vector4U26F6 b) => new Vector4U26F6(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U26F6 lhs, Vector4U26F6 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U26F6 lhs, Vector4U26F6 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U26F6 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U26F6 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U26F6>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U26F6 other)
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
        public Vector4U26F6 Min(Vector4U26F6 other) => new Vector4U26F6(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6 Max(Vector4U26F6 other) => new Vector4U26F6(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6 Half() => new Vector4U26F6(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6 Twice() => new Vector4U26F6(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6 Clamp(U26F6 min, U26F6 max) => new Vector4U26F6(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6 Clamp(
            Vector4U26F6 min, Vector4U26F6 max
        ) => new Vector4U26F6(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6 WrappingAdd(Vector4U26F6 other) => new Vector4U26F6(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6 WrappingSub(Vector4U26F6 other) => new Vector4U26F6(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6 WrappingMul(Vector4U26F6 other) => new Vector4U26F6(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6 WrappingAddSigned(Vector4I26F6 other) => new Vector4U26F6(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6 SaturatingAdd(Vector4U26F6 other) => new Vector4U26F6(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6 SaturatingMul(U26F6 other) => new Vector4U26F6(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U26F6 other) {
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
        public U26F6 Dot(Vector4U26F6 other) {
            const ulong k = 1UL << 4;
            return U26F6.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U26F6 SaturatingDot(Vector4U26F6 other) {
            const ulong k = 1UL << 4;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U26F6.MaxValue;
            } else {
                return U26F6.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U54F10 LengthSquaredUnsigned() => U54F10.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I54F10 LengthSquaredSigned() => I54F10.FromBits(
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
        public U54F10 LengthSquared() => LengthSquaredUnsigned();

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
        public U26F6 LengthHalf() => U26F6.FromBits(LengthInternal());

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
        public I26F6 LengthHalfSigned() => I26F6.FromBits(checked((int)LengthInternal()));

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
        public U27F5 LengthUnsigned() => U27F5.FromBits(LengthInternal());

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
        public I27F5 LengthSigned() => I27F5.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U27F5 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U26F6? Normalize() {
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

            const ulong k = 1UL << 5;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U26F6(
                U26F6.FromBits(y0),
                U26F6.FromBits(y1),
                U26F6.FromBits(y2),
                U26F6.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U26F6 XX() => new Vector2U26F6(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U26F6 XY() => new Vector2U26F6(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U26F6 XZ() => new Vector2U26F6(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U26F6 XW() => new Vector2U26F6(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U26F6 YX() => new Vector2U26F6(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U26F6 YY() => new Vector2U26F6(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U26F6 YZ() => new Vector2U26F6(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U26F6 YW() => new Vector2U26F6(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U26F6 ZX() => new Vector2U26F6(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U26F6 ZY() => new Vector2U26F6(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U26F6 ZZ() => new Vector2U26F6(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U26F6 ZW() => new Vector2U26F6(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U26F6 WX() => new Vector2U26F6(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U26F6 WY() => new Vector2U26F6(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U26F6 WZ() => new Vector2U26F6(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U26F6 WW() => new Vector2U26F6(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 XXX() => new Vector3U26F6(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 XXY() => new Vector3U26F6(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 XXZ() => new Vector3U26F6(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 XXW() => new Vector3U26F6(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 XYX() => new Vector3U26F6(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 XYY() => new Vector3U26F6(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 XYZ() => new Vector3U26F6(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 XYW() => new Vector3U26F6(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 XZX() => new Vector3U26F6(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 XZY() => new Vector3U26F6(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 XZZ() => new Vector3U26F6(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 XZW() => new Vector3U26F6(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 XWX() => new Vector3U26F6(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 XWY() => new Vector3U26F6(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 XWZ() => new Vector3U26F6(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 XWW() => new Vector3U26F6(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 YXX() => new Vector3U26F6(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 YXY() => new Vector3U26F6(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 YXZ() => new Vector3U26F6(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 YXW() => new Vector3U26F6(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 YYX() => new Vector3U26F6(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 YYY() => new Vector3U26F6(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 YYZ() => new Vector3U26F6(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 YYW() => new Vector3U26F6(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 YZX() => new Vector3U26F6(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 YZY() => new Vector3U26F6(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 YZZ() => new Vector3U26F6(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 YZW() => new Vector3U26F6(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 YWX() => new Vector3U26F6(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 YWY() => new Vector3U26F6(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 YWZ() => new Vector3U26F6(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 YWW() => new Vector3U26F6(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 ZXX() => new Vector3U26F6(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 ZXY() => new Vector3U26F6(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 ZXZ() => new Vector3U26F6(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 ZXW() => new Vector3U26F6(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 ZYX() => new Vector3U26F6(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 ZYY() => new Vector3U26F6(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 ZYZ() => new Vector3U26F6(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 ZYW() => new Vector3U26F6(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 ZZX() => new Vector3U26F6(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 ZZY() => new Vector3U26F6(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 ZZZ() => new Vector3U26F6(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 ZZW() => new Vector3U26F6(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 ZWX() => new Vector3U26F6(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 ZWY() => new Vector3U26F6(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 ZWZ() => new Vector3U26F6(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 ZWW() => new Vector3U26F6(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 WXX() => new Vector3U26F6(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 WXY() => new Vector3U26F6(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 WXZ() => new Vector3U26F6(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 WXW() => new Vector3U26F6(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 WYX() => new Vector3U26F6(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 WYY() => new Vector3U26F6(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 WYZ() => new Vector3U26F6(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 WYW() => new Vector3U26F6(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 WZX() => new Vector3U26F6(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 WZY() => new Vector3U26F6(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 WZZ() => new Vector3U26F6(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 WZW() => new Vector3U26F6(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 WWX() => new Vector3U26F6(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 WWY() => new Vector3U26F6(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 WWZ() => new Vector3U26F6(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U26F6 WWW() => new Vector3U26F6(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XXXX() => new Vector4U26F6(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XXXY() => new Vector4U26F6(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XXXZ() => new Vector4U26F6(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XXXW() => new Vector4U26F6(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XXYX() => new Vector4U26F6(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XXYY() => new Vector4U26F6(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XXYZ() => new Vector4U26F6(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XXYW() => new Vector4U26F6(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XXZX() => new Vector4U26F6(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XXZY() => new Vector4U26F6(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XXZZ() => new Vector4U26F6(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XXZW() => new Vector4U26F6(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XXWX() => new Vector4U26F6(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XXWY() => new Vector4U26F6(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XXWZ() => new Vector4U26F6(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XXWW() => new Vector4U26F6(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XYXX() => new Vector4U26F6(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XYXY() => new Vector4U26F6(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XYXZ() => new Vector4U26F6(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XYXW() => new Vector4U26F6(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XYYX() => new Vector4U26F6(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XYYY() => new Vector4U26F6(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XYYZ() => new Vector4U26F6(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XYYW() => new Vector4U26F6(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XYZX() => new Vector4U26F6(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XYZY() => new Vector4U26F6(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XYZZ() => new Vector4U26F6(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XYZW() => new Vector4U26F6(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XYWX() => new Vector4U26F6(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XYWY() => new Vector4U26F6(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XYWZ() => new Vector4U26F6(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XYWW() => new Vector4U26F6(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XZXX() => new Vector4U26F6(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XZXY() => new Vector4U26F6(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XZXZ() => new Vector4U26F6(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XZXW() => new Vector4U26F6(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XZYX() => new Vector4U26F6(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XZYY() => new Vector4U26F6(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XZYZ() => new Vector4U26F6(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XZYW() => new Vector4U26F6(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XZZX() => new Vector4U26F6(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XZZY() => new Vector4U26F6(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XZZZ() => new Vector4U26F6(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XZZW() => new Vector4U26F6(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XZWX() => new Vector4U26F6(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XZWY() => new Vector4U26F6(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XZWZ() => new Vector4U26F6(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XZWW() => new Vector4U26F6(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XWXX() => new Vector4U26F6(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XWXY() => new Vector4U26F6(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XWXZ() => new Vector4U26F6(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XWXW() => new Vector4U26F6(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XWYX() => new Vector4U26F6(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XWYY() => new Vector4U26F6(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XWYZ() => new Vector4U26F6(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XWYW() => new Vector4U26F6(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XWZX() => new Vector4U26F6(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XWZY() => new Vector4U26F6(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XWZZ() => new Vector4U26F6(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XWZW() => new Vector4U26F6(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XWWX() => new Vector4U26F6(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XWWY() => new Vector4U26F6(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XWWZ() => new Vector4U26F6(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 XWWW() => new Vector4U26F6(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YXXX() => new Vector4U26F6(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YXXY() => new Vector4U26F6(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YXXZ() => new Vector4U26F6(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YXXW() => new Vector4U26F6(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YXYX() => new Vector4U26F6(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YXYY() => new Vector4U26F6(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YXYZ() => new Vector4U26F6(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YXYW() => new Vector4U26F6(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YXZX() => new Vector4U26F6(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YXZY() => new Vector4U26F6(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YXZZ() => new Vector4U26F6(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YXZW() => new Vector4U26F6(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YXWX() => new Vector4U26F6(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YXWY() => new Vector4U26F6(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YXWZ() => new Vector4U26F6(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YXWW() => new Vector4U26F6(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YYXX() => new Vector4U26F6(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YYXY() => new Vector4U26F6(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YYXZ() => new Vector4U26F6(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YYXW() => new Vector4U26F6(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YYYX() => new Vector4U26F6(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YYYY() => new Vector4U26F6(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YYYZ() => new Vector4U26F6(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YYYW() => new Vector4U26F6(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YYZX() => new Vector4U26F6(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YYZY() => new Vector4U26F6(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YYZZ() => new Vector4U26F6(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YYZW() => new Vector4U26F6(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YYWX() => new Vector4U26F6(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YYWY() => new Vector4U26F6(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YYWZ() => new Vector4U26F6(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YYWW() => new Vector4U26F6(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YZXX() => new Vector4U26F6(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YZXY() => new Vector4U26F6(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YZXZ() => new Vector4U26F6(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YZXW() => new Vector4U26F6(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YZYX() => new Vector4U26F6(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YZYY() => new Vector4U26F6(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YZYZ() => new Vector4U26F6(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YZYW() => new Vector4U26F6(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YZZX() => new Vector4U26F6(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YZZY() => new Vector4U26F6(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YZZZ() => new Vector4U26F6(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YZZW() => new Vector4U26F6(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YZWX() => new Vector4U26F6(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YZWY() => new Vector4U26F6(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YZWZ() => new Vector4U26F6(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YZWW() => new Vector4U26F6(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YWXX() => new Vector4U26F6(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YWXY() => new Vector4U26F6(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YWXZ() => new Vector4U26F6(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YWXW() => new Vector4U26F6(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YWYX() => new Vector4U26F6(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YWYY() => new Vector4U26F6(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YWYZ() => new Vector4U26F6(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YWYW() => new Vector4U26F6(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YWZX() => new Vector4U26F6(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YWZY() => new Vector4U26F6(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YWZZ() => new Vector4U26F6(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YWZW() => new Vector4U26F6(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YWWX() => new Vector4U26F6(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YWWY() => new Vector4U26F6(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YWWZ() => new Vector4U26F6(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 YWWW() => new Vector4U26F6(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZXXX() => new Vector4U26F6(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZXXY() => new Vector4U26F6(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZXXZ() => new Vector4U26F6(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZXXW() => new Vector4U26F6(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZXYX() => new Vector4U26F6(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZXYY() => new Vector4U26F6(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZXYZ() => new Vector4U26F6(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZXYW() => new Vector4U26F6(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZXZX() => new Vector4U26F6(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZXZY() => new Vector4U26F6(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZXZZ() => new Vector4U26F6(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZXZW() => new Vector4U26F6(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZXWX() => new Vector4U26F6(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZXWY() => new Vector4U26F6(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZXWZ() => new Vector4U26F6(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZXWW() => new Vector4U26F6(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZYXX() => new Vector4U26F6(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZYXY() => new Vector4U26F6(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZYXZ() => new Vector4U26F6(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZYXW() => new Vector4U26F6(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZYYX() => new Vector4U26F6(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZYYY() => new Vector4U26F6(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZYYZ() => new Vector4U26F6(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZYYW() => new Vector4U26F6(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZYZX() => new Vector4U26F6(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZYZY() => new Vector4U26F6(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZYZZ() => new Vector4U26F6(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZYZW() => new Vector4U26F6(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZYWX() => new Vector4U26F6(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZYWY() => new Vector4U26F6(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZYWZ() => new Vector4U26F6(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZYWW() => new Vector4U26F6(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZZXX() => new Vector4U26F6(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZZXY() => new Vector4U26F6(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZZXZ() => new Vector4U26F6(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZZXW() => new Vector4U26F6(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZZYX() => new Vector4U26F6(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZZYY() => new Vector4U26F6(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZZYZ() => new Vector4U26F6(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZZYW() => new Vector4U26F6(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZZZX() => new Vector4U26F6(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZZZY() => new Vector4U26F6(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZZZZ() => new Vector4U26F6(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZZZW() => new Vector4U26F6(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZZWX() => new Vector4U26F6(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZZWY() => new Vector4U26F6(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZZWZ() => new Vector4U26F6(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZZWW() => new Vector4U26F6(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZWXX() => new Vector4U26F6(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZWXY() => new Vector4U26F6(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZWXZ() => new Vector4U26F6(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZWXW() => new Vector4U26F6(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZWYX() => new Vector4U26F6(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZWYY() => new Vector4U26F6(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZWYZ() => new Vector4U26F6(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZWYW() => new Vector4U26F6(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZWZX() => new Vector4U26F6(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZWZY() => new Vector4U26F6(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZWZZ() => new Vector4U26F6(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZWZW() => new Vector4U26F6(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZWWX() => new Vector4U26F6(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZWWY() => new Vector4U26F6(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZWWZ() => new Vector4U26F6(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 ZWWW() => new Vector4U26F6(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WXXX() => new Vector4U26F6(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WXXY() => new Vector4U26F6(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WXXZ() => new Vector4U26F6(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WXXW() => new Vector4U26F6(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WXYX() => new Vector4U26F6(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WXYY() => new Vector4U26F6(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WXYZ() => new Vector4U26F6(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WXYW() => new Vector4U26F6(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WXZX() => new Vector4U26F6(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WXZY() => new Vector4U26F6(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WXZZ() => new Vector4U26F6(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WXZW() => new Vector4U26F6(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WXWX() => new Vector4U26F6(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WXWY() => new Vector4U26F6(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WXWZ() => new Vector4U26F6(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WXWW() => new Vector4U26F6(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WYXX() => new Vector4U26F6(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WYXY() => new Vector4U26F6(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WYXZ() => new Vector4U26F6(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WYXW() => new Vector4U26F6(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WYYX() => new Vector4U26F6(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WYYY() => new Vector4U26F6(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WYYZ() => new Vector4U26F6(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WYYW() => new Vector4U26F6(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WYZX() => new Vector4U26F6(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WYZY() => new Vector4U26F6(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WYZZ() => new Vector4U26F6(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WYZW() => new Vector4U26F6(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WYWX() => new Vector4U26F6(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WYWY() => new Vector4U26F6(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WYWZ() => new Vector4U26F6(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WYWW() => new Vector4U26F6(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WZXX() => new Vector4U26F6(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WZXY() => new Vector4U26F6(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WZXZ() => new Vector4U26F6(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WZXW() => new Vector4U26F6(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WZYX() => new Vector4U26F6(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WZYY() => new Vector4U26F6(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WZYZ() => new Vector4U26F6(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WZYW() => new Vector4U26F6(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WZZX() => new Vector4U26F6(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WZZY() => new Vector4U26F6(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WZZZ() => new Vector4U26F6(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WZZW() => new Vector4U26F6(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WZWX() => new Vector4U26F6(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WZWY() => new Vector4U26F6(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WZWZ() => new Vector4U26F6(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WZWW() => new Vector4U26F6(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WWXX() => new Vector4U26F6(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WWXY() => new Vector4U26F6(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WWXZ() => new Vector4U26F6(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WWXW() => new Vector4U26F6(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WWYX() => new Vector4U26F6(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WWYY() => new Vector4U26F6(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WWYZ() => new Vector4U26F6(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WWYW() => new Vector4U26F6(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WWZX() => new Vector4U26F6(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WWZY() => new Vector4U26F6(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WWZZ() => new Vector4U26F6(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WWZW() => new Vector4U26F6(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WWWX() => new Vector4U26F6(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WWWY() => new Vector4U26F6(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WWWZ() => new Vector4U26F6(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U26F6 WWWW() => new Vector4U26F6(W, W, W, W);

    }
}
