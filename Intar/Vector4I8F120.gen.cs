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

        public I8F120 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I8F120.FromBits(Repr[index]);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr[index] = value.Bits;
        }

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

        #region Constructors

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector4I8F120(Vector4Int128 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F120(I8F120 x, I8F120 y, I8F120 z, I8F120 w) : this(new Vector4Int128(x.Bits, y.Bits, z.Bits, w.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F120(I8F120 value) : this(value, value, value, value) { }

        #endregion

        #region Zero, One, UnitX, UnitY, UnitZ, UnitW

        public static readonly Vector4I8F120 Zero = new Vector4I8F120(I8F120.Zero);
        public static readonly Vector4I8F120 One = new Vector4I8F120(I8F120.One);
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
        public static Vector4I8F120 operator -(Vector4I8F120 a, Vector4I8F120 b) {
            return new Vector4I8F120(a.Repr - b.Repr);
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

        public Vector4Bool IsNegative() => Repr.IsNegative();

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I8F120 Abs() => new Vector4I8F120(Repr.Abs());

        #region Half, Twice

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector4I8F120 Half() => new Vector4I8F120(Repr.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector4I8F120 Twice() => new Vector4I8F120(Repr.Twice());

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 XX() => new Vector2I8F120(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 XY() => new Vector2I8F120(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 XZ() => new Vector2I8F120(Repr.XZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 XW() => new Vector2I8F120(Repr.XW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 YX() => new Vector2I8F120(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 YY() => new Vector2I8F120(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 YZ() => new Vector2I8F120(Repr.YZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 YW() => new Vector2I8F120(Repr.YW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 ZX() => new Vector2I8F120(Repr.ZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 ZY() => new Vector2I8F120(Repr.ZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 ZZ() => new Vector2I8F120(Repr.ZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 ZW() => new Vector2I8F120(Repr.ZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 WX() => new Vector2I8F120(Repr.WX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 WY() => new Vector2I8F120(Repr.WY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 WZ() => new Vector2I8F120(Repr.WZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 WW() => new Vector2I8F120(Repr.WW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XXX() => new Vector3I8F120(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XXY() => new Vector3I8F120(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XXZ() => new Vector3I8F120(Repr.XXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XXW() => new Vector3I8F120(Repr.XXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XYX() => new Vector3I8F120(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XYY() => new Vector3I8F120(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XYZ() => new Vector3I8F120(Repr.XYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XYW() => new Vector3I8F120(Repr.XYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XZX() => new Vector3I8F120(Repr.XZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XZY() => new Vector3I8F120(Repr.XZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XZZ() => new Vector3I8F120(Repr.XZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XZW() => new Vector3I8F120(Repr.XZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XWX() => new Vector3I8F120(Repr.XWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XWY() => new Vector3I8F120(Repr.XWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XWZ() => new Vector3I8F120(Repr.XWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XWW() => new Vector3I8F120(Repr.XWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YXX() => new Vector3I8F120(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YXY() => new Vector3I8F120(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YXZ() => new Vector3I8F120(Repr.YXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YXW() => new Vector3I8F120(Repr.YXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YYX() => new Vector3I8F120(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YYY() => new Vector3I8F120(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YYZ() => new Vector3I8F120(Repr.YYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YYW() => new Vector3I8F120(Repr.YYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YZX() => new Vector3I8F120(Repr.YZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YZY() => new Vector3I8F120(Repr.YZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YZZ() => new Vector3I8F120(Repr.YZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YZW() => new Vector3I8F120(Repr.YZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YWX() => new Vector3I8F120(Repr.YWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YWY() => new Vector3I8F120(Repr.YWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YWZ() => new Vector3I8F120(Repr.YWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YWW() => new Vector3I8F120(Repr.YWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZXX() => new Vector3I8F120(Repr.ZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZXY() => new Vector3I8F120(Repr.ZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZXZ() => new Vector3I8F120(Repr.ZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZXW() => new Vector3I8F120(Repr.ZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZYX() => new Vector3I8F120(Repr.ZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZYY() => new Vector3I8F120(Repr.ZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZYZ() => new Vector3I8F120(Repr.ZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZYW() => new Vector3I8F120(Repr.ZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZZX() => new Vector3I8F120(Repr.ZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZZY() => new Vector3I8F120(Repr.ZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZZZ() => new Vector3I8F120(Repr.ZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZZW() => new Vector3I8F120(Repr.ZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZWX() => new Vector3I8F120(Repr.ZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZWY() => new Vector3I8F120(Repr.ZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZWZ() => new Vector3I8F120(Repr.ZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 ZWW() => new Vector3I8F120(Repr.ZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WXX() => new Vector3I8F120(Repr.WXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WXY() => new Vector3I8F120(Repr.WXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WXZ() => new Vector3I8F120(Repr.WXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WXW() => new Vector3I8F120(Repr.WXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WYX() => new Vector3I8F120(Repr.WYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WYY() => new Vector3I8F120(Repr.WYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WYZ() => new Vector3I8F120(Repr.WYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WYW() => new Vector3I8F120(Repr.WYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WZX() => new Vector3I8F120(Repr.WZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WZY() => new Vector3I8F120(Repr.WZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WZZ() => new Vector3I8F120(Repr.WZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WZW() => new Vector3I8F120(Repr.WZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WWX() => new Vector3I8F120(Repr.WWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WWY() => new Vector3I8F120(Repr.WWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WWZ() => new Vector3I8F120(Repr.WWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 WWW() => new Vector3I8F120(Repr.WWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXXX() => new Vector4I8F120(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXXY() => new Vector4I8F120(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXXZ() => new Vector4I8F120(Repr.XXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXXW() => new Vector4I8F120(Repr.XXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXYX() => new Vector4I8F120(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXYY() => new Vector4I8F120(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXYZ() => new Vector4I8F120(Repr.XXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXYW() => new Vector4I8F120(Repr.XXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXZX() => new Vector4I8F120(Repr.XXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXZY() => new Vector4I8F120(Repr.XXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXZZ() => new Vector4I8F120(Repr.XXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXZW() => new Vector4I8F120(Repr.XXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXWX() => new Vector4I8F120(Repr.XXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXWY() => new Vector4I8F120(Repr.XXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXWZ() => new Vector4I8F120(Repr.XXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXWW() => new Vector4I8F120(Repr.XXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYXX() => new Vector4I8F120(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYXY() => new Vector4I8F120(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYXZ() => new Vector4I8F120(Repr.XYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYXW() => new Vector4I8F120(Repr.XYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYYX() => new Vector4I8F120(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYYY() => new Vector4I8F120(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYYZ() => new Vector4I8F120(Repr.XYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYYW() => new Vector4I8F120(Repr.XYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYZX() => new Vector4I8F120(Repr.XYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYZY() => new Vector4I8F120(Repr.XYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYZZ() => new Vector4I8F120(Repr.XYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYZW() => new Vector4I8F120(Repr.XYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYWX() => new Vector4I8F120(Repr.XYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYWY() => new Vector4I8F120(Repr.XYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYWZ() => new Vector4I8F120(Repr.XYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYWW() => new Vector4I8F120(Repr.XYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZXX() => new Vector4I8F120(Repr.XZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZXY() => new Vector4I8F120(Repr.XZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZXZ() => new Vector4I8F120(Repr.XZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZXW() => new Vector4I8F120(Repr.XZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZYX() => new Vector4I8F120(Repr.XZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZYY() => new Vector4I8F120(Repr.XZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZYZ() => new Vector4I8F120(Repr.XZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZYW() => new Vector4I8F120(Repr.XZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZZX() => new Vector4I8F120(Repr.XZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZZY() => new Vector4I8F120(Repr.XZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZZZ() => new Vector4I8F120(Repr.XZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZZW() => new Vector4I8F120(Repr.XZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZWX() => new Vector4I8F120(Repr.XZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZWY() => new Vector4I8F120(Repr.XZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZWZ() => new Vector4I8F120(Repr.XZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XZWW() => new Vector4I8F120(Repr.XZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWXX() => new Vector4I8F120(Repr.XWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWXY() => new Vector4I8F120(Repr.XWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWXZ() => new Vector4I8F120(Repr.XWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWXW() => new Vector4I8F120(Repr.XWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWYX() => new Vector4I8F120(Repr.XWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWYY() => new Vector4I8F120(Repr.XWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWYZ() => new Vector4I8F120(Repr.XWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWYW() => new Vector4I8F120(Repr.XWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWZX() => new Vector4I8F120(Repr.XWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWZY() => new Vector4I8F120(Repr.XWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWZZ() => new Vector4I8F120(Repr.XWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWZW() => new Vector4I8F120(Repr.XWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWWX() => new Vector4I8F120(Repr.XWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWWY() => new Vector4I8F120(Repr.XWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWWZ() => new Vector4I8F120(Repr.XWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XWWW() => new Vector4I8F120(Repr.XWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXXX() => new Vector4I8F120(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXXY() => new Vector4I8F120(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXXZ() => new Vector4I8F120(Repr.YXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXXW() => new Vector4I8F120(Repr.YXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXYX() => new Vector4I8F120(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXYY() => new Vector4I8F120(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXYZ() => new Vector4I8F120(Repr.YXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXYW() => new Vector4I8F120(Repr.YXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXZX() => new Vector4I8F120(Repr.YXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXZY() => new Vector4I8F120(Repr.YXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXZZ() => new Vector4I8F120(Repr.YXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXZW() => new Vector4I8F120(Repr.YXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXWX() => new Vector4I8F120(Repr.YXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXWY() => new Vector4I8F120(Repr.YXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXWZ() => new Vector4I8F120(Repr.YXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXWW() => new Vector4I8F120(Repr.YXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYXX() => new Vector4I8F120(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYXY() => new Vector4I8F120(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYXZ() => new Vector4I8F120(Repr.YYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYXW() => new Vector4I8F120(Repr.YYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYYX() => new Vector4I8F120(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYYY() => new Vector4I8F120(Repr.YYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYYZ() => new Vector4I8F120(Repr.YYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYYW() => new Vector4I8F120(Repr.YYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYZX() => new Vector4I8F120(Repr.YYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYZY() => new Vector4I8F120(Repr.YYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYZZ() => new Vector4I8F120(Repr.YYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYZW() => new Vector4I8F120(Repr.YYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYWX() => new Vector4I8F120(Repr.YYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYWY() => new Vector4I8F120(Repr.YYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYWZ() => new Vector4I8F120(Repr.YYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYWW() => new Vector4I8F120(Repr.YYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZXX() => new Vector4I8F120(Repr.YZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZXY() => new Vector4I8F120(Repr.YZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZXZ() => new Vector4I8F120(Repr.YZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZXW() => new Vector4I8F120(Repr.YZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZYX() => new Vector4I8F120(Repr.YZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZYY() => new Vector4I8F120(Repr.YZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZYZ() => new Vector4I8F120(Repr.YZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZYW() => new Vector4I8F120(Repr.YZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZZX() => new Vector4I8F120(Repr.YZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZZY() => new Vector4I8F120(Repr.YZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZZZ() => new Vector4I8F120(Repr.YZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZZW() => new Vector4I8F120(Repr.YZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZWX() => new Vector4I8F120(Repr.YZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZWY() => new Vector4I8F120(Repr.YZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZWZ() => new Vector4I8F120(Repr.YZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YZWW() => new Vector4I8F120(Repr.YZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWXX() => new Vector4I8F120(Repr.YWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWXY() => new Vector4I8F120(Repr.YWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWXZ() => new Vector4I8F120(Repr.YWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWXW() => new Vector4I8F120(Repr.YWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWYX() => new Vector4I8F120(Repr.YWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWYY() => new Vector4I8F120(Repr.YWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWYZ() => new Vector4I8F120(Repr.YWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWYW() => new Vector4I8F120(Repr.YWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWZX() => new Vector4I8F120(Repr.YWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWZY() => new Vector4I8F120(Repr.YWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWZZ() => new Vector4I8F120(Repr.YWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWZW() => new Vector4I8F120(Repr.YWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWWX() => new Vector4I8F120(Repr.YWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWWY() => new Vector4I8F120(Repr.YWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWWZ() => new Vector4I8F120(Repr.YWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YWWW() => new Vector4I8F120(Repr.YWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXXX() => new Vector4I8F120(Repr.ZXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXXY() => new Vector4I8F120(Repr.ZXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXXZ() => new Vector4I8F120(Repr.ZXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXXW() => new Vector4I8F120(Repr.ZXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXYX() => new Vector4I8F120(Repr.ZXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXYY() => new Vector4I8F120(Repr.ZXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXYZ() => new Vector4I8F120(Repr.ZXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXYW() => new Vector4I8F120(Repr.ZXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXZX() => new Vector4I8F120(Repr.ZXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXZY() => new Vector4I8F120(Repr.ZXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXZZ() => new Vector4I8F120(Repr.ZXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXZW() => new Vector4I8F120(Repr.ZXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXWX() => new Vector4I8F120(Repr.ZXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXWY() => new Vector4I8F120(Repr.ZXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXWZ() => new Vector4I8F120(Repr.ZXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZXWW() => new Vector4I8F120(Repr.ZXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYXX() => new Vector4I8F120(Repr.ZYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYXY() => new Vector4I8F120(Repr.ZYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYXZ() => new Vector4I8F120(Repr.ZYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYXW() => new Vector4I8F120(Repr.ZYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYYX() => new Vector4I8F120(Repr.ZYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYYY() => new Vector4I8F120(Repr.ZYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYYZ() => new Vector4I8F120(Repr.ZYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYYW() => new Vector4I8F120(Repr.ZYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYZX() => new Vector4I8F120(Repr.ZYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYZY() => new Vector4I8F120(Repr.ZYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYZZ() => new Vector4I8F120(Repr.ZYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYZW() => new Vector4I8F120(Repr.ZYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYWX() => new Vector4I8F120(Repr.ZYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYWY() => new Vector4I8F120(Repr.ZYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYWZ() => new Vector4I8F120(Repr.ZYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZYWW() => new Vector4I8F120(Repr.ZYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZXX() => new Vector4I8F120(Repr.ZZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZXY() => new Vector4I8F120(Repr.ZZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZXZ() => new Vector4I8F120(Repr.ZZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZXW() => new Vector4I8F120(Repr.ZZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZYX() => new Vector4I8F120(Repr.ZZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZYY() => new Vector4I8F120(Repr.ZZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZYZ() => new Vector4I8F120(Repr.ZZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZYW() => new Vector4I8F120(Repr.ZZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZZX() => new Vector4I8F120(Repr.ZZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZZY() => new Vector4I8F120(Repr.ZZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZZZ() => new Vector4I8F120(Repr.ZZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZZW() => new Vector4I8F120(Repr.ZZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZWX() => new Vector4I8F120(Repr.ZZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZWY() => new Vector4I8F120(Repr.ZZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZWZ() => new Vector4I8F120(Repr.ZZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZZWW() => new Vector4I8F120(Repr.ZZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWXX() => new Vector4I8F120(Repr.ZWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWXY() => new Vector4I8F120(Repr.ZWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWXZ() => new Vector4I8F120(Repr.ZWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWXW() => new Vector4I8F120(Repr.ZWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWYX() => new Vector4I8F120(Repr.ZWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWYY() => new Vector4I8F120(Repr.ZWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWYZ() => new Vector4I8F120(Repr.ZWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWYW() => new Vector4I8F120(Repr.ZWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWZX() => new Vector4I8F120(Repr.ZWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWZY() => new Vector4I8F120(Repr.ZWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWZZ() => new Vector4I8F120(Repr.ZWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWZW() => new Vector4I8F120(Repr.ZWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWWX() => new Vector4I8F120(Repr.ZWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWWY() => new Vector4I8F120(Repr.ZWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWWZ() => new Vector4I8F120(Repr.ZWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 ZWWW() => new Vector4I8F120(Repr.ZWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXXX() => new Vector4I8F120(Repr.WXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXXY() => new Vector4I8F120(Repr.WXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXXZ() => new Vector4I8F120(Repr.WXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXXW() => new Vector4I8F120(Repr.WXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXYX() => new Vector4I8F120(Repr.WXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXYY() => new Vector4I8F120(Repr.WXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXYZ() => new Vector4I8F120(Repr.WXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXYW() => new Vector4I8F120(Repr.WXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXZX() => new Vector4I8F120(Repr.WXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXZY() => new Vector4I8F120(Repr.WXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXZZ() => new Vector4I8F120(Repr.WXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXZW() => new Vector4I8F120(Repr.WXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXWX() => new Vector4I8F120(Repr.WXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXWY() => new Vector4I8F120(Repr.WXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXWZ() => new Vector4I8F120(Repr.WXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WXWW() => new Vector4I8F120(Repr.WXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYXX() => new Vector4I8F120(Repr.WYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYXY() => new Vector4I8F120(Repr.WYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYXZ() => new Vector4I8F120(Repr.WYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYXW() => new Vector4I8F120(Repr.WYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYYX() => new Vector4I8F120(Repr.WYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYYY() => new Vector4I8F120(Repr.WYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYYZ() => new Vector4I8F120(Repr.WYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYYW() => new Vector4I8F120(Repr.WYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYZX() => new Vector4I8F120(Repr.WYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYZY() => new Vector4I8F120(Repr.WYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYZZ() => new Vector4I8F120(Repr.WYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYZW() => new Vector4I8F120(Repr.WYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYWX() => new Vector4I8F120(Repr.WYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYWY() => new Vector4I8F120(Repr.WYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYWZ() => new Vector4I8F120(Repr.WYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WYWW() => new Vector4I8F120(Repr.WYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZXX() => new Vector4I8F120(Repr.WZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZXY() => new Vector4I8F120(Repr.WZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZXZ() => new Vector4I8F120(Repr.WZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZXW() => new Vector4I8F120(Repr.WZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZYX() => new Vector4I8F120(Repr.WZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZYY() => new Vector4I8F120(Repr.WZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZYZ() => new Vector4I8F120(Repr.WZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZYW() => new Vector4I8F120(Repr.WZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZZX() => new Vector4I8F120(Repr.WZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZZY() => new Vector4I8F120(Repr.WZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZZZ() => new Vector4I8F120(Repr.WZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZZW() => new Vector4I8F120(Repr.WZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZWX() => new Vector4I8F120(Repr.WZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZWY() => new Vector4I8F120(Repr.WZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZWZ() => new Vector4I8F120(Repr.WZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WZWW() => new Vector4I8F120(Repr.WZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWXX() => new Vector4I8F120(Repr.WWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWXY() => new Vector4I8F120(Repr.WWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWXZ() => new Vector4I8F120(Repr.WWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWXW() => new Vector4I8F120(Repr.WWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWYX() => new Vector4I8F120(Repr.WWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWYY() => new Vector4I8F120(Repr.WWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWYZ() => new Vector4I8F120(Repr.WWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWYW() => new Vector4I8F120(Repr.WWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWZX() => new Vector4I8F120(Repr.WWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWZY() => new Vector4I8F120(Repr.WWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWZZ() => new Vector4I8F120(Repr.WWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWZW() => new Vector4I8F120(Repr.WWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWWX() => new Vector4I8F120(Repr.WWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWWY() => new Vector4I8F120(Repr.WWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWWZ() => new Vector4I8F120(Repr.WWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 WWWW() => new Vector4I8F120(Repr.WWWW());

        #endregion

    }
} // namespace Intar

#endif // NET7_0_OR_GREATER
