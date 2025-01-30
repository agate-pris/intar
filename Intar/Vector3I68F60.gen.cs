#if NET7_0_OR_GREATER

using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector3I68F60
    : IEquatable<Vector3I68F60>
    , IFormattable {
        #region Fields

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector3Int128 Repr;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        #region Components
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
        #endregion
        #region Indexer
        public I68F60 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I68F60.FromBits(Repr[index]);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr[index] = value.Bits;
        }
        #endregion
        #region Conversion
        public static explicit operator System.Numerics.Vector3(Vector3I68F60 a) {
            return (System.Numerics.Vector3)a.Repr / (float)I68F60.OneRepr;
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector3(Vector3I68F60 a) {
            return (UnityEngine.Vector3)a.Repr / (float)I68F60.OneRepr;
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float3(Vector3I68F60 a) {
            return (Unity.Mathematics.float3)a.Repr / (float)I68F60.OneRepr;
        }
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        Vector3I68F60(Vector3Int128 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I68F60(I68F60 x, I68F60 y, I68F60 z) : this(new Vector3Int128(x.Bits, y.Bits, z.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I68F60(I68F60 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I68F60 FromRepr(Vector3Int128 repr) {
            return new Vector3I68F60(repr);
        }
        #endregion
        #region Zero, One, NegativeOne, UnitX, UnitY, UnitZ
        public static readonly Vector3I68F60 Zero = new Vector3I68F60(I68F60.Zero);
        public static readonly Vector3I68F60 One = new Vector3I68F60(I68F60.One);
        public static readonly Vector3I68F60 NegativeOne = new Vector3I68F60(I68F60.NegativeOne);
        public static readonly Vector3I68F60 UnitX = new Vector3I68F60(I68F60.One, I68F60.Zero, I68F60.Zero);
        public static readonly Vector3I68F60 UnitY = new Vector3I68F60(I68F60.Zero, I68F60.One, I68F60.Zero);
        public static readonly Vector3I68F60 UnitZ = new Vector3I68F60(I68F60.Zero, I68F60.Zero, I68F60.One);
        #endregion
        #region IAdditionOperators, ISubtractionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I68F60 operator +(Vector3I68F60 a, Vector3I68F60 b) {
            return new Vector3I68F60(a.Repr + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I68F60 operator +(I68F60 a, Vector3I68F60 b) {
            return new Vector3I68F60(a.Bits + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I68F60 operator +(Vector3I68F60 a, I68F60 b) {
            return new Vector3I68F60(a.Repr + b.Bits);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I68F60 operator -(Vector3I68F60 a, Vector3I68F60 b) {
            return new Vector3I68F60(a.Repr - b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I68F60 operator -(I68F60 a, Vector3I68F60 b) {
            return new Vector3I68F60(a.Bits - b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I68F60 operator -(Vector3I68F60 a, I68F60 b) {
            return new Vector3I68F60(a.Repr - b.Bits);
        }
        #endregion
        #region IUnaryPlusOperators, IUnaryNegationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I68F60 operator +(Vector3I68F60 x) {
            return new Vector3I68F60(+x.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I68F60 operator -(Vector3I68F60 x) {
            return new Vector3I68F60(-x.Repr);
        }
        #endregion
        #region IEqualityOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3I68F60 lhs, Vector3I68F60 rhs) => lhs.Repr == rhs.Repr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3I68F60 lhs, Vector3I68F60 rhs) => lhs.Repr != rhs.Repr;
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is Vector3I68F60 o && Equals(o);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I68F60 other) {
            return Repr.Equals(other.Repr);
        }
        #endregion
        #region IFormattable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}, {Z.ToString(format, formatProvider)}>";
        }
        #endregion
        #region Min, Max, Clamp
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I68F60 Min(Vector3I68F60 other) {
            return new Vector3I68F60(Repr.Min(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I68F60 Max(Vector3I68F60 other) {
            return new Vector3I68F60(Repr.Max(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I68F60 Clamp(I68F60 min, I68F60 max) {
            return new Vector3I68F60(Repr.Clamp(min.Bits, max.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I68F60 Clamp(Vector3I68F60 min, Vector3I68F60 max) {
            return new Vector3I68F60(Repr.Clamp(min.Repr, max.Repr));
        }
        #endregion
        #region IsNegative, Abs
        public Vector3Bool IsNegative() => Repr.IsNegative();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I68F60 Abs() => new Vector3I68F60(Repr.Abs());

        // 符号なし固定小数点数ベクトル型は定義されていないため
        // UnsignedAbs と AbsDiff は定義されない.
        #endregion
        #region Half, Twice
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I68F60 Half() => new Vector3I68F60(Repr.Half());
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I68F60 Twice() => new Vector3I68F60(Repr.Twice());
        #endregion
        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 X0() => Vector2I68F60.FromRepr(Repr.X0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 X1() => Vector2I68F60.FromRepr(Repr.X1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 XX() => Vector2I68F60.FromRepr(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 XY() => Vector2I68F60.FromRepr(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 XZ() => Vector2I68F60.FromRepr(Repr.XZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 YX() => Vector2I68F60.FromRepr(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 YY() => Vector2I68F60.FromRepr(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 YZ() => Vector2I68F60.FromRepr(Repr.YZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 ZX() => Vector2I68F60.FromRepr(Repr.ZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 ZY() => Vector2I68F60.FromRepr(Repr.ZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 ZZ() => Vector2I68F60.FromRepr(Repr.ZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XY0() => FromRepr(Repr.XY0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XY1() => FromRepr(Repr.XY1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XXX() => FromRepr(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XXY() => FromRepr(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XXZ() => FromRepr(Repr.XXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XYX() => FromRepr(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XYY() => FromRepr(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XYZ() => FromRepr(Repr.XYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XZX() => FromRepr(Repr.XZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XZY() => FromRepr(Repr.XZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XZZ() => FromRepr(Repr.XZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YXX() => FromRepr(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YXY() => FromRepr(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YXZ() => FromRepr(Repr.YXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YYX() => FromRepr(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YYY() => FromRepr(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YYZ() => FromRepr(Repr.YYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YZX() => FromRepr(Repr.YZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YZY() => FromRepr(Repr.YZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YZZ() => FromRepr(Repr.YZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZXX() => FromRepr(Repr.ZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZXY() => FromRepr(Repr.ZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZXZ() => FromRepr(Repr.ZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZYX() => FromRepr(Repr.ZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZYY() => FromRepr(Repr.ZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZYZ() => FromRepr(Repr.ZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZZX() => FromRepr(Repr.ZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZZY() => FromRepr(Repr.ZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZZZ() => FromRepr(Repr.ZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYZ0() => Vector4I68F60.FromRepr(Repr.XYZ0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYZ1() => Vector4I68F60.FromRepr(Repr.XYZ1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXXX() => Vector4I68F60.FromRepr(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXXY() => Vector4I68F60.FromRepr(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXXZ() => Vector4I68F60.FromRepr(Repr.XXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXYX() => Vector4I68F60.FromRepr(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXYY() => Vector4I68F60.FromRepr(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXYZ() => Vector4I68F60.FromRepr(Repr.XXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXZX() => Vector4I68F60.FromRepr(Repr.XXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXZY() => Vector4I68F60.FromRepr(Repr.XXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXZZ() => Vector4I68F60.FromRepr(Repr.XXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYXX() => Vector4I68F60.FromRepr(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYXY() => Vector4I68F60.FromRepr(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYXZ() => Vector4I68F60.FromRepr(Repr.XYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYYX() => Vector4I68F60.FromRepr(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYYY() => Vector4I68F60.FromRepr(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYYZ() => Vector4I68F60.FromRepr(Repr.XYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYZX() => Vector4I68F60.FromRepr(Repr.XYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYZY() => Vector4I68F60.FromRepr(Repr.XYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYZZ() => Vector4I68F60.FromRepr(Repr.XYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZXX() => Vector4I68F60.FromRepr(Repr.XZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZXY() => Vector4I68F60.FromRepr(Repr.XZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZXZ() => Vector4I68F60.FromRepr(Repr.XZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZYX() => Vector4I68F60.FromRepr(Repr.XZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZYY() => Vector4I68F60.FromRepr(Repr.XZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZYZ() => Vector4I68F60.FromRepr(Repr.XZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZZX() => Vector4I68F60.FromRepr(Repr.XZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZZY() => Vector4I68F60.FromRepr(Repr.XZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZZZ() => Vector4I68F60.FromRepr(Repr.XZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXXX() => Vector4I68F60.FromRepr(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXXY() => Vector4I68F60.FromRepr(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXXZ() => Vector4I68F60.FromRepr(Repr.YXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXYX() => Vector4I68F60.FromRepr(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXYY() => Vector4I68F60.FromRepr(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXYZ() => Vector4I68F60.FromRepr(Repr.YXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXZX() => Vector4I68F60.FromRepr(Repr.YXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXZY() => Vector4I68F60.FromRepr(Repr.YXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXZZ() => Vector4I68F60.FromRepr(Repr.YXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYXX() => Vector4I68F60.FromRepr(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYXY() => Vector4I68F60.FromRepr(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYXZ() => Vector4I68F60.FromRepr(Repr.YYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYYX() => Vector4I68F60.FromRepr(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYYY() => Vector4I68F60.FromRepr(Repr.YYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYYZ() => Vector4I68F60.FromRepr(Repr.YYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYZX() => Vector4I68F60.FromRepr(Repr.YYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYZY() => Vector4I68F60.FromRepr(Repr.YYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYZZ() => Vector4I68F60.FromRepr(Repr.YYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZXX() => Vector4I68F60.FromRepr(Repr.YZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZXY() => Vector4I68F60.FromRepr(Repr.YZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZXZ() => Vector4I68F60.FromRepr(Repr.YZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZYX() => Vector4I68F60.FromRepr(Repr.YZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZYY() => Vector4I68F60.FromRepr(Repr.YZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZYZ() => Vector4I68F60.FromRepr(Repr.YZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZZX() => Vector4I68F60.FromRepr(Repr.YZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZZY() => Vector4I68F60.FromRepr(Repr.YZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZZZ() => Vector4I68F60.FromRepr(Repr.YZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXXX() => Vector4I68F60.FromRepr(Repr.ZXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXXY() => Vector4I68F60.FromRepr(Repr.ZXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXXZ() => Vector4I68F60.FromRepr(Repr.ZXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXYX() => Vector4I68F60.FromRepr(Repr.ZXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXYY() => Vector4I68F60.FromRepr(Repr.ZXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXYZ() => Vector4I68F60.FromRepr(Repr.ZXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXZX() => Vector4I68F60.FromRepr(Repr.ZXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXZY() => Vector4I68F60.FromRepr(Repr.ZXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXZZ() => Vector4I68F60.FromRepr(Repr.ZXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYXX() => Vector4I68F60.FromRepr(Repr.ZYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYXY() => Vector4I68F60.FromRepr(Repr.ZYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYXZ() => Vector4I68F60.FromRepr(Repr.ZYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYYX() => Vector4I68F60.FromRepr(Repr.ZYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYYY() => Vector4I68F60.FromRepr(Repr.ZYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYYZ() => Vector4I68F60.FromRepr(Repr.ZYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYZX() => Vector4I68F60.FromRepr(Repr.ZYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYZY() => Vector4I68F60.FromRepr(Repr.ZYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYZZ() => Vector4I68F60.FromRepr(Repr.ZYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZXX() => Vector4I68F60.FromRepr(Repr.ZZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZXY() => Vector4I68F60.FromRepr(Repr.ZZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZXZ() => Vector4I68F60.FromRepr(Repr.ZZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZYX() => Vector4I68F60.FromRepr(Repr.ZZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZYY() => Vector4I68F60.FromRepr(Repr.ZZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZYZ() => Vector4I68F60.FromRepr(Repr.ZZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZZX() => Vector4I68F60.FromRepr(Repr.ZZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZZY() => Vector4I68F60.FromRepr(Repr.ZZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZZZ() => Vector4I68F60.FromRepr(Repr.ZZZZ());
        #endregion
    }
} // namespace Intar

#endif // NET7_0_OR_GREATER
