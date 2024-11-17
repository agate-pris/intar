using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct Vector2I34F30
    : IEquatable<Vector2I34F30>
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

        public I34F30 X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I34F30.FromBits(Repr.X);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.X = value.Bits;
        }
        public I34F30 Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I34F30.FromBits(Repr.Y);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Y = value.Bits;
        }

        public I34F30 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I34F30.FromBits(Repr[index]);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr[index] = value.Bits;
        }

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I34F30(Vector2Int64 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I34F30(I34F30 x, I34F30 y) : this(new Vector2Int64(x.Bits, y.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I34F30(I34F30 value) : this(value, value) { }

        // Constants
        // ---------------------------------------

        public static readonly Vector2I34F30 Zero = new Vector2I34F30(I34F30.Zero);
        public static readonly Vector2I34F30 One = new Vector2I34F30(I34F30.One);
        public static readonly Vector2I34F30 UnitX = new Vector2I34F30(I34F30.One, I34F30.Zero);
        public static readonly Vector2I34F30 UnitY = new Vector2I34F30(I34F30.Zero, I34F30.One);

        //
        // IAdditionOperators
        // ISubtractionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator +(Vector2I34F30 a, Vector2I34F30 b) {
            return new Vector2I34F30(a.Repr + b.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator -(Vector2I34F30 a, Vector2I34F30 b) {
            return new Vector2I34F30(a.Repr - b.Repr);
        }

#if NET7_0_OR_GREATER

        //
        // IIMultiplyOperators
        // IDivisionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator *(Vector2I34F30 a, Vector2I34F30 b) {
            return new Vector2I34F30((Vector2Int64)(a.WideRepr * b.WideRepr / I34F30.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator *(Vector2I34F30 a, I34F30 b) {
            return new Vector2I34F30((Vector2Int64)(a.WideRepr * b.Bits / I34F30.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator *(I34F30 a, Vector2I34F30 b) {
            return b * a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator /(Vector2I34F30 a, Vector2I34F30 b) {
            return new Vector2I34F30((Vector2Int64)(a.WideRepr * I34F30.OneRepr / b.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator /(Vector2I34F30 a, I34F30 b) {
            return new Vector2I34F30((Vector2Int64)(a.WideRepr * I34F30.OneRepr / b.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator /(I34F30 a, Vector2I34F30 b) {
            return new Vector2I34F30((Vector2Int64)(a.WideBits * I34F30.OneRepr / b.WideRepr));
        }

#endif // NET7_0_OR_GREATER

        //
        // IUnaryPlusOperators
        // IUnaryNegationOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator +(Vector2I34F30 x) {
            return new Vector2I34F30(+x.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator -(Vector2I34F30 x) {
            return new Vector2I34F30(-x.Repr);
        }

        //
        // IEqualityOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(Vector2I34F30 lhs, Vector2I34F30 rhs) => lhs.Repr == rhs.Repr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2I34F30 lhs, Vector2I34F30 rhs) => lhs.Repr != rhs.Repr;

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector2I34F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        //
        // IEquatable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2I34F30 other) {
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
        public Vector2I34F30 Min(Vector2I34F30 other) {
            return new Vector2I34F30(Repr.Min(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I34F30 Max(Vector2I34F30 other) {
            return new Vector2I34F30(Repr.Max(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I34F30 Abs() => new Vector2I34F30(Repr.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector2I34F30 Half() => new Vector2I34F30(Repr.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector2I34F30 Twice() => new Vector2I34F30(Repr.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I34F30 Clamp(I34F30 min, I34F30 max) {
            return new Vector2I34F30(Repr.Clamp(min.Bits, max.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I34F30 Clamp(Vector2I34F30 min, Vector2I34F30 max) {
            return new Vector2I34F30(Repr.Clamp(min.Repr, max.Repr));
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I68F60 UncheckedDot(Vector2I34F30 other) {
            return I68F60.FromBits(Repr.UncheckedDot(other.Repr));
        }

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U68F60 LengthSquared() => U68F60.FromBits(Repr.LengthSquared());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 Length() => U34F30.FromBits(Repr.Length());

#endif // NET7_0_OR_GREATER

        //
        // Swizzling
        //

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 XX() => new Vector2I34F30(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 XY() => new Vector2I34F30(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 YX() => new Vector2I34F30(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 YY() => new Vector2I34F30(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XXX() => new Vector3I34F30(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XXY() => new Vector3I34F30(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XYX() => new Vector3I34F30(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XYY() => new Vector3I34F30(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YXX() => new Vector3I34F30(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YXY() => new Vector3I34F30(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YYX() => new Vector3I34F30(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YYY() => new Vector3I34F30(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXXX() => new Vector4I34F30(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXXY() => new Vector4I34F30(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXYX() => new Vector4I34F30(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXYY() => new Vector4I34F30(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYXX() => new Vector4I34F30(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYXY() => new Vector4I34F30(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYYX() => new Vector4I34F30(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYYY() => new Vector4I34F30(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXXX() => new Vector4I34F30(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXXY() => new Vector4I34F30(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXYX() => new Vector4I34F30(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXYY() => new Vector4I34F30(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYXX() => new Vector4I34F30(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYXY() => new Vector4I34F30(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYYX() => new Vector4I34F30(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYYY() => new Vector4I34F30(Repr.YYYY());

    }
} // namespace AgatePris.Intar
