using System;
using System.Runtime.CompilerServices;

namespace Intar1991 {
    [Serializable]
    public struct Vector2I4F60
    : IEquatable<Vector2I4F60>
    , IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector2Int64 Repr;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

#if NET7_0_OR_GREATER

        internal Vector2Int128 WideRepr {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Repr;
        }

#endif // NET7_0_OR_GREATER

        public I4F60 X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I4F60.FromBits(Repr.X);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.X = value.Bits;
        }
        public I4F60 Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I4F60.FromBits(Repr.Y);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Y = value.Bits;
        }

        public I4F60 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I4F60.FromBits(Repr[index]);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr[index] = value.Bits;
        }

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F60(Vector2Int64 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F60(I4F60 x, I4F60 y) : this(new Vector2Int64(x.Bits, y.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F60(I4F60 value) : this(value, value) { }

        // Constants
        // ---------------------------------------

        public static readonly Vector2I4F60 Zero = new Vector2I4F60(I4F60.Zero);
        public static readonly Vector2I4F60 One = new Vector2I4F60(I4F60.One);
        public static readonly Vector2I4F60 UnitX = new Vector2I4F60(I4F60.One, I4F60.Zero);
        public static readonly Vector2I4F60 UnitY = new Vector2I4F60(I4F60.Zero, I4F60.One);

        //
        // IAdditionOperators
        // ISubtractionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F60 operator +(Vector2I4F60 a, Vector2I4F60 b) {
            return new Vector2I4F60(a.Repr + b.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F60 operator -(Vector2I4F60 a, Vector2I4F60 b) {
            return new Vector2I4F60(a.Repr - b.Repr);
        }

#if NET7_0_OR_GREATER

        //
        // IIMultiplyOperators
        // IDivisionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F60 operator *(Vector2I4F60 a, Vector2I4F60 b) {
            return new Vector2I4F60((Vector2Int64)(a.WideRepr * b.WideRepr / I4F60.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F60 operator *(Vector2I4F60 a, I4F60 b) {
            return new Vector2I4F60((Vector2Int64)(a.WideRepr * b.Bits / I4F60.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F60 operator *(I4F60 a, Vector2I4F60 b) {
            return b * a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F60 operator /(Vector2I4F60 a, Vector2I4F60 b) {
            return new Vector2I4F60((Vector2Int64)(a.WideRepr * I4F60.OneRepr / b.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F60 operator /(Vector2I4F60 a, I4F60 b) {
            return new Vector2I4F60((Vector2Int64)(a.WideRepr * I4F60.OneRepr / b.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F60 operator /(I4F60 a, Vector2I4F60 b) {
            return new Vector2I4F60((Vector2Int64)(a.WideBits * I4F60.OneRepr / b.WideRepr));
        }

#endif // NET7_0_OR_GREATER

        //
        // IUnaryPlusOperators
        // IUnaryNegationOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F60 operator +(Vector2I4F60 x) {
            return new Vector2I4F60(+x.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I4F60 operator -(Vector2I4F60 x) {
            return new Vector2I4F60(-x.Repr);
        }

        //
        // IEqualityOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(Vector2I4F60 lhs, Vector2I4F60 rhs) => lhs.Repr == rhs.Repr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2I4F60 lhs, Vector2I4F60 rhs) => lhs.Repr != rhs.Repr;

        //
        // Derived from INumberBase
        //

        public Vector2Bool IsNegative() => Repr.IsNegative();

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector2I4F60 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        //
        // IEquatable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2I4F60 other) {
            return Repr.Equals(other.Repr);
        }

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}>";
        }

        //
        // Methods
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F60 Min(Vector2I4F60 other) {
            return new Vector2I4F60(Repr.Min(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F60 Max(Vector2I4F60 other) {
            return new Vector2I4F60(Repr.Max(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F60 Abs() => new Vector2I4F60(Repr.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector2I4F60 Half() => new Vector2I4F60(Repr.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector2I4F60 Twice() => new Vector2I4F60(Repr.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F60 Clamp(I4F60 min, I4F60 max) {
            return new Vector2I4F60(Repr.Clamp(min.Bits, max.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F60 Clamp(Vector2I4F60 min, Vector2I4F60 max) {
            return new Vector2I4F60(Repr.Clamp(min.Repr, max.Repr));
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I8F120 UncheckedDot(Vector2I4F60 other) {
            return I8F120.FromBits(Repr.UncheckedDot(other.Repr));
        }

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U8F120 LengthSquared() => U8F120.FromBits(Repr.LengthSquared());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F60 Length() => U4F60.FromBits(Repr.Length());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I4F60? Normalize() {

            // 各要素の内部表現型を取り出し、
            // その絶対値を得る。

            var isNegative = IsNegative();
            var abs = new Vector2UInt64(
                unchecked((ulong)(isNegative.X ? Overflowing.WrappingNeg(Repr.X) : Repr.X)),
                unchecked((ulong)(isNegative.Y ? Overflowing.WrappingNeg(Repr.Y) : Repr.Y))
            );

            // 各要素の最大値が 0 の場合は null を返す。

            var max = Math.Max(abs.X, abs.Y);
            if (max == 0) {
                return null;
            }

            // ベクトルの大きさが小さい時の誤差を小さくするため、
            // 最大の要素が表現型の範囲に収まるように拡大する。
            // 最大の要素以外にも同じ値を乗算する。
            // 剰余の回数を減らすため、
            // 先に型の最大値を最大値で割っておき、それを乗算する。

            var scaled = abs * (ulong.MaxValue / max);
            var sqrDiv4 = scaled.BigMul(scaled) / 4;
            var halfLength = Mathi.Sqrt(sqrDiv4.X + sqrDiv4.Y);

            const ulong fracOneTwo = I4F60.OneRepr / 2;
            var absNormalized = (Vector2Int64)(scaled.BigMul(fracOneTwo) / halfLength);

            return new Vector2I4F60(new Vector2Int64(
                isNegative.X ? -absNormalized.X : absNormalized.X,
                isNegative.Y ? -absNormalized.Y : absNormalized.Y
            ));
        }

#endif // NET7_0_OR_GREATER

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 XX() => new Vector2I4F60(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 XY() => new Vector2I4F60(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 YX() => new Vector2I4F60(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 YY() => new Vector2I4F60(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XXX() => new Vector3I4F60(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XXY() => new Vector3I4F60(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XYX() => new Vector3I4F60(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XYY() => new Vector3I4F60(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YXX() => new Vector3I4F60(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YXY() => new Vector3I4F60(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YYX() => new Vector3I4F60(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YYY() => new Vector3I4F60(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXXX() => new Vector4I4F60(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXXY() => new Vector4I4F60(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXYX() => new Vector4I4F60(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXYY() => new Vector4I4F60(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYXX() => new Vector4I4F60(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYXY() => new Vector4I4F60(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYYX() => new Vector4I4F60(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYYY() => new Vector4I4F60(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXXX() => new Vector4I4F60(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXXY() => new Vector4I4F60(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXYX() => new Vector4I4F60(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXYY() => new Vector4I4F60(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYXX() => new Vector4I4F60(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYXY() => new Vector4I4F60(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYYX() => new Vector4I4F60(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYYY() => new Vector4I4F60(Repr.YYYY());

        #endregion

    }
} // namespace Intar1991
