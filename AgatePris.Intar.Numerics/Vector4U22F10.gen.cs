using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U22F10
    : IEquatable<Vector4U22F10>
    , IFormattable
    , IVector<U46F18, I46F18, U23F9, I23F9>
    , IVectorComponentRespective<U22F10> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U22F10 X;
        public U22F10 Y;
        public U22F10 Z;
        public U22F10 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(U22F10 x, U22F10 y, U22F10 z, U22F10 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(U22F10 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(U22F10 x, U22F10 y, Vector2U22F10 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(U22F10 x, Vector3U22F10 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(Vector2U22F10 xy, Vector2U22F10 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(Vector4U22F10 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(U22F10 x, Vector2U22F10 yz, U22F10 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(Vector3U22F10 xyz, U22F10 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10(Vector2U22F10 xy, U22F10 z, U22F10 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U22F10 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U22F10(U22F10.Zero);
        }
        public static Vector4U22F10 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U22F10(U22F10.One);
        }
        public static Vector4U22F10 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U22F10(U22F10.One, U22F10.Zero, U22F10.Zero, U22F10.Zero);
        }
        public static Vector4U22F10 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U22F10(U22F10.Zero, U22F10.One, U22F10.Zero, U22F10.Zero);
        }
        public static Vector4U22F10 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U22F10(U22F10.Zero, U22F10.Zero, U22F10.One, U22F10.Zero);
        }
        public static Vector4U22F10 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U22F10(U22F10.Zero, U22F10.Zero, U22F10.Zero, U22F10.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 operator +(Vector4U22F10 a, Vector4U22F10 b) => new Vector4U22F10(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 operator -(Vector4U22F10 a, Vector4U22F10 b) => new Vector4U22F10(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 operator *(Vector4U22F10 a, Vector4U22F10 b) => new Vector4U22F10(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 operator *(Vector4U22F10 a, U22F10 b) => new Vector4U22F10(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 operator *(U22F10 a, Vector4U22F10 b) => new Vector4U22F10(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 operator /(Vector4U22F10 a, Vector4U22F10 b) => new Vector4U22F10(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 operator /(Vector4U22F10 a, U22F10 b) => new Vector4U22F10(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U22F10 operator /(U22F10 a, Vector4U22F10 b) => new Vector4U22F10(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U22F10 lhs, Vector4U22F10 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U22F10 lhs, Vector4U22F10 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U22F10 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U22F10 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U22F10>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U22F10 other)
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
        public Vector4U22F10 Min(Vector4U22F10 other) => new Vector4U22F10(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10 Max(Vector4U22F10 other) => new Vector4U22F10(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10 Half() => new Vector4U22F10(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10 Twice() => new Vector4U22F10(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10 Clamp(U22F10 min, U22F10 max) => new Vector4U22F10(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10 Clamp(
            Vector4U22F10 min, Vector4U22F10 max
        ) => new Vector4U22F10(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10 WrappingAdd(Vector4U22F10 other) => new Vector4U22F10(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10 WrappingSub(Vector4U22F10 other) => new Vector4U22F10(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10 WrappingMul(Vector4U22F10 other) => new Vector4U22F10(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10 WrappingAddSigned(Vector4I22F10 other) => new Vector4U22F10(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10 SaturatingAdd(Vector4U22F10 other) => new Vector4U22F10(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10 SaturatingMul(U22F10 other) => new Vector4U22F10(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U22F10 other) {
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
        public U22F10 Dot(Vector4U22F10 other) {
            const ulong k = 1UL << 8;
            return U22F10.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U22F10 SaturatingDot(Vector4U22F10 other) {
            const ulong k = 1UL << 8;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U22F10.MaxValue;
            } else {
                return U22F10.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U46F18 LengthSquaredUnsigned() => U46F18.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I46F18 LengthSquaredSigned() => I46F18.FromBits(
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
        public U46F18 LengthSquared() => LengthSquaredUnsigned();

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
        public U22F10 LengthHalf() => U22F10.FromBits(LengthInternal());

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
        public I22F10 LengthHalfSigned() => I22F10.FromBits(checked((int)LengthInternal()));

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
        public U23F9 LengthUnsigned() => U23F9.FromBits(LengthInternal());

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
        public I23F9 LengthSigned() => I23F9.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U23F9 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U22F10? Normalize() {
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

            const ulong k = 1UL << 9;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U22F10(
                U22F10.FromBits(y0),
                U22F10.FromBits(y1),
                U22F10.FromBits(y2),
                U22F10.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U22F10 XX() => new Vector2U22F10(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U22F10 XY() => new Vector2U22F10(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U22F10 XZ() => new Vector2U22F10(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U22F10 XW() => new Vector2U22F10(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U22F10 YX() => new Vector2U22F10(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U22F10 YY() => new Vector2U22F10(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U22F10 YZ() => new Vector2U22F10(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U22F10 YW() => new Vector2U22F10(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U22F10 ZX() => new Vector2U22F10(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U22F10 ZY() => new Vector2U22F10(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U22F10 ZZ() => new Vector2U22F10(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U22F10 ZW() => new Vector2U22F10(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U22F10 WX() => new Vector2U22F10(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U22F10 WY() => new Vector2U22F10(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U22F10 WZ() => new Vector2U22F10(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U22F10 WW() => new Vector2U22F10(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 XXX() => new Vector3U22F10(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 XXY() => new Vector3U22F10(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 XXZ() => new Vector3U22F10(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 XXW() => new Vector3U22F10(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 XYX() => new Vector3U22F10(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 XYY() => new Vector3U22F10(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 XYZ() => new Vector3U22F10(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 XYW() => new Vector3U22F10(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 XZX() => new Vector3U22F10(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 XZY() => new Vector3U22F10(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 XZZ() => new Vector3U22F10(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 XZW() => new Vector3U22F10(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 XWX() => new Vector3U22F10(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 XWY() => new Vector3U22F10(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 XWZ() => new Vector3U22F10(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 XWW() => new Vector3U22F10(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 YXX() => new Vector3U22F10(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 YXY() => new Vector3U22F10(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 YXZ() => new Vector3U22F10(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 YXW() => new Vector3U22F10(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 YYX() => new Vector3U22F10(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 YYY() => new Vector3U22F10(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 YYZ() => new Vector3U22F10(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 YYW() => new Vector3U22F10(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 YZX() => new Vector3U22F10(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 YZY() => new Vector3U22F10(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 YZZ() => new Vector3U22F10(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 YZW() => new Vector3U22F10(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 YWX() => new Vector3U22F10(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 YWY() => new Vector3U22F10(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 YWZ() => new Vector3U22F10(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 YWW() => new Vector3U22F10(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 ZXX() => new Vector3U22F10(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 ZXY() => new Vector3U22F10(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 ZXZ() => new Vector3U22F10(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 ZXW() => new Vector3U22F10(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 ZYX() => new Vector3U22F10(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 ZYY() => new Vector3U22F10(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 ZYZ() => new Vector3U22F10(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 ZYW() => new Vector3U22F10(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 ZZX() => new Vector3U22F10(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 ZZY() => new Vector3U22F10(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 ZZZ() => new Vector3U22F10(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 ZZW() => new Vector3U22F10(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 ZWX() => new Vector3U22F10(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 ZWY() => new Vector3U22F10(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 ZWZ() => new Vector3U22F10(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 ZWW() => new Vector3U22F10(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 WXX() => new Vector3U22F10(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 WXY() => new Vector3U22F10(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 WXZ() => new Vector3U22F10(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 WXW() => new Vector3U22F10(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 WYX() => new Vector3U22F10(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 WYY() => new Vector3U22F10(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 WYZ() => new Vector3U22F10(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 WYW() => new Vector3U22F10(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 WZX() => new Vector3U22F10(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 WZY() => new Vector3U22F10(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 WZZ() => new Vector3U22F10(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 WZW() => new Vector3U22F10(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 WWX() => new Vector3U22F10(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 WWY() => new Vector3U22F10(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 WWZ() => new Vector3U22F10(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U22F10 WWW() => new Vector3U22F10(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XXXX() => new Vector4U22F10(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XXXY() => new Vector4U22F10(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XXXZ() => new Vector4U22F10(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XXXW() => new Vector4U22F10(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XXYX() => new Vector4U22F10(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XXYY() => new Vector4U22F10(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XXYZ() => new Vector4U22F10(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XXYW() => new Vector4U22F10(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XXZX() => new Vector4U22F10(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XXZY() => new Vector4U22F10(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XXZZ() => new Vector4U22F10(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XXZW() => new Vector4U22F10(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XXWX() => new Vector4U22F10(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XXWY() => new Vector4U22F10(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XXWZ() => new Vector4U22F10(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XXWW() => new Vector4U22F10(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XYXX() => new Vector4U22F10(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XYXY() => new Vector4U22F10(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XYXZ() => new Vector4U22F10(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XYXW() => new Vector4U22F10(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XYYX() => new Vector4U22F10(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XYYY() => new Vector4U22F10(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XYYZ() => new Vector4U22F10(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XYYW() => new Vector4U22F10(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XYZX() => new Vector4U22F10(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XYZY() => new Vector4U22F10(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XYZZ() => new Vector4U22F10(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XYZW() => new Vector4U22F10(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XYWX() => new Vector4U22F10(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XYWY() => new Vector4U22F10(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XYWZ() => new Vector4U22F10(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XYWW() => new Vector4U22F10(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XZXX() => new Vector4U22F10(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XZXY() => new Vector4U22F10(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XZXZ() => new Vector4U22F10(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XZXW() => new Vector4U22F10(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XZYX() => new Vector4U22F10(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XZYY() => new Vector4U22F10(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XZYZ() => new Vector4U22F10(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XZYW() => new Vector4U22F10(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XZZX() => new Vector4U22F10(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XZZY() => new Vector4U22F10(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XZZZ() => new Vector4U22F10(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XZZW() => new Vector4U22F10(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XZWX() => new Vector4U22F10(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XZWY() => new Vector4U22F10(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XZWZ() => new Vector4U22F10(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XZWW() => new Vector4U22F10(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XWXX() => new Vector4U22F10(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XWXY() => new Vector4U22F10(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XWXZ() => new Vector4U22F10(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XWXW() => new Vector4U22F10(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XWYX() => new Vector4U22F10(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XWYY() => new Vector4U22F10(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XWYZ() => new Vector4U22F10(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XWYW() => new Vector4U22F10(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XWZX() => new Vector4U22F10(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XWZY() => new Vector4U22F10(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XWZZ() => new Vector4U22F10(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XWZW() => new Vector4U22F10(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XWWX() => new Vector4U22F10(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XWWY() => new Vector4U22F10(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XWWZ() => new Vector4U22F10(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 XWWW() => new Vector4U22F10(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YXXX() => new Vector4U22F10(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YXXY() => new Vector4U22F10(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YXXZ() => new Vector4U22F10(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YXXW() => new Vector4U22F10(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YXYX() => new Vector4U22F10(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YXYY() => new Vector4U22F10(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YXYZ() => new Vector4U22F10(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YXYW() => new Vector4U22F10(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YXZX() => new Vector4U22F10(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YXZY() => new Vector4U22F10(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YXZZ() => new Vector4U22F10(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YXZW() => new Vector4U22F10(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YXWX() => new Vector4U22F10(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YXWY() => new Vector4U22F10(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YXWZ() => new Vector4U22F10(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YXWW() => new Vector4U22F10(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YYXX() => new Vector4U22F10(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YYXY() => new Vector4U22F10(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YYXZ() => new Vector4U22F10(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YYXW() => new Vector4U22F10(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YYYX() => new Vector4U22F10(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YYYY() => new Vector4U22F10(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YYYZ() => new Vector4U22F10(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YYYW() => new Vector4U22F10(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YYZX() => new Vector4U22F10(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YYZY() => new Vector4U22F10(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YYZZ() => new Vector4U22F10(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YYZW() => new Vector4U22F10(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YYWX() => new Vector4U22F10(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YYWY() => new Vector4U22F10(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YYWZ() => new Vector4U22F10(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YYWW() => new Vector4U22F10(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YZXX() => new Vector4U22F10(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YZXY() => new Vector4U22F10(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YZXZ() => new Vector4U22F10(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YZXW() => new Vector4U22F10(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YZYX() => new Vector4U22F10(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YZYY() => new Vector4U22F10(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YZYZ() => new Vector4U22F10(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YZYW() => new Vector4U22F10(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YZZX() => new Vector4U22F10(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YZZY() => new Vector4U22F10(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YZZZ() => new Vector4U22F10(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YZZW() => new Vector4U22F10(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YZWX() => new Vector4U22F10(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YZWY() => new Vector4U22F10(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YZWZ() => new Vector4U22F10(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YZWW() => new Vector4U22F10(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YWXX() => new Vector4U22F10(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YWXY() => new Vector4U22F10(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YWXZ() => new Vector4U22F10(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YWXW() => new Vector4U22F10(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YWYX() => new Vector4U22F10(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YWYY() => new Vector4U22F10(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YWYZ() => new Vector4U22F10(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YWYW() => new Vector4U22F10(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YWZX() => new Vector4U22F10(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YWZY() => new Vector4U22F10(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YWZZ() => new Vector4U22F10(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YWZW() => new Vector4U22F10(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YWWX() => new Vector4U22F10(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YWWY() => new Vector4U22F10(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YWWZ() => new Vector4U22F10(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 YWWW() => new Vector4U22F10(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZXXX() => new Vector4U22F10(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZXXY() => new Vector4U22F10(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZXXZ() => new Vector4U22F10(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZXXW() => new Vector4U22F10(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZXYX() => new Vector4U22F10(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZXYY() => new Vector4U22F10(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZXYZ() => new Vector4U22F10(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZXYW() => new Vector4U22F10(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZXZX() => new Vector4U22F10(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZXZY() => new Vector4U22F10(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZXZZ() => new Vector4U22F10(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZXZW() => new Vector4U22F10(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZXWX() => new Vector4U22F10(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZXWY() => new Vector4U22F10(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZXWZ() => new Vector4U22F10(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZXWW() => new Vector4U22F10(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZYXX() => new Vector4U22F10(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZYXY() => new Vector4U22F10(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZYXZ() => new Vector4U22F10(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZYXW() => new Vector4U22F10(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZYYX() => new Vector4U22F10(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZYYY() => new Vector4U22F10(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZYYZ() => new Vector4U22F10(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZYYW() => new Vector4U22F10(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZYZX() => new Vector4U22F10(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZYZY() => new Vector4U22F10(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZYZZ() => new Vector4U22F10(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZYZW() => new Vector4U22F10(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZYWX() => new Vector4U22F10(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZYWY() => new Vector4U22F10(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZYWZ() => new Vector4U22F10(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZYWW() => new Vector4U22F10(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZZXX() => new Vector4U22F10(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZZXY() => new Vector4U22F10(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZZXZ() => new Vector4U22F10(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZZXW() => new Vector4U22F10(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZZYX() => new Vector4U22F10(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZZYY() => new Vector4U22F10(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZZYZ() => new Vector4U22F10(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZZYW() => new Vector4U22F10(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZZZX() => new Vector4U22F10(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZZZY() => new Vector4U22F10(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZZZZ() => new Vector4U22F10(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZZZW() => new Vector4U22F10(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZZWX() => new Vector4U22F10(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZZWY() => new Vector4U22F10(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZZWZ() => new Vector4U22F10(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZZWW() => new Vector4U22F10(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZWXX() => new Vector4U22F10(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZWXY() => new Vector4U22F10(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZWXZ() => new Vector4U22F10(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZWXW() => new Vector4U22F10(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZWYX() => new Vector4U22F10(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZWYY() => new Vector4U22F10(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZWYZ() => new Vector4U22F10(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZWYW() => new Vector4U22F10(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZWZX() => new Vector4U22F10(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZWZY() => new Vector4U22F10(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZWZZ() => new Vector4U22F10(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZWZW() => new Vector4U22F10(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZWWX() => new Vector4U22F10(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZWWY() => new Vector4U22F10(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZWWZ() => new Vector4U22F10(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 ZWWW() => new Vector4U22F10(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WXXX() => new Vector4U22F10(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WXXY() => new Vector4U22F10(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WXXZ() => new Vector4U22F10(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WXXW() => new Vector4U22F10(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WXYX() => new Vector4U22F10(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WXYY() => new Vector4U22F10(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WXYZ() => new Vector4U22F10(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WXYW() => new Vector4U22F10(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WXZX() => new Vector4U22F10(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WXZY() => new Vector4U22F10(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WXZZ() => new Vector4U22F10(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WXZW() => new Vector4U22F10(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WXWX() => new Vector4U22F10(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WXWY() => new Vector4U22F10(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WXWZ() => new Vector4U22F10(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WXWW() => new Vector4U22F10(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WYXX() => new Vector4U22F10(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WYXY() => new Vector4U22F10(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WYXZ() => new Vector4U22F10(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WYXW() => new Vector4U22F10(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WYYX() => new Vector4U22F10(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WYYY() => new Vector4U22F10(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WYYZ() => new Vector4U22F10(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WYYW() => new Vector4U22F10(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WYZX() => new Vector4U22F10(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WYZY() => new Vector4U22F10(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WYZZ() => new Vector4U22F10(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WYZW() => new Vector4U22F10(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WYWX() => new Vector4U22F10(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WYWY() => new Vector4U22F10(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WYWZ() => new Vector4U22F10(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WYWW() => new Vector4U22F10(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WZXX() => new Vector4U22F10(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WZXY() => new Vector4U22F10(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WZXZ() => new Vector4U22F10(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WZXW() => new Vector4U22F10(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WZYX() => new Vector4U22F10(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WZYY() => new Vector4U22F10(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WZYZ() => new Vector4U22F10(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WZYW() => new Vector4U22F10(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WZZX() => new Vector4U22F10(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WZZY() => new Vector4U22F10(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WZZZ() => new Vector4U22F10(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WZZW() => new Vector4U22F10(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WZWX() => new Vector4U22F10(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WZWY() => new Vector4U22F10(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WZWZ() => new Vector4U22F10(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WZWW() => new Vector4U22F10(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WWXX() => new Vector4U22F10(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WWXY() => new Vector4U22F10(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WWXZ() => new Vector4U22F10(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WWXW() => new Vector4U22F10(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WWYX() => new Vector4U22F10(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WWYY() => new Vector4U22F10(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WWYZ() => new Vector4U22F10(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WWYW() => new Vector4U22F10(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WWZX() => new Vector4U22F10(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WWZY() => new Vector4U22F10(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WWZZ() => new Vector4U22F10(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WWZW() => new Vector4U22F10(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WWWX() => new Vector4U22F10(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WWWY() => new Vector4U22F10(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WWWZ() => new Vector4U22F10(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U22F10 WWWW() => new Vector4U22F10(W, W, W, W);

    }
}
