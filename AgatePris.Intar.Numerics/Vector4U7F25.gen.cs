using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U7F25
    : IEquatable<Vector4U7F25>
    , IFormattable
    , IVector<U16F48, I16F48, U8F24, I8F24>
    , IVectorComponentRespective<U7F25> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U7F25 X;
        public U7F25 Y;
        public U7F25 Z;
        public U7F25 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(U7F25 x, U7F25 y, U7F25 z, U7F25 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(U7F25 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(U7F25 x, U7F25 y, Vector2U7F25 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(U7F25 x, Vector3U7F25 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(Vector2U7F25 xy, Vector2U7F25 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(Vector4U7F25 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(U7F25 x, Vector2U7F25 yz, U7F25 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(Vector3U7F25 xyz, U7F25 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25(Vector2U7F25 xy, U7F25 z, U7F25 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U7F25 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U7F25(U7F25.Zero);
        }
        public static Vector4U7F25 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U7F25(U7F25.One);
        }
        public static Vector4U7F25 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U7F25(U7F25.One, U7F25.Zero, U7F25.Zero, U7F25.Zero);
        }
        public static Vector4U7F25 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U7F25(U7F25.Zero, U7F25.One, U7F25.Zero, U7F25.Zero);
        }
        public static Vector4U7F25 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U7F25(U7F25.Zero, U7F25.Zero, U7F25.One, U7F25.Zero);
        }
        public static Vector4U7F25 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U7F25(U7F25.Zero, U7F25.Zero, U7F25.Zero, U7F25.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 operator +(Vector4U7F25 a, Vector4U7F25 b) => new Vector4U7F25(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 operator -(Vector4U7F25 a, Vector4U7F25 b) => new Vector4U7F25(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 operator *(Vector4U7F25 a, Vector4U7F25 b) => new Vector4U7F25(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 operator *(Vector4U7F25 a, U7F25 b) => new Vector4U7F25(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 operator *(U7F25 a, Vector4U7F25 b) => new Vector4U7F25(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 operator /(Vector4U7F25 a, Vector4U7F25 b) => new Vector4U7F25(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 operator /(Vector4U7F25 a, U7F25 b) => new Vector4U7F25(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U7F25 operator /(U7F25 a, Vector4U7F25 b) => new Vector4U7F25(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U7F25 lhs, Vector4U7F25 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U7F25 lhs, Vector4U7F25 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U7F25 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U7F25 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U7F25>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U7F25 other)
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
        public Vector4U7F25 Min(Vector4U7F25 other) => new Vector4U7F25(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25 Max(Vector4U7F25 other) => new Vector4U7F25(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25 Half() => new Vector4U7F25(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25 Twice() => new Vector4U7F25(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25 Clamp(U7F25 min, U7F25 max) => new Vector4U7F25(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25 Clamp(
            Vector4U7F25 min, Vector4U7F25 max
        ) => new Vector4U7F25(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25 WrappingAdd(Vector4U7F25 other) => new Vector4U7F25(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25 WrappingSub(Vector4U7F25 other) => new Vector4U7F25(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25 WrappingMul(Vector4U7F25 other) => new Vector4U7F25(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25 WrappingAddSigned(Vector4I7F25 other) => new Vector4U7F25(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25 SaturatingAdd(Vector4U7F25 other) => new Vector4U7F25(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25 SaturatingMul(U7F25 other) => new Vector4U7F25(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U7F25 other) {
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
        public U7F25 Dot(Vector4U7F25 other) {
            const ulong k = 1UL << 23;
            return U7F25.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U7F25 SaturatingDot(Vector4U7F25 other) {
            const ulong k = 1UL << 23;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U7F25.MaxValue;
            } else {
                return U7F25.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U16F48 LengthSquaredUnsigned() => U16F48.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I16F48 LengthSquaredSigned() => I16F48.FromBits(
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
        public U16F48 LengthSquared() => LengthSquaredUnsigned();

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
        public U7F25 LengthHalf() => U7F25.FromBits(LengthInternal());

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
        public I7F25 LengthHalfSigned() => I7F25.FromBits(checked((int)LengthInternal()));

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
        public U8F24 LengthUnsigned() => U8F24.FromBits(LengthInternal());

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
        public I8F24 LengthSigned() => I8F24.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U8F24 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U7F25? Normalize() {
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

            const ulong k = 1UL << 24;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U7F25(
                U7F25.FromBits(y0),
                U7F25.FromBits(y1),
                U7F25.FromBits(y2),
                U7F25.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U7F25 XX() => new Vector2U7F25(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U7F25 XY() => new Vector2U7F25(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U7F25 XZ() => new Vector2U7F25(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U7F25 XW() => new Vector2U7F25(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U7F25 YX() => new Vector2U7F25(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U7F25 YY() => new Vector2U7F25(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U7F25 YZ() => new Vector2U7F25(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U7F25 YW() => new Vector2U7F25(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U7F25 ZX() => new Vector2U7F25(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U7F25 ZY() => new Vector2U7F25(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U7F25 ZZ() => new Vector2U7F25(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U7F25 ZW() => new Vector2U7F25(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U7F25 WX() => new Vector2U7F25(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U7F25 WY() => new Vector2U7F25(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U7F25 WZ() => new Vector2U7F25(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U7F25 WW() => new Vector2U7F25(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 XXX() => new Vector3U7F25(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 XXY() => new Vector3U7F25(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 XXZ() => new Vector3U7F25(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 XXW() => new Vector3U7F25(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 XYX() => new Vector3U7F25(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 XYY() => new Vector3U7F25(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 XYZ() => new Vector3U7F25(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 XYW() => new Vector3U7F25(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 XZX() => new Vector3U7F25(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 XZY() => new Vector3U7F25(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 XZZ() => new Vector3U7F25(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 XZW() => new Vector3U7F25(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 XWX() => new Vector3U7F25(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 XWY() => new Vector3U7F25(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 XWZ() => new Vector3U7F25(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 XWW() => new Vector3U7F25(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 YXX() => new Vector3U7F25(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 YXY() => new Vector3U7F25(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 YXZ() => new Vector3U7F25(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 YXW() => new Vector3U7F25(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 YYX() => new Vector3U7F25(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 YYY() => new Vector3U7F25(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 YYZ() => new Vector3U7F25(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 YYW() => new Vector3U7F25(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 YZX() => new Vector3U7F25(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 YZY() => new Vector3U7F25(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 YZZ() => new Vector3U7F25(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 YZW() => new Vector3U7F25(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 YWX() => new Vector3U7F25(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 YWY() => new Vector3U7F25(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 YWZ() => new Vector3U7F25(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 YWW() => new Vector3U7F25(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 ZXX() => new Vector3U7F25(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 ZXY() => new Vector3U7F25(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 ZXZ() => new Vector3U7F25(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 ZXW() => new Vector3U7F25(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 ZYX() => new Vector3U7F25(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 ZYY() => new Vector3U7F25(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 ZYZ() => new Vector3U7F25(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 ZYW() => new Vector3U7F25(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 ZZX() => new Vector3U7F25(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 ZZY() => new Vector3U7F25(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 ZZZ() => new Vector3U7F25(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 ZZW() => new Vector3U7F25(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 ZWX() => new Vector3U7F25(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 ZWY() => new Vector3U7F25(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 ZWZ() => new Vector3U7F25(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 ZWW() => new Vector3U7F25(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 WXX() => new Vector3U7F25(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 WXY() => new Vector3U7F25(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 WXZ() => new Vector3U7F25(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 WXW() => new Vector3U7F25(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 WYX() => new Vector3U7F25(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 WYY() => new Vector3U7F25(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 WYZ() => new Vector3U7F25(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 WYW() => new Vector3U7F25(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 WZX() => new Vector3U7F25(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 WZY() => new Vector3U7F25(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 WZZ() => new Vector3U7F25(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 WZW() => new Vector3U7F25(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 WWX() => new Vector3U7F25(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 WWY() => new Vector3U7F25(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 WWZ() => new Vector3U7F25(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U7F25 WWW() => new Vector3U7F25(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XXXX() => new Vector4U7F25(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XXXY() => new Vector4U7F25(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XXXZ() => new Vector4U7F25(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XXXW() => new Vector4U7F25(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XXYX() => new Vector4U7F25(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XXYY() => new Vector4U7F25(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XXYZ() => new Vector4U7F25(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XXYW() => new Vector4U7F25(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XXZX() => new Vector4U7F25(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XXZY() => new Vector4U7F25(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XXZZ() => new Vector4U7F25(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XXZW() => new Vector4U7F25(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XXWX() => new Vector4U7F25(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XXWY() => new Vector4U7F25(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XXWZ() => new Vector4U7F25(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XXWW() => new Vector4U7F25(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XYXX() => new Vector4U7F25(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XYXY() => new Vector4U7F25(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XYXZ() => new Vector4U7F25(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XYXW() => new Vector4U7F25(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XYYX() => new Vector4U7F25(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XYYY() => new Vector4U7F25(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XYYZ() => new Vector4U7F25(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XYYW() => new Vector4U7F25(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XYZX() => new Vector4U7F25(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XYZY() => new Vector4U7F25(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XYZZ() => new Vector4U7F25(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XYZW() => new Vector4U7F25(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XYWX() => new Vector4U7F25(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XYWY() => new Vector4U7F25(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XYWZ() => new Vector4U7F25(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XYWW() => new Vector4U7F25(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XZXX() => new Vector4U7F25(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XZXY() => new Vector4U7F25(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XZXZ() => new Vector4U7F25(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XZXW() => new Vector4U7F25(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XZYX() => new Vector4U7F25(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XZYY() => new Vector4U7F25(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XZYZ() => new Vector4U7F25(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XZYW() => new Vector4U7F25(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XZZX() => new Vector4U7F25(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XZZY() => new Vector4U7F25(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XZZZ() => new Vector4U7F25(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XZZW() => new Vector4U7F25(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XZWX() => new Vector4U7F25(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XZWY() => new Vector4U7F25(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XZWZ() => new Vector4U7F25(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XZWW() => new Vector4U7F25(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XWXX() => new Vector4U7F25(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XWXY() => new Vector4U7F25(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XWXZ() => new Vector4U7F25(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XWXW() => new Vector4U7F25(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XWYX() => new Vector4U7F25(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XWYY() => new Vector4U7F25(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XWYZ() => new Vector4U7F25(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XWYW() => new Vector4U7F25(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XWZX() => new Vector4U7F25(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XWZY() => new Vector4U7F25(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XWZZ() => new Vector4U7F25(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XWZW() => new Vector4U7F25(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XWWX() => new Vector4U7F25(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XWWY() => new Vector4U7F25(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XWWZ() => new Vector4U7F25(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 XWWW() => new Vector4U7F25(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YXXX() => new Vector4U7F25(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YXXY() => new Vector4U7F25(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YXXZ() => new Vector4U7F25(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YXXW() => new Vector4U7F25(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YXYX() => new Vector4U7F25(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YXYY() => new Vector4U7F25(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YXYZ() => new Vector4U7F25(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YXYW() => new Vector4U7F25(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YXZX() => new Vector4U7F25(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YXZY() => new Vector4U7F25(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YXZZ() => new Vector4U7F25(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YXZW() => new Vector4U7F25(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YXWX() => new Vector4U7F25(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YXWY() => new Vector4U7F25(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YXWZ() => new Vector4U7F25(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YXWW() => new Vector4U7F25(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YYXX() => new Vector4U7F25(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YYXY() => new Vector4U7F25(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YYXZ() => new Vector4U7F25(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YYXW() => new Vector4U7F25(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YYYX() => new Vector4U7F25(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YYYY() => new Vector4U7F25(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YYYZ() => new Vector4U7F25(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YYYW() => new Vector4U7F25(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YYZX() => new Vector4U7F25(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YYZY() => new Vector4U7F25(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YYZZ() => new Vector4U7F25(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YYZW() => new Vector4U7F25(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YYWX() => new Vector4U7F25(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YYWY() => new Vector4U7F25(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YYWZ() => new Vector4U7F25(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YYWW() => new Vector4U7F25(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YZXX() => new Vector4U7F25(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YZXY() => new Vector4U7F25(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YZXZ() => new Vector4U7F25(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YZXW() => new Vector4U7F25(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YZYX() => new Vector4U7F25(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YZYY() => new Vector4U7F25(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YZYZ() => new Vector4U7F25(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YZYW() => new Vector4U7F25(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YZZX() => new Vector4U7F25(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YZZY() => new Vector4U7F25(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YZZZ() => new Vector4U7F25(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YZZW() => new Vector4U7F25(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YZWX() => new Vector4U7F25(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YZWY() => new Vector4U7F25(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YZWZ() => new Vector4U7F25(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YZWW() => new Vector4U7F25(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YWXX() => new Vector4U7F25(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YWXY() => new Vector4U7F25(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YWXZ() => new Vector4U7F25(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YWXW() => new Vector4U7F25(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YWYX() => new Vector4U7F25(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YWYY() => new Vector4U7F25(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YWYZ() => new Vector4U7F25(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YWYW() => new Vector4U7F25(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YWZX() => new Vector4U7F25(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YWZY() => new Vector4U7F25(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YWZZ() => new Vector4U7F25(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YWZW() => new Vector4U7F25(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YWWX() => new Vector4U7F25(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YWWY() => new Vector4U7F25(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YWWZ() => new Vector4U7F25(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 YWWW() => new Vector4U7F25(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZXXX() => new Vector4U7F25(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZXXY() => new Vector4U7F25(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZXXZ() => new Vector4U7F25(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZXXW() => new Vector4U7F25(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZXYX() => new Vector4U7F25(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZXYY() => new Vector4U7F25(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZXYZ() => new Vector4U7F25(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZXYW() => new Vector4U7F25(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZXZX() => new Vector4U7F25(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZXZY() => new Vector4U7F25(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZXZZ() => new Vector4U7F25(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZXZW() => new Vector4U7F25(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZXWX() => new Vector4U7F25(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZXWY() => new Vector4U7F25(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZXWZ() => new Vector4U7F25(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZXWW() => new Vector4U7F25(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZYXX() => new Vector4U7F25(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZYXY() => new Vector4U7F25(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZYXZ() => new Vector4U7F25(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZYXW() => new Vector4U7F25(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZYYX() => new Vector4U7F25(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZYYY() => new Vector4U7F25(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZYYZ() => new Vector4U7F25(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZYYW() => new Vector4U7F25(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZYZX() => new Vector4U7F25(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZYZY() => new Vector4U7F25(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZYZZ() => new Vector4U7F25(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZYZW() => new Vector4U7F25(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZYWX() => new Vector4U7F25(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZYWY() => new Vector4U7F25(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZYWZ() => new Vector4U7F25(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZYWW() => new Vector4U7F25(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZZXX() => new Vector4U7F25(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZZXY() => new Vector4U7F25(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZZXZ() => new Vector4U7F25(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZZXW() => new Vector4U7F25(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZZYX() => new Vector4U7F25(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZZYY() => new Vector4U7F25(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZZYZ() => new Vector4U7F25(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZZYW() => new Vector4U7F25(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZZZX() => new Vector4U7F25(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZZZY() => new Vector4U7F25(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZZZZ() => new Vector4U7F25(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZZZW() => new Vector4U7F25(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZZWX() => new Vector4U7F25(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZZWY() => new Vector4U7F25(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZZWZ() => new Vector4U7F25(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZZWW() => new Vector4U7F25(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZWXX() => new Vector4U7F25(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZWXY() => new Vector4U7F25(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZWXZ() => new Vector4U7F25(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZWXW() => new Vector4U7F25(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZWYX() => new Vector4U7F25(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZWYY() => new Vector4U7F25(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZWYZ() => new Vector4U7F25(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZWYW() => new Vector4U7F25(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZWZX() => new Vector4U7F25(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZWZY() => new Vector4U7F25(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZWZZ() => new Vector4U7F25(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZWZW() => new Vector4U7F25(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZWWX() => new Vector4U7F25(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZWWY() => new Vector4U7F25(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZWWZ() => new Vector4U7F25(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 ZWWW() => new Vector4U7F25(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WXXX() => new Vector4U7F25(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WXXY() => new Vector4U7F25(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WXXZ() => new Vector4U7F25(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WXXW() => new Vector4U7F25(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WXYX() => new Vector4U7F25(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WXYY() => new Vector4U7F25(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WXYZ() => new Vector4U7F25(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WXYW() => new Vector4U7F25(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WXZX() => new Vector4U7F25(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WXZY() => new Vector4U7F25(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WXZZ() => new Vector4U7F25(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WXZW() => new Vector4U7F25(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WXWX() => new Vector4U7F25(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WXWY() => new Vector4U7F25(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WXWZ() => new Vector4U7F25(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WXWW() => new Vector4U7F25(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WYXX() => new Vector4U7F25(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WYXY() => new Vector4U7F25(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WYXZ() => new Vector4U7F25(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WYXW() => new Vector4U7F25(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WYYX() => new Vector4U7F25(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WYYY() => new Vector4U7F25(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WYYZ() => new Vector4U7F25(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WYYW() => new Vector4U7F25(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WYZX() => new Vector4U7F25(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WYZY() => new Vector4U7F25(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WYZZ() => new Vector4U7F25(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WYZW() => new Vector4U7F25(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WYWX() => new Vector4U7F25(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WYWY() => new Vector4U7F25(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WYWZ() => new Vector4U7F25(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WYWW() => new Vector4U7F25(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WZXX() => new Vector4U7F25(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WZXY() => new Vector4U7F25(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WZXZ() => new Vector4U7F25(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WZXW() => new Vector4U7F25(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WZYX() => new Vector4U7F25(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WZYY() => new Vector4U7F25(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WZYZ() => new Vector4U7F25(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WZYW() => new Vector4U7F25(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WZZX() => new Vector4U7F25(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WZZY() => new Vector4U7F25(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WZZZ() => new Vector4U7F25(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WZZW() => new Vector4U7F25(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WZWX() => new Vector4U7F25(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WZWY() => new Vector4U7F25(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WZWZ() => new Vector4U7F25(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WZWW() => new Vector4U7F25(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WWXX() => new Vector4U7F25(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WWXY() => new Vector4U7F25(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WWXZ() => new Vector4U7F25(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WWXW() => new Vector4U7F25(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WWYX() => new Vector4U7F25(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WWYY() => new Vector4U7F25(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WWYZ() => new Vector4U7F25(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WWYW() => new Vector4U7F25(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WWZX() => new Vector4U7F25(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WWZY() => new Vector4U7F25(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WWZZ() => new Vector4U7F25(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WWZW() => new Vector4U7F25(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WWWX() => new Vector4U7F25(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WWWY() => new Vector4U7F25(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WWWZ() => new Vector4U7F25(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U7F25 WWWW() => new Vector4U7F25(W, W, W, W);

    }
}
