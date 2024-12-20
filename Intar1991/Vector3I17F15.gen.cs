using System;
using System.Runtime.CompilerServices;

namespace Intar1991 {
    [Serializable]
    public struct Vector3I17F15
    : IEquatable<Vector3I17F15>
    , IFormattable {

        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public Vector3Int32 Repr;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion

        #region WideRepr

        internal Vector3Int64 WideRepr {
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
        public I17F15 Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I17F15.FromBits(Repr.Z);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Z = value.Bits;
        }
        #endregion

        public I17F15 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I17F15.FromBits(Repr[index]);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr[index] = value.Bits;
        }

        public static explicit operator System.Numerics.Vector3(Vector3I17F15 a) {
            return (System.Numerics.Vector3)a.Repr / I17F15.OneRepr;
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector3(Vector3I17F15 a) {
            return (UnityEngine.Vector3)a.Repr / I17F15.OneRepr;
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float3(Vector3I17F15 a) {
            return (Unity.Mathematics.float3)a.Repr / I17F15.OneRepr;
        }
#endif

        #region Constructors

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15(Vector3Int32 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15(I17F15 x, I17F15 y, I17F15 z) : this(new Vector3Int32(x.Bits, y.Bits, z.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15(I17F15 value) : this(value, value, value) { }

        #endregion

        #region Zero, One, UnitX, UnitY, UnitZ

        public static readonly Vector3I17F15 Zero = new Vector3I17F15(I17F15.Zero);
        public static readonly Vector3I17F15 One = new Vector3I17F15(I17F15.One);
        public static readonly Vector3I17F15 UnitX = new Vector3I17F15(I17F15.One, I17F15.Zero, I17F15.Zero);
        public static readonly Vector3I17F15 UnitY = new Vector3I17F15(I17F15.Zero, I17F15.One, I17F15.Zero);
        public static readonly Vector3I17F15 UnitZ = new Vector3I17F15(I17F15.Zero, I17F15.Zero, I17F15.One);

        #endregion

        #region IAdditionOperators, ISubtractionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator +(Vector3I17F15 a, Vector3I17F15 b) {
            return new Vector3I17F15(a.Repr + b.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator -(Vector3I17F15 a, Vector3I17F15 b) {
            return new Vector3I17F15(a.Repr - b.Repr);
        }

        #endregion

        #region IMultiplyOperators, IDivisionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator *(Vector3I17F15 a, Vector3I17F15 b) {
            return new Vector3I17F15((Vector3Int32)(a.WideRepr * b.WideRepr / I17F15.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator *(Vector3I17F15 a, I17F15 b) {
            return new Vector3I17F15((Vector3Int32)(a.WideRepr * b.Bits / I17F15.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator *(I17F15 a, Vector3I17F15 b) {
            return b * a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator /(Vector3I17F15 a, Vector3I17F15 b) {
            return new Vector3I17F15((Vector3Int32)(a.WideRepr * I17F15.OneRepr / b.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator /(Vector3I17F15 a, I17F15 b) {
            return new Vector3I17F15((Vector3Int32)(a.WideRepr * I17F15.OneRepr / b.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator /(I17F15 a, Vector3I17F15 b) {
            return new Vector3I17F15((Vector3Int32)(a.WideBits * I17F15.OneRepr / b.WideRepr));
        }

        #endregion

        #region IUnaryPlusOperators, IUnaryNegationOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator +(Vector3I17F15 x) {
            return new Vector3I17F15(+x.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator -(Vector3I17F15 x) {
            return new Vector3I17F15(-x.Repr);
        }

        #endregion

        #region IEqualityOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3I17F15 lhs, Vector3I17F15 rhs) => lhs.Repr == rhs.Repr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3I17F15 lhs, Vector3I17F15 rhs) => lhs.Repr != rhs.Repr;

        #endregion

        public Vector3Bool IsNegative() => Repr.IsNegative();

        #region Object

        public override bool Equals(object obj) => obj is Vector3I17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        #endregion

        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I17F15 other) {
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
        public Vector3I17F15 Min(Vector3I17F15 other) {
            return new Vector3I17F15(Repr.Min(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 Max(Vector3I17F15 other) {
            return new Vector3I17F15(Repr.Max(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 Clamp(I17F15 min, I17F15 max) {
            return new Vector3I17F15(Repr.Clamp(min.Bits, max.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 Clamp(Vector3I17F15 min, Vector3I17F15 max) {
            return new Vector3I17F15(Repr.Clamp(min.Repr, max.Repr));
        }

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 Abs() => new Vector3I17F15(Repr.Abs());

        #region Half, Twice

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I17F15 Half() => new Vector3I17F15(Repr.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I17F15 Twice() => new Vector3I17F15(Repr.Twice());

        #endregion

        #region Cross, UncheckedDot, (Unchecked)LengthSquared, (Unchecked)Length

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I34F30 Cross(Vector3I17F15 other) {
            var tmp = Repr.Cross(other.Repr);
            return new Vector3I34F30(tmp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 UncheckedDot(Vector3I17F15 other) {
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
        internal static Vector3Int32? Normalize(Vector3Int32 v) {

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
            var absNormalized = (Vector3Int32)(scaled.BigMul(fracOneTwo) / halfLength);

            return new Vector3Int32(
                isNegative.X ? -absNormalized.X : absNormalized.X,
                isNegative.Y ? -absNormalized.Y : absNormalized.Y,
                isNegative.Z ? -absNormalized.Z : absNormalized.Z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15? Normalize() {
            var tmp = Normalize(Repr);
            if (tmp == null) {
                return null;
            }
            return new Vector3I17F15(tmp.Value);
        }

        #region Sin/Cos

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 SinP2() => new Vector3I2F30(
            X.SinP2(),
            Y.SinP2(),
            Z.SinP2());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 SinP3() => new Vector3I2F30(
            X.SinP3(),
            Y.SinP3(),
            Z.SinP3());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 SinP4() => new Vector3I2F30(
            X.SinP4(),
            Y.SinP4(),
            Z.SinP4());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 SinP5() => new Vector3I2F30(
            X.SinP5(),
            Y.SinP5(),
            Z.SinP5());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 CosP2() => new Vector3I2F30(
            X.CosP2(),
            Y.CosP2(),
            Z.CosP2());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 CosP3() => new Vector3I2F30(
            X.CosP3(),
            Y.CosP3(),
            Z.CosP3());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 CosP4() => new Vector3I2F30(
            X.CosP4(),
            Y.CosP4(),
            Z.CosP4());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I2F30 CosP5() => new Vector3I2F30(
            X.CosP5(),
            Y.CosP5(),
            Z.CosP5());

        #endregion

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XX() => new Vector2I17F15(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XY() => new Vector2I17F15(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XZ() => new Vector2I17F15(Repr.XZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YX() => new Vector2I17F15(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YY() => new Vector2I17F15(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YZ() => new Vector2I17F15(Repr.YZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 ZX() => new Vector2I17F15(Repr.ZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 ZY() => new Vector2I17F15(Repr.ZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 ZZ() => new Vector2I17F15(Repr.ZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXX() => new Vector3I17F15(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXY() => new Vector3I17F15(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXZ() => new Vector3I17F15(Repr.XXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYX() => new Vector3I17F15(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYY() => new Vector3I17F15(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYZ() => new Vector3I17F15(Repr.XYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XZX() => new Vector3I17F15(Repr.XZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XZY() => new Vector3I17F15(Repr.XZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XZZ() => new Vector3I17F15(Repr.XZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXX() => new Vector3I17F15(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXY() => new Vector3I17F15(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXZ() => new Vector3I17F15(Repr.YXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYX() => new Vector3I17F15(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYY() => new Vector3I17F15(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYZ() => new Vector3I17F15(Repr.YYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YZX() => new Vector3I17F15(Repr.YZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YZY() => new Vector3I17F15(Repr.YZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YZZ() => new Vector3I17F15(Repr.YZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZXX() => new Vector3I17F15(Repr.ZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZXY() => new Vector3I17F15(Repr.ZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZXZ() => new Vector3I17F15(Repr.ZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZYX() => new Vector3I17F15(Repr.ZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZYY() => new Vector3I17F15(Repr.ZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZYZ() => new Vector3I17F15(Repr.ZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZZX() => new Vector3I17F15(Repr.ZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZZY() => new Vector3I17F15(Repr.ZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZZZ() => new Vector3I17F15(Repr.ZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXX() => new Vector4I17F15(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXY() => new Vector4I17F15(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXZ() => new Vector4I17F15(Repr.XXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYX() => new Vector4I17F15(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYY() => new Vector4I17F15(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYZ() => new Vector4I17F15(Repr.XXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXZX() => new Vector4I17F15(Repr.XXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXZY() => new Vector4I17F15(Repr.XXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXZZ() => new Vector4I17F15(Repr.XXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXX() => new Vector4I17F15(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXY() => new Vector4I17F15(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXZ() => new Vector4I17F15(Repr.XYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYX() => new Vector4I17F15(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYY() => new Vector4I17F15(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYZ() => new Vector4I17F15(Repr.XYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZX() => new Vector4I17F15(Repr.XYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZY() => new Vector4I17F15(Repr.XYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZZ() => new Vector4I17F15(Repr.XYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZXX() => new Vector4I17F15(Repr.XZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZXY() => new Vector4I17F15(Repr.XZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZXZ() => new Vector4I17F15(Repr.XZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZYX() => new Vector4I17F15(Repr.XZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZYY() => new Vector4I17F15(Repr.XZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZYZ() => new Vector4I17F15(Repr.XZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZZX() => new Vector4I17F15(Repr.XZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZZY() => new Vector4I17F15(Repr.XZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZZZ() => new Vector4I17F15(Repr.XZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXX() => new Vector4I17F15(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXY() => new Vector4I17F15(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXZ() => new Vector4I17F15(Repr.YXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYX() => new Vector4I17F15(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYY() => new Vector4I17F15(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYZ() => new Vector4I17F15(Repr.YXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXZX() => new Vector4I17F15(Repr.YXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXZY() => new Vector4I17F15(Repr.YXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXZZ() => new Vector4I17F15(Repr.YXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXX() => new Vector4I17F15(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXY() => new Vector4I17F15(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXZ() => new Vector4I17F15(Repr.YYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYX() => new Vector4I17F15(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYY() => new Vector4I17F15(Repr.YYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYZ() => new Vector4I17F15(Repr.YYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYZX() => new Vector4I17F15(Repr.YYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYZY() => new Vector4I17F15(Repr.YYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYZZ() => new Vector4I17F15(Repr.YYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZXX() => new Vector4I17F15(Repr.YZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZXY() => new Vector4I17F15(Repr.YZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZXZ() => new Vector4I17F15(Repr.YZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZYX() => new Vector4I17F15(Repr.YZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZYY() => new Vector4I17F15(Repr.YZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZYZ() => new Vector4I17F15(Repr.YZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZZX() => new Vector4I17F15(Repr.YZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZZY() => new Vector4I17F15(Repr.YZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZZZ() => new Vector4I17F15(Repr.YZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXXX() => new Vector4I17F15(Repr.ZXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXXY() => new Vector4I17F15(Repr.ZXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXXZ() => new Vector4I17F15(Repr.ZXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXYX() => new Vector4I17F15(Repr.ZXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXYY() => new Vector4I17F15(Repr.ZXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXYZ() => new Vector4I17F15(Repr.ZXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXZX() => new Vector4I17F15(Repr.ZXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXZY() => new Vector4I17F15(Repr.ZXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXZZ() => new Vector4I17F15(Repr.ZXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYXX() => new Vector4I17F15(Repr.ZYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYXY() => new Vector4I17F15(Repr.ZYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYXZ() => new Vector4I17F15(Repr.ZYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYYX() => new Vector4I17F15(Repr.ZYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYYY() => new Vector4I17F15(Repr.ZYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYYZ() => new Vector4I17F15(Repr.ZYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYZX() => new Vector4I17F15(Repr.ZYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYZY() => new Vector4I17F15(Repr.ZYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYZZ() => new Vector4I17F15(Repr.ZYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZXX() => new Vector4I17F15(Repr.ZZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZXY() => new Vector4I17F15(Repr.ZZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZXZ() => new Vector4I17F15(Repr.ZZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZYX() => new Vector4I17F15(Repr.ZZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZYY() => new Vector4I17F15(Repr.ZZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZYZ() => new Vector4I17F15(Repr.ZZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZZX() => new Vector4I17F15(Repr.ZZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZZY() => new Vector4I17F15(Repr.ZZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZZZ() => new Vector4I17F15(Repr.ZZZZ());

        #endregion

    }
} // namespace Intar1991
