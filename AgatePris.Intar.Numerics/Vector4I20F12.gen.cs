using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar.Numerics {
    [Serializable]
    public struct Vector4I20F12
    : IEquatable<Vector4I20F12>
    , IFormattable
    , IVector<U42F22, I42F22, U21F11, I21F11>
    , IVectorComponentRespective<I20F12> {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I20F12 X;
        public I20F12 Y;
        public I20F12 Z;
        public I20F12 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(I20F12 x, I20F12 y, I20F12 z, I20F12 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(I20F12 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(I20F12 x, I20F12 y, Vector2I20F12 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(I20F12 x, Vector3I20F12 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(Vector2I20F12 xy, Vector2I20F12 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(Vector4I20F12 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(I20F12 x, Vector2I20F12 yz, I20F12 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(Vector3I20F12 xyz, I20F12 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12(Vector2I20F12 xy, I20F12 z, I20F12 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I20F12 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I20F12(I20F12.Zero);
        }
        public static Vector4I20F12 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I20F12(I20F12.One);
        }
        public static Vector4I20F12 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I20F12(I20F12.One, I20F12.Zero, I20F12.Zero, I20F12.Zero);
        }
        public static Vector4I20F12 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I20F12(I20F12.Zero, I20F12.One, I20F12.Zero, I20F12.Zero);
        }
        public static Vector4I20F12 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I20F12(I20F12.Zero, I20F12.Zero, I20F12.One, I20F12.Zero);
        }
        public static Vector4I20F12 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I20F12(I20F12.Zero, I20F12.Zero, I20F12.Zero, I20F12.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 operator +(Vector4I20F12 a, Vector4I20F12 b) => new Vector4I20F12(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 operator -(Vector4I20F12 a, Vector4I20F12 b) => new Vector4I20F12(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 operator *(Vector4I20F12 a, Vector4I20F12 b) => new Vector4I20F12(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 operator *(Vector4I20F12 a, I20F12 b) => new Vector4I20F12(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 operator *(I20F12 a, Vector4I20F12 b) => new Vector4I20F12(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 operator /(Vector4I20F12 a, Vector4I20F12 b) => new Vector4I20F12(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 operator /(Vector4I20F12 a, I20F12 b) => new Vector4I20F12(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I20F12 operator /(I20F12 a, Vector4I20F12 b) => new Vector4I20F12(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I20F12 lhs, Vector4I20F12 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I20F12 lhs, Vector4I20F12 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I20F12 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4I20F12 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I20F12>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I20F12 other)
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
        public Vector4I20F12 Min(Vector4I20F12 other) => new Vector4I20F12(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 Max(Vector4I20F12 other) => new Vector4I20F12(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 Abs() => new Vector4I20F12(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 Half() => new Vector4I20F12(
            X.Half(),
            Y.Half(),
            Z.Half(),
            W.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 Twice() => new Vector4I20F12(
            X.Twice(),
            Y.Twice(),
            Z.Twice(),
            W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 Clamp(I20F12 min, I20F12 max) => new Vector4I20F12(
            X.Clamp(min, max),
            Y.Clamp(min, max),
            Z.Clamp(min, max),
            W.Clamp(min, max));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 Clamp(
            Vector4I20F12 min, Vector4I20F12 max
        ) => new Vector4I20F12(
            X.Clamp(min.X, max.X),
            Y.Clamp(min.Y, max.Y),
            Z.Clamp(min.Z, max.Z),
            W.Clamp(min.W, max.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 WrappingAdd(Vector4I20F12 other) => new Vector4I20F12(
            X.WrappingAdd(other.X),
            Y.WrappingAdd(other.Y),
            Z.WrappingAdd(other.Z),
            W.WrappingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 WrappingSub(Vector4I20F12 other) => new Vector4I20F12(
            X.WrappingSub(other.X),
            Y.WrappingSub(other.Y),
            Z.WrappingSub(other.Z),
            W.WrappingSub(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 WrappingMul(Vector4I20F12 other) => new Vector4I20F12(
            X.WrappingMul(other.X),
            Y.WrappingMul(other.Y),
            Z.WrappingMul(other.Z),
            W.WrappingMul(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 WrappingAddUnsigned(Vector4U20F12 other) => new Vector4I20F12(
            X.WrappingAddUnsigned(other.X),
            Y.WrappingAddUnsigned(other.Y),
            Z.WrappingAddUnsigned(other.Z),
            W.WrappingAddUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 WrappingSubUnsigned(Vector4U20F12 other) => new Vector4I20F12(
            X.WrappingSubUnsigned(other.X),
            Y.WrappingSubUnsigned(other.Y),
            Z.WrappingSubUnsigned(other.Z),
            W.WrappingSubUnsigned(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U20F12 UnsignedAbs() => new Vector4U20F12(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 SaturatingAdd(Vector4I20F12 other) => new Vector4I20F12(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y),
            Z.SaturatingAdd(other.Z),
            W.SaturatingAdd(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 SaturatingMul(I20F12 other) => new Vector4I20F12(
            X.SaturatingMul(other),
            Y.SaturatingMul(other),
            Z.SaturatingMul(other),
            W.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I20F12 other) {
            var x = ((long)X.Bits) * other.X.Bits;
            var y = ((long)Y.Bits) * other.Y.Bits;
            var z = ((long)Z.Bits) * other.Z.Bits;
            var w = ((long)W.Bits) * other.W.Bits;

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
        public I20F12 Dot(Vector4I20F12 other) {
            const long k = 1L << 10;
            return I20F12.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I20F12 SaturatingDot(Vector4I20F12 other) {
            const long k = 1L << 10;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I20F12.MaxValue;
            } else if (bits < int.MinValue) {
                return I20F12.MinValue;
            } else {
                return I20F12.FromBits((int)bits);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long LengthSquaredInternal() => DotInternal(this);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U42F22 LengthSquaredUnsigned() => U42F22.FromBits(
            (ulong)LengthSquaredInternal()
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I42F22 LengthSquaredSigned() => I42F22.FromBits(
            LengthSquaredInternal()
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
        public I42F22 LengthSquared() => LengthSquaredSigned();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        uint LengthInternal() {
            var squared = LengthSquaredInternal();
            return (uint)Mathi.Sqrt((ulong)squared);
        }

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// </summary>
        /// <remarks>
        /// <para>This method differs from <see cref="LengthHalf">LengthHalf</see> in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para>このメソッドは <see cref="LengthHalf">LengthHalf</see> とは異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </remarks>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalf"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U20F12 LengthHalfUnsigned() => U20F12.FromBits(LengthInternal());

        /// <summary>
        /// <para>Returns the half of the length of the vector.</para>
        /// <para>ベクトルの長さの半分を返します｡</para>
        /// <remarks><div class="WARNING alert alert-warning">
        /// <h5>Warning</h5>
        /// <para>This method throws an exception if the result is outside the range of the data type.</para>
        /// <para>このメソッドは結果がデータ型の範囲外の場合に例外を送出します｡</para>
        /// <para><see cref="LengthHalfUnsigned">LengthHalfUnsigned</see> differs from this method in that
        /// it does not throws an exception because the result always falls within a range.</para>
        /// <para><see cref="LengthHalfUnsigned">LengthHalfUnsigned</see> はこのメソッドと異なり､
        /// 結果が必ず範囲内に収まるため例外を送出することはありません｡</para>
        /// </div></remarks>
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="LengthHalfUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I20F12 LengthHalf() => I20F12.FromBits(checked((int)LengthInternal()));

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
        /// <seealso cref="LengthHalfUnsigned"/>
        /// <seealso cref="LengthSigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U21F11 LengthUnsigned() => U21F11.FromBits(LengthInternal());

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
        /// <seealso cref="LengthHalf"/>
        /// <seealso cref="LengthUnsigned"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I21F11 LengthSigned() => I21F11.FromBits(checked((int)LengthInternal()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I21F11 Length() => LengthSigned();

        // Swizzling Properties
        // ---------------------------------------

        public Vector2I20F12 XX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(X, X); }
        public Vector2I20F12 XY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(X, Y); }
        public Vector2I20F12 XZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(X, Z); }
        public Vector2I20F12 XW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(X, W); }
        public Vector2I20F12 YX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Y, X); }
        public Vector2I20F12 YY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Y, Y); }
        public Vector2I20F12 YZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Y, Z); }
        public Vector2I20F12 YW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Y, W); }
        public Vector2I20F12 ZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Z, X); }
        public Vector2I20F12 ZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Z, Y); }
        public Vector2I20F12 ZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Z, Z); }
        public Vector2I20F12 ZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(Z, W); }
        public Vector2I20F12 WX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(W, X); }
        public Vector2I20F12 WY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(W, Y); }
        public Vector2I20F12 WZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(W, Z); }
        public Vector2I20F12 WW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector2I20F12(W, W); }
        public Vector3I20F12 XXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, X, X); }
        public Vector3I20F12 XXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, X, Y); }
        public Vector3I20F12 XXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, X, Z); }
        public Vector3I20F12 XXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, X, W); }
        public Vector3I20F12 XYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Y, X); }
        public Vector3I20F12 XYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Y, Y); }
        public Vector3I20F12 XYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Y, Z); }
        public Vector3I20F12 XYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Y, W); }
        public Vector3I20F12 XZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Z, X); }
        public Vector3I20F12 XZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Z, Y); }
        public Vector3I20F12 XZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Z, Z); }
        public Vector3I20F12 XZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, Z, W); }
        public Vector3I20F12 XWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, W, X); }
        public Vector3I20F12 XWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, W, Y); }
        public Vector3I20F12 XWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, W, Z); }
        public Vector3I20F12 XWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(X, W, W); }
        public Vector3I20F12 YXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, X, X); }
        public Vector3I20F12 YXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, X, Y); }
        public Vector3I20F12 YXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, X, Z); }
        public Vector3I20F12 YXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, X, W); }
        public Vector3I20F12 YYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Y, X); }
        public Vector3I20F12 YYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Y, Y); }
        public Vector3I20F12 YYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Y, Z); }
        public Vector3I20F12 YYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Y, W); }
        public Vector3I20F12 YZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Z, X); }
        public Vector3I20F12 YZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Z, Y); }
        public Vector3I20F12 YZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Z, Z); }
        public Vector3I20F12 YZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, Z, W); }
        public Vector3I20F12 YWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, W, X); }
        public Vector3I20F12 YWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, W, Y); }
        public Vector3I20F12 YWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, W, Z); }
        public Vector3I20F12 YWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Y, W, W); }
        public Vector3I20F12 ZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, X, X); }
        public Vector3I20F12 ZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, X, Y); }
        public Vector3I20F12 ZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, X, Z); }
        public Vector3I20F12 ZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, X, W); }
        public Vector3I20F12 ZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Y, X); }
        public Vector3I20F12 ZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Y, Y); }
        public Vector3I20F12 ZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Y, Z); }
        public Vector3I20F12 ZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Y, W); }
        public Vector3I20F12 ZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Z, X); }
        public Vector3I20F12 ZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Z, Y); }
        public Vector3I20F12 ZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Z, Z); }
        public Vector3I20F12 ZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, Z, W); }
        public Vector3I20F12 ZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, W, X); }
        public Vector3I20F12 ZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, W, Y); }
        public Vector3I20F12 ZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, W, Z); }
        public Vector3I20F12 ZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(Z, W, W); }
        public Vector3I20F12 WXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(W, X, X); }
        public Vector3I20F12 WXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(W, X, Y); }
        public Vector3I20F12 WXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(W, X, Z); }
        public Vector3I20F12 WXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(W, X, W); }
        public Vector3I20F12 WYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(W, Y, X); }
        public Vector3I20F12 WYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(W, Y, Y); }
        public Vector3I20F12 WYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(W, Y, Z); }
        public Vector3I20F12 WYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(W, Y, W); }
        public Vector3I20F12 WZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(W, Z, X); }
        public Vector3I20F12 WZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(W, Z, Y); }
        public Vector3I20F12 WZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(W, Z, Z); }
        public Vector3I20F12 WZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(W, Z, W); }
        public Vector3I20F12 WWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(W, W, X); }
        public Vector3I20F12 WWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(W, W, Y); }
        public Vector3I20F12 WWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(W, W, Z); }
        public Vector3I20F12 WWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector3I20F12(W, W, W); }
        public Vector4I20F12 XXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, X, X); }
        public Vector4I20F12 XXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, X, Y); }
        public Vector4I20F12 XXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, X, Z); }
        public Vector4I20F12 XXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, X, W); }
        public Vector4I20F12 XXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Y, X); }
        public Vector4I20F12 XXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Y, Y); }
        public Vector4I20F12 XXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Y, Z); }
        public Vector4I20F12 XXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Y, W); }
        public Vector4I20F12 XXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Z, X); }
        public Vector4I20F12 XXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Z, Y); }
        public Vector4I20F12 XXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Z, Z); }
        public Vector4I20F12 XXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, Z, W); }
        public Vector4I20F12 XXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, W, X); }
        public Vector4I20F12 XXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, W, Y); }
        public Vector4I20F12 XXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, W, Z); }
        public Vector4I20F12 XXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, X, W, W); }
        public Vector4I20F12 XYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, X, X); }
        public Vector4I20F12 XYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, X, Y); }
        public Vector4I20F12 XYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, X, Z); }
        public Vector4I20F12 XYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, X, W); }
        public Vector4I20F12 XYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Y, X); }
        public Vector4I20F12 XYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Y, Y); }
        public Vector4I20F12 XYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Y, Z); }
        public Vector4I20F12 XYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Y, W); }
        public Vector4I20F12 XYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Z, X); }
        public Vector4I20F12 XYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Z, Y); }
        public Vector4I20F12 XYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Z, Z); }
        public Vector4I20F12 XYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, Z, W); }
        public Vector4I20F12 XYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, W, X); }
        public Vector4I20F12 XYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, W, Y); }
        public Vector4I20F12 XYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, W, Z); }
        public Vector4I20F12 XYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Y, W, W); }
        public Vector4I20F12 XZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, X, X); }
        public Vector4I20F12 XZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, X, Y); }
        public Vector4I20F12 XZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, X, Z); }
        public Vector4I20F12 XZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, X, W); }
        public Vector4I20F12 XZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Y, X); }
        public Vector4I20F12 XZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Y, Y); }
        public Vector4I20F12 XZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Y, Z); }
        public Vector4I20F12 XZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Y, W); }
        public Vector4I20F12 XZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Z, X); }
        public Vector4I20F12 XZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Z, Y); }
        public Vector4I20F12 XZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Z, Z); }
        public Vector4I20F12 XZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, Z, W); }
        public Vector4I20F12 XZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, W, X); }
        public Vector4I20F12 XZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, W, Y); }
        public Vector4I20F12 XZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, W, Z); }
        public Vector4I20F12 XZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, Z, W, W); }
        public Vector4I20F12 XWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, W, X, X); }
        public Vector4I20F12 XWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, W, X, Y); }
        public Vector4I20F12 XWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, W, X, Z); }
        public Vector4I20F12 XWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, W, X, W); }
        public Vector4I20F12 XWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, W, Y, X); }
        public Vector4I20F12 XWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, W, Y, Y); }
        public Vector4I20F12 XWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, W, Y, Z); }
        public Vector4I20F12 XWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, W, Y, W); }
        public Vector4I20F12 XWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, W, Z, X); }
        public Vector4I20F12 XWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, W, Z, Y); }
        public Vector4I20F12 XWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, W, Z, Z); }
        public Vector4I20F12 XWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, W, Z, W); }
        public Vector4I20F12 XWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, W, W, X); }
        public Vector4I20F12 XWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, W, W, Y); }
        public Vector4I20F12 XWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, W, W, Z); }
        public Vector4I20F12 XWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(X, W, W, W); }
        public Vector4I20F12 YXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, X, X); }
        public Vector4I20F12 YXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, X, Y); }
        public Vector4I20F12 YXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, X, Z); }
        public Vector4I20F12 YXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, X, W); }
        public Vector4I20F12 YXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Y, X); }
        public Vector4I20F12 YXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Y, Y); }
        public Vector4I20F12 YXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Y, Z); }
        public Vector4I20F12 YXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Y, W); }
        public Vector4I20F12 YXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Z, X); }
        public Vector4I20F12 YXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Z, Y); }
        public Vector4I20F12 YXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Z, Z); }
        public Vector4I20F12 YXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, Z, W); }
        public Vector4I20F12 YXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, W, X); }
        public Vector4I20F12 YXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, W, Y); }
        public Vector4I20F12 YXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, W, Z); }
        public Vector4I20F12 YXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, X, W, W); }
        public Vector4I20F12 YYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, X, X); }
        public Vector4I20F12 YYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, X, Y); }
        public Vector4I20F12 YYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, X, Z); }
        public Vector4I20F12 YYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, X, W); }
        public Vector4I20F12 YYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Y, X); }
        public Vector4I20F12 YYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Y, Y); }
        public Vector4I20F12 YYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Y, Z); }
        public Vector4I20F12 YYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Y, W); }
        public Vector4I20F12 YYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Z, X); }
        public Vector4I20F12 YYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Z, Y); }
        public Vector4I20F12 YYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Z, Z); }
        public Vector4I20F12 YYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, Z, W); }
        public Vector4I20F12 YYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, W, X); }
        public Vector4I20F12 YYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, W, Y); }
        public Vector4I20F12 YYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, W, Z); }
        public Vector4I20F12 YYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Y, W, W); }
        public Vector4I20F12 YZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, X, X); }
        public Vector4I20F12 YZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, X, Y); }
        public Vector4I20F12 YZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, X, Z); }
        public Vector4I20F12 YZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, X, W); }
        public Vector4I20F12 YZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Y, X); }
        public Vector4I20F12 YZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Y, Y); }
        public Vector4I20F12 YZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Y, Z); }
        public Vector4I20F12 YZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Y, W); }
        public Vector4I20F12 YZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Z, X); }
        public Vector4I20F12 YZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Z, Y); }
        public Vector4I20F12 YZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Z, Z); }
        public Vector4I20F12 YZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, Z, W); }
        public Vector4I20F12 YZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, W, X); }
        public Vector4I20F12 YZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, W, Y); }
        public Vector4I20F12 YZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, W, Z); }
        public Vector4I20F12 YZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, Z, W, W); }
        public Vector4I20F12 YWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, W, X, X); }
        public Vector4I20F12 YWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, W, X, Y); }
        public Vector4I20F12 YWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, W, X, Z); }
        public Vector4I20F12 YWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, W, X, W); }
        public Vector4I20F12 YWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, W, Y, X); }
        public Vector4I20F12 YWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, W, Y, Y); }
        public Vector4I20F12 YWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, W, Y, Z); }
        public Vector4I20F12 YWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, W, Y, W); }
        public Vector4I20F12 YWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, W, Z, X); }
        public Vector4I20F12 YWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, W, Z, Y); }
        public Vector4I20F12 YWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, W, Z, Z); }
        public Vector4I20F12 YWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, W, Z, W); }
        public Vector4I20F12 YWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, W, W, X); }
        public Vector4I20F12 YWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, W, W, Y); }
        public Vector4I20F12 YWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, W, W, Z); }
        public Vector4I20F12 YWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Y, W, W, W); }
        public Vector4I20F12 ZXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, X, X); }
        public Vector4I20F12 ZXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, X, Y); }
        public Vector4I20F12 ZXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, X, Z); }
        public Vector4I20F12 ZXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, X, W); }
        public Vector4I20F12 ZXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Y, X); }
        public Vector4I20F12 ZXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Y, Y); }
        public Vector4I20F12 ZXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Y, Z); }
        public Vector4I20F12 ZXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Y, W); }
        public Vector4I20F12 ZXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Z, X); }
        public Vector4I20F12 ZXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Z, Y); }
        public Vector4I20F12 ZXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Z, Z); }
        public Vector4I20F12 ZXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, Z, W); }
        public Vector4I20F12 ZXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, W, X); }
        public Vector4I20F12 ZXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, W, Y); }
        public Vector4I20F12 ZXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, W, Z); }
        public Vector4I20F12 ZXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, X, W, W); }
        public Vector4I20F12 ZYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, X, X); }
        public Vector4I20F12 ZYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, X, Y); }
        public Vector4I20F12 ZYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, X, Z); }
        public Vector4I20F12 ZYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, X, W); }
        public Vector4I20F12 ZYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Y, X); }
        public Vector4I20F12 ZYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Y, Y); }
        public Vector4I20F12 ZYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Y, Z); }
        public Vector4I20F12 ZYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Y, W); }
        public Vector4I20F12 ZYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Z, X); }
        public Vector4I20F12 ZYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Z, Y); }
        public Vector4I20F12 ZYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Z, Z); }
        public Vector4I20F12 ZYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, Z, W); }
        public Vector4I20F12 ZYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, W, X); }
        public Vector4I20F12 ZYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, W, Y); }
        public Vector4I20F12 ZYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, W, Z); }
        public Vector4I20F12 ZYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Y, W, W); }
        public Vector4I20F12 ZZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, X, X); }
        public Vector4I20F12 ZZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, X, Y); }
        public Vector4I20F12 ZZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, X, Z); }
        public Vector4I20F12 ZZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, X, W); }
        public Vector4I20F12 ZZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Y, X); }
        public Vector4I20F12 ZZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Y, Y); }
        public Vector4I20F12 ZZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Y, Z); }
        public Vector4I20F12 ZZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Y, W); }
        public Vector4I20F12 ZZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Z, X); }
        public Vector4I20F12 ZZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Z, Y); }
        public Vector4I20F12 ZZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Z, Z); }
        public Vector4I20F12 ZZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, Z, W); }
        public Vector4I20F12 ZZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, W, X); }
        public Vector4I20F12 ZZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, W, Y); }
        public Vector4I20F12 ZZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, W, Z); }
        public Vector4I20F12 ZZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, Z, W, W); }
        public Vector4I20F12 ZWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, W, X, X); }
        public Vector4I20F12 ZWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, W, X, Y); }
        public Vector4I20F12 ZWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, W, X, Z); }
        public Vector4I20F12 ZWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, W, X, W); }
        public Vector4I20F12 ZWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, W, Y, X); }
        public Vector4I20F12 ZWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, W, Y, Y); }
        public Vector4I20F12 ZWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, W, Y, Z); }
        public Vector4I20F12 ZWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, W, Y, W); }
        public Vector4I20F12 ZWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, W, Z, X); }
        public Vector4I20F12 ZWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, W, Z, Y); }
        public Vector4I20F12 ZWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, W, Z, Z); }
        public Vector4I20F12 ZWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, W, Z, W); }
        public Vector4I20F12 ZWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, W, W, X); }
        public Vector4I20F12 ZWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, W, W, Y); }
        public Vector4I20F12 ZWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, W, W, Z); }
        public Vector4I20F12 ZWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(Z, W, W, W); }
        public Vector4I20F12 WXXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, X, X, X); }
        public Vector4I20F12 WXXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, X, X, Y); }
        public Vector4I20F12 WXXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, X, X, Z); }
        public Vector4I20F12 WXXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, X, X, W); }
        public Vector4I20F12 WXYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, X, Y, X); }
        public Vector4I20F12 WXYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, X, Y, Y); }
        public Vector4I20F12 WXYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, X, Y, Z); }
        public Vector4I20F12 WXYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, X, Y, W); }
        public Vector4I20F12 WXZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, X, Z, X); }
        public Vector4I20F12 WXZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, X, Z, Y); }
        public Vector4I20F12 WXZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, X, Z, Z); }
        public Vector4I20F12 WXZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, X, Z, W); }
        public Vector4I20F12 WXWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, X, W, X); }
        public Vector4I20F12 WXWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, X, W, Y); }
        public Vector4I20F12 WXWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, X, W, Z); }
        public Vector4I20F12 WXWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, X, W, W); }
        public Vector4I20F12 WYXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Y, X, X); }
        public Vector4I20F12 WYXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Y, X, Y); }
        public Vector4I20F12 WYXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Y, X, Z); }
        public Vector4I20F12 WYXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Y, X, W); }
        public Vector4I20F12 WYYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Y, Y, X); }
        public Vector4I20F12 WYYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Y, Y, Y); }
        public Vector4I20F12 WYYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Y, Y, Z); }
        public Vector4I20F12 WYYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Y, Y, W); }
        public Vector4I20F12 WYZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Y, Z, X); }
        public Vector4I20F12 WYZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Y, Z, Y); }
        public Vector4I20F12 WYZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Y, Z, Z); }
        public Vector4I20F12 WYZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Y, Z, W); }
        public Vector4I20F12 WYWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Y, W, X); }
        public Vector4I20F12 WYWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Y, W, Y); }
        public Vector4I20F12 WYWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Y, W, Z); }
        public Vector4I20F12 WYWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Y, W, W); }
        public Vector4I20F12 WZXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Z, X, X); }
        public Vector4I20F12 WZXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Z, X, Y); }
        public Vector4I20F12 WZXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Z, X, Z); }
        public Vector4I20F12 WZXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Z, X, W); }
        public Vector4I20F12 WZYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Z, Y, X); }
        public Vector4I20F12 WZYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Z, Y, Y); }
        public Vector4I20F12 WZYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Z, Y, Z); }
        public Vector4I20F12 WZYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Z, Y, W); }
        public Vector4I20F12 WZZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Z, Z, X); }
        public Vector4I20F12 WZZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Z, Z, Y); }
        public Vector4I20F12 WZZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Z, Z, Z); }
        public Vector4I20F12 WZZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Z, Z, W); }
        public Vector4I20F12 WZWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Z, W, X); }
        public Vector4I20F12 WZWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Z, W, Y); }
        public Vector4I20F12 WZWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Z, W, Z); }
        public Vector4I20F12 WZWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, Z, W, W); }
        public Vector4I20F12 WWXX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, W, X, X); }
        public Vector4I20F12 WWXY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, W, X, Y); }
        public Vector4I20F12 WWXZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, W, X, Z); }
        public Vector4I20F12 WWXW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, W, X, W); }
        public Vector4I20F12 WWYX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, W, Y, X); }
        public Vector4I20F12 WWYY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, W, Y, Y); }
        public Vector4I20F12 WWYZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, W, Y, Z); }
        public Vector4I20F12 WWYW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, W, Y, W); }
        public Vector4I20F12 WWZX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, W, Z, X); }
        public Vector4I20F12 WWZY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, W, Z, Y); }
        public Vector4I20F12 WWZZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, W, Z, Z); }
        public Vector4I20F12 WWZW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, W, Z, W); }
        public Vector4I20F12 WWWX { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, W, W, X); }
        public Vector4I20F12 WWWY { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, W, W, Y); }
        public Vector4I20F12 WWWZ { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, W, W, Z); }
        public Vector4I20F12 WWWW { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => new Vector4I20F12(W, W, W, W); }

    }

    partial struct I20F12 {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I20F12 SaturatingMul(Vector4I20F12 other) => other.SaturatingMul(this);
    }
}
