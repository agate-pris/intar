#if NET7_0_OR_GREATER

using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector4I68F60
    : IEquatable<Vector4I68F60>
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
        public I68F60 W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I68F60.FromBits(Repr.W);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.W = value.Bits;
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
        public static explicit operator System.Numerics.Vector4(Vector4I68F60 a) {
            return (System.Numerics.Vector4)a.Repr / (float)I68F60.OneRepr;
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector4(Vector4I68F60 a) {
            return (UnityEngine.Vector4)a.Repr / (float)I68F60.OneRepr;
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float4(Vector4I68F60 a) {
            return (Unity.Mathematics.float4)a.Repr / (float)I68F60.OneRepr;
        }
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        Vector4I68F60(Vector4Int128 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I68F60(I68F60 x, I68F60 y, I68F60 z, I68F60 w) : this(new Vector4Int128(x.Bits, y.Bits, z.Bits, w.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I68F60(I68F60 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I68F60 FromRepr(Vector4Int128 repr) {
            return new Vector4I68F60(repr);
        }
        #endregion
        #region Zero, One, NegativeOne, UnitX, UnitY, UnitZ, UnitW
        public static readonly Vector4I68F60 Zero = new Vector4I68F60(I68F60.Zero);
        public static readonly Vector4I68F60 One = new Vector4I68F60(I68F60.One);
        public static readonly Vector4I68F60 NegativeOne = new Vector4I68F60(I68F60.NegativeOne);
        public static readonly Vector4I68F60 UnitX = new Vector4I68F60(I68F60.One, I68F60.Zero, I68F60.Zero, I68F60.Zero);
        public static readonly Vector4I68F60 UnitY = new Vector4I68F60(I68F60.Zero, I68F60.One, I68F60.Zero, I68F60.Zero);
        public static readonly Vector4I68F60 UnitZ = new Vector4I68F60(I68F60.Zero, I68F60.Zero, I68F60.One, I68F60.Zero);
        public static readonly Vector4I68F60 UnitW = new Vector4I68F60(I68F60.Zero, I68F60.Zero, I68F60.Zero, I68F60.One);
        #endregion
        #region IAdditionOperators, ISubtractionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I68F60 operator +(Vector4I68F60 a, Vector4I68F60 b) {
            return new Vector4I68F60(a.Repr + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I68F60 operator +(I68F60 a, Vector4I68F60 b) {
            return new Vector4I68F60(a.Bits + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I68F60 operator +(Vector4I68F60 a, I68F60 b) {
            return new Vector4I68F60(a.Repr + b.Bits);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I68F60 operator -(Vector4I68F60 a, Vector4I68F60 b) {
            return new Vector4I68F60(a.Repr - b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I68F60 operator -(I68F60 a, Vector4I68F60 b) {
            return new Vector4I68F60(a.Bits - b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I68F60 operator -(Vector4I68F60 a, I68F60 b) {
            return new Vector4I68F60(a.Repr - b.Bits);
        }
        #endregion
        #region IUnaryPlusOperators, IUnaryNegationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I68F60 operator +(Vector4I68F60 x) {
            return new Vector4I68F60(+x.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I68F60 operator -(Vector4I68F60 x) {
            return new Vector4I68F60(-x.Repr);
        }
        #endregion
        #region IEqualityOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator ==(Vector4I68F60 lhs, Vector4I68F60 rhs) => lhs.Repr == rhs.Repr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(Vector4I68F60 lhs, Vector4I68F60 rhs) => lhs.Repr != rhs.Repr;
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is Vector4I68F60 o && Equals(o);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I68F60 other) {
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
        public Vector4I68F60 Min(Vector4I68F60 other) {
            return new Vector4I68F60(Repr.Min(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I68F60 Max(Vector4I68F60 other) {
            return new Vector4I68F60(Repr.Max(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I68F60 Clamp(I68F60 min, I68F60 max) {
            return new Vector4I68F60(Repr.Clamp(min.Bits, max.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I68F60 Clamp(Vector4I68F60 min, Vector4I68F60 max) {
            return new Vector4I68F60(Repr.Clamp(min.Repr, max.Repr));
        }
        #endregion
        #region IsNegative, Abs
        public Vector4Bool IsNegative() => Repr.IsNegative();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I68F60 Abs() => new Vector4I68F60(Repr.Abs());

        // 符号なし固定小数点数ベクトル型は定義されていないため
        // UnsignedAbs と AbsDiff は定義されない.
        #endregion
        #region Half, Twice
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector4I68F60 Half() => new Vector4I68F60(Repr.Half());
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector4I68F60 Twice() => new Vector4I68F60(Repr.Twice());
        #endregion
        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 X0() => Vector2I68F60.FromRepr(Repr.X0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 X1() => Vector2I68F60.FromRepr(Repr.X1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 XX() => Vector2I68F60.FromRepr(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 XY() => Vector2I68F60.FromRepr(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 XZ() => Vector2I68F60.FromRepr(Repr.XZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 XW() => Vector2I68F60.FromRepr(Repr.XW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 YX() => Vector2I68F60.FromRepr(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 YY() => Vector2I68F60.FromRepr(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 YZ() => Vector2I68F60.FromRepr(Repr.YZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 YW() => Vector2I68F60.FromRepr(Repr.YW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 ZX() => Vector2I68F60.FromRepr(Repr.ZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 ZY() => Vector2I68F60.FromRepr(Repr.ZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 ZZ() => Vector2I68F60.FromRepr(Repr.ZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 ZW() => Vector2I68F60.FromRepr(Repr.ZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 WX() => Vector2I68F60.FromRepr(Repr.WX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 WY() => Vector2I68F60.FromRepr(Repr.WY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 WZ() => Vector2I68F60.FromRepr(Repr.WZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 WW() => Vector2I68F60.FromRepr(Repr.WW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XY0() => Vector3I68F60.FromRepr(Repr.XY0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XY1() => Vector3I68F60.FromRepr(Repr.XY1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XXX() => Vector3I68F60.FromRepr(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XXY() => Vector3I68F60.FromRepr(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XXZ() => Vector3I68F60.FromRepr(Repr.XXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XXW() => Vector3I68F60.FromRepr(Repr.XXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XYX() => Vector3I68F60.FromRepr(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XYY() => Vector3I68F60.FromRepr(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XYZ() => Vector3I68F60.FromRepr(Repr.XYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XYW() => Vector3I68F60.FromRepr(Repr.XYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XZX() => Vector3I68F60.FromRepr(Repr.XZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XZY() => Vector3I68F60.FromRepr(Repr.XZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XZZ() => Vector3I68F60.FromRepr(Repr.XZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XZW() => Vector3I68F60.FromRepr(Repr.XZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XWX() => Vector3I68F60.FromRepr(Repr.XWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XWY() => Vector3I68F60.FromRepr(Repr.XWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XWZ() => Vector3I68F60.FromRepr(Repr.XWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XWW() => Vector3I68F60.FromRepr(Repr.XWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YXX() => Vector3I68F60.FromRepr(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YXY() => Vector3I68F60.FromRepr(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YXZ() => Vector3I68F60.FromRepr(Repr.YXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YXW() => Vector3I68F60.FromRepr(Repr.YXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YYX() => Vector3I68F60.FromRepr(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YYY() => Vector3I68F60.FromRepr(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YYZ() => Vector3I68F60.FromRepr(Repr.YYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YYW() => Vector3I68F60.FromRepr(Repr.YYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YZX() => Vector3I68F60.FromRepr(Repr.YZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YZY() => Vector3I68F60.FromRepr(Repr.YZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YZZ() => Vector3I68F60.FromRepr(Repr.YZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YZW() => Vector3I68F60.FromRepr(Repr.YZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YWX() => Vector3I68F60.FromRepr(Repr.YWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YWY() => Vector3I68F60.FromRepr(Repr.YWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YWZ() => Vector3I68F60.FromRepr(Repr.YWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YWW() => Vector3I68F60.FromRepr(Repr.YWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZXX() => Vector3I68F60.FromRepr(Repr.ZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZXY() => Vector3I68F60.FromRepr(Repr.ZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZXZ() => Vector3I68F60.FromRepr(Repr.ZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZXW() => Vector3I68F60.FromRepr(Repr.ZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZYX() => Vector3I68F60.FromRepr(Repr.ZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZYY() => Vector3I68F60.FromRepr(Repr.ZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZYZ() => Vector3I68F60.FromRepr(Repr.ZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZYW() => Vector3I68F60.FromRepr(Repr.ZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZZX() => Vector3I68F60.FromRepr(Repr.ZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZZY() => Vector3I68F60.FromRepr(Repr.ZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZZZ() => Vector3I68F60.FromRepr(Repr.ZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZZW() => Vector3I68F60.FromRepr(Repr.ZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZWX() => Vector3I68F60.FromRepr(Repr.ZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZWY() => Vector3I68F60.FromRepr(Repr.ZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZWZ() => Vector3I68F60.FromRepr(Repr.ZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 ZWW() => Vector3I68F60.FromRepr(Repr.ZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 WXX() => Vector3I68F60.FromRepr(Repr.WXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 WXY() => Vector3I68F60.FromRepr(Repr.WXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 WXZ() => Vector3I68F60.FromRepr(Repr.WXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 WXW() => Vector3I68F60.FromRepr(Repr.WXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 WYX() => Vector3I68F60.FromRepr(Repr.WYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 WYY() => Vector3I68F60.FromRepr(Repr.WYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 WYZ() => Vector3I68F60.FromRepr(Repr.WYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 WYW() => Vector3I68F60.FromRepr(Repr.WYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 WZX() => Vector3I68F60.FromRepr(Repr.WZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 WZY() => Vector3I68F60.FromRepr(Repr.WZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 WZZ() => Vector3I68F60.FromRepr(Repr.WZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 WZW() => Vector3I68F60.FromRepr(Repr.WZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 WWX() => Vector3I68F60.FromRepr(Repr.WWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 WWY() => Vector3I68F60.FromRepr(Repr.WWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 WWZ() => Vector3I68F60.FromRepr(Repr.WWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 WWW() => Vector3I68F60.FromRepr(Repr.WWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYZ0() => FromRepr(Repr.XYZ0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYZ1() => FromRepr(Repr.XYZ1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXXX() => FromRepr(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXXY() => FromRepr(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXXZ() => FromRepr(Repr.XXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXXW() => FromRepr(Repr.XXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXYX() => FromRepr(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXYY() => FromRepr(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXYZ() => FromRepr(Repr.XXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXYW() => FromRepr(Repr.XXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXZX() => FromRepr(Repr.XXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXZY() => FromRepr(Repr.XXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXZZ() => FromRepr(Repr.XXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXZW() => FromRepr(Repr.XXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXWX() => FromRepr(Repr.XXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXWY() => FromRepr(Repr.XXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXWZ() => FromRepr(Repr.XXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXWW() => FromRepr(Repr.XXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYXX() => FromRepr(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYXY() => FromRepr(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYXZ() => FromRepr(Repr.XYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYXW() => FromRepr(Repr.XYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYYX() => FromRepr(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYYY() => FromRepr(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYYZ() => FromRepr(Repr.XYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYYW() => FromRepr(Repr.XYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYZX() => FromRepr(Repr.XYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYZY() => FromRepr(Repr.XYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYZZ() => FromRepr(Repr.XYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYZW() => FromRepr(Repr.XYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYWX() => FromRepr(Repr.XYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYWY() => FromRepr(Repr.XYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYWZ() => FromRepr(Repr.XYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYWW() => FromRepr(Repr.XYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZXX() => FromRepr(Repr.XZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZXY() => FromRepr(Repr.XZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZXZ() => FromRepr(Repr.XZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZXW() => FromRepr(Repr.XZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZYX() => FromRepr(Repr.XZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZYY() => FromRepr(Repr.XZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZYZ() => FromRepr(Repr.XZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZYW() => FromRepr(Repr.XZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZZX() => FromRepr(Repr.XZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZZY() => FromRepr(Repr.XZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZZZ() => FromRepr(Repr.XZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZZW() => FromRepr(Repr.XZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZWX() => FromRepr(Repr.XZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZWY() => FromRepr(Repr.XZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZWZ() => FromRepr(Repr.XZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XZWW() => FromRepr(Repr.XZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XWXX() => FromRepr(Repr.XWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XWXY() => FromRepr(Repr.XWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XWXZ() => FromRepr(Repr.XWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XWXW() => FromRepr(Repr.XWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XWYX() => FromRepr(Repr.XWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XWYY() => FromRepr(Repr.XWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XWYZ() => FromRepr(Repr.XWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XWYW() => FromRepr(Repr.XWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XWZX() => FromRepr(Repr.XWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XWZY() => FromRepr(Repr.XWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XWZZ() => FromRepr(Repr.XWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XWZW() => FromRepr(Repr.XWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XWWX() => FromRepr(Repr.XWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XWWY() => FromRepr(Repr.XWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XWWZ() => FromRepr(Repr.XWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XWWW() => FromRepr(Repr.XWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXXX() => FromRepr(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXXY() => FromRepr(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXXZ() => FromRepr(Repr.YXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXXW() => FromRepr(Repr.YXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXYX() => FromRepr(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXYY() => FromRepr(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXYZ() => FromRepr(Repr.YXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXYW() => FromRepr(Repr.YXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXZX() => FromRepr(Repr.YXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXZY() => FromRepr(Repr.YXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXZZ() => FromRepr(Repr.YXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXZW() => FromRepr(Repr.YXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXWX() => FromRepr(Repr.YXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXWY() => FromRepr(Repr.YXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXWZ() => FromRepr(Repr.YXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXWW() => FromRepr(Repr.YXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYXX() => FromRepr(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYXY() => FromRepr(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYXZ() => FromRepr(Repr.YYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYXW() => FromRepr(Repr.YYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYYX() => FromRepr(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYYY() => FromRepr(Repr.YYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYYZ() => FromRepr(Repr.YYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYYW() => FromRepr(Repr.YYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYZX() => FromRepr(Repr.YYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYZY() => FromRepr(Repr.YYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYZZ() => FromRepr(Repr.YYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYZW() => FromRepr(Repr.YYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYWX() => FromRepr(Repr.YYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYWY() => FromRepr(Repr.YYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYWZ() => FromRepr(Repr.YYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYWW() => FromRepr(Repr.YYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZXX() => FromRepr(Repr.YZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZXY() => FromRepr(Repr.YZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZXZ() => FromRepr(Repr.YZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZXW() => FromRepr(Repr.YZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZYX() => FromRepr(Repr.YZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZYY() => FromRepr(Repr.YZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZYZ() => FromRepr(Repr.YZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZYW() => FromRepr(Repr.YZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZZX() => FromRepr(Repr.YZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZZY() => FromRepr(Repr.YZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZZZ() => FromRepr(Repr.YZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZZW() => FromRepr(Repr.YZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZWX() => FromRepr(Repr.YZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZWY() => FromRepr(Repr.YZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZWZ() => FromRepr(Repr.YZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YZWW() => FromRepr(Repr.YZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YWXX() => FromRepr(Repr.YWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YWXY() => FromRepr(Repr.YWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YWXZ() => FromRepr(Repr.YWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YWXW() => FromRepr(Repr.YWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YWYX() => FromRepr(Repr.YWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YWYY() => FromRepr(Repr.YWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YWYZ() => FromRepr(Repr.YWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YWYW() => FromRepr(Repr.YWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YWZX() => FromRepr(Repr.YWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YWZY() => FromRepr(Repr.YWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YWZZ() => FromRepr(Repr.YWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YWZW() => FromRepr(Repr.YWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YWWX() => FromRepr(Repr.YWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YWWY() => FromRepr(Repr.YWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YWWZ() => FromRepr(Repr.YWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YWWW() => FromRepr(Repr.YWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXXX() => FromRepr(Repr.ZXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXXY() => FromRepr(Repr.ZXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXXZ() => FromRepr(Repr.ZXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXXW() => FromRepr(Repr.ZXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXYX() => FromRepr(Repr.ZXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXYY() => FromRepr(Repr.ZXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXYZ() => FromRepr(Repr.ZXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXYW() => FromRepr(Repr.ZXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXZX() => FromRepr(Repr.ZXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXZY() => FromRepr(Repr.ZXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXZZ() => FromRepr(Repr.ZXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXZW() => FromRepr(Repr.ZXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXWX() => FromRepr(Repr.ZXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXWY() => FromRepr(Repr.ZXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXWZ() => FromRepr(Repr.ZXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZXWW() => FromRepr(Repr.ZXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYXX() => FromRepr(Repr.ZYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYXY() => FromRepr(Repr.ZYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYXZ() => FromRepr(Repr.ZYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYXW() => FromRepr(Repr.ZYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYYX() => FromRepr(Repr.ZYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYYY() => FromRepr(Repr.ZYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYYZ() => FromRepr(Repr.ZYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYYW() => FromRepr(Repr.ZYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYZX() => FromRepr(Repr.ZYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYZY() => FromRepr(Repr.ZYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYZZ() => FromRepr(Repr.ZYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYZW() => FromRepr(Repr.ZYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYWX() => FromRepr(Repr.ZYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYWY() => FromRepr(Repr.ZYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYWZ() => FromRepr(Repr.ZYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZYWW() => FromRepr(Repr.ZYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZXX() => FromRepr(Repr.ZZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZXY() => FromRepr(Repr.ZZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZXZ() => FromRepr(Repr.ZZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZXW() => FromRepr(Repr.ZZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZYX() => FromRepr(Repr.ZZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZYY() => FromRepr(Repr.ZZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZYZ() => FromRepr(Repr.ZZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZYW() => FromRepr(Repr.ZZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZZX() => FromRepr(Repr.ZZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZZY() => FromRepr(Repr.ZZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZZZ() => FromRepr(Repr.ZZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZZW() => FromRepr(Repr.ZZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZWX() => FromRepr(Repr.ZZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZWY() => FromRepr(Repr.ZZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZWZ() => FromRepr(Repr.ZZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZZWW() => FromRepr(Repr.ZZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZWXX() => FromRepr(Repr.ZWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZWXY() => FromRepr(Repr.ZWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZWXZ() => FromRepr(Repr.ZWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZWXW() => FromRepr(Repr.ZWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZWYX() => FromRepr(Repr.ZWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZWYY() => FromRepr(Repr.ZWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZWYZ() => FromRepr(Repr.ZWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZWYW() => FromRepr(Repr.ZWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZWZX() => FromRepr(Repr.ZWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZWZY() => FromRepr(Repr.ZWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZWZZ() => FromRepr(Repr.ZWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZWZW() => FromRepr(Repr.ZWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZWWX() => FromRepr(Repr.ZWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZWWY() => FromRepr(Repr.ZWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZWWZ() => FromRepr(Repr.ZWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 ZWWW() => FromRepr(Repr.ZWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WXXX() => FromRepr(Repr.WXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WXXY() => FromRepr(Repr.WXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WXXZ() => FromRepr(Repr.WXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WXXW() => FromRepr(Repr.WXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WXYX() => FromRepr(Repr.WXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WXYY() => FromRepr(Repr.WXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WXYZ() => FromRepr(Repr.WXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WXYW() => FromRepr(Repr.WXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WXZX() => FromRepr(Repr.WXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WXZY() => FromRepr(Repr.WXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WXZZ() => FromRepr(Repr.WXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WXZW() => FromRepr(Repr.WXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WXWX() => FromRepr(Repr.WXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WXWY() => FromRepr(Repr.WXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WXWZ() => FromRepr(Repr.WXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WXWW() => FromRepr(Repr.WXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WYXX() => FromRepr(Repr.WYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WYXY() => FromRepr(Repr.WYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WYXZ() => FromRepr(Repr.WYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WYXW() => FromRepr(Repr.WYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WYYX() => FromRepr(Repr.WYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WYYY() => FromRepr(Repr.WYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WYYZ() => FromRepr(Repr.WYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WYYW() => FromRepr(Repr.WYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WYZX() => FromRepr(Repr.WYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WYZY() => FromRepr(Repr.WYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WYZZ() => FromRepr(Repr.WYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WYZW() => FromRepr(Repr.WYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WYWX() => FromRepr(Repr.WYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WYWY() => FromRepr(Repr.WYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WYWZ() => FromRepr(Repr.WYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WYWW() => FromRepr(Repr.WYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WZXX() => FromRepr(Repr.WZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WZXY() => FromRepr(Repr.WZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WZXZ() => FromRepr(Repr.WZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WZXW() => FromRepr(Repr.WZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WZYX() => FromRepr(Repr.WZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WZYY() => FromRepr(Repr.WZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WZYZ() => FromRepr(Repr.WZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WZYW() => FromRepr(Repr.WZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WZZX() => FromRepr(Repr.WZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WZZY() => FromRepr(Repr.WZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WZZZ() => FromRepr(Repr.WZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WZZW() => FromRepr(Repr.WZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WZWX() => FromRepr(Repr.WZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WZWY() => FromRepr(Repr.WZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WZWZ() => FromRepr(Repr.WZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WZWW() => FromRepr(Repr.WZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WWXX() => FromRepr(Repr.WWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WWXY() => FromRepr(Repr.WWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WWXZ() => FromRepr(Repr.WWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WWXW() => FromRepr(Repr.WWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WWYX() => FromRepr(Repr.WWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WWYY() => FromRepr(Repr.WWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WWYZ() => FromRepr(Repr.WWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WWYW() => FromRepr(Repr.WWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WWZX() => FromRepr(Repr.WWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WWZY() => FromRepr(Repr.WWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WWZZ() => FromRepr(Repr.WWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WWZW() => FromRepr(Repr.WWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WWWX() => FromRepr(Repr.WWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WWWY() => FromRepr(Repr.WWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WWWZ() => FromRepr(Repr.WWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 WWWW() => FromRepr(Repr.WWWW());
        #endregion
    }
} // namespace Intar

#endif // NET7_0_OR_GREATER
