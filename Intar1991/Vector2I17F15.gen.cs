using System;
using System.Runtime.CompilerServices;

namespace Intar1991 {
    [Serializable]
    public struct Vector2I17F15
    : IEquatable<Vector2I17F15>
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
        public I17F15 X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I17F15.FromBits(Repr.X);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.X = value.Bits;
        }
        public I17F15 Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I17F15.FromBits(Repr.Y);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Y = value.Bits;
        }
        #endregion

        public I17F15 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I17F15.FromBits(Repr[index]);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr[index] = value.Bits;
        }

        public static explicit operator System.Numerics.Vector2(Vector2I17F15 a) {
            return (System.Numerics.Vector2)a.Repr / I17F15.OneRepr;
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector2(Vector2I17F15 a) {
            return (UnityEngine.Vector2)a.Repr / I17F15.OneRepr;
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float2(Vector2I17F15 a) {
            return (Unity.Mathematics.float2)a.Repr / I17F15.OneRepr;
        }
#endif

        #region Constructors

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15(Vector2Int32 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15(I17F15 x, I17F15 y) : this(new Vector2Int32(x.Bits, y.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15(I17F15 value) : this(value, value) { }

        #endregion

        #region Zero, One, UnitX, UnitY

        public static readonly Vector2I17F15 Zero = new Vector2I17F15(I17F15.Zero);
        public static readonly Vector2I17F15 One = new Vector2I17F15(I17F15.One);
        public static readonly Vector2I17F15 UnitX = new Vector2I17F15(I17F15.One, I17F15.Zero);
        public static readonly Vector2I17F15 UnitY = new Vector2I17F15(I17F15.Zero, I17F15.One);

        #endregion

        #region IAdditionOperators, ISubtractionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator +(Vector2I17F15 a, Vector2I17F15 b) {
            return new Vector2I17F15(a.Repr + b.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator -(Vector2I17F15 a, Vector2I17F15 b) {
            return new Vector2I17F15(a.Repr - b.Repr);
        }

        #endregion

        #region IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator *(Vector2I17F15 a, Vector2I17F15 b) {
            return new Vector2I17F15((Vector2Int32)(a.WideRepr * b.WideRepr / I17F15.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator *(Vector2I17F15 a, I17F15 b) {
            return new Vector2I17F15((Vector2Int32)(a.WideRepr * b.Bits / I17F15.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator *(I17F15 a, Vector2I17F15 b) {
            return b * a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator /(Vector2I17F15 a, Vector2I17F15 b) {
            return new Vector2I17F15((Vector2Int32)(a.WideRepr * I17F15.OneRepr / b.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator /(Vector2I17F15 a, I17F15 b) {
            return new Vector2I17F15((Vector2Int32)(a.WideRepr * I17F15.OneRepr / b.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator /(I17F15 a, Vector2I17F15 b) {
            return new Vector2I17F15((Vector2Int32)(a.WideBits * I17F15.OneRepr / b.WideRepr));
        }

        #endregion

        #region IUnaryPlusOperators, IUnaryNegationOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator +(Vector2I17F15 x) {
            return new Vector2I17F15(+x.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator -(Vector2I17F15 x) {
            return new Vector2I17F15(-x.Repr);
        }

        #endregion

        #region IEqualityOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(Vector2I17F15 lhs, Vector2I17F15 rhs) => lhs.Repr == rhs.Repr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2I17F15 lhs, Vector2I17F15 rhs) => lhs.Repr != rhs.Repr;

        #endregion

        public Vector2Bool IsNegative() => Repr.IsNegative();

        #region Object

        public override bool Equals(object obj) => obj is Vector2I17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";

        #endregion

        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2I17F15 other) {
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
        public Vector2I17F15 Min(Vector2I17F15 other) {
            return new Vector2I17F15(Repr.Min(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 Max(Vector2I17F15 other) {
            return new Vector2I17F15(Repr.Max(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 Clamp(I17F15 min, I17F15 max) {
            return new Vector2I17F15(Repr.Clamp(min.Bits, max.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 Clamp(Vector2I17F15 min, Vector2I17F15 max) {
            return new Vector2I17F15(Repr.Clamp(min.Repr, max.Repr));
        }

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15 Abs() => new Vector2I17F15(Repr.Abs());

        #region Half, Twice

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector2I17F15 Half() => new Vector2I17F15(Repr.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector2I17F15 Twice() => new Vector2I17F15(Repr.Twice());

        #endregion

        #region Cross, UncheckedDot, (Unchecked)LengthSquared, (Unchecked)Length

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 UncheckedDot(Vector2I17F15 other) {
            return I34F30.FromBits(Repr.UncheckedDot(other.Repr));
        }

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 LengthSquared() => U34F30.FromBits(Repr.LengthSquared());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 Length() => U17F15.FromBits(Repr.Length());

        #endregion

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

            const uint fracOneTwo = I17F15.OneRepr / 2;
            var absNormalized = (Vector2Int32)(scaled.BigMul(fracOneTwo) / halfLength);

            return new Vector2Int32(
                isNegative.X ? -absNormalized.X : absNormalized.X,
                isNegative.Y ? -absNormalized.Y : absNormalized.Y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I17F15? Normalize() {
            var tmp = Normalize(Repr);
            if (tmp == null) {
                return null;
            }
            return new Vector2I17F15(tmp.Value);
        }

        #region Sin/Cos

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 SinP2() => new Vector2I2F30(
            X.SinP2(),
            Y.SinP2());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 SinP3() => new Vector2I2F30(
            X.SinP3(),
            Y.SinP3());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 SinP4() => new Vector2I2F30(
            X.SinP4(),
            Y.SinP4());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 SinP5() => new Vector2I2F30(
            X.SinP5(),
            Y.SinP5());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 CosP2() => new Vector2I2F30(
            X.CosP2(),
            Y.CosP2());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 CosP3() => new Vector2I2F30(
            X.CosP3(),
            Y.CosP3());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 CosP4() => new Vector2I2F30(
            X.CosP4(),
            Y.CosP4());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I2F30 CosP5() => new Vector2I2F30(
            X.CosP5(),
            Y.CosP5());

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XX() => new Vector2I17F15(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XY() => new Vector2I17F15(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YX() => new Vector2I17F15(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YY() => new Vector2I17F15(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXX() => new Vector3I17F15(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXY() => new Vector3I17F15(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYX() => new Vector3I17F15(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYY() => new Vector3I17F15(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXX() => new Vector3I17F15(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXY() => new Vector3I17F15(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYX() => new Vector3I17F15(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYY() => new Vector3I17F15(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXX() => new Vector4I17F15(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXY() => new Vector4I17F15(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYX() => new Vector4I17F15(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYY() => new Vector4I17F15(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXX() => new Vector4I17F15(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXY() => new Vector4I17F15(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYX() => new Vector4I17F15(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYY() => new Vector4I17F15(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXX() => new Vector4I17F15(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXY() => new Vector4I17F15(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYX() => new Vector4I17F15(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYY() => new Vector4I17F15(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXX() => new Vector4I17F15(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXY() => new Vector4I17F15(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYX() => new Vector4I17F15(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYY() => new Vector4I17F15(Repr.YYYY());

        #endregion

    }
} // namespace Intar1991
