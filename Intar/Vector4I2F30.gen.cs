using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector4I2F30
    : IEquatable<Vector4I2F30>
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
        public I2F30 Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I2F30.FromBits(Repr.Z);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Z = value.Bits;
        }
        public I2F30 W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I2F30.FromBits(Repr.W);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.W = value.Bits;
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
        public static explicit operator System.Numerics.Vector4(Vector4I2F30 a) {
            return (System.Numerics.Vector4)a.Repr / I2F30.OneRepr;
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector4(Vector4I2F30 a) {
            return (UnityEngine.Vector4)a.Repr / I2F30.OneRepr;
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float4(Vector4I2F30 a) {
            return (Unity.Mathematics.float4)a.Repr / I2F30.OneRepr;
        }
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        Vector4I2F30(Vector4Int32 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(I2F30 x, I2F30 y, I2F30 z, I2F30 w) : this(new Vector4Int32(x.Bits, y.Bits, z.Bits, w.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30(I2F30 value) : this(value, value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 FromRepr(Vector4Int32 repr) {
            return new Vector4I2F30(repr);
        }
        #endregion
        #region Zero, One, UnitX, UnitY, UnitZ, UnitW
        public static readonly Vector4I2F30 Zero = new Vector4I2F30(I2F30.Zero);
        public static readonly Vector4I2F30 One = new Vector4I2F30(I2F30.One);
        public static readonly Vector4I2F30 UnitX = new Vector4I2F30(I2F30.One, I2F30.Zero, I2F30.Zero, I2F30.Zero);
        public static readonly Vector4I2F30 UnitY = new Vector4I2F30(I2F30.Zero, I2F30.One, I2F30.Zero, I2F30.Zero);
        public static readonly Vector4I2F30 UnitZ = new Vector4I2F30(I2F30.Zero, I2F30.Zero, I2F30.One, I2F30.Zero);
        public static readonly Vector4I2F30 UnitW = new Vector4I2F30(I2F30.Zero, I2F30.Zero, I2F30.Zero, I2F30.One);
        #endregion
        #region IAdditionOperators, ISubtractionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator +(Vector4I2F30 a, Vector4I2F30 b) {
            return new Vector4I2F30(a.Repr + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator +(I2F30 a, Vector4I2F30 b) {
            return new Vector4I2F30(a.Bits + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator +(Vector4I2F30 a, I2F30 b) {
            return new Vector4I2F30(a.Repr + b.Bits);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator -(Vector4I2F30 a, Vector4I2F30 b) {
            return new Vector4I2F30(a.Repr - b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator -(I2F30 a, Vector4I2F30 b) {
            return new Vector4I2F30(a.Bits - b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator -(Vector4I2F30 a, I2F30 b) {
            return new Vector4I2F30(a.Repr - b.Bits);
        }
        #endregion
        #region IMultiplyOperators, IDivisionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator *(Vector4I2F30 a, Vector4I2F30 b) {
            return new Vector4I2F30((Vector4Int32)(a.WideRepr * b.WideRepr / I2F30.OneRepr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator *(Vector4I2F30 a, I2F30 b) {
            return new Vector4I2F30((Vector4Int32)(a.WideRepr * b.Bits / I2F30.OneRepr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator *(I2F30 a, Vector4I2F30 b) {
            return b * a;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator /(Vector4I2F30 a, Vector4I2F30 b) {
            return new Vector4I2F30((Vector4Int32)(a.WideRepr * I2F30.OneRepr / b.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator /(Vector4I2F30 a, I2F30 b) {
            return new Vector4I2F30((Vector4Int32)(a.WideRepr * I2F30.OneRepr / b.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator /(I2F30 a, Vector4I2F30 b) {
            return new Vector4I2F30((Vector4Int32)(a.WideBits * I2F30.OneRepr / b.WideRepr));
        }
        #endregion
        #region IUnaryPlusOperators, IUnaryNegationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator +(Vector4I2F30 x) {
            return new Vector4I2F30(+x.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4I2F30 operator -(Vector4I2F30 x) {
            return new Vector4I2F30(-x.Repr);
        }
        #endregion
        #region IEqualityOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator ==(Vector4I2F30 lhs, Vector4I2F30 rhs) => lhs.Repr == rhs.Repr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4Bool operator !=(Vector4I2F30 lhs, Vector4I2F30 rhs) => lhs.Repr != rhs.Repr;
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is Vector4I2F30 o && Equals(o);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4I2F30 other) {
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
        public Vector4I2F30 Min(Vector4I2F30 other) {
            return new Vector4I2F30(Repr.Min(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 Max(Vector4I2F30 other) {
            return new Vector4I2F30(Repr.Max(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 Clamp(I2F30 min, I2F30 max) {
            return new Vector4I2F30(Repr.Clamp(min.Bits, max.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 Clamp(Vector4I2F30 min, Vector4I2F30 max) {
            return new Vector4I2F30(Repr.Clamp(min.Repr, max.Repr));
        }
        #endregion
        #region IsNegative, Abs
        public Vector4Bool IsNegative() => Repr.IsNegative();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30 Abs() => new Vector4I2F30(Repr.Abs());

        // 符号なし固定小数点数ベクトル型は定義されていないため
        // UnsignedAbs と AbsDiff は定義されない.
        #endregion
        #region Half, Twice
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector4I2F30 Half() => new Vector4I2F30(Repr.Half());
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector4I2F30 Twice() => new Vector4I2F30(Repr.Twice());
        #endregion
        #region Dot, LengthSquared, Length, DistanceSquared, Distance

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I4F60 Dot(Vector4I2F30 other) {
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F60 DistanceSquared(Vector4I2F30 other) {
            return U4F60.FromBits(Repr.DistanceSquared(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U2F30 Distance(Vector4I2F30 other) {
            return U2F30.FromBits(Repr.Distance(other.Repr));
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

            const uint fracOneTwo = I2F30.OneRepr / 2;
            var absNormalized = (Vector4Int32)(scaled.BigMul(fracOneTwo) / halfLength);

            return new Vector4Int32(
                isNegative.X ? -absNormalized.X : absNormalized.X,
                isNegative.Y ? -absNormalized.Y : absNormalized.Y,
                isNegative.Z ? -absNormalized.Z : absNormalized.Z,
                isNegative.W ? -absNormalized.W : absNormalized.W
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector4I2F30? Normalize() {
            var tmp = Normalize(Repr);
            if (tmp == null) {
                return null;
            }
            return new Vector4I2F30(tmp.Value);
        }
        #endregion
        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 X0() => Vector2I2F30.FromRepr(Repr.X0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 X1() => Vector2I2F30.FromRepr(Repr.X1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XX() => Vector2I2F30.FromRepr(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XY() => Vector2I2F30.FromRepr(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XZ() => Vector2I2F30.FromRepr(Repr.XZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 XW() => Vector2I2F30.FromRepr(Repr.XW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YX() => Vector2I2F30.FromRepr(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YY() => Vector2I2F30.FromRepr(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YZ() => Vector2I2F30.FromRepr(Repr.YZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 YW() => Vector2I2F30.FromRepr(Repr.YW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 ZX() => Vector2I2F30.FromRepr(Repr.ZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 ZY() => Vector2I2F30.FromRepr(Repr.ZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 ZZ() => Vector2I2F30.FromRepr(Repr.ZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 ZW() => Vector2I2F30.FromRepr(Repr.ZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 WX() => Vector2I2F30.FromRepr(Repr.WX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 WY() => Vector2I2F30.FromRepr(Repr.WY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 WZ() => Vector2I2F30.FromRepr(Repr.WZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I2F30 WW() => Vector2I2F30.FromRepr(Repr.WW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XY0() => Vector3I2F30.FromRepr(Repr.XY0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XY1() => Vector3I2F30.FromRepr(Repr.XY1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXX() => Vector3I2F30.FromRepr(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXY() => Vector3I2F30.FromRepr(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXZ() => Vector3I2F30.FromRepr(Repr.XXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XXW() => Vector3I2F30.FromRepr(Repr.XXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYX() => Vector3I2F30.FromRepr(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYY() => Vector3I2F30.FromRepr(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYZ() => Vector3I2F30.FromRepr(Repr.XYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XYW() => Vector3I2F30.FromRepr(Repr.XYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XZX() => Vector3I2F30.FromRepr(Repr.XZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XZY() => Vector3I2F30.FromRepr(Repr.XZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XZZ() => Vector3I2F30.FromRepr(Repr.XZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XZW() => Vector3I2F30.FromRepr(Repr.XZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XWX() => Vector3I2F30.FromRepr(Repr.XWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XWY() => Vector3I2F30.FromRepr(Repr.XWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XWZ() => Vector3I2F30.FromRepr(Repr.XWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 XWW() => Vector3I2F30.FromRepr(Repr.XWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXX() => Vector3I2F30.FromRepr(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXY() => Vector3I2F30.FromRepr(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXZ() => Vector3I2F30.FromRepr(Repr.YXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YXW() => Vector3I2F30.FromRepr(Repr.YXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYX() => Vector3I2F30.FromRepr(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYY() => Vector3I2F30.FromRepr(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYZ() => Vector3I2F30.FromRepr(Repr.YYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YYW() => Vector3I2F30.FromRepr(Repr.YYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YZX() => Vector3I2F30.FromRepr(Repr.YZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YZY() => Vector3I2F30.FromRepr(Repr.YZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YZZ() => Vector3I2F30.FromRepr(Repr.YZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YZW() => Vector3I2F30.FromRepr(Repr.YZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YWX() => Vector3I2F30.FromRepr(Repr.YWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YWY() => Vector3I2F30.FromRepr(Repr.YWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YWZ() => Vector3I2F30.FromRepr(Repr.YWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 YWW() => Vector3I2F30.FromRepr(Repr.YWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZXX() => Vector3I2F30.FromRepr(Repr.ZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZXY() => Vector3I2F30.FromRepr(Repr.ZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZXZ() => Vector3I2F30.FromRepr(Repr.ZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZXW() => Vector3I2F30.FromRepr(Repr.ZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZYX() => Vector3I2F30.FromRepr(Repr.ZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZYY() => Vector3I2F30.FromRepr(Repr.ZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZYZ() => Vector3I2F30.FromRepr(Repr.ZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZYW() => Vector3I2F30.FromRepr(Repr.ZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZZX() => Vector3I2F30.FromRepr(Repr.ZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZZY() => Vector3I2F30.FromRepr(Repr.ZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZZZ() => Vector3I2F30.FromRepr(Repr.ZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZZW() => Vector3I2F30.FromRepr(Repr.ZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZWX() => Vector3I2F30.FromRepr(Repr.ZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZWY() => Vector3I2F30.FromRepr(Repr.ZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZWZ() => Vector3I2F30.FromRepr(Repr.ZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 ZWW() => Vector3I2F30.FromRepr(Repr.ZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WXX() => Vector3I2F30.FromRepr(Repr.WXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WXY() => Vector3I2F30.FromRepr(Repr.WXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WXZ() => Vector3I2F30.FromRepr(Repr.WXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WXW() => Vector3I2F30.FromRepr(Repr.WXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WYX() => Vector3I2F30.FromRepr(Repr.WYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WYY() => Vector3I2F30.FromRepr(Repr.WYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WYZ() => Vector3I2F30.FromRepr(Repr.WYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WYW() => Vector3I2F30.FromRepr(Repr.WYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WZX() => Vector3I2F30.FromRepr(Repr.WZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WZY() => Vector3I2F30.FromRepr(Repr.WZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WZZ() => Vector3I2F30.FromRepr(Repr.WZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WZW() => Vector3I2F30.FromRepr(Repr.WZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WWX() => Vector3I2F30.FromRepr(Repr.WWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WWY() => Vector3I2F30.FromRepr(Repr.WWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WWZ() => Vector3I2F30.FromRepr(Repr.WWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I2F30 WWW() => Vector3I2F30.FromRepr(Repr.WWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZ0() => FromRepr(Repr.XYZ0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZ1() => FromRepr(Repr.XYZ1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXX() => FromRepr(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXY() => FromRepr(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXZ() => FromRepr(Repr.XXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXXW() => FromRepr(Repr.XXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYX() => FromRepr(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYY() => FromRepr(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYZ() => FromRepr(Repr.XXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXYW() => FromRepr(Repr.XXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXZX() => FromRepr(Repr.XXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXZY() => FromRepr(Repr.XXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXZZ() => FromRepr(Repr.XXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXZW() => FromRepr(Repr.XXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXWX() => FromRepr(Repr.XXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXWY() => FromRepr(Repr.XXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXWZ() => FromRepr(Repr.XXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XXWW() => FromRepr(Repr.XXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXX() => FromRepr(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXY() => FromRepr(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXZ() => FromRepr(Repr.XYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYXW() => FromRepr(Repr.XYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYX() => FromRepr(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYY() => FromRepr(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYZ() => FromRepr(Repr.XYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYYW() => FromRepr(Repr.XYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZX() => FromRepr(Repr.XYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZY() => FromRepr(Repr.XYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZZ() => FromRepr(Repr.XYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYZW() => FromRepr(Repr.XYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYWX() => FromRepr(Repr.XYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYWY() => FromRepr(Repr.XYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYWZ() => FromRepr(Repr.XYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XYWW() => FromRepr(Repr.XYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZXX() => FromRepr(Repr.XZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZXY() => FromRepr(Repr.XZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZXZ() => FromRepr(Repr.XZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZXW() => FromRepr(Repr.XZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZYX() => FromRepr(Repr.XZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZYY() => FromRepr(Repr.XZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZYZ() => FromRepr(Repr.XZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZYW() => FromRepr(Repr.XZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZZX() => FromRepr(Repr.XZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZZY() => FromRepr(Repr.XZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZZZ() => FromRepr(Repr.XZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZZW() => FromRepr(Repr.XZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZWX() => FromRepr(Repr.XZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZWY() => FromRepr(Repr.XZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZWZ() => FromRepr(Repr.XZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XZWW() => FromRepr(Repr.XZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWXX() => FromRepr(Repr.XWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWXY() => FromRepr(Repr.XWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWXZ() => FromRepr(Repr.XWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWXW() => FromRepr(Repr.XWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWYX() => FromRepr(Repr.XWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWYY() => FromRepr(Repr.XWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWYZ() => FromRepr(Repr.XWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWYW() => FromRepr(Repr.XWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWZX() => FromRepr(Repr.XWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWZY() => FromRepr(Repr.XWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWZZ() => FromRepr(Repr.XWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWZW() => FromRepr(Repr.XWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWWX() => FromRepr(Repr.XWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWWY() => FromRepr(Repr.XWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWWZ() => FromRepr(Repr.XWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 XWWW() => FromRepr(Repr.XWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXX() => FromRepr(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXY() => FromRepr(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXZ() => FromRepr(Repr.YXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXXW() => FromRepr(Repr.YXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYX() => FromRepr(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYY() => FromRepr(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYZ() => FromRepr(Repr.YXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXYW() => FromRepr(Repr.YXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXZX() => FromRepr(Repr.YXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXZY() => FromRepr(Repr.YXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXZZ() => FromRepr(Repr.YXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXZW() => FromRepr(Repr.YXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXWX() => FromRepr(Repr.YXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXWY() => FromRepr(Repr.YXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXWZ() => FromRepr(Repr.YXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YXWW() => FromRepr(Repr.YXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXX() => FromRepr(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXY() => FromRepr(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXZ() => FromRepr(Repr.YYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYXW() => FromRepr(Repr.YYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYX() => FromRepr(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYY() => FromRepr(Repr.YYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYZ() => FromRepr(Repr.YYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYYW() => FromRepr(Repr.YYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYZX() => FromRepr(Repr.YYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYZY() => FromRepr(Repr.YYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYZZ() => FromRepr(Repr.YYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYZW() => FromRepr(Repr.YYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYWX() => FromRepr(Repr.YYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYWY() => FromRepr(Repr.YYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYWZ() => FromRepr(Repr.YYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YYWW() => FromRepr(Repr.YYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZXX() => FromRepr(Repr.YZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZXY() => FromRepr(Repr.YZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZXZ() => FromRepr(Repr.YZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZXW() => FromRepr(Repr.YZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZYX() => FromRepr(Repr.YZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZYY() => FromRepr(Repr.YZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZYZ() => FromRepr(Repr.YZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZYW() => FromRepr(Repr.YZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZZX() => FromRepr(Repr.YZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZZY() => FromRepr(Repr.YZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZZZ() => FromRepr(Repr.YZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZZW() => FromRepr(Repr.YZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZWX() => FromRepr(Repr.YZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZWY() => FromRepr(Repr.YZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZWZ() => FromRepr(Repr.YZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YZWW() => FromRepr(Repr.YZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWXX() => FromRepr(Repr.YWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWXY() => FromRepr(Repr.YWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWXZ() => FromRepr(Repr.YWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWXW() => FromRepr(Repr.YWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWYX() => FromRepr(Repr.YWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWYY() => FromRepr(Repr.YWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWYZ() => FromRepr(Repr.YWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWYW() => FromRepr(Repr.YWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWZX() => FromRepr(Repr.YWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWZY() => FromRepr(Repr.YWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWZZ() => FromRepr(Repr.YWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWZW() => FromRepr(Repr.YWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWWX() => FromRepr(Repr.YWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWWY() => FromRepr(Repr.YWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWWZ() => FromRepr(Repr.YWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 YWWW() => FromRepr(Repr.YWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXXX() => FromRepr(Repr.ZXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXXY() => FromRepr(Repr.ZXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXXZ() => FromRepr(Repr.ZXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXXW() => FromRepr(Repr.ZXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXYX() => FromRepr(Repr.ZXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXYY() => FromRepr(Repr.ZXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXYZ() => FromRepr(Repr.ZXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXYW() => FromRepr(Repr.ZXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXZX() => FromRepr(Repr.ZXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXZY() => FromRepr(Repr.ZXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXZZ() => FromRepr(Repr.ZXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXZW() => FromRepr(Repr.ZXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXWX() => FromRepr(Repr.ZXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXWY() => FromRepr(Repr.ZXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXWZ() => FromRepr(Repr.ZXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZXWW() => FromRepr(Repr.ZXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYXX() => FromRepr(Repr.ZYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYXY() => FromRepr(Repr.ZYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYXZ() => FromRepr(Repr.ZYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYXW() => FromRepr(Repr.ZYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYYX() => FromRepr(Repr.ZYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYYY() => FromRepr(Repr.ZYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYYZ() => FromRepr(Repr.ZYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYYW() => FromRepr(Repr.ZYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYZX() => FromRepr(Repr.ZYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYZY() => FromRepr(Repr.ZYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYZZ() => FromRepr(Repr.ZYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYZW() => FromRepr(Repr.ZYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYWX() => FromRepr(Repr.ZYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYWY() => FromRepr(Repr.ZYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYWZ() => FromRepr(Repr.ZYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZYWW() => FromRepr(Repr.ZYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZXX() => FromRepr(Repr.ZZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZXY() => FromRepr(Repr.ZZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZXZ() => FromRepr(Repr.ZZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZXW() => FromRepr(Repr.ZZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZYX() => FromRepr(Repr.ZZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZYY() => FromRepr(Repr.ZZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZYZ() => FromRepr(Repr.ZZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZYW() => FromRepr(Repr.ZZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZZX() => FromRepr(Repr.ZZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZZY() => FromRepr(Repr.ZZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZZZ() => FromRepr(Repr.ZZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZZW() => FromRepr(Repr.ZZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZWX() => FromRepr(Repr.ZZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZWY() => FromRepr(Repr.ZZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZWZ() => FromRepr(Repr.ZZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZZWW() => FromRepr(Repr.ZZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWXX() => FromRepr(Repr.ZWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWXY() => FromRepr(Repr.ZWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWXZ() => FromRepr(Repr.ZWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWXW() => FromRepr(Repr.ZWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWYX() => FromRepr(Repr.ZWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWYY() => FromRepr(Repr.ZWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWYZ() => FromRepr(Repr.ZWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWYW() => FromRepr(Repr.ZWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWZX() => FromRepr(Repr.ZWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWZY() => FromRepr(Repr.ZWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWZZ() => FromRepr(Repr.ZWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWZW() => FromRepr(Repr.ZWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWWX() => FromRepr(Repr.ZWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWWY() => FromRepr(Repr.ZWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWWZ() => FromRepr(Repr.ZWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 ZWWW() => FromRepr(Repr.ZWWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXXX() => FromRepr(Repr.WXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXXY() => FromRepr(Repr.WXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXXZ() => FromRepr(Repr.WXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXXW() => FromRepr(Repr.WXXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXYX() => FromRepr(Repr.WXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXYY() => FromRepr(Repr.WXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXYZ() => FromRepr(Repr.WXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXYW() => FromRepr(Repr.WXYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXZX() => FromRepr(Repr.WXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXZY() => FromRepr(Repr.WXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXZZ() => FromRepr(Repr.WXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXZW() => FromRepr(Repr.WXZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXWX() => FromRepr(Repr.WXWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXWY() => FromRepr(Repr.WXWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXWZ() => FromRepr(Repr.WXWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WXWW() => FromRepr(Repr.WXWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYXX() => FromRepr(Repr.WYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYXY() => FromRepr(Repr.WYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYXZ() => FromRepr(Repr.WYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYXW() => FromRepr(Repr.WYXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYYX() => FromRepr(Repr.WYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYYY() => FromRepr(Repr.WYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYYZ() => FromRepr(Repr.WYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYYW() => FromRepr(Repr.WYYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYZX() => FromRepr(Repr.WYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYZY() => FromRepr(Repr.WYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYZZ() => FromRepr(Repr.WYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYZW() => FromRepr(Repr.WYZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYWX() => FromRepr(Repr.WYWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYWY() => FromRepr(Repr.WYWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYWZ() => FromRepr(Repr.WYWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WYWW() => FromRepr(Repr.WYWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZXX() => FromRepr(Repr.WZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZXY() => FromRepr(Repr.WZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZXZ() => FromRepr(Repr.WZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZXW() => FromRepr(Repr.WZXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZYX() => FromRepr(Repr.WZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZYY() => FromRepr(Repr.WZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZYZ() => FromRepr(Repr.WZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZYW() => FromRepr(Repr.WZYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZZX() => FromRepr(Repr.WZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZZY() => FromRepr(Repr.WZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZZZ() => FromRepr(Repr.WZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZZW() => FromRepr(Repr.WZZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZWX() => FromRepr(Repr.WZWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZWY() => FromRepr(Repr.WZWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZWZ() => FromRepr(Repr.WZWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WZWW() => FromRepr(Repr.WZWW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWXX() => FromRepr(Repr.WWXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWXY() => FromRepr(Repr.WWXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWXZ() => FromRepr(Repr.WWXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWXW() => FromRepr(Repr.WWXW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWYX() => FromRepr(Repr.WWYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWYY() => FromRepr(Repr.WWYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWYZ() => FromRepr(Repr.WWYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWYW() => FromRepr(Repr.WWYW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWZX() => FromRepr(Repr.WWZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWZY() => FromRepr(Repr.WWZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWZZ() => FromRepr(Repr.WWZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWZW() => FromRepr(Repr.WWZW());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWWX() => FromRepr(Repr.WWWX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWWY() => FromRepr(Repr.WWWY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWWZ() => FromRepr(Repr.WWWZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I2F30 WWWW() => FromRepr(Repr.WWWW());
        #endregion
    }
} // namespace Intar
