using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4U15F17
    : IEquatable<Vector4U15F17>
    , IFormattable
    , IVector<U32F32, I32F32, U16F16, I16F16>
    , IVectorComponentRespective<U15F17> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U15F17 X;
        public U15F17 Y;
        public U15F17 Z;
        public U15F17 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(U15F17 x, U15F17 y, U15F17 z, U15F17 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(U15F17 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(U15F17 x, U15F17 y, Vector2U15F17 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(U15F17 x, Vector3U15F17 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(Vector2U15F17 xy, Vector2U15F17 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(Vector4U15F17 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(U15F17 x, Vector2U15F17 yz, U15F17 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(Vector3U15F17 xyz, U15F17 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17(Vector2U15F17 xy, U15F17 z, U15F17 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4U15F17 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U15F17(U15F17.Zero);
        }
        public static Vector4U15F17 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U15F17(U15F17.One);
        }
        public static Vector4U15F17 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U15F17(U15F17.One, U15F17.Zero, U15F17.Zero, U15F17.Zero);
        }
        public static Vector4U15F17 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U15F17(U15F17.Zero, U15F17.One, U15F17.Zero, U15F17.Zero);
        }
        public static Vector4U15F17 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U15F17(U15F17.Zero, U15F17.Zero, U15F17.One, U15F17.Zero);
        }
        public static Vector4U15F17 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4U15F17(U15F17.Zero, U15F17.Zero, U15F17.Zero, U15F17.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 operator +(Vector4U15F17 a, Vector4U15F17 b) => new Vector4U15F17(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 operator -(Vector4U15F17 a, Vector4U15F17 b) => new Vector4U15F17(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 operator *(Vector4U15F17 a, Vector4U15F17 b) => new Vector4U15F17(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 operator *(Vector4U15F17 a, U15F17 b) => new Vector4U15F17(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 operator *(U15F17 a, Vector4U15F17 b) => new Vector4U15F17(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 operator /(Vector4U15F17 a, Vector4U15F17 b) => new Vector4U15F17(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 operator /(Vector4U15F17 a, U15F17 b) => new Vector4U15F17(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4U15F17 operator /(U15F17 a, Vector4U15F17 b) => new Vector4U15F17(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4U15F17 lhs, Vector4U15F17 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4U15F17 lhs, Vector4U15F17 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U15F17 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4U15F17 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4U15F17>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4U15F17 other)
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
        public Vector4U15F17 Min(Vector4U15F17 other) => new Vector4U15F17(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 Max(Vector4U15F17 other) => new Vector4U15F17(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 Half() => new Vector4U15F17(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 Twice() => new Vector4U15F17(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 Clamp(U15F17 min, U15F17 max) => new Vector4U15F17(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 Clamp(
            Vector4U15F17 min, Vector4U15F17 max
        ) => new Vector4U15F17(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 WrappingAdd(Vector4U15F17 other) => new Vector4U15F17(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 WrappingSub(Vector4U15F17 other) => new Vector4U15F17(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 WrappingMul(Vector4U15F17 other) => new Vector4U15F17(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 WrappingAddSigned(Vector4I15F17 other) => new Vector4U15F17(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z),
            W.WrappingAddSigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 SaturatingAdd(Vector4U15F17 other) => new Vector4U15F17(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17 SaturatingMul(U15F17 other) => new Vector4U15F17(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector4U15F17 other) {
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
        public U15F17 Dot(Vector4U15F17 other) {
            const ulong k = 1UL << 15;
            return U15F17.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U15F17 SaturatingDot(Vector4U15F17 other) {
            const ulong k = 1UL << 15;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U15F17.MaxValue;
            } else {
                return U15F17.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U32F32 LengthSquaredUnsigned() => U32F32.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I32F32 LengthSquaredSigned() => I32F32.FromBits(
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
        public U32F32 LengthSquared() => LengthSquaredUnsigned();

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
        public U15F17 LengthHalf() => U15F17.FromBits(LengthInternal());

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
        public I15F17 LengthHalfSigned() => I15F17.FromBits(checked((int)LengthInternal()));

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
        public U16F16 LengthUnsigned() => U16F16.FromBits(LengthInternal());

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
        public I16F16 LengthSigned() => I16F16.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U16F16 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U15F17? Normalize() {
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

            const ulong k = 1UL << 16;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);
            var y3 = (uint)(l3 * k / ll);

            return new Vector4U15F17(
                U15F17.FromBits(y0),
                U15F17.FromBits(y1),
                U15F17.FromBits(y2),
                U15F17.FromBits(y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U15F17 XX() => new Vector2U15F17(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U15F17 XY() => new Vector2U15F17(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U15F17 XZ() => new Vector2U15F17(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U15F17 XW() => new Vector2U15F17(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U15F17 YX() => new Vector2U15F17(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U15F17 YY() => new Vector2U15F17(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U15F17 YZ() => new Vector2U15F17(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U15F17 YW() => new Vector2U15F17(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U15F17 ZX() => new Vector2U15F17(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U15F17 ZY() => new Vector2U15F17(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U15F17 ZZ() => new Vector2U15F17(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U15F17 ZW() => new Vector2U15F17(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U15F17 WX() => new Vector2U15F17(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U15F17 WY() => new Vector2U15F17(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U15F17 WZ() => new Vector2U15F17(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U15F17 WW() => new Vector2U15F17(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 XXX() => new Vector3U15F17(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 XXY() => new Vector3U15F17(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 XXZ() => new Vector3U15F17(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 XXW() => new Vector3U15F17(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 XYX() => new Vector3U15F17(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 XYY() => new Vector3U15F17(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 XYZ() => new Vector3U15F17(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 XYW() => new Vector3U15F17(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 XZX() => new Vector3U15F17(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 XZY() => new Vector3U15F17(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 XZZ() => new Vector3U15F17(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 XZW() => new Vector3U15F17(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 XWX() => new Vector3U15F17(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 XWY() => new Vector3U15F17(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 XWZ() => new Vector3U15F17(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 XWW() => new Vector3U15F17(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 YXX() => new Vector3U15F17(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 YXY() => new Vector3U15F17(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 YXZ() => new Vector3U15F17(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 YXW() => new Vector3U15F17(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 YYX() => new Vector3U15F17(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 YYY() => new Vector3U15F17(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 YYZ() => new Vector3U15F17(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 YYW() => new Vector3U15F17(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 YZX() => new Vector3U15F17(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 YZY() => new Vector3U15F17(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 YZZ() => new Vector3U15F17(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 YZW() => new Vector3U15F17(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 YWX() => new Vector3U15F17(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 YWY() => new Vector3U15F17(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 YWZ() => new Vector3U15F17(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 YWW() => new Vector3U15F17(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 ZXX() => new Vector3U15F17(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 ZXY() => new Vector3U15F17(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 ZXZ() => new Vector3U15F17(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 ZXW() => new Vector3U15F17(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 ZYX() => new Vector3U15F17(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 ZYY() => new Vector3U15F17(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 ZYZ() => new Vector3U15F17(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 ZYW() => new Vector3U15F17(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 ZZX() => new Vector3U15F17(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 ZZY() => new Vector3U15F17(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 ZZZ() => new Vector3U15F17(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 ZZW() => new Vector3U15F17(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 ZWX() => new Vector3U15F17(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 ZWY() => new Vector3U15F17(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 ZWZ() => new Vector3U15F17(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 ZWW() => new Vector3U15F17(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 WXX() => new Vector3U15F17(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 WXY() => new Vector3U15F17(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 WXZ() => new Vector3U15F17(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 WXW() => new Vector3U15F17(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 WYX() => new Vector3U15F17(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 WYY() => new Vector3U15F17(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 WYZ() => new Vector3U15F17(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 WYW() => new Vector3U15F17(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 WZX() => new Vector3U15F17(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 WZY() => new Vector3U15F17(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 WZZ() => new Vector3U15F17(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 WZW() => new Vector3U15F17(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 WWX() => new Vector3U15F17(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 WWY() => new Vector3U15F17(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 WWZ() => new Vector3U15F17(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U15F17 WWW() => new Vector3U15F17(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XXXX() => new Vector4U15F17(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XXXY() => new Vector4U15F17(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XXXZ() => new Vector4U15F17(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XXXW() => new Vector4U15F17(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XXYX() => new Vector4U15F17(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XXYY() => new Vector4U15F17(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XXYZ() => new Vector4U15F17(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XXYW() => new Vector4U15F17(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XXZX() => new Vector4U15F17(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XXZY() => new Vector4U15F17(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XXZZ() => new Vector4U15F17(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XXZW() => new Vector4U15F17(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XXWX() => new Vector4U15F17(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XXWY() => new Vector4U15F17(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XXWZ() => new Vector4U15F17(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XXWW() => new Vector4U15F17(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XYXX() => new Vector4U15F17(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XYXY() => new Vector4U15F17(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XYXZ() => new Vector4U15F17(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XYXW() => new Vector4U15F17(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XYYX() => new Vector4U15F17(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XYYY() => new Vector4U15F17(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XYYZ() => new Vector4U15F17(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XYYW() => new Vector4U15F17(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XYZX() => new Vector4U15F17(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XYZY() => new Vector4U15F17(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XYZZ() => new Vector4U15F17(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XYZW() => new Vector4U15F17(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XYWX() => new Vector4U15F17(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XYWY() => new Vector4U15F17(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XYWZ() => new Vector4U15F17(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XYWW() => new Vector4U15F17(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XZXX() => new Vector4U15F17(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XZXY() => new Vector4U15F17(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XZXZ() => new Vector4U15F17(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XZXW() => new Vector4U15F17(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XZYX() => new Vector4U15F17(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XZYY() => new Vector4U15F17(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XZYZ() => new Vector4U15F17(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XZYW() => new Vector4U15F17(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XZZX() => new Vector4U15F17(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XZZY() => new Vector4U15F17(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XZZZ() => new Vector4U15F17(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XZZW() => new Vector4U15F17(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XZWX() => new Vector4U15F17(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XZWY() => new Vector4U15F17(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XZWZ() => new Vector4U15F17(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XZWW() => new Vector4U15F17(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XWXX() => new Vector4U15F17(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XWXY() => new Vector4U15F17(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XWXZ() => new Vector4U15F17(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XWXW() => new Vector4U15F17(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XWYX() => new Vector4U15F17(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XWYY() => new Vector4U15F17(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XWYZ() => new Vector4U15F17(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XWYW() => new Vector4U15F17(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XWZX() => new Vector4U15F17(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XWZY() => new Vector4U15F17(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XWZZ() => new Vector4U15F17(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XWZW() => new Vector4U15F17(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XWWX() => new Vector4U15F17(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XWWY() => new Vector4U15F17(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XWWZ() => new Vector4U15F17(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 XWWW() => new Vector4U15F17(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YXXX() => new Vector4U15F17(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YXXY() => new Vector4U15F17(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YXXZ() => new Vector4U15F17(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YXXW() => new Vector4U15F17(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YXYX() => new Vector4U15F17(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YXYY() => new Vector4U15F17(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YXYZ() => new Vector4U15F17(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YXYW() => new Vector4U15F17(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YXZX() => new Vector4U15F17(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YXZY() => new Vector4U15F17(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YXZZ() => new Vector4U15F17(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YXZW() => new Vector4U15F17(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YXWX() => new Vector4U15F17(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YXWY() => new Vector4U15F17(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YXWZ() => new Vector4U15F17(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YXWW() => new Vector4U15F17(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YYXX() => new Vector4U15F17(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YYXY() => new Vector4U15F17(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YYXZ() => new Vector4U15F17(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YYXW() => new Vector4U15F17(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YYYX() => new Vector4U15F17(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YYYY() => new Vector4U15F17(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YYYZ() => new Vector4U15F17(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YYYW() => new Vector4U15F17(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YYZX() => new Vector4U15F17(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YYZY() => new Vector4U15F17(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YYZZ() => new Vector4U15F17(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YYZW() => new Vector4U15F17(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YYWX() => new Vector4U15F17(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YYWY() => new Vector4U15F17(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YYWZ() => new Vector4U15F17(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YYWW() => new Vector4U15F17(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YZXX() => new Vector4U15F17(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YZXY() => new Vector4U15F17(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YZXZ() => new Vector4U15F17(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YZXW() => new Vector4U15F17(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YZYX() => new Vector4U15F17(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YZYY() => new Vector4U15F17(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YZYZ() => new Vector4U15F17(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YZYW() => new Vector4U15F17(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YZZX() => new Vector4U15F17(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YZZY() => new Vector4U15F17(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YZZZ() => new Vector4U15F17(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YZZW() => new Vector4U15F17(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YZWX() => new Vector4U15F17(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YZWY() => new Vector4U15F17(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YZWZ() => new Vector4U15F17(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YZWW() => new Vector4U15F17(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YWXX() => new Vector4U15F17(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YWXY() => new Vector4U15F17(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YWXZ() => new Vector4U15F17(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YWXW() => new Vector4U15F17(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YWYX() => new Vector4U15F17(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YWYY() => new Vector4U15F17(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YWYZ() => new Vector4U15F17(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YWYW() => new Vector4U15F17(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YWZX() => new Vector4U15F17(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YWZY() => new Vector4U15F17(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YWZZ() => new Vector4U15F17(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YWZW() => new Vector4U15F17(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YWWX() => new Vector4U15F17(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YWWY() => new Vector4U15F17(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YWWZ() => new Vector4U15F17(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 YWWW() => new Vector4U15F17(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZXXX() => new Vector4U15F17(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZXXY() => new Vector4U15F17(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZXXZ() => new Vector4U15F17(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZXXW() => new Vector4U15F17(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZXYX() => new Vector4U15F17(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZXYY() => new Vector4U15F17(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZXYZ() => new Vector4U15F17(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZXYW() => new Vector4U15F17(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZXZX() => new Vector4U15F17(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZXZY() => new Vector4U15F17(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZXZZ() => new Vector4U15F17(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZXZW() => new Vector4U15F17(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZXWX() => new Vector4U15F17(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZXWY() => new Vector4U15F17(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZXWZ() => new Vector4U15F17(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZXWW() => new Vector4U15F17(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZYXX() => new Vector4U15F17(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZYXY() => new Vector4U15F17(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZYXZ() => new Vector4U15F17(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZYXW() => new Vector4U15F17(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZYYX() => new Vector4U15F17(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZYYY() => new Vector4U15F17(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZYYZ() => new Vector4U15F17(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZYYW() => new Vector4U15F17(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZYZX() => new Vector4U15F17(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZYZY() => new Vector4U15F17(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZYZZ() => new Vector4U15F17(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZYZW() => new Vector4U15F17(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZYWX() => new Vector4U15F17(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZYWY() => new Vector4U15F17(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZYWZ() => new Vector4U15F17(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZYWW() => new Vector4U15F17(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZZXX() => new Vector4U15F17(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZZXY() => new Vector4U15F17(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZZXZ() => new Vector4U15F17(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZZXW() => new Vector4U15F17(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZZYX() => new Vector4U15F17(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZZYY() => new Vector4U15F17(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZZYZ() => new Vector4U15F17(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZZYW() => new Vector4U15F17(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZZZX() => new Vector4U15F17(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZZZY() => new Vector4U15F17(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZZZZ() => new Vector4U15F17(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZZZW() => new Vector4U15F17(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZZWX() => new Vector4U15F17(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZZWY() => new Vector4U15F17(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZZWZ() => new Vector4U15F17(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZZWW() => new Vector4U15F17(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZWXX() => new Vector4U15F17(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZWXY() => new Vector4U15F17(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZWXZ() => new Vector4U15F17(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZWXW() => new Vector4U15F17(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZWYX() => new Vector4U15F17(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZWYY() => new Vector4U15F17(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZWYZ() => new Vector4U15F17(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZWYW() => new Vector4U15F17(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZWZX() => new Vector4U15F17(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZWZY() => new Vector4U15F17(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZWZZ() => new Vector4U15F17(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZWZW() => new Vector4U15F17(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZWWX() => new Vector4U15F17(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZWWY() => new Vector4U15F17(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZWWZ() => new Vector4U15F17(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 ZWWW() => new Vector4U15F17(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WXXX() => new Vector4U15F17(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WXXY() => new Vector4U15F17(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WXXZ() => new Vector4U15F17(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WXXW() => new Vector4U15F17(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WXYX() => new Vector4U15F17(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WXYY() => new Vector4U15F17(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WXYZ() => new Vector4U15F17(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WXYW() => new Vector4U15F17(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WXZX() => new Vector4U15F17(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WXZY() => new Vector4U15F17(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WXZZ() => new Vector4U15F17(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WXZW() => new Vector4U15F17(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WXWX() => new Vector4U15F17(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WXWY() => new Vector4U15F17(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WXWZ() => new Vector4U15F17(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WXWW() => new Vector4U15F17(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WYXX() => new Vector4U15F17(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WYXY() => new Vector4U15F17(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WYXZ() => new Vector4U15F17(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WYXW() => new Vector4U15F17(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WYYX() => new Vector4U15F17(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WYYY() => new Vector4U15F17(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WYYZ() => new Vector4U15F17(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WYYW() => new Vector4U15F17(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WYZX() => new Vector4U15F17(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WYZY() => new Vector4U15F17(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WYZZ() => new Vector4U15F17(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WYZW() => new Vector4U15F17(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WYWX() => new Vector4U15F17(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WYWY() => new Vector4U15F17(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WYWZ() => new Vector4U15F17(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WYWW() => new Vector4U15F17(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WZXX() => new Vector4U15F17(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WZXY() => new Vector4U15F17(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WZXZ() => new Vector4U15F17(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WZXW() => new Vector4U15F17(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WZYX() => new Vector4U15F17(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WZYY() => new Vector4U15F17(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WZYZ() => new Vector4U15F17(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WZYW() => new Vector4U15F17(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WZZX() => new Vector4U15F17(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WZZY() => new Vector4U15F17(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WZZZ() => new Vector4U15F17(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WZZW() => new Vector4U15F17(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WZWX() => new Vector4U15F17(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WZWY() => new Vector4U15F17(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WZWZ() => new Vector4U15F17(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WZWW() => new Vector4U15F17(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WWXX() => new Vector4U15F17(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WWXY() => new Vector4U15F17(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WWXZ() => new Vector4U15F17(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WWXW() => new Vector4U15F17(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WWYX() => new Vector4U15F17(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WWYY() => new Vector4U15F17(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WWYZ() => new Vector4U15F17(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WWYW() => new Vector4U15F17(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WWZX() => new Vector4U15F17(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WWZY() => new Vector4U15F17(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WWZZ() => new Vector4U15F17(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WWZW() => new Vector4U15F17(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WWWX() => new Vector4U15F17(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WWWY() => new Vector4U15F17(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WWWZ() => new Vector4U15F17(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U15F17 WWWW() => new Vector4U15F17(W, W, W, W);

    }
}
