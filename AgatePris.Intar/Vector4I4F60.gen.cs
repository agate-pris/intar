using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct Vector4I4F60
    : IEquatable<Vector4I4F60>
    , IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector4Int64 Repr;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

#if NET7_0_OR_GREATER

        internal Vector4Int128 WideRepr {
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
        public I4F60 Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I4F60.FromBits(Repr.Z);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Z = value.Bits;
        }
        public I4F60 W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I4F60.FromBits(Repr.W);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.W = value.Bits;
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
        public Vector4I4F60(Vector4Int64 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F60(I4F60 x, I4F60 y, I4F60 z, I4F60 w) : this(new Vector4Int64(x.Bits, y.Bits, z.Bits, w.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F60(I4F60 value) : this(value, value, value, value) { }

        // Constants
        // ---------------------------------------

        public static readonly Vector4I4F60 Zero = new Vector4I4F60(I4F60.Zero);
        public static readonly Vector4I4F60 One = new Vector4I4F60(I4F60.One);
        public static readonly Vector4I4F60 UnitX = new Vector4I4F60(I4F60.One, I4F60.Zero, I4F60.Zero, I4F60.Zero);
        public static readonly Vector4I4F60 UnitY = new Vector4I4F60(I4F60.Zero, I4F60.One, I4F60.Zero, I4F60.Zero);
        public static readonly Vector4I4F60 UnitZ = new Vector4I4F60(I4F60.Zero, I4F60.Zero, I4F60.One, I4F60.Zero);
        public static readonly Vector4I4F60 UnitW = new Vector4I4F60(I4F60.Zero, I4F60.Zero, I4F60.Zero, I4F60.One);

        //
        // IAdditionOperators
        // ISubtractionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F60 operator +(Vector4I4F60 a, Vector4I4F60 b) {
            return new Vector4I4F60(a.Repr + b.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F60 operator -(Vector4I4F60 a, Vector4I4F60 b) {
            return new Vector4I4F60(a.Repr - b.Repr);
        }

#if NET7_0_OR_GREATER

        //
        // IIMultiplyOperators
        // IDivisionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F60 operator *(Vector4I4F60 a, Vector4I4F60 b) {
            return new Vector4I4F60((Vector4Int64)(a.WideRepr * b.WideRepr / I4F60.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F60 operator *(Vector4I4F60 a, I4F60 b) {
            return new Vector4I4F60((Vector4Int64)(a.WideRepr * b.Bits / I4F60.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F60 operator *(I4F60 a, Vector4I4F60 b) {
            return b * a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F60 operator /(Vector4I4F60 a, Vector4I4F60 b) {
            return new Vector4I4F60((Vector4Int64)(a.WideRepr * I4F60.OneRepr / b.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F60 operator /(Vector4I4F60 a, I4F60 b) {
            return new Vector4I4F60((Vector4Int64)(a.WideRepr * I4F60.OneRepr / b.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F60 operator /(I4F60 a, Vector4I4F60 b) {
            return new Vector4I4F60((Vector4Int64)(a.WideBits * I4F60.OneRepr / b.WideRepr));
        }

#endif // NET7_0_OR_GREATER

        //
        // IUnaryPlusOperators
        // IUnaryNegationOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F60 operator +(Vector4I4F60 x) {
            return new Vector4I4F60(+x.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I4F60 operator -(Vector4I4F60 x) {
            return new Vector4I4F60(-x.Repr);
        }

        //
        // IEqualityOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator ==(Vector4I4F60 lhs, Vector4I4F60 rhs) => lhs.Repr == rhs.Repr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(Vector4I4F60 lhs, Vector4I4F60 rhs) => lhs.Repr != rhs.Repr;

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector4I4F60 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        //
        // IEquatable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I4F60 other) {
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
        public Vector4I4F60 Min(Vector4I4F60 other) {
            return new Vector4I4F60(Repr.Min(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F60 Max(Vector4I4F60 other) {
            return new Vector4I4F60(Repr.Max(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F60 Abs() => new Vector4I4F60(Repr.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector4I4F60 Half() => new Vector4I4F60(Repr.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector4I4F60 Twice() => new Vector4I4F60(Repr.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F60 Clamp(I4F60 min, I4F60 max) {
            return new Vector4I4F60(Repr.Clamp(min.Bits, max.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I4F60 Clamp(Vector4I4F60 min, Vector4I4F60 max) {
            return new Vector4I4F60(Repr.Clamp(min.Repr, max.Repr));
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I8F120 UncheckedDot(Vector4I4F60 other) {
            return I8F120.FromBits(Repr.UncheckedDot(other.Repr));
        }

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U8F120 UncheckedLengthSquared() => U8F120.FromBits(Repr.UncheckedLengthSquared());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F60 UncheckedLength() => U4F60.FromBits(Repr.UncheckedLength());

#endif // NET7_0_OR_GREATER

        //
        // Swizzling
        //

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 XX() => new Vector2I4F60(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 XY() => new Vector2I4F60(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 XZ() => new Vector2I4F60(Repr.XZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 XW() => new Vector2I4F60(Repr.XW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 YX() => new Vector2I4F60(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 YY() => new Vector2I4F60(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 YZ() => new Vector2I4F60(Repr.YZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 YW() => new Vector2I4F60(Repr.YW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 ZX() => new Vector2I4F60(Repr.ZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 ZY() => new Vector2I4F60(Repr.ZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 ZZ() => new Vector2I4F60(Repr.ZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 ZW() => new Vector2I4F60(Repr.ZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 WX() => new Vector2I4F60(Repr.WX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 WY() => new Vector2I4F60(Repr.WY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 WZ() => new Vector2I4F60(Repr.WZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 WW() => new Vector2I4F60(Repr.WW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XXX() => new Vector3I4F60(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XXY() => new Vector3I4F60(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XXZ() => new Vector3I4F60(Repr.XXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XXW() => new Vector3I4F60(Repr.XXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XYX() => new Vector3I4F60(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XYY() => new Vector3I4F60(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XYZ() => new Vector3I4F60(Repr.XYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XYW() => new Vector3I4F60(Repr.XYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XZX() => new Vector3I4F60(Repr.XZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XZY() => new Vector3I4F60(Repr.XZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XZZ() => new Vector3I4F60(Repr.XZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XZW() => new Vector3I4F60(Repr.XZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XWX() => new Vector3I4F60(Repr.XWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XWY() => new Vector3I4F60(Repr.XWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XWZ() => new Vector3I4F60(Repr.XWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XWW() => new Vector3I4F60(Repr.XWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YXX() => new Vector3I4F60(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YXY() => new Vector3I4F60(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YXZ() => new Vector3I4F60(Repr.YXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YXW() => new Vector3I4F60(Repr.YXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YYX() => new Vector3I4F60(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YYY() => new Vector3I4F60(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YYZ() => new Vector3I4F60(Repr.YYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YYW() => new Vector3I4F60(Repr.YYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YZX() => new Vector3I4F60(Repr.YZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YZY() => new Vector3I4F60(Repr.YZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YZZ() => new Vector3I4F60(Repr.YZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YZW() => new Vector3I4F60(Repr.YZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YWX() => new Vector3I4F60(Repr.YWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YWY() => new Vector3I4F60(Repr.YWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YWZ() => new Vector3I4F60(Repr.YWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YWW() => new Vector3I4F60(Repr.YWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZXX() => new Vector3I4F60(Repr.ZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZXY() => new Vector3I4F60(Repr.ZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZXZ() => new Vector3I4F60(Repr.ZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZXW() => new Vector3I4F60(Repr.ZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZYX() => new Vector3I4F60(Repr.ZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZYY() => new Vector3I4F60(Repr.ZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZYZ() => new Vector3I4F60(Repr.ZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZYW() => new Vector3I4F60(Repr.ZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZZX() => new Vector3I4F60(Repr.ZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZZY() => new Vector3I4F60(Repr.ZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZZZ() => new Vector3I4F60(Repr.ZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZZW() => new Vector3I4F60(Repr.ZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZWX() => new Vector3I4F60(Repr.ZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZWY() => new Vector3I4F60(Repr.ZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZWZ() => new Vector3I4F60(Repr.ZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZWW() => new Vector3I4F60(Repr.ZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 WXX() => new Vector3I4F60(Repr.WXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 WXY() => new Vector3I4F60(Repr.WXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 WXZ() => new Vector3I4F60(Repr.WXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 WXW() => new Vector3I4F60(Repr.WXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 WYX() => new Vector3I4F60(Repr.WYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 WYY() => new Vector3I4F60(Repr.WYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 WYZ() => new Vector3I4F60(Repr.WYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 WYW() => new Vector3I4F60(Repr.WYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 WZX() => new Vector3I4F60(Repr.WZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 WZY() => new Vector3I4F60(Repr.WZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 WZZ() => new Vector3I4F60(Repr.WZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 WZW() => new Vector3I4F60(Repr.WZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 WWX() => new Vector3I4F60(Repr.WWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 WWY() => new Vector3I4F60(Repr.WWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 WWZ() => new Vector3I4F60(Repr.WWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 WWW() => new Vector3I4F60(Repr.WWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXXX() => new Vector4I4F60(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXXY() => new Vector4I4F60(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXXZ() => new Vector4I4F60(Repr.XXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXXW() => new Vector4I4F60(Repr.XXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXYX() => new Vector4I4F60(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXYY() => new Vector4I4F60(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXYZ() => new Vector4I4F60(Repr.XXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXYW() => new Vector4I4F60(Repr.XXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXZX() => new Vector4I4F60(Repr.XXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXZY() => new Vector4I4F60(Repr.XXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXZZ() => new Vector4I4F60(Repr.XXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXZW() => new Vector4I4F60(Repr.XXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXWX() => new Vector4I4F60(Repr.XXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXWY() => new Vector4I4F60(Repr.XXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXWZ() => new Vector4I4F60(Repr.XXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXWW() => new Vector4I4F60(Repr.XXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYXX() => new Vector4I4F60(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYXY() => new Vector4I4F60(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYXZ() => new Vector4I4F60(Repr.XYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYXW() => new Vector4I4F60(Repr.XYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYYX() => new Vector4I4F60(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYYY() => new Vector4I4F60(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYYZ() => new Vector4I4F60(Repr.XYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYYW() => new Vector4I4F60(Repr.XYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYZX() => new Vector4I4F60(Repr.XYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYZY() => new Vector4I4F60(Repr.XYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYZZ() => new Vector4I4F60(Repr.XYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYZW() => new Vector4I4F60(Repr.XYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYWX() => new Vector4I4F60(Repr.XYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYWY() => new Vector4I4F60(Repr.XYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYWZ() => new Vector4I4F60(Repr.XYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYWW() => new Vector4I4F60(Repr.XYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZXX() => new Vector4I4F60(Repr.XZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZXY() => new Vector4I4F60(Repr.XZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZXZ() => new Vector4I4F60(Repr.XZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZXW() => new Vector4I4F60(Repr.XZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZYX() => new Vector4I4F60(Repr.XZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZYY() => new Vector4I4F60(Repr.XZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZYZ() => new Vector4I4F60(Repr.XZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZYW() => new Vector4I4F60(Repr.XZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZZX() => new Vector4I4F60(Repr.XZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZZY() => new Vector4I4F60(Repr.XZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZZZ() => new Vector4I4F60(Repr.XZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZZW() => new Vector4I4F60(Repr.XZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZWX() => new Vector4I4F60(Repr.XZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZWY() => new Vector4I4F60(Repr.XZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZWZ() => new Vector4I4F60(Repr.XZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZWW() => new Vector4I4F60(Repr.XZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XWXX() => new Vector4I4F60(Repr.XWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XWXY() => new Vector4I4F60(Repr.XWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XWXZ() => new Vector4I4F60(Repr.XWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XWXW() => new Vector4I4F60(Repr.XWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XWYX() => new Vector4I4F60(Repr.XWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XWYY() => new Vector4I4F60(Repr.XWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XWYZ() => new Vector4I4F60(Repr.XWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XWYW() => new Vector4I4F60(Repr.XWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XWZX() => new Vector4I4F60(Repr.XWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XWZY() => new Vector4I4F60(Repr.XWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XWZZ() => new Vector4I4F60(Repr.XWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XWZW() => new Vector4I4F60(Repr.XWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XWWX() => new Vector4I4F60(Repr.XWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XWWY() => new Vector4I4F60(Repr.XWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XWWZ() => new Vector4I4F60(Repr.XWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XWWW() => new Vector4I4F60(Repr.XWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXXX() => new Vector4I4F60(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXXY() => new Vector4I4F60(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXXZ() => new Vector4I4F60(Repr.YXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXXW() => new Vector4I4F60(Repr.YXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXYX() => new Vector4I4F60(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXYY() => new Vector4I4F60(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXYZ() => new Vector4I4F60(Repr.YXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXYW() => new Vector4I4F60(Repr.YXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXZX() => new Vector4I4F60(Repr.YXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXZY() => new Vector4I4F60(Repr.YXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXZZ() => new Vector4I4F60(Repr.YXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXZW() => new Vector4I4F60(Repr.YXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXWX() => new Vector4I4F60(Repr.YXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXWY() => new Vector4I4F60(Repr.YXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXWZ() => new Vector4I4F60(Repr.YXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXWW() => new Vector4I4F60(Repr.YXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYXX() => new Vector4I4F60(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYXY() => new Vector4I4F60(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYXZ() => new Vector4I4F60(Repr.YYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYXW() => new Vector4I4F60(Repr.YYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYYX() => new Vector4I4F60(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYYY() => new Vector4I4F60(Repr.YYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYYZ() => new Vector4I4F60(Repr.YYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYYW() => new Vector4I4F60(Repr.YYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYZX() => new Vector4I4F60(Repr.YYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYZY() => new Vector4I4F60(Repr.YYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYZZ() => new Vector4I4F60(Repr.YYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYZW() => new Vector4I4F60(Repr.YYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYWX() => new Vector4I4F60(Repr.YYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYWY() => new Vector4I4F60(Repr.YYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYWZ() => new Vector4I4F60(Repr.YYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYWW() => new Vector4I4F60(Repr.YYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZXX() => new Vector4I4F60(Repr.YZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZXY() => new Vector4I4F60(Repr.YZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZXZ() => new Vector4I4F60(Repr.YZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZXW() => new Vector4I4F60(Repr.YZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZYX() => new Vector4I4F60(Repr.YZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZYY() => new Vector4I4F60(Repr.YZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZYZ() => new Vector4I4F60(Repr.YZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZYW() => new Vector4I4F60(Repr.YZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZZX() => new Vector4I4F60(Repr.YZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZZY() => new Vector4I4F60(Repr.YZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZZZ() => new Vector4I4F60(Repr.YZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZZW() => new Vector4I4F60(Repr.YZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZWX() => new Vector4I4F60(Repr.YZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZWY() => new Vector4I4F60(Repr.YZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZWZ() => new Vector4I4F60(Repr.YZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZWW() => new Vector4I4F60(Repr.YZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YWXX() => new Vector4I4F60(Repr.YWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YWXY() => new Vector4I4F60(Repr.YWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YWXZ() => new Vector4I4F60(Repr.YWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YWXW() => new Vector4I4F60(Repr.YWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YWYX() => new Vector4I4F60(Repr.YWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YWYY() => new Vector4I4F60(Repr.YWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YWYZ() => new Vector4I4F60(Repr.YWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YWYW() => new Vector4I4F60(Repr.YWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YWZX() => new Vector4I4F60(Repr.YWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YWZY() => new Vector4I4F60(Repr.YWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YWZZ() => new Vector4I4F60(Repr.YWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YWZW() => new Vector4I4F60(Repr.YWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YWWX() => new Vector4I4F60(Repr.YWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YWWY() => new Vector4I4F60(Repr.YWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YWWZ() => new Vector4I4F60(Repr.YWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YWWW() => new Vector4I4F60(Repr.YWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXXX() => new Vector4I4F60(Repr.ZXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXXY() => new Vector4I4F60(Repr.ZXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXXZ() => new Vector4I4F60(Repr.ZXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXXW() => new Vector4I4F60(Repr.ZXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXYX() => new Vector4I4F60(Repr.ZXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXYY() => new Vector4I4F60(Repr.ZXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXYZ() => new Vector4I4F60(Repr.ZXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXYW() => new Vector4I4F60(Repr.ZXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXZX() => new Vector4I4F60(Repr.ZXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXZY() => new Vector4I4F60(Repr.ZXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXZZ() => new Vector4I4F60(Repr.ZXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXZW() => new Vector4I4F60(Repr.ZXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXWX() => new Vector4I4F60(Repr.ZXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXWY() => new Vector4I4F60(Repr.ZXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXWZ() => new Vector4I4F60(Repr.ZXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXWW() => new Vector4I4F60(Repr.ZXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYXX() => new Vector4I4F60(Repr.ZYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYXY() => new Vector4I4F60(Repr.ZYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYXZ() => new Vector4I4F60(Repr.ZYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYXW() => new Vector4I4F60(Repr.ZYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYYX() => new Vector4I4F60(Repr.ZYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYYY() => new Vector4I4F60(Repr.ZYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYYZ() => new Vector4I4F60(Repr.ZYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYYW() => new Vector4I4F60(Repr.ZYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYZX() => new Vector4I4F60(Repr.ZYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYZY() => new Vector4I4F60(Repr.ZYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYZZ() => new Vector4I4F60(Repr.ZYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYZW() => new Vector4I4F60(Repr.ZYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYWX() => new Vector4I4F60(Repr.ZYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYWY() => new Vector4I4F60(Repr.ZYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYWZ() => new Vector4I4F60(Repr.ZYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYWW() => new Vector4I4F60(Repr.ZYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZXX() => new Vector4I4F60(Repr.ZZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZXY() => new Vector4I4F60(Repr.ZZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZXZ() => new Vector4I4F60(Repr.ZZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZXW() => new Vector4I4F60(Repr.ZZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZYX() => new Vector4I4F60(Repr.ZZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZYY() => new Vector4I4F60(Repr.ZZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZYZ() => new Vector4I4F60(Repr.ZZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZYW() => new Vector4I4F60(Repr.ZZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZZX() => new Vector4I4F60(Repr.ZZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZZY() => new Vector4I4F60(Repr.ZZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZZZ() => new Vector4I4F60(Repr.ZZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZZW() => new Vector4I4F60(Repr.ZZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZWX() => new Vector4I4F60(Repr.ZZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZWY() => new Vector4I4F60(Repr.ZZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZWZ() => new Vector4I4F60(Repr.ZZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZWW() => new Vector4I4F60(Repr.ZZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZWXX() => new Vector4I4F60(Repr.ZWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZWXY() => new Vector4I4F60(Repr.ZWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZWXZ() => new Vector4I4F60(Repr.ZWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZWXW() => new Vector4I4F60(Repr.ZWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZWYX() => new Vector4I4F60(Repr.ZWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZWYY() => new Vector4I4F60(Repr.ZWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZWYZ() => new Vector4I4F60(Repr.ZWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZWYW() => new Vector4I4F60(Repr.ZWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZWZX() => new Vector4I4F60(Repr.ZWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZWZY() => new Vector4I4F60(Repr.ZWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZWZZ() => new Vector4I4F60(Repr.ZWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZWZW() => new Vector4I4F60(Repr.ZWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZWWX() => new Vector4I4F60(Repr.ZWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZWWY() => new Vector4I4F60(Repr.ZWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZWWZ() => new Vector4I4F60(Repr.ZWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZWWW() => new Vector4I4F60(Repr.ZWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WXXX() => new Vector4I4F60(Repr.WXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WXXY() => new Vector4I4F60(Repr.WXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WXXZ() => new Vector4I4F60(Repr.WXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WXXW() => new Vector4I4F60(Repr.WXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WXYX() => new Vector4I4F60(Repr.WXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WXYY() => new Vector4I4F60(Repr.WXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WXYZ() => new Vector4I4F60(Repr.WXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WXYW() => new Vector4I4F60(Repr.WXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WXZX() => new Vector4I4F60(Repr.WXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WXZY() => new Vector4I4F60(Repr.WXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WXZZ() => new Vector4I4F60(Repr.WXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WXZW() => new Vector4I4F60(Repr.WXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WXWX() => new Vector4I4F60(Repr.WXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WXWY() => new Vector4I4F60(Repr.WXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WXWZ() => new Vector4I4F60(Repr.WXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WXWW() => new Vector4I4F60(Repr.WXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WYXX() => new Vector4I4F60(Repr.WYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WYXY() => new Vector4I4F60(Repr.WYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WYXZ() => new Vector4I4F60(Repr.WYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WYXW() => new Vector4I4F60(Repr.WYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WYYX() => new Vector4I4F60(Repr.WYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WYYY() => new Vector4I4F60(Repr.WYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WYYZ() => new Vector4I4F60(Repr.WYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WYYW() => new Vector4I4F60(Repr.WYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WYZX() => new Vector4I4F60(Repr.WYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WYZY() => new Vector4I4F60(Repr.WYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WYZZ() => new Vector4I4F60(Repr.WYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WYZW() => new Vector4I4F60(Repr.WYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WYWX() => new Vector4I4F60(Repr.WYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WYWY() => new Vector4I4F60(Repr.WYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WYWZ() => new Vector4I4F60(Repr.WYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WYWW() => new Vector4I4F60(Repr.WYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WZXX() => new Vector4I4F60(Repr.WZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WZXY() => new Vector4I4F60(Repr.WZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WZXZ() => new Vector4I4F60(Repr.WZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WZXW() => new Vector4I4F60(Repr.WZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WZYX() => new Vector4I4F60(Repr.WZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WZYY() => new Vector4I4F60(Repr.WZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WZYZ() => new Vector4I4F60(Repr.WZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WZYW() => new Vector4I4F60(Repr.WZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WZZX() => new Vector4I4F60(Repr.WZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WZZY() => new Vector4I4F60(Repr.WZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WZZZ() => new Vector4I4F60(Repr.WZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WZZW() => new Vector4I4F60(Repr.WZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WZWX() => new Vector4I4F60(Repr.WZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WZWY() => new Vector4I4F60(Repr.WZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WZWZ() => new Vector4I4F60(Repr.WZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WZWW() => new Vector4I4F60(Repr.WZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WWXX() => new Vector4I4F60(Repr.WWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WWXY() => new Vector4I4F60(Repr.WWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WWXZ() => new Vector4I4F60(Repr.WWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WWXW() => new Vector4I4F60(Repr.WWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WWYX() => new Vector4I4F60(Repr.WWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WWYY() => new Vector4I4F60(Repr.WWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WWYZ() => new Vector4I4F60(Repr.WWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WWYW() => new Vector4I4F60(Repr.WWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WWZX() => new Vector4I4F60(Repr.WWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WWZY() => new Vector4I4F60(Repr.WWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WWZZ() => new Vector4I4F60(Repr.WWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WWZW() => new Vector4I4F60(Repr.WWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WWWX() => new Vector4I4F60(Repr.WWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WWWY() => new Vector4I4F60(Repr.WWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WWWZ() => new Vector4I4F60(Repr.WWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 WWWW() => new Vector4I4F60(Repr.WWWW());

    }
} // namespace AgatePris.Intar
