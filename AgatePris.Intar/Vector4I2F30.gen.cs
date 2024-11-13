using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct Vector4I2F30
    : IEquatable<Vector4I2F30>
    , IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector4Int32 Repr;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        internal Vector4Int64 WideRepr {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Repr;
        }

        public I2F30 X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I2F30.FromBits(Repr.X);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.X = value.Bits;
        }
        public I2F30 Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I2F30.FromBits(Repr.Y);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Y = value.Bits;
        }
        public I2F30 Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I2F30.FromBits(Repr.Z);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Z = value.Bits;
        }
        public I2F30 W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I2F30.FromBits(Repr.W);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.W = value.Bits;
        }

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(Vector4Int32 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(I2F30 x, I2F30 y, I2F30 z, I2F30 w) : this(new Vector4Int32(x.Bits, y.Bits, z.Bits, w.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(I2F30 value) : this(value, value, value, value) { }

        // Constants
        // ---------------------------------------

        public static readonly Vector4I2F30 Zero = new Vector4I2F30(I2F30.Zero);
        public static readonly Vector4I2F30 One = new Vector4I2F30(I2F30.One);
        public static readonly Vector4I2F30 UnitX = new Vector4I2F30(I2F30.One, I2F30.Zero, I2F30.Zero, I2F30.Zero);
        public static readonly Vector4I2F30 UnitY = new Vector4I2F30(I2F30.Zero, I2F30.One, I2F30.Zero, I2F30.Zero);
        public static readonly Vector4I2F30 UnitZ = new Vector4I2F30(I2F30.Zero, I2F30.Zero, I2F30.One, I2F30.Zero);
        public static readonly Vector4I2F30 UnitW = new Vector4I2F30(I2F30.Zero, I2F30.Zero, I2F30.Zero, I2F30.One);

        //
        // IAdditionOperators
        // ISubtractionOperators
        // IIMultiplyOperators
        // IDivisionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator +(Vector4I2F30 a, Vector4I2F30 b) {
            return new Vector4I2F30(a.Repr + b.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator -(Vector4I2F30 a, Vector4I2F30 b) {
            return new Vector4I2F30(a.Repr - b.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator *(Vector4I2F30 a, Vector4I2F30 b) {
            return new Vector4I2F30((Vector4Int32)(a.WideRepr * b.WideRepr / I2F30.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator *(Vector4I2F30 a, I2F30 b) {
            return new Vector4I2F30((Vector4Int32)(a.WideRepr * b.Bits / I2F30.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator *(I2F30 a, Vector4I2F30 b) {
            return b * a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator /(Vector4I2F30 a, Vector4I2F30 b) {
            return new Vector4I2F30((Vector4Int32)(a.WideRepr * I2F30.OneRepr / b.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator /(Vector4I2F30 a, I2F30 b) {
            return new Vector4I2F30((Vector4Int32)(a.WideRepr * I2F30.OneRepr / b.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator /(I2F30 a, Vector4I2F30 b) {
            return new Vector4I2F30((Vector4Int32)(a.WideBits * I2F30.OneRepr / b.WideRepr));
        }

        //
        // IUnaryPlusOperators
        // IUnaryNegationOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator +(Vector4I2F30 x) {
            return new Vector4I2F30(+x.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator -(Vector4I2F30 x) {
            return new Vector4I2F30(-x.Repr);
        }

        //
        // IEqualityOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4I2F30 lhs, Vector4I2F30 rhs) => lhs.Repr == rhs.Repr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4I2F30 lhs, Vector4I2F30 rhs) => lhs.Repr != rhs.Repr;

        // Indexer
        // ---------------------------------------

        public I2F30 this[int index] {
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

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector4I2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        //
        // IEquatable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I2F30 other) {
            return Repr.Equals(other.Repr);
        }

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}, {Z.ToString(format, formatProvider)}, {W.ToString(format, formatProvider)}>";
        }

        //
        // Methods
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 Min(Vector4I2F30 other) {
            return new Vector4I2F30(Repr.Min(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 Max(Vector4I2F30 other) {
            return new Vector4I2F30(Repr.Max(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 Abs() => new Vector4I2F30(Repr.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector4I2F30 Half() => new Vector4I2F30(Repr.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector4I2F30 Twice() => new Vector4I2F30(Repr.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 Clamp(I2F30 min, I2F30 max) {
            return new Vector4I2F30(Repr.Clamp(min.Bits, max.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 Clamp(Vector4I2F30 min, Vector4I2F30 max) {
            return new Vector4I2F30(Repr.Clamp(min.Repr, max.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        long DotInternal(Vector4I2F30 other) {
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
        public I2F30 Dot(Vector4I2F30 other) {
            const long k = 1L << 28;
            return I2F30.FromBits((int)(DotInternal(other) / k));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I2F30 SaturatingDot(Vector4I2F30 other) {
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

        // ベクトルの長さは符号つき、
        // かつ次元が 3 以下の場合のみ定義される。

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30? Normalize() {

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

            const ulong k = 1UL << 29;
            var y0 = (int)(l0 * k / ll);
            var y1 = (int)(l1 * k / ll);
            var y2 = (int)(l2 * k / ll);
            var y3 = (int)(l3 * k / ll);

            // 最後に符号をあわせて返す。

            return new Vector4I2F30(
                I2F30.FromBits(b0 ? -y0 : y0),
                I2F30.FromBits(b1 ? -y1 : y1),
                I2F30.FromBits(b2 ? -y2 : y2),
                I2F30.FromBits(b3 ? -y3 : y3));
        }

        // Swizzling
        // ---------

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XX() => new Vector2I2F30(X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XY() => new Vector2I2F30(X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XZ() => new Vector2I2F30(X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XW() => new Vector2I2F30(X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YX() => new Vector2I2F30(Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YY() => new Vector2I2F30(Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YZ() => new Vector2I2F30(Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YW() => new Vector2I2F30(Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 ZX() => new Vector2I2F30(Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 ZY() => new Vector2I2F30(Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 ZZ() => new Vector2I2F30(Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 ZW() => new Vector2I2F30(Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 WX() => new Vector2I2F30(W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 WY() => new Vector2I2F30(W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 WZ() => new Vector2I2F30(W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 WW() => new Vector2I2F30(W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXX() => new Vector3I2F30(X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXY() => new Vector3I2F30(X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXZ() => new Vector3I2F30(X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXW() => new Vector3I2F30(X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYX() => new Vector3I2F30(X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYY() => new Vector3I2F30(X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYZ() => new Vector3I2F30(X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYW() => new Vector3I2F30(X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XZX() => new Vector3I2F30(X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XZY() => new Vector3I2F30(X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XZZ() => new Vector3I2F30(X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XZW() => new Vector3I2F30(X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XWX() => new Vector3I2F30(X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XWY() => new Vector3I2F30(X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XWZ() => new Vector3I2F30(X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XWW() => new Vector3I2F30(X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXX() => new Vector3I2F30(Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXY() => new Vector3I2F30(Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXZ() => new Vector3I2F30(Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXW() => new Vector3I2F30(Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYX() => new Vector3I2F30(Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYY() => new Vector3I2F30(Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYZ() => new Vector3I2F30(Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYW() => new Vector3I2F30(Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YZX() => new Vector3I2F30(Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YZY() => new Vector3I2F30(Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YZZ() => new Vector3I2F30(Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YZW() => new Vector3I2F30(Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YWX() => new Vector3I2F30(Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YWY() => new Vector3I2F30(Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YWZ() => new Vector3I2F30(Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YWW() => new Vector3I2F30(Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZXX() => new Vector3I2F30(Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZXY() => new Vector3I2F30(Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZXZ() => new Vector3I2F30(Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZXW() => new Vector3I2F30(Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZYX() => new Vector3I2F30(Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZYY() => new Vector3I2F30(Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZYZ() => new Vector3I2F30(Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZYW() => new Vector3I2F30(Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZZX() => new Vector3I2F30(Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZZY() => new Vector3I2F30(Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZZZ() => new Vector3I2F30(Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZZW() => new Vector3I2F30(Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZWX() => new Vector3I2F30(Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZWY() => new Vector3I2F30(Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZWZ() => new Vector3I2F30(Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZWW() => new Vector3I2F30(Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WXX() => new Vector3I2F30(W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WXY() => new Vector3I2F30(W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WXZ() => new Vector3I2F30(W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WXW() => new Vector3I2F30(W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WYX() => new Vector3I2F30(W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WYY() => new Vector3I2F30(W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WYZ() => new Vector3I2F30(W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WYW() => new Vector3I2F30(W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WZX() => new Vector3I2F30(W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WZY() => new Vector3I2F30(W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WZZ() => new Vector3I2F30(W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WZW() => new Vector3I2F30(W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WWX() => new Vector3I2F30(W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WWY() => new Vector3I2F30(W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WWZ() => new Vector3I2F30(W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WWW() => new Vector3I2F30(W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXX() => new Vector4I2F30(X, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXY() => new Vector4I2F30(X, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXZ() => new Vector4I2F30(X, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXW() => new Vector4I2F30(X, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYX() => new Vector4I2F30(X, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYY() => new Vector4I2F30(X, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYZ() => new Vector4I2F30(X, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYW() => new Vector4I2F30(X, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXZX() => new Vector4I2F30(X, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXZY() => new Vector4I2F30(X, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXZZ() => new Vector4I2F30(X, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXZW() => new Vector4I2F30(X, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXWX() => new Vector4I2F30(X, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXWY() => new Vector4I2F30(X, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXWZ() => new Vector4I2F30(X, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXWW() => new Vector4I2F30(X, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXX() => new Vector4I2F30(X, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXY() => new Vector4I2F30(X, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXZ() => new Vector4I2F30(X, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXW() => new Vector4I2F30(X, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYX() => new Vector4I2F30(X, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYY() => new Vector4I2F30(X, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYZ() => new Vector4I2F30(X, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYW() => new Vector4I2F30(X, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZX() => new Vector4I2F30(X, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZY() => new Vector4I2F30(X, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZZ() => new Vector4I2F30(X, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZW() => new Vector4I2F30(X, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYWX() => new Vector4I2F30(X, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYWY() => new Vector4I2F30(X, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYWZ() => new Vector4I2F30(X, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYWW() => new Vector4I2F30(X, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZXX() => new Vector4I2F30(X, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZXY() => new Vector4I2F30(X, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZXZ() => new Vector4I2F30(X, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZXW() => new Vector4I2F30(X, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZYX() => new Vector4I2F30(X, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZYY() => new Vector4I2F30(X, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZYZ() => new Vector4I2F30(X, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZYW() => new Vector4I2F30(X, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZZX() => new Vector4I2F30(X, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZZY() => new Vector4I2F30(X, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZZZ() => new Vector4I2F30(X, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZZW() => new Vector4I2F30(X, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZWX() => new Vector4I2F30(X, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZWY() => new Vector4I2F30(X, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZWZ() => new Vector4I2F30(X, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZWW() => new Vector4I2F30(X, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWXX() => new Vector4I2F30(X, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWXY() => new Vector4I2F30(X, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWXZ() => new Vector4I2F30(X, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWXW() => new Vector4I2F30(X, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWYX() => new Vector4I2F30(X, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWYY() => new Vector4I2F30(X, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWYZ() => new Vector4I2F30(X, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWYW() => new Vector4I2F30(X, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWZX() => new Vector4I2F30(X, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWZY() => new Vector4I2F30(X, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWZZ() => new Vector4I2F30(X, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWZW() => new Vector4I2F30(X, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWWX() => new Vector4I2F30(X, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWWY() => new Vector4I2F30(X, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWWZ() => new Vector4I2F30(X, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWWW() => new Vector4I2F30(X, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXX() => new Vector4I2F30(Y, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXY() => new Vector4I2F30(Y, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXZ() => new Vector4I2F30(Y, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXW() => new Vector4I2F30(Y, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYX() => new Vector4I2F30(Y, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYY() => new Vector4I2F30(Y, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYZ() => new Vector4I2F30(Y, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYW() => new Vector4I2F30(Y, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXZX() => new Vector4I2F30(Y, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXZY() => new Vector4I2F30(Y, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXZZ() => new Vector4I2F30(Y, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXZW() => new Vector4I2F30(Y, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXWX() => new Vector4I2F30(Y, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXWY() => new Vector4I2F30(Y, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXWZ() => new Vector4I2F30(Y, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXWW() => new Vector4I2F30(Y, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXX() => new Vector4I2F30(Y, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXY() => new Vector4I2F30(Y, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXZ() => new Vector4I2F30(Y, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXW() => new Vector4I2F30(Y, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYX() => new Vector4I2F30(Y, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYY() => new Vector4I2F30(Y, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYZ() => new Vector4I2F30(Y, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYW() => new Vector4I2F30(Y, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYZX() => new Vector4I2F30(Y, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYZY() => new Vector4I2F30(Y, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYZZ() => new Vector4I2F30(Y, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYZW() => new Vector4I2F30(Y, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYWX() => new Vector4I2F30(Y, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYWY() => new Vector4I2F30(Y, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYWZ() => new Vector4I2F30(Y, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYWW() => new Vector4I2F30(Y, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZXX() => new Vector4I2F30(Y, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZXY() => new Vector4I2F30(Y, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZXZ() => new Vector4I2F30(Y, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZXW() => new Vector4I2F30(Y, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZYX() => new Vector4I2F30(Y, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZYY() => new Vector4I2F30(Y, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZYZ() => new Vector4I2F30(Y, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZYW() => new Vector4I2F30(Y, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZZX() => new Vector4I2F30(Y, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZZY() => new Vector4I2F30(Y, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZZZ() => new Vector4I2F30(Y, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZZW() => new Vector4I2F30(Y, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZWX() => new Vector4I2F30(Y, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZWY() => new Vector4I2F30(Y, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZWZ() => new Vector4I2F30(Y, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZWW() => new Vector4I2F30(Y, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWXX() => new Vector4I2F30(Y, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWXY() => new Vector4I2F30(Y, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWXZ() => new Vector4I2F30(Y, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWXW() => new Vector4I2F30(Y, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWYX() => new Vector4I2F30(Y, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWYY() => new Vector4I2F30(Y, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWYZ() => new Vector4I2F30(Y, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWYW() => new Vector4I2F30(Y, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWZX() => new Vector4I2F30(Y, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWZY() => new Vector4I2F30(Y, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWZZ() => new Vector4I2F30(Y, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWZW() => new Vector4I2F30(Y, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWWX() => new Vector4I2F30(Y, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWWY() => new Vector4I2F30(Y, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWWZ() => new Vector4I2F30(Y, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWWW() => new Vector4I2F30(Y, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXXX() => new Vector4I2F30(Z, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXXY() => new Vector4I2F30(Z, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXXZ() => new Vector4I2F30(Z, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXXW() => new Vector4I2F30(Z, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXYX() => new Vector4I2F30(Z, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXYY() => new Vector4I2F30(Z, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXYZ() => new Vector4I2F30(Z, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXYW() => new Vector4I2F30(Z, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXZX() => new Vector4I2F30(Z, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXZY() => new Vector4I2F30(Z, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXZZ() => new Vector4I2F30(Z, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXZW() => new Vector4I2F30(Z, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXWX() => new Vector4I2F30(Z, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXWY() => new Vector4I2F30(Z, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXWZ() => new Vector4I2F30(Z, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXWW() => new Vector4I2F30(Z, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYXX() => new Vector4I2F30(Z, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYXY() => new Vector4I2F30(Z, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYXZ() => new Vector4I2F30(Z, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYXW() => new Vector4I2F30(Z, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYYX() => new Vector4I2F30(Z, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYYY() => new Vector4I2F30(Z, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYYZ() => new Vector4I2F30(Z, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYYW() => new Vector4I2F30(Z, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYZX() => new Vector4I2F30(Z, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYZY() => new Vector4I2F30(Z, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYZZ() => new Vector4I2F30(Z, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYZW() => new Vector4I2F30(Z, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYWX() => new Vector4I2F30(Z, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYWY() => new Vector4I2F30(Z, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYWZ() => new Vector4I2F30(Z, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYWW() => new Vector4I2F30(Z, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZXX() => new Vector4I2F30(Z, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZXY() => new Vector4I2F30(Z, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZXZ() => new Vector4I2F30(Z, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZXW() => new Vector4I2F30(Z, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZYX() => new Vector4I2F30(Z, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZYY() => new Vector4I2F30(Z, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZYZ() => new Vector4I2F30(Z, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZYW() => new Vector4I2F30(Z, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZZX() => new Vector4I2F30(Z, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZZY() => new Vector4I2F30(Z, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZZZ() => new Vector4I2F30(Z, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZZW() => new Vector4I2F30(Z, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZWX() => new Vector4I2F30(Z, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZWY() => new Vector4I2F30(Z, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZWZ() => new Vector4I2F30(Z, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZWW() => new Vector4I2F30(Z, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWXX() => new Vector4I2F30(Z, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWXY() => new Vector4I2F30(Z, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWXZ() => new Vector4I2F30(Z, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWXW() => new Vector4I2F30(Z, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWYX() => new Vector4I2F30(Z, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWYY() => new Vector4I2F30(Z, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWYZ() => new Vector4I2F30(Z, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWYW() => new Vector4I2F30(Z, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWZX() => new Vector4I2F30(Z, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWZY() => new Vector4I2F30(Z, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWZZ() => new Vector4I2F30(Z, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWZW() => new Vector4I2F30(Z, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWWX() => new Vector4I2F30(Z, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWWY() => new Vector4I2F30(Z, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWWZ() => new Vector4I2F30(Z, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWWW() => new Vector4I2F30(Z, W, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXXX() => new Vector4I2F30(W, X, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXXY() => new Vector4I2F30(W, X, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXXZ() => new Vector4I2F30(W, X, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXXW() => new Vector4I2F30(W, X, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXYX() => new Vector4I2F30(W, X, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXYY() => new Vector4I2F30(W, X, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXYZ() => new Vector4I2F30(W, X, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXYW() => new Vector4I2F30(W, X, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXZX() => new Vector4I2F30(W, X, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXZY() => new Vector4I2F30(W, X, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXZZ() => new Vector4I2F30(W, X, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXZW() => new Vector4I2F30(W, X, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXWX() => new Vector4I2F30(W, X, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXWY() => new Vector4I2F30(W, X, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXWZ() => new Vector4I2F30(W, X, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXWW() => new Vector4I2F30(W, X, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYXX() => new Vector4I2F30(W, Y, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYXY() => new Vector4I2F30(W, Y, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYXZ() => new Vector4I2F30(W, Y, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYXW() => new Vector4I2F30(W, Y, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYYX() => new Vector4I2F30(W, Y, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYYY() => new Vector4I2F30(W, Y, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYYZ() => new Vector4I2F30(W, Y, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYYW() => new Vector4I2F30(W, Y, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYZX() => new Vector4I2F30(W, Y, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYZY() => new Vector4I2F30(W, Y, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYZZ() => new Vector4I2F30(W, Y, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYZW() => new Vector4I2F30(W, Y, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYWX() => new Vector4I2F30(W, Y, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYWY() => new Vector4I2F30(W, Y, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYWZ() => new Vector4I2F30(W, Y, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYWW() => new Vector4I2F30(W, Y, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZXX() => new Vector4I2F30(W, Z, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZXY() => new Vector4I2F30(W, Z, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZXZ() => new Vector4I2F30(W, Z, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZXW() => new Vector4I2F30(W, Z, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZYX() => new Vector4I2F30(W, Z, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZYY() => new Vector4I2F30(W, Z, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZYZ() => new Vector4I2F30(W, Z, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZYW() => new Vector4I2F30(W, Z, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZZX() => new Vector4I2F30(W, Z, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZZY() => new Vector4I2F30(W, Z, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZZZ() => new Vector4I2F30(W, Z, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZZW() => new Vector4I2F30(W, Z, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZWX() => new Vector4I2F30(W, Z, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZWY() => new Vector4I2F30(W, Z, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZWZ() => new Vector4I2F30(W, Z, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZWW() => new Vector4I2F30(W, Z, W, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWXX() => new Vector4I2F30(W, W, X, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWXY() => new Vector4I2F30(W, W, X, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWXZ() => new Vector4I2F30(W, W, X, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWXW() => new Vector4I2F30(W, W, X, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWYX() => new Vector4I2F30(W, W, Y, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWYY() => new Vector4I2F30(W, W, Y, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWYZ() => new Vector4I2F30(W, W, Y, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWYW() => new Vector4I2F30(W, W, Y, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWZX() => new Vector4I2F30(W, W, Z, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWZY() => new Vector4I2F30(W, W, Z, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWZZ() => new Vector4I2F30(W, W, Z, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWZW() => new Vector4I2F30(W, W, Z, W);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWWX() => new Vector4I2F30(W, W, W, X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWWY() => new Vector4I2F30(W, W, W, Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWWZ() => new Vector4I2F30(W, W, W, Z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWWW() => new Vector4I2F30(W, W, W, W);

    }
} // // namespace AgatePris.Intar
