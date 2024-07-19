using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U15F17
    : IEquatable<Vector3U15F17>
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

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17(U15F17 x, U15F17 y, U15F17 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17(U15F17 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17(U15F17 x, Vector2U15F17 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17(Vector3U15F17 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17(Vector2U15F17 xy, U15F17 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U15F17 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U15F17(U15F17.Zero);
        }
        public static Vector3U15F17 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U15F17(U15F17.One);
        }
        public static Vector3U15F17 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U15F17(U15F17.One, U15F17.Zero, U15F17.Zero);
        }
        public static Vector3U15F17 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U15F17(U15F17.Zero, U15F17.One, U15F17.Zero);
        }
        public static Vector3U15F17 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U15F17(U15F17.Zero, U15F17.Zero, U15F17.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator +(Vector3U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator -(Vector3U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator *(Vector3U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator *(Vector3U15F17 a, U15F17 b) => new Vector3U15F17(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator *(U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator /(Vector3U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator /(Vector3U15F17 a, U15F17 b) => new Vector3U15F17(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U15F17 operator /(U15F17 a, Vector3U15F17 b) => new Vector3U15F17(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U15F17 lhs, Vector3U15F17 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U15F17 lhs, Vector3U15F17 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U15F17 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector3U15F17 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U15F17>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U15F17 other)
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
        public Vector3U15F17 Min(Vector3U15F17 other) => new Vector3U15F17(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17 Max(Vector3U15F17 other) => new Vector3U15F17(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17 Half() => new Vector3U15F17(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17 Twice() => new Vector3U15F17(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17 Clamp(U15F17 min, U15F17 max) => new Vector3U15F17(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17 Clamp(
            Vector3U15F17 min, Vector3U15F17 max
        ) => new Vector3U15F17(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17 WrappingAdd(Vector3U15F17 other) => new Vector3U15F17(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17 WrappingSub(Vector3U15F17 other) => new Vector3U15F17(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17 WrappingMul(Vector3U15F17 other) => new Vector3U15F17(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17 WrappingAddSigned(Vector3I15F17 other) => new Vector3U15F17(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17 SaturatingAdd(Vector3U15F17 other) => new Vector3U15F17(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17 SaturatingMul(U15F17 other) => new Vector3U15F17(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U15F17 other) {
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
        public U15F17 Dot(Vector3U15F17 other) {
            const ulong k = 1UL << 15;
            return U15F17.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U15F17 SaturatingDot(Vector3U15F17 other) {
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

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U15F17 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(X, X); }
        public Vector2U15F17 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(X, Y); }
        public Vector2U15F17 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(X, Z); }
        public Vector2U15F17 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Y, X); }
        public Vector2U15F17 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Y, Y); }
        public Vector2U15F17 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Y, Z); }
        public Vector2U15F17 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Z, X); }
        public Vector2U15F17 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Z, Y); }
        public Vector2U15F17 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U15F17(Z, Z); }
        public Vector3U15F17 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, X, X); }
        public Vector3U15F17 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, X, Y); }
        public Vector3U15F17 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, X, Z); }
        public Vector3U15F17 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Y, X); }
        public Vector3U15F17 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Y, Y); }
        public Vector3U15F17 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Y, Z); }
        public Vector3U15F17 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Z, X); }
        public Vector3U15F17 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Z, Y); }
        public Vector3U15F17 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(X, Z, Z); }
        public Vector3U15F17 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, X, X); }
        public Vector3U15F17 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, X, Y); }
        public Vector3U15F17 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, X, Z); }
        public Vector3U15F17 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Y, X); }
        public Vector3U15F17 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Y, Y); }
        public Vector3U15F17 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Y, Z); }
        public Vector3U15F17 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Z, X); }
        public Vector3U15F17 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Z, Y); }
        public Vector3U15F17 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Y, Z, Z); }
        public Vector3U15F17 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, X, X); }
        public Vector3U15F17 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, X, Y); }
        public Vector3U15F17 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, X, Z); }
        public Vector3U15F17 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Y, X); }
        public Vector3U15F17 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Y, Y); }
        public Vector3U15F17 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Y, Z); }
        public Vector3U15F17 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Z, X); }
        public Vector3U15F17 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Z, Y); }
        public Vector3U15F17 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U15F17(Z, Z, Z); }
        public Vector4U15F17 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, X, X); }
        public Vector4U15F17 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, X, Y); }
        public Vector4U15F17 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, X, Z); }
        public Vector4U15F17 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Y, X); }
        public Vector4U15F17 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Y, Y); }
        public Vector4U15F17 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Y, Z); }
        public Vector4U15F17 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Z, X); }
        public Vector4U15F17 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Z, Y); }
        public Vector4U15F17 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, X, Z, Z); }
        public Vector4U15F17 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, X, X); }
        public Vector4U15F17 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, X, Y); }
        public Vector4U15F17 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, X, Z); }
        public Vector4U15F17 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Y, X); }
        public Vector4U15F17 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Y, Y); }
        public Vector4U15F17 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Y, Z); }
        public Vector4U15F17 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Z, X); }
        public Vector4U15F17 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Z, Y); }
        public Vector4U15F17 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Y, Z, Z); }
        public Vector4U15F17 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, X, X); }
        public Vector4U15F17 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, X, Y); }
        public Vector4U15F17 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, X, Z); }
        public Vector4U15F17 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Y, X); }
        public Vector4U15F17 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Y, Y); }
        public Vector4U15F17 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Y, Z); }
        public Vector4U15F17 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Z, X); }
        public Vector4U15F17 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Z, Y); }
        public Vector4U15F17 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(X, Z, Z, Z); }
        public Vector4U15F17 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, X, X); }
        public Vector4U15F17 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, X, Y); }
        public Vector4U15F17 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, X, Z); }
        public Vector4U15F17 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Y, X); }
        public Vector4U15F17 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Y, Y); }
        public Vector4U15F17 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Y, Z); }
        public Vector4U15F17 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Z, X); }
        public Vector4U15F17 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Z, Y); }
        public Vector4U15F17 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, X, Z, Z); }
        public Vector4U15F17 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, X, X); }
        public Vector4U15F17 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, X, Y); }
        public Vector4U15F17 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, X, Z); }
        public Vector4U15F17 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Y, X); }
        public Vector4U15F17 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Y, Y); }
        public Vector4U15F17 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Y, Z); }
        public Vector4U15F17 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Z, X); }
        public Vector4U15F17 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Z, Y); }
        public Vector4U15F17 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Y, Z, Z); }
        public Vector4U15F17 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, X, X); }
        public Vector4U15F17 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, X, Y); }
        public Vector4U15F17 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, X, Z); }
        public Vector4U15F17 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Y, X); }
        public Vector4U15F17 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Y, Y); }
        public Vector4U15F17 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Y, Z); }
        public Vector4U15F17 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Z, X); }
        public Vector4U15F17 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Z, Y); }
        public Vector4U15F17 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Y, Z, Z, Z); }
        public Vector4U15F17 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, X, X); }
        public Vector4U15F17 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, X, Y); }
        public Vector4U15F17 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, X, Z); }
        public Vector4U15F17 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Y, X); }
        public Vector4U15F17 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Y, Y); }
        public Vector4U15F17 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Y, Z); }
        public Vector4U15F17 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Z, X); }
        public Vector4U15F17 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Z, Y); }
        public Vector4U15F17 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, X, Z, Z); }
        public Vector4U15F17 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, X, X); }
        public Vector4U15F17 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, X, Y); }
        public Vector4U15F17 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, X, Z); }
        public Vector4U15F17 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Y, X); }
        public Vector4U15F17 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Y, Y); }
        public Vector4U15F17 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Y, Z); }
        public Vector4U15F17 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Z, X); }
        public Vector4U15F17 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Z, Y); }
        public Vector4U15F17 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Y, Z, Z); }
        public Vector4U15F17 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, X, X); }
        public Vector4U15F17 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, X, Y); }
        public Vector4U15F17 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, X, Z); }
        public Vector4U15F17 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Y, X); }
        public Vector4U15F17 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Y, Y); }
        public Vector4U15F17 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Y, Z); }
        public Vector4U15F17 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Z, X); }
        public Vector4U15F17 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Z, Y); }
        public Vector4U15F17 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U15F17(Z, Z, Z, Z); }

    }

    partial struct U15F17 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U15F17 SaturatingMul(Vector3U15F17 other) => other.SaturatingMul(this);
    }
}
