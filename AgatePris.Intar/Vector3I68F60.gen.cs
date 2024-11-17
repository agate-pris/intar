#if NET7_0_OR_GREATER

using System;
using System.Runtime.CompilerServices;

namespace AgatePris.Intar {
    [Serializable]
    public struct Vector3I68F60
    : IEquatable<Vector3I68F60>
    , IFormattable {
        // Fields
        // ---------------------------------------

#if NET5_0_OR_GREATER
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector3Int128 Repr;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public I68F60 X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I68F60.FromBits(Repr.X);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.X = value.Bits;
        }
        public I68F60 Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I68F60.FromBits(Repr.Y);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Y = value.Bits;
        }
        public I68F60 Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I68F60.FromBits(Repr.Z);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Z = value.Bits;
        }

        public I68F60 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I68F60.FromBits(Repr[index]);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr[index] = value.Bits;
        }

        // Constructors
        // ---------------------------------------

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I68F60(Vector3Int128 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I68F60(I68F60 x, I68F60 y, I68F60 z) : this(new Vector3Int128(x.Bits, y.Bits, z.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I68F60(I68F60 value) : this(value, value, value) { }

        // Constants
        // ---------------------------------------

        public static readonly Vector3I68F60 Zero = new Vector3I68F60(I68F60.Zero);
        public static readonly Vector3I68F60 One = new Vector3I68F60(I68F60.One);
        public static readonly Vector3I68F60 UnitX = new Vector3I68F60(I68F60.One, I68F60.Zero, I68F60.Zero);
        public static readonly Vector3I68F60 UnitY = new Vector3I68F60(I68F60.Zero, I68F60.One, I68F60.Zero);
        public static readonly Vector3I68F60 UnitZ = new Vector3I68F60(I68F60.Zero, I68F60.Zero, I68F60.One);

        //
        // IAdditionOperators
        // ISubtractionOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I68F60 operator +(Vector3I68F60 a, Vector3I68F60 b) {
            return new Vector3I68F60(a.Repr + b.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I68F60 operator -(Vector3I68F60 a, Vector3I68F60 b) {
            return new Vector3I68F60(a.Repr - b.Repr);
        }

        //
        // IUnaryPlusOperators
        // IUnaryNegationOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I68F60 operator +(Vector3I68F60 x) {
            return new Vector3I68F60(+x.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I68F60 operator -(Vector3I68F60 x) {
            return new Vector3I68F60(-x.Repr);
        }

        //
        // IEqualityOperators
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3I68F60 lhs, Vector3I68F60 rhs) => lhs.Repr == rhs.Repr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3I68F60 lhs, Vector3I68F60 rhs) => lhs.Repr != rhs.Repr;

        //
        // Derived from INumberBase
        //

        public Vector3Bool IsNegative() => Repr.IsNegative();

        //
        // Object
        //

        public override bool Equals(object obj) => obj is Vector3I68F60 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        //
        // IEquatable
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I68F60 other) {
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
        public Vector3I68F60 Min(Vector3I68F60 other) {
            return new Vector3I68F60(Repr.Min(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I68F60 Max(Vector3I68F60 other) {
            return new Vector3I68F60(Repr.Max(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I68F60 Abs() => new Vector3I68F60(Repr.Abs());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I68F60 Half() => new Vector3I68F60(Repr.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I68F60 Twice() => new Vector3I68F60(Repr.Twice());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I68F60 Clamp(I68F60 min, I68F60 max) {
            return new Vector3I68F60(Repr.Clamp(min.Bits, max.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I68F60 Clamp(Vector3I68F60 min, Vector3I68F60 max) {
            return new Vector3I68F60(Repr.Clamp(min.Repr, max.Repr));
        }

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 XX() => new Vector2I68F60(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 XY() => new Vector2I68F60(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 XZ() => new Vector2I68F60(Repr.XZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 YX() => new Vector2I68F60(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 YY() => new Vector2I68F60(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 YZ() => new Vector2I68F60(Repr.YZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 ZX() => new Vector2I68F60(Repr.ZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 ZY() => new Vector2I68F60(Repr.ZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 ZZ() => new Vector2I68F60(Repr.ZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XXX() => new Vector3I68F60(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XXY() => new Vector3I68F60(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XXZ() => new Vector3I68F60(Repr.XXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XYX() => new Vector3I68F60(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XYY() => new Vector3I68F60(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XYZ() => new Vector3I68F60(Repr.XYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XZX() => new Vector3I68F60(Repr.XZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XZY() => new Vector3I68F60(Repr.XZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XZZ() => new Vector3I68F60(Repr.XZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YXX() => new Vector3I68F60(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YXY() => new Vector3I68F60(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YXZ() => new Vector3I68F60(Repr.YXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YYX() => new Vector3I68F60(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YYY() => new Vector3I68F60(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YYZ() => new Vector3I68F60(Repr.YYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YZX() => new Vector3I68F60(Repr.YZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YZY() => new Vector3I68F60(Repr.YZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YZZ() => new Vector3I68F60(Repr.YZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZXX() => new Vector3I68F60(Repr.ZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZXY() => new Vector3I68F60(Repr.ZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZXZ() => new Vector3I68F60(Repr.ZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZYX() => new Vector3I68F60(Repr.ZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZYY() => new Vector3I68F60(Repr.ZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZYZ() => new Vector3I68F60(Repr.ZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZZX() => new Vector3I68F60(Repr.ZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZZY() => new Vector3I68F60(Repr.ZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZZZ() => new Vector3I68F60(Repr.ZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXXX() => new Vector4I68F60(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXXY() => new Vector4I68F60(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXXZ() => new Vector4I68F60(Repr.XXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXYX() => new Vector4I68F60(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXYY() => new Vector4I68F60(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXYZ() => new Vector4I68F60(Repr.XXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXZX() => new Vector4I68F60(Repr.XXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXZY() => new Vector4I68F60(Repr.XXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXZZ() => new Vector4I68F60(Repr.XXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYXX() => new Vector4I68F60(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYXY() => new Vector4I68F60(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYXZ() => new Vector4I68F60(Repr.XYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYYX() => new Vector4I68F60(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYYY() => new Vector4I68F60(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYYZ() => new Vector4I68F60(Repr.XYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYZX() => new Vector4I68F60(Repr.XYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYZY() => new Vector4I68F60(Repr.XYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYZZ() => new Vector4I68F60(Repr.XYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZXX() => new Vector4I68F60(Repr.XZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZXY() => new Vector4I68F60(Repr.XZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZXZ() => new Vector4I68F60(Repr.XZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZYX() => new Vector4I68F60(Repr.XZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZYY() => new Vector4I68F60(Repr.XZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZYZ() => new Vector4I68F60(Repr.XZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZZX() => new Vector4I68F60(Repr.XZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZZY() => new Vector4I68F60(Repr.XZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZZZ() => new Vector4I68F60(Repr.XZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXXX() => new Vector4I68F60(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXXY() => new Vector4I68F60(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXXZ() => new Vector4I68F60(Repr.YXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXYX() => new Vector4I68F60(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXYY() => new Vector4I68F60(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXYZ() => new Vector4I68F60(Repr.YXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXZX() => new Vector4I68F60(Repr.YXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXZY() => new Vector4I68F60(Repr.YXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXZZ() => new Vector4I68F60(Repr.YXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYXX() => new Vector4I68F60(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYXY() => new Vector4I68F60(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYXZ() => new Vector4I68F60(Repr.YYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYYX() => new Vector4I68F60(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYYY() => new Vector4I68F60(Repr.YYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYYZ() => new Vector4I68F60(Repr.YYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYZX() => new Vector4I68F60(Repr.YYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYZY() => new Vector4I68F60(Repr.YYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYZZ() => new Vector4I68F60(Repr.YYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZXX() => new Vector4I68F60(Repr.YZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZXY() => new Vector4I68F60(Repr.YZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZXZ() => new Vector4I68F60(Repr.YZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZYX() => new Vector4I68F60(Repr.YZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZYY() => new Vector4I68F60(Repr.YZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZYZ() => new Vector4I68F60(Repr.YZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZZX() => new Vector4I68F60(Repr.YZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZZY() => new Vector4I68F60(Repr.YZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZZZ() => new Vector4I68F60(Repr.YZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXXX() => new Vector4I68F60(Repr.ZXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXXY() => new Vector4I68F60(Repr.ZXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXXZ() => new Vector4I68F60(Repr.ZXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXYX() => new Vector4I68F60(Repr.ZXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXYY() => new Vector4I68F60(Repr.ZXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXYZ() => new Vector4I68F60(Repr.ZXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXZX() => new Vector4I68F60(Repr.ZXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXZY() => new Vector4I68F60(Repr.ZXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXZZ() => new Vector4I68F60(Repr.ZXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYXX() => new Vector4I68F60(Repr.ZYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYXY() => new Vector4I68F60(Repr.ZYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYXZ() => new Vector4I68F60(Repr.ZYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYYX() => new Vector4I68F60(Repr.ZYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYYY() => new Vector4I68F60(Repr.ZYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYYZ() => new Vector4I68F60(Repr.ZYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYZX() => new Vector4I68F60(Repr.ZYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYZY() => new Vector4I68F60(Repr.ZYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYZZ() => new Vector4I68F60(Repr.ZYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZXX() => new Vector4I68F60(Repr.ZZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZXY() => new Vector4I68F60(Repr.ZZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZXZ() => new Vector4I68F60(Repr.ZZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZYX() => new Vector4I68F60(Repr.ZZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZYY() => new Vector4I68F60(Repr.ZZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZYZ() => new Vector4I68F60(Repr.ZZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZZX() => new Vector4I68F60(Repr.ZZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZZY() => new Vector4I68F60(Repr.ZZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZZZ() => new Vector4I68F60(Repr.ZZZZ());

        #endregion

    }
} // namespace AgatePris.Intar

#endif // NET7_0_OR_GREATER
