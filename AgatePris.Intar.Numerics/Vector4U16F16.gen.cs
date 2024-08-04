using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U16F16
    : IEquatable<Vector4U16F16>
    , IFormattable
    , IVector<U34F30, I34F30, U17F15, I17F15>
    , IVectorComponentRespective<U16F16> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U16F16 X;
        public U16F16 Y;
        public U16F16 Z;
        public U16F16 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 x, U16F16 y, U16F16 z, U16F16 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 x, U16F16 y, Vector2U16F16 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 x, Vector3U16F16 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(Vector2U16F16 xy, Vector2U16F16 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(Vector4U16F16 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(U16F16 x, Vector2U16F16 yz, U16F16 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(Vector3U16F16 xyz, U16F16 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16(Vector2U16F16 xy, U16F16 z, U16F16 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U16F16 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U16F16(U16F16.Zero);
        }
        public static Vector4U16F16 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U16F16(U16F16.One);
        }
        public static Vector4U16F16 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U16F16(U16F16.One, U16F16.Zero, U16F16.Zero, U16F16.Zero);
        }
        public static Vector4U16F16 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U16F16(U16F16.Zero, U16F16.One, U16F16.Zero, U16F16.Zero);
        }
        public static Vector4U16F16 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U16F16(U16F16.Zero, U16F16.Zero, U16F16.One, U16F16.Zero);
        }
        public static Vector4U16F16 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U16F16(U16F16.Zero, U16F16.Zero, U16F16.Zero, U16F16.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator +(Vector4U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator -(Vector4U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator *(Vector4U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator *(Vector4U16F16 a, U16F16 b) => new Vector4U16F16(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator *(U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator /(Vector4U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator /(Vector4U16F16 a, U16F16 b) => new Vector4U16F16(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U16F16 operator /(U16F16 a, Vector4U16F16 b) => new Vector4U16F16(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U16F16 lhs, Vector4U16F16 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U16F16 lhs, Vector4U16F16 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U16F16 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U16F16 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U16F16>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U16F16 other)
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
        public Vector4U16F16 Min(Vector4U16F16 other) => new Vector4U16F16(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16 Max(Vector4U16F16 other) => new Vector4U16F16(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16 Half() => new Vector4U16F16(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16 Twice() => new Vector4U16F16(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16 Clamp(U16F16 min, U16F16 max) => new Vector4U16F16(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16 Clamp(
            Vector4U16F16 min, Vector4U16F16 max
        ) => new Vector4U16F16(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16 WrappingAdd(Vector4U16F16 other) => new Vector4U16F16(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16 WrappingSub(Vector4U16F16 other) => new Vector4U16F16(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16 WrappingMul(Vector4U16F16 other) => new Vector4U16F16(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16 WrappingAddSigned(Vector4I16F16 other) => new Vector4U16F16(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16 SaturatingAdd(Vector4U16F16 other) => new Vector4U16F16(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16 SaturatingMul(U16F16 other) => new Vector4U16F16(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U16F16 other) {
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
        public U16F16 Dot(Vector4U16F16 other) {
            const ulong k = 1UL << 14;
            return U16F16.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U16F16 SaturatingDot(Vector4U16F16 other) {
            const ulong k = 1UL << 14;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U16F16.MaxValue;
            } else {
                return U16F16.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 LengthSquaredUnsigned() => U34F30.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 LengthSquaredSigned() => I34F30.FromBits(
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
        public U34F30 LengthSquared() => LengthSquaredUnsigned();

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
        public U16F16 LengthHalf() => U16F16.FromBits(LengthInternal());

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
        public I16F16 LengthHalfSigned() => I16F16.FromBits(checked((int)LengthInternal()));

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
        public U17F15 LengthUnsigned() => U17F15.FromBits(LengthInternal());

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
        public I17F15 LengthSigned() => I17F15.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U16F16? Normalize() {
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

            const ulong k = 1UL << 15;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U16F16(
                U16F16.FromBits(y0),
                U16F16.FromBits(y1),
                U16F16.FromBits(y2),
                U16F16.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U16F16 XX() => new Vector2U16F16(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U16F16 XY() => new Vector2U16F16(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U16F16 XZ() => new Vector2U16F16(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U16F16 XW() => new Vector2U16F16(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U16F16 YX() => new Vector2U16F16(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U16F16 YY() => new Vector2U16F16(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U16F16 YZ() => new Vector2U16F16(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U16F16 YW() => new Vector2U16F16(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U16F16 ZX() => new Vector2U16F16(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U16F16 ZY() => new Vector2U16F16(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U16F16 ZZ() => new Vector2U16F16(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U16F16 ZW() => new Vector2U16F16(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U16F16 WX() => new Vector2U16F16(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U16F16 WY() => new Vector2U16F16(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U16F16 WZ() => new Vector2U16F16(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U16F16 WW() => new Vector2U16F16(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 XXX() => new Vector3U16F16(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 XXY() => new Vector3U16F16(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 XXZ() => new Vector3U16F16(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 XXW() => new Vector3U16F16(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 XYX() => new Vector3U16F16(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 XYY() => new Vector3U16F16(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 XYZ() => new Vector3U16F16(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 XYW() => new Vector3U16F16(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 XZX() => new Vector3U16F16(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 XZY() => new Vector3U16F16(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 XZZ() => new Vector3U16F16(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 XZW() => new Vector3U16F16(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 XWX() => new Vector3U16F16(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 XWY() => new Vector3U16F16(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 XWZ() => new Vector3U16F16(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 XWW() => new Vector3U16F16(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 YXX() => new Vector3U16F16(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 YXY() => new Vector3U16F16(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 YXZ() => new Vector3U16F16(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 YXW() => new Vector3U16F16(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 YYX() => new Vector3U16F16(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 YYY() => new Vector3U16F16(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 YYZ() => new Vector3U16F16(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 YYW() => new Vector3U16F16(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 YZX() => new Vector3U16F16(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 YZY() => new Vector3U16F16(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 YZZ() => new Vector3U16F16(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 YZW() => new Vector3U16F16(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 YWX() => new Vector3U16F16(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 YWY() => new Vector3U16F16(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 YWZ() => new Vector3U16F16(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 YWW() => new Vector3U16F16(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 ZXX() => new Vector3U16F16(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 ZXY() => new Vector3U16F16(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 ZXZ() => new Vector3U16F16(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 ZXW() => new Vector3U16F16(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 ZYX() => new Vector3U16F16(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 ZYY() => new Vector3U16F16(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 ZYZ() => new Vector3U16F16(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 ZYW() => new Vector3U16F16(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 ZZX() => new Vector3U16F16(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 ZZY() => new Vector3U16F16(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 ZZZ() => new Vector3U16F16(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 ZZW() => new Vector3U16F16(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 ZWX() => new Vector3U16F16(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 ZWY() => new Vector3U16F16(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 ZWZ() => new Vector3U16F16(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 ZWW() => new Vector3U16F16(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 WXX() => new Vector3U16F16(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 WXY() => new Vector3U16F16(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 WXZ() => new Vector3U16F16(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 WXW() => new Vector3U16F16(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 WYX() => new Vector3U16F16(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 WYY() => new Vector3U16F16(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 WYZ() => new Vector3U16F16(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 WYW() => new Vector3U16F16(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 WZX() => new Vector3U16F16(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 WZY() => new Vector3U16F16(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 WZZ() => new Vector3U16F16(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 WZW() => new Vector3U16F16(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 WWX() => new Vector3U16F16(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 WWY() => new Vector3U16F16(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 WWZ() => new Vector3U16F16(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U16F16 WWW() => new Vector3U16F16(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XXXX() => new Vector4U16F16(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XXXY() => new Vector4U16F16(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XXXZ() => new Vector4U16F16(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XXXW() => new Vector4U16F16(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XXYX() => new Vector4U16F16(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XXYY() => new Vector4U16F16(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XXYZ() => new Vector4U16F16(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XXYW() => new Vector4U16F16(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XXZX() => new Vector4U16F16(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XXZY() => new Vector4U16F16(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XXZZ() => new Vector4U16F16(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XXZW() => new Vector4U16F16(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XXWX() => new Vector4U16F16(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XXWY() => new Vector4U16F16(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XXWZ() => new Vector4U16F16(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XXWW() => new Vector4U16F16(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XYXX() => new Vector4U16F16(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XYXY() => new Vector4U16F16(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XYXZ() => new Vector4U16F16(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XYXW() => new Vector4U16F16(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XYYX() => new Vector4U16F16(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XYYY() => new Vector4U16F16(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XYYZ() => new Vector4U16F16(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XYYW() => new Vector4U16F16(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XYZX() => new Vector4U16F16(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XYZY() => new Vector4U16F16(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XYZZ() => new Vector4U16F16(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XYZW() => new Vector4U16F16(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XYWX() => new Vector4U16F16(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XYWY() => new Vector4U16F16(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XYWZ() => new Vector4U16F16(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XYWW() => new Vector4U16F16(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XZXX() => new Vector4U16F16(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XZXY() => new Vector4U16F16(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XZXZ() => new Vector4U16F16(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XZXW() => new Vector4U16F16(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XZYX() => new Vector4U16F16(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XZYY() => new Vector4U16F16(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XZYZ() => new Vector4U16F16(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XZYW() => new Vector4U16F16(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XZZX() => new Vector4U16F16(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XZZY() => new Vector4U16F16(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XZZZ() => new Vector4U16F16(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XZZW() => new Vector4U16F16(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XZWX() => new Vector4U16F16(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XZWY() => new Vector4U16F16(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XZWZ() => new Vector4U16F16(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XZWW() => new Vector4U16F16(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XWXX() => new Vector4U16F16(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XWXY() => new Vector4U16F16(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XWXZ() => new Vector4U16F16(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XWXW() => new Vector4U16F16(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XWYX() => new Vector4U16F16(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XWYY() => new Vector4U16F16(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XWYZ() => new Vector4U16F16(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XWYW() => new Vector4U16F16(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XWZX() => new Vector4U16F16(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XWZY() => new Vector4U16F16(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XWZZ() => new Vector4U16F16(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XWZW() => new Vector4U16F16(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XWWX() => new Vector4U16F16(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XWWY() => new Vector4U16F16(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XWWZ() => new Vector4U16F16(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 XWWW() => new Vector4U16F16(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YXXX() => new Vector4U16F16(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YXXY() => new Vector4U16F16(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YXXZ() => new Vector4U16F16(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YXXW() => new Vector4U16F16(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YXYX() => new Vector4U16F16(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YXYY() => new Vector4U16F16(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YXYZ() => new Vector4U16F16(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YXYW() => new Vector4U16F16(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YXZX() => new Vector4U16F16(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YXZY() => new Vector4U16F16(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YXZZ() => new Vector4U16F16(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YXZW() => new Vector4U16F16(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YXWX() => new Vector4U16F16(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YXWY() => new Vector4U16F16(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YXWZ() => new Vector4U16F16(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YXWW() => new Vector4U16F16(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YYXX() => new Vector4U16F16(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YYXY() => new Vector4U16F16(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YYXZ() => new Vector4U16F16(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YYXW() => new Vector4U16F16(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YYYX() => new Vector4U16F16(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YYYY() => new Vector4U16F16(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YYYZ() => new Vector4U16F16(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YYYW() => new Vector4U16F16(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YYZX() => new Vector4U16F16(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YYZY() => new Vector4U16F16(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YYZZ() => new Vector4U16F16(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YYZW() => new Vector4U16F16(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YYWX() => new Vector4U16F16(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YYWY() => new Vector4U16F16(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YYWZ() => new Vector4U16F16(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YYWW() => new Vector4U16F16(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YZXX() => new Vector4U16F16(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YZXY() => new Vector4U16F16(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YZXZ() => new Vector4U16F16(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YZXW() => new Vector4U16F16(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YZYX() => new Vector4U16F16(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YZYY() => new Vector4U16F16(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YZYZ() => new Vector4U16F16(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YZYW() => new Vector4U16F16(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YZZX() => new Vector4U16F16(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YZZY() => new Vector4U16F16(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YZZZ() => new Vector4U16F16(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YZZW() => new Vector4U16F16(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YZWX() => new Vector4U16F16(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YZWY() => new Vector4U16F16(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YZWZ() => new Vector4U16F16(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YZWW() => new Vector4U16F16(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YWXX() => new Vector4U16F16(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YWXY() => new Vector4U16F16(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YWXZ() => new Vector4U16F16(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YWXW() => new Vector4U16F16(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YWYX() => new Vector4U16F16(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YWYY() => new Vector4U16F16(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YWYZ() => new Vector4U16F16(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YWYW() => new Vector4U16F16(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YWZX() => new Vector4U16F16(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YWZY() => new Vector4U16F16(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YWZZ() => new Vector4U16F16(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YWZW() => new Vector4U16F16(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YWWX() => new Vector4U16F16(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YWWY() => new Vector4U16F16(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YWWZ() => new Vector4U16F16(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 YWWW() => new Vector4U16F16(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZXXX() => new Vector4U16F16(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZXXY() => new Vector4U16F16(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZXXZ() => new Vector4U16F16(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZXXW() => new Vector4U16F16(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZXYX() => new Vector4U16F16(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZXYY() => new Vector4U16F16(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZXYZ() => new Vector4U16F16(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZXYW() => new Vector4U16F16(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZXZX() => new Vector4U16F16(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZXZY() => new Vector4U16F16(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZXZZ() => new Vector4U16F16(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZXZW() => new Vector4U16F16(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZXWX() => new Vector4U16F16(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZXWY() => new Vector4U16F16(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZXWZ() => new Vector4U16F16(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZXWW() => new Vector4U16F16(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZYXX() => new Vector4U16F16(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZYXY() => new Vector4U16F16(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZYXZ() => new Vector4U16F16(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZYXW() => new Vector4U16F16(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZYYX() => new Vector4U16F16(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZYYY() => new Vector4U16F16(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZYYZ() => new Vector4U16F16(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZYYW() => new Vector4U16F16(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZYZX() => new Vector4U16F16(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZYZY() => new Vector4U16F16(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZYZZ() => new Vector4U16F16(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZYZW() => new Vector4U16F16(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZYWX() => new Vector4U16F16(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZYWY() => new Vector4U16F16(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZYWZ() => new Vector4U16F16(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZYWW() => new Vector4U16F16(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZZXX() => new Vector4U16F16(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZZXY() => new Vector4U16F16(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZZXZ() => new Vector4U16F16(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZZXW() => new Vector4U16F16(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZZYX() => new Vector4U16F16(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZZYY() => new Vector4U16F16(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZZYZ() => new Vector4U16F16(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZZYW() => new Vector4U16F16(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZZZX() => new Vector4U16F16(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZZZY() => new Vector4U16F16(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZZZZ() => new Vector4U16F16(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZZZW() => new Vector4U16F16(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZZWX() => new Vector4U16F16(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZZWY() => new Vector4U16F16(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZZWZ() => new Vector4U16F16(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZZWW() => new Vector4U16F16(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZWXX() => new Vector4U16F16(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZWXY() => new Vector4U16F16(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZWXZ() => new Vector4U16F16(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZWXW() => new Vector4U16F16(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZWYX() => new Vector4U16F16(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZWYY() => new Vector4U16F16(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZWYZ() => new Vector4U16F16(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZWYW() => new Vector4U16F16(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZWZX() => new Vector4U16F16(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZWZY() => new Vector4U16F16(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZWZZ() => new Vector4U16F16(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZWZW() => new Vector4U16F16(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZWWX() => new Vector4U16F16(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZWWY() => new Vector4U16F16(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZWWZ() => new Vector4U16F16(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 ZWWW() => new Vector4U16F16(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WXXX() => new Vector4U16F16(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WXXY() => new Vector4U16F16(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WXXZ() => new Vector4U16F16(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WXXW() => new Vector4U16F16(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WXYX() => new Vector4U16F16(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WXYY() => new Vector4U16F16(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WXYZ() => new Vector4U16F16(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WXYW() => new Vector4U16F16(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WXZX() => new Vector4U16F16(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WXZY() => new Vector4U16F16(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WXZZ() => new Vector4U16F16(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WXZW() => new Vector4U16F16(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WXWX() => new Vector4U16F16(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WXWY() => new Vector4U16F16(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WXWZ() => new Vector4U16F16(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WXWW() => new Vector4U16F16(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WYXX() => new Vector4U16F16(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WYXY() => new Vector4U16F16(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WYXZ() => new Vector4U16F16(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WYXW() => new Vector4U16F16(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WYYX() => new Vector4U16F16(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WYYY() => new Vector4U16F16(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WYYZ() => new Vector4U16F16(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WYYW() => new Vector4U16F16(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WYZX() => new Vector4U16F16(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WYZY() => new Vector4U16F16(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WYZZ() => new Vector4U16F16(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WYZW() => new Vector4U16F16(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WYWX() => new Vector4U16F16(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WYWY() => new Vector4U16F16(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WYWZ() => new Vector4U16F16(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WYWW() => new Vector4U16F16(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WZXX() => new Vector4U16F16(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WZXY() => new Vector4U16F16(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WZXZ() => new Vector4U16F16(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WZXW() => new Vector4U16F16(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WZYX() => new Vector4U16F16(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WZYY() => new Vector4U16F16(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WZYZ() => new Vector4U16F16(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WZYW() => new Vector4U16F16(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WZZX() => new Vector4U16F16(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WZZY() => new Vector4U16F16(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WZZZ() => new Vector4U16F16(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WZZW() => new Vector4U16F16(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WZWX() => new Vector4U16F16(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WZWY() => new Vector4U16F16(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WZWZ() => new Vector4U16F16(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WZWW() => new Vector4U16F16(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WWXX() => new Vector4U16F16(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WWXY() => new Vector4U16F16(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WWXZ() => new Vector4U16F16(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WWXW() => new Vector4U16F16(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WWYX() => new Vector4U16F16(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WWYY() => new Vector4U16F16(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WWYZ() => new Vector4U16F16(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WWYW() => new Vector4U16F16(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WWZX() => new Vector4U16F16(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WWZY() => new Vector4U16F16(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WWZZ() => new Vector4U16F16(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WWZW() => new Vector4U16F16(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WWWX() => new Vector4U16F16(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WWWY() => new Vector4U16F16(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WWWZ() => new Vector4U16F16(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U16F16 WWWW() => new Vector4U16F16(W, W, W, W);

    }
}
