using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct Vector3I34F30
    : IEquatable<Vector3I34F30>
    , IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector3Int64 Repr;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

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
        public I34F30 Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I34F30.FromBits(Repr.Z);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Z = value.Bits;
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
        public Vector3I34F30(Vector3Int64 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I34F30(I34F30 x, I34F30 y, I34F30 z) : this(new Vector3Int64(x.Bits, y.Bits, z.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I34F30(I34F30 value) : this(value, value, value) { }

        // Constants
        // ---------------------------------------

        public static readonly Vector3I34F30 Zero = new Vector3I34F30(I34F30.Zero);
        public static readonly Vector3I34F30 One = new Vector3I34F30(I34F30.One);
        public static readonly Vector3I34F30 UnitX = new Vector3I34F30(I34F30.One, I34F30.Zero, I34F30.Zero);
        public static readonly Vector3I34F30 UnitY = new Vector3I34F30(I34F30.Zero, I34F30.One, I34F30.Zero);
        public static readonly Vector3I34F30 UnitZ = new Vector3I34F30(I34F30.Zero, I34F30.Zero, I34F30.One);

        //
        // IAdditionOperators
        // ISubtractionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I34F30 operator +(Vector3I34F30 a, Vector3I34F30 b) {
            return new Vector3I34F30(a.Repr + b.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I34F30 operator -(Vector3I34F30 a, Vector3I34F30 b) {
            return new Vector3I34F30(a.Repr - b.Repr);
        }

        //
        // IUnaryPlusOperators
        // IUnaryNegationOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I34F30 operator +(Vector3I34F30 x) {
            return new Vector3I34F30(+x.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I34F30 operator -(Vector3I34F30 x) {
            return new Vector3I34F30(-x.Repr);
        }

        //
        // IEqualityOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3I34F30 lhs, Vector3I34F30 rhs) => lhs.Repr == rhs.Repr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3I34F30 lhs, Vector3I34F30 rhs) => lhs.Repr != rhs.Repr;

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector3I34F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        //
        // IEquatable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I34F30 other) {
            return Repr.Equals(other.Repr);
        }

        // IFormattable
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}, {Z.ToString(format, formatProvider)}>";
        }

        //
        // Methods
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I34F30 Min(Vector3I34F30 other) {
            return new Vector3I34F30(Repr.Min(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I34F30 Max(Vector3I34F30 other) {
            return new Vector3I34F30(Repr.Max(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I34F30 Abs() => new Vector3I34F30(Repr.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I34F30 Half() => new Vector3I34F30(Repr.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I34F30 Twice() => new Vector3I34F30(Repr.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I34F30 Clamp(I34F30 min, I34F30 max) {
            return new Vector3I34F30(Repr.Clamp(min.Bits, max.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I34F30 Clamp(Vector3I34F30 min, Vector3I34F30 max) {
            return new Vector3I34F30(Repr.Clamp(min.Repr, max.Repr));
        }

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I68F60 Cross(Vector3I34F30 other) {
            var tmp = Repr.Cross(other.Repr);
            return new Vector3I68F60(tmp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I68F60 UncheckedDot(Vector3I34F30 other) {
            return I68F60.FromBits(Repr.UncheckedDot(other.Repr));
        }

#endif // NET7_0_OR_GREATER

        //
        // Swizzling
        //

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 XX() => new Vector2I34F30(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 XY() => new Vector2I34F30(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 XZ() => new Vector2I34F30(Repr.XZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 YX() => new Vector2I34F30(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 YY() => new Vector2I34F30(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 YZ() => new Vector2I34F30(Repr.YZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 ZX() => new Vector2I34F30(Repr.ZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 ZY() => new Vector2I34F30(Repr.ZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 ZZ() => new Vector2I34F30(Repr.ZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XXX() => new Vector3I34F30(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XXY() => new Vector3I34F30(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XXZ() => new Vector3I34F30(Repr.XXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XYX() => new Vector3I34F30(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XYY() => new Vector3I34F30(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XYZ() => new Vector3I34F30(Repr.XYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XZX() => new Vector3I34F30(Repr.XZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XZY() => new Vector3I34F30(Repr.XZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XZZ() => new Vector3I34F30(Repr.XZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YXX() => new Vector3I34F30(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YXY() => new Vector3I34F30(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YXZ() => new Vector3I34F30(Repr.YXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YYX() => new Vector3I34F30(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YYY() => new Vector3I34F30(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YYZ() => new Vector3I34F30(Repr.YYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YZX() => new Vector3I34F30(Repr.YZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YZY() => new Vector3I34F30(Repr.YZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YZZ() => new Vector3I34F30(Repr.YZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZXX() => new Vector3I34F30(Repr.ZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZXY() => new Vector3I34F30(Repr.ZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZXZ() => new Vector3I34F30(Repr.ZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZYX() => new Vector3I34F30(Repr.ZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZYY() => new Vector3I34F30(Repr.ZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZYZ() => new Vector3I34F30(Repr.ZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZZX() => new Vector3I34F30(Repr.ZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZZY() => new Vector3I34F30(Repr.ZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZZZ() => new Vector3I34F30(Repr.ZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXXX() => new Vector4I34F30(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXXY() => new Vector4I34F30(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXXZ() => new Vector4I34F30(Repr.XXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXYX() => new Vector4I34F30(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXYY() => new Vector4I34F30(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXYZ() => new Vector4I34F30(Repr.XXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXZX() => new Vector4I34F30(Repr.XXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXZY() => new Vector4I34F30(Repr.XXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXZZ() => new Vector4I34F30(Repr.XXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYXX() => new Vector4I34F30(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYXY() => new Vector4I34F30(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYXZ() => new Vector4I34F30(Repr.XYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYYX() => new Vector4I34F30(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYYY() => new Vector4I34F30(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYYZ() => new Vector4I34F30(Repr.XYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYZX() => new Vector4I34F30(Repr.XYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYZY() => new Vector4I34F30(Repr.XYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYZZ() => new Vector4I34F30(Repr.XYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZXX() => new Vector4I34F30(Repr.XZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZXY() => new Vector4I34F30(Repr.XZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZXZ() => new Vector4I34F30(Repr.XZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZYX() => new Vector4I34F30(Repr.XZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZYY() => new Vector4I34F30(Repr.XZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZYZ() => new Vector4I34F30(Repr.XZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZZX() => new Vector4I34F30(Repr.XZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZZY() => new Vector4I34F30(Repr.XZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZZZ() => new Vector4I34F30(Repr.XZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXXX() => new Vector4I34F30(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXXY() => new Vector4I34F30(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXXZ() => new Vector4I34F30(Repr.YXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXYX() => new Vector4I34F30(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXYY() => new Vector4I34F30(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXYZ() => new Vector4I34F30(Repr.YXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXZX() => new Vector4I34F30(Repr.YXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXZY() => new Vector4I34F30(Repr.YXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXZZ() => new Vector4I34F30(Repr.YXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYXX() => new Vector4I34F30(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYXY() => new Vector4I34F30(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYXZ() => new Vector4I34F30(Repr.YYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYYX() => new Vector4I34F30(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYYY() => new Vector4I34F30(Repr.YYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYYZ() => new Vector4I34F30(Repr.YYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYZX() => new Vector4I34F30(Repr.YYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYZY() => new Vector4I34F30(Repr.YYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYZZ() => new Vector4I34F30(Repr.YYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZXX() => new Vector4I34F30(Repr.YZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZXY() => new Vector4I34F30(Repr.YZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZXZ() => new Vector4I34F30(Repr.YZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZYX() => new Vector4I34F30(Repr.YZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZYY() => new Vector4I34F30(Repr.YZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZYZ() => new Vector4I34F30(Repr.YZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZZX() => new Vector4I34F30(Repr.YZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZZY() => new Vector4I34F30(Repr.YZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZZZ() => new Vector4I34F30(Repr.YZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXXX() => new Vector4I34F30(Repr.ZXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXXY() => new Vector4I34F30(Repr.ZXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXXZ() => new Vector4I34F30(Repr.ZXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXYX() => new Vector4I34F30(Repr.ZXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXYY() => new Vector4I34F30(Repr.ZXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXYZ() => new Vector4I34F30(Repr.ZXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXZX() => new Vector4I34F30(Repr.ZXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXZY() => new Vector4I34F30(Repr.ZXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXZZ() => new Vector4I34F30(Repr.ZXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYXX() => new Vector4I34F30(Repr.ZYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYXY() => new Vector4I34F30(Repr.ZYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYXZ() => new Vector4I34F30(Repr.ZYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYYX() => new Vector4I34F30(Repr.ZYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYYY() => new Vector4I34F30(Repr.ZYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYYZ() => new Vector4I34F30(Repr.ZYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYZX() => new Vector4I34F30(Repr.ZYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYZY() => new Vector4I34F30(Repr.ZYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYZZ() => new Vector4I34F30(Repr.ZYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZXX() => new Vector4I34F30(Repr.ZZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZXY() => new Vector4I34F30(Repr.ZZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZXZ() => new Vector4I34F30(Repr.ZZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZYX() => new Vector4I34F30(Repr.ZZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZYY() => new Vector4I34F30(Repr.ZZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZYZ() => new Vector4I34F30(Repr.ZZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZZX() => new Vector4I34F30(Repr.ZZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZZY() => new Vector4I34F30(Repr.ZZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZZZ() => new Vector4I34F30(Repr.ZZZZ());

    }
} // namespace AgatePris.Intar
