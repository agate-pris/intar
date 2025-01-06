#if NET7_0_OR_GREATER

using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector2I68F60
    : IEquatable<Vector2I68F60>
    , IFormattable {
        #region Fields

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector2Int128 Repr;

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
        public static explicit operator System.Numerics.Vector2(Vector2I68F60 a) {
            return (System.Numerics.Vector2)a.Repr / (float)I68F60.OneRepr;
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector2(Vector2I68F60 a) {
            return (UnityEngine.Vector2)a.Repr / (float)I68F60.OneRepr;
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float2(Vector2I68F60 a) {
            return (Unity.Mathematics.float2)a.Repr / (float)I68F60.OneRepr;
        }
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        Vector2I68F60(Vector2Int128 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I68F60(I68F60 x, I68F60 y) : this(new Vector2Int128(x.Bits, y.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I68F60(I68F60 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I68F60 FromRepr(Vector2Int128 repr) {
            return new Vector2I68F60(repr);
        }
        #endregion
        #region Zero, One, UnitX, UnitY
        public static readonly Vector2I68F60 Zero = new Vector2I68F60(I68F60.Zero);
        public static readonly Vector2I68F60 One = new Vector2I68F60(I68F60.One);
        public static readonly Vector2I68F60 UnitX = new Vector2I68F60(I68F60.One, I68F60.Zero);
        public static readonly Vector2I68F60 UnitY = new Vector2I68F60(I68F60.Zero, I68F60.One);
        #endregion
        #region IAdditionOperators, ISubtractionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I68F60 operator +(Vector2I68F60 a, Vector2I68F60 b) {
            return new Vector2I68F60(a.Repr + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I68F60 operator -(Vector2I68F60 a, Vector2I68F60 b) {
            return new Vector2I68F60(a.Repr - b.Repr);
        }
        #endregion
        #region IUnaryPlusOperators, IUnaryNegationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I68F60 operator +(Vector2I68F60 x) {
            return new Vector2I68F60(+x.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I68F60 operator -(Vector2I68F60 x) {
            return new Vector2I68F60(-x.Repr);
        }
        #endregion
        #region IEqualityOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(Vector2I68F60 lhs, Vector2I68F60 rhs) => lhs.Repr == rhs.Repr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2I68F60 lhs, Vector2I68F60 rhs) => lhs.Repr != rhs.Repr;
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is Vector2I68F60 o && Equals(o);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2I68F60 other) {
            return Repr.Equals(other.Repr);
        }
        #endregion
        #region IFormattable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}>";
        }
        #endregion
        #region Min, Max, Clamp
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I68F60 Min(Vector2I68F60 other) {
            return new Vector2I68F60(Repr.Min(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I68F60 Max(Vector2I68F60 other) {
            return new Vector2I68F60(Repr.Max(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I68F60 Clamp(I68F60 min, I68F60 max) {
            return new Vector2I68F60(Repr.Clamp(min.Bits, max.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I68F60 Clamp(Vector2I68F60 min, Vector2I68F60 max) {
            return new Vector2I68F60(Repr.Clamp(min.Repr, max.Repr));
        }
        #endregion
        #region IsNegative, Abs
        public Vector2Bool IsNegative() => Repr.IsNegative();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I68F60 Abs() => new Vector2I68F60(Repr.Abs());

        // 符号なし固定小数点数ベクトル型は定義されていないため
        // UnsignedAbs と AbsDiff は定義されない.
        #endregion
        #region Half, Twice
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector2I68F60 Half() => new Vector2I68F60(Repr.Half());
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector2I68F60 Twice() => new Vector2I68F60(Repr.Twice());
        #endregion
        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 XX() => Vector2I68F60.FromRepr(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 XY() => Vector2I68F60.FromRepr(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 YX() => Vector2I68F60.FromRepr(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I68F60 YY() => Vector2I68F60.FromRepr(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XXX() => Vector3I68F60.FromRepr(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XXY() => Vector3I68F60.FromRepr(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XYX() => Vector3I68F60.FromRepr(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 XYY() => Vector3I68F60.FromRepr(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YXX() => Vector3I68F60.FromRepr(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YXY() => Vector3I68F60.FromRepr(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YYX() => Vector3I68F60.FromRepr(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I68F60 YYY() => Vector3I68F60.FromRepr(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXXX() => Vector4I68F60.FromRepr(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXXY() => Vector4I68F60.FromRepr(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXYX() => Vector4I68F60.FromRepr(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XXYY() => Vector4I68F60.FromRepr(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYXX() => Vector4I68F60.FromRepr(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYXY() => Vector4I68F60.FromRepr(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYYX() => Vector4I68F60.FromRepr(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 XYYY() => Vector4I68F60.FromRepr(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXXX() => Vector4I68F60.FromRepr(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXXY() => Vector4I68F60.FromRepr(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXYX() => Vector4I68F60.FromRepr(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YXYY() => Vector4I68F60.FromRepr(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYXX() => Vector4I68F60.FromRepr(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYXY() => Vector4I68F60.FromRepr(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYYX() => Vector4I68F60.FromRepr(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I68F60 YYYY() => Vector4I68F60.FromRepr(Repr.YYYY());
        #endregion
    }
} // namespace Intar

#endif // NET7_0_OR_GREATER
