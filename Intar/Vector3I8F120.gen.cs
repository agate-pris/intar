#if NET7_0_OR_GREATER

using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector3I8F120
    : IEquatable<Vector3I8F120>
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
        public I8F120 X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I8F120.FromBits(Repr.X);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.X = value.Bits;
        }
        public I8F120 Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I8F120.FromBits(Repr.Y);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Y = value.Bits;
        }
        public I8F120 Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I8F120.FromBits(Repr.Z);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Z = value.Bits;
        }
        #endregion
        #region Indexer
        public I8F120 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I8F120.FromBits(Repr[index]);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr[index] = value.Bits;
        }
        #endregion
        #region Conversion
        public static explicit operator System.Numerics.Vector3(Vector3I8F120 a) {
            return (System.Numerics.Vector3)a.Repr / (float)I8F120.OneRepr;
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector3(Vector3I8F120 a) {
            return (UnityEngine.Vector3)a.Repr / (float)I8F120.OneRepr;
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float3(Vector3I8F120 a) {
            return (Unity.Mathematics.float3)a.Repr / (float)I8F120.OneRepr;
        }
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I8F120(Vector3Int128 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F120(I8F120 x, I8F120 y, I8F120 z) : this(new Vector3Int128(x.Bits, y.Bits, z.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F120(I8F120 value) : this(value, value, value) { }
        #endregion
        #region Zero, One, UnitX, UnitY, UnitZ
        public static readonly Vector3I8F120 Zero = new Vector3I8F120(I8F120.Zero);
        public static readonly Vector3I8F120 One = new Vector3I8F120(I8F120.One);
        public static readonly Vector3I8F120 UnitX = new Vector3I8F120(I8F120.One, I8F120.Zero, I8F120.Zero);
        public static readonly Vector3I8F120 UnitY = new Vector3I8F120(I8F120.Zero, I8F120.One, I8F120.Zero);
        public static readonly Vector3I8F120 UnitZ = new Vector3I8F120(I8F120.Zero, I8F120.Zero, I8F120.One);
        #endregion
        #region IAdditionOperators, ISubtractionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F120 operator +(Vector3I8F120 a, Vector3I8F120 b) {
            return new Vector3I8F120(a.Repr + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F120 operator -(Vector3I8F120 a, Vector3I8F120 b) {
            return new Vector3I8F120(a.Repr - b.Repr);
        }
        #endregion
        #region IUnaryPlusOperators, IUnaryNegationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F120 operator +(Vector3I8F120 x) {
            return new Vector3I8F120(+x.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I8F120 operator -(Vector3I8F120 x) {
            return new Vector3I8F120(-x.Repr);
        }
        #endregion
        #region IEqualityOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3I8F120 lhs, Vector3I8F120 rhs) => lhs.Repr == rhs.Repr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3I8F120 lhs, Vector3I8F120 rhs) => lhs.Repr != rhs.Repr;
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is Vector3I8F120 o && Equals(o);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I8F120 other) {
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
        public Vector3I8F120 Min(Vector3I8F120 other) {
            return new Vector3I8F120(Repr.Min(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F120 Max(Vector3I8F120 other) {
            return new Vector3I8F120(Repr.Max(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F120 Clamp(I8F120 min, I8F120 max) {
            return new Vector3I8F120(Repr.Clamp(min.Bits, max.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F120 Clamp(Vector3I8F120 min, Vector3I8F120 max) {
            return new Vector3I8F120(Repr.Clamp(min.Repr, max.Repr));
        }
        #endregion
        #region IsNegative, Abs
        public Vector3Bool IsNegative() => Repr.IsNegative();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F120 Abs() => new Vector3I8F120(Repr.Abs());
        #endregion
        #region Half, Twice
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I8F120 Half() => new Vector3I8F120(Repr.Half());
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I8F120 Twice() => new Vector3I8F120(Repr.Twice());
        #endregion
        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 XX() => new Vector2I8F120(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 XY() => new Vector2I8F120(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 XZ() => new Vector2I8F120(Repr.XZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 YX() => new Vector2I8F120(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 YY() => new Vector2I8F120(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 YZ() => new Vector2I8F120(Repr.YZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 ZX() => new Vector2I8F120(Repr.ZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 ZY() => new Vector2I8F120(Repr.ZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 ZZ() => new Vector2I8F120(Repr.ZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XXX() => new Vector3I8F120(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XXY() => new Vector3I8F120(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XXZ() => new Vector3I8F120(Repr.XXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XYX() => new Vector3I8F120(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XYY() => new Vector3I8F120(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XYZ() => new Vector3I8F120(Repr.XYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XZX() => new Vector3I8F120(Repr.XZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XZY() => new Vector3I8F120(Repr.XZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XZZ() => new Vector3I8F120(Repr.XZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YXX() => new Vector3I8F120(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YXY() => new Vector3I8F120(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YXZ() => new Vector3I8F120(Repr.YXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YYX() => new Vector3I8F120(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YYY() => new Vector3I8F120(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YYZ() => new Vector3I8F120(Repr.YYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YZX() => new Vector3I8F120(Repr.YZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YZY() => new Vector3I8F120(Repr.YZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YZZ() => new Vector3I8F120(Repr.YZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZXX() => new Vector3I8F120(Repr.ZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZXY() => new Vector3I8F120(Repr.ZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZXZ() => new Vector3I8F120(Repr.ZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZYX() => new Vector3I8F120(Repr.ZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZYY() => new Vector3I8F120(Repr.ZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZYZ() => new Vector3I8F120(Repr.ZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZZX() => new Vector3I8F120(Repr.ZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZZY() => new Vector3I8F120(Repr.ZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZZZ() => new Vector3I8F120(Repr.ZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXXX() => new Vector4I8F120(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXXY() => new Vector4I8F120(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXXZ() => new Vector4I8F120(Repr.XXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXYX() => new Vector4I8F120(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXYY() => new Vector4I8F120(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXYZ() => new Vector4I8F120(Repr.XXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXZX() => new Vector4I8F120(Repr.XXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXZY() => new Vector4I8F120(Repr.XXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXZZ() => new Vector4I8F120(Repr.XXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYXX() => new Vector4I8F120(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYXY() => new Vector4I8F120(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYXZ() => new Vector4I8F120(Repr.XYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYYX() => new Vector4I8F120(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYYY() => new Vector4I8F120(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYYZ() => new Vector4I8F120(Repr.XYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYZX() => new Vector4I8F120(Repr.XYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYZY() => new Vector4I8F120(Repr.XYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYZZ() => new Vector4I8F120(Repr.XYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZXX() => new Vector4I8F120(Repr.XZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZXY() => new Vector4I8F120(Repr.XZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZXZ() => new Vector4I8F120(Repr.XZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZYX() => new Vector4I8F120(Repr.XZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZYY() => new Vector4I8F120(Repr.XZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZYZ() => new Vector4I8F120(Repr.XZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZZX() => new Vector4I8F120(Repr.XZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZZY() => new Vector4I8F120(Repr.XZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZZZ() => new Vector4I8F120(Repr.XZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXXX() => new Vector4I8F120(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXXY() => new Vector4I8F120(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXXZ() => new Vector4I8F120(Repr.YXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXYX() => new Vector4I8F120(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXYY() => new Vector4I8F120(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXYZ() => new Vector4I8F120(Repr.YXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXZX() => new Vector4I8F120(Repr.YXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXZY() => new Vector4I8F120(Repr.YXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXZZ() => new Vector4I8F120(Repr.YXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYXX() => new Vector4I8F120(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYXY() => new Vector4I8F120(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYXZ() => new Vector4I8F120(Repr.YYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYYX() => new Vector4I8F120(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYYY() => new Vector4I8F120(Repr.YYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYYZ() => new Vector4I8F120(Repr.YYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYZX() => new Vector4I8F120(Repr.YYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYZY() => new Vector4I8F120(Repr.YYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYZZ() => new Vector4I8F120(Repr.YYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZXX() => new Vector4I8F120(Repr.YZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZXY() => new Vector4I8F120(Repr.YZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZXZ() => new Vector4I8F120(Repr.YZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZYX() => new Vector4I8F120(Repr.YZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZYY() => new Vector4I8F120(Repr.YZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZYZ() => new Vector4I8F120(Repr.YZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZZX() => new Vector4I8F120(Repr.YZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZZY() => new Vector4I8F120(Repr.YZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZZZ() => new Vector4I8F120(Repr.YZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXXX() => new Vector4I8F120(Repr.ZXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXXY() => new Vector4I8F120(Repr.ZXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXXZ() => new Vector4I8F120(Repr.ZXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXYX() => new Vector4I8F120(Repr.ZXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXYY() => new Vector4I8F120(Repr.ZXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXYZ() => new Vector4I8F120(Repr.ZXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXZX() => new Vector4I8F120(Repr.ZXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXZY() => new Vector4I8F120(Repr.ZXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXZZ() => new Vector4I8F120(Repr.ZXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYXX() => new Vector4I8F120(Repr.ZYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYXY() => new Vector4I8F120(Repr.ZYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYXZ() => new Vector4I8F120(Repr.ZYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYYX() => new Vector4I8F120(Repr.ZYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYYY() => new Vector4I8F120(Repr.ZYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYYZ() => new Vector4I8F120(Repr.ZYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYZX() => new Vector4I8F120(Repr.ZYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYZY() => new Vector4I8F120(Repr.ZYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYZZ() => new Vector4I8F120(Repr.ZYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZXX() => new Vector4I8F120(Repr.ZZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZXY() => new Vector4I8F120(Repr.ZZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZXZ() => new Vector4I8F120(Repr.ZZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZYX() => new Vector4I8F120(Repr.ZZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZYY() => new Vector4I8F120(Repr.ZZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZYZ() => new Vector4I8F120(Repr.ZZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZZX() => new Vector4I8F120(Repr.ZZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZZY() => new Vector4I8F120(Repr.ZZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZZZ() => new Vector4I8F120(Repr.ZZZZ());
        #endregion
    }
} // namespace Intar

#endif // NET7_0_OR_GREATER
