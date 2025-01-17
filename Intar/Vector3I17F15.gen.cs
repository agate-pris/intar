using System;
using System.Runtime.CompilerServices;

namespace Intar {
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
        #region Indexer
        public I17F15 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I17F15.FromBits(Repr[index]);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr[index] = value.Bits;
        }
        #endregion
        #region Conversion
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

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        Vector3I17F15(Vector3Int32 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15(I17F15 x, I17F15 y, I17F15 z) : this(new Vector3Int32(x.Bits, y.Bits, z.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15(I17F15 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 FromRepr(Vector3Int32 repr) {
            return new Vector3I17F15(repr);
        }
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
        public static Vector3I17F15 operator +(I17F15 a, Vector3I17F15 b) {
            return new Vector3I17F15(a.Bits + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator +(Vector3I17F15 a, I17F15 b) {
            return new Vector3I17F15(a.Repr + b.Bits);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator -(Vector3I17F15 a, Vector3I17F15 b) {
            return new Vector3I17F15(a.Repr - b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator -(I17F15 a, Vector3I17F15 b) {
            return new Vector3I17F15(a.Bits - b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator -(Vector3I17F15 a, I17F15 b) {
            return new Vector3I17F15(a.Repr - b.Bits);
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
        #region IsNegative, Abs
        public Vector3Bool IsNegative() => Repr.IsNegative();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 Abs() => new Vector3I17F15(Repr.Abs());

        // 符号なし固定小数点数ベクトル型は定義されていないため
        // UnsignedAbs と AbsDiff は定義されない.
        #endregion
        #region Half, Twice
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I17F15 Half() => new Vector3I17F15(Repr.Half());
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I17F15 Twice() => new Vector3I17F15(Repr.Twice());
        #endregion
        #region Cross, Dot, LengthSquared, Length, DistanceSquared, Distance
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I34F30 Cross(Vector3I17F15 other) {
            var tmp = Repr.Cross(other.Repr);
            return Vector3I34F30.FromRepr(tmp);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 Dot(Vector3I17F15 other) {
            return I34F30.FromBits(Repr.Dot(other.Repr));
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 DistanceSquared(Vector3I17F15 other) {
            return U34F30.FromBits(Repr.DistanceSquared(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 Distance(Vector3I17F15 other) {
            return U17F15.FromBits(Repr.Distance(other.Repr));
        }
        #endregion
        #region Normalize
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
        #endregion
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 X0() => Vector2I17F15.FromRepr(Repr.X0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 X1() => Vector2I17F15.FromRepr(Repr.X1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XX() => Vector2I17F15.FromRepr(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XY() => Vector2I17F15.FromRepr(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XZ() => Vector2I17F15.FromRepr(Repr.XZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YX() => Vector2I17F15.FromRepr(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YY() => Vector2I17F15.FromRepr(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YZ() => Vector2I17F15.FromRepr(Repr.YZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 ZX() => Vector2I17F15.FromRepr(Repr.ZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 ZY() => Vector2I17F15.FromRepr(Repr.ZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 ZZ() => Vector2I17F15.FromRepr(Repr.ZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XY0() => FromRepr(Repr.XY0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XY1() => FromRepr(Repr.XY1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXX() => FromRepr(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXY() => FromRepr(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXZ() => FromRepr(Repr.XXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYX() => FromRepr(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYY() => FromRepr(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYZ() => FromRepr(Repr.XYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XZX() => FromRepr(Repr.XZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XZY() => FromRepr(Repr.XZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XZZ() => FromRepr(Repr.XZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXX() => FromRepr(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXY() => FromRepr(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXZ() => FromRepr(Repr.YXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYX() => FromRepr(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYY() => FromRepr(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYZ() => FromRepr(Repr.YYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YZX() => FromRepr(Repr.YZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YZY() => FromRepr(Repr.YZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YZZ() => FromRepr(Repr.YZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZXX() => FromRepr(Repr.ZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZXY() => FromRepr(Repr.ZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZXZ() => FromRepr(Repr.ZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZYX() => FromRepr(Repr.ZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZYY() => FromRepr(Repr.ZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZYZ() => FromRepr(Repr.ZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZZX() => FromRepr(Repr.ZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZZY() => FromRepr(Repr.ZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZZZ() => FromRepr(Repr.ZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZ0() => Vector4I17F15.FromRepr(Repr.XYZ0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZ1() => Vector4I17F15.FromRepr(Repr.XYZ1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXX() => Vector4I17F15.FromRepr(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXY() => Vector4I17F15.FromRepr(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXZ() => Vector4I17F15.FromRepr(Repr.XXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYX() => Vector4I17F15.FromRepr(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYY() => Vector4I17F15.FromRepr(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYZ() => Vector4I17F15.FromRepr(Repr.XXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXZX() => Vector4I17F15.FromRepr(Repr.XXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXZY() => Vector4I17F15.FromRepr(Repr.XXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXZZ() => Vector4I17F15.FromRepr(Repr.XXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXX() => Vector4I17F15.FromRepr(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXY() => Vector4I17F15.FromRepr(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXZ() => Vector4I17F15.FromRepr(Repr.XYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYX() => Vector4I17F15.FromRepr(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYY() => Vector4I17F15.FromRepr(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYZ() => Vector4I17F15.FromRepr(Repr.XYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZX() => Vector4I17F15.FromRepr(Repr.XYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZY() => Vector4I17F15.FromRepr(Repr.XYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZZ() => Vector4I17F15.FromRepr(Repr.XYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZXX() => Vector4I17F15.FromRepr(Repr.XZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZXY() => Vector4I17F15.FromRepr(Repr.XZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZXZ() => Vector4I17F15.FromRepr(Repr.XZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZYX() => Vector4I17F15.FromRepr(Repr.XZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZYY() => Vector4I17F15.FromRepr(Repr.XZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZYZ() => Vector4I17F15.FromRepr(Repr.XZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZZX() => Vector4I17F15.FromRepr(Repr.XZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZZY() => Vector4I17F15.FromRepr(Repr.XZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZZZ() => Vector4I17F15.FromRepr(Repr.XZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXX() => Vector4I17F15.FromRepr(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXY() => Vector4I17F15.FromRepr(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXZ() => Vector4I17F15.FromRepr(Repr.YXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYX() => Vector4I17F15.FromRepr(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYY() => Vector4I17F15.FromRepr(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYZ() => Vector4I17F15.FromRepr(Repr.YXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXZX() => Vector4I17F15.FromRepr(Repr.YXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXZY() => Vector4I17F15.FromRepr(Repr.YXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXZZ() => Vector4I17F15.FromRepr(Repr.YXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXX() => Vector4I17F15.FromRepr(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXY() => Vector4I17F15.FromRepr(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXZ() => Vector4I17F15.FromRepr(Repr.YYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYX() => Vector4I17F15.FromRepr(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYY() => Vector4I17F15.FromRepr(Repr.YYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYZ() => Vector4I17F15.FromRepr(Repr.YYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYZX() => Vector4I17F15.FromRepr(Repr.YYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYZY() => Vector4I17F15.FromRepr(Repr.YYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYZZ() => Vector4I17F15.FromRepr(Repr.YYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZXX() => Vector4I17F15.FromRepr(Repr.YZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZXY() => Vector4I17F15.FromRepr(Repr.YZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZXZ() => Vector4I17F15.FromRepr(Repr.YZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZYX() => Vector4I17F15.FromRepr(Repr.YZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZYY() => Vector4I17F15.FromRepr(Repr.YZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZYZ() => Vector4I17F15.FromRepr(Repr.YZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZZX() => Vector4I17F15.FromRepr(Repr.YZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZZY() => Vector4I17F15.FromRepr(Repr.YZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZZZ() => Vector4I17F15.FromRepr(Repr.YZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXXX() => Vector4I17F15.FromRepr(Repr.ZXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXXY() => Vector4I17F15.FromRepr(Repr.ZXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXXZ() => Vector4I17F15.FromRepr(Repr.ZXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXYX() => Vector4I17F15.FromRepr(Repr.ZXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXYY() => Vector4I17F15.FromRepr(Repr.ZXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXYZ() => Vector4I17F15.FromRepr(Repr.ZXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXZX() => Vector4I17F15.FromRepr(Repr.ZXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXZY() => Vector4I17F15.FromRepr(Repr.ZXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXZZ() => Vector4I17F15.FromRepr(Repr.ZXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYXX() => Vector4I17F15.FromRepr(Repr.ZYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYXY() => Vector4I17F15.FromRepr(Repr.ZYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYXZ() => Vector4I17F15.FromRepr(Repr.ZYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYYX() => Vector4I17F15.FromRepr(Repr.ZYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYYY() => Vector4I17F15.FromRepr(Repr.ZYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYYZ() => Vector4I17F15.FromRepr(Repr.ZYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYZX() => Vector4I17F15.FromRepr(Repr.ZYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYZY() => Vector4I17F15.FromRepr(Repr.ZYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYZZ() => Vector4I17F15.FromRepr(Repr.ZYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZXX() => Vector4I17F15.FromRepr(Repr.ZZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZXY() => Vector4I17F15.FromRepr(Repr.ZZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZXZ() => Vector4I17F15.FromRepr(Repr.ZZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZYX() => Vector4I17F15.FromRepr(Repr.ZZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZYY() => Vector4I17F15.FromRepr(Repr.ZZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZYZ() => Vector4I17F15.FromRepr(Repr.ZZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZZX() => Vector4I17F15.FromRepr(Repr.ZZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZZY() => Vector4I17F15.FromRepr(Repr.ZZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZZZ() => Vector4I17F15.FromRepr(Repr.ZZZZ());
        #endregion
    }
} // namespace Intar
