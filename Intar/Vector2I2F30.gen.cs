using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector2I2F30
    : IEquatable<Vector2I2F30>
    , IFormattable {
        #region Fields

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector2Int32 Repr;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        #region WideRepr
        internal Vector2Int64 WideRepr {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Repr;
        }
        #endregion
        #region Components
        public I2F30 X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I2F30.FromBits(Repr.X);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.X = value.Bits;
        }
        public I2F30 Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I2F30.FromBits(Repr.Y);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Y = value.Bits;
        }
        #endregion
        #region Indexer
        public I2F30 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I2F30.FromBits(Repr[index]);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr[index] = value.Bits;
        }
        #endregion
        #region Conversion
        public static explicit operator System.Numerics.Vector2(Vector2I2F30 a) {
            return (System.Numerics.Vector2)a.Repr / I2F30.OneRepr;
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector2(Vector2I2F30 a) {
            return (UnityEngine.Vector2)a.Repr / I2F30.OneRepr;
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float2(Vector2I2F30 a) {
            return (Unity.Mathematics.float2)a.Repr / I2F30.OneRepr;
        }
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector2I2F30(Vector2Int32 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30(I2F30 x, I2F30 y) : this(new Vector2Int32(x.Bits, y.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30(I2F30 value) : this(value, value) { }
        #endregion
        #region Zero, One, UnitX, UnitY
        public static readonly Vector2I2F30 Zero = new Vector2I2F30(I2F30.Zero);
        public static readonly Vector2I2F30 One = new Vector2I2F30(I2F30.One);
        public static readonly Vector2I2F30 UnitX = new Vector2I2F30(I2F30.One, I2F30.Zero);
        public static readonly Vector2I2F30 UnitY = new Vector2I2F30(I2F30.Zero, I2F30.One);
        #endregion
        #region IAdditionOperators, ISubtractionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator +(Vector2I2F30 a, Vector2I2F30 b) {
            return new Vector2I2F30(a.Repr + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator -(Vector2I2F30 a, Vector2I2F30 b) {
            return new Vector2I2F30(a.Repr - b.Repr);
        }
        #endregion
        #region IMultiplyOperators, IDivisionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator *(Vector2I2F30 a, Vector2I2F30 b) {
            return new Vector2I2F30((Vector2Int32)(a.WideRepr * b.WideRepr / I2F30.OneRepr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator *(Vector2I2F30 a, I2F30 b) {
            return new Vector2I2F30((Vector2Int32)(a.WideRepr * b.Bits / I2F30.OneRepr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator *(I2F30 a, Vector2I2F30 b) {
            return b * a;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator /(Vector2I2F30 a, Vector2I2F30 b) {
            return new Vector2I2F30((Vector2Int32)(a.WideRepr * I2F30.OneRepr / b.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator /(Vector2I2F30 a, I2F30 b) {
            return new Vector2I2F30((Vector2Int32)(a.WideRepr * I2F30.OneRepr / b.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator /(I2F30 a, Vector2I2F30 b) {
            return new Vector2I2F30((Vector2Int32)(a.WideBits * I2F30.OneRepr / b.WideRepr));
        }
        #endregion
        #region IUnaryPlusOperators, IUnaryNegationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator +(Vector2I2F30 x) {
            return new Vector2I2F30(+x.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I2F30 operator -(Vector2I2F30 x) {
            return new Vector2I2F30(-x.Repr);
        }
        #endregion
        #region IEqualityOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(Vector2I2F30 lhs, Vector2I2F30 rhs) => lhs.Repr == rhs.Repr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2I2F30 lhs, Vector2I2F30 rhs) => lhs.Repr != rhs.Repr;
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is Vector2I2F30 o && Equals(o);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2I2F30 other) {
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
        public Vector2I2F30 Min(Vector2I2F30 other) {
            return new Vector2I2F30(Repr.Min(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 Max(Vector2I2F30 other) {
            return new Vector2I2F30(Repr.Max(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 Clamp(I2F30 min, I2F30 max) {
            return new Vector2I2F30(Repr.Clamp(min.Bits, max.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 Clamp(Vector2I2F30 min, Vector2I2F30 max) {
            return new Vector2I2F30(Repr.Clamp(min.Repr, max.Repr));
        }
        #endregion
        #region IsNegative, Abs
        public Vector2Bool IsNegative() => Repr.IsNegative();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 Abs() => new Vector2I2F30(Repr.Abs());
        #endregion
        #region Half, Twice
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector2I2F30 Half() => new Vector2I2F30(Repr.Half());
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector2I2F30 Twice() => new Vector2I2F30(Repr.Twice());
        #endregion
        #region Cross, Dot, LengthSquared, Length
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F60 Dot(Vector2I2F30 other) {
            return I4F60.FromBits(Repr.Dot(other.Repr));
        }

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F60 LengthSquared() => U4F60.FromBits(Repr.LengthSquared());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 Length() => U2F30.FromBits(Repr.Length());
        #endregion
        #region Normalize
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Vector2Int32? Normalize(Vector2Int32 v) {

            // 各要素の内部表現型を取り出し、
            // その絶対値を得る。

            var (isNegative, abs) = v.IsNegativeAndUnsignedAbs();
            var maxComponent = abs.MaxComponent();

            // 各要素の最大値が 0 の場合は null を返す。
            if (maxComponent == 0) {
                return null;
            }

            // ベクトルの大きさが小さい時の誤差を小さくするため、
            // 最大の要素が表現型の範囲に収まるように拡大する。
            // 最大の要素以外にも同じ値を乗算する。
            // 剰余の回数を減らすため、
            // 先に型の最大値を最大値で割っておき、それを乗算する。

            var scaled = abs * (uint.MaxValue / maxComponent);

            var halfLength = scaled.HalfLength();

            const uint fracOneTwo = I2F30.OneRepr / 2;
            var absNormalized = (Vector2Int32)(scaled.BigMul(fracOneTwo) / halfLength);

            return new Vector2Int32(
                isNegative.X ? -absNormalized.X : absNormalized.X,
                isNegative.Y ? -absNormalized.Y : absNormalized.Y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30? Normalize() {
            var tmp = Normalize(Repr);
            if (tmp == null) {
                return null;
            }
            return new Vector2I2F30(tmp.Value);
        }
        #endregion
        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XX() => new Vector2I2F30(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XY() => new Vector2I2F30(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YX() => new Vector2I2F30(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YY() => new Vector2I2F30(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXX() => new Vector3I2F30(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXY() => new Vector3I2F30(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYX() => new Vector3I2F30(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYY() => new Vector3I2F30(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXX() => new Vector3I2F30(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXY() => new Vector3I2F30(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYX() => new Vector3I2F30(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYY() => new Vector3I2F30(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXX() => new Vector4I2F30(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXY() => new Vector4I2F30(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYX() => new Vector4I2F30(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYY() => new Vector4I2F30(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXX() => new Vector4I2F30(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXY() => new Vector4I2F30(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYX() => new Vector4I2F30(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYY() => new Vector4I2F30(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXX() => new Vector4I2F30(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXY() => new Vector4I2F30(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYX() => new Vector4I2F30(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYY() => new Vector4I2F30(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXX() => new Vector4I2F30(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXY() => new Vector4I2F30(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYX() => new Vector4I2F30(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYY() => new Vector4I2F30(Repr.YYYY());
        #endregion
    }
} // namespace Intar
