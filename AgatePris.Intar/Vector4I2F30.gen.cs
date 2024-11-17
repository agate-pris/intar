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

        public I2F30 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I2F30.FromBits(Repr[index]);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr[index] = value.Bits;
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
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator +(Vector4I2F30 a, Vector4I2F30 b) {
            return new Vector4I2F30(a.Repr + b.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator -(Vector4I2F30 a, Vector4I2F30 b) {
            return new Vector4I2F30(a.Repr - b.Repr);
        }

        //
        // IIMultiplyOperators
        // IDivisionOperators
        //

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
        public static Vector4Bool operator ==(Vector4I2F30 lhs, Vector4I2F30 rhs) => lhs.Repr == rhs.Repr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(Vector4I2F30 lhs, Vector4I2F30 rhs) => lhs.Repr != rhs.Repr;

        //
        // Derived from INumberBase
        //

        public Vector4Bool IsNegative() => Repr.IsNegative();

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
        public I4F60 UncheckedDot(Vector4I2F30 other) {
            return I4F60.FromBits(Repr.UncheckedDot(other.Repr));
        }

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F60 UncheckedLengthSquared() => U4F60.FromBits(Repr.UncheckedLengthSquared());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 UncheckedLength() => U2F30.FromBits(Repr.UncheckedLength());

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

        //
        // Swizzling
        //

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XX() => new Vector2I2F30(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XY() => new Vector2I2F30(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XZ() => new Vector2I2F30(Repr.XZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XW() => new Vector2I2F30(Repr.XW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YX() => new Vector2I2F30(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YY() => new Vector2I2F30(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YZ() => new Vector2I2F30(Repr.YZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YW() => new Vector2I2F30(Repr.YW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 ZX() => new Vector2I2F30(Repr.ZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 ZY() => new Vector2I2F30(Repr.ZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 ZZ() => new Vector2I2F30(Repr.ZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 ZW() => new Vector2I2F30(Repr.ZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 WX() => new Vector2I2F30(Repr.WX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 WY() => new Vector2I2F30(Repr.WY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 WZ() => new Vector2I2F30(Repr.WZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 WW() => new Vector2I2F30(Repr.WW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXX() => new Vector3I2F30(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXY() => new Vector3I2F30(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXZ() => new Vector3I2F30(Repr.XXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXW() => new Vector3I2F30(Repr.XXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYX() => new Vector3I2F30(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYY() => new Vector3I2F30(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYZ() => new Vector3I2F30(Repr.XYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYW() => new Vector3I2F30(Repr.XYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XZX() => new Vector3I2F30(Repr.XZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XZY() => new Vector3I2F30(Repr.XZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XZZ() => new Vector3I2F30(Repr.XZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XZW() => new Vector3I2F30(Repr.XZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XWX() => new Vector3I2F30(Repr.XWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XWY() => new Vector3I2F30(Repr.XWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XWZ() => new Vector3I2F30(Repr.XWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XWW() => new Vector3I2F30(Repr.XWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXX() => new Vector3I2F30(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXY() => new Vector3I2F30(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXZ() => new Vector3I2F30(Repr.YXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXW() => new Vector3I2F30(Repr.YXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYX() => new Vector3I2F30(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYY() => new Vector3I2F30(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYZ() => new Vector3I2F30(Repr.YYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYW() => new Vector3I2F30(Repr.YYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YZX() => new Vector3I2F30(Repr.YZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YZY() => new Vector3I2F30(Repr.YZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YZZ() => new Vector3I2F30(Repr.YZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YZW() => new Vector3I2F30(Repr.YZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YWX() => new Vector3I2F30(Repr.YWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YWY() => new Vector3I2F30(Repr.YWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YWZ() => new Vector3I2F30(Repr.YWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YWW() => new Vector3I2F30(Repr.YWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZXX() => new Vector3I2F30(Repr.ZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZXY() => new Vector3I2F30(Repr.ZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZXZ() => new Vector3I2F30(Repr.ZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZXW() => new Vector3I2F30(Repr.ZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZYX() => new Vector3I2F30(Repr.ZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZYY() => new Vector3I2F30(Repr.ZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZYZ() => new Vector3I2F30(Repr.ZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZYW() => new Vector3I2F30(Repr.ZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZZX() => new Vector3I2F30(Repr.ZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZZY() => new Vector3I2F30(Repr.ZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZZZ() => new Vector3I2F30(Repr.ZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZZW() => new Vector3I2F30(Repr.ZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZWX() => new Vector3I2F30(Repr.ZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZWY() => new Vector3I2F30(Repr.ZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZWZ() => new Vector3I2F30(Repr.ZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZWW() => new Vector3I2F30(Repr.ZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WXX() => new Vector3I2F30(Repr.WXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WXY() => new Vector3I2F30(Repr.WXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WXZ() => new Vector3I2F30(Repr.WXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WXW() => new Vector3I2F30(Repr.WXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WYX() => new Vector3I2F30(Repr.WYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WYY() => new Vector3I2F30(Repr.WYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WYZ() => new Vector3I2F30(Repr.WYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WYW() => new Vector3I2F30(Repr.WYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WZX() => new Vector3I2F30(Repr.WZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WZY() => new Vector3I2F30(Repr.WZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WZZ() => new Vector3I2F30(Repr.WZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WZW() => new Vector3I2F30(Repr.WZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WWX() => new Vector3I2F30(Repr.WWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WWY() => new Vector3I2F30(Repr.WWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WWZ() => new Vector3I2F30(Repr.WWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WWW() => new Vector3I2F30(Repr.WWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXX() => new Vector4I2F30(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXY() => new Vector4I2F30(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXZ() => new Vector4I2F30(Repr.XXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXW() => new Vector4I2F30(Repr.XXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYX() => new Vector4I2F30(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYY() => new Vector4I2F30(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYZ() => new Vector4I2F30(Repr.XXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYW() => new Vector4I2F30(Repr.XXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXZX() => new Vector4I2F30(Repr.XXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXZY() => new Vector4I2F30(Repr.XXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXZZ() => new Vector4I2F30(Repr.XXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXZW() => new Vector4I2F30(Repr.XXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXWX() => new Vector4I2F30(Repr.XXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXWY() => new Vector4I2F30(Repr.XXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXWZ() => new Vector4I2F30(Repr.XXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXWW() => new Vector4I2F30(Repr.XXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXX() => new Vector4I2F30(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXY() => new Vector4I2F30(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXZ() => new Vector4I2F30(Repr.XYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXW() => new Vector4I2F30(Repr.XYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYX() => new Vector4I2F30(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYY() => new Vector4I2F30(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYZ() => new Vector4I2F30(Repr.XYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYW() => new Vector4I2F30(Repr.XYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZX() => new Vector4I2F30(Repr.XYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZY() => new Vector4I2F30(Repr.XYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZZ() => new Vector4I2F30(Repr.XYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZW() => new Vector4I2F30(Repr.XYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYWX() => new Vector4I2F30(Repr.XYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYWY() => new Vector4I2F30(Repr.XYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYWZ() => new Vector4I2F30(Repr.XYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYWW() => new Vector4I2F30(Repr.XYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZXX() => new Vector4I2F30(Repr.XZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZXY() => new Vector4I2F30(Repr.XZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZXZ() => new Vector4I2F30(Repr.XZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZXW() => new Vector4I2F30(Repr.XZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZYX() => new Vector4I2F30(Repr.XZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZYY() => new Vector4I2F30(Repr.XZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZYZ() => new Vector4I2F30(Repr.XZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZYW() => new Vector4I2F30(Repr.XZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZZX() => new Vector4I2F30(Repr.XZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZZY() => new Vector4I2F30(Repr.XZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZZZ() => new Vector4I2F30(Repr.XZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZZW() => new Vector4I2F30(Repr.XZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZWX() => new Vector4I2F30(Repr.XZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZWY() => new Vector4I2F30(Repr.XZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZWZ() => new Vector4I2F30(Repr.XZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZWW() => new Vector4I2F30(Repr.XZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWXX() => new Vector4I2F30(Repr.XWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWXY() => new Vector4I2F30(Repr.XWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWXZ() => new Vector4I2F30(Repr.XWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWXW() => new Vector4I2F30(Repr.XWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWYX() => new Vector4I2F30(Repr.XWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWYY() => new Vector4I2F30(Repr.XWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWYZ() => new Vector4I2F30(Repr.XWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWYW() => new Vector4I2F30(Repr.XWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWZX() => new Vector4I2F30(Repr.XWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWZY() => new Vector4I2F30(Repr.XWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWZZ() => new Vector4I2F30(Repr.XWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWZW() => new Vector4I2F30(Repr.XWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWWX() => new Vector4I2F30(Repr.XWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWWY() => new Vector4I2F30(Repr.XWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWWZ() => new Vector4I2F30(Repr.XWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWWW() => new Vector4I2F30(Repr.XWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXX() => new Vector4I2F30(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXY() => new Vector4I2F30(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXZ() => new Vector4I2F30(Repr.YXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXW() => new Vector4I2F30(Repr.YXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYX() => new Vector4I2F30(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYY() => new Vector4I2F30(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYZ() => new Vector4I2F30(Repr.YXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYW() => new Vector4I2F30(Repr.YXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXZX() => new Vector4I2F30(Repr.YXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXZY() => new Vector4I2F30(Repr.YXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXZZ() => new Vector4I2F30(Repr.YXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXZW() => new Vector4I2F30(Repr.YXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXWX() => new Vector4I2F30(Repr.YXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXWY() => new Vector4I2F30(Repr.YXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXWZ() => new Vector4I2F30(Repr.YXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXWW() => new Vector4I2F30(Repr.YXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXX() => new Vector4I2F30(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXY() => new Vector4I2F30(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXZ() => new Vector4I2F30(Repr.YYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXW() => new Vector4I2F30(Repr.YYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYX() => new Vector4I2F30(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYY() => new Vector4I2F30(Repr.YYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYZ() => new Vector4I2F30(Repr.YYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYW() => new Vector4I2F30(Repr.YYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYZX() => new Vector4I2F30(Repr.YYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYZY() => new Vector4I2F30(Repr.YYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYZZ() => new Vector4I2F30(Repr.YYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYZW() => new Vector4I2F30(Repr.YYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYWX() => new Vector4I2F30(Repr.YYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYWY() => new Vector4I2F30(Repr.YYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYWZ() => new Vector4I2F30(Repr.YYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYWW() => new Vector4I2F30(Repr.YYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZXX() => new Vector4I2F30(Repr.YZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZXY() => new Vector4I2F30(Repr.YZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZXZ() => new Vector4I2F30(Repr.YZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZXW() => new Vector4I2F30(Repr.YZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZYX() => new Vector4I2F30(Repr.YZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZYY() => new Vector4I2F30(Repr.YZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZYZ() => new Vector4I2F30(Repr.YZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZYW() => new Vector4I2F30(Repr.YZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZZX() => new Vector4I2F30(Repr.YZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZZY() => new Vector4I2F30(Repr.YZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZZZ() => new Vector4I2F30(Repr.YZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZZW() => new Vector4I2F30(Repr.YZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZWX() => new Vector4I2F30(Repr.YZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZWY() => new Vector4I2F30(Repr.YZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZWZ() => new Vector4I2F30(Repr.YZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZWW() => new Vector4I2F30(Repr.YZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWXX() => new Vector4I2F30(Repr.YWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWXY() => new Vector4I2F30(Repr.YWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWXZ() => new Vector4I2F30(Repr.YWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWXW() => new Vector4I2F30(Repr.YWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWYX() => new Vector4I2F30(Repr.YWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWYY() => new Vector4I2F30(Repr.YWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWYZ() => new Vector4I2F30(Repr.YWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWYW() => new Vector4I2F30(Repr.YWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWZX() => new Vector4I2F30(Repr.YWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWZY() => new Vector4I2F30(Repr.YWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWZZ() => new Vector4I2F30(Repr.YWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWZW() => new Vector4I2F30(Repr.YWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWWX() => new Vector4I2F30(Repr.YWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWWY() => new Vector4I2F30(Repr.YWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWWZ() => new Vector4I2F30(Repr.YWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWWW() => new Vector4I2F30(Repr.YWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXXX() => new Vector4I2F30(Repr.ZXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXXY() => new Vector4I2F30(Repr.ZXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXXZ() => new Vector4I2F30(Repr.ZXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXXW() => new Vector4I2F30(Repr.ZXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXYX() => new Vector4I2F30(Repr.ZXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXYY() => new Vector4I2F30(Repr.ZXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXYZ() => new Vector4I2F30(Repr.ZXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXYW() => new Vector4I2F30(Repr.ZXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXZX() => new Vector4I2F30(Repr.ZXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXZY() => new Vector4I2F30(Repr.ZXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXZZ() => new Vector4I2F30(Repr.ZXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXZW() => new Vector4I2F30(Repr.ZXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXWX() => new Vector4I2F30(Repr.ZXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXWY() => new Vector4I2F30(Repr.ZXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXWZ() => new Vector4I2F30(Repr.ZXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXWW() => new Vector4I2F30(Repr.ZXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYXX() => new Vector4I2F30(Repr.ZYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYXY() => new Vector4I2F30(Repr.ZYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYXZ() => new Vector4I2F30(Repr.ZYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYXW() => new Vector4I2F30(Repr.ZYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYYX() => new Vector4I2F30(Repr.ZYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYYY() => new Vector4I2F30(Repr.ZYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYYZ() => new Vector4I2F30(Repr.ZYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYYW() => new Vector4I2F30(Repr.ZYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYZX() => new Vector4I2F30(Repr.ZYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYZY() => new Vector4I2F30(Repr.ZYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYZZ() => new Vector4I2F30(Repr.ZYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYZW() => new Vector4I2F30(Repr.ZYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYWX() => new Vector4I2F30(Repr.ZYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYWY() => new Vector4I2F30(Repr.ZYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYWZ() => new Vector4I2F30(Repr.ZYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYWW() => new Vector4I2F30(Repr.ZYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZXX() => new Vector4I2F30(Repr.ZZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZXY() => new Vector4I2F30(Repr.ZZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZXZ() => new Vector4I2F30(Repr.ZZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZXW() => new Vector4I2F30(Repr.ZZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZYX() => new Vector4I2F30(Repr.ZZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZYY() => new Vector4I2F30(Repr.ZZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZYZ() => new Vector4I2F30(Repr.ZZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZYW() => new Vector4I2F30(Repr.ZZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZZX() => new Vector4I2F30(Repr.ZZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZZY() => new Vector4I2F30(Repr.ZZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZZZ() => new Vector4I2F30(Repr.ZZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZZW() => new Vector4I2F30(Repr.ZZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZWX() => new Vector4I2F30(Repr.ZZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZWY() => new Vector4I2F30(Repr.ZZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZWZ() => new Vector4I2F30(Repr.ZZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZWW() => new Vector4I2F30(Repr.ZZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWXX() => new Vector4I2F30(Repr.ZWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWXY() => new Vector4I2F30(Repr.ZWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWXZ() => new Vector4I2F30(Repr.ZWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWXW() => new Vector4I2F30(Repr.ZWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWYX() => new Vector4I2F30(Repr.ZWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWYY() => new Vector4I2F30(Repr.ZWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWYZ() => new Vector4I2F30(Repr.ZWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWYW() => new Vector4I2F30(Repr.ZWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWZX() => new Vector4I2F30(Repr.ZWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWZY() => new Vector4I2F30(Repr.ZWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWZZ() => new Vector4I2F30(Repr.ZWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWZW() => new Vector4I2F30(Repr.ZWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWWX() => new Vector4I2F30(Repr.ZWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWWY() => new Vector4I2F30(Repr.ZWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWWZ() => new Vector4I2F30(Repr.ZWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWWW() => new Vector4I2F30(Repr.ZWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXXX() => new Vector4I2F30(Repr.WXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXXY() => new Vector4I2F30(Repr.WXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXXZ() => new Vector4I2F30(Repr.WXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXXW() => new Vector4I2F30(Repr.WXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXYX() => new Vector4I2F30(Repr.WXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXYY() => new Vector4I2F30(Repr.WXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXYZ() => new Vector4I2F30(Repr.WXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXYW() => new Vector4I2F30(Repr.WXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXZX() => new Vector4I2F30(Repr.WXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXZY() => new Vector4I2F30(Repr.WXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXZZ() => new Vector4I2F30(Repr.WXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXZW() => new Vector4I2F30(Repr.WXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXWX() => new Vector4I2F30(Repr.WXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXWY() => new Vector4I2F30(Repr.WXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXWZ() => new Vector4I2F30(Repr.WXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXWW() => new Vector4I2F30(Repr.WXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYXX() => new Vector4I2F30(Repr.WYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYXY() => new Vector4I2F30(Repr.WYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYXZ() => new Vector4I2F30(Repr.WYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYXW() => new Vector4I2F30(Repr.WYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYYX() => new Vector4I2F30(Repr.WYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYYY() => new Vector4I2F30(Repr.WYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYYZ() => new Vector4I2F30(Repr.WYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYYW() => new Vector4I2F30(Repr.WYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYZX() => new Vector4I2F30(Repr.WYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYZY() => new Vector4I2F30(Repr.WYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYZZ() => new Vector4I2F30(Repr.WYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYZW() => new Vector4I2F30(Repr.WYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYWX() => new Vector4I2F30(Repr.WYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYWY() => new Vector4I2F30(Repr.WYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYWZ() => new Vector4I2F30(Repr.WYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYWW() => new Vector4I2F30(Repr.WYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZXX() => new Vector4I2F30(Repr.WZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZXY() => new Vector4I2F30(Repr.WZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZXZ() => new Vector4I2F30(Repr.WZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZXW() => new Vector4I2F30(Repr.WZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZYX() => new Vector4I2F30(Repr.WZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZYY() => new Vector4I2F30(Repr.WZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZYZ() => new Vector4I2F30(Repr.WZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZYW() => new Vector4I2F30(Repr.WZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZZX() => new Vector4I2F30(Repr.WZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZZY() => new Vector4I2F30(Repr.WZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZZZ() => new Vector4I2F30(Repr.WZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZZW() => new Vector4I2F30(Repr.WZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZWX() => new Vector4I2F30(Repr.WZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZWY() => new Vector4I2F30(Repr.WZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZWZ() => new Vector4I2F30(Repr.WZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZWW() => new Vector4I2F30(Repr.WZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWXX() => new Vector4I2F30(Repr.WWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWXY() => new Vector4I2F30(Repr.WWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWXZ() => new Vector4I2F30(Repr.WWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWXW() => new Vector4I2F30(Repr.WWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWYX() => new Vector4I2F30(Repr.WWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWYY() => new Vector4I2F30(Repr.WWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWYZ() => new Vector4I2F30(Repr.WWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWYW() => new Vector4I2F30(Repr.WWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWZX() => new Vector4I2F30(Repr.WWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWZY() => new Vector4I2F30(Repr.WWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWZZ() => new Vector4I2F30(Repr.WWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWZW() => new Vector4I2F30(Repr.WWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWWX() => new Vector4I2F30(Repr.WWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWWY() => new Vector4I2F30(Repr.WWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWWZ() => new Vector4I2F30(Repr.WWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWWW() => new Vector4I2F30(Repr.WWWW());

    }
} // namespace AgatePris.Intar
