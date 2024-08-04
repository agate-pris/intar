using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U25F7
    : IEquatable<Vector3U25F7>
    , IFormattable
    , IVector<U52F12, I52F12, U26F6, I26F6>
    , IVectorComponentRespective<U25F7> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U25F7 X;
        public U25F7 Y;
        public U25F7 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7(U25F7 x, U25F7 y, U25F7 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7(U25F7 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7(U25F7 x, Vector2U25F7 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7(Vector3U25F7 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7(Vector2U25F7 xy, U25F7 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U25F7 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U25F7(U25F7.Zero);
        }
        public static Vector3U25F7 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U25F7(U25F7.One);
        }
        public static Vector3U25F7 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U25F7(U25F7.One, U25F7.Zero, U25F7.Zero);
        }
        public static Vector3U25F7 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U25F7(U25F7.Zero, U25F7.One, U25F7.Zero);
        }
        public static Vector3U25F7 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U25F7(U25F7.Zero, U25F7.Zero, U25F7.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 operator +(Vector3U25F7 a, Vector3U25F7 b) => new Vector3U25F7(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 operator -(Vector3U25F7 a, Vector3U25F7 b) => new Vector3U25F7(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 operator *(Vector3U25F7 a, Vector3U25F7 b) => new Vector3U25F7(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 operator *(Vector3U25F7 a, U25F7 b) => new Vector3U25F7(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 operator *(U25F7 a, Vector3U25F7 b) => new Vector3U25F7(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 operator /(Vector3U25F7 a, Vector3U25F7 b) => new Vector3U25F7(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 operator /(Vector3U25F7 a, U25F7 b) => new Vector3U25F7(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U25F7 operator /(U25F7 a, Vector3U25F7 b) => new Vector3U25F7(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U25F7 lhs, Vector3U25F7 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U25F7 lhs, Vector3U25F7 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U25F7 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector3U25F7 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U25F7>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U25F7 other)
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
        public Vector3U25F7 Min(Vector3U25F7 other) => new Vector3U25F7(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7 Max(Vector3U25F7 other) => new Vector3U25F7(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7 Half() => new Vector3U25F7(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7 Twice() => new Vector3U25F7(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7 Clamp(U25F7 min, U25F7 max) => new Vector3U25F7(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7 Clamp(
            Vector3U25F7 min, Vector3U25F7 max
        ) => new Vector3U25F7(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7 WrappingAdd(Vector3U25F7 other) => new Vector3U25F7(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7 WrappingSub(Vector3U25F7 other) => new Vector3U25F7(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7 WrappingMul(Vector3U25F7 other) => new Vector3U25F7(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7 WrappingAddSigned(Vector3I25F7 other) => new Vector3U25F7(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7 SaturatingAdd(Vector3U25F7 other) => new Vector3U25F7(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7 SaturatingMul(U25F7 other) => new Vector3U25F7(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U25F7 other) {
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
        public U25F7 Dot(Vector3U25F7 other) {
            const ulong k = 1UL << 5;
            return U25F7.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U25F7 SaturatingDot(Vector3U25F7 other) {
            const ulong k = 1UL << 5;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U25F7.MaxValue;
            } else {
                return U25F7.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U52F12 LengthSquaredUnsigned() => U52F12.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I52F12 LengthSquaredSigned() => I52F12.FromBits(
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
        public U52F12 LengthSquared() => LengthSquaredUnsigned();

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
        public U25F7 LengthHalf() => U25F7.FromBits(LengthInternal());

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
        public I25F7 LengthHalfSigned() => I25F7.FromBits(checked((int)LengthInternal()));

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
        public U26F6 LengthUnsigned() => U26F6.FromBits(LengthInternal());

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
        public I26F6 LengthSigned() => I26F6.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U26F6 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U25F7? Normalize() {
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

            const ulong k = 1UL << 6;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);

            return new Vector3U25F7(
                U25F7.FromBits(y0),
                U25F7.FromBits(y1),
                U25F7.FromBits(y2));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U25F7 XX() => new Vector2U25F7(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U25F7 XY() => new Vector2U25F7(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U25F7 XZ() => new Vector2U25F7(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U25F7 YX() => new Vector2U25F7(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U25F7 YY() => new Vector2U25F7(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U25F7 YZ() => new Vector2U25F7(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U25F7 ZX() => new Vector2U25F7(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U25F7 ZY() => new Vector2U25F7(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2U25F7 ZZ() => new Vector2U25F7(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 XXX() => new Vector3U25F7(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 XXY() => new Vector3U25F7(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 XXZ() => new Vector3U25F7(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 XYX() => new Vector3U25F7(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 XYY() => new Vector3U25F7(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 XYZ() => new Vector3U25F7(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 XZX() => new Vector3U25F7(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 XZY() => new Vector3U25F7(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 XZZ() => new Vector3U25F7(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 YXX() => new Vector3U25F7(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 YXY() => new Vector3U25F7(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 YXZ() => new Vector3U25F7(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 YYX() => new Vector3U25F7(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 YYY() => new Vector3U25F7(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 YYZ() => new Vector3U25F7(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 YZX() => new Vector3U25F7(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 YZY() => new Vector3U25F7(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 YZZ() => new Vector3U25F7(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 ZXX() => new Vector3U25F7(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 ZXY() => new Vector3U25F7(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 ZXZ() => new Vector3U25F7(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 ZYX() => new Vector3U25F7(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 ZYY() => new Vector3U25F7(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 ZYZ() => new Vector3U25F7(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 ZZX() => new Vector3U25F7(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 ZZY() => new Vector3U25F7(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3U25F7 ZZZ() => new Vector3U25F7(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XXXX() => new Vector4U25F7(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XXXY() => new Vector4U25F7(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XXXZ() => new Vector4U25F7(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XXYX() => new Vector4U25F7(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XXYY() => new Vector4U25F7(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XXYZ() => new Vector4U25F7(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XXZX() => new Vector4U25F7(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XXZY() => new Vector4U25F7(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XXZZ() => new Vector4U25F7(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XYXX() => new Vector4U25F7(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XYXY() => new Vector4U25F7(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XYXZ() => new Vector4U25F7(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XYYX() => new Vector4U25F7(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XYYY() => new Vector4U25F7(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XYYZ() => new Vector4U25F7(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XYZX() => new Vector4U25F7(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XYZY() => new Vector4U25F7(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XYZZ() => new Vector4U25F7(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XZXX() => new Vector4U25F7(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XZXY() => new Vector4U25F7(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XZXZ() => new Vector4U25F7(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XZYX() => new Vector4U25F7(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XZYY() => new Vector4U25F7(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XZYZ() => new Vector4U25F7(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XZZX() => new Vector4U25F7(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XZZY() => new Vector4U25F7(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 XZZZ() => new Vector4U25F7(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YXXX() => new Vector4U25F7(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YXXY() => new Vector4U25F7(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YXXZ() => new Vector4U25F7(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YXYX() => new Vector4U25F7(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YXYY() => new Vector4U25F7(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YXYZ() => new Vector4U25F7(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YXZX() => new Vector4U25F7(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YXZY() => new Vector4U25F7(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YXZZ() => new Vector4U25F7(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YYXX() => new Vector4U25F7(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YYXY() => new Vector4U25F7(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YYXZ() => new Vector4U25F7(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YYYX() => new Vector4U25F7(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YYYY() => new Vector4U25F7(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YYYZ() => new Vector4U25F7(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YYZX() => new Vector4U25F7(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YYZY() => new Vector4U25F7(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YYZZ() => new Vector4U25F7(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YZXX() => new Vector4U25F7(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YZXY() => new Vector4U25F7(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YZXZ() => new Vector4U25F7(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YZYX() => new Vector4U25F7(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YZYY() => new Vector4U25F7(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YZYZ() => new Vector4U25F7(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YZZX() => new Vector4U25F7(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YZZY() => new Vector4U25F7(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 YZZZ() => new Vector4U25F7(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZXXX() => new Vector4U25F7(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZXXY() => new Vector4U25F7(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZXXZ() => new Vector4U25F7(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZXYX() => new Vector4U25F7(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZXYY() => new Vector4U25F7(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZXYZ() => new Vector4U25F7(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZXZX() => new Vector4U25F7(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZXZY() => new Vector4U25F7(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZXZZ() => new Vector4U25F7(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZYXX() => new Vector4U25F7(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZYXY() => new Vector4U25F7(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZYXZ() => new Vector4U25F7(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZYYX() => new Vector4U25F7(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZYYY() => new Vector4U25F7(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZYYZ() => new Vector4U25F7(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZYZX() => new Vector4U25F7(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZYZY() => new Vector4U25F7(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZYZZ() => new Vector4U25F7(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZZXX() => new Vector4U25F7(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZZXY() => new Vector4U25F7(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZZXZ() => new Vector4U25F7(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZZYX() => new Vector4U25F7(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZZYY() => new Vector4U25F7(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZZYZ() => new Vector4U25F7(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZZZX() => new Vector4U25F7(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZZZY() => new Vector4U25F7(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4U25F7 ZZZZ() => new Vector4U25F7(Z, Z, Z, Z);

    }
}
