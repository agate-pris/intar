using AgatePris.Intar.Extensions;
using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct Vector2I17F15
    : IEquatable<Vector2I17F15>
    , IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I17F15 X;
        public I17F15 Y;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15(I17F15 x, I17F15 y) {
            X = x;
            Y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15(I17F15 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15(Vector2I17F15 xy) : this(xy.X, xy.Y) { }

        // Constants
        // ---------------------------------------

        public static Vector2I17F15 Zero {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I17F15(I17F15.Zero);
        }
        public static Vector2I17F15 One {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I17F15(I17F15.One);
        }
        public static Vector2I17F15 UnitX {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I17F15(I17F15.One, I17F15.Zero);
        }
        public static Vector2I17F15 UnitY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector2I17F15(I17F15.Zero, I17F15.One);
        }

        // Arithmetic Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator +(Vector2I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a.X + b.X,
            a.Y + b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator -(Vector2I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a.X - b.X,
            a.Y - b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator *(Vector2I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a.X * b.X,
            a.Y * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator *(Vector2I17F15 a, I17F15 b) => new Vector2I17F15(
            a.X * b,
            a.Y * b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator *(I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a * b.X,
            a * b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator /(Vector2I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a.X / b.X,
            a.Y / b.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator /(Vector2I17F15 a, I17F15 b) => new Vector2I17F15(
            a.X / b,
            a.Y / b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator /(I17F15 a, Vector2I17F15 b) => new Vector2I17F15(
            a / b.X,
            a / b.Y);

        // Comparison Operators
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2I17F15 lhs, Vector2I17F15 rhs) => lhs.Equals(rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I17F15 lhs, Vector2I17F15 rhs) => !(lhs == rhs);

        // Indexer
        // ---------------------------------------

        public I17F15 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                switch (index) {
                    case 0: return X;
                    case 1: return Y;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                switch (index) {
                    case 0: X = value; break;
                    case 1: Y = value; break;
                    default: throw new ArgumentOutOfRangeException($"index: {index}");
                }
            }
        }

        // Object
        // ---------------------------------------

        public override bool Equals(object obj) => obj is Vector2I17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(X, Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        // IEquatable<Vector2I17F15>
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2I17F15 other)
            => other.X == X
            && other.Y == Y;

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            var x = X.ToString(format, formatProvider);
            var y = Y.ToString(format, formatProvider);
            return $"<{x}, {y}>";
        }

        // Methods
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 Min(Vector2I17F15 other) => new Vector2I17F15(
            X.Min(other.X),
            Y.Min(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 Max(Vector2I17F15 other) => new Vector2I17F15(
            X.Max(other.X),
            Y.Max(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 Abs() => new Vector2I17F15(
            X.Abs(),
            Y.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal Vector2I17F15 Half() => new Vector2I17F15(X.Half(), Y.Half());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] internal Vector2I17F15 Twice() => new Vector2I17F15(X.Twice(), Y.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 Clamp(I17F15 min, I17F15 max) {
            return new Vector2I17F15(X.Clamp(min, max), Y.Clamp(min, max));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 Clamp(Vector2I17F15 min, Vector2I17F15 max) {
            return new Vector2I17F15(X.Clamp(min.X, max.X), Y.Clamp(min.Y, max.Y));
        }

#if AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2U17F15 UnsignedAbs() => new Vector2U17F15(
            X.UnsignedAbs(),
            Y.UnsignedAbs());

#endif // AGATE_PRIS_INTAR_ENABLE_UNSIGNED_VECTOR

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 SaturatingAdd(Vector2I17F15 other) => new Vector2I17F15(
            X.SaturatingAdd(other.X),
            Y.SaturatingAdd(other.Y));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 SaturatingMul(I17F15 other) => new Vector2I17F15(
            X.SaturatingMul(other),
            Y.SaturatingMul(other));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector2I17F15 other) {
            var x = ((long)X.Bits) * other.X.Bits;
            var y = ((long)Y.Bits) * other.Y.Bits;

            // オーバーフローを避けるため､ 事前に除算する｡
            // 2 次元から 4 次元までのすべての次元で同じ結果を得るため､
            // 精度を犠牲にしても 4 次元の計算に合わせて常に 4 で除算する｡
            return
                (x / 4) +
                (y / 4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15 Dot(Vector2I17F15 other) {
            const long k = 1L << 13;
            return I17F15.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I17F15 SaturatingDot(Vector2I17F15 other) {
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

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 LengthSquared() {
            var a1 = Overflowing.UnsignedAbs(X.Bits);
            var a2 = Overflowing.UnsignedAbs(Y.Bits);
            var s1 = (ulong)a1 * a1;
            var s2 = (ulong)a2 * a2;
            return U34F30.FromBits(s1 + s2);
        }

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 Length() {
            return U17F15.FromBits((uint)Mathi.Sqrt(LengthSquared().Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15? Normalize() {

            // 各要素の内部表現型を取り出し、
            // その絶対値を得る。

            var x0 = X.Bits;
            var x1 = Y.Bits;
            var b0 = x0 < 0;
            var b1 = x1 < 0;
            var a0 = unchecked((uint)(b0 ? Overflowing.WrappingNeg(x0) : x0));
            var a1 = unchecked((uint)(b1 ? Overflowing.WrappingNeg(x1) : x1));

            // 各要素の最大値が 0 の場合は null を返す。

            var max = a0.Max(a1);
            if (max == 0) {
                return null;
            }

            // ベクトルの大きさが小さい時の誤差を小さくするため、
            // 最大の要素が表現型の範囲に収まるように拡大する。
            // 最大の要素以外にも同じ値を乗算する。

            ulong m = uint.MaxValue / max;
            var l0 = m * a0;
            var l1 = m * a1;
            var sum =
                (l0 * l0 / 4) +
                (l1 * l1 / 4);
            var ll = Mathi.Sqrt(sum);

            // 小数部の桁をあわせる。

            const ulong k = 1UL << 14;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);

            // 最後に符号をあわせて返す。

            return new Vector2I17F15(
                I17F15.FromBits(b0 ? -y0 : y0),
                I17F15.FromBits(b1 ? -y1 : y1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 SinP4() => new Vector2I2F30(
            X.SinP4(),
            Y.SinP4());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 SinP5() => new Vector2I2F30(
            X.SinP5(),
            Y.SinP5());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 CosP4() => new Vector2I2F30(
            X.CosP4(),
            Y.CosP4());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 CosP5() => new Vector2I2F30(
            X.CosP5(),
            Y.CosP5());

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XX() => new Vector2I17F15(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XY() => new Vector2I17F15(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YX() => new Vector2I17F15(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YY() => new Vector2I17F15(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXX() => new Vector3I17F15(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXY() => new Vector3I17F15(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYX() => new Vector3I17F15(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYY() => new Vector3I17F15(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXX() => new Vector3I17F15(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXY() => new Vector3I17F15(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYX() => new Vector3I17F15(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYY() => new Vector3I17F15(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXX() => new Vector4I17F15(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXY() => new Vector4I17F15(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYX() => new Vector4I17F15(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYY() => new Vector4I17F15(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXX() => new Vector4I17F15(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXY() => new Vector4I17F15(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYX() => new Vector4I17F15(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYY() => new Vector4I17F15(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXX() => new Vector4I17F15(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXY() => new Vector4I17F15(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYX() => new Vector4I17F15(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYY() => new Vector4I17F15(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXX() => new Vector4I17F15(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXY() => new Vector4I17F15(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYX() => new Vector4I17F15(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYY() => new Vector4I17F15(Y, Y, Y, Y);

    }
} // // namespace AgatePris.Intar
