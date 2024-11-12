using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct Vector3I2F30
    : IEquatable<Vector3I2F30>
    , IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I2F30 X;
        public I2F30 Y;
        public I2F30 Z;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30(I2F30 x, I2F30 y, I2F30 z) {
            X = x;
            Y = y;
            Z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30(I2F30 value) : this(value, value, value) { }

        // Constants
        // ---------------------------------------

        public static Vector3I2F30 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I2F30(I2F30.Zero);
        }
        public static Vector3I2F30 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I2F30(I2F30.One);
        }
        public static Vector3I2F30 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I2F30(I2F30.One, I2F30.Zero, I2F30.Zero);
        }
        public static Vector3I2F30 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I2F30(I2F30.Zero, I2F30.One, I2F30.Zero);
        }
        public static Vector3I2F30 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I2F30(I2F30.Zero, I2F30.Zero, I2F30.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator +(Vector3I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator -(Vector3I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator *(Vector3I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator *(Vector3I2F30 a, I2F30 b) => new Vector3I2F30(
            a.X * b,
            a.Y * b,
            a.Z * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator *(I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a * b.X,
            a * b.Y,
            a * b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator /(Vector3I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator /(Vector3I2F30 a, I2F30 b) => new Vector3I2F30(
            a.X / b,
            a.Y / b,
            a.Z / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I2F30 operator /(I2F30 a, Vector3I2F30 b) => new Vector3I2F30(
            a / b.X,
            a / b.Y,
            a / b.Z);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I2F30 lhs, Vector3I2F30 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I2F30 lhs, Vector3I2F30 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I2F30 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector3I2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        // IEquatable<Vector3I2F30>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I2F30 other)
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
        public Vector3I2F30 Min(Vector3I2F30 other) => new Vector3I2F30(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 Max(Vector3I2F30 other) => new Vector3I2F30(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 Abs() => new Vector3I2F30(
            X.Abs(),
            Y.Abs(),
            Z.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal Vector3I2F30 Half() => new Vector3I2F30(X.Half(), Y.Half(), Z.Half());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal Vector3I2F30 Twice() => new Vector3I2F30(X.Twice(), Y.Twice(), Z.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 Clamp(I2F30 min, I2F30 max) {
            return new Vector3I2F30(X.Clamp(min, max), Y.Clamp(min, max), Z.Clamp(min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 Clamp(Vector3I2F30 min, Vector3I2F30 max) {
            return new Vector3I2F30(X.Clamp(min.X, max.X), Y.Clamp(min.Y, max.Y), Z.Clamp(min.Z, max.Z));
        }

#if AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3U2F30 UnsignedAbs() => new Vector3U2F30(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs());

#endif // AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CrossInternal(Vector3I2F30 other, out long x, out long y, out long z) {
            var ax = (long)X.Bits;
            var ay = (long)Y.Bits;
            var az = (long)Z.Bits;
            var bx = (long)other.X.Bits;
            var by = (long)other.Y.Bits;
            var bz = (long)other.Z.Bits;

            x = (ay * bz) - (az * by);
            y = (az * bx) - (ax * bz);
            z = (ax * by) - (ay * bx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 Cross(Vector3I2F30 other) {
            const long k = 1L << 30;
            CrossInternal(other, out var x, out var y, out var z);
            return new Vector3I2F30(
                I2F30.FromBits((int)(x / k)),
                I2F30.FromBits((int)(y / k)),
                I2F30.FromBits((int)(z / k)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 SaturatingCross(Vector3I2F30 other) {
            const long k = 1L << 30;
            CrossInternal(other, out var x, out var y, out var z);
            x /= k;
            if (x > int.MaxValue) {
                x = int.MaxValue;
            } else if (x < int.MinValue) {
                x = int.MinValue;
            }
            y /= k;
            if (y > int.MaxValue) {
                y = int.MaxValue;
            } else if (y < int.MinValue) {
                y = int.MinValue;
            }
            z /= k;
            if (z > int.MaxValue) {
                z = int.MaxValue;
            } else if (z < int.MinValue) {
                z = int.MinValue;
            }
            return new Vector3I2F30(
                I2F30.FromBits((int)x),
                I2F30.FromBits((int)y),
                I2F30.FromBits((int)z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector3I2F30 other) {
            var x = ((long)X.Bits) * other.X.Bits;
            var y = ((long)Y.Bits) * other.Y.Bits;
            var z = ((long)Z.Bits) * other.Z.Bits;

            // オーバーフローを避けるため､ 事前に除算する｡
            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算に合わせて常に 4 で除算する｡
            return
                (x / 4) +
                (y / 4) +
                (z / 4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 Dot(Vector3I2F30 other) {
            const long k = 1L << 28;
            return I2F30.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 SaturatingDot(Vector3I2F30 other) {
            const long k = 1L << 28;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I2F30.MaxValue;
            } else if (bits < int.MinValue) {
                return I2F30.MinValue;
            } else {
                return I2F30.FromBits((int)bits);
            }
        }

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F60 LengthSquared() {
            var a1 = Mathi.UnsignedAbs(X.Bits);
            var a2 = Mathi.UnsignedAbs(Y.Bits);
            var a3 = Mathi.UnsignedAbs(Z.Bits);
            var s1 = (ulong)a1 * a1;
            var s2 = (ulong)a2 * a2;
            var s3 = (ulong)a3 * a3;
            return U4F60.FromBits(s1 + s2 + s3);
        }

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 Length() {
            return U2F30.FromBits((uint)Mathi.Sqrt(LengthSquared().Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30? Normalize() {

            // 各要素の内部表現型を取り出し、
            // その絶対値を得る。

            var x0 = X.Bits;
            var x1 = Y.Bits;
            var x2 = Z.Bits;
            var b0 = x0 < 0;
            var b1 = x1 < 0;
            var b2 = x2 < 0;
            var a0 = unchecked((uint)(b0 ? Overflowing.WrappingNeg(x0) : x0));
            var a1 = unchecked((uint)(b1 ? Overflowing.WrappingNeg(x1) : x1));
            var a2 = unchecked((uint)(b2 ? Overflowing.WrappingNeg(x2) : x2));

            // 各要素の最大値が 0 の場合は null を返す。

            var max = Math.Max(Math.Max(a0, a1), a2);
            if (max == 0) {
                return null;
            }

            // ベクトルの大きさが小さい時の誤差を小さくするため、
            // 最大の要素が表現型の範囲に収まるように拡大する。
            // 最大の要素以外にも同じ値を乗算する。

            ulong m = uint.MaxValue / max;
            var l0 = m * a0;
            var l1 = m * a1;
            var l2 = m * a2;
            var sum =
                (l0 * l0 / 4) +
                (l1 * l1 / 4) +
                (l2 * l2 / 4);
            var ll = Mathi.Sqrt(sum);

            // 小数部の桁をあわせる。

            const ulong k = 1UL << 29;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);

            // 最後に符号をあわせて返す。

            return new Vector3I2F30(
                I2F30.FromBits(b0 ? -y0 : y0),
                I2F30.FromBits(b1 ? -y1 : y1),
                I2F30.FromBits(b2 ? -y2 : y2));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XX() => new Vector2I2F30(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XY() => new Vector2I2F30(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XZ() => new Vector2I2F30(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YX() => new Vector2I2F30(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YY() => new Vector2I2F30(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YZ() => new Vector2I2F30(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 ZX() => new Vector2I2F30(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 ZY() => new Vector2I2F30(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 ZZ() => new Vector2I2F30(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXX() => new Vector3I2F30(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXY() => new Vector3I2F30(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXZ() => new Vector3I2F30(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYX() => new Vector3I2F30(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYY() => new Vector3I2F30(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYZ() => new Vector3I2F30(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XZX() => new Vector3I2F30(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XZY() => new Vector3I2F30(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XZZ() => new Vector3I2F30(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXX() => new Vector3I2F30(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXY() => new Vector3I2F30(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXZ() => new Vector3I2F30(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYX() => new Vector3I2F30(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYY() => new Vector3I2F30(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYZ() => new Vector3I2F30(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YZX() => new Vector3I2F30(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YZY() => new Vector3I2F30(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YZZ() => new Vector3I2F30(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZXX() => new Vector3I2F30(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZXY() => new Vector3I2F30(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZXZ() => new Vector3I2F30(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZYX() => new Vector3I2F30(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZYY() => new Vector3I2F30(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZYZ() => new Vector3I2F30(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZZX() => new Vector3I2F30(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZZY() => new Vector3I2F30(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZZZ() => new Vector3I2F30(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXX() => new Vector4I2F30(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXY() => new Vector4I2F30(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXZ() => new Vector4I2F30(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYX() => new Vector4I2F30(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYY() => new Vector4I2F30(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYZ() => new Vector4I2F30(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXZX() => new Vector4I2F30(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXZY() => new Vector4I2F30(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXZZ() => new Vector4I2F30(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXX() => new Vector4I2F30(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXY() => new Vector4I2F30(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXZ() => new Vector4I2F30(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYX() => new Vector4I2F30(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYY() => new Vector4I2F30(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYZ() => new Vector4I2F30(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZX() => new Vector4I2F30(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZY() => new Vector4I2F30(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZZ() => new Vector4I2F30(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZXX() => new Vector4I2F30(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZXY() => new Vector4I2F30(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZXZ() => new Vector4I2F30(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZYX() => new Vector4I2F30(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZYY() => new Vector4I2F30(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZYZ() => new Vector4I2F30(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZZX() => new Vector4I2F30(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZZY() => new Vector4I2F30(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZZZ() => new Vector4I2F30(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXX() => new Vector4I2F30(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXY() => new Vector4I2F30(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXZ() => new Vector4I2F30(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYX() => new Vector4I2F30(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYY() => new Vector4I2F30(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYZ() => new Vector4I2F30(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXZX() => new Vector4I2F30(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXZY() => new Vector4I2F30(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXZZ() => new Vector4I2F30(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXX() => new Vector4I2F30(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXY() => new Vector4I2F30(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXZ() => new Vector4I2F30(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYX() => new Vector4I2F30(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYY() => new Vector4I2F30(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYZ() => new Vector4I2F30(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYZX() => new Vector4I2F30(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYZY() => new Vector4I2F30(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYZZ() => new Vector4I2F30(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZXX() => new Vector4I2F30(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZXY() => new Vector4I2F30(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZXZ() => new Vector4I2F30(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZYX() => new Vector4I2F30(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZYY() => new Vector4I2F30(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZYZ() => new Vector4I2F30(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZZX() => new Vector4I2F30(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZZY() => new Vector4I2F30(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZZZ() => new Vector4I2F30(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXXX() => new Vector4I2F30(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXXY() => new Vector4I2F30(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXXZ() => new Vector4I2F30(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXYX() => new Vector4I2F30(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXYY() => new Vector4I2F30(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXYZ() => new Vector4I2F30(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXZX() => new Vector4I2F30(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXZY() => new Vector4I2F30(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXZZ() => new Vector4I2F30(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYXX() => new Vector4I2F30(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYXY() => new Vector4I2F30(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYXZ() => new Vector4I2F30(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYYX() => new Vector4I2F30(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYYY() => new Vector4I2F30(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYYZ() => new Vector4I2F30(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYZX() => new Vector4I2F30(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYZY() => new Vector4I2F30(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYZZ() => new Vector4I2F30(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZXX() => new Vector4I2F30(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZXY() => new Vector4I2F30(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZXZ() => new Vector4I2F30(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZYX() => new Vector4I2F30(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZYY() => new Vector4I2F30(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZYZ() => new Vector4I2F30(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZZX() => new Vector4I2F30(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZZY() => new Vector4I2F30(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZZZ() => new Vector4I2F30(Z, Z, Z, Z);

    }
} // // namespace AgatePris.Intar
