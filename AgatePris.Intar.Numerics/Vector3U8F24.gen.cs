using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U8F24
    : IEquatable<Vector3U8F24>
    , IFormattable
    , IVector<U18F46, I18F46, U9F23, I9F23>
    , IVectorComponentRespective<U8F24> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U8F24 X;
        public U8F24 Y;
        public U8F24 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24(U8F24 x, U8F24 y, U8F24 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24(U8F24 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24(U8F24 x, Vector2U8F24 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24(Vector3U8F24 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24(Vector2U8F24 xy, U8F24 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U8F24 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U8F24(U8F24.Zero);
        }
        public static Vector3U8F24 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U8F24(U8F24.One);
        }
        public static Vector3U8F24 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U8F24(U8F24.One, U8F24.Zero, U8F24.Zero);
        }
        public static Vector3U8F24 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U8F24(U8F24.Zero, U8F24.One, U8F24.Zero);
        }
        public static Vector3U8F24 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U8F24(U8F24.Zero, U8F24.Zero, U8F24.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 operator +(Vector3U8F24 a, Vector3U8F24 b) => new Vector3U8F24(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 operator -(Vector3U8F24 a, Vector3U8F24 b) => new Vector3U8F24(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 operator *(Vector3U8F24 a, Vector3U8F24 b) => new Vector3U8F24(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 operator *(Vector3U8F24 a, U8F24 b) => new Vector3U8F24(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 operator *(U8F24 a, Vector3U8F24 b) => new Vector3U8F24(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 operator /(Vector3U8F24 a, Vector3U8F24 b) => new Vector3U8F24(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 operator /(Vector3U8F24 a, U8F24 b) => new Vector3U8F24(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U8F24 operator /(U8F24 a, Vector3U8F24 b) => new Vector3U8F24(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U8F24 lhs, Vector3U8F24 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U8F24 lhs, Vector3U8F24 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U8F24 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                switch (index) {
                    case 0: return X;
                    case 1: return Y;
                    case 2: return Z;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                switch (index) {
                    case 0: X = value; break;
                    case 1: Y = value; break;
                    case 2: Z = value; break;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
        }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector3U8F24 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U8F24>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U8F24 other)
            => other.X == X
            && other.Y == Y
            && other.Z == Z;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            var z = Z.ToString(format, formatProvider);
            return $"<{x}, {y}, {z}>";
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 Min(Vector3U8F24 other) => new Vector3U8F24(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 Max(Vector3U8F24 other) => new Vector3U8F24(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 Half() => new Vector3U8F24(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 Twice() => new Vector3U8F24(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 Clamp(U8F24 min, U8F24 max) => new Vector3U8F24(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 Clamp(
            Vector3U8F24 min, Vector3U8F24 max
        ) => new Vector3U8F24(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 WrappingAdd(Vector3U8F24 other) => new Vector3U8F24(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 WrappingSub(Vector3U8F24 other) => new Vector3U8F24(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 WrappingMul(Vector3U8F24 other) => new Vector3U8F24(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 WrappingAddSigned(Vector3I8F24 other) => new Vector3U8F24(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 SaturatingAdd(Vector3U8F24 other) => new Vector3U8F24(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24 SaturatingMul(U8F24 other) => new Vector3U8F24(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U8F24 other) {
            var x = ((ulong)X.Bits) * other.X.Bits;
            var y = ((ulong)Y.Bits) * other.Y.Bits;
            var z = ((ulong)Z.Bits) * other.Z.Bits;

            // オーバーフローを避けるため､ 事前に除算する｡
            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算に合わせて常に 4 で除算する｡
            return
                (x / 4) +
                (y / 4) +
                (z / 4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U8F24 Dot(Vector3U8F24 other) {
            const ulong k = 1UL << 22;
            return U8F24.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U8F24 SaturatingDot(Vector3U8F24 other) {
            const ulong k = 1UL << 22;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U8F24.MaxValue;
            } else {
                return U8F24.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U18F46 LengthSquaredUnsigned() => U18F46.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I18F46 LengthSquaredSigned() => I18F46.FromBits(
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
        public U18F46 LengthSquared() => LengthSquaredUnsigned();

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
        public U8F24 LengthHalf() => U8F24.FromBits(LengthInternal());

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
        public I8F24 LengthHalfSigned() => I8F24.FromBits(checked((int)LengthInternal()));

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
        public U9F23 LengthUnsigned() => U9F23.FromBits(LengthInternal());

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
        public I9F23 LengthSigned() => I9F23.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U9F23 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U8F24? Normalize() {
            var a0 = X.Bits;
            var a1 = Y.Bits;
            var a2 = Z.Bits;

            var max = a0.Max(a1).Max(a2);
            if (max == 0) {
                return null;
            }

            ulong m = uint.MaxValue / max;
            var l0 = m * a0;
            var l1 = m * a1;
            var l2 = m * a2;
            var sum =
                (l0 * l0 / 4) +
                (l1 * l1 / 4) +
                (l2 * l2 / 4);
            var ll = Mathi.Sqrt(sum);

            const ulong k = 1UL << 23;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);

            return new Vector3U8F24(
                U8F24.FromBits(y0),
                U8F24.FromBits(y1),
                U8F24.FromBits(y2));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 XX() => new Vector2U8F24(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 XY() => new Vector2U8F24(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 XZ() => new Vector2U8F24(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 YX() => new Vector2U8F24(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 YY() => new Vector2U8F24(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 YZ() => new Vector2U8F24(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 ZX() => new Vector2U8F24(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 ZY() => new Vector2U8F24(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U8F24 ZZ() => new Vector2U8F24(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XXX() => new Vector3U8F24(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XXY() => new Vector3U8F24(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XXZ() => new Vector3U8F24(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XYX() => new Vector3U8F24(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XYY() => new Vector3U8F24(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XYZ() => new Vector3U8F24(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XZX() => new Vector3U8F24(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XZY() => new Vector3U8F24(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 XZZ() => new Vector3U8F24(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YXX() => new Vector3U8F24(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YXY() => new Vector3U8F24(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YXZ() => new Vector3U8F24(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YYX() => new Vector3U8F24(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YYY() => new Vector3U8F24(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YYZ() => new Vector3U8F24(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YZX() => new Vector3U8F24(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YZY() => new Vector3U8F24(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 YZZ() => new Vector3U8F24(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZXX() => new Vector3U8F24(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZXY() => new Vector3U8F24(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZXZ() => new Vector3U8F24(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZYX() => new Vector3U8F24(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZYY() => new Vector3U8F24(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZYZ() => new Vector3U8F24(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZZX() => new Vector3U8F24(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZZY() => new Vector3U8F24(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U8F24 ZZZ() => new Vector3U8F24(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXXX() => new Vector4U8F24(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXXY() => new Vector4U8F24(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXXZ() => new Vector4U8F24(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXYX() => new Vector4U8F24(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXYY() => new Vector4U8F24(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXYZ() => new Vector4U8F24(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXZX() => new Vector4U8F24(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXZY() => new Vector4U8F24(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XXZZ() => new Vector4U8F24(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYXX() => new Vector4U8F24(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYXY() => new Vector4U8F24(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYXZ() => new Vector4U8F24(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYYX() => new Vector4U8F24(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYYY() => new Vector4U8F24(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYYZ() => new Vector4U8F24(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYZX() => new Vector4U8F24(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYZY() => new Vector4U8F24(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XYZZ() => new Vector4U8F24(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZXX() => new Vector4U8F24(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZXY() => new Vector4U8F24(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZXZ() => new Vector4U8F24(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZYX() => new Vector4U8F24(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZYY() => new Vector4U8F24(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZYZ() => new Vector4U8F24(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZZX() => new Vector4U8F24(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZZY() => new Vector4U8F24(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 XZZZ() => new Vector4U8F24(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXXX() => new Vector4U8F24(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXXY() => new Vector4U8F24(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXXZ() => new Vector4U8F24(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXYX() => new Vector4U8F24(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXYY() => new Vector4U8F24(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXYZ() => new Vector4U8F24(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXZX() => new Vector4U8F24(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXZY() => new Vector4U8F24(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YXZZ() => new Vector4U8F24(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYXX() => new Vector4U8F24(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYXY() => new Vector4U8F24(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYXZ() => new Vector4U8F24(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYYX() => new Vector4U8F24(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYYY() => new Vector4U8F24(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYYZ() => new Vector4U8F24(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYZX() => new Vector4U8F24(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYZY() => new Vector4U8F24(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YYZZ() => new Vector4U8F24(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZXX() => new Vector4U8F24(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZXY() => new Vector4U8F24(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZXZ() => new Vector4U8F24(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZYX() => new Vector4U8F24(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZYY() => new Vector4U8F24(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZYZ() => new Vector4U8F24(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZZX() => new Vector4U8F24(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZZY() => new Vector4U8F24(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 YZZZ() => new Vector4U8F24(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXXX() => new Vector4U8F24(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXXY() => new Vector4U8F24(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXXZ() => new Vector4U8F24(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXYX() => new Vector4U8F24(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXYY() => new Vector4U8F24(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXYZ() => new Vector4U8F24(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXZX() => new Vector4U8F24(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXZY() => new Vector4U8F24(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZXZZ() => new Vector4U8F24(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYXX() => new Vector4U8F24(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYXY() => new Vector4U8F24(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYXZ() => new Vector4U8F24(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYYX() => new Vector4U8F24(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYYY() => new Vector4U8F24(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYYZ() => new Vector4U8F24(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYZX() => new Vector4U8F24(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYZY() => new Vector4U8F24(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZYZZ() => new Vector4U8F24(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZXX() => new Vector4U8F24(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZXY() => new Vector4U8F24(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZXZ() => new Vector4U8F24(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZYX() => new Vector4U8F24(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZYY() => new Vector4U8F24(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZYZ() => new Vector4U8F24(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZZX() => new Vector4U8F24(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZZY() => new Vector4U8F24(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U8F24 ZZZZ() => new Vector4U8F24(Z, Z, Z, Z);

    }
}
