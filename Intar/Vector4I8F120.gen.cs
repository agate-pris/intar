#if NET7_0_OR_GREATER

using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector4I8F120
    : IEquatable<Vector4I8F120>
    , IFormattable {
        #region Fields

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector4Int128 Repr;

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
        public I8F120 W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I8F120.FromBits(Repr.W);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.W = value.Bits;
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
        public static explicit operator System.Numerics.Vector4(Vector4I8F120 a) {
            return (System.Numerics.Vector4)a.Repr / (float)I8F120.OneRepr;
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector4(Vector4I8F120 a) {
            return (UnityEngine.Vector4)a.Repr / (float)I8F120.OneRepr;
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float4(Vector4I8F120 a) {
            return (Unity.Mathematics.float4)a.Repr / (float)I8F120.OneRepr;
        }
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        Vector4I8F120(Vector4Int128 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F120(I8F120 x, I8F120 y, I8F120 z, I8F120 w) : this(new Vector4Int128(x.Bits, y.Bits, z.Bits, w.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F120(I8F120 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F120 FromRepr(Vector4Int128 repr) {
            return new Vector4I8F120(repr);
        }
        #endregion
        #region Zero, One, NegativeOne, UnitX, UnitY, UnitZ, UnitW
        public static readonly Vector4I8F120 Zero = new Vector4I8F120(I8F120.Zero);
        public static readonly Vector4I8F120 One = new Vector4I8F120(I8F120.One);
        public static readonly Vector4I8F120 NegativeOne = new Vector4I8F120(I8F120.NegativeOne);
        public static readonly Vector4I8F120 UnitX = new Vector4I8F120(I8F120.One, I8F120.Zero, I8F120.Zero, I8F120.Zero);
        public static readonly Vector4I8F120 UnitY = new Vector4I8F120(I8F120.Zero, I8F120.One, I8F120.Zero, I8F120.Zero);
        public static readonly Vector4I8F120 UnitZ = new Vector4I8F120(I8F120.Zero, I8F120.Zero, I8F120.One, I8F120.Zero);
        public static readonly Vector4I8F120 UnitW = new Vector4I8F120(I8F120.Zero, I8F120.Zero, I8F120.Zero, I8F120.One);
        #endregion
        #region IAdditionOperators, ISubtractionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F120 operator +(Vector4I8F120 a, Vector4I8F120 b) {
            return new Vector4I8F120(a.Repr + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F120 operator +(I8F120 a, Vector4I8F120 b) {
            return new Vector4I8F120(a.Bits + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F120 operator +(Vector4I8F120 a, I8F120 b) {
            return new Vector4I8F120(a.Repr + b.Bits);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F120 operator -(Vector4I8F120 a, Vector4I8F120 b) {
            return new Vector4I8F120(a.Repr - b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F120 operator -(I8F120 a, Vector4I8F120 b) {
            return new Vector4I8F120(a.Bits - b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F120 operator -(Vector4I8F120 a, I8F120 b) {
            return new Vector4I8F120(a.Repr - b.Bits);
        }
        #endregion
        #region IUnaryPlusOperators, IUnaryNegationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F120 operator +(Vector4I8F120 x) {
            return new Vector4I8F120(+x.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I8F120 operator -(Vector4I8F120 x) {
            return new Vector4I8F120(-x.Repr);
        }
        #endregion
        #region IEqualityOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator ==(Vector4I8F120 lhs, Vector4I8F120 rhs) => lhs.Repr == rhs.Repr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(Vector4I8F120 lhs, Vector4I8F120 rhs) => lhs.Repr != rhs.Repr;
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is Vector4I8F120 o && Equals(o);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I8F120 other) {
            return Repr.Equals(other.Repr);
        }
        #endregion
        #region IFormattable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}, {Z.ToString(format, formatProvider)}, {W.ToString(format, formatProvider)}>";
        }
        #endregion
        #region Min, Max, Clamp
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F120 Min(Vector4I8F120 other) {
            return new Vector4I8F120(Repr.Min(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F120 Max(Vector4I8F120 other) {
            return new Vector4I8F120(Repr.Max(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F120 Clamp(I8F120 min, I8F120 max) {
            return new Vector4I8F120(Repr.Clamp(min.Bits, max.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F120 Clamp(Vector4I8F120 min, Vector4I8F120 max) {
            return new Vector4I8F120(Repr.Clamp(min.Repr, max.Repr));
        }
        #endregion
        #region IsNegative, Abs
        public Vector4Bool IsNegative() => Repr.IsNegative();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F120 Abs() => new Vector4I8F120(Repr.Abs());

        // 符号なし固定小数点数ベクトル型は定義されていないため
        // UnsignedAbs と AbsDiff は定義されない.
        #endregion
        #region Half, Twice
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector4I8F120 Half() => new Vector4I8F120(Repr.Half());
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector4I8F120 Twice() => new Vector4I8F120(Repr.Twice());
        #endregion
        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 X0() => Vector2I8F120.FromRepr(Repr.X0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 X1() => Vector2I8F120.FromRepr(Repr.X1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 XX() => Vector2I8F120.FromRepr(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 XY() => Vector2I8F120.FromRepr(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 XZ() => Vector2I8F120.FromRepr(Repr.XZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 XW() => Vector2I8F120.FromRepr(Repr.XW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 YX() => Vector2I8F120.FromRepr(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 YY() => Vector2I8F120.FromRepr(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 YZ() => Vector2I8F120.FromRepr(Repr.YZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 YW() => Vector2I8F120.FromRepr(Repr.YW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 ZX() => Vector2I8F120.FromRepr(Repr.ZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 ZY() => Vector2I8F120.FromRepr(Repr.ZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 ZZ() => Vector2I8F120.FromRepr(Repr.ZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 ZW() => Vector2I8F120.FromRepr(Repr.ZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 WX() => Vector2I8F120.FromRepr(Repr.WX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 WY() => Vector2I8F120.FromRepr(Repr.WY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 WZ() => Vector2I8F120.FromRepr(Repr.WZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 WW() => Vector2I8F120.FromRepr(Repr.WW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XY0() => Vector3I8F120.FromRepr(Repr.XY0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XY1() => Vector3I8F120.FromRepr(Repr.XY1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XXX() => Vector3I8F120.FromRepr(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XXY() => Vector3I8F120.FromRepr(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XXZ() => Vector3I8F120.FromRepr(Repr.XXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XXW() => Vector3I8F120.FromRepr(Repr.XXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XYX() => Vector3I8F120.FromRepr(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XYY() => Vector3I8F120.FromRepr(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XYZ() => Vector3I8F120.FromRepr(Repr.XYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XYW() => Vector3I8F120.FromRepr(Repr.XYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XZX() => Vector3I8F120.FromRepr(Repr.XZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XZY() => Vector3I8F120.FromRepr(Repr.XZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XZZ() => Vector3I8F120.FromRepr(Repr.XZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XZW() => Vector3I8F120.FromRepr(Repr.XZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XWX() => Vector3I8F120.FromRepr(Repr.XWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XWY() => Vector3I8F120.FromRepr(Repr.XWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XWZ() => Vector3I8F120.FromRepr(Repr.XWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XWW() => Vector3I8F120.FromRepr(Repr.XWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YXX() => Vector3I8F120.FromRepr(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YXY() => Vector3I8F120.FromRepr(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YXZ() => Vector3I8F120.FromRepr(Repr.YXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YXW() => Vector3I8F120.FromRepr(Repr.YXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YYX() => Vector3I8F120.FromRepr(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YYY() => Vector3I8F120.FromRepr(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YYZ() => Vector3I8F120.FromRepr(Repr.YYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YYW() => Vector3I8F120.FromRepr(Repr.YYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YZX() => Vector3I8F120.FromRepr(Repr.YZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YZY() => Vector3I8F120.FromRepr(Repr.YZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YZZ() => Vector3I8F120.FromRepr(Repr.YZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YZW() => Vector3I8F120.FromRepr(Repr.YZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YWX() => Vector3I8F120.FromRepr(Repr.YWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YWY() => Vector3I8F120.FromRepr(Repr.YWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YWZ() => Vector3I8F120.FromRepr(Repr.YWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YWW() => Vector3I8F120.FromRepr(Repr.YWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZXX() => Vector3I8F120.FromRepr(Repr.ZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZXY() => Vector3I8F120.FromRepr(Repr.ZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZXZ() => Vector3I8F120.FromRepr(Repr.ZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZXW() => Vector3I8F120.FromRepr(Repr.ZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZYX() => Vector3I8F120.FromRepr(Repr.ZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZYY() => Vector3I8F120.FromRepr(Repr.ZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZYZ() => Vector3I8F120.FromRepr(Repr.ZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZYW() => Vector3I8F120.FromRepr(Repr.ZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZZX() => Vector3I8F120.FromRepr(Repr.ZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZZY() => Vector3I8F120.FromRepr(Repr.ZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZZZ() => Vector3I8F120.FromRepr(Repr.ZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZZW() => Vector3I8F120.FromRepr(Repr.ZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZWX() => Vector3I8F120.FromRepr(Repr.ZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZWY() => Vector3I8F120.FromRepr(Repr.ZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZWZ() => Vector3I8F120.FromRepr(Repr.ZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZWW() => Vector3I8F120.FromRepr(Repr.ZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WXX() => Vector3I8F120.FromRepr(Repr.WXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WXY() => Vector3I8F120.FromRepr(Repr.WXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WXZ() => Vector3I8F120.FromRepr(Repr.WXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WXW() => Vector3I8F120.FromRepr(Repr.WXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WYX() => Vector3I8F120.FromRepr(Repr.WYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WYY() => Vector3I8F120.FromRepr(Repr.WYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WYZ() => Vector3I8F120.FromRepr(Repr.WYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WYW() => Vector3I8F120.FromRepr(Repr.WYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WZX() => Vector3I8F120.FromRepr(Repr.WZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WZY() => Vector3I8F120.FromRepr(Repr.WZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WZZ() => Vector3I8F120.FromRepr(Repr.WZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WZW() => Vector3I8F120.FromRepr(Repr.WZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WWX() => Vector3I8F120.FromRepr(Repr.WWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WWY() => Vector3I8F120.FromRepr(Repr.WWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WWZ() => Vector3I8F120.FromRepr(Repr.WWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WWW() => Vector3I8F120.FromRepr(Repr.WWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYZ0() => FromRepr(Repr.XYZ0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYZ1() => FromRepr(Repr.XYZ1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXXX() => FromRepr(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXXY() => FromRepr(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXXZ() => FromRepr(Repr.XXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXXW() => FromRepr(Repr.XXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXYX() => FromRepr(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXYY() => FromRepr(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXYZ() => FromRepr(Repr.XXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXYW() => FromRepr(Repr.XXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXZX() => FromRepr(Repr.XXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXZY() => FromRepr(Repr.XXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXZZ() => FromRepr(Repr.XXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXZW() => FromRepr(Repr.XXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXWX() => FromRepr(Repr.XXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXWY() => FromRepr(Repr.XXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXWZ() => FromRepr(Repr.XXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXWW() => FromRepr(Repr.XXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYXX() => FromRepr(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYXY() => FromRepr(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYXZ() => FromRepr(Repr.XYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYXW() => FromRepr(Repr.XYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYYX() => FromRepr(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYYY() => FromRepr(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYYZ() => FromRepr(Repr.XYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYYW() => FromRepr(Repr.XYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYZX() => FromRepr(Repr.XYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYZY() => FromRepr(Repr.XYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYZZ() => FromRepr(Repr.XYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYZW() => FromRepr(Repr.XYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYWX() => FromRepr(Repr.XYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYWY() => FromRepr(Repr.XYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYWZ() => FromRepr(Repr.XYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYWW() => FromRepr(Repr.XYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZXX() => FromRepr(Repr.XZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZXY() => FromRepr(Repr.XZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZXZ() => FromRepr(Repr.XZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZXW() => FromRepr(Repr.XZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZYX() => FromRepr(Repr.XZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZYY() => FromRepr(Repr.XZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZYZ() => FromRepr(Repr.XZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZYW() => FromRepr(Repr.XZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZZX() => FromRepr(Repr.XZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZZY() => FromRepr(Repr.XZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZZZ() => FromRepr(Repr.XZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZZW() => FromRepr(Repr.XZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZWX() => FromRepr(Repr.XZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZWY() => FromRepr(Repr.XZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZWZ() => FromRepr(Repr.XZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZWW() => FromRepr(Repr.XZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWXX() => FromRepr(Repr.XWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWXY() => FromRepr(Repr.XWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWXZ() => FromRepr(Repr.XWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWXW() => FromRepr(Repr.XWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWYX() => FromRepr(Repr.XWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWYY() => FromRepr(Repr.XWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWYZ() => FromRepr(Repr.XWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWYW() => FromRepr(Repr.XWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWZX() => FromRepr(Repr.XWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWZY() => FromRepr(Repr.XWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWZZ() => FromRepr(Repr.XWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWZW() => FromRepr(Repr.XWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWWX() => FromRepr(Repr.XWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWWY() => FromRepr(Repr.XWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWWZ() => FromRepr(Repr.XWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWWW() => FromRepr(Repr.XWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXXX() => FromRepr(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXXY() => FromRepr(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXXZ() => FromRepr(Repr.YXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXXW() => FromRepr(Repr.YXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXYX() => FromRepr(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXYY() => FromRepr(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXYZ() => FromRepr(Repr.YXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXYW() => FromRepr(Repr.YXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXZX() => FromRepr(Repr.YXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXZY() => FromRepr(Repr.YXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXZZ() => FromRepr(Repr.YXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXZW() => FromRepr(Repr.YXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXWX() => FromRepr(Repr.YXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXWY() => FromRepr(Repr.YXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXWZ() => FromRepr(Repr.YXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXWW() => FromRepr(Repr.YXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYXX() => FromRepr(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYXY() => FromRepr(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYXZ() => FromRepr(Repr.YYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYXW() => FromRepr(Repr.YYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYYX() => FromRepr(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYYY() => FromRepr(Repr.YYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYYZ() => FromRepr(Repr.YYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYYW() => FromRepr(Repr.YYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYZX() => FromRepr(Repr.YYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYZY() => FromRepr(Repr.YYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYZZ() => FromRepr(Repr.YYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYZW() => FromRepr(Repr.YYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYWX() => FromRepr(Repr.YYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYWY() => FromRepr(Repr.YYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYWZ() => FromRepr(Repr.YYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYWW() => FromRepr(Repr.YYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZXX() => FromRepr(Repr.YZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZXY() => FromRepr(Repr.YZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZXZ() => FromRepr(Repr.YZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZXW() => FromRepr(Repr.YZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZYX() => FromRepr(Repr.YZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZYY() => FromRepr(Repr.YZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZYZ() => FromRepr(Repr.YZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZYW() => FromRepr(Repr.YZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZZX() => FromRepr(Repr.YZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZZY() => FromRepr(Repr.YZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZZZ() => FromRepr(Repr.YZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZZW() => FromRepr(Repr.YZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZWX() => FromRepr(Repr.YZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZWY() => FromRepr(Repr.YZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZWZ() => FromRepr(Repr.YZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZWW() => FromRepr(Repr.YZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWXX() => FromRepr(Repr.YWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWXY() => FromRepr(Repr.YWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWXZ() => FromRepr(Repr.YWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWXW() => FromRepr(Repr.YWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWYX() => FromRepr(Repr.YWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWYY() => FromRepr(Repr.YWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWYZ() => FromRepr(Repr.YWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWYW() => FromRepr(Repr.YWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWZX() => FromRepr(Repr.YWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWZY() => FromRepr(Repr.YWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWZZ() => FromRepr(Repr.YWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWZW() => FromRepr(Repr.YWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWWX() => FromRepr(Repr.YWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWWY() => FromRepr(Repr.YWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWWZ() => FromRepr(Repr.YWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWWW() => FromRepr(Repr.YWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXXX() => FromRepr(Repr.ZXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXXY() => FromRepr(Repr.ZXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXXZ() => FromRepr(Repr.ZXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXXW() => FromRepr(Repr.ZXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXYX() => FromRepr(Repr.ZXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXYY() => FromRepr(Repr.ZXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXYZ() => FromRepr(Repr.ZXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXYW() => FromRepr(Repr.ZXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXZX() => FromRepr(Repr.ZXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXZY() => FromRepr(Repr.ZXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXZZ() => FromRepr(Repr.ZXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXZW() => FromRepr(Repr.ZXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXWX() => FromRepr(Repr.ZXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXWY() => FromRepr(Repr.ZXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXWZ() => FromRepr(Repr.ZXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXWW() => FromRepr(Repr.ZXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYXX() => FromRepr(Repr.ZYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYXY() => FromRepr(Repr.ZYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYXZ() => FromRepr(Repr.ZYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYXW() => FromRepr(Repr.ZYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYYX() => FromRepr(Repr.ZYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYYY() => FromRepr(Repr.ZYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYYZ() => FromRepr(Repr.ZYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYYW() => FromRepr(Repr.ZYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYZX() => FromRepr(Repr.ZYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYZY() => FromRepr(Repr.ZYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYZZ() => FromRepr(Repr.ZYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYZW() => FromRepr(Repr.ZYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYWX() => FromRepr(Repr.ZYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYWY() => FromRepr(Repr.ZYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYWZ() => FromRepr(Repr.ZYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYWW() => FromRepr(Repr.ZYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZXX() => FromRepr(Repr.ZZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZXY() => FromRepr(Repr.ZZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZXZ() => FromRepr(Repr.ZZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZXW() => FromRepr(Repr.ZZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZYX() => FromRepr(Repr.ZZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZYY() => FromRepr(Repr.ZZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZYZ() => FromRepr(Repr.ZZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZYW() => FromRepr(Repr.ZZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZZX() => FromRepr(Repr.ZZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZZY() => FromRepr(Repr.ZZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZZZ() => FromRepr(Repr.ZZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZZW() => FromRepr(Repr.ZZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZWX() => FromRepr(Repr.ZZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZWY() => FromRepr(Repr.ZZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZWZ() => FromRepr(Repr.ZZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZWW() => FromRepr(Repr.ZZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWXX() => FromRepr(Repr.ZWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWXY() => FromRepr(Repr.ZWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWXZ() => FromRepr(Repr.ZWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWXW() => FromRepr(Repr.ZWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWYX() => FromRepr(Repr.ZWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWYY() => FromRepr(Repr.ZWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWYZ() => FromRepr(Repr.ZWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWYW() => FromRepr(Repr.ZWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWZX() => FromRepr(Repr.ZWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWZY() => FromRepr(Repr.ZWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWZZ() => FromRepr(Repr.ZWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWZW() => FromRepr(Repr.ZWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWWX() => FromRepr(Repr.ZWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWWY() => FromRepr(Repr.ZWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWWZ() => FromRepr(Repr.ZWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWWW() => FromRepr(Repr.ZWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXXX() => FromRepr(Repr.WXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXXY() => FromRepr(Repr.WXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXXZ() => FromRepr(Repr.WXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXXW() => FromRepr(Repr.WXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXYX() => FromRepr(Repr.WXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXYY() => FromRepr(Repr.WXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXYZ() => FromRepr(Repr.WXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXYW() => FromRepr(Repr.WXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXZX() => FromRepr(Repr.WXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXZY() => FromRepr(Repr.WXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXZZ() => FromRepr(Repr.WXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXZW() => FromRepr(Repr.WXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXWX() => FromRepr(Repr.WXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXWY() => FromRepr(Repr.WXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXWZ() => FromRepr(Repr.WXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXWW() => FromRepr(Repr.WXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYXX() => FromRepr(Repr.WYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYXY() => FromRepr(Repr.WYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYXZ() => FromRepr(Repr.WYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYXW() => FromRepr(Repr.WYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYYX() => FromRepr(Repr.WYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYYY() => FromRepr(Repr.WYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYYZ() => FromRepr(Repr.WYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYYW() => FromRepr(Repr.WYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYZX() => FromRepr(Repr.WYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYZY() => FromRepr(Repr.WYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYZZ() => FromRepr(Repr.WYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYZW() => FromRepr(Repr.WYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYWX() => FromRepr(Repr.WYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYWY() => FromRepr(Repr.WYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYWZ() => FromRepr(Repr.WYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYWW() => FromRepr(Repr.WYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZXX() => FromRepr(Repr.WZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZXY() => FromRepr(Repr.WZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZXZ() => FromRepr(Repr.WZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZXW() => FromRepr(Repr.WZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZYX() => FromRepr(Repr.WZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZYY() => FromRepr(Repr.WZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZYZ() => FromRepr(Repr.WZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZYW() => FromRepr(Repr.WZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZZX() => FromRepr(Repr.WZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZZY() => FromRepr(Repr.WZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZZZ() => FromRepr(Repr.WZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZZW() => FromRepr(Repr.WZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZWX() => FromRepr(Repr.WZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZWY() => FromRepr(Repr.WZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZWZ() => FromRepr(Repr.WZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZWW() => FromRepr(Repr.WZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWXX() => FromRepr(Repr.WWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWXY() => FromRepr(Repr.WWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWXZ() => FromRepr(Repr.WWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWXW() => FromRepr(Repr.WWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWYX() => FromRepr(Repr.WWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWYY() => FromRepr(Repr.WWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWYZ() => FromRepr(Repr.WWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWYW() => FromRepr(Repr.WWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWZX() => FromRepr(Repr.WWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWZY() => FromRepr(Repr.WWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWZZ() => FromRepr(Repr.WWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWZW() => FromRepr(Repr.WWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWWX() => FromRepr(Repr.WWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWWY() => FromRepr(Repr.WWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWWZ() => FromRepr(Repr.WWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWWW() => FromRepr(Repr.WWWW());
        #endregion
    }
} // namespace Intar

#endif // NET7_0_OR_GREATER
