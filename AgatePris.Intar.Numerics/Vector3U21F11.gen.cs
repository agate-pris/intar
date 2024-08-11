using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U21F11
    : IEquatable<Vector3U21F11>
    , IFormattable
    , IVector<U44F20, I44F20, U22F10, I22F10>
    , IVectorComponentRespective<U21F11> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U21F11 X;
        public U21F11 Y;
        public U21F11 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11(U21F11 x, U21F11 y, U21F11 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11(U21F11 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11(U21F11 x, Vector2U21F11 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11(Vector3U21F11 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11(Vector2U21F11 xy, U21F11 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U21F11 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U21F11(U21F11.Zero);
        }
        public static Vector3U21F11 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U21F11(U21F11.One);
        }
        public static Vector3U21F11 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U21F11(U21F11.One, U21F11.Zero, U21F11.Zero);
        }
        public static Vector3U21F11 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U21F11(U21F11.Zero, U21F11.One, U21F11.Zero);
        }
        public static Vector3U21F11 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U21F11(U21F11.Zero, U21F11.Zero, U21F11.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator +(Vector3U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator -(Vector3U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator *(Vector3U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator *(Vector3U21F11 a, U21F11 b) => new Vector3U21F11(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator *(U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator /(Vector3U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator /(Vector3U21F11 a, U21F11 b) => new Vector3U21F11(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U21F11 operator /(U21F11 a, Vector3U21F11 b) => new Vector3U21F11(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U21F11 lhs, Vector3U21F11 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U21F11 lhs, Vector3U21F11 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U21F11 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector3U21F11 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U21F11>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U21F11 other)
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
        public Vector3U21F11 Min(Vector3U21F11 other) => new Vector3U21F11(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 Max(Vector3U21F11 other) => new Vector3U21F11(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 Half() => new Vector3U21F11(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 Twice() => new Vector3U21F11(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 Clamp(U21F11 min, U21F11 max) => new Vector3U21F11(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 Clamp(
            Vector3U21F11 min, Vector3U21F11 max
        ) => new Vector3U21F11(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 WrappingAdd(Vector3U21F11 other) => new Vector3U21F11(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 WrappingSub(Vector3U21F11 other) => new Vector3U21F11(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 WrappingMul(Vector3U21F11 other) => new Vector3U21F11(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 WrappingAddSigned(Vector3I21F11 other) => new Vector3U21F11(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 SaturatingAdd(Vector3U21F11 other) => new Vector3U21F11(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11 SaturatingMul(U21F11 other) => new Vector3U21F11(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U21F11 other) {
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
        public U21F11 Dot(Vector3U21F11 other) {
            const ulong k = 1UL << 9;
            return U21F11.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U21F11 SaturatingDot(Vector3U21F11 other) {
            const ulong k = 1UL << 9;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U21F11.MaxValue;
            } else {
                return U21F11.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U44F20 LengthSquaredUnsigned() => U44F20.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I44F20 LengthSquaredSigned() => I44F20.FromBits(
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
        public U44F20 LengthSquared() => LengthSquaredUnsigned();

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
        public U21F11 LengthHalf() => U21F11.FromBits(LengthInternal());

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
        public I21F11 LengthHalfSigned() => I21F11.FromBits(checked((int)LengthInternal()));

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
        public U22F10 LengthUnsigned() => U22F10.FromBits(LengthInternal());

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
        public I22F10 LengthSigned() => I22F10.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U22F10 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U21F11? Normalize() {
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

            const ulong k = 1UL << 10;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);

            return new Vector3U21F11(
                U21F11.FromBits(y0),
                U21F11.FromBits(y1),
                U21F11.FromBits(y2));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 XX() => new Vector2U21F11(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 XY() => new Vector2U21F11(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 XZ() => new Vector2U21F11(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 YX() => new Vector2U21F11(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 YY() => new Vector2U21F11(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 YZ() => new Vector2U21F11(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 ZX() => new Vector2U21F11(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 ZY() => new Vector2U21F11(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U21F11 ZZ() => new Vector2U21F11(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XXX() => new Vector3U21F11(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XXY() => new Vector3U21F11(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XXZ() => new Vector3U21F11(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XYX() => new Vector3U21F11(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XYY() => new Vector3U21F11(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XYZ() => new Vector3U21F11(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XZX() => new Vector3U21F11(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XZY() => new Vector3U21F11(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 XZZ() => new Vector3U21F11(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YXX() => new Vector3U21F11(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YXY() => new Vector3U21F11(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YXZ() => new Vector3U21F11(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YYX() => new Vector3U21F11(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YYY() => new Vector3U21F11(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YYZ() => new Vector3U21F11(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YZX() => new Vector3U21F11(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YZY() => new Vector3U21F11(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 YZZ() => new Vector3U21F11(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZXX() => new Vector3U21F11(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZXY() => new Vector3U21F11(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZXZ() => new Vector3U21F11(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZYX() => new Vector3U21F11(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZYY() => new Vector3U21F11(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZYZ() => new Vector3U21F11(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZZX() => new Vector3U21F11(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZZY() => new Vector3U21F11(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U21F11 ZZZ() => new Vector3U21F11(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXXX() => new Vector4U21F11(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXXY() => new Vector4U21F11(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXXZ() => new Vector4U21F11(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXYX() => new Vector4U21F11(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXYY() => new Vector4U21F11(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXYZ() => new Vector4U21F11(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXZX() => new Vector4U21F11(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXZY() => new Vector4U21F11(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XXZZ() => new Vector4U21F11(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYXX() => new Vector4U21F11(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYXY() => new Vector4U21F11(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYXZ() => new Vector4U21F11(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYYX() => new Vector4U21F11(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYYY() => new Vector4U21F11(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYYZ() => new Vector4U21F11(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYZX() => new Vector4U21F11(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYZY() => new Vector4U21F11(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XYZZ() => new Vector4U21F11(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZXX() => new Vector4U21F11(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZXY() => new Vector4U21F11(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZXZ() => new Vector4U21F11(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZYX() => new Vector4U21F11(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZYY() => new Vector4U21F11(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZYZ() => new Vector4U21F11(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZZX() => new Vector4U21F11(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZZY() => new Vector4U21F11(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 XZZZ() => new Vector4U21F11(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXXX() => new Vector4U21F11(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXXY() => new Vector4U21F11(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXXZ() => new Vector4U21F11(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXYX() => new Vector4U21F11(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXYY() => new Vector4U21F11(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXYZ() => new Vector4U21F11(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXZX() => new Vector4U21F11(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXZY() => new Vector4U21F11(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YXZZ() => new Vector4U21F11(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYXX() => new Vector4U21F11(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYXY() => new Vector4U21F11(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYXZ() => new Vector4U21F11(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYYX() => new Vector4U21F11(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYYY() => new Vector4U21F11(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYYZ() => new Vector4U21F11(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYZX() => new Vector4U21F11(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYZY() => new Vector4U21F11(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YYZZ() => new Vector4U21F11(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZXX() => new Vector4U21F11(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZXY() => new Vector4U21F11(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZXZ() => new Vector4U21F11(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZYX() => new Vector4U21F11(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZYY() => new Vector4U21F11(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZYZ() => new Vector4U21F11(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZZX() => new Vector4U21F11(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZZY() => new Vector4U21F11(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 YZZZ() => new Vector4U21F11(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXXX() => new Vector4U21F11(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXXY() => new Vector4U21F11(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXXZ() => new Vector4U21F11(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXYX() => new Vector4U21F11(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXYY() => new Vector4U21F11(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXYZ() => new Vector4U21F11(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXZX() => new Vector4U21F11(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXZY() => new Vector4U21F11(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZXZZ() => new Vector4U21F11(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYXX() => new Vector4U21F11(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYXY() => new Vector4U21F11(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYXZ() => new Vector4U21F11(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYYX() => new Vector4U21F11(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYYY() => new Vector4U21F11(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYYZ() => new Vector4U21F11(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYZX() => new Vector4U21F11(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYZY() => new Vector4U21F11(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZYZZ() => new Vector4U21F11(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZXX() => new Vector4U21F11(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZXY() => new Vector4U21F11(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZXZ() => new Vector4U21F11(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZYX() => new Vector4U21F11(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZYY() => new Vector4U21F11(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZYZ() => new Vector4U21F11(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZZX() => new Vector4U21F11(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZZY() => new Vector4U21F11(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U21F11 ZZZZ() => new Vector4U21F11(Z, Z, Z, Z);

    }
}
