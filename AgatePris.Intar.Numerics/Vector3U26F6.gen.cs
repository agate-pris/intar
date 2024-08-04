using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector3U26F6
    : IEquatable<Vector3U26F6>
    , IFormattable
    , IVector<U54F10, I54F10, U27F5, I27F5>
    , IVectorComponentRespective<U26F6> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public U26F6 X;
        public U26F6 Y;
        public U26F6 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6(U26F6 x, U26F6 y, U26F6 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6(U26F6 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6(U26F6 x, Vector2U26F6 yz) : this(x, yz.X, yz.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6(Vector3U26F6 xyz) : this(xyz.X, xyz.Y, xyz.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6(Vector2U26F6 xy, U26F6 z) : this(xy.X, xy.Y, z) { }

        // Constants
        // ---------------------------------------

        public static Vector3U26F6 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U26F6(U26F6.Zero);
        }
        public static Vector3U26F6 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U26F6(U26F6.One);
        }
        public static Vector3U26F6 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U26F6(U26F6.One, U26F6.Zero, U26F6.Zero);
        }
        public static Vector3U26F6 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U26F6(U26F6.Zero, U26F6.One, U26F6.Zero);
        }
        public static Vector3U26F6 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3U26F6(U26F6.Zero, U26F6.Zero, U26F6.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator +(Vector3U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator -(Vector3U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator *(Vector3U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator *(Vector3U26F6 a, U26F6 b) => new Vector3U26F6(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator *(U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator /(Vector3U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator /(Vector3U26F6 a, U26F6 b) => new Vector3U26F6(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3U26F6 operator /(U26F6 a, Vector3U26F6 b) => new Vector3U26F6(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3U26F6 lhs, Vector3U26F6 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3U26F6 lhs, Vector3U26F6 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public U26F6 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector3U26F6 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3U26F6>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3U26F6 other)
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
        public Vector3U26F6 Min(Vector3U26F6 other) => new Vector3U26F6(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6 Max(Vector3U26F6 other) => new Vector3U26F6(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6 Half() => new Vector3U26F6(
            X.Half(),
            Y.Half(),
            Z.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6 Twice() => new Vector3U26F6(
            X.Twice(),
            Y.Twice(),
            Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6 Clamp(U26F6 min, U26F6 max) => new Vector3U26F6(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6 Clamp(
            Vector3U26F6 min, Vector3U26F6 max
        ) => new Vector3U26F6(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6 WrappingAdd(Vector3U26F6 other) => new Vector3U26F6(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6 WrappingSub(Vector3U26F6 other) => new Vector3U26F6(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6 WrappingMul(Vector3U26F6 other) => new Vector3U26F6(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6 WrappingAddSigned(Vector3I26F6 other) => new Vector3U26F6(
            X.WrappingAddSigned(other.X),
            Y.WrappingAddSigned(other.Y),
            Z.WrappingAddSigned(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6 SaturatingAdd(Vector3U26F6 other) => new Vector3U26F6(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6 SaturatingMul(U26F6 other) => new Vector3U26F6(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong DotInternal(Vector3U26F6 other) {
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
        public U26F6 Dot(Vector3U26F6 other) {
            const ulong k = 1UL << 4;
            return U26F6.FromBits((uint)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U26F6 SaturatingDot(Vector3U26F6 other) {
            const ulong k = 1UL << 4;
            var bits = DotInternal(other) / k;
            if (bits > uint.MaxValue) {
                return U26F6.MaxValue;
            } else {
                return U26F6.FromBits((uint)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        ulong LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U54F10 LengthSquaredUnsigned() => U54F10.FromBits(
            LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I54F10 LengthSquaredSigned() => I54F10.FromBits(
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
        public U54F10 LengthSquared() => LengthSquaredUnsigned();

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
        public U26F6 LengthHalf() => U26F6.FromBits(LengthInternal());

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
        public I26F6 LengthHalfSigned() => I26F6.FromBits(checked((int)LengthInternal()));

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
        public U27F5 LengthUnsigned() => U27F5.FromBits(LengthInternal());

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
        public I27F5 LengthSigned() => I27F5.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U27F5 Length() => LengthUnsigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U26F6? Normalize() {
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

            const ulong k = 1UL << 5;
            var y0 = (uint)(l0 * k / ll);
            var y1 = (uint)(l1 * k / ll);
            var y2 = (uint)(l2 * k / ll);

            return new Vector3U26F6(
                U26F6.FromBits(y0),
                U26F6.FromBits(y1),
                U26F6.FromBits(y2));
        }

        // Swizzling Properties
        // ---------------------------------------

        public Vector2U26F6 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(X, X); }
        public Vector2U26F6 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(X, Y); }
        public Vector2U26F6 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(X, Z); }
        public Vector2U26F6 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Y, X); }
        public Vector2U26F6 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Y, Y); }
        public Vector2U26F6 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Y, Z); }
        public Vector2U26F6 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Z, X); }
        public Vector2U26F6 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Z, Y); }
        public Vector2U26F6 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2U26F6(Z, Z); }
        public Vector3U26F6 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, X, X); }
        public Vector3U26F6 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, X, Y); }
        public Vector3U26F6 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, X, Z); }
        public Vector3U26F6 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Y, X); }
        public Vector3U26F6 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Y, Y); }
        public Vector3U26F6 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Y, Z); }
        public Vector3U26F6 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Z, X); }
        public Vector3U26F6 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Z, Y); }
        public Vector3U26F6 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(X, Z, Z); }
        public Vector3U26F6 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, X, X); }
        public Vector3U26F6 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, X, Y); }
        public Vector3U26F6 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, X, Z); }
        public Vector3U26F6 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Y, X); }
        public Vector3U26F6 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Y, Y); }
        public Vector3U26F6 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Y, Z); }
        public Vector3U26F6 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Z, X); }
        public Vector3U26F6 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Z, Y); }
        public Vector3U26F6 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Y, Z, Z); }
        public Vector3U26F6 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, X, X); }
        public Vector3U26F6 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, X, Y); }
        public Vector3U26F6 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, X, Z); }
        public Vector3U26F6 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Y, X); }
        public Vector3U26F6 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Y, Y); }
        public Vector3U26F6 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Y, Z); }
        public Vector3U26F6 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Z, X); }
        public Vector3U26F6 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Z, Y); }
        public Vector3U26F6 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3U26F6(Z, Z, Z); }
        public Vector4U26F6 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, X, X); }
        public Vector4U26F6 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, X, Y); }
        public Vector4U26F6 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, X, Z); }
        public Vector4U26F6 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Y, X); }
        public Vector4U26F6 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Y, Y); }
        public Vector4U26F6 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Y, Z); }
        public Vector4U26F6 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Z, X); }
        public Vector4U26F6 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Z, Y); }
        public Vector4U26F6 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, X, Z, Z); }
        public Vector4U26F6 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, X, X); }
        public Vector4U26F6 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, X, Y); }
        public Vector4U26F6 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, X, Z); }
        public Vector4U26F6 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Y, X); }
        public Vector4U26F6 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Y, Y); }
        public Vector4U26F6 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Y, Z); }
        public Vector4U26F6 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Z, X); }
        public Vector4U26F6 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Z, Y); }
        public Vector4U26F6 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Y, Z, Z); }
        public Vector4U26F6 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, X, X); }
        public Vector4U26F6 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, X, Y); }
        public Vector4U26F6 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, X, Z); }
        public Vector4U26F6 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Y, X); }
        public Vector4U26F6 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Y, Y); }
        public Vector4U26F6 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Y, Z); }
        public Vector4U26F6 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Z, X); }
        public Vector4U26F6 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Z, Y); }
        public Vector4U26F6 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(X, Z, Z, Z); }
        public Vector4U26F6 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, X, X); }
        public Vector4U26F6 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, X, Y); }
        public Vector4U26F6 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, X, Z); }
        public Vector4U26F6 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Y, X); }
        public Vector4U26F6 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Y, Y); }
        public Vector4U26F6 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Y, Z); }
        public Vector4U26F6 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Z, X); }
        public Vector4U26F6 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Z, Y); }
        public Vector4U26F6 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, X, Z, Z); }
        public Vector4U26F6 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, X, X); }
        public Vector4U26F6 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, X, Y); }
        public Vector4U26F6 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, X, Z); }
        public Vector4U26F6 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Y, X); }
        public Vector4U26F6 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Y, Y); }
        public Vector4U26F6 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Y, Z); }
        public Vector4U26F6 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Z, X); }
        public Vector4U26F6 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Z, Y); }
        public Vector4U26F6 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Y, Z, Z); }
        public Vector4U26F6 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, X, X); }
        public Vector4U26F6 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, X, Y); }
        public Vector4U26F6 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, X, Z); }
        public Vector4U26F6 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Y, X); }
        public Vector4U26F6 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Y, Y); }
        public Vector4U26F6 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Y, Z); }
        public Vector4U26F6 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Z, X); }
        public Vector4U26F6 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Z, Y); }
        public Vector4U26F6 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Y, Z, Z, Z); }
        public Vector4U26F6 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, X, X); }
        public Vector4U26F6 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, X, Y); }
        public Vector4U26F6 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, X, Z); }
        public Vector4U26F6 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Y, X); }
        public Vector4U26F6 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Y, Y); }
        public Vector4U26F6 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Y, Z); }
        public Vector4U26F6 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Z, X); }
        public Vector4U26F6 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Z, Y); }
        public Vector4U26F6 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, X, Z, Z); }
        public Vector4U26F6 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, X, X); }
        public Vector4U26F6 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, X, Y); }
        public Vector4U26F6 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, X, Z); }
        public Vector4U26F6 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Y, X); }
        public Vector4U26F6 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Y, Y); }
        public Vector4U26F6 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Y, Z); }
        public Vector4U26F6 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Z, X); }
        public Vector4U26F6 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Z, Y); }
        public Vector4U26F6 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Y, Z, Z); }
        public Vector4U26F6 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, X, X); }
        public Vector4U26F6 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, X, Y); }
        public Vector4U26F6 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, X, Z); }
        public Vector4U26F6 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Y, X); }
        public Vector4U26F6 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Y, Y); }
        public Vector4U26F6 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Y, Z); }
        public Vector4U26F6 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Z, X); }
        public Vector4U26F6 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Z, Y); }
        public Vector4U26F6 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4U26F6(Z, Z, Z, Z); }

    }
}
