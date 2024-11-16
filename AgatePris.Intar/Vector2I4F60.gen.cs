using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
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
        public static bool operator ==(Vector2I4F60 lhs, Vector2I4F60 rhs) => lhs.Repr == rhs.Repr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2I4F60 lhs, Vector2I4F60 rhs) => lhs.Repr != rhs.Repr;

        //
        // Indexer
        //

        public I4F60 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I4F60.FromBits(Repr[index]);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr[index] = value.Bits;
        }

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

#endif // NET7_0_OR_GREATER

        //
        // Swizzling
        //

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

    }
} // // namespace AgatePris.Intar
