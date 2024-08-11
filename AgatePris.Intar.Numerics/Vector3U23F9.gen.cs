using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U23F9
    : IEquatable<Vector3U23F9>
    , IFormattable
    , IVector<U48F16, I48F16, U24F8, I24F8>
    , IVectorComponentRespective<U23F9> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U23F9 X;
        public U23F9 Y;
        public U23F9 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9(U23F9 x, U23F9 y, U23F9 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9(U23F9 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9(U23F9 x, Vector2U23F9 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9(Vector3U23F9 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9(Vector2U23F9 xy, U23F9 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U23F9 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U23F9(U23F9.Zero);
        }
        public static Vector3U23F9 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U23F9(U23F9.One);
        }
        public static Vector3U23F9 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U23F9(U23F9.One, U23F9.Zero, U23F9.Zero);
        }
        public static Vector3U23F9 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U23F9(U23F9.Zero, U23F9.One, U23F9.Zero);
        }
        public static Vector3U23F9 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U23F9(U23F9.Zero, U23F9.Zero, U23F9.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator +(Vector3U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator -(Vector3U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator *(Vector3U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator *(Vector3U23F9 a, U23F9 b) => new Vector3U23F9(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator *(U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator /(Vector3U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator /(Vector3U23F9 a, U23F9 b) => new Vector3U23F9(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U23F9 operator /(U23F9 a, Vector3U23F9 b) => new Vector3U23F9(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U23F9 lhs, Vector3U23F9 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U23F9 lhs, Vector3U23F9 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U23F9 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector3U23F9 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U23F9>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U23F9 other)
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
        public Vector3U23F9 Min(Vector3U23F9 other) => new Vector3U23F9(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 Max(Vector3U23F9 other) => new Vector3U23F9(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 Half() => new Vector3U23F9(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 Twice() => new Vector3U23F9(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 Clamp(U23F9 min, U23F9 max) => new Vector3U23F9(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 Clamp(
            Vector3U23F9 min, Vector3U23F9 max
        ) => new Vector3U23F9(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 WrappingAdd(Vector3U23F9 other) => new Vector3U23F9(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 WrappingSub(Vector3U23F9 other) => new Vector3U23F9(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 WrappingMul(Vector3U23F9 other) => new Vector3U23F9(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 WrappingAddSigned(Vector3I23F9 other) => new Vector3U23F9(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 SaturatingAdd(Vector3U23F9 other) => new Vector3U23F9(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9 SaturatingMul(U23F9 other) => new Vector3U23F9(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U23F9 other) {
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
        public U23F9 Dot(Vector3U23F9 other) {
            const ulong k = 1UL << 7;
            return U23F9.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U23F9 SaturatingDot(Vector3U23F9 other) {
            const ulong k = 1UL << 7;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U23F9.MaxValue;
            } else {
                return U23F9.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U48F16 LengthSquaredUnsigned() => U48F16.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I48F16 LengthSquaredSigned() => I48F16.FromBits(
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
        public U48F16 LengthSquared() => LengthSquaredUnsigned();

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
        public U23F9 LengthHalf() => U23F9.FromBits(LengthInternal());

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
        public I23F9 LengthHalfSigned() => I23F9.FromBits(checked((int)LengthInternal()));

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
        public U24F8 LengthUnsigned() => U24F8.FromBits(LengthInternal());

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
        public I24F8 LengthSigned() => I24F8.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U24F8 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U23F9? Normalize() {
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

            const ulong k = 1UL << 8;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);

            return new Vector3U23F9(
                U23F9.FromBits(y0),
                U23F9.FromBits(y1),
                U23F9.FromBits(y2));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U23F9 XX() => new Vector2U23F9(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U23F9 XY() => new Vector2U23F9(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U23F9 XZ() => new Vector2U23F9(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U23F9 YX() => new Vector2U23F9(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U23F9 YY() => new Vector2U23F9(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U23F9 YZ() => new Vector2U23F9(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U23F9 ZX() => new Vector2U23F9(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U23F9 ZY() => new Vector2U23F9(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U23F9 ZZ() => new Vector2U23F9(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 XXX() => new Vector3U23F9(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 XXY() => new Vector3U23F9(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 XXZ() => new Vector3U23F9(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 XYX() => new Vector3U23F9(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 XYY() => new Vector3U23F9(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 XYZ() => new Vector3U23F9(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 XZX() => new Vector3U23F9(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 XZY() => new Vector3U23F9(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 XZZ() => new Vector3U23F9(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 YXX() => new Vector3U23F9(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 YXY() => new Vector3U23F9(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 YXZ() => new Vector3U23F9(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 YYX() => new Vector3U23F9(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 YYY() => new Vector3U23F9(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 YYZ() => new Vector3U23F9(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 YZX() => new Vector3U23F9(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 YZY() => new Vector3U23F9(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 YZZ() => new Vector3U23F9(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 ZXX() => new Vector3U23F9(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 ZXY() => new Vector3U23F9(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 ZXZ() => new Vector3U23F9(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 ZYX() => new Vector3U23F9(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 ZYY() => new Vector3U23F9(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 ZYZ() => new Vector3U23F9(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 ZZX() => new Vector3U23F9(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 ZZY() => new Vector3U23F9(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U23F9 ZZZ() => new Vector3U23F9(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XXXX() => new Vector4U23F9(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XXXY() => new Vector4U23F9(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XXXZ() => new Vector4U23F9(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XXYX() => new Vector4U23F9(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XXYY() => new Vector4U23F9(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XXYZ() => new Vector4U23F9(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XXZX() => new Vector4U23F9(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XXZY() => new Vector4U23F9(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XXZZ() => new Vector4U23F9(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XYXX() => new Vector4U23F9(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XYXY() => new Vector4U23F9(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XYXZ() => new Vector4U23F9(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XYYX() => new Vector4U23F9(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XYYY() => new Vector4U23F9(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XYYZ() => new Vector4U23F9(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XYZX() => new Vector4U23F9(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XYZY() => new Vector4U23F9(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XYZZ() => new Vector4U23F9(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XZXX() => new Vector4U23F9(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XZXY() => new Vector4U23F9(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XZXZ() => new Vector4U23F9(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XZYX() => new Vector4U23F9(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XZYY() => new Vector4U23F9(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XZYZ() => new Vector4U23F9(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XZZX() => new Vector4U23F9(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XZZY() => new Vector4U23F9(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 XZZZ() => new Vector4U23F9(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YXXX() => new Vector4U23F9(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YXXY() => new Vector4U23F9(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YXXZ() => new Vector4U23F9(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YXYX() => new Vector4U23F9(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YXYY() => new Vector4U23F9(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YXYZ() => new Vector4U23F9(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YXZX() => new Vector4U23F9(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YXZY() => new Vector4U23F9(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YXZZ() => new Vector4U23F9(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YYXX() => new Vector4U23F9(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YYXY() => new Vector4U23F9(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YYXZ() => new Vector4U23F9(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YYYX() => new Vector4U23F9(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YYYY() => new Vector4U23F9(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YYYZ() => new Vector4U23F9(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YYZX() => new Vector4U23F9(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YYZY() => new Vector4U23F9(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YYZZ() => new Vector4U23F9(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YZXX() => new Vector4U23F9(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YZXY() => new Vector4U23F9(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YZXZ() => new Vector4U23F9(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YZYX() => new Vector4U23F9(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YZYY() => new Vector4U23F9(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YZYZ() => new Vector4U23F9(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YZZX() => new Vector4U23F9(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YZZY() => new Vector4U23F9(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 YZZZ() => new Vector4U23F9(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZXXX() => new Vector4U23F9(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZXXY() => new Vector4U23F9(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZXXZ() => new Vector4U23F9(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZXYX() => new Vector4U23F9(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZXYY() => new Vector4U23F9(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZXYZ() => new Vector4U23F9(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZXZX() => new Vector4U23F9(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZXZY() => new Vector4U23F9(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZXZZ() => new Vector4U23F9(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZYXX() => new Vector4U23F9(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZYXY() => new Vector4U23F9(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZYXZ() => new Vector4U23F9(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZYYX() => new Vector4U23F9(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZYYY() => new Vector4U23F9(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZYYZ() => new Vector4U23F9(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZYZX() => new Vector4U23F9(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZYZY() => new Vector4U23F9(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZYZZ() => new Vector4U23F9(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZZXX() => new Vector4U23F9(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZZXY() => new Vector4U23F9(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZZXZ() => new Vector4U23F9(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZZYX() => new Vector4U23F9(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZZYY() => new Vector4U23F9(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZZYZ() => new Vector4U23F9(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZZZX() => new Vector4U23F9(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZZZY() => new Vector4U23F9(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U23F9 ZZZZ() => new Vector4U23F9(Z, Z, Z, Z);

    }
}
