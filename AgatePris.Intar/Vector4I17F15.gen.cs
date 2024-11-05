using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct Vector4I17F15
    : IEquatable<Vector4I17F15>
    , IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I17F15 X;
        public I17F15 Y;
        public I17F15 Z;
        public I17F15 W;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(I17F15 x, I17F15 y, I17F15 z, I17F15 w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(I17F15 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(I17F15 x, I17F15 y, Vector2I17F15 zw) : this(x, y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(I17F15 x, Vector3I17F15 yzw) : this(x, yzw.X, yzw.Y, yzw.Z) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(Vector2I17F15 xy, Vector2I17F15 zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(Vector4I17F15 xyzw) : this(xyzw.X, xyzw.Y, xyzw.Z, xyzw.W) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(I17F15 x, Vector2I17F15 yz, I17F15 w) : this(x, yz.X, yz.Y, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(Vector3I17F15 xyz, I17F15 w) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(Vector2I17F15 xy, I17F15 z, I17F15 w) : this(xy.X, xy.Y, z, w) { }

        // Constants
        // ---------------------------------------

        public static Vector4I17F15 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I17F15(I17F15.Zero);
        }
        public static Vector4I17F15 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I17F15(I17F15.One);
        }
        public static Vector4I17F15 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I17F15(I17F15.One, I17F15.Zero, I17F15.Zero, I17F15.Zero);
        }
        public static Vector4I17F15 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I17F15(I17F15.Zero, I17F15.One, I17F15.Zero, I17F15.Zero);
        }
        public static Vector4I17F15 UnitZ {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I17F15(I17F15.Zero, I17F15.Zero, I17F15.One, I17F15.Zero);
        }
        public static Vector4I17F15 UnitW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector4I17F15(I17F15.Zero, I17F15.Zero, I17F15.Zero, I17F15.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator +(Vector4I17F15 a, Vector4I17F15 b) => new Vector4I17F15(
            a.X + b.X,
            a.Y + b.Y,
            a.Z + b.Z,
            a.W + b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator -(Vector4I17F15 a, Vector4I17F15 b) => new Vector4I17F15(
            a.X - b.X,
            a.Y - b.Y,
            a.Z - b.Z,
            a.W - b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator *(Vector4I17F15 a, Vector4I17F15 b) => new Vector4I17F15(
            a.X * b.X,
            a.Y * b.Y,
            a.Z * b.Z,
            a.W * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator *(Vector4I17F15 a, I17F15 b) => new Vector4I17F15(
            a.X * b,
            a.Y * b,
            a.Z * b,
            a.W * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator *(I17F15 a, Vector4I17F15 b) => new Vector4I17F15(
            a * b.X,
            a * b.Y,
            a * b.Z,
            a * b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator /(Vector4I17F15 a, Vector4I17F15 b) => new Vector4I17F15(
            a.X / b.X,
            a.Y / b.Y,
            a.Z / b.Z,
            a.W / b.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator /(Vector4I17F15 a, I17F15 b) => new Vector4I17F15(
            a.X / b,
            a.Y / b,
            a.Z / b,
            a.W / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator /(I17F15 a, Vector4I17F15 b) => new Vector4I17F15(
            a / b.X,
            a / b.Y,
            a / b.Z,
            a / b.W);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I17F15 lhs, Vector4I17F15 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I17F15 lhs, Vector4I17F15 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I17F15 this[int index] {
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

        public override bool Equals(object obj) => obj is Vector4I17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        // IEquatable<Vector4I17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I17F15 other)
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
        public Vector4I17F15 Min(Vector4I17F15 other) => new Vector4I17F15(
            X.Min(other.X),
            Y.Min(other.Y),
            Z.Min(other.Z),
            W.Min(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15 Max(Vector4I17F15 other) => new Vector4I17F15(
            X.Max(other.X),
            Y.Max(other.Y),
            Z.Max(other.Z),
            W.Max(other.W));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15 Abs() => new Vector4I17F15(
            X.Abs(),
            Y.Abs(),
            Z.Abs(),
            W.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal Vector4I17F15 Half() => new Vector4I17F15(X.Half(), Y.Half(), Z.Half(), W.Half());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal Vector4I17F15 Twice() => new Vector4I17F15(X.Twice(), Y.Twice(), Z.Twice(), W.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15 Clamp(I17F15 min, I17F15 max) {
            return new Vector4I17F15(X.Clamp(min, max), Y.Clamp(min, max), Z.Clamp(min, max), W.Clamp(min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15 Clamp(Vector4I17F15 min, Vector4I17F15 max) {
            return new Vector4I17F15(X.Clamp(min.X, max.X), Y.Clamp(min.Y, max.Y), Z.Clamp(min.Z, max.Z), W.Clamp(min.W, max.W));
        }

#if AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4U17F15 UnsignedAbs() => new Vector4U17F15(
            X.UnsignedAbs(),
            Y.UnsignedAbs(),
            Z.UnsignedAbs(),
            W.UnsignedAbs());

#endif // AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I17F15 other) {
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
        public I17F15 Dot(Vector4I17F15 other) {
            const long k = 1L << 13;
            return I17F15.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15 SaturatingDot(Vector4I17F15 other) {
            const long k = 1L << 13;
            var bits = DotInternal(other) / k;
            if (bits > int.MaxValue) {
                return I17F15.MaxValue;
            } else if (bits < int.MinValue) {
                return I17F15.MinValue;
            } else {
                return I17F15.FromBits((int)bits);
            }
        }

        // ベクトルの長さは符号つき、
        // かつ次元が 3 以下の場合のみ定義される。

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15? Normalize() {

            // 各要素の内部表現型を取り出し、
            // その絶対値を得る。

            var x0 = X.Bits;
            var x1 = Y.Bits;
            var x2 = Z.Bits;
            var x3 = W.Bits;
            var b0 = x0 < 0;
            var b1 = x1 < 0;
            var b2 = x2 < 0;
            var b3 = x3 < 0;
            var a0 = unchecked((uint)(b0 ? Overflowing.WrappingNeg(x0) : x0));
            var a1 = unchecked((uint)(b1 ? Overflowing.WrappingNeg(x1) : x1));
            var a2 = unchecked((uint)(b2 ? Overflowing.WrappingNeg(x2) : x2));
            var a3 = unchecked((uint)(b3 ? Overflowing.WrappingNeg(x3) : x3));

            // 各要素の最大値が 0 の場合は null を返す。

            var max = Math.Max(Math.Max(a0, a1), Math.Max(a2, a3));
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
            var l3 = m * a3;
            var sum =
                (l0 * l0 / 4) +
                (l1 * l1 / 4) +
                (l2 * l2 / 4) +
                (l3 * l3 / 4);
            var ll = Mathi.Sqrt(sum);

            // 小数部の桁をあわせる。

            const ulong k = 1UL << 14;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);
            var y3 = (int)(l3 * k / ll);

            // 最後に符号をあわせて返す。

            return new Vector4I17F15(
                I17F15.FromBits(b0 ? -y0 : y0),
                I17F15.FromBits(b1 ? -y1 : y1),
                I17F15.FromBits(b2 ? -y2 : y2),
                I17F15.FromBits(b3 ? -y3 : y3));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 SinP4() => new Vector4I2F30(
            X.SinP4(),
            Y.SinP4(),
            Z.SinP4(),
            W.SinP4());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 SinP5() => new Vector4I2F30(
            X.SinP5(),
            Y.SinP5(),
            Z.SinP5(),
            W.SinP5());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 CosP4() => new Vector4I2F30(
            X.CosP4(),
            Y.CosP4(),
            Z.CosP4(),
            W.CosP4());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 CosP5() => new Vector4I2F30(
            X.CosP5(),
            Y.CosP5(),
            Z.CosP5(),
            W.CosP5());

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XX() => new Vector2I17F15(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XY() => new Vector2I17F15(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XZ() => new Vector2I17F15(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XW() => new Vector2I17F15(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YX() => new Vector2I17F15(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YY() => new Vector2I17F15(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YZ() => new Vector2I17F15(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YW() => new Vector2I17F15(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 ZX() => new Vector2I17F15(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 ZY() => new Vector2I17F15(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 ZZ() => new Vector2I17F15(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 ZW() => new Vector2I17F15(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 WX() => new Vector2I17F15(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 WY() => new Vector2I17F15(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 WZ() => new Vector2I17F15(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 WW() => new Vector2I17F15(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXX() => new Vector3I17F15(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXY() => new Vector3I17F15(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXZ() => new Vector3I17F15(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXW() => new Vector3I17F15(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYX() => new Vector3I17F15(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYY() => new Vector3I17F15(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYZ() => new Vector3I17F15(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYW() => new Vector3I17F15(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XZX() => new Vector3I17F15(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XZY() => new Vector3I17F15(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XZZ() => new Vector3I17F15(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XZW() => new Vector3I17F15(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XWX() => new Vector3I17F15(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XWY() => new Vector3I17F15(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XWZ() => new Vector3I17F15(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XWW() => new Vector3I17F15(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXX() => new Vector3I17F15(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXY() => new Vector3I17F15(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXZ() => new Vector3I17F15(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXW() => new Vector3I17F15(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYX() => new Vector3I17F15(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYY() => new Vector3I17F15(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYZ() => new Vector3I17F15(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYW() => new Vector3I17F15(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YZX() => new Vector3I17F15(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YZY() => new Vector3I17F15(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YZZ() => new Vector3I17F15(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YZW() => new Vector3I17F15(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YWX() => new Vector3I17F15(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YWY() => new Vector3I17F15(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YWZ() => new Vector3I17F15(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YWW() => new Vector3I17F15(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZXX() => new Vector3I17F15(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZXY() => new Vector3I17F15(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZXZ() => new Vector3I17F15(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZXW() => new Vector3I17F15(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZYX() => new Vector3I17F15(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZYY() => new Vector3I17F15(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZYZ() => new Vector3I17F15(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZYW() => new Vector3I17F15(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZZX() => new Vector3I17F15(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZZY() => new Vector3I17F15(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZZZ() => new Vector3I17F15(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZZW() => new Vector3I17F15(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZWX() => new Vector3I17F15(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZWY() => new Vector3I17F15(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZWZ() => new Vector3I17F15(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZWW() => new Vector3I17F15(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WXX() => new Vector3I17F15(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WXY() => new Vector3I17F15(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WXZ() => new Vector3I17F15(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WXW() => new Vector3I17F15(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WYX() => new Vector3I17F15(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WYY() => new Vector3I17F15(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WYZ() => new Vector3I17F15(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WYW() => new Vector3I17F15(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WZX() => new Vector3I17F15(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WZY() => new Vector3I17F15(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WZZ() => new Vector3I17F15(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WZW() => new Vector3I17F15(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WWX() => new Vector3I17F15(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WWY() => new Vector3I17F15(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WWZ() => new Vector3I17F15(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WWW() => new Vector3I17F15(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXX() => new Vector4I17F15(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXY() => new Vector4I17F15(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXZ() => new Vector4I17F15(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXW() => new Vector4I17F15(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYX() => new Vector4I17F15(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYY() => new Vector4I17F15(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYZ() => new Vector4I17F15(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYW() => new Vector4I17F15(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXZX() => new Vector4I17F15(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXZY() => new Vector4I17F15(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXZZ() => new Vector4I17F15(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXZW() => new Vector4I17F15(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXWX() => new Vector4I17F15(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXWY() => new Vector4I17F15(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXWZ() => new Vector4I17F15(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXWW() => new Vector4I17F15(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXX() => new Vector4I17F15(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXY() => new Vector4I17F15(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXZ() => new Vector4I17F15(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXW() => new Vector4I17F15(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYX() => new Vector4I17F15(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYY() => new Vector4I17F15(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYZ() => new Vector4I17F15(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYW() => new Vector4I17F15(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZX() => new Vector4I17F15(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZY() => new Vector4I17F15(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZZ() => new Vector4I17F15(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZW() => new Vector4I17F15(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYWX() => new Vector4I17F15(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYWY() => new Vector4I17F15(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYWZ() => new Vector4I17F15(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYWW() => new Vector4I17F15(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZXX() => new Vector4I17F15(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZXY() => new Vector4I17F15(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZXZ() => new Vector4I17F15(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZXW() => new Vector4I17F15(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZYX() => new Vector4I17F15(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZYY() => new Vector4I17F15(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZYZ() => new Vector4I17F15(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZYW() => new Vector4I17F15(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZZX() => new Vector4I17F15(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZZY() => new Vector4I17F15(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZZZ() => new Vector4I17F15(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZZW() => new Vector4I17F15(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZWX() => new Vector4I17F15(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZWY() => new Vector4I17F15(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZWZ() => new Vector4I17F15(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZWW() => new Vector4I17F15(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWXX() => new Vector4I17F15(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWXY() => new Vector4I17F15(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWXZ() => new Vector4I17F15(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWXW() => new Vector4I17F15(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWYX() => new Vector4I17F15(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWYY() => new Vector4I17F15(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWYZ() => new Vector4I17F15(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWYW() => new Vector4I17F15(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWZX() => new Vector4I17F15(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWZY() => new Vector4I17F15(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWZZ() => new Vector4I17F15(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWZW() => new Vector4I17F15(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWWX() => new Vector4I17F15(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWWY() => new Vector4I17F15(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWWZ() => new Vector4I17F15(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWWW() => new Vector4I17F15(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXX() => new Vector4I17F15(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXY() => new Vector4I17F15(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXZ() => new Vector4I17F15(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXW() => new Vector4I17F15(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYX() => new Vector4I17F15(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYY() => new Vector4I17F15(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYZ() => new Vector4I17F15(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYW() => new Vector4I17F15(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXZX() => new Vector4I17F15(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXZY() => new Vector4I17F15(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXZZ() => new Vector4I17F15(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXZW() => new Vector4I17F15(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXWX() => new Vector4I17F15(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXWY() => new Vector4I17F15(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXWZ() => new Vector4I17F15(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXWW() => new Vector4I17F15(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXX() => new Vector4I17F15(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXY() => new Vector4I17F15(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXZ() => new Vector4I17F15(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXW() => new Vector4I17F15(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYX() => new Vector4I17F15(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYY() => new Vector4I17F15(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYZ() => new Vector4I17F15(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYW() => new Vector4I17F15(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYZX() => new Vector4I17F15(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYZY() => new Vector4I17F15(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYZZ() => new Vector4I17F15(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYZW() => new Vector4I17F15(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYWX() => new Vector4I17F15(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYWY() => new Vector4I17F15(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYWZ() => new Vector4I17F15(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYWW() => new Vector4I17F15(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZXX() => new Vector4I17F15(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZXY() => new Vector4I17F15(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZXZ() => new Vector4I17F15(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZXW() => new Vector4I17F15(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZYX() => new Vector4I17F15(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZYY() => new Vector4I17F15(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZYZ() => new Vector4I17F15(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZYW() => new Vector4I17F15(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZZX() => new Vector4I17F15(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZZY() => new Vector4I17F15(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZZZ() => new Vector4I17F15(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZZW() => new Vector4I17F15(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZWX() => new Vector4I17F15(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZWY() => new Vector4I17F15(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZWZ() => new Vector4I17F15(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZWW() => new Vector4I17F15(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWXX() => new Vector4I17F15(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWXY() => new Vector4I17F15(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWXZ() => new Vector4I17F15(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWXW() => new Vector4I17F15(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWYX() => new Vector4I17F15(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWYY() => new Vector4I17F15(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWYZ() => new Vector4I17F15(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWYW() => new Vector4I17F15(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWZX() => new Vector4I17F15(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWZY() => new Vector4I17F15(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWZZ() => new Vector4I17F15(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWZW() => new Vector4I17F15(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWWX() => new Vector4I17F15(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWWY() => new Vector4I17F15(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWWZ() => new Vector4I17F15(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWWW() => new Vector4I17F15(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXXX() => new Vector4I17F15(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXXY() => new Vector4I17F15(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXXZ() => new Vector4I17F15(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXXW() => new Vector4I17F15(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXYX() => new Vector4I17F15(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXYY() => new Vector4I17F15(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXYZ() => new Vector4I17F15(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXYW() => new Vector4I17F15(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXZX() => new Vector4I17F15(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXZY() => new Vector4I17F15(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXZZ() => new Vector4I17F15(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXZW() => new Vector4I17F15(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXWX() => new Vector4I17F15(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXWY() => new Vector4I17F15(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXWZ() => new Vector4I17F15(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXWW() => new Vector4I17F15(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYXX() => new Vector4I17F15(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYXY() => new Vector4I17F15(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYXZ() => new Vector4I17F15(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYXW() => new Vector4I17F15(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYYX() => new Vector4I17F15(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYYY() => new Vector4I17F15(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYYZ() => new Vector4I17F15(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYYW() => new Vector4I17F15(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYZX() => new Vector4I17F15(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYZY() => new Vector4I17F15(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYZZ() => new Vector4I17F15(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYZW() => new Vector4I17F15(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYWX() => new Vector4I17F15(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYWY() => new Vector4I17F15(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYWZ() => new Vector4I17F15(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYWW() => new Vector4I17F15(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZXX() => new Vector4I17F15(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZXY() => new Vector4I17F15(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZXZ() => new Vector4I17F15(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZXW() => new Vector4I17F15(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZYX() => new Vector4I17F15(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZYY() => new Vector4I17F15(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZYZ() => new Vector4I17F15(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZYW() => new Vector4I17F15(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZZX() => new Vector4I17F15(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZZY() => new Vector4I17F15(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZZZ() => new Vector4I17F15(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZZW() => new Vector4I17F15(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZWX() => new Vector4I17F15(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZWY() => new Vector4I17F15(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZWZ() => new Vector4I17F15(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZWW() => new Vector4I17F15(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWXX() => new Vector4I17F15(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWXY() => new Vector4I17F15(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWXZ() => new Vector4I17F15(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWXW() => new Vector4I17F15(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWYX() => new Vector4I17F15(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWYY() => new Vector4I17F15(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWYZ() => new Vector4I17F15(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWYW() => new Vector4I17F15(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWZX() => new Vector4I17F15(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWZY() => new Vector4I17F15(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWZZ() => new Vector4I17F15(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWZW() => new Vector4I17F15(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWWX() => new Vector4I17F15(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWWY() => new Vector4I17F15(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWWZ() => new Vector4I17F15(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWWW() => new Vector4I17F15(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXXX() => new Vector4I17F15(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXXY() => new Vector4I17F15(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXXZ() => new Vector4I17F15(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXXW() => new Vector4I17F15(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXYX() => new Vector4I17F15(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXYY() => new Vector4I17F15(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXYZ() => new Vector4I17F15(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXYW() => new Vector4I17F15(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXZX() => new Vector4I17F15(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXZY() => new Vector4I17F15(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXZZ() => new Vector4I17F15(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXZW() => new Vector4I17F15(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXWX() => new Vector4I17F15(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXWY() => new Vector4I17F15(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXWZ() => new Vector4I17F15(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXWW() => new Vector4I17F15(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYXX() => new Vector4I17F15(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYXY() => new Vector4I17F15(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYXZ() => new Vector4I17F15(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYXW() => new Vector4I17F15(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYYX() => new Vector4I17F15(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYYY() => new Vector4I17F15(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYYZ() => new Vector4I17F15(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYYW() => new Vector4I17F15(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYZX() => new Vector4I17F15(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYZY() => new Vector4I17F15(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYZZ() => new Vector4I17F15(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYZW() => new Vector4I17F15(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYWX() => new Vector4I17F15(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYWY() => new Vector4I17F15(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYWZ() => new Vector4I17F15(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYWW() => new Vector4I17F15(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZXX() => new Vector4I17F15(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZXY() => new Vector4I17F15(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZXZ() => new Vector4I17F15(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZXW() => new Vector4I17F15(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZYX() => new Vector4I17F15(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZYY() => new Vector4I17F15(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZYZ() => new Vector4I17F15(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZYW() => new Vector4I17F15(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZZX() => new Vector4I17F15(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZZY() => new Vector4I17F15(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZZZ() => new Vector4I17F15(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZZW() => new Vector4I17F15(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZWX() => new Vector4I17F15(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZWY() => new Vector4I17F15(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZWZ() => new Vector4I17F15(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZWW() => new Vector4I17F15(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWXX() => new Vector4I17F15(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWXY() => new Vector4I17F15(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWXZ() => new Vector4I17F15(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWXW() => new Vector4I17F15(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWYX() => new Vector4I17F15(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWYY() => new Vector4I17F15(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWYZ() => new Vector4I17F15(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWYW() => new Vector4I17F15(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWZX() => new Vector4I17F15(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWZY() => new Vector4I17F15(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWZZ() => new Vector4I17F15(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWZW() => new Vector4I17F15(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWWX() => new Vector4I17F15(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWWY() => new Vector4I17F15(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWWZ() => new Vector4I17F15(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWWW() => new Vector4I17F15(W, W, W, W);

    }
} // // namespace AgatePris.Intar
