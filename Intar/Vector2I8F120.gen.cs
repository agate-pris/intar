#if NET7_0_OR_GREATER

using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector2I8F120
    : IEquatable<Vector2I8F120>
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
        public static explicit operator System.Numerics.Vector2(Vector2I8F120 a) {
            return (System.Numerics.Vector2)a.Repr / (float)I8F120.OneRepr;
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector2(Vector2I8F120 a) {
            return (UnityEngine.Vector2)a.Repr / (float)I8F120.OneRepr;
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float2(Vector2I8F120 a) {
            return (Unity.Mathematics.float2)a.Repr / (float)I8F120.OneRepr;
        }
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        Vector2I8F120(Vector2Int128 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I8F120(I8F120 x, I8F120 y) : this(new Vector2Int128(x.Bits, y.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I8F120(I8F120 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F120 FromRepr(Vector2Int128 repr) {
            return new Vector2I8F120(repr);
        }
        #endregion
        #region Zero, One, UnitX, UnitY
        public static readonly Vector2I8F120 Zero = new Vector2I8F120(I8F120.Zero);
        public static readonly Vector2I8F120 One = new Vector2I8F120(I8F120.One);
        public static readonly Vector2I8F120 UnitX = new Vector2I8F120(I8F120.One, I8F120.Zero);
        public static readonly Vector2I8F120 UnitY = new Vector2I8F120(I8F120.Zero, I8F120.One);
        #endregion
        #region IAdditionOperators, ISubtractionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F120 operator +(Vector2I8F120 a, Vector2I8F120 b) {
            return new Vector2I8F120(a.Repr + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F120 operator -(Vector2I8F120 a, Vector2I8F120 b) {
            return new Vector2I8F120(a.Repr - b.Repr);
        }
        #endregion
        #region IUnaryPlusOperators, IUnaryNegationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F120 operator +(Vector2I8F120 x) {
            return new Vector2I8F120(+x.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I8F120 operator -(Vector2I8F120 x) {
            return new Vector2I8F120(-x.Repr);
        }
        #endregion
        #region IEqualityOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(Vector2I8F120 lhs, Vector2I8F120 rhs) => lhs.Repr == rhs.Repr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2I8F120 lhs, Vector2I8F120 rhs) => lhs.Repr != rhs.Repr;
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is Vector2I8F120 o && Equals(o);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2I8F120 other) {
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
        public Vector2I8F120 Min(Vector2I8F120 other) {
            return new Vector2I8F120(Repr.Min(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I8F120 Max(Vector2I8F120 other) {
            return new Vector2I8F120(Repr.Max(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I8F120 Clamp(I8F120 min, I8F120 max) {
            return new Vector2I8F120(Repr.Clamp(min.Bits, max.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I8F120 Clamp(Vector2I8F120 min, Vector2I8F120 max) {
            return new Vector2I8F120(Repr.Clamp(min.Repr, max.Repr));
        }
        #endregion
        #region IsNegative, Abs
        public Vector2Bool IsNegative() => Repr.IsNegative();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I8F120 Abs() => new Vector2I8F120(Repr.Abs());

        // 符号なし固定小数点数ベクトル型は定義されていないため
        // UnsignedAbs と AbsDiff は定義されない.
        #endregion
        #region Half, Twice
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector2I8F120 Half() => new Vector2I8F120(Repr.Half());
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector2I8F120 Twice() => new Vector2I8F120(Repr.Twice());
        #endregion
        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 XX() => Vector2I8F120.FromRepr(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 XY() => Vector2I8F120.FromRepr(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 YX() => Vector2I8F120.FromRepr(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I8F120 YY() => Vector2I8F120.FromRepr(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XXX() => Vector3I8F120.FromRepr(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XXY() => Vector3I8F120.FromRepr(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XYX() => Vector3I8F120.FromRepr(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 XYY() => Vector3I8F120.FromRepr(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YXX() => Vector3I8F120.FromRepr(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YXY() => Vector3I8F120.FromRepr(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YYX() => Vector3I8F120.FromRepr(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I8F120 YYY() => Vector3I8F120.FromRepr(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXXX() => Vector4I8F120.FromRepr(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXXY() => Vector4I8F120.FromRepr(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXYX() => Vector4I8F120.FromRepr(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XXYY() => Vector4I8F120.FromRepr(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYXX() => Vector4I8F120.FromRepr(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYXY() => Vector4I8F120.FromRepr(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYYX() => Vector4I8F120.FromRepr(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 XYYY() => Vector4I8F120.FromRepr(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXXX() => Vector4I8F120.FromRepr(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXXY() => Vector4I8F120.FromRepr(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXYX() => Vector4I8F120.FromRepr(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YXYY() => Vector4I8F120.FromRepr(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYXX() => Vector4I8F120.FromRepr(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYXY() => Vector4I8F120.FromRepr(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYYX() => Vector4I8F120.FromRepr(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I8F120 YYYY() => Vector4I8F120.FromRepr(Repr.YYYY());
        #endregion
    }
} // namespace Intar

#endif // NET7_0_OR_GREATER
