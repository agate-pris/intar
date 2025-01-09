using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector4I17F15
    : IEquatable<Vector4I17F15>
    , IFormattable {
        #region Fields

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector4Int32 Repr;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        #region WideRepr
        internal Vector4Int64 WideRepr {
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
        public I17F15 W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I17F15.FromBits(Repr.W);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.W = value.Bits;
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
        public static explicit operator System.Numerics.Vector4(Vector4I17F15 a) {
            return (System.Numerics.Vector4)a.Repr / I17F15.OneRepr;
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector4(Vector4I17F15 a) {
            return (UnityEngine.Vector4)a.Repr / I17F15.OneRepr;
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float4(Vector4I17F15 a) {
            return (Unity.Mathematics.float4)a.Repr / I17F15.OneRepr;
        }
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        Vector4I17F15(Vector4Int32 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(I17F15 x, I17F15 y, I17F15 z, I17F15 w) : this(new Vector4Int32(x.Bits, y.Bits, z.Bits, w.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15(I17F15 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 FromRepr(Vector4Int32 repr) {
            return new Vector4I17F15(repr);
        }
        #endregion
        #region Zero, One, UnitX, UnitY, UnitZ, UnitW
        public static readonly Vector4I17F15 Zero = new Vector4I17F15(I17F15.Zero);
        public static readonly Vector4I17F15 One = new Vector4I17F15(I17F15.One);
        public static readonly Vector4I17F15 UnitX = new Vector4I17F15(I17F15.One, I17F15.Zero, I17F15.Zero, I17F15.Zero);
        public static readonly Vector4I17F15 UnitY = new Vector4I17F15(I17F15.Zero, I17F15.One, I17F15.Zero, I17F15.Zero);
        public static readonly Vector4I17F15 UnitZ = new Vector4I17F15(I17F15.Zero, I17F15.Zero, I17F15.One, I17F15.Zero);
        public static readonly Vector4I17F15 UnitW = new Vector4I17F15(I17F15.Zero, I17F15.Zero, I17F15.Zero, I17F15.One);
        #endregion
        #region IAdditionOperators, ISubtractionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator +(Vector4I17F15 a, Vector4I17F15 b) {
            return new Vector4I17F15(a.Repr + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator -(Vector4I17F15 a, Vector4I17F15 b) {
            return new Vector4I17F15(a.Repr - b.Repr);
        }
        #endregion
        #region IMultiplyOperators, IDivisionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator *(Vector4I17F15 a, Vector4I17F15 b) {
            return new Vector4I17F15((Vector4Int32)(a.WideRepr * b.WideRepr / I17F15.OneRepr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator *(Vector4I17F15 a, I17F15 b) {
            return new Vector4I17F15((Vector4Int32)(a.WideRepr * b.Bits / I17F15.OneRepr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator *(I17F15 a, Vector4I17F15 b) {
            return b * a;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator /(Vector4I17F15 a, Vector4I17F15 b) {
            return new Vector4I17F15((Vector4Int32)(a.WideRepr * I17F15.OneRepr / b.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator /(Vector4I17F15 a, I17F15 b) {
            return new Vector4I17F15((Vector4Int32)(a.WideRepr * I17F15.OneRepr / b.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator /(I17F15 a, Vector4I17F15 b) {
            return new Vector4I17F15((Vector4Int32)(a.WideBits * I17F15.OneRepr / b.WideRepr));
        }
        #endregion
        #region IUnaryPlusOperators, IUnaryNegationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator +(Vector4I17F15 x) {
            return new Vector4I17F15(+x.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I17F15 operator -(Vector4I17F15 x) {
            return new Vector4I17F15(-x.Repr);
        }
        #endregion
        #region IEqualityOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator ==(Vector4I17F15 lhs, Vector4I17F15 rhs) => lhs.Repr == rhs.Repr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(Vector4I17F15 lhs, Vector4I17F15 rhs) => lhs.Repr != rhs.Repr;
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is Vector4I17F15 o && Equals(o);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I17F15 other) {
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
        public Vector4I17F15 Min(Vector4I17F15 other) {
            return new Vector4I17F15(Repr.Min(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15 Max(Vector4I17F15 other) {
            return new Vector4I17F15(Repr.Max(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15 Clamp(I17F15 min, I17F15 max) {
            return new Vector4I17F15(Repr.Clamp(min.Bits, max.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15 Clamp(Vector4I17F15 min, Vector4I17F15 max) {
            return new Vector4I17F15(Repr.Clamp(min.Repr, max.Repr));
        }
        #endregion
        #region IsNegative, Abs
        public Vector4Bool IsNegative() => Repr.IsNegative();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15 Abs() => new Vector4I17F15(Repr.Abs());

        // 符号なし固定小数点数ベクトル型は定義されていないため
        // UnsignedAbs と AbsDiff は定義されない.
        #endregion
        #region Half, Twice
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector4I17F15 Half() => new Vector4I17F15(Repr.Half());
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector4I17F15 Twice() => new Vector4I17F15(Repr.Twice());
        #endregion
        #region Dot, LengthSquared, Length, DistanceSquared, Distance
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I34F30 Dot(Vector4I17F15 other) {
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
        public U34F30 DistanceSquared(Vector4I17F15 other) {
            return U34F30.FromBits(Repr.DistanceSquared(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 Distance(Vector4I17F15 other) {
            return U17F15.FromBits(Repr.Distance(other.Repr));
        }
        #endregion
        #region Normalize
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Vector4Int32? Normalize(Vector4Int32 v) {

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
            var absNormalized = (Vector4Int32)(scaled.BigMul(fracOneTwo) / halfLength);

            return new Vector4Int32(
                isNegative.X ? -absNormalized.X : absNormalized.X,
                isNegative.Y ? -absNormalized.Y : absNormalized.Y,
                isNegative.Z ? -absNormalized.Z : absNormalized.Z,
                isNegative.W ? -absNormalized.W : absNormalized.W
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I17F15? Normalize() {
            var tmp = Normalize(Repr);
            if (tmp == null) {
                return null;
            }
            return new Vector4I17F15(tmp.Value);
        }
        #endregion
        #region Sin/Cos

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 SinP2() => new Vector4I2F30(
            X.SinP2(),
            Y.SinP2(),
            Z.SinP2(),
            W.SinP2());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 SinP3() => new Vector4I2F30(
            X.SinP3(),
            Y.SinP3(),
            Z.SinP3(),
            W.SinP3());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 SinP4() => new Vector4I2F30(
            X.SinP4(),
            Y.SinP4(),
            Z.SinP4(),
            W.SinP4());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 SinP5() => new Vector4I2F30(
            X.SinP5(),
            Y.SinP5(),
            Z.SinP5(),
            W.SinP5());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 CosP2() => new Vector4I2F30(
            X.CosP2(),
            Y.CosP2(),
            Z.CosP2(),
            W.CosP2());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 CosP3() => new Vector4I2F30(
            X.CosP3(),
            Y.CosP3(),
            Z.CosP3(),
            W.CosP3());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 CosP4() => new Vector4I2F30(
            X.CosP4(),
            Y.CosP4(),
            Z.CosP4(),
            W.CosP4());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 CosP5() => new Vector4I2F30(
            X.CosP5(),
            Y.CosP5(),
            Z.CosP5(),
            W.CosP5());

        #endregion
        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 X0() => Vector2I17F15.FromRepr(Repr.X0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 X1() => Vector2I17F15.FromRepr(Repr.X1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XX() => Vector2I17F15.FromRepr(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XY() => Vector2I17F15.FromRepr(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XZ() => Vector2I17F15.FromRepr(Repr.XZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 XW() => Vector2I17F15.FromRepr(Repr.XW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YX() => Vector2I17F15.FromRepr(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YY() => Vector2I17F15.FromRepr(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YZ() => Vector2I17F15.FromRepr(Repr.YZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 YW() => Vector2I17F15.FromRepr(Repr.YW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 ZX() => Vector2I17F15.FromRepr(Repr.ZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 ZY() => Vector2I17F15.FromRepr(Repr.ZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 ZZ() => Vector2I17F15.FromRepr(Repr.ZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 ZW() => Vector2I17F15.FromRepr(Repr.ZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 WX() => Vector2I17F15.FromRepr(Repr.WX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 WY() => Vector2I17F15.FromRepr(Repr.WY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 WZ() => Vector2I17F15.FromRepr(Repr.WZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I17F15 WW() => Vector2I17F15.FromRepr(Repr.WW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XY0() => Vector3I17F15.FromRepr(Repr.XY0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XY1() => Vector3I17F15.FromRepr(Repr.XY1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXX() => Vector3I17F15.FromRepr(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXY() => Vector3I17F15.FromRepr(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXZ() => Vector3I17F15.FromRepr(Repr.XXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XXW() => Vector3I17F15.FromRepr(Repr.XXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYX() => Vector3I17F15.FromRepr(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYY() => Vector3I17F15.FromRepr(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYZ() => Vector3I17F15.FromRepr(Repr.XYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XYW() => Vector3I17F15.FromRepr(Repr.XYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XZX() => Vector3I17F15.FromRepr(Repr.XZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XZY() => Vector3I17F15.FromRepr(Repr.XZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XZZ() => Vector3I17F15.FromRepr(Repr.XZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XZW() => Vector3I17F15.FromRepr(Repr.XZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XWX() => Vector3I17F15.FromRepr(Repr.XWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XWY() => Vector3I17F15.FromRepr(Repr.XWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XWZ() => Vector3I17F15.FromRepr(Repr.XWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 XWW() => Vector3I17F15.FromRepr(Repr.XWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXX() => Vector3I17F15.FromRepr(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXY() => Vector3I17F15.FromRepr(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXZ() => Vector3I17F15.FromRepr(Repr.YXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YXW() => Vector3I17F15.FromRepr(Repr.YXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYX() => Vector3I17F15.FromRepr(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYY() => Vector3I17F15.FromRepr(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYZ() => Vector3I17F15.FromRepr(Repr.YYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YYW() => Vector3I17F15.FromRepr(Repr.YYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YZX() => Vector3I17F15.FromRepr(Repr.YZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YZY() => Vector3I17F15.FromRepr(Repr.YZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YZZ() => Vector3I17F15.FromRepr(Repr.YZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YZW() => Vector3I17F15.FromRepr(Repr.YZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YWX() => Vector3I17F15.FromRepr(Repr.YWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YWY() => Vector3I17F15.FromRepr(Repr.YWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YWZ() => Vector3I17F15.FromRepr(Repr.YWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 YWW() => Vector3I17F15.FromRepr(Repr.YWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZXX() => Vector3I17F15.FromRepr(Repr.ZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZXY() => Vector3I17F15.FromRepr(Repr.ZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZXZ() => Vector3I17F15.FromRepr(Repr.ZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZXW() => Vector3I17F15.FromRepr(Repr.ZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZYX() => Vector3I17F15.FromRepr(Repr.ZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZYY() => Vector3I17F15.FromRepr(Repr.ZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZYZ() => Vector3I17F15.FromRepr(Repr.ZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZYW() => Vector3I17F15.FromRepr(Repr.ZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZZX() => Vector3I17F15.FromRepr(Repr.ZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZZY() => Vector3I17F15.FromRepr(Repr.ZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZZZ() => Vector3I17F15.FromRepr(Repr.ZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZZW() => Vector3I17F15.FromRepr(Repr.ZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZWX() => Vector3I17F15.FromRepr(Repr.ZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZWY() => Vector3I17F15.FromRepr(Repr.ZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZWZ() => Vector3I17F15.FromRepr(Repr.ZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 ZWW() => Vector3I17F15.FromRepr(Repr.ZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WXX() => Vector3I17F15.FromRepr(Repr.WXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WXY() => Vector3I17F15.FromRepr(Repr.WXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WXZ() => Vector3I17F15.FromRepr(Repr.WXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WXW() => Vector3I17F15.FromRepr(Repr.WXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WYX() => Vector3I17F15.FromRepr(Repr.WYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WYY() => Vector3I17F15.FromRepr(Repr.WYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WYZ() => Vector3I17F15.FromRepr(Repr.WYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WYW() => Vector3I17F15.FromRepr(Repr.WYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WZX() => Vector3I17F15.FromRepr(Repr.WZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WZY() => Vector3I17F15.FromRepr(Repr.WZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WZZ() => Vector3I17F15.FromRepr(Repr.WZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WZW() => Vector3I17F15.FromRepr(Repr.WZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WWX() => Vector3I17F15.FromRepr(Repr.WWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WWY() => Vector3I17F15.FromRepr(Repr.WWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WWZ() => Vector3I17F15.FromRepr(Repr.WWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I17F15 WWW() => Vector3I17F15.FromRepr(Repr.WWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZ0() => FromRepr(Repr.XYZ0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZ1() => FromRepr(Repr.XYZ1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXX() => FromRepr(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXY() => FromRepr(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXZ() => FromRepr(Repr.XXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXXW() => FromRepr(Repr.XXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYX() => FromRepr(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYY() => FromRepr(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYZ() => FromRepr(Repr.XXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXYW() => FromRepr(Repr.XXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXZX() => FromRepr(Repr.XXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXZY() => FromRepr(Repr.XXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXZZ() => FromRepr(Repr.XXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXZW() => FromRepr(Repr.XXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXWX() => FromRepr(Repr.XXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXWY() => FromRepr(Repr.XXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXWZ() => FromRepr(Repr.XXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XXWW() => FromRepr(Repr.XXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXX() => FromRepr(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXY() => FromRepr(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXZ() => FromRepr(Repr.XYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYXW() => FromRepr(Repr.XYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYX() => FromRepr(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYY() => FromRepr(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYZ() => FromRepr(Repr.XYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYYW() => FromRepr(Repr.XYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZX() => FromRepr(Repr.XYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZY() => FromRepr(Repr.XYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZZ() => FromRepr(Repr.XYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYZW() => FromRepr(Repr.XYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYWX() => FromRepr(Repr.XYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYWY() => FromRepr(Repr.XYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYWZ() => FromRepr(Repr.XYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XYWW() => FromRepr(Repr.XYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZXX() => FromRepr(Repr.XZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZXY() => FromRepr(Repr.XZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZXZ() => FromRepr(Repr.XZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZXW() => FromRepr(Repr.XZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZYX() => FromRepr(Repr.XZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZYY() => FromRepr(Repr.XZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZYZ() => FromRepr(Repr.XZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZYW() => FromRepr(Repr.XZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZZX() => FromRepr(Repr.XZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZZY() => FromRepr(Repr.XZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZZZ() => FromRepr(Repr.XZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZZW() => FromRepr(Repr.XZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZWX() => FromRepr(Repr.XZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZWY() => FromRepr(Repr.XZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZWZ() => FromRepr(Repr.XZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XZWW() => FromRepr(Repr.XZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWXX() => FromRepr(Repr.XWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWXY() => FromRepr(Repr.XWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWXZ() => FromRepr(Repr.XWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWXW() => FromRepr(Repr.XWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWYX() => FromRepr(Repr.XWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWYY() => FromRepr(Repr.XWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWYZ() => FromRepr(Repr.XWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWYW() => FromRepr(Repr.XWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWZX() => FromRepr(Repr.XWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWZY() => FromRepr(Repr.XWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWZZ() => FromRepr(Repr.XWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWZW() => FromRepr(Repr.XWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWWX() => FromRepr(Repr.XWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWWY() => FromRepr(Repr.XWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWWZ() => FromRepr(Repr.XWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 XWWW() => FromRepr(Repr.XWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXX() => FromRepr(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXY() => FromRepr(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXZ() => FromRepr(Repr.YXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXXW() => FromRepr(Repr.YXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYX() => FromRepr(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYY() => FromRepr(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYZ() => FromRepr(Repr.YXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXYW() => FromRepr(Repr.YXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXZX() => FromRepr(Repr.YXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXZY() => FromRepr(Repr.YXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXZZ() => FromRepr(Repr.YXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXZW() => FromRepr(Repr.YXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXWX() => FromRepr(Repr.YXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXWY() => FromRepr(Repr.YXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXWZ() => FromRepr(Repr.YXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YXWW() => FromRepr(Repr.YXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXX() => FromRepr(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXY() => FromRepr(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXZ() => FromRepr(Repr.YYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYXW() => FromRepr(Repr.YYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYX() => FromRepr(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYY() => FromRepr(Repr.YYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYZ() => FromRepr(Repr.YYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYYW() => FromRepr(Repr.YYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYZX() => FromRepr(Repr.YYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYZY() => FromRepr(Repr.YYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYZZ() => FromRepr(Repr.YYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYZW() => FromRepr(Repr.YYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYWX() => FromRepr(Repr.YYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYWY() => FromRepr(Repr.YYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYWZ() => FromRepr(Repr.YYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YYWW() => FromRepr(Repr.YYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZXX() => FromRepr(Repr.YZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZXY() => FromRepr(Repr.YZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZXZ() => FromRepr(Repr.YZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZXW() => FromRepr(Repr.YZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZYX() => FromRepr(Repr.YZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZYY() => FromRepr(Repr.YZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZYZ() => FromRepr(Repr.YZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZYW() => FromRepr(Repr.YZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZZX() => FromRepr(Repr.YZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZZY() => FromRepr(Repr.YZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZZZ() => FromRepr(Repr.YZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZZW() => FromRepr(Repr.YZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZWX() => FromRepr(Repr.YZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZWY() => FromRepr(Repr.YZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZWZ() => FromRepr(Repr.YZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YZWW() => FromRepr(Repr.YZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWXX() => FromRepr(Repr.YWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWXY() => FromRepr(Repr.YWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWXZ() => FromRepr(Repr.YWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWXW() => FromRepr(Repr.YWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWYX() => FromRepr(Repr.YWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWYY() => FromRepr(Repr.YWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWYZ() => FromRepr(Repr.YWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWYW() => FromRepr(Repr.YWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWZX() => FromRepr(Repr.YWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWZY() => FromRepr(Repr.YWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWZZ() => FromRepr(Repr.YWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWZW() => FromRepr(Repr.YWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWWX() => FromRepr(Repr.YWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWWY() => FromRepr(Repr.YWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWWZ() => FromRepr(Repr.YWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 YWWW() => FromRepr(Repr.YWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXXX() => FromRepr(Repr.ZXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXXY() => FromRepr(Repr.ZXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXXZ() => FromRepr(Repr.ZXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXXW() => FromRepr(Repr.ZXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXYX() => FromRepr(Repr.ZXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXYY() => FromRepr(Repr.ZXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXYZ() => FromRepr(Repr.ZXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXYW() => FromRepr(Repr.ZXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXZX() => FromRepr(Repr.ZXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXZY() => FromRepr(Repr.ZXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXZZ() => FromRepr(Repr.ZXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXZW() => FromRepr(Repr.ZXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXWX() => FromRepr(Repr.ZXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXWY() => FromRepr(Repr.ZXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXWZ() => FromRepr(Repr.ZXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZXWW() => FromRepr(Repr.ZXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYXX() => FromRepr(Repr.ZYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYXY() => FromRepr(Repr.ZYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYXZ() => FromRepr(Repr.ZYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYXW() => FromRepr(Repr.ZYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYYX() => FromRepr(Repr.ZYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYYY() => FromRepr(Repr.ZYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYYZ() => FromRepr(Repr.ZYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYYW() => FromRepr(Repr.ZYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYZX() => FromRepr(Repr.ZYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYZY() => FromRepr(Repr.ZYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYZZ() => FromRepr(Repr.ZYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYZW() => FromRepr(Repr.ZYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYWX() => FromRepr(Repr.ZYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYWY() => FromRepr(Repr.ZYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYWZ() => FromRepr(Repr.ZYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZYWW() => FromRepr(Repr.ZYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZXX() => FromRepr(Repr.ZZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZXY() => FromRepr(Repr.ZZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZXZ() => FromRepr(Repr.ZZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZXW() => FromRepr(Repr.ZZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZYX() => FromRepr(Repr.ZZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZYY() => FromRepr(Repr.ZZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZYZ() => FromRepr(Repr.ZZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZYW() => FromRepr(Repr.ZZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZZX() => FromRepr(Repr.ZZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZZY() => FromRepr(Repr.ZZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZZZ() => FromRepr(Repr.ZZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZZW() => FromRepr(Repr.ZZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZWX() => FromRepr(Repr.ZZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZWY() => FromRepr(Repr.ZZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZWZ() => FromRepr(Repr.ZZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZZWW() => FromRepr(Repr.ZZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWXX() => FromRepr(Repr.ZWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWXY() => FromRepr(Repr.ZWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWXZ() => FromRepr(Repr.ZWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWXW() => FromRepr(Repr.ZWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWYX() => FromRepr(Repr.ZWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWYY() => FromRepr(Repr.ZWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWYZ() => FromRepr(Repr.ZWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWYW() => FromRepr(Repr.ZWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWZX() => FromRepr(Repr.ZWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWZY() => FromRepr(Repr.ZWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWZZ() => FromRepr(Repr.ZWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWZW() => FromRepr(Repr.ZWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWWX() => FromRepr(Repr.ZWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWWY() => FromRepr(Repr.ZWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWWZ() => FromRepr(Repr.ZWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 ZWWW() => FromRepr(Repr.ZWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXXX() => FromRepr(Repr.WXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXXY() => FromRepr(Repr.WXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXXZ() => FromRepr(Repr.WXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXXW() => FromRepr(Repr.WXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXYX() => FromRepr(Repr.WXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXYY() => FromRepr(Repr.WXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXYZ() => FromRepr(Repr.WXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXYW() => FromRepr(Repr.WXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXZX() => FromRepr(Repr.WXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXZY() => FromRepr(Repr.WXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXZZ() => FromRepr(Repr.WXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXZW() => FromRepr(Repr.WXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXWX() => FromRepr(Repr.WXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXWY() => FromRepr(Repr.WXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXWZ() => FromRepr(Repr.WXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WXWW() => FromRepr(Repr.WXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYXX() => FromRepr(Repr.WYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYXY() => FromRepr(Repr.WYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYXZ() => FromRepr(Repr.WYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYXW() => FromRepr(Repr.WYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYYX() => FromRepr(Repr.WYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYYY() => FromRepr(Repr.WYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYYZ() => FromRepr(Repr.WYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYYW() => FromRepr(Repr.WYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYZX() => FromRepr(Repr.WYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYZY() => FromRepr(Repr.WYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYZZ() => FromRepr(Repr.WYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYZW() => FromRepr(Repr.WYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYWX() => FromRepr(Repr.WYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYWY() => FromRepr(Repr.WYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYWZ() => FromRepr(Repr.WYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WYWW() => FromRepr(Repr.WYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZXX() => FromRepr(Repr.WZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZXY() => FromRepr(Repr.WZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZXZ() => FromRepr(Repr.WZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZXW() => FromRepr(Repr.WZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZYX() => FromRepr(Repr.WZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZYY() => FromRepr(Repr.WZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZYZ() => FromRepr(Repr.WZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZYW() => FromRepr(Repr.WZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZZX() => FromRepr(Repr.WZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZZY() => FromRepr(Repr.WZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZZZ() => FromRepr(Repr.WZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZZW() => FromRepr(Repr.WZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZWX() => FromRepr(Repr.WZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZWY() => FromRepr(Repr.WZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZWZ() => FromRepr(Repr.WZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WZWW() => FromRepr(Repr.WZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWXX() => FromRepr(Repr.WWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWXY() => FromRepr(Repr.WWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWXZ() => FromRepr(Repr.WWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWXW() => FromRepr(Repr.WWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWYX() => FromRepr(Repr.WWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWYY() => FromRepr(Repr.WWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWYZ() => FromRepr(Repr.WWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWYW() => FromRepr(Repr.WWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWZX() => FromRepr(Repr.WWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWZY() => FromRepr(Repr.WWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWZZ() => FromRepr(Repr.WWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWZW() => FromRepr(Repr.WWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWWX() => FromRepr(Repr.WWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWWY() => FromRepr(Repr.WWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWWZ() => FromRepr(Repr.WWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I17F15 WWWW() => FromRepr(Repr.WWWW());
        #endregion
    }
} // namespace Intar
