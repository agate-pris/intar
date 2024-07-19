using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U13F19
    : IEquatable<Vector3U13F19>
    , IFormattable
    , IVector<U28F36, I28F36, U14F18, I14F18>
    , IVectorComponentRespective<U13F19> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U13F19 X;
        public U13F19 Y;
        public U13F19 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19(U13F19 x, U13F19 y, U13F19 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19(U13F19 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19(U13F19 x, Vector2U13F19 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19(Vector3U13F19 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19(Vector2U13F19 xy, U13F19 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U13F19 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U13F19(U13F19.Zero);
        }
        public static Vector3U13F19 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U13F19(U13F19.One);
        }
        public static Vector3U13F19 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U13F19(U13F19.One, U13F19.Zero, U13F19.Zero);
        }
        public static Vector3U13F19 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U13F19(U13F19.Zero, U13F19.One, U13F19.Zero);
        }
        public static Vector3U13F19 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U13F19(U13F19.Zero, U13F19.Zero, U13F19.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator +(Vector3U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator -(Vector3U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator *(Vector3U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator *(Vector3U13F19 a, U13F19 b) => new Vector3U13F19(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator *(U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator /(Vector3U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator /(Vector3U13F19 a, U13F19 b) => new Vector3U13F19(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U13F19 operator /(U13F19 a, Vector3U13F19 b) => new Vector3U13F19(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U13F19 lhs, Vector3U13F19 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U13F19 lhs, Vector3U13F19 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U13F19 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector3U13F19 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U13F19>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U13F19 other)
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
        public Vector3U13F19 Min(Vector3U13F19 other) => new Vector3U13F19(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19 Max(Vector3U13F19 other) => new Vector3U13F19(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19 Half() => new Vector3U13F19(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19 Twice() => new Vector3U13F19(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19 Clamp(U13F19 min, U13F19 max) => new Vector3U13F19(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19 Clamp(
            Vector3U13F19 min, Vector3U13F19 max
        ) => new Vector3U13F19(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19 WrappingAdd(Vector3U13F19 other) => new Vector3U13F19(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19 WrappingSub(Vector3U13F19 other) => new Vector3U13F19(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19 WrappingMul(Vector3U13F19 other) => new Vector3U13F19(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19 WrappingAddSigned(Vector3I13F19 other) => new Vector3U13F19(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19 SaturatingAdd(Vector3U13F19 other) => new Vector3U13F19(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19 SaturatingMul(U13F19 other) => new Vector3U13F19(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U13F19 other) {
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
        public U13F19 Dot(Vector3U13F19 other) {
            const ulong k = 1UL << 17;
            return U13F19.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U13F19 SaturatingDot(Vector3U13F19 other) {
            const ulong k = 1UL << 17;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U13F19.MaxValue;
            } else {
                return U13F19.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U28F36 LengthSquaredUnsigned() => U28F36.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I28F36 LengthSquaredSigned() => I28F36.FromBits(
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
        public U28F36 LengthSquared() => LengthSquaredUnsigned();

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
        public U13F19 LengthHalf() => U13F19.FromBits(LengthInternal());

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
        public I13F19 LengthHalfSigned() => I13F19.FromBits(checked((int)LengthInternal()));

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
        public U14F18 LengthUnsigned() => U14F18.FromBits(LengthInternal());

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
        public I14F18 LengthSigned() => I14F18.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U14F18 Length() => LengthUnsigned();

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U13F19 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(X, X); }
        public Vector2U13F19 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(X, Y); }
        public Vector2U13F19 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(X, Z); }
        public Vector2U13F19 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Y, X); }
        public Vector2U13F19 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Y, Y); }
        public Vector2U13F19 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Y, Z); }
        public Vector2U13F19 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Z, X); }
        public Vector2U13F19 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Z, Y); }
        public Vector2U13F19 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U13F19(Z, Z); }
        public Vector3U13F19 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, X, X); }
        public Vector3U13F19 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, X, Y); }
        public Vector3U13F19 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, X, Z); }
        public Vector3U13F19 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Y, X); }
        public Vector3U13F19 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Y, Y); }
        public Vector3U13F19 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Y, Z); }
        public Vector3U13F19 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Z, X); }
        public Vector3U13F19 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Z, Y); }
        public Vector3U13F19 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(X, Z, Z); }
        public Vector3U13F19 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, X, X); }
        public Vector3U13F19 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, X, Y); }
        public Vector3U13F19 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, X, Z); }
        public Vector3U13F19 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Y, X); }
        public Vector3U13F19 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Y, Y); }
        public Vector3U13F19 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Y, Z); }
        public Vector3U13F19 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Z, X); }
        public Vector3U13F19 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Z, Y); }
        public Vector3U13F19 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Y, Z, Z); }
        public Vector3U13F19 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, X, X); }
        public Vector3U13F19 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, X, Y); }
        public Vector3U13F19 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, X, Z); }
        public Vector3U13F19 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Y, X); }
        public Vector3U13F19 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Y, Y); }
        public Vector3U13F19 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Y, Z); }
        public Vector3U13F19 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Z, X); }
        public Vector3U13F19 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Z, Y); }
        public Vector3U13F19 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U13F19(Z, Z, Z); }
        public Vector4U13F19 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, X, X); }
        public Vector4U13F19 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, X, Y); }
        public Vector4U13F19 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, X, Z); }
        public Vector4U13F19 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Y, X); }
        public Vector4U13F19 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Y, Y); }
        public Vector4U13F19 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Y, Z); }
        public Vector4U13F19 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Z, X); }
        public Vector4U13F19 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Z, Y); }
        public Vector4U13F19 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, X, Z, Z); }
        public Vector4U13F19 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, X, X); }
        public Vector4U13F19 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, X, Y); }
        public Vector4U13F19 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, X, Z); }
        public Vector4U13F19 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Y, X); }
        public Vector4U13F19 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Y, Y); }
        public Vector4U13F19 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Y, Z); }
        public Vector4U13F19 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Z, X); }
        public Vector4U13F19 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Z, Y); }
        public Vector4U13F19 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Y, Z, Z); }
        public Vector4U13F19 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, X, X); }
        public Vector4U13F19 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, X, Y); }
        public Vector4U13F19 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, X, Z); }
        public Vector4U13F19 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Y, X); }
        public Vector4U13F19 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Y, Y); }
        public Vector4U13F19 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Y, Z); }
        public Vector4U13F19 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Z, X); }
        public Vector4U13F19 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Z, Y); }
        public Vector4U13F19 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(X, Z, Z, Z); }
        public Vector4U13F19 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, X, X); }
        public Vector4U13F19 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, X, Y); }
        public Vector4U13F19 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, X, Z); }
        public Vector4U13F19 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Y, X); }
        public Vector4U13F19 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Y, Y); }
        public Vector4U13F19 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Y, Z); }
        public Vector4U13F19 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Z, X); }
        public Vector4U13F19 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Z, Y); }
        public Vector4U13F19 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, X, Z, Z); }
        public Vector4U13F19 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, X, X); }
        public Vector4U13F19 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, X, Y); }
        public Vector4U13F19 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, X, Z); }
        public Vector4U13F19 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Y, X); }
        public Vector4U13F19 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Y, Y); }
        public Vector4U13F19 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Y, Z); }
        public Vector4U13F19 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Z, X); }
        public Vector4U13F19 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Z, Y); }
        public Vector4U13F19 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Y, Z, Z); }
        public Vector4U13F19 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, X, X); }
        public Vector4U13F19 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, X, Y); }
        public Vector4U13F19 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, X, Z); }
        public Vector4U13F19 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Y, X); }
        public Vector4U13F19 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Y, Y); }
        public Vector4U13F19 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Y, Z); }
        public Vector4U13F19 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Z, X); }
        public Vector4U13F19 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Z, Y); }
        public Vector4U13F19 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Y, Z, Z, Z); }
        public Vector4U13F19 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, X, X); }
        public Vector4U13F19 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, X, Y); }
        public Vector4U13F19 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, X, Z); }
        public Vector4U13F19 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Y, X); }
        public Vector4U13F19 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Y, Y); }
        public Vector4U13F19 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Y, Z); }
        public Vector4U13F19 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Z, X); }
        public Vector4U13F19 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Z, Y); }
        public Vector4U13F19 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, X, Z, Z); }
        public Vector4U13F19 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, X, X); }
        public Vector4U13F19 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, X, Y); }
        public Vector4U13F19 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, X, Z); }
        public Vector4U13F19 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Y, X); }
        public Vector4U13F19 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Y, Y); }
        public Vector4U13F19 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Y, Z); }
        public Vector4U13F19 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Z, X); }
        public Vector4U13F19 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Z, Y); }
        public Vector4U13F19 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Y, Z, Z); }
        public Vector4U13F19 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, X, X); }
        public Vector4U13F19 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, X, Y); }
        public Vector4U13F19 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, X, Z); }
        public Vector4U13F19 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Y, X); }
        public Vector4U13F19 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Y, Y); }
        public Vector4U13F19 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Y, Z); }
        public Vector4U13F19 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Z, X); }
        public Vector4U13F19 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Z, Y); }
        public Vector4U13F19 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U13F19(Z, Z, Z, Z); }

    }

    partial struct U13F19 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U13F19 SaturatingMul(Vector3U13F19 other) => other.SaturatingMul(this);
    }
}
